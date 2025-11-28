// Namespace: Internal.Cryptography.Pal
internal enum GeneralNameType // TypeDefIndex: 7396
{
	// Fields
	public int value__; // 0x0
	public const GeneralNameType OtherName = 0;
	public const GeneralNameType Rfc822Name = 1;
	public const GeneralNameType Email = 1;
	public const GeneralNameType DnsName = 2;
	public const GeneralNameType X400Address = 3;
	public const GeneralNameType DirectoryName = 4;
	public const GeneralNameType EdiPartyName = 5;
	public const GeneralNameType UniformResourceIdentifier = 6;
	public const GeneralNameType IPAddress = 7;
	public const GeneralNameType RegisteredId = 8;
}

// Namespace: Internal.Cryptography.Pal
internal struct CertificateData // TypeDefIndex: 7399
{
	// Fields
	internal byte[] RawData; // 0x0
	internal byte[] SubjectPublicKeyInfo; // 0x8
	internal int Version; // 0x10
	internal byte[] SerialNumber; // 0x18
	internal CertificateData.AlgorithmIdentifier TbsSignature; // 0x20
	internal X500DistinguishedName Issuer; // 0x30
	internal DateTime NotBefore; // 0x38
	internal DateTime NotAfter; // 0x40
	internal X500DistinguishedName Subject; // 0x48
	internal CertificateData.AlgorithmIdentifier PublicKeyAlgorithm; // 0x50
	internal byte[] PublicKey; // 0x60
	internal byte[] IssuerUniqueId; // 0x68
	internal byte[] SubjectUniqueId; // 0x70
	internal List<X509Extension> Extensions; // 0x78
	internal CertificateData.AlgorithmIdentifier SignatureAlgorithm; // 0x80
	internal byte[] SignatureValue; // 0x90

	// Methods

	// RVA: 0x1DC79B0 Offset: 0x1DC5FB0 VA: 0x181DC79B0
	internal void .ctor(byte[] rawData) { }

	// RVA: 0x1DC70D0 Offset: 0x1DC56D0 VA: 0x181DC70D0
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1DC75F0 Offset: 0x1DC5BF0 VA: 0x181DC75F0
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x1DC6F20 Offset: 0x1DC5520 VA: 0x181DC6F20
	private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	[IteratorStateMachine(typeof(CertificateData.<ReadReverseRdns>d__21))]
	// RVA: 0x1DC7930 Offset: 0x1DC5F30 VA: 0x181DC7930
	private static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(X500DistinguishedName name) { }
}

