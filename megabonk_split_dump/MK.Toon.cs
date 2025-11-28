// Namespace: MK.Toon
public enum Workflow // TypeDefIndex: 13761
{
	// Fields
	public int value__; // 0x0
	public const Workflow Metallic = 0;
	public const Workflow Specular = 1;
	public const Workflow Roughness = 2;
}

// Namespace: MK.Toon
public enum Surface // TypeDefIndex: 13762
{
	// Fields
	public int value__; // 0x0
	public const Surface Opaque = 0;
	public const Surface Transparent = 1;
}

// Namespace: MK.Toon
internal enum SurfaceRefraction // TypeDefIndex: 13763
{
	// Fields
	public int value__; // 0x0
	public const SurfaceRefraction Transparent = 1;
}

// Namespace: MK.Toon
internal enum SurfaceOutline // TypeDefIndex: 13764
{
	// Fields
	public int value__; // 0x0
	public const SurfaceOutline Opaque = 0;
}

// Namespace: MK.Toon
public enum RenderFace // TypeDefIndex: 13765
{
	// Fields
	public int value__; // 0x0
	public const RenderFace DoubleSided = 0;
	public const RenderFace Back = 1;
	public const RenderFace Front = 2;
}

// Namespace: MK.Toon
public enum DetailBlend // TypeDefIndex: 13766
{
	// Fields
	public int value__; // 0x0
	public const DetailBlend Mix = 0;
	public const DetailBlend Add = 1;
	public const DetailBlend Multiply = 2;
}

// Namespace: MK.Toon
public enum Light // TypeDefIndex: 13767
{
	// Fields
	public int value__; // 0x0
	public const Light Builtin = 0;
	public const Light Cel = 1;
	public const Light Banded = 2;
	public const Light Ramp = 3;
}

// Namespace: MK.Toon
public enum ZWrite // TypeDefIndex: 13768
{
	// Fields
	public int value__; // 0x0
	public const ZWrite Off = 0;
	public const ZWrite On = 1;
}

// Namespace: MK.Toon
public enum Iridescence // TypeDefIndex: 13769
{
	// Fields
	public int value__; // 0x0
	public const Iridescence Off = 0;
	public const Iridescence On = 1;
}

// Namespace: MK.Toon
public enum Rim // TypeDefIndex: 13770
{
	// Fields
	public int value__; // 0x0
	public const Rim Off = 0;
	public const Rim Default = 1;
	public const Rim Split = 2;
}

// Namespace: MK.Toon
public enum ColorGrading // TypeDefIndex: 13771
{
	// Fields
	public int value__; // 0x0
	public const ColorGrading Off = 0;
	public const ColorGrading Albedo = 1;
	public const ColorGrading FinalOutput = 2;
}

// Namespace: MK.Toon
public enum VertexAnimation // TypeDefIndex: 13772
{
	// Fields
	public int value__; // 0x0
	public const VertexAnimation Off = 0;
	public const VertexAnimation Sine = 1;
	public const VertexAnimation Pulse = 2;
	public const VertexAnimation Noise = 3;
}

// Namespace: MK.Toon
public enum Dissolve // TypeDefIndex: 13773
{
	// Fields
	public int value__; // 0x0
	public const Dissolve Off = 0;
	public const Dissolve Default = 1;
	public const Dissolve BorderColor = 2;
	public const Dissolve BorderRamp = 3;
}

// Namespace: MK.Toon
public enum LightTransmission // TypeDefIndex: 13774
{
	// Fields
	public int value__; // 0x0
	public const LightTransmission Off = 0;
	public const LightTransmission Translucent = 1;
	public const LightTransmission SubSurfaceScattering = 2;
}

// Namespace: MK.Toon
public enum Diffuse // TypeDefIndex: 13775
{
	// Fields
	public int value__; // 0x0
	public const Diffuse Lambert = 0;
	public const Diffuse OrenNayar = 1;
	public const Diffuse Minnaert = 2;
}

// Namespace: MK.Toon
public enum Specular // TypeDefIndex: 13776
{
	// Fields
	public int value__; // 0x0
	public const Specular Off = 0;
	public const Specular Isotropic = 1;
	public const Specular Anisotropic = 2;
}

// Namespace: MK.Toon
internal enum SpecularSimple // TypeDefIndex: 13777
{
	// Fields
	public int value__; // 0x0
	public const SpecularSimple Off = 0;
	public const SpecularSimple Isotropic = 1;
}

// Namespace: MK.Toon
public enum Artistic // TypeDefIndex: 13778
{
	// Fields
	public int value__; // 0x0
	public const Artistic Off = 0;
	public const Artistic Drawn = 1;
	public const Artistic Hatching = 2;
	public const Artistic Sketch = 3;
}

// Namespace: MK.Toon
public enum ArtisticProjection // TypeDefIndex: 13779
{
	// Fields
	public int value__; // 0x0
	public const ArtisticProjection TangentSpace = 0;
	public const ArtisticProjection ScreenSpace = 1;
}

// Namespace: MK.Toon
public enum EnvironmentReflection // TypeDefIndex: 13780
{
	// Fields
	public int value__; // 0x0
	public const EnvironmentReflection Off = 0;
	public const EnvironmentReflection Ambient = 1;
	public const EnvironmentReflection Advanced = 2;
}

// Namespace: MK.Toon
internal enum EnvironmentReflectionSimple // TypeDefIndex: 13781
{
	// Fields
	public int value__; // 0x0
	public const EnvironmentReflectionSimple Off = 0;
	public const EnvironmentReflectionSimple Ambient = 1;
}

// Namespace: MK.Toon
public enum Outline // TypeDefIndex: 13782
{
	// Fields
	public int value__; // 0x0
	public const Outline HullObject = 1;
	public const Outline HullOrigin = 2;
	public const Outline HullClip = 3;
}

// Namespace: MK.Toon
public enum OutlineData // TypeDefIndex: 13783
{
	// Fields
	public int value__; // 0x0
	public const OutlineData Normal = 0;
	public const OutlineData Baked = 1;
}

// Namespace: MK.Toon
public enum Stencil // TypeDefIndex: 13784
{
	// Fields
	public int value__; // 0x0
	public const Stencil Builtin = 1;
	public const Stencil Custom = 2;
}

