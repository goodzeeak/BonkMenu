// Namespace: System.Net
internal class ContextAwareResult : LazyAsyncResult // TypeDefIndex: 7722
{
	// Fields
	private ExecutionContext _context; // 0x40
	private object _lock; // 0x48
	private ContextAwareResult.StateFlags _flags; // 0x50

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void SafeCaptureIdentity() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void CleanupInternal() { }

	// RVA: 0x1E4B4B0 Offset: 0x1E49AB0 VA: 0x181E4B4B0
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1E4B450 Offset: 0x1E49A50 VA: 0x181E4B450
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1E4B3E0 Offset: 0x1E499E0 VA: 0x181E4B3E0
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1E4B310 Offset: 0x1E49910 VA: 0x181E4B310
	internal object StartPostingAsyncOp() { }

	// RVA: 0x1E4B230 Offset: 0x1E49830 VA: 0x181E4B230
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x1E4B1F0 Offset: 0x1E497F0 VA: 0x181E4B1F0
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x1E4ACC0 Offset: 0x1E492C0 VA: 0x181E4ACC0 Slot: 9
	protected override void Cleanup() { }

	// RVA: 0x1E4A7D0 Offset: 0x1E48DD0 VA: 0x181E4A7D0
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x1E4AE90 Offset: 0x1E49490 VA: 0x181E4AE90 Slot: 8
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x1E4ADA0 Offset: 0x1E493A0 VA: 0x181E4ADA0
	private void CompleteCallback() { }
}

// Namespace: System.Net
internal static class HttpStatusDescription // TypeDefIndex: 7723
{
	// Methods

	// RVA: 0x1E52450 Offset: 0x1E50A50 VA: 0x181E52450
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x1E52460 Offset: 0x1E50A60 VA: 0x181E52460
	internal static string Get(int code) { }
}

// Namespace: System.Net
internal static class HttpValidationHelpers // TypeDefIndex: 7724
{
	// Fields
	private static readonly char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x1E52C40 Offset: 0x1E51240 VA: 0x181E52C40
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x1E52D70 Offset: 0x1E51370 VA: 0x181E52D70
	private static void .cctor() { }
}

// Namespace: System.Net
internal sealed class NetEventSource : EventSource // TypeDefIndex: 7726
{
	// Fields
	public static readonly NetEventSource Log; // 0x0

	// Properties
	public static bool IsEnabled { get; }

	// Methods

	[NonEvent]
	// RVA: 0x1E58B30 Offset: 0x1E57130 VA: 0x181E58B30
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x1E589B0 Offset: 0x1E56FB0 VA: 0x181E589B0
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	[NonEvent]
	// RVA: 0x1E58CC0 Offset: 0x1E572C0 VA: 0x181E58CC0
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	[Event(1, Level = 4, Keywords = 4)]
	// RVA: 0x1E58E70 Offset: 0x1E57470 VA: 0x181E58E70
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[NonEvent]
	// RVA: 0x1E59190 Offset: 0x1E57790 VA: 0x181E59190
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x1E59320 Offset: 0x1E57920 VA: 0x181E59320
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	[Event(2, Level = 4, Keywords = 4)]
	// RVA: 0x1E59100 Offset: 0x1E57700 VA: 0x181E59100
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[NonEvent]
	// RVA: 0x1E59E30 Offset: 0x1E58430 VA: 0x181E59E30
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x1E5A050 Offset: 0x1E58650 VA: 0x181E5A050
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	[Event(4, Level = 4, Keywords = 1)]
	// RVA: 0x1E59FC0 Offset: 0x1E585C0 VA: 0x181E59FC0
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x1E58F90 Offset: 0x1E57590 VA: 0x181E58F90
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	[Event(5, Level = 3, Keywords = 1)]
	// RVA: 0x1E58F00 Offset: 0x1E57500 VA: 0x181E58F00
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x1E59490 Offset: 0x1E57A90 VA: 0x181E59490
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	[Event(6, Level = 1, Keywords = 2)]
	// RVA: 0x1E58920 Offset: 0x1E56F20 VA: 0x181E58920
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x1E58700 Offset: 0x1E56D00 VA: 0x181E58700
	public static void Associate(object first, object second, string memberName) { }

	[Event(3, Level = 4, Keywords = 1, Message = "[{2}]<-->[{3}]")]
	// RVA: 0x1E58880 Offset: 0x1E56E80 VA: 0x181E58880
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x1E5A440 Offset: 0x1E58A40 VA: 0x181E5A440
	public static bool get_IsEnabled() { }

	[NonEvent]
	// RVA: 0x1E59D40 Offset: 0x1E58340 VA: 0x181E59D40
	public static string IdOf(object value) { }

	[NonEvent]
	// RVA: 0x709380 Offset: 0x707980 VA: 0x180709380
	public static int GetHashCode(object value) { }

	[NonEvent]
	// RVA: 0x1E59970 Offset: 0x1E57F70 VA: 0x181E59970
	public static object Format(object value) { }

	[NonEvent]
	// RVA: 0x1E59600 Offset: 0x1E57C00 VA: 0x181E59600
	private static string Format(FormattableString s) { }

	[NonEvent]
	// RVA: 0x1E5A1C0 Offset: 0x1E587C0 VA: 0x181E5A1C0
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x1AD28B0 Offset: 0x1AD0EB0 VA: 0x181AD28B0
	public void .ctor() { }

	// RVA: 0x1E5A3D0 Offset: 0x1E589D0 VA: 0x181E5A3D0
	private static void .cctor() { }
}

// Namespace: System.Net
internal static class TcpValidationHelpers // TypeDefIndex: 7727
{
	// Methods

	// RVA: 0x1E5DD00 Offset: 0x1E5C300 VA: 0x181E5DD00
	public static bool ValidatePortNumber(int port) { }
}

// Namespace: System.Net
internal class TlsStream : NetworkStream // TypeDefIndex: 7728
{
	// Fields
	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Methods

	// RVA: 0x1E5E130 Offset: 0x1E5C730 VA: 0x181E5E130
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x1E5DD20 Offset: 0x1E5C320 VA: 0x181E5DD20
	public void AuthenticateAsClient() { }

	// RVA: 0x1E5DE40 Offset: 0x1E5C440 VA: 0x181E5DE40
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x1E5E040 Offset: 0x1E5C640 VA: 0x181E5E040
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1E5DFC0 Offset: 0x1E5C5C0 VA: 0x181E5DFC0 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1E5E0A0 Offset: 0x1E5C6A0 VA: 0x181E5E0A0 Slot: 27
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x1E5E100 Offset: 0x1E5C700 VA: 0x181E5E100 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E5E0D0 Offset: 0x1E5C6D0 VA: 0x181E5E0D0 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E5DF80 Offset: 0x1E5C580 VA: 0x181E5DF80 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1E5E070 Offset: 0x1E5C670 VA: 0x181E5E070 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1E5E000 Offset: 0x1E5C600 VA: 0x181E5E000 Slot: 18
	public override void Close() { }
}

// Namespace: System.Net
public enum HttpStatusCode // TypeDefIndex: 7729
{
	// Fields
	public int value__; // 0x0
	public const HttpStatusCode Continue = 100;
	public const HttpStatusCode SwitchingProtocols = 101;
	public const HttpStatusCode Processing = 102;
	public const HttpStatusCode EarlyHints = 103;
	public const HttpStatusCode OK = 200;
	public const HttpStatusCode Created = 201;
	public const HttpStatusCode Accepted = 202;
	public const HttpStatusCode NonAuthoritativeInformation = 203;
	public const HttpStatusCode NoContent = 204;
	public const HttpStatusCode ResetContent = 205;
	public const HttpStatusCode PartialContent = 206;
	public const HttpStatusCode MultiStatus = 207;
	public const HttpStatusCode AlreadyReported = 208;
	public const HttpStatusCode IMUsed = 226;
	public const HttpStatusCode MultipleChoices = 300;
	public const HttpStatusCode Ambiguous = 300;
	public const HttpStatusCode MovedPermanently = 301;
	public const HttpStatusCode Moved = 301;
	public const HttpStatusCode Found = 302;
	public const HttpStatusCode Redirect = 302;
	public const HttpStatusCode SeeOther = 303;
	public const HttpStatusCode RedirectMethod = 303;
	public const HttpStatusCode NotModified = 304;
	public const HttpStatusCode UseProxy = 305;
	public const HttpStatusCode Unused = 306;
	public const HttpStatusCode TemporaryRedirect = 307;
	public const HttpStatusCode RedirectKeepVerb = 307;
	public const HttpStatusCode PermanentRedirect = 308;
	public const HttpStatusCode BadRequest = 400;
	public const HttpStatusCode Unauthorized = 401;
	public const HttpStatusCode PaymentRequired = 402;
	public const HttpStatusCode Forbidden = 403;
	public const HttpStatusCode NotFound = 404;
	public const HttpStatusCode MethodNotAllowed = 405;
	public const HttpStatusCode NotAcceptable = 406;
	public const HttpStatusCode ProxyAuthenticationRequired = 407;
	public const HttpStatusCode RequestTimeout = 408;
	public const HttpStatusCode Conflict = 409;
	public const HttpStatusCode Gone = 410;
	public const HttpStatusCode LengthRequired = 411;
	public const HttpStatusCode PreconditionFailed = 412;
	public const HttpStatusCode RequestEntityTooLarge = 413;
	public const HttpStatusCode RequestUriTooLong = 414;
	public const HttpStatusCode UnsupportedMediaType = 415;
	public const HttpStatusCode RequestedRangeNotSatisfiable = 416;
	public const HttpStatusCode ExpectationFailed = 417;
	public const HttpStatusCode MisdirectedRequest = 421;
	public const HttpStatusCode UnprocessableEntity = 422;
	public const HttpStatusCode Locked = 423;
	public const HttpStatusCode FailedDependency = 424;
	public const HttpStatusCode UpgradeRequired = 426;
	public const HttpStatusCode PreconditionRequired = 428;
	public const HttpStatusCode TooManyRequests = 429;
	public const HttpStatusCode RequestHeaderFieldsTooLarge = 431;
	public const HttpStatusCode UnavailableForLegalReasons = 451;
	public const HttpStatusCode InternalServerError = 500;
	public const HttpStatusCode NotImplemented = 501;
	public const HttpStatusCode BadGateway = 502;
	public const HttpStatusCode ServiceUnavailable = 503;
	public const HttpStatusCode GatewayTimeout = 504;
	public const HttpStatusCode HttpVersionNotSupported = 505;
	public const HttpStatusCode VariantAlsoNegotiates = 506;
	public const HttpStatusCode InsufficientStorage = 507;
	public const HttpStatusCode LoopDetected = 508;
	public const HttpStatusCode NotExtended = 510;
	public const HttpStatusCode NetworkAuthenticationRequired = 511;
}

// Namespace: System.Net
public class HttpVersion // TypeDefIndex: 7730
{
	// Fields
	public static readonly Version Unknown; // 0x0
	public static readonly Version Version10; // 0x8
	public static readonly Version Version11; // 0x10
	public static readonly Version Version20; // 0x18

	// Methods

	// RVA: 0x1E52E00 Offset: 0x1E51400 VA: 0x181E52E00
	private static void .cctor() { }
}

// Namespace: System.Net
[Serializable]
public class IPAddress // TypeDefIndex: 7732
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private uint _addressOrScopeId; // 0x10
	private readonly ushort[] _numbers; // 0x18
	private string _toString; // 0x20
	private int _hashCode; // 0x28
	internal const int NumberOfLabels = 8;

	// Properties
	private bool IsIPv4 { get; }
	private bool IsIPv6 { get; }
	private uint PrivateAddress { get; set; }
	private uint PrivateScopeId { get; set; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }

	// Methods

	// RVA: 0x1353A60 Offset: 0x1352060 VA: 0x181353A60
	private bool get_IsIPv4() { }

	// RVA: 0x136E330 Offset: 0x136C930 VA: 0x18136E330
	private bool get_IsIPv6() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	private uint get_PrivateAddress() { }

	// RVA: 0x1E54810 Offset: 0x1E52E10 VA: 0x181E54810
	private void set_PrivateAddress(uint value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	private uint get_PrivateScopeId() { }

	// RVA: 0x1E54810 Offset: 0x1E52E10 VA: 0x181E54810
	private void set_PrivateScopeId(uint value) { }

	// RVA: 0x1E54340 Offset: 0x1E52940 VA: 0x181E54340
	public void .ctor(long newAddress) { }

	// RVA: 0x1E541D0 Offset: 0x1E527D0 VA: 0x181E541D0
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x1E545A0 Offset: 0x1E52BA0 VA: 0x181E545A0
	public void .ctor(ReadOnlySpan<byte> address, long scopeid) { }

	// RVA: 0x1E54270 Offset: 0x1E52870 VA: 0x181E54270
	internal void .ctor(ushort* numbers, int numbersLength, uint scopeid) { }

	// RVA: 0x1E54170 Offset: 0x1E52770 VA: 0x181E54170
	private void .ctor(ushort[] numbers, uint scopeid) { }

	// RVA: 0x1E540E0 Offset: 0x1E526E0 VA: 0x181E540E0
	public void .ctor(byte[] address) { }

	// RVA: 0x1E543E0 Offset: 0x1E529E0 VA: 0x181E543E0
	public void .ctor(ReadOnlySpan<byte> address) { }

	// RVA: 0x1E53B10 Offset: 0x1E52110 VA: 0x181E53B10
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x1E539A0 Offset: 0x1E51FA0 VA: 0x181E539A0
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x1E53BC0 Offset: 0x1E521C0 VA: 0x181E53BC0
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1E49DB0 Offset: 0x1E483B0 VA: 0x181E49DB0
	private void WriteIPv6Bytes(Span<byte> destination) { }

	// RVA: 0x1E53CD0 Offset: 0x1E522D0 VA: 0x181E53CD0
	private void WriteIPv4Bytes(Span<byte> destination) { }

	// RVA: 0x1E531A0 Offset: 0x1E517A0 VA: 0x181E531A0
	public byte[] GetAddressBytes() { }

	// RVA: 0x1E54790 Offset: 0x1E52D90 VA: 0x181E54790
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1E547B0 Offset: 0x1E52DB0 VA: 0x181E547B0
	public long get_ScopeId() { }

	// RVA: 0x1E53AB0 Offset: 0x1E520B0 VA: 0x181E53AB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E537B0 Offset: 0x1E51DB0 VA: 0x181E537B0
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x1E53060 Offset: 0x1E51660 VA: 0x181E53060
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1E52F70 Offset: 0x1E51570 VA: 0x181E52F70 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1E53320 Offset: 0x1E51920 VA: 0x181E53320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E53880 Offset: 0x1E51E80 VA: 0x181E53880
	public IPAddress MapToIPv6() { }

	// RVA: 0x1E53A60 Offset: 0x1E52060 VA: 0x181E53A60
	private static byte[] ThrowAddressNullException() { }

	// RVA: 0x1E53D20 Offset: 0x1E52320 VA: 0x181E53D20
	private static void .cctor() { }
}

// Namespace: System.Net
internal class IPAddressParser // TypeDefIndex: 7733
{
	// Methods

	// RVA: 0x1E79F90 Offset: 0x1E78590 VA: 0x181E79F90
	internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse) { }

	// RVA: 0x1E79850 Offset: 0x1E77E50 VA: 0x181E79850
	internal static string IPv4AddressToString(uint address) { }

	// RVA: 0x1E798B0 Offset: 0x1E77EB0 VA: 0x181E798B0
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	// RVA: 0x1E795C0 Offset: 0x1E77BC0 VA: 0x181E795C0
	private static int IPv4AddressToStringHelper(uint address, char* addressString) { }

	// RVA: 0x1E79D20 Offset: 0x1E78320 VA: 0x181E79D20
	internal static string IPv6AddressToString(ushort[] address, uint scopeId) { }

	// RVA: 0x1E79920 Offset: 0x1E77F20 VA: 0x181E79920
	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId) { }

	// RVA: 0x1E79510 Offset: 0x1E77B10 VA: 0x181E79510
	private static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset) { }

	// RVA: 0x1E79D40 Offset: 0x1E78340 VA: 0x181E79D40
	public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address) { }

	// RVA: 0x1E79E20 Offset: 0x1E78420 VA: 0x181E79E20
	public static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope) { }

	// RVA: 0x1E79320 Offset: 0x1E77920 VA: 0x181E79320
	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x1E79270 Offset: 0x1E77870 VA: 0x181E79270
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	// RVA: 0x1E794D0 Offset: 0x1E77AD0 VA: 0x181E794D0
	private static uint ExtractIPv4Address(ushort[] address) { }

	// RVA: 0x1E7A2E0 Offset: 0x1E788E0 VA: 0x181E7A2E0
	private static ushort Reverse(ushort number) { }
}

// Namespace: System.Net
[Serializable]
public class IPEndPoint : EndPoint // TypeDefIndex: 7734
{
	// Fields
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x1E7AC70 Offset: 0x1E79270 VA: 0x181E7AC70 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1E7AB80 Offset: 0x1E79180 VA: 0x181E7AB80
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IPAddress get_Address() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Port() { }

