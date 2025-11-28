// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler // TypeDefIndex: 13867
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x26827B0 Offset: 0x2680DB0 VA: 0x1826827B0
	private void ReleaseFromScripting() { }

	// RVA: 0x22F0DD0 Offset: 0x22EF3D0 VA: 0x1822F0DD0 Slot: 4
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCode]
	// RVA: 0x2682810 Offset: 0x2680E10 VA: 0x182682810
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x2682720 Offset: 0x2680D20 VA: 0x182682720 Slot: 5
	public void Dispose() { }

	// RVA: 0x2682770 Offset: 0x2680D70 VA: 0x182682770
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable // TypeDefIndex: 13869
{
	// Fields
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string error { get; }
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2683360 Offset: 0x2681960 VA: 0x182683360
	private void ReleaseFromScripting() { }

	[VisibleToOtherModules]
	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x242A7F0 Offset: 0x2428DF0 VA: 0x18242A7F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2682B50 Offset: 0x2681150 VA: 0x182682B50 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x26833C0 Offset: 0x26819C0 VA: 0x1826833C0
	public string get_error() { }

	// RVA: 0x2682DA0 Offset: 0x26813A0 VA: 0x182682DA0
	private string GetErrorMsg() { }

	// RVA: 0x14542D0 Offset: 0x14528D0 VA: 0x1814542D0
	public byte[] get_data() { }

	// RVA: 0x1531350 Offset: 0x152F950 VA: 0x181531350
	public string get_text() { }

	// RVA: 0x8AFA20 Offset: 0x8AE020 VA: 0x1808AFA20 Slot: 6
	protected virtual NativeArray<byte> GetNativeData() { }

	// RVA: 0x2682CC0 Offset: 0x26812C0 VA: 0x182682CC0 Slot: 7
	protected virtual byte[] GetData() { }

	// RVA: 0x2683080 Offset: 0x2681680 VA: 0x182683080 Slot: 8
	protected virtual string GetText() { }

	// RVA: 0x2682E80 Offset: 0x2681480 VA: 0x182682E80
	private Encoding GetTextEncoder() { }

	// RVA: 0x2682BF0 Offset: 0x26811F0 VA: 0x182682BF0
	private string GetContentType() { }

	[RequiredByNativeCode]
	// RVA: 0xB6ED80 Offset: 0xB6D380 VA: 0x180B6ED80 Slot: 9
	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

	[RequiredByNativeCode]
	// RVA: 0x236C0F0 Offset: 0x236A6F0 VA: 0x18236C0F0 Slot: 10
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	protected virtual void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	protected virtual void CompleteContent() { }

	[RequiredByNativeCode]
	// RVA: 0x2682E70 Offset: 0x2681470 VA: 0x182682E70 Slot: 13
	protected virtual float GetProgress() { }

	[NativeThrows]
	[VisibleToOtherModules]
	// RVA: 0x26831B0 Offset: 0x26817B0 VA: 0x1826831B0
	internal static byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	// RVA: 0x2682CC0 Offset: 0x26812C0 VA: 0x182682CC0
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule" })]
	// RVA: 0x2683200 Offset: 0x2681800 VA: 0x182683200
	internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule" })]
	// RVA: 0x2682B10 Offset: 0x2681110 VA: 0x182682B10
	internal static void DisposeNativeArray(ref NativeArray<byte> data) { }

	// RVA: 0x2682AA0 Offset: 0x26810A0 VA: 0x182682AA0
	internal static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length) { }

	// RVA: 0x2683320 Offset: 0x2681920 VA: 0x182683320
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	// RVA: 0x2682D50 Offset: 0x2681350 VA: 0x182682D50
	private static void GetErrorMsg_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2682BA0 Offset: 0x26811A0 VA: 0x182682BA0
	private static void GetContentType_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2683160 Offset: 0x2681760 VA: 0x182683160
	private static byte* InternalGetByteArray_Injected(IntPtr dh, out int length) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
public sealed class DownloadHandlerBuffer : DownloadHandler // TypeDefIndex: 13870
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x2682830 Offset: 0x2680E30 VA: 0x182682830
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x2682A20 Offset: 0x2681020 VA: 0x182682A20
	private void InternalCreateBuffer() { }

	// RVA: 0x2682A60 Offset: 0x2681060 VA: 0x182682A60
	public void .ctor() { }

	// RVA: 0x26828F0 Offset: 0x2680EF0 VA: 0x1826828F0 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x2682870 Offset: 0x2680E70 VA: 0x182682870 Slot: 5
	public override void Dispose() { }
}