// Namespace: MK.Toon
public enum BlendFactor // TypeDefIndex: 13785
{
	// Fields
	public int value__; // 0x0
	public const BlendFactor Zero = 0;
	public const BlendFactor One = 1;
	public const BlendFactor DstColor = 2;
	public const BlendFactor SrcColor = 3;
	public const BlendFactor OneMinusDstColor = 4;
	public const BlendFactor SrcAlpha = 5;
	public const BlendFactor OneMinusSrcColor = 6;
	public const BlendFactor DstAlpha = 7;
	public const BlendFactor OneMinusDstAlpha = 8;
	public const BlendFactor SrcAlphaSaturate = 9;
	public const BlendFactor OneMinusSrcAlpha = 10;
}

// Namespace: MK.Toon
public enum Blend // TypeDefIndex: 13786
{
	// Fields
	public int value__; // 0x0
	public const Blend Alpha = 0;
	public const Blend Premultiply = 1;
	public const Blend Additive = 2;
	public const Blend Multiply = 3;
	public const Blend Custom = 4;
}

// Namespace: MK.Toon
internal enum BlendOpaque // TypeDefIndex: 13787
{
	// Fields
	public int value__; // 0x0
	public const BlendOpaque Default = 0;
	public const BlendOpaque Custom = 4;
}

// Namespace: MK.Toon
public enum BlendOperation // TypeDefIndex: 13788
{
	// Fields
	public int value__; // 0x0
	public const BlendOperation Add = 0;
	public const BlendOperation Subtract = 1;
	public const BlendOperation ReverseSubtract = 2;
	public const BlendOperation Min = 3;
	public const BlendOperation Max = 4;
	public const BlendOperation LogicalClear = 5;
	public const BlendOperation LogicalSet = 6;
	public const BlendOperation LogicalCopy = 7;
	public const BlendOperation LogicalCopyInverted = 8;
	public const BlendOperation LogicalNoop = 9;
	public const BlendOperation LogicalInvert = 10;
	public const BlendOperation LogicalAnd = 11;
	public const BlendOperation LogicalNand = 12;
	public const BlendOperation LogicalOr = 13;
	public const BlendOperation LogicalNor = 14;
	public const BlendOperation LogicalXor = 15;
	public const BlendOperation LogicalEquivalence = 16;
	public const BlendOperation LogicalAndReverse = 17;
	public const BlendOperation LogicalAndInverted = 18;
	public const BlendOperation LogicalOrReverse = 19;
	public const BlendOperation LogicalOrInverted = 20;
	public const BlendOperation Multiply = 21;
	public const BlendOperation Screen = 22;
	public const BlendOperation Overlay = 23;
	public const BlendOperation Darken = 24;
	public const BlendOperation Lighten = 25;
	public const BlendOperation ColorDodge = 26;
	public const BlendOperation ColorBurn = 27;
	public const BlendOperation HardLight = 28;
	public const BlendOperation SoftLight = 29;
	public const BlendOperation Difference = 30;
	public const BlendOperation Exclusion = 31;
	public const BlendOperation HSLHue = 32;
	public const BlendOperation HSLSaturation = 33;
	public const BlendOperation HSLColor = 34;
	public const BlendOperation HSLLuminosity = 35;
}

// Namespace: MK.Toon
public enum ColorBlend // TypeDefIndex: 13789
{
	// Fields
	public int value__; // 0x0
	public const ColorBlend Multiply = 0;
	public const ColorBlend Additive = 1;
	public const ColorBlend Subtractive = 2;
	public const ColorBlend Overlay = 3;
	public const ColorBlend Color = 4;
	public const ColorBlend Difference = 5;
}

// Namespace: MK.Toon
public enum RenderQueue // TypeDefIndex: 13790
{
	// Fields
	public int value__; // 0x0
	public const RenderQueue Background = 1000;
	public const RenderQueue Geometry = 2000;
	public const RenderQueue AlphaTest = 2450;
	public const RenderQueue GeometryLast = 2500;
	public const RenderQueue Transparent = 3000;
	public const RenderQueue Overlay = 4000;
}

// Namespace: MK.Toon
public enum ZTest // TypeDefIndex: 13791
{
	// Fields
	public int value__; // 0x0
	public const ZTest Always = 8;
	public const ZTest Equal = 3;
	public const ZTest GreaterEqual = 7;
	public const ZTest Greater = 5;
	public const ZTest LessEqual = 4;
	public const ZTest Less = 2;
	public const ZTest NotEqual = 6;
}

// Namespace: MK.Toon
public enum StencilOperation // TypeDefIndex: 13792
{
	// Fields
	public int value__; // 0x0
	public const StencilOperation Keep = 0;
	public const StencilOperation Zero = 1;
	public const StencilOperation Replace = 2;
	public const StencilOperation IncrementSaturate = 3;
	public const StencilOperation DecrementSaturate = 4;
	public const StencilOperation Invert = 5;
	public const StencilOperation IncrementWrap = 6;
	public const StencilOperation DecrementWrap = 7;
	public const StencilOperation Always = 8;
}

// Namespace: MK.Toon
public enum StencilComparison // TypeDefIndex: 13793
{
	// Fields
	public int value__; // 0x0
	public const StencilComparison Disabled = 0;
	public const StencilComparison Never = 1;
	public const StencilComparison Less = 2;
	public const StencilComparison Equal = 3;
	public const StencilComparison LessEqual = 4;
	public const StencilComparison Greater = 5;
	public const StencilComparison NotEqual = 6;
	public const StencilComparison GreaterEqual = 7;
	public const StencilComparison Always = 8;
}

// Namespace: MK.Toon
public static class Keywords // TypeDefIndex: 13794
{
	// Fields
	public static readonly string albedoMap; // 0x0
	public static readonly string alphaClipping; // 0x8
	public static readonly string[] surface; // 0x10
	public static readonly string[] lightTransmission; // 0x18
	public static readonly string thicknessMap; // 0x20
	public static readonly string normalMap; // 0x28
	public static readonly string heightMap; // 0x30
	public static readonly string parallax; // 0x38
	public static readonly string occlusionMap; // 0x40
	public static readonly string[] blend; // 0x48
	public static readonly string[] light; // 0x50
	public static readonly string[] artistic; // 0x58
	public static readonly string[] artisticProjection; // 0x60
	public static readonly string artisticAnimation; // 0x68
	public static readonly string[] workflow; // 0x70
	public static readonly string emission; // 0x78
	public static readonly string emissionMap; // 0x80
	public static readonly string detailMap; // 0x88
	public static readonly string[] detailBlend; // 0x90
	public static readonly string detailNormalMap; // 0x98
	public static readonly string[] rim; // 0xA0
	public static readonly string[] iridescence; // 0xA8
	public static readonly string[] colorGrading; // 0xB0
	public static readonly string[] dissolve; // 0xB8
	public static readonly string goochRamp; // 0xC0
	public static readonly string goochBrightMap; // 0xC8
	public static readonly string goochDarkMap; // 0xD0
	public static readonly string[] diffuse; // 0xD8
	public static readonly string[] specular; // 0xE0
	public static readonly string[] environmentReflections; // 0xE8
	public static readonly string fresnelHighlights; // 0xF0
	public static readonly string[] outline; // 0xF8
	public static readonly string outlineData; // 0x100
	public static readonly string outlineMap; // 0x108
	public static readonly string refractionDistortionMap; // 0x110
	public static readonly string indexOfRefraction; // 0x118
	public static readonly string outlineNoise; // 0x120
	public static readonly string receiveShadows; // 0x128
	public static readonly string wrappedLighting; // 0x130
	public static readonly string[] colorBlend; // 0x138
	public static readonly string flipbook; // 0x140
	public static readonly string softFade; // 0x148
	public static readonly string cameraFade; // 0x150
	public static readonly string thresholdMap; // 0x158
	public static readonly string pbsMap0; // 0x160
	public static readonly string pbsMap1; // 0x168
	public static readonly string[] vertexAnimation; // 0x170
	public static readonly string vertexAnimationMap; // 0x178
	public static readonly string vertexAnimationStutter; // 0x180

