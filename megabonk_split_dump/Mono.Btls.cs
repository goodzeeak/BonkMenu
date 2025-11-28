// Namespace: Mono.Btls
internal class MonoBtlsBio : MonoBtlsObject // TypeDefIndex: 7330
{
	// Properties
	protected internal MonoBtlsBio.BoringBioHandle Handle { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(MonoBtlsBio.BoringBioHandle handle) { }

	// RVA: 0x1A79EE0 Offset: 0x1A784E0 VA: 0x181A79EE0
	protected internal MonoBtlsBio.BoringBioHandle get_Handle() { }

	// RVA: 0x1A79F60 Offset: 0x1A78560 VA: 0x181A79F60
	private static extern void mono_btls_bio_free(IntPtr handle) { }
}

// Namespace: Mono.Btls
internal class MonoBtlsBioMemory : MonoBtlsBio // TypeDefIndex: 7331
{
	// Methods

	// RVA: 0x1A78DC0 Offset: 0x1A773C0 VA: 0x181A78DC0
	private static extern IntPtr mono_btls_bio_mem_new() { }

	// RVA: 0x1A78D30 Offset: 0x1A77330 VA: 0x181A78D30
	private static extern int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data) { }

	// RVA: 0x1A78C50 Offset: 0x1A77250 VA: 0x181A78C50
	public void .ctor() { }

	// RVA: 0x1A78A10 Offset: 0x1A77010 VA: 0x181A78A10
	public byte[] GetData() { }
}

// Namespace: Mono.Btls
internal interface IMonoBtlsBioMono // TypeDefIndex: 7332
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Read(byte[] buffer, int offset, int size, out bool wantMore);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Write(byte[] buffer, int offset, int size);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Close();
}

// Namespace: Mono.Btls
internal class MonoBtlsBioMono : MonoBtlsBio // TypeDefIndex: 7337
{
	// Fields
	private GCHandle handle; // 0x20
	private IntPtr instance; // 0x28
	private MonoBtlsBioMono.BioReadFunc readFunc; // 0x30
	private MonoBtlsBioMono.BioWriteFunc writeFunc; // 0x38
	private MonoBtlsBioMono.BioControlFunc controlFunc; // 0x40
	private IntPtr readFuncPtr; // 0x48
	private IntPtr writeFuncPtr; // 0x50
	private IntPtr controlFuncPtr; // 0x58
	private IMonoBtlsBioMono backend; // 0x60

	// Methods

	// RVA: 0x1A79940 Offset: 0x1A77F40 VA: 0x181A79940
	public void .ctor(IMonoBtlsBioMono backend) { }

	// RVA: 0x1A79E70 Offset: 0x1A78470 VA: 0x181A79E70
	private static extern IntPtr mono_btls_bio_mono_new() { }

	// RVA: 0x1A79DB0 Offset: 0x1A783B0 VA: 0x181A79DB0
	private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	// RVA: 0x1A790B0 Offset: 0x1A776B0 VA: 0x181A790B0
	private long Control(MonoBtlsBioMono.ControlCommand command, long arg) { }

	// RVA: 0x1A79400 Offset: 0x1A77A00 VA: 0x181A79400
	private int OnRead(IntPtr data, int dataLength, out int wantMore) { }

	[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioReadFunc))]
	// RVA: 0x1A79150 Offset: 0x1A77750 VA: 0x181A79150
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore) { }

	// RVA: 0x1A79570 Offset: 0x1A77B70 VA: 0x181A79570
	private int OnWrite(IntPtr data, int dataLength) { }

	[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioWriteFunc))]
	// RVA: 0x1A796C0 Offset: 0x1A77CC0 VA: 0x181A796C0
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

	[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioControlFunc))]
	// RVA: 0x1A78EE0 Offset: 0x1A774E0 VA: 0x181A78EE0
	private static long Control(IntPtr instance, MonoBtlsBioMono.ControlCommand command, long arg) { }

	// RVA: 0x1A78E30 Offset: 0x1A77430 VA: 0x181A78E30 Slot: 5
	protected override void Close() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono // TypeDefIndex: 7338
{
	// Fields
	private X509Certificate2 remoteCertificate; // 0x58
	private X509Certificate clientCertificate; // 0x60
	private X509CertificateImplBtls nativeServerCertificate; // 0x68
	private X509CertificateImplBtls nativeClientCertificate; // 0x70
	private MonoBtlsSslCtx ctx; // 0x78
	private MonoBtlsSsl ssl; // 0x80
	private MonoBtlsBio bio; // 0x88
	private MonoBtlsBio errbio; // 0x90
	private MonoTlsConnectionInfo connectionInfo; // 0x98
	private bool certificateValidated; // 0xA0
	private bool isAuthenticated; // 0xA1
	private bool connected; // 0xA2

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }
	public override X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x1A7C360 Offset: 0x1A7A960 VA: 0x181A7C360
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0x1A7A740 Offset: 0x1A78D40 VA: 0x181A7A740
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	// RVA: 0x1A7BEE0 Offset: 0x1A7A4E0 VA: 0x181A7BEE0
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x1A7B8C0 Offset: 0x1A79EC0 VA: 0x181A7B8C0
	private int SelectCallback(string[] acceptableIssuers) { }

	// RVA: 0x1A7B990 Offset: 0x1A79F90 VA: 0x181A7B990
	private int ServerNameCallback() { }

	// RVA: 0x1A7BD80 Offset: 0x1A7A380 VA: 0x181A7BD80 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x1A7BA00 Offset: 0x1A7A000 VA: 0x181A7BA00
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	// RVA: 0x1A7A200 Offset: 0x1A78800 VA: 0x181A7A200
	private static Exception GetException(MonoBtlsSslError status) { }

	// RVA: 0x1A7B440 Offset: 0x1A79A40 VA: 0x181A7B440 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x1A7A140 Offset: 0x1A78740 VA: 0x181A7A140
	private MonoBtlsSslError DoProcessHandshake() { }

	// RVA: 0x1A7A1A0 Offset: 0x1A787A0 VA: 0x181A7A1A0 Slot: 8
	public override void FinishHandshake() { }

	// RVA: 0x1A7A9E0 Offset: 0x1A78FE0 VA: 0x181A7A9E0
	private void InitializeConnection() { }

	// RVA: 0x1A7A660 Offset: 0x1A78C60 VA: 0x181A7A660
	private void GetPeerCertificate() { }

	// RVA: 0x1A7B1B0 Offset: 0x1A797B0 VA: 0x181A7B1B0
	private void InitializeSession() { }

	// RVA: 0x1A7A960 Offset: 0x1A78F60 VA: 0x181A7A960
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	// RVA: 0x1A7A1C0 Offset: 0x1A787C0 VA: 0x181A7A1C0 Slot: 11
	public override void Flush() { }

	// RVA: 0x1A7B5B0 Offset: 0x1A79BB0 VA: 0x181A7B5B0 Slot: 12
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1A7C0F0 Offset: 0x1A7A6F0 VA: 0x181A7C0F0 Slot: 13
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1A7B880 Offset: 0x1A79E80 VA: 0x181A7B880 Slot: 16
	public override void Renegotiate() { }

	// RVA: 0x1A7BD20 Offset: 0x1A7A320 VA: 0x181A7BD20 Slot: 14
	public override void Shutdown() { }

	// RVA: 0x1A7B410 Offset: 0x1A79A10 VA: 0x181A7B410 Slot: 15
	public override bool PendingRenegotiation() { }

	// RVA: -1 Offset: -1
	private void Dispose<T>(ref T disposable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7368B0 Offset: 0x734EB0 VA: 0x1807368B0
	|-MonoBtlsContext.Dispose<object>
	*/

	// RVA: 0x1A79FE0 Offset: 0x1A785E0 VA: 0x181A79FE0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A7B3B0 Offset: 0x1A799B0 VA: 0x181A7B3B0 Slot: 18
	private int Mono.Btls.IMonoBtlsBioMono.Read(byte[] buffer, int offset, int size, out bool wantMore) { }

	// RVA: 0x1A7B3E0 Offset: 0x1A799E0 VA: 0x181A7B3E0 Slot: 19
	private bool Mono.Btls.IMonoBtlsBioMono.Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	private void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	private void Mono.Btls.IMonoBtlsBioMono.Close() { }

	// RVA: 0x163E060 Offset: 0x163C660 VA: 0x18163E060 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 10
	public override X509Certificate2 get_RemoteCertificate() { }
}

// Namespace: Mono.Btls
internal static class MonoBtlsError // TypeDefIndex: 7339
{
	// Methods

	// RVA: 0x1A7C3B0 Offset: 0x1A7A9B0 VA: 0x181A7C3B0
	private static extern void mono_btls_error_clear_error() { }

	// RVA: 0x1A7C780 Offset: 0x1A7AD80 VA: 0x181A7C780
	private static extern int mono_btls_error_get_error_line(out IntPtr file, out int line) { }

