// Namespace: UnityEngine.Windows.WebCam
[StaticAccessor("PhotoCapture", 2)]
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCapture.h")]
public class PhotoCapture : IDisposable // TypeDefIndex: 9830
{
	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2359840 Offset: 0x2357E40 VA: 0x182359840
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x23597B0 Offset: 0x2357DB0 VA: 0x1823597B0
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1815DF0 Offset: 0x18143F0 VA: 0x181815DF0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCode]
	// RVA: 0x2359550 Offset: 0x2357B50 VA: 0x182359550
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2359550 Offset: 0x2357B50 VA: 0x182359550
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2359550 Offset: 0x2357B50 VA: 0x182359550
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x23595E0 Offset: 0x2357BE0 VA: 0x1823595E0
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x2359430 Offset: 0x2357A30 VA: 0x182359430 Slot: 4
	public void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	// RVA: 0x23593D0 Offset: 0x23579D0 VA: 0x1823593D0
	private void Dispose_Internal() { }

	// RVA: 0x23594C0 Offset: 0x2357AC0 VA: 0x1823594C0 Slot: 1
	protected override void Finalize() { }

	[NativeName("DisposeThreaded")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[ThreadAndSerializationSafe]
	// RVA: 0x2359330 Offset: 0x2357930 VA: 0x182359330
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2359390 Offset: 0x2357990 VA: 0x182359390
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	// RVA: 0x23592F0 Offset: 0x23578F0 VA: 0x1823592F0
	private static void DisposeThreaded_Internal_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Windows.WebCam
[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 9832
{
	// Fields
	private IntPtr m_NativePtr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <dataLength>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <hasLocationData>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	// Properties
	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_dataLength() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	private void set_dataLength(int value) { }

	[CompilerGenerated]
	// RVA: 0x39A910 Offset: 0x398F10 VA: 0x18039A910
	private void set_hasLocationData(bool value) { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x23590E0 Offset: 0x23576E0 VA: 0x1823590E0
	private int GetDataLength() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2359180 Offset: 0x2357780 VA: 0x182359180
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2359040 Offset: 0x2357640 VA: 0x182359040
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x23591E0 Offset: 0x23577E0 VA: 0x1823591E0
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x2358E00 Offset: 0x2357400 VA: 0x182358E00
	private void Cleanup() { }

	[NativeName("Dispose")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[ThreadAndSerializationSafe]
	// RVA: 0x2358EE0 Offset: 0x23574E0 VA: 0x182358EE0
	private void Dispose_Internal() { }

	// RVA: 0x2358F40 Offset: 0x2357540 VA: 0x182358F40 Slot: 4
	public void Dispose() { }

	// RVA: 0x2358FA0 Offset: 0x23575A0 VA: 0x182358FA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x23590A0 Offset: 0x23576A0 VA: 0x1823590A0
	private static int GetDataLength_Injected(IntPtr _unity_self) { }

	// RVA: 0x2359140 Offset: 0x2357740 VA: 0x182359140
	private static bool GetHasLocationData_Injected(IntPtr _unity_self) { }

	// RVA: 0x2359000 Offset: 0x2357600 VA: 0x182359000
	private static CapturePixelFormat GetCapturePixelFormat_Injected(IntPtr _unity_self) { }

	// RVA: 0x2358EA0 Offset: 0x23574A0 VA: 0x182358EA0
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Windows.WebCam
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
[StaticAccessor("VideoCaptureBindings", 2)]
public class VideoCapture : IDisposable // TypeDefIndex: 9841
{
	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x236A0E0 Offset: 0x23686E0 VA: 0x18236A0E0
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2369FC0 Offset: 0x23685C0 VA: 0x182369FC0
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1815DF0 Offset: 0x18143F0 VA: 0x181815DF0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCode]
	// RVA: 0x236A050 Offset: 0x2368650 VA: 0x18236A050
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x236A050 Offset: 0x2368650 VA: 0x18236A050
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x236A050 Offset: 0x2368650 VA: 0x18236A050
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x236A050 Offset: 0x2368650 VA: 0x18236A050
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x2369EA0 Offset: 0x23684A0 VA: 0x182369EA0 Slot: 4
	public void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = True)]
	// RVA: 0x2369E40 Offset: 0x2368440 VA: 0x182369E40
	private void Dispose_Internal() { }

	// RVA: 0x2369F30 Offset: 0x2368530 VA: 0x182369F30 Slot: 1
	protected override void Finalize() { }

	[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = True)]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[ThreadAndSerializationSafe]
	// RVA: 0x2369DA0 Offset: 0x23683A0 VA: 0x182369DA0
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2369E00 Offset: 0x2368400 VA: 0x182369E00
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	// RVA: 0x2369D60 Offset: 0x2368360 VA: 0x182369D60
	private static void DisposeThreaded_Internal_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Windows.WebCam
[MovedFrom("UnityEngine.XR.WSA.WebCam")]
public enum CapturePixelFormat // TypeDefIndex: 9842
{
	// Fields
	public int value__; // 0x0
	public const CapturePixelFormat BGRA32 = 0;
	public const CapturePixelFormat NV12 = 1;
	public const CapturePixelFormat JPEG = 2;
	public const CapturePixelFormat PNG = 3;
}