	// Methods

	// RVA: 0x12F9C60 Offset: 0x12F8260 VA: 0x1812F9C60
	private static void .cctor() { }
}

// Namespace: MK.Toon
public static class Properties // TypeDefIndex: 13795
{
	// Fields
	internal static readonly string shaderComponentOutlineName; // 0x0
	internal static readonly string shaderComponentRefractionName; // 0x8
	internal static readonly string shaderVariantPBSName; // 0x10
	internal static readonly string shaderVariantSimpleName; // 0x18
	internal static readonly string shaderVariantUnlitName; // 0x20
	public static readonly EnumProperty<Workflow> workflow; // 0x28
	public static readonly EnumProperty<RenderFace> renderFace; // 0x30
	public static readonly SurfaceProperty surface; // 0x38
	public static readonly EnumProperty<ZWrite> zWrite; // 0x40
	public static readonly EnumProperty<ZTest> zTest; // 0x48
	public static readonly EnumProperty<BlendFactor> blendSrc; // 0x50
	public static readonly EnumProperty<BlendFactor> blendDst; // 0x58
	public static readonly BlendProperty blend; // 0x60
	public static readonly AlphaClippingProperty alphaClipping; // 0x68
	public static readonly ColorProperty albedoColor; // 0x70
	public static readonly RangeProperty alphaCutoff; // 0x78
	public static readonly TextureProperty albedoMap; // 0x80
	public static readonly TilingProperty mainTiling; // 0x88
	public static readonly OffsetProperty mainOffset; // 0x90
	public static readonly ColorProperty specularColor; // 0x98
	public static readonly RangeProperty metallic; // 0xA0
	public static readonly RangeProperty smoothness; // 0xA8
	public static readonly RangeProperty roughness; // 0xB0
	public static readonly TextureProperty specularMap; // 0xB8
	public static readonly TextureProperty roughnessMap; // 0xC0
	public static readonly TextureProperty metallicMap; // 0xC8
	public static readonly FloatProperty normalMapIntensity; // 0xD0
	public static readonly TextureProperty normalMap; // 0xD8
	public static readonly RangeProperty parallax; // 0xE0
	public static readonly TextureProperty heightMap; // 0xE8
	public static readonly EnumProperty<LightTransmission> lightTransmission; // 0xF0
	public static readonly RangeProperty lightTransmissionDistortion; // 0xF8
	public static readonly ColorProperty lightTransmissionColor; // 0x100
	public static readonly TextureProperty thicknessMap; // 0x108
	public static readonly RangeProperty occlusionMapIntensity; // 0x110
	public static readonly TextureProperty occlusionMap; // 0x118
	public static readonly ColorProperty emissionColor; // 0x120
	public static readonly TextureProperty emissionMap; // 0x128
	public static readonly EnumProperty<DetailBlend> detailBlend; // 0x130
	public static readonly ColorProperty detailColor; // 0x138
	public static readonly RangeProperty detailMix; // 0x140
	public static readonly TextureProperty detailMap; // 0x148
	public static readonly TilingProperty detailTiling; // 0x150
	public static readonly OffsetProperty detailOffset; // 0x158
	public static readonly FloatProperty detailNormalMapIntensity; // 0x160
	public static readonly TextureProperty detailNormalMap; // 0x168
	public static readonly BoolProperty receiveShadows; // 0x170
	public static readonly BoolProperty wrappedLighting; // 0x178
	public static readonly RangeProperty diffuseSmoothness; // 0x180
	public static readonly RangeProperty diffuseThresholdOffset; // 0x188
	public static readonly RangeProperty specularSmoothness; // 0x190
	public static readonly RangeProperty specularThresholdOffset; // 0x198
	public static readonly RangeProperty rimSmoothness; // 0x1A0
	public static readonly RangeProperty rimThresholdOffset; // 0x1A8
	public static readonly RangeProperty lightTransmissionSmoothness; // 0x1B0
	public static readonly RangeProperty lightTransmissionThresholdOffset; // 0x1B8
	public static readonly EnumProperty<Light> light; // 0x1C0
	public static readonly TextureProperty diffuseRamp; // 0x1C8
	public static readonly TextureProperty specularRamp; // 0x1D0
	public static readonly TextureProperty rimRamp; // 0x1D8
	public static readonly TextureProperty lightTransmissionRamp; // 0x1E0
	public static readonly StepProperty lightBands; // 0x1E8
	public static readonly RangeProperty lightBandsScale; // 0x1F0
	public static readonly RangeProperty lightThreshold; // 0x1F8
	public static readonly TextureProperty thresholdMap; // 0x200
	public static readonly FloatProperty thresholdMapScale; // 0x208
	public static readonly RangeProperty goochRampIntensity; // 0x210
	public static readonly TextureProperty goochRamp; // 0x218
	public static readonly ColorProperty goochBrightColor; // 0x220
	public static readonly TextureProperty goochBrightMap; // 0x228
	public static readonly ColorProperty goochDarkColor; // 0x230
	public static readonly TextureProperty goochDarkMap; // 0x238
	public static readonly EnumProperty<ColorGrading> colorGrading; // 0x240
	public static readonly FloatProperty contrast; // 0x248
	public static readonly RangeProperty saturation; // 0x250
	public static readonly RangeProperty brightness; // 0x258
	public static readonly EnumProperty<Iridescence> iridescence; // 0x260
	public static readonly TextureProperty iridescenceRamp; // 0x268
	public static readonly RangeProperty iridescenceSize; // 0x270
	public static readonly RangeProperty iridescenceThresholdOffset; // 0x278
	public static readonly RangeProperty iridescenceSmoothness; // 0x280
	public static readonly ColorProperty iridescenceColor; // 0x288
	public static readonly EnumProperty<Rim> rim; // 0x290
	public static readonly ColorProperty rimColor; // 0x298
	public static readonly ColorProperty rimBrightColor; // 0x2A0
	public static readonly ColorProperty rimDarkColor; // 0x2A8
	public static readonly RangeProperty rimSize; // 0x2B0
	public static readonly EnumProperty<VertexAnimation> vertexAnimation; // 0x2B8
	public static readonly BoolProperty vertexAnimationStutter; // 0x2C0
	public static readonly TextureProperty vertexAnimationMap; // 0x2C8
	public static readonly RangeProperty vertexAnimationIntensity; // 0x2D0
	public static readonly Vector3Property vertexAnimationFrequency; // 0x2D8
	public static readonly EnumProperty<Dissolve> dissolve; // 0x2E0
	public static readonly TextureProperty dissolveMap; // 0x2E8
	public static readonly FloatProperty dissolveMapScale; // 0x2F0
	public static readonly RangeProperty dissolveAmount; // 0x2F8
	public static readonly RangeProperty dissolveBorderSize; // 0x300
	public static readonly TextureProperty dissolveBorderRamp; // 0x308
	public static readonly ColorProperty dissolveBorderColor; // 0x310
	public static readonly EnumProperty<Artistic> artistic; // 0x318
	public static readonly EnumProperty<ArtisticProjection> artisticProjection; // 0x320
	public static readonly RangeProperty artisticFrequency; // 0x328
	public static readonly FloatProperty drawnMapScale; // 0x330
	public static readonly TextureProperty drawnMap; // 0x338
	public static readonly FloatProperty hatchingMapScale; // 0x340
	public static readonly TextureProperty hatchingBrightMap; // 0x348
	public static readonly TextureProperty hatchingDarkMap; // 0x350
	public static readonly RangeProperty drawnClampMin; // 0x358
	public static readonly RangeProperty drawnClampMax; // 0x360
	public static readonly FloatProperty sketchMapScale; // 0x368
	public static readonly TextureProperty sketchMap; // 0x370
	public static readonly EnumProperty<Diffuse> diffuse; // 0x378
	public static readonly SpecularProperty specular; // 0x380
	public static readonly RangeProperty specularIntensity; // 0x388
	public static readonly RangeProperty anisotropy; // 0x390
	public static readonly RangeProperty lightTransmissionIntensity; // 0x398
	public static readonly EnvironmentReflectionProperty environmentReflections; // 0x3A0
	public static readonly BoolProperty fresnelHighlights; // 0x3A8
	public static readonly BoolProperty indirectFade; // 0x3B0
	public static readonly RenderPriorityProperty renderPriority; // 0x3B8
	public static readonly StencilModeProperty stencil; // 0x3C0
	public static readonly StepProperty stencilRef; // 0x3C8
	public static readonly StepProperty stencilReadMask; // 0x3D0
	public static readonly StepProperty stencilWriteMask; // 0x3D8
	public static readonly EnumProperty<StencilComparison> stencilComp; // 0x3E0
	public static readonly EnumProperty<StencilOperation> stencilPass; // 0x3E8
	public static readonly EnumProperty<StencilOperation> stencilFail; // 0x3F0
	public static readonly EnumProperty<StencilOperation> stencilZFail; // 0x3F8
	public static readonly EnumProperty<Outline> outline; // 0x400
	public static readonly EnumProperty<OutlineData> outlineData; // 0x408
	public static readonly TextureProperty outlineMap; // 0x410
	public static readonly RangeProperty outlineSize; // 0x418
	public static readonly ColorProperty outlineColor; // 0x420
	public static readonly RangeProperty outlineNoise; // 0x428
	public static readonly FloatProperty refractionDistortionMapScale; // 0x430
	public static readonly TextureProperty refractionDistortionMap; // 0x438
	public static readonly FloatProperty refractionDistortion; // 0x440
	public static readonly RangeProperty refractionDistortionFade; // 0x448
	public static readonly RangeProperty indexOfRefraction; // 0x450
	public static readonly BoolProperty flipbook; // 0x458
	public static readonly BoolProperty softFade; // 0x460
	public static readonly FloatProperty softFadeNearDistance; // 0x468
	public static readonly FloatProperty softFadeFarDistance; // 0x470
	public static readonly BoolProperty cameraFade; // 0x478
	public static readonly FloatProperty cameraFadeNearDistance; // 0x480
	public static readonly FloatProperty cameraFadeFarDistance; // 0x488
	public static readonly EnumProperty<ColorBlend> colorBlend; // 0x490

