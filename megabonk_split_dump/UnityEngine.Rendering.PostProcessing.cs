// Namespace: UnityEngine.Rendering.PostProcessing
[Usage(256, AllowMultiple = False)]
public sealed class DisplayNameAttribute : Attribute // TypeDefIndex: 12372
{
	// Fields
	public readonly string displayName; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string displayName) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Usage(256, AllowMultiple = False)]
public sealed class MaxAttribute : Attribute // TypeDefIndex: 12373
{
	// Fields
	public readonly float max; // 0x10

	// Methods

	// RVA: 0x2034290 Offset: 0x2032890 VA: 0x182034290
	public void .ctor(float max) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Usage(256, AllowMultiple = False)]
public sealed class MinAttribute : Attribute // TypeDefIndex: 12374
{
	// Fields
	public readonly float min; // 0x10

	// Methods

	// RVA: 0x2034290 Offset: 0x2032890 VA: 0x182034290
	public void .ctor(float min) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Usage(256, AllowMultiple = False)]
public sealed class MinMaxAttribute : Attribute // TypeDefIndex: 12375
{
	// Fields
	public readonly float min; // 0x10
	public readonly float max; // 0x14

	// Methods

	// RVA: 0x20342C0 Offset: 0x20328C0 VA: 0x1820342C0
	public void .ctor(float min, float max) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Usage(4, AllowMultiple = False)]
public sealed class PostProcessAttribute : Attribute // TypeDefIndex: 12376
{
	// Fields
	public readonly Type renderer; // 0x10
	public readonly PostProcessEvent eventType; // 0x18
	public readonly string menuItem; // 0x20
	public readonly bool allowInSceneView; // 0x28
	internal readonly bool builtinEffect; // 0x29

	// Methods

	// RVA: 0x2039740 Offset: 0x2037D40 VA: 0x182039740
	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	// RVA: 0x20396D0 Offset: 0x2037CD0 VA: 0x1820396D0
	internal void .ctor(Type renderer, string menuItem, bool allowInSceneView = True) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Usage(256, AllowMultiple = False)]
