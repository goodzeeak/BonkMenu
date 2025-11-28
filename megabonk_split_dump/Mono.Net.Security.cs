// Namespace: Mono.Net.Security
internal class BufferOffsetSize // TypeDefIndex: 7292
{
	// Fields
	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	// Properties
	public int EndOffset { get; }
	public int Remaining { get; }

	// Methods

	// RVA: 0x1A74120 Offset: 0x1A72720 VA: 0x181A74120
	public int get_EndOffset() { }

	// RVA: 0x1A74130 Offset: 0x1A72730 VA: 0x181A74130
	public int get_Remaining() { }

	// RVA: 0x1A73FC0 Offset: 0x1A725C0 VA: 0x181A73FC0
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x1A73F40 Offset: 0x1A72540 VA: 0x181A73F40 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2 : BufferOffsetSize // TypeDefIndex: 7293
{
	// Fields
	public readonly int InitialSize; // 0x28

	// Methods

	// RVA: 0x1A73E20 Offset: 0x1A72420 VA: 0x181A73E20
	public void .ctor(int size) { }

	// RVA: 0x1A73DC0 Offset: 0x1A723C0 VA: 0x181A73DC0
	public void Reset() { }

	// RVA: 0x1A73CE0 Offset: 0x1A722E0 VA: 0x181A73CE0
	public void MakeRoom(int size) { }

	// RVA: 0x1A73BD0 Offset: 0x1A721D0 VA: 0x181A73BD0
	public void AppendData(byte[] buffer, int offset, int size) { }
}

// Namespace: Mono.Net.Security
internal enum AsyncOperationStatus // TypeDefIndex: 7294
{
	// Fields
	public int value__; // 0x0
	public const AsyncOperationStatus Initialize = 0;
	public const AsyncOperationStatus Continue = 1;
	public const AsyncOperationStatus ReadDone = 2;
	public const AsyncOperationStatus Complete = 3;
}

// Namespace: Mono.Net.Security
internal class AsyncProtocolResult // TypeDefIndex: 7295
{
	// Fields
	[CompilerGenerated]
	private readonly int <UserResult>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x18

	// Properties
	public int UserResult { get; }
	public ExceptionDispatchInfo Error { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_UserResult() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	public void .ctor(int result) { }

	// RVA: 0x13E9320 Offset: 0x13E7920 VA: 0x1813E9320
	public void .ctor(ExceptionDispatchInfo error) { }
}

// Namespace: Mono.Net.Security
internal abstract class AsyncProtocolRequest // TypeDefIndex: 7299
{
	// Fields
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_RunSynchronously() { }

	// RVA: 0x1A73640 Offset: 0x1A71C40 VA: 0x181A73640
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_UserResult() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	protected void set_UserResult(int value) { }

	// RVA: 0x1A735A0 Offset: 0x1A71BA0 VA: 0x181A735A0
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x1A73360 Offset: 0x1A71960 VA: 0x181A73360
	internal void RequestRead(int size) { }

	// RVA: 0x1A733F0 Offset: 0x1A719F0 VA: 0x181A733F0
	internal void RequestWrite() { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<StartOperation>d__23))]
	// RVA: 0x1A73400 Offset: 0x1A71A00 VA: 0x181A73400
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<ProcessOperation>d__24))]
	// RVA: 0x1A73250 Offset: 0x1A71850 VA: 0x181A73250
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<InnerRead>d__25))]
	// RVA: 0x1A73120 Offset: 0x1A71720 VA: 0x181A73120
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	// RVA: 0x1A73530 Offset: 0x1A71B30 VA: 0x181A73530 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest : AsyncProtocolRequest // TypeDefIndex: 7300
{
	// Methods

	// RVA: 0x1A73110 Offset: 0x1A71710 VA: 0x181A73110
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x1A730E0 Offset: 0x1A716E0 VA: 0x181A730E0 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }
}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 7301
{
	// Fields
	[CompilerGenerated]
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGenerated]
	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	protected int get_CurrentSize() { }

	[CompilerGenerated]
	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	protected void set_CurrentSize(int value) { }

	// RVA: 0x1A736F0 Offset: 0x1A71CF0 VA: 0x181A736F0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A73680 Offset: 0x1A71C80 VA: 0x181A73680 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest : AsyncReadOrWriteRequest // TypeDefIndex: 7302
{
	// Methods

	// RVA: 0x1A73810 Offset: 0x1A71E10 VA: 0x181A73810
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A73790 Offset: 0x1A71D90 VA: 0x181A73790 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }
}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest : AsyncReadOrWriteRequest // TypeDefIndex: 7303
{
	// Methods

	// RVA: 0x1A73810 Offset: 0x1A71E10 VA: 0x181A73810
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A73820 Offset: 0x1A71E20 VA: 0x181A73820 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }
}