	// RVA: 0x1A7C810 Offset: 0x1A7AE10 VA: 0x181A7C810
	private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	// RVA: 0x1A7C420 Offset: 0x1A7AA20 VA: 0x181A7C420
	private static extern int mono_btls_error_get_reason(int error) { }

	// RVA: 0x1A7C3B0 Offset: 0x1A7A9B0 VA: 0x181A7C3B0
	public static void ClearError() { }

	// RVA: 0x1A7C4A0 Offset: 0x1A7AAA0 VA: 0x181A7C4A0
	public static string GetErrorString(int error) { }

	// RVA: 0x1A7C680 Offset: 0x1A7AC80 VA: 0x181A7C680
	public static int GetError(out string file, out int line) { }

	// RVA: 0x1A7C420 Offset: 0x1A7AA20 VA: 0x181A7C420
	public static int GetErrorReason(int error) { }
}

// Namespace: Mono.Btls
internal class MonoBtlsException : Exception // TypeDefIndex: 7340
{
	// Methods

	// RVA: 0x1A7C910 Offset: 0x1A7AF10 VA: 0x181A7C910
	public void .ctor() { }

	// RVA: 0x1A7C9E0 Offset: 0x1A7AFE0 VA: 0x181A7C9E0
	public void .ctor(MonoBtlsSslError error) { }

	// RVA: 0x1A7C8B0 Offset: 0x1A7AEB0 VA: 0x181A7C8B0
	public void .ctor(string message) { }

	// RVA: 0x1A7C960 Offset: 0x1A7AF60 VA: 0x181A7C960
	public void .ctor(string format, object[] args) { }
}

// Namespace: Mono.Btls
internal class MonoBtlsKey : MonoBtlsObject // TypeDefIndex: 7342
{
	// Properties
	internal MonoBtlsKey.BoringKeyHandle Handle { get; }

	// Methods

	// RVA: 0x1A7D210 Offset: 0x1A7B810 VA: 0x181A7D210
	private static extern IntPtr mono_btls_key_new() { }

	// RVA: 0x1A7D0E0 Offset: 0x1A7B6E0 VA: 0x181A7D0E0
	private static extern void mono_btls_key_free(IntPtr handle) { }

	// RVA: 0x1A7D280 Offset: 0x1A7B880 VA: 0x181A7D280
	private static extern IntPtr mono_btls_key_up_ref(IntPtr handle) { }

	// RVA: 0x1A7D160 Offset: 0x1A7B760 VA: 0x181A7D160
	private static extern int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits) { }

	// RVA: 0x1A7D030 Offset: 0x1A7B630 VA: 0x181A7D030
	private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, byte[] der, int der_length) { }

	// RVA: 0x1A7CFB0 Offset: 0x1A7B5B0 VA: 0x181A7CFB0
	internal MonoBtlsKey.BoringKeyHandle get_Handle() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(MonoBtlsKey.BoringKeyHandle handle) { }

	// RVA: 0x1A7CDE0 Offset: 0x1A7B3E0 VA: 0x181A7CDE0
	public byte[] GetBytes(bool include_private_bits) { }

	// RVA: 0x1A7CA90 Offset: 0x1A7B090 VA: 0x181A7CA90
	public MonoBtlsKey Copy() { }

	// RVA: 0x1A7CBE0 Offset: 0x1A7B1E0 VA: 0x181A7CBE0
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }
}

// Namespace: Mono.Btls
internal abstract class MonoBtlsObject : IDisposable // TypeDefIndex: 7344
{
	// Fields
	private MonoBtlsObject.MonoBtlsHandle handle; // 0x10
	private Exception lastError; // 0x18

