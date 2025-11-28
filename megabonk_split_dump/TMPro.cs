// Namespace: TMPro
public class FastAction // TypeDefIndex: 11353
{
	// Fields
	private LinkedList<Action> delegates; // 0x10
	private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18

	// Methods

	// RVA: 0x2171900 Offset: 0x216FF00 VA: 0x182171900
	public void Add(Action rhs) { }

	// RVA: 0x2171A50 Offset: 0x2170050 VA: 0x182171A50
	public void Remove(Action rhs) { }

	// RVA: 0x21719C0 Offset: 0x216FFC0 VA: 0x1821719C0
	public void Call() { }

	// RVA: 0x2171B10 Offset: 0x2170110 VA: 0x182171B10
	public void .ctor() { }
}

// Namespace: TMPro
public class FastAction<A> // TypeDefIndex: 11354
{
	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001350 Offset: 0xFFF950 VA: 0x181001350
	|-FastAction<bool>.Add
	|-FastAction<object>.Add
	|
	|-RVA: 0x10013F0 Offset: 0xFFF9F0 VA: 0x1810013F0
	|-FastAction<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001850 Offset: 0xFFFE50 VA: 0x181001850
	|-FastAction<bool>.Remove
	|-FastAction<object>.Remove
	|
	|-RVA: 0x1001770 Offset: 0xFFFD70 VA: 0x181001770
	|-FastAction<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001670 Offset: 0xFFFC70 VA: 0x181001670
	|-FastAction<bool>.Call
	|
	|-RVA: 0x10016F0 Offset: 0xFFFCF0 VA: 0x1810016F0
	|-FastAction<object>.Call
	|
	|-RVA: 0x10014D0 Offset: 0xFFFAD0 VA: 0x1810014D0
	|-FastAction<__Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10018F0 Offset: 0xFFFEF0 VA: 0x1810018F0
	|-FastAction<bool>..ctor
	|-FastAction<object>..ctor
	|
	|-RVA: 0x10019D0 Offset: 0xFFFFD0 VA: 0x1810019D0
	|-FastAction<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
public class FastAction<A, B> // TypeDefIndex: 11355
{
	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001350 Offset: 0xFFF950 VA: 0x181001350
	|-FastAction<bool, object>.Add
	|-FastAction<object, object>.Add
	|
	|-RVA: 0x10013F0 Offset: 0xFFF9F0 VA: 0x1810013F0
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001850 Offset: 0xFFFE50 VA: 0x181001850
	|-FastAction<bool, object>.Remove
	|-FastAction<object, object>.Remove
	|
	|-RVA: 0x1001770 Offset: 0xFFFD70 VA: 0x181001770
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001D80 Offset: 0x1000380 VA: 0x181001D80
	|-FastAction<bool, object>.Call
	|
	|-RVA: 0x1001CF0 Offset: 0x10002F0 VA: 0x181001CF0
	|-FastAction<object, object>.Call
	|
	|-RVA: 0x1001AB0 Offset: 0x10000B0 VA: 0x181001AB0
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001E10 Offset: 0x1000410 VA: 0x181001E10
	|-FastAction<bool, object>..ctor
	|-FastAction<object, object>..ctor
	|
	|-RVA: 0x1001EF0 Offset: 0x10004F0 VA: 0x181001EF0
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
public class FastAction<A, B, C> // TypeDefIndex: 11356
{
	// Fields
	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001350 Offset: 0xFFF950 VA: 0x181001350
	|-FastAction<object, object, object>.Add
	|
	|-RVA: 0x10013F0 Offset: 0xFFF9F0 VA: 0x1810013F0
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001850 Offset: 0xFFFE50 VA: 0x181001850
	|-FastAction<object, object, object>.Remove
	|
	|-RVA: 0x1001770 Offset: 0xFFFD70 VA: 0x181001770
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10022D0 Offset: 0x10008D0 VA: 0x1810022D0
	|-FastAction<object, object, object>.Call
	|
	|-RVA: 0x1001FD0 Offset: 0x10005D0 VA: 0x181001FD0
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1002460 Offset: 0x1000A60 VA: 0x181002460
	|-FastAction<object, object, object>..ctor
	|
	|-RVA: 0x1002380 Offset: 0x1000980 VA: 0x181002380
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
[Serializable]
public struct GlyphAnchorPoint // TypeDefIndex: 11357
{
	// Fields
	[SerializeField]
	private float m_XCoordinate; // 0x0
	[SerializeField]
	private float m_YCoordinate; // 0x4

	// Properties
	public float xCoordinate { get; set; }
	public float yCoordinate { get; set; }

	// Methods

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_xCoordinate() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_xCoordinate(float value) { }

	// RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	public float get_yCoordinate() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_yCoordinate(float value) { }
}

// Namespace: TMPro
[Serializable]
public struct MarkPositionAdjustment // TypeDefIndex: 11358
{
	// Fields
	[SerializeField]
	private float m_XPositionAdjustment; // 0x0
	[SerializeField]
	private float m_YPositionAdjustment; // 0x4

	// Properties
	public float xPositionAdjustment { get; set; }
	public float yPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_xPositionAdjustment() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_xPositionAdjustment(float value) { }

	// RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	public float get_yPositionAdjustment() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_yPositionAdjustment(float value) { }

	// RVA: 0xB1E9A0 Offset: 0xB1CFA0 VA: 0x180B1E9A0
	public void .ctor(float x, float y) { }
}

// Namespace: TMPro
[Serializable]
public struct MarkToBaseAdjustmentRecord // TypeDefIndex: 11359
{
	// Fields
	[SerializeField]
	private uint m_BaseGlyphID; // 0x0
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x4
	[SerializeField]
	private uint m_MarkGlyphID; // 0xC
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x10

	// Properties
	public uint baseGlyphID { get; set; }
	public GlyphAnchorPoint baseGlyphAnchorPoint { get; set; }
	public uint markGlyphID { get; set; }
	public MarkPositionAdjustment markPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public uint get_baseGlyphID() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_baseGlyphID(uint value) { }

	// RVA: 0x3A4A80 Offset: 0x3A3080 VA: 0x1803A4A80
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x3A4C40 Offset: 0x3A3240 VA: 0x1803A4C40
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public uint get_markGlyphID() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_markGlyphID(uint value) { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: TMPro
[Serializable]
public struct MarkToMarkAdjustmentRecord // TypeDefIndex: 11360
{
	// Fields
	[SerializeField]
	private uint m_BaseMarkGlyphID; // 0x0
	[SerializeField]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x4
	[SerializeField]
	private uint m_CombiningMarkGlyphID; // 0xC
	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x10

	// Properties
	public uint baseMarkGlyphID { get; set; }
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; set; }
	public uint combiningMarkGlyphID { get; set; }
	public MarkPositionAdjustment combiningMarkPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public uint get_baseMarkGlyphID() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_baseMarkGlyphID(uint value) { }

	// RVA: 0x3A4A80 Offset: 0x3A3080 VA: 0x1803A4A80
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x3A4C40 Offset: 0x3A3240 VA: 0x1803A4C40
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public uint get_combiningMarkGlyphID() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_combiningMarkGlyphID(uint value) { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: TMPro
[Serializable]
public struct SingleSubstitutionRecord // TypeDefIndex: 11361
{}

// Namespace: TMPro
[Serializable]
public struct MultipleSubstitutionRecord // TypeDefIndex: 11362
{
	// Fields
	[SerializeField]
	private uint m_TargetGlyphID; // 0x0
	[SerializeField]
	private uint[] m_SubstituteGlyphIDs; // 0x8

	// Properties
	public uint targetGlyphID { get; set; }
	public uint[] substituteGlyphIDs { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public uint get_targetGlyphID() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_targetGlyphID(uint value) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public uint[] get_substituteGlyphIDs() { }

	// RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	public void set_substituteGlyphIDs(uint[] value) { }
}

// Namespace: TMPro
[Serializable]
public struct AlternateSubstitutionRecord // TypeDefIndex: 11363
{}

// Namespace: TMPro
[Serializable]
public struct LigatureSubstitutionRecord // TypeDefIndex: 11364
{
	// Fields
	[SerializeField]
	private uint[] m_ComponentGlyphIDs; // 0x0
	[SerializeField]
	private uint m_LigatureGlyphID; // 0x8

	// Properties
	public uint[] componentGlyphIDs { get; set; }
	public uint ligatureGlyphID { get; set; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public uint[] get_componentGlyphIDs() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void set_componentGlyphIDs(uint[] value) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public uint get_ligatureGlyphID() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_ligatureGlyphID(uint value) { }

	// RVA: 0x2171BD0 Offset: 0x21701D0 VA: 0x182171BD0
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	// RVA: 0x2171C50 Offset: 0x2170250 VA: 0x182171C50
	public static bool op_Inequality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }
}

// Namespace: TMPro
public interface ITextPreprocessor // TypeDefIndex: 11365
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string PreprocessText(string text);
}

// Namespace: TMPro
public class MaterialReferenceManager // TypeDefIndex: 11366
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x2172AC0 Offset: 0x21710C0 VA: 0x182172AC0
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x2171F10 Offset: 0x2170510 VA: 0x182171F10
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x2171E20 Offset: 0x2170420 VA: 0x182171E20
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0x21722B0 Offset: 0x21708B0 VA: 0x1821722B0
	public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x21720F0 Offset: 0x21706F0 VA: 0x1821720F0
	private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x21723B0 Offset: 0x21709B0 VA: 0x1821723B0
	public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x21721E0 Offset: 0x21707E0 VA: 0x1821721E0
	private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x2172080 Offset: 0x2170680 VA: 0x182172080
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x2172010 Offset: 0x2170610 VA: 0x182172010
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x2171D80 Offset: 0x2170380 VA: 0x182171D80
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x2171CF0 Offset: 0x21702F0 VA: 0x182171CF0
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x2172490 Offset: 0x2170A90 VA: 0x182172490
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0x2172500 Offset: 0x2170B00 VA: 0x182172500
	public bool Contains(TMP_SpriteAsset sprite) { }

	// RVA: 0x21726F0 Offset: 0x2170CF0 VA: 0x1821726F0
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x2172670 Offset: 0x2170C70 VA: 0x182172670
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x21728F0 Offset: 0x2170EF0 VA: 0x1821728F0
	public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x2172870 Offset: 0x2170E70 VA: 0x182172870
	private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x21725F0 Offset: 0x2170BF0 VA: 0x1821725F0
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x2172570 Offset: 0x2170B70 VA: 0x182172570
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x21727F0 Offset: 0x2170DF0 VA: 0x1821727F0
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x2172770 Offset: 0x2170D70 VA: 0x182172770
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x2172970 Offset: 0x2170F70 VA: 0x182172970
	public void .ctor() { }
}

// Namespace: TMPro
public struct TMP_MaterialReference // TypeDefIndex: 11367
{
	// Fields
	public Material material; // 0x0
	public int referenceCount; // 0x8
}

// Namespace: TMPro
public struct MaterialReference // TypeDefIndex: 11368
{
	// Fields
	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public TMP_SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x2173250 Offset: 0x2171850 VA: 0x182173250
	public void .ctor(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x2173170 Offset: 0x2171770 VA: 0x182173170
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0x2172EF0 Offset: 0x21714F0 VA: 0x182172EF0
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x2172C90 Offset: 0x2171290 VA: 0x182172C90
	public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

// Namespace: TMPro
public enum TextContainerAnchors // TypeDefIndex: 11369
{
	// Fields
	public int value__; // 0x0
	public const TextContainerAnchors TopLeft = 0;
	public const TextContainerAnchors Top = 1;
	public const TextContainerAnchors TopRight = 2;
	public const TextContainerAnchors Left = 3;
	public const TextContainerAnchors Middle = 4;
	public const TextContainerAnchors Right = 5;
	public const TextContainerAnchors BottomLeft = 6;
	public const TextContainerAnchors Bottom = 7;
	public const TextContainerAnchors BottomRight = 8;
	public const TextContainerAnchors Custom = 9;
}

// Namespace: TMPro
[RequireComponent(typeof(RectTransform))]
public class TextContainer : UIBehaviour // TypeDefIndex: 11370
{
	// Fields
	private bool m_hasChanged; // 0x20
	[SerializeField]
	private Vector2 m_pivot; // 0x24
	[SerializeField]
	private TextContainerAnchors m_anchorPosition; // 0x2C
	[SerializeField]
	private Rect m_rect; // 0x30
	private bool m_isDefaultWidth; // 0x40
	private bool m_isDefaultHeight; // 0x41
	private bool m_isAutoFitting; // 0x42
	private Vector3[] m_corners; // 0x48
	private Vector3[] m_worldCorners; // 0x50
	[SerializeField]
	private Vector4 m_margins; // 0x58
	private RectTransform m_rectTransform; // 0x68
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x70

	// Properties
	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_hasChanged() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_hasChanged(bool value) { }

	// RVA: 0x2173E80 Offset: 0x2172480 VA: 0x182173E80
	public Vector2 get_pivot() { }

	// RVA: 0x21741F0 Offset: 0x21727F0 VA: 0x1821741F0
	public void set_pivot(Vector2 value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x2173FF0 Offset: 0x21725F0 VA: 0x182173FF0
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0x16AF8F0 Offset: 0x16ADEF0 VA: 0x1816AF8F0
	public Rect get_rect() { }

	// RVA: 0x2174270 Offset: 0x2172870 VA: 0x182174270
	public void set_rect(Rect value) { }

	// RVA: 0x2173F30 Offset: 0x2172530 VA: 0x182173F30
	public Vector2 get_size() { }

	// RVA: 0x21742F0 Offset: 0x21728F0 VA: 0x1821742F0
	public void set_size(Vector2 value) { }

	// RVA: 0x2173FE0 Offset: 0x21725E0 VA: 0x182173FE0
	public float get_width() { }

	// RVA: 0x2174380 Offset: 0x2172980 VA: 0x182174380
	public void set_width(float value) { }

	// RVA: 0x2173E70 Offset: 0x2172470 VA: 0x182173E70
	public float get_height() { }

	// RVA: 0x2174120 Offset: 0x2172720 VA: 0x182174120
	public void set_height(float value) { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_isDefaultWidth() { }

	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70
	public bool get_isDefaultHeight() { }

	// RVA: 0x178BFD0 Offset: 0x178A5D0 VA: 0x18178BFD0
	public bool get_isAutoFitting() { }

	// RVA: 0x1C3AEA0 Offset: 0x1C394A0 VA: 0x181C3AEA0
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public Vector3[] get_corners() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public Vector3[] get_worldCorners() { }

	// RVA: 0x199B300 Offset: 0x1999900 VA: 0x18199B300
	public Vector4 get_margins() { }

	// RVA: 0x2174170 Offset: 0x2172770 VA: 0x182174170
	public void set_margins(Vector4 value) { }

	// RVA: 0x2173EA0 Offset: 0x21724A0 VA: 0x182173EA0
	public RectTransform get_rectTransform() { }

	// RVA: 0x2173F50 Offset: 0x2172550 VA: 0x182173F50
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x2173310 Offset: 0x2171910 VA: 0x182173310 Slot: 4
	protected override void Awake() { }

	// RVA: 0x21738A0 Offset: 0x2171EA0 VA: 0x1821738A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2173710 Offset: 0x2171D10 VA: 0x182173710
	private void OnContainerChanged() { }

	// RVA: 0x21738B0 Offset: 0x2171EB0 VA: 0x1821738B0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2173B50 Offset: 0x2172150 VA: 0x182173B50
	private void SetRect(Vector2 size) { }

	// RVA: 0x2173BA0 Offset: 0x21721A0 VA: 0x182173BA0
	private void UpdateCorners() { }

	// RVA: 0x21735D0 Offset: 0x2171BD0 VA: 0x1821735D0
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x21733C0 Offset: 0x21719C0 VA: 0x1821733C0
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x2173DF0 Offset: 0x21723F0 VA: 0x182173DF0
	public void .ctor() { }

	// RVA: 0x2173DB0 Offset: 0x21723B0 VA: 0x182173DB0
	private static void .cctor() { }
}

// Namespace: TMPro
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
[AddComponentMenu("Mesh/TextMeshPro - Text")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.2")]
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 11371
{
	// Fields
	[SerializeField]
	internal int _SortingLayer; // 0x6D8
	[SerializeField]
	internal int _SortingLayerID; // 0x6DC
	[SerializeField]
	internal int _SortingOrder; // 0x6E0
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x6E8
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x6F0
	private float m_previousLossyScaleY; // 0x6F4
	[SerializeField]
	private Renderer m_renderer; // 0x6F8
	private MeshFilter m_meshFilter; // 0x700
	private bool m_isFirstAllocation; // 0x708
	private int m_max_characters; // 0x70C
	private int m_max_numberOfLines; // 0x710
	private TMP_SubMesh[] m_subTextObjects; // 0x718
	[SerializeField]
	private MaskingTypes m_maskType; // 0x720
	private Matrix4x4 m_EnvMapMatrix; // 0x724
	private Vector3[] m_RectTransformCorners; // 0x768
	private bool m_isRegisteredForEvents; // 0x770
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveTextExtentMarker; // 0x88
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x98
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0xA0

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x2185A50 Offset: 0x2184050 VA: 0x182185A50
	public int get_sortingLayerID() { }

	// RVA: 0x2185D60 Offset: 0x2184360 VA: 0x182185D60
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2185AE0 Offset: 0x21840E0 VA: 0x182185AE0
	public int get_sortingOrder() { }

	// RVA: 0x2185F20 Offset: 0x2184520 VA: 0x182185F20
	public void set_sortingOrder(int value) { }

	// RVA: 0x217D4F0 Offset: 0x217BAF0 VA: 0x18217D4F0 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x2185CD0 Offset: 0x21842D0 VA: 0x182185CD0 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public TextContainer get_textContainer() { }

	// RVA: 0x2185B70 Offset: 0x2184170 VA: 0x182185B70
	public Transform get_transform() { }

	// RVA: 0x21859B0 Offset: 0x2183FB0 VA: 0x1821859B0
	public Renderer get_renderer() { }

	// RVA: 0x21858E0 Offset: 0x2183EE0 VA: 0x1821858E0 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x21857B0 Offset: 0x2183DB0 VA: 0x1821857B0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x21857A0 Offset: 0x2183DA0 VA: 0x1821857A0
	public MaskingTypes get_maskType() { }

	// RVA: 0x2185D50 Offset: 0x2184350 VA: 0x182185D50
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x21832D0 Offset: 0x21818D0 VA: 0x1821832D0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x2183520 Offset: 0x2181B20 VA: 0x182183520
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x2184110 Offset: 0x2182710 VA: 0x182184110 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x2183060 Offset: 0x2181660 VA: 0x182183060 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x2183630 Offset: 0x2181C30 VA: 0x182183630 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x21777A0 Offset: 0x2175DA0 VA: 0x1821777A0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x217FB60 Offset: 0x217E160 VA: 0x18217FB60 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x2184620 Offset: 0x2182C20 VA: 0x182184620 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x2184760 Offset: 0x2182D60 VA: 0x182184760 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x217E2B0 Offset: 0x217C8B0 VA: 0x18217E2B0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x217EBB0 Offset: 0x217D1B0 VA: 0x18217EBB0 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x217DB00 Offset: 0x217C100 VA: 0x18217DB00 Slot: 130
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGenerated]
	// RVA: 0x21856E0 Offset: 0x2183CE0 VA: 0x1821856E0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x2185C10 Offset: 0x2184210 VA: 0x182185C10 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x21844C0 Offset: 0x2182AC0 VA: 0x1821844C0 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x2184D10 Offset: 0x2183310 VA: 0x182184D10 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x2184F10 Offset: 0x2183510 VA: 0x182184F10 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x217BE50 Offset: 0x217A450 VA: 0x18217BE50
	public void UpdateFontAsset() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x217D790 Offset: 0x217BD90 VA: 0x18217D790 Slot: 4
	protected override void Awake() { }

	// RVA: 0x217F4D0 Offset: 0x217DAD0 VA: 0x18217F4D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x217F430 Offset: 0x217DA30 VA: 0x18217F430 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x217F340 Offset: 0x217D940 VA: 0x18217F340 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x217ED00 Offset: 0x217D300 VA: 0x18217ED00 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x21841B0 Offset: 0x21827B0 VA: 0x1821841B0
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x2183370 Offset: 0x2181970 VA: 0x182183370
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x2183240 Offset: 0x2181840 VA: 0x182183240
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x2183130 Offset: 0x2181730 VA: 0x182183130
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x217E170 Offset: 0x217C770 VA: 0x18217E170
	private void EnableMasking() { }

	// RVA: 0x217DF20 Offset: 0x217C520 VA: 0x18217DF20
	private void DisableMasking() { }

	// RVA: 0x21844E0 Offset: 0x2182AE0 VA: 0x1821844E0
	private void UpdateMask() { }

	// RVA: 0x217E5B0 Offset: 0x217CBB0 VA: 0x18217E5B0 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x217E6F0 Offset: 0x217CCF0 VA: 0x18217E6F0 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x217B310 Offset: 0x2179910 VA: 0x18217B310 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x217E910 Offset: 0x217CF10 VA: 0x18217E910 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x2183CB0 Offset: 0x21822B0 VA: 0x182183CB0 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x2183A20 Offset: 0x2182020 VA: 0x182183A20 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x2182ED0 Offset: 0x21814D0 VA: 0x182182ED0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x2183890 Offset: 0x2181E90 VA: 0x182183890 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x217DD40 Offset: 0x217C340 VA: 0x18217DD40
	private void CreateMaterialInstance() { }

	// RVA: 0x2183C70 Offset: 0x2182270 VA: 0x182183C70 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x2182B80 Offset: 0x2181180 VA: 0x182182B80 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x2183BB0 Offset: 0x21821B0 VA: 0x182183BB0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x217FED0 Offset: 0x217E4D0 VA: 0x18217FED0 Slot: 114
	internal override int SetArraySizes(TMP_Text.TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x217DBF0 Offset: 0x217C1F0 VA: 0x18217DBF0 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x217F410 Offset: 0x217DA10 VA: 0x18217F410 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x217FB20 Offset: 0x217E120 VA: 0x18217FB20 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x217F980 Offset: 0x217DF80 VA: 0x18217F980 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x217EC30 Offset: 0x217D230 VA: 0x18217EC30 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x217F5D0 Offset: 0x217DBD0 VA: 0x18217F5D0
	private void OnPreRenderObject() { }

	// RVA: 0x2158E20 Offset: 0x2157420 VA: 0x182158E20 Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x217EB00 Offset: 0x217D100 VA: 0x18217EB00 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x2183650 Offset: 0x2181C50 VA: 0x182183650
	private void SetMeshFilters(bool state) { }

	// RVA: 0x217FC40 Offset: 0x217E240 VA: 0x18217FC40 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x217FD70 Offset: 0x217E370 VA: 0x18217FD70
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x217DE20 Offset: 0x217C420 VA: 0x18217DE20 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x2184A90 Offset: 0x2183090 VA: 0x182184A90
	internal void UpdateSubMeshSortingLayerID(int id) { }

	// RVA: 0x2184BD0 Offset: 0x21831D0 VA: 0x182184BD0
	internal void UpdateSubMeshSortingOrder(int order) { }

	// RVA: 0x217E2D0 Offset: 0x217C8D0 VA: 0x18217E2D0 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x2184880 Offset: 0x2182E80 VA: 0x182184880
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x2185610 Offset: 0x2183C10 VA: 0x182185610
	public void .ctor() { }

	// RVA: 0x2185130 Offset: 0x2183730 VA: 0x182185130
	private static void .cctor() { }
}

// Namespace: TMPro
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.2")]
public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 11374
{
	// Fields
	private bool m_isRebuildingLayout; // 0x6D8
	private Coroutine m_DelayedGraphicRebuild; // 0x6E0
	private Coroutine m_DelayedMaterialRebuild; // 0x6E8
	private bool m_ShouldUpdateCulling; // 0x6F0
	private Rect m_ClipRect; // 0x6F4
	private bool m_ValidRect; // 0x704
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x708
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x710
	protected TMP_SubMeshUI[] m_subTextObjects; // 0x718
	private float m_previousLossyScaleY; // 0x720
	private Vector3[] m_RectTransformCorners; // 0x728
	private CanvasRenderer m_canvasRenderer; // 0x730
	private Canvas m_canvas; // 0x738
	private float m_CanvasScaleFactor; // 0x740
	private bool m_isFirstAllocation; // 0x744
	private int m_max_characters; // 0x748
	[SerializeField]
	private Material m_baseMaterial; // 0x750
	private bool m_isScrollRegionSet; // 0x758
	[SerializeField]
	private Vector4 m_maskOffset; // 0x75C
	private Matrix4x4 m_EnvMapMatrix; // 0x76C
	private bool m_isRegisteredForEvents; // 0x7AC
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveTextExtentMarker; // 0x88
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x98
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0xA0

	// Properties
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x217D5B0 Offset: 0x217BBB0 VA: 0x18217D5B0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x217D4F0 Offset: 0x217BAF0 VA: 0x18217D4F0 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x217D6E0 Offset: 0x217BCE0 VA: 0x18217D6E0 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x217D610 Offset: 0x217BC10 VA: 0x18217D610 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x217D500 Offset: 0x217BB00 VA: 0x18217D500
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x217B890 Offset: 0x2179E90 VA: 0x18217B890 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x217AB50 Offset: 0x2179150 VA: 0x18217AB50 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x217AC30 Offset: 0x2179230 VA: 0x18217AC30 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x21777A0 Offset: 0x2175DA0 VA: 0x1821777A0 Slot: 26
	public override void SetAllDirty() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedGraphicRebuild>d__18))]
	// RVA: 0x2174B90 Offset: 0x2173190 VA: 0x182174B90
	private IEnumerator DelayedGraphicRebuild() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedMaterialRebuild>d__19))]
	// RVA: 0x2174C00 Offset: 0x2173200 VA: 0x182174C00
	private IEnumerator DelayedMaterialRebuild() { }

	// RVA: 0x2177580 Offset: 0x2175B80 VA: 0x182177580 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x217C8C0 Offset: 0x217AEC0 VA: 0x18217C8C0
	private void UpdateSubObjectPivot() { }

	// RVA: 0x2175AF0 Offset: 0x21740F0 VA: 0x182175AF0 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x217C390 Offset: 0x217A990 VA: 0x18217C390 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x217D5A0 Offset: 0x217BBA0 VA: 0x18217D5A0
	public Vector4 get_maskOffset() { }

	// RVA: 0x217D760 Offset: 0x217BD60 VA: 0x18217D760
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0x2177660 Offset: 0x2175C60 VA: 0x182177660 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x2174970 Offset: 0x2172F70 VA: 0x182174970 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x217B960 Offset: 0x2179F60 VA: 0x18217B960 Slot: 102
	internal override void UpdateCulling() { }

	// RVA: 0x217C4F0 Offset: 0x217AAF0 VA: 0x18217C4F0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x21760A0 Offset: 0x21746A0 VA: 0x1821760A0 Slot: 112
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x2175FE0 Offset: 0x21745E0 VA: 0x182175FE0 Slot: 113
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x2174FB0 Offset: 0x21735B0 VA: 0x182174FB0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x2175EF0 Offset: 0x21744F0 VA: 0x182175EF0 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x2174700 Offset: 0x2172D00 VA: 0x182174700 Slot: 129
	public override void ClearMesh() { }

	[CompilerGenerated]
	// RVA: 0x217D430 Offset: 0x217BA30 VA: 0x18217D430 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x217D620 Offset: 0x217BC20 VA: 0x18217D620 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x217BE70 Offset: 0x217A470 VA: 0x18217BE70 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x217C9B0 Offset: 0x217AFB0 VA: 0x18217C9B0 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x217CC00 Offset: 0x217B200 VA: 0x18217CC00 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x217BE50 Offset: 0x217A450 VA: 0x18217BE50
	public void UpdateFontAsset() { }

	// RVA: 0x21743D0 Offset: 0x21729D0 VA: 0x1821743D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2176CE0 Offset: 0x21752E0 VA: 0x182176CE0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2176B50 Offset: 0x2175150 VA: 0x182176B50 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x21769A0 Offset: 0x2174FA0 VA: 0x1821769A0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2176260 Offset: 0x2174860 VA: 0x182176260 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x2175320 Offset: 0x2173920 VA: 0x182175320
	private Canvas GetCanvas() { }

	// RVA: 0x217BB40 Offset: 0x217A140 VA: 0x18217BB40
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x2174D70 Offset: 0x2173370 VA: 0x182174D70
	private void EnableMasking() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void DisableMasking() { }

	// RVA: 0x217BF00 Offset: 0x217A500 VA: 0x18217BF00
	private void UpdateMask() { }

	// RVA: 0x2175750 Offset: 0x2173D50 VA: 0x182175750 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x21758C0 Offset: 0x2173EC0 VA: 0x1821758C0 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x217B310 Offset: 0x2179910 VA: 0x18217B310 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x2175C50 Offset: 0x2174250 VA: 0x182175C50 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x217B370 Offset: 0x2179970 VA: 0x18217B370 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x217AF70 Offset: 0x2179570 VA: 0x18217AF70 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x217A9B0 Offset: 0x2178FB0 VA: 0x18217A9B0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x217ADD0 Offset: 0x21793D0 VA: 0x18217ADD0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x217B260 Offset: 0x2179860 VA: 0x18217B260 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x217A620 Offset: 0x2178C20 VA: 0x18217A620 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x217B1A0 Offset: 0x21797A0 VA: 0x18217B1A0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x217AD10 Offset: 0x2179310 VA: 0x18217AD10
	private void SetMeshArrays(int size) { }

	// RVA: 0x21777F0 Offset: 0x2175DF0 VA: 0x1821777F0 Slot: 114
	internal override int SetArraySizes(TMP_Text.TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x2174820 Offset: 0x2172E20 VA: 0x182174820 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x2176B10 Offset: 0x2175110 VA: 0x182176B10 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2176870 Offset: 0x2174E70 VA: 0x182176870 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x2177530 Offset: 0x2175B30 VA: 0x182177530 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2177210 Offset: 0x2175810 VA: 0x182177210 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2176190 Offset: 0x2174790 VA: 0x182176190 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x2176F50 Offset: 0x2175550 VA: 0x182176F50
	private void OnPreRenderCanvas() { }

	// RVA: 0x21652C0 Offset: 0x21638C0 VA: 0x1821652C0 Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x2175E40 Offset: 0x2174440 VA: 0x182175E40 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x2177670 Offset: 0x2175C70 VA: 0x182177670 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x2174C70 Offset: 0x2173270 VA: 0x182174C70 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x2175470 Offset: 0x2173A70 VA: 0x182175470 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x2175060 Offset: 0x2173660 VA: 0x182175060 Slot: 117
	internal override Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x217C610 Offset: 0x217AC10 VA: 0x18217C610
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x217D360 Offset: 0x217B960 VA: 0x18217D360
	public void .ctor() { }

	// RVA: 0x217CE80 Offset: 0x217B480 VA: 0x18217CE80
	private static void .cctor() { }
}

// Namespace: TMPro
public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 11375
{
	// Fields
	public int value__; // 0x0
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;
}

// Namespace: TMPro
public static class TMPro_EventManager // TypeDefIndex: 11376
{
	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x219B290 Offset: 0x2199890 VA: 0x18219B290
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x219B200 Offset: 0x2199800 VA: 0x18219B200
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x219B380 Offset: 0x2199980 VA: 0x18219B380
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x219B410 Offset: 0x2199A10 VA: 0x18219B410
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x219B160 Offset: 0x2199760 VA: 0x18219B160
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x219B5B0 Offset: 0x2199BB0 VA: 0x18219B5B0
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x219B050 Offset: 0x2199650 VA: 0x18219B050
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(Object obj) { }

	// RVA: 0x219B530 Offset: 0x2199B30 VA: 0x18219B530
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x219B630 Offset: 0x2199C30 VA: 0x18219B630
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x219B320 Offset: 0x2199920 VA: 0x18219B320
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x219B4A0 Offset: 0x2199AA0 VA: 0x18219B4A0
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x219B0D0 Offset: 0x21996D0 VA: 0x18219B0D0
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x219B690 Offset: 0x2199C90 VA: 0x18219B690
	private static void .cctor() { }
}

// Namespace: TMPro
public class Compute_DT_EventArgs // TypeDefIndex: 11377
{
	// Fields
	public Compute_DistanceTransform_EventTypes EventType; // 0x10
	public float ProgressPercentage; // 0x14
	public Color[] Colors; // 0x18

	// Methods

	// RVA: 0x421D90 Offset: 0x420390 VA: 0x180421D90
	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	// RVA: 0x3E8780 Offset: 0x3E6D80 VA: 0x1803E8780
	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }
}

// Namespace: TMPro
[Extension]
public static class TMPro_ExtensionMethods // TypeDefIndex: 11378
{
	// Methods