	// RVA: 0x1E7A820 Offset: 0x1E78E20 VA: 0x181E7A820 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E7A780 Offset: 0x1E78D80 VA: 0x181E7A780 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x1E7A2F0 Offset: 0x1E788F0 VA: 0x181E7A2F0 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1E7A690 Offset: 0x1E78C90 VA: 0x181E7A690 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1E7A740 Offset: 0x1E78D40 VA: 0x181E7A740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E7A8F0 Offset: 0x1E78EF0 VA: 0x181E7A8F0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CommandStream : NetworkStreamWrapper // TypeDefIndex: 7738
{
	// Fields
	private static readonly AsyncCallback s_writeCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; // 0x8
	private bool _recoverableFailure; // 0x38
	protected WebRequest _request; // 0x40
	protected bool _isAsync; // 0x48
	private bool _aborted; // 0x49
	protected CommandStream.PipelineEntry[] _commands; // 0x50
	protected int _index; // 0x58
	private bool _doRead; // 0x5C
	private bool _doSend; // 0x5D
	private ResponseDescription _currentResponseDescription; // 0x60
	protected string _abortReason; // 0x68
	private string _buffer; // 0x70
	private Encoding _encoding; // 0x78
	private Decoder _decoder; // 0x80

	// Properties
	internal bool RecoverableFailure { get; }
	protected Encoding Encoding { get; set; }

	// Methods

	// RVA: 0x1E69A00 Offset: 0x1E68000 VA: 0x181E69A00
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1E67E00 Offset: 0x1E66400 VA: 0x181E67E00 Slot: 37
	internal virtual void Abort(Exception e) { }

	// RVA: 0x1E68510 Offset: 0x1E66B10 VA: 0x181E68510 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E68770 Offset: 0x1E66D70 VA: 0x181E68770
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	internal bool get_RecoverableFailure() { }

	// RVA: 0x1E68800 Offset: 0x1E66E00 VA: 0x181E68800
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x1E696E0 Offset: 0x1E67CE0 VA: 0x181E696E0
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x1E68010 Offset: 0x1E66610 VA: 0x181E68010 Slot: 38
	protected virtual void ClearState() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 39
	protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x1E68650 Offset: 0x1E66C50 VA: 0x181E68650
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x1E685A0 Offset: 0x1E66BA0 VA: 0x181E685A0
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x1E686D0 Offset: 0x1E66CD0 VA: 0x181E686D0
	protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x1E67FD0 Offset: 0x1E665D0 VA: 0x181E67FD0
	internal void CheckContinuePipeline() { }

	// RVA: 0x1E68030 Offset: 0x1E66630 VA: 0x181E68030
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x1E68A30 Offset: 0x1E67030 VA: 0x181E68A30
	private bool PostSendCommandProcessing(ref Stream stream) { }

	// RVA: 0x1E68810 Offset: 0x1E66E10 VA: 0x181E68810
	private bool PostReadCommandProcessing(ref Stream stream) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 40
	protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x1E68B30 Offset: 0x1E67130 VA: 0x181E68B30
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1E69780 Offset: 0x1E67D80 VA: 0x181E69780
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	protected Encoding get_Encoding() { }

	// RVA: 0x1E69B00 Offset: 0x1E68100 VA: 0x181E69B00
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 41
	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x1E69370 Offset: 0x1E67970 VA: 0x181E69370
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x1E68D20 Offset: 0x1E67320 VA: 0x181E68D20
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x1E69910 Offset: 0x1E67F10 VA: 0x181E69910
	private static void .cctor() { }
}

// Namespace: System.Net
internal class ResponseDescription // TypeDefIndex: 7739
{
	// Fields
	internal bool Multiline; // 0x10
	internal int Status; // 0x14
	internal string StatusDescription; // 0x18
	internal StringBuilder StatusBuffer; // 0x20
	internal string StatusCodeString; // 0x28

	// Properties
	internal bool PositiveIntermediate { get; }
	internal bool PositiveCompletion { get; }
	internal bool TransientFailure { get; }
	internal bool PermanentFailure { get; }
	internal bool InvalidStatusCode { get; }

	// Methods

	// RVA: 0x1E7CA00 Offset: 0x1E7B000 VA: 0x181E7CA00
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x1E7C9E0 Offset: 0x1E7AFE0 VA: 0x181E7C9E0
	internal bool get_PositiveCompletion() { }

	// RVA: 0x1E7CA20 Offset: 0x1E7B020 VA: 0x181E7CA20
	internal bool get_TransientFailure() { }

	// RVA: 0x1E7C9C0 Offset: 0x1E7AFC0 VA: 0x181E7C9C0
	internal bool get_PermanentFailure() { }

	// RVA: 0x1E7C9A0 Offset: 0x1E7AFA0 VA: 0x181E7C9A0
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x1E7C930 Offset: 0x1E7AF30 VA: 0x181E7C930
	public void .ctor() { }
}

// Namespace: System.Net
internal class ReceiveState // TypeDefIndex: 7740
{
	// Fields
	internal ResponseDescription Resp; // 0x10
	internal int ValidThrough; // 0x18
	internal byte[] Buffer; // 0x20
	internal CommandStream Connection; // 0x28

	// Methods

	// RVA: 0x1E7C820 Offset: 0x1E7AE20 VA: 0x181E7C820
	internal void .ctor(CommandStream connection) { }
}

// Namespace: System.Net
internal enum FtpLoginState // TypeDefIndex: 7741
{
	// Fields
	public byte value__; // 0x0
	public const FtpLoginState NotLoggedIn = 0;
	public const FtpLoginState LoggedIn = 1;
	public const FtpLoginState LoggedInButNeedsRelogin = 2;
	public const FtpLoginState ReloginFailed = 3;
}

// Namespace: System.Net
internal class FtpControlStream : CommandStream // TypeDefIndex: 7744
{
	// Fields
	private Socket _dataSocket; // 0x88
	private IPEndPoint _passiveEndPoint; // 0x90
	private TlsStream _tlsStream; // 0x98
	private StringBuilder _bannerMessage; // 0xA0
	private StringBuilder _welcomeMessage; // 0xA8
	private StringBuilder _exitMessage; // 0xB0
	private WeakReference _credentials; // 0xB8
	private string _currentTypeSetting; // 0xC0
	private long _contentLength; // 0xC8
	private DateTime _lastModified; // 0xD0
	private bool _dataHandshakeStarted; // 0xD8
	private string _loginDirectory; // 0xE0
	private string _establishedServerDirectory; // 0xE8
	private string _requestedServerDirectory; // 0xF0
	private Uri _responseUri; // 0xF8
	private FtpLoginState _loginState; // 0x100
	internal FtpStatusCode StatusCode; // 0x104
	internal string StatusLine; // 0x108
	private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; // 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10

	// Properties
	internal NetworkCredential Credentials { get; set; }
	internal long ContentLength { get; }
	internal DateTime LastModified { get; }
	internal Uri ResponseUri { get; }
	internal string BannerMessage { get; }
	internal string WelcomeMessage { get; }
	internal string ExitMessage { get; }

	// Methods

	// RVA: 0x1E6F5D0 Offset: 0x1E6DBD0 VA: 0x181E6F5D0
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x1E6F6F0 Offset: 0x1E6DCF0 VA: 0x181E6F6F0
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x1E6F440 Offset: 0x1E6DA40 VA: 0x181E6F440
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1E6A110 Offset: 0x1E68710 VA: 0x181E6A110
	internal void AbortConnect() { }

	// RVA: 0x1E6A130 Offset: 0x1E68730 VA: 0x181E6A130
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1E6BC70 Offset: 0x1E6A270 VA: 0x181E6BC70
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1E6ED30 Offset: 0x1E6D330 VA: 0x181E6ED30
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1E6E9E0 Offset: 0x1E6CFE0 VA: 0x181E6E9E0
	private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	// RVA: 0x1E6BB70 Offset: 0x1E6A170 VA: 0x181E6BB70 Slot: 38
	protected override void ClearState() { }