	// Properties
	internal MonoBtlsObject.MonoBtlsHandle Handle { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(MonoBtlsObject.MonoBtlsHandle handle) { }

	// RVA: 0x1A7D9A0 Offset: 0x1A7BFA0 VA: 0x181A7D9A0
	internal MonoBtlsObject.MonoBtlsHandle get_Handle() { }

	// RVA: 0x1A7D9C0 Offset: 0x1A7BFC0 VA: 0x181A7D9C0
	public bool get_IsValid() { }

	// RVA: 0x1A7D6A0 Offset: 0x1A7BCA0 VA: 0x181A7D6A0
	protected void CheckThrow() { }

	// RVA: 0x1A7D970 Offset: 0x1A7BF70 VA: 0x181A7D970
	protected Exception SetException(Exception ex) { }

	// RVA: 0x1A7D300 Offset: 0x1A7B900 VA: 0x181A7D300
	protected void CheckError(bool ok, string callerName) { }

	// RVA: 0x1A7D490 Offset: 0x1A7BA90 VA: 0x181A7D490
	protected void CheckError(int ret, string callerName) { }

	// RVA: 0x1A7D4A0 Offset: 0x1A7BAA0 VA: 0x181A7D4A0
	protected internal void CheckLastError(string callerName) { }

	// RVA: 0x1A7DA00 Offset: 0x1A7C000 VA: 0x181A7DA00
	private static extern void mono_btls_free(IntPtr data) { }

	// RVA: 0x1A7D8F0 Offset: 0x1A7BEF0 VA: 0x181A7D8F0
	protected void FreeDataPtr(IntPtr data) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected virtual void Close() { }

	// RVA: 0x1A7D740 Offset: 0x1A7BD40 VA: 0x181A7D740
	protected void Dispose(bool disposing) { }

	// RVA: 0x1A7D830 Offset: 0x1A7BE30 VA: 0x181A7D830 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A7D890 Offset: 0x1A7BE90 VA: 0x181A7D890 Slot: 1
	protected override void Finalize() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsPkcs12 : MonoBtlsObject // TypeDefIndex: 7346
{
	// Fields
	private MonoBtlsKey privateKey; // 0x20

	// Properties
	internal MonoBtlsPkcs12.BoringPkcs12Handle Handle { get; }
	public int Count { get; }
	public bool HasPrivateKey { get; }

	// Methods

	// RVA: 0x1A7E190 Offset: 0x1A7C790 VA: 0x181A7E190
	internal MonoBtlsPkcs12.BoringPkcs12Handle get_Handle() { }

	// RVA: 0x1A7E2B0 Offset: 0x1A7C8B0 VA: 0x181A7E2B0
	private static extern void mono_btls_pkcs12_free(IntPtr handle) { }

	// RVA: 0x1A7E630 Offset: 0x1A7CC30 VA: 0x181A7E630
	private static extern IntPtr mono_btls_pkcs12_new() { }

	// RVA: 0x1A7E3C0 Offset: 0x1A7C9C0 VA: 0x181A7E3C0
	private static extern int mono_btls_pkcs12_get_count(IntPtr handle) { }

	// RVA: 0x1A7E330 Offset: 0x1A7C930 VA: 0x181A7E330
	private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x1A7E540 Offset: 0x1A7CB40 VA: 0x181A7E540
	private static extern int mono_btls_pkcs12_import(IntPtr chain, void* data, int len, SafePasswordHandle password) { }

	// RVA: 0x1A7E4C0 Offset: 0x1A7CAC0 VA: 0x181A7E4C0
	private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	// RVA: 0x1A7E440 Offset: 0x1A7CA40 VA: 0x181A7E440
	private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	// RVA: 0x1A7E010 Offset: 0x1A7C610 VA: 0x181A7E010
	internal void .ctor() { }

	// RVA: 0x1A7E0F0 Offset: 0x1A7C6F0 VA: 0x181A7E0F0
	public int get_Count() { }

	// RVA: 0x1A7DA80 Offset: 0x1A7C080 VA: 0x181A7DA80
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x1A7DEA0 Offset: 0x1A7C4A0 VA: 0x181A7DEA0
	public void Import(byte[] buffer, SafePasswordHandle password) { }

	// RVA: 0x1A7E210 Offset: 0x1A7C810 VA: 0x181A7E210
	public bool get_HasPrivateKey() { }

	// RVA: 0x1A7DC80 Offset: 0x1A7C280 VA: 0x181A7DC80
	public MonoBtlsKey GetPrivateKey() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsProvider : MobileTlsProvider // TypeDefIndex: 7347
{
	// Properties
	public override Guid ID { get; }
	public override string Name { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x1A80B70 Offset: 0x1A7F170 VA: 0x181A80B70 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x1A80BD0 Offset: 0x1A7F1D0 VA: 0x181A80BD0 Slot: 5
	public override string get_Name() { }

	// RVA: 0x1A80AD0 Offset: 0x1A7F0D0 VA: 0x181A80AD0
	internal void .ctor() { }

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

	// RVA: 0x1A7EBA0 Offset: 0x1A7D1A0 VA: 0x181A7EBA0 Slot: 11
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x1A7ED70 Offset: 0x1A7D370 VA: 0x181A7ED70
	internal X509Certificate2Impl GetNativeCertificate(byte[] data, string password, X509KeyStorageFlags flags) { }

	// RVA: 0x1A7EF20 Offset: 0x1A7D520 VA: 0x181A7EF20
	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	// RVA: 0x1A7EEA0 Offset: 0x1A7D4A0 VA: 0x181A7EEA0
	internal X509Certificate2Impl GetNativeCertificate(byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	// RVA: 0x1A7F340 Offset: 0x1A7D940 VA: 0x181A7F340
	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	// RVA: 0x1A7FB30 Offset: 0x1A7E130 VA: 0x181A7FB30 Slot: 12
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0x1A804C0 Offset: 0x1A7EAC0 VA: 0x181A804C0
	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	// RVA: 0x1A7E780 Offset: 0x1A7CD80 VA: 0x181A7E780
	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0x1A7F4C0 Offset: 0x1A7DAC0 VA: 0x181A7F4C0
	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	// RVA: 0x1A7F710 Offset: 0x1A7DD10 VA: 0x181A7F710
	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0x1A7FAA0 Offset: 0x1A7E0A0 VA: 0x181A7FAA0
	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	// RVA: 0x1A7E730 Offset: 0x1A7CD30 VA: 0x181A7E730
	private static void AddUserStore(MonoBtlsX509Store store) { }

	// RVA: 0x1A7E6A0 Offset: 0x1A7CCA0 VA: 0x181A7E6A0
	private static void AddMachineStore(MonoBtlsX509Store store) { }

	// RVA: 0x1A7E6F0 Offset: 0x1A7CCF0 VA: 0x181A7E6F0
	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0x1A7EAA0 Offset: 0x1A7D0A0 VA: 0x181A7EAA0
	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1A7ECF0 Offset: 0x1A7D2F0 VA: 0x181A7ECF0
	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	// RVA: 0x1A7EC40 Offset: 0x1A7D240 VA: 0x181A7EC40
	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	// RVA: 0x1A7F040 Offset: 0x1A7D640 VA: 0x181A7F040
	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }
}

// Namespace: Mono.Btls
[UnmanagedFunctionPointer(2)]
internal sealed class MonoBtlsVerifyCallback : MulticastDelegate // TypeDefIndex: 7348
{
	// Methods

	// RVA: 0x1014780 Offset: 0x1012D80 VA: 0x181014780
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950 Slot: 13
	public virtual int Invoke(MonoBtlsX509StoreCtx ctx) { }
}

// Namespace: Mono.Btls
[UnmanagedFunctionPointer(2)]
internal sealed class MonoBtlsSelectCallback : MulticastDelegate // TypeDefIndex: 7349
{
	// Methods

	// RVA: 0xA82680 Offset: 0xA80C80 VA: 0x180A82680
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950 Slot: 13
	public virtual int Invoke(string[] acceptableIssuers) { }
}

// Namespace: Mono.Btls
[UnmanagedFunctionPointer(2)]
internal sealed class MonoBtlsServerNameCallback : MulticastDelegate // TypeDefIndex: 7350
{
	// Methods

	// RVA: 0x1012390 Offset: 0x1010990 VA: 0x181012390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1011D00 Offset: 0x1010300 VA: 0x181011D00 Slot: 13
	public virtual int Invoke() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsSsl : MonoBtlsObject // TypeDefIndex: 7353
{
	// Fields
	private MonoBtlsBio bio; // 0x20
	private MonoBtlsSsl.PrintErrorsCallbackFunc printErrorsFunc; // 0x28
	private IntPtr printErrorsFuncPtr; // 0x30

	// Properties
	internal MonoBtlsSsl.BoringSslHandle Handle { get; }

	// Methods

	// RVA: 0x1DCF2F0 Offset: 0x1DCD8F0 VA: 0x181DCF2F0
	private static extern void mono_btls_ssl_destroy(IntPtr handle) { }

	// RVA: 0x1DCF680 Offset: 0x1DCDC80 VA: 0x181DCF680
	private static extern IntPtr mono_btls_ssl_new(IntPtr handle) { }

	// RVA: 0x1DCFB70 Offset: 0x1DCE170 VA: 0x181DCFB70
	private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1DCFC00 Offset: 0x1DCE200 VA: 0x181DCFC00
	private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	// RVA: 0x1DCF160 Offset: 0x1DCD760 VA: 0x181DCF160
	private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1DCF0E0 Offset: 0x1DCD6E0 VA: 0x181DCF0E0
	private static extern int mono_btls_ssl_accept(IntPtr handle) { }

	// RVA: 0x1DCF270 Offset: 0x1DCD870 VA: 0x181DCF270
	private static extern int mono_btls_ssl_connect(IntPtr handle) { }

	// RVA: 0x1DCF600 Offset: 0x1DCDC00 VA: 0x181DCF600
	private static extern int mono_btls_ssl_handshake(IntPtr handle) { }

	// RVA: 0x1DCF1F0 Offset: 0x1DCD7F0 VA: 0x181DCF1F0
	private static extern void mono_btls_ssl_close(IntPtr handle) { }

	// RVA: 0x1DCFAF0 Offset: 0x1DCE0F0 VA: 0x181DCFAF0
	private static extern int mono_btls_ssl_shutdown(IntPtr handle) { }

	// RVA: 0x1DCF940 Offset: 0x1DCDF40 VA: 0x181DCF940
	private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	// RVA: 0x1DCF8B0 Offset: 0x1DCDEB0 VA: 0x181DCF8B0
	private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	// RVA: 0x1DCF790 Offset: 0x1DCDD90 VA: 0x181DCF790
	private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x1DCFC90 Offset: 0x1DCE290 VA: 0x181DCFC90
	private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x1DCF3F0 Offset: 0x1DCD9F0 VA: 0x181DCF3F0
	private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	// RVA: 0x1DCF580 Offset: 0x1DCDB80 VA: 0x181DCF580
	private static extern int mono_btls_ssl_get_version(IntPtr handle) { }

	// RVA: 0x1DCF370 Offset: 0x1DCD970 VA: 0x181DCF370
	private static extern int mono_btls_ssl_get_cipher(IntPtr handle) { }

	// RVA: 0x1DCF480 Offset: 0x1DCDA80 VA: 0x181DCF480
	private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	// RVA: 0x1DCF700 Offset: 0x1DCDD00 VA: 0x181DCF700
	private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	// RVA: 0x1DCFA60 Offset: 0x1DCE060 VA: 0x181DCFA60
	private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	// RVA: 0x1DCF500 Offset: 0x1DCDB00 VA: 0x181DCF500
	private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	// RVA: 0x1DCF9D0 Offset: 0x1DCDFD0 VA: 0x181DCF9D0
	private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	// RVA: 0x1DCF830 Offset: 0x1DCDE30 VA: 0x181DCF830
	private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	// RVA: 0x1DCD930 Offset: 0x1DCBF30 VA: 0x181DCD930
	private static MonoBtlsSsl.BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	// RVA: 0x1DCEE00 Offset: 0x1DCD400 VA: 0x181DCEE00
	public void .ctor(MonoBtlsSslCtx ctx) { }

	// RVA: 0x1DCF060 Offset: 0x1DCD660 VA: 0x181DCF060
	internal MonoBtlsSsl.BoringSslHandle get_Handle() { }

	// RVA: 0x1DCE480 Offset: 0x1DCCA80 VA: 0x181DCE480
	public void SetBio(MonoBtlsBio bio) { }

	// RVA: 0x1DCEB50 Offset: 0x1DCD150 VA: 0x181DCEB50
	private Exception ThrowError(string callerName) { }

	// RVA: 0x1DCDB40 Offset: 0x1DCC140 VA: 0x181DCDB40
	private MonoBtlsSslError GetError(int ret_code) { }

	// RVA: 0x1DCE570 Offset: 0x1DCCB70 VA: 0x181DCE570
	public void SetCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1DCE670 Offset: 0x1DCCC70 VA: 0x181DCE670
	public void SetPrivateKey(MonoBtlsKey key) { }

	// RVA: 0x1DCD6B0 Offset: 0x1DCBCB0 VA: 0x181DCD6B0
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1DCD5F0 Offset: 0x1DCBBF0 VA: 0x181DCD5F0
	public MonoBtlsSslError Accept() { }

	// RVA: 0x1DCD870 Offset: 0x1DCBE70 VA: 0x181DCD870
	public MonoBtlsSslError Connect() { }

	// RVA: 0x1DCE000 Offset: 0x1DCC600 VA: 0x181DCE000
	public MonoBtlsSslError Handshake() { }

	[MonoPInvokeCallback(typeof(MonoBtlsSsl.PrintErrorsCallbackFunc))]
	// RVA: 0x1DCE0C0 Offset: 0x1DCC6C0 VA: 0x181DCE0C0
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	// RVA: 0x1DCDBC0 Offset: 0x1DCC1C0 VA: 0x181DCDBC0
	public string GetErrors() { }

	// RVA: 0x1DCE210 Offset: 0x1DCC810 VA: 0x181DCE210
	public void PrintErrors() { }

	// RVA: 0x1DCE2E0 Offset: 0x1DCC8E0 VA: 0x181DCE2E0
	public MonoBtlsSslError Read(IntPtr data, ref int dataSize) { }

	// RVA: 0x1DCECF0 Offset: 0x1DCD2F0 VA: 0x181DCECF0
	public MonoBtlsSslError Write(IntPtr data, ref int dataSize) { }

	// RVA: 0x1DCDF60 Offset: 0x1DCC560 VA: 0x181DCDF60
	public int GetVersion() { }

	// RVA: 0x1DCDA60 Offset: 0x1DCC060 VA: 0x181DCDA60
	public int GetCipher() { }

	// RVA: 0x1DCDD50 Offset: 0x1DCC350 VA: 0x181DCDD50
	public MonoBtlsX509 GetPeerCertificate() { }

	// RVA: 0x1DCE8C0 Offset: 0x1DCCEC0 VA: 0x181DCE8C0
	public void SetServerName(string name) { }

	// RVA: 0x1DCDE70 Offset: 0x1DCC470 VA: 0x181DCDE70
	public string GetServerName() { }

	// RVA: 0x1DCEA80 Offset: 0x1DCD080 VA: 0x181DCEA80
	public void Shutdown() { }

	// RVA: 0x1DCE770 Offset: 0x1DCCD70 VA: 0x181DCE770
	public void SetQuietShutdown() { }

	// RVA: 0x1DCD7B0 Offset: 0x1DCBDB0 VA: 0x181DCD7B0 Slot: 5
	protected override void Close() { }

	// RVA: 0x1DCE810 Offset: 0x1DCCE10 VA: 0x181DCE810
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	// RVA: 0x1DCE3E0 Offset: 0x1DCC9E0 VA: 0x181DCE3E0
	public bool RenegotiatePending() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsSslCtx : MonoBtlsObject // TypeDefIndex: 7358
{
	// Fields
	private MonoBtlsSslCtx.NativeVerifyFunc verifyFunc; // 0x20
	private MonoBtlsSslCtx.NativeSelectFunc selectFunc; // 0x28
	private MonoBtlsSslCtx.NativeServerNameFunc serverNameFunc; // 0x30
	private IntPtr verifyFuncPtr; // 0x38
	private IntPtr selectFuncPtr; // 0x40
	private IntPtr serverNameFuncPtr; // 0x48
	private MonoBtlsVerifyCallback verifyCallback; // 0x50
	private MonoBtlsSelectCallback selectCallback; // 0x58
	private MonoBtlsServerNameCallback serverNameCallback; // 0x60
	private MonoBtlsX509Store store; // 0x68
	private GCHandle instance; // 0x70
	private IntPtr instancePtr; // 0x78

	// Properties
	internal MonoBtlsSslCtx.BoringSslCtxHandle Handle { get; }
	public MonoBtlsX509Store CertificateStore { get; }

	// Methods

	// RVA: 0x1DCCF40 Offset: 0x1DCB540 VA: 0x181DCCF40
	internal MonoBtlsSslCtx.BoringSslCtxHandle get_Handle() { }

	// RVA: 0x1DCD0D0 Offset: 0x1DCB6D0 VA: 0x181DCD0D0
	private static extern IntPtr mono_btls_ssl_ctx_new() { }

	// RVA: 0x1DCCFC0 Offset: 0x1DCB5C0 VA: 0x181DCCFC0
	private static extern int mono_btls_ssl_ctx_free(IntPtr handle) { }

	// RVA: 0x1DCD040 Offset: 0x1DCB640 VA: 0x181DCD040
	private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	// RVA: 0x1DCD1D0 Offset: 0x1DCB7D0 VA: 0x181DCD1D0
	private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	// RVA: 0x1DCD140 Offset: 0x1DCB740 VA: 0x181DCD140
	private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x1DCD440 Offset: 0x1DCBA40 VA: 0x181DCD440
	private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	// RVA: 0x1DCD3B0 Offset: 0x1DCB9B0 VA: 0x181DCD3B0
	private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	// RVA: 0x1DCD270 Offset: 0x1DCB870 VA: 0x181DCD270
	private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	// RVA: 0x1DCD560 Offset: 0x1DCBB60 VA: 0x181DCD560
	private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x1DCD310 Offset: 0x1DCB910 VA: 0x181DCD310
	private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x1DCD4D0 Offset: 0x1DCBAD0 VA: 0x181DCD4D0
	private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x1DCC9A0 Offset: 0x1DCAFA0 VA: 0x181DCC9A0
	public void .ctor() { }

	// RVA: 0x1DCCA70 Offset: 0x1DCB070 VA: 0x181DCCA70
	internal void .ctor(MonoBtlsSslCtx.BoringSslCtxHandle handle) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public MonoBtlsX509Store get_CertificateStore() { }

	// RVA: 0x1DCC970 Offset: 0x1DCAF70 VA: 0x181DCC970
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

	[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeVerifyFunc))]
	// RVA: 0x1DCBB40 Offset: 0x1DCA140 VA: 0x181DCBB40
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeSelectFunc))]
	// RVA: 0x1DCB870 Offset: 0x1DC9E70 VA: 0x181DCB870
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x1DCB440 Offset: 0x1DC9A40 VA: 0x181DCB440
	private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	// RVA: 0x1DCC780 Offset: 0x1DCAD80 VA: 0x181DCC780
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	// RVA: 0x1DCC600 Offset: 0x1DCAC00 VA: 0x181DCC600
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	// RVA: 0x1DCC550 Offset: 0x1DCAB50 VA: 0x181DCC550
	public void SetMinVersion(int version) { }

	// RVA: 0x1DCC4A0 Offset: 0x1DCAAA0 VA: 0x181DCC4A0
	public void SetMaxVersion(int version) { }

	// RVA: 0x1DCBEA0 Offset: 0x1DCA4A0 VA: 0x181DCBEA0
	public void SetCiphers(short[] ciphers, bool allow_unsupported) { }

	// RVA: 0x1DCC860 Offset: 0x1DCAE60 VA: 0x181DCC860
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x1DCC0B0 Offset: 0x1DCA6B0 VA: 0x181DCC0B0
	public void SetClientCertificateIssuers(string[] acceptableIssuers) { }

	// RVA: 0x1DCC6C0 Offset: 0x1DCACC0 VA: 0x181DCC6C0
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	[MonoPInvokeCallback(typeof(MonoBtlsSslCtx.NativeServerNameFunc))]
	// RVA: 0x1DCB9F0 Offset: 0x1DC9FF0 VA: 0x181DCB9F0
	private static int NativeServerNameCallback(IntPtr instance) { }

	// RVA: 0x1DCB3F0 Offset: 0x1DC99F0 VA: 0x181DCB3F0 Slot: 5
	protected override void Close() { }
}

// Namespace: Mono.Btls
internal enum MonoBtlsSslError // TypeDefIndex: 7359
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsSslError None = 0;
	public const MonoBtlsSslError Ssl = 1;
	public const MonoBtlsSslError WantRead = 2;
	public const MonoBtlsSslError WantWrite = 3;
	public const MonoBtlsSslError WantX509Lookup = 4;
	public const MonoBtlsSslError Syscall = 5;
	public const MonoBtlsSslError ZeroReturn = 6;
	public const MonoBtlsSslError WantConnect = 7;
	public const MonoBtlsSslError WantAccept = 8;
	public const MonoBtlsSslError WantChannelIdLookup = 9;
	public const MonoBtlsSslError PendingSession = 11;
	public const MonoBtlsSslError PendingCertificate = 12;
	public const MonoBtlsSslError WantPrivateKeyOperation = 13;
}