public sealed class TrackballAttribute : Attribute // TypeDefIndex: 12378
{
	// Fields
	public readonly TrackballAttribute.Mode mode; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(TrackballAttribute.Mode mode) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum AmbientOcclusionMode // TypeDefIndex: 12379
{
	// Fields
	public int value__; // 0x0
	public const AmbientOcclusionMode ScalableAmbientObscurance = 0;
	public const AmbientOcclusionMode MultiScaleVolumetricObscurance = 1;
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum AmbientOcclusionQuality // TypeDefIndex: 12380
{
	// Fields
	public int value__; // 0x0
	public const AmbientOcclusionQuality Lowest = 0;
	public const AmbientOcclusionQuality Low = 1;
	public const AmbientOcclusionQuality Medium = 2;
	public const AmbientOcclusionQuality High = 3;
	public const AmbientOcclusionQuality Ultra = 4;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode> // TypeDefIndex: 12381
{
	// Methods

	// RVA: 0x2029390 Offset: 0x2027990 VA: 0x182029390
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality> // TypeDefIndex: 12382
{
	// Methods

	// RVA: 0x20293D0 Offset: 0x20279D0 VA: 0x1820293D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(AmbientOcclusionRenderer), "Unity/Ambient Occlusion", True)]
[Serializable]
public sealed class AmbientOcclusion : PostProcessEffectSettings // TypeDefIndex: 12383
{
	// Fields
	[Tooltip("The ambient occlusion method to use. "Multi Scale Volumetric Obscurance" is higher quality and faster on desktop & console platforms but requires compute shader support.")]
	public AmbientOcclusionModeParameter mode; // 0x30
	[Range(0, 4)]
	[Tooltip("The degree of darkness added by ambient occlusion. Higher values produce darker areas.")]
	public FloatParameter intensity; // 0x38
	[ColorUsage(False)]
	[Tooltip("The custom color to use for the ambient occlusion. The default is black.")]
	public ColorParameter color; // 0x40
	[Tooltip("Check this box to mark this Volume as to only affect ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering. Objects rendered with the Forward rendering path won't get any ambient occlusion.")]
	public BoolParameter ambientOnly; // 0x48
	[Range(-8, 0)]
	public FloatParameter noiseFilterTolerance; // 0x50
	[Range(-8, -1)]
	public FloatParameter blurTolerance; // 0x58
	[Range(-12, -1)]
	public FloatParameter upsampleTolerance; // 0x60
	[Range(1, 10)]
	[Tooltip("This modifies the thickness of occluders. It increases the size of dark areas and also introduces a dark halo around objects.")]
	public FloatParameter thicknessModifier; // 0x68
	[Range(0, 0.001)]
	[Tooltip("Add a bias distance to sampled depth in AO to reduce self-shadowing aliasing artifacts. ")]
	public FloatParameter zBias; // 0x70
	[Range(0, 1)]
	[Tooltip("Modifies the influence of direct lighting on ambient occlusion.")]
	public FloatParameter directLightingStrength; // 0x78
	[Tooltip("The radius of sample points. This affects the size of darkened areas.")]
	public FloatParameter radius; // 0x80
	[Tooltip("The number of sample points. This affects both quality and performance. For "Lowest", "Low", and "Medium", passes are downsampled. For "High" and "Ultra", they are not and therefore you should only "High" and "Ultra" on high-end hardware.")]
	public AmbientOcclusionQualityParameter quality; // 0x88

	// Methods

	// RVA: 0x2029AE0 Offset: 0x20280E0 VA: 0x182029AE0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2029E60 Offset: 0x2028460 VA: 0x182029E60
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
internal interface IAmbientOcclusionMethod // TypeDefIndex: 12384
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DepthTextureMode GetCameraFlags();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RenderAfterOpaque(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RenderAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CompositeAmbientOnly(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release();
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 12385
{
	// Fields
	private IAmbientOcclusionMethod[] m_Methods; // 0x20

	// Methods

	// RVA: 0x2029660 Offset: 0x2027C60 VA: 0x182029660 Slot: 4
	public override void Init() { }

	// RVA: 0x20298F0 Offset: 0x2027EF0 VA: 0x1820298F0
	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x2029600 Offset: 0x2027C00 VA: 0x182029600
	public IAmbientOcclusionMethod Get() { }

	// RVA: 0x2029410 Offset: 0x2027A10 VA: 0x182029410 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x2029980 Offset: 0x2027F80 VA: 0x182029980 Slot: 7
	public override void Release() { }

	// RVA: 0x2029590 Offset: 0x2027B90 VA: 0x182029590
	public ScalableAO GetScalableAO() { }

	// RVA: 0x2029520 Offset: 0x2027B20 VA: 0x182029520
	public MultiScaleVO GetMultiScaleVO() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2029AA0 Offset: 0x20280A0 VA: 0x182029AA0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum EyeAdaptation // TypeDefIndex: 12386
{
	// Fields
	public int value__; // 0x0
	public const EyeAdaptation Progressive = 0;
	public const EyeAdaptation Fixed = 1;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class EyeAdaptationParameter : ParameterOverride<EyeAdaptation> // TypeDefIndex: 12387
{
	// Methods

	// RVA: 0x2032DF0 Offset: 0x20313F0 VA: 0x182032DF0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(AutoExposureRenderer), "Unity/Auto Exposure", True)]
[Serializable]
public sealed class AutoExposure : PostProcessEffectSettings // TypeDefIndex: 12388
{
	// Fields
	[MinMax(1, 99)]
	[DisplayName("Filtering (%)")]
	[Tooltip("Filters the bright and dark parts of the histogram when computing the average luminance. This is to avoid very dark pixels and very bright pixels from contributing to the auto exposure. Unit is in percent.")]
	public Vector2Parameter filtering; // 0x30
	[Range(-9, 9)]
	[DisplayName("Minimum (EV)")]
	[Tooltip("Minimum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter minLuminance; // 0x38
	[Range(-9, 9)]
	[DisplayName("Maximum (EV)")]
	[Tooltip("Maximum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter maxLuminance; // 0x40
	[Min(0)]
	[DisplayName("Exposure Compensation")]
	[Tooltip("Use this to scale the global exposure of the scene.")]
	public FloatParameter keyValue; // 0x48
	[DisplayName("Type")]
	[Tooltip("Use "Progressive" if you want auto exposure to be animated. Use "Fixed" otherwise.")]
	public EyeAdaptationParameter eyeAdaptation; // 0x50
	[Min(0)]
	[Tooltip("Adaptation speed from a dark to a light environment.")]
	public FloatParameter speedUp; // 0x58
	[Min(0)]
	[Tooltip("Adaptation speed from a light to a dark environment.")]
	public FloatParameter speedDown; // 0x60

	// Methods

	// RVA: 0x202AEC0 Offset: 0x20294C0 VA: 0x18202AEC0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x202B030 Offset: 0x2029630 VA: 0x18202B030
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 12389
{
	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumAutoExposureTextures = 2;
	private readonly RenderTexture[][] m_AutoExposurePool; // 0x20
	private int[] m_AutoExposurePingPong; // 0x28
	private RenderTexture m_CurrentAutoExposure; // 0x30

	// Methods

	// RVA: 0x202AD50 Offset: 0x2029350 VA: 0x18202AD50
	public void .ctor() { }

	// RVA: 0x202A1D0 Offset: 0x20287D0 VA: 0x18202A1D0
	private void CheckTexture(int eye, int id) { }

	// RVA: 0x202A490 Offset: 0x2028A90 VA: 0x18202A490 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x202A3C0 Offset: 0x20289C0 VA: 0x18202A3C0 Slot: 7
	public override void Release() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(BloomRenderer), "Unity/Bloom", True)]
[Serializable]
public sealed class Bloom : PostProcessEffectSettings // TypeDefIndex: 12390
{
	// Fields
	[Min(0)]
	[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
	public FloatParameter intensity; // 0x30
	[Min(0)]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public FloatParameter threshold; // 0x38
	[Range(0, 1)]
	[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
	public FloatParameter softKnee; // 0x40
	[Tooltip("Clamps pixels to control the bloom amount. Value is in gamma-space.")]
	public FloatParameter clamp; // 0x48
	[Range(1, 10)]
	[Tooltip("Changes the extent of veiling effects. For maximum quality, use integer values. Because this value changes the internal iteration count, You should not animating it as it may introduce issues with the perceived radius.")]
	public FloatParameter diffusion; // 0x50
	[Range(-1, 1)]
	[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
	public FloatParameter anamorphicRatio; // 0x58
	[ColorUsage(False, True)]
	[Tooltip("Global tint of the bloom filter.")]
	public ColorParameter color; // 0x60
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performance by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; // 0x68
	[Tooltip("The lens dirt texture used to add smudges or dust to the bloom effect.")]
	[DisplayName("Texture")]
	public TextureParameter dirtTexture; // 0x70
	[Min(0)]
	[Tooltip("The intensity of the lens dirtiness.")]
	[DisplayName("Intensity")]
	public FloatParameter dirtIntensity; // 0x78

	// Methods

	// RVA: 0x202C370 Offset: 0x202A970 VA: 0x18202C370 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x202C3B0 Offset: 0x202A9B0 VA: 0x18202C3B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom> // TypeDefIndex: 12393
{
	// Fields
	private BloomRenderer.Level[] m_Pyramid; // 0x20
	private const int k_MaxPyramidSize = 16;

	// Methods

	// RVA: 0x202B240 Offset: 0x2029840 VA: 0x18202B240 Slot: 4
	public override void Init() { }

	// RVA: 0x202B360 Offset: 0x2029960 VA: 0x18202B360 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x202C330 Offset: 0x202A930 VA: 0x18202C330
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(ChromaticAberrationRenderer), "Unity/Chromatic Aberration", True)]
[Serializable]
public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 12394
{
	// Fields
	[Tooltip("Shifts the hue of chromatic aberrations.")]
	public TextureParameter spectralLut; // 0x30
	[Range(0, 1)]
	[Tooltip("Amount of tangential distortion.")]
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; // 0x40

	// Methods

	// RVA: 0x202CA50 Offset: 0x202B050 VA: 0x18202CA50 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x202CA90 Offset: 0x202B090 VA: 0x18202CA90
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration> // TypeDefIndex: 12395
{
	// Fields
	private Texture2D m_InternalSpectralLut; // 0x20

	// Methods

	// RVA: 0x202C6D0 Offset: 0x202ACD0 VA: 0x18202C6D0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x202C660 Offset: 0x202AC60 VA: 0x18202C660 Slot: 7
	public override void Release() { }

	// RVA: 0x202CA10 Offset: 0x202B010 VA: 0x18202CA10
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum GradingMode // TypeDefIndex: 12396
{
	// Fields
	public int value__; // 0x0
	public const GradingMode LowDefinitionRange = 0;
	public const GradingMode HighDefinitionRange = 1;
	public const GradingMode External = 2;
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum Tonemapper // TypeDefIndex: 12397
{
	// Fields
	public int value__; // 0x0
	public const Tonemapper None = 0;
	public const Tonemapper Neutral = 1;
	public const Tonemapper ACES = 2;
	public const Tonemapper Custom = 3;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class GradingModeParameter : ParameterOverride<GradingMode> // TypeDefIndex: 12398
{
	// Methods

	// RVA: 0x20332D0 Offset: 0x20318D0 VA: 0x1820332D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class TonemapperParameter : ParameterOverride<Tonemapper> // TypeDefIndex: 12399
{
	// Methods

	// RVA: 0x203DF90 Offset: 0x203C590 VA: 0x18203DF90
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(ColorGradingRenderer), "Unity/Color Grading", True)]
[Serializable]
public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 12400
{
	// Fields
	[DisplayName("Mode")]
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	public GradingModeParameter gradingMode; // 0x30
	[DisplayName("Lookup Texture")]
	[Tooltip("A custom 3D log-encoded texture.")]
	public TextureParameter externalLut; // 0x38
	[DisplayName("Mode")]
	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	public TonemapperParameter tonemapper; // 0x40
	[DisplayName("Toe Strength")]
	[Range(0, 1)]
	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveToeStrength; // 0x48
	[DisplayName("Toe Length")]
	[Range(0, 1)]
	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	public FloatParameter toneCurveToeLength; // 0x50
	[DisplayName("Shoulder Strength")]
	[Range(0, 1)]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveShoulderStrength; // 0x58
	[DisplayName("Shoulder Length")]
	[Min(0)]
	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	public FloatParameter toneCurveShoulderLength; // 0x60
	[DisplayName("Shoulder Angle")]
	[Range(0, 1)]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	public FloatParameter toneCurveShoulderAngle; // 0x68
	[DisplayName("Gamma")]
	[Min(0.001)]
	[Tooltip("Applies a gamma function to the curve.")]
	public FloatParameter toneCurveGamma; // 0x70
	[DisplayName("Lookup Texture")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	public TextureParameter ldrLut; // 0x78
	[DisplayName("Contribution")]
	[Range(0, 1)]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	public FloatParameter ldrLutContribution; // 0x80
	[DisplayName("Temperature")]
	[Range(-100, 100)]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	public FloatParameter temperature; // 0x88
	[DisplayName("Tint")]
	[Range(-100, 100)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public FloatParameter tint; // 0x90
	[DisplayName("Color Filter")]
	[ColorUsage(False, True)]
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; // 0x98
	[DisplayName("Hue Shift")]
	[Range(-180, 180)]
	[Tooltip("Shift the hue of all colors.")]
	public FloatParameter hueShift; // 0xA0
	[DisplayName("Saturation")]
	[Range(-100, 100)]
	[Tooltip("Pushes the intensity of all colors.")]
	public FloatParameter saturation; // 0xA8
	[DisplayName("Brightness")]
	[Range(-100, 100)]
	[Tooltip("Makes the image brighter or darker.")]
	public FloatParameter brightness; // 0xB0
	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; // 0xB8
	[DisplayName("Contrast")]
	[Range(-100, 100)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public FloatParameter contrast; // 0xC0
	[DisplayName("Red")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerRedOutRedIn; // 0xC8
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerRedOutGreenIn; // 0xD0
	[DisplayName("Blue")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerRedOutBlueIn; // 0xD8
	[DisplayName("Red")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerGreenOutRedIn; // 0xE0
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerGreenOutGreenIn; // 0xE8
	[DisplayName("Blue")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerGreenOutBlueIn; // 0xF0
	[DisplayName("Red")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerBlueOutRedIn; // 0xF8
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerBlueOutGreenIn; // 0x100
	[DisplayName("Blue")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerBlueOutBlueIn; // 0x108
	[DisplayName("Lift")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(1)]
	public Vector4Parameter lift; // 0x110
	[DisplayName("Gamma")]
	[Tooltip("Power function that controls mid-range tones.")]
	[Trackball(2)]
	public Vector4Parameter gamma; // 0x118
	[DisplayName("Gain")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(3)]
	public Vector4Parameter gain; // 0x120
	public SplineParameter masterCurve; // 0x128
	public SplineParameter redCurve; // 0x130
	public SplineParameter greenCurve; // 0x138
	public SplineParameter blueCurve; // 0x140
	public SplineParameter hueVsHueCurve; // 0x148
	public SplineParameter hueVsSatCurve; // 0x150
	public SplineParameter satVsSatCurve; // 0x158
	public SplineParameter lumVsSatCurve; // 0x160

	// Methods

	// RVA: 0x2030670 Offset: 0x202EC70 VA: 0x182030670 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x20306C0 Offset: 0x202ECC0 VA: 0x1820306C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading> // TypeDefIndex: 12402
{
	// Fields
	private Texture2D m_GradingCurves; // 0x20
	private readonly Color[] m_Pixels; // 0x28
	private RenderTexture m_InternalLdrLut; // 0x30
	private RenderTexture m_InternalLogLut; // 0x38
	private const int k_Lut2DSize = 32;
	private const int k_Lut3DSize = 33;
	private readonly HableCurve m_HableCurve; // 0x40

	// Methods

	// RVA: 0x2030450 Offset: 0x202EA50 VA: 0x182030450 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x202D580 Offset: 0x202BB80 VA: 0x18202D580
	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x202E7D0 Offset: 0x202CDD0 VA: 0x18202E7D0
	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x202D810 Offset: 0x202BE10 VA: 0x18202D810
	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x202F720 Offset: 0x202DD20 VA: 0x18202F720
	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x202CBA0 Offset: 0x202B1A0 VA: 0x18202CBA0
	private void CheckInternalLogLut() { }

	// RVA: 0x202CD80 Offset: 0x202B380 VA: 0x18202CD80
	private void CheckInternalStripLut() { }

	// RVA: 0x202CF60 Offset: 0x202B560 VA: 0x18202CF60
	private Texture2D GetCurveTexture(bool hdr) { }

	// RVA: 0x202D480 Offset: 0x202BA80 VA: 0x18202D480
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	// RVA: 0x202D3B0 Offset: 0x202B9B0 VA: 0x18202D3B0
	private static RenderTextureFormat GetLutFormat() { }

	// RVA: 0x202CF30 Offset: 0x202B530 VA: 0x18202CF30
	private static TextureFormat GetCurveFormat() { }

	// RVA: 0x202D4E0 Offset: 0x202BAE0 VA: 0x18202D4E0 Slot: 7
	public override void Release() { }

	// RVA: 0x20305C0 Offset: 0x202EBC0 VA: 0x1820305C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum KernelSize // TypeDefIndex: 12403
{
	// Fields
	public int value__; // 0x0
	public const KernelSize Small = 0;
	public const KernelSize Medium = 1;
	public const KernelSize Large = 2;
	public const KernelSize VeryLarge = 3;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class KernelSizeParameter : ParameterOverride<KernelSize> // TypeDefIndex: 12404
{
	// Methods

	// RVA: 0x2033C50 Offset: 0x2032250 VA: 0x182033C50
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(DepthOfFieldRenderer), "Unity/Depth of Field", False)]
[Serializable]
public sealed class DepthOfField : PostProcessEffectSettings // TypeDefIndex: 12405
{
	// Fields
	[Min(0.1)]
	[Tooltip("Distance to the point of focus.")]
	public FloatParameter focusDistance; // 0x30
	[Range(0.05, 32)]
	[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	public FloatParameter aperture; // 0x38
	[Range(1, 300)]
	[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	public FloatParameter focalLength; // 0x40
	[DisplayName("Max Blur Size")]
	[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
	public KernelSizeParameter kernelSize; // 0x48

	// Methods

	// RVA: 0x20329A0 Offset: 0x2030FA0 VA: 0x1820329A0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x20329E0 Offset: 0x2030FE0 VA: 0x1820329E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField> // TypeDefIndex: 12407
{
	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumCoCHistoryTextures = 2;
	private readonly RenderTexture[][] m_CoCHistoryTextures; // 0x20
	private int[] m_HistoryPingPong; // 0x28
	private const float k_FilmHeight = 0.024;

	// Methods

	// RVA: 0x2032830 Offset: 0x2030E30 VA: 0x182032830
	public void .ctor() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x20327A0 Offset: 0x2030DA0 VA: 0x1820327A0
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	// RVA: 0x2031720 Offset: 0x202FD20 VA: 0x182031720
	private float CalculateMaxCoCRadius(int screenHeight) { }

	// RVA: 0x20317A0 Offset: 0x202FDA0 VA: 0x1820317A0
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	// RVA: 0x2031B00 Offset: 0x2030100 VA: 0x182031B00 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x20319F0 Offset: 0x202FFF0 VA: 0x1820319F0 Slot: 7
	public override void Release() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
[Serializable]
internal sealed class Dithering // TypeDefIndex: 12408
{
	// Fields
	private int m_NoiseTextureIndex; // 0x10
	private Random m_Random; // 0x18

	// Methods

	// RVA: 0x2032B30 Offset: 0x2031130 VA: 0x182032B30
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x2032D80 Offset: 0x2031380 VA: 0x182032D80
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
[Serializable]
public sealed class FastApproximateAntialiasing // TypeDefIndex: 12409
{
	// Fields
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This setting is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public bool fastMode; // 0x10
	[Tooltip("Keep alpha channel. This will slightly lower the effect quality but allows rendering against a transparent background.
This setting has no effect if the camera render target has no alpha channel.")]
	public bool keepAlpha; // 0x11

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
[Serializable]
public sealed class Fog // TypeDefIndex: 12410
{
	// Fields
	[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
	public bool enabled; // 0x10
	[Tooltip("Mark true for the fog to ignore the skybox")]
	public bool excludeSkybox; // 0x11

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x2032E30 Offset: 0x2031430 VA: 0x182032E30
	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2032F50 Offset: 0x2031550 VA: 0x182032F50
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x20332C0 Offset: 0x20318C0 VA: 0x1820332C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(GrainRenderer), "Unity/Grain", True)]
[Serializable]
public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 12411
{
	// Fields
	[Tooltip("Enable the use of colored grain.")]
	public BoolParameter colored; // 0x30
	[Range(0, 1)]
	[Tooltip("Grain strength. Higher values mean more visible grain.")]
	public FloatParameter intensity; // 0x38
	[Range(0.3, 3)]
	[Tooltip("Grain particle size.")]
	public FloatParameter size; // 0x40
	[Range(0, 1)]
	[DisplayName("Luminance Contribution")]
	[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
	public FloatParameter lumContrib; // 0x48

	// Methods

	// RVA: 0x202CA50 Offset: 0x202B050 VA: 0x18202CA50 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2033B20 Offset: 0x2032120 VA: 0x182033B20
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain> // TypeDefIndex: 12412
{
	// Fields
	private RenderTexture m_GrainLookupRT; // 0x20
	private const int k_SampleCount = 1024;
	private int m_SampleIndex; // 0x28

	// Methods

	// RVA: 0x20333D0 Offset: 0x20319D0 VA: 0x1820333D0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2033310 Offset: 0x2031910 VA: 0x182033310
	private RenderTextureFormat GetLookupFormat() { }

	// RVA: 0x2033360 Offset: 0x2031960 VA: 0x182033360 Slot: 7
	public override void Release() { }

	// RVA: 0x2033AE0 Offset: 0x20320E0 VA: 0x182033AE0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(LensDistortionRenderer), "Unity/Lens Distortion", True)]
[Serializable]
public sealed class LensDistortion : PostProcessEffectSettings // TypeDefIndex: 12413
{
	// Fields
	[Range(-100, 100)]
	[Tooltip("Total distortion amount.")]
	public FloatParameter intensity; // 0x30
	[Range(0, 1)]
	[DisplayName("X Multiplier")]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	public FloatParameter intensityX; // 0x38
	[Range(0, 1)]
	[DisplayName("Y Multiplier")]
	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	public FloatParameter intensityY; // 0x40
	[Space]
	[Range(-1, 1)]
	[Tooltip("Distortion center point (x-axis).")]
	public FloatParameter centerX; // 0x48
	[Range(-1, 1)]
	[Tooltip("Distortion center point (y-axis).")]
	public FloatParameter centerY; // 0x50
	[Space]
	[Range(0.01, 5)]
	[Tooltip("Global screen scaling.")]
	public FloatParameter scale; // 0x58

	// Methods

	// RVA: 0x2033FD0 Offset: 0x20325D0 VA: 0x182033FD0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x20340F0 Offset: 0x20326F0 VA: 0x1820340F0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class LensDistortionRenderer : PostProcessEffectRenderer<LensDistortion> // TypeDefIndex: 12414
{
	// Methods

	// RVA: 0x2033C90 Offset: 0x2032290 VA: 0x182033C90 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2033F90 Offset: 0x2032590 VA: 0x182033F90
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(MotionBlurRenderer), "Unity/Motion Blur", False)]
[Serializable]
public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 12415
{
	// Fields
	[Range(0, 360)]
	[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
	public FloatParameter shutterAngle; // 0x30
	[Range(4, 32)]
	[Tooltip("The amount of sample points. This affects quality and performance.")]
	public IntParameter sampleCount; // 0x38

	// Methods

	// RVA: 0x2034F60 Offset: 0x2033560 VA: 0x182034F60 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2035010 Offset: 0x2033610 VA: 0x182035010
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur> // TypeDefIndex: 12417
{
	// Methods

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x2034300 Offset: 0x2032900 VA: 0x182034300
	private void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat) { }

	// RVA: 0x20343C0 Offset: 0x20329C0 VA: 0x1820343C0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2034F20 Offset: 0x2033520 VA: 0x182034F20
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
[Serializable]
internal sealed class MultiScaleVO : IAmbientOcclusionMethod // TypeDefIndex: 12420
{
	// Fields
	private readonly float[] m_SampleThickness; // 0x10
	private readonly float[] m_InvThicknessTable; // 0x18
	private readonly float[] m_SampleWeightTable; // 0x20
	private readonly int[] m_Widths; // 0x28
	private readonly int[] m_Heights; // 0x30
	private readonly int[] m_ScaledWidths; // 0x38
	private readonly int[] m_ScaledHeights; // 0x40
	private AmbientOcclusion m_Settings; // 0x48
	private PropertySheet m_PropertySheet; // 0x50
	private PostProcessResources m_Resources; // 0x58
	private RenderTexture m_AmbientOnlyAO; // 0x60
	private RenderTextureFormat m_R8Format; // 0x68
	private RenderTextureFormat m_R16Format; // 0x6C
	private bool float4Texture; // 0x70
	private readonly RenderTargetIdentifier[] m_MRT; // 0x78

	// Methods

	// RVA: 0x2039180 Offset: 0x2037780 VA: 0x182039180
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void SetResources(PostProcessResources resources) { }

	// RVA: 0x2035230 Offset: 0x2033830 VA: 0x182035230
	private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale) { }

	// RVA: 0x20350D0 Offset: 0x20336D0 VA: 0x1820350D0
	private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale) { }

	// RVA: 0x2038AD0 Offset: 0x20370D0 VA: 0x182038AD0
	private void Release(CommandBuffer cmd, int id) { }

	// RVA: 0x2035410 Offset: 0x2033A10 VA: 0x182035410
	private Vector4 CalculateZBufferParams(Camera camera) { }

	// RVA: 0x2035390 Offset: 0x2033990 VA: 0x182035390
	private float CalculateTanHalfFovHeight(Camera camera) { }

	// RVA: 0x2036790 Offset: 0x2034D90 VA: 0x182036790
	private Vector2 GetSize(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x2036730 Offset: 0x2034D30 VA: 0x182036730
	private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip) { }

	// RVA: 0x2035950 Offset: 0x2033F50 VA: 0x182035950
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

	// RVA: 0x2036970 Offset: 0x2034F70 VA: 0x182036970
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA, Camera camera) { }

	// RVA: 0x20371A0 Offset: 0x20357A0 VA: 0x1820371A0
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

	// RVA: 0x2037CF0 Offset: 0x20362F0 VA: 0x182037CF0
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	// RVA: 0x2038530 Offset: 0x2036B30 VA: 0x182038530
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = False) { }

	// RVA: 0x2037AD0 Offset: 0x20360D0 VA: 0x182037AD0
	private void PushReleaseCommands(CommandBuffer cmd) { }

	// RVA: 0x20367F0 Offset: 0x2034DF0 VA: 0x1820367F0
	private void PreparePropertySheet(PostProcessRenderContext context) { }

	// RVA: 0x20354C0 Offset: 0x2033AC0 VA: 0x1820354C0
	private void CheckAOTexture(PostProcessRenderContext context) { }

	// RVA: 0x20370F0 Offset: 0x20356F0 VA: 0x1820370F0
	private void PushDebug(PostProcessRenderContext context) { }

	// RVA: 0x2038B70 Offset: 0x2037170 VA: 0x182038B70 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x2038FC0 Offset: 0x20375C0 VA: 0x182038FC0 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x2035700 Offset: 0x2033D00 VA: 0x182035700 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x2038B00 Offset: 0x2037100 VA: 0x182038B00 Slot: 8
	public void Release() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
[Serializable]
internal sealed class ScalableAO : IAmbientOcclusionMethod // TypeDefIndex: 12422
{
	// Fields
	private RenderTexture m_Result; // 0x10
	private PropertySheet m_PropertySheet; // 0x18
	private AmbientOcclusion m_Settings; // 0x20
	private readonly RenderTargetIdentifier[] m_MRT; // 0x28
	private readonly int[] m_SampleCount; // 0x30

	// Methods

	// RVA: 0x203A6A0 Offset: 0x2038CA0 VA: 0x18203A6A0
	public void .ctor(AmbientOcclusion settings) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 4
	public DepthTextureMode GetCameraFlags() { }

	// RVA: 0x2039A00 Offset: 0x2038000 VA: 0x182039A00
	private void DoLazyInitialization(PostProcessRenderContext context) { }

	// RVA: 0x2039F70 Offset: 0x2038570 VA: 0x182039F70
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	// RVA: 0x2039C70 Offset: 0x2038270 VA: 0x182039C70 Slot: 5
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	// RVA: 0x2039ED0 Offset: 0x20384D0 VA: 0x182039ED0 Slot: 6
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x20397B0 Offset: 0x2037DB0 VA: 0x1820397B0 Slot: 7
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x2039C00 Offset: 0x2038200 VA: 0x182039C00 Slot: 8
	public void Release() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum ScreenSpaceReflectionPreset // TypeDefIndex: 12423
{
	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionPreset Lower = 0;
	public const ScreenSpaceReflectionPreset Low = 1;
	public const ScreenSpaceReflectionPreset Medium = 2;
	public const ScreenSpaceReflectionPreset High = 3;
	public const ScreenSpaceReflectionPreset Higher = 4;
	public const ScreenSpaceReflectionPreset Ultra = 5;
	public const ScreenSpaceReflectionPreset Overkill = 6;
	public const ScreenSpaceReflectionPreset Custom = 7;
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum ScreenSpaceReflectionResolution // TypeDefIndex: 12424
{
	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionResolution Downsampled = 0;
	public const ScreenSpaceReflectionResolution FullSize = 1;
	public const ScreenSpaceReflectionResolution Supersampled = 2;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset> // TypeDefIndex: 12425
{
	// Methods

	// RVA: 0x203A7F0 Offset: 0x2038DF0 VA: 0x18203A7F0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class ScreenSpaceReflectionResolutionParameter : ParameterOverride<ScreenSpaceReflectionResolution> // TypeDefIndex: 12426
{
	// Methods

	// RVA: 0x203A830 Offset: 0x2038E30 VA: 0x18203A830
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(ScreenSpaceReflectionsRenderer), "Unity/Screen-space reflections", True)]
[Serializable]
public sealed class ScreenSpaceReflections : PostProcessEffectSettings // TypeDefIndex: 12427
{
	// Fields
	[Tooltip("Choose a quality preset, or use "Custom" to create your own custom preset. Don't use a preset higher than "Medium" if you desire good performance on consoles.")]
	public ScreenSpaceReflectionPresetParameter preset; // 0x30
	[Range(0, 256)]
	[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
	public IntParameter maximumIterationCount; // 0x38
	[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
	public ScreenSpaceReflectionResolutionParameter resolution; // 0x40
	[Range(1, 64)]
	[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
	public FloatParameter thickness; // 0x48
	[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
	public FloatParameter maximumMarchDistance; // 0x50
	[Range(0, 1)]
	[Tooltip("Fades reflections close to the near planes.")]
	public FloatParameter distanceFade; // 0x58
	[Range(0, 1)]
	[Tooltip("Fades reflections close to the screen edges.")]
	public FloatParameter vignette; // 0x60

	// Methods

	// RVA: 0x203C300 Offset: 0x203A900 VA: 0x18203C300 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x203C470 Offset: 0x203AA70 VA: 0x18203C470
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections> // TypeDefIndex: 12430
{
	// Fields
	private RenderTexture m_Resolve; // 0x20
	private RenderTexture m_History; // 0x28
	private int[] m_MipIDs; // 0x30
	private readonly ScreenSpaceReflectionsRenderer.QualityPreset[] m_Presets; // 0x38

	// Methods

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x203A870 Offset: 0x2038E70 VA: 0x18203A870
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap) { }

	// RVA: 0x203AB10 Offset: 0x2039110 VA: 0x18203AB10 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x203AA80 Offset: 0x2039080 VA: 0x18203AA80 Slot: 7
	public override void Release() { }

	// RVA: 0x203BF20 Offset: 0x203A520 VA: 0x18203BF20
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
[Serializable]
public sealed class SubpixelMorphologicalAntialiasing // TypeDefIndex: 12433
{
	// Fields
	[Tooltip("Lower quality is faster at the expense of visual quality (Low = ~60%, Medium = ~80%).")]
	public SubpixelMorphologicalAntialiasing.Quality quality; // 0x10

	// Methods

	// RVA: 0x203C6A0 Offset: 0x203ACA0 VA: 0x18203C6A0
	public bool IsSupported() { }

	// RVA: 0x203C6F0 Offset: 0x203ACF0 VA: 0x18203C6F0
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x203CC10 Offset: 0x203B210 VA: 0x18203CC10
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
[Serializable]
public sealed class TemporalAntialiasing // TypeDefIndex: 12435
{
	// Fields
	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	[Range(0.1, 1)]
	public float jitterSpread; // 0x10
	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	[Range(0, 3)]
	public float sharpness; // 0x14
	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	[Range(0, 0.99)]
	public float stationaryBlending; // 0x18
	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	[Range(0, 0.99)]
	public float motionBlending; // 0x1C
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; // 0x20
	[CompilerGenerated]
	private Vector2 <jitter>k__BackingField; // 0x28
	private readonly RenderTargetIdentifier[] m_Mrt; // 0x30
	private bool m_ResetHistory; // 0x38
	private const int k_SampleCount = 8;
	[CompilerGenerated]
	private int <sampleIndex>k__BackingField; // 0x3C
	private const int k_NumEyes = 2;
	private const int k_NumHistoryTextures = 2;
	private readonly RenderTexture[][] m_HistoryTextures; // 0x40
	private readonly int[] m_HistoryPingPong; // 0x48

	// Properties
	public Vector2 jitter { get; set; }
	public int sampleIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x203DF70 Offset: 0x203C570 VA: 0x18203DF70
	public Vector2 get_jitter() { }

	[CompilerGenerated]
	// RVA: 0x1EB1790 Offset: 0x1EAFD90 VA: 0x181EB1790
	private void set_jitter(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public int get_sampleIndex() { }

	[CompilerGenerated]
	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	private void set_sampleIndex(int value) { }

	// RVA: 0x203D860 Offset: 0x203BE60 VA: 0x18203D860
	public bool IsSupported() { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x1DF8F70 Offset: 0x1DF7570 VA: 0x181DF8F70
	internal void ResetHistory() { }

	// RVA: 0x203D5A0 Offset: 0x203BBA0 VA: 0x18203D5A0
	private Vector2 GenerateRandomOffset() { }

	// RVA: 0x203D640 Offset: 0x203BC40 VA: 0x18203D640
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	// RVA: 0x203D190 Offset: 0x203B790 VA: 0x18203D190
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	// RVA: 0x203D270 Offset: 0x203B870 VA: 0x18203D270
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	// RVA: 0x203D4C0 Offset: 0x203BAC0 VA: 0x18203D4C0
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	// RVA: 0x203CC20 Offset: 0x203B220 VA: 0x18203CC20
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	// RVA: 0x203DA10 Offset: 0x203C010 VA: 0x18203DA10
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x203D890 Offset: 0x203BE90 VA: 0x18203D890
	internal void Release() { }

	// RVA: 0x203DEA0 Offset: 0x203C4A0 VA: 0x18203DEA0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum VignetteMode // TypeDefIndex: 12436
{
	// Fields
	public int value__; // 0x0
	public const VignetteMode Classic = 0;
	public const VignetteMode Masked = 1;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class VignetteModeParameter : ParameterOverride<VignetteMode> // TypeDefIndex: 12437
{
	// Methods

	// RVA: 0x203E0B0 Offset: 0x203C6B0 VA: 0x18203E0B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[PostProcess(typeof(VignetteRenderer), "Unity/Vignette", True)]
[Serializable]
public sealed class Vignette : PostProcessEffectSettings // TypeDefIndex: 12438
{
	// Fields
	[Tooltip("Use the "Classic" mode for parametric controls. Use the "Masked" mode to use your own texture mask.")]
	public VignetteModeParameter mode; // 0x30
	[Tooltip("Vignette color.")]
	public ColorParameter color; // 0x38
	[Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center; // 0x40
	[Range(0, 1)]
	[Tooltip("Amount of vignetting on screen.")]
	public FloatParameter intensity; // 0x48
	[Range(0.01, 1)]
	[Tooltip("Smoothness of the vignette borders.")]
	public FloatParameter smoothness; // 0x50
	[Range(0, 1)]
	[Tooltip("Lower values will make a square-ish vignette.")]
	public FloatParameter roundness; // 0x58
	[Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
	public BoolParameter rounded; // 0x60
	[Tooltip("A black and white mask to use as a vignette.")]
	public TextureParameter mask; // 0x68
	[Range(0, 1)]
	[Tooltip("Mask opacity.")]
	public FloatParameter opacity; // 0x70

	// Methods

	// RVA: 0x203E4E0 Offset: 0x203CAE0 VA: 0x18203E4E0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x203E5B0 Offset: 0x203CBB0 VA: 0x18203E5B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Preserve]
internal sealed class VignetteRenderer : PostProcessEffectRenderer<Vignette> // TypeDefIndex: 12439
{
	// Methods

	// RVA: 0x203E0F0 Offset: 0x203C6F0 VA: 0x18203E0F0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x203E4A0 Offset: 0x203CAA0 VA: 0x18203E4A0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class HistogramMonitor : Monitor // TypeDefIndex: 12441
{
	// Fields
	public int width; // 0x20
	public int height; // 0x24
	public HistogramMonitor.Channel channel; // 0x28
	private ComputeBuffer m_Data; // 0x30
	private const int k_NumBins = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x203FAA0 Offset: 0x203E0A0 VA: 0x18203FAA0 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x2040190 Offset: 0x203E790 VA: 0x182040190 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x203FB20 Offset: 0x203E120 VA: 0x18203FB20 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2040200 Offset: 0x203E800 VA: 0x182040200
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class LightMeterMonitor : Monitor // TypeDefIndex: 12442
{
	// Fields
	public int width; // 0x20
	public int height; // 0x24
	public bool showCurves; // 0x28

	// Methods

	// RVA: 0x20408C0 Offset: 0x203EEC0 VA: 0x1820408C0 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x2040290 Offset: 0x203E890 VA: 0x182040290 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2040970 Offset: 0x203EF70 VA: 0x182040970
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum MonitorType // TypeDefIndex: 12443
{
	// Fields
	public int value__; // 0x0
	public const MonitorType LightMeter = 0;
	public const MonitorType Histogram = 1;
	public const MonitorType Waveform = 2;
	public const MonitorType Vectorscope = 3;
}

// Namespace: UnityEngine.Rendering.PostProcessing
public abstract class Monitor // TypeDefIndex: 12444
{
	// Fields
	[CompilerGenerated]
	private RenderTexture <output>k__BackingField; // 0x10
	internal bool requested; // 0x18

	// Properties
	public RenderTexture output { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public RenderTexture get_output() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	protected void set_output(RenderTexture value) { }

	// RVA: 0x20416F0 Offset: 0x203FCF0 VA: 0x1820416F0
	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	internal virtual bool NeedsHalfRes() { }

	// RVA: 0x2041550 Offset: 0x203FB50 VA: 0x182041550
	protected void CheckOutput(int width, int height) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	internal virtual void OnEnable() { }

	// RVA: 0x2041830 Offset: 0x203FE30 VA: 0x182041830 Slot: 7
	internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Render(PostProcessRenderContext context);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 12445
{
	// Fields
	public int size; // 0x20
	public float exposure; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x2057740 Offset: 0x2055D40 VA: 0x182057740 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x2057ED0 Offset: 0x20564D0 VA: 0x182057ED0 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x20577C0 Offset: 0x2055DC0 VA: 0x1820577C0 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2057F40 Offset: 0x2056540 VA: 0x182057F40
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class WaveformMonitor : Monitor // TypeDefIndex: 12446
{
	// Fields
	public float exposure; // 0x20
	public int height; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSize = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x2057740 Offset: 0x2055D40 VA: 0x182057740 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x20587E0 Offset: 0x2056DE0 VA: 0x1820587E0 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x2057F60 Offset: 0x2056560 VA: 0x182057F60 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2058850 Offset: 0x2056E50 VA: 0x182058850
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public abstract class ParameterOverride // TypeDefIndex: 12447
{
	// Fields
	public bool overrideState; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetHash();

	// RVA: -1 Offset: -1
	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73A5C0 Offset: 0x738BC0 VA: 0x18073A5C0
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x73A690 Offset: 0x738C90 VA: 0x18073A690
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x73A870 Offset: 0x738E70 VA: 0x18073A870
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x73A940 Offset: 0x738F40 VA: 0x18073A940
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x73AA10 Offset: 0x739010 VA: 0x18073AA10
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x73AAE0 Offset: 0x7390E0 VA: 0x18073AAE0
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x73ABC0 Offset: 0x7391C0 VA: 0x18073ABC0
	|-ParameterOverride.GetValue<Vector3>
	|
	|-RVA: 0x73A770 Offset: 0x738D70 VA: 0x18073A770
	|-ParameterOverride.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected internal virtual void OnEnable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void SetValue(ParameterOverride parameter);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public class ParameterOverride<T> : ParameterOverride // TypeDefIndex: 12448
{
	// Fields
	public T value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E6EB0 Offset: 0x12E54B0 VA: 0x1812E6EB0
	|-ParameterOverride<bool>..ctor
	|
	|-RVA: 0x12E6FF0 Offset: 0x12E55F0 VA: 0x1812E6FF0
	|-ParameterOverride<Color>..ctor
	|-ParameterOverride<Vector4>..ctor
	|
	|-RVA: 0x12E6BF0 Offset: 0x12E51F0 VA: 0x1812E6BF0
	|-ParameterOverride<int>..ctor
	|-ParameterOverride<Int32Enum>..ctor
	|-ParameterOverride<float>..ctor
	|
	|-RVA: 0x12E7050 Offset: 0x12E5650 VA: 0x1812E7050
	|-ParameterOverride<object>..ctor
	|
	|-RVA: 0x12E72A0 Offset: 0x12E58A0 VA: 0x1812E72A0
	|-ParameterOverride<Vector2>..ctor
	|
	|-RVA: 0x12E7150 Offset: 0x12E5750 VA: 0x1812E7150
	|-ParameterOverride<Vector3>..ctor
	|
	|-RVA: 0x12E6D90 Offset: 0x12E5390 VA: 0x1812E6D90
	|-ParameterOverride<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E7200 Offset: 0x12E5800 VA: 0x1812E7200
	|-ParameterOverride<bool>..ctor
	|
	|-RVA: 0x12E6C20 Offset: 0x12E5220 VA: 0x1812E6C20
	|-ParameterOverride<Color>..ctor
	|-ParameterOverride<Vector4>..ctor
	|
	|-RVA: 0x12E7020 Offset: 0x12E5620 VA: 0x1812E7020
	|-ParameterOverride<int>..ctor
	|-ParameterOverride<Int32Enum>..ctor
	|
	|-RVA: 0x12E6ED0 Offset: 0x12E54D0 VA: 0x1812E6ED0
	|-ParameterOverride<object>..ctor
	|
	|-RVA: 0x12E71D0 Offset: 0x12E57D0 VA: 0x1812E71D0
	|-ParameterOverride<float>..ctor
	|
	|-RVA: 0x12E7270 Offset: 0x12E5870 VA: 0x1812E7270
	|-ParameterOverride<Vector2>..ctor
	|
	|-RVA: 0x12E7320 Offset: 0x12E5920 VA: 0x1812E7320
	|-ParameterOverride<Vector3>..ctor
	|
	|-RVA: 0x12E6C90 Offset: 0x12E5290 VA: 0x1812E6C90
	|-ParameterOverride<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value, bool overrideState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E7110 Offset: 0x12E5710 VA: 0x1812E7110
	|-ParameterOverride<bool>..ctor
	|
	|-RVA: 0x12E7190 Offset: 0x12E5790 VA: 0x1812E7190
	|-ParameterOverride<Color>..ctor
	|-ParameterOverride<Vector4>..ctor
	|
	|-RVA: 0x12E6C50 Offset: 0x12E5250 VA: 0x1812E6C50
	|-ParameterOverride<int>..ctor
	|-ParameterOverride<Int32Enum>..ctor
	|
	|-RVA: 0x12E72D0 Offset: 0x12E58D0 VA: 0x1812E72D0
	|-ParameterOverride<object>..ctor
	|
	|-RVA: 0x12E70D0 Offset: 0x12E56D0 VA: 0x1812E70D0
	|-ParameterOverride<float>..ctor
	|
	|-RVA: 0x12E7230 Offset: 0x12E5830 VA: 0x1812E7230
	|-ParameterOverride<Vector2>..ctor
	|
	|-RVA: 0x12E7080 Offset: 0x12E5680 VA: 0x1812E7080
	|-ParameterOverride<Vector3>..ctor
	|
	|-RVA: 0x12E6F10 Offset: 0x12E5510 VA: 0x1812E6F10
	|-ParameterOverride<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void Interp(ParameterOverride from, ParameterOverride to, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E62D0 Offset: 0x12E48D0 VA: 0x1812E62D0
	|-ParameterOverride<bool>.Interp
	|
	|-RVA: 0x12E6210 Offset: 0x12E4810 VA: 0x1812E6210
	|-ParameterOverride<Color>.Interp
	|-ParameterOverride<Vector4>.Interp
	|
	|-RVA: 0x12E6450 Offset: 0x12E4A50 VA: 0x1812E6450
	|-ParameterOverride<int>.Interp
	|-ParameterOverride<Int32Enum>.Interp
	|
	|-RVA: 0x12E60F0 Offset: 0x12E46F0 VA: 0x1812E60F0
	|-ParameterOverride<object>.Interp
	|
	|-RVA: 0x12E5ED0 Offset: 0x12E44D0 VA: 0x1812E5ED0
	|-ParameterOverride<float>.Interp
	|
	|-RVA: 0x12E6720 Offset: 0x12E4D20 VA: 0x1812E6720
	|-ParameterOverride<Vector2>.Interp
	|
	|-RVA: 0x12E6640 Offset: 0x12E4C40 VA: 0x1812E6640
	|-ParameterOverride<Vector3>.Interp
	|
	|-RVA: 0x12E5F80 Offset: 0x12E4580 VA: 0x1812E5F80
	|-ParameterOverride<__Il2CppFullySharedGenericType>.Interp
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public virtual void Interp(T from, T to, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E63F0 Offset: 0x12E49F0 VA: 0x1812E63F0
	|-ParameterOverride<bool>.Interp
	|
	|-RVA: 0x12E6420 Offset: 0x12E4A20 VA: 0x1812E6420
	|-ParameterOverride<Color>.Interp
	|-ParameterOverride<Vector4>.Interp
	|
	|-RVA: 0x12E5EA0 Offset: 0x12E44A0 VA: 0x1812E5EA0
	|-ParameterOverride<int>.Interp
	|-ParameterOverride<Int32Enum>.Interp
	|
	|-RVA: 0x12E6380 Offset: 0x12E4980 VA: 0x1812E6380
	|-ParameterOverride<object>.Interp
	|
	|-RVA: 0x12E61A0 Offset: 0x12E47A0 VA: 0x1812E61A0
	|-ParameterOverride<float>.Interp
	|
	|-RVA: 0x12E63B0 Offset: 0x12E49B0 VA: 0x1812E63B0
	|-ParameterOverride<Vector2>.Interp
	|
	|-RVA: 0x12E61D0 Offset: 0x12E47D0 VA: 0x1812E61D0
	|-ParameterOverride<Vector3>.Interp
	|
	|-RVA: 0x12E6500 Offset: 0x12E4B00 VA: 0x1812E6500
	|-ParameterOverride<__Il2CppFullySharedGenericType>.Interp
	*/

	// RVA: -1 Offset: -1
	public void Override(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E6910 Offset: 0x12E4F10 VA: 0x1812E6910
	|-ParameterOverride<bool>.Override
	|
	|-RVA: 0x12E67E0 Offset: 0x12E4DE0 VA: 0x1812E67E0
	|-ParameterOverride<Color>.Override
	|-ParameterOverride<Vector4>.Override
	|
	|-RVA: 0x12E68C0 Offset: 0x12E4EC0 VA: 0x1812E68C0
	|-ParameterOverride<int>.Override
	|-ParameterOverride<Int32Enum>.Override
	|
	|-RVA: 0x12E68D0 Offset: 0x12E4ED0 VA: 0x1812E68D0
	|-ParameterOverride<object>.Override
	|
	|-RVA: 0x12E6920 Offset: 0x12E4F20 VA: 0x1812E6920
	|-ParameterOverride<float>.Override
	|
	|-RVA: 0x12E6930 Offset: 0x12E4F30 VA: 0x1812E6930
	|-ParameterOverride<Vector2>.Override
	|
	|-RVA: 0x12E68F0 Offset: 0x12E4EF0 VA: 0x1812E68F0
	|-ParameterOverride<Vector3>.Override
	|
	|-RVA: 0x12E67F0 Offset: 0x12E4DF0 VA: 0x1812E67F0
	|-ParameterOverride<__Il2CppFullySharedGenericType>.Override
	*/

	// RVA: -1 Offset: -1 Slot: 8
	internal override void SetValue(ParameterOverride parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E6940 Offset: 0x12E4F40 VA: 0x1812E6940
	|-ParameterOverride<bool>.SetValue
	|
	|-RVA: 0x12E69D0 Offset: 0x12E4FD0 VA: 0x1812E69D0
	|-ParameterOverride<Color>.SetValue
	|-ParameterOverride<Vector4>.SetValue
	|
	|-RVA: 0x12E6A60 Offset: 0x12E5060 VA: 0x1812E6A60
	|-ParameterOverride<int>.SetValue
	|-ParameterOverride<Int32Enum>.SetValue
	|
	|-RVA: 0x12E6A10 Offset: 0x12E5010 VA: 0x1812E6A10
	|-ParameterOverride<object>.SetValue
	|
	|-RVA: 0x12E6AA0 Offset: 0x12E50A0 VA: 0x1812E6AA0
	|-ParameterOverride<float>.SetValue
	|
	|-RVA: 0x12E6BA0 Offset: 0x12E51A0 VA: 0x1812E6BA0
	|-ParameterOverride<Vector2>.SetValue
	|
	|-RVA: 0x12E6980 Offset: 0x12E4F80 VA: 0x1812E6980
	|-ParameterOverride<Vector3>.SetValue
	|
	|-RVA: 0x12E6AE0 Offset: 0x12E50E0 VA: 0x1812E6AE0
	|-ParameterOverride<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override int GetHash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E5990 Offset: 0x12E3F90 VA: 0x1812E5990
	|-ParameterOverride<bool>.GetHash
	|
	|-RVA: 0x12E5CE0 Offset: 0x12E42E0 VA: 0x1812E5CE0
	|-ParameterOverride<Color>.GetHash
	|
	|-RVA: 0x12E5DC0 Offset: 0x12E43C0 VA: 0x1812E5DC0
	|-ParameterOverride<int>.GetHash
	|
	|-RVA: 0x12E5C90 Offset: 0x12E4290 VA: 0x1812E5C90
	|-ParameterOverride<Int32Enum>.GetHash
	|
	|-RVA: 0x12E5920 Offset: 0x12E3F20 VA: 0x1812E5920
	|-ParameterOverride<object>.GetHash
	|
	|-RVA: 0x12E5B90 Offset: 0x12E4190 VA: 0x1812E5B90
	|-ParameterOverride<float>.GetHash
	|
	|-RVA: 0x12E5E30 Offset: 0x12E4430 VA: 0x1812E5E30
	|-ParameterOverride<Vector2>.GetHash
	|
	|-RVA: 0x12E5C00 Offset: 0x12E4200 VA: 0x1812E5C00
	|-ParameterOverride<Vector3>.GetHash
	|
	|-RVA: 0x12E5B20 Offset: 0x12E4120 VA: 0x1812E5B20
	|-ParameterOverride<Vector4>.GetHash
	|
	|-RVA: 0x12E5A00 Offset: 0x12E4000 VA: 0x1812E5A00
	|-ParameterOverride<__Il2CppFullySharedGenericType>.GetHash
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(ParameterOverride<T> prop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E7510 Offset: 0x12E5B10 VA: 0x1812E7510
	|-ParameterOverride<bool>.op_Implicit
	|
	|-RVA: 0x12E7450 Offset: 0x12E5A50 VA: 0x1812E7450
	|-ParameterOverride<Color>.op_Implicit
	|-ParameterOverride<Vector4>.op_Implicit
	|
	|-RVA: 0x12E7360 Offset: 0x12E5960 VA: 0x1812E7360
	|-ParameterOverride<int>.op_Implicit
	|-ParameterOverride<Int32Enum>.op_Implicit
	|
	|-RVA: 0x12E74F0 Offset: 0x12E5AF0 VA: 0x1812E74F0
	|-ParameterOverride<object>.op_Implicit
	|
	|-RVA: 0x12E7470 Offset: 0x12E5A70 VA: 0x1812E7470
	|-ParameterOverride<float>.op_Implicit
	|
	|-RVA: 0x12E7490 Offset: 0x12E5A90 VA: 0x1812E7490
	|-ParameterOverride<Vector2>.op_Implicit
	|
	|-RVA: 0x12E74C0 Offset: 0x12E5AC0 VA: 0x1812E74C0
	|-ParameterOverride<Vector3>.op_Implicit
	|
	|-RVA: 0x12E7380 Offset: 0x12E5980 VA: 0x1812E7380
	|-ParameterOverride<__Il2CppFullySharedGenericType>.op_Implicit
	*/
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class FloatParameter : ParameterOverride<float> // TypeDefIndex: 12449
{
	// Methods

	// RVA: 0x203EF30 Offset: 0x203D530 VA: 0x18203EF30 Slot: 9
	public override void Interp(float from, float to, float t) { }

	// RVA: 0x203EF50 Offset: 0x203D550 VA: 0x18203EF50
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class IntParameter : ParameterOverride<int> // TypeDefIndex: 12450
{
	// Methods

	// RVA: 0x2040220 Offset: 0x203E820 VA: 0x182040220 Slot: 9
	public override void Interp(int from, int to, float t) { }

	// RVA: 0x2040250 Offset: 0x203E850 VA: 0x182040250
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class BoolParameter : ParameterOverride<bool> // TypeDefIndex: 12451
{
	// Methods

	// RVA: 0x203E860 Offset: 0x203CE60 VA: 0x18203E860
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class ColorParameter : ParameterOverride<Color> // TypeDefIndex: 12452
{
	// Methods

	// RVA: 0x203E8A0 Offset: 0x203CEA0 VA: 0x18203E8A0 Slot: 9
	public override void Interp(Color from, Color to, float t) { }

	// RVA: 0x203E950 Offset: 0x203CF50 VA: 0x18203E950
	public static Vector4 op_Implicit(ColorParameter prop) { }

	// RVA: 0x203E910 Offset: 0x203CF10 VA: 0x18203E910
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class Vector2Parameter : ParameterOverride<Vector2> // TypeDefIndex: 12453
{
	// Methods

	// RVA: 0x2057470 Offset: 0x2055A70 VA: 0x182057470 Slot: 9
	public override void Interp(Vector2 from, Vector2 to, float t) { }

	// RVA: 0x2057500 Offset: 0x2055B00 VA: 0x182057500
	public static Vector3 op_Implicit(Vector2Parameter prop) { }

	// RVA: 0x2057530 Offset: 0x2055B30 VA: 0x182057530
	public static Vector4 op_Implicit(Vector2Parameter prop) { }

	// RVA: 0x20574C0 Offset: 0x2055AC0 VA: 0x1820574C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class Vector3Parameter : ParameterOverride<Vector3> // TypeDefIndex: 12454
{
	// Methods

	// RVA: 0x2057580 Offset: 0x2055B80 VA: 0x182057580 Slot: 9
	public override void Interp(Vector3 from, Vector3 to, float t) { }

	// RVA: 0x2057660 Offset: 0x2055C60 VA: 0x182057660
	public static Vector2 op_Implicit(Vector3Parameter prop) { }

	// RVA: 0x2057610 Offset: 0x2055C10 VA: 0x182057610
	public static Vector4 op_Implicit(Vector3Parameter prop) { }

	// RVA: 0x20575D0 Offset: 0x2055BD0 VA: 0x1820575D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class Vector4Parameter : ParameterOverride<Vector4> // TypeDefIndex: 12455
{
	// Methods

	// RVA: 0x203E8A0 Offset: 0x203CEA0 VA: 0x18203E8A0 Slot: 9
	public override void Interp(Vector4 from, Vector4 to, float t) { }

	// RVA: 0x20576D0 Offset: 0x2055CD0 VA: 0x1820576D0
	public static Vector2 op_Implicit(Vector4Parameter prop) { }

	// RVA: 0x2057700 Offset: 0x2055D00 VA: 0x182057700
	public static Vector3 op_Implicit(Vector4Parameter prop) { }

	// RVA: 0x2057690 Offset: 0x2055C90 VA: 0x182057690
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class SplineParameter : ParameterOverride<Spline> // TypeDefIndex: 12456
{
	// Methods

	// RVA: 0x2056630 Offset: 0x2054C30 VA: 0x182056630 Slot: 6
	protected internal override void OnEnable() { }

	// RVA: 0x2056650 Offset: 0x2054C50 VA: 0x182056650 Slot: 8
	internal override void SetValue(ParameterOverride parameter) { }

	// RVA: 0x20564F0 Offset: 0x2054AF0 VA: 0x1820564F0 Slot: 9
	public override void Interp(Spline from, Spline to, float t) { }

	// RVA: 0x20566C0 Offset: 0x2054CC0 VA: 0x1820566C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum TextureParameterDefault // TypeDefIndex: 12457
{
	// Fields
	public int value__; // 0x0
	public const TextureParameterDefault None = 0;
	public const TextureParameterDefault Black = 1;
	public const TextureParameterDefault White = 2;
	public const TextureParameterDefault Transparent = 3;
	public const TextureParameterDefault Lut2D = 4;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class TextureParameter : ParameterOverride<Texture> // TypeDefIndex: 12458
{
	// Fields
	public TextureParameterDefault defaultState; // 0x20

	// Methods

	// RVA: 0x2056700 Offset: 0x2054D00 VA: 0x182056700 Slot: 9
	public override void Interp(Texture from, Texture to, float t) { }

	// RVA: 0x2056B70 Offset: 0x2055170 VA: 0x182056B70
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public sealed class PostProcessBundle // TypeDefIndex: 12459
{
	// Fields
	[CompilerGenerated]
	private PostProcessAttribute <attribute>k__BackingField; // 0x10
	[CompilerGenerated]
	private PostProcessEffectSettings <settings>k__BackingField; // 0x18
	private PostProcessEffectRenderer m_Renderer; // 0x20

	// Properties
	public PostProcessAttribute attribute { get; set; }
	public PostProcessEffectSettings settings { get; set; }
	internal PostProcessEffectRenderer renderer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public PostProcessAttribute get_attribute() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public PostProcessEffectSettings get_settings() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_settings(PostProcessEffectSettings value) { }

	// RVA: 0x20419E0 Offset: 0x203FFE0 VA: 0x1820419E0
	internal PostProcessEffectRenderer get_renderer() { }

	// RVA: 0x2041930 Offset: 0x203FF30 VA: 0x182041930
	internal void .ctor(PostProcessEffectSettings settings) { }

	// RVA: 0x20418A0 Offset: 0x203FEA0 VA: 0x1820418A0
	internal void Release() { }

	// RVA: 0x2041910 Offset: 0x203FF10 VA: 0x182041910
	internal void ResetHistory() { }

	// RVA: -1 Offset: -1
	internal T CastSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A160 Offset: 0x748760 VA: 0x18074A160
	|-PostProcessBundle.CastSettings<object>
	*/

	// RVA: -1 Offset: -1
	internal T CastRenderer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A0E0 Offset: 0x7486E0 VA: 0x18074A0E0
	|-PostProcessBundle.CastRenderer<object>
	*/
}

// Namespace: UnityEngine.Rendering.PostProcessing
[ExecuteAlways]
[AddComponentMenu("Rendering/Post-process Debug", 1002)]
public sealed class PostProcessDebug : MonoBehaviour // TypeDefIndex: 12460
{
	// Fields
	public PostProcessLayer postProcessLayer; // 0x20
	private PostProcessLayer m_PreviousPostProcessLayer; // 0x28
	public bool lightMeter; // 0x30
	public bool histogram; // 0x31
	public bool waveform; // 0x32
	public bool vectorscope; // 0x33
	public DebugOverlay debugOverlay; // 0x34
	private Camera m_CurrentCamera; // 0x38
	private CommandBuffer m_CmdAfterEverything; // 0x40

	// Methods

	// RVA: 0x2043140 Offset: 0x2041740 VA: 0x182043140
	private void OnEnable() { }

	// RVA: 0x20430A0 Offset: 0x20416A0 VA: 0x1820430A0
	private void OnDisable() { }

	// RVA: 0x20436C0 Offset: 0x2041CC0 VA: 0x1820436C0
	private void Update() { }

	// RVA: 0x2043410 Offset: 0x2041A10 VA: 0x182043410
	private void Reset() { }

	// RVA: 0x2043460 Offset: 0x2041A60 VA: 0x182043460
	private void UpdateStates() { }

	// RVA: 0x2043300 Offset: 0x2041900 VA: 0x182043300
	private void OnPostRender() { }

	// RVA: 0x20431D0 Offset: 0x20417D0 VA: 0x1820431D0
	private void OnGUI() { }

	// RVA: 0x2042F30 Offset: 0x2041530 VA: 0x182042F30
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum DebugOverlay // TypeDefIndex: 12461
{
	// Fields
	public int value__; // 0x0
	public const DebugOverlay None = 0;
	public const DebugOverlay Depth = 1;
	public const DebugOverlay Normals = 2;
	public const DebugOverlay MotionVectors = 3;
	public const DebugOverlay NANTracker = 4;
	public const DebugOverlay ColorBlindnessSimulation = 5;
	public const DebugOverlay _ = 6;
	public const DebugOverlay AmbientOcclusion = 7;
	public const DebugOverlay BloomBuffer = 8;
	public const DebugOverlay BloomThreshold = 9;
	public const DebugOverlay DepthOfField = 10;
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum ColorBlindnessType // TypeDefIndex: 12462
{
	// Fields
	public int value__; // 0x0
	public const ColorBlindnessType Deuteranopia = 0;
	public const ColorBlindnessType Protanopia = 1;
	public const ColorBlindnessType Tritanopia = 2;
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class PostProcessDebugLayer // TypeDefIndex: 12464
{
	// Fields
	public LightMeterMonitor lightMeter; // 0x10
	public HistogramMonitor histogram; // 0x18
	public WaveformMonitor waveform; // 0x20
	public VectorscopeMonitor vectorscope; // 0x28
	private Dictionary<MonitorType, Monitor> m_Monitors; // 0x30
	private int frameWidth; // 0x38
	private int frameHeight; // 0x3C
	[CompilerGenerated]
	private RenderTexture <debugOverlayTarget>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <debugOverlayActive>k__BackingField; // 0x48
	[CompilerGenerated]
	private DebugOverlay <debugOverlay>k__BackingField; // 0x4C
	public PostProcessDebugLayer.OverlaySettings overlaySettings; // 0x50

	// Properties
	public RenderTexture debugOverlayTarget { get; set; }
	public bool debugOverlayActive { get; set; }
	public DebugOverlay debugOverlay { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public RenderTexture get_debugOverlayTarget() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	private void set_debugOverlayTarget(RenderTexture value) { }

	[CompilerGenerated]
	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_debugOverlayActive() { }

	[CompilerGenerated]
	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	private void set_debugOverlayActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public DebugOverlay get_debugOverlay() { }

	[CompilerGenerated]
	// RVA: 0x9CC920 Offset: 0x9CAF20 VA: 0x1809CC920
	private void set_debugOverlay(DebugOverlay value) { }

	// RVA: 0x2041FB0 Offset: 0x20405B0 VA: 0x182041FB0
	internal void OnEnable() { }

	// RVA: 0x2041DB0 Offset: 0x20403B0 VA: 0x182041DB0
	internal void OnDisable() { }

	// RVA: 0x2041B10 Offset: 0x2040110 VA: 0x182041B10
	private void DestroyDebugOverlayTarget() { }

	// RVA: 0x2042EC0 Offset: 0x20414C0 VA: 0x182042EC0
	public void RequestMonitorPass(MonitorType monitor) { }

	// RVA: 0x9CC920 Offset: 0x9CAF20 VA: 0x1809CC920
	public void RequestDebugOverlay(DebugOverlay mode) { }

	// RVA: 0x2042F20 Offset: 0x2041520 VA: 0x182042F20
	internal void SetFrameSize(int width, int height) { }

	// RVA: 0x2042260 Offset: 0x2040860 VA: 0x182042260
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x2041D80 Offset: 0x2040380 VA: 0x182041D80
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x2042580 Offset: 0x2040B80 VA: 0x182042580
	internal void RenderMonitors(PostProcessRenderContext context) { }

	// RVA: 0x2042A50 Offset: 0x2041050 VA: 0x182042A50
	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	// RVA: 0x2041B80 Offset: 0x2040180 VA: 0x182041B80
	internal void EndFrame() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public abstract class PostProcessEffectRenderer // TypeDefIndex: 12465
{
	// Fields
	protected bool m_ResetHistory; // 0x10

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public virtual void Init() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public virtual DepthTextureMode GetCameraFlags() { }

	// RVA: 0x1E9D770 Offset: 0x1E9BD70 VA: 0x181E9D770 Slot: 6
	public virtual void ResetHistory() { }

	// RVA: 0x39A460 Offset: 0x398A60 VA: 0x18039A460 Slot: 7
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Render(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	// RVA: 0x1796550 Offset: 0x1794B50 VA: 0x181796550
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer // TypeDefIndex: 12466
{
	// Fields
	[CompilerGenerated]
	private T <settings>k__BackingField; // 0x0

	// Properties
	public T settings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_settings() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-PostProcessEffectRenderer<object>.get_settings
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_settings(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	|-PostProcessEffectRenderer<object>.set_settings
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override void SetSettings(PostProcessEffectSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F0010 Offset: 0x12EE610 VA: 0x1812F0010
	|-PostProcessEffectRenderer<object>.SetSettings
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F0090 Offset: 0x12EE690 VA: 0x1812F0090
	|-PostProcessEffectRenderer<object>..ctor
	*/
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public class PostProcessEffectSettings : ScriptableObject // TypeDefIndex: 12468
{
	// Fields
	public bool active; // 0x18
	public BoolParameter enabled; // 0x20
	internal ReadOnlyCollection<ParameterOverride> parameters; // 0x28

	// Methods

	// RVA: 0x2043B00 Offset: 0x2042100 VA: 0x182043B00
	private void OnEnable() { }

	// RVA: 0x2043940 Offset: 0x2041F40 VA: 0x182043940
	private void OnDisable() { }

	// RVA: 0x2043F70 Offset: 0x2042570 VA: 0x182043F70
	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	// RVA: 0x2043920 Offset: 0x2041F20 VA: 0x182043920 Slot: 4
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x2043740 Offset: 0x2041D40 VA: 0x182043740
	public int GetHash() { }

	// RVA: 0x2044200 Offset: 0x2042800 VA: 0x182044200
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2044150 Offset: 0x2042750 VA: 0x182044150
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public enum PostProcessEvent // TypeDefIndex: 12469
{
	// Fields
	public int value__; // 0x0
	public const PostProcessEvent BeforeTransparent = 0;
	public const PostProcessEvent BeforeStack = 1;
	public const PostProcessEvent AfterStack = 2;
}

// Namespace: UnityEngine.Rendering.PostProcessing
internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent> // TypeDefIndex: 12470
{
	// Methods

	// RVA: 0xACF100 Offset: 0xACD700 VA: 0x180ACF100 Slot: 4
	public bool Equals(PostProcessEvent x, PostProcessEvent y) { }

	// RVA: 0x4CDF70 Offset: 0x4CC570 VA: 0x1804CDF70 Slot: 5
	public int GetHashCode(PostProcessEvent obj) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[ExecuteAlways]
[DisallowMultipleComponent]
[ImageEffectAllowedInSceneView]
[AddComponentMenu("Rendering/Post-process Layer", 1000)]
[RequireComponent(typeof(Camera))]
public sealed class PostProcessLayer : MonoBehaviour // TypeDefIndex: 12478
{
	// Fields
	public Transform volumeTrigger; // 0x20
	public LayerMask volumeLayer; // 0x28
	public bool stopNaNPropagation; // 0x2C
	public bool finalBlitToCameraTarget; // 0x2D
	public PostProcessLayer.Antialiasing antialiasingMode; // 0x30
	public TemporalAntialiasing temporalAntialiasing; // 0x38
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; // 0x40
	public FastApproximateAntialiasing fastApproximateAntialiasing; // 0x48
	public Fog fog; // 0x50
	private Dithering dithering; // 0x58
	public PostProcessDebugLayer debugLayer; // 0x60
	[SerializeField]
	private PostProcessResources m_Resources; // 0x68
	private PostProcessResources m_OldResources; // 0x70
	[Preserve]
	[SerializeField]
	private bool m_ShowToolkit; // 0x78
	[Preserve]
	[SerializeField]
	private bool m_ShowCustomSorter; // 0x79
	public bool breakBeforeColorGrading; // 0x7A
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles; // 0x80
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles; // 0x88
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_AfterStackBundles; // 0x90
	[CompilerGenerated]
	private Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> <sortedBundles>k__BackingField; // 0x98
	[CompilerGenerated]
	private DepthTextureMode <cameraDepthFlags>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <haveBundlesBeenInited>k__BackingField; // 0xA4
	private Dictionary<Type, PostProcessBundle> m_Bundles; // 0xA8
	private PropertySheetFactory m_PropertySheetFactory; // 0xB0
	private CommandBuffer m_LegacyCmdBufferBeforeReflections; // 0xB8
	private CommandBuffer m_LegacyCmdBufferBeforeLighting; // 0xC0
	private CommandBuffer m_LegacyCmdBufferOpaque; // 0xC8
	private CommandBuffer m_LegacyCmdBuffer; // 0xD0
	private Camera m_Camera; // 0xD8
	private PostProcessRenderContext m_CurrentContext; // 0xE0
	private LogHistogram m_LogHistogram; // 0xE8
	private bool m_SettingsUpdateNeeded; // 0xF0
	private bool m_IsRenderingInSceneView; // 0xF1
	private TargetPool m_TargetPool; // 0xF8
	private bool m_NaNKilled; // 0x100
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects; // 0x108
	private readonly List<RenderTargetIdentifier> m_Targets; // 0x110

	// Properties
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> sortedBundles { get; set; }
	public DepthTextureMode cameraDepthFlags { get; set; }
	public bool haveBundlesBeenInited { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGenerated]
	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGenerated]
	// RVA: 0x1BD25D0 Offset: 0x1BD0BD0 VA: 0x181BD25D0
	public DepthTextureMode get_cameraDepthFlags() { }

	[CompilerGenerated]
	// RVA: 0x204B580 Offset: 0x2049B80 VA: 0x18204B580
	private void set_cameraDepthFlags(DepthTextureMode value) { }

	[CompilerGenerated]
	// RVA: 0x204B570 Offset: 0x2049B70 VA: 0x18204B570
	public bool get_haveBundlesBeenInited() { }

	[CompilerGenerated]
	// RVA: 0x204B590 Offset: 0x2049B90 VA: 0x18204B590
	private void set_haveBundlesBeenInited(bool value) { }

	// RVA: 0x2046450 Offset: 0x2044A50 VA: 0x182046450
	private void OnEnable() { }

	// RVA: 0x2045CE0 Offset: 0x20442E0 VA: 0x182045CE0
	private void InitLegacy() { }

	// RVA: 0x2045540 Offset: 0x2043B40 VA: 0x182045540
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget() { }

	[ImageEffectUsesCommandBuffer]
	// RVA: 0x2046FB0 Offset: 0x20455B0 VA: 0x182046FB0
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x2045F60 Offset: 0x2044560 VA: 0x182045F60
	public void Init(PostProcessResources resources) { }

	// RVA: 0x2045850 Offset: 0x2043E50 VA: 0x182045850
	public void InitBundles() { }

	// RVA: 0x204AB80 Offset: 0x2049180 VA: 0x18204AB80
	private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	// RVA: 0x20460A0 Offset: 0x20446A0 VA: 0x1820460A0
	private void OnDisable() { }

	// RVA: 0x204A3D0 Offset: 0x20489D0 VA: 0x18204A3D0
	private void Reset() { }

	// RVA: 0x2046920 Offset: 0x2044F20 VA: 0x182046920
	private void OnPreCull() { }

	// RVA: 0x2046F30 Offset: 0x2045530 VA: 0x182046F30
	private void OnPreRender() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	// RVA: 0x204B1C0 Offset: 0x20497C0 VA: 0x18204B1C0
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	// RVA: 0x2044580 Offset: 0x2042B80 VA: 0x182044580
	private void BuildCommandBuffers() { }

	// RVA: 0x2046710 Offset: 0x2044D10 VA: 0x182046710
	private void OnPostRender() { }

	// RVA: -1 Offset: -1
	public PostProcessBundle GetBundle<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A1D0 Offset: 0x7487D0 VA: 0x18074A1D0
	|-PostProcessLayer.GetBundle<object>
	*/

	// RVA: 0x20455D0 Offset: 0x2043BD0 VA: 0x1820455D0
	public PostProcessBundle GetBundle(Type settingsType) { }

	// RVA: -1 Offset: -1
	public T GetSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A230 Offset: 0x748830 VA: 0x18074A230
	|-PostProcessLayer.GetSettings<object>
	*/

	// RVA: 0x2044420 Offset: 0x2042A20 VA: 0x182044420
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = False) { }

	// RVA: 0x2047060 Offset: 0x2045660 VA: 0x182047060
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	// RVA: 0x204A400 Offset: 0x2048A00 VA: 0x18204A400
	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	// RVA: 0x204A260 Offset: 0x2048860 VA: 0x18204A260
	public void ResetHistory() { }

	// RVA: 0x2045840 Offset: 0x2043E40 VA: 0x182045840
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	// RVA: 0x2045630 Offset: 0x2043C30 VA: 0x182045630
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	// RVA: 0x204A6D0 Offset: 0x2048CD0 VA: 0x18204A6D0
	private void SetupContext(PostProcessRenderContext context) { }

	// RVA: 0x204B350 Offset: 0x2049950 VA: 0x18204B350
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

	// RVA: 0x20494C0 Offset: 0x2047AC0 VA: 0x1820494C0
	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	// RVA: 0x20495B0 Offset: 0x2047BB0 VA: 0x1820495B0
	public void Render(PostProcessRenderContext context) { }

	// RVA: 0x20488F0 Offset: 0x2046EF0 VA: 0x1820488F0
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	// RVA: 0x2048B10 Offset: 0x2047110 VA: 0x182048B10
	private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	// RVA: 0x2044350 Offset: 0x2042950 VA: 0x182044350
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	// RVA: 0x20442A0 Offset: 0x20428A0 VA: 0x1820442A0
	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	// RVA: 0x20472C0 Offset: 0x20458C0 VA: 0x1820472C0
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: 0x2047E70 Offset: 0x2046470 VA: 0x182047E70
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: -1 Offset: -1
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A320 Offset: 0x748920 VA: 0x18074A320
	|-PostProcessLayer.RenderEffect<object>
	*/

	// RVA: 0x204AAE0 Offset: 0x20490E0 VA: 0x18204AAE0
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	// RVA: 0x204B490 Offset: 0x2049A90 VA: 0x18204B490
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public sealed class PostProcessManager // TypeDefIndex: 12480
{
	// Fields
	private static PostProcessManager s_Instance; // 0x0
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes; // 0x10
	private readonly List<PostProcessVolume> m_Volumes; // 0x18
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x20
	private readonly List<PostProcessEffectSettings> m_BaseSettings; // 0x28
	private readonly List<Collider> m_TempColliders; // 0x30
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes; // 0x38

	// Properties
	public static PostProcessManager instance { get; }

	// Methods

	// RVA: 0x204DD20 Offset: 0x204C320 VA: 0x18204DD20
	public static PostProcessManager get_instance() { }

	// RVA: 0x204DB30 Offset: 0x204C130 VA: 0x18204DB30
	private void .ctor() { }

	// RVA: 0x204B5A0 Offset: 0x2049BA0 VA: 0x18204B5A0
	private void CleanBaseTypes() { }

	// RVA: 0x204C8D0 Offset: 0x204AED0 VA: 0x18204C8D0
	private void ReloadBaseTypes() { }

	// RVA: 0x204B7A0 Offset: 0x2049DA0 VA: 0x18204B7A0
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = True, bool skipZeroWeight = True) { }

	// RVA: 0x204BDA0 Offset: 0x204A3A0 VA: 0x18204BDA0
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	// RVA: 0x204BE60 Offset: 0x204A460 VA: 0x18204BE60
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	// RVA: 0x204C410 Offset: 0x204AA10 VA: 0x18204C410
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	// RVA: 0x204D000 Offset: 0x204B600 VA: 0x18204D000
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x204DAD0 Offset: 0x204C0D0 VA: 0x18204DAD0
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

	// RVA: 0x204C670 Offset: 0x204AC70 VA: 0x18204C670
	private void Register(PostProcessVolume volume, int layer) { }

	// RVA: 0x204C880 Offset: 0x204AE80 VA: 0x18204C880
	internal void Register(PostProcessVolume volume) { }

	// RVA: 0x204D2D0 Offset: 0x204B8D0 VA: 0x18204D2D0
	private void Unregister(PostProcessVolume volume, int layer) { }

	// RVA: 0x204D270 Offset: 0x204B870 VA: 0x18204D270
	internal void Unregister(PostProcessVolume volume) { }

	// RVA: 0x204CD90 Offset: 0x204B390 VA: 0x18204CD90
	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	// RVA: 0x204D460 Offset: 0x204BA60 VA: 0x18204D460
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	// RVA: 0x204C000 Offset: 0x204A600 VA: 0x18204C000
	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x204D160 Offset: 0x204B760 VA: 0x18204D160
	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 12482
{
	// Fields
	[Tooltip("A list of all settings currently stored in this profile.")]
	public List<PostProcessEffectSettings> settings; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x204E3A0 Offset: 0x204C9A0 VA: 0x18204E3A0
	private void OnEnable() { }

	// RVA: -1 Offset: -1
	public T AddSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A540 Offset: 0x748B40 VA: 0x18074A540
	|-PostProcessProfile.AddSettings<object>
	*/

	// RVA: 0x204DF90 Offset: 0x204C590 VA: 0x18204DF90
	public PostProcessEffectSettings AddSettings(Type type) { }

	// RVA: 0x204E160 Offset: 0x204C760 VA: 0x18204E160
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	// RVA: -1 Offset: -1
	public void RemoveSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A7D0 Offset: 0x748DD0 VA: 0x18074A7D0
	|-PostProcessProfile.RemoveSettings<object>
	*/

	// RVA: 0x204E4C0 Offset: 0x204CAC0 VA: 0x18204E4C0
	public void RemoveSettings(Type type) { }

	// RVA: -1 Offset: -1
	public bool HasSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A770 Offset: 0x748D70 VA: 0x18074A770
	|-PostProcessProfile.HasSettings<object>
	*/

	// RVA: 0x204E230 Offset: 0x204C830 VA: 0x18204E230
	public bool HasSettings(Type type) { }

	// RVA: -1 Offset: -1
	public T GetSetting<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A5F0 Offset: 0x748BF0 VA: 0x18074A5F0
	|-PostProcessProfile.GetSetting<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetSettings<T>(out T outSetting) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74A830 Offset: 0x748E30 VA: 0x18074A830
	|-PostProcessProfile.TryGetSettings<object>
	*/

	// RVA: 0x204E620 Offset: 0x204CC20 VA: 0x18204E620
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public sealed class PostProcessRenderContext // TypeDefIndex: 12484
{
	// Fields
	private Camera m_Camera; // 0x10
	[CompilerGenerated]
	private CommandBuffer <command>k__BackingField; // 0x18
	[CompilerGenerated]
	private RenderTargetIdentifier <source>k__BackingField; // 0x20
	[CompilerGenerated]
	private RenderTargetIdentifier <destination>k__BackingField; // 0x48
	[CompilerGenerated]
	private RenderTextureFormat <sourceFormat>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <flip>k__BackingField; // 0x74
	[CompilerGenerated]
	private PostProcessResources <resources>k__BackingField; // 0x78
	[CompilerGenerated]
	private PropertySheetFactory <propertySheets>k__BackingField; // 0x80
	[CompilerGenerated]
	private Dictionary<string, object> <userData>k__BackingField; // 0x88
	[CompilerGenerated]
	private PostProcessDebugLayer <debugLayer>k__BackingField; // 0x90
	[CompilerGenerated]
	private int <width>k__BackingField; // 0x98
	[CompilerGenerated]
	private int <height>k__BackingField; // 0x9C
	[CompilerGenerated]
	private bool <stereoActive>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <xrActiveEye>k__BackingField; // 0xA4
	[CompilerGenerated]
	private int <numberOfEyes>k__BackingField; // 0xA8
	[CompilerGenerated]
	private PostProcessRenderContext.StereoRenderingMode <stereoRenderingMode>k__BackingField; // 0xAC
	[CompilerGenerated]
	private int <screenWidth>k__BackingField; // 0xB0
	[CompilerGenerated]
	private int <screenHeight>k__BackingField; // 0xB4
	[CompilerGenerated]
	private bool <isSceneView>k__BackingField; // 0xB8
	[CompilerGenerated]
	private PostProcessLayer.Antialiasing <antialiasing>k__BackingField; // 0xBC
	[CompilerGenerated]
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField; // 0xC0
	internal PropertySheet uberSheet; // 0xC8
	internal Texture autoExposureTexture; // 0xD0
	internal LogHistogram logHistogram; // 0xD8
	internal Texture logLut; // 0xE0
	internal AutoExposure autoExposure; // 0xE8
	internal int bloomBufferNameID; // 0xF0
	internal bool physicalCamera; // 0xF4
	private RenderTextureDescriptor m_sourceDescriptor; // 0xF8

	// Properties
	public Camera camera { get; set; }
	public CommandBuffer command { get; set; }
	public RenderTargetIdentifier source { get; set; }
	public RenderTargetIdentifier destination { get; set; }
	public RenderTextureFormat sourceFormat { get; set; }
	public bool flip { get; set; }
	public PostProcessResources resources { get; set; }
	public PropertySheetFactory propertySheets { get; set; }
	public Dictionary<string, object> userData { get; set; }
	public PostProcessDebugLayer debugLayer { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public bool stereoActive { get; set; }
	public int xrActiveEye { get; set; }
	public int numberOfEyes { get; set; }
	public PostProcessRenderContext.StereoRenderingMode stereoRenderingMode { get; set; }
	public int screenWidth { get; set; }
	public int screenHeight { get; set; }
	public bool isSceneView { get; set; }
	public PostProcessLayer.Antialiasing antialiasing { get; set; }
	public TemporalAntialiasing temporalAntialiasing { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Camera get_camera() { }

	// RVA: 0x204EEB0 Offset: 0x204D4B0 VA: 0x18204EEB0
	public void set_camera(Camera value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public CommandBuffer get_command() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_command(CommandBuffer value) { }

	[CompilerGenerated]
	// RVA: 0x204EE80 Offset: 0x204D480 VA: 0x18204EE80
	public RenderTargetIdentifier get_source() { }

	[CompilerGenerated]
	// RVA: 0x204F0D0 Offset: 0x204D6D0 VA: 0x18204F0D0
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	// RVA: 0x204EE50 Offset: 0x204D450 VA: 0x18204EE50
	public RenderTargetIdentifier get_destination() { }

	[CompilerGenerated]
	// RVA: 0x204F060 Offset: 0x204D660 VA: 0x18204F060
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGenerated]
	// RVA: 0x4A4300 Offset: 0x4A2900 VA: 0x1804A4300
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGenerated]
	// RVA: 0x1C3ABF0 Offset: 0x1C391F0 VA: 0x181C3ABF0
	public bool get_flip() { }

	[CompilerGenerated]
	// RVA: 0x204F080 Offset: 0x204D680 VA: 0x18204F080
	public void set_flip(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public PostProcessResources get_resources() { }

	[CompilerGenerated]
	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	internal void set_resources(PostProcessResources value) { }

	[CompilerGenerated]
	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGenerated]
	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public Dictionary<string, object> get_userData() { }

	[CompilerGenerated]
	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	private void set_userData(Dictionary<string, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGenerated]
	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGenerated]
	// RVA: 0x12ECB50 Offset: 0x12EB150 VA: 0x1812ECB50
	public int get_width() { }

	[CompilerGenerated]
	// RVA: 0x5266C0 Offset: 0x524CC0 VA: 0x1805266C0
	private void set_width(int value) { }

	[CompilerGenerated]
	// RVA: 0x17251D0 Offset: 0x17237D0 VA: 0x1817251D0
	public int get_height() { }

	[CompilerGenerated]
	// RVA: 0x204F090 Offset: 0x204D690 VA: 0x18204F090
	private void set_height(int value) { }

	[CompilerGenerated]
	// RVA: 0x156F940 Offset: 0x156DF40 VA: 0x18156F940
	public bool get_stereoActive() { }

	[CompilerGenerated]
	// RVA: 0x163E120 Offset: 0x163C720 VA: 0x18163E120
	private void set_stereoActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x53C820 Offset: 0x53AE20 VA: 0x18053C820
	public int get_xrActiveEye() { }

	[CompilerGenerated]
	// RVA: 0x204F0F0 Offset: 0x204D6F0 VA: 0x18204F0F0
	public void set_xrActiveEye(int value) { }

	[CompilerGenerated]
	// RVA: 0x1C59660 Offset: 0x1C57C60 VA: 0x181C59660
	public int get_numberOfEyes() { }

	[CompilerGenerated]
	// RVA: 0x204F0B0 Offset: 0x204D6B0 VA: 0x18204F0B0
	private void set_numberOfEyes(int value) { }

	[CompilerGenerated]
	// RVA: 0x3A3480 Offset: 0x3A1A80 VA: 0x1803A3480
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGenerated]
	// RVA: 0x168CD00 Offset: 0x168B300 VA: 0x18168CD00
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGenerated]
	// RVA: 0x3A35F0 Offset: 0x3A1BF0 VA: 0x1803A35F0
	public int get_screenWidth() { }

	[CompilerGenerated]
	// RVA: 0x163E0B0 Offset: 0x163C6B0 VA: 0x18163E0B0
	private void set_screenWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x3A35B0 Offset: 0x3A1BB0 VA: 0x1803A35B0
	public int get_screenHeight() { }

	[CompilerGenerated]
	// RVA: 0x204F0C0 Offset: 0x204D6C0 VA: 0x18204F0C0
	private void set_screenHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x204EE70 Offset: 0x204D470 VA: 0x18204EE70
	public bool get_isSceneView() { }

	[CompilerGenerated]
	// RVA: 0x204F0A0 Offset: 0x204D6A0 VA: 0x18204F0A0
	internal void set_isSceneView(bool value) { }

	[CompilerGenerated]
	// RVA: 0x145DAA0 Offset: 0x145C0A0 VA: 0x18145DAA0
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGenerated]
	// RVA: 0x204EEA0 Offset: 0x204D4A0 VA: 0x18204EEA0
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGenerated]
	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	// RVA: 0x204EAC0 Offset: 0x204D0C0 VA: 0x18204EAC0
	public void Reset() { }

	// RVA: 0x204EA20 Offset: 0x204D020 VA: 0x18204EA20
	public bool IsTemporalAntialiasingActive() { }

	// RVA: 0x204E9F0 Offset: 0x204CFF0 VA: 0x18204E9F0
	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	// RVA: 0x204EA60 Offset: 0x204D060 VA: 0x18204EA60
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x204E6A0 Offset: 0x204CCA0 VA: 0x18204E6A0
	internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	// RVA: 0x204E850 Offset: 0x204CE50 VA: 0x18204E850
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x204E960 Offset: 0x204CF60 VA: 0x18204E960
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x204ED20 Offset: 0x204D320 VA: 0x18204ED20
	public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public sealed class PostProcessResources : ScriptableObject // TypeDefIndex: 12488
{
	// Fields
	public Texture2D[] blueNoise64; // 0x18
	public Texture2D[] blueNoise256; // 0x20
	public PostProcessResources.SMAALuts smaaLuts; // 0x28
	public PostProcessResources.Shaders shaders; // 0x30
	public PostProcessResources.ComputeShaders computeShaders; // 0x38

	// Methods

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[ExecuteAlways]
[AddComponentMenu("Rendering/Post-process Volume", 1001)]
public sealed class PostProcessVolume : MonoBehaviour // TypeDefIndex: 12489
{
	// Fields
	public PostProcessProfile sharedProfile; // 0x20
	[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
	public bool isGlobal; // 0x28
	[Min(0)]
	[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
	public float blendDistance; // 0x2C
	[Range(0, 1)]
	[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
	public float weight; // 0x30
	[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
	public float priority; // 0x34
	private int m_PreviousLayer; // 0x38
	private float m_PreviousPriority; // 0x3C
	private List<Collider> m_TempColliders; // 0x40
	private PostProcessProfile m_InternalProfile; // 0x48

	// Properties
	public PostProcessProfile profile { get; set; }
	internal PostProcessProfile profileRef { get; }
	internal int previousLayer { get; }

	// Methods

	// RVA: 0x204FC00 Offset: 0x204E200 VA: 0x18204FC00
	public PostProcessProfile get_profile() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_profile(PostProcessProfile value) { }

	// RVA: 0x204FB80 Offset: 0x204E180 VA: 0x18204FB80
	internal PostProcessProfile get_profileRef() { }

	// RVA: 0x204F100 Offset: 0x204D700 VA: 0x18204F100
	public bool HasInstantiatedProfile() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	internal int get_previousLayer() { }

	// RVA: 0x204F9D0 Offset: 0x204DFD0 VA: 0x18204F9D0
	private void OnEnable() { }

	// RVA: 0x204F150 Offset: 0x204D750 VA: 0x18204F150
	private void OnDisable() { }

	// RVA: 0x204FAB0 Offset: 0x204E0B0 VA: 0x18204FAB0
	private void Update() { }

	// RVA: 0x204F1C0 Offset: 0x204D7C0 VA: 0x18204F1C0
	private void OnDrawGizmos() { }

	// RVA: 0x204FB70 Offset: 0x204E170 VA: 0x18204FB70
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public static class ColorUtilities // TypeDefIndex: 12490
{
	// Fields
	private const float logC_cut = 0.011361;
	private const float logC_a = 5.555556;
	private const float logC_b = 0.047996;
	private const float logC_c = 0.244161;
	private const float logC_d = 0.386036;
	private const float logC_e = 5.301883;
	private const float logC_f = 0.092819;

	// Methods

	// RVA: 0x203ED90 Offset: 0x203D390 VA: 0x18203ED90
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x203E9A0 Offset: 0x203CFA0 VA: 0x18203E9A0
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x203EBC0 Offset: 0x203D1C0 VA: 0x18203EBC0
	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	// RVA: 0x203EB50 Offset: 0x203D150 VA: 0x18203EB50
	public static Vector3 ColorToLift(Vector4 color) { }

	// RVA: 0x203EAA0 Offset: 0x203D0A0 VA: 0x18203EAA0
	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	// RVA: 0x203EA30 Offset: 0x203D030 VA: 0x18203EA30
	public static Vector3 ColorToGain(Vector4 color) { }

	// RVA: 0x203ED30 Offset: 0x203D330 VA: 0x18203ED30
	public static float LogCToLinear(float x) { }

	// RVA: 0x203ECE0 Offset: 0x203D2E0 VA: 0x18203ECE0
	public static float LinearToLogC(float x) { }

	// RVA: 0x203EDC0 Offset: 0x203D3C0 VA: 0x18203EDC0
	public static uint ToHex(Color c) { }

	// RVA: 0x203EE50 Offset: 0x203D450 VA: 0x18203EE50
	public static Color ToRGBA(uint hex) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public class HableCurve // TypeDefIndex: 12494
{
	// Fields
	[CompilerGenerated]
	private float <whitePoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <inverseWhitePoint>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <x0>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <x1>k__BackingField; // 0x1C
	private readonly HableCurve.Segment[] m_Segments; // 0x20
	public readonly HableCurve.Uniforms uniforms; // 0x28

	// Properties
	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	internal float x0 { get; set; }
	internal float x1 { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_whitePoint() { }

	[CompilerGenerated]
	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	private void set_whitePoint(float value) { }

	[CompilerGenerated]
	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_inverseWhitePoint() { }

	[CompilerGenerated]
	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	private void set_inverseWhitePoint(float value) { }

	[CompilerGenerated]
	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70
	internal float get_x0() { }

	[CompilerGenerated]
	// RVA: 0x3A4C30 Offset: 0x3A3230 VA: 0x1803A4C30
	private void set_x0(float value) { }

	[CompilerGenerated]
	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0
	internal float get_x1() { }

	[CompilerGenerated]
	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450
	private void set_x1(float value) { }

	// RVA: 0x203F8F0 Offset: 0x203DEF0 VA: 0x18203F8F0
	public void .ctor() { }

	// RVA: 0x203F040 Offset: 0x203D640 VA: 0x18203F040
	public float Eval(float x) { }

	// RVA: 0x203F640 Offset: 0x203DC40 VA: 0x18203F640
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x203F0E0 Offset: 0x203D6E0 VA: 0x18203F0E0
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x203F880 Offset: 0x203DE80 VA: 0x18203F880
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x203EF90 Offset: 0x203D590 VA: 0x18203EF90
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x203EFF0 Offset: 0x203D5F0 VA: 0x18203EFF0
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public static class HaltonSeq // TypeDefIndex: 12495
{
	// Methods

	// RVA: 0x203FA40 Offset: 0x203E040 VA: 0x18203FA40
	public static float Get(int index, int radix) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
internal sealed class LogHistogram // TypeDefIndex: 12496
{
	// Fields
	public const int rangeMin = -9;
	public const int rangeMax = 9;
	private const int k_Bins = 128;
	[CompilerGenerated]
	private ComputeBuffer <data>k__BackingField; // 0x10

	// Properties
	public ComputeBuffer data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ComputeBuffer get_data() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_data(ComputeBuffer value) { }

	// RVA: 0x2040990 Offset: 0x203EF90 VA: 0x182040990
	public void Generate(PostProcessRenderContext context) { }

	// RVA: 0x2040E30 Offset: 0x203F430 VA: 0x182040E30
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	// RVA: 0x2040E80 Offset: 0x203F480 VA: 0x182040E80
	public void Release() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
internal static class MeshUtilities // TypeDefIndex: 12497
{
	// Fields
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; // 0x8

	// Methods

	// RVA: 0x2041390 Offset: 0x203F990 VA: 0x182041390
	private static void .cctor() { }

	// RVA: 0x2040F60 Offset: 0x203F560 VA: 0x182040F60
	internal static Mesh GetColliderMesh(Collider collider) { }

	// RVA: 0x2041210 Offset: 0x203F810 VA: 0x182041210
	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	// RVA: 0x2040EC0 Offset: 0x203F4C0 VA: 0x182040EC0
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Extension]
internal static class PostProcessEffectRendererExtensions // TypeDefIndex: 12498
{
	// Methods

	[Extension]
	// RVA: 0x20436D0 Offset: 0x2041CD0 VA: 0x1820436D0
	public static Exception RenderOrLog(PostProcessEffectRenderer self, PostProcessRenderContext context) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public sealed class PropertySheet // TypeDefIndex: 12499
{
	// Fields
	[CompilerGenerated]
	private MaterialPropertyBlock <properties>k__BackingField; // 0x10
	[CompilerGenerated]
	private Material <material>k__BackingField; // 0x18

	// Properties
	public MaterialPropertyBlock properties { get; set; }
	internal Material material { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public MaterialPropertyBlock get_properties() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_properties(MaterialPropertyBlock value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal Material get_material() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_material(Material value) { }

	// RVA: 0x2050500 Offset: 0x204EB00 VA: 0x182050500
	internal void .ctor(Material material) { }

	// RVA: 0x2050420 Offset: 0x204EA20 VA: 0x182050420
	public void ClearKeywords() { }

	// RVA: 0x2050470 Offset: 0x204EA70 VA: 0x182050470
	public void EnableKeyword(string keyword) { }

	// RVA: 0x2050450 Offset: 0x204EA50 VA: 0x182050450
	public void DisableKeyword(string keyword) { }

	// RVA: 0x2050490 Offset: 0x204EA90 VA: 0x182050490
	internal void Release() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
public sealed class PropertySheetFactory // TypeDefIndex: 12500
{
	// Fields
	private readonly Dictionary<Shader, PropertySheet> m_Sheets; // 0x10

	// Methods

	// RVA: 0x20503A0 Offset: 0x204E9A0 VA: 0x1820503A0
	public void .ctor() { }

	[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
	// RVA: 0x20500A0 Offset: 0x204E6A0 VA: 0x1820500A0
	public PropertySheet Get(string shaderName) { }

	// RVA: 0x204FE80 Offset: 0x204E480 VA: 0x18204FE80
	public PropertySheet Get(Shader shader) { }

	// RVA: 0x2050180 Offset: 0x204E780 VA: 0x182050180
	public void Release() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Extension]
public static class RuntimeUtilities // TypeDefIndex: 12504
{
	// Fields
	private static Texture2D m_WhiteTexture; // 0x0
	private static Texture3D m_WhiteTexture3D; // 0x8
	private static Texture2D m_BlackTexture; // 0x10
	private static Texture3D m_BlackTexture3D; // 0x18
	private static Texture2D m_TransparentTexture; // 0x20
	private static Texture3D m_TransparentTexture3D; // 0x28
	private static Dictionary<int, Texture2D> m_LutStrips; // 0x30
	private static PostProcessResources s_Resources; // 0x38
	private static Mesh s_FullscreenTriangle; // 0x40
	private static Material s_CopyStdMaterial; // 0x48
	private static Material s_CopyStdFromDoubleWideMaterial; // 0x50
	private static Material s_CopyMaterial; // 0x58
	private static Material s_CopyFromTexArrayMaterial; // 0x60
	private static PropertySheet s_CopySheet; // 0x68
	private static PropertySheet s_CopyFromTexArraySheet; // 0x70
	private static IEnumerable<Type> m_AssemblyTypes; // 0x78

	// Properties
	public static Texture2D whiteTexture { get; }
	public static Texture3D whiteTexture3D { get; }
	public static Texture2D blackTexture { get; }
	public static Texture3D blackTexture3D { get; }
	public static Texture2D transparentTexture { get; }
	public static Texture3D transparentTexture3D { get; }
	public static Mesh fullscreenTriangle { get; }
	public static Material copyStdMaterial { get; }
	public static Material copyStdFromDoubleWideMaterial { get; }
	public static Material copyMaterial { get; }
	public static Material copyFromTexArrayMaterial { get; }
	public static PropertySheet copySheet { get; }
	public static PropertySheet copyFromTexArraySheet { get; }
	public static bool scriptableRenderPipelineActive { get; }
	public static bool supportsDeferredShading { get; }
	public static bool supportsDepthNormals { get; }
	public static bool isSinglePassStereoEnabled { get; }
	public static bool isVREnabled { get; }
	public static bool isAndroidOpenGL { get; }
	public static bool isWebNonWebGPU { get; }
	public static RenderTextureFormat defaultHDRRenderTextureFormat { get; }
	public static bool isLinearColorSpace { get; }

	// Methods

	// RVA: 0x2054A80 Offset: 0x2053080 VA: 0x182054A80
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x2054890 Offset: 0x2052E90 VA: 0x182054890
	public static Texture3D get_whiteTexture3D() { }

	// RVA: 0x2053210 Offset: 0x2051810 VA: 0x182053210
	public static Texture2D get_blackTexture() { }

	// RVA: 0x2053020 Offset: 0x2051620 VA: 0x182053020
	public static Texture3D get_blackTexture3D() { }

	// RVA: 0x20546D0 Offset: 0x2052CD0 VA: 0x1820546D0
	public static Texture2D get_transparentTexture() { }

	// RVA: 0x20544F0 Offset: 0x2052AF0 VA: 0x1820544F0
	public static Texture3D get_transparentTexture3D() { }

	// RVA: 0x20526D0 Offset: 0x2050CD0 VA: 0x1820526D0
	public static Texture2D GetLutStrip(int size) { }

	// RVA: 0x2053E20 Offset: 0x2052420 VA: 0x182053E20
	public static Mesh get_fullscreenTriangle() { }

	// RVA: 0x2053C70 Offset: 0x2052270 VA: 0x182053C70
	public static Material get_copyStdMaterial() { }

	// RVA: 0x2053AC0 Offset: 0x20520C0 VA: 0x182053AC0
	public static Material get_copyStdFromDoubleWideMaterial() { }

	// RVA: 0x2053800 Offset: 0x2051E00 VA: 0x182053800
	public static Material get_copyMaterial() { }

	// RVA: 0x20533D0 Offset: 0x20519D0 VA: 0x1820533D0
	public static Material get_copyFromTexArrayMaterial() { }

	// RVA: 0x20539B0 Offset: 0x2051FB0 VA: 0x1820539B0
	public static PropertySheet get_copySheet() { }

	// RVA: 0x2053580 Offset: 0x2051B80 VA: 0x182053580
	public static PropertySheet get_copyFromTexArraySheet() { }

	// RVA: 0x2054CC0 Offset: 0x20532C0 VA: 0x182054CC0
	internal static bool isValidResources() { }

	// RVA: 0x2052DB0 Offset: 0x20513B0 VA: 0x182052DB0
	internal static void UpdateResources(PostProcessResources resources) { }

	[Extension]
	// RVA: 0x2052D60 Offset: 0x2051360 VA: 0x182052D60
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[Extension]
	// RVA: 0x2052C70 Offset: 0x2051270 VA: 0x182052C70
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Extension]
	// RVA: 0x2052CD0 Offset: 0x20512D0 VA: 0x182052CD0
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Extension]
	// RVA: 0x2051690 Offset: 0x204FC90 VA: 0x182051690
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport, bool preserveDepth = False) { }

	[Extension]
	// RVA: 0x2050DA0 Offset: 0x204F3A0 VA: 0x182050DA0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport, bool preserveDepth = False) { }

	[Extension]
	// RVA: 0x2051330 Offset: 0x204F930 VA: 0x182051330
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport, bool preserveDepth = False) { }

	[Extension]
	// RVA: 0x2050580 Offset: 0x204EB80 VA: 0x182050580
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[Extension]
	// RVA: 0x2050960 Offset: 0x204EF60 VA: 0x182050960
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[Extension]
	// RVA: 0x2050750 Offset: 0x204ED50 VA: 0x182050750
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[Extension]
	// RVA: 0x2050B90 Offset: 0x204F190 VA: 0x182050B90
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[Extension]
	// RVA: 0x2051040 Offset: 0x204F640 VA: 0x182051040
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[Extension]
	// RVA: 0x2051460 Offset: 0x204FA60 VA: 0x182051460
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[Extension]
	// RVA: 0x2051A40 Offset: 0x2050040 VA: 0x182051A40
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[Extension]
	// RVA: 0x2051950 Offset: 0x204FF50 VA: 0x182051950
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	// RVA: 0x2051B10 Offset: 0x2050110 VA: 0x182051B10
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	// RVA: 0x2054370 Offset: 0x2052970 VA: 0x182054370
	public static bool get_scriptableRenderPipelineActive() { }

	// RVA: 0x20543F0 Offset: 0x20529F0 VA: 0x1820543F0
	public static bool get_supportsDeferredShading() { }

	// RVA: 0x2054470 Offset: 0x2052A70 VA: 0x182054470
	public static bool get_supportsDepthNormals() { }

	// RVA: 0x20542D0 Offset: 0x20528D0 VA: 0x1820542D0
	public static bool get_isSinglePassStereoEnabled() { }

	// RVA: 0x2054300 Offset: 0x2052900 VA: 0x182054300
	public static bool get_isVREnabled() { }

	// RVA: 0x2054250 Offset: 0x2052850 VA: 0x182054250
	public static bool get_isAndroidOpenGL() { }

	// RVA: 0x2054310 Offset: 0x2052910 VA: 0x182054310
	public static bool get_isWebNonWebGPU() { }

	// RVA: 0x458E50 Offset: 0x457450 VA: 0x180458E50
	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	// RVA: 0x2054CA0 Offset: 0x20532A0 VA: 0x182054CA0
	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	// RVA: 0x2054C40 Offset: 0x2053240 VA: 0x182054C40
	internal static bool hasAlpha(RenderTextureFormat format) { }

	// RVA: 0x2051FA0 Offset: 0x20505A0 VA: 0x182051FA0
	public static void Destroy(Object obj) { }

	// RVA: 0x20542B0 Offset: 0x20528B0 VA: 0x1820542B0
	public static bool get_isLinearColorSpace() { }

	// RVA: 0x2052B40 Offset: 0x2051140 VA: 0x182052B40
	public static bool IsResolvedDepthAvailable(Camera camera) { }

	// RVA: 0x2051C80 Offset: 0x2050280 VA: 0x182051C80
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	// RVA: 0x2051EC0 Offset: 0x20504C0 VA: 0x182051EC0
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	// RVA: 0x2052AD0 Offset: 0x20510D0 VA: 0x182052AD0
	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	// RVA: 0x2052BB0 Offset: 0x20511B0 VA: 0x182052BB0
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	// RVA: 0x2052A20 Offset: 0x2051020 VA: 0x182052A20
	public static bool IsDynamicResolutionEnabled(Camera camera) { }

	[IteratorStateMachine(typeof(RuntimeUtilities.<GetAllSceneObjects>d__86<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7980C0 Offset: 0x7966C0 VA: 0x1807980C0
	|-RuntimeUtilities.GetAllSceneObjects<object>
	*/

	// RVA: -1 Offset: -1
	public static void CreateIfNull<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x798070 Offset: 0x796670 VA: 0x180798070
	|-RuntimeUtilities.CreateIfNull<object>
	*/

	// RVA: 0x2052020 Offset: 0x2050620 VA: 0x182052020
	public static float Exp2(float x) { }

	// RVA: 0x2052530 Offset: 0x2050B30 VA: 0x182052530
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x20523C0 Offset: 0x20509C0 VA: 0x1820523C0
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x2052030 Offset: 0x2050630 VA: 0x182052030
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	// RVA: 0x20521D0 Offset: 0x20507D0 VA: 0x1820521D0
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	// RVA: -1 Offset: -1
	public static IEnumerable<Type> GetAllTypesDerivedFrom<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x798120 Offset: 0x796720 VA: 0x180798120
	|-RuntimeUtilities.GetAllTypesDerivedFrom<object>
	|-RuntimeUtilities.GetAllTypesDerivedFrom<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7982D0 Offset: 0x7968D0 VA: 0x1807982D0
	|-RuntimeUtilities.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7986C0 Offset: 0x796CC0 VA: 0x1807986C0
	|-RuntimeUtilities.GetMemberAttributes<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7983B0 Offset: 0x7969B0 VA: 0x1807983B0
	|-RuntimeUtilities.GetFieldPath<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2052F90 Offset: 0x2051590 VA: 0x182052F90
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
internal static class ShaderIDs // TypeDefIndex: 12505
{
	// Fields
	internal static readonly int MainTex; // 0x0
	internal static readonly int Jitter; // 0x4
	internal static readonly int Sharpness; // 0x8
	internal static readonly int FinalBlendParameters; // 0xC
	internal static readonly int HistoryTex; // 0x10
	internal static readonly int SMAA_Flip; // 0x14
	internal static readonly int SMAA_Flop; // 0x18
	internal static readonly int AOParams; // 0x1C
	internal static readonly int AOColor; // 0x20
	internal static readonly int OcclusionTexture1; // 0x24
	internal static readonly int OcclusionTexture2; // 0x28
	internal static readonly int SAOcclusionTexture; // 0x2C
	internal static readonly int MSVOcclusionTexture; // 0x30
	internal static readonly int DepthCopy; // 0x34
	internal static readonly int LinearDepth; // 0x38
	internal static readonly int LowDepth1; // 0x3C
	internal static readonly int LowDepth2; // 0x40
	internal static readonly int LowDepth3; // 0x44
	internal static readonly int LowDepth4; // 0x48
	internal static readonly int TiledDepth1; // 0x4C
	internal static readonly int TiledDepth2; // 0x50
	internal static readonly int TiledDepth3; // 0x54
	internal static readonly int TiledDepth4; // 0x58
	internal static readonly int Occlusion1; // 0x5C
	internal static readonly int Occlusion2; // 0x60
	internal static readonly int Occlusion3; // 0x64
	internal static readonly int Occlusion4; // 0x68
	internal static readonly int Combined1; // 0x6C
	internal static readonly int Combined2; // 0x70
	internal static readonly int Combined3; // 0x74
	internal static readonly int SSRResolveTemp; // 0x78
	internal static readonly int Noise; // 0x7C
	internal static readonly int Test; // 0x80
	internal static readonly int Resolve; // 0x84
	internal static readonly int History; // 0x88
	internal static readonly int ViewMatrix; // 0x8C
	internal static readonly int InverseViewMatrix; // 0x90
	internal static readonly int ScreenSpaceProjectionMatrix; // 0x94
	internal static readonly int Params2; // 0x98
	internal static readonly int FogColor; // 0x9C
	internal static readonly int FogParams; // 0xA0
	internal static readonly int VelocityScale; // 0xA4
	internal static readonly int MaxBlurRadius; // 0xA8
	internal static readonly int RcpMaxBlurRadius; // 0xAC
	internal static readonly int VelocityTex; // 0xB0
	internal static readonly int Tile2RT; // 0xB4
	internal static readonly int Tile4RT; // 0xB8
	internal static readonly int Tile8RT; // 0xBC
	internal static readonly int TileMaxOffs; // 0xC0
	internal static readonly int TileMaxLoop; // 0xC4
	internal static readonly int TileVRT; // 0xC8
	internal static readonly int NeighborMaxTex; // 0xCC
	internal static readonly int LoopCount; // 0xD0
	internal static readonly int DepthOfFieldTemp; // 0xD4
	internal static readonly int DepthOfFieldTex; // 0xD8
	internal static readonly int Distance; // 0xDC
	internal static readonly int LensCoeff; // 0xE0
	internal static readonly int MaxCoC; // 0xE4
	internal static readonly int RcpMaxCoC; // 0xE8
	internal static readonly int RcpAspect; // 0xEC
	internal static readonly int CoCTex; // 0xF0
	internal static readonly int TaaParams; // 0xF4
	internal static readonly int AutoExposureTex; // 0xF8
	internal static readonly int HistogramBuffer; // 0xFC
	internal static readonly int Params; // 0x100
	internal static readonly int ScaleOffsetRes; // 0x104
	internal static readonly int BloomTex; // 0x108
	internal static readonly int SampleScale; // 0x10C
	internal static readonly int Threshold; // 0x110
	internal static readonly int ColorIntensity; // 0x114
	internal static readonly int Bloom_DirtTex; // 0x118
	internal static readonly int Bloom_Settings; // 0x11C
	internal static readonly int Bloom_Color; // 0x120
	internal static readonly int Bloom_DirtTileOffset; // 0x124
	internal static readonly int ChromaticAberration_Amount; // 0x128
	internal static readonly int ChromaticAberration_SpectralLut; // 0x12C
	internal static readonly int Distortion_CenterScale; // 0x130
	internal static readonly int Distortion_Amount; // 0x134
	internal static readonly int Lut2D; // 0x138
	internal static readonly int Lut3D; // 0x13C
	internal static readonly int Lut3D_Params; // 0x140
	internal static readonly int Lut2D_Params; // 0x144
	internal static readonly int UserLut2D_Params; // 0x148
	internal static readonly int PostExposure; // 0x14C
	internal static readonly int ColorBalance; // 0x150
	internal static readonly int ColorFilter; // 0x154
	internal static readonly int HueSatCon; // 0x158
	internal static readonly int Brightness; // 0x15C
	internal static readonly int ChannelMixerRed; // 0x160
	internal static readonly int ChannelMixerGreen; // 0x164
	internal static readonly int ChannelMixerBlue; // 0x168
	internal static readonly int Lift; // 0x16C
	internal static readonly int InvGamma; // 0x170
	internal static readonly int Gain; // 0x174
	internal static readonly int Curves; // 0x178
	internal static readonly int CustomToneCurve; // 0x17C
	internal static readonly int ToeSegmentA; // 0x180
	internal static readonly int ToeSegmentB; // 0x184
	internal static readonly int MidSegmentA; // 0x188
	internal static readonly int MidSegmentB; // 0x18C
	internal static readonly int ShoSegmentA; // 0x190
	internal static readonly int ShoSegmentB; // 0x194
	internal static readonly int Vignette_Color; // 0x198
	internal static readonly int Vignette_Center; // 0x19C
	internal static readonly int Vignette_Settings; // 0x1A0
	internal static readonly int Vignette_Mask; // 0x1A4
	internal static readonly int Vignette_Opacity; // 0x1A8
	internal static readonly int Vignette_Mode; // 0x1AC
	internal static readonly int Grain_Params1; // 0x1B0
	internal static readonly int Grain_Params2; // 0x1B4
	internal static readonly int GrainTex; // 0x1B8
	internal static readonly int Phase; // 0x1BC
	internal static readonly int GrainNoiseParameters; // 0x1C0
	internal static readonly int LumaInAlpha; // 0x1C4
	internal static readonly int DitheringTex; // 0x1C8
	internal static readonly int Dithering_Coords; // 0x1CC
	internal static readonly int From; // 0x1D0
	internal static readonly int To; // 0x1D4
	internal static readonly int Interp; // 0x1D8
	internal static readonly int TargetColor; // 0x1DC
	internal static readonly int HalfResFinalCopy; // 0x1E0
	internal static readonly int WaveformSource; // 0x1E4
	internal static readonly int WaveformBuffer; // 0x1E8
	internal static readonly int VectorscopeBuffer; // 0x1EC
	internal static readonly int RenderViewportScaleFactor; // 0x1F0
	internal static readonly int UVTransform; // 0x1F4
	internal static readonly int DepthSlice; // 0x1F8
	internal static readonly int UVScaleOffset; // 0x1FC
	internal static readonly int PosScaleOffset; // 0x200

	// Methods

	// RVA: 0x2054D90 Offset: 0x2053390 VA: 0x182054D90
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Serializable]
public sealed class Spline // TypeDefIndex: 12506
{
	// Fields
	public const int k_Precision = 128;
	public const float k_Step = 0.0078125;
	public AnimationCurve curve; // 0x10
	[SerializeField]
	private bool m_Loop; // 0x18
	[SerializeField]
	private float m_ZeroValue; // 0x1C
	[SerializeField]
	private float m_Range; // 0x20
	private AnimationCurve m_InternalLoopingCurve; // 0x28
	private int frameCount; // 0x30
	public float[] cachedData; // 0x38

	// Methods

	// RVA: 0x2058C00 Offset: 0x2057200 VA: 0x182058C00
	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	// RVA: 0x2058870 Offset: 0x2056E70 VA: 0x182058870
	public void Cache(int frame) { }

	// RVA: 0x2058B90 Offset: 0x2057190 VA: 0x182058B90
	public float Evaluate(float t, int length) { }

	// RVA: 0x2058B20 Offset: 0x2057120 VA: 0x182058B20
	public float Evaluate(float t) { }

	// RVA: 0x2058BD0 Offset: 0x20571D0 VA: 0x182058BD0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
internal class TargetPool // TypeDefIndex: 12507
{
	// Fields
	private readonly List<int> m_Pool; // 0x10
	private int m_Current; // 0x18

	// Methods

	// RVA: 0x2058FB0 Offset: 0x20575B0 VA: 0x182058FB0
	internal void .ctor() { }

	// RVA: 0x2058D10 Offset: 0x2057310 VA: 0x182058D10
	internal int Get() { }

	// RVA: 0x2058E60 Offset: 0x2057460 VA: 0x182058E60
	private int Get(int i) { }

	// RVA: 0x2058FA0 Offset: 0x20575A0 VA: 0x182058FA0
	internal void Reset() { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
[Extension]
public static class TextureFormatUtilities // TypeDefIndex: 12508
{
	// Fields
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap; // 0x0
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats; // 0x8
	private static Dictionary<int, bool> s_SupportedTextureFormats; // 0x10

	// Methods

	// RVA: 0x2059560 Offset: 0x2057B60 VA: 0x182059560
	private static void .cctor() { }

	// RVA: 0x2059320 Offset: 0x2057920 VA: 0x182059320
	private static bool IsObsolete(object value) { }

	// RVA: 0x2059160 Offset: 0x2057760 VA: 0x182059160
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	[Extension]
	// RVA: 0x20594D0 Offset: 0x2057AD0 VA: 0x1820594D0
	internal static bool IsSupported(RenderTextureFormat format) { }

	[Extension]
	// RVA: 0x2059440 Offset: 0x2057A40 VA: 0x182059440
	internal static bool IsSupported(TextureFormat format) { }
}

// Namespace: UnityEngine.Rendering.PostProcessing
internal class TextureLerper // TypeDefIndex: 12509
{
	// Fields
	private static TextureLerper m_Instance; // 0x0
	private CommandBuffer m_Command; // 0x10
	private PropertySheetFactory m_PropertySheets; // 0x18
	private PostProcessResources m_Resources; // 0x20
	private List<RenderTexture> m_Recycled; // 0x28
	private List<RenderTexture> m_Actives; // 0x30

	// Properties
	internal static TextureLerper instance { get; }

	// Methods

	// RVA: 0x205B8B0 Offset: 0x2059EB0 VA: 0x18205B8B0
	internal static TextureLerper get_instance() { }

	// RVA: 0x205B800 Offset: 0x2059E00 VA: 0x18205B800
	private void .ctor() { }

	// RVA: 0x205A020 Offset: 0x2058620 VA: 0x18205A020
	internal void BeginFrame(PostProcessRenderContext context) { }

	// RVA: 0x205A2F0 Offset: 0x20588F0 VA: 0x18205A2F0
	internal void EndFrame() { }

	// RVA: 0x205A4F0 Offset: 0x2058AF0 VA: 0x18205A4F0
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = False, bool force3D = False) { }

	// RVA: 0x205A7F0 Offset: 0x2058DF0 VA: 0x18205A7F0
	internal Texture Lerp(Texture from, Texture to, float t) { }

	// RVA: 0x205B020 Offset: 0x2059620 VA: 0x18205B020
	internal Texture Lerp(Texture from, Color to, float t) { }

	// RVA: 0x205A080 Offset: 0x2058680 VA: 0x18205A080
	internal void Clear() { }
}