	// RVA: 0x1E6D2D0 Offset: 0x1E6B8D0 VA: 0x181E6D2D0 Slot: 40
	protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x1E6A430 Offset: 0x1E68A30 VA: 0x181E6A430 Slot: 39
	protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x1E6E2A0 Offset: 0x1E6C8A0 VA: 0x181E6E2A0
	private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	// RVA: 0x1E6C8E0 Offset: 0x1E6AEE0 VA: 0x181E6C8E0
	private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	// RVA: 0x1E6C1D0 Offset: 0x1E6A7D0 VA: 0x181E6C1D0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1E6C0C0 Offset: 0x1E6A6C0 VA: 0x181E6C0C0
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	internal long get_ContentLength() { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	internal DateTime get_LastModified() { }

	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	internal Uri get_ResponseUri() { }

	// RVA: 0x1E6F5A0 Offset: 0x1E6DBA0 VA: 0x181E6F5A0
	internal string get_BannerMessage() { }

	// RVA: 0x1E6F6C0 Offset: 0x1E6DCC0 VA: 0x181E6F6C0
	internal string get_WelcomeMessage() { }

	// RVA: 0x1E6F690 Offset: 0x1E6DC90 VA: 0x181E6F690
	internal string get_ExitMessage() { }

	// RVA: 0x1E6C420 Offset: 0x1E6AA20 VA: 0x181E6C420
	private long GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x1E6C550 Offset: 0x1E6AB50 VA: 0x181E6C550
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x1E6EF50 Offset: 0x1E6D550 VA: 0x181E6EF50
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x1E6EE60 Offset: 0x1E6D460 VA: 0x181E6EE60
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x1E6C850 Offset: 0x1E6AE50 VA: 0x181E6C850
	private string GetLoginDirectory(string str) { }

	// RVA: 0x1E6CE80 Offset: 0x1E6B480 VA: 0x181E6CE80
	private int GetPortV4(string responseString) { }

	// RVA: 0x1E6D050 Offset: 0x1E6B650 VA: 0x181E6D050
	private int GetPortV6(string responseString) { }

	// RVA: 0x1E6BE30 Offset: 0x1E6A430 VA: 0x181E6BE30
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x1E6CAA0 Offset: 0x1E6B0A0 VA: 0x181E6CAA0
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x1E6C310 Offset: 0x1E6A910 VA: 0x181E6C310
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x1E6BDA0 Offset: 0x1E6A3A0 VA: 0x181E6BDA0
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x1E6B7D0 Offset: 0x1E69DD0 VA: 0x181E6B7D0 Slot: 41
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x1E6D250 Offset: 0x1E6B850 VA: 0x181E6D250
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x1E6F300 Offset: 0x1E6D900 VA: 0x181E6F300
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FtpDataStream : Stream, ICloseEx // TypeDefIndex: 7745
{
	// Fields
	private FtpWebRequest _request; // 0x28
	private NetworkStream _networkStream; // 0x30
	private bool _writeable; // 0x38
	private bool _readable; // 0x39
	private bool _isFullyRead; // 0x3A
	private bool _closing; // 0x3B

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x1E70570 Offset: 0x1E6EB70 VA: 0x181E70570
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x1E6FBC0 Offset: 0x1E6E1C0 VA: 0x181E6FBC0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E70140 Offset: 0x1E6E740 VA: 0x181E70140 Slot: 37
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1E6FB70 Offset: 0x1E6E170 VA: 0x181E6FB70
	private void CheckError() { }

	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1E70680 Offset: 0x1E6EC80 VA: 0x181E70680 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x14CA150 Offset: 0x14C8750 VA: 0x1814CA150 Slot: 11
	public override long get_Length() { }

	// RVA: 0x14CA1B0 Offset: 0x14C87B0 VA: 0x1814CA1B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1410880 Offset: 0x140EE80 VA: 0x181410880 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E70040 Offset: 0x1E6E640 VA: 0x181E70040 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E6FF70 Offset: 0x1E6E570 VA: 0x181E6FF70 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E704D0 Offset: 0x1E6EAD0 VA: 0x181E704D0 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E6F7A0 Offset: 0x1E6DDA0 VA: 0x181E6F7A0
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x1E6F930 Offset: 0x1E6DF30 VA: 0x181E6F930 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1E6FC80 Offset: 0x1E6E280 VA: 0x181E6FC80 Slot: 23
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1E6FAB0 Offset: 0x1E6E0B0 VA: 0x181E6FAB0 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1E6FE60 Offset: 0x1E6E460 VA: 0x181E6FE60 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1E6FF40 Offset: 0x1E6E540 VA: 0x181E6FF40 Slot: 20
	public override void Flush() { }

	// RVA: 0x1E706B0 Offset: 0x1E6ECB0 VA: 0x181E706B0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1E706E0 Offset: 0x1E6ECE0 VA: 0x181E706E0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1410A20 Offset: 0x140F020 VA: 0x181410A20 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1E70710 Offset: 0x1E6ED10 VA: 0x181E70710 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x14125D0 Offset: 0x1410BD0 VA: 0x1814125D0 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1E700E0 Offset: 0x1E6E6E0 VA: 0x181E700E0
	internal void SetSocketTimeoutOption(int timeout) { }
}

// Namespace: System.Net
internal enum FtpOperation // TypeDefIndex: 7746
{
	// Fields
	public int value__; // 0x0
	public const FtpOperation DownloadFile = 0;
	public const FtpOperation ListDirectory = 1;
	public const FtpOperation ListDirectoryDetails = 2;
	public const FtpOperation UploadFile = 3;
	public const FtpOperation UploadFileUnique = 4;
	public const FtpOperation AppendFile = 5;
	public const FtpOperation DeleteFile = 6;
	public const FtpOperation GetDateTimestamp = 7;
	public const FtpOperation GetFileSize = 8;
	public const FtpOperation Rename = 9;
	public const FtpOperation MakeDirectory = 10;
	public const FtpOperation RemoveDirectory = 11;
	public const FtpOperation PrintWorkingDirectory = 12;
	public const FtpOperation Other = 13;
}

// Namespace: System.Net
[Flags]
internal enum FtpMethodFlags // TypeDefIndex: 7747
{
	// Fields
	public int value__; // 0x0
	public const FtpMethodFlags None = 0;
	public const FtpMethodFlags IsDownload = 1;
	public const FtpMethodFlags IsUpload = 2;
	public const FtpMethodFlags TakesParameter = 4;
	public const FtpMethodFlags MayTakeParameter = 8;
	public const FtpMethodFlags DoesNotTakeParameter = 16;
	public const FtpMethodFlags ParameterIsDirectory = 32;
	public const FtpMethodFlags ShouldParseForResponseUri = 64;
	public const FtpMethodFlags HasHttpCommand = 128;
	public const FtpMethodFlags MustChangeWorkingDirectoryToPath = 256;
}

// Namespace: System.Net
internal class FtpMethodInfo // TypeDefIndex: 7748
{
	// Fields
	internal string Method; // 0x10
	internal FtpOperation Operation; // 0x18
	internal FtpMethodFlags Flags; // 0x1C
	internal string HttpCommand; // 0x20
	private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x0

	// Properties
	internal bool IsCommandOnly { get; }
	internal bool IsUpload { get; }
	internal bool IsDownload { get; }
	internal bool ShouldParseForResponseUri { get; }

	// Methods

	// RVA: 0x1E71170 Offset: 0x1E6F770 VA: 0x181E71170
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x1E708A0 Offset: 0x1E6EEA0 VA: 0x181E708A0
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x1E711E0 Offset: 0x1E6F7E0 VA: 0x181E711E0
	internal bool get_IsCommandOnly() { }

	// RVA: 0x1E711F0 Offset: 0x1E6F7F0 VA: 0x181E711F0
	internal bool get_IsUpload() { }

	// RVA: 0x1BB4DE0 Offset: 0x1BB33E0 VA: 0x181BB4DE0
	internal bool get_IsDownload() { }

	// RVA: 0x1E71200 Offset: 0x1E6F800 VA: 0x181E71200
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x1E70740 Offset: 0x1E6ED40 VA: 0x181E70740
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x1E708B0 Offset: 0x1E6EEB0 VA: 0x181E708B0
	private static void .cctor() { }
}

// Namespace: System.Net
public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 7752
{
	// Fields
	private object _syncObject; // 0x38
	private ICredentials _authInfo; // 0x40
	private readonly Uri _uri; // 0x48
	private FtpMethodInfo _methodInfo; // 0x50
	private string _renameTo; // 0x58
	private bool _getRequestStreamStarted; // 0x60
	private bool _getResponseStarted; // 0x61
	private DateTime _startTime; // 0x68
	private int _timeout; // 0x70
	private int _remainingTimeout; // 0x74
	private long _contentLength; // 0x78
	private long _contentOffset; // 0x80
	private X509CertificateCollection _clientCertificates; // 0x88
	private bool _passive; // 0x90
	private bool _binary; // 0x91
	private bool _async; // 0x92
	private bool _aborted; // 0x93
	private bool _timedOut; // 0x94
	private Exception _exception; // 0x98
	private TimerThread.Queue _timerQueue; // 0xA0
	private TimerThread.Callback _timerCallback; // 0xA8
	private bool _enableSsl; // 0xB0
	private FtpControlStream _connection; // 0xB8
	private Stream _stream; // 0xC0
	private FtpWebRequest.RequestStage _requestStage; // 0xC8
	private bool _onceFailed; // 0xCC
	private WebHeaderCollection _ftpRequestHeaders; // 0xD0
	private FtpWebResponse _ftpWebResponse; // 0xD8
	private int _readWriteTimeout; // 0xE0
	private ContextAwareResult _writeAsyncResult; // 0xE8
	private LazyAsyncResult _readAsyncResult; // 0xF0
	private LazyAsyncResult _requestCompleteAsyncResult; // 0xF8
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x0
	private static readonly TimerThread.Queue s_DefaultTimerQueue; // 0x8

	// Properties
	internal FtpMethodInfo MethodInfo { get; }
	public override string Method { get; set; }
	public string RenameTo { get; }
	public override ICredentials Credentials { get; set; }
	public override Uri RequestUri { get; }
	public override int Timeout { get; }
	internal int RemainingTimeout { get; }
	public int ReadWriteTimeout { get; }
	public long ContentOffset { get; }
	public override long ContentLength { get; }
	public override IWebProxy Proxy { get; set; }
	internal bool Aborted { get; }
	private TimerThread.Queue TimerQueue { get; }
	public override RequestCachePolicy CachePolicy { set; }
	public bool UseBinary { get; }
	public bool UsePassive { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public bool EnableSsl { get; }
	public override WebHeaderCollection Headers { get; }
	public override bool UseDefaultCredentials { get; }
	private bool InUse { get; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x1E75D30 Offset: 0x1E74330 VA: 0x181E75D30 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1E75FF0 Offset: 0x1E745F0 VA: 0x181E75FF0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_RenameTo() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x1E75E70 Offset: 0x1E74470 VA: 0x181E75E70 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x19774D0 Offset: 0x1975AD0 VA: 0x1819774D0
	internal int get_RemainingTimeout() { }

	// RVA: 0x16EE3A0 Offset: 0x16EC9A0 VA: 0x1816EE3A0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public long get_ContentOffset() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1E76190 Offset: 0x1E74790 VA: 0x181E76190 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1AAA360 Offset: 0x1AA8960 VA: 0x181AAA360
	internal bool get_Aborted() { }

	// RVA: 0x1E75690 Offset: 0x1E73C90 VA: 0x181E75690
	internal void .ctor(Uri uri) { }

	// RVA: 0x1E739E0 Offset: 0x1E71FE0 VA: 0x181E739E0 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1E722E0 Offset: 0x1E708E0 VA: 0x181E722E0 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1E72B60 Offset: 0x1E71160 VA: 0x181E72B60 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1E74500 Offset: 0x1E72B00 VA: 0x181E74500
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x1E75410 Offset: 0x1E73A10 VA: 0x181E75410
	private Exception TranslateConnectException(Exception e) { }

	[AsyncStateMachine(typeof(FtpWebRequest.<CreateConnectionAsync>d__86))]
	// RVA: 0x1E728E0 Offset: 0x1E70EE0 VA: 0x181E728E0
	private void CreateConnectionAsync() { }

	// RVA: 0x1E729A0 Offset: 0x1E70FA0 VA: 0x181E729A0
	private FtpControlStream CreateConnection() { }

	// RVA: 0x1E74E50 Offset: 0x1E73450 VA: 0x181E74E50
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x1E75310 Offset: 0x1E73910 VA: 0x181E75310
	private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x1E75D50 Offset: 0x1E74350 VA: 0x181E75D50
	private TimerThread.Queue get_TimerQueue() { }

	// RVA: 0x1E72030 Offset: 0x1E70630 VA: 0x181E72030
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x1E74100 Offset: 0x1E72700 VA: 0x181E74100
	private void SetException(Exception exception) { }

	// RVA: 0x1E728C0 Offset: 0x1E70EC0 VA: 0x181E728C0
	private void CheckError() { }

	// RVA: 0x1E740E0 Offset: 0x1E726E0 VA: 0x181E740E0
	internal void RequestCallback(object obj) { }

	// RVA: 0x1E74A80 Offset: 0x1E73080 VA: 0x181E74A80
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x1E71600 Offset: 0x1E6FC00 VA: 0x181E71600
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x1E734F0 Offset: 0x1E71AF0 VA: 0x181E734F0
	private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage) { }

	// RVA: 0x1E71270 Offset: 0x1E6F870 VA: 0x181E71270 Slot: 24
	public override void Abort() { }

	// RVA: 0x1E75E00 Offset: 0x1E74400 VA: 0x181E75E00 Slot: 8
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1AAA350 Offset: 0x1AA8950 VA: 0x181AAA350
	public bool get_UseBinary() { }

	// RVA: 0x534920 Offset: 0x532F20 VA: 0x180534920
	public bool get_UsePassive() { }

	// RVA: 0x1E75B30 Offset: 0x1E74130 VA: 0x181E75B30
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1641010 Offset: 0x163F610 VA: 0x181641010
	public bool get_EnableSsl() { }

	// RVA: 0x1E75C50 Offset: 0x1E74250 VA: 0x181E75C50 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1E75DD0 Offset: 0x1E743D0 VA: 0x181E75DD0 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1E75D10 Offset: 0x1E74310 VA: 0x181E75D10
	private bool get_InUse() { }

	// RVA: 0x1E72E40 Offset: 0x1E71440 VA: 0x181E72E40
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x1E72AB0 Offset: 0x1E710B0 VA: 0x181E72AB0
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x1E754F0 Offset: 0x1E73AF0 VA: 0x181E754F0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FtpWebRequestCreator : IWebRequestCreate // TypeDefIndex: 7753
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1E71210 Offset: 0x1E6F810 VA: 0x181E71210 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: System.Net
public class FtpWebResponse : WebResponse, IDisposable // TypeDefIndex: 7755
{
	// Fields
	internal Stream _responseStream; // 0x20
	private long _contentLength; // 0x28
	private Uri _responseUri; // 0x30
	private FtpStatusCode _statusCode; // 0x38
	private string _statusLine; // 0x40
	private WebHeaderCollection _ftpRequestHeaders; // 0x48
	private DateTime _lastModified; // 0x50
	private string _bannerMessage; // 0x58
	private string _welcomeMessage; // 0x60
	private string _exitMessage; // 0x68

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public FtpStatusCode StatusCode { get; }

	// Methods

	// RVA: 0x1E764E0 Offset: 0x1E74AE0 VA: 0x181E764E0
	internal void .ctor(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x1E764A0 Offset: 0x1E74AA0 VA: 0x181E764A0
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x1E762F0 Offset: 0x1E748F0 VA: 0x181E762F0 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x1E76400 Offset: 0x1E74A00 VA: 0x181E76400
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x1E76200 Offset: 0x1E74800 VA: 0x181E76200 Slot: 9
	public override void Close() { }

	// RVA: 0x1E76640 Offset: 0x1E74C40 VA: 0x181E76640 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public FtpStatusCode get_StatusCode() { }
}

// Namespace: System.Net
internal class NetworkStreamWrapper : Stream // TypeDefIndex: 7756
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Properties
	protected bool UsingSecureStream { get; }
	internal IPAddress ServerAddress { get; }
	internal Socket Socket { get; }
	internal NetworkStream NetworkStream { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E7C5B0 Offset: 0x1E7ABB0 VA: 0x181E7C5B0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1E7C700 Offset: 0x1E7AD00 VA: 0x181E7C700
	protected bool get_UsingSecureStream() { }

	// RVA: 0x1E7C670 Offset: 0x1E7AC70 VA: 0x181E7C670
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x1782D10 Offset: 0x1781310 VA: 0x181782D10
	internal Socket get_Socket() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x14CA180 Offset: 0x14C8780 VA: 0x1814CA180 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1E70680 Offset: 0x1E6EC80 VA: 0x181E70680 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E7C640 Offset: 0x1E7AC40 VA: 0x181E7C640 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E706B0 Offset: 0x1E6ECB0 VA: 0x181E706B0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1E706E0 Offset: 0x1E6ECE0 VA: 0x181E706E0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1410A20 Offset: 0x140F020 VA: 0x181410A20 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1E70710 Offset: 0x1E6ED10 VA: 0x181E70710 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x14125D0 Offset: 0x1410BD0 VA: 0x1814125D0 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x14CA150 Offset: 0x14C8750 VA: 0x1814CA150 Slot: 11
	public override long get_Length() { }

	// RVA: 0x14CA1B0 Offset: 0x14C87B0 VA: 0x1814CA1B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1410880 Offset: 0x140EE80 VA: 0x181410880 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E7C520 Offset: 0x1E7AB20 VA: 0x181E7C520 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E7C4F0 Offset: 0x1E7AAF0 VA: 0x181E7C4F0 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E7C580 Offset: 0x1E7AB80 VA: 0x181E7C580 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E7C380 Offset: 0x1E7A980 VA: 0x181E7C380 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E7C300 Offset: 0x1E7A900 VA: 0x181E7C300
	internal void CloseSocket() { }

	// RVA: 0x1E7C340 Offset: 0x1E7A940 VA: 0x181E7C340
	public void Close(int timeout) { }

	// RVA: 0x1E7C280 Offset: 0x1E7A880 VA: 0x181E7C280 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1E7C430 Offset: 0x1E7AA30 VA: 0x181E7C430 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1E7C4C0 Offset: 0x1E7AAC0 VA: 0x181E7C4C0 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1E7C2C0 Offset: 0x1E7A8C0 VA: 0x181E7C2C0 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1E7C460 Offset: 0x1E7AA60 VA: 0x181E7C460 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1E7C550 Offset: 0x1E7AB50 VA: 0x181E7C550 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1E6FF40 Offset: 0x1E6E540 VA: 0x181E6FF40 Slot: 20
	public override void Flush() { }

	// RVA: 0x1E7C490 Offset: 0x1E7AA90 VA: 0x181E7C490 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1E700E0 Offset: 0x1E6E6E0 VA: 0x181E700E0
	internal void SetSocketTimeoutOption(int timeout) { }
}

// Namespace: System.Net
[Flags]
public enum SecurityProtocolType // TypeDefIndex: 7757
{
	// Fields
	public int value__; // 0x0
	public const SecurityProtocolType SystemDefault = 0;
	public const SecurityProtocolType Ssl3 = 48;
	public const SecurityProtocolType Tls = 192;
	public const SecurityProtocolType Tls11 = 768;
	public const SecurityProtocolType Tls12 = 3072;
	public const SecurityProtocolType Tls13 = 12288;
}

// Namespace: System.Net
public class Authorization // TypeDefIndex: 7758
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x1E67430 Offset: 0x1E65A30 VA: 0x181E67430
	public void .ctor(string token) { }

	// RVA: 0x1E674B0 Offset: 0x1E65AB0 VA: 0x181E674B0
	public void .ctor(string token, bool finished) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Message() { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_Complete() { }
}

// Namespace: System.Net
public class CredentialCache // TypeDefIndex: 7759
{
	// Properties
	public static ICredentials DefaultCredentials { get; }
	public static NetworkCredential DefaultNetworkCredentials { get; }

	// Methods

	// RVA: 0x1E69B60 Offset: 0x1E68160 VA: 0x181E69B60
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x1E69BB0 Offset: 0x1E681B0 VA: 0x181E69BB0
	public static NetworkCredential get_DefaultNetworkCredentials() { }
}

// Namespace: System.Net
internal class SystemNetworkCredential : NetworkCredential // TypeDefIndex: 7760
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x1E7D990 Offset: 0x1E7BF90 VA: 0x181E7D990
	private void .ctor() { }

	// RVA: 0x1E7D880 Offset: 0x1E7BE80 VA: 0x181E7D880
	private static void .cctor() { }
}

// Namespace: System.Net
[Serializable]
public abstract class EndPoint // TypeDefIndex: 7761
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x1E69E10 Offset: 0x1E68410 VA: 0x181E69E10 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x1E69DE0 Offset: 0x1E683E0 VA: 0x181E69DE0 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x1E69DB0 Offset: 0x1E683B0 VA: 0x181E69DB0 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Net
public enum FtpStatusCode // TypeDefIndex: 7762
{
	// Fields
	public int value__; // 0x0
	public const FtpStatusCode Undefined = 0;
	public const FtpStatusCode RestartMarker = 110;
	public const FtpStatusCode ServiceTemporarilyNotAvailable = 120;
	public const FtpStatusCode DataAlreadyOpen = 125;
	public const FtpStatusCode OpeningData = 150;
	public const FtpStatusCode CommandOK = 200;
	public const FtpStatusCode CommandExtraneous = 202;
	public const FtpStatusCode DirectoryStatus = 212;
	public const FtpStatusCode FileStatus = 213;
	public const FtpStatusCode SystemType = 215;
	public const FtpStatusCode SendUserCommand = 220;
	public const FtpStatusCode ClosingControl = 221;
	public const FtpStatusCode ClosingData = 226;
	public const FtpStatusCode EnteringPassive = 227;
	public const FtpStatusCode LoggedInProceed = 230;
	public const FtpStatusCode ServerWantsSecureSession = 234;
	public const FtpStatusCode FileActionOK = 250;
	public const FtpStatusCode PathnameCreated = 257;
	public const FtpStatusCode SendPasswordCommand = 331;
	public const FtpStatusCode NeedLoginAccount = 332;
	public const FtpStatusCode FileCommandPending = 350;
	public const FtpStatusCode ServiceNotAvailable = 421;
	public const FtpStatusCode CantOpenData = 425;
	public const FtpStatusCode ConnectionClosed = 426;
	public const FtpStatusCode ActionNotTakenFileUnavailableOrBusy = 450;
	public const FtpStatusCode ActionAbortedLocalProcessingError = 451;
	public const FtpStatusCode ActionNotTakenInsufficientSpace = 452;
	public const FtpStatusCode CommandSyntaxError = 500;
	public const FtpStatusCode ArgumentSyntaxError = 501;
	public const FtpStatusCode CommandNotImplemented = 502;
	public const FtpStatusCode BadCommandSequence = 503;
	public const FtpStatusCode NotLoggedIn = 530;
	public const FtpStatusCode AccountNeeded = 532;
	public const FtpStatusCode ActionNotTakenFileUnavailable = 550;
	public const FtpStatusCode ActionAbortedUnknownPageType = 551;
	public const FtpStatusCode FileActionAborted = 552;
	public const FtpStatusCode ActionNotTakenFilenameNotAllowed = 553;
}

// Namespace: System.Net
public enum HttpRequestHeader // TypeDefIndex: 7763
{
	// Fields
	public int value__; // 0x0
	public const HttpRequestHeader CacheControl = 0;
	public const HttpRequestHeader Connection = 1;
	public const HttpRequestHeader Date = 2;
	public const HttpRequestHeader KeepAlive = 3;
	public const HttpRequestHeader Pragma = 4;
	public const HttpRequestHeader Trailer = 5;
	public const HttpRequestHeader TransferEncoding = 6;
	public const HttpRequestHeader Upgrade = 7;
	public const HttpRequestHeader Via = 8;
	public const HttpRequestHeader Warning = 9;
	public const HttpRequestHeader Allow = 10;
	public const HttpRequestHeader ContentLength = 11;
	public const HttpRequestHeader ContentType = 12;
	public const HttpRequestHeader ContentEncoding = 13;
	public const HttpRequestHeader ContentLanguage = 14;
	public const HttpRequestHeader ContentLocation = 15;
	public const HttpRequestHeader ContentMd5 = 16;
	public const HttpRequestHeader ContentRange = 17;
	public const HttpRequestHeader Expires = 18;
	public const HttpRequestHeader LastModified = 19;
	public const HttpRequestHeader Accept = 20;
	public const HttpRequestHeader AcceptCharset = 21;
	public const HttpRequestHeader AcceptEncoding = 22;
	public const HttpRequestHeader AcceptLanguage = 23;
	public const HttpRequestHeader Authorization = 24;
	public const HttpRequestHeader Cookie = 25;
	public const HttpRequestHeader Expect = 26;
	public const HttpRequestHeader From = 27;
	public const HttpRequestHeader Host = 28;
	public const HttpRequestHeader IfMatch = 29;
	public const HttpRequestHeader IfModifiedSince = 30;
	public const HttpRequestHeader IfNoneMatch = 31;
	public const HttpRequestHeader IfRange = 32;
	public const HttpRequestHeader IfUnmodifiedSince = 33;
	public const HttpRequestHeader MaxForwards = 34;
	public const HttpRequestHeader ProxyAuthorization = 35;
	public const HttpRequestHeader Referer = 36;
	public const HttpRequestHeader Range = 37;
	public const HttpRequestHeader Te = 38;
	public const HttpRequestHeader Translate = 39;
	public const HttpRequestHeader UserAgent = 40;
}

// Namespace: System.Net
public interface IAuthenticationModule // TypeDefIndex: 7764
{
	// Properties
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_AuthenticationType();
}

// Namespace: System.Net
public interface ICertificatePolicy // TypeDefIndex: 7765
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
}

// Namespace: System.Net
public interface ICredentials // TypeDefIndex: 7766
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkCredential GetCredential(Uri uri, string authType);
}

// Namespace: System.Net
public class IPHostEntry // TypeDefIndex: 7767
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_HostName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_HostName(string value) { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Aliases(string[] value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IPAddress[] get_AddressList() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x1E7AC90 Offset: 0x1E79290 VA: 0x181E7AC90
	public void .ctor() { }
}

// Namespace: System.Net
public interface IWebRequestCreate // TypeDefIndex: 7768
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebRequest Create(Uri uri);
}

// Namespace: System.Net
internal class InternalException : SystemException // TypeDefIndex: 7769
{
	// Methods

	// RVA: 0x13968D0 Offset: 0x1394ED0 VA: 0x1813968D0
	internal void .ctor() { }
}

// Namespace: System.Net
internal static class NclUtilities // TypeDefIndex: 7770
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x1E7B7C0 Offset: 0x1E79DC0 VA: 0x181E7B7C0
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x1E7B730 Offset: 0x1E79D30 VA: 0x181E7B730
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1E7B710 Offset: 0x1E79D10 VA: 0x181E7B710
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x1E7B910 Offset: 0x1E79F10 VA: 0x181E7B910
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1E7B870 Offset: 0x1E79E70 VA: 0x181E7B870
	private static object get_LocalAddressesLock() { }
}

// Namespace: System.Net
internal static class ValidationHelper // TypeDefIndex: 7771
{
	// Fields
	public static string[] EmptyArray; // 0x0
	internal static readonly char[] InvalidMethodChars; // 0x8
	internal static readonly char[] InvalidParamChars; // 0x10

	// Methods

	// RVA: 0x1E7F920 Offset: 0x1E7DF20 VA: 0x181E7F920
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x1E7F910 Offset: 0x1E7DF10 VA: 0x181E7F910
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x1E5DD00 Offset: 0x1E5C300 VA: 0x181E5DD00
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x1E7F930 Offset: 0x1E7DF30 VA: 0x181E7F930
	private static void .cctor() { }
}

// Namespace: System.Net
internal static class ExceptionHelper // TypeDefIndex: 7772
{
	// Properties
	internal static NotImplementedException MethodNotImplementedException { get; }
	internal static NotImplementedException PropertyNotImplementedException { get; }
	internal static WebException TimeoutException { get; }
	internal static NotSupportedException PropertyNotSupportedException { get; }
	internal static WebException RequestAbortedException { get; }

	// Methods

	// RVA: 0x1E69E40 Offset: 0x1E68440 VA: 0x181E69E40
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x1E69EB0 Offset: 0x1E684B0 VA: 0x181E69EB0
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x1E6A0A0 Offset: 0x1E686A0 VA: 0x181E6A0A0
	internal static WebException get_TimeoutException() { }

	// RVA: 0x1E69F20 Offset: 0x1E68520 VA: 0x181E69F20
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x1E69F90 Offset: 0x1E68590 VA: 0x181E69F90
	internal static WebException get_RequestAbortedException() { }
}

// Namespace: System.Net
internal class WebRequestPrefixElement // TypeDefIndex: 7773
{
	// Fields
	public string Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Properties
	public IWebRequestCreate Creator { get; set; }

	// Methods

	// RVA: 0x1E82C80 Offset: 0x1E81280 VA: 0x181E82C80
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(string P, IWebRequestCreate C) { }
}

// Namespace: System.Net
public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 7774
{
	// Methods

	// RVA: 0x593FB0 Offset: 0x5925B0 VA: 0x180593FB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }
}

// Namespace: System.Net
internal enum TriState // TypeDefIndex: 7775
{
	// Fields
	public int value__; // 0x0
	public const TriState Unspecified = -1;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Net
public class NetworkCredential : ICredentials // TypeDefIndex: 7776
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x1E7C130 Offset: 0x1E7A730 VA: 0x181E7C130
	public void .ctor(string userName, string password) { }

	// RVA: 0x1E7C080 Offset: 0x1E7A680 VA: 0x181E7C080
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_UserName() { }