// Namespace: Mono.Btls
[Flags]
internal enum MonoBtlsSslRenegotiateMode // TypeDefIndex: 7360
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsSslRenegotiateMode NEVER = 0;
	public const MonoBtlsSslRenegotiateMode ONCE = 1;
	public const MonoBtlsSslRenegotiateMode FREELY = 2;
	public const MonoBtlsSslRenegotiateMode IGNORE = 3;
}

// Namespace: Mono.Btls
internal class MonoBtlsStream : MobileAuthenticatedStream // TypeDefIndex: 7361
{
	// Methods

	// RVA: 0x1DCFDA0 Offset: 0x1DCE3A0 VA: 0x181DCFDA0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x1DCFD30 Offset: 0x1DCE330 VA: 0x181DCFD30 Slot: 40
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }
}

// Namespace: Mono.Btls
internal static class MonoBtlsUtils // TypeDefIndex: 7362
{
	// Fields
	private static byte[] emailOid; // 0x0

	// Methods

	// RVA: 0x1DD0480 Offset: 0x1DCEA80 VA: 0x181DD0480
	public static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x1DCFE30 Offset: 0x1DCE430 VA: 0x181DCFE30
	private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	// RVA: 0x1DD0500 Offset: 0x1DCEB00 VA: 0x181DD0500
	public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

