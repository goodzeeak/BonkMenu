// Namespace: UnityEngine.Analytics
[Flags]
public enum SendEventOptions // TypeDefIndex: 10175
{
	// Fields
	public int value__; // 0x0
	public const SendEventOptions kAppendNone = 0;
	public const SendEventOptions kAppendBuildGuid = 1;
	public const SendEventOptions kAppendBuildTarget = 2;
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
public class AnalyticsEventBase // TypeDefIndex: 10176
{
	// Fields
	private string eventName; // 0x10
	private int eventVersion; // 0x18
	private string eventPrefix; // 0x20
	private SendEventOptions sendEventOptions; // 0x28

	// Methods

	// RVA: 0x236A150 Offset: 0x2368750 VA: 0x18236A150
	public void .ctor(string eventName, int eventVersion, SendEventOptions sendEventOptions = 0, string eventPrefix = "") { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class BatchRenderGroupUsageAnalytic : AnalyticsEventBase // TypeDefIndex: 10177
{
	// Fields
	public int maxBRGInstance; // 0x30
	public int maxMeshCount; // 0x34
	public int maxMaterialCount; // 0x38
	public int maxDrawCommandBatch; // 0x3C

	// Methods

	// RVA: 0x236B290 Offset: 0x2369890 VA: 0x18236B290
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x236B1D0 Offset: 0x23697D0 VA: 0x18236B1D0
	public static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class UaaLApplicationLaunchAnalytic : AnalyticsEventBase // TypeDefIndex: 10178
{
	// Fields
	public int launch_type; // 0x30
	public int launch_process_type; // 0x34

	// Methods

	// RVA: 0x236B3E0 Offset: 0x23699E0 VA: 0x18236B3E0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x236B320 Offset: 0x2369920 VA: 0x18236B320
	public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class SubsystemsAnalyticBase : AnalyticsEventBase // TypeDefIndex: 14116
{
	// Fields
	public string subsystem; // 0x30

	// Methods

	// RVA: 0x2680D30 Offset: 0x267F330 VA: 0x182680D30
	public void .ctor(string eventName) { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class SubsystemsAnalyticStart : SubsystemsAnalyticBase // TypeDefIndex: 14117
{
	// Methods

	// RVA: 0x2680F70 Offset: 0x267F570 VA: 0x182680F70
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680EC0 Offset: 0x267F4C0 VA: 0x182680EC0
	internal static SubsystemsAnalyticStart CreateSubsystemsAnalyticStart() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class SubsystemsAnalyticStop : SubsystemsAnalyticBase // TypeDefIndex: 14118
{
	// Methods

	// RVA: 0x26810A0 Offset: 0x267F6A0 VA: 0x1826810A0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680FF0 Offset: 0x267F5F0 VA: 0x182680FF0
	internal static SubsystemsAnalyticStop CreateSubsystemsAnalyticStop() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class SubsystemsAnalyticInfo : SubsystemsAnalyticBase // TypeDefIndex: 14119
{
	// Fields
	private string id; // 0x38
	private string plugin_name; // 0x40
	private string version; // 0x48
	private string library_name; // 0x50

	// Methods

	// RVA: 0x2680E40 Offset: 0x267F440 VA: 0x182680E40
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680D90 Offset: 0x267F390 VA: 0x182680D90
	internal static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class VRDeviceAnalyticBase : AnalyticsEventBase // TypeDefIndex: 14120
{
	// Methods

	// RVA: 0x26812B0 Offset: 0x267F8B0 VA: 0x1826812B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class VRDeviceAnalyticAspect : VRDeviceAnalyticBase // TypeDefIndex: 14121
{
	// Fields
	public float vr_aspect_ratio; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2681320 Offset: 0x267F920 VA: 0x182681320
	internal static VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect() { }

	// RVA: 0x26812B0 Offset: 0x267F8B0 VA: 0x1826812B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class VRDeviceMirrorAnalytic : VRDeviceAnalyticBase // TypeDefIndex: 14122
{
	// Fields
	public bool vr_device_mirror_mode; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x26813B0 Offset: 0x267F9B0 VA: 0x1826813B0
	internal static VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic() { }

	// RVA: 0x26812B0 Offset: 0x267F8B0 VA: 0x1826812B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class VRDeviceUserAnalytic : VRDeviceAnalyticBase // TypeDefIndex: 14123
{
	// Fields
	public int vr_user_presence; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2681440 Offset: 0x267FA40 VA: 0x182681440
	internal static VRDeviceUserAnalytic CreateVRDeviceUserAnalytic() { }

	// RVA: 0x26812B0 Offset: 0x267F8B0 VA: 0x1826812B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class VRDeviceActiveControllersAnalytic : VRDeviceAnalyticBase // TypeDefIndex: 14124
{
	// Fields
	public string[] vr_active_controllers; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2681220 Offset: 0x267F820 VA: 0x182681220
	internal static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic() { }

	// RVA: 0x26812B0 Offset: 0x267F8B0 VA: 0x1826812B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
[NativeHeader("Modules/UnityAnalytics/ContinuousEvent/Manager.h")]
[ExcludeFromDocs]
public class ContinuousEvent // TypeDefIndex: 14268
{}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
public enum AnalyticsSessionState // TypeDefIndex: 14269
{
	// Fields
	public int value__; // 0x0
	public const AnalyticsSessionState kSessionStopped = 0;
	public const AnalyticsSessionState kSessionStarted = 1;
	public const AnalyticsSessionState kSessionPaused = 2;
	public const AnalyticsSessionState kSessionResumed = 3;
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
public static class AnalyticsSessionInfo // TypeDefIndex: 14272
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2681530 Offset: 0x267FB30 VA: 0x182681530
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x26814D0 Offset: 0x267FAD0 VA: 0x1826814D0
	internal static void CallIdentityTokenChanged(string token) { }
}