	// RVA: 0x1E7C250 Offset: 0x1E7A850 VA: 0x181E7C250
	public void set_UserName(string value) { }

	// RVA: 0x1E7C070 Offset: 0x1E7A670 VA: 0x181E7C070
	public string get_Password() { }

	// RVA: 0x1E7C220 Offset: 0x1E7A820 VA: 0x181E7C220
	public void set_Password(string value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Domain() { }

	// RVA: 0x1E7C1F0 Offset: 0x1E7A7F0 VA: 0x181E7C1F0
	public void set_Domain(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string InternalGetUserName() { }

	// RVA: 0x1E7C070 Offset: 0x1E7A670 VA: 0x181E7C070
	internal string InternalGetPassword() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string InternalGetDomain() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }
}

// Namespace: System.Net
[Serializable]
public class ProtocolViolationException : InvalidOperationException, ISerializable // TypeDefIndex: 7777
{
	// Methods

	// RVA: 0x1E7C7A0 Offset: 0x1E7ADA0 VA: 0x181E7C7A0
	public void .ctor() { }

	// RVA: 0x1E7C7B0 Offset: 0x1E7ADB0 VA: 0x181E7C7B0
	public void .ctor(string message) { }

	// RVA: 0x14154C0 Offset: 0x1413AC0 VA: 0x1814154C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1DDC140 Offset: 0x1DDA740 VA: 0x181DDC140 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1DDC140 Offset: 0x1DDA740 VA: 0x181DDC140 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
public class SocketAddress // TypeDefIndex: 7778
{
	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x1E7D7C0 Offset: 0x1E7BDC0 VA: 0x181E7D7C0
	public AddressFamily get_Family() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Size() { }

	// RVA: 0x1E7D800 Offset: 0x1E7BE00 VA: 0x181E7D800
	public byte get_Item(int offset) { }

	// RVA: 0x1E7D390 Offset: 0x1E7B990 VA: 0x181E7D390
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x1E7D4B0 Offset: 0x1E7BAB0 VA: 0x181E7D4B0
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x1E7D330 Offset: 0x1E7B930 VA: 0x181E7D330
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x1E7CCE0 Offset: 0x1E7B2E0 VA: 0x181E7CCE0
	internal IPAddress GetIPAddress() { }

	// RVA: 0x1E7CF50 Offset: 0x1E7B550 VA: 0x181E7CF50
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x1E7CA40 Offset: 0x1E7B040 VA: 0x181E7CA40 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1E7CBC0 Offset: 0x1E7B1C0 VA: 0x181E7CBC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E7D0B0 Offset: 0x1E7B6B0 VA: 0x181E7D0B0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 7779
{
	// Fields
	private WebExceptionStatus m_Status; // 0x90
	private WebResponse m_Response; // 0x98
	private WebExceptionInternalStatus m_InternalStatus; // 0xA0

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0x1E7FCB0 Offset: 0x1E7E2B0 VA: 0x181E7FCB0
	public void .ctor() { }

	// RVA: 0x1E80150 Offset: 0x1E7E750 VA: 0x181E80150
	public void .ctor(string message) { }

	// RVA: 0x1E7FEA0 Offset: 0x1E7E4A0 VA: 0x181E7FEA0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1E7FCD0 Offset: 0x1E7E2D0 VA: 0x181E7FCD0
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x1E7FD20 Offset: 0x1E7E320 VA: 0x181E7FD20
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x1E7FEC0 Offset: 0x1E7E4C0 VA: 0x181E7FEC0
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1E7FF80 Offset: 0x1E7E580 VA: 0x181E7FF80
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1E7FDE0 Offset: 0x1E7E3E0 VA: 0x181E7FDE0
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1E80060 Offset: 0x1E7E660 VA: 0x181E80060
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1E7FCF0 Offset: 0x1E7E2F0 VA: 0x181E7FCF0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E7FC80 Offset: 0x1E7E280 VA: 0x181E7FC80 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1DDC140 Offset: 0x1DDA740 VA: 0x181DDC140 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public WebExceptionStatus get_Status() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public WebResponse get_Response() { }
}

// Namespace: System.Net
internal enum WebExceptionInternalStatus // TypeDefIndex: 7780
{
	// Fields
	public int value__; // 0x0
	public const WebExceptionInternalStatus RequestFatal = 0;
	public const WebExceptionInternalStatus ServicePointFatal = 1;
	public const WebExceptionInternalStatus Recoverable = 2;
	public const WebExceptionInternalStatus Isolated = 3;
}

// Namespace: System.Net
public enum WebExceptionStatus // TypeDefIndex: 7781
{
	// Fields
	public int value__; // 0x0
	public const WebExceptionStatus Success = 0;
	public const WebExceptionStatus NameResolutionFailure = 1;
	public const WebExceptionStatus ConnectFailure = 2;
	public const WebExceptionStatus ReceiveFailure = 3;
	public const WebExceptionStatus SendFailure = 4;
	public const WebExceptionStatus PipelineFailure = 5;
	public const WebExceptionStatus RequestCanceled = 6;
	public const WebExceptionStatus ProtocolError = 7;
	public const WebExceptionStatus ConnectionClosed = 8;
	public const WebExceptionStatus TrustFailure = 9;
	public const WebExceptionStatus SecureChannelFailure = 10;
	public const WebExceptionStatus ServerProtocolViolation = 11;
	public const WebExceptionStatus KeepAliveFailure = 12;
	public const WebExceptionStatus Pending = 13;
	public const WebExceptionStatus Timeout = 14;
	public const WebExceptionStatus ProxyNameResolutionFailure = 15;
	public const WebExceptionStatus UnknownError = 16;
	public const WebExceptionStatus MessageLengthLimitExceeded = 17;
	public const WebExceptionStatus CacheEntryNotFound = 18;
	public const WebExceptionStatus RequestProhibitedByCachePolicy = 19;
	public const WebExceptionStatus RequestProhibitedByProxy = 20;
}

// Namespace: System.Net
internal static class WebExceptionMapping // TypeDefIndex: 7782
{
	// Fields
	private static readonly string[] s_Mapping; // 0x0

	// Methods

	// RVA: 0x1E7FA60 Offset: 0x1E7E060 VA: 0x181E7FA60
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x1E7FC10 Offset: 0x1E7E210 VA: 0x181E7FC10
	private static void .cctor() { }
}

// Namespace: System.Net
internal enum WebHeaderCollectionType // TypeDefIndex: 7783
{
	// Fields
	public ushort value__; // 0x0
	public const WebHeaderCollectionType Unknown = 0;
	public const WebHeaderCollectionType WebRequest = 1;
	public const WebHeaderCollectionType WebResponse = 2;
	public const WebHeaderCollectionType HttpWebRequest = 3;
	public const WebHeaderCollectionType HttpWebResponse = 4;
	public const WebHeaderCollectionType HttpListenerRequest = 5;
	public const WebHeaderCollectionType HttpListenerResponse = 6;
	public const WebHeaderCollectionType FtpWebRequest = 7;
	public const WebHeaderCollectionType FtpWebResponse = 8;
	public const WebHeaderCollectionType FileWebRequest = 9;
	public const WebHeaderCollectionType FileWebResponse = 10;
}

// Namespace: System.Net
[ComVisible(True)]
[DefaultMember("Item")]
[Serializable]
public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 7785
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x1E81810 Offset: 0x1E7FE10 VA: 0x181E81810
	private void NormalizeCommonHeaders() { }

	// RVA: 0x1E82BD0 Offset: 0x1E811D0 VA: 0x181E82BD0
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x1E80670 Offset: 0x1E7EC70 VA: 0x181E80670
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x1E82B60 Offset: 0x1E81160 VA: 0x181E82B60
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x1E819A0 Offset: 0x1E7FFA0 VA: 0x181E819A0
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x1E80170 Offset: 0x1E7E770 VA: 0x181E80170
	internal void AddInternal(string name, string value) { }

	// RVA: 0x1E80710 Offset: 0x1E7ED10 VA: 0x181E80710
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x1E81940 Offset: 0x1E7FF40 VA: 0x181E81940
	internal void RemoveInternal(string name) { }

	// RVA: 0x1E80780 Offset: 0x1E7ED80 VA: 0x181E80780
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x1E80D00 Offset: 0x1E7F300 VA: 0x181E80D00
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x1E82050 Offset: 0x1E80650 VA: 0x181E82050
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x1E801E0 Offset: 0x1E7E7E0 VA: 0x181E801E0 Slot: 15
	public override void Add(string name, string value) { }

	// RVA: 0x1E80390 Offset: 0x1E7E990 VA: 0x181E80390
	public void Add(string header) { }

	// RVA: 0x1E81DE0 Offset: 0x1E803E0 VA: 0x181E81DE0 Slot: 18
	public override void Set(string name, string value) { }

	// RVA: 0x1E81BB0 Offset: 0x1E801B0 VA: 0x181E81BB0
	internal void SetInternal(string name, string value) { }

	// RVA: 0x1E81A90 Offset: 0x1E80090 VA: 0x181E81A90 Slot: 19
	public override void Remove(string name) { }

	// RVA: 0x1E81240 Offset: 0x1E7F840 VA: 0x181E81240 Slot: 17
	public override string[] GetValues(string header) { }

	// RVA: 0x1E82290 Offset: 0x1E80890 VA: 0x181E82290 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E80D70 Offset: 0x1E7F370 VA: 0x181E80D70
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x1E82A10 Offset: 0x1E81010 VA: 0x181E82A10
	public void .ctor() { }

	// RVA: 0x1E82A70 Offset: 0x1E81070 VA: 0x181E82A70
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x1E82840 Offset: 0x1E80E40 VA: 0x181E82840
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	public override void OnDeserialization(object sender) { }

	// RVA: 0x1E810C0 Offset: 0x1E7F6C0 VA: 0x181E810C0 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E82020 Offset: 0x1E80620 VA: 0x181E82020 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E81470 Offset: 0x1E7FA70 VA: 0x181E81470 Slot: 16
	public override string Get(string name) { }

	// RVA: 0x1E81000 Offset: 0x1E7F600 VA: 0x181E81000 Slot: 13
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1E82B90 Offset: 0x1E81190 VA: 0x181E82B90 Slot: 14
	public override int get_Count() { }

	// RVA: 0x1E817C0 Offset: 0x1E7FDC0 VA: 0x181E817C0 Slot: 20
	public override string Get(int index) { }

	// RVA: 0x1E81070 Offset: 0x1E7F670 VA: 0x181E81070 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x1E822E0 Offset: 0x1E808E0 VA: 0x181E822E0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CaseInsensitiveAscii : IEqualityComparer, IComparer // TypeDefIndex: 7786
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x1E67C10 Offset: 0x1E66210 VA: 0x181E67C10 Slot: 5
	public int GetHashCode(object myObject) { }

	// RVA: 0x1E676C0 Offset: 0x1E65CC0 VA: 0x181E676C0 Slot: 6
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x1E67B20 Offset: 0x1E66120 VA: 0x181E67B20
	private int FastGetHashCode(string myString) { }

	// RVA: 0x1E67830 Offset: 0x1E65E30 VA: 0x181E67830 Slot: 4
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1E67D20 Offset: 0x1E66320 VA: 0x181E67D20
	private static void .cctor() { }
}

// Namespace: System.Net
[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 7789
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual long ContentLength { get; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual int Timeout { get; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }

	// Methods

	// RVA: 0x1E83E40 Offset: 0x1E82440 VA: 0x181E83E40
	private static object get_InternalSyncObject() { }

	// RVA: 0x1E82ED0 Offset: 0x1E814D0 VA: 0x181E82ED0
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x1E83260 Offset: 0x1E81860 VA: 0x181E83260
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x1E83190 Offset: 0x1E81790 VA: 0x181E83190
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x1E83F60 Offset: 0x1E82560 VA: 0x181E83F60
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x1E836D0 Offset: 0x1E81CD0 VA: 0x181E836D0
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x1E83BA0 Offset: 0x1E821A0 VA: 0x181E83BA0
	protected void .ctor() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E83990 Offset: 0x1E81F90 VA: 0x181E83990 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E835F0 Offset: 0x1E81BF0 VA: 0x181E835F0 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1E835F0 Offset: 0x1E81BF0 VA: 0x181E835F0
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x1E83F30 Offset: 0x1E82530 VA: 0x181E83F30 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x1E84200 Offset: 0x1E82800 VA: 0x181E84200 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x1E84140 Offset: 0x1E82740 VA: 0x181E84140 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x1E83C30 Offset: 0x1E82230 VA: 0x181E83C30 Slot: 12
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1E83BD0 Offset: 0x1E821D0 VA: 0x181E83BD0 Slot: 13
	public virtual long get_ContentLength() { }

	// RVA: 0x1E83C00 Offset: 0x1E82200 VA: 0x181E83C00 Slot: 14
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x1E841D0 Offset: 0x1E827D0 VA: 0x181E841D0 Slot: 15
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x1E841A0 Offset: 0x1E827A0 VA: 0x181E841A0 Slot: 16
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1E84110 Offset: 0x1E82710 VA: 0x181E84110 Slot: 17
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1E84230 Offset: 0x1E82830 VA: 0x181E84230 Slot: 18
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1E84170 Offset: 0x1E82770 VA: 0x181E84170 Slot: 19
	public virtual int get_Timeout() { }

	// RVA: 0x1E835C0 Offset: 0x1E81BC0 VA: 0x181E835C0 Slot: 20
	public virtual WebResponse GetResponse() { }

	// RVA: 0x1E82EA0 Offset: 0x1E814A0 VA: 0x181E82EA0 Slot: 21
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1E83330 Offset: 0x1E81930 VA: 0x181E83330 Slot: 22
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1E83360 Offset: 0x1E81960 VA: 0x181E83360 Slot: 23
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x1E83950 Offset: 0x1E81F50 VA: 0x181E83950
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x1E82E70 Offset: 0x1E81470 VA: 0x181E82E70 Slot: 24
	public virtual void Abort() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x1E83C60 Offset: 0x1E82260 VA: 0x181E83C60
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1E83AC0 Offset: 0x1E820C0 VA: 0x181E83AC0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1E839C0 Offset: 0x1E81FC0 VA: 0x181E839C0
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }
}

// Namespace: System.Net
[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 7790
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Properties
	public virtual bool IsFromCache { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D95E60 Offset: 0x1D94460 VA: 0x181D95E60 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public virtual void Close() { }

	// RVA: 0x1E84290 Offset: 0x1E82890 VA: 0x181E84290 Slot: 7
	public void Dispose() { }

	// RVA: 0x1E84260 Offset: 0x1E82860 VA: 0x181E84260 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10 Slot: 11
	public virtual bool get_IsFromCache() { }

	// RVA: 0x1E842F0 Offset: 0x1E828F0 VA: 0x181E842F0 Slot: 12
	public virtual Stream GetResponseStream() { }

	// RVA: 0x1E84350 Offset: 0x1E82950 VA: 0x181E84350 Slot: 13
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x1E84320 Offset: 0x1E82920 VA: 0x181E84320 Slot: 14
	public virtual WebHeaderCollection get_Headers() { }
}

// Namespace: System.Net
internal class BufferOffsetSize // TypeDefIndex: 7791
{
	// Fields
	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x1E67600 Offset: 0x1E65C00 VA: 0x181E67600
	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x1E67540 Offset: 0x1E65B40 VA: 0x181E67540
	internal void .ctor(byte[] buffer, bool copyBuffer) { }
}

// Namespace: System.Net
internal sealed class HeaderParser : MulticastDelegate // TypeDefIndex: 7792
{
	// Methods

	// RVA: 0xA825C0 Offset: 0xA80BC0 VA: 0x180A825C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950 Slot: 13
	public virtual string[] Invoke(string value) { }
}

// Namespace: System.Net
internal class HeaderInfo // TypeDefIndex: 7793
{
	// Fields
	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Methods

	// RVA: 0x1E79200 Offset: 0x1E77800 VA: 0x181E79200
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
internal class HeaderInfoTable // TypeDefIndex: 7794
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x1E76930 Offset: 0x1E74F30 VA: 0x181E76930
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1E76730 Offset: 0x1E74D30 VA: 0x181E76730
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1E769B0 Offset: 0x1E74FB0 VA: 0x181E769B0
	private static void .cctor() { }

	// RVA: 0x1E79100 Offset: 0x1E77700 VA: 0x181E79100
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Net
[Flags]
internal enum CloseExState // TypeDefIndex: 7795
{
	// Fields
	public int value__; // 0x0
	public const CloseExState Normal = 0;
	public const CloseExState Abort = 1;
	public const CloseExState Silent = 2;
}

// Namespace: System.Net
internal interface ICloseEx // TypeDefIndex: 7796
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CloseEx(CloseExState closeState);
}

// Namespace: System.Net
internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 7798
{
	// Fields
	[ThreadStatic]
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_EndCalled; // 0x34
	private bool m_UserEvent; // 0x35
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	protected AsyncCallback AsyncCallback { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }
	internal bool EndCalled { get; set; }

	// Methods

	// RVA: 0x1E7B630 Offset: 0x1E79C30 VA: 0x181E7B630
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1E7B4A0 Offset: 0x1E79AA0 VA: 0x181E7B4A0
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal object get_AsyncObject() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x1E7B560 Offset: 0x1E79B60 VA: 0x181E7B560 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1E7AEF0 Offset: 0x1E794F0 VA: 0x181E7AEF0
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x1E7B600 Offset: 0x1E79C00 VA: 0x181E7B600 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1E7B6E0 Offset: 0x1E79CE0 VA: 0x181E7B6E0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1E7B6D0 Offset: 0x1E79CD0 VA: 0x181E7B6D0
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	internal bool get_EndCalled() { }

	// RVA: 0x16A5170 Offset: 0x16A3770 VA: 0x1816A5170
	internal void set_EndCalled(bool value) { }

	// RVA: 0x1E7B070 Offset: 0x1E79670 VA: 0x181E7B070
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1E7AEE0 Offset: 0x1E794E0 VA: 0x181E7AEE0
	internal void InvokeCallback(object result) { }

	// RVA: 0x1E7AED0 Offset: 0x1E794D0 VA: 0x181E7AED0
	internal void InvokeCallback() { }

	// RVA: 0x1E7ACA0 Offset: 0x1E792A0 VA: 0x181E7ACA0 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x1E7B410 Offset: 0x1E79A10 VA: 0x181E7B410
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x1E7AEC0 Offset: 0x1E794C0 VA: 0x181E7AEC0
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1E7B200 Offset: 0x1E79800 VA: 0x181E7B200
	private object WaitForCompletion(bool snap) { }
}

// Namespace: System.Net
internal class NetRes // TypeDefIndex: 7799
{
	// Methods

	// RVA: 0x1E7BFC0 Offset: 0x1E7A5C0 VA: 0x181E7BFC0
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x1E7BF60 Offset: 0x1E7A560 VA: 0x181E7BF60
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x1E7BE10 Offset: 0x1E7A410 VA: 0x181E7BE10
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }
}

// Namespace: System.Net
internal static class TimerThread // TypeDefIndex: 7808
{
	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static int s_CacheScanIteration; // 0x30
	private static Hashtable s_QueuesCache; // 0x38