	// RVA: 0x1DD0670 Offset: 0x1DCEC70 VA: 0x181DD0670
	private static void .cctor() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsX509 : MonoBtlsObject // TypeDefIndex: 7364
{
	// Properties
	internal MonoBtlsX509.BoringX509Handle Handle { get; }

	// Methods

	// RVA: 0x1DD7840 Offset: 0x1DD5E40 VA: 0x181DD7840
	internal MonoBtlsX509.BoringX509Handle get_Handle() { }

	// RVA: 0x1CDFC90 Offset: 0x1CDE290 VA: 0x181CDFC90
	internal void .ctor(MonoBtlsX509.BoringX509Handle handle) { }

	// RVA: 0x1DD7C20 Offset: 0x1DD6220 VA: 0x181DD7C20
	private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

	// RVA: 0x1DD7A60 Offset: 0x1DD6060 VA: 0x181DD7A60
	private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	// RVA: 0x1DD7BA0 Offset: 0x1DD61A0 VA: 0x181DD7BA0
	private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	// RVA: 0x1DD7B00 Offset: 0x1DD6100 VA: 0x181DD7B00
	private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	// RVA: 0x1DD7950 Offset: 0x1DD5F50 VA: 0x181DD7950
	private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	// RVA: 0x1DD79E0 Offset: 0x1DD5FE0 VA: 0x181DD79E0
	private static extern void mono_btls_x509_free(IntPtr handle) { }

	// RVA: 0x1DD78C0 Offset: 0x1DD5EC0 VA: 0x181DD78C0
	private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	// RVA: 0x1DD6F40 Offset: 0x1DD5540 VA: 0x181DD6F40
	internal MonoBtlsX509 Copy() { }

	// RVA: 0x1DD75A0 Offset: 0x1DD5BA0 VA: 0x181DD75A0
	public static MonoBtlsX509 LoadFromData(byte[] buffer, MonoBtlsX509Format format) { }

	// RVA: 0x1DD7460 Offset: 0x1DD5A60 VA: 0x181DD7460
	public MonoBtlsX509Name GetSubjectName() { }

	// RVA: 0x1DD7260 Offset: 0x1DD5860 VA: 0x181DD7260
	public long GetSubjectNameHash() { }

	// RVA: 0x1DD7070 Offset: 0x1DD5670 VA: 0x181DD7070
	public byte[] GetRawData(MonoBtlsX509Format format) { }

	// RVA: 0x1DD6E70 Offset: 0x1DD5470 VA: 0x181DD6E70
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	// RVA: 0x1DD6D80 Offset: 0x1DD5380 VA: 0x181DD6D80
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }
}

// Namespace: Mono.Btls
internal class MonoBtlsX509Chain : MonoBtlsObject // TypeDefIndex: 7366
{
	// Properties
	internal MonoBtlsX509Chain.BoringX509ChainHandle Handle { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x1DD0BF0 Offset: 0x1DCF1F0 VA: 0x181DD0BF0
	internal MonoBtlsX509Chain.BoringX509ChainHandle get_Handle() { }

	// RVA: 0x1DD0E90 Offset: 0x1DCF490 VA: 0x181DD0E90
	private static extern IntPtr mono_btls_x509_chain_new() { }

	// RVA: 0x1DD0E10 Offset: 0x1DCF410 VA: 0x181DD0E10
	private static extern int mono_btls_x509_chain_get_count(IntPtr handle) { }

	// RVA: 0x1DD0D80 Offset: 0x1DCF380 VA: 0x181DD0D80
	private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x1DD0C70 Offset: 0x1DCF270 VA: 0x181DD0C70
	private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	// RVA: 0x1DD0F00 Offset: 0x1DCF500 VA: 0x181DD0F00
	private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

	// RVA: 0x1DD0D00 Offset: 0x1DCF300 VA: 0x181DD0D00
	private static extern void mono_btls_x509_chain_free(IntPtr handle) { }

	// RVA: 0x1DD0A80 Offset: 0x1DCF080 VA: 0x181DD0A80
	public void .ctor() { }

	// RVA: 0x1CDFC90 Offset: 0x1CDE290 VA: 0x181CDFC90
	internal void .ctor(MonoBtlsX509Chain.BoringX509ChainHandle handle) { }

	// RVA: 0x1DD0B50 Offset: 0x1DCF150 VA: 0x181DD0B50
	public int get_Count() { }

	// RVA: 0x1DD08F0 Offset: 0x1DCEEF0 VA: 0x181DD08F0
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x1DD0700 Offset: 0x1DCED00 VA: 0x181DD0700
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1DD07C0 Offset: 0x1DCEDC0 VA: 0x181DD07C0
	internal MonoBtlsX509Chain Copy() { }
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509Error // TypeDefIndex: 7367
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509Error OK = 0;
	public const MonoBtlsX509Error UNABLE_TO_GET_ISSUER_CERT = 2;
	public const MonoBtlsX509Error UNABLE_TO_GET_CRL = 3;
	public const MonoBtlsX509Error UNABLE_TO_DECRYPT_CERT_SIGNATURE = 4;
	public const MonoBtlsX509Error UNABLE_TO_DECRYPT_CRL_SIGNATURE = 5;
	public const MonoBtlsX509Error UNABLE_TO_DECODE_ISSUER_PUBLIC_KEY = 6;
	public const MonoBtlsX509Error CERT_SIGNATURE_FAILURE = 7;
	public const MonoBtlsX509Error CRL_SIGNATURE_FAILURE = 8;
	public const MonoBtlsX509Error CERT_NOT_YET_VALID = 9;
	public const MonoBtlsX509Error CERT_HAS_EXPIRED = 10;
	public const MonoBtlsX509Error CRL_NOT_YET_VALID = 11;
	public const MonoBtlsX509Error CRL_HAS_EXPIRED = 12;
	public const MonoBtlsX509Error ERROR_IN_CERT_NOT_BEFORE_FIELD = 13;
	public const MonoBtlsX509Error ERROR_IN_CERT_NOT_AFTER_FIELD = 14;
	public const MonoBtlsX509Error ERROR_IN_CRL_LAST_UPDATE_FIELD = 15;
	public const MonoBtlsX509Error ERROR_IN_CRL_NEXT_UPDATE_FIELD = 16;
	public const MonoBtlsX509Error OUT_OF_MEM = 17;
	public const MonoBtlsX509Error DEPTH_ZERO_SELF_SIGNED_CERT = 18;
	public const MonoBtlsX509Error SELF_SIGNED_CERT_IN_CHAIN = 19;
	public const MonoBtlsX509Error UNABLE_TO_GET_ISSUER_CERT_LOCALLY = 20;
	public const MonoBtlsX509Error UNABLE_TO_VERIFY_LEAF_SIGNATURE = 21;
	public const MonoBtlsX509Error CERT_CHAIN_TOO_LONG = 22;
	public const MonoBtlsX509Error CERT_REVOKED = 23;
	public const MonoBtlsX509Error INVALID_CA = 24;
	public const MonoBtlsX509Error PATH_LENGTH_EXCEEDED = 25;
	public const MonoBtlsX509Error INVALID_PURPOSE = 26;
	public const MonoBtlsX509Error CERT_UNTRUSTED = 27;
	public const MonoBtlsX509Error CERT_REJECTED = 28;
	public const MonoBtlsX509Error SUBJECT_ISSUER_MISMATCH = 29;
	public const MonoBtlsX509Error AKID_SKID_MISMATCH = 30;
	public const MonoBtlsX509Error AKID_ISSUER_SERIAL_MISMATCH = 31;
	public const MonoBtlsX509Error KEYUSAGE_NO_CERTSIGN = 32;
	public const MonoBtlsX509Error UNABLE_TO_GET_CRL_ISSUER = 33;
	public const MonoBtlsX509Error UNHANDLED_CRITICAL_EXTENSION = 34;
	public const MonoBtlsX509Error KEYUSAGE_NO_CRL_SIGN = 35;
	public const MonoBtlsX509Error UNHANDLED_CRITICAL_CRL_EXTENSION = 36;
	public const MonoBtlsX509Error INVALID_NON_CA = 37;
	public const MonoBtlsX509Error PROXY_PATH_LENGTH_EXCEEDED = 38;
	public const MonoBtlsX509Error KEYUSAGE_NO_DIGITAL_SIGNATURE = 39;
	public const MonoBtlsX509Error PROXY_CERTIFICATES_NOT_ALLOWED = 40;
	public const MonoBtlsX509Error INVALID_EXTENSION = 41;
	public const MonoBtlsX509Error INVALID_POLICY_EXTENSION = 42;
	public const MonoBtlsX509Error NO_EXPLICIT_POLICY = 43;
	public const MonoBtlsX509Error DIFFERENT_CRL_SCOPE = 44;
	public const MonoBtlsX509Error UNSUPPORTED_EXTENSION_FEATURE = 45;
	public const MonoBtlsX509Error UNNESTED_RESOURCE = 46;
	public const MonoBtlsX509Error PERMITTED_VIOLATION = 47;
	public const MonoBtlsX509Error EXCLUDED_VIOLATION = 48;
	public const MonoBtlsX509Error SUBTREE_MINMAX = 49;
	public const MonoBtlsX509Error UNSUPPORTED_CONSTRAINT_TYPE = 51;
	public const MonoBtlsX509Error UNSUPPORTED_CONSTRAINT_SYNTAX = 52;
	public const MonoBtlsX509Error UNSUPPORTED_NAME_SYNTAX = 53;
	public const MonoBtlsX509Error CRL_PATH_VALIDATION_ERROR = 54;
	public const MonoBtlsX509Error SUITE_B_INVALID_VERSION = 56;
	public const MonoBtlsX509Error SUITE_B_INVALID_ALGORITHM = 57;
	public const MonoBtlsX509Error SUITE_B_INVALID_CURVE = 58;
	public const MonoBtlsX509Error SUITE_B_INVALID_SIGNATURE_ALGORITHM = 59;
	public const MonoBtlsX509Error SUITE_B_LOS_NOT_ALLOWED = 60;
	public const MonoBtlsX509Error SUITE_B_CANNOT_SIGN_P_384_WITH_P_256 = 61;
	public const MonoBtlsX509Error HOSTNAME_MISMATCH = 62;
	public const MonoBtlsX509Error EMAIL_MISMATCH = 63;
	public const MonoBtlsX509Error IP_ADDRESS_MISMATCH = 64;
	public const MonoBtlsX509Error APPLICATION_VERIFICATION = 50;
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509FileType // TypeDefIndex: 7368
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509FileType PEM = 1;
	public const MonoBtlsX509FileType ASN1 = 2;
	public const MonoBtlsX509FileType DEFAULT = 3;
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509Format // TypeDefIndex: 7369
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509Format DER = 1;
	public const MonoBtlsX509Format PEM = 2;
}

// Namespace: Mono.Btls
internal class MonoBtlsX509Lookup : MonoBtlsObject // TypeDefIndex: 7371
{
	// Fields
	private MonoBtlsX509Store store; // 0x20
	private MonoBtlsX509LookupType type; // 0x28
	private List<MonoBtlsX509LookupMono> monoLookups; // 0x30

