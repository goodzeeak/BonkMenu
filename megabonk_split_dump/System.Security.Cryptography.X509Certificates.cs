// Namespace: System.Security.Cryptography.X509Certificates
public enum X509ContentType // TypeDefIndex: 809
{
	// Fields
	public int value__; // 0x0
	public const X509ContentType Unknown = 0;
	public const X509ContentType Cert = 1;
	public const X509ContentType SerializedCert = 2;
	public const X509ContentType Pfx = 3;
	public const X509ContentType Pkcs12 = 3;
	public const X509ContentType SerializedStore = 4;
	public const X509ContentType Pkcs7 = 5;
	public const X509ContentType Authenticode = 6;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509KeyStorageFlags // TypeDefIndex: 810
{
	// Fields
	public int value__; // 0x0
	public const X509KeyStorageFlags DefaultKeySet = 0;
	public const X509KeyStorageFlags UserKeySet = 1;
	public const X509KeyStorageFlags MachineKeySet = 2;
	public const X509KeyStorageFlags Exportable = 4;
	public const X509KeyStorageFlags UserProtected = 8;
	public const X509KeyStorageFlags PersistKeySet = 16;
	public const X509KeyStorageFlags EphemeralKeySet = 32;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable // TypeDefIndex: 811
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private byte[] lazyCertHash; // 0x18
	private byte[] lazySerialNumber; // 0x20
	private string lazyIssuer; // 0x28
	private string lazySubject; // 0x30
	private string lazyKeyAlgorithm; // 0x38
	private byte[] lazyKeyAlgorithmParameters; // 0x40
	private byte[] lazyPublicKey; // 0x48
	private DateTime lazyNotBefore; // 0x50
	private DateTime lazyNotAfter; // 0x58

	// Properties
	public string Issuer { get; }
	public string Subject { get; }
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }

	// Methods

	// RVA: 0x13D6EB0 Offset: 0x13D54B0 VA: 0x1813D6EB0 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x13D7A00 Offset: 0x13D6000 VA: 0x1813D7A00
	public void .ctor() { }

	// RVA: 0x13D7B40 Offset: 0x13D6140 VA: 0x1813D7B40
	public void .ctor(byte[] data) { }

	// RVA: 0x13D79E0 Offset: 0x13D5FE0 VA: 0x1813D79E0
	public void .ctor(byte[] rawData, string password) { }

	// RVA: 0x13D7CA0 Offset: 0x13D62A0 VA: 0x1813D7CA0
	public void .ctor(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x13D7A80 Offset: 0x13D6080 VA: 0x1813D7A80
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x13D77E0 Offset: 0x13D5DE0 VA: 0x1813D77E0
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x13D7990 Offset: 0x13D5F90 VA: 0x1813D7990
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13D7070 Offset: 0x13D5670 VA: 0x1813D7070 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13D7030 Offset: 0x13D5630 VA: 0x1813D7030 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x13D8050 Offset: 0x13D6650 VA: 0x1813D8050
	public string get_Issuer() { }

	// RVA: 0x13D8100 Offset: 0x13D6700 VA: 0x1813D8100
	public string get_Subject() { }

	// RVA: 0x13D6060 Offset: 0x13D4660 VA: 0x1813D6060 Slot: 4
	public void Dispose() { }

	// RVA: 0x13D6080 Offset: 0x13D4680 VA: 0x1813D6080 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x13D61A0 Offset: 0x13D47A0 VA: 0x1813D61A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13D60A0 Offset: 0x13D46A0 VA: 0x1813D60A0 Slot: 9
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x13D6230 Offset: 0x13D4830 VA: 0x1813D6230 Slot: 10
	public virtual byte[] Export(X509ContentType contentType, string password) { }

	// RVA: 0x13D6610 Offset: 0x13D4C10 VA: 0x1813D6610 Slot: 11
	public virtual byte[] GetCertHash() { }

	// RVA: 0x13D6560 Offset: 0x13D4B60 VA: 0x1813D6560 Slot: 12
	public virtual string GetCertHashString() { }

	// RVA: 0x13D6BF0 Offset: 0x13D51F0 VA: 0x1813D6BF0
	private byte[] GetRawCertHash() { }

	// RVA: 0x13D6B70 Offset: 0x13D5170 VA: 0x1813D6B70 Slot: 13
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x13D66C0 Offset: 0x13D4CC0 VA: 0x1813D66C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13D6830 Offset: 0x13D4E30 VA: 0x1813D6830 Slot: 14
	public virtual string GetKeyAlgorithm() { }

	// RVA: 0x13D6780 Offset: 0x13D4D80 VA: 0x1813D6780 Slot: 15
	public virtual byte[] GetKeyAlgorithmParameters() { }

	// RVA: 0x13D6AC0 Offset: 0x13D50C0 VA: 0x1813D6AC0 Slot: 16
	public virtual byte[] GetPublicKey() { }

	// RVA: 0x13D6D80 Offset: 0x13D5380 VA: 0x1813D6D80 Slot: 17
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x13D6CD0 Offset: 0x13D52D0 VA: 0x1813D6CD0 Slot: 18
	public virtual string GetSerialNumberString() { }

	// RVA: 0x13D6C60 Offset: 0x13D5260 VA: 0x1813D6C60
	private byte[] GetRawSerialNumber() { }

	// RVA: 0x13D7110 Offset: 0x13D5710 VA: 0x1813D7110 Slot: 3
	public override string ToString() { }

	// RVA: 0x13D7130 Offset: 0x13D5730 VA: 0x1813D7130 Slot: 19
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x13D68E0 Offset: 0x13D4EE0 VA: 0x1813D68E0
	internal DateTime GetNotAfter() { }

	// RVA: 0x13D69D0 Offset: 0x13D4FD0 VA: 0x1813D69D0
	internal DateTime GetNotBefore() { }

	// RVA: 0x13D63F0 Offset: 0x13D49F0 VA: 0x1813D63F0
	protected static string FormatDate(DateTime date) { }

	// RVA: 0x13D7650 Offset: 0x13D5C50 VA: 0x1813D7650
	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x13D7770 Offset: 0x13D5D70 VA: 0x1813D7770
	private void VerifyContentType(X509ContentType contentType) { }

	// RVA: 0x13D6E70 Offset: 0x13D5470 VA: 0x1813D6E70
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x13D8030 Offset: 0x13D6630 VA: 0x1813D8030
	internal bool get_IsValid() { }

	// RVA: 0x13D70B0 Offset: 0x13D56B0 VA: 0x1813D70B0
	internal void ThrowIfInvalid() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 812
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract string Issuer { get; }
	public abstract string Subject { get; }
	public abstract byte[] RawData { get; }
	public abstract DateTime NotAfter { get; }
	public abstract DateTime NotBefore { get; }
	public abstract byte[] Thumbprint { get; }
	public abstract string KeyAlgorithm { get; }
	public abstract byte[] KeyAlgorithmParameters { get; }
	public abstract byte[] PublicKeyValue { get; }
	public abstract byte[] SerialNumber { get; }
	public abstract bool HasPrivateKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x13D6010 Offset: 0x13D4610 VA: 0x1813D6010
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Issuer();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Subject();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] get_RawData();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime get_NotAfter();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime get_NotBefore();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract byte[] get_Thumbprint();

