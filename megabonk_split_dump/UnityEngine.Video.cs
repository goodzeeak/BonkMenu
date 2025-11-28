// Namespace: UnityEngine.Video
[RequiredByNativeCode]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
public sealed class VideoClip : Object // TypeDefIndex: 14242
{}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoRenderMode // TypeDefIndex: 14243
{
	// Fields
	public int value__; // 0x0
	public const VideoRenderMode CameraFarPlane = 0;
	public const VideoRenderMode CameraNearPlane = 1;
	public const VideoRenderMode RenderTexture = 2;
	public const VideoRenderMode MaterialOverride = 3;
	public const VideoRenderMode APIOnly = 4;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum Video3DLayout // TypeDefIndex: 14244
{
	// Fields
	public int value__; // 0x0
	public const Video3DLayout No3D = 0;
	public const Video3DLayout SideBySide3D = 1;
	public const Video3DLayout OverUnder3D = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAspectRatio // TypeDefIndex: 14245
{
	// Fields
	public int value__; // 0x0
	public const VideoAspectRatio NoScaling = 0;
	public const VideoAspectRatio FitVertically = 1;
	public const VideoAspectRatio FitHorizontally = 2;
	public const VideoAspectRatio FitInside = 3;
	public const VideoAspectRatio FitOutside = 4;
	public const VideoAspectRatio Stretch = 5;
}

// Namespace: UnityEngine.Video
[Obsolete("VideoTimeSource is deprecated. Use TimeUpdateMode instead. (UnityUpgradable) -> VideoTimeUpdateMode")]
[RequiredByNativeCode]
public enum VideoTimeSource // TypeDefIndex: 14246
{
	// Fields
	public int value__; // 0x0
	[Obsolete("AudioDSPTimeSource is deprecated. Use DSPTime instead. (UnityUpgradable) -> DSPTime")]
	public const VideoTimeSource AudioDSPTimeSource = 0;
	[Obsolete("GameTimeSource is deprecated. Use GameTime instead. (UnityUpgradable) -> GameTime")]
	public const VideoTimeSource GameTimeSource = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeReference // TypeDefIndex: 14247
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeReference Freerun = 0;
	public const VideoTimeReference InternalTime = 1;
	public const VideoTimeReference ExternalTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoSource // TypeDefIndex: 14248
{
	// Fields
	public int value__; // 0x0
	public const VideoSource VideoClip = 0;
	public const VideoSource Url = 1;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoTimeUpdateMode // TypeDefIndex: 14249
{
	// Fields
	public int value__; // 0x0
	public const VideoTimeUpdateMode DSPTime = 0;
	public const VideoTimeUpdateMode GameTime = 1;
	public const VideoTimeUpdateMode UnscaledGameTime = 2;
}

// Namespace: UnityEngine.Video
[RequiredByNativeCode]
public enum VideoAudioOutputMode // TypeDefIndex: 14250
{
	// Fields
	public int value__; // 0x0
	public const VideoAudioOutputMode None = 0;
	public const VideoAudioOutputMode AudioSource = 1;
	public const VideoAudioOutputMode Direct = 2;
	public const VideoAudioOutputMode APIOnly = 3;
}

// Namespace: UnityEngine.Video
[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public sealed class VideoPlayer : Behaviour // TypeDefIndex: 14255
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler started; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x26888B0 Offset: 0x2686EB0 VA: 0x1826888B0
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2688830 Offset: 0x2686E30 VA: 0x182688830
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	// RVA: 0x2688870 Offset: 0x2686E70 VA: 0x182688870
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2688930 Offset: 0x2686F30 VA: 0x182688930
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x26887F0 Offset: 0x2686DF0 VA: 0x1826887F0
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x26887B0 Offset: 0x2686DB0 VA: 0x1826887B0
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	// RVA: 0x26888F0 Offset: 0x2686EF0 VA: 0x1826888F0
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2688770 Offset: 0x2686D70 VA: 0x182688770
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }
}

