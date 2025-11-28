// Namespace: Mono.Security.Authenticode
public class AuthenticodeBase // TypeDefIndex: 12883
{
	// Fields
	private byte[] fileblock; // 0x10
	private Stream fs; // 0x18
	private int blockNo; // 0x20
	private int blockLength; // 0x24
	private int peOffset; // 0x28
	private int dirSecurityOffset; // 0x2C
	private int dirSecuritySize; // 0x30
	private int coffSymbolTableOffset; // 0x34
	private bool pe64; // 0x38

	// Properties
	internal int PEOffset { get; }

	// Methods

	// RVA: 0x1322890 Offset: 0x1320E90 VA: 0x181322890
	public void .ctor() { }

	// RVA: 0x13228F0 Offset: 0x1320EF0 VA: 0x1813228F0
	internal int get_PEOffset() { }

	// RVA: 0x13223D0 Offset: 0x13209D0 VA: 0x1813223D0
	internal void Open(string filename) { }

	// RVA: 0x1322490 Offset: 0x1320A90 VA: 0x181322490
	internal void Open(byte[] rawdata) { }

	// RVA: 0x1321DD0 Offset: 0x13203D0 VA: 0x181321DD0
	internal void Close() { }

	// RVA: 0x13227C0 Offset: 0x1320DC0 VA: 0x1813227C0
	internal void ReadFirstBlock() { }

	// RVA: 0x1322540 Offset: 0x1320B40 VA: 0x181322540
	internal int ProcessFirstBlock() { }

	// RVA: 0x1322300 Offset: 0x1320900 VA: 0x181322300
	internal byte[] GetSecurityEntry() { }

	// RVA: 0x1321E20 Offset: 0x1320420 VA: 0x181321E20
	internal byte[] GetHash(HashAlgorithm hash) { }
}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 12884
{
	// Fields
	private string filename; // 0x40
	private byte[] rawdata; // 0x48
	private byte[] hash; // 0x50
	private X509CertificateCollection coll; // 0x58
	private ASN1 signedHash; // 0x60
	private DateTime timestamp; // 0x68
	private X509Certificate signingCertificate; // 0x70
	private int reason; // 0x78
	private bool trustedRoot; // 0x7C
	private bool trustedTimestampRoot; // 0x7D
	private byte[] entry; // 0x80
	private X509Chain signerChain; // 0x88
	private X509Chain timestampChain; // 0x90

	// Properties
	public byte[] RawData { set; }
	public X509Certificate SigningCertificate { get; }

	// Methods

	// RVA: 0x1325740 Offset: 0x1323D40 VA: 0x181325740
	public void .ctor() { }

	// RVA: 0x1325820 Offset: 0x1323E20 VA: 0x181325820
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1325920 Offset: 0x1323F20 VA: 0x181325920
	public void set_RawData(byte[] value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0x1322920 Offset: 0x1320F20 VA: 0x181322920
	private bool CheckSignature() { }

	// RVA: 0x1324240 Offset: 0x1322840 VA: 0x181324240
	private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509) { }

	// RVA: 0x1324D50 Offset: 0x1323350 VA: 0x181324D50
	private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0x1324440 Offset: 0x1322A40 VA: 0x181324440
	private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) { }

	// RVA: 0x1324340 Offset: 0x1322940 VA: 0x181324340
	private void Reset() { }
}