	// Methods

	// RVA: 0x12FB590 Offset: 0x12F9B90 VA: 0x1812FB590
	public static void UpdateSystemProperties(Material material) { }

	// RVA: 0x12FB740 Offset: 0x12F9D40 VA: 0x1812FB740
	private static void .cctor() { }
}

// Namespace: MK.Toon
public abstract class Property<T> // TypeDefIndex: 13796
{
	// Fields
	protected string[] _keywords; // 0x0
	protected Uniform _uniform; // 0x0

	// Properties
	public Uniform uniform { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Uniform get_uniform() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-Property<bool>.get_uniform
	|-Property<Color>.get_uniform
	|-Property<int>.get_uniform
	|-Property<Int32Enum>.get_uniform
	|-Property<object>.get_uniform
	|-Property<float>.get_uniform
	|-Property<Vector2>.get_uniform
	|-Property<Vector3>.get_uniform
	|-Property<Vector4>.get_uniform
	|-Property<__Il2CppFullySharedGenericType>.get_uniform
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Uniform uniform, string[] keywords) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B6980 Offset: 0x8B4F80 VA: 0x1808B6980
	|-Property<bool>..ctor
	|-Property<Color>..ctor
	|-Property<int>..ctor
	|-Property<Int32Enum>..ctor
	|-Property<object>..ctor
	|-Property<float>..ctor
	|-Property<Vector2>..ctor
	|-Property<Vector3>..ctor
	|-Property<Vector4>..ctor
	|-Property<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T GetValue(Material material);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetValue(Material material, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	protected void SetKeyword(Material material, bool b, int keywordIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B6780 Offset: 0x8B4D80 VA: 0x1808B6780
	|-Property<bool>.SetKeyword
	|-Property<Color>.SetKeyword
	|-Property<int>.SetKeyword
	|-Property<Int32Enum>.SetKeyword
	|-Property<object>.SetKeyword
	|-Property<float>.SetKeyword
	|-Property<Vector2>.SetKeyword
	|-Property<Vector3>.SetKeyword
	|-Property<Vector4>.SetKeyword
	|
	|-RVA: 0x8B68C0 Offset: 0x8B4EC0 VA: 0x1808B68C0
	|-Property<__Il2CppFullySharedGenericType>.SetKeyword
	*/

	// RVA: -1 Offset: -1
	private void CleanKeywords(Material material) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B6700 Offset: 0x8B4D00 VA: 0x1808B6700
	|-Property<bool>.CleanKeywords
	|-Property<Color>.CleanKeywords
	|-Property<int>.CleanKeywords
	|-Property<Int32Enum>.CleanKeywords
	|-Property<object>.CleanKeywords
	|-Property<float>.CleanKeywords
	|-Property<Vector2>.CleanKeywords
	|-Property<Vector3>.CleanKeywords
	|-Property<Vector4>.CleanKeywords
	|-Property<__Il2CppFullySharedGenericType>.CleanKeywords
	*/
}

// Namespace: MK.Toon
public abstract class Property<T, U> : Property<T> // TypeDefIndex: 13797
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Uniform uniform, string[] keywords) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B6980 Offset: 0x8B4F80 VA: 0x1808B6980
	|-Property<int, bool>..ctor
	|-Property<Int32Enum, bool>..ctor
	|
	|-RVA: 0x8C3B10 Offset: 0x8C2110 VA: 0x1808C3B10
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetValue(Material material, T valueM, U valueS);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValue
	*/
}