	[Extension]
	// RVA: 0x219C0C0 Offset: 0x219A6C0 VA: 0x18219C0C0
	internal static int TagToInt(string s) { }

	[Extension]
	// RVA: 0x219C250 Offset: 0x219A850 VA: 0x18219C250
	public static int[] ToIntArray(string text) { }

	[Extension]
	// RVA: 0x219BAC0 Offset: 0x219A0C0 VA: 0x18219BAC0
	public static string ArrayToString(char[] chars) { }

	[Extension]
	// RVA: 0x219BE40 Offset: 0x219A440 VA: 0x18219BE40
	public static string IntToString(int[] unicodes) { }

	[Extension]
	// RVA: 0x219C2F0 Offset: 0x219A8F0 VA: 0x18219C2F0
	internal static string UintToString(List<uint> unicodes) { }

	[Extension]
	// RVA: 0x219BED0 Offset: 0x219A4D0 VA: 0x18219BED0
	public static string IntToString(int[] unicodes, int start, int length) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0A70 Offset: 0x7BF070 VA: 0x1807C0A70
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[Extension]
	// RVA: 0x219BBA0 Offset: 0x219A1A0 VA: 0x18219BBA0
	public static bool Compare(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x219BB70 Offset: 0x219A170 VA: 0x18219BB70
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x177A1C0 Offset: 0x17787C0 VA: 0x18177A1C0
	public static bool Compare(Color a, Color b) { }

	[Extension]
	// RVA: 0x18142B0 Offset: 0x18128B0 VA: 0x1818142B0
	public static bool CompareRGB(Color a, Color b) { }

	[Extension]
	// RVA: 0x219BFE0 Offset: 0x219A5E0 VA: 0x18219BFE0
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x219BFE0 Offset: 0x219A5E0 VA: 0x18219BFE0
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x219C170 Offset: 0x219A770 VA: 0x18219C170
	public static Color32 Tint(Color32 c1, float tint) { }

	[Extension]
	// RVA: 0x219BDF0 Offset: 0x219A3F0 VA: 0x18219BDF0
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x219BD40 Offset: 0x219A340 VA: 0x18219BD40
	private static byte GammaToLinear(byte value) { }

	[Extension]
	// RVA: 0x219BFB0 Offset: 0x219A5B0 VA: 0x18219BFB0
	public static Color MinAlpha(Color c1, Color c2) { }

	[Extension]
	// RVA: 0x219BCB0 Offset: 0x219A2B0 VA: 0x18219BCB0
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[Extension]
	// RVA: 0x219BBE0 Offset: 0x219A1E0 VA: 0x18219BBE0
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }
}

// Namespace: TMPro
public static class TMP_Math // TypeDefIndex: 11379
{
	// Fields
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8

	// Methods

	// RVA: 0x219ABA0 Offset: 0x21991A0 VA: 0x18219ABA0
	public static bool Approximately(float a, float b) { }

	// RVA: 0x219ABD0 Offset: 0x21991D0 VA: 0x18219ABD0
	public static int Mod(int a, int b) { }

	// RVA: 0x219ABF0 Offset: 0x21991F0 VA: 0x18219ABF0
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 11380
{
	// Fields
	public int value__; // 0x0
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;
}

// Namespace: TMPro
[Serializable]
public struct VertexGradient // TypeDefIndex: 11381
{
	// Fields
	public Color topLeft; // 0x0
	public Color topRight; // 0x10
	public Color bottomLeft; // 0x20
	public Color bottomRight; // 0x30

	// Methods

	// RVA: 0x219C540 Offset: 0x219AB40 VA: 0x18219C540
	public void .ctor(Color color) { }

	// RVA: 0x1F89C20 Offset: 0x1F88220 VA: 0x181F89C20
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }
}

// Namespace: TMPro
public struct TMP_PageInfo // TypeDefIndex: 11382
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10
}

// Namespace: TMPro
public struct TMP_LinkInfo // TypeDefIndex: 11383
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x219AAC0 Offset: 0x21990C0 VA: 0x18219AAC0
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x219A9D0 Offset: 0x2198FD0 VA: 0x18219A9D0
	public string GetLinkText() { }

	// RVA: 0x219AAB0 Offset: 0x21990B0 VA: 0x18219AAB0
	public string GetLink() { }

	// RVA: 0x219A930 Offset: 0x2198F30 VA: 0x18219A930
	public string GetLinkID() { }
}

// Namespace: TMPro
public struct TMP_WordInfo // TypeDefIndex: 11384
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x219AF70 Offset: 0x2199570 VA: 0x18219AF70
	public string GetWord() { }
}

// Namespace: TMPro
public struct TMP_SpriteInfo // TypeDefIndex: 11385
{
	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8
}

// Namespace: TMPro
public struct Extents // TypeDefIndex: 11386
{
	// Fields
	internal static Extents zero; // 0x0
	internal static Extents uninitialized; // 0x10
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x1FBE710 Offset: 0x1FBCD10 VA: 0x181FBE710
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x2186800 Offset: 0x2184E00 VA: 0x182186800 Slot: 3
	public override string ToString() { }

	// RVA: 0x21869E0 Offset: 0x2184FE0 VA: 0x1821869E0
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public struct Mesh_Extents // TypeDefIndex: 11387
{
	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x1FBE710 Offset: 0x1FBCD10 VA: 0x181FBE710
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x21872F0 Offset: 0x21858F0 VA: 0x1821872F0 Slot: 3
	public override string ToString() { }
}

// Namespace: TMPro
internal struct WordWrapState // TypeDefIndex: 11388
{
	// Fields
	public int previous_WordBreak; // 0x0
	public int total_CharacterCount; // 0x4
	public int visible_CharacterCount; // 0x8
	public int visibleSpaceCount; // 0xC
	public int visible_SpriteCount; // 0x10
	public int visible_LinkCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharIndex; // 0x24
	public int lineNumber; // 0x28
	public float maxCapHeight; // 0x2C
	public float maxAscender; // 0x30
	public float maxDescender; // 0x34
	public float startOfLineAscender; // 0x38
	public float maxLineAscender; // 0x3C
	public float maxLineDescender; // 0x40
	public float pageAscender; // 0x44
	public HorizontalAlignmentOptions horizontalAlignment; // 0x48
	public float marginLeft; // 0x4C
	public float marginRight; // 0x50
	public float xAdvance; // 0x54
	public float preferredWidth; // 0x58
	public float preferredHeight; // 0x5C
	public float renderedWidth; // 0x60
	public float renderedHeight; // 0x64
	public float previousLineScale; // 0x68
	public int wordCount; // 0x6C
	public FontStyles fontStyle; // 0x70
	public int italicAngle; // 0x74
	public float fontScaleMultiplier; // 0x78
	public float currentFontSize; // 0x7C
	public float baselineOffset; // 0x80
	public float lineOffset; // 0x84
	public bool isDrivenLineSpacing; // 0x88
	public int lastBaseGlyphIndex; // 0x8C
	public float cSpace; // 0x90
	public float mSpace; // 0x94
	public TMP_TextInfo textInfo; // 0x98
	public TMP_LineInfo lineInfo; // 0xA0
	public Color32 vertexColor; // 0x100
	public Color32 underlineColor; // 0x104
	public Color32 strikethroughColor; // 0x108
	public HighlightState highlightState; // 0x10C
	public TMP_FontStyleStack basicStyleStack; // 0x120
	public TMP_TextProcessingStack<int> italicAngleStack; // 0x130
	public TMP_TextProcessingStack<Color32> colorStack; // 0x150
	public TMP_TextProcessingStack<Color32> underlineColorStack; // 0x170
	public TMP_TextProcessingStack<Color32> strikethroughColorStack; // 0x190
	public TMP_TextProcessingStack<Color32> highlightColorStack; // 0x1B0
	public TMP_TextProcessingStack<HighlightState> highlightStateStack; // 0x1D0
	public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack; // 0x200
	public TMP_TextProcessingStack<float> sizeStack; // 0x228
	public TMP_TextProcessingStack<float> indentStack; // 0x248
	public TMP_TextProcessingStack<FontWeight> fontWeightStack; // 0x268
	public TMP_TextProcessingStack<int> styleStack; // 0x288
	public TMP_TextProcessingStack<float> baselineStack; // 0x2A8
	public TMP_TextProcessingStack<int> actionStack; // 0x2C8
	public TMP_TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2E8
	public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack; // 0x340
	public int spriteAnimationID; // 0x360
	public TMP_FontAsset currentFontAsset; // 0x368
	public TMP_SpriteAsset currentSpriteAsset; // 0x370
	public Material currentMaterial; // 0x378
	public int currentMaterialIndex; // 0x380
	public Extents meshExtents; // 0x384
	public bool tagNoParsing; // 0x394
	public bool isNonBreakingSpace; // 0x395
	public Quaternion fxRotation; // 0x398
	public Vector3 fxScale; // 0x3A8
}

// Namespace: TMPro
internal struct TagAttribute // TypeDefIndex: 11389
{
	// Fields
	public int startIndex; // 0x0
	public int length; // 0x4
	public int hashCode; // 0x8
}

// Namespace: TMPro
internal struct RichTextTagAttribute // TypeDefIndex: 11390
{
	// Fields
	public int nameHashCode; // 0x0
	public int valueHashCode; // 0x4
	public TagValueType valueType; // 0x8
	public int valueStartIndex; // 0xC
	public int valueLength; // 0x10
	public TagUnitType unitType; // 0x14
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 11391
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x28
	[SerializeField]
	[FormerlySerializedAs("material")]
	internal Material m_Material; // 0x88
	internal int m_MaterialHashCode; // 0x90

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_version() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_version(string value) { }

	// RVA: 0x2187710 Offset: 0x2185D10 VA: 0x182187710
	public int get_instanceID() { }

	// RVA: 0x21876A0 Offset: 0x2185CA0 VA: 0x1821876A0
	public int get_hashCode() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_hashCode(int value) { }

	// RVA: 0x2187660 Offset: 0x2185C60 VA: 0x182187660
	public FaceInfo get_faceInfo() { }

	// RVA: 0x2187810 Offset: 0x2185E10 VA: 0x182187810
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public Material get_material() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	public void set_material(Material value) { }

	// RVA: 0x2187740 Offset: 0x2185D40 VA: 0x182187740
	public int get_materialHashCode() { }

