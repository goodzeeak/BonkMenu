// Namespace: Coffee.UIParticleInternal
[Extension]
internal static class CanvasExtensions // TypeDefIndex: 13531
{
	// Methods

	[Extension]
	// RVA: 0x5546E0 Offset: 0x552CE0 VA: 0x1805546E0
	public static bool ShouldGammaToLinearInShader(Canvas canvas) { }

	[Extension]
	// RVA: 0x5546A0 Offset: 0x552CA0 VA: 0x1805546A0
	public static bool ShouldGammaToLinearInMesh(Canvas canvas) { }

	[Extension]
	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool IsStereoCanvas(Canvas canvas) { }

	[Extension]
	// RVA: 0x553F60 Offset: 0x552560 VA: 0x180553F60
	public static void GetViewProjectionMatrix(Canvas canvas, out Matrix4x4 vpMatrix) { }

	[Extension]
	// RVA: 0x553D50 Offset: 0x552350 VA: 0x180553D50
	public static void GetViewProjectionMatrix(Canvas canvas, Camera.MonoOrStereoscopicEye eye, out Matrix4x4 vpMatrix) { }

	[Extension]
	// RVA: 0x553F30 Offset: 0x552530 VA: 0x180553F30
	public static void GetViewProjectionMatrix(Canvas canvas, out Matrix4x4 vMatrix, out Matrix4x4 pMatrix) { }

	[Extension]
	// RVA: 0x554130 Offset: 0x552730 VA: 0x180554130
	public static void GetViewProjectionMatrix(Canvas canvas, Camera.MonoOrStereoscopicEye eye, out Matrix4x4 vMatrix, out Matrix4x4 pMatrix) { }
}

// Namespace: Coffee.UIParticleInternal
[Extension]
internal static class Color32Extensions // TypeDefIndex: 13532
{
	// Fields
	private static readonly List<Color32> s_Colors; // 0x0
	private static byte[] s_LinearToGammaLut; // 0x8
	private static byte[] s_GammaToLinearLut; // 0x10

	// Methods

	[Extension]
	// RVA: 0x554A60 Offset: 0x553060 VA: 0x180554A60
	public static byte LinearToGamma(byte self) { }

	[Extension]
	// RVA: 0x554720 Offset: 0x552D20 VA: 0x180554720
	public static byte GammaToLinear(byte self) { }

	[Extension]
	// RVA: 0x554C00 Offset: 0x553200 VA: 0x180554C00
	public static void LinearToGamma(Mesh self) { }

	[Extension]
	// RVA: 0x5548C0 Offset: 0x552EC0 VA: 0x1805548C0
	public static void GammaToLinear(Mesh self) { }

	// RVA: 0x554DA0 Offset: 0x5533A0 VA: 0x180554DA0
	private static void .cctor() { }
}