// Namespace: MK.Toon
public class BoolProperty : Property<bool> // TypeDefIndex: 13798
{
	// Methods

	// RVA: 0x12F94B0 Offset: 0x12F7AB0 VA: 0x1812F94B0
	public void .ctor(Uniform uniform, string keyword) { }

	// RVA: 0x12F9440 Offset: 0x12F7A40 VA: 0x1812F9440
	public void .ctor(Uniform uniform) { }

	// RVA: 0x12F8D10 Offset: 0x12F7310 VA: 0x1812F8D10 Slot: 4
	public override bool GetValue(Material material) { }

	// RVA: 0x12F93B0 Offset: 0x12F79B0 VA: 0x1812F93B0 Slot: 5
	public override void SetValue(Material material, bool value) { }
}

// Namespace: MK.Toon
public class IntProperty : Property<int> // TypeDefIndex: 13799
{
	// Fields
	private int _keywordDisabled; // 0x20

	// Methods

	// RVA: 0x12F9B40 Offset: 0x12F8140 VA: 0x1812F9B40
	public void .ctor(Uniform uniform, string keyword, int keywordDisabled = 0) { }

	// RVA: 0x12F9BF0 Offset: 0x12F81F0 VA: 0x1812F9BF0
	public void .ctor(Uniform uniform) { }

	// RVA: 0x12F9710 Offset: 0x12F7D10 VA: 0x1812F9710 Slot: 4
	public override int GetValue(Material material) { }

	// RVA: 0x12F9AB0 Offset: 0x12F80B0 VA: 0x1812F9AB0 Slot: 5
	public override void SetValue(Material material, int value) { }
}

// Namespace: MK.Toon
public class StepProperty : Property<int> // TypeDefIndex: 13800
{
	// Fields
	private int _keywordDisabled; // 0x20
	private int _minValue; // 0x24
	private int _maxValue; // 0x28

	// Methods

	// RVA: 0x1301340 Offset: 0x12FF940 VA: 0x181301340
	public void .ctor(Uniform uniform, int minValue, int maxValue, string keyword, int keywordDisabled = 0) { }

	// RVA: 0x1301410 Offset: 0x12FFA10 VA: 0x181301410
	public void .ctor(Uniform uniform, int minValue, int maxValue) { }

	// RVA: 0x12F9710 Offset: 0x12F7D10 VA: 0x1812F9710 Slot: 4
	public override int GetValue(Material material) { }

	// RVA: 0x13012A0 Offset: 0x12FF8A0 VA: 0x1813012A0 Slot: 5
	public override void SetValue(Material material, int value) { }
}

// Namespace: MK.Toon
public class FloatProperty : Property<float> // TypeDefIndex: 13801
{
	// Fields
	private float _keywordDisabled; // 0x20

	// Methods

	// RVA: 0x12F9980 Offset: 0x12F7F80 VA: 0x1812F9980
	public void .ctor(Uniform uniform, string keyword, float keywordDisabled = 0) { }

	// RVA: 0x12F9A40 Offset: 0x12F8040 VA: 0x1812F9A40
	public void .ctor(Uniform uniform) { }

	// RVA: 0x12F98B0 Offset: 0x12F7EB0 VA: 0x1812F98B0 Slot: 4
	public override float GetValue(Material material) { }

	// RVA: 0x12F98E0 Offset: 0x12F7EE0 VA: 0x1812F98E0 Slot: 5
	public override void SetValue(Material material, float value) { }
}

// Namespace: MK.Toon
public class RangeProperty : Property<float> // TypeDefIndex: 13802
{
	// Fields
	private float _keywordDisabled; // 0x20
	private float _minValue; // 0x24
	private float _maxValue; // 0x28

	// Methods

	// RVA: 0x1300A70 Offset: 0x12FF070 VA: 0x181300A70
	public void .ctor(Uniform uniform, string keyword, float minValue, float maxValue, float keywordDisabled = 0) { }

	// RVA: 0x13009A0 Offset: 0x12FEFA0 VA: 0x1813009A0
	public void .ctor(Uniform uniform, string keyword, float minValue, float keywordDisabled = 0) { }

	// RVA: 0x1300B50 Offset: 0x12FF150 VA: 0x181300B50
	public void .ctor(Uniform uniform, float minValue, float maxValue) { }

	// RVA: 0x1300BE0 Offset: 0x12FF1E0 VA: 0x181300BE0
	public void .ctor(Uniform uniform, float minValue) { }

	// RVA: 0x12F98B0 Offset: 0x12F7EB0 VA: 0x1812F98B0 Slot: 4
	public override float GetValue(Material material) { }

	// RVA: 0x13008E0 Offset: 0x12FEEE0 VA: 0x1813008E0 Slot: 5
	public override void SetValue(Material material, float value) { }
}

// Namespace: MK.Toon
public class Vector2Property : Property<Vector2> // TypeDefIndex: 13803
{
	// Methods

