// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable // TypeDefIndex: 10163
{
	// Methods

	// RVA: 0x234D650 Offset: 0x234BC50 VA: 0x18234D650 Slot: 4
	public bool TickRealtimeProbes() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void Dispose(bool disposing) { }

	[StaticAccessor("GetReflectionProbes()", Type = 0)]
	// RVA: 0x234D650 Offset: 0x234BC50 VA: 0x18234D650
	private static bool BuiltinUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x234D680 Offset: 0x234BC80 VA: 0x18234D680
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
public interface IScriptableRuntimeReflectionSystem : IDisposable // TypeDefIndex: 10164
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TickRealtimeProbes();
}

// Namespace: UnityEngine.Experimental.Rendering
[RequiredByNativeCode]
[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
public static class ScriptableRuntimeReflectionSystemSettings // TypeDefIndex: 10165
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Properties
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system { set; }
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2360C00 Offset: 0x235F200 VA: 0x182360C00
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x2360BB0 Offset: 0x235F1B0 VA: 0x182360BB0
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[StaticAccessor("ScriptableRuntimeReflectionSystem", 2)]
	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x2360B00 Offset: 0x235F100 VA: 0x182360B00
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x2360B30 Offset: 0x235F130 VA: 0x182360B30
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
[RequiredByNativeCode]
internal class ScriptableRuntimeReflectionSystemWrapper // TypeDefIndex: 10166
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Properties
	internal IScriptableRuntimeReflectionSystem implementation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x2360D20 Offset: 0x235F320 VA: 0x182360D20
	private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
[Flags]
public enum TextureCreationFlags // TypeDefIndex: 10167
{
	// Fields
	public int value__; // 0x0
	public const TextureCreationFlags None = 0;
	public const TextureCreationFlags MipChain = 1;
	public const TextureCreationFlags DontInitializePixels = 4;
	public const TextureCreationFlags Crunch = 64;
	public const TextureCreationFlags DontUploadUponCreate = 1024;
	[ExcludeFromDocs]
	[Obsolete("IgnoreMipmapLimit flag is no longer used since this is now the default behavior for all Texture shapes. Please provide mipmap limit information using a MipmapLimitDescriptor argument.", False)]
	public const TextureCreationFlags IgnoreMipmapLimit = 2048;
}

// Namespace: UnityEngine.Experimental.Rendering
[Flags]
public enum GraphicsFormatUsage // TypeDefIndex: 10168
{
	// Fields
	public int value__; // 0x0
	public const GraphicsFormatUsage None = 0;
	public const GraphicsFormatUsage Sample = 1;
	public const GraphicsFormatUsage Linear = 2;
	public const GraphicsFormatUsage Sparse = 4;
	public const GraphicsFormatUsage Render = 16;
	public const GraphicsFormatUsage Blend = 32;
	public const GraphicsFormatUsage GetPixels = 64;
	public const GraphicsFormatUsage SetPixels = 128;
	public const GraphicsFormatUsage SetPixels32 = 256;
	public const GraphicsFormatUsage ReadPixels = 512;
	public const GraphicsFormatUsage LoadStore = 1024;
	public const GraphicsFormatUsage MSAA2x = 2048;
	public const GraphicsFormatUsage MSAA4x = 4096;
	public const GraphicsFormatUsage MSAA8x = 8192;
	public const GraphicsFormatUsage StencilSampling = 65536;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum DefaultFormat // TypeDefIndex: 10169
{
	// Fields
	public int value__; // 0x0
	public const DefaultFormat LDR = 0;
	public const DefaultFormat HDR = 1;
	public const DefaultFormat DepthStencil = 2;
	public const DefaultFormat Shadow = 3;
	public const DefaultFormat Video = 4;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum GraphicsFormat // TypeDefIndex: 10170
{
	// Fields
	public int value__; // 0x0
	public const GraphicsFormat None = 0;
	public const GraphicsFormat R8_SRGB = 1;
	public const GraphicsFormat R8G8_SRGB = 2;
	public const GraphicsFormat R8G8B8_SRGB = 3;
	public const GraphicsFormat R8G8B8A8_SRGB = 4;
	public const GraphicsFormat R8_UNorm = 5;
	public const GraphicsFormat R8G8_UNorm = 6;
	public const GraphicsFormat R8G8B8_UNorm = 7;
	public const GraphicsFormat R8G8B8A8_UNorm = 8;
	public const GraphicsFormat R8_SNorm = 9;
	public const GraphicsFormat R8G8_SNorm = 10;
	public const GraphicsFormat R8G8B8_SNorm = 11;
	public const GraphicsFormat R8G8B8A8_SNorm = 12;
	public const GraphicsFormat R8_UInt = 13;
	public const GraphicsFormat R8G8_UInt = 14;
	public const GraphicsFormat R8G8B8_UInt = 15;
	public const GraphicsFormat R8G8B8A8_UInt = 16;
	public const GraphicsFormat R8_SInt = 17;
	public const GraphicsFormat R8G8_SInt = 18;
	public const GraphicsFormat R8G8B8_SInt = 19;
	public const GraphicsFormat R8G8B8A8_SInt = 20;
	public const GraphicsFormat R16_UNorm = 21;
	public const GraphicsFormat R16G16_UNorm = 22;
	public const GraphicsFormat R16G16B16_UNorm = 23;
	public const GraphicsFormat R16G16B16A16_UNorm = 24;
	public const GraphicsFormat R16_SNorm = 25;
	public const GraphicsFormat R16G16_SNorm = 26;
	public const GraphicsFormat R16G16B16_SNorm = 27;
	public const GraphicsFormat R16G16B16A16_SNorm = 28;
	public const GraphicsFormat R16_UInt = 29;
	public const GraphicsFormat R16G16_UInt = 30;
	public const GraphicsFormat R16G16B16_UInt = 31;
	public const GraphicsFormat R16G16B16A16_UInt = 32;
	public const GraphicsFormat R16_SInt = 33;
	public const GraphicsFormat R16G16_SInt = 34;
	public const GraphicsFormat R16G16B16_SInt = 35;
	public const GraphicsFormat R16G16B16A16_SInt = 36;
	public const GraphicsFormat R32_UInt = 37;
	public const GraphicsFormat R32G32_UInt = 38;
	public const GraphicsFormat R32G32B32_UInt = 39;
	public const GraphicsFormat R32G32B32A32_UInt = 40;
	public const GraphicsFormat R32_SInt = 41;
	public const GraphicsFormat R32G32_SInt = 42;
	public const GraphicsFormat R32G32B32_SInt = 43;
	public const GraphicsFormat R32G32B32A32_SInt = 44;
	public const GraphicsFormat R16_SFloat = 45;
	public const GraphicsFormat R16G16_SFloat = 46;
	public const GraphicsFormat R16G16B16_SFloat = 47;
	public const GraphicsFormat R16G16B16A16_SFloat = 48;
	public const GraphicsFormat R32_SFloat = 49;
	public const GraphicsFormat R32G32_SFloat = 50;
	public const GraphicsFormat R32G32B32_SFloat = 51;
	public const GraphicsFormat R32G32B32A32_SFloat = 52;
	public const GraphicsFormat B8G8R8_SRGB = 56;
	public const GraphicsFormat B8G8R8A8_SRGB = 57;
	public const GraphicsFormat B8G8R8_UNorm = 58;
	public const GraphicsFormat B8G8R8A8_UNorm = 59;
	public const GraphicsFormat B8G8R8_SNorm = 60;
	public const GraphicsFormat B8G8R8A8_SNorm = 61;
	public const GraphicsFormat B8G8R8_UInt = 62;
	public const GraphicsFormat B8G8R8A8_UInt = 63;
	public const GraphicsFormat B8G8R8_SInt = 64;
	public const GraphicsFormat B8G8R8A8_SInt = 65;
	public const GraphicsFormat R4G4B4A4_UNormPack16 = 66;
	public const GraphicsFormat B4G4R4A4_UNormPack16 = 67;
	public const GraphicsFormat R5G6B5_UNormPack16 = 68;
	public const GraphicsFormat B5G6R5_UNormPack16 = 69;
	public const GraphicsFormat R5G5B5A1_UNormPack16 = 70;
	public const GraphicsFormat B5G5R5A1_UNormPack16 = 71;
	public const GraphicsFormat A1R5G5B5_UNormPack16 = 72;
	public const GraphicsFormat E5B9G9R9_UFloatPack32 = 73;
	public const GraphicsFormat B10G11R11_UFloatPack32 = 74;
	public const GraphicsFormat A2B10G10R10_UNormPack32 = 75;
	public const GraphicsFormat A2B10G10R10_UIntPack32 = 76;
	public const GraphicsFormat A2B10G10R10_SIntPack32 = 77;
	public const GraphicsFormat A2R10G10B10_UNormPack32 = 78;
	public const GraphicsFormat A2R10G10B10_UIntPack32 = 79;
	public const GraphicsFormat A2R10G10B10_SIntPack32 = 80;
	public const GraphicsFormat A2R10G10B10_XRSRGBPack32 = 81;
	public const GraphicsFormat A2R10G10B10_XRUNormPack32 = 82;
	public const GraphicsFormat R10G10B10_XRSRGBPack32 = 83;
	public const GraphicsFormat R10G10B10_XRUNormPack32 = 84;
	public const GraphicsFormat A10R10G10B10_XRSRGBPack32 = 85;
	public const GraphicsFormat A10R10G10B10_XRUNormPack32 = 86;
	public const GraphicsFormat D16_UNorm = 90;
	public const GraphicsFormat D24_UNorm = 91;
	public const GraphicsFormat D24_UNorm_S8_UInt = 92;
	public const GraphicsFormat D32_SFloat = 93;
	public const GraphicsFormat D32_SFloat_S8_UInt = 94;
	public const GraphicsFormat S8_UInt = 95;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.RGB_DXT1_SRGB has been deprecated. Use GraphicsFormat.RGBA_DXT1_SRGB instead (UnityUpgradable) -> RGBA_DXT1_SRGB", True)]
	public const GraphicsFormat RGB_DXT1_SRGB = 96;
	public const GraphicsFormat RGBA_DXT1_SRGB = 96;
	[Obsolete("Enum member GraphicsFormat.RGB_DXT1_UNorm has been deprecated. Use GraphicsFormat.RGBA_DXT1_UNorm instead (UnityUpgradable) -> RGBA_DXT1_UNorm", True)]
	[EditorBrowsable(1)]
	public const GraphicsFormat RGB_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT3_SRGB = 98;
	public const GraphicsFormat RGBA_DXT3_UNorm = 99;
	public const GraphicsFormat RGBA_DXT5_SRGB = 100;
	public const GraphicsFormat RGBA_DXT5_UNorm = 101;
	public const GraphicsFormat R_BC4_UNorm = 102;
	public const GraphicsFormat R_BC4_SNorm = 103;
	public const GraphicsFormat RG_BC5_UNorm = 104;
	public const GraphicsFormat RG_BC5_SNorm = 105;
	public const GraphicsFormat RGB_BC6H_UFloat = 106;
	public const GraphicsFormat RGB_BC6H_SFloat = 107;
	public const GraphicsFormat RGBA_BC7_SRGB = 108;
	public const GraphicsFormat RGBA_BC7_UNorm = 109;
	public const GraphicsFormat RGB_PVRTC_2Bpp_SRGB = 110;
	public const GraphicsFormat RGB_PVRTC_2Bpp_UNorm = 111;
	public const GraphicsFormat RGB_PVRTC_4Bpp_SRGB = 112;
	public const GraphicsFormat RGB_PVRTC_4Bpp_UNorm = 113;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_SRGB = 114;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_UNorm = 115;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_SRGB = 116;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_UNorm = 117;
	public const GraphicsFormat RGB_ETC_UNorm = 118;
	public const GraphicsFormat RGB_ETC2_SRGB = 119;
	public const GraphicsFormat RGB_ETC2_UNorm = 120;
	public const GraphicsFormat RGB_A1_ETC2_SRGB = 121;
	public const GraphicsFormat RGB_A1_ETC2_UNorm = 122;
	public const GraphicsFormat RGBA_ETC2_SRGB = 123;
	public const GraphicsFormat RGBA_ETC2_UNorm = 124;
	public const GraphicsFormat R_EAC_UNorm = 125;
	public const GraphicsFormat R_EAC_SNorm = 126;
	public const GraphicsFormat RG_EAC_UNorm = 127;
	public const GraphicsFormat RG_EAC_SNorm = 128;
	public const GraphicsFormat RGBA_ASTC4X4_SRGB = 129;
	public const GraphicsFormat RGBA_ASTC4X4_UNorm = 130;
	public const GraphicsFormat RGBA_ASTC5X5_SRGB = 131;
	public const GraphicsFormat RGBA_ASTC5X5_UNorm = 132;
	public const GraphicsFormat RGBA_ASTC6X6_SRGB = 133;
	public const GraphicsFormat RGBA_ASTC6X6_UNorm = 134;
	public const GraphicsFormat RGBA_ASTC8X8_SRGB = 135;
	public const GraphicsFormat RGBA_ASTC8X8_UNorm = 136;
	public const GraphicsFormat RGBA_ASTC10X10_SRGB = 137;
	public const GraphicsFormat RGBA_ASTC10X10_UNorm = 138;
	public const GraphicsFormat RGBA_ASTC12X12_SRGB = 139;
	public const GraphicsFormat RGBA_ASTC12X12_UNorm = 140;
	public const GraphicsFormat YUV2 = 141;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.DepthAuto is obsolete. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default depth buffer format.", True)]
	public const GraphicsFormat DepthAuto = 142;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.ShadowAuto is obsolete. Use GraphicsFormat.None as a color format to indicate depth only rendering, DefaultFormat to get the default shadow buffer format and ShadowSamplingMode.CompareDepths to enable shadowmap sampling.", True)]
	public const GraphicsFormat ShadowAuto = 143;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.VideoAuto is obsolete. Use DefaultFormat instead.", True)]
	public const GraphicsFormat VideoAuto = 144;
	public const GraphicsFormat RGBA_ASTC4X4_UFloat = 145;
	public const GraphicsFormat RGBA_ASTC5X5_UFloat = 146;
	public const GraphicsFormat RGBA_ASTC6X6_UFloat = 147;
	public const GraphicsFormat RGBA_ASTC8X8_UFloat = 148;
	public const GraphicsFormat RGBA_ASTC10X10_UFloat = 149;
	public const GraphicsFormat RGBA_ASTC12X12_UFloat = 150;
	public const GraphicsFormat D16_UNorm_S8_UInt = 151;
}

// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/Format.h")]
public class GraphicsFormatUtility // TypeDefIndex: 10171
{
	// Fields
	private static readonly GraphicsFormat[] tableNoStencil; // 0x0
	private static readonly GraphicsFormat[] tableStencil; // 0x8

	// Methods

	// RVA: 0x2353640 Offset: 0x2351C40 VA: 0x182353640
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x23534B0 Offset: 0x2351AB0 VA: 0x1823534B0
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x23535C0 Offset: 0x2351BC0 VA: 0x1823535C0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = False)]
	// RVA: 0x2353470 Offset: 0x2351A70 VA: 0x182353470
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x23534F0 Offset: 0x2351AF0 VA: 0x1823534F0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2353130 Offset: 0x2351730 VA: 0x182353130
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x2353170 Offset: 0x2351770 VA: 0x182353170
	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x23530F0 Offset: 0x23516F0 VA: 0x1823530F0
	public static int GetDepthBits(GraphicsFormat format) { }

	// RVA: 0x23531E0 Offset: 0x23517E0 VA: 0x1823531E0
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2353930 Offset: 0x2351F30 VA: 0x182353930
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2353740 Offset: 0x2351D40 VA: 0x182353740
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x23536C0 Offset: 0x2351CC0 VA: 0x1823536C0
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2353700 Offset: 0x2351D00 VA: 0x182353700
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x23537C0 Offset: 0x2351DC0 VA: 0x1823537C0
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x2353800 Offset: 0x2351E00 VA: 0x182353800
	public static bool IsCompressedFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x23530B0 Offset: 0x23516B0 VA: 0x1823530B0
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x2353040 Offset: 0x2351640 VA: 0x182353040
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2353780 Offset: 0x2351D80 VA: 0x182353780
	public static bool HasAlphaChannel(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x23538B0 Offset: 0x2351EB0 VA: 0x1823538B0
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x23538F0 Offset: 0x2351EF0 VA: 0x1823538F0
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	// RVA: 0x2353870 Offset: 0x2351E70 VA: 0x182353870
	public static bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x2353970 Offset: 0x2351F70 VA: 0x182353970
	private static void .cctor() { }
}