	// Methods

	// RVA: 0x1E7EF80 Offset: 0x1E7D580 VA: 0x181E7EF80
	private static void .cctor() { }

	// RVA: 0x1E7DA50 Offset: 0x1E7C050 VA: 0x181E7DA50
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x1E7DC60 Offset: 0x1E7C260 VA: 0x181E7DC60
	internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x1E7E640 Offset: 0x1E7CC40 VA: 0x181E7E640
	private static void Prod() { }

	// RVA: 0x1E7E7E0 Offset: 0x1E7CDE0 VA: 0x181E7E7E0
	private static void ThreadProc() { }

	// RVA: 0x1E7E760 Offset: 0x1E7CD60 VA: 0x181E7E760
	private static void StopTimerThread() { }

	// RVA: 0x1E7E560 Offset: 0x1E7CB60 VA: 0x181E7E560
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x1E7E580 Offset: 0x1E7CB80 VA: 0x181E7E580
	private static void OnDomainUnload(object sender, EventArgs e) { }
}

// Namespace: System.Net
internal enum CookieVariant // TypeDefIndex: 7809
{
	// Fields
	public int value__; // 0x0
	public const CookieVariant Unknown = 0;
	public const CookieVariant Plain = 1;
	public const CookieVariant Rfc2109 = 2;
	public const CookieVariant Rfc2965 = 3;
	public const CookieVariant Default = 2;
}

// Namespace: System.Net
[Serializable]
public sealed class Cookie // TypeDefIndex: 7810
{
	// Fields
	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalField]
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties
	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x1E8E120 Offset: 0x1E8C720 VA: 0x181E8E120
	public void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Comment() { }

	// RVA: 0x1AD2F70 Offset: 0x1AD1570 VA: 0x181AD2F70
	public void set_Comment(string value) { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_CommentUri(Uri value) { }

	// RVA: 0x15B31C0 Offset: 0x15B17C0 VA: 0x1815B31C0
	public void set_HttpOnly(bool value) { }

	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_Discard(bool value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Domain() { }

	// RVA: 0x1E8E640 Offset: 0x1E8CC40 VA: 0x181E8E640
	public void set_Domain(string value) { }

	// RVA: 0x1E8E360 Offset: 0x1E8C960 VA: 0x181E8E360
	private string get__Domain() { }

	// RVA: 0x1E8E2A0 Offset: 0x1E8C8A0 VA: 0x181E8E2A0
	public bool get_Expired() { }

	// RVA: 0x10051E0 Offset: 0x10037E0 VA: 0x1810051E0
	public void set_Expires(DateTime value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_Name() { }

	// RVA: 0x1E8C920 Offset: 0x1E8AF20 VA: 0x181E8C920
	internal bool InternalSetName(string value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public string get_Path() { }

	// RVA: 0x1E8E6B0 Offset: 0x1E8CCB0 VA: 0x181E8E6B0
	public void set_Path(string value) { }

	// RVA: 0x1E8E420 Offset: 0x1E8CA20 VA: 0x181E8E420
	private string get__Path() { }

	// RVA: 0x1D0A790 Offset: 0x1D08D90 VA: 0x181D0A790
	internal bool get_Plain() { }

	// RVA: 0x1E8CA20 Offset: 0x1E8B020 VA: 0x181E8CA20
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x1E8CF50 Offset: 0x1E8B550 VA: 0x181E8CF50
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x1E8C570 Offset: 0x1E8AB70 VA: 0x181E8C570
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1E8E700 Offset: 0x1E8CD00 VA: 0x181E8E700
	public void set_Port(string value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	internal int[] get_PortList() { }

	// RVA: 0x1E8E4A0 Offset: 0x1E8CAA0 VA: 0x181E8E4A0
	private string get__Port() { }

	// RVA: 0xBCFCF0 Offset: 0xBCE2F0 VA: 0x180BCFCF0
	public bool get_Secure() { }

	// RVA: 0xBD0F40 Offset: 0xBCF540 VA: 0x180BD0F40
	public void set_Secure(bool value) { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public string get_Value() { }

	// RVA: 0x1E8EBB0 Offset: 0x1E8D1B0 VA: 0x181E8EBB0
	public void set_Value(string value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal CookieVariant get_Variant() { }

	// RVA: 0x1E8E280 Offset: 0x1E8C880 VA: 0x181E8E280
	internal string get_DomainKey() { }

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90
	public int get_Version() { }

	// RVA: 0x1E8EBF0 Offset: 0x1E8D1F0 VA: 0x181E8EBF0
	public void set_Version(int value) { }

	// RVA: 0x1E8E550 Offset: 0x1E8CB50 VA: 0x181E8E550
	private string get__Version() { }

	// RVA: 0x1E8C710 Offset: 0x1E8AD10 VA: 0x181E8C710
	internal static IComparer GetComparer() { }

	// RVA: 0x1E8C600 Offset: 0x1E8AC00 VA: 0x181E8C600 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1E8C760 Offset: 0x1E8AD60 VA: 0x181E8C760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E8CA80 Offset: 0x1E8B080 VA: 0x181E8CA80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E8DF60 Offset: 0x1E8C560 VA: 0x181E8DF60
	private static void .cctor() { }
}

// Namespace: System.Net
internal enum CookieToken // TypeDefIndex: 7811
{
	// Fields
	public int value__; // 0x0
	public const CookieToken Nothing = 0;
	public const CookieToken NameValuePair = 1;
	public const CookieToken Attribute = 2;
	public const CookieToken EndToken = 3;
	public const CookieToken EndCookie = 4;
	public const CookieToken End = 5;
	public const CookieToken Equals = 6;
	public const CookieToken Comment = 7;
	public const CookieToken CommentUrl = 8;
	public const CookieToken CookieName = 9;
	public const CookieToken Discard = 10;
	public const CookieToken Domain = 11;
	public const CookieToken Expires = 12;
	public const CookieToken MaxAge = 13;
	public const CookieToken Path = 14;
	public const CookieToken Port = 15;
	public const CookieToken Secure = 16;
	public const CookieToken HttpOnly = 17;
	public const CookieToken Unknown = 18;
	public const CookieToken Version = 19;
}

// Namespace: System.Net
internal class CookieTokenizer // TypeDefIndex: 7813
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1E8C510 Offset: 0x1E8AB10 VA: 0x181E8C510
	internal void .ctor(string tokenStream) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	internal bool get_EndOfCookie() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1E8C560 Offset: 0x1E8AB60 VA: 0x181E8C560
	internal bool get_Eof() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_Name() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_Name(string value) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	internal bool get_Quoted() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	internal void set_Quoted(bool value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	internal CookieToken get_Token() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal string get_Value() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_Value(string value) { }

	// RVA: 0x1E8B7F0 Offset: 0x1E89DF0 VA: 0x181E8B7F0
	internal string Extract() { }

	// RVA: 0x1E8B850 Offset: 0x1E89E50 VA: 0x181E8B850
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1E8BA90 Offset: 0x1E8A090 VA: 0x181E8BA90
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1E8BCF0 Offset: 0x1E8A2F0 VA: 0x181E8BCF0
	internal void Reset() { }

	// RVA: 0x1E8BD50 Offset: 0x1E8A350 VA: 0x181E8BD50
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1E8BF60 Offset: 0x1E8A560 VA: 0x181E8BF60
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CookieParser // TypeDefIndex: 7814
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0x1E8B750 Offset: 0x1E89D50 VA: 0x181E8B750
	internal void .ctor(string cookieString) { }

	// RVA: 0x1E8ACC0 Offset: 0x1E892C0 VA: 0x181E8ACC0
	internal Cookie Get() { }

	// RVA: 0x1E8AC30 Offset: 0x1E89230 VA: 0x181E8AC30
	internal static string CheckQuoted(string value) { }
}

// Namespace: System.Net
internal class Comparer : IComparer // TypeDefIndex: 7815
{
	// Methods

	// RVA: 0x1E85F10 Offset: 0x1E84510 VA: 0x181E85F10 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 7818
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalField]
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x1E87010 Offset: 0x1E85610 VA: 0x181E87010
	public void .ctor() { }

	// RVA: 0x1E870C0 Offset: 0x1E856C0 VA: 0x181E870C0
	public Cookie get_Item(int index) { }

	// RVA: 0x1E863E0 Offset: 0x1E849E0 VA: 0x181E863E0
	public void Add(Cookie cookie) { }

	// RVA: 0x1E864B0 Offset: 0x1E84AB0 VA: 0x181E864B0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x138B880 Offset: 0x1389E80 VA: 0x18138B880 Slot: 5
	public int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1E86810 Offset: 0x1E84E10 VA: 0x181E86810 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1E86F10 Offset: 0x1E85510 VA: 0x181E86F10
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x1E86B50 Offset: 0x1E85150 VA: 0x181E86B50
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x1E868E0 Offset: 0x1E84EE0 VA: 0x181E868E0
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x1E86EE0 Offset: 0x1E854E0 VA: 0x181E86EE0
	internal void RemoveAt(int idx) { }

	// RVA: 0x1E86840 Offset: 0x1E84E40 VA: 0x181E86840 Slot: 8
	public IEnumerator GetEnumerator() { }
}

// Namespace: System.Net
internal struct HeaderVariantInfo // TypeDefIndex: 7819
{
	// Fields
	private string m_name; // 0x0
	private CookieVariant m_variant; // 0x8

	// Properties
	internal string Name { get; }
	internal CookieVariant Variant { get; }

	// Methods

	// RVA: 0x970F90 Offset: 0x96F590 VA: 0x180970F90
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	internal string get_Name() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	internal CookieVariant get_Variant() { }
}

// Namespace: System.Net
[Serializable]
public class CookieContainer // TypeDefIndex: 7820
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x1E8AB20 Offset: 0x1E89120 VA: 0x181E8AB20
	public void .ctor() { }

	// RVA: 0x1E871C0 Offset: 0x1E857C0 VA: 0x181E871C0
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x1E872F0 Offset: 0x1E858F0 VA: 0x181E872F0
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x1E87B10 Offset: 0x1E86110 VA: 0x181E87B10
	private bool AgeCookies(string domain) { }

	// RVA: 0x1E89B40 Offset: 0x1E88140 VA: 0x181E89B40
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1E8A560 Offset: 0x1E88B60 VA: 0x181E8A560
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1E893A0 Offset: 0x1E879A0 VA: 0x181E893A0
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x1E8A110 Offset: 0x1E88710 VA: 0x181E8A110
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x1E88B80 Offset: 0x1E87180 VA: 0x181E88B80
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1E8A810 Offset: 0x1E88E10 VA: 0x181E8A810
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x1E89CB0 Offset: 0x1E882B0 VA: 0x181E89CB0
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1E89D80 Offset: 0x1E88380 VA: 0x181E89D80
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x1E8A9F0 Offset: 0x1E88FF0 VA: 0x181E8A9F0
	private static void .cctor() { }
}

// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
internal class PathList // TypeDefIndex: 7822
{
	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1E99F90 Offset: 0x1E98590 VA: 0x181E99F90
	public void .ctor() { }

	// RVA: 0x14A4A00 Offset: 0x14A3000 VA: 0x1814A4A00
	public int get_Count() { }

	// RVA: 0x1E99C40 Offset: 0x1E98240 VA: 0x181E99C40
	public int GetCookiesCount() { }

	// RVA: 0x140B6D0 Offset: 0x1409CD0 VA: 0x18140B6D0
	public ICollection get_Values() { }

	// RVA: 0x1E9A050 Offset: 0x1E98650 VA: 0x181E9A050
	public object get_Item(string s) { }

	// RVA: 0x1E9A080 Offset: 0x1E98680 VA: 0x181E9A080
	public void set_Item(string s, object value) { }

	// RVA: 0x131AB70 Offset: 0x1319170 VA: 0x18131AB70
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13703A0 Offset: 0x136E9A0 VA: 0x1813703A0
	public object get_SyncRoot() { }
}

// Namespace: System.Net
[Serializable]
public class CookieException : FormatException, ISerializable // TypeDefIndex: 7823
{
	// Methods

	// RVA: 0x1DDC160 Offset: 0x1DDA760 VA: 0x181DDC160
	public void .ctor() { }

	// RVA: 0x1DDC170 Offset: 0x1DDA770 VA: 0x181DDC170
	internal void .ctor(string message) { }

	// RVA: 0x1E8AC20 Offset: 0x1E89220 VA: 0x181E8AC20
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x14154C0 Offset: 0x1413AC0 VA: 0x1814154C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1DDC140 Offset: 0x1DDA740 VA: 0x181DDC140 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1DDC140 Offset: 0x1DDA740 VA: 0x181DDC140 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net
[Serializable]
public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 7824
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private IWebProxy m_proxy; // 0x68
	private ManualResetEvent m_readerEvent; // 0x70
	private bool m_readPending; // 0x78
	private WebResponse m_response; // 0x80
	private Stream m_stream; // 0x88
	private bool m_syncHint; // 0x90
	private int m_timeout; // 0x94
	private Uri m_uri; // 0x98
	private bool m_writePending; // 0xA0
	private bool m_writing; // 0xA1
	private LazyAsyncResult m_WriteAResult; // 0xA8
	private LazyAsyncResult m_ReadAResult; // 0xB0
	private int m_Aborted; // 0xB8

	// Properties
	internal bool Aborted { get; }
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; }

	// Methods

	// RVA: 0x1E938A0 Offset: 0x1E91EA0 VA: 0x181E938A0
	internal void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1E93A30 Offset: 0x1E92030 VA: 0x181E93A30
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E83990 Offset: 0x1E81F90 VA: 0x181E83990 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E92D00 Offset: 0x1E91300 VA: 0x181E92D00 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E93E70 Offset: 0x1E92470 VA: 0x181E93E70
	internal bool get_Aborted() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1E93EB0 Offset: 0x1E924B0 VA: 0x181E93EB0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1E92890 Offset: 0x1E90E90 VA: 0x181E92890 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1E92AD0 Offset: 0x1E910D0 VA: 0x181E92AD0 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1E93490 Offset: 0x1E91A90 VA: 0x181E93490 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1E92F60 Offset: 0x1E91560 VA: 0x181E92F60
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x1E93190 Offset: 0x1E91790 VA: 0x181E93190
	private static void GetResponseCallback(object state) { }

	// RVA: 0x1E93710 Offset: 0x1E91D10 VA: 0x181E93710
	internal void UnblockReader() { }

	// RVA: 0x1E93E80 Offset: 0x1E92480 VA: 0x181E93E80 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1E92650 Offset: 0x1E90C50 VA: 0x181E92650 Slot: 24
	public override void Abort() { }

	// RVA: 0x1E937B0 Offset: 0x1E91DB0 VA: 0x181E937B0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 7825
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1E924A0 Offset: 0x1E90AA0 VA: 0x181E924A0 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: System.Net
internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 7826
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1E94D60 Offset: 0x1E93360 VA: 0x181E94D60
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1E94E00 Offset: 0x1E93400 VA: 0x181E94E00
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1E94AE0 Offset: 0x1E930E0 VA: 0x181E94AE0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E94C80 Offset: 0x1E93280 VA: 0x181E94C80 Slot: 40
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1E94BF0 Offset: 0x1E931F0 VA: 0x181E94BF0 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E94CD0 Offset: 0x1E932D0 VA: 0x181E94CD0 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1E948E0 Offset: 0x1E92EE0 VA: 0x181E948E0 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1E94B70 Offset: 0x1E93170 VA: 0x181E94B70 Slot: 23
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1E94990 Offset: 0x1E92F90 VA: 0x181E94990 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1E94BB0 Offset: 0x1E931B0 VA: 0x181E94BB0 Slot: 27
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1E94A40 Offset: 0x1E93040 VA: 0x181E94A40
	private void CheckError() { }
}

// Namespace: System.Net
[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 7827
{
	// Fields
	private bool m_closed; // 0x20
	private long m_contentLength; // 0x28
	private FileAccess m_fileAccess; // 0x30
	private WebHeaderCollection m_headers; // 0x38
	private Stream m_stream; // 0x40
	private Uri m_uri; // 0x48

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x1E945C0 Offset: 0x1E92BC0 VA: 0x181E945C0
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1E94330 Offset: 0x1E92930 VA: 0x181E94330
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D95E60 Offset: 0x1D94460 VA: 0x181D95E60 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E94050 Offset: 0x1E92650 VA: 0x181E94050 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E948A0 Offset: 0x1E92EA0 VA: 0x181E948A0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1E948C0 Offset: 0x1E92EC0 VA: 0x181E948C0 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x1E93F80 Offset: 0x1E92580 VA: 0x181E93F80
	private void CheckDisposed() { }

	// RVA: 0x1E94010 Offset: 0x1E92610 VA: 0x181E94010 Slot: 9
	public override void Close() { }

	// RVA: 0x1E94210 Offset: 0x1E92810 VA: 0x181E94210 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1E941D0 Offset: 0x1E927D0 VA: 0x181E941D0 Slot: 12
	public override Stream GetResponseStream() { }
}

// Namespace: System.Net
public interface IWebProxy // TypeDefIndex: 7828
{
	// Properties
	public abstract ICredentials Credentials { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Uri GetProxy(Uri destination);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsBypassed(Uri host);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICredentials get_Credentials();
}

// Namespace: System.Net
[Serializable]
public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 7829
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x1E9D990 Offset: 0x1E9BF90 VA: 0x181E9D990
	public void .ctor() { }

	// RVA: 0x1E9DA00 Offset: 0x1E9C000 VA: 0x181E9DA00
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x1E9DE20 Offset: 0x1E9C420 VA: 0x181E9DE20
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x1E9DE90 Offset: 0x1E9C490 VA: 0x181E9DE90
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1E9CB80 Offset: 0x1E9B180 VA: 0x181E9CB80 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x1E9D780 Offset: 0x1E9BD80 VA: 0x181E9D780
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x1E9D550 Offset: 0x1E9BB50 VA: 0x181E9D550
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x1E9D3D0 Offset: 0x1E9B9D0 VA: 0x181E9D3D0
	private bool IsLocal(Uri host) { }

	// RVA: 0x1E9D2E0 Offset: 0x1E9B8E0 VA: 0x181E9D2E0
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x1E9D1F0 Offset: 0x1E9B7F0 VA: 0x181E9D1F0 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x1E9CDD0 Offset: 0x1E9B3D0 VA: 0x181E9CDD0
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x1E9DAD0 Offset: 0x1E9C0D0 VA: 0x181E9DAD0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D95E60 Offset: 0x1D94460 VA: 0x181D95E60 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E9C9B0 Offset: 0x1E9AFB0 VA: 0x181E9C9B0 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x1E9C960 Offset: 0x1E9AF60 VA: 0x181E9C960
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x1E9D960 Offset: 0x1E9BF60 VA: 0x181E9D960
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x1E9D770 Offset: 0x1E9BD70 VA: 0x181E9D770
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x1E9CB00 Offset: 0x1E9B100 VA: 0x181E9CB00
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x1E9CD70 Offset: 0x1E9B370 VA: 0x181E9CD70
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x1E9C7F0 Offset: 0x1E9ADF0 VA: 0x181E9C7F0
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x1E9D6E0 Offset: 0x1E9BCE0 VA: 0x181E9D6E0
	private static Uri ProxyUri(string proxyName) { }
}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine // TypeDefIndex: 7830
{
	// Methods

	// RVA: 0x1E85560 Offset: 0x1E83B60 VA: 0x181E85560
	public bool GetProxies(Uri destination, out IList<string> proxyList) { }

	// RVA: 0x1E85560 Offset: 0x1E83B60 VA: 0x181E85560
	public bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus) { }
}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods // TypeDefIndex: 7834
{}

// Namespace: System.Net
internal static class Logging // TypeDefIndex: 7835
{
	// Properties
	internal static bool On { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	internal static bool get_On() { }
}

// Namespace: System.Net
internal class ServerCertValidationCallback // TypeDefIndex: 7837
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Properties
	internal RemoteCertificateValidationCallback ValidationCallback { get; }

	// Methods

	// RVA: 0x1E9A580 Offset: 0x1E98B80 VA: 0x181E9A580
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x1E9A360 Offset: 0x1E98960 VA: 0x181E9A360
	internal void Callback(object state) { }

	// RVA: 0x1E9A410 Offset: 0x1E98A10 VA: 0x181E9A410
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

// Namespace: System.Net
public class AuthenticationManager // TypeDefIndex: 7838
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x1E848A0 Offset: 0x1E82EA0 VA: 0x181E848A0
	private static void EnsureModules() { }

	// RVA: 0x1E84380 Offset: 0x1E82980 VA: 0x181E84380
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1E844E0 Offset: 0x1E82AE0 VA: 0x181E844E0
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1E84B30 Offset: 0x1E83130 VA: 0x181E84B30
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x1E84F50 Offset: 0x1E83550 VA: 0x181E84F50
	private static void .cctor() { }
}

// Namespace: System.Net
internal class BasicClient : IAuthenticationModule // TypeDefIndex: 7839
{
	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1E85580 Offset: 0x1E83B80 VA: 0x181E85580 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1E85630 Offset: 0x1E83C30 VA: 0x181E85630
	private static byte[] GetBytes(string str) { }

	// RVA: 0x1E856D0 Offset: 0x1E83CD0 VA: 0x181E856D0
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1E859D0 Offset: 0x1E83FD0 VA: 0x181E859D0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1E859F0 Offset: 0x1E83FF0 VA: 0x181E859F0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Net
public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 7840
{
	// Methods

	// RVA: 0x1E85A20 Offset: 0x1E84020 VA: 0x181E85A20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D4E10 Offset: 0x5D3410 VA: 0x1805D4E10 Slot: 13
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }
}

// Namespace: System.Net
internal class BufferedReadStream : WebReadStream // TypeDefIndex: 7842
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x1E85D30 Offset: 0x1E84330 VA: 0x181E85D30
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[AsyncStateMachine(typeof(BufferedReadStream.<ProcessReadAsync>d__2))]
	// RVA: 0x1E85B40 Offset: 0x1E84140 VA: 0x181E85B40 Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1E85C90 Offset: 0x1E84290 VA: 0x181E85C90
	internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result) { }
}

// Namespace: System.Net
internal class ContentDecodeStream : WebReadStream // TypeDefIndex: 7844
{
	// Fields
	[CompilerGenerated]
	private readonly Stream <OriginalInnerStream>k__BackingField; // 0x40

	// Properties
	private Stream OriginalInnerStream { get; }

	// Methods

	// RVA: 0x1E85FF0 Offset: 0x1E845F0 VA: 0x181E85FF0
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x1E85D30 Offset: 0x1E84330 VA: 0x181E85D30
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x1E7C4C0 Offset: 0x1E7AAC0 VA: 0x181E7C4C0 Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1E860D0 Offset: 0x1E846D0 VA: 0x181E860D0 Slot: 38
	internal override Task FinishReading(CancellationToken cancellationToken) { }
}

// Namespace: System.Net
[Flags]
public enum DecompressionMethods // TypeDefIndex: 7845
{
	// Fields
	public int value__; // 0x0
	public const DecompressionMethods None = 0;
	public const DecompressionMethods GZip = 1;
	public const DecompressionMethods Deflate = 2;
}

// Namespace: System.Net
internal class DefaultCertificatePolicy // TypeDefIndex: 7846
{}

// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 7847
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x1E901A0 Offset: 0x1E8E7A0 VA: 0x181E901A0
	public void .ctor(string header) { }

	// RVA: 0x1456490 Offset: 0x1454A90 VA: 0x181456490
	public string get_Realm() { }

	// RVA: 0x14563A0 Offset: 0x14549A0 VA: 0x1814563A0
	public string get_Opaque() { }

	// RVA: 0x1456400 Offset: 0x1454A00 VA: 0x181456400
	public string get_Nonce() { }

	// RVA: 0x1456430 Offset: 0x1454A30 VA: 0x181456430
	public string get_Algorithm() { }

	// RVA: 0x1456460 Offset: 0x1454A60 VA: 0x181456460
	public string get_QOP() { }

	// RVA: 0x1E8FE20 Offset: 0x1E8E420 VA: 0x181E8FE20
	public bool Parse() { }

	// RVA: 0x1E8FFE0 Offset: 0x1E8E5E0 VA: 0x181E8FFE0
	private void SkipWhitespace() { }

	// RVA: 0x1E8FAC0 Offset: 0x1E8E0C0 VA: 0x181E8FAC0
	private string GetKey() { }

	// RVA: 0x1E8FBA0 Offset: 0x1E8E1A0 VA: 0x181E8FBA0
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x1E90050 Offset: 0x1E8E650 VA: 0x181E90050
	private static void .cctor() { }
}

// Namespace: System.Net
internal class DigestSession // TypeDefIndex: 7848
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x1E91100 Offset: 0x1E8F700 VA: 0x181E91100
	private static void .cctor() { }

