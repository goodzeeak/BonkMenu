// Namespace: Mono.Unity
internal static class CertHelper // TypeDefIndex: 7230
{
	// Methods

	// RVA: 0x1A744A0 Offset: 0x1A72AA0 VA: 0x181A744A0
	public static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A742E0 Offset: 0x1A728E0 VA: 0x181A742E0
	public static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: Mono.Unity
internal static class Debug // TypeDefIndex: 7231
{
	// Methods

	// RVA: 0x1A755B0 Offset: 0x1A73BB0 VA: 0x181A755B0
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	// RVA: 0x1A75420 Offset: 0x1A73A20 VA: 0x181A75420
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }
}

// Namespace: Mono.Unity
internal static class UnityTls // TypeDefIndex: 7286
{
	// Fields
	private static UnityTls.unitytls_interface_struct marshalledInterface; // 0x0

	// Properties
	public static bool IsSupported { get; }
	public static UnityTls.unitytls_interface_struct NativeInterface { get; }

	// Methods

	// RVA: 0x1A8ACE0 Offset: 0x1A892E0 VA: 0x181A8ACE0
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0x1A8ACF0 Offset: 0x1A892F0 VA: 0x181A8ACF0
	public static bool get_IsSupported() { }

	// RVA: 0x1A8AD10 Offset: 0x1A89310 VA: 0x181A8AD10
	public static UnityTls.unitytls_interface_struct get_NativeInterface() { }
}

// Namespace: Mono.Unity
internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 7287
{
	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate2 remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }
	public override X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x1A890E0 Offset: 0x1A876E0 VA: 0x181A890E0
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0x1A87610 Offset: 0x1A85C10 VA: 0x181A87610
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x3A3490 Offset: 0x3A1A90 VA: 0x1803A3490 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910 Slot: 10
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public override void Flush() { }

	// RVA: 0x1A881F0 Offset: 0x1A867F0 VA: 0x181A881F0 Slot: 12
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A88ED0 Offset: 0x1A874D0 VA: 0x181A88ED0 Slot: 13
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A88400 Offset: 0x1A86A00 VA: 0x181A88400 Slot: 16
	public override void Renegotiate() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	public override bool PendingRenegotiation() { }

	// RVA: 0x1A88440 Offset: 0x1A86A40 VA: 0x181A88440 Slot: 14
	public override void Shutdown() { }

	// RVA: 0x1A874B0 Offset: 0x1A85AB0 VA: 0x181A874B0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A88570 Offset: 0x1A86B70 VA: 0x181A88570 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x1A87AB0 Offset: 0x1A860B0 VA: 0x181A87AB0 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x1A87930 Offset: 0x1A85F30 VA: 0x181A87930 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
	// RVA: 0x1A88D90 Offset: 0x1A87390 VA: 0x181A88D90
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A88B80 Offset: 0x1A87180 VA: 0x181A88B80
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
	// RVA: 0x1A87E00 Offset: 0x1A86400 VA: 0x181A87E00
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A87F40 Offset: 0x1A86540 VA: 0x181A87F40
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
	// RVA: 0x1A88A60 Offset: 0x1A87060 VA: 0x181A88A60
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A887C0 Offset: 0x1A86DC0 VA: 0x181A887C0
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
	// RVA: 0x1A87370 Offset: 0x1A85970 VA: 0x181A87370
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A87020 Offset: 0x1A85620 VA: 0x181A87020
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: Mono.Unity
internal static class UnityTlsConversions // TypeDefIndex: 7288
{
	// Methods

	// RVA: 0x1A89D40 Offset: 0x1A88340 VA: 0x181A89D40
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x1A89D00 Offset: 0x1A88300 VA: 0x181A89D00
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x1A89CD0 Offset: 0x1A882D0 VA: 0x181A89CD0
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x1A89D80 Offset: 0x1A88380 VA: 0x181A89D80
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x1A89E20 Offset: 0x1A88420 VA: 0x181A89E20
	public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

	// RVA: 0x1A89DE0 Offset: 0x1A883E0 VA: 0x181A89DE0
	public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult) { }
}

// Namespace: Mono.Unity
internal class UnityTlsProvider : MobileTlsProvider // TypeDefIndex: 7289
{
	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x1A8A9F0 Offset: 0x1A88FF0 VA: 0x181A8A9F0 Slot: 5
	public override string get_Name() { }

	// RVA: 0x1A8A990 Offset: 0x1A88F90 VA: 0x181A8A990 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x1A80C00 Offset: 0x1A7F200 VA: 0x181A80C00 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x1A89E50 Offset: 0x1A88450 VA: 0x181A89E50 Slot: 11
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
	// RVA: 0x1A8AA20 Offset: 0x1A89020 VA: 0x181A8AA20
	private static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A8A040 Offset: 0x1A88640 VA: 0x181A8A040 Slot: 12
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Mono.Unity
internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 7290
{
	// Methods

	// RVA: 0x1A8AB10 Offset: 0x1A89110 VA: 0x181A8AB10
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x1A8AAA0 Offset: 0x1A890A0 VA: 0x181A8AAA0 Slot: 40
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }
}

// Namespace: Mono.Unity
internal class X509ChainImplUnityTls : X509ChainImpl // TypeDefIndex: 7291
{
	// Fields
	private X509ChainElementCollection elements; // 0x10
	private UnityTls.unitytls_x509list_ref nativeCertificateChain; // 0x18
	private X509ChainPolicy policy; // 0x20
	private List<X509ChainStatus> chainStatusList; // 0x28
	private bool reverseOrder; // 0x30

	// Properties
	public override bool IsValid { get; }
	internal UnityTls.unitytls_x509list_ref NativeCertificateChain { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: 0x1A8AFC0 Offset: 0x1A895C0 VA: 0x181A8AFC0
	internal void .ctor(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = False) { }

	// RVA: 0x1A8B3D0 Offset: 0x1A899D0 VA: 0x181A8B3D0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal UnityTls.unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0x1A8B060 Offset: 0x1A89660 VA: 0x181A8B060 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1A8ADE0 Offset: 0x1A893E0 VA: 0x181A8ADE0 Slot: 9
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1A8AF60 Offset: 0x1A89560 VA: 0x181A8AF60 Slot: 10
	public override void Reset() { }

	// RVA: 0x1A8AF20 Offset: 0x1A89520 VA: 0x181A8AF20 Slot: 11
	protected override void Dispose(bool disposing) { }
}

