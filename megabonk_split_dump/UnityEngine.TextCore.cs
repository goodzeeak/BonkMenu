// Namespace: UnityEngine.TextCore
public enum OTL_FeatureTag // TypeDefIndex: 11352
{
	// Fields
	public uint value__; // 0x0
	public const OTL_FeatureTag kern = 1801810542;
	public const OTL_FeatureTag liga = 1818847073;
	public const OTL_FeatureTag mark = 1835102827;
	public const OTL_FeatureTag mkmk = 1835756907;
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct FaceInfo // TypeDefIndex: 13687
{
	// Fields
	[SerializeField]
	[NativeName("faceIndex")]
	private int m_FaceIndex; // 0x0
	[SerializeField]
	[NativeName("familyName")]
	private string m_FamilyName; // 0x8
	[SerializeField]
	[NativeName("styleName")]
	private string m_StyleName; // 0x10
	[SerializeField]
	[NativeName("pointSize")]
	private int m_PointSize; // 0x18
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; // 0x1C
	[NativeName("unitsPerEM")]
	[SerializeField]
	private int m_UnitsPerEM; // 0x20
	[NativeName("lineHeight")]
	[SerializeField]
	private float m_LineHeight; // 0x24
	[SerializeField]
	[NativeName("ascentLine")]
	private float m_AscentLine; // 0x28
	[NativeName("capLine")]
	[SerializeField]
	private float m_CapLine; // 0x2C
	[NativeName("meanLine")]
	[SerializeField]
	private float m_MeanLine; // 0x30
	[NativeName("baseline")]
	[SerializeField]
	private float m_Baseline; // 0x34
	[NativeName("descentLine")]
	[SerializeField]
	private float m_DescentLine; // 0x38
	[SerializeField]
	[NativeName("superscriptOffset")]
	private float m_SuperscriptOffset; // 0x3C
	[NativeName("superscriptSize")]
	[SerializeField]
	private float m_SuperscriptSize; // 0x40
	[SerializeField]
	[NativeName("subscriptOffset")]
	private float m_SubscriptOffset; // 0x44
	[NativeName("subscriptSize")]
	[SerializeField]
	private float m_SubscriptSize; // 0x48
	[NativeName("underlineOffset")]
	[SerializeField]
	private float m_UnderlineOffset; // 0x4C
	[SerializeField]
	[NativeName("underlineThickness")]
	private float m_UnderlineThickness; // 0x50
	[NativeName("strikethroughOffset")]
	[SerializeField]
	private float m_StrikethroughOffset; // 0x54
	[SerializeField]
	[NativeName("strikethroughThickness")]
	private float m_StrikethroughThickness; // 0x58
	[SerializeField]
	[NativeName("tabWidth")]
	private float m_TabWidth; // 0x5C

	// Properties
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	internal int faceIndex { get; }
	public string familyName { get; }
	public string styleName { get; }
	public int pointSize { get; }
	public float scale { get; set; }
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	internal int unitsPerEM { get; set; }
	public float lineHeight { get; }
	public float ascentLine { get; }
	public float capLine { get; set; }
	public float meanLine { get; set; }
	public float baseline { get; }
	public float descentLine { get; }
	public float superscriptOffset { get; }
	public float superscriptSize { get; }
	public float subscriptOffset { get; }
	public float subscriptSize { get; }
	public float underlineOffset { get; }
	public float underlineThickness { get; }
	public float strikethroughOffset { get; set; }
	public float tabWidth { get; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	internal int get_faceIndex() { }

	// RVA: 0x1573780 Offset: 0x1571D80 VA: 0x181573780
	public string get_familyName() { }

	// RVA: 0x101AB70 Offset: 0x1019170 VA: 0x18101AB70
	public string get_styleName() { }

	// RVA: 0xA3D180 Offset: 0xA3B780 VA: 0x180A3D180
	public int get_pointSize() { }

	// RVA: 0x23A8F40 Offset: 0x23A7540 VA: 0x1823A8F40
	public float get_scale() { }

	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450
	public void set_scale(float value) { }

	// RVA: 0xA3D120 Offset: 0xA3B720 VA: 0x180A3D120
	internal int get_unitsPerEM() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	internal void set_unitsPerEM(int value) { }

	// RVA: 0x234CC70 Offset: 0x234B270 VA: 0x18234CC70
	public float get_lineHeight() { }

	// RVA: 0x23E4370 Offset: 0x23E2970 VA: 0x1823E4370
	public float get_ascentLine() { }

	// RVA: 0x23A8F70 Offset: 0x23A7570 VA: 0x1823A8F70
	public float get_capLine() { }

	// RVA: 0x1853730 Offset: 0x1851D30 VA: 0x181853730
	public void set_capLine(float value) { }

	// RVA: 0x23A8F50 Offset: 0x23A7550 VA: 0x1823A8F50
	public float get_meanLine() { }

	// RVA: 0x36F720 Offset: 0x36DD20 VA: 0x18036F720
	public void set_meanLine(float value) { }

	// RVA: 0x23A8F80 Offset: 0x23A7580 VA: 0x1823A8F80
	public float get_baseline() { }

	// RVA: 0x2173FE0 Offset: 0x21725E0 VA: 0x182173FE0
	public float get_descentLine() { }

	// RVA: 0x2173E70 Offset: 0x2172470 VA: 0x182173E70
	public float get_superscriptOffset() { }

	// RVA: 0x23A8F30 Offset: 0x23A7530 VA: 0x1823A8F30
	public float get_superscriptSize() { }

	// RVA: 0x23E4390 Offset: 0x23E2990 VA: 0x1823E4390
	public float get_subscriptOffset() { }

	// RVA: 0x23E43A0 Offset: 0x23E29A0 VA: 0x1823E43A0
	public float get_subscriptSize() { }

	// RVA: 0x23E43C0 Offset: 0x23E29C0 VA: 0x1823E43C0
	public float get_underlineOffset() { }

	// RVA: 0x23E43D0 Offset: 0x23E29D0 VA: 0x1823E43D0
	public float get_underlineThickness() { }

	// RVA: 0x23E4380 Offset: 0x23E2980 VA: 0x1823E4380
	public float get_strikethroughOffset() { }

	// RVA: 0x474440 Offset: 0x472A40 VA: 0x180474440
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x23E43B0 Offset: 0x23E29B0 VA: 0x1823E43B0
	public float get_tabWidth() { }
}

// Namespace: UnityEngine.TextCore
public enum GlyphClassDefinitionType // TypeDefIndex: 13688
{
	// Fields
	public int value__; // 0x0
	public const GlyphClassDefinitionType Undefined = 0;
	public const GlyphClassDefinitionType Base = 1;
	public const GlyphClassDefinitionType Ligature = 2;
	public const GlyphClassDefinitionType Mark = 3;
	public const GlyphClassDefinitionType Component = 4;
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 13689
{
	// Fields
	[SerializeField]
	[NativeName("x")]
	private int m_X; // 0x0
	[NativeName("y")]
	[SerializeField]
	private int m_Y; // 0x4
	[SerializeField]
	[NativeName("width")]
	private int m_Width; // 0x8
	[NativeName("height")]
	[SerializeField]
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public int get_x() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_x(int value) { }

	// RVA: 0x9BF260 Offset: 0x9BD860 VA: 0x1809BF260
	public int get_y() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_y(int value) { }

	// RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	public int get_width() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_width(int value) { }

	// RVA: 0x12A6840 Offset: 0x12A4E40 VA: 0x1812A6840
	public int get_height() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_height(int value) { }

	// RVA: 0x23E9550 Offset: 0x23E7B50 VA: 0x1823E9550
	public static GlyphRect get_zero() { }

	// RVA: 0x16AE250 Offset: 0x16AC850 VA: 0x1816AE250
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x23E94C0 Offset: 0x23E7AC0 VA: 0x1823E94C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23E9460 Offset: 0x23E7A60 VA: 0x1823E9460 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E93E0 Offset: 0x23E79E0 VA: 0x1823E93E0 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x23E9510 Offset: 0x23E7B10 VA: 0x1823E9510
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 13690
{
	// Fields
	[SerializeField]
	[NativeName("width")]
	private float m_Width; // 0x0
	[SerializeField]
	[NativeName("height")]
	private float m_Height; // 0x4
	[SerializeField]
	[NativeName("horizontalBearingX")]
	private float m_HorizontalBearingX; // 0x8
	[NativeName("horizontalBearingY")]
	[SerializeField]
	private float m_HorizontalBearingY; // 0xC
	[NativeName("horizontalAdvance")]
	[SerializeField]
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; set; }
	public float height { get; set; }
	public float horizontalBearingX { get; set; }
	public float horizontalBearingY { get; set; }
	public float horizontalAdvance { get; set; }

	// Methods

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_width() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_width(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_height() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_height(float value) { }

	// RVA: 0x22FFFF0 Offset: 0x22FE5F0 VA: 0x1822FFFF0
	public float get_horizontalBearingX() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_horizontalBearingX(float value) { }

	// RVA: 0x22E91B0 Offset: 0x22E77B0 VA: 0x1822E91B0
	public float get_horizontalBearingY() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_horizontalBearingY(float value) { }

	// RVA: 0x23E91B0 Offset: 0x23E77B0 VA: 0x1823E91B0
	public float get_horizontalAdvance() { }

	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	public void set_horizontalAdvance(float value) { }

	// RVA: 0x23E9180 Offset: 0x23E7780 VA: 0x1823E9180
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x23E9120 Offset: 0x23E7720 VA: 0x1823E9120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23E90B0 Offset: 0x23E76B0 VA: 0x1823E90B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E9020 Offset: 0x23E7620 VA: 0x1823E9020 Slot: 4
	public bool Equals(GlyphMetrics other) { }
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public class Glyph // TypeDefIndex: 13691
{
	// Fields
	[SerializeField]
	[NativeName("index")]
	private uint m_Index; // 0x10
	[NativeName("metrics")]
	[SerializeField]
	private GlyphMetrics m_Metrics; // 0x14
	[SerializeField]
	[NativeName("glyphRect")]
	private GlyphRect m_GlyphRect; // 0x28
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; // 0x38
	[NativeName("atlasIndex")]
	[SerializeField]
	private int m_AtlasIndex; // 0x3C
	[NativeName("type")]
	[SerializeField]
	private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x2333510 Offset: 0x2331B10 VA: 0x182333510
	public uint get_index() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_index(uint value) { }

	// RVA: 0x23E93B0 Offset: 0x23E79B0 VA: 0x1823E93B0
	public GlyphMetrics get_metrics() { }

	// RVA: 0x23E97F0 Offset: 0x23E7DF0 VA: 0x1823E97F0
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x23AB180 Offset: 0x23A9780 VA: 0x1823AB180
	public GlyphRect get_glyphRect() { }

	// RVA: 0x14DAB40 Offset: 0x14D9140 VA: 0x1814DAB40
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x2173FE0 Offset: 0x21725E0 VA: 0x182173FE0
	public float get_scale() { }

	// RVA: 0x559130 Offset: 0x557730 VA: 0x180559130
	public void set_scale(float value) { }

	// RVA: 0x23E97E0 Offset: 0x23E7DE0 VA: 0x1823E97E0
	public int get_atlasIndex() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_atlasIndex(int value) { }

	// RVA: 0x23E97A0 Offset: 0x23E7DA0 VA: 0x1823E97A0
	public void .ctor() { }

	// RVA: 0x23E96E0 Offset: 0x23E7CE0 VA: 0x1823E96E0
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x23E9730 Offset: 0x23E7D30 VA: 0x1823E9730
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }
}

