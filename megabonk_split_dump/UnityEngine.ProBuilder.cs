// Namespace: UnityEngine.ProBuilder
public sealed class ActionResult // TypeDefIndex: 11550
{
	// Fields
	[CompilerGenerated]
	private ActionResult.Status <status>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <notification>k__BackingField; // 0x18

	// Properties
	public ActionResult.Status status { get; set; }
	public string notification { get; set; }
	public static ActionResult Success { get; }
	public static ActionResult NoSelection { get; }
	public static ActionResult UserCanceled { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ActionResult.Status get_status() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	private void set_status(ActionResult.Status value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_notification() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_notification(string value) { }

	// RVA: 0x3E8780 Offset: 0x3E6D80 VA: 0x1803E8780
	public void .ctor(ActionResult.Status status, string notification) { }

	// RVA: 0x207E7E0 Offset: 0x207CDE0 VA: 0x18207E7E0
	public static bool op_Implicit(ActionResult res) { }

	// RVA: 0x207E650 Offset: 0x207CC50 VA: 0x18207E650
	public bool ToBool() { }

	// RVA: 0x207E560 Offset: 0x207CB60 VA: 0x18207E560
	public static bool FromBool(bool success) { }

	// RVA: 0x207E6E0 Offset: 0x207CCE0 VA: 0x18207E6E0
	public static ActionResult get_Success() { }

	// RVA: 0x207E660 Offset: 0x207CC60 VA: 0x18207E660
	public static ActionResult get_NoSelection() { }

	// RVA: 0x207E760 Offset: 0x207CD60 VA: 0x18207E760
	public static ActionResult get_UserCanceled() { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
internal static class ArrayUtility // TypeDefIndex: 11554
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] ValuesWithIndexes<T>(T[] arr, int[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65CF60 Offset: 0x65B560 VA: 0x18065CF60
	|-ArrayUtility.ValuesWithIndexes<Vector2>
	|
	|-RVA: 0x65C820 Offset: 0x65AE20 VA: 0x18065C820
	|-ArrayUtility.ValuesWithIndexes<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static List<T> ValuesWithIndexes<T>(List<T> arr, IList<int> indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65CCA0 Offset: 0x65B2A0 VA: 0x18065CCA0
	|-ArrayUtility.ValuesWithIndexes<object>
	|
	|-RVA: 0x65C9C0 Offset: 0x65AFC0 VA: 0x18065C9C0
	|-ArrayUtility.ValuesWithIndexes<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<int> AllIndexesOf<T>(IList<T> list, Func<T, bool> lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63DDA0 Offset: 0x63C3A0 VA: 0x18063DDA0
	|-ArrayUtility.AllIndexesOf<bool>
	|
	|-RVA: 0x63DF60 Offset: 0x63C560 VA: 0x18063DF60
	|-ArrayUtility.AllIndexesOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] Add<T>(T[] arr, T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63DC20 Offset: 0x63C220 VA: 0x18063DC20
	|-ArrayUtility.Add<int>
	|
	|-RVA: 0x63DCD0 Offset: 0x63C2D0 VA: 0x18063DCD0
	|-ArrayUtility.Add<object>
	|
	|-RVA: 0x63DAA0 Offset: 0x63C0A0 VA: 0x18063DAA0
	|-ArrayUtility.Add<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] AddRange<T>(T[] arr, T[] val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63D9D0 Offset: 0x63BFD0 VA: 0x18063D9D0
	|-ArrayUtility.AddRange<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] Remove<T>(T[] arr, T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65B2A0 Offset: 0x6598A0 VA: 0x18065B2A0
	|-ArrayUtility.Remove<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] Remove<T>(T[] arr, IEnumerable<T> val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65B4E0 Offset: 0x659AE0 VA: 0x18065B4E0
	|-ArrayUtility.Remove<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveAt<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65B060 Offset: 0x659660 VA: 0x18065B060
	|-ArrayUtility.RemoveAt<int>
	|
	|-RVA: 0x65AC90 Offset: 0x659290 VA: 0x18065AC90
	|-ArrayUtility.RemoveAt<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveAt<T>(IList<T> list, IEnumerable<int> indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65B120 Offset: 0x659720 VA: 0x18065B120
	|-ArrayUtility.RemoveAt<object>
	|
	|-RVA: 0x65AEE0 Offset: 0x6594E0 VA: 0x18065AEE0
	|-ArrayUtility.RemoveAt<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] SortedRemoveAt<T>(IList<T> list, IList<int> sorted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65BBB0 Offset: 0x65A1B0 VA: 0x18065BBB0
	|-ArrayUtility.SortedRemoveAt<object>
	|
	|-RVA: 0x65B970 Offset: 0x659F70 VA: 0x18065B970
	|-ArrayUtility.SortedRemoveAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65AA50 Offset: 0x659050 VA: 0x18065AA50
	|-ArrayUtility.NearestIndexPriorToValue<int>
	|
	|-RVA: 0x65A480 Offset: 0x658A80 VA: 0x18065A480
	|-ArrayUtility.NearestIndexPriorToValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<T> Fill<T>(Func<int, T> ctor, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x659FC0 Offset: 0x6585C0 VA: 0x180659FC0
	|-ArrayUtility.Fill<object>
	|
	|-RVA: 0x659DD0 Offset: 0x6583D0 VA: 0x180659DD0
	|-ArrayUtility.Fill<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] Fill<T>(T val, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x659A40 Offset: 0x658040 VA: 0x180659A40
	|-ArrayUtility.Fill<Color>
	|
	|-RVA: 0x659F30 Offset: 0x658530 VA: 0x180659F30
	|-ArrayUtility.Fill<int>
	|
	|-RVA: 0x65A0F0 Offset: 0x6586F0 VA: 0x18065A0F0
	|-ArrayUtility.Fill<Vector2>
	|
	|-RVA: 0x659C60 Offset: 0x658260 VA: 0x180659C60
	|-ArrayUtility.Fill<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsMatch<T>(T[] a, T[] b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6596A0 Offset: 0x657CA0 VA: 0x1806596A0
	|-ArrayUtility.ContainsMatch<int>
	|
	|-RVA: 0x659420 Offset: 0x657A20 VA: 0x180659420
	|-ArrayUtility.ContainsMatch<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsMatch<T>(T[] a, T[] b, out int index_a, out int index_b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x659730 Offset: 0x657D30 VA: 0x180659730
	|-ArrayUtility.ContainsMatch<int>
	|
	|-RVA: 0x659550 Offset: 0x657B50 VA: 0x180659550
	|-ArrayUtility.ContainsMatch<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] Concat<T>(T[] x, T[] y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63E2A0 Offset: 0x63C8A0 VA: 0x18063E2A0
	|-ArrayUtility.Concat<object>
	|-ArrayUtility.Concat<Vector3>
	|
	|-RVA: 0x63E190 Offset: 0x63C790 VA: 0x18063E190
	|-ArrayUtility.Concat<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(List<List<T>> InList, T InValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65A190 Offset: 0x658790 VA: 0x18065A190
	|-ArrayUtility.IndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] Fill<T>(int count, Func<int, T> ctor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x659AE0 Offset: 0x6580E0 VA: 0x180659AE0
	|-ArrayUtility.Fill<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddOrAppend<T, K>(Dictionary<T, List<K>> dictionary, T key, K value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63D4B0 Offset: 0x63BAB0 VA: 0x18063D4B0
	|-ArrayUtility.AddOrAppend<int, SimpleTuple<object, object>>
	|
	|-RVA: 0x63D330 Offset: 0x63B930 VA: 0x18063D330
	|-ArrayUtility.AddOrAppend<int, int>
	|
	|-RVA: 0x63D800 Offset: 0x63BE00 VA: 0x18063D800
	|-ArrayUtility.AddOrAppend<object, SimpleTuple<object, int>>
	|
	|-RVA: 0x63D680 Offset: 0x63BC80 VA: 0x18063D680
	|-ArrayUtility.AddOrAppend<object, int>
	|
	|-RVA: 0x63D080 Offset: 0x63B680 VA: 0x18063D080
	|-ArrayUtility.AddOrAppend<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddOrAppendRange<T, K>(Dictionary<T, List<K>> dictionary, T key, List<K> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63CEF0 Offset: 0x63B4F0 VA: 0x18063CEF0
	|-ArrayUtility.AddOrAppendRange<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> DistinctBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x659910 Offset: 0x657F10 VA: 0x180659910
	|-ArrayUtility.DistinctBy<object, Edge>
	|
	|-RVA: 0x6597E0 Offset: 0x657DE0 VA: 0x1806597E0
	|-ArrayUtility.DistinctBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static string ToString<TKey, TValue>(Dictionary<TKey, TValue> dict) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65BEC0 Offset: 0x65A4C0 VA: 0x18065BEC0
	|-ArrayUtility.ToString<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static string ToString<T>(IEnumerable<T> arr, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65C4A0 Offset: 0x65AAA0 VA: 0x18065C4A0
	|-ArrayUtility.ToString<int>
	|
	|-RVA: 0x65C660 Offset: 0x65AC60 VA: 0x18065C660
	|-ArrayUtility.ToString<object>
	|
	|-RVA: 0x65C2D0 Offset: 0x65A8D0 VA: 0x18065C2D0
	|-ArrayUtility.ToString<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public struct AutoUnwrapSettings // TypeDefIndex: 11557
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("useWorldSpace")]
	private bool m_UseWorldSpace; // 0x0
	[SerializeField]
	[FormerlySerializedAs("flipU")]
	private bool m_FlipU; // 0x1
	[SerializeField]
	[FormerlySerializedAs("flipV")]
	private bool m_FlipV; // 0x2
	[SerializeField]
	[FormerlySerializedAs("swapUV")]
	private bool m_SwapUV; // 0x3
	[SerializeField]
	[FormerlySerializedAs("fill")]
	private AutoUnwrapSettings.Fill m_Fill; // 0x4
	[SerializeField]
	[FormerlySerializedAs("scale")]
	private Vector2 m_Scale; // 0x8
	[SerializeField]
	[FormerlySerializedAs("offset")]
	private Vector2 m_Offset; // 0x10
	[SerializeField]
	[FormerlySerializedAs("rotation")]
	private float m_Rotation; // 0x18
	[SerializeField]
	[FormerlySerializedAs("anchor")]
	private AutoUnwrapSettings.Anchor m_Anchor; // 0x1C

	// Properties
	public static AutoUnwrapSettings defaultAutoUnwrapSettings { get; }
	public bool useWorldSpace { get; set; }
	public bool flipU { get; set; }
	public bool flipV { get; set; }
	public bool swapUV { get; set; }
	public AutoUnwrapSettings.Fill fill { get; set; }
	public Vector2 scale { get; set; }
	public Vector2 offset { get; set; }
	public float rotation { get; set; }
	public AutoUnwrapSettings.Anchor anchor { get; set; }
	public static AutoUnwrapSettings tile { get; }
	public static AutoUnwrapSettings fit { get; }
	public static AutoUnwrapSettings stretch { get; }

	// Methods

	// RVA: 0x207EC90 Offset: 0x207D290 VA: 0x18207EC90
	public static AutoUnwrapSettings get_defaultAutoUnwrapSettings() { }

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_useWorldSpace() { }

	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x12B1970 Offset: 0x12AFF70 VA: 0x1812B1970
	public bool get_flipU() { }

	// RVA: 0x16A56B0 Offset: 0x16A3CB0 VA: 0x1816A56B0
	public void set_flipU(bool value) { }

	// RVA: 0x157D110 Offset: 0x157B710 VA: 0x18157D110
	public bool get_flipV() { }

	// RVA: 0x207ED20 Offset: 0x207D320 VA: 0x18207ED20
	public void set_flipV(bool value) { }

	// RVA: 0x58E950 Offset: 0x58CF50 VA: 0x18058E950
	public bool get_swapUV() { }

	// RVA: 0x207ED30 Offset: 0x207D330 VA: 0x18207ED30
	public void set_swapUV(bool value) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public AutoUnwrapSettings.Fill get_fill() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_fill(AutoUnwrapSettings.Fill value) { }

	// RVA: 0x16ADB70 Offset: 0x16AC170 VA: 0x1816ADB70
	public Vector2 get_scale() { }

	// RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	public void set_scale(Vector2 value) { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	public Vector2 get_offset() { }

	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_offset(Vector2 value) { }

	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70
	public float get_rotation() { }

	// RVA: 0x3A4C30 Offset: 0x3A3230 VA: 0x1803A4C30
	public void set_rotation(float value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public AutoUnwrapSettings.Anchor get_anchor() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_anchor(AutoUnwrapSettings.Anchor value) { }

	// RVA: 0x207EC50 Offset: 0x207D250 VA: 0x18207EC50
	public void .ctor(AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x207EC90 Offset: 0x207D290 VA: 0x18207EC90
	public static AutoUnwrapSettings get_tile() { }

	// RVA: 0x207ECC0 Offset: 0x207D2C0 VA: 0x18207ECC0
	public static AutoUnwrapSettings get_fit() { }

	// RVA: 0x207ECF0 Offset: 0x207D2F0 VA: 0x18207ECF0
	public static AutoUnwrapSettings get_stretch() { }

	// RVA: 0x207E7F0 Offset: 0x207CDF0 VA: 0x18207E7F0
	public void Reset() { }

	// RVA: 0x207E820 Offset: 0x207CE20 VA: 0x18207E820 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
internal enum BezierTangentMode // TypeDefIndex: 11558
{
	// Fields
	public int value__; // 0x0
	public const BezierTangentMode Free = 0;
	public const BezierTangentMode Aligned = 1;
	public const BezierTangentMode Mirrored = 2;
}

// Namespace: UnityEngine.ProBuilder
internal enum BezierTangentDirection // TypeDefIndex: 11559
{
	// Fields
	public int value__; // 0x0
	public const BezierTangentDirection In = 0;
	public const BezierTangentDirection Out = 1;
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal struct BezierPoint // TypeDefIndex: 11560
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 tangentIn; // 0xC
	public Vector3 tangentOut; // 0x18
	public Quaternion rotation; // 0x24

	// Methods

	// RVA: 0x207F9D0 Offset: 0x207DFD0 VA: 0x18207F9D0
	public void .ctor(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) { }

	// RVA: 0x207EEC0 Offset: 0x207D4C0 VA: 0x18207EEC0
	public void EnforceTangentMode(BezierTangentDirection master, BezierTangentMode mode) { }

	// RVA: 0x207F8F0 Offset: 0x207DEF0 VA: 0x18207F8F0
	public void SetPosition(Vector3 position) { }

	// RVA: 0x207F990 Offset: 0x207DF90 VA: 0x18207F990
	public void SetTangentIn(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x207F9B0 Offset: 0x207DFB0 VA: 0x18207F9B0
	public void SetTangentOut(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x207F7B0 Offset: 0x207DDB0 VA: 0x18207F7B0
	public static Vector3 QuadraticPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x207ED40 Offset: 0x207D340 VA: 0x18207ED40
	public static Vector3 CubicPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x207F1A0 Offset: 0x207D7A0 VA: 0x18207F1A0
	public static Vector3 GetLookDirection(IList<BezierPoint> points, int index, int previous, int next) { }
}

// Namespace: UnityEngine.ProBuilder
[AddComponentMenu("")]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[RequireComponent(typeof(ProBuilderMesh))]
internal sealed class BezierShape : MonoBehaviour // TypeDefIndex: 11561
{
	// Fields
	public List<BezierPoint> points; // 0x20
	public bool closeLoop; // 0x28
	public float radius; // 0x2C
	public int rows; // 0x30
	public int columns; // 0x34
	public bool smooth; // 0x38
	[SerializeField]
	private bool m_IsEditing; // 0x39
	private ProBuilderMesh m_Mesh; // 0x40

	// Properties
	public bool isEditing { get; set; }
	public ProBuilderMesh mesh { get; set; }

	// Methods

	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	public bool get_isEditing() { }

	// RVA: 0xADB1E0 Offset: 0xAD97E0 VA: 0x180ADB1E0
	public void set_isEditing(bool value) { }

	// RVA: 0x207FE60 Offset: 0x207E460 VA: 0x18207FE60
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x207FA10 Offset: 0x207E010 VA: 0x18207FA10
	public void Init() { }

	// RVA: 0x207FCF0 Offset: 0x207E2F0 VA: 0x18207FCF0
	public void Refresh() { }

	// RVA: 0x207FDD0 Offset: 0x207E3D0 VA: 0x18207FDD0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class Bounds2D // TypeDefIndex: 11562
{
	// Fields
	public Vector2 center; // 0x10
	[SerializeField]
	private Vector2 m_Size; // 0x18
	[SerializeField]
	private Vector2 m_Extents; // 0x20

	// Properties
	public Vector2 size { get; set; }
	public Vector2 extents { get; }
	public Vector2[] corners { get; }

	// Methods

	// RVA: 0x10C9BB0 Offset: 0x10C81B0 VA: 0x1810C9BB0
	public Vector2 get_size() { }

	// RVA: 0x2082450 Offset: 0x2080A50 VA: 0x182082450
	public void set_size(Vector2 value) { }

	// RVA: 0x16ADB50 Offset: 0x16AC150 VA: 0x1816ADB50
	public Vector2 get_extents() { }

	// RVA: 0x2082360 Offset: 0x2080960 VA: 0x182082360
	public Vector2[] get_corners() { }

	// RVA: 0x2081BC0 Offset: 0x20801C0 VA: 0x182081BC0
	public void .ctor() { }

	// RVA: 0x2081AA0 Offset: 0x20800A0 VA: 0x182081AA0
	public void .ctor(Vector2 center, Vector2 size) { }

	// RVA: 0x2082270 Offset: 0x2080870 VA: 0x182082270
	public void .ctor(IList<Vector2> points) { }

	// RVA: 0x2081E80 Offset: 0x2080480 VA: 0x182081E80
	public void .ctor(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x2081F80 Offset: 0x2080580 VA: 0x182081F80
	internal void .ctor(Vector3[] points, Edge[] edges) { }

	// RVA: 0x2081C90 Offset: 0x2080290 VA: 0x182081C90
	public void .ctor(Vector2[] points, int length) { }

	// RVA: 0x20809A0 Offset: 0x207EFA0 VA: 0x1820809A0
	public bool ContainsPoint(Vector2 point) { }

	// RVA: 0x2080A00 Offset: 0x207F000 VA: 0x182080A00
	public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x2080D30 Offset: 0x207F330 VA: 0x182080D30
	public bool Intersects(Bounds2D bounds) { }

	// RVA: 0x2080DA0 Offset: 0x207F3A0 VA: 0x182080DA0
	public bool Intersects(Rect rect) { }

	// RVA: 0x2080E10 Offset: 0x207F410 VA: 0x182080E10
	public void SetWithPoints(IList<Vector2> points) { }

	// RVA: 0x20810E0 Offset: 0x207F6E0 VA: 0x1820810E0
	public void SetWithPoints(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x2080350 Offset: 0x207E950 VA: 0x182080350
	public static Vector2 Center(IList<Vector2> points) { }

	// RVA: 0x20805D0 Offset: 0x207EBD0 VA: 0x1820805D0
	public static Vector2 Center(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x2081590 Offset: 0x207FB90 VA: 0x182081590
	public static Vector2 Size(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x207FEF0 Offset: 0x207E4F0 VA: 0x18207FEF0
	internal static Vector2 Center(IList<Vector4> points, IEnumerable<int> indexes) { }

	// RVA: 0x2081950 Offset: 0x207FF50 VA: 0x182081950 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
public static class BuiltinMaterials // TypeDefIndex: 11563
{
	// Fields
	private static bool s_IsInitialized; // 0x0
	public const string faceShader = "Hidden/ProBuilder/FaceHighlight";
	public const string lineShader = "Hidden/ProBuilder/LineBillboard";
	public const string lineShaderMetal = "Hidden/ProBuilder/LineBillboardMetal";
	public const string pointShader = "Hidden/ProBuilder/PointBillboard";
	public const string wireShader = "Hidden/ProBuilder/FaceHighlight";
	public const string dotShader = "Hidden/ProBuilder/VertexShader";
	internal static readonly Color previewColor; // 0x4
	private static Shader s_SelectionPickerShader; // 0x18
	private static bool s_GeometryShadersSupported; // 0x20
	private static Material s_DefaultMaterial; // 0x28
	private static Material s_FacePickerMaterial; // 0x30
	private static Material s_VertexPickerMaterial; // 0x38
	private static Material s_EdgePickerMaterial; // 0x40
	private static Material s_UnityDefaultDiffuse; // 0x48
	private static Material s_UnlitVertexColorMaterial; // 0x50
	private static Material s_ShapePreviewMaterial; // 0x58
	private static string k_EdgePickerMaterial; // 0x60
	private static string k_FacePickerMaterial; // 0x68
	private static string k_VertexPickerMaterial; // 0x70
	private static string k_EdgePickerShader; // 0x78
	private static string k_FacePickerShader; // 0x80
	private static string k_VertexPickerShader; // 0x88

	// Properties
	public static bool geometryShadersSupported { get; }
	public static Material defaultMaterial { get; }
	internal static Shader selectionPickerShader { get; }
	internal static Material facePickerMaterial { get; }
	internal static Material vertexPickerMaterial { get; }
	internal static Material edgePickerMaterial { get; }
	internal static Material triggerMaterial { get; }
	internal static Material colliderMaterial { get; }
	[Obsolete("NoDraw is no longer supported.")]
	internal static Material noDrawMaterial { get; }
	internal static Material unlitVertexColor { get; }
	internal static Material ShapePreviewMaterial { get; }

	// Methods

	// RVA: 0x20829D0 Offset: 0x2080FD0 VA: 0x1820829D0
	private static void Init() { }

	// RVA: 0x20836B0 Offset: 0x2081CB0 VA: 0x1820836B0
	public static bool get_geometryShadersSupported() { }

	// RVA: 0x2083590 Offset: 0x2081B90 VA: 0x182083590
	public static Material get_defaultMaterial() { }

	// RVA: 0x2083800 Offset: 0x2081E00 VA: 0x182083800
	internal static Shader get_selectionPickerShader() { }

	// RVA: 0x2083650 Offset: 0x2081C50 VA: 0x182083650
	internal static Material get_facePickerMaterial() { }

	// RVA: 0x20839B0 Offset: 0x2081FB0 VA: 0x1820839B0
	internal static Material get_vertexPickerMaterial() { }

	// RVA: 0x20835F0 Offset: 0x2081BF0 VA: 0x1820835F0
	internal static Material get_edgePickerMaterial() { }

	// RVA: 0x2083860 Offset: 0x2081E60 VA: 0x182083860
	internal static Material get_triggerMaterial() { }

	// RVA: 0x20834A0 Offset: 0x2081AA0 VA: 0x1820834A0
	internal static Material get_colliderMaterial() { }

	// RVA: 0x2083710 Offset: 0x2081D10 VA: 0x182083710
	internal static Material get_noDrawMaterial() { }

	// RVA: 0x20826A0 Offset: 0x2080CA0 VA: 0x1820826A0
	internal static Material GetLegacyDiffuse() { }

	// RVA: 0x2082480 Offset: 0x2080A80 VA: 0x182082480
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x2083950 Offset: 0x2081F50 VA: 0x182083950
	internal static Material get_unlitVertexColor() { }

	// RVA: 0x2083440 Offset: 0x2081A40 VA: 0x182083440
	internal static Material get_ShapePreviewMaterial() { }

	// RVA: 0x2083260 Offset: 0x2081860 VA: 0x182083260
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal class ChangelogEntry // TypeDefIndex: 11564
{
	// Fields
	[SerializeField]
	private SemVer m_VersionInfo; // 0x10
	[SerializeField]
	private string m_ReleaseNotes; // 0x18

	// Properties
	public SemVer versionInfo { get; }
	public string releaseNotes { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public SemVer get_versionInfo() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_releaseNotes() { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(SemVer version, string releaseNotes) { }

	// RVA: 0x2083C40 Offset: 0x2082240 VA: 0x182083C40 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal class Changelog // TypeDefIndex: 11565
{
	// Fields
	private const string k_ChangelogEntryPattern = "(##\\s\\[[0-9]+\\.[0-9]+\\.[0-9]+(\\-[a-zA-Z]+(\\.[0-9]+)*)*\\])";
	private const string k_VersionInfoPattern = "(?<=##\\s\\[).*(?=\\])";
	private const string k_VersionDatePattern = "(?<=##\\s\\[.*\\]\\s-\\s)[0-9-]*";
	[SerializeField]
	private List<ChangelogEntry> m_Entries; // 0x10

	// Properties
	public ReadOnlyCollection<ChangelogEntry> entries { get; }

	// Methods

	// RVA: 0x20840E0 Offset: 0x20826E0 VA: 0x1820840E0
	public ReadOnlyCollection<ChangelogEntry> get_entries() { }

	// RVA: 0x2083E30 Offset: 0x2082430 VA: 0x182083E30
	public void .ctor(string log) { }

	// RVA: 0x2083CB0 Offset: 0x20822B0 VA: 0x182083CB0
	private ChangelogEntry CreateEntry(string version, string contents) { }
}

// Namespace: UnityEngine.ProBuilder
internal static class Clipping // TypeDefIndex: 11567
{
	// Methods

	// RVA: 0x2084150 Offset: 0x2082750 VA: 0x182084150
	private static Clipping.OutCode ComputeOutCode(Rect rect, float x, float y) { }

	// RVA: 0x20841A0 Offset: 0x20827A0 VA: 0x1820841A0
	internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1) { }
}

// Namespace: UnityEngine.ProBuilder
[DisallowMultipleComponent]
internal sealed class ColliderBehaviour : EntityBehaviour // TypeDefIndex: 11568
{
	// Methods

	// RVA: 0x2084410 Offset: 0x2082A10 VA: 0x182084410 Slot: 4
	public override void Initialize() { }

	// RVA: 0x20846A0 Offset: 0x2082CA0 VA: 0x1820846A0 Slot: 5
	public override void OnEnterPlayMode() { }

	// RVA: 0x2084730 Offset: 0x2082D30 VA: 0x182084730 Slot: 6
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x501B30 Offset: 0x500130 VA: 0x180501B30
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
[DefaultMember("Item")]
[Serializable]
internal sealed class ColorPalette : ScriptableObject, IHasDefault // TypeDefIndex: 11569
{
	// Fields
	[CompilerGenerated]
	private Color <current>k__BackingField; // 0x18
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private List<Color> m_Colors; // 0x28

	// Properties
	public Color current { get; set; }
	public ReadOnlyCollection<Color> colors { get; }
	public Color Item { get; set; }
	public int Count { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8641A0 Offset: 0x8627A0 VA: 0x1808641A0
	public Color get_current() { }

	[CompilerGenerated]
	// RVA: 0x14DAB50 Offset: 0x14D9150 VA: 0x1814DAB50
	public void set_current(Color value) { }

	// RVA: 0x2085000 Offset: 0x2083600 VA: 0x182085000
	public ReadOnlyCollection<Color> get_colors() { }

	// RVA: 0x20847C0 Offset: 0x2082DC0 VA: 0x1820847C0
	public void SetColors(IEnumerable<Color> colors) { }

	// RVA: 0x2084870 Offset: 0x2082E70 VA: 0x182084870 Slot: 4
	public void SetDefaultValues() { }

	// RVA: 0x2084F80 Offset: 0x2083580 VA: 0x182084F80
	public Color get_Item(int i) { }

	// RVA: 0x2085070 Offset: 0x2083670 VA: 0x182085070
	public void set_Item(int i, Color value) { }

	// RVA: 0x2084F40 Offset: 0x2083540 VA: 0x182084F40
	public int get_Count() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class HSVColor // TypeDefIndex: 11570
{
	// Fields
	public float h; // 0x10
	public float s; // 0x14
	public float v; // 0x18

	// Methods

	// RVA: 0x2083BF0 Offset: 0x20821F0 VA: 0x182083BF0
	public void .ctor(float h, float s, float v) { }

	// RVA: 0x208A210 Offset: 0x2088810 VA: 0x18208A210
	public void .ctor(float h, float s, float v, float sv_modifier) { }

	// RVA: 0x208A0B0 Offset: 0x20886B0 VA: 0x18208A0B0
	public static HSVColor FromRGB(Color col) { }

	// RVA: 0x208A160 Offset: 0x2088760 VA: 0x18208A160 Slot: 3
	public override string ToString() { }

	// RVA: 0x208A110 Offset: 0x2088710 VA: 0x18208A110
	public float SqrDistance(HSVColor InColor) { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class XYZColor // TypeDefIndex: 11571
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x2083BF0 Offset: 0x20821F0 VA: 0x182083BF0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x209AB00 Offset: 0x2099100 VA: 0x18209AB00
	public static XYZColor FromRGB(Color col) { }

	// RVA: 0x209AA80 Offset: 0x2099080 VA: 0x18209AA80
	public static XYZColor FromRGB(float R, float G, float B) { }

	// RVA: 0x209ABA0 Offset: 0x20991A0 VA: 0x18209ABA0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class CIELabColor // TypeDefIndex: 11572
{
	// Fields
	public float L; // 0x10
	public float a; // 0x14
	public float b; // 0x18

	// Methods

	// RVA: 0x2083BF0 Offset: 0x20821F0 VA: 0x182083BF0
	public void .ctor(float L, float a, float b) { }

	// RVA: 0x2083AF0 Offset: 0x20820F0 VA: 0x182083AF0
	public static CIELabColor FromXYZ(XYZColor xyz) { }

	// RVA: 0x2083A10 Offset: 0x2082010 VA: 0x182083A10
	public static CIELabColor FromRGB(Color col) { }

	// RVA: 0x2083B40 Offset: 0x2082140 VA: 0x182083B40 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class ColorUtility // TypeDefIndex: 11573
{
	// Fields
	private static readonly Dictionary<string, CIELabColor> ColorNameLookup; // 0x0

	// Methods

	// RVA: 0x2085E80 Offset: 0x2084480 VA: 0x182085E80
	private static bool approx(float lhs, float rhs) { }

	// RVA: 0x20855E0 Offset: 0x2083BE0 VA: 0x1820855E0
	public static Color GetColor(Vector3 vec) { }

	// RVA: 0x2085AA0 Offset: 0x20840A0 VA: 0x182085AA0
	public static XYZColor RGBToXYZ(Color col) { }

	// RVA: 0x20858F0 Offset: 0x2083EF0 VA: 0x1820858F0
	public static XYZColor RGBToXYZ(float r, float g, float b) { }

	// RVA: 0x2085D10 Offset: 0x2084310 VA: 0x182085D10
	public static CIELabColor XYZToCIE_Lab(XYZColor xyz) { }

	// RVA: 0x20851B0 Offset: 0x20837B0 VA: 0x1820851B0
	public static float DeltaE(CIELabColor lhs, CIELabColor rhs) { }

	// RVA: 0x2085760 Offset: 0x2083D60 VA: 0x182085760
	public static Color HSVtoRGB(HSVColor hsv) { }

	// RVA: 0x2085640 Offset: 0x2083C40 VA: 0x182085640
	public static Color HSVtoRGB(float h, float s, float v) { }

	// RVA: 0x2085B00 Offset: 0x2084100 VA: 0x182085B00
	public static HSVColor RGBtoHSV(Color color) { }

	// RVA: 0x2085270 Offset: 0x2083870 VA: 0x182085270
	public static string GetColorName(Color InColor) { }

	// RVA: 0x20850E0 Offset: 0x20836E0 VA: 0x1820850E0
	private static CIELabColor CIELabFromRGB(float R, float G, float B, float Scale) { }

	// RVA: 0x205B9D0 Offset: 0x2059FD0 VA: 0x18205B9D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public struct Edge : IEquatable<Edge> // TypeDefIndex: 11574
{
	// Fields
	public int a; // 0x0
	public int b; // 0x4
	public static readonly Edge Empty; // 0x0

	// Methods

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int a, int b) { }

	// RVA: 0x2087820 Offset: 0x2085E20 VA: 0x182087820
	public bool IsValid() { }

	// RVA: 0x20878B0 Offset: 0x2085EB0 VA: 0x1820878B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2087330 Offset: 0x2085930 VA: 0x182087330 Slot: 4
	public bool Equals(Edge other) { }

	// RVA: 0x2087360 Offset: 0x2085960 VA: 0x182087360 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2087560 Offset: 0x2085B60 VA: 0x182087560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FE7730 Offset: 0x1FE5D30 VA: 0x181FE7730
	public static Edge op_Addition(Edge a, Edge b) { }

	// RVA: 0x1FE7D50 Offset: 0x1FE6350 VA: 0x181FE7D50
	public static Edge op_Subtraction(Edge a, Edge b) { }

	// RVA: 0x1FE7750 Offset: 0x1FE5D50 VA: 0x181FE7750
	public static Edge op_Addition(Edge a, int b) { }

	// RVA: 0x1FE7D30 Offset: 0x1FE6330 VA: 0x181FE7D30
	public static Edge op_Subtraction(Edge a, int b) { }

	// RVA: 0x2087A20 Offset: 0x2086020 VA: 0x182087A20
	public static bool op_Equality(Edge a, Edge b) { }

	// RVA: 0x2087AB0 Offset: 0x20860B0 VA: 0x182087AB0
	public static bool op_Inequality(Edge a, Edge b) { }

	// RVA: 0x20871F0 Offset: 0x20857F0 VA: 0x1820871F0
	public static Edge Add(Edge a, Edge b) { }

	// RVA: 0x2087840 Offset: 0x2085E40 VA: 0x182087840
	public static Edge Subtract(Edge a, Edge b) { }

	// RVA: 0x2087430 Offset: 0x2085A30 VA: 0x182087430
	public bool Equals(Edge other, Dictionary<int, int> lookup) { }

	// RVA: 0x2087320 Offset: 0x2085920 VA: 0x182087320
	public bool Contains(int index) { }

	// RVA: 0x2087260 Offset: 0x2085860 VA: 0x182087260
	public bool Contains(Edge other) { }

	// RVA: 0x2087280 Offset: 0x2085880 VA: 0x182087280
	internal bool Contains(int index, Dictionary<int, int> lookup) { }

	// RVA: 0x2087590 Offset: 0x2085B90 VA: 0x182087590
	internal static void GetIndices(IEnumerable<Edge> edges, List<int> indices) { }

	// RVA: 0x20879D0 Offset: 0x2085FD0 VA: 0x1820879D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
public struct EdgeLookup : IEquatable<EdgeLookup> // TypeDefIndex: 11576
{
	// Fields
	private Edge m_Local; // 0x0
	private Edge m_Common; // 0x8

	// Properties
	public Edge local { get; set; }
	public Edge common { get; set; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public Edge get_local() { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void set_local(Edge value) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public Edge get_common() { }

	// RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	public void set_common(Edge value) { }

	// RVA: 0x2086680 Offset: 0x2084C80 VA: 0x182086680
	public void .ctor(Edge common, Edge local) { }

	// RVA: 0x2086650 Offset: 0x2084C50 VA: 0x182086650
	public void .ctor(int cx, int cy, int x, int y) { }

	// RVA: 0x2085FD0 Offset: 0x20845D0 VA: 0x182085FD0 Slot: 4
	public bool Equals(EdgeLookup other) { }

	// RVA: 0x2085EF0 Offset: 0x20844F0 VA: 0x182085EF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20863E0 Offset: 0x20849E0 VA: 0x1820863E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2086690 Offset: 0x2084C90 VA: 0x182086690
	public static bool op_Equality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x2086710 Offset: 0x2084D10 VA: 0x182086710
	public static bool op_Inequality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x2086450 Offset: 0x2084A50 VA: 0x182086450 Slot: 3
	public override string ToString() { }

	// RVA: 0x2086310 Offset: 0x2084910 VA: 0x182086310
	public static IEnumerable<EdgeLookup> GetEdgeLookup(IEnumerable<Edge> edges, Dictionary<int, int> lookup) { }

	// RVA: 0x2086070 Offset: 0x2084670 VA: 0x182086070
	public static HashSet<EdgeLookup> GetEdgeLookupHashSet(IEnumerable<Edge> edges, Dictionary<int, int> lookup) { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
internal static class EdgeUtility // TypeDefIndex: 11578
{
	// Methods

	[Extension]
	// RVA: 0x2086C00 Offset: 0x2085200 VA: 0x182086C00
	public static IEnumerable<Edge> GetSharedVertexHandleEdges(ProBuilderMesh mesh, IEnumerable<Edge> edges) { }

	[Extension]
	// RVA: 0x2086B60 Offset: 0x2085160 VA: 0x182086B60
	public static Edge GetSharedVertexHandleEdge(ProBuilderMesh mesh, Edge edge) { }

	[Extension]
	// RVA: 0x2086960 Offset: 0x2084F60 VA: 0x182086960
	internal static Edge GetEdgeWithSharedVertexHandles(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x2086F10 Offset: 0x2085510 VA: 0x182086F10
	public static bool ValidateEdge(ProBuilderMesh mesh, Edge edge, out SimpleTuple<Face, Edge> validEdge) { }

	[Extension]
	// RVA: 0x20868B0 Offset: 0x2084EB0 VA: 0x1820868B0
	internal static bool Contains(Edge[] edges, Edge edge) { }

	[Extension]
	// RVA: 0x2086840 Offset: 0x2084E40 VA: 0x182086840
	internal static bool Contains(Edge[] edges, int x, int y) { }

	[Extension]
	// RVA: 0x2086CD0 Offset: 0x20852D0 VA: 0x182086CD0
	internal static int IndexOf(ProBuilderMesh mesh, IList<Edge> edges, Edge edge) { }

	[Extension]
	// RVA: 0x2086790 Offset: 0x2084D90 VA: 0x182086790
	internal static int[] AllTriangles(Edge[] edges) { }

	[Extension]
	// RVA: 0x20869E0 Offset: 0x2084FE0 VA: 0x1820869E0
	internal static Face GetFace(ProBuilderMesh mesh, Edge edge) { }
}

// Namespace: UnityEngine.ProBuilder
[DisallowMultipleComponent]
[AddComponentMenu("")]
internal sealed class Entity : MonoBehaviour // TypeDefIndex: 11579
{
	// Fields
	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("_entityType")]
	private EntityType m_EntityType; // 0x20

	// Properties
	public EntityType entityType { get; }

	// Methods

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public EntityType get_entityType() { }

	// RVA: 0x2087BF0 Offset: 0x20861F0 VA: 0x182087BF0
	public void Awake() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void SetEntity(EntityType t) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal abstract class EntityBehaviour : MonoBehaviour // TypeDefIndex: 11580
{
	// Fields
	[Tooltip("Allow ProBuilder to automatically hide and show this object when entering or exiting play mode.")]
	public bool manageVisibility; // 0x20

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnEnterPlayMode();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnSceneLoaded(Scene scene, LoadSceneMode mode);

	// RVA: 0x2087B10 Offset: 0x2086110 VA: 0x182087B10
	protected void SetMaterial(Material material) { }

	// RVA: 0x501B30 Offset: 0x500130 VA: 0x180501B30
	protected void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
[DefaultMember("Item")]
[Serializable]
public sealed class Face // TypeDefIndex: 11581
{
	// Fields
	[FormerlySerializedAs("_indices")]
	[SerializeField]
	private int[] m_Indexes; // 0x10
	[SerializeField]
	[FormerlySerializedAs("_smoothingGroup")]
	private int m_SmoothingGroup; // 0x18
	[SerializeField]
	[FormerlySerializedAs("_uv")]
	private AutoUnwrapSettings m_Uv; // 0x1C
	[SerializeField]
	[FormerlySerializedAs("_mat")]
	private Material m_Material; // 0x40
	[SerializeField]
	private int m_SubmeshIndex; // 0x48
	[SerializeField]
	[FormerlySerializedAs("manualUV")]
	private bool m_ManualUV; // 0x4C
	[SerializeField]
	internal int elementGroup; // 0x50
	[SerializeField]
	private int m_TextureGroup; // 0x54
	private int[] m_DistinctIndexes; // 0x58
	private Edge[] m_Edges; // 0x60

	// Properties
	public bool manualUV { get; set; }
	public int textureGroup { get; set; }
	internal int[] indexesInternal { get; set; }
	public ReadOnlyCollection<int> indexes { get; }
	internal int[] distinctIndexesInternal { get; }
	public ReadOnlyCollection<int> distinctIndexes { get; }
	internal Edge[] edgesInternal { get; }
	public ReadOnlyCollection<Edge> edges { get; }
	public int smoothingGroup { get; set; }
	[Obsolete("Face.material is deprecated. Please use submeshIndex instead.")]
	public Material material { get; set; }
	public int submeshIndex { get; set; }
	public AutoUnwrapSettings uv { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x16EE360 Offset: 0x16EC960 VA: 0x1816EE360
	public bool get_manualUV() { }

	// RVA: 0x16EE370 Offset: 0x16EC970 VA: 0x1816EE370
	public void set_manualUV(bool value) { }

	// RVA: 0x464C80 Offset: 0x463280 VA: 0x180464C80
	public int get_textureGroup() { }

	// RVA: 0x464C90 Offset: 0x463290 VA: 0x180464C90
	public void set_textureGroup(int value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal int[] get_indexesInternal() { }

	// RVA: 0x2089F90 Offset: 0x2088590 VA: 0x182089F90
	internal void set_indexesInternal(int[] value) { }

	// RVA: 0x2089F00 Offset: 0x2088500 VA: 0x182089F00
	public ReadOnlyCollection<int> get_indexes() { }

	// RVA: 0x2088D60 Offset: 0x2087360 VA: 0x182088D60
	public void SetIndexes(IEnumerable<int> indices) { }

	// RVA: 0x2089D50 Offset: 0x2088350 VA: 0x182089D50
	internal int[] get_distinctIndexesInternal() { }

	// RVA: 0x2089DE0 Offset: 0x20883E0 VA: 0x182089DE0
	public ReadOnlyCollection<int> get_distinctIndexes() { }

	// RVA: 0x2089E60 Offset: 0x2088460 VA: 0x182089E60
	internal Edge[] get_edgesInternal() { }

	// RVA: 0x2089E80 Offset: 0x2088480 VA: 0x182089E80
	public ReadOnlyCollection<Edge> get_edges() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_smoothingGroup() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_smoothingGroup(int value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public Material get_material() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_material(Material value) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public int get_submeshIndex() { }

	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	public void set_submeshIndex(int value) { }

	// RVA: 0x2089F70 Offset: 0x2088570 VA: 0x182089F70
	public AutoUnwrapSettings get_uv() { }

	// RVA: 0x208A0A0 Offset: 0x20886A0 VA: 0x18208A0A0
	public void set_uv(AutoUnwrapSettings value) { }

	// RVA: 0x16A6B10 Offset: 0x16A5110 VA: 0x1816A6B10
	public int get_Item(int i) { }

	// RVA: 0x20897A0 Offset: 0x2087DA0 VA: 0x1820897A0
	public void .ctor() { }

	// RVA: 0x2089AF0 Offset: 0x20880F0 VA: 0x182089AF0
	public void .ctor(IEnumerable<int> indices) { }

	[Obsolete("Face.material is deprecated. Please use "submeshIndex" instead.")]
	// RVA: 0x2089C10 Offset: 0x2088210 VA: 0x182089C10
	internal void .ctor(int[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x20897C0 Offset: 0x2087DC0 VA: 0x1820897C0
	internal void .ctor(IEnumerable<int> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x20898F0 Offset: 0x2087EF0 VA: 0x1820898F0
	public void .ctor(Face other) { }

	// RVA: 0x20886C0 Offset: 0x2086CC0 VA: 0x1820886C0
	public void CopyFrom(Face other) { }

	// RVA: 0x2088C60 Offset: 0x2087260 VA: 0x182088C60
	internal void InvalidateCache() { }

	// RVA: 0x2088350 Offset: 0x2086950 VA: 0x182088350
	private Edge[] CacheEdges() { }

	// RVA: 0x20882C0 Offset: 0x20868C0 VA: 0x1820882C0
	private int[] CacheDistinctIndexes() { }

	// RVA: 0x2088640 Offset: 0x2086C40 VA: 0x182088640
	public bool Contains(int a, int b, int c) { }

	// RVA: 0x2088CA0 Offset: 0x20872A0 VA: 0x182088CA0
	public bool IsQuad() { }

	// RVA: 0x2089060 Offset: 0x2087660 VA: 0x182089060
	public int[] ToQuad() { }

	// RVA: 0x2089460 Offset: 0x2087A60 VA: 0x182089460 Slot: 3
	public override string ToString() { }

	// RVA: 0x2088F70 Offset: 0x2087570 VA: 0x182088F70
	public void ShiftIndexes(int offset) { }

	// RVA: 0x2088FF0 Offset: 0x20875F0 VA: 0x182088FF0
	private int SmallestIndexValue() { }

	// RVA: 0x2088EA0 Offset: 0x20874A0 VA: 0x182088EA0
	public void ShiftIndexesToZero() { }

	// RVA: 0x2088D00 Offset: 0x2087300 VA: 0x182088D00
	public void Reverse() { }

	// RVA: 0x2088A90 Offset: 0x2087090 VA: 0x182088A90
	internal static void GetIndices(IEnumerable<Face> faces, List<int> indices) { }

	// RVA: 0x20888B0 Offset: 0x2086EB0 VA: 0x1820888B0
	internal static void GetDistinctIndices(IEnumerable<Face> faces, List<int> indices) { }

	// RVA: 0x2089630 Offset: 0x2087C30 VA: 0x182089630
	internal bool TryGetNextEdge(Edge source, int index, ref Edge nextEdge, ref int nextIndex) { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class FaceRebuildData // TypeDefIndex: 11582
{
	// Fields
	public Face face; // 0x10
	public List<Vertex> vertices; // 0x18
	public List<int> sharedIndexes; // 0x20
	public List<int> sharedIndexesUV; // 0x28
	private int _appliedOffset; // 0x30

	// Methods

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int Offset() { }

	// RVA: 0x2088220 Offset: 0x2086820 VA: 0x182088220 Slot: 3
	public override string ToString() { }

	// RVA: 0x20880A0 Offset: 0x20866A0 VA: 0x1820880A0
	public static void Apply(IEnumerable<FaceRebuildData> newFaces, ProBuilderMesh mesh, List<Vertex> vertices, List<Face> faces) { }

	// RVA: 0x2087CA0 Offset: 0x20862A0 VA: 0x182087CA0
	public static void Apply(IEnumerable<FaceRebuildData> newFaces, List<Vertex> vertices, List<Face> faces, Dictionary<int, int> sharedVertexLookup, Dictionary<int, int> sharedTextureLookup) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class HandleConstraint2D // TypeDefIndex: 11583
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public static readonly HandleConstraint2D None; // 0x0

	// Methods

	// RVA: 0x1669140 Offset: 0x1667740 VA: 0x181669140
	public void .ctor(int x, int y) { }

	// RVA: 0x208A370 Offset: 0x2088970 VA: 0x18208A370
	public HandleConstraint2D Inverse() { }

	// RVA: 0x208A3F0 Offset: 0x20889F0 VA: 0x18208A3F0
	public Vector2 Mask(Vector2 v) { }

	// RVA: 0x208A320 Offset: 0x2088920 VA: 0x18208A320
	public Vector2 InverseMask(Vector2 v) { }

	// RVA: 0x208A5C0 Offset: 0x2088BC0 VA: 0x18208A5C0
	public static bool op_Equality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x208A600 Offset: 0x2088C00 VA: 0x18208A600
	public static bool op_Inequality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x208A280 Offset: 0x2088880 VA: 0x18208A280 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x208A420 Offset: 0x2088A20 VA: 0x18208A420 Slot: 3
	public override string ToString() { }

	// RVA: 0x208A540 Offset: 0x2088B40 VA: 0x18208A540
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
public enum HandleOrientation // TypeDefIndex: 11584
{
	// Fields
	public int value__; // 0x0
	public const HandleOrientation World = 0;
	public const HandleOrientation ActiveObject = 1;
	public const HandleOrientation ActiveElement = 2;
}

// Namespace: UnityEngine.ProBuilder
[Extension]
public static class HandleUtility // TypeDefIndex: 11585
{
	// Methods

	[Extension]
	// RVA: 0x208DCB0 Offset: 0x208C2B0 VA: 0x18208DCB0
	internal static Vector3 ScreenToGuiPoint(Camera camera, Vector3 point, float pixelsPerPoint) { }

	// RVA: 0x208AD20 Offset: 0x2089320 VA: 0x18208AD20
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, HashSet<Face> ignore) { }

	// RVA: 0x208B490 Offset: 0x2089A90 VA: 0x18208B490
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, float distance, CullingMode cullingMode, HashSet<Face> ignore) { }

	// RVA: 0x208A640 Offset: 0x2088C40 VA: 0x18208A640
	internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, ref SimpleTuple<Face, Vector3> back, ref SimpleTuple<Face, Vector3> front) { }

	// RVA: 0x208AD70 Offset: 0x2089370 VA: 0x18208AD70
	internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, out List<RaycastHit> hits, CullingMode cullingMode, HashSet<Face> ignore) { }

	[Extension]
	// RVA: 0x208D1D0 Offset: 0x208B7D0 VA: 0x18208D1D0
	internal static Ray InverseTransformRay(Transform transform, Ray InWorldRay) { }

	// RVA: 0x208D3E0 Offset: 0x208B9E0 VA: 0x18208D3E0
	internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, out RaycastHit hit, float distance = ∞) { }

	// RVA: 0x208D760 Offset: 0x208BD60 VA: 0x18208D760
	internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, int[] triangles, out RaycastHit hit, float distance = ∞) { }

	// RVA: 0x208DA40 Offset: 0x208C040 VA: 0x18208DA40
	internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint) { }

	// RVA: 0x208C7A0 Offset: 0x208ADA0 VA: 0x18208C7A0
	public static Quaternion GetRotation(ProBuilderMesh mesh, IEnumerable<int> indices) { }

	// RVA: 0x208C680 Offset: 0x208AC80 VA: 0x18208C680
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<Face> faces) { }

	// RVA: 0x208C270 Offset: 0x208A870 VA: 0x18208C270
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x208C150 Offset: 0x208A750 VA: 0x18208C150
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<Edge> edges) { }

	// RVA: 0x208BF10 Offset: 0x208A510 VA: 0x18208BF10
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x208D0B0 Offset: 0x208B6B0 VA: 0x18208D0B0
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<int> vertices) { }

	// RVA: 0x208CF80 Offset: 0x208B580 VA: 0x18208CF80
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x208BD30 Offset: 0x208A330 VA: 0x18208BD30
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	// RVA: 0x208BBF0 Offset: 0x208A1F0 VA: 0x18208BBF0
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<Edge> edges) { }

	// RVA: 0x208BE30 Offset: 0x208A430 VA: 0x18208BE30
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<int> vertices) { }
}

// Namespace: UnityEngine.ProBuilder
internal interface IHasDefault // TypeDefIndex: 11586
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetDefaultValues();
}

// Namespace: UnityEngine.ProBuilder
[Extension]
internal static class InternalUtility // TypeDefIndex: 11588
{
	// Methods

	// RVA: -1 Offset: -1
	public static T[] GetComponents<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70F880 Offset: 0x70DE80 VA: 0x18070F880
	|-InternalUtility.GetComponents<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] GetComponents<T>(IEnumerable<Transform> transforms) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70F8E0 Offset: 0x70DEE0 VA: 0x18070F8E0
	|-InternalUtility.GetComponents<object>
	*/

	// RVA: 0x208EE80 Offset: 0x208D480 VA: 0x18208EE80
	public static GameObject EmptyGameObjectWithTransform(Transform t) { }

	// RVA: 0x208EFC0 Offset: 0x208D5C0 VA: 0x18208EFC0
	public static GameObject MeshGameObjectWithTransform(string name, Transform t, Mesh mesh, Material mat, bool inheritParent) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T NextEnumValue<T>(T current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70FB30 Offset: 0x70E130 VA: 0x18070FB30
	|-InternalUtility.NextEnumValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x208EDA0 Offset: 0x208D3A0 VA: 0x18208EDA0
	public static string ControlKeyString(char character) { }

	// RVA: 0x208F1E0 Offset: 0x208D7E0 VA: 0x18208F1E0
	public static bool TryParseColor(string value, ref Color col) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T DemandComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70F5B0 Offset: 0x70DBB0 VA: 0x18070F5B0
	|-InternalUtility.DemandComponent<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T DemandComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70F730 Offset: 0x70DD30 VA: 0x18070F730
	|-InternalUtility.DemandComponent<object>
	*/
}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec2 : IEquatable<IntVec2> // TypeDefIndex: 11589
{
	// Fields
	public Vector2 value; // 0x0

	// Properties
	public float x { get; }
	public float y { get; }

	// Methods

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_x() { }

	// RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	public float get_y() { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(Vector2 vector) { }

	// RVA: 0x208E0F0 Offset: 0x208C6F0 VA: 0x18208E0F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x208E180 Offset: 0x208C780 VA: 0x18208E180
	public static bool op_Equality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x208E1A0 Offset: 0x208C7A0 VA: 0x18208E1A0
	public static bool op_Inequality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x208DD20 Offset: 0x208C320 VA: 0x18208DD20 Slot: 4
	public bool Equals(IntVec2 p) { }

	// RVA: 0x208DE80 Offset: 0x208C480 VA: 0x18208DE80
	public bool Equals(Vector2 p) { }

	// RVA: 0x208DFE0 Offset: 0x208C5E0 VA: 0x18208DFE0 Slot: 0
	public override bool Equals(object b) { }

	// RVA: 0x208E0E0 Offset: 0x208C6E0 VA: 0x18208E0E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x208E1C0 Offset: 0x208C7C0 VA: 0x18208E1C0
	private static int round(float v) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static Vector2 op_Implicit(IntVec2 p) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static IntVec2 op_Implicit(Vector2 p) { }
}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec3 : IEquatable<IntVec3> // TypeDefIndex: 11590
{
	// Fields
	public Vector3 value; // 0x0

	// Properties
	public float x { get; }
	public float y { get; }
	public float z { get; }

	// Methods

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_x() { }

	// RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	public float get_y() { }

	// RVA: 0x1105EF0 Offset: 0x11044F0 VA: 0x181105EF0
	public float get_z() { }

	// RVA: 0x9720D0 Offset: 0x9706D0 VA: 0x1809720D0
	public void .ctor(Vector3 vector) { }

	// RVA: 0x208E580 Offset: 0x208CB80 VA: 0x18208E580 Slot: 3
	public override string ToString() { }

	// RVA: 0x208E630 Offset: 0x208CC30 VA: 0x18208E630
	public static bool op_Equality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x208E660 Offset: 0x208CC60 VA: 0x18208E660
	public static bool op_Inequality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x208E350 Offset: 0x208C950 VA: 0x18208E350 Slot: 4
	public bool Equals(IntVec3 p) { }

	// RVA: 0x208E350 Offset: 0x208C950 VA: 0x18208E350
	public bool Equals(Vector3 p) { }

	// RVA: 0x208E220 Offset: 0x208C820 VA: 0x18208E220 Slot: 0
	public override bool Equals(object b) { }

	// RVA: 0x208E550 Offset: 0x208CB50 VA: 0x18208E550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x208E6B0 Offset: 0x208CCB0 VA: 0x18208E6B0
	private static int round(float v) { }

	// RVA: 0x971FB0 Offset: 0x9705B0 VA: 0x180971FB0
	public static Vector3 op_Implicit(IntVec3 p) { }

	// RVA: 0x971FB0 Offset: 0x9705B0 VA: 0x180971FB0
	public static IntVec3 op_Implicit(Vector3 p) { }
}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec4 : IEquatable<IntVec4> // TypeDefIndex: 11591
{
	// Fields
	public Vector4 value; // 0x0

	// Properties
	public float x { get; }
	public float y { get; }
	public float z { get; }
	public float w { get; }

	// Methods

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_x() { }

	// RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	public float get_y() { }

	// RVA: 0x1105EF0 Offset: 0x11044F0 VA: 0x181105EF0
	public float get_z() { }

	// RVA: 0x19477A0 Offset: 0x1945DA0 VA: 0x1819477A0
	public float get_w() { }

	// RVA: 0x3A43C0 Offset: 0x3A29C0 VA: 0x1803A43C0
	public void .ctor(Vector4 vector) { }

	// RVA: 0x208EAE0 Offset: 0x208D0E0 VA: 0x18208EAE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x208ECF0 Offset: 0x208D2F0 VA: 0x18208ECF0
	public static bool op_Equality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x208ED10 Offset: 0x208D310 VA: 0x18208ED10
	public static bool op_Inequality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x208E830 Offset: 0x208CE30 VA: 0x18208E830 Slot: 4
	public bool Equals(IntVec4 p) { }

	// RVA: 0x208E830 Offset: 0x208CE30 VA: 0x18208E830
	public bool Equals(Vector4 p) { }

	// RVA: 0x208E710 Offset: 0x208CD10 VA: 0x18208E710 Slot: 0
	public override bool Equals(object b) { }

	// RVA: 0x208EAC0 Offset: 0x208D0C0 VA: 0x18208EAC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x208ED40 Offset: 0x208D340 VA: 0x18208ED40
	private static int round(float v) { }

	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public static Vector4 op_Implicit(IntVec4 p) { }

	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public static IntVec4 op_Implicit(Vector4 p) { }
}

// Namespace: UnityEngine.ProBuilder
[Flags]
internal enum LogLevel // TypeDefIndex: 11592
{
	// Fields
	public int value__; // 0x0
	public const LogLevel None = 0;
	public const LogLevel Error = 1;
	public const LogLevel Warning = 2;
	public const LogLevel Info = 4;
	public const LogLevel Default = 3;
	public const LogLevel All = 255;
}

// Namespace: UnityEngine.ProBuilder
[Flags]
internal enum LogOutput // TypeDefIndex: 11593
{
	// Fields
	public int value__; // 0x0
	public const LogOutput None = 0;
	public const LogOutput Console = 1;
	public const LogOutput File = 2;
}

// Namespace: UnityEngine.ProBuilder
internal static class Log // TypeDefIndex: 11594
{
	// Fields
	public const string k_ProBuilderLogFileName = "ProBuilderLog.txt";
	private static Stack<LogLevel> s_logStack; // 0x0
	private static LogLevel s_LogLevel; // 0x8
	private static LogOutput s_Output; // 0xC
	private static string s_LogFilePath; // 0x10

	// Methods

	// RVA: 0x208FBE0 Offset: 0x208E1E0 VA: 0x18208FBE0
	public static void PushLogLevel(LogLevel level) { }

	// RVA: 0x208F7E0 Offset: 0x208DDE0 VA: 0x18208F7E0
	public static void PopLogLevel() { }

	// RVA: 0x208FCE0 Offset: 0x208E2E0 VA: 0x18208FCE0
	public static void SetLogLevel(LogLevel level) { }

	// RVA: 0x208FD40 Offset: 0x208E340 VA: 0x18208FD40
	public static void SetOutput(LogOutput output) { }

	// RVA: 0x208FC70 Offset: 0x208E270 VA: 0x18208FC70
	public static void SetLogFile(string path) { }

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Debug<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Log.Debug<__Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: 0x208F470 Offset: 0x208DA70 VA: 0x18208F470
	public static void Debug(string message) { }

	[Conditional("DEBUG")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Debug(string format, object[] values) { }

	// RVA: 0x208F710 Offset: 0x208DD10 VA: 0x18208F710
	public static void Info(string format, object[] values) { }

	// RVA: 0x208F690 Offset: 0x208DC90 VA: 0x18208F690
	public static void Info(string message) { }

	// RVA: 0x208FDA0 Offset: 0x208E3A0 VA: 0x18208FDA0
	public static void Warning(string format, object[] values) { }

	// RVA: 0x208FE70 Offset: 0x208E470 VA: 0x18208FE70
	public static void Warning(string message) { }

	// RVA: 0x208F620 Offset: 0x208DC20 VA: 0x18208F620
	public static void Error(string format, object[] values) { }

	// RVA: 0x208F5A0 Offset: 0x208DBA0 VA: 0x18208F5A0
	public static void Error(string message) { }

	[Conditional("CONSOLE_PRO_ENABLED")]
	// RVA: -1 Offset: -1
	internal static void Watch<T, K>(T key, K value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72D4D0 Offset: 0x72BAD0 VA: 0x18072D4D0
	|-Log.Watch<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x208F4C0 Offset: 0x208DAC0 VA: 0x18208F4C0
	private static void DoPrint(string message, LogType type) { }

	// RVA: 0x208F930 Offset: 0x208DF30 VA: 0x18208F930
	private static void PrintToFile(string message, string path) { }

	// RVA: 0x208F3E0 Offset: 0x208D9E0 VA: 0x18208F3E0
	public static void ClearLogFile() { }

	// RVA: 0x208F870 Offset: 0x208DE70 VA: 0x18208F870
	private static void PrintToConsole(string message, LogType type = 3) { }

	// RVA: -1 Offset: -1
	internal static void NotNull<T>(T obj, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72D3F0 Offset: 0x72B9F0 VA: 0x18072D3F0
	|-Log.NotNull<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x208FEF0 Offset: 0x208E4F0 VA: 0x18208FEF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class MaterialUtility // TypeDefIndex: 11595
{
	// Fields
	internal static List<Material> s_MaterialArray; // 0x0

	// Methods

	// RVA: 0x208FFF0 Offset: 0x208E5F0 VA: 0x18208FFF0
	internal static int GetMaterialCount(Renderer renderer) { }

	// RVA: 0x20900D0 Offset: 0x208E6D0 VA: 0x1820900D0
	internal static Material GetSharedMaterial(Renderer renderer, int index) { }

	// RVA: 0x2090220 Offset: 0x208E820 VA: 0x182090220
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
public static class Math // TypeDefIndex: 11596
{
	// Fields
	public const float phi = 1.618034;
	private const float k_FltEpsilon = 1E-45;
	private const float k_FltCompareEpsilon = 0.0001;
	internal const float handleEpsilon = 0.0001;
	private static Vector3 tv1; // 0x0
	private static Vector3 tv2; // 0xC
	private static Vector3 tv3; // 0x18
	private static Vector3 tv4; // 0x24

	// Methods

	// RVA: 0x2094670 Offset: 0x2092C70 VA: 0x182094670
	internal static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin) { }

	// RVA: 0x2094880 Offset: 0x2092E80 VA: 0x182094880
	internal static Vector2 PointInEllipseCircumference(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, out Vector2 tangent) { }

	// RVA: 0x20946F0 Offset: 0x2092CF0 VA: 0x1820946F0
	internal static Vector2 PointInEllipseCircumferenceWithConstantAngle(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, out Vector2 tangent) { }

	// RVA: 0x2095090 Offset: 0x2093690 VA: 0x182095090
	internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle) { }

	// RVA: 0x2096000 Offset: 0x2094600 VA: 0x182096000
	internal static float SignedAngle(Vector2 a, Vector2 b) { }

	// RVA: 0x2096370 Offset: 0x2094970 VA: 0x182096370
	public static float SqrDistance(Vector3 a, Vector3 b) { }

	// RVA: 0x2096410 Offset: 0x2094A10 VA: 0x182096410
	public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z) { }

	// RVA: 0x2095160 Offset: 0x2093760 VA: 0x182095160
	internal static float PolygonArea(Vector3[] vertices, int[] indexes) { }

	[Extension]
	// RVA: 0x2095E70 Offset: 0x2094470 VA: 0x182095E70
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	[Extension]
	// RVA: 0x2095F20 Offset: 0x2094520 VA: 0x182095F20
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	// RVA: 0x2094640 Offset: 0x2092C40 VA: 0x182094640
	internal static Vector2 Perpendicular(Vector2 value) { }

	// RVA: 0x2095C90 Offset: 0x2094290 VA: 0x182095C90
	public static Vector2 ReflectPoint(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x20962B0 Offset: 0x20948B0 VA: 0x1820962B0
	internal static float SqrDistanceRayPoint(Ray ray, Vector3 point) { }

	// RVA: 0x2091960 Offset: 0x208FF60 VA: 0x182091960
	public static float DistancePointLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x2091680 Offset: 0x208FC80 VA: 0x182091680
	public static float DistancePointLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd) { }

	// RVA: 0x20927E0 Offset: 0x2090DE0 VA: 0x1820927E0
	public static Vector3 GetNearestPointRayRay(Ray a, Ray b) { }

	// RVA: 0x2092880 Offset: 0x2090E80 VA: 0x182092880
	internal static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd) { }

	// RVA: 0x20924C0 Offset: 0x2090AC0 VA: 0x1820924C0
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect) { }

	// RVA: 0x2092680 Offset: 0x2090C80 VA: 0x182092680
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x2094CA0 Offset: 0x20932A0 VA: 0x182094CA0
	internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, int[] indexes) { }

	// RVA: 0x2094960 Offset: 0x2092F60 VA: 0x182094960
	internal static bool PointInPolygon(Vector2[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x2094AF0 Offset: 0x20930F0 VA: 0x182094AF0
	internal static bool PointInPolygon(Vector3[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x2095C00 Offset: 0x2094200 VA: 0x182095C00
	internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b) { }

	// RVA: 0x2095C50 Offset: 0x2094250 VA: 0x182095C50
	internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b) { }

	// RVA: 0x2095810 Offset: 0x2093E10 VA: 0x182095810
	public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint) { }

	// RVA: 0x2095390 Offset: 0x2093990 VA: 0x182095390
	internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal) { }

	// RVA: 0x2095F80 Offset: 0x2094580 VA: 0x182095F80
	public static float Secant(float x) { }

	// RVA: 0x20944F0 Offset: 0x2092AF0 VA: 0x1820944F0
	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0x2093D30 Offset: 0x2092330 VA: 0x182093D30
	internal static Vector3 Normal(IList<Vertex> vertices, IList<int> indexes) { }

	// RVA: 0x2093A00 Offset: 0x2092000 VA: 0x182093A00
	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x2093350 Offset: 0x2091950 VA: 0x182093350
	public static Normal NormalTangentBitangent(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x2092C60 Offset: 0x2091260 VA: 0x182092C60
	internal static bool IsCardinalAxis(Vector3 v, float epsilon = 1E-45) { }

	[Extension]
	// RVA: 0x1813A50 Offset: 0x1812050 VA: 0x181813A50
	internal static Vector2 DivideBy(Vector2 v, Vector2 o) { }

	[Extension]
	// RVA: 0x18148B0 Offset: 0x1812EB0 VA: 0x1818148B0
	internal static Vector3 DivideBy(Vector3 v, Vector3 o) { }

	// RVA: -1 Offset: -1
	internal static T Max<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72EB00 Offset: 0x72D100 VA: 0x18072EB00
	|-Math.Max<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static T Min<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72F040 Offset: 0x72D640 VA: 0x18072F040
	|-Math.Min<int>
	|
	|-RVA: 0x72EDA0 Offset: 0x72D3A0 VA: 0x18072EDA0
	|-Math.Min<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2093010 Offset: 0x2091610 VA: 0x182093010
	internal static float LargestValue(Vector3 v) { }

	// RVA: 0x2093040 Offset: 0x2091640 VA: 0x182093040
	internal static float LargestValue(Vector2 v) { }

	// RVA: 0x2096040 Offset: 0x2094640 VA: 0x182096040
	internal static Vector2 SmallestVector2(Vector2[] v) { }

	// RVA: 0x20960B0 Offset: 0x20946B0 VA: 0x1820960B0
	internal static Vector2 SmallestVector2(Vector2[] v, IList<int> indexes) { }

	// RVA: 0x2093060 Offset: 0x2091660 VA: 0x182093060
	internal static Vector2 LargestVector2(Vector2[] v) { }

	// RVA: 0x20930E0 Offset: 0x20916E0 VA: 0x1820930E0
	internal static Vector2 LargestVector2(Vector2[] v, IList<int> indexes) { }

	// RVA: 0x2091E00 Offset: 0x2090400 VA: 0x182091E00
	internal static Bounds GetBounds(Vector3[] positions, IList<int> indices) { }

	// RVA: 0x2090B80 Offset: 0x208F180 VA: 0x182090B80
	public static Vector2 Average(IList<Vector2> array, IList<int> indexes) { }

	// RVA: 0x2090F10 Offset: 0x208F510 VA: 0x182090F10
	public static Vector3 Average(IList<Vector3> array, IList<int> indexes) { }

	// RVA: 0x2090410 Offset: 0x208EA10 VA: 0x182090410
	public static Vector4 Average(IList<Vector4> array, IList<int> indexes) { }

	// RVA: 0x2092B60 Offset: 0x2091160 VA: 0x182092B60
	internal static Vector3 InvertScaleVector(Vector3 scaleVector) { }

	[Extension]
	// RVA: 0x20902F0 Offset: 0x208E8F0 VA: 0x1820902F0
	internal static bool Approx2(Vector2 a, Vector2 b, float delta = 0.0001) { }

	[Extension]
	// RVA: 0x2090340 Offset: 0x208E940 VA: 0x182090340
	internal static bool Approx3(Vector3 a, Vector3 b, float delta = 0.0001) { }

	[Extension]
	// RVA: 0x2090390 Offset: 0x208E990 VA: 0x182090390
	internal static bool Approx4(Vector4 a, Vector4 b, float delta = 0.0001) { }

	[Extension]
	// RVA: 0x2090390 Offset: 0x208E990 VA: 0x182090390
	internal static bool ApproxC(Color a, Color b, float delta = 0.0001) { }

	[Extension]
	// RVA: 0x20903F0 Offset: 0x208E9F0 VA: 0x1820903F0
	internal static bool Approx(float a, float b, float delta = 0.0001) { }

	// RVA: 0x195F2A0 Offset: 0x195D8A0 VA: 0x18195F2A0
	public static int Clamp(int value, int lowerBound, int upperBound) { }

	[Extension]
	// RVA: 0x20902B0 Offset: 0x208E8B0 VA: 0x1820902B0
	internal static Vector3 Abs(Vector3 v) { }

	[Extension]
	// RVA: 0x2095FA0 Offset: 0x20945A0 VA: 0x182095FA0
	internal static Vector3 Sign(Vector3 v) { }

	[Extension]
	// RVA: 0x20963E0 Offset: 0x20949E0 VA: 0x1820963E0
	internal static float Sum(Vector3 v) { }

	// RVA: 0x2091620 Offset: 0x208FC20 VA: 0x182091620
	internal static void Cross(Vector3 a, Vector3 b, ref Vector3 res) { }

	// RVA: 0x20963B0 Offset: 0x20949B0 VA: 0x1820963B0
	internal static void Subtract(Vector3 a, Vector3 b, ref Vector3 res) { }

	// RVA: 0x2092EF0 Offset: 0x20914F0 VA: 0x182092EF0
	internal static bool IsNumber(float value) { }

	// RVA: 0x2092F20 Offset: 0x2091520 VA: 0x182092F20
	internal static bool IsNumber(Vector2 value) { }

	// RVA: 0x2092E80 Offset: 0x2091480 VA: 0x182092E80
	internal static bool IsNumber(Vector3 value) { }

	// RVA: 0x2092F80 Offset: 0x2091580 VA: 0x182092F80
	internal static bool IsNumber(Vector4 value) { }

	// RVA: 0x20932F0 Offset: 0x20918F0 VA: 0x1820932F0
	internal static float MakeNonZero(float value, float min = 0.0001) { }

	// RVA: 0x2091D30 Offset: 0x2090330 VA: 0x182091D30
	internal static Vector4 FixNaN(Vector4 value) { }

	// RVA: 0x2091B50 Offset: 0x2090150 VA: 0x182091B50
	internal static Vector2 EnsureUnitVector(Vector2 value) { }

	// RVA: 0x2091AA0 Offset: 0x20900A0 VA: 0x182091AA0
	internal static Vector3 EnsureUnitVector(Vector3 value) { }

	// RVA: 0x2091BF0 Offset: 0x20901F0 VA: 0x182091BF0
	internal static Vector4 EnsureUnitVector(Vector4 value) { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class MeshHandle // TypeDefIndex: 11597
{
	// Fields
	private Transform m_Transform; // 0x10
	private Mesh m_Mesh; // 0x18

	// Properties
	public Mesh mesh { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Mesh get_mesh() { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(Transform transform, Mesh mesh) { }

	// RVA: 0x2096550 Offset: 0x2094B50 VA: 0x182096550
	public void DrawMeshNow(int submeshIndex) { }
}

// Namespace: UnityEngine.ProBuilder
internal static class MeshHandles // TypeDefIndex: 11599
{
	// Fields
	private static List<Vector3> s_Vector2List; // 0x0
	private static List<Vector3> s_Vector3List; // 0x8
	private static List<Vector4> s_Vector4List; // 0x10
	private static List<int> s_IndexList; // 0x18
	private static List<int> s_SharedVertexIndexList; // 0x20
	private static readonly Vector2 k_Billboard0; // 0x28
	private static readonly Vector2 k_Billboard1; // 0x30
	private static readonly Vector2 k_Billboard2; // 0x38
	private static readonly Vector2 k_Billboard3; // 0x40

	// Methods

	// RVA: 0x20984E0 Offset: 0x2096AE0 VA: 0x1820984E0
	internal static void CreateFaceMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x2098360 Offset: 0x2096960 VA: 0x182098360
	internal static void CreateFaceMeshFromFaces(ProBuilderMesh mesh, IList<Face> faces, Mesh target) { }

	// RVA: 0x2097FA0 Offset: 0x20965A0 VA: 0x182097FA0
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x2097C60 Offset: 0x2096260 VA: 0x182097C60
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target, Edge[] edges) { }

	// RVA: 0x209A090 Offset: 0x2098690 VA: 0x18209A090
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x209A370 Offset: 0x2098970 VA: 0x18209A370
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target, IList<int> indexes) { }

	// RVA: 0x2099EB0 Offset: 0x20984B0 VA: 0x182099EB0
	private static void CreatePointMesh(Vector3[] positions, IList<int> indexes, Mesh target) { }

	// RVA: 0x2098670 Offset: 0x2096C70 VA: 0x182098670
	internal static void CreatePointBillboardMesh(IList<Vector3> positions, Mesh target) { }

	// RVA: 0x2099240 Offset: 0x2097840 VA: 0x182099240
	private static void CreatePointBillboardMesh(IList<Vector3> positions, IList<int> indexes, Mesh target) { }

	// RVA: 0x20966A0 Offset: 0x2094CA0 VA: 0x1820966A0
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x2096F70 Offset: 0x2095570 VA: 0x182096F70
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target, ICollection<Edge> edges) { }

	// RVA: 0x209A490 Offset: 0x2098A90 VA: 0x18209A490
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
public static class MeshUtility // TypeDefIndex: 11601
{
	// Methods

	// RVA: 0x209C100 Offset: 0x209A700 VA: 0x18209C100
	internal static Vertex[] GeneratePerTriangleMesh(Mesh mesh) { }

	// RVA: 0x209C460 Offset: 0x209AA60 VA: 0x18209C460
	public static void GenerateTangent(Mesh mesh) { }

	// RVA: 0x209BC60 Offset: 0x209A260 VA: 0x18209BC60
	public static Mesh DeepCopy(Mesh source) { }

	// RVA: 0x209B7C0 Offset: 0x2099DC0 VA: 0x18209B7C0
	public static void CopyTo(Mesh source, Mesh destination) { }

	// RVA: -1 Offset: -1
	internal static T GetMeshChannel<T>(GameObject gameObject, Func<Mesh, T> attributeGetter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x732B00 Offset: 0x731100 VA: 0x180732B00
	|-MeshUtility.GetMeshChannel<object>
	|
	|-RVA: 0x7325D0 Offset: 0x730BD0 VA: 0x1807325D0
	|-MeshUtility.GetMeshChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void PrintAttribute<T>(StringBuilder sb, string title, IEnumerable<T> attrib, string fmt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x732DC0 Offset: 0x7313C0 VA: 0x180732DC0
	|-MeshUtility.PrintAttribute<Color>
	|-MeshUtility.PrintAttribute<Vector4>
	|
	|-RVA: 0x7333F0 Offset: 0x7319F0 VA: 0x1807333F0
	|-MeshUtility.PrintAttribute<Vector2>
	|
	|-RVA: 0x7336B0 Offset: 0x731CB0 VA: 0x1807336B0
	|-MeshUtility.PrintAttribute<Vector3>
	|
	|-RVA: 0x733080 Offset: 0x731680 VA: 0x180733080
	|-MeshUtility.PrintAttribute<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x209D640 Offset: 0x209BC40 VA: 0x18209D640
	public static string Print(Mesh mesh) { }

	// RVA: 0x209CD70 Offset: 0x209B370 VA: 0x18209CD70
	public static uint GetIndexCount(Mesh mesh) { }

	// RVA: 0x209CE20 Offset: 0x209B420 VA: 0x18209CE20
	public static uint GetPrimitiveCount(Mesh mesh) { }

	// RVA: 0x209B250 Offset: 0x2099850 VA: 0x18209B250
	public static void Compile(ProBuilderMesh probuilderMesh, Mesh targetMesh, MeshTopology preferredTopology = 0) { }

	[Extension]
	// RVA: 0x209CF20 Offset: 0x209B520 VA: 0x18209CF20
	public static Vertex[] GetVertices(Mesh mesh) { }

	// RVA: 0x209AD70 Offset: 0x2099370 VA: 0x18209AD70
	public static void CollapseSharedVertices(Mesh mesh, Vertex[] vertices) { }

	// RVA: 0x209BCC0 Offset: 0x209A2C0 VA: 0x18209BCC0
	public static void FitToSize(ProBuilderMesh mesh, Bounds currentSize, Vector3 sizeToFit) { }

	// RVA: 0x209E2B0 Offset: 0x209C8B0 VA: 0x18209E2B0
	internal static string SanityCheck(ProBuilderMesh mesh) { }

	// RVA: 0x209E290 Offset: 0x209C890 VA: 0x18209E290
	internal static string SanityCheck(Mesh mesh) { }

	// RVA: 0x209E2E0 Offset: 0x209C8E0 VA: 0x18209E2E0
	internal static string SanityCheck(IList<Vertex> vertices) { }

	// RVA: 0x209D550 Offset: 0x209BB50 VA: 0x18209D550
	internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x209E200 Offset: 0x209C800 VA: 0x18209E200
	internal static void RestoreParticleSystem(ProBuilderMesh pbmesh) { }

	[Extension]
	// RVA: 0x209CCA0 Offset: 0x209B2A0 VA: 0x18209CCA0
	internal static Bounds GetBounds(ProBuilderMesh mesh) { }
}

// Namespace: UnityEngine.ProBuilder
public struct Normal : IEquatable<Normal> // TypeDefIndex: 11602
{
	// Fields
	[CompilerGenerated]
	private Vector3 <normal>k__BackingField; // 0x0
	[CompilerGenerated]
	private Vector4 <tangent>k__BackingField; // 0xC
	[CompilerGenerated]
	private Vector3 <bitangent>k__BackingField; // 0x1C

	// Properties
	public Vector3 normal { get; set; }
	public Vector4 tangent { get; set; }
	public Vector3 bitangent { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x971FB0 Offset: 0x9705B0 VA: 0x180971FB0
	public Vector3 get_normal() { }

	[CompilerGenerated]
	// RVA: 0x9720D0 Offset: 0x9706D0 VA: 0x1809720D0
	public void set_normal(Vector3 value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x209E8F0 Offset: 0x209CEF0 VA: 0x18209E8F0
	public Vector4 get_tangent() { }

	[CompilerGenerated]
	// RVA: 0x209E9B0 Offset: 0x209CFB0 VA: 0x18209E9B0
	public void set_tangent(Vector4 value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x209E8D0 Offset: 0x209CED0 VA: 0x18209E8D0
	public Vector3 get_bitangent() { }

	[CompilerGenerated]
	// RVA: 0x209E9A0 Offset: 0x209CFA0 VA: 0x18209E9A0
	public void set_bitangent(Vector3 value) { }

	// RVA: 0x209E680 Offset: 0x209CC80 VA: 0x18209E680 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x209E840 Offset: 0x209CE40 VA: 0x18209E840 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x209E730 Offset: 0x209CD30 VA: 0x18209E730 Slot: 4
	public bool Equals(Normal other) { }

	// RVA: 0x209E900 Offset: 0x209CF00 VA: 0x18209E900
	public static bool op_Equality(Normal a, Normal b) { }

	// RVA: 0x209E940 Offset: 0x209CF40 VA: 0x18209E940
	public static bool op_Inequality(Normal a, Normal b) { }
}

// Namespace: UnityEngine.ProBuilder
public static class Normals // TypeDefIndex: 11603
{
	// Fields
	private static Vector3[] s_SmoothAvg; // 0x0
	private static float[] s_SmoothAvgCount; // 0x8
	private static int[] s_CachedIntArray; // 0x10

	// Methods

	// RVA: 0x20A0170 Offset: 0x209E770 VA: 0x1820A0170
	private static void ClearIntArray(int count) { }

	// RVA: 0x209F810 Offset: 0x209DE10 VA: 0x18209F810
	public static void CalculateTangents(ProBuilderMesh mesh) { }

	// RVA: 0x209E9C0 Offset: 0x209CFC0 VA: 0x18209E9C0
	private static void CalculateHardNormals(ProBuilderMesh mesh) { }

	// RVA: 0x209F050 Offset: 0x209D650 VA: 0x18209F050
	public static void CalculateNormals(ProBuilderMesh mesh) { }

	// RVA: 0x20A0280 Offset: 0x209E880 VA: 0x1820A0280
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class ObjectPool<T> : IDisposable // TypeDefIndex: 11604
{
	// Fields
	private bool m_IsDisposed; // 0x0
	private Queue<T> m_Pool; // 0x0
	public int desiredSize; // 0x0
	public Func<T> constructor; // 0x0
	public Action<T> destructor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor, bool lazyInitialization = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEF20 Offset: 0x12DD520 VA: 0x1812DEF20
	|-ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD6A0 Offset: 0x12DBCA0 VA: 0x1812DD6A0
	|-ObjectPool<__Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD970 Offset: 0x12DBF70 VA: 0x1812DD970
	|-ObjectPool<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public void Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD820 Offset: 0x12DBE20 VA: 0x1812DD820
	|-ObjectPool<__Il2CppFullySharedGenericType>.Empty
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD7B0 Offset: 0x12DBDB0 VA: 0x1812DD7B0
	|-ObjectPool<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD7F0 Offset: 0x12DBDF0 VA: 0x1812DD7F0
	|-ObjectPool<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: UnityEngine.ProBuilder
public enum PivotPoint // TypeDefIndex: 11605
{
	// Fields
	public int value__; // 0x0
	public const PivotPoint Center = 0;
	public const PivotPoint IndividualOrigins = 1;
	public const PivotPoint ActiveElement = 2;
}

// Namespace: UnityEngine.ProBuilder
[AddComponentMenu("")]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[ProGridsConditionalSnap]
public sealed class PolyShape : MonoBehaviour // TypeDefIndex: 11607
{
	// Fields
	private ProBuilderMesh m_Mesh; // 0x20
	[FormerlySerializedAs("points")]
	[SerializeField]
	internal List<Vector3> m_Points; // 0x28
	[FormerlySerializedAs("extrude")]
	[SerializeField]
	private float m_Extrude; // 0x30
	[FormerlySerializedAs("polyEditMode")]
	[SerializeField]
	private PolyShape.PolyEditMode m_EditMode; // 0x34
	[FormerlySerializedAs("flipNormals")]
	[SerializeField]
	private bool m_FlipNormals; // 0x38
	[SerializeField]
	internal bool isOnGrid; // 0x39

	// Properties
	public ReadOnlyCollection<Vector3> controlPoints { get; }
	public float extrude { get; set; }
	internal PolyShape.PolyEditMode polyEditMode { get; set; }
	public bool flipNormals { get; set; }
	internal ProBuilderMesh mesh { get; set; }

	// Methods

	// RVA: 0x20A0830 Offset: 0x209EE30 VA: 0x1820A0830
	public ReadOnlyCollection<Vector3> get_controlPoints() { }

	// RVA: 0x20A0750 Offset: 0x209ED50 VA: 0x1820A0750
	public void SetControlPoints(IList<Vector3> points) { }

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0
	public float get_extrude() { }

	// RVA: 0x36F720 Offset: 0x36DD20 VA: 0x18036F720
	public void set_extrude(float value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	internal PolyShape.PolyEditMode get_polyEditMode() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	internal void set_polyEditMode(PolyShape.PolyEditMode value) { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_flipNormals() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_flipNormals(bool value) { }

	// RVA: 0x20A08A0 Offset: 0x209EEA0 VA: 0x1820A08A0
	internal ProBuilderMesh get_mesh() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_mesh(ProBuilderMesh value) { }

	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	private bool IsSnapEnabled() { }

	// RVA: 0x20A07B0 Offset: 0x209EDB0 VA: 0x1820A07B0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class PreferenceDictionary : ScriptableObject, ISerializationCallbackReceiver, IHasDefault // TypeDefIndex: 11608
{
	// Fields
	private Dictionary<string, bool> m_Bool; // 0x18
	private Dictionary<string, int> m_Int; // 0x20
	private Dictionary<string, float> m_Float; // 0x28
	private Dictionary<string, string> m_String; // 0x30
	private Dictionary<string, Color> m_Color; // 0x38
	private Dictionary<string, Material> m_Material; // 0x40
	[SerializeField]
	private List<string> m_Bool_keys; // 0x48
	[SerializeField]
	private List<string> m_Int_keys; // 0x50
	[SerializeField]
	private List<string> m_Float_keys; // 0x58
	[SerializeField]
	private List<string> m_String_keys; // 0x60
	[SerializeField]
	private List<string> m_Color_keys; // 0x68
	[SerializeField]
	private List<string> m_Material_keys; // 0x70
	[SerializeField]
	private List<bool> m_Bool_values; // 0x78
	[SerializeField]
	private List<int> m_Int_values; // 0x80
	[SerializeField]
	private List<float> m_Float_values; // 0x88
	[SerializeField]
	private List<string> m_String_values; // 0x90
	[SerializeField]
	private List<Color> m_Color_values; // 0x98
	[SerializeField]
	private List<Material> m_Material_values; // 0xA0

	// Methods

	// RVA: 0x20A14B0 Offset: 0x209FAB0 VA: 0x1820A14B0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x20A1080 Offset: 0x209F680 VA: 0x1820A1080 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x20A1950 Offset: 0x209FF50 VA: 0x1820A1950 Slot: 6
	public void SetDefaultValues() { }

	// RVA: 0x20A0F40 Offset: 0x209F540 VA: 0x1820A0F40
	public bool HasKey(string key) { }

	// RVA: -1 Offset: -1
	public bool HasKey<T>(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74AFC0 Offset: 0x7495C0 VA: 0x18074AFC0
	|-PreferenceDictionary.HasKey<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x20A0A00 Offset: 0x209F000 VA: 0x1820A0A00
	public void DeleteKey(string key) { }

	// RVA: -1 Offset: -1
	public T Get<T>(string key, T fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74AA80 Offset: 0x749080 VA: 0x18074AA80
	|-PreferenceDictionary.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Set<T>(string key, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74B330 Offset: 0x749930 VA: 0x18074B330
	|-PreferenceDictionary.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x20A0C20 Offset: 0x209F220 VA: 0x1820A0C20
	public bool GetBool(string key, bool fallback = False) { }

	// RVA: 0x20A0DC0 Offset: 0x209F3C0 VA: 0x1820A0DC0
	public int GetInt(string key, int fallback = 0) { }

	// RVA: 0x20A0D30 Offset: 0x209F330 VA: 0x1820A0D30
	public float GetFloat(string key, float fallback = 0) { }

	// RVA: 0x20A0EC0 Offset: 0x209F4C0 VA: 0x1820A0EC0
	public string GetString(string key, string fallback) { }

	// RVA: 0x20A0CA0 Offset: 0x209F2A0 VA: 0x1820A0CA0
	public Color GetColor(string key, Color fallback) { }

	// RVA: 0x20A0E40 Offset: 0x209F440 VA: 0x1820A0E40
	public Material GetMaterial(string key, Material fallback) { }

	// RVA: 0x20A1870 Offset: 0x209FE70 VA: 0x1820A1870
	public void SetBool(string key, bool value) { }

	// RVA: 0x20A1AB0 Offset: 0x20A00B0 VA: 0x1820A1AB0
	public void SetInt(string key, int value) { }

	// RVA: 0x20A1A40 Offset: 0x20A0040 VA: 0x1820A1A40
	public void SetFloat(string key, float value) { }

	// RVA: 0x20A1B90 Offset: 0x20A0190 VA: 0x1820A1B90
	public void SetString(string key, string value) { }

	// RVA: 0x20A18E0 Offset: 0x209FEE0 VA: 0x1820A18E0
	public void SetColor(string key, Color value) { }

	// RVA: 0x20A1B20 Offset: 0x20A0120 VA: 0x1820A1B20
	public void SetMaterial(string key, Material value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Dictionary<string, bool> GetBoolDictionary() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Dictionary<string, int> GetIntDictionary() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Dictionary<string, float> GetFloatDictionary() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Dictionary<string, string> GetStringDictionary() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public Dictionary<string, Color> GetColorDictionary() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public Dictionary<string, Material> GetMaterialDictionary() { }

	// RVA: 0x20A0930 Offset: 0x209EF30 VA: 0x1820A0930
	public void Clear() { }

	// RVA: 0x20A1C00 Offset: 0x20A0200 VA: 0x1820A1C00
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class PreferenceKeys // TypeDefIndex: 11609
{
	// Fields
	public const string pluginTitle = "ProBuilder";
	internal const float k_MaxPointDistanceFromControl = 20;
	internal const char DEGREE_SYMBOL = '\xb0';
	internal const char CMD_SUPER = '\x2318';
	internal const char CMD_SHIFT = '\x21e7';
	internal const char CMD_OPTION = '\x2325';
	internal const char CMD_ALT = '\x2387';
	internal const char CMD_DELETE = '\x232b';
	internal static readonly Color proBuilderBlue; // 0x0
	internal static readonly Color proBuilderLightGray; // 0x10
	internal static readonly Color proBuilderDarkGray; // 0x20
	public const int menuEditor = 100;
	public const int menuSelection = 200;
	public const int menuGeometry = 200;
	public const int menuActions = 300;
	public const int menuMaterialColors = 400;
	public const int menuVertexColors = 400;
	public const int menuRepair = 600;
	public const int menuMisc = 600;
	public const int menuExport = 800;
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultEditLevel = "pbDefaultEditLevel";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultSelectionMode = "pbDefaultSelectionMode";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbHandleAlignment = "pbHandleAlignment";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbVertexColorTool = "pbVertexColorTool";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbToolbarLocation = "pbToolbarLocation";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultEntity = "pbDefaultEntity";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbExtrudeMethod = "pbExtrudeMethod";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultStaticFlags = "pbDefaultStaticFlags";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbSelectedFaceColor = "pbDefaultFaceColor";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbWireframeColor = "pbDefaultEdgeColor";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUnselectedEdgeColor = "pbUnselectedEdgeColor";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbSelectedEdgeColor = "pbSelectedEdgeColor";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbSelectedVertexColor = "pbDefaultSelectedVertexColor";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUnselectedVertexColor = "pbDefaultVertexColor";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbPreselectionColor = "pbPreselectionColor";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultOpenInDockableWindow = "pbDefaultOpenInDockableWindow";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbEditorPrefVersion = "pbEditorPrefVersion";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbEditorShortcutsVersion = "pbEditorShortcutsVersion";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultCollider = "pbDefaultCollider";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbForceConvex = "pbForceConvex";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbVertexColorPrefs = "pbVertexColorPrefs";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowEditorNotifications = "pbShowEditorNotifications";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDragCheckLimit = "pbDragCheckLimit";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbForceVertexPivot = "pbForceVertexPivot";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbForceGridPivot = "pbForceGridPivot";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbManifoldEdgeExtrusion = "pbManifoldEdgeExtrusion";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbPerimeterEdgeBridgeOnly = "pbPerimeterEdgeBridgeOnly";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbPBOSelectionOnly = "pbPBOSelectionOnly";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbCloseShapeWindow = "pbCloseShapeWindow";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUVEditorFloating = "pbUVEditorFloating";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUVMaterialPreview = "pbUVMaterialPreview";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowSceneToolbar = "pbShowSceneToolbar";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbNormalizeUVsOnPlanarProjection = "pbNormalizeUVsOnPlanarProjection";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbStripProBuilderOnBuild = "pbStripProBuilderOnBuild";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDisableAutoUV2Generation = "pbDisableAutoUV2Generation";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowSceneInfo = "pbShowSceneInfo";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbEnableBackfaceSelection = "pbEnableBackfaceSelection";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbVertexPaletteDockable = "pbVertexPaletteDockable";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbExtrudeAsGroup = "pbExtrudeAsGroup";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUniqueModeShortcuts = "pbUniqueModeShortcuts";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbMaterialEditorFloating = "pbMaterialEditorFloating";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShapeWindowFloating = "pbShapeWindowFloating";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbIconGUI = "pbIconGUI";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShiftOnlyTooltips = "pbShiftOnlyTooltips";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDrawAxisLines = "pbDrawAxisLines";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbCollapseVertexToFirst = "pbCollapseVertexToFirst";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbMeshesAreAssets = "pbMeshesAreAssets";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbElementSelectIsHamFisted = "pbElementSelectIsHamFisted";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbFillHoleSelectsEntirePath = "pbFillHoleSelectsEntirePath";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDetachToNewObject = "pbDetachToNewObject";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbPreserveFaces = "pbPreserveFaces";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDragSelectWholeElement = "pbDragSelectWholeElement";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowPreselectionHighlight = "pbShowPreselectionHighlight";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbRectSelectMode = "pbRectSelectMode";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDragSelectMode = "pbDragSelectMode";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShadowCastingMode = "pbShadowCastingMode";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbEnableExperimental = "pbEnableExperimental";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbCheckForProBuilderUpdates = "pbCheckForProBuilderUpdates";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbManageLightmappingStaticFlag = "pbManageLightmappingStaticFlag";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowMissingLightmapUvWarning = "pb_Lightmapping::showMissingLightmapUvWarning";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbSelectedFaceDither = "pbSelectedFaceDither";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUseUnityColors = "pbUseUnityColors";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbVertexHandleSize = "pbVertexHandleSize";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUVGridSnapValue = "pbUVGridSnapValue";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbUVWeldDistance = "pbUVWeldDistance";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbLineHandleSize = "pbLineHandleSize";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbWireframeSize = "pbWireframeSize";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbWeldDistance = "pbWeldDistance";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbExtrudeDistance = "pbExtrudeDistance";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbBevelAmount = "pbBevelAmount";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbEdgeSubdivisions = "pbEdgeSubdivisions";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultShortcuts = "pbDefaultShortcuts";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbDefaultMaterial = "pbDefaultMaterial";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbCurrentMaterialPalette = "pbCurrentMaterialPalette";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbGrowSelectionUsingAngle = "pbGrowSelectionUsingAngle";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbGrowSelectionAngle = "pbGrowSelectionAngle";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbGrowSelectionAngleIterative = "pbGrowSelectionAngleIterative";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowDetail = "pbShowDetail";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowOccluder = "pbShowOccluder";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowMover = "pbShowMover";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowCollider = "pbShowCollider";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowTrigger = "pbShowTrigger";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string pbShowNoDraw = "pbShowNoDraw";
	[Obsolete("Use Pref<T> or Settings class directly.")]
	internal const string defaultUnwrapParameters = "pbDefaultUnwrapParameters";

	// Methods

	// RVA: 0x20A1DE0 Offset: 0x20A03E0 VA: 0x1820A1DE0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Flags]
public enum SelectMode // TypeDefIndex: 11610
{
	// Fields
	public int value__; // 0x0
	public const SelectMode None = 0;
	public const SelectMode Object = 1;
	public const SelectMode Vertex = 2;
	public const SelectMode Edge = 4;
	public const SelectMode Face = 8;
	public const SelectMode TextureFace = 16;
	public const SelectMode TextureEdge = 32;
	public const SelectMode TextureVertex = 64;
	public const SelectMode InputTool = 128;
	public const SelectMode Any = 65535;
}

// Namespace: UnityEngine.ProBuilder
internal enum ComponentMode // TypeDefIndex: 11611
{
	// Fields
	public int value__; // 0x0
	public const ComponentMode Vertex = 0;
	public const ComponentMode Edge = 1;
	public const ComponentMode Face = 2;
}

// Namespace: UnityEngine.ProBuilder
internal enum EditLevel // TypeDefIndex: 11612
{
	// Fields
	public int value__; // 0x0
	public const EditLevel Top = 0;
	public const EditLevel Geometry = 1;
	public const EditLevel Texture = 2;
	public const EditLevel Plugin = 3;
}

// Namespace: UnityEngine.ProBuilder
internal enum EntityType // TypeDefIndex: 11613
{
	// Fields
	public int value__; // 0x0
	public const EntityType Detail = 0;
	public const EntityType Occluder = 1;
	public const EntityType Trigger = 2;
	public const EntityType Collider = 3;
	public const EntityType Mover = 4;
}

// Namespace: UnityEngine.ProBuilder
internal enum ColliderType // TypeDefIndex: 11614
{
	// Fields
	public int value__; // 0x0
	public const ColliderType None = 0;
	public const ColliderType BoxCollider = 1;
	public const ColliderType MeshCollider = 2;
}

// Namespace: UnityEngine.ProBuilder
public enum ProjectionAxis // TypeDefIndex: 11615
{
	// Fields
	public int value__; // 0x0
	public const ProjectionAxis X = 0;
	public const ProjectionAxis Y = 1;
	public const ProjectionAxis Z = 2;
	public const ProjectionAxis XNegative = 3;
	public const ProjectionAxis YNegative = 4;
	public const ProjectionAxis ZNegative = 5;
}

// Namespace: UnityEngine.ProBuilder
internal enum HandleAxis // TypeDefIndex: 11616
{
	// Fields
	public int value__; // 0x0
	public const HandleAxis X = 1;
	public const HandleAxis Y = 2;
	public const HandleAxis Z = 4;
	public const HandleAxis Free = 8;
}

// Namespace: UnityEngine.ProBuilder
public enum Axis // TypeDefIndex: 11617
{
	// Fields
	public int value__; // 0x0
	public const Axis Right = 0;
	public const Axis Left = 1;
	public const Axis Up = 2;
	public const Axis Down = 3;
	public const Axis Forward = 4;
	public const Axis Backward = 5;
}

// Namespace: UnityEngine.ProBuilder
public enum WindingOrder // TypeDefIndex: 11618
{
	// Fields
	public int value__; // 0x0
	public const WindingOrder Unknown = 0;
	public const WindingOrder Clockwise = 1;
	public const WindingOrder CounterClockwise = 2;
}

// Namespace: UnityEngine.ProBuilder
public enum SortMethod // TypeDefIndex: 11619
{
	// Fields
	public int value__; // 0x0
	public const SortMethod Clockwise = 0;
	public const SortMethod CounterClockwise = 1;
}

// Namespace: UnityEngine.ProBuilder
[Flags]
public enum CullingMode // TypeDefIndex: 11620
{
	// Fields
	public int value__; // 0x0
	public const CullingMode None = 0;
	public const CullingMode Back = 1;
	public const CullingMode Front = 2;
	public const CullingMode FrontBack = 3;
}

// Namespace: UnityEngine.ProBuilder
public enum RectSelectMode // TypeDefIndex: 11621
{
	// Fields
	public int value__; // 0x0
	public const RectSelectMode Partial = 0;
	public const RectSelectMode Complete = 1;
}

// Namespace: UnityEngine.ProBuilder
public enum MeshSyncState // TypeDefIndex: 11622
{
	// Fields
	public int value__; // 0x0
	public const MeshSyncState Null = 0;
	[Obsolete("InstanceIDMismatch is no longer used. Mesh references are not tracked by Instance ID.")]
	public const MeshSyncState InstanceIDMismatch = 1;
	public const MeshSyncState Lightmap = 2;
	public const MeshSyncState InSync = 3;
	public const MeshSyncState NeedsRebuild = 4;
}

// Namespace: UnityEngine.ProBuilder
[Flags]
public enum MeshArrays // TypeDefIndex: 11623
{
	// Fields
	public int value__; // 0x0
	public const MeshArrays Position = 1;
	public const MeshArrays Texture0 = 2;
	public const MeshArrays Texture1 = 4;
	public const MeshArrays Lightmap = 4;
	public const MeshArrays Texture2 = 8;
	public const MeshArrays Texture3 = 16;
	public const MeshArrays Color = 32;
	public const MeshArrays Normal = 64;
	public const MeshArrays Tangent = 128;
	public const MeshArrays All = 255;
}

// Namespace: UnityEngine.ProBuilder
internal enum IndexFormat // TypeDefIndex: 11624
{
	// Fields
	public int value__; // 0x0
	public const IndexFormat Local = 0;
	public const IndexFormat Common = 1;
	public const IndexFormat Both = 2;
}

// Namespace: UnityEngine.ProBuilder
[Flags]
public enum RefreshMask // TypeDefIndex: 11625
{
	// Fields
	public int value__; // 0x0
	public const RefreshMask UV = 1;
	public const RefreshMask Colors = 2;
	public const RefreshMask Normals = 4;
	public const RefreshMask Tangents = 8;
	public const RefreshMask Collisions = 16;
	public const RefreshMask Bounds = 22;
	public const RefreshMask All = 31;
}

// Namespace: UnityEngine.ProBuilder
public enum ExtrudeMethod // TypeDefIndex: 11626
{
	// Fields
	public int value__; // 0x0
	public const ExtrudeMethod IndividualFaces = 0;
	public const ExtrudeMethod VertexNormal = 1;
	public const ExtrudeMethod FaceNormal = 2;
}

// Namespace: UnityEngine.ProBuilder
[AddComponentMenu("//ProBuilder MeshFilter")]
[RequireComponent(typeof(MeshRenderer))]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
public sealed class ProBuilderMesh : MonoBehaviour // TypeDefIndex: 11632
{
	// Fields
	internal const HideFlags k_MeshFilterHideFlags = 10;
	private const int k_UVChannelCount = 4;
	internal const int k_MeshFormatVersion = 2;
	internal const int k_MeshFormatVersionSubmeshMaterialRefactor = 1;
	internal const int k_MeshFormatVersionAutoUVScaleOffset = 2;
	public const uint maxVertexCount = 65535;
	[SerializeField]
	private int m_MeshFormatVersion; // 0x20
	[SerializeField]
	[FormerlySerializedAs("_quads")]
	private Face[] m_Faces; // 0x28
	[SerializeField]
	[FormerlySerializedAs("_sharedIndices")]
	[FormerlySerializedAs("m_SharedVertexes")]
	private SharedVertex[] m_SharedVertices; // 0x30
	private ProBuilderMesh.CacheValidState m_CacheValid; // 0x38
	private Dictionary<int, int> m_SharedVertexLookup; // 0x40
	[SerializeField]
	[FormerlySerializedAs("_sharedIndicesUV")]
	private SharedVertex[] m_SharedTextures; // 0x48
	private Dictionary<int, int> m_SharedTextureLookup; // 0x50
	[SerializeField]
	[FormerlySerializedAs("_vertices")]
	private Vector3[] m_Positions; // 0x58
	[SerializeField]
	[FormerlySerializedAs("_uv")]
	private Vector2[] m_Textures0; // 0x60
	[SerializeField]
	[FormerlySerializedAs("_uv3")]
	private List<Vector4> m_Textures2; // 0x68
	[SerializeField]
	[FormerlySerializedAs("_uv4")]
	private List<Vector4> m_Textures3; // 0x70
	[SerializeField]
	[FormerlySerializedAs("_tangents")]
	private Vector4[] m_Tangents; // 0x78
	private Vector3[] m_Normals; // 0x80
	[SerializeField]
	[FormerlySerializedAs("_colors")]
	private Color[] m_Colors; // 0x88
	[CompilerGenerated]
	private bool <userCollisions>k__BackingField; // 0x90
	[FormerlySerializedAs("unwrapParameters")]
	[SerializeField]
	private UnwrapParameters m_UnwrapParameters; // 0x98
	[FormerlySerializedAs("dontDestroyMeshOnDelete")]
	[SerializeField]
	private bool m_PreserveMeshAssetOnDestroy; // 0xA0
	[SerializeField]
	internal string assetGuid; // 0xA8
	[SerializeField]
	private Mesh m_Mesh; // 0xB0
	private MeshRenderer m_MeshRenderer; // 0xB8
	private MeshFilter m_MeshFilter; // 0xC0
	internal const ushort k_UnitializedVersionIndex = 0;
	[SerializeField]
	private ushort m_VersionIndex; // 0xC8
	private ushort m_InstanceVersionIndex; // 0xCA
	[CompilerGenerated]
	private static Action<ProBuilderMesh> meshWillBeDestroyed; // 0x0
	[CompilerGenerated]
	private static Action<ProBuilderMesh> meshWasInitialized; // 0x8
	[CompilerGenerated]
	private static Action<ProBuilderMesh> componentWillBeDestroyed; // 0x10
	[CompilerGenerated]
	private static Action<ProBuilderMesh> componentHasBeenReset; // 0x18
	[CompilerGenerated]
	private static Action<ProBuilderMesh> elementSelectionChanged; // 0x20
	private static HashSet<int> s_CachedHashSet; // 0x28
	[SerializeField]
	private bool m_IsSelectable; // 0xCC
	[SerializeField]
	private int[] m_SelectedFaces; // 0xD0
	[SerializeField]
	private Edge[] m_SelectedEdges; // 0xD8
	[SerializeField]
	private int[] m_SelectedVertices; // 0xE0
	private bool m_SelectedCacheDirty; // 0xE8
	private int m_SelectedSharedVerticesCount; // 0xEC
	private int m_SelectedCoincidentVertexCount; // 0xF0
	private HashSet<int> m_SelectedSharedVertices; // 0xF8
	private List<int> m_SelectedCoincidentVertices; // 0x100

	// Properties
	public bool userCollisions { get; set; }
	public UnwrapParameters unwrapParameters { get; set; }
	internal MeshRenderer renderer { get; }
	internal MeshFilter filter { get; }
	internal ushort versionIndex { get; }
	internal ushort nonSerializedVersionIndex { get; }
	public bool preserveMeshAssetOnDestroy { get; set; }
	internal Face[] facesInternal { get; set; }
	public IList<Face> faces { get; set; }
	internal SharedVertex[] sharedVerticesInternal { get; set; }
	public IList<SharedVertex> sharedVertices { get; set; }
	internal Dictionary<int, int> sharedVertexLookup { get; }
	internal SharedVertex[] sharedTextures { get; set; }
	internal Dictionary<int, int> sharedTextureLookup { get; }
	internal Vector3[] positionsInternal { get; set; }
	public IList<Vector3> positions { get; set; }
	public IList<Vector3> normals { get; }
	internal Vector3[] normalsInternal { get; set; }
	internal Color[] colorsInternal { get; set; }
	public IList<Color> colors { get; set; }
	public IList<Vector4> tangents { get; set; }
	internal Vector4[] tangentsInternal { get; set; }
	internal Vector2[] texturesInternal { get; set; }
	internal List<Vector4> textures2Internal { get; set; }
	internal List<Vector4> textures3Internal { get; set; }
	public IList<Vector2> textures { get; set; }
	public int faceCount { get; }
	public int vertexCount { get; }
	public int edgeCount { get; }
	public int indexCount { get; }
	public int triangleCount { get; }
	internal Mesh mesh { get; set; }
	[Obsolete("InstanceID is not used to track mesh references as of 2023/04/12")]
	internal int id { get; }
	public MeshSyncState meshSyncState { get; }
	internal int meshFormatVersion { get; }
	public bool selectable { get; set; }
	public int selectedFaceCount { get; }
	public int selectedVertexCount { get; }
	public int selectedEdgeCount { get; }
	internal int selectedSharedVerticesCount { get; }
	internal int selectedCoincidentVertexCount { get; }
	internal IEnumerable<int> selectedSharedVertices { get; }
	internal IEnumerable<int> selectedCoincidentVertices { get; }
	public ReadOnlyCollection<int> selectedFaceIndexes { get; }
	public ReadOnlyCollection<int> selectedVertices { get; }
	public ReadOnlyCollection<Edge> selectedEdges { get; }
	internal Face[] selectedFacesInternal { get; set; }
	internal int[] selectedFaceIndicesInternal { get; set; }
	internal Edge[] selectedEdgesInternal { get; set; }
	internal int[] selectedIndexesInternal { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x534920 Offset: 0x532F20 VA: 0x180534920
	public bool get_userCollisions() { }

	[CompilerGenerated]
	// RVA: 0x534950 Offset: 0x532F50 VA: 0x180534950
	public void set_userCollisions(bool value) { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public UnwrapParameters get_unwrapParameters() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public void set_unwrapParameters(UnwrapParameters value) { }

	// RVA: 0x20AAC70 Offset: 0x20A9270 VA: 0x1820AAC70
	internal MeshRenderer get_renderer() { }

	// RVA: 0x20AA7C0 Offset: 0x20A8DC0 VA: 0x1820AA7C0
	internal MeshFilter get_filter() { }

	// RVA: 0x20AB330 Offset: 0x20A9930 VA: 0x1820AB330
	internal ushort get_versionIndex() { }

	// RVA: 0x20AAB70 Offset: 0x20A9170 VA: 0x1820AAB70
	internal ushort get_nonSerializedVersionIndex() { }

	// RVA: 0x156F940 Offset: 0x156DF40 VA: 0x18156F940
	public bool get_preserveMeshAssetOnDestroy() { }

	// RVA: 0x163E120 Offset: 0x163C720 VA: 0x18163E120
	public void set_preserveMeshAssetOnDestroy(bool value) { }

	// RVA: 0x20A6710 Offset: 0x20A4D10 VA: 0x1820A6710
	public bool HasArrays(MeshArrays channels) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal Face[] get_facesInternal() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_facesInternal(Face[] value) { }

	// RVA: 0x20AA750 Offset: 0x20A8D50 VA: 0x1820AA750
	public IList<Face> get_faces() { }

	// RVA: 0x20AB9D0 Offset: 0x20A9FD0 VA: 0x1820AB9D0
	public void set_faces(IList<Face> value) { }

	// RVA: 0x20A6C10 Offset: 0x20A5210 VA: 0x1820A6C10
	internal void InvalidateSharedVertexLookup() { }

	// RVA: 0x20A6B60 Offset: 0x20A5160 VA: 0x1820A6B60
	internal void InvalidateSharedTextureLookup() { }

	// RVA: 0x20A6960 Offset: 0x20A4F60 VA: 0x1820A6960
	internal void InvalidateFaces() { }

	// RVA: 0x20A6920 Offset: 0x20A4F20 VA: 0x1820A6920
	internal void InvalidateCaches() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal SharedVertex[] get_sharedVerticesInternal() { }

	// RVA: 0x20ABC30 Offset: 0x20AA230 VA: 0x1820ABC30
	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	// RVA: 0x20AB060 Offset: 0x20A9660 VA: 0x1820AB060
	public IList<SharedVertex> get_sharedVertices() { }

	// RVA: 0x20ABC60 Offset: 0x20AA260 VA: 0x1820ABC60
	public void set_sharedVertices(IList<SharedVertex> value) { }

	// RVA: 0x20AAFC0 Offset: 0x20A95C0 VA: 0x1820AAFC0
	internal Dictionary<int, int> get_sharedVertexLookup() { }

	// RVA: 0x20A8C20 Offset: 0x20A7220 VA: 0x1820A8C20
	internal void SetSharedVertices(IEnumerable<KeyValuePair<int, int>> indexes) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal SharedVertex[] get_sharedTextures() { }

	// RVA: 0x20ABC00 Offset: 0x20AA200 VA: 0x1820ABC00
	internal void set_sharedTextures(SharedVertex[] value) { }

	// RVA: 0x20AAF20 Offset: 0x20A9520 VA: 0x1820AAF20
	internal Dictionary<int, int> get_sharedTextureLookup() { }

	// RVA: 0x20A8B90 Offset: 0x20A7190 VA: 0x1820A8B90
	internal void SetSharedTextures(IEnumerable<KeyValuePair<int, int>> indexes) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal Vector3[] get_positionsInternal() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	internal void set_positionsInternal(Vector3[] value) { }

	// RVA: 0x20AAC00 Offset: 0x20A9200 VA: 0x1820AAC00
	public IList<Vector3> get_positions() { }

	// RVA: 0x20ABA80 Offset: 0x20AA080 VA: 0x1820ABA80
	public void set_positions(IList<Vector3> value) { }

	// RVA: 0x20A5F50 Offset: 0x20A4550 VA: 0x1820A5F50
	public Vertex[] GetVertices(IList<int> indexes) { }

	// RVA: 0x20A5750 Offset: 0x20A3D50 VA: 0x1820A5750
	internal void GetVerticesInList(IList<Vertex> vertices) { }

	// RVA: 0x20A9190 Offset: 0x20A7790 VA: 0x1820A9190
	public void SetVertices(IList<Vertex> vertices, bool applyMesh = False) { }

	// RVA: 0x20AAB80 Offset: 0x20A9180 VA: 0x1820AAB80
	public IList<Vector3> get_normals() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	internal Vector3[] get_normalsInternal() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void set_normalsInternal(Vector3[] value) { }

	// RVA: 0x20A4B00 Offset: 0x20A3100 VA: 0x1820A4B00
	public Vector3[] GetNormals() { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal Color[] get_colorsInternal() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	internal void set_colorsInternal(Color[] value) { }

	// RVA: 0x20AA620 Offset: 0x20A8C20 VA: 0x1820AA620
	public IList<Color> get_colors() { }

	// RVA: 0x20AB8B0 Offset: 0x20A9EB0 VA: 0x1820AB8B0
	public void set_colors(IList<Color> value) { }

	// RVA: 0x20A4A30 Offset: 0x20A3030 VA: 0x1820A4A30
	public Color[] GetColors() { }

	// RVA: 0x20AB0D0 Offset: 0x20A96D0 VA: 0x1820AB0D0
	public IList<Vector4> get_tangents() { }

	// RVA: 0x20ABE80 Offset: 0x20AA480 VA: 0x1820ABE80
	public void set_tangents(IList<Vector4> value) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	internal Vector4[] get_tangentsInternal() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	internal void set_tangentsInternal(Vector4[] value) { }

	// RVA: 0x20A50F0 Offset: 0x20A36F0 VA: 0x1820A50F0
	public Vector4[] GetTangents() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal Vector2[] get_texturesInternal() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void set_texturesInternal(Vector2[] value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	internal List<Vector4> get_textures2Internal() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	internal void set_textures2Internal(List<Vector4> value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	internal List<Vector4> get_textures3Internal() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	internal void set_textures3Internal(List<Vector4> value) { }

	// RVA: 0x20AB170 Offset: 0x20A9770 VA: 0x1820AB170
	public IList<Vector2> get_textures() { }

	// RVA: 0x20ABF80 Offset: 0x20AA580 VA: 0x1820ABF80
	public void set_textures(IList<Vector2> value) { }

	// RVA: 0x20A52D0 Offset: 0x20A38D0 VA: 0x1820A52D0
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x20A51B0 Offset: 0x20A37B0 VA: 0x1820A51B0
	internal ReadOnlyCollection<Vector2> GetUVs(int channel) { }

	// RVA: 0x20A8D60 Offset: 0x20A7360 VA: 0x1820A8D60
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x20AA730 Offset: 0x20A8D30 VA: 0x1820AA730
	public int get_faceCount() { }

	// RVA: 0x20AB340 Offset: 0x20A9940 VA: 0x1820AB340
	public int get_vertexCount() { }

	// RVA: 0x20AA6A0 Offset: 0x20A8CA0 VA: 0x1820AA6A0
	public int get_edgeCount() { }

	// RVA: 0x20AA8A0 Offset: 0x20A8EA0 VA: 0x1820AA8A0
	public int get_indexCount() { }

	// RVA: 0x20AB1F0 Offset: 0x20A97F0 VA: 0x1820AB1F0
	public int get_triangleCount() { }

	[CompilerGenerated]
	// RVA: 0x20AA510 Offset: 0x20A8B10 VA: 0x1820AA510
	public static void add_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AB7A0 Offset: 0x20A9DA0 VA: 0x1820AB7A0
	public static void remove_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AA400 Offset: 0x20A8A00 VA: 0x1820AA400
	internal static void add_meshWasInitialized(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AB690 Offset: 0x20A9C90 VA: 0x1820AB690
	internal static void remove_meshWasInitialized(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AA1E0 Offset: 0x20A87E0 VA: 0x1820AA1E0
	internal static void add_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AB470 Offset: 0x20A9A70 VA: 0x1820AB470
	internal static void remove_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AA0D0 Offset: 0x20A86D0 VA: 0x1820AA0D0
	internal static void add_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AB360 Offset: 0x20A9960 VA: 0x1820AB360
	internal static void remove_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AA2F0 Offset: 0x20A88F0 VA: 0x1820AA2F0
	public static void add_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x20AB580 Offset: 0x20A9B80 VA: 0x1820AB580
	public static void remove_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	// RVA: 0x20AAAA0 Offset: 0x20A90A0 VA: 0x1820AAAA0
	internal Mesh get_mesh() { }

	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	internal void set_mesh(Mesh value) { }

	// RVA: 0x20AA870 Offset: 0x20A8E70 VA: 0x1820AA870
	internal int get_id() { }

	// RVA: 0x20AA9D0 Offset: 0x20A8FD0 VA: 0x1820AA9D0
	public MeshSyncState get_meshSyncState() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal int get_meshFormatVersion() { }

	// RVA: 0x20A2020 Offset: 0x20A0620 VA: 0x1820A2020
	private void Awake() { }

	// RVA: 0x20A7C00 Offset: 0x20A6200 VA: 0x1820A7C00
	private void Reset() { }

	// RVA: 0x20A6E80 Offset: 0x20A5480 VA: 0x1820A6E80
	private void OnDestroy() { }

	// RVA: 0x20A32E0 Offset: 0x20A18E0 VA: 0x1820A32E0
	internal void DestroyUnityMesh() { }

	// RVA: 0x20A68F0 Offset: 0x20A4EF0 VA: 0x1820A68F0
	private void IncrementVersionIndex() { }

	// RVA: 0x20A24E0 Offset: 0x20A0AE0 VA: 0x1820A24E0
	public void Clear() { }

	// RVA: 0x20A34E0 Offset: 0x20A1AE0 VA: 0x1820A34E0
	internal void EnsureMeshFilterIsAssigned() { }

	// RVA: 0x20A2D30 Offset: 0x20A1330 VA: 0x1820A2D30
	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	// RVA: 0x20A2E50 Offset: 0x20A1450 VA: 0x1820A2E50
	public static ProBuilderMesh Create() { }

	// RVA: 0x20A2EE0 Offset: 0x20A14E0 VA: 0x1820A2EE0
	public static ProBuilderMesh Create(IEnumerable<Vector3> positions, IEnumerable<Face> faces) { }

	// RVA: 0x20A30B0 Offset: 0x20A16B0 VA: 0x1820A30B0
	public static ProBuilderMesh Create(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices, IList<SharedVertex> sharedTextures, IList<Material> materials) { }

	// RVA: 0x20A3740 Offset: 0x20A1D40 VA: 0x1820A3740
	internal void GeometryWithPoints(Vector3[] points) { }

	// RVA: 0x20A7100 Offset: 0x20A5700 VA: 0x1820A7100
	public void RebuildWithPositionsAndFaces(IEnumerable<Vector3> vertices, IEnumerable<Face> faces) { }

	// RVA: 0x20A7240 Offset: 0x20A5840 VA: 0x1820A7240
	internal void Rebuild() { }

	// RVA: 0x20A9530 Offset: 0x20A7B30 VA: 0x1820A9530
	public void ToMesh(MeshTopology preferredTopology = 0) { }

	// RVA: 0x20A3670 Offset: 0x20A1C70 VA: 0x1820A3670
	private void FinalizeToMesh(bool usedInParticleSystem) { }

	// RVA: 0x20A6CD0 Offset: 0x20A52D0 VA: 0x1820A6CD0
	public void MakeUnique() { }

	// RVA: 0x20A2660 Offset: 0x20A0C60 VA: 0x1820A2660
	public void CopyFrom(ProBuilderMesh other) { }

	// RVA: 0x20A79C0 Offset: 0x20A5FC0 VA: 0x1820A79C0
	public void Refresh(RefreshMask mask = 31) { }

	// RVA: 0x20A33E0 Offset: 0x20A19E0 VA: 0x1820A33E0
	internal void EnsureMeshColliderIsAssigned() { }

	// RVA: 0x20A5630 Offset: 0x20A3C30 VA: 0x1820A5630
	internal int GetUnusedTextureGroup(int i = 1) { }

	// RVA: 0x20A6CC0 Offset: 0x20A52C0 VA: 0x1820A6CC0
	private static bool IsValidTextureGroup(int group) { }

	// RVA: 0x20A9DC0 Offset: 0x20A83C0 VA: 0x1820A9DC0
	internal int UnusedElementGroup(int i = 1) { }

	// RVA: 0x20A73A0 Offset: 0x20A59A0 VA: 0x1820A73A0
	public void RefreshUV(IEnumerable<Face> facesToRefresh) { }

	// RVA: 0x20A7FA0 Offset: 0x20A65A0 VA: 0x1820A7FA0
	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	// RVA: 0x20A7270 Offset: 0x20A5870 VA: 0x1820A7270
	private void RefreshColors() { }

	// RVA: 0x20A7CC0 Offset: 0x20A62C0 VA: 0x1820A7CC0
	public void SetFaceColor(Face face, Color color) { }

	// RVA: 0x20A8050 Offset: 0x20A6650 VA: 0x1820A8050
	public void SetMaterial(IEnumerable<Face> faces, Material material) { }

	// RVA: 0x20A72C0 Offset: 0x20A58C0 VA: 0x1820A72C0
	private void RefreshNormals() { }

	// RVA: 0x20A7330 Offset: 0x20A5930 VA: 0x1820A7330
	private void RefreshTangents() { }

	// RVA: 0x20A4D10 Offset: 0x20A3310 VA: 0x1820A4D10
	internal int GetSharedVertexHandle(int vertex) { }

	// RVA: 0x20A4E90 Offset: 0x20A3490 VA: 0x1820A4E90
	internal HashSet<int> GetSharedVertexHandles(IEnumerable<int> vertices) { }

	// RVA: 0x20A4090 Offset: 0x20A2690 VA: 0x1820A4090
	public List<int> GetCoincidentVertices(IEnumerable<int> vertices) { }

	// RVA: 0x20A4660 Offset: 0x20A2C60 VA: 0x1820A4660
	public void GetCoincidentVertices(IEnumerable<Face> faces, List<int> coincident) { }

	// RVA: 0x20A4160 Offset: 0x20A2760 VA: 0x1820A4160
	public void GetCoincidentVertices(IEnumerable<Edge> edges, List<int> coincident) { }

	// RVA: 0x20A3D20 Offset: 0x20A2320 VA: 0x1820A3D20
	public void GetCoincidentVertices(IEnumerable<int> vertices, List<int> coincident) { }

	// RVA: 0x20A3B40 Offset: 0x20A2140 VA: 0x1820A3B40
	public void GetCoincidentVertices(int vertex, List<int> coincident) { }

	// RVA: 0x20A9080 Offset: 0x20A7680 VA: 0x1820A9080
	public void SetVerticesCoincident(IEnumerable<int> vertices) { }

	// RVA: 0x20A8CB0 Offset: 0x20A72B0 VA: 0x1820A8CB0
	internal void SetTexturesCoincident(IEnumerable<int> vertices) { }

	// RVA: 0x20A1F70 Offset: 0x20A0570 VA: 0x1820A1F70
	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	// RVA: 0x20A1E50 Offset: 0x20A0450 VA: 0x1820A1E50
	internal void AddSharedVertex(SharedVertex vertex) { }

	// RVA: 0x20AACE0 Offset: 0x20A92E0 VA: 0x1820AACE0
	public bool get_selectable() { }

	// RVA: 0x20ABB30 Offset: 0x20AA130 VA: 0x1820ABB30
	public void set_selectable(bool value) { }

	// RVA: 0x20AADC0 Offset: 0x20A93C0 VA: 0x1820AADC0
	public int get_selectedFaceCount() { }

	// RVA: 0x20AAE90 Offset: 0x20A9490 VA: 0x1820AAE90
	public int get_selectedVertexCount() { }

	// RVA: 0x20AAD30 Offset: 0x20A9330 VA: 0x1820AAD30
	public int get_selectedEdgeCount() { }

	// RVA: 0x20AAE50 Offset: 0x20A9450 VA: 0x1820AAE50
	internal int get_selectedSharedVerticesCount() { }

	// RVA: 0x20AACF0 Offset: 0x20A92F0 VA: 0x1820AACF0
	internal int get_selectedCoincidentVertexCount() { }

	// RVA: 0x20AAE70 Offset: 0x20A9470 VA: 0x1820AAE70
	internal IEnumerable<int> get_selectedSharedVertices() { }

	// RVA: 0x20AAD10 Offset: 0x20A9310 VA: 0x1820AAD10
	internal IEnumerable<int> get_selectedCoincidentVertices() { }

	// RVA: 0x20A2230 Offset: 0x20A0830 VA: 0x1820A2230
	private void CacheSelection() { }

	// RVA: 0x20A4C30 Offset: 0x20A3230 VA: 0x1820A4C30
	public Face[] GetSelectedFaces() { }

	// RVA: 0x20AADE0 Offset: 0x20A93E0 VA: 0x1820AADE0
	public ReadOnlyCollection<int> get_selectedFaceIndexes() { }

	// RVA: 0x20AAEB0 Offset: 0x20A94B0 VA: 0x1820AAEB0
	public ReadOnlyCollection<int> get_selectedVertices() { }

	// RVA: 0x20AAD50 Offset: 0x20A9350 VA: 0x1820AAD50
	public ReadOnlyCollection<Edge> get_selectedEdges() { }

	// RVA: 0x20A4C30 Offset: 0x20A3230 VA: 0x1820A4C30
	internal Face[] get_selectedFacesInternal() { }

	// RVA: 0x20ABB40 Offset: 0x20AA140 VA: 0x1820ABB40
	internal void set_selectedFacesInternal(Face[] value) { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	internal int[] get_selectedFaceIndicesInternal() { }

	// RVA: 0x510990 Offset: 0x50EF90 VA: 0x180510990
	internal void set_selectedFaceIndicesInternal(int[] value) { }

	// RVA: 0x3A3640 Offset: 0x3A1C40 VA: 0x1803A3640
	internal Edge[] get_selectedEdgesInternal() { }

	// RVA: 0x15B40E0 Offset: 0x15B26E0 VA: 0x1815B40E0
	internal void set_selectedEdgesInternal(Edge[] value) { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	internal int[] get_selectedIndexesInternal() { }

	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	internal void set_selectedIndexesInternal(int[] value) { }

	// RVA: 0x20A3AA0 Offset: 0x20A20A0 VA: 0x1820A3AA0
	internal Face GetActiveFace() { }

	// RVA: 0x20A3A10 Offset: 0x20A2010 VA: 0x1820A3A10
	internal Edge GetActiveEdge() { }

	// RVA: 0x20A3B00 Offset: 0x20A2100 VA: 0x1820A3B00
	internal int GetActiveVertex() { }

	// RVA: 0x20A1F10 Offset: 0x20A0510 VA: 0x1820A1F10
	internal void AddToFaceSelection(int index) { }

	// RVA: 0x20A8750 Offset: 0x20A6D50 VA: 0x1820A8750
	public void SetSelectedFaces(IEnumerable<Face> selected) { }

	// RVA: 0x20A8810 Offset: 0x20A6E10 VA: 0x1820A8810
	internal void SetSelectedFaces(IEnumerable<int> selected) { }

	// RVA: 0x20A8610 Offset: 0x20A6C10 VA: 0x1820A8610
	public void SetSelectedEdges(IEnumerable<Edge> edges) { }

	// RVA: 0x20A8A20 Offset: 0x20A7020 VA: 0x1820A8A20
	public void SetSelectedVertices(IEnumerable<int> vertices) { }

	// RVA: 0x20A7BA0 Offset: 0x20A61A0 VA: 0x1820A7BA0
	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	// RVA: 0x20A2430 Offset: 0x20A0A30 VA: 0x1820A2430
	public void ClearSelection() { }

	// RVA: 0x20A9F70 Offset: 0x20A8570 VA: 0x1820A9F70
	public void .ctor() { }

	// RVA: 0x20A9EE0 Offset: 0x20A84E0 VA: 0x1820A9EE0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x20A9D70 Offset: 0x20A8370 VA: 0x1820A9D70
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	[CompilerGenerated]
	// RVA: 0x20A9CA0 Offset: 0x20A82A0 VA: 0x1820A9CA0
	private int <SetSelectedFaces>b__245_0(Face x) { }

	[CompilerGenerated]
	// RVA: 0x20A9CF0 Offset: 0x20A82F0 VA: 0x1820A9CF0
	private IEnumerable<int> <SetSelectedFaces>b__246_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x20A9D30 Offset: 0x20A8330 VA: 0x1820A9D30
	private IEnumerable<Edge> <SetSelectedFaces>b__246_1(int x) { }
}

// Namespace: UnityEngine.ProBuilder
internal static class ProBuilderSnapping // TypeDefIndex: 11633
{
	// Fields
	private const float k_MaxRaySnapDistance = ∞;

	// Methods

	// RVA: 0x20AC250 Offset: 0x20AA850 VA: 0x1820AC250
	internal static bool IsCardinalDirection(Vector3 direction) { }

	// RVA: 0x20ACEC0 Offset: 0x20AB4C0 VA: 0x1820ACEC0
	public static float Snap(float val, float snap) { }

	// RVA: 0x20ACFC0 Offset: 0x20AB5C0 VA: 0x1820ACFC0
	public static Vector3 Snap(Vector3 val, Vector3 snap) { }

	// RVA: 0x20ACB30 Offset: 0x20AB130 VA: 0x1820ACB30
	public static void SnapVertices(ProBuilderMesh mesh, IEnumerable<int> indexes, Vector3 snap) { }

	// RVA: 0x20AC070 Offset: 0x20AA670 VA: 0x1820AC070
	internal static Vector3 GetSnappingMaskBasedOnNormalVector(Vector3 normal) { }

	// RVA: 0x20AC550 Offset: 0x20AAB50 VA: 0x1820AC550
	internal static Vector3 SnapValueOnRay(Ray ray, float distance, float snap, Vector3Mask mask) { }
}

// Namespace: UnityEngine.ProBuilder
[Usage(4, AllowMultiple = False, Inherited = True)]
internal sealed class ProGridsNoSnapAttribute : Attribute // TypeDefIndex: 11634
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Usage(4, AllowMultiple = False, Inherited = True)]
internal sealed class ProGridsConditionalSnapAttribute : Attribute // TypeDefIndex: 11635
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
public static class Projection // TypeDefIndex: 11637
{
	// Methods

	// RVA: 0x20AEAB0 Offset: 0x20AD0B0 VA: 0x1820AEAB0
	public static Vector2[] PlanarProject(IList<Vector3> positions, IList<int> indexes) { }

	// RVA: 0x20AEBE0 Offset: 0x20AD1E0 VA: 0x1820AEBE0
	public static Vector2[] PlanarProject(IList<Vector3> positions, IList<int> indexes, Vector3 direction) { }

	// RVA: 0x20AE290 Offset: 0x20AC890 VA: 0x1820AE290
	internal static void PlanarProject(IList<Vector3> positions, IList<int> indexes, Vector3 direction, List<Vector2> results) { }

	// RVA: 0x20ADD80 Offset: 0x20AC380 VA: 0x1820ADD80
	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x20AED00 Offset: 0x20AD300 VA: 0x1820AED00
	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x20AF8D0 Offset: 0x20ADED0 VA: 0x1820AF8D0
	internal static Vector2[] SphericalProject(IList<Vector3> vertices, IList<int> indexes) { }

	// RVA: 0x20AF330 Offset: 0x20AD930 VA: 0x1820AF330
	internal static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = 1) { }

	// RVA: 0x20ADCC0 Offset: 0x20AC2C0 VA: 0x1820ADCC0
	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	// RVA: 0x20AF150 Offset: 0x20AD750 VA: 0x1820AF150
	internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis) { }

	// RVA: 0x20AFB60 Offset: 0x20AE160 VA: 0x1820AFB60
	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

	// RVA: 0x20AD6E0 Offset: 0x20ABCE0 VA: 0x1820AD6E0
	public static Plane FindBestPlane(IList<Vector3> points, IList<int> indexes) { }

	// RVA: 0x20AD0A0 Offset: 0x20AB6A0 VA: 0x1820AD0A0
	internal static Plane FindBestPlane(ProBuilderMesh mesh, int textureGroup) { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class RaycastHit // TypeDefIndex: 11638
{
	// Fields
	public float distance; // 0x10
	public Vector3 point; // 0x14
	public Vector3 normal; // 0x20
	public int face; // 0x2C

	// Methods

	// RVA: 0x20AFC80 Offset: 0x20AE280 VA: 0x1820AFC80
	public void .ctor(float distance, Vector3 point, Vector3 normal, int face) { }
}

// Namespace: UnityEngine.ProBuilder
public enum SelectionModifierBehavior // TypeDefIndex: 11639
{
	// Fields
	public int value__; // 0x0
	public const SelectionModifierBehavior Add = 0;
	public const SelectionModifierBehavior Subtract = 1;
	public const SelectionModifierBehavior Difference = 2;
}

// Namespace: UnityEngine.ProBuilder
public static class SelectionPicker // TypeDefIndex: 11640
{
	// Methods

	// RVA: 0x20B55E0 Offset: 0x20B3BE0 VA: 0x1820B55E0
	public static Dictionary<ProBuilderMesh, HashSet<int>> PickVerticesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1) { }

	// RVA: 0x20B45C0 Offset: 0x20B2BC0 VA: 0x1820B45C0
	public static Dictionary<ProBuilderMesh, HashSet<Face>> PickFacesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1) { }

	// RVA: 0x20B3C00 Offset: 0x20B2200 VA: 0x1820B3C00
	public static Dictionary<ProBuilderMesh, HashSet<Edge>> PickEdgesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1) { }

	// RVA: 0x20B44E0 Offset: 0x20B2AE0 VA: 0x1820B44E0
	public static Face PickFace(Camera camera, Vector3 mousePosition, ProBuilderMesh pickable) { }
}

// Namespace: UnityEngine.ProBuilder
public struct PickerOptions // TypeDefIndex: 11641
{
	// Fields
	[CompilerGenerated]
	private bool <depthTest>k__BackingField; // 0x0
	[CompilerGenerated]
	private RectSelectMode <rectSelectMode>k__BackingField; // 0x4
	private static readonly PickerOptions k_Default; // 0x0

	// Properties
	public bool depthTest { get; set; }
	public RectSelectMode rectSelectMode { get; set; }
	public static PickerOptions Default { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_depthTest() { }

	[CompilerGenerated]
	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	public void set_depthTest(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public RectSelectMode get_rectSelectMode() { }

	[CompilerGenerated]
	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_rectSelectMode(RectSelectMode value) { }

	// RVA: 0x20A0580 Offset: 0x209EB80 VA: 0x1820A0580
	public static PickerOptions get_Default() { }

	// RVA: 0x20A0410 Offset: 0x209EA10 VA: 0x1820A0410 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20A0380 Offset: 0x209E980 VA: 0x1820A0380
	public bool Equals(PickerOptions other) { }

	// RVA: 0x20A04B0 Offset: 0x209EAB0 VA: 0x1820A04B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20A05D0 Offset: 0x209EBD0 VA: 0x1820A05D0
	public static bool op_Equality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x20A0690 Offset: 0x209EC90 VA: 0x1820A0690
	public static bool op_Inequality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x20A0530 Offset: 0x209EB30 VA: 0x1820A0530
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class SelectionPickerRenderer // TypeDefIndex: 11647
{
	// Fields
	private const string k_FacePickerOcclusionTintUniform = "_Tint";
	private static readonly Color k_Blackf; // 0x0
	private static readonly Color k_Whitef; // 0x10
	private const uint k_PickerHashNone = 0;
	private const uint k_PickerHashMin = 1;
	private const uint k_PickerHashMax = 16777215;
	private const uint k_MinEdgePixelsForValidSelection = 1;
	private static bool s_Initialized; // 0x20
	private static SelectionPickerRenderer.ISelectionPickerRenderer s_PickerRenderer; // 0x28
	private static RenderTextureFormat s_RenderTextureFormat; // 0x30
	private static RenderTextureFormat[] s_PreferredFormats; // 0x38

	// Properties
	private static RenderTextureFormat renderTextureFormat { get; }
	private static TextureFormat textureFormat { get; }
	private static SelectionPickerRenderer.ISelectionPickerRenderer pickerRenderer { get; }

	// Methods

	// RVA: 0x20B3A40 Offset: 0x20B2040 VA: 0x1820B3A40
	private static RenderTextureFormat get_renderTextureFormat() { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080
	private static TextureFormat get_textureFormat() { }

	// RVA: 0x20B3920 Offset: 0x20B1F20 VA: 0x1820B3920
	private static SelectionPickerRenderer.ISelectionPickerRenderer get_pickerRenderer() { }

	// RVA: 0x20B2160 Offset: 0x20B0760 VA: 0x1820B2160
	public static Dictionary<ProBuilderMesh, HashSet<Face>> PickFacesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, int renderTextureWidth = -1, int renderTextureHeight = -1) { }

	// RVA: 0x20B2710 Offset: 0x20B0D10 VA: 0x1820B2710
	public static Dictionary<ProBuilderMesh, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1) { }

	// RVA: 0x20B1A10 Offset: 0x20B0010 VA: 0x1820B1A10
	public static Dictionary<ProBuilderMesh, HashSet<Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1) { }

	// RVA: 0x20B3600 Offset: 0x20B1C00 VA: 0x1820B3600
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Face>> map, int width = -1, int height = -1) { }

	// RVA: 0x20B3080 Offset: 0x20B1680 VA: 0x1820B3080
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, int>> map, int width = -1, int height = -1) { }

	// RVA: 0x20B3340 Offset: 0x20B1940 VA: 0x1820B3340
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Edge>> map, int width = -1, int height = -1) { }

	// RVA: 0x20B1060 Offset: 0x20AF660 VA: 0x1820B1060
	private static GameObject[] GenerateFacePickingObjects(IList<ProBuilderMesh> selection, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Face>> map) { }

	// RVA: 0x20B15C0 Offset: 0x20AFBC0 VA: 0x1820B15C0
	private static void GenerateVertexPickingObjects(IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, int>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects) { }

	// RVA: 0x20B0C10 Offset: 0x20AF210 VA: 0x1820B0C10
	private static void GenerateEdgePickingObjects(IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Edge>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects) { }

	// RVA: 0x20B01D0 Offset: 0x20AE7D0 VA: 0x1820B01D0
	private static Mesh BuildVertexMesh(ProBuilderMesh pb, Dictionary<uint, SimpleTuple<ProBuilderMesh, int>> map, ref uint index) { }

	// RVA: 0x20AFCF0 Offset: 0x20AE2F0 VA: 0x1820AFCF0
	private static Mesh BuildEdgeMesh(ProBuilderMesh pb, Dictionary<uint, SimpleTuple<ProBuilderMesh, Edge>> map, ref uint index) { }

	// RVA: 0x20B0BD0 Offset: 0x20AF1D0 VA: 0x1820B0BD0
	public static uint DecodeRGBA(Color32 color) { }

	// RVA: 0x20B0BF0 Offset: 0x20AF1F0 VA: 0x1820B0BF0
	public static Color32 EncodeRGBA(uint hash) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	private static bool ShouldUseHDRP() { }

	// RVA: 0x20B3800 Offset: 0x20B1E00 VA: 0x1820B3800
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[EditorBrowsable(1)]
public class SceneSelection : IEquatable<SceneSelection> // TypeDefIndex: 11648
{
	// Fields
	public GameObject gameObject; // 0x10
	public ProBuilderMesh mesh; // 0x18
	private List<int> m_Vertices; // 0x20
	private List<Edge> m_Edges; // 0x28
	private List<Face> m_Faces; // 0x30
	[Obsolete("Use SetSingleVertex")]
	public int vertex; // 0x38
	[Obsolete("Use SetSingleEdge")]
	public Edge edge; // 0x3C
	[Obsolete("Use SetSingleFace")]
	public Face face; // 0x48

	// Properties
	public List<int> vertexes { get; set; }
	public List<Edge> edges { get; set; }
	public List<Face> faces { get; set; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<int> get_vertexes() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_vertexes(List<int> value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<Edge> get_edges() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_edges(List<Edge> value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<Face> get_faces() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_faces(List<Face> value) { }

	// RVA: 0x20B6970 Offset: 0x20B4F70 VA: 0x1820B6970
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x20B6D10 Offset: 0x20B5310 VA: 0x1820B6D10
	public void .ctor(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x20B7260 Offset: 0x20B5860 VA: 0x1820B7260
	public void .ctor(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x20B7050 Offset: 0x20B5650 VA: 0x1820B7050
	public void .ctor(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x20B6BD0 Offset: 0x20B51D0 VA: 0x1820B6BD0
	internal void .ctor(ProBuilderMesh mesh, List<int> vertexes) { }

	// RVA: 0x20B6F10 Offset: 0x20B5510 VA: 0x1820B6F10
	internal void .ctor(ProBuilderMesh mesh, List<Edge> edges) { }

	// RVA: 0x20B6A90 Offset: 0x20B5090 VA: 0x1820B6A90
	internal void .ctor(ProBuilderMesh mesh, List<Face> faces) { }

	// RVA: 0x20B6550 Offset: 0x20B4B50 VA: 0x1820B6550
	public void SetSingleFace(Face face) { }

	// RVA: 0x20B6640 Offset: 0x20B4C40 VA: 0x1820B6640
	public void SetSingleVertex(int vertex) { }

	// RVA: 0x20B6490 Offset: 0x20B4A90 VA: 0x1820B6490
	public void SetSingleEdge(Edge edge) { }

	// RVA: 0x20B5E60 Offset: 0x20B4460 VA: 0x1820B5E60
	public void Clear() { }

	// RVA: 0x20B5F20 Offset: 0x20B4520 VA: 0x1820B5F20
	public void CopyTo(SceneSelection dst) { }

	// RVA: 0x20B6700 Offset: 0x20B4D00 VA: 0x1820B6700 Slot: 3
	public override string ToString() { }

	// RVA: 0x20B6070 Offset: 0x20B4670 VA: 0x1820B6070 Slot: 4
	public bool Equals(SceneSelection other) { }

	// RVA: 0x20B6160 Offset: 0x20B4760 VA: 0x1820B6160 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20B6300 Offset: 0x20B4900 VA: 0x1820B6300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20B7460 Offset: 0x20B5A60 VA: 0x1820B7460
	public static bool op_Equality(SceneSelection left, SceneSelection right) { }

	// RVA: 0x20B7470 Offset: 0x20B5A70 VA: 0x1820B7470
	public static bool op_Inequality(SceneSelection left, SceneSelection right) { }
}

// Namespace: UnityEngine.ProBuilder
internal struct VertexPickerEntry // TypeDefIndex: 11649
{
	// Fields
	public ProBuilderMesh mesh; // 0x0
	public int vertex; // 0x8
	public float screenDistance; // 0xC
	public Vector3 worldPosition; // 0x10
}

// Namespace: UnityEngine.ProBuilder
internal static class SelectPathFaces // TypeDefIndex: 11650
{
	// Fields
	private static int[] s_cachedPredecessors; // 0x0
	private static int s_cachedStart; // 0x8
	private static ProBuilderMesh s_cachedMesh; // 0x10
	private static int s_cachedFacesCount; // 0x18
	private static List<WingedEdge> s_cachedWings; // 0x20
	private static Dictionary<Face, int> s_cachedFacesIndex; // 0x28

	// Methods

	// RVA: 0x20B7CE0 Offset: 0x20B62E0 VA: 0x1820B7CE0
	public static List<int> GetPath(ProBuilderMesh mesh, int start, int end) { }

	// RVA: 0x20B7490 Offset: 0x20B5A90 VA: 0x1820B7490
	private static int[] Dijkstra(ProBuilderMesh mesh, int start) { }

	// RVA: 0x20B8050 Offset: 0x20B6650 VA: 0x1820B8050
	private static float GetWeight(int face1, int face2, ProBuilderMesh mesh) { }

	// RVA: 0x20B7BF0 Offset: 0x20B61F0 VA: 0x1820B7BF0
	private static List<int> GetMinimalPath(int[] predecessors, int start, int end) { }

	// RVA: 0x20B84B0 Offset: 0x20B6AB0 VA: 0x1820B84B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal sealed class SemVer : IEquatable<SemVer>, IComparable<SemVer>, IComparable // TypeDefIndex: 11651
{
	// Fields
	[SerializeField]
	private int m_Major; // 0x10
	[SerializeField]
	private int m_Minor; // 0x14
	[SerializeField]
	private int m_Patch; // 0x18
	[SerializeField]
	private int m_Build; // 0x1C
	[SerializeField]
	private string m_Type; // 0x20
	[SerializeField]
	private string m_Metadata; // 0x28
	[SerializeField]
	private string m_Date; // 0x30
	public const string DefaultStringFormat = "M.m.p-t.b";

	// Properties
	public int major { get; }
	public int minor { get; }
	public int patch { get; }
	public int build { get; }
	public string type { get; }
	public string metadata { get; }
	public string date { get; }
	public SemVer MajorMinorPatch { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_major() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_minor() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_patch() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_build() { }

	// RVA: 0x20B9B60 Offset: 0x20B8160 VA: 0x1820B9B60
	public string get_type() { }

	// RVA: 0x20B9B10 Offset: 0x20B8110 VA: 0x1820B9B10
	public string get_metadata() { }

	// RVA: 0x20B9AC0 Offset: 0x20B80C0 VA: 0x1820B9AC0
	public string get_date() { }

	// RVA: 0x20B9A00 Offset: 0x20B8000 VA: 0x1820B9A00
	public SemVer get_MajorMinorPatch() { }

	// RVA: 0x20B9800 Offset: 0x20B7E00 VA: 0x1820B9800
	public void .ctor() { }

	// RVA: 0x20B9900 Offset: 0x20B7F00 VA: 0x1820B9900
	public void .ctor(string formatted, string date) { }

	// RVA: 0x20B9870 Offset: 0x20B7E70 VA: 0x1820B9870
	public void .ctor(int major, int minor, int patch, int build = -1, string type, string date, string metadata) { }

	// RVA: 0x20B8F70 Offset: 0x20B7570 VA: 0x1820B8F70
	public bool IsValid() { }

	// RVA: 0x20B8AF0 Offset: 0x20B70F0 VA: 0x1820B8AF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x20B8DD0 Offset: 0x20B73D0 VA: 0x1820B8DD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20B8B80 Offset: 0x20B7180 VA: 0x1820B8B80 Slot: 4
	public bool Equals(SemVer version) { }

	// RVA: 0x20B8940 Offset: 0x20B6F40 VA: 0x1820B8940 Slot: 6
	public int CompareTo(object obj) { }

	// RVA: 0x20B97F0 Offset: 0x20B7DF0 VA: 0x1820B97F0
	private static int WrapNoValue(int value) { }

	// RVA: 0x20B89A0 Offset: 0x20B6FA0 VA: 0x1820B89A0 Slot: 5
	public int CompareTo(SemVer version) { }

	// RVA: 0x20B9BB0 Offset: 0x20B81B0 VA: 0x1820B9BB0
	public static bool op_Equality(SemVer left, SemVer right) { }

	// RVA: 0x20B9C70 Offset: 0x20B8270 VA: 0x1820B9C70
	public static bool op_Inequality(SemVer left, SemVer right) { }

	// RVA: 0x20B9D10 Offset: 0x20B8310 VA: 0x1820B9D10
	public static bool op_LessThan(SemVer left, SemVer right) { }

	// RVA: 0x20B9C40 Offset: 0x20B8240 VA: 0x1820B9C40
	public static bool op_GreaterThan(SemVer left, SemVer right) { }

	// RVA: 0x20B9CA0 Offset: 0x20B82A0 VA: 0x1820B9CA0
	public static bool op_LessThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x20B9BD0 Offset: 0x20B81D0 VA: 0x1820B9BD0
	public static bool op_GreaterThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x20B91B0 Offset: 0x20B77B0 VA: 0x1820B91B0
	public string ToString(string format) { }

	// RVA: 0x20B8F90 Offset: 0x20B7590 VA: 0x1820B8F90 Slot: 3
	public override string ToString() { }

	// RVA: 0x20B93E0 Offset: 0x20B79E0 VA: 0x1820B93E0
	public static bool TryGetVersionInfo(string input, out SemVer version) { }

	// RVA: 0x20B8D20 Offset: 0x20B7320 VA: 0x1820B8D20
	private static int GetBuildNumber(string input) { }
}

// Namespace: UnityEngine.ProBuilder
public enum PivotLocation // TypeDefIndex: 11652
{
	// Fields
	public int value__; // 0x0
	public const PivotLocation Center = 0;
	public const PivotLocation FirstCorner = 1;
}

// Namespace: UnityEngine.ProBuilder
public static class ShapeFactory // TypeDefIndex: 11653
{
	// Methods

	// RVA: -1 Offset: -1
	public static ProBuilderMesh Instantiate<T>(PivotLocation pivotType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79DCC0 Offset: 0x79C2C0 VA: 0x18079DCC0
	|-ShapeFactory.Instantiate<object>
	*/

	// RVA: 0x20B9D40 Offset: 0x20B8340 VA: 0x1820B9D40
	public static ProBuilderMesh Instantiate(Type shapeType, PivotLocation pivotType = 0) { }

	// RVA: 0x20B9F90 Offset: 0x20B8590 VA: 0x1820B9F90
	public static ProBuilderMesh Instantiate(Shape shape, PivotLocation pivotType = 0) { }
}

// Namespace: UnityEngine.ProBuilder
public enum ShapeType // TypeDefIndex: 11654
{
	// Fields
	public int value__; // 0x0
	public const ShapeType Cube = 0;
	public const ShapeType Stair = 1;
	public const ShapeType CurvedStair = 2;
	public const ShapeType Prism = 3;
	public const ShapeType Cylinder = 4;
	public const ShapeType Plane = 5;
	public const ShapeType Door = 6;
	public const ShapeType Pipe = 7;
	public const ShapeType Cone = 8;
	public const ShapeType Sprite = 9;
	public const ShapeType Arch = 10;
	public const ShapeType Sphere = 11;
	public const ShapeType Torus = 12;
}

// Namespace: UnityEngine.ProBuilder
public static class ShapeGenerator // TypeDefIndex: 11655
{
	// Fields
	private static readonly Vector3[] k_IcosphereVertices; // 0x0
	private static readonly int[] k_IcosphereTriangles; // 0x8
	private static readonly Vector3[] k_CubeVertices; // 0x10
	private static readonly int[] k_CubeTriangles; // 0x18

	// Methods

	// RVA: 0x20BA1C0 Offset: 0x20B87C0 VA: 0x1820BA1C0
	public static ProBuilderMesh CreateShape(ShapeType shape, PivotLocation pivotType = 0) { }

	// RVA: 0x20C27F0 Offset: 0x20C0DF0 VA: 0x1820C27F0
	public static ProBuilderMesh GenerateStair(PivotLocation pivotType, Vector3 size, int steps, bool buildSides) { }

	// RVA: 0x20BC230 Offset: 0x20BA830 VA: 0x1820BC230
	public static ProBuilderMesh GenerateCurvedStair(PivotLocation pivotType, float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides) { }

	// RVA: 0x20C1F60 Offset: 0x20C0560 VA: 0x1820C1F60
	internal static ProBuilderMesh GenerateStair(PivotLocation pivotType, int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly) { }

	// RVA: 0x20BBF40 Offset: 0x20BA540 VA: 0x1820BBF40
	public static ProBuilderMesh GenerateCube(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x20BD4E0 Offset: 0x20BBAE0 VA: 0x1820BD4E0
	public static ProBuilderMesh GenerateCylinder(PivotLocation pivotType, int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1) { }

	// RVA: 0x20C1750 Offset: 0x20BFD50 VA: 0x1820C1750
	public static ProBuilderMesh GeneratePrism(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x20BE010 Offset: 0x20BC610 VA: 0x1820BE010
	public static ProBuilderMesh GenerateDoor(PivotLocation pivotType, float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth) { }

	// RVA: 0x20C1030 Offset: 0x20BF630 VA: 0x1820C1030
	public static ProBuilderMesh GeneratePlane(PivotLocation pivotType, float width, float height, int widthCuts, int heightCuts, Axis axis) { }

	// RVA: 0x20C0670 Offset: 0x20BEC70 VA: 0x1820C0670
	public static ProBuilderMesh GeneratePipe(PivotLocation pivotType, float radius, float height, float thickness, int subdivAxis, int subdivHeight) { }

	// RVA: 0x20BB410 Offset: 0x20B9A10 VA: 0x1820BB410
	public static ProBuilderMesh GenerateCone(PivotLocation pivotType, float radius, float height, int subdivAxis) { }

	// RVA: 0x20BA800 Offset: 0x20B8E00 VA: 0x1820BA800
	public static ProBuilderMesh GenerateArch(PivotLocation pivotType, float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps) { }

	// RVA: 0x20BF880 Offset: 0x20BDE80 VA: 0x1820BF880
	public static ProBuilderMesh GenerateIcosahedron(PivotLocation pivotType, float radius, int subdivisions, bool weldVertices = True, bool manualUvs = True) { }

	// RVA: 0x20C4180 Offset: 0x20C2780 VA: 0x1820C4180
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x20C3C40 Offset: 0x20C2240 VA: 0x1820C3C40
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x20C3560 Offset: 0x20C1B60 VA: 0x1820C3560
	public static ProBuilderMesh GenerateTorus(PivotLocation pivotType, int rows, int columns, float innerRadius, float outerRadius, bool smooth, float horizontalCircumference, float verticalCircumference, bool manualUvs = False) { }

	// RVA: 0x20C4910 Offset: 0x20C2F10 VA: 0x1820C4910
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[DefaultMember("Item")]
[Serializable]
public sealed class SharedVertex : ICollection<int>, IEnumerable<int>, IEnumerable // TypeDefIndex: 11657
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("array")]
	[FormerlySerializedAs("m_Vertexes")]
	private int[] m_Vertices; // 0x10

	// Properties
	internal int[] arrayInternal { get; }
	public int Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal int[] get_arrayInternal() { }

	// RVA: 0x20C6570 Offset: 0x20C4B70 VA: 0x1820C6570
	public void .ctor(IEnumerable<int> indexes) { }

	// RVA: 0x20C6620 Offset: 0x20C4C20 VA: 0x1820C6620
	public void .ctor(SharedVertex sharedVertex) { }

	// RVA: 0x16A6B10 Offset: 0x16A5110 VA: 0x1816A6B10
	public int get_Item(int i) { }

	// RVA: 0x20C6720 Offset: 0x20C4D20 VA: 0x1820C6720
	public void set_Item(int i, int value) { }

	// RVA: 0x20C4F60 Offset: 0x20C3560 VA: 0x1820C4F60 Slot: 11
	public IEnumerator<int> GetEnumerator() { }

	// RVA: 0x20C6520 Offset: 0x20C4B20 VA: 0x1820C6520 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C4F60 Offset: 0x20C3560 VA: 0x1820C4F60 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x20C4E60 Offset: 0x20C3460 VA: 0x1820C4E60 Slot: 6
	public void Add(int item) { }

	// RVA: 0x20C4EC0 Offset: 0x20C34C0 VA: 0x1820C4EC0 Slot: 7
	public void Clear() { }

	// RVA: 0x20C4F10 Offset: 0x20C3510 VA: 0x1820C4F10 Slot: 8
	public bool Contains(int item) { }

	// RVA: 0x128CBE0 Offset: 0x128B1E0 VA: 0x18128CBE0 Slot: 9
	public void CopyTo(int[] array, int arrayIndex) { }

	// RVA: 0x20C58B0 Offset: 0x20C3EB0 VA: 0x1820C58B0 Slot: 10
	public bool Remove(int item) { }

	// RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700 Slot: 4
	public int get_Count() { }

	// RVA: 0x20C6700 Offset: 0x20C4D00 VA: 0x1820C6700 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x20C4FB0 Offset: 0x20C35B0 VA: 0x1820C4FB0
	public static void GetSharedVertexLookup(IList<SharedVertex> sharedVertices, Dictionary<int, int> lookup) { }

	// RVA: 0x20C5B40 Offset: 0x20C4140 VA: 0x1820C5B40
	internal void ShiftIndexes(int offset) { }

	// RVA: 0x20C5EF0 Offset: 0x20C44F0 VA: 0x1820C5EF0
	internal static SharedVertex[] ToSharedVertices(IEnumerable<KeyValuePair<int, int>> lookup) { }

	// RVA: 0x20C6330 Offset: 0x20C4930 VA: 0x1820C6330
	private static SharedVertex[] ToSharedVertices(List<List<int>> list) { }

	// RVA: 0x20C5270 Offset: 0x20C3870 VA: 0x1820C5270
	public static SharedVertex[] GetSharedVerticesWithPositions(IList<Vector3> positions) { }

	// RVA: 0x20C5800 Offset: 0x20C3E00 VA: 0x1820C5800
	internal static SharedVertex[] RemoveAndShift(Dictionary<int, int> lookup, IEnumerable<int> remove) { }

	// RVA: 0x20C5BA0 Offset: 0x20C41A0 VA: 0x1820C5BA0
	internal static SharedVertex[] SortedRemoveAndShift(Dictionary<int, int> lookup, List<int> remove) { }

	// RVA: 0x20C5940 Offset: 0x20C3F40 VA: 0x1820C5940
	internal static void SetCoincident(ref Dictionary<int, int> lookup, IEnumerable<int> vertices) { }
}

// Namespace: UnityEngine.ProBuilder
public struct SimpleTuple<T1, T2> // TypeDefIndex: 11658
{
	// Fields
	private T1 m_Item1; // 0x0
	private T2 m_Item2; // 0x0

	// Properties
	public T1 item1 { get; set; }
	public T2 item2 { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	|-SimpleTuple<int, int>.get_item1
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-SimpleTuple<object, Edge>.get_item1
	|-SimpleTuple<object, int>.get_item1
	|-SimpleTuple<object, object>.get_item1
	|-SimpleTuple<object, Vector3>.get_item1
	|
	|-RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	|-SimpleTuple<float, Vector2>.get_item1
	|
	|-RVA: 0x9711B0 Offset: 0x96F7B0 VA: 0x1809711B0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_item1
	*/

	// RVA: -1 Offset: -1
	public void set_item1(T1 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	|-SimpleTuple<int, int>.set_item1
	|
	|-RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	|-SimpleTuple<object, Edge>.set_item1
	|-SimpleTuple<object, int>.set_item1
	|-SimpleTuple<object, object>.set_item1
	|-SimpleTuple<object, Vector3>.set_item1
	|
	|-RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	|-SimpleTuple<float, Vector2>.set_item1
	|
	|-RVA: 0x971390 Offset: 0x96F990 VA: 0x180971390
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	|-SimpleTuple<int, int>.get_item2
	|
	|-RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	|-SimpleTuple<object, Edge>.get_item2
	|-SimpleTuple<object, object>.get_item2
	|
	|-RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	|-SimpleTuple<object, int>.get_item2
	|
	|-RVA: 0x971280 Offset: 0x96F880 VA: 0x180971280
	|-SimpleTuple<object, Vector3>.get_item2
	|
	|-RVA: 0x3A4A80 Offset: 0x3A3080 VA: 0x1803A4A80
	|-SimpleTuple<float, Vector2>.get_item2
	|
	|-RVA: 0x9712B0 Offset: 0x96F8B0 VA: 0x1809712B0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_item2
	*/

	// RVA: -1 Offset: -1
	public void set_item2(T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	|-SimpleTuple<int, int>.set_item2
	|
	|-RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	|-SimpleTuple<object, Edge>.set_item2
	|
	|-RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	|-SimpleTuple<object, int>.set_item2
	|
	|-RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	|-SimpleTuple<object, object>.set_item2
	|
	|-RVA: 0x9714B0 Offset: 0x96FAB0 VA: 0x1809714B0
	|-SimpleTuple<object, Vector3>.set_item2
	|
	|-RVA: 0x3A4C40 Offset: 0x3A3240 VA: 0x1803A4C40
	|-SimpleTuple<float, Vector2>.set_item2
	|
	|-RVA: 0x9714D0 Offset: 0x96FAD0 VA: 0x1809714D0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_item2
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	|-SimpleTuple<int, int>..ctor
	|
	|-RVA: 0x971180 Offset: 0x96F780 VA: 0x180971180
	|-SimpleTuple<object, Edge>..ctor
	|
	|-RVA: 0x970F90 Offset: 0x96F590 VA: 0x180970F90
	|-SimpleTuple<object, int>..ctor
	|
	|-RVA: 0x598200 Offset: 0x596800 VA: 0x180598200
	|-SimpleTuple<object, object>..ctor
	|
	|-RVA: 0x970F50 Offset: 0x96F550 VA: 0x180970F50
	|-SimpleTuple<object, Vector3>..ctor
	|
	|-RVA: 0x970F40 Offset: 0x96F540 VA: 0x180970F40
	|-SimpleTuple<float, Vector2>..ctor
	|
	|-RVA: 0x970FC0 Offset: 0x96F5C0 VA: 0x180970FC0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x970A90 Offset: 0x96F090 VA: 0x180970A90
	|-SimpleTuple<int, int>.ToString
	|
	|-RVA: 0x9707C0 Offset: 0x96EDC0 VA: 0x1809707C0
	|-SimpleTuple<object, Edge>.ToString
	|
	|-RVA: 0x9708C0 Offset: 0x96EEC0 VA: 0x1809708C0
	|-SimpleTuple<object, int>.ToString
	|
	|-RVA: 0x970610 Offset: 0x96EC10 VA: 0x180970610
	|-SimpleTuple<object, object>.ToString
	|
	|-RVA: 0x9709A0 Offset: 0x96EFA0 VA: 0x1809709A0
	|-SimpleTuple<object, Vector3>.ToString
	|
	|-RVA: 0x9706D0 Offset: 0x96ECD0 VA: 0x1809706D0
	|-SimpleTuple<float, Vector2>.ToString
	|
	|-RVA: 0x970B70 Offset: 0x96F170 VA: 0x180970B70
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: UnityEngine.ProBuilder
internal struct SimpleTuple<T1, T2, T3> // TypeDefIndex: 11659
{
	// Fields
	private T1 m_Item1; // 0x0
	private T2 m_Item2; // 0x0
	private T3 m_Item3; // 0x0

	// Properties
	public T1 item1 { get; set; }
	public T2 item2 { get; set; }
	public T3 item3 { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x971FB0 Offset: 0x9705B0 VA: 0x180971FB0
	|-SimpleTuple<Vector3, Vector3, object>.get_item1
	|
	|-RVA: 0x9711B0 Offset: 0x96F7B0 VA: 0x1809711B0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_item1
	*/

	// RVA: -1 Offset: -1
	public void set_item1(T1 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9720D0 Offset: 0x9706D0 VA: 0x1809720D0
	|-SimpleTuple<Vector3, Vector3, object>.set_item1
	|
	|-RVA: 0x971390 Offset: 0x96F990 VA: 0x180971390
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x971FD0 Offset: 0x9705D0 VA: 0x180971FD0
	|-SimpleTuple<Vector3, Vector3, object>.get_item2
	|
	|-RVA: 0x9712B0 Offset: 0x96F8B0 VA: 0x1809712B0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_item2
	*/

	// RVA: -1 Offset: -1
	public void set_item2(T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9720E0 Offset: 0x9706E0 VA: 0x1809720E0
	|-SimpleTuple<Vector3, Vector3, object>.set_item2
	|
	|-RVA: 0x9714D0 Offset: 0x96FAD0 VA: 0x1809714D0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-SimpleTuple<Vector3, Vector3, object>.get_item3
	|
	|-RVA: 0x971FF0 Offset: 0x9705F0 VA: 0x180971FF0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_item3
	*/

	// RVA: -1 Offset: -1
	public void set_item3(T3 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	|-SimpleTuple<Vector3, Vector3, object>.set_item3
	|
	|-RVA: 0x9720F0 Offset: 0x9706F0 VA: 0x1809720F0
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_item3
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x971CF0 Offset: 0x9702F0 VA: 0x180971CF0
	|-SimpleTuple<Vector3, Vector3, object>..ctor
	|
	|-RVA: 0x971D20 Offset: 0x970320 VA: 0x180971D20
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9715D0 Offset: 0x96FBD0 VA: 0x1809715D0
	|-SimpleTuple<Vector3, Vector3, object>.ToString
	|
	|-RVA: 0x971720 Offset: 0x96FD20 VA: 0x180971720
	|-SimpleTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: UnityEngine.ProBuilder
public static class Smoothing // TypeDefIndex: 11661
{
	// Fields
	internal const int smoothingGroupNone = 0;
	internal const int smoothRangeMin = 1;
	internal const int smoothRangeMax = 24;
	internal const int hardRangeMin = 25;
	internal const int hardRangeMax = 42;

	// Methods

	// RVA: 0x20C7180 Offset: 0x20C5780 VA: 0x1820C7180
	public static int GetUnusedSmoothingGroup(ProBuilderMesh mesh) { }

	// RVA: 0x20C7100 Offset: 0x20C5700 VA: 0x1820C7100
	private static int GetNextUnusedSmoothingGroup(int start, HashSet<int> used) { }

	// RVA: 0x20C73C0 Offset: 0x20C59C0 VA: 0x1820C73C0
	public static bool IsSmooth(int index) { }

	// RVA: 0x20C6E70 Offset: 0x20C5470 VA: 0x1820C6E70
	public static void ApplySmoothingGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, float angleThreshold) { }

	// RVA: 0x20C6750 Offset: 0x20C4D50 VA: 0x1820C6750
	internal static void ApplySmoothingGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, float angleThreshold, Vector3[] normals) { }

	// RVA: 0x20C6E90 Offset: 0x20C5490 VA: 0x1820C6E90
	private static bool FindSoftEdgesRecursive(Vector3[] normals, WingedEdge wing, float angleThreshold, HashSet<Face> processed) { }

	// RVA: 0x20C73E0 Offset: 0x20C59E0 VA: 0x1820C73E0
	private static bool IsSoftEdge(Vector3[] normals, EdgeLookup left, EdgeLookup right, float threshold) { }
}

// Namespace: UnityEngine.ProBuilder
internal static class Spline // TypeDefIndex: 11662
{
	// Methods

	// RVA: 0x20C7670 Offset: 0x20C5C70 VA: 0x1820C7670
	internal static ProBuilderMesh Extrude(IList<BezierPoint> points, float radius = 0.5, int columns = 32, int rows = 16, bool closeLoop = False, bool smooth = True) { }

	// RVA: 0x20C7580 Offset: 0x20C5B80 VA: 0x1820C7580
	internal static void Extrude(IList<BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref ProBuilderMesh target) { }

	// RVA: 0x20C8040 Offset: 0x20C6640 VA: 0x1820C8040
	internal static List<Vector3> GetControlPoints(IList<BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations) { }

	// RVA: 0x20C7760 Offset: 0x20C5D60 VA: 0x1820C7760
	internal static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref ProBuilderMesh target, IList<Quaternion> pointRotations) { }

	// RVA: 0x20C8430 Offset: 0x20C6A30 VA: 0x1820C8430
	private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant) { }

	// RVA: 0x20C8890 Offset: 0x20C6E90 VA: 0x1820C8890
	private static Vector3[] VertexRing(Quaternion orientation, Vector3 offset, float radius, int segments) { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class Submesh // TypeDefIndex: 11663
{
	// Fields
	[SerializeField]
	internal int[] m_Indexes; // 0x10
	[SerializeField]
	internal MeshTopology m_Topology; // 0x18
	[SerializeField]
	internal int m_SubmeshIndex; // 0x1C

	// Properties
	public IEnumerable<int> indexes { get; set; }
	public MeshTopology topology { get; set; }
	public int submeshIndex { get; set; }

	// Methods

	// RVA: 0x20C9B60 Offset: 0x20C8160 VA: 0x1820C9B60
	public IEnumerable<int> get_indexes() { }

	// RVA: 0x20C9BD0 Offset: 0x20C81D0 VA: 0x1820C9BD0
	public void set_indexes(IEnumerable<int> value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public MeshTopology get_topology() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_topology(MeshTopology value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_submeshIndex() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_submeshIndex(int value) { }

	// RVA: 0x20C9990 Offset: 0x20C7F90 VA: 0x1820C9990
	public void .ctor(int submeshIndex, MeshTopology topology, IEnumerable<int> indexes) { }

	// RVA: 0x20C9A60 Offset: 0x20C8060 VA: 0x1820C9A60
	public void .ctor(Mesh mesh, int subMeshIndex) { }

	// RVA: 0x20C98A0 Offset: 0x20C7EA0 VA: 0x1820C98A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C8C00 Offset: 0x20C7200 VA: 0x1820C8C00
	internal static int GetSubmeshCount(ProBuilderMesh mesh) { }

	// RVA: 0x20C8C60 Offset: 0x20C7260 VA: 0x1820C8C60
	public static Submesh[] GetSubmeshes(IEnumerable<Face> faces, int submeshCount, MeshTopology preferredTopology = 0) { }

	// RVA: 0x20C9740 Offset: 0x20C7D40 VA: 0x1820C9740
	internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh) { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class Transform2D // TypeDefIndex: 11664
{
	// Fields
	public Vector2 position; // 0x10
	public float rotation; // 0x18
	public Vector2 scale; // 0x1C

	// Methods

	// RVA: 0x20C9E30 Offset: 0x20C8430 VA: 0x1820C9E30
	public void .ctor(Vector2 position, float rotation, Vector2 scale) { }

	// RVA: 0x20C9DB0 Offset: 0x20C83B0 VA: 0x1820C9DB0
	public Vector2 TransformPoint(Vector2 p) { }

	// RVA: 0x20C9C30 Offset: 0x20C8230 VA: 0x1820C9C30 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
public static class TransformUtility // TypeDefIndex: 11665
{
	// Fields
	private static Dictionary<Transform, Transform[]> s_ChildStack; // 0x0

	// Methods

	// RVA: 0x20CA5D0 Offset: 0x20C8BD0 VA: 0x1820CA5D0
	internal static void UnparentChildren(Transform t) { }

	// RVA: 0x20CA190 Offset: 0x20C8790 VA: 0x1820CA190
	internal static void ReparentChildren(Transform t) { }

	[Extension]
	// RVA: 0x20CA2C0 Offset: 0x20C88C0 VA: 0x1820CA2C0
	public static Vertex TransformVertex(Transform transform, Vertex vertex) { }

	[Extension]
	// RVA: 0x20C9E90 Offset: 0x20C8490 VA: 0x1820C9E90
	public static Vertex InverseTransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x20CA740 Offset: 0x20C8D40 VA: 0x1820CA740
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal struct Triangle : IEquatable<Triangle> // TypeDefIndex: 11666
{
	// Fields
	[SerializeField]
	private int m_A; // 0x0
	[SerializeField]
	private int m_B; // 0x4
	[SerializeField]
	private int m_C; // 0x8

	// Properties
	public int a { get; }
	public int b { get; }
	public int c { get; }
	public IEnumerable<int> indices { get; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_a() { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_b() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_c() { }

	// RVA: 0x20CAA80 Offset: 0x20C9080 VA: 0x1820CAA80
	public IEnumerable<int> get_indices() { }

	// RVA: 0xB263E0 Offset: 0xB249E0 VA: 0x180B263E0
	public void .ctor(int a, int b, int c) { }

	// RVA: 0x1699F20 Offset: 0x1698520 VA: 0x181699F20 Slot: 4
	public bool Equals(Triangle other) { }

	// RVA: 0x20CA8F0 Offset: 0x20C8EF0 VA: 0x1820CA8F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20CA9A0 Offset: 0x20C8FA0 VA: 0x1820CA9A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CA9C0 Offset: 0x20C8FC0 VA: 0x1820CA9C0
	public bool IsAdjacent(Triangle other) { }

	// RVA: 0x20CA7D0 Offset: 0x20C8DD0 VA: 0x1820CA7D0
	private bool ContainsEdge(Edge edge) { }
}

// Namespace: UnityEngine.ProBuilder
[DisallowMultipleComponent]
internal sealed class TriggerBehaviour : EntityBehaviour // TypeDefIndex: 11667
{
	// Methods

	// RVA: 0x20CAAF0 Offset: 0x20C90F0 VA: 0x1820CAAF0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x20CAC90 Offset: 0x20C9290 VA: 0x1820CAC90 Slot: 5
	public override void OnEnterPlayMode() { }

	// RVA: 0x20CAD00 Offset: 0x20C9300 VA: 0x1820CAD00 Slot: 6
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x20CAD70 Offset: 0x20C9370 VA: 0x1820CAD70
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class UnwrapParameters // TypeDefIndex: 11668
{
	// Fields
	internal const float k_HardAngle = 88;
	internal const float k_PackMargin = 20;
	internal const float k_AngleError = 8;
	internal const float k_AreaError = 15;
	[Tooltip("Angle between neighbor triangles that will generate seam.")]
	[Range(1, 180)]
	[SerializeField]
	[FormerlySerializedAs("hardAngle")]
	private float m_HardAngle; // 0x10
	[Tooltip("Measured in pixels, assuming mesh will cover an entire 1024x1024 lightmap.")]
	[Range(1, 64)]
	[SerializeField]
	[FormerlySerializedAs("packMargin")]
	private float m_PackMargin; // 0x14
	[Tooltip("Measured in percents. Angle error measures deviation of UV angles from geometry angles. Area error measures deviation of UV triangles area from geometry triangles if they were uniformly scaled.")]
	[Range(1, 75)]
	[SerializeField]
	[FormerlySerializedAs("angleError")]
	private float m_AngleError; // 0x18
	[Range(1, 75)]
	[SerializeField]
	[FormerlySerializedAs("areaError")]
	private float m_AreaError; // 0x1C

	// Properties
	public float hardAngle { get; set; }
	public float packMargin { get; set; }
	public float angleError { get; set; }
	public float areaError { get; set; }

	// Methods

	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_hardAngle() { }

	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	public void set_hardAngle(float value) { }

	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_packMargin() { }

	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	public void set_packMargin(float value) { }

	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70
	public float get_angleError() { }

	// RVA: 0x3A4C30 Offset: 0x3A3230 VA: 0x1803A4C30
	public void set_angleError(float value) { }

	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0
	public float get_areaError() { }

	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450
	public void set_areaError(float value) { }

	// RVA: 0x20CB570 Offset: 0x20C9B70 VA: 0x1820CB570
	public void .ctor() { }

	// RVA: 0x20CB4C0 Offset: 0x20C9AC0 VA: 0x1820CB4C0
	public void .ctor(UnwrapParameters other) { }

	// RVA: 0x20CB290 Offset: 0x20C9890 VA: 0x1820CB290
	public void Reset() { }

	// RVA: 0x20CB2B0 Offset: 0x20C98B0 VA: 0x1820CB2B0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class UvUnwrapping // TypeDefIndex: 11671
{
	// Fields
	private static List<Vector2> s_UVTransformProjectionBuffer; // 0x0
	private static Vector2 s_TempVector2; // 0x8
	private static readonly List<int> s_IndexBuffer; // 0x10

	// Methods

	// RVA: 0x20CD910 Offset: 0x20CBF10 VA: 0x1820CD910
	internal static void SetAutoUV(ProBuilderMesh mesh, Face[] faces, bool auto) { }

	// RVA: 0x20CD690 Offset: 0x20CBC90 VA: 0x1820CD690
	internal static void SetAutoAndAlignUnwrapParamsToUVs(ProBuilderMesh mesh, IEnumerable<Face> facesToConvert) { }

	// RVA: 0x20CCAA0 Offset: 0x20CB0A0 VA: 0x1820CCAA0
	internal static AutoUnwrapSettings GetAutoUnwrapSettings(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x20CD070 Offset: 0x20CB670 VA: 0x1820CD070
	internal static UvUnwrapping.UVTransform GetUVTransform(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x20CCCF0 Offset: 0x20CB2F0 VA: 0x1820CCCF0
	private static int GetIndex(IList<int> collection, int index) { }

	// RVA: 0x20CC470 Offset: 0x20CAA70 VA: 0x1820CC470
	internal static UvUnwrapping.UVTransform CalculateDelta(IList<Vector2> src, IList<int> srcIndices, IList<Vector2> dst, IList<int> dstIndices) { }

	// RVA: 0x20CCD50 Offset: 0x20CB350 VA: 0x1820CCD50
	private static Vector2 GetRotatedSize(IList<Vector2> points, IList<int> indices, Vector2 center, float rotation) { }

	// RVA: 0x20CDAC0 Offset: 0x20CC0C0 VA: 0x1820CDAC0
	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x20CC9B0 Offset: 0x20CAFB0 VA: 0x1820CC9B0
	internal static void CopyUVs(ProBuilderMesh mesh, Face source, Face dest) { }

	// RVA: 0x20CD1A0 Offset: 0x20CB7A0 VA: 0x1820CD1A0
	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x20CBA00 Offset: 0x20CA000 VA: 0x1820CBA00
	private static void ApplyUVSettings(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings uvSettings) { }

	// RVA: 0x20CD370 Offset: 0x20CB970 VA: 0x1820CD370
	private static void ScaleUVs(Vector2[] uvs, IList<int> indexes, Vector2 scale, Bounds2D bounds) { }

	// RVA: 0x20CB5C0 Offset: 0x20C9BC0 VA: 0x1820CB5C0
	private static void ApplyUVAnchor(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings.Anchor anchor) { }

	// RVA: 0x20CDC50 Offset: 0x20CC250 VA: 0x1820CDC50
	internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh) { }

	// RVA: 0x20CDE10 Offset: 0x20CC410 VA: 0x1820CDE10
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class VectorHash // TypeDefIndex: 11672
{
	// Fields
	public const float FltCompareResolution = 1000;

	// Methods

	// RVA: 0x20CE520 Offset: 0x20CCB20 VA: 0x1820CE520
	private static int HashFloat(float f) { }

	// RVA: 0x20CE440 Offset: 0x20CCA40 VA: 0x1820CE440
	public static int GetHashCode(Vector2 v) { }

	// RVA: 0x20CE310 Offset: 0x20CC910 VA: 0x1820CE310
	public static int GetHashCode(Vector3 v) { }

	// RVA: 0x20CE180 Offset: 0x20CC780 VA: 0x1820CE180
	public static int GetHashCode(Vector4 v) { }
}

// Namespace: UnityEngine.ProBuilder
internal struct Vector2Mask // TypeDefIndex: 11673
{
	// Fields
	private const byte X = 1;
	private const byte Y = 2;
	public static readonly Vector2Mask XY; // 0x0
	private byte m_Mask; // 0x0

	// Properties
	public float x { get; }
	public float y { get; }

	// Methods

	// RVA: 0x20CDFD0 Offset: 0x20CC5D0 VA: 0x1820CDFD0
	public float get_x() { }

	// RVA: 0x20CDFF0 Offset: 0x20CC5F0 VA: 0x1820CDFF0
	public float get_y() { }

	// RVA: 0x20CDF90 Offset: 0x20CC590 VA: 0x1820CDF90
	public void .ctor(Vector3 v, float epsilon = 1E-45) { }

	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	public void .ctor(byte mask) { }

	// RVA: 0x20CE090 Offset: 0x20CC690 VA: 0x1820CE090
	public static Vector2 op_Implicit(Vector2Mask mask) { }

	// RVA: 0x20CE040 Offset: 0x20CC640 VA: 0x1820CE040
	public static Vector2Mask op_Implicit(Vector2 v) { }

	// RVA: 0x20CE020 Offset: 0x20CC620 VA: 0x1820CE020
	public static Vector2Mask op_BitwiseOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x20CE010 Offset: 0x20CC610 VA: 0x1820CE010
	public static Vector2Mask op_BitwiseAnd(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x20CE030 Offset: 0x20CC630 VA: 0x1820CE030
	public static Vector2Mask op_ExclusiveOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x20CE100 Offset: 0x20CC700 VA: 0x1820CE100
	public static Vector2 op_Multiply(Vector2Mask mask, float value) { }

	// RVA: 0x20CDF50 Offset: 0x20CC550 VA: 0x1820CDF50
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[DefaultMember("Item")]
internal struct Vector3Mask : IEquatable<Vector3Mask> // TypeDefIndex: 11674
{
	// Fields
	private const byte X = 1;
	private const byte Y = 2;
	private const byte Z = 4;
	public static readonly Vector3Mask XYZ; // 0x0
	private byte m_Mask; // 0x0

	// Properties
	public float x { get; }
	public float y { get; }
	public float z { get; }
	public int active { get; }
	public float Item { get; set; }

	// Methods

	// RVA: 0x20CDFD0 Offset: 0x20CC5D0 VA: 0x1820CDFD0
	public float get_x() { }

	// RVA: 0x20CDFF0 Offset: 0x20CC5F0 VA: 0x1820CDFF0
	public float get_y() { }

	// RVA: 0x20DD380 Offset: 0x20DB980 VA: 0x1820DD380
	public float get_z() { }

	// RVA: 0x20DD2A0 Offset: 0x20DB8A0 VA: 0x1820DD2A0
	public void .ctor(Vector3 v, float epsilon = 1E-45) { }

	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	public void .ctor(byte mask) { }

	// RVA: 0x20DD170 Offset: 0x20DB770 VA: 0x1820DD170 Slot: 3
	public override string ToString() { }

	// RVA: 0x20DD360 Offset: 0x20DB960 VA: 0x1820DD360
	public int get_active() { }

	// RVA: 0x20DD420 Offset: 0x20DBA20 VA: 0x1820DD420
	public static Vector3 op_Implicit(Vector3Mask mask) { }

	// RVA: 0x20DD3B0 Offset: 0x20DB9B0 VA: 0x1820DD3B0
	public static Vector3Mask op_Explicit(Vector3 v) { }

	// RVA: 0x20CE020 Offset: 0x20CC620 VA: 0x1820CE020
	public static Vector3Mask op_BitwiseOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x20CE010 Offset: 0x20CC610 VA: 0x1820CE010
	public static Vector3Mask op_BitwiseAnd(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x20CE030 Offset: 0x20CC630 VA: 0x1820CE030
	public static Vector3Mask op_ExclusiveOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x20DD5C0 Offset: 0x20DBBC0 VA: 0x1820DD5C0
	public static Vector3 op_Multiply(Vector3Mask mask, float value) { }

	// RVA: 0x20DD510 Offset: 0x20DBB10 VA: 0x1820DD510
	public static Vector3 op_Multiply(Vector3Mask mask, Vector3 value) { }

	// RVA: 0x20DD660 Offset: 0x20DBC60 VA: 0x1820DD660
	public static Vector3 op_Multiply(Quaternion rotation, Vector3Mask mask) { }

	// RVA: 0x20DD3A0 Offset: 0x20DB9A0 VA: 0x1820DD3A0
	public static bool op_Equality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x20DD4B0 Offset: 0x20DBAB0 VA: 0x1820DD4B0
	public static bool op_Inequality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x20DD2F0 Offset: 0x20DB8F0 VA: 0x1820DD2F0
	public float get_Item(int i) { }

	// RVA: 0x20DD8F0 Offset: 0x20DBEF0 VA: 0x1820DD8F0
	public void set_Item(int i, float value) { }

	// RVA: 0x146F8A0 Offset: 0x146DEA0 VA: 0x18146F8A0 Slot: 4
	public bool Equals(Vector3Mask other) { }

	// RVA: 0x20DD0C0 Offset: 0x20DB6C0 VA: 0x1820DD0C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20DD160 Offset: 0x20DB760 VA: 0x1820DD160 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20DD260 Offset: 0x20DB860 VA: 0x1820DD260
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class Vertex : IEquatable<Vertex> // TypeDefIndex: 11675
{
	// Fields
	[SerializeField]
	private Vector3 m_Position; // 0x10
	[SerializeField]
	private Color m_Color; // 0x1C
	[SerializeField]
	private Vector3 m_Normal; // 0x2C
	[SerializeField]
	private Vector4 m_Tangent; // 0x38
	[SerializeField]
	private Vector2 m_UV0; // 0x48
	[SerializeField]
	private Vector2 m_UV2; // 0x50
	[SerializeField]
	private Vector4 m_UV3; // 0x58
	[SerializeField]
	private Vector4 m_UV4; // 0x68
	[SerializeField]
	private MeshArrays m_Attributes; // 0x78

	// Properties
	public Vector3 position { get; set; }
	public Color color { get; set; }
	public Vector3 normal { get; set; }
	public Vector4 tangent { get; set; }
	public Vector2 uv0 { get; set; }
	public Vector2 uv2 { get; set; }
	public Vector4 uv3 { get; set; }
	public Vector4 uv4 { get; set; }
	internal MeshArrays attributes { get; }
	private bool hasPosition { get; set; }
	private bool hasColor { get; set; }
	private bool hasNormal { get; set; }
	private bool hasTangent { get; set; }
	private bool hasUV0 { get; set; }
	private bool hasUV2 { get; set; }
	private bool hasUV3 { get; set; }
	private bool hasUV4 { get; set; }

	// Methods

	// RVA: 0xEB3820 Offset: 0xEB1E20 VA: 0x180EB3820
	public Vector3 get_position() { }

	// RVA: 0x20E2070 Offset: 0x20E0670 VA: 0x1820E2070
	public void set_position(Vector3 value) { }

	// RVA: 0x20E1D60 Offset: 0x20E0360 VA: 0x1820E1D60
	public Color get_color() { }

	// RVA: 0x20E1E90 Offset: 0x20E0490 VA: 0x1820E1E90
	public void set_color(Color value) { }

	// RVA: 0x3CB4B0 Offset: 0x3C9AB0 VA: 0x1803CB4B0
	public Vector3 get_normal() { }

	// RVA: 0x20E2040 Offset: 0x20E0640 VA: 0x1820E2040
	public void set_normal(Vector3 value) { }

	// RVA: 0x163E080 Offset: 0x163C680 VA: 0x18163E080
	public Vector4 get_tangent() { }

	// RVA: 0x20E20A0 Offset: 0x20E06A0 VA: 0x1820E20A0
	public void set_tangent(Vector4 value) { }

	// RVA: 0x20E1DF0 Offset: 0x20E03F0 VA: 0x1820E1DF0
	public Vector2 get_uv0() { }

	// RVA: 0x20E20D0 Offset: 0x20E06D0 VA: 0x1820E20D0
	public void set_uv0(Vector2 value) { }

	// RVA: 0x20E1E10 Offset: 0x20E0410 VA: 0x1820E1E10
	public Vector2 get_uv2() { }

	// RVA: 0x20E2100 Offset: 0x20E0700 VA: 0x1820E2100
	public void set_uv2(Vector2 value) { }

	// RVA: 0x199B300 Offset: 0x1999900 VA: 0x18199B300
	public Vector4 get_uv3() { }

	// RVA: 0x20E2130 Offset: 0x20E0730 VA: 0x1820E2130
	public void set_uv3(Vector4 value) { }

	// RVA: 0xC9D6A0 Offset: 0xC9BCA0 VA: 0x180C9D6A0
	public Vector4 get_uv4() { }

	// RVA: 0x20E2160 Offset: 0x20E0760 VA: 0x1820E2160
	public void set_uv4(Vector4 value) { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360
	internal MeshArrays get_attributes() { }

	// RVA: 0x20E09B0 Offset: 0x20DEFB0 VA: 0x1820E09B0
	public bool HasArrays(MeshArrays attribute) { }

	// RVA: 0x20E1D90 Offset: 0x20E0390 VA: 0x1820E1D90
	private bool get_hasPosition() { }

	// RVA: 0x20E1F20 Offset: 0x20E0520 VA: 0x1820E1F20
	private void set_hasPosition(bool value) { }

	// RVA: 0x20E1D70 Offset: 0x20E0370 VA: 0x1820E1D70
	private bool get_hasColor() { }

	// RVA: 0x20E1EC0 Offset: 0x20E04C0 VA: 0x1820E1EC0
	private void set_hasColor(bool value) { }

	// RVA: 0x20E1D80 Offset: 0x20E0380 VA: 0x1820E1D80
	private bool get_hasNormal() { }

	// RVA: 0x20E1EF0 Offset: 0x20E04F0 VA: 0x1820E1EF0
	private void set_hasNormal(bool value) { }

	// RVA: 0x20E1DA0 Offset: 0x20E03A0 VA: 0x1820E1DA0
	private bool get_hasTangent() { }

	// RVA: 0x20E1F50 Offset: 0x20E0550 VA: 0x1820E1F50
	private void set_hasTangent(bool value) { }

	// RVA: 0x20E1DB0 Offset: 0x20E03B0 VA: 0x1820E1DB0
	private bool get_hasUV0() { }

	// RVA: 0x20E1F80 Offset: 0x20E0580 VA: 0x1820E1F80
	private void set_hasUV0(bool value) { }

	// RVA: 0x20E1DC0 Offset: 0x20E03C0 VA: 0x1820E1DC0
	private bool get_hasUV2() { }

	// RVA: 0x20E1FB0 Offset: 0x20E05B0 VA: 0x1820E1FB0
	private void set_hasUV2(bool value) { }

	// RVA: 0x20E1DD0 Offset: 0x20E03D0 VA: 0x1820E1DD0
	private bool get_hasUV3() { }

	// RVA: 0x20E1FE0 Offset: 0x20E05E0 VA: 0x1820E1FE0
	private void set_hasUV3(bool value) { }

	// RVA: 0x20E1DE0 Offset: 0x20E03E0 VA: 0x1820E1DE0
	private bool get_hasUV4() { }

	// RVA: 0x20E2010 Offset: 0x20E0610 VA: 0x1820E2010
	private void set_hasUV4(bool value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x20DFEE0 Offset: 0x20DE4E0 VA: 0x1820DFEE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20DFF70 Offset: 0x20DE570 VA: 0x1820DFF70 Slot: 4
	public bool Equals(Vertex other) { }

	// RVA: 0x20DFCE0 Offset: 0x20DE2E0 VA: 0x1820DFCE0
	public bool Equals(Vertex other, MeshArrays mask) { }

	// RVA: 0x20E0920 Offset: 0x20DEF20 VA: 0x1820E0920 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E1BC0 Offset: 0x20E01C0 VA: 0x1820E1BC0
	public void .ctor(Vertex vertex) { }

	// RVA: 0x20E1E30 Offset: 0x20E0430 VA: 0x1820E1E30
	public static bool op_Equality(Vertex a, Vertex b) { }

	// RVA: 0x20E1E50 Offset: 0x20E0450 VA: 0x1820E1E50
	public static bool op_Inequality(Vertex a, Vertex b) { }

	// RVA: 0x20DEE20 Offset: 0x20DD420 VA: 0x1820DEE20
	public static Vertex op_Addition(Vertex a, Vertex b) { }

	// RVA: 0x20DEE20 Offset: 0x20DD420 VA: 0x1820DEE20
	public static Vertex Add(Vertex a, Vertex b) { }

	// RVA: 0x20DEEA0 Offset: 0x20DD4A0 VA: 0x1820DEEA0
	public void Add(Vertex b) { }

	// RVA: 0x20E1840 Offset: 0x20DFE40 VA: 0x1820E1840
	public static Vertex op_Subtraction(Vertex a, Vertex b) { }

	// RVA: 0x20E1840 Offset: 0x20DFE40 VA: 0x1820E1840
	public static Vertex Subtract(Vertex a, Vertex b) { }

	// RVA: 0x20E15B0 Offset: 0x20DFBB0 VA: 0x1820E15B0
	public void Subtract(Vertex b) { }

	// RVA: 0x20E1020 Offset: 0x20DF620 VA: 0x1820E1020
	public static Vertex op_Multiply(Vertex a, float value) { }

	// RVA: 0x20E1020 Offset: 0x20DF620 VA: 0x1820E1020
	public static Vertex Multiply(Vertex a, float value) { }

	// RVA: 0x20E10A0 Offset: 0x20DF6A0 VA: 0x1820E10A0
	public void Multiply(float value) { }

	// RVA: 0x20DFAD0 Offset: 0x20DE0D0 VA: 0x1820DFAD0
	public static Vertex op_Division(Vertex a, float value) { }

	// RVA: 0x20DFAD0 Offset: 0x20DE0D0 VA: 0x1820DFAD0
	public static Vertex Divide(Vertex a, float value) { }

	// RVA: 0x20DFB50 Offset: 0x20DE150 VA: 0x1820DFB50
	public void Divide(float value) { }

	// RVA: 0x20E1230 Offset: 0x20DF830 VA: 0x1820E1230
	public void Normalize() { }

	// RVA: 0x20E18C0 Offset: 0x20DFEC0 VA: 0x1820E18C0
	public string ToString(string args) { }

	// RVA: 0x20E08C0 Offset: 0x20DEEC0 VA: 0x1820E08C0
	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4) { }

	// RVA: 0x20E0140 Offset: 0x20DE740 VA: 0x1820E0140
	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, MeshArrays attributes) { }

	// RVA: 0x20E12F0 Offset: 0x20DF8F0 VA: 0x1820E12F0
	public static void SetMesh(Mesh mesh, IList<Vertex> vertices) { }

	// RVA: 0x20DF130 Offset: 0x20DD730 VA: 0x1820DF130
	public static Vertex Average(IList<Vertex> vertices, IList<int> indexes) { }

	// RVA: 0x20E09C0 Offset: 0x20DEFC0 VA: 0x1820E09C0
	public static Vertex Mix(Vertex x, Vertex y, float weight) { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
public static class VertexPositioning // TypeDefIndex: 11676
{
	// Fields
	private static List<int> s_CoincidentVertices; // 0x0

	// Methods

	[Extension]
	// RVA: 0x20DEBE0 Offset: 0x20DD1E0 VA: 0x1820DEBE0
	public static Vector3[] VerticesInWorldSpace(ProBuilderMesh mesh) { }

	[Extension]
	// RVA: 0x20DDE90 Offset: 0x20DC490 VA: 0x1820DDE90
	public static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset) { }

	[Extension]
	// RVA: 0x20DDFA0 Offset: 0x20DC5A0 VA: 0x1820DDFA0
	internal static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset, float snapValue, bool snapAxisOnly) { }

	[Extension]
	// RVA: 0x20DEAA0 Offset: 0x20DD0A0 VA: 0x1820DEAA0
	public static void TranslateVertices(ProBuilderMesh mesh, IEnumerable<int> indexes, Vector3 offset) { }

	[Extension]
	// RVA: 0x20DE960 Offset: 0x20DCF60 VA: 0x1820DE960
	public static void TranslateVertices(ProBuilderMesh mesh, IEnumerable<Edge> edges, Vector3 offset) { }

	[Extension]
	// RVA: 0x20DE820 Offset: 0x20DCE20 VA: 0x1820DE820
	public static void TranslateVertices(ProBuilderMesh mesh, IEnumerable<Face> faces, Vector3 offset) { }

	// RVA: 0x20DE690 Offset: 0x20DCC90 VA: 0x1820DE690
	private static void TranslateVerticesInternal(ProBuilderMesh mesh, IEnumerable<int> indices, Vector3 offset) { }

	[Extension]
	// RVA: 0x20DD970 Offset: 0x20DBF70 VA: 0x1820DD970
	public static void SetSharedVertexPosition(ProBuilderMesh mesh, int sharedVertexHandle, Vector3 position) { }

	[Extension]
	// RVA: 0x20DDC50 Offset: 0x20DC250 VA: 0x1820DDC50
	internal static void SetSharedVertexValues(ProBuilderMesh mesh, int sharedVertexHandle, Vertex vertex) { }

	// RVA: 0x20DED90 Offset: 0x20DD390 VA: 0x1820DED90
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
public sealed class WingedEdge : IEquatable<WingedEdge> // TypeDefIndex: 11679
{
	// Fields
	private static readonly Dictionary<Edge, WingedEdge> k_OppositeEdgeDictionary; // 0x0
	[CompilerGenerated]
	private EdgeLookup <edge>k__BackingField; // 0x10
	[CompilerGenerated]
	private Face <face>k__BackingField; // 0x20
	[CompilerGenerated]
	private WingedEdge <next>k__BackingField; // 0x28
	[CompilerGenerated]
	private WingedEdge <previous>k__BackingField; // 0x30
	[CompilerGenerated]
	private WingedEdge <opposite>k__BackingField; // 0x38

	// Properties
	public EdgeLookup edge { get; set; }
	public Face face { get; set; }
	public WingedEdge next { get; set; }
	public WingedEdge previous { get; set; }
	public WingedEdge opposite { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public EdgeLookup get_edge() { }

	[CompilerGenerated]
	// RVA: 0x1032A10 Offset: 0x1031010 VA: 0x181032A10
	private void set_edge(EdgeLookup value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Face get_face() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_face(Face value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public WingedEdge get_next() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	private void set_next(WingedEdge value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public WingedEdge get_previous() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_previous(WingedEdge value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public WingedEdge get_opposite() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_opposite(WingedEdge value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x20E22B0 Offset: 0x20E08B0 VA: 0x1820E22B0 Slot: 4
	public bool Equals(WingedEdge other) { }

	// RVA: 0x20E2340 Offset: 0x20E0940 VA: 0x1820E2340 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20E2590 Offset: 0x20E0B90 VA: 0x1820E2590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E2280 Offset: 0x20E0880 VA: 0x1820E2280
	public int Count() { }

	// RVA: 0x20E3C30 Offset: 0x20E2230 VA: 0x1820E3C30 Slot: 3
	public override string ToString() { }

	// RVA: 0x20E31C0 Offset: 0x20E17C0 VA: 0x1820E31C0
	internal static int[] MakeQuad(WingedEdge left, WingedEdge right) { }

	// RVA: 0x20E24A0 Offset: 0x20E0AA0 VA: 0x1820E24A0
	public WingedEdge GetAdjacentEdgeWithCommonIndex(int common) { }

	// RVA: 0x20E3B30 Offset: 0x20E2130 VA: 0x1820E3B30
	public static List<Edge> SortEdgesByAdjacency(Face face) { }

	// RVA: 0x20E39A0 Offset: 0x20E1FA0 VA: 0x1820E39A0
	public static void SortEdgesByAdjacency(List<Edge> edges) { }

	// RVA: 0x20E25F0 Offset: 0x20E0BF0 VA: 0x1820E25F0
	public static Dictionary<int, List<WingedEdge>> GetSpokes(List<WingedEdge> wings) { }

	// RVA: 0x20E3670 Offset: 0x20E1C70 VA: 0x1820E3670
	internal static List<int> SortCommonIndexesByAdjacency(List<WingedEdge> wings, HashSet<int> common) { }

	// RVA: 0x20E30C0 Offset: 0x20E16C0 VA: 0x1820E30C0
	public static List<WingedEdge> GetWingedEdges(ProBuilderMesh mesh, bool oneWingPerFace = False) { }

	// RVA: 0x20E2910 Offset: 0x20E0F10 VA: 0x1820E2910
	public static List<WingedEdge> GetWingedEdges(ProBuilderMesh mesh, IEnumerable<Face> faces, bool oneWingPerFace = False) { }

	// RVA: 0x20E3EA0 Offset: 0x20E24A0 VA: 0x1820E3EA0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
public sealed class WingedEdgeEnumerator : IEnumerator<WingedEdge>, IEnumerator, IDisposable // TypeDefIndex: 11680
{
	// Fields
	private WingedEdge m_Start; // 0x10
	private WingedEdge m_Current; // 0x18

	// Properties
	public WingedEdge Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x157E150 Offset: 0x157C750 VA: 0x18157E150
	public void .ctor(WingedEdge start) { }

	// RVA: 0x20E2190 Offset: 0x20E0790 VA: 0x1820E2190 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1122980 Offset: 0x1120F80 VA: 0x181122980 Slot: 8
	public void Reset() { }

	// RVA: 0x20E2220 Offset: 0x20E0820 VA: 0x1820E2220 Slot: 4
	public WingedEdge get_Current() { }

	// RVA: 0x20E2210 Offset: 0x20E0810 VA: 0x1820E2210 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void Dispose() { }
}

