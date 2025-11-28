// Namespace: UnityEngine.Splines
internal static class ArrayUtility // TypeDefIndex: 12517
{
	// Methods

	// RVA: -1 Offset: -1
	public static void RemoveAt<T>(ref T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65B1E0 Offset: 0x6597E0 VA: 0x18065B1E0
	|-ArrayUtility.RemoveAt<object>
	|-ArrayUtility.RemoveAt<SplineKnotIndex>
	|
	|-RVA: 0x65AE20 Offset: 0x659420 VA: 0x18065AE20
	|-ArrayUtility.RemoveAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void RemoveAt<T>(ref T[] array, IEnumerable<int> indices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65AFA0 Offset: 0x6595A0 VA: 0x18065AFA0
	|-ArrayUtility.RemoveAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SortedRemoveAt<T>(ref T[] array, IList<int> sorted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65BD60 Offset: 0x65A360 VA: 0x18065BD60
	|-ArrayUtility.SortedRemoveAt<SplineKnotIndex>
	|
	|-RVA: 0x65B720 Offset: 0x659D20 VA: 0x18065B720
	|-ArrayUtility.SortedRemoveAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Remove<T>(ref T[] array, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65B540 Offset: 0x659B40 VA: 0x18065B540
	|-ArrayUtility.Remove<object>
	|
	|-RVA: 0x65B630 Offset: 0x659C30 VA: 0x18065B630
	|-ArrayUtility.Remove<SplineKnotIndex>
	|
	|-RVA: 0x65B3E0 Offset: 0x6599E0 VA: 0x18065B3E0
	|-ArrayUtility.Remove<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Add<T>(ref T[] array, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x659310 Offset: 0x657910 VA: 0x180659310
	|-ArrayUtility.Add<object>
	|
	|-RVA: 0x6593A0 Offset: 0x6579A0 VA: 0x1806593A0
	|-ArrayUtility.Add<SplineKnotIndex>
	|
	|-RVA: 0x6591B0 Offset: 0x6577B0 VA: 0x1806591B0
	|-ArrayUtility.Add<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.Splines
public struct BezierCurve : IEquatable<BezierCurve> // TypeDefIndex: 12518
{
	// Fields
	public float3 P0; // 0x0
	public float3 P1; // 0xC
	public float3 P2; // 0x18
	public float3 P3; // 0x24

	// Properties
	public float3 Tangent0 { get; set; }
	public float3 Tangent1 { get; set; }

	// Methods

	// RVA: 0x1F8FA30 Offset: 0x1F8E030 VA: 0x181F8FA30
	public float3 get_Tangent0() { }

	// RVA: 0x2131D90 Offset: 0x2130390 VA: 0x182131D90
	public void set_Tangent0(float3 value) { }

	// RVA: 0x2131CD0 Offset: 0x21302D0 VA: 0x182131CD0
	public float3 get_Tangent1() { }

	// RVA: 0x2131DD0 Offset: 0x21303D0 VA: 0x182131DD0
	public void set_Tangent1(float3 value) { }

	// RVA: 0x21318C0 Offset: 0x212FEC0 VA: 0x1821318C0
	public void .ctor(float3 p0, float3 p1) { }

	// RVA: 0x2131BF0 Offset: 0x21301F0 VA: 0x182131BF0
	public void .ctor(float3 p0, float3 p1, float3 p2) { }

	// RVA: 0x1F79320 Offset: 0x1F77920 VA: 0x181F79320
	public void .ctor(float3 p0, float3 p1, float3 p2, float3 p3) { }

	// RVA: 0x21318F0 Offset: 0x212FEF0 VA: 0x1821318F0
	public void .ctor(BezierKnot a, BezierKnot b) { }

	// RVA: 0x2131500 Offset: 0x212FB00 VA: 0x182131500
	public BezierCurve Transform(float4x4 matrix) { }

	// RVA: 0x2131200 Offset: 0x212F800 VA: 0x182131200
	public static BezierCurve FromTangent(float3 pointA, float3 tangentOutA, float3 pointB, float3 tangentInB) { }

	// RVA: 0x21314B0 Offset: 0x212FAB0 VA: 0x1821314B0
	public BezierCurve GetInvertedCurve() { }

	// RVA: 0x1FBCA00 Offset: 0x1FBB000 VA: 0x181FBCA00 Slot: 4
	public bool Equals(BezierCurve other) { }

	// RVA: 0x2131150 Offset: 0x212F750 VA: 0x182131150 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21312B0 Offset: 0x212F8B0 VA: 0x1821312B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2131D20 Offset: 0x2130320 VA: 0x182131D20
	public static bool op_Equality(BezierCurve left, BezierCurve right) { }

	// RVA: 0x2131D50 Offset: 0x2130350 VA: 0x182131D50
	public static bool op_Inequality(BezierCurve left, BezierCurve right) { }
}

// Namespace: UnityEngine.Splines
[Serializable]
public struct BezierKnot : ISerializationCallbackReceiver, IEquatable<BezierKnot> // TypeDefIndex: 12519
{
	// Fields
	public float3 Position; // 0x0
	public float3 TangentIn; // 0xC
	public float3 TangentOut; // 0x18
	public quaternion Rotation; // 0x24

	// Methods

	// RVA: 0x2133290 Offset: 0x2131890 VA: 0x182133290
	public void .ctor(float3 position) { }

	// RVA: 0x2133310 Offset: 0x2131910 VA: 0x182133310
	public void .ctor(float3 position, float3 tangentIn, float3 tangentOut) { }

	// RVA: 0x207F9D0 Offset: 0x207DFD0 VA: 0x18207F9D0
	public void .ctor(float3 position, float3 tangentIn, float3 tangentOut, quaternion rotation) { }

	// RVA: 0x2132AD0 Offset: 0x21310D0 VA: 0x182132AD0
	public BezierKnot Transform(float4x4 matrix) { }

	// RVA: 0x21333B0 Offset: 0x21319B0 VA: 0x1821333B0
	public static BezierKnot op_Addition(BezierKnot knot, float3 rhs) { }

	// RVA: 0x2133420 Offset: 0x2131A20 VA: 0x182133420
	public static BezierKnot op_Subtraction(BezierKnot knot, float3 rhs) { }

	// RVA: 0x2131E10 Offset: 0x2130410 VA: 0x182131E10
	internal BezierKnot BakeTangentDirectionToRotation(bool mirrored, BezierTangent main = 1) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x21327F0 Offset: 0x2130DF0 VA: 0x1821327F0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2132890 Offset: 0x2130E90 VA: 0x182132890 Slot: 3
	public override string ToString() { }

	// RVA: 0x21324F0 Offset: 0x2130AF0 VA: 0x1821324F0 Slot: 6
	public bool Equals(BezierKnot other) { }

	// RVA: 0x2132640 Offset: 0x2130C40 VA: 0x182132640 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21326F0 Offset: 0x2130CF0 VA: 0x1821326F0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Splines
public enum TangentMode // TypeDefIndex: 12520
{
	// Fields
	public int value__; // 0x0
	public const TangentMode AutoSmooth = 0;
	public const TangentMode Linear = 1;
	public const TangentMode Mirrored = 2;
	public const TangentMode Continuous = 3;
	public const TangentMode Broken = 4;
}

// Namespace: UnityEngine.Splines
public enum BezierTangent // TypeDefIndex: 12521
{
	// Fields
	public int value__; // 0x0
	public const BezierTangent In = 0;
	public const BezierTangent Out = 1;
}

// Namespace: UnityEngine.Splines
public static class CurveUtility // TypeDefIndex: 12523
{
	// Fields
	private const int k_NormalsPerCurve = 16;
	private const float k_Epsilon = 0.0001;
	private static readonly DistanceToInterpolation[] k_DistanceLUT; // 0x0

	// Methods

	// RVA: 0x2133FB0 Offset: 0x21325B0 VA: 0x182133FB0
	public static float3 EvaluatePosition(BezierCurve curve, float t) { }

	// RVA: 0x2134180 Offset: 0x2132780 VA: 0x182134180
	public static float3 EvaluateTangent(BezierCurve curve, float t) { }

	// RVA: 0x2133C60 Offset: 0x2132260 VA: 0x182133C60
	public static float3 EvaluateAcceleration(BezierCurve curve, float t) { }

	// RVA: 0x2133DB0 Offset: 0x21323B0 VA: 0x182133DB0
	public static float EvaluateCurvature(BezierCurve curve, float t) { }

	// RVA: 0x2133A50 Offset: 0x2132050 VA: 0x182133A50
	private static float3 DeCasteljau(BezierCurve curve, float t) { }

	// RVA: 0x2135F60 Offset: 0x2134560 VA: 0x182135F60
	public static void Split(BezierCurve curve, float t, out BezierCurve left, out BezierCurve right) { }

	// RVA: 0x21338A0 Offset: 0x2131EA0 VA: 0x1821338A0
	public static float CalculateLength(BezierCurve curve, int resolution = 30) { }

	// RVA: 0x2133690 Offset: 0x2131C90 VA: 0x182133690
	public static void CalculateCurveLengths(BezierCurve curve, DistanceToInterpolation[] lookupTable) { }

	// RVA: 0x2133610 Offset: 0x2131C10 VA: 0x182133610
	private static bool Approximately(float a, float b) { }

	// RVA: 0x2133490 Offset: 0x2131A90 VA: 0x182133490
	public static float ApproximateLength(BezierCurve curve) { }

	// RVA: 0x2135390 Offset: 0x2133990 VA: 0x182135390
	internal static void EvaluateUpVectors(BezierCurve curve, float3 startUp, float3 endUp, Vector3[] upVectors) { }

	// RVA: 0x2134350 Offset: 0x2132950 VA: 0x182134350
	internal static float3 EvaluateUpVector(BezierCurve curve, float t, float3 startUp, float3 endUp) { }

	// RVA: 0x2135B00 Offset: 0x2134100 VA: 0x182135B00
	private static CurveUtility.FrenetFrame GetNextRotationMinimizingFrame(BezierCurve curve, CurveUtility.FrenetFrame previousRMFrame, float nextRMFrameT) { }

	// RVA: 0x21355E0 Offset: 0x2133BE0 VA: 0x1821355E0
	public static float GetDistanceToInterpolation(BezierCurve curve, float distance) { }

	// RVA: -1 Offset: -1
	public static float GetDistanceToInterpolation<T>(T lut, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C10E0 Offset: 0x6BF6E0 VA: 0x1806C10E0
	|-CurveUtility.GetDistanceToInterpolation<NativeSpline.Slice<DistanceToInterpolation>>
	|
	|-RVA: 0x6C0F50 Offset: 0x6BF550 VA: 0x1806C0F50
	|-CurveUtility.GetDistanceToInterpolation<object>
	|
	|-RVA: 0x6C0A70 Offset: 0x6BF070 VA: 0x1806C0A70
	|-CurveUtility.GetDistanceToInterpolation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2135A20 Offset: 0x2134020 VA: 0x182135A20
	public static float3 GetNearestPoint(BezierCurve curve, Ray ray, int resolution = 16) { }

	// RVA: 0x21356A0 Offset: 0x2133CA0 VA: 0x1821356A0
	public static float GetNearestPoint(BezierCurve curve, Ray ray, out float3 position, out float interpolation, int resolution = 16) { }

	// RVA: 0x2136310 Offset: 0x2134910 VA: 0x182136310
	private static void .cctor() { }
}

// Namespace: UnityEngine.Splines
public interface IDataPoint // TypeDefIndex: 12524
{
	// Properties
	public abstract float Index { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_Index();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Index(float value);
}

// Namespace: UnityEngine.Splines
[Serializable]
public struct DataPoint<TDataType> : IComparable<DataPoint<TDataType>>, IComparable<float>, IDataPoint // TypeDefIndex: 12525
{
	// Fields
	[FormerlySerializedAs("m_Time")]
	[SerializeField]
	private float m_Index; // 0x0
	[SerializeField]
	private TDataType m_Value; // 0x0

	// Properties
	public float Index { get; set; }
	public TDataType Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public float get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	|-DataPoint<int>.get_Index
	|-DataPoint<object>.get_Index
	|-DataPoint<float>.get_Index
	|-DataPoint<float4>.get_Index
	|
	|-RVA: 0xD32810 Offset: 0xD30E10 VA: 0x180D32810
	|-DataPoint<__Il2CppFullySharedGenericType>.get_Index
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void set_Index(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	|-DataPoint<int>.set_Index
	|-DataPoint<object>.set_Index
	|-DataPoint<float>.set_Index
	|-DataPoint<float4>.set_Index
	|
	|-RVA: 0xD32880 Offset: 0xD30E80 VA: 0x180D32880
	|-DataPoint<__Il2CppFullySharedGenericType>.set_Index
	*/

	// RVA: -1 Offset: -1
	public TDataType get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	|-DataPoint<int>.get_Value
	|
	|-RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	|-DataPoint<object>.get_Value
	|
	|-RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	|-DataPoint<float>.get_Value
	|
	|-RVA: 0xA64900 Offset: 0xA62F00 VA: 0x180A64900
	|-DataPoint<__Il2CppFullySharedGenericType>.get_Value
	|
	|-RVA: 0xD32870 Offset: 0xD30E70 VA: 0x180D32870
	|-DataPoint<float4>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(TDataType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	|-DataPoint<int>.set_Value
	|
	|-RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	|-DataPoint<object>.set_Value
	|
	|-RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	|-DataPoint<float>.set_Value
	|
	|-RVA: 0xD32920 Offset: 0xD30F20 VA: 0x180D32920
	|-DataPoint<__Il2CppFullySharedGenericType>.set_Value
	|
	|-RVA: 0xD32910 Offset: 0xD30F10 VA: 0x180D32910
	|-DataPoint<float4>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(float index, TDataType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1E960 Offset: 0xB1CF60 VA: 0x180B1E960
	|-DataPoint<int>..ctor
	|
	|-RVA: 0xD327F0 Offset: 0xD30DF0 VA: 0x180D327F0
	|-DataPoint<object>..ctor
	|
	|-RVA: 0xB1E9A0 Offset: 0xB1CFA0 VA: 0x180B1E9A0
	|-DataPoint<float>..ctor
	|
	|-RVA: 0xD32680 Offset: 0xD30C80 VA: 0x180D32680
	|-DataPoint<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xD327E0 Offset: 0xD30DE0 VA: 0x180D327E0
	|-DataPoint<float4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int CompareTo(DataPoint<TDataType> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD32170 Offset: 0xD30770 VA: 0x180D32170
	|-DataPoint<int>.CompareTo
	|
	|-RVA: 0xD32070 Offset: 0xD30670 VA: 0x180D32070
	|-DataPoint<object>.CompareTo
	|-DataPoint<float4>.CompareTo
	|
	|-RVA: 0xD31ED0 Offset: 0xD304D0 VA: 0x180D31ED0
	|-DataPoint<float>.CompareTo
	|
	|-RVA: 0xD31F90 Offset: 0xD30590 VA: 0x180D31F90
	|-DataPoint<__Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int CompareTo(float other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD31F40 Offset: 0xD30540 VA: 0x180D31F40
	|-DataPoint<int>.CompareTo
	|-DataPoint<object>.CompareTo
	|-DataPoint<float>.CompareTo
	|-DataPoint<float4>.CompareTo
	|
	|-RVA: 0xD320E0 Offset: 0xD306E0 VA: 0x180D320E0
	|-DataPoint<__Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD321E0 Offset: 0xD307E0 VA: 0x180D321E0
	|-DataPoint<int>.ToString
	|
	|-RVA: 0xD325E0 Offset: 0xD30BE0 VA: 0x180D325E0
	|-DataPoint<object>.ToString
	|
	|-RVA: 0xD322B0 Offset: 0xD308B0 VA: 0x180D322B0
	|-DataPoint<float>.ToString
	|
	|-RVA: 0xD32380 Offset: 0xD30980 VA: 0x180D32380
	|-DataPoint<__Il2CppFullySharedGenericType>.ToString
	|
	|-RVA: 0xD32510 Offset: 0xD30B10 VA: 0x180D32510
	|-DataPoint<float4>.ToString
	*/
}

// Namespace: UnityEngine.Splines
internal class DataPointComparer<T> : IComparer<T> // TypeDefIndex: 12526
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD31C70 Offset: 0xD30270 VA: 0x180D31C70
	|-DataPointComparer<DataPoint<int>>.Compare
	|
	|-RVA: 0xD31CF0 Offset: 0xD302F0 VA: 0x180D31CF0
	|-DataPointComparer<DataPoint<object>>.Compare
	|-DataPointComparer<DataPoint<float4>>.Compare
	|
	|-RVA: 0xD31CB0 Offset: 0xD302B0 VA: 0x180D31CB0
	|-DataPointComparer<DataPoint<float>>.Compare
	|
	|-RVA: 0xD31D20 Offset: 0xD30320 VA: 0x180D31D20
	|-DataPointComparer<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-DataPointComparer<DataPoint<int>>..ctor
	|-DataPointComparer<DataPoint<object>>..ctor
	|-DataPointComparer<DataPoint<float>>..ctor
	|-DataPointComparer<DataPoint<float4>>..ctor
	|-DataPointComparer<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Splines
[Serializable]
public class EmbeddedSplineData // TypeDefIndex: 12527
{
	// Fields
	[SerializeField]
	private SplineContainer m_Container; // 0x10
	[SerializeField]
	private int m_SplineIndex; // 0x18
	[SerializeField]
	private EmbeddedSplineDataType m_Type; // 0x1C
	[SerializeField]
	private string m_Key; // 0x20

	// Properties
	public SplineContainer Container { get; set; }
	public int SplineIndex { get; set; }
	public EmbeddedSplineDataType Type { get; set; }
	public string Key { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public SplineContainer get_Container() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Container(SplineContainer value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_SplineIndex() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_SplineIndex(int value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public EmbeddedSplineDataType get_Type() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_Type(EmbeddedSplineDataType value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Key() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Key(string value) { }

	// RVA: 0x2137090 Offset: 0x2135690 VA: 0x182137090
	public void .ctor() { }

	// RVA: 0x21370E0 Offset: 0x21356E0 VA: 0x1821370E0
	public void .ctor(string key, EmbeddedSplineDataType type, SplineContainer container, int splineIndex = 0) { }

	// RVA: 0x2136F80 Offset: 0x2135580 VA: 0x182136F80
	public bool TryGetSpline(out Spline spline) { }

	// RVA: 0x2136B00 Offset: 0x2135100 VA: 0x182136B00
	public bool TryGetFloatData(out SplineData<float> data) { }

	// RVA: 0x2136980 Offset: 0x2134F80 VA: 0x182136980
	public bool TryGetFloat4Data(out SplineData<float4> data) { }

	// RVA: 0x2136C80 Offset: 0x2135280 VA: 0x182136C80
	public bool TryGetIntData(out SplineData<int> data) { }

	// RVA: 0x2136E00 Offset: 0x2135400 VA: 0x182136E00
	public bool TryGetObjectData(out SplineData<Object> data) { }

	// RVA: 0x2136530 Offset: 0x2134B30 VA: 0x182136530
	public SplineData<float> GetOrCreateFloatData() { }

	// RVA: 0x21363C0 Offset: 0x21349C0 VA: 0x1821363C0
	public SplineData<float4> GetOrCreateFloat4Data() { }

	// RVA: 0x21366A0 Offset: 0x2134CA0 VA: 0x1821366A0
	public SplineData<int> GetOrCreateIntData() { }

	// RVA: 0x2136810 Offset: 0x2134E10 VA: 0x182136810
	public SplineData<Object> GetOrCreateObjectData() { }
}

// Namespace: UnityEngine.Splines
public enum EmbeddedSplineDataType // TypeDefIndex: 12528
{
	// Fields
	public int value__; // 0x0
	public const EmbeddedSplineDataType Int = 0;
	public const EmbeddedSplineDataType Float = 1;
	public const EmbeddedSplineDataType Float4 = 2;
	public const EmbeddedSplineDataType Object = 3;
}

// Namespace: UnityEngine.Splines
public static class InterpolatorUtility // TypeDefIndex: 12529
{
	// Fields
	private static readonly IInterpolator<float> s_LerpFloat; // 0x0
	private static readonly IInterpolator<float2> s_LerpFloat2; // 0x8
	private static readonly IInterpolator<float3> s_LerpFloat3; // 0x10
	private static readonly IInterpolator<float4> s_LerpFloat4; // 0x18
	private static readonly IInterpolator<float2> s_SlerpFloat2; // 0x20
	private static readonly IInterpolator<float3> s_SlerpFloat3; // 0x28
	private static readonly IInterpolator<quaternion> s_LerpQuaternion; // 0x30
	private static readonly IInterpolator<Color> s_LerpColor; // 0x38
	private static readonly IInterpolator<float> s_SmoothStepFloat; // 0x40
	private static readonly IInterpolator<float2> s_SmoothStepFloat2; // 0x48
	private static readonly IInterpolator<float3> s_SmoothStepFloat3; // 0x50
	private static readonly IInterpolator<float4> s_SmoothStepFloat4; // 0x58
	private static readonly IInterpolator<quaternion> s_SlerpQuaternion; // 0x60

	// Properties
	public static IInterpolator<float> LerpFloat { get; }
	public static IInterpolator<float2> LerpFloat2 { get; }
	public static IInterpolator<float3> LerpFloat3 { get; }
	public static IInterpolator<float4> LerpFloat4 { get; }
	public static IInterpolator<float2> SlerpFloat2 { get; }
	public static IInterpolator<float3> SlerpFloat3 { get; }
	public static IInterpolator<quaternion> LerpQuaternion { get; }
	public static IInterpolator<Color> LerpColor { get; }
	public static IInterpolator<float> SmoothStepFloat { get; }
	public static IInterpolator<float2> SmoothStepFloat2 { get; }
	public static IInterpolator<float3> SmoothStepFloat3 { get; }
	public static IInterpolator<float4> SmoothStepFloat4 { get; }
	public static IInterpolator<quaternion> SlerpQuaternion { get; }

	// Methods

	// RVA: 0x21376A0 Offset: 0x2135CA0 VA: 0x1821376A0
	public static IInterpolator<float> get_LerpFloat() { }

	// RVA: 0x21375B0 Offset: 0x2135BB0 VA: 0x1821375B0
	public static IInterpolator<float2> get_LerpFloat2() { }

	// RVA: 0x2137600 Offset: 0x2135C00 VA: 0x182137600
	public static IInterpolator<float3> get_LerpFloat3() { }

	// RVA: 0x2137650 Offset: 0x2135C50 VA: 0x182137650
	public static IInterpolator<float4> get_LerpFloat4() { }

	// RVA: 0x2137740 Offset: 0x2135D40 VA: 0x182137740
	public static IInterpolator<float2> get_SlerpFloat2() { }

	// RVA: 0x2137790 Offset: 0x2135D90 VA: 0x182137790
	public static IInterpolator<float3> get_SlerpFloat3() { }

	// RVA: 0x21376F0 Offset: 0x2135CF0 VA: 0x1821376F0
	public static IInterpolator<quaternion> get_LerpQuaternion() { }

	// RVA: 0x2137560 Offset: 0x2135B60 VA: 0x182137560
	public static IInterpolator<Color> get_LerpColor() { }

	// RVA: 0x2137920 Offset: 0x2135F20 VA: 0x182137920
	public static IInterpolator<float> get_SmoothStepFloat() { }

	// RVA: 0x2137830 Offset: 0x2135E30 VA: 0x182137830
	public static IInterpolator<float2> get_SmoothStepFloat2() { }

	// RVA: 0x2137880 Offset: 0x2135E80 VA: 0x182137880
	public static IInterpolator<float3> get_SmoothStepFloat3() { }

	// RVA: 0x21378D0 Offset: 0x2135ED0 VA: 0x1821378D0
	public static IInterpolator<float4> get_SmoothStepFloat4() { }

	// RVA: 0x21377E0 Offset: 0x2135DE0 VA: 0x1821377E0
	public static IInterpolator<quaternion> get_SlerpQuaternion() { }

	// RVA: 0x2137150 Offset: 0x2135750 VA: 0x182137150
	private static void .cctor() { }
}

// Namespace: UnityEngine.Splines
[Serializable]
public struct DistanceToInterpolation // TypeDefIndex: 12530
{
	// Fields
	public float Distance; // 0x0
	public float T; // 0x4
	internal static readonly DistanceToInterpolation Invalid; // 0x0

	// Methods

	// RVA: 0x2136380 Offset: 0x2134980 VA: 0x182136380
	private static void .cctor() { }
}

// Namespace: UnityEngine.Splines
public interface IHasEmptyCurves // TypeDefIndex: 12531
{
	// Properties
	public abstract IReadOnlyList<int> EmptyCurves { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IReadOnlyList<int> get_EmptyCurves();
}

// Namespace: UnityEngine.Splines
public interface ISpline : IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot> // TypeDefIndex: 12532
{
	// Properties
	public abstract bool Closed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Closed();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetLength();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract BezierCurve GetCurve(int index);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float GetCurveLength(int index);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float3 GetCurveUpVector(int index, float t);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float GetCurveInterpolation(int curveIndex, float curveDistance);
}

// Namespace: UnityEngine.Splines
public interface ISplineContainer // TypeDefIndex: 12533
{
	// Properties
	public abstract IReadOnlyList<Spline> Splines { get; set; }
	public abstract KnotLinkCollection KnotLinkCollection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IReadOnlyList<Spline> get_Splines();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Splines(IReadOnlyList<Spline> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract KnotLinkCollection get_KnotLinkCollection();
}

// Namespace: UnityEngine.Splines
[Obsolete("Use ISplineContainer instead.")]
public interface ISplineProvider // TypeDefIndex: 12534
{
	// Properties
	public abstract IEnumerable<Spline> Splines { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<Spline> get_Splines();
}

// Namespace: UnityEngine.Splines
[Serializable]
public sealed class KnotLinkCollection // TypeDefIndex: 12536
{
	// Fields
	[SerializeField]
	private KnotLinkCollection.KnotLink[] m_KnotsLink; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	public int get_Count() { }

	// RVA: 0x21379C0 Offset: 0x2135FC0 VA: 0x1821379C0
	private KnotLinkCollection.KnotLink GetKnotLinksInternal(SplineKnotIndex index) { }

	// RVA: 0x21385D0 Offset: 0x2136BD0 VA: 0x1821385D0
	public bool TryGetKnotLinks(SplineKnotIndex knotIndex, out IReadOnlyList<SplineKnotIndex> linkedKnots) { }

	// RVA: 0x2137A60 Offset: 0x2136060 VA: 0x182137A60
	public IReadOnlyList<SplineKnotIndex> GetKnotLinks(SplineKnotIndex knotIndex) { }

	// RVA: 0x2137970 Offset: 0x2135F70 VA: 0x182137970
	public void Clear() { }

	// RVA: 0x2137DF0 Offset: 0x21363F0 VA: 0x182137DF0
	public void Link(SplineKnotIndex knotA, SplineKnotIndex knotB) { }

	// RVA: 0x2138600 Offset: 0x2136C00 VA: 0x182138600
	public void Unlink(SplineKnotIndex knot) { }

	// RVA: 0x2138380 Offset: 0x2136980 VA: 0x182138380
	public void SplineRemoved(int splineIndex) { }

	// RVA: 0x21381D0 Offset: 0x21367D0 VA: 0x1821381D0
	public void SplineIndexChanged(int previousIndex, int newIndex) { }

	// RVA: 0x2137B30 Offset: 0x2136130 VA: 0x182137B30
	public void KnotIndexChanged(int splineIndex, int previousKnotIndex, int newKnotIndex) { }

	// RVA: 0x2137C00 Offset: 0x2136200 VA: 0x182137C00
	public void KnotIndexChanged(SplineKnotIndex previousIndex, SplineKnotIndex newIndex) { }

	// RVA: 0x2137CE0 Offset: 0x21362E0 VA: 0x182137CE0
	public void KnotRemoved(int splineIndex, int knotIndex) { }

	// RVA: 0x2137D20 Offset: 0x2136320 VA: 0x182137D20
	public void KnotRemoved(SplineKnotIndex index) { }

	// RVA: 0x2137C90 Offset: 0x2136290 VA: 0x182137C90
	public void KnotInserted(int splineIndex, int knotIndex) { }

	// RVA: 0x2137CD0 Offset: 0x21362D0 VA: 0x182137CD0
	public void KnotInserted(SplineKnotIndex index) { }

	// RVA: 0x21380B0 Offset: 0x21366B0 VA: 0x1821380B0
	public void ShiftKnotIndices(SplineKnotIndex index, int offset) { }

	// RVA: 0x21386C0 Offset: 0x2136CC0 VA: 0x1821386C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Splines
internal static class MathUtility // TypeDefIndex: 12537
{
	// Methods

	// RVA: 0x2138790 Offset: 0x2136D90 VA: 0x182138790
	public static float3 MultiplyVector(float4x4 matrix, float3 vector) { }
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
public struct NativeSpline : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>, IDisposable // TypeDefIndex: 12539
{
	// Fields
	[ReadOnly]
	private NativeArray<BezierKnot> m_Knots; // 0x0
	[ReadOnly]
	private NativeArray<BezierCurve> m_Curves; // 0x10
	[ReadOnly]
	private NativeArray<DistanceToInterpolation> m_SegmentLengthsLookupTable; // 0x20
	[ReadOnly]
	private NativeArray<float3> m_UpVectorsLookupTable; // 0x30
	private bool m_Closed; // 0x40
	private float m_Length; // 0x44
	private const int k_SegmentResolution = 30;

	// Properties
	public NativeArray<BezierKnot> Knots { get; }
	public NativeArray<BezierCurve> Curves { get; }
	public bool Closed { get; }
	public int Count { get; }
	public BezierKnot Item { get; }

	// Methods

	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public NativeArray<BezierKnot> get_Knots() { }

	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public NativeArray<BezierCurve> get_Curves() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0 Slot: 4
	public bool get_Closed() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90 Slot: 11
	public int get_Count() { }

	// RVA: 0x46E1F0 Offset: 0x46C7F0 VA: 0x18046E1F0 Slot: 5
	public float GetLength() { }

	// RVA: 0x213A200 Offset: 0x2138800 VA: 0x18213A200 Slot: 10
	public BezierKnot get_Item(int index) { }

	// RVA: 0x21391B0 Offset: 0x21377B0 VA: 0x1821391B0 Slot: 12
	public IEnumerator<BezierKnot> GetEnumerator() { }

	// RVA: 0x2139260 Offset: 0x2137860 VA: 0x182139260 Slot: 13
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x213A040 Offset: 0x2138640 VA: 0x18213A040
	public void .ctor(ISpline spline, Allocator allocator = 2) { }

	// RVA: 0x2139F90 Offset: 0x2138590 VA: 0x182139F90
	public void .ctor(ISpline spline, bool cacheUpVectors, Allocator allocator = 2) { }

	// RVA: 0x213A0E0 Offset: 0x21386E0 VA: 0x18213A0E0
	public void .ctor(ISpline spline, float4x4 transform, Allocator allocator = 2) { }

	// RVA: 0x2139350 Offset: 0x2137950 VA: 0x182139350
	public void .ctor(ISpline spline, float4x4 transform, bool cacheUpVectors, Allocator allocator = 2) { }

	// RVA: 0x21392E0 Offset: 0x21378E0 VA: 0x1821392E0
	public void .ctor(IReadOnlyList<BezierKnot> knots, bool closed, float4x4 transform, Allocator allocator = 2) { }

	// RVA: 0x2139F20 Offset: 0x2138520 VA: 0x182139F20
	public void .ctor(IReadOnlyList<BezierKnot> knots, bool closed, float4x4 transform, bool cacheUpVectors, Allocator allocator = 2) { }

	// RVA: 0x2139270 Offset: 0x2137870 VA: 0x182139270
	public void .ctor(IReadOnlyList<BezierKnot> knots, IReadOnlyList<int> splits, bool closed, float4x4 transform, Allocator allocator = 2) { }

	// RVA: 0x2139470 Offset: 0x2137A70 VA: 0x182139470
	public void .ctor(IReadOnlyList<BezierKnot> knots, IReadOnlyList<int> splits, bool closed, float4x4 transform, bool cacheUpVectors, Allocator allocator = 2) { }

	// RVA: 0x2139180 Offset: 0x2137780 VA: 0x182139180 Slot: 6
	public BezierCurve GetCurve(int index) { }

	// RVA: 0x2138FC0 Offset: 0x21375C0 VA: 0x182138FC0 Slot: 7
	public float GetCurveLength(int curveIndex) { }

	// RVA: 0x2138FE0 Offset: 0x21375E0 VA: 0x182138FE0 Slot: 8
	public float3 GetCurveUpVector(int index, float t) { }

	// RVA: 0x2138E20 Offset: 0x2137420 VA: 0x182138E20 Slot: 14
	public void Dispose() { }

	// RVA: 0x2138EB0 Offset: 0x21374B0 VA: 0x182138EB0 Slot: 9
	public float GetCurveInterpolation(int curveIndex, float curveDistance) { }
}

// Namespace: UnityEngine.Splines
public class SplineIndexAttribute : PropertyAttribute // TypeDefIndex: 12540
{
	// Fields
	public readonly string SplineContainerProperty; // 0x10

	// Methods

	// RVA: 0x169A1F0 Offset: 0x16987F0 VA: 0x18169A1F0
	public void .ctor(string splineContainerProperty) { }
}

// Namespace: UnityEngine.Splines
[Flags]
public enum EmbeddedSplineDataField // TypeDefIndex: 12541
{
	// Fields
	public int value__; // 0x0
	public const EmbeddedSplineDataField Container = 1;
	public const EmbeddedSplineDataField SplineIndex = 2;
	public const EmbeddedSplineDataField Key = 4;
	public const EmbeddedSplineDataField Type = 8;
	public const EmbeddedSplineDataField All = 255;
}

// Namespace: UnityEngine.Splines
public class EmbeddedSplineDataFieldsAttribute : PropertyAttribute // TypeDefIndex: 12542
{
	// Fields
	public readonly EmbeddedSplineDataField Fields; // 0x10

	// Methods

	// RVA: 0x1F08FB0 Offset: 0x1F075B0 VA: 0x181F08FB0
	public void .ctor(EmbeddedSplineDataField fields) { }
}

// Namespace: UnityEngine.Splines
internal class RamerDouglasPeucker<T> // TypeDefIndex: 12544
{
	// Fields
	private T m_Points; // 0x0
	private bool[] m_Keep; // 0x0
	private float m_Epsilon; // 0x0
	private int m_KeepCount; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T points) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9980 Offset: 0x8F7F80 VA: 0x1808F9980
	|-RamerDouglasPeucker<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Reduce(List<float3> results, float epsilon) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9290 Offset: 0x8F7890 VA: 0x1808F9290
	|-RamerDouglasPeucker<__Il2CppFullySharedGenericType>.Reduce
	*/

	// RVA: -1 Offset: -1
	private void Keep(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9240 Offset: 0x8F7840 VA: 0x1808F9240
	|-RamerDouglasPeucker<__Il2CppFullySharedGenericType>.Keep
	*/

	// RVA: -1 Offset: -1
	private void Discard(RamerDouglasPeucker.Range<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8CE0 Offset: 0x8F72E0 VA: 0x1808F8CE0
	|-RamerDouglasPeucker<__Il2CppFullySharedGenericType>.Discard
	*/

	// RVA: -1 Offset: -1
	private void Reduce(RamerDouglasPeucker.Range<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9820 Offset: 0x8F7E20 VA: 0x1808F9820
	|-RamerDouglasPeucker<__Il2CppFullySharedGenericType>.Reduce
	*/

	// RVA: -1 Offset: -1
	private ValueTuple<int, float> FindFarthest(RamerDouglasPeucker.Range<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8E30 Offset: 0x8F7430 VA: 0x1808F8E30
	|-RamerDouglasPeucker<__Il2CppFullySharedGenericType>.FindFarthest
	*/
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
[Serializable]
public class Spline : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>, IList<BezierKnot>, ICollection<BezierKnot> // TypeDefIndex: 12547
{
	// Fields
	private const TangentMode k_DefaultTangentMode = 4;
	private const BezierTangent k_DefaultMainTangent = 1;
	private const int k_BatchModification = -1;
	private const int k_CurveDistanceLutResolution = 30;
	[SerializeField]
	[Obsolete]
	[HideInInspector]
	private SplineType m_EditModeType; // 0x10
	[SerializeField]
	private List<BezierKnot> m_Knots; // 0x18
	private float m_Length; // 0x20
	[SerializeField]
	[HideInInspector]
	private List<Spline.MetaData> m_MetaData; // 0x28
	[SerializeField]
	private bool m_Closed; // 0x30
	[SerializeField]
	private SplineDataDictionary<int> m_IntData; // 0x38
	[SerializeField]
	private SplineDataDictionary<float> m_FloatData; // 0x40
	[SerializeField]
	private SplineDataDictionary<float4> m_Float4Data; // 0x48
	[SerializeField]
	private SplineDataDictionary<Object> m_ObjectData; // 0x50
	[CompilerGenerated]
	private Action changed; // 0x58
	[CompilerGenerated]
	private static Action<Spline, int, SplineModification> Changed; // 0x0
	[TupleElementNames(new[] { "curve0", "curve1" })]
	private ValueTuple<float, float> m_LastKnotChangeCurveLengths; // 0x60

	// Properties
	private IEnumerable<ISplineModificationHandler> embeddedSplineData { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	[Obsolete("Use GetTangentMode and SetTangentMode.")]
	public SplineType EditType { get; set; }
	public IEnumerable<BezierKnot> Knots { get; set; }
	public bool Closed { get; set; }
	public BezierKnot Item { get; set; }

	// Methods

	[IteratorStateMachine(typeof(Spline.<get_embeddedSplineData>d__15))]
	// RVA: 0x214DB80 Offset: 0x214C180 VA: 0x18214DB80
	private IEnumerable<ISplineModificationHandler> get_embeddedSplineData() { }

	// RVA: 0x214C2E0 Offset: 0x214A8E0 VA: 0x18214C2E0
	public bool TryGetFloatData(string key, out SplineData<float> data) { }

	// RVA: 0x214C270 Offset: 0x214A870 VA: 0x18214C270
	public bool TryGetFloat4Data(string key, out SplineData<float4> data) { }

	// RVA: 0x214C350 Offset: 0x214A950 VA: 0x18214C350
	public bool TryGetIntData(string key, out SplineData<int> data) { }

	// RVA: 0x214C3C0 Offset: 0x214A9C0 VA: 0x18214C3C0
	public bool TryGetObjectData(string key, out SplineData<Object> data) { }

	// RVA: 0x2149500 Offset: 0x2147B00 VA: 0x182149500
	public SplineData<float> GetOrCreateFloatData(string key) { }

	// RVA: 0x21494A0 Offset: 0x2147AA0 VA: 0x1821494A0
	public SplineData<float4> GetOrCreateFloat4Data(string key) { }

	// RVA: 0x2149560 Offset: 0x2147B60 VA: 0x182149560
	public SplineData<int> GetOrCreateIntData(string key) { }

	// RVA: 0x21495C0 Offset: 0x2147BC0 VA: 0x1821495C0
	public SplineData<Object> GetOrCreateObjectData(string key) { }

	// RVA: 0x214A930 Offset: 0x2148F30 VA: 0x18214A930
	public bool RemoveFloatData(string key) { }

	// RVA: 0x214A8D0 Offset: 0x2148ED0 VA: 0x18214A8D0
	public bool RemoveFloat4Data(string key) { }

	// RVA: 0x214A990 Offset: 0x2148F90 VA: 0x18214A990
	public bool RemoveIntData(string key) { }

	// RVA: 0x214A9F0 Offset: 0x2148FF0 VA: 0x18214A9F0
	public bool RemoveObjectData(string key) { }

	// RVA: 0x21491E0 Offset: 0x21477E0 VA: 0x1821491E0
	public IEnumerable<string> GetFloatDataKeys() { }

	// RVA: 0x2149140 Offset: 0x2147740 VA: 0x182149140
	public IEnumerable<string> GetFloat4DataKeys() { }

	// RVA: 0x2149280 Offset: 0x2147880 VA: 0x182149280
	public IEnumerable<string> GetIntDataKeys() { }

	// RVA: 0x2149400 Offset: 0x2147A00 VA: 0x182149400
	public IEnumerable<string> GetObjectDataKeys() { }

	// RVA: 0x2149620 Offset: 0x2147C20 VA: 0x182149620
	public IEnumerable<string> GetSplineDataKeys(EmbeddedSplineDataType type) { }

	// RVA: 0x2149230 Offset: 0x2147830 VA: 0x182149230
	public IEnumerable<SplineData<float>> GetFloatDataValues() { }

	// RVA: 0x2149190 Offset: 0x2147790 VA: 0x182149190
	public IEnumerable<SplineData<float4>> GetFloat4DataValues() { }

	// RVA: 0x21492D0 Offset: 0x21478D0 VA: 0x1821492D0
	public IEnumerable<SplineData<int>> GetIntDataValues() { }

	// RVA: 0x2149450 Offset: 0x2147A50 VA: 0x182149450
	public IEnumerable<SplineData<Object>> GetObjectDataValues() { }

	// RVA: 0x214B7E0 Offset: 0x2149DE0 VA: 0x18214B7E0
	public void SetFloatData(string key, SplineData<float> value) { }

	// RVA: 0x214B770 Offset: 0x2149D70 VA: 0x18214B770
	public void SetFloat4Data(string key, SplineData<float4> value) { }

	// RVA: 0x214B850 Offset: 0x2149E50 VA: 0x18214B850
	public void SetIntData(string key, SplineData<int> value) { }

	// RVA: 0x214BAB0 Offset: 0x214A0B0 VA: 0x18214BAB0
	public void SetObjectData(string key, SplineData<Object> value) { }

	// RVA: 0x214DAB0 Offset: 0x214C0B0 VA: 0x18214DAB0 Slot: 19
	public int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 20
	public bool get_IsReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x214DA10 Offset: 0x214C010 VA: 0x18214DA10
	public void add_changed(Action value) { }

	[CompilerGenerated]
	// RVA: 0x214DCE0 Offset: 0x214C2E0 VA: 0x18214DCE0
	public void remove_changed(Action value) { }

	[CompilerGenerated]
	// RVA: 0x214D930 Offset: 0x214BF30 VA: 0x18214D930
	public static void add_Changed(Action<Spline, int, SplineModification> value) { }

	[CompilerGenerated]
	// RVA: 0x214DC00 Offset: 0x214C200 VA: 0x18214DC00
	public static void remove_Changed(Action<Spline, int, SplineModification> value) { }

	// RVA: 0x214B320 Offset: 0x2149920 VA: 0x18214B320
	internal void SetDirtyNoNotify() { }

	// RVA: 0x214B3D0 Offset: 0x21499D0 VA: 0x18214B3D0
	internal void SetDirty(SplineModification modificationEvent, int knotIndex = -1) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 26
	protected virtual void OnSplineChanged() { }

	// RVA: 0x21485A0 Offset: 0x2146BA0 VA: 0x1821485A0
	private void EnsureMetaDataValid() { }

	// RVA: 0x2148520 Offset: 0x2146B20 VA: 0x182148520
	public void EnforceTangentModeNoNotify(int index) { }

	// RVA: 0x21484B0 Offset: 0x2146AB0 VA: 0x1821484B0
	public void EnforceTangentModeNoNotify(SplineRange range) { }

	// RVA: 0x2149750 Offset: 0x2147D50 VA: 0x182149750
	public TangentMode GetTangentMode(int index) { }

	// RVA: 0x214BDD0 Offset: 0x214A3D0 VA: 0x18214BDD0
	public void SetTangentMode(TangentMode mode) { }

	// RVA: 0x214C050 Offset: 0x214A650 VA: 0x18214C050
	public void SetTangentMode(int index, TangentMode mode, BezierTangent main = 1) { }

	// RVA: 0x214BE70 Offset: 0x214A470 VA: 0x18214BE70
	public void SetTangentMode(SplineRange range, TangentMode mode, BezierTangent main = 1) { }

	// RVA: 0x214BB20 Offset: 0x214A120 VA: 0x18214BB20
	public void SetTangentModeNoNotify(int index, TangentMode mode, BezierTangent main = 1) { }

	// RVA: 0x2147C10 Offset: 0x2146210 VA: 0x182147C10
	private void ApplyTangentModeNoNotify(int index, BezierTangent main = 1) { }

	// RVA: 0x2148740 Offset: 0x2146D40 VA: 0x182148740
	public float GetAutoSmoothTension(int index) { }

	// RVA: 0x214B1E0 Offset: 0x21497E0 VA: 0x18214B1E0
	public void SetAutoSmoothTension(int index, float tension) { }

	// RVA: 0x214B0C0 Offset: 0x21496C0 VA: 0x18214B0C0
	public void SetAutoSmoothTension(SplineRange range, float tension) { }

	// RVA: 0x214AFA0 Offset: 0x21495A0 VA: 0x18214AFA0
	public void SetAutoSmoothTensionNoNotify(int index, float tension) { }

	// RVA: 0x214AEA0 Offset: 0x21494A0 VA: 0x18214AEA0
	public void SetAutoSmoothTensionNoNotify(SplineRange range, float tension) { }

	// RVA: 0x214AD80 Offset: 0x2149380 VA: 0x18214AD80
	private void SetAutoSmoothTensionInternal(SplineRange range, float tension, bool setDirty) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public SplineType get_EditType() { }

	// RVA: 0x214DDA0 Offset: 0x214C3A0 VA: 0x18214DDA0
	public void set_EditType(SplineType value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public IEnumerable<BezierKnot> get_Knots() { }

	// RVA: 0x214DEE0 Offset: 0x214C4E0 VA: 0x18214DEE0
	public void set_Knots(IEnumerable<BezierKnot> value) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190 Slot: 4
	public bool get_Closed() { }

	// RVA: 0x214DD80 Offset: 0x214C380 VA: 0x18214DD80
	public void set_Closed(bool value) { }

	// RVA: 0x21497C0 Offset: 0x2147DC0 VA: 0x1821497C0 Slot: 16
	public int IndexOf(BezierKnot item) { }

	// RVA: 0x214A710 Offset: 0x2148D10 VA: 0x18214A710 Slot: 17
	public void Insert(int index, BezierKnot knot) { }

	// RVA: 0x214A6C0 Offset: 0x2148CC0 VA: 0x18214A6C0
	public void Insert(int index, BezierKnot knot, TangentMode mode) { }

	// RVA: 0x214A510 Offset: 0x2148B10 VA: 0x18214A510
	public void Insert(int index, BezierKnot knot, TangentMode mode, float tension) { }

	// RVA: 0x2149840 Offset: 0x2147E40 VA: 0x182149840
	internal void InsertOnCurve(int index, float curveT) { }

	// RVA: 0x214A770 Offset: 0x2148D70 VA: 0x18214A770 Slot: 18
	public void RemoveAt(int index) { }

	// RVA: 0x214DAF0 Offset: 0x214C0F0 VA: 0x18214DAF0 Slot: 14
	public BezierKnot get_Item(int index) { }

	// RVA: 0x214DE50 Offset: 0x214C450 VA: 0x18214DE50 Slot: 15
	public void set_Item(int index, BezierKnot value) { }

	// RVA: 0x214BA20 Offset: 0x214A020 VA: 0x18214BA20
	public void SetKnot(int index, BezierKnot value, BezierTangent main = 1) { }

	// RVA: 0x214B8C0 Offset: 0x2149EC0 VA: 0x18214B8C0
	public void SetKnotNoNotify(int index, BezierKnot value, BezierTangent main = 1) { }

	// RVA: 0x214CD40 Offset: 0x214B340 VA: 0x18214CD40
	public void .ctor() { }

	// RVA: 0x214C8D0 Offset: 0x214AED0 VA: 0x18214C8D0
	public void .ctor(int knotCapacity, bool closed = False) { }

	// RVA: 0x214CB10 Offset: 0x214B110 VA: 0x18214CB10
	public void .ctor(IEnumerable<BezierKnot> knots, bool closed = False) { }

	// RVA: 0x214CF30 Offset: 0x214B530 VA: 0x18214CF30
	public void .ctor(Spline spline) { }

	// RVA: 0x2148F20 Offset: 0x2147520 VA: 0x182148F20 Slot: 6
	public BezierCurve GetCurve(int index) { }

	// RVA: 0x2148A70 Offset: 0x2147070 VA: 0x182148A70 Slot: 7
	public float GetCurveLength(int index) { }

	// RVA: 0x2149320 Offset: 0x2147920 VA: 0x182149320 Slot: 5
	public float GetLength() { }

	// RVA: 0x21487A0 Offset: 0x2146DA0 VA: 0x1821487A0
	private DistanceToInterpolation[] GetCurveDistanceLut(int index) { }

	// RVA: 0x21489E0 Offset: 0x2146FE0 VA: 0x1821489E0 Slot: 9
	public float GetCurveInterpolation(int curveIndex, float curveDistance) { }

	// RVA: 0x214C430 Offset: 0x214AA30 VA: 0x18214C430
	private void WarmUpCurveUps() { }

	// RVA: 0x2148C30 Offset: 0x2147230 VA: 0x182148C30 Slot: 8
	public float3 GetCurveUpVector(int index, float t) { }

	// RVA: 0x214C5B0 Offset: 0x214ABB0 VA: 0x18214C5B0
	public void Warmup() { }

	// RVA: 0x214ABA0 Offset: 0x21491A0 VA: 0x18214ABA0
	public void Resize(int newSize) { }

	// RVA: 0x214C220 Offset: 0x214A820 VA: 0x18214C220
	public BezierKnot[] ToArray() { }

	// RVA: 0x21482B0 Offset: 0x21468B0 VA: 0x1821482B0
	public void Copy(Spline copyFrom) { }

	// RVA: 0x2149090 Offset: 0x2147690 VA: 0x182149090 Slot: 12
	public IEnumerator<BezierKnot> GetEnumerator() { }

	// RVA: 0x214C170 Offset: 0x214A770 VA: 0x18214C170 Slot: 13
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2147A20 Offset: 0x2146020 VA: 0x182147A20 Slot: 21
	public void Add(BezierKnot item) { }

	// RVA: 0x2147B70 Offset: 0x2146170 VA: 0x182147B70
	public void Add(BezierKnot item, TangentMode mode) { }

	// RVA: 0x2147AC0 Offset: 0x21460C0 VA: 0x182147AC0
	public void Add(BezierKnot item, TangentMode mode, float tension) { }

	// RVA: 0x2148130 Offset: 0x2146730 VA: 0x182148130 Slot: 22
	public void Clear() { }

	// RVA: 0x21481C0 Offset: 0x21467C0 VA: 0x1821481C0 Slot: 23
	public bool Contains(BezierKnot item) { }

	// RVA: 0x2148240 Offset: 0x2146840 VA: 0x182148240 Slot: 24
	public void CopyTo(BezierKnot[] array, int arrayIndex) { }

	// RVA: 0x214AB00 Offset: 0x2149100 VA: 0x18214AB00 Slot: 25
	public bool Remove(BezierKnot item) { }

	// RVA: 0x214AA50 Offset: 0x2149050 VA: 0x18214AA50
	internal void RemoveUnusedSplineData() { }

	// RVA: 0x2148060 Offset: 0x2146660 VA: 0x182148060
	internal void CacheKnotOperationCurves(int index) { }
}

// Namespace: UnityEngine.Splines
[AddComponentMenu("Splines/Spline Animate")]
[ExecuteInEditMode]
public class SplineAnimate : SplineComponent // TypeDefIndex: 12552
{
	// Fields
	[SerializeField]
	[Tooltip("The target spline to follow.")]
	private SplineContainer m_Target; // 0x28
	[SerializeField]
	[Tooltip("Enable to have the animation start when the GameObject first loads.")]
	private bool m_PlayOnAwake; // 0x30
	[SerializeField]
	[Tooltip("The loop mode that the animation uses. Loop modes cause the animation to repeat after it finishes. The following loop modes are available:.
Once - Traverse the spline once and stop at the end.
Loop Continuous - Traverse the spline continuously without stopping.
Ease In Then Continuous - Traverse the spline repeatedly without stopping. If Ease In easing is enabled, apply easing to the first loop only.
Ping Pong - Traverse the spline continuously without stopping and reverse direction after an end of the spline is reached.
")]
	private SplineAnimate.LoopMode m_LoopMode; // 0x34
	[SerializeField]
	[Tooltip("The method used to animate the GameObject along the spline.
Time - The spline is traversed in a given amount of seconds.
Speed - The spline is traversed at a given maximum speed.")]
	private SplineAnimate.Method m_Method; // 0x38
	[SerializeField]
	[Tooltip("The period of time that it takes for the GameObject to complete its animation along the spline.")]
	private float m_Duration; // 0x3C
	[SerializeField]
	[Tooltip("The speed in meters/second that the GameObject animates along the spline at.")]
	private float m_MaxSpeed; // 0x40
	[SerializeField]
	[Tooltip("The easing mode used when the GameObject animates along the spline.
None - Apply no easing to the animation. The animation speed is linear.
Ease In Only - Apply easing to the beginning of animation.
Ease Out Only - Apply easing to the end of animation.
Ease In-Out - Apply easing to the beginning and end of animation.
")]
	private SplineAnimate.EasingMode m_EasingMode; // 0x44
	[SerializeField]
	[Tooltip("The coordinate space that the GameObject's up and forward axes align to.")]
	private SplineAnimate.AlignmentMode m_AlignmentMode; // 0x48
	[SerializeField]
	[Tooltip("Which axis of the GameObject is treated as the forward axis.")]
	private SplineComponent.AlignAxis m_ObjectForwardAxis; // 0x4C
	[SerializeField]
	[Tooltip("Which axis of the GameObject is treated as the up axis.")]
	private SplineComponent.AlignAxis m_ObjectUpAxis; // 0x50
	[SerializeField]
	[Tooltip("Normalized distance [0;1] offset along the spline at which the GameObject should be placed when the animation begins.")]
	private float m_StartOffset; // 0x54
	private float m_StartOffsetT; // 0x58
	private float m_SplineLength; // 0x5C
	private bool m_Playing; // 0x60
	private float m_NormalizedTime; // 0x64
	private float m_ElapsedTime; // 0x68
	private SplinePath<Spline> m_SplinePath; // 0x70
	[CompilerGenerated]
	private Action<Vector3, Quaternion> onUpdated; // 0x78
	[CompilerGenerated]
	private Action<Vector3, Quaternion> Updated; // 0x80

	// Properties
	[Obsolete("Use Container instead.", False)]
	public SplineContainer splineContainer { get; }
	public SplineContainer Container { get; set; }
	[Obsolete("Use PlayOnAwake instead.", False)]
	public bool playOnAwake { get; }
	public bool PlayOnAwake { get; set; }
	[Obsolete("Use Loop instead.", False)]
	public SplineAnimate.LoopMode loopMode { get; }
	public SplineAnimate.LoopMode Loop { get; set; }
	[Obsolete("Use AnimationMethod instead.", False)]
	public SplineAnimate.Method method { get; }
	public SplineAnimate.Method AnimationMethod { get; set; }
	[Obsolete("Use Duration instead.", False)]
	public float duration { get; }
	public float Duration { get; set; }
	[Obsolete("Use MaxSpeed instead.", False)]
	public float maxSpeed { get; }
	public float MaxSpeed { get; set; }
	[Obsolete("Use Easing instead.", False)]
	public SplineAnimate.EasingMode easingMode { get; }
	public SplineAnimate.EasingMode Easing { get; set; }
	[Obsolete("Use Alignment instead.", False)]
	public SplineAnimate.AlignmentMode alignmentMode { get; }
	public SplineAnimate.AlignmentMode Alignment { get; set; }
	[Obsolete("Use ObjectForwardAxis instead.", False)]
	public SplineComponent.AlignAxis objectForwardAxis { get; }
	public SplineComponent.AlignAxis ObjectForwardAxis { get; set; }
	[Obsolete("Use ObjectUpAxis instead.", False)]
	public SplineComponent.AlignAxis objectUpAxis { get; }
	public SplineComponent.AlignAxis ObjectUpAxis { get; set; }
	[Obsolete("Use NormalizedTime instead.", False)]
	public float normalizedTime { get; }
	public float NormalizedTime { get; set; }
	[Obsolete("Use ElapsedTime instead.", False)]
	public float elapsedTime { get; }
	public float ElapsedTime { get; set; }
	public float StartOffset { get; set; }
	internal float StartOffsetT { get; }
	[Obsolete("Use IsPlaying instead.", False)]
	public bool isPlaying { get; }
	public bool IsPlaying { get; }

	// Methods

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public SplineContainer get_splineContainer() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public SplineContainer get_Container() { }

	// RVA: 0x213B8B0 Offset: 0x2139EB0 VA: 0x18213B8B0
	public void set_Container(SplineContainer value) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_playOnAwake() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_PlayOnAwake() { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	public void set_PlayOnAwake(bool value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public SplineAnimate.LoopMode get_loopMode() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public SplineAnimate.LoopMode get_Loop() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	public void set_Loop(SplineAnimate.LoopMode value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public SplineAnimate.Method get_method() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public SplineAnimate.Method get_AnimationMethod() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_AnimationMethod(SplineAnimate.Method value) { }

	// RVA: 0x1853720 Offset: 0x1851D20 VA: 0x181853720
	public float get_duration() { }

	// RVA: 0x1853720 Offset: 0x1851D20 VA: 0x181853720
	public float get_Duration() { }

	// RVA: 0x213BBB0 Offset: 0x213A1B0 VA: 0x18213BBB0
	public void set_Duration(float value) { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_maxSpeed() { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_MaxSpeed() { }

	// RVA: 0x213BC00 Offset: 0x213A200 VA: 0x18213BC00
	public void set_MaxSpeed(float value) { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public SplineAnimate.EasingMode get_easingMode() { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public SplineAnimate.EasingMode get_Easing() { }

	// RVA: 0x1978180 Offset: 0x1976780 VA: 0x181978180
	public void set_Easing(SplineAnimate.EasingMode value) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public SplineAnimate.AlignmentMode get_alignmentMode() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public SplineAnimate.AlignmentMode get_Alignment() { }

	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	public void set_Alignment(SplineAnimate.AlignmentMode value) { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public SplineComponent.AlignAxis get_objectForwardAxis() { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public SplineComponent.AlignAxis get_ObjectForwardAxis() { }

	// RVA: 0x213BC80 Offset: 0x213A280 VA: 0x18213BC80
	public void set_ObjectForwardAxis(SplineComponent.AlignAxis value) { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public SplineComponent.AlignAxis get_objectUpAxis() { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public SplineComponent.AlignAxis get_ObjectUpAxis() { }

	// RVA: 0x213BCE0 Offset: 0x213A2E0 VA: 0x18213BCE0
	public void set_ObjectUpAxis(SplineComponent.AlignAxis value) { }

	// RVA: 0x187F590 Offset: 0x187DB90 VA: 0x18187F590
	public float get_normalizedTime() { }

	// RVA: 0x187F590 Offset: 0x187DB90 VA: 0x18187F590
	public float get_NormalizedTime() { }

	// RVA: 0x213BC20 Offset: 0x213A220 VA: 0x18213BC20
	public void set_NormalizedTime(float value) { }

	// RVA: 0x4A42F0 Offset: 0x4A28F0 VA: 0x1804A42F0
	public float get_elapsedTime() { }

	// RVA: 0x4A42F0 Offset: 0x4A28F0 VA: 0x1804A42F0
	public float get_ElapsedTime() { }

	// RVA: 0x213BBD0 Offset: 0x213A1D0 VA: 0x18213BBD0
	public void set_ElapsedTime(float value) { }

	// RVA: 0x17836B0 Offset: 0x1781CB0 VA: 0x1817836B0
	public float get_StartOffset() { }

	// RVA: 0x213BD40 Offset: 0x213A340 VA: 0x18213BD40
	public void set_StartOffset(float value) { }

	// RVA: 0x187F580 Offset: 0x187DB80 VA: 0x18187F580
	internal float get_StartOffsetT() { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_isPlaying() { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x213B690 Offset: 0x2139C90 VA: 0x18213B690
	public void add_onUpdated(Action<Vector3, Quaternion> value) { }

	[CompilerGenerated]
	// RVA: 0x213B800 Offset: 0x2139E00 VA: 0x18213B800
	public void remove_onUpdated(Action<Vector3, Quaternion> value) { }

	[CompilerGenerated]
	// RVA: 0x213B5D0 Offset: 0x2139BD0 VA: 0x18213B5D0
	public void add_Updated(Action<Vector3, Quaternion> value) { }

	[CompilerGenerated]
	// RVA: 0x213B740 Offset: 0x2139D40 VA: 0x18213B740
	public void remove_Updated(Action<Vector3, Quaternion> value) { }

	// RVA: 0x213B360 Offset: 0x2139960 VA: 0x18213B360
	private void Start() { }

	// RVA: 0x213AEA0 Offset: 0x21394A0 VA: 0x18213AEA0
	private void OnEnable() { }

	// RVA: 0x213AE30 Offset: 0x2139430 VA: 0x18213AE30
	private void OnDisable() { }

	// RVA: 0x213AF30 Offset: 0x2139530 VA: 0x18213AF30
	private void OnValidate() { }

	// RVA: 0x213B0A0 Offset: 0x21396A0 VA: 0x18213B0A0
	internal void RecalculateAnimationParameters() { }

	// RVA: 0x213AD20 Offset: 0x2139320 VA: 0x18213AD20
	private bool IsNullOrEmptyContainer() { }

	// RVA: 0x213AF70 Offset: 0x2139570 VA: 0x18213AF70
	public void Play() { }

	// RVA: 0x213AF60 Offset: 0x2139560 VA: 0x18213AF60
	public void Pause() { }

	// RVA: 0x213B160 Offset: 0x2139760 VA: 0x18213B160
	public void Restart(bool autoplay) { }

	// RVA: 0x213B540 Offset: 0x2139B40 VA: 0x18213B540
	public void Update() { }

	// RVA: 0x213A400 Offset: 0x2138A00 VA: 0x18213A400
	private void CalculateNormalizedTime(float deltaTime) { }

	// RVA: 0x213B370 Offset: 0x2139970 VA: 0x18213B370
	private void UpdateStartOffsetT() { }

	// RVA: 0x213B3D0 Offset: 0x21399D0 VA: 0x18213B3D0
	private void UpdateTransform() { }

	// RVA: 0x213A690 Offset: 0x2138C90 VA: 0x18213A690
	private void EvaluatePositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	// RVA: 0x213A240 Offset: 0x2138840 VA: 0x18213A240
	private void CalculateDuration() { }

	// RVA: 0x213A320 Offset: 0x2138920 VA: 0x18213A320
	private void CalculateMaxSpeed() { }

	// RVA: 0x213AF90 Offset: 0x2139590 VA: 0x18213AF90
	private void RebuildSplinePath() { }

	// RVA: 0x213B310 Offset: 0x2139910 VA: 0x18213B310
	private SplineComponent.AlignAxis SetObjectAlignAxis(SplineComponent.AlignAxis newValue, ref SplineComponent.AlignAxis targetAxis, SplineComponent.AlignAxis otherAxis) { }

	// RVA: 0x213AF20 Offset: 0x2139520 VA: 0x18213AF20
	private void OnSplineChange(Spline spline, int knotIndex, SplineModification modificationType) { }

	// RVA: 0x213AC90 Offset: 0x2139290 VA: 0x18213AC90
	internal float GetLoopInterpolation(bool offset) { }

	// RVA: 0x213A660 Offset: 0x2138C60 VA: 0x18213A660
	private float EaseInQuadratic(float t) { }

	// RVA: 0x213A670 Offset: 0x2138C70 VA: 0x18213A670
	private float EaseOutQuadratic(float t) { }

	// RVA: 0x213A630 Offset: 0x2138C30 VA: 0x18213A630
	private float EaseInOutQuadratic(float t) { }

	// RVA: 0x213B590 Offset: 0x2139B90 VA: 0x18213B590
	public void .ctor() { }
}

// Namespace: UnityEngine.Splines
public abstract class SplineComponent : MonoBehaviour // TypeDefIndex: 12554
{
	// Fields
	private readonly float3[] m_AlignAxisToVector; // 0x20

	// Methods

	// RVA: 0x213BDF0 Offset: 0x213A3F0 VA: 0x18213BDF0
	protected float3 GetAxis(SplineComponent.AlignAxis axis) { }

	// RVA: 0x213BE40 Offset: 0x213A440 VA: 0x18213BE40
	protected void .ctor() { }
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
[AddComponentMenu("Splines/Spline Container")]
[ExecuteInEditMode]
public sealed class SplineContainer : MonoBehaviour, ISplineContainer, ISerializationCallbackReceiver // TypeDefIndex: 12556
{
	// Fields
	private const string k_IconPath = "Packages/com.unity.splines/Editor/Resources/Icons/SplineComponent.png";
	[SerializeField]
	[Obsolete]
	[HideInInspector]
	private Spline m_Spline; // 0x20
	[SerializeField]
	private Spline[] m_Splines; // 0x28
	[SerializeField]
	private KnotLinkCollection m_Knots; // 0x30
	[TupleElementNames(new[] { "previousIndex", "newIndex" })]
	private List<ValueTuple<int, int>> m_ReorderedSplinesIndices; // 0x38
	private List<int> m_RemovedSplinesIndices; // 0x40
	private List<int> m_AddedSplinesIndices; // 0x48
	[CompilerGenerated]
	private static Action<SplineContainer, int> SplineAdded; // 0x0
	[CompilerGenerated]
	private static Action<SplineContainer, int> SplineRemoved; // 0x8
	[CompilerGenerated]
	private static Action<SplineContainer, int, int> SplineReordered; // 0x10
	private ReadOnlyCollection<Spline> m_ReadOnlySplines; // 0x50

	// Properties
	public IReadOnlyList<Spline> Splines { get; set; }
	public KnotLinkCollection KnotLinkCollection { get; }
	public Spline Item { get; }
	private bool IsScaled { get; }
	public Spline Spline { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x213CE80 Offset: 0x213B480 VA: 0x18213CE80
	public static void add_SplineAdded(Action<SplineContainer, int> value) { }

	[CompilerGenerated]
	// RVA: 0x213D2B0 Offset: 0x213B8B0 VA: 0x18213D2B0
	public static void remove_SplineAdded(Action<SplineContainer, int> value) { }

	[CompilerGenerated]
	// RVA: 0x213CF60 Offset: 0x213B560 VA: 0x18213CF60
	public static void add_SplineRemoved(Action<SplineContainer, int> value) { }

	[CompilerGenerated]
	// RVA: 0x213D390 Offset: 0x213B990 VA: 0x18213D390
	public static void remove_SplineRemoved(Action<SplineContainer, int> value) { }

	[CompilerGenerated]
	// RVA: 0x213D040 Offset: 0x213B640 VA: 0x18213D040
	public static void add_SplineReordered(Action<SplineContainer, int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x213D470 Offset: 0x213BA70 VA: 0x18213D470
	public static void remove_SplineReordered(Action<SplineContainer, int, int> value) { }

	// RVA: 0x213D220 Offset: 0x213B820 VA: 0x18213D220 Slot: 4
	public IReadOnlyList<Spline> get_Splines() { }

	// RVA: 0x213D5D0 Offset: 0x213BBD0 VA: 0x18213D5D0 Slot: 5
	public void set_Splines(IReadOnlyList<Spline> value) { }

	// RVA: 0x213C730 Offset: 0x213AD30 VA: 0x18213C730
	private static int IndexOf(IReadOnlyList<Spline> self, Spline elementToFind) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 6
	public KnotLinkCollection get_KnotLinkCollection() { }

	// RVA: 0x13EA160 Offset: 0x13E8760 VA: 0x1813EA160
	public Spline get_Item(int index) { }

	// RVA: 0x213CA10 Offset: 0x213B010 VA: 0x18213CA10
	private void OnEnable() { }

	// RVA: 0x213C9A0 Offset: 0x213AFA0 VA: 0x18213C9A0
	private void OnDisable() { }

	// RVA: 0x213CB20 Offset: 0x213B120 VA: 0x18213CB20
	private void OnSplineChanged(Spline spline, int index, SplineModification modificationType) { }

	// RVA: 0x213CA80 Offset: 0x213B080 VA: 0x18213CA80
	private void OnKnotModified(Spline spline, int index) { }

	// RVA: 0x213D120 Offset: 0x213B720 VA: 0x18213D120
	private bool get_IsScaled() { }

	// RVA: 0x213D1E0 Offset: 0x213B7E0 VA: 0x18213D1E0
	public Spline get_Spline() { }

	// RVA: 0x213D550 Offset: 0x213BB50 VA: 0x18213D550
	public void set_Spline(Spline value) { }

	// RVA: 0x213C600 Offset: 0x213AC00 VA: 0x18213C600
	public bool Evaluate(float t, out float3 position, out float3 tangent, out float3 upVector) { }

	// RVA: 0x213C6A0 Offset: 0x213ACA0 VA: 0x18213C6A0
	public bool Evaluate(int splineIndex, float t, out float3 position, out float3 tangent, out float3 upVector) { }

	// RVA: -1 Offset: -1
	public bool Evaluate<T>(T spline, float t, out float3 position, out float3 tangent, out float3 upVector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A3290 Offset: 0x7A1890 VA: 0x1807A3290
	|-SplineContainer.Evaluate<object>
	|
	|-RVA: 0x7A2CF0 Offset: 0x7A12F0 VA: 0x1807A2CF0
	|-SplineContainer.Evaluate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x213C210 Offset: 0x213A810 VA: 0x18213C210
	public float3 EvaluatePosition(float t) { }

	// RVA: 0x213C2B0 Offset: 0x213A8B0 VA: 0x18213C2B0
	public float3 EvaluatePosition(int splineIndex, float t) { }

	// RVA: -1 Offset: -1
	public float3 EvaluatePosition<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A19A0 Offset: 0x79FFA0 VA: 0x1807A19A0
	|-SplineContainer.EvaluatePosition<object>
	|
	|-RVA: 0x7A15A0 Offset: 0x79FBA0 VA: 0x1807A15A0
	|-SplineContainer.EvaluatePosition<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x213C410 Offset: 0x213AA10 VA: 0x18213C410
	public float3 EvaluateTangent(float t) { }

	// RVA: 0x213C360 Offset: 0x213A960 VA: 0x18213C360
	public float3 EvaluateTangent(int splineIndex, float t) { }

	// RVA: -1 Offset: -1
	public float3 EvaluateTangent<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A21D0 Offset: 0x7A07D0 VA: 0x1807A21D0
	|-SplineContainer.EvaluateTangent<object>
	|
	|-RVA: 0x7A1DD0 Offset: 0x7A03D0 VA: 0x1807A1DD0
	|-SplineContainer.EvaluateTangent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x213C560 Offset: 0x213AB60 VA: 0x18213C560
	public float3 EvaluateUpVector(float t) { }

	// RVA: 0x213C4B0 Offset: 0x213AAB0 VA: 0x18213C4B0
	public float3 EvaluateUpVector(int splineIndex, float t) { }

	// RVA: -1 Offset: -1
	public float3 EvaluateUpVector<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A2910 Offset: 0x7A0F10 VA: 0x1807A2910
	|-SplineContainer.EvaluateUpVector<object>
	|
	|-RVA: 0x7A24F0 Offset: 0x7A0AF0 VA: 0x1807A24F0
	|-SplineContainer.EvaluateUpVector<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x213C170 Offset: 0x213A770 VA: 0x18213C170
	public float3 EvaluateAcceleration(float t) { }

	// RVA: 0x213C0C0 Offset: 0x213A6C0 VA: 0x18213C0C0
	public float3 EvaluateAcceleration(int splineIndex, float t) { }

	// RVA: -1 Offset: -1
	public float3 EvaluateAcceleration<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A1150 Offset: 0x79F750 VA: 0x1807A1150
	|-SplineContainer.EvaluateAcceleration<object>
	|
	|-RVA: 0x7A0D40 Offset: 0x79F340 VA: 0x1807A0D40
	|-SplineContainer.EvaluateAcceleration<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x213C0B0 Offset: 0x213A6B0 VA: 0x18213C0B0
	public float CalculateLength() { }

	// RVA: 0x213BFB0 Offset: 0x213A5B0 VA: 0x18213BFB0
	public float CalculateLength(int splineIndex) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public void OnBeforeSerialize() { }

	// RVA: 0x213C7E0 Offset: 0x213ADE0 VA: 0x18213C7E0 Slot: 8
	public void OnAfterDeserialize() { }

	// RVA: 0x213CC60 Offset: 0x213B260 VA: 0x18213CC60
	public void .ctor() { }
}

// Namespace: UnityEngine.Splines
public interface IInterpolator<T> // TypeDefIndex: 12557
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Interpolate(T from, T to, float t);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IInterpolator<__Il2CppFullySharedGenericType>.Interpolate
	*/
}

// Namespace: UnityEngine.Splines
public enum PathIndexUnit // TypeDefIndex: 12558
{
	// Fields
	public int value__; // 0x0
	public const PathIndexUnit Distance = 0;
	public const PathIndexUnit Normalized = 1;
	public const PathIndexUnit Knot = 2;
}

// Namespace: UnityEngine.Splines
internal interface ISplineModificationHandler // TypeDefIndex: 12559
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSplineModified(SplineModificationData info);
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
[Serializable]
public class SplineData<T> : IEnumerable<DataPoint<T>>, IEnumerable, ISplineModificationHandler // TypeDefIndex: 12563
{
	// Fields
	private static readonly DataPointComparer<DataPoint<T>> k_DataPointComparer; // 0x0
	[SerializeField]
	private PathIndexUnit m_IndexUnit; // 0x0
	[SerializeField]
	private T m_DefaultValue; // 0x0
	[SerializeField]
	private List<DataPoint<T>> m_DataPoints; // 0x0
	private bool m_NeedsSort; // 0x0
	[CompilerGenerated]
	private Action changed; // 0x0
	[CompilerGenerated]
	private Action Changed; // 0x0

	// Properties
	public DataPoint<T> Item { get; set; }
	public PathIndexUnit PathIndexUnit { get; set; }
	public T DefaultValue { get; set; }
	public int Count { get; }
	public IEnumerable<float> Indexes { get; }

	// Methods

	// RVA: -1 Offset: -1
	public DataPoint<T> get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A62A0 Offset: 0x9A48A0 VA: 0x1809A62A0
	|-SplineData<int>.get_Item
	|
	|-RVA: 0x9A62D0 Offset: 0x9A48D0 VA: 0x1809A62D0
	|-SplineData<object>.get_Item
	|
	|-RVA: 0x9A6120 Offset: 0x9A4720 VA: 0x1809A6120
	|-SplineData<float>.get_Item
	|
	|-RVA: 0x9A61A0 Offset: 0x9A47A0 VA: 0x1809A61A0
	|-SplineData<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x9A6150 Offset: 0x9A4750 VA: 0x1809A6150
	|-SplineData<float4>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, DataPoint<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6DC0 Offset: 0x9A53C0 VA: 0x1809A6DC0
	|-SplineData<int>.set_Item
	|
	|-RVA: 0x9A6BC0 Offset: 0x9A51C0 VA: 0x1809A6BC0
	|-SplineData<object>.set_Item
	|
	|-RVA: 0x9A6EB0 Offset: 0x9A54B0 VA: 0x1809A6EB0
	|-SplineData<float>.set_Item
	|
	|-RVA: 0x9A6AF0 Offset: 0x9A50F0 VA: 0x1809A6AF0
	|-SplineData<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x9A6CC0 Offset: 0x9A52C0 VA: 0x1809A6CC0
	|-SplineData<float4>.set_Item
	*/

	// RVA: -1 Offset: -1
	public PathIndexUnit get_PathIndexUnit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	|-SplineData<int>.get_PathIndexUnit
	|-SplineData<object>.get_PathIndexUnit
	|-SplineData<float>.get_PathIndexUnit
	|-SplineData<float4>.get_PathIndexUnit
	|
	|-RVA: 0x886C10 Offset: 0x885210 VA: 0x180886C10
	|-SplineData<__Il2CppFullySharedGenericType>.get_PathIndexUnit
	*/

	// RVA: -1 Offset: -1
	public void set_PathIndexUnit(PathIndexUnit value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	|-SplineData<int>.set_PathIndexUnit
	|-SplineData<object>.set_PathIndexUnit
	|-SplineData<float>.set_PathIndexUnit
	|-SplineData<float4>.set_PathIndexUnit
	|
	|-RVA: 0x9A6FB0 Offset: 0x9A55B0 VA: 0x1809A6FB0
	|-SplineData<__Il2CppFullySharedGenericType>.set_PathIndexUnit
	*/

	// RVA: -1 Offset: -1
	public T get_DefaultValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	|-SplineData<int>.get_DefaultValue
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-SplineData<object>.get_DefaultValue
	|
	|-RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	|-SplineData<float>.get_DefaultValue
	|
	|-RVA: 0x9A57D0 Offset: 0x9A3DD0 VA: 0x1809A57D0
	|-SplineData<__Il2CppFullySharedGenericType>.get_DefaultValue
	|
	|-RVA: 0x87AB30 Offset: 0x879130 VA: 0x18087AB30
	|-SplineData<float4>.get_DefaultValue
	*/

	// RVA: -1 Offset: -1
	public void set_DefaultValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	|-SplineData<int>.set_DefaultValue
	|
	|-RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	|-SplineData<object>.set_DefaultValue
	|
	|-RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	|-SplineData<float>.set_DefaultValue
	|
	|-RVA: 0x9A6A00 Offset: 0x9A5000 VA: 0x1809A6A00
	|-SplineData<__Il2CppFullySharedGenericType>.set_DefaultValue
	|
	|-RVA: 0x9A6AD0 Offset: 0x9A50D0 VA: 0x1809A6AD0
	|-SplineData<float4>.set_DefaultValue
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965B90 Offset: 0x964190 VA: 0x180965B90
	|-SplineData<int>.get_Count
	|-SplineData<float>.get_Count
	|
	|-RVA: 0x51CA30 Offset: 0x51B030 VA: 0x18051CA30
	|-SplineData<object>.get_Count
	|
	|-RVA: 0x9A5770 Offset: 0x9A3D70 VA: 0x1809A5770
	|-SplineData<__Il2CppFullySharedGenericType>.get_Count
	|
	|-RVA: 0x9A5750 Offset: 0x9A3D50 VA: 0x1809A5750
	|-SplineData<float4>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<float> get_Indexes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5C10 Offset: 0x9A4210 VA: 0x1809A5C10
	|-SplineData<int>.get_Indexes
	|
	|-RVA: 0x9A5A60 Offset: 0x9A4060 VA: 0x1809A5A60
	|-SplineData<object>.get_Indexes
	|
	|-RVA: 0x9A5F70 Offset: 0x9A4570 VA: 0x1809A5F70
	|-SplineData<float>.get_Indexes
	|
	|-RVA: 0x9A5880 Offset: 0x9A3E80 VA: 0x1809A5880
	|-SplineData<__Il2CppFullySharedGenericType>.get_Indexes
	|
	|-RVA: 0x9A5DC0 Offset: 0x9A43C0 VA: 0x1809A5DC0
	|-SplineData<float4>.get_Indexes
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_changed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A5610 Offset: 0x9A3C10 VA: 0x1809A5610
	|-SplineData<int>.add_changed
	|
	|-RVA: 0x9A56B0 Offset: 0x9A3CB0 VA: 0x1809A56B0
	|-SplineData<object>.add_changed
	|
	|-RVA: 0x9A5570 Offset: 0x9A3B70 VA: 0x1809A5570
	|-SplineData<float>.add_changed
	|
	|-RVA: 0x9A5480 Offset: 0x9A3A80 VA: 0x1809A5480
	|-SplineData<__Il2CppFullySharedGenericType>.add_changed
	|
	|-RVA: 0x9A53E0 Offset: 0x9A39E0 VA: 0x1809A53E0
	|-SplineData<float4>.add_changed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_changed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A67D0 Offset: 0x9A4DD0 VA: 0x1809A67D0
	|-SplineData<int>.remove_changed
	|
	|-RVA: 0x9A6870 Offset: 0x9A4E70 VA: 0x1809A6870
	|-SplineData<object>.remove_changed
	|
	|-RVA: 0x9A6690 Offset: 0x9A4C90 VA: 0x1809A6690
	|-SplineData<float>.remove_changed
	|
	|-RVA: 0x9A6910 Offset: 0x9A4F10 VA: 0x1809A6910
	|-SplineData<__Il2CppFullySharedGenericType>.remove_changed
	|
	|-RVA: 0x9A6730 Offset: 0x9A4D30 VA: 0x1809A6730
	|-SplineData<float4>.remove_changed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_Changed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A52A0 Offset: 0x9A38A0 VA: 0x1809A52A0
	|-SplineData<int>.add_Changed
	|
	|-RVA: 0x9A5070 Offset: 0x9A3670 VA: 0x1809A5070
	|-SplineData<object>.add_Changed
	|
	|-RVA: 0x9A5340 Offset: 0x9A3940 VA: 0x1809A5340
	|-SplineData<float>.add_Changed
	|
	|-RVA: 0x9A51B0 Offset: 0x9A37B0 VA: 0x1809A51B0
	|-SplineData<__Il2CppFullySharedGenericType>.add_Changed
	|
	|-RVA: 0x9A5110 Offset: 0x9A3710 VA: 0x1809A5110
	|-SplineData<float4>.add_Changed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_Changed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6320 Offset: 0x9A4920 VA: 0x1809A6320
	|-SplineData<int>.remove_Changed
	|
	|-RVA: 0x9A6460 Offset: 0x9A4A60 VA: 0x1809A6460
	|-SplineData<object>.remove_Changed
	|
	|-RVA: 0x9A6500 Offset: 0x9A4B00 VA: 0x1809A6500
	|-SplineData<float>.remove_Changed
	|
	|-RVA: 0x9A65A0 Offset: 0x9A4BA0 VA: 0x1809A65A0
	|-SplineData<__Il2CppFullySharedGenericType>.remove_Changed
	|
	|-RVA: 0x9A63C0 Offset: 0x9A49C0 VA: 0x1809A63C0
	|-SplineData<float4>.remove_Changed
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A3590 Offset: 0x9A1B90 VA: 0x1809A3590
	|-SplineData<int>..ctor
	|-SplineData<float>..ctor
	|
	|-RVA: 0x9A4FE0 Offset: 0x9A35E0 VA: 0x1809A4FE0
	|-SplineData<object>..ctor
	|
	|-RVA: 0x9A3490 Offset: 0x9A1A90 VA: 0x1809A3490
	|-SplineData<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x9A3400 Offset: 0x9A1A00 VA: 0x1809A3400
	|-SplineData<float4>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T init) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A3620 Offset: 0x9A1C20 VA: 0x1809A3620
	|-SplineData<int>..ctor
	|
	|-RVA: 0x9A3AF0 Offset: 0x9A20F0 VA: 0x1809A3AF0
	|-SplineData<object>..ctor
	|
	|-RVA: 0x9A4EC0 Offset: 0x9A34C0 VA: 0x1809A4EC0
	|-SplineData<float>..ctor
	|
	|-RVA: 0x9A48D0 Offset: 0x9A2ED0 VA: 0x1809A48D0
	|-SplineData<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x9A3C10 Offset: 0x9A2210 VA: 0x1809A3C10
	|-SplineData<float4>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<DataPoint<T>> dataPoints) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A3740 Offset: 0x9A1D40 VA: 0x1809A3740
	|-SplineData<int>..ctor
	|
	|-RVA: 0x9A3D50 Offset: 0x9A2350 VA: 0x1809A3D50
	|-SplineData<object>..ctor
	|
	|-RVA: 0x9A4510 Offset: 0x9A2B10 VA: 0x1809A4510
	|-SplineData<float>..ctor
	|
	|-RVA: 0x9A4120 Offset: 0x9A2720 VA: 0x1809A4120
	|-SplineData<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x9A4AD0 Offset: 0x9A30D0 VA: 0x1809A4AD0
	|-SplineData<float4>..ctor
	*/

	// RVA: -1 Offset: -1
	private void SetDirty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A05B0 Offset: 0x99EBB0 VA: 0x1809A05B0
	|-SplineData<int>.SetDirty
	|-SplineData<float>.SetDirty
	|
	|-RVA: 0x9A05F0 Offset: 0x99EBF0 VA: 0x1809A05F0
	|-SplineData<object>.SetDirty
	|
	|-RVA: 0x9A0520 Offset: 0x99EB20 VA: 0x1809A0520
	|-SplineData<__Il2CppFullySharedGenericType>.SetDirty
	|
	|-RVA: 0x9A0630 Offset: 0x99EC30 VA: 0x1809A0630
	|-SplineData<float4>.SetDirty
	*/

	// RVA: -1 Offset: -1
	public void Add(float t, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99BE90 Offset: 0x99A490 VA: 0x18099BE90
	|-SplineData<int>.Add
	|
	|-RVA: 0x99C060 Offset: 0x99A660 VA: 0x18099C060
	|-SplineData<object>.Add
	|
	|-RVA: 0x99C0D0 Offset: 0x99A6D0 VA: 0x18099C0D0
	|-SplineData<float>.Add
	|
	|-RVA: 0x99C130 Offset: 0x99A730 VA: 0x18099C130
	|-SplineData<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x99BE00 Offset: 0x99A400 VA: 0x18099BE00
	|-SplineData<float4>.Add
	*/

	// RVA: -1 Offset: -1
	public int Add(DataPoint<T> dataPoint) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99B8F0 Offset: 0x999EF0 VA: 0x18099B8F0
	|-SplineData<int>.Add
	|
	|-RVA: 0x99BCA0 Offset: 0x99A2A0 VA: 0x18099BCA0
	|-SplineData<object>.Add
	|
	|-RVA: 0x99B7B0 Offset: 0x999DB0 VA: 0x18099B7B0
	|-SplineData<float>.Add
	|
	|-RVA: 0x99BA30 Offset: 0x99A030 VA: 0x18099BA30
	|-SplineData<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x99BEF0 Offset: 0x99A4F0 VA: 0x18099BEF0
	|-SplineData<float4>.Add
	*/

	// RVA: -1 Offset: -1
	public int AddDataPointWithDefaultValue(float t, bool useDefaultValue = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99B590 Offset: 0x999B90 VA: 0x18099B590
	|-SplineData<int>.AddDataPointWithDefaultValue
	|
	|-RVA: 0x99B130 Offset: 0x999730 VA: 0x18099B130
	|-SplineData<object>.AddDataPointWithDefaultValue
	|
	|-RVA: 0x99B380 Offset: 0x999980 VA: 0x18099B380
	|-SplineData<float>.AddDataPointWithDefaultValue
	|
	|-RVA: 0x99A750 Offset: 0x998D50 VA: 0x18099A750
	|-SplineData<__Il2CppFullySharedGenericType>.AddDataPointWithDefaultValue
	|
	|-RVA: 0x99AEB0 Offset: 0x9994B0 VA: 0x18099AEB0
	|-SplineData<float4>.AddDataPointWithDefaultValue
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99EDE0 Offset: 0x99D3E0 VA: 0x18099EDE0
	|-SplineData<int>.RemoveAt
	|-SplineData<float>.RemoveAt
	|
	|-RVA: 0x99EFA0 Offset: 0x99D5A0 VA: 0x18099EFA0
	|-SplineData<object>.RemoveAt
	|
	|-RVA: 0x99EEA0 Offset: 0x99D4A0 VA: 0x18099EEA0
	|-SplineData<__Il2CppFullySharedGenericType>.RemoveAt
	|
	|-RVA: 0x99ED20 Offset: 0x99D320 VA: 0x18099ED20
	|-SplineData<float4>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public bool RemoveDataPoint(float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99F700 Offset: 0x99DD00 VA: 0x18099F700
	|-SplineData<int>.RemoveDataPoint
	|
	|-RVA: 0x99F200 Offset: 0x99D800 VA: 0x18099F200
	|-SplineData<object>.RemoveDataPoint
	|
	|-RVA: 0x99F590 Offset: 0x99DB90 VA: 0x18099F590
	|-SplineData<float>.RemoveDataPoint
	|
	|-RVA: 0x99F380 Offset: 0x99D980 VA: 0x18099F380
	|-SplineData<__Il2CppFullySharedGenericType>.RemoveDataPoint
	|
	|-RVA: 0x99F060 Offset: 0x99D660 VA: 0x18099F060
	|-SplineData<float4>.RemoveDataPoint
	*/

	// RVA: -1 Offset: -1
	public int MoveDataPoint(int index, float newIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99EC10 Offset: 0x99D210 VA: 0x18099EC10
	|-SplineData<int>.MoveDataPoint
	|
	|-RVA: 0x99E600 Offset: 0x99CC00 VA: 0x18099E600
	|-SplineData<object>.MoveDataPoint
	|
	|-RVA: 0x99EAF0 Offset: 0x99D0F0 VA: 0x18099EAF0
	|-SplineData<float>.MoveDataPoint
	|
	|-RVA: 0x99E880 Offset: 0x99CE80 VA: 0x18099E880
	|-SplineData<__Il2CppFullySharedGenericType>.MoveDataPoint
	|
	|-RVA: 0x99E740 Offset: 0x99CD40 VA: 0x18099E740
	|-SplineData<float4>.MoveDataPoint
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99C490 Offset: 0x99AA90 VA: 0x18099C490
	|-SplineData<int>.Clear
	|-SplineData<float>.Clear
	|
	|-RVA: 0x99C4F0 Offset: 0x99AAF0 VA: 0x18099C4F0
	|-SplineData<object>.Clear
	|
	|-RVA: 0x99C410 Offset: 0x99AA10 VA: 0x18099C410
	|-SplineData<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x99C3B0 Offset: 0x99A9B0 VA: 0x18099C3B0
	|-SplineData<float4>.Clear
	*/

	// RVA: -1 Offset: -1
	private static int Wrap(int value, int lowerBound, int upperBound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A3190 Offset: 0x9A1790 VA: 0x1809A3190
	|-SplineData<int>.Wrap
	|-SplineData<object>.Wrap
	|-SplineData<float>.Wrap
	|-SplineData<__Il2CppFullySharedGenericType>.Wrap
	|-SplineData<float4>.Wrap
	*/

	// RVA: -1 Offset: -1
	private int ResolveBinaryIndex(int index, bool wrap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99F870 Offset: 0x99DE70 VA: 0x18099F870
	|-SplineData<int>.ResolveBinaryIndex
	|-SplineData<float>.ResolveBinaryIndex
	|
	|-RVA: 0x99FAF0 Offset: 0x99E0F0 VA: 0x18099FAF0
	|-SplineData<object>.ResolveBinaryIndex
	|
	|-RVA: 0x99F920 Offset: 0x99DF20 VA: 0x18099F920
	|-SplineData<__Il2CppFullySharedGenericType>.ResolveBinaryIndex
	|
	|-RVA: 0x99FA40 Offset: 0x99E040 VA: 0x18099FA40
	|-SplineData<float4>.ResolveBinaryIndex
	*/

	// RVA: -1 Offset: -1
	private ValueTuple<int, int, float> GetIndex(float t, float splineLength, int knotCount, bool closed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99D380 Offset: 0x99B980 VA: 0x18099D380
	|-SplineData<int>.GetIndex
	|
	|-RVA: 0x99CEB0 Offset: 0x99B4B0 VA: 0x18099CEB0
	|-SplineData<object>.GetIndex
	|
	|-RVA: 0x99E140 Offset: 0x99C740 VA: 0x18099E140
	|-SplineData<float>.GetIndex
	|
	|-RVA: 0x99D850 Offset: 0x99BE50 VA: 0x18099D850
	|-SplineData<__Il2CppFullySharedGenericType>.GetIndex
	|
	|-RVA: 0x99C9E0 Offset: 0x99AFE0 VA: 0x18099C9E0
	|-SplineData<float4>.GetIndex
	*/

	// RVA: -1 Offset: -1
	public T Evaluate<TSpline, TInterpolator>(TSpline spline, float t, PathIndexUnit indexUnit, TInterpolator interpolator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x609D00 Offset: 0x608300 VA: 0x180609D00
	|-SplineData<__Il2CppFullySharedGenericType>.Evaluate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Evaluate<TSpline, TInterpolator>(TSpline spline, float t, TInterpolator interpolator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6095C0 Offset: 0x607BC0 VA: 0x1806095C0
	|-SplineData<__Il2CppFullySharedGenericType>.Evaluate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetDataPoint(int index, DataPoint<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A0160 Offset: 0x99E760 VA: 0x1809A0160
	|-SplineData<int>.SetDataPoint
	|
	|-RVA: 0x9A0340 Offset: 0x99E940 VA: 0x1809A0340
	|-SplineData<object>.SetDataPoint
	|
	|-RVA: 0x9A0430 Offset: 0x99EA30 VA: 0x1809A0430
	|-SplineData<float>.SetDataPoint
	|
	|-RVA: 0x99FFF0 Offset: 0x99E5F0 VA: 0x18099FFF0
	|-SplineData<__Il2CppFullySharedGenericType>.SetDataPoint
	|
	|-RVA: 0x9A0240 Offset: 0x99E840 VA: 0x1809A0240
	|-SplineData<float4>.SetDataPoint
	*/

	// RVA: -1 Offset: -1
	public void SetDataPointNoSort(int index, DataPoint<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99FF60 Offset: 0x99E560 VA: 0x18099FF60
	|-SplineData<int>.SetDataPointNoSort
	|
	|-RVA: 0x99FEB0 Offset: 0x99E4B0 VA: 0x18099FEB0
	|-SplineData<object>.SetDataPointNoSort
	|
	|-RVA: 0x99FBA0 Offset: 0x99E1A0 VA: 0x18099FBA0
	|-SplineData<float>.SetDataPointNoSort
	|
	|-RVA: 0x99FC30 Offset: 0x99E230 VA: 0x18099FC30
	|-SplineData<__Il2CppFullySharedGenericType>.SetDataPointNoSort
	|
	|-RVA: 0x99FE00 Offset: 0x99E400 VA: 0x18099FE00
	|-SplineData<float4>.SetDataPointNoSort
	*/

	// RVA: -1 Offset: -1
	public void SortIfNecessary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A06E0 Offset: 0x99ECE0 VA: 0x1809A06E0
	|-SplineData<int>.SortIfNecessary
	|
	|-RVA: 0x9A0670 Offset: 0x99EC70 VA: 0x1809A0670
	|-SplineData<object>.SortIfNecessary
	|
	|-RVA: 0x9A08C0 Offset: 0x99EEC0 VA: 0x1809A08C0
	|-SplineData<float>.SortIfNecessary
	|
	|-RVA: 0x9A07C0 Offset: 0x99EDC0 VA: 0x1809A07C0
	|-SplineData<__Il2CppFullySharedGenericType>.SortIfNecessary
	|
	|-RVA: 0x9A0750 Offset: 0x99ED50 VA: 0x1809A0750
	|-SplineData<float4>.SortIfNecessary
	*/

	// RVA: -1 Offset: -1
	internal void ForceSort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99C770 Offset: 0x99AD70 VA: 0x18099C770
	|-SplineData<int>.ForceSort
	|
	|-RVA: 0x99C5E0 Offset: 0x99ABE0 VA: 0x18099C5E0
	|-SplineData<object>.ForceSort
	|
	|-RVA: 0x99C560 Offset: 0x99AB60 VA: 0x18099C560
	|-SplineData<float>.ForceSort
	|
	|-RVA: 0x99C660 Offset: 0x99AC60 VA: 0x18099C660
	|-SplineData<__Il2CppFullySharedGenericType>.ForceSort
	|
	|-RVA: 0x99C6F0 Offset: 0x99ACF0 VA: 0x18099C6F0
	|-SplineData<float4>.ForceSort
	*/

	// RVA: -1 Offset: -1
	public void ConvertPathUnit<TSplineType>(TSplineType spline, PathIndexUnit toUnit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x609090 Offset: 0x607690 VA: 0x180609090
	|-SplineData<__Il2CppFullySharedGenericType>.ConvertPathUnit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public float GetNormalizedInterpolation<TSplineType>(TSplineType spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60A070 Offset: 0x608670 VA: 0x18060A070
	|-SplineData<__Il2CppFullySharedGenericType>.GetNormalizedInterpolation<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(SplineData.<GetEnumerator>d__46<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<DataPoint<T>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99C7F0 Offset: 0x99ADF0 VA: 0x18099C7F0
	|-SplineData<int>.GetEnumerator
	|-SplineData<float>.GetEnumerator
	|
	|-RVA: 0x99C950 Offset: 0x99AF50 VA: 0x18099C950
	|-SplineData<object>.GetEnumerator
	|-SplineData<float4>.GetEnumerator
	|
	|-RVA: 0x99C880 Offset: 0x99AE80 VA: 0x18099C880
	|-SplineData<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A09D0 Offset: 0x99EFD0 VA: 0x1809A09D0
	|-SplineData<int>.System.Collections.IEnumerable.GetEnumerator
	|-SplineData<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9A0930 Offset: 0x99EF30 VA: 0x1809A0930
	|-SplineData<object>.System.Collections.IEnumerable.GetEnumerator
	|-SplineData<float4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9A0A70 Offset: 0x99F070 VA: 0x1809A0A70
	|-SplineData<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static float WrapInt(float index, int lowerBound, int upperBound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A2EB0 Offset: 0x9A14B0 VA: 0x1809A2EB0
	|-SplineData<int>.WrapInt
	|-SplineData<object>.WrapInt
	|-SplineData<float>.WrapInt
	|-SplineData<float4>.WrapInt
	|
	|-RVA: 0x9A3010 Offset: 0x9A1610 VA: 0x1809A3010
	|-SplineData<__Il2CppFullySharedGenericType>.WrapInt
	*/

	// RVA: -1 Offset: -1
	private static float ClampInt(float index, int lowerBound, int upperBound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99C2C0 Offset: 0x99A8C0 VA: 0x18099C2C0
	|-SplineData<int>.ClampInt
	|-SplineData<object>.ClampInt
	|-SplineData<float>.ClampInt
	|-SplineData<__Il2CppFullySharedGenericType>.ClampInt
	|-SplineData<float4>.ClampInt
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void UnityEngine.Splines.ISplineModificationHandler.OnSplineModified(SplineModificationData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A0AA0 Offset: 0x99F0A0 VA: 0x1809A0AA0
	|-SplineData<int>.UnityEngine.Splines.ISplineModificationHandler.OnSplineModified
	|
	|-RVA: 0x9A2130 Offset: 0x9A0730 VA: 0x1809A2130
	|-SplineData<object>.UnityEngine.Splines.ISplineModificationHandler.OnSplineModified
	|
	|-RVA: 0x9A1AB0 Offset: 0x9A00B0 VA: 0x1809A1AB0
	|-SplineData<float>.UnityEngine.Splines.ISplineModificationHandler.OnSplineModified
	|
	|-RVA: 0x9A10F0 Offset: 0x99F6F0 VA: 0x1809A10F0
	|-SplineData<__Il2CppFullySharedGenericType>.UnityEngine.Splines.ISplineModificationHandler.OnSplineModified
	|
	|-RVA: 0x9A2820 Offset: 0x9A0E20 VA: 0x1809A2820
	|-SplineData<float4>.UnityEngine.Splines.ISplineModificationHandler.OnSplineModified
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A32F0 Offset: 0x9A18F0 VA: 0x1809A32F0
	|-SplineData<int>..cctor
	|-SplineData<object>..cctor
	|-SplineData<float>..cctor
	|-SplineData<float4>..cctor
	|
	|-RVA: 0x9A31C0 Offset: 0x9A17C0 VA: 0x1809A31C0
	|-SplineData<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.Splines
[Serializable]
internal class SplineDataKeyValuePair<T> // TypeDefIndex: 12564
{
	// Fields
	public string Key; // 0x0
	public SplineData<T> Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-SplineDataKeyValuePair<int>..ctor
	|-SplineDataKeyValuePair<object>..ctor
	|-SplineDataKeyValuePair<float>..ctor
	|-SplineDataKeyValuePair<__Il2CppFullySharedGenericType>..ctor
	|-SplineDataKeyValuePair<float4>..ctor
	*/
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
[Serializable]
internal class SplineDataDictionary<T> : IEnumerable<SplineDataKeyValuePair<T>>, IEnumerable // TypeDefIndex: 12566
{
	// Fields
	[SerializeField]
	private List<SplineDataKeyValuePair<T>> m_Data; // 0x0

	// Properties
	public IEnumerable<string> Keys { get; }
	public IEnumerable<SplineData<T>> Values { get; }
	public SplineData<T> Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public IEnumerable<string> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9998B0 Offset: 0x997EB0 VA: 0x1809998B0
	|-SplineDataDictionary<int>.get_Keys
	|-SplineDataDictionary<object>.get_Keys
	|-SplineDataDictionary<float>.get_Keys
	|-SplineDataDictionary<float4>.get_Keys
	|
	|-RVA: 0x999A60 Offset: 0x998060 VA: 0x180999A60
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<SplineData<T>> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x999C30 Offset: 0x998230 VA: 0x180999C30
	|-SplineDataDictionary<int>.get_Values
	|-SplineDataDictionary<object>.get_Values
	|-SplineDataDictionary<float>.get_Values
	|-SplineDataDictionary<float4>.get_Values
	|
	|-RVA: 0x999DE0 Offset: 0x9983E0 VA: 0x180999DE0
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1
	private int FindIndex(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x997D40 Offset: 0x996340 VA: 0x180997D40
	|-SplineDataDictionary<int>.FindIndex
	|-SplineDataDictionary<object>.FindIndex
	|-SplineDataDictionary<float>.FindIndex
	|-SplineDataDictionary<float4>.FindIndex
	|
	|-RVA: 0x997DE0 Offset: 0x9963E0 VA: 0x180997DE0
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, out SplineData<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x999520 Offset: 0x997B20 VA: 0x180999520
	|-SplineDataDictionary<int>.TryGetValue
	|-SplineDataDictionary<object>.TryGetValue
	|-SplineDataDictionary<float>.TryGetValue
	|-SplineDataDictionary<float4>.TryGetValue
	|
	|-RVA: 0x9995C0 Offset: 0x997BC0 VA: 0x1809995C0
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public SplineData<T> GetOrCreate(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x997FD0 Offset: 0x9965D0 VA: 0x180997FD0
	|-SplineDataDictionary<int>.GetOrCreate
	|-SplineDataDictionary<float>.GetOrCreate
	|
	|-RVA: 0x998650 Offset: 0x996C50 VA: 0x180998650
	|-SplineDataDictionary<object>.GetOrCreate
	|
	|-RVA: 0x998230 Offset: 0x996830 VA: 0x180998230
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.GetOrCreate
	|
	|-RVA: 0x9983F0 Offset: 0x9969F0 VA: 0x1809983F0
	|-SplineDataDictionary<float4>.GetOrCreate
	*/

	// RVA: -1 Offset: -1
	public SplineData<T> get_Item(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9997B0 Offset: 0x997DB0 VA: 0x1809997B0
	|-SplineDataDictionary<int>.get_Item
	|-SplineDataDictionary<object>.get_Item
	|-SplineDataDictionary<float>.get_Item
	|-SplineDataDictionary<float4>.get_Item
	|
	|-RVA: 0x999860 Offset: 0x997E60 VA: 0x180999860
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(string key, SplineData<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99A120 Offset: 0x998720 VA: 0x18099A120
	|-SplineDataDictionary<int>.set_Item
	|
	|-RVA: 0x999FB0 Offset: 0x9985B0 VA: 0x180999FB0
	|-SplineDataDictionary<object>.set_Item
	|
	|-RVA: 0x99A290 Offset: 0x998890 VA: 0x18099A290
	|-SplineDataDictionary<float>.set_Item
	|
	|-RVA: 0x99A570 Offset: 0x998B70 VA: 0x18099A570
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x99A400 Offset: 0x998A00 VA: 0x18099A400
	|-SplineDataDictionary<float4>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x997CD0 Offset: 0x9962D0 VA: 0x180997CD0
	|-SplineDataDictionary<int>.Contains
	|-SplineDataDictionary<object>.Contains
	|-SplineDataDictionary<float>.Contains
	|-SplineDataDictionary<float4>.Contains
	|
	|-RVA: 0x997D00 Offset: 0x996300 VA: 0x180997D00
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<SplineDataKeyValuePair<T>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x997F60 Offset: 0x996560 VA: 0x180997F60
	|-SplineDataDictionary<int>.GetEnumerator
	|-SplineDataDictionary<object>.GetEnumerator
	|-SplineDataDictionary<float>.GetEnumerator
	|-SplineDataDictionary<float4>.GetEnumerator
	|
	|-RVA: 0x997EE0 Offset: 0x9964E0 VA: 0x180997EE0
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9993E0 Offset: 0x9979E0 VA: 0x1809993E0
	|-SplineDataDictionary<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x999430 Offset: 0x997A30 VA: 0x180999430
	|-SplineDataDictionary<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x999390 Offset: 0x997990 VA: 0x180999390
	|-SplineDataDictionary<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x999480 Offset: 0x997A80 VA: 0x180999480
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9994D0 Offset: 0x997AD0 VA: 0x1809994D0
	|-SplineDataDictionary<float4>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public bool Remove(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x999290 Offset: 0x997890 VA: 0x180999290
	|-SplineDataDictionary<int>.Remove
	|-SplineDataDictionary<object>.Remove
	|-SplineDataDictionary<float>.Remove
	|-SplineDataDictionary<float4>.Remove
	|
	|-RVA: 0x999300 Offset: 0x997900 VA: 0x180999300
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9990C0 Offset: 0x9976C0 VA: 0x1809990C0
	|-SplineDataDictionary<int>.RemoveEmpty
	|
	|-RVA: 0x998C50 Offset: 0x997250 VA: 0x180998C50
	|-SplineDataDictionary<object>.RemoveEmpty
	|
	|-RVA: 0x998A80 Offset: 0x997080 VA: 0x180998A80
	|-SplineDataDictionary<float>.RemoveEmpty
	|
	|-RVA: 0x998E20 Offset: 0x997420 VA: 0x180998E20
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>.RemoveEmpty
	|
	|-RVA: 0x9988B0 Offset: 0x996EB0 VA: 0x1809988B0
	|-SplineDataDictionary<float4>.RemoveEmpty
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x999690 Offset: 0x997C90 VA: 0x180999690
	|-SplineDataDictionary<int>..ctor
	|-SplineDataDictionary<object>..ctor
	|-SplineDataDictionary<float>..ctor
	|-SplineDataDictionary<float4>..ctor
	|
	|-RVA: 0x999720 Offset: 0x997D20 VA: 0x180999720
	|-SplineDataDictionary<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Splines
[Obsolete("Use SplineDataHandles.DataPointHandles instead and EditorTools to interact with SplineData.", False)]
[Usage(256)]
public abstract class SplineDataHandleAttribute : Attribute // TypeDefIndex: 12567
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Splines
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[AddComponentMenu("Splines/Spline Extrude")]
public class SplineExtrude : MonoBehaviour // TypeDefIndex: 12568
{
	// Fields
	[SerializeField]
	[Tooltip("The Spline to extrude.")]
	private SplineContainer m_Container; // 0x20
	[SerializeField]
	[Tooltip("Enable to regenerate the extruded mesh when the target Spline is modified. Disable this option if the Spline will not be modified at runtime.")]
	private bool m_RebuildOnSplineChange; // 0x28
	[SerializeField]
	[Tooltip("The maximum number of times per-second that the mesh will be rebuilt.")]
	private int m_RebuildFrequency; // 0x2C
	[SerializeField]
	[Tooltip("Automatically update any Mesh, Box, or Sphere collider components when the mesh is extruded.")]
	private bool m_UpdateColliders; // 0x30
	[SerializeField]
	[Tooltip("The number of sides that comprise the radius of the mesh.")]
	private int m_Sides; // 0x34
	[SerializeField]
	[Tooltip("The number of edge loops that comprise the length of one unit of the mesh. The total number of sections is equal to "Spline.GetLength() * segmentsPerUnit".")]
	private float m_SegmentsPerUnit; // 0x38
	[SerializeField]
	[Tooltip("Indicates if the start and end of the mesh are filled. When the Spline is closed this setting is ignored.")]
	private bool m_Capped; // 0x3C
	[SerializeField]
	[Tooltip("The radius of the extruded mesh.")]
	private float m_Radius; // 0x40
	[SerializeField]
	[Tooltip("The section of the Spline to extrude.")]
	private Vector2 m_Range; // 0x44
	private Mesh m_Mesh; // 0x50
	private bool m_RebuildRequested; // 0x58
	private float m_NextScheduledRebuild; // 0x5C

	// Properties
	[Obsolete("Use Container instead.", False)]
	public SplineContainer container { get; }
	public SplineContainer Container { get; set; }
	[Obsolete("Use RebuildOnSplineChange instead.", False)]
	public bool rebuildOnSplineChange { get; }
	public bool RebuildOnSplineChange { get; set; }
	[Obsolete("Use RebuildFrequency instead.", False)]
	public int rebuildFrequency { get; }
	public int RebuildFrequency { get; set; }
	[Obsolete("Use Sides instead.", False)]
	public int sides { get; }
	public int Sides { get; set; }
	[Obsolete("Use SegmentsPerUnit instead.", False)]
	public float segmentsPerUnit { get; }
	public float SegmentsPerUnit { get; set; }
	[Obsolete("Use Capped instead.", False)]
	public bool capped { get; }
	public bool Capped { get; set; }
	[Obsolete("Use Radius instead.", False)]
	public float radius { get; }
	public float Radius { get; set; }
	[Obsolete("Use Range instead.", False)]
	public Vector2 range { get; }
	public Vector2 Range { get; set; }
	[Obsolete("Use Spline instead.", False)]
	public Spline spline { get; }
	public Spline Spline { get; }
	public IReadOnlyList<Spline> Splines { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public SplineContainer get_container() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public SplineContainer get_Container() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Container(SplineContainer value) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_rebuildOnSplineChange() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_RebuildOnSplineChange() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_RebuildOnSplineChange(bool value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_rebuildFrequency() { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_RebuildFrequency() { }

	// RVA: 0x213EAC0 Offset: 0x213D0C0 VA: 0x18213EAC0
	public void set_RebuildFrequency(int value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public int get_sides() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public int get_Sides() { }

	// RVA: 0x213EAE0 Offset: 0x213D0E0 VA: 0x18213EAE0
	public void set_Sides(int value) { }

	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0
	public float get_segmentsPerUnit() { }

	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0
	public float get_SegmentsPerUnit() { }

	// RVA: 0x213EAD0 Offset: 0x213D0D0 VA: 0x18213EAD0
	public void set_SegmentsPerUnit(float value) { }

	// RVA: 0x9E9940 Offset: 0x9E7F40 VA: 0x1809E9940
	public bool get_capped() { }

	// RVA: 0x9E9940 Offset: 0x9E7F40 VA: 0x1809E9940
	public bool get_Capped() { }

	// RVA: 0x9E9950 Offset: 0x9E7F50 VA: 0x1809E9950
	public void set_Capped(bool value) { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_radius() { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_Radius() { }

	// RVA: 0x213EA80 Offset: 0x213D080 VA: 0x18213EA80
	public void set_Radius(float value) { }

	// RVA: 0x213EA00 Offset: 0x213D000 VA: 0x18213EA00
	public Vector2 get_range() { }

	// RVA: 0x213EA00 Offset: 0x213D000 VA: 0x18213EA00
	public Vector2 get_Range() { }

	// RVA: 0x213EA90 Offset: 0x213D090 VA: 0x18213EA90
	public void set_Range(Vector2 value) { }

	// RVA: 0x213EA20 Offset: 0x213D020 VA: 0x18213EA20
	public Spline get_spline() { }

	// RVA: 0x213EA20 Offset: 0x213D020 VA: 0x18213EA20
	public Spline get_Spline() { }

	// RVA: 0x213EA60 Offset: 0x213D060 VA: 0x18213EA60
	public IReadOnlyList<Spline> get_Splines() { }

	// RVA: 0x213E5F0 Offset: 0x213CBF0 VA: 0x18213E5F0
	internal void Reset() { }

	// RVA: 0x213E7F0 Offset: 0x213CDF0 VA: 0x18213E7F0
	private void Start() { }

	// RVA: 0x213E030 Offset: 0x213C630 VA: 0x18213E030
	private void OnEnable() { }

	// RVA: 0x213DFC0 Offset: 0x213C5C0 VA: 0x18213DFC0
	private void OnDisable() { }

	// RVA: 0x213E0A0 Offset: 0x213C6A0 VA: 0x18213E0A0
	private void OnSplineChanged(Spline spline, int knotIndex, SplineModification modificationType) { }

	// RVA: 0x213E980 Offset: 0x213CF80 VA: 0x18213E980
	private void Update() { }

	// RVA: 0x213E160 Offset: 0x213C760 VA: 0x18213E160
	public void Rebuild() { }

	// RVA: 0x213E150 Offset: 0x213C750 VA: 0x18213E150
	private void OnValidate() { }

	// RVA: 0x213DF40 Offset: 0x213C540 VA: 0x18213DF40
	internal Mesh CreateMeshAsset() { }

	// RVA: 0x213E9C0 Offset: 0x213CFC0 VA: 0x18213E9C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Splines
public static class SplineFactory // TypeDefIndex: 12569
{
	// Methods

	// RVA: 0x2140150 Offset: 0x213E750 VA: 0x182140150
	public static Spline CreateLinear(IList<float3> positions, bool closed = False) { }

	// RVA: 0x2140160 Offset: 0x213E760 VA: 0x182140160
	public static Spline CreateLinear(IList<float3> positions, IList<quaternion> rotations, bool closed = False) { }

	// RVA: 0x213EFE0 Offset: 0x213D5E0 VA: 0x18213EFE0
	public static Spline CreateCatmullRom(IList<float3> positions, bool closed = False) { }

	// RVA: 0x213EAF0 Offset: 0x213D0F0 VA: 0x18213EAF0
	internal static Spline CreateCatmullRom(IList<float3> positions, IList<quaternion> rotations, bool closed = False) { }

	// RVA: 0x2141510 Offset: 0x213FB10 VA: 0x182141510
	public static Spline CreateRoundedSquare(float radius, float rounding) { }

	// RVA: 0x213F4F0 Offset: 0x213DAF0 VA: 0x18213F4F0
	public static Spline CreateHelix(float radius, float height, int revolutions) { }

	// RVA: 0x21408D0 Offset: 0x213EED0 VA: 0x1821408D0
	public static Spline CreateRoundedCornerSquare(float size, float cornerRadius) { }

	// RVA: 0x2141B00 Offset: 0x2140100 VA: 0x182141B00
	public static Spline CreateSquare(float size) { }

	// RVA: 0x213EFF0 Offset: 0x213D5F0 VA: 0x18213EFF0
	public static Spline CreateCircle(float radius) { }

	// RVA: 0x21403F0 Offset: 0x213E9F0 VA: 0x1821403F0
	public static Spline CreatePolygon(float edgeSize, int sides) { }

	// RVA: 0x2141C90 Offset: 0x2140290 VA: 0x182141C90
	public static Spline CreateStarPolygon(float edgeSize, int corners, float concavity) { }
}

// Namespace: UnityEngine.Splines
[Serializable]
public struct SplineInfo : IEquatable<SplineInfo>, ISerializationCallbackReceiver // TypeDefIndex: 12570
{
	// Fields
	[SerializeField]
	private Object m_Object; // 0x0
	[SerializeReference]
	private ISplineContainer m_Container; // 0x8
	[SerializeField]
	private int m_SplineIndex; // 0x10

	// Properties
	public Object Object { get; }
	public ISplineContainer Container { get; set; }
	public Transform Transform { get; }
	public Spline Spline { get; }
	public int Index { get; set; }
	public float4x4 LocalToWorld { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public Object get_Object() { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public ISplineContainer get_Container() { }

	// RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	public void set_Container(ISplineContainer value) { }

	// RVA: 0x2142890 Offset: 0x2140E90 VA: 0x182142890
	public Transform get_Transform() { }

	// RVA: 0x21427C0 Offset: 0x2140DC0 VA: 0x1821427C0
	public Spline get_Spline() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Index() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_Index(int value) { }

	// RVA: 0x2142640 Offset: 0x2140C40 VA: 0x182142640
	public float4x4 get_LocalToWorld() { }

	// RVA: 0x2142550 Offset: 0x2140B50 VA: 0x182142550
	public void .ctor(ISplineContainer container, int index) { }

	// RVA: 0x21423B0 Offset: 0x21409B0 VA: 0x1821423B0 Slot: 4
	public bool Equals(SplineInfo other) { }

	// RVA: 0x2142300 Offset: 0x2140900 VA: 0x182142300 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2142400 Offset: 0x2140A00 VA: 0x182142400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21424C0 Offset: 0x2140AC0 VA: 0x1821424C0 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x2142450 Offset: 0x2140A50 VA: 0x182142450 Slot: 6
	public void OnAfterDeserialize() { }
}

// Namespace: UnityEngine.Splines
[ExecuteInEditMode]
[AddComponentMenu("Splines/Spline Instantiate")]
public class SplineInstantiate : SplineComponent // TypeDefIndex: 12578
{
	// Fields
	[SerializeField]
	private SplineContainer m_Container; // 0x28
	[SerializeField]
	private List<SplineInstantiate.InstantiableItem> m_ItemsToInstantiate; // 0x30
	[SerializeField]
	private SplineInstantiate.Method m_Method; // 0x38
	[SerializeField]
	private SplineInstantiate.Space m_Space; // 0x3C
	[SerializeField]
	private Vector2 m_Spacing; // 0x40
	[SerializeField]
	private SplineComponent.AlignAxis m_Up; // 0x48
	[SerializeField]
	private SplineComponent.AlignAxis m_Forward; // 0x4C
	[SerializeField]
	private SplineInstantiate.Vector3Offset m_PositionOffset; // 0x50
	[SerializeField]
	private SplineInstantiate.Vector3Offset m_RotationOffset; // 0x74
	[SerializeField]
	private SplineInstantiate.Vector3Offset m_ScaleOffset; // 0x98
	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("m_Instances")]
	private List<GameObject> m_DeprecatedInstances; // 0xC0
	private const string k_InstancesRootName = "root-";
	private GameObject m_InstancesRoot; // 0xC8
	private readonly List<GameObject> m_Instances; // 0xD0
	private bool m_InstancesCacheDirty; // 0xD8
	[SerializeField]
	private bool m_AutoRefresh; // 0xD9
	private SplineInstantiate.InstantiableItem m_CurrentItem; // 0xE0
	private bool m_SplineDirty; // 0xF8
	private float m_MaxProbability; // 0xFC
	[SerializeField]
	private int m_Seed; // 0x100
	private List<float> m_TimesCache; // 0x108
	private List<float> m_LengthsCache; // 0x110

	// Properties
	[Obsolete("Use Container instead.", False)]
	public SplineContainer container { get; }
	public SplineContainer Container { get; set; }
	public SplineInstantiate.InstantiableItem[] itemsToInstantiate { get; set; }
	[Obsolete("Use InstantiateMethod instead.", False)]
	public SplineInstantiate.Method method { get; }
	public SplineInstantiate.Method InstantiateMethod { get; set; }
	[Obsolete("Use CoordinateSpace instead.", False)]
	public SplineInstantiate.Space space { get; }
	public SplineInstantiate.Space CoordinateSpace { get; set; }
	public float MinSpacing { get; set; }
	public float MaxSpacing { get; set; }
	[Obsolete("Use UpAxis instead.", False)]
	public SplineComponent.AlignAxis upAxis { get; }
	public SplineComponent.AlignAxis UpAxis { get; set; }
	[Obsolete("Use ForwardAxis instead.", False)]
	public SplineComponent.AlignAxis forwardAxis { get; }
	public SplineComponent.AlignAxis ForwardAxis { get; set; }
	[Obsolete("Use MinPositionOffset instead.", False)]
	public Vector3 minPositionOffset { get; }
	public Vector3 MinPositionOffset { get; set; }
	[Obsolete("Use MaxPositionOffset instead.", False)]
	public Vector3 maxPositionOffset { get; }
	public Vector3 MaxPositionOffset { get; set; }
	[Obsolete("Use PositionSpace instead.", False)]
	public SplineInstantiate.OffsetSpace positionSpace { get; }
	public SplineInstantiate.OffsetSpace PositionSpace { get; set; }
	[Obsolete("Use MinRotationOffset instead.", False)]
	public Vector3 minRotationOffset { get; }
	public Vector3 MinRotationOffset { get; set; }
	[Obsolete("Use MaxRotationOffset instead.", False)]
	public Vector3 maxRotationOffset { get; }
	public Vector3 MaxRotationOffset { get; set; }
	[Obsolete("Use RotationSpace instead.", False)]
	public SplineInstantiate.OffsetSpace rotationSpace { get; }
	public SplineInstantiate.OffsetSpace RotationSpace { get; set; }
	[Obsolete("Use MinScaleOffset instead.", False)]
	public Vector3 minScaleOffset { get; }
	public Vector3 MinScaleOffset { get; set; }
	[Obsolete("Use MaxScaleOffset instead.", False)]
	public Vector3 maxScaleOffset { get; }
	public Vector3 MaxScaleOffset { get; set; }
	[Obsolete("Use ScaleSpace instead.", False)]
	public SplineInstantiate.OffsetSpace scaleSpace { get; }
	public SplineInstantiate.OffsetSpace ScaleSpace { get; set; }
	internal GameObject InstancesRoot { get; }
	private Transform instancesRootTransform { get; }
	internal List<GameObject> instances { get; }
	private float maxProbability { get; set; }
	public int Seed { get; set; }

	// Methods

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public SplineContainer get_container() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public SplineContainer get_Container() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Container(SplineContainer value) { }

	// RVA: 0x21474B0 Offset: 0x2145AB0 VA: 0x1821474B0
	public SplineInstantiate.InstantiableItem[] get_itemsToInstantiate() { }

	// RVA: 0x2147970 Offset: 0x2145F70 VA: 0x182147970
	public void set_itemsToInstantiate(SplineInstantiate.InstantiableItem[] value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public SplineInstantiate.Method get_method() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public SplineInstantiate.Method get_InstantiateMethod() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_InstantiateMethod(SplineInstantiate.Method value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public SplineInstantiate.Space get_space() { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public SplineInstantiate.Space get_CoordinateSpace() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_CoordinateSpace(SplineInstantiate.Space value) { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_MinSpacing() { }

	// RVA: 0x21478D0 Offset: 0x2145ED0 VA: 0x1821478D0
	public void set_MinSpacing(float value) { }

	// RVA: 0x46E1F0 Offset: 0x46C7F0 VA: 0x18046E1F0
	public float get_MaxSpacing() { }

	// RVA: 0x2147710 Offset: 0x2145D10 VA: 0x182147710
	public void set_MaxSpacing(float value) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public SplineComponent.AlignAxis get_upAxis() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public SplineComponent.AlignAxis get_UpAxis() { }

	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	public void set_UpAxis(SplineComponent.AlignAxis value) { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public SplineComponent.AlignAxis get_forwardAxis() { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public SplineComponent.AlignAxis get_ForwardAxis() { }

	// RVA: 0x2147510 Offset: 0x2145B10 VA: 0x182147510
	public void set_ForwardAxis(SplineComponent.AlignAxis value) { }

	// RVA: 0x20D6DF0 Offset: 0x20D53F0 VA: 0x1820D6DF0
	public Vector3 get_minPositionOffset() { }

	// RVA: 0x20D6DF0 Offset: 0x20D53F0 VA: 0x1820D6DF0
	public Vector3 get_MinPositionOffset() { }

	// RVA: 0x2147730 Offset: 0x2145D30 VA: 0x182147730
	public void set_MinPositionOffset(Vector3 value) { }

	// RVA: 0x2147230 Offset: 0x2145830 VA: 0x182147230
	public Vector3 get_maxPositionOffset() { }

	// RVA: 0x2147230 Offset: 0x2145830 VA: 0x182147230
	public Vector3 get_MaxPositionOffset() { }

	// RVA: 0x2147570 Offset: 0x2145B70 VA: 0x182147570
	public void set_MaxPositionOffset(Vector3 value) { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	public SplineInstantiate.OffsetSpace get_positionSpace() { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	public SplineInstantiate.OffsetSpace get_PositionSpace() { }

	// RVA: 0x21478F0 Offset: 0x2145EF0 VA: 0x1821478F0
	public void set_PositionSpace(SplineInstantiate.OffsetSpace value) { }

	// RVA: 0x2147250 Offset: 0x2145850 VA: 0x182147250
	public Vector3 get_minRotationOffset() { }

	// RVA: 0x2147250 Offset: 0x2145850 VA: 0x182147250
	public Vector3 get_MinRotationOffset() { }

	// RVA: 0x21477A0 Offset: 0x2145DA0 VA: 0x1821477A0
	public void set_MinRotationOffset(Vector3 value) { }

	// RVA: 0x420BA0 Offset: 0x41F1A0 VA: 0x180420BA0
	public Vector3 get_maxRotationOffset() { }

	// RVA: 0x420BA0 Offset: 0x41F1A0 VA: 0x180420BA0
	public Vector3 get_MaxRotationOffset() { }

	// RVA: 0x21475E0 Offset: 0x2145BE0 VA: 0x1821475E0
	public void set_MaxRotationOffset(Vector3 value) { }

	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90
	public SplineInstantiate.OffsetSpace get_rotationSpace() { }

	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90
	public SplineInstantiate.OffsetSpace get_RotationSpace() { }

	// RVA: 0x2147910 Offset: 0x2145F10 VA: 0x182147910
	public void set_RotationSpace(SplineInstantiate.OffsetSpace value) { }

	// RVA: 0x12ECB30 Offset: 0x12EB130 VA: 0x1812ECB30
	public Vector3 get_minScaleOffset() { }

	// RVA: 0x12ECB30 Offset: 0x12EB130 VA: 0x1812ECB30
	public Vector3 get_MinScaleOffset() { }

	// RVA: 0x2147830 Offset: 0x2145E30 VA: 0x182147830
	public void set_MinScaleOffset(Vector3 value) { }

	// RVA: 0x12ECAF0 Offset: 0x12EB0F0 VA: 0x1812ECAF0
	public Vector3 get_maxScaleOffset() { }

	// RVA: 0x12ECAF0 Offset: 0x12EB0F0 VA: 0x1812ECAF0
	public Vector3 get_MaxScaleOffset() { }

	// RVA: 0x2147670 Offset: 0x2145C70 VA: 0x182147670
	public void set_MaxScaleOffset(Vector3 value) { }

	// RVA: 0x3A3470 Offset: 0x3A1A70 VA: 0x1803A3470
	public SplineInstantiate.OffsetSpace get_scaleSpace() { }

	// RVA: 0x3A3470 Offset: 0x3A1A70 VA: 0x1803A3470
	public SplineInstantiate.OffsetSpace get_ScaleSpace() { }

	// RVA: 0x2147930 Offset: 0x2145F30 VA: 0x182147930
	public void set_ScaleSpace(SplineInstantiate.OffsetSpace value) { }

	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	internal GameObject get_InstancesRoot() { }

	// RVA: 0x2147270 Offset: 0x2145870 VA: 0x182147270
	private Transform get_instancesRootTransform() { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	internal List<GameObject> get_instances() { }

	// RVA: 0x2147500 Offset: 0x2145B00 VA: 0x182147500
	private float get_maxProbability() { }

	// RVA: 0x2147A00 Offset: 0x2146000 VA: 0x182147A00
	private void set_maxProbability(float value) { }

	// RVA: 0x561290 Offset: 0x55F890 VA: 0x180561290
	public int get_Seed() { }

	// RVA: 0x2147960 Offset: 0x2145F60 VA: 0x182147960
	public void set_Seed(int value) { }

	// RVA: 0x21436F0 Offset: 0x2141CF0 VA: 0x1821436F0
	private void OnEnable() { }

	// RVA: 0x2143670 Offset: 0x2141C70 VA: 0x182143670
	private void OnDisable() { }

	// RVA: 0x21440E0 Offset: 0x21426E0 VA: 0x1821440E0
	private void UndoRedoPerformed() { }

	// RVA: 0x2143840 Offset: 0x2141E40 VA: 0x182143840
	private void OnValidate() { }

	// RVA: 0x2142E50 Offset: 0x2141450 VA: 0x182142E50
	private void EnsureItemsValidity() { }

	// RVA: 0x2142900 Offset: 0x2140F00 VA: 0x182142900
	private void CheckChildrenValidity() { }

	// RVA: 0x2147000 Offset: 0x2145600 VA: 0x182147000
	private void ValidateSpacing() { }

	// RVA: 0x2146FB0 Offset: 0x21455B0 VA: 0x182146FB0
	private void ValidateAxis() { }

	// RVA: 0x2143980 Offset: 0x2141F80 VA: 0x182143980
	internal void SetSplineDirty(Spline spline) { }

	// RVA: 0x21435E0 Offset: 0x2141BE0 VA: 0x1821435E0
	private void InitContainer() { }

	// RVA: 0x2142E40 Offset: 0x2141440 VA: 0x182142E40
	public void Clear() { }

	// RVA: 0x2143970 Offset: 0x2141F70 VA: 0x182143970
	public void SetDirty() { }

	// RVA: 0x2143F10 Offset: 0x2142510 VA: 0x182143F10
	private void TryClearCache() { }

	// RVA: 0x2142CC0 Offset: 0x21412C0 VA: 0x182142CC0
	private void ClearDeprecatedInstances() { }

	// RVA: 0x2143930 Offset: 0x2141F30 VA: 0x182143930
	public void Randomize() { }

	// RVA: 0x2146F90 Offset: 0x2145590 VA: 0x182146F90
	private void Update() { }

	// RVA: 0x21440F0 Offset: 0x21426F0 VA: 0x1821440F0
	public void UpdateInstances() { }

	// RVA: 0x2143A40 Offset: 0x2142040 VA: 0x182143A40
	private bool SpawnPrefab(int index) { }

	// RVA: 0x2143190 Offset: 0x2141790 VA: 0x182143190
	private void GetCustomSpaceAxis(SplineInstantiate.OffsetSpace space, float3 splineUp, float3 direction, Transform instanceTransform, out float3 customUp, out float3 customForward) { }

	// RVA: 0x21434B0 Offset: 0x2141AB0 VA: 0x1821434B0
	private int GetPrefabIndex() { }

	// RVA: 0x2143790 Offset: 0x2141D90 VA: 0x182143790
	private void OnSplineChanged(Spline spline, int knotIndex, SplineModification modificationType) { }

	// RVA: 0x2147080 Offset: 0x2145680 VA: 0x182147080
	public void .ctor() { }
}

// Namespace: UnityEngine.Splines
public struct GetPosition : IJobParallelFor // TypeDefIndex: 12579
{
	// Fields
	[ReadOnly]
	public NativeSpline Spline; // 0x0
	[WriteOnly]
	public NativeArray<float3> Positions; // 0x48

	// Methods

	// RVA: 0x214EF10 Offset: 0x214D510 VA: 0x18214EF10 Slot: 4
	public void Execute(int index) { }
}

// Namespace: UnityEngine.Splines
public struct GetPositionTangentNormal : IJobParallelFor // TypeDefIndex: 12580
{
	// Fields
	[ReadOnly]
	public NativeSpline Spline; // 0x0
	[WriteOnly]
	public NativeArray<float3> Positions; // 0x48
	[WriteOnly]
	public NativeArray<float3> Tangents; // 0x58
	[WriteOnly]
	public NativeArray<float3> Normals; // 0x68

	// Methods

	// RVA: 0x214EDE0 Offset: 0x214D3E0 VA: 0x18214EDE0 Slot: 4
	public void Execute(int index) { }
}

// Namespace: UnityEngine.Splines
public static class SplineJobs // TypeDefIndex: 12581
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EvaluatePosition<T>(T spline, NativeArray<float3> positions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A3920 Offset: 0x7A1F20 VA: 0x1807A3920
	|-SplineJobs.EvaluatePosition<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x214F950 Offset: 0x214DF50 VA: 0x18214F950
	public static void EvaluatePosition(NativeSpline spline, NativeArray<float3> positions) { }

	// RVA: -1 Offset: -1
	public static void EvaluatePositionTangentNormal<T>(T spline, NativeArray<float3> positions, NativeArray<float3> tangents, NativeArray<float3> normals) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A3770 Offset: 0x7A1D70 VA: 0x1807A3770
	|-SplineJobs.EvaluatePositionTangentNormal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x214F810 Offset: 0x214DE10 VA: 0x18214F810
	public static void EvaluatePositionTangentNormal(NativeSpline spline, NativeArray<float3> positions, NativeArray<float3> tangents, NativeArray<float3> normals) { }
}

// Namespace: UnityEngine.Splines
[Serializable]
public struct SplineKnotIndex : IEquatable<SplineKnotIndex> // TypeDefIndex: 12582
{
	// Fields
	public static SplineKnotIndex Invalid; // 0x0
	public int Spline; // 0x0
	public int Knot; // 0x4

	// Methods

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int spline, int knot) { }

	// RVA: 0x214FC00 Offset: 0x214E200 VA: 0x18214FC00
	public static bool op_Equality(SplineKnotIndex indexA, SplineKnotIndex indexB) { }

	// RVA: 0x214FC80 Offset: 0x214E280 VA: 0x18214FC80
	public static bool op_Inequality(SplineKnotIndex indexA, SplineKnotIndex indexB) { }

	// RVA: 0x1FE7450 Offset: 0x1FE5A50 VA: 0x181FE7450 Slot: 4
	public bool Equals(SplineKnotIndex otherIndex) { }

	// RVA: 0x214FA60 Offset: 0x214E060 VA: 0x18214FA60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214FB10 Offset: 0x214E110 VA: 0x18214FB10
	public bool IsValid() { }

	// RVA: 0x19590C0 Offset: 0x19576C0 VA: 0x1819590C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214FB30 Offset: 0x214E130 VA: 0x18214FB30 Slot: 3
	public override string ToString() { }

	// RVA: 0x214FBB0 Offset: 0x214E1B0 VA: 0x18214FBB0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Splines
public static class SplineMath // TypeDefIndex: 12583
{
	// Methods

	// RVA: 0x2150580 Offset: 0x214EB80 VA: 0x182150580
	public static float RayLineParameter(float3 ro, float3 rd, float3 lineOrigin, float3 lineDir) { }

	// RVA: 0x2150050 Offset: 0x214E650 VA: 0x182150050
	public static float3 RayLineDistance(float3 ro, float3 rd, float3 a, float3 b) { }

	// RVA: 0x21504C0 Offset: 0x214EAC0 VA: 0x1821504C0
	public static ValueTuple<float3, float3> RayLineNearestPoint(float3 ro, float3 rd, float3 a, float3 b) { }

	// RVA: 0x2150140 Offset: 0x214E740 VA: 0x182150140
	public static ValueTuple<float3, float3> RayLineNearestPoint(float3 ro, float3 rd, float3 a, float3 b, out float rayParam, out float lineParam) { }

	// RVA: 0x214FE50 Offset: 0x214E450 VA: 0x18214FE50
	public static float3 PointLineNearestPoint(float3 p, float3 a, float3 b, out float lineParam) { }

	// RVA: 0x214FD00 Offset: 0x214E300 VA: 0x18214FD00
	public static float DistancePointLine(float3 p, float3 a, float3 b) { }

	// RVA: 0x214FDD0 Offset: 0x214E3D0 VA: 0x18214FDD0
	internal static float GetUnitCircleTangentLength() { }
}

// Namespace: UnityEngine.Splines
public static class SplineMesh // TypeDefIndex: 12587
{
	// Fields
	private const float k_RadiusMin = 1E-05;
	private const float k_RadiusMax = 10000;
	private const int k_SidesMin = 3;
	private const int k_SidesMax = 2084;
	private const int k_SegmentsMin = 2;
	private const int k_SegmentsMax = 4096;
	private static readonly VertexAttributeDescriptor[] k_PipeVertexAttribs; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void ExtrudeRing<T, K>(T spline, float t, NativeArray<K> data, int start, int count, float radius) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A4800 Offset: 0x7A2E00 VA: 0x1807A4800
	|-SplineMesh.ExtrudeRing<object, SplineMesh.VertexData>
	|
	|-RVA: 0x7A3AA0 Offset: 0x7A20A0 VA: 0x1807A3AA0
	|-SplineMesh.ExtrudeRing<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2150760 Offset: 0x214ED60 VA: 0x182150760
	public static void GetVertexAndIndexCount(int sides, int segments, bool capped, bool closed, Vector2 range, out int vertexCount, out int indexCount) { }

	// RVA: 0x2150710 Offset: 0x214ED10 VA: 0x182150710
	private static void GetVertexAndIndexCount(SplineMesh.Settings settings, out int vertexCount, out int indexCount) { }

	// RVA: -1 Offset: -1
	public static void Extrude<T>(T spline, Mesh mesh, float radius, int sides, int segments, bool capped = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A6EB0 Offset: 0x7A54B0 VA: 0x1807A6EB0
	|-SplineMesh.Extrude<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Extrude<T>(T spline, Mesh mesh, float radius, int sides, int segments, bool capped, float2 range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A6940 Offset: 0x7A4F40 VA: 0x1807A6940
	|-SplineMesh.Extrude<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Extrude<T>(IReadOnlyList<T> splines, Mesh mesh, float radius, int sides, float segmentsPerUnit, bool capped, float2 range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A8A20 Offset: 0x7A7020 VA: 0x1807A8A20
	|-SplineMesh.Extrude<object>
	|
	|-RVA: 0x7A7060 Offset: 0x7A5660 VA: 0x1807A7060
	|-SplineMesh.Extrude<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Extrude<TSplineType, TVertexType, TIndexType>(TSplineType spline, NativeArray<TVertexType> vertices, NativeArray<TIndexType> indices, float radius, int sides, int segments, bool capped, float2 range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A66C0 Offset: 0x7A4CC0 VA: 0x1807A66C0
	|-SplineMesh.Extrude<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void Extrude<TSplineType, TVertexType, TIndexType>(TSplineType spline, NativeArray<TVertexType> vertices, NativeArray<TIndexType> indices, SplineMesh.Settings settings, int vertexArrayOffset = 0, int indicesArrayOffset = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A7D80 Offset: 0x7A6380 VA: 0x1807A7D80
	|-SplineMesh.Extrude<object, SplineMesh.VertexData, ushort>
	|-SplineMesh.Extrude<object, SplineMesh.VertexData, uint>
	|
	|-RVA: 0x7A5060 Offset: 0x7A3660 VA: 0x1807A5060
	|-SplineMesh.Extrude<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2150A90 Offset: 0x214F090 VA: 0x182150A90
	private static void WindTris(NativeArray<ushort> indices, SplineMesh.Settings settings, int vertexArrayOffset = 0, int indexArrayOffset = 0) { }

	// RVA: 0x21508A0 Offset: 0x214EEA0 VA: 0x1821508A0
	private static void WindTris(NativeArray<uint> indices, SplineMesh.Settings settings, int vertexArrayOffset = 0, int indexArrayOffset = 0) { }

	// RVA: 0x2150CC0 Offset: 0x214F2C0 VA: 0x182150CC0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Splines
public enum SplineModification // TypeDefIndex: 12588
{
	// Fields
	public int value__; // 0x0
	public const SplineModification Default = 0;
	public const SplineModification ClosedModified = 1;
	public const SplineModification KnotModified = 2;
	public const SplineModification KnotInserted = 3;
	public const SplineModification KnotRemoved = 4;
	public const SplineModification KnotReordered = 5;
}

// Namespace: UnityEngine.Splines
internal struct SplineModificationData // TypeDefIndex: 12589
{
	// Fields
	public readonly Spline Spline; // 0x0
	public readonly SplineModification Modification; // 0x8
	public readonly int KnotIndex; // 0xC
	public readonly float PrevCurveLength; // 0x10
	public readonly float NextCurveLength; // 0x14

	// Methods

	// RVA: 0x2150DF0 Offset: 0x214F3F0 VA: 0x182150DF0
	public void .ctor(Spline spline, SplineModification modification, int knotIndex, float prevCurveLength, float nextCurveLength) { }
}

// Namespace: UnityEngine.Splines
[Serializable]
internal class SplinePathRef // TypeDefIndex: 12591
{
	// Fields
	[SerializeField]
	public SplinePathRef.SliceRef[] Splines; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x2150E40 Offset: 0x214F440 VA: 0x182150E40
	public void .ctor(IEnumerable<SplinePathRef.SliceRef> slices) { }
}

// Namespace: UnityEngine.Splines
public class SplinePath : SplinePath<SplineSlice<Spline>> // TypeDefIndex: 12592
{
	// Methods

	// RVA: 0x2150EA0 Offset: 0x214F4A0 VA: 0x182150EA0
	public void .ctor(IEnumerable<SplineSlice<Spline>> slices) { }
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
public class SplinePath<T> : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>, IHasEmptyCurves // TypeDefIndex: 12594
{
	// Fields
	private T[] m_Splines; // 0x0
	private int[] m_Splits; // 0x0

	// Properties
	public IReadOnlyList<T> Slices { get; set; }
	public int Count { get; }
	public BezierKnot Item { get; }
	public BezierKnot Item { get; }
	public bool Closed { get; }
	public IReadOnlyList<int> EmptyCurves { get; }

	// Methods

	// RVA: -1 Offset: -1
	public IReadOnlyList<T> get_Slices() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-SplinePath<SplineSlice<object>>.get_Slices
	|-SplinePath<object>.get_Slices
	|-SplinePath<__Il2CppFullySharedGenericType>.get_Slices
	*/

	// RVA: -1 Offset: -1
	public void set_Slices(IReadOnlyList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB530 Offset: 0x9A9B30 VA: 0x1809AB530
	|-SplinePath<SplineSlice<object>>.set_Slices
	|
	|-RVA: 0x9AB460 Offset: 0x9A9A60 VA: 0x1809AB460
	|-SplinePath<object>.set_Slices
	|
	|-RVA: 0x9AB4C0 Offset: 0x9A9AC0 VA: 0x1809AB4C0
	|-SplinePath<__Il2CppFullySharedGenericType>.set_Slices
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> slices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AA6C0 Offset: 0x9A8CC0 VA: 0x1809AA6C0
	|-SplinePath<SplineSlice<object>>..ctor
	|
	|-RVA: 0x9AA7B0 Offset: 0x9A8DB0 VA: 0x1809AA7B0
	|-SplinePath<object>..ctor
	|
	|-RVA: 0x9AA730 Offset: 0x9A8D30 VA: 0x1809AA730
	|-SplinePath<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void BuildSplitData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A72A0 Offset: 0x9A58A0 VA: 0x1809A72A0
	|-SplinePath<SplineSlice<object>>.BuildSplitData
	|
	|-RVA: 0x9A7020 Offset: 0x9A5620 VA: 0x1809A7020
	|-SplinePath<object>.BuildSplitData
	|
	|-RVA: 0x9A74A0 Offset: 0x9A5AA0 VA: 0x1809A74A0
	|-SplinePath<__Il2CppFullySharedGenericType>.BuildSplitData
	*/

	[IteratorStateMachine(typeof(SplinePath.<GetEnumerator>d__7<T>))]
	// RVA: -1 Offset: -1 Slot: 12
	public IEnumerator<BezierKnot> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AA290 Offset: 0x9A8890 VA: 0x1809AA290
	|-SplinePath<SplineSlice<object>>.GetEnumerator
	|-SplinePath<object>.GetEnumerator
	|
	|-RVA: 0x9AA200 Offset: 0x9A8800 VA: 0x1809AA200
	|-SplinePath<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AA620 Offset: 0x9A8C20 VA: 0x1809AA620
	|-SplinePath<SplineSlice<object>>.System.Collections.IEnumerable.GetEnumerator
	|-SplinePath<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x877B00 Offset: 0x876100 VA: 0x180877B00
	|-SplinePath<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AAA70 Offset: 0x9A9070 VA: 0x1809AAA70
	|-SplinePath<SplineSlice<object>>.get_Count
	|
	|-RVA: 0x9AABA0 Offset: 0x9A91A0 VA: 0x1809AABA0
	|-SplinePath<object>.get_Count
	|
	|-RVA: 0x9AA820 Offset: 0x9A8E20 VA: 0x1809AA820
	|-SplinePath<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public BezierKnot get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB3D0 Offset: 0x9A99D0 VA: 0x1809AB3D0
	|-SplinePath<SplineSlice<object>>.get_Item
	|
	|-RVA: 0x9AB180 Offset: 0x9A9780 VA: 0x1809AB180
	|-SplinePath<object>.get_Item
	|
	|-RVA: 0x9AB320 Offset: 0x9A9920 VA: 0x1809AB320
	|-SplinePath<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public BezierKnot get_Item(SplineKnotIndex index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB080 Offset: 0x9A9680 VA: 0x1809AB080
	|-SplinePath<SplineSlice<object>>.get_Item
	|
	|-RVA: 0x9AB210 Offset: 0x9A9810 VA: 0x1809AB210
	|-SplinePath<object>.get_Item
	|
	|-RVA: 0x9AAD60 Offset: 0x9A9360 VA: 0x1809AAD60
	|-SplinePath<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal SplineKnotIndex GetBranchKnotIndex(int knot) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A7CE0 Offset: 0x9A62E0 VA: 0x1809A7CE0
	|-SplinePath<SplineSlice<object>>.GetBranchKnotIndex
	|
	|-RVA: 0x9A7710 Offset: 0x9A5D10 VA: 0x1809A7710
	|-SplinePath<object>.GetBranchKnotIndex
	|
	|-RVA: 0x9A78C0 Offset: 0x9A5EC0 VA: 0x1809A78C0
	|-SplinePath<__Il2CppFullySharedGenericType>.GetBranchKnotIndex
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool get_Closed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-SplinePath<SplineSlice<object>>.get_Closed
	|-SplinePath<object>.get_Closed
	|-SplinePath<__Il2CppFullySharedGenericType>.get_Closed
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public float GetLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AA3B0 Offset: 0x9A89B0 VA: 0x1809AA3B0
	|-SplinePath<SplineSlice<object>>.GetLength
	|
	|-RVA: 0x9AA320 Offset: 0x9A8920 VA: 0x1809AA320
	|-SplinePath<object>.GetLength
	|
	|-RVA: 0x9AA440 Offset: 0x9A8A40 VA: 0x1809AA440
	|-SplinePath<__Il2CppFullySharedGenericType>.GetLength
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public IReadOnlyList<int> get_EmptyCurves() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-SplinePath<SplineSlice<object>>.get_EmptyCurves
	|-SplinePath<object>.get_EmptyCurves
	|-SplinePath<__Il2CppFullySharedGenericType>.get_EmptyCurves
	*/

	// RVA: -1 Offset: -1
	private bool IsDegenerate(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AA530 Offset: 0x9A8B30 VA: 0x1809AA530
	|-SplinePath<SplineSlice<object>>.IsDegenerate
	|
	|-RVA: 0x9AA5D0 Offset: 0x9A8BD0 VA: 0x1809AA5D0
	|-SplinePath<object>.IsDegenerate
	|
	|-RVA: 0x9AA580 Offset: 0x9A8B80 VA: 0x1809AA580
	|-SplinePath<__Il2CppFullySharedGenericType>.IsDegenerate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public BezierCurve GetCurve(int knot) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AA000 Offset: 0x9A8600 VA: 0x1809AA000
	|-SplinePath<SplineSlice<object>>.GetCurve
	|
	|-RVA: 0x9A9BA0 Offset: 0x9A81A0 VA: 0x1809A9BA0
	|-SplinePath<object>.GetCurve
	|
	|-RVA: 0x9A9DA0 Offset: 0x9A83A0 VA: 0x1809A9DA0
	|-SplinePath<__Il2CppFullySharedGenericType>.GetCurve
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public float GetCurveLength(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A8640 Offset: 0x9A6C40 VA: 0x1809A8640
	|-SplinePath<SplineSlice<object>>.GetCurveLength
	|
	|-RVA: 0x9A8A10 Offset: 0x9A7010 VA: 0x1809A8A10
	|-SplinePath<object>.GetCurveLength
	|
	|-RVA: 0x9A82A0 Offset: 0x9A68A0 VA: 0x1809A82A0
	|-SplinePath<__Il2CppFullySharedGenericType>.GetCurveLength
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public float3 GetCurveUpVector(int index, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A8E10 Offset: 0x9A7410 VA: 0x1809A8E10
	|-SplinePath<SplineSlice<object>>.GetCurveUpVector
	|
	|-RVA: 0x9A91E0 Offset: 0x9A77E0 VA: 0x1809A91E0
	|-SplinePath<object>.GetCurveUpVector
	|
	|-RVA: 0x9A9600 Offset: 0x9A7C00 VA: 0x1809A9600
	|-SplinePath<__Il2CppFullySharedGenericType>.GetCurveUpVector
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public float GetCurveInterpolation(int curveIndex, float curveDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A7FB0 Offset: 0x9A65B0 VA: 0x1809A7FB0
	|-SplinePath<SplineSlice<object>>.GetCurveInterpolation
	|
	|-RVA: 0x9A7E90 Offset: 0x9A6490 VA: 0x1809A7E90
	|-SplinePath<object>.GetCurveInterpolation
	|
	|-RVA: 0x9A80C0 Offset: 0x9A66C0 VA: 0x1809A80C0
	|-SplinePath<__Il2CppFullySharedGenericType>.GetCurveInterpolation
	*/
}

// Namespace: UnityEngine.Splines
public enum SliceDirection // TypeDefIndex: 12595
{
	// Fields
	public int value__; // 0x0
	public const SliceDirection Forward = 0;
	public const SliceDirection Backward = 1;
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
[Serializable]
public struct SplineRange : IEnumerable<int>, IEnumerable // TypeDefIndex: 12597
{
	// Fields
	[SerializeField]
	private int m_Start; // 0x0
	[SerializeField]
	private int m_Count; // 0x4
	[SerializeField]
	private SliceDirection m_Direction; // 0x8

	// Properties
	public int Start { get; set; }
	public int End { get; }
	public int Count { get; set; }
	public SliceDirection Direction { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_Start() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_Start(int value) { }

	// RVA: 0x2151150 Offset: 0x214F750 VA: 0x182151150
	public int get_End() { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_Count() { }

	// RVA: 0x2151180 Offset: 0x214F780 VA: 0x182151180
	public void set_Count(int value) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public SliceDirection get_Direction() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_Direction(SliceDirection value) { }

	// RVA: 0x2151110 Offset: 0x214F710 VA: 0x182151110
	public void .ctor(int start, int count) { }

	// RVA: 0x2151130 Offset: 0x214F730 VA: 0x182151130
	public void .ctor(int start, int count, SliceDirection direction) { }

	// RVA: 0x2151170 Offset: 0x214F770 VA: 0x182151170
	public int get_Item(int index) { }

	// RVA: 0x2150FB0 Offset: 0x214F5B0 VA: 0x182150FB0 Slot: 4
	public IEnumerator<int> GetEnumerator() { }

	// RVA: 0x2151070 Offset: 0x214F670 VA: 0x182151070 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2151080 Offset: 0x214F680 VA: 0x182151080 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Splines
public struct SplineComputeBufferScope<T> : IDisposable // TypeDefIndex: 12598
{
	// Fields
	private T m_Spline; // 0x0
	private int m_KnotCount; // 0x0
	private ComputeBuffer m_CurveBuffer; // 0x0
	private ComputeBuffer m_LengthBuffer; // 0x0
	private ComputeShader m_Shader; // 0x0
	private string m_Info; // 0x0
	private string m_Curves; // 0x0
	private string m_CurveLengths; // 0x0
	private int m_Kernel; // 0x0

	// Properties
	public Vector4 Info { get; }
	public ComputeBuffer Curves { get; }
	public ComputeBuffer CurveLengths { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T spline) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9974A0 Offset: 0x995AA0 VA: 0x1809974A0
	|-SplineComputeBufferScope<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Bind(ComputeShader shader, int kernel, string info, string curves, string lengths) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x996380 Offset: 0x994980 VA: 0x180996380
	|-SplineComputeBufferScope<__Il2CppFullySharedGenericType>.Bind
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x996980 Offset: 0x994F80 VA: 0x180996980
	|-SplineComputeBufferScope<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Upload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x996A20 Offset: 0x995020 VA: 0x180996A20
	|-SplineComputeBufferScope<__Il2CppFullySharedGenericType>.Upload
	*/

	// RVA: -1 Offset: -1
	public Vector4 get_Info() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x997950 Offset: 0x995F50 VA: 0x180997950
	|-SplineComputeBufferScope<__Il2CppFullySharedGenericType>.get_Info
	*/

	// RVA: -1 Offset: -1
	public ComputeBuffer get_Curves() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x997900 Offset: 0x995F00 VA: 0x180997900
	|-SplineComputeBufferScope<__Il2CppFullySharedGenericType>.get_Curves
	*/

	// RVA: -1 Offset: -1
	public ComputeBuffer get_CurveLengths() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9978B0 Offset: 0x995EB0 VA: 0x1809978B0
	|-SplineComputeBufferScope<__Il2CppFullySharedGenericType>.get_CurveLengths
	*/
}

// Namespace: UnityEngine.Splines
[DefaultMember("Item")]
public struct SplineSlice<T> : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot> // TypeDefIndex: 12600
{
	// Fields
	public T Spline; // 0x0
	public SplineRange Range; // 0x0
	public float4x4 Transform; // 0x0

	// Properties
	public int Count { get; }
	public bool Closed { get; }
	public BezierKnot Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ABE50 Offset: 0x9AA450 VA: 0x1809ABE50
	|-SplineSlice<object>.get_Count
	|
	|-RVA: 0x9ACE00 Offset: 0x9AB400 VA: 0x1809ACE00
	|-SplineSlice<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool get_Closed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-SplineSlice<object>.get_Closed
	|-SplineSlice<__Il2CppFullySharedGenericType>.get_Closed
	*/

	// RVA: -1 Offset: -1
	private static BezierKnot FlipTangents(BezierKnot knot) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB590 Offset: 0x9A9B90 VA: 0x1809AB590
	|-SplineSlice<object>.FlipTangents
	|-SplineSlice<__Il2CppFullySharedGenericType>.FlipTangents
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public BezierKnot get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ABF30 Offset: 0x9AA530 VA: 0x1809ABF30
	|-SplineSlice<object>.get_Item
	|
	|-RVA: 0x9AD2D0 Offset: 0x9AB8D0 VA: 0x1809AD2D0
	|-SplineSlice<__Il2CppFullySharedGenericType>.get_Item
	*/

	[IteratorStateMachine(typeof(SplineSlice.<GetEnumerator>d__10<T>))]
	// RVA: -1 Offset: -1 Slot: 12
	public IEnumerator<BezierKnot> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ABA60 Offset: 0x9AA060 VA: 0x1809ABA60
	|-SplineSlice<object>.GetEnumerator
	|
	|-RVA: 0x9AC740 Offset: 0x9AAD40 VA: 0x1809AC740
	|-SplineSlice<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ABCD0 Offset: 0x9AA2D0 VA: 0x1809ABCD0
	|-SplineSlice<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9AC9B0 Offset: 0x9AAFB0 VA: 0x1809AC9B0
	|-SplineSlice<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T spline, SplineRange range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ABD70 Offset: 0x9AA370 VA: 0x1809ABD70
	|-SplineSlice<object>..ctor
	|
	|-RVA: 0x9ACC00 Offset: 0x9AB200 VA: 0x1809ACC00
	|-SplineSlice<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T spline, SplineRange range, float4x4 transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ABD10 Offset: 0x9AA310 VA: 0x1809ABD10
	|-SplineSlice<object>..ctor
	|
	|-RVA: 0x9ACA20 Offset: 0x9AB020 VA: 0x1809ACA20
	|-SplineSlice<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public float GetLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9ABB40 Offset: 0x9AA140 VA: 0x1809ABB40
	|-SplineSlice<object>.GetLength
	|
	|-RVA: 0x9AC8B0 Offset: 0x9AAEB0 VA: 0x1809AC8B0
	|-SplineSlice<__Il2CppFullySharedGenericType>.GetLength
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public BezierCurve GetCurve(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB900 Offset: 0x9A9F00 VA: 0x1809AB900
	|-SplineSlice<object>.GetCurve
	|
	|-RVA: 0x9AC530 Offset: 0x9AAB30 VA: 0x1809AC530
	|-SplineSlice<__Il2CppFullySharedGenericType>.GetCurve
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public float GetCurveLength(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB710 Offset: 0x9A9D10 VA: 0x1809AB710
	|-SplineSlice<object>.GetCurveLength
	|
	|-RVA: 0x9AC2F0 Offset: 0x9AA8F0 VA: 0x1809AC2F0
	|-SplineSlice<__Il2CppFullySharedGenericType>.GetCurveLength
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public float3 GetCurveUpVector(int index, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB7F0 Offset: 0x9A9DF0 VA: 0x1809AB7F0
	|-SplineSlice<object>.GetCurveUpVector
	|
	|-RVA: 0x9AC400 Offset: 0x9AAA00 VA: 0x1809AC400
	|-SplineSlice<__Il2CppFullySharedGenericType>.GetCurveUpVector
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public float GetCurveInterpolation(int curveIndex, float curveDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AB620 Offset: 0x9A9C20 VA: 0x1809AB620
	|-SplineSlice<object>.GetCurveInterpolation
	|
	|-RVA: 0x9AC1E0 Offset: 0x9AA7E0 VA: 0x1809AC1E0
	|-SplineSlice<__Il2CppFullySharedGenericType>.GetCurveInterpolation
	*/
}

// Namespace: UnityEngine.Splines
[Obsolete("Replaced by GetTangentMode and SetTangentMode.")]
public enum SplineType // TypeDefIndex: 12601
{
	// Fields
	public byte value__; // 0x0
	public const SplineType CatmullRom = 0;
	public const SplineType Bezier = 1;
	public const SplineType Linear = 2;
}

// Namespace: UnityEngine.Splines
[Extension]
internal static class SplineTypeUtility // TypeDefIndex: 12602
{
	// Methods

	[Extension]
	// RVA: 0x2151190 Offset: 0x214F790 VA: 0x182151190
	internal static TangentMode GetTangentMode(SplineType splineType) { }
}

// Namespace: UnityEngine.Splines
[Extension]
public static class SplineUtility // TypeDefIndex: 12604
{
	// Fields
	private const int k_SubdivisionCountMin = 6;
	private const int k_SubdivisionCountMax = 1024;
	public const float DefaultTension = 0.33333334;
	public const float CatmullRomTension = 0.5;
	public const int PickResolutionMin = 2;
	public const int PickResolutionDefault = 4;
	public const int PickResolutionMax = 64;
	public const int DrawResolutionDefault = 10;

	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Evaluate<T>(T spline, float t, out float3 position, out float3 tangent, out float3 upVector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AF800 Offset: 0x7ADE00 VA: 0x1807AF800
	|-SplineUtility.Evaluate<NativeSpline>
	|
	|-RVA: 0x7AFAB0 Offset: 0x7AE0B0 VA: 0x1807AFAB0
	|-SplineUtility.Evaluate<object>
	|
	|-RVA: 0x7AF340 Offset: 0x7AD940 VA: 0x1807AF340
	|-SplineUtility.Evaluate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2151CE0 Offset: 0x21502E0 VA: 0x182151CE0
	public static bool EvaluateNurbs(float t, List<float3> controlPoints, List<double> knotVector, int order, out float3 position) { }

	// RVA: 0x2155E10 Offset: 0x2154410 VA: 0x182155E10
	private static float[] GetNurbsBasisFunctions(int degree, float t, List<double> knotVector, int span) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static float3 EvaluatePosition<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7ADA10 Offset: 0x7AC010 VA: 0x1807ADA10
	|-SplineUtility.EvaluatePosition<NativeSpline>
	|
	|-RVA: 0x7ADBB0 Offset: 0x7AC1B0 VA: 0x1807ADBB0
	|-SplineUtility.EvaluatePosition<object>
	|
	|-RVA: 0x7AD700 Offset: 0x7ABD00 VA: 0x1807AD700
	|-SplineUtility.EvaluatePosition<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float3 EvaluateTangent<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AE060 Offset: 0x7AC660 VA: 0x1807AE060
	|-SplineUtility.EvaluateTangent<NativeSpline>
	|
	|-RVA: 0x7AE200 Offset: 0x7AC800 VA: 0x1807AE200
	|-SplineUtility.EvaluateTangent<object>
	|
	|-RVA: 0x7ADD50 Offset: 0x7AC350 VA: 0x1807ADD50
	|-SplineUtility.EvaluateTangent<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float3 EvaluateUpVector<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AE680 Offset: 0x7ACC80 VA: 0x1807AE680
	|-SplineUtility.EvaluateUpVector<NativeSpline>
	|
	|-RVA: 0x7AE7A0 Offset: 0x7ACDA0 VA: 0x1807AE7A0
	|-SplineUtility.EvaluateUpVector<object>
	|
	|-RVA: 0x7AE3A0 Offset: 0x7AC9A0 VA: 0x1807AE3A0
	|-SplineUtility.EvaluateUpVector<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float3 CalculateUpVector<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A9DA0 Offset: 0x7A83A0 VA: 0x1807A9DA0
	|-SplineUtility.CalculateUpVector<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static float3 CalculateUpVector<T>(T spline, int curveIndex, float curveT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AAC30 Offset: 0x7A9230 VA: 0x1807AAC30
	|-SplineUtility.CalculateUpVector<SplineSlice<object>>
	|
	|-RVA: 0x7AA780 Offset: 0x7A8D80 VA: 0x1807AA780
	|-SplineUtility.CalculateUpVector<NativeSpline>
	|
	|-RVA: 0x7AA070 Offset: 0x7A8670 VA: 0x1807AA070
	|-SplineUtility.CalculateUpVector<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void EvaluateUpVectorsForCurve<T>(T spline, int curveIndex, Vector3[] upVectors) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AEF30 Offset: 0x7AD530 VA: 0x1807AEF30
	|-SplineUtility.EvaluateUpVectorsForCurve<object>
	|
	|-RVA: 0x7AE8B0 Offset: 0x7ACEB0 VA: 0x1807AE8B0
	|-SplineUtility.EvaluateUpVectorsForCurve<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float3 EvaluateAcceleration<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7ACAE0 Offset: 0x7AB0E0 VA: 0x1807ACAE0
	|-SplineUtility.EvaluateAcceleration<NativeSpline>
	|
	|-RVA: 0x7ACC90 Offset: 0x7AB290 VA: 0x1807ACC90
	|-SplineUtility.EvaluateAcceleration<object>
	|
	|-RVA: 0x7AC7C0 Offset: 0x7AADC0 VA: 0x1807AC7C0
	|-SplineUtility.EvaluateAcceleration<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float EvaluateCurvature<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AD420 Offset: 0x7ABA20 VA: 0x1807AD420
	|-SplineUtility.EvaluateCurvature<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float3 EvaluateCurvatureCenter<T>(T spline, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7ACE40 Offset: 0x7AB440 VA: 0x1807ACE40
	|-SplineUtility.EvaluateCurvatureCenter<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int SplineToCurveT<T>(T spline, float splineT, out float curveT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B6B20 Offset: 0x7B5120 VA: 0x1807B6B20
	|-SplineUtility.SplineToCurveT<NativeSpline>
	|
	|-RVA: 0x7B6E60 Offset: 0x7B5460 VA: 0x1807B6E60
	|-SplineUtility.SplineToCurveT<object>
	|
	|-RVA: 0x7B6A20 Offset: 0x7B5020 VA: 0x1807B6A20
	|-SplineUtility.SplineToCurveT<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	private static int SplineToCurveT<T>(T spline, float splineT, out float curveT, bool useLUT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B6CE0 Offset: 0x7B52E0 VA: 0x1807B6CE0
	|-SplineUtility.SplineToCurveT<NativeSpline>
	|
	|-RVA: 0x7B6ED0 Offset: 0x7B54D0 VA: 0x1807B6ED0
	|-SplineUtility.SplineToCurveT<object>
	|
	|-RVA: 0x7B6530 Offset: 0x7B4B30 VA: 0x1807B6530
	|-SplineUtility.SplineToCurveT<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float CurveToSplineT<T>(T spline, float curve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AC560 Offset: 0x7AAB60 VA: 0x1807AC560
	|-SplineUtility.CurveToSplineT<object>
	|
	|-RVA: 0x7ABFA0 Offset: 0x7AA5A0 VA: 0x1807ABFA0
	|-SplineUtility.CurveToSplineT<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float CalculateLength<T>(T spline, float4x4 transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A9CD0 Offset: 0x7A82D0 VA: 0x1807A9CD0
	|-SplineUtility.CalculateLength<object>
	|
	|-RVA: 0x7A9B60 Offset: 0x7A8160 VA: 0x1807A9B60
	|-SplineUtility.CalculateLength<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int GetCurveCount<T>(T spline) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B1230 Offset: 0x7AF830 VA: 0x1807B1230
	|-SplineUtility.GetCurveCount<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Bounds GetBounds<T>(T spline) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B10E0 Offset: 0x7AF6E0 VA: 0x1807B10E0
	|-SplineUtility.GetBounds<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Bounds GetBounds<T>(T spline, float4x4 transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AFD40 Offset: 0x7AE340 VA: 0x1807AFD40
	|-SplineUtility.GetBounds<__Il2CppFullySharedGenericType>
	*/

	[Obsolete("Use GetSubdivisionCount instead.", False)]
	// RVA: 0x2156080 Offset: 0x2154680 VA: 0x182156080
	public static int GetSegmentCount(float length, int resolution) { }

	// RVA: 0x2156080 Offset: 0x2154680 VA: 0x182156080
	public static int GetSubdivisionCount(float length, int resolution) { }

	// RVA: -1 Offset: -1
	private static SplineUtility.Segment GetNearestPoint<T>(T spline, float3 ro, float3 rd, SplineUtility.Segment range, out float distance, out float3 nearest, out float time, int segments) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B1E00 Offset: 0x7B0400 VA: 0x1807B1E00
	|-SplineUtility.GetNearestPoint<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static SplineUtility.Segment GetNearestPoint<T>(T spline, float3 point, SplineUtility.Segment range, out float distance, out float3 nearest, out float time, int segments) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B1700 Offset: 0x7AFD00 VA: 0x1807B1700
	|-SplineUtility.GetNearestPoint<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static float GetNearestPoint<T>(T spline, Ray ray, out float3 nearest, out float t, int resolution = 4, int iterations = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B13B0 Offset: 0x7AF9B0 VA: 0x1807B13B0
	|-SplineUtility.GetNearestPoint<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static float GetNearestPoint<T>(T spline, float3 point, out float3 nearest, out float t, int resolution = 4, int iterations = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B1B30 Offset: 0x7B0130 VA: 0x1807B1B30
	|-SplineUtility.GetNearestPoint<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float3 GetPointAtLinearDistance<T>(T spline, float fromT, float relativeDistance, out float resultPointT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B2D90 Offset: 0x7B1390 VA: 0x1807B2D90
	|-SplineUtility.GetPointAtLinearDistance<NativeSpline>
	|
	|-RVA: 0x7B27D0 Offset: 0x7B0DD0 VA: 0x1807B27D0
	|-SplineUtility.GetPointAtLinearDistance<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float ConvertIndexUnit<T>(T spline, float t, PathIndexUnit targetPathUnit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AB340 Offset: 0x7A9940 VA: 0x1807AB340
	|-SplineUtility.ConvertIndexUnit<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float ConvertIndexUnit<T>(T spline, float value, PathIndexUnit fromPathUnit, PathIndexUnit targetPathUnit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AB500 Offset: 0x7A9B00 VA: 0x1807AB500
	|-SplineUtility.ConvertIndexUnit<object>
	|
	|-RVA: 0x7AB080 Offset: 0x7A9680 VA: 0x1807AB080
	|-SplineUtility.ConvertIndexUnit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static float ConvertNormalizedIndexUnit<T>(T spline, float t, PathIndexUnit targetPathUnit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AB8D0 Offset: 0x7A9ED0 VA: 0x1807AB8D0
	|-SplineUtility.ConvertNormalizedIndexUnit<object>
	|
	|-RVA: 0x7AB6E0 Offset: 0x7A9CE0 VA: 0x1807AB6E0
	|-SplineUtility.ConvertNormalizedIndexUnit<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2158A80 Offset: 0x2157080 VA: 0x182158A80
	private static float WrapInterpolation(float t, bool closed) { }

	// RVA: -1 Offset: -1
	public static float GetNormalizedInterpolation<T>(T spline, float t, PathIndexUnit originalPathUnit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B25C0 Offset: 0x7B0BC0 VA: 0x1807B25C0
	|-SplineUtility.GetNormalizedInterpolation<object>
	|
	|-RVA: 0x7B2220 Offset: 0x7B0820 VA: 0x1807B2220
	|-SplineUtility.GetNormalizedInterpolation<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int PreviousIndex<T>(T spline, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B4940 Offset: 0x7B2F40 VA: 0x1807B4940
	|-SplineUtility.PreviousIndex<object>
	|
	|-RVA: 0x7B47B0 Offset: 0x7B2DB0 VA: 0x1807B47B0
	|-SplineUtility.PreviousIndex<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int NextIndex<T>(T spline, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B4460 Offset: 0x7B2A60 VA: 0x1807B4460
	|-SplineUtility.NextIndex<SplineSlice<object>>
	|
	|-RVA: 0x7B4370 Offset: 0x7B2970 VA: 0x1807B4370
	|-SplineUtility.NextIndex<NativeSpline>
	|
	|-RVA: 0x7B43D0 Offset: 0x7B29D0 VA: 0x1807B43D0
	|-SplineUtility.NextIndex<object>
	|
	|-RVA: 0x7B41E0 Offset: 0x7B27E0 VA: 0x1807B41E0
	|-SplineUtility.NextIndex<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static BezierKnot Previous<T>(T spline, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B49D0 Offset: 0x7B2FD0 VA: 0x1807B49D0
	|-SplineUtility.Previous<object>
	|
	|-RVA: 0x7B44E0 Offset: 0x7B2AE0 VA: 0x1807B44E0
	|-SplineUtility.Previous<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static BezierKnot Next<T>(T spline, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B46B0 Offset: 0x7B2CB0 VA: 0x1807B46B0
	|-SplineUtility.Next<object>
	|
	|-RVA: 0x7B44E0 Offset: 0x7B2AE0 VA: 0x1807B44E0
	|-SplineUtility.Next<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2156EB0 Offset: 0x21554B0 VA: 0x182156EB0
	internal static int PreviousIndex(int index, int count, bool wrap) { }

	// RVA: 0x2156E90 Offset: 0x2155490 VA: 0x182156E90
	internal static int NextIndex(int index, int count, bool wrap) { }

	// RVA: 0x21555B0 Offset: 0x2153BB0 VA: 0x1821555B0
	internal static float3 GetExplicitLinearTangent(float3 point, float3 to) { }

	// RVA: 0x21553C0 Offset: 0x21539C0 VA: 0x1821553C0
	internal static float3 GetExplicitLinearTangent(BezierKnot from, BezierKnot to) { }

	// RVA: 0x2155270 Offset: 0x2153870 VA: 0x182155270
	public static float3 GetCatmullRomTangent(float3 previous, float3 next) { }

	// RVA: 0x2154E60 Offset: 0x2153460 VA: 0x182154E60
	public static float3 GetAutoSmoothTangent(float3 previous, float3 next, float tension = 0.33333334) { }

	// RVA: 0x2154FA0 Offset: 0x21535A0 VA: 0x182154FA0
	public static float3 GetAutoSmoothTangent(float3 previous, float3 current, float3 next, float tension = 0.33333334) { }

	// RVA: 0x21560F0 Offset: 0x21546F0 VA: 0x1821560F0
	private static float3 GetUniformAutoSmoothTangent(float3 previous, float3 next, float tension) { }

	// RVA: 0x2154DA0 Offset: 0x21533A0 VA: 0x182154DA0
	public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next) { }

	// RVA: 0x2154CE0 Offset: 0x21532E0 VA: 0x182154CE0
	public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal) { }

	// RVA: 0x2154A30 Offset: 0x2153030 VA: 0x182154A30
	public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal, float tension = 0.33333334) { }

	// RVA: 0x2155610 Offset: 0x2153C10 VA: 0x182155610
	internal static quaternion GetKnotRotation(float3 tangent, float3 normal) { }

	// RVA: 0x21583E0 Offset: 0x21569E0 VA: 0x1821583E0
	public static void SetPivot(SplineContainer container, Vector3 position) { }

	// RVA: 0x2152020 Offset: 0x2150620 VA: 0x182152020
	public static bool FitSplineToPoints(List<float3> points, float errorThreshold, bool closed, out Spline spline) { }

	// RVA: 0x21513C0 Offset: 0x214F9C0 VA: 0x1821513C0
	private static float3 Bernstein(float t, float3[] bezier, int degree) { }

	// RVA: 0x2153C80 Offset: 0x2152280 VA: 0x182153C80
	private static Spline GenerateSplineFromTValues(List<float3> points, bool closed, float[] tValues) { }

	// RVA: 0x2151580 Offset: 0x214FB80 VA: 0x182151580
	private static ValueTuple<float, int> ComputeMaxError(List<float3> points, float3[] positions) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Spline AddSpline<T>(T container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A98E0 Offset: 0x7A7EE0 VA: 0x1807A98E0
	|-SplineUtility.AddSpline<object>
	|
	|-RVA: 0x7A9580 Offset: 0x7A7B80 VA: 0x1807A9580
	|-SplineUtility.AddSpline<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddSpline<T>(T container, Spline spline) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7A9960 Offset: 0x7A7F60 VA: 0x1807A9960
	|-SplineUtility.AddSpline<object>
	|
	|-RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690
	|-SplineUtility.AddSpline<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool RemoveSplineAt<T>(T container, int splineIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B50F0 Offset: 0x7B36F0 VA: 0x1807B50F0
	|-SplineUtility.RemoveSplineAt<object>
	|
	|-RVA: 0x7B4D70 Offset: 0x7B3370 VA: 0x1807B4D70
	|-SplineUtility.RemoveSplineAt<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool RemoveSpline<T>(T container, Spline spline) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B52C0 Offset: 0x7B38C0 VA: 0x1807B52C0
	|-SplineUtility.RemoveSpline<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ReorderSpline<T>(T container, int previousSplineIndex, int newSplineIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B5590 Offset: 0x7B3B90 VA: 0x1807B5590
	|-SplineUtility.ReorderSpline<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static bool IsIndexValid<T>(T container, SplineKnotIndex index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B34A0 Offset: 0x7B1AA0 VA: 0x1807B34A0
	|-SplineUtility.IsIndexValid<object>
	|
	|-RVA: 0x7B31C0 Offset: 0x7B17C0 VA: 0x1807B31C0
	|-SplineUtility.IsIndexValid<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void SetLinkedKnotPosition<T>(T container, SplineKnotIndex index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B6000 Offset: 0x7B4600 VA: 0x1807B6000
	|-SplineUtility.SetLinkedKnotPosition<object>
	|
	|-RVA: 0x7B5A20 Offset: 0x7B4020 VA: 0x1807B5A20
	|-SplineUtility.SetLinkedKnotPosition<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LinkKnots<T>(T container, SplineKnotIndex knotA, SplineKnotIndex knotB) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B3D10 Offset: 0x7B2310 VA: 0x1807B3D10
	|-SplineUtility.LinkKnots<object>
	|
	|-RVA: 0x7B35D0 Offset: 0x7B1BD0 VA: 0x1807B35D0
	|-SplineUtility.LinkKnots<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void UnlinkKnots<T>(T container, IReadOnlyList<SplineKnotIndex> knots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B73D0 Offset: 0x7B59D0 VA: 0x1807B73D0
	|-SplineUtility.UnlinkKnots<object>
	|
	|-RVA: 0x7B7150 Offset: 0x7B5750 VA: 0x1807B7150
	|-SplineUtility.UnlinkKnots<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x21511B0 Offset: 0x214F7B0 VA: 0x1821511B0
	public static bool AreKnotLinked(ISplineContainer container, SplineKnotIndex knotA, SplineKnotIndex knotB) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyKnotLinks<T>(T container, int srcSplineIndex, int destSplineIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7AB990 Offset: 0x7A9F90 VA: 0x1807AB990
	|-SplineUtility.CopyKnotLinks<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<float3> ReducePoints<T>(T line, float epsilon = 0.15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B4C00 Offset: 0x7B3200 VA: 0x1807B4C00
	|-SplineUtility.ReducePoints<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ReducePoints<T>(T line, List<float3> results, float epsilon = 0.15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B4AD0 Offset: 0x7B30D0 VA: 0x1807B4AD0
	|-SplineUtility.ReducePoints<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21513A0 Offset: 0x214F9A0 VA: 0x1821513A0
	internal static bool AreTangentsModifiable(TangentMode mode) { }

	[Extension]
	// RVA: 0x2156ED0 Offset: 0x21554D0 VA: 0x182156ED0
	public static void ReverseFlow(ISplineContainer container, int splineIndex) { }

	// RVA: 0x2157650 Offset: 0x2155C50 VA: 0x182157650
	public static void ReverseFlow(SplineInfo splineInfo) { }

	// RVA: 0x2156F20 Offset: 0x2155520 VA: 0x182156F20
	public static void ReverseFlow(Spline spline) { }

	[Extension]
	// RVA: 0x2156140 Offset: 0x2154740 VA: 0x182156140
	public static SplineKnotIndex JoinSplinesOnKnots(ISplineContainer container, SplineKnotIndex mainKnot, SplineKnotIndex otherKnot) { }

	[Extension]
	// RVA: 0x2151760 Offset: 0x214FD60 VA: 0x182151760
	internal static SplineKnotIndex DuplicateKnot(ISplineContainer container, SplineKnotIndex originalKnot, int targetIndex) { }

	[Extension]
	// RVA: 0x21518A0 Offset: 0x214FEA0 VA: 0x1821518A0
	public static void DuplicateSpline(ISplineContainer container, SplineKnotIndex fromKnot, SplineKnotIndex toKnot, out int newSplineIndex) { }

	[Extension]
	// RVA: 0x2158600 Offset: 0x2156C00 VA: 0x182158600
	public static SplineKnotIndex SplitSplineOnKnot(ISplineContainer container, SplineKnotIndex knotInfo) { }
}