	// RVA: 0x13066C0 Offset: 0x1304CC0 VA: 0x1813066C0
	public void .ctor(Uniform uniform) { }

	// RVA: 0x1306610 Offset: 0x1304C10 VA: 0x181306610 Slot: 4
	public override Vector2 GetValue(Material material) { }

	// RVA: 0x1306650 Offset: 0x1304C50 VA: 0x181306650 Slot: 5
	public override void SetValue(Material material, Vector2 value) { }
}

// Namespace: MK.Toon
public class Vector3Property : Property<Vector3> // TypeDefIndex: 13804
{
	// Methods

	// RVA: 0x1306800 Offset: 0x1304E00 VA: 0x181306800
	public void .ctor(Uniform uniform) { }

	// RVA: 0x1306730 Offset: 0x1304D30 VA: 0x181306730 Slot: 4
	public override Vector3 GetValue(Material material) { }

	// RVA: 0x1306790 Offset: 0x1304D90 VA: 0x181306790 Slot: 5
	public override void SetValue(Material material, Vector3 value) { }
}

// Namespace: MK.Toon
public class Vector4Property : Property<Vector4> // TypeDefIndex: 13805
{
	// Methods

	// RVA: 0x1306900 Offset: 0x1304F00 VA: 0x181306900
	public void .ctor(Uniform uniform) { }

	// RVA: 0x1306870 Offset: 0x1304E70 VA: 0x181306870 Slot: 4
	public override Vector4 GetValue(Material material) { }

	// RVA: 0x13068C0 Offset: 0x1304EC0 VA: 0x1813068C0 Slot: 5
	public override void SetValue(Material material, Vector4 value) { }
}

// Namespace: MK.Toon
public class ColorProperty : Property<Color> // TypeDefIndex: 13806
{
	// Methods

	// RVA: 0x12F9660 Offset: 0x12F7C60 VA: 0x1812F9660
	public void .ctor(Uniform uniform, string keyword) { }

	// RVA: 0x12F95F0 Offset: 0x12F7BF0 VA: 0x1812F95F0
	public void .ctor(Uniform uniform) { }

	// RVA: 0x12F9560 Offset: 0x12F7B60 VA: 0x1812F9560 Slot: 4
	public override Color GetValue(Material material) { }

	// RVA: 0x12F95B0 Offset: 0x12F7BB0 VA: 0x1812F95B0 Slot: 5
	public override void SetValue(Material material, Color color) { }
}

// Namespace: MK.Toon
public class TextureProperty : Property<Texture> // TypeDefIndex: 13807
{
	// Methods

	// RVA: 0x1301B90 Offset: 0x1300190 VA: 0x181301B90
	public void .ctor(Uniform uniform, string keyword) { }

	// RVA: 0x1301B20 Offset: 0x1300120 VA: 0x181301B20
	public void .ctor(Uniform uniform) { }

	// RVA: 0x1301A30 Offset: 0x1300030 VA: 0x181301A30 Slot: 4
	public override Texture GetValue(Material material) { }

	// RVA: 0x1301A60 Offset: 0x1300060 VA: 0x181301A60 Slot: 5
	public override void SetValue(Material material, Texture texture) { }
}

// Namespace: MK.Toon
public class EnumProperty<T> : Property<T> // TypeDefIndex: 13808
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Uniform uniform, string[] keywords) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE93390 Offset: 0xE91990 VA: 0x180E93390
	|-EnumProperty<Int32Enum>..ctor
	|
	|-RVA: 0x8C3B10 Offset: 0x8C2110 VA: 0x1808C3B10
	|-EnumProperty<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T GetValue(Material material) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE92E80 Offset: 0xE91480 VA: 0x180E92E80
	|-EnumProperty<Int32Enum>.GetValue
	|
	|-RVA: 0xE92F20 Offset: 0xE91520 VA: 0x180E92F20
	|-EnumProperty<__Il2CppFullySharedGenericStructType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void SetValue(Material material, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE93000 Offset: 0xE91600 VA: 0x180E93000
	|-EnumProperty<Int32Enum>.SetValue
	|
	|-RVA: 0xE93170 Offset: 0xE91770 VA: 0x180E93170
	|-EnumProperty<__Il2CppFullySharedGenericStructType>.SetValue
	*/
}

// Namespace: MK.Toon
public class AlphaClippingProperty : Property<bool> // TypeDefIndex: 13809
{
	// Methods

	// RVA: 0x12F8EB0 Offset: 0x12F74B0 VA: 0x1812F8EB0
	public void .ctor(Uniform uniform, string keyword) { }

	// RVA: 0x12F8D10 Offset: 0x12F7310 VA: 0x1812F8D10 Slot: 4
	public override bool GetValue(Material material) { }

	// RVA: 0x12F8D50 Offset: 0x12F7350 VA: 0x1812F8D50 Slot: 5
	public override void SetValue(Material material, bool value) { }
}

// Namespace: MK.Toon
public class TilingProperty : Property<Vector2> // TypeDefIndex: 13810
{
	// Methods

	// RVA: 0x1301D10 Offset: 0x1300310 VA: 0x181301D10
	public void .ctor(Uniform uniform) { }

	// RVA: 0x1301C40 Offset: 0x1300240 VA: 0x181301C40 Slot: 4
	public override Vector2 GetValue(Material material) { }

	// RVA: 0x1301CA0 Offset: 0x13002A0 VA: 0x181301CA0 Slot: 5
	public override void SetValue(Material material, Vector2 value) { }
}

// Namespace: MK.Toon
public class OffsetProperty : Property<Vector2> // TypeDefIndex: 13811
{
	// Methods

	// RVA: 0x12FB520 Offset: 0x12F9B20 VA: 0x1812FB520
	public void .ctor(Uniform uniform) { }

	// RVA: 0x12FB450 Offset: 0x12F9A50 VA: 0x1812FB450 Slot: 4
	public override Vector2 GetValue(Material material) { }

	// RVA: 0x12FB4B0 Offset: 0x12F9AB0 VA: 0x1812FB4B0 Slot: 5
	public override void SetValue(Material material, Vector2 value) { }
}

// Namespace: MK.Toon
public class SpecularProperty : Property<Specular> // TypeDefIndex: 13812
{
	// Methods

	// RVA: 0x1300FD0 Offset: 0x12FF5D0 VA: 0x181300FD0
	public void .ctor(Uniform uniform, string[] keywords) { }

	// RVA: 0x12F9710 Offset: 0x12F7D10 VA: 0x1812F9710 Slot: 4
	public override Specular GetValue(Material material) { }

