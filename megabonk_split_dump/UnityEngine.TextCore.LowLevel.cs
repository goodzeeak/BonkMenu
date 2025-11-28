// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Flags]
public enum GlyphLoadFlags // TypeDefIndex: 13692
{
	// Fields
	public int value__; // 0x0
	public const GlyphLoadFlags LOAD_DEFAULT = 0;
	public const GlyphLoadFlags LOAD_NO_SCALE = 1;
	public const GlyphLoadFlags LOAD_NO_HINTING = 2;
	public const GlyphLoadFlags LOAD_RENDER = 4;
	public const GlyphLoadFlags LOAD_NO_BITMAP = 8;
	public const GlyphLoadFlags LOAD_FORCE_AUTOHINT = 32;
	public const GlyphLoadFlags LOAD_MONOCHROME = 4096;
	public const GlyphLoadFlags LOAD_NO_AUTOHINT = 32768;
	public const GlyphLoadFlags LOAD_COLOR = 1048576;
	public const GlyphLoadFlags LOAD_COMPUTE_METRICS = 2097152;
	public const GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY = 4194304;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum FontEngineError // TypeDefIndex: 13693
{
	// Fields
	public int value__; // 0x0
	public const FontEngineError Success = 0;
	public const FontEngineError Invalid_File_Path = 1;
	public const FontEngineError Invalid_File_Format = 2;
	public const FontEngineError Invalid_File_Structure = 3;
	public const FontEngineError Invalid_File = 4;
	public const FontEngineError Invalid_Table = 8;
	public const FontEngineError Invalid_Glyph_Index = 16;
	public const FontEngineError Invalid_Character_Code = 17;
	public const FontEngineError Invalid_Pixel_Size = 23;
	public const FontEngineError Invalid_Library = 33;
	public const FontEngineError Invalid_Face = 35;
	public const FontEngineError Invalid_Library_or_Face = 41;
	public const FontEngineError Atlas_Generation_Cancelled = 100;
	public const FontEngineError Invalid_SharedTextureData = 101;
	public const FontEngineError OpenTypeLayoutLookup_Mismatch = 116;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
public enum GlyphRenderMode // TypeDefIndex: 13694
{
	// Fields
	public int value__; // 0x0
	public const GlyphRenderMode SMOOTH_HINTED = 4121;
	public const GlyphRenderMode SMOOTH = 4117;
	public const GlyphRenderMode COLOR_HINTED = 69656;
	public const GlyphRenderMode COLOR = 69652;
	public const GlyphRenderMode RASTER_HINTED = 4122;
	public const GlyphRenderMode RASTER = 4118;
	public const GlyphRenderMode SDF = 4134;
	public const GlyphRenderMode SDF8 = 8230;
	public const GlyphRenderMode SDF16 = 16422;
	public const GlyphRenderMode SDF32 = 32806;
	public const GlyphRenderMode SDFAA_HINTED = 4169;
	public const GlyphRenderMode SDFAA = 4165;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
public enum GlyphPackingMode // TypeDefIndex: 13695
{
	// Fields
	public int value__; // 0x0
	public const GlyphPackingMode BestShortSideFit = 0;
	public const GlyphPackingMode BestLongSideFit = 1;
	public const GlyphPackingMode BestAreaFit = 2;
	public const GlyphPackingMode BottomLeftRule = 3;
	public const GlyphPackingMode ContactPointRule = 4;
}

// Namespace: UnityEngine.TextCore.LowLevel
[DebuggerDisplay("{familyName} - {styleName}")]
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
internal struct FontReference // TypeDefIndex: 13696
{
	// Fields
	public string familyName; // 0x0
	public string styleName; // 0x8
	public int faceIndex; // 0x10
	public string filePath; // 0x18
}

// Namespace: UnityEngine.TextCore.LowLevel
[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
public sealed class FontEngine // TypeDefIndex: 13697
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray; // 0x30
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x38
	private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray; // 0x40
	private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray; // 0x48
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x50

	// Methods

	// RVA: 0x23E65E0 Offset: 0x23E4BE0 VA: 0x1823E65E0
	public static FontEngineError LoadFontFace(string filePath) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x23E5C60 Offset: 0x23E4260 VA: 0x1823E5C60
	private static int LoadFontFace_Internal(string filePath) { }

	// RVA: 0x23E6500 Offset: 0x23E4B00 VA: 0x1823E6500
	public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x23E5E50 Offset: 0x23E4450 VA: 0x1823E5E50
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x23E6420 Offset: 0x23E4A20 VA: 0x1823E6420
	public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x23E6060 Offset: 0x23E4660 VA: 0x1823E6060
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x23E6570 Offset: 0x23E4B70 VA: 0x1823E6570
	public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x23E6170 Offset: 0x23E4770 VA: 0x1823E6170
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x23E8C70 Offset: 0x23E7270 VA: 0x1823E8C70
	public static FontEngineError UnloadFontFace() { }

	[NativeMethod(Name = "TextCore::FontEngine::UnloadFontFace", IsFreeFunction = True)]
	// RVA: 0x23E8C40 Offset: 0x23E7240 VA: 0x1823E8C40
	private static int UnloadFontFace_Internal() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E8BD0 Offset: 0x23E71D0 VA: 0x1823E8BD0
	internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E8920 Offset: 0x23E6F20 VA: 0x1823E8920
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	// RVA: 0x23E4860 Offset: 0x23E2E60 VA: 0x1823E4860
	public static FaceInfo GetFaceInfo() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E4820 Offset: 0x23E2E20 VA: 0x1823E4820
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	// RVA: 0x23E4970 Offset: 0x23E2F70 VA: 0x1823E4970
	public static string[] GetFontFaces() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFontFaces", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E4940 Offset: 0x23E2F40 VA: 0x1823E4940
	private static string[] GetFontFaces_Internal() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	[NativeMethod(Name = "TextCore::FontEngine::GetVariantGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E5B40 Offset: 0x23E4140 VA: 0x1823E5B40
	internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E49E0 Offset: 0x23E2FE0 VA: 0x1823E49E0
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x23E8740 Offset: 0x23E6D40 VA: 0x1823E8740
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E86F0 Offset: 0x23E6CF0 VA: 0x1823E86F0
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x23E8570 Offset: 0x23E6B70 VA: 0x1823E8570
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E8520 Offset: 0x23E6B20 VA: 0x1823E8520
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E6D40 Offset: 0x23E5340 VA: 0x1823E6D40
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E7060 Offset: 0x23E5660 VA: 0x1823E7060
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E6DE0 Offset: 0x23E53E0 VA: 0x1823E6DE0
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E7AC0 Offset: 0x23E60C0 VA: 0x1823E7AC0
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E76F0 Offset: 0x23E5CF0 VA: 0x1823E76F0
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllLigatureSubstitutionRecords", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x23E4400 Offset: 0x23E2A00 VA: 0x1823E4400
	internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E4C40 Offset: 0x23E3240 VA: 0x1823E4C40
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E4D40 Offset: 0x23E3340 VA: 0x1823E4D40
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(List<uint> glyphIndexes) { }

	// RVA: 0x23E4DD0 Offset: 0x23E33D0 VA: 0x1823E4DD0
	private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E6680 Offset: 0x23E4C80 VA: 0x1823E6680
	private static int PopulateLigatureSubstitutionRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E4C00 Offset: 0x23E3200 VA: 0x1823E4C00
	private static int GetLigatureSubstitutionRecordsFromMarshallingArray([Out] LigatureSubstitutionRecord[] ligatureSubstitutionRecords) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E4A20 Offset: 0x23E3020 VA: 0x1823E4A20
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = True)]
	// RVA: 0x23E6A90 Offset: 0x23E5090 VA: 0x1823E6A90
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllPairAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E4710 Offset: 0x23E2D10 VA: 0x1823E4710
	internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E58D0 Offset: 0x23E3ED0 VA: 0x1823E58D0
	internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x23E5960 Offset: 0x23E3F60 VA: 0x1823E5960
	private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E6B80 Offset: 0x23E5180 VA: 0x1823E6B80
	private static int PopulatePairAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E57B0 Offset: 0x23E3DB0 VA: 0x1823E57B0
	private static int GetPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToBaseAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E4470 Offset: 0x23E2A70 VA: 0x1823E4470
	internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E5300 Offset: 0x23E3900 VA: 0x1823E5300
	internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x23E5120 Offset: 0x23E3720 VA: 0x1823E5120
	private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E67C0 Offset: 0x23E4DC0 VA: 0x1823E67C0
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E5000 Offset: 0x23E3600 VA: 0x1823E5000
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray([Out] MarkToBaseAdjustmentRecord[] adjustmentRecords) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToMarkAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E45C0 Offset: 0x23E2BC0 VA: 0x1823E45C0
	internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E54F0 Offset: 0x23E3AF0 VA: 0x1823E54F0
	internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x23E5580 Offset: 0x23E3B80 VA: 0x1823E5580
	private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E6900 Offset: 0x23E4F00 VA: 0x1823E6900
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x23E53D0 Offset: 0x23E39D0 VA: 0x1823E53D0
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray([Out] MarkToMarkAdjustmentRecord[] adjustmentRecords) { }

	// RVA: 0x23E5B80 Offset: 0x23E4180 VA: 0x1823E5B80
	private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref uint[] dstArray) { }

	// RVA: -1 Offset: -1
	private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x701A10 Offset: 0x700010 VA: 0x180701A10
	|-FontEngine.GenericListToMarshallingArray<uint>
	|
	|-RVA: 0x701740 Offset: 0x6FFD40 VA: 0x180701740
	|-FontEngine.GenericListToMarshallingArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x701B40 Offset: 0x700140 VA: 0x180701B40
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	|-FontEngine.SetMarshallingArraySize<LigatureSubstitutionRecord>
	|-FontEngine.SetMarshallingArraySize<MarkToBaseAdjustmentRecord>
	|-FontEngine.SetMarshallingArraySize<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x701C00 Offset: 0x700200 VA: 0x180701C00
	|-FontEngine.SetMarshallingArraySize<__Il2CppFullySharedGenericType>
	*/

	[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x23E6CB0 Offset: 0x23E52B0 VA: 0x1823E6CB0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x23E8CD0 Offset: 0x23E72D0 VA: 0x1823E8CD0
	private static void .cctor() { }

	// RVA: 0x23E5C20 Offset: 0x23E4220 VA: 0x1823E5C20
	private static int LoadFontFace_Internal_Injected(ref ManagedSpanWrapper filePath) { }

	// RVA: 0x23E5E00 Offset: 0x23E4400 VA: 0x1823E5E00
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref ManagedSpanWrapper filePath, int pointSize, int faceIndex) { }

	// RVA: 0x23E6010 Offset: 0x23E4610 VA: 0x1823E6010
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(IntPtr font, int pointSize, int faceIndex) { }

	// RVA: 0x23E6110 Offset: 0x23E4710 VA: 0x1823E6110
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, int pointSize) { }

	// RVA: 0x23E88C0 Offset: 0x23E6EC0 VA: 0x1823E88C0
	private static bool TryGetSystemFontReference_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, out FontReference fontRef) { }

