// Namespace: UnityEngine
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
public struct SortingLayer // TypeDefIndex: 9500
{
	// Fields
	private int m_Id; // 0x0

	// Methods

	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	// RVA: 0x2313C20 Offset: 0x2312220 VA: 0x182313C20
	public static int GetLayerValueFromID(int id) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public struct Keyframe // TypeDefIndex: 9501
{
	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	// Properties
	public float time { get; set; }
	public float value { get; set; }
	public float inTangent { get; set; }
	public float outTangent { get; set; }
	[Obsolete("Use AnimationUtility.SetKeyLeftTangentMode, AnimationUtility.SetKeyRightTangentMode, AnimationUtility.GetKeyLeftTangentMode or AnimationUtility.GetKeyRightTangentMode instead.")]
	public int tangentMode { get; set; }
	internal int tangentModeInternal { get; set; }

	// Methods

	// RVA: 0x22FFFD0 Offset: 0x22FE5D0 VA: 0x1822FFFD0
	public void .ctor(float time, float value) { }

	// RVA: 0x22FFFA0 Offset: 0x22FE5A0 VA: 0x1822FFFA0
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_time() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_time(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_value() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_value(float value) { }

	// RVA: 0x22FFFF0 Offset: 0x22FE5F0 VA: 0x1822FFFF0
	public float get_inTangent() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_inTangent(float value) { }

	// RVA: 0x22E91B0 Offset: 0x22E77B0 VA: 0x1822E91B0
	public float get_outTangent() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_outTangent(float value) { }

	// RVA: 0xA6D740 Offset: 0xA6BD40 VA: 0x180A6D740
	public int get_tangentMode() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void set_tangentMode(int value) { }

	// RVA: 0xA6D740 Offset: 0xA6BD40 VA: 0x180A6D740
	internal int get_tangentModeInternal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void set_tangentModeInternal(int value) { }
}

// Namespace: UnityEngine
public enum WrapMode // TypeDefIndex: 9502
{
	// Fields
	public int value__; // 0x0
	public const WrapMode Once = 1;
	public const WrapMode Loop = 2;
	public const WrapMode PingPong = 4;
	public const WrapMode Default = 0;
	public const WrapMode ClampForever = 8;
	public const WrapMode Clamp = 1;
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 9504
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	internal IntPtr m_Ptr; // 0x10
	private bool m_RequiresNativeCleanup; // 0x18

	// Properties
	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { get; set; }
	public WrapMode postWrapMode { get; set; }

	// Methods

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x22EF730 Offset: 0x22EDD30 VA: 0x1822EF730
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x22EF670 Offset: 0x22EDC70 VA: 0x1822EF670
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x22EF7C0 Offset: 0x22EDDC0 VA: 0x1822EF7C0
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x22EF2D0 Offset: 0x22ED8D0 VA: 0x1822EF2D0 Slot: 1
	protected override void Finalize() { }

	[ThreadSafe]
	// RVA: 0x22EF260 Offset: 0x22ED860 VA: 0x1822EF260
	public float Evaluate(float time) { }

	// RVA: 0x22EFDE0 Offset: 0x22EE3E0 VA: 0x1822EFDE0
	public Keyframe[] get_keys() { }

	// RVA: 0x22EFB10 Offset: 0x22EE110 VA: 0x1822EFB10
	public void set_keys(Keyframe[] value) { }

	// RVA: 0x22EEF10 Offset: 0x22ED510 VA: 0x1822EEF10
	public int AddKey(Keyframe key) { }

	[NativeMethod("AddKey", IsThreadSafe = True)]
	// RVA: 0x22EEEB0 Offset: 0x22ED4B0 VA: 0x1822EEEB0
	private int AddKey_Internal(Keyframe key) { }

	[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	// RVA: 0x22EFA60 Offset: 0x22EE060 VA: 0x1822EFA60
	public void RemoveKey(int index) { }

	// RVA: 0x22EFD30 Offset: 0x22EE330 VA: 0x1822EFD30
	public Keyframe get_Item(int index) { }

	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	// RVA: 0x22EFE30 Offset: 0x22EE430 VA: 0x1822EFE30
	public int get_length() { }

	[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x22EFB10 Offset: 0x22EE110 VA: 0x1822EFB10
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	// RVA: 0x22EF440 Offset: 0x22EDA40 VA: 0x1822EF440
	private Keyframe GetKey(int index) { }

	[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x22EF520 Offset: 0x22EDB20 VA: 0x1822EF520
	private Keyframe[] GetKeys() { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x22EF390 Offset: 0x22ED990 VA: 0x1822EF390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22EF820 Offset: 0x22EDE20 VA: 0x1822EF820
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethod("GetPreInfinity", IsThreadSafe = True)]
	// RVA: 0x22EFF70 Offset: 0x22EE570 VA: 0x1822EFF70
	public WrapMode get_preWrapMode() { }

	[NativeMethod("SetPreInfinity", IsThreadSafe = True)]
	// RVA: 0x22F00B0 Offset: 0x22EE6B0 VA: 0x1822F00B0
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethod("GetPostInfinity", IsThreadSafe = True)]
	// RVA: 0x22EFED0 Offset: 0x22EE4D0 VA: 0x1822EFED0
	public WrapMode get_postWrapMode() { }

	[NativeMethod("SetPostInfinity", IsThreadSafe = True)]
	// RVA: 0x22F0010 Offset: 0x22EE610 VA: 0x1822F0010
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x22EFCF0 Offset: 0x22EE2F0 VA: 0x1822EFCF0
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCode]
	// RVA: 0x22EFC10 Offset: 0x22EE210 VA: 0x1822EFC10
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	// RVA: 0x22EFCC0 Offset: 0x22EE2C0 VA: 0x1822EFCC0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x22EF090 Offset: 0x22ED690 VA: 0x1822EF090 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x22EEF90 Offset: 0x22ED590 VA: 0x1822EEF90 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x22EF630 Offset: 0x22EDC30 VA: 0x1822EF630
	private static IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys) { }

	// RVA: 0x22EF770 Offset: 0x22EDD70 VA: 0x1822EF770
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	// RVA: 0x22EF210 Offset: 0x22ED810 VA: 0x1822EF210
	private static float Evaluate_Injected(IntPtr _unity_self, float time) { }

	// RVA: 0x22EEE60 Offset: 0x22ED460 VA: 0x1822EEE60
	private static int AddKey_Internal_Injected(IntPtr _unity_self, in Keyframe key) { }

	// RVA: 0x22EFA20 Offset: 0x22EE020 VA: 0x1822EFA20
	private static void RemoveKey_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x22EFDF0 Offset: 0x22EE3F0 VA: 0x1822EFDF0
	private static int get_length_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EFAC0 Offset: 0x22EE0C0 VA: 0x1822EFAC0
	private static void SetKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keys) { }

	// RVA: 0x22EF3F0 Offset: 0x22ED9F0 VA: 0x1822EF3F0
	private static void GetKey_Injected(IntPtr _unity_self, int index, out Keyframe ret) { }

	// RVA: 0x22EF4D0 Offset: 0x22EDAD0 VA: 0x1822EF4D0
	private static void GetKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	// RVA: 0x22EF350 Offset: 0x22ED950 VA: 0x1822EF350
	private static int GetHashCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EFF30 Offset: 0x22EE530 VA: 0x1822EFF30
	private static WrapMode get_preWrapMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F0070 Offset: 0x22EE670 VA: 0x1822F0070
	private static void set_preWrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

	// RVA: 0x22EFE90 Offset: 0x22EE490 VA: 0x1822EFE90
	private static WrapMode get_postWrapMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EFFD0 Offset: 0x22EE5D0 VA: 0x1822EFFD0
	private static void set_postWrapMode_Injected(IntPtr _unity_self, WrapMode value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
public class Application // TypeDefIndex: 9508
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Application.LowMemoryCallback lowMemory; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Application.MemoryUsageChangedCallback memoryUsageChanged; // 0x8
	private static Application.LogCallback s_LogCallbackHandler; // 0x10
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool> focusChanged; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string> deepLinkActivated; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Func<bool> wantsToQuit; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action quitting; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action unloading; // 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; // 0x48

	// Properties
	public static bool isPlaying { get; }
	public static bool isFocused { get; }
	public static bool runInBackground { get; }
	public static bool isBatchMode { get; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	public static string persistentDataPath { get; }
	public static string unityVersion { get; }
	public static string version { get; }
	public static int targetFrameRate { set; }
	public static RuntimePlatform platform { get; }
	public static SystemLanguage systemLanguage { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunction("GetInputManager().QuitApplication")]
	// RVA: 0x22F0A50 Offset: 0x22EF050 VA: 0x1822F0A50
	public static void Quit(int exitCode) { }

	// RVA: 0x22F0A90 Offset: 0x22EF090 VA: 0x1822F0A90
	public static void Quit() { }

	[FreeFunction("IsWorldPlaying")]
	// RVA: 0x22F0E10 Offset: 0x22EF410 VA: 0x1822F0E10
	public static bool get_isPlaying() { }

	[FreeFunction("IsPlayerFocused")]
	// RVA: 0x22F0DE0 Offset: 0x22EF3E0 VA: 0x1822F0DE0
	public static bool get_isFocused() { }

	[FreeFunction("GetPlayerSettingsRunInBackground")]
	// RVA: 0x22F0F90 Offset: 0x22EF590 VA: 0x1822F0F90
	public static bool get_runInBackground() { }

	[FreeFunction("::IsBatchmode")]
	// RVA: 0x22F0DA0 Offset: 0x22EF3A0 VA: 0x1822F0DA0
	public static bool get_isBatchMode() { }

	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	// RVA: 0x22F0CC0 Offset: 0x22EF2C0 VA: 0x1822F0CC0
	public static string get_dataPath() { }

	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	// RVA: 0x22F1000 Offset: 0x22EF600 VA: 0x1822F1000
	public static string get_streamingAssetsPath() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	// RVA: 0x22F0E80 Offset: 0x22EF480 VA: 0x1822F0E80
	public static string get_persistentDataPath() { }

	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	// RVA: 0x22F1150 Offset: 0x22EF750 VA: 0x1822F1150
	public static string get_unityVersion() { }

	[FreeFunction("GetApplicationInfo().GetVersion")]
	// RVA: 0x22F1270 Offset: 0x22EF870 VA: 0x1822F1270
	public static string get_version() { }

	[FreeFunction("OpenURL")]
	// RVA: 0x22F08C0 Offset: 0x22EEEC0 VA: 0x1822F08C0
	public static void OpenURL(string url) { }

	[FreeFunction("SetTargetFrameRate")]
	// RVA: 0x22F1460 Offset: 0x22EFA60 VA: 0x1822F1460
	public static void set_targetFrameRate(int value) { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	// RVA: 0x22F0F60 Offset: 0x22EF560 VA: 0x1822F0F60
	public static RuntimePlatform get_platform() { }

	[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
	// RVA: 0x22F10E0 Offset: 0x22EF6E0 VA: 0x1822F10E0
	public static SystemLanguage get_systemLanguage() { }

	[RequiredByNativeCode]
	// RVA: 0x22F0200 Offset: 0x22EE800 VA: 0x1822F0200
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[RequiredByNativeCode]
	// RVA: 0x22F0340 Offset: 0x22EE940 VA: 0x1822F0340
	internal static bool HasLogCallback() { }

	[RequiredByNativeCode]
	// RVA: 0x22F0110 Offset: 0x22EE710 VA: 0x1822F0110
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[CompilerGenerated]
	// RVA: 0x22F0B70 Offset: 0x22EF170 VA: 0x1822F0B70
	public static void add_focusChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x22F1350 Offset: 0x22EF950 VA: 0x1822F1350
	public static void remove_focusChanged(Action<bool> value) { }

	[RequiredByNativeCode]
	// RVA: 0x22F0560 Offset: 0x22EEB60 VA: 0x1822F0560
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x22F03C0 Offset: 0x22EE9C0 VA: 0x1822F03C0
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x22F04D0 Offset: 0x22EEAD0 VA: 0x1822F04D0
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	// RVA: 0x22F0840 Offset: 0x22EEE40 VA: 0x1822F0840
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCode]
	// RVA: 0x22F07A0 Offset: 0x22EEDA0 VA: 0x1822F07A0
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	// RVA: 0x22F0700 Offset: 0x22EED00 VA: 0x1822F0700
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x22F0DD0 Offset: 0x22EF3D0 VA: 0x1822F0DD0
	public static bool get_isEditor() { }

	// RVA: 0x22F0AF0 Offset: 0x22EF0F0 VA: 0x1822F0AF0
	private static void .cctor() { }

	// RVA: 0x22F0C80 Offset: 0x22EF280 VA: 0x1822F0C80
	private static void get_dataPath_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x22F0FC0 Offset: 0x22EF5C0 VA: 0x1822F0FC0
	private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x22F0E40 Offset: 0x22EF440 VA: 0x1822F0E40
	private static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x22F1110 Offset: 0x22EF710 VA: 0x1822F1110
	private static void get_unityVersion_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x22F1230 Offset: 0x22EF830 VA: 0x1822F1230
	private static void get_version_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x22F0880 Offset: 0x22EEE80 VA: 0x1822F0880
	private static void OpenURL_Injected(ref ManagedSpanWrapper url) { }
}

// Namespace: UnityEngine
public enum ApplicationMemoryUsage // TypeDefIndex: 9509
{
	// Fields
	public int value__; // 0x0
	public const ApplicationMemoryUsage Unknown = 0;
	public const ApplicationMemoryUsage Low = 1;
	public const ApplicationMemoryUsage Medium = 2;
	public const ApplicationMemoryUsage High = 3;
	public const ApplicationMemoryUsage Critical = 4;
}

// Namespace: UnityEngine
public struct ApplicationMemoryUsageChange // TypeDefIndex: 9510
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ApplicationMemoryUsage <memoryUsage>k__BackingField; // 0x0

	// Properties
	private ApplicationMemoryUsage memoryUsage { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(ApplicationMemoryUsage usage) { }
}

// Namespace: UnityEngine
public enum SendMessageOptions // TypeDefIndex: 9511
{
	// Fields
	public int value__; // 0x0
	public const SendMessageOptions RequireReceiver = 0;
	public const SendMessageOptions DontRequireReceiver = 1;
}

// Namespace: UnityEngine
public enum PrimitiveType // TypeDefIndex: 9512
{
	// Fields
	public int value__; // 0x0
	public const PrimitiveType Sphere = 0;
	public const PrimitiveType Capsule = 1;
	public const PrimitiveType Cylinder = 2;
	public const PrimitiveType Cube = 3;
	public const PrimitiveType Plane = 4;
	public const PrimitiveType Quad = 5;
}

// Namespace: UnityEngine
public enum Space // TypeDefIndex: 9513
{
	// Fields
	public int value__; // 0x0
	public const Space World = 0;
	public const Space Self = 1;
}

// Namespace: UnityEngine
public enum RuntimePlatform // TypeDefIndex: 9514
{
	// Fields
	public int value__; // 0x0
	public const RuntimePlatform OSXEditor = 0;
	public const RuntimePlatform OSXPlayer = 1;
	public const RuntimePlatform WindowsPlayer = 2;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXWebPlayer = 3;
	[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXDashboardPlayer = 4;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform WindowsWebPlayer = 5;
	public const RuntimePlatform WindowsEditor = 7;
	public const RuntimePlatform IPhonePlayer = 8;
	[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
	public const RuntimePlatform XBOX360 = 10;
	[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
	public const RuntimePlatform PS3 = 9;
	public const RuntimePlatform Android = 11;
	[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform NaCl = 12;
	[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform FlashPlayer = 15;
	public const RuntimePlatform LinuxPlayer = 13;
	public const RuntimePlatform LinuxEditor = 16;
	public const RuntimePlatform WebGLPlayer = 17;
	[Obsolete("Use WSAPlayerX86 instead")]
	public const RuntimePlatform MetroPlayerX86 = 18;
	public const RuntimePlatform WSAPlayerX86 = 18;
	[Obsolete("Use WSAPlayerX64 instead")]
	public const RuntimePlatform MetroPlayerX64 = 19;
	public const RuntimePlatform WSAPlayerX64 = 19;
	[Obsolete("Use WSAPlayerARM instead")]
	public const RuntimePlatform MetroPlayerARM = 20;
	public const RuntimePlatform WSAPlayerARM = 20;
	[Obsolete("Windows Phone 8 was removed in 5.3")]
	public const RuntimePlatform WP8Player = 21;
	[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
	public const RuntimePlatform BlackBerryPlayer = 22;
	[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform TizenPlayer = 23;
	[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
	public const RuntimePlatform PSP2 = 24;
	public const RuntimePlatform PS4 = 25;
	[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
	public const RuntimePlatform PSM = 26;
	public const RuntimePlatform XboxOne = 27;
	[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform SamsungTVPlayer = 28;
	[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
	public const RuntimePlatform WiiU = 30;
	public const RuntimePlatform tvOS = 31;
	public const RuntimePlatform Switch = 32;
	[Obsolete("Lumin is no longer supported in Unity 2022.2")]
	public const RuntimePlatform Lumin = 33;
	[Obsolete("Stadia is no longer supported in Unity 2023.1")]
	public const RuntimePlatform Stadia = 34;
	[Obsolete("CloudRendering is deprecated, please use LinuxHeadlessSimulation (UnityUpgradable) -> LinuxHeadlessSimulation", False)]
	public const RuntimePlatform CloudRendering = -1;
	public const RuntimePlatform LinuxHeadlessSimulation = 35;
	[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
	public const RuntimePlatform GameCoreScarlett = -1;
	public const RuntimePlatform GameCoreXboxSeries = 36;
	public const RuntimePlatform GameCoreXboxOne = 37;
	public const RuntimePlatform PS5 = 38;
	public const RuntimePlatform EmbeddedLinuxArm64 = 39;
	public const RuntimePlatform EmbeddedLinuxArm32 = 40;
	public const RuntimePlatform EmbeddedLinuxX64 = 41;
	public const RuntimePlatform EmbeddedLinuxX86 = 42;
	public const RuntimePlatform LinuxServer = 43;
	public const RuntimePlatform WindowsServer = 44;
	public const RuntimePlatform OSXServer = 45;
	public const RuntimePlatform QNXArm32 = 46;
	public const RuntimePlatform QNXArm64 = 47;
	public const RuntimePlatform QNXX64 = 48;
	public const RuntimePlatform QNXX86 = 49;
}

// Namespace: UnityEngine
public enum SystemLanguage // TypeDefIndex: 9515
{
	// Fields
	public int value__; // 0x0
	public const SystemLanguage Afrikaans = 0;
	public const SystemLanguage Arabic = 1;
	public const SystemLanguage Basque = 2;
	public const SystemLanguage Belarusian = 3;
	public const SystemLanguage Bulgarian = 4;
	public const SystemLanguage Catalan = 5;
	public const SystemLanguage Chinese = 6;
	public const SystemLanguage Czech = 7;
	public const SystemLanguage Danish = 8;
	public const SystemLanguage Dutch = 9;
	public const SystemLanguage English = 10;
	public const SystemLanguage Estonian = 11;
	public const SystemLanguage Faroese = 12;
	public const SystemLanguage Finnish = 13;
	public const SystemLanguage French = 14;
	public const SystemLanguage German = 15;
	public const SystemLanguage Greek = 16;
	public const SystemLanguage Hebrew = 17;
	public const SystemLanguage Icelandic = 19;
	public const SystemLanguage Indonesian = 20;
	public const SystemLanguage Italian = 21;
	public const SystemLanguage Japanese = 22;
	public const SystemLanguage Korean = 23;
	public const SystemLanguage Latvian = 24;
	public const SystemLanguage Lithuanian = 25;
	public const SystemLanguage Norwegian = 26;
	public const SystemLanguage Polish = 27;
	public const SystemLanguage Portuguese = 28;
	public const SystemLanguage Romanian = 29;
	public const SystemLanguage Russian = 30;
	public const SystemLanguage SerboCroatian = 31;
	public const SystemLanguage Slovak = 32;
	public const SystemLanguage Slovenian = 33;
	public const SystemLanguage Spanish = 34;
	public const SystemLanguage Swedish = 35;
	public const SystemLanguage Thai = 36;
	public const SystemLanguage Turkish = 37;
	public const SystemLanguage Ukrainian = 38;
	public const SystemLanguage Vietnamese = 39;
	public const SystemLanguage ChineseSimplified = 40;
	public const SystemLanguage ChineseTraditional = 41;
	public const SystemLanguage Hindi = 42;
	public const SystemLanguage Unknown = 43;
	public const SystemLanguage Hungarian = 18;
}

// Namespace: UnityEngine
public enum LogType // TypeDefIndex: 9516
{
	// Fields
	public int value__; // 0x0
	public const LogType Error = 0;
	public const LogType Assert = 1;
	public const LogType Warning = 2;
	public const LogType Log = 3;
	public const LogType Exception = 4;
}

// Namespace: UnityEngine
public enum LogOption // TypeDefIndex: 9517
{
	// Fields
	public int value__; // 0x0
	public const LogOption None = 0;
	public const LogOption NoStacktrace = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
internal class BootConfigData // TypeDefIndex: 9518
{
	// Fields
	private IntPtr m_Ptr; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x22F1870 Offset: 0x22EFE70 VA: 0x1822F1870
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x22F1920 Offset: 0x22EFF20 VA: 0x1822F1920
	private void .ctor(IntPtr nativeHandle) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct CachedAssetBundle // TypeDefIndex: 9519
{
	// Fields
	private string m_Name; // 0x0
	private Hash128 m_Hash; // 0x8

	// Properties
	public string name { get; }
	public Hash128 hash { get; }

	// Methods

	// RVA: 0x10936D0 Offset: 0x1091CD0 VA: 0x1810936D0
	public void .ctor(string name, Hash128 hash) { }

	// RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	public string get_name() { }

	// RVA: 0x22F2980 Offset: 0x22F0F80 VA: 0x1822F2980
	public Hash128 get_hash() { }
}

// Namespace: UnityEngine
[StaticAccessor("CacheWrapper", 2)]
[NativeHeader("Runtime/Misc/Cache.h")]
public struct Cache : IEquatable<Cache> // TypeDefIndex: 9520
{
	// Fields
	private int m_Handle; // 0x0

	// Properties
	internal int handle { get; }
	public bool valid { get; }
	public string path { get; }
	public long maximumAvailableStorageSpace { set; }
	public int expirationDelay { set; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	internal int get_handle() { }

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22F2810 Offset: 0x22F0E10 VA: 0x1822F2810 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(Cache other) { }

	// RVA: 0x22F28C0 Offset: 0x22F0EC0 VA: 0x1822F28C0
	public bool get_valid() { }

	// RVA: 0x22F2750 Offset: 0x22F0D50 VA: 0x1822F2750
	internal static bool Cache_IsValid(int handle) { }

	// RVA: 0x22F28B0 Offset: 0x22F0EB0 VA: 0x1822F28B0
	public string get_path() { }

	[NativeThrows]
	// RVA: 0x22F26A0 Offset: 0x22F0CA0 VA: 0x1822F26A0
	internal static string Cache_GetPath(int handle) { }

	// RVA: 0x22F2940 Offset: 0x22F0F40 VA: 0x1822F2940
	public void set_maximumAvailableStorageSpace(long value) { }

	[NativeThrows]
	// RVA: 0x22F27D0 Offset: 0x22F0DD0 VA: 0x1822F27D0
	internal static void Cache_SetMaximumDiskSpaceAvailable(int handle, long value) { }

	// RVA: 0x22F2900 Offset: 0x22F0F00 VA: 0x1822F2900
	public void set_expirationDelay(int value) { }

	[NativeThrows]
	// RVA: 0x22F2790 Offset: 0x22F0D90 VA: 0x1822F2790
	internal static void Cache_SetExpirationDelay(int handle, int value) { }

	// RVA: 0x22F2660 Offset: 0x22F0C60 VA: 0x1822F2660
	private static void Cache_GetPath_Injected(int handle, out ManagedSpanWrapper ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/CachingManager.h")]
[StaticAccessor("GetCachingManager()", 0)]
public sealed class Caching // TypeDefIndex: 9521
{
	// Properties
	public static bool compressionEnabled { set; }
	public static bool ready { get; }
	[StaticAccessor("CachingManagerWrapper", 2)]
	public static Cache defaultCache { get; }
	[StaticAccessor("CachingManagerWrapper", 2)]
	public static Cache currentCacheForWriting { get; set; }

	// Methods

	// RVA: 0x22F3A60 Offset: 0x22F2060 VA: 0x1822F3A60
	public static void set_compressionEnabled(bool value) { }

	[NativeName("GetIsReady")]
	// RVA: 0x22F3A30 Offset: 0x22F2030 VA: 0x1822F3A30
	public static bool get_ready() { }

	// RVA: 0x22F3060 Offset: 0x22F1660 VA: 0x1822F3060
	public static bool ClearCachedVersion(string assetBundleName, Hash128 hash) { }

	[NativeName("ClearCachedVersion")]
	// RVA: 0x22F2EC0 Offset: 0x22F14C0 VA: 0x1822F2EC0
	internal static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash) { }

	// RVA: 0x22F32F0 Offset: 0x22F18F0 VA: 0x1822F32F0
	public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash) { }

	// RVA: 0x22F2DF0 Offset: 0x22F13F0 VA: 0x1822F2DF0
	public static bool ClearAllCachedVersions(string assetBundleName) { }

	// RVA: 0x22F3150 Offset: 0x22F1750 VA: 0x1822F3150
	internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion) { }

	// RVA: 0x22F3880 Offset: 0x22F1E80 VA: 0x1822F3880
	public static bool IsVersionCached(CachedAssetBundle cachedBundle) { }

	[NativeName("IsCached")]
	// RVA: 0x22F35F0 Offset: 0x22F1BF0 VA: 0x1822F35F0
	internal static bool IsVersionCached(string url, string assetBundleName, Hash128 hash) { }

	// RVA: 0x22F2BB0 Offset: 0x22F11B0 VA: 0x1822F2BB0
	public static Cache AddCache(string cachePath) { }

	[NativeName("AddCachePath")]
	// RVA: 0x22F29F0 Offset: 0x22F0FF0 VA: 0x1822F29F0
	internal static Cache AddCache(string cachePath, bool isReadonly) { }

	[NativeName("Caching_GetCacheHandleByPath")]
	[StaticAccessor("CachingManagerWrapper", 2)]
	[NativeThrows]
	// RVA: 0x22F33D0 Offset: 0x22F19D0 VA: 0x1822F33D0
	public static Cache GetCacheByPath(string cachePath) { }

	[NativeName("Caching_GetDefaultCacheHandle")]
	// RVA: 0x22F39F0 Offset: 0x22F1FF0 VA: 0x1822F39F0
	public static Cache get_defaultCache() { }

	[NativeName("Caching_GetCurrentCacheHandle")]
	// RVA: 0x22F3970 Offset: 0x22F1F70 VA: 0x1822F3970
	public static Cache get_currentCacheForWriting() { }

	[NativeThrows]
	[NativeName("Caching_SetCurrentCacheByHandle")]
	// RVA: 0x22F3AE0 Offset: 0x22F20E0 VA: 0x1822F3AE0
	public static void set_currentCacheForWriting(Cache value) { }

	// RVA: 0x22F2E70 Offset: 0x22F1470 VA: 0x1822F2E70
	private static bool ClearCachedVersionInternal_Injected(ref ManagedSpanWrapper assetBundleName, in Hash128 hash) { }

	// RVA: 0x22F30F0 Offset: 0x22F16F0 VA: 0x1822F30F0
	private static bool ClearCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, in Hash128 hash, bool keepInputVersion) { }

	// RVA: 0x22F3590 Offset: 0x22F1B90 VA: 0x1822F3590
	private static bool IsVersionCached_Injected(ref ManagedSpanWrapper url, ref ManagedSpanWrapper assetBundleName, in Hash128 hash) { }

	// RVA: 0x22F2990 Offset: 0x22F0F90 VA: 0x1822F2990
	private static void AddCache_Injected(ref ManagedSpanWrapper cachePath, bool isReadonly, out Cache ret) { }

	// RVA: 0x22F3380 Offset: 0x22F1980 VA: 0x1822F3380
	private static void GetCacheByPath_Injected(ref ManagedSpanWrapper cachePath, out Cache ret) { }

	// RVA: 0x22F39B0 Offset: 0x22F1FB0 VA: 0x1822F39B0
	private static void get_defaultCache_Injected(out Cache ret) { }

	// RVA: 0x22F3930 Offset: 0x22F1F30 VA: 0x1822F3930
	private static void get_currentCacheForWriting_Injected(out Cache ret) { }

	// RVA: 0x22F3AA0 Offset: 0x22F20A0 VA: 0x1822F3AA0
	private static void set_currentCacheForWriting_Injected(in Cache value) { }
}

// Namespace: UnityEngine
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class BatchRendererGroupRuntimeAnalytic : AnalyticsEventBase // TypeDefIndex: 9522
{
	// Fields
	private int brgRuntimeStatus; // 0x30

	// Methods

	// RVA: 0x22F15D0 Offset: 0x22EFBD0 VA: 0x1822F15D0
	private void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x22F1540 Offset: 0x22EFB40 VA: 0x1822F1540
	public static BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
public sealed class Camera : Behaviour // TypeDefIndex: 9526
{
	// Fields
	public const float kMinAperture = 0.7;
	public const float kMaxAperture = 32;
	public const int kMinBladeCount = 3;
	public const int kMaxBladeCount = 11;
	internal uint m_NonSerializedVersion; // 0x18
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativeProperty("Near")]
	public float nearClipPlane { get; }
	[NativeProperty("Far")]
	public float farClipPlane { get; set; }
	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { set; }
	public bool allowDynamicResolution { get; }
	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture { set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public float depth { get; }
	public float aspect { get; }
	public int cullingMask { get; set; }
	public int eventMask { get; }
	public CameraType cameraType { get; }
	public bool useOcclusionCulling { set; }
	public Color backgroundColor { set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool usePhysicalProperties { get; set; }
	[NativeProperty("NormalizedViewportRect")]
	public Rect rect { get; }
	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect { get; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public int scaledPixelWidth { get; }
	public int scaledPixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public int targetDisplay { get; }
	public Matrix4x4 worldToCameraMatrix { get; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { set; }
	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering { set; }
	public static Camera main { get; }
	public static Camera current { get; }
	public bool stereoEnabled { get; }
	public StereoTargetEyeMask stereoTargetEye { get; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }

	// Methods

	// RVA: 0x22F60D0 Offset: 0x22F46D0 VA: 0x1822F60D0
	public float get_nearClipPlane() { }

	// RVA: 0x22F5EC0 Offset: 0x22F44C0 VA: 0x1822F5EC0
	public float get_farClipPlane() { }

	// RVA: 0x22F7370 Offset: 0x22F5970 VA: 0x1822F7370
	public void set_farClipPlane(float value) { }

	// RVA: 0x22F5F80 Offset: 0x22F4580 VA: 0x1822F5F80
	public float get_fieldOfView() { }

	// RVA: 0x22F7450 Offset: 0x22F5A50 VA: 0x1822F7450
	public void set_fieldOfView(float value) { }

	// RVA: 0x22F7980 Offset: 0x22F5F80 VA: 0x1822F7980
	public void set_renderingPath(RenderingPath value) { }

	[NativeName("CalculateRenderingPath")]
	// RVA: 0x22F56B0 Offset: 0x22F3CB0 VA: 0x1822F56B0
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x22F5830 Offset: 0x22F3E30 VA: 0x1822F5830
	public bool get_allowHDR() { }

	// RVA: 0x22F6E60 Offset: 0x22F5460 VA: 0x1822F6E60
	public void set_allowHDR(bool value) { }

	// RVA: 0x22F6F40 Offset: 0x22F5540 VA: 0x1822F6F40
	public void set_allowMSAA(bool value) { }

	// RVA: 0x22F5770 Offset: 0x22F3D70 VA: 0x1822F5770
	public bool get_allowDynamicResolution() { }

	// RVA: 0x22F7530 Offset: 0x22F5B30 VA: 0x1822F7530
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x22F6190 Offset: 0x22F4790 VA: 0x1822F6190
	public float get_orthographicSize() { }

	// RVA: 0x22F76F0 Offset: 0x22F5CF0 VA: 0x1822F76F0
	public void set_orthographicSize(float value) { }

	// RVA: 0x22F6250 Offset: 0x22F4850 VA: 0x1822F6250
	public bool get_orthographic() { }

	// RVA: 0x22F77D0 Offset: 0x22F5DD0 VA: 0x1822F77D0
	public void set_orthographic(bool value) { }

	// RVA: 0x22F5D40 Offset: 0x22F4340 VA: 0x1822F5D40
	public float get_depth() { }

	// RVA: 0x22F58F0 Offset: 0x22F3EF0 VA: 0x1822F58F0
	public float get_aspect() { }

	// RVA: 0x22F5B30 Offset: 0x22F4130 VA: 0x1822F5B30
	public int get_cullingMask() { }

	// RVA: 0x22F71C0 Offset: 0x22F57C0 VA: 0x1822F71C0
	public void set_cullingMask(int value) { }

	// RVA: 0x22F5E00 Offset: 0x22F4400 VA: 0x1822F5E00
	public int get_eventMask() { }

	// RVA: 0x22F59B0 Offset: 0x22F3FB0 VA: 0x1822F59B0
	public CameraType get_cameraType() { }

	// RVA: 0x22F7C50 Offset: 0x22F6250 VA: 0x1822F7C50
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x22F7020 Offset: 0x22F5620 VA: 0x1822F7020
	public void set_backgroundColor(Color value) { }

	// RVA: 0x22F5A70 Offset: 0x22F4070 VA: 0x1822F5A70
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x22F70F0 Offset: 0x22F56F0 VA: 0x1822F70F0
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x22F5C80 Offset: 0x22F4280 VA: 0x1822F5C80
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x22F7290 Offset: 0x22F5890 VA: 0x1822F7290
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x22F6CA0 Offset: 0x22F52A0 VA: 0x1822F6CA0
	public bool get_usePhysicalProperties() { }

	// RVA: 0x22F7D30 Offset: 0x22F6330 VA: 0x1822F7D30
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x22F6670 Offset: 0x22F4C70 VA: 0x1822F6670
	public Rect get_rect() { }

	// RVA: 0x22F63E0 Offset: 0x22F49E0 VA: 0x1822F63E0
	public Rect get_pixelRect() { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	// RVA: 0x22F64B0 Offset: 0x22F4AB0 VA: 0x1822F64B0
	public int get_pixelWidth() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	// RVA: 0x22F6310 Offset: 0x22F4910 VA: 0x1822F6310
	public int get_pixelHeight() { }

	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	// RVA: 0x22F6800 Offset: 0x22F4E00 VA: 0x1822F6800
	public int get_scaledPixelWidth() { }

	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	// RVA: 0x22F6740 Offset: 0x22F4D40 VA: 0x1822F6740
	public int get_scaledPixelHeight() { }

	// RVA: 0x22F6BC0 Offset: 0x22F51C0 VA: 0x1822F6BC0
	public RenderTexture get_targetTexture() { }

	// RVA: 0x22F7A60 Offset: 0x22F6060 VA: 0x1822F7A60
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x22F6B00 Offset: 0x22F5100 VA: 0x1822F6B00
	public int get_targetDisplay() { }

	// RVA: 0x22F6D70 Offset: 0x22F5370 VA: 0x1822F6D70
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x22F6580 Offset: 0x22F4B80 VA: 0x1822F6580
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x22F78B0 Offset: 0x22F5EB0 VA: 0x1822F78B0
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x22F7610 Offset: 0x22F5C10 VA: 0x1822F7610
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x22F7B70 Offset: 0x22F6170 VA: 0x1822F7B70
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x22F4B70 Offset: 0x22F3170 VA: 0x1822F4B70
	public void ResetProjectionMatrix() { }

	// RVA: 0x22F53B0 Offset: 0x22F39B0 VA: 0x1822F53B0
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x22F55B0 Offset: 0x22F3BB0 VA: 0x1822F55B0
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x22F52E0 Offset: 0x22F38E0 VA: 0x1822F52E0
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x22F54E0 Offset: 0x22F3AE0 VA: 0x1822F54E0
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x22F5020 Offset: 0x22F3620 VA: 0x1822F5020
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x22F4F10 Offset: 0x22F3510 VA: 0x1822F4F10
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x22F4E10 Offset: 0x22F3410 VA: 0x1822F4E10
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x22F4D20 Offset: 0x22F3320 VA: 0x1822F4D20
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunction("FindMainCamera")]
	// RVA: 0x22F6030 Offset: 0x22F4630 VA: 0x1822F6030
	public static Camera get_main() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	// RVA: 0x22F5BE0 Offset: 0x22F41E0 VA: 0x1822F5BE0
	public static Camera get_current() { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	// RVA: 0x22F6980 Offset: 0x22F4F80 VA: 0x1822F6980
	public bool get_stereoEnabled() { }

	// RVA: 0x22F6A40 Offset: 0x22F5040 VA: 0x1822F6A40
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	// RVA: 0x22F68C0 Offset: 0x22F4EC0 VA: 0x1822F68C0
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x22F4350 Offset: 0x22F2950 VA: 0x1822F4350
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = True)]
	// RVA: 0x22F4550 Offset: 0x22F2B50 VA: 0x1822F4550
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x22F3F70 Offset: 0x22F2570 VA: 0x1822F3F70
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	// RVA: 0x22F4450 Offset: 0x22F2A50 VA: 0x1822F4450
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x22F5120 Offset: 0x22F3720 VA: 0x1822F5120
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x22F4C30 Offset: 0x22F3230 VA: 0x1822F4C30
	public void ResetStereoProjectionMatrices() { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	// RVA: 0x22F4120 Offset: 0x22F2720 VA: 0x1822F4120
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	// RVA: 0x22F4190 Offset: 0x22F2790 VA: 0x1822F4190
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x22F4120 Offset: 0x22F2720 VA: 0x1822F4120
	public static int get_allCamerasCount() { }

	// RVA: 0x22F4200 Offset: 0x22F2800 VA: 0x1822F4200
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	// RVA: 0x22F4940 Offset: 0x22F2F40 VA: 0x1822F4940
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	// RVA: 0x22F5200 Offset: 0x22F3800 VA: 0x1822F5200
	public static void SetupCurrent(Camera cur) { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	// RVA: 0x22F3E70 Offset: 0x22F2470 VA: 0x1822F3E70
	public void CopyFrom(Camera other) { }

	[NativeName("AddCommandBuffer")]
	// RVA: 0x22F3B70 Offset: 0x22F2170 VA: 0x1822F3B70
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("RemoveCommandBuffer")]
	// RVA: 0x22F4650 Offset: 0x22F2C50 VA: 0x1822F4650
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x22F3C50 Offset: 0x22F2250 VA: 0x1822F3C50
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x22F4730 Offset: 0x22F2D30 VA: 0x1822F4730
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[RequiredByNativeCode]
	// RVA: 0x22F4060 Offset: 0x22F2660 VA: 0x1822F4060
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x22F40C0 Offset: 0x22F26C0 VA: 0x1822F40C0
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x22F4000 Offset: 0x22F2600 VA: 0x1822F4000
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x22F3E00 Offset: 0x22F2400 VA: 0x1822F3E00
	private static void BumpNonSerializedVersion(Camera cam) { }

	// RVA: 0x22F6090 Offset: 0x22F4690 VA: 0x1822F6090
	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F5E80 Offset: 0x22F4480 VA: 0x1822F5E80
	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7320 Offset: 0x22F5920 VA: 0x1822F7320
	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x22F5F40 Offset: 0x22F4540 VA: 0x1822F5F40
	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7400 Offset: 0x22F5A00 VA: 0x1822F7400
	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x22F7940 Offset: 0x22F5F40 VA: 0x1822F7940
	private static void set_renderingPath_Injected(IntPtr _unity_self, RenderingPath value) { }

	// RVA: 0x22F5670 Offset: 0x22F3C70 VA: 0x1822F5670
	private static RenderingPath get_actualRenderingPath_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F57F0 Offset: 0x22F3DF0 VA: 0x1822F57F0
	private static bool get_allowHDR_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F6E10 Offset: 0x22F5410 VA: 0x1822F6E10
	private static void set_allowHDR_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x22F6EF0 Offset: 0x22F54F0 VA: 0x1822F6EF0
	private static void set_allowMSAA_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x22F5730 Offset: 0x22F3D30 VA: 0x1822F5730
	private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F74E0 Offset: 0x22F5AE0 VA: 0x1822F74E0
	private static void set_forceIntoRenderTexture_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x22F6150 Offset: 0x22F4750 VA: 0x1822F6150
	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F76A0 Offset: 0x22F5CA0 VA: 0x1822F76A0
	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x22F6210 Offset: 0x22F4810 VA: 0x1822F6210
	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7780 Offset: 0x22F5D80 VA: 0x1822F7780
	private static void set_orthographic_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x22F5D00 Offset: 0x22F4300 VA: 0x1822F5D00
	private static float get_depth_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F58B0 Offset: 0x22F3EB0 VA: 0x1822F58B0
	private static float get_aspect_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F5AF0 Offset: 0x22F40F0 VA: 0x1822F5AF0
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7180 Offset: 0x22F5780 VA: 0x1822F7180
	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x22F5DC0 Offset: 0x22F43C0 VA: 0x1822F5DC0
	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F5970 Offset: 0x22F3F70 VA: 0x1822F5970
	private static CameraType get_cameraType_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7C00 Offset: 0x22F6200 VA: 0x1822F7C00
	private static void set_useOcclusionCulling_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x22F6FD0 Offset: 0x22F55D0 VA: 0x1822F6FD0
	private static void set_backgroundColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x22F5A30 Offset: 0x22F4030 VA: 0x1822F5A30
	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F70B0 Offset: 0x22F56B0 VA: 0x1822F70B0
	private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value) { }

	// RVA: 0x22F5C40 Offset: 0x22F4240 VA: 0x1822F5C40
	private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7250 Offset: 0x22F5850 VA: 0x1822F7250
	private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value) { }

	// RVA: 0x22F6C60 Offset: 0x22F5260 VA: 0x1822F6C60
	private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7CE0 Offset: 0x22F62E0 VA: 0x1822F7CE0
	private static void set_usePhysicalProperties_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x22F6620 Offset: 0x22F4C20 VA: 0x1822F6620
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x22F6390 Offset: 0x22F4990 VA: 0x1822F6390
	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x22F6470 Offset: 0x22F4A70 VA: 0x1822F6470
	private static int get_pixelWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F62D0 Offset: 0x22F48D0 VA: 0x1822F62D0
	private static int get_pixelHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F67C0 Offset: 0x22F4DC0 VA: 0x1822F67C0
	private static int get_scaledPixelWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F6700 Offset: 0x22F4D00 VA: 0x1822F6700
	private static int get_scaledPixelHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F6B80 Offset: 0x22F5180 VA: 0x1822F6B80
	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F7A10 Offset: 0x22F6010 VA: 0x1822F7A10
	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x22F6AC0 Offset: 0x22F50C0 VA: 0x1822F6AC0
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F6D20 Offset: 0x22F5320 VA: 0x1822F6D20
	private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	// RVA: 0x22F6530 Offset: 0x22F4B30 VA: 0x1822F6530
	private static void get_projectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	// RVA: 0x22F7860 Offset: 0x22F5E60 VA: 0x1822F7860
	private static void set_projectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	// RVA: 0x22F75C0 Offset: 0x22F5BC0 VA: 0x1822F75C0
	private static void set_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	// RVA: 0x22F7B20 Offset: 0x22F6120 VA: 0x1822F7B20
	private static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x22F4B30 Offset: 0x22F3130 VA: 0x1822F4B30
	private static void ResetProjectionMatrix_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F5270 Offset: 0x22F3870 VA: 0x1822F5270
	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x22F5470 Offset: 0x22F3A70 VA: 0x1822F5470
	private static void WorldToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x22F4FC0 Offset: 0x22F35C0 VA: 0x1822F4FC0
	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	// RVA: 0x22F4CB0 Offset: 0x22F32B0 VA: 0x1822F4CB0
	private static void ScreenPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x22F6000 Offset: 0x22F4600 VA: 0x1822F6000
	private static IntPtr get_main_Injected() { }

	// RVA: 0x22F5BB0 Offset: 0x22F41B0 VA: 0x1822F5BB0
	private static IntPtr get_current_Injected() { }

	// RVA: 0x22F6940 Offset: 0x22F4F40 VA: 0x1822F6940
	private static bool get_stereoEnabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F6A00 Offset: 0x22F5000 VA: 0x1822F6A00
	private static StereoTargetEyeMask get_stereoTargetEye_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F6880 Offset: 0x22F4E80 VA: 0x1822F6880
	private static Camera.MonoOrStereoscopicEye get_stereoActiveEye_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F4300 Offset: 0x22F2900 VA: 0x1822F4300
	private static void GetStereoNonJitteredProjectionMatrix_Injected(IntPtr _unity_self, Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x22F4500 Offset: 0x22F2B00 VA: 0x1822F4500
	private static void GetStereoViewMatrix_Injected(IntPtr _unity_self, Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x22F3F30 Offset: 0x22F2530 VA: 0x1822F3F30
	private static void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(IntPtr _unity_self, Camera.StereoscopicEye eye) { }

	// RVA: 0x22F4400 Offset: 0x22F2A00 VA: 0x1822F4400
	private static void GetStereoProjectionMatrix_Injected(IntPtr _unity_self, Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x22F50D0 Offset: 0x22F36D0 VA: 0x1822F50D0
	private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, Camera.StereoscopicEye eye, in Matrix4x4 matrix) { }

	// RVA: 0x22F4BF0 Offset: 0x22F31F0 VA: 0x1822F4BF0
	private static void ResetStereoProjectionMatrices_Injected(IntPtr _unity_self) { }

	// RVA: 0x22F4150 Offset: 0x22F2750 VA: 0x1822F4150
	private static int GetAllCamerasImpl_Injected([Out] Camera[] cam) { }

	// RVA: 0x22F48E0 Offset: 0x22F2EE0 VA: 0x1822F48E0
	private static void RenderWithShader_Injected(IntPtr _unity_self, IntPtr shader, ref ManagedSpanWrapper replacementTag) { }

	// RVA: 0x22F51C0 Offset: 0x22F37C0 VA: 0x1822F51C0
	private static void SetupCurrent_Injected(IntPtr cur) { }

	// RVA: 0x22F3E20 Offset: 0x22F2420 VA: 0x1822F3E20
	private static void CopyFrom_Injected(IntPtr _unity_self, IntPtr other) { }

	// RVA: 0x22F3B20 Offset: 0x22F2120 VA: 0x1822F3B20
	private static void AddCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	// RVA: 0x22F4600 Offset: 0x22F2C00 VA: 0x1822F4600
	private static void RemoveCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }
}

// Namespace: UnityEngine
public struct CullingGroupEvent // TypeDefIndex: 9527
{
	// Fields
	private int m_Index; // 0x0
	private byte m_PrevState; // 0x4
	private byte m_ThisState; // 0x5
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup // TypeDefIndex: 9529
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x22F7DC0 Offset: 0x22F63C0 VA: 0x1822F7DC0
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 9531
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	private static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions; // 0x8
	private static List<Action<Texture>> registeredDefaultReflectionTextureActions; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2310C90 Offset: 0x230F290 VA: 0x182310C90
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	// RVA: 0x2310D10 Offset: 0x230F310 VA: 0x182310D10
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x2310E60 Offset: 0x230F460 VA: 0x182310E60
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 9532
{
	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x22F8020 Offset: 0x22F6620 VA: 0x1822F8020
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x22F7F40 Offset: 0x22F6540 VA: 0x1822F7F40
	internal static void Internal_LogException(Exception ex, Object obj) { }

	// RVA: 0x22F82B0 Offset: 0x22F68B0 VA: 0x1822F82B0 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x22F81E0 Offset: 0x22F67E0 VA: 0x1822F81E0 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x22F7FC0 Offset: 0x22F65C0 VA: 0x1822F7FC0
	private static void Internal_Log_Injected(LogType level, LogOption options, ref ManagedSpanWrapper msg, IntPtr obj) { }

	// RVA: 0x22F7EF0 Offset: 0x22F64F0 VA: 0x1822F7EF0
	private static void Internal_LogException_Injected(Exception ex, IntPtr obj) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug // TypeDefIndex: 9533
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties
	public static ILogger unityLogger { get; }
	public static bool isDebugBuild { get; }

	// Methods

	// RVA: 0x22F9DC0 Offset: 0x22F83C0 VA: 0x1822F9DC0
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocs]
	// RVA: 0x22F8870 Offset: 0x22F6E70 VA: 0x1822F8870
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocs]
	// RVA: 0x22F8970 Offset: 0x22F6F70 VA: 0x1822F8970
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	// RVA: 0x22F87D0 Offset: 0x22F6DD0 VA: 0x1822F87D0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocs]
	// RVA: 0x22F8BB0 Offset: 0x22F71B0 VA: 0x1822F8BB0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0x22F8A60 Offset: 0x22F7060 VA: 0x1822F8A60
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	[FreeFunction("PauseEditor")]
	// RVA: 0x22F84A0 Offset: 0x22F6AA0 VA: 0x1822F84A0
	public static void Break() { }

	[ThreadSafe]
	// RVA: 0x22F8D70 Offset: 0x22F7370 VA: 0x1822F8D70
	public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x22F9BC0 Offset: 0x22F81C0 VA: 0x1822F9BC0
	public static void Log(object message) { }

	// RVA: 0x22F9AF0 Offset: 0x22F80F0 VA: 0x1822F9AF0
	public static void Log(object message, Object context) { }

	// RVA: 0x22F96E0 Offset: 0x22F7CE0 VA: 0x1822F96E0
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x22F94A0 Offset: 0x22F7AA0 VA: 0x1822F94A0
	public static void LogError(object message) { }

	// RVA: 0x22F93D0 Offset: 0x22F79D0 VA: 0x1822F93D0
	public static void LogError(object message, Object context) { }

	// RVA: 0x22F9300 Offset: 0x22F7900 VA: 0x1822F9300
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x22F9220 Offset: 0x22F7820 VA: 0x1822F9220
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x22F9560 Offset: 0x22F7B60 VA: 0x1822F9560
	public static void LogException(Exception exception) { }

	// RVA: 0x22F9620 Offset: 0x22F7C20 VA: 0x1822F9620
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x22F9A30 Offset: 0x22F8030 VA: 0x1822F9A30
	public static void LogWarning(object message) { }

	// RVA: 0x22F9960 Offset: 0x22F7F60 VA: 0x1822F9960
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x22F97B0 Offset: 0x22F7DB0 VA: 0x1822F97B0
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x22F9880 Offset: 0x22F7E80 VA: 0x1822F9880
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x22F8300 Offset: 0x22F6900 VA: 0x1822F8300
	public static void Assert(bool condition) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x22F83D0 Offset: 0x22F69D0 VA: 0x1822F83D0
	public static void Assert(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x22F9160 Offset: 0x22F7760 VA: 0x1822F9160
	public static void LogAssertion(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x22F9090 Offset: 0x22F7690 VA: 0x1822F9090
	public static void LogAssertionFormat(string format, object[] args) { }

	// RVA: 0x22F9D90 Offset: 0x22F8390 VA: 0x1822F9D90
	public static bool get_isDebugBuild() { }

	[RequiredByNativeCode]
	// RVA: 0x22F84D0 Offset: 0x22F6AD0 VA: 0x1822F84D0
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	[RequiredByNativeCode]
	// RVA: 0x22F8F20 Offset: 0x22F7520 VA: 0x1822F8F20
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x22F9C80 Offset: 0x22F8280 VA: 0x1822F9C80
	private static void .cctor() { }

	// RVA: 0x22F8760 Offset: 0x22F6D60 VA: 0x1822F8760
	private static void DrawLine_Injected(in Vector3 start, in Vector3 end, in Color color, float duration, bool depthTest) { }

	// RVA: 0x22F8D20 Offset: 0x22F7320 VA: 0x1822F8D20
	private static int ExtractStackTraceNoAlloc_Injected(byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder) { }
}

// Namespace: UnityEngine
[MovedFrom(True, "UnityEditor", "UnityEditor", null)]
public class ExpressionEvaluator // TypeDefIndex: 9540
{
	// Fields
	private static ExpressionEvaluator.PcgRandom s_Random; // 0x0
	private static Dictionary<string, ExpressionEvaluator.Operator> s_Operators; // 0x10

	// Methods

	// RVA: -1 Offset: -1
	internal static bool Evaluate<T>(string expression, out T value, out ExpressionEvaluator.Expression delayed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FB710 Offset: 0x6F9D10 VA: 0x1806FB710
	|-ExpressionEvaluator.Evaluate<double>
	|
	|-RVA: 0x6FB9A0 Offset: 0x6F9FA0 VA: 0x1806FB9A0
	|-ExpressionEvaluator.Evaluate<long>
	|-ExpressionEvaluator.Evaluate<ulong>
	|
	|-RVA: 0x6FB840 Offset: 0x6F9E40 VA: 0x1806FB840
	|-ExpressionEvaluator.Evaluate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FAA70 Offset: 0x6F9070 VA: 0x1806FAA70
	|-ExpressionEvaluator.EvaluateTokens<double>
	|
	|-RVA: 0x6FB330 Offset: 0x6F9930 VA: 0x1806FB330
	|-ExpressionEvaluator.EvaluateTokens<long>
	|-ExpressionEvaluator.EvaluateTokens<ulong>
	|
	|-RVA: 0x6FAE50 Offset: 0x6F9450 VA: 0x1806FAE50
	|-ExpressionEvaluator.EvaluateTokens<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22FAC70 Offset: 0x22F9270 VA: 0x1822FAC70
	private static bool EvaluateDouble(string[] tokens, ref double value, int index, int count) { }

	// RVA: 0x22FBAE0 Offset: 0x22FA0E0 VA: 0x1822FBAE0
	private static string[] InfixToRPN(string[] tokens) { }

	// RVA: 0x22FC170 Offset: 0x22FA770 VA: 0x1822FC170
	private static bool NeedToPop(Stack<string> operatorStack, ExpressionEvaluator.Operator newOperator) { }

	// RVA: 0x22FB510 Offset: 0x22F9B10 VA: 0x1822FB510
	private static string[] ExpressionToTokens(string expression, out bool hasVariables) { }

	// RVA: 0x22FBF90 Offset: 0x22FA590 VA: 0x1822FBF90
	private static bool IsCommand(string token) { }

	// RVA: 0x22FC110 Offset: 0x22FA710 VA: 0x1822FC110
	private static bool IsVariable(string token) { }

	// RVA: 0x22FC020 Offset: 0x22FA620 VA: 0x1822FC020
	private static bool IsDelayedFunction(string token) { }

	// RVA: 0x22FC090 Offset: 0x22FA690 VA: 0x1822FC090
	private static bool IsOperator(string token) { }

	// RVA: 0x22FC410 Offset: 0x22FAA10 VA: 0x1822FC410
	private static ExpressionEvaluator.Operator TokenToOperator(string token) { }

	// RVA: 0x22FC260 Offset: 0x22FA860 VA: 0x1822FC260
	private static string PreFormatExpression(string expression) { }

	// RVA: 0x22FB960 Offset: 0x22F9F60 VA: 0x1822FB960
	private static string[] FixUnaryOperators(string[] tokens) { }

	// RVA: 0x22FB180 Offset: 0x22F9780 VA: 0x1822FB180
	private static double EvaluateOp(double[] values, ExpressionEvaluator.Op op, int index, int count) { }

	// RVA: -1 Offset: -1
	private static bool TryParse<T>(string expression, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FC2D0 Offset: 0x6FA8D0 VA: 0x1806FC2D0
	|-ExpressionEvaluator.TryParse<double>
	|-ExpressionEvaluator.TryParse<long>
	|-ExpressionEvaluator.TryParse<ulong>
	|
	|-RVA: 0x6FCAC0 Offset: 0x6FB0C0 VA: 0x1806FCAC0
	|-ExpressionEvaluator.TryParse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22FC4B0 Offset: 0x22FAAB0 VA: 0x1822FC4B0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeClass("AABB")]
public struct Bounds : IEquatable<Bounds>, IFormattable // TypeDefIndex: 9541
{
	// Fields
	private Vector3 m_Center; // 0x0
	[NativeName("m_Extent")]
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; }
	public Vector3 max { get; }

	// Methods

	// RVA: 0x22F22B0 Offset: 0x22F08B0 VA: 0x1822F22B0
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x22F1F90 Offset: 0x22F0590 VA: 0x1822F1F90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22F1E60 Offset: 0x22F0460 VA: 0x1822F1E60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x22F1DB0 Offset: 0x22F03B0 VA: 0x1822F1DB0 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x22F1D70 Offset: 0x22F0370 VA: 0x1822F1D70
	public Vector3 get_center() { }

	// RVA: 0x9720D0 Offset: 0x9706D0 VA: 0x1809720D0
	public void set_center(Vector3 value) { }

	// RVA: 0x22F23A0 Offset: 0x22F09A0 VA: 0x1822F23A0
	public Vector3 get_size() { }

	// RVA: 0x22F2540 Offset: 0x22F0B40 VA: 0x1822F2540
	public void set_size(Vector3 value) { }

	// RVA: 0x22F1D90 Offset: 0x22F0390 VA: 0x1822F1D90
	public Vector3 get_extents() { }

	// RVA: 0x9720E0 Offset: 0x9706E0 VA: 0x1809720E0
	public void set_extents(Vector3 value) { }

	// RVA: 0x22F2350 Offset: 0x22F0950 VA: 0x1822F2350
	public Vector3 get_min() { }

	// RVA: 0x22F2300 Offset: 0x22F0900 VA: 0x1822F2300
	public Vector3 get_max() { }

	// RVA: 0x22F23E0 Offset: 0x22F09E0 VA: 0x1822F23E0
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x22F2480 Offset: 0x22F0A80 VA: 0x1822F2480
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x22F2060 Offset: 0x22F0660 VA: 0x1822F2060
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x7977D0 Offset: 0x795DD0 VA: 0x1807977D0
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x22F22A0 Offset: 0x22F08A0 VA: 0x1822F22A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22F20E0 Offset: 0x22F06E0 VA: 0x1822F20E0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct BoundsInt : IEquatable<BoundsInt>, IFormattable // TypeDefIndex: 9542
{
	// Fields
	private Vector3Int m_Position; // 0x0
	private Vector3Int m_Size; // 0xC

	// Properties
	public Vector3Int position { get; set; }
	public Vector3Int size { get; set; }

	// Methods

	// RVA: 0x22F1D70 Offset: 0x22F0370 VA: 0x1822F1D70
	public Vector3Int get_position() { }

	// RVA: 0x9720D0 Offset: 0x9706D0 VA: 0x1809720D0
	public void set_position(Vector3Int value) { }

	// RVA: 0x22F1D90 Offset: 0x22F0390 VA: 0x1822F1D90
	public Vector3Int get_size() { }

	// RVA: 0x9720E0 Offset: 0x9706E0 VA: 0x1809720E0
	public void set_size(Vector3Int value) { }

	// RVA: 0xB1EA30 Offset: 0xB1D030 VA: 0x180B1EA30
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x22F1D60 Offset: 0x22F0360 VA: 0x1822F1D60 Slot: 3
	public override string ToString() { }

	// RVA: 0x22F1BC0 Offset: 0x22F01C0 VA: 0x1822F1BC0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x22F1A50 Offset: 0x22F0050 VA: 0x1822F1A50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x22F19A0 Offset: 0x22EFFA0 VA: 0x1822F19A0 Slot: 4
	public bool Equals(BoundsInt other) { }

	// RVA: 0x22F1B80 Offset: 0x22F0180 VA: 0x1822F1B80 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct Plane : IFormattable // TypeDefIndex: 9543
{
	// Fields
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x22F1D70 Offset: 0x22F0370 VA: 0x1822F1D70
	public Vector3 get_normal() { }

	// RVA: 0x230DD90 Offset: 0x230C390 VA: 0x18230DD90
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x230DB70 Offset: 0x230C170 VA: 0x18230DB70
	public float GetDistanceToPoint(Vector3 point) { }

	// RVA: 0x209AC50 Offset: 0x2099250 VA: 0x18209AC50
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x230DD80 Offset: 0x230C380 VA: 0x18230DD80 Slot: 3
	public override string ToString() { }

	// RVA: 0x230DBC0 Offset: 0x230C1C0 VA: 0x18230DBC0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
public struct Ray : IFormattable // TypeDefIndex: 9544
{
	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x230F0D0 Offset: 0x230D6D0 VA: 0x18230F0D0
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x22F1D70 Offset: 0x22F0370 VA: 0x1822F1D70
	public Vector3 get_origin() { }

	// RVA: 0x9720D0 Offset: 0x9706D0 VA: 0x1809720D0
	public void set_origin(Vector3 value) { }

	// RVA: 0x22F1D90 Offset: 0x22F0390 VA: 0x1822F1D90
	public Vector3 get_direction() { }

	// RVA: 0x230F130 Offset: 0x230D730 VA: 0x18230F130
	public void set_direction(Vector3 value) { }

	// RVA: 0x230EEB0 Offset: 0x230D4B0 VA: 0x18230EEB0
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x230EF00 Offset: 0x230D500 VA: 0x18230EF00 Slot: 3
	public override string ToString() { }

	// RVA: 0x230EF10 Offset: 0x230D510 VA: 0x18230EF10 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
public struct Ray2D : IFormattable // TypeDefIndex: 9545
{
	// Fields
	private Vector2 m_Origin; // 0x0
	private Vector2 m_Direction; // 0x8

	// Properties
	public Vector2 origin { get; set; }
	public Vector2 direction { get; set; }

	// Methods

	// RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	public Vector2 get_origin() { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void set_origin(Vector2 value) { }

	// RVA: 0x16ADB70 Offset: 0x16AC170 VA: 0x1816ADB70
	public Vector2 get_direction() { }

	// RVA: 0x230EE70 Offset: 0x230D470 VA: 0x18230EE70
	public void set_direction(Vector2 value) { }

	// RVA: 0x230ECA0 Offset: 0x230D2A0 VA: 0x18230ECA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x230ECB0 Offset: 0x230D2B0 VA: 0x18230ECB0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Math/Rect.h")]
public struct Rect : IEquatable<Rect>, IFormattable // TypeDefIndex: 9546
{
	// Fields
	[NativeName("x")]
	private float m_XMin; // 0x0
	[NativeName("y")]
	private float m_YMin; // 0x4
	[NativeName("width")]
	private float m_Width; // 0x8
	[NativeName("height")]
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; set; }
	public Vector2 max { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x1FD2430 Offset: 0x1FD0A30 VA: 0x181FD2430
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x1F7DBD0 Offset: 0x1F7C1D0 VA: 0x181F7DBD0
	public void .ctor(Rect source) { }

	// RVA: 0x2310AF0 Offset: 0x230F0F0 VA: 0x182310AF0
	public static Rect get_zero() { }

	// RVA: 0x2310670 Offset: 0x230EC70 VA: 0x182310670
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_x() { }

	// RVA: 0x3A4C50 Offset: 0x3A3250 VA: 0x1803A4C50
	public void set_x(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_y() { }

	// RVA: 0xD32900 Offset: 0xD30F00 VA: 0x180D32900
	public void set_y(float value) { }

	// RVA: 0x2310A90 Offset: 0x230F090 VA: 0x182310A90
	public Vector2 get_position() { }

	// RVA: 0x1FBD870 Offset: 0x1FBBE70 VA: 0x181FBD870
	public void set_position(Vector2 value) { }

	// RVA: 0x2310A20 Offset: 0x230F020 VA: 0x182310A20
	public Vector2 get_center() { }

	// RVA: 0x2310BA0 Offset: 0x230F1A0 VA: 0x182310BA0
	public void set_center(Vector2 value) { }

	// RVA: 0x2310A70 Offset: 0x230F070 VA: 0x182310A70
	public Vector2 get_min() { }

	// RVA: 0x2310C10 Offset: 0x230F210 VA: 0x182310C10
	public void set_min(Vector2 value) { }

	// RVA: 0x2310A50 Offset: 0x230F050 VA: 0x182310A50
	public Vector2 get_max() { }

	// RVA: 0x2310BE0 Offset: 0x230F1E0 VA: 0x182310BE0
	public void set_max(Vector2 value) { }

	// RVA: 0x22FFFF0 Offset: 0x22FE5F0 VA: 0x1822FFFF0
	public float get_width() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_width(float value) { }

	// RVA: 0x22E91B0 Offset: 0x22E77B0 VA: 0x1822E91B0
	public float get_height() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_height(float value) { }

	// RVA: 0x2310AB0 Offset: 0x230F0B0 VA: 0x182310AB0
	public Vector2 get_size() { }

	// RVA: 0x1FD2FE0 Offset: 0x1FD15E0 VA: 0x181FD2FE0
	public void set_size(Vector2 value) { }

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_xMin() { }

	// RVA: 0x2310C50 Offset: 0x230F250 VA: 0x182310C50
	public void set_xMin(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_yMin() { }

	// RVA: 0x2310C70 Offset: 0x230F270 VA: 0x182310C70
	public void set_yMin(float value) { }

	// RVA: 0x2310AD0 Offset: 0x230F0D0 VA: 0x182310AD0
	public float get_xMax() { }

	// RVA: 0x181B6A0 Offset: 0x1819CA0 VA: 0x18181B6A0
	public void set_xMax(float value) { }

	// RVA: 0x2310AE0 Offset: 0x230F0E0 VA: 0x182310AE0
	public float get_yMax() { }

	// RVA: 0x181B6B0 Offset: 0x1819CB0 VA: 0x18181B6B0
	public void set_yMax(float value) { }

	// RVA: 0xFE64B0 Offset: 0xFE4AB0 VA: 0x180FE64B0
	public bool Contains(Vector2 point) { }

	// RVA: 0x23103D0 Offset: 0x230E9D0 VA: 0x1823103D0
	public bool Contains(Vector3 point) { }

	// RVA: 0x23106B0 Offset: 0x230ECB0 VA: 0x1823106B0
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x2310720 Offset: 0x230ED20 VA: 0x182310720
	public bool Overlaps(Rect other) { }

	// RVA: 0x5538B0 Offset: 0x551EB0 VA: 0x1805538B0
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x2310B40 Offset: 0x230F140 VA: 0x182310B40
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x2310B00 Offset: 0x230F100 VA: 0x182310B00
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x23105D0 Offset: 0x230EBD0 VA: 0x1823105D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2310410 Offset: 0x230EA10 VA: 0x182310410 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2310520 Offset: 0x230EB20 VA: 0x182310520 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x2310770 Offset: 0x230ED70 VA: 0x182310770 Slot: 3
	public override string ToString() { }

	// RVA: 0x2310780 Offset: 0x230ED80 VA: 0x182310780 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable // TypeDefIndex: 9547
{
	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public int xMin { get; }
	public int yMin { get; }
	public int xMax { get; }
	public int yMax { get; }

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

	// RVA: 0x230F610 Offset: 0x230DC10 VA: 0x18230F610
	public int get_xMin() { }

	// RVA: 0x230F6F0 Offset: 0x230DCF0 VA: 0x18230F6F0
	public int get_yMin() { }

	// RVA: 0x230F5A0 Offset: 0x230DBA0 VA: 0x18230F5A0
	public int get_xMax() { }

	// RVA: 0x230F680 Offset: 0x230DC80 VA: 0x18230F680
	public int get_yMax() { }

	// RVA: 0x16AE250 Offset: 0x16AC850 VA: 0x1816AE250
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x22EE230 Offset: 0x22EC830 VA: 0x1822EE230
	public bool Overlaps(RectInt other) { }

	// RVA: 0x230F590 Offset: 0x230DB90 VA: 0x18230F590 Slot: 3
	public override string ToString() { }

	// RVA: 0x230F320 Offset: 0x230D920 VA: 0x18230F320 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x230F280 Offset: 0x230D880 VA: 0x18230F280 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230F180 Offset: 0x230D780 VA: 0x18230F180 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x230F250 Offset: 0x230D850 VA: 0x18230F250 Slot: 4
	public bool Equals(RectInt other) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/IMGUI/GUIStyle.h")]
[Serializable]
public class RectOffset : IFormattable // TypeDefIndex: 9549
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("left", False, 1)]
	public int left { get; set; }
	[NativeProperty("right", False, 1)]
	public int right { get; set; }
	[NativeProperty("top", False, 1)]
	public int top { get; set; }
	[NativeProperty("bottom", False, 1)]
	public int bottom { get; set; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x230FD50 Offset: 0x230E350 VA: 0x18230FD50
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x230FD00 Offset: 0x230E300 VA: 0x18230FD00
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x230F7B0 Offset: 0x230DDB0 VA: 0x18230F7B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x230F9A0 Offset: 0x230DFA0 VA: 0x18230F9A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x230F9B0 Offset: 0x230DFB0 VA: 0x18230F9B0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x230F760 Offset: 0x230DD60 VA: 0x18230F760
	private void Destroy() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x230F850 Offset: 0x230DE50 VA: 0x18230F850
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x230F880 Offset: 0x230DE80 VA: 0x18230F880
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x230FF10 Offset: 0x230E510 VA: 0x18230FF10
	public int get_left() { }

	// RVA: 0x2310230 Offset: 0x230E830 VA: 0x182310230
	public void set_left(int value) { }

	// RVA: 0x230FFB0 Offset: 0x230E5B0 VA: 0x18230FFB0
	public int get_right() { }

	// RVA: 0x23102D0 Offset: 0x230E8D0 VA: 0x1823102D0
	public void set_right(int value) { }

	// RVA: 0x2310050 Offset: 0x230E650 VA: 0x182310050
	public int get_top() { }

	// RVA: 0x2310370 Offset: 0x230E970 VA: 0x182310370
	public void set_top(int value) { }

	// RVA: 0x230FDD0 Offset: 0x230E3D0 VA: 0x18230FDD0
	public int get_bottom() { }

	// RVA: 0x2310190 Offset: 0x230E790 VA: 0x182310190
	public void set_bottom(int value) { }

	// RVA: 0x230FE70 Offset: 0x230E470 VA: 0x18230FE70
	public int get_horizontal() { }

	// RVA: 0x23100F0 Offset: 0x230E6F0 VA: 0x1823100F0
	public int get_vertical() { }

	// RVA: 0x230F920 Offset: 0x230DF20 VA: 0x18230F920
	public Rect Remove(Rect rect) { }

	// RVA: 0x230FED0 Offset: 0x230E4D0 VA: 0x18230FED0
	private static int get_left_Injected(IntPtr _unity_self) { }

	// RVA: 0x23101F0 Offset: 0x230E7F0 VA: 0x1823101F0
	private static void set_left_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x230FF70 Offset: 0x230E570 VA: 0x18230FF70
	private static int get_right_Injected(IntPtr _unity_self) { }

	// RVA: 0x2310290 Offset: 0x230E890 VA: 0x182310290
	private static void set_right_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2310010 Offset: 0x230E610 VA: 0x182310010
	private static int get_top_Injected(IntPtr _unity_self) { }

	// RVA: 0x2310330 Offset: 0x230E930 VA: 0x182310330
	private static void set_top_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x230FD90 Offset: 0x230E390 VA: 0x18230FD90
	private static int get_bottom_Injected(IntPtr _unity_self) { }

	// RVA: 0x2310150 Offset: 0x230E750 VA: 0x182310150
	private static void set_bottom_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x230FE30 Offset: 0x230E430 VA: 0x18230FE30
	private static int get_horizontal_Injected(IntPtr _unity_self) { }

	// RVA: 0x23100B0 Offset: 0x230E6B0 VA: 0x1823100B0
	private static int get_vertical_Injected(IntPtr _unity_self) { }

	// RVA: 0x230F8C0 Offset: 0x230DEC0 VA: 0x18230F8C0
	private static void Remove_Injected(IntPtr _unity_self, in Rect rect, out Rect ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/LightingSettings.h")]
[PreventReadOnlyInstanceModification]
public sealed class LightingSettings : Object // TypeDefIndex: 9550
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void LightingSettingsDontStripMe() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", 2)]
public sealed class Gizmos // TypeDefIndex: 9551
{
	// Properties
	public static Color color { set; }
	public static Matrix4x4 matrix { set; }

	// Methods

	[NativeThrows]
	// RVA: 0x22FDB90 Offset: 0x22FC190 VA: 0x1822FDB90
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrows]
	// RVA: 0x22FD880 Offset: 0x22FBE80 VA: 0x1822FD880
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrows]
	// RVA: 0x22FD920 Offset: 0x22FBF20 VA: 0x1822FD920
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrows]
	// RVA: 0x22FD4B0 Offset: 0x22FBAB0 VA: 0x1822FD4B0
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrows]
	// RVA: 0x22FD6C0 Offset: 0x22FBCC0 VA: 0x1822FD6C0
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrows]
	// RVA: 0x22FD9D0 Offset: 0x22FBFD0 VA: 0x1822FD9D0
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x22FDC20 Offset: 0x22FC220 VA: 0x1822FDC20
	public static void set_color(Color value) { }

	// RVA: 0x22FDCA0 Offset: 0x22FC2A0 VA: 0x1822FDCA0
	public static void set_matrix(Matrix4x4 value) { }

	[ExcludeFromDocs]
	// RVA: 0x22FD560 Offset: 0x22FBB60 VA: 0x1822FD560
	public static void DrawMesh(Mesh mesh) { }

	// RVA: 0x22FD770 Offset: 0x22FBD70 VA: 0x1822FD770
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x22FDA80 Offset: 0x22FC080 VA: 0x1822FDA80
	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x22FDB40 Offset: 0x22FC140 VA: 0x1822FDB40
	private static void DrawWireSphere_Injected(in Vector3 center, float radius) { }

	// RVA: 0x22FD830 Offset: 0x22FBE30 VA: 0x1822FD830
	private static void DrawSphere_Injected(in Vector3 center, float radius) { }

	// RVA: 0x22FD8D0 Offset: 0x22FBED0 VA: 0x1822FD8D0
	private static void DrawWireCube_Injected(in Vector3 center, in Vector3 size) { }

	// RVA: 0x22FD460 Offset: 0x22FBA60 VA: 0x1822FD460
	private static void DrawCube_Injected(in Vector3 center, in Vector3 size) { }

	// RVA: 0x22FD500 Offset: 0x22FBB00 VA: 0x1822FD500
	private static void DrawMesh_Injected(IntPtr mesh, int submeshIndex, in Vector3 position, in Quaternion rotation, in Vector3 scale) { }

	// RVA: 0x22FD970 Offset: 0x22FBF70 VA: 0x1822FD970
	private static void DrawWireMesh_Injected(IntPtr mesh, int submeshIndex, in Vector3 position, in Quaternion rotation, in Vector3 scale) { }

	// RVA: 0x22FDBE0 Offset: 0x22FC1E0 VA: 0x1822FDBE0
	private static void set_color_Injected(in Color value) { }

	// RVA: 0x22FDC60 Offset: 0x22FC260 VA: 0x1822FDC60
	private static void set_matrix_Injected(in Matrix4x4 value) { }
}

// Namespace: UnityEngine
internal static class BeforeRenderHelper // TypeDefIndex: 9553
{
	// Fields
	private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks; // 0x0

	// Methods

	// RVA: 0x22F1640 Offset: 0x22EFC40 VA: 0x1822F1640
	public static void Invoke() { }

	// RVA: 0x22F17E0 Offset: 0x22EFDE0 VA: 0x1822F17E0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
public static class CustomRenderTextureManager // TypeDefIndex: 9554
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<CustomRenderTexture> textureLoaded; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x22F7E30 Offset: 0x22F6430 VA: 0x1822F7E30
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[RequiredByNativeCode]
	// RVA: 0x22F7E90 Offset: 0x22F6490 VA: 0x1822F7E90
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[UsedByNativeCode]
public class Display // TypeDefIndex: 9556
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static int m_ActiveEditorGameViewTarget; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x22FA940 Offset: 0x22F8F40 VA: 0x1822FA940
	internal void .ctor() { }

	// RVA: 0x1815DF0 Offset: 0x18143F0 VA: 0x181815DF0
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x22FAAF0 Offset: 0x22F90F0 VA: 0x1822FAAF0
	public int get_renderingWidth() { }

	// RVA: 0x22FAA70 Offset: 0x22F9070 VA: 0x1822FAA70
	public int get_renderingHeight() { }

	// RVA: 0x22FABF0 Offset: 0x22F91F0 VA: 0x1822FABF0
	public int get_systemWidth() { }

	// RVA: 0x22FAB70 Offset: 0x22F9170 VA: 0x1822FAB70
	public int get_systemHeight() { }

	// RVA: 0x22FA980 Offset: 0x22F8F80 VA: 0x1822FA980
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x22FA6E0 Offset: 0x22F8CE0 VA: 0x1822FA6E0
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x22FAA20 Offset: 0x22F9020 VA: 0x1822FAA20
	public static Display get_main() { }

	[RequiredByNativeCode]
	// RVA: 0x22FA4B0 Offset: 0x22F8AB0 VA: 0x1822FA4B0
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCode]
	// RVA: 0x22FA300 Offset: 0x22F8900 VA: 0x1822FA300
	internal static void FireDisplaysUpdated() { }

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	// RVA: 0x22FA450 Offset: 0x22F8A50 VA: 0x1822FA450
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	// RVA: 0x22FA3F0 Offset: 0x22F89F0 VA: 0x1822FA3F0
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_GetRenderingBuffersWrapper")]
	// RVA: 0x22FA390 Offset: 0x22F8990 VA: 0x1822FA390
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	// RVA: 0x22FA680 Offset: 0x22F8C80 VA: 0x1822FA680
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x22FA7B0 Offset: 0x22F8DB0 VA: 0x1822FA7B0
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum FullScreenMode // TypeDefIndex: 9557
{
	// Fields
	public int value__; // 0x0
	public const FullScreenMode ExclusiveFullScreen = 0;
	public const FullScreenMode FullScreenWindow = 1;
	public const FullScreenMode MaximizedWindow = 2;
	public const FullScreenMode Windowed = 3;
}

// Namespace: UnityEngine
[NativeType("Runtime/Graphics/RefreshRate.h")]
public struct RefreshRate : IEquatable<RefreshRate>, IComparable<RefreshRate> // TypeDefIndex: 9558
{
	// Fields
	public uint numerator; // 0x0
	public uint denominator; // 0x4

	// Properties
	public double value { get; }

	// Methods

	// RVA: 0x2311090 Offset: 0x230F690 VA: 0x182311090
	public double get_value() { }

	// RVA: 0x2310FB0 Offset: 0x230F5B0 VA: 0x182310FB0 Slot: 4
	public bool Equals(RefreshRate other) { }

	// RVA: 0x2310F50 Offset: 0x230F550 VA: 0x182310F50 Slot: 5
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x2310FF0 Offset: 0x230F5F0 VA: 0x182310FF0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[NativeType("Runtime/Graphics/DisplayInfo.h")]
[UsedByNativeCode]
public struct DisplayInfo : IEquatable<DisplayInfo> // TypeDefIndex: 9559
{
	// Fields
	internal ulong handle; // 0x0
	public int width; // 0x8
	public int height; // 0xC
	public RefreshRate refreshRate; // 0x10
	public RectInt workArea; // 0x18
	public string name; // 0x28

	// Methods

	// RVA: 0x101ACA0 Offset: 0x10192A0 VA: 0x18101ACA0 Slot: 4
	public bool Equals(DisplayInfo other) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetScreenManager()", 0)]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
public sealed class Screen // TypeDefIndex: 9560
{
	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static FullScreenMode fullScreenMode { get; set; }
	public static DisplayInfo mainWindowDisplayInfo { get; }
	public static Resolution[] resolutions { get; }

	// Methods

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	// RVA: 0x2313440 Offset: 0x2311A40 VA: 0x182313440
	public static int get_width() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	// RVA: 0x2313280 Offset: 0x2311880 VA: 0x182313280
	public static int get_height() { }

	[NativeName("GetDPI")]
	// RVA: 0x23131F0 Offset: 0x23117F0 VA: 0x1823131F0
	public static float get_dpi() { }

	// RVA: 0x23131B0 Offset: 0x23117B0 VA: 0x1823131B0
	public static Resolution get_currentResolution() { }

	[NativeName("IsFullscreen")]
	// RVA: 0x2313250 Offset: 0x2311850 VA: 0x182313250
	public static bool get_fullScreen() { }

	[NativeName("GetFullscreenMode")]
	// RVA: 0x2313220 Offset: 0x2311820 VA: 0x182313220
	public static FullScreenMode get_fullScreenMode() { }

	[NativeName("RequestSetFullscreenModeFromScript")]
	// RVA: 0x2313470 Offset: 0x2311A70 VA: 0x182313470
	public static void set_fullScreenMode(FullScreenMode value) { }

	[NativeName("RequestResolution")]
	// RVA: 0x23130A0 Offset: 0x23116A0 VA: 0x1823130A0
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	// RVA: 0x2313100 Offset: 0x2311700 VA: 0x182313100
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	// RVA: 0x23132B0 Offset: 0x23118B0 VA: 0x1823132B0
	public static DisplayInfo get_mainWindowDisplayInfo() { }

	// RVA: 0x2312E20 Offset: 0x2311420 VA: 0x182312E20
	public static void GetDisplayLayout(List<DisplayInfo> displayLayout) { }

	// RVA: 0x2312FE0 Offset: 0x23115E0 VA: 0x182312FE0
	public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position) { }

	[FreeFunction("GetMainWindowDisplayInfo")]
	// RVA: 0x2312EE0 Offset: 0x23114E0 VA: 0x182312EE0
	private static DisplayInfo GetMainWindowDisplayInfo() { }

	[FreeFunction("GetDisplayLayout")]
	// RVA: 0x2312DE0 Offset: 0x23113E0 VA: 0x182312DE0
	private static void GetDisplayLayoutImpl(List<DisplayInfo> displayLayout) { }

	[FreeFunction("MoveMainWindow")]
	// RVA: 0x2312F80 Offset: 0x2311580 VA: 0x182312F80
	private static AsyncOperation MoveMainWindowImpl(in DisplayInfo display, Vector2Int position) { }

	[FreeFunction("ScreenScripting::GetResolutions")]
	// RVA: 0x2313360 Offset: 0x2311960 VA: 0x182313360
	public static Resolution[] get_resolutions() { }

	// RVA: 0x2313170 Offset: 0x2311770 VA: 0x182313170
	private static void get_currentResolution_Injected(out Resolution ret) { }

	// RVA: 0x2313040 Offset: 0x2311640 VA: 0x182313040
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, in RefreshRate preferredRefreshRate) { }

	// RVA: 0x2312EA0 Offset: 0x23114A0 VA: 0x182312EA0
	private static void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret) { }

	// RVA: 0x2312F30 Offset: 0x2311530 VA: 0x182312F30
	private static IntPtr MoveMainWindowImpl_Injected(in DisplayInfo display, in Vector2Int position) { }

	// RVA: 0x2313320 Offset: 0x2311920 VA: 0x182313320
	private static void get_resolutions_Injected(out BlittableArrayWrapper ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public struct RenderBuffer // TypeDefIndex: 9561
{
	// Fields
	internal int m_RenderTextureInstanceID; // 0x0
	internal IntPtr m_BufferPtr; // 0x8
}

// Namespace: UnityEngine
[NativeType("Runtime/GfxDevice/GfxDeviceTypes.h")]
public enum ComputeBufferMode // TypeDefIndex: 9562
{
	// Fields
	public int value__; // 0x0
	public const ComputeBufferMode Immutable = 0;
	public const ComputeBufferMode Dynamic = 1;
	[Obsolete("ComputeBufferMode.Circular is deprecated (legacy mode)")]
	public const ComputeBufferMode Circular = 2;
	[Obsolete("ComputeBufferMode.StreamOut is deprecated (internal use only)")]
	public const ComputeBufferMode StreamOut = 3;
	public const ComputeBufferMode SubUpdates = 4;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public class Graphics // TypeDefIndex: 9563
{
	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0
	internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; // 0x8

	// Methods

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	// RVA: 0x22FF090 Offset: 0x22FD690 VA: 0x1822FF090
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunction("GraphicsScripting::SetNullRT")]
	// RVA: 0x22FF0C0 Offset: 0x22FD6C0 VA: 0x1822FF0C0
	private static void Internal_SetNullRT() { }

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x22FF160 Offset: 0x22FD760 VA: 0x1822FF160
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunction("GraphicsScripting::DrawMeshNow")]
	// RVA: 0x22FEF70 Offset: 0x22FD570 VA: 0x1822FEF70
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	[FreeFunction("GraphicsScripting::DrawTexture")]
	// RVA: 0x22FF050 Offset: 0x22FD650 VA: 0x1822FF050
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunction("GraphicsScripting::DrawMeshInstancedIndirect")]
	// RVA: 0x22FECD0 Offset: 0x22FD2D0 VA: 0x1822FECD0
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	// RVA: 0x22FEAF0 Offset: 0x22FD0F0 VA: 0x1822FEAF0
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunction("GraphicsScripting::Blit")]
	// RVA: 0x22FDD30 Offset: 0x22FC330 VA: 0x1822FDD30
	private static void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0x22FF3D0 Offset: 0x22FD9D0 VA: 0x1822FF3D0
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x22FF200 Offset: 0x22FD800 VA: 0x1822FF200
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x22FF6D0 Offset: 0x22FDCD0 VA: 0x1822FF6D0
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x22FE8D0 Offset: 0x22FCED0 VA: 0x1822FE8D0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x22FE240 Offset: 0x22FC840 VA: 0x1822FE240
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x22FDF90 Offset: 0x22FC590 VA: 0x1822FDF90
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x22FDE10 Offset: 0x22FC410 VA: 0x1822FDE10
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x22FE0A0 Offset: 0x22FC6A0 VA: 0x1822FE0A0
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	[ExcludeFromDocs]
	// RVA: 0x22FE7D0 Offset: 0x22FCDD0 VA: 0x1822FE7D0
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset = 0, MaterialPropertyBlock properties, ShadowCastingMode castShadows = 1, bool receiveShadows = True, int layer = 0, Camera camera, LightProbeUsage lightProbeUsage = 1) { }

	[ExcludeFromDocs]
	// RVA: 0x22FF4C0 Offset: 0x22FDAC0 VA: 0x1822FF4C0
	public static void SetRenderTarget(RenderTexture rt) { }

	// RVA: 0x22FF8D0 Offset: 0x22FDED0 VA: 0x1822FF8D0
	private static void .cctor() { }

	// RVA: 0x22FF0F0 Offset: 0x22FD6F0 VA: 0x1822FF0F0
	private static void Internal_SetRTSimple_Injected(in RenderBuffer color, in RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x22FEF20 Offset: 0x22FD520 VA: 0x1822FEF20
	private static void Internal_DrawMeshNow2_Injected(IntPtr mesh, int subsetIndex, in Matrix4x4 matrix) { }

	// RVA: 0x22FEC50 Offset: 0x22FD250 VA: 0x1822FEC50
	private static void Internal_DrawMeshInstancedIndirect_Injected(IntPtr mesh, int submeshIndex, IntPtr material, in Bounds bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume) { }

	// RVA: 0x22FEA80 Offset: 0x22FD080 VA: 0x1822FEA80
	private static void Internal_BlitMaterial5_Injected(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT) { }

	// RVA: 0x22FDCE0 Offset: 0x22FC2E0 VA: 0x1822FDCE0
	private static void Blit2_Injected(IntPtr source, IntPtr dest) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/CameraUtil.h")]
[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[StaticAccessor("GetGfxDevice()", 0)]
public sealed class GL // TypeDefIndex: 9564
{
	// Properties
	public static Matrix4x4 modelview { set; }

	// Methods

	[NativeName("ImmediateVertex")]
	// RVA: 0x22FD310 Offset: 0x22FB910 VA: 0x1822FD310
	public static void Vertex3(float x, float y, float z) { }

	[NativeName("ImmediateTexCoordAll")]
	// RVA: 0x22FD2B0 Offset: 0x22FB8B0 VA: 0x1822FD2B0
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x22FD260 Offset: 0x22FB860 VA: 0x1822FD260
	public static void TexCoord2(float x, float y) { }

	[NativeName("ImmediateColor")]
	// RVA: 0x22FD050 Offset: 0x22FB650 VA: 0x1822FD050
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x22FCDA0 Offset: 0x22FB3A0 VA: 0x1822FCDA0
	public static void Color(Color c) { }

	// RVA: 0x22FD220 Offset: 0x22FB820 VA: 0x1822FD220
	private static void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x22FD3F0 Offset: 0x22FB9F0 VA: 0x1822FD3F0
	public static void set_modelview(Matrix4x4 value) { }

	[FreeFunction("GLPushMatrixScript")]
	// RVA: 0x22FD1B0 Offset: 0x22FB7B0 VA: 0x1822FD1B0
	public static void PushMatrix() { }

	[FreeFunction("GLPopMatrixScript")]
	// RVA: 0x22FD180 Offset: 0x22FB780 VA: 0x1822FD180
	public static void PopMatrix() { }

	[FreeFunction("GLLoadOrthoScript")]
	// RVA: 0x22FD0D0 Offset: 0x22FB6D0 VA: 0x1822FD0D0
	public static void LoadOrtho() { }

	[FreeFunction("GLLoadProjectionMatrixScript")]
	// RVA: 0x22FD140 Offset: 0x22FB740 VA: 0x1822FD140
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunction("GLGetGPUProjectionMatrix")]
	// RVA: 0x22FCFE0 Offset: 0x22FB5E0 VA: 0x1822FCFE0
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunction]
	// RVA: 0x22FCF00 Offset: 0x22FB500 VA: 0x1822FCF00
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x22FCF00 Offset: 0x22FB500 VA: 0x1822FCF00
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunction("GLBegin", ThrowsException = True)]
	// RVA: 0x22FCCF0 Offset: 0x22FB2F0 VA: 0x1822FCCF0
	public static void Begin(int mode) { }

	[FreeFunction("GLEnd")]
	// RVA: 0x22FCDF0 Offset: 0x22FB3F0 VA: 0x1822FCDF0
	public static void End() { }

	[FreeFunction]
	// RVA: 0x22FCE90 Offset: 0x22FB490 VA: 0x1822FCE90
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x22FCD30 Offset: 0x22FB330 VA: 0x1822FCD30
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[FreeFunction("SetGLViewport")]
	// RVA: 0x22FD3B0 Offset: 0x22FB9B0 VA: 0x1822FD3B0
	public static void Viewport(Rect pixelRect) { }

	// RVA: 0x22FD1E0 Offset: 0x22FB7E0 VA: 0x1822FD1E0
	private static void SetViewMatrix_Injected(in Matrix4x4 m) { }

	// RVA: 0x22FD100 Offset: 0x22FB700 VA: 0x1822FD100
	private static void LoadProjectionMatrix_Injected(in Matrix4x4 mat) { }

	// RVA: 0x22FCF80 Offset: 0x22FB580 VA: 0x1822FCF80
	private static void GetGPUProjectionMatrix_Injected(in Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x22FCE20 Offset: 0x22FB420 VA: 0x1822FCE20
	private static void GLClear_Injected(bool clearDepth, bool clearColor, in Color backgroundColor, float depth) { }

	// RVA: 0x22FD370 Offset: 0x22FB970 VA: 0x1822FD370
	private static void Viewport_Injected(in Rect pixelRect) { }
}

// Namespace: UnityEngine
[StaticAccessor("ScalableBufferManager::GetInstance()", 0)]
[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
public static class ScalableBufferManager // TypeDefIndex: 9565
{
	// Properties
	public static float widthScaleFactor { get; }
	public static float heightScaleFactor { get; }

	// Methods

	// RVA: 0x2312DB0 Offset: 0x23113B0 VA: 0x182312DB0
	public static float get_widthScaleFactor() { }

	// RVA: 0x2312D80 Offset: 0x2311380 VA: 0x182312D80
	public static float get_heightScaleFactor() { }
}

// Namespace: UnityEngine
[StaticAccessor("GetLightmapSettings()")]
[NativeHeader("Runtime/Graphics/LightmapSettings.h")]
public sealed class LightmapSettings : Object // TypeDefIndex: 9566
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
public sealed class LightProbes : Object // TypeDefIndex: 9567
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action lightProbesUpdated; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action tetrahedralizationCompleted; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action needsRetetrahedralization; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2300020 Offset: 0x22FE620 VA: 0x182300020
	private static void Internal_CallLightProbesUpdatedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x23000C0 Offset: 0x22FE6C0 VA: 0x1823000C0
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x2300070 Offset: 0x22FE670 VA: 0x182300070
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public struct Resolution // TypeDefIndex: 9568
{
	// Fields
	private int m_Width; // 0x0
	private int m_Height; // 0x4
	private RefreshRate m_RefreshRate; // 0x8

	// Properties
	public int width { get; }
	public int height { get; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public int get_width() { }

	// RVA: 0x9BF260 Offset: 0x9BD860 VA: 0x1809BF260
	public int get_height() { }

	// RVA: 0x2312BD0 Offset: 0x23111D0 VA: 0x182312BD0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[IsReadOnly]
internal struct RenderInstancedDataLayout // TypeDefIndex: 9569
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <size>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <offsetObjectToWorld>k__BackingField; // 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <offsetPrevObjectToWorld>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <offsetRenderingLayerMask>k__BackingField; // 0xC
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
internal struct Internal_DrawTextureArguments // TypeDefIndex: 9570
{
	// Fields
	public Rect screenRect; // 0x0
	public Rect sourceRect; // 0x10
	public int leftBorder; // 0x20
	public int rightBorder; // 0x24
	public int topBorder; // 0x28
	public int bottomBorder; // 0x2C
	public Color leftBorderColor; // 0x30
	public Color rightBorderColor; // 0x40
	public Color topBorderColor; // 0x50
	public Color bottomBorderColor; // 0x60
	public Color color; // 0x70
	public Vector4 borderWidths; // 0x80
	public Vector4 cornerRadiuses; // 0x90
	public bool smoothCorners; // 0xA0
	public int pass; // 0xA4
	public Texture texture; // 0xA8
	public Material mat; // 0xB0
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[StaticAccessor("GetQualitySettings()", 0)]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
public sealed class QualitySettings : Object // TypeDefIndex: 9571
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int, int> activeQualityLevelChanged; // 0x0

	// Properties
	[NativeProperty("ShadowQuality")]
	public static ShadowQuality shadows { set; }
	public static int shadowCascades { set; }
	public static float shadowDistance { set; }
	[NativeProperty("ShadowResolution")]
	public static ShadowResolution shadowResolution { set; }
	public static int globalTextureMipmapLimit { set; }
	public static bool softParticles { set; }
	public static int vSyncCount { set; }
	public static int antiAliasing { set; }
	[NativeName("RenderPipeline")]
	private static ScriptableObject INTERNAL_renderPipeline { get; set; }
	public static RenderPipelineAsset renderPipeline { get; set; }
	[StaticAccessor("QualitySettingsScripting", 2)]
	public static int maxQueuedFrames { set; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x230E640 Offset: 0x230CC40 VA: 0x18230E640
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	// RVA: 0x230EA60 Offset: 0x230D060 VA: 0x18230EA60
	public static void set_shadows(ShadowQuality value) { }

	// RVA: 0x230E9A0 Offset: 0x230CFA0 VA: 0x18230E9A0
	public static void set_shadowCascades(int value) { }

	// RVA: 0x230E9E0 Offset: 0x230CFE0 VA: 0x18230E9E0
	public static void set_shadowDistance(float value) { }

	// RVA: 0x230EA20 Offset: 0x230D020 VA: 0x18230EA20
	public static void set_shadowResolution(ShadowResolution value) { }

	// RVA: 0x230E920 Offset: 0x230CF20 VA: 0x18230E920
	public static void set_globalTextureMipmapLimit(int value) { }

	// RVA: 0x230EAA0 Offset: 0x230D0A0 VA: 0x18230EAA0
	public static void set_softParticles(bool value) { }

	// RVA: 0x230EAE0 Offset: 0x230D0E0 VA: 0x18230EAE0
	public static void set_vSyncCount(int value) { }

	// RVA: 0x230E8E0 Offset: 0x230CEE0 VA: 0x18230E8E0
	public static void set_antiAliasing(int value) { }

	// RVA: 0x230E6D0 Offset: 0x230CCD0 VA: 0x18230E6D0
	private static ScriptableObject get_INTERNAL_renderPipeline() { }

	// RVA: 0x230E870 Offset: 0x230CE70 VA: 0x18230E870
	private static void set_INTERNAL_renderPipeline(ScriptableObject value) { }

	// RVA: 0x230E760 Offset: 0x230CD60 VA: 0x18230E760
	public static RenderPipelineAsset get_renderPipeline() { }

	// RVA: 0x230E870 Offset: 0x230CE70 VA: 0x18230E870
	public static void set_renderPipeline(RenderPipelineAsset value) { }

	// RVA: 0x230E960 Offset: 0x230CF60 VA: 0x18230E960
	public static void set_maxQueuedFrames(int value) { }

	[StaticAccessor("GetPlayerSettings()", 0)]
	[NativeName("GetColorSpace")]
	// RVA: 0x230E730 Offset: 0x230CD30 VA: 0x18230E730
	public static ColorSpace get_activeColorSpace() { }

	// RVA: 0x230E6A0 Offset: 0x230CCA0 VA: 0x18230E6A0
	private static IntPtr get_INTERNAL_renderPipeline_Injected() { }

	// RVA: 0x230E830 Offset: 0x230CE30 VA: 0x18230E830
	private static void set_INTERNAL_renderPipeline_Injected(IntPtr value) { }
}

// Namespace: UnityEngine
public sealed class ImageEffectAllowedInSceneView : Attribute // TypeDefIndex: 9572
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(64)]
public sealed class ImageEffectUsesCommandBuffer : Attribute // TypeDefIndex: 9573
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/TrailRenderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public sealed class TrailRenderer : Renderer // TypeDefIndex: 9574
{
	// Properties
	public float startWidth { get; set; }
	public bool emitting { set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }

	// Methods

	// RVA: 0x23144B0 Offset: 0x2312AB0 VA: 0x1823144B0
	public float get_startWidth() { }

	// RVA: 0x2314820 Offset: 0x2312E20 VA: 0x182314820
	public void set_startWidth(float value) { }

	// RVA: 0x2314580 Offset: 0x2312B80 VA: 0x182314580
	public void set_emitting(bool value) { }

	// RVA: 0x23143E0 Offset: 0x23129E0 VA: 0x1823143E0
	public Color get_startColor() { }

	// RVA: 0x2314740 Offset: 0x2312D40 VA: 0x182314740
	public void set_startColor(Color value) { }

	// RVA: 0x2314300 Offset: 0x2312900 VA: 0x182314300
	public Color get_endColor() { }

	// RVA: 0x2314660 Offset: 0x2312C60 VA: 0x182314660
	public void set_endColor(Color value) { }

	// RVA: 0x2314230 Offset: 0x2312830 VA: 0x182314230
	public void Clear() { }

	// RVA: 0x2314470 Offset: 0x2312A70 VA: 0x182314470
	private static float get_startWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x23147D0 Offset: 0x2312DD0 VA: 0x1823147D0
	private static void set_startWidth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2314530 Offset: 0x2312B30 VA: 0x182314530
	private static void set_emitting_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2314390 Offset: 0x2312990 VA: 0x182314390
	private static void get_startColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x23146F0 Offset: 0x2312CF0 VA: 0x1823146F0
	private static void set_startColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x23142B0 Offset: 0x23128B0 VA: 0x1823142B0
	private static void get_endColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x2314610 Offset: 0x2312C10 VA: 0x182314610
	private static void set_endColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x23141F0 Offset: 0x23127F0 VA: 0x1823141F0
	private static void Clear_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
public sealed class LineRenderer : Renderer // TypeDefIndex: 9575
{
	// Properties
	public float startWidth { get; set; }
	public float endWidth { set; }
	public bool useWorldSpace { set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }
	[NativeProperty("PositionsCount")]
	public int positionCount { set; }

	// Methods

	// RVA: 0x2301170 Offset: 0x22FF770 VA: 0x182301170
	public float get_startWidth() { }

	// RVA: 0x23015B0 Offset: 0x22FFBB0 VA: 0x1823015B0
	public void set_startWidth(float value) { }

	// RVA: 0x2301320 Offset: 0x22FF920 VA: 0x182301320
	public void set_endWidth(float value) { }

	// RVA: 0x2301690 Offset: 0x22FFC90 VA: 0x182301690
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x23010A0 Offset: 0x22FF6A0 VA: 0x1823010A0
	public Color get_startColor() { }

	// RVA: 0x23014D0 Offset: 0x22FFAD0 VA: 0x1823014D0
	public void set_startColor(Color value) { }

	// RVA: 0x2300FC0 Offset: 0x22FF5C0 VA: 0x182300FC0
	public Color get_endColor() { }

	// RVA: 0x2301240 Offset: 0x22FF840 VA: 0x182301240
	public void set_endColor(Color value) { }

	// RVA: 0x23013F0 Offset: 0x22FF9F0 VA: 0x1823013F0
	public void set_positionCount(int value) { }

	// RVA: 0x2300D50 Offset: 0x22FF350 VA: 0x182300D50
	public void SetPosition(int index, Vector3 position) { }

	[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = True)]
	// RVA: 0x2300E40 Offset: 0x22FF440 VA: 0x182300E40
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x2301130 Offset: 0x22FF730 VA: 0x182301130
	private static float get_startWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x2301560 Offset: 0x22FFB60 VA: 0x182301560
	private static void set_startWidth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x23012D0 Offset: 0x22FF8D0 VA: 0x1823012D0
	private static void set_endWidth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2301640 Offset: 0x22FFC40 VA: 0x182301640
	private static void set_useWorldSpace_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2301050 Offset: 0x22FF650 VA: 0x182301050
	private static void get_startColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x2301480 Offset: 0x22FFA80 VA: 0x182301480
	private static void set_startColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x2300F70 Offset: 0x22FF570 VA: 0x182300F70
	private static void get_endColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x23011F0 Offset: 0x22FF7F0 VA: 0x1823011F0
	private static void set_endColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x23013B0 Offset: 0x22FF9B0 VA: 0x1823013B0
	private static void set_positionCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2300D00 Offset: 0x22FF300 VA: 0x182300D00
	private static void SetPosition_Injected(IntPtr _unity_self, int index, in Vector3 position) { }

	// RVA: 0x2300DF0 Offset: 0x22FF3F0 VA: 0x182300DF0
	private static void SetPositions_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
public sealed class MaterialPropertyBlock // TypeDefIndex: 9577
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isEmpty { get; }

	// Methods

	[NativeName("GetFloatFromScript")]
	[ThreadSafe]
	// RVA: 0x2301C60 Offset: 0x2300260 VA: 0x182301C60
	private float GetFloatImpl(int name) { }

	[ThreadSafe]
	[NativeName("GetVectorFromScript")]
	// RVA: 0x2301DF0 Offset: 0x23003F0 VA: 0x182301DF0
	private Vector4 GetVectorImpl(int name) { }

	[ThreadSafe]
	[NativeName("GetColorFromScript")]
	// RVA: 0x2301B10 Offset: 0x2300110 VA: 0x182301B10
	private Color GetColorImpl(int name) { }

	[NativeName("GetTextureFromScript")]
	[ThreadSafe]
	// RVA: 0x2301D00 Offset: 0x2300300 VA: 0x182301D00
	private Texture GetTextureImpl(int name) { }

	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	// RVA: 0x2302280 Offset: 0x2300880 VA: 0x182302280
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetVectorFromScript")]
	[ThreadSafe]
	// RVA: 0x2302B00 Offset: 0x2301100 VA: 0x182302B00
	private void SetVectorImpl(int name, Vector4 value) { }

	[ThreadSafe]
	[NativeName("SetColorFromScript")]
	// RVA: 0x23020C0 Offset: 0x23006C0 VA: 0x1823020C0
	private void SetColorImpl(int name, Color value) { }

	[ThreadSafe]
	[NativeName("SetMatrixFromScript")]
	// RVA: 0x23023D0 Offset: 0x23009D0 VA: 0x1823023D0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	// RVA: 0x2302520 Offset: 0x2300B20 VA: 0x182302520
	private void SetTextureImpl(int name, Texture value) { }

	[NativeName("SetBufferFromScript")]
	[ThreadSafe]
	// RVA: 0x2301F50 Offset: 0x2300550 VA: 0x182301F50
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[ThreadSafe]
	[NativeName("SetVectorArrayFromScript")]
	// RVA: 0x2302750 Offset: 0x2300D50 VA: 0x182302750
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	// RVA: 0x23018F0 Offset: 0x22FFEF0 VA: 0x1823018F0
	private static IntPtr CreateImpl() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2301920 Offset: 0x22FFF20 VA: 0x182301920
	private static void DestroyImpl(IntPtr mpb) { }

	[ThreadSafe]
	[NativeName("IsEmpty")]
	// RVA: 0x2302C60 Offset: 0x2301260 VA: 0x182302C60
	public bool get_isEmpty() { }

	[ThreadSafe]
	// RVA: 0x2301830 Offset: 0x22FFE30 VA: 0x182301830
	private void Clear(bool keepMemory) { }

	// RVA: 0x2301890 Offset: 0x22FFE90 VA: 0x182301890
	public void Clear() { }

	// RVA: 0x23028A0 Offset: 0x2300EA0 VA: 0x1823028A0
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x2302BE0 Offset: 0x23011E0 VA: 0x182302BE0
	public void .ctor() { }

	// RVA: 0x23019F0 Offset: 0x22FFFF0 VA: 0x1823019F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2301960 Offset: 0x22FFF60 VA: 0x182301960
	private void Dispose() { }

	// RVA: 0x23022F0 Offset: 0x23008F0 VA: 0x1823022F0
	public void SetFloat(string name, float value) { }

	// RVA: 0x2302280 Offset: 0x2300880 VA: 0x182302280
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x2302B70 Offset: 0x2301170 VA: 0x182302B70
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x23021A0 Offset: 0x23007A0 VA: 0x1823021A0
	public void SetColor(string name, Color value) { }

	// RVA: 0x2302130 Offset: 0x2300730 VA: 0x182302130
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x2302440 Offset: 0x2300A40 VA: 0x182302440
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2301FD0 Offset: 0x23005D0 VA: 0x182301FD0
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x2301F50 Offset: 0x2300550 VA: 0x182301F50
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x2302600 Offset: 0x2300C00 VA: 0x182302600
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x2302520 Offset: 0x2300B20 VA: 0x182302520
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x2302870 Offset: 0x2300E70 VA: 0x182302870
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x2301C60 Offset: 0x2300260 VA: 0x182301C60
	public float GetFloat(int nameID) { }

	// RVA: 0x2301E70 Offset: 0x2300470 VA: 0x182301E70
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x2301B90 Offset: 0x2300190 VA: 0x182301B90
	public Color GetColor(int nameID) { }

	// RVA: 0x2301D00 Offset: 0x2300300 VA: 0x182301D00
	public Texture GetTexture(int nameID) { }

	// RVA: 0x2301C20 Offset: 0x2300220 VA: 0x182301C20
	private static float GetFloatImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x2301DA0 Offset: 0x23003A0 VA: 0x182301DA0
	private static void GetVectorImpl_Injected(IntPtr _unity_self, int name, out Vector4 ret) { }

	// RVA: 0x2301AC0 Offset: 0x23000C0 VA: 0x182301AC0
	private static void GetColorImpl_Injected(IntPtr _unity_self, int name, out Color ret) { }

	// RVA: 0x2301CC0 Offset: 0x23002C0 VA: 0x182301CC0
	private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x2302230 Offset: 0x2300830 VA: 0x182302230
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	// RVA: 0x2302AB0 Offset: 0x23010B0 VA: 0x182302AB0
	private static void SetVectorImpl_Injected(IntPtr _unity_self, int name, in Vector4 value) { }

	// RVA: 0x2302070 Offset: 0x2300670 VA: 0x182302070
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	// RVA: 0x2302380 Offset: 0x2300980 VA: 0x182302380
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	// RVA: 0x23024D0 Offset: 0x2300AD0 VA: 0x1823024D0
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	// RVA: 0x2301F00 Offset: 0x2300500 VA: 0x182301F00
	private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	// RVA: 0x23026F0 Offset: 0x2300CF0 VA: 0x1823026F0
	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	// RVA: 0x2302C20 Offset: 0x2301220 VA: 0x182302C20
	private static bool get_isEmpty_Injected(IntPtr _unity_self) { }

	// RVA: 0x23017E0 Offset: 0x22FFDE0 VA: 0x1823017E0
	private static void Clear_Injected(IntPtr _unity_self, bool keepMemory) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/Renderer.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public class Renderer : Component // TypeDefIndex: 9578
{
	// Properties
	public Bounds bounds { get; }
	public Bounds localBounds { set; }
	public bool enabled { get; set; }
	public ShadowCastingMode shadowCastingMode { set; }
	public bool receiveShadows { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	internal int sortingGroupID { get; }
	internal int sortingGroupOrder { get; }
	public bool isPartOfStaticBatch { get; }
	public Material[] materials { set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	// RVA: 0x23121A0 Offset: 0x23107A0 VA: 0x1823121A0
	public Bounds get_bounds() { }

	[NativeName("SetLocalAABB")]
	// RVA: 0x23127F0 Offset: 0x2310DF0 VA: 0x1823127F0
	public void set_localBounds(Bounds value) { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	// RVA: 0x2311600 Offset: 0x230FC00 VA: 0x182311600
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	// RVA: 0x2311950 Offset: 0x230FF50 VA: 0x182311950
	private Material GetSharedMaterial() { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	// RVA: 0x2312090 Offset: 0x2310690 VA: 0x182312090
	private void SetMaterial(Material m) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = True)]
	// RVA: 0x2311470 Offset: 0x230FA70 VA: 0x182311470
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	// RVA: 0x2311EB0 Offset: 0x23104B0 VA: 0x182311EB0
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x2311F70 Offset: 0x2310570 VA: 0x182311F70
	private void SetMaterialArray(Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	// RVA: 0x2311DB0 Offset: 0x23103B0 VA: 0x182311DB0
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	// RVA: 0x2311780 Offset: 0x230FD80 VA: 0x182311780
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlockMaterialIndex", HasExplicitThis = True)]
	// RVA: 0x2311CB0 Offset: 0x23102B0 VA: 0x182311CB0
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlockMaterialIndex", HasExplicitThis = True)]
	// RVA: 0x23116A0 Offset: 0x230FCA0 VA: 0x1823116A0
	internal void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex) { }

	// RVA: 0x2311DB0 Offset: 0x23103B0 VA: 0x182311DB0
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x2311CB0 Offset: 0x23102B0 VA: 0x182311CB0
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x2311780 Offset: 0x230FD80 VA: 0x182311780
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x23116A0 Offset: 0x230FCA0 VA: 0x1823116A0
	public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x2312280 Offset: 0x2310880 VA: 0x182312280
	public bool get_enabled() { }

	// RVA: 0x2312710 Offset: 0x2310D10 VA: 0x182312710
	public void set_enabled(bool value) { }

	// RVA: 0x23129A0 Offset: 0x2310FA0 VA: 0x1823129A0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x23128D0 Offset: 0x2310ED0 VA: 0x1823128D0
	public void set_receiveShadows(bool value) { }

	// RVA: 0x2312580 Offset: 0x2310B80 VA: 0x182312580
	public int get_sortingLayerID() { }

	// RVA: 0x2312A70 Offset: 0x2311070 VA: 0x182312A70
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2312640 Offset: 0x2310C40 VA: 0x182312640
	public int get_sortingOrder() { }

	// RVA: 0x2312B40 Offset: 0x2311140 VA: 0x182312B40
	public void set_sortingOrder(int value) { }

	// RVA: 0x2312400 Offset: 0x2310A00 VA: 0x182312400
	internal int get_sortingGroupID() { }

	// RVA: 0x23124C0 Offset: 0x2310AC0 VA: 0x1823124C0
	internal int get_sortingGroupOrder() { }

	[NativeName("IsPartOfStaticBatch")]
	// RVA: 0x2312340 Offset: 0x2310940 VA: 0x182312340
	public bool get_isPartOfStaticBatch() { }

	// RVA: 0x2311540 Offset: 0x230FB40 VA: 0x182311540
	private int GetMaterialCount() { }

	[NativeName("GetMaterialArray")]
	// RVA: 0x2311890 Offset: 0x230FE90 VA: 0x182311890
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x2311F70 Offset: 0x2310570 VA: 0x182311F70
	public void set_materials(Material[] value) { }

	// RVA: 0x2311600 Offset: 0x230FC00 VA: 0x182311600
	public Material get_material() { }

	// RVA: 0x2312090 Offset: 0x2310690 VA: 0x182312090
	public void set_material(Material value) { }

	// RVA: 0x2311950 Offset: 0x230FF50 VA: 0x182311950
	public Material get_sharedMaterial() { }

	// RVA: 0x2312090 Offset: 0x2310690 VA: 0x182312090
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x2311890 Offset: 0x230FE90 VA: 0x182311890
	public Material[] get_sharedMaterials() { }

	// RVA: 0x2311F70 Offset: 0x2310570 VA: 0x182311F70
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x23119F0 Offset: 0x230FFF0 VA: 0x1823119F0
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x2312150 Offset: 0x2310750 VA: 0x182312150
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	// RVA: 0x23127A0 Offset: 0x2310DA0 VA: 0x1823127A0
	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	// RVA: 0x23115C0 Offset: 0x230FBC0 VA: 0x1823115C0
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x2311910 Offset: 0x230FF10 VA: 0x182311910
	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x2312040 Offset: 0x2310640 VA: 0x182312040
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	// RVA: 0x2311420 Offset: 0x230FA20 VA: 0x182311420
	private static void CopySharedMaterialArray_Injected(IntPtr _unity_self, [Out] Material[] m) { }

	// RVA: 0x2311E50 Offset: 0x2310450 VA: 0x182311E50
	private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length) { }

	// RVA: 0x2311D60 Offset: 0x2310360 VA: 0x182311D60
	private static void Internal_SetPropertyBlock_Injected(IntPtr _unity_self, IntPtr properties) { }

	// RVA: 0x2311C00 Offset: 0x2310200 VA: 0x182311C00
	private static void Internal_GetPropertyBlock_Injected(IntPtr _unity_self, IntPtr dest) { }

	// RVA: 0x2311C50 Offset: 0x2310250 VA: 0x182311C50
	private static void Internal_SetPropertyBlockMaterialIndex_Injected(IntPtr _unity_self, IntPtr properties, int materialIndex) { }

	// RVA: 0x2311BA0 Offset: 0x23101A0 VA: 0x182311BA0
	private static void Internal_GetPropertyBlockMaterialIndex_Injected(IntPtr _unity_self, IntPtr dest, int materialIndex) { }

	// RVA: 0x2312240 Offset: 0x2310840 VA: 0x182312240
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x23126C0 Offset: 0x2310CC0 VA: 0x1823126C0
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2312960 Offset: 0x2310F60 VA: 0x182312960
	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	// RVA: 0x2312880 Offset: 0x2310E80 VA: 0x182312880
	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2312540 Offset: 0x2310B40 VA: 0x182312540
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x2312A30 Offset: 0x2311030 VA: 0x182312A30
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2312600 Offset: 0x2310C00 VA: 0x182312600
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x2312B00 Offset: 0x2311100 VA: 0x182312B00
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x23123C0 Offset: 0x23109C0 VA: 0x1823123C0
	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	// RVA: 0x2312480 Offset: 0x2310A80 VA: 0x182312480
	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x2312300 Offset: 0x2310900 VA: 0x182312300
	private static bool get_isPartOfStaticBatch_Injected(IntPtr _unity_self) { }

	// RVA: 0x2311500 Offset: 0x230FB00 VA: 0x182311500
	private static int GetMaterialCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x2311850 Offset: 0x230FE50 VA: 0x182311850
	private static Material[] GetSharedMaterialArray_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/RenderSettings.h")]
[StaticAccessor("GetRenderSettings()", 0)]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
public sealed class RenderSettings : Object // TypeDefIndex: 9579
{
	// Properties
	[NativeProperty("UseFog")]
	public static bool fog { get; set; }
	[NativeProperty("LinearFogStart")]
	public static float fogStartDistance { get; }
	[NativeProperty("LinearFogEnd")]
	public static float fogEndDistance { get; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; set; }
	[NativeProperty("AmbientSkyColor")]
	public static Color ambientLight { set; }
	[NativeProperty("SkyboxMaterial")]
	public static Material skybox { set; }

	// Methods

	// RVA: 0x23111C0 Offset: 0x230F7C0 VA: 0x1823111C0
	public static bool get_fog() { }

	// RVA: 0x2311330 Offset: 0x230F930 VA: 0x182311330
	public static void set_fog(bool value) { }

	// RVA: 0x2311190 Offset: 0x230F790 VA: 0x182311190
	public static float get_fogStartDistance() { }

	// RVA: 0x2311160 Offset: 0x230F760 VA: 0x182311160
	public static float get_fogEndDistance() { }

	// RVA: 0x23110F0 Offset: 0x230F6F0 VA: 0x1823110F0
	public static Color get_fogColor() { }

	// RVA: 0x23112B0 Offset: 0x230F8B0 VA: 0x1823112B0
	public static void set_fogColor(Color value) { }

	// RVA: 0x2311130 Offset: 0x230F730 VA: 0x182311130
	public static float get_fogDensity() { }

	// RVA: 0x23112F0 Offset: 0x230F8F0 VA: 0x1823112F0
	public static void set_fogDensity(float value) { }

	// RVA: 0x2311230 Offset: 0x230F830 VA: 0x182311230
	public static void set_ambientLight(Color value) { }

	// RVA: 0x23113B0 Offset: 0x230F9B0 VA: 0x1823113B0
	public static void set_skybox(Material value) { }

	// RVA: 0x23110B0 Offset: 0x230F6B0 VA: 0x1823110B0
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x2311270 Offset: 0x230F870 VA: 0x182311270
	private static void set_fogColor_Injected(in Color value) { }

	// RVA: 0x23111F0 Offset: 0x230F7F0 VA: 0x1823111F0
	private static void set_ambientLight_Injected(in Color value) { }

	// RVA: 0x2311370 Offset: 0x230F970 VA: 0x182311370
	private static void set_skybox_Injected(IntPtr value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
public sealed class Shader : Object // TypeDefIndex: 9580
{
	// Properties
	public bool isSupported { get; }

	// Methods

	// RVA: 0x23134B0 Offset: 0x2311AB0 VA: 0x1823134B0
	public static Shader Find(string name) { }

	[NativeMethod("IsSupported")]
	// RVA: 0x2313930 Offset: 0x2311F30 VA: 0x182313930
	public bool get_isSupported() { }

	[FreeFunction("ShaderScripting::TagToID")]
	// RVA: 0x2313770 Offset: 0x2311D70 VA: 0x182313770
	internal static int TagToID(string name) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	// RVA: 0x2313560 Offset: 0x2311B60 VA: 0x182313560
	public static int PropertyToID(string name) { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	// RVA: 0x23136E0 Offset: 0x2311CE0 VA: 0x1823136E0
	private static void SetGlobalFloatImpl(int name, float value) { }

	// RVA: 0x23136E0 Offset: 0x2311CE0 VA: 0x1823136E0
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x23138F0 Offset: 0x2311EF0 VA: 0x1823138F0
	private static bool get_isSupported_Injected(IntPtr _unity_self) { }

	// RVA: 0x2313730 Offset: 0x2311D30 VA: 0x182313730
	private static int TagToID_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x2313520 Offset: 0x2311B20 VA: 0x182313520
	private static int PropertyToID_Injected(ref ManagedSpanWrapper name) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
public class Material : Object // TypeDefIndex: 9581
{
	// Fields
	private static readonly int k_ColorId; // 0x0
	private static readonly int k_MainTexId; // 0x4

	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; set; }
	public Vector2 mainTextureOffset { get; set; }
	public Vector2 mainTextureScale { set; }
	public int renderQueue { get; set; }
	public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[FreeFunction("MaterialScripting::CreateWithShader")]
	// RVA: 0x2303040 Offset: 0x2301640 VA: 0x182303040
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	// RVA: 0x2302F20 Offset: 0x2301520 VA: 0x182302F20
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	// RVA: 0x2303110 Offset: 0x2301710 VA: 0x182303110
	private static void CreateWithString(Material self) { }

	// RVA: 0x2306420 Offset: 0x2304A20 VA: 0x182306420
	public void .ctor(Shader shader) { }

	[RequiredByNativeCode]
	// RVA: 0x23065E0 Offset: 0x2304BE0 VA: 0x1823065E0
	public void .ctor(Material source) { }

	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	[EditorBrowsable(1)]
	// RVA: 0x2306550 Offset: 0x2304B50 VA: 0x182306550
	public void .ctor(string contents) { }

	// RVA: 0x23038B0 Offset: 0x2301EB0 VA: 0x1823038B0
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x2306CB0 Offset: 0x23052B0 VA: 0x182306CB0
	public Shader get_shader() { }

	// RVA: 0x23074B0 Offset: 0x2305AB0 VA: 0x1823074B0
	public void set_shader(Shader value) { }

	// RVA: 0x2306710 Offset: 0x2304D10 VA: 0x182306710
	public Color get_color() { }

	// RVA: 0x2306D70 Offset: 0x2305370 VA: 0x182306D70
	public void set_color(Color value) { }

	// RVA: 0x2306A90 Offset: 0x2305090 VA: 0x182306A90
	public Texture get_mainTexture() { }

	// RVA: 0x2307250 Offset: 0x2305850 VA: 0x182307250
	public void set_mainTexture(Texture value) { }

	// RVA: 0x2306990 Offset: 0x2304F90 VA: 0x182306990
	public Vector2 get_mainTextureOffset() { }

	// RVA: 0x2306FF0 Offset: 0x23055F0 VA: 0x182306FF0
	public void set_mainTextureOffset(Vector2 value) { }

	// RVA: 0x2307120 Offset: 0x2305720 VA: 0x182307120
	public void set_mainTextureScale(Vector2 value) { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	// RVA: 0x2303970 Offset: 0x2301F70 VA: 0x182303970
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeName("HasPropertyFromScript")]
	// RVA: 0x23042F0 Offset: 0x23028F0 VA: 0x1823042F0
	public bool HasProperty(int nameID) { }

	// RVA: 0x23043A0 Offset: 0x23029A0 VA: 0x1823043A0
	public bool HasProperty(string name) { }

	[NativeName("GetActualRenderQueue")]
	// RVA: 0x2306BD0 Offset: 0x23051D0 VA: 0x182306BD0
	public int get_renderQueue() { }

	[NativeName("SetCustomRenderQueue")]
	// RVA: 0x23073B0 Offset: 0x23059B0 VA: 0x1823073B0
	public void set_renderQueue(int value) { }

	// RVA: 0x23033D0 Offset: 0x23019D0 VA: 0x1823033D0
	public void EnableKeyword(string keyword) { }

	// RVA: 0x23031A0 Offset: 0x23017A0 VA: 0x1823031A0
	public void DisableKeyword(string keyword) { }

	// RVA: 0x23068F0 Offset: 0x2304EF0 VA: 0x1823068F0
	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	// RVA: 0x2306F40 Offset: 0x2305540 VA: 0x182306F40
	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = True)]
	// RVA: 0x2305AC0 Offset: 0x23040C0 VA: 0x182305AC0
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	// RVA: 0x23055A0 Offset: 0x2303BA0 VA: 0x1823055A0
	public void SetOverrideTag(string tag, string val) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	// RVA: 0x23058B0 Offset: 0x2303EB0 VA: 0x1823058B0
	public bool SetPass(int pass) { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	// RVA: 0x2302DF0 Offset: 0x23013F0 VA: 0x182302DF0
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x2303D80 Offset: 0x2302380 VA: 0x182303D80
	private string[] GetShaderKeywords() { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x23059B0 Offset: 0x2303FB0 VA: 0x1823059B0
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x2303D80 Offset: 0x2302380 VA: 0x182303D80
	public string[] get_shaderKeywords() { }

	// RVA: 0x23059B0 Offset: 0x2303FB0 VA: 0x1823059B0
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x2302D00 Offset: 0x2301300 VA: 0x182302D00
	public int ComputeCRC() { }

	[NativeName("SetFloatFromScript")]
	// RVA: 0x23051F0 Offset: 0x23037F0 VA: 0x1823051F0
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetColorFromScript")]
	// RVA: 0x2304B10 Offset: 0x2303110 VA: 0x182304B10
	private void SetColorImpl(int name, Color value) { }

	[NativeName("SetMatrixFromScript")]
	// RVA: 0x23053A0 Offset: 0x23039A0 VA: 0x1823053A0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeName("SetTextureFromScript")]
	// RVA: 0x2305D00 Offset: 0x2304300 VA: 0x182305D00
	private void SetTextureImpl(int name, Texture value) { }

	[NativeName("SetBufferFromScript")]
	// RVA: 0x23044B0 Offset: 0x2302AB0 VA: 0x1823044B0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeName("GetFloatFromScript")]
	// RVA: 0x2303A60 Offset: 0x2302060 VA: 0x182303A60
	private float GetFloatImpl(int name) { }

	[NativeName("GetColorFromScript")]
	// RVA: 0x2303600 Offset: 0x2301C00 VA: 0x182303600
	private Color GetColorImpl(int name) { }

	[NativeName("GetTextureFromScript")]
	// RVA: 0x2303E60 Offset: 0x2302460 VA: 0x182303E60
	private Texture GetTextureImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	// RVA: 0x2304DC0 Offset: 0x23033C0 VA: 0x182304DC0
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetColorArray", HasExplicitThis = True)]
	// RVA: 0x23046E0 Offset: 0x2302CE0 VA: 0x1823046E0
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	// RVA: 0x2304040 Offset: 0x2302640 VA: 0x182304040
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	[NativeName("SetTextureOffsetFromScript")]
	// RVA: 0x2305E50 Offset: 0x2304450 VA: 0x182305E50
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeName("SetTextureScaleFromScript")]
	// RVA: 0x2306000 Offset: 0x2304600 VA: 0x182306000
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x2304F60 Offset: 0x2303560 VA: 0x182304F60
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x2304880 Offset: 0x2302E80 VA: 0x182304880
	private void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x2305300 Offset: 0x2303900 VA: 0x182305300
	public void SetInt(string name, int value) { }

	// RVA: 0x2305340 Offset: 0x2303940 VA: 0x182305340
	public void SetInt(int nameID, int value) { }

	// RVA: 0x23052C0 Offset: 0x23038C0 VA: 0x1823052C0
	public void SetFloat(string name, float value) { }

	// RVA: 0x23052B0 Offset: 0x23038B0 VA: 0x1823052B0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x2304C90 Offset: 0x2303290 VA: 0x182304C90
	public void SetColor(string name, Color value) { }

	// RVA: 0x2304BD0 Offset: 0x23031D0 VA: 0x182304BD0
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x23062A0 Offset: 0x23048A0 VA: 0x1823062A0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x23061B0 Offset: 0x23047B0 VA: 0x1823061B0
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x2305460 Offset: 0x2303A60 VA: 0x182305460
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2306160 Offset: 0x2304760 VA: 0x182306160
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x23061A0 Offset: 0x23047A0 VA: 0x1823061A0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x2304590 Offset: 0x2302B90 VA: 0x182304590
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x2304F10 Offset: 0x2303510 VA: 0x182304F10
	public void SetFloatArray(string name, float[] values) { }

	// RVA: 0x2304830 Offset: 0x2302E30 VA: 0x182304830
	public void SetColorArray(string name, Color[] values) { }

	// RVA: 0x2303BD0 Offset: 0x23021D0 VA: 0x182303BD0
	public int GetInt(string name) { }

	// RVA: 0x2303C90 Offset: 0x2302290 VA: 0x182303C90
	public int GetInt(int nameID) { }

	// RVA: 0x2303B10 Offset: 0x2302110 VA: 0x182303B10
	public float GetFloat(string name) { }

	// RVA: 0x2303A60 Offset: 0x2302060 VA: 0x182303A60
	public float GetFloat(int nameID) { }

	// RVA: 0x23036C0 Offset: 0x2301CC0 VA: 0x1823036C0
	public Color GetColor(string name) { }

	// RVA: 0x23037A0 Offset: 0x2301DA0 VA: 0x1823037A0
	public Color GetColor(int nameID) { }

	// RVA: 0x23041D0 Offset: 0x23027D0 VA: 0x1823041D0
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x2303E60 Offset: 0x2302460 VA: 0x182303E60
	public Texture GetTexture(int nameID) { }

	// RVA: 0x2305F00 Offset: 0x2304500 VA: 0x182305F00
	public void SetTextureOffset(int nameID, Vector2 value) { }

	// RVA: 0x23060B0 Offset: 0x23046B0 VA: 0x1823060B0
	public void SetTextureScale(int nameID, Vector2 value) { }

	// RVA: 0x2303F20 Offset: 0x2302520 VA: 0x182303F20
	public Vector2 GetTextureOffset(int nameID) { }

	// RVA: 0x2304100 Offset: 0x2302700 VA: 0x182304100
	public Vector2 GetTextureScale(int nameID) { }

	// RVA: 0x23063A0 Offset: 0x23049A0 VA: 0x1823063A0
	private static void .cctor() { }

	// RVA: 0x2302FF0 Offset: 0x23015F0 VA: 0x182302FF0
	private static void CreateWithShader_Injected(Material self, IntPtr shader) { }

	// RVA: 0x2302ED0 Offset: 0x23014D0 VA: 0x182302ED0
	private static void CreateWithMaterial_Injected(Material self, IntPtr source) { }

	// RVA: 0x2303880 Offset: 0x2301E80 VA: 0x182303880
	private static IntPtr GetDefaultMaterial_Injected() { }

	// RVA: 0x2306C70 Offset: 0x2305270 VA: 0x182306C70
	private static IntPtr get_shader_Injected(IntPtr _unity_self) { }

	// RVA: 0x2307460 Offset: 0x2305A60 VA: 0x182307460
	private static void set_shader_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x2303930 Offset: 0x2301F30 VA: 0x182303930
	private static int GetFirstPropertyNameIdByAttribute_Injected(IntPtr _unity_self, ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x23042B0 Offset: 0x23028B0 VA: 0x1823042B0
	private static bool HasProperty_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x2306B90 Offset: 0x2305190 VA: 0x182306B90
	private static int get_renderQueue_Injected(IntPtr _unity_self) { }

	// RVA: 0x2307370 Offset: 0x2305970 VA: 0x182307370
	private static void set_renderQueue_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2303380 Offset: 0x2301980 VA: 0x182303380
	private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	// RVA: 0x2303150 Offset: 0x2301750 VA: 0x182303150
	private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	// RVA: 0x23068B0 Offset: 0x2304EB0 VA: 0x1823068B0
	private static MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(IntPtr _unity_self) { }

	// RVA: 0x2306F00 Offset: 0x2305500 VA: 0x182306F00
	private static void set_globalIlluminationFlags_Injected(IntPtr _unity_self, MaterialGlobalIlluminationFlags value) { }

	// RVA: 0x2305A60 Offset: 0x2304060 VA: 0x182305A60
	private static void SetShaderPassEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName, bool enabled) { }

	// RVA: 0x2305540 Offset: 0x2303B40 VA: 0x182305540
	private static void SetOverrideTag_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag, ref ManagedSpanWrapper val) { }

	// RVA: 0x2305870 Offset: 0x2303E70 VA: 0x182305870
	private static bool SetPass_Injected(IntPtr _unity_self, int pass) { }

	// RVA: 0x2302DA0 Offset: 0x23013A0 VA: 0x182302DA0
	private static void CopyPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	// RVA: 0x2303D40 Offset: 0x2302340 VA: 0x182303D40
	private static string[] GetShaderKeywords_Injected(IntPtr _unity_self) { }

	// RVA: 0x2305960 Offset: 0x2303F60 VA: 0x182305960
	private static void SetShaderKeywords_Injected(IntPtr _unity_self, string[] names) { }

	// RVA: 0x2302CC0 Offset: 0x23012C0 VA: 0x182302CC0
	private static int ComputeCRC_Injected(IntPtr _unity_self) { }

	// RVA: 0x23051A0 Offset: 0x23037A0 VA: 0x1823051A0
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	// RVA: 0x2304AC0 Offset: 0x23030C0 VA: 0x182304AC0
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	// RVA: 0x2305350 Offset: 0x2303950 VA: 0x182305350
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	// RVA: 0x2305CB0 Offset: 0x23042B0 VA: 0x182305CB0
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	// RVA: 0x2304460 Offset: 0x2302A60 VA: 0x182304460
	private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	// RVA: 0x2303A20 Offset: 0x2302020 VA: 0x182303A20
	private static float GetFloatImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x23035B0 Offset: 0x2301BB0 VA: 0x1823035B0
	private static void GetColorImpl_Injected(IntPtr _unity_self, int name, out Color ret) { }

	// RVA: 0x2303E20 Offset: 0x2302420 VA: 0x182303E20
	private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x2304D60 Offset: 0x2303360 VA: 0x182304D60
	private static void SetFloatArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	// RVA: 0x2304680 Offset: 0x2302C80 VA: 0x182304680
	private static void SetColorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	// RVA: 0x2303FF0 Offset: 0x23025F0 VA: 0x182303FF0
	private static void GetTextureScaleAndOffsetImpl_Injected(IntPtr _unity_self, int name, out Vector4 ret) { }

	// RVA: 0x2305E00 Offset: 0x2304400 VA: 0x182305E00
	private static void SetTextureOffsetImpl_Injected(IntPtr _unity_self, int name, in Vector2 offset) { }

	// RVA: 0x2305FB0 Offset: 0x23045B0 VA: 0x182305FB0
	private static void SetTextureScaleImpl_Injected(IntPtr _unity_self, int name, in Vector2 scale) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Projector.h")]
public sealed class Projector : Behaviour // TypeDefIndex: 9582
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/SharedLightData.h")]
public struct LightBakingOutput // TypeDefIndex: 9583
{
	// Fields
	public int probeOcclusionLightIndex; // 0x0
	public int occlusionMaskChannel; // 0x4
	[NativeName("lightmapBakeMode.lightmapBakeType")]
	public LightmapBakeType lightmapBakeType; // 0x8
	[NativeName("lightmapBakeMode.mixedLightingMode")]
	public MixedLightingMode mixedLightingMode; // 0xC
	public bool isBaked; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Camera/Light.h")]
public sealed class Light : Behaviour // TypeDefIndex: 9584
{
	// Properties
	[NativeProperty("LightType")]
	public LightType type { get; }
	public float spotAngle { get; }
	public Color color { get; set; }
	public float colorTemperature { get; }
	public bool useColorTemperature { get; }
	public float intensity { get; set; }
	public float bounceIntensity { get; }
	public float range { get; }
	public float dilatedRange { get; }
	public LightBakingOutput bakingOutput { get; }
	public LightShadows shadows { get; }
	public float cookieSize { get; }
	public Texture cookie { get; }

	// Methods

	// RVA: 0x2300A00 Offset: 0x22FF000 VA: 0x182300A00
	public LightType get_type() { }

	// RVA: 0x2300940 Offset: 0x22FEF40 VA: 0x182300940
	public float get_spotAngle() { }

	// RVA: 0x23003D0 Offset: 0x22FE9D0 VA: 0x1823003D0
	public Color get_color() { }

	// RVA: 0x2300B90 Offset: 0x22FF190 VA: 0x182300B90
	public void set_color(Color value) { }

	// RVA: 0x2300300 Offset: 0x22FE900 VA: 0x182300300
	public float get_colorTemperature() { }

	// RVA: 0x2300AC0 Offset: 0x22FF0C0 VA: 0x182300AC0
	public bool get_useColorTemperature() { }

	// RVA: 0x2300700 Offset: 0x22FED00 VA: 0x182300700
	public float get_intensity() { }

	// RVA: 0x2300C70 Offset: 0x22FF270 VA: 0x182300C70
	public void set_intensity(float value) { }

	// RVA: 0x2300240 Offset: 0x22FE840 VA: 0x182300240
	public float get_bounceIntensity() { }

	// RVA: 0x23007C0 Offset: 0x22FEDC0 VA: 0x1823007C0
	public float get_range() { }

	// RVA: 0x2300640 Offset: 0x22FEC40 VA: 0x182300640
	public float get_dilatedRange() { }

	// RVA: 0x2300160 Offset: 0x22FE760 VA: 0x182300160
	public LightBakingOutput get_bakingOutput() { }

	[NativeMethod("GetShadowType")]
	// RVA: 0x2300880 Offset: 0x22FEE80 VA: 0x182300880
	public LightShadows get_shadows() { }

	// RVA: 0x23004A0 Offset: 0x22FEAA0 VA: 0x1823004A0
	public float get_cookieSize() { }

	// RVA: 0x2300560 Offset: 0x22FEB60 VA: 0x182300560
	public Texture get_cookie() { }

	// RVA: 0x23009C0 Offset: 0x22FEFC0 VA: 0x1823009C0
	private static LightType get_type_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300900 Offset: 0x22FEF00 VA: 0x182300900
	private static float get_spotAngle_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300380 Offset: 0x22FE980 VA: 0x182300380
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x2300B40 Offset: 0x22FF140 VA: 0x182300B40
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x23002C0 Offset: 0x22FE8C0 VA: 0x1823002C0
	private static float get_colorTemperature_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300A80 Offset: 0x22FF080 VA: 0x182300A80
	private static bool get_useColorTemperature_Injected(IntPtr _unity_self) { }

	// RVA: 0x23006C0 Offset: 0x22FECC0 VA: 0x1823006C0
	private static float get_intensity_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300C20 Offset: 0x22FF220 VA: 0x182300C20
	private static void set_intensity_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2300200 Offset: 0x22FE800 VA: 0x182300200
	private static float get_bounceIntensity_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300780 Offset: 0x22FED80 VA: 0x182300780
	private static float get_range_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300600 Offset: 0x22FEC00 VA: 0x182300600
	private static float get_dilatedRange_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300110 Offset: 0x22FE710 VA: 0x182300110
	private static void get_bakingOutput_Injected(IntPtr _unity_self, out LightBakingOutput ret) { }

	// RVA: 0x2300840 Offset: 0x22FEE40 VA: 0x182300840
	private static LightShadows get_shadows_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300460 Offset: 0x22FEA60 VA: 0x182300460
	private static float get_cookieSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x2300520 Offset: 0x22FEB20 VA: 0x182300520
	private static IntPtr get_cookie_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
public sealed class MeshFilter : Component // TypeDefIndex: 9585
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public Mesh mesh { set; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void DontStripMeshFilter() { }

	// RVA: 0x2307CB0 Offset: 0x23062B0 VA: 0x182307CB0
	public Mesh get_sharedMesh() { }

	// RVA: 0x2307EB0 Offset: 0x23064B0 VA: 0x182307EB0
	public void set_sharedMesh(Mesh value) { }

	[NativeName("SetInstantiatedMesh")]
	// RVA: 0x2307DA0 Offset: 0x23063A0 VA: 0x182307DA0
	public void set_mesh(Mesh value) { }

	// RVA: 0x2307C70 Offset: 0x2306270 VA: 0x182307C70
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x2307E60 Offset: 0x2306460 VA: 0x182307E60
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x2307D50 Offset: 0x2306350 VA: 0x182307D50
	private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value) { }
}

// Namespace: UnityEngine
public enum RenderingPath // TypeDefIndex: 9586
{
	// Fields
	public int value__; // 0x0
	public const RenderingPath UsePlayerSettings = -1;
	public const RenderingPath VertexLit = 0;
	public const RenderingPath Forward = 1;
	[Obsolete("DeferredLighting has been removed. Use DeferredShading, Forward or HDRP/URP instead.", False)]
	public const RenderingPath DeferredLighting = 2;
	public const RenderingPath DeferredShading = 3;
}

// Namespace: UnityEngine
public enum StereoTargetEyeMask // TypeDefIndex: 9587
{
	// Fields
	public int value__; // 0x0
	public const StereoTargetEyeMask None = 0;
	public const StereoTargetEyeMask Left = 1;
	public const StereoTargetEyeMask Right = 2;
	public const StereoTargetEyeMask Both = 3;
}

// Namespace: UnityEngine
[Flags]
public enum CameraType // TypeDefIndex: 9588
{
	// Fields
	public int value__; // 0x0
	public const CameraType Game = 1;
	public const CameraType SceneView = 2;
	public const CameraType Preview = 4;
	public const CameraType VR = 8;
	public const CameraType Reflection = 16;
}

// Namespace: UnityEngine
[Flags]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
public enum ComputeBufferType // TypeDefIndex: 9589
{
	// Fields
	public int value__; // 0x0
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	[Obsolete("Enum member DrawIndirect has been deprecated. Use IndirectArguments instead (UnityUpgradable) -> IndirectArguments", False)]
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	[Obsolete("Enum member GPUMemory has been deprecated. All compute buffers now follow the behavior previously defined by this member.", False)]
	public const ComputeBufferType GPUMemory = 512;
}

// Namespace: UnityEngine
public enum LightType // TypeDefIndex: 9590
{
	// Fields
	public int value__; // 0x0
	public const LightType Spot = 0;
	public const LightType Directional = 1;
	public const LightType Point = 2;
	[Obsolete("Enum member LightType.Area has been deprecated. Use LightType.Rectangle instead (UnityUpgradable) -> Rectangle", True)]
	public const LightType Area = 3;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
	public const LightType Pyramid = 5;
	public const LightType Box = 6;
	public const LightType Tube = 7;
}

// Namespace: UnityEngine
public enum LightShadows // TypeDefIndex: 9591
{
	// Fields
	public int value__; // 0x0
	public const LightShadows None = 0;
	public const LightShadows Hard = 1;
	public const LightShadows Soft = 2;
}

// Namespace: UnityEngine
[Flags]
public enum LightmapBakeType // TypeDefIndex: 9592
{
	// Fields
	public int value__; // 0x0
	public const LightmapBakeType Realtime = 4;
	public const LightmapBakeType Baked = 2;
	public const LightmapBakeType Mixed = 1;
}

// Namespace: UnityEngine
public enum MixedLightingMode // TypeDefIndex: 9593
{
	// Fields
	public int value__; // 0x0
	public const MixedLightingMode IndirectOnly = 0;
	public const MixedLightingMode Shadowmask = 2;
	public const MixedLightingMode Subtractive = 1;
}

// Namespace: UnityEngine
public enum ShadowQuality // TypeDefIndex: 9594
{
	// Fields
	public int value__; // 0x0
	public const ShadowQuality Disable = 0;
	public const ShadowQuality HardOnly = 1;
	public const ShadowQuality All = 2;
}

// Namespace: UnityEngine
public enum ShadowResolution // TypeDefIndex: 9595
{
	// Fields
	public int value__; // 0x0
	public const ShadowResolution Low = 0;
	public const ShadowResolution Medium = 1;
	public const ShadowResolution High = 2;
	public const ShadowResolution VeryHigh = 3;
}

// Namespace: UnityEngine
public enum CameraClearFlags // TypeDefIndex: 9596
{
	// Fields
	public int value__; // 0x0
	public const CameraClearFlags Skybox = 1;
	public const CameraClearFlags Color = 2;
	public const CameraClearFlags SolidColor = 2;
	public const CameraClearFlags Depth = 3;
	public const CameraClearFlags Nothing = 4;
}

// Namespace: UnityEngine
[Flags]
public enum DepthTextureMode // TypeDefIndex: 9597
{
	// Fields
	public int value__; // 0x0
	public const DepthTextureMode None = 0;
	public const DepthTextureMode Depth = 1;
	public const DepthTextureMode DepthNormals = 2;
	public const DepthTextureMode MotionVectors = 4;
}

// Namespace: UnityEngine
public enum MeshTopology // TypeDefIndex: 9598
{
	// Fields
	public int value__; // 0x0
	public const MeshTopology Triangles = 0;
	public const MeshTopology Quads = 2;
	public const MeshTopology Lines = 3;
	public const MeshTopology LineStrip = 4;
	public const MeshTopology Points = 5;
}

// Namespace: UnityEngine
public enum ColorSpace // TypeDefIndex: 9599
{
	// Fields
	public int value__; // 0x0
	public const ColorSpace Uninitialized = -1;
	public const ColorSpace Gamma = 0;
	public const ColorSpace Linear = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[UsedByNativeCode]
public enum ColorGamut // TypeDefIndex: 9600
{
	// Fields
	public int value__; // 0x0
	public const ColorGamut sRGB = 0;
	public const ColorGamut Rec709 = 1;
	public const ColorGamut Rec2020 = 2;
	public const ColorGamut DisplayP3 = 3;
	public const ColorGamut HDR10 = 4;
	public const ColorGamut DolbyHDR = 5;
	public const ColorGamut P3D65G22 = 6;
}

// Namespace: UnityEngine
public enum FilterMode // TypeDefIndex: 9601
{
	// Fields
	public int value__; // 0x0
	public const FilterMode Point = 0;
	public const FilterMode Bilinear = 1;
	public const FilterMode Trilinear = 2;
}

// Namespace: UnityEngine
public enum TextureWrapMode // TypeDefIndex: 9602
{
	// Fields
	public int value__; // 0x0
	public const TextureWrapMode Repeat = 0;
	public const TextureWrapMode Clamp = 1;
	public const TextureWrapMode Mirror = 2;
	public const TextureWrapMode MirrorOnce = 3;
}

// Namespace: UnityEngine
public enum TextureFormat // TypeDefIndex: 9603
{
	// Fields
	public int value__; // 0x0
	public const TextureFormat Alpha8 = 1;
	public const TextureFormat ARGB4444 = 2;
	public const TextureFormat RGB24 = 3;
	public const TextureFormat RGBA32 = 4;
	public const TextureFormat ARGB32 = 5;
	public const TextureFormat RGB565 = 7;
	public const TextureFormat R16 = 9;
	public const TextureFormat DXT1 = 10;
	public const TextureFormat DXT5 = 12;
	public const TextureFormat RGBA4444 = 13;
	public const TextureFormat BGRA32 = 14;
	public const TextureFormat RHalf = 15;
	public const TextureFormat RGHalf = 16;
	public const TextureFormat RGBAHalf = 17;
	public const TextureFormat RFloat = 18;
	public const TextureFormat RGFloat = 19;
	public const TextureFormat RGBAFloat = 20;
	public const TextureFormat YUY2 = 21;
	public const TextureFormat RGB9e5Float = 22;
	public const TextureFormat BC4 = 26;
	public const TextureFormat BC5 = 27;
	public const TextureFormat BC6H = 24;
	public const TextureFormat BC7 = 25;
	public const TextureFormat DXT1Crunched = 28;
	public const TextureFormat DXT5Crunched = 29;
	public const TextureFormat PVRTC_RGB2 = 30;
	public const TextureFormat PVRTC_RGBA2 = 31;
	public const TextureFormat PVRTC_RGB4 = 32;
	public const TextureFormat PVRTC_RGBA4 = 33;
	public const TextureFormat ETC_RGB4 = 34;
	public const TextureFormat EAC_R = 41;
	public const TextureFormat EAC_R_SIGNED = 42;
	public const TextureFormat EAC_RG = 43;
	public const TextureFormat EAC_RG_SIGNED = 44;
	public const TextureFormat ETC2_RGB = 45;
	public const TextureFormat ETC2_RGBA1 = 46;
	public const TextureFormat ETC2_RGBA8 = 47;
	public const TextureFormat ASTC_4x4 = 48;
	public const TextureFormat ASTC_5x5 = 49;
	public const TextureFormat ASTC_6x6 = 50;
	public const TextureFormat ASTC_8x8 = 51;
	public const TextureFormat ASTC_10x10 = 52;
	public const TextureFormat ASTC_12x12 = 53;
	public const TextureFormat RG16 = 62;
	public const TextureFormat R8 = 63;
	public const TextureFormat ETC_RGB4Crunched = 64;
	public const TextureFormat ETC2_RGBA8Crunched = 65;
	public const TextureFormat ASTC_HDR_4x4 = 66;
	public const TextureFormat ASTC_HDR_5x5 = 67;
	public const TextureFormat ASTC_HDR_6x6 = 68;
	public const TextureFormat ASTC_HDR_8x8 = 69;
	public const TextureFormat ASTC_HDR_10x10 = 70;
	public const TextureFormat ASTC_HDR_12x12 = 71;
	public const TextureFormat RG32 = 72;
	public const TextureFormat RGB48 = 73;
	public const TextureFormat RGBA64 = 74;
	public const TextureFormat R8_SIGNED = 75;
	public const TextureFormat RG16_SIGNED = 76;
	public const TextureFormat RGB24_SIGNED = 77;
	public const TextureFormat RGBA32_SIGNED = 78;
	public const TextureFormat R16_SIGNED = 79;
	public const TextureFormat RG32_SIGNED = 80;
	public const TextureFormat RGB48_SIGNED = 81;
	public const TextureFormat RGBA64_SIGNED = 82;
}

// Namespace: UnityEngine
internal enum TextureColorSpace // TypeDefIndex: 9604
{
	// Fields
	public int value__; // 0x0
	public const TextureColorSpace Linear = 0;
	public const TextureColorSpace sRGB = 1;
}

// Namespace: UnityEngine
public enum CubemapFace // TypeDefIndex: 9605
{
	// Fields
	public int value__; // 0x0
	public const CubemapFace Unknown = -1;
	public const CubemapFace PositiveX = 0;
	public const CubemapFace NegativeX = 1;
	public const CubemapFace PositiveY = 2;
	public const CubemapFace NegativeY = 3;
	public const CubemapFace PositiveZ = 4;
	public const CubemapFace NegativeZ = 5;
}

// Namespace: UnityEngine
public enum RenderTextureFormat // TypeDefIndex: 9606
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureFormat ARGB32 = 0;
	public const RenderTextureFormat Depth = 1;
	public const RenderTextureFormat ARGBHalf = 2;
	public const RenderTextureFormat Shadowmap = 3;
	public const RenderTextureFormat RGB565 = 4;
	public const RenderTextureFormat ARGB4444 = 5;
	public const RenderTextureFormat ARGB1555 = 6;
	public const RenderTextureFormat Default = 7;
	public const RenderTextureFormat ARGB2101010 = 8;
	public const RenderTextureFormat DefaultHDR = 9;
	public const RenderTextureFormat ARGB64 = 10;
	public const RenderTextureFormat ARGBFloat = 11;
	public const RenderTextureFormat RGFloat = 12;
	public const RenderTextureFormat RGHalf = 13;
	public const RenderTextureFormat RFloat = 14;
	public const RenderTextureFormat RHalf = 15;
	public const RenderTextureFormat R8 = 16;
	public const RenderTextureFormat ARGBInt = 17;
	public const RenderTextureFormat RGInt = 18;
	public const RenderTextureFormat RInt = 19;
	public const RenderTextureFormat BGRA32 = 20;
	public const RenderTextureFormat RGB111110Float = 22;
	public const RenderTextureFormat RG32 = 23;
	public const RenderTextureFormat RGBAUShort = 24;
	public const RenderTextureFormat RG16 = 25;
	public const RenderTextureFormat BGRA10101010_XR = 26;
	public const RenderTextureFormat BGR101010_XR = 27;
	public const RenderTextureFormat R16 = 28;
}

// Namespace: UnityEngine
public enum VRTextureUsage // TypeDefIndex: 9607
{
	// Fields
	public int value__; // 0x0
	public const VRTextureUsage None = 0;
	public const VRTextureUsage OneEye = 1;
	public const VRTextureUsage TwoEyes = 2;
	public const VRTextureUsage DeviceSpecific = 3;
}

// Namespace: UnityEngine
[Flags]
public enum RenderTextureCreationFlags // TypeDefIndex: 9608
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureCreationFlags MipMap = 1;
	public const RenderTextureCreationFlags AutoGenerateMips = 2;
	public const RenderTextureCreationFlags SRGB = 4;
	public const RenderTextureCreationFlags EyeTexture = 8;
	public const RenderTextureCreationFlags EnableRandomWrite = 16;
	public const RenderTextureCreationFlags CreatedFromScript = 32;
	public const RenderTextureCreationFlags AllowVerticalFlip = 128;
	public const RenderTextureCreationFlags NoResolvedColorSurface = 256;
	public const RenderTextureCreationFlags DynamicallyScalable = 1024;
	public const RenderTextureCreationFlags BindMS = 2048;
	public const RenderTextureCreationFlags DynamicallyScalableExplicit = 65536;
}

// Namespace: UnityEngine
public enum RenderTextureReadWrite // TypeDefIndex: 9609
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureReadWrite Default = 0;
	public const RenderTextureReadWrite Linear = 1;
	public const RenderTextureReadWrite sRGB = 2;
}

// Namespace: UnityEngine
[Flags]
public enum RenderTextureMemoryless // TypeDefIndex: 9610
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureMemoryless None = 0;
	public const RenderTextureMemoryless Color = 1;
	public const RenderTextureMemoryless Depth = 2;
	public const RenderTextureMemoryless MSAA = 4;
}

// Namespace: UnityEngine
[Flags]
public enum LightmapsMode // TypeDefIndex: 9611
{
	// Fields
	public int value__; // 0x0
	public const LightmapsMode NonDirectional = 0;
	public const LightmapsMode CombinedDirectional = 1;
}

// Namespace: UnityEngine
[Flags]
public enum MaterialGlobalIlluminationFlags // TypeDefIndex: 9612
{
	// Fields
	public int value__; // 0x0
	public const MaterialGlobalIlluminationFlags None = 0;
	public const MaterialGlobalIlluminationFlags RealtimeEmissive = 1;
	public const MaterialGlobalIlluminationFlags BakedEmissive = 2;
	public const MaterialGlobalIlluminationFlags EmissiveIsBlack = 4;
	public const MaterialGlobalIlluminationFlags AnyEmissive = 3;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
public sealed class LightProbeProxyVolume : Behaviour // TypeDefIndex: 9613
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 9614
{
	// Properties
	[NativeProperty("Mesh")]
	public Mesh sharedMesh { get; set; }

	// Methods

	// RVA: 0x2313A70 Offset: 0x2312070 VA: 0x182313A70
	public Mesh get_sharedMesh() { }

	// RVA: 0x2313B60 Offset: 0x2312160 VA: 0x182313B60
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x2313A30 Offset: 0x2312030 VA: 0x182313A30
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x2313B10 Offset: 0x2312110 VA: 0x182313B10
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
public class MeshRenderer : Renderer // TypeDefIndex: 9615
{
	// Properties
	public Mesh additionalVertexStreams { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void DontStripMeshRenderer() { }

	// RVA: 0x2307FB0 Offset: 0x23065B0 VA: 0x182307FB0
	public Mesh get_additionalVertexStreams() { }

	// RVA: 0x2307F70 Offset: 0x2306570 VA: 0x182307F70
	private static IntPtr get_additionalVertexStreams_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
public sealed class Mesh : Object // TypeDefIndex: 9618
{
	// Properties
	public IndexFormat indexFormat { set; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Vector2[] uv4 { set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { get; set; }
	public int[] triangles { get; set; }

	// Methods

	[FreeFunction("MeshScripting::CreateMesh")]
	// RVA: 0x2309E00 Offset: 0x2308400 VA: 0x182309E00
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCode]
	// RVA: 0x230CD00 Offset: 0x230B300 VA: 0x18230CD00
	public void .ctor() { }

	[FreeFunction("MeshScripting::MeshFromInstanceId")]
	// RVA: 0x2308A70 Offset: 0x2307070 VA: 0x182308A70
	internal static Mesh FromInstanceID(int id) { }

	// RVA: 0x230D530 Offset: 0x230BB30 VA: 0x18230D530
	public void set_indexFormat(IndexFormat value) { }

	[FreeFunction(Name = "MeshScripting::GetIndexStart", HasExplicitThis = True)]
	// RVA: 0x2309290 Offset: 0x2307890 VA: 0x182309290
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	// RVA: 0x2309080 Offset: 0x2307680 VA: 0x182309080
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetBaseVertex", HasExplicitThis = True)]
	// RVA: 0x2308D30 Offset: 0x2307330 VA: 0x182308D30
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	// RVA: 0x23099D0 Offset: 0x2307FD0 VA: 0x1823099D0
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	// RVA: 0x23094D0 Offset: 0x2307AD0 VA: 0x1823094D0
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x230AD80 Offset: 0x2309380 VA: 0x18230AD80
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	// RVA: 0x230A230 Offset: 0x2308830 VA: 0x18230A230
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	// RVA: 0x2309D70 Offset: 0x2308370 VA: 0x182309D70
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	// RVA: 0x230AAA0 Offset: 0x23090A0 VA: 0x18230AAA0
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x2308B30 Offset: 0x2307130 VA: 0x182308B30
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x2308C40 Offset: 0x2307240 VA: 0x182308C40
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[NativeMethod("CanAccessFromScript")]
	// RVA: 0x230CEA0 Offset: 0x230B4A0 VA: 0x18230CEA0
	internal bool get_canAccess() { }

	[NativeMethod("GetVertexCount")]
	// RVA: 0x230D280 Offset: 0x230B880 VA: 0x18230D280
	public int get_vertexCount() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	// RVA: 0x230D030 Offset: 0x230B630 VA: 0x18230D030
	public int get_subMeshCount() { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	// RVA: 0x230D660 Offset: 0x230BC60 VA: 0x18230D660
	public void set_subMeshCount(int value) { }

	// RVA: 0x230CDC0 Offset: 0x230B3C0 VA: 0x18230CDC0
	public Bounds get_bounds() { }

	// RVA: 0x230D390 Offset: 0x230B990 VA: 0x18230D390
	public void set_bounds(Bounds value) { }

	[NativeMethod("Clear")]
	// RVA: 0x2308670 Offset: 0x2306C70 VA: 0x182308670
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethod("RecalculateBounds")]
	// RVA: 0x230A380 Offset: 0x2308980 VA: 0x18230A380
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateNormals")]
	// RVA: 0x230A700 Offset: 0x2308D00 VA: 0x18230A700
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("MarkDynamic")]
	// RVA: 0x2309E80 Offset: 0x2308480 VA: 0x182309E80
	private void MarkDynamicImpl() { }

	[NativeMethod("UploadMeshData")]
	// RVA: 0x230CB80 Offset: 0x230B180 VA: 0x18230CB80
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	// RVA: 0x2309770 Offset: 0x2307D70 VA: 0x182309770
	private MeshTopology GetTopologyImpl(int submesh) { }

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	// RVA: 0x2308800 Offset: 0x2306E00 VA: 0x182308800
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[NativeMethod("Optimize")]
	// RVA: 0x230A020 Offset: 0x2308620 VA: 0x18230A020
	private void OptimizeImpl() { }

	// RVA: 0x2309C30 Offset: 0x2308230 VA: 0x182309C30
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x2308980 Offset: 0x2306F80 VA: 0x182308980
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734270 Offset: 0x732870 VA: 0x180734270
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734370 Offset: 0x732970 VA: 0x180734370
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|
	|-RVA: 0x734490 Offset: 0x732A90 VA: 0x180734490
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x230B5C0 Offset: 0x2309BC0 VA: 0x18230B5C0
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734B30 Offset: 0x733130 VA: 0x180734B30
	|-Mesh.SetArrayForChannel<Color32>
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734BC0 Offset: 0x7331C0 VA: 0x180734BC0
	|-Mesh.SetArrayForChannel<Color>
	|-Mesh.SetArrayForChannel<Vector2>
	|-Mesh.SetArrayForChannel<Vector3>
	|-Mesh.SetArrayForChannel<Vector4>
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734C50 Offset: 0x733250 VA: 0x180734C50
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0x734D60 Offset: 0x733360 VA: 0x180734D60
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734F20 Offset: 0x733520 VA: 0x180734F20
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0x734E40 Offset: 0x733440 VA: 0x180734E40
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734810 Offset: 0x732E10 VA: 0x180734810
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0x734690 Offset: 0x732C90 VA: 0x180734690
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7344F0 Offset: 0x732AF0 VA: 0x1807344F0
	|-Mesh.GetListForChannel<Color32>
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0x734720 Offset: 0x732D20 VA: 0x180734720
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x230D300 Offset: 0x230B900 VA: 0x18230D300
	public Vector3[] get_vertices() { }

	// RVA: 0x230D970 Offset: 0x230BF70 VA: 0x18230D970
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x230CFB0 Offset: 0x230B5B0 VA: 0x18230CFB0
	public Vector3[] get_normals() { }

	// RVA: 0x230D5C0 Offset: 0x230BBC0 VA: 0x18230D5C0
	public void set_normals(Vector3[] value) { }

	// RVA: 0x230D0B0 Offset: 0x230B6B0 VA: 0x18230D0B0
	public Vector4[] get_tangents() { }

	// RVA: 0x230D6F0 Offset: 0x230BCF0 VA: 0x18230D6F0
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x230D200 Offset: 0x230B800 VA: 0x18230D200
	public Vector2[] get_uv() { }

	// RVA: 0x230D910 Offset: 0x230BF10 VA: 0x18230D910
	public void set_uv(Vector2[] value) { }

	// RVA: 0x230D1C0 Offset: 0x230B7C0 VA: 0x18230D1C0
	public Vector2[] get_uv2() { }

	// RVA: 0x230D850 Offset: 0x230BE50 VA: 0x18230D850
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x230D8B0 Offset: 0x230BEB0 VA: 0x18230D8B0
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x230CF70 Offset: 0x230B570 VA: 0x18230CF70
	public Color[] get_colors() { }

	// RVA: 0x230D490 Offset: 0x230BA90 VA: 0x18230D490
	public void set_colors(Color[] value) { }

	// RVA: 0x230CF20 Offset: 0x230B520 VA: 0x18230CF20
	public Color32[] get_colors32() { }

	// RVA: 0x230D420 Offset: 0x230BA20 VA: 0x18230D420
	public void set_colors32(Color32[] value) { }

	// RVA: 0x230CA90 Offset: 0x230B090 VA: 0x18230CA90
	public void SetVertices(List<Vector3> inVertices) { }

	[ExcludeFromDocs]
	// RVA: 0x230CA10 Offset: 0x230B010 VA: 0x18230CA10
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x230C990 Offset: 0x230AF90 VA: 0x18230C990
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x230B520 Offset: 0x2309B20 VA: 0x18230B520
	public void SetNormals(List<Vector3> inNormals) { }

	[ExcludeFromDocs]
	// RVA: 0x230B4A0 Offset: 0x2309AA0 VA: 0x18230B4A0
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x230B420 Offset: 0x2309A20 VA: 0x18230B420
	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x230B9A0 Offset: 0x2309FA0 VA: 0x18230B9A0
	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	// RVA: 0x230BAC0 Offset: 0x230A0C0 VA: 0x18230BAC0
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x230BA40 Offset: 0x230A040 VA: 0x18230BA40
	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2308F00 Offset: 0x2307500 VA: 0x182308F00
	public void GetColors(List<Color32> colors) { }

	// RVA: 0x230ABE0 Offset: 0x23091E0 VA: 0x18230ABE0
	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x230AC80 Offset: 0x2309280 VA: 0x18230AC80
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: 0x230AB50 Offset: 0x2309150 VA: 0x18230AB50
	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x735120 Offset: 0x733720 VA: 0x180735120
	|-Mesh.SetUvsImpl<Vector3>
	|-Mesh.SetUvsImpl<Vector4>
	|
	|-RVA: 0x735030 Offset: 0x733630 VA: 0x180735030
	|-Mesh.SetUvsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x230C7D0 Offset: 0x230ADD0 VA: 0x18230C7D0
	public void SetUVs(int channel, List<Vector3> uvs) { }

	// RVA: 0x230C520 Offset: 0x230AB20 VA: 0x18230C520
	public void SetUVs(int channel, List<Vector4> uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x230C2F0 Offset: 0x230A8F0 VA: 0x18230C2F0
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	// RVA: 0x230C260 Offset: 0x230A860 VA: 0x18230C260
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x230C490 Offset: 0x230AA90 VA: 0x18230C490
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: 0x230C1D0 Offset: 0x230A7D0 VA: 0x18230C1D0
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x230C880 Offset: 0x230AE80 VA: 0x18230C880
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	// RVA: 0x230C6D0 Offset: 0x230ACD0 VA: 0x18230C6D0
	public void SetUVs(int channel, Vector4[] uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x230C5D0 Offset: 0x230ABD0 VA: 0x18230C5D0
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	// RVA: 0x230C380 Offset: 0x230A980 VA: 0x18230C380
	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7349D0 Offset: 0x732FD0 VA: 0x1807349D0
	|-Mesh.GetUVsImpl<Vector4>
	|
	|-RVA: 0x7348A0 Offset: 0x732EA0 VA: 0x1807348A0
	|-Mesh.GetUVsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2309CC0 Offset: 0x23082C0 VA: 0x182309CC0
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x2308050 Offset: 0x2306650 VA: 0x182308050
	public static Mesh.MeshDataArray AllocateWritableMeshData(int meshCount) { }

	// RVA: 0x2308090 Offset: 0x2306690 VA: 0x182308090
	public static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, Mesh mesh, MeshUpdateFlags flags = 0) { }

	// RVA: 0x230A2C0 Offset: 0x23088C0 VA: 0x18230A2C0
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x2308220 Offset: 0x2306820 VA: 0x182308220
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x2308210 Offset: 0x2306810 VA: 0x182308210
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x2308200 Offset: 0x2306800 VA: 0x182308200
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x230D0F0 Offset: 0x230B6F0 VA: 0x18230D0F0
	public int[] get_triangles() { }

	// RVA: 0x230D750 Offset: 0x230BD50 VA: 0x18230D750
	public void set_triangles(int[] value) { }

	// RVA: 0x2309B20 Offset: 0x2308120 VA: 0x182309B20
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x2309BA0 Offset: 0x23081A0 VA: 0x182309BA0
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x2309620 Offset: 0x2307C20 VA: 0x182309620
	public int[] GetIndices(int submesh) { }

	// RVA: 0x23096A0 Offset: 0x2307CA0 VA: 0x1823096A0
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x2309320 Offset: 0x2307920 VA: 0x182309320
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x2309110 Offset: 0x2307710 VA: 0x182309110
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x2308DC0 Offset: 0x23073C0 VA: 0x182308DC0
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x23083D0 Offset: 0x23069D0 VA: 0x1823083D0
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x230BB40 Offset: 0x230A140 VA: 0x18230BB40
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x230C0A0 Offset: 0x230A6A0 VA: 0x18230C0A0
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x230BD70 Offset: 0x230A370 VA: 0x18230BD70
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x230C130 Offset: 0x230A730 VA: 0x18230C130
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x230BF60 Offset: 0x230A560 VA: 0x18230BF60
	public void SetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x230BE20 Offset: 0x230A420 VA: 0x18230BE20
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x230BC50 Offset: 0x230A250 VA: 0x18230BC50
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x230AF60 Offset: 0x2309560 VA: 0x18230AF60
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x230B3F0 Offset: 0x23099F0 VA: 0x18230B3F0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x230B2D0 Offset: 0x23098D0 VA: 0x18230B2D0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x230AE40 Offset: 0x2309440 VA: 0x18230AE40
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x230AF80 Offset: 0x2309580 VA: 0x18230AF80
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x230B140 Offset: 0x2309740 VA: 0x18230B140
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2308670 Offset: 0x2306C70 VA: 0x182308670
	public void Clear(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	// RVA: 0x2308700 Offset: 0x2306D00 VA: 0x182308700
	public void Clear() { }

	[ExcludeFromDocs]
	// RVA: 0x230A410 Offset: 0x2308A10 VA: 0x18230A410
	public void RecalculateBounds() { }

	[ExcludeFromDocs]
	// RVA: 0x230A790 Offset: 0x2308D90 VA: 0x18230A790
	public void RecalculateNormals() { }

	// RVA: 0x230A560 Offset: 0x2308B60 VA: 0x18230A560
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x230A8E0 Offset: 0x2308EE0 VA: 0x18230A8E0
	public void RecalculateNormals(MeshUpdateFlags flags) { }

	// RVA: 0x2309F00 Offset: 0x2308500 VA: 0x182309F00
	public void MarkDynamic() { }

	// RVA: 0x230CC10 Offset: 0x230B210 VA: 0x18230CC10
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x230A0A0 Offset: 0x23086A0 VA: 0x18230A0A0
	public void Optimize() { }

	// RVA: 0x2309800 Offset: 0x2307E00 VA: 0x182309800
	public MeshTopology GetTopology(int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x2308940 Offset: 0x2306F40 VA: 0x182308940
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[ExcludeFromDocs]
	// RVA: 0x2308960 Offset: 0x2306F60 VA: 0x182308960
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	// RVA: 0x2308A30 Offset: 0x2307030 VA: 0x182308A30
	private static IntPtr FromInstanceID_Injected(int id) { }

	// RVA: 0x230D4F0 Offset: 0x230BAF0 VA: 0x18230D4F0
	private static void set_indexFormat_Injected(IntPtr _unity_self, IndexFormat value) { }

	// RVA: 0x2309250 Offset: 0x2307850 VA: 0x182309250
	private static uint GetIndexStartImpl_Injected(IntPtr _unity_self, int submesh) { }

	// RVA: 0x2309040 Offset: 0x2307640 VA: 0x182309040
	private static uint GetIndexCountImpl_Injected(IntPtr _unity_self, int submesh) { }

	// RVA: 0x2308CF0 Offset: 0x23072F0 VA: 0x182308CF0
	private static uint GetBaseVertexImpl_Injected(IntPtr _unity_self, int submesh) { }

	// RVA: 0x2309960 Offset: 0x2307F60 VA: 0x182309960
	private static void GetTrianglesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, out BlittableArrayWrapper ret) { }

	// RVA: 0x2309460 Offset: 0x2307A60 VA: 0x182309460
	private static void GetIndicesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, out BlittableArrayWrapper ret) { }

	// RVA: 0x230AD10 Offset: 0x2309310 VA: 0x18230AD10
	private static void SetIndicesImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	// RVA: 0x230A1F0 Offset: 0x23087F0 VA: 0x18230A1F0
	private static void PrintErrorCantAccessChannel_Injected(IntPtr _unity_self, VertexAttribute ch) { }

	// RVA: 0x2309D30 Offset: 0x2308330 VA: 0x182309D30
	private static bool HasVertexAttribute_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	// RVA: 0x230AA40 Offset: 0x2309040 VA: 0x18230AA40
	private static void SetArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x2308AD0 Offset: 0x23070D0 VA: 0x182308AD0
	private static Array GetAllocArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: 0x2308BE0 Offset: 0x23071E0 VA: 0x182308BE0
	private static void GetArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	// RVA: 0x230CE60 Offset: 0x230B460 VA: 0x18230CE60
	private static bool get_canAccess_Injected(IntPtr _unity_self) { }

	// RVA: 0x230D240 Offset: 0x230B840 VA: 0x18230D240
	private static int get_vertexCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x230CFF0 Offset: 0x230B5F0 VA: 0x18230CFF0
	private static int get_subMeshCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x230D620 Offset: 0x230BC20 VA: 0x18230D620
	private static void set_subMeshCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x230CD70 Offset: 0x230B370 VA: 0x18230CD70
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	// RVA: 0x230D340 Offset: 0x230B940 VA: 0x18230D340
	private static void set_bounds_Injected(IntPtr _unity_self, in Bounds value) { }

	// RVA: 0x2308620 Offset: 0x2306C20 VA: 0x182308620
	private static void ClearImpl_Injected(IntPtr _unity_self, bool keepVertexLayout) { }

	// RVA: 0x230A340 Offset: 0x2308940 VA: 0x18230A340
	private static void RecalculateBoundsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	// RVA: 0x230A6C0 Offset: 0x2308CC0 VA: 0x18230A6C0
	private static void RecalculateNormalsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	// RVA: 0x2309E40 Offset: 0x2308440 VA: 0x182309E40
	private static void MarkDynamicImpl_Injected(IntPtr _unity_self) { }

	// RVA: 0x230CB30 Offset: 0x230B130 VA: 0x18230CB30
	private static void UploadMeshDataImpl_Injected(IntPtr _unity_self, bool markNoLongerReadable) { }

	// RVA: 0x2309730 Offset: 0x2307D30 VA: 0x182309730
	private static MeshTopology GetTopologyImpl_Injected(IntPtr _unity_self, int submesh) { }

	// RVA: 0x2308780 Offset: 0x2306D80 VA: 0x182308780
	private static void CombineMeshesImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	// RVA: 0x2309FE0 Offset: 0x23085E0 VA: 0x182309FE0
	private static void OptimizeImpl_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/StaticBatching.h")]
internal struct StaticBatchingHelper // TypeDefIndex: 9619
{
	// Methods

	[FreeFunction("StaticBatching::CombineMeshesForStaticBatching")]
	// RVA: 0x2325F70 Offset: 0x2324570 VA: 0x182325F70
	internal static void CombineMeshes(GameObject[] gos, GameObject staticBatchRoot) { }

	// RVA: 0x2325F20 Offset: 0x2324520 VA: 0x182325F20
	private static void CombineMeshes_Injected(GameObject[] gos, IntPtr staticBatchRoot) { }
}

// Namespace: UnityEngine
public struct CombineInstance // TypeDefIndex: 9620
{
	// Fields
	private int m_MeshInstanceID; // 0x0
	private int m_SubMeshIndex; // 0x4
	private Matrix4x4 m_Transform; // 0x8
	private Vector4 m_LightmapScaleOffset; // 0x48
	private Vector4 m_RealtimeLightmapScaleOffset; // 0x58

	// Properties
	public Mesh mesh { get; set; }
	public int subMeshIndex { set; }
	public Matrix4x4 transform { set; }

	// Methods

	// RVA: 0x2317620 Offset: 0x2315C20 VA: 0x182317620
	public Mesh get_mesh() { }

	// RVA: 0x2317630 Offset: 0x2315C30 VA: 0x182317630
	public void set_mesh(Mesh value) { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_subMeshIndex(int value) { }

	// RVA: 0x23176C0 Offset: 0x2315CC0 VA: 0x1823176C0
	public void set_transform(Matrix4x4 value) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
public class Texture : Object // TypeDefIndex: 9621
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Properties
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual TextureDimension dimension { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { get; set; }
	public FilterMode filterMode { get; set; }
	public int anisoLevel { set; }
	public Vector2 texelSize { get; }
	internal ColorSpace activeTextureColorSpace { get; }

	// Methods

	// RVA: 0x232BBF0 Offset: 0x232A1F0 VA: 0x18232BBF0
	protected void .ctor() { }

	[ThreadSafe]
	// RVA: 0x232B620 Offset: 0x2329C20 VA: 0x18232B620
	private int GetDataWidth() { }

	[ThreadSafe]
	// RVA: 0x232B540 Offset: 0x2329B40 VA: 0x18232B540
	private int GetDataHeight() { }

	[ThreadSafe]
	// RVA: 0x232B700 Offset: 0x2329D00 VA: 0x18232B700
	private TextureDimension GetDimension() { }

	// RVA: 0x232B620 Offset: 0x2329C20 VA: 0x18232B620 Slot: 4
	public virtual int get_width() { }

	// RVA: 0x232C2F0 Offset: 0x232A8F0 VA: 0x18232C2F0 Slot: 5
	public virtual void set_width(int value) { }

	// RVA: 0x232B540 Offset: 0x2329B40 VA: 0x18232B540 Slot: 6
	public virtual int get_height() { }

	// RVA: 0x232C2B0 Offset: 0x232A8B0 VA: 0x18232C2B0 Slot: 7
	public virtual void set_height(int value) { }

	// RVA: 0x232B700 Offset: 0x2329D00 VA: 0x18232B700 Slot: 8
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x232C180 Offset: 0x232A780 VA: 0x18232C180 Slot: 9
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x232BE10 Offset: 0x232A410 VA: 0x18232BE10 Slot: 10
	public virtual bool get_isReadable() { }

	[NativeName("GetWrapModeU")]
	// RVA: 0x232BFF0 Offset: 0x232A5F0 VA: 0x18232BFF0
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x232C370 Offset: 0x232A970 VA: 0x18232C370
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x232BD30 Offset: 0x232A330 VA: 0x18232BD30
	public FilterMode get_filterMode() { }

	// RVA: 0x232C200 Offset: 0x232A800 VA: 0x18232C200
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x232C0D0 Offset: 0x232A6D0 VA: 0x18232C0D0
	public void set_anisoLevel(int value) { }

	[NativeName("GetTexelSize")]
	// RVA: 0x232BF00 Offset: 0x232A500 VA: 0x18232BF00
	public Vector2 get_texelSize() { }

	[NativeMethod("GetActiveTextureColorSpace")]
	// RVA: 0x232B850 Offset: 0x2329E50 VA: 0x18232B850
	private int Internal_GetActiveTextureColorSpace() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
	// RVA: 0x232BC40 Offset: 0x232A240 VA: 0x18232BC40
	internal ColorSpace get_activeTextureColorSpace() { }

	// RVA: 0x232B800 Offset: 0x2329E00 VA: 0x18232B800
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x232B7A0 Offset: 0x2329DA0 VA: 0x18232B7A0
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x232B8F0 Offset: 0x2329EF0 VA: 0x18232B8F0
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x232BA90 Offset: 0x232A090 VA: 0x18232BA90
	internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	// RVA: 0x232B470 Offset: 0x2329A70 VA: 0x18232B470
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x232B410 Offset: 0x2329A10 VA: 0x18232B410
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	// RVA: 0x232BBB0 Offset: 0x232A1B0 VA: 0x18232BBB0
	private static void .cctor() { }

	// RVA: 0x232B5E0 Offset: 0x2329BE0 VA: 0x18232B5E0
	private static int GetDataWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x232B500 Offset: 0x2329B00 VA: 0x18232B500
	private static int GetDataHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x232B6C0 Offset: 0x2329CC0 VA: 0x18232B6C0
	private static TextureDimension GetDimension_Injected(IntPtr _unity_self) { }

	// RVA: 0x232BDD0 Offset: 0x232A3D0 VA: 0x18232BDD0
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x232BFB0 Offset: 0x232A5B0 VA: 0x18232BFB0
	private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x232C330 Offset: 0x232A930 VA: 0x18232C330
	private static void set_wrapMode_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	// RVA: 0x232BCF0 Offset: 0x232A2F0 VA: 0x18232BCF0
	private static FilterMode get_filterMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x232C1C0 Offset: 0x232A7C0 VA: 0x18232C1C0
	private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value) { }

	// RVA: 0x232C090 Offset: 0x232A690 VA: 0x18232C090
	private static void set_anisoLevel_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x232BEB0 Offset: 0x232A4B0 VA: 0x18232BEB0
	private static void get_texelSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x232B810 Offset: 0x2329E10 VA: 0x18232B810
	private static int Internal_GetActiveTextureColorSpace_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
public sealed class Texture2D : Texture // TypeDefIndex: 9622
{
	// Fields
	internal const int streamingMipmapsPriorityMin = -128;
	internal const int streamingMipmapsPriorityMax = 127;

	// Properties
	public TextureFormat format { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D whiteTexture { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetTextureFormat")]
	// RVA: 0x232A1C0 Offset: 0x23287C0 VA: 0x18232A1C0
	public TextureFormat get_format() { }

	// RVA: 0x232A330 Offset: 0x2328930 VA: 0x18232A330
	public static Texture2D get_whiteTexture() { }

	[FreeFunction("Texture2DScripting::CreateEmpty")]
	// RVA: 0x23284C0 Offset: 0x2326AC0 VA: 0x1823284C0
	private static bool Internal_CreateEmptyImpl(Texture2D mono) { }

	[FreeFunction("Texture2DScripting::Create")]
	// RVA: 0x2328570 Offset: 0x2326B70 VA: 0x182328570
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x2328790 Offset: 0x2326D90 VA: 0x182328790
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x232A280 Offset: 0x2328880 VA: 0x18232A280 Slot: 10
	public override bool get_isReadable() { }

	[NativeName("Apply")]
	// RVA: 0x2327880 Offset: 0x2325E80 VA: 0x182327880
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Reinitialize")]
	// RVA: 0x2328EF0 Offset: 0x23274F0 VA: 0x182328EF0
	private bool ReinitializeImpl(int width, int height) { }

	[NativeName("SetPixel")]
	// RVA: 0x2329370 Offset: 0x2327970 VA: 0x182329370
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[NativeName("GetPixel")]
	// RVA: 0x2327D40 Offset: 0x2326340 VA: 0x182327D40
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	[NativeName("GetPixelBilinear")]
	// RVA: 0x2327B00 Offset: 0x2326100 VA: 0x182327B00
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	// RVA: 0x2329000 Offset: 0x2327600 VA: 0x182329000
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	// RVA: 0x2328C00 Offset: 0x2327200 VA: 0x182328C00
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2329690 Offset: 0x2327C90 VA: 0x182329690
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	// RVA: 0x23288A0 Offset: 0x2326EA0 VA: 0x1823288A0
	private bool LoadRawTextureDataImplArray(byte[] data) { }

	// RVA: 0x2328430 Offset: 0x2326A30 VA: 0x182328430
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x2328370 Offset: 0x2326970 VA: 0x182328370
	private ulong GetRawImageDataSize() { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x23291F0 Offset: 0x23277F0 VA: 0x1823291F0
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2328280 Offset: 0x2326880 VA: 0x182328280
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2327F50 Offset: 0x2326550 VA: 0x182327F50
	public Color32[] GetPixels32(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2327FE0 Offset: 0x23265E0 VA: 0x182327FE0
	public Color32[] GetPixels32() { }

	// RVA: 0x2329B30 Offset: 0x2328130 VA: 0x182329B30
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x2329DC0 Offset: 0x23283C0 VA: 0x182329DC0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x2329F90 Offset: 0x2328590 VA: 0x182329F90
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2329FE0 Offset: 0x23285E0 VA: 0x182329FE0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x232A0B0 Offset: 0x23286B0 VA: 0x18232A0B0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2329C20 Offset: 0x2328220 VA: 0x182329C20
	public void .ctor(int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x2329430 Offset: 0x2327A30 VA: 0x182329430
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x23297F0 Offset: 0x2327DF0 VA: 0x1823297F0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2329980 Offset: 0x2327F80 VA: 0x182329980
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	// RVA: 0x2327E00 Offset: 0x2326400 VA: 0x182327E00
	public Color GetPixel(int x, int y) { }

	[ExcludeFromDocs]
	// RVA: 0x2327BD0 Offset: 0x23261D0 VA: 0x182327BD0
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x23289B0 Offset: 0x2326FB0 VA: 0x1823289B0
	public void LoadRawTextureData(byte[] data) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C5500 Offset: 0x7C3B00 VA: 0x1807C5500
	|-Texture2D.GetRawTextureData<Color>
	|
	|-RVA: 0x7C5610 Offset: 0x7C3C10 VA: 0x1807C5610
	|-Texture2D.GetRawTextureData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2327920 Offset: 0x2325F20 VA: 0x182327920
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x23279F0 Offset: 0x2325FF0 VA: 0x1823279F0
	public void Apply() { }

	// RVA: 0x23290C0 Offset: 0x23276C0 VA: 0x1823290C0
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x2329000 Offset: 0x2327600 VA: 0x182329000
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x2328DB0 Offset: 0x23273B0 VA: 0x182328DB0
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocs]
	// RVA: 0x2328CC0 Offset: 0x23272C0 VA: 0x182328CC0
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x23291F0 Offset: 0x23277F0 VA: 0x1823291F0
	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2329520 Offset: 0x2327B20 VA: 0x182329520
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x23280C0 Offset: 0x23266C0 VA: 0x1823280C0
	public Color[] GetPixels(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x23281B0 Offset: 0x23267B0 VA: 0x1823281B0
	public Color[] GetPixels() { }

	// RVA: 0x232A180 Offset: 0x2328780 VA: 0x18232A180
	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	// RVA: 0x232A300 Offset: 0x2328900 VA: 0x18232A300
	private static IntPtr get_whiteTexture_Injected() { }

	// RVA: 0x2328500 Offset: 0x2326B00 VA: 0x182328500
	private static bool Internal_CreateImpl_Injected(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	// RVA: 0x232A240 Offset: 0x2328840 VA: 0x18232A240
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x2327820 Offset: 0x2325E20 VA: 0x182327820
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2328EA0 Offset: 0x23274A0 VA: 0x182328EA0
	private static bool ReinitializeImpl_Injected(IntPtr _unity_self, int width, int height) { }

	// RVA: 0x2329310 Offset: 0x2327910 VA: 0x182329310
	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, in Color color) { }

	// RVA: 0x2327CE0 Offset: 0x23262E0 VA: 0x182327CE0
	private static void GetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, out Color ret) { }

	// RVA: 0x2327AA0 Offset: 0x23260A0 VA: 0x182327AA0
	private static void GetPixelBilinearImpl_Injected(IntPtr _unity_self, int image, int mip, float u, float v, out Color ret) { }

	// RVA: 0x2328F90 Offset: 0x2327590 VA: 0x182328F90
	private static bool ReinitializeWithTextureFormatImpl_Injected(IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	// RVA: 0x2328B90 Offset: 0x2327190 VA: 0x182328B90
	private static void ReadPixelsImpl_Injected(IntPtr _unity_self, in Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x2329630 Offset: 0x2327C30 VA: 0x182329630
	private static void SetPixelsImpl_Injected(IntPtr _unity_self, int x, int y, int w, int h, ref ManagedSpanWrapper pixel, int miplevel, int frame) { }

	// RVA: 0x2328850 Offset: 0x2326E50 VA: 0x182328850
	private static bool LoadRawTextureDataImplArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper data) { }

	// RVA: 0x23283F0 Offset: 0x23269F0 VA: 0x1823283F0
	private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame) { }

	// RVA: 0x2328330 Offset: 0x2326930 VA: 0x182328330
	private static ulong GetRawImageDataSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x2329190 Offset: 0x2327790 VA: 0x182329190
	private static void SetAllPixels32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }

	// RVA: 0x2328060 Offset: 0x2326660 VA: 0x182328060
	private static Color[] GetPixels_Injected(IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	// RVA: 0x2327F10 Offset: 0x2326510 VA: 0x182327F10
	private static Color32[] GetPixels32_Injected(IntPtr _unity_self, int miplevel) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
[ExcludeFromPreset]
public sealed class Cubemap : Texture // TypeDefIndex: 9623
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	[FreeFunction("CubemapScripting::Create")]
	// RVA: 0x23180B0 Offset: 0x23166B0 VA: 0x1823180B0
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2318110 Offset: 0x2316710 VA: 0x182318110
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2318C90 Offset: 0x2317290 VA: 0x182318C90 Slot: 10
	public override bool get_isReadable() { }

	// RVA: 0x23181E0 Offset: 0x23167E0 VA: 0x1823181E0
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x23182B0 Offset: 0x23168B0 VA: 0x1823182B0
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	[ExcludeFromDocs]
	// RVA: 0x23184E0 Offset: 0x2316AE0 VA: 0x1823184E0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2318580 Offset: 0x2316B80 VA: 0x182318580
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x23185D0 Offset: 0x2316BD0 VA: 0x1823185D0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2318670 Offset: 0x2316C70 VA: 0x182318670
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x23189D0 Offset: 0x2316FD0 VA: 0x1823189D0
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x23188F0 Offset: 0x2316EF0 VA: 0x1823188F0
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2318430 Offset: 0x2316A30 VA: 0x182318430
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x23188D0 Offset: 0x2316ED0 VA: 0x1823188D0
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x23189A0 Offset: 0x2316FA0 VA: 0x1823189A0
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x23183D0 Offset: 0x23169D0 VA: 0x1823183D0
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x2318C50 Offset: 0x2317250 VA: 0x182318C50
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
public sealed class Texture3D : Texture // TypeDefIndex: 9624
{
	// Properties
	public int depth { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetTextureLayerCount")]
	// RVA: 0x232B2D0 Offset: 0x23298D0 VA: 0x18232B2D0
	public int get_depth() { }

	// RVA: 0x232B390 Offset: 0x2329990 VA: 0x18232B390 Slot: 10
	public override bool get_isReadable() { }

	[FreeFunction("Texture3DScripting::Create")]
	// RVA: 0x232A610 Offset: 0x2328C10 VA: 0x18232A610
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x232A670 Offset: 0x2328C70 VA: 0x18232A670
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = True)]
	// RVA: 0x232A3F0 Offset: 0x23289F0 VA: 0x18232A3F0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x232A7C0 Offset: 0x2328DC0 VA: 0x18232A7C0
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x232A8E0 Offset: 0x2328EE0 VA: 0x18232A8E0
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	// RVA: 0x232B080 Offset: 0x2329680 VA: 0x18232B080
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x232AB10 Offset: 0x2329110 VA: 0x18232AB10
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x232AFD0 Offset: 0x23295D0 VA: 0x18232AFD0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x232AB70 Offset: 0x2329170 VA: 0x18232AB70
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x232B250 Offset: 0x2329850 VA: 0x18232B250
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x232B210 Offset: 0x2329810 VA: 0x18232B210
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x232ADE0 Offset: 0x23293E0 VA: 0x18232ADE0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x232AA50 Offset: 0x2329050 VA: 0x18232AA50
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x232AD20 Offset: 0x2329320 VA: 0x18232AD20
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x232B140 Offset: 0x2329740 VA: 0x18232B140
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x232A540 Offset: 0x2328B40 VA: 0x18232A540
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x232A490 Offset: 0x2328A90 VA: 0x18232A490
	public void Apply() { }

	// RVA: 0x232A9F0 Offset: 0x2328FF0 VA: 0x18232A9F0
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x232B290 Offset: 0x2329890 VA: 0x18232B290
	private static int get_depth_Injected(IntPtr _unity_self) { }

	// RVA: 0x232B350 Offset: 0x2329950 VA: 0x18232B350
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x232A390 Offset: 0x2328990 VA: 0x18232A390
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x232A760 Offset: 0x2328D60 VA: 0x18232A760
	private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
[ExcludeFromPreset]
public sealed class Texture2DArray : Texture // TypeDefIndex: 9625
{
	// Properties
	public static int allSlices { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetAllTextureLayersIdentifier")]
	// RVA: 0x2327730 Offset: 0x2325D30 VA: 0x182327730
	public static int get_allSlices() { }

	// RVA: 0x23277A0 Offset: 0x2325DA0 VA: 0x1823277A0 Slot: 10
	public override bool get_isReadable() { }

	[FreeFunction("Texture2DArrayScripting::Create")]
	// RVA: 0x23262E0 Offset: 0x23248E0 VA: 0x1823262E0
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x2326500 Offset: 0x2324B00 VA: 0x182326500
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[FreeFunction(Name = "Texture2DArrayScripting::Apply", HasExplicitThis = True)]
	// RVA: 0x2326050 Offset: 0x2324650 VA: 0x182326050
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "Texture2DArrayScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2326750 Offset: 0x2324D50 VA: 0x182326750
	public void SetPixels(Color[] colors, int arrayElement, int miplevel) { }

	// RVA: 0x2326630 Offset: 0x2324C30 VA: 0x182326630
	public void SetPixels(Color[] colors, int arrayElement) { }

	// RVA: 0x23269B0 Offset: 0x2324FB0 VA: 0x1823269B0
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x2326880 Offset: 0x2324E80 VA: 0x182326880
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x2327650 Offset: 0x2325C50 VA: 0x182327650
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2326BE0 Offset: 0x23251E0 VA: 0x182326BE0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2326CD0 Offset: 0x23252D0 VA: 0x182326CD0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[RequiredByNativeCode]
	// RVA: 0x2326D70 Offset: 0x2325370 VA: 0x182326D70
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2327100 Offset: 0x2325700 VA: 0x182327100
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2326E40 Offset: 0x2325440 VA: 0x182326E40
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x2327370 Offset: 0x2325970 VA: 0x182327370
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x2326C70 Offset: 0x2325270 VA: 0x182326C70
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x2327150 Offset: 0x2325750 VA: 0x182327150
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2327290 Offset: 0x2325890 VA: 0x182327290
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x23271B0 Offset: 0x23257B0 VA: 0x1823271B0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	// RVA: 0x2326B00 Offset: 0x2325100 VA: 0x182326B00
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x23261A0 Offset: 0x23247A0 VA: 0x1823261A0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x23260F0 Offset: 0x23246F0 VA: 0x1823260F0
	public void Apply() { }

	// RVA: 0x2326AA0 Offset: 0x23250A0 VA: 0x182326AA0
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x2327760 Offset: 0x2325D60 VA: 0x182327760
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x2326270 Offset: 0x2324870 VA: 0x182326270
	private static bool Internal_CreateImpl_Injected(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	// RVA: 0x2325FF0 Offset: 0x23245F0 VA: 0x182325FF0
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x23265C0 Offset: 0x2324BC0 VA: 0x1823265C0
	private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int arrayElement, int miplevel) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
[ExcludeFromPreset]
public sealed class CubemapArray : Texture // TypeDefIndex: 9626
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2318030 Offset: 0x2316630 VA: 0x182318030 Slot: 10
	public override bool get_isReadable() { }

	[FreeFunction("CubemapArrayScripting::Create")]
	// RVA: 0x23176E0 Offset: 0x2315CE0 VA: 0x1823176E0
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x2317740 Offset: 0x2315D40 VA: 0x182317740
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2317A40 Offset: 0x2316040 VA: 0x182317A40
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2317E50 Offset: 0x2316450 VA: 0x182317E50
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2317EA0 Offset: 0x23164A0 VA: 0x182317EA0
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2317870 Offset: 0x2315E70 VA: 0x182317870
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2317AF0 Offset: 0x23160F0 VA: 0x182317AF0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x2317A10 Offset: 0x2316010 VA: 0x182317A10
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2317CD0 Offset: 0x23162D0 VA: 0x182317CD0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x2317D90 Offset: 0x2316390 VA: 0x182317D90
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2317F40 Offset: 0x2316540 VA: 0x182317F40
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2317810 Offset: 0x2315E10 VA: 0x182317810
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x2317FF0 Offset: 0x23165F0 VA: 0x182317FF0
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[UsedByNativeCode]
public class RenderTexture : Texture // TypeDefIndex: 9627
{
	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	public GraphicsFormat graphicsFormat { get; set; }
	[NativeProperty("MipMap")]
	public bool useMipMap { set; }
	[NativeProperty("SRGBReadWrite")]
	public bool sRGB { get; }
	public RenderTextureFormat format { get; set; }
	public GraphicsFormat depthStencilFormat { get; set; }
	public bool autoGenerateMips { set; }
	public int volumeDepth { get; set; }
	public bool enableRandomWrite { get; set; }
	public bool useDynamicScale { get; set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public RenderTextureDescriptor descriptor { get; }

	// Methods

	// RVA: 0x2323B90 Offset: 0x2322190 VA: 0x182323B90 Slot: 4
	public override int get_width() { }

	// RVA: 0x2324560 Offset: 0x2322B60 VA: 0x182324560 Slot: 5
	public override void set_width(int value) { }

	// RVA: 0x2323890 Offset: 0x2321E90 VA: 0x182323890 Slot: 6
	public override int get_height() { }

	// RVA: 0x2324200 Offset: 0x2322800 VA: 0x182324200 Slot: 7
	public override void set_height(int value) { }

	// RVA: 0x23234E0 Offset: 0x2321AE0 VA: 0x1823234E0 Slot: 8
	public override TextureDimension get_dimension() { }

	// RVA: 0x2323E00 Offset: 0x2322400 VA: 0x182323E00 Slot: 9
	public override void set_dimension(TextureDimension value) { }

	[NativeName("GetColorFormat")]
	// RVA: 0x231FFE0 Offset: 0x231E5E0 VA: 0x18231FFE0
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	[NativeName("SetColorFormat")]
	// RVA: 0x23216E0 Offset: 0x231FCE0 VA: 0x1823216E0
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x23237D0 Offset: 0x2321DD0 VA: 0x1823237D0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x23216E0 Offset: 0x231FCE0 VA: 0x1823216E0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x23243C0 Offset: 0x23229C0 VA: 0x1823243C0
	public void set_useMipMap(bool value) { }

	// RVA: 0x2323950 Offset: 0x2321F50 VA: 0x182323950
	public bool get_sRGB() { }

	// RVA: 0x2323620 Offset: 0x2321C20 VA: 0x182323620
	public RenderTextureFormat get_format() { }

	// RVA: 0x2323F70 Offset: 0x2322570 VA: 0x182323F70
	public void set_format(RenderTextureFormat value) { }

	// RVA: 0x2323340 Offset: 0x2321940 VA: 0x182323340
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x2323D30 Offset: 0x2322330 VA: 0x182323D30
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x2323C60 Offset: 0x2322260 VA: 0x182323C60
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x2323AD0 Offset: 0x23220D0 VA: 0x182323AD0
	public int get_volumeDepth() { }

	// RVA: 0x2324490 Offset: 0x2322A90 VA: 0x182324490
	public void set_volumeDepth(int value) { }

	// RVA: 0x23235A0 Offset: 0x2321BA0 VA: 0x1823235A0
	public bool get_enableRandomWrite() { }

	// RVA: 0x2323EE0 Offset: 0x23224E0 VA: 0x182323EE0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x2323A10 Offset: 0x2322010 VA: 0x182323A10
	public bool get_useDynamicScale() { }

	// RVA: 0x23242E0 Offset: 0x23228E0 VA: 0x1823242E0
	public void set_useDynamicScale(bool value) { }

	[FreeFunction("RenderTexture::GetActiveAsRenderTexture")]
	// RVA: 0x231FE50 Offset: 0x231E450 VA: 0x18231FE50
	private static RenderTexture GetActive() { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	// RVA: 0x2321630 Offset: 0x231FC30 VA: 0x182321630
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x231FE50 Offset: 0x231E450 VA: 0x18231FE50
	public static RenderTexture get_active() { }

	// RVA: 0x2321630 Offset: 0x231FC30 VA: 0x182321630
	public static void set_active(RenderTexture value) { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	// RVA: 0x231FF00 Offset: 0x231E500 VA: 0x18231FF00
	private RenderBuffer GetColorBuffer() { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	// RVA: 0x2320240 Offset: 0x231E840 VA: 0x182320240
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x23217B0 Offset: 0x231FDB0 VA: 0x1823217B0
	private void SetMipMapCount(int count) { }

	// RVA: 0x2321A40 Offset: 0x2320040 VA: 0x182321A40
	internal void SetShadowSamplingMode(ShadowSamplingMode samplingMode) { }

	// RVA: 0x23231A0 Offset: 0x23217A0 VA: 0x1823231A0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x2323250 Offset: 0x2321850 VA: 0x182323250
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x231FDA0 Offset: 0x231E3A0 VA: 0x18231FDA0
	public bool Create() { }

	// RVA: 0x2321570 Offset: 0x231FB70 VA: 0x182321570
	public void Release() { }

	// RVA: 0x2321400 Offset: 0x231FA00 VA: 0x182321400
	public bool IsCreated() { }

	// RVA: 0x2321970 Offset: 0x231FF70 VA: 0x182321970
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunction("RenderTextureScripting::Create")]
	// RVA: 0x2321380 Offset: 0x231F980 VA: 0x182321380
	private static void Internal_Create(RenderTexture rt) { }

	[NativeName("SetRenderTextureDescFromScript")]
	// RVA: 0x2321890 Offset: 0x231FE90 VA: 0x182321890
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeName("GetRenderTextureDesc")]
	// RVA: 0x2320480 Offset: 0x231EA80 VA: 0x182320480
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	// RVA: 0x2320680 Offset: 0x231EC80 VA: 0x182320680
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	// RVA: 0x23214C0 Offset: 0x231FAC0 VA: 0x1823214C0
	public static void ReleaseTemporary(RenderTexture temp) { }

	[RequiredByNativeCode]
	// RVA: 0x2322D20 Offset: 0x2321320 VA: 0x182322D20
	protected internal void .ctor() { }

	// RVA: 0x2322450 Offset: 0x2320A50 VA: 0x182322450
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x2322F10 Offset: 0x2321510 VA: 0x182322F10
	public void .ctor(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	// RVA: 0x2322BA0 Offset: 0x23211A0 VA: 0x182322BA0
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x23220E0 Offset: 0x23206E0 VA: 0x1823220E0
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x23227D0 Offset: 0x2320DD0 VA: 0x1823227D0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2322180 Offset: 0x2320780 VA: 0x182322180
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2322E70 Offset: 0x2321470 VA: 0x182322E70
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x2322AC0 Offset: 0x23210C0 VA: 0x182322AC0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x23226B0 Offset: 0x2320CB0 VA: 0x1823226B0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x2322590 Offset: 0x2320B90 VA: 0x182322590
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocs]
	// RVA: 0x2322DA0 Offset: 0x23213A0 VA: 0x182322DA0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x2321080 Offset: 0x231F680 VA: 0x182321080
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x2320410 Offset: 0x231EA10 VA: 0x182320410
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x23202D0 Offset: 0x231E8D0 VA: 0x1823202D0
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback = False) { }

	// RVA: 0x2320420 Offset: 0x231EA20 VA: 0x182320420
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x2320310 Offset: 0x231E910 VA: 0x182320310
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x23233C0 Offset: 0x23219C0 VA: 0x1823233C0
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x2321AD0 Offset: 0x23200D0 VA: 0x182321AD0
	private static void ValidateRenderTextureDesc(ref RenderTextureDescriptor desc) { }

	// RVA: 0x23201A0 Offset: 0x231E7A0 VA: 0x1823201A0
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x23201C0 Offset: 0x231E7C0 VA: 0x1823201C0
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x2320520 Offset: 0x231EB20 VA: 0x182320520
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format) { }

	// RVA: 0x2320520 Offset: 0x231EB20 VA: 0x182320520
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format) { }

	// RVA: 0x2322050 Offset: 0x2320650 VA: 0x182322050
	internal static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format) { }

	// RVA: 0x2320070 Offset: 0x231E670 VA: 0x182320070
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x2320CE0 Offset: 0x231F2E0 VA: 0x182320CE0
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x2320530 Offset: 0x231EB30 VA: 0x182320530
	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False, ShadowSamplingMode shadowSamplingMode = 2) { }

	// RVA: 0x2320EF0 Offset: 0x231F4F0 VA: 0x182320EF0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	// RVA: 0x2320860 Offset: 0x231EE60 VA: 0x182320860
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	// RVA: 0x23206E0 Offset: 0x231ECE0 VA: 0x1823206E0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	// RVA: 0x23209E0 Offset: 0x231EFE0 VA: 0x1823209E0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocs]
	// RVA: 0x2320B60 Offset: 0x231F160 VA: 0x182320B60
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x2320D70 Offset: 0x231F370 VA: 0x182320D70
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x2323B50 Offset: 0x2322150 VA: 0x182323B50
	private static int get_width_Injected(IntPtr _unity_self) { }

	// RVA: 0x2324520 Offset: 0x2322B20 VA: 0x182324520
	private static void set_width_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2323850 Offset: 0x2321E50 VA: 0x182323850
	private static int get_height_Injected(IntPtr _unity_self) { }

	// RVA: 0x23241C0 Offset: 0x23227C0 VA: 0x1823241C0
	private static void set_height_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x23234A0 Offset: 0x2321AA0 VA: 0x1823234A0
	private static TextureDimension get_dimension_Injected(IntPtr _unity_self) { }

	// RVA: 0x2323DC0 Offset: 0x23223C0 VA: 0x182323DC0
	private static void set_dimension_Injected(IntPtr _unity_self, TextureDimension value) { }

	// RVA: 0x231FF90 Offset: 0x231E590 VA: 0x18231FF90
	private static GraphicsFormat GetColorFormat_Injected(IntPtr _unity_self, bool suppressWarnings) { }

	// RVA: 0x23216A0 Offset: 0x231FCA0 VA: 0x1823216A0
	private static void SetColorFormat_Injected(IntPtr _unity_self, GraphicsFormat format) { }

	// RVA: 0x2324370 Offset: 0x2322970 VA: 0x182324370
	private static void set_useMipMap_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2323910 Offset: 0x2321F10 VA: 0x182323910
	private static bool get_sRGB_Injected(IntPtr _unity_self) { }

	// RVA: 0x2323300 Offset: 0x2321900 VA: 0x182323300
	private static GraphicsFormat get_depthStencilFormat_Injected(IntPtr _unity_self) { }

	// RVA: 0x2323CF0 Offset: 0x23222F0 VA: 0x182323CF0
	private static void set_depthStencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value) { }

	// RVA: 0x2323C10 Offset: 0x2322210 VA: 0x182323C10
	private static void set_autoGenerateMips_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2323A90 Offset: 0x2322090 VA: 0x182323A90
	private static int get_volumeDepth_Injected(IntPtr _unity_self) { }

	// RVA: 0x2324450 Offset: 0x2322A50 VA: 0x182324450
	private static void set_volumeDepth_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2323560 Offset: 0x2321B60 VA: 0x182323560
	private static bool get_enableRandomWrite_Injected(IntPtr _unity_self) { }

	// RVA: 0x2323E90 Offset: 0x2322490 VA: 0x182323E90
	private static void set_enableRandomWrite_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x23239D0 Offset: 0x2321FD0 VA: 0x1823239D0
	private static bool get_useDynamicScale_Injected(IntPtr _unity_self) { }

	// RVA: 0x2324290 Offset: 0x2322890 VA: 0x182324290
	private static void set_useDynamicScale_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x231FE20 Offset: 0x231E420 VA: 0x18231FE20
	private static IntPtr GetActive_Injected() { }

	// RVA: 0x23215F0 Offset: 0x231FBF0 VA: 0x1823215F0
	private static void SetActive_Injected(IntPtr rt) { }

	// RVA: 0x231FEB0 Offset: 0x231E4B0 VA: 0x18231FEB0
	private static void GetColorBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	// RVA: 0x23201F0 Offset: 0x231E7F0 VA: 0x1823201F0
	private static void GetDepthBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	// RVA: 0x2321770 Offset: 0x231FD70 VA: 0x182321770
	private static void SetMipMapCount_Injected(IntPtr _unity_self, int count) { }

	// RVA: 0x2321A00 Offset: 0x2320000 VA: 0x182321A00
	private static void SetShadowSamplingMode_Injected(IntPtr _unity_self, ShadowSamplingMode samplingMode) { }

	// RVA: 0x231FD60 Offset: 0x231E360 VA: 0x18231FD60
	private static bool Create_Injected(IntPtr _unity_self) { }

	// RVA: 0x2321530 Offset: 0x231FB30 VA: 0x182321530
	private static void Release_Injected(IntPtr _unity_self) { }

	// RVA: 0x23213C0 Offset: 0x231F9C0 VA: 0x1823213C0
	private static bool IsCreated_Injected(IntPtr _unity_self) { }

	// RVA: 0x2321920 Offset: 0x231FF20 VA: 0x182321920
	private static void SetSRGBReadWrite_Injected(IntPtr _unity_self, bool srgb) { }

	// RVA: 0x2321840 Offset: 0x231FE40 VA: 0x182321840
	private static void SetRenderTextureDescriptor_Injected(IntPtr _unity_self, in RenderTextureDescriptor desc) { }

	// RVA: 0x2320430 Offset: 0x231EA30 VA: 0x182320430
	private static void GetDescriptor_Injected(IntPtr _unity_self, out RenderTextureDescriptor ret) { }

	// RVA: 0x2320640 Offset: 0x231EC40 VA: 0x182320640
	private static IntPtr GetTemporary_Internal_Injected(in RenderTextureDescriptor desc) { }

	// RVA: 0x2321480 Offset: 0x231FA80 VA: 0x182321480
	private static void ReleaseTemporary_Injected(IntPtr temp) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CustomRenderTexture.h")]
[UsedByNativeCode]
public sealed class CustomRenderTexture : RenderTexture // TypeDefIndex: 9628
{}

// Namespace: UnityEngine
public struct RenderTextureDescriptor // TypeDefIndex: 9629
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <width>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <msaaSamples>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <volumeDepth>k__BackingField; // 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private GraphicsFormat <depthStencilFormat>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; set; }
	public int height { get; set; }
	public int msaaSamples { get; set; }
	public int volumeDepth { get; set; }
	public int mipCount { set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public GraphicsFormat depthStencilFormat { get; set; }
	public RenderTextureFormat colorFormat { get; set; }
	public bool sRGB { get; set; }
	public int depthBufferBits { get; set; }
	public TextureDimension dimension { get; set; }
	public ShadowSamplingMode shadowSamplingMode { get; set; }
	public VRTextureUsage vrUsage { get; set; }
	public RenderTextureMemoryless memoryless { get; set; }
	public bool useMipMap { get; set; }
	public bool autoGenerateMips { get; set; }
	public bool enableRandomWrite { get; set; }
	internal bool createdFromScript { set; }
	public bool useDynamicScale { set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_width() { }

	[CompilerGenerated]
	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_width(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_height() { }

	[CompilerGenerated]
	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_height(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_msaaSamples() { }

	[CompilerGenerated]
	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_msaaSamples(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_volumeDepth() { }

	[CompilerGenerated]
	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_volumeDepth(int value) { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_mipCount(int value) { }

	// RVA: 0xEBC7A0 Offset: 0xEBADA0 VA: 0x180EBC7A0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x231FBC0 Offset: 0x231E1C0 VA: 0x18231FBC0
	public void set_graphicsFormat(GraphicsFormat value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public GraphicsFormat get_depthStencilFormat() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x231F8D0 Offset: 0x231DED0 VA: 0x18231F8D0
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x231FA20 Offset: 0x231E020 VA: 0x18231FA20
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x231F9A0 Offset: 0x231DFA0 VA: 0x18231F9A0
	public bool get_sRGB() { }

	// RVA: 0x231FC80 Offset: 0x231E280 VA: 0x18231FC80
	public void set_sRGB(bool value) { }

	// RVA: 0x231F940 Offset: 0x231DF40 VA: 0x18231F940
	public int get_depthBufferBits() { }

	// RVA: 0x231FB10 Offset: 0x231E110 VA: 0x18231FB10
	public void set_depthBufferBits(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public TextureDimension get_dimension() { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_dimension(TextureDimension value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[CompilerGenerated]
	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public VRTextureUsage get_vrUsage() { }

	[CompilerGenerated]
	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_vrUsage(VRTextureUsage value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGenerated]
	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_memoryless(RenderTextureMemoryless value) { }

	[ExcludeFromDocs]
	// RVA: 0x231F530 Offset: 0x231DB30 VA: 0x18231F530
	public void .ctor(int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x231F6D0 Offset: 0x231DCD0 VA: 0x18231F6D0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat) { }

	[ExcludeFromDocs]
	// RVA: 0x231F810 Offset: 0x231DE10 VA: 0x18231F810
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	[ExcludeFromDocs]
	// RVA: 0x231F630 Offset: 0x231DC30 VA: 0x18231F630
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x231F6F0 Offset: 0x231DCF0 VA: 0x18231F6F0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x231F550 Offset: 0x231DB50 VA: 0x18231F550
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	// RVA: 0x231F660 Offset: 0x231DC60 VA: 0x18231F660
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x231F510 Offset: 0x231DB10 VA: 0x18231F510
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x231F9F0 Offset: 0x231DFF0 VA: 0x18231F9F0
	public bool get_useMipMap() { }

	// RVA: 0x231FD40 Offset: 0x231E340 VA: 0x18231FD40
	public void set_useMipMap(bool value) { }

	// RVA: 0x231F8C0 Offset: 0x231DEC0 VA: 0x18231F8C0
	public bool get_autoGenerateMips() { }

	// RVA: 0x231FA00 Offset: 0x231E000 VA: 0x18231FA00
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x231F990 Offset: 0x231DF90 VA: 0x18231F990
	public bool get_enableRandomWrite() { }

	// RVA: 0x231FBA0 Offset: 0x231E1A0 VA: 0x18231FBA0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x231FAF0 Offset: 0x231E0F0 VA: 0x18231FAF0
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x231FD20 Offset: 0x231E320 VA: 0x18231FD20
	public void set_useDynamicScale(bool value) { }
}

// Namespace: UnityEngine
public struct MipmapLimitDescriptor // TypeDefIndex: 9630
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <useMipmapLimit>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <groupName>k__BackingField; // 0x8

	// Properties
	public bool useMipmapLimit { get; }
	public string groupName { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_useMipmapLimit() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public string get_groupName() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/Hash128.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[Serializable]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 9631
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.GraphToolsFoundationModule" })]
	internal ulong u64_0; // 0x0
	[VisibleToOtherModules(new[] { "UnityEngine.GraphToolsFoundationModule" })]
	internal ulong u64_1; // 0x8

	// Properties
	public bool isValid { get; }

	// Methods

	// RVA: 0x231A360 Offset: 0x2318960 VA: 0x18231A360
	public void .ctor(uint u32_0, uint u32_1, uint u32_2, uint u32_3) { }

	// RVA: 0x1FBE710 Offset: 0x1FBCD10 VA: 0x181FBE710
	public void .ctor(ulong u64_0, ulong u64_1) { }

	// RVA: 0x231A390 Offset: 0x2318990 VA: 0x18231A390
	public bool get_isValid() { }

	// RVA: 0x2319C60 Offset: 0x2318260 VA: 0x182319C60 Slot: 5
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x231A340 Offset: 0x2318940 VA: 0x18231A340 Slot: 3
	public override string ToString() { }

	[FreeFunction("StringToHash128", IsThreadSafe = True)]
	// RVA: 0x231A170 Offset: 0x2318770 VA: 0x18231A170
	public static Hash128 Parse(string hashString) { }

	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	// RVA: 0x231A070 Offset: 0x2318670 VA: 0x18231A070
	private static string Hash128ToStringImpl(Hash128 hash) { }

	[FreeFunction("ComputeHash128FromScriptString", IsThreadSafe = True)]
	// RVA: 0x2319D50 Offset: 0x2318350 VA: 0x182319D50
	private static void ComputeFromString(string data, ref Hash128 hash) { }

	// RVA: 0x2319ED0 Offset: 0x23184D0 VA: 0x182319ED0
	public static Hash128 Compute(string data) { }

	// RVA: 0x2319F10 Offset: 0x2318510 VA: 0x182319F10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2319FC0 Offset: 0x23185C0 VA: 0x182319FC0 Slot: 6
	public bool Equals(Hash128 obj) { }

	// RVA: 0x2319FF0 Offset: 0x23185F0 VA: 0x182319FF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2319B20 Offset: 0x2318120 VA: 0x182319B20 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x231A3B0 Offset: 0x23189B0 VA: 0x18231A3B0
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x231A440 Offset: 0x2318A40 VA: 0x18231A440
	public static bool op_Inequality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x231A470 Offset: 0x2318A70 VA: 0x18231A470
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x231A3D0 Offset: 0x23189D0 VA: 0x18231A3D0
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x231A120 Offset: 0x2318720 VA: 0x18231A120
	private static void Parse_Injected(ref ManagedSpanWrapper hashString, out Hash128 ret) { }

	// RVA: 0x231A020 Offset: 0x2318620 VA: 0x18231A020
	private static void Hash128ToStringImpl_Injected(in Hash128 hash, out ManagedSpanWrapper ret) { }

	// RVA: 0x2319D00 Offset: 0x2318300 VA: 0x182319D00
	private static void ComputeFromString_Injected(ref ManagedSpanWrapper data, ref Hash128 hash) { }
}

// Namespace: UnityEngine
public static class HashUnsafeUtilities // TypeDefIndex: 9632
{
	// Methods

	// RVA: 0x231A550 Offset: 0x2318B50 VA: 0x18231A550
	public static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2) { }

	// RVA: 0x231A490 Offset: 0x2318A90 VA: 0x18231A490
	public static void ComputeHash128(void* data, ulong dataSize, Hash128* hash) { }
}

// Namespace: UnityEngine
internal static class SpookyHash // TypeDefIndex: 9634
{
	// Fields
	private static readonly bool AllowUnalignedRead; // 0x0

	// Methods

	// RVA: 0x23245F0 Offset: 0x2322BF0 VA: 0x1823245F0
	private static bool AttemptDetectAllowUnalignedRead() { }

	// RVA: 0x2324AD0 Offset: 0x23230D0 VA: 0x182324AD0
	public static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2) { }

	// RVA: 0x2324890 Offset: 0x2322E90 VA: 0x182324890
	private static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	// RVA: 0x2324670 Offset: 0x2322C70 VA: 0x182324670
	private static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	// RVA: 0x23255F0 Offset: 0x2323BF0 VA: 0x1823255F0
	private static void Rot64(ref ulong x, int k) { }

	// RVA: 0x23259C0 Offset: 0x2323FC0 VA: 0x1823259C0
	private static void Short(void* message, ulong length, ulong* hash1, ulong* hash2) { }

	// RVA: 0x23257D0 Offset: 0x2323DD0 VA: 0x1823257D0
	private static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	// RVA: 0x2325620 Offset: 0x2323C20 VA: 0x182325620
	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	// RVA: 0x2325320 Offset: 0x2323920 VA: 0x182325320
	private static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11) { }

	// RVA: 0x2325E90 Offset: 0x2324490 VA: 0x182325E90
	private static void memset(void* dst, int value, ulong numberOfBytes) { }

	// RVA: 0x2325DE0 Offset: 0x23243E0 VA: 0x182325DE0
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum CursorMode // TypeDefIndex: 9635
{
	// Fields
	public int value__; // 0x0
	public const CursorMode Auto = 0;
	public const CursorMode ForceSoftware = 1;
}

// Namespace: UnityEngine
public enum CursorLockMode // TypeDefIndex: 9636
{
	// Fields
	public int value__; // 0x0
	public const CursorLockMode None = 0;
	public const CursorLockMode Locked = 1;
	public const CursorLockMode Confined = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
public class Cursor // TypeDefIndex: 9637
{
	// Properties
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; set; }

	// Methods

	// RVA: 0x2318D70 Offset: 0x2317370 VA: 0x182318D70
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x2318E30 Offset: 0x2317430 VA: 0x182318E30
	public static bool get_visible() { }

	// RVA: 0x2318EA0 Offset: 0x23174A0 VA: 0x182318EA0
	public static void set_visible(bool value) { }

	// RVA: 0x2318E00 Offset: 0x2317400 VA: 0x182318E00
	public static CursorLockMode get_lockState() { }

	// RVA: 0x2318E60 Offset: 0x2317460 VA: 0x182318E60
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x2318D10 Offset: 0x2317310 VA: 0x182318D10
	private static void SetCursor_Injected(IntPtr texture, in Vector2 hotspot, CursorMode cursorMode) { }
}

// Namespace: UnityEngine
public enum KeyCode // TypeDefIndex: 9638
{
	// Fields
	public int value__; // 0x0
	public const KeyCode None = 0;
	public const KeyCode Backspace = 8;
	public const KeyCode Delete = 127;
	public const KeyCode Tab = 9;
	public const KeyCode Clear = 12;
	public const KeyCode Return = 13;
	public const KeyCode Pause = 19;
	public const KeyCode Escape = 27;
	public const KeyCode Space = 32;
	public const KeyCode Keypad0 = 256;
	public const KeyCode Keypad1 = 257;
	public const KeyCode Keypad2 = 258;
	public const KeyCode Keypad3 = 259;
	public const KeyCode Keypad4 = 260;
	public const KeyCode Keypad5 = 261;
	public const KeyCode Keypad6 = 262;
	public const KeyCode Keypad7 = 263;
	public const KeyCode Keypad8 = 264;
	public const KeyCode Keypad9 = 265;
	public const KeyCode KeypadPeriod = 266;
	public const KeyCode KeypadDivide = 267;
	public const KeyCode KeypadMultiply = 268;
	public const KeyCode KeypadMinus = 269;
	public const KeyCode KeypadPlus = 270;
	public const KeyCode KeypadEnter = 271;
	public const KeyCode KeypadEquals = 272;
	public const KeyCode UpArrow = 273;
	public const KeyCode DownArrow = 274;
	public const KeyCode RightArrow = 275;
	public const KeyCode LeftArrow = 276;
	public const KeyCode Insert = 277;
	public const KeyCode Home = 278;
	public const KeyCode End = 279;
	public const KeyCode PageUp = 280;
	public const KeyCode PageDown = 281;
	public const KeyCode F1 = 282;
	public const KeyCode F2 = 283;
	public const KeyCode F3 = 284;
	public const KeyCode F4 = 285;
	public const KeyCode F5 = 286;
	public const KeyCode F6 = 287;
	public const KeyCode F7 = 288;
	public const KeyCode F8 = 289;
	public const KeyCode F9 = 290;
	public const KeyCode F10 = 291;
	public const KeyCode F11 = 292;
	public const KeyCode F12 = 293;
	public const KeyCode F13 = 294;
	public const KeyCode F14 = 295;
	public const KeyCode F15 = 296;
	public const KeyCode Alpha0 = 48;
	public const KeyCode Alpha1 = 49;
	public const KeyCode Alpha2 = 50;
	public const KeyCode Alpha3 = 51;
	public const KeyCode Alpha4 = 52;
	public const KeyCode Alpha5 = 53;
	public const KeyCode Alpha6 = 54;
	public const KeyCode Alpha7 = 55;
	public const KeyCode Alpha8 = 56;
	public const KeyCode Alpha9 = 57;
	public const KeyCode Exclaim = 33;
	public const KeyCode DoubleQuote = 34;
	public const KeyCode Hash = 35;
	public const KeyCode Dollar = 36;
	public const KeyCode Percent = 37;
	public const KeyCode Ampersand = 38;
	public const KeyCode Quote = 39;
	public const KeyCode LeftParen = 40;
	public const KeyCode RightParen = 41;
	public const KeyCode Asterisk = 42;
	public const KeyCode Plus = 43;
	public const KeyCode Comma = 44;
	public const KeyCode Minus = 45;
	public const KeyCode Period = 46;
	public const KeyCode Slash = 47;
	public const KeyCode Colon = 58;
	public const KeyCode Semicolon = 59;
	public const KeyCode Less = 60;
	public const KeyCode Equals = 61;
	public const KeyCode Greater = 62;
	public const KeyCode Question = 63;
	public const KeyCode At = 64;
	public const KeyCode LeftBracket = 91;
	public const KeyCode Backslash = 92;
	public const KeyCode RightBracket = 93;
	public const KeyCode Caret = 94;
	public const KeyCode Underscore = 95;
	public const KeyCode BackQuote = 96;
	public const KeyCode A = 97;
	public const KeyCode B = 98;
	public const KeyCode C = 99;
	public const KeyCode D = 100;
	public const KeyCode E = 101;
	public const KeyCode F = 102;
	public const KeyCode G = 103;
	public const KeyCode H = 104;
	public const KeyCode I = 105;
	public const KeyCode J = 106;
	public const KeyCode K = 107;
	public const KeyCode L = 108;
	public const KeyCode M = 109;
	public const KeyCode N = 110;
	public const KeyCode O = 111;
	public const KeyCode P = 112;
	public const KeyCode Q = 113;
	public const KeyCode R = 114;
	public const KeyCode S = 115;
	public const KeyCode T = 116;
	public const KeyCode U = 117;
	public const KeyCode V = 118;
	public const KeyCode W = 119;
	public const KeyCode X = 120;
	public const KeyCode Y = 121;
	public const KeyCode Z = 122;
	public const KeyCode LeftCurlyBracket = 123;
	public const KeyCode Pipe = 124;
	public const KeyCode RightCurlyBracket = 125;
	public const KeyCode Tilde = 126;
	public const KeyCode Numlock = 300;
	public const KeyCode CapsLock = 301;
	public const KeyCode ScrollLock = 302;
	public const KeyCode RightShift = 303;
	public const KeyCode LeftShift = 304;
	public const KeyCode RightControl = 305;
	public const KeyCode LeftControl = 306;
	public const KeyCode RightAlt = 307;
	public const KeyCode LeftAlt = 308;
	public const KeyCode LeftMeta = 310;
	public const KeyCode LeftCommand = 310;
	public const KeyCode LeftApple = 310;
	public const KeyCode LeftWindows = 311;
	public const KeyCode RightMeta = 309;
	public const KeyCode RightCommand = 309;
	public const KeyCode RightApple = 309;
	public const KeyCode RightWindows = 312;
	public const KeyCode AltGr = 313;
	public const KeyCode Help = 315;
	public const KeyCode Print = 316;
	public const KeyCode SysReq = 317;
	public const KeyCode Break = 318;
	public const KeyCode Menu = 319;
	public const KeyCode WheelUp = 321;
	public const KeyCode WheelDown = 322;
	public const KeyCode Mouse0 = 323;
	public const KeyCode Mouse1 = 324;
	public const KeyCode Mouse2 = 325;
	public const KeyCode Mouse3 = 326;
	public const KeyCode Mouse4 = 327;
	public const KeyCode Mouse5 = 328;
	public const KeyCode Mouse6 = 329;
	public const KeyCode JoystickButton0 = 330;
	public const KeyCode JoystickButton1 = 331;
	public const KeyCode JoystickButton2 = 332;
	public const KeyCode JoystickButton3 = 333;
	public const KeyCode JoystickButton4 = 334;
	public const KeyCode JoystickButton5 = 335;
	public const KeyCode JoystickButton6 = 336;
	public const KeyCode JoystickButton7 = 337;
	public const KeyCode JoystickButton8 = 338;
	public const KeyCode JoystickButton9 = 339;
	public const KeyCode JoystickButton10 = 340;
	public const KeyCode JoystickButton11 = 341;
	public const KeyCode JoystickButton12 = 342;
	public const KeyCode JoystickButton13 = 343;
	public const KeyCode JoystickButton14 = 344;
	public const KeyCode JoystickButton15 = 345;
	public const KeyCode JoystickButton16 = 346;
	public const KeyCode JoystickButton17 = 347;
	public const KeyCode JoystickButton18 = 348;
	public const KeyCode JoystickButton19 = 349;
	public const KeyCode Joystick1Button0 = 350;
	public const KeyCode Joystick1Button1 = 351;
	public const KeyCode Joystick1Button2 = 352;
	public const KeyCode Joystick1Button3 = 353;
	public const KeyCode Joystick1Button4 = 354;
	public const KeyCode Joystick1Button5 = 355;
	public const KeyCode Joystick1Button6 = 356;
	public const KeyCode Joystick1Button7 = 357;
	public const KeyCode Joystick1Button8 = 358;
	public const KeyCode Joystick1Button9 = 359;
	public const KeyCode Joystick1Button10 = 360;
	public const KeyCode Joystick1Button11 = 361;
	public const KeyCode Joystick1Button12 = 362;
	public const KeyCode Joystick1Button13 = 363;
	public const KeyCode Joystick1Button14 = 364;
	public const KeyCode Joystick1Button15 = 365;
	public const KeyCode Joystick1Button16 = 366;
	public const KeyCode Joystick1Button17 = 367;
	public const KeyCode Joystick1Button18 = 368;
	public const KeyCode Joystick1Button19 = 369;
	public const KeyCode Joystick2Button0 = 370;
	public const KeyCode Joystick2Button1 = 371;
	public const KeyCode Joystick2Button2 = 372;
	public const KeyCode Joystick2Button3 = 373;
	public const KeyCode Joystick2Button4 = 374;
	public const KeyCode Joystick2Button5 = 375;
	public const KeyCode Joystick2Button6 = 376;
	public const KeyCode Joystick2Button7 = 377;
	public const KeyCode Joystick2Button8 = 378;
	public const KeyCode Joystick2Button9 = 379;
	public const KeyCode Joystick2Button10 = 380;
	public const KeyCode Joystick2Button11 = 381;
	public const KeyCode Joystick2Button12 = 382;
	public const KeyCode Joystick2Button13 = 383;
	public const KeyCode Joystick2Button14 = 384;
	public const KeyCode Joystick2Button15 = 385;
	public const KeyCode Joystick2Button16 = 386;
	public const KeyCode Joystick2Button17 = 387;
	public const KeyCode Joystick2Button18 = 388;
	public const KeyCode Joystick2Button19 = 389;
	public const KeyCode Joystick3Button0 = 390;
	public const KeyCode Joystick3Button1 = 391;
	public const KeyCode Joystick3Button2 = 392;
	public const KeyCode Joystick3Button3 = 393;
	public const KeyCode Joystick3Button4 = 394;
	public const KeyCode Joystick3Button5 = 395;
	public const KeyCode Joystick3Button6 = 396;
	public const KeyCode Joystick3Button7 = 397;
	public const KeyCode Joystick3Button8 = 398;
	public const KeyCode Joystick3Button9 = 399;
	public const KeyCode Joystick3Button10 = 400;
	public const KeyCode Joystick3Button11 = 401;
	public const KeyCode Joystick3Button12 = 402;
	public const KeyCode Joystick3Button13 = 403;
	public const KeyCode Joystick3Button14 = 404;
	public const KeyCode Joystick3Button15 = 405;
	public const KeyCode Joystick3Button16 = 406;
	public const KeyCode Joystick3Button17 = 407;
	public const KeyCode Joystick3Button18 = 408;
	public const KeyCode Joystick3Button19 = 409;
	public const KeyCode Joystick4Button0 = 410;
	public const KeyCode Joystick4Button1 = 411;
	public const KeyCode Joystick4Button2 = 412;
	public const KeyCode Joystick4Button3 = 413;
	public const KeyCode Joystick4Button4 = 414;
	public const KeyCode Joystick4Button5 = 415;
	public const KeyCode Joystick4Button6 = 416;
	public const KeyCode Joystick4Button7 = 417;
	public const KeyCode Joystick4Button8 = 418;
	public const KeyCode Joystick4Button9 = 419;
	public const KeyCode Joystick4Button10 = 420;
	public const KeyCode Joystick4Button11 = 421;
	public const KeyCode Joystick4Button12 = 422;
	public const KeyCode Joystick4Button13 = 423;
	public const KeyCode Joystick4Button14 = 424;
	public const KeyCode Joystick4Button15 = 425;
	public const KeyCode Joystick4Button16 = 426;
	public const KeyCode Joystick4Button17 = 427;
	public const KeyCode Joystick4Button18 = 428;
	public const KeyCode Joystick4Button19 = 429;
	public const KeyCode Joystick5Button0 = 430;
	public const KeyCode Joystick5Button1 = 431;
	public const KeyCode Joystick5Button2 = 432;
	public const KeyCode Joystick5Button3 = 433;
	public const KeyCode Joystick5Button4 = 434;
	public const KeyCode Joystick5Button5 = 435;
	public const KeyCode Joystick5Button6 = 436;
	public const KeyCode Joystick5Button7 = 437;
	public const KeyCode Joystick5Button8 = 438;
	public const KeyCode Joystick5Button9 = 439;
	public const KeyCode Joystick5Button10 = 440;
	public const KeyCode Joystick5Button11 = 441;
	public const KeyCode Joystick5Button12 = 442;
	public const KeyCode Joystick5Button13 = 443;
	public const KeyCode Joystick5Button14 = 444;
	public const KeyCode Joystick5Button15 = 445;
	public const KeyCode Joystick5Button16 = 446;
	public const KeyCode Joystick5Button17 = 447;
	public const KeyCode Joystick5Button18 = 448;
	public const KeyCode Joystick5Button19 = 449;
	public const KeyCode Joystick6Button0 = 450;
	public const KeyCode Joystick6Button1 = 451;
	public const KeyCode Joystick6Button2 = 452;
	public const KeyCode Joystick6Button3 = 453;
	public const KeyCode Joystick6Button4 = 454;
	public const KeyCode Joystick6Button5 = 455;
	public const KeyCode Joystick6Button6 = 456;
	public const KeyCode Joystick6Button7 = 457;
	public const KeyCode Joystick6Button8 = 458;
	public const KeyCode Joystick6Button9 = 459;
	public const KeyCode Joystick6Button10 = 460;
	public const KeyCode Joystick6Button11 = 461;
	public const KeyCode Joystick6Button12 = 462;
	public const KeyCode Joystick6Button13 = 463;
	public const KeyCode Joystick6Button14 = 464;
	public const KeyCode Joystick6Button15 = 465;
	public const KeyCode Joystick6Button16 = 466;
	public const KeyCode Joystick6Button17 = 467;
	public const KeyCode Joystick6Button18 = 468;
	public const KeyCode Joystick6Button19 = 469;
	public const KeyCode Joystick7Button0 = 470;
	public const KeyCode Joystick7Button1 = 471;
	public const KeyCode Joystick7Button2 = 472;
	public const KeyCode Joystick7Button3 = 473;
	public const KeyCode Joystick7Button4 = 474;
	public const KeyCode Joystick7Button5 = 475;
	public const KeyCode Joystick7Button6 = 476;
	public const KeyCode Joystick7Button7 = 477;
	public const KeyCode Joystick7Button8 = 478;
	public const KeyCode Joystick7Button9 = 479;
	public const KeyCode Joystick7Button10 = 480;
	public const KeyCode Joystick7Button11 = 481;
	public const KeyCode Joystick7Button12 = 482;
	public const KeyCode Joystick7Button13 = 483;
	public const KeyCode Joystick7Button14 = 484;
	public const KeyCode Joystick7Button15 = 485;
	public const KeyCode Joystick7Button16 = 486;
	public const KeyCode Joystick7Button17 = 487;
	public const KeyCode Joystick7Button18 = 488;
	public const KeyCode Joystick7Button19 = 489;
	public const KeyCode Joystick8Button0 = 490;
	public const KeyCode Joystick8Button1 = 491;
	public const KeyCode Joystick8Button2 = 492;
	public const KeyCode Joystick8Button3 = 493;
	public const KeyCode Joystick8Button4 = 494;
	public const KeyCode Joystick8Button5 = 495;
	public const KeyCode Joystick8Button6 = 496;
	public const KeyCode Joystick8Button7 = 497;
	public const KeyCode Joystick8Button8 = 498;
	public const KeyCode Joystick8Button9 = 499;
	public const KeyCode Joystick8Button10 = 500;
	public const KeyCode Joystick8Button11 = 501;
	public const KeyCode Joystick8Button12 = 502;
	public const KeyCode Joystick8Button13 = 503;
	public const KeyCode Joystick8Button14 = 504;
	public const KeyCode Joystick8Button15 = 505;
	public const KeyCode Joystick8Button16 = 506;
	public const KeyCode Joystick8Button17 = 507;
	public const KeyCode Joystick8Button18 = 508;
	public const KeyCode Joystick8Button19 = 509;
}

// Namespace: UnityEngine
public interface ILogger : ILogHandler // TypeDefIndex: 9639
{
	// Properties
	public abstract ILogHandler logHandler { get; }
	public abstract bool logEnabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ILogHandler get_logHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_logEnabled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Log(LogType logType, object message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Log(LogType logType, object message, Object context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Log(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LogWarning(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LogError(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LogFormat(LogType logType, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void LogException(Exception exception);
}

// Namespace: UnityEngine
public interface ILogHandler // TypeDefIndex: 9640
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogFormat(LogType logType, Object context, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogException(Exception exception, Object context);
}

// Namespace: UnityEngine
public class Logger : ILogger, ILogHandler // TypeDefIndex: 9641
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <logEnabled>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x231B040 Offset: 0x2319640 VA: 0x18231B040
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 15
	public void set_logHandler(ILogHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40 Slot: 16
	public void set_logEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30 Slot: 17
	public LogType get_filterLogType() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40 Slot: 18
	public void set_filterLogType(LogType value) { }

	// RVA: 0x231A700 Offset: 0x2318D00 VA: 0x18231A700 Slot: 19
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x231A5D0 Offset: 0x2318BD0 VA: 0x18231A5D0
	private static string GetString(object message) { }

	// RVA: 0x231ADD0 Offset: 0x23193D0 VA: 0x18231ADD0 Slot: 6
	public void Log(LogType logType, object message) { }

	// RVA: 0x231AF00 Offset: 0x2319500 VA: 0x18231AF00 Slot: 7
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x231AC50 Offset: 0x2319250 VA: 0x18231AC50 Slot: 8
	public void Log(string tag, object message) { }

	// RVA: 0x231AAD0 Offset: 0x23190D0 VA: 0x18231AAD0 Slot: 9
	public void LogWarning(string tag, object message) { }

	// RVA: 0x231A720 Offset: 0x2318D20 VA: 0x18231A720 Slot: 10
	public void LogError(string tag, object message) { }

	// RVA: 0x231A920 Offset: 0x2318F20 VA: 0x18231A920 Slot: 12
	public void LogException(Exception exception) { }

	// RVA: 0x231A8A0 Offset: 0x2318EA0 VA: 0x18231A8A0 Slot: 14
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x231A990 Offset: 0x2318F90 VA: 0x18231A990 Slot: 11
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x231AA30 Offset: 0x2319030 VA: 0x18231AA30 Slot: 13
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter // TypeDefIndex: 9642
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x232C670 Offset: 0x232AC70 VA: 0x18232C670
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x232C500 Offset: 0x232AB00 VA: 0x18232C500
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x232C420 Offset: 0x232AA20 VA: 0x18232C420
	public static void Init() { }

	// RVA: 0x232C760 Offset: 0x232AD60 VA: 0x18232C760 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x232C6A0 Offset: 0x232ACA0 VA: 0x18232C6A0 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x232C680 Offset: 0x232AC80 VA: 0x18232C680 Slot: 17
	public override void Write(string s) { }

	// RVA: 0x232C6E0 Offset: 0x232ACE0 VA: 0x18232C6E0 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x232C710 Offset: 0x232AD10 VA: 0x18232C710
	public void .ctor() { }

	// RVA: 0x232C4C0 Offset: 0x232AAC0 VA: 0x18232C4C0
	private static void WriteStringToUnityLogImpl_Injected(ref ManagedSpanWrapper s) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("ColorRGBAf")]
[DefaultMember("Item")]
[NativeHeader("Runtime/Math/Color.h")]
public struct Color : IEquatable<Color>, IFormattable // TypeDefIndex: 9643
{
	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color clear { get; }
	public Color linear { get; }
	public float maxColorComponent { get; }

	// Methods

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x2317240 Offset: 0x2315840 VA: 0x182317240
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x2316FA0 Offset: 0x23155A0 VA: 0x182316FA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2317230 Offset: 0x2315830 VA: 0x182317230
	public string ToString(string format) { }

	// RVA: 0x2316FB0 Offset: 0x23155B0 VA: 0x182316FB0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x6FC030 Offset: 0x6FA630 VA: 0x1806FC030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23168A0 Offset: 0x2314EA0 VA: 0x1823168A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2316980 Offset: 0x2314F80 VA: 0x182316980 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x2317390 Offset: 0x2315990 VA: 0x182317390
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x23175C0 Offset: 0x2315BC0 VA: 0x1823175C0
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x2317560 Offset: 0x2315B60 VA: 0x182317560
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x2317510 Offset: 0x2315B10 VA: 0x182317510
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x23173F0 Offset: 0x23159F0 VA: 0x1823173F0
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x2317410 Offset: 0x2315A10 VA: 0x182317410
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x23174A0 Offset: 0x2315AA0 VA: 0x1823174A0
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x2316D60 Offset: 0x2315360 VA: 0x182316D60
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x2316CE0 Offset: 0x23152E0 VA: 0x182316CE0
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2316E00 Offset: 0x2315400 VA: 0x182316E00
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x2317370 Offset: 0x2315970 VA: 0x182317370
	public static Color get_red() { }

	// RVA: 0x23172A0 Offset: 0x23158A0 VA: 0x1823172A0
	public static Color get_green() { }

	// RVA: 0x2317270 Offset: 0x2315870 VA: 0x182317270
	public static Color get_blue() { }

	// RVA: 0x3A43A0 Offset: 0x3A29A0 VA: 0x1803A43A0
	public static Color get_white() { }

	// RVA: 0x2317260 Offset: 0x2315860 VA: 0x182317260
	public static Color get_black() { }

	// RVA: 0x2317380 Offset: 0x2315980 VA: 0x182317380
	public static Color get_yellow() { }

	// RVA: 0x2317280 Offset: 0x2315880 VA: 0x182317280
	public static Color get_cyan() { }

	// RVA: 0x2317340 Offset: 0x2315940 VA: 0x182317340
	public static Color get_magenta() { }

	// RVA: 0x2317290 Offset: 0x2315890 VA: 0x182317290
	public static Color get_gray() { }

	// RVA: 0x8AFA20 Offset: 0x8AE020 VA: 0x1808AFA20
	public static Color get_clear() { }

	// RVA: 0x23172B0 Offset: 0x23158B0 VA: 0x1823172B0
	public Color get_linear() { }

	// RVA: 0x2317350 Offset: 0x2315950 VA: 0x182317350
	public float get_maxColorComponent() { }

	// RVA: 0x2317480 Offset: 0x2315A80 VA: 0x182317480
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x2317480 Offset: 0x2315A80 VA: 0x182317480
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x2316F00 Offset: 0x2315500 VA: 0x182316F00
	public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V) { }

	// RVA: 0x2316E50 Offset: 0x2315450 VA: 0x182316E50
	private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V) { }

	// RVA: 0x2316A00 Offset: 0x2315000 VA: 0x182316A00
	public static Color HSVToRGB(float H, float S, float V) { }

	// RVA: 0x2316A30 Offset: 0x2315030 VA: 0x182316A30
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[DefaultMember("Item")]
public struct Color32 : IFormattable // TypeDefIndex: 9644
{
	// Fields
	[Ignore(DoesNotContributeToSize = True)]
	private int rgba; // 0x0
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

	// Methods

	// RVA: 0x1F72B70 Offset: 0x1F71170 VA: 0x181F72B70
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x2158C20 Offset: 0x2157220 VA: 0x182158C20
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x23162E0 Offset: 0x23148E0 VA: 0x1823162E0
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x23162D0 Offset: 0x23148D0 VA: 0x1823162D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2316070 Offset: 0x2314670 VA: 0x182316070 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Math/ColorUtility.h")]
public class ColorUtility // TypeDefIndex: 9645
{
	// Methods

	[FreeFunction("TryParseHtmlColor", True)]
	// RVA: 0x23163B0 Offset: 0x23149B0 VA: 0x1823163B0
	internal static bool DoTryParseHtmlColor(string htmlString, out Color32 color) { }

	// RVA: 0x2316800 Offset: 0x2314E00 VA: 0x182316800
	public static bool TryParseHtmlString(string htmlString, out Color color) { }

	// RVA: 0x2316550 Offset: 0x2314B50 VA: 0x182316550
	public static string ToHtmlStringRGBA(Color color) { }

	// RVA: 0x2316360 Offset: 0x2314960 VA: 0x182316360
	private static bool DoTryParseHtmlColor_Injected(ref ManagedSpanWrapper htmlString, out Color32 color) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct GradientColorKey // TypeDefIndex: 9646
{
	// Fields
	public Color color; // 0x0
	public float time; // 0x10
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct GradientAlphaKey // TypeDefIndex: 9647
{
	// Fields
	public float alpha; // 0x0
	public float time; // 0x4
}

// Namespace: UnityEngine
public enum GradientMode // TypeDefIndex: 9648
{
	// Fields
	public int value__; // 0x0
	public const GradientMode Blend = 0;
	public const GradientMode Fixed = 1;
	public const GradientMode PerceptualBlend = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient> // TypeDefIndex: 9650
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	internal IntPtr m_Ptr; // 0x10
	private bool m_RequiresNativeCleanup; // 0x18

	// Properties
	public GradientColorKey[] colorKeys { get; set; }
	public GradientAlphaKey[] alphaKeys { get; set; }
	[NativeProperty(IsThreadSafe = True)]
	public GradientMode mode { get; set; }

	// Methods

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x2319360 Offset: 0x2317960 VA: 0x182319360
	private static IntPtr Init() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2318F20 Offset: 0x2317520 VA: 0x182318F20
	private void Cleanup() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x23193E0 Offset: 0x23179E0 VA: 0x1823193E0
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCode]
	// RVA: 0x2319440 Offset: 0x2317A40 VA: 0x182319440
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	// RVA: 0x22EFCC0 Offset: 0x22EE2C0 VA: 0x1822EFCC0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x23192C0 Offset: 0x23178C0 VA: 0x1823192C0 Slot: 1
	protected override void Finalize() { }

	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2319240 Offset: 0x2317840 VA: 0x182319240
	public Color Evaluate(float time) { }

	[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2319630 Offset: 0x2317C30 VA: 0x182319630
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2319980 Offset: 0x2317F80 VA: 0x182319980
	public void set_colorKeys(GradientColorKey[] value) { }

	[FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x23194D0 Offset: 0x2317AD0 VA: 0x1823194D0
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2319830 Offset: 0x2317E30 VA: 0x182319830
	public void set_alphaKeys(GradientAlphaKey[] value) { }

	// RVA: 0x2319780 Offset: 0x2317D80 VA: 0x182319780
	public GradientMode get_mode() { }

	// RVA: 0x2319AC0 Offset: 0x23180C0 VA: 0x182319AC0
	public void set_mode(GradientMode value) { }

	// RVA: 0x2318F80 Offset: 0x2317580 VA: 0x182318F80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2319100 Offset: 0x2317700 VA: 0x182319100 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x2319350 Offset: 0x2317950 VA: 0x182319350 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2318EE0 Offset: 0x23174E0 VA: 0x182318EE0
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	// RVA: 0x2319390 Offset: 0x2317990 VA: 0x182319390
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	// RVA: 0x23191E0 Offset: 0x23177E0 VA: 0x1823191E0
	private static void Evaluate_Injected(IntPtr _unity_self, float time, out Color ret) { }

	// RVA: 0x23195E0 Offset: 0x2317BE0 VA: 0x1823195E0
	private static void get_colorKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	// RVA: 0x2319930 Offset: 0x2317F30 VA: 0x182319930
	private static void set_colorKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x2319480 Offset: 0x2317A80 VA: 0x182319480
	private static void get_alphaKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	// RVA: 0x23197E0 Offset: 0x2317DE0 VA: 0x1823197E0
	private static void set_alphaKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x2319740 Offset: 0x2317D40 VA: 0x182319740
	private static GradientMode get_mode_Injected(IntPtr _unity_self) { }

	// RVA: 0x2319A80 Offset: 0x2318080 VA: 0x182319A80
	private static void set_mode_Injected(IntPtr _unity_self, GradientMode value) { }
}

// Namespace: UnityEngine
[Serializable]
public struct FrustumPlanes // TypeDefIndex: 9651
{
	// Fields
	public float left; // 0x0
	public float right; // 0x4
	public float bottom; // 0x8
	public float top; // 0xC
	public float zNear; // 0x10
	public float zFar; // 0x14
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("Matrix4x4f")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[DefaultMember("Item")]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 9652
{
	// Fields
	[NativeName("m_Data[0]")]
	public float m00; // 0x0
	[NativeName("m_Data[1]")]
	public float m10; // 0x4
	[NativeName("m_Data[2]")]
	public float m20; // 0x8
	[NativeName("m_Data[3]")]
	public float m30; // 0xC
	[NativeName("m_Data[4]")]
	public float m01; // 0x10
	[NativeName("m_Data[5]")]
	public float m11; // 0x14
	[NativeName("m_Data[6]")]
	public float m21; // 0x18
	[NativeName("m_Data[7]")]
	public float m31; // 0x1C
	[NativeName("m_Data[8]")]
	public float m02; // 0x20
	[NativeName("m_Data[9]")]
	public float m12; // 0x24
	[NativeName("m_Data[10]")]
	public float m22; // 0x28
	[NativeName("m_Data[11]")]
	public float m32; // 0x2C
	[NativeName("m_Data[12]")]
	public float m03; // 0x30
	[NativeName("m_Data[13]")]
	public float m13; // 0x34
	[NativeName("m_Data[14]")]
	public float m23; // 0x38
	[NativeName("m_Data[15]")]
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }

	// Methods

	[ThreadSafe]
	// RVA: 0x231B8A0 Offset: 0x2319EA0 VA: 0x18231B8A0
	private Quaternion GetRotation() { }

	[ThreadSafe]
	// RVA: 0x231B7E0 Offset: 0x2319DE0 VA: 0x18231B7E0
	private Vector3 GetLossyScale() { }

	[ThreadSafe]
	// RVA: 0x231B0D0 Offset: 0x23196D0 VA: 0x18231B0D0
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x231CED0 Offset: 0x231B4D0 VA: 0x18231CED0
	public Quaternion get_rotation() { }

	// RVA: 0x231CE60 Offset: 0x231B460 VA: 0x18231CE60
	public Vector3 get_lossyScale() { }

	// RVA: 0x231CCE0 Offset: 0x231B2E0 VA: 0x18231CCE0
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	// RVA: 0x231C1C0 Offset: 0x231A7C0 VA: 0x18231C1C0
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	// RVA: 0x231BA30 Offset: 0x231A030 VA: 0x18231BA30
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	// RVA: 0x231BAD0 Offset: 0x231A0D0 VA: 0x18231BAD0
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x231CDB0 Offset: 0x231B3B0 VA: 0x18231CDB0
	public Matrix4x4 get_inverse() { }

	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = True)]
	// RVA: 0x231BDD0 Offset: 0x231A3D0 VA: 0x18231BDD0
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = True)]
	// RVA: 0x231B460 Offset: 0x2319A60 VA: 0x18231B460
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x231B370 Offset: 0x2319970 VA: 0x18231B370
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0x231CB00 Offset: 0x231B100 VA: 0x18231CB00
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x231CCD0 Offset: 0x231B2D0 VA: 0x18231CCD0
	public float get_Item(int row, int column) { }

	// RVA: 0x231D6F0 Offset: 0x231BCF0 VA: 0x18231D6F0
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x231CB70 Offset: 0x231B170 VA: 0x18231CB70
	public float get_Item(int index) { }

	// RVA: 0x231D590 Offset: 0x231BB90 VA: 0x18231D590
	public void set_Item(int index, float value) { }

	// RVA: 0x231B5E0 Offset: 0x2319BE0 VA: 0x18231B5E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231B130 Offset: 0x2319730 VA: 0x18231B130 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x231B1E0 Offset: 0x23197E0 VA: 0x18231B1E0 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x231D050 Offset: 0x231B650 VA: 0x18231D050
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x231CF30 Offset: 0x231B530 VA: 0x18231CF30
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x231B510 Offset: 0x2319B10 VA: 0x18231B510
	public Vector4 GetColumn(int index) { }

	// RVA: 0x231B8F0 Offset: 0x2319EF0 VA: 0x18231B8F0
	public Vector4 GetRow(int index) { }

	// RVA: 0x231B830 Offset: 0x2319E30 VA: 0x18231B830
	public Vector3 GetPosition() { }

	// RVA: 0x231C0E0 Offset: 0x231A6E0 VA: 0x18231C0E0
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x231BBD0 Offset: 0x231A1D0 VA: 0x18231BBD0
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x231BB30 Offset: 0x231A130 VA: 0x18231BB30
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x231BCC0 Offset: 0x231A2C0 VA: 0x18231BCC0
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x231C030 Offset: 0x231A630 VA: 0x18231C030
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x231C940 Offset: 0x231AF40 VA: 0x18231C940
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x231BE80 Offset: 0x231A480 VA: 0x18231BE80
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x231CD50 Offset: 0x231B350 VA: 0x18231CD50
	public static Matrix4x4 get_identity() { }

	// RVA: 0x231C240 Offset: 0x231A840 VA: 0x18231C240 Slot: 3
	public override string ToString() { }

	// RVA: 0x231C250 Offset: 0x231A850 VA: 0x18231C250 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x231C9E0 Offset: 0x231AFE0 VA: 0x18231C9E0
	private static void .cctor() { }

	// RVA: 0x231B850 Offset: 0x2319E50 VA: 0x18231B850
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0x231B790 Offset: 0x2319D90 VA: 0x18231B790
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x231B080 Offset: 0x2319680 VA: 0x18231B080
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x231C150 Offset: 0x231A750 VA: 0x18231C150
	private static void TRS_Injected(in Vector3 pos, in Quaternion q, in Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x231B9E0 Offset: 0x2319FE0 VA: 0x18231B9E0
	private static bool Inverse3DAffine_Injected(in Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0x231BA80 Offset: 0x231A080 VA: 0x18231BA80
	private static void Inverse_Injected(in Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x231BD50 Offset: 0x231A350 VA: 0x18231BD50
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x231B2F0 Offset: 0x23198F0 VA: 0x18231B2F0
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[DefaultMember("Item")]
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[NativeClass("Vector3f")]
[Il2CppEagerStaticClassConstruction]
public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 9653
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }
	public static Vector3 positiveInfinity { get; }

	// Methods

	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x232D2E0 Offset: 0x232B8E0 VA: 0x18232D2E0
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = True)]
	// RVA: 0x232CED0 Offset: 0x232B4D0 VA: 0x18232CED0
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x232CED0 Offset: 0x232B4D0 VA: 0x18232CED0
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	// RVA: 0x232CBB0 Offset: 0x232B1B0 VA: 0x18232CBB0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x232CB60 Offset: 0x232B160 VA: 0x18232CB60
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x232CD50 Offset: 0x232B350 VA: 0x18232CD50
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	// RVA: 0x3B2F50 Offset: 0x3B1550 VA: 0x1803B2F50
	public float get_Item(int index) { }

	// RVA: 0x1722980 Offset: 0x1720F80 VA: 0x181722980
	public void set_Item(int index, float value) { }

	// RVA: 0x17E7430 Offset: 0x17E5A30 VA: 0x1817E7430
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x232D740 Offset: 0x232BD40 VA: 0x18232D740
	public void .ctor(float x, float y) { }

	// RVA: 0x17E7430 Offset: 0x17E5A30 VA: 0x1817E7430
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x232D210 Offset: 0x232B810 VA: 0x18232D210
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x232D240 Offset: 0x232B840 VA: 0x18232D240
	public void Scale(Vector3 scale) { }

	// RVA: 0x232C8E0 Offset: 0x232AEE0 VA: 0x18232C8E0
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x232CB00 Offset: 0x232B100 VA: 0x18232CB00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232CA40 Offset: 0x232B040 VA: 0x18232CA40 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x18142B0 Offset: 0x18128B0 VA: 0x1818142B0 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x232D190 Offset: 0x232B790 VA: 0x18232D190
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x345610 Offset: 0x343C10 VA: 0x180345610
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x345500 Offset: 0x343B00 VA: 0x180345500
	public void Normalize() { }

	// RVA: 0x232D990 Offset: 0x232BF90 VA: 0x18232D990
	public Vector3 get_normalized() { }

	// RVA: 0x232CA10 Offset: 0x232B010 VA: 0x18232CA10
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x232D050 Offset: 0x232B650 VA: 0x18232D050
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x232CF20 Offset: 0x232B520 VA: 0x18232CF20
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x232C770 Offset: 0x232AD70 VA: 0x18232C770
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x17B6040 Offset: 0x17B4640 VA: 0x1817B6040
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x232C940 Offset: 0x232AF40 VA: 0x18232C940
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x232CC20 Offset: 0x232B220 VA: 0x18232CC20
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x232D8A0 Offset: 0x232BEA0 VA: 0x18232D8A0
	public float get_magnitude() { }

	// RVA: 0x232D350 Offset: 0x232B950 VA: 0x18232D350
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x232D350 Offset: 0x232B950 VA: 0x18232D350
	public float get_sqrMagnitude() { }

	// RVA: 0x232CD10 Offset: 0x232B310 VA: 0x18232CD10
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x232CCD0 Offset: 0x232B2D0 VA: 0x18232CCD0
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x232DB20 Offset: 0x232C120 VA: 0x18232DB20
	public static Vector3 get_zero() { }

	// RVA: 0x232D9E0 Offset: 0x232BFE0 VA: 0x18232D9E0
	public static Vector3 get_one() { }

	// RVA: 0x232D800 Offset: 0x232BE00 VA: 0x18232D800
	public static Vector3 get_forward() { }

	// RVA: 0x232D760 Offset: 0x232BD60 VA: 0x18232D760
	public static Vector3 get_back() { }

	// RVA: 0x232DAD0 Offset: 0x232C0D0 VA: 0x18232DAD0
	public static Vector3 get_up() { }

	// RVA: 0x232D7B0 Offset: 0x232BDB0 VA: 0x18232D7B0
	public static Vector3 get_down() { }

	// RVA: 0x232D850 Offset: 0x232BE50 VA: 0x18232D850
	public static Vector3 get_left() { }

	// RVA: 0x232DA80 Offset: 0x232C080 VA: 0x18232DA80
	public static Vector3 get_right() { }

	// RVA: 0x232DA30 Offset: 0x232C030 VA: 0x18232DA30
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x345B30 Offset: 0x344130 VA: 0x180345B30
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x345B90 Offset: 0x344190 VA: 0x180345B90
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x232DC70 Offset: 0x232C270 VA: 0x18232DC70
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x232DC40 Offset: 0x232C240 VA: 0x18232DC40
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x232DC10 Offset: 0x232C210 VA: 0x18232DC10
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x345B60 Offset: 0x344160 VA: 0x180345B60
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x232DB70 Offset: 0x232C170 VA: 0x18232DB70
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x232DBB0 Offset: 0x232C1B0 VA: 0x18232DBB0
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x232D390 Offset: 0x232B990 VA: 0x18232D390 Slot: 3
	public override string ToString() { }

	// RVA: 0x232D380 Offset: 0x232B980 VA: 0x18232D380
	public string ToString(string format) { }

	// RVA: 0x232D3A0 Offset: 0x232B9A0 VA: 0x18232D3A0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x232D5C0 Offset: 0x232BBC0 VA: 0x18232D5C0
	private static void .cctor() { }

	// RVA: 0x232D270 Offset: 0x232B870 VA: 0x18232D270
	private static void Slerp_Injected(in Vector3 a, in Vector3 b, float t, out Vector3 ret) { }
}

// Namespace: UnityEngine
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
[DefaultMember("Item")]
public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 9654
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public float Item { get; }
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; }

	// Methods

	[FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
	// RVA: 0x231E5A0 Offset: 0x231CBA0 VA: 0x18231E5A0
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x231E8E0 Offset: 0x231CEE0 VA: 0x18231E8E0
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x231EE40 Offset: 0x231D440 VA: 0x18231EE40
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = True)]
	// RVA: 0x231ED60 Offset: 0x231D360 VA: 0x18231ED60
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
	// RVA: 0x231E9B0 Offset: 0x231CFB0 VA: 0x18231E9B0
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	// RVA: 0x231E650 Offset: 0x231CC50 VA: 0x18231E650
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	// RVA: 0x231E840 Offset: 0x231CE40 VA: 0x18231E840
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = True)]
	// RVA: 0x231E790 Offset: 0x231CD90 VA: 0x18231E790
	private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) { }

	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	// RVA: 0x231E210 Offset: 0x231C810 VA: 0x18231E210
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	// RVA: 0x231EB40 Offset: 0x231D140 VA: 0x18231EB40
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocs]
	// RVA: 0x231EA80 Offset: 0x231D080 VA: 0x18231EA80
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x19C8DE0 Offset: 0x19C73E0 VA: 0x1819C8DE0
	public float get_Item(int index) { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x231F2F0 Offset: 0x231D8F0 VA: 0x18231F2F0
	public static Quaternion get_identity() { }

	// RVA: 0x447620 Offset: 0x445C20 VA: 0x180447620
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x231F3A0 Offset: 0x231D9A0 VA: 0x18231F3A0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x231E930 Offset: 0x231CF30 VA: 0x18231E930
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x231F340 Offset: 0x231D940 VA: 0x18231F340
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2158D60 Offset: 0x2157360 VA: 0x182158D60
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x231E300 Offset: 0x231C900 VA: 0x18231E300
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x231E270 Offset: 0x231C870 VA: 0x18231E270
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x231E6A0 Offset: 0x231CCA0 VA: 0x18231E6A0
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x231F1E0 Offset: 0x231D7E0 VA: 0x18231F1E0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x231E4C0 Offset: 0x231CAC0 VA: 0x18231E4C0
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x231E420 Offset: 0x231CA20 VA: 0x18231E420
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x231EEB0 Offset: 0x231D4B0 VA: 0x18231EEB0
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	// RVA: 0x231EBA0 Offset: 0x231D1A0 VA: 0x18231EBA0
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x6FC260 Offset: 0x6FA860 VA: 0x1806FC260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231E340 Offset: 0x231C940 VA: 0x18231E340 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2316980 Offset: 0x2314F80 VA: 0x182316980 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x231F190 Offset: 0x231D790 VA: 0x18231F190 Slot: 3
	public override string ToString() { }

	// RVA: 0x231EF10 Offset: 0x231D510 VA: 0x18231EF10 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x231F1A0 Offset: 0x231D7A0 VA: 0x18231F1A0
	private static void .cctor() { }

	// RVA: 0x231E540 Offset: 0x231CB40 VA: 0x18231E540
	private static void FromToRotation_Injected(in Vector3 fromDirection, in Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x231E890 Offset: 0x231CE90 VA: 0x18231E890
	private static void Inverse_Injected(in Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x231EDD0 Offset: 0x231D3D0 VA: 0x18231EDD0
	private static void Slerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x231ECF0 Offset: 0x231D2F0 VA: 0x18231ECF0
	private static void SlerpUnclamped_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x231E940 Offset: 0x231CF40 VA: 0x18231E940
	private static void Lerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x231E600 Offset: 0x231CC00 VA: 0x18231E600
	private static void Internal_FromEulerRad_Injected(in Vector3 euler, out Quaternion ret) { }

	// RVA: 0x231E7F0 Offset: 0x231CDF0 VA: 0x18231E7F0
	private static void Internal_ToEulerRad_Injected(in Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x231E730 Offset: 0x231CD30 VA: 0x18231E730
	private static void Internal_ToAxisAngleRad_Injected(in Quaternion q, out Vector3 axis, out float angle) { }

	// RVA: 0x231E1B0 Offset: 0x231C7B0 VA: 0x18231E1B0
	private static void AngleAxis_Injected(float angle, in Vector3 axis, out Quaternion ret) { }

	// RVA: 0x231EA20 Offset: 0x231D020 VA: 0x18231EA20
	private static void LookRotation_Injected(in Vector3 forward, in Vector3 upwards, out Quaternion ret) { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[NativeHeader("Runtime/Math/FloatConversion.h")]
public struct Mathf // TypeDefIndex: 9655
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2338CE0 Offset: 0x23372E0 VA: 0x182338CE0
	public static float GammaToLinearSpace(float value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2338E50 Offset: 0x2337450 VA: 0x182338E50
	public static float LinearToGammaSpace(float value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2338A30 Offset: 0x2337030 VA: 0x182338A30
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = True)]
	// RVA: 0x23390A0 Offset: 0x23376A0 VA: 0x1823390A0
	public static float PerlinNoise(float x, float y) { }

	// RVA: 0x2339420 Offset: 0x2337A20 VA: 0x182339420
	public static float Sin(float f) { }

	// RVA: 0x2338A80 Offset: 0x2337080 VA: 0x182338A80
	public static float Cos(float f) { }

	// RVA: 0x23396A0 Offset: 0x2337CA0 VA: 0x1823396A0
	public static float Tan(float f) { }

	// RVA: 0x23386E0 Offset: 0x2336CE0 VA: 0x1823386E0
	public static float Asin(float f) { }

	// RVA: 0x23385F0 Offset: 0x2336BF0 VA: 0x1823385F0
	public static float Acos(float f) { }

	// RVA: 0x23387B0 Offset: 0x2336DB0 VA: 0x1823387B0
	public static float Atan(float f) { }

	// RVA: 0x2338740 Offset: 0x2336D40 VA: 0x182338740
	public static float Atan2(float y, float x) { }

	// RVA: 0x2339620 Offset: 0x2337C20 VA: 0x182339620
	public static float Sqrt(float f) { }

	// RVA: 0x2338540 Offset: 0x2336B40 VA: 0x182338540
	public static float Abs(float f) { }

	// RVA: 0x23385A0 Offset: 0x2336BA0 VA: 0x1823385A0
	public static int Abs(int value) { }

	// RVA: 0x2339050 Offset: 0x2337650 VA: 0x182339050
	public static float Min(float a, float b) { }

	// RVA: 0x2339060 Offset: 0x2337660 VA: 0x182339060
	public static int Min(int a, int b) { }

	// RVA: 0x2339040 Offset: 0x2337640 VA: 0x182339040
	public static float Max(float a, float b) { }

	// RVA: 0x2338FD0 Offset: 0x23375D0 VA: 0x182338FD0
	public static float Max(float[] values) { }

	// RVA: 0x2338FC0 Offset: 0x23375C0 VA: 0x182338FC0
	public static int Max(int a, int b) { }

	// RVA: 0x2339170 Offset: 0x2337770 VA: 0x182339170
	public static float Pow(float f, float p) { }

	// RVA: 0x2338BC0 Offset: 0x23371C0 VA: 0x182338BC0
	public static float Exp(float power) { }

	// RVA: 0x2338EF0 Offset: 0x23374F0 VA: 0x182338EF0
	public static float Log(float f, float p) { }

	// RVA: 0x2338F60 Offset: 0x2337560 VA: 0x182338F60
	public static float Log(float f) { }

	// RVA: 0x2338E90 Offset: 0x2337490 VA: 0x182338E90
	public static float Log10(float f) { }

	// RVA: 0x2338870 Offset: 0x2336E70 VA: 0x182338870
	public static float Ceil(float f) { }

	// RVA: 0x2338C80 Offset: 0x2337280 VA: 0x182338C80
	public static float Floor(float f) { }

	// RVA: 0x23393A0 Offset: 0x23379A0 VA: 0x1823393A0
	public static float Round(float f) { }

	// RVA: 0x2338810 Offset: 0x2336E10 VA: 0x182338810
	public static int CeilToInt(float f) { }

	// RVA: 0x2338C20 Offset: 0x2337220 VA: 0x182338C20
	public static int FloorToInt(float f) { }

	// RVA: 0x2339340 Offset: 0x2337940 VA: 0x182339340
	public static int RoundToInt(float f) { }

	// RVA: 0x2339400 Offset: 0x2337A00 VA: 0x182339400
	public static float Sign(float f) { }

	// RVA: 0x17B3F00 Offset: 0x17B2500 VA: 0x1817B3F00
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x2338970 Offset: 0x2336F70 VA: 0x182338970
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x17B3B90 Offset: 0x17B2190 VA: 0x1817B3B90
	public static float Clamp01(float value) { }

	// RVA: 0x2338E10 Offset: 0x2337410 VA: 0x182338E10
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x2338DF0 Offset: 0x23373F0 VA: 0x182338DF0
	public static float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x23395C0 Offset: 0x2337BC0 VA: 0x1823395C0
	public static float SmoothStep(float from, float to, float t) { }

	// RVA: 0x2338650 Offset: 0x2336C50 VA: 0x182338650
	public static bool Approximately(float a, float b) { }

	// RVA: 0x2339480 Offset: 0x2337A80 VA: 0x182339480
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x23391E0 Offset: 0x23377E0 VA: 0x1823391E0
	public static float Repeat(float t, float length) { }

	// RVA: 0x23390F0 Offset: 0x23376F0 VA: 0x1823390F0
	public static float PingPong(float t, float length) { }

	// RVA: 0x2338DA0 Offset: 0x23373A0 VA: 0x182338DA0
	public static float InverseLerp(float a, float b, float value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23388D0 Offset: 0x2336ED0 VA: 0x1823388D0
	internal static float ClampToFloat(double value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2338930 Offset: 0x2336F30 VA: 0x182338930
	internal static int ClampToInt(long value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2338950 Offset: 0x2336F50 VA: 0x182338950
	internal static uint ClampToUInt(long value) { }

	// RVA: 0x2338D20 Offset: 0x2337320 VA: 0x182338D20
	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2339240 Offset: 0x2337840 VA: 0x182339240
	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	// RVA: 0x2338AE0 Offset: 0x23370E0 VA: 0x182338AE0
	internal static double DiscardLeastSignificantDecimal(double v) { }

	// RVA: 0x2339070 Offset: 0x2337670 VA: 0x182339070
	public static int NextPowerOfTwo(int value) { }

	// RVA: 0x2338990 Offset: 0x2336F90 VA: 0x182338990
	public static int ClosestPowerOfTwo(int value) { }

	// RVA: 0x2338DE0 Offset: 0x23373E0 VA: 0x182338DE0
	public static bool IsPowerOfTwo(int value) { }

	// RVA: 0x2339700 Offset: 0x2337D00 VA: 0x182339700
	private static void .cctor() { }

	// RVA: 0x23389E0 Offset: 0x2336FE0 VA: 0x1823389E0
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstruction]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("Vector2f")]
[DefaultMember("Item")]
public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 9656
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 down { get; }
	public static Vector2 left { get; }
	public static Vector2 right { get; }
	public static Vector2 negativeInfinity { get; }

	// Methods

	// RVA: 0x2186400 Offset: 0x2184A00 VA: 0x182186400
	public float get_Item(int index) { }

	// RVA: 0x232DF60 Offset: 0x232C560 VA: 0x18232DF60
	public void set_Item(int index, float value) { }

	// RVA: 0xB1E9A0 Offset: 0xB1CFA0 VA: 0x180B1E9A0
	public void .ctor(float x, float y) { }

	// RVA: 0x234AE00 Offset: 0x2349400 VA: 0x18234AE00
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x234ADB0 Offset: 0x23493B0 VA: 0x18234ADB0
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x1813EA0 Offset: 0x18124A0 VA: 0x181813EA0
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x1774880 Offset: 0x1772E80 VA: 0x181774880
	public void Normalize() { }

	// RVA: 0x234B520 Offset: 0x2349B20 VA: 0x18234B520
	public Vector2 get_normalized() { }

	// RVA: 0x234B0C0 Offset: 0x23496C0 VA: 0x18234B0C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x234B0B0 Offset: 0x23496B0 VA: 0x18234B0B0
	public string ToString(string format) { }

	// RVA: 0x234B0D0 Offset: 0x23496D0 VA: 0x18234B0D0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x234AD70 Offset: 0x2349370 VA: 0x18234AD70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234ACD0 Offset: 0x23492D0 VA: 0x18234ACD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1813A90 Offset: 0x1812090 VA: 0x181813A90 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x2094640 Offset: 0x2092C40 VA: 0x182094640
	public static Vector2 Perpendicular(Vector2 inDirection) { }

	// RVA: 0x234ACA0 Offset: 0x23492A0 VA: 0x18234ACA0
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x234B420 Offset: 0x2349A20 VA: 0x18234B420
	public float get_magnitude() { }

	// RVA: 0x234B6A0 Offset: 0x2349CA0 VA: 0x18234B6A0
	public float get_sqrMagnitude() { }

	// RVA: 0x234A990 Offset: 0x2348F90 VA: 0x18234A990
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x234AEF0 Offset: 0x23494F0 VA: 0x18234AEF0
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x234ABF0 Offset: 0x23491F0 VA: 0x18234ABF0
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x234AAF0 Offset: 0x23490F0 VA: 0x18234AAF0
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x234AEB0 Offset: 0x23494B0 VA: 0x18234AEB0
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x234AE70 Offset: 0x2349470 VA: 0x18234AE70
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x18139F0 Offset: 0x1811FF0 VA: 0x1818139F0
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x1813EE0 Offset: 0x18124E0 VA: 0x181813EE0
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x1813EA0 Offset: 0x18124A0 VA: 0x181813EA0
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x1813A50 Offset: 0x1812050 VA: 0x181813A50
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x194B900 Offset: 0x1949F00 VA: 0x18194B900
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x1814060 Offset: 0x1812660 VA: 0x181814060
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x194B780 Offset: 0x1949D80 VA: 0x18194B780
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x1814030 Offset: 0x1812630 VA: 0x181814030
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x234B760 Offset: 0x2349D60 VA: 0x18234B760
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x234B7B0 Offset: 0x2349DB0 VA: 0x18234B7B0
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x2310A90 Offset: 0x230F090 VA: 0x182310A90
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x3B2F20 Offset: 0x3B1520 VA: 0x1803B2F20
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x234B710 Offset: 0x2349D10 VA: 0x18234B710
	public static Vector2 get_zero() { }

	// RVA: 0x234B600 Offset: 0x2349C00 VA: 0x18234B600
	public static Vector2 get_one() { }

	// RVA: 0x234B6C0 Offset: 0x2349CC0 VA: 0x18234B6C0
	public static Vector2 get_up() { }

	// RVA: 0x234B380 Offset: 0x2349980 VA: 0x18234B380
	public static Vector2 get_down() { }

	// RVA: 0x234B3D0 Offset: 0x23499D0 VA: 0x18234B3D0
	public static Vector2 get_left() { }

	// RVA: 0x234B650 Offset: 0x2349C50 VA: 0x18234B650
	public static Vector2 get_right() { }

	// RVA: 0x234B4D0 Offset: 0x2349AD0 VA: 0x18234B4D0
	public static Vector2 get_negativeInfinity() { }

	// RVA: 0x234B290 Offset: 0x2349890 VA: 0x18234B290
	private static void .cctor() { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[NativeType("Runtime/Math/Vector2Int.h")]
[Il2CppEagerStaticClassConstruction]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable // TypeDefIndex: 9657
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public static Vector2Int zero { get; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public int get_x() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_x(int value) { }

	// RVA: 0x9BF260 Offset: 0x9BD860 VA: 0x1809BF260
	public int get_y() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_y(int value) { }

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int x, int y) { }

	// RVA: 0x234A350 Offset: 0x2348950 VA: 0x18234A350
	public static float Distance(Vector2Int a, Vector2Int b) { }

	// RVA: 0x234A910 Offset: 0x2348F10 VA: 0x18234A910
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x234A4D0 Offset: 0x2348AD0 VA: 0x18234A4D0
	public static Vector2Int FloorToInt(Vector2 v) { }

	// RVA: 0x234A970 Offset: 0x2348F70 VA: 0x18234A970
	public static Vector2Int op_UnaryNegation(Vector2Int v) { }

	// RVA: 0x234A8D0 Offset: 0x2348ED0 VA: 0x18234A8D0
	public static Vector2Int op_Addition(Vector2Int a, Vector2Int b) { }

	// RVA: 0x234A950 Offset: 0x2348F50 VA: 0x18234A950
	public static Vector2Int op_Subtraction(Vector2Int a, Vector2Int b) { }

	// RVA: 0x234A8F0 Offset: 0x2348EF0 VA: 0x18234A8F0
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x234A930 Offset: 0x2348F30 VA: 0x18234A930
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x234A420 Offset: 0x2348A20 VA: 0x18234A420 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x234A400 Offset: 0x2348A00 VA: 0x18234A400 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x234A590 Offset: 0x2348B90 VA: 0x18234A590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234A790 Offset: 0x2348D90 VA: 0x18234A790 Slot: 3
	public override string ToString() { }

	// RVA: 0x234A5E0 Offset: 0x2348BE0 VA: 0x18234A5E0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x234A890 Offset: 0x2348E90 VA: 0x18234A890
	public static Vector2Int get_zero() { }

	// RVA: 0x234A7A0 Offset: 0x2348DA0 VA: 0x18234A7A0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstruction]
[UsedByNativeCode]
[DefaultMember("Item")]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable // TypeDefIndex: 9658
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C
	private static readonly Vector3Int s_Forward; // 0x48
	private static readonly Vector3Int s_Back; // 0x54

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int z { get; set; }

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
	public int get_z() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_z(int value) { }

	// RVA: 0xB263E0 Offset: 0xB249E0 VA: 0x180B263E0
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x234BC90 Offset: 0x234A290 VA: 0x18234BC90
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x234B800 Offset: 0x2349E00 VA: 0x18234B800 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x234B8D0 Offset: 0x2349ED0 VA: 0x18234B8D0 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x10250E0 Offset: 0x10236E0 VA: 0x1810250E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234B920 Offset: 0x2349F20 VA: 0x18234B920 Slot: 3
	public override string ToString() { }

	// RVA: 0x234B930 Offset: 0x2349F30 VA: 0x18234B930 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x234BB40 Offset: 0x234A140 VA: 0x18234BB40
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/Vector4.h")]
[NativeClass("Vector4f")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[DefaultMember("Item")]
public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 9659
{
	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0x19C8E70 Offset: 0x19C7470 VA: 0x1819C8E70
	public float get_Item(int index) { }

	// RVA: 0x19C8F00 Offset: 0x19C7500 VA: 0x1819C8F00
	public void set_Item(int index, float value) { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x234C220 Offset: 0x234A820 VA: 0x18234C220
	public void .ctor(float x, float y) { }

	// RVA: 0x6FC260 Offset: 0x6FA860 VA: 0x1806FC260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x234BCB0 Offset: 0x234A2B0 VA: 0x18234BCB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x177A1C0 Offset: 0x17787C0 VA: 0x18177A1C0 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x234BE40 Offset: 0x234A440 VA: 0x18234BE40
	public void Normalize() { }

	// RVA: 0x231E300 Offset: 0x231C900 VA: 0x18231E300
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x234BD70 Offset: 0x234A370 VA: 0x18234BD70
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x234C280 Offset: 0x234A880 VA: 0x18234C280
	public float get_sqrMagnitude() { }

	// RVA: 0x234C2D0 Offset: 0x234A8D0 VA: 0x18234C2D0
	public static Vector4 get_zero() { }

	// RVA: 0x234C230 Offset: 0x234A830 VA: 0x18234C230
	public static Vector4 get_one() { }

	// RVA: 0x2317390 Offset: 0x2315990 VA: 0x182317390
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x23175C0 Offset: 0x2315BC0 VA: 0x1823175C0
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	// RVA: 0x2317510 Offset: 0x2315B10 VA: 0x182317510
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x23173F0 Offset: 0x23159F0 VA: 0x1823173F0
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x234C320 Offset: 0x234A920 VA: 0x18234C320
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x234C420 Offset: 0x234AA20 VA: 0x18234C420
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x234C3A0 Offset: 0x234A9A0 VA: 0x18234C3A0
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x234C380 Offset: 0x234A980 VA: 0x18234C380
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x234C3E0 Offset: 0x234A9E0 VA: 0x18234C3E0
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x2310A90 Offset: 0x230F090 VA: 0x182310A90
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x234C180 Offset: 0x234A780 VA: 0x18234C180 Slot: 3
	public override string ToString() { }

	// RVA: 0x234C170 Offset: 0x234A770 VA: 0x18234C170
	public string ToString(string format) { }

	// RVA: 0x234BEF0 Offset: 0x234A4F0 VA: 0x18234BEF0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x234C190 Offset: 0x234A790 VA: 0x18234C190
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal struct TypeDispatchData : IDisposable // TypeDefIndex: 9660
{
	// Fields
	public Object[] changed; // 0x0
	public NativeArray<int> changedID; // 0x8
	public NativeArray<int> destroyedID; // 0x18

	// Methods

	// RVA: 0x2348010 Offset: 0x2346610 VA: 0x182348010 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
internal struct TransformDispatchData : IDisposable // TypeDefIndex: 9661
{
	// Fields
	public NativeArray<int> transformedID; // 0x0
	public NativeArray<int> parentID; // 0x10
	public NativeArray<Matrix4x4> localToWorldMatrices; // 0x20
	public NativeArray<Vector3> positions; // 0x30
	public NativeArray<Quaternion> rotations; // 0x40
	public NativeArray<Vector3> scales; // 0x50

	// Methods

	// RVA: 0x2347F60 Offset: 0x2346560 VA: 0x182347F60 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
[StaticAccessor("GetObjectDispatcher()", 0)]
internal sealed class ObjectDispatcher // TypeDefIndex: 9663
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static Action<Object[], IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch; // 0x0
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch; // 0x8

	// Methods

	// RVA: 0x233BCF0 Offset: 0x233A2F0 VA: 0x18233BCF0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
[MovedFrom("UnityEditor")]
internal class NumericFieldDraggerUtility // TypeDefIndex: 9664
{
	// Fields
	private static bool s_UseYSign; // 0x0

	// Methods

	// RVA: 0x233B870 Offset: 0x2339E70 VA: 0x18233B870
	public static float Acceleration(bool shiftPressed, bool altPressed) { }

	// RVA: 0x233BBE0 Offset: 0x233A1E0 VA: 0x18233BBE0
	public static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

	// RVA: 0x233B970 Offset: 0x2339F70 VA: 0x18233B970
	public static double CalculateFloatDragSensitivity(double value) { }

	// RVA: 0x233B8B0 Offset: 0x2339EB0 VA: 0x18233B8B0
	public static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue) { }

	// RVA: 0x233BA30 Offset: 0x233A030 VA: 0x18233BA30
	public static long CalculateIntDragSensitivity(long value) { }

	// RVA: 0x233BAE0 Offset: 0x233A0E0 VA: 0x18233BAE0
	public static ulong CalculateIntDragSensitivity(ulong value) { }

	// RVA: 0x233BB60 Offset: 0x233A160 VA: 0x18233BB60
	public static double CalculateIntDragSensitivity(double value) { }

	// RVA: 0x233BA50 Offset: 0x233A050 VA: 0x18233BA50
	public static long CalculateIntDragSensitivity(long value, long minValue, long maxValue) { }
}

// Namespace: UnityEngine
internal interface IPlayerEditorConnectionNative // TypeDefIndex: 9665
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DisconnectAll();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TrySendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Poll();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected();
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 9666
{
	// Methods

	// RVA: 0x233F800 Offset: 0x233DE00 VA: 0x18233F800 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x233F8F0 Offset: 0x233DEF0 VA: 0x18233F8F0 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x233F0B0 Offset: 0x233D6B0 VA: 0x18233F0B0 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x233F7B0 Offset: 0x233DDB0 VA: 0x18233F7B0 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x233F9E0 Offset: 0x233DFE0 VA: 0x18233F9E0 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x233F050 Offset: 0x233D650 VA: 0x18233F050 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x233F080 Offset: 0x233D680 VA: 0x18233F080 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x233F020 Offset: 0x233D620 VA: 0x18233F020 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	// RVA: 0x233F080 Offset: 0x233D680 VA: 0x18233F080
	private static bool IsConnected() { }

	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	// RVA: 0x233F050 Offset: 0x233D650 VA: 0x18233F050
	private static void Initialize() { }

	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	// RVA: 0x233F120 Offset: 0x233D720 VA: 0x18233F120
	private static void RegisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	// RVA: 0x233FA70 Offset: 0x233E070 VA: 0x18233FA70
	private static void UnregisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	// RVA: 0x233F2F0 Offset: 0x233D8F0 VA: 0x18233F2F0
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	// RVA: 0x233F580 Offset: 0x233DB80 VA: 0x18233F580
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	// RVA: 0x233F0B0 Offset: 0x233D6B0 VA: 0x18233F0B0
	private static void PollInternal() { }

	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	// RVA: 0x233F020 Offset: 0x233D620 VA: 0x18233F020
	private static void DisconnectAll() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x233F0E0 Offset: 0x233D6E0 VA: 0x18233F0E0
	private static void RegisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

	// RVA: 0x233FA30 Offset: 0x233E030 VA: 0x18233FA30
	private static void UnregisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

	// RVA: 0x233F290 Offset: 0x233D890 VA: 0x18233F290
	private static void SendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	// RVA: 0x233F520 Offset: 0x233DB20 VA: 0x18233F520
	private static bool TrySendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }
}

// Namespace: UnityEngine
public class PlayerPrefsException : Exception // TypeDefIndex: 9667
{
	// Methods

	// RVA: 0x233FBE0 Offset: 0x233E1E0 VA: 0x18233FBE0
	public void .ctor(string error) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
public class PlayerPrefs // TypeDefIndex: 9668
{
	// Methods

	[NativeMethod("SetString")]
	// RVA: 0x2340290 Offset: 0x233E890 VA: 0x182340290
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x23401D0 Offset: 0x233E7D0 VA: 0x1823401D0
	public static void SetString(string key, string value) { }

	// RVA: 0x233FCE0 Offset: 0x233E2E0 VA: 0x18233FCE0
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x233FCA0 Offset: 0x233E2A0 VA: 0x18233FCA0
	public static string GetString(string key) { }

	// RVA: 0x2340020 Offset: 0x233E620 VA: 0x182340020
	public static bool HasKey(string key) { }

	[NativeMethod("Sync")]
	// RVA: 0x23401A0 Offset: 0x233E7A0 VA: 0x1823401A0
	public static void Save() { }

	// RVA: 0x2340240 Offset: 0x233E840 VA: 0x182340240
	private static bool TrySetSetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper value) { }

	// RVA: 0x233FC40 Offset: 0x233E240 VA: 0x18233FC40
	private static void GetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret) { }

	// RVA: 0x233FFE0 Offset: 0x233E5E0 VA: 0x18233FFE0
	private static bool HasKey_Injected(ref ManagedSpanWrapper key) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
[UsedByNativeCode]
public abstract class PropertyAttribute : Attribute // TypeDefIndex: 9669
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = False)]
[UsedByNativeCode]
public class InspectorNameAttribute : PropertyAttribute // TypeDefIndex: 9670
{
	// Fields
	public readonly string displayName; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string displayName) { }
}

// Namespace: UnityEngine
[Usage(32767, Inherited = True, AllowMultiple = False)]
public class TooltipAttribute : PropertyAttribute // TypeDefIndex: 9671
{
	// Fields
	public readonly string tooltip; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string tooltip) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = True)]
public class SpaceAttribute : PropertyAttribute // TypeDefIndex: 9672
{
	// Fields
	public readonly float height; // 0x10

	// Methods

	// RVA: 0x2344810 Offset: 0x2342E10 VA: 0x182344810
	public void .ctor() { }

	// RVA: 0x2034290 Offset: 0x2032890 VA: 0x182034290
	public void .ctor(float height) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = True)]
public class HeaderAttribute : PropertyAttribute // TypeDefIndex: 9673
{
	// Fields
	public readonly string header; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string header) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class RangeAttribute : PropertyAttribute // TypeDefIndex: 9674
{
	// Fields
	public readonly float min; // 0x10
	public readonly float max; // 0x14

	// Methods

	// RVA: 0x20342C0 Offset: 0x20328C0 VA: 0x1820342C0
	public void .ctor(float min, float max) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class MinAttribute : PropertyAttribute // TypeDefIndex: 9675
{
	// Fields
	public readonly float min; // 0x10

	// Methods

	// RVA: 0x2034290 Offset: 0x2032890 VA: 0x182034290
	public void .ctor(float min) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class MultilineAttribute : PropertyAttribute // TypeDefIndex: 9676
{
	// Fields
	public readonly int lines; // 0x10

	// Methods

	// RVA: 0x233B830 Offset: 0x2339E30 VA: 0x18233B830
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class TextAreaAttribute : PropertyAttribute // TypeDefIndex: 9677
{
	// Fields
	public readonly int minLines; // 0x10
	public readonly int maxLines; // 0x14

	// Methods

	// RVA: 0x2346650 Offset: 0x2344C50 VA: 0x182346650
	public void .ctor() { }

	// RVA: 0x141C2E0 Offset: 0x141A8E0 VA: 0x18141C2E0
	public void .ctor(int minLines, int maxLines) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 9678
{
	// Fields
	public readonly bool showAlpha; // 0x10
	public readonly bool hdr; // 0x11
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minBrightness; // 0x14
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxBrightness; // 0x18
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minExposureValue; // 0x1C
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxExposureValue; // 0x20

	// Methods

	// RVA: 0x2331000 Offset: 0x232F600 VA: 0x182331000
	public void .ctor(bool showAlpha) { }

	// RVA: 0x2330FA0 Offset: 0x232F5A0 VA: 0x182330FA0
	public void .ctor(bool showAlpha, bool hdr) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/PropertyName.h")]
internal class PropertyNameUtils // TypeDefIndex: 9679
{
	// Methods

	[FreeFunction("PropertyNameFromStringICall", IsThreadSafe = True)]
	// RVA: 0x2340570 Offset: 0x233EB70 VA: 0x182340570
	public static PropertyName PropertyNameFromString(string name) { }

	// RVA: 0x2340520 Offset: 0x233EB20 VA: 0x182340520
	private static void PropertyNameFromString_Injected(ref ManagedSpanWrapper name, out PropertyName ret) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct PropertyName : IEquatable<PropertyName> // TypeDefIndex: 9680
{
	// Fields
	internal int id; // 0x0

	// Methods

	// RVA: 0x2340830 Offset: 0x233EE30 VA: 0x182340830
	public void .ctor(string name) { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(PropertyName other) { }

	// RVA: 0x23407C0 Offset: 0x233EDC0 VA: 0x1823407C0
	public static bool IsNullOrEmpty(PropertyName prop) { }

	// RVA: 0x2340850 Offset: 0x233EE50 VA: 0x182340850
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2340730 Offset: 0x233ED30 VA: 0x182340730 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(PropertyName other) { }

	// RVA: 0x2340860 Offset: 0x233EE60 VA: 0x182340860
	public static PropertyName op_Implicit(string name) { }

	// RVA: 0x23407D0 Offset: 0x233EDD0 VA: 0x1823407D0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random // TypeDefIndex: 9682
{
	// Properties
	[StaticAccessor("GetScriptingRand()", 0)]
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector3 onUnitSphere { get; }

	// Methods

	[NativeMethod("SetSeed")]
	[StaticAccessor("GetScriptingRand()", 0)]
	// RVA: 0x2340A50 Offset: 0x233F050 VA: 0x182340A50
	public static void InitState(int seed) { }

	// RVA: 0x2340C60 Offset: 0x233F260 VA: 0x182340C60
	public static Random.State get_state() { }

	// RVA: 0x2340D10 Offset: 0x233F310 VA: 0x182340D10
	public static void set_state(Random.State value) { }

	[FreeFunction]
	// RVA: 0x2340AD0 Offset: 0x233F0D0 VA: 0x182340AD0
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x2340A90 Offset: 0x233F090 VA: 0x182340A90
	public static int Range(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x2340A90 Offset: 0x233F090 VA: 0x182340A90
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x2340CA0 Offset: 0x233F2A0 VA: 0x182340CA0
	public static float get_value() { }

	[FreeFunction]
	// RVA: 0x2340B60 Offset: 0x233F160 VA: 0x182340B60
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunction]
	// RVA: 0x2340BE0 Offset: 0x233F1E0 VA: 0x182340BE0
	public static Vector3 get_onUnitSphere() { }

	// RVA: 0x2340870 Offset: 0x233EE70 VA: 0x182340870
	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	// RVA: 0x2340C20 Offset: 0x233F220 VA: 0x182340C20
	private static void get_state_Injected(out Random.State ret) { }

	// RVA: 0x2340CD0 Offset: 0x233F2D0 VA: 0x182340CD0
	private static void set_state_Injected(in Random.State value) { }

	// RVA: 0x2340B20 Offset: 0x233F120 VA: 0x182340B20
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x2340BA0 Offset: 0x233F1A0 VA: 0x182340BA0
	private static void get_onUnitSphere_Injected(out Vector3 ret) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class ResourceRequest : AsyncOperation // TypeDefIndex: 9684
{
	// Fields
	internal string m_Path; // 0x20
	internal Type m_Type; // 0x28

	// Properties
	public Object asset { get; }

	// Methods

	// RVA: 0x23431B0 Offset: 0x23417B0 VA: 0x1823431B0 Slot: 4
	protected virtual Object GetResult() { }

	// RVA: 0x15267C0 Offset: 0x1524DC0 VA: 0x1815267C0
	public Object get_asset() { }

	// RVA: 0x232E8C0 Offset: 0x232CEC0 VA: 0x18232E8C0
	protected void .ctor(IntPtr ptr) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
internal static class ResourcesAPIInternal // TypeDefIndex: 9685
{
	// Methods

	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	[TypeInferenceRule(2)]
	// RVA: 0x23431D0 Offset: 0x23417D0 VA: 0x1823431D0
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	// RVA: 0x2343250 Offset: 0x2341850 VA: 0x182343250
	public static Shader FindShaderByName(string name) { }

	[FreeFunction("Resources_Bindings::Load")]
	[NativeThrows]
	[TypeInferenceRule(1)]
	// RVA: 0x2343940 Offset: 0x2341F40 VA: 0x182343940
	public static Object Load(string path, Type systemTypeInstance) { }

	[NativeThrows]
	[FreeFunction("Resources_Bindings::LoadAll")]
	// RVA: 0x2343490 Offset: 0x2341A90 VA: 0x182343490
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
	// RVA: 0x23436C0 Offset: 0x2341CC0 VA: 0x1823436C0
	internal static ResourceRequest LoadAsyncInternal(string path, Type type) { }

	[FreeFunction("Scripting::UnloadAssetFromScripting")]
	// RVA: 0x2343B90 Offset: 0x2342190 VA: 0x182343B90
	public static void UnloadAsset(Object assetToUnload) { }

	// RVA: 0x2343210 Offset: 0x2341810 VA: 0x182343210
	private static IntPtr FindShaderByName_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x23438F0 Offset: 0x2341EF0 VA: 0x1823438F0
	private static IntPtr Load_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance) { }

	// RVA: 0x2343440 Offset: 0x2341A40 VA: 0x182343440
	private static Object[] LoadAll_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance) { }

	// RVA: 0x2343670 Offset: 0x2341C70 VA: 0x182343670
	private static IntPtr LoadAsyncInternal_Injected(ref ManagedSpanWrapper path, Type type) { }

	// RVA: 0x2343B50 Offset: 0x2342150 VA: 0x182343B50
	private static void UnloadAsset_Injected(IntPtr assetToUnload) { }
}

// Namespace: UnityEngine
public class ResourcesAPI // TypeDefIndex: 9686
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static ResourcesAPI ActiveAPI { get; }
	public static ResourcesAPI overrideAPI { get; }

	// Methods

	// RVA: 0x2343DE0 Offset: 0x23423E0 VA: 0x182343DE0
	internal static ResourcesAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x2343E90 Offset: 0x2342490 VA: 0x182343E90
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected internal void .ctor() { }

	// RVA: 0x2343C00 Offset: 0x2342200 VA: 0x182343C00 Slot: 4
	protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x2343C40 Offset: 0x2342240 VA: 0x182343C40 Slot: 5
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x2343CE0 Offset: 0x23422E0 VA: 0x182343CE0 Slot: 6
	protected internal virtual Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x2343C50 Offset: 0x2342250 VA: 0x182343C50 Slot: 7
	protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: 0x2343C70 Offset: 0x2342270 VA: 0x182343C70 Slot: 8
	protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance) { }

	// RVA: 0x2343D00 Offset: 0x2342300 VA: 0x182343D00 Slot: 9
	protected internal virtual void UnloadAsset(Object assetToUnload) { }

	// RVA: 0x2343D70 Offset: 0x2342370 VA: 0x182343D70
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
public sealed class Resources // TypeDefIndex: 9687
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7972F0 Offset: 0x7958F0 VA: 0x1807972F0
	|-Resources.ConvertObjects<object>
	*/

	// RVA: 0x233CE10 Offset: 0x233B410 VA: 0x18233CE10
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x23442C0 Offset: 0x23428C0 VA: 0x1823442C0
	public static Object Load(string path) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7974C0 Offset: 0x795AC0 VA: 0x1807974C0
	|-Resources.Load<object>
	*/

	// RVA: 0x2344240 Offset: 0x2342840 VA: 0x182344240
	public static Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x23441C0 Offset: 0x23427C0 VA: 0x1823441C0
	public static ResourceRequest LoadAsync(string path, Type type) { }

	// RVA: 0x2344140 Offset: 0x2342740 VA: 0x182344140
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	[FreeFunction("GetScriptingBuiltinResource", ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2343F30 Offset: 0x2342530 VA: 0x182343F30
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x797410 Offset: 0x795A10 VA: 0x180797410
	|-Resources.GetBuiltinResource<object>
	*/

	// RVA: 0x2344330 Offset: 0x2342930 VA: 0x182344330
	public static void UnloadAsset(Object assetToUnload) { }

	// RVA: 0x2343EE0 Offset: 0x23424E0 VA: 0x182343EE0
	private static IntPtr GetBuiltinResource_Injected(Type type, ref ManagedSpanWrapper path) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
public class AsyncOperation : YieldInstruction // TypeDefIndex: 9689
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.AssetBundleModule" })]
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { get; set; }

	// Methods

	[StaticAccessor("AsyncOperationBindings", 2)]
	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x232E7F0 Offset: 0x232CDF0 VA: 0x18232E7F0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", 2)]
	// RVA: 0x232E830 Offset: 0x232CE30 VA: 0x18232E830
	private static void InternalSetManagedObject(IntPtr ptr, AsyncOperation self) { }

	// RVA: 0x232E8C0 Offset: 0x232CEC0 VA: 0x18232E8C0
	protected void .ctor(IntPtr ptr) { }

	[NativeMethod("IsDone")]
	// RVA: 0x232EB20 Offset: 0x232D120 VA: 0x18232EB20
	public bool get_isDone() { }

	[NativeMethod("GetProgress")]
	// RVA: 0x232EBC0 Offset: 0x232D1C0 VA: 0x18232EBC0
	public float get_progress() { }

	[NativeMethod("SetPriority")]
	// RVA: 0x232EDC0 Offset: 0x232D3C0 VA: 0x18232EDC0
	public void set_priority(int value) { }

	[NativeMethod("GetAllowSceneActivation")]
	// RVA: 0x232EA80 Offset: 0x232D080 VA: 0x18232EA80
	public bool get_allowSceneActivation() { }

	[NativeMethod("SetAllowSceneActivation")]
	// RVA: 0x232ED20 Offset: 0x232D320 VA: 0x18232ED20
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x232E770 Offset: 0x232CD70 VA: 0x18232E770 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCode]
	// RVA: 0x232E880 Offset: 0x232CE80 VA: 0x18232E880
	internal void InvokeCompletionEvent() { }

	// RVA: 0x232E910 Offset: 0x232CF10 VA: 0x18232E910
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x232EC20 Offset: 0x232D220 VA: 0x18232EC20
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x232EAE0 Offset: 0x232D0E0 VA: 0x18232EAE0
	private static bool get_isDone_Injected(IntPtr _unity_self) { }

	// RVA: 0x232EB80 Offset: 0x232D180 VA: 0x18232EB80
	private static float get_progress_Injected(IntPtr _unity_self) { }

	// RVA: 0x232ED80 Offset: 0x232D380 VA: 0x18232ED80
	private static void set_priority_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x232EA40 Offset: 0x232D040 VA: 0x18232EA40
	private static bool get_allowSceneActivation_Injected(IntPtr _unity_self) { }

	// RVA: 0x232ECD0 Offset: 0x232D2D0 VA: 0x18232ECD0
	private static void set_allowSceneActivation_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: UnityEngine
internal class AttributeHelperEngine // TypeDefIndex: 9690
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x232F170 Offset: 0x232D770 VA: 0x18232F170
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCode]
	// RVA: 0x232F290 Offset: 0x232D890 VA: 0x18232F290
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x232F070 Offset: 0x232D670 VA: 0x18232F070
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x232EE20 Offset: 0x232D420 VA: 0x18232EE20
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x232F000 Offset: 0x232D600 VA: 0x18232F000
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666640 Offset: 0x664C40 VA: 0x180666640
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	*/

	// RVA: 0x232F700 Offset: 0x232DD00 VA: 0x18232F700
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Usage(4, Inherited = False)]
[RequiredByNativeCode]
public sealed class DisallowMultipleComponent : Attribute // TypeDefIndex: 9691
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(4, AllowMultiple = True)]
[RequiredByNativeCode]
public sealed class RequireComponent : Attribute // TypeDefIndex: 9692
{
	// Fields
	public Type m_Type0; // 0x10
	public Type m_Type1; // 0x18
	public Type m_Type2; // 0x20

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type requiredComponent) { }

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(Type requiredComponent, Type requiredComponent2) { }
}

// Namespace: UnityEngine
public sealed class AddComponentMenu : Attribute // TypeDefIndex: 9693
{
	// Fields
	private string m_AddComponentMenu; // 0x10
	private int m_Ordering; // 0x18

	// Methods

	// RVA: 0x232DFE0 Offset: 0x232C5E0 VA: 0x18232DFE0
	public void .ctor(string menuName) { }

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	public void .ctor(string menuName, int order) { }
}

// Namespace: UnityEngine
[Usage(4, AllowMultiple = False, Inherited = False)]
public sealed class CreateAssetMenuAttribute : Attribute // TypeDefIndex: 9694
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <menuName>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <fileName>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <order>k__BackingField; // 0x20

	// Properties
	public string menuName { set; }
	public string fileName { set; }
	public int order { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_menuName(string value) { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_fileName(string value) { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_order(int value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(64, AllowMultiple = True)]
[RequiredByNativeCode]
public sealed class ContextMenu : Attribute // TypeDefIndex: 9695
{
	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C
	public readonly string disabledTooltip; // 0x20
	internal readonly string iconResource; // 0x28

	// Methods

	// RVA: 0x23332D0 Offset: 0x23318D0 VA: 0x1823332D0
	public void .ctor(string itemName) { }

	// RVA: 0x2333240 Offset: 0x2331840 VA: 0x182333240
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x23331A0 Offset: 0x23317A0 VA: 0x1823331A0
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

	// RVA: 0x23333D0 Offset: 0x23319D0 VA: 0x1823333D0
	public void .ctor(string itemName, bool isValidateFunction, int priority, string disabledTooltip) { }

	// RVA: 0x2333350 Offset: 0x2331950 VA: 0x182333350
	internal void .ctor(string itemName, bool isValidateFunction, int priority, string disabledTooltip, string iconResource) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class ExecuteInEditMode : Attribute // TypeDefIndex: 9696
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class ExecuteAlways : Attribute // TypeDefIndex: 9697
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class HideInInspector : Attribute // TypeDefIndex: 9698
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(4, AllowMultiple = False)]
public class HelpURLAttribute : Attribute // TypeDefIndex: 9699
{
	// Fields
	internal readonly string m_Url; // 0x10
	internal readonly bool m_Dispatcher; // 0x18
	internal readonly string m_DispatchingFieldName; // 0x20

	// Methods

	// RVA: 0x2337D40 Offset: 0x2336340 VA: 0x182337D40
	public void .ctor(string url) { }
}

// Namespace: UnityEngine
[Usage(4)]
[UsedByNativeCode]
public class DefaultExecutionOrder : Attribute // TypeDefIndex: 9700
{
	// Fields
	private int m_Order; // 0x10

	// Properties
	public int order { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int order) { }

	// RVA: 0x2333510 Offset: 0x2331B10 VA: 0x182333510
	public int get_order() { }
}

// Namespace: UnityEngine
[Usage(1)]
[RequiredByNativeCode]
public class AssemblyIsEditorAssembly : Attribute // TypeDefIndex: 9701
{}

// Namespace: UnityEngine
[Usage(4, Inherited = False)]
[UsedByNativeCode]
public class ExcludeFromPresetAttribute : Attribute // TypeDefIndex: 9702
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/Awaitable.h")]
[AsyncMethodBuilder(typeof(Awaitable.AwaitableAsyncMethodBuilder))]
[NativeHeader("Runtime/Mono/DelayedCallAwaitable.h")]
[NativeHeader("Runtime/Mono/AsyncOperationAwaitable.h")]
public class Awaitable : IEnumerator // TypeDefIndex: 9711
{
	// Fields
	private readonly Awaitable.ManagedLockWithSingleThreadBias _spinLock; // 0x10
	private static readonly Awaitable.ThreadSafeObjectPool<Awaitable> _pool; // 0x0
	private Awaitable.AwaitableHandle _handle; // 0x18
	private ExceptionDispatchInfo _exceptionToRethrow; // 0x20
	private bool _managedAwaitableDone; // 0x28
	private Action _continuation; // 0x30
	private Nullable<CancellationTokenRegistration> _cancelTokenRegistration; // 0x38
	private static bool _nextFrameAndEndOfFrameWiredUp; // 0x10
	private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration; // 0x18
	private static readonly Awaitable.DoubleBufferedAwaitableList _nextFrameAwaitables; // 0x30
	private static readonly Awaitable.DoubleBufferedAwaitableList _endOfFrameAwaitables; // 0x38
	private static SynchronizationContext _synchronizationContext; // 0x40

	// Properties
	private bool IsCompletedNoLock { get; }
	public bool IsCompleted { get; }
	internal bool IsDettachedOrCompleted { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x23301B0 Offset: 0x232E7B0 VA: 0x1823301B0
	private void SetExceptionFromNative(Exception ex) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x2330080 Offset: 0x232E680 VA: 0x182330080
	private void RunContinuation() { }

	[FreeFunction("Scripting::Awaitables::Release", IsThreadSafe = True)]
	// RVA: 0x2330040 Offset: 0x232E640 VA: 0x182330040
	private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable) { }

	[FreeFunction("Scripting::Awaitables::IsCompleted", IsThreadSafe = True)]
	// RVA: 0x232F970 Offset: 0x232DF70 VA: 0x18232F970
	private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable) { }

	// RVA: 0x2330530 Offset: 0x232EB30 VA: 0x182330530
	private void .ctor() { }

	// RVA: 0x232FF00 Offset: 0x232E500 VA: 0x18232FF00
	internal void RaiseManagedCompletion() { }

	// RVA: 0x232FBA0 Offset: 0x232E1A0 VA: 0x18232FBA0
	internal void PropagateExceptionAndRelease() { }

	// RVA: 0x2330540 Offset: 0x232EB40 VA: 0x182330540
	private bool get_IsCompletedNoLock() { }

	// RVA: 0x2330650 Offset: 0x232EC50 VA: 0x182330650
	public bool get_IsCompleted() { }

	// RVA: 0x2330850 Offset: 0x232EE50 VA: 0x182330850
	internal bool get_IsDettachedOrCompleted() { }

	// RVA: 0x232F8D0 Offset: 0x232DED0 VA: 0x18232F8D0
	private Awaitable.AwaitableHandle CheckPointerValidity() { }

	// RVA: 0x2330340 Offset: 0x232E940 VA: 0x182330340 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	[RequiredByNativeCode]
	// RVA: 0x232F9B0 Offset: 0x232DFB0 VA: 0x18232F9B0
	private static void OnDelayedCallManagerCleared() { }

	[RequiredByNativeCode]
	// RVA: 0x232FB40 Offset: 0x232E140 VA: 0x18232FB40
	private static void OnUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x232FAE0 Offset: 0x232E0E0 VA: 0x18232FAE0
	private static void OnEndOfFrame() { }

	// RVA: 0x23302D0 Offset: 0x232E8D0 VA: 0x1823302D0
	internal static void SetSynchronizationContext(SynchronizationContext synchronizationContext) { }

	// RVA: 0x2330370 Offset: 0x232E970 VA: 0x182330370
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[UsedByNativeCode]
public class Behaviour : Component // TypeDefIndex: 9712
{
	// Properties
	[RequiredByNativeCode]
	[NativeProperty]
	public bool enabled { get; set; }
	[NativeProperty]
	public bool isActiveAndEnabled { get; }

	// Methods

	// RVA: 0x2330B50 Offset: 0x232F150 VA: 0x182330B50
	public bool get_enabled() { }

	// RVA: 0x2330CE0 Offset: 0x232F2E0 VA: 0x182330CE0
	public void set_enabled(bool value) { }

	[NativeMethod("IsAddedToManager")]
	// RVA: 0x2330C10 Offset: 0x232F210 VA: 0x182330C10
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x2330AC0 Offset: 0x232F0C0 VA: 0x182330AC0
	public void .ctor() { }

	// RVA: 0x2330B10 Offset: 0x232F110 VA: 0x182330B10
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x2330C90 Offset: 0x232F290 VA: 0x182330C90
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2330BD0 Offset: 0x232F1D0 VA: 0x182330BD0
	private static bool get_isActiveAndEnabled_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
internal struct CastHelper<T> // TypeDefIndex: 9713
{
	// Fields
	public T t; // 0x0
	public IntPtr onePointerFurtherThanT; // 0x0
}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer // TypeDefIndex: 9714
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2330F90 Offset: 0x232F590 VA: 0x182330F90
	private static void Init() { }

	[RequiredByNativeCode]
	// RVA: 0x2330E70 Offset: 0x232F470 VA: 0x182330E70
	private static void InitStdErrWithHandle(IntPtr fileHandle) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyVersion // TypeDefIndex: 9715
{
	// Fields
	public ushort major; // 0x0
	public ushort minor; // 0x2
	public ushort build; // 0x4
	public ushort revision; // 0x6

	// Methods

	// RVA: 0x232E730 Offset: 0x232CD30 VA: 0x18232E730
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	// RVA: 0x232E530 Offset: 0x232CB30 VA: 0x18232E530 Slot: 3
	public override string ToString() { }

	// RVA: 0x232E3E0 Offset: 0x232C9E0 VA: 0x18232E3E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x232E490 Offset: 0x232CA90 VA: 0x18232E490 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyFullName // TypeDefIndex: 9716
{
	// Fields
	[NativeName("name")]
	public string Name; // 0x0
	[NativeName("version")]
	public AssemblyVersion Version; // 0x8
	[NativeName("publicKeyToken")]
	public string PublicKeyToken; // 0x10
	[NativeName("culture")]
	public string Culture; // 0x18

	// Methods

	// RVA: 0x232E020 Offset: 0x232C620 VA: 0x18232E020 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x232E130 Offset: 0x232C730 VA: 0x18232E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232E1D0 Offset: 0x232C7D0 VA: 0x18232E1D0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[NativeClass("Unity::Component")]
public class Component : Object // TypeDefIndex: 9717
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public string tag { get; }

	// Methods

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2332060 Offset: 0x2330660 VA: 0x182332060
	public Transform get_transform() { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	// RVA: 0x2331EE0 Offset: 0x23304E0 VA: 0x182331EE0
	public GameObject get_gameObject() { }

	[TypeInferenceRule(0)]
	// RVA: 0x23316C0 Offset: 0x232FCC0 VA: 0x1823316C0
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2331160 Offset: 0x232F760 VA: 0x182331160
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BA7F0 Offset: 0x6B8DF0 VA: 0x1806BA7F0
	|-Component.GetComponent<object>
	|
	|-RVA: 0x6BA620 Offset: 0x6B8C20 VA: 0x1806BA620
	|-Component.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x2331CB0 Offset: 0x23302B0 VA: 0x182331CB0
	public bool TryGetComponent(Type type, out Component component) { }

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BAE60 Offset: 0x6B9460 VA: 0x1806BAE60
	|-Component.TryGetComponent<object>
	|
	|-RVA: 0x6BADF0 Offset: 0x6B93F0 VA: 0x1806BADF0
	|-Component.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x2331330 Offset: 0x232F930 VA: 0x182331330
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2331200 Offset: 0x232F800 VA: 0x182331200
	public Component GetComponentInChildren(Type t) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BA160 Offset: 0x6B8760 VA: 0x1806BA160
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0x6BA010 Offset: 0x6B8610 VA: 0x1806BA010
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: 0x23318E0 Offset: 0x232FEE0 VA: 0x1823318E0
	public Component[] GetComponentsInChildren(Type t) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BAAC0 Offset: 0x6B90C0 VA: 0x1806BAAC0
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x6BA8B0 Offset: 0x6B8EB0 VA: 0x1806BA8B0
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BAA50 Offset: 0x6B9050 VA: 0x1806BAA50
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x6BA920 Offset: 0x6B8F20 VA: 0x1806BA920
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BA9E0 Offset: 0x6B8FE0 VA: 0x1806BA9E0
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x6BA870 Offset: 0x6B8E70 VA: 0x1806BA870
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BAB20 Offset: 0x6B9120 VA: 0x1806BAB20
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x6BA990 Offset: 0x6B8F90 VA: 0x1806BA990
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x2331590 Offset: 0x232FB90 VA: 0x182331590
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2331460 Offset: 0x232FA60 VA: 0x182331460
	public Component GetComponentInParent(Type t) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BA4B0 Offset: 0x6B8AB0 VA: 0x1806BA4B0
	|-Component.GetComponentInParent<object>
	|
	|-RVA: 0x6BA210 Offset: 0x6B8810 VA: 0x1806BA210
	|-Component.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BA570 Offset: 0x6B8B70 VA: 0x1806BA570
	|-Component.GetComponentInParent<object>
	|
	|-RVA: 0x6BA360 Offset: 0x6B8960 VA: 0x1806BA360
	|-Component.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23319A0 Offset: 0x232FFA0 VA: 0x1823319A0
	public Component[] GetComponentsInParent(Type t, bool includeInactive) { }

	[ExcludeFromDocs]
	// RVA: 0x2331A70 Offset: 0x2330070 VA: 0x182331A70
	public Component[] GetComponentsInParent(Type t) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BAC80 Offset: 0x6B9280 VA: 0x1806BAC80
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x6BA8B0 Offset: 0x6B8EB0 VA: 0x1806BA8B0
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BAC10 Offset: 0x6B9210 VA: 0x1806BAC10
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x6BA920 Offset: 0x6B8F20 VA: 0x1806BA920
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BABA0 Offset: 0x6B91A0 VA: 0x1806BABA0
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x6BA870 Offset: 0x6B8E70 VA: 0x1806BA870
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2331B30 Offset: 0x2330130 VA: 0x182331B30
	public Component[] GetComponents(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2331840 Offset: 0x232FE40 VA: 0x182331840
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x2331840 Offset: 0x232FE40 VA: 0x182331840
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BACE0 Offset: 0x6B92E0 VA: 0x1806BACE0
	|-Component.GetComponents<object>
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2331F80 Offset: 0x2330580 VA: 0x182331F80
	public string get_tag() { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BADA0 Offset: 0x6B93A0 VA: 0x1806BADA0
	|-Component.GetComponents<object>
	|
	|-RVA: 0x6BAD50 Offset: 0x6B9350 VA: 0x1806BAD50
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2331050 Offset: 0x232F650 VA: 0x182331050
	public bool CompareTag(string tag) { }

	// RVA: 0x2330AC0 Offset: 0x232F0C0 VA: 0x182330AC0
	public void .ctor() { }

	// RVA: 0x2332020 Offset: 0x2330620 VA: 0x182332020
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	// RVA: 0x2331EA0 Offset: 0x23304A0 VA: 0x182331EA0
	private static IntPtr get_gameObject_Injected(IntPtr _unity_self) { }

	// RVA: 0x2331100 Offset: 0x232F700 VA: 0x182331100
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x23317E0 Offset: 0x232FDE0 VA: 0x1823317E0
	private static void GetComponentsForListInternal_Injected(IntPtr _unity_self, Type searchType, object resultList) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Mono/Coroutine.h")]
public sealed class Coroutine : YieldInstruction // TypeDefIndex: 9719
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x2333450 Offset: 0x2331A50 VA: 0x182333450 Slot: 1
	protected override void Finalize() { }

	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	// RVA: 0x23334D0 Offset: 0x2331AD0 VA: 0x1823334D0
	private static void ReleaseCoroutine(IntPtr ptr) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
internal class SetupCoroutine // TypeDefIndex: 9720
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23446E0 Offset: 0x2342CE0 VA: 0x1823446E0
	public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x23445C0 Offset: 0x2342BC0 VA: 0x1823445C0
	public static object InvokeMember(object behaviour, string name, object variable) { }
}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 9721
{
	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0xA6D740 Offset: 0xA6BD40 VA: 0x180A6D740 Slot: 5
	public object get_Current() { }

	// RVA: 0x14542D0 Offset: 0x14528D0 VA: 0x1814542D0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public virtual void Reset() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct EnumData // TypeDefIndex: 9722
{
	// Fields
	public Enum[] values; // 0x0
	public int[] flagValues; // 0x8
	public string[] displayNames; // 0x10
	public string[] names; // 0x18
	public string[] tooltip; // 0x20
	public bool flags; // 0x28
	public Type underlyingType; // 0x30
	public bool unsigned; // 0x38
	public bool serializable; // 0x39
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal static class EnumDataUtility // TypeDefIndex: 9727
{
	// Fields
	private static readonly Dictionary<ValueTuple<EnumDataUtility.CachedType, Type>, EnumData> s_EnumData; // 0x0

	// Methods

	// RVA: 0x23342B0 Offset: 0x23328B0 VA: 0x1823342B0
	public static EnumData GetCachedEnumData(Type enumType, EnumDataUtility.CachedType cachedType = 1, Func<string, string> nicifyName) { }

	// RVA: 0x2335340 Offset: 0x2333940 VA: 0x182335340
	public static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData) { }

	// RVA: 0x2333D70 Offset: 0x2332370 VA: 0x182333D70
	private static bool CheckObsoleteAddition(FieldInfo field, EnumDataUtility.CachedType cachedType) { }

	// RVA: 0x2334190 Offset: 0x2332790 VA: 0x182334190
	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	// RVA: 0x2333EA0 Offset: 0x23324A0 VA: 0x182333EA0
	private static string EnumNameFromEnumField(FieldInfo field, Func<string, string> nicifyName) { }

	// RVA: 0x2335890 Offset: 0x2333E90 VA: 0x182335890
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2335820 Offset: 0x2333E20 VA: 0x182335820
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(ref EnumDataUtility.<>c__DisplayClass8_0 ) { }
}

// Namespace: UnityEngine
[Usage(4)]
[UsedByNativeCode]
public class ExcludeFromObjectFactoryAttribute : Attribute // TypeDefIndex: 9728
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(1028, Inherited = True)]
[RequiredByNativeCode]
internal sealed class ExtensionOfNativeClassAttribute : Attribute // TypeDefIndex: 9729
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeClass(null)]
[ExcludeFromObjectFactory]
internal class FailedToLoadScriptObject : Object // TypeDefIndex: 9730
{}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[UsedByNativeCode]
public sealed class GameObject : Object // TypeDefIndex: 9731
{
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; }
	public string tag { get; set; }
	public Scene scene { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	// RVA: 0x2335C30 Offset: 0x2334230 VA: 0x182335C30
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703780 Offset: 0x701D80 VA: 0x180703780
	|-GameObject.GetComponent<object>
	|
	|-RVA: 0x7035B0 Offset: 0x701BB0 VA: 0x1807035B0
	|-GameObject.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x23363B0 Offset: 0x23349B0 VA: 0x1823363B0
	public Component GetComponent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2335F20 Offset: 0x2334520 VA: 0x182335F20
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[TypeInferenceRule(0)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x23360D0 Offset: 0x23346D0 VA: 0x1823360D0
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2336020 Offset: 0x2334620 VA: 0x182336020
	public Component GetComponentInChildren(Type type) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703140 Offset: 0x701740 VA: 0x180703140
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x703030 Offset: 0x701630 VA: 0x180703030
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703210 Offset: 0x701810 VA: 0x180703210
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x702EE0 Offset: 0x7014E0 VA: 0x180702EE0
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x23361F0 Offset: 0x23347F0 VA: 0x1823361F0
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[TypeInferenceRule(0)]
	// RVA: 0x23362B0 Offset: 0x23348B0 VA: 0x1823362B0
	public Component GetComponentInParent(Type type) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7034E0 Offset: 0x701AE0 VA: 0x1807034E0
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x703030 Offset: 0x701630 VA: 0x180703030
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703420 Offset: 0x701A20 VA: 0x180703420
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x7032D0 Offset: 0x7018D0 VA: 0x1807032D0
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2336710 Offset: 0x2334D10 VA: 0x182336710
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x2336880 Offset: 0x2334E80 VA: 0x182336880
	public Component[] GetComponents(Type type) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703CA0 Offset: 0x7022A0 VA: 0x180703CA0
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23367D0 Offset: 0x2334DD0 VA: 0x1823367D0
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703C10 Offset: 0x702210 VA: 0x180703C10
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: 0x2336560 Offset: 0x2334B60 VA: 0x182336560
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x2336450 Offset: 0x2334A50 VA: 0x182336450
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7038A0 Offset: 0x701EA0 VA: 0x1807038A0
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703800 Offset: 0x701E00 VA: 0x180703800
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703990 Offset: 0x701F90 VA: 0x180703990
	|-GameObject.GetComponentsInChildren<object>
	|
	|-RVA: 0x6BA870 Offset: 0x6B8E70 VA: 0x1806BA870
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: 0x2336570 Offset: 0x2334B70 VA: 0x182336570
	public Component[] GetComponentsInParent(Type type) { }

	// RVA: 0x2336580 Offset: 0x2334B80 VA: 0x182336580
	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703B70 Offset: 0x702170 VA: 0x180703B70
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703A80 Offset: 0x702080 VA: 0x180703A80
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BA870 Offset: 0x6B8E70 VA: 0x1806BA870
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x703FB0 Offset: 0x7025B0 VA: 0x180703FB0
	|-GameObject.TryGetComponent<object>
	|
	|-RVA: 0x703D80 Offset: 0x702380 VA: 0x180703D80
	|-GameObject.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23370B0 Offset: 0x23356B0 VA: 0x1823370B0
	public bool TryGetComponent(Type type, out Component component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2337010 Offset: 0x2335610 VA: 0x182337010
	internal Component TryGetComponentInternal(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2336F20 Offset: 0x2335520 VA: 0x182336F20
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	// RVA: 0x2335920 Offset: 0x2333F20 VA: 0x182335920
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2335920 Offset: 0x2333F20 VA: 0x182335920
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x702E50 Offset: 0x701450 VA: 0x180702E50
	|-GameObject.AddComponent<object>
	*/

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	// RVA: 0x23379C0 Offset: 0x2335FC0 VA: 0x1823379C0
	public Transform get_transform() { }

	// RVA: 0x23376C0 Offset: 0x2335CC0 VA: 0x1823376C0
	public int get_layer() { }

	// RVA: 0x2337AA0 Offset: 0x23360A0 VA: 0x182337AA0
	public void set_layer(int value) { }

	[NativeMethod(Name = "SetSelfActive")]
	// RVA: 0x2336E30 Offset: 0x2335430 VA: 0x182336E30
	public void SetActive(bool value) { }

	[NativeMethod(Name = "IsSelfActive")]
	// RVA: 0x2337540 Offset: 0x2335B40 VA: 0x182337540
	public bool get_activeSelf() { }

	[NativeMethod(Name = "IsActive")]
	// RVA: 0x2337480 Offset: 0x2335A80 VA: 0x182337480
	public bool get_activeInHierarchy() { }

	[NativeMethod(Name = "GetIsStaticDeprecated")]
	// RVA: 0x2337600 Offset: 0x2335C00 VA: 0x182337600
	public bool get_isStatic() { }

	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	// RVA: 0x2337870 Offset: 0x2335E70 VA: 0x182337870
	public string get_tag() { }

	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	// RVA: 0x2337B80 Offset: 0x2336180 VA: 0x182337B80
	public void set_tag(string value) { }

	// RVA: 0x2335BE0 Offset: 0x23341E0 VA: 0x182335BE0
	public bool CompareTag(string tag) { }

	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
	// RVA: 0x2335A10 Offset: 0x2334010 VA: 0x182335A10
	private bool CompareTag_Internal(string tag) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	// RVA: 0x2336C10 Offset: 0x2335210 VA: 0x182336C10
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x2337230 Offset: 0x2335830 VA: 0x182337230
	public void .ctor(string name) { }

	// RVA: 0x23373E0 Offset: 0x23359E0 VA: 0x1823373E0
	public void .ctor() { }

	// RVA: 0x23372A0 Offset: 0x23358A0 VA: 0x1823372A0
	public void .ctor(string name, Type[] components) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	// RVA: 0x2336A20 Offset: 0x2335020 VA: 0x182336A20
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	// RVA: 0x2335CD0 Offset: 0x23342D0 VA: 0x182335CD0
	public static GameObject Find(string name) { }

	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	// RVA: 0x2337790 Offset: 0x2335D90 VA: 0x182337790
	public Scene get_scene() { }

	// RVA: 0x1561B10 Offset: 0x1560110 VA: 0x181561B10
	public GameObject get_gameObject() { }

	// RVA: 0x2335BF0 Offset: 0x23341F0 VA: 0x182335BF0
	private static IntPtr CreatePrimitive_Injected(PrimitiveType type) { }

	// RVA: 0x2336360 Offset: 0x2334960 VA: 0x182336360
	private static IntPtr GetComponent_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x2335EC0 Offset: 0x23344C0 VA: 0x182335EC0
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x2335FC0 Offset: 0x23345C0 VA: 0x182335FC0
	private static IntPtr GetComponentInChildren_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	// RVA: 0x2336190 Offset: 0x2334790 VA: 0x182336190
	private static IntPtr GetComponentInParent_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	// RVA: 0x2336690 Offset: 0x2334C90 VA: 0x182336690
	private static Array GetComponentsInternal_Injected(IntPtr _unity_self, Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x2336FC0 Offset: 0x23355C0 VA: 0x182336FC0
	private static IntPtr TryGetComponentInternal_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x2336EC0 Offset: 0x23354C0 VA: 0x182336EC0
	private static void TryGetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x2336980 Offset: 0x2334F80 VA: 0x182336980
	private static IntPtr Internal_AddComponentWithType_Injected(IntPtr _unity_self, Type componentType) { }

	// RVA: 0x2337980 Offset: 0x2335F80 VA: 0x182337980
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	// RVA: 0x2337680 Offset: 0x2335C80 VA: 0x182337680
	private static int get_layer_Injected(IntPtr _unity_self) { }

	// RVA: 0x2337A60 Offset: 0x2336060 VA: 0x182337A60
	private static void set_layer_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2336DE0 Offset: 0x23353E0 VA: 0x182336DE0
	private static void SetActive_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2337500 Offset: 0x2335B00 VA: 0x182337500
	private static bool get_activeSelf_Injected(IntPtr _unity_self) { }

	// RVA: 0x2337440 Offset: 0x2335A40 VA: 0x182337440
	private static bool get_activeInHierarchy_Injected(IntPtr _unity_self) { }

	// RVA: 0x23375C0 Offset: 0x2335BC0 VA: 0x1823375C0
	private static bool get_isStatic_Injected(IntPtr _unity_self) { }

	// RVA: 0x2337820 Offset: 0x2335E20 VA: 0x182337820
	private static void get_tag_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2337B30 Offset: 0x2336130 VA: 0x182337B30
	private static void set_tag_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x23359C0 Offset: 0x2333FC0 VA: 0x1823359C0
	private static bool CompareTag_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag) { }

	// RVA: 0x2336BA0 Offset: 0x23351A0 VA: 0x182336BA0
	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	// RVA: 0x23369D0 Offset: 0x2334FD0 VA: 0x1823369D0
	private static void Internal_CreateGameObject_Injected(GameObject self, ref ManagedSpanWrapper name) { }

	// RVA: 0x2335C90 Offset: 0x2334290 VA: 0x182335C90
	private static IntPtr Find_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x2337740 Offset: 0x2335D40 VA: 0x182337740
	private static void get_scene_Injected(IntPtr _unity_self, out Scene ret) { }
}

// Namespace: UnityEngine
[Usage(16)]
public sealed class InspectorOrderAttribute : PropertyAttribute // TypeDefIndex: 9732
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private InspectorSort <m_inspectorSort>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private InspectorSortDirection <m_sortDirection>k__BackingField; // 0x14

	// Properties
	internal InspectorSort m_inspectorSort { get; }
	internal InspectorSortDirection m_sortDirection { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal InspectorSort get_m_inspectorSort() { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	internal InspectorSortDirection get_m_sortDirection() { }
}

// Namespace: UnityEngine
public enum InspectorSort // TypeDefIndex: 9733
{
	// Fields
	public int value__; // 0x0
	public const InspectorSort ByName = 0;
	public const InspectorSort ByValue = 1;
}

// Namespace: UnityEngine
public enum InspectorSortDirection // TypeDefIndex: 9734
{
	// Fields
	public int value__; // 0x0
	public const InspectorSortDirection Ascending = 0;
	public const InspectorSortDirection Descending = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[NativeClass("BitField", "struct BitField;")]
public struct LayerMask // TypeDefIndex: 9735
{
	// Fields
	[NativeName("m_Bits")]
	private int m_Mask; // 0x0

	// Properties
	public int value { get; set; }

	// Methods

	// RVA: 0x2338060 Offset: 0x2336660 VA: 0x182338060
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x2338060 Offset: 0x2336660 VA: 0x182338060
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public int get_value() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_value(int value) { }

	[NativeMethod("LayerToString")]
	[StaticAccessor("GetTagManager()", 0)]
	// RVA: 0x2337DF0 Offset: 0x23363F0 VA: 0x182337DF0
	public static string LayerToName(int layer) { }

	[NativeMethod("StringToLayer")]
	[StaticAccessor("GetTagManager()", 0)]
	// RVA: 0x2337EE0 Offset: 0x23364E0 VA: 0x182337EE0
	public static int NameToLayer(string layerName) { }

	// RVA: 0x2337DB0 Offset: 0x23363B0 VA: 0x182337DB0
	private static void LayerToName_Injected(int layer, out ManagedSpanWrapper ret) { }

	// RVA: 0x2337EA0 Offset: 0x23364A0 VA: 0x182337EA0
	private static int NameToLayer_Injected(ref ManagedSpanWrapper layerName) { }
}

// Namespace: UnityEngine
[Serializable]
public struct LazyLoadReference<T> // TypeDefIndex: 9736
{
	// Fields
	private const int kInstanceID_None = 0;
	[SerializeField]
	private int m_InstanceID; // 0x0

	// Properties
	public bool isSet { get; }
	public T asset { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_isSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111E40 Offset: 0x1110440 VA: 0x181111E40
	|-LazyLoadReference<object>.get_isSet
	*/

	// RVA: -1 Offset: -1
	public T get_asset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111D70 Offset: 0x1110370 VA: 0x181111D70
	|-LazyLoadReference<object>.get_asset
	*/

	// RVA: -1 Offset: -1
	public void set_asset(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111EA0 Offset: 0x11104A0 VA: 0x181111EA0
	|-LazyLoadReference<object>.set_asset
	*/

	// RVA: -1 Offset: -1
	public static LazyLoadReference<T> op_Implicit(T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111E50 Offset: 0x1110450 VA: 0x181111E50
	|-LazyLoadReference<object>.op_Implicit
	*/
}

// Namespace: UnityEngine
internal static class ManagedStreamHelpers // TypeDefIndex: 9737
{
	// Methods

	// RVA: 0x23383D0 Offset: 0x23369D0 VA: 0x1823383D0
	internal static void ValidateLoadFromStream(Stream stream) { }

	[RequiredByNativeCode]
	// RVA: 0x23381F0 Offset: 0x23367F0 VA: 0x1823381F0
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x23382F0 Offset: 0x23368F0 VA: 0x1823382F0
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x2338130 Offset: 0x2336730 VA: 0x182338130
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
[RequiredByNativeCode]
[ExtensionOfNativeClass]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class MonoBehaviour : Behaviour // TypeDefIndex: 9738
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Properties
	public CancellationToken destroyCancellationToken { get; }
	public bool useGUILayout { get; set; }
	public bool didStart { get; }
	public bool didAwake { get; }

	// Methods

	// RVA: 0x233B3E0 Offset: 0x23399E0 VA: 0x18233B3E0
	public CancellationToken get_destroyCancellationToken() { }

	[RequiredByNativeCode]
	// RVA: 0x233A410 Offset: 0x2338A10 VA: 0x18233A410
	private void RaiseCancellation() { }

	// RVA: 0x2339C40 Offset: 0x2338240 VA: 0x182339C40
	public bool IsInvoking() { }

	// RVA: 0x23397D0 Offset: 0x2337DD0 VA: 0x1823397D0
	public void CancelInvoke() { }

	// RVA: 0x2339FF0 Offset: 0x23385F0 VA: 0x182339FF0
	public void Invoke(string methodName, float time) { }

	// RVA: 0x2339F60 Offset: 0x2338560 VA: 0x182339F60
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x2339870 Offset: 0x2337E70 VA: 0x182339870
	public void CancelInvoke(string methodName) { }

	// RVA: 0x233A260 Offset: 0x2338860 VA: 0x18233A260
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocs]
	// RVA: 0x233A8F0 Offset: 0x2338EF0 VA: 0x18233A8F0
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x233AA60 Offset: 0x2339060 VA: 0x18233AA60
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x233A740 Offset: 0x2338D40 VA: 0x18233A740
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
	// RVA: 0x233A740 Offset: 0x2338D40 VA: 0x18233A740
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x233B230 Offset: 0x2339830 VA: 0x18233B230
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x233B080 Offset: 0x2339680 VA: 0x18233B080
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x233AEC0 Offset: 0x23394C0 VA: 0x18233AEC0
	public void StopCoroutine(string methodName) { }

	// RVA: 0x233AC20 Offset: 0x2339220 VA: 0x18233AC20
	public void StopAllCoroutines() { }

	// RVA: 0x233B680 Offset: 0x2339C80 VA: 0x18233B680
	public bool get_useGUILayout() { }

	// RVA: 0x233B7A0 Offset: 0x2339DA0 VA: 0x18233B7A0
	public void set_useGUILayout(bool value) { }

	// RVA: 0x233B5C0 Offset: 0x2339BC0 VA: 0x18233B5C0
	public bool get_didStart() { }

	// RVA: 0x233B500 Offset: 0x2339B00 VA: 0x18233B500
	public bool get_didAwake() { }

	// RVA: 0x233B700 Offset: 0x2339D00 VA: 0x18233B700
	public static void print(object message) { }

	[FreeFunction("CancelInvoke")]
	// RVA: 0x23397D0 Offset: 0x2337DD0 VA: 0x1823397D0
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunction("IsInvoking")]
	// RVA: 0x2339C40 Offset: 0x2338240 VA: 0x182339C40
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunction]
	// RVA: 0x2339D50 Offset: 0x2338350 VA: 0x182339D50
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunction]
	// RVA: 0x2339880 Offset: 0x2337E80 VA: 0x182339880
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x233A060 Offset: 0x2338660 VA: 0x18233A060
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x233A2B0 Offset: 0x23388B0 VA: 0x18233A2B0
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x233A570 Offset: 0x2338B70 VA: 0x18233A570
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x233A480 Offset: 0x2338A80 VA: 0x18233A480
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x233ADD0 Offset: 0x23393D0 VA: 0x18233ADD0
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x233ACF0 Offset: 0x23392F0 VA: 0x18233ACF0
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x2339AB0 Offset: 0x23380B0 VA: 0x182339AB0
	internal string GetScriptClassName() { }

	// RVA: 0x233A390 Offset: 0x2338990 VA: 0x18233A390
	private void OnCancellationTokenCreated() { }

	// RVA: 0x2330AC0 Offset: 0x232F0C0 VA: 0x182330AC0
	public void .ctor() { }

	// RVA: 0x233AE70 Offset: 0x2339470 VA: 0x18233AE70
	private static void StopCoroutine_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName) { }

	// RVA: 0x233ABE0 Offset: 0x23391E0 VA: 0x18233ABE0
	private static void StopAllCoroutines_Injected(IntPtr _unity_self) { }

	// RVA: 0x233B640 Offset: 0x2339C40 VA: 0x18233B640
	private static bool get_useGUILayout_Injected(IntPtr _unity_self) { }

	// RVA: 0x233B750 Offset: 0x2339D50 VA: 0x18233B750
	private static void set_useGUILayout_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x233B580 Offset: 0x2339B80 VA: 0x18233B580
	private static bool get_didStart_Injected(IntPtr _unity_self) { }

	// RVA: 0x233B4C0 Offset: 0x2339AC0 VA: 0x18233B4C0
	private static bool get_didAwake_Injected(IntPtr _unity_self) { }

	// RVA: 0x2339BC0 Offset: 0x23381C0 VA: 0x182339BC0
	private static void Internal_CancelInvokeAll_Injected(IntPtr self) { }

	// RVA: 0x2339C00 Offset: 0x2338200 VA: 0x182339C00
	private static bool Internal_IsInvokingAll_Injected(IntPtr self) { }

	// RVA: 0x2339CE0 Offset: 0x23382E0 VA: 0x182339CE0
	private static void InvokeDelayed_Injected(IntPtr self, ref ManagedSpanWrapper methodName, float time, float repeatRate) { }

	// RVA: 0x2339780 Offset: 0x2337D80 VA: 0x182339780
	private static void CancelInvoke_Injected(IntPtr self, ref ManagedSpanWrapper methodName) { }

	// RVA: 0x233A010 Offset: 0x2338610 VA: 0x18233A010
	private static bool IsInvoking_Injected(IntPtr self, ref ManagedSpanWrapper methodName) { }

	// RVA: 0x233A270 Offset: 0x2338870 VA: 0x18233A270
	private static bool IsObjectMonoBehaviour_Injected(IntPtr obj) { }

	// RVA: 0x233A510 Offset: 0x2338B10 VA: 0x18233A510
	private static Coroutine StartCoroutineManaged_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value) { }

	// RVA: 0x233A430 Offset: 0x2338A30 VA: 0x18233A430
	private static Coroutine StartCoroutineManaged2_Injected(IntPtr _unity_self, IEnumerator enumerator) { }

	// RVA: 0x233AD80 Offset: 0x2339380 VA: 0x18233AD80
	private static void StopCoroutineManaged_Injected(IntPtr _unity_self, IntPtr routine) { }

	// RVA: 0x233ACA0 Offset: 0x23392A0 VA: 0x18233ACA0
	private static void StopCoroutineFromEnumeratorManaged_Injected(IntPtr _unity_self, IEnumerator routine) { }

	// RVA: 0x2339A60 Offset: 0x2338060 VA: 0x182339A60
	private static void GetScriptClassName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x233A350 Offset: 0x2338950 VA: 0x18233A350
	private static void OnCancellationTokenCreated_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
internal static class NoAllocHelpers // TypeDefIndex: 9740
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x738480 Offset: 0x736A80 VA: 0x180738480
	|-NoAllocHelpers.EnsureListElemCount<Color32>
	|-NoAllocHelpers.EnsureListElemCount<Vector4>
	|
	|-RVA: 0x738700 Offset: 0x736D00 VA: 0x180738700
	|-NoAllocHelpers.EnsureListElemCount<object>
	|
	|-RVA: 0x738590 Offset: 0x736B90 VA: 0x180738590
	|-NoAllocHelpers.EnsureListElemCount<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x233B850 Offset: 0x2339E50 VA: 0x18233B850
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x738B80 Offset: 0x737180 VA: 0x180738B80
	|-NoAllocHelpers.SafeLength<Color32>
	|-NoAllocHelpers.SafeLength<int>
	|-NoAllocHelpers.SafeLength<Vector3>
	|-NoAllocHelpers.SafeLength<Vector4>
	|-NoAllocHelpers.SafeLength<GrassChunkManager.GrassData>
	|
	|-RVA: 0x738BB0 Offset: 0x7371B0 VA: 0x180738BB0
	|-NoAllocHelpers.SafeLength<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] ExtractArrayFromList<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x738830 Offset: 0x736E30 VA: 0x180738830
	|-NoAllocHelpers.ExtractArrayFromList<Color32>
	|-NoAllocHelpers.ExtractArrayFromList<int>
	|-NoAllocHelpers.ExtractArrayFromList<object>
	|-NoAllocHelpers.ExtractArrayFromList<RaycastHit2D>
	|-NoAllocHelpers.ExtractArrayFromList<Vector3>
	|-NoAllocHelpers.ExtractArrayFromList<Vector4>
	|-NoAllocHelpers.ExtractArrayFromList<GrassChunkManager.GrassData>
	|
	|-RVA: 0x738890 Offset: 0x736E90 VA: 0x180738890
	|-NoAllocHelpers.ExtractArrayFromList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResetListContents<T>(List<T> list, ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x738990 Offset: 0x736F90 VA: 0x180738990
	|-NoAllocHelpers.ResetListContents<RaycastHit2D>
	|
	|-RVA: 0x7388F0 Offset: 0x736EF0 VA: 0x1807388F0
	|-NoAllocHelpers.ResetListContents<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResetListSize<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x738AD0 Offset: 0x7370D0 VA: 0x180738AD0
	|-NoAllocHelpers.ResetListSize<RaycastHit2D>
	|
	|-RVA: 0x738A10 Offset: 0x737010 VA: 0x180738A10
	|-NoAllocHelpers.ResetListSize<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: UnityEngine
public struct RangeInt // TypeDefIndex: 9741
{
	// Fields
	public int start; // 0x0
	public int length; // 0x4

	// Properties
	public int end { get; }

	// Methods

	// RVA: 0x2340D50 Offset: 0x233F350 VA: 0x182340D50
	public int get_end() { }

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int start, int length) { }
}

// Namespace: UnityEngine
public enum RuntimeInitializeLoadType // TypeDefIndex: 9742
{
	// Fields
	public int value__; // 0x0
	public const RuntimeInitializeLoadType AfterSceneLoad = 0;
	public const RuntimeInitializeLoadType BeforeSceneLoad = 1;
	public const RuntimeInitializeLoadType AfterAssembliesLoaded = 2;
	public const RuntimeInitializeLoadType BeforeSplashScreen = 3;
	public const RuntimeInitializeLoadType SubsystemRegistration = 4;
}

// Namespace: UnityEngine
[Usage(64, AllowMultiple = False)]
[RequiredByNativeCode]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute // TypeDefIndex: 9743
{
	// Fields
	private RuntimeInitializeLoadType m_LoadType; // 0x10

	// Properties
	private RuntimeInitializeLoadType loadType { set; }

	// Methods

	// RVA: 0x23443A0 Offset: 0x23429A0 VA: 0x1823443A0
	public void .ctor() { }

	// RVA: 0x1F08FB0 Offset: 0x1F075B0 VA: 0x181F08FB0
	public void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	private void set_loadType(RuntimeInitializeLoadType value) { }
}

// Namespace: UnityEngine
[ExtensionOfNativeClass]
[NativeClass(null)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class ScriptableObject : Object // TypeDefIndex: 9744
{
	// Methods

	// RVA: 0x2344520 Offset: 0x2342B20 VA: 0x182344520
	public void .ctor() { }

	// RVA: 0x23443C0 Offset: 0x23429C0 VA: 0x1823443C0
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x798C60 Offset: 0x797260 VA: 0x180798C60
	|-ScriptableObject.CreateInstance<object>
	*/

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x23444E0 Offset: 0x2342AE0 VA: 0x1823444E0
	private static void CreateScriptableObject(ScriptableObject self) { }

	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2344470 Offset: 0x2342A70 VA: 0x182344470
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

	// RVA: 0x2344420 Offset: 0x2342A20 VA: 0x182344420
	private static IntPtr CreateScriptableObjectInstanceFromType_Injected(Type type, bool applyDefaultsAndReset) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[NativeHeader("Runtime/Export/Scripting/ScriptingRuntime.h")]
internal class ScriptingRuntime // TypeDefIndex: 9745
{
	// Methods

	// RVA: 0x2344590 Offset: 0x2342B90 VA: 0x182344590
	public static string[] GetAllUserAssemblies() { }
}

// Namespace: UnityEngine
internal class ScriptingUtility // TypeDefIndex: 9747
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0xB6ED80 Offset: 0xB6D380 VA: 0x180B6ED80
	private static bool IsManagedCodeWorking() { }

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void SetupCallbacks(IntPtr p) { }
}

// Namespace: UnityEngine
[Usage(4, Inherited = True, AllowMultiple = False)]
public class SelectionBaseAttribute : Attribute // TypeDefIndex: 9748
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
public static class StackTraceUtility // TypeDefIndex: 9749
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23454F0 Offset: 0x2343AF0 VA: 0x1823454F0
	internal static void SetProjectFolder(string folder) { }

	[RequiredByNativeCode]
	// RVA: 0x2344FC0 Offset: 0x23435C0 VA: 0x182344FC0
	public static string ExtractStackTrace() { }

	[RequiredByNativeCode]
	// RVA: 0x2345100 Offset: 0x2343700 VA: 0x182345100
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	// RVA: 0x2344830 Offset: 0x2342E30 VA: 0x182344830
	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0x2345610 Offset: 0x2343C10 VA: 0x182345610
	private static void .cctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
public class UnityException : Exception // TypeDefIndex: 9750
{
	// Methods

	// RVA: 0x2349550 Offset: 0x2347B50 VA: 0x182349550
	public void .ctor() { }

	// RVA: 0x2349640 Offset: 0x2347C40 VA: 0x182349640
	public void .ctor(string message) { }

	// RVA: 0x23495C0 Offset: 0x2347BC0 VA: 0x1823495C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : Object // TypeDefIndex: 9752
{
	// Properties
	public byte[] bytes { get; }
	public string text { get; }

	// Methods

	// RVA: 0x23469D0 Offset: 0x2344FD0 VA: 0x1823469D0
	public byte[] get_bytes() { }

	// RVA: 0x23468E0 Offset: 0x2344EE0 VA: 0x1823468E0
	public string get_text() { }

	// RVA: 0x23468E0 Offset: 0x2344EE0 VA: 0x1823468E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2346680 Offset: 0x2344C80 VA: 0x182346680
	internal static string DecodeString(byte[] bytes) { }

	// RVA: 0x2346990 Offset: 0x2344F90 VA: 0x182346990
	private static byte[] get_bytes_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public class TrackedReference // TypeDefIndex: 9753
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.AnimationModule" })]
	internal IntPtr m_Ptr; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
internal sealed class UnhandledExceptionHandler // TypeDefIndex: 9755
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2349430 Offset: 0x2347A30 VA: 0x182349430
	private static void RegisterUECatcher() { }
}

// Namespace: UnityEngine
[Flags]
public enum HideFlags // TypeDefIndex: 9756
{
	// Fields
	public int value__; // 0x0
	public const HideFlags None = 0;
	public const HideFlags HideInHierarchy = 1;
	public const HideFlags HideInInspector = 2;
	public const HideFlags DontSaveInEditor = 4;
	public const HideFlags NotEditable = 8;
	public const HideFlags DontSaveInBuild = 16;
	public const HideFlags DontUnloadUnusedAsset = 32;
	public const HideFlags DontSave = 52;
	public const HideFlags HideAndDontSave = 61;
}

// Namespace: UnityEngine
public enum FindObjectsSortMode // TypeDefIndex: 9757
{
	// Fields
	public int value__; // 0x0
	public const FindObjectsSortMode None = 0;
	public const FindObjectsSortMode InstanceID = 1;
}

// Namespace: UnityEngine
public enum FindObjectsInactive // TypeDefIndex: 9758
{
	// Fields
	public int value__; // 0x0
	public const FindObjectsInactive Exclude = 0;
	public const FindObjectsInactive Include = 1;
}

// Namespace: UnityEngine
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
public class Object // TypeDefIndex: 9760
{
	// Fields
	private const int kInstanceID_None = 0;
	private IntPtr m_CachedPtr; // 0x10
	internal static readonly int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x233D0F0 Offset: 0x233B6F0 VA: 0x18233D0F0
	public int GetInstanceID() { }

	// RVA: 0x233D0E0 Offset: 0x233B6E0 VA: 0x18233D0E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233C690 Offset: 0x233AC90 VA: 0x18233C690 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x233ED90 Offset: 0x233D390 VA: 0x18233ED90
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x233BEA0 Offset: 0x233A4A0 VA: 0x18233BEA0
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x233C5D0 Offset: 0x233ABD0 VA: 0x18233C5D0
	private void EnsureRunningOnMainThread() { }

	// RVA: 0x233E550 Offset: 0x233CB50 VA: 0x18233E550
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x101AB70 Offset: 0x1019170 VA: 0x18101AB70
	private IntPtr GetCachedPtr() { }

	// RVA: 0x233EC80 Offset: 0x233D280 VA: 0x18233EC80
	public string get_name() { }

	// RVA: 0x233F010 Offset: 0x233D610 VA: 0x18233F010
	public void set_name(string value) { }

	[TypeInferenceRule(3)]
	// RVA: 0x233D940 Offset: 0x233BF40 VA: 0x18233D940
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(3)]
	// RVA: 0x233D3D0 Offset: 0x233B9D0 VA: 0x18233D3D0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x233D730 Offset: 0x233BD30 VA: 0x18233D730
	public static Object Instantiate(Object original) { }

	[TypeInferenceRule(3)]
	// RVA: 0x233D370 Offset: 0x233B970 VA: 0x18233D370
	public static Object Instantiate(Object original, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x233DC30 Offset: 0x233C230 VA: 0x18233DC30
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73A340 Offset: 0x738940 VA: 0x18073A340
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73A070 Offset: 0x738670 VA: 0x18073A070
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73A150 Offset: 0x738750 VA: 0x18073A150
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73A250 Offset: 0x738850 VA: 0x18073A250
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73A470 Offset: 0x738A70 VA: 0x18073A470
	|-Object.Instantiate<object>
	*/

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x233C330 Offset: 0x233A930 VA: 0x18233C330
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocs]
	// RVA: 0x233C3D0 Offset: 0x233A9D0 VA: 0x18233C3D0
	public static void Destroy(Object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x233C0B0 Offset: 0x233A6B0 VA: 0x18233C0B0
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocs]
	// RVA: 0x233BFF0 Offset: 0x233A5F0 VA: 0x18233BFF0
	public static void DestroyImmediate(Object obj) { }

	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID, but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	// RVA: 0x233CEC0 Offset: 0x233B4C0 VA: 0x18233CEC0
	public static Object[] FindObjectsOfType(Type type) { }

	[TypeInferenceRule(2)]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	// RVA: 0x233CF30 Offset: 0x233B530 VA: 0x18233CF30
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	// RVA: 0x233CD90 Offset: 0x233B390 VA: 0x18233CD90
	public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	[TypeInferenceRule(2)]
	// RVA: 0x233CD40 Offset: 0x233B340 VA: 0x18233CD40
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	// RVA: 0x233C510 Offset: 0x233AB10 VA: 0x18233C510
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x233EBE0 Offset: 0x233D1E0 VA: 0x18233EBE0
	public HideFlags get_hideFlags() { }

	// RVA: 0x233EF60 Offset: 0x233D560 VA: 0x18233EF60
	public void set_hideFlags(HideFlags value) { }

	[Obsolete("use Object.Destroy instead.")]
	// RVA: 0x233C150 Offset: 0x233A750 VA: 0x18233C150
	public static void DestroyObject(Object obj, float t) { }

	[ExcludeFromDocs]
	[Obsolete("use Object.Destroy instead.")]
	// RVA: 0x233C220 Offset: 0x233A820 VA: 0x18233C220
	public static void DestroyObject(Object obj) { }

	[Obsolete("Object.FindSceneObjectsOfType has been deprecated, Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindSceneObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	// RVA: 0x233CF80 Offset: 0x233B580 VA: 0x18233CF80
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
	// RVA: 0x233CE80 Offset: 0x233B480 VA: 0x18233CE80
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739FD0 Offset: 0x7385D0 VA: 0x180739FD0
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindObjectsByType<T>(FindObjectsSortMode sortMode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739DC0 Offset: 0x7383C0 VA: 0x180739DC0
	|-Object.FindObjectsByType<object>
	*/

	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739F20 Offset: 0x738520 VA: 0x180739F20
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739E70 Offset: 0x738470 VA: 0x180739E70
	|-Object.FindObjectsByType<object>
	*/

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739C00 Offset: 0x738200 VA: 0x180739C00
	|-Object.FindObjectOfType<object>
	*/

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739CE0 Offset: 0x7382E0 VA: 0x180739CE0
	|-Object.FindObjectOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindFirstObjectByType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739A40 Offset: 0x738040 VA: 0x180739A40
	|-Object.FindFirstObjectByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAnyObjectByType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739960 Offset: 0x737F60 VA: 0x180739960
	|-Object.FindAnyObjectByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739B20 Offset: 0x738120 VA: 0x180739B20
	|-Object.FindFirstObjectByType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x739880 Offset: 0x737E80 VA: 0x180739880
	|-Object.FindAnyObjectByType<object>
	*/

	[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
	// RVA: 0x233CE10 Offset: 0x233B410 VA: 0x18233CE10
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x233BE40 Offset: 0x233A440 VA: 0x18233BE40
	private static void CheckNullArgument(object arg, string message) { }

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[TypeInferenceRule(0)]
	// RVA: 0x233CCB0 Offset: 0x233B2B0 VA: 0x18233CCB0
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0x233CA00 Offset: 0x233B000 VA: 0x18233CA00
	public static Object FindFirstObjectByType(Type type) { }

	// RVA: 0x233C8B0 Offset: 0x233AEB0 VA: 0x18233C8B0
	public static Object FindAnyObjectByType(Type type) { }

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[TypeInferenceRule(0)]
	// RVA: 0x233CC10 Offset: 0x233B210 VA: 0x18233CC10
	public static Object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x233CAA0 Offset: 0x233B0A0 VA: 0x18233CAA0
	public static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x233C950 Offset: 0x233AF50 VA: 0x18233C950
	public static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x233E9D0 Offset: 0x233CFD0 VA: 0x18233E9D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x233EC90 Offset: 0x233D290 VA: 0x18233EC90
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x233EE20 Offset: 0x233D420 VA: 0x18233EE20
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x233D2F0 Offset: 0x233B8F0 VA: 0x18233D2F0
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[NativeMethod(Name = "CurrentThreadIsMainThread", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x233BF70 Offset: 0x233A570 VA: 0x18233BF70
	private static bool CurrentThreadIsMainThread() { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x233E130 Offset: 0x233C730 VA: 0x18233E130
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunction("CloneObject")]
	// RVA: 0x233DFA0 Offset: 0x233C5A0 VA: 0x18233DFA0
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x233E450 Offset: 0x233CA50 VA: 0x18233E450
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x233E280 Offset: 0x233C880 VA: 0x18233E280
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	// RVA: 0x233EA20 Offset: 0x233D020 VA: 0x18233EA20
	private static string ToString(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::GetName", HasExplicitThis = True)]
	// RVA: 0x233D1C0 Offset: 0x233B7C0 VA: 0x18233D1C0
	private string GetName() { }

	[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
	// RVA: 0x233E5B0 Offset: 0x233CBB0 VA: 0x18233E5B0
	internal static bool IsPersistent(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::SetName", HasExplicitThis = True)]
	// RVA: 0x233E7A0 Offset: 0x233CDA0 VA: 0x18233E7A0
	private void SetName(string name) { }

	[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x233C490 Offset: 0x233AA90 VA: 0x18233C490
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	// RVA: 0x233CB90 Offset: 0x233B190 VA: 0x18233CB90
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	[FreeFunction("UnityEngineObjectBindings::GetPtrFromInstanceID")]
	// RVA: 0x233D320 Offset: 0x233B920 VA: 0x18233D320
	private static IntPtr GetPtrFromInstanceID(int instanceID, Type objectType, out bool isMonoBehaviour) { }

	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	// RVA: 0x233D060 Offset: 0x233B660 VA: 0x18233D060
	internal static Object ForceLoadFromInstanceID(int instanceID) { }

	[FreeFunction("UnityEngineObjectBindings::MarkObjectDirty", HasExplicitThis = True)]
	// RVA: 0x233E6B0 Offset: 0x233CCB0 VA: 0x18233E6B0
	internal void MarkDirty() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x233EB40 Offset: 0x233D140 VA: 0x18233EB40
	private static void .cctor() { }

	// RVA: 0x233C2E0 Offset: 0x233A8E0 VA: 0x18233C2E0
	private static void Destroy_Injected(IntPtr obj, float t) { }

	// RVA: 0x233BFA0 Offset: 0x233A5A0 VA: 0x18233BFA0
	private static void DestroyImmediate_Injected(IntPtr obj, bool allowDestroyingAssets) { }

	// RVA: 0x233C4D0 Offset: 0x233AAD0 VA: 0x18233C4D0
	private static void DontDestroyOnLoad_Injected(IntPtr target) { }

	// RVA: 0x233EBA0 Offset: 0x233D1A0 VA: 0x18233EBA0
	private static HideFlags get_hideFlags_Injected(IntPtr _unity_self) { }

	// RVA: 0x233EF20 Offset: 0x233D520 VA: 0x18233EF20
	private static void set_hideFlags_Injected(IntPtr _unity_self, HideFlags value) { }

	// RVA: 0x233E0F0 Offset: 0x233C6F0 VA: 0x18233E0F0
	private static IntPtr Internal_CloneSingle_Injected(IntPtr data) { }

	// RVA: 0x233DF40 Offset: 0x233C540 VA: 0x18233DF40
	private static IntPtr Internal_CloneSingleWithParent_Injected(IntPtr data, IntPtr parent, bool worldPositionStays) { }

	// RVA: 0x233E3F0 Offset: 0x233C9F0 VA: 0x18233E3F0
	private static IntPtr Internal_InstantiateSingle_Injected(IntPtr data, in Vector3 pos, in Quaternion rot) { }

	// RVA: 0x233E210 Offset: 0x233C810 VA: 0x18233E210
	private static IntPtr Internal_InstantiateSingleWithParent_Injected(IntPtr data, IntPtr parent, in Vector3 pos, in Quaternion rot) { }

	// RVA: 0x233E980 Offset: 0x233CF80 VA: 0x18233E980
	private static void ToString_Injected(IntPtr obj, out ManagedSpanWrapper ret) { }

	// RVA: 0x233D170 Offset: 0x233B770 VA: 0x18233D170
	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x233E570 Offset: 0x233CB70 VA: 0x18233E570
	private static bool IsPersistent_Injected(IntPtr obj) { }

	// RVA: 0x233E750 Offset: 0x233CD50 VA: 0x18233E750
	private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x233CB50 Offset: 0x233B150 VA: 0x18233CB50
	private static IntPtr FindObjectFromInstanceID_Injected(int instanceID) { }

	// RVA: 0x233D020 Offset: 0x233B620 VA: 0x18233D020
	private static IntPtr ForceLoadFromInstanceID_Injected(int instanceID) { }

	// RVA: 0x233E670 Offset: 0x233CC70 VA: 0x18233E670
	private static void MarkDirty_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 9762
{
	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x234A280 Offset: 0x2348880 VA: 0x18234A280
	private void .ctor(int mainThreadID) { }

	// RVA: 0x234A1C0 Offset: 0x23487C0 VA: 0x18234A1C0
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x2349F20 Offset: 0x2348520 VA: 0x182349F20 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x2349D50 Offset: 0x2348350 VA: 0x182349D50 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x2349D40 Offset: 0x2348340 VA: 0x182349D40 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x2349D60 Offset: 0x2348360 VA: 0x182349D60 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x23496B0 Offset: 0x2347CB0 VA: 0x1823496B0 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x2349790 Offset: 0x2347D90 VA: 0x182349790
	public void Exec() { }

	// RVA: 0x2349B40 Offset: 0x2348140 VA: 0x182349B40
	private bool HasPendingTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x2349BA0 Offset: 0x23481A0 VA: 0x182349BA0
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCode]
	// RVA: 0x2349AE0 Offset: 0x23480E0 VA: 0x182349AE0
	private static void ExecuteTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x2349980 Offset: 0x2347F80 VA: 0x182349980
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForEndOfFrame : YieldInstruction // TypeDefIndex: 9763
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForFixedUpdate : YieldInstruction // TypeDefIndex: 9764
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForSeconds : YieldInstruction // TypeDefIndex: 9765
{
	// Fields
	internal float m_Seconds; // 0x10

	// Methods

	// RVA: 0x234C570 Offset: 0x234AB70 VA: 0x18234C570
	public void .ctor(float seconds) { }
}

// Namespace: UnityEngine
public class WaitForSecondsRealtime : CustomYieldInstruction // TypeDefIndex: 9766
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Properties
	public float waitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_waitTime() { }

	[CompilerGenerated]
	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	public void set_waitTime(float value) { }

	// RVA: 0x234C4D0 Offset: 0x234AAD0 VA: 0x18234C4D0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x234C4A0 Offset: 0x234AAA0 VA: 0x18234C4A0
	public void .ctor(float time) { }

	// RVA: 0x234C490 Offset: 0x234AA90 VA: 0x18234C490 Slot: 8
	public override void Reset() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public class YieldInstruction // TypeDefIndex: 9767
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class SerializeField : Attribute // TypeDefIndex: 9768
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(256)]
public sealed class SerializeReference : Attribute // TypeDefIndex: 9769
{
	// Methods

	[ExcludeFromDocs]
	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(4)]
public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 9770
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public interface ISerializationCallbackReceiver // TypeDefIndex: 9771
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeforeSerialize();

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAfterDeserialize();
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[NativeClass("GraphicsBuffer")]
public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 9773
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public int count { get; }

	// Methods

	// RVA: 0x2332300 Offset: 0x2330900 VA: 0x182332300 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2332180 Offset: 0x2330780 VA: 0x182332180 Slot: 4
	public void Dispose() { }

	// RVA: 0x2332240 Offset: 0x2330840 VA: 0x182332240
	private void Dispose(bool disposing) { }

	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	// RVA: 0x23323B0 Offset: 0x23309B0 VA: 0x1823323B0
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
	// RVA: 0x2332140 Offset: 0x2330740 VA: 0x182332140
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x23329C0 Offset: 0x2330FC0 VA: 0x1823329C0
	public void .ctor(int count, int stride) { }

	// RVA: 0x2332790 Offset: 0x2330D90 VA: 0x182332790
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x23327C0 Offset: 0x2330DC0 VA: 0x1823327C0
	private void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x2332180 Offset: 0x2330780 VA: 0x182332180
	public void Release() { }

	// RVA: 0x2332A30 Offset: 0x2331030 VA: 0x182332A30
	public int get_count() { }

	// RVA: 0x23325F0 Offset: 0x2330BF0 VA: 0x1823325F0
	public void SetData(Array data) { }

	// RVA: -1 Offset: -1
	public void SetData<T>(List<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BB210 Offset: 0x6B9810 VA: 0x1806BB210
	|-ComputeBuffer.SetData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x6BAF50 Offset: 0x6B9550 VA: 0x1806BAF50
	|-ComputeBuffer.SetData<GrassChunkManager.GrassData>
	*/

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BAEC0 Offset: 0x6B94C0 VA: 0x1806BAEC0
	|-ComputeBuffer.SetData<BezierCurve>
	|
	|-RVA: 0x6BB410 Offset: 0x6B9A10 VA: 0x1806BB410
	|-ComputeBuffer.SetData<float>
	|
	|-RVA: 0x6BB150 Offset: 0x6B9750 VA: 0x1806BB150
	|-ComputeBuffer.SetData<__Il2CppFullySharedGenericStructType>
	*/

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2332570 Offset: 0x2330B70 VA: 0x182332570
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2332480 Offset: 0x2330A80 VA: 0x182332480
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2332100 Offset: 0x2330700 VA: 0x182332100
	private static void DestroyBuffer_Injected(IntPtr buf) { }

	// RVA: 0x23329F0 Offset: 0x2330FF0 VA: 0x1823329F0
	private static int get_count_Injected(IntPtr _unity_self) { }

	// RVA: 0x2332500 Offset: 0x2330B00 VA: 0x182332500
	private static void InternalSetNativeData_Injected(IntPtr _unity_self, IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2332410 Offset: 0x2330A10 VA: 0x182332410
	private static void InternalSetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingAccelerationStructure.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public sealed class ComputeShader : Object // TypeDefIndex: 9774
{
	// Methods

	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	// RVA: 0x2332AE0 Offset: 0x23310E0 VA: 0x182332AE0
	public int FindKernel(string name) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = True)]
	// RVA: 0x2333100 Offset: 0x2331700 VA: 0x182333100
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	// RVA: 0x2332E10 Offset: 0x2331410 VA: 0x182332E10
	private void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	// RVA: 0x2332E10 Offset: 0x2331410 VA: 0x182332E10
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2332D00 Offset: 0x2331300 VA: 0x182332D00
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	// RVA: 0x2333050 Offset: 0x2331650 VA: 0x182333050
	public void SetVector(string name, Vector4 val) { }

	// RVA: 0x2332F00 Offset: 0x2331500 VA: 0x182332F00
	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x2332A90 Offset: 0x2331090 VA: 0x182332A90
	private static int FindKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x2333000 Offset: 0x2331600 VA: 0x182333000
	private static void SetVector_Injected(IntPtr _unity_self, int nameID, in Vector4 val) { }

	// RVA: 0x2332DB0 Offset: 0x23313B0 VA: 0x182332DB0
	private static void Internal_SetBuffer_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr buffer) { }

	// RVA: 0x2332CA0 Offset: 0x23312A0 VA: 0x182332CA0
	private static void GetKernelThreadGroupSizes_Injected(IntPtr _unity_self, int kernelIndex, out uint x, out uint y, out uint z) { }
}

// Namespace: UnityEngine
public sealed class ShaderVariantCollection : Object // TypeDefIndex: 9775
{}

// Namespace: UnityEngine
public sealed class StaticBatchingUtility // TypeDefIndex: 9776
{
	// Fields
	internal static ProfilerMarker s_CombineMarker; // 0x0

	// Methods

	// RVA: 0x2345980 Offset: 0x2343F80 VA: 0x182345980
	public static void Combine(GameObject staticBatchRoot) { }

	// RVA: 0x2345680 Offset: 0x2343C80 VA: 0x182345680
	private static void CombineRoot(GameObject staticBatchRoot) { }

	// RVA: 0x2345A60 Offset: 0x2344060 VA: 0x182345A60
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal class LowerResBlitTexture : Object // TypeDefIndex: 9777
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void LowerResBlitTextureDontStripMe() { }
}

// Namespace: UnityEngine
internal class PreloadData : Object // TypeDefIndex: 9778
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void PreloadDataDontStripMe() { }
}

// Namespace: UnityEngine
public enum OperatingSystemFamily // TypeDefIndex: 9779
{
	// Fields
	public int value__; // 0x0
	public const OperatingSystemFamily Other = 0;
	public const OperatingSystemFamily MacOSX = 1;
	public const OperatingSystemFamily Windows = 2;
	public const OperatingSystemFamily Linux = 3;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/SystemInfoMemory.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
public sealed class SystemInfo // TypeDefIndex: 9780
{
	// Properties
	public static string operatingSystem { get; }
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static string processorType { get; }
	public static int systemMemorySize { get; }
	public static string deviceName { get; }
	public static string deviceModel { get; }
	public static GraphicsDeviceType graphicsDeviceType { get; }
	public static bool graphicsUVStartsAtTop { get; }
	public static int graphicsShaderLevel { get; }
	public static bool supportsMotionVectors { get; }
	public static bool supports3DRenderTextures { get; }
	public static CopyTextureSupport copyTextureSupport { get; }
	public static bool supportsComputeShaders { get; }
	public static bool supportsInstancing { get; }
	public static int supportedRenderTargetCount { get; }
	public static bool usesReversedZBuffer { get; }
	public static int maxTextureSize { get; }
	internal static int maxRenderTextureSize { get; }
	public static long maxGraphicsBufferSize { get; }
	public static bool usesLoadStoreActions { get; }
	public static bool supportsIndirectArgumentsBuffer { get; }

	// Methods

	// RVA: 0x2346630 Offset: 0x2344C30 VA: 0x182346630
	public static string get_operatingSystem() { }

	// RVA: 0x2345F00 Offset: 0x2344500 VA: 0x182345F00
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x2346640 Offset: 0x2344C40 VA: 0x182346640
	public static string get_processorType() { }

	// RVA: 0x2346020 Offset: 0x2344620 VA: 0x182346020
	public static int get_systemMemorySize() { }

	// RVA: 0x2346620 Offset: 0x2344C20 VA: 0x182346620
	public static string get_deviceName() { }

	// RVA: 0x2346610 Offset: 0x2344C10 VA: 0x182346610
	public static string get_deviceModel() { }

	// RVA: 0x2345DD0 Offset: 0x23443D0 VA: 0x182345DD0
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x2345E70 Offset: 0x2344470 VA: 0x182345E70
	public static bool get_graphicsUVStartsAtTop() { }

	// RVA: 0x2345E40 Offset: 0x2344440 VA: 0x182345E40
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x2346340 Offset: 0x2344940 VA: 0x182346340
	public static bool get_supportsMotionVectors() { }

	// RVA: 0x2346280 Offset: 0x2344880 VA: 0x182346280
	public static bool get_supports3DRenderTextures() { }

	// RVA: 0x2345BC0 Offset: 0x23441C0 VA: 0x182345BC0
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x23462B0 Offset: 0x23448B0 VA: 0x1823462B0
	public static bool get_supportsComputeShaders() { }

	// RVA: 0x2346310 Offset: 0x2344910 VA: 0x182346310
	public static bool get_supportsInstancing() { }

	// RVA: 0x2346250 Offset: 0x2344850 VA: 0x182346250
	public static int get_supportedRenderTargetCount() { }

	// RVA: 0x23465E0 Offset: 0x2344BE0 VA: 0x1823465E0
	public static bool get_usesReversedZBuffer() { }

	// RVA: 0x23461C0 Offset: 0x23447C0 VA: 0x1823461C0
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x2346370 Offset: 0x2344970 VA: 0x182346370
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x23464B0 Offset: 0x2344AB0 VA: 0x1823464B0
	public static bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x2345ED0 Offset: 0x23444D0 VA: 0x182345ED0
	public static int get_maxTextureSize() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2345EA0 Offset: 0x23444A0 VA: 0x182345EA0
	internal static int get_maxRenderTextureSize() { }

	// RVA: 0x2346220 Offset: 0x2344820 VA: 0x182346220
	public static long get_maxGraphicsBufferSize() { }

	// RVA: 0x23465B0 Offset: 0x2344BB0 VA: 0x1823465B0
	public static bool get_usesLoadStoreActions() { }

	// RVA: 0x23462E0 Offset: 0x23448E0 VA: 0x1823462E0
	public static bool get_supportsIndirectArgumentsBuffer() { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	// RVA: 0x2345F70 Offset: 0x2344570 VA: 0x182345F70
	private static string GetOperatingSystem() { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	// RVA: 0x2345F00 Offset: 0x2344500 VA: 0x182345F00
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetProcessorType")]
	// RVA: 0x2346090 Offset: 0x2344690 VA: 0x182346090
	private static string GetProcessorType() { }

	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	// RVA: 0x2346020 Offset: 0x2344620 VA: 0x182346020
	private static int GetPhysicalMemoryMB() { }

	[FreeFunction("systeminfo::GetDeviceName")]
	// RVA: 0x2345D20 Offset: 0x2344320 VA: 0x182345D20
	private static string GetDeviceName() { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	// RVA: 0x2345C30 Offset: 0x2344230 VA: 0x182345C30
	private static string GetDeviceModel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	// RVA: 0x2345DD0 Offset: 0x23443D0 VA: 0x182345DD0
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	// RVA: 0x2345E70 Offset: 0x2344470 VA: 0x182345E70
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	// RVA: 0x2345E40 Offset: 0x2344440 VA: 0x182345E40
	private static int GetGraphicsShaderLevel() { }

	[FreeFunction("SupportsMotionVectors")]
	// RVA: 0x2346340 Offset: 0x2344940 VA: 0x182346340
	private static bool SupportsMotionVectors() { }

	[FreeFunction("ScriptingGraphicsCaps::Supports3DRenderTextures")]
	// RVA: 0x2346280 Offset: 0x2344880 VA: 0x182346280
	private static bool Supports3DRenderTextures() { }

	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	// RVA: 0x2345BC0 Offset: 0x23441C0 VA: 0x182345BC0
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	// RVA: 0x23462B0 Offset: 0x23448B0 VA: 0x1823462B0
	private static bool SupportsComputeShaders() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
	// RVA: 0x2346310 Offset: 0x2344910 VA: 0x182346310
	private static bool SupportsInstancing() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	// RVA: 0x2346250 Offset: 0x2344850 VA: 0x182346250
	private static int SupportedRenderTargetCount() { }

	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	// RVA: 0x23465E0 Offset: 0x2344BE0 VA: 0x1823465E0
	private static bool UsesReversedZBuffer() { }

	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	// RVA: 0x2346140 Offset: 0x2344740 VA: 0x182346140
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	// RVA: 0x2346470 Offset: 0x2344A70 VA: 0x182346470
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	// RVA: 0x2345ED0 Offset: 0x23444D0 VA: 0x182345ED0
	private static int GetMaxTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	// RVA: 0x2345EA0 Offset: 0x23444A0 VA: 0x182345EA0
	private static int GetMaxRenderTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	// RVA: 0x2346220 Offset: 0x2344820 VA: 0x182346220
	private static long MaxGraphicsBufferSize() { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	// RVA: 0x2346180 Offset: 0x2344780 VA: 0x182346180
	public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	// RVA: 0x2345B80 Offset: 0x2344180 VA: 0x182345B80
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	// RVA: 0x2345E00 Offset: 0x2344400 VA: 0x182345E00
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
	// RVA: 0x23465B0 Offset: 0x2344BB0 VA: 0x1823465B0
	private static bool UsesLoadStoreActions() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsIndirectArgumentsBuffer")]
	// RVA: 0x23462E0 Offset: 0x23448E0 VA: 0x1823462E0
	private static bool SupportsIndirectArgumentsBuffer() { }

	// RVA: 0x2345F30 Offset: 0x2344530 VA: 0x182345F30
	private static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x2346050 Offset: 0x2344650 VA: 0x182346050
	private static void GetProcessorType_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x2345CE0 Offset: 0x23442E0 VA: 0x182345CE0
	private static void GetDeviceName_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x2345BF0 Offset: 0x23441F0 VA: 0x182345BF0
	private static void GetDeviceModel_Injected(out ManagedSpanWrapper ret) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
internal class SystemClock // TypeDefIndex: 9781
{
	// Fields
	private static readonly DateTime s_Epoch; // 0x0

	// Properties
	public static DateTime now { get; }

	// Methods

	// RVA: 0x2345B40 Offset: 0x2344140 VA: 0x182345B40
	public static DateTime get_now() { }

	// RVA: 0x2345AC0 Offset: 0x23440C0 VA: 0x182345AC0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("GetTimeManager()", 0)]
[NativeHeader("Runtime/Input/TimeManager.h")]
public class Time // TypeDefIndex: 9782
{
	// Properties
	[NativeProperty("CurTime")]
	public static float time { get; }
	[NativeProperty("CurTimeRational")]
	public static RationalTime timeAsRational { get; }
	public static float deltaTime { get; }
	public static float unscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float fixedDeltaTime { get; }
	public static float smoothDeltaTime { get; }
	public static float timeScale { get; set; }
	public static int frameCount { get; }
	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount { get; }
	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup { get; }

	// Methods

	// RVA: 0x2346C20 Offset: 0x2345220 VA: 0x182346C20
	public static float get_time() { }

	// RVA: 0x2346BB0 Offset: 0x23451B0 VA: 0x182346BB0
	public static RationalTime get_timeAsRational() { }

	// RVA: 0x2346A50 Offset: 0x2345050 VA: 0x182346A50
	public static float get_deltaTime() { }

	// RVA: 0x2346C80 Offset: 0x2345280 VA: 0x182346C80
	public static float get_unscaledTime() { }

	// RVA: 0x2346C50 Offset: 0x2345250 VA: 0x182346C50
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x2346A80 Offset: 0x2345080 VA: 0x182346A80
	public static float get_fixedDeltaTime() { }

	// RVA: 0x2346B40 Offset: 0x2345140 VA: 0x182346B40
	public static float get_smoothDeltaTime() { }

	// RVA: 0x2346BF0 Offset: 0x23451F0 VA: 0x182346BF0
	public static float get_timeScale() { }

	// RVA: 0x2346CB0 Offset: 0x23452B0 VA: 0x182346CB0
	public static void set_timeScale(float value) { }

	// RVA: 0x2346AB0 Offset: 0x23450B0 VA: 0x182346AB0
	public static int get_frameCount() { }

	// RVA: 0x2346B10 Offset: 0x2345110 VA: 0x182346B10
	public static int get_renderedFrameCount() { }

	// RVA: 0x2346AE0 Offset: 0x23450E0 VA: 0x182346AE0
	public static float get_realtimeSinceStartup() { }

	// RVA: 0x2346B70 Offset: 0x2345170 VA: 0x182346B70
	private static void get_timeAsRational_Injected(out RationalTime ret) { }
}

// Namespace: UnityEngine
internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 9783
{
	// Fields
	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14
}

// Namespace: UnityEngine
[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
public class TouchScreenKeyboard // TypeDefIndex: 9786
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <disableInPlaceEditing>k__BackingField; // 0x0

	// Properties
	public static bool isSupported { get; }
	internal static bool disableInPlaceEditing { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }

	// Methods

	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	// RVA: 0x2346EA0 Offset: 0x23454A0 VA: 0x182346EA0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2346CF0 Offset: 0x23452F0 VA: 0x182346CF0
	private void Destroy() { }

	// RVA: 0x2346D80 Offset: 0x2345380 VA: 0x182346D80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x23474E0 Offset: 0x2345AE0 VA: 0x1823474E0
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	// RVA: 0x2347250 Offset: 0x2345850 VA: 0x182347250
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x2347870 Offset: 0x2345E70 VA: 0x182347870
	public static bool get_isSupported() { }

	[CompilerGenerated]
	// RVA: 0x23477D0 Offset: 0x2345DD0 VA: 0x1823477D0
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x2347810 Offset: 0x2345E10 VA: 0x182347810
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x2346EE0 Offset: 0x23454E0 VA: 0x182346EE0
	private static bool IsInPlaceEditingAllowed() { }

	// RVA: 0x2346F10 Offset: 0x2345510 VA: 0x182346F10
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocs]
	// RVA: 0x2347050 Offset: 0x2345650 VA: 0x182347050
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeName("GetText")]
	// RVA: 0x2347A30 Offset: 0x2346030 VA: 0x182347A30
	public string get_text() { }

	[NativeName("SetText")]
	// RVA: 0x2347DB0 Offset: 0x23463B0 VA: 0x182347DB0
	public void set_text(string value) { }

	[NativeName("SetInputHidden")]
	// RVA: 0x2347C50 Offset: 0x2346250 VA: 0x182347C50
	public static void set_hideInput(bool value) { }

	[NativeName("IsActive")]
	// RVA: 0x2347630 Offset: 0x2345C30 VA: 0x182347630
	public bool get_active() { }

	[NativeName("SetActive")]
	// RVA: 0x2347B50 Offset: 0x2346150 VA: 0x182347B50
	public void set_active(bool value) { }

	[NativeName("GetKeyboardStatus")]
	// RVA: 0x2347980 Offset: 0x2345F80 VA: 0x182347980
	public TouchScreenKeyboard.Status get_status() { }

	[NativeName("SetCharacterLimit")]
	// RVA: 0x2347BF0 Offset: 0x23461F0 VA: 0x182347BF0
	public void set_characterLimit(int value) { }

	[NativeName("CanGetSelection")]
	// RVA: 0x23476D0 Offset: 0x2345CD0 VA: 0x1823476D0
	public bool get_canGetSelection() { }

	[NativeName("CanSetSelection")]
	// RVA: 0x2347770 Offset: 0x2345D70 VA: 0x182347770
	public bool get_canSetSelection() { }

	// RVA: 0x23478F0 Offset: 0x2345EF0 VA: 0x1823478F0
	public RangeInt get_selection() { }

	// RVA: 0x2347C90 Offset: 0x2346290 VA: 0x182347C90
	public void set_selection(RangeInt value) { }

	// RVA: 0x2346E50 Offset: 0x2345450 VA: 0x182346E50
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x23471B0 Offset: 0x23457B0 VA: 0x1823471B0
	private static void SetSelection(int start, int length) { }

	// RVA: 0x23471F0 Offset: 0x23457F0 VA: 0x1823471F0
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref ManagedSpanWrapper text, ref ManagedSpanWrapper textPlaceholder) { }

	// RVA: 0x23479E0 Offset: 0x2345FE0 VA: 0x1823479E0
	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2347D60 Offset: 0x2346360 VA: 0x182347D60
	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x23475F0 Offset: 0x2345BF0 VA: 0x1823475F0
	private static bool get_active_Injected(IntPtr _unity_self) { }

	// RVA: 0x2347B00 Offset: 0x2346100 VA: 0x182347B00
	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2347940 Offset: 0x2345F40 VA: 0x182347940
	private static TouchScreenKeyboard.Status get_status_Injected(IntPtr _unity_self) { }

	// RVA: 0x2347BB0 Offset: 0x23461B0 VA: 0x182347BB0
	private static void set_characterLimit_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x2347690 Offset: 0x2345C90 VA: 0x182347690
	private static bool get_canGetSelection_Injected(IntPtr _unity_self) { }

	// RVA: 0x2347730 Offset: 0x2345D30 VA: 0x182347730
	private static bool get_canSetSelection_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
public enum TouchScreenKeyboardType // TypeDefIndex: 9787
{
	// Fields
	public int value__; // 0x0
	public const TouchScreenKeyboardType Default = 0;
	public const TouchScreenKeyboardType ASCIICapable = 1;
	public const TouchScreenKeyboardType NumbersAndPunctuation = 2;
	public const TouchScreenKeyboardType URL = 3;
	public const TouchScreenKeyboardType NumberPad = 4;
	public const TouchScreenKeyboardType PhonePad = 5;
	public const TouchScreenKeyboardType NamePhonePad = 6;
	public const TouchScreenKeyboardType EmailAddress = 7;
	[Obsolete("Wii U is no longer supported as of Unity 2018.1.")]
	public const TouchScreenKeyboardType NintendoNetworkAccount = 8;
	public const TouchScreenKeyboardType Social = 9;
	public const TouchScreenKeyboardType Search = 10;
	public const TouchScreenKeyboardType DecimalPad = 11;
	public const TouchScreenKeyboardType OneTimeCode = 12;
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal static class UINumericFieldsUtils // TypeDefIndex: 9788
{
	// Fields
	public static readonly string k_AllowedCharactersForFloat; // 0x0
	public static readonly string k_AllowedCharactersForInt; // 0x8
	public static readonly string k_DoubleFieldFormatString; // 0x10
	public static readonly string k_FloatFieldFormatString; // 0x18
	public static readonly string k_IntFieldFormatString; // 0x20

	// Methods

	// RVA: 0x23488A0 Offset: 0x2346EA0 VA: 0x1823488A0
	public static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x2348A30 Offset: 0x2347030 VA: 0x182348A30
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value) { }

	// RVA: 0x2348B50 Offset: 0x2347150 VA: 0x182348B50
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value) { }

	// RVA: 0x2348DD0 Offset: 0x23473D0 VA: 0x182348DD0
	public static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x2348E50 Offset: 0x2347450 VA: 0x182348E50
	public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value) { }

	// RVA: 0x23490A0 Offset: 0x23476A0 VA: 0x1823490A0
	public static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x2349120 Offset: 0x2347720 VA: 0x182349120
	public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value) { }

	// RVA: 0x2348D20 Offset: 0x2347320 VA: 0x182348D20
	public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value) { }

	// RVA: 0x2348FF0 Offset: 0x23475F0 VA: 0x182348FF0
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value) { }

	// RVA: 0x23492C0 Offset: 0x23478C0 VA: 0x1823492C0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Flags]
public enum DrivenTransformProperties // TypeDefIndex: 9789
{
	// Fields
	public int value__; // 0x0
	public const DrivenTransformProperties None = 0;
	public const DrivenTransformProperties All = -1;
	public const DrivenTransformProperties AnchoredPositionX = 2;
	public const DrivenTransformProperties AnchoredPositionY = 4;
	public const DrivenTransformProperties AnchoredPositionZ = 8;
	public const DrivenTransformProperties Rotation = 16;
	public const DrivenTransformProperties ScaleX = 32;
	public const DrivenTransformProperties ScaleY = 64;
	public const DrivenTransformProperties ScaleZ = 128;
	public const DrivenTransformProperties AnchorMinX = 256;
	public const DrivenTransformProperties AnchorMinY = 512;
	public const DrivenTransformProperties AnchorMaxX = 1024;
	public const DrivenTransformProperties AnchorMaxY = 2048;
	public const DrivenTransformProperties SizeDeltaX = 4096;
	public const DrivenTransformProperties SizeDeltaY = 8192;
	public const DrivenTransformProperties PivotX = 16384;
	public const DrivenTransformProperties PivotY = 32768;
	public const DrivenTransformProperties AnchoredPosition = 6;
	public const DrivenTransformProperties AnchoredPosition3D = 14;
	public const DrivenTransformProperties Scale = 224;
	public const DrivenTransformProperties AnchorMin = 768;
	public const DrivenTransformProperties AnchorMax = 3072;
	public const DrivenTransformProperties Anchors = 3840;
	public const DrivenTransformProperties SizeDelta = 12288;
	public const DrivenTransformProperties Pivot = 49152;
}

// Namespace: UnityEngine
public struct DrivenRectTransformTracker // TypeDefIndex: 9790
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Clear() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeClass("UI::RectTransform")]
public sealed class RectTransform : Transform // TypeDefIndex: 9793
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23419A0 Offset: 0x233FFA0 VA: 0x1823419A0
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGenerated]
	// RVA: 0x23423D0 Offset: 0x23409D0 VA: 0x1823423D0
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x2342260 Offset: 0x2340860 VA: 0x182342260
	public Rect get_rect() { }

	// RVA: 0x2341B90 Offset: 0x2340190 VA: 0x182341B90
	public Vector2 get_anchorMin() { }

	// RVA: 0x23425C0 Offset: 0x2340BC0 VA: 0x1823425C0
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x2341AB0 Offset: 0x23400B0 VA: 0x182341AB0
	public Vector2 get_anchorMax() { }

	// RVA: 0x23424E0 Offset: 0x2340AE0 VA: 0x1823424E0
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x2341D50 Offset: 0x2340350 VA: 0x182341D50
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x2342780 Offset: 0x2340D80 VA: 0x182342780
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x2342340 Offset: 0x2340940 VA: 0x182342340
	public Vector2 get_sizeDelta() { }

	// RVA: 0x2343120 Offset: 0x2341720 VA: 0x182343120
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x2342180 Offset: 0x2340780 VA: 0x182342180
	public Vector2 get_pivot() { }

	// RVA: 0x2343040 Offset: 0x2341640 VA: 0x182343040
	public void set_pivot(Vector2 value) { }

	// RVA: 0x2341C20 Offset: 0x2340220 VA: 0x182341C20
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x2342650 Offset: 0x2340C50 VA: 0x182342650
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x2341FB0 Offset: 0x23405B0 VA: 0x182341FB0
	public Vector2 get_offsetMin() { }

	// RVA: 0x2342BF0 Offset: 0x23411F0 VA: 0x182342BF0
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x2341DE0 Offset: 0x23403E0 VA: 0x182341DE0
	public Vector2 get_offsetMax() { }

	// RVA: 0x2342810 Offset: 0x2340E10 VA: 0x182342810
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x2340D60 Offset: 0x233F360 VA: 0x182340D60
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x23410F0 Offset: 0x233F6F0 VA: 0x1823410F0
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x23414B0 Offset: 0x233FAB0 VA: 0x1823414B0
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCode]
	// RVA: 0x2341450 Offset: 0x233FA50 VA: 0x182341450
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x2340F40 Offset: 0x233F540 VA: 0x182340F40
	private Vector2 GetParentSize() { }

	// RVA: 0x2342210 Offset: 0x2340810 VA: 0x182342210
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x2341B40 Offset: 0x2340140 VA: 0x182341B40
	private static void get_anchorMin_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2342570 Offset: 0x2340B70 VA: 0x182342570
	private static void set_anchorMin_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x2341A60 Offset: 0x2340060 VA: 0x182341A60
	private static void get_anchorMax_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2342490 Offset: 0x2340A90 VA: 0x182342490
	private static void set_anchorMax_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x2341D00 Offset: 0x2340300 VA: 0x182341D00
	private static void get_anchoredPosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2342730 Offset: 0x2340D30 VA: 0x182342730
	private static void set_anchoredPosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x23422F0 Offset: 0x23408F0 VA: 0x1823422F0
	private static void get_sizeDelta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x23430D0 Offset: 0x23416D0 VA: 0x1823430D0
	private static void set_sizeDelta_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x2342130 Offset: 0x2340730 VA: 0x182342130
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2342FF0 Offset: 0x23415F0 VA: 0x182342FF0
	private static void set_pivot_Injected(IntPtr _unity_self, in Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Transform/Transform.h")]
[RequiredByNativeCode]
[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
public class Transform : Component, IEnumerable // TypeDefIndex: 9795
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged { set; }

	// Methods

	// RVA: 0x2366EE0 Offset: 0x23654E0 VA: 0x182366EE0
	public Vector3 get_position() { }

	// RVA: 0x2367A40 Offset: 0x2366040 VA: 0x182367A40
	public void set_position(Vector3 value) { }

	// RVA: 0x2366A40 Offset: 0x2365040 VA: 0x182366A40
	public Vector3 get_localPosition() { }

	// RVA: 0x2367660 Offset: 0x2365C60 VA: 0x182367660
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x23666A0 Offset: 0x2364CA0 VA: 0x1823666A0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2367370 Offset: 0x2365970 VA: 0x182367370
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x23668D0 Offset: 0x2364ED0 VA: 0x1823668D0
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x2367530 Offset: 0x2365B30 VA: 0x182367530
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x2366F80 Offset: 0x2365580 VA: 0x182366F80
	public Vector3 get_right() { }

	// RVA: 0x2367170 Offset: 0x2365770 VA: 0x182367170
	public Vector3 get_up() { }

	// RVA: 0x2367BB0 Offset: 0x23661B0 VA: 0x182367BB0
	public void set_up(Vector3 value) { }

	// RVA: 0x23667C0 Offset: 0x2364DC0 VA: 0x1823667C0
	public Vector3 get_forward() { }

	// RVA: 0x23670E0 Offset: 0x23656E0 VA: 0x1823670E0
	public Quaternion get_rotation() { }

	// RVA: 0x2367B20 Offset: 0x2366120 VA: 0x182367B20
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2366B30 Offset: 0x2365130 VA: 0x182366B30
	public Quaternion get_localRotation() { }

	// RVA: 0x2367740 Offset: 0x2365D40 VA: 0x182367740
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x2366C10 Offset: 0x2365210 VA: 0x182366C10
	public Vector3 get_localScale() { }

	// RVA: 0x2367820 Offset: 0x2365E20 VA: 0x182367820
	public void set_localScale(Vector3 value) { }

	// RVA: 0x2364750 Offset: 0x2362D50 VA: 0x182364750
	public Transform get_parent() { }

	// RVA: 0x23678B0 Offset: 0x2365EB0 VA: 0x1823678B0
	public void set_parent(Transform value) { }

	// RVA: 0x2364750 Offset: 0x2362D50 VA: 0x182364750
	internal Transform get_parentInternal() { }

	// RVA: 0x2365E80 Offset: 0x2364480 VA: 0x182365E80
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x2364750 Offset: 0x2362D50 VA: 0x182364750
	private Transform GetParent() { }

	// RVA: 0x2365E80 Offset: 0x2364480 VA: 0x182365E80
	public void SetParent(Transform p) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	// RVA: 0x2365F40 Offset: 0x2364540 VA: 0x182365F40
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x23672D0 Offset: 0x23658D0 VA: 0x1823672D0
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x2366D00 Offset: 0x2365300 VA: 0x182366D00
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x2366070 Offset: 0x2364670 VA: 0x182366070
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2365660 Offset: 0x2363C60 VA: 0x182365660
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x2365310 Offset: 0x2363910 VA: 0x182365310
	public void Rotate(Vector3 eulers) { }

	[NativeMethod("RotateAround")]
	// RVA: 0x2365270 Offset: 0x2363870 VA: 0x182365270
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x2365490 Offset: 0x2363A90 VA: 0x182365490
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x2365340 Offset: 0x2363940 VA: 0x182365340
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x2364EE0 Offset: 0x23634E0 VA: 0x182364EE0
	public void LookAt(Transform target) { }

	// RVA: 0x2365080 Offset: 0x2363680 VA: 0x182365080
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2365130 Offset: 0x2363730 VA: 0x182365130
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	// RVA: 0x23649F0 Offset: 0x2362FF0 VA: 0x1823649F0
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2366240 Offset: 0x2364840 VA: 0x182366240
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x2364AF0 Offset: 0x23630F0 VA: 0x182364AF0
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x2366530 Offset: 0x2364B30 VA: 0x182366530
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x2364D10 Offset: 0x2363310 VA: 0x182364D10
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x2366350 Offset: 0x2364950 VA: 0x182366350
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x2366400 Offset: 0x2364A00 VA: 0x182366400
	public Vector3 TransformPoint(float x, float y, float z) { }

	// RVA: 0x2364C00 Offset: 0x2363200 VA: 0x182364C00
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x2364830 Offset: 0x2362E30 VA: 0x182364830
	public Transform get_root() { }

	// RVA: 0x2364830 Offset: 0x2362E30 VA: 0x182364830
	private Transform GetRoot() { }

	[NativeMethod("GetChildrenCount")]
	// RVA: 0x2366620 Offset: 0x2364C20 VA: 0x182366620
	public int get_childCount() { }

	// RVA: 0x2365DA0 Offset: 0x23643A0 VA: 0x182365DA0
	public void SetAsFirstSibling() { }

	// RVA: 0x2366150 Offset: 0x2364750 VA: 0x182366150
	public void SetSiblingIndex(int index) { }

	// RVA: 0x2364910 Offset: 0x2362F10 VA: 0x182364910
	public int GetSiblingIndex() { }

	[FreeFunction(HasExplicitThis = True)]
	// RVA: 0x2364340 Offset: 0x2362940 VA: 0x182364340
	private Transform FindRelativeTransformWithPath(string path, bool isActiveOnly) { }

	// RVA: 0x2364550 Offset: 0x2362B50 VA: 0x182364550
	public Transform Find(string n) { }

	[NativeMethod("GetWorldScaleLossy")]
	// RVA: 0x2366DF0 Offset: 0x23653F0 VA: 0x182366DF0
	public Vector3 get_lossyScale() { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	// RVA: 0x2364E10 Offset: 0x2363410 VA: 0x182364E10
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x23674A0 Offset: 0x2365AA0 VA: 0x1823674A0
	public void set_hasChanged(bool value) { }

	// RVA: 0x23646A0 Offset: 0x2362CA0 VA: 0x1823646A0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	// RVA: 0x2364600 Offset: 0x2362C00 VA: 0x182364600
	public Transform GetChild(int index) { }

	// RVA: 0x2366E90 Offset: 0x2365490 VA: 0x182366E90
	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23679F0 Offset: 0x2365FF0 VA: 0x1823679F0
	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x23669F0 Offset: 0x2364FF0 VA: 0x1823669F0
	private static void get_localPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x2367610 Offset: 0x2365C10 VA: 0x182367610
	private static void set_localPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x2367090 Offset: 0x2365690 VA: 0x182367090
	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	// RVA: 0x2367AD0 Offset: 0x23660D0 VA: 0x182367AD0
	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	// RVA: 0x2366AE0 Offset: 0x23650E0 VA: 0x182366AE0
	private static void get_localRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	// RVA: 0x23676F0 Offset: 0x2365CF0 VA: 0x1823676F0
	private static void set_localRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	// RVA: 0x2366BC0 Offset: 0x23651C0 VA: 0x182366BC0
	private static void get_localScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23677D0 Offset: 0x2365DD0 VA: 0x1823677D0
	private static void set_localScale_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x2364710 Offset: 0x2362D10 VA: 0x182364710
	private static IntPtr GetParent_Injected(IntPtr _unity_self) { }

	// RVA: 0x2365E20 Offset: 0x2364420 VA: 0x182365E20
	private static void SetParent_Injected(IntPtr _unity_self, IntPtr parent, bool worldPositionStays) { }

	// RVA: 0x2367280 Offset: 0x2365880 VA: 0x182367280
	private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	// RVA: 0x2366CB0 Offset: 0x23652B0 VA: 0x182366CB0
	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	// RVA: 0x2366010 Offset: 0x2364610 VA: 0x182366010
	private static void SetPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 position, in Quaternion rotation) { }

	// RVA: 0x2365210 Offset: 0x2363810 VA: 0x182365210
	private static void RotateAroundInternal_Injected(IntPtr _unity_self, in Vector3 axis, float angle) { }

	// RVA: 0x2364990 Offset: 0x2362F90 VA: 0x182364990
	private static void Internal_LookAt_Injected(IntPtr _unity_self, in Vector3 worldPosition, in Vector3 worldUp) { }

	// RVA: 0x23661E0 Offset: 0x23647E0 VA: 0x1823661E0
	private static void TransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2364A90 Offset: 0x2363090 VA: 0x182364A90
	private static void InverseTransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	// RVA: 0x23664D0 Offset: 0x2364AD0 VA: 0x1823664D0
	private static void TransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2364CB0 Offset: 0x23632B0 VA: 0x182364CB0
	private static void InverseTransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

	// RVA: 0x23662F0 Offset: 0x23648F0 VA: 0x1823662F0
	private static void TransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	// RVA: 0x2364BA0 Offset: 0x23631A0 VA: 0x182364BA0
	private static void InverseTransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	// RVA: 0x23647F0 Offset: 0x2362DF0 VA: 0x1823647F0
	private static IntPtr GetRoot_Injected(IntPtr _unity_self) { }

	// RVA: 0x23665E0 Offset: 0x2364BE0 VA: 0x1823665E0
	private static int get_childCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x2365D60 Offset: 0x2364360 VA: 0x182365D60
	private static void SetAsFirstSibling_Injected(IntPtr _unity_self) { }

	// RVA: 0x2366110 Offset: 0x2364710 VA: 0x182366110
	private static void SetSiblingIndex_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x23648D0 Offset: 0x2362ED0 VA: 0x1823648D0
	private static int GetSiblingIndex_Injected(IntPtr _unity_self) { }

	// RVA: 0x23642E0 Offset: 0x23628E0 VA: 0x1823642E0
	private static IntPtr FindRelativeTransformWithPath_Injected(IntPtr _unity_self, ref ManagedSpanWrapper path, bool isActiveOnly) { }

	// RVA: 0x2366DA0 Offset: 0x23653A0 VA: 0x182366DA0
	private static void get_lossyScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x2364DC0 Offset: 0x23633C0 VA: 0x182364DC0
	private static bool IsChildOf_Injected(IntPtr _unity_self, IntPtr parent) { }

	// RVA: 0x2367450 Offset: 0x2365A50 VA: 0x182367450
	private static void set_hasChanged_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x23645C0 Offset: 0x2362BC0 VA: 0x1823645C0
	private static IntPtr GetChild_Injected(IntPtr _unity_self, int index) { }
}

// Namespace: UnityEngine
[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class SpriteRenderer : Renderer // TypeDefIndex: 9796
{
	// Fields
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2361E10 Offset: 0x2360410 VA: 0x182361E10
	private void InvokeSpriteChanged() { }
}

// Namespace: UnityEngine
public enum SpritePackingRotation // TypeDefIndex: 9797
{
	// Fields
	public int value__; // 0x0
	public const SpritePackingRotation None = 0;
	public const SpritePackingRotation FlipHorizontal = 1;
	public const SpritePackingRotation FlipVertical = 2;
	public const SpritePackingRotation Rotate180 = 3;
	public const SpritePackingRotation Any = 15;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[ExcludeFromPreset]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
public sealed class Sprite : Object // TypeDefIndex: 9798
{
	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public SpritePackingRotation packingRotation { get; }
	public Rect textureRect { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2362390 Offset: 0x2360990 VA: 0x182362390
	private void .ctor() { }

	// RVA: 0x2362150 Offset: 0x2360750 VA: 0x182362150
	internal int GetPackingRotation() { }

	// RVA: 0x2362090 Offset: 0x2360690 VA: 0x182362090
	internal int GetPacked() { }

	// RVA: 0x2362300 Offset: 0x2360900 VA: 0x182362300
	internal Rect GetTextureRect() { }

	// RVA: 0x2361EE0 Offset: 0x23604E0 VA: 0x182361EE0
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x2361FC0 Offset: 0x23605C0 VA: 0x182361FC0
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x2362220 Offset: 0x2360820 VA: 0x182362220
	internal Vector4 GetPadding() { }

	// RVA: 0x23625F0 Offset: 0x2360BF0 VA: 0x1823625F0
	public Bounds get_bounds() { }

	// RVA: 0x2362900 Offset: 0x2360F00 VA: 0x182362900
	public Rect get_rect() { }

	// RVA: 0x2362510 Offset: 0x2360B10 VA: 0x182362510
	public Vector4 get_border() { }

	// RVA: 0x2362A80 Offset: 0x2361080 VA: 0x182362A80
	public Texture2D get_texture() { }

	[NativeMethod("GetPixelsToUnits")]
	// RVA: 0x2362830 Offset: 0x2360E30 VA: 0x182362830
	public float get_pixelsPerUnit() { }

	[NativeMethod("GetAlphaTexture")]
	// RVA: 0x2362420 Offset: 0x2360A20 VA: 0x182362420
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethod("GetPivotInPixels")]
	// RVA: 0x2362760 Offset: 0x2360D60 VA: 0x182362760
	public Vector2 get_pivot() { }

	// RVA: 0x2362690 Offset: 0x2360C90 VA: 0x182362690
	public bool get_packed() { }

	// RVA: 0x2362150 Offset: 0x2360750 VA: 0x182362150
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0x2362990 Offset: 0x2360F90 VA: 0x182362990
	public Rect get_textureRect() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	// RVA: 0x2362CE0 Offset: 0x23612E0 VA: 0x182362CE0
	public Vector2[] get_vertices() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	// RVA: 0x2362B60 Offset: 0x2361160 VA: 0x182362B60
	public ushort[] get_triangles() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	// RVA: 0x2362C20 Offset: 0x2361220 VA: 0x182362C20
	public Vector2[] get_uv() { }

	// RVA: 0x2362110 Offset: 0x2360710 VA: 0x182362110
	private static int GetPackingRotation_Injected(IntPtr _unity_self) { }

	// RVA: 0x2362050 Offset: 0x2360650 VA: 0x182362050
	private static int GetPacked_Injected(IntPtr _unity_self) { }

	// RVA: 0x23622B0 Offset: 0x23608B0 VA: 0x1823622B0
	private static void GetTextureRect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x2361E90 Offset: 0x2360490 VA: 0x182361E90
	private static void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x2361F70 Offset: 0x2360570 VA: 0x182361F70
	private static void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x23621D0 Offset: 0x23607D0 VA: 0x1823621D0
	private static void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x23625A0 Offset: 0x2360BA0 VA: 0x1823625A0
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	// RVA: 0x23628B0 Offset: 0x2360EB0 VA: 0x1823628B0
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x23624C0 Offset: 0x2360AC0 VA: 0x1823624C0
	private static void get_border_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x2362A40 Offset: 0x2361040 VA: 0x182362A40
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	// RVA: 0x23627F0 Offset: 0x2360DF0 VA: 0x1823627F0
	private static float get_pixelsPerUnit_Injected(IntPtr _unity_self) { }

	// RVA: 0x23623E0 Offset: 0x23609E0 VA: 0x1823623E0
	private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x2362710 Offset: 0x2360D10 VA: 0x182362710
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2362CA0 Offset: 0x23612A0 VA: 0x182362CA0
	private static Vector2[] get_vertices_Injected(IntPtr _unity_self) { }

	// RVA: 0x2362B20 Offset: 0x2361120 VA: 0x182362B20
	private static ushort[] get_triangles_Injected(IntPtr _unity_self) { }

	// RVA: 0x2362BE0 Offset: 0x23611E0 VA: 0x182362BE0
	private static Vector2[] get_uv_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/Event.bindings.h")]
[StaticAccessor("GUIEvent", 2)]
public sealed class Event // TypeDefIndex: 12750
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	[NativeProperty("type", False, 1)]
	public EventType rawType { get; }
	[NativeProperty("mousePosition", False, 1)]
	public Vector2 mousePosition { get; set; }
	[NativeProperty("delta", False, 1)]
	public Vector2 delta { get; set; }
	[NativeProperty("pointerType", False, 1)]
	public PointerType pointerType { get; }
	[NativeProperty("button", False, 1)]
	public int button { get; }
	[NativeProperty("modifiers", False, 1)]
	public EventModifiers modifiers { get; set; }
	[NativeProperty("pressure", False, 1)]
	public float pressure { get; }
	[NativeProperty("twist", False, 1)]
	public float twist { get; }
	[NativeProperty("tilt", False, 1)]
	public Vector2 tilt { get; }
	[NativeProperty("penStatus", False, 1)]
	public PenStatus penStatus { get; }
	[NativeProperty("clickCount", False, 1)]
	public int clickCount { get; }
	[NativeProperty("character", False, 1)]
	public char character { get; set; }
	[NativeProperty("keycode", False, 1)]
	private KeyCode Internal_keyCode { get; set; }
	public KeyCode keyCode { get; set; }
	[NativeProperty("displayIndex", False, 1)]
	public int displayIndex { get; set; }
	public EventType type { get; set; }
	public string commandName { get; set; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public bool capsLock { get; }
	public bool numeric { get; }
	public bool functionKey { get; }
	public static Event current { get; set; }
	public bool isKey { get; }
	public bool isMouse { get; }
	public bool isScrollWheel { get; }
	internal bool isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0x2372780 Offset: 0x2370D80 VA: 0x182372780
	public EventType get_rawType() { }

	// RVA: 0x2372490 Offset: 0x2370A90 VA: 0x182372490
	public Vector2 get_mousePosition() { }

	// RVA: 0x2373080 Offset: 0x2371680 VA: 0x182373080
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x2371E60 Offset: 0x2370460 VA: 0x182371E60
	public Vector2 get_delta() { }

	// RVA: 0x2372E90 Offset: 0x2371490 VA: 0x182372E90
	public void set_delta(Vector2 value) { }

	// RVA: 0x2372640 Offset: 0x2370C40 VA: 0x182372640
	public PointerType get_pointerType() { }

	// RVA: 0x23719F0 Offset: 0x236FFF0 VA: 0x1823719F0
	public int get_button() { }

	// RVA: 0x23723E0 Offset: 0x23709E0 VA: 0x1823723E0
	public EventModifiers get_modifiers() { }

	// RVA: 0x2372FD0 Offset: 0x23715D0 VA: 0x182372FD0
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x23726E0 Offset: 0x2370CE0 VA: 0x1823726E0
	public float get_pressure() { }

	// RVA: 0x2372940 Offset: 0x2370F40 VA: 0x182372940
	public float get_twist() { }

	// RVA: 0x2372890 Offset: 0x2370E90 VA: 0x182372890
	public Vector2 get_tilt() { }

	// RVA: 0x23725A0 Offset: 0x2370BA0 VA: 0x1823725A0
	public PenStatus get_penStatus() { }

	// RVA: 0x2371B90 Offset: 0x2370190 VA: 0x182371B90
	public int get_clickCount() { }

	// RVA: 0x2371AF0 Offset: 0x23700F0 VA: 0x182371AF0
	public char get_character() { }

	// RVA: 0x2372B30 Offset: 0x2371130 VA: 0x182372B30
	public void set_character(char value) { }

	// RVA: 0x23718F0 Offset: 0x236FEF0 VA: 0x1823718F0
	private KeyCode get_Internal_keyCode() { }

	// RVA: 0x2372A80 Offset: 0x2371080 VA: 0x182372A80
	private void set_Internal_keyCode(KeyCode value) { }

	// RVA: 0x2372210 Offset: 0x2370810 VA: 0x182372210
	public KeyCode get_keyCode() { }

	// RVA: 0x2372A80 Offset: 0x2371080 VA: 0x182372A80
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x2371F10 Offset: 0x2370510 VA: 0x182371F10
	public int get_displayIndex() { }

	// RVA: 0x2372F30 Offset: 0x2371530 VA: 0x182372F30
	public void set_displayIndex(int value) { }

	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	// RVA: 0x23729E0 Offset: 0x2370FE0 VA: 0x1823729E0
	public EventType get_type() { }

	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	// RVA: 0x2373120 Offset: 0x2371720 VA: 0x182373120
	public void set_type(EventType value) { }

	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	// RVA: 0x2371C40 Offset: 0x2370240 VA: 0x182371C40
	public string get_commandName() { }

	[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
	// RVA: 0x2372BE0 Offset: 0x23711E0 VA: 0x182372BE0
	public void set_commandName(string value) { }

	[NativeMethod("Use")]
	// RVA: 0x236F060 Offset: 0x236D660 VA: 0x18236F060
	private void Internal_Use() { }

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x236EDF0 Offset: 0x236D3F0 VA: 0x18236EDF0
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x236EE30 Offset: 0x236D430 VA: 0x18236EE30
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
	// RVA: 0x236ED90 Offset: 0x236D390 VA: 0x18236ED90
	public EventType GetTypeForControl(int controlID) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x236E4E0 Offset: 0x236CAE0 VA: 0x18236E4E0
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x2370B60 Offset: 0x236F160 VA: 0x182370B60
	public static bool PopEvent(Event outEvent) { }

	[VisibleToOtherModules(new[] { "UnityEngine.InputForUIModule" })]
	// RVA: 0x236EAF0 Offset: 0x236D0F0 VA: 0x18236EAF0
	internal static void GetEventAtIndex(int index, Event outEvent) { }

	// RVA: 0x236EB90 Offset: 0x236D190 VA: 0x18236EB90
	public static int GetEventCount() { }

	// RVA: 0x236EFE0 Offset: 0x236D5E0 VA: 0x18236EFE0
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x236EE70 Offset: 0x236D470 VA: 0x18236EE70
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "UnityEngine.InputForUIModule" })]
	// RVA: 0x236EA80 Offset: 0x236D080 VA: 0x18236EA80
	internal static int GetDoubleClickTime() { }

	// RVA: 0x2371820 Offset: 0x236FE20 VA: 0x182371820
	public void .ctor() { }

	// RVA: 0x2371860 Offset: 0x236FE60 VA: 0x182371860
	public void .ctor(int displayIndex) { }

	// RVA: 0x236E9F0 Offset: 0x236CFF0 VA: 0x18236E9F0 Slot: 1
	protected override void Finalize() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x236E540 Offset: 0x236CB40 VA: 0x18236E540
	internal void CopyFrom(Event e) { }

	// RVA: 0x23727E0 Offset: 0x2370DE0 VA: 0x1823727E0
	public bool get_shift() { }

	// RVA: 0x2371D70 Offset: 0x2370370 VA: 0x182371D70
	public bool get_control() { }

	// RVA: 0x2371950 Offset: 0x236FF50 VA: 0x182371950
	public bool get_alt() { }

	// RVA: 0x2371D10 Offset: 0x2370310 VA: 0x182371D10
	public bool get_command() { }

	// RVA: 0x2371A50 Offset: 0x2370050 VA: 0x182371A50
	public bool get_capsLock() { }

	// RVA: 0x2372500 Offset: 0x2370B00 VA: 0x182372500
	public bool get_numeric() { }

	// RVA: 0x2371F70 Offset: 0x2370570 VA: 0x182371F70
	public bool get_functionKey() { }

	// RVA: 0x2371DD0 Offset: 0x23703D0 VA: 0x182371DD0
	public static Event get_current() { }

	// RVA: 0x2372D90 Offset: 0x2371390 VA: 0x182372D90
	public static void set_current(Event value) { }

	// RVA: 0x23720A0 Offset: 0x23706A0 VA: 0x1823720A0
	public bool get_isKey() { }

	// RVA: 0x2372120 Offset: 0x2370720 VA: 0x182372120
	public bool get_isMouse() { }

	// RVA: 0x23721B0 Offset: 0x23707B0 VA: 0x1823721B0
	public bool get_isScrollWheel() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2371FD0 Offset: 0x23705D0 VA: 0x182371FD0
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x236F0C0 Offset: 0x236D6C0 VA: 0x18236F0C0
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x236EBC0 Offset: 0x236D1C0 VA: 0x18236EBC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x236E5B0 Offset: 0x236CBB0 VA: 0x18236E5B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2370BF0 Offset: 0x236F1F0 VA: 0x182370BF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2371600 Offset: 0x236FC00 VA: 0x182371600
	public void Use() { }

	// RVA: 0x2372740 Offset: 0x2370D40 VA: 0x182372740
	private static EventType get_rawType_Injected(IntPtr _unity_self) { }

	// RVA: 0x2372440 Offset: 0x2370A40 VA: 0x182372440
	private static void get_mousePosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2373030 Offset: 0x2371630 VA: 0x182373030
	private static void set_mousePosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x2371E10 Offset: 0x2370410 VA: 0x182371E10
	private static void get_delta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2372E40 Offset: 0x2371440 VA: 0x182372E40
	private static void set_delta_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x2372600 Offset: 0x2370C00 VA: 0x182372600
	private static PointerType get_pointerType_Injected(IntPtr _unity_self) { }

	// RVA: 0x23719B0 Offset: 0x236FFB0 VA: 0x1823719B0
	private static int get_button_Injected(IntPtr _unity_self) { }

	// RVA: 0x23723A0 Offset: 0x23709A0 VA: 0x1823723A0
	private static EventModifiers get_modifiers_Injected(IntPtr _unity_self) { }

	// RVA: 0x2372F90 Offset: 0x2371590 VA: 0x182372F90
	private static void set_modifiers_Injected(IntPtr _unity_self, EventModifiers value) { }

	// RVA: 0x23726A0 Offset: 0x2370CA0 VA: 0x1823726A0
	private static float get_pressure_Injected(IntPtr _unity_self) { }

	// RVA: 0x2372900 Offset: 0x2370F00 VA: 0x182372900
	private static float get_twist_Injected(IntPtr _unity_self) { }

	// RVA: 0x2372840 Offset: 0x2370E40 VA: 0x182372840
	private static void get_tilt_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x2372560 Offset: 0x2370B60 VA: 0x182372560
	private static PenStatus get_penStatus_Injected(IntPtr _unity_self) { }

	// RVA: 0x2371B50 Offset: 0x2370150 VA: 0x182371B50
	private static int get_clickCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x2371AB0 Offset: 0x23700B0 VA: 0x182371AB0
	private static char get_character_Injected(IntPtr _unity_self) { }

	// RVA: 0x2372AE0 Offset: 0x23710E0 VA: 0x182372AE0
	private static void set_character_Injected(IntPtr _unity_self, char value) { }

	// RVA: 0x23718B0 Offset: 0x236FEB0 VA: 0x1823718B0
	private static KeyCode get_Internal_keyCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x2372A40 Offset: 0x2371040 VA: 0x182372A40
	private static void set_Internal_keyCode_Injected(IntPtr _unity_self, KeyCode value) { }

	// RVA: 0x2371ED0 Offset: 0x23704D0 VA: 0x182371ED0
	private static int get_displayIndex_Injected(IntPtr _unity_self) { }

	// RVA: 0x2372EF0 Offset: 0x23714F0 VA: 0x182372EF0
	private static void set_displayIndex_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x23729A0 Offset: 0x2370FA0 VA: 0x1823729A0
	private static EventType get_type_Injected(IntPtr _unity_self) { }

	// RVA: 0x23730E0 Offset: 0x23716E0 VA: 0x1823730E0
	private static void set_type_Injected(IntPtr _unity_self, EventType value) { }

	// RVA: 0x2371BF0 Offset: 0x23701F0 VA: 0x182371BF0
	private static void get_commandName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2372B90 Offset: 0x2371190 VA: 0x182372B90
	private static void set_commandName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x236F020 Offset: 0x236D620 VA: 0x18236F020
	private static void Internal_Use_Injected(IntPtr _unity_self) { }

	// RVA: 0x236ED50 Offset: 0x236D350 VA: 0x18236ED50
	private static EventType GetTypeForControl_Injected(IntPtr _unity_self, int controlID) { }

	// RVA: 0x236E490 Offset: 0x236CA90 VA: 0x18236E490
	private static void CopyFromPtr_Injected(IntPtr _unity_self, IntPtr ptr) { }

	// RVA: 0x2370B20 Offset: 0x236F120 VA: 0x182370B20
	private static bool PopEvent_Injected(IntPtr outEvent) { }

	// RVA: 0x236EAB0 Offset: 0x236D0B0 VA: 0x18236EAB0
	private static void GetEventAtIndex_Injected(int index, IntPtr outEvent) { }
}

// Namespace: UnityEngine
public enum EventType // TypeDefIndex: 12751
{
	// Fields
	public int value__; // 0x0
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	public const EventType TouchDown = 30;
	public const EventType TouchUp = 31;
	public const EventType TouchMove = 32;
	public const EventType TouchEnter = 33;
	public const EventType TouchLeave = 34;
	public const EventType TouchStationary = 35;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", True)]
	public const EventType mouseDown = 0;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", True)]
	public const EventType mouseUp = 1;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", True)]
	public const EventType mouseMove = 2;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", True)]
	public const EventType mouseDrag = 3;
	[EditorBrowsable(1)]
	[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", True)]
	public const EventType keyDown = 4;
	[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", True)]
	[EditorBrowsable(1)]
	public const EventType keyUp = 5;
	[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", True)]
	[EditorBrowsable(1)]
	public const EventType scrollWheel = 6;
	[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", True)]
	[EditorBrowsable(1)]
	public const EventType repaint = 7;
	[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", True)]
	[EditorBrowsable(1)]
	public const EventType layout = 8;
	[EditorBrowsable(1)]
	[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", True)]
	public const EventType dragUpdated = 9;
	[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", True)]
	[EditorBrowsable(1)]
	public const EventType dragPerform = 10;
	[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", True)]
	[EditorBrowsable(1)]
	public const EventType ignore = 11;
	[Obsolete("Use Used instead (UnityUpgradable) -> Used", True)]
	[EditorBrowsable(1)]
	public const EventType used = 12;
}

// Namespace: UnityEngine
[Flags]
public enum EventModifiers // TypeDefIndex: 12752
{
	// Fields
	public int value__; // 0x0
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;
}

// Namespace: UnityEngine
public enum PointerType // TypeDefIndex: 12753
{
	// Fields
	public int value__; // 0x0
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct EventInterests // TypeDefIndex: 12754
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <wantsLessLayoutEvents>k__BackingField; // 0x2

	// Properties
	public bool wantsMouseMove { get; set; }
	public bool wantsMouseEnterLeaveWindow { get; set; }
	public bool wantsLessLayoutEvents { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_wantsMouseMove() { }

	[CompilerGenerated]
	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	public void set_wantsMouseMove(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x12B1970 Offset: 0x12AFF70 VA: 0x1812B1970
	public bool get_wantsMouseEnterLeaveWindow() { }

	[CompilerGenerated]
	// RVA: 0x16A56B0 Offset: 0x16A3CB0 VA: 0x1816A56B0
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x157D110 Offset: 0x157B710 VA: 0x18157D110
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x236E370 Offset: 0x236C970 VA: 0x18236E370
	public bool WantsEvent(EventType type) { }

	// RVA: 0x236E390 Offset: 0x236C990 VA: 0x18236E390
	public bool WantsLayoutPass(EventType type) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public class GUI // TypeDefIndex: 12756
{
	// Fields
	private static int s_ScrollControlId; // 0x0
	private static int s_HotTextField; // 0x4
	private static readonly int s_BoxHash; // 0x8
	private static readonly int s_ButonHash; // 0xC
	private static readonly int s_RepeatButtonHash; // 0x10
	private static readonly int s_ToggleHash; // 0x14
	private static readonly int s_ButtonGridHash; // 0x18
	private static readonly int s_SliderHash; // 0x1C
	private static readonly int s_BeginGroupHash; // 0x20
	private static readonly int s_ScrollviewHash; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static int <scrollTroughSide>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	internal static Rect s_ToolTipRect; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static GenericStack <scrollViewStates>k__BackingField; // 0x50

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static bool changed { get; set; }
	public static bool enabled { get; set; }
	internal static bool usePageScrollbars { get; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x238BDB0 Offset: 0x238A3B0 VA: 0x18238BDB0
	public static Color get_color() { }

	// RVA: 0x238C3C0 Offset: 0x238A9C0 VA: 0x18238C3C0
	public static void set_color(Color value) { }

	// RVA: 0x238BB70 Offset: 0x238A170 VA: 0x18238BB70
	public static Color get_backgroundColor() { }

	// RVA: 0x238C2D0 Offset: 0x238A8D0 VA: 0x18238C2D0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x238BE60 Offset: 0x238A460 VA: 0x18238BE60
	public static Color get_contentColor() { }

	// RVA: 0x238C470 Offset: 0x238AA70 VA: 0x18238C470
	public static void set_contentColor(Color value) { }

	// RVA: 0x238BD40 Offset: 0x238A340 VA: 0x18238BD40
	public static bool get_changed() { }

	// RVA: 0x238C340 Offset: 0x238A940 VA: 0x18238C340
	public static void set_changed(bool value) { }

	// RVA: 0x238BED0 Offset: 0x238A4D0 VA: 0x18238BED0
	public static bool get_enabled() { }

	// RVA: 0x238C4E0 Offset: 0x238AAE0 VA: 0x18238C4E0
	public static void set_enabled(bool value) { }

	// RVA: 0x238C260 Offset: 0x238A860 VA: 0x18238C260
	internal static bool get_usePageScrollbars() { }

	[FreeFunction("GetGUIBlendMaterial")]
	// RVA: 0x238BC10 Offset: 0x238A210 VA: 0x18238BC10
	internal static Material get_blendMaterial() { }

	[FreeFunction("GetGUIBlitMaterial")]
	// RVA: 0x238BCC0 Offset: 0x238A2C0 VA: 0x18238BCC0
	internal static Material get_blitMaterial() { }

	[FreeFunction("GetGUIRoundedRectMaterial")]
	// RVA: 0x238C010 Offset: 0x238A610 VA: 0x18238C010
	internal static Material get_roundedRectMaterial() { }

	[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
	// RVA: 0x238C0C0 Offset: 0x238A6C0 VA: 0x18238C0C0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x2389BB0 Offset: 0x23881B0 VA: 0x182389BB0
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x2389BF0 Offset: 0x23881F0 VA: 0x182389BF0
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x238A170 Offset: 0x2388770 VA: 0x18238A170
	internal static void ReleaseMouseControl() { }

	// RVA: 0x2389E80 Offset: 0x2388480 VA: 0x182389E80
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x238B820 Offset: 0x2389E20 VA: 0x18238B820
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x238C140 Offset: 0x238A740 VA: 0x18238C140
	internal static int get_scrollTroughSide() { }

	[CompilerGenerated]
	// RVA: 0x238C5E0 Offset: 0x238ABE0 VA: 0x18238C5E0
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGenerated]
	// RVA: 0x238BF90 Offset: 0x238A590 VA: 0x18238BF90
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGenerated]
	// RVA: 0x238C580 Offset: 0x238AB80 VA: 0x18238C580
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x238C640 Offset: 0x238AC40 VA: 0x18238C640
	public static void set_skin(GUISkin value) { }

	// RVA: 0x238C1E0 Offset: 0x238A7E0 VA: 0x18238C1E0
	public static GUISkin get_skin() { }

	// RVA: 0x2387090 Offset: 0x2385690 VA: 0x182387090
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x238BF00 Offset: 0x238A500 VA: 0x18238BF00
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x238C520 Offset: 0x238AB20 VA: 0x18238C520
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x2389FB0 Offset: 0x23885B0 VA: 0x182389FB0
	public static void Label(Rect position, string text) { }

	// RVA: 0x2389EB0 Offset: 0x23884B0 VA: 0x182389EB0
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x238A0D0 Offset: 0x23886D0 VA: 0x18238A0D0
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2388810 Offset: 0x2386E10 VA: 0x182388810
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x23886A0 Offset: 0x2386CA0 VA: 0x1823886A0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x2387470 Offset: 0x2385A70 VA: 0x182387470
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x23882B0 Offset: 0x23868B0 VA: 0x1823882B0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x23883D0 Offset: 0x23869D0 VA: 0x1823883D0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x23875C0 Offset: 0x2385BC0 VA: 0x1823875C0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x2388130 Offset: 0x2386730 VA: 0x182388130
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x2387FE0 Offset: 0x23865E0 VA: 0x182387FE0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x23877E0 Offset: 0x2385DE0 VA: 0x1823877E0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x2385CB0 Offset: 0x23842B0 VA: 0x182385CB0
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x2385BF0 Offset: 0x23841F0 VA: 0x182385BF0
	public static void Box(Rect position, string text) { }

	// RVA: 0x23859D0 Offset: 0x2383FD0 VA: 0x1823859D0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2386AE0 Offset: 0x23850E0 VA: 0x182386AE0
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x238B2F0 Offset: 0x23898F0 VA: 0x18238B2F0
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x2386220 Offset: 0x2384820 VA: 0x182386220
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x23866D0 Offset: 0x2384CD0 VA: 0x1823866D0
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2387310 Offset: 0x2385910 VA: 0x182387310
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x238B110 Offset: 0x2389710 VA: 0x18238B110
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x2389C30 Offset: 0x2388230 VA: 0x182389C30
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x238A1A0 Offset: 0x23887A0 VA: 0x18238A1A0
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x238B5D0 Offset: 0x2389BD0 VA: 0x18238B5D0
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x238A4E0 Offset: 0x2388AE0 VA: 0x18238A4E0
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x2384A60 Offset: 0x2383060 VA: 0x182384A60
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x23846E0 Offset: 0x2382CE0 VA: 0x1823846E0
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x23889A0 Offset: 0x2386FA0 VA: 0x1823889A0
	public static void EndGroup() { }

	[CompilerGenerated]
	// RVA: 0x238C190 Offset: 0x238A790 VA: 0x18238C190
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x2384B20 Offset: 0x2383120 VA: 0x182384B20
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x2388A10 Offset: 0x2387010 VA: 0x182388A10
	public static void EndScrollView(bool handleScrollWheel) { }

	[RequiredByNativeCode]
	// RVA: 0x2385E50 Offset: 0x2384450 VA: 0x182385E50
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x238BD70 Offset: 0x238A370 VA: 0x18238BD70
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x238C380 Offset: 0x238A980 VA: 0x18238C380
	private static void set_color_Injected(in Color value) { }

	// RVA: 0x238BB30 Offset: 0x238A130 VA: 0x18238BB30
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x238C290 Offset: 0x238A890 VA: 0x18238C290
	private static void set_backgroundColor_Injected(in Color value) { }

	// RVA: 0x238BE20 Offset: 0x238A420 VA: 0x18238BE20
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x238C430 Offset: 0x238AA30 VA: 0x18238C430
	private static void set_contentColor_Injected(in Color value) { }

	// RVA: 0x238BBE0 Offset: 0x238A1E0 VA: 0x18238BBE0
	private static IntPtr get_blendMaterial_Injected() { }

	// RVA: 0x238BC90 Offset: 0x238A290 VA: 0x18238BC90
	private static IntPtr get_blitMaterial_Injected() { }

	// RVA: 0x238BFE0 Offset: 0x238A5E0 VA: 0x18238BFE0
	private static IntPtr get_roundedRectMaterial_Injected() { }

	// RVA: 0x238C090 Offset: 0x238A690 VA: 0x18238C090
	private static IntPtr get_roundedRectWithColorPerBorderMaterial_Injected() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIClip.h")]
[NativeHeader("Modules/IMGUI/GUIState.h")]
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal sealed class GUIClip // TypeDefIndex: 12758
{
	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	// RVA: 0x2373770 Offset: 0x2371D70 VA: 0x182373770
	internal static Rect get_visibleRect() { }

	// RVA: 0x23735F0 Offset: 0x2371BF0 VA: 0x1823735F0
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2373400 Offset: 0x2371A00 VA: 0x182373400
	internal static void Internal_Pop() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	// RVA: 0x23733A0 Offset: 0x23719A0 VA: 0x1823733A0
	internal static int Internal_GetCount() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	// RVA: 0x2373350 Offset: 0x2371950 VA: 0x182373350
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x23736F0 Offset: 0x2371CF0 VA: 0x1823736F0
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x2373490 Offset: 0x2371A90 VA: 0x182373490
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x2373520 Offset: 0x2371B20 VA: 0x182373520
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x23733D0 Offset: 0x23719D0 VA: 0x1823733D0
	internal static void Internal_PopParentClip() { }

	// RVA: 0x2373650 Offset: 0x2371C50 VA: 0x182373650
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x2373400 Offset: 0x2371A00 VA: 0x182373400
	internal static void Pop() { }

	// RVA: 0x2373730 Offset: 0x2371D30 VA: 0x182373730
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x2373580 Offset: 0x2371B80 VA: 0x182373580
	private static void Internal_Push_Injected(in Rect screenRect, in Vector2 scrollOffset, in Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x2373310 Offset: 0x2371910 VA: 0x182373310
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x23736B0 Offset: 0x2371CB0 VA: 0x1823736B0
	private static void SetMatrix_Injected(in Matrix4x4 m) { }

	// RVA: 0x2373430 Offset: 0x2371A30 VA: 0x182373430
	private static void Internal_PushParentClip_Injected(in Matrix4x4 renderTransform, in Matrix4x4 inputTransform, in Rect clipRect) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Modules/IMGUI/GUIContent.h")]
[Serializable]
public class GUIContent // TypeDefIndex: 12759
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Texture m_Image; // 0x18
	[SerializeField]
	private string m_Tooltip; // 0x20
	[SerializeField]
	private string m_TextWithWhitespace; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action OnTextChanged; // 0x30
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	internal static string k_ZeroWidthSpace; // 0x18
	public static GUIContent none; // 0x20

	// Properties
	public string text { get; set; }
	internal string textWithWhitespace { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2374010 Offset: 0x2372610 VA: 0x182374010
	internal void add_OnTextChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2374120 Offset: 0x2372720 VA: 0x182374120
	internal void remove_OnTextChanged(Action value) { }

	// RVA: 0x101AB70 Offset: 0x1019170 VA: 0x18101AB70
	public string get_text() { }

	// RVA: 0x2374240 Offset: 0x2372840 VA: 0x182374240
	public void set_text(string value) { }

	// RVA: 0x23740B0 Offset: 0x23726B0 VA: 0x1823740B0
	internal string get_textWithWhitespace() { }

	// RVA: 0x23741C0 Offset: 0x23727C0 VA: 0x1823741C0
	internal void set_textWithWhitespace(string value) { }

	// RVA: 0x2373990 Offset: 0x2371F90 VA: 0x182373990
	internal void SetTextWithoutNotify(string value) { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_image(Texture value) { }

	// RVA: 0x2358D20 Offset: 0x2357320 VA: 0x182358D20
	public string get_tooltip() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_tooltip(string value) { }

	// RVA: 0x2373F60 Offset: 0x2372560 VA: 0x182373F60
	public void .ctor() { }

	// RVA: 0x2373FE0 Offset: 0x23725E0 VA: 0x182373FE0
	public void .ctor(string text) { }

	// RVA: 0x2373E40 Offset: 0x2372440 VA: 0x182373E40
	public void .ctor(string text, string tooltip) { }

	// RVA: 0x2373D40 Offset: 0x2372340 VA: 0x182373D40
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x2373E60 Offset: 0x2372460 VA: 0x182373E60
	public void .ctor(GUIContent src) { }

	// RVA: 0x23739D0 Offset: 0x2371FD0 VA: 0x1823739D0
	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23737B0 Offset: 0x2371DB0 VA: 0x1823737B0
	internal static void ClearStaticCache() { }

	// RVA: 0x2373AB0 Offset: 0x23720B0 VA: 0x182373AB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2373AE0 Offset: 0x23720E0 VA: 0x182373AE0
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum ScaleMode // TypeDefIndex: 12760
{
	// Fields
	public int value__; // 0x0
	public const ScaleMode StretchToFill = 0;
	public const ScaleMode ScaleAndCrop = 1;
	public const ScaleMode ScaleToFit = 2;
}

// Namespace: UnityEngine
public enum FocusType // TypeDefIndex: 12761
{
	// Fields
	public int value__; // 0x0
	[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", False)]
	public const FocusType Native = 0;
	public const FocusType Keyboard = 1;
	public const FocusType Passive = 2;
}

// Namespace: UnityEngine
public class GUILayout // TypeDefIndex: 12762
{
	// Methods

	// RVA: 0x2379160 Offset: 0x2377760 VA: 0x182379160
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x2379200 Offset: 0x2377800 VA: 0x182379200
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x23785A0 Offset: 0x2376BA0 VA: 0x1823785A0
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2379280 Offset: 0x2377880 VA: 0x182379280
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2379310 Offset: 0x2377910 VA: 0x182379310
	public static bool Toggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x23786F0 Offset: 0x2376CF0 VA: 0x1823786F0
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2378BE0 Offset: 0x23771E0 VA: 0x182378BE0
	public static void FlexibleSpace() { }

	// RVA: 0x2377B40 Offset: 0x2376140 VA: 0x182377B40
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x2377D20 Offset: 0x2376320 VA: 0x182377D20
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2378970 Offset: 0x2376F70 VA: 0x182378970
	public static void EndHorizontal() { }

	// RVA: 0x23783C0 Offset: 0x23769C0 VA: 0x1823783C0
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x2378250 Offset: 0x2376850 VA: 0x182378250
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2378AA0 Offset: 0x23770A0 VA: 0x182378AA0
	public static void EndVertical() { }

	// RVA: 0x2377800 Offset: 0x2375E00 VA: 0x182377800
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x23778B0 Offset: 0x2375EB0 VA: 0x1823778B0
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x2378800 Offset: 0x2376E00 VA: 0x182378800
	public static void EndArea() { }

	// RVA: 0x2377E90 Offset: 0x2376490 VA: 0x182377E90
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x2377F60 Offset: 0x2376560 VA: 0x182377F60
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x23789B0 Offset: 0x2376FB0 VA: 0x1823789B0
	public static void EndScrollView() { }

	// RVA: 0x2378A20 Offset: 0x2377020 VA: 0x182378A20
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x2379320 Offset: 0x2377920 VA: 0x182379320
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x23790D0 Offset: 0x23776D0 VA: 0x1823790D0
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x2378B60 Offset: 0x2377160 VA: 0x182378B60
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x2378AE0 Offset: 0x23770E0 VA: 0x182378AE0
	public static GUILayoutOption ExpandHeight(bool expand) { }
}

// Namespace: UnityEngine
public sealed class GUILayoutOption // TypeDefIndex: 12764
{
	// Fields
	internal GUILayoutOption.Type type; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x3E8780 Offset: 0x3E6D80 VA: 0x1803E8780
	internal void .ctor(GUILayoutOption.Type type, object value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility // TypeDefIndex: 12766
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static int <unbalancedgroupscount>k__BackingField; // 0x28
	private static GUIStyle s_SpaceStyle; // 0x30

	// Properties
	internal static int unbalancedgroupscount { get; set; }
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0x23763C0 Offset: 0x23749C0 VA: 0x1823763C0
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x2376480 Offset: 0x2374A80 VA: 0x182376480
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[CompilerGenerated]
	// RVA: 0x2377750 Offset: 0x2375D50 VA: 0x182377750
	internal static int get_unbalancedgroupscount() { }

	[CompilerGenerated]
	// RVA: 0x23777A0 Offset: 0x2375DA0 VA: 0x1823777A0
	internal static void set_unbalancedgroupscount(int value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23772B0 Offset: 0x23758B0 VA: 0x1823772B0
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x2374FA0 Offset: 0x23735A0 VA: 0x182374FA0
	internal static void Begin(int instanceID) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23742A0 Offset: 0x23728A0 VA: 0x1823742A0
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x2374C00 Offset: 0x2373200 VA: 0x182374C00
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2377000 Offset: 0x2375600 VA: 0x182377000
	internal static void Layout() { }

	// RVA: 0x2376B20 Offset: 0x2375120 VA: 0x182376B20
	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2376940 Offset: 0x2374F40 VA: 0x182376940
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x2376500 Offset: 0x2374B00 VA: 0x182376500
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x2376D90 Offset: 0x2375390 VA: 0x182376D90
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x2375260 Offset: 0x2373860 VA: 0x182375260
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x2374820 Offset: 0x2372E20 VA: 0x182374820
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x2375D90 Offset: 0x2374390 VA: 0x182375D90
	internal static void EndLayoutGroup() { }

	// RVA: 0x2374490 Offset: 0x2372A90 VA: 0x182374490
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x2375BB0 Offset: 0x23741B0 VA: 0x182375BB0
	internal static void EndLayoutArea() { }

	// RVA: 0x23762E0 Offset: 0x23748E0 VA: 0x1823762E0
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x23755D0 Offset: 0x2373BD0 VA: 0x1823755D0
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2376230 Offset: 0x2374830 VA: 0x182376230
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x23753A0 Offset: 0x23739A0 VA: 0x1823753A0
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x23760F0 Offset: 0x23746F0 VA: 0x1823760F0
	public static Rect GetLastRect() { }

	// RVA: 0x23775D0 Offset: 0x2375BD0 VA: 0x1823775D0
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x2377490 Offset: 0x2375A90 VA: 0x182377490
	private static void .cctor() { }

	// RVA: 0x2376380 Offset: 0x2374980 VA: 0x182376380
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x2376440 Offset: 0x2374A40 VA: 0x182376440
	private static void Internal_MoveWindow_Injected(int windowID, in Rect r) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Serializable]
public sealed class GUISettings // TypeDefIndex: 12767
{
	// Fields
	[SerializeField]
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField]
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField]
	private Color m_CursorColor; // 0x14
	[SerializeField]
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField]
	private Color m_SelectionColor; // 0x28

	// Methods

	// RVA: 0x23793B0 Offset: 0x23779B0 VA: 0x1823793B0
	public void .ctor() { }
}

// Namespace: UnityEngine
[ExecuteInEditMode]
[RequiredByNativeCode]
[AssetFileNameExtension("guiskin", new[] {  })]
[Serializable]
public sealed class GUISkin : ScriptableObject // TypeDefIndex: 12769
{
	// Fields
	[SerializeField]
	private Font m_Font; // 0x18
	[SerializeField]
	private GUIStyle m_box; // 0x20
	[SerializeField]
	private GUIStyle m_button; // 0x28
	[SerializeField]
	private GUIStyle m_toggle; // 0x30
	[SerializeField]
	private GUIStyle m_label; // 0x38
	[SerializeField]
	private GUIStyle m_textField; // 0x40
	[SerializeField]
	private GUIStyle m_textArea; // 0x48
	[SerializeField]
	private GUIStyle m_window; // 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; // 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; // 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; // 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; // 0xD8
	[SerializeField]
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE8
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	internal GUIStyle sliderMixed { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x237AD60 Offset: 0x2379360 VA: 0x18237AD60
	public void .ctor() { }

	// RVA: 0x23793E0 Offset: 0x23779E0 VA: 0x1823793E0
	internal void OnEnable() { }

	// RVA: 0x237A780 Offset: 0x2378D80 VA: 0x18237A780
	internal static void CleanupRoots() { }

	// RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	public Font get_font() { }

	// RVA: 0x237B220 Offset: 0x2379820 VA: 0x18237B220
	public void set_font(Font value) { }

	// RVA: 0x2358D20 Offset: 0x2357320 VA: 0x182358D20
	public GUIStyle get_box() { }

	// RVA: 0x237B0A0 Offset: 0x23796A0 VA: 0x18237B0A0
	public void set_box(GUIStyle value) { }

	// RVA: 0x237AFC0 Offset: 0x23795C0 VA: 0x18237AFC0
	public GUIStyle get_label() { }

	// RVA: 0x237B730 Offset: 0x2379D30 VA: 0x18237B730
	public void set_label(GUIStyle value) { }

	// RVA: 0x237B010 Offset: 0x2379610 VA: 0x18237B010
	public GUIStyle get_textField() { }

	// RVA: 0x237B930 Offset: 0x2379F30 VA: 0x18237B930
	public void set_textField(GUIStyle value) { }

	// RVA: 0x237B000 Offset: 0x2379600 VA: 0x18237B000
	public GUIStyle get_textArea() { }

	// RVA: 0x237B8B0 Offset: 0x2379EB0 VA: 0x18237B8B0
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x234CC80 Offset: 0x234B280 VA: 0x18234CC80
	public GUIStyle get_button() { }

	// RVA: 0x237B120 Offset: 0x2379720 VA: 0x18237B120
	public void set_button(GUIStyle value) { }

	// RVA: 0x2358D10 Offset: 0x2357310 VA: 0x182358D10
	public GUIStyle get_toggle() { }

	// RVA: 0x237B9B0 Offset: 0x2379FB0 VA: 0x18237B9B0
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x237B090 Offset: 0x2379690 VA: 0x18237B090
	public GUIStyle get_window() { }

	// RVA: 0x237BDB0 Offset: 0x237A3B0 VA: 0x18237BDB0
	public void set_window(GUIStyle value) { }

	// RVA: 0x237AFB0 Offset: 0x23795B0 VA: 0x18237AFB0
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x237B6B0 Offset: 0x2379CB0 VA: 0x18237B6B0
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x237AFA0 Offset: 0x23795A0 VA: 0x18237AFA0
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x237B630 Offset: 0x2379C30 VA: 0x18237B630
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x237AF90 Offset: 0x2379590 VA: 0x18237AF90
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x237B5B0 Offset: 0x2379BB0 VA: 0x18237B5B0
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x237AFF0 Offset: 0x23795F0 VA: 0x18237AFF0
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x237B830 Offset: 0x2379E30 VA: 0x18237B830
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x237B080 Offset: 0x2379680 VA: 0x18237B080
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x237BD30 Offset: 0x237A330 VA: 0x18237BD30
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x237B070 Offset: 0x2379670 VA: 0x18237B070
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x237BCB0 Offset: 0x237A2B0 VA: 0x18237BCB0
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x237B060 Offset: 0x2379660 VA: 0x18237B060
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x237BC30 Offset: 0x237A230 VA: 0x18237BC30
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x237AF80 Offset: 0x2379580 VA: 0x18237AF80
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x237B530 Offset: 0x2379B30 VA: 0x18237B530
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x237AF70 Offset: 0x2379570 VA: 0x18237AF70
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x237B4B0 Offset: 0x2379AB0 VA: 0x18237B4B0
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x237AF50 Offset: 0x2379550 VA: 0x18237AF50
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x237B3B0 Offset: 0x23799B0 VA: 0x18237B3B0
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x237AF60 Offset: 0x2379560 VA: 0x18237AF60
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x237B430 Offset: 0x2379A30 VA: 0x18237B430
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x237B050 Offset: 0x2379650 VA: 0x18237B050
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x237BBB0 Offset: 0x237A1B0 VA: 0x18237BBB0
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x237B030 Offset: 0x2379630 VA: 0x18237B030
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x237BAB0 Offset: 0x237A0B0 VA: 0x18237BAB0
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x237B040 Offset: 0x2379640 VA: 0x18237B040
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x237BB30 Offset: 0x237A130 VA: 0x18237BB30
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x237B020 Offset: 0x2379620 VA: 0x18237B020
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x237BA30 Offset: 0x237A030 VA: 0x18237BA30
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x237AFD0 Offset: 0x23795D0 VA: 0x18237AFD0
	public GUIStyle get_scrollView() { }

	// RVA: 0x237B7B0 Offset: 0x2379DB0 VA: 0x18237B7B0
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x237AE40 Offset: 0x2379440 VA: 0x18237AE40
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x237B1A0 Offset: 0x23797A0 VA: 0x18237B1A0
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x237AFE0 Offset: 0x23795E0 VA: 0x18237AFE0
	public GUISettings get_settings() { }

	// RVA: 0x237AE50 Offset: 0x2379450 VA: 0x18237AE50
	internal static GUIStyle get_error() { }

	// RVA: 0x23793E0 Offset: 0x23779E0 VA: 0x1823793E0
	internal void Apply() { }

	// RVA: 0x2379450 Offset: 0x2377A50 VA: 0x182379450
	private void BuildStyleCache() { }

	// RVA: 0x237A950 Offset: 0x2378F50 VA: 0x18237A950
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x237A800 Offset: 0x2378E00 VA: 0x18237A800
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x237AC30 Offset: 0x2379230 VA: 0x18237AC30
	internal void MakeCurrent() { }

	// RVA: 0x237A890 Offset: 0x2378E90 VA: 0x18237A890
	public IEnumerator GetEnumerator() { }
}

// Namespace: UnityEngine
internal class GUIStateObjects // TypeDefIndex: 12770
{
	// Fields
	private static Dictionary<int, object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x237BE30 Offset: 0x237A430 VA: 0x18237BE30
	internal static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x237BF80 Offset: 0x237A580 VA: 0x18237BF80
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Serializable]
public sealed class GUIStyleState // TypeDefIndex: 12772
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("Background", False, 0)]
	public Texture2D background { get; set; }
	[NativeProperty("textColor", False, 1)]
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x237C280 Offset: 0x237A880 VA: 0x18237C280
	public Texture2D get_background() { }

	// RVA: 0x237C420 Offset: 0x237AA20 VA: 0x18237C420
	public void set_background(Texture2D value) { }

	// RVA: 0x237C360 Offset: 0x237A960 VA: 0x18237C360
	public Color get_textColor() { }

	// RVA: 0x237C520 Offset: 0x237AB20 VA: 0x18237C520
	public void set_textColor(Color value) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x237C1D0 Offset: 0x237A7D0 VA: 0x18237C1D0
	private static IntPtr Init() { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x237C050 Offset: 0x237A650 VA: 0x18237C050
	private void Cleanup() { }

	// RVA: 0x237C200 Offset: 0x237A800 VA: 0x18237C200
	public void .ctor() { }

	// RVA: 0x230FD00 Offset: 0x230E300 VA: 0x18230FD00
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x237C150 Offset: 0x237A750 VA: 0x18237C150
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x237C0B0 Offset: 0x237A6B0 VA: 0x18237C0B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x237C240 Offset: 0x237A840 VA: 0x18237C240
	private static IntPtr get_background_Injected(IntPtr _unity_self) { }

	// RVA: 0x237C3D0 Offset: 0x237A9D0 VA: 0x18237C3D0
	private static void set_background_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x237C310 Offset: 0x237A910 VA: 0x18237C310
	private static void get_textColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x237C4D0 Offset: 0x237AAD0 VA: 0x18237C4D0
	private static void set_textColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x237C010 Offset: 0x237A610 VA: 0x18237C010
	private static void Cleanup_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("IMGUIScriptingClasses.h")]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[RequiredByNativeCode]
[Serializable]
public sealed class GUIStyle // TypeDefIndex: 12774
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativeProperty("Name", False, 0)]
	internal string rawName { get; set; }
	[NativeProperty("Font", False, 0)]
	public Font font { get; set; }
	[NativeProperty("m_ImagePosition", False, 1)]
	public ImagePosition imagePosition { get; set; }
	[NativeProperty("m_Alignment", False, 1)]
	public TextAnchor alignment { get; set; }
	[NativeProperty("m_WordWrap", False, 1)]
	public bool wordWrap { get; set; }
	[NativeProperty("m_Clipping", False, 1)]
	public TextClipping clipping { get; set; }
	[NativeProperty("m_ContentOffset", False, 1)]
	public Vector2 contentOffset { get; set; }
	[NativeProperty("m_FixedWidth", False, 1)]
	public float fixedWidth { get; set; }
	[NativeProperty("m_FixedHeight", False, 1)]
	public float fixedHeight { get; set; }
	[NativeProperty("m_StretchWidth", False, 1)]
	public bool stretchWidth { get; set; }
	[NativeProperty("m_StretchHeight", False, 1)]
	public bool stretchHeight { get; set; }
	[NativeProperty("m_FontSize", False, 1)]
	public int fontSize { get; set; }
	[NativeProperty("m_FontStyle", False, 1)]
	public FontStyle fontStyle { get; set; }
	[NativeProperty("m_RichText", False, 1)]
	public bool richText { get; set; }
	public string name { get; set; }
	public GUIStyleState normal { get; set; }
	public GUIStyleState hover { get; set; }
	public GUIStyleState active { get; set; }
	public GUIStyleState onNormal { get; set; }
	public GUIStyleState onHover { get; set; }
	public GUIStyleState onActive { get; set; }
	public GUIStyleState focused { get; set; }
	public GUIStyleState onFocused { get; set; }
	public RectOffset border { get; set; }
	public RectOffset margin { get; set; }
	public RectOffset padding { get; set; }
	public RectOffset overflow { get; set; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x2380260 Offset: 0x237E860 VA: 0x182380260
	internal string get_rawName() { }

	// RVA: 0x23817F0 Offset: 0x237FDF0 VA: 0x1823817F0
	internal void set_rawName(string value) { }

	// RVA: 0x237F580 Offset: 0x237DB80 VA: 0x18237F580
	public Font get_font() { }

	// RVA: 0x2380F70 Offset: 0x237F570 VA: 0x182380F70
	public void set_font(Font value) { }

	// RVA: 0x237F730 Offset: 0x237DD30 VA: 0x18237F730
	public ImagePosition get_imagePosition() { }

	// RVA: 0x2381140 Offset: 0x237F740 VA: 0x182381140
	public void set_imagePosition(ImagePosition value) { }

	// RVA: 0x237EE00 Offset: 0x237D400 VA: 0x18237EE00
	public TextAnchor get_alignment() { }

	// RVA: 0x23807B0 Offset: 0x237EDB0 VA: 0x1823807B0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2380630 Offset: 0x237EC30 VA: 0x182380630
	public bool get_wordWrap() { }

	// RVA: 0x2381CE0 Offset: 0x23802E0 VA: 0x182381CE0
	public void set_wordWrap(bool value) { }

	// RVA: 0x237EFC0 Offset: 0x237D5C0 VA: 0x18237EFC0
	public TextClipping get_clipping() { }

	// RVA: 0x2380940 Offset: 0x237EF40 VA: 0x182380940
	public void set_clipping(TextClipping value) { }

	// RVA: 0x237F0A0 Offset: 0x237D6A0 VA: 0x18237F0A0
	public Vector2 get_contentOffset() { }

	// RVA: 0x2380A30 Offset: 0x237F030 VA: 0x182380A30
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x237F250 Offset: 0x237D850 VA: 0x18237F250
	public float get_fixedWidth() { }

	// RVA: 0x2380C10 Offset: 0x237F210 VA: 0x182380C10
	public void set_fixedWidth(float value) { }

	// RVA: 0x237F180 Offset: 0x237D780 VA: 0x18237F180
	public float get_fixedHeight() { }

	// RVA: 0x2380B20 Offset: 0x237F120 VA: 0x182380B20
	public void set_fixedHeight(float value) { }

	// RVA: 0x2380560 Offset: 0x237EB60 VA: 0x182380560
	public bool get_stretchWidth() { }

	// RVA: 0x2381BF0 Offset: 0x23801F0 VA: 0x182381BF0
	public void set_stretchWidth(bool value) { }

	// RVA: 0x2380490 Offset: 0x237EA90 VA: 0x182380490
	public bool get_stretchHeight() { }

	// RVA: 0x2381B00 Offset: 0x2380100 VA: 0x182381B00
	public void set_stretchHeight(bool value) { }

	// RVA: 0x237F3E0 Offset: 0x237D9E0 VA: 0x18237F3E0
	public int get_fontSize() { }

	// RVA: 0x2380DA0 Offset: 0x237F3A0 VA: 0x182380DA0
	public void set_fontSize(int value) { }

	// RVA: 0x237F4B0 Offset: 0x237DAB0 VA: 0x18237F4B0
	public FontStyle get_fontStyle() { }

	// RVA: 0x2380E80 Offset: 0x237F480 VA: 0x182380E80
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x23803C0 Offset: 0x237E9C0 VA: 0x1823803C0
	public bool get_richText() { }

	// RVA: 0x2381A10 Offset: 0x2380010 VA: 0x182381A10
	public void set_richText(bool value) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x237E0F0 Offset: 0x237C6F0 VA: 0x18237E0F0
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = True)]
	// RVA: 0x237E070 Offset: 0x237C670 VA: 0x18237E070
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x237E170 Offset: 0x237C770 VA: 0x18237E170
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x237DCE0 Offset: 0x237C2E0 VA: 0x18237DCE0
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::AssignStyleState", HasExplicitThis = True)]
	// RVA: 0x237C6D0 Offset: 0x237ACD0 VA: 0x18237C6D0
	private void AssignStyleState(int idx, IntPtr srcStyleState) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	// RVA: 0x237DC00 Offset: 0x237C200 VA: 0x18237DC00
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = True)]
	// RVA: 0x237C5D0 Offset: 0x237ABD0 VA: 0x18237C5D0
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	// RVA: 0x237E380 Offset: 0x237C980 VA: 0x18237E380
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	// RVA: 0x237E220 Offset: 0x237C820 VA: 0x18237E220
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	// RVA: 0x237DF60 Offset: 0x237C560 VA: 0x18237DF60
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	// RVA: 0x237C780 Offset: 0x237AD80 VA: 0x18237C780
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	// RVA: 0x237DE40 Offset: 0x237C440 VA: 0x18237DE40
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = True)]
	// RVA: 0x237E4E0 Offset: 0x237CAE0 VA: 0x18237E4E0
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	// RVA: 0x237E8A0 Offset: 0x237CEA0 VA: 0x18237E8A0
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	// RVA: 0x237E5E0 Offset: 0x237CBE0 VA: 0x18237E5E0
	internal static bool IsTooltipActive(string tooltip) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	// RVA: 0x237E7C0 Offset: 0x237CDC0 VA: 0x18237E7C0
	internal static void SetDefaultFont(Font font) { }

	[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
	// RVA: 0x237D520 Offset: 0x237BB20 VA: 0x18237D520
	internal static Font GetDefaultFont() { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
	// RVA: 0x237E130 Offset: 0x237C730 VA: 0x18237E130
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	// RVA: 0x237EC80 Offset: 0x237D280 VA: 0x18237EC80
	public void .ctor() { }

	// RVA: 0x237EB70 Offset: 0x237D170 VA: 0x18237EB70
	public void .ctor(GUIStyle other) { }

	// RVA: 0x237D0E0 Offset: 0x237B6E0 VA: 0x18237D0E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x237FB70 Offset: 0x237E170 VA: 0x18237FB70
	public string get_name() { }

	// RVA: 0x2381290 Offset: 0x237F890 VA: 0x182381290
	public void set_name(string value) { }

	// RVA: 0x237FC70 Offset: 0x237E270 VA: 0x18237FC70
	public GUIStyleState get_normal() { }

	// RVA: 0x23812D0 Offset: 0x237F8D0 VA: 0x1823812D0
	public void set_normal(GUIStyleState value) { }

	// RVA: 0x237F630 Offset: 0x237DC30 VA: 0x18237F630
	public GUIStyleState get_hover() { }

	// RVA: 0x2381050 Offset: 0x237F650 VA: 0x182381050
	public void set_hover(GUIStyleState value) { }

	// RVA: 0x237ED00 Offset: 0x237D300 VA: 0x18237ED00
	public GUIStyleState get_active() { }

	// RVA: 0x23806C0 Offset: 0x237ECC0 VA: 0x1823806C0
	public void set_active(GUIStyleState value) { }

	// RVA: 0x237FF70 Offset: 0x237E570 VA: 0x18237FF70
	public GUIStyleState get_onNormal() { }

	// RVA: 0x2381590 Offset: 0x237FB90 VA: 0x182381590
	public void set_onNormal(GUIStyleState value) { }

	// RVA: 0x237FEB0 Offset: 0x237E4B0 VA: 0x18237FEB0
	public GUIStyleState get_onHover() { }

	// RVA: 0x23814E0 Offset: 0x237FAE0 VA: 0x1823814E0
	public void set_onHover(GUIStyleState value) { }

	// RVA: 0x237FD30 Offset: 0x237E330 VA: 0x18237FD30
	public GUIStyleState get_onActive() { }

	// RVA: 0x2381380 Offset: 0x237F980 VA: 0x182381380
	public void set_onActive(GUIStyleState value) { }

	// RVA: 0x237F2E0 Offset: 0x237D8E0 VA: 0x18237F2E0
	public GUIStyleState get_focused() { }

	// RVA: 0x2380CB0 Offset: 0x237F2B0 VA: 0x182380CB0
	public void set_focused(GUIStyleState value) { }

	// RVA: 0x237FDF0 Offset: 0x237E3F0 VA: 0x18237FDF0
	public GUIStyleState get_onFocused() { }

	// RVA: 0x2381430 Offset: 0x237FA30 VA: 0x182381430
	public void set_onFocused(GUIStyleState value) { }

	// RVA: 0x237EE90 Offset: 0x237D490 VA: 0x18237EE90
	public RectOffset get_border() { }

	// RVA: 0x2380850 Offset: 0x237EE50 VA: 0x182380850
	public void set_border(RectOffset value) { }

	// RVA: 0x237FA80 Offset: 0x237E080 VA: 0x18237FA80
	public RectOffset get_margin() { }

	// RVA: 0x23811E0 Offset: 0x237F7E0 VA: 0x1823811E0
	public void set_margin(RectOffset value) { }

	// RVA: 0x2380120 Offset: 0x237E720 VA: 0x182380120
	public RectOffset get_padding() { }

	// RVA: 0x23816F0 Offset: 0x237FCF0 VA: 0x1823816F0
	public void set_padding(RectOffset value) { }

	// RVA: 0x2380030 Offset: 0x237E630 VA: 0x182380030
	public RectOffset get_overflow() { }

	// RVA: 0x2381640 Offset: 0x237FC40 VA: 0x182381640
	public void set_overflow(RectOffset value) { }

	// RVA: 0x237F950 Offset: 0x237DF50 VA: 0x18237F950
	public float get_lineHeight() { }

	// RVA: 0x237CC70 Offset: 0x237B270 VA: 0x18237CC70
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x237CB80 Offset: 0x237B180 VA: 0x18237CB80
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x237CDB0 Offset: 0x237B3B0 VA: 0x18237CDB0
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x237CDF0 Offset: 0x237B3F0 VA: 0x18237CDF0
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x237CA00 Offset: 0x237B000 VA: 0x18237CA00
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x237FBB0 Offset: 0x237E1B0 VA: 0x18237FBB0
	public static GUIStyle get_none() { }

	// RVA: 0x237D1A0 Offset: 0x237B7A0 VA: 0x18237D1A0
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x237C900 Offset: 0x237AF00 VA: 0x18237C900
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x237C780 Offset: 0x237AD80 VA: 0x18237C780
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x237DAD0 Offset: 0x237C0D0 VA: 0x18237DAD0
	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	// RVA: 0x237F7C0 Offset: 0x237DDC0 VA: 0x18237F7C0
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x237C830 Offset: 0x237AE30 VA: 0x18237C830
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x237EA40 Offset: 0x237D040 VA: 0x18237EA40 Slot: 3
	public override string ToString() { }

	[RequiredByNativeCode]
	// RVA: 0x237D6E0 Offset: 0x237BCE0 VA: 0x18237D6E0
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId) { }

	[RequiredByNativeCode]
	// RVA: 0x237D5A0 Offset: 0x237BBA0 VA: 0x18237D5A0
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions) { }

	[RequiredByNativeCode]
	// RVA: 0x237D6B0 Offset: 0x237BCB0 VA: 0x18237D6B0
	internal static void GetLineHeight(GUIStyle style, ref float lineHeight) { }

	[RequiredByNativeCode]
	// RVA: 0x237D010 Offset: 0x237B610 VA: 0x18237D010
	internal static void EmptyManagedCache() { }

	// RVA: 0x237EB30 Offset: 0x237D130 VA: 0x18237EB30
	private static void .cctor() { }

	// RVA: 0x2380210 Offset: 0x237E810 VA: 0x182380210
	private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x23817A0 Offset: 0x237FDA0 VA: 0x1823817A0
	private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x237F540 Offset: 0x237DB40 VA: 0x18237F540
	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	// RVA: 0x2380F20 Offset: 0x237F520 VA: 0x182380F20
	private static void set_font_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x237F6F0 Offset: 0x237DCF0 VA: 0x18237F6F0
	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	// RVA: 0x2381100 Offset: 0x237F700 VA: 0x182381100
	private static void set_imagePosition_Injected(IntPtr _unity_self, ImagePosition value) { }

	// RVA: 0x237EDC0 Offset: 0x237D3C0 VA: 0x18237EDC0
	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	// RVA: 0x2380770 Offset: 0x237ED70 VA: 0x182380770
	private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value) { }

	// RVA: 0x23805F0 Offset: 0x237EBF0 VA: 0x1823805F0
	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	// RVA: 0x2381C90 Offset: 0x2380290 VA: 0x182381C90
	private static void set_wordWrap_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x237EF80 Offset: 0x237D580 VA: 0x18237EF80
	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x2380900 Offset: 0x237EF00 VA: 0x182380900
	private static void set_clipping_Injected(IntPtr _unity_self, TextClipping value) { }

	// RVA: 0x237F050 Offset: 0x237D650 VA: 0x18237F050
	private static void get_contentOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x23809E0 Offset: 0x237EFE0 VA: 0x1823809E0
	private static void set_contentOffset_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x237F210 Offset: 0x237D810 VA: 0x18237F210
	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x2380BC0 Offset: 0x237F1C0 VA: 0x182380BC0
	private static void set_fixedWidth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x237F140 Offset: 0x237D740 VA: 0x18237F140
	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x2380AD0 Offset: 0x237F0D0 VA: 0x182380AD0
	private static void set_fixedHeight_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x2380520 Offset: 0x237EB20 VA: 0x182380520
	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x2381BA0 Offset: 0x23801A0 VA: 0x182381BA0
	private static void set_stretchWidth_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x2380450 Offset: 0x237EA50 VA: 0x182380450
	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x2381AB0 Offset: 0x23800B0 VA: 0x182381AB0
	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x237F3A0 Offset: 0x237D9A0 VA: 0x18237F3A0
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x2380D60 Offset: 0x237F360 VA: 0x182380D60
	private static void set_fontSize_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x237F470 Offset: 0x237DA70 VA: 0x18237F470
	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	// RVA: 0x2380E40 Offset: 0x237F440 VA: 0x182380E40
	private static void set_fontStyle_Injected(IntPtr _unity_self, FontStyle value) { }

	// RVA: 0x2380380 Offset: 0x237E980 VA: 0x182380380
	private static bool get_richText_Injected(IntPtr _unity_self) { }

	// RVA: 0x23819C0 Offset: 0x237FFC0 VA: 0x1823819C0
	private static void set_richText_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x237E020 Offset: 0x237C620 VA: 0x18237E020
	private static IntPtr Internal_Copy_Injected(GUIStyle self, IntPtr other) { }

	// RVA: 0x237DCA0 Offset: 0x237C2A0 VA: 0x18237DCA0
	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	// RVA: 0x237C680 Offset: 0x237AC80 VA: 0x18237C680
	private static void AssignStyleState_Injected(IntPtr _unity_self, int idx, IntPtr srcStyleState) { }

	// RVA: 0x237DBC0 Offset: 0x237C1C0 VA: 0x18237DBC0
	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	// RVA: 0x237C580 Offset: 0x237AB80 VA: 0x18237C580
	private static void AssignRectOffset_Injected(IntPtr _unity_self, int idx, IntPtr srcRectOffset) { }

	// RVA: 0x237E2F0 Offset: 0x237C8F0 VA: 0x18237E2F0
	private static void Internal_Draw_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x237E1B0 Offset: 0x237C7B0 VA: 0x18237E1B0
	private static void Internal_Draw2_Injected(IntPtr _unity_self, in Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x237DEF0 Offset: 0x237C4F0 VA: 0x18237DEF0
	private static void Internal_CalcSizeWithConstraints_Injected(IntPtr _unity_self, GUIContent content, in Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x237DD80 Offset: 0x237C380 VA: 0x18237DD80
	private static float Internal_CalcHeight_Injected(IntPtr _unity_self, GUIContent content, float width) { }

	// RVA: 0x237DDE0 Offset: 0x237C3E0 VA: 0x18237DDE0
	private static void Internal_CalcMinMaxWidth_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret) { }

	// RVA: 0x237E470 Offset: 0x237CA70 VA: 0x18237E470
	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, in Vector2 textSize, out Vector2 ret) { }

	// RVA: 0x237E850 Offset: 0x237CE50 VA: 0x18237E850
	private static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, in Rect screenRect) { }

	// RVA: 0x237E5A0 Offset: 0x237CBA0 VA: 0x18237E5A0
	private static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip) { }

	// RVA: 0x237E780 Offset: 0x237CD80 VA: 0x18237E780
	private static void SetDefaultFont_Injected(IntPtr font) { }

	// RVA: 0x237D4F0 Offset: 0x237BAF0 VA: 0x18237D4F0
	private static IntPtr GetDefaultFont_Injected() { }
}

// Namespace: UnityEngine
public enum ImagePosition // TypeDefIndex: 12775
{
	// Fields
	public int value__; // 0x0
	public const ImagePosition ImageLeft = 0;
	public const ImagePosition ImageAbove = 1;
	public const ImagePosition ImageOnly = 2;
	public const ImagePosition TextOnly = 3;
}

// Namespace: UnityEngine
public enum TextClipping // TypeDefIndex: 12776
{
	// Fields
	public int value__; // 0x0
	public const TextClipping Overflow = 0;
	public const TextClipping Clip = 1;
	public const TextClipping Ellipsis = 2;
}

// Namespace: UnityEngine
[Usage(64)]
public class GUITargetAttribute : Attribute // TypeDefIndex: 12777
{
	// Fields
	internal int displayMask; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2381D80 Offset: 0x2380380 VA: 0x182381D80
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
public class GUIUtility // TypeDefIndex: 12778
{
	// Fields
	internal static int s_ControlCount; // 0x0
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static int s_SkinMode; // 0x4
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static int s_OriginalID; // 0x8
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Action takeCapture; // 0x10
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Action releaseCapture; // 0x18
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Func<int, IntPtr, bool> processEvent; // 0x20
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Action cleanupRoots; // 0x28
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x30
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Action guiChanged; // 0x38
	internal static Action<EventType, KeyCode> beforeEventProcessed; // 0x40
	private static Event m_Event; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <guiIsExiting>k__BackingField; // 0x50
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x58

	// Properties
	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, 1)]
	internal static float pixelsPerPoint { get; }
	[NativeProperty("GetGUIState().m_OnGUIDepth", True, 1)]
	internal static int guiDepth { get; }
	[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", True, 1)]
	internal static bool mouseUsed { set; }
	[StaticAccessor("GetInputManager()", 0)]
	internal static bool textFieldInput { get; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessor("InputBindings", 2)]
	internal static string compositionString { get; }
	[StaticAccessor("InputBindings", 2)]
	internal static IMECompositionMode imeCompositionMode { set; }
	[StaticAccessor("InputBindings", 2)]
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2384120 Offset: 0x2382720 VA: 0x182384120
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2384030 Offset: 0x2382630 VA: 0x182384030
	internal static int get_guiDepth() { }

	// RVA: 0x23844D0 Offset: 0x2382AD0 VA: 0x1823844D0
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x2384270 Offset: 0x2382870 VA: 0x182384270
	internal static bool get_textFieldInput() { }

	[FreeFunction("GetCopyBuffer")]
	// RVA: 0x2384190 Offset: 0x2382790 VA: 0x182384190
	public static string get_systemCopyBuffer() { }

	[FreeFunction("SetCopyBuffer")]
	// RVA: 0x2384550 Offset: 0x2382B50 VA: 0x182384550
	public static void set_systemCopyBuffer(string value) { }

	[FreeFunction("GetGUIState().GetControlID")]
	// RVA: 0x2383500 Offset: 0x2381B00 VA: 0x182383500
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x2382D00 Offset: 0x2381300 VA: 0x182382D00
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2382150 Offset: 0x2380750 VA: 0x182382150
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2382220 Offset: 0x2380820 VA: 0x182382220
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethod("EndContainer")]
	// RVA: 0x2383450 Offset: 0x2381A50 VA: 0x182383450
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2382500 Offset: 0x2380B00 VA: 0x182382500
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2383CD0 Offset: 0x23822D0 VA: 0x182383CD0
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2383D00 Offset: 0x2382300 VA: 0x182383D00
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2382FF0 Offset: 0x23815F0 VA: 0x182382FF0
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2383790 Offset: 0x2381D90 VA: 0x182383790
	internal static bool OwnsId(int id) { }

	// RVA: 0x2381F90 Offset: 0x2380590 VA: 0x182381F90
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	// RVA: 0x2383F50 Offset: 0x2382550 VA: 0x182383F50
	internal static string get_compositionString() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2384420 Offset: 0x2382A20 VA: 0x182384420
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x23842E0 Offset: 0x23828E0 VA: 0x1823842E0
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x23835C0 Offset: 0x2381BC0 VA: 0x1823835C0
	private static int Internal_GetHotControl() { }

	// RVA: 0x23835F0 Offset: 0x2381BF0 VA: 0x1823835F0
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x2383620 Offset: 0x2381C20 VA: 0x182383620
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x2383660 Offset: 0x2381C60 VA: 0x182383660
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x2383580 Offset: 0x2381B80 VA: 0x182383580
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x2383480 Offset: 0x2381A80 VA: 0x182383480
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCode]
	// RVA: 0x2383720 Offset: 0x2381D20 VA: 0x182383720
	private static void MarkGUIChanged() { }

	// RVA: 0x2382C80 Offset: 0x2381280 VA: 0x182382C80
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x2382E70 Offset: 0x2381470 VA: 0x182382E70
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGenerated]
	// RVA: 0x2384350 Offset: 0x2382950 VA: 0x182384350
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x2384060 Offset: 0x2382660 VA: 0x182384060
	public static int get_hotControl() { }

	// RVA: 0x23843B0 Offset: 0x23829B0 VA: 0x1823843B0
	public static void set_hotControl(int value) { }

	[RequiredByNativeCode]
	// RVA: 0x2383DE0 Offset: 0x23823E0 VA: 0x182383DE0
	internal static void TakeCapture() { }

	[RequiredByNativeCode]
	// RVA: 0x2383A20 Offset: 0x2382020 VA: 0x182383A20
	internal static void RemoveCapture() { }

	// RVA: 0x23840C0 Offset: 0x23826C0 VA: 0x1823840C0
	public static int get_keyboardControl() { }

	// RVA: 0x2384460 Offset: 0x2382A60 VA: 0x182384460
	public static void set_keyboardControl(int value) { }

	// RVA: 0x2383020 Offset: 0x2381620 VA: 0x182383020
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x2382C40 Offset: 0x2381240 VA: 0x182382C40
	public static void ExitGUI() { }

	// RVA: 0x2382DD0 Offset: 0x23813D0 VA: 0x182382DD0
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCode]
	// RVA: 0x23837D0 Offset: 0x2381DD0 VA: 0x1823837D0
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23826D0 Offset: 0x2380CD0 VA: 0x1823826D0
	internal static void EndContainer() { }

	[RequiredByNativeCode]
	// RVA: 0x2382290 Offset: 0x2380890 VA: 0x182382290
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCode]
	// RVA: 0x2382850 Offset: 0x2380E50 VA: 0x182382850
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCode]
	// RVA: 0x2382750 Offset: 0x2380D50 VA: 0x182382750
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCode]
	// RVA: 0x2382630 Offset: 0x2380C30 VA: 0x182382630
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2383A90 Offset: 0x2382090 VA: 0x182383A90
	internal static void ResetGlobalState() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23836A0 Offset: 0x2381CA0 VA: 0x1823836A0
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2383D30 Offset: 0x2382330 VA: 0x182383D30
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x2382570 Offset: 0x2380B70 VA: 0x182382570
	internal static void CheckOnGUI() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2383C20 Offset: 0x2382220 VA: 0x182383C20
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x2382030 Offset: 0x2380630 VA: 0x182382030
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x2383320 Offset: 0x2381920 VA: 0x182383320
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23833A0 Offset: 0x23819A0 VA: 0x1823833A0
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x2383140 Offset: 0x2381740 VA: 0x182383140
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x2383E50 Offset: 0x2382450 VA: 0x182383E50
	private static void .cctor() { }

	// RVA: 0x2384150 Offset: 0x2382750 VA: 0x182384150
	private static void get_systemCopyBuffer_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x2384510 Offset: 0x2382B10 VA: 0x182384510
	private static void set_systemCopyBuffer_Injected(ref ManagedSpanWrapper value) { }

	// RVA: 0x23834B0 Offset: 0x2381AB0 VA: 0x1823834B0
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, in Rect rect) { }

	// RVA: 0x2382110 Offset: 0x2380710 VA: 0x182382110
	private static void BeginContainerFromOwner_Injected(IntPtr owner) { }

	// RVA: 0x23821E0 Offset: 0x23807E0 VA: 0x1823821E0
	private static void BeginContainer_Injected(IntPtr objectGUIState) { }

	// RVA: 0x23824C0 Offset: 0x2380AC0 VA: 0x1823824C0
	private static int CheckForTabEvent_Injected(IntPtr evt) { }

	// RVA: 0x2381F20 Offset: 0x2380520 VA: 0x182381F20
	private static void AlignRectToDevice_Injected(in Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x2383F10 Offset: 0x2382510 VA: 0x182383F10
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x23842A0 Offset: 0x23828A0 VA: 0x1823842A0
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }
}

// Namespace: UnityEngine
public sealed class ExitGUIException : Exception // TypeDefIndex: 12779
{
	// Methods

	// RVA: 0x2373180 Offset: 0x2371780 VA: 0x182373180
	public void .ctor() { }

	// RVA: 0x2373240 Offset: 0x2371840 VA: 0x182373240
	internal void .ctor(string message) { }
}

// Namespace: UnityEngine
internal class IMGUITextHandle : TextHandle // TypeDefIndex: 12781
{
	// Fields
	internal LinkedListNode<IMGUITextHandle.TextHandleTuple> tuple; // 0x48
	private static Dictionary<int, IMGUITextHandle> textHandles; // 0x0
	private static LinkedList<IMGUITextHandle.TextHandleTuple> textHandlesTuple; // 0x8
	private static float lastCleanupTime; // 0x10
	internal bool isCachedOnNative; // 0x50

	// Methods

	// RVA: 0x238D060 Offset: 0x238B660 VA: 0x18238D060
	internal static void EmptyManagedCache() { }

	// RVA: 0x238D360 Offset: 0x238B960 VA: 0x18238D360
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor) { }

	// RVA: 0x238D200 Offset: 0x238B800 VA: 0x18238D200
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached) { }

	// RVA: 0x238C6C0 Offset: 0x238ACC0 VA: 0x18238C6C0
	private static void ClearUnusedTextHandles() { }

	// RVA: 0x238D4B0 Offset: 0x238BAB0 VA: 0x18238D4B0
	private static IMGUITextHandle GetTextHandle(TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached) { }

	// RVA: 0x238D100 Offset: 0x238B700 VA: 0x18238D100
	internal static float GetLineHeight(GUIStyle style) { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	internal Vector2 GetPreferredSize() { }

	// RVA: 0x238C8A0 Offset: 0x238AEA0 VA: 0x18238C8A0
	private static void ConvertGUIStyleToGenerationSettings(TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect) { }

	// RVA: 0x238DA20 Offset: 0x238C020 VA: 0x18238DA20
	private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping) { }

	// RVA: 0x238DB30 Offset: 0x238C130 VA: 0x18238DB30
	public void .ctor() { }

	// RVA: 0x238DA40 Offset: 0x238C040 VA: 0x18238DA40
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class GUILayoutEntry // TypeDefIndex: 12782
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x237B010 Offset: 0x2379610 VA: 0x18237B010
	public GUIStyle get_style() { }

	// RVA: 0x238EE10 Offset: 0x238D410 VA: 0x18238EE10
	public void set_style(GUIStyle value) { }

	// RVA: 0x238ED30 Offset: 0x238D330 VA: 0x18238ED30 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x238ED60 Offset: 0x238D360 VA: 0x18238ED60 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x238ED90 Offset: 0x238D390 VA: 0x18238ED90 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x238ECB0 Offset: 0x238D2B0 VA: 0x18238ECB0 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x238ECE0 Offset: 0x238D2E0 VA: 0x18238ECE0
	public int get_marginHorizontal() { }

	// RVA: 0x238EDC0 Offset: 0x238D3C0 VA: 0x18238EDC0
	public int get_marginVertical() { }

	// RVA: 0x238EA90 Offset: 0x238D090 VA: 0x18238EA90
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x238EBA0 Offset: 0x238D1A0 VA: 0x18238EBA0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x238E4A0 Offset: 0x238CAA0 VA: 0x18238E4A0 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x238E4B0 Offset: 0x238CAB0 VA: 0x18238E4B0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x238E3F0 Offset: 0x238C9F0 VA: 0x18238E3F0 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x238E070 Offset: 0x238C670 VA: 0x18238E070 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x238E4C0 Offset: 0x238CAC0 VA: 0x18238E4C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x238EA30 Offset: 0x238D030 VA: 0x18238EA30
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal sealed class GUIWordWrapSizer : GUILayoutEntry // TypeDefIndex: 12783
{
	// Fields
	private readonly GUIContent m_Content; // 0x48
	private readonly float m_ForcedMinHeight; // 0x50
	private readonly float m_ForcedMaxHeight; // 0x54

	// Methods

	// RVA: 0x2392290 Offset: 0x2390890 VA: 0x182392290
	public void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x23921D0 Offset: 0x23907D0 VA: 0x1823921D0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x2392150 Offset: 0x2390750 VA: 0x182392150 Slot: 9
	public override void CalcHeight() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "UnityEditor.CoreModule" })]
internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 12784
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x498D50 Offset: 0x497350 VA: 0x180498D50 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x486A80 Offset: 0x485080 VA: 0x180486A80 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x46E210 Offset: 0x46C810 VA: 0x18046E210 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x2391980 Offset: 0x238FF80 VA: 0x182391980
	public void .ctor() { }

	// RVA: 0x238EF00 Offset: 0x238D500 VA: 0x18238EF00 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x238EFF0 Offset: 0x238D5F0 VA: 0x18238EFF0 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x2390430 Offset: 0x238EA30 VA: 0x182390430
	public void ResetCursor() { }

	// RVA: 0x2390190 Offset: 0x238E790 VA: 0x182390190
	public GUILayoutEntry GetNext() { }

	// RVA: 0x238FE80 Offset: 0x238E480 VA: 0x18238FE80
	public Rect GetLast() { }

	// RVA: 0x238EE50 Offset: 0x238D450 VA: 0x18238EE50
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x238F780 Offset: 0x238DD80 VA: 0x18238F780 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x2390440 Offset: 0x238EA40 VA: 0x182390440 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x238F0F0 Offset: 0x238D6F0 VA: 0x18238F0F0 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x2390CB0 Offset: 0x238F2B0 VA: 0x182390CB0 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x2391530 Offset: 0x238FB30 VA: 0x182391530 Slot: 3
	public override string ToString() { }

	// RVA: 0x23918A0 Offset: 0x238FEA0 VA: 0x1823918A0
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 12785
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2391FE0 Offset: 0x23905E0 VA: 0x182391FE0
	public void .ctor() { }

	// RVA: 0x2391BD0 Offset: 0x23901D0 VA: 0x182391BD0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x2391C70 Offset: 0x2390270 VA: 0x182391C70 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x2391AB0 Offset: 0x23900B0 VA: 0x182391AB0 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x2391DC0 Offset: 0x23903C0 VA: 0x182391DC0 Slot: 11
	public override void SetVertical(float y, float height) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIState.h")]
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class ObjectGUIState : IDisposable // TypeDefIndex: 12787
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x2392570 Offset: 0x2390B70 VA: 0x182392570
	public void .ctor() { }

	// RVA: 0x23923D0 Offset: 0x23909D0 VA: 0x1823923D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2392460 Offset: 0x2390A60 VA: 0x182392460 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2392380 Offset: 0x2390980 VA: 0x182392380
	private void Destroy() { }

	// RVA: 0x2392500 Offset: 0x2390B00 VA: 0x182392500
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2392530 Offset: 0x2390B30 VA: 0x182392530
	private static void Internal_Destroy(IntPtr ptr) { }
}

// Namespace: UnityEngine
internal class RuntimeTextSettings : TextSettings // TypeDefIndex: 12788
{
	// Fields
	private static RuntimeTextSettings s_DefaultTextSettings; // 0x0
	private static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal; // 0x8

	// Properties
	internal static RuntimeTextSettings defaultTextSettings { get; }

	// Methods

	// RVA: 0x23926A0 Offset: 0x2390CA0 VA: 0x1823926A0
	internal static RuntimeTextSettings get_defaultTextSettings() { }

	// RVA: 0x23925B0 Offset: 0x2390BB0 VA: 0x1823925B0 Slot: 6
	internal override Shader GetFontShader() { }

	// RVA: 0x23925F0 Offset: 0x2390BF0 VA: 0x1823925F0 Slot: 4
	internal override List<FontAsset> GetStaticFallbackOSFontAsset() { }

	// RVA: 0x2392630 Offset: 0x2390C30 VA: 0x182392630 Slot: 5
	internal override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	// RVA: 0x2392690 Offset: 0x2390C90 VA: 0x182392690
	public void .ctor() { }
}

// Namespace: UnityEngine
internal class ScrollViewState // TypeDefIndex: 12789
{
	// Fields
	public Rect position; // 0x10
	public Rect visibleRect; // 0x20
	public Rect viewRect; // 0x30
	public Vector2 scrollPosition; // 0x40
	public bool apply; // 0x48
	public bool isDuringTouchScroll; // 0x49
	public Vector2 touchScrollStartMousePosition; // 0x4C
	public Vector2 touchScrollStartPosition; // 0x54
	public Vector2 velocity; // 0x5C
	public float previousTimeSinceStartup; // 0x64

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine
internal class SliderState // TypeDefIndex: 12790
{
	// Fields
	public float dragStartPos; // 0x10
	public float dragStartValue; // 0x14
	public bool isDragging; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine
internal struct SliderHandler // TypeDefIndex: 12791
{
	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x2394180 Offset: 0x2392780 VA: 0x182394180
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x23928B0 Offset: 0x2390EB0 VA: 0x1823928B0
	public float Handle() { }

	// RVA: 0x2392C00 Offset: 0x2391200 VA: 0x182392C00
	private float OnMouseDown() { }

	// RVA: 0x23930C0 Offset: 0x23916C0 VA: 0x1823930C0
	private float OnMouseDrag() { }

	// RVA: 0x2393200 Offset: 0x2391800 VA: 0x182393200
	private float OnMouseUp() { }

	// RVA: 0x2393290 Offset: 0x2391890 VA: 0x182393290
	private float OnRepaint() { }

	// RVA: 0x23927C0 Offset: 0x2390DC0 VA: 0x1823927C0
	private EventType CurrentEventType() { }

	// RVA: 0x2392800 Offset: 0x2390E00 VA: 0x182392800
	private int CurrentScrollTroughSide() { }

	// RVA: 0x2392B30 Offset: 0x2391130 VA: 0x182392B30
	private bool IsEmptySlider() { }

	// RVA: 0x2393AD0 Offset: 0x23920D0 VA: 0x182393AD0
	private bool SupportsPageMovements() { }

	// RVA: 0x2393830 Offset: 0x2391E30 VA: 0x182393830
	private float PageMovementValue() { }

	// RVA: 0x23938E0 Offset: 0x2391EE0 VA: 0x1823938E0
	private float PageUpMovementBound() { }

	// RVA: 0x23927F0 Offset: 0x2390DF0 VA: 0x1823927F0
	private Event CurrentEvent() { }

	// RVA: 0x2393DA0 Offset: 0x23923A0 VA: 0x182393DA0
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x2392760 Offset: 0x2390D60 VA: 0x182392760
	private float Clamp(float value) { }

	// RVA: 0x2393C80 Offset: 0x2392280 VA: 0x182393C80
	private Rect ThumbSelectionRect() { }

	// RVA: 0x2393A70 Offset: 0x2392070 VA: 0x182393A70
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x2393980 Offset: 0x2391F80 VA: 0x182393980
	private SliderState SliderState() { }

	// RVA: 0x2393B30 Offset: 0x2392130 VA: 0x182393B30
	private Rect ThumbExtRect() { }

	// RVA: 0x2393C30 Offset: 0x2392230 VA: 0x182393C30
	private Rect ThumbRect() { }

	// RVA: 0x2393FB0 Offset: 0x23925B0 VA: 0x182393FB0
	private Rect VerticalThumbRect() { }

	// RVA: 0x2392960 Offset: 0x2390F60 VA: 0x182392960
	private Rect HorizontalThumbRect() { }

	// RVA: 0x2392790 Offset: 0x2390D90 VA: 0x182392790
	private float ClampedCurrentValue() { }

	// RVA: 0x2392B80 Offset: 0x2391180 VA: 0x182392B80
	private float MousePosition() { }

	// RVA: 0x2393EE0 Offset: 0x23924E0 VA: 0x182393EE0
	private float ValuesPerPixel() { }

	// RVA: 0x2393CD0 Offset: 0x23922D0 VA: 0x182393CD0
	private float ThumbSize() { }

	// RVA: 0x2392B50 Offset: 0x2391150 VA: 0x182392B50
	private float MaxValue() { }

	// RVA: 0x2392B70 Offset: 0x2391170 VA: 0x182392B70
	private float MinValue() { }
}

// Namespace: UnityEngine
internal enum TextEditOp // TypeDefIndex: 12792
{
	// Fields
	public int value__; // 0x0
	public const TextEditOp MoveLeft = 0;
	public const TextEditOp MoveRight = 1;
	public const TextEditOp MoveUp = 2;
	public const TextEditOp MoveDown = 3;
	public const TextEditOp MoveLineStart = 4;
	public const TextEditOp MoveLineEnd = 5;
	public const TextEditOp MoveTextStart = 6;
	public const TextEditOp MoveTextEnd = 7;
	public const TextEditOp MovePageUp = 8;
	public const TextEditOp MovePageDown = 9;
	public const TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditOp MoveWordLeft = 12;
	public const TextEditOp MoveWordRight = 13;
	public const TextEditOp MoveParagraphForward = 14;
	public const TextEditOp MoveParagraphBackward = 15;
	public const TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditOp Delete = 18;
	public const TextEditOp Backspace = 19;
	public const TextEditOp DeleteWordBack = 20;
	public const TextEditOp DeleteWordForward = 21;
	public const TextEditOp DeleteLineBack = 22;
	public const TextEditOp Cut = 23;
	public const TextEditOp Paste = 24;
	public const TextEditOp ScrollStart = 25;
	public const TextEditOp ScrollEnd = 26;
	public const TextEditOp ScrollPageUp = 27;
	public const TextEditOp ScrollPageDown = 28;
}

// Namespace: UnityEngine
internal enum TextSelectOp // TypeDefIndex: 12793
{
	// Fields
	public int value__; // 0x0
	public const TextSelectOp SelectLeft = 0;
	public const TextSelectOp SelectRight = 1;
	public const TextSelectOp SelectUp = 2;
	public const TextSelectOp SelectDown = 3;
	public const TextSelectOp SelectTextStart = 4;
	public const TextSelectOp SelectTextEnd = 5;
	public const TextSelectOp SelectPageUp = 6;
	public const TextSelectOp SelectPageDown = 7;
	public const TextSelectOp ExpandSelectGraphicalLineStart = 8;
	public const TextSelectOp ExpandSelectGraphicalLineEnd = 9;
	public const TextSelectOp SelectGraphicalLineStart = 10;
	public const TextSelectOp SelectGraphicalLineEnd = 11;
	public const TextSelectOp SelectWordLeft = 12;
	public const TextSelectOp SelectWordRight = 13;
	public const TextSelectOp SelectToEndOfPreviousWord = 14;
	public const TextSelectOp SelectToStartOfNextWord = 15;
	public const TextSelectOp SelectParagraphBackward = 16;
	public const TextSelectOp SelectParagraphForward = 17;
	public const TextSelectOp Copy = 18;
	public const TextSelectOp SelectAll = 19;
	public const TextSelectOp SelectNone = 20;
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class TextEditingUtilities // TypeDefIndex: 12794
{
	// Fields
	private TextSelectingUtilities m_TextSelectingUtility; // 0x10
	internal TextHandle textHandle; // 0x18
	private int m_CursorIndexSavedState; // 0x20
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal bool isCompositionActive; // 0x24
	private bool m_UpdateImeWindowPosition; // 0x25
	internal Action OnTextChanged; // 0x28
	public bool multiline; // 0x30
	private string m_Text; // 0x38
	private static Dictionary<Event, TextEditOp> s_KeyEditOps; // 0x0
	private char m_HighSurrogate; // 0x40

	// Properties
	private bool hasSelection { get; }
	internal bool revealCursor { set; }
	internal int stringCursorIndex { get; }
	private int cursorIndex { get; set; }
	private int cursorIndexNoValidation { get; set; }
	private int selectIndexNoValidation { set; }
	internal int stringSelectIndex { get; }
	private int selectIndex { get; set; }
	public string text { get; set; }

	// Methods

	// RVA: 0x23968D0 Offset: 0x2394ED0 VA: 0x1823968D0
	private bool get_hasSelection() { }

	// RVA: 0x2396AD0 Offset: 0x23950D0 VA: 0x182396AD0
	internal void set_revealCursor(bool value) { }

	// RVA: 0x23969D0 Offset: 0x2394FD0 VA: 0x1823969D0
	internal int get_stringCursorIndex() { }

	// RVA: 0x2396870 Offset: 0x2394E70 VA: 0x182396870
	private int get_cursorIndex() { }

	// RVA: 0x2396A90 Offset: 0x2395090 VA: 0x182396A90
	private void set_cursorIndex(int value) { }

	// RVA: 0x2396850 Offset: 0x2394E50 VA: 0x182396850
	private int get_cursorIndexNoValidation() { }

	// RVA: 0x2396A90 Offset: 0x2395090 VA: 0x182396A90
	private void set_cursorIndexNoValidation(int value) { }

	// RVA: 0x2396B10 Offset: 0x2395110 VA: 0x182396B10
	private void set_selectIndexNoValidation(int value) { }

	// RVA: 0x2396A30 Offset: 0x2395030 VA: 0x182396A30
	internal int get_stringSelectIndex() { }

	// RVA: 0x2396970 Offset: 0x2394F70 VA: 0x182396970
	private int get_selectIndex() { }

	// RVA: 0x2396B10 Offset: 0x2395110 VA: 0x182396B10
	private void set_selectIndex(int value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_text() { }

	// RVA: 0x2396B50 Offset: 0x2395150 VA: 0x182396B50
	public void set_text(string value) { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void SetTextWithoutNotify(string value) { }

	// RVA: 0x23967D0 Offset: 0x2394DD0 VA: 0x1823967D0
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x2396740 Offset: 0x2394D40 VA: 0x182396740
	public bool UpdateImeState() { }

	// RVA: 0x23966C0 Offset: 0x2394CC0 VA: 0x1823966C0
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x23965E0 Offset: 0x2394BE0 VA: 0x1823965E0
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x23950A0 Offset: 0x23936A0 VA: 0x1823950A0
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x2394FD0 Offset: 0x23935D0 VA: 0x182394FD0
	public void EnableCursorPreviewState() { }

	// RVA: 0x2396560 Offset: 0x2394B60 VA: 0x182396560
	public void RestoreCursorState() { }

	[VisibleToOtherModules]
	// RVA: 0x2395190 Offset: 0x2393790 VA: 0x182395190
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x2395C70 Offset: 0x2394270 VA: 0x182395C70
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x2395A50 Offset: 0x2394050 VA: 0x182395A50
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x23952B0 Offset: 0x23938B0 VA: 0x1823952B0
	private void InitKeyActions() { }

	// RVA: 0x23944F0 Offset: 0x2392AF0 VA: 0x1823944F0
	public bool DeleteLineBack() { }

	// RVA: 0x2394AA0 Offset: 0x23930A0 VA: 0x182394AA0
	public bool DeleteWordBack() { }

	// RVA: 0x2394C70 Offset: 0x2393270 VA: 0x182394C70
	public bool DeleteWordForward() { }

	// RVA: 0x2394E10 Offset: 0x2393410 VA: 0x182394E10
	public bool Delete() { }

	// RVA: 0x2394200 Offset: 0x2392800 VA: 0x182394200
	public bool Backspace() { }

	// RVA: 0x2394700 Offset: 0x2392D00 VA: 0x182394700
	public bool DeleteSelection() { }

	// RVA: 0x2396380 Offset: 0x2394980 VA: 0x182396380
	public void ReplaceSelection(string replace) { }

	// RVA: 0x2395900 Offset: 0x2393F00 VA: 0x182395900
	public bool Insert(char c) { }

	// RVA: 0x2394460 Offset: 0x2392A60 VA: 0x182394460
	public bool CanPaste() { }

	// RVA: 0x23944C0 Offset: 0x2392AC0 VA: 0x1823944C0
	public bool Cut() { }

	// RVA: 0x2395B40 Offset: 0x2394140 VA: 0x182395B40
	public bool Paste() { }

	// RVA: 0x23962F0 Offset: 0x23948F0 VA: 0x1823962F0
	private static string ReplaceNewlinesWithSpaces(string value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2395AE0 Offset: 0x23940E0 VA: 0x182395AE0
	internal void OnBlur(bool removeSelection = True) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x23966D0 Offset: 0x2394CD0 VA: 0x1823966D0
	internal bool TouchScreenKeyboardShouldBeUsed() { }
}

// Namespace: UnityEngine
public class TextEditor // TypeDefIndex: 12796
{
	// Fields
	private readonly GUIContent m_Content; // 0x10
	private TextSelectingUtilities m_TextSelecting; // 0x18
	internal TextEditingUtilities m_TextEditing; // 0x20
	internal IMGUITextHandle m_TextHandle; // 0x28
	public TouchScreenKeyboard keyboardOnScreen; // 0x30
	public int controlID; // 0x38
	public GUIStyle style; // 0x40
	[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", True)]
	public bool hasHorizontalCursorPos; // 0x48
	public bool isPasswordField; // 0x49
	public Vector2 scrollOffset; // 0x4C
	private string m_TextWithWhitespace; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Rect <position>k__BackingField; // 0x60
	public Vector2 graphicalCursorPos; // 0x70
	private Vector2 lastCursorPos; // 0x78
	private Vector2 previousContentSize; // 0x80

	// Properties
	public bool showCursor { get; }
	public string text { get; set; }
	internal string textWithWhitespace { get; set; }
	public Rect position { get; }

	// Methods

	// RVA: 0x23978F0 Offset: 0x2395EF0 VA: 0x1823978F0
	public bool get_showCursor() { }

	// RVA: 0x1CE92C0 Offset: 0x1CE78C0 VA: 0x181CE92C0
	public string get_text() { }

	// RVA: 0x2397A00 Offset: 0x2396000 VA: 0x182397A00
	public void set_text(string value) { }

	// RVA: 0x2397910 Offset: 0x2395F10 VA: 0x182397910
	internal string get_textWithWhitespace() { }

	// RVA: 0x2397980 Offset: 0x2395F80 VA: 0x182397980
	internal void set_textWithWhitespace(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B7430 Offset: 0x15B5A30 VA: 0x1815B7430
	public Rect get_position() { }

	[RequiredByNativeCode]
	// RVA: 0x2397350 Offset: 0x2395950 VA: 0x182397350
	public void .ctor() { }

	// RVA: 0x2396CC0 Offset: 0x23952C0 VA: 0x182396CC0
	private void OnTextChangedHandle() { }

	// RVA: 0x2396BC0 Offset: 0x23951C0 VA: 0x182396BC0
	private void OnContentTextChangedHandle() { }

	// RVA: 0x23971A0 Offset: 0x23957A0 VA: 0x1823971A0
	internal void UpdateTextHandle() { }

	[VisibleToOtherModules]
	// RVA: 0x2396D10 Offset: 0x2395310 VA: 0x182396D10
	internal void UpdateScrollOffset() { }

	// RVA: 0x2396CB0 Offset: 0x23952B0 VA: 0x182396CB0 Slot: 4
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x2396CB0 Offset: 0x23952B0 VA: 0x182396CB0 Slot: 5
	internal virtual void OnSelectIndexChange() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class TextSelectingUtilities // TypeDefIndex: 12799
{
	// Fields
	public TextEditor.DblClickSnapping dblClickSnap; // 0x10
	public int iAltCursorPos; // 0x14
	public bool hasHorizontalCursorPos; // 0x18
	private bool m_bJustSelected; // 0x19
	private bool m_MouseDragSelectsWholeWords; // 0x1A
	private int m_DblClickInitPos; // 0x1C
	public TextHandle textHandle; // 0x20
	private const int kMoveDownHeight = 5;
	private const char kNewLineChar = '\xa';
	private bool m_RevealCursor; // 0x28
	private int m_CursorIndex; // 0x2C
	internal int m_SelectIndex; // 0x30
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps; // 0x0
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal Action OnCursorIndexChange; // 0x38
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal Action OnSelectIndexChange; // 0x40
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal Action OnRevealCursorChange; // 0x48

	// Properties
	public bool hasSelection { get; }
	public bool revealCursor { get; set; }
	private int m_CharacterCount { get; }
	private int characterCount { get; }
	private TextElementInfo[] m_TextElementInfos { get; }
	public int cursorIndex { get; set; }
	internal int cursorIndexNoValidation { get; set; }
	public int selectIndex { get; set; }
	internal int selectIndexNoValidation { set; }
	public string selectedText { get; }

	// Methods

	// RVA: 0x239C7C0 Offset: 0x239ADC0 VA: 0x18239C7C0
	public bool get_hasSelection() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_revealCursor() { }

	// RVA: 0x239CB90 Offset: 0x239B190 VA: 0x18239CB90
	public void set_revealCursor(bool value) { }

	// RVA: 0x239C850 Offset: 0x239AE50 VA: 0x18239C850
	private int get_m_CharacterCount() { }

	// RVA: 0x239C680 Offset: 0x239AC80 VA: 0x18239C680
	private int get_characterCount() { }

	// RVA: 0x239C880 Offset: 0x239AE80 VA: 0x18239C880
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x239C770 Offset: 0x239AD70 VA: 0x18239C770
	public int get_cursorIndex() { }

	// RVA: 0x239CB60 Offset: 0x239B160 VA: 0x18239CB60
	public void set_cursorIndex(int value) { }

	// RVA: 0x239C760 Offset: 0x239AD60 VA: 0x18239C760
	internal int get_cursorIndexNoValidation() { }

	// RVA: 0x239CB60 Offset: 0x239B160 VA: 0x18239CB60
	internal void set_cursorIndexNoValidation(int value) { }

	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x239C8B0 Offset: 0x239AEB0 VA: 0x18239C8B0
	public int get_selectIndex() { }

	// RVA: 0x239CBC0 Offset: 0x239B1C0 VA: 0x18239CBC0
	public void set_selectIndex(int value) { }

	// RVA: 0x239CBC0 Offset: 0x239B1C0 VA: 0x18239CBC0
	internal void set_selectIndexNoValidation(int value) { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x239C900 Offset: 0x239AF00 VA: 0x18239C900
	public string get_selectedText() { }

	// RVA: 0x239C630 Offset: 0x239AC30 VA: 0x18239C630
	public void .ctor(TextHandle textHandle) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x2398780 Offset: 0x2396D80 VA: 0x182398780
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x239A6C0 Offset: 0x2398CC0 VA: 0x18239A6C0
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x2398D40 Offset: 0x2397340 VA: 0x182398D40
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x23988D0 Offset: 0x2396ED0 VA: 0x1823988D0
	private void InitKeyActions() { }

	// RVA: 0x2397C70 Offset: 0x2396270 VA: 0x182397C70
	public void ClearCursorPos() { }

	// RVA: 0x239A630 Offset: 0x2398C30 VA: 0x18239A630
	public void OnFocus(bool selectAll = True) { }

	// RVA: 0x239ABD0 Offset: 0x23991D0 VA: 0x18239ABD0
	public void SelectAll() { }

	// RVA: 0x239B470 Offset: 0x2399A70 VA: 0x18239B470
	public void SelectNone() { }

	// RVA: 0x239B2E0 Offset: 0x23998E0 VA: 0x18239B2E0
	public void SelectLeft() { }

	// RVA: 0x239B930 Offset: 0x2399F30 VA: 0x18239B930
	public void SelectRight() { }

	// RVA: 0x239C0D0 Offset: 0x239A6D0 VA: 0x18239C0D0
	public void SelectUp() { }

	// RVA: 0x239B160 Offset: 0x2399760 VA: 0x18239B160
	public void SelectDown() { }

	// RVA: 0x239BAC0 Offset: 0x239A0C0 VA: 0x18239BAC0
	public void SelectTextEnd() { }

	// RVA: 0x239BB00 Offset: 0x239A100 VA: 0x18239BB00
	public void SelectTextStart() { }

	// RVA: 0x239C050 Offset: 0x239A650 VA: 0x18239C050
	public void SelectToStartOfNextWord() { }

	// RVA: 0x239BB30 Offset: 0x239A130 VA: 0x18239BB30
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x239C3C0 Offset: 0x239A9C0 VA: 0x18239C3C0
	public void SelectWordRight() { }

	// RVA: 0x239C150 Offset: 0x239A750 VA: 0x18239C150
	public void SelectWordLeft() { }

	// RVA: 0x239B260 Offset: 0x2399860 VA: 0x18239B260
	public void SelectGraphicalLineStart() { }

	// RVA: 0x239B1E0 Offset: 0x23997E0 VA: 0x18239B1E0
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x239B710 Offset: 0x2399D10 VA: 0x18239B710
	public void SelectParagraphForward() { }

	// RVA: 0x239B4E0 Offset: 0x2399AE0 VA: 0x18239B4E0
	public void SelectParagraphBackward() { }

	// RVA: 0x239ADC0 Offset: 0x23993C0 VA: 0x18239ADC0
	public void SelectCurrentWord() { }

	// RVA: 0x239AC30 Offset: 0x2399230 VA: 0x18239AC30
	public void SelectCurrentParagraph() { }

	// RVA: 0x2399B40 Offset: 0x2398140 VA: 0x182399B40
	public void MoveRight() { }

	// RVA: 0x2399280 Offset: 0x2397880 VA: 0x182399280
	public void MoveLeft() { }

	// RVA: 0x239A080 Offset: 0x2398680 VA: 0x18239A080
	public void MoveUp() { }

	// RVA: 0x2398E70 Offset: 0x2397470 VA: 0x182398E70
	public void MoveDown() { }

	// RVA: 0x2399610 Offset: 0x2397C10 VA: 0x182399610
	public void MoveLineStart() { }

	// RVA: 0x2399470 Offset: 0x2397A70 VA: 0x182399470
	public void MoveLineEnd() { }

	// RVA: 0x2399160 Offset: 0x2397760 VA: 0x182399160
	public void MoveGraphicalLineStart() { }

	// RVA: 0x2399040 Offset: 0x2397640 VA: 0x182399040
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x2399DA0 Offset: 0x23983A0 VA: 0x182399DA0
	public void MoveTextStart() { }

	// RVA: 0x2399D40 Offset: 0x2398340 VA: 0x182399D40
	public void MoveTextEnd() { }

	// RVA: 0x2399970 Offset: 0x2397F70 VA: 0x182399970
	public void MoveParagraphForward() { }

	// RVA: 0x23997A0 Offset: 0x2397DA0 VA: 0x1823997A0
	public void MoveParagraphBackward() { }

	// RVA: 0x239A450 Offset: 0x2398A50 VA: 0x18239A450
	public void MoveWordRight() { }

	// RVA: 0x2399F40 Offset: 0x2398540 VA: 0x182399F40
	public void MoveToStartOfNextWord() { }

	// RVA: 0x2399E00 Offset: 0x2398400 VA: 0x182399E00
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x239A250 Offset: 0x2398850 VA: 0x18239A250
	public void MoveWordLeft() { }

	// RVA: 0x2397F00 Offset: 0x2396500 VA: 0x182397F00
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x2397D70 Offset: 0x2396370 VA: 0x182397D70
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x2398DD0 Offset: 0x23973D0 VA: 0x182398DD0
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x239BBB0 Offset: 0x239A1B0 VA: 0x18239BBB0
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x2398290 Offset: 0x2396890 VA: 0x182398290
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x2398320 Offset: 0x2396920 VA: 0x182398320
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x23983C0 Offset: 0x23969C0 VA: 0x1823983C0
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x23981C0 Offset: 0x23967C0 VA: 0x1823981C0
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x2398090 Offset: 0x2396690 VA: 0x182398090
	private int FindEndOfClassification(int p, TextSelectingUtilities.Direction dir) { }

	// RVA: 0x2397B00 Offset: 0x2396100 VA: 0x182397B00
	private int ClampTextIndex(int index) { }

	// RVA: 0x2398890 Offset: 0x2396E90 VA: 0x182398890
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x239ABC0 Offset: 0x23991C0 VA: 0x18239ABC0
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x239A610 Offset: 0x2398C10 VA: 0x18239A610
	public int NextCodePointIndex(int index) { }

	// RVA: 0x23986C0 Offset: 0x2396CC0 VA: 0x1823986C0
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x23985F0 Offset: 0x2396BF0 VA: 0x1823985F0
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x2397C80 Offset: 0x2396280 VA: 0x182397C80
	public void Copy() { }

	// RVA: 0x2397B30 Offset: 0x2396130 VA: 0x182397B30
	private TextSelectingUtilities.CharacterType ClassifyChar(int index) { }
}

// Namespace: UnityEngine
[Usage(384, AllowMultiple = True)]
public class AssetReferenceUIRestriction : Attribute // TypeDefIndex: 13075
{
	// Methods

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	public virtual bool ValidateAsset(string path) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(384, AllowMultiple = False)]
public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction // TypeDefIndex: 13076
{
	// Fields
	public string[] m_AllowedLabels; // 0x10
	public string m_CachedToString; // 0x18

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string[] allowedLabels) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	public override bool ValidateAsset(string path) { }

	// RVA: 0x1EAF9F0 Offset: 0x1EADFF0 VA: 0x181EAF9F0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 13576
{
	// Methods

	// RVA: 0x3B5700 Offset: 0x3B3D00 VA: 0x1803B5700
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x345000 Offset: 0x343600 VA: 0x180345000 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
public sealed class AndroidJavaException : Exception // TypeDefIndex: 13577
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x22DF6A0 Offset: 0x22DDCA0 VA: 0x1822DF6A0
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x22DF720 Offset: 0x22DDD20 VA: 0x1822DF720 Slot: 8
	public override string get_StackTrace() { }
}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef // TypeDefIndex: 13578
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x22E2430 Offset: 0x22E0A30 VA: 0x1822E2430
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x22E23A0 Offset: 0x22E09A0 VA: 0x1822E23A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x12E74F0 Offset: 0x12E5AF0 VA: 0x1812E74F0
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x22E2350 Offset: 0x22E0950 VA: 0x1822E2350
	public void Dispose() { }
}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 13579
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x22E1740 Offset: 0x22DFD40 VA: 0x1822E1740
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x22E1820 Offset: 0x22DFE20 VA: 0x1822E1820
	public void run() { }

	// RVA: 0x22E1690 Offset: 0x22DFC90 VA: 0x1822E1690 Slot: 6
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }
}

// Namespace: UnityEngine
public class AndroidJavaProxy // TypeDefIndex: 13580
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x22E1430 Offset: 0x22DFA30 VA: 0x1822E1430
	public void .ctor(string javaInterface) { }

	// RVA: 0x22E14B0 Offset: 0x22DFAB0 VA: 0x1822E14B0
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x22E0270 Offset: 0x22DE870 VA: 0x1822E0270 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22E03D0 Offset: 0x22DE9D0 VA: 0x1822E03D0 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x22E0D60 Offset: 0x22DF360 VA: 0x1822E0D60 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x22E0F10 Offset: 0x22DF510 VA: 0x1822E0F10 Slot: 6
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x22E14F0 Offset: 0x22DFAF0 VA: 0x1822E14F0 Slot: 7
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x22E1550 Offset: 0x22DFB50 VA: 0x1822E1550 Slot: 8
	public virtual int hashCode() { }

	// RVA: 0x22E1630 Offset: 0x22DFC30 VA: 0x1822E1630 Slot: 9
	public virtual string toString() { }

	// RVA: 0x22E02F0 Offset: 0x22DE8F0 VA: 0x1822E02F0
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x22E0310 Offset: 0x22DE910 VA: 0x1822E0310
	internal IntPtr GetRawProxy() { }

	// RVA: 0x22E12B0 Offset: 0x22DF8B0 VA: 0x1822E12B0
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class AndroidJavaObject : IDisposable // TypeDefIndex: 13581
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x22E00B0 Offset: 0x22DE6B0 VA: 0x1822E00B0
	public void .ctor(string className, object[] args) { }

	// RVA: 0x22DFF00 Offset: 0x22DE500 VA: 0x1822DFF00
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x22DF8B0 Offset: 0x22DDEB0 VA: 0x1822DF8B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x22DF9E0 Offset: 0x22DDFE0 VA: 0x1822DF9E0
	public IntPtr GetRawObject() { }

	// RVA: 0x168F790 Offset: 0x168DD90 VA: 0x18168F790
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67E7D0 Offset: 0x67CDD0 VA: 0x18067E7D0
	|-AndroidJavaObject.Call<bool>
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0x67E8B0 Offset: 0x67CEB0 VA: 0x18067E8B0
	|-AndroidJavaObject.Call<char>
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0x67E990 Offset: 0x67CF90 VA: 0x18067E990
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0x67EA70 Offset: 0x67D070 VA: 0x18067EA70
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x67EB10 Offset: 0x67D110 VA: 0x18067EB10
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x67EBF0 Offset: 0x67D1F0 VA: 0x18067EBF0
	|-AndroidJavaObject.Call<object>
	|
	|-RVA: 0x67EC90 Offset: 0x67D290 VA: 0x18067EC90
	|-AndroidJavaObject.Call<float>
	|
	|-RVA: 0x67E570 Offset: 0x67CB70 VA: 0x18067E570
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67E690 Offset: 0x67CC90 VA: 0x18067E690
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0x67E730 Offset: 0x67CD30 VA: 0x18067E730
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0x67E570 Offset: 0x67CB70 VA: 0x18067E570
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22DF840 Offset: 0x22DDE40 VA: 0x1822DF840
	protected void DebugPrint(string msg) { }

	// RVA: 0x22DFA00 Offset: 0x22DE000 VA: 0x1822DFA00
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x22DFBC0 Offset: 0x22DE1C0 VA: 0x1822DFBC0
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22DF910 Offset: 0x22DDF10 VA: 0x1822DF910 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6824F0 Offset: 0x680AF0 VA: 0x1806824F0
	|-AndroidJavaObject._Call<bool>
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x683540 Offset: 0x681B40 VA: 0x180683540
	|-AndroidJavaObject._Call<char>
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x685540 Offset: 0x683B40 VA: 0x180685540
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x6875F0 Offset: 0x685BF0 VA: 0x1806875F0
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x688600 Offset: 0x686C00 VA: 0x180688600
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x6886D0 Offset: 0x686CD0 VA: 0x1806886D0
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x689590 Offset: 0x687B90 VA: 0x180689590
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x686610 Offset: 0x684C10 VA: 0x180686610
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6825C0 Offset: 0x680BC0 VA: 0x1806825C0
	|-AndroidJavaObject._Call<bool>
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x683610 Offset: 0x681C10 VA: 0x180683610
	|-AndroidJavaObject._Call<char>
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x684590 Offset: 0x682B90 VA: 0x180684590
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x686760 Offset: 0x684D60 VA: 0x180686760
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x687680 Offset: 0x685C80 VA: 0x180687680
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x688760 Offset: 0x686D60 VA: 0x180688760
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x689660 Offset: 0x687C60 VA: 0x180689660
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x685610 Offset: 0x683C10 VA: 0x180685610
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6815A0 Offset: 0x67FBA0 VA: 0x1806815A0
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x681630 Offset: 0x67FC30 VA: 0x180681630
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x6805C0 Offset: 0x67EBC0 VA: 0x1806805C0
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x680710 Offset: 0x67ED10 VA: 0x180680710
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x6816C0 Offset: 0x67FCC0 VA: 0x1806816C0
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x67F5C0 Offset: 0x67DBC0 VA: 0x18067F5C0
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22DF750 Offset: 0x22DDD50 VA: 0x1822DF750
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: -1 Offset: -1
	internal static ReturnType FromJavaArray<ReturnType>(IntPtr jobject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67ED70 Offset: 0x67D370 VA: 0x18067ED70
	|-AndroidJavaObject.FromJavaArray<bool>
	|-AndroidJavaObject.FromJavaArray<sbyte>
	|
	|-RVA: 0x67EE70 Offset: 0x67D470 VA: 0x18067EE70
	|-AndroidJavaObject.FromJavaArray<char>
	|-AndroidJavaObject.FromJavaArray<short>
	|
	|-RVA: 0x67EF70 Offset: 0x67D570 VA: 0x18067EF70
	|-AndroidJavaObject.FromJavaArray<double>
	|
	|-RVA: 0x67F230 Offset: 0x67D830 VA: 0x18067F230
	|-AndroidJavaObject.FromJavaArray<int>
	|
	|-RVA: 0x67F330 Offset: 0x67D930 VA: 0x18067F330
	|-AndroidJavaObject.FromJavaArray<long>
	|
	|-RVA: 0x67F430 Offset: 0x67DA30 VA: 0x18067F430
	|-AndroidJavaObject.FromJavaArray<object>
	|
	|-RVA: 0x67F4C0 Offset: 0x67DAC0 VA: 0x18067F4C0
	|-AndroidJavaObject.FromJavaArray<float>
	|
	|-RVA: 0x67F070 Offset: 0x67D670 VA: 0x18067F070
	|-AndroidJavaObject.FromJavaArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22DF9E0 Offset: 0x22DDFE0 VA: 0x1822DF9E0
	protected IntPtr _GetRawObject() { }

	// RVA: 0x168F790 Offset: 0x168DD90 VA: 0x18168F790
	protected IntPtr _GetRawClass() { }
}

// Namespace: UnityEngine
public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 13582
{
	// Methods

	// RVA: 0x22DF510 Offset: 0x22DDB10 VA: 0x1822DF510
	public void .ctor(string className) { }

	// RVA: 0x22DF280 Offset: 0x22DD880 VA: 0x1822DF280
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x22DF410 Offset: 0x22DDA10 VA: 0x1822DF410
	internal void .ctor(IntPtr jclass) { }
}

// Namespace: UnityEngine
internal class AndroidReflection // TypeDefIndex: 13583
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x1633590 Offset: 0x1631B90 VA: 0x181633590
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x21F2CA0 Offset: 0x21F12A0 VA: 0x1821F2CA0
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x22E1D00 Offset: 0x22E0300 VA: 0x1822E1D00
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x22E1A00 Offset: 0x22E0000 VA: 0x1822E1A00
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x22E1850 Offset: 0x22DFE50 VA: 0x1822E1850
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x22E1AE0 Offset: 0x22E00E0 VA: 0x1822E1AE0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x22E1DE0 Offset: 0x22E03E0 VA: 0x1822E1DE0
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x22E1F20 Offset: 0x22E0520 VA: 0x1822E1F20
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x22E2080 Offset: 0x22E0680 VA: 0x1822E2080
	private static void .cctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
internal sealed class _AndroidJNIHelper // TypeDefIndex: 13584
{
	// Fields
	private static int FRAME_SIZE_FOR_ARRAYS; // 0x0

	// Methods

	// RVA: 0x22E4990 Offset: 0x22E2F90 VA: 0x1822E4990
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x22E4B40 Offset: 0x22E3140 VA: 0x1822E4B40
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCode]
	// RVA: 0x22E61E0 Offset: 0x22E47E0 VA: 0x1822E61E0
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x22E4110 Offset: 0x22E2710 VA: 0x1822E4110
	public static void CreateJNIArgArray(object[] args, Span<jvalue> ret) { }

	// RVA: 0x22E6290 Offset: 0x22E4890 VA: 0x1822E6290
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x22E6990 Offset: 0x22E4F90 VA: 0x1822E6990
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x22E2560 Offset: 0x22E0B60 VA: 0x1822E2560
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x22E4C50 Offset: 0x22E3250 VA: 0x1822E4C50
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x22E3460 Offset: 0x22E1A60 VA: 0x1822E3460
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x819040 Offset: 0x817640 VA: 0x180819040
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x819C50 Offset: 0x818250 VA: 0x180819C50
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x81A860 Offset: 0x818E60 VA: 0x18081A860
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x81B480 Offset: 0x819A80 VA: 0x18081B480
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x81C090 Offset: 0x81A690 VA: 0x18081C090
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x81CCA0 Offset: 0x81B2A0 VA: 0x18081CCA0
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x82E310 Offset: 0x82C910 VA: 0x18082E310
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x82D8B0 Offset: 0x82BEB0 VA: 0x18082D8B0
	|-_AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22E4F50 Offset: 0x22E3550 VA: 0x1822E4F50
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82EF30 Offset: 0x82D530 VA: 0x18082EF30
	|-_AndroidJNIHelper.GetMethodID<bool>
	|-_AndroidJNIHelper.GetMethodID<char>
	|-_AndroidJNIHelper.GetMethodID<double>
	|-_AndroidJNIHelper.GetMethodID<short>
	|-_AndroidJNIHelper.GetMethodID<int>
	|-_AndroidJNIHelper.GetMethodID<long>
	|-_AndroidJNIHelper.GetMethodID<object>
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|-_AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x82EFE0 Offset: 0x82D5E0 VA: 0x18082EFE0
	|-_AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22E4DB0 Offset: 0x22E33B0 VA: 0x1822E4DB0
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x22E5140 Offset: 0x22E3740 VA: 0x1822E5140
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x22E5110 Offset: 0x22E3710 VA: 0x1822E5110
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x22E5450 Offset: 0x22E3A50 VA: 0x1822E5450
	public static string GetSignature(object obj) { }

	// RVA: 0x22E5310 Offset: 0x22E3910 VA: 0x1822E5310
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82F090 Offset: 0x82D690 VA: 0x18082F090
	|-_AndroidJNIHelper.GetSignature<bool>
	|-_AndroidJNIHelper.GetSignature<char>
	|-_AndroidJNIHelper.GetSignature<double>
	|-_AndroidJNIHelper.GetSignature<short>
	|-_AndroidJNIHelper.GetSignature<int>
	|-_AndroidJNIHelper.GetSignature<long>
	|-_AndroidJNIHelper.GetSignature<object>
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|-_AndroidJNIHelper.GetSignature<float>
	|-_AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22E7240 Offset: 0x22E5840 VA: 0x1822E7240
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeType(1, "ScriptingJvalue")]
public struct jvalue // TypeDefIndex: 13585
{
	// Fields
	public bool z; // 0x0
	public sbyte b; // 0x0
	public char c; // 0x0
	public short s; // 0x0
	public int i; // 0x0
	public long j; // 0x0
	public float f; // 0x0
	public double d; // 0x0
	public IntPtr l; // 0x0
}

// Namespace: UnityEngine
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[UsedByNativeCode]
[NativeConditional("PLATFORM_ANDROID")]
public static class AndroidJNIHelper // TypeDefIndex: 13586
{
	// Methods

	// RVA: 0x22D9830 Offset: 0x22D7E30 VA: 0x1822D9830
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x22D9890 Offset: 0x22D7E90 VA: 0x1822D9890
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x22D9370 Offset: 0x22D7970 VA: 0x1822D9370
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x22D9120 Offset: 0x22D7720 VA: 0x1822D9120
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x22D8FE0 Offset: 0x22D75E0 VA: 0x1822D8FE0
	public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x22D94B0 Offset: 0x22D7AB0 VA: 0x1822D94B0
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x22D9640 Offset: 0x22D7C40 VA: 0x1822D9640
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67E050 Offset: 0x67C650 VA: 0x18067E050
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x67E0B0 Offset: 0x67C6B0 VA: 0x18067E0B0
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x67E110 Offset: 0x67C710 VA: 0x18067E110
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x67E2B0 Offset: 0x67C8B0 VA: 0x18067E2B0
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x67E310 Offset: 0x67C910 VA: 0x18067E310
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x67E370 Offset: 0x67C970 VA: 0x18067E370
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x67E3D0 Offset: 0x67C9D0 VA: 0x18067E3D0
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x67E170 Offset: 0x67C770 VA: 0x18067E170
	|-AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67E430 Offset: 0x67CA30 VA: 0x18067E430
	|-AndroidJNIHelper.GetMethodID<bool>
	|-AndroidJNIHelper.GetMethodID<char>
	|-AndroidJNIHelper.GetMethodID<double>
	|-AndroidJNIHelper.GetMethodID<short>
	|-AndroidJNIHelper.GetMethodID<int>
	|-AndroidJNIHelper.GetMethodID<long>
	|-AndroidJNIHelper.GetMethodID<object>
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|-AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x67E4D0 Offset: 0x67CAD0 VA: 0x18067E4D0
	|-AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22D8E90 Offset: 0x22D7490 VA: 0x1822D8E90
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x22D8DD0 Offset: 0x22D73D0 VA: 0x1822D8DD0
	public static IntPtr Box(int value) { }

	// RVA: 0x22D8E30 Offset: 0x22D7430 VA: 0x1822D8E30
	public static IntPtr Box(bool value) { }
}

// Namespace: UnityEngine
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
public static class AndroidJNI // TypeDefIndex: 13588
{
	// Methods

	[ThreadSafe]
	// RVA: 0x22DEA50 Offset: 0x22DD050 VA: 0x1822DEA50
	private static void ReleaseStringChars(AndroidJNI.JStringBinding str) { }

	[ThreadSafe]
	// RVA: 0x22DD680 Offset: 0x22DBC80 VA: 0x1822DD680
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	// RVA: 0x22DDBA0 Offset: 0x22DC1A0 VA: 0x1822DDBA0
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	// RVA: 0x22DD610 Offset: 0x22DBC10 VA: 0x1822DD610
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	// RVA: 0x22DD5E0 Offset: 0x22DBBE0 VA: 0x1822DD5E0
	public static void ExceptionClear() { }

	[ThreadSafe]
	// RVA: 0x22DE990 Offset: 0x22DCF90 VA: 0x1822DE990
	public static int PushLocalFrame(int capacity) { }

	[ThreadSafe]
	// RVA: 0x22DE950 Offset: 0x22DCF50 VA: 0x1822DE950
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[ThreadSafe]
	// RVA: 0x22DE590 Offset: 0x22DCB90 VA: 0x1822DE590
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DE9D0 Offset: 0x22DCFD0 VA: 0x1822DE9D0
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DE910 Offset: 0x22DCF10 VA: 0x1822DE910
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DD5A0 Offset: 0x22DBBA0 VA: 0x1822DD5A0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DE5D0 Offset: 0x22DCBD0 VA: 0x1822DE5D0
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DD560 Offset: 0x22DBB60 VA: 0x1822DD560
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DE540 Offset: 0x22DCB40 VA: 0x1822DE540
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x22DE6C0 Offset: 0x22DCCC0 VA: 0x1822DE6C0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DE610 Offset: 0x22DCC10 VA: 0x1822DE610
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x22DDFD0 Offset: 0x22DC5D0 VA: 0x1822DDFD0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DDD00 Offset: 0x22DC300 VA: 0x1822DDD00
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x22DE070 Offset: 0x22DC670 VA: 0x1822DE070
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x22DE900 Offset: 0x22DCF00 VA: 0x1822DE900
	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	// RVA: 0x22DE780 Offset: 0x22DCD80 VA: 0x1822DE780
	private static IntPtr NewStringFromStr(string chars) { }

	// RVA: 0x22DE3B0 Offset: 0x22DC9B0 VA: 0x1822DE3B0
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x22DE350 Offset: 0x22DC950 VA: 0x1822DE350
	private static AndroidJNI.JStringBinding GetStringCharsInternal(IntPtr str) { }

	// RVA: 0x22DD4B0 Offset: 0x22DBAB0 VA: 0x1822DD4B0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22DD440 Offset: 0x22DBA40 VA: 0x1822DD440
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DD290 Offset: 0x22DB890 VA: 0x1822DD290
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x22DD210 Offset: 0x22DB810 VA: 0x1822DD210
	private static AndroidJNI.JStringBinding CallStringMethodUnsafeInternal(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC2E0 Offset: 0x22DA8E0 VA: 0x1822DC2E0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC280 Offset: 0x22DA880 VA: 0x1822DC280
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC120 Offset: 0x22DA720 VA: 0x1822DC120
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC0C0 Offset: 0x22DA6C0 VA: 0x1822DC0C0
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DBDA0 Offset: 0x22DA3A0 VA: 0x1822DBDA0
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DBD40 Offset: 0x22DA340 VA: 0x1822DBD40
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC4A0 Offset: 0x22DAAA0 VA: 0x1822DC4A0
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC440 Offset: 0x22DAA40 VA: 0x1822DC440
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC3C0 Offset: 0x22DA9C0 VA: 0x1822DC3C0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC360 Offset: 0x22DA960 VA: 0x1822DC360
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DBE80 Offset: 0x22DA480 VA: 0x1822DBE80
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DBE20 Offset: 0x22DA420 VA: 0x1822DBE20
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC040 Offset: 0x22DA640 VA: 0x1822DC040
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DBFE0 Offset: 0x22DA5E0 VA: 0x1822DBFE0
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DBF60 Offset: 0x22DA560 VA: 0x1822DBF60
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DBF00 Offset: 0x22DA500 VA: 0x1822DBF00
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC200 Offset: 0x22DA800 VA: 0x1822DC200
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC1A0 Offset: 0x22DA7A0 VA: 0x1822DC1A0
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DD010 Offset: 0x22DB610 VA: 0x1822DD010
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22DCFA0 Offset: 0x22DB5A0 VA: 0x1822DCFA0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DCDF0 Offset: 0x22DB3F0 VA: 0x1822DCDF0
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x22DCD70 Offset: 0x22DB370 VA: 0x1822DCD70
	private static AndroidJNI.JStringBinding CallStaticStringMethodUnsafeInternal(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DCAC0 Offset: 0x22DB0C0 VA: 0x1822DCAC0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DCA60 Offset: 0x22DB060 VA: 0x1822DCA60
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC900 Offset: 0x22DAF00 VA: 0x1822DC900
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC8A0 Offset: 0x22DAEA0 VA: 0x1822DC8A0
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC580 Offset: 0x22DAB80 VA: 0x1822DC580
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC520 Offset: 0x22DAB20 VA: 0x1822DC520
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DCC80 Offset: 0x22DB280 VA: 0x1822DCC80
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DCC20 Offset: 0x22DB220 VA: 0x1822DCC20
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DCBA0 Offset: 0x22DB1A0 VA: 0x1822DCBA0
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DCB40 Offset: 0x22DB140 VA: 0x1822DCB40
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC660 Offset: 0x22DAC60 VA: 0x1822DC660
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC600 Offset: 0x22DAC00 VA: 0x1822DC600
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC820 Offset: 0x22DAE20 VA: 0x1822DC820
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC7C0 Offset: 0x22DADC0 VA: 0x1822DC7C0
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC740 Offset: 0x22DAD40 VA: 0x1822DC740
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC6E0 Offset: 0x22DACE0 VA: 0x1822DC6E0
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DC9E0 Offset: 0x22DAFE0 VA: 0x1822DC9E0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DC980 Offset: 0x22DAF80 VA: 0x1822DC980
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x22DD120 Offset: 0x22DB720 VA: 0x1822DD120
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x22DD0C0 Offset: 0x22DB6C0 VA: 0x1822DD0C0
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x22DEB20 Offset: 0x22DD120 VA: 0x1822DEB20
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafe]
	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	// RVA: 0x22DEC20 Offset: 0x22DD220 VA: 0x1822DEC20
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x22DF120 Offset: 0x22DD720 VA: 0x1822DF120
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafe]
	// RVA: 0x22DF190 Offset: 0x22DD790 VA: 0x1822DF190
	public static IntPtr ToSByteArray(sbyte* array, int length) { }

	// RVA: 0x22DED20 Offset: 0x22DD320 VA: 0x1822DED20
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafe]
	// RVA: 0x22DECE0 Offset: 0x22DD2E0 VA: 0x1822DECE0
	public static IntPtr ToCharArray(char* array, int length) { }

	// RVA: 0x22DF210 Offset: 0x22DD810 VA: 0x1822DF210
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafe]
	// RVA: 0x22DF1D0 Offset: 0x22DD7D0 VA: 0x1822DF1D0
	public static IntPtr ToShortArray(short* array, int length) { }

	// RVA: 0x22DEF30 Offset: 0x22DD530 VA: 0x1822DEF30
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafe]
	// RVA: 0x22DEEF0 Offset: 0x22DD4F0 VA: 0x1822DEEF0
	public static IntPtr ToIntArray(int* array, int length) { }

	// RVA: 0x22DEFA0 Offset: 0x22DD5A0 VA: 0x1822DEFA0
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafe]
	// RVA: 0x22DF010 Offset: 0x22DD610 VA: 0x1822DF010
	public static IntPtr ToLongArray(long* array, int length) { }

	// RVA: 0x22DEE40 Offset: 0x22DD440 VA: 0x1822DEE40
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafe]
	// RVA: 0x22DEEB0 Offset: 0x22DD4B0 VA: 0x1822DEEB0
	public static IntPtr ToFloatArray(float* array, int length) { }

	// RVA: 0x22DED90 Offset: 0x22DD390 VA: 0x1822DED90
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafe]
	// RVA: 0x22DEE00 Offset: 0x22DD400 VA: 0x1822DEE00
	public static IntPtr ToDoubleArray(double* array, int length) { }

	[ThreadSafe]
	// RVA: 0x22DF0D0 Offset: 0x22DD6D0 VA: 0x1822DF0D0
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x22DF050 Offset: 0x22DD650 VA: 0x1822DF050
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafe]
	// RVA: 0x22DD850 Offset: 0x22DBE50 VA: 0x1822DD850
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ThreadSafe]
	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	// RVA: 0x22DD980 Offset: 0x22DBF80 VA: 0x1822DD980
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDBE0 Offset: 0x22DC1E0 VA: 0x1822DDBE0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDA60 Offset: 0x22DC060 VA: 0x1822DDA60
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDC20 Offset: 0x22DC220 VA: 0x1822DDC20
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDB20 Offset: 0x22DC120 VA: 0x1822DDB20
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDB60 Offset: 0x22DC160 VA: 0x1822DDB60
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDAE0 Offset: 0x22DC0E0 VA: 0x1822DDAE0
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDAA0 Offset: 0x22DC0A0 VA: 0x1822DDAA0
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DDC60 Offset: 0x22DC260 VA: 0x1822DDC60
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x22DE670 Offset: 0x22DCC70 VA: 0x1822DE670
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x22DDF90 Offset: 0x22DC590 VA: 0x1822DDF90
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x22DEA90 Offset: 0x22DD090 VA: 0x1822DEA90
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	// RVA: 0x22DEA10 Offset: 0x22DD010 VA: 0x1822DEA10
	private static void ReleaseStringChars_Injected(in AndroidJNI.JStringBinding str) { }

	// RVA: 0x22DD640 Offset: 0x22DBC40 VA: 0x1822DD640
	private static IntPtr FindClass_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x22DDCA0 Offset: 0x22DC2A0 VA: 0x1822DDCA0
	private static IntPtr GetMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	// RVA: 0x22DE010 Offset: 0x22DC610 VA: 0x1822DE010
	private static IntPtr GetStaticMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	// RVA: 0x22DE740 Offset: 0x22DCD40 VA: 0x1822DE740
	private static IntPtr NewStringFromStr_Injected(ref ManagedSpanWrapper chars) { }

	// RVA: 0x22DE300 Offset: 0x22DC900 VA: 0x1822DE300
	private static void GetStringCharsInternal_Injected(IntPtr str, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x22DD1A0 Offset: 0x22DB7A0 VA: 0x1822DD1A0
	private static void CallStringMethodUnsafeInternal_Injected(IntPtr obj, IntPtr methodID, jvalue* args, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x22DCD00 Offset: 0x22DB300 VA: 0x1822DCD00
	private static void CallStaticStringMethodUnsafeInternal_Injected(IntPtr clazz, IntPtr methodID, jvalue* args, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x22DEAE0 Offset: 0x22DD0E0 VA: 0x1822DEAE0
	private static IntPtr ToBooleanArray_Injected(ref ManagedSpanWrapper array) { }

	// RVA: 0x22DEBE0 Offset: 0x22DD1E0 VA: 0x1822DEBE0
	private static IntPtr ToByteArray_Injected(ref ManagedSpanWrapper array) { }

	// RVA: 0x22DD800 Offset: 0x22DBE00 VA: 0x1822DD800
	private static void FromBooleanArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	// RVA: 0x22DD930 Offset: 0x22DBF30 VA: 0x1822DD930
	private static void FromByteArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }
}

// Namespace: UnityEngine
internal class AndroidJNISafe // TypeDefIndex: 13589
{
	// Methods

	// RVA: 0x22DABA0 Offset: 0x22D91A0 VA: 0x1822DABA0
	public static void CheckException() { }

	// RVA: 0x22DB670 Offset: 0x22D9C70 VA: 0x1822DB670
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x22DAE00 Offset: 0x22D9400 VA: 0x1822DAE00
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x22DADC0 Offset: 0x22D93C0 VA: 0x1822DADC0
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x22DB5D0 Offset: 0x22D9BD0 VA: 0x1822DB5D0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x22DB4B0 Offset: 0x22D9AB0 VA: 0x1822DB4B0
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x22DB3F0 Offset: 0x22D99F0 VA: 0x1822DB3F0
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x22DB460 Offset: 0x22D9A60 VA: 0x1822DB460
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x22DB320 Offset: 0x22D9920 VA: 0x1822DB320
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x22DB160 Offset: 0x22D9760 VA: 0x1822DB160
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x22DAE40 Offset: 0x22D9440 VA: 0x1822DAE40
	public static IntPtr FindClass(string name) { }

	// RVA: 0x22DB620 Offset: 0x22D9C20 VA: 0x1822DB620
	public static void PushLocalFrame(int capacity) { }

	// RVA: 0x22DB500 Offset: 0x22D9B00 VA: 0x1822DB500
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DAA20 Offset: 0x22D9020 VA: 0x1822DAA20
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22DA960 Offset: 0x22D8F60 VA: 0x1822DA960
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA640 Offset: 0x22D8C40 VA: 0x1822DA640
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22DA570 Offset: 0x22D8B70 VA: 0x1822DA570
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA870 Offset: 0x22D8E70 VA: 0x1822DA870
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA150 Offset: 0x22D8750 VA: 0x1822DA150
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA220 Offset: 0x22D8820 VA: 0x1822DA220
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA300 Offset: 0x22D8900 VA: 0x1822DA300
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA4A0 Offset: 0x22D8AA0 VA: 0x1822DA4A0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA7A0 Offset: 0x22D8DA0 VA: 0x1822DA7A0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA6D0 Offset: 0x22D8CD0 VA: 0x1822DA6D0
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA080 Offset: 0x22D8680 VA: 0x1822DA080
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DA3E0 Offset: 0x22D89E0 VA: 0x1822DA3E0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9E10 Offset: 0x22D8410 VA: 0x1822D9E10
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DAAB0 Offset: 0x22D90B0 VA: 0x1822DAAB0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D99F0 Offset: 0x22D7FF0 VA: 0x1822D99F0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9AC0 Offset: 0x22D80C0 VA: 0x1822D9AC0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9BA0 Offset: 0x22D81A0 VA: 0x1822D9BA0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9D40 Offset: 0x22D8340 VA: 0x1822D9D40
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9FB0 Offset: 0x22D85B0 VA: 0x1822D9FB0
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9EE0 Offset: 0x22D84E0 VA: 0x1822D9EE0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9920 Offset: 0x22D7F20 VA: 0x1822D9920
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22D9C80 Offset: 0x22D8280 VA: 0x1822D9C80
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x22DAF30 Offset: 0x22D9530 VA: 0x1822DAF30
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x22DAFA0 Offset: 0x22D95A0 VA: 0x1822DAFA0
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x22DB010 Offset: 0x22D9610 VA: 0x1822DB010
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x22DB0F0 Offset: 0x22D96F0 VA: 0x1822DB0F0
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x22DB240 Offset: 0x22D9840 VA: 0x1822DB240
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x22DAEE0 Offset: 0x22D94E0 VA: 0x1822DAEE0
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x22DB1D0 Offset: 0x22D97D0 VA: 0x1822DB1D0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x22DAE90 Offset: 0x22D9490 VA: 0x1822DAE90
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x22DB080 Offset: 0x22D9680 VA: 0x1822DB080
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x22DBB80 Offset: 0x22DA180 VA: 0x1822DBB80
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x22DB8B0 Offset: 0x22D9EB0 VA: 0x1822DB8B0
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x22DB940 Offset: 0x22D9F40 VA: 0x1822DB940
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x22DB9D0 Offset: 0x22D9FD0 VA: 0x1822DB9D0
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x22DBAF0 Offset: 0x22DA0F0 VA: 0x1822DBAF0
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x22DBCB0 Offset: 0x22DA2B0 VA: 0x1822DBCB0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x22DB7B0 Offset: 0x22D9DB0 VA: 0x1822DB7B0
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x22DBC20 Offset: 0x22DA220 VA: 0x1822DBC20
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x22DB6B0 Offset: 0x22D9CB0 VA: 0x1822DB6B0
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x22DBA60 Offset: 0x22DA060 VA: 0x1822DBA60
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x22DB370 Offset: 0x22D9970 VA: 0x1822DB370
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x22DB2B0 Offset: 0x22D98B0 VA: 0x1822DB2B0
	public static int GetArrayLength(IntPtr array) { }
}

// Namespace: UnityEngine
public enum RigidbodyConstraints // TypeDefIndex: 13603
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyConstraints None = 0;
	public const RigidbodyConstraints FreezePositionX = 2;
	public const RigidbodyConstraints FreezePositionY = 4;
	public const RigidbodyConstraints FreezePositionZ = 8;
	public const RigidbodyConstraints FreezeRotationX = 16;
	public const RigidbodyConstraints FreezeRotationY = 32;
	public const RigidbodyConstraints FreezeRotationZ = 64;
	public const RigidbodyConstraints FreezePosition = 14;
	public const RigidbodyConstraints FreezeRotation = 112;
	public const RigidbodyConstraints FreezeAll = 126;
}

// Namespace: UnityEngine
public enum ForceMode // TypeDefIndex: 13604
{
	// Fields
	public int value__; // 0x0
	public const ForceMode Force = 0;
	public const ForceMode Acceleration = 5;
	public const ForceMode Impulse = 1;
	public const ForceMode VelocityChange = 2;
}

// Namespace: UnityEngine
public enum RigidbodyInterpolation // TypeDefIndex: 13605
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyInterpolation None = 0;
	public const RigidbodyInterpolation Interpolate = 1;
	public const RigidbodyInterpolation Extrapolate = 2;
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class ControllerColliderHit // TypeDefIndex: 13606
{
	// Fields
	internal CharacterController m_Controller; // 0x10
	internal Collider m_Collider; // 0x18
	internal Vector3 m_Point; // 0x20
	internal Vector3 m_Normal; // 0x2C
	internal Vector3 m_MoveDirection; // 0x38
	internal float m_MoveLength; // 0x44
	internal int m_Push; // 0x48
}

// Namespace: UnityEngine
public class Collision // TypeDefIndex: 13607
{
	// Fields
	private ContactPairHeader m_Header; // 0x10
	private ContactPair m_Pair; // 0x38
	private bool m_Flipped; // 0x60
	private ContactPoint[] m_LegacyContacts; // 0x68

	// Properties
	public Vector3 relativeVelocity { get; }
	public Rigidbody rigidbody { get; }
	public Component body { get; }
	public Collider collider { get; }
	public Transform transform { get; }
	public GameObject gameObject { get; }
	internal bool Flipped { set; }
	public int contactCount { get; }
	public ContactPoint[] contacts { get; }

	// Methods

	// RVA: 0x23B19B0 Offset: 0x23AFFB0 VA: 0x1823B19B0
	public Vector3 get_relativeVelocity() { }

	// RVA: 0x23B1A10 Offset: 0x23B0010 VA: 0x1823B1A10
	public Rigidbody get_rigidbody() { }

	// RVA: 0x23B1790 Offset: 0x23AFD90 VA: 0x1823B1790
	public Component get_body() { }

	// RVA: 0x23B1810 Offset: 0x23AFE10 VA: 0x1823B1810
	public Collider get_collider() { }

	// RVA: 0x23B1AA0 Offset: 0x23B00A0 VA: 0x1823B1AA0
	public Transform get_transform() { }

	// RVA: 0x23B1920 Offset: 0x23AFF20 VA: 0x1823B1920
	public GameObject get_gameObject() { }

	// RVA: 0x37F820 Offset: 0x37DE20 VA: 0x18037F820
	internal void set_Flipped(bool value) { }

	// RVA: 0x23B18A0 Offset: 0x23AFEA0 VA: 0x1823B18A0
	public int get_contactCount() { }

	// RVA: 0x23B18B0 Offset: 0x23AFEB0 VA: 0x1823B18B0
	public ContactPoint[] get_contacts() { }

	// RVA: 0x23B1730 Offset: 0x23AFD30 VA: 0x1823B1730
	public void .ctor() { }

	// RVA: 0x23B1650 Offset: 0x23AFC50 VA: 0x1823B1650
	internal void .ctor(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x23B15F0 Offset: 0x23AFBF0 VA: 0x1823B15F0
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	// RVA: 0x23B13D0 Offset: 0x23AF9D0 VA: 0x1823B13D0
	public ContactPoint GetContact(int index) { }
}

// Namespace: UnityEngine
public enum QueryTriggerInteraction // TypeDefIndex: 13608
{
	// Fields
	public int value__; // 0x0
	public const QueryTriggerInteraction UseGlobal = 0;
	public const QueryTriggerInteraction Ignore = 1;
	public const QueryTriggerInteraction Collide = 2;
}

// Namespace: UnityEngine
public enum CollisionDetectionMode // TypeDefIndex: 13609
{
	// Fields
	public int value__; // 0x0
	public const CollisionDetectionMode Discrete = 0;
	public const CollisionDetectionMode Continuous = 1;
	public const CollisionDetectionMode ContinuousDynamic = 2;
	public const CollisionDetectionMode ContinuousSpeculative = 3;
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", 0)]
public class Physics // TypeDefIndex: 13611
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Physics.ContactEventDelegate ContactEvent; // 0x10
	private static readonly Collision s_ReusableCollision; // 0x18

	// Properties
	public static Vector3 gravity { get; }
	public static SimulationMode simulationMode { set; }
	public static bool invokeCollisionCallbacks { get; }
	[NativeProperty("DefaultPhysicsSceneHandle", True, 0, True)]
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool reuseCollisionCallbacks { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23B42B0 Offset: 0x23B28B0 VA: 0x1823B42B0
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[ThreadSafe]
	// RVA: 0x23B8FE0 Offset: 0x23B75E0 VA: 0x1823B8FE0
	public static Vector3 get_gravity() { }

	// RVA: 0x23B90B0 Offset: 0x23B76B0 VA: 0x1823B90B0
	public static void set_simulationMode(SimulationMode value) { }

	// RVA: 0x23B9050 Offset: 0x23B7650 VA: 0x1823B9050
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x23B8F30 Offset: 0x23B7530 VA: 0x1823B8F30
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x23B3E20 Offset: 0x23B2420 VA: 0x1823B3E20
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[ExcludeFromDocs]
	// RVA: 0x23B3F50 Offset: 0x23B2550 VA: 0x1823B3F50
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	[NativeName("IgnoreCollision")]
	// RVA: 0x23B40A0 Offset: 0x23B26A0 VA: 0x1823B40A0
	public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore) { }

	// RVA: 0x23B6740 Offset: 0x23B4D40 VA: 0x1823B6740
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B63E0 Offset: 0x23B49E0 VA: 0x1823B63E0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B7300 Offset: 0x23B5900 VA: 0x1823B7300
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B6FD0 Offset: 0x23B55D0 VA: 0x1823B6FD0
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x23B6EF0 Offset: 0x23B54F0 VA: 0x1823B6EF0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x23B68D0 Offset: 0x23B4ED0 VA: 0x1823B68D0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B6310 Offset: 0x23B4910 VA: 0x1823B6310
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B6570 Offset: 0x23B4B70 VA: 0x1823B6570
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x23B6D60 Offset: 0x23B5360 VA: 0x1823B6D60
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B69A0 Offset: 0x23B4FA0 VA: 0x1823B69A0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B6B20 Offset: 0x23B5120 VA: 0x1823B6B20
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B7490 Offset: 0x23B5A90 VA: 0x1823B7490
	public static bool Raycast(Ray ray) { }

	// RVA: 0x23B7220 Offset: 0x23B5820 VA: 0x1823B7220
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B6640 Offset: 0x23B4C40 VA: 0x1823B6640
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B6CA0 Offset: 0x23B52A0 VA: 0x1823B6CA0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B7160 Offset: 0x23B5760 VA: 0x1823B7160
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x23B8AF0 Offset: 0x23B70F0 VA: 0x1823B8AF0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B8730 Offset: 0x23B6D30 VA: 0x1823B8730
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B8A20 Offset: 0x23B7020 VA: 0x1823B8A20
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x23B8800 Offset: 0x23B6E00 VA: 0x1823B8800
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B88F0 Offset: 0x23B6EF0 VA: 0x1823B88F0
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	// RVA: 0x23B8C50 Offset: 0x23B7250 VA: 0x1823B8C50
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B8D20 Offset: 0x23B7320 VA: 0x1823B8D20
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[NativeName("RaycastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x23B4160 Offset: 0x23B2760 VA: 0x1823B4160
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B51B0 Offset: 0x23B37B0 VA: 0x1823B51B0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B5100 Offset: 0x23B3700 VA: 0x1823B5100
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B53D0 Offset: 0x23B39D0 VA: 0x1823B53D0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B5470 Offset: 0x23B3A70 VA: 0x1823B5470
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x23B5320 Offset: 0x23B3920 VA: 0x1823B5320
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x23B5060 Offset: 0x23B3660 VA: 0x1823B5060
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B4FC0 Offset: 0x23B35C0 VA: 0x1823B4FC0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B5510 Offset: 0x23B3B10 VA: 0x1823B5510
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x23B5F60 Offset: 0x23B4560 VA: 0x1823B5F60
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x23B5980 Offset: 0x23B3F80 VA: 0x1823B5980
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B55A0 Offset: 0x23B3BA0 VA: 0x1823B55A0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B5790 Offset: 0x23B3D90 VA: 0x1823B5790
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x23B6040 Offset: 0x23B4640 VA: 0x1823B6040
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B5D70 Offset: 0x23B4370 VA: 0x1823B5D70
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23B5B70 Offset: 0x23B4170 VA: 0x1823B5B70
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x23B6120 Offset: 0x23B4720 VA: 0x1823B6120
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeName("SphereCastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x23B4E50 Offset: 0x23B3450 VA: 0x1823B4E50
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B8010 Offset: 0x23B6610 VA: 0x1823B8010
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B7E90 Offset: 0x23B6490 VA: 0x1823B7E90
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x23B7F50 Offset: 0x23B6550 VA: 0x1823B7F50
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B7D90 Offset: 0x23B6390 VA: 0x1823B7D90
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask) { }

	[NativeName("OverlapSphere")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x23B4B40 Offset: 0x23B3140 VA: 0x1823B4B40
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B4CF0 Offset: 0x23B32F0 VA: 0x1823B4CF0
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B4BE0 Offset: 0x23B31E0 VA: 0x1823B4BE0
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x23B9080 Offset: 0x23B7680 VA: 0x1823B9080
	public static bool get_reuseCollisionCallbacks() { }

	// RVA: 0x23B4A00 Offset: 0x23B3000 VA: 0x1823B4A00
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B4910 Offset: 0x23B2F10 VA: 0x1823B4910
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	[NativeName("SphereTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x23B37A0 Offset: 0x23B1DA0 VA: 0x1823B37A0
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B3840 Offset: 0x23B1E40 VA: 0x1823B3840
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B3930 Offset: 0x23B1F30 VA: 0x1823B3930
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x23B8150 Offset: 0x23B6750 VA: 0x1823B8150
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B8540 Offset: 0x23B6B40 VA: 0x1823B8540
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B8320 Offset: 0x23B6920 VA: 0x1823B8320
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("CapsuleTest")]
	// RVA: 0x23B3440 Offset: 0x23B1A40 VA: 0x1823B3440
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B3620 Offset: 0x23B1C20 VA: 0x1823B3620
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B34E0 Offset: 0x23B1AE0 VA: 0x1823B34E0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[NativeName("OverlapBox")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x23B4600 Offset: 0x23B2C00 VA: 0x1823B4600
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B46A0 Offset: 0x23B2CA0 VA: 0x1823B46A0
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x23B47C0 Offset: 0x23B2DC0 VA: 0x1823B47C0
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x23B3B40 Offset: 0x23B2140 VA: 0x1823B3B40
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x23B3A80 Offset: 0x23B2080 VA: 0x1823B3A80
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x23B7B10 Offset: 0x23B6110 VA: 0x1823B7B10
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x23B7CF0 Offset: 0x23B62F0 VA: 0x1823B7CF0
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x23B7C00 Offset: 0x23B6200 VA: 0x1823B7C00
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[RequiredByNativeCode]
	// RVA: 0x23B43B0 Offset: 0x23B29B0 VA: 0x1823B43B0
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x23B7610 Offset: 0x23B5C10 VA: 0x1823B7610
	private static void ReportContacts(NativeArray.ReadOnly<ContactPairHeader> array) { }

	// RVA: 0x23B3BC0 Offset: 0x23B21C0 VA: 0x1823B3BC0
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x23B8E30 Offset: 0x23B7430 VA: 0x1823B8E30
	private static void .cctor() { }

	// RVA: 0x23B8FA0 Offset: 0x23B75A0 VA: 0x1823B8FA0
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x23B8EF0 Offset: 0x23B74F0 VA: 0x1823B8EF0
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x23B3DC0 Offset: 0x23B23C0 VA: 0x1823B3DC0
	private static void IgnoreCollision_Injected(IntPtr collider1, IntPtr collider2, bool ignore) { }

	// RVA: 0x23B40F0 Offset: 0x23B26F0 VA: 0x1823B40F0
	private static void Internal_RaycastAll_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	// RVA: 0x23B4DE0 Offset: 0x23B33E0 VA: 0x1823B4DE0
	private static void Query_SphereCastAll_Injected(in PhysicsScene physicsScene, in Vector3 origin, float radius, in Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	// RVA: 0x23B4AD0 Offset: 0x23B30D0 VA: 0x1823B4AD0
	private static Collider[] OverlapSphere_Internal_Injected(in PhysicsScene physicsScene, in Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B3730 Offset: 0x23B1D30 VA: 0x1823B3730
	private static bool CheckSphere_Internal_Injected(in PhysicsScene physicsScene, in Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B33D0 Offset: 0x23B19D0 VA: 0x1823B33D0
	private static bool CheckCapsule_Internal_Injected(in PhysicsScene physicsScene, in Vector3 start, in Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B4590 Offset: 0x23B2B90 VA: 0x1823B4590
	private static Collider[] OverlapBox_Internal_Injected(in PhysicsScene physicsScene, in Vector3 center, in Vector3 halfExtents, in Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B3B00 Offset: 0x23B2100 VA: 0x1823B3B00
	private static IntPtr GetColliderByInstanceID_Injected(int instanceID) { }

	// RVA: 0x23B3A40 Offset: 0x23B2040 VA: 0x1823B3A40
	private static IntPtr GetBodyByInstanceID_Injected(int instanceID) { }

	// RVA: 0x23B7AC0 Offset: 0x23B60C0 VA: 0x1823B7AC0
	private static void SendOnCollisionEnter_Injected(IntPtr component, Collision collision) { }

	// RVA: 0x23B7CA0 Offset: 0x23B62A0 VA: 0x1823B7CA0
	private static void SendOnCollisionStay_Injected(IntPtr component, Collision collision) { }

	// RVA: 0x23B7BB0 Offset: 0x23B61B0 VA: 0x1823B7BB0
	private static void SendOnCollisionExit_Injected(IntPtr component, Collision collision) { }
}

// Namespace: UnityEngine
public struct ModifiableContactPair // TypeDefIndex: 13612
{
	// Fields
	private IntPtr actor; // 0x0
	private IntPtr otherActor; // 0x8
	private IntPtr shape; // 0x10
	private IntPtr otherShape; // 0x18
	public Quaternion rotation; // 0x20
	public Vector3 position; // 0x30
	public Quaternion otherRotation; // 0x3C
	public Vector3 otherPosition; // 0x4C
	private int numContacts; // 0x58
	private IntPtr contacts; // 0x60
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/PhysicMaterial.h")]
public class PhysicMaterial : Object // TypeDefIndex: 13613
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[UsedByNativeCode]
public struct RaycastHit // TypeDefIndex: 13614
{
	// Fields
	[NativeName("point")]
	internal Vector3 m_Point; // 0x0
	[NativeName("normal")]
	internal Vector3 m_Normal; // 0xC
	[NativeName("faceID")]
	internal uint m_FaceID; // 0x18
	[NativeName("distance")]
	internal float m_Distance; // 0x1C
	[NativeName("uv")]
	internal Vector2 m_UV; // 0x20
	[NativeName("collider")]
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; }
	public Vector3 normal { get; }
	public float distance { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x23B90F0 Offset: 0x23B76F0 VA: 0x1823B90F0
	public Collider get_collider() { }

	// RVA: 0x22F1D70 Offset: 0x22F0370 VA: 0x1822F1D70
	public Vector3 get_point() { }

	// RVA: 0x22F1D90 Offset: 0x22F0390 VA: 0x1822F1D90
	public Vector3 get_normal() { }

	// RVA: 0x23A8F40 Offset: 0x23A7540 VA: 0x1823A8F40
	public float get_distance() { }

	// RVA: 0x23B92B0 Offset: 0x23B78B0 VA: 0x1823B92B0
	public Transform get_transform() { }

	// RVA: 0x23B91A0 Offset: 0x23B77A0 VA: 0x1823B91A0
	public Rigidbody get_rigidbody() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component // TypeDefIndex: 13615
{
	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { get; set; }
	public float drag { get; set; }
	public float mass { get; set; }
	public bool useGravity { get; set; }
	public bool isKinematic { get; set; }
	public bool freezeRotation { set; }
	public RigidbodyConstraints constraints { get; set; }
	public CollisionDetectionMode collisionDetectionMode { set; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; }
	public RigidbodyInterpolation interpolation { set; }
	public float sleepThreshold { set; }
	public float maxAngularVelocity { set; }

	// Methods

	// RVA: 0x23B9F40 Offset: 0x23B8540 VA: 0x1823B9F40
	public Vector3 get_velocity() { }

	// RVA: 0x23BAB20 Offset: 0x23B9120 VA: 0x1823BAB20
	public void set_velocity(Vector3 value) { }

	// RVA: 0x23B98C0 Offset: 0x23B7EC0 VA: 0x1823B98C0
	public Vector3 get_angularVelocity() { }

	// RVA: 0x23BA030 Offset: 0x23B8630 VA: 0x1823BA030
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x23B9A60 Offset: 0x23B8060 VA: 0x1823B9A60
	public float get_drag() { }

	// RVA: 0x23BA2B0 Offset: 0x23B88B0 VA: 0x1823BA2B0
	public void set_drag(float value) { }

	// RVA: 0x23B9BE0 Offset: 0x23B81E0 VA: 0x1823B9BE0
	public float get_mass() { }

	// RVA: 0x23BA6C0 Offset: 0x23B8CC0 VA: 0x1823BA6C0
	public void set_mass(float value) { }

	// RVA: 0x23B9E70 Offset: 0x23B8470 VA: 0x1823B9E70
	public bool get_useGravity() { }

	// RVA: 0x23BAA40 Offset: 0x23B9040 VA: 0x1823BAA40
	public void set_useGravity(bool value) { }

	// RVA: 0x23B9B20 Offset: 0x23B8120 VA: 0x1823B9B20
	public bool get_isKinematic() { }

	// RVA: 0x23BA5E0 Offset: 0x23B8BE0 VA: 0x1823BA5E0
	public void set_isKinematic(bool value) { }

	// RVA: 0x23BA340 Offset: 0x23B8940 VA: 0x1823BA340
	public void set_freezeRotation(bool value) { }

	// RVA: 0x23B99A0 Offset: 0x23B7FA0 VA: 0x1823B99A0
	public RigidbodyConstraints get_constraints() { }

	// RVA: 0x23BA1D0 Offset: 0x23B87D0 VA: 0x1823BA1D0
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x23BA100 Offset: 0x23B8700 VA: 0x1823BA100
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x23B9CB0 Offset: 0x23B82B0 VA: 0x1823B9CB0
	public Vector3 get_position() { }

	// RVA: 0x23BA880 Offset: 0x23B8E80 VA: 0x1823BA880
	public void set_position(Vector3 value) { }

	// RVA: 0x23B9DA0 Offset: 0x23B83A0 VA: 0x1823B9DA0
	public Quaternion get_rotation() { }

	// RVA: 0x23BA500 Offset: 0x23B8B00 VA: 0x1823BA500
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x23BA960 Offset: 0x23B8F60 VA: 0x1823BA960
	public void set_sleepThreshold(float value) { }

	// RVA: 0x23BA7A0 Offset: 0x23B8DA0 VA: 0x1823BA7A0
	public void set_maxAngularVelocity(float value) { }

	// RVA: 0x23B9700 Offset: 0x23B7D00 VA: 0x1823B9700
	public void MovePosition(Vector3 position) { }

	// RVA: 0x23B97E0 Offset: 0x23B7DE0 VA: 0x1823B97E0
	public void MoveRotation(Quaternion rot) { }

	// RVA: 0x23B9480 Offset: 0x23B7A80 VA: 0x1823B9480
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x23B93F0 Offset: 0x23B79F0 VA: 0x1823B93F0
	public void AddForce(Vector3 force) { }

	// RVA: 0x23B9610 Offset: 0x23B7C10 VA: 0x1823B9610
	public void AddTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x23B9580 Offset: 0x23B7B80 VA: 0x1823B9580
	public void AddTorque(Vector3 torque) { }

	// RVA: 0x23B9EF0 Offset: 0x23B84F0 VA: 0x1823B9EF0
	private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23BAAD0 Offset: 0x23B90D0 VA: 0x1823BAAD0
	private static void set_velocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x23B9870 Offset: 0x23B7E70 VA: 0x1823B9870
	private static void get_angularVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23B9FE0 Offset: 0x23B85E0 VA: 0x1823B9FE0
	private static void set_angularVelocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x23B9A20 Offset: 0x23B8020 VA: 0x1823B9A20
	private static float get_drag_Injected(IntPtr _unity_self) { }

	// RVA: 0x23BA260 Offset: 0x23B8860 VA: 0x1823BA260
	private static void set_drag_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x23B9BA0 Offset: 0x23B81A0 VA: 0x1823B9BA0
	private static float get_mass_Injected(IntPtr _unity_self) { }

	// RVA: 0x23BA670 Offset: 0x23B8C70 VA: 0x1823BA670
	private static void set_mass_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x23B9E30 Offset: 0x23B8430 VA: 0x1823B9E30
	private static bool get_useGravity_Injected(IntPtr _unity_self) { }

	// RVA: 0x23BA9F0 Offset: 0x23B8FF0 VA: 0x1823BA9F0
	private static void set_useGravity_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x23B9AE0 Offset: 0x23B80E0 VA: 0x1823B9AE0
	private static bool get_isKinematic_Injected(IntPtr _unity_self) { }

	// RVA: 0x23BA590 Offset: 0x23B8B90 VA: 0x1823BA590
	private static void set_isKinematic_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x23B9960 Offset: 0x23B7F60 VA: 0x1823B9960
	private static RigidbodyConstraints get_constraints_Injected(IntPtr _unity_self) { }

	// RVA: 0x23BA190 Offset: 0x23B8790 VA: 0x1823BA190
	private static void set_constraints_Injected(IntPtr _unity_self, RigidbodyConstraints value) { }

	// RVA: 0x23BA0C0 Offset: 0x23B86C0 VA: 0x1823BA0C0
	private static void set_collisionDetectionMode_Injected(IntPtr _unity_self, CollisionDetectionMode value) { }

	// RVA: 0x23B9C60 Offset: 0x23B8260 VA: 0x1823B9C60
	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23BA830 Offset: 0x23B8E30 VA: 0x1823BA830
	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x23B9D50 Offset: 0x23B8350 VA: 0x1823B9D50
	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	// RVA: 0x23BA4C0 Offset: 0x23B8AC0 VA: 0x1823BA4C0
	private static void set_interpolation_Injected(IntPtr _unity_self, RigidbodyInterpolation value) { }

	// RVA: 0x23BA910 Offset: 0x23B8F10 VA: 0x1823BA910
	private static void set_sleepThreshold_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x23BA750 Offset: 0x23B8D50 VA: 0x1823BA750
	private static void set_maxAngularVelocity_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x23B96B0 Offset: 0x23B7CB0 VA: 0x1823B96B0
	private static void MovePosition_Injected(IntPtr _unity_self, in Vector3 position) { }

	// RVA: 0x23B9790 Offset: 0x23B7D90 VA: 0x1823B9790
	private static void MoveRotation_Injected(IntPtr _unity_self, in Quaternion rot) { }

	// RVA: 0x23B9390 Offset: 0x23B7990 VA: 0x1823B9390
	private static void AddForce_Injected(IntPtr _unity_self, in Vector3 force, ForceMode mode) { }

	// RVA: 0x23B9520 Offset: 0x23B7B20 VA: 0x1823B9520
	private static void AddTorque_Injected(IntPtr _unity_self, in Vector3 torque, ForceMode mode) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Physics/Collider.h")]
[RequireComponent(typeof(Transform))]
public class Collider : Component // TypeDefIndex: 13616
{
	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }

	// Methods

	// RVA: 0x23B10D0 Offset: 0x23AF6D0 VA: 0x1823B10D0
	public bool get_enabled() { }

	// RVA: 0x23B1260 Offset: 0x23AF860 VA: 0x1823B1260
	public void set_enabled(bool value) { }

	[NativeMethod("GetRigidbody")]
	// RVA: 0x23B0F00 Offset: 0x23AF500 VA: 0x1823B0F00
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x23B1190 Offset: 0x23AF790 VA: 0x1823B1190
	public bool get_isTrigger() { }

	// RVA: 0x23B1340 Offset: 0x23AF940 VA: 0x1823B1340
	public void set_isTrigger(bool value) { }

	// RVA: 0x23B0CF0 Offset: 0x23AF2F0 VA: 0x1823B0CF0
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x23B0FF0 Offset: 0x23AF5F0 VA: 0x1823B0FF0
	public Bounds get_bounds() { }

	[NativeName("ClosestPointOnBounds")]
	// RVA: 0x23B0E10 Offset: 0x23AF410 VA: 0x1823B0E10
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x23B0B80 Offset: 0x23AF180 VA: 0x1823B0B80
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	// RVA: 0x23B1090 Offset: 0x23AF690 VA: 0x1823B1090
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x23B1210 Offset: 0x23AF810 VA: 0x1823B1210
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x23B0EC0 Offset: 0x23AF4C0 VA: 0x1823B0EC0
	private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self) { }

	// RVA: 0x23B1150 Offset: 0x23AF750 VA: 0x1823B1150
	private static bool get_isTrigger_Injected(IntPtr _unity_self) { }

	// RVA: 0x23B12F0 Offset: 0x23AF8F0 VA: 0x1823B12F0
	private static void set_isTrigger_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x23B0C90 Offset: 0x23AF290 VA: 0x1823B0C90
	private static void ClosestPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	// RVA: 0x23B0FA0 Offset: 0x23AF5A0 VA: 0x1823B0FA0
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	// RVA: 0x23B0DA0 Offset: 0x23AF3A0 VA: 0x1823B0DA0
	private static void Internal_ClosestPointOnBounds_Injected(IntPtr _unity_self, in Vector3 point, ref Vector3 outPos, ref float distance) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider // TypeDefIndex: 13617
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Physics/MeshCollider.h")]
public class MeshCollider : Collider // TypeDefIndex: 13618
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public bool convex { get; set; }

	// Methods

	// RVA: 0x23B2080 Offset: 0x23B0680 VA: 0x1823B2080
	public Mesh get_sharedMesh() { }

	// RVA: 0x23B2250 Offset: 0x23B0850 VA: 0x1823B2250
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x23B1FC0 Offset: 0x23B05C0 VA: 0x1823B1FC0
	public bool get_convex() { }

	// RVA: 0x23B2170 Offset: 0x23B0770 VA: 0x1823B2170
	public void set_convex(bool value) { }

	// RVA: 0x23B2040 Offset: 0x23B0640 VA: 0x1823B2040
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x23B2200 Offset: 0x23B0800 VA: 0x1823B2200
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x23B1F80 Offset: 0x23B0580 VA: 0x1823B1F80
	private static bool get_convex_Injected(IntPtr _unity_self) { }

	// RVA: 0x23B2120 Offset: 0x23B0720 VA: 0x1823B2120
	private static void set_convex_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/CapsuleCollider.h")]
[RequiredByNativeCode]
public class CapsuleCollider : Collider // TypeDefIndex: 13619
{
	// Properties
	public Vector3 center { set; }
	public float radius { get; set; }
	public float height { get; set; }

	// Methods

	// RVA: 0x23B0930 Offset: 0x23AEF30 VA: 0x1823B0930
	public void set_center(Vector3 value) { }

	// RVA: 0x23B0860 Offset: 0x23AEE60 VA: 0x1823B0860
	public float get_radius() { }

	// RVA: 0x23B0AF0 Offset: 0x23AF0F0 VA: 0x1823B0AF0
	public void set_radius(float value) { }

	// RVA: 0x23B07A0 Offset: 0x23AEDA0 VA: 0x1823B07A0
	public float get_height() { }

	// RVA: 0x23B0A10 Offset: 0x23AF010 VA: 0x1823B0A10
	public void set_height(float value) { }

	// RVA: 0x23B08E0 Offset: 0x23AEEE0 VA: 0x1823B08E0
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x23B0820 Offset: 0x23AEE20 VA: 0x1823B0820
	private static float get_radius_Injected(IntPtr _unity_self) { }

	// RVA: 0x23B0AA0 Offset: 0x23AF0A0 VA: 0x1823B0AA0
	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x23B0760 Offset: 0x23AED60 VA: 0x1823B0760
	private static float get_height_Injected(IntPtr _unity_self) { }

	// RVA: 0x23B09C0 Offset: 0x23AEFC0 VA: 0x1823B09C0
	private static void set_height_Injected(IntPtr _unity_self, float value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/BoxCollider.h")]
[RequiredByNativeCode]
public class BoxCollider : Collider // TypeDefIndex: 13620
{
	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }

	// Methods

	// RVA: 0x23B0410 Offset: 0x23AEA10 VA: 0x1823B0410
	public Vector3 get_center() { }

	// RVA: 0x23B05F0 Offset: 0x23AEBF0 VA: 0x1823B05F0
	public void set_center(Vector3 value) { }

	// RVA: 0x23B0500 Offset: 0x23AEB00 VA: 0x1823B0500
	public Vector3 get_size() { }

	// RVA: 0x23B06D0 Offset: 0x23AECD0 VA: 0x1823B06D0
	public void set_size(Vector3 value) { }

	// RVA: 0x23B03C0 Offset: 0x23AE9C0 VA: 0x1823B03C0
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23B05A0 Offset: 0x23AEBA0 VA: 0x1823B05A0
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x23B04B0 Offset: 0x23AEAB0 VA: 0x1823B04B0
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23B0680 Offset: 0x23AEC80 VA: 0x1823B0680
	private static void set_size_Injected(IntPtr _unity_self, in Vector3 value) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Physics/SphereCollider.h")]
public class SphereCollider : Collider // TypeDefIndex: 13621
{
	// Properties
	public Vector3 center { get; set; }
	public float radius { get; set; }

	// Methods

	// RVA: 0x23BAC00 Offset: 0x23B9200 VA: 0x1823BAC00
	public Vector3 get_center() { }

	// RVA: 0x23BADB0 Offset: 0x23B93B0 VA: 0x1823BADB0
	public void set_center(Vector3 value) { }

	// RVA: 0x23BACE0 Offset: 0x23B92E0 VA: 0x1823BACE0
	public float get_radius() { }

	// RVA: 0x23BAE90 Offset: 0x23B9490 VA: 0x1823BAE90
	public void set_radius(float value) { }

	// RVA: 0x23BABB0 Offset: 0x23B91B0 VA: 0x1823BABB0
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23BAD60 Offset: 0x23B9360 VA: 0x1823BAD60
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x23BACA0 Offset: 0x23B92A0 VA: 0x1823BACA0
	private static float get_radius_Injected(IntPtr _unity_self) { }

	// RVA: 0x23BAE40 Offset: 0x23B9440 VA: 0x1823BAE40
	private static void set_radius_Injected(IntPtr _unity_self, float value) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Physics/MessageParameters.h")]
public struct ContactPoint // TypeDefIndex: 13622
{
	// Fields
	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal Vector3 m_Impulse; // 0x18
	internal int m_ThisColliderInstanceID; // 0x24
	internal int m_OtherColliderInstanceID; // 0x28
	internal float m_Separation; // 0x2C

	// Properties
	public Vector3 point { get; }
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x22F1D70 Offset: 0x22F0370 VA: 0x1822F1D70
	public Vector3 get_point() { }

	// RVA: 0x22F1D90 Offset: 0x22F0390 VA: 0x1822F1D90
	public Vector3 get_normal() { }

	// RVA: 0x23B1F30 Offset: 0x23B0530 VA: 0x1823B1F30
	internal void .ctor(Vector3 point, Vector3 normal, Vector3 impulse, float separation, int thisInstanceID, int otherInstenceID) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 13623
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x23B3300 Offset: 0x23B1900 VA: 0x1823B3300 Slot: 3
	public override string ToString() { }

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23B2310 Offset: 0x23B0910 VA: 0x1823B2310 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x23B2D90 Offset: 0x23B1390 VA: 0x1823B2D90
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("RaycastTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x23B2570 Offset: 0x23B0B70 VA: 0x1823B2570
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2EE0 Offset: 0x23B14E0 VA: 0x1823B2EE0
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("Raycast")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x23B2650 Offset: 0x23B0C50 VA: 0x1823B2650
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2BE0 Offset: 0x23B11E0 VA: 0x1823B2BE0
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("RaycastNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x23B2400 Offset: 0x23B0A00 VA: 0x1823B2400
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("SphereCast")]
	// RVA: 0x23B2B50 Offset: 0x23B1150 VA: 0x1823B2B50
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2850 Offset: 0x23B0E50 VA: 0x1823B2850
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B31D0 Offset: 0x23B17D0 VA: 0x1823B31D0
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("SphereCastNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x23B2730 Offset: 0x23B0D30 VA: 0x1823B2730
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B3050 Offset: 0x23B1650 VA: 0x1823B3050
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("OverlapSphereNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x23B29F0 Offset: 0x23B0FF0 VA: 0x1823B29F0
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2A60 Offset: 0x23B1060 VA: 0x1823B2A60
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2500 Offset: 0x23B0B00 VA: 0x1823B2500
	private static bool Internal_RaycastTest_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B25E0 Offset: 0x23B0BE0 VA: 0x1823B25E0
	private static bool Internal_Raycast_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2390 Offset: 0x23B0990 VA: 0x1823B2390
	private static int Internal_RaycastNonAlloc_Injected(in PhysicsScene physicsScene, in Ray ray, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2AE0 Offset: 0x23B10E0 VA: 0x1823B2AE0
	private static bool Query_SphereCast_Injected(in PhysicsScene physicsScene, in Vector3 origin, float radius, in Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B26C0 Offset: 0x23B0CC0 VA: 0x1823B26C0
	private static int Internal_SphereCastNonAlloc_Injected(in PhysicsScene physicsScene, in Vector3 origin, float radius, in Vector3 direction, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23B2980 Offset: 0x23B0F80 VA: 0x1823B2980
	private static int OverlapSphereNonAlloc_Internal_Injected(in PhysicsScene physicsScene, in Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }
}

// Namespace: UnityEngine
public enum SimulationMode // TypeDefIndex: 13624
{
	// Fields
	public int value__; // 0x0
	public const SimulationMode FixedUpdate = 0;
	public const SimulationMode Update = 1;
	public const SimulationMode Script = 2;
}

// Namespace: UnityEngine
[IsReadOnly]
public struct ContactPairHeader // TypeDefIndex: 13625
{
	// Fields
	internal readonly int m_BodyID; // 0x0
	internal readonly int m_OtherBodyID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPairs; // 0x10
	internal readonly CollisionPairHeaderFlags m_Flags; // 0x14
	internal readonly Vector3 m_RelativeVelocity; // 0x18

	// Properties
	public Component body { get; }
	public Component otherBody { get; }
	internal bool hasRemovedBody { get; }

	// Methods

	// RVA: 0x23B1BC0 Offset: 0x23B01C0 VA: 0x1823B1BC0
	public Component get_body() { }

	// RVA: 0x23B1C30 Offset: 0x23B0230 VA: 0x1823B1C30
	public Component get_otherBody() { }

	// RVA: 0x23B1C10 Offset: 0x23B0210 VA: 0x1823B1C10
	internal bool get_hasRemovedBody() { }

	// RVA: 0x23B1BB0 Offset: 0x23B01B0 VA: 0x1823B1BB0
	public ref ContactPair GetContactPair(int index) { }

	// RVA: 0x23B1B30 Offset: 0x23B0130 VA: 0x1823B1B30
	internal ContactPair* GetContactPair_Internal(int index) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[IsReadOnly]
public struct ContactPair // TypeDefIndex: 13626
{
	// Fields
	internal readonly int m_ColliderID; // 0x0
	internal readonly int m_OtherColliderID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPoints; // 0x10
	internal readonly CollisionPairFlags m_Flags; // 0x14
	internal readonly CollisionPairEventFlags m_Events; // 0x16
	internal readonly Vector3 m_ImpulseSum; // 0x18

	// Properties
	public int colliderInstanceID { get; }
	public int otherColliderInstanceID { get; }
	public Collider collider { get; }
	public Collider otherCollider { get; }
	public bool isCollisionEnter { get; }
	public bool isCollisionExit { get; }
	public bool isCollisionStay { get; }
	internal bool hasRemovedCollider { get; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_colliderInstanceID() { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_otherColliderInstanceID() { }

	// RVA: 0x23B1E40 Offset: 0x23B0440 VA: 0x1823B1E40
	public Collider get_collider() { }

	// RVA: 0x23B1ED0 Offset: 0x23B04D0 VA: 0x1823B1ED0
	public Collider get_otherCollider() { }

	// RVA: 0x23B1EA0 Offset: 0x23B04A0 VA: 0x1823B1EA0
	public bool get_isCollisionEnter() { }

	// RVA: 0x23B1EB0 Offset: 0x23B04B0 VA: 0x1823B1EB0
	public bool get_isCollisionExit() { }

	// RVA: 0x23B1EC0 Offset: 0x23B04C0 VA: 0x1823B1EC0
	public bool get_isCollisionStay() { }

	// RVA: 0x23B1C10 Offset: 0x23B0210 VA: 0x1823B1C10
	internal bool get_hasRemovedCollider() { }

	// RVA: 0x23B1CE0 Offset: 0x23B02E0 VA: 0x1823B1CE0
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x23B1DC0 Offset: 0x23B03C0 VA: 0x1823B1DC0
	internal ContactPairPoint* GetContactPoint_Internal(int index) { }

	// RVA: 0x23B1C80 Offset: 0x23B0280 VA: 0x1823B1C80
	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ref ManagedSpanWrapper managedContainer, bool flipped) { }
}

// Namespace: UnityEngine
[IsReadOnly]
public struct ContactPairPoint // TypeDefIndex: 13627
{
	// Fields
	internal readonly Vector3 m_Position; // 0x0
	internal readonly float m_Separation; // 0xC
	internal readonly Vector3 m_Normal; // 0x10
	internal readonly uint m_InternalFaceIndex0; // 0x1C
	internal readonly Vector3 m_Impulse; // 0x20
	internal readonly uint m_InternalFaceIndex1; // 0x2C
}

// Namespace: UnityEngine
internal enum CollisionPairHeaderFlags // TypeDefIndex: 13628
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairHeaderFlags RemovedActor = 1;
	public const CollisionPairHeaderFlags RemovedOtherActor = 2;
}

// Namespace: UnityEngine
internal enum CollisionPairFlags // TypeDefIndex: 13629
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairFlags RemovedShape = 1;
	public const CollisionPairFlags RemovedOtherShape = 2;
	public const CollisionPairFlags ActorPairHasFirstTouch = 4;
	public const CollisionPairFlags ActorPairLostTouch = 8;
	public const CollisionPairFlags InternalHasImpulses = 16;
	public const CollisionPairFlags InternalContactsAreFlipped = 32;
}

// Namespace: UnityEngine
internal enum CollisionPairEventFlags // TypeDefIndex: 13630
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairEventFlags SolveContacts = 1;
	public const CollisionPairEventFlags ModifyContacts = 2;
	public const CollisionPairEventFlags NotifyTouchFound = 4;
	public const CollisionPairEventFlags NotifyTouchPersists = 8;
	public const CollisionPairEventFlags NotifyTouchLost = 16;
	public const CollisionPairEventFlags NotifyTouchCCD = 32;
	public const CollisionPairEventFlags NotifyThresholdForceFound = 64;
	public const CollisionPairEventFlags NotifyThresholdForcePersists = 128;
	public const CollisionPairEventFlags NotifyThresholdForceLost = 256;
	public const CollisionPairEventFlags NotifyContactPoint = 512;
	public const CollisionPairEventFlags DetectDiscreteContact = 1024;
	public const CollisionPairEventFlags DetectCCDContact = 2048;
	public const CollisionPairEventFlags PreSolverVelocity = 4096;
	public const CollisionPairEventFlags PostSolverVelocity = 8192;
	public const CollisionPairEventFlags ContactEventPose = 16384;
	public const CollisionPairEventFlags NextFree = 32768;
	public const CollisionPairEventFlags ContactDefault = 1025;
	public const CollisionPairEventFlags TriggerDefault = 1044;
}

// Namespace: UnityEngine
public class WWWForm // TypeDefIndex: 13864
{
	// Fields
	private static byte[] dDash; // 0x0
	private static byte[] crlf; // 0x8
	private static byte[] contentTypeHeader; // 0x10
	private static byte[] dispositionHeader; // 0x18
	private static byte[] endQuote; // 0x20
	private static byte[] fileNameField; // 0x28
	private static byte[] ampersand; // 0x30
	private static byte[] equal; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }

	// Methods

	// RVA: 0x2686300 Offset: 0x2684900 VA: 0x182686300
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x2685FA0 Offset: 0x26845A0 VA: 0x182685FA0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder // TypeDefIndex: 13865
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x26866C0 Offset: 0x2684CC0 VA: 0x1826866C0
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x2686750 Offset: 0x2684D50 VA: 0x182686750
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x2686310 Offset: 0x2684910 VA: 0x182686310
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x26863A0 Offset: 0x26849A0 VA: 0x1826863A0
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x26867B0 Offset: 0x2684DB0 VA: 0x1826867B0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
public sealed class ParticleSystem : Component // TypeDefIndex: 13894
{
	// Properties
	[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", False)]
	public bool enableEmission { set; }
	[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", False)]
	public float startSpeed { set; }
	[Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
	public Color startColor { get; set; }
	[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", False)]
	public float startLifetime { set; }
	public bool isPlaying { get; }
	public int particleCount { get; }
	public float time { get; set; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime { get; }
	public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation { get; }
	public ParticleSystem.TrailModule trails { get; }

	// Methods

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x23ABD70 Offset: 0x23AA370 VA: 0x1823ABD70
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x23ABF50 Offset: 0x23AA550 VA: 0x1823ABF50
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x23ACF70 Offset: 0x23AB570 VA: 0x1823ACF70
	public void set_enableEmission(bool value) { }

	// RVA: 0x23AD160 Offset: 0x23AB760 VA: 0x1823AD160
	public void set_startSpeed(float value) { }

	// RVA: 0x23ACE40 Offset: 0x23AB440 VA: 0x1823ACE40
	public Color get_startColor() { }

	// RVA: 0x23ACFD0 Offset: 0x23AB5D0 VA: 0x1823ACFD0
	public void set_startColor(Color value) { }

	// RVA: 0x23AD100 Offset: 0x23AB700 VA: 0x1823AD100
	public void set_startLifetime(float value) { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	// RVA: 0x23ACD00 Offset: 0x23AB300 VA: 0x1823ACD00
	public bool get_isPlaying() { }

	[NativeName("SyncJobs(false)->GetParticleCount")]
	// RVA: 0x23ACDC0 Offset: 0x23AB3C0 VA: 0x1823ACDC0
	public int get_particleCount() { }

	[NativeName("SyncJobs(false)->GetSecPosition")]
	// RVA: 0x23ACEF0 Offset: 0x23AB4F0 VA: 0x1823ACEF0
	public float get_time() { }

	[NativeName("SyncJobs(false)->SetSecPosition")]
	// RVA: 0x23AD210 Offset: 0x23AB810 VA: 0x1823AD210
	public void set_time(float value) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x23AC760 Offset: 0x23AAD60 VA: 0x1823AC760
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x23AC740 Offset: 0x23AAD40 VA: 0x1823AC740
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x23AC0F0 Offset: 0x23AA6F0 VA: 0x1823AC0F0
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x23AC290 Offset: 0x23AA890 VA: 0x1823AC290
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	// RVA: 0x23AC930 Offset: 0x23AAF30 VA: 0x1823AC930
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x23AC9F0 Offset: 0x23AAFF0 VA: 0x1823AC9F0
	public void Simulate(float t, bool withChildren, bool restart) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	// RVA: 0x23AC5C0 Offset: 0x23AABC0 VA: 0x1823AC5C0
	public void Play(bool withChildren) { }

	// RVA: 0x23AC650 Offset: 0x23AAC50 VA: 0x1823AC650
	public void Play() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	// RVA: 0x23AC4E0 Offset: 0x23AAAE0 VA: 0x1823AC4E0
	public void Pause(bool withChildren) { }

	// RVA: 0x23AC460 Offset: 0x23AAA60 VA: 0x1823AC460
	public void Pause() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	// RVA: 0x23ACC20 Offset: 0x23AB220 VA: 0x1823ACC20
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x23ACB90 Offset: 0x23AB190 VA: 0x1823ACB90
	public void Stop(bool withChildren) { }

	// RVA: 0x23ACB00 Offset: 0x23AB100 VA: 0x1823ACB00
	public void Stop() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	// RVA: 0x23ABA50 Offset: 0x23AA050 VA: 0x1823ABA50
	public void Clear(bool withChildren) { }

	// RVA: 0x23ABAE0 Offset: 0x23AA0E0 VA: 0x1823ABAE0
	public void Clear() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
	// RVA: 0x23AC300 Offset: 0x23AA900 VA: 0x1823AC300
	public bool IsAlive(bool withChildren) { }

	// RVA: 0x23AC390 Offset: 0x23AA990 VA: 0x1823AC390
	public bool IsAlive() { }

	[RequiredByNativeCode]
	// RVA: 0x23ABCE0 Offset: 0x23AA2E0 VA: 0x1823ABCE0
	public void Emit(int count) { }

	[NativeName("SyncJobs()->Emit")]
	// RVA: 0x23ABCE0 Offset: 0x23AA2E0 VA: 0x1823ABCE0
	private void Emit_Internal(int count) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	// RVA: 0x23ABFE0 Offset: 0x23AA5E0 VA: 0x1823ABFE0
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	// RVA: 0x23ABBB0 Offset: 0x23AA1B0 VA: 0x1823ABBB0
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation() { }

	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public ParticleSystem.TrailModule get_trails() { }

	// RVA: 0x23ACCC0 Offset: 0x23AB2C0 VA: 0x1823ACCC0
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x23ACD80 Offset: 0x23AB380 VA: 0x1823ACD80
	private static int get_particleCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x23ACEB0 Offset: 0x23AB4B0 VA: 0x1823ACEB0
	private static float get_time_Injected(IntPtr _unity_self) { }

	// RVA: 0x23AD1C0 Offset: 0x23AB7C0 VA: 0x1823AD1C0
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x23AC6D0 Offset: 0x23AACD0 VA: 0x1823AC6D0
	private static void SetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset) { }

	// RVA: 0x23AC080 Offset: 0x23AA680 VA: 0x1823AC080
	private static int GetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset) { }

	// RVA: 0x23AC8C0 Offset: 0x23AAEC0 VA: 0x1823AC8C0
	private static void Simulate_Injected(IntPtr _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x23AC570 Offset: 0x23AAB70 VA: 0x1823AC570
	private static void Play_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x23AC410 Offset: 0x23AAA10 VA: 0x1823AC410
	private static void Pause_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x23ACAA0 Offset: 0x23AB0A0 VA: 0x1823ACAA0
	private static void Stop_Injected(IntPtr _unity_self, bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x23ABA00 Offset: 0x23AA000 VA: 0x1823ABA00
	private static void Clear_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x23AC2B0 Offset: 0x23AA8B0 VA: 0x1823AC2B0
	private static bool IsAlive_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x23ABCA0 Offset: 0x23AA2A0 VA: 0x1823ABCA0
	private static void Emit_Internal_Injected(IntPtr _unity_self, int count) { }

	// RVA: 0x23ABC40 Offset: 0x23AA240 VA: 0x1823ABC40
	private static void Emit_Injected(IntPtr _unity_self, in ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x23ABB60 Offset: 0x23AA160 VA: 0x1823ABB60
	private static void EmitOld_Internal_Injected(IntPtr _unity_self, ref ParticleSystem.Particle particle) { }
}

// Namespace: UnityEngine
public enum ParticleSystemRenderMode // TypeDefIndex: 13895
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemRenderMode Billboard = 0;
	public const ParticleSystemRenderMode Stretch = 1;
	public const ParticleSystemRenderMode HorizontalBillboard = 2;
	public const ParticleSystemRenderMode VerticalBillboard = 3;
	public const ParticleSystemRenderMode Mesh = 4;
	public const ParticleSystemRenderMode None = 5;
}

// Namespace: UnityEngine
public enum ParticleSystemCurveMode // TypeDefIndex: 13896
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemCurveMode Constant = 0;
	public const ParticleSystemCurveMode Curve = 1;
	public const ParticleSystemCurveMode TwoCurves = 2;
	public const ParticleSystemCurveMode TwoConstants = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemGradientMode // TypeDefIndex: 13897
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemGradientMode Color = 0;
	public const ParticleSystemGradientMode Gradient = 1;
	public const ParticleSystemGradientMode TwoColors = 2;
	public const ParticleSystemGradientMode TwoGradients = 3;
	public const ParticleSystemGradientMode RandomColor = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemAnimationMode // TypeDefIndex: 13898
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemAnimationMode Grid = 0;
	public const ParticleSystemAnimationMode Sprites = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemSimulationSpace // TypeDefIndex: 13899
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemSimulationSpace Local = 0;
	public const ParticleSystemSimulationSpace World = 1;
	public const ParticleSystemSimulationSpace Custom = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemStopBehavior // TypeDefIndex: 13900
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemStopBehavior StopEmittingAndClear = 0;
	public const ParticleSystemStopBehavior StopEmitting = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemScalingMode // TypeDefIndex: 13901
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemScalingMode Hierarchy = 0;
	public const ParticleSystemScalingMode Local = 1;
	public const ParticleSystemScalingMode Shape = 2;
}

// Namespace: UnityEngine
[Flags]
public enum ParticleSystemBakeMeshOptions // TypeDefIndex: 13902
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemBakeMeshOptions BakeRotationAndScale = 1;
	public const ParticleSystemBakeMeshOptions BakePosition = 2;
	public const ParticleSystemBakeMeshOptions Default = 0;
}

// Namespace: UnityEngine
[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("ParticleSystemScriptingClasses.h")]
public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 13903
{
	// Properties
	public ParticleSystemRenderMode renderMode { get; }
	public float sortingFudge { get; }
	public Material trailMaterial { get; }
	public Mesh mesh { get; }

	// Methods

	// RVA: 0x23AB7E0 Offset: 0x23A9DE0 VA: 0x1823AB7E0
	public ParticleSystemRenderMode get_renderMode() { }

	// RVA: 0x23AB8A0 Offset: 0x23A9EA0 VA: 0x1823AB8A0
	public float get_sortingFudge() { }

	// RVA: 0x23AB960 Offset: 0x23A9F60 VA: 0x1823AB960
	public Material get_trailMaterial() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
	// RVA: 0x23AB700 Offset: 0x23A9D00 VA: 0x1823AB700
	public Mesh get_mesh() { }

	[RequiredByNativeCode]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	// RVA: 0x23AB610 Offset: 0x23A9C10 VA: 0x1823AB610
	public int GetMeshes([Out] Mesh[] meshes) { }

	// RVA: 0x23AB2B0 Offset: 0x23A98B0 VA: 0x1823AB2B0
	public void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x23AB470 Offset: 0x23A9A70 VA: 0x1823AB470
	public void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x23AB7A0 Offset: 0x23A9DA0 VA: 0x1823AB7A0
	private static ParticleSystemRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x23AB860 Offset: 0x23A9E60 VA: 0x1823AB860
	private static float get_sortingFudge_Injected(IntPtr _unity_self) { }

	// RVA: 0x23AB920 Offset: 0x23A9F20 VA: 0x1823AB920
	private static IntPtr get_trailMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x23AB6C0 Offset: 0x23A9CC0 VA: 0x1823AB6C0
	private static IntPtr get_mesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x23AB5C0 Offset: 0x23A9BC0 VA: 0x1823AB5C0
	private static int GetMeshes_Injected(IntPtr _unity_self, [Out] Mesh[] meshes) { }

	// RVA: 0x23AB240 Offset: 0x23A9840 VA: 0x1823AB240
	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x23AB400 Offset: 0x23A9A00 VA: 0x1823AB400
	private static void BakeTrailsMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(4, AllowMultiple = False)]
public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 13906
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 13907
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal enum AnimationEventSource // TypeDefIndex: 13908
{
	// Fields
	public int value__; // 0x0
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimationState.h")]
public sealed class AnimationState : TrackedReference // TypeDefIndex: 13909
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
internal struct AnimationEventBlittable : IDisposable // TypeDefIndex: 13910
{
	// Fields
	internal float m_Time; // 0x0
	internal IntPtr m_FunctionName; // 0x8
	internal IntPtr m_StringParameter; // 0x10
	internal IntPtr m_ObjectReferenceParameter; // 0x18
	internal float m_FloatParameter; // 0x20
	internal int m_IntParameter; // 0x24
	internal int m_MessageOptions; // 0x28
	internal AnimationEventSource m_Source; // 0x2C
	internal IntPtr m_StateSender; // 0x30
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x38
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x5C
	[ThreadStatic]
	private static GCHandlePool s_handlePool; // 0x80000000

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x22E7470 Offset: 0x22E5A70 VA: 0x1822E7470
	internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable) { }

	// RVA: 0x22E74E0 Offset: 0x22E5AE0 VA: 0x1822E74E0
	internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable) { }

	// RVA: 0x22E7310 Offset: 0x22E5910 VA: 0x1822E7310 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
public sealed class AnimationEvent // TypeDefIndex: 13911
{
	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Methods

	// RVA: 0x22E79D0 Offset: 0x22E5FD0 VA: 0x1822E79D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion // TypeDefIndex: 13912
{}

// Namespace: UnityEngine
internal class GCHandlePool // TypeDefIndex: 13913
{
	// Fields
	private GCHandle[] m_handles; // 0x10
	private int m_current; // 0x18

	// Methods

	// RVA: 0x22EA570 Offset: 0x22E8B70 VA: 0x1822EA570
	public void .ctor() { }

	// RVA: 0x22EA470 Offset: 0x22E8A70 VA: 0x1822EA470
	public void Free(GCHandle h) { }
}

// Namespace: UnityEngine
internal enum StateInfoIndex // TypeDefIndex: 13914
{
	// Fields
	public int value__; // 0x0
	public const StateInfoIndex CurrentState = 0;
	public const StateInfoIndex NextState = 1;
	public const StateInfoIndex ExitState = 2;
	public const StateInfoIndex InterruptedState = 3;
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
public struct AnimatorClipInfo // TypeDefIndex: 13915
{
	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorStateInfo // TypeDefIndex: 13916
{
	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	// Properties
	public float normalizedTime { get; }

	// Methods

	// RVA: 0x22E9170 Offset: 0x22E7770 VA: 0x1822E9170
	public bool IsName(string name) { }

	// RVA: 0x22E91B0 Offset: 0x22E77B0 VA: 0x1822E91B0
	public float get_normalizedTime() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorTransitionInfo // TypeDefIndex: 13917
{
	// Fields
	[NativeName("fullPathHash")]
	private int m_FullPath; // 0x0
	[NativeName("userNameHash")]
	private int m_UserName; // 0x4
	[NativeName("nameHash")]
	private int m_Name; // 0x8
	[NativeName("hasFixedDuration")]
	private bool m_HasFixedDuration; // 0xC
	[NativeName("duration")]
	private float m_Duration; // 0x10
	[NativeName("normalizedTime")]
	private float m_NormalizedTime; // 0x14
	[NativeName("anyState")]
	private bool m_AnyState; // 0x18
	[NativeName("transitionType")]
	private int m_TransitionType; // 0x1C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/Animator.h")]
public class Animator : Behaviour // TypeDefIndex: 13918
{
	// Properties
	public float speed { get; set; }
	public RuntimeAnimatorController runtimeAnimatorController { get; }
	public bool hasBoundPlayables { get; }

	// Methods

	// RVA: 0x22E94F0 Offset: 0x22E7AF0 VA: 0x1822E94F0
	public bool GetBool(string name) { }

	// RVA: 0x22E9CA0 Offset: 0x22E82A0 VA: 0x1822E9CA0
	public void SetBool(string name, bool value) { }

	// RVA: 0x22E9EC0 Offset: 0x22E84C0 VA: 0x1822E9EC0
	public void SetTrigger(string name) { }

	// RVA: 0x22E9A60 Offset: 0x22E8060 VA: 0x1822E9A60
	public void ResetTrigger(string name) { }

	// RVA: 0x22E9220 Offset: 0x22E7820 VA: 0x1822E9220
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x22E9500 Offset: 0x22E7B00 VA: 0x1822E9500
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x22EA310 Offset: 0x22E8910 VA: 0x1822EA310
	public float get_speed() { }

	// RVA: 0x22EA3E0 Offset: 0x22E89E0 VA: 0x1822EA3E0
	public void set_speed(float value) { }

	// RVA: 0x22E9640 Offset: 0x22E7C40 VA: 0x1822E9640
	public void Play(string stateName) { }

	// RVA: 0x22E9790 Offset: 0x22E7D90 VA: 0x1822E9790
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	// RVA: 0x22E96E0 Offset: 0x22E7CE0 VA: 0x1822E96E0
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x22EA190 Offset: 0x22E8790 VA: 0x1822EA190
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	[NativeMethod("HasBoundPlayables")]
	// RVA: 0x22EA0D0 Offset: 0x22E86D0 VA: 0x1822EA0D0
	public bool get_hasBoundPlayables() { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	// RVA: 0x22E9F10 Offset: 0x22E8510 VA: 0x1822E9F10
	public static int StringToHash(string name) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	// RVA: 0x22E9AD0 Offset: 0x22E80D0 VA: 0x1822E9AD0
	private void SetBoolString(string name, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = True)]
	// RVA: 0x22E9320 Offset: 0x22E7920 VA: 0x1822E9320
	private bool GetBoolString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	// RVA: 0x22E9D00 Offset: 0x22E8300 VA: 0x1822E9D00
	private void SetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	// RVA: 0x22E98A0 Offset: 0x22E7EA0 VA: 0x1822E98A0
	private void ResetTriggerString(string name) { }

	// RVA: 0x22E91C0 Offset: 0x22E77C0 VA: 0x1822E91C0
	private static void GetAnimatorStateInfo_Injected(IntPtr _unity_self, int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x22EA2D0 Offset: 0x22E88D0 VA: 0x1822EA2D0
	private static float get_speed_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EA390 Offset: 0x22E8990 VA: 0x1822EA390
	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x22E95E0 Offset: 0x22E7BE0 VA: 0x1822E95E0
	private static void Play_Injected(IntPtr _unity_self, int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x22EA150 Offset: 0x22E8750 VA: 0x1822EA150
	private static IntPtr get_runtimeAnimatorController_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EA090 Offset: 0x22E8690 VA: 0x1822EA090
	private static bool get_hasBoundPlayables_Injected(IntPtr _unity_self) { }

	// RVA: 0x22E9ED0 Offset: 0x22E84D0 VA: 0x1822E9ED0
	private static int StringToHash_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x22E9A70 Offset: 0x22E8070 VA: 0x1822E9A70
	private static void SetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, bool value) { }

	// RVA: 0x22E92D0 Offset: 0x22E78D0 VA: 0x1822E92D0
	private static bool GetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x22E9CB0 Offset: 0x22E82B0 VA: 0x1822E9CB0
	private static void SetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x22E9850 Offset: 0x22E7E50 VA: 0x1822E9850
	private static void ResetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 13920
{
	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	// RVA: 0x22E9140 Offset: 0x22E7740 VA: 0x1822E9140
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }
}

// Namespace: UnityEngine
[NativeType(1, "MonoSkeletonBone")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/HumanDescription.h")]
public struct SkeletonBone // TypeDefIndex: 13921
{
	// Fields
	[NativeName("m_Name")]
	public string name; // 0x0
	[NativeName("m_ParentName")]
	internal string parentName; // 0x8
	[NativeName("m_Position")]
	public Vector3 position; // 0x10
	[NativeName("m_Rotation")]
	public Quaternion rotation; // 0x1C
	[NativeName("m_Scale")]
	public Vector3 scale; // 0x2C
}

// Namespace: UnityEngine
[NativeType(1, "MonoHumanLimit")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
public struct HumanLimit // TypeDefIndex: 13922
{
	// Fields
	private Vector3 m_Min; // 0x0
	private Vector3 m_Max; // 0xC
	private Vector3 m_Center; // 0x18
	private float m_AxisLength; // 0x24
	private int m_UseDefaultValues; // 0x28
}

// Namespace: UnityEngine
[NativeType(1, "MonoHumanBone")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/HumanDescription.h")]
public struct HumanBone // TypeDefIndex: 13923
{
	// Fields
	private string m_BoneName; // 0x0
	private string m_HumanName; // 0x8
	[NativeName("m_Limit")]
	public HumanLimit limit; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Motion.h")]
public class Motion : Object // TypeDefIndex: 13924
{}

// Namespace: UnityEngine
[ExcludeFromObjectFactory]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
public class RuntimeAnimatorController : Object // TypeDefIndex: 13925
{}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter // TypeDefIndex: 13941
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasGroup.h")]
[NativeClass("UI::CanvasGroup")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 13942
{
	// Properties
	[NativeProperty("Alpha", False, 0)]
	public float alpha { get; set; }
	[NativeProperty("Interactable", False, 0)]
	public bool interactable { get; }
	[NativeProperty("BlocksRaycasts", False, 0)]
	public bool blocksRaycasts { get; }
	[NativeProperty("IgnoreParentGroups", False, 0)]
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x263A2F0 Offset: 0x26388F0 VA: 0x18263A2F0
	public float get_alpha() { }

	// RVA: 0x263A580 Offset: 0x2638B80 VA: 0x18263A580
	public void set_alpha(float value) { }

	// RVA: 0x263A4B0 Offset: 0x2638AB0 VA: 0x18263A4B0
	public bool get_interactable() { }

	// RVA: 0x263A230 Offset: 0x2638830 VA: 0x18263A230
	public bool get_blocksRaycasts() { }

	// RVA: 0x263A3F0 Offset: 0x26389F0 VA: 0x18263A3F0
	public bool get_ignoreParentGroups() { }

	// RVA: 0x263A660 Offset: 0x2638C60 VA: 0x18263A660
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x263A230 Offset: 0x2638830 VA: 0x18263A230 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x263A2B0 Offset: 0x26388B0 VA: 0x18263A2B0
	private static float get_alpha_Injected(IntPtr _unity_self) { }

	// RVA: 0x263A530 Offset: 0x2638B30 VA: 0x18263A530
	private static void set_alpha_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x263A470 Offset: 0x2638A70 VA: 0x18263A470
	private static bool get_interactable_Injected(IntPtr _unity_self) { }

	// RVA: 0x263A370 Offset: 0x2638970 VA: 0x18263A370
	private static bool get_blocksRaycasts_Injected(IntPtr _unity_self) { }

	// RVA: 0x263A3B0 Offset: 0x26389B0 VA: 0x18263A3B0
	private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self) { }

	// RVA: 0x263A610 Offset: 0x2638C10 VA: 0x18263A610
	private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasRenderer.h")]
[NativeClass("UI::CanvasRenderer")]
public sealed class CanvasRenderer : Component // TypeDefIndex: 13943
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativeProperty("ShouldCull", False, 0)]
	public bool cull { get; set; }
	public Vector2 clippingSoftness { set; }

	// Methods

	// RVA: 0x263BE00 Offset: 0x263A400 VA: 0x18263BE00
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x263BA90 Offset: 0x263A090 VA: 0x18263BA90
	public int get_materialCount() { }

	// RVA: 0x263BED0 Offset: 0x263A4D0 VA: 0x18263BED0
	public void set_materialCount(int value) { }

	// RVA: 0x263BFA0 Offset: 0x263A5A0 VA: 0x18263BFA0
	public void set_popMaterialCount(int value) { }

	// RVA: 0x263B790 Offset: 0x2639D90 VA: 0x18263B790
	public int get_absoluteDepth() { }

	// RVA: 0x263B9D0 Offset: 0x2639FD0 VA: 0x18263B9D0
	public bool get_hasMoved() { }

	// RVA: 0x263B850 Offset: 0x2639E50 VA: 0x18263B850
	public bool get_cullTransparentMesh() { }

	// RVA: 0x263BC40 Offset: 0x263A240 VA: 0x18263BC40
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x263B910 Offset: 0x2639F10 VA: 0x18263B910
	public bool get_cull() { }

	// RVA: 0x263BD20 Offset: 0x263A320 VA: 0x18263BD20
	public void set_cull(bool value) { }

	// RVA: 0x263AEB0 Offset: 0x26394B0 VA: 0x18263AEB0
	public void SetColor(Color color) { }

	// RVA: 0x263AA80 Offset: 0x2639080 VA: 0x18263AA80
	public Color GetColor() { }

	// RVA: 0x263A9A0 Offset: 0x2638FA0 VA: 0x18263A9A0
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x263BB60 Offset: 0x263A160 VA: 0x18263BB60
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x263A8D0 Offset: 0x2638ED0 VA: 0x18263A8D0
	public void DisableRectClipping() { }

	// RVA: 0x263B1F0 Offset: 0x26397F0 VA: 0x18263B1F0
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x263ACB0 Offset: 0x26392B0 VA: 0x18263ACB0
	public Material GetMaterial(int index) { }

	// RVA: 0x263B440 Offset: 0x2639A40 VA: 0x18263B440
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x263B570 Offset: 0x2639B70 VA: 0x18263B570
	public void SetTexture(Texture texture) { }

	// RVA: 0x263ADA0 Offset: 0x26393A0 VA: 0x18263ADA0
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x263B320 Offset: 0x2639920 VA: 0x18263B320
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x263A7A0 Offset: 0x2638DA0 VA: 0x18263A7A0
	public void Clear() { }

	// RVA: 0x263AB50 Offset: 0x2639150 VA: 0x18263AB50
	public float GetInheritedAlpha() { }

	// RVA: 0x263AFA0 Offset: 0x26395A0 VA: 0x18263AFA0
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x263AC10 Offset: 0x2639210 VA: 0x18263AC10
	public Material GetMaterial() { }

	// RVA: 0x263B680 Offset: 0x2639C80 VA: 0x18263B680
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x263A820 Offset: 0x2638E20 VA: 0x18263A820
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x263A6F0 Offset: 0x2638CF0 VA: 0x18263A6F0
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x263B630 Offset: 0x2639C30 VA: 0x18263B630
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x263A6F0 Offset: 0x2638CF0 VA: 0x18263A6F0
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x263A820 Offset: 0x2638E20 VA: 0x18263A820
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x263BDB0 Offset: 0x263A3B0 VA: 0x18263BDB0
	private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x263BA50 Offset: 0x263A050 VA: 0x18263BA50
	private static int get_materialCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x263BE90 Offset: 0x263A490 VA: 0x18263BE90
	private static void set_materialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x263BF60 Offset: 0x263A560 VA: 0x18263BF60
	private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x263B750 Offset: 0x2639D50 VA: 0x18263B750
	private static int get_absoluteDepth_Injected(IntPtr _unity_self) { }

	// RVA: 0x263B990 Offset: 0x2639F90 VA: 0x18263B990
	private static bool get_hasMoved_Injected(IntPtr _unity_self) { }

	// RVA: 0x263B810 Offset: 0x2639E10 VA: 0x18263B810
	private static bool get_cullTransparentMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x263BBF0 Offset: 0x263A1F0 VA: 0x18263BBF0
	private static void set_cullTransparentMesh_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x263B8D0 Offset: 0x2639ED0 VA: 0x18263B8D0
	private static bool get_cull_Injected(IntPtr _unity_self) { }

	// RVA: 0x263BCD0 Offset: 0x263A2D0 VA: 0x18263BCD0
	private static void set_cull_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x263AE60 Offset: 0x2639460 VA: 0x18263AE60
	private static void SetColor_Injected(IntPtr _unity_self, in Color color) { }

	// RVA: 0x263AA30 Offset: 0x2639030 VA: 0x18263AA30
	private static void GetColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x263A950 Offset: 0x2638F50 VA: 0x18263A950
	private static void EnableRectClipping_Injected(IntPtr _unity_self, in Rect rect) { }

	// RVA: 0x263BB10 Offset: 0x263A110 VA: 0x18263BB10
	private static void set_clippingSoftness_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x263A890 Offset: 0x2638E90 VA: 0x18263A890
	private static void DisableRectClipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x263AF40 Offset: 0x2639540 VA: 0x18263AF40
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x263ABD0 Offset: 0x26391D0 VA: 0x18263ABD0
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x263B3E0 Offset: 0x26399E0 VA: 0x18263B3E0
	private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x263B520 Offset: 0x2639B20 VA: 0x18263B520
	private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x263AD50 Offset: 0x2639350 VA: 0x18263AD50
	private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x263B2D0 Offset: 0x26398D0 VA: 0x18263B2D0
	private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh) { }

	// RVA: 0x263A760 Offset: 0x2638D60 VA: 0x18263A760
	private static void Clear_Injected(IntPtr _unity_self) { }

	// RVA: 0x263AB10 Offset: 0x2639110 VA: 0x18263AB10
	private static float GetInheritedAlpha_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Camera.h")]
[StaticAccessor("UI", 2)]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeHeader("Modules/UI/RectTransformUtil.h")]
[NativeHeader("Modules/UI/Canvas.h")]
public sealed class RectTransformUtility // TypeDefIndex: 13944
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x263E170 Offset: 0x263C770 VA: 0x18263E170
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x263E2C0 Offset: 0x263C8C0 VA: 0x18263E2C0
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x263E420 Offset: 0x263CA20 VA: 0x18263E420
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x263E640 Offset: 0x263CC40 VA: 0x18263E640
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x263E510 Offset: 0x263CB10 VA: 0x18263E510
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x263EA80 Offset: 0x263D080 VA: 0x18263EA80
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x263E7E0 Offset: 0x263CDE0 VA: 0x18263E7E0
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x263E900 Offset: 0x263CF00 VA: 0x18263E900
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x263EF30 Offset: 0x263D530 VA: 0x18263EF30
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x263DCA0 Offset: 0x263C2A0 VA: 0x18263DCA0
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x263DA40 Offset: 0x263C040 VA: 0x18263DA40
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x263E0E0 Offset: 0x263C6E0 VA: 0x18263E0E0
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x263F010 Offset: 0x263D610 VA: 0x18263F010
	private static void .cctor() { }

	// RVA: 0x263E100 Offset: 0x263C700 VA: 0x18263E100
	private static void PixelAdjustPoint_Injected(in Vector2 point, IntPtr elementTransform, IntPtr canvas, out Vector2 ret) { }

	// RVA: 0x263E260 Offset: 0x263C860 VA: 0x18263E260
	private static void PixelAdjustRect_Injected(IntPtr rectTransform, IntPtr canvas, out Rect ret) { }

	// RVA: 0x263E3B0 Offset: 0x263C9B0 VA: 0x18263E3B0
	private static bool PointInRectangle_Injected(in Vector2 screenPoint, IntPtr rect, IntPtr cam, in Vector4 offset) { }
}

// Namespace: UnityEngine
public enum RenderMode // TypeDefIndex: 13945
{
	// Fields
	public int value__; // 0x0
	public const RenderMode ScreenSpaceOverlay = 0;
	public const RenderMode ScreenSpaceCamera = 1;
	public const RenderMode WorldSpace = 2;
}

// Namespace: UnityEngine
[Flags]
public enum AdditionalCanvasShaderChannels // TypeDefIndex: 13946
{
	// Fields
	public int value__; // 0x0
	public const AdditionalCanvasShaderChannels None = 0;
	public const AdditionalCanvasShaderChannels TexCoord1 = 1;
	public const AdditionalCanvasShaderChannels TexCoord2 = 2;
	public const AdditionalCanvasShaderChannels TexCoord3 = 4;
	public const AdditionalCanvasShaderChannels Normal = 8;
	public const AdditionalCanvasShaderChannels Tangent = 16;
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeClass("UI::Canvas")]
[RequireComponent(typeof(RectTransform))]
public sealed class Canvas : Behaviour // TypeDefIndex: 13948
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases preWillRenderCanvases; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int> <externBeginRenderOverlays>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int, int> <externRenderOverlaysBefore>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int> <externEndRenderOverlays>k__BackingField; // 0x20

	// Properties
	public RenderMode renderMode { get; set; }
	public bool isRootCanvas { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool vertexColorAlwaysGammaSpace { get; }
	public bool pixelPerfect { get; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	internal static Action<int> externBeginRenderOverlays { get; set; }
	internal static Action<int, int> externRenderOverlaysBefore { get; set; }
	internal static Action<int> externEndRenderOverlays { get; set; }
	[NativeProperty("Camera", False, 0)]
	public Camera worldCamera { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x263C3E0 Offset: 0x263A9E0 VA: 0x18263C3E0
	public static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x263D1C0 Offset: 0x263B7C0 VA: 0x18263D1C0
	public static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x263C4A0 Offset: 0x263AAA0 VA: 0x18263C4A0
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x263D280 Offset: 0x263B880 VA: 0x18263D280
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x263CA20 Offset: 0x263B020 VA: 0x18263CA20
	public RenderMode get_renderMode() { }

	// RVA: 0x263D730 Offset: 0x263BD30 VA: 0x18263D730
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x263C720 Offset: 0x263AD20 VA: 0x18263C720
	public bool get_isRootCanvas() { }

	// RVA: 0x263CD60 Offset: 0x263B360 VA: 0x18263CD60
	public float get_scaleFactor() { }

	// RVA: 0x263D810 Offset: 0x263BE10 VA: 0x18263D810
	public void set_scaleFactor(float value) { }

	// RVA: 0x263C960 Offset: 0x263AF60 VA: 0x18263C960
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x263D660 Offset: 0x263BC60 VA: 0x18263D660
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x263D060 Offset: 0x263B660 VA: 0x18263D060
	public bool get_vertexColorAlwaysGammaSpace() { }

	// RVA: 0x263C8A0 Offset: 0x263AEA0 VA: 0x18263C8A0
	public bool get_pixelPerfect() { }

	// RVA: 0x263CAE0 Offset: 0x263B0E0 VA: 0x18263CAE0
	public int get_renderOrder() { }

	// RVA: 0x263C7E0 Offset: 0x263ADE0 VA: 0x18263C7E0
	public bool get_overrideSorting() { }

	// RVA: 0x263D580 Offset: 0x263BB80 VA: 0x18263D580
	public void set_overrideSorting(bool value) { }

	// RVA: 0x263CEE0 Offset: 0x263B4E0 VA: 0x18263CEE0
	public int get_sortingOrder() { }

	// RVA: 0x263D9B0 Offset: 0x263BFB0 VA: 0x18263D9B0
	public void set_sortingOrder(int value) { }

	// RVA: 0x263CFA0 Offset: 0x263B5A0 VA: 0x18263CFA0
	public int get_targetDisplay() { }

	// RVA: 0x263CE20 Offset: 0x263B420 VA: 0x18263CE20
	public int get_sortingLayerID() { }

	// RVA: 0x263D8E0 Offset: 0x263BEE0 VA: 0x18263D8E0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x263C5A0 Offset: 0x263ABA0 VA: 0x18263C5A0
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x263D380 Offset: 0x263B980 VA: 0x18263D380
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x263CC80 Offset: 0x263B280 VA: 0x18263CC80
	public Canvas get_rootCanvas() { }

	// RVA: 0x263CBB0 Offset: 0x263B1B0 VA: 0x18263CBB0
	public Vector2 get_renderingDisplaySize() { }

	[CompilerGenerated]
	// RVA: 0x263C620 Offset: 0x263AC20 VA: 0x18263C620
	internal static Action<int> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x263D410 Offset: 0x263BA10 VA: 0x18263D410
	internal static void set_externBeginRenderOverlays(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x263C6A0 Offset: 0x263ACA0 VA: 0x18263C6A0
	internal static Action<int, int> get_externRenderOverlaysBefore() { }

	[CompilerGenerated]
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x263D4D0 Offset: 0x263BAD0 VA: 0x18263D4D0
	internal static void set_externRenderOverlaysBefore(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x263C660 Offset: 0x263AC60 VA: 0x18263C660
	internal static Action<int> get_externEndRenderOverlays() { }

	[CompilerGenerated]
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x263D470 Offset: 0x263BA70 VA: 0x18263D470
	internal static void set_externEndRenderOverlays(Action<int> value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x263C3A0 Offset: 0x263A9A0 VA: 0x18263C3A0
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x263D120 Offset: 0x263B720 VA: 0x18263D120
	public Camera get_worldCamera() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	// RVA: 0x263C1B0 Offset: 0x263A7B0 VA: 0x18263C1B0
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	// RVA: 0x263C240 Offset: 0x263A840 VA: 0x18263C240
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x263C0F0 Offset: 0x263A6F0 VA: 0x18263C0F0
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x263C300 Offset: 0x263A900 VA: 0x18263C300
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x263C350 Offset: 0x263A950 VA: 0x18263C350
	private static void SendWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x263C030 Offset: 0x263A630 VA: 0x18263C030
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	// RVA: 0x263C2A0 Offset: 0x263A8A0 VA: 0x18263C2A0
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	// RVA: 0x263C090 Offset: 0x263A690 VA: 0x18263C090
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x263C9E0 Offset: 0x263AFE0 VA: 0x18263C9E0
	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x263D6F0 Offset: 0x263BCF0 VA: 0x18263D6F0
	private static void set_renderMode_Injected(IntPtr _unity_self, RenderMode value) { }

	// RVA: 0x263C6E0 Offset: 0x263ACE0 VA: 0x18263C6E0
	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x263CD20 Offset: 0x263B320 VA: 0x18263CD20
	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	// RVA: 0x263D7C0 Offset: 0x263BDC0 VA: 0x18263D7C0
	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x263C920 Offset: 0x263AF20 VA: 0x18263C920
	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	// RVA: 0x263D610 Offset: 0x263BC10 VA: 0x18263D610
	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x263D020 Offset: 0x263B620 VA: 0x18263D020
	private static bool get_vertexColorAlwaysGammaSpace_Injected(IntPtr _unity_self) { }

	// RVA: 0x263C860 Offset: 0x263AE60 VA: 0x18263C860
	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	// RVA: 0x263CAA0 Offset: 0x263B0A0 VA: 0x18263CAA0
	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x263C7A0 Offset: 0x263ADA0 VA: 0x18263C7A0
	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	// RVA: 0x263D530 Offset: 0x263BB30 VA: 0x18263D530
	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x263CEA0 Offset: 0x263B4A0 VA: 0x18263CEA0
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x263D970 Offset: 0x263BF70 VA: 0x18263D970
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x263CF60 Offset: 0x263B560 VA: 0x18263CF60
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	// RVA: 0x263CDE0 Offset: 0x263B3E0 VA: 0x18263CDE0
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x263D8A0 Offset: 0x263BEA0 VA: 0x18263D8A0
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x263C560 Offset: 0x263AB60 VA: 0x18263C560
	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	// RVA: 0x263D340 Offset: 0x263B940 VA: 0x18263D340
	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	// RVA: 0x263CC40 Offset: 0x263B240 VA: 0x18263CC40
	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x263CB60 Offset: 0x263B160 VA: 0x18263CB60
	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x263D0E0 Offset: 0x263B6E0 VA: 0x18263D0E0
	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	// RVA: 0x263C180 Offset: 0x263A780 VA: 0x18263C180
	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	// RVA: 0x263C210 Offset: 0x263A810 VA: 0x18263C210
	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }
}

// Namespace: UnityEngine
[StaticAccessor("UI::SystemProfilerApi", 2)]
[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
public static class UISystemProfilerApi // TypeDefIndex: 13950
{
	// Methods

	// RVA: 0x263F270 Offset: 0x263D870 VA: 0x18263F270
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x263F2B0 Offset: 0x263D8B0 VA: 0x18263F2B0
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x263F0D0 Offset: 0x263D6D0 VA: 0x18263F0D0
	public static void AddMarker(string name, Object obj) { }

	// RVA: 0x263F080 Offset: 0x263D680 VA: 0x18263F080
	private static void AddMarker_Injected(ref ManagedSpanWrapper name, IntPtr obj) { }
}

// Namespace: UnityEngine
public enum TouchPhase // TypeDefIndex: 13981
{
	// Fields
	public int value__; // 0x0
	public const TouchPhase Began = 0;
	public const TouchPhase Moved = 1;
	public const TouchPhase Stationary = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
}

// Namespace: UnityEngine
public enum IMECompositionMode // TypeDefIndex: 13982
{
	// Fields
	public int value__; // 0x0
	public const IMECompositionMode Auto = 0;
	public const IMECompositionMode On = 1;
	public const IMECompositionMode Off = 2;
}

// Namespace: UnityEngine
public enum TouchType // TypeDefIndex: 13983
{
	// Fields
	public int value__; // 0x0
	public const TouchType Direct = 0;
	public const TouchType Indirect = 1;
	public const TouchType Stylus = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch // TypeDefIndex: 13984
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; set; }
	public Vector2 rawPosition { get; set; }
	public Vector2 deltaPosition { get; set; }
	public float deltaTime { get; }
	public int tapCount { get; }
	public TouchPhase phase { get; }
	public float pressure { get; }
	public float maximumPossiblePressure { get; }
	public TouchType type { get; }
	public float altitudeAngle { get; }
	public float azimuthAngle { get; }
	public float radius { get; }
	public float radiusVariance { get; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public int get_fingerId() { }

	// RVA: 0x3A4A80 Offset: 0x3A3080 VA: 0x1803A4A80
	public Vector2 get_position() { }

	// RVA: 0x3A4C40 Offset: 0x3A3240 VA: 0x1803A4C40
	public void set_position(Vector2 value) { }

	// RVA: 0x3A4A50 Offset: 0x3A3050 VA: 0x1803A4A50
	public Vector2 get_rawPosition() { }

	// RVA: 0x3A4C20 Offset: 0x3A3220 VA: 0x1803A4C20
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x8641B0 Offset: 0x8627B0 VA: 0x1808641B0
	public Vector2 get_deltaPosition() { }

	// RVA: 0x23A5990 Offset: 0x23A3F90 VA: 0x1823A5990
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x23A8F40 Offset: 0x23A7540 VA: 0x1823A8F40
	public float get_deltaTime() { }

	// RVA: 0xA3D120 Offset: 0xA3B720 VA: 0x180A3D120
	public int get_tapCount() { }

	// RVA: 0x23A8F60 Offset: 0x23A7560 VA: 0x1823A8F60
	public TouchPhase get_phase() { }

	// RVA: 0x23A8F70 Offset: 0x23A7570 VA: 0x1823A8F70
	public float get_pressure() { }

	// RVA: 0x23A8F50 Offset: 0x23A7550 VA: 0x1823A8F50
	public float get_maximumPossiblePressure() { }

	// RVA: 0xA3D1A0 Offset: 0xA3B7A0 VA: 0x180A3D1A0
	public TouchType get_type() { }

	// RVA: 0x2173E70 Offset: 0x2172470 VA: 0x182173E70
	public float get_altitudeAngle() { }

	// RVA: 0x23A8F30 Offset: 0x23A7530 VA: 0x1823A8F30
	public float get_azimuthAngle() { }

	// RVA: 0x23A8F80 Offset: 0x23A7580 VA: 0x1823A8F80
	public float get_radius() { }

	// RVA: 0x2173FE0 Offset: 0x21725E0 VA: 0x182173FE0
	public float get_radiusVariance() { }
}

// Namespace: UnityEngine
[Flags]
public enum PenStatus // TypeDefIndex: 13985
{
	// Fields
	public int value__; // 0x0
	public const PenStatus None = 0;
	public const PenStatus Contact = 1;
	public const PenStatus Barrel = 2;
	public const PenStatus Inverted = 4;
	public const PenStatus Eraser = 8;
}

// Namespace: UnityEngine
public enum PenEventType // TypeDefIndex: 13986
{
	// Fields
	public int value__; // 0x0
	public const PenEventType NoContact = 0;
	public const PenEventType PenDown = 1;
	public const PenEventType PenUp = 2;
}

// Namespace: UnityEngine
public struct PenData // TypeDefIndex: 13987
{
	// Fields
	public Vector2 position; // 0x0
	public Vector2 tilt; // 0x8
	public PenStatus penStatus; // 0x10
	public float twist; // 0x14
	public float pressure; // 0x18
	public PenEventType contactType; // 0x1C
	public Vector2 deltaPos; // 0x20
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Camera.h")]
internal class CameraRaycastHelper // TypeDefIndex: 13988
{
	// Methods

	[FreeFunction("CameraScripting::RaycastTry")]
	// RVA: 0x23A5E60 Offset: 0x23A4460 VA: 0x1823A5E60
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	// RVA: 0x23A5D30 Offset: 0x23A4330 VA: 0x1823A5D30
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x23A5DF0 Offset: 0x23A43F0 VA: 0x1823A5DF0
	private static IntPtr RaycastTry_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }

	// RVA: 0x23A5CC0 Offset: 0x23A42C0 VA: 0x1823A5CC0
	private static IntPtr RaycastTry2D_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input // TypeDefIndex: 13989
{
	// Properties
	public static bool simulateMouseWithTouches { get; set; }
	[NativeThrows]
	public static bool anyKey { get; }
	[NativeThrows]
	public static Vector3 mousePosition { get; }
	[NativeThrows]
	public static Vector3 mousePositionDelta { get; }
	[NativeThrows]
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchPressureSupported { get; }
	public static bool touchSupported { get; }
	public static bool multiTouchEnabled { get; set; }
	public static Vector3 acceleration { get; }
	public static Touch[] touches { get; }

	// Methods

	// RVA: 0x23A6BB0 Offset: 0x23A51B0 VA: 0x1823A6BB0
	public static float GetAxis(string axisName) { }

	// RVA: 0x23A6BA0 Offset: 0x23A51A0 VA: 0x1823A6BA0
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x23A6BE0 Offset: 0x23A51E0 VA: 0x1823A6BE0
	public static bool GetButton(string buttonName) { }

	// RVA: 0x23A6BC0 Offset: 0x23A51C0 VA: 0x1823A6BC0
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x23A6BD0 Offset: 0x23A51D0 VA: 0x1823A6BD0
	public static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x23A6C60 Offset: 0x23A5260 VA: 0x1823A6C60
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x23A6CA0 Offset: 0x23A52A0 VA: 0x1823A6CA0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x23A6C20 Offset: 0x23A5220 VA: 0x1823A6C20
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x23A6DF0 Offset: 0x23A53F0 VA: 0x1823A6DF0
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	// RVA: 0x23A6D70 Offset: 0x23A5370 VA: 0x1823A6D70
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	// RVA: 0x23A6DB0 Offset: 0x23A53B0 VA: 0x1823A6DB0
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	// RVA: 0x23A6BF0 Offset: 0x23A51F0 VA: 0x1823A6BF0
	public static string[] GetJoystickNames() { }

	[NativeThrows]
	// RVA: 0x23A6E70 Offset: 0x23A5470 VA: 0x1823A6E70
	public static Touch GetTouch(int index) { }

	[NativeThrows]
	// RVA: 0x23A6D20 Offset: 0x23A5320 VA: 0x1823A6D20
	public static PenData GetLastPenContactEvent() { }

	[NativeThrows]
	// RVA: 0x23A6B70 Offset: 0x23A5170 VA: 0x1823A6B70
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x23A6C60 Offset: 0x23A5260 VA: 0x1823A6C60
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x23A6CA0 Offset: 0x23A52A0 VA: 0x1823A6CA0
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x23A6C20 Offset: 0x23A5220 VA: 0x1823A6C20
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x23A7300 Offset: 0x23A5900 VA: 0x1823A7300
	public static bool get_simulateMouseWithTouches() { }

	// RVA: 0x23A75F0 Offset: 0x23A5BF0 VA: 0x1823A75F0
	public static void set_simulateMouseWithTouches(bool value) { }

	// RVA: 0x23A6F50 Offset: 0x23A5550 VA: 0x1823A6F50
	public static bool get_anyKey() { }

	// RVA: 0x23A71E0 Offset: 0x23A57E0 VA: 0x1823A71E0
	public static Vector3 get_mousePosition() { }

	// RVA: 0x23A7160 Offset: 0x23A5760 VA: 0x1823A7160
	public static Vector3 get_mousePositionDelta() { }

	// RVA: 0x23A7290 Offset: 0x23A5890 VA: 0x1823A7290
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x23A70F0 Offset: 0x23A56F0 VA: 0x1823A70F0
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x23A7570 Offset: 0x23A5B70 VA: 0x1823A7570
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x23A7040 Offset: 0x23A5640 VA: 0x1823A7040
	public static string get_compositionString() { }

	// RVA: 0x23A6FC0 Offset: 0x23A55C0 VA: 0x1823A6FC0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x23A7530 Offset: 0x23A5B30 VA: 0x1823A7530
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunction("GetMousePresent")]
	// RVA: 0x23A7220 Offset: 0x23A5820 VA: 0x1823A7220
	public static bool get_mousePresent() { }

	[FreeFunction("GetTouchCount")]
	// RVA: 0x23A7330 Offset: 0x23A5930 VA: 0x1823A7330
	public static int get_touchCount() { }

	[FreeFunction("IsTouchPressureSupported")]
	// RVA: 0x23A7360 Offset: 0x23A5960 VA: 0x1823A7360
	public static bool get_touchPressureSupported() { }

	[FreeFunction("IsTouchSupported")]
	// RVA: 0x23A7390 Offset: 0x23A5990 VA: 0x1823A7390
	public static bool get_touchSupported() { }

	[FreeFunction("IsMultiTouchEnabled")]
	// RVA: 0x23A72D0 Offset: 0x23A58D0 VA: 0x1823A72D0
	public static bool get_multiTouchEnabled() { }

	[FreeFunction("SetMultiTouchEnabled")]
	// RVA: 0x23A75B0 Offset: 0x23A5BB0 VA: 0x1823A75B0
	public static void set_multiTouchEnabled(bool value) { }

	[FreeFunction("GetAcceleration")]
	// RVA: 0x23A6F10 Offset: 0x23A5510 VA: 0x1823A6F10
	public static Vector3 get_acceleration() { }

	// RVA: 0x23A73C0 Offset: 0x23A59C0 VA: 0x1823A73C0
	public static Touch[] get_touches() { }

	// RVA: 0x23A6B40 Offset: 0x23A5140 VA: 0x1823A6B40
	internal static bool CheckDisabled() { }

	// RVA: 0x23A6E30 Offset: 0x23A5430 VA: 0x1823A6E30
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x23A6CE0 Offset: 0x23A52E0 VA: 0x1823A6CE0
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	// RVA: 0x23A71A0 Offset: 0x23A57A0 VA: 0x1823A71A0
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x23A7120 Offset: 0x23A5720 VA: 0x1823A7120
	private static void get_mousePositionDelta_Injected(out Vector3 ret) { }

	// RVA: 0x23A7250 Offset: 0x23A5850 VA: 0x1823A7250
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x23A7000 Offset: 0x23A5600 VA: 0x1823A7000
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x23A6F80 Offset: 0x23A5580 VA: 0x1823A6F80
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x23A74F0 Offset: 0x23A5AF0 VA: 0x1823A74F0
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }

	// RVA: 0x23A6ED0 Offset: 0x23A54D0 VA: 0x1823A6ED0
	private static void get_acceleration_Injected(out Vector3 ret) { }
}

// Namespace: UnityEngine
internal class SendMouseEvents // TypeDefIndex: 13991
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x23A8BC0 Offset: 0x23A71C0 VA: 0x1823A8BC0
	private static void UpdateMouse() { }

	[RequiredByNativeCode]
	// RVA: 0x23A8B70 Offset: 0x23A7170 VA: 0x1823A8B70
	private static void SetMouseMoved() { }

	[RequiredByNativeCode]
	// RVA: 0x23A7630 Offset: 0x23A5C30 VA: 0x1823A7630
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x23A8230 Offset: 0x23A6830 VA: 0x1823A8230
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x23A8E30 Offset: 0x23A7430 VA: 0x1823A8E30
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum FontStyle // TypeDefIndex: 14017
{
	// Fields
	public int value__; // 0x0
	public const FontStyle Normal = 0;
	public const FontStyle Bold = 1;
	public const FontStyle Italic = 2;
	public const FontStyle BoldAndItalic = 3;
}

// Namespace: UnityEngine
[Flags]
internal enum TextGenerationError // TypeDefIndex: 14018
{
	// Fields
	public int value__; // 0x0
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

// Namespace: UnityEngine
public struct TextGenerationSettings // TypeDefIndex: 14019
{
	// Fields
	public Font font; // 0x0
	public Color color; // 0x8
	public int fontSize; // 0x18
	public float lineSpacing; // 0x1C
	public bool richText; // 0x20
	public float scaleFactor; // 0x24
	public FontStyle fontStyle; // 0x28
	public TextAnchor textAnchor; // 0x2C
	public bool alignByGeometry; // 0x30
	public bool resizeTextForBestFit; // 0x31
	public int resizeTextMinSize; // 0x34
	public int resizeTextMaxSize; // 0x38
	public bool updateBounds; // 0x3C
	public VerticalWrapMode verticalOverflow; // 0x40
	public HorizontalWrapMode horizontalOverflow; // 0x44
	public Vector2 generationExtents; // 0x48
	public Vector2 pivot; // 0x50
	public bool generateOutOfBounds; // 0x58

	// Methods

	// RVA: 0x2433B60 Offset: 0x2432160 VA: 0x182433B60
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x2433BE0 Offset: 0x24321E0 VA: 0x182433BE0
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x2433C30 Offset: 0x2432230 VA: 0x182433C30
	public bool Equals(TextGenerationSettings other) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable // TypeDefIndex: 14021
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x2435870 Offset: 0x2433E70 VA: 0x182435870
	public void .ctor() { }

	// RVA: 0x2435710 Offset: 0x2433D10 VA: 0x182435710
	public void .ctor(int initialCapacity) { }

	// RVA: 0x2433F00 Offset: 0x2432500 VA: 0x182433F00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2435310 Offset: 0x2433910 VA: 0x182435310 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x24359C0 Offset: 0x2433FC0 VA: 0x1824359C0
	public int get_characterCountVisible() { }

	// RVA: 0x2435360 Offset: 0x2433960 VA: 0x182435360
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x2434410 Offset: 0x2432A10 VA: 0x182434410
	public void Invalidate() { }

	// RVA: 0x2434030 Offset: 0x2432630 VA: 0x182434030
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x24340E0 Offset: 0x24326E0 VA: 0x1824340E0
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x2434340 Offset: 0x2432940 VA: 0x182434340
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x2434210 Offset: 0x2432810 VA: 0x182434210
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x2434140 Offset: 0x2432740 VA: 0x182434140
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x2434A90 Offset: 0x2433090 VA: 0x182434A90
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x24352B0 Offset: 0x24338B0 VA: 0x1824352B0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x2434720 Offset: 0x2432D20 VA: 0x182434720
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x2434420 Offset: 0x2432A20 VA: 0x182434420
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x2435D40 Offset: 0x2434340 VA: 0x182435D40
	public IList<UIVertex> get_verts() { }

	// RVA: 0x2435AC0 Offset: 0x24340C0 VA: 0x182435AC0
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x2435BF0 Offset: 0x24341F0 VA: 0x182435BF0
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x2435CD0 Offset: 0x24342D0 VA: 0x182435CD0
	public Rect get_rectExtents() { }

	// RVA: 0x2435A60 Offset: 0x2434060 VA: 0x182435A60
	public int get_characterCount() { }

	// RVA: 0x2435B90 Offset: 0x2434190 VA: 0x182435B90
	public int get_lineCount() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x24343A0 Offset: 0x24329A0 VA: 0x1824343A0
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x24343D0 Offset: 0x24329D0 VA: 0x1824343D0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2434F60 Offset: 0x2433560 VA: 0x182434F60
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x2434D80 Offset: 0x2433380 VA: 0x182434D80
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrows]
	// RVA: 0x2434340 Offset: 0x2432940 VA: 0x182434340
	private void GetVerticesInternal(object vertices) { }

	[NativeThrows]
	// RVA: 0x2434030 Offset: 0x2432630 VA: 0x182434030
	private void GetCharactersInternal(object characters) { }

	[NativeThrows]
	// RVA: 0x24340E0 Offset: 0x24326E0 VA: 0x1824340E0
	private void GetLinesInternal(object lines) { }

	// RVA: 0x2435C80 Offset: 0x2434280 VA: 0x182435C80
	private static void get_rectExtents_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x2435A20 Offset: 0x2434020 VA: 0x182435A20
	private static int get_characterCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x2435B50 Offset: 0x2434150 VA: 0x182435B50
	private static int get_lineCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x2434CC0 Offset: 0x24332C0 VA: 0x182434CC0
	private static bool Populate_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper str, IntPtr font, in Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x24342F0 Offset: 0x24328F0 VA: 0x1824342F0
	private static void GetVerticesInternal_Injected(IntPtr _unity_self, object vertices) { }

	// RVA: 0x2433FE0 Offset: 0x24325E0 VA: 0x182433FE0
	private static void GetCharactersInternal_Injected(IntPtr _unity_self, object characters) { }

	// RVA: 0x2434090 Offset: 0x2432690 VA: 0x182434090
	private static void GetLinesInternal_Injected(IntPtr _unity_self, object lines) { }
}

// Namespace: UnityEngine
public enum TextAlignment // TypeDefIndex: 14022
{
	// Fields
	public int value__; // 0x0
	public const TextAlignment Left = 0;
	public const TextAlignment Center = 1;
	public const TextAlignment Right = 2;
}

// Namespace: UnityEngine
public enum TextAnchor // TypeDefIndex: 14023
{
	// Fields
	public int value__; // 0x0
	public const TextAnchor UpperLeft = 0;
	public const TextAnchor UpperCenter = 1;
	public const TextAnchor UpperRight = 2;
	public const TextAnchor MiddleLeft = 3;
	public const TextAnchor MiddleCenter = 4;
	public const TextAnchor MiddleRight = 5;
	public const TextAnchor LowerLeft = 6;
	public const TextAnchor LowerCenter = 7;
	public const TextAnchor LowerRight = 8;
}

// Namespace: UnityEngine
public enum HorizontalWrapMode // TypeDefIndex: 14024
{
	// Fields
	public int value__; // 0x0
	public const HorizontalWrapMode Wrap = 0;
	public const HorizontalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public enum VerticalWrapMode // TypeDefIndex: 14025
{
	// Fields
	public int value__; // 0x0
	public const VerticalWrapMode Truncate = 0;
	public const VerticalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UICharInfo // TypeDefIndex: 14026
{
	// Fields
	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UILineInfo // TypeDefIndex: 14027
{
	// Fields
	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UIVertex // TypeDefIndex: 14028
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector4 uv0; // 0x2C
	public Vector4 uv1; // 0x3C
	public Vector4 uv2; // 0x4C
	public Vector4 uv3; // 0x5C
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x2435DD0 Offset: 0x24343D0 VA: 0x182435DD0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("TextRenderingPrivate", 2)]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[NativeClass("TextRendering::Font")]
public sealed class Font : Object // TypeDefIndex: 14030
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24336A0 Offset: 0x2431CA0 VA: 0x1824336A0
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x2433A80 Offset: 0x2432080 VA: 0x182433A80
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x2433940 Offset: 0x2431F40 VA: 0x182433940
	public Material get_material() { }

	// RVA: 0x24337C0 Offset: 0x2431DC0 VA: 0x1824337C0
	public bool get_dynamic() { }

	// RVA: 0x2433880 Offset: 0x2431E80 VA: 0x182433880
	public int get_fontSize() { }

	[RequiredByNativeCode]
	// RVA: 0x2433620 Offset: 0x2431C20 VA: 0x182433620
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x2433500 Offset: 0x2431B00 VA: 0x182433500
	public bool HasCharacter(char c) { }

	// RVA: 0x2433590 Offset: 0x2431B90 VA: 0x182433590
	private bool HasCharacter(int c) { }

	// RVA: 0x2433490 Offset: 0x2431A90 VA: 0x182433490
	public static string[] GetPathsToOSFonts() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x2433460 Offset: 0x2431A60 VA: 0x182433460
	internal static string[] GetOSFallbacks() { }

	// RVA: 0x2433900 Offset: 0x2431F00 VA: 0x182433900
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	// RVA: 0x2433780 Offset: 0x2431D80 VA: 0x182433780
	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	// RVA: 0x2433840 Offset: 0x2431E40 VA: 0x182433840
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x24334C0 Offset: 0x2431AC0 VA: 0x1824334C0
	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 14052
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x23B0230 Offset: 0x23AE830 VA: 0x1823B0230 Slot: 3
	public override string ToString() { }

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23AF620 Offset: 0x23ADC20 VA: 0x1823AF620 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x22F28A0 Offset: 0x22F0EA0 VA: 0x1822F28A0 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x23B0010 Offset: 0x23AE610 VA: 0x1823B0010
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x23B0150 Offset: 0x23AE750 VA: 0x1823B0150
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x23AFE60 Offset: 0x23AE460 VA: 0x1823AFE60
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x23AFFB0 Offset: 0x23AE5B0 VA: 0x1823AFFB0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("Raycast_Binding")]
	// RVA: 0x23AFDE0 Offset: 0x23AE3E0 VA: 0x1823AFDE0
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastArray_Binding")]
	// RVA: 0x23AF9E0 Offset: 0x23ADFE0 VA: 0x1823AF9E0
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethod("RaycastList_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x23AFB70 Offset: 0x23AE170 VA: 0x1823AFB70
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x23AF830 Offset: 0x23ADE30 VA: 0x1823AF830
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRayIntersectionArray_Binding")]
	// RVA: 0x23AF710 Offset: 0x23ADD10 VA: 0x1823AF710
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x23AFD70 Offset: 0x23AE370 VA: 0x1823AFD70
	private static void Raycast_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x23AF970 Offset: 0x23ADF70 VA: 0x1823AF970
	private static int RaycastArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref ManagedSpanWrapper results) { }

	// RVA: 0x23AFB00 Offset: 0x23AE100 VA: 0x1823AFB00
	private static int RaycastList_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref BlittableListWrapper results) { }

	// RVA: 0x23AF6A0 Offset: 0x23ADCA0 VA: 0x1823AF6A0
	private static int GetRayIntersectionArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, ref ManagedSpanWrapper results) { }
}

// Namespace: UnityEngine
[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[StaticAccessor("GetPhysicsManager2D()", 1)]
[NativeHeader("Physics2DScriptingClasses.h")]
public class Physics2D // TypeDefIndex: 14053
{
	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0xA6D740 Offset: 0xA6BD40 VA: 0x180A6D740
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x23AF5F0 Offset: 0x23ADBF0 VA: 0x1823AF5F0
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocs]
	// RVA: 0x23AF400 Offset: 0x23ADA00 VA: 0x1823AF400
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	// RVA: 0x23AF0C0 Offset: 0x23AD6C0 VA: 0x1823AF0C0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x23AED90 Offset: 0x23AD390 VA: 0x1823AED90
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x23AF260 Offset: 0x23AD860 VA: 0x1823AF260
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x23AEA50 Offset: 0x23AD050 VA: 0x1823AEA50
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	// RVA: 0x23AEBF0 Offset: 0x23AD1F0 VA: 0x1823AEBF0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x23AEF20 Offset: 0x23AD520 VA: 0x1823AEF20
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x23AF1A0 Offset: 0x23AD7A0 VA: 0x1823AF1A0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocs]
	// RVA: 0x23AE4F0 Offset: 0x23ACAF0 VA: 0x1823AE4F0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocs]
	// RVA: 0x23AE450 Offset: 0x23ACA50 VA: 0x1823AE450
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x23AE3B0 Offset: 0x23AC9B0 VA: 0x1823AE3B0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x23AE270 Offset: 0x23AC870 VA: 0x1823AE270
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[RequiredByNativeCode]
	// RVA: 0x23AE720 Offset: 0x23ACD20 VA: 0x1823AE720
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	[ExcludeFromDocs]
	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	[EditorBrowsable(1)]
	// RVA: 0x23AE8C0 Offset: 0x23ACEC0 VA: 0x1823AE8C0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	[EditorBrowsable(1)]
	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	// RVA: 0x23AE580 Offset: 0x23ACB80 VA: 0x1823AE580
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	// RVA: 0x23AF560 Offset: 0x23ADB60 VA: 0x1823AF560
	private static void .cctor() { }

	// RVA: 0x23AE200 Offset: 0x23AC800 VA: 0x1823AE200
	private static void GetRayIntersectionAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret) { }
}

// Namespace: UnityEngine
public enum RigidbodyInterpolation2D // TypeDefIndex: 14054
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyInterpolation2D None = 0;
	public const RigidbodyInterpolation2D Interpolate = 1;
	public const RigidbodyInterpolation2D Extrapolate = 2;
}

// Namespace: UnityEngine
public enum RigidbodySleepMode2D // TypeDefIndex: 14055
{
	// Fields
	public int value__; // 0x0
	public const RigidbodySleepMode2D NeverSleep = 0;
	public const RigidbodySleepMode2D StartAwake = 1;
	public const RigidbodySleepMode2D StartAsleep = 2;
}

// Namespace: UnityEngine
public enum CollisionDetectionMode2D // TypeDefIndex: 14056
{
	// Fields
	public int value__; // 0x0
	[EditorBrowsable(1)]
	[Obsolete("Enum member CollisionDetectionMode2D.None has been deprecated. Use CollisionDetectionMode2D.Discrete instead (UnityUpgradable) -> Discrete", True)]
	public const CollisionDetectionMode2D None = 0;
	public const CollisionDetectionMode2D Discrete = 0;
	public const CollisionDetectionMode2D Continuous = 1;
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("ContactFilter", "struct ContactFilter;")]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[Serializable]
public struct ContactFilter2D // TypeDefIndex: 14057
{
	// Fields
	[NativeName("m_UseTriggers")]
	public bool useTriggers; // 0x0
	[NativeName("m_UseLayerMask")]
	public bool useLayerMask; // 0x1
	[NativeName("m_UseDepth")]
	public bool useDepth; // 0x2
	[NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth; // 0x3
	[NativeName("m_UseNormalAngle")]
	public bool useNormalAngle; // 0x4
	[NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle; // 0x5
	[NativeName("m_LayerMask")]
	public LayerMask layerMask; // 0x8
	[NativeName("m_MinDepth")]
	public float minDepth; // 0xC
	[NativeName("m_MaxDepth")]
	public float maxDepth; // 0x10
	[NativeName("m_MinNormalAngle")]
	public float minNormalAngle; // 0x14
	[NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle; // 0x18

	// Methods

	// RVA: 0x23AE050 Offset: 0x23AC650 VA: 0x1823AE050
	private void CheckConsistency() { }

	// RVA: 0x23AE1F0 Offset: 0x23AC7F0 VA: 0x1823AE1F0
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x23AE1A0 Offset: 0x23AC7A0 VA: 0x1823AE1A0
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x23AE090 Offset: 0x23AC690 VA: 0x1823AE090
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class Collision2D // TypeDefIndex: 14058
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38
}

// Namespace: UnityEngine
[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[RequiredByNativeCode(Optional = False, GenerateProxy = True)]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
public struct ContactPoint2D // TypeDefIndex: 14059
{
	// Fields
	[NativeName("point")]
	private Vector2 m_Point; // 0x0
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x8
	[NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity; // 0x10
	[NativeName("separation")]
	private float m_Separation; // 0x18
	[NativeName("normalImpulse")]
	private float m_NormalImpulse; // 0x1C
	[NativeName("tangentImpulse")]
	private float m_TangentImpulse; // 0x20
	[NativeName("collider")]
	private int m_Collider; // 0x24
	[NativeName("otherCollider")]
	private int m_OtherCollider; // 0x28
	[NativeName("rigidbody")]
	private int m_Rigidbody; // 0x2C
	[NativeName("otherRigidbody")]
	private int m_OtherRigidbody; // 0x30
	[NativeName("enabled")]
	private int m_Enabled; // 0x34
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
public struct RaycastHit2D // TypeDefIndex: 14060
{
	// Fields
	[NativeName("centroid")]
	private Vector2 m_Centroid; // 0x0
	[NativeName("point")]
	private Vector2 m_Point; // 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x10
	[NativeName("distance")]
	private float m_Distance; // 0x18
	[NativeName("fraction")]
	private float m_Fraction; // 0x1C
	[NativeName("collider")]
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x16ADB70 Offset: 0x16AC170 VA: 0x1816ADB70
	public Vector2 get_point() { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	public Vector2 get_normal() { }

	// RVA: 0x23B03B0 Offset: 0x23AE9B0 VA: 0x1823B03B0
	public float get_distance() { }

	// RVA: 0x23B0300 Offset: 0x23AE900 VA: 0x1823B0300
	public Collider2D get_collider() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component // TypeDefIndex: 14061
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True)]
[RequireComponent(typeof(Transform))]
public class Collider2D : Behaviour // TypeDefIndex: 14062
{}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
[NativeHeader("Modules/Physics2D/Joint2D.h")]
public class Joint2D : Behaviour // TypeDefIndex: 14063
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
public sealed class PhysicsMaterial2D : Object // TypeDefIndex: 14064
{}

// Namespace: UnityEngine
[StaticAccessor("GetITerrainManager()", 1)]
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
[UsedByNativeCode]
public sealed class Terrain : Behaviour // TypeDefIndex: 14066
{
	// Properties
	public TerrainData terrainData { get; }
	public Material materialTemplate { set; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains { get; }

	// Methods

	// RVA: 0x23E3C80 Offset: 0x23E2280 VA: 0x1823E3C80
	public TerrainData get_terrainData() { }

	// RVA: 0x23E3E10 Offset: 0x23E2410 VA: 0x1823E3E10
	public void set_materialTemplate(Material value) { }

	// RVA: 0x23E3B00 Offset: 0x23E2100 VA: 0x1823E3B00
	public bool get_allowAutoConnect() { }

	// RVA: 0x23E3BC0 Offset: 0x23E21C0 VA: 0x1823E3BC0
	public int get_groupingID() { }

	// RVA: 0x23E3940 Offset: 0x23E1F40 VA: 0x1823E3940
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x23E3A90 Offset: 0x23E2090 VA: 0x1823E3A90
	public static Terrain[] get_activeTerrains() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	// RVA: 0x23E3C40 Offset: 0x23E2240 VA: 0x1823E3C40
	private static IntPtr get_terrainData_Injected(IntPtr _unity_self) { }

	// RVA: 0x23E3DC0 Offset: 0x23E23C0 VA: 0x1823E3DC0
	private static void set_materialTemplate_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x23E3AC0 Offset: 0x23E20C0 VA: 0x1823E3AC0
	private static bool get_allowAutoConnect_Injected(IntPtr _unity_self) { }

	// RVA: 0x23E3B80 Offset: 0x23E2180 VA: 0x1823E3B80
	private static int get_groupingID_Injected(IntPtr _unity_self) { }

	// RVA: 0x23E38D0 Offset: 0x23E1ED0 VA: 0x1823E38D0
	private static void SetNeighbors_Injected(IntPtr _unity_self, IntPtr left, IntPtr top, IntPtr right, IntPtr bottom) { }
}

// Namespace: UnityEngine
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainCallbacks // TypeDefIndex: 14069
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23E11C0 Offset: 0x23DF7C0 VA: 0x1823E11C0
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCode]
	// RVA: 0x23E1320 Offset: 0x23DF920 VA: 0x1823E1320
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
public sealed class TerrainData : Object // TypeDefIndex: 14071
{
	// Fields
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MinimumAlphamapResolution; // 0x10
	internal static readonly int k_MaximumAlphamapResolution; // 0x14
	internal static readonly int k_MinimumBaseMapResolution; // 0x18
	internal static readonly int k_MaximumBaseMapResolution; // 0x1C

	// Properties
	public Vector3 size { get; }
	internal Terrain[] users { get; }

	// Methods

	[ThreadSafe]
	[StaticAccessor("TerrainDataScriptingInterface", 2)]
	// RVA: 0x23E1570 Offset: 0x23DFB70 VA: 0x1823E1570
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	[NativeName("GetHeightmap().GetSize")]
	// RVA: 0x23E17E0 Offset: 0x23DFDE0 VA: 0x1823E17E0
	public Vector3 get_size() { }

	[RequiredByNativeCode]
	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	// RVA: 0x23E14D0 Offset: 0x23DFAD0 VA: 0x1823E14D0
	internal float GetAlphamapResolutionInternal() { }

	// RVA: 0x23E18E0 Offset: 0x23DFEE0 VA: 0x1823E18E0
	internal Terrain[] get_users() { }

	// RVA: 0x23E15B0 Offset: 0x23DFBB0 VA: 0x1823E15B0
	private static void .cctor() { }

	// RVA: 0x23E1790 Offset: 0x23DFD90 VA: 0x1823E1790
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x23E1490 Offset: 0x23DFA90 VA: 0x1823E1490
	private static float GetAlphamapResolutionInternal_Injected(IntPtr _unity_self) { }

	// RVA: 0x23E18A0 Offset: 0x23DFEA0 VA: 0x1823E18A0
	private static Terrain[] get_users_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
public enum AudioDataLoadState // TypeDefIndex: 14095
{
	// Fields
	public int value__; // 0x0
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;
}

// Namespace: UnityEngine
[StaticAccessor("GetAudioManager()", 0)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
public sealed class AudioSettings // TypeDefIndex: 14097
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemShuttingDown; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemStartedUp; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x22EC2E0 Offset: 0x22EA8E0 VA: 0x1822EC2E0
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x22EC340 Offset: 0x22EA940 VA: 0x1822EC340
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	// RVA: 0x22EC390 Offset: 0x22EA990 VA: 0x1822EC390
	internal static void InvokeOnAudioSystemStartedUp() { }
}

// Namespace: UnityEngine
[StaticAccessor("AudioClipBindings", 2)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
public sealed class AudioClip : AudioResource // TypeDefIndex: 14100
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativeProperty("LengthSec")]
	public float length { get; }
	public AudioDataLoadState loadState { get; }

	// Methods

	// RVA: 0x22EBD00 Offset: 0x22EA300 VA: 0x1822EBD00
	public float get_length() { }

	// RVA: 0x22EBB80 Offset: 0x22EA180 VA: 0x1822EBB80
	public bool LoadAudioData() { }

	// RVA: 0x22EBC40 Offset: 0x22EA240 VA: 0x1822EBC40
	public bool UnloadAudioData() { }

	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	// RVA: 0x22EBDC0 Offset: 0x22EA3C0 VA: 0x1822EBDC0
	public AudioDataLoadState get_loadState() { }

	[RequiredByNativeCode]
	// RVA: 0x22EBB00 Offset: 0x22EA100 VA: 0x1822EBB00
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	// RVA: 0x22EBB20 Offset: 0x22EA120 VA: 0x1822EBB20
	private void InvokePCMSetPositionCallback_Internal(int position) { }

	// RVA: 0x22EBCC0 Offset: 0x22EA2C0 VA: 0x1822EBCC0
	private static float get_length_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EBB40 Offset: 0x22EA140 VA: 0x1822EBB40
	private static bool LoadAudioData_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EBC00 Offset: 0x22EA200 VA: 0x1822EBC00
	private static bool UnloadAudioData_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EBD80 Offset: 0x22EA380 VA: 0x1822EBD80
	private static AudioDataLoadState get_loadState_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
public class AudioBehaviour : Behaviour // TypeDefIndex: 14101
{}

// Namespace: UnityEngine
[StaticAccessor("AudioListenerBindings", 2)]
[RequireComponent(typeof(Transform))]
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 14102
{}

// Namespace: UnityEngine
[StaticAccessor("AudioSourceBindings", 2)]
[RequireComponent(typeof(Transform))]
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 14103
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativeProperty("SecPosition")]
	public float time { get; }
	[NativeProperty("AudioClip")]
	public AudioClip clip { set; }
	public bool isPlaying { get; }
	public bool loop { set; }

	// Methods

	// RVA: 0x22EC420 Offset: 0x22EAA20 VA: 0x1822EC420
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x22ECDB0 Offset: 0x22EB3B0 VA: 0x1822ECDB0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x22EC670 Offset: 0x22EAC70 VA: 0x1822EC670
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x22ECC30 Offset: 0x22EB230 VA: 0x1822ECC30
	private void Play(double delay) { }

	// RVA: 0x22EC780 Offset: 0x22EAD80 VA: 0x1822EC780
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x22ECF30 Offset: 0x22EB530 VA: 0x1822ECF30
	private void Stop(bool stopOneShots) { }

	// RVA: 0x22ED240 Offset: 0x22EB840 VA: 0x1822ED240
	public float get_volume() { }

	// RVA: 0x22ED500 Offset: 0x22EBB00 VA: 0x1822ED500
	public void set_volume(float value) { }

	// RVA: 0x22EC420 Offset: 0x22EAA20 VA: 0x1822EC420
	public float get_pitch() { }

	// RVA: 0x22ECDB0 Offset: 0x22EB3B0 VA: 0x1822ECDB0
	public void set_pitch(float value) { }

	// RVA: 0x22ED180 Offset: 0x22EB780 VA: 0x1822ED180
	public float get_time() { }

	// RVA: 0x22ED310 Offset: 0x22EB910 VA: 0x1822ED310
	public void set_clip(AudioClip value) { }

	[ExcludeFromDocs]
	// RVA: 0x22ECCC0 Offset: 0x22EB2C0 VA: 0x1822ECCC0
	public void Play() { }

	// RVA: 0x22EC580 Offset: 0x22EAB80 VA: 0x1822EC580
	public void PlayDelayed(float delay) { }

	[ExcludeFromDocs]
	// RVA: 0x22EC890 Offset: 0x22EAE90 VA: 0x1822EC890
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x22ECA30 Offset: 0x22EB030 VA: 0x1822ECA30
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x22ECEB0 Offset: 0x22EB4B0 VA: 0x1822ECEB0
	public void Stop() { }

	// RVA: 0x22EC500 Offset: 0x22EAB00 VA: 0x1822EC500
	public void Pause() { }

	// RVA: 0x22ED000 Offset: 0x22EB600 VA: 0x1822ED000
	public void UnPause() { }

	[NativeName("IsPlayingScripting")]
	// RVA: 0x22ED0C0 Offset: 0x22EB6C0 VA: 0x1822ED0C0
	public bool get_isPlaying() { }

	// RVA: 0x22ED420 Offset: 0x22EBA20 VA: 0x1822ED420
	public void set_loop(bool value) { }

	// RVA: 0x22EC3E0 Offset: 0x22EA9E0 VA: 0x1822EC3E0
	private static float GetPitch_Injected(IntPtr source) { }

	// RVA: 0x22ECD60 Offset: 0x22EB360 VA: 0x1822ECD60
	private static void SetPitch_Injected(IntPtr source, float pitch) { }

	// RVA: 0x22EC620 Offset: 0x22EAC20 VA: 0x1822EC620
	private static void PlayHelper_Injected(IntPtr source, ulong delay) { }

	// RVA: 0x22ECBE0 Offset: 0x22EB1E0 VA: 0x1822ECBE0
	private static void Play_Injected(IntPtr _unity_self, double delay) { }

	// RVA: 0x22EC720 Offset: 0x22EAD20 VA: 0x1822EC720
	private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale) { }

	// RVA: 0x22ECE60 Offset: 0x22EB460 VA: 0x1822ECE60
	private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots) { }

	// RVA: 0x22ED200 Offset: 0x22EB800 VA: 0x1822ED200
	private static float get_volume_Injected(IntPtr _unity_self) { }

	// RVA: 0x22ED4B0 Offset: 0x22EBAB0 VA: 0x1822ED4B0
	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x22ED140 Offset: 0x22EB740 VA: 0x1822ED140
	private static float get_time_Injected(IntPtr _unity_self) { }

	// RVA: 0x22ED2C0 Offset: 0x22EB8C0 VA: 0x1822ED2C0
	private static void set_clip_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x22EC4C0 Offset: 0x22EAAC0 VA: 0x1822EC4C0
	private static void Pause_Injected(IntPtr _unity_self) { }

	// RVA: 0x22ECFC0 Offset: 0x22EB5C0 VA: 0x1822ECFC0
	private static void UnPause_Injected(IntPtr _unity_self) { }

	// RVA: 0x22ED080 Offset: 0x22EB680 VA: 0x1822ED080
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x22ED3D0 Offset: 0x22EB9D0 VA: 0x1822ED3D0
	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioLowPassFilter : Behaviour // TypeDefIndex: 14104
{
	// Properties
	public float cutoffFrequency { get; set; }

	// Methods

	// RVA: 0x22EBE80 Offset: 0x22EA480 VA: 0x1822EBE80
	public float get_cutoffFrequency() { }

	// RVA: 0x22EBF50 Offset: 0x22EA550 VA: 0x1822EBF50
	public void set_cutoffFrequency(float value) { }

	// RVA: 0x22EBE40 Offset: 0x22EA440 VA: 0x1822EBE40
	private static float get_cutoffFrequency_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EBF00 Offset: 0x22EA500 VA: 0x1822EBF00
	private static void set_cutoffFrequency_Injected(IntPtr _unity_self, float value) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(AudioBehaviour))]
public sealed class AudioReverbFilter : Behaviour // TypeDefIndex: 14105
{}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(4, Inherited = False)]
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 14149
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string preferredExtension, string[] otherExtensions) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(64)]
internal class ThreadAndSerializationSafeAttribute : Attribute // TypeDefIndex: 14150
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(2048, AllowMultiple = False)]
[VisibleToOtherModules]
internal class WritableAttribute : Attribute // TypeDefIndex: 14151
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(1)]
[VisibleToOtherModules]
internal class UnityEngineModuleAssembly : Attribute // TypeDefIndex: 14152
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(12, Inherited = False)]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute // TypeDefIndex: 14153
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <QualifiedNativeName>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Declaration>k__BackingField; // 0x18

	// Properties
	private string QualifiedNativeName { set; }
	private string Declaration { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_QualifiedNativeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_Declaration(string value) { }

	// RVA: 0x23DF860 Offset: 0x23DDE60 VA: 0x1823DF860
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string qualifiedCppName, string declaration) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
internal sealed class UnityString // TypeDefIndex: 14154
{
	// Methods

	// RVA: 0x23DFFD0 Offset: 0x23DE5D0 VA: 0x1823DFFD0
	public static string Format(string fmt, object[] args) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
[NativeHeader("AssetBundleScriptingClasses.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
public class AssetBundle : Object // TypeDefIndex: 14191
{
	// Methods

	// RVA: 0x22EB910 Offset: 0x22E9F10 VA: 0x1822EB910
	private void .ctor() { }

	[FreeFunction("GetAllAssetBundles")]
	// RVA: 0x22EAA20 Offset: 0x22E9020 VA: 0x1822EAA20
	internal static AssetBundle[] GetAllLoadedAssetBundles_Native() { }

	// RVA: 0x22EAA20 Offset: 0x22E9020 VA: 0x1822EAA20
	public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles() { }

	[FreeFunction("LoadFromFileAsync")]
	// RVA: 0x22EB4A0 Offset: 0x22E9AA0 VA: 0x1822EB4A0
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x22EB6F0 Offset: 0x22E9CF0 VA: 0x1822EB6F0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x22EB6E0 Offset: 0x22E9CE0 VA: 0x1822EB6E0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc) { }

	// RVA: 0x22EAEE0 Offset: 0x22E94E0 VA: 0x1822EAEE0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x22EB300 Offset: 0x22E9900 VA: 0x1822EB300
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type) { }

	// RVA: 0x22EAA50 Offset: 0x22E9050 VA: 0x1822EAA50
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAllAssetsAsync<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E730 Offset: 0x65CD30 VA: 0x18065E730
	|-AssetBundle.LoadAllAssetsAsync<object>
	|-AssetBundle.LoadAllAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22EAB50 Offset: 0x22E9150 VA: 0x1822EAB50
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	[NativeMethod("LoadAssetAsync_Internal")]
	[NativeThrows]
	// RVA: 0x22EAC70 Offset: 0x22E9270 VA: 0x1822EAC70
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethod("Unload")]
	[NativeThrows]
	// RVA: 0x22EB880 Offset: 0x22E9E80 VA: 0x1822EB880
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethod("UnloadAsync")]
	[NativeThrows]
	// RVA: 0x22EB750 Offset: 0x22E9D50 VA: 0x1822EB750
	public AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects) { }

	[NativeThrows]
	[NativeMethod("LoadAssetWithSubAssetsAsync_Internal")]
	// RVA: 0x22EB090 Offset: 0x22E9690 VA: 0x1822EB090
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

	// RVA: 0x22EB450 Offset: 0x22E9A50 VA: 0x1822EB450
	private static IntPtr LoadFromFileAsync_Internal_Injected(ref ManagedSpanWrapper path, uint crc, ulong offset) { }

	// RVA: 0x22EAC10 Offset: 0x22E9210 VA: 0x1822EAC10
	private static IntPtr LoadAssetAsync_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type) { }

	// RVA: 0x22EB830 Offset: 0x22E9E30 VA: 0x1822EB830
	private static void Unload_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects) { }

	// RVA: 0x22EB700 Offset: 0x22E9D00 VA: 0x1822EB700
	private static IntPtr UnloadAsync_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects) { }

	// RVA: 0x22EB030 Offset: 0x22E9630 VA: 0x1822EB030
	private static IntPtr LoadAssetWithSubAssetsAsync_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 14193
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	[NativeMethod("GetAssetBundleBlocking")]
	// RVA: 0x22EA780 Offset: 0x22E8D80 VA: 0x1822EA780
	public AssetBundle get_assetBundle() { }

	// RVA: 0x22EA730 Offset: 0x22E8D30 VA: 0x1822EA730
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x22EA740 Offset: 0x22E8D40 VA: 0x1822EA740
	private static IntPtr get_assetBundle_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleRecompressOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRecompressOperation : AsyncOperation // TypeDefIndex: 14194
{}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRequest : ResourceRequest // TypeDefIndex: 14196
{
	// Properties
	public Object asset { get; }
	public Object[] allAssets { get; }

	// Methods

	[NativeMethod("GetLoadedAsset")]
	// RVA: 0x22EA850 Offset: 0x22E8E50 VA: 0x1822EA850 Slot: 4
	protected override Object GetResult() { }

	// RVA: 0x15267C0 Offset: 0x1524DC0 VA: 0x1815267C0
	public Object get_asset() { }

	[NativeMethod("GetAllLoadedAssets")]
	// RVA: 0x22EA920 Offset: 0x22E8F20 VA: 0x1822EA920
	public Object[] get_allAssets() { }

	// RVA: 0x22EA730 Offset: 0x22E8D30 VA: 0x1822EA730
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x22EA810 Offset: 0x22E8E10 VA: 0x1822EA810
	private static IntPtr GetResult_Injected(IntPtr _unity_self) { }

	// RVA: 0x22EA8E0 Offset: 0x22E8EE0 VA: 0x1822EA8E0
	private static Object[] get_allAssets_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
[RequiredByNativeCode]
public class AssetBundleUnloadOperation : AsyncOperation // TypeDefIndex: 14198
{
	// Methods

	[NativeMethod("WaitForCompletion")]
	// RVA: 0x22EA9C0 Offset: 0x22E8FC0 VA: 0x1822EA9C0
	public void WaitForCompletion() { }

	// RVA: 0x22EA730 Offset: 0x22E8D30 VA: 0x1822EA730
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x22EA980 Offset: 0x22E8F80 VA: 0x1822EA980
	private static void WaitForCompletion_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Subsystems/Subsystem.h")]
public class IntegratedSubsystem // TypeDefIndex: 14201
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	internal IntPtr m_Ptr; // 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

	// Methods

	// RVA: 0x23E00C0 Offset: 0x23DE6C0 VA: 0x1823E00C0
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x23E0070 Offset: 0x23DE670 VA: 0x1823E0070
	private static void SetHandle_Injected(IntPtr _unity_self, IntegratedSubsystem subsystem) { }
}

// Namespace: UnityEngine
[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 14202
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine
[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 14203
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string id { get; }

	// Methods

	// RVA: 0x23E0060 Offset: 0x23DE660 VA: 0x1823E0060 Slot: 4
	public string get_id() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemDescriptor.h")]
[UsedByNativeCode("SubsystemDescriptor")]
public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 14204
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	|-IntegratedSubsystemDescriptor<object>..ctor
	*/
}

// Namespace: UnityEngine
internal static class SubsystemDescriptorBindings // TypeDefIndex: 14205
{
	// Methods

	// RVA: 0x23E0210 Offset: 0x23DE810 VA: 0x1823E0210
	public static string GetId(IntPtr descriptorPtr) { }

	// RVA: 0x23E01C0 Offset: 0x23DE7C0 VA: 0x1823E01C0
	private static void GetId_Injected(IntPtr descriptorPtr, out ManagedSpanWrapper ret) { }
}

// Namespace: UnityEngine
public interface ISubsystemDescriptor // TypeDefIndex: 14206
{
	// Properties
	public abstract string id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_id();
}

// Namespace: UnityEngine
[Obsolete("Use SubsystemWithProvider instead.", False)]
public abstract class Subsystem // TypeDefIndex: 14207
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[Obsolete("Use SubsystemDescriptorWithProvider instead.", False)]
public abstract class SubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 14208
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10

	// Properties
	public string id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public string get_id() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal static class Internal_SubsystemDescriptors // TypeDefIndex: 14209
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23E0120 Offset: 0x23DE720 VA: 0x1823E0120
	internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemManager // TypeDefIndex: 14210
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action beforeReloadSubsystems; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action afterReloadSubsystems; // 0x8
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
	private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsStarted; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsCompleted; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23E0E70 Offset: 0x23DF470 VA: 0x1823E0E70
	private static void ReloadSubsystemsStarted() { }

	[RequiredByNativeCode]
	// RVA: 0x23E0D80 Offset: 0x23DF380 VA: 0x1823E0D80
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	// RVA: 0x23E0C50 Offset: 0x23DF250 VA: 0x1823E0C50
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCode]
	// RVA: 0x23E08D0 Offset: 0x23DEED0 VA: 0x1823E08D0
	private static void ClearSubsystems() { }

	// RVA: 0x23E0F60 Offset: 0x23DF560 VA: 0x1823E0F60
	private static void StaticConstructScriptingClassMap() { }

	// RVA: 0x23E0F90 Offset: 0x23DF590 VA: 0x1823E0F90
	private static void .cctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	// RVA: 0x23E0AF0 Offset: 0x23DF0F0 VA: 0x1823E0AF0
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility // TypeDefIndex: 14261
{
	// Methods

	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	// RVA: 0x23A9800 Offset: 0x23A7E00 VA: 0x1823A9800
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	[ThreadSafe]
	// RVA: 0x23A9280 Offset: 0x23A7880 VA: 0x1823A9280
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x23A9910 Offset: 0x23A7F10 VA: 0x1823A9910
	public static string ToJson(object obj) { }

	// RVA: 0x23A9A70 Offset: 0x23A8070 VA: 0x1823A9A70
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x713A10 Offset: 0x712010 VA: 0x180713A10
	|-JsonUtility.FromJson<DiagnosticEvent>
	|
	|-RVA: 0x713C40 Offset: 0x712240 VA: 0x180713C40
	|-JsonUtility.FromJson<object>
	|
	|-RVA: 0x713B00 Offset: 0x712100 VA: 0x180713B00
	|-JsonUtility.FromJson<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23A95D0 Offset: 0x23A7BD0 VA: 0x1823A95D0
	public static object FromJson(string json, Type type) { }

	// RVA: 0x23A9420 Offset: 0x23A7A20 VA: 0x1823A9420
	public static void FromJsonOverwrite(string json, object objectToOverwrite) { }

	// RVA: 0x23A97A0 Offset: 0x23A7DA0 VA: 0x1823A97A0
	private static void ToJsonInternal_Injected(object obj, bool prettyPrint, out ManagedSpanWrapper ret) { }

	// RVA: 0x23A9220 Offset: 0x23A7820 VA: 0x1823A9220
	private static object FromJsonInternal_Injected(ref ManagedSpanWrapper json, object objectToOverwrite, Type type) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
public static class RemoteSettings // TypeDefIndex: 14264
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action BeforeFetchFromServer; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x26816C0 Offset: 0x267FCC0 VA: 0x1826816C0
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCode]
	// RVA: 0x26815F0 Offset: 0x267FBF0 VA: 0x1826815F0
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCode]
	// RVA: 0x2681640 Offset: 0x267FC40 VA: 0x182681640
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[ExcludeFromDocs]
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
public class RemoteConfigSettings // TypeDefIndex: 14265
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<bool> Updated; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x26815C0 Offset: 0x267FBC0 VA: 0x1826815C0
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }
}

// Namespace: UnityEngine
internal static class RemoteConfigSettingsHelper // TypeDefIndex: 14267
{}

// Namespace: UnityEngine
[ExcludeFromDocs]
[NativeHeader("Modules/Marshalling/MarshallingTests.h")]
[NativeClass("StructCoreString", "struct StructCoreString;")]
[RequiredByNativeCode(GenerateProxy = True, Name = "StructCoreStringManaged")]
internal struct StructCoreString // TypeDefIndex: 14279
{
	// Fields
	public string field; // 0x0
}

// Namespace: UnityEngine
[NativeType("Modules/Marshalling/MarshallingTests.h")]
internal class InvokeTests // TypeDefIndex: 14280
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x147B320 Offset: 0x1479920 VA: 0x18147B320
	private static bool InvokeBool(bool arg) { }

	[RequiredByNativeCode]
	// RVA: 0x147B320 Offset: 0x1479920 VA: 0x18147B320
	private static sbyte InvokeSByte(sbyte arg) { }

	[RequiredByNativeCode]
	// RVA: 0x147B320 Offset: 0x1479920 VA: 0x18147B320
	private static byte InvokeByte(byte arg) { }

	[RequiredByNativeCode]
	// RVA: 0x230DF60 Offset: 0x230C560 VA: 0x18230DF60
	private static char InvokeChar(char arg) { }

	[RequiredByNativeCode]
	// RVA: 0x230DF60 Offset: 0x230C560 VA: 0x18230DF60
	private static short InvokeShort(short arg) { }

	[RequiredByNativeCode]
	// RVA: 0x230DF60 Offset: 0x230C560 VA: 0x18230DF60
	private static ushort InvokeUShort(ushort arg) { }

	[RequiredByNativeCode]
	// RVA: 0x2338060 Offset: 0x2336660 VA: 0x182338060
	private static int InvokeInt(int arg) { }

	[RequiredByNativeCode]
	// RVA: 0x2338060 Offset: 0x2336660 VA: 0x182338060
	private static uint InvokeUInt(uint arg) { }

	[RequiredByNativeCode]
	// RVA: 0x1561B10 Offset: 0x1560110 VA: 0x181561B10
	private static long InvokeLong(long arg) { }

	[RequiredByNativeCode]
	// RVA: 0x1561B10 Offset: 0x1560110 VA: 0x181561B10
	private static ulong InvokeULong(ulong arg) { }

	[RequiredByNativeCode]
	// RVA: 0x1561B10 Offset: 0x1560110 VA: 0x181561B10
	private static IntPtr InvokeIntPtr(IntPtr arg) { }

	[RequiredByNativeCode]
	// RVA: 0x1561B10 Offset: 0x1560110 VA: 0x181561B10
	private static UIntPtr InvokeUIntPtr(UIntPtr arg) { }

	[RequiredByNativeCode]
	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	private static float InvokeFloat(float arg) { }

	[RequiredByNativeCode]
	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	private static double InvokeDouble(double arg) { }
}

// Namespace: UnityEngine
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[RequireComponent(typeof(Transform))]
public class GridLayout : Behaviour // TypeDefIndex: 14289
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void DoNothing() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Terrain/Public/TerrainData.h")]
[NativeHeader("Modules/TerrainPhysics/TerrainCollider.h")]
public class TerrainCollider : Collider // TypeDefIndex: 14293
{}