	// RVA: 0x1300EC0 Offset: 0x12FF4C0 VA: 0x181300EC0 Slot: 5
	public override void SetValue(Material material, Specular specular) { }
}

// Namespace: MK.Toon
public class EnvironmentReflectionProperty : Property<EnvironmentReflection> // TypeDefIndex: 13813
{
	// Methods

	// RVA: 0x12F9850 Offset: 0x12F7E50 VA: 0x1812F9850
	public void .ctor(Uniform uniform, string[] keywords) { }

	// RVA: 0x12F9710 Offset: 0x12F7D10 VA: 0x1812F9710 Slot: 4
	public override EnvironmentReflection GetValue(Material material) { }

	// RVA: 0x12F9740 Offset: 0x12F7D40 VA: 0x1812F9740 Slot: 5
	public override void SetValue(Material material, EnvironmentReflection environmentReflection) { }
}

// Namespace: MK.Toon
public class StencilModeProperty : Property<Stencil> // TypeDefIndex: 13814
{
	// Methods

	// RVA: 0x1301230 Offset: 0x12FF830 VA: 0x181301230
	public void .ctor(Uniform uniform) { }

	// RVA: 0x12F9710 Offset: 0x12F7D10 VA: 0x1812F9710 Slot: 4
	public override Stencil GetValue(Material material) { }

	// RVA: 0x1301030 Offset: 0x12FF630 VA: 0x181301030 Slot: 5
	public override void SetValue(Material material, Stencil stencil) { }
}

// Namespace: MK.Toon
public class RenderPriorityProperty : Property<int, bool> // TypeDefIndex: 13815
{
	// Methods

	// RVA: 0x1300E50 Offset: 0x12FF450 VA: 0x181300E50
	public void .ctor(Uniform uniform) { }

	// RVA: 0x1300C60 Offset: 0x12FF260 VA: 0x181300C60 Slot: 4
	public override int GetValue(Material material) { }

	// RVA: 0x1300CC0 Offset: 0x12FF2C0 VA: 0x181300CC0 Slot: 5
	public override void SetValue(Material material, int priority) { }

	// RVA: 0x1300CF0 Offset: 0x12FF2F0 VA: 0x181300CF0 Slot: 6
	public override void SetValue(Material material, int priority, bool alphaClipping) { }
}

// Namespace: MK.Toon
public class SurfaceProperty : Property<Surface, bool> // TypeDefIndex: 13816
{
	// Methods

	// RVA: 0x13019D0 Offset: 0x12FFFD0 VA: 0x1813019D0
	public void .ctor(Uniform uniform, string[] keywords) { }

	// RVA: 0x13014A0 Offset: 0x12FFAA0 VA: 0x1813014A0 Slot: 4
	public override Surface GetValue(Material material) { }

	// RVA: 0x1300CC0 Offset: 0x12FF2C0 VA: 0x181300CC0 Slot: 5
	public override void SetValue(Material material, Surface surface) { }

	// RVA: 0x1301500 Offset: 0x12FFB00 VA: 0x181301500 Slot: 6
	public override void SetValue(Material material, Surface surface, bool alphaClipping) { }
}

// Namespace: MK.Toon
public class BlendProperty : Property<Blend> // TypeDefIndex: 13817
{
	// Methods

	// RVA: 0x12F9350 Offset: 0x12F7950 VA: 0x1812F9350
	public void .ctor(Uniform uniform, string[] keywords) { }

	// RVA: 0x12F8F60 Offset: 0x12F7560 VA: 0x1812F8F60 Slot: 4
	public override Blend GetValue(Material material) { }

	// RVA: 0x12F8FC0 Offset: 0x12F75C0 VA: 0x1812F8FC0 Slot: 5
	public override void SetValue(Material material, Blend blend) { }
}

// Namespace: MK.Toon
public class Uniform // TypeDefIndex: 13818
{
	// Fields
	protected string _name; // 0x10
	protected int _id; // 0x18