	// RVA: 0x23E6D80 Offset: 0x23E5380 VA: 0x1823E6D80
	private static bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x23E7680 Offset: 0x23E5C80 VA: 0x1823E7680
	private static bool TryAddGlyphsToTexture_Internal_Injected(ref ManagedSpanWrapper glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out BlittableArrayWrapper glyphs, ref int glyphCount) { }

	// RVA: 0x23E6630 Offset: 0x23E4C30 VA: 0x1823E6630
	private static int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x23E6A40 Offset: 0x23E5040 VA: 0x1823E6A40
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x23E46D0 Offset: 0x23E2CD0 VA: 0x1823E46D0
	private static void GetAllPairAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	// RVA: 0x23E69F0 Offset: 0x23E4FF0 VA: 0x1823E69F0
	private static int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x23E5770 Offset: 0x23E3D70 VA: 0x1823E5770
	private static int GetPairAdjustmentRecordsFromMarshallingArray_Injected(out BlittableArrayWrapper glyphPairAdjustmentRecords) { }

	// RVA: 0x23E4430 Offset: 0x23E2A30 VA: 0x1823E4430
	private static void GetAllMarkToBaseAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	// RVA: 0x23E6770 Offset: 0x23E4D70 VA: 0x1823E6770
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x23E4FC0 Offset: 0x23E35C0 VA: 0x1823E4FC0
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(out BlittableArrayWrapper adjustmentRecords) { }