	// Properties
	internal MonoBtlsX509Lookup.BoringX509LookupHandle Handle { get; }

	// Methods

	// RVA: 0x1DD28E0 Offset: 0x1DD0EE0 VA: 0x181DD28E0
	internal MonoBtlsX509Lookup.BoringX509LookupHandle get_Handle() { }

	// RVA: 0x1DD2B10 Offset: 0x1DD1110 VA: 0x181DD2B10
	private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	// RVA: 0x1DD2960 Offset: 0x1DD0F60 VA: 0x181DD2960
	private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1DD2A00 Offset: 0x1DD1000 VA: 0x181DD2A00
	private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	// RVA: 0x1DD2A90 Offset: 0x1DD1090 VA: 0x181DD2A90
	private static extern void mono_btls_x509_lookup_free(IntPtr handle) { }

	// RVA: 0x1DD2BA0 Offset: 0x1DD11A0 VA: 0x181DD2BA0
	private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

	// RVA: 0x1DD25A0 Offset: 0x1DD0BA0 VA: 0x181DD25A0
	private static MonoBtlsX509Lookup.BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x1DD2770 Offset: 0x1DD0D70 VA: 0x181DD2770
	internal void .ctor(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x1DD26D0 Offset: 0x1DD0CD0 VA: 0x181DD26D0
	internal IntPtr GetNativeLookup() { }

	// RVA: 0x1DD1FD0 Offset: 0x1DD05D0 VA: 0x181DD1FD0
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1DD2190 Offset: 0x1DD0790 VA: 0x181DD2190
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	// RVA: 0x1DD1EC0 Offset: 0x1DD04C0 VA: 0x181DD1EC0
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x1DD2410 Offset: 0x1DD0A10 VA: 0x181DD2410 Slot: 5
	protected override void Close() { }
}

// Namespace: Mono.Btls
internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject // TypeDefIndex: 7374
{
	// Fields
	private GCHandle gch; // 0x20
	private IntPtr instance; // 0x28
	private MonoBtlsX509LookupMono.BySubjectFunc bySubjectFunc; // 0x30
	private IntPtr bySubjectFuncPtr; // 0x38
	private MonoBtlsX509Lookup lookup; // 0x40

	// Properties
	internal MonoBtlsX509LookupMono.BoringX509LookupMonoHandle Handle { get; }

	// Methods

	// RVA: 0x1DD1CB0 Offset: 0x1DD02B0 VA: 0x181DD1CB0
	internal MonoBtlsX509LookupMono.BoringX509LookupMonoHandle get_Handle() { }

	// RVA: 0x1DD1E50 Offset: 0x1DD0450 VA: 0x181DD1E50
	private static extern IntPtr mono_btls_x509_lookup_mono_new() { }

	// RVA: 0x1DD1DB0 Offset: 0x1DD03B0 VA: 0x181DD1DB0
	private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	// RVA: 0x1DD1D30 Offset: 0x1DD0330 VA: 0x181DD1D30
	private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	// RVA: 0x1DD1A20 Offset: 0x1DD0020 VA: 0x181DD1A20
	internal void .ctor() { }

	// RVA: 0x1DD1730 Offset: 0x1DCFD30 VA: 0x181DD1730
	internal void Install(MonoBtlsX509Lookup lookup) { }

	// RVA: 0x1DD1550 Offset: 0x1DCFB50 VA: 0x181DD1550
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name);

	[MonoPInvokeCallback(typeof(MonoBtlsX509LookupMono.BySubjectFunc))]
	// RVA: 0x1DD1790 Offset: 0x1DCFD90 VA: 0x181DD1790
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr) { }

	// RVA: 0x1DD1670 Offset: 0x1DCFC70 VA: 0x181DD1670 Slot: 5
	protected override void Close() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono // TypeDefIndex: 7375
{
	// Fields
	private long[] hashes; // 0x48
	private MonoBtlsX509[] certificates; // 0x50
	private X509CertificateCollection collection; // 0x58
	private MonoBtlsX509TrustKind trust; // 0x60

	// Methods

	// RVA: 0x1DD1500 Offset: 0x1DCFB00 VA: 0x181DD1500
	internal void .ctor(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x1DD10D0 Offset: 0x1DCF6D0 VA: 0x181DD10D0
	private void Initialize() { }

	// RVA: 0x1DD1440 Offset: 0x1DCFA40 VA: 0x181DD1440 Slot: 6
	protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x1DD0F80 Offset: 0x1DCF580 VA: 0x181DD0F80 Slot: 5
	protected override void Close() { }
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509LookupType // TypeDefIndex: 7376
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509LookupType UNKNOWN = 0;
	public const MonoBtlsX509LookupType FILE = 1;
	public const MonoBtlsX509LookupType HASH_DIR = 2;
	public const MonoBtlsX509LookupType MONO = 3;
}

// Namespace: Mono.Btls
internal class MonoBtlsX509Name : MonoBtlsObject // TypeDefIndex: 7378
{
	// Properties
	internal MonoBtlsX509Name.BoringX509NameHandle Handle { get; }

	// Methods

	// RVA: 0x1DD3A20 Offset: 0x1DD2020 VA: 0x181DD3A20
	private static extern long mono_btls_x509_name_hash(IntPtr handle) { }

	// RVA: 0x1DD3730 Offset: 0x1DD1D30 VA: 0x181DD3730
	private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	// RVA: 0x1DD38F0 Offset: 0x1DD1EF0 VA: 0x181DD38F0
	private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	// RVA: 0x1DD3850 Offset: 0x1DD1E50 VA: 0x181DD3850
	private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	// RVA: 0x1DD37B0 Offset: 0x1DD1DB0 VA: 0x181DD37B0
	private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data) { }

	// RVA: 0x1DD3980 Offset: 0x1DD1F80 VA: 0x181DD3980
	private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str) { }

	// RVA: 0x1DD3690 Offset: 0x1DD1C90 VA: 0x181DD3690
	private static extern IntPtr mono_btls_x509_name_from_data(void* data, int len, int use_canon_enc) { }

	// RVA: 0x1DD3610 Offset: 0x1DD1C10 VA: 0x181DD3610
	private static extern void mono_btls_x509_name_free(IntPtr handle) { }

	// RVA: 0x1DD3590 Offset: 0x1DD1B90 VA: 0x181DD3590
	internal MonoBtlsX509Name.BoringX509NameHandle get_Handle() { }

	// RVA: 0x1CDFC90 Offset: 0x1CDE290 VA: 0x181CDFC90
	internal void .ctor(MonoBtlsX509Name.BoringX509NameHandle handle) { }

	// RVA: 0x1DD34F0 Offset: 0x1DD1AF0 VA: 0x181DD34F0
	public long GetHash() { }

	// RVA: 0x1DD2DB0 Offset: 0x1DD13B0 VA: 0x181DD2DB0
	public int GetEntryCount() { }