	// Properties
	public string name { get; }
	public int id { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_id() { }

	// RVA: 0x1301D80 Offset: 0x1300380 VA: 0x181301D80
	public void .ctor(string name) { }
}

// Namespace: MK.Toon
public static class Uniforms // TypeDefIndex: 13819
{
	// Fields
	public static readonly Uniform workflow; // 0x0
	public static readonly Uniform renderFace; // 0x8
	public static readonly Uniform surface; // 0x10
	public static readonly Uniform zWrite; // 0x18
	public static readonly Uniform zTest; // 0x20
	public static readonly Uniform blendSrc; // 0x28
	public static readonly Uniform blendDst; // 0x30
	public static readonly Uniform blend; // 0x38
	public static readonly Uniform alphaClipping; // 0x40
	public static readonly Uniform albedoColor; // 0x48
	public static readonly Uniform alphaCutoff; // 0x50
	public static readonly Uniform albedoMap; // 0x58
	public static readonly Uniform specularColor; // 0x60
	public static readonly Uniform metallic; // 0x68
	public static readonly Uniform smoothness; // 0x70
	public static readonly Uniform roughness; // 0x78
	public static readonly Uniform specularMap; // 0x80
	public static readonly Uniform roughnessMap; // 0x88
	public static readonly Uniform metallicMap; // 0x90
	public static readonly Uniform normalMapIntensity; // 0x98
	public static readonly Uniform normalMap; // 0xA0
	public static readonly Uniform parallax; // 0xA8
	public static readonly Uniform heightMap; // 0xB0
	public static readonly Uniform lightTransmission; // 0xB8
	public static readonly Uniform lightTransmissionDistortion; // 0xC0
	public static readonly Uniform lightTransmissionColor; // 0xC8
	public static readonly Uniform thicknessMap; // 0xD0
	public static readonly Uniform occlusionMapIntensity; // 0xD8
	public static readonly Uniform occlusionMap; // 0xE0
	public static readonly Uniform emissionColor; // 0xE8
	public static readonly Uniform emissionMap; // 0xF0
	public static readonly Uniform detailBlend; // 0xF8
	public static readonly Uniform detailColor; // 0x100
	public static readonly Uniform detailMix; // 0x108
	public static readonly Uniform detailMap; // 0x110
	public static readonly Uniform detailNormalMapIntensity; // 0x118
	public static readonly Uniform detailNormalMap; // 0x120
	public static readonly Uniform receiveShadows; // 0x128
	public static readonly Uniform wrappedLighting; // 0x130
	public static readonly Uniform diffuseSmoothness; // 0x138
	public static readonly Uniform diffuseThresholdOffset; // 0x140
	public static readonly Uniform specularSmoothness; // 0x148
	public static readonly Uniform specularThresholdOffset; // 0x150
	public static readonly Uniform rimSmoothness; // 0x158
	public static readonly Uniform rimThresholdOffset; // 0x160
	public static readonly Uniform lightTransmissionSmoothness; // 0x168
	public static readonly Uniform lightTransmissionThresholdOffset; // 0x170
	public static readonly Uniform light; // 0x178
	public static readonly Uniform diffuseRamp; // 0x180
	public static readonly Uniform specularRamp; // 0x188
	public static readonly Uniform rimRamp; // 0x190
	public static readonly Uniform lightTransmissionRamp; // 0x198
	public static readonly Uniform lightBands; // 0x1A0
	public static readonly Uniform lightBandsScale; // 0x1A8
	public static readonly Uniform lightThreshold; // 0x1B0
	public static readonly Uniform thresholdMap; // 0x1B8
	public static readonly Uniform thresholdMapScale; // 0x1C0
	public static readonly Uniform goochRampIntensity; // 0x1C8
	public static readonly Uniform goochRamp; // 0x1D0
	public static readonly Uniform goochBrightColor; // 0x1D8
	public static readonly Uniform goochBrightMap; // 0x1E0
	public static readonly Uniform goochDarkColor; // 0x1E8
	public static readonly Uniform goochDarkMap; // 0x1F0
	public static readonly Uniform colorGrading; // 0x1F8
	public static readonly Uniform contrast; // 0x200
	public static readonly Uniform saturation; // 0x208
	public static readonly Uniform brightness; // 0x210
	public static readonly Uniform iridescence; // 0x218
	public static readonly Uniform iridescenceRamp; // 0x220
	public static readonly Uniform iridescenceSize; // 0x228
	public static readonly Uniform iridescenceThresholdOffset; // 0x230
	public static readonly Uniform iridescenceSmoothness; // 0x238
	public static readonly Uniform iridescenceColor; // 0x240
	public static readonly Uniform rim; // 0x248
	public static readonly Uniform rimColor; // 0x250
	public static readonly Uniform rimBrightColor; // 0x258
	public static readonly Uniform rimDarkColor; // 0x260
	public static readonly Uniform rimSize; // 0x268
	public static readonly Uniform vertexAnimation; // 0x270
	public static readonly Uniform vertexAnimationStutter; // 0x278
	public static readonly Uniform vertexAnimationMap; // 0x280
	public static readonly Uniform vertexAnimationIntensity; // 0x288
	public static readonly Uniform vertexAnimationFrequency; // 0x290
	public static readonly Uniform dissolve; // 0x298
	public static readonly Uniform dissolveMap; // 0x2A0
	public static readonly Uniform dissolveMapScale; // 0x2A8
	public static readonly Uniform dissolveAmount; // 0x2B0
	public static readonly Uniform dissolveBorderSize; // 0x2B8
	public static readonly Uniform dissolveBorderRamp; // 0x2C0
	public static readonly Uniform dissolveBorderColor; // 0x2C8
	public static readonly Uniform artistic; // 0x2D0
	public static readonly Uniform artisticProjection; // 0x2D8
	public static readonly Uniform artisticFrequency; // 0x2E0
	public static readonly Uniform drawnMapScale; // 0x2E8
	public static readonly Uniform drawnMap; // 0x2F0
	public static readonly Uniform hatchingMapScale; // 0x2F8
	public static readonly Uniform hatchingBrightMap; // 0x300
	public static readonly Uniform hatchingDarkMap; // 0x308
	public static readonly Uniform drawnClampMin; // 0x310
	public static readonly Uniform drawnClampMax; // 0x318
	public static readonly Uniform sketchMapScale; // 0x320
	public static readonly Uniform sketchMap; // 0x328
	public static readonly Uniform diffuse; // 0x330
	public static readonly Uniform specular; // 0x338
	public static readonly Uniform specularIntensity; // 0x340
	public static readonly Uniform anisotropy; // 0x348
	public static readonly Uniform lightTransmissionIntensity; // 0x350
	public static readonly Uniform environmentReflections; // 0x358
	public static readonly Uniform fresnelHighlights; // 0x360
	public static readonly Uniform IndirectFade; // 0x368
	public static readonly Uniform stencil; // 0x370
	public static readonly Uniform renderPriority; // 0x378
	public static readonly Uniform stencilRef; // 0x380
	public static readonly Uniform stencilReadMask; // 0x388
	public static readonly Uniform stencilWriteMask; // 0x390
	public static readonly Uniform stencilComp; // 0x398
	public static readonly Uniform stencilPass; // 0x3A0
	public static readonly Uniform stencilFail; // 0x3A8
	public static readonly Uniform stencilZFail; // 0x3B0
	public static readonly Uniform outline; // 0x3B8
	public static readonly Uniform outlineData; // 0x3C0
	public static readonly Uniform outlineMap; // 0x3C8
	public static readonly Uniform outlineSize; // 0x3D0
	public static readonly Uniform outlineColor; // 0x3D8
	public static readonly Uniform outlineNoise; // 0x3E0
	public static readonly Uniform refractionDistortionMapScale; // 0x3E8
	public static readonly Uniform refractionDistortionMap; // 0x3F0
	public static readonly Uniform refractionDistortion; // 0x3F8
	public static readonly Uniform indexOfRefraction; // 0x400
	public static readonly Uniform refractionDistortionFade; // 0x408
	public static readonly Uniform flipbook; // 0x410
	public static readonly Uniform softFade; // 0x418
	public static readonly Uniform softFadeNearDistance; // 0x420
	public static readonly Uniform softFadeFarDistance; // 0x428
	public static readonly Uniform cameraFade; // 0x430
	public static readonly Uniform cameraFadeNearDistance; // 0x438
	public static readonly Uniform cameraFadeFarDistance; // 0x440
	public static readonly Uniform colorBlend; // 0x448
	public static readonly Uniform initialized; // 0x450
	public static readonly Uniform optionsTab; // 0x458
	public static readonly Uniform inputTab; // 0x460
	public static readonly Uniform stylizeTab; // 0x468
	public static readonly Uniform advancedTab; // 0x470
	public static readonly Uniform particlesTab; // 0x478
	public static readonly Uniform outlineTab; // 0x480
	public static readonly Uniform refractionTab; // 0x488
	public static readonly Uniform mainTex; // 0x490
	public static readonly Uniform cutoff; // 0x498
	public static readonly Uniform color; // 0x4A0

	// Methods

	// RVA: 0x1301DC0 Offset: 0x13003C0 VA: 0x181301DC0
	private static void .cctor() { }
}