// Namespace: Mono.Net.Security
internal class ChainValidationHelper : ICertificateValidator // TypeDefIndex: 7305
{
	// Fields
	private readonly WeakReference<SslStream> owner; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MobileTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly MonoTlsStream tlsStream; // 0x38
	private readonly HttpWebRequest request; // 0x40

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x1A746F0 Offset: 0x1A72CF0 VA: 0x181A746F0
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1A74600 Offset: 0x1A72C00 VA: 0x181A74600
	internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x1A75000 Offset: 0x1A73600 VA: 0x181A75000
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0x1A747E0 Offset: 0x1A72DE0 VA: 0x181A747E0
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0x1A746B0 Offset: 0x1A72CB0 VA: 0x181A746B0
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 4
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x1A74990 Offset: 0x1A72F90 VA: 0x181A74990 Slot: 5
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x1A749F0 Offset: 0x1A72FF0 VA: 0x181A749F0
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1A74A90 Offset: 0x1A73090 VA: 0x181A74A90
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1A74B70 Offset: 0x1A73170 VA: 0x181A74B70
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1A748D0 Offset: 0x1A72ED0 VA: 0x181A748D0
	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }
}

// Namespace: Mono.Net.Security
internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable // TypeDefIndex: 7313
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private MobileAuthenticatedStream.Operation operation; // 0x80
	private static int uniqueNameInteger; // 0x0
	[CompilerGenerated]
	private readonly SslStream <SslStream>k__BackingField; // 0x88
	[CompilerGenerated]
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly MobileTlsProvider <Provider>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0xA0
	private static int nextId; // 0x4
	internal readonly int ID; // 0xA8

	// Properties
	public SslStream SslStream { get; }
	public MonoTlsSettings Settings { get; }
	public MobileTlsProvider Provider { get; }
	internal string TargetHost { get; set; }
	public override bool IsAuthenticated { get; }
	public X509Certificate LocalCertificate { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x1A77660 Offset: 0x1A75C60 VA: 0x181A77660
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0 Slot: 38
	public SslStream get_SslStream() { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public MonoTlsSettings get_Settings() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public MobileTlsProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	private void set_TargetHost(string value) { }

	// RVA: 0x1A759C0 Offset: 0x1A73FC0 VA: 0x181A759C0
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x1A75F20 Offset: 0x1A74520 VA: 0x181A75F20
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x1A75D00 Offset: 0x1A74300 VA: 0x181A75D00
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x1A75E80 Offset: 0x1A74480 VA: 0x181A75E80
	internal static Exception GetInternalError() { }

	// RVA: 0x1A75ED0 Offset: 0x1A744D0 VA: 0x181A75ED0
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0x1A77290 Offset: 0x1A75890 VA: 0x181A77290
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x1A757D0 Offset: 0x1A73DD0 VA: 0x181A757D0
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1A75660 Offset: 0x1A73C60 VA: 0x181A75660 Slot: 39
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48))]
	// RVA: 0x1A769B0 Offset: 0x1A74FB0 VA: 0x181A769B0
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

	// RVA: 0x1A77150 Offset: 0x1A75750 VA: 0x181A77150 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A77530 Offset: 0x1A75B30 VA: 0x181A77530 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A770A0 Offset: 0x1A756A0 VA: 0x181A770A0 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1A77480 Offset: 0x1A75A80 VA: 0x181A77480 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<StartOperation>d__57))]
	// RVA: 0x1A772E0 Offset: 0x1A758E0 VA: 0x181A772E0
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x1A76480 Offset: 0x1A74A80 VA: 0x181A76480
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x1A76310 Offset: 0x1A74910 VA: 0x181A76310
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A76840 Offset: 0x1A74E40 VA: 0x181A76840
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x1A76680 Offset: 0x1A74C80 VA: 0x181A76680
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerRead>d__66))]
	// RVA: 0x1A760A0 Offset: 0x1A746A0 VA: 0x181A760A0
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerWrite>d__67))]
	// RVA: 0x1A761F0 Offset: 0x1A747F0 VA: 0x181A761F0
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x1A76AF0 Offset: 0x1A750F0 VA: 0x181A76AF0
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0x1A76E20 Offset: 0x1A75420 VA: 0x181A76E20
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x1A76F60 Offset: 0x1A75560 VA: 0x181A76F60
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x1A779F0 Offset: 0x1A75FF0 VA: 0x181A779F0 Slot: 37
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1A75AC0 Offset: 0x1A740C0 VA: 0x181A75AC0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A75CD0 Offset: 0x1A742D0 VA: 0x181A75CD0 Slot: 20
	public override void Flush() { }

	// RVA: 0x1A77AF0 Offset: 0x1A760F0 VA: 0x181A77AF0 Slot: 41
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0x1A778F0 Offset: 0x1A75EF0 VA: 0x181A778F0 Slot: 42
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x1A77250 Offset: 0x1A75850 VA: 0x181A77250 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1A77800 Offset: 0x1A75E00 VA: 0x181A77800 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1A77850 Offset: 0x1A75E50 VA: 0x181A77850 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1A77880 Offset: 0x1A75E80 VA: 0x181A77880 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1A77AC0 Offset: 0x1A760C0 VA: 0x181A77AC0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1A77C00 Offset: 0x1A76200 VA: 0x181A77C00 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1A77C90 Offset: 0x1A76290 VA: 0x181A77C90 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1A77C30 Offset: 0x1A76230 VA: 0x181A77C30 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1A77CD0 Offset: 0x1A762D0 VA: 0x181A77CD0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1A77C60 Offset: 0x1A76260 VA: 0x181A77C60 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1A77D00 Offset: 0x1A76300 VA: 0x181A77D00 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1A77620 Offset: 0x1A75C20 VA: 0x181A77620
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1A77430 Offset: 0x1A75A30 VA: 0x181A77430
	private void <InnerWrite>b__67_0() { }
}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 7314
{
	// Fields
	private ChainValidationHelper certificateValidator; // 0x10
	[CompilerGenerated]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <TargetHost>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <ServerName>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly bool <AskForClientCertificate>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; // 0x44
	[CompilerGenerated]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; // 0x48
	[CompilerGenerated]
	private X509Certificate <LocalServerCertificate>k__BackingField; // 0x50

	// Properties
	internal MonoSslAuthenticationOptions Options { get; }
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	internal string TargetHost { get; }
	protected string ServerName { get; }
	protected bool AskForClientCertificate { get; }
	protected SslProtocols EnabledProtocols { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; set; }
	internal abstract X509Certificate LocalClientCertificate { get; }
	public abstract X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x1A78740 Offset: 0x1A76D40 VA: 0x181A78740
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal MonoSslAuthenticationOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x1A789F0 Offset: 0x1A76FF0 VA: 0x181A789F0
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated();

	[CompilerGenerated]
	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	protected string get_ServerName() { }

	[CompilerGenerated]
	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	protected bool get_AskForClientCertificate() { }

	[CompilerGenerated]
	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	protected SslProtocols get_EnabledProtocols() { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1A77E00 Offset: 0x1A76400 VA: 0x181A77E00
	protected void GetProtocolVersions(out Nullable<TlsProtocolCode> min, out Nullable<TlsProtocolCode> max) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake();

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal X509Certificate get_LocalServerCertificate() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	private void set_LocalServerCertificate(X509Certificate value) { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract X509Certificate2 get_RemoteCertificate();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool PendingRenegotiation();

	// RVA: 0x1A786E0 Offset: 0x1A76CE0 VA: 0x181A786E0
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0x1A78420 Offset: 0x1A76A20 VA: 0x181A78420
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	// RVA: 0x1A77EF0 Offset: 0x1A764F0 VA: 0x181A77EF0
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Renegotiate();

	// RVA: 0x1A77D30 Offset: 0x1A76330 VA: 0x181A77D30 Slot: 4
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 17
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1A77D90 Offset: 0x1A76390 VA: 0x181A77D90 Slot: 1
	protected override void Finalize() { }
}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsProvider : MonoTlsProvider // TypeDefIndex: 7315
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11);

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: Mono.Net.Security
internal abstract class MonoSslAuthenticationOptions // TypeDefIndex: 7316
{
	// Fields
	[CompilerGenerated]
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; // 0x10

	// Properties
	public abstract bool ServerMode { get; }
	public abstract bool AllowRenegotiation { get; }
	public abstract SslProtocols EnabledSslProtocols { get; set; }
	public abstract EncryptionPolicy EncryptionPolicy { set; }
	public abstract X509RevocationMode CertificateRevocationCheckMode { set; }
	public abstract string TargetHost { get; set; }
	public abstract X509Certificate ServerCertificate { get; }
	public abstract X509CertificateCollection ClientCertificates { get; set; }
	public abstract bool ClientCertificateRequired { get; }
	internal ServerCertSelectionCallback ServerCertSelectionDelegate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_ServerMode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_AllowRenegotiation();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract SslProtocols get_EnabledSslProtocols();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_EnabledSslProtocols(SslProtocols value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_EncryptionPolicy(EncryptionPolicy value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_CertificateRevocationCheckMode(X509RevocationMode value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_TargetHost();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_TargetHost(string value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract X509Certificate get_ServerCertificate();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract X509CertificateCollection get_ClientCertificates();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void set_ClientCertificates(X509CertificateCollection value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_ClientCertificateRequired();

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions // TypeDefIndex: 7317
{
	// Fields
	[CompilerGenerated]
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Properties
	public SslClientAuthenticationOptions Options { get; }
	public override bool ServerMode { get; }
	public override bool AllowRenegotiation { get; }
	public override X509RevocationMode CertificateRevocationCheckMode { set; }
	public override EncryptionPolicy EncryptionPolicy { set; }
	public override SslProtocols EnabledSslProtocols { get; set; }
	public override string TargetHost { get; set; }
	public override bool ClientCertificateRequired { get; }
	public override X509CertificateCollection ClientCertificates { get; set; }
	public override X509Certificate ServerCertificate { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 4
	public override bool get_ServerMode() { }

	// RVA: 0x1A80C10 Offset: 0x1A7F210 VA: 0x181A80C10
	public void .ctor() { }

	// RVA: 0x1A80C80 Offset: 0x1A7F280 VA: 0x181A80C80 Slot: 5
	public override bool get_AllowRenegotiation() { }

	// RVA: 0x1A80D20 Offset: 0x1A7F320 VA: 0x181A80D20 Slot: 9
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x1A80D90 Offset: 0x1A7F390 VA: 0x181A80D90 Slot: 8
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x965B90 Offset: 0x964190 VA: 0x180965B90 Slot: 6
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x1A80D70 Offset: 0x1A7F370 VA: 0x181A80D70 Slot: 7
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x168F7B0 Offset: 0x168DDB0 VA: 0x18168F7B0 Slot: 10
	public override string get_TargetHost() { }

	// RVA: 0x168F820 Offset: 0x168DE20 VA: 0x18168F820 Slot: 11
	public override void set_TargetHost(string value) { }

	// RVA: 0x1A80CA0 Offset: 0x1A7F2A0 VA: 0x181A80CA0 Slot: 15
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0x168F8F0 Offset: 0x168DEF0 VA: 0x18168F8F0 Slot: 13
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1A80D40 Offset: 0x1A7F340 VA: 0x181A80D40 Slot: 14
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x1A80CE0 Offset: 0x1A7F2E0 VA: 0x181A80CE0 Slot: 12
	public override X509Certificate get_ServerCertificate() { }
}

// Namespace: Mono.Net.Security
internal static class MonoTlsProviderFactory // TypeDefIndex: 7318
{
	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MobileTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MobileTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48

	// Methods

	// RVA: 0x1A81000 Offset: 0x1A7F600 VA: 0x181A81000
	internal static MobileTlsProvider GetProviderInternal() { }

	// RVA: 0x1A81140 Offset: 0x1A7F740 VA: 0x181A81140
	internal static void InitializeInternal() { }

	// RVA: 0x1A81870 Offset: 0x1A7FE70 VA: 0x181A81870
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x1A814E0 Offset: 0x1A7FAE0 VA: 0x181A814E0
	private static void InitializeProviderRegistration() { }

	// RVA: 0x1A82010 Offset: 0x1A80610 VA: 0x181A82010
	private static void PopulateUnityProviders() { }

	// RVA: 0x1A81E00 Offset: 0x1A80400 VA: 0x181A81E00
	private static void PopulateProviders() { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	internal static bool IsBtlsSupported() { }

	// RVA: 0x1A80DB0 Offset: 0x1A7F3B0 VA: 0x181A80DB0
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x1A81100 Offset: 0x1A7F700 VA: 0x181A81100
	internal static MobileTlsProvider GetProvider() { }

	// RVA: 0x1A82150 Offset: 0x1A80750 VA: 0x181A82150
	private static void .cctor() { }
}

// Namespace: Mono.Net.Security
internal class MonoTlsStream : IDisposable // TypeDefIndex: 7320
{
	// Fields
	private readonly MobileTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private SslStream sslStream; // 0x30
	private readonly object sslStreamLock; // 0x38
	private WebExceptionStatus status; // 0x40
	[CompilerGenerated]
	private bool <CertificateValidationFailed>k__BackingField; // 0x44

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal HttpWebRequest get_Request() { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGenerated]
	// RVA: 0x43C000 Offset: 0x43A600 VA: 0x18043C000
	internal bool get_CertificateValidationFailed() { }

	[CompilerGenerated]
	// RVA: 0x16EE2D0 Offset: 0x16EC8D0 VA: 0x1816EE2D0
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x1A824A0 Offset: 0x1A80AA0 VA: 0x181A824A0
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	[AsyncStateMachine(typeof(MonoTlsStream.<CreateStream>d__18))]
	// RVA: 0x1A82340 Offset: 0x1A80940 VA: 0x181A82340
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0x1A82490 Offset: 0x1A80A90 VA: 0x181A82490 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A82290 Offset: 0x1A80890 VA: 0x181A82290
	private void CloseSslStream() { }
}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper // TypeDefIndex: 7321
{
	// Methods

	// RVA: 0x1A82710 Offset: 0x1A80D10 VA: 0x181A82710
	internal static object GetProvider() { }
}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator // TypeDefIndex: 7322
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0x1A838E0 Offset: 0x1A81EE0 VA: 0x181A838E0
	private static void .cctor() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	internal static bool NeedsChain(MonoTlsSettings settings) { }
}