	// RVA: 0x1E91160 Offset: 0x1E8F760 VA: 0x181E91160
	public void .ctor() { }

	// RVA: 0x1E911C0 Offset: 0x1E8F7C0 VA: 0x181E911C0
	public string get_Algorithm() { }

	// RVA: 0x1E913C0 Offset: 0x1E8F9C0 VA: 0x181E913C0
	public string get_Realm() { }

	// RVA: 0x1E91300 Offset: 0x1E8F900 VA: 0x181E91300
	public string get_Nonce() { }

	// RVA: 0x1E91340 Offset: 0x1E8F940 VA: 0x181E91340
	public string get_Opaque() { }

	// RVA: 0x1E91380 Offset: 0x1E8F980 VA: 0x181E91380
	public string get_QOP() { }

	// RVA: 0x1E91200 Offset: 0x1E8F800 VA: 0x181E91200
	public string get_CNonce() { }

	// RVA: 0x1E90BD0 Offset: 0x1E8F1D0 VA: 0x181E90BD0
	public bool Parse(string challenge) { }

	// RVA: 0x1E90A70 Offset: 0x1E8F070 VA: 0x181E90A70
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x1E90810 Offset: 0x1E8EE10 VA: 0x181E90810
	private string HA1(string username, string password) { }

	// RVA: 0x1E90970 Offset: 0x1E8EF70 VA: 0x181E90970
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x1E90D90 Offset: 0x1E8F390 VA: 0x181E90D90
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x1E90260 Offset: 0x1E8E860 VA: 0x181E90260
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public DateTime get_LastUse() { }
}

// Namespace: System.Net
internal class DigestClient : IAuthenticationModule // TypeDefIndex: 7849
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1E8F960 Offset: 0x1E8DF60 VA: 0x181E8F960
	private static Hashtable get_Cache() { }

	// RVA: 0x1E8EFC0 Offset: 0x1E8D5C0 VA: 0x181E8EFC0
	private static void CheckExpired(int count) { }

	// RVA: 0x1E8EC70 Offset: 0x1E8D270 VA: 0x181E8EC70 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1E8F700 Offset: 0x1E8DD00 VA: 0x181E8F700 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1E8F930 Offset: 0x1E8DF30 VA: 0x181E8F930 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1E8F8B0 Offset: 0x1E8DEB0 VA: 0x181E8F8B0
	private static void .cctor() { }
}

// Namespace: System.Net
public static class Dns // TypeDefIndex: 7851
{
	// Methods

	// RVA: 0x1E91400 Offset: 0x1E8FA00 VA: 0x181E91400
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1E91630 Offset: 0x1E8FC30 VA: 0x181E91630
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x1E91C10 Offset: 0x1E90210 VA: 0x181E91C10
	private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x1E91AD0 Offset: 0x1E900D0 VA: 0x181E91AD0
	private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x1E921B0 Offset: 0x1E907B0 VA: 0x181E921B0
	private static bool GetHostName_icall(out string h_name) { }

	// RVA: 0x1E91740 Offset: 0x1E8FD40 VA: 0x181E91740
	private static void Error_11001(string hostName) { }

	// RVA: 0x1E92200 Offset: 0x1E90800 VA: 0x181E92200
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x1E91AE0 Offset: 0x1E900E0 VA: 0x181E91AE0
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x1E91D20 Offset: 0x1E90320 VA: 0x181E91D20
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x1E92050 Offset: 0x1E90650 VA: 0x181E92050
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x1E918C0 Offset: 0x1E8FEC0 VA: 0x181E918C0
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x1E91C20 Offset: 0x1E90220 VA: 0x181E91C20
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x1E921C0 Offset: 0x1E907C0 VA: 0x181E921C0
	public static string GetHostName() { }

	// RVA: 0x1E917B0 Offset: 0x1E8FDB0 VA: 0x181E917B0
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }
}

// Namespace: System.Net
internal class FixedSizeReadStream : WebReadStream // TypeDefIndex: 7853
{
	// Fields
	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; // 0x40
	private long position; // 0x48

	// Properties
	public long ContentLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public long get_ContentLength() { }

	// RVA: 0x1E95000 Offset: 0x1E93600 VA: 0x181E95000
	public void .ctor(WebOperation operation, Stream innerStream, long contentLength) { }

	[AsyncStateMachine(typeof(FixedSizeReadStream.<ProcessReadAsync>d__5))]
	// RVA: 0x1E94EB0 Offset: 0x1E934B0 VA: 0x181E94EB0 Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }
}

// Namespace: System.Net
internal class HttpRequestCreator : IWebRequestCreate // TypeDefIndex: 7854
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1E95E70 Offset: 0x1E94470 VA: 0x181E95E70 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: System.Net
[Serializable]
public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 7862
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private int continueTimeout; // 0xF4
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private static int defaultMaxResponseHeadersLength; // 0x0
	private static int defaultMaximumErrorResponseLength; // 0x4
	private static RequestCachePolicy defaultCachePolicy; // 0x8
	private int readWriteTimeout; // 0x138
	private MobileTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private bool hostHasPort; // 0x158
	private Uri hostUri; // 0x160
	private HttpWebRequest.AuthorizationState auth_state; // 0x168
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x178
	internal Func<Stream, Task> ResendContentFactory; // 0x188
	[CompilerGenerated]
	private bool <ThrowOnError>k__BackingField; // 0x190
	private bool unsafe_auth_blah; // 0x191

	// Properties
	public Uri Address { get; }
	public virtual bool AllowWriteStreamBuffering { get; }
	public DecompressionMethods AutomaticDecompression { get; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MobileTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public override long ContentLength { get; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override ICredentials Credentials { get; set; }
	[MonoTODO]
	public static int DefaultMaximumErrorResponseLength { get; }
	public override WebHeaderCollection Headers { get; }
	public string Host { get; }
	public bool KeepAlive { get; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public Version ProtocolVersion { get; }
	public override IWebProxy Proxy { get; set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }
	internal bool FinishedReading { set; }
	internal bool Aborted { get; }

	// Methods

	// RVA: 0x1E98BF0 Offset: 0x1E971F0 VA: 0x181E98BF0
	private static void .cctor() { }

	// RVA: 0x1E98CD0 Offset: 0x1E972D0 VA: 0x181E98CD0
	public void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1E98F70 Offset: 0x1E97570 VA: 0x181E98F70
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E98720 Offset: 0x1E96D20 VA: 0x181E98720
	private void ResetAuthorization() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public Uri get_Address() { }

	// RVA: 0x16EE320 Offset: 0x16EC920 VA: 0x1816EE320 Slot: 25
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1E99140 Offset: 0x1E97740 VA: 0x181E99140
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x1E99330 Offset: 0x1E97930 VA: 0x181E99330
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x1E99340 Offset: 0x1E97940 VA: 0x181E99340
	private bool get_MethodWithBuffer() { }

	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x1E99150 Offset: 0x1E97750 VA: 0x181E99150
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0xC9D9E0 Offset: 0xC9BFE0 VA: 0x180C9D9E0
	internal void set_InternalContentLength(long value) { }

	[CompilerGenerated]
	// RVA: 0x1791C40 Offset: 0x1790240 VA: 0x181791C40
	internal bool get_ThrowOnError() { }

	[CompilerGenerated]
	// RVA: 0x1E998D0 Offset: 0x1E97ED0 VA: 0x181E998D0
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1E991C0 Offset: 0x1E977C0 VA: 0x181E991C0
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1E99220 Offset: 0x1E97820 VA: 0x181E99220
	public string get_Host() { }

	// RVA: 0x3A35D0 Offset: 0x3A1BD0 VA: 0x1803A35D0
	public bool get_KeepAlive() { }

	// RVA: 0x17870A0 Offset: 0x17856A0 VA: 0x1817870A0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1E99580 Offset: 0x1E97B80 VA: 0x181E99580 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public Version get_ProtocolVersion() { }

	// RVA: 0x3A3640 Offset: 0x3A1C40 VA: 0x1803A3640 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1E99830 Offset: 0x1E97E30 VA: 0x181E99830 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1E99450 Offset: 0x1E97A50 VA: 0x181E99450
	public bool get_SendChunked() { }

	// RVA: 0x1E99480 Offset: 0x1E97A80 VA: 0x181E99480
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x16EE440 Offset: 0x16ECA40 VA: 0x1816EE440 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x1E99490 Offset: 0x1E97A90 VA: 0x181E99490
	public string get_TransferEncoding() { }

	// RVA: 0x1E994E0 Offset: 0x1E97AE0 VA: 0x181E994E0 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1791B20 Offset: 0x1790120 VA: 0x181791B20
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1E99210 Offset: 0x1E97810 VA: 0x181E99210
	internal bool get_ExpectContinue() { }

	// RVA: 0x1E99560 Offset: 0x1E97B60 VA: 0x181E99560
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal Uri get_AuthUri() { }

	// RVA: 0x1E99420 Offset: 0x1E97A20 VA: 0x181E99420
	internal bool get_ProxyQuery() { }

	// RVA: 0x17871E0 Offset: 0x17857E0 VA: 0x1817871E0
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1E99460 Offset: 0x1E97A60 VA: 0x181E99460
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1E97B10 Offset: 0x1E96110 VA: 0x181E97B10
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x1E98830 Offset: 0x1E96E30 VA: 0x181E98830
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70A8D0 Offset: 0x708ED0 VA: 0x18070A8D0
	|-HttpWebRequest.RunWithTimeout<int>
	|
	|-RVA: 0x70A7A0 Offset: 0x708DA0 VA: 0x18070A7A0
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<T>))]
	// RVA: -1 Offset: -1
	private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70A380 Offset: 0x708980 VA: 0x18070A380
	|-HttpWebRequest.RunWithTimeoutWorker<int>
	|
	|-RVA: 0x70A4D0 Offset: 0x708AD0 VA: 0x18070A4D0
	|-HttpWebRequest.RunWithTimeoutWorker<object>
	|
	|-RVA: 0x70A200 Offset: 0x708800 VA: 0x18070A200
	|-HttpWebRequest.RunWithTimeoutWorker<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70AAC0 Offset: 0x7090C0 VA: 0x18070AAC0
	|-HttpWebRequest.RunWithTimeout<object>
	|
	|-RVA: 0x70A620 Offset: 0x708C20 VA: 0x18070A620
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<MyGetResponseAsync>d__243))]
	// RVA: 0x1E98100 Offset: 0x1E96700 VA: 0x181E98100
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpWebRequest.<GetResponseFromData>d__244))]
	// RVA: 0x1E97720 Offset: 0x1E95D20 VA: 0x181E97720
	private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1E96AB0 Offset: 0x1E950B0 VA: 0x181E96AB0
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x1E97E70 Offset: 0x1E96470 VA: 0x181E97E70
	private WebException GetWebException(Exception e) { }

	// RVA: 0x1E97C20 Offset: 0x1E96220 VA: 0x181E97C20
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x1E96740 Offset: 0x1E94D40 VA: 0x181E96740
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x1E95FA0 Offset: 0x1E945A0 VA: 0x181E95FA0 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1E969E0 Offset: 0x1E94FE0 VA: 0x181E969E0 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1E97870 Offset: 0x1E95E70 VA: 0x181E97870 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1E99570 Offset: 0x1E97B70 VA: 0x181E99570
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x1E99110 Offset: 0x1E97710 VA: 0x181E99110
	internal bool get_Aborted() { }

	// RVA: 0x1E95ED0 Offset: 0x1E944D0 VA: 0x181E95ED0 Slot: 24
	public override void Abort() { }

	// RVA: 0x1E98AA0 Offset: 0x1E970A0 VA: 0x181E98AA0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E972D0 Offset: 0x1E958D0 VA: 0x181E972D0 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1E966D0 Offset: 0x1E94CD0 VA: 0x181E966D0
	private void CheckRequestStarted() { }

	// RVA: 0x1E967E0 Offset: 0x1E94DE0 VA: 0x181E967E0
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x1E987B0 Offset: 0x1E96DB0 VA: 0x181E987B0
	private void RewriteRedirectToGet() { }

	// RVA: 0x1E98210 Offset: 0x1E96810 VA: 0x181E98210
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x1E96B70 Offset: 0x1E95170 VA: 0x181E96B70
	private string GetHeaders() { }

	// RVA: 0x1E96800 Offset: 0x1E94E00 VA: 0x181E96800
	private void DoPreAuthenticate() { }

	// RVA: 0x1E97310 Offset: 0x1E95910 VA: 0x181E97310
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x1E97EF0 Offset: 0x1E964F0 VA: 0x181E97EF0
	private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1E96170 Offset: 0x1E94770 VA: 0x181E96170
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1E97910 Offset: 0x1E95F10 VA: 0x181E97910
	private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x1E961A0 Offset: 0x1E947A0 VA: 0x181E961A0
	private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool <RunWithTimeout>b__242_0<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70AD20 Offset: 0x709320 VA: 0x18070AD20
	|-HttpWebRequest.<RunWithTimeout>b__242_0<object>
	|-HttpWebRequest.<RunWithTimeout>b__242_0<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<<GetRewriteHandler>b__271_0>d))]
	[CompilerGenerated]
	// RVA: 0x1E98AE0 Offset: 0x1E970E0 VA: 0x181E98AE0
	private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	// RVA: 0x1E98CA0 Offset: 0x1E972A0 VA: 0x181E98CA0
	public void .ctor() { }
}

