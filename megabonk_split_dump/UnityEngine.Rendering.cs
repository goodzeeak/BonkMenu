// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[UsedByNativeCode]
public struct AsyncGPUReadbackRequest // TypeDefIndex: 10054
{
	// Fields
	internal IntPtr m_Ptr; // 0x0
	internal int m_Version; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x234CC90 Offset: 0x234B290 VA: 0x18234CC90
	private static void InvokeCallback(Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj) { }
}

// Namespace: UnityEngine.Rendering
public enum IndexFormat // TypeDefIndex: 10055
{
	// Fields
	public int value__; // 0x0
	public const IndexFormat UInt16 = 0;
	public const IndexFormat UInt32 = 1;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum MeshUpdateFlags // TypeDefIndex: 10056
{
	// Fields
	public int value__; // 0x0
	public const MeshUpdateFlags Default = 0;
	public const MeshUpdateFlags DontValidateIndices = 1;
	public const MeshUpdateFlags DontResetBoneBounds = 2;
	public const MeshUpdateFlags DontNotifyMeshUsers = 4;
	public const MeshUpdateFlags DontRecalculateBounds = 8;
}

// Namespace: UnityEngine.Rendering
public enum VertexAttributeFormat // TypeDefIndex: 10057
{
	// Fields
	public int value__; // 0x0
	public const VertexAttributeFormat Float32 = 0;
	public const VertexAttributeFormat Float16 = 1;
	public const VertexAttributeFormat UNorm8 = 2;
	public const VertexAttributeFormat SNorm8 = 3;
	public const VertexAttributeFormat UNorm16 = 4;
	public const VertexAttributeFormat SNorm16 = 5;
	public const VertexAttributeFormat UInt8 = 6;
	public const VertexAttributeFormat SInt8 = 7;
	public const VertexAttributeFormat UInt16 = 8;
	public const VertexAttributeFormat SInt16 = 9;
	public const VertexAttributeFormat UInt32 = 10;
	public const VertexAttributeFormat SInt32 = 11;
}

// Namespace: UnityEngine.Rendering
[MovedFrom("UnityEngine.Experimental.Rendering")]
public enum VertexAttribute // TypeDefIndex: 10058
{
	// Fields
	public int value__; // 0x0
	public const VertexAttribute Position = 0;
	public const VertexAttribute Normal = 1;
	public const VertexAttribute Tangent = 2;
	public const VertexAttribute Color = 3;
	public const VertexAttribute TexCoord0 = 4;
	public const VertexAttribute TexCoord1 = 5;
	public const VertexAttribute TexCoord2 = 6;
	public const VertexAttribute TexCoord3 = 7;
	public const VertexAttribute TexCoord4 = 8;
	public const VertexAttribute TexCoord5 = 9;
	public const VertexAttribute TexCoord6 = 10;
	public const VertexAttribute TexCoord7 = 11;
	public const VertexAttribute BlendWeight = 12;
	public const VertexAttribute BlendIndices = 13;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferLoadAction // TypeDefIndex: 10059
{
	// Fields
	public int value__; // 0x0
	public const RenderBufferLoadAction Load = 0;
	public const RenderBufferLoadAction Clear = 1;
	public const RenderBufferLoadAction DontCare = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferStoreAction // TypeDefIndex: 10060
{
	// Fields
	public int value__; // 0x0
	public const RenderBufferStoreAction Store = 0;
	public const RenderBufferStoreAction Resolve = 1;
	public const RenderBufferStoreAction StoreAndResolve = 2;
	public const RenderBufferStoreAction DontCare = 3;
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public enum CompareFunction // TypeDefIndex: 10061
{
	// Fields
	public int value__; // 0x0
	public const CompareFunction Disabled = 0;
	public const CompareFunction Never = 1;
	public const CompareFunction Less = 2;
	public const CompareFunction Equal = 3;
	public const CompareFunction LessEqual = 4;
	public const CompareFunction Greater = 5;
	public const CompareFunction NotEqual = 6;
	public const CompareFunction GreaterEqual = 7;
	public const CompareFunction Always = 8;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum ColorWriteMask // TypeDefIndex: 10062
{
	// Fields
	public int value__; // 0x0
	public const ColorWriteMask Alpha = 1;
	public const ColorWriteMask Blue = 2;
	public const ColorWriteMask Green = 4;
	public const ColorWriteMask Red = 8;
	public const ColorWriteMask All = 15;
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public enum StencilOp // TypeDefIndex: 10063
{
	// Fields
	public int value__; // 0x0
	public const StencilOp Keep = 0;
	public const StencilOp Zero = 1;
	public const StencilOp Replace = 2;
	public const StencilOp IncrementSaturate = 3;
	public const StencilOp DecrementSaturate = 4;
	public const StencilOp Invert = 5;
	public const StencilOp IncrementWrap = 6;
	public const StencilOp DecrementWrap = 7;
}

// Namespace: UnityEngine.Rendering
public enum CameraEvent // TypeDefIndex: 10064
{
	// Fields
	public int value__; // 0x0
	public const CameraEvent BeforeDepthTexture = 0;
	public const CameraEvent AfterDepthTexture = 1;
	public const CameraEvent BeforeDepthNormalsTexture = 2;
	public const CameraEvent AfterDepthNormalsTexture = 3;
	public const CameraEvent BeforeGBuffer = 4;
	public const CameraEvent AfterGBuffer = 5;
	public const CameraEvent BeforeLighting = 6;
	public const CameraEvent AfterLighting = 7;
	public const CameraEvent BeforeFinalPass = 8;
	public const CameraEvent AfterFinalPass = 9;
	public const CameraEvent BeforeForwardOpaque = 10;
	public const CameraEvent AfterForwardOpaque = 11;
	public const CameraEvent BeforeImageEffectsOpaque = 12;
	public const CameraEvent AfterImageEffectsOpaque = 13;
	public const CameraEvent BeforeSkybox = 14;
	public const CameraEvent AfterSkybox = 15;
	public const CameraEvent BeforeForwardAlpha = 16;
	public const CameraEvent AfterForwardAlpha = 17;
	public const CameraEvent BeforeImageEffects = 18;
	public const CameraEvent AfterImageEffects = 19;
	public const CameraEvent AfterEverything = 20;
	public const CameraEvent BeforeReflections = 21;
	public const CameraEvent AfterReflections = 22;
	public const CameraEvent BeforeHaloAndLensFlares = 23;
	public const CameraEvent AfterHaloAndLensFlares = 24;
}

// Namespace: UnityEngine.Rendering
internal static class CameraEventUtils // TypeDefIndex: 10065
{
	// Methods

	// RVA: 0x234D6D0 Offset: 0x234BCD0 VA: 0x18234D6D0
	public static bool IsValid(CameraEvent value) { }
}

// Namespace: UnityEngine.Rendering
public enum BuiltinRenderTextureType // TypeDefIndex: 10066
{
	// Fields
	public int value__; // 0x0
	public const BuiltinRenderTextureType PropertyName = -4;
	public const BuiltinRenderTextureType BufferPtr = -3;
	public const BuiltinRenderTextureType RenderTexture = -2;
	public const BuiltinRenderTextureType BindableTexture = -1;
	public const BuiltinRenderTextureType None = 0;
	public const BuiltinRenderTextureType CurrentActive = 1;
	public const BuiltinRenderTextureType CameraTarget = 2;
	public const BuiltinRenderTextureType Depth = 3;
	public const BuiltinRenderTextureType DepthNormals = 4;
	public const BuiltinRenderTextureType ResolvedDepth = 5;
	[Obsolete("Deferred Lighting has been removed, so PrepassNormalsSpec built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassNormalsSpec = 7;
	[Obsolete("Deferred Lighting has been removed, so PrepassLight built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassLight = 8;
	[Obsolete("Deferred Lighting has been removed, so PrepassLightSpec built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassLightSpec = 9;
	public const BuiltinRenderTextureType GBuffer0 = 10;
	public const BuiltinRenderTextureType GBuffer1 = 11;
	public const BuiltinRenderTextureType GBuffer2 = 12;
	public const BuiltinRenderTextureType GBuffer3 = 13;
	public const BuiltinRenderTextureType Reflections = 14;
	public const BuiltinRenderTextureType MotionVectors = 15;
	public const BuiltinRenderTextureType GBuffer4 = 16;
	public const BuiltinRenderTextureType GBuffer5 = 17;
	public const BuiltinRenderTextureType GBuffer6 = 18;
	public const BuiltinRenderTextureType GBuffer7 = 19;
}

// Namespace: UnityEngine.Rendering
public enum ShadowCastingMode // TypeDefIndex: 10067
{
	// Fields
	public int value__; // 0x0
	public const ShadowCastingMode Off = 0;
	public const ShadowCastingMode On = 1;
	public const ShadowCastingMode TwoSided = 2;
	public const ShadowCastingMode ShadowsOnly = 3;
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public enum GraphicsDeviceType // TypeDefIndex: 10068
{
	// Fields
	public int value__; // 0x0
	[Obsolete("OpenGL2 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType OpenGL2 = 0;
	[Obsolete("Direct3D 9 is no longer supported in Unity 2017.2+")]
	public const GraphicsDeviceType Direct3D9 = 1;
	public const GraphicsDeviceType Direct3D11 = 2;
	[Obsolete("PS3 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType PlayStation3 = 3;
	public const GraphicsDeviceType Null = 4;
	[Obsolete("Xbox360 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType Xbox360 = 6;
	[Obsolete("OpenGL ES 2.0 is no longer supported in Unity 2023.1")]
	public const GraphicsDeviceType OpenGLES2 = 8;
	public const GraphicsDeviceType OpenGLES3 = 11;
	[Obsolete("PVita is no longer supported as of Unity 2018")]
	public const GraphicsDeviceType PlayStationVita = 12;
	public const GraphicsDeviceType PlayStation4 = 13;
	public const GraphicsDeviceType XboxOne = 14;
	[Obsolete("PlayStationMobile is no longer supported in Unity 5.3+")]
	public const GraphicsDeviceType PlayStationMobile = 15;
	public const GraphicsDeviceType Metal = 16;
	public const GraphicsDeviceType OpenGLCore = 17;
	public const GraphicsDeviceType Direct3D12 = 18;
	[Obsolete("Nintendo 3DS support is unavailable since 2018.1")]
	public const GraphicsDeviceType N3DS = 19;
	public const GraphicsDeviceType Vulkan = 21;
	public const GraphicsDeviceType Switch = 22;
	public const GraphicsDeviceType XboxOneD3D12 = 23;
	public const GraphicsDeviceType GameCoreXboxOne = 24;
	[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
	public const GraphicsDeviceType GameCoreScarlett = -1;
	public const GraphicsDeviceType GameCoreXboxSeries = 25;
	public const GraphicsDeviceType PlayStation5 = 26;
	public const GraphicsDeviceType PlayStation5NGGC = 27;
	public const GraphicsDeviceType WebGPU = 28;
}

// Namespace: UnityEngine.Rendering
public struct SubMeshDescriptor // TypeDefIndex: 10069
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Bounds <bounds>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private MeshTopology <topology>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <indexStart>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <indexCount>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <baseVertex>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <firstVertex>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <vertexCount>k__BackingField; // 0x2C

	// Properties
	public Bounds bounds { get; set; }
	public MeshTopology topology { get; set; }
	public int indexStart { get; set; }
	public int indexCount { get; set; }
	public int baseVertex { get; set; }
	public int firstVertex { get; set; }
	public int vertexCount { get; set; }

	// Methods

	// RVA: 0x2363490 Offset: 0x2361A90 VA: 0x182363490
	public void .ctor(int indexStart, int indexCount, MeshTopology topology = 0) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1105BA0 Offset: 0x11041A0 VA: 0x181105BA0
	public Bounds get_bounds() { }

	[CompilerGenerated]
	// RVA: 0x23634D0 Offset: 0x2361AD0 VA: 0x1823634D0
	public void set_bounds(Bounds value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public MeshTopology get_topology() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_topology(MeshTopology value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_indexStart() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_indexStart(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_indexCount() { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_indexCount(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public int get_baseVertex() { }

	[CompilerGenerated]
	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_baseVertex(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_firstVertex() { }

	[CompilerGenerated]
	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_firstVertex(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_vertexCount() { }

	[CompilerGenerated]
	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	public void set_vertexCount(int value) { }

	// RVA: 0x2363130 Offset: 0x2361730 VA: 0x182363130 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor> // TypeDefIndex: 10070
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VertexAttribute <attribute>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VertexAttributeFormat <format>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <dimension>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <stream>k__BackingField; // 0xC

	// Properties
	public VertexAttribute attribute { get; set; }
	public VertexAttributeFormat format { get; set; }
	public int dimension { get; set; }
	public int stream { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public VertexAttribute get_attribute() { }

	[CompilerGenerated]
	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_attribute(VertexAttribute value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public VertexAttributeFormat get_format() { }

	[CompilerGenerated]
	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_format(VertexAttributeFormat value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_dimension() { }

	[CompilerGenerated]
	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_dimension(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_stream() { }

	[CompilerGenerated]
	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_stream(int value) { }

	// RVA: 0x16AE250 Offset: 0x16AC850 VA: 0x1816AE250
	public void .ctor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	// RVA: 0x2369B50 Offset: 0x2368150 VA: 0x182369B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x2369B30 Offset: 0x2368130 VA: 0x182369B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2369A70 Offset: 0x2368070 VA: 0x182369A70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x230F250 Offset: 0x230D850 VA: 0x18230F250 Slot: 4
	public bool Equals(VertexAttributeDescriptor other) { }
}

// Namespace: UnityEngine.Rendering
public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 10071
{
	// Fields
	public const int AllDepthSlices = -1;
	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20

	// Methods

	// RVA: 0x235EAB0 Offset: 0x235D0B0 VA: 0x18235EAB0
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x235EA30 Offset: 0x235D030 VA: 0x18235EA30
	public void .ctor(int nameID) { }

	// RVA: 0x235EA80 Offset: 0x235D080 VA: 0x18235EA80
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x235EAD0 Offset: 0x235D0D0 VA: 0x18235EAD0
	public void .ctor(Texture tex) { }

	// RVA: 0x235EA50 Offset: 0x235D050 VA: 0x18235EA50
	public void .ctor(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x235EBE0 Offset: 0x235D1E0 VA: 0x18235EBE0
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x235EC30 Offset: 0x235D230 VA: 0x18235EC30
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x235EC80 Offset: 0x235D280 VA: 0x18235EC80
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x235EDD0 Offset: 0x235D3D0 VA: 0x18235EDD0
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x235E6F0 Offset: 0x235CCF0 VA: 0x18235E6F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x235E6A0 Offset: 0x235CCA0 VA: 0x18235E6A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235E5F0 Offset: 0x235CBF0 VA: 0x18235E5F0 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x235E540 Offset: 0x235CB40 VA: 0x18235E540 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum RenderTargetFlags // TypeDefIndex: 10072
{
	// Fields
	public int value__; // 0x0
	public const RenderTargetFlags None = 0;
	public const RenderTargetFlags ReadOnlyDepth = 1;
	public const RenderTargetFlags ReadOnlyStencil = 2;
	public const RenderTargetFlags ReadOnlyDepthStencil = 3;
}

// Namespace: UnityEngine.Rendering
public enum ShadowSamplingMode // TypeDefIndex: 10073
{
	// Fields
	public int value__; // 0x0
	public const ShadowSamplingMode CompareDepths = 0;
	public const ShadowSamplingMode RawDepth = 1;
	public const ShadowSamplingMode None = 2;
}

// Namespace: UnityEngine.Rendering
public enum LightProbeUsage // TypeDefIndex: 10074
{
	// Fields
	public int value__; // 0x0
	public const LightProbeUsage Off = 0;
	public const LightProbeUsage BlendProbes = 1;
	public const LightProbeUsage UseProxyVolume = 2;
	public const LightProbeUsage CustomProvided = 4;
}

// Namespace: UnityEngine.Rendering
public enum BuiltinShaderType // TypeDefIndex: 10075
{
	// Fields
	public int value__; // 0x0
	public const BuiltinShaderType DeferredShading = 0;
	public const BuiltinShaderType DeferredReflections = 1;
	[Obsolete("LegacyDeferredLighting has been removed.", False)]
	public const BuiltinShaderType LegacyDeferredLighting = 2;
	public const BuiltinShaderType ScreenSpaceShadows = 3;
	public const BuiltinShaderType DepthNormals = 4;
	public const BuiltinShaderType MotionVectors = 5;
	public const BuiltinShaderType LightHalo = 6;
	public const BuiltinShaderType LensFlare = 7;
}

// Namespace: UnityEngine.Rendering
public enum BuiltinShaderMode // TypeDefIndex: 10076
{
	// Fields
	public int value__; // 0x0
	public const BuiltinShaderMode Disabled = 0;
	public const BuiltinShaderMode UseBuiltin = 1;
	public const BuiltinShaderMode UseCustom = 2;
}

// Namespace: UnityEngine.Rendering
public enum TextureDimension // TypeDefIndex: 10077
{
	// Fields
	public int value__; // 0x0
	public const TextureDimension Unknown = -1;
	public const TextureDimension None = 0;
	public const TextureDimension Any = 1;
	public const TextureDimension Tex2D = 2;
	public const TextureDimension Tex3D = 3;
	public const TextureDimension Cube = 4;
	public const TextureDimension Tex2DArray = 5;
	public const TextureDimension CubeArray = 6;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum CopyTextureSupport // TypeDefIndex: 10078
{
	// Fields
	public int value__; // 0x0
	public const CopyTextureSupport None = 0;
	public const CopyTextureSupport Basic = 1;
	public const CopyTextureSupport Copy3D = 2;
	public const CopyTextureSupport DifferentTypes = 4;
	public const CopyTextureSupport TextureToRT = 8;
	public const CopyTextureSupport RTToTexture = 16;
}

// Namespace: UnityEngine.Rendering
public enum SinglePassStereoMode // TypeDefIndex: 10079
{
	// Fields
	public int value__; // 0x0
	public const SinglePassStereoMode None = 0;
	public const SinglePassStereoMode SideBySide = 1;
	public const SinglePassStereoMode Instancing = 2;
	public const SinglePassStereoMode Multiview = 3;
}

// Namespace: UnityEngine.Rendering
public enum CommandBufferExecutionFlags // TypeDefIndex: 10080
{
	// Fields
	public int value__; // 0x0
	public const CommandBufferExecutionFlags None = 0;
	public const CommandBufferExecutionFlags AsyncCompute = 2;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum RTClearFlags // TypeDefIndex: 10081
{
	// Fields
	public int value__; // 0x0
	public const RTClearFlags None = 0;
	public const RTClearFlags Color = 1;
	public const RTClearFlags Depth = 2;
	public const RTClearFlags Stencil = 4;
	public const RTClearFlags All = 7;
	public const RTClearFlags DepthStencil = 6;
	public const RTClearFlags ColorDepth = 3;
	public const RTClearFlags ColorStencil = 5;
}

// Namespace: UnityEngine.Rendering
public enum RenderTextureSubElement // TypeDefIndex: 10082
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureSubElement Color = 0;
	public const RenderTextureSubElement Depth = 1;
	public const RenderTextureSubElement Stencil = 2;
	public const RenderTextureSubElement Default = 3;
}

// Namespace: UnityEngine.Rendering
[StaticAccessor("GetGraphicsSettings()", 0)]
[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
public sealed class GraphicsSettings : Object // TypeDefIndex: 10084
{
	// Fields
	private static Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings; // 0x0

	// Properties
	public static bool lightsUseLinearIntensity { get; }
	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline { get; }
	public static RenderPipelineAsset currentRenderPipeline { get; }
	public static RenderPipelineAsset renderPipelineAsset { get; set; }
	[NativeName("DefaultRenderPipeline")]
	private static ScriptableObject INTERNAL_defaultRenderPipeline { get; set; }
	public static RenderPipelineAsset defaultRenderPipeline { get; set; }

	// Methods

	// RVA: 0x23542D0 Offset: 0x23528D0 VA: 0x1823542D0
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x2353F80 Offset: 0x2352580 VA: 0x182353F80
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x23540B0 Offset: 0x23526B0 VA: 0x1823540B0
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	// RVA: 0x2354300 Offset: 0x2352900 VA: 0x182354300
	public static RenderPipelineAsset get_renderPipelineAsset() { }

	// RVA: 0x23545D0 Offset: 0x2352BD0 VA: 0x1823545D0
	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

	// RVA: 0x2354030 Offset: 0x2352630 VA: 0x182354030
	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	// RVA: 0x2354480 Offset: 0x2352A80 VA: 0x182354480
	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	// RVA: 0x23541C0 Offset: 0x23527C0 VA: 0x1823541C0
	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	// RVA: 0x2354510 Offset: 0x2352B10 VA: 0x182354510
	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }

	[NativeName("GetShaderModeScript")]
	// RVA: 0x2353A60 Offset: 0x2352060 VA: 0x182353A60
	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type) { }

	[NativeName("GetSettingsForRenderPipeline")]
	// RVA: 0x2353C50 Offset: 0x2352250 VA: 0x182353C50
	private static Object Internal_GetSettingsForRenderPipeline(string renderpipelineName) { }

	// RVA: 0x2353AA0 Offset: 0x23520A0 VA: 0x182353AA0
	private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings() { }

	// RVA: 0x2353E40 Offset: 0x2352440 VA: 0x182353E40
	private static void .cctor() { }

	// RVA: 0x2353F50 Offset: 0x2352550 VA: 0x182353F50
	private static IntPtr get_INTERNAL_currentRenderPipeline_Injected() { }

	// RVA: 0x2354000 Offset: 0x2352600 VA: 0x182354000
	private static IntPtr get_INTERNAL_defaultRenderPipeline_Injected() { }

	// RVA: 0x2354440 Offset: 0x2352A40 VA: 0x182354440
	private static void set_INTERNAL_defaultRenderPipeline_Injected(IntPtr value) { }

	// RVA: 0x2353C10 Offset: 0x2352210 VA: 0x182353C10
	private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName) { }
}

// Namespace: UnityEngine.Rendering
public interface IRenderPipelineGraphicsSettings // TypeDefIndex: 10085
{}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode]
public class OnDemandRendering // TypeDefIndex: 10086
{
	// Fields
	private static int m_RenderFrameInterval; // 0x0

	// Properties
	public static int renderFrameInterval { get; }

	// Methods

	// RVA: 0x2357F30 Offset: 0x2356530 VA: 0x182357F30
	public static int get_renderFrameInterval() { }

	[RequiredByNativeCode]
	// RVA: 0x2357E60 Offset: 0x2356460 VA: 0x182357E60
	internal static void GetRenderFrameInterval(out int frameInterval) { }

	// RVA: 0x2357EF0 Offset: 0x23564F0 VA: 0x182357EF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
[UsedByNativeCode]
[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
public class CommandBuffer : IDisposable // TypeDefIndex: 10088
{
	// Fields
	public static bool ThrowOnSetRenderTarget; // 0x0
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { set; }

	// Methods

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = True)]
	// RVA: 0x2350990 Offset: 0x234EF90 VA: 0x182350990
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	// RVA: 0x2350220 Offset: 0x234E820 VA: 0x182350220
	private static IntPtr InitBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2350A30 Offset: 0x234F030 VA: 0x182350A30
	private void ReleaseBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = True)]
	// RVA: 0x2350F50 Offset: 0x234F550 VA: 0x182350F50
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = True)]
	// RVA: 0x2350680 Offset: 0x234EC80 VA: 0x182350680
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = True)]
	// RVA: 0x2350860 Offset: 0x234EE60 VA: 0x182350860
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	// RVA: 0x2350500 Offset: 0x234EB00 VA: 0x182350500
	private void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x234E9F0 Offset: 0x234CFF0 VA: 0x18234E9F0
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x23525E0 Offset: 0x2350BE0 VA: 0x1823525E0
	public void set_name(string value) { }

	[NativeMethod("ClearCommands")]
	// RVA: 0x234E4F0 Offset: 0x234CAF0 VA: 0x18234E4F0
	public void Clear() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = True)]
	// RVA: 0x2350330 Offset: 0x234E930 VA: 0x182350330
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2352430 Offset: 0x2350A30 VA: 0x182352430
	public void SetViewport(Rect pixelRect) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = True)]
	// RVA: 0x234E5C0 Offset: 0x234CBC0 VA: 0x18234E5C0
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = True)]
	// RVA: 0x234DB70 Offset: 0x234C170 VA: 0x18234DB70
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = True)]
	// RVA: 0x234D9F0 Offset: 0x234BFF0 VA: 0x18234D9F0
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRT", HasExplicitThis = True)]
	// RVA: 0x234F5D0 Offset: 0x234DBD0 VA: 0x18234F5D0
	private void GetTemporaryRT(int nameID, int width, int height, FilterMode filter, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale, ShadowSamplingMode shadowSamplingMode) { }

	// RVA: 0x234F670 Offset: 0x234DC70 VA: 0x18234F670
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x234FCA0 Offset: 0x234E2A0 VA: 0x18234FCA0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x234FE80 Offset: 0x234E480 VA: 0x18234FE80
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x234FA30 Offset: 0x234E030 VA: 0x18234FA30
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x234F860 Offset: 0x234DE60 VA: 0x18234F860
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x2350060 Offset: 0x234E660 VA: 0x182350060
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = True)]
	// RVA: 0x234F4C0 Offset: 0x234DAC0 VA: 0x18234F4C0
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x234FC00 Offset: 0x234E200 VA: 0x18234FC00
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = True)]
	// RVA: 0x2350AD0 Offset: 0x234F0D0 VA: 0x182350AD0
	public void ReleaseTemporaryRT(int nameID) { }

	// RVA: 0x234E3C0 Offset: 0x234C9C0 VA: 0x18234E3C0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x234E2D0 Offset: 0x234C8D0 VA: 0x18234E2D0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth = 1, uint stencil = 0) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
	// RVA: 0x2351190 Offset: 0x234F790 VA: 0x182351190
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
	// RVA: 0x23514C0 Offset: 0x234FAC0 VA: 0x1823514C0
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	// RVA: 0x234F040 Offset: 0x234D640 VA: 0x18234F040
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	// RVA: 0x234E860 Offset: 0x234CE60 VA: 0x18234E860
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x23524E0 Offset: 0x2350AE0 VA: 0x1823524E0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = True)]
	// RVA: 0x2351260 Offset: 0x234F860 VA: 0x182351260
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = True)]
	// RVA: 0x234D7F0 Offset: 0x234BDF0 VA: 0x18234D7F0
	public void BeginSample(string name) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = True)]
	// RVA: 0x234F220 Offset: 0x234D820 VA: 0x18234F220
	public void EndSample(string name) { }

	// RVA: 0x234E150 Offset: 0x234C750 VA: 0x18234E150
	private static void CheckThrowOnSetRenderTarget() { }

	// RVA: 0x2351F50 Offset: 0x2350550 VA: 0x182351F50
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x23519C0 Offset: 0x234FFC0 VA: 0x1823519C0
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2351CE0 Offset: 0x23502E0 VA: 0x182351CE0
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2351B30 Offset: 0x2350130 VA: 0x182351B30
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x23520A0 Offset: 0x23506A0 VA: 0x1823520A0
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	// RVA: 0x234E240 Offset: 0x234C840 VA: 0x18234E240
	private void ClearRenderTargetSingle_Internal(RTClearFlags clearFlags, Color color, float depth, uint stencil) { }

	// RVA: 0x2351930 Offset: 0x234FF30 VA: 0x182351930
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x23515A0 Offset: 0x234FBA0 VA: 0x1823515A0
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x23516C0 Offset: 0x234FCC0 VA: 0x1823516C0
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x234F3B0 Offset: 0x234D9B0 VA: 0x18234F3B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x234EAE0 Offset: 0x234D0E0 VA: 0x18234EAE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x234EB80 Offset: 0x234D180 VA: 0x18234EB80
	private void Dispose(bool disposing) { }

	// RVA: 0x2352550 Offset: 0x2350B50 VA: 0x182352550
	public void .ctor() { }

	// RVA: 0x2351040 Offset: 0x234F640 VA: 0x182351040
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	// RVA: 0x2350C50 Offset: 0x234F250 VA: 0x182350C50
	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	// RVA: 0x2350DC0 Offset: 0x234F3C0 VA: 0x182350DC0
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x2350B30 Offset: 0x234F130 VA: 0x182350B30
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x234E9F0 Offset: 0x234CFF0 VA: 0x18234E9F0
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x234EC60 Offset: 0x234D260 VA: 0x18234EC60
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[ExcludeFromDocs]
	// RVA: 0x234EBF0 Offset: 0x234D1F0 VA: 0x18234EBF0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x234E650 Offset: 0x234CC50 VA: 0x18234E650
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x234E720 Offset: 0x234CD20 VA: 0x18234E720
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	// RVA: 0x234DE40 Offset: 0x234C440 VA: 0x18234DE40
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0x234DFE0 Offset: 0x234C5E0 VA: 0x18234DFE0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x234DCB0 Offset: 0x234C2B0 VA: 0x18234DCB0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x23513D0 Offset: 0x234F9D0 VA: 0x1823513D0
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x2351360 Offset: 0x234F960 VA: 0x182351360
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x23512E0 Offset: 0x234F8E0 VA: 0x1823512E0
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x2350990 Offset: 0x234EF90 VA: 0x182350990
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x2350950 Offset: 0x234EF50 VA: 0x182350950
	private static void Internal_SetSinglePassStereo_Injected(IntPtr _unity_self, SinglePassStereoMode mode) { }

	// RVA: 0x23509F0 Offset: 0x234EFF0 VA: 0x1823509F0
	private static void ReleaseBuffer_Injected(IntPtr _unity_self) { }

	// RVA: 0x2350EE0 Offset: 0x234F4E0 VA: 0x182350EE0
	private static void SetComputeVectorParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, in Vector4 val) { }

	// RVA: 0x2350610 Offset: 0x234EC10 VA: 0x182350610
	private static void Internal_SetComputeFloats_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	// RVA: 0x23507F0 Offset: 0x234EDF0 VA: 0x1823507F0
	private static void Internal_SetComputeTextureParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	// RVA: 0x2350490 Offset: 0x234EA90 VA: 0x182350490
	private static void Internal_SetComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer) { }

	// RVA: 0x2350250 Offset: 0x234E850 VA: 0x182350250
	private static void Internal_DispatchCompute_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x2352590 Offset: 0x2350B90 VA: 0x182352590
	private static void set_name_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x234E4B0 Offset: 0x234CAB0 VA: 0x18234E4B0
	private static void Clear_Injected(IntPtr _unity_self) { }

	// RVA: 0x23502C0 Offset: 0x234E8C0 VA: 0x1823502C0
	private static void Internal_DrawMesh_Injected(IntPtr _unity_self, IntPtr mesh, in Matrix4x4 matrix, IntPtr material, int submeshIndex, int shaderPass, IntPtr properties) { }

	// RVA: 0x23523E0 Offset: 0x23509E0 VA: 0x1823523E0
	private static void SetViewport_Injected(IntPtr _unity_self, in Rect pixelRect) { }

	// RVA: 0x234E550 Offset: 0x234CB50 VA: 0x18234E550
	private static void CopyTexture_Internal_Injected(IntPtr _unity_self, ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	// RVA: 0x234DB00 Offset: 0x234C100 VA: 0x18234DB00
	private static void Blit_Texture_Injected(IntPtr _unity_self, IntPtr source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, in Vector2 scale, in Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x234D980 Offset: 0x234BF80 VA: 0x18234D980
	private static void Blit_Identifier_Injected(IntPtr _unity_self, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, in Vector2 scale, in Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x234F540 Offset: 0x234DB40 VA: 0x18234F540
	private static void GetTemporaryRT_Injected(IntPtr _unity_self, int nameID, int width, int height, FilterMode filter, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale, ShadowSamplingMode shadowSamplingMode) { }

	// RVA: 0x234F460 Offset: 0x234DA60 VA: 0x18234F460
	private static void GetTemporaryRTWithDescriptor_Injected(IntPtr _unity_self, int nameID, in RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x2350A90 Offset: 0x234F090 VA: 0x182350A90
	private static void ReleaseTemporaryRT_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x2351140 Offset: 0x234F740 VA: 0x182351140
	private static void SetGlobalFloat_Injected(IntPtr _unity_self, int nameID, float value) { }

	// RVA: 0x2351470 Offset: 0x234FA70 VA: 0x182351470
	private static void SetGlobalVector_Injected(IntPtr _unity_self, int nameID, in Vector4 value) { }

	// RVA: 0x234EFF0 Offset: 0x234D5F0 VA: 0x18234EFF0
	private static void EnableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	// RVA: 0x234E810 Offset: 0x234CE10 VA: 0x18234E810
	private static void DisableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	// RVA: 0x2352490 Offset: 0x2350A90 VA: 0x182352490
	private static bool ValidateAgainstExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	// RVA: 0x2351200 Offset: 0x234F800 VA: 0x182351200
	private static void SetGlobalTexture_Impl_Injected(IntPtr _unity_self, int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0x234D7A0 Offset: 0x234BDA0 VA: 0x18234D7A0
	private static void BeginSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x234F1D0 Offset: 0x234D7D0 VA: 0x18234F1D0
	private static void EndSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x234E1E0 Offset: 0x234C7E0 VA: 0x18234E1E0
	private static void ClearRenderTargetSingle_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, in Color color, float depth, uint stencil) { }

	// RVA: 0x23518C0 Offset: 0x234FEC0 VA: 0x1823518C0
	private static void SetRenderTargetSingle_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2351530 Offset: 0x234FB30 VA: 0x182351530
	private static void SetRenderTargetColorDepth_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier color, in RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x2351650 Offset: 0x234FC50 VA: 0x182351650
	private static void SetRenderTargetMulti_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, in RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }
}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[NativeClass("BatchID")]
public struct BatchID : IEquatable<BatchID> // TypeDefIndex: 10089
{
	// Fields
	public static readonly BatchID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x234CFE0 Offset: 0x234B5E0 VA: 0x18234CFE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234CF40 Offset: 0x234B540 VA: 0x18234CF40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(BatchID other) { }

	// RVA: 0x234CFF0 Offset: 0x234B5F0 VA: 0x18234CFF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeClass("BatchMaterialID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchMaterialID : IEquatable<BatchMaterialID> // TypeDefIndex: 10090
{
	// Fields
	public static readonly BatchMaterialID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x234CFE0 Offset: 0x234B5E0 VA: 0x18234CFE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234D030 Offset: 0x234B630 VA: 0x18234D030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(BatchMaterialID other) { }

	// RVA: 0x234D0D0 Offset: 0x234B6D0 VA: 0x18234D0D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("BatchMeshID")]
public struct BatchMeshID : IEquatable<BatchMeshID> // TypeDefIndex: 10091
{
	// Fields
	public static readonly BatchMeshID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x234CFE0 Offset: 0x234B5E0 VA: 0x18234CFE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234D110 Offset: 0x234B710 VA: 0x18234D110 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(BatchMeshID other) { }

	// RVA: 0x234D1B0 Offset: 0x234B7B0 VA: 0x18234D1B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum BatchDrawCommandFlags // TypeDefIndex: 10092
{
	// Fields
	public int value__; // 0x0
	public const BatchDrawCommandFlags None = 0;
	public const BatchDrawCommandFlags FlipWinding = 1;
	public const BatchDrawCommandFlags HasMotion = 2;
	public const BatchDrawCommandFlags IsLightMapped = 4;
	public const BatchDrawCommandFlags HasSortingPosition = 8;
	public const BatchDrawCommandFlags LODCrossFade = 16;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum BatchCullingFlags // TypeDefIndex: 10093
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingFlags None = 0;
	public const BatchCullingFlags CullLightmappedShadowCasters = 1;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingViewType // TypeDefIndex: 10094
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingViewType Unknown = 0;
	public const BatchCullingViewType Camera = 1;
	public const BatchCullingViewType Light = 2;
	public const BatchCullingViewType Picking = 3;
	public const BatchCullingViewType SelectionOutline = 4;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingProjectionType // TypeDefIndex: 10095
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingProjectionType Unknown = 0;
	public const BatchCullingProjectionType Perspective = 1;
	public const BatchCullingProjectionType Orthographic = 2;
}

// Namespace: UnityEngine.Rendering
public struct BatchPackedCullingViewID : IEquatable<BatchPackedCullingViewID> // TypeDefIndex: 10096
{
	// Fields
	internal ulong handle; // 0x0

	// Methods

	// RVA: 0x234D280 Offset: 0x234B880 VA: 0x18234D280 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x9BD870 Offset: 0x9BBE70 VA: 0x1809BD870 Slot: 4
	public bool Equals(BatchPackedCullingViewID other) { }

	// RVA: 0x234D1F0 Offset: 0x234B7F0 VA: 0x18234D1F0 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommand // TypeDefIndex: 10097
{
	// Fields
	public uint visibleOffset; // 0x0
	public uint visibleCount; // 0x4
	public BatchID batchID; // 0x8
	public BatchMaterialID materialID; // 0xC
	public BatchMeshID meshID; // 0x10
	public ushort submeshIndex; // 0x14
	public ushort splitVisibilityMask; // 0x16
	public BatchDrawCommandFlags flags; // 0x18
	public int sortingPosition; // 0x1C
}

// Namespace: UnityEngine.Rendering
public struct BatchFilterSettings // TypeDefIndex: 10098
{
	// Fields
	public uint renderingLayerMask; // 0x0
	public int rendererPriority; // 0x4
	private ulong m_sceneCullingMask; // 0x8
	public byte layer; // 0x10
	private byte m_motionMode; // 0x11
	private byte m_shadowMode; // 0x12
	private byte m_receiveShadows; // 0x13
	private byte m_staticShadowCaster; // 0x14
	private byte m_allDepthSorted; // 0x15
	private byte m_isSceneCullingMaskSet; // 0x16
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawRange // TypeDefIndex: 10099
{
	// Fields
	public uint drawCommandsBegin; // 0x0
	public uint drawCommandsCount; // 0x4
	public BatchFilterSettings filterSettings; // 0x8
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutputDrawCommands // TypeDefIndex: 10100
{
	// Fields
	public BatchDrawCommand* drawCommands; // 0x0
	public int* visibleInstances; // 0x8
	public BatchDrawRange* drawRanges; // 0x10
	public float* instanceSortingPositions; // 0x18
	public int* drawCommandPickingInstanceIDs; // 0x20
	public int drawCommandCount; // 0x28
	public int visibleInstanceCount; // 0x2C
	public int drawRangeCount; // 0x30
	public int instanceSortingPositionFloatCount; // 0x34
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct CullingSplit // TypeDefIndex: 10101
{
	// Fields
	public Vector3 sphereCenter; // 0x0
	public float sphereRadius; // 0xC
	public int cullingPlaneOffset; // 0x10
	public int cullingPlaneCount; // 0x14
	public float cascadeBlendCullingFactor; // 0x18
	public float nearPlane; // 0x1C
	public Matrix4x4 cullingMatrix; // 0x20
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
public struct BatchCullingContext // TypeDefIndex: 10102
{
	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public readonly NativeArray<CullingSplit> cullingSplits; // 0x10
	public readonly LODParameters lodParameters; // 0x20
	public readonly Matrix4x4 localToWorldMatrix; // 0x3C
	public readonly BatchCullingViewType viewType; // 0x7C
	public readonly BatchCullingProjectionType projectionType; // 0x80
	public readonly BatchCullingFlags cullingFlags; // 0x84
	public readonly BatchPackedCullingViewID viewID; // 0x88
	public readonly uint cullingLayerMask; // 0x90
	public readonly ulong sceneCullingMask; // 0x98
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	public readonly byte isOrthographic; // 0xA0
	public readonly int receiverPlaneOffset; // 0xA4
	public readonly int receiverPlaneCount; // 0xA8

	// Methods

	// RVA: 0x234CE90 Offset: 0x234B490 VA: 0x18234CE90
	internal void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount) { }
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutput // TypeDefIndex: 10103
{
	// Fields
	public NativeArray<BatchCullingOutputDrawCommands> drawCommands; // 0x0
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
internal struct BatchRendererCullingOutput // TypeDefIndex: 10104
{
	// Fields
	public JobHandle cullingJobsFence; // 0x0
	public Matrix4x4 localToWorldMatrix; // 0x10
	public Plane* cullingPlanes; // 0x50
	public int cullingPlaneCount; // 0x58
	public int receiverPlaneOffset; // 0x5C
	public int receiverPlaneCount; // 0x60
	public CullingSplit* cullingSplits; // 0x68
	public int cullingSplitCount; // 0x70
	public BatchCullingViewType viewType; // 0x74
	public BatchCullingProjectionType projectionType; // 0x78
	public BatchCullingFlags cullingFlags; // 0x7C
	public ulong viewID; // 0x80
	public uint cullingLayerMask; // 0x88
	public ulong sceneCullingMask; // 0x90
	public BatchCullingOutputDrawCommands* drawCommands; // 0x98
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Math/Matrix4x4.h")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode]
public class BatchRendererGroup // TypeDefIndex: 10106
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x234D290 Offset: 0x234B890 VA: 0x18234D290
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }
}

// Namespace: UnityEngine.Rendering
public struct LightShadowCasterCullingInfo // TypeDefIndex: 10107
{
	// Fields
	public RangeInt splitRange; // 0x0
	public BatchCullingProjectionType projectionType; // 0x8
}

// Namespace: UnityEngine.Rendering
public class InvalidImportException : Exception // TypeDefIndex: 10108
{}

// Namespace: UnityEngine.Rendering
public struct LODParameters : IEquatable<LODParameters> // TypeDefIndex: 10109
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private Vector3 m_CameraPosition; // 0x4
	private float m_FieldOfView; // 0x10
	private float m_OrthoSize; // 0x14
	private int m_CameraPixelHeight; // 0x18

	// Methods

	// RVA: 0x2355450 Offset: 0x2353A50 VA: 0x182355450 Slot: 4
	public bool Equals(LODParameters other) { }

	// RVA: 0x23554F0 Offset: 0x2353AF0 VA: 0x1823554F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2355610 Offset: 0x2353C10 VA: 0x182355610 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline // TypeDefIndex: 10110
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-RenderPipeline.ProcessRenderRequests<object>
	|-RenderPipeline.ProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x235E4C0 Offset: 0x235CAC0 VA: 0x18235E4C0 Slot: 6
	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x235E430 Offset: 0x235CA30 VA: 0x18235E430
	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: -1 Offset: -1
	internal void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x790C40 Offset: 0x78F240 VA: 0x180790C40
	|-RenderPipeline.InternalProcessRenderRequests<object>
	|
	|-RVA: 0x790AE0 Offset: 0x78F0E0 VA: 0x180790AE0
	|-RenderPipeline.InternalProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	private void set_disposed(bool value) { }

	// RVA: 0x235E3C0 Offset: 0x235C9C0 VA: 0x18235E3C0
	internal void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 10111
{
	// Properties
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual string[] prefixedRenderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Material default2DMaskMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }
	public virtual string renderPipelineShaderTag { get; }
	public virtual Type pipelineType { get; }
	[Obsolete("This property is obsolete. Use pipelineType instead. #from(23.2)", False)]
	protected internal virtual Type renderPipelineType { get; }

	// Methods

	// RVA: 0x235CB50 Offset: 0x235B150 VA: 0x18235CB50
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 11
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 12
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 13
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 14
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 16
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 17
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 18
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 20
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 21
	public virtual Shader get_defaultShader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 22
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 23
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x235CD20 Offset: 0x235B320 VA: 0x18235CD20 Slot: 24
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x235CCC0 Offset: 0x235B2C0 VA: 0x18235CCC0 Slot: 26
	public virtual Type get_pipelineType() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 27
	protected virtual void EnsureGlobalSettings() { }

	// RVA: 0x235CC00 Offset: 0x235B200 VA: 0x18235CC00 Slot: 28
	protected virtual void OnValidate() { }

	// RVA: 0x235CBC0 Offset: 0x235B1C0 VA: 0x18235CBC0 Slot: 29
	protected virtual void OnDisable() { }

	// RVA: 0x235CD90 Offset: 0x235B390 VA: 0x18235CD90 Slot: 30
	protected internal virtual Type get_renderPipelineType() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineGlobalSettings : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 10112
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Dictionary<Type, int> <settingsMap>k__BackingField; // 0x18

	// Properties
	protected virtual List<IRenderPipelineGraphicsSettings> settingsList { get; }
	private Dictionary<Type, int> settingsMap { get; }

	// Methods

	// RVA: 0x235D1D0 Offset: 0x235B7D0 VA: 0x18235D1D0 Slot: 6
	protected virtual List<IRenderPipelineGraphicsSettings> get_settingsList() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	private Dictionary<Type, int> get_settingsMap() { }

	// RVA: 0x235CE70 Offset: 0x235B470 VA: 0x18235CE70
	private void RecreateSettingsMap() { }

	// RVA: 0x235CFC0 Offset: 0x235B5C0 VA: 0x18235CFC0
	protected internal bool TryGet(Type type, out IRenderPipelineGraphicsSettings settings) { }

	// RVA: 0x235CDF0 Offset: 0x235B3F0 VA: 0x18235CDF0
	protected internal bool Contains(Type type) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x235CE70 Offset: 0x235B470 VA: 0x18235CE70 Slot: 8
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x235D150 Offset: 0x235B750 VA: 0x18235D150
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager // TypeDefIndex: 10113
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static List<Camera> s_Cameras; // 0x8
	private static string s_CurrentPipelineType; // 0x10
	private static RenderPipeline s_CurrentPipeline; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineTypeChanged; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action activeRenderPipelineCreated; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineDisposed; // 0x38

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	// RVA: 0x235E270 Offset: 0x235C870 VA: 0x18235E270
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x235E2C0 Offset: 0x235C8C0 VA: 0x18235E2C0
	private static void set_currentPipeline(RenderPipeline value) { }

	[RequiredByNativeCode]
	// RVA: 0x235DE90 Offset: 0x235C490 VA: 0x18235DE90
	internal static void OnActiveRenderPipelineTypeChanged() { }

	[RequiredByNativeCode]
	// RVA: 0x235DD80 Offset: 0x235C380 VA: 0x18235DD80
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	// RVA: 0x235DB70 Offset: 0x235C170 VA: 0x18235DB70
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	[RequiredByNativeCode]
	// RVA: 0x235D430 Offset: 0x235BA30 VA: 0x18235D430
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	// RVA: 0x235DB20 Offset: 0x235C120 VA: 0x18235DB20
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	// RVA: 0x235D780 Offset: 0x235BD80 VA: 0x18235D780
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest) { }

	// RVA: 0x235DF00 Offset: 0x235C500 VA: 0x18235DF00
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x235DC10 Offset: 0x235C210 VA: 0x18235DC10
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x235E170 Offset: 0x235C770 VA: 0x18235E170
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 10115
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x2360990 Offset: 0x235EF90 VA: 0x182360990
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x23609F0 Offset: 0x235EFF0 VA: 0x1823609F0
	internal void GetCameras(List<Camera> results) { }

	// RVA: 0x2360950 Offset: 0x235EF50 VA: 0x182360950 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x2360890 Offset: 0x235EE90 VA: 0x182360890 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x234CFE0 Offset: 0x234B5E0 VA: 0x18234CFE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2360AB0 Offset: 0x235F0B0 VA: 0x182360AB0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 10116
{
	// Fields
	private int m_Id; // 0x0

	// Methods

	// RVA: 0x2360E30 Offset: 0x235F430 VA: 0x182360E30
	public void .ctor(string name) { }

	// RVA: 0x2360D80 Offset: 0x235F380 VA: 0x182360D80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x2360E10 Offset: 0x235F410 VA: 0x182360E10 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public struct ShadowSplitData : IEquatable<ShadowSplitData> // TypeDefIndex: 10118
{
	// Fields
	public static readonly int maximumCullingPlaneCount; // 0x0
	private int m_CullingPlaneCount; // 0x0
	[FixedBuffer(typeof(byte), 160)]
	internal ShadowSplitData.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x4
	private Vector4 m_CullingSphere; // 0xA4
	private float m_ShadowCascadeBlendCullingFactor; // 0xB4
	private float m_CullingNearPlane; // 0xB8
	private Matrix4x4 m_CullingMatrix; // 0xBC

	// Properties
	public int cullingPlaneCount { get; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public int get_cullingPlaneCount() { }

	// RVA: 0x2361290 Offset: 0x235F890 VA: 0x182361290
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x2360FB0 Offset: 0x235F5B0 VA: 0x182360FB0 Slot: 4
	public bool Equals(ShadowSplitData other) { }

	// RVA: 0x2360E50 Offset: 0x235F450 VA: 0x182360E50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23613F0 Offset: 0x235F9F0 VA: 0x1823613F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2361480 Offset: 0x235FA80 VA: 0x182361480
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public struct StencilState : IEquatable<StencilState> // TypeDefIndex: 10119
{
	// Fields
	private byte m_Enabled; // 0x0
	private byte m_ReadMask; // 0x1
	private byte m_WriteMask; // 0x2
	private byte m_Padding; // 0x3
	private byte m_CompareFunctionFront; // 0x4
	private byte m_PassOperationFront; // 0x5
	private byte m_FailOperationFront; // 0x6
	private byte m_ZFailOperationFront; // 0x7
	private byte m_CompareFunctionBack; // 0x8
	private byte m_PassOperationBack; // 0x9
	private byte m_FailOperationBack; // 0xA
	private byte m_ZFailOperationBack; // 0xB

	// Properties
	public bool enabled { set; }
	public byte readMask { set; }
	public byte writeMask { set; }
	public CompareFunction compareFunctionFront { set; }
	public StencilOp passOperationFront { set; }
	public StencilOp failOperationFront { set; }
	public StencilOp zFailOperationFront { set; }
	public CompareFunction compareFunctionBack { set; }
	public StencilOp passOperationBack { set; }
	public StencilOp failOperationBack { set; }
	public StencilOp zFailOperationBack { set; }

	// Methods

	// RVA: 0x2363020 Offset: 0x2361620 VA: 0x182363020
	public void set_enabled(bool value) { }

	// RVA: 0x16A56B0 Offset: 0x16A3CB0 VA: 0x1816A56B0
	public void set_readMask(byte value) { }

	// RVA: 0x207ED20 Offset: 0x207D320 VA: 0x18207ED20
	public void set_writeMask(byte value) { }

	// RVA: 0x22D6360 Offset: 0x22D4960 VA: 0x1822D6360
	public void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x23630A0 Offset: 0x23616A0 VA: 0x1823630A0
	public void set_passOperationFront(StencilOp value) { }

	// RVA: 0x2363090 Offset: 0x2361690 VA: 0x182363090
	public void set_failOperationFront(StencilOp value) { }

	// RVA: 0x23630C0 Offset: 0x23616C0 VA: 0x1823630C0
	public void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x214F390 Offset: 0x214D990 VA: 0x18214F390
	public void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x214F3A0 Offset: 0x214D9A0 VA: 0x18214F3A0
	public void set_passOperationBack(StencilOp value) { }

	// RVA: 0x2363080 Offset: 0x2361680 VA: 0x182363080
	public void set_failOperationBack(StencilOp value) { }

	// RVA: 0x23630B0 Offset: 0x23616B0 VA: 0x1823630B0
	public void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x2362D60 Offset: 0x2361360 VA: 0x182362D60 Slot: 4
	public bool Equals(StencilState other) { }

	// RVA: 0x2362DD0 Offset: 0x23613D0 VA: 0x182362DD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2362F20 Offset: 0x2361520 VA: 0x182362F20 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
public class SupportedRenderingFeatures // TypeDefIndex: 10122
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <enlightenLightmapper>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enlighten>k__BackingField; // 0x25
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <motionVectors>k__BackingField; // 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <receiveShadows>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <reflectionProbes>k__BackingField; // 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <reflectionProbesBlendDistance>k__BackingField; // 0x2A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendererPriority>k__BackingField; // 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <rendersUIOverlay>k__BackingField; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesFog>k__BackingField; // 0x2E
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x2F
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesLODBias>k__BackingField; // 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnableLODCrossFade>k__BackingField; // 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <rendererProbes>k__BackingField; // 0x35
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <particleSystemInstancing>k__BackingField; // 0x36
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <ambientProbeBaking>k__BackingField; // 0x37
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <defaultReflectionProbeBaking>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesShadowmask>k__BackingField; // 0x39
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesLightProbeSystem>k__BackingField; // 0x3A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <supportsHDR>k__BackingField; // 0x3B
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <supportsClouds>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

	// Properties
	public static SupportedRenderingFeatures active { get; set; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	public bool enlighten { get; }
	public bool rendersUIOverlay { get; }
	public bool ambientProbeBaking { get; }
	public bool defaultReflectionProbeBaking { get; }
	public bool overridesLightProbeSystem { get; }

	// Methods

	// RVA: 0x2363FD0 Offset: 0x23625D0 VA: 0x182363FD0
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x23640C0 Offset: 0x23626C0 VA: 0x1823640C0
	public static void set_active(SupportedRenderingFeatures value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGenerated]
	// RVA: 0x161BB10 Offset: 0x161A110 VA: 0x18161BB10
	public bool get_enlighten() { }

	[CompilerGenerated]
	// RVA: 0x54CA70 Offset: 0x54B070 VA: 0x18054CA70
	public bool get_rendersUIOverlay() { }

	[CompilerGenerated]
	// RVA: 0x23640B0 Offset: 0x23626B0 VA: 0x1823640B0
	public bool get_ambientProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_defaultReflectionProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0
	public bool get_overridesLightProbeSystem() { }

	[RequiredByNativeCode]
	// RVA: 0x2363510 Offset: 0x2361B10 VA: 0x182363510
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x2363C90 Offset: 0x2362290 VA: 0x182363C90
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCode]
	// RVA: 0x2363B30 Offset: 0x2362130 VA: 0x182363B30
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x2363940 Offset: 0x2361F40 VA: 0x182363940
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCode]
	// RVA: 0x2363840 Offset: 0x2361E40 VA: 0x182363840
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2363AB0 Offset: 0x23620B0 VA: 0x182363AB0
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2363A80 Offset: 0x2362080 VA: 0x182363A80
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2363DE0 Offset: 0x23623E0 VA: 0x182363DE0
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2363760 Offset: 0x2361D60 VA: 0x182363760
	internal static void IsAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x23637D0 Offset: 0x2361DD0 VA: 0x1823637D0
	internal static void IsDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2363E50 Offset: 0x2362450 VA: 0x182363E50
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x23634F0 Offset: 0x2361AF0 VA: 0x1823634F0
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x2363F30 Offset: 0x2362530 VA: 0x182363F30
	public void .ctor() { }

	// RVA: 0x2363EC0 Offset: 0x23624C0 VA: 0x182363EC0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum ShaderPropertyFlags // TypeDefIndex: 10123
{
	// Fields
	public int value__; // 0x0
	public const ShaderPropertyFlags None = 0;
	public const ShaderPropertyFlags HideInInspector = 1;
	public const ShaderPropertyFlags PerRendererData = 2;
	public const ShaderPropertyFlags NoScaleOffset = 4;
	public const ShaderPropertyFlags Normal = 8;
	public const ShaderPropertyFlags HDR = 16;
	public const ShaderPropertyFlags Gamma = 32;
	public const ShaderPropertyFlags NonModifiableTextureData = 64;
	public const ShaderPropertyFlags MainTexture = 128;
	public const ShaderPropertyFlags MainColor = 256;
}

// Namespace: UnityEngine.Rendering
[RequireComponent(typeof(Transform))]
[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
public sealed class SortingGroup : Behaviour // TypeDefIndex: 10124
{
	// Properties
	[StaticAccessor("SortingGroup", 2)]
	internal static int invalidSortingGroupID { get; }
	public int sortingLayerID { get; }
	public int sortingOrder { get; }

	// Methods

	// RVA: 0x2361560 Offset: 0x235FB60 VA: 0x182361560
	internal static int get_invalidSortingGroupID() { }

	[StaticAccessor("SortingGroup", 2)]
	// RVA: 0x2361500 Offset: 0x235FB00 VA: 0x182361500
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	// RVA: 0x23615D0 Offset: 0x235FBD0 VA: 0x1823615D0
	public int get_sortingLayerID() { }

	// RVA: 0x2361690 Offset: 0x235FC90 VA: 0x182361690
	public int get_sortingOrder() { }

	// RVA: 0x23614C0 Offset: 0x235FAC0 VA: 0x1823614C0
	private static IntPtr GetSortingGroupByIndex_Injected(int index) { }

	// RVA: 0x2361590 Offset: 0x235FB90 VA: 0x182361590
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x2361650 Offset: 0x235FC50 VA: 0x182361650
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum UVChannelFlags // TypeDefIndex: 13904
{
	// Fields
	public int value__; // 0x0
	public const UVChannelFlags UV0 = 1;
	public const UVChannelFlags UV1 = 2;
	public const UVChannelFlags UV2 = 4;
	public const UVChannelFlags UV3 = 8;
}