	// RVA: 0x23E4580 Offset: 0x23E2B80 VA: 0x1823E4580
	private static void GetAllMarkToMarkAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	// RVA: 0x23E68B0 Offset: 0x23E4EB0 VA: 0x1823E68B0
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x23E5390 Offset: 0x23E3990 VA: 0x1823E5390
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(out BlittableArrayWrapper adjustmentRecords) { }

	// RVA: 0x23E6C70 Offset: 0x23E5270 VA: 0x1823E6C70
	private static void ResetAtlasTexture_Injected(IntPtr texture) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities // TypeDefIndex: 13698
{
	// Methods

	// RVA: 0x23E43E0 Offset: 0x23E29E0 VA: 0x1823E43E0
	internal static int MaxValue(int a, int b, int c) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
internal struct GlyphMarshallingStruct // TypeDefIndex: 13699
{
	// Fields
	public uint index; // 0x0
	public GlyphMetrics metrics; // 0x4
	public GlyphRect glyphRect; // 0x18
	public float scale; // 0x28
	public int atlasIndex; // 0x2C
	public GlyphClassDefinitionType classDefinitionType; // 0x30
}

// Namespace: UnityEngine.TextCore.LowLevel
[Flags]
public enum FontFeatureLookupFlags // TypeDefIndex: 13700
{
	// Fields
	public int value__; // 0x0
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 13701
{
	// Fields
	[SerializeField]
	[NativeName("xPlacement")]
	private float m_XPlacement; // 0x0
	[NativeName("yPlacement")]
	[SerializeField]
	private float m_YPlacement; // 0x4
	[SerializeField]
	[NativeName("xAdvance")]
	private float m_XAdvance; // 0x8
	[SerializeField]
	[NativeName("yAdvance")]
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_xPlacement() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_xPlacement(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_yPlacement() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_yPlacement(float value) { }

	// RVA: 0x22FFFF0 Offset: 0x22FE5F0 VA: 0x1822FFFF0
	public float get_xAdvance() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_xAdvance(float value) { }

	// RVA: 0x22E91B0 Offset: 0x22E77B0 VA: 0x1822E91B0
	public float get_yAdvance() { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x2317390 Offset: 0x2315990 VA: 0x182317390
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x23E9690 Offset: 0x23E7C90 VA: 0x1823E9690 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23E95B0 Offset: 0x23E7BB0 VA: 0x1823E95B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E9610 Offset: 0x23E7C10 VA: 0x1823E9610 Slot: 4
	public bool Equals(GlyphValueRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord> // TypeDefIndex: 13702
{
	// Fields
	[SerializeField]
	[NativeName("glyphIndex")]
	private uint m_GlyphIndex; // 0x0
	[SerializeField]
	[NativeName("glyphValueRecord")]
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public uint get_glyphIndex() { }

	// RVA: 0x23E9010 Offset: 0x23E7610 VA: 0x1823E9010
	public GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x11057E0 Offset: 0x1103DE0 VA: 0x1811057E0
	public void .ctor(uint glyphIndex, GlyphValueRecord glyphValueRecord) { }

	[ExcludeFromDocs]
	// RVA: 0x23E8FB0 Offset: 0x23E75B0 VA: 0x1823E8FB0 Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x23E8F40 Offset: 0x23E7540 VA: 0x1823E8F40 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x23E8EB0 Offset: 0x23E74B0 VA: 0x1823E8EB0 Slot: 4
	public bool Equals(GlyphAdjustmentRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
[UsedByNativeCode]
[Serializable]
public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord> // TypeDefIndex: 13703
{
	// Fields
	[SerializeField]
	[NativeName("firstAdjustmentRecord")]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeName("secondAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
	[SerializeField]
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }
	public FontFeatureLookupFlags featureLookupFlags { get; }

	// Methods

	// RVA: 0x23E93A0 Offset: 0x23E79A0 VA: 0x1823E93A0
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x23E93D0 Offset: 0x23E79D0 VA: 0x1823E93D0
	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

	// RVA: 0x23E93B0 Offset: 0x23E79B0 VA: 0x1823E93B0
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0xA3D1A0 Offset: 0xA3B7A0 VA: 0x180A3D1A0
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x23E9370 Offset: 0x23E7970 VA: 0x1823E9370
	public void .ctor(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[ExcludeFromDocs]
	// RVA: 0x23E9300 Offset: 0x23E7900 VA: 0x1823E9300 Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x23E91C0 Offset: 0x23E77C0 VA: 0x1823E91C0 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x23E9240 Offset: 0x23E7840 VA: 0x1823E9240 Slot: 4
	public bool Equals(GlyphPairAdjustmentRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct GlyphAnchorPoint // TypeDefIndex: 13704
{
	// Fields
	[SerializeField]
	[NativeName("xPositionAdjustment")]
	private float m_XCoordinate; // 0x0
	[NativeName("yPositionAdjustment")]
	[SerializeField]
	private float m_YCoordinate; // 0x4

	// Properties
	public float xCoordinate { get; set; }
	public float yCoordinate { get; set; }

	// Methods

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_xCoordinate() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_xCoordinate(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_yCoordinate() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_yCoordinate(float value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct MarkPositionAdjustment // TypeDefIndex: 13705
{
	// Fields
	[NativeName("xCoordinate")]
	[SerializeField]
	private float m_XPositionAdjustment; // 0x0
	[SerializeField]
	[NativeName("yCoordinate")]
	private float m_YPositionAdjustment; // 0x4

	// Properties
	public float xPositionAdjustment { get; set; }
	public float yPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_xPositionAdjustment() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_xPositionAdjustment(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_yPositionAdjustment() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_yPositionAdjustment(float value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct MarkToBaseAdjustmentRecord // TypeDefIndex: 13706
{
	// Fields
	[SerializeField]
	[NativeName("baseGlyphID")]
	private uint m_BaseGlyphID; // 0x0
	[SerializeField]
	[NativeName("baseAnchor")]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x4
	[SerializeField]
	[NativeName("markGlyphID")]
	private uint m_MarkGlyphID; // 0xC
	[SerializeField]
	[NativeName("markPositionAdjustment")]
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x10

	// Properties
	public uint baseGlyphID { get; set; }
	public GlyphAnchorPoint baseGlyphAnchorPoint { get; set; }
	public uint markGlyphID { get; set; }
	public MarkPositionAdjustment markPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public uint get_baseGlyphID() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_baseGlyphID(uint value) { }

	// RVA: 0x3A4A80 Offset: 0x3A3080 VA: 0x1803A4A80
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x3A4C40 Offset: 0x3A3240 VA: 0x1803A4C40
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x12A6840 Offset: 0x12A4E40 VA: 0x1812A6840
	public uint get_markGlyphID() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_markGlyphID(uint value) { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct MarkToMarkAdjustmentRecord // TypeDefIndex: 13707
{
	// Fields
	[SerializeField]
	[NativeName("baseMarkGlyphID")]
	private uint m_BaseMarkGlyphID; // 0x0
	[SerializeField]
	[NativeName("baseMarkAnchor")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x4
	[SerializeField]
	[NativeName("combiningMarkGlyphID")]
	private uint m_CombiningMarkGlyphID; // 0xC
	[NativeName("combiningMarkPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x10

	// Properties
	public uint baseMarkGlyphID { get; set; }
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; set; }
	public uint combiningMarkGlyphID { get; set; }
	public MarkPositionAdjustment combiningMarkPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public uint get_baseMarkGlyphID() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_baseMarkGlyphID(uint value) { }

	// RVA: 0x3A4A80 Offset: 0x3A3080 VA: 0x1803A4A80
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x3A4C40 Offset: 0x3A3240 VA: 0x1803A4C40
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x12A6840 Offset: 0x12A4E40 VA: 0x1812A6840
	public uint get_combiningMarkGlyphID() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_combiningMarkGlyphID(uint value) { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct MultipleSubstitutionRecord // TypeDefIndex: 13708
{
	// Fields
	[NativeName("targetGlyphID")]
	[SerializeField]
	private uint m_TargetGlyphID; // 0x0
	[SerializeField]
	[NativeName("substituteGlyphIDs")]
	private uint[] m_SubstituteGlyphIDs; // 0x8
}

// Namespace: UnityEngine.TextCore.LowLevel
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule", "UnityEditor.TextCoreTextEngineModule" })]
[UsedByNativeCode]
[Serializable]
internal struct LigatureSubstitutionRecord : IEquatable<LigatureSubstitutionRecord> // TypeDefIndex: 13709
{
	// Fields
	[SerializeField]
	[NativeName("componentGlyphs")]
	private uint[] m_ComponentGlyphIDs; // 0x0
	[NativeName("ligatureGlyph")]
	[SerializeField]
	private uint m_LigatureGlyphID; // 0x8

	// Properties
	public uint[] componentGlyphIDs { get; set; }
	public uint ligatureGlyphID { get; set; }

	// Methods

	// RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	public uint[] get_componentGlyphIDs() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void set_componentGlyphIDs(uint[] value) { }

	// RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	public uint get_ligatureGlyphID() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_ligatureGlyphID(uint value) { }

	// RVA: 0x23E9800 Offset: 0x23E7E00 VA: 0x1823E9800 Slot: 4
	public bool Equals(LigatureSubstitutionRecord other) { }

	// RVA: 0x23E98D0 Offset: 0x23E7ED0 VA: 0x1823E98D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E9970 Offset: 0x23E7F70 VA: 0x1823E9970 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23E99A0 Offset: 0x23E7FA0 VA: 0x1823E99A0
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }
}