// Namespace: System.Net
[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 7863
{
	// Fields
	private Uri uri; // 0x20
	private WebHeaderCollection webHeaders; // 0x28
	private CookieCollection cookieCollection; // 0x30
	private string method; // 0x38
	private Version version; // 0x40
	private HttpStatusCode statusCode; // 0x48
	private string statusDescription; // 0x50
	private long contentLength; // 0x58
	private string contentType; // 0x60
	private CookieContainer cookie_container; // 0x68
	private bool disposed; // 0x70
	private Stream stream; // 0x78

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1D95E90 Offset: 0x1D94490 VA: 0x181D95E90
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x1D96380 Offset: 0x1D94980 VA: 0x181D96380
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Obsolete("Serialization is obsoleted for this type", False)]
	// RVA: 0x1D95F80 Offset: 0x1D94580 VA: 0x181D95F80
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1D96640 Offset: 0x1D94C40 VA: 0x181D96640 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940 Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1D96660 Offset: 0x1D94C60 VA: 0x181D96660 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x1D95DA0 Offset: 0x1D943A0 VA: 0x181D95DA0 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x1D95E60 Offset: 0x1D94460 VA: 0x181D95E60 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D95C30 Offset: 0x1D94230 VA: 0x181D95C30 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D95A50 Offset: 0x1D94050 VA: 0x181D95A50 Slot: 9
	public override void Close() { }

	// RVA: 0x1D95E40 Offset: 0x1D94440 VA: 0x181D95E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D95A90 Offset: 0x1D94090 VA: 0x181D95A90 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D959C0 Offset: 0x1D93FC0 VA: 0x181D959C0
	private void CheckDisposed() { }

	// RVA: 0x1D95AA0 Offset: 0x1D940A0 VA: 0x181D95AA0
	private void FillCookies() { }
}

// Namespace: System.Net
public interface ICredentialPolicy // TypeDefIndex: 7864
{}

// Namespace: System.Net
internal class MonoChunkParser // TypeDefIndex: 7867
{
	// Fields
	private WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkParser.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x1D97470 Offset: 0x1D95A70 VA: 0x181D97470
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1D97380 Offset: 0x1D95980 VA: 0x181D97380
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D96E30 Offset: 0x1D95430 VA: 0x181D96E30
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D97440 Offset: 0x1D95A40 VA: 0x181D97440
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D96950 Offset: 0x1D94F50 VA: 0x181D96950
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D97650 Offset: 0x1D95C50 VA: 0x181D97650
	public bool get_WantMore() { }

	// RVA: 0x1D97540 Offset: 0x1D95B40 VA: 0x181D97540
	public bool get_DataAvailable() { }

	// RVA: 0x1D97530 Offset: 0x1D95B30 VA: 0x181D97530
	public int get_ChunkLeft() { }

	// RVA: 0x1D96C10 Offset: 0x1D95210 VA: 0x181D96C10
	private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D96680 Offset: 0x1D94C80 VA: 0x181D96680
	private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D97390 Offset: 0x1D95990 VA: 0x181D97390
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1D96D50 Offset: 0x1D95350 VA: 0x181D96D50
	private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D97120 Offset: 0x1D95720 VA: 0x181D97120
	private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D973E0 Offset: 0x1D959E0 VA: 0x181D973E0
	private static void ThrowProtocolViolation(string message) { }
}

// Namespace: System.Net
internal class MonoChunkStream : WebReadStream // TypeDefIndex: 7870
{
	// Fields
	[CompilerGenerated]
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Properties
	protected MonoChunkParser Decoder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x1D97A40 Offset: 0x1D96040 VA: 0x181D97A40
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<ProcessReadAsync>d__7))]
	// RVA: 0x1D97780 Offset: 0x1D95D80 VA: 0x181D97780 Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<FinishReading>d__8))]
	// RVA: 0x1D97670 Offset: 0x1D95C70 VA: 0x181D97670 Slot: 38
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1D978D0 Offset: 0x1D95ED0 VA: 0x181D978D0
	private static void ThrowExpectingChunkTrailer() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1D97930 Offset: 0x1D95F30 VA: 0x181D97930
	private Task <>n__0(CancellationToken cancellationToken) { }
}

// Namespace: System.Net
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 7871
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1D97CB0 Offset: 0x1D962B0 VA: 0x181D97CB0
	public void .ctor() { }

	// RVA: 0x1D97BC0 Offset: 0x1D961C0 VA: 0x181D97BC0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D97D20 Offset: 0x1D96320 VA: 0x181D97D20 Slot: 6
	public string get_AuthenticationType() { }
}

// Namespace: System.Net
public class ServicePoint // TypeDefIndex: 7872
{
	// Fields
	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	private bool disposed; // 0x5C
	private int connectionLeaseTimeout; // 0x60
	private int receiveBufferSize; // 0x64
	[CompilerGenerated]
	private readonly ServicePointManager.SPKey <Key>k__BackingField; // 0x68
	[CompilerGenerated]
	private ServicePointScheduler <Scheduler>k__BackingField; // 0x70
	private int connectionLimit; // 0x78
	private int maxIdleTime; // 0x7C
	private object m_ServerCertificateOrBytes; // 0x80
	private object m_ClientCertificateOrBytes; // 0x88

	// Properties
	internal ServicePointManager.SPKey Key { get; }
	private ServicePointScheduler Scheduler { get; set; }
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0x1D9A630 Offset: 0x1D98C30 VA: 0x181D9A630
	internal void .ctor(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	[CompilerGenerated]
	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	internal ServicePointManager.SPKey get_Key() { }

	[CompilerGenerated]
	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	private ServicePointScheduler get_Scheduler() { }

	[CompilerGenerated]
	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Uri get_Address() { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360
	public int get_ConnectionLimit() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x1D9AD60 Offset: 0x1D99360 VA: 0x181D9AD60
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x1D9ACC0 Offset: 0x1D992C0 VA: 0x181D9ACC0
	internal bool get_SendContinue() { }

	// RVA: 0x1D9AD60 Offset: 0x1D99360 VA: 0x181D9AD60
	internal void set_SendContinue(bool value) { }

	// RVA: 0x1D9A4A0 Offset: 0x1D98AA0 VA: 0x181D9A4A0
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x1D9A1A0 Offset: 0x1D987A0 VA: 0x181D9A1A0
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x1D9A2F0 Offset: 0x1D988F0 VA: 0x181D9A2F0
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	internal bool get_UsesProxy() { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x1D9AD50 Offset: 0x1D99350 VA: 0x181D9AD50
	internal bool get_UseConnect() { }

	// RVA: 0x1D9AD70 Offset: 0x1D99370 VA: 0x181D9AD70
	internal void set_UseConnect(bool value) { }

	// RVA: 0x1D9A740 Offset: 0x1D98D40 VA: 0x181D9A740
	private bool get_HasTimedOut() { }

	// RVA: 0x1D9A860 Offset: 0x1D98E60 VA: 0x181D9A860
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void SetVersion(Version version) { }

	// RVA: 0x1D9A360 Offset: 0x1D98960 VA: 0x181D9A360
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1D9A180 Offset: 0x1D98780 VA: 0x181D9A180
	internal void FreeServicePoint() { }

	// RVA: 0x1D9A5E0 Offset: 0x1D98BE0 VA: 0x181D9A5E0
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x1D9A590 Offset: 0x1D98B90 VA: 0x181D9A590
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x1D9A0B0 Offset: 0x1D986B0 VA: 0x181D9A0B0
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }
}

// Namespace: System.Net
public class ServicePointManager // TypeDefIndex: 7874
{
	// Fields
	private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }

	// Methods

	// RVA: 0x1D98900 Offset: 0x1D96F00 VA: 0x181D98900
	private static void .cctor() { }

	// RVA: 0x1D98820 Offset: 0x1D96E20 VA: 0x181D98820
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x1D98A10 Offset: 0x1D97010 VA: 0x181D98A10
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x1D98A60 Offset: 0x1D97060 VA: 0x181D98A60
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x1D98AB0 Offset: 0x1D970B0 VA: 0x181D98AB0
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x1D98B00 Offset: 0x1D97100 VA: 0x181D98B00
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1D98B50 Offset: 0x1D97150 VA: 0x181D98B50
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1D97FB0 Offset: 0x1D965B0 VA: 0x181D97FB0
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x1D98870 Offset: 0x1D96E70 VA: 0x181D98870
	internal static void RemoveServicePoint(ServicePoint sp) { }
}

// Namespace: System.Net
internal class ServicePointScheduler // TypeDefIndex: 7880
{
	// Fields
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private ServicePointScheduler.AsyncManualResetEvent schedulerEvent; // 0x20
	private ServicePointScheduler.ConnectionGroup defaultGroup; // 0x28
	private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups; // 0x30
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations; // 0x38
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58

	// Properties
	private ServicePoint ServicePoint { get; set; }
	public int MaxIdleTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	private ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_MaxIdleTime() { }

	// RVA: 0x1D99E80 Offset: 0x1D98480 VA: 0x181D99E80
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x1D998E0 Offset: 0x1D97EE0 VA: 0x181D998E0
	public void Run() { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<RunScheduler>d__32))]
	// RVA: 0x1D99800 Offset: 0x1D97E00 VA: 0x181D99800
	private Task RunScheduler() { }

	// RVA: 0x1D98BE0 Offset: 0x1D971E0 VA: 0x181D98BE0
	private void Cleanup() { }

	// RVA: 0x1D995C0 Offset: 0x1D97BC0 VA: 0x181D995C0
	private void RunSchedulerIteration() { }

	// RVA: 0x1D99180 Offset: 0x1D97780 VA: 0x181D99180
	private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x1D98DB0 Offset: 0x1D973B0 VA: 0x181D98DB0
	private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x1D999B0 Offset: 0x1D97FB0 VA: 0x181D999B0
	private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group) { }

	// RVA: 0x1D994F0 Offset: 0x1D97AF0 VA: 0x181D994F0
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x1D99420 Offset: 0x1D97A20 VA: 0x181D99420
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x1D98E00 Offset: 0x1D97400 VA: 0x181D98E00
	private void FinalCleanup() { }

	// RVA: 0x1D99BC0 Offset: 0x1D981C0 VA: 0x181D99BC0
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1D98F40 Offset: 0x1D97540 VA: 0x181D98F40
	private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x1D99170 Offset: 0x1D97770 VA: 0x181D99170
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x1D99140 Offset: 0x1D97740 VA: 0x181D99140
	private void OnConnectionClosed(WebConnection connection) { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<WaitAsync>d__46))]
	// RVA: 0x1D99D60 Offset: 0x1D98360 VA: 0x181D99D60
	public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout) { }

	[CompilerGenerated]
	// RVA: 0x1D99800 Offset: 0x1D97E00 VA: 0x181D99800
	private Task <Run>b__31_0() { }
}

// Namespace: System.Net
internal class WebCompletionSource<T> // TypeDefIndex: 7884
{
	// Fields
	private TaskCompletionSource<WebCompletionSource.Result<T>> completion; // 0x0
	private WebCompletionSource.Result<T> currentResult; // 0x0

	// Properties
	internal WebCompletionSource.Result<T> CurrentResult { get; }
	internal Task Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool runAsync = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE57F0 Offset: 0xBE3DF0 VA: 0x180BE57F0
	|-WebCompletionSource<ValueTuple<bool, object>>..ctor
	|-WebCompletionSource<object>..ctor
	|
	|-RVA: 0xBE5890 Offset: 0xBE3E90 VA: 0x180BE5890
	|-WebCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal WebCompletionSource.Result<T> get_CurrentResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-WebCompletionSource<ValueTuple<bool, object>>.get_CurrentResult
	|-WebCompletionSource<object>.get_CurrentResult
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_CurrentResult
	*/

	// RVA: -1 Offset: -1
	internal Task get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE5930 Offset: 0xBE3F30 VA: 0x180BE5930
	|-WebCompletionSource<ValueTuple<bool, object>>.get_Task
	|-WebCompletionSource<object>.get_Task
	|
	|-RVA: 0x9C4E90 Offset: 0x9C3490 VA: 0x1809C4E90
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted(T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE5260 Offset: 0xBE3860 VA: 0x180BE5260
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|
	|-RVA: 0xBE4E90 Offset: 0xBE3490 VA: 0x180BE4E90
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0xBE50F0 Offset: 0xBE36F0 VA: 0x180BE50F0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4F50 Offset: 0xBE3550 VA: 0x180BE4F50
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0xBE5010 Offset: 0xBE3610 VA: 0x180BE5010
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4D80 Offset: 0xBE3380 VA: 0x180BE4D80
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0xBE4BE0 Offset: 0xBE31E0 VA: 0x180BE4BE0
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0xBE4CF0 Offset: 0xBE32F0 VA: 0x180BE4CF0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(OperationCanceledException error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4B10 Offset: 0xBE3110 VA: 0x180BE4B10
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0xBE4A30 Offset: 0xBE3030 VA: 0x180BE4A30
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE5400 Offset: 0xBE3A00 VA: 0x180BE5400
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetException
	|-WebCompletionSource<object>.TrySetException
	|
	|-RVA: 0xBE5320 Offset: 0xBE3920 VA: 0x180BE5320
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void ThrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE48A0 Offset: 0xBE2EA0 VA: 0x180BE48A0
	|-WebCompletionSource<ValueTuple<bool, object>>.ThrowOnError
	|-WebCompletionSource<object>.ThrowOnError
	|
	|-RVA: 0xBE4920 Offset: 0xBE2F20 VA: 0x180BE4920
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.ThrowOnError
	*/

	[AsyncStateMachine(typeof(WebCompletionSource.<WaitForCompletion>d__15<T>))]
	// RVA: -1 Offset: -1
	public Task<T> WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE55F0 Offset: 0xBE3BF0 VA: 0x180BE55F0
	|-WebCompletionSource<ValueTuple<bool, object>>.WaitForCompletion
	|
	|-RVA: 0xBE56F0 Offset: 0xBE3CF0 VA: 0x180BE56F0
	|-WebCompletionSource<object>.WaitForCompletion
	|
	|-RVA: 0xBE54D0 Offset: 0xBE3AD0 VA: 0x180BE54D0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/
}

// Namespace: System.Net
internal class WebCompletionSource : WebCompletionSource<object> // TypeDefIndex: 7885
{
	// Methods

	// RVA: 0x1DA4BB0 Offset: 0x1DA31B0 VA: 0x181DA4BB0
	public void .ctor() { }
}

// Namespace: System.Net
internal enum ReadState // TypeDefIndex: 7886
{
	// Fields
	public int value__; // 0x0
	public const ReadState None = 0;
	public const ReadState Status = 1;
	public const ReadState Headers = 2;
	public const ReadState Content = 3;
	public const ReadState Aborted = 4;
}

// Namespace: System.Net
internal class WebConnection : IDisposable // TypeDefIndex: 7891
{
	// Fields
	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	[CompilerGenerated]
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	private DateTime idleSince; // 0x50
	private WebOperation currentOperation; // 0x58

	// Properties
	public ServicePoint ServicePoint { get; }
	public bool Closed { get; }
	public DateTime IdleSince { get; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1DA7390 Offset: 0x1DA5990 VA: 0x181DA7390
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x1DA6340 Offset: 0x1DA4940 VA: 0x181DA6340
	private bool CanReuse() { }

	// RVA: 0x1DA6370 Offset: 0x1DA4970 VA: 0x181DA6370
	private bool CheckReusable() { }

	[AsyncStateMachine(typeof(WebConnection.<Connect>d__16))]
	// RVA: 0x1DA65C0 Offset: 0x1DA4BC0 VA: 0x181DA65C0
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<CreateStream>d__18))]
	// RVA: 0x1DA6840 Offset: 0x1DA4E40 VA: 0x181DA6840
	private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<InitConnection>d__19))]
	// RVA: 0x1DA6B40 Offset: 0x1DA5140 VA: 0x181DA6B40
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x1DA69D0 Offset: 0x1DA4FD0 VA: 0x181DA69D0
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x1DA6EE0 Offset: 0x1DA54E0 VA: 0x181DA6EE0
	internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x1DA5FE0 Offset: 0x1DA45E0 VA: 0x181DA5FE0
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x1DA6C90 Offset: 0x1DA5290 VA: 0x181DA6C90
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x1DA7100 Offset: 0x1DA5700 VA: 0x181DA7100
	private void Reset() { }

	// RVA: 0x1DA6520 Offset: 0x1DA4B20 VA: 0x181DA6520
	private void Close(bool reset) { }

	// RVA: 0x1DA63C0 Offset: 0x1DA49C0 VA: 0x181DA63C0
	private void CloseSocket() { }

	// RVA: 0x1DA73D0 Offset: 0x1DA59D0 VA: 0x181DA73D0
	public bool get_Closed() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public DateTime get_IdleSince() { }

	// RVA: 0x1DA71B0 Offset: 0x1DA57B0 VA: 0x181DA71B0
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x1DA66E0 Offset: 0x1DA4CE0 VA: 0x181DA66E0
	public bool Continue(WebOperation next) { }

	// RVA: 0x1DA6990 Offset: 0x1DA4F90 VA: 0x181DA6990
	private void Dispose(bool disposing) { }

	// RVA: 0x1DA6990 Offset: 0x1DA4F90 VA: 0x181DA6990 Slot: 4
	public void Dispose() { }

	// RVA: 0x1DA70D0 Offset: 0x1DA56D0 VA: 0x181DA70D0
	private void ResetNtlm() { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x4E5B20 Offset: 0x4E4120 VA: 0x1804E5B20
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x4E5B50 Offset: 0x4E4150 VA: 0x1804E5B50
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }
}