// Namespace: UnityEngine.Networking
[UsedByNativeCode]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
public class UnityWebRequestAsyncOperation : AsyncOperation // TypeDefIndex: 13872
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Properties
	public UnityWebRequest webRequest { get; set; }

	// Methods

	// RVA: 0x22EA730 Offset: 0x22E8D30 VA: 0x1822EA730
	private void .ctor(IntPtr ptr) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public UnityWebRequest get_webRequest() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_webRequest(UnityWebRequest value) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable // TypeDefIndex: 13877
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { get; set; }
	public string error { get; }
	public string url { get; set; }
	public Uri uri { set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public UnityWebRequest.Result result { get; }
	public ulong downloadedBytes { get; }
	public int redirectLimit { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	// RVA: 0x2683E40 Offset: 0x2682440 VA: 0x182683E40
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModules]
	// RVA: 0x2683910 Offset: 0x2681F10 VA: 0x182683910
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGenerated]
	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0xADB1E0 Offset: 0xAD97E0 VA: 0x180ADB1E0
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x13D9FF0 Offset: 0x13D85F0 VA: 0x1813D9FF0
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[NativeThrows]
	// RVA: 0x2683560 Offset: 0x2681B60 VA: 0x182683560
	internal static IntPtr Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2684330 Offset: 0x2682930 VA: 0x182684330
	private void Release() { }

	// RVA: 0x2683EF0 Offset: 0x26824F0 VA: 0x182683EF0
	internal void InternalDestroy() { }

	// RVA: 0x2684090 Offset: 0x2682690 VA: 0x182684090
	private void InternalSetDefaults() { }

	// RVA: 0x2684EE0 Offset: 0x26834E0 VA: 0x182684EE0
	public void .ctor(string url, string method) { }

	// RVA: 0x2684CB0 Offset: 0x26832B0 VA: 0x182684CB0
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x2684D60 Offset: 0x2683360 VA: 0x182684D60
	public void .ctor(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x2683690 Offset: 0x2681C90 VA: 0x182683690 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2683630 Offset: 0x2681C30 VA: 0x182683630 Slot: 4
	public void Dispose() { }

	// RVA: 0x2683590 Offset: 0x2681B90 VA: 0x182683590
	private void DisposeHandlers() { }

	[NativeThrows]
	// RVA: 0x26834B0 Offset: 0x2681AB0 VA: 0x1826834B0
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x2684390 Offset: 0x2682990 VA: 0x182684390
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2683410 Offset: 0x2681A10 VA: 0x182683410
	public void Abort() { }

	// RVA: 0x2684840 Offset: 0x2682E40 VA: 0x182684840
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x26840A0 Offset: 0x26826A0 VA: 0x1826840A0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x2684580 Offset: 0x2682B80 VA: 0x182684580
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x2683F80 Offset: 0x2682580 VA: 0x182683F80
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x2683A00 Offset: 0x2682000 VA: 0x182683A00
	internal UnityWebRequest.UnityWebRequestMethod GetMethod() { }

	// RVA: 0x2683750 Offset: 0x2681D50 VA: 0x182683750
	internal string GetCustomMethod() { }

	// RVA: 0x26852A0 Offset: 0x26838A0 VA: 0x1826852A0
	public string get_method() { }

	// RVA: 0x26857C0 Offset: 0x2683DC0 VA: 0x1826857C0
	public void set_method(string value) { }

	// RVA: 0x2683860 Offset: 0x2681E60 VA: 0x182683860
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x2685000 Offset: 0x2683600 VA: 0x182685000
	public string get_error() { }

	// RVA: 0x26854D0 Offset: 0x2683AD0 VA: 0x1826854D0
	public string get_url() { }

	// RVA: 0x2685E20 Offset: 0x2684420 VA: 0x182685E20
	public void set_url(string value) { }

	// RVA: 0x2685D20 Offset: 0x2684320 VA: 0x182685D20
	public void set_uri(Uri value) { }

	// RVA: 0x2683D30 Offset: 0x2682330 VA: 0x182683D30
	private string GetUrl() { }

	// RVA: 0x2684B00 Offset: 0x2683100 VA: 0x182684B00
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x26841E0 Offset: 0x26827E0 VA: 0x1826841E0
	private void InternalSetUrl(string url) { }

	// RVA: 0x26853D0 Offset: 0x26839D0 VA: 0x1826853D0
	public long get_responseCode() { }

	[NativeMethod("IsModifiable")]
	// RVA: 0x2685240 Offset: 0x2683840 VA: 0x182685240
	public bool get_isModifiable() { }

	// RVA: 0x26851A0 Offset: 0x26837A0 VA: 0x1826851A0
	public bool get_isDone() { }

	[NativeMethod("GetResult")]
	// RVA: 0x2685470 Offset: 0x2683A70 VA: 0x182685470
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x2684FA0 Offset: 0x26835A0 VA: 0x182684FA0
	public ulong get_downloadedBytes() { }

	[NativeThrows]
	// RVA: 0x26848E0 Offset: 0x2682EE0 VA: 0x1826848E0
	private void SetRedirectLimitFromScripting(int limit) { }

	// RVA: 0x26848E0 Offset: 0x2682EE0 VA: 0x1826848E0
	public void set_redirectLimit(int value) { }

	// RVA: 0x2683AC0 Offset: 0x26820C0 VA: 0x182683AC0
	public string GetResponseHeader(string name) { }

	// RVA: 0x2684A30 Offset: 0x2683030 VA: 0x182684A30
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x2358D20 Offset: 0x2357320 VA: 0x182358D20
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x2685BB0 Offset: 0x26841B0 VA: 0x182685BB0
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x2684780 Offset: 0x2682D80 VA: 0x182684780
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x2685650 Offset: 0x2683C50 VA: 0x182685650
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x26844B0 Offset: 0x2682AB0 VA: 0x1826844B0
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x234CC80 Offset: 0x234B280 VA: 0x18234CC80
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x26854E0 Offset: 0x2683AE0 VA: 0x1826854E0
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x2684980 Offset: 0x2682F80 VA: 0x182684980
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x2685A20 Offset: 0x2684020 VA: 0x182685A20
	public void set_timeout(int value) { }

	// RVA: 0x2683E00 Offset: 0x2682400 VA: 0x182683E00
	private static void GetWebErrorString_Injected(UnityWebRequest.UnityWebRequestError err, out ManagedSpanWrapper ret) { }

	// RVA: 0x26838C0 Offset: 0x2681EC0 VA: 0x1826838C0
	private static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret) { }

	// RVA: 0x26842F0 Offset: 0x26828F0 VA: 0x1826842F0
	private static void Release_Injected(IntPtr _unity_self) { }

	// RVA: 0x2683470 Offset: 0x2681A70 VA: 0x182683470
	private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self) { }

	// RVA: 0x26833D0 Offset: 0x26819D0 VA: 0x1826833D0
	private static void Abort_Injected(IntPtr _unity_self) { }

	// RVA: 0x2684800 Offset: 0x2682E00 VA: 0x182684800
	private static UnityWebRequest.UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x2684530 Offset: 0x2682B30 VA: 0x182684530
	private static UnityWebRequest.UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ref ManagedSpanWrapper customMethodName) { }

	// RVA: 0x26839C0 Offset: 0x2681FC0 VA: 0x1826839C0
	private static UnityWebRequest.UnityWebRequestMethod GetMethod_Injected(IntPtr _unity_self) { }

	// RVA: 0x2683700 Offset: 0x2681D00 VA: 0x182683700
	private static void GetCustomMethod_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2683820 Offset: 0x2681E20 VA: 0x182683820
	private static UnityWebRequest.UnityWebRequestError GetError_Injected(IntPtr _unity_self) { }

	// RVA: 0x2683CE0 Offset: 0x26822E0 VA: 0x182683CE0
	private static void GetUrl_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x2684AB0 Offset: 0x26830B0 VA: 0x182684AB0
	private static UnityWebRequest.UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper url) { }

	// RVA: 0x2685390 Offset: 0x2683990 VA: 0x182685390
	private static long get_responseCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x2685200 Offset: 0x2683800 VA: 0x182685200
	private static bool get_isModifiable_Injected(IntPtr _unity_self) { }

	// RVA: 0x2685430 Offset: 0x2683A30 VA: 0x182685430
	private static UnityWebRequest.Result get_result_Injected(IntPtr _unity_self) { }

	// RVA: 0x2684F60 Offset: 0x2683560 VA: 0x182684F60
	private static ulong get_downloadedBytes_Injected(IntPtr _unity_self) { }

	// RVA: 0x26848A0 Offset: 0x2682EA0 VA: 0x1826848A0
	private static void SetRedirectLimitFromScripting_Injected(IntPtr _unity_self, int limit) { }

	// RVA: 0x2683A60 Offset: 0x2682060 VA: 0x182683A60
	private static void GetResponseHeader_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out ManagedSpanWrapper ret) { }

	// RVA: 0x26849E0 Offset: 0x2682FE0 VA: 0x1826849E0
	private static UnityWebRequest.UnityWebRequestError SetUploadHandler_Injected(IntPtr _unity_self, IntPtr uh) { }

	// RVA: 0x2684730 Offset: 0x2682D30 VA: 0x182684730
	private static UnityWebRequest.UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh) { }

	// RVA: 0x2684460 Offset: 0x2682A60 VA: 0x182684460
	private static UnityWebRequest.UnityWebRequestError SetCertificateHandler_Injected(IntPtr _unity_self, IntPtr ch) { }

	// RVA: 0x2684940 Offset: 0x2682F40 VA: 0x182684940
	private static UnityWebRequest.UnityWebRequestError SetTimeoutMsec_Injected(IntPtr _unity_self, int timeout) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler // TypeDefIndex: 13879
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2685F40 Offset: 0x2684540 VA: 0x182685F40
	private void ReleaseFromScripting() { }

	// RVA: 0x2685EB0 Offset: 0x26844B0 VA: 0x182685EB0 Slot: 4
	public virtual void Dispose() { }

	// RVA: 0x2685F00 Offset: 0x2684500 VA: 0x182685F00
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestAssetBundle // TypeDefIndex: 14257
{
	// Methods

	// RVA: 0x2682600 Offset: 0x2680C00 VA: 0x182682600
	public static UnityWebRequest GetAssetBundle(string uri) { }

	// RVA: 0x2682520 Offset: 0x2680B20 VA: 0x182682520
	public static UnityWebRequest GetAssetBundle(Uri uri) { }

	// RVA: 0x2682230 Offset: 0x2680830 VA: 0x182682230
	public static UnityWebRequest GetAssetBundle(string uri, uint crc) { }

	// RVA: 0x2682440 Offset: 0x2680A40 VA: 0x182682440
	public static UnityWebRequest GetAssetBundle(Uri uri, uint crc) { }

	// RVA: 0x26822F0 Offset: 0x26808F0 VA: 0x1826822F0
	public static UnityWebRequest GetAssetBundle(Uri uri, CachedAssetBundle cachedAssetBundle, uint crc = 0) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
public sealed class DownloadHandlerAssetBundle : DownloadHandler // TypeDefIndex: 14259
{
	// Properties
	public AssetBundle assetBundle { get; }
	public bool autoLoadAssetBundle { get; set; }
	public bool isDownloadComplete { get; }

	// Methods

	// RVA: 0x2681B40 Offset: 0x2680140 VA: 0x182681B40
	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	// RVA: 0x2681830 Offset: 0x267FE30 VA: 0x182681830
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x2681DC0 Offset: 0x26803C0 VA: 0x182681DC0
	private void InternalCreateAssetBundle(string url, uint crc) { }

	// RVA: 0x2681D80 Offset: 0x2680380 VA: 0x182681D80
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x2681DE0 Offset: 0x26803E0 VA: 0x182681DE0
	public void .ctor(string url, uint crc) { }

	// RVA: 0x2681E30 Offset: 0x2680430 VA: 0x182681E30
	public void .ctor(string url, CachedAssetBundle cachedBundle, uint crc) { }

	// RVA: 0x2681CE0 Offset: 0x26802E0 VA: 0x182681CE0 Slot: 7
	protected override byte[] GetData() { }

	// RVA: 0x2681D30 Offset: 0x2680330 VA: 0x182681D30 Slot: 8
	protected override string GetText() { }

	// RVA: 0x2681F10 Offset: 0x2680510 VA: 0x182681F10
	public AssetBundle get_assetBundle() { }

	// RVA: 0x2682080 Offset: 0x2680680 VA: 0x182682080
	public bool get_autoLoadAssetBundle() { }

	[NativeThrows]
	// RVA: 0x26821D0 Offset: 0x26807D0 VA: 0x1826821D0
	public void set_autoLoadAssetBundle(bool value) { }

	// RVA: 0x2682120 Offset: 0x2680720 VA: 0x182682120
	public bool get_isDownloadComplete() { }

	// RVA: 0x2681AE0 Offset: 0x26800E0 VA: 0x182681AE0
	private static IntPtr Create_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, uint crc) { }

	// RVA: 0x26817C0 Offset: 0x267FDC0 VA: 0x1826817C0
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, ref ManagedSpanWrapper name, in Hash128 hash, uint crc) { }

	// RVA: 0x2681ED0 Offset: 0x26804D0 VA: 0x182681ED0
	private static IntPtr get_assetBundle_Injected(IntPtr _unity_self) { }

	// RVA: 0x2682040 Offset: 0x2680640 VA: 0x182682040
	private static bool get_autoLoadAssetBundle_Injected(IntPtr _unity_self) { }

	// RVA: 0x2682180 Offset: 0x2680780 VA: 0x182682180
	private static void set_autoLoadAssetBundle_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x26820E0 Offset: 0x26806E0 VA: 0x1826820E0
	private static bool get_isDownloadComplete_Injected(IntPtr _unity_self) { }
}

