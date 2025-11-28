// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class Character : TextElement // TypeDefIndex: 12297
{
	// Methods

	// RVA: 0x23E9AE0 Offset: 0x23E80E0 VA: 0x1823E9AE0
	public void .ctor() { }

	// RVA: 0x23E9B10 Offset: 0x23E8110 VA: 0x1823E9B10
	public void .ctor(uint unicode, FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x23E9A60 Offset: 0x23E8060 VA: 0x1823E9A60
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class ColorUtilities // TypeDefIndex: 12298
{
	// Methods

	// RVA: 0x23E9BB0 Offset: 0x23E81B0 VA: 0x1823E9BB0
	internal static bool CompareColors(Color32 a, Color32 b) { }

	// RVA: 0x23E9BF0 Offset: 0x23E81F0 VA: 0x1823E9BF0
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2) { }
}

// Namespace: UnityEngine.TextCore.Text
public enum OTL_FeatureTag // TypeDefIndex: 12299
{
	// Fields
	public uint value__; // 0x0
	public const OTL_FeatureTag kern = 1801810542;
	public const OTL_FeatureTag liga = 1818847073;
	public const OTL_FeatureTag mark = 1835102827;
	public const OTL_FeatureTag mkmk = 1835756907;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontFeatureTable // TypeDefIndex: 12301
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
	internal List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords { get; }
	internal List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords { get; }

	// Methods

	// RVA: 0x234CC80 Offset: 0x234B280 VA: 0x18234CC80
	internal List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	// RVA: 0x2358D10 Offset: 0x2357310 VA: 0x182358D10
	internal List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	// RVA: 0x23F74F0 Offset: 0x23F5AF0 VA: 0x1823F74F0
	internal void .ctor() { }

	// RVA: 0x23F6E30 Offset: 0x23F5430 VA: 0x1823F6E30
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x23F7070 Offset: 0x23F5670 VA: 0x1823F7070
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x23F72B0 Offset: 0x23F58B0 VA: 0x1823F72B0
	public void SortMarkToMarkAdjustmentRecords() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Extents // TypeDefIndex: 12302
{
	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x23E9CD0 Offset: 0x23E82D0 VA: 0x1823E9CD0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct LineInfo // TypeDefIndex: 12303
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int wordCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharacterIndex; // 0x20
	public float length; // 0x24
	public float lineHeight; // 0x28
	public float ascender; // 0x2C
	public float baseline; // 0x30
	public float descender; // 0x34
	public float maxAdvance; // 0x38
	public float width; // 0x3C
	public float marginLeft; // 0x40
	public float marginRight; // 0x44
	public TextAlignment alignment; // 0x48
	public Extents lineExtents; // 0x4C
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct LinkInfo // TypeDefIndex: 12304
{
	// Fields
	public int hashCode; // 0x0
	public int linkIdFirstCharacterIndex; // 0x4
	public int linkIdLength; // 0x8
	public int linkTextfirstCharacterIndex; // 0xC
	public int linkTextLength; // 0x10
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal char[] linkId; // 0x18
	private string m_LinkIdString; // 0x20
	private string m_LinkTextString; // 0x28

	// Methods

	// RVA: 0x23F7890 Offset: 0x23F5E90 VA: 0x1823F7890
	internal void SetLinkId(char[] text, int startIndex, int length) { }

	// RVA: 0x23F77B0 Offset: 0x23F5DB0 VA: 0x1823F77B0
	public string GetLinkText(TextInfo textInfo) { }

	// RVA: 0x23F7760 Offset: 0x23F5D60 VA: 0x1823F7760
	public string GetLinkId() { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class MaterialManager // TypeDefIndex: 12305
{
	// Fields
	private static Dictionary<long, Material> s_FallbackMaterials; // 0x0

	// Methods

	// RVA: 0x23F7C90 Offset: 0x23F6290 VA: 0x1823F7C90
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x23F8160 Offset: 0x23F6760 VA: 0x1823F8160
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x23F7990 Offset: 0x23F5F90 VA: 0x1823F7990
	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	// RVA: 0x23F86C0 Offset: 0x23F6CC0 VA: 0x1823F86C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct MaterialReference // TypeDefIndex: 12306
{
	// Fields
	public int index; // 0x0
	public FontAsset fontAsset; // 0x8
	public SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isFallbackMaterial; // 0x20
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x23F99F0 Offset: 0x23F7FF0 VA: 0x1823F99F0
	public void .ctor(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x23F9560 Offset: 0x23F7B60 VA: 0x1823F9560
	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x23F97A0 Offset: 0x23F7DA0 VA: 0x1823F97A0
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class MaterialReferenceManager // TypeDefIndex: 12307
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x23F9390 Offset: 0x23F7990 VA: 0x1823F9390
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x23F8A00 Offset: 0x23F7000 VA: 0x1823F8A00
	public static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x23F8880 Offset: 0x23F6E80 VA: 0x1823F8880
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	// RVA: 0x23F8D50 Offset: 0x23F7350 VA: 0x1823F8D50
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x23F8C70 Offset: 0x23F7270 VA: 0x1823F8C70
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x23F8C00 Offset: 0x23F7200 VA: 0x1823F8C00
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x23F8B90 Offset: 0x23F7190 VA: 0x1823F8B90
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x23F87E0 Offset: 0x23F6DE0 VA: 0x1823F87E0
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x23F8750 Offset: 0x23F6D50 VA: 0x1823F8750
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x23F8FC0 Offset: 0x23F75C0 VA: 0x1823F8FC0
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x23F8F40 Offset: 0x23F7540 VA: 0x1823F8F40
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x23F91C0 Offset: 0x23F77C0 VA: 0x1823F91C0
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x23F9140 Offset: 0x23F7740 VA: 0x1823F9140
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x23F8EC0 Offset: 0x23F74C0 VA: 0x1823F8EC0
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x23F8E40 Offset: 0x23F7440 VA: 0x1823F8E40
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x23F90C0 Offset: 0x23F76C0 VA: 0x1823F90C0
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x23F9040 Offset: 0x23F7640 VA: 0x1823F9040
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x23F9240 Offset: 0x23F7840 VA: 0x1823F9240
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum VertexSortingOrder // TypeDefIndex: 12308
{
	// Fields
	public int value__; // 0x0
	public const VertexSortingOrder Normal = 0;
	public const VertexSortingOrder Reverse = 1;
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum VertexDataLayout // TypeDefIndex: 12309
{
	// Fields
	public int value__; // 0x0
	public const VertexDataLayout Mesh = 0;
	public const VertexDataLayout VBO = 1;
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct MeshInfo // TypeDefIndex: 12310
{
	// Fields
	public int vertexCount; // 0x0
	public TextCoreVertex[] vertexData; // 0x8
	public Material material; // 0x10
	[Ignore]
	private static readonly Color32 k_DefaultColor; // 0x0
	[Ignore]
	private static readonly Vector3 k_DefaultNormal; // 0x4
	[Ignore]
	private static readonly Vector4 k_DefaultTangent; // 0x10
	[Ignore]
	public Vector3[] vertices; // 0x18
	[Ignore]
	public Vector3[] normals; // 0x20
	[Ignore]
	public Vector4[] tangents; // 0x28
	[Ignore]
	public int vertexBufferSize; // 0x30
	[Ignore]
	public Vector4[] uvs0; // 0x38
	[Ignore]
	public Vector2[] uvs2; // 0x40
	[Ignore]
	public Color32[] colors32; // 0x48
	[Ignore]
	public int[] triangles; // 0x50
	[Ignore]
	public VertexDataLayout vertexDataLayout; // 0x58
	[Ignore]
	public bool applySDF; // 0x5C
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal GlyphRenderMode glyphRenderMode; // 0x60

	// Methods

	// RVA: 0x23FA940 Offset: 0x23F8F40 VA: 0x1823FA940
	public void .ctor(int size, VertexDataLayout layout, bool isIMGUI) { }

	// RVA: 0x23F9B60 Offset: 0x23F8160 VA: 0x1823F9B60
	internal void ResizeMeshInfo(int size, bool isIMGUI) { }

	// RVA: 0x23F9AF0 Offset: 0x23F80F0 VA: 0x1823F9AF0
	internal void Clear(bool uploadChanges) { }

	// RVA: 0x23F9A70 Offset: 0x23F8070 VA: 0x1823F9A70
	internal void ClearUnusedVertices() { }

	// RVA: 0x23F9DB0 Offset: 0x23F83B0 VA: 0x1823F9DB0
	internal void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x23F9E60 Offset: 0x23F8460 VA: 0x1823F9E60
	internal void SwapVertexData(int src, int dst) { }

	// RVA: 0x23FA8B0 Offset: 0x23F8EB0 VA: 0x1823FA8B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum TextFontWeight // TypeDefIndex: 12311
{
	// Fields
	public int value__; // 0x0
	public const TextFontWeight Thin = 100;
	public const TextFontWeight ExtraLight = 200;
	public const TextFontWeight Light = 300;
	public const TextFontWeight Regular = 400;
	public const TextFontWeight Medium = 500;
	public const TextFontWeight SemiBold = 600;
	public const TextFontWeight Bold = 700;
	public const TextFontWeight Heavy = 800;
	public const TextFontWeight Black = 900;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public struct FontWeightPair // TypeDefIndex: 12312
{
	// Fields
	public FontAsset regularTypeface; // 0x0
	public FontAsset italicTypeface; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
[Serializable]
public struct FontAssetCreationEditorSettings // TypeDefIndex: 12313
{
	// Fields
	public string sourceFontFileGUID; // 0x0
	public int faceIndex; // 0x8
	public int pointSizeSamplingMode; // 0xC
	public int pointSize; // 0x10
	public int padding; // 0x14
	public int paddingMode; // 0x18
	public int packingMode; // 0x1C
	public int atlasWidth; // 0x20
	public int atlasHeight; // 0x24
	public int characterSetSelectionMode; // 0x28
	public string characterSequence; // 0x30
	public string referencedFontAssetGUID; // 0x38
	public string referencedTextAssetGUID; // 0x40
	public int fontStyle; // 0x48
	public float fontStyleModifier; // 0x4C
	public int renderMode; // 0x50
	public bool includeFontFeatures; // 0x54
}

// Namespace: UnityEngine.TextCore.Text
public enum AtlasPopulationMode // TypeDefIndex: 12314
{
	// Fields
	public int value__; // 0x0
	public const AtlasPopulationMode Static = 0;
	public const AtlasPopulationMode Dynamic = 1;
	public const AtlasPopulationMode DynamicOS = 2;
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[Serializable]
public class FontAsset : TextAsset // TypeDefIndex: 12316
{
	// Fields
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
	[SerializeField]
	private Font m_SourceFontFile; // 0x98
	[SerializeField]
	private string m_SourceFontFilePath; // 0xA0
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0xA8
	[SerializeField]
	internal bool InternalDynamicOS; // 0xAC
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0xB0
	private int m_FamilyNameHashCode; // 0x110
	private int m_StyleNameHashCode; // 0x114
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0x118
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x120
	[SerializeField]
	internal List<Character> m_CharacterTable; // 0x128
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal Dictionary<uint, Character> m_CharacterLookupDictionary; // 0x130
	private readonly ReaderWriterLockSlim characterLookupLock; // 0x138
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
	internal FontFeatureTable m_FontFeatureTable; // 0x178
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; // 0x180
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable; // 0x188
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; // 0x190
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight; // 0x198
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	internal float m_RegularStyleSpacing; // 0x19C
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	internal float m_BoldStyleWeight; // 0x1A0
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing; // 0x1A4
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	internal byte m_ItalicStyleSlant; // 0x1A8
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple; // 0x1A9
	internal bool IsFontAssetLookupTablesDirty; // 0x1AA
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
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x60
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x68
	private static List<FontAsset> k_FontAssets_KerningUpdateQueue; // 0x70
	private static HashSet<int> k_FontAssets_KerningUpdateQueueLookup; // 0x78
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x80
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x88
	private List<Glyph> m_GlyphsToRender; // 0x1B0
	private List<Glyph> m_GlyphsRendered; // 0x1B8
	private List<uint> m_GlyphIndexList; // 0x1C0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1C8
	internal List<uint> m_GlyphsToAdd; // 0x1D0
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1D8
	internal List<Character> m_CharactersToAdd; // 0x1E0
	internal HashSet<uint> m_CharactersToAddLookup; // 0x1E8
	internal List<uint> s_MissingCharacterList; // 0x1F0
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x1F8
	internal Dictionary<ValueTuple<uint, uint>, uint> m_VariantGlyphIndexes; // 0x200
	internal static uint[] k_GlyphIndexArray; // 0x90

	// Properties
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<Character> characterTable { get; set; }
	public Dictionary<uint, Character> characterLookupTable { get; }
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
	public FontFeatureTable fontFeatureTable { get; set; }
	public List<FontAsset> fallbackFontAssetTable { get; set; }
	public FontWeightPair[] fontWeightTable { get; set; }
	public float regularStyleWeight { get; set; }
	public float regularStyleSpacing { get; set; }
	public float boldStyleWeight { get; set; }
	public float boldStyleSpacing { get; set; }
	public byte italicStyleSlant { get; set; }
	public byte tabMultiple { get; set; }

	// Methods

	// RVA: 0x23F6B80 Offset: 0x23F5180 VA: 0x1823F6B80
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	// RVA: 0x23F6D90 Offset: 0x23F5390 VA: 0x1823F6D90
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	// RVA: 0x237AF70 Offset: 0x2379570 VA: 0x18237AF70
	public Font get_sourceFontFile() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x23F6970 Offset: 0x23F4F70 VA: 0x1823F6970
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x204F0B0 Offset: 0x204D6B0 VA: 0x18204F0B0
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x23F6AD0 Offset: 0x23F50D0 VA: 0x1823F6AD0
	public FaceInfo get_faceInfo() { }

	// RVA: 0x23F6D40 Offset: 0x23F5340 VA: 0x1823F6D40
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x23F6B30 Offset: 0x23F5130 VA: 0x1823F6B30
	internal int get_familyNameHashCode() { }

	// RVA: 0x219A820 Offset: 0x2198E20 VA: 0x18219A820
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x23F6C90 Offset: 0x23F5290 VA: 0x1823F6C90
	internal int get_styleNameHashCode() { }

	// RVA: 0x23F6E10 Offset: 0x23F5410 VA: 0x1823F6E10
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x23F6C40 Offset: 0x23F5240 VA: 0x1823F6C40
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x16410B0 Offset: 0x163F6B0 VA: 0x1816410B0
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x23F6C00 Offset: 0x23F5200 VA: 0x1823F6C00
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x23F6AB0 Offset: 0x23F50B0 VA: 0x1823F6AB0
	public List<Character> get_characterTable() { }

	// RVA: 0x23F6D20 Offset: 0x23F5320 VA: 0x1823F6D20
	internal void set_characterTable(List<Character> value) { }

	// RVA: 0x23F6A70 Offset: 0x23F5070 VA: 0x1823F6A70
	public Dictionary<uint, Character> get_characterLookupTable() { }

	// RVA: 0x23ECB40 Offset: 0x23EB140 VA: 0x1823ECB40
	private bool CharacterLookupTable_ContainsKey(uint key) { }

	// RVA: 0x23ECD20 Offset: 0x23EB320 VA: 0x1823ECD20
	private bool CharacterLookupTable_TryGet(uint key, out Character character) { }

	// RVA: 0x23ECC30 Offset: 0x23EB230 VA: 0x1823ECC30
	private void CharacterLookupTable_TryAdd(uint key, Character character) { }

	// RVA: 0x23F69A0 Offset: 0x23F4FA0 VA: 0x1823F69A0
	public Texture2D get_atlasTexture() { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x127C520 Offset: 0x127AB20 VA: 0x18127C520
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x23F6990 Offset: 0x23F4F90 VA: 0x1823F6990
	public int get_atlasTextureCount() { }

	// RVA: 0x23F6C50 Offset: 0x23F5250 VA: 0x1823F6C50
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x219A8F0 Offset: 0x2198EF0 VA: 0x18219A8F0
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x23F6BF0 Offset: 0x23F51F0 VA: 0x1823F6BF0
	public bool get_getFontFeatures() { }

	// RVA: 0x219A8E0 Offset: 0x2198EE0 VA: 0x18219A8E0
	public void set_getFontFeatures(bool value) { }

	// RVA: 0x23F6AC0 Offset: 0x23F50C0 VA: 0x1823F6AC0
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x219A850 Offset: 0x2198E50 VA: 0x18219A850
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x23F6A40 Offset: 0x23F5040 VA: 0x1823F6A40
	public int get_atlasWidth() { }

	// RVA: 0x219A840 Offset: 0x2198E40 VA: 0x18219A840
	internal void set_atlasWidth(int value) { }

	// RVA: 0x23F6950 Offset: 0x23F4F50 VA: 0x1823F6950
	public int get_atlasHeight() { }

	// RVA: 0x219A800 Offset: 0x2198E00 VA: 0x18219A800
	internal void set_atlasHeight(int value) { }

	// RVA: 0x23F6960 Offset: 0x23F4F60 VA: 0x1823F6960
	public int get_atlasPadding() { }

	// RVA: 0x219A810 Offset: 0x2198E10 VA: 0x18219A810
	internal void set_atlasPadding(int value) { }

	// RVA: 0x23F6980 Offset: 0x23F4F80 VA: 0x1823F6980
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x219A830 Offset: 0x2198E30 VA: 0x18219A830
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x23F6CF0 Offset: 0x23F52F0 VA: 0x1823F6CF0
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x219A910 Offset: 0x2198F10 VA: 0x18219A910
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x23F6BE0 Offset: 0x23F51E0 VA: 0x1823F6BE0
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x219A8C0 Offset: 0x2198EC0 VA: 0x18219A8C0
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x23F6BC0 Offset: 0x23F51C0 VA: 0x1823F6BC0
	public FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1C9ACB0 Offset: 0x1C992B0 VA: 0x181C9ACB0
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	// RVA: 0x23F6B20 Offset: 0x23F5120 VA: 0x1823F6B20
	public List<FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x37EB40 Offset: 0x37D140 VA: 0x18037EB40
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	// RVA: 0x23F6BD0 Offset: 0x23F51D0 VA: 0x1823F6BD0
	public FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x37EB80 Offset: 0x37D180 VA: 0x18037EB80
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	// RVA: 0x23F6C80 Offset: 0x23F5280 VA: 0x1823F6C80
	public float get_regularStyleWeight() { }

	// RVA: 0x23F6E00 Offset: 0x23F5400 VA: 0x1823F6E00
	public void set_regularStyleWeight(float value) { }

	// RVA: 0x23F6C70 Offset: 0x23F5270 VA: 0x1823F6C70
	public float get_regularStyleSpacing() { }

	// RVA: 0x23F6DF0 Offset: 0x23F53F0 VA: 0x1823F6DF0
	public void set_regularStyleSpacing(float value) { }

	// RVA: 0x23F6A60 Offset: 0x23F5060 VA: 0x1823F6A60
	public float get_boldStyleWeight() { }

	// RVA: 0x23F6D10 Offset: 0x23F5310 VA: 0x1823F6D10
	public void set_boldStyleWeight(float value) { }

	// RVA: 0x23F6A50 Offset: 0x23F5050 VA: 0x1823F6A50
	public float get_boldStyleSpacing() { }

	// RVA: 0x23F6D00 Offset: 0x23F5300 VA: 0x1823F6D00
	public void set_boldStyleSpacing(float value) { }

	// RVA: 0x23F6C60 Offset: 0x23F5260 VA: 0x1823F6C60
	public byte get_italicStyleSlant() { }

	// RVA: 0x23F6DE0 Offset: 0x23F53E0 VA: 0x1823F6DE0
	public void set_italicStyleSlant(byte value) { }

	// RVA: 0x23F6CE0 Offset: 0x23F52E0 VA: 0x1823F6CE0
	public byte get_tabMultiple() { }

	// RVA: 0x23F6E20 Offset: 0x23F5420 VA: 0x1823F6E20
	public void set_tabMultiple(byte value) { }

	// RVA: 0x23EE320 Offset: 0x23EC920 VA: 0x1823EE320
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	// RVA: 0x23EDC80 Offset: 0x23EC280 VA: 0x1823EDC80
	internal static List<FontAsset> CreateFontAssetOSFallbackList(string[] fallbacksFamilyNames, Shader shader, int pointSize = 90) { }

	// RVA: 0x23EDDE0 Offset: 0x23EC3E0 VA: 0x1823EDDE0
	internal static FontAsset CreateFontAssetWithOSFallbackList(string[] fallbacksFamilyNames, Shader shader, int pointSize = 90) { }

	// RVA: 0x23ED4D0 Offset: 0x23EBAD0 VA: 0x1823ED4D0
	private static FontAsset CreateFontAssetFromFamilyName(string familyName, Shader shader, int pointSize = 90) { }

	// RVA: 0x23EE270 Offset: 0x23EC870 VA: 0x1823EE270
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x23EE050 Offset: 0x23EC650 VA: 0x1823EE050
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 2, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x23EE1B0 Offset: 0x23EC7B0 VA: 0x1823EE1B0
	public static FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x23EDF90 Offset: 0x23EC590 VA: 0x1823EDF90
	internal static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, Shader shader, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x23EEA00 Offset: 0x23ED000 VA: 0x1823EEA00
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x23EE540 Offset: 0x23ECB40 VA: 0x1823EE540
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, Shader shader, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x23ED680 Offset: 0x23EBC80 VA: 0x1823ED680
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void Awake() { }

	// RVA: 0x23F0E40 Offset: 0x23EF440 VA: 0x1823F0E40
	private void OnDestroy() { }

	// RVA: 0x23F0F60 Offset: 0x23EF560 VA: 0x1823F0F60
	public void ReadFontAssetDefinition() { }

	// RVA: 0x23EFF50 Offset: 0x23EE550 VA: 0x1823EFF50
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x23F00B0 Offset: 0x23EE6B0 VA: 0x1823F00B0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x23EFD30 Offset: 0x23EE330 VA: 0x1823EFD30
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x23F05A0 Offset: 0x23EEBA0 VA: 0x1823F05A0
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x23F0330 Offset: 0x23EE930 VA: 0x1823F0330
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x23F0890 Offset: 0x23EEE90 VA: 0x1823F0890
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x23F0AA0 Offset: 0x23EF0A0 VA: 0x1823F0AA0
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x23EC940 Offset: 0x23EAF40 VA: 0x1823EC940
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x23EC5E0 Offset: 0x23EABE0 VA: 0x1823EC5E0
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x23EB710 Offset: 0x23E9D10 VA: 0x1823EB710
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	// RVA: 0x23F0CB0 Offset: 0x23EF2B0 VA: 0x1823F0CB0
	private FontEngineError LoadFontFace() { }

	// RVA: 0x23F1E80 Offset: 0x23F0480 VA: 0x1823F1E80
	internal void SortCharacterTable() { }

	// RVA: 0x23F2050 Offset: 0x23F0650 VA: 0x1823F2050
	internal void SortGlyphTable() { }

	// RVA: 0x23F2000 Offset: 0x23F0600 VA: 0x1823F2000
	internal void SortFontFeatureTable() { }

	// RVA: 0x23F1B70 Offset: 0x23F0170 VA: 0x1823F1B70
	internal void SortAllTables() { }

	// RVA: 0x23EF530 Offset: 0x23EDB30 VA: 0x1823EF530
	public bool HasCharacter(int character) { }

	// RVA: 0x23EF580 Offset: 0x23EDB80 VA: 0x1823EF580
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x23EF1C0 Offset: 0x23ED7C0 VA: 0x1823EF1C0
	public bool HasCharacter(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x23EEF80 Offset: 0x23ED580 VA: 0x1823EEF80
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x23EFAD0 Offset: 0x23EE0D0 VA: 0x1823EFAD0
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x23EF640 Offset: 0x23EDC40 VA: 0x1823EF640
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x23EF5A0 Offset: 0x23EDBA0 VA: 0x1823EF5A0
	public bool HasCharacters(string text) { }

	// RVA: 0x23EEC80 Offset: 0x23ED280 VA: 0x1823EEC80
	public static string GetCharacters(FontAsset fontAsset) { }

	// RVA: 0x23EEBA0 Offset: 0x23ED1A0 VA: 0x1823EEBA0
	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	// RVA: 0x23EEE40 Offset: 0x23ED440 VA: 0x1823EEE40
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x23EED70 Offset: 0x23ED370 VA: 0x1823EED70
	internal uint GetGlyphIndex(uint unicode, out bool success) { }

	// RVA: 0x23EEEF0 Offset: 0x23ED4F0 VA: 0x1823EEEF0
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	// RVA: 0x23F5190 Offset: 0x23F3790 VA: 0x1823F5190
	internal void UpdateFontAssetData() { }

	// RVA: 0x23ED2B0 Offset: 0x23EB8B0 VA: 0x1823ED2B0
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x23ED070 Offset: 0x23EB670 VA: 0x1823ED070
	internal void ClearCharacterAndGlyphTablesInternal() { }

	// RVA: 0x23ED3B0 Offset: 0x23EB9B0 VA: 0x1823ED3B0
	internal void ClearFontFeaturesInternal() { }

	// RVA: 0x23ED0A0 Offset: 0x23EB6A0 VA: 0x1823ED0A0
	private void ClearCharacterAndGlyphTables() { }

	// RVA: 0x23ED3D0 Offset: 0x23EB9D0 VA: 0x1823ED3D0
	private void ClearFontFeaturesTables() { }

	// RVA: 0x23ECE20 Offset: 0x23EB420 VA: 0x1823ECE20
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x23EEAC0 Offset: 0x23ED0C0 VA: 0x1823EEAC0
	private void DestroyAtlasTextures() { }

	// RVA: 0x23F16C0 Offset: 0x23EFCC0 VA: 0x1823F16C0
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	// RVA: 0x23F17C0 Offset: 0x23EFDC0 VA: 0x1823F17C0
	internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset) { }

	// RVA: 0x23F54C0 Offset: 0x23F3AC0 VA: 0x1823F54C0
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x23F1570 Offset: 0x23EFB70 VA: 0x1823F1570
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x23F4EC0 Offset: 0x23F34C0 VA: 0x1823F4EC0
	internal static void UpdateAtlasTexturesInQueue() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x23F52F0 Offset: 0x23F38F0 VA: 0x1823F52F0
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x23F2500 Offset: 0x23F0B00 VA: 0x1823F2500
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x23F2530 Offset: 0x23F0B30 VA: 0x1823F2530
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x23F24D0 Offset: 0x23F0AD0 VA: 0x1823F24D0
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x23F3170 Offset: 0x23F1770 VA: 0x1823F3170
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x23EB720 Offset: 0x23E9D20 VA: 0x1823EB720
	internal bool AddGlyphInternal(uint glyphIndex) { }

	// RVA: 0x23F48B0 Offset: 0x23F2EB0 VA: 0x1823F48B0
	internal bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex) { }

	// RVA: 0x23F4E10 Offset: 0x23F3410 VA: 0x1823F4E10
	internal bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex) { }

	// RVA: 0x23F3D40 Offset: 0x23F2340 VA: 0x1823F3D40
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x23F21D0 Offset: 0x23F07D0 VA: 0x1823F21D0
	internal bool TryAddCharacterInternal(uint unicode, out Character character, bool populateLigatures = True) { }

	// RVA: 0x23F3F00 Offset: 0x23F2500 VA: 0x1823F3F00
	private bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = True) { }

	// RVA: 0x23F42D0 Offset: 0x23F28D0 VA: 0x1823F42D0
	private bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = True) { }

	// RVA: 0x23F4960 Offset: 0x23F2F60 VA: 0x1823F4960
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x23F18C0 Offset: 0x23EFEC0 VA: 0x1823F18C0
	private void SetupNewAtlasTexture() { }

	// RVA: 0x23F5890 Offset: 0x23F3E90 VA: 0x1823F5890
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x23F5AC0 Offset: 0x23F40C0 VA: 0x1823F5AC0
	private void UpdateGlyphAdjustmentRecordsForNewGlyphs() { }

	// RVA: 0x23F59A0 Offset: 0x23F3FA0 VA: 0x1823F59A0
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x23EFC30 Offset: 0x23EE230 VA: 0x1823EFC30
	internal void ImportFontFeatures() { }

	// RVA: 0x23F5A50 Offset: 0x23F4050 VA: 0x1823F5A50
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	// RVA: 0x23F6000 Offset: 0x23F4600 VA: 0x1823F6000
	internal void UpdateLigatureSubstitutionRecords() { }

	// RVA: 0x23EB740 Offset: 0x23E9D40 VA: 0x1823EB740
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	// RVA: 0x23F5F90 Offset: 0x23F4590 VA: 0x1823F5F90
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x23EC2B0 Offset: 0x23EA8B0 VA: 0x1823EC2B0
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	// RVA: 0x23F5B70 Offset: 0x23F4170 VA: 0x1823F5B70
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: 0x23F5050 Offset: 0x23F3650 VA: 0x1823F5050
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	// RVA: 0x23EBB90 Offset: 0x23EA190 VA: 0x1823EBB90
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	// RVA: 0x23EBF20 Offset: 0x23EA520 VA: 0x1823EBF20
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	// RVA: 0x23F6520 Offset: 0x23F4B20 VA: 0x1823F6520
	public void .ctor() { }

	// RVA: 0x23F6070 Offset: 0x23F4670 VA: 0x1823F6070
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class FontAssetUtilities // TypeDefIndex: 12317
{
	// Fields
	private static HashSet<int> k_SearchedAssets; // 0x0

	// Methods

	// RVA: 0x23EA460 Offset: 0x23E8A60 VA: 0x1823EA460
	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x23E9EB0 Offset: 0x23E84B0 VA: 0x1823E9EB0
	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x23EA770 Offset: 0x23E8D70 VA: 0x1823EA770
	internal static Character GetCharacterFromFontAssetsInternal(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, List<FontAsset> OSFallbackList, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = True) { }

	// RVA: 0x23EA580 Offset: 0x23E8B80 VA: 0x1823EA580
	private static Character GetCharacterFromFontAssetsInternal(uint unicode, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = True) { }

	// RVA: 0x23EAD60 Offset: 0x23E9360 VA: 0x1823EAD60
	internal static TextElement GetTextElementFromTextAssets(uint unicode, FontAsset sourceFontAsset, List<TextAsset> textAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x23EAAA0 Offset: 0x23E90A0 VA: 0x1823EAAA0
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x23EA8E0 Offset: 0x23E8EE0 VA: 0x1823EA8E0
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }
}

// Namespace: UnityEngine.TextCore.Text
[HelpURL("https://docs.unity3d.com/2023.2/Documentation/Manual/UIE-sprite.html")]
[ExcludeFromPreset]
public class SpriteAsset : TextAsset // TypeDefIndex: 12319
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x38
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x48
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture; // 0xA8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <width>k__BackingField; // 0xB0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <height>k__BackingField; // 0xB4
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable; // 0xB8
	internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup; // 0xC0
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable; // 0xC8
	internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup; // 0xD0
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public FaceInfo faceInfo { get; set; }
	public Texture spriteSheet { get; set; }
	internal float width { get; set; }
	internal float height { get; set; }
	public List<SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x23FC5F0 Offset: 0x23FABF0 VA: 0x1823FC5F0
	public FaceInfo get_faceInfo() { }

	// RVA: 0x23FC6D0 Offset: 0x23FACD0 VA: 0x1823FC6D0
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x237AF60 Offset: 0x2379560 VA: 0x18237AF60
	public Texture get_spriteSheet() { }

	// RVA: 0x23FC720 Offset: 0x23FAD20 VA: 0x1823FC720
	internal void set_spriteSheet(Texture value) { }

	[CompilerGenerated]
	// RVA: 0x23FC6C0 Offset: 0x23FACC0 VA: 0x1823FC6C0
	internal float get_width() { }

	[CompilerGenerated]
	// RVA: 0x23FC7B0 Offset: 0x23FADB0 VA: 0x1823FC7B0
	private void set_width(float value) { }

	[CompilerGenerated]
	// RVA: 0x23FC630 Offset: 0x23FAC30 VA: 0x1823FC630
	internal float get_height() { }

	[CompilerGenerated]
	// RVA: 0x23FC710 Offset: 0x23FAD10 VA: 0x1823FC710
	private void set_height(float value) { }

	// RVA: 0x23FC680 Offset: 0x23FAC80 VA: 0x1823FC680
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	// RVA: 0x23FC640 Offset: 0x23FAC40 VA: 0x1823FC640
	public Dictionary<uint, SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	internal void set_spriteCharacterLookupTable(Dictionary<uint, SpriteCharacter> value) { }

	// RVA: 0x237B020 Offset: 0x2379620 VA: 0x18237B020
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x1621970 Offset: 0x161FF70 VA: 0x181621970
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void Awake() { }

	// RVA: 0x23FBF60 Offset: 0x23FA560 VA: 0x1823FBF60
	public void UpdateLookupTables() { }

	// RVA: 0x23FAE10 Offset: 0x23F9410 VA: 0x1823FAE10
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x23FAEE0 Offset: 0x23F94E0 VA: 0x1823FAEE0
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x23FAEA0 Offset: 0x23F94A0 VA: 0x1823FAEA0
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x23FB7B0 Offset: 0x23F9DB0 VA: 0x1823FB7B0
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x23FB560 Offset: 0x23F9B60 VA: 0x1823FB560
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x23FB6F0 Offset: 0x23F9CF0 VA: 0x1823FB6F0
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x23FB1E0 Offset: 0x23F97E0 VA: 0x1823FB1E0
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings) { }

	// RVA: 0x23FAF80 Offset: 0x23F9580 VA: 0x1823FAF80
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x23FB120 Offset: 0x23F9720 VA: 0x1823FB120
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x23FBDE0 Offset: 0x23FA3E0 VA: 0x1823FBDE0
	public void SortGlyphTable() { }

	// RVA: 0x23FB990 Offset: 0x23F9F90 VA: 0x1823FB990
	internal void SortCharacterTable() { }

	// RVA: 0x23FBB10 Offset: 0x23FA110 VA: 0x1823FBB10
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x23FC520 Offset: 0x23FAB20 VA: 0x1823FC520
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteCharacter : TextElement // TypeDefIndex: 12320
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x2358D10 Offset: 0x2357310 VA: 0x182358D10
	public string get_name() { }

	// RVA: 0x23FC7C0 Offset: 0x23FADC0 VA: 0x1823FC7C0
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteGlyph : Glyph // TypeDefIndex: 12321
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x21DC250 Offset: 0x21DA850 VA: 0x1821DC250
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromObjectFactory]
[Serializable]
public abstract class TextAsset : ScriptableObject // TypeDefIndex: 12322
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[FormerlySerializedAs("material")]
	[SerializeField]
	internal Material m_Material; // 0x28
	internal int m_MaterialHashCode; // 0x30

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	public string get_version() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_version(string value) { }

	// RVA: 0x2187710 Offset: 0x2185D10 VA: 0x182187710
	public int get_instanceID() { }

	// RVA: 0x23FC7E0 Offset: 0x23FADE0 VA: 0x1823FC7E0
	public int get_hashCode() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_hashCode(int value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Material get_material() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_material(Material value) { }

	// RVA: 0x23FC820 Offset: 0x23FAE20 VA: 0x1823FC820
	public int get_materialHashCode() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_materialHashCode(int value) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum ColorGradientMode // TypeDefIndex: 12323
{
	// Fields
	public int value__; // 0x0
	public const ColorGradientMode Single = 0;
	public const ColorGradientMode HorizontalGradient = 1;
	public const ColorGradientMode VerticalGradient = 2;
	public const ColorGradientMode FourCornersGradient = 3;
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextColorGradient : ScriptableObject // TypeDefIndex: 12324
{
	// Fields
	public ColorGradientMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorGradientMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x23FC900 Offset: 0x23FAF00 VA: 0x1823FC900
	public void .ctor() { }

	// RVA: 0x2187AE0 Offset: 0x21860E0 VA: 0x182187AE0
	public void .ctor(Color color) { }

	// RVA: 0x2187B30 Offset: 0x2186130 VA: 0x182187B30
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x23FC8C0 Offset: 0x23FAEC0 VA: 0x1823FC8C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextSettings : ScriptableObject // TypeDefIndex: 12326
{
	// Fields
	internal string k_SystemFontName; // 0x18
	[SerializeField]
	protected string m_Version; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAsset")]
	protected FontAsset m_DefaultFontAsset; // 0x28
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	[SerializeField]
	protected string m_DefaultFontAssetPath; // 0x30
	[SerializeField]
	[FormerlySerializedAs("m_fallbackFontAssets")]
	protected List<FontAsset> m_FallbackFontAssets; // 0x38
	private static List<FontAsset> s_FallbackOSFontAssetInternal; // 0x0
	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	protected bool m_MatchMaterialPreset; // 0x40
	[SerializeField]
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	protected int m_MissingCharacterUnicode; // 0x44
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild; // 0x48
	[SerializeField]
	private bool m_EnableEmojiSupport; // 0x49
	[SerializeField]
	private List<TextAsset> m_EmojiFallbackTextAssets; // 0x50
	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	protected SpriteAsset m_DefaultSpriteAsset; // 0x58
	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	protected string m_DefaultSpriteAssetPath; // 0x60
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets; // 0x68
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static SpriteAsset <s_GlobalSpriteAsset>k__BackingField; // 0x8
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode; // 0x70
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	protected TextStyleSheet m_DefaultStyleSheet; // 0x78
	[SerializeField]
	protected string m_StyleSheetsResourcePath; // 0x80
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	protected string m_DefaultColorGradientPresetsPath; // 0x88
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x90
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	protected bool m_DisplayWarnings; // 0x98
	internal Dictionary<int, FontAsset> m_FontLookup; // 0xA0
	private List<TextSettings.FontReferenceMap> m_FontReferences; // 0xA8

	// Properties
	public string version { get; set; }
	public FontAsset defaultFontAsset { get; set; }
	public string defaultFontAssetPath { get; set; }
	public List<FontAsset> fallbackFontAssets { get; set; }
	internal List<FontAsset> fallbackOSFontAssets { get; }
	public bool matchMaterialPreset { get; set; }
	public int missingCharacterUnicode { get; set; }
	public bool clearDynamicDataOnBuild { get; set; }
	public bool enableEmojiSupport { get; set; }
	public List<TextAsset> emojiFallbackTextAssets { get; set; }
	public SpriteAsset defaultSpriteAsset { get; set; }
	public string defaultSpriteAssetPath { get; set; }
	public List<SpriteAsset> fallbackSpriteAssets { get; set; }
	internal static SpriteAsset s_GlobalSpriteAsset { get; set; }
	public uint missingSpriteCharacterUnicode { get; set; }
	public TextStyleSheet defaultStyleSheet { get; set; }
	public string styleSheetsResourcePath { get; set; }
	public string defaultColorGradientPresetsPath { get; set; }
	public UnicodeLineBreakingRules lineBreakingRules { get; set; }
	public bool displayWarnings { get; set; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_version() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_version(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public FontAsset get_defaultFontAsset() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_defaultFontAsset(FontAsset value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_defaultFontAssetPath() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_defaultFontAssetPath(string value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public List<FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	// RVA: 0x23FD690 Offset: 0x23FBC90 VA: 0x1823FD690
	internal List<FontAsset> get_fallbackOSFontAssets() { }

	// RVA: 0x23FD040 Offset: 0x23FB640 VA: 0x1823FD040 Slot: 4
	internal virtual List<FontAsset> GetStaticFallbackOSFontAsset() { }

	// RVA: 0x23FD4C0 Offset: 0x23FBAC0 VA: 0x1823FD4C0 Slot: 5
	internal virtual void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_matchMaterialPreset() { }

	// RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	public void set_matchMaterialPreset(bool value) { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public int get_missingCharacterUnicode() { }

	// RVA: 0x1978180 Offset: 0x1976780 VA: 0x181978180
	public void set_missingCharacterUnicode(int value) { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	public void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x23FD680 Offset: 0x23FBC80 VA: 0x1823FD680
	public bool get_enableEmojiSupport() { }

	// RVA: 0x16EE310 Offset: 0x16EC910 VA: 0x1816EE310
	public void set_enableEmojiSupport(bool value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public List<TextAsset> get_emojiFallbackTextAssets() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_emojiFallbackTextAssets(List<TextAsset> value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_defaultSpriteAssetPath() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_defaultSpriteAssetPath(string value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x23FD840 Offset: 0x23FBE40 VA: 0x1823FD840
	private static void set_s_GlobalSpriteAsset(SpriteAsset value) { }

	[CompilerGenerated]
	// RVA: 0x23FD800 Offset: 0x23FBE00 VA: 0x1823FD800
	internal static SpriteAsset get_s_GlobalSpriteAsset() { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	public uint get_missingSpriteCharacterUnicode() { }

	// RVA: 0x4A4300 Offset: 0x4A2900 VA: 0x1804A4300
	public void set_missingSpriteCharacterUnicode(uint value) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public TextStyleSheet get_defaultStyleSheet() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public string get_styleSheetsResourcePath() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	public void set_styleSheetsResourcePath(string value) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	public void set_defaultColorGradientPresetsPath(string value) { }

	// RVA: 0x23FD770 Offset: 0x23FBD70 VA: 0x1823FD770
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	// RVA: 0x3A35D0 Offset: 0x3A1BD0 VA: 0x1803A35D0
	public bool get_displayWarnings() { }

	// RVA: 0x3A3CA0 Offset: 0x3A22A0 VA: 0x1803A3CA0
	public void set_displayWarnings(bool value) { }

	// RVA: 0x23FD320 Offset: 0x23FB920 VA: 0x1823FD320
	private void OnEnable() { }

	// RVA: 0x23FD080 Offset: 0x23FB680 VA: 0x1823FD080
	protected void InitializeFontReferenceLookup() { }

	// RVA: 0x23FC9B0 Offset: 0x23FAFB0 VA: 0x1823FC9B0
	protected FontAsset GetCachedFontAssetInternal(Font font) { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x23FCA20 Offset: 0x23FB020 VA: 0x1823FCA20
	internal FontAsset GetCachedFontAsset(Font font, Shader shader) { }

	// RVA: 0x23FCF80 Offset: 0x23FB580 VA: 0x1823FCF80 Slot: 6
	internal virtual Shader GetFontShader() { }

	// RVA: 0x23FCFC0 Offset: 0x23FB5C0 VA: 0x1823FCFC0
	private List<FontAsset> GetOSFontAssetList() { }

	// RVA: 0x23FD520 Offset: 0x23FBB20 VA: 0x1823FD520
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextStyle // TypeDefIndex: 12327
{
	// Fields
	internal static TextStyle k_NormalStyle; // 0x0
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
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public int hashCode { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0xA3D180 Offset: 0xA3B780 VA: 0x180A3D180
	public int get_hashCode() { }

	// RVA: 0x2358D10 Offset: 0x2357310 VA: 0x182358D10
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x237AFC0 Offset: 0x23795C0 VA: 0x18237AFC0
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x23FE070 Offset: 0x23FC670 VA: 0x1823FE070
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x23FDE70 Offset: 0x23FC470 VA: 0x1823FDE70
	public void RefreshStyle() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextStyleSheet : ScriptableObject // TypeDefIndex: 12328
{
	// Fields
	[SerializeField]
	private List<TextStyle> m_StyleList; // 0x18
	private Dictionary<int, TextStyle> m_StyleLookupDictionary; // 0x20
	private object styleLookupLock; // 0x28

	// Properties
	internal List<TextStyle> styles { get; }

	// Methods

	// RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	internal List<TextStyle> get_styles() { }

	// RVA: 0x23FDDA0 Offset: 0x23FC3A0 VA: 0x1823FDDA0
	private void Reset() { }

	// RVA: 0x23FD8A0 Offset: 0x23FBEA0 VA: 0x1823FD8A0
	public TextStyle GetStyle(int hashCode) { }

	// RVA: 0x23FD9C0 Offset: 0x23FBFC0 VA: 0x1823FD9C0
	public TextStyle GetStyle(string name) { }

	// RVA: 0x23FDDA0 Offset: 0x23FC3A0 VA: 0x1823FDDA0
	public void RefreshStyles() { }

	// RVA: 0x23FDA60 Offset: 0x23FC060 VA: 0x1823FDA60
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x23FDDB0 Offset: 0x23FC3B0 VA: 0x1823FDDB0
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum TextElementType // TypeDefIndex: 12329
{
	// Fields
	public byte value__; // 0x0
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public abstract class TextElement // TypeDefIndex: 12330
{
	// Fields
	[SerializeField]
	protected TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TextAsset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TextAsset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x2420A80 Offset: 0x241F080 VA: 0x182420A80
	public TextElementType get_elementType() { }

	// RVA: 0xEBC7A0 Offset: 0xEBADA0 VA: 0x180EBC7A0
	public uint get_unicode() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_unicode(uint value) { }

	// RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	public TextAsset get_textAsset() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_textAsset(TextAsset value) { }

	// RVA: 0x2358D20 Offset: 0x2357320 VA: 0x182358D20
	public Glyph get_glyph() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_glyph(Glyph value) { }

	// RVA: 0xA3D1A0 Offset: 0xA3B7A0 VA: 0x180A3D1A0
	public uint get_glyphIndex() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_glyphIndex(uint value) { }

	// RVA: 0x23A8F70 Offset: 0x23A7570 VA: 0x1823A8F70
	public float get_scale() { }

	// RVA: 0x1853730 Offset: 0x1851D30 VA: 0x181853730
	public void set_scale(float value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextVertex // TypeDefIndex: 12331
{
	// Fields
	public Vector3 position; // 0x0
	public Vector4 uv; // 0xC
	public Vector2 uv2; // 0x1C
	public Color32 color; // 0x24
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct TextElementInfo // TypeDefIndex: 12332
{
	// Fields
	public uint character; // 0x0
	public int index; // 0x4
	public TextElementType elementType; // 0x8
	public int stringLength; // 0xC
	public TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public FontAsset fontAsset; // 0x20
	public SpriteAsset spriteAsset; // 0x28
	public int spriteIndex; // 0x30
	public Material material; // 0x38
	public int materialReferenceIndex; // 0x40
	public bool isUsingAlternateTypeface; // 0x44
	public float pointSize; // 0x48
	public int lineNumber; // 0x4C
	public int pageNumber; // 0x50
	public int vertexIndex; // 0x54
	public TextVertex vertexTopLeft; // 0x58
	public TextVertex vertexBottomLeft; // 0x80
	public TextVertex vertexTopRight; // 0xA8
	public TextVertex vertexBottomRight; // 0xD0
	public Vector3 topLeft; // 0xF8
	public Vector3 bottomLeft; // 0x104
	public Vector3 topRight; // 0x110
	public Vector3 bottomRight; // 0x11C
	public float origin; // 0x128
	public float ascender; // 0x12C
	public float baseLine; // 0x130
	public float descender; // 0x134
	internal float adjustedAscender; // 0x138
	internal float adjustedDescender; // 0x13C
	internal float adjustedHorizontalAdvance; // 0x140
	public float xAdvance; // 0x144
	public float aspectRatio; // 0x148
	public float scale; // 0x14C
	public Color32 color; // 0x150
	public Color32 underlineColor; // 0x154
	public int underlineVertexIndex; // 0x158
	public Color32 strikethroughColor; // 0x15C
	public int strikethroughVertexIndex; // 0x160
	public Color32 highlightColor; // 0x164
	public HighlightState highlightState; // 0x168
	public FontStyles style; // 0x17C
	public bool isVisible; // 0x180

	// Methods

	// RVA: 0x241E680 Offset: 0x241CC80 VA: 0x18241E680 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class TextGenerator // TypeDefIndex: 12335
{
	// Fields
	private const int k_Tab = 9;
	private const int k_LineFeed = 10;
	private const int k_VerticalTab = 11;
	private const int k_CarriageReturn = 13;
	private const int k_Space = 32;
	private const int k_DoubleQuotes = 34;
	private const int k_NumberSign = 35;
	private const int k_PercentSign = 37;
	private const int k_SingleQuote = 39;
	private const int k_Plus = 43;
	private const int k_Period = 46;
	private const int k_LesserThan = 60;
	private const int k_Equal = 61;
	private const int k_GreaterThan = 62;
	private const int k_Underline = 95;
	private const int k_NoBreakSpace = 160;
	private const int k_SoftHyphen = 173;
	private const int k_HyphenMinus = 45;
	private const int k_FigureSpace = 8199;
	private const int k_Hyphen = 8208;
	private const int k_NonBreakingHyphen = 8209;
	private const int k_ZeroWidthSpace = 8203;
	private const int k_NarrowNoBreakSpace = 8239;
	private const int k_WordJoiner = 8288;
	private const int k_HorizontalEllipsis = 8230;
	private const int k_LineSeparator = 8232;
	private const int k_ParagraphSeparator = 8233;
	private const int k_RightSingleQuote = 8217;
	private const int k_Square = 9633;
	private const int k_HangulJamoStart = 4352;
	private const int k_HangulJamoEnd = 4607;
	private const int k_CjkStart = 11904;
	private const int k_CjkEnd = 40959;
	private const int k_HangulJameExtendedStart = 43360;
	private const int k_HangulJameExtendedEnd = 43391;
	private const int k_HangulSyllablesStart = 44032;
	private const int k_HangulSyllablesEnd = 55295;
	private const int k_CjkIdeographsStart = 63744;
	private const int k_CjkIdeographsEnd = 64255;
	private const int k_CjkFormsStart = 65072;
	private const int k_CjkFormsEnd = 65103;
	private const int k_CjkHalfwidthStart = 65280;
	private const int k_CjkHalfwidthEnd = 65519;
	private const int k_EndOfText = 3;
	private const float k_FloatUnset = -32767;
	private const int k_MaxCharacters = 8;
	private static TextGenerator s_TextGenerator; // 0x0
	private TextBackingContainer m_TextBackingArray; // 0x10
	internal TextProcessingElement[] m_TextProcessingArray; // 0x20
	internal int m_InternalTextProcessingArraySize; // 0x28
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x2C
	private char[] m_HtmlTag; // 0x30
	internal HighlightState m_HighlightState; // 0x38
	protected bool m_IsIgnoringAlignment; // 0x4C
	protected bool m_IsTextTruncated; // 0x4D
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TextGenerator.MissingCharacterEventCallback OnMissingCharacter; // 0x8
	private Vector3[] m_RectTransformCorners; // 0x50
	private float m_MarginWidth; // 0x58
	private float m_MarginHeight; // 0x5C
	private float m_PreferredWidth; // 0x60
	private float m_PreferredHeight; // 0x64
	private FontAsset m_CurrentFontAsset; // 0x68
	private Material m_CurrentMaterial; // 0x70
	private int m_CurrentMaterialIndex; // 0x78
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; // 0x80
	private float m_Padding; // 0xD8
	private SpriteAsset m_CurrentSpriteAsset; // 0xE0
	private int m_TotalCharacterCount; // 0xE8
	private float m_FontSize; // 0xEC
	private float m_FontScaleMultiplier; // 0xF0
	private float m_CurrentFontSize; // 0xF4
	private TextProcessingStack<float> m_SizeStack; // 0xF8
	protected TextProcessingStack<int>[] m_TextStyleStacks; // 0x118
	protected int m_TextStyleStackDepth; // 0x120
	private FontStyles m_FontStyleInternal; // 0x124
	private FontStyleStack m_FontStyleStack; // 0x128
	private TextFontWeight m_FontWeightInternal; // 0x134
	private TextProcessingStack<TextFontWeight> m_FontWeightStack; // 0x138
	private TextAlignment m_LineJustification; // 0x158
	private TextProcessingStack<TextAlignment> m_LineJustificationStack; // 0x160
	private float m_BaselineOffset; // 0x180
	private TextProcessingStack<float> m_BaselineOffsetStack; // 0x188
	private Color32 m_FontColor32; // 0x1A8
	private Color32 m_HtmlColor; // 0x1AC
	private Color32 m_UnderlineColor; // 0x1B0
	private Color32 m_StrikethroughColor; // 0x1B4
	private TextProcessingStack<Color32> m_ColorStack; // 0x1B8
	private TextProcessingStack<Color32> m_UnderlineColorStack; // 0x1D8
	private TextProcessingStack<Color32> m_StrikethroughColorStack; // 0x1F8
	private TextProcessingStack<Color32> m_HighlightColorStack; // 0x218
	private TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x238
	private TextProcessingStack<int> m_ItalicAngleStack; // 0x268
	private TextColorGradient m_ColorGradientPreset; // 0x288
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack; // 0x290
	private bool m_ColorGradientPresetIsTinted; // 0x2B8
	private TextProcessingStack<int> m_ActionStack; // 0x2C0
	private float m_LineOffset; // 0x2E0
	private float m_LineHeight; // 0x2E4
	private bool m_IsDrivenLineSpacing; // 0x2E8
	private float m_CSpacing; // 0x2EC
	private float m_MonoSpacing; // 0x2F0
	private bool m_DuoSpace; // 0x2F4
	private float m_XAdvance; // 0x2F8
	private float m_TagLineIndent; // 0x2FC
	private float m_TagIndent; // 0x300
	private TextProcessingStack<float> m_IndentStack; // 0x308
	private bool m_TagNoParsing; // 0x328
	private int m_CharacterCount; // 0x32C
	private int m_FirstCharacterOfLine; // 0x330
	private int m_LastCharacterOfLine; // 0x334
	private int m_FirstVisibleCharacterOfLine; // 0x338
	private int m_LastVisibleCharacterOfLine; // 0x33C
	private float m_MaxLineAscender; // 0x340
	private float m_MaxLineDescender; // 0x344
	private int m_LineNumber; // 0x348
	private int m_LineVisibleCharacterCount; // 0x34C
	private int m_LineVisibleSpaceCount; // 0x350
	private int m_FirstOverflowCharacterIndex; // 0x354
	private int m_PageNumber; // 0x358
	private float m_MarginLeft; // 0x35C
	private float m_MarginRight; // 0x360
	private float m_Width; // 0x364
	private Extents m_MeshExtents; // 0x368
	private float m_MaxCapHeight; // 0x378
	private float m_MaxAscender; // 0x37C
	private float m_MaxDescender; // 0x380
	private bool m_IsNewPage; // 0x384
	private bool m_IsNonBreakingSpace; // 0x385
	private WordWrapState m_SavedWordWrapState; // 0x388
	private WordWrapState m_SavedLineState; // 0x720
	private WordWrapState m_SavedEllipsisState; // 0xAB8
	private WordWrapState m_SavedLastValidState; // 0xE50
	private WordWrapState m_SavedSoftLineBreakState; // 0x11E8
	private TextElementType m_TextElementType; // 0x1580
	private bool m_isTextLayoutPhase; // 0x1581
	private int m_SpriteIndex; // 0x1584
	private Color32 m_SpriteColor; // 0x1588
	private TextElement m_CachedTextElement; // 0x1590
	private Color32 m_HighlightColor; // 0x1598
	private float m_CharWidthAdjDelta; // 0x159C
	private float m_MaxFontSize; // 0x15A0
	private float m_MinFontSize; // 0x15A4
	private int m_AutoSizeIterationCount; // 0x15A8
	private int m_AutoSizeMaxIterationCount; // 0x15AC
	private float m_StartOfLineAscender; // 0x15B0
	private float m_LineSpacingDelta; // 0x15B4
	internal MaterialReference[] m_MaterialReferences; // 0x15B8
	private int m_SpriteCount; // 0x15C0
	private TextProcessingStack<int> m_StyleStack; // 0x15C8
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x15E8
	private int m_SpriteAnimationId; // 0x19A0
	private int m_ItalicAngle; // 0x19A4
	private Vector3 m_FXScale; // 0x19A8
	private Quaternion m_FXRotation; // 0x19B4
	private int m_LastBaseGlyphIndex; // 0x19C4
	private float m_PageAscender; // 0x19C8
	private RichTextTagAttribute[] m_XmlAttribute; // 0x19D0
	private float[] m_AttributeParameterValues; // 0x19D8
	private Dictionary<int, int> m_MaterialReferenceIndexLookup; // 0x19E0
	private bool m_IsCalculatingPreferredValues; // 0x19E8
	private bool m_TintSprite; // 0x19E9
	protected TextGenerator.SpecialCharacter m_Ellipsis; // 0x19F0
	protected TextGenerator.SpecialCharacter m_Underline; // 0x1A10
	private TextElementInfo[] m_InternalTextElementInfo; // 0x1A30

	// Properties
	public bool isTextTruncated { get; }

	// Methods

	// RVA: 0x2404520 Offset: 0x2402B20 VA: 0x182404520
	public void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x241DE80 Offset: 0x241C480 VA: 0x18241DE80
	public bool get_isTextTruncated() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2404110 Offset: 0x2402710 VA: 0x182404110
	internal void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2417A30 Offset: 0x2416030 VA: 0x182417A30
	private bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, out bool isThreadSuccess) { }

	// RVA: 0x2401D80 Offset: 0x2400380 VA: 0x182401D80
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x2415650 Offset: 0x2413C50 VA: 0x182415650
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) { }

	// RVA: 0x2413220 Offset: 0x2411820 VA: 0x182413220
	private int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) { }

	// RVA: 0x24137C0 Offset: 0x2411DC0 VA: 0x1824137C0
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2414C40 Offset: 0x2413240 VA: 0x182414C40
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2402A10 Offset: 0x2401010 VA: 0x182402A10
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2401FA0 Offset: 0x24005A0 VA: 0x182401FA0
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2401DF0 Offset: 0x24003F0 VA: 0x182401DF0
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	// RVA: 0x2405CC0 Offset: 0x24042C0 VA: 0x182405CC0
	public void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender) { }

	// RVA: 0x240AD50 Offset: 0x2409350 VA: 0x18240AD50
	public void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, out uint charCode, out float maxVisibleDescender) { }

	// RVA: 0x2405460 Offset: 0x2403A60 VA: 0x182405460
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2404B10 Offset: 0x2403110 VA: 0x182404B10
	public Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x2404980 Offset: 0x2402F80 VA: 0x182404980
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x23FE2B0 Offset: 0x23FC8B0 VA: 0x1823FE2B0 Slot: 4
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingMode textWrapMode, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2412F20 Offset: 0x2411520 VA: 0x182412F20
	internal void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2412DB0 Offset: 0x24113B0 VA: 0x182412DB0
	internal bool PrepareFontAsset(TextGenerationSettings generationSettings) { }

	// RVA: 0x2415BF0 Offset: 0x24141F0 VA: 0x182415BF0
	private int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2404DB0 Offset: 0x24033B0 VA: 0x182404DB0
	private TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x2411F50 Offset: 0x2410550 VA: 0x182411F50
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x2411E60 Offset: 0x2410460 VA: 0x182411E60
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x2412020 Offset: 0x2410620 VA: 0x182412020
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	// RVA: 0x2410B70 Offset: 0x240F170 VA: 0x182410B70
	private bool PopulateFontAsset(TextGenerationSettings generationSettings, TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x2401E20 Offset: 0x2400420 VA: 0x182401E20
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	// RVA: 0x2404D60 Offset: 0x2403360 VA: 0x182404D60
	protected bool GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	// RVA: 0x24046B0 Offset: 0x2402CB0 VA: 0x1824046B0
	protected bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x2405320 Offset: 0x2403920 VA: 0x182405320
	protected bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x2401F20 Offset: 0x2400520 VA: 0x182401F20
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	// RVA: 0x241D4C0 Offset: 0x241BAC0 VA: 0x18241D4C0
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings> // TypeDefIndex: 12336
{
	// Fields
	public string text; // 0x10
	public Rect screenRect; // 0x18
	public Vector4 margins; // 0x28
	public float scale; // 0x38
	public FontAsset fontAsset; // 0x40
	public Material material; // 0x48
	public SpriteAsset spriteAsset; // 0x50
	public TextStyleSheet styleSheet; // 0x58
	public FontStyles fontStyle; // 0x60
	public TextSettings textSettings; // 0x68
	public TextAlignment textAlignment; // 0x70
	public TextOverflowMode overflowMode; // 0x74
	public bool wordWrap; // 0x78
	public float wordWrappingRatio; // 0x7C
	public Color color; // 0x80
	public TextColorGradient fontColorGradient; // 0x90
	public TextColorGradient fontColorGradientPreset; // 0x98
	public bool tintSprites; // 0xA0
	public bool overrideRichTextColors; // 0xA1
	public bool shouldConvertToLinearSpace; // 0xA2
	public float fontSize; // 0xA4
	public bool autoSize; // 0xA8
	public float fontSizeMin; // 0xAC
	public float fontSizeMax; // 0xB0
	public List<OTL_FeatureTag> fontFeatures; // 0xB8
	public bool emojiFallbackSupport; // 0xC0
	public bool richText; // 0xC1
	public bool isRightToLeft; // 0xC2
	public float extraPadding; // 0xC4
	public bool parseControlCharacters; // 0xC8
	public bool isOrthographic; // 0xC9
	public bool isPlaceholder; // 0xCA
	public bool tagNoParsing; // 0xCB
	public float characterSpacing; // 0xCC
	public float wordSpacing; // 0xD0
	public float lineSpacing; // 0xD4
	public float paragraphSpacing; // 0xD8
	public float lineSpacingMax; // 0xDC
	public TextWrappingMode textWrappingMode; // 0xE0
	public int maxVisibleCharacters; // 0xE4
	public int maxVisibleWords; // 0xE8
	public int maxVisibleLines; // 0xEC
	public int firstVisibleCharacter; // 0xF0
	public bool useMaxVisibleDescender; // 0xF4
	public TextFontWeight fontWeight; // 0xF8
	public int pageToDisplay; // 0xFC
	public TextureMapping horizontalMapping; // 0x100
	public TextureMapping verticalMapping; // 0x104
	public float uvLineOffset; // 0x108
	public VertexSortingOrder geometrySortingOrder; // 0x10C
	public bool inverseYAxis; // 0x110
	public bool isIMGUI; // 0x111
	public float charWidthMaxAdj; // 0x114
	internal TextInputSource inputSource; // 0x118

	// Methods

	// RVA: 0x2424130 Offset: 0x2422730 VA: 0x182424130
	public void .ctor() { }

	// RVA: 0x2420A90 Offset: 0x241F090 VA: 0x182420A90 Slot: 4
	public bool Equals(TextGenerationSettings other) { }

	// RVA: 0x24210B0 Offset: 0x241F6B0 VA: 0x1824210B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24211B0 Offset: 0x241F7B0 VA: 0x1824211B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20B7470 Offset: 0x20B5A70 VA: 0x1820B7470
	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	// RVA: 0x2421770 Offset: 0x241FD70 VA: 0x182421770 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal enum TextAlignment // TypeDefIndex: 12337
{
	// Fields
	public int value__; // 0x0
	public const TextAlignment TopLeft = 257;
	public const TextAlignment TopCenter = 258;
	public const TextAlignment TopRight = 260;
	public const TextAlignment TopJustified = 264;
	public const TextAlignment TopFlush = 272;
	public const TextAlignment TopGeoAligned = 288;
	public const TextAlignment MiddleLeft = 513;
	public const TextAlignment MiddleCenter = 514;
	public const TextAlignment MiddleRight = 516;
	public const TextAlignment MiddleJustified = 520;
	public const TextAlignment MiddleFlush = 528;
	public const TextAlignment MiddleGeoAligned = 544;
	public const TextAlignment BottomLeft = 1025;
	public const TextAlignment BottomCenter = 1026;
	public const TextAlignment BottomRight = 1028;
	public const TextAlignment BottomJustified = 1032;
	public const TextAlignment BottomFlush = 1040;
	public const TextAlignment BottomGeoAligned = 1056;
	public const TextAlignment BaselineLeft = 2049;
	public const TextAlignment BaselineCenter = 2050;
	public const TextAlignment BaselineRight = 2052;
	public const TextAlignment BaselineJustified = 2056;
	public const TextAlignment BaselineFlush = 2064;
	public const TextAlignment BaselineGeoAligned = 2080;
	public const TextAlignment MidlineLeft = 4097;
	public const TextAlignment MidlineCenter = 4098;
	public const TextAlignment MidlineRight = 4100;
	public const TextAlignment MidlineJustified = 4104;
	public const TextAlignment MidlineFlush = 4112;
	public const TextAlignment MidlineGeoAligned = 4128;
	public const TextAlignment CaplineLeft = 8193;
	public const TextAlignment CaplineCenter = 8194;
	public const TextAlignment CaplineRight = 8196;
	public const TextAlignment CaplineJustified = 8200;
	public const TextAlignment CaplineFlush = 8208;
	public const TextAlignment CaplineGeoAligned = 8224;
}

// Namespace: UnityEngine.TextCore.Text
[Flags]
public enum FontStyles // TypeDefIndex: 12338
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

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal enum TextOverflowMode // TypeDefIndex: 12339
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowMode Overflow = 0;
	public const TextOverflowMode Ellipsis = 1;
	public const TextOverflowMode Masking = 2;
	public const TextOverflowMode Truncate = 3;
	public const TextOverflowMode ScrollRect = 4;
	public const TextOverflowMode Page = 5;
	public const TextOverflowMode Linked = 6;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextureMapping // TypeDefIndex: 12340
{
	// Fields
	public int value__; // 0x0
	public const TextureMapping Character = 0;
	public const TextureMapping Line = 1;
	public const TextureMapping Paragraph = 2;
	public const TextureMapping MatchAspect = 3;
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal enum TextWrappingMode // TypeDefIndex: 12341
{
	// Fields
	public int value__; // 0x0
	public const TextWrappingMode NoWrap = 0;
	public const TextWrappingMode Normal = 1;
	public const TextWrappingMode PreserveWhitespace = 2;
	public const TextWrappingMode PreserveWhitespaceNoWrap = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextInputSource // TypeDefIndex: 12342
{
	// Fields
	public int value__; // 0x0
	public const TextInputSource TextInputBox = 0;
	public const TextInputSource SetText = 1;
	public const TextInputSource SetTextArray = 2;
	public const TextInputSource TextString = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal struct RichTextTagAttribute // TypeDefIndex: 12343
{
	// Fields
	public int nameHashCode; // 0x0
	public int valueHashCode; // 0x4
	public TagValueType valueType; // 0x8
	public int valueStartIndex; // 0xC
	public int valueLength; // 0x10
	public TagUnitType unitType; // 0x14
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TextProcessingElement // TypeDefIndex: 12344
{
	// Fields
	public TextProcessingElementType elementType; // 0x0
	public uint unicode; // 0x4
	public int stringIndex; // 0x8
	public int length; // 0xC
}

// Namespace: UnityEngine.TextCore.Text
[DefaultMember("Item")]
internal struct TextBackingContainer // TypeDefIndex: 12345
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0xF2FCE0 Offset: 0xF2E2E0 VA: 0x180F2FCE0
	public int get_Capacity() { }

	// RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	public int get_Count() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_Count(int value) { }

	// RVA: 0x21E17B0 Offset: 0x21DFDB0 VA: 0x1821E17B0
	public uint get_Item(int index) { }

	// RVA: 0x241E620 Offset: 0x241CC20 VA: 0x18241E620
	public void set_Item(int index, uint value) { }

	// RVA: 0x241E5C0 Offset: 0x241CBC0 VA: 0x18241E5C0
	public void .ctor(int size) { }

	// RVA: 0x241E540 Offset: 0x241CB40 VA: 0x18241E540
	public void Resize(int size) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct CharacterSubstitution // TypeDefIndex: 12346
{
	// Fields
	public int index; // 0x0
	public uint unicode; // 0x4

	// Methods

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int index, uint unicode) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Offset // TypeDefIndex: 12347
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; }
	public float right { get; }
	public float top { get; }
	public float bottom { get; }
	public static Offset zero { get; }

	// Methods

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_left() { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_right() { }

	// RVA: 0x22FFFF0 Offset: 0x22FE5F0 VA: 0x1822FFFF0
	public float get_top() { }

	// RVA: 0x22E91B0 Offset: 0x22E77B0 VA: 0x1822E91B0
	public float get_bottom() { }

	// RVA: 0x241E380 Offset: 0x241C980 VA: 0x18241E380
	public static Offset get_zero() { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x177A1C0 Offset: 0x17787C0 VA: 0x18177A1C0
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	// RVA: 0x2317510 Offset: 0x2315B10 VA: 0x182317510
	public static Offset op_Multiply(Offset a, float b) { }

	// RVA: 0x241E2F0 Offset: 0x241C8F0 VA: 0x18241E2F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x241E290 Offset: 0x241C890 VA: 0x18241E290 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x241E340 Offset: 0x241C940 VA: 0x18241E340
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct HighlightState // TypeDefIndex: 12348
{
	// Fields
	public Color32 color; // 0x0
	public Offset padding; // 0x4

	// Methods

	// RVA: 0x11057E0 Offset: 0x1103DE0 VA: 0x1811057E0
	public void .ctor(Color32 color, Offset padding) { }

	// RVA: 0x241DF60 Offset: 0x241C560 VA: 0x18241DF60
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x241E0A0 Offset: 0x241C6A0 VA: 0x18241E0A0
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x241DF00 Offset: 0x241C500 VA: 0x18241DF00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x241DE90 Offset: 0x241C490 VA: 0x18241DE90 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordWrapState // TypeDefIndex: 12349
{
	// Fields
	public int previousWordBreak; // 0x0
	public int totalCharacterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int visibleSpaceCount; // 0xC
	public int visibleSpriteCount; // 0x10
	public int visibleLinkCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharIndex; // 0x24
	public int lineNumber; // 0x28
	public float maxCapHeight; // 0x2C
	public float maxAscender; // 0x30
	public float maxDescender; // 0x34
	public float maxLineAscender; // 0x38
	public float maxLineDescender; // 0x3C
	public float startOfLineAscender; // 0x40
	public float xAdvance; // 0x44
	public float preferredWidth; // 0x48
	public float preferredHeight; // 0x4C
	public float previousLineScale; // 0x50
	public float pageAscender; // 0x54
	public int wordCount; // 0x58
	public FontStyles fontStyle; // 0x5C
	public float fontScale; // 0x60
	public float fontScaleMultiplier; // 0x64
	public int italicAngle; // 0x68
	public float currentFontSize; // 0x6C
	public float baselineOffset; // 0x70
	public float lineOffset; // 0x74
	public TextInfo textInfo; // 0x78
	public LineInfo lineInfo; // 0x80
	public Color32 vertexColor; // 0xDC
	public Color32 underlineColor; // 0xE0
	public Color32 strikethroughColor; // 0xE4
	public Color32 highlightColor; // 0xE8
	public HighlightState highlightState; // 0xEC
	public FontStyleStack basicStyleStack; // 0x100
	public TextProcessingStack<int> italicAngleStack; // 0x110
	public TextProcessingStack<Color32> colorStack; // 0x130
	public TextProcessingStack<Color32> underlineColorStack; // 0x150
	public TextProcessingStack<Color32> strikethroughColorStack; // 0x170
	public TextProcessingStack<Color32> highlightColorStack; // 0x190
	public TextProcessingStack<HighlightState> highlightStateStack; // 0x1B0
	public TextProcessingStack<TextColorGradient> colorGradientStack; // 0x1E0
	public TextProcessingStack<float> sizeStack; // 0x208
	public TextProcessingStack<float> indentStack; // 0x228
	public TextProcessingStack<TextFontWeight> fontWeightStack; // 0x248
	public TextProcessingStack<int> styleStack; // 0x268
	public TextProcessingStack<float> baselineStack; // 0x288
	public TextProcessingStack<int> actionStack; // 0x2A8
	public TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2C8
	public TextProcessingStack<TextAlignment> lineJustificationStack; // 0x320
	public int lastBaseGlyphIndex; // 0x340
	public int spriteAnimationId; // 0x344
	public FontAsset currentFontAsset; // 0x348
	public SpriteAsset currentSpriteAsset; // 0x350
	public Material currentMaterial; // 0x358
	public int currentMaterialIndex; // 0x360
	public Extents meshExtents; // 0x364
	public bool tagNoParsing; // 0x374
	public bool isNonBreakingSpace; // 0x375
	public bool isDrivenLineSpacing; // 0x376
	public Vector3 fxScale; // 0x378
	public Quaternion fxRotation; // 0x384
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
[Extension]
internal static class TextGeneratorUtilities // TypeDefIndex: 12350
{
	// Fields
	public static readonly Vector2 largePositiveVector2; // 0x0
	public static readonly Vector2 largeNegativeVector2; // 0x8

	// Methods

	// RVA: 0x2424650 Offset: 0x2422C50 VA: 0x182424650
	public static bool Approximately(float a, float b) { }

	// RVA: 0x2427E20 Offset: 0x2426420 VA: 0x182427E20
	public static Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x24284A0 Offset: 0x2426AA0 VA: 0x1824284A0
	public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x2428740 Offset: 0x2426D40 VA: 0x182428740
	public static uint HexToInt(char hex) { }

	// RVA: 0x2424820 Offset: 0x2422E20 VA: 0x182424820
	public static float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x2424680 Offset: 0x2422C80 VA: 0x182424680
	public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C5160 Offset: 0x7C3760 VA: 0x1807C5160
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0x7C5060 Offset: 0x7C3660 VA: 0x1807C5060
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C51E0 Offset: 0x7C37E0 VA: 0x1807C51E0
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0x7C50E0 Offset: 0x7C36E0 VA: 0x1807C50E0
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2428B90 Offset: 0x2427190 VA: 0x182428B90
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2428960 Offset: 0x2426F60 VA: 0x182428960
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2429AB0 Offset: 0x24280B0 VA: 0x182429AB0
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2429CB0 Offset: 0x24282B0 VA: 0x182429CB0
	private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2429980 Offset: 0x2427F80 VA: 0x182429980
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2428A80 Offset: 0x2427080 VA: 0x182428A80
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2428850 Offset: 0x2426E50 VA: 0x182428850
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2428CB0 Offset: 0x24272B0 VA: 0x182428CB0
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2427840 Offset: 0x2425E40 VA: 0x182427840
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	// RVA: 0x2427760 Offset: 0x2425D60 VA: 0x182427760
	public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x2427680 Offset: 0x2425C80 VA: 0x182427680
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: 0x2427A30 Offset: 0x2426030 VA: 0x182427A30
	public static uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x2427930 Offset: 0x2425F30 VA: 0x182427930
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	// RVA: 0x2427B10 Offset: 0x2426110 VA: 0x182427B10
	public static uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x2427C70 Offset: 0x2426270 VA: 0x182427C70
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	// RVA: 0x24248B0 Offset: 0x2422EB0 VA: 0x1824248B0
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2425E20 Offset: 0x2424420 VA: 0x182425E20
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2424260 Offset: 0x2422860 VA: 0x182424260
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	// RVA: 0x2429EB0 Offset: 0x24284B0 VA: 0x182429EB0
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	// RVA: 0x2429900 Offset: 0x2427F00 VA: 0x182429900
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	// RVA: 0x2429880 Offset: 0x2427E80 VA: 0x182429880
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	// RVA: 0x24248A0 Offset: 0x2422EA0 VA: 0x1824248A0
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x24275C0 Offset: 0x2425BC0 VA: 0x1824275C0
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x2427500 Offset: 0x2425B00 VA: 0x182427500
	public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x242A0F0 Offset: 0x24286F0 VA: 0x18242A0F0
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x242A150 Offset: 0x2428750 VA: 0x18242A150
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x242A1B0 Offset: 0x24287B0 VA: 0x18242A1B0
	public static char ToUpperFast(char c) { }

	// RVA: 0x2427430 Offset: 0x2425A30 VA: 0x182427430
	public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x2429270 Offset: 0x2427870 VA: 0x182429270
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	// RVA: 0x2429150 Offset: 0x2427750 VA: 0x182429150
	public static bool IsBaseGlyph(uint c) { }

	[Extension]
	// RVA: 0x2429930 Offset: 0x2427F30 VA: 0x182429930
	public static Color MinAlpha(Color c1, Color c2) { }

	// RVA: 0x2427300 Offset: 0x2425900 VA: 0x182427300
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x2427380 Offset: 0x2425980 VA: 0x182427380
	private static byte GammaToLinear(byte value) { }

	// RVA: 0x2429780 Offset: 0x2427D80 VA: 0x182429780
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	// RVA: 0x2429800 Offset: 0x2427E00 VA: 0x182429800
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	// RVA: 0x2429360 Offset: 0x2427960 VA: 0x182429360
	internal static bool IsEmoji(uint c) { }

	// RVA: 0x2429720 Offset: 0x2427D20 VA: 0x182429720
	internal static bool IsHangul(uint c) { }

	// RVA: 0x24292A0 Offset: 0x24278A0 VA: 0x1824292A0
	internal static bool IsCJK(uint c) { }

	// RVA: 0x242A210 Offset: 0x2428810 VA: 0x18242A210
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal class TextHandle // TypeDefIndex: 12352
{
	// Fields
	private static TextGenerationSettings[] s_Settings; // 0x0
	private static TextGenerator[] s_Generators; // 0x8
	private static TextInfo[] s_TextInfosCommon; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector2 <preferredSize>k__BackingField; // 0x10
	private Rect m_ScreenRect; // 0x18
	private float m_LineHeightDefault; // 0x28
	private bool m_IsPlaceholder; // 0x2C
	private bool m_IsCached; // 0x2D
	private LinkedListNode<TextInfo> m_TextInfoNode; // 0x30
	private bool m_IsEllided; // 0x38
	private static LinkedList<TextInfo> s_TextInfoPool; // 0x18
	private static double s_MinTimeInCache; // 0x20
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal static double currentTime; // 0x28
	private static object syncRoot; // 0x30
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal int m_PreviousGenerationSettingsHash; // 0x3C
	protected internal static List<OTL_FeatureTag> m_ActiveFontFeatures; // 0x38
	private bool isDirty; // 0x40

	// Properties
	internal static TextGenerationSettings[] settingsArray { get; }
	internal static TextGenerator[] generators { get; }
	internal static TextInfo[] textInfosCommon { get; }
	internal static TextInfo textInfoCommon { get; }
	private static TextGenerator generator { get; }
	internal static TextGenerationSettings settings { get; }
	internal Vector2 preferredSize { get; set; }
	internal TextInfo textInfo { get; }
	public bool IsPlaceholder { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x242D160 Offset: 0x242B760 VA: 0x18242D160
	internal static void InitThreadArrays() { }

	// RVA: 0x242FE30 Offset: 0x242E430 VA: 0x18242FE30
	internal static TextGenerationSettings[] get_settingsArray() { }

	// RVA: 0x242FC60 Offset: 0x242E260 VA: 0x18242FC60
	internal static TextGenerator[] get_generators() { }

	// RVA: 0x2430490 Offset: 0x242EA90 VA: 0x182430490
	internal static TextInfo[] get_textInfosCommon() { }

	// RVA: -1 Offset: -1
	private static void InitArray<T>(ref T[] array, Func<T> createInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C5410 Offset: 0x7C3A10 VA: 0x1807C5410
	|-TextHandle.InitArray<object>
	|
	|-RVA: 0x7C5260 Offset: 0x7C3860 VA: 0x1807C5260
	|-TextHandle.InitArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2430210 Offset: 0x242E810 VA: 0x182430210
	internal static TextInfo get_textInfoCommon() { }

	// RVA: 0x242FA50 Offset: 0x242E050 VA: 0x18242FA50
	private static TextGenerator get_generator() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x2430000 Offset: 0x242E600 VA: 0x182430000
	internal static TextGenerationSettings get_settings() { }

	// RVA: 0x242A7F0 Offset: 0x2428DF0 VA: 0x18242A7F0 Slot: 1
	protected override void Finalize() { }

	[CompilerGenerated]
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	internal Vector2 get_preferredSize() { }

	[CompilerGenerated]
	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	private void set_preferredSize(Vector2 value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x2430420 Offset: 0x242EA20 VA: 0x182430420
	internal TextInfo get_textInfo() { }

	// RVA: 0x242A270 Offset: 0x2428870 VA: 0x18242A270 Slot: 4
	public virtual void AddTextInfoToCache() { }

	// RVA: 0x242EA40 Offset: 0x242D040 VA: 0x18242EA40 Slot: 5
	public virtual void RemoveTextInfoFromCache() { }

	// RVA: 0x242E8C0 Offset: 0x242CEC0 VA: 0x18242E8C0
	private void RefreshCaching() { }

	// RVA: 0x242E590 Offset: 0x242CB90 VA: 0x18242E590
	private void RecycleTextInfoFromCache() { }

	// RVA: 0x40CE40 Offset: 0x40B440 VA: 0x18040CE40
	public void SetDirty() { }

	// RVA: 0x242D550 Offset: 0x242BB50 VA: 0x18242D550
	public bool IsDirty(TextGenerationSettings settings) { }

	// RVA: 0x242C230 Offset: 0x242A830 VA: 0x18242C230
	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = True) { }

	// RVA: 0x242C4E0 Offset: 0x242AAE0 VA: 0x18242C4E0
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = False, bool inverseYAxis = True) { }

	// RVA: 0x242BF20 Offset: 0x242A520 VA: 0x18242BF20
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = True) { }

	// RVA: 0x242D7C0 Offset: 0x242BDC0 VA: 0x18242D7C0
	public int LineDownCharacterPosition(int originalPos) { }

	// RVA: 0x242DD30 Offset: 0x242C330 VA: 0x18242DD30
	public int LineUpCharacterPosition(int originalPos) { }

	// RVA: 0x242BAA0 Offset: 0x242A0A0 VA: 0x18242BAA0
	public int FindNearestLine(Vector2 position) { }

	// RVA: 0x242B070 Offset: 0x2429670 VA: 0x18242B070
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	// RVA: 0x242A860 Offset: 0x2428E60 VA: 0x18242A860
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = True) { }

	// RVA: 0x242BE80 Offset: 0x242A480 VA: 0x18242BE80
	public int GetCorrespondingStringIndex(int index) { }

	// RVA: 0x242CC90 Offset: 0x242B290 VA: 0x18242CC90
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	// RVA: 0x242E2E0 Offset: 0x242C8E0 VA: 0x18242E2E0
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x21E34A0 Offset: 0x21E1AA0 VA: 0x1821E34A0
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x242CEB0 Offset: 0x242B4B0 VA: 0x18242CEB0
	public int GetLineNumber(int index) { }

	// RVA: 0x242CB60 Offset: 0x242B160 VA: 0x18242CB60
	public float GetLineHeight(int lineNumber) { }

	// RVA: 0x242C930 Offset: 0x242AF30 VA: 0x18242C930
	public float GetLineHeightFromCharacterIndex(int index) { }

	// RVA: 0x242BC60 Offset: 0x242A260 VA: 0x18242BC60
	public float GetCharacterHeightFromIndex(int index) { }

	// RVA: 0x54CA70 Offset: 0x54B070 VA: 0x18054CA70
	public bool get_IsPlaceholder() { }

	// RVA: 0x242D5B0 Offset: 0x242BBB0 VA: 0x18242D5B0
	public bool IsElided() { }

	// RVA: 0x242EC20 Offset: 0x242D220 VA: 0x18242EC20
	public string Substring(int startIndex, int length) { }

	// RVA: 0x242CFE0 Offset: 0x242B5E0 VA: 0x18242CFE0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x242D6A0 Offset: 0x242BCA0 VA: 0x18242D6A0
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x242F420 Offset: 0x242DA20 VA: 0x18242F420
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x242F4C0 Offset: 0x242DAC0 VA: 0x18242F4C0
	internal TextInfo Update() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x242E460 Offset: 0x242CA60 VA: 0x18242E460
	internal bool PrepareFontAsset() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x242EE30 Offset: 0x242D430 VA: 0x18242EE30
	internal void UpdatePreferredSize() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x242C790 Offset: 0x242AD90 VA: 0x18242C790
	internal static float GetLineHeightDefault(TextGenerationSettings settings) { }

	// RVA: 0x242F880 Offset: 0x242DE80 VA: 0x18242F880
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct PageInfo // TypeDefIndex: 12353
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordInfo // TypeDefIndex: 12354
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public int characterCount; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal class TextInfo // TypeDefIndex: 12355
{
	// Fields
	private static Vector2 s_InfinityVectorPositive; // 0x0
	private static Vector2 s_InfinityVectorNegative; // 0x8
	public int characterCount; // 0x10
	public int spriteCount; // 0x14
	public int spaceCount; // 0x18
	public int wordCount; // 0x1C
	public int linkCount; // 0x20
	public int lineCount; // 0x24
	public int pageCount; // 0x28
	public int materialCount; // 0x2C
	public TextElementInfo[] textElementInfo; // 0x30
	public WordInfo[] wordInfo; // 0x38
	public LinkInfo[] linkInfo; // 0x40
	public LineInfo[] lineInfo; // 0x48
	public PageInfo[] pageInfo; // 0x50
	public MeshInfo[] meshInfo; // 0x58
	public double lastTimeInCache; // 0x60
	public Action removedFromCache; // 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VertexDataLayout <vertexDataLayout>k__BackingField; // 0x70
	public bool hasMultipleColors; // 0x74

	// Properties
	public VertexDataLayout vertexDataLayout { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	public VertexDataLayout get_vertexDataLayout() { }

	[CompilerGenerated]
	// RVA: 0x4A4300 Offset: 0x4A2900 VA: 0x1804A4300
	private void set_vertexDataLayout(VertexDataLayout value) { }

	// RVA: 0x2430BB0 Offset: 0x242F1B0 VA: 0x182430BB0
	public void RemoveFromCache() { }

	// RVA: 0x2430C50 Offset: 0x242F250 VA: 0x182430C50
	public void .ctor(VertexDataLayout vertexDataLayout) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2430B30 Offset: 0x242F130 VA: 0x182430B30
	internal void Clear() { }

	// RVA: 0x2430940 Offset: 0x242EF40 VA: 0x182430940
	internal void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x2430660 Offset: 0x242EC60 VA: 0x182430660
	internal void ClearLineInfo() { }

	// RVA: 0x2430A00 Offset: 0x242F000 VA: 0x182430A00
	internal void ClearPageInfo() { }

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0780 Offset: 0x7BED80 VA: 0x1807C0780
	|-TextInfo.Resize<LinkInfo>
	|-TextInfo.Resize<WordInfo>
	|
	|-RVA: 0x7C0650 Offset: 0x7BEC50 VA: 0x1807C0650
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0800 Offset: 0x7BEE00 VA: 0x1807C0800
	|-TextInfo.Resize<MeshInfo>
	|-TextInfo.Resize<PageInfo>
	|-TextInfo.Resize<TextElementInfo>
	|
	|-RVA: 0x7C06D0 Offset: 0x7BECD0 VA: 0x1807C06D0
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2430BF0 Offset: 0x242F1F0 VA: 0x182430BF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum MarkupTag // TypeDefIndex: 12356
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

// Namespace: UnityEngine.TextCore.Text
internal enum TagValueType // TypeDefIndex: 12357
{
	// Fields
	public int value__; // 0x0
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagUnitType // TypeDefIndex: 12358
{
	// Fields
	public int value__; // 0x0
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextProcessingElementType // TypeDefIndex: 12359
{
	// Fields
	public int value__; // 0x0
	public const TextProcessingElementType Undefined = 0;
	public const TextProcessingElementType TextCharacterElement = 1;
	public const TextProcessingElementType TextMarkupElement = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal struct FontStyleStack // TypeDefIndex: 12360
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

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack<T> // TypeDefIndex: 12361
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

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5BB0 Offset: 0x9C41B0 VA: 0x1809C5BB0
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x9C59E0 Offset: 0x9C3FE0 VA: 0x1809C59E0
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x9CC400 Offset: 0x9CAA00 VA: 0x1809CC400
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x9CC770 Offset: 0x9CAD70 VA: 0x1809CC770
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0xA3D010 Offset: 0xA3B610 VA: 0x180A3D010
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x9CC460 Offset: 0x9CAA60 VA: 0x1809CC460
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5A30 Offset: 0x9C4030 VA: 0x1809C5A30
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x9C5B30 Offset: 0x9C4130 VA: 0x1809C5B30
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x9CBC30 Offset: 0x9CA230 VA: 0x1809CBC30
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x9CBD50 Offset: 0x9CA350 VA: 0x1809CBD50
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0xA3CF80 Offset: 0xA3B580 VA: 0x180A3CF80
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x9CC170 Offset: 0x9CA770 VA: 0x1809CC170
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5960 Offset: 0x9C3F60 VA: 0x1809C5960
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x9C5AA0 Offset: 0x9C40A0 VA: 0x1809C5AA0
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x9CC0D0 Offset: 0x9CA6D0 VA: 0x1809CC0D0
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x9CBBA0 Offset: 0x9CA1A0 VA: 0x1809CBBA0
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0xA3D070 Offset: 0xA3B670 VA: 0x180A3D070
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x9CBDD0 Offset: 0x9CA3D0 VA: 0x1809CBDD0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3D180 Offset: 0xA3B780 VA: 0x180A3D180
	|-TextProcessingStack<Color32>.get_Count
	|-TextProcessingStack<int>.get_Count
	|-TextProcessingStack<Int32Enum>.get_Count
	|-TextProcessingStack<float>.get_Count
	|
	|-RVA: 0xA3D1A0 Offset: 0xA3B7A0 VA: 0x180A3D1A0
	|-TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0xA3D190 Offset: 0xA3B790 VA: 0x180A3D190
	|-TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0xA3D120 Offset: 0xA3B720 VA: 0x180A3D120
	|-TextProcessingStack<object>.get_Count
	|
	|-RVA: 0xA3D110 Offset: 0xA3B710 VA: 0x180A3D110
	|-TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0xA3D130 Offset: 0xA3B730 VA: 0x180A3D130
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4FF0 Offset: 0x9C35F0 VA: 0x1809C4FF0
	|-TextProcessingStack<Color32>.get_current
	|-TextProcessingStack<int>.get_current
	|-TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0xA3A960 Offset: 0xA38F60 VA: 0x180A3A960
	|-TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0xA3A750 Offset: 0xA38D50 VA: 0x180A3A750
	|-TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x9C8340 Offset: 0x9C6940 VA: 0x1809C8340
	|-TextProcessingStack<object>.get_current
	|
	|-RVA: 0x9C8550 Offset: 0x9C6B50 VA: 0x1809C8550
	|-TextProcessingStack<float>.get_current
	|
	|-RVA: 0xA3A800 Offset: 0xA38E00 VA: 0x180A3A800
	|-TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0xA3A540 Offset: 0xA38B40 VA: 0x180A3A540
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5590 Offset: 0x9C3B90 VA: 0x1809C5590
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x9C5820 Offset: 0x9C3E20 VA: 0x1809C5820
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x9CAB40 Offset: 0x9C9140 VA: 0x1809CAB40
	|-TextProcessingStack<int>.SetDefault
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x9CB560 Offset: 0x9C9B60 VA: 0x1809CB560
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x9CB920 Offset: 0x9C9F20 VA: 0x1809CB920
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x9CB0D0 Offset: 0x9C96D0 VA: 0x1809CB0D0
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0xA3CDC0 Offset: 0xA3B3C0 VA: 0x180A3CDC0
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x9CB6C0 Offset: 0x9C9CC0 VA: 0x1809CB6C0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4F60 Offset: 0x9C3560 VA: 0x1809C4F60
	|-TextProcessingStack<Color32>.Clear
	|-TextProcessingStack<int>.Clear
	|-TextProcessingStack<Int32Enum>.Clear
	|-TextProcessingStack<float>.Clear
	|
	|-RVA: 0x9C4F70 Offset: 0x9C3570 VA: 0x1809C4F70
	|-TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x9C8290 Offset: 0x9C6890 VA: 0x1809C8290
	|-TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x9C8190 Offset: 0x9C6790 VA: 0x1809C8190
	|-TextProcessingStack<object>.Clear
	|
	|-RVA: 0xA3A530 Offset: 0xA38B30 VA: 0x180A3A530
	|-TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x9C81A0 Offset: 0x9C67A0 VA: 0x1809C81A0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C5770 Offset: 0x9C3D70 VA: 0x1809C5770
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x9C56B0 Offset: 0x9C3CB0 VA: 0x1809C56B0
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x9CAC60 Offset: 0x9C9260 VA: 0x1809CAC60
	|-TextProcessingStack<int>.SetDefault
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x9CB1F0 Offset: 0x9C97F0 VA: 0x1809CB1F0
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x9CB4A0 Offset: 0x9C9AA0 VA: 0x1809CB4A0
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x9CB870 Offset: 0x9C9E70 VA: 0x1809CB870
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0xA3CC80 Offset: 0xA3B280 VA: 0x180A3CC80
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x9CAD10 Offset: 0x9C9310 VA: 0x1809CAD10
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4F20 Offset: 0x9C3520 VA: 0x1809C4F20
	|-TextProcessingStack<Color32>.Add
	|-TextProcessingStack<int>.Add
	|-TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x9C4ED0 Offset: 0x9C34D0 VA: 0x1809C4ED0
	|-TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x9C8040 Offset: 0x9C6640 VA: 0x1809C8040
	|-TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x9C7CE0 Offset: 0x9C62E0 VA: 0x1809C7CE0
	|-TextProcessingStack<object>.Add
	|
	|-RVA: 0x9C8000 Offset: 0x9C6600 VA: 0x1809C8000
	|-TextProcessingStack<float>.Add
	|
	|-RVA: 0xA3A470 Offset: 0xA38A70 VA: 0x180A3A470
	|-TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x9C7D30 Offset: 0x9C6330 VA: 0x1809C7D30
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C54A0 Offset: 0x9C3AA0 VA: 0x1809C54A0
	|-TextProcessingStack<Color32>.Remove
	|-TextProcessingStack<int>.Remove
	|-TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0xA3CBF0 Offset: 0xA3B1F0 VA: 0x180A3CBF0
	|-TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0xA3C5B0 Offset: 0xA3ABB0 VA: 0x180A3C5B0
	|-TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x9CAAE0 Offset: 0x9C90E0 VA: 0x1809CAAE0
	|-TextProcessingStack<object>.Remove
	|
	|-RVA: 0x9CA610 Offset: 0x9C8C10 VA: 0x1809CA610
	|-TextProcessingStack<float>.Remove
	|
	|-RVA: 0xA3C680 Offset: 0xA3AC80 VA: 0x180A3C680
	|-TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0xA3C800 Offset: 0xA3AE00 VA: 0x180A3C800
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3BBD0 Offset: 0xA3A1D0 VA: 0x180A3BBD0
	|-TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x9C5310 Offset: 0x9C3910 VA: 0x1809C5310
	|-TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x9C9D10 Offset: 0x9C8310 VA: 0x1809C9D10
	|-TextProcessingStack<int>.Push
	|-TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x9C99E0 Offset: 0x9C7FE0 VA: 0x1809C99E0
	|-TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x9C9AE0 Offset: 0x9C80E0 VA: 0x1809C9AE0
	|-TextProcessingStack<object>.Push
	|
	|-RVA: 0xA3BC90 Offset: 0xA3A290 VA: 0x180A3BC90
	|-TextProcessingStack<float>.Push
	|
	|-RVA: 0xA3BD60 Offset: 0xA3A360 VA: 0x180A3BD60
	|-TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0xA3BEB0 Offset: 0xA3A4B0 VA: 0x180A3BEB0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3BB30 Offset: 0xA3A130 VA: 0x180A3BB30
	|-TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0xA3AE40 Offset: 0xA39440 VA: 0x180A3AE40
	|-TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x9C8990 Offset: 0x9C6F90 VA: 0x1809C8990
	|-TextProcessingStack<int>.Pop
	|-TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0xA3B9C0 Offset: 0xA39FC0 VA: 0x180A3B9C0
	|-TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0xA3B630 Offset: 0xA39C30 VA: 0x180A3B630
	|-TextProcessingStack<object>.Pop
	|
	|-RVA: 0x9C9550 Offset: 0x9C7B50 VA: 0x1809C9550
	|-TextProcessingStack<float>.Pop
	|
	|-RVA: 0xA3B6F0 Offset: 0xA39CF0 VA: 0x180A3B6F0
	|-TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0xA3AF10 Offset: 0xA39510 VA: 0x180A3AF10
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C50A0 Offset: 0x9C36A0 VA: 0x1809C50A0
	|-TextProcessingStack<Color32>.Peek
	|-TextProcessingStack<int>.Peek
	|-TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0xA3A9E0 Offset: 0xA38FE0 VA: 0x180A3A9E0
	|-TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0xA3ADA0 Offset: 0xA393A0 VA: 0x180A3ADA0
	|-TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x9C86C0 Offset: 0x9C6CC0 VA: 0x1809C86C0
	|-TextProcessingStack<object>.Peek
	|
	|-RVA: 0x9C8790 Offset: 0x9C6D90 VA: 0x1809C8790
	|-TextProcessingStack<float>.Peek
	|
	|-RVA: 0xA3AA50 Offset: 0xA39050 VA: 0x180A3AA50
	|-TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0xA3AB90 Offset: 0xA39190 VA: 0x180A3AB90
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9C4FF0 Offset: 0x9C35F0 VA: 0x1809C4FF0
	|-TextProcessingStack<Color32>.CurrentItem
	|-TextProcessingStack<int>.CurrentItem
	|-TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0xA3A960 Offset: 0xA38F60 VA: 0x180A3A960
	|-TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0xA3A750 Offset: 0xA38D50 VA: 0x180A3A750
	|-TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x9C8340 Offset: 0x9C6940 VA: 0x1809C8340
	|-TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x9C8550 Offset: 0x9C6B50 VA: 0x1809C8550
	|-TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0xA3A800 Offset: 0xA38E00 VA: 0x180A3A800
	|-TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0xA3A540 Offset: 0xA38B40 VA: 0x180A3A540
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/
}

// Namespace: UnityEngine.TextCore.Text
internal class TextResourceManager // TypeDefIndex: 12363
{
	// Fields
	private static readonly Dictionary<int, TextResourceManager.FontAssetRef> s_FontAssetReferences; // 0x0
	private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup; // 0x8
	private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
	private static readonly List<int> s_FontAssetRemovalList; // 0x18
	private static readonly int k_RegularStyleHashCode; // 0x20

	// Methods

	// RVA: 0x2430E40 Offset: 0x242F440 VA: 0x182430E40
	internal static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x2431450 Offset: 0x242FA50 VA: 0x182431450
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
public static class TextShaderUtilities // TypeDefIndex: 12364
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
	private static Shader k_ShaderRef_MobileSDF_IMGUI; // 0x150
	private static Shader k_ShaderRef_MobileBitmap; // 0x158
	private static Shader k_ShaderRef_Sprite; // 0x160

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileSDF_IMGUI { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }
	internal static Shader ShaderRef_Sprite { get; }

	// Methods

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2432AF0 Offset: 0x24310F0 VA: 0x182432AF0
	internal static Shader get_ShaderRef_MobileSDF() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x2432930 Offset: 0x2430F30 VA: 0x182432930
	internal static Shader get_ShaderRef_MobileSDF_IMGUI() { }

	// RVA: 0x24326B0 Offset: 0x2430CB0 VA: 0x1824326B0
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x2432D00 Offset: 0x2431300 VA: 0x182432D00
	internal static Shader get_ShaderRef_Sprite() { }

	// RVA: 0x2432370 Offset: 0x2430970 VA: 0x182432370
	private static void .cctor() { }

	// RVA: 0x2431880 Offset: 0x242FE80 VA: 0x182431880
	internal static void GetShaderPropertyIDs() { }
}

// Namespace: UnityEngine.TextCore.Text
[Extension]
internal static class TextUtilities // TypeDefIndex: 12365
{
	// Methods

	// RVA: 0x2433020 Offset: 0x2431620 VA: 0x182433020
	internal static char ToUpperFast(char c) { }

	// RVA: 0x2432F80 Offset: 0x2431580 VA: 0x182432F80
	public static int GetHashCodeCaseInSensitive(string s) { }

	[Extension]
	// RVA: 0x2433080 Offset: 0x2431680 VA: 0x182433080
	internal static string UintToString(List<uint> unicodes) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class UnicodeLineBreakingRules // TypeDefIndex: 12366
{
	// Fields
	[SerializeField]
	private TextAsset m_UnicodeLineBreakingRules; // 0x10
	[SerializeField]
	private TextAsset m_LeadingCharacters; // 0x18
	[SerializeField]
	private TextAsset m_FollowingCharacters; // 0x20
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x28
	private HashSet<uint> m_LeadingCharactersLookup; // 0x30
	private HashSet<uint> m_FollowingCharactersLookup; // 0x38

	// Properties
	internal HashSet<uint> leadingCharactersLookup { get; }
	internal HashSet<uint> followingCharactersLookup { get; }
	public bool useModernHangulLineBreakingRules { get; }

	// Methods

	// RVA: 0x2433430 Offset: 0x2431A30 VA: 0x182433430
	internal HashSet<uint> get_leadingCharactersLookup() { }

	// RVA: 0x2433400 Offset: 0x2431A00 VA: 0x182433400
	internal HashSet<uint> get_followingCharactersLookup() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x2433210 Offset: 0x2431810 VA: 0x182433210
	internal void LoadLineBreakingRules() { }

	// RVA: 0x2433140 Offset: 0x2431740 VA: 0x182433140
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
[UsedByNativeCode("MeshInfo")]
[NativeHeader("Modules/TextCoreTextEngine/MeshInfo.h")]
internal struct MeshInfoBindings // TypeDefIndex: 12367
{
	// Fields
	public TextCoreVertex[] vertexData; // 0x0
	public Material material; // 0x8
	public int vertexCount; // 0x10
}

// Namespace: UnityEngine.TextCore.Text
[NativeHeader("Modules/TextCoreTextEngine/TextCoreVertex.h")]
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
[UsedByNativeCode("TextCoreVertex")]
internal struct TextCoreVertex // TypeDefIndex: 12368
{
	// Fields
	public Vector3 position; // 0x0
	public Color32 color; // 0xC
	public Vector2 uv0; // 0x10
	public Vector2 uv2; // 0x18
}