// Namespace: System.Net
internal abstract class WebConnectionStream : Stream // TypeDefIndex: 7892
{
	// Fields
	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly WebConnection <Connection>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x50

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebConnection Connection { get; }
	internal WebOperation Operation { get; }
	internal ServicePoint ServicePoint { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1DA59F0 Offset: 0x1DA3FF0 VA: 0x181DA59F0
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal WebOperation get_Operation() { }

	// RVA: 0x1DA5B90 Offset: 0x1DA4190 VA: 0x181DA5B90
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1DA5C00 Offset: 0x1DA4200 VA: 0x181DA5C00 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1DA5C70 Offset: 0x1DA4270 VA: 0x181DA5C70 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1DA5320 Offset: 0x1DA3920 VA: 0x181DA5320
	protected Exception GetException(Exception e) { }

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

	// RVA: 0x1DA54A0 Offset: 0x1DA3AA0 VA: 0x181DA54A0 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1DA4BF0 Offset: 0x1DA31F0 VA: 0x181DA4BF0 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1DA50C0 Offset: 0x1DA36C0 VA: 0x181DA50C0 Slot: 23
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1DA4E70 Offset: 0x1DA3470 VA: 0x181DA4E70 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1DA5190 Offset: 0x1DA3790 VA: 0x181DA5190 Slot: 27
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1DA57B0 Offset: 0x1DA3DB0 VA: 0x181DA57B0 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void Flush() { }

	// RVA: 0x1DA5240 Offset: 0x1DA3840 VA: 0x181DA5240 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1774A10 Offset: 0x1773010 VA: 0x181774A10
	internal void InternalClose() { }

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract void Close_internal(ref bool disposed);

	// RVA: 0x1DA50A0 Offset: 0x1DA36A0 VA: 0x181DA50A0 Slot: 18
	public override void Close() { }

	// RVA: 0x1DA5760 Offset: 0x1DA3D60 VA: 0x181DA5760 Slot: 30
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1DA5AF0 Offset: 0x1DA40F0 VA: 0x181DA5AF0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1DA5B40 Offset: 0x1DA4140 VA: 0x181DA5B40 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1DA5BB0 Offset: 0x1DA41B0 VA: 0x181DA5BB0 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: System.Net
internal class WebConnectionTunnel // TypeDefIndex: 7896
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private WebConnectionTunnel.NtlmAuthState ntlmAuthState; // 0x28
	[CompilerGenerated]
	private bool <Success>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <CloseConnection>k__BackingField; // 0x2D
	[CompilerGenerated]
	private int <StatusCode>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <Challenge>k__BackingField; // 0x40
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	[CompilerGenerated]
	private Version <ProxyVersion>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x58

	// Properties
	public HttpWebRequest Request { get; }
	public Uri ConnectUri { get; }
	public bool Success { get; set; }
	public bool CloseConnection { get; set; }
	public int StatusCode { get; set; }
	private string StatusDescription { set; }
	public string[] Challenge { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public Version ProxyVersion { get; set; }
	public byte[] Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Uri get_ConnectUri() { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	[CompilerGenerated]
	// RVA: 0x54CA70 Offset: 0x54B070 VA: 0x18054CA70
	public bool get_Success() { }

	[CompilerGenerated]
	// RVA: 0x1897480 Offset: 0x1895A80 VA: 0x181897480
	private void set_Success(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1897350 Offset: 0x1895950 VA: 0x181897350
	public bool get_CloseConnection() { }

	[CompilerGenerated]
	// RVA: 0x1897490 Offset: 0x1895A90 VA: 0x181897490
	private void set_CloseConnection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	private void set_StatusCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string[] get_Challenge() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	private void set_Challenge(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public Version get_ProxyVersion() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	private void set_ProxyVersion(Version value) { }

	[CompilerGenerated]
	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	private void set_Data(byte[] value) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<Initialize>d__42))]
	// RVA: 0x1DA5D70 Offset: 0x1DA4370 VA: 0x181DA5D70
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<ReadHeaders>d__43))]
	// RVA: 0x1DA5E90 Offset: 0x1DA4490 VA: 0x181DA5E90
	private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1DA5CE0 Offset: 0x1DA42E0 VA: 0x181DA5CE0
	private void FlushContents(Stream stream, int contentLength) { }
}

// Namespace: System.Net
internal class WebOperation // TypeDefIndex: 7898
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private WebConnection <Connection>k__BackingField; // 0x18
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	private CancellationTokenSource cts; // 0x38
	private WebCompletionSource<WebRequestStream> requestTask; // 0x40
	private WebCompletionSource<WebRequestStream> requestWrittenTask; // 0x48
	private WebCompletionSource<WebResponseStream> responseTask; // 0x50
	private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask; // 0x58
	private WebRequestStream writeStream; // 0x60
	private WebResponseStream responseStream; // 0x68
	private ExceptionDispatchInfo disposedInfo; // 0x70
	private ExceptionDispatchInfo closedInfo; // 0x78
	private WebOperation priorityRequest; // 0x80
	private int requestSent; // 0x88
	private int finished; // 0x8C

	// Properties
	public HttpWebRequest Request { get; }
	public WebConnection Connection { get; set; }
	public ServicePoint ServicePoint { get; set; }
	public BufferOffsetSize WriteBuffer { get; }
	public bool IsNtlmChallenge { get; }
	public bool Aborted { get; }
	public bool Closed { get; }
	public WebRequestStream WriteStream { get; }
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_Connection(WebConnection value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_ServicePoint(ServicePoint value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public BufferOffsetSize get_WriteBuffer() { }

	[CompilerGenerated]
	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x1DA8350 Offset: 0x1DA6950 VA: 0x181DA8350
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x1DA8510 Offset: 0x1DA6B10 VA: 0x181DA8510
	public bool get_Aborted() { }

	// RVA: 0x1DA8560 Offset: 0x1DA6B60 VA: 0x181DA8560
	public bool get_Closed() { }

	// RVA: 0x1DA73E0 Offset: 0x1DA59E0 VA: 0x181DA73E0
	public void Abort() { }

	// RVA: 0x1DA75A0 Offset: 0x1DA5BA0 VA: 0x181DA75A0
	public void Close() { }

	// RVA: 0x1DA7CE0 Offset: 0x1DA62E0 VA: 0x181DA7CE0
	private void SetCanceled() { }

	// RVA: 0x1DA7E90 Offset: 0x1DA6490 VA: 0x181DA7E90
	private void SetError(Exception error) { }

	// RVA: 0x1DA7DB0 Offset: 0x1DA63B0 VA: 0x181DA7DB0
	private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x1DA7440 Offset: 0x1DA5A40 VA: 0x181DA7440
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1DA82B0 Offset: 0x1DA68B0 VA: 0x181DA82B0
	internal void ThrowIfDisposed() { }

	// RVA: 0x1DA81D0 Offset: 0x1DA67D0 VA: 0x181DA81D0
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1DA8090 Offset: 0x1DA6690 VA: 0x181DA8090
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x1DA80F0 Offset: 0x1DA66F0 VA: 0x181DA80F0
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1DA7520 Offset: 0x1DA5B20 VA: 0x181DA7520
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	// RVA: 0x1DA79A0 Offset: 0x1DA5FA0 VA: 0x181DA79A0
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x1DA7F30 Offset: 0x1DA6530 VA: 0x181DA7F30
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x1DA7900 Offset: 0x1DA5F00 VA: 0x181DA7900
	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x1DA85C0 Offset: 0x1DA6BC0 VA: 0x181DA85C0
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x1DA7950 Offset: 0x1DA5F50 VA: 0x181DA7950
	public Task<WebResponseStream> GetResponseStream() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> get_Finished() { }

	[AsyncStateMachine(typeof(WebOperation.<Run>d__58))]
	// RVA: 0x1DA7C20 Offset: 0x1DA6220 VA: 0x181DA7C20
	internal void Run() { }

	// RVA: 0x1DA7600 Offset: 0x1DA5C00 VA: 0x181DA7600
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x1DA7690 Offset: 0x1DA5C90 VA: 0x181DA7690
	internal void Finish(bool ok, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x1DA8310 Offset: 0x1DA6910 VA: 0x181DA8310
	private void <RegisterRequest>b__48_0() { }
}

// Namespace: System.Net
internal abstract class WebReadStream : Stream // TypeDefIndex: 7900
{
	// Fields
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Properties
	public WebOperation Operation { get; }
	protected Stream InnerStream { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public WebOperation get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	protected Stream get_InnerStream() { }

	// RVA: 0x1DA9120 Offset: 0x1DA7720 VA: 0x181DA9120
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x1DA91B0 Offset: 0x1DA77B0 VA: 0x181DA91B0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1DA91F0 Offset: 0x1DA77F0 VA: 0x181DA91F0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1DA9230 Offset: 0x1DA7830 VA: 0x181DA9230 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1DA90A0 Offset: 0x1DA76A0 VA: 0x181DA90A0 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1DA90E0 Offset: 0x1DA76E0 VA: 0x181DA90E0 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1DA8AD0 Offset: 0x1DA70D0 VA: 0x181DA8AD0 Slot: 20
	public override void Flush() { }

	// RVA: 0x1DA8B10 Offset: 0x1DA7110 VA: 0x181DA8B10
	protected Exception GetException(Exception e) { }

	// RVA: 0x1DA8DE0 Offset: 0x1DA73E0 VA: 0x181DA8DE0 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1DA8620 Offset: 0x1DA6C20 VA: 0x181DA8620 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1DA88F0 Offset: 0x1DA6EF0 VA: 0x181DA88F0 Slot: 23
	public override int EndRead(IAsyncResult r) { }

	[AsyncStateMachine(typeof(WebReadStream.<ReadAsync>d__28))]
	// RVA: 0x1DA8C90 Offset: 0x1DA7290 VA: 0x181DA8C90 Slot: 24
	public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

	// RVA: 0x1DA89C0 Offset: 0x1DA6FC0 VA: 0x181DA89C0 Slot: 38
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1DA88A0 Offset: 0x1DA6EA0 VA: 0x181DA88A0 Slot: 19
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Net
internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 7909
{
	// Fields
	private static byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x58
	private bool requestWritten; // 0x60
	private bool allowBuffering; // 0x61
	private bool sendChunked; // 0x62
	private WebCompletionSource pendingWrite; // 0x68
	private long totalWritten; // 0x70
	private byte[] headers; // 0x78
	private bool headersSent; // 0x80
	private int completeRequestWritten; // 0x84
	private int chunkTrailerWritten; // 0x88
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly bool <KeepAlive>k__BackingField; // 0x98

	// Properties
	internal Stream InnerStream { get; }
	public bool KeepAlive { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	internal bool HasWriteBuffer { get; }
	internal int WriteBufferLength { get; }

	// Methods

	// RVA: 0x1DAA4E0 Offset: 0x1DA8AE0 VA: 0x181DAA4E0
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	internal Stream get_InnerStream() { }

	[CompilerGenerated]
	// RVA: 0x3A35D0 Offset: 0x3A1BD0 VA: 0x1803A35D0
	public bool get_KeepAlive() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1DAA670 Offset: 0x1DA8C70 VA: 0x181DAA670
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x1DAA6A0 Offset: 0x1DA8CA0 VA: 0x181DAA6A0
	internal int get_WriteBufferLength() { }

	// RVA: 0x1DA96B0 Offset: 0x1DA7CB0 VA: 0x181DA96B0
	internal BufferOffsetSize GetWriteBuffer() { }

	[AsyncStateMachine(typeof(WebRequestStream.<FinishWriting>d__31))]
	// RVA: 0x1DA95B0 Offset: 0x1DA7BB0 VA: 0x181DA95B0
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x1DA9D70 Offset: 0x1DA8370 VA: 0x181DA9D70 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteAsyncInner>d__33))]
	// RVA: 0x1DA9C30 Offset: 0x1DA8230 VA: 0x181DA9C30
	private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<ProcessWrite>d__34))]
	// RVA: 0x1DA9900 Offset: 0x1DA7F00 VA: 0x181DA9900
	private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DA9270 Offset: 0x1DA7870 VA: 0x181DA9270
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[AsyncStateMachine(typeof(WebRequestStream.<Initialize>d__36))]
	// RVA: 0x1DA97D0 Offset: 0x1DA7DD0 VA: 0x181DA97D0
	internal Task Initialize(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<SetHeadersAsync>d__37))]
	// RVA: 0x1DA9AD0 Offset: 0x1DA80D0 VA: 0x181DA9AD0
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteRequestAsync>d__38))]
	// RVA: 0x1DAA340 Offset: 0x1DA8940 VA: 0x181DAA340
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer_inner>d__39))]
	// RVA: 0x1DAA150 Offset: 0x1DA8750 VA: 0x181DAA150
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer>d__40))]
	// RVA: 0x1DAA250 Offset: 0x1DA8850 VA: 0x181DAA250
	private Task WriteChunkTrailer() { }

	// RVA: 0x1DA98E0 Offset: 0x1DA7EE0 VA: 0x181DA98E0
	internal void KillBuffer() { }

	// RVA: 0x1DA9A40 Offset: 0x1DA8040 VA: 0x181DA9A40 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DA9BF0 Offset: 0x1DA81F0 VA: 0x181DA9BF0 Slot: 37
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x1DA9320 Offset: 0x1DA7920 VA: 0x181DA9320 Slot: 38
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x1DAA450 Offset: 0x1DA8A50 VA: 0x181DAA450
	private static void .cctor() { }
}

// Namespace: System.Net
internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 7915
{
	// Fields
	private WebReadStream innerStream; // 0x58
	private bool nextReadCalled; // 0x60
	private bool bufferedEntireContent; // 0x61
	private WebCompletionSource pendingRead; // 0x68
	private object locker; // 0x70
	private int nestedRead; // 0x78
	private bool read_eof; // 0x7C
	[CompilerGenerated]
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0x80
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x88
	[CompilerGenerated]
	private HttpStatusCode <StatusCode>k__BackingField; // 0x90
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x98
	[CompilerGenerated]
	private Version <Version>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <KeepAlive>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <ChunkedRead>k__BackingField; // 0xA9

	// Properties
	public WebRequestStream RequestStream { get; }
	public WebHeaderCollection Headers { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public Version Version { get; set; }
	public bool KeepAlive { get; set; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	private bool ChunkedRead { get; set; }
	private bool ExpectContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public WebRequestStream get_RequestStream() { }

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public HttpStatusCode get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0xAC7EF0 Offset: 0xAC64F0 VA: 0x180AC7EF0
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_StatusDescription() { }

	[CompilerGenerated]
	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	private void set_Version(Version value) { }

	[CompilerGenerated]
	// RVA: 0x3A3490 Offset: 0x3A1A90 VA: 0x1803A3490
	public bool get_KeepAlive() { }

	[CompilerGenerated]
	// RVA: 0x3A3990 Offset: 0x3A1F90 VA: 0x1803A3990
	private void set_KeepAlive(bool value) { }

	// RVA: 0x1DAC180 Offset: 0x1DAA780 VA: 0x181DAC180
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	public override bool get_CanWrite() { }

	[CompilerGenerated]
	// RVA: 0x3A35A0 Offset: 0x3A1BA0 VA: 0x1803A35A0
	private bool get_ChunkedRead() { }

	[CompilerGenerated]
	// RVA: 0x168CD10 Offset: 0x168B310 VA: 0x18168CD10
	private void set_ChunkedRead(bool value) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAsync>d__40))]
	// RVA: 0x1DABEE0 Offset: 0x1DAA4E0 VA: 0x181DABEE0 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1DABA00 Offset: 0x1DAA000 VA: 0x181DABA00
	private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DAC040 Offset: 0x1DAA640 VA: 0x181DAC040 Slot: 37
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x1DAC220 Offset: 0x1DAA820 VA: 0x181DAC220
	private bool get_ExpectContent() { }

	// RVA: 0x1DAB320 Offset: 0x1DA9920 VA: 0x181DAB320
	private void Initialize(BufferOffsetSize buffer) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsyncInner>d__47))]
	// RVA: 0x1DABC90 Offset: 0x1DAA290 VA: 0x181DABC90
	private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsync>d__48))]
	// RVA: 0x1DABDC0 Offset: 0x1DAA3C0 VA: 0x181DABDC0
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x1DAC100 Offset: 0x1DAA700 VA: 0x181DAC100 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1DAA700 Offset: 0x1DA8D00 VA: 0x181DAA700 Slot: 38
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x1DAA7A0 Offset: 0x1DA8DA0 VA: 0x181DAA7A0
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[AsyncStateMachine(typeof(WebResponseStream.<InitReadAsync>d__52))]
	// RVA: 0x1DAB210 Offset: 0x1DA9810 VA: 0x181DAB210
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1DAAA40 Offset: 0x1DA9040 VA: 0x181DAAA40
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }
}