	// RVA: 0x1DD31F0 Offset: 0x1DD17F0 VA: 0x181DD31F0
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	// RVA: 0x1DD2FB0 Offset: 0x1DD15B0 VA: 0x181DD2FB0
	public string GetEntryOid(int index) { }

	// RVA: 0x1DD2E50 Offset: 0x1DD1450 VA: 0x181DD2E50
	public byte[] GetEntryOidData(int index) { }

	// RVA: 0x1DD32E0 Offset: 0x1DD18E0 VA: 0x181DD32E0
	public string GetEntryValue(int index, out int tag) { }

	// RVA: 0x1DD2C20 Offset: 0x1DD1220 VA: 0x181DD2C20
	public static MonoBtlsX509Name CreateFromData(byte[] data, bool use_canon_enc) { }
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509NameEntryType // TypeDefIndex: 7379
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509NameEntryType Unknown = 0;
	public const MonoBtlsX509NameEntryType CountryName = 1;
	public const MonoBtlsX509NameEntryType OrganizationName = 2;
	public const MonoBtlsX509NameEntryType OrganizationalUnitName = 3;
	public const MonoBtlsX509NameEntryType CommonName = 4;
	public const MonoBtlsX509NameEntryType LocalityName = 5;
	public const MonoBtlsX509NameEntryType StateOrProvinceName = 6;
	public const MonoBtlsX509NameEntryType StreetAddress = 7;
	public const MonoBtlsX509NameEntryType SerialNumber = 8;
	public const MonoBtlsX509NameEntryType DomainComponent = 9;
	public const MonoBtlsX509NameEntryType UserId = 10;
	public const MonoBtlsX509NameEntryType Email = 11;
	public const MonoBtlsX509NameEntryType DnQualifier = 12;
	public const MonoBtlsX509NameEntryType Title = 13;
	public const MonoBtlsX509NameEntryType Surname = 14;
	public const MonoBtlsX509NameEntryType GivenName = 15;
	public const MonoBtlsX509NameEntryType Initial = 16;
}

// Namespace: Mono.Btls
internal class MonoBtlsX509Store : MonoBtlsObject // TypeDefIndex: 7381
{
	// Fields
	private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash; // 0x20

	// Properties
	internal MonoBtlsX509Store.BoringX509StoreHandle Handle { get; }

	// Methods

	// RVA: 0x1DD5DD0 Offset: 0x1DD43D0 VA: 0x181DD5DD0
	internal MonoBtlsX509Store.BoringX509StoreHandle get_Handle() { }

	// RVA: 0x1DD5FE0 Offset: 0x1DD45E0 VA: 0x181DD5FE0
	private static extern IntPtr mono_btls_x509_store_new() { }

	// RVA: 0x1DD5F60 Offset: 0x1DD4560 VA: 0x181DD5F60
	private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	// RVA: 0x1DD5E50 Offset: 0x1DD4450 VA: 0x181DD5E50
	private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1DD5EE0 Offset: 0x1DD44E0 VA: 0x181DD5EE0
	private static extern void mono_btls_x509_store_free(IntPtr handle) { }

	// RVA: 0x1DD5A90 Offset: 0x1DD4090 VA: 0x181DD5A90
	private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal() { }

	// RVA: 0x1DD5970 Offset: 0x1DD3F70 VA: 0x181DD5970
	private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal(MonoBtlsSslCtx.BoringSslCtxHandle ctx) { }

	// RVA: 0x1DD5B90 Offset: 0x1DD4190 VA: 0x181DD5B90
	internal void .ctor() { }

	// RVA: 0x1DD5CA0 Offset: 0x1DD42A0 VA: 0x181DD5CA0
	internal void .ctor(MonoBtlsSslCtx.BoringSslCtxHandle ctx) { }

	// RVA: 0x1DD5210 Offset: 0x1DD3810 VA: 0x181DD5210
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1DD55D0 Offset: 0x1DD3BD0 VA: 0x181DD55D0
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	// RVA: 0x1DD53D0 Offset: 0x1DD39D0 VA: 0x181DD53D0
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1DD5310 Offset: 0x1DD3910 VA: 0x181DD5310
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x1DD57B0 Offset: 0x1DD3DB0 VA: 0x181DD57B0 Slot: 5
	protected override void Close() { }
}

// Namespace: Mono.Btls
internal class MonoBtlsX509StoreCtx : MonoBtlsObject // TypeDefIndex: 7383
{
	// Fields
	private Nullable<int> verifyResult; // 0x20

	// Properties
	internal MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Handle { get; }
	public int VerifyResult { get; }

	// Methods

	// RVA: 0x1DD45C0 Offset: 0x1DD2BC0 VA: 0x181DD45C0
	internal MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle get_Handle() { }

	// RVA: 0x1DD4A00 Offset: 0x1DD3000 VA: 0x181DD4A00
	private static extern IntPtr mono_btls_x509_store_ctx_new() { }

	// RVA: 0x1DD4750 Offset: 0x1DD2D50 VA: 0x181DD4750
	private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	// RVA: 0x1DD4850 Offset: 0x1DD2E50 VA: 0x181DD4850
	private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string) { }

	// RVA: 0x1DD47D0 Offset: 0x1DD2DD0 VA: 0x181DD47D0
	private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	// RVA: 0x1DD4960 Offset: 0x1DD2F60 VA: 0x181DD4960
	private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	// RVA: 0x1DD4A70 Offset: 0x1DD3070 VA: 0x181DD4A70
	private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x1DD4B80 Offset: 0x1DD3180 VA: 0x181DD4B80
	private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	// RVA: 0x1DD48E0 Offset: 0x1DD2EE0 VA: 0x181DD48E0
	private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	// RVA: 0x1DD4B00 Offset: 0x1DD3100 VA: 0x181DD4B00
	private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	// RVA: 0x1DD46D0 Offset: 0x1DD2CD0 VA: 0x181DD46D0
	private static extern void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	// RVA: 0x1DD44C0 Offset: 0x1DD2AC0 VA: 0x181DD44C0
	internal void .ctor() { }

	// RVA: 0x1DD3BF0 Offset: 0x1DD21F0 VA: 0x181DD3BF0
	private static MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	// RVA: 0x1DD4350 Offset: 0x1DD2950 VA: 0x181DD4350
	internal void .ctor(int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x1DD4590 Offset: 0x1DD2B90 VA: 0x181DD4590
	internal void .ctor(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle ptr, Nullable<int> verifyResult) { }

	// RVA: 0x1DD3E30 Offset: 0x1DD2430 VA: 0x181DD3E30
	public MonoBtlsX509Error GetError() { }

	// RVA: 0x1DD3D00 Offset: 0x1DD2300 VA: 0x181DD3D00
	public MonoBtlsX509Chain GetChain() { }

	// RVA: 0x1DD3EE0 Offset: 0x1DD24E0 VA: 0x181DD3EE0
	public MonoBtlsX509Chain GetUntrusted() { }

	// RVA: 0x1DD4010 Offset: 0x1DD2610 VA: 0x181DD4010
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	// RVA: 0x1DD4150 Offset: 0x1DD2750 VA: 0x181DD4150
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x1DD4640 Offset: 0x1DD2C40 VA: 0x181DD4640
	public int get_VerifyResult() { }

	// RVA: 0x1DD4250 Offset: 0x1DD2850 VA: 0x181DD4250
	public int Verify() { }

	// RVA: 0x1DD3AA0 Offset: 0x1DD20A0 VA: 0x181DD3AA0
	public MonoBtlsX509StoreCtx Copy() { }
}

// Namespace: Mono.Btls
internal static class MonoBtlsX509StoreManager // TypeDefIndex: 7384
{
	// Fields
	private static bool initialized; // 0x0
	private static string machineTrustedRootPath; // 0x8
	private static string machineIntermediateCAPath; // 0x10
	private static string machineUntrustedPath; // 0x18
	private static string userTrustedRootPath; // 0x20
	private static string userIntermediateCAPath; // 0x28
	private static string userUntrustedPath; // 0x30

	// Methods

	// RVA: 0x1DD4F30 Offset: 0x1DD3530 VA: 0x181DD4F30
	private static void Initialize() { }

	// RVA: 0x1DD4C00 Offset: 0x1DD3200 VA: 0x181DD4C00
	private static void DoInitialize() { }

	// RVA: 0x1DD4E00 Offset: 0x1DD3400 VA: 0x181DD4E00
	public static string GetStorePath(MonoBtlsX509StoreType type) { }
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509StoreType // TypeDefIndex: 7385
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509StoreType Custom = 0;
	public const MonoBtlsX509StoreType MachineTrustedRoots = 1;
	public const MonoBtlsX509StoreType MachineIntermediateCA = 2;
	public const MonoBtlsX509StoreType MachineUntrusted = 3;
	public const MonoBtlsX509StoreType UserTrustedRoots = 4;
	public const MonoBtlsX509StoreType UserIntermediateCA = 5;
	public const MonoBtlsX509StoreType UserUntrusted = 6;
}