	// RVA: 0x13D5F70 Offset: 0x13D4570 VA: 0x1813D5F70 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_KeyAlgorithm();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] get_KeyAlgorithmParameters();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract byte[] get_PublicKeyValue();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract byte[] get_SerialNumber();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_HasPrivateKey();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract RSA GetRSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract DSA GetDSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract byte[] Export(X509ContentType contentType, SafePasswordHandle password);

	// RVA: 0x13D5D50 Offset: 0x13D4350 VA: 0x1813D5D50 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x13D5CF0 Offset: 0x13D42F0 VA: 0x1813D5CF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x13D5F00 Offset: 0x13D4500 VA: 0x1813D5F00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper // TypeDefIndex: 813
{
	// Properties
	private static ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: 0x13D8550 Offset: 0x13D6B50 VA: 0x1813D8550
	private static ISystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x13D83F0 Offset: 0x13D69F0 VA: 0x1813D83F0
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x13D84C0 Offset: 0x13D6AC0 VA: 0x1813D84C0
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x13D84E0 Offset: 0x13D6AE0 VA: 0x1813D84E0
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x13D8500 Offset: 0x13D6B00 VA: 0x1813D8500
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x13D81B0 Offset: 0x13D67B0 VA: 0x1813D81B0
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x13D8330 Offset: 0x13D6930 VA: 0x1813D8330
	public static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x13D8220 Offset: 0x13D6820 VA: 0x1813D8220
	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum OpenFlags // TypeDefIndex: 7511
{
	// Fields
	public int value__; // 0x0
	public const OpenFlags ReadOnly = 0;
	public const OpenFlags ReadWrite = 1;
	public const OpenFlags MaxAllowed = 2;
	public const OpenFlags OpenExistingOnly = 4;
	public const OpenFlags IncludeArchived = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreLocation // TypeDefIndex: 7512
{
	// Fields
	public int value__; // 0x0
	public const StoreLocation CurrentUser = 1;
	public const StoreLocation LocalMachine = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreName // TypeDefIndex: 7513
{
	// Fields
	public int value__; // 0x0
	public const StoreName AddressBook = 1;
	public const StoreName AuthRoot = 2;
	public const StoreName CertificateAuthority = 3;
	public const StoreName Disallowed = 4;
	public const StoreName My = 5;
	public const StoreName Root = 6;
	public const StoreName TrustedPeople = 7;
	public const StoreName TrustedPublisher = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X500DistinguishedNameFlags // TypeDefIndex: 7514
{
	// Fields
	public int value__; // 0x0
	public const X500DistinguishedNameFlags None = 0;
	public const X500DistinguishedNameFlags Reversed = 1;
	public const X500DistinguishedNameFlags UseSemicolons = 16;
	public const X500DistinguishedNameFlags DoNotUsePlusSign = 32;
	public const X500DistinguishedNameFlags DoNotUseQuotes = 64;
	public const X500DistinguishedNameFlags UseCommas = 128;
	public const X500DistinguishedNameFlags UseNewLines = 256;
	public const X500DistinguishedNameFlags UseUTF8Encoding = 4096;
	public const X500DistinguishedNameFlags UseT61Encoding = 8192;
	public const X500DistinguishedNameFlags ForceUTF8Encoding = 16384;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509ChainStatusFlags // TypeDefIndex: 7515
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags Revoked = 4;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotValidForUsage = 16;
	public const X509ChainStatusFlags UntrustedRoot = 32;
	public const X509ChainStatusFlags RevocationStatusUnknown = 64;
	public const X509ChainStatusFlags Cyclic = 128;
	public const X509ChainStatusFlags InvalidExtension = 256;
	public const X509ChainStatusFlags InvalidPolicyConstraints = 512;
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags InvalidNameConstraints = 2048;
	public const X509ChainStatusFlags HasNotSupportedNameConstraint = 4096;
	public const X509ChainStatusFlags HasNotDefinedNameConstraint = 8192;
	public const X509ChainStatusFlags HasNotPermittedNameConstraint = 16384;
	public const X509ChainStatusFlags HasExcludedNameConstraint = 32768;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags CtlNotTimeValid = 131072;
	public const X509ChainStatusFlags CtlNotSignatureValid = 262144;
	public const X509ChainStatusFlags CtlNotValidForUsage = 524288;
	public const X509ChainStatusFlags OfflineRevocation = 16777216;
	public const X509ChainStatusFlags NoIssuanceChainPolicy = 33554432;
	public const X509ChainStatusFlags ExplicitDistrust = 67108864;
	public const X509ChainStatusFlags HasNotSupportedCriticalExtension = 134217728;
	public const X509ChainStatusFlags HasWeakSignature = 1048576;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509FindType // TypeDefIndex: 7516
{
	// Fields
	public int value__; // 0x0
	public const X509FindType FindByThumbprint = 0;
	public const X509FindType FindBySubjectName = 1;
	public const X509FindType FindBySubjectDistinguishedName = 2;
	public const X509FindType FindByIssuerName = 3;
	public const X509FindType FindByIssuerDistinguishedName = 4;
	public const X509FindType FindBySerialNumber = 5;
	public const X509FindType FindByTimeValid = 6;
	public const X509FindType FindByTimeNotYetValid = 7;
	public const X509FindType FindByTimeExpired = 8;
	public const X509FindType FindByTemplateName = 9;
	public const X509FindType FindByApplicationPolicy = 10;
	public const X509FindType FindByCertificatePolicy = 11;
	public const X509FindType FindByExtension = 12;
	public const X509FindType FindByKeyUsage = 13;
	public const X509FindType FindBySubjectKeyIdentifier = 14;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509KeyUsageFlags // TypeDefIndex: 7517
{
	// Fields
	public int value__; // 0x0
	public const X509KeyUsageFlags None = 0;
	public const X509KeyUsageFlags EncipherOnly = 1;
	public const X509KeyUsageFlags CrlSign = 2;
	public const X509KeyUsageFlags KeyCertSign = 4;
	public const X509KeyUsageFlags KeyAgreement = 8;
	public const X509KeyUsageFlags DataEncipherment = 16;
	public const X509KeyUsageFlags KeyEncipherment = 32;
	public const X509KeyUsageFlags NonRepudiation = 64;
	public const X509KeyUsageFlags DigitalSignature = 128;
	public const X509KeyUsageFlags DecipherOnly = 32768;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509NameType // TypeDefIndex: 7518
{
	// Fields
	public int value__; // 0x0
	public const X509NameType SimpleName = 0;
	public const X509NameType EmailName = 1;
	public const X509NameType UpnName = 2;
	public const X509NameType DnsName = 3;
	public const X509NameType DnsFromAlternativeName = 4;
	public const X509NameType UrlName = 5;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationFlag // TypeDefIndex: 7519
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationFlag EndCertificateOnly = 0;
	public const X509RevocationFlag EntireChain = 1;
	public const X509RevocationFlag ExcludeRoot = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationMode // TypeDefIndex: 7520
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationMode NoCheck = 0;
	public const X509RevocationMode Online = 1;
	public const X509RevocationMode Offline = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509SubjectKeyIdentifierHashAlgorithm // TypeDefIndex: 7521
{
	// Fields
	public int value__; // 0x0
	public const X509SubjectKeyIdentifierHashAlgorithm Sha1 = 0;
	public const X509SubjectKeyIdentifierHashAlgorithm ShortSha1 = 1;
	public const X509SubjectKeyIdentifierHashAlgorithm CapiSha1 = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509VerificationFlags // TypeDefIndex: 7522
{
	// Fields
	public int value__; // 0x0
	public const X509VerificationFlags NoFlag = 0;
	public const X509VerificationFlags IgnoreNotTimeValid = 1;
	public const X509VerificationFlags IgnoreCtlNotTimeValid = 2;
	public const X509VerificationFlags IgnoreNotTimeNested = 4;
	public const X509VerificationFlags IgnoreInvalidBasicConstraints = 8;
	public const X509VerificationFlags AllowUnknownCertificateAuthority = 16;
	public const X509VerificationFlags IgnoreWrongUsage = 32;
	public const X509VerificationFlags IgnoreInvalidName = 64;
	public const X509VerificationFlags IgnoreInvalidPolicy = 128;
	public const X509VerificationFlags IgnoreEndRevocationUnknown = 256;
	public const X509VerificationFlags IgnoreCtlSignerRevocationUnknown = 512;
	public const X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown = 1024;
	public const X509VerificationFlags IgnoreRootRevocationUnknown = 2048;
	public const X509VerificationFlags AllFlags = 4095;
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class PublicKey // TypeDefIndex: 7523
{
	// Fields
	private AsnEncodedData _keyValue; // 0x10
	private AsnEncodedData _params; // 0x18
	private Oid _oid; // 0x20
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x1E19740 Offset: 0x1E17D40 VA: 0x181E19740
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x1E19960 Offset: 0x1E17F60 VA: 0x181E19960
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Oid get_Oid() { }

	// RVA: 0x1E19630 Offset: 0x1E17C30 VA: 0x181E19630
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1E18DD0 Offset: 0x1E173D0 VA: 0x181E18DD0
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x1E192D0 Offset: 0x1E178D0 VA: 0x181E192D0
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x1E196D0 Offset: 0x1E17CD0 VA: 0x181E196D0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 7524
{
	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x1E1AA60 Offset: 0x1E19060 VA: 0x181E1AA60
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x1E1A660 Offset: 0x1E18C60 VA: 0x181E1A660
	public void .ctor(string distinguishedName) { }

	// RVA: 0x1E1A670 Offset: 0x1E18C70 VA: 0x181E1A670
	public void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Name() { }

	// RVA: 0x1E1A3D0 Offset: 0x1E189D0 VA: 0x181E1A3D0
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1E1A580 Offset: 0x1E18B80 VA: 0x181E1A580 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x1E1A5F0 Offset: 0x1E18BF0 VA: 0x181E1A5F0
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1E1A2F0 Offset: 0x1E188F0 VA: 0x181E1A2F0
	private void DecodeRawData() { }

	// RVA: 0x1E1A120 Offset: 0x1E18720 VA: 0x181E1A120
	private static string Canonize(string s) { }

	// RVA: 0x1E19F10 Offset: 0x1E18510 VA: 0x181E19F10
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 7525
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x28
	private bool _hasPathLengthConstraint; // 0x29
	private int _pathLengthConstraint; // 0x2C
	private AsnDecodeStatus _status; // 0x30

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1E1B5D0 Offset: 0x1E19BD0 VA: 0x181E1B5D0
	public void .ctor() { }

	// RVA: 0x1E1B690 Offset: 0x1E19C90 VA: 0x181E1B690
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1E1B340 Offset: 0x1E19940 VA: 0x181E1B340
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x1E1B7A0 Offset: 0x1E19DA0 VA: 0x181E1B7A0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1E1B810 Offset: 0x1E19E10 VA: 0x181E1B810
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x1E1B880 Offset: 0x1E19E80 VA: 0x181E1B880
	public int get_PathLengthConstraint() { }

	// RVA: 0x1E1ABE0 Offset: 0x1E191E0 VA: 0x181E1ABE0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1E1AE10 Offset: 0x1E19410 VA: 0x181E1AE10
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1E1AF70 Offset: 0x1E19570 VA: 0x181E1AF70
	internal byte[] Encode() { }

	// RVA: 0x1E1B0F0 Offset: 0x1E196F0 VA: 0x181E1B0F0 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate2 : X509Certificate // TypeDefIndex: 7526
{
	// Fields
	private byte[] lazyRawData; // 0x60
	private Oid lazySignatureAlgorithm; // 0x68
	private int lazyVersion; // 0x70
	private X500DistinguishedName lazySubjectName; // 0x78
	private X500DistinguishedName lazyIssuerName; // 0x80
	private PublicKey lazyPublicKey; // 0x88
	private AsymmetricAlgorithm lazyPrivateKey; // 0x90
	private X509ExtensionCollection lazyExtensions; // 0x98

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public bool HasPrivateKey { get; }
	public AsymmetricAlgorithm PrivateKey { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public PublicKey PublicKey { get; }
	public byte[] RawData { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	internal X509Certificate2Impl Impl { get; }

	// Methods

	// RVA: 0x1E1F980 Offset: 0x1E1DF80 VA: 0x181E1F980 Slot: 7
	public override void Reset() { }

	// RVA: 0x1E208F0 Offset: 0x1E1EEF0 VA: 0x181E208F0
	public void .ctor() { }

	// RVA: 0x1E207D0 Offset: 0x1E1EDD0 VA: 0x181E207D0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1E207B0 Offset: 0x1E1EDB0 VA: 0x181E207B0
	public void .ctor(byte[] rawData, string password) { }

	// RVA: 0x1E208E0 Offset: 0x1E1EEE0 VA: 0x181E208E0
	internal void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x1E207C0 Offset: 0x1E1EDC0 VA: 0x181E207C0
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x1E20900 Offset: 0x1E1EF00 VA: 0x181E20900
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E20960 Offset: 0x1E1EF60 VA: 0x181E20960
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x1E20CB0 Offset: 0x1E1F2B0 VA: 0x181E20CB0
	public bool get_HasPrivateKey() { }

	// RVA: 0x1E20E20 Offset: 0x1E1F420 VA: 0x181E20E20
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1E20D80 Offset: 0x1E1F380 VA: 0x181E20D80
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x1E20E00 Offset: 0x1E1F400 VA: 0x181E20E00
	public DateTime get_NotAfter() { }

	// RVA: 0x1E20E10 Offset: 0x1E1F410 VA: 0x181E20E10
	public DateTime get_NotBefore() { }

	// RVA: 0x1E20FE0 Offset: 0x1E1F5E0 VA: 0x181E20FE0
	public PublicKey get_PublicKey() { }

	// RVA: 0x1E21170 Offset: 0x1E1F770 VA: 0x181E21170
	public byte[] get_RawData() { }

	// RVA: 0x1E211F0 Offset: 0x1E1F7F0 VA: 0x181E211F0
	public string get_SerialNumber() { }

	// RVA: 0x1E21210 Offset: 0x1E1F810 VA: 0x181E21210
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x1E213D0 Offset: 0x1E1F9D0 VA: 0x181E213D0
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x1E21450 Offset: 0x1E1FA50 VA: 0x181E21450
	public string get_Thumbprint() { }

	// RVA: 0x1E21480 Offset: 0x1E1FA80 VA: 0x181E21480
	public int get_Version() { }

	// RVA: 0x1E1F890 Offset: 0x1E1DE90 VA: 0x181E1F890
	public static X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x1E1F930 Offset: 0x1E1DF30 VA: 0x181E1F930
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1E20760 Offset: 0x1E1ED60 VA: 0x181E20760 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E1FA50 Offset: 0x1E1E050 VA: 0x181E1FA50 Slot: 19
	public override string ToString(bool verbose) { }

	// RVA: 0x1E20770 Offset: 0x1E1ED70 VA: 0x181E20770
	public bool Verify() { }

	// RVA: 0x1E1F590 Offset: 0x1E1DB90 VA: 0x181E1F590
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x1E20D00 Offset: 0x1E1F300 VA: 0x181E20D00
	internal X509Certificate2Impl get_Impl() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 7527
{
	// Fields
	private static string[] newline_split; // 0x0

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }

	// RVA: 0x1E1CF50 Offset: 0x1E1B550 VA: 0x181E1CF50
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x1E1CFF0 Offset: 0x1E1B5F0 VA: 0x181E1CFF0
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x1E1B970 Offset: 0x1E19F70 VA: 0x181E1B970
	public int Add(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x1E1B8F0 Offset: 0x1E19EF0 VA: 0x181E1B8F0
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x1E1BA00 Offset: 0x1E1A000 VA: 0x181E1BA00
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x1E1CDE0 Offset: 0x1E1B3E0 VA: 0x181E1CDE0
	private string GetKeyIdentifier(X509Certificate2 x) { }

	[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	// RVA: 0x1E1BC60 Offset: 0x1E1A260 VA: 0x181E1BC60
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x1E1CD40 Offset: 0x1E1B340 VA: 0x181E1CD40
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x1E1CEB0 Offset: 0x1E1B4B0 VA: 0x181E1CEB0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator : IEnumerator // TypeDefIndex: 7528
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate2 Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1E1D2A0 Offset: 0x1E1B8A0 VA: 0x181E1D2A0
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x1E1D310 Offset: 0x1E1B910 VA: 0x181E1D310
	public X509Certificate2 get_Current() { }

	// RVA: 0x1E1D160 Offset: 0x1E1B760 VA: 0x181E1D160
	public bool MoveNext() { }

	// RVA: 0x1E1D250 Offset: 0x1E1B850 VA: 0x181E1D250 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1E1D1B0 Offset: 0x1E1B7B0 VA: 0x181E1D1B0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1E1D200 Offset: 0x1E1B800 VA: 0x181E1D200 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 7529
{
	// Properties
	public abstract IEnumerable<X509Extension> Extensions { get; }
	public abstract X500DistinguishedName IssuerName { get; }
	public abstract AsymmetricAlgorithm PrivateKey { get; set; }
	public abstract string SignatureAlgorithm { get; }
	public abstract X500DistinguishedName SubjectName { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IEnumerable<X509Extension> get_Extensions();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract X500DistinguishedName get_IssuerName();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract AsymmetricAlgorithm get_PrivateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_PrivateKey(AsymmetricAlgorithm value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_SignatureAlgorithm();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract X500DistinguishedName get_SubjectName();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 29
	internal abstract X509CertificateImplCollection get_IntermediateCertificates();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool Verify(X509Certificate2 thisCertificate);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void AppendPrivateKeyInfo(StringBuilder sb);

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Certificate2ImplMono : X509Certificate2ImplUnix // TypeDefIndex: 7530
{
	// Fields
	private X509CertificateImplCollection intermediateCerts; // 0xB0
	private X509Certificate _cert; // 0xB8
	private static string empty_error; // 0x0
	private static byte[] signedData; // 0x8

	// Properties
	public override bool IsValid { get; }
	private X509Certificate Cert { get; }
	public override bool HasPrivateKey { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0x1C51180 Offset: 0x1C4F780 VA: 0x181C51180 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1E1E2B0 Offset: 0x1E1C8B0 VA: 0x181E1E2B0
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x1E1E2F0 Offset: 0x1E1C8F0 VA: 0x181E1E2F0
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x1E1E060 Offset: 0x1E1C660 VA: 0x181E1E060
	public void .ctor(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1E1D3B0 Offset: 0x1E1B9B0 VA: 0x181E1D3B0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x1DE06F0 Offset: 0x1DDECF0 VA: 0x181DE06F0
	private X509Certificate get_Cert() { }

	// RVA: 0x1E1D5E0 Offset: 0x1E1BBE0 VA: 0x181E1D5E0 Slot: 33
	protected override byte[] GetRawCertData() { }

	// RVA: 0x1E1E3B0 Offset: 0x1E1C9B0 VA: 0x181E1E3B0 Slot: 17
	public override bool get_HasPrivateKey() { }

	// RVA: 0x1E1E3E0 Offset: 0x1E1C9E0 VA: 0x181E1E3E0 Slot: 24
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1E1E830 Offset: 0x1E1CE30 VA: 0x181E1E830 Slot: 25
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x1E1D540 Offset: 0x1E1BB40 VA: 0x181E1D540 Slot: 18
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x1E1D4A0 Offset: 0x1E1BAA0 VA: 0x181E1D4A0 Slot: 19
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x1E1DD80 Offset: 0x1E1C380 VA: 0x181E1DD80
	private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x1E1D630 Offset: 0x1E1BC30 VA: 0x181E1D630
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODO("by default this depends on the incomplete X509Chain")]
	// RVA: 0x1E1DDF0 Offset: 0x1E1C3F0 VA: 0x181E1DDF0 Slot: 31
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0 Slot: 29
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x1E1DF80 Offset: 0x1E1C580 VA: 0x181E1DF80
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl // TypeDefIndex: 7531
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Properties
	public sealed override string KeyAlgorithm { get; }
	public sealed override byte[] KeyAlgorithmParameters { get; }
	public sealed override byte[] PublicKeyValue { get; }
	public sealed override byte[] SerialNumber { get; }
	public sealed override string SignatureAlgorithm { get; }
	public sealed override int Version { get; }
	public sealed override X500DistinguishedName SubjectName { get; }
	public sealed override X500DistinguishedName IssuerName { get; }
	public sealed override string Subject { get; }
	public sealed override string Issuer { get; }
	public sealed override byte[] RawData { get; }
	public sealed override byte[] Thumbprint { get; }
	public sealed override IEnumerable<X509Extension> Extensions { get; }
	public sealed override DateTime NotAfter { get; }
	public sealed override DateTime NotBefore { get; }

	// Methods

	// RVA: 0x1E1EB20 Offset: 0x1E1D120 VA: 0x181E1EB20
	private void EnsureCertData() { }

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract byte[] GetRawCertData();

	// RVA: 0x1E1F2F0 Offset: 0x1E1D8F0 VA: 0x181E1F2F0 Slot: 13
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x1E1F2D0 Offset: 0x1E1D8D0 VA: 0x181E1F2D0 Slot: 14
	public sealed override byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x1E1F3D0 Offset: 0x1E1D9D0 VA: 0x181E1F3D0 Slot: 15
	public sealed override byte[] get_PublicKeyValue() { }

	// RVA: 0x1E1F410 Offset: 0x1E1DA10 VA: 0x181E1F410 Slot: 16
	public sealed override byte[] get_SerialNumber() { }

	// RVA: 0x1E1F430 Offset: 0x1E1DA30 VA: 0x181E1F430 Slot: 26
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x1E1F570 Offset: 0x1E1DB70 VA: 0x181E1F570 Slot: 28
	public sealed override int get_Version() { }

	// RVA: 0x1E1F450 Offset: 0x1E1DA50 VA: 0x181E1F450 Slot: 27
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x1E1F280 Offset: 0x1E1D880 VA: 0x181E1F280 Slot: 23
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x1E1F470 Offset: 0x1E1DA70 VA: 0x181E1F470 Slot: 8
	public sealed override string get_Subject() { }

	// RVA: 0x1E1F2A0 Offset: 0x1E1D8A0 VA: 0x181E1F2A0 Slot: 7
	public sealed override string get_Issuer() { }

	// RVA: 0x1E1F3F0 Offset: 0x1E1D9F0 VA: 0x181E1F3F0 Slot: 9
	public sealed override byte[] get_RawData() { }

	// RVA: 0x1E1F4A0 Offset: 0x1E1DAA0 VA: 0x181E1F4A0 Slot: 12
	public sealed override byte[] get_Thumbprint() { }

	// RVA: 0x1E1F220 Offset: 0x1E1D820 VA: 0x181E1F220 Slot: 30
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1E1F260 Offset: 0x1E1D860 VA: 0x181E1F260 Slot: 22
	public sealed override IEnumerable<X509Extension> get_Extensions() { }

	// RVA: 0x1E1F310 Offset: 0x1E1D910 VA: 0x181E1F310 Slot: 10
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x1E1F370 Offset: 0x1E1D970 VA: 0x181E1F370 Slot: 11
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x1E1EA90 Offset: 0x1E1D090 VA: 0x181E1EA90 Slot: 32
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x1E1F0A0 Offset: 0x1E1D6A0 VA: 0x181E1F0A0 Slot: 20
	public sealed override byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x1E1EC30 Offset: 0x1E1D230 VA: 0x181E1EC30
	private byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x1E1EC90 Offset: 0x1E1D290 VA: 0x181E1EC90
	private byte[] ExportPkcs12(string password) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase // TypeDefIndex: 7533
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }

	// RVA: 0x1E21790 Offset: 0x1E1FD90 VA: 0x181E21790
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x1E21910 Offset: 0x1E1FF10 VA: 0x181E21910
	public X509Certificate get_Item(int index) { }

	// RVA: 0x1E21660 Offset: 0x1E1FC60 VA: 0x181E21660
	public int Add(X509Certificate value) { }

	// RVA: 0x1E214F0 Offset: 0x1E1FAF0 VA: 0x181E214F0
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x1E216F0 Offset: 0x1E1FCF0 VA: 0x181E216F0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 7534
{
	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x1E21F10 Offset: 0x1E20510 VA: 0x181E21F10
	public void .ctor() { }

	// RVA: 0x1E21F90 Offset: 0x1E20590 VA: 0x181E21F90
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x1E221A0 Offset: 0x1E207A0 VA: 0x181E221A0
	public int get_Count() { }

	// RVA: 0x1E221E0 Offset: 0x1E207E0 VA: 0x181E221E0
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x1E21C10 Offset: 0x1E20210 VA: 0x181E21C10
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x1E21D00 Offset: 0x1E20300 VA: 0x181E21D00
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x1E21EB0 Offset: 0x1E204B0 VA: 0x181E21EB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1E21D60 Offset: 0x1E20360 VA: 0x181E21D60 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain : IDisposable // TypeDefIndex: 7535
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainElementCollection ChainElements { get; }
	public X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: 0x1E28400 Offset: 0x1E26A00 VA: 0x181E28400
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x1E28210 Offset: 0x1E26810 VA: 0x181E28210
	public void .ctor() { }

	// RVA: 0x1E28280 Offset: 0x1E26880 VA: 0x181E28280
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x1E28190 Offset: 0x1E26790 VA: 0x181E28190
	internal void .ctor(X509ChainImpl impl) { }

	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	// RVA: 0x1E28140 Offset: 0x1E26740 VA: 0x181E28140
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x1E28300 Offset: 0x1E26900 VA: 0x181E28300
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1E28380 Offset: 0x1E26980 VA: 0x181E28380
	public X509ChainPolicy get_ChainPolicy() { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x1E27EB0 Offset: 0x1E264B0 VA: 0x181E27EB0
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1E280D0 Offset: 0x1E266D0 VA: 0x181E280D0
	public void Reset() { }

	// RVA: 0x1E27F40 Offset: 0x1E26540 VA: 0x181E27F40
	public static X509Chain Create() { }

	// RVA: 0x1E28070 Offset: 0x1E26670 VA: 0x181E28070 Slot: 4
	public void Dispose() { }

	// RVA: 0x1E27FE0 Offset: 0x1E265E0 VA: 0x181E27FE0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509ChainElement // TypeDefIndex: 7536
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0x1E237E0 Offset: 0x1E21DE0 VA: 0x181E237E0
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x1E228C0 Offset: 0x1E20EC0 VA: 0x181E228C0
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x1E228F0 Offset: 0x1E20EF0 VA: 0x181E228F0
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x1E22970 Offset: 0x1E20F70 VA: 0x181E22970
	internal void UncompressFlags() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 7537
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1E225A0 Offset: 0x1E20BA0 VA: 0x181E225A0
	internal void .ctor() { }

	// RVA: 0x14A4DA0 Offset: 0x14A33A0 VA: 0x1814A4DA0 Slot: 5
	public int get_Count() { }

	// RVA: 0x140B6D0 Offset: 0x1409CD0 VA: 0x18140B6D0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1E22610 Offset: 0x1E20C10 VA: 0x181E22610
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x14A4580 Offset: 0x14A2B80 VA: 0x1814A4580 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14A4550 Offset: 0x14A2B50 VA: 0x1814A4550 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1E22460 Offset: 0x1E20A60 VA: 0x181E22460
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x1E22500 Offset: 0x1E20B00 VA: 0x181E22500 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E22240 Offset: 0x1E20840 VA: 0x181E22240
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x1E222F0 Offset: 0x1E208F0 VA: 0x181E222F0
	internal void Clear() { }

	// RVA: 0x1E22320 Offset: 0x1E20920 VA: 0x181E22320
	internal bool Contains(X509Certificate2 certificate) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator : IEnumerator // TypeDefIndex: 7538
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509ChainElement Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1E227B0 Offset: 0x1E20DB0 VA: 0x181E227B0
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x1E22820 Offset: 0x1E20E20 VA: 0x181E22820
	public X509ChainElement get_Current() { }

	// RVA: 0x1E22760 Offset: 0x1E20D60 VA: 0x181E22760 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1E226C0 Offset: 0x1E20CC0 VA: 0x181E226C0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1E22710 Offset: 0x1E20D10 VA: 0x181E22710 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 7539
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract X509ChainElementCollection ChainElements { get; }
	public abstract X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x1E27620 Offset: 0x1E25C20 VA: 0x181E27620
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509ChainElementCollection get_ChainElements();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract X509ChainPolicy get_ChainPolicy();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Build(X509Certificate2 certificate);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void AddStatus(X509ChainStatusFlags errorCode);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Reset();

	// RVA: 0x1E275C0 Offset: 0x1E25BC0 VA: 0x181E275C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F5CD0 Offset: 0x16F42D0 VA: 0x1816F5CD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 7540
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override bool IsValid { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0x1E26BB0 Offset: 0x1E251B0 VA: 0x181E26BB0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void AddStatus(X509ChainStatusFlags error) { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x1E23BC0 Offset: 0x1E221C0 VA: 0x181E23BC0 Slot: 8
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1E262A0 Offset: 0x1E248A0 VA: 0x181E262A0 Slot: 10
	public override void Reset() { }

	// RVA: 0x1E272D0 Offset: 0x1E258D0 VA: 0x181E272D0
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x1E26DB0 Offset: 0x1E253B0 VA: 0x181E26DB0
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x1E27230 Offset: 0x1E25830 VA: 0x181E27230
	private X509Store get_LMRootStore() { }

	// RVA: 0x1E27520 Offset: 0x1E25B20 VA: 0x181E27520
	private X509Store get_UserRootStore() { }

	// RVA: 0x1E27190 Offset: 0x1E25790 VA: 0x181E27190
	private X509Store get_LMCAStore() { }

	// RVA: 0x1E27480 Offset: 0x1E25A80 VA: 0x181E27480
	private X509Store get_UserCAStore() { }

	// RVA: 0x1E26F60 Offset: 0x1E25560 VA: 0x181E26F60
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x1E23830 Offset: 0x1E21E30 VA: 0x181E23830
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x1E26480 Offset: 0x1E24A80 VA: 0x181E26480
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x1E24ED0 Offset: 0x1E234D0 VA: 0x181E24ED0
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x1E25390 Offset: 0x1E23990 VA: 0x181E25390
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x1E254E0 Offset: 0x1E23AE0 VA: 0x181E254E0
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x1E267B0 Offset: 0x1E24DB0 VA: 0x181E267B0
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x1E25F30 Offset: 0x1E24530 VA: 0x181E25F30
	private void Process(int n) { }

	// RVA: 0x1E25580 Offset: 0x1E23B80 VA: 0x181E25580
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x1E26A50 Offset: 0x1E25050 VA: 0x181E26A50
	private void WrapUp() { }

	// RVA: 0x1E25900 Offset: 0x1E23F00 VA: 0x181E25900
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x1E25530 Offset: 0x1E23B30 VA: 0x181E25530
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x1E252F0 Offset: 0x1E238F0 VA: 0x181E252F0
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x1E25070 Offset: 0x1E23670 VA: 0x181E25070
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x1E25100 Offset: 0x1E23700 VA: 0x181E25100
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x1E25180 Offset: 0x1E23780 VA: 0x181E25180
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x1E245E0 Offset: 0x1E22BE0 VA: 0x181E245E0
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x1E24AA0 Offset: 0x1E230A0 VA: 0x181E24AA0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x1E24840 Offset: 0x1E22E40 VA: 0x181E24840
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x1E242F0 Offset: 0x1E228F0 VA: 0x181E242F0
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x1E24BE0 Offset: 0x1E231E0 VA: 0x181E24BE0
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x1E25CF0 Offset: 0x1E242F0 VA: 0x181E25CF0
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x1E25AC0 Offset: 0x1E240C0 VA: 0x181E25AC0
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x1E26B40 Offset: 0x1E25140 VA: 0x181E26B40
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainPolicy // TypeDefIndex: 7541
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; set; }
	public X509RevocationFlag RevocationFlag { get; }
	public X509RevocationMode RevocationMode { get; set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0x1E27780 Offset: 0x1E25D80 VA: 0x181E27780
	public void .ctor() { }

	// RVA: 0x1E278A0 Offset: 0x1E25EA0 VA: 0x181E278A0
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x1E27C20 Offset: 0x1E26220 VA: 0x181E27C20
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x1E27C90 Offset: 0x1E26290 VA: 0x181E27C90
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public DateTime get_VerificationTime() { }

	// RVA: 0x1E27670 Offset: 0x1E25C70 VA: 0x181E27670
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus // TypeDefIndex: 7542
{
	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }

	// Methods

	// RVA: 0x1E27E80 Offset: 0x1E26480 VA: 0x181E27E80
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	public void set_StatusInformation(string value) { }

	// RVA: 0x1E27D00 Offset: 0x1E26300 VA: 0x181E27D00
	internal static string GetInformation(X509ChainStatusFlags flags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 7543
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x1E28D40 Offset: 0x1E27340 VA: 0x181E28D40
	public void .ctor() { }

	// RVA: 0x1E28E00 Offset: 0x1E27400 VA: 0x181E28E00
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x1E28F10 Offset: 0x1E27510 VA: 0x181E28F10
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x1E28460 Offset: 0x1E26A60 VA: 0x181E28460 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1E28690 Offset: 0x1E26C90 VA: 0x181E28690
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1E28870 Offset: 0x1E26E70 VA: 0x181E28870
	internal byte[] Encode() { }

	// RVA: 0x1E28A10 Offset: 0x1E27010 VA: 0x181E28A10 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension : AsnEncodedData // TypeDefIndex: 7544
{
	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1E29F40 Offset: 0x1E28540 VA: 0x181E29F40
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_Critical() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_Critical(bool value) { }

	// RVA: 0x1E29C50 Offset: 0x1E28250 VA: 0x181E29C50 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1E29E40 Offset: 0x1E28440 VA: 0x181E29E40
	internal string FormatUnkownData(byte[] data) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : ICollection, IEnumerable // TypeDefIndex: 7545
{
	// Fields
	private static byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x1E29740 Offset: 0x1E27D40 VA: 0x181E29740
	public void .ctor() { }

	// RVA: 0x14A4DA0 Offset: 0x14A33A0 VA: 0x1814A4DA0 Slot: 5
	public int get_Count() { }

	// RVA: 0x140B6D0 Offset: 0x1409CD0 VA: 0x18140B6D0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1E297B0 Offset: 0x1E27DB0 VA: 0x181E297B0
	public X509Extension get_Item(string oid) { }

	// RVA: 0x1E293D0 Offset: 0x1E279D0 VA: 0x181E293D0
	public int Add(X509Extension extension) { }

	// RVA: 0x1E294F0 Offset: 0x1E27AF0 VA: 0x181E294F0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1E29460 Offset: 0x1E27A60 VA: 0x181E29460
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x1E29640 Offset: 0x1E27C40 VA: 0x181E29640 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E296D0 Offset: 0x1E27CD0 VA: 0x181E296D0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator : IEnumerator // TypeDefIndex: 7546
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Extension Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1E29B50 Offset: 0x1E28150 VA: 0x181E29B50
	internal void .ctor(ArrayList list) { }

	// RVA: 0x1E29BB0 Offset: 0x1E281B0 VA: 0x181E29BB0
	public X509Extension get_Current() { }

	// RVA: 0x1E29B00 Offset: 0x1E28100 VA: 0x181E29B00 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1E29A60 Offset: 0x1E28060 VA: 0x181E29A60 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1E29AB0 Offset: 0x1E280B0 VA: 0x181E29AB0 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2 // TypeDefIndex: 7547
{
	// Methods

	[MonoTODO("Investigate replacement; see comments in source.")]
	// RVA: 0x1E2A0C0 Offset: 0x1E286C0 VA: 0x181E2A0C0
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x1E29FF0 Offset: 0x1E285F0 VA: 0x181E29FF0
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x13D84E0 Offset: 0x13D6AE0 VA: 0x1813D84E0
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x1E2A1F0 Offset: 0x1E287F0 VA: 0x181E2A1F0
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x1E2A050 Offset: 0x1E28650 VA: 0x181E2A050
	internal static Exception GetInvalidChainContextException() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 7548
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x28
	private AsnDecodeStatus _status; // 0x2C

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x1E2AE70 Offset: 0x1E29470 VA: 0x181E2AE70
	public void .ctor() { }

	// RVA: 0x1E2AC60 Offset: 0x1E29260 VA: 0x181E2AC60
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x1E2AD70 Offset: 0x1E29370 VA: 0x181E2AD70
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x1E2AF30 Offset: 0x1E29530 VA: 0x181E2AF30
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x1E2A240 Offset: 0x1E28840 VA: 0x181E2A240 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1E2A750 Offset: 0x1E28D50 VA: 0x181E2A750
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x1E2A470 Offset: 0x1E28A70 VA: 0x181E2A470
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1E2A5E0 Offset: 0x1E28BE0 VA: 0x181E2A5E0
	internal byte[] Encode() { }

	// RVA: 0x1E2A760 Offset: 0x1E28D60 VA: 0x181E2A760 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Store : IDisposable // TypeDefIndex: 7549
{
	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }

	// Methods

	// RVA: 0x1E2B3C0 Offset: 0x1E299C0 VA: 0x181E2B3C0
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x1E2B520 Offset: 0x1E29B20 VA: 0x181E2B520
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x1E2B5B0 Offset: 0x1E29BB0 VA: 0x181E2B5B0
	private X509Stores get_Factory() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal X509Store get_Store() { }

	// RVA: 0x1E2AFA0 Offset: 0x1E295A0 VA: 0x181E2AFA0
	public void Close() { }

	// RVA: 0x1E2AFA0 Offset: 0x1E295A0 VA: 0x181E2AFA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1E2AFE0 Offset: 0x1E295E0 VA: 0x181E2AFE0
	public void Open(OpenFlags flags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 7550
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x1E2C8A0 Offset: 0x1E2AEA0 VA: 0x181E2C8A0
	public void .ctor() { }

	// RVA: 0x1E2C2A0 Offset: 0x1E2A8A0 VA: 0x181E2C2A0
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x1E2C3B0 Offset: 0x1E2A9B0 VA: 0x181E2C3B0
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1E2C5D0 Offset: 0x1E2ABD0 VA: 0x181E2C5D0
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1E2C280 Offset: 0x1E2A880 VA: 0x181E2C280
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x1E2BE40 Offset: 0x1E2A440 VA: 0x181E2BE40
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x1E2C960 Offset: 0x1E2AF60 VA: 0x181E2C960
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x1E2B5D0 Offset: 0x1E29BD0 VA: 0x181E2B5D0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1E2B9C0 Offset: 0x1E29FC0 VA: 0x181E2B9C0
	internal static byte FromHexChar(char c) { }

	// RVA: 0x1E2B9F0 Offset: 0x1E29FF0 VA: 0x181E2B9F0
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x1E2BA70 Offset: 0x1E2A070 VA: 0x181E2BA70
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x1E2B800 Offset: 0x1E29E00 VA: 0x181E2B800
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1E2B940 Offset: 0x1E29F40 VA: 0x181E2B940
	internal byte[] Encode() { }

	// RVA: 0x1E2BBF0 Offset: 0x1E2A1F0 VA: 0x181E2BBF0 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Extension]
public static class RSACertificateExtensions // TypeDefIndex: 10710
{
	// Methods

	[Extension]
	// RVA: 0x1A05D20 Offset: 0x1A04320 VA: 0x181A05D20
	public static RSA GetRSAPublicKey(X509Certificate2 certificate) { }
}

