// Namespace: System.Net.Security
public class SslClientAuthenticationOptions // TypeDefIndex: 7967
{
	// Fields
	private EncryptionPolicy _encryptionPolicy; // 0x10
	private X509RevocationMode _checkCertificateRevocation; // 0x14
	private SslProtocols _enabledSslProtocols; // 0x18
	private bool _allowRenegotiation; // 0x1C
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x28

	// Properties
	public bool AllowRenegotiation { get; }
	public string TargetHost { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public X509RevocationMode CertificateRevocationCheckMode { set; }
	public EncryptionPolicy EncryptionPolicy { set; }
	public SslProtocols EnabledSslProtocols { get; set; }

	// Methods

	// RVA: 0x39A900 Offset: 0x398F00 VA: 0x18039A900
	public bool get_AllowRenegotiation() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_TargetHost(string value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x1DBE120 Offset: 0x1DBC720 VA: 0x181DBE120
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x1DBE1C0 Offset: 0x1DBC7C0 VA: 0x181DBE1C0
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x1DBE110 Offset: 0x1DBC710 VA: 0x181DBE110
	public void .ctor() { }
}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream : Stream // TypeDefIndex: 7968
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0x1DACA40 Offset: 0x1DAB040 VA: 0x181DACA40
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	protected Stream get_InnerStream() { }

	// RVA: 0x1DAC970 Offset: 0x1DAAF70 VA: 0x181DAC970 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract bool get_IsAuthenticated();
}

// Namespace: System.Net.Security
public enum AuthenticationLevel // TypeDefIndex: 7969
{
	// Fields
	public int value__; // 0x0
	public const AuthenticationLevel None = 0;
	public const AuthenticationLevel MutualAuthRequested = 1;
	public const AuthenticationLevel MutualAuthRequired = 2;
}

// Namespace: System.Net.Security
public enum EncryptionPolicy // TypeDefIndex: 7970
{
	// Fields
	public int value__; // 0x0
	public const EncryptionPolicy RequireEncryption = 0;
	public const EncryptionPolicy AllowNoEncryption = 1;
	public const EncryptionPolicy NoEncryption = 2;
}

// Namespace: System.Net.Security
public sealed class LocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 7971
{
	// Methods

	// RVA: 0x1DAE240 Offset: 0x1DAC840 VA: 0x181DAE240
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D7AF0 Offset: 0x5D60F0 VA: 0x1805D7AF0 Slot: 13
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 7972
{
	// Methods

	// RVA: 0x1DB16B0 Offset: 0x1DAFCB0 VA: 0x181DB16B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x39D730 Offset: 0x39BD30 VA: 0x18039D730 Slot: 13
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

// Namespace: System.Net.Security
[Flags]
public enum SslPolicyErrors // TypeDefIndex: 7973
{
	// Fields
	public int value__; // 0x0
	public const SslPolicyErrors None = 0;
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const SslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 7974
{
	// Methods

	// RVA: 0x132DCE0 Offset: 0x132C2E0 VA: 0x18132DCE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x39D730 Offset: 0x39BD30 VA: 0x18039D730 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback : MulticastDelegate // TypeDefIndex: 7975
{
	// Methods

	// RVA: 0xA825C0 Offset: 0xA80BC0 VA: 0x180A825C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950 Slot: 13
	public virtual X509Certificate Invoke(string hostName) { }
}

// Namespace: System.Net.Security
public class SslStream : AuthenticatedStream // TypeDefIndex: 7977
{
	// Fields
	private MobileTlsProvider provider; // 0x38
	private MonoTlsSettings settings; // 0x40
	private RemoteCertificateValidationCallback validationCallback; // 0x48
	private LocalCertificateSelectionCallback selectionCallback; // 0x50
	private MobileAuthenticatedStream impl; // 0x58
	private bool explicitSettings; // 0x60

	// Properties
	internal MobileAuthenticatedStream Impl { get; }
	internal string InternalTargetHost { get; }
	public override bool IsAuthenticated { get; }
	public virtual X509Certificate LocalCertificate { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1DBF040 Offset: 0x1DBD640 VA: 0x181DBF040
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x1DBF0B0 Offset: 0x1DBD6B0 VA: 0x181DBF0B0
	internal string get_InternalTargetHost() { }

	// RVA: 0x1DBE6B0 Offset: 0x1DBCCB0 VA: 0x181DBE6B0
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x1DBED90 Offset: 0x1DBD390 VA: 0x181DBED90
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x1DBEDB0 Offset: 0x1DBD3B0 VA: 0x181DBEDB0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x1DBEC20 Offset: 0x1DBD220 VA: 0x181DBEC20
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1DBEA30 Offset: 0x1DBD030 VA: 0x181DBEA30
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x1DBE880 Offset: 0x1DBCE80 VA: 0x181DBE880
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x1DBE2E0 Offset: 0x1DBC8E0 VA: 0x181DBE2E0 Slot: 38
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1DBE360 Offset: 0x1DBC960 VA: 0x181DBE360 Slot: 39
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x137FA70 Offset: 0x137E070 VA: 0x18137FA70 Slot: 40
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1DBE260 Offset: 0x1DBC860 VA: 0x181DBE260 Slot: 41
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1DBF120 Offset: 0x1DBD720 VA: 0x181DBF120 Slot: 37
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1DBF220 Offset: 0x1DBD820 VA: 0x181DBF220 Slot: 42
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1DBEFE0 Offset: 0x1DBD5E0 VA: 0x181DBEFE0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1A77850 Offset: 0x1A75E50 VA: 0x181A77850 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1DBF010 Offset: 0x1DBD610 VA: 0x181DBF010 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1DBF310 Offset: 0x1DBD910 VA: 0x181DBF310 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1DBF470 Offset: 0x1DBDA70 VA: 0x181DBF470 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1DBF4F0 Offset: 0x1DBDAF0 VA: 0x181DBF4F0 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1DBF1A0 Offset: 0x1DBD7A0 VA: 0x181DBF1A0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1DBF290 Offset: 0x1DBD890 VA: 0x181DBF290 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1DBF410 Offset: 0x1DBDA10 VA: 0x181DBF410 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1DBE820 Offset: 0x1DBCE20 VA: 0x181DBE820 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1DBE680 Offset: 0x1DBCC80 VA: 0x181DBE680 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1A75CD0 Offset: 0x1A742D0 VA: 0x181A75CD0 Slot: 20
	public override void Flush() { }

	// RVA: 0x1DBE520 Offset: 0x1DBCB20 VA: 0x181DBE520
	private void CheckDisposed() { }

	// RVA: 0x1DBE590 Offset: 0x1DBCB90 VA: 0x181DBE590 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1DBE7A0 Offset: 0x1DBCDA0 VA: 0x181DBE7A0 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1DBE720 Offset: 0x1DBCD20 VA: 0x181DBE720 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1DBEB20 Offset: 0x1DBD120 VA: 0x181DBEB20 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1DBE400 Offset: 0x1DBCA00 VA: 0x181DBE400 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1DBE640 Offset: 0x1DBCC40 VA: 0x181DBE640 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1DBE490 Offset: 0x1DBCA90 VA: 0x181DBE490 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x137FA70 Offset: 0x137E070 VA: 0x18137FA70 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }
}