// Namespace: Mono.Btls
[Flags]
internal enum MonoBtlsX509TrustKind // TypeDefIndex: 7386
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509TrustKind DEFAULT = 0;
	public const MonoBtlsX509TrustKind TRUST_CLIENT = 1;
	public const MonoBtlsX509TrustKind TRUST_SERVER = 2;
	public const MonoBtlsX509TrustKind TRUST_ALL = 4;
	public const MonoBtlsX509TrustKind REJECT_CLIENT = 32;
	public const MonoBtlsX509TrustKind REJECT_SERVER = 64;
	public const MonoBtlsX509TrustKind REJECT_ALL = 128;
}

// Namespace: Mono.Btls
internal class MonoBtlsX509VerifyParam : MonoBtlsObject // TypeDefIndex: 7388
{
	// Properties
	internal MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle Handle { get; }
	public bool CanModify { get; }

	// Methods

	// RVA: 0x1DD69D0 Offset: 0x1DD4FD0 VA: 0x181DD69D0
	internal MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle get_Handle() { }

	// RVA: 0x1DD6AD0 Offset: 0x1DD50D0 VA: 0x181DD6AD0
	private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	// RVA: 0x1DD6BD0 Offset: 0x1DD51D0 VA: 0x181DD6BD0
	private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	// RVA: 0x1DD6A50 Offset: 0x1DD5050 VA: 0x181DD6A50
	private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	// RVA: 0x1DD6C50 Offset: 0x1DD5250 VA: 0x181DD6C50
	private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	// RVA: 0x1DD6CF0 Offset: 0x1DD52F0 VA: 0x181DD6CF0
	private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, long time) { }

	// RVA: 0x1DD6B50 Offset: 0x1DD5150 VA: 0x181DD6B50
	private static extern void mono_btls_x509_verify_param_free(IntPtr handle) { }

	// RVA: 0x1CDFC90 Offset: 0x1CDE290 VA: 0x181CDFC90
	internal void .ctor(MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle handle) { }

	// RVA: 0x1DD6050 Offset: 0x1DD4650 VA: 0x181DD6050
	public MonoBtlsX509VerifyParam Copy() { }

	// RVA: 0x1DD6180 Offset: 0x1DD4780 VA: 0x181DD6180
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	// RVA: 0x1DD61C0 Offset: 0x1DD47C0 VA: 0x181DD61C0
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	// RVA: 0x1DD6200 Offset: 0x1DD4800 VA: 0x181DD6200
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = False) { }

	// RVA: 0x1DD6930 Offset: 0x1DD4F30 VA: 0x181DD6930
	public bool get_CanModify() { }

	// RVA: 0x1DD6840 Offset: 0x1DD4E40 VA: 0x181DD6840
	private void WantToModify() { }

	// RVA: 0x1DD64A0 Offset: 0x1DD4AA0 VA: 0x181DD64A0
	public void SetHost(string name) { }

	// RVA: 0x1DD6680 Offset: 0x1DD4C80 VA: 0x181DD6680
	public void SetTime(DateTime time) { }
}

// Namespace: Mono.Btls
internal class X509CertificateImplBtls : X509Certificate2ImplUnix // TypeDefIndex: 7389
{
	// Fields
	private MonoBtlsX509 x509; // 0xB0
	private MonoBtlsKey nativePrivateKey; // 0xB8
	private X509CertificateImplCollection intermediateCerts; // 0xC0

	// Properties
	public override bool IsValid { get; }
	internal MonoBtlsX509 X509 { get; }
	internal MonoBtlsKey NativePrivateKey { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	public override bool HasPrivateKey { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }

	// Methods

	// RVA: 0x1DE02C0 Offset: 0x1DDE8C0 VA: 0x181DE02C0
	internal void .ctor(MonoBtlsX509 x509) { }

	// RVA: 0x1DE0310 Offset: 0x1DDE910 VA: 0x181DE0310
	private void .ctor(X509CertificateImplBtls other) { }

	// RVA: 0x1DE03F0 Offset: 0x1DDE9F0 VA: 0x181DE03F0
	internal void .ctor(byte[] data, MonoBtlsX509Format format) { }

	// RVA: 0x1DE0450 Offset: 0x1DDEA50 VA: 0x181DE0450
	internal void .ctor(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1DE06D0 Offset: 0x1DDECD0 VA: 0x181DE06D0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1DE0710 Offset: 0x1DDED10 VA: 0x181DE0710
	internal MonoBtlsX509 get_X509() { }

	// RVA: 0x1DE06F0 Offset: 0x1DDECF0 VA: 0x181DE06F0
	internal MonoBtlsKey get_NativePrivateKey() { }

	// RVA: 0x1DDF7F0 Offset: 0x1DDDDF0 VA: 0x181DDF7F0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x1DDF9D0 Offset: 0x1DDDFD0 VA: 0x181DDF9D0 Slot: 33
	protected override byte[] GetRawCertData() { }

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670 Slot: 29
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x1DDF900 Offset: 0x1DDDF00 VA: 0x181DDF900 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C51180 Offset: 0x1C4F780 VA: 0x181C51180 Slot: 17
	public override bool get_HasPrivateKey() { }

	// RVA: 0x1DDF990 Offset: 0x1DDDF90 VA: 0x181DDF990 Slot: 24
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1DE0730 Offset: 0x1DDED30 VA: 0x181DE0730 Slot: 25
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x1DDF990 Offset: 0x1DDDF90 VA: 0x181DDF990 Slot: 18
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x1DDF950 Offset: 0x1DDDF50 VA: 0x181DDF950 Slot: 19
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x1DDFF80 Offset: 0x1DDE580 VA: 0x181DDFF80
	private void Import(byte[] data) { }

	// RVA: 0x1DDFAF0 Offset: 0x1DDE0F0 VA: 0x181DDFAF0
	private void ImportPkcs12(byte[] data, SafePasswordHandle password) { }

	// RVA: 0x1DDFA10 Offset: 0x1DDE010 VA: 0x181DDFA10
	private void ImportAuthenticode(byte[] data) { }

	// RVA: 0x1DDFFE0 Offset: 0x1DDE5E0 VA: 0x181DDFFE0 Slot: 31
	public override bool Verify(X509Certificate2 thisCertificate) { }
}

// Namespace: Mono.Btls
internal class X509ChainImplBtls : X509ChainImpl // TypeDefIndex: 7390
{
	// Fields
	private MonoBtlsX509StoreCtx storeCtx; // 0x10
	private MonoBtlsX509Chain chain; // 0x18
	private MonoBtlsX509Chain untrustedChain; // 0x20
	private X509ChainElementCollection elements; // 0x28
	private X509Certificate2Collection untrusted; // 0x30
	private X509Certificate2[] certificates; // 0x38
	private X509ChainPolicy policy; // 0x40
	private List<X509ChainStatus> chainStatusList; // 0x48

	// Properties
	public override bool IsValid { get; }
	internal MonoBtlsX509StoreCtx StoreCtx { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: 0x1DE1100 Offset: 0x1DDF700 VA: 0x181DE1100
	internal void .ctor(MonoBtlsX509Chain chain) { }

	// RVA: 0x1DE0B60 Offset: 0x1DDF160 VA: 0x181DE0B60
	internal void .ctor(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x1DE1550 Offset: 0x1DDFB50 VA: 0x181DE1550 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1DE1570 Offset: 0x1DDFB70 VA: 0x181DE1570
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	// RVA: 0x1DE12A0 Offset: 0x1DDF8A0 VA: 0x181DE12A0 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x1DE0810 Offset: 0x1DDEE10 VA: 0x181DE0810 Slot: 9
	public override void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1DE0AC0 Offset: 0x1DDF0C0 VA: 0x181DE0AC0 Slot: 10
	public override void Reset() { }

	// RVA: 0x1DE0950 Offset: 0x1DDEF50 VA: 0x181DE0950 Slot: 11
	protected override void Dispose(bool disposing) { }
}

// Namespace: Mono.Btls
internal class X509PalImplBtls : X509PalImpl // TypeDefIndex: 7391
{
	// Fields
	[CompilerGenerated]
	private readonly MonoBtlsProvider <Provider>k__BackingField; // 0x10

	// Properties
	private MonoBtlsProvider Provider { get; }

	// Methods

	// RVA: 0x1DE1610 Offset: 0x1DDFC10 VA: 0x181DE1610
	public void .ctor(MonoTlsProvider provider) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	private MonoBtlsProvider get_Provider() { }

	// RVA: 0x1DE15E0 Offset: 0x1DDFBE0 VA: 0x181DE15E0 Slot: 4
	public override X509CertificateImpl Import(byte[] data) { }

	// RVA: 0x1DE1590 Offset: 0x1DDFB90 VA: 0x181DE1590 Slot: 5
	public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1DE15C0 Offset: 0x1DDFBC0 VA: 0x181DE15C0 Slot: 6
	public override X509Certificate2Impl Import(X509Certificate cert) { }
}