	// RVA: 0xAC7EF0 Offset: 0xAC64F0 VA: 0x180AC7EF0
	public void set_materialHashCode(int value) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Character : TMP_TextElement // TypeDefIndex: 11392
{
	// Methods

	// RVA: 0x2187850 Offset: 0x2185E50 VA: 0x182187850
	public void .ctor() { }

	// RVA: 0x21878E0 Offset: 0x2185EE0 VA: 0x1821878E0
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0x2187960 Offset: 0x2185F60 VA: 0x182187960
	public void .ctor(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x2187880 Offset: 0x2185E80 VA: 0x182187880
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
public struct TMP_Vertex // TypeDefIndex: 11393
{
	// Fields
	public Vector3 position; // 0x0
	public Vector4 uv; // 0xC
	public Vector2 uv2; // 0x1C
	public Color32 color; // 0x24
	private static readonly TMP_Vertex k_Zero; // 0x0

	// Properties
	public static TMP_Vertex zero { get; }

	// Methods

	// RVA: 0x219AF00 Offset: 0x2199500 VA: 0x18219AF00
	public static TMP_Vertex get_zero() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void .cctor() { }
}

// Namespace: TMPro
public struct TMP_Offset // TypeDefIndex: 11394
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly TMP_Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; set; }
	public float right { get; set; }
	public float top { get; set; }
	public float bottom { get; set; }
	public float horizontal { get; set; }
	public float vertical { get; set; }
	public static TMP_Offset zero { get; }

	// Methods

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_left() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_left(float value) { }

	// RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	public float get_right() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_right(float value) { }

	// RVA: 0x1105EF0 Offset: 0x11044F0 VA: 0x181105EF0
	public float get_top() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_top(float value) { }

	// RVA: 0x19477A0 Offset: 0x1945DA0 VA: 0x1819477A0
	public float get_bottom() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_bottom(float value) { }

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_horizontal() { }

	// RVA: 0x194C280 Offset: 0x194A880 VA: 0x18194C280
	public void set_horizontal(float value) { }

	// RVA: 0x1105EF0 Offset: 0x11044F0 VA: 0x181105EF0
	public float get_vertical() { }

	// RVA: 0x219AEF0 Offset: 0x21994F0 VA: 0x18219AEF0
	public void set_vertical(float value) { }

	// RVA: 0x219ADE0 Offset: 0x21993E0 VA: 0x18219ADE0
	public static TMP_Offset get_zero() { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x219ADC0 Offset: 0x21993C0 VA: 0x18219ADC0
	public void .ctor(float horizontal, float vertical) { }

	// RVA: 0x177A1C0 Offset: 0x17787C0 VA: 0x18177A1C0
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x219AE40 Offset: 0x2199440 VA: 0x18219AE40
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x18152D0 Offset: 0x18138D0 VA: 0x1818152D0
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	// RVA: 0x219AD30 Offset: 0x2199330 VA: 0x18219AD30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x219ACD0 Offset: 0x21992D0 VA: 0x18219ACD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x219AC50 Offset: 0x2199250 VA: 0x18219AC50
	public bool Equals(TMP_Offset other) { }

	// RVA: 0x219AD80 Offset: 0x2199380 VA: 0x18219AD80
	private static void .cctor() { }
}

// Namespace: TMPro
public struct HighlightState // TypeDefIndex: 11395
{
	// Fields
	public Color32 color; // 0x0
	public TMP_Offset padding; // 0x4

	// Methods

	// RVA: 0x11057E0 Offset: 0x1103DE0 VA: 0x1811057E0
	public void .ctor(Color32 color, TMP_Offset padding) { }

	// RVA: 0x21870B0 Offset: 0x21856B0 VA: 0x1821870B0
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x21871D0 Offset: 0x21857D0 VA: 0x1821871D0
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x2187050 Offset: 0x2185650 VA: 0x182187050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2186F50 Offset: 0x2185550 VA: 0x182186F50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2186FC0 Offset: 0x21855C0 VA: 0x182186FC0
	public bool Equals(HighlightState other) { }
}

// Namespace: TMPro
[DebuggerDisplay("Unicode '{character}'  ({((uint)character).ToString("X")})")]
public struct TMP_CharacterInfo // TypeDefIndex: 11396
{
	// Fields
	public TMP_TextElementType elementType; // 0x0
	public char character; // 0x4
	public int index; // 0x8
	public int stringLength; // 0xC
	public TMP_TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public TMP_FontAsset fontAsset; // 0x20
	public Material material; // 0x28
	public int materialReferenceIndex; // 0x30
	public bool isUsingAlternateTypeface; // 0x34
	public float pointSize; // 0x38
	public int lineNumber; // 0x3C
	public int pageNumber; // 0x40
	public int vertexIndex; // 0x44
	public TMP_Vertex vertex_BL; // 0x48
	public TMP_Vertex vertex_TL; // 0x70
	public TMP_Vertex vertex_TR; // 0x98
	public TMP_Vertex vertex_BR; // 0xC0
	public Vector3 topLeft; // 0xE8
	public Vector3 bottomLeft; // 0xF4
	public Vector3 topRight; // 0x100
	public Vector3 bottomRight; // 0x10C
	public float origin; // 0x118
	public float xAdvance; // 0x11C
	public float ascender; // 0x120
	public float baseLine; // 0x124
	public float descender; // 0x128
	internal float adjustedAscender; // 0x12C
	internal float adjustedDescender; // 0x130
	internal float adjustedHorizontalAdvance; // 0x134
	public float aspectRatio; // 0x138
	public float scale; // 0x13C
	public Color32 color; // 0x140
	public Color32 underlineColor; // 0x144
	public int underlineVertexIndex; // 0x148
	public Color32 strikethroughColor; // 0x14C
	public int strikethroughVertexIndex; // 0x150
	public Color32 highlightColor; // 0x154
	public HighlightState highlightState; // 0x158
	public FontStyles style; // 0x16C
	public bool isVisible; // 0x170
}

// Namespace: TMPro
public enum ColorMode // TypeDefIndex: 11397
{
	// Fields
	public int value__; // 0x0
	public const ColorMode Single = 0;
	public const ColorMode HorizontalGradient = 1;
	public const ColorMode VerticalGradient = 2;
	public const ColorMode FourCornersGradient = 3;
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 11398
{
	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x2187A30 Offset: 0x2186030 VA: 0x182187A30
	public void .ctor() { }

	// RVA: 0x2187AE0 Offset: 0x21860E0 VA: 0x182187AE0
	public void .ctor(Color color) { }

	// RVA: 0x2187B30 Offset: 0x2186130 VA: 0x182187B30
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x21879F0 Offset: 0x2185FF0 VA: 0x1821879F0
	private static void .cctor() { }
}

// Namespace: TMPro
public static class TMP_Compatibility // TypeDefIndex: 11400
{
	// Methods

	// RVA: 0x2187BA0 Offset: 0x21861A0 VA: 0x182187BA0
	public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) { }
}

// Namespace: TMPro
internal interface ITweenValue // TypeDefIndex: 11401
{
	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();
}

// Namespace: TMPro
internal struct ColorTween : ITweenValue // TypeDefIndex: 11404
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1105D70 Offset: 0x1104370 VA: 0x181105D70
	public Color get_startColor() { }

	// RVA: 0x14DAB30 Offset: 0x14D9130 VA: 0x1814DAB30
	public void set_startColor(Color value) { }

	// RVA: 0x8641A0 Offset: 0x8627A0 VA: 0x1808641A0
	public Color get_targetColor() { }

	// RVA: 0x14DAB50 Offset: 0x14D9150 VA: 0x1814DAB50
	public void set_targetColor(Color value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0 Slot: 6
	public float get_duration() { }

	// RVA: 0x1853730 Offset: 0x1851D30 VA: 0x181853730
	public void set_duration(float value) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x2186580 Offset: 0x2184B80 VA: 0x182186580 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x21864C0 Offset: 0x2184AC0 VA: 0x1821864C0
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool GetIgnoreTimescale() { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0
	public float GetDuration() { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: TMPro
internal struct FloatTween : ITweenValue // TypeDefIndex: 11406
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1105EF0 Offset: 0x11044F0 VA: 0x181105EF0
	public float get_startValue() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_startValue(float value) { }

	// RVA: 0x19477A0 Offset: 0x1945DA0 VA: 0x1819477A0
	public float get_targetValue() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_targetValue(float value) { }

	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0 Slot: 6
	public float get_duration() { }

	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	public void set_duration(float value) { }

	// RVA: 0xC1EE00 Offset: 0xC1D400 VA: 0x180C1EE00 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1453DF0 Offset: 0x14523F0 VA: 0x181453DF0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x2186BD0 Offset: 0x21851D0 VA: 0x182186BD0 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x2186B10 Offset: 0x2185110 VA: 0x182186B10
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0xC1EE00 Offset: 0xC1D400 VA: 0x180C1EE00
	public bool GetIgnoreTimescale() { }

	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float GetDuration() { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: TMPro
internal class TweenRunner<T> // TypeDefIndex: 11408
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	[IteratorStateMachine(typeof(TweenRunner.<Start>d__2<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerator Start(T tweenInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6D1C0 Offset: 0xA6B7C0 VA: 0x180A6D1C0
	|-TweenRunner<FloatTween>.Start
	|
	|-RVA: 0xA6D280 Offset: 0xA6B880 VA: 0x180A6D280
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Start
	*/

	// RVA: -1 Offset: -1
	public void Init(MonoBehaviour coroutineContainer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-TweenRunner<FloatTween>.Init
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Init
	*/

	// RVA: -1 Offset: -1
	public void StartTween(T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6CFB0 Offset: 0xA6B5B0 VA: 0x180A6CFB0
	|-TweenRunner<FloatTween>.StartTween
	|
	|-RVA: 0xA6CD50 Offset: 0xA6B350 VA: 0x180A6CD50
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StartTween
	*/

	// RVA: -1 Offset: -1
	public void StopTween() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6D4C0 Offset: 0xA6BAC0 VA: 0x180A6D4C0
	|-TweenRunner<FloatTween>.StopTween
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StopTween
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-TweenRunner<FloatTween>..ctor
	|-TweenRunner<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: TMPro
public static class TMP_DefaultControls // TypeDefIndex: 11410
{
	// Fields
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_TextElementSize; // 0x0
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Color s_DefaultSelectableColor; // 0x18
	private static Color s_TextColor; // 0x28

	// Methods

	// RVA: 0x218A010 Offset: 0x2188610 VA: 0x18218A010
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0x218A0B0 Offset: 0x21886B0 VA: 0x18218A0B0
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0x218A1C0 Offset: 0x21887C0 VA: 0x18218A1C0
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0x218A170 Offset: 0x2188770 VA: 0x18218A170
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x218A330 Offset: 0x2188930 VA: 0x18218A330
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x218A250 Offset: 0x2188850 VA: 0x18218A250
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x2189BE0 Offset: 0x21881E0 VA: 0x182189BE0
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x2187CB0 Offset: 0x21862B0 VA: 0x182187CB0
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x2189F60 Offset: 0x2188560 VA: 0x182189F60
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x2189370 Offset: 0x2187970 VA: 0x182189370
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x2188080 Offset: 0x2186680 VA: 0x182188080
	public static GameObject CreateDropdown(TMP_DefaultControls.Resources resources) { }

	// RVA: -1 Offset: -1
	private static T AddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0440 Offset: 0x7BEA40 VA: 0x1807C0440
	|-TMP_DefaultControls.AddComponent<object>
	*/

	// RVA: 0x218A410 Offset: 0x2188A10 VA: 0x18218A410
	private static void .cctor() { }
}

// Namespace: TMPro
[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
[RequireComponent(typeof(RectTransform))]
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 11418
{
	// Fields
	private static readonly TMP_Dropdown.OptionData k_NothingOption; // 0x0
	private static readonly TMP_Dropdown.OptionData k_EverythingOption; // 0x8
	private static readonly TMP_Dropdown.OptionData k_MixedOption; // 0x10
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private TMP_Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[SerializeField]
	private Graphic m_Placeholder; // 0x118
	[Space]
	[SerializeField]
	private TMP_Text m_ItemText; // 0x120
	[SerializeField]
	private Image m_ItemImage; // 0x128
	[Space]
	[SerializeField]
	private int m_Value; // 0x130
	[SerializeField]
	private bool m_MultiSelect; // 0x134
	[Space]
	[SerializeField]
	private TMP_Dropdown.OptionDataList m_Options; // 0x138
	[Space]
	[SerializeField]
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x140
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x148
	private GameObject m_Dropdown; // 0x150
	private GameObject m_Blocker; // 0x158
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x160
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x168
	private bool validTemplate; // 0x170
	private Coroutine m_Coroutine; // 0x178
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x18

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }
	public bool MultiSelect { get; set; }

	// Methods

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public RectTransform get_template() { }

	// RVA: 0x218E840 Offset: 0x218CE40 VA: 0x18218E840
	public void set_template(RectTransform value) { }

	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public TMP_Text get_captionText() { }

	// RVA: 0x218E720 Offset: 0x218CD20 VA: 0x18218E720
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	public Image get_captionImage() { }

	// RVA: 0x218E6F0 Offset: 0x218CCF0 VA: 0x18218E6F0
	public void set_captionImage(Image value) { }

	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0
	public Graphic get_placeholder() { }

	// RVA: 0x218E810 Offset: 0x218CE10 VA: 0x18218E810
	public void set_placeholder(Graphic value) { }

	// RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	public TMP_Text get_itemText() { }

	// RVA: 0x218E780 Offset: 0x218CD80 VA: 0x18218E780
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x19DB6F0 Offset: 0x19D9CF0 VA: 0x1819DB6F0
	public Image get_itemImage() { }

	// RVA: 0x218E750 Offset: 0x218CD50 VA: 0x18218E750
	public void set_itemImage(Image value) { }

	// RVA: 0x218E6B0 Offset: 0x218CCB0 VA: 0x18218E6B0
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x218E7D0 Offset: 0x218CDD0 VA: 0x18218E7D0
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x218E7B0 Offset: 0x218CDB0 VA: 0x18218E7B0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x218E6A0 Offset: 0x218CCA0 VA: 0x18218E6A0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x218E6E0 Offset: 0x218CCE0 VA: 0x18218E6E0
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x561240 Offset: 0x55F840 VA: 0x180561240
	public int get_value() { }

	// RVA: 0x218E870 Offset: 0x218CE70 VA: 0x18218E870
	public void set_value(int value) { }

	// RVA: 0x218C450 Offset: 0x218AA50 VA: 0x18218C450
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x218C460 Offset: 0x218AA60 VA: 0x18218C460
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x218E630 Offset: 0x218CC30 VA: 0x18218E630
	public bool get_IsExpanded() { }

	// RVA: 0x218E690 Offset: 0x218CC90 VA: 0x18218E690
	public bool get_MultiSelect() { }

	// RVA: 0x218E6D0 Offset: 0x218CCD0 VA: 0x18218E6D0
	public void set_MultiSelect(bool value) { }

	// RVA: 0x218E490 Offset: 0x218CA90 VA: 0x18218E490
	protected void .ctor() { }

	// RVA: 0x218AD80 Offset: 0x2189380 VA: 0x18218AD80 Slot: 4
	protected override void Awake() { }

	// RVA: 0x218E200 Offset: 0x218C800 VA: 0x18218E200 Slot: 6
	protected override void Start() { }

	// RVA: 0x218BB40 Offset: 0x218A140 VA: 0x18218BB40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x218BF40 Offset: 0x218A540 VA: 0x18218BF40
	public void RefreshShownValue() { }

	// RVA: 0x218A820 Offset: 0x2188E20 VA: 0x18218A820
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x218A890 Offset: 0x2188E90 VA: 0x18218A890
	public void AddOptions(List<string> options) { }

	// RVA: 0x218AA10 Offset: 0x2189010 VA: 0x18218AA10
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x218AED0 Offset: 0x21894D0 VA: 0x18218AED0
	public void ClearOptions() { }

	// RVA: 0x218C5E0 Offset: 0x218ABE0 VA: 0x18218C5E0
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4AF0 Offset: 0x6D30F0 VA: 0x1806D4AF0
	|-TMP_Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x218BBF0 Offset: 0x218A1F0 VA: 0x18218BBF0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x218BBF0 Offset: 0x218A1F0 VA: 0x18218BBF0 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x218BB30 Offset: 0x218A130 VA: 0x18218BB30 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x218CCC0 Offset: 0x218B2C0 VA: 0x18218CCC0
	public void Show() { }

	// RVA: 0x218BB00 Offset: 0x218A100 VA: 0x18218BB00
	private static bool IsEverythingValue(int count, int value) { }

	// RVA: 0x218B6B0 Offset: 0x2189CB0 VA: 0x18218B6B0
	private static int EverythingValue(int count) { }

	// RVA: 0x218AF90 Offset: 0x2189590 VA: 0x18218AF90 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x218B610 Offset: 0x2189C10 VA: 0x18218B610 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x218B4D0 Offset: 0x2189AD0 VA: 0x18218B4D0 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x218B660 Offset: 0x2189C60 VA: 0x18218B660 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x218B530 Offset: 0x2189B30 VA: 0x18218B530 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x218A4C0 Offset: 0x2188AC0 VA: 0x18218A4C0
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x218ACF0 Offset: 0x21892F0 VA: 0x18218ACF0
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x218AB90 Offset: 0x2189190 VA: 0x18218AB90
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x218C3A0 Offset: 0x218A9A0 VA: 0x18218C3A0
	private void SetAlpha(float alpha) { }

	// RVA: 0x218B700 Offset: 0x2189D00 VA: 0x18218B700
	public void Hide() { }

	[IteratorStateMachine(typeof(TMP_Dropdown.<DelayedDestroyDropdownList>d__90))]
	// RVA: 0x218B590 Offset: 0x2189B90 VA: 0x18218B590
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x218B900 Offset: 0x2189F00 VA: 0x18218B900
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x218BC00 Offset: 0x218A200 VA: 0x18218BC00
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x218B6E0 Offset: 0x2189CE0 VA: 0x18218B6E0
	private static int FirstActiveFlagIndex(int value) { }

	// RVA: 0x218E2C0 Offset: 0x218C8C0 VA: 0x18218E2C0
	private static void .cctor() { }
}

// Namespace: TMPro
internal class TMP_DynamicFontAssetUtilities // TypeDefIndex: 11420
{
	// Fields
	private static TMP_DynamicFontAssetUtilities s_Instance; // 0x0
	private Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference> s_SystemFontLookup; // 0x10
	private string[] s_SystemFontPaths; // 0x18
	private uint s_RegularStyleNameHashCode; // 0x20

	// Methods

	// RVA: 0x218E880 Offset: 0x218CE80 VA: 0x18218E880
	private void InitializeSystemFontReferenceCache() { }

	// RVA: 0x218F260 Offset: 0x218D860 VA: 0x18218F260
	public static bool TryGetSystemFontReference(string familyName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x218F1D0 Offset: 0x218D7D0 VA: 0x18218F1D0
	public static bool TryGetSystemFontReference(string familyName, string styleName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x218EED0 Offset: 0x218D4D0 VA: 0x18218EED0
	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x218F360 Offset: 0x218D960 VA: 0x18218F360
	public void .ctor() { }

	// RVA: 0x218F2F0 Offset: 0x218D8F0 VA: 0x18218F2F0
	private static void .cctor() { }
}

// Namespace: TMPro
public enum AtlasPopulationMode // TypeDefIndex: 11421
{
	// Fields
	public int value__; // 0x0
	public const AtlasPopulationMode Static = 0;
	public const AtlasPopulationMode Dynamic = 1;
	public const AtlasPopulationMode DynamicOS = 2;
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 11423
{
	// Fields
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x98
	[SerializeField]
	internal FontAssetCreationSettings m_CreationSettings; // 0xA0
	[SerializeField]
	private Font m_SourceFontFile; // 0x100
	[SerializeField]
	private string m_SourceFontFilePath; // 0x108
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x110
	[SerializeField]
	internal bool InternalDynamicOS; // 0x114
	private int m_FamilyNameHashCode; // 0x118
	private int m_StyleNameHashCode; // 0x11C
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0x120
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x128
	[SerializeField]
	internal List<TMP_Character> m_CharacterTable; // 0x130
	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0x138
	internal Texture2D m_AtlasTexture; // 0x140
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0x148
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0x150
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0x154
	[SerializeField]
	private bool m_GetFontFeatures; // 0x155
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x156
	[SerializeField]
	internal int m_AtlasWidth; // 0x158
	[SerializeField]
	internal int m_AtlasHeight; // 0x15C
	[SerializeField]
	internal int m_AtlasPadding; // 0x160
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x164
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0x168
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0x170
	[SerializeField]
	internal TMP_FontFeatureTable m_FontFeatureTable; // 0x178
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; // 0x180
	[SerializeField]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x188
	[SerializeField]
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
	[SerializeField]
	private TMP_FontWeightPair[] fontWeights; // 0x198
	public float normalStyle; // 0x1A0
	public float normalSpacingOffset; // 0x1A4
	public float boldStyle; // 0x1A8
	public float boldSpacing; // 0x1AC
	public byte italicStyle; // 0x1B0
	public byte tabSize; // 0x1B1
	internal bool IsFontAssetLookupTablesDirty; // 0x1B2
	[SerializeField]
	private FaceInfo_Legacy m_fontInfo; // 0x1B8
	[SerializeField]
	internal List<TMP_Glyph> m_glyphInfoList; // 0x1C0
	[SerializeField]
	[FormerlySerializedAs("m_kerningInfo")]
	internal KerningTable m_KerningTable; // 0x1C8
	[SerializeField]
	private List<TMP_FontAsset> fallbackFontAssets; // 0x1D0
	[SerializeField]
	public Texture2D atlas; // 0x1D8
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x10
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x18
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x20
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; // 0x28
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x30
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x38
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x40
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x48
	private static string s_DefaultMaterialSuffix; // 0x50
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x58
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x60
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x68
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x70
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x78
	private List<Glyph> m_GlyphsToRender; // 0x1E0
	private List<Glyph> m_GlyphsRendered; // 0x1E8
	private List<uint> m_GlyphIndexList; // 0x1F0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1F8
	internal List<uint> m_GlyphsToAdd; // 0x200
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x208
	internal List<TMP_Character> m_CharactersToAdd; // 0x210
	internal HashSet<uint> m_CharactersToAddLookup; // 0x218
	internal List<uint> s_MissingCharacterList; // 0x220
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x228
	internal static uint[] k_GlyphIndexArray; // 0x80

	// Properties
	public FontAssetCreationSettings creationSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	public bool getFontFeatures { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }
	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	public FaceInfo_Legacy fontInfo { get; }

	// Methods

	// RVA: 0x219A630 Offset: 0x2198C30 VA: 0x18219A630
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0x219A860 Offset: 0x2198E60 VA: 0x18219A860
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public Font get_sourceFontFile() { }

	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x219A520 Offset: 0x2198B20 VA: 0x18219A520
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x219A820 Offset: 0x2198E20 VA: 0x18219A820
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x219A680 Offset: 0x2198C80 VA: 0x18219A680
	internal int get_familyNameHashCode() { }

	// RVA: 0x219A8B0 Offset: 0x2198EB0 VA: 0x18219A8B0
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x219A770 Offset: 0x2198D70 VA: 0x18219A770
	internal int get_styleNameHashCode() { }

	// RVA: 0x219A900 Offset: 0x2198F00 VA: 0x18219A900
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x8DA9C0 Offset: 0x8D8FC0 VA: 0x1808DA9C0
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x219A720 Offset: 0x2198D20 VA: 0x18219A720
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x17871D0 Offset: 0x17857D0 VA: 0x1817871D0
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x1AA57D0 Offset: 0x1AA3DD0 VA: 0x181AA57D0
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0x219A5E0 Offset: 0x2198BE0 VA: 0x18219A5E0
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0x219A540 Offset: 0x2198B40 VA: 0x18219A540
	public Texture2D get_atlasTexture() { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x127C520 Offset: 0x127AB20 VA: 0x18127C520
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x219A530 Offset: 0x2198B30 VA: 0x18219A530
	public int get_atlasTextureCount() { }

	// RVA: 0x219A760 Offset: 0x2198D60 VA: 0x18219A760
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x219A8F0 Offset: 0x2198EF0 VA: 0x18219A8F0
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x219A710 Offset: 0x2198D10 VA: 0x18219A710
	public bool get_getFontFeatures() { }

	// RVA: 0x219A8E0 Offset: 0x2198EE0 VA: 0x18219A8E0
	public void set_getFontFeatures(bool value) { }

	// RVA: 0x219A620 Offset: 0x2198C20 VA: 0x18219A620
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x219A850 Offset: 0x2198E50 VA: 0x18219A850
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x17A2690 Offset: 0x17A0C90 VA: 0x1817A2690
	public int get_atlasWidth() { }

	// RVA: 0x219A840 Offset: 0x2198E40 VA: 0x18219A840
	internal void set_atlasWidth(int value) { }

	// RVA: 0x219A510 Offset: 0x2198B10 VA: 0x18219A510
	public int get_atlasHeight() { }

	// RVA: 0x219A800 Offset: 0x2198E00 VA: 0x18219A800
	internal void set_atlasHeight(int value) { }

	// RVA: 0x178DC60 Offset: 0x178C260 VA: 0x18178DC60
	public int get_atlasPadding() { }

	// RVA: 0x219A810 Offset: 0x2198E10 VA: 0x18219A810
	internal void set_atlasPadding(int value) { }

	// RVA: 0x1791A70 Offset: 0x1790070 VA: 0x181791A70
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x219A830 Offset: 0x2198E30 VA: 0x18219A830
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x219A7F0 Offset: 0x2198DF0 VA: 0x18219A7F0
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x219A910 Offset: 0x2198F10 VA: 0x18219A910
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1793F00 Offset: 0x1792500 VA: 0x181793F00
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x219A8C0 Offset: 0x2198EC0 VA: 0x18219A8C0
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x219A700 Offset: 0x2198D00 VA: 0x18219A700
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1C9ACB0 Offset: 0x1C992B0 VA: 0x181C9ACB0
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x37EAE0 Offset: 0x37D0E0 VA: 0x18037EAE0
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x37EB40 Offset: 0x37D140 VA: 0x18037EB40
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0x37EB10 Offset: 0x37D110 VA: 0x18037EB10
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x37EB80 Offset: 0x37D180 VA: 0x18037EB80
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0x1BE7A30 Offset: 0x1BE6030 VA: 0x181BE7A30
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0x21912D0 Offset: 0x218F8D0 VA: 0x1821912D0
	public static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	// RVA: 0x2191AF0 Offset: 0x21900F0 VA: 0x182191AF0
	public static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x2191980 Offset: 0x218FF80 VA: 0x182191980
	private static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2191500 Offset: 0x218FB00 VA: 0x182191500
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x2191800 Offset: 0x218FE00 VA: 0x182191800
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x21916A0 Offset: 0x218FCA0 VA: 0x1821916A0
	private static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x2190CB0 Offset: 0x218F2B0 VA: 0x182190CB0
	private static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x2194680 Offset: 0x2192C80 VA: 0x182194680
	private void OnDestroy() { }

	// RVA: 0x21947B0 Offset: 0x2192DB0 VA: 0x1821947B0
	public void ReadFontAssetDefinition() { }

	// RVA: 0x2193510 Offset: 0x2191B10 VA: 0x182193510
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x21939B0 Offset: 0x2191FB0 VA: 0x1821939B0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x2193300 Offset: 0x2191900 VA: 0x182193300
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x2193EE0 Offset: 0x21924E0 VA: 0x182193EE0
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x2193C30 Offset: 0x2192230 VA: 0x182193C30
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2194180 Offset: 0x2192780 VA: 0x182194180
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2194340 Offset: 0x2192940 VA: 0x182194340
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x2190480 Offset: 0x218EA80 VA: 0x182190480
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x2190160 Offset: 0x218E760 VA: 0x182190160
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x218F370 Offset: 0x218D970 VA: 0x18218F370
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) { }

	// RVA: 0x2194500 Offset: 0x2192B00 VA: 0x182194500
	private FontEngineError LoadFontFace() { }

	// RVA: 0x2195500 Offset: 0x2193B00 VA: 0x182195500
	internal void SortCharacterTable() { }

	// RVA: 0x21956D0 Offset: 0x2193CD0 VA: 0x1821956D0
	internal void SortGlyphTable() { }

	// RVA: 0x2195680 Offset: 0x2193C80 VA: 0x182195680
	internal void SortFontFeatureTable() { }

	// RVA: 0x21951F0 Offset: 0x21937F0 VA: 0x1821951F0
	internal void SortAllTables() { }

	// RVA: 0x2192200 Offset: 0x2190800 VA: 0x182192200
	public bool HasCharacter(int character) { }

	// RVA: 0x2192280 Offset: 0x2190880 VA: 0x182192280
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2191FB0 Offset: 0x21905B0 VA: 0x182191FB0
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2192890 Offset: 0x2190E90 VA: 0x182192890
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x2192A10 Offset: 0x2191010 VA: 0x182192A10
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x2193140 Offset: 0x2191740 VA: 0x182193140
	public bool HasCharacters(string text) { }

	// RVA: 0x2191D50 Offset: 0x2190350 VA: 0x182191D50
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x2191C80 Offset: 0x2190280 VA: 0x182191C80
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0x2191E40 Offset: 0x2190440 VA: 0x182191E40
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x2191F20 Offset: 0x2190520 VA: 0x182191F20
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	// RVA: 0x2194DF0 Offset: 0x21933F0 VA: 0x182194DF0
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x2199090 Offset: 0x2197690 VA: 0x182199090
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x2194CA0 Offset: 0x21932A0 VA: 0x182194CA0
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x2198B10 Offset: 0x2197110 VA: 0x182198B10
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x2198ED0 Offset: 0x21974D0 VA: 0x182198ED0
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x21979A0 Offset: 0x2195FA0 VA: 0x1821979A0
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x2196130 Offset: 0x2194730 VA: 0x182196130
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x2196D30 Offset: 0x2195330 VA: 0x182196D30
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x2196D60 Offset: 0x2195360 VA: 0x182196D60
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x218F3E0 Offset: 0x218D9E0 VA: 0x18218F3E0
	internal bool AddGlyphInternal(uint glyphIndex) { }

	// RVA: 0x21979D0 Offset: 0x2195FD0 VA: 0x1821979D0
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x2195850 Offset: 0x2193E50 VA: 0x182195850
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0x21984B0 Offset: 0x2196AB0 VA: 0x1821984B0
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x2198020 Offset: 0x2196620 VA: 0x182198020
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x2194F40 Offset: 0x2193540 VA: 0x182194F40
	private void SetupNewAtlasTexture() { }

	// RVA: 0x2198960 Offset: 0x2196F60 VA: 0x182198960
	internal void UpdateAtlasTexture() { }

	// RVA: 0x21992C0 Offset: 0x21978C0 VA: 0x1821992C0
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x21993D0 Offset: 0x21979D0 VA: 0x1821993D0
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x2193200 Offset: 0x2191800 VA: 0x182193200
	internal void ImportFontFeatures() { }

	// RVA: 0x2199480 Offset: 0x2197A80 VA: 0x182199480
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	// RVA: 0x2199870 Offset: 0x2197E70 VA: 0x182199870
	internal void UpdateLigatureSubstitutionRecords() { }

	// RVA: 0x218F400 Offset: 0x218DA00 VA: 0x18218F400
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	// RVA: 0x21994F0 Offset: 0x2197AF0 VA: 0x1821994F0
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x218FE40 Offset: 0x218E440 VA: 0x18218FE40
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	// RVA: 0x2199560 Offset: 0x2197B60 VA: 0x182199560
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x2198C90 Offset: 0x2197290 VA: 0x182198C90
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	// RVA: 0x218F840 Offset: 0x218DE40 VA: 0x18218F840
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	// RVA: 0x218FB40 Offset: 0x218E140 VA: 0x18218FB40
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0490 Offset: 0x7BEA90 VA: 0x1807C0490
	|-TMP_FontAsset.CopyListDataToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2198D40 Offset: 0x2197340 VA: 0x182198D40
	internal void UpdateFontAssetData() { }

	// RVA: 0x2190B40 Offset: 0x218F140 VA: 0x182190B40
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x2190900 Offset: 0x218EF00 VA: 0x182190900
	internal void ClearCharacterAndGlyphTablesInternal() { }

	// RVA: 0x2190B90 Offset: 0x218F190 VA: 0x182190B90
	internal void ClearFontFeaturesInternal() { }

	// RVA: 0x2190930 Offset: 0x218EF30 VA: 0x182190930
	private void ClearCharacterAndGlyphTables() { }

	// RVA: 0x2190BB0 Offset: 0x218F1B0 VA: 0x182190BB0
	private void ClearFontFeaturesTables() { }

	// RVA: 0x21906B0 Offset: 0x218ECB0 VA: 0x1821906B0
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x2191BA0 Offset: 0x21901A0 VA: 0x182191BA0
	private void DestroyAtlasTextures() { }

	// RVA: 0x21998E0 Offset: 0x2197EE0 VA: 0x1821998E0
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0x219A130 Offset: 0x2198730 VA: 0x18219A130
	public void .ctor() { }

	// RVA: 0x2199D20 Offset: 0x2198320 VA: 0x182199D20
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class FaceInfo_Legacy // TypeDefIndex: 11424
{
	// Fields
	public string Name; // 0x10
	public float PointSize; // 0x18
	public float Scale; // 0x1C
	public int CharacterCount; // 0x20
	public float LineHeight; // 0x24
	public float Baseline; // 0x28
	public float Ascender; // 0x2C
	public float CapHeight; // 0x30
	public float Descender; // 0x34
	public float CenterLine; // 0x38
	public float SuperscriptOffset; // 0x3C
	public float SubscriptOffset; // 0x40
	public float SubSize; // 0x44
	public float Underline; // 0x48
	public float UnderlineThickness; // 0x4C
	public float strikethrough; // 0x50
	public float strikethroughThickness; // 0x54
	public float TabWidth; // 0x58
	public float Padding; // 0x5C
	public float AtlasWidth; // 0x60
	public float AtlasHeight; // 0x64

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 11425
{
	// Methods

	// RVA: 0x219F6C0 Offset: 0x219DCC0 VA: 0x18219F6C0
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public struct FontAssetCreationSettings // TypeDefIndex: 11426
{
	// Fields
	public string sourceFontFileName; // 0x0
	public string sourceFontFileGUID; // 0x8
	public int faceIndex; // 0x10
	public int pointSizeSamplingMode; // 0x14
	public int pointSize; // 0x18
	public int padding; // 0x1C
	public int paddingMode; // 0x20
	public int packingMode; // 0x24
	public int atlasWidth; // 0x28
	public int atlasHeight; // 0x2C
	public int characterSetSelectionMode; // 0x30
	public string characterSequence; // 0x38
	public string referencedFontAssetGUID; // 0x40
	public string referencedTextAssetGUID; // 0x48
	public int fontStyle; // 0x50
	public float fontStyleModifier; // 0x54
	public int renderMode; // 0x58
	public bool includeFontFeatures; // 0x5C

	// Methods

	// RVA: 0x219C560 Offset: 0x219AB60 VA: 0x18219C560
	internal void .ctor(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_FontWeightPair // TypeDefIndex: 11427
{
	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8
}

// Namespace: TMPro
public struct KerningPairKey // TypeDefIndex: 11428
{
	// Fields
	public uint ascii_Left; // 0x0
	public uint ascii_Right; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x219C710 Offset: 0x219AD10 VA: 0x18219C710
	public void .ctor(uint ascii_left, uint ascii_right) { }
}

// Namespace: TMPro
[Serializable]
public struct GlyphValueRecord_Legacy // TypeDefIndex: 11429
{
	// Fields
	public float xPlacement; // 0x0
	public float yPlacement; // 0x4
	public float xAdvance; // 0x8
	public float yAdvance; // 0xC

	// Methods

	// RVA: 0x219C6B0 Offset: 0x219ACB0 VA: 0x18219C6B0
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x18151A0 Offset: 0x18137A0 VA: 0x1818151A0
	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }
}

// Namespace: TMPro
[Serializable]
public class KerningPair // TypeDefIndex: 11430
{
	// Fields
	[FormerlySerializedAs("AscII_Left")]
	[SerializeField]
	private uint m_FirstGlyph; // 0x10
	[SerializeField]
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAs("AscII_Right")]
	[SerializeField]
	private uint m_SecondGlyph; // 0x24
	[SerializeField]
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAs("XadvanceOffset")]
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField]
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public uint get_firstGlyph() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_firstGlyph(uint value) { }

	// RVA: 0x87AB30 Offset: 0x879130 VA: 0x18087AB30
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public uint get_secondGlyph() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_secondGlyph(uint value) { }

	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x9E9940 Offset: 0x9E7F40 VA: 0x1809E9940
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x219C880 Offset: 0x219AE80 VA: 0x18219C880
	public void .ctor() { }

	// RVA: 0x219C7D0 Offset: 0x219ADD0 VA: 0x18219C7D0
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x219C820 Offset: 0x219AE20 VA: 0x18219C820
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x219C730 Offset: 0x219AD30 VA: 0x18219C730
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x219C740 Offset: 0x219AD40 VA: 0x18219C740
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class KerningTable // TypeDefIndex: 11435
{
	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0x219D080 Offset: 0x219B680 VA: 0x18219D080
	public void .ctor() { }

	// RVA: 0x219CB80 Offset: 0x219B180 VA: 0x18219CB80
	public void AddKerningPair() { }

	// RVA: 0x219CA20 Offset: 0x219B020 VA: 0x18219CA20
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0x219C8B0 Offset: 0x219AEB0 VA: 0x18219C8B0
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0x219CCD0 Offset: 0x219B2D0 VA: 0x18219CCD0
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0x219CDE0 Offset: 0x219B3E0 VA: 0x18219CDE0
	public void RemoveKerningPair(int index) { }

	// RVA: 0x219CE40 Offset: 0x219B440 VA: 0x18219CE40
	public void SortKerningPairs() { }
}

// Namespace: TMPro
public static class TMP_FontUtilities // TypeDefIndex: 11436
{
	// Fields
	private static List<int> k_searchedFontAssets; // 0x0

	// Methods

	// RVA: 0x219F290 Offset: 0x219D890 VA: 0x18219F290
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x219F1A0 Offset: 0x219D7A0 VA: 0x18219F1A0
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0x219EDF0 Offset: 0x219D3F0 VA: 0x18219EDF0
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x219F0B0 Offset: 0x219D6B0 VA: 0x18219F0B0
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }
}

// Namespace: TMPro
public class TMP_FontAssetUtilities // TypeDefIndex: 11437
{
	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static HashSet<int> k_SearchedAssets; // 0x8

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0x219E400 Offset: 0x219CA00 VA: 0x18219E400
	private static void .cctor() { }

	// RVA: 0x219E470 Offset: 0x219CA70 VA: 0x18219E470
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0x219D5D0 Offset: 0x219BBD0 VA: 0x18219D5D0
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x219D100 Offset: 0x219B700 VA: 0x18219D100
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x219D760 Offset: 0x219BD60 VA: 0x18219D760
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x219DEE0 Offset: 0x219C4E0 VA: 0x18219DEE0
	internal static TMP_TextElement GetTextElementFromTextAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_Asset> textAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x219DBA0 Offset: 0x219C1A0 VA: 0x18219DBA0
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x219D9C0 Offset: 0x219BFC0 VA: 0x18219D9C0
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: TMPro
[Flags]
public enum FontFeatureLookupFlags // TypeDefIndex: 11438
{
	// Fields
	public int value__; // 0x0
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphValueRecord // TypeDefIndex: 11439
{
	// Fields
	[SerializeField]
	internal float m_XPlacement; // 0x0
	[SerializeField]
	internal float m_YPlacement; // 0x4
	[SerializeField]
	internal float m_XAdvance; // 0x8
	[SerializeField]
	internal float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_xPlacement() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_xPlacement(float value) { }

	// RVA: 0xD32860 Offset: 0xD30E60 VA: 0x180D32860
	public float get_yPlacement() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_yPlacement(float value) { }

	// RVA: 0x1105EF0 Offset: 0x11044F0 VA: 0x181105EF0
	public float get_xAdvance() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_xAdvance(float value) { }

	// RVA: 0x19477A0 Offset: 0x1945DA0 VA: 0x1819477A0
	public float get_yAdvance() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_yAdvance(float value) { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x1F7DBD0 Offset: 0x1F7C1D0 VA: 0x181F7DBD0
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x219C6B0 Offset: 0x219ACB0 VA: 0x18219C6B0
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x219F6A0 Offset: 0x219DCA0 VA: 0x18219F6A0
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 11440
{
	// Fields
	[SerializeField]
	internal uint m_GlyphIndex; // 0x0
	[SerializeField]
	internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public uint get_glyphIndex() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_glyphIndex(uint value) { }

	// RVA: 0xD32870 Offset: 0xD30E70 VA: 0x180D32870
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0xD32910 Offset: 0xD30F10 VA: 0x180D32910
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x11057E0 Offset: 0x1103DE0 VA: 0x1811057E0
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x219F390 Offset: 0x219D990 VA: 0x18219F390
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 11441
{
	// Fields
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0xE96B90 Offset: 0xE95190 VA: 0x180E96B90
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x219F680 Offset: 0x219DC80 VA: 0x18219F680
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x219F660 Offset: 0x219DC60 VA: 0x18219F660
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x219F690 Offset: 0x219DC90 VA: 0x18219F690
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0x219F460 Offset: 0x219DA60 VA: 0x18219F460
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0x219F4B0 Offset: 0x219DAB0 VA: 0x18219F4B0
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }
}

// Namespace: TMPro
public struct GlyphPairKey // TypeDefIndex: 11442
{
	// Fields
	public uint firstGlyphIndex; // 0x0
	public uint secondGlyphIndex; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x219C660 Offset: 0x219AC60 VA: 0x18219C660
	public void .ctor(uint firstGlyphIndex, uint secondGlyphIndex) { }

	// RVA: 0x219C680 Offset: 0x219AC80 VA: 0x18219C680
	internal void .ctor(TMP_GlyphPairAdjustmentRecord record) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_FontFeatureTable // TypeDefIndex: 11444
{
	// Fields
	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Properties
	public List<MultipleSubstitutionRecord> multipleSubstitutionRecords { get; set; }
	public List<LigatureSubstitutionRecord> ligatureRecords { get; set; }
	public List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }
	public List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords { get; set; }
	public List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public List<MultipleSubstitutionRecord> get_multipleSubstitutionRecords() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_multipleSubstitutionRecords(List<MultipleSubstitutionRecord> value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<LigatureSubstitutionRecord> get_ligatureRecords() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_ligatureRecords(List<LigatureSubstitutionRecord> value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_glyphPairAdjustmentRecords(List<GlyphPairAdjustmentRecord> value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_MarkToBaseAdjustmentRecords(List<MarkToBaseAdjustmentRecord> value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_MarkToMarkAdjustmentRecords(List<MarkToMarkAdjustmentRecord> value) { }

	// RVA: 0x219EB80 Offset: 0x219D180 VA: 0x18219EB80
	public void .ctor() { }

	// RVA: 0x219E4C0 Offset: 0x219CAC0 VA: 0x18219E4C0
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x219E700 Offset: 0x219CD00 VA: 0x18219E700
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x219E940 Offset: 0x219CF40 VA: 0x18219E940
	public void SortMarkToMarkAdjustmentRecords() { }
}

// Namespace: TMPro
[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.2")]
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICancelHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 11458
{
	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDevice; // 0x8
	protected RectTransform m_RectTransform; // 0x108
	[SerializeField]
	protected RectTransform m_TextViewport; // 0x110
	protected RectMask2D m_TextComponentRectMask; // 0x118
	protected RectMask2D m_TextViewportRectMask; // 0x120
	[SerializeField]
	protected TMP_Text m_TextComponent; // 0x128
	protected RectTransform m_TextComponentRectTransform; // 0x130
	[SerializeField]
	protected Graphic m_Placeholder; // 0x138
	[SerializeField]
	protected Scrollbar m_VerticalScrollbar; // 0x140
	[SerializeField]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x148
	private bool m_IsDrivenByLayoutComponents; // 0x150
	[SerializeField]
	private LayoutGroup m_LayoutGroup; // 0x158
	private IScrollHandler m_IScrollHandlerParent; // 0x160
	private float m_ScrollPosition; // 0x168
	[SerializeField]
	protected float m_ScrollSensitivity; // 0x16C
	[SerializeField]
	private TMP_InputField.ContentType m_ContentType; // 0x170
	[SerializeField]
	private TMP_InputField.InputType m_InputType; // 0x174
	[SerializeField]
	private char m_AsteriskChar; // 0x178
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x17C
	[SerializeField]
	private TMP_InputField.LineType m_LineType; // 0x180
	[SerializeField]
	private bool m_HideMobileInput; // 0x184
	[SerializeField]
	private bool m_HideSoftKeyboard; // 0x185
	[SerializeField]
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x188
	[SerializeField]
	private string m_RegexValue; // 0x190
	[SerializeField]
	private float m_GlobalPointSize; // 0x198
	[SerializeField]
	private int m_CharacterLimit; // 0x19C
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x1A0
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x1A8
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x1B0
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x1B8
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x1C0
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x1C8
	[SerializeField]
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x1D0
	[SerializeField]
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x1D8
	[SerializeField]
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x1E0
	[SerializeField]
	private Color m_CaretColor; // 0x1E8
	[SerializeField]
	private bool m_CustomCaretColor; // 0x1F8
	[SerializeField]
	private Color m_SelectionColor; // 0x1FC
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_Text; // 0x210
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x218
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x21C
	[SerializeField]
	private bool m_ReadOnly; // 0x220
	[SerializeField]
	private bool m_RichText; // 0x221
	protected int m_StringPosition; // 0x224
	protected int m_StringSelectPosition; // 0x228
	protected int m_CaretPosition; // 0x22C
	protected int m_CaretSelectPosition; // 0x230
	private RectTransform caretRectTrans; // 0x238
	protected UIVertex[] m_CursorVerts; // 0x240
	private CanvasRenderer m_CachedInputRenderer; // 0x248
	private Vector2 m_LastPosition; // 0x250
	protected Mesh m_Mesh; // 0x258
	private bool m_AllowInput; // 0x260
	private bool m_ShouldActivateNextUpdate; // 0x261
	private bool m_UpdateDrag; // 0x262
	private bool m_DragPositionOutOfBounds; // 0x263
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x264
	private Coroutine m_BlinkCoroutine; // 0x268
	private float m_BlinkStartTime; // 0x270
	private Coroutine m_DragCoroutine; // 0x278
	private string m_OriginalText; // 0x280
	private bool m_WasCanceled; // 0x288
	private bool m_HasDoneFocusTransition; // 0x289
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x290
	private bool m_PreventCallback; // 0x298
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x299
	private bool m_IsTextComponentUpdateRequired; // 0x29A
	private bool m_HasTextBeenRemoved; // 0x29B
	private float m_PointerDownClickStartTime; // 0x29C
	private float m_KeyDownStartTime; // 0x2A0
	private float m_DoubleClickDelay; // 0x2A4
	private bool m_IsApplePlatform; // 0x2A8
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private bool m_IsCompositionActive; // 0x2A9
	private bool m_ShouldUpdateIMEWindowPosition; // 0x2AA
	private int m_PreviousIMEInsertionLine; // 0x2AC
	[SerializeField]
	protected TMP_FontAsset m_GlobalFontAsset; // 0x2B0
	[SerializeField]
	protected bool m_OnFocusSelectAll; // 0x2B8
	protected bool m_isSelectAll; // 0x2B9
	[SerializeField]
	protected bool m_ResetOnDeActivation; // 0x2BA
	private bool m_SelectionStillActive; // 0x2BB
	private bool m_ReleaseSelection; // 0x2BC
	private KeyCode m_LastKeyCode; // 0x2C0
	private GameObject m_PreviouslySelectedObject; // 0x2C8
	[SerializeField]
	private bool m_KeepTextSelectionVisible; // 0x2D0
	[SerializeField]
	private bool m_RestoreOriginalTextOnEscape; // 0x2D1
	[SerializeField]
	protected bool m_isRichTextEditingAllowed; // 0x2D2
	[SerializeField]
	protected int m_LineLimit; // 0x2D4
	public bool isAlert; // 0x2D8
	[SerializeField]
	protected TMP_InputValidator m_InputValidator; // 0x2E0
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x2E8
	private bool m_isSelected; // 0x2E9
	private bool m_IsStringPositionDirty; // 0x2EA
	private bool m_IsCaretPositionDirty; // 0x2EB
	private bool m_forceRectTransformAdjustment; // 0x2EC
	private bool m_IsKeyboardBeingClosedInHoloLens; // 0x2ED
	private Event m_ProcessingEvent; // 0x2F0

	// Properties
	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	private int compositionLength { get; }
	protected Mesh mesh { get; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool keepTextSelectionVisible { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x21ADFF0 Offset: 0x21AC5F0 VA: 0x1821ADFF0
	private BaseInput get_inputSystem() { }

	// RVA: 0x21ADE70 Offset: 0x21AC470 VA: 0x1821ADE70
	private string get_compositionString() { }

	// RVA: 0x21ADE40 Offset: 0x21AC440 VA: 0x1821ADE40
	private int get_compositionLength() { }

	// RVA: 0x21AD9C0 Offset: 0x21ABFC0 VA: 0x1821AD9C0
	protected void .ctor() { }

	// RVA: 0x21AE160 Offset: 0x21AC760 VA: 0x1821AE160
	protected Mesh get_mesh() { }

	// RVA: 0x21AFC70 Offset: 0x21AE270 VA: 0x1821AFC70 Slot: 61
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x21AE680 Offset: 0x21ACC80 VA: 0x1821AE680 Slot: 62
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x21AE6E0 Offset: 0x21ACCE0 VA: 0x1821AE6E0
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x21AFC80 Offset: 0x21AE280 VA: 0x1821AFC80
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x21AE750 Offset: 0x21ACD50 VA: 0x1821AE750
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0x21AFD20 Offset: 0x21AE320 VA: 0x1821AFD20
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0x21AE800 Offset: 0x21ACE00 VA: 0x1821AE800
	private bool isKeyboardUsingEvents() { }

	// RVA: 0x21AE8F0 Offset: 0x21ACEF0 VA: 0x1821AE8F0
	private bool isUWP() { }

	// RVA: 0x21AE7E0 Offset: 0x21ACDE0 VA: 0x1821AE7E0
	public string get_text() { }

	// RVA: 0x21B0080 Offset: 0x21AE680 VA: 0x1821B0080
	public void set_text(string value) { }

	// RVA: 0x21AC010 Offset: 0x21AA610 VA: 0x1821AC010
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x21AC020 Offset: 0x21AA620 VA: 0x1821AC020
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x21AE110 Offset: 0x21AC710 VA: 0x1821AE110
	public bool get_isFocused() { }

	// RVA: 0x21ADD10 Offset: 0x21AC310 VA: 0x1821ADD10
	public float get_caretBlinkRate() { }

	// RVA: 0x21AE9E0 Offset: 0x21ACFE0 VA: 0x1821AE9E0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1AA3FA0 Offset: 0x1AA25A0 VA: 0x181AA3FA0
	public int get_caretWidth() { }

	// RVA: 0x21AEBA0 Offset: 0x21AD1A0 VA: 0x1821AEBA0
	public void set_caretWidth(int value) { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	public RectTransform get_textViewport() { }

	// RVA: 0x21B0030 Offset: 0x21AE630 VA: 0x1821B0030
	public void set_textViewport(RectTransform value) { }

	// RVA: 0x19DB6F0 Offset: 0x19D9CF0 VA: 0x1819DB6F0
	public TMP_Text get_textComponent() { }

	// RVA: 0x21AFFD0 Offset: 0x21AE5D0 VA: 0x1821AFFD0
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	public Graphic get_placeholder() { }

	// RVA: 0x21AF710 Offset: 0x21ADD10 VA: 0x1821AF710
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x21B0090 Offset: 0x21AE690 VA: 0x1821B0090
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x21AE5E0 Offset: 0x21ACBE0 VA: 0x1821AE5E0
	public float get_scrollSensitivity() { }

	// RVA: 0x21AF990 Offset: 0x21ADF90 VA: 0x1821AF990
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x21ADD20 Offset: 0x21AC320 VA: 0x1821ADD20
	public Color get_caretColor() { }

	// RVA: 0x21AEA50 Offset: 0x21AD050 VA: 0x1821AEA50
	public void set_caretColor(Color value) { }

	// RVA: 0x21ADF30 Offset: 0x21AC530 VA: 0x1821ADF30
	public bool get_customCaretColor() { }

	// RVA: 0x21AEFD0 Offset: 0x21AD5D0 VA: 0x1821AEFD0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x21AE5F0 Offset: 0x21ACBF0 VA: 0x1821AE5F0
	public Color get_selectionColor() { }

	// RVA: 0x21AFA80 Offset: 0x21AE080 VA: 0x1821AFA80
	public void set_selectionColor(Color value) { }

	// RVA: 0x21AE230 Offset: 0x21AC830 VA: 0x1821AE230
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x21AF480 Offset: 0x21ADA80 VA: 0x1821AF480
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x21AE270 Offset: 0x21AC870 VA: 0x1821AE270
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x21AF580 Offset: 0x21ADB80 VA: 0x1821AF580
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x21AE260 Offset: 0x21AC860 VA: 0x1821AE260
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0x21AF530 Offset: 0x21ADB30 VA: 0x1821AF530
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x1BE7A30 Offset: 0x1BE6030 VA: 0x181BE7A30
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0x21AF430 Offset: 0x21ADA30 VA: 0x1821AF430
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x21AE280 Offset: 0x21AC880 VA: 0x1821AE280
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0x21AF5D0 Offset: 0x21ADBD0 VA: 0x1821AF5D0
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x21AE240 Offset: 0x21AC840 VA: 0x1821AE240
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0x21AF4D0 Offset: 0x21ADAD0 VA: 0x1821AF4D0
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x21AE2B0 Offset: 0x21AC8B0 VA: 0x1821AE2B0
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x21AF6C0 Offset: 0x21ADCC0 VA: 0x1821AF6C0
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0x21AE290 Offset: 0x21AC890 VA: 0x1821AE290
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x21AF620 Offset: 0x21ADC20 VA: 0x1821AF620
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0x21AE2A0 Offset: 0x21AC8A0 VA: 0x1821AE2A0
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x21AF670 Offset: 0x21ADC70 VA: 0x1821AF670
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0x37EAC0 Offset: 0x37D0C0 VA: 0x18037EAC0
	public int get_characterLimit() { }

	// RVA: 0x21AEC30 Offset: 0x21AD230 VA: 0x1821AEC30
	public void set_characterLimit(int value) { }

	// RVA: 0x1791B30 Offset: 0x1790130 VA: 0x181791B30
	public float get_pointSize() { }

	// RVA: 0x21AF760 Offset: 0x21ADD60 VA: 0x1821AF760
	public void set_pointSize(float value) { }

	// RVA: 0x21ADF50 Offset: 0x21AC550 VA: 0x1821ADF50
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x21AF030 Offset: 0x21AD630 VA: 0x1821AF030
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x21AE250 Offset: 0x21AC850 VA: 0x1821AE250
	public bool get_onFocusSelectAll() { }

	// RVA: 0x21AF520 Offset: 0x21ADB20 VA: 0x1821AF520
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0x21AE5B0 Offset: 0x21ACBB0 VA: 0x1821AE5B0
	public bool get_resetOnDeActivation() { }

	// RVA: 0x21AF8E0 Offset: 0x21ADEE0 VA: 0x1821AF8E0
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0x21AE130 Offset: 0x21AC730 VA: 0x1821AE130
	public bool get_keepTextSelectionVisible() { }

	// RVA: 0x21AF260 Offset: 0x21AD860 VA: 0x1821AF260
	public void set_keepTextSelectionVisible(bool value) { }

	// RVA: 0x21AE5C0 Offset: 0x21ACBC0 VA: 0x1821AE5C0
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0x21AF8F0 Offset: 0x21ADEF0 VA: 0x1821AF8F0
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0x21AE120 Offset: 0x21AC720 VA: 0x1821AE120
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0x21AF250 Offset: 0x21AD850 VA: 0x1821AF250
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0x21ADF20 Offset: 0x21AC520 VA: 0x1821ADF20
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0x21AEDA0 Offset: 0x21AD3A0 VA: 0x1821AEDA0
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x37EAF0 Offset: 0x37D0F0 VA: 0x18037EAF0
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0x21AF350 Offset: 0x21AD950 VA: 0x1821AF350
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0x21AE150 Offset: 0x21AC750 VA: 0x1821AE150
	public int get_lineLimit() { }

	// RVA: 0x21AF2E0 Offset: 0x21AD8E0 VA: 0x1821AF2E0
	public void set_lineLimit(int value) { }

	// RVA: 0x21AE0F0 Offset: 0x21AC6F0 VA: 0x1821AE0F0
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0x21AF170 Offset: 0x21AD770 VA: 0x1821AF170
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x21AE140 Offset: 0x21AC740 VA: 0x1821AE140
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x21AF270 Offset: 0x21AD870 VA: 0x1821AF270
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x16C1A70 Offset: 0x16C0070 VA: 0x1816C1A70
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x21AECE0 Offset: 0x21AD2E0 VA: 0x1821AECE0
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0x21AE100 Offset: 0x21AC700 VA: 0x1821AE100
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0x21AF1E0 Offset: 0x21AD7E0 VA: 0x1821AF1E0
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0x21AE5A0 Offset: 0x21ACBA0 VA: 0x1821AE5A0
	public bool get_readOnly() { }

	// RVA: 0x21AF8D0 Offset: 0x21ADED0 VA: 0x1821AF8D0
	public void set_readOnly(bool value) { }

	// RVA: 0x21AE5D0 Offset: 0x21ACBD0 VA: 0x1821AE5D0
	public bool get_richText() { }

	// RVA: 0x21AF900 Offset: 0x21ADF00 VA: 0x1821AF900
	public void set_richText(bool value) { }

	// RVA: 0x21AE210 Offset: 0x21AC810 VA: 0x1821AE210
	public bool get_multiLine() { }

	// RVA: 0x21ADD00 Offset: 0x21AC300 VA: 0x1821ADD00
	public char get_asteriskChar() { }

	// RVA: 0x21AE980 Offset: 0x21ACF80 VA: 0x1821AE980
	public void set_asteriskChar(char value) { }

	// RVA: 0x21AE7F0 Offset: 0x21ACDF0 VA: 0x1821AE7F0
	public bool get_wasCanceled() { }

	// RVA: 0x21A1B00 Offset: 0x21A0100 VA: 0x1821A1B00
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0x21A1A80 Offset: 0x21A0080 VA: 0x1821A1A80
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0x21A1A70 Offset: 0x21A0070 VA: 0x1821A1A70
	private int ClampArrayIndex(int index) { }

	// RVA: 0x21ADD80 Offset: 0x21AC380 VA: 0x1821ADD80
	protected int get_caretPositionInternal() { }

	// RVA: 0x21AEAC0 Offset: 0x21AD0C0 VA: 0x1821AEAC0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x21AE600 Offset: 0x21ACC00 VA: 0x1821AE600
	protected int get_stringPositionInternal() { }

	// RVA: 0x21AFE50 Offset: 0x21AE450 VA: 0x1821AFE50
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0x21ADDC0 Offset: 0x21AC3C0 VA: 0x1821ADDC0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x21AEB80 Offset: 0x21AD180 VA: 0x1821AEB80
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x21AE640 Offset: 0x21ACC40 VA: 0x1821AE640
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0x21AFF80 Offset: 0x21AE580 VA: 0x1821AFF80
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0x21ADF60 Offset: 0x21AC560 VA: 0x1821ADF60
	private bool get_hasSelection() { }

	// RVA: 0x21ADDC0 Offset: 0x21AC3C0 VA: 0x1821ADDC0
	public int get_caretPosition() { }

	// RVA: 0x21AEAE0 Offset: 0x21AD0E0 VA: 0x1821AEAE0
	public void set_caretPosition(int value) { }

	// RVA: 0x21ADD80 Offset: 0x21AC380 VA: 0x1821ADD80
	public int get_selectionAnchorPosition() { }

	// RVA: 0x21AFA20 Offset: 0x21AE020 VA: 0x1821AFA20
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x21ADDC0 Offset: 0x21AC3C0 VA: 0x1821ADDC0
	public int get_selectionFocusPosition() { }

	// RVA: 0x21AFAF0 Offset: 0x21AE0F0 VA: 0x1821AFAF0
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x21AE640 Offset: 0x21ACC40 VA: 0x1821AE640
	public int get_stringPosition() { }

	// RVA: 0x21AFEA0 Offset: 0x21AE4A0 VA: 0x1821AFEA0
	public void set_stringPosition(int value) { }

	// RVA: 0x21AE600 Offset: 0x21ACC00 VA: 0x1821AE600
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0x21AFB50 Offset: 0x21AE150 VA: 0x1821AFB50
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0x21AE640 Offset: 0x21ACC40 VA: 0x1821AE640
	public int get_selectionStringFocusPosition() { }

	// RVA: 0x21AFBE0 Offset: 0x21AE1E0 VA: 0x1821AFBE0
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0x21A9280 Offset: 0x21A7880 VA: 0x1821A9280 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x21A8A10 Offset: 0x21A7010 VA: 0x1821A8A10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x21A86F0 Offset: 0x21A6CF0 VA: 0x1821A86F0
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachine(typeof(TMP_InputField.<CaretBlink>d__293))]
	// RVA: 0x21A1A00 Offset: 0x21A0000 VA: 0x1821A1A00
	private IEnumerator CaretBlink() { }

	// RVA: 0x21ABCB0 Offset: 0x21AA2B0 VA: 0x1821ABCB0
	private void SetCaretVisible() { }

	// RVA: 0x21ABBE0 Offset: 0x21AA1E0 VA: 0x1821ABBE0
	private void SetCaretActive() { }

	// RVA: 0x21A9E00 Offset: 0x21A8400 VA: 0x1821A9E00
	protected void OnFocus() { }

	// RVA: 0x21AB6C0 Offset: 0x21A9CC0 VA: 0x1821AB6C0
	protected void SelectAll() { }

	// RVA: 0x21A7B70 Offset: 0x21A6170 VA: 0x1821A7B70
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x21A7D60 Offset: 0x21A6360 VA: 0x1821A7D60
	public void MoveTextStart(bool shift) { }

	// RVA: 0x21A7EC0 Offset: 0x21A64C0 VA: 0x1821A7EC0
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0x21A8160 Offset: 0x21A6760 VA: 0x1821A8160
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0x21ADE00 Offset: 0x21AC400 VA: 0x1821ADE00
	private static string get_clipboard() { }

	// RVA: 0x21AED50 Offset: 0x21AD350 VA: 0x1821AED50
	private static void set_clipboard(string value) { }

	// RVA: 0x21A4830 Offset: 0x21A2E30 VA: 0x1821A4830
	private bool InPlaceEditing() { }

	// RVA: 0x21A47B0 Offset: 0x21A2DB0 VA: 0x1821A47B0
	private bool InPlaceEditingChanged() { }

	// RVA: 0x21AC220 Offset: 0x21AA820 VA: 0x1821AC220
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x21AC560 Offset: 0x21AAB60 VA: 0x1821AC560
	private void UpdateKeyboardStringPosition() { }

	// RVA: 0x21ACE80 Offset: 0x21AB480 VA: 0x1821ACE80
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x21A4F10 Offset: 0x21A3510 VA: 0x1821A4F10 Slot: 63
	protected virtual void LateUpdate() { }

	// RVA: 0x21A5F00 Offset: 0x21A4500 VA: 0x1821A5F00
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x21A88D0 Offset: 0x21A6ED0 VA: 0x1821A88D0 Slot: 64
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x21A8D80 Offset: 0x21A7380 VA: 0x1821A8D80 Slot: 65
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(TMP_InputField.<MouseDragOutsideRect>d__314))]
	// RVA: 0x21A5FF0 Offset: 0x21A45F0 VA: 0x1821A5FF0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x21A9B20 Offset: 0x21A8120 VA: 0x1821A9B20 Slot: 66
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x21A9E70 Offset: 0x21A8470 VA: 0x1821A9E70 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x21A4A50 Offset: 0x21A3050 VA: 0x1821A4A50
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x21A4A30 Offset: 0x21A3030 VA: 0x1821A4A30 Slot: 67
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0x21AB520 Offset: 0x21A9B20 VA: 0x1821AB520
	public void ProcessEvent(Event e) { }

	// RVA: 0x21AABF0 Offset: 0x21A91F0 VA: 0x1821AABF0 Slot: 68
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x21AA830 Offset: 0x21A8E30 VA: 0x1821AA830 Slot: 69
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x21A4480 Offset: 0x21A2A80 VA: 0x1821A4480
	private float GetScrollPositionRelativeToViewport() { }

	// RVA: 0x21A4620 Offset: 0x21A2C20 VA: 0x1821A4620
	private string GetSelectedString() { }

	// RVA: 0x21A2930 Offset: 0x21A0F30 VA: 0x1821A2930
	private int FindNextWordBegin() { }

	// RVA: 0x21A7330 Offset: 0x21A5930 VA: 0x1821A7330
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x21A2A50 Offset: 0x21A1050 VA: 0x1821A2A50
	private int FindPrevWordBegin() { }

	// RVA: 0x21A6350 Offset: 0x21A4950 VA: 0x1821A6350
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x21A5C10 Offset: 0x21A4210 VA: 0x1821A5C10
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x21A5930 Offset: 0x21A3F30 VA: 0x1821A5930
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x21AB1B0 Offset: 0x21A97B0 VA: 0x1821AB1B0
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x21AADD0 Offset: 0x21A93D0 VA: 0x1821AADD0
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x21A6340 Offset: 0x21A4940 VA: 0x1821A6340
	private void MoveDown(bool shift) { }

	// RVA: 0x21A6080 Offset: 0x21A4680 VA: 0x1821A6080
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x21A8440 Offset: 0x21A6A40 VA: 0x1821A8440
	private void MoveUp(bool shift) { }

	// RVA: 0x21A8450 Offset: 0x21A6A50 VA: 0x1821A8450
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x21A7320 Offset: 0x21A5920 VA: 0x1821A7320
	private void MovePageUp(bool shift) { }

	// RVA: 0x21A6F00 Offset: 0x21A5500 VA: 0x1821A6F00
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x21A6EF0 Offset: 0x21A54F0 VA: 0x1821A6EF0
	private void MovePageDown(bool shift) { }

	// RVA: 0x21A6AB0 Offset: 0x21A50B0 VA: 0x1821A6AB0
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0x21A2340 Offset: 0x21A0940 VA: 0x1821A2340
	private void Delete() { }

	// RVA: 0x21A1F70 Offset: 0x21A0570 VA: 0x1821A1F70
	private void DeleteKey() { }

	// RVA: 0x21A1530 Offset: 0x219FB30 VA: 0x1821A1530
	private void Backspace() { }

	// RVA: 0x21A0780 Offset: 0x219ED80 VA: 0x1821A0780 Slot: 70
	protected virtual void Append(string input) { }

	// RVA: 0x21A0830 Offset: 0x219EE30 VA: 0x1821A0830 Slot: 71
	protected virtual void Append(char input) { }

	// RVA: 0x21A48B0 Offset: 0x21A2EB0 VA: 0x1821A48B0
	private void Insert(char c) { }

	// RVA: 0x21AD070 Offset: 0x21AB670 VA: 0x1821AD070
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x21ABAB0 Offset: 0x21AA0B0 VA: 0x1821ABAB0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x21ABB10 Offset: 0x21AA110 VA: 0x1821ABB10
	private void SendOnValueChanged() { }

	// RVA: 0x21AB740 Offset: 0x21A9D40 VA: 0x1821AB740
	protected void SendOnEndEdit() { }

	// RVA: 0x21AB960 Offset: 0x21A9F60 VA: 0x1821AB960
	protected void SendOnSubmit() { }

	// RVA: 0x21AB900 Offset: 0x21A9F00 VA: 0x1821AB900
	protected void SendOnFocus() { }

	// RVA: 0x21AB8A0 Offset: 0x21A9EA0 VA: 0x1821AB8A0
	protected void SendOnFocusLost() { }

	// RVA: 0x21AB9C0 Offset: 0x21A9FC0 VA: 0x1821AB9C0
	protected void SendOnTextSelection() { }

	// RVA: 0x21AB7A0 Offset: 0x21A9DA0 VA: 0x1821AB7A0
	protected void SendOnEndTextSelection() { }

	// RVA: 0x21ABB70 Offset: 0x21AA170 VA: 0x1821ABB70
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x21AC720 Offset: 0x21AAD20 VA: 0x1821AC720
	protected void UpdateLabel() { }

	// RVA: 0x21ACCC0 Offset: 0x21AB2C0 VA: 0x1821ACCC0
	private void UpdateScrollbar() { }

	// RVA: 0x21AAA60 Offset: 0x21A9060 VA: 0x1821AAA60
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void UpdateMaskRegions() { }

	// RVA: 0x21A0520 Offset: 0x219EB20 VA: 0x1821A0520
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0x21A42D0 Offset: 0x21A28D0 VA: 0x1821A42D0
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x21A4380 Offset: 0x21A2980 VA: 0x1821A4380
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x21A42D0 Offset: 0x21A28D0 VA: 0x1821A42D0
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x21A4700 Offset: 0x21A2D00 VA: 0x1821A4700
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0x21ACDB0 Offset: 0x21AB3B0 VA: 0x1821ACDB0
	private void UpdateStringIndexFromCaretPosition() { }

	// RVA: 0x21AC2D0 Offset: 0x21AA8D0 VA: 0x1821AC2D0
	private void UpdateCaretPositionFromStringIndex() { }

	// RVA: 0x21A2B50 Offset: 0x21A1150 VA: 0x1821A2B50
	public void ForceLabelUpdate() { }

	// RVA: 0x21A5EB0 Offset: 0x21A44B0 VA: 0x1821A5EB0
	private void MarkGeometryAsDirty() { }

	// RVA: 0x21AB530 Offset: 0x21A9B30 VA: 0x1821AB530 Slot: 72
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 73
	public virtual void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 74
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x21AC4A0 Offset: 0x21AAAA0 VA: 0x1821AC4A0
	private void UpdateGeometry() { }

	// RVA: 0x21A0E00 Offset: 0x219F400 VA: 0x1821A0E00
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x21A9B50 Offset: 0x21A8150 VA: 0x1821A9B50
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x21A2B60 Offset: 0x21A1160 VA: 0x1821A2B60
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x21A1B40 Offset: 0x21A0140 VA: 0x1821A1B40
	private void CreateCursorVerts() { }

	// RVA: 0x21A38E0 Offset: 0x21A1EE0 VA: 0x1821A38E0
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x219FDA0 Offset: 0x219E3A0 VA: 0x18219FDA0
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0x21AD0C0 Offset: 0x21AB6C0 VA: 0x1821AD0C0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x219FC60 Offset: 0x219E260 VA: 0x18219FC60
	public void ActivateInputField() { }

	// RVA: 0x219F760 Offset: 0x219DD60 VA: 0x18219F760
	private void ActivateInputFieldInternal() { }

	// RVA: 0x21AAAA0 Offset: 0x21A90A0 VA: 0x1821AAAA0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x21A9E40 Offset: 0x21A8440 VA: 0x1821A9E40 Slot: 75
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void OnControlClick() { }

	// RVA: 0x21AB600 Offset: 0x21A9C00 VA: 0x1821AB600
	public void ReleaseSelection() { }

	// RVA: 0x21A1D00 Offset: 0x21A0300 VA: 0x1821A1D00
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0x21A8990 Offset: 0x21A6F90 VA: 0x1821A8990 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x21AAB20 Offset: 0x21A9120 VA: 0x1821AAB20 Slot: 76
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x21A8900 Offset: 0x21A6F00 VA: 0x1821A8900 Slot: 77
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x21A9E20 Offset: 0x21A8420 VA: 0x1821A9E20 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x21A2730 Offset: 0x21A0D30 VA: 0x1821A2730
	private void EnforceContentType() { }

	// RVA: 0x21ABF60 Offset: 0x21AA560 VA: 0x1821ABF60
	private void SetTextComponentWrapMode() { }

	// RVA: 0x21ABED0 Offset: 0x21AA4D0 VA: 0x1821ABED0
	private void SetTextComponentRichTextMode() { }

	// RVA: 0x21AC1A0 Offset: 0x21AA7A0 VA: 0x1821AC1A0
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x21AC200 Offset: 0x21AA800 VA: 0x1821AC200
	private void SetToCustom() { }

	// RVA: 0x21AC200 Offset: 0x21AA800 VA: 0x1821AC200
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0x21A2700 Offset: 0x21A0D00 VA: 0x1821A2700 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 78
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 79
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 80
	public virtual float get_minWidth() { }

	// RVA: 0x21AE430 Offset: 0x21ACA30 VA: 0x1821AE430 Slot: 81
	public virtual float get_preferredWidth() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 82
	public virtual float get_flexibleWidth() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 83
	public virtual float get_minHeight() { }

	// RVA: 0x21AE2C0 Offset: 0x21AC8C0 VA: 0x1821AE2C0 Slot: 84
	public virtual float get_preferredHeight() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 85
	public virtual float get_flexibleHeight() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 86
	public virtual int get_layoutPriority() { }

	// RVA: 0x21ABDE0 Offset: 0x21AA3E0 VA: 0x1821ABDE0
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0x21ABCF0 Offset: 0x21AA2F0 VA: 0x1821ABCF0
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x21AD920 Offset: 0x21ABF20 VA: 0x1821AD920
	private static void .cctor() { }

	// RVA: 0x21AC2C0 Offset: 0x21AA8C0 VA: 0x1821AC2C0 Slot: 47
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: TMPro
internal static class SetPropertyUtility // TypeDefIndex: 11459
{
	// Methods

	// RVA: 0x21CD7B0 Offset: 0x21CBDB0 VA: 0x1821CD7B0
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C850 Offset: 0x79AE50 VA: 0x18079C850
	|-SetPropertyUtility.SetEquatableStruct<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79CB80 Offset: 0x79B180 VA: 0x18079CB80
	|-SetPropertyUtility.SetStruct<bool>
	|
	|-RVA: 0x79CC10 Offset: 0x79B210 VA: 0x18079CC10
	|-SetPropertyUtility.SetStruct<char>
	|
	|-RVA: 0x79D6C0 Offset: 0x79BCC0 VA: 0x18079D6C0
	|-SetPropertyUtility.SetStruct<int>
	|
	|-RVA: 0x79D4A0 Offset: 0x79BAA0 VA: 0x18079D4A0
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0x79D920 Offset: 0x79BF20 VA: 0x18079D920
	|-SetPropertyUtility.SetStruct<float>
	|
	|-RVA: 0x79D050 Offset: 0x79B650 VA: 0x18079D050
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C7F0 Offset: 0x79ADF0 VA: 0x18079C7F0
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 11460
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract char Validate(ref string text, ref int pos, char ch);

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: TMPro
public struct TMP_LineInfo // TypeDefIndex: 11461
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int visibleSpaceCount; // 0x10
	public int wordCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharacterIndex; // 0x24
	public float length; // 0x28
	public float lineHeight; // 0x2C
	public float ascender; // 0x30
	public float baseline; // 0x34
	public float descender; // 0x38
	public float maxAdvance; // 0x3C
	public float width; // 0x40
	public float marginLeft; // 0x44
	public float marginRight; // 0x48
	public HorizontalAlignmentOptions alignment; // 0x4C
	public Extents lineExtents; // 0x50
}

// Namespace: TMPro
internal static class TMP_ListPool<T> // TypeDefIndex: 11463
{
	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C3AF0 Offset: 0x9C20F0 VA: 0x1809C3AF0
	|-TMP_ListPool<object>.Get
	|
	|-RVA: 0x9C39E0 Offset: 0x9C1FE0 VA: 0x1809C39E0
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C3C90 Offset: 0x9C2290 VA: 0x1809C3C90
	|-TMP_ListPool<object>.Release
	|
	|-RVA: 0x9C3EB0 Offset: 0x9C24B0 VA: 0x1809C3EB0
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C3FD0 Offset: 0x9C25D0 VA: 0x1809C3FD0
	|-TMP_ListPool<object>..cctor
	|
	|-RVA: 0x9C4290 Offset: 0x9C2890 VA: 0x1809C4290
	|-TMP_ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: TMPro
public static class TMP_MaterialManager // TypeDefIndex: 11470
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x21D3C70 Offset: 0x21D2270 VA: 0x1821D3C70
	private static void .cctor() { }

	// RVA: 0x21D2E70 Offset: 0x21D1470 VA: 0x1821D2E70
	private static void OnPreRender() { }

	// RVA: 0x21D2A80 Offset: 0x21D1080 VA: 0x1821D2A80
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x21D3610 Offset: 0x21D1C10 VA: 0x1821D3610
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x21D1AB0 Offset: 0x21D00B0 VA: 0x1821D1AB0
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x21D3B80 Offset: 0x21D2180 VA: 0x1821D3B80
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x21D0F70 Offset: 0x21CF570 VA: 0x1821D0F70
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x21D3A20 Offset: 0x21D2020 VA: 0x1821D3A20
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x21D2EF0 Offset: 0x21D14F0 VA: 0x1821D2EF0
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x21D1450 Offset: 0x21CFA50 VA: 0x1821D1450
	public static void ClearMaterials() { }

	// RVA: 0x21D2680 Offset: 0x21D0C80 VA: 0x1821D2680
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x21D2470 Offset: 0x21D0A70 VA: 0x1821D2470
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x21D1930 Offset: 0x21CFF30 VA: 0x1821D1930
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x21D2120 Offset: 0x21D0720 VA: 0x1821D2120
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x21D1C30 Offset: 0x21D0230 VA: 0x1821D1C30
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x21D0E30 Offset: 0x21CF430 VA: 0x1821D0E30
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x21D3870 Offset: 0x21D1E70 VA: 0x1821D3870
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x21D11F0 Offset: 0x21CF7F0 VA: 0x1821D11F0
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x21D3430 Offset: 0x21D1A30 VA: 0x1821D3430
	public static void ReleaseFallbackMaterial(Material fallbackMaterial) { }

	// RVA: 0x21D1640 Offset: 0x21CFC40 VA: 0x1821D1640
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

// Namespace: TMPro
public enum VertexSortingOrder // TypeDefIndex: 11471
{
	// Fields
	public int value__; // 0x0
	public const VertexSortingOrder Normal = 0;
	public const VertexSortingOrder Reverse = 1;
}

// Namespace: TMPro
public struct TMP_MeshInfo // TypeDefIndex: 11472
{
	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector4[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40
	public Material material; // 0x48

	// Methods

	// RVA: 0x21D5CC0 Offset: 0x21D42C0 VA: 0x1821D5CC0
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x21D6260 Offset: 0x21D4860 VA: 0x1821D6260
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x21D4180 Offset: 0x21D2780 VA: 0x1821D4180
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x21D4680 Offset: 0x21D2C80 VA: 0x1821D4680
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x21D3FA0 Offset: 0x21D25A0 VA: 0x1821D3FA0
	public void Clear() { }

	// RVA: 0x21D4040 Offset: 0x21D2640 VA: 0x1821D4040
	public void Clear(bool uploadChanges) { }

	// RVA: 0x21D3F60 Offset: 0x21D2560 VA: 0x1821D3F60
	public void ClearUnusedVertices() { }

	// RVA: 0x21D3E70 Offset: 0x21D2470 VA: 0x1821D3E70
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x21D3EB0 Offset: 0x21D24B0 VA: 0x1821D3EB0
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x21D5200 Offset: 0x21D3800 VA: 0x1821D5200
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x21D52B0 Offset: 0x21D38B0 VA: 0x1821D52B0
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x21D5450 Offset: 0x21D3A50 VA: 0x1821D5450
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0x21D5C20 Offset: 0x21D4220 VA: 0x1821D5C20
	private static void .cctor() { }
}

// Namespace: TMPro
internal class TMP_ObjectPool<T> // TypeDefIndex: 11473
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGenerated]
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	|-TMP_ObjectPool<object>.get_countAll
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	|-TMP_ObjectPool<object>.set_countAll
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4DF0 Offset: 0x9C33F0 VA: 0x1809C4DF0
	|-TMP_ObjectPool<object>.get_countActive
	|
	|-RVA: 0x9C4E10 Offset: 0x9C3410 VA: 0x1809C4E10
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	|-TMP_ObjectPool<object>.get_countInactive
	|
	|-RVA: 0x9C4E90 Offset: 0x9C3490 VA: 0x1809C4E90
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4D00 Offset: 0x9C3300 VA: 0x1809C4D00
	|-TMP_ObjectPool<object>..ctor
	|
	|-RVA: 0x9C4C40 Offset: 0x9C3240 VA: 0x1809C4C40
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4500 Offset: 0x9C2B00 VA: 0x1809C4500
	|-TMP_ObjectPool<object>.Get
	|
	|-RVA: 0x9C45F0 Offset: 0x9C2BF0 VA: 0x1809C45F0
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4810 Offset: 0x9C2E10 VA: 0x1809C4810
	|-TMP_ObjectPool<object>.Release
	|
	|-RVA: 0x9C4990 Offset: 0x9C2F90 VA: 0x1809C4990
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: TMPro
public class TMP_ResourceManager // TypeDefIndex: 11475
{
	// Fields
	private static TMP_Settings s_TextSettings; // 0x0
	private static readonly Dictionary<int, TMP_ResourceManager.FontAssetRef> s_FontAssetReferences; // 0x8
	private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetNameReferenceLookup; // 0x10
	private static readonly Dictionary<long, TMP_FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x18
	private static readonly List<int> s_FontAssetRemovalList; // 0x20
	private static readonly int k_RegularStyleHashCode; // 0x28

	// Methods

	// RVA: 0x21D72A0 Offset: 0x21D58A0 VA: 0x1821D72A0
	internal static TMP_Settings GetTextSettings() { }

	// RVA: 0x21D6C80 Offset: 0x21D5280 VA: 0x1821D6C80
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x21D77B0 Offset: 0x21D5DB0 VA: 0x1821D77B0
	public static void RemoveFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x21D79E0 Offset: 0x21D5FE0 VA: 0x1821D79E0
	internal static bool TryGetFontAssetByName(int nameHashcode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x21D7910 Offset: 0x21D5F10 VA: 0x1821D7910
	internal static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x21D7260 Offset: 0x21D5860 VA: 0x1821D7260
	public static void ClearFontAssetGlyphCache() { }

	// RVA: 0x21D73C0 Offset: 0x21D59C0 VA: 0x1821D73C0
	internal static void RebuildFontAssetCache() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x21D7A80 Offset: 0x21D6080 VA: 0x1821D7A80
	private static void .cctor() { }
}

// Namespace: TMPro
internal enum MarkupTag // TypeDefIndex: 11476
{
	// Fields
	public int value__; // 0x0
	public const MarkupTag BOLD = 66;
	public const MarkupTag SLASH_BOLD = 1613;
	public const MarkupTag ITALIC = 73;
	public const MarkupTag SLASH_ITALIC = 1606;
	public const MarkupTag UNDERLINE = 85;
	public const MarkupTag SLASH_UNDERLINE = 1626;
	public const MarkupTag STRIKETHROUGH = 83;
	public const MarkupTag SLASH_STRIKETHROUGH = 1628;
	public const MarkupTag MARK = 2699125;
	public const MarkupTag SLASH_MARK = 57644506;
	public const MarkupTag SUBSCRIPT = 92132;
	public const MarkupTag SLASH_SUBSCRIPT = 1770219;
	public const MarkupTag SUPERSCRIPT = 92150;
	public const MarkupTag SLASH_SUPERSCRIPT = 1770233;
	public const MarkupTag COLOR = 81999901;
	public const MarkupTag SLASH_COLOR = 1909026194;
	public const MarkupTag ALPHA = 75165780;
	public const MarkupTag A = 65;
	public const MarkupTag SLASH_A = 1614;
	public const MarkupTag SIZE = 3061285;
	public const MarkupTag SLASH_SIZE = 58429962;
	public const MarkupTag SPRITE = -991527447;
	public const MarkupTag NO_BREAK = 2856657;
	public const MarkupTag SLASH_NO_BREAK = 57477502;
	public const MarkupTag STYLE = 100252951;
	public const MarkupTag SLASH_STYLE = 1927738392;
	public const MarkupTag FONT = 2586451;
	public const MarkupTag SLASH_FONT = 57747708;
	public const MarkupTag SLASH_MATERIAL = -1100708252;
	public const MarkupTag LINK = 2656128;
	public const MarkupTag SLASH_LINK = 57686191;
	public const MarkupTag FONT_WEIGHT = -1889896162;
	public const MarkupTag SLASH_FONT_WEIGHT = -757976431;
	public const MarkupTag NO_PARSE = -408011596;
	public const MarkupTag SLASH_NO_PARSE = -294095813;
	public const MarkupTag POSITION = 85420;
	public const MarkupTag SLASH_POSITION = 1777699;
	public const MarkupTag VERTICAL_OFFSET = 1952379995;
	public const MarkupTag SLASH_VERTICAL_OFFSET = -11107948;
	public const MarkupTag SPACE = 100083556;
	public const MarkupTag SLASH_SPACE = 1927873067;
	public const MarkupTag PAGE = 2808691;
	public const MarkupTag SLASH_PAGE = 58683868;
	public const MarkupTag ALIGN = 75138797;
	public const MarkupTag SLASH_ALIGN = 1916026786;
	public const MarkupTag WIDTH = 105793766;
	public const MarkupTag SLASH_WIDTH = 1923459625;
	public const MarkupTag GRADIENT = -1999759898;
	public const MarkupTag SLASH_GRADIENT = -1854491959;
	public const MarkupTag CHARACTER_SPACE = -1584382009;
	public const MarkupTag SLASH_CHARACTER_SPACE = -1394426712;
	public const MarkupTag MONOSPACE = -1340221943;
	public const MarkupTag SLASH_MONOSPACE = -1638865562;
	public const MarkupTag CLASS = 82115566;
	public const MarkupTag INDENT = -1514123076;
	public const MarkupTag SLASH_INDENT = -1496889389;
	public const MarkupTag LINE_INDENT = -844305121;
	public const MarkupTag SLASH_LINE_INDENT = 93886352;
	public const MarkupTag MARGIN = -1355614050;
	public const MarkupTag SLASH_MARGIN = -1649644303;
	public const MarkupTag MARGIN_LEFT = -272933656;
	public const MarkupTag MARGIN_RIGHT = -447416589;
	public const MarkupTag LINE_HEIGHT = -799081892;
	public const MarkupTag SLASH_LINE_HEIGHT = 200452819;
	public const MarkupTag ACTION = -1827519330;
	public const MarkupTag SLASH_ACTION = -1187217679;
	public const MarkupTag SCALE = 100553336;
	public const MarkupTag SLASH_SCALE = 1928413879;
	public const MarkupTag ROTATE = -1000007783;
	public const MarkupTag SLASH_ROTATE = -764695562;
	public const MarkupTag TABLE = 226476955;
	public const MarkupTag SLASH_TABLE = -979118220;
	public const MarkupTag TH = 5862489;
	public const MarkupTag SLASH_TH = 193346070;
	public const MarkupTag TR = 5862467;
	public const MarkupTag SLASH_TR = 193346060;
	public const MarkupTag TD = 5862485;
	public const MarkupTag SLASH_TD = 193346074;
	public const MarkupTag LOWERCASE = -1506899689;
	public const MarkupTag SLASH_LOWERCASE = -1451284584;
	public const MarkupTag ALLCAPS = 218273952;
	public const MarkupTag SLASH_ALLCAPS = -797437649;
	public const MarkupTag UPPERCASE = -305409418;
	public const MarkupTag SLASH_UPPERCASE = -582368199;
	public const MarkupTag SMALLCAPS = -766062114;
	public const MarkupTag SLASH_SMALLCAPS = 199921873;
	public const MarkupTag LIGA = 2655971;
	public const MarkupTag SLASH_LIGA = 57686604;
	public const MarkupTag FRAC = 2598518;
	public const MarkupTag SLASH_FRAC = 57774681;
	public const MarkupTag NAME = 2875623;
	public const MarkupTag INDEX = 84268030;
	public const MarkupTag TINT = 2960519;
	public const MarkupTag ANIM = 2283339;
	public const MarkupTag MATERIAL = 825491659;
	public const MarkupTag HREF = 2535353;
	public const MarkupTag ANGLE = 75347905;
	public const MarkupTag PADDING = -2144568463;
	public const MarkupTag FAMILYNAME = 704251153;
	public const MarkupTag STYLENAME = -1207081936;
	public const MarkupTag DUOSPACE = 582810522;
	public const MarkupTag RED = 91635;
	public const MarkupTag GREEN = 87065851;
	public const MarkupTag BLUE = 2457214;
	public const MarkupTag YELLOW = -882444668;
	public const MarkupTag ORANGE = -1108587920;
	public const MarkupTag BLACK = 81074727;
	public const MarkupTag WHITE = 105680263;
	public const MarkupTag PURPLE = -1250222130;
	public const MarkupTag GREY = 2638345;
	public const MarkupTag LIGHTBLUE = 341063360;
	public const MarkupTag BR = 2256;
	public const MarkupTag CR = 2289;
	public const MarkupTag ZWSP = 3288238;
	public const MarkupTag ZWJ = 99623;
	public const MarkupTag NBSP = 2869039;
	public const MarkupTag SHY = 92674;
	public const MarkupTag LEFT = 2660507;
	public const MarkupTag RIGHT = 99937376;
	public const MarkupTag CENTER = -1591113269;
	public const MarkupTag JUSTIFIED = 817091359;
	public const MarkupTag FLUSH = 85552164;
	public const MarkupTag NONE = 2857034;
	public const MarkupTag PLUS = 43;
	public const MarkupTag MINUS = 45;
	public const MarkupTag PX = 2568;
	public const MarkupTag PLUS_PX = 49507;
	public const MarkupTag MINUS_PX = 47461;
	public const MarkupTag EM = 2216;
	public const MarkupTag PLUS_EM = 49091;
	public const MarkupTag MINUS_EM = 46789;
	public const MarkupTag PCT = 85031;
	public const MarkupTag PLUS_PCT = 1634348;
	public const MarkupTag MINUS_PCT = 1567082;
	public const MarkupTag PERCENTAGE = 37;
	public const MarkupTag PLUS_PERCENTAGE = 1454;
	public const MarkupTag MINUS_PERCENTAGE = 1512;
	public const MarkupTag TRUE = 2932022;
	public const MarkupTag FALSE = 85422813;
	public const MarkupTag INVALID = 1585415185;
	public const MarkupTag NOTDEF = 612146780;
	public const MarkupTag NORMAL = -1183493901;
	public const MarkupTag DEFAULT = -620974005;
	public const MarkupTag REGULAR = 1291372090;
}

// Namespace: TMPro
public enum TagValueType // TypeDefIndex: 11477
{
	// Fields
	public int value__; // 0x0
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: TMPro
public enum TagUnitType // TypeDefIndex: 11478
{
	// Fields
	public int value__; // 0x0
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: TMPro
internal static class CodePoint // TypeDefIndex: 11479
{
	// Fields
	public const uint SPACE = 32;
	public const uint DOUBLE_QUOTE = 34;
	public const uint NUMBER_SIGN = 35;
	public const uint PERCENTAGE = 37;
	public const uint PLUS = 43;
	public const uint MINUS = 45;
	public const uint PERIOD = 46;
	public const uint HYPHEN_MINUS = 45;
	public const uint SOFT_HYPHEN = 173;
	public const uint HYPHEN = 8208;
	public const uint NON_BREAKING_HYPHEN = 8209;
	public const uint ZERO_WIDTH_SPACE = 8203;
	public const uint RIGHT_SINGLE_QUOTATION = 8217;
	public const uint APOSTROPHE = 39;
	public const uint WORD_JOINER = 8288;
	public const uint HIGH_SURROGATE_START = 55296;
	public const uint HIGH_SURROGATE_END = 56319;
	public const uint LOW_SURROGATE_START = 56320;
	public const uint LOW_SURROGATE_END = 57343;
	public const uint UNICODE_PLANE01_START = 65536;
}

// Namespace: TMPro
public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 11480
{
	// Fields
	public bool isSelected; // 0x20

	// Methods

	// RVA: 0x21D7CF0 Offset: 0x21D62F0 VA: 0x1821D7CF0 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x21D7D50 Offset: 0x21D6350 VA: 0x1821D7D50 Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x21D7C90 Offset: 0x21D6290 VA: 0x1821D7C90 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent(typeof(CanvasRenderer))]
public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 11481
{
	// Methods

	// RVA: 0x21D7DB0 Offset: 0x21D63B0 VA: 0x1821D7DB0 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x55D530 Offset: 0x55BB30 VA: 0x18055D530
	public void .ctor() { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_Settings : ScriptableObject // TypeDefIndex: 11483
{
	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField]
	internal string assetVersion; // 0x18
	internal static string s_CurrentAssetVersion; // 0x8
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	private TextWrappingModes m_TextWrappingMode; // 0x20
	[SerializeField]
	private bool m_enableKerning; // 0x24
	[SerializeField]
	private List<OTL_FeatureTag> m_ActiveFontFeatures; // 0x28
	[SerializeField]
	private bool m_enableExtraPadding; // 0x30
	[SerializeField]
	private bool m_enableTintAllSprites; // 0x31
	[SerializeField]
	private bool m_enableParseEscapeCharacters; // 0x32
	[SerializeField]
	private bool m_EnableRaycastTarget; // 0x33
	[SerializeField]
	private bool m_GetFontFeaturesAtRuntime; // 0x34
	[SerializeField]
	private int m_missingGlyphCharacter; // 0x38
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x3C
	[SerializeField]
	private bool m_warningsDisabled; // 0x3D
	[SerializeField]
	private TMP_FontAsset m_defaultFontAsset; // 0x40
	[SerializeField]
	private string m_defaultFontAssetPath; // 0x48
	[SerializeField]
	private float m_defaultFontSize; // 0x50
	[SerializeField]
	private float m_defaultAutoSizeMinRatio; // 0x54
	[SerializeField]
	private float m_defaultAutoSizeMaxRatio; // 0x58
	[SerializeField]
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x5C
	[SerializeField]
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x64
	[SerializeField]
	private bool m_autoSizeTextContainer; // 0x6C
	[SerializeField]
	private bool m_IsTextObjectScaleStatic; // 0x6D
	[SerializeField]
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x70
	[SerializeField]
	private bool m_matchMaterialPreset; // 0x78
	[SerializeField]
	private bool m_HideSubTextObjects; // 0x79
	[SerializeField]
	private TMP_SpriteAsset m_defaultSpriteAsset; // 0x80
	[SerializeField]
	private string m_defaultSpriteAssetPath; // 0x88
	[SerializeField]
	private bool m_enableEmojiSupport; // 0x90
	[SerializeField]
	private uint m_MissingCharacterSpriteUnicode; // 0x94
	[SerializeField]
	private List<TMP_Asset> m_EmojiFallbackTextAssets; // 0x98
	[SerializeField]
	private string m_defaultColorGradientPresetsPath; // 0xA0
	[SerializeField]
	private TMP_StyleSheet m_defaultStyleSheet; // 0xA8
	[SerializeField]
	private string m_StyleSheetsResourcePath; // 0xB0
	[SerializeField]
	private TextAsset m_leadingCharacters; // 0xB8
	[SerializeField]
	private TextAsset m_followingCharacters; // 0xC0
	[SerializeField]
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0xC8
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0xD0

	// Properties
	public static string version { get; }
	public static TextWrappingModes textWrappingMode { get; }
	[Obsolete("The "enableKerning" property has been deprecated. Use the "fontFeatures" property to control what features are enabled by default on newly created text components.")]
	public static bool enableKerning { get; }
	public static List<OTL_FeatureTag> fontFeatures { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableParseEscapeCharacters { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool clearDynamicDataOnBuild { get; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; set; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static bool isTextObjectScaleStatic { get; set; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; set; }
	public static bool matchMaterialPreset { get; }
	public static bool hideSubTextObjects { get; }
	public static TMP_SpriteAsset defaultSpriteAsset { get; set; }
	public static string defaultSpriteAssetPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static uint missingCharacterSpriteUnicode { get; set; }
	public static List<TMP_Asset> emojiFallbackTextAssets { get; set; }
	public static string defaultColorGradientPresetsPath { get; }
	public static TMP_StyleSheet defaultStyleSheet { get; set; }
	public static string styleSheetsResourcePath { get; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static bool useModernHangulLineBreakingRules { get; set; }
	public static TMP_Settings instance { get; }
	internal static bool isTMPSettingsNull { get; }

	// Methods

	// RVA: 0x21D9680 Offset: 0x21D7C80 VA: 0x1821D9680
	public static string get_version() { }

	// RVA: 0x21D8500 Offset: 0x21D6B00 VA: 0x1821D8500
	internal void SetAssetVersion() { }

	// RVA: 0x21D95D0 Offset: 0x21D7BD0 VA: 0x1821D95D0
	public static TextWrappingModes get_textWrappingMode() { }

	// RVA: 0x21D8C80 Offset: 0x21D7280 VA: 0x1821D8C80
	public static bool get_enableKerning() { }

	// RVA: 0x21D8EE0 Offset: 0x21D74E0 VA: 0x1821D8EE0
	public static List<OTL_FeatureTag> get_fontFeatures() { }

	// RVA: 0x21D8C30 Offset: 0x21D7230 VA: 0x1821D8C30
	public static bool get_enableExtraPadding() { }

	// RVA: 0x21D8DE0 Offset: 0x21D73E0 VA: 0x1821D8DE0
	public static bool get_enableTintAllSprites() { }

	// RVA: 0x21D8D40 Offset: 0x21D7340 VA: 0x1821D8D40
	public static bool get_enableParseEscapeCharacters() { }

	// RVA: 0x21D8D90 Offset: 0x21D7390 VA: 0x1821D8D90
	public static bool get_enableRaycastTarget() { }

	// RVA: 0x21D8F30 Offset: 0x21D7530 VA: 0x1821D8F30
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0x21D9520 Offset: 0x21D7B20 VA: 0x1821D9520
	public static int get_missingGlyphCharacter() { }

	// RVA: 0x21D9A50 Offset: 0x21D8050 VA: 0x1821D9A50
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0x21D8720 Offset: 0x21D6D20 VA: 0x1821D8720
	public static bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x21D96B0 Offset: 0x21D7CB0 VA: 0x1821D96B0
	public static bool get_warningsDisabled() { }

	// RVA: 0x21D8820 Offset: 0x21D6E20 VA: 0x1821D8820
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0x21D9700 Offset: 0x21D7D00 VA: 0x1821D9700
	public static void set_defaultFontAsset(TMP_FontAsset value) { }

	// RVA: 0x21D87D0 Offset: 0x21D6DD0 VA: 0x1821D87D0
	public static string get_defaultFontAssetPath() { }

	// RVA: 0x21D8870 Offset: 0x21D6E70 VA: 0x1821D8870
	public static float get_defaultFontSize() { }

	// RVA: 0x21D8A50 Offset: 0x21D7050 VA: 0x1821D8A50
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0x21D89F0 Offset: 0x21D6FF0 VA: 0x1821D89F0
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0x21D8AB0 Offset: 0x21D70B0 VA: 0x1821D8AB0
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0x21D8B10 Offset: 0x21D7110 VA: 0x1821D8B10
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0x21D86D0 Offset: 0x21D6CD0 VA: 0x1821D86D0
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0x21D9320 Offset: 0x21D7920 VA: 0x1821D9320
	public static bool get_isTextObjectScaleStatic() { }

	// RVA: 0x21D9990 Offset: 0x21D7F90 VA: 0x1821D9990
	public static void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x21D8E30 Offset: 0x21D7430 VA: 0x1821D8E30
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x21D9920 Offset: 0x21D7F20 VA: 0x1821D9920
	public static void set_fallbackFontAssets(List<TMP_FontAsset> value) { }

	// RVA: 0x21D9470 Offset: 0x21D7A70 VA: 0x1821D9470
	public static bool get_matchMaterialPreset() { }

	// RVA: 0x21D8F80 Offset: 0x21D7580 VA: 0x1821D8F80
	public static bool get_hideSubTextObjects() { }

	// RVA: 0x21D8930 Offset: 0x21D6F30 VA: 0x1821D8930
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x21D9770 Offset: 0x21D7D70 VA: 0x1821D9770
	public static void set_defaultSpriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x21D88D0 Offset: 0x21D6ED0 VA: 0x1821D88D0
	public static string get_defaultSpriteAssetPath() { }

	// RVA: 0x21D8BD0 Offset: 0x21D71D0 VA: 0x1821D8BD0
	public static bool get_enableEmojiSupport() { }

	// RVA: 0x21D98C0 Offset: 0x21D7EC0 VA: 0x1821D98C0
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0x21D94C0 Offset: 0x21D7AC0 VA: 0x1821D94C0
	public static uint get_missingCharacterSpriteUnicode() { }

	// RVA: 0x21D99F0 Offset: 0x21D7FF0 VA: 0x1821D99F0
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	// RVA: 0x21D8B70 Offset: 0x21D7170 VA: 0x1821D8B70
	public static List<TMP_Asset> get_emojiFallbackTextAssets() { }

	// RVA: 0x21D9850 Offset: 0x21D7E50 VA: 0x1821D9850
	public static void set_emojiFallbackTextAssets(List<TMP_Asset> value) { }

	// RVA: 0x21D8770 Offset: 0x21D6D70 VA: 0x1821D8770
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x21D8990 Offset: 0x21D6F90 VA: 0x1821D8990
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	// RVA: 0x21D97E0 Offset: 0x21D7DE0 VA: 0x1821D97E0
	public static void set_defaultStyleSheet(TMP_StyleSheet value) { }

	// RVA: 0x21D9570 Offset: 0x21D7B70 VA: 0x1821D9570
	public static string get_styleSheetsResourcePath() { }

	// RVA: 0x21D9370 Offset: 0x21D7970 VA: 0x1821D9370
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0x21D8E80 Offset: 0x21D7480 VA: 0x1821D8E80
	public static TextAsset get_followingCharacters() { }

	// RVA: 0x21D93D0 Offset: 0x21D79D0 VA: 0x1821D93D0
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0x21D9620 Offset: 0x21D7C20 VA: 0x1821D9620
	public static bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x21D9AB0 Offset: 0x21D80B0 VA: 0x1821D9AB0
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x21D8FD0 Offset: 0x21D75D0 VA: 0x1821D8FD0
	public static TMP_Settings get_instance() { }

	// RVA: 0x21D92A0 Offset: 0x21D78A0 VA: 0x1821D92A0
	internal static bool get_isTMPSettingsNull() { }

	// RVA: 0x21D81F0 Offset: 0x21D67F0 VA: 0x1821D81F0
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0x21D7FF0 Offset: 0x21D65F0 VA: 0x1821D7FF0
	public static TMP_Settings GetSettings() { }

	// RVA: 0x21D7F40 Offset: 0x21D6540 VA: 0x1821D7F40
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0x21D8090 Offset: 0x21D6690 VA: 0x1821D8090
	public static TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x21D8140 Offset: 0x21D6740 VA: 0x1821D8140
	public static TMP_StyleSheet GetStyleSheet() { }

	// RVA: 0x21D8330 Offset: 0x21D6930 VA: 0x1821D8330
	public static void LoadLinebreakingRules() { }

	// RVA: 0x21D7E70 Offset: 0x21D6470 VA: 0x1821D7E70
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x21D85E0 Offset: 0x21D6BE0 VA: 0x1821D85E0
	public void .ctor() { }

	// RVA: 0x21D8570 Offset: 0x21D6B70 VA: 0x1821D8570
	private static void .cctor() { }
}

// Namespace: TMPro
public static class ShaderUtilities // TypeDefIndex: 11484
{
	// Fields
	public static int ID_MainTex; // 0x0
	public static int ID_FaceTex; // 0x4
	public static int ID_FaceColor; // 0x8
	public static int ID_FaceDilate; // 0xC
	public static int ID_Shininess; // 0x10
	public static int ID_OutlineOffset1; // 0x14
	public static int ID_OutlineOffset2; // 0x18
	public static int ID_OutlineOffset3; // 0x1C
	public static int ID_OutlineMode; // 0x20
	public static int ID_IsoPerimeter; // 0x24
	public static int ID_Softness; // 0x28
	public static int ID_UnderlayColor; // 0x2C
	public static int ID_UnderlayOffsetX; // 0x30
	public static int ID_UnderlayOffsetY; // 0x34
	public static int ID_UnderlayDilate; // 0x38
	public static int ID_UnderlaySoftness; // 0x3C
	public static int ID_UnderlayOffset; // 0x40
	public static int ID_UnderlayIsoPerimeter; // 0x44
	public static int ID_WeightNormal; // 0x48
	public static int ID_WeightBold; // 0x4C
	public static int ID_OutlineTex; // 0x50
	public static int ID_OutlineWidth; // 0x54
	public static int ID_OutlineSoftness; // 0x58
	public static int ID_OutlineColor; // 0x5C
	public static int ID_Outline2Color; // 0x60
	public static int ID_Outline2Width; // 0x64
	public static int ID_Padding; // 0x68
	public static int ID_GradientScale; // 0x6C
	public static int ID_ScaleX; // 0x70
	public static int ID_ScaleY; // 0x74
	public static int ID_PerspectiveFilter; // 0x78
	public static int ID_Sharpness; // 0x7C
	public static int ID_TextureWidth; // 0x80
	public static int ID_TextureHeight; // 0x84
	public static int ID_BevelAmount; // 0x88
	public static int ID_GlowColor; // 0x8C
	public static int ID_GlowOffset; // 0x90
	public static int ID_GlowPower; // 0x94
	public static int ID_GlowOuter; // 0x98
	public static int ID_GlowInner; // 0x9C
	public static int ID_LightAngle; // 0xA0
	public static int ID_EnvMap; // 0xA4
	public static int ID_EnvMatrix; // 0xA8
	public static int ID_EnvMatrixRotation; // 0xAC
	public static int ID_MaskCoord; // 0xB0
	public static int ID_ClipRect; // 0xB4
	public static int ID_MaskSoftnessX; // 0xB8
	public static int ID_MaskSoftnessY; // 0xBC
	public static int ID_VertexOffsetX; // 0xC0
	public static int ID_VertexOffsetY; // 0xC4
	public static int ID_UseClipRect; // 0xC8
	public static int ID_StencilID; // 0xCC
	public static int ID_StencilOp; // 0xD0
	public static int ID_StencilComp; // 0xD4
	public static int ID_StencilReadMask; // 0xD8
	public static int ID_StencilWriteMask; // 0xDC
	public static int ID_ShaderFlags; // 0xE0
	public static int ID_ScaleRatio_A; // 0xE4
	public static int ID_ScaleRatio_B; // 0xE8
	public static int ID_ScaleRatio_C; // 0xEC
	public static string Keyword_Bevel; // 0xF0
	public static string Keyword_Glow; // 0xF8
	public static string Keyword_Underlay; // 0x100
	public static string Keyword_Ratios; // 0x108
	public static string Keyword_MASK_SOFT; // 0x110
	public static string Keyword_MASK_HARD; // 0x118
	public static string Keyword_MASK_TEX; // 0x120
	public static string Keyword_Outline; // 0x128
	public static string ShaderTag_ZTestMode; // 0x130
	public static string ShaderTag_CullMode; // 0x138
	private static float m_clamp; // 0x140
	public static bool isInitialized; // 0x144
	private static Shader k_ShaderRef_MobileSDF; // 0x148
	private static Shader k_ShaderRef_MobileBitmap; // 0x150

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }

	// Methods

	// RVA: 0x21D0B70 Offset: 0x21CF170 VA: 0x1821D0B70
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x21D0A50 Offset: 0x21CF050 VA: 0x1821D0A50
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x21D0710 Offset: 0x21CED10 VA: 0x1821D0710
	private static void .cctor() { }

	// RVA: 0x21CF330 Offset: 0x21CD930 VA: 0x1821CF330
	public static void GetShaderPropertyIDs() { }

	// RVA: 0x21D0150 Offset: 0x21CE750 VA: 0x1821D0150
	public static void UpdateShaderRatios(Material mat) { }

	// RVA: 0x21CDBD0 Offset: 0x21CC1D0 VA: 0x1821CDBD0
	public static Vector4 GetFontExtent(Material material) { }

	// RVA: 0x21CFF90 Offset: 0x21CE590 VA: 0x1821CFF90
	public static bool IsMaskingEnabled(Material material) { }

	// RVA: 0x21CE830 Offset: 0x21CCE30 VA: 0x1821CE830
	public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) { }

	// RVA: 0x21CD7F0 Offset: 0x21CBDF0 VA: 0x1821CD7F0
	private static float ComputePaddingForProperties(Material mat) { }

	// RVA: 0x21CDC20 Offset: 0x21CC220 VA: 0x1821CDC20
	public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 11485
{
	// Fields
	public string name; // 0x38
	public int hashCode; // 0x40
	public int unicode; // 0x44
	public Vector2 pivot; // 0x48
	public Sprite sprite; // 0x50

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: TMPro
[DisallowMultipleComponent]
public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 11487
{
	// Fields
	private Dictionary<int, bool> m_animations; // 0x20
	private TMP_Text m_TextComponent; // 0x28

	// Methods

	// RVA: 0x21D9B10 Offset: 0x21D8110 VA: 0x1821D9B10
	private void Awake() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void OnEnable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void OnDisable() { }

	// RVA: 0x21D9D50 Offset: 0x21D8350 VA: 0x1821D9D50
	public void StopAllAnimations() { }

	// RVA: 0x21D9C20 Offset: 0x21D8220 VA: 0x1821D9C20
	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[IteratorStateMachine(typeof(TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7))]
	// RVA: 0x21D9B60 Offset: 0x21D8160 VA: 0x1821D9B60
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	// RVA: 0x21D9DA0 Offset: 0x21D83A0 VA: 0x1821D9DA0
	public void .ctor() { }
}

// Namespace: TMPro
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Sprites.html")]
[ExcludeFromPreset]
public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 11489
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x98
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0xA0
	public Texture spriteSheet; // 0xA8
	[SerializeField]
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[FormerlySerializedAs("m_SpriteGlyphTable")]
	[SerializeField]
	private List<TMP_SpriteGlyph> m_GlyphTable; // 0xC0
	internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	public List<TMP_Sprite> spriteInfoList; // 0xD0
	[SerializeField]
	public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public List<TMP_SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<TMP_SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x21DBF30 Offset: 0x21DA530 VA: 0x1821DBF30
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	// RVA: 0x21DBEF0 Offset: 0x21DA4F0 VA: 0x1821DBEF0
	public Dictionary<uint, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	internal void set_spriteCharacterLookupTable(Dictionary<uint, TMP_SpriteCharacter> value) { }

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	// RVA: 0x21D9E20 Offset: 0x21D8420 VA: 0x1821D9E20
	private void Awake() { }

	// RVA: 0x21D9EA0 Offset: 0x21D84A0 VA: 0x1821D9EA0
	private Material GetDefaultSpriteMaterial() { }

	// RVA: 0x21DB320 Offset: 0x21D9920 VA: 0x1821DB320
	public void UpdateLookupTables() { }

	// RVA: 0x21D9F70 Offset: 0x21D8570 VA: 0x1821D9F70
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x21DA080 Offset: 0x21D8680 VA: 0x1821DA080
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x21DA000 Offset: 0x21D8600 VA: 0x1821DA000
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x21DAA80 Offset: 0x21D9080 VA: 0x1821DAA80
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x21DA830 Offset: 0x21D8E30 VA: 0x1821DA830
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x21DA9C0 Offset: 0x21D8FC0 VA: 0x1821DA9C0
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x21DA370 Offset: 0x21D8970 VA: 0x1821DA370
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x21DA1E0 Offset: 0x21D87E0 VA: 0x1821DA1E0
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x21DA120 Offset: 0x21D8720 VA: 0x1821DA120
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x21DB1A0 Offset: 0x21D97A0 VA: 0x1821DB1A0
	public void SortGlyphTable() { }

	// RVA: 0x21DAD50 Offset: 0x21D9350 VA: 0x1821DAD50
	internal void SortCharacterTable() { }

	// RVA: 0x21DAED0 Offset: 0x21D94D0 VA: 0x1821DAED0
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x21DB900 Offset: 0x21D9F00 VA: 0x1821DB900
	private void UpgradeSpriteAsset() { }

	// RVA: 0x21DBE20 Offset: 0x21DA420 VA: 0x1821DBE20
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 11490
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30

	// Properties
	public string name { get; set; }

	// Methods

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_name() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_name(string value) { }

	// RVA: 0x21DC040 Offset: 0x21DA640 VA: 0x1821DC040
	public void .ctor() { }

	// RVA: 0x21DBFD0 Offset: 0x21DA5D0 VA: 0x1821DBFD0
	public void .ctor(uint unicode, TMP_SpriteGlyph glyph) { }

	// RVA: 0x21DC060 Offset: 0x21DA660 VA: 0x1821DC060
	public void .ctor(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) { }

	// RVA: 0x21DBF70 Offset: 0x21DA570 VA: 0x1821DBF70
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 11491
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x21DC250 Offset: 0x21DA850 VA: 0x1821DC250
	public void .ctor() { }

	// RVA: 0x21DC1B0 Offset: 0x21DA7B0 VA: 0x1821DC1B0
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	// RVA: 0x21DC0F0 Offset: 0x21DA6F0 VA: 0x1821DC0F0
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Style // TypeDefIndex: 11492
{
	// Fields
	internal static TMP_Style k_NormalStyle; // 0x0
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_HashCode; // 0x18
	[SerializeField]
	private string m_OpeningDefinition; // 0x20
	[SerializeField]
	private string m_ClosingDefinition; // 0x28
	[SerializeField]
	private uint[] m_OpeningTagArray; // 0x30
	[SerializeField]
	private uint[] m_ClosingTagArray; // 0x38

	// Properties
	public static TMP_Style NormalStyle { get; }
	public string name { get; set; }
	public int hashCode { get; set; }
	public string styleOpeningDefinition { get; }
	public string styleClosingDefinition { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x21DC9B0 Offset: 0x21DAFB0 VA: 0x1821DC9B0
	public static TMP_Style get_NormalStyle() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	// RVA: 0x21DCAA0 Offset: 0x21DB0A0 VA: 0x1821DCAA0
	public void set_name(string value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_hashCode() { }

	// RVA: 0x21DCA90 Offset: 0x21DB090 VA: 0x1821DCA90
	public void set_hashCode(int value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_styleOpeningDefinition() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_styleClosingDefinition() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x21DC8F0 Offset: 0x21DAEF0 VA: 0x1821DC8F0
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x21DC780 Offset: 0x21DAD80 VA: 0x1821DC780
	public void RefreshStyle() { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 11493
{
	// Fields
	[SerializeField]
	private List<TMP_Style> m_StyleList; // 0x18
	private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TMP_Style> styles { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal List<TMP_Style> get_styles() { }

	// RVA: 0x21DC6F0 Offset: 0x21DACF0 VA: 0x1821DC6F0
	private void Reset() { }

	// RVA: 0x21DC320 Offset: 0x21DA920 VA: 0x1821DC320
	public TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x21DC260 Offset: 0x21DA860 VA: 0x1821DC260
	public TMP_Style GetStyle(string name) { }

	// RVA: 0x21DC6F0 Offset: 0x21DACF0 VA: 0x1821DC6F0
	public void RefreshStyles() { }

	// RVA: 0x21DC3B0 Offset: 0x21DA9B0 VA: 0x1821DC3B0
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x21DC700 Offset: 0x21DAD00 VA: 0x1821DC700
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent(typeof(MeshRenderer))]
[ExecuteAlways]
public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 11494
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0x20
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0x28
	[SerializeField]
	private Material m_material; // 0x30
	[SerializeField]
	private Material m_sharedMaterial; // 0x38
	private Material m_fallbackMaterial; // 0x40
	private Material m_fallbackSourceMaterial; // 0x48
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x50
	[SerializeField]
	private float m_padding; // 0x54
	[SerializeField]
	private Renderer m_renderer; // 0x58
	private MeshFilter m_meshFilter; // 0x60
	private Mesh m_mesh; // 0x68
	[SerializeField]
	private TextMeshPro m_TextComponent; // 0x70
	private bool m_isRegisteredForEvents; // 0x78

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x21DF3F0 Offset: 0x21DD9F0 VA: 0x1821DF3F0
	public Material get_material() { }

	// RVA: 0x21DF850 Offset: 0x21DDE50 VA: 0x1821DF850
	public void set_material(Material value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public Material get_sharedMaterial() { }

	// RVA: 0x21DF080 Offset: 0x21DD680 VA: 0x1821DF080
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public Material get_fallbackMaterial() { }

	// RVA: 0x21DF6F0 Offset: 0x21DDCF0 VA: 0x1821DF6F0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	public bool get_isDefaultMaterial() { }

	// RVA: 0x1031CD0 Offset: 0x10302D0 VA: 0x181031CD0
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x17836B0 Offset: 0x1781CB0 VA: 0x1817836B0
	public float get_padding() { }

	// RVA: 0x474440 Offset: 0x472A40 VA: 0x180474440
	public void set_padding(float value) { }

	// RVA: 0x21DF5D0 Offset: 0x21DDBD0 VA: 0x1821DF5D0
	public Renderer get_renderer() { }

	// RVA: 0x21DF400 Offset: 0x21DDA00 VA: 0x1821DF400
	public MeshFilter get_meshFilter() { }

	// RVA: 0x21DF510 Offset: 0x21DDB10 VA: 0x1821DF510
	public Mesh get_mesh() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_mesh(Mesh value) { }

	// RVA: 0x21DF660 Offset: 0x21DDC60 VA: 0x1821DF660
	public TMP_Text get_textComponent() { }

	// RVA: 0x21DE400 Offset: 0x21DCA00 VA: 0x1821DE400
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0x21DEDD0 Offset: 0x21DD3D0 VA: 0x1821DEDD0
	private void OnEnable() { }

	// RVA: 0x21DED10 Offset: 0x21DD310 VA: 0x1821DED10
	private void OnDisable() { }

	// RVA: 0x21DEBC0 Offset: 0x21DD1C0 VA: 0x1821DEBC0
	private void OnDestroy() { }

	// RVA: 0x21DE850 Offset: 0x21DCE50 VA: 0x1821DE850
	public void DestroySelf() { }

	// RVA: 0x21DE8B0 Offset: 0x21DCEB0 VA: 0x1821DE8B0
	private Material GetMaterial(Material mat) { }

	// RVA: 0x21DE790 Offset: 0x21DCD90 VA: 0x1821DE790
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x21DEB20 Offset: 0x21DD120 VA: 0x1821DEB20
	private Material GetSharedMaterial() { }

	// RVA: 0x21DF080 Offset: 0x21DD680 VA: 0x1821DF080
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x21DEA90 Offset: 0x21DD090 VA: 0x1821DEA90
	public float GetPaddingForMaterial() { }

	// RVA: 0x21DF370 Offset: 0x21DD970 VA: 0x1821DF370
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x21DF0C0 Offset: 0x21DD6C0 VA: 0x1821DF0C0
	public void SetVerticesDirty() { }

	// RVA: 0x21DF070 Offset: 0x21DD670 VA: 0x1821DF070
	public void SetMaterialDirty() { }

	// RVA: 0x21DF170 Offset: 0x21DD770 VA: 0x1821DF170
	protected void UpdateMaterial() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: TMPro
[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 11495
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0xE0
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0xE8
	[SerializeField]
	private Material m_material; // 0xF0
	[SerializeField]
	private Material m_sharedMaterial; // 0xF8
	private Material m_fallbackMaterial; // 0x100
	private Material m_fallbackSourceMaterial; // 0x108
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x110
	[SerializeField]
	private float m_padding; // 0x114
	private Mesh m_mesh; // 0x118
	[SerializeField]
	private TextMeshProUGUI m_TextComponent; // 0x120
	private bool m_isRegisteredForEvents; // 0x128
	private bool m_materialDirty; // 0x129
	[SerializeField]
	private int m_materialReferenceIndex; // 0x12C
	private Transform m_RootCanvasTransform; // 0x130

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x15B42A0 Offset: 0x15B28A0 VA: 0x1815B42A0
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x21DDCF0 Offset: 0x21DC2F0 VA: 0x1821DDCF0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x21DDE10 Offset: 0x21DC410 VA: 0x1821DDE10 Slot: 32
	public override Material get_material() { }

	// RVA: 0x21DE2E0 Offset: 0x21DC8E0 VA: 0x1821DE2E0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	public Material get_sharedMaterial() { }

	// RVA: 0x21DD920 Offset: 0x21DBF20 VA: 0x1821DD920
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public Material get_fallbackMaterial() { }

	// RVA: 0x21DE150 Offset: 0x21DC750 VA: 0x1821DE150
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x21DDDB0 Offset: 0x21DC3B0 VA: 0x1821DDDB0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x161EDF0 Offset: 0x161D3F0 VA: 0x18161EDF0
	public bool get_isDefaultMaterial() { }

	// RVA: 0x161EF10 Offset: 0x161D510 VA: 0x18161EF10
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x21DE0A0 Offset: 0x21DC6A0 VA: 0x1821DE0A0
	public float get_padding() { }

	// RVA: 0x21DE3F0 Offset: 0x21DC9F0 VA: 0x1821DE3F0
	public void set_padding(float value) { }

	// RVA: 0x21DDFD0 Offset: 0x21DC5D0 VA: 0x1821DDFD0
	public Mesh get_mesh() { }

	// RVA: 0x16410B0 Offset: 0x163F6B0 VA: 0x1816410B0
	public void set_mesh(Mesh value) { }

	// RVA: 0x21DE0B0 Offset: 0x21DC6B0 VA: 0x1821DE0B0
	public TMP_Text get_textComponent() { }

	// RVA: 0x21DCAE0 Offset: 0x21DB0E0 VA: 0x1821DCAE0
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0x21DD740 Offset: 0x21DBD40 VA: 0x1821DD740 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x21DD680 Offset: 0x21DBC80 VA: 0x1821DD680 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x21DD4A0 Offset: 0x21DBAA0 VA: 0x1821DD4A0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x21DD7B0 Offset: 0x21DBDB0 VA: 0x1821DD7B0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x21DD130 Offset: 0x21DB730 VA: 0x1821DD130 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x21DD320 Offset: 0x21DB920 VA: 0x1821DD320
	public float GetPaddingForMaterial() { }

	// RVA: 0x21DD290 Offset: 0x21DB890 VA: 0x1821DD290
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x21DDC60 Offset: 0x21DC260 VA: 0x1821DDC60
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x21DD980 Offset: 0x21DBF80 VA: 0x1821DD980 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x21DD850 Offset: 0x21DBE50 VA: 0x1821DD850 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x21DD8A0 Offset: 0x21DBEA0 VA: 0x1821DD8A0
	public void SetPivotDirty() { }

	// RVA: 0x21DD3B0 Offset: 0x21DB9B0 VA: 0x1821DD3B0
	private Transform GetRootCanvasTransform() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x21DD810 Offset: 0x21DBE10 VA: 0x1821DD810 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x2183630 Offset: 0x2181C30 VA: 0x182183630
	public void RefreshMaterial() { }

	// RVA: 0x21DDA40 Offset: 0x21DC040 VA: 0x1821DDA40 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x2177660 Offset: 0x2175C60 VA: 0x182177660 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	private Material GetMaterial() { }

	// RVA: 0x21DCF80 Offset: 0x21DB580 VA: 0x1821DCF80
	private Material GetMaterial(Material mat) { }

	// RVA: 0x21DCEC0 Offset: 0x21DB4C0 VA: 0x1821DCEC0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x21DD470 Offset: 0x21DBA70 VA: 0x1821DD470
	private Material GetSharedMaterial() { }

	// RVA: 0x21DD920 Offset: 0x21DBF20 VA: 0x1821DD920
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x55D530 Offset: 0x55BB30 VA: 0x18055D530
	public void .ctor() { }
}

// Namespace: TMPro
public interface ITextElement // TypeDefIndex: 11496
{
	// Properties
	public abstract Material sharedMaterial { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material get_sharedMaterial();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Rebuild(CanvasUpdate update);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetInstanceID();
}

// Namespace: TMPro
public enum TextAlignmentOptions // TypeDefIndex: 11497
{
	// Fields
	public int value__; // 0x0
	public const TextAlignmentOptions TopLeft = 257;
	public const TextAlignmentOptions Top = 258;
	public const TextAlignmentOptions TopRight = 260;
	public const TextAlignmentOptions TopJustified = 264;
	public const TextAlignmentOptions TopFlush = 272;
	public const TextAlignmentOptions TopGeoAligned = 288;
	public const TextAlignmentOptions Left = 513;
	public const TextAlignmentOptions Center = 514;
	public const TextAlignmentOptions Right = 516;
	public const TextAlignmentOptions Justified = 520;
	public const TextAlignmentOptions Flush = 528;
	public const TextAlignmentOptions CenterGeoAligned = 544;
	public const TextAlignmentOptions BottomLeft = 1025;
	public const TextAlignmentOptions Bottom = 1026;
	public const TextAlignmentOptions BottomRight = 1028;
	public const TextAlignmentOptions BottomJustified = 1032;
	public const TextAlignmentOptions BottomFlush = 1040;
	public const TextAlignmentOptions BottomGeoAligned = 1056;
	public const TextAlignmentOptions BaselineLeft = 2049;
	public const TextAlignmentOptions Baseline = 2050;
	public const TextAlignmentOptions BaselineRight = 2052;
	public const TextAlignmentOptions BaselineJustified = 2056;
	public const TextAlignmentOptions BaselineFlush = 2064;
	public const TextAlignmentOptions BaselineGeoAligned = 2080;
	public const TextAlignmentOptions MidlineLeft = 4097;
	public const TextAlignmentOptions Midline = 4098;
	public const TextAlignmentOptions MidlineRight = 4100;
	public const TextAlignmentOptions MidlineJustified = 4104;
	public const TextAlignmentOptions MidlineFlush = 4112;
	public const TextAlignmentOptions MidlineGeoAligned = 4128;
	public const TextAlignmentOptions CaplineLeft = 8193;
	public const TextAlignmentOptions Capline = 8194;
	public const TextAlignmentOptions CaplineRight = 8196;
	public const TextAlignmentOptions CaplineJustified = 8200;
	public const TextAlignmentOptions CaplineFlush = 8208;
	public const TextAlignmentOptions CaplineGeoAligned = 8224;
	public const TextAlignmentOptions Converted = 65535;
}

// Namespace: TMPro
public enum HorizontalAlignmentOptions // TypeDefIndex: 11498
{
	// Fields
	public int value__; // 0x0
	public const HorizontalAlignmentOptions Left = 1;
	public const HorizontalAlignmentOptions Center = 2;
	public const HorizontalAlignmentOptions Right = 4;
	public const HorizontalAlignmentOptions Justified = 8;
	public const HorizontalAlignmentOptions Flush = 16;
	public const HorizontalAlignmentOptions Geometry = 32;
}

// Namespace: TMPro
public enum VerticalAlignmentOptions // TypeDefIndex: 11499
{
	// Fields
	public int value__; // 0x0
	public const VerticalAlignmentOptions Top = 256;
	public const VerticalAlignmentOptions Middle = 512;
	public const VerticalAlignmentOptions Bottom = 1024;
	public const VerticalAlignmentOptions Baseline = 2048;
	public const VerticalAlignmentOptions Geometry = 4096;
	public const VerticalAlignmentOptions Capline = 8192;
}

// Namespace: TMPro
public enum TextRenderFlags // TypeDefIndex: 11500
{
	// Fields
	public int value__; // 0x0
	public const TextRenderFlags DontRender = 0;
	public const TextRenderFlags Render = 255;
}

// Namespace: TMPro
public enum TMP_TextElementType // TypeDefIndex: 11501
{
	// Fields
	public int value__; // 0x0
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Sprite = 1;
}

// Namespace: TMPro
public enum MaskingTypes // TypeDefIndex: 11502
{
	// Fields
	public int value__; // 0x0
	public const MaskingTypes MaskOff = 0;
	public const MaskingTypes MaskHard = 1;
	public const MaskingTypes MaskSoft = 2;
}

// Namespace: TMPro
public enum TextOverflowModes // TypeDefIndex: 11503
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowModes Overflow = 0;
	public const TextOverflowModes Ellipsis = 1;
	public const TextOverflowModes Masking = 2;
	public const TextOverflowModes Truncate = 3;
	public const TextOverflowModes ScrollRect = 4;
	public const TextOverflowModes Page = 5;
	public const TextOverflowModes Linked = 6;
}

// Namespace: TMPro
public enum TextWrappingModes // TypeDefIndex: 11504
{
	// Fields
	public int value__; // 0x0
	public const TextWrappingModes NoWrap = 0;
	public const TextWrappingModes Normal = 1;
	public const TextWrappingModes PreserveWhitespace = 2;
	public const TextWrappingModes PreserveWhitespaceNoWrap = 3;
}

// Namespace: TMPro
public enum MaskingOffsetMode // TypeDefIndex: 11505
{
	// Fields
	public int value__; // 0x0
	public const MaskingOffsetMode Percentage = 0;
	public const MaskingOffsetMode Pixel = 1;
}

// Namespace: TMPro
public enum TextureMappingOptions // TypeDefIndex: 11506
{
	// Fields
	public int value__; // 0x0
	public const TextureMappingOptions Character = 0;
	public const TextureMappingOptions Line = 1;
	public const TextureMappingOptions Paragraph = 2;
	public const TextureMappingOptions MatchAspect = 3;
}

// Namespace: TMPro
[Flags]
public enum FontStyles // TypeDefIndex: 11507
{
	// Fields
	public int value__; // 0x0
	public const FontStyles Normal = 0;
	public const FontStyles Bold = 1;
	public const FontStyles Italic = 2;
	public const FontStyles Underline = 4;
	public const FontStyles LowerCase = 8;
	public const FontStyles UpperCase = 16;
	public const FontStyles SmallCaps = 32;
	public const FontStyles Strikethrough = 64;
	public const FontStyles Superscript = 128;
	public const FontStyles Subscript = 256;
	public const FontStyles Highlight = 512;
}

// Namespace: TMPro
public enum FontWeight // TypeDefIndex: 11508
{
	// Fields
	public int value__; // 0x0
	public const FontWeight Thin = 100;
	public const FontWeight ExtraLight = 200;
	public const FontWeight Light = 300;
	public const FontWeight Regular = 400;
	public const FontWeight Medium = 500;
	public const FontWeight SemiBold = 600;
	public const FontWeight Bold = 700;
	public const FontWeight Heavy = 800;
	public const FontWeight Black = 900;
}

// Namespace: TMPro
public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 11516
{
	// Fields
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_text; // 0xE0
	private bool m_IsTextBackingStringDirty; // 0xE8
	[SerializeField]
	protected ITextPreprocessor m_TextPreprocessor; // 0xF0
	[SerializeField]
	protected bool m_isRightToLeft; // 0xF8
	[SerializeField]
	protected TMP_FontAsset m_fontAsset; // 0x100
	protected TMP_FontAsset m_currentFontAsset; // 0x108
	protected bool m_isSDFShader; // 0x110
	[SerializeField]
	protected Material m_sharedMaterial; // 0x118
	protected Material m_currentMaterial; // 0x120
	protected static MaterialReference[] m_materialReferences; // 0x0
	protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x8
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
	protected int m_currentMaterialIndex; // 0x128
	[SerializeField]
	protected Material[] m_fontSharedMaterials; // 0x130
	[SerializeField]
	protected Material m_fontMaterial; // 0x138
	[SerializeField]
	protected Material[] m_fontMaterials; // 0x140
	protected bool m_isMaterialDirty; // 0x148
	[SerializeField]
	protected Color32 m_fontColor32; // 0x14C
	[SerializeField]
	protected Color m_fontColor; // 0x150
	protected static Color32 s_colorWhite; // 0x68
	protected Color32 m_underlineColor; // 0x160
	protected Color32 m_strikethroughColor; // 0x164
	internal HighlightState m_HighlightState; // 0x168
	internal bool m_ConvertToLinearSpace; // 0x17C
	[SerializeField]
	protected bool m_enableVertexGradient; // 0x17D
	[SerializeField]
	protected ColorMode m_colorMode; // 0x180
	[SerializeField]
	protected VertexGradient m_fontColorGradient; // 0x184
	[SerializeField]
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1C8
	[SerializeField]
	protected TMP_SpriteAsset m_spriteAsset; // 0x1D0
	[SerializeField]
	protected bool m_tintAllSprites; // 0x1D8
	protected bool m_tintSprite; // 0x1D9
	protected Color32 m_spriteColor; // 0x1DC
	[SerializeField]
	protected TMP_StyleSheet m_StyleSheet; // 0x1E0
	internal TMP_Style m_TextStyle; // 0x1E8
	[SerializeField]
	protected int m_TextStyleHashCode; // 0x1F0
	[SerializeField]
	protected bool m_overrideHtmlColors; // 0x1F4
	[SerializeField]
	protected Color32 m_faceColor; // 0x1F8
	protected Color32 m_outlineColor; // 0x1FC
	protected float m_outlineWidth; // 0x200
	[SerializeField]
	protected float m_fontSize; // 0x204
	protected float m_currentFontSize; // 0x208
	[SerializeField]
	protected float m_fontSizeBase; // 0x20C
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x210
	[SerializeField]
	protected FontWeight m_fontWeight; // 0x230
	protected FontWeight m_FontWeightInternal; // 0x234
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x238
	[SerializeField]
	protected bool m_enableAutoSizing; // 0x258
	protected float m_maxFontSize; // 0x25C
	protected float m_minFontSize; // 0x260
	protected int m_AutoSizeIterationCount; // 0x264
	protected int m_AutoSizeMaxIterationCount; // 0x268
	protected bool m_IsAutoSizePointSizeSet; // 0x26C
	[SerializeField]
	protected float m_fontSizeMin; // 0x270
	[SerializeField]
	protected float m_fontSizeMax; // 0x274
	[SerializeField]
	protected FontStyles m_fontStyle; // 0x278
	protected FontStyles m_FontStyleInternal; // 0x27C
	protected TMP_FontStyleStack m_fontStyleStack; // 0x280
	protected bool m_isUsingBold; // 0x28A
	[SerializeField]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x28C
	[SerializeField]
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x290
	[SerializeField]
	[FormerlySerializedAs("m_lineJustification")]
	protected TextAlignmentOptions m_textAlignment; // 0x294
	protected HorizontalAlignmentOptions m_lineJustification; // 0x298
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2A0
	protected Vector3[] m_textContainerLocalCorners; // 0x2C0
	[SerializeField]
	protected float m_characterSpacing; // 0x2C8
	protected float m_cSpacing; // 0x2CC
	protected float m_monoSpacing; // 0x2D0
	protected bool m_duoSpace; // 0x2D4
	[SerializeField]
	protected float m_wordSpacing; // 0x2D8
	[SerializeField]
	protected float m_lineSpacing; // 0x2DC
	protected float m_lineSpacingDelta; // 0x2E0
	protected float m_lineHeight; // 0x2E4
	protected bool m_IsDrivenLineSpacing; // 0x2E8
	[SerializeField]
	protected float m_lineSpacingMax; // 0x2EC
	[SerializeField]
	protected float m_paragraphSpacing; // 0x2F0
	[SerializeField]
	protected float m_charWidthMaxAdj; // 0x2F4
	protected float m_charWidthAdjDelta; // 0x2F8
	[SerializeField]
	[FormerlySerializedAs("m_enableWordWrapping")]
	protected TextWrappingModes m_TextWrappingMode; // 0x2FC
	protected bool m_isCharacterWrappingEnabled; // 0x300
	protected bool m_isNonBreakingSpace; // 0x301
	protected bool m_isIgnoringAlignment; // 0x302
	[SerializeField]
	protected float m_wordWrappingRatios; // 0x304
	[SerializeField]
	protected TextOverflowModes m_overflowMode; // 0x308
	protected int m_firstOverflowCharacterIndex; // 0x30C
	[SerializeField]
	protected TMP_Text m_linkedTextComponent; // 0x310
	[SerializeField]
	internal TMP_Text parentLinkedComponent; // 0x318
	protected bool m_isTextTruncated; // 0x320
	[SerializeField]
	protected bool m_enableKerning; // 0x321
	protected int m_LastBaseGlyphIndex; // 0x324
	[SerializeField]
	protected List<OTL_FeatureTag> m_ActiveFontFeatures; // 0x328
	[SerializeField]
	protected bool m_enableExtraPadding; // 0x330
	[SerializeField]
	protected bool checkPaddingRequired; // 0x331
	[SerializeField]
	protected bool m_isRichText; // 0x332
	[SerializeField]
	private bool m_EmojiFallbackSupport; // 0x333
	[SerializeField]
	protected bool m_parseCtrlCharacters; // 0x334
	protected bool m_isOverlay; // 0x335
	[SerializeField]
	protected bool m_isOrthographic; // 0x336
	[SerializeField]
	protected bool m_isCullingEnabled; // 0x337
	protected bool m_isMaskingEnabled; // 0x338
	protected bool isMaskUpdateRequired; // 0x339
	protected bool m_ignoreCulling; // 0x33A
	[SerializeField]
	protected TextureMappingOptions m_horizontalMapping; // 0x33C
	[SerializeField]
	protected TextureMappingOptions m_verticalMapping; // 0x340
	[SerializeField]
	protected float m_uvLineOffset; // 0x344
	protected TextRenderFlags m_renderMode; // 0x348
	[SerializeField]
	protected VertexSortingOrder m_geometrySortingOrder; // 0x34C
	[SerializeField]
	protected bool m_IsTextObjectScaleStatic; // 0x350
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x351
	protected int m_firstVisibleCharacter; // 0x354
	protected int m_maxVisibleCharacters; // 0x358
	protected int m_maxVisibleWords; // 0x35C
	protected int m_maxVisibleLines; // 0x360
	[SerializeField]
	protected bool m_useMaxVisibleDescender; // 0x364
	[SerializeField]
	protected int m_pageToDisplay; // 0x368
	protected bool m_isNewPage; // 0x36C
	[SerializeField]
	protected Vector4 m_margin; // 0x370
	protected float m_marginLeft; // 0x380
	protected float m_marginRight; // 0x384
	protected float m_marginWidth; // 0x388
	protected float m_marginHeight; // 0x38C
	protected float m_width; // 0x390
	protected TMP_TextInfo m_textInfo; // 0x398
	protected bool m_havePropertiesChanged; // 0x3A0
	[SerializeField]
	protected bool m_isUsingLegacyAnimationComponent; // 0x3A1
	protected Transform m_transform; // 0x3A8
	protected RectTransform m_rectTransform; // 0x3B0
	protected Vector2 m_PreviousRectTransformSize; // 0x3B8
	protected Vector2 m_PreviousPivotPosition; // 0x3C0
	[CompilerGenerated]
	private bool <autoSizeTextContainer>k__BackingField; // 0x3C8
	protected bool m_autoSizeTextContainer; // 0x3C9
	protected Mesh m_mesh; // 0x3D0
	[SerializeField]
	protected bool m_isVolumetricText; // 0x3D8
	[CompilerGenerated]
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
	[CompilerGenerated]
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
	[CompilerGenerated]
	private static TMP_Text.MissingCharacterEventCallback OnMissingCharacter; // 0x80
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3E0
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x3E8
	protected float m_flexibleHeight; // 0x3F0
	protected float m_flexibleWidth; // 0x3F4
	protected float m_minWidth; // 0x3F8
	protected float m_minHeight; // 0x3FC
	protected float m_maxWidth; // 0x400
	protected float m_maxHeight; // 0x404
	protected LayoutElement m_LayoutElement; // 0x408
	protected float m_preferredWidth; // 0x410
	protected float m_RenderedWidth; // 0x414
	protected bool m_isPreferredWidthDirty; // 0x418
	protected float m_preferredHeight; // 0x41C
	protected float m_RenderedHeight; // 0x420
	protected bool m_isPreferredHeightDirty; // 0x424
	protected bool m_isCalculatingPreferredValues; // 0x425
	protected int m_layoutPriority; // 0x428
	protected bool m_isLayoutDirty; // 0x42C
	protected bool m_isAwake; // 0x42D
	internal bool m_isWaitingOnResourceLoad; // 0x42E
	internal TMP_Text.TextInputSources m_inputSource; // 0x430
	protected float m_fontScaleMultiplier; // 0x434
	private static char[] m_htmlTag; // 0x88
	private static RichTextTagAttribute[] m_xmlAttribute; // 0x90
	private static float[] m_attributeParameterValues; // 0x98
	protected float tag_LineIndent; // 0x438
	protected float tag_Indent; // 0x43C
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x440
	protected bool tag_NoParsing; // 0x460
	protected bool m_isTextLayoutPhase; // 0x461
	protected Quaternion m_FXRotation; // 0x464
	protected Vector3 m_FXScale; // 0x474
	internal TMP_Text.TextProcessingElement[] m_TextProcessingArray; // 0x480
	internal int m_InternalTextProcessingArraySize; // 0x488
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x490
	protected int m_totalCharacterCount; // 0x498
	internal static WordWrapState m_SavedWordWrapState; // 0xA0
	internal static WordWrapState m_SavedLineState; // 0x458
	internal static WordWrapState m_SavedEllipsisState; // 0x810
	internal static WordWrapState m_SavedLastValidState; // 0xBC8
	internal static WordWrapState m_SavedSoftLineBreakState; // 0xF80
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1338
	protected int m_characterCount; // 0x49C
	protected int m_firstCharacterOfLine; // 0x4A0
	protected int m_firstVisibleCharacterOfLine; // 0x4A4
	protected int m_lastCharacterOfLine; // 0x4A8
	protected int m_lastVisibleCharacterOfLine; // 0x4AC
	protected int m_lineNumber; // 0x4B0
	protected int m_lineVisibleCharacterCount; // 0x4B4
	protected int m_lineVisibleSpaceCount; // 0x4B8
	protected int m_pageNumber; // 0x4BC
	protected float m_PageAscender; // 0x4C0
	protected float m_maxTextAscender; // 0x4C4
	protected float m_maxCapHeight; // 0x4C8
	protected float m_ElementAscender; // 0x4CC
	protected float m_ElementDescender; // 0x4D0
	protected float m_maxLineAscender; // 0x4D4
	protected float m_maxLineDescender; // 0x4D8
	protected float m_startOfLineAscender; // 0x4DC
	protected float m_startOfLineDescender; // 0x4E0
	protected float m_lineOffset; // 0x4E4
	protected Extents m_meshExtents; // 0x4E8
	protected Color32 m_htmlColor; // 0x4F8
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x500
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x520
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x540
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x560
	protected TMP_ColorGradient m_colorGradientPreset; // 0x590
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x598
	protected bool m_colorGradientPresetIsTinted; // 0x5C0
	protected float m_tabSpacing; // 0x5C4
	protected float m_spacing; // 0x5C8
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x5D0
	protected int m_TextStyleStackDepth; // 0x5D8
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x5E0
	protected int m_ItalicAngle; // 0x600
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x608
	protected float m_padding; // 0x628
	protected float m_baselineOffset; // 0x62C
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x630
	protected float m_xAdvance; // 0x650
	protected TMP_TextElementType m_textElementType; // 0x654
	protected TMP_TextElement m_cached_TextElement; // 0x658
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x660
	protected TMP_Text.SpecialCharacter m_Underline; // 0x680
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x6A0
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x6A8
	protected int m_spriteCount; // 0x6B0
	protected int m_spriteIndex; // 0x6B4
	protected int m_spriteAnimationID; // 0x6B8
	private static ProfilerMarker k_ParseTextMarker; // 0x1710
	private static ProfilerMarker k_InsertNewLineMarker; // 0x1718
	protected bool m_ignoreActiveState; // 0x6BC
	private TMP_Text.TextBackingContainer m_TextBackingArray; // 0x6C0
	private readonly Decimal[] k_Power; // 0x6D0
	protected static Vector2 k_LargePositiveVector2; // 0x1720
	protected static Vector2 k_LargeNegativeVector2; // 0x1728
	protected static float k_LargePositiveFloat; // 0x1730
	protected static float k_LargeNegativeFloat; // 0x1734
	protected static int k_LargePositiveInt; // 0x1738
	protected static int k_LargeNegativeInt; // 0x173C

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public TextWrappingModes textWrappingMode { get; set; }
	[Obsolete("The enabledWordWrapping property is now obsolete. Please use the textWrappingMode property instead.")]
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	[Obsolete("The "enableKerning" property has been deprecated. Use the "fontFeatures" property to control what features are enabled on the text component.")]
	public bool enableKerning { get; set; }
	public List<OTL_FeatureTag> fontFeatures { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool emojiFallbackSupport { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x21CB710 Offset: 0x21C9D10 VA: 0x1821CB710 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x21CD1F0 Offset: 0x21CB7F0 VA: 0x1821CD1F0 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x551B80 Offset: 0x550180 VA: 0x180551B80
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x551B90 Offset: 0x550190 VA: 0x180551B90
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x21CADA0 Offset: 0x21C93A0 VA: 0x1821CADA0
	public bool get_isRightToLeftText() { }

	// RVA: 0x21CC940 Offset: 0x21CAF40 VA: 0x1821CC940
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public TMP_FontAsset get_font() { }

	// RVA: 0x21CC730 Offset: 0x21CAD30 VA: 0x1821CC730
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x21CC4C0 Offset: 0x21CAAC0 VA: 0x1821CC4C0 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x21CACC0 Offset: 0x21C92C0 VA: 0x1821CACC0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x21CC470 Offset: 0x21CAA70 VA: 0x1821CC470 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x21CAC80 Offset: 0x21C9280 VA: 0x1821CAC80
	public Material get_fontMaterial() { }

	// RVA: 0x21CC360 Offset: 0x21CA960 VA: 0x1821CC360
	public void set_fontMaterial(Material value) { }

	// RVA: 0x21CACA0 Offset: 0x21C92A0 VA: 0x1821CACA0 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x21CC470 Offset: 0x21CAA70 VA: 0x1821CC470 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x21CAA70 Offset: 0x21C9070 VA: 0x1821CAA70 Slot: 22
	public override Color get_color() { }

	// RVA: 0x21CBEC0 Offset: 0x21CA4C0 VA: 0x1821CBEC0 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x21CA930 Offset: 0x21C8F30 VA: 0x1821CA930
	public float get_alpha() { }

	// RVA: 0x21CBD30 Offset: 0x21CA330 VA: 0x1821CBD30
	public void set_alpha(float value) { }

	// RVA: 0x21CAB00 Offset: 0x21C9100 VA: 0x1821CAB00
	public bool get_enableVertexGradient() { }

	// RVA: 0x21CC180 Offset: 0x21CA780 VA: 0x1821CC180
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x21CAA40 Offset: 0x21C9040 VA: 0x1821CAA40
	public VertexGradient get_colorGradient() { }

	// RVA: 0x21CBE70 Offset: 0x21CA470 VA: 0x1821CBE70
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x21AE240 Offset: 0x21AC840 VA: 0x1821AE240
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x21CBE30 Offset: 0x21CA430 VA: 0x1821CBE30
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x21AE2B0 Offset: 0x21AC8B0 VA: 0x1821AE2B0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x21CD090 Offset: 0x21CB690 VA: 0x1821CD090
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x21CB800 Offset: 0x21C9E00 VA: 0x1821CB800
	public bool get_tintAllSprites() { }

	// RVA: 0x21CD2A0 Offset: 0x21CB8A0 VA: 0x1821CD2A0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x21AE2A0 Offset: 0x21AC8A0 VA: 0x1821AE2A0
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x21CD0E0 Offset: 0x21CB6E0 VA: 0x1821CD0E0
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x21CB680 Offset: 0x21C9C80 VA: 0x1821CB680
	public TMP_Style get_textStyle() { }

	// RVA: 0x21CD130 Offset: 0x21CB730 VA: 0x1821CD130
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x21CB150 Offset: 0x21C9750 VA: 0x1821CB150
	public bool get_overrideColorTags() { }

	// RVA: 0x21CCF10 Offset: 0x21CB510 VA: 0x1821CCF10
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x21CAB40 Offset: 0x21C9140 VA: 0x1821CAB40
	public Color32 get_faceColor() { }

	// RVA: 0x21CC250 Offset: 0x21CA850 VA: 0x1821CC250
	public void set_faceColor(Color32 value) { }

	// RVA: 0x21CAF80 Offset: 0x21C9580 VA: 0x1821CAF80
	public Color32 get_outlineColor() { }

	// RVA: 0x21CCDF0 Offset: 0x21CB3F0 VA: 0x1821CCDF0
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x21CB070 Offset: 0x21C9670 VA: 0x1821CB070
	public float get_outlineWidth() { }

	// RVA: 0x21CCE60 Offset: 0x21CB460 VA: 0x1821CCE60
	public void set_outlineWidth(float value) { }

	// RVA: 0x21CAD00 Offset: 0x21C9300 VA: 0x1821CAD00
	public float get_fontSize() { }

	// RVA: 0x21CC620 Offset: 0x21CAC20 VA: 0x1821CC620
	public void set_fontSize(float value) { }

	// RVA: 0x21CAD20 Offset: 0x21C9320 VA: 0x1821CAD20
	public FontWeight get_fontWeight() { }

	// RVA: 0x21CC6E0 Offset: 0x21CACE0 VA: 0x1821CC6E0
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x21CB190 Offset: 0x21C9790 VA: 0x1821CB190
	public float get_pixelsPerUnit() { }

	// RVA: 0x21CAA90 Offset: 0x21C9090 VA: 0x1821CAA90
	public bool get_enableAutoSizing() { }

	// RVA: 0x21CBFA0 Offset: 0x21CA5A0 VA: 0x1821CBFA0
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x21CACF0 Offset: 0x21C92F0 VA: 0x1821CACF0
	public float get_fontSizeMin() { }

	// RVA: 0x21CC5D0 Offset: 0x21CABD0 VA: 0x1821CC5D0
	public void set_fontSizeMin(float value) { }

	// RVA: 0x21CACE0 Offset: 0x21C92E0 VA: 0x1821CACE0
	public float get_fontSizeMax() { }

	// RVA: 0x21CC580 Offset: 0x21CAB80 VA: 0x1821CC580
	public void set_fontSizeMax(float value) { }

	// RVA: 0x21CAD10 Offset: 0x21C9310 VA: 0x1821CAD10
	public FontStyles get_fontStyle() { }

	// RVA: 0x21CC690 Offset: 0x21CAC90 VA: 0x1821CC690
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x21CADE0 Offset: 0x21C93E0 VA: 0x1821CADE0
	public bool get_isUsingBold() { }

	// RVA: 0x21CAD50 Offset: 0x21C9350 VA: 0x1821CAD50
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x21CC840 Offset: 0x21CAE40 VA: 0x1821CC840
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x21CB8D0 Offset: 0x21C9ED0 VA: 0x1821CB8D0
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x21CD320 Offset: 0x21CB920 VA: 0x1821CD320
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x21CA920 Offset: 0x21C8F20 VA: 0x1821CA920
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x21CBCF0 Offset: 0x21CA2F0 VA: 0x1821CBCF0
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x21CAA20 Offset: 0x21C9020 VA: 0x1821CAA20
	public float get_characterSpacing() { }

	// RVA: 0x21CBD70 Offset: 0x21CA370 VA: 0x1821CBD70
	public void set_characterSpacing(float value) { }

	// RVA: 0x21CB8F0 Offset: 0x21C9EF0 VA: 0x1821CB8F0
	public float get_wordSpacing() { }

	// RVA: 0x21CD380 Offset: 0x21CB980 VA: 0x1821CD380
	public void set_wordSpacing(float value) { }

	// RVA: 0x21CAED0 Offset: 0x21C94D0 VA: 0x1821CAED0
	public float get_lineSpacing() { }

	// RVA: 0x21CCB00 Offset: 0x21CB100 VA: 0x1821CCB00
	public void set_lineSpacing(float value) { }

	// RVA: 0x21CAEC0 Offset: 0x21C94C0 VA: 0x1821CAEC0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x21CCAA0 Offset: 0x21CB0A0 VA: 0x1821CCAA0
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x21CB170 Offset: 0x21C9770 VA: 0x1821CB170
	public float get_paragraphSpacing() { }

	// RVA: 0x21CCF70 Offset: 0x21CB570 VA: 0x1821CCF70
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x21CAA30 Offset: 0x21C9030 VA: 0x1821CAA30
	public float get_characterWidthAdjustment() { }

	// RVA: 0x21CBDD0 Offset: 0x21CA3D0 VA: 0x1821CBDD0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x21CB700 Offset: 0x21C9D00 VA: 0x1821CB700
	public TextWrappingModes get_textWrappingMode() { }

	// RVA: 0x21CD1A0 Offset: 0x21CB7A0 VA: 0x1821CD1A0
	public void set_textWrappingMode(TextWrappingModes value) { }

	// RVA: 0x21CAB10 Offset: 0x21C9110 VA: 0x1821CAB10
	public bool get_enableWordWrapping() { }

	// RVA: 0x21CC1B0 Offset: 0x21CA7B0 VA: 0x1821CC1B0
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x21CB900 Offset: 0x21C9F00 VA: 0x1821CB900
	public float get_wordWrappingRatios() { }

	// RVA: 0x21CD3E0 Offset: 0x21CB9E0 VA: 0x1821CD3E0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x21CB140 Offset: 0x21C9740 VA: 0x1821CB140
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x21CCEC0 Offset: 0x21CB4C0 VA: 0x1821CCEC0
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x21CADC0 Offset: 0x21C93C0 VA: 0x1821CADC0
	public bool get_isTextOverflowing() { }

	// RVA: 0x21CAC30 Offset: 0x21C9230 VA: 0x1821CAC30
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x21CAEE0 Offset: 0x21C94E0 VA: 0x1821CAEE0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x21CCB60 Offset: 0x21CB160 VA: 0x1821CCB60
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x21CADD0 Offset: 0x21C93D0 VA: 0x1821CADD0
	public bool get_isTextTruncated() { }

	// RVA: 0x21CAAB0 Offset: 0x21C90B0 VA: 0x1821CAAB0
	public bool get_enableKerning() { }

	// RVA: 0x21CC030 Offset: 0x21CA630 VA: 0x1821CC030
	public void set_enableKerning(bool value) { }

	// RVA: 0x21CAC70 Offset: 0x21C9270 VA: 0x1821CAC70
	public List<OTL_FeatureTag> get_fontFeatures() { }

	// RVA: 0x21CC300 Offset: 0x21CA900 VA: 0x1821CC300
	public void set_fontFeatures(List<OTL_FeatureTag> value) { }

	// RVA: 0x21CAB30 Offset: 0x21C9130 VA: 0x1821CAB30
	public bool get_extraPadding() { }

	// RVA: 0x21CC200 Offset: 0x21CA800 VA: 0x1821CC200
	public void set_extraPadding(bool value) { }

	// RVA: 0x21CB480 Offset: 0x21C9A80 VA: 0x1821CB480
	public bool get_richText() { }

	// RVA: 0x21CD040 Offset: 0x21CB640 VA: 0x1821CD040
	public void set_richText(bool value) { }

	// RVA: 0x21CAA80 Offset: 0x21C9080 VA: 0x1821CAA80
	public bool get_emojiFallbackSupport() { }

	// RVA: 0x21CBF50 Offset: 0x21CA550 VA: 0x1821CBF50
	public void set_emojiFallbackSupport(bool value) { }

	// RVA: 0x21CB180 Offset: 0x21C9780 VA: 0x1821CB180
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x21CCFD0 Offset: 0x21CB5D0 VA: 0x1821CCFD0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x21CAD90 Offset: 0x21C9390 VA: 0x1821CAD90
	public bool get_isOverlay() { }

	// RVA: 0x21CC8F0 Offset: 0x21CAEF0 VA: 0x1821CC8F0
	public void set_isOverlay(bool value) { }

	// RVA: 0x21CAD80 Offset: 0x21C9380 VA: 0x1821CAD80
	public bool get_isOrthographic() { }

	// RVA: 0x21CC8C0 Offset: 0x21CAEC0 VA: 0x1821CC8C0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x21CAAA0 Offset: 0x21C90A0 VA: 0x1821CAAA0
	public bool get_enableCulling() { }

	// RVA: 0x21CBFF0 Offset: 0x21CA5F0 VA: 0x1821CBFF0
	public void set_enableCulling(bool value) { }

	// RVA: 0x21CAD70 Offset: 0x21C9370 VA: 0x1821CAD70
	public bool get_ignoreVisibility() { }

	// RVA: 0x21CC8A0 Offset: 0x21CAEA0 VA: 0x1821CC8A0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x21CAD60 Offset: 0x21C9360 VA: 0x1821CAD60
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x21CC870 Offset: 0x21CAE70 VA: 0x1821CC870
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x21CB8E0 Offset: 0x21C9EE0 VA: 0x1821CB8E0
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x21CD350 Offset: 0x21CB950 VA: 0x1821CD350
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x21CAEF0 Offset: 0x21C94F0 VA: 0x1821CAEF0
	public float get_mappingUvLineOffset() { }

	// RVA: 0x21CCC70 Offset: 0x21CB270 VA: 0x1821CCC70
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x21CB470 Offset: 0x21C9A70 VA: 0x1821CB470
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x21CD020 Offset: 0x21CB620 VA: 0x1821CD020
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x21CAD30 Offset: 0x21C9330 VA: 0x1821CAD30
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x21CC800 Offset: 0x21CAE00 VA: 0x1821CC800
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x21CADB0 Offset: 0x21C93B0 VA: 0x1821CADB0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x21CC990 Offset: 0x21CAF90 VA: 0x1821CC990
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x21CB8C0 Offset: 0x21C9EC0 VA: 0x1821CB8C0
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x21CD300 Offset: 0x21CB900 VA: 0x1821CD300
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x21CAC40 Offset: 0x21C9240 VA: 0x1821CAC40
	public int get_firstVisibleCharacter() { }

	// RVA: 0x21CC2D0 Offset: 0x21CA8D0 VA: 0x1821CC2D0
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x21CAF20 Offset: 0x21C9520 VA: 0x1821CAF20
	public int get_maxVisibleCharacters() { }

	// RVA: 0x21CCD60 Offset: 0x21CB360 VA: 0x1821CCD60
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x21CAF40 Offset: 0x21C9540 VA: 0x1821CAF40
	public int get_maxVisibleWords() { }

	// RVA: 0x21CCDC0 Offset: 0x21CB3C0 VA: 0x1821CCDC0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x21CAF30 Offset: 0x21C9530 VA: 0x1821CAF30
	public int get_maxVisibleLines() { }

	// RVA: 0x21CCD90 Offset: 0x21CB390 VA: 0x1821CCD90
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x21CB8B0 Offset: 0x21C9EB0 VA: 0x1821CB8B0
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x21CD2D0 Offset: 0x21CB8D0 VA: 0x1821CD2D0
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x21CB160 Offset: 0x21C9760 VA: 0x1821CB160
	public int get_pageToDisplay() { }

	// RVA: 0x21CCF40 Offset: 0x21CB540 VA: 0x1821CCF40
	public void set_pageToDisplay(int value) { }

	// RVA: 0x21CAF00 Offset: 0x21C9500 VA: 0x1821CAF00 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x21CCCA0 Offset: 0x21CB2A0 VA: 0x1821CCCA0 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x21CB600 Offset: 0x21C9C00 VA: 0x1821CB600
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x21CAD40 Offset: 0x21C9340 VA: 0x1821CAD40
	public bool get_havePropertiesChanged() { }

	// RVA: 0x21CC820 Offset: 0x21CAE20 VA: 0x1821CC820
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x21CADF0 Offset: 0x21C93F0 VA: 0x1821CADF0
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x21CCA20 Offset: 0x21CB020 VA: 0x1821CCA20
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x21CB810 Offset: 0x21C9E10 VA: 0x1821CB810
	public Transform get_transform() { }

	// RVA: 0x21CB3D0 Offset: 0x21C99D0 VA: 0x1821CB3D0
	public RectTransform get_rectTransform() { }

	[CompilerGenerated]
	// RVA: 0x21CA940 Offset: 0x21C8F40 VA: 0x1821CA940 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGenerated]
	// RVA: 0x21CBD60 Offset: 0x21CA360 VA: 0x1821CBD60 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x217D610 Offset: 0x217BC10 VA: 0x18217D610 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x21CAE00 Offset: 0x21C9400 VA: 0x1821CAE00
	public bool get_isVolumetricText() { }

	// RVA: 0x21CCA30 Offset: 0x21CB030 VA: 0x1821CCA30
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x21CA950 Offset: 0x21C8F50 VA: 0x1821CA950
	public Bounds get_bounds() { }

	// RVA: 0x21CB5A0 Offset: 0x21C9BA0 VA: 0x1821CB5A0
	public Bounds get_textBounds() { }

	[CompilerGenerated]
	// RVA: 0x21CA540 Offset: 0x21C8B40 VA: 0x1821CA540
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x21CB910 Offset: 0x21C9F10 VA: 0x1821CB910
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x21CA810 Offset: 0x21C8E10 VA: 0x1821CA810
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x21CBBE0 Offset: 0x21CA1E0 VA: 0x1821CBBE0
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x21CA650 Offset: 0x21C8C50 VA: 0x1821CA650
	public static void add_OnMissingCharacter(TMP_Text.MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	// RVA: 0x21CBA20 Offset: 0x21CA020 VA: 0x1821CBA20
	public static void remove_OnMissingCharacter(TMP_Text.MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	// RVA: 0x21CA750 Offset: 0x21C8D50 VA: 0x1821CA750 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x21CBB20 Offset: 0x21CA120 VA: 0x1821CBB20 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x21CB490 Offset: 0x21C9A90 VA: 0x1821CB490
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x21CAC50 Offset: 0x21C9250 VA: 0x1821CAC50 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x21CAC60 Offset: 0x21C9260 VA: 0x1821CAC60 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x21CAF70 Offset: 0x21C9570 VA: 0x1821CAF70 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x21CAF60 Offset: 0x21C9560 VA: 0x1821CAF60 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x21CAF50 Offset: 0x21C9550 VA: 0x1821CAF50
	public float get_maxWidth() { }

	// RVA: 0x21CAF10 Offset: 0x21C9510 VA: 0x1821CAF10
	public float get_maxHeight() { }

	// RVA: 0x21CAE10 Offset: 0x21C9410 VA: 0x1821CAE10
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x21CB3B0 Offset: 0x21C99B0 VA: 0x1821CB3B0 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x21CB390 Offset: 0x21C9990 VA: 0x1821CB390 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x21B9CB0 Offset: 0x21B82B0 VA: 0x1821B9CB0 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x21B9BD0 Offset: 0x21B81D0 VA: 0x1821B9BD0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x21CAEB0 Offset: 0x21C94B0 VA: 0x1821CAEB0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x21B4AB0 Offset: 0x21B30B0 VA: 0x1821B4AB0 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x21C2750 Offset: 0x21C0D50 VA: 0x1821C2750
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x21B8DF0 Offset: 0x21B73F0 VA: 0x1821B8DF0 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x21B8F40 Offset: 0x21B7540 VA: 0x1821B8F40 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x21B4BE0 Offset: 0x21B31E0 VA: 0x1821B4BE0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x21B4B70 Offset: 0x21B3170 VA: 0x1821B4B70 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x21BD410 Offset: 0x21BBA10 VA: 0x1821BD410
	protected void ParseInputText() { }

	// RVA: 0x21BD900 Offset: 0x21BBF00 VA: 0x1821BD900
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x21BD700 Offset: 0x21BBD00 VA: 0x1821BD700
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x21BD5F0 Offset: 0x21BBBF0 VA: 0x1821BD5F0
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x21BD800 Offset: 0x21BBE00 VA: 0x1821BD800
	private void PopulateTextBackingArray(char[] sourceText, int start, int length) { }

	// RVA: 0x21BD9E0 Offset: 0x21BBFE0 VA: 0x1821BD9E0
	private void PopulateTextProcessingArray() { }

	// RVA: 0x21C1E60 Offset: 0x21C0460 VA: 0x1821C1E60
	private void SetTextInternal(string sourceText) { }

	// RVA: 0x21C22A0 Offset: 0x21C08A0 VA: 0x1821C22A0
	public void SetText(string sourceText) { }

	[Obsolete("Use the SetText(string) function instead.")]
	// RVA: 0x21C22A0 Offset: 0x21C08A0 VA: 0x1821C22A0
	public void SetText(string sourceText, bool syncTextInputBox = True) { }

	// RVA: 0x21C25A0 Offset: 0x21C0BA0 VA: 0x1821C25A0
	public void SetText(string sourceText, float arg0) { }

	// RVA: 0x21C1F60 Offset: 0x21C0560 VA: 0x1821C1F60
	public void SetText(string sourceText, float arg0, float arg1) { }

	// RVA: 0x21C2500 Offset: 0x21C0B00 VA: 0x1821C2500
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	// RVA: 0x21C2550 Offset: 0x21C0B50 VA: 0x1821C2550
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x21C24A0 Offset: 0x21C0AA0 VA: 0x1821C24A0
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x21C23D0 Offset: 0x21C09D0 VA: 0x1821C23D0
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x21C2430 Offset: 0x21C0A30 VA: 0x1821C2430
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x21C1FF0 Offset: 0x21C05F0 VA: 0x1821C1FF0
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x21C1FA0 Offset: 0x21C05A0 VA: 0x1821C1FA0
	public void SetText(StringBuilder sourceText) { }

	// RVA: 0x21C25F0 Offset: 0x21C0BF0 VA: 0x1821C25F0
	private void SetText(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x21C1E30 Offset: 0x21C0430 VA: 0x1821C1E30
	public void SetText(char[] sourceText) { }

	// RVA: 0x21C25E0 Offset: 0x21C0BE0 VA: 0x1821C25E0
	public void SetText(char[] sourceText, int start, int length) { }

	// RVA: 0x21C1E30 Offset: 0x21C0430 VA: 0x1821C1E30
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x21C1CE0 Offset: 0x21C02E0 VA: 0x1821C1CE0
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x21B9EE0 Offset: 0x21B84E0 VA: 0x1821B9EE0
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x21BC720 Offset: 0x21BAD20 VA: 0x1821BC720
	private void InsertOpeningTextStyle(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x21BBC20 Offset: 0x21BA220 VA: 0x1821BBC20
	private void InsertClosingTextStyle(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x21BC7E0 Offset: 0x21BADE0 VA: 0x1821BC7E0
	private void InsertTextStyleInTextProcessingArray(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition) { }

	// RVA: 0x21BEC10 Offset: 0x21BD210 VA: 0x1821BEC10
	private bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x21BEA80 Offset: 0x21BD080 VA: 0x1821BEA80
	private bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x21BE9C0 Offset: 0x21BCFC0 VA: 0x1821BE9C0
	private void ReplaceClosingStyleTag(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x21BC670 Offset: 0x21BAC70 VA: 0x1821BC670
	private void InsertOpeningStyleTag(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x21BBB70 Offset: 0x21BA170 VA: 0x1821BBB70
	private void InsertClosingStyleTag(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x21B8C70 Offset: 0x21B7270 VA: 0x1821B8C70
	private int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x21B8D30 Offset: 0x21B7330 VA: 0x1821B8D30
	private int GetMarkupTagHashCode(TMP_Text.TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x21B9E00 Offset: 0x21B8400 VA: 0x1821B9E00
	private int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x21B9D10 Offset: 0x21B8310 VA: 0x1821B9D10
	private int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0920 Offset: 0x7BEF20 VA: 0x1807C0920
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x7C0A00 Offset: 0x7BF000 VA: 0x1807C0A00
	|-TMP_Text.ResizeInternalArray<TMP_Text.TextProcessingElement>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C08B0 Offset: 0x7BEEB0 VA: 0x1807C08B0
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x7C0990 Offset: 0x7BEF90 VA: 0x1807C0990
	|-TMP_Text.ResizeInternalArray<TMP_Text.TextProcessingElement>
	*/

	// RVA: 0x21B04F0 Offset: 0x21AEAF0 VA: 0x1821B04F0
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x21B0990 Offset: 0x21AEF90 VA: 0x1821B0990
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x21BCC10 Offset: 0x21BB210 VA: 0x1821BCC10
	private string InternalTextBackingArrayToString() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 114
	internal virtual int SetArraySizes(TMP_Text.TextProcessingElement[] unicodeChars) { }

	// RVA: 0x21B9860 Offset: 0x21B7E60 VA: 0x1821B9860
	public Vector2 GetPreferredValues() { }

	// RVA: 0x21B9420 Offset: 0x21B7A20 VA: 0x1821B9420
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x21B94A0 Offset: 0x21B7AA0 VA: 0x1821B94A0
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x21B9650 Offset: 0x21B7C50 VA: 0x1821B9650
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x21B98C0 Offset: 0x21B7EC0 VA: 0x1821B98C0
	protected float GetPreferredWidth() { }

	// RVA: 0x21B9A70 Offset: 0x21B8070 VA: 0x1821B9A70
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x21B9B10 Offset: 0x21B8110 VA: 0x1821B9B10
	private float GetPreferredWidth(Vector2 margin, TextWrappingModes wrapMode) { }

	// RVA: 0x21B9210 Offset: 0x21B7810 VA: 0x1821B9210
	protected float GetPreferredHeight() { }

	// RVA: 0x21B9150 Offset: 0x21B7750 VA: 0x1821B9150
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x21B9C40 Offset: 0x21B8240 VA: 0x1821B9C40
	public Vector2 GetRenderedValues() { }

	// RVA: 0x21B9C00 Offset: 0x21B8200 VA: 0x1821B9C00
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x21B9CB0 Offset: 0x21B82B0 VA: 0x1821B9CB0
	private float GetRenderedWidth() { }

	// RVA: 0x21B9C80 Offset: 0x21B8280 VA: 0x1821B9C80
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x21B9BD0 Offset: 0x21B81D0 VA: 0x1821B9BD0
	private float GetRenderedHeight() { }

	// RVA: 0x21B9BA0 Offset: 0x21B81A0 VA: 0x1821B9BA0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x21B0F90 Offset: 0x21AF590 VA: 0x1821B0F90 Slot: 115
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingModes textWrapMode) { }

	// RVA: 0x86A2D0 Offset: 0x8688D0 VA: 0x18086A2D0 Slot: 116
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x21B8880 Offset: 0x21B6E80 VA: 0x1821B8880 Slot: 117
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x21BA370 Offset: 0x21B8970 VA: 0x1821BA370
	protected Bounds GetTextBounds() { }

	// RVA: 0x21BA010 Offset: 0x21B8610 VA: 0x1821BA010
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x21B0AF0 Offset: 0x21AF0F0 VA: 0x1821B0AF0
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x21BEE10 Offset: 0x21BD410 VA: 0x1821BEE10
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 118
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 119
	public virtual void ComputeMarginSize() { }

	// RVA: 0x21BBCE0 Offset: 0x21BA2E0 VA: 0x1821BBCE0
	internal void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x21C1700 Offset: 0x21BFD00 VA: 0x1821C1700
	internal void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x21BF0B0 Offset: 0x21BD6B0 VA: 0x1821BF0B0
	internal int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x21BF6D0 Offset: 0x21BDCD0 VA: 0x1821BF6D0 Slot: 120
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x21C0CB0 Offset: 0x21BF2B0 VA: 0x1821C0CB0 Slot: 121
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x21B73B0 Offset: 0x21B59B0 VA: 0x1821B73B0 Slot: 122
	protected virtual void FillCharacterVertexBuffers(int i) { }

	// RVA: 0x21B6530 Offset: 0x21B4B30 VA: 0x1821B6530 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, bool isVolumetric) { }

	// RVA: 0x21B7D20 Offset: 0x21B6320 VA: 0x1821B7D20 Slot: 124
	protected virtual void FillSpriteVertexBuffers(int i) { }

	// RVA: 0x21B53B0 Offset: 0x21B39B0 VA: 0x1821B53B0 Slot: 125
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x21B4D30 Offset: 0x21B3330 VA: 0x1821B4D30 Slot: 126
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x21BCED0 Offset: 0x21BB4D0 VA: 0x1821BCED0
	protected void LoadDefaultSettings() { }

	// RVA: 0x21B9CE0 Offset: 0x21B82E0 VA: 0x1821B9CE0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x21B88B0 Offset: 0x21B6EB0 VA: 0x1821B88B0
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x21BB0F0 Offset: 0x21B96F0 VA: 0x1821BB0F0
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x21BEDB0 Offset: 0x21BD3B0 VA: 0x1821BEDB0
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x21B8BE0 Offset: 0x21B71E0 VA: 0x1821B8BE0
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x21BA670 Offset: 0x21B8C70 VA: 0x1821BA670
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 127
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 128
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 129
	public virtual void ClearMesh() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 130
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x21B9060 Offset: 0x21B7660 VA: 0x1821B9060 Slot: 131
	public virtual string GetParsedText() { }

	// RVA: 0x21BCCE0 Offset: 0x21BB2E0 VA: 0x1821BCCE0
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x21BE890 Offset: 0x21BCE90 VA: 0x1821BE890
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x21B4C80 Offset: 0x21B3280 VA: 0x1821B4C80
	protected void DoMissingGlyphCallback(int unicode, int stringIndex, TMP_FontAsset fontAsset) { }

	// RVA: 0x21BD3D0 Offset: 0x21BB9D0 VA: 0x1821BD3D0
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x21BD390 Offset: 0x21BB990 VA: 0x1821BD390
	protected float PackUV(float x, float y) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 132
	internal virtual void InternalUpdate() { }

	// RVA: 0x21BBA60 Offset: 0x21BA060 VA: 0x1821BBA60
	protected uint HexToInt(char hex) { }

	// RVA: 0x21BCDD0 Offset: 0x21BB3D0 VA: 0x1821BCDD0
	private bool IsValidUTF16(TMP_Text.TextBackingContainer text, int index) { }

	// RVA: 0x21BAC70 Offset: 0x21B9270 VA: 0x1821BAC70
	private uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x21BAD40 Offset: 0x21B9340 VA: 0x1821BAD40
	private uint GetUTF16(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x21BCE50 Offset: 0x21BB450 VA: 0x1821BCE50
	private bool IsValidUTF32(TMP_Text.TextBackingContainer text, int index) { }

	// RVA: 0x21BAE10 Offset: 0x21B9410 VA: 0x1821BAE10
	private uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x21BAF90 Offset: 0x21B9590 VA: 0x1821BAF90
	private uint GetUTF32(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x21BB490 Offset: 0x21B9A90 VA: 0x1821BB490
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x21BB1C0 Offset: 0x21B97C0 VA: 0x1821BB1C0
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x21B8690 Offset: 0x21B6C90 VA: 0x1821B8690
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x21B4A80 Offset: 0x21B3080 VA: 0x1821B4A80
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x21B4900 Offset: 0x21B2F00 VA: 0x1821B4900
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x21B4820 Offset: 0x21B2E20 VA: 0x1821B4820
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x21C2800 Offset: 0x21C0E00 VA: 0x1821C2800
	internal bool ValidateHtmlTag(TMP_Text.TextProcessingElement[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x21C97C0 Offset: 0x21C7DC0 VA: 0x1821C97C0
	protected void .ctor() { }

	// RVA: 0x21C91C0 Offset: 0x21C77C0 VA: 0x1821C91C0
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TextElementType // TypeDefIndex: 11517
{
	// Fields
	public byte value__; // 0x0
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement // TypeDefIndex: 11518
{
	// Fields
	[SerializeField]
	internal TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TMP_Asset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TMP_Asset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public TextElementType get_elementType() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public uint get_unicode() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_unicode(uint value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public TMP_Asset get_textAsset() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_textAsset(TMP_Asset value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Glyph get_glyph() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_glyph(Glyph value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public uint get_glyphIndex() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_glyphIndex(uint value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0
	public float get_scale() { }

	// RVA: 0x1853730 Offset: 0x1851D30 VA: 0x181853730
	public void set_scale(float value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement_Legacy // TypeDefIndex: 11519
{
	// Fields
	public int id; // 0x10
	public float x; // 0x14
	public float y; // 0x18
	public float width; // 0x1C
	public float height; // 0x20
	public float xOffset; // 0x24
	public float yOffset; // 0x28
	public float xAdvance; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextInfo // TypeDefIndex: 11520
{
	// Fields
	internal static Vector2 k_InfinityVectorPositive; // 0x0
	internal static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x21E0880 Offset: 0x21DEE80 VA: 0x1821E0880
	public void .ctor() { }

	// RVA: 0x21E0B70 Offset: 0x21DF170 VA: 0x1821E0B70
	internal void .ctor(int characterCount) { }

	// RVA: 0x21E09C0 Offset: 0x21DEFC0 VA: 0x1821E09C0
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x21E0100 Offset: 0x21DE700 VA: 0x1821E0100
	internal void Clear() { }

	// RVA: 0x21DF8F0 Offset: 0x21DDEF0 VA: 0x1821DF8F0
	internal void ClearAllData() { }

	// RVA: 0x21DFE50 Offset: 0x21DE450 VA: 0x1821DFE50
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x21DFA30 Offset: 0x21DE030 VA: 0x1821DFA30
	public void ClearAllMeshInfo() { }

	// RVA: 0x21E0760 Offset: 0x21DED60 VA: 0x1821E0760
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x21E0040 Offset: 0x21DE640 VA: 0x1821E0040
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x21DFAE0 Offset: 0x21DE0E0 VA: 0x1821DFAE0
	internal void ClearLineInfo() { }

	// RVA: 0x21DFF10 Offset: 0x21DE510 VA: 0x1821DFF10
	internal void ClearPageInfo() { }

	// RVA: 0x21E0180 Offset: 0x21DE780 VA: 0x1821E0180
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0780 Offset: 0x7BED80 VA: 0x1807C0780
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	|
	|-RVA: 0x7C0650 Offset: 0x7BEC50 VA: 0x1807C0650
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0800 Offset: 0x7BEE00 VA: 0x1807C0800
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	|
	|-RVA: 0x7C06D0 Offset: 0x7BECD0 VA: 0x1807C06D0
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21E0820 Offset: 0x21DEE20 VA: 0x1821E0820
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_TextParsingUtilities // TypeDefIndex: 11521
{
	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x0
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x21E1610 Offset: 0x21DFC10 VA: 0x1821E1610
	private static void .cctor() { }

	// RVA: 0x21E1680 Offset: 0x21DFC80 VA: 0x1821E1680
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x21E0D20 Offset: 0x21DF320 VA: 0x1821E0D20
	public static int GetHashCode(string s) { }

	// RVA: 0x21E0CC0 Offset: 0x21DF2C0 VA: 0x1821E0CC0
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x21E1490 Offset: 0x21DFA90 VA: 0x1821E1490
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x21E15B0 Offset: 0x21DFBB0 VA: 0x1821E15B0
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x21E1550 Offset: 0x21DFB50 VA: 0x1821E1550
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x21E14F0 Offset: 0x21DFAF0 VA: 0x1821E14F0
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x21E1450 Offset: 0x21DFA50 VA: 0x1821E1450
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x21E1470 Offset: 0x21DFA70 VA: 0x1821E1470
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x21E0CB0 Offset: 0x21DF2B0 VA: 0x1821E0CB0
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x21E0FE0 Offset: 0x21DF5E0 VA: 0x1821E0FE0
	internal static bool IsDiacriticalMark(uint c) { }

	// RVA: 0x21E0E00 Offset: 0x21DF400 VA: 0x1821E0E00
	internal static bool IsBaseGlyph(uint c) { }

	// RVA: 0x21E1030 Offset: 0x21DF630 VA: 0x1821E1030
	internal static bool IsEmoji(uint c) { }

	// RVA: 0x21E13F0 Offset: 0x21DF9F0 VA: 0x1821E13F0
	internal static bool IsHangul(uint c) { }

	// RVA: 0x21E0F10 Offset: 0x21DF510 VA: 0x1821E0F10
	internal static bool IsCJK(uint c) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: TMPro
internal enum TextProcessingElementType // TypeDefIndex: 11522
{
	// Fields
	public int value__; // 0x0
	public const TextProcessingElementType Undefined = 0;
	public const TextProcessingElementType TextCharacterElement = 1;
	public const TextProcessingElementType TextMarkupElement = 2;
}

// Namespace: TMPro
internal struct CharacterElement // TypeDefIndex: 11523
{
	// Fields
	private uint m_Unicode; // 0x0
	private TMP_TextElement m_TextElement; // 0x8

	// Properties
	public uint Unicode { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public uint get_Unicode() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_Unicode(uint value) { }

	// RVA: 0x21E2D90 Offset: 0x21E1390 VA: 0x1821E2D90
	public void .ctor(TMP_TextElement textElement) { }
}

// Namespace: TMPro
internal struct MarkupAttribute // TypeDefIndex: 11524
{
	// Fields
	private int m_NameHashCode; // 0x0
	private int m_ValueHashCode; // 0x4
	private int m_ValueStartIndex; // 0x8
	private int m_ValueLength; // 0xC

	// Properties
	public int NameHashCode { get; set; }
	public int ValueHashCode { get; set; }
	public int ValueStartIndex { get; set; }
	public int ValueLength { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_NameHashCode() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_NameHashCode(int value) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_ValueHashCode() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_ValueHashCode(int value) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_ValueStartIndex() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_ValueStartIndex(int value) { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_ValueLength() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_ValueLength(int value) { }
}

// Namespace: TMPro
internal struct MarkupElement // TypeDefIndex: 11525
{
	// Fields
	private MarkupAttribute[] m_Attributes; // 0x0

	// Properties
	public int NameHashCode { get; set; }
	public int ValueHashCode { get; set; }
	public int ValueStartIndex { get; set; }
	public int ValueLength { get; set; }
	public MarkupAttribute[] Attributes { get; set; }

	// Methods

	// RVA: 0x21E2E70 Offset: 0x21E1470 VA: 0x1821E2E70
	public int get_NameHashCode() { }

	// RVA: 0x21E2F30 Offset: 0x21E1530 VA: 0x1821E2F30
	public void set_NameHashCode(int value) { }

	// RVA: 0x21E2EA0 Offset: 0x21E14A0 VA: 0x1821E2EA0
	public int get_ValueHashCode() { }

	// RVA: 0x21E2FB0 Offset: 0x21E15B0 VA: 0x1821E2FB0
	public void set_ValueHashCode(int value) { }

	// RVA: 0x21E2F00 Offset: 0x21E1500 VA: 0x1821E2F00
	public int get_ValueStartIndex() { }

	// RVA: 0x21E3010 Offset: 0x21E1610 VA: 0x1821E3010
	public void set_ValueStartIndex(int value) { }

	// RVA: 0x21E2ED0 Offset: 0x21E14D0 VA: 0x1821E2ED0
	public int get_ValueLength() { }

	// RVA: 0x21E2FE0 Offset: 0x21E15E0 VA: 0x1821E2FE0
	public void set_ValueLength(int value) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public MarkupAttribute[] get_Attributes() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void set_Attributes(MarkupAttribute[] value) { }

	// RVA: 0x21E2DC0 Offset: 0x21E13C0 VA: 0x1821E2DC0
	public void .ctor(int nameHashCode, int startIndex, int length) { }
}

// Namespace: TMPro
[DebuggerDisplay("{DebuggerDisplay()}")]
internal struct TextProcessingElement // TypeDefIndex: 11526
{
	// Fields
	private TextProcessingElementType m_ElementType; // 0x0
	private int m_StartIndex; // 0x4
	private int m_Length; // 0x8
	private CharacterElement m_CharacterElement; // 0x10
	private MarkupElement m_MarkupElement; // 0x20

	// Properties
	public TextProcessingElementType ElementType { get; set; }
	public int StartIndex { get; set; }
	public int Length { get; set; }
	public CharacterElement CharacterElement { get; }
	public MarkupElement MarkupElement { get; set; }
	public static TextProcessingElement Undefined { get; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public TextProcessingElementType get_ElementType() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_ElementType(TextProcessingElementType value) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_StartIndex() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_StartIndex(int value) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_Length() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_Length(int value) { }

	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public CharacterElement get_CharacterElement() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public MarkupElement get_MarkupElement() { }

	// RVA: 0x21EB300 Offset: 0x21E9900 VA: 0x1821EB300
	public void set_MarkupElement(MarkupElement value) { }

	// RVA: 0x21EB2C0 Offset: 0x21E98C0 VA: 0x1821EB2C0
	public void .ctor(TextProcessingElementType elementType, int startIndex, int length) { }

	// RVA: 0x21EB260 Offset: 0x21E9860 VA: 0x1821EB260
	public void .ctor(TMP_TextElement textElement, int startIndex, int length) { }

	// RVA: 0x21EB1D0 Offset: 0x21E97D0 VA: 0x1821EB1D0
	public void .ctor(CharacterElement characterElement, int startIndex, int length) { }

	// RVA: 0x21EB210 Offset: 0x21E9810 VA: 0x1821EB210
	public void .ctor(MarkupElement markupElement) { }

	// RVA: 0x21EB2E0 Offset: 0x21E98E0 VA: 0x1821EB2E0
	public static TextProcessingElement get_Undefined() { }

	// RVA: 0x21EB0E0 Offset: 0x21E96E0 VA: 0x1821EB0E0
	private string DebuggerDisplay() { }
}

// Namespace: TMPro
public struct TMP_FontStyleStack // TypeDefIndex: 11527
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x21E3360 Offset: 0x21E1960 VA: 0x1821E3360
	public void Clear() { }

	// RVA: 0x21E32B0 Offset: 0x21E18B0 VA: 0x1821E32B0
	public byte Add(FontStyles style) { }

	// RVA: 0x21E3370 Offset: 0x21E1970 VA: 0x1821E3370
	public byte Remove(FontStyles style) { }
}

// Namespace: TMPro
[DebuggerDisplay("Item count = {m_Count}")]
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 11528
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5BB0 Offset: 0x9C41B0 VA: 0x1809C5BB0
	|-TMP_TextProcessingStack<Color32>..ctor
	|-TMP_TextProcessingStack<int>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x9C59E0 Offset: 0x9C3FE0 VA: 0x1809C59E0
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x9CC400 Offset: 0x9CAA00 VA: 0x1809CC400
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x9CC770 Offset: 0x9CAD70 VA: 0x1809CC770
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x9CC070 Offset: 0x9CA670 VA: 0x1809CC070
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x9CC460 Offset: 0x9CAA60 VA: 0x1809CC460
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5A30 Offset: 0x9C4030 VA: 0x1809C5A30
	|-TMP_TextProcessingStack<Color32>..ctor
	|-TMP_TextProcessingStack<int>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x9C5B30 Offset: 0x9C4130 VA: 0x1809C5B30
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x9CBC30 Offset: 0x9CA230 VA: 0x1809CBC30
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x9CBD50 Offset: 0x9CA350 VA: 0x1809CBD50
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x9CBCC0 Offset: 0x9CA2C0 VA: 0x1809CBCC0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x9CC170 Offset: 0x9CA770 VA: 0x1809CC170
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5960 Offset: 0x9C3F60 VA: 0x1809C5960
	|-TMP_TextProcessingStack<Color32>..ctor
	|-TMP_TextProcessingStack<int>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x9C5AA0 Offset: 0x9C40A0 VA: 0x1809C5AA0
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x9CC0D0 Offset: 0x9CA6D0 VA: 0x1809CC0D0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x9CBBA0 Offset: 0x9CA1A0 VA: 0x1809CBBA0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x9CC6D0 Offset: 0x9CACD0 VA: 0x1809CC6D0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x9CBDD0 Offset: 0x9CA3D0 VA: 0x1809CBDD0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-TMP_TextProcessingStack<Color32>.get_Count
	|-TMP_TextProcessingStack<int>.get_Count
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x9CC7C0 Offset: 0x9CADC0 VA: 0x1809CC7C0
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x9CC7D0 Offset: 0x9CADD0 VA: 0x1809CC7D0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4FF0 Offset: 0x9C35F0 VA: 0x1809C4FF0
	|-TMP_TextProcessingStack<Color32>.get_current
	|-TMP_TextProcessingStack<int>.get_current
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x9C4F80 Offset: 0x9C3580 VA: 0x1809C4F80
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x9C82A0 Offset: 0x9C68A0 VA: 0x1809C82A0
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x9C8340 Offset: 0x9C6940 VA: 0x1809C8340
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x9C8550 Offset: 0x9C6B50 VA: 0x1809C8550
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x9C85A0 Offset: 0x9C6BA0 VA: 0x1809C85A0
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x9C8390 Offset: 0x9C6990 VA: 0x1809C8390
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x9CC870 Offset: 0x9CAE70 VA: 0x1809CC870
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x9CC820 Offset: 0x9CAE20 VA: 0x1809CC820
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x9CC920 Offset: 0x9CAF20 VA: 0x1809CC920
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x9CC890 Offset: 0x9CAE90 VA: 0x1809CC890
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x9CC8A0 Offset: 0x9CAEA0 VA: 0x1809CC8A0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5590 Offset: 0x9C3B90 VA: 0x1809C5590
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x9C5820 Offset: 0x9C3E20 VA: 0x1809C5820
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x9CAB40 Offset: 0x9C9140 VA: 0x1809CAB40
	|-TMP_TextProcessingStack<int>.SetDefault
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x9CB560 Offset: 0x9C9B60 VA: 0x1809CB560
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x9CB920 Offset: 0x9C9F20 VA: 0x1809CB920
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x9CB0D0 Offset: 0x9C96D0 VA: 0x1809CB0D0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x9CB2D0 Offset: 0x9C98D0 VA: 0x1809CB2D0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x9CB6C0 Offset: 0x9C9CC0 VA: 0x1809CB6C0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4F60 Offset: 0x9C3560 VA: 0x1809C4F60
	|-TMP_TextProcessingStack<Color32>.Clear
	|-TMP_TextProcessingStack<int>.Clear
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x9C4F70 Offset: 0x9C3570 VA: 0x1809C4F70
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x9C8290 Offset: 0x9C6890 VA: 0x1809C8290
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x9C8190 Offset: 0x9C6790 VA: 0x1809C8190
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x9C8280 Offset: 0x9C6880 VA: 0x1809C8280
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x9C81A0 Offset: 0x9C67A0 VA: 0x1809C81A0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5770 Offset: 0x9C3D70 VA: 0x1809C5770
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x9C56B0 Offset: 0x9C3CB0 VA: 0x1809C56B0
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x9CAC60 Offset: 0x9C9260 VA: 0x1809CAC60
	|-TMP_TextProcessingStack<int>.SetDefault
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x9CB1F0 Offset: 0x9C97F0 VA: 0x1809CB1F0
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x9CB4A0 Offset: 0x9C9AA0 VA: 0x1809CB4A0
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x9CB870 Offset: 0x9C9E70 VA: 0x1809CB870
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x9CBA50 Offset: 0x9CA050 VA: 0x1809CBA50
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x9CAD10 Offset: 0x9C9310 VA: 0x1809CAD10
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4F20 Offset: 0x9C3520 VA: 0x1809C4F20
	|-TMP_TextProcessingStack<Color32>.Add
	|-TMP_TextProcessingStack<int>.Add
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x9C4ED0 Offset: 0x9C34D0 VA: 0x1809C4ED0
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x9C8040 Offset: 0x9C6640 VA: 0x1809C8040
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x9C7CE0 Offset: 0x9C62E0 VA: 0x1809C7CE0
	|-TMP_TextProcessingStack<object>.Add
	|
	|-RVA: 0x9C8000 Offset: 0x9C6600 VA: 0x1809C8000
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x9C80C0 Offset: 0x9C66C0 VA: 0x1809C80C0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x9C7D30 Offset: 0x9C6330 VA: 0x1809C7D30
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C54A0 Offset: 0x9C3AA0 VA: 0x1809C54A0
	|-TMP_TextProcessingStack<Color32>.Remove
	|-TMP_TextProcessingStack<int>.Remove
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x9C5500 Offset: 0x9C3B00 VA: 0x1809C5500
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x9CAA20 Offset: 0x9C9020 VA: 0x1809CAA20
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x9CAAE0 Offset: 0x9C90E0 VA: 0x1809CAAE0
	|-TMP_TextProcessingStack<object>.Remove
	|
	|-RVA: 0x9CA610 Offset: 0x9C8C10 VA: 0x1809CA610
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x9CA5A0 Offset: 0x9C8BA0 VA: 0x1809CA5A0
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x9CA680 Offset: 0x9C8C80 VA: 0x1809CA680
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C53E0 Offset: 0x9C39E0 VA: 0x1809C53E0
	|-TMP_TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x9C5310 Offset: 0x9C3910 VA: 0x1809C5310
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x9C9D10 Offset: 0x9C8310 VA: 0x1809C9D10
	|-TMP_TextProcessingStack<int>.Push
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x9C99E0 Offset: 0x9C7FE0 VA: 0x1809C99E0
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x9C9AE0 Offset: 0x9C80E0 VA: 0x1809C9AE0
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x9CA4D0 Offset: 0x9C8AD0 VA: 0x1809CA4D0
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x9C9BB0 Offset: 0x9C81B0 VA: 0x1809C9BB0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x9C9DD0 Offset: 0x9C83D0 VA: 0x1809C9DD0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C50E0 Offset: 0x9C36E0 VA: 0x1809C50E0
	|-TMP_TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x9C5180 Offset: 0x9C3780 VA: 0x1809C5180
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x9C8990 Offset: 0x9C6F90 VA: 0x1809C8990
	|-TMP_TextProcessingStack<int>.Pop
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x9C8A20 Offset: 0x9C7020 VA: 0x1809C8A20
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x9C95E0 Offset: 0x9C7BE0 VA: 0x1809C95E0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x9C9550 Offset: 0x9C7B50 VA: 0x1809C9550
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x9C8B80 Offset: 0x9C7180 VA: 0x1809C8B80
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x9C8DF0 Offset: 0x9C73F0 VA: 0x1809C8DF0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C50A0 Offset: 0x9C36A0 VA: 0x1809C50A0
	|-TMP_TextProcessingStack<Color32>.Peek
	|-TMP_TextProcessingStack<int>.Peek
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x9C5040 Offset: 0x9C3640 VA: 0x1809C5040
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x9C8700 Offset: 0x9C6D00 VA: 0x1809C8700
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x9C86C0 Offset: 0x9C6CC0 VA: 0x1809C86C0
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x9C8790 Offset: 0x9C6D90 VA: 0x1809C8790
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x9C85F0 Offset: 0x9C6BF0 VA: 0x1809C85F0
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x9C87D0 Offset: 0x9C6DD0 VA: 0x1809C87D0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4FF0 Offset: 0x9C35F0 VA: 0x1809C4FF0
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	|-TMP_TextProcessingStack<int>.CurrentItem
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x9C4F80 Offset: 0x9C3580 VA: 0x1809C4F80
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x9C82A0 Offset: 0x9C68A0 VA: 0x1809C82A0
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x9C8340 Offset: 0x9C6940 VA: 0x1809C8340
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x9C8550 Offset: 0x9C6B50 VA: 0x1809C8550
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x9C85A0 Offset: 0x9C6BA0 VA: 0x1809C85A0
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x9C8390 Offset: 0x9C6990 VA: 0x1809C8390
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C52C0 Offset: 0x9C38C0 VA: 0x1809C52C0
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	|-TMP_TextProcessingStack<int>.PreviousItem
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x9C5250 Offset: 0x9C3850 VA: 0x1809C5250
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x9C98F0 Offset: 0x9C7EF0 VA: 0x1809C98F0
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x9C9990 Offset: 0x9C7F90 VA: 0x1809C9990
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x9C9850 Offset: 0x9C7E50 VA: 0x1809C9850
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x9C98A0 Offset: 0x9C7EA0 VA: 0x1809C98A0
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x9C9690 Offset: 0x9C7C90 VA: 0x1809C9690
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.PreviousItem
	*/
}

// Namespace: TMPro
public enum CaretPosition // TypeDefIndex: 11529
{
	// Fields
	public int value__; // 0x0
	public const CaretPosition None = 0;
	public const CaretPosition Left = 1;
	public const CaretPosition Right = 2;
}

// Namespace: TMPro
public struct CaretInfo // TypeDefIndex: 11530
{
	// Fields
	public int index; // 0x0
	public CaretPosition position; // 0x4

	// Methods

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int index, CaretPosition position) { }
}

// Namespace: TMPro
public static class TMP_TextUtilities // TypeDefIndex: 11532
{
	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x0
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x21E79F0 Offset: 0x21E5FF0 VA: 0x1821E79F0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x21E7BD0 Offset: 0x21E61D0 VA: 0x1821E7BD0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x21E58F0 Offset: 0x21E3EF0 VA: 0x1821E58F0
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x21E4CC0 Offset: 0x21E32C0 VA: 0x1821E4CC0
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x21E8400 Offset: 0x21E6A00 VA: 0x1821E8400
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x21E3680 Offset: 0x21E1C80 VA: 0x1821E3680
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x21E5310 Offset: 0x21E3910 VA: 0x1821E5310
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x21E4460 Offset: 0x21E2A60 VA: 0x1821E4460
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x21E6AA0 Offset: 0x21E50A0 VA: 0x1821E6AA0
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x21E3AA0 Offset: 0x21E20A0 VA: 0x1821E3AA0
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x21E3CB0 Offset: 0x21E22B0 VA: 0x1821E3CB0
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x21E5B90 Offset: 0x21E4190 VA: 0x1821E5B90
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x21E86A0 Offset: 0x21E6CA0 VA: 0x1821E86A0
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x21E8820 Offset: 0x21E6E20 VA: 0x1821E8820
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x21E8220 Offset: 0x21E6820 VA: 0x1821E8220
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x21E34A0 Offset: 0x21E1AA0 VA: 0x1821E34A0
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x21E8DE0 Offset: 0x21E73E0 VA: 0x1821E8DE0
	public static char ToLowerFast(char c) { }

	// RVA: 0x21E8EA0 Offset: 0x21E74A0 VA: 0x1821E8EA0
	public static char ToUpperFast(char c) { }

	// RVA: 0x21E8E40 Offset: 0x21E7440 VA: 0x1821E8E40
	internal static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x21E7F40 Offset: 0x21E6540 VA: 0x1821E7F40
	public static int GetHashCode(string s) { }

	// RVA: 0x21E0CC0 Offset: 0x21DF2C0 VA: 0x1821E0CC0
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x21E8030 Offset: 0x21E6630 VA: 0x1821E8030
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x21E7E60 Offset: 0x21E6460 VA: 0x1821E7E60
	public static uint GetHashCodeCaseInSensitive(string s) { }

	// RVA: 0x21E8110 Offset: 0x21E6710 VA: 0x1821E8110
	public static int HexToInt(char hex) { }

	// RVA: 0x21E8BF0 Offset: 0x21E71F0 VA: 0x1821E8BF0
	public static int StringHexToInt(string s) { }

	// RVA: 0x21E8F00 Offset: 0x21E7500 VA: 0x1821E8F00
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateManager // TypeDefIndex: 11533
{
	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
	private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
	private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
	private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x8
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

	// Properties
	private static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x21EA130 Offset: 0x21E8730 VA: 0x1821EA130
	private static TMP_UpdateManager get_instance() { }

	// RVA: 0x21E9F10 Offset: 0x21E8510 VA: 0x1821E9F10
	private void .ctor() { }

	// RVA: 0x21E9A20 Offset: 0x21E8020 VA: 0x1821E9A20
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x21E9470 Offset: 0x21E7A70 VA: 0x1821E9470
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x21E9920 Offset: 0x21E7F20 VA: 0x1821E9920
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x21E93B0 Offset: 0x21E79B0 VA: 0x1821E93B0
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x21E9820 Offset: 0x21E7E20 VA: 0x1821E9820
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x21E92F0 Offset: 0x21E78F0 VA: 0x1821E92F0
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x21E9720 Offset: 0x21E7D20 VA: 0x1821E9720
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x21E9230 Offset: 0x21E7830 VA: 0x1821E9230
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x21E9710 Offset: 0x21E7D10 VA: 0x1821E9710
	private void OnCameraPreCull() { }

	// RVA: 0x21E8F70 Offset: 0x21E7570 VA: 0x1821E8F70
	private void DoRebuilds() { }

	// RVA: 0x21E9CF0 Offset: 0x21E82F0 VA: 0x1821E9CF0
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x21E9B20 Offset: 0x21E8120 VA: 0x1821E9B20
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x21E9530 Offset: 0x21E7B30 VA: 0x1821E9530
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x21E95D0 Offset: 0x21E7BD0 VA: 0x1821E95D0
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x21E9670 Offset: 0x21E7C70 VA: 0x1821E9670
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x21E9DC0 Offset: 0x21E83C0 VA: 0x1821E9DC0
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateRegistry // TypeDefIndex: 11534
{
	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private HashSet<int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private HashSet<int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x21EAF00 Offset: 0x21E9500 VA: 0x1821EAF00
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x21EADA0 Offset: 0x21E93A0 VA: 0x1821EADA0
	protected void .ctor() { }

	// RVA: 0x21EAA90 Offset: 0x21E9090 VA: 0x1821EAA90
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x21EA340 Offset: 0x21E8940 VA: 0x1821EA340
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x21EA970 Offset: 0x21E8F70 VA: 0x1821EA970
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x21EA210 Offset: 0x21E8810 VA: 0x1821EA210
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x21EA650 Offset: 0x21E8C50 VA: 0x1821EA650
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x21EA910 Offset: 0x21E8F10 VA: 0x1821EA910
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x21EABB0 Offset: 0x21E91B0 VA: 0x1821EABB0
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x21EA560 Offset: 0x21E8B60 VA: 0x1821EA560
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x21EA470 Offset: 0x21E8A70 VA: 0x1821EA470
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }
}