// Namespace: Coffee.UIParticleInternal
[Extension]
internal static class ComponentExtensions // TypeDefIndex: 13533
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] GetComponentsInChildren<T>(Component self, int depth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B94B0 Offset: 0x6B7AB0 VA: 0x1806B94B0
	|-ComponentExtensions.GetComponentsInChildren<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void GetComponentsInChildren<T>(Component self, List<T> results, int depth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9420 Offset: 0x6B7A20 VA: 0x1806B9420
	|-ComponentExtensions.GetComponentsInChildren<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	private static void GetComponentsInChildren_Internal<T>(Component self, List<T> results, int depth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B92C0 Offset: 0x6B78C0 VA: 0x1806B92C0
	|-ComponentExtensions.GetComponentsInChildren_Internal<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9570 Offset: 0x6B7B70 VA: 0x1806B9570
	|-ComponentExtensions.GetOrAddComponent<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetRootComponent<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9680 Offset: 0x6B7C80 VA: 0x1806B9680
	|-ComponentExtensions.GetRootComponent<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetComponentInParent<T>(Component self, bool includeSelf, Transform stopAfter, Predicate<T> valid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9140 Offset: 0x6B7740 VA: 0x1806B9140
	|-ComponentExtensions.GetComponentInParent<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddComponentOnChildren<T>(Component self, HideFlags hideFlags, bool includeSelf) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B8F50 Offset: 0x6B7550 VA: 0x1806B8F50
	|-ComponentExtensions.AddComponentOnChildren<object>
	*/
}

// Namespace: Coffee.UIParticleInternal
internal static class Misc // TypeDefIndex: 13534
{
	// Methods

	// RVA: 0x555A60 Offset: 0x554060 VA: 0x180555A60
	public static void Destroy(Object obj) { }

	// RVA: 0x5559E0 Offset: 0x553FE0 VA: 0x1805559E0
	public static void DestroyImmediate(Object obj) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void SetDirty(Object obj) { }
}

// Namespace: Coffee.UIParticleInternal
[Extension]
internal static class SpriteExtensions // TypeDefIndex: 13535
{
	// Methods

	[Extension]
	// RVA: 0x556730 Offset: 0x554D30 VA: 0x180556730
	internal static Texture2D GetActualTexture(Sprite self) { }
}

// Namespace: Coffee.UIParticleInternal
[Extension]
internal static class Vector3Extensions // TypeDefIndex: 13536
{
	// Methods

	[Extension]
	// RVA: 0x5618A0 Offset: 0x55FEA0 VA: 0x1805618A0
	public static Vector3 Inverse(Vector3 self) { }

	[Extension]
	// RVA: 0x5617D0 Offset: 0x55FDD0 VA: 0x1805617D0
	public static Vector3 GetScaled(Vector3 self, Vector3 other1) { }

	[Extension]
	// RVA: 0x561830 Offset: 0x55FE30 VA: 0x180561830
	public static Vector3 GetScaled(Vector3 self, Vector3 other1, Vector3 other2) { }

	[Extension]
	// RVA: 0x561740 Offset: 0x55FD40 VA: 0x180561740
	public static Vector3 GetScaled(Vector3 self, Vector3 other1, Vector3 other2, Vector3 other3) { }

	[Extension]
	// RVA: 0x561960 Offset: 0x55FF60 VA: 0x180561960
	public static bool IsVisible(Vector3 self) { }

	[Extension]
	// RVA: 0x561940 Offset: 0x55FF40 VA: 0x180561940
	public static bool IsVisible2D(Vector3 self) { }
}

// Namespace: Coffee.UIParticleInternal
public abstract class PreloadedProjectSettings : ScriptableObject // TypeDefIndex: 13537
{
	// Methods

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: Coffee.UIParticleInternal
public abstract class PreloadedProjectSettings<T> : PreloadedProjectSettings // TypeDefIndex: 13538
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static T instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4AC0 Offset: 0x12F30C0 VA: 0x1812F4AC0
	|-PreloadedProjectSettings<object>.get_instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4970 Offset: 0x12F2F70 VA: 0x1812F4970
	|-PreloadedProjectSettings<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F48B0 Offset: 0x12F2EB0 VA: 0x1812F48B0
	|-PreloadedProjectSettings<object>.OnDisable
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	|-PreloadedProjectSettings<object>..ctor
	*/
}

// Namespace: Coffee.UIParticleInternal
internal class FastActionBase<T> // TypeDefIndex: 13540
{
	// Fields
	private static readonly ObjectPool<LinkedListNode<T>> s_NodePool; // 0x0
	private readonly LinkedList<T> _delegates; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1000100 Offset: 0xFFE700 VA: 0x181000100
	|-FastActionBase<object>.Add
	|
	|-RVA: 0x10001F0 Offset: 0xFFE7F0 VA: 0x1810001F0
	|-FastActionBase<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10006F0 Offset: 0xFFECF0 VA: 0x1810006F0
	|-FastActionBase<object>.Remove
	|
	|-RVA: 0x10007F0 Offset: 0xFFEDF0 VA: 0x1810007F0
	|-FastActionBase<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	protected void Invoke(Action<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1000610 Offset: 0xFFEC10 VA: 0x181000610
	|-FastActionBase<object>.Invoke
	|
	|-RVA: 0x1000440 Offset: 0xFFEA40 VA: 0x181000440
	|-FastActionBase<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1000410 Offset: 0xFFEA10 VA: 0x181000410
	|-FastActionBase<object>.Clear
	|
	|-RVA: 0x10003E0 Offset: 0xFFE9E0 VA: 0x1810003E0
	|-FastActionBase<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001230 Offset: 0xFFF830 VA: 0x181001230
	|-FastActionBase<object>..ctor
	|
	|-RVA: 0x10012C0 Offset: 0xFFF8C0 VA: 0x1810012C0
	|-FastActionBase<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1000E50 Offset: 0xFFF450 VA: 0x181000E50
	|-FastActionBase<object>..cctor
	|
	|-RVA: 0x10009D0 Offset: 0xFFEFD0 VA: 0x1810009D0
	|-FastActionBase<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Coffee.UIParticleInternal
internal class FastAction : FastActionBase<Action> // TypeDefIndex: 13542
{
	// Methods

	// RVA: 0x554E30 Offset: 0x553430 VA: 0x180554E30
	public void Invoke() { }

	// RVA: 0x554F50 Offset: 0x553550 VA: 0x180554F50
	public void .ctor() { }
}

// Namespace: Coffee.UIParticleInternal
internal static class FrameCache // TypeDefIndex: 13545
{
	// Fields
	private static readonly Dictionary<Type, FrameCache.IFrameCache> s_Caches; // 0x0

	// Methods

	// RVA: 0x555190 Offset: 0x553790 VA: 0x180555190
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static bool TryGet<T>(object key1, string key2, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x702A50 Offset: 0x701050 VA: 0x180702A50
	|-FrameCache.TryGet<Matrix4x4>
	|
	|-RVA: 0x702820 Offset: 0x700E20 VA: 0x180702820
	|-FrameCache.TryGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGet<T>(object key1, string key2, int key3, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x702930 Offset: 0x700F30 VA: 0x180702930
	|-FrameCache.TryGet<Matrix4x4>
	|
	|-RVA: 0x702700 Offset: 0x700D00 VA: 0x180702700
	|-FrameCache.TryGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Set<T>(object key1, string key2, T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x702470 Offset: 0x700A70 VA: 0x180702470
	|-FrameCache.Set<Matrix4x4>
	|
	|-RVA: 0x702110 Offset: 0x700710 VA: 0x180702110
	|-FrameCache.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Set<T>(object key1, string key2, int key3, T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7025B0 Offset: 0x700BB0 VA: 0x1807025B0
	|-FrameCache.Set<Matrix4x4>
	|
	|-RVA: 0x7022C0 Offset: 0x7008C0 VA: 0x1807022C0
	|-FrameCache.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x554FB0 Offset: 0x5535B0 VA: 0x180554FB0
	private static void ClearAllCache() { }

	// RVA: -1 Offset: -1
	private static FrameCache.FrameCacheContainer<T> GetFrameCache<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x701EF0 Offset: 0x7004F0 VA: 0x180701EF0
	|-FrameCache.GetFrameCache<Matrix4x4>
	|
	|-RVA: 0x701CD0 Offset: 0x7002D0 VA: 0x180701CD0
	|-FrameCache.GetFrameCache<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Coffee.UIParticleInternal
internal static class Logging // TypeDefIndex: 13546
{
	// Fields
	private const string k_DisableSymbol = "DISABLE_COFFEE_LOGGER";

	// Methods

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void Log_Internal(LogType type, object tag, object message, Object context) { }

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void LogIf(bool enable, object tag, object message, Object context) { }

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Log(object tag, object message, Object context) { }

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void LogWarning(object tag, object message, Object context) { }

	// RVA: 0x555310 Offset: 0x553910 VA: 0x180555310
	public static void LogError(object tag, object message, Object context) { }

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void LogMulticast(Type type, string fieldName, object instance, string message) { }

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void AppendTag(StringBuilder sb, object tag) { }

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void AppendType(StringBuilder sb, Type type) { }

	[Conditional("DISABLE_COFFEE_LOGGER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void AppendReadableCode(StringBuilder sb, object tag) { }
}

// Namespace: Coffee.UIParticleInternal
internal static class MaterialRepository // TypeDefIndex: 13548
{
	// Fields
	private static readonly ObjectRepository<Material> s_Repository; // 0x0

	// Properties
	public static int count { get; }

	// Methods

	// RVA: 0x555970 Offset: 0x553F70 VA: 0x180555970
	public static int get_count() { }

	// RVA: 0x555840 Offset: 0x553E40 VA: 0x180555840
	public static bool Valid(Hash128 hash, Material material) { }

	// RVA: 0x555710 Offset: 0x553D10 VA: 0x180555710
	public static void Get(Hash128 hash, ref Material material, Func<Material> onCreate) { }

	// RVA: 0x555580 Offset: 0x553B80 VA: 0x180555580
	public static void Get(Hash128 hash, ref Material material, string shaderName) { }

	// RVA: 0x5553A0 Offset: 0x5539A0 VA: 0x1805553A0
	public static void Get(Hash128 hash, ref Material material, string shaderName, string[] keywords) { }

	// RVA: -1 Offset: -1
	public static void Get<T>(Hash128 hash, ref Material material, Func<T, Material> onCreate, T source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72EA20 Offset: 0x72D020 VA: 0x18072EA20
	|-MaterialRepository.Get<ValueTuple<object, object>>
	|
	|-RVA: 0x72E8D0 Offset: 0x72CED0 VA: 0x18072E8D0
	|-MaterialRepository.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x5557C0 Offset: 0x553DC0 VA: 0x1805557C0
	public static void Release(ref Material material) { }

	// RVA: 0x5558E0 Offset: 0x553EE0 VA: 0x1805558E0
	private static void .cctor() { }
}

// Namespace: Coffee.UIParticleInternal
internal class ObjectPool<T> // TypeDefIndex: 13549
{
	// Fields
	private readonly Func<T> _onCreate; // 0x0
	private readonly Action<T> _onReturn; // 0x0
	private readonly Predicate<T> _onValid; // 0x0
	private readonly Stack<T> _pool; // 0x0
	private int _count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> onCreate, Predicate<T> onValid, Action<T> onReturn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEBF0 Offset: 0x12DD1F0 VA: 0x1812DEBF0
	|-ObjectPool<object>..ctor
	|
	|-RVA: 0x12DF160 Offset: 0x12DD760 VA: 0x1812DF160
	|-ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE520 Offset: 0x12DCB20 VA: 0x1812DE520
	|-ObjectPool<object>.Rent
	|
	|-RVA: 0x12DE5C0 Offset: 0x12DCBC0 VA: 0x1812DE5C0
	|-ObjectPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1
	public void Return(ref T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEB50 Offset: 0x12DD150 VA: 0x1812DEB50
	|-ObjectPool<object>.Return
	|
	|-RVA: 0x12DE7D0 Offset: 0x12DCDD0 VA: 0x1812DE7D0
	|-ObjectPool<__Il2CppFullySharedGenericType>.Return
	*/
}

// Namespace: Coffee.UIParticleInternal
internal static class ListPool<T> // TypeDefIndex: 13551
{
	// Fields
	private static readonly ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1121420 Offset: 0x111FA20 VA: 0x181121420
	|-ListPool<object>.Rent
	|
	|-RVA: 0x9C39E0 Offset: 0x9C1FE0 VA: 0x1809C39E0
	|-ListPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1
	public static void Return(ref List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1121600 Offset: 0x111FC00 VA: 0x181121600
	|-ListPool<object>.Return
	|
	|-RVA: 0x11214F0 Offset: 0x111FAF0 VA: 0x1811214F0
	|-ListPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11216E0 Offset: 0x111FCE0 VA: 0x1811216E0
	|-ListPool<object>..cctor
	|
	|-RVA: 0x1121AA0 Offset: 0x11200A0 VA: 0x181121AA0
	|-ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Coffee.UIParticleInternal
internal class ObjectRepository<T> // TypeDefIndex: 13554
{
	// Fields
	private readonly Dictionary<Hash128, ObjectRepository.Entry<T>> _cache; // 0x0
	private readonly Dictionary<int, Hash128> _objectKey; // 0x0
	private readonly string _name; // 0x0
	private readonly Action<T> _onRelease; // 0x0
	private readonly Stack<ObjectRepository.Entry<T>> _pool; // 0x0

	// Properties
	public int count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<T> onRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0780 Offset: 0x12DED80 VA: 0x1812E0780
	|-ObjectRepository<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0B50 Offset: 0x12DF150 VA: 0x1812E0B50
	|-ObjectRepository<object>.get_count
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DFDD0 Offset: 0x12DE3D0 VA: 0x1812DFDD0
	|-ObjectRepository<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Valid(Hash128 hash, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E06B0 Offset: 0x12DECB0 VA: 0x1812E06B0
	|-ObjectRepository<object>.Valid
	*/

	// RVA: -1 Offset: -1
	public void Get(Hash128 hash, ref T obj, Func<T> onCreate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0160 Offset: 0x12DE760 VA: 0x1812E0160
	|-ObjectRepository<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Get<TS>(Hash128 hash, ref T obj, Func<TS, T> onCreate, TS source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6071A0 Offset: 0x6057A0 VA: 0x1806071A0
	|-ObjectRepository<object>.Get<ValueTuple<object, object>>
	|
	|-RVA: 0x6070C0 Offset: 0x6056C0 VA: 0x1806070C0
	|-ObjectRepository<object>.Get<object>
	|
	|-RVA: 0x606F50 Offset: 0x605550 VA: 0x180606F50
	|-ObjectRepository<object>.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private bool GetFromCache(Hash128 hash, ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DFFD0 Offset: 0x12DE5D0 VA: 0x1812DFFD0
	|-ObjectRepository<object>.GetFromCache
	*/

	// RVA: -1 Offset: -1
	private void Add(Hash128 hash, ref T obj, T newObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DFBD0 Offset: 0x12DE1D0 VA: 0x1812DFBD0
	|-ObjectRepository<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Release(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0380 Offset: 0x12DE980 VA: 0x1812E0380
	|-ObjectRepository<object>.Release
	*/

	// RVA: -1 Offset: -1
	private void Remove(ObjectRepository.Entry<T> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E05B0 Offset: 0x12DEBB0 VA: 0x1812E05B0
	|-ObjectRepository<object>.Remove
	*/
}

// Namespace: Coffee.UIParticleInternal
internal static class UIExtraCallbacks // TypeDefIndex: 13555
{
	// Fields
	private static bool s_IsInitializedAfterCanvasRebuild; // 0x0
	private static readonly FastAction s_AfterCanvasRebuildAction; // 0x8
	private static readonly FastAction s_LateAfterCanvasRebuildAction; // 0x10
	private static readonly FastAction s_BeforeCanvasRebuildAction; // 0x18

	// Methods

	// RVA: 0x5574E0 Offset: 0x555AE0 VA: 0x1805574E0
	private static void .cctor() { }

	// RVA: 0x5577F0 Offset: 0x555DF0 VA: 0x1805577F0
	public static void add_onLateAfterCanvasRebuild(Action value) { }

	// RVA: 0x557970 Offset: 0x555F70 VA: 0x180557970
	public static void remove_onLateAfterCanvasRebuild(Action value) { }

	// RVA: 0x557770 Offset: 0x555D70 VA: 0x180557770
	public static void add_onBeforeCanvasRebuild(Action value) { }

	// RVA: 0x5578F0 Offset: 0x555EF0 VA: 0x1805578F0
	public static void remove_onBeforeCanvasRebuild(Action value) { }

	// RVA: 0x5576F0 Offset: 0x555CF0 VA: 0x1805576F0
	public static void add_onAfterCanvasRebuild(Action value) { }

	// RVA: 0x557870 Offset: 0x555E70 VA: 0x180557870
	public static void remove_onAfterCanvasRebuild(Action value) { }

	// RVA: 0x557170 Offset: 0x555770 VA: 0x180557170
	private static void InitializeAfterCanvasRebuild() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x557260 Offset: 0x555860 VA: 0x180557260
	private static void InitializeOnLoad() { }

	// RVA: 0x557390 Offset: 0x555990 VA: 0x180557390
	private static void OnBeforeCanvasRebuild() { }

	// RVA: 0x557310 Offset: 0x555910 VA: 0x180557310
	private static void OnAfterCanvasRebuild() { }
}

// Namespace: Coffee.UIParticleInternal
[Extension]
internal static class ParticleSystemExtensions // TypeDefIndex: 13557
{
	// Fields
	private static ParticleSystem.Particle[] s_TmpParticles; // 0x0

	// Methods

	// RVA: 0x555F40 Offset: 0x554540 VA: 0x180555F40
	public static ParticleSystem.Particle[] GetParticleArray(int size) { }

	[Extension]
	// RVA: 0x5564B0 Offset: 0x554AB0 VA: 0x1805564B0
	public static void ValidateShape(ParticleSystem self) { }

	[Extension]
	// RVA: 0x555AE0 Offset: 0x5540E0 VA: 0x180555AE0
	public static bool CanBakeMesh(ParticleSystemRenderer self) { }

	[Extension]
	// RVA: 0x555CE0 Offset: 0x5542E0 VA: 0x180555CE0
	public static ParticleSystemSimulationSpace GetActualSimulationSpace(ParticleSystem self) { }

	[Extension]
	// RVA: 0x556210 Offset: 0x554810 VA: 0x180556210
	public static bool IsLocalSpace(ParticleSystem self) { }

	[Extension]
	// RVA: 0x5562E0 Offset: 0x5548E0 VA: 0x1805562E0
	public static bool IsWorldSpace(ParticleSystem self) { }

	[Extension]
	// RVA: 0x5563B0 Offset: 0x5549B0 VA: 0x1805563B0
	public static void SortForRendering(List<ParticleSystem> self, Transform transform, bool sortByMaterial) { }

	// RVA: 0x555D80 Offset: 0x554380 VA: 0x180555D80
	private static int GetIndex(IList<ParticleSystem> list, Object ps) { }

	[Extension]
	// RVA: 0x556090 Offset: 0x554690 VA: 0x180556090
	public static Texture2D GetTextureForSprite(ParticleSystem self) { }

	[Extension]
	// RVA: 0x555B80 Offset: 0x554180 VA: 0x180555B80
	public static void Exec(List<ParticleSystem> self, Action<ParticleSystem> action) { }

	// RVA: 0x5566C0 Offset: 0x554CC0 VA: 0x1805566C0
	private static void .cctor() { }
}

