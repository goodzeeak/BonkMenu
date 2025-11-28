// Namespace: Mono.Security.X509
internal class SafeBag // TypeDefIndex: 12811
{
	// Fields
	private string _bagOID; // 0x10
	private ASN1 _asn1; // 0x18

	// Properties
	public string BagOID { get; }
	public ASN1 ASN1 { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(string bagOID, ASN1 asn1) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_BagOID() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ASN1 get_ASN1() { }
}

// Namespace: Mono.Security.X509
public class PKCS12 : ICloneable // TypeDefIndex: 12813
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1315B10 Offset: 0x1314110 VA: 0x181315B10
	public void .ctor() { }

	// RVA: 0x1315A80 Offset: 0x1314080 VA: 0x181315A80
	public void .ctor(byte[] data) { }

	// RVA: 0x1315A30 Offset: 0x1314030 VA: 0x181315A30
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x130F580 Offset: 0x130DB80 VA: 0x18130F580
	private void Decode(byte[] data) { }

	// RVA: 0x1310BD0 Offset: 0x130F1D0 VA: 0x181310BD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13166D0 Offset: 0x1314CD0 VA: 0x1813166D0
	public void set_Password(string value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public int get_IterationCount() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	public void set_IterationCount(int value) { }

	// RVA: 0x1316010 Offset: 0x1314610 VA: 0x181316010
	public ArrayList get_Keys() { }

	// RVA: 0x1315C10 Offset: 0x1314210 VA: 0x181315C10
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1316690 Offset: 0x1314C90 VA: 0x181316690
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x130F500 Offset: 0x130DB00 VA: 0x18130F500
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1313480 Offset: 0x1311A80 VA: 0x181313480
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1310070 Offset: 0x130E670 VA: 0x181310070
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x130FF30 Offset: 0x130E530 VA: 0x18130FF30
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x13101B0 Offset: 0x130E7B0 VA: 0x1813101B0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1313170 Offset: 0x1311770 VA: 0x181313170
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x130E3C0 Offset: 0x130C9C0 VA: 0x18130E3C0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1314A80 Offset: 0x1313080 VA: 0x181314A80
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1313C60 Offset: 0x1312260 VA: 0x181313C60
	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0x130E660 Offset: 0x130CC60 VA: 0x18130E660
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1313AB0 Offset: 0x13120B0 VA: 0x181313AB0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1310C60 Offset: 0x130F260 VA: 0x181310C60
	public byte[] GetBytes() { }

	// RVA: 0x1310310 Offset: 0x130E910 VA: 0x181310310
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x130DCA0 Offset: 0x130C2A0 VA: 0x18130DCA0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x130DCB0 Offset: 0x130C2B0 VA: 0x18130DCB0
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x13159E0 Offset: 0x1313FE0 VA: 0x1813159E0
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1315380 Offset: 0x1313980 VA: 0x181315380
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x130F440 Offset: 0x130DA40 VA: 0x18130F440
	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	// RVA: 0x130DFD0 Offset: 0x130C5D0 VA: 0x18130DFD0
	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0x130F2F0 Offset: 0x130D8F0 VA: 0x18130F2F0 Slot: 4
	public object Clone() { }

	// RVA: 0x1316640 Offset: 0x1314C40 VA: 0x181316640
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x13159F0 Offset: 0x1313FF0 VA: 0x1813159F0
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public sealed class X501 // TypeDefIndex: 12814
{
	// Fields
	private static byte[] countryName; // 0x0
	private static byte[] organizationName; // 0x8
	private static byte[] organizationalUnitName; // 0x10
	private static byte[] commonName; // 0x18
	private static byte[] localityName; // 0x20
	private static byte[] stateOrProvinceName; // 0x28
	private static byte[] streetAddress; // 0x30
	private static byte[] serialNumber; // 0x38
	private static byte[] domainComponent; // 0x40
	private static byte[] userid; // 0x48
	private static byte[] email; // 0x50
	private static byte[] dnQualifier; // 0x58
	private static byte[] title; // 0x60
	private static byte[] surname; // 0x68
	private static byte[] givenName; // 0x70
	private static byte[] initial; // 0x78

	// Methods

	// RVA: 0x1319F50 Offset: 0x1318550 VA: 0x181319F50
	public static string ToString(ASN1 seq) { }

	// RVA: 0x1319D60 Offset: 0x1318360 VA: 0x181319D60
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0x1317B30 Offset: 0x1316130 VA: 0x181317B30
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0x13187B0 Offset: 0x1316DB0 VA: 0x1813187B0
	private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	// RVA: 0x1319300 Offset: 0x1317900 VA: 0x181319300
	private static bool IsOid(string oid) { }

	// RVA: 0x13193F0 Offset: 0x13179F0 VA: 0x1813193F0
	private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos) { }

	// RVA: 0x1319240 Offset: 0x1317840 VA: 0x181319240
	private static bool IsHex(char c) { }

	// RVA: 0x1319730 Offset: 0x1317D30 VA: 0x181319730
	private static string ReadHex(string value, ref int pos) { }

	// RVA: 0x1319580 Offset: 0x1317B80 VA: 0x181319580
	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	// RVA: 0x1319970 Offset: 0x1317F70 VA: 0x181319970
	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	// RVA: 0x1319AC0 Offset: 0x13180C0 VA: 0x181319AC0
	private static string ReadValue(string value, ref int pos) { }

	// RVA: 0x1318490 Offset: 0x1316A90 VA: 0x181318490
	public static ASN1 FromString(string rdn) { }

	// RVA: 0x131A0A0 Offset: 0x13186A0 VA: 0x18131A0A0
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public class X509Crl // TypeDefIndex: 12816
{
	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x131F2B0 Offset: 0x131D8B0 VA: 0x18131F2B0
	public void .ctor(byte[] crl) { }

	// RVA: 0x131E4C0 Offset: 0x131CAC0 VA: 0x18131E4C0
	private void Parse(byte[] crl) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x131F3D0 Offset: 0x131D9D0 VA: 0x18131F3D0
	public byte[] get_Hash() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_IssuerName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public DateTime get_NextUpdate() { }

	// RVA: 0x131A830 Offset: 0x1318E30 VA: 0x18131A830
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x131E200 Offset: 0x131C800 VA: 0x18131E200
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x131E290 Offset: 0x131C890 VA: 0x18131E290
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x131EFB0 Offset: 0x131D5B0 VA: 0x18131EFB0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x131EED0 Offset: 0x131D4D0 VA: 0x18131EED0
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x131EC20 Offset: 0x131D220 VA: 0x18131EC20
	public bool VerifySignature(AsymmetricAlgorithm aa) { }
}

// Namespace: Mono.Security.X509
public class X509Certificate : ISerializable // TypeDefIndex: 12817
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }
	public bool IsCurrent { get; }
	public bool IsSelfSigned { get; }

	// Methods

	// RVA: 0x131B0D0 Offset: 0x13196D0 VA: 0x18131B0D0
	private void Parse(byte[] data) { }

	// RVA: 0x131BF70 Offset: 0x131A570 VA: 0x18131BF70
	public void .ctor(byte[] data) { }

	// RVA: 0x131AF10 Offset: 0x1319510 VA: 0x18131AF10
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x131C1B0 Offset: 0x131A7B0 VA: 0x18131C1B0
	public DSA get_DSA() { }

	// RVA: 0x131D1A0 Offset: 0x131B7A0 VA: 0x18131D1A0
	public void set_DSA(DSA value) { }

	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x131C560 Offset: 0x131AB60 VA: 0x18131C560
	public byte[] get_Hash() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x131C950 Offset: 0x131AF50 VA: 0x18131C950 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x131C9D0 Offset: 0x131AFD0 VA: 0x18131C9D0 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x131CA50 Offset: 0x131B050 VA: 0x18131CA50 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x131D1F0 Offset: 0x131B7F0 VA: 0x18131D1F0 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x131CC70 Offset: 0x131B270 VA: 0x18131CC70 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x131CCF0 Offset: 0x131B2F0 VA: 0x18131CCF0 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x131CD80 Offset: 0x131B380 VA: 0x18131CD80 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 15
	public virtual string get_SubjectName() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 16
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 17
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x12ECB50 Offset: 0x12EB150 VA: 0x1812ECB50
	public int get_Version() { }

	// RVA: 0x131C7B0 Offset: 0x131ADB0 VA: 0x18131C7B0
	public bool get_IsCurrent() { }

	// RVA: 0x131BE40 Offset: 0x131A440 VA: 0x18131BE40
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0x131BD70 Offset: 0x131A370 VA: 0x18131BD70
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x131BC40 Offset: 0x131A240 VA: 0x18131BC40
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x131BA60 Offset: 0x131A060 VA: 0x18131BA60
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x131C8C0 Offset: 0x131AEC0 VA: 0x18131C8C0
	public bool get_IsSelfSigned() { }

	// RVA: 0x131AEB0 Offset: 0x13194B0 VA: 0x18131AEB0 Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x131AFB0 Offset: 0x13195B0 VA: 0x18131AFB0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x131BF10 Offset: 0x131A510 VA: 0x18131BF10
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 12819
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }

	// RVA: 0x131ABB0 Offset: 0x13191B0 VA: 0x18131ABB0
	public X509Certificate get_Item(int index) { }

	// RVA: 0x131A7A0 Offset: 0x1318DA0 VA: 0x18131A7A0
	public int Add(X509Certificate value) { }

	// RVA: 0x131A6C0 Offset: 0x1318CC0 VA: 0x18131A6C0
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x131A8A0 Offset: 0x1318EA0 VA: 0x18131A8A0
	public bool Contains(X509Certificate value) { }

	// RVA: 0x131A8C0 Offset: 0x1318EC0 VA: 0x18131A8C0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x131AB70 Offset: 0x1319170 VA: 0x18131AB70 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x131A990 Offset: 0x1318F90 VA: 0x18131A990
	public int IndexOf(X509Certificate value) { }

	// RVA: 0x131A830 Offset: 0x1318E30 VA: 0x18131A830
	private bool Compare(byte[] array1, byte[] array2) { }
}

// Namespace: Mono.Security.X509
public class X509Chain // TypeDefIndex: 12820
{
	// Fields
	private X509CertificateCollection roots; // 0x10
	private X509CertificateCollection certs; // 0x18
	private X509Certificate _root; // 0x20
	private X509CertificateCollection _chain; // 0x28
	private X509ChainStatusFlags _status; // 0x30

	// Properties
	public X509CertificateCollection TrustAnchors { get; }

	// Methods

	// RVA: 0x131DF60 Offset: 0x131C560 VA: 0x18131DF60
	public void .ctor() { }

	// RVA: 0x131DFD0 Offset: 0x131C5D0 VA: 0x18131DFD0
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0x131DE20 Offset: 0x131C420 VA: 0x18131DE20
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0x131D240 Offset: 0x131B840 VA: 0x18131D240
	public bool Build(X509Certificate leaf) { }

	// RVA: 0x131DF10 Offset: 0x131C510 VA: 0x18131DF10
	public void Reset() { }

	// RVA: 0x131DC90 Offset: 0x131C290 VA: 0x18131DC90
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0x131D670 Offset: 0x131BC70 VA: 0x18131D670
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0x131D890 Offset: 0x131BE90 VA: 0x18131D890
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0x131DC50 Offset: 0x131C250 VA: 0x18131DC50
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0x131DAD0 Offset: 0x131C0D0 VA: 0x18131DAD0
	private bool IsParent(X509Certificate child, X509Certificate parent) { }
}

// Namespace: Mono.Security.X509
[Flags]
[Serializable]
public enum X509ChainStatusFlags // TypeDefIndex: 12821
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags UntrustedRoot = 32;
}

// Namespace: Mono.Security.X509
public class X509Extension // TypeDefIndex: 12822
{
	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x131FEC0 Offset: 0x131E4C0 VA: 0x18131FEC0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x13201E0 Offset: 0x131E7E0 VA: 0x1813201E0
	public void .ctor(X509Extension extension) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Oid() { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_Critical() { }

	// RVA: 0x1320360 Offset: 0x131E960 VA: 0x181320360
	public ASN1 get_Value() { }

	// RVA: 0x131FA30 Offset: 0x131E030 VA: 0x18131FA30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x131FCB0 Offset: 0x131E2B0 VA: 0x18131FCB0
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x131FB90 Offset: 0x131E190 VA: 0x18131FB90 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 12823
{
	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }

	// RVA: 0x131F6D0 Offset: 0x131DCD0 VA: 0x18131F6D0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x131F550 Offset: 0x131DB50 VA: 0x18131F550
	public int IndexOf(string oid) { }

	// RVA: 0x131AB70 Offset: 0x1319170 VA: 0x18131AB70 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x131F820 Offset: 0x131DE20 VA: 0x18131F820
	public X509Extension get_Item(string oid) { }
}

// Namespace: Mono.Security.X509
public class X509Store // TypeDefIndex: 12824
{
	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x13218C0 Offset: 0x131FEC0 VA: 0x1813218C0
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x1321920 Offset: 0x131FF20 VA: 0x181321920
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1321960 Offset: 0x131FF60 VA: 0x181321960
	public ArrayList get_Crls() { }

	// RVA: 0x1321760 Offset: 0x131FD60 VA: 0x181321760
	private byte[] Load(string filename) { }

	// RVA: 0x1321590 Offset: 0x131FB90 VA: 0x181321590
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x1321600 Offset: 0x131FC00 VA: 0x181321600
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x1321530 Offset: 0x131FB30 VA: 0x181321530
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x1321210 Offset: 0x131F810 VA: 0x181321210
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x13213E0 Offset: 0x131F9E0 VA: 0x1813213E0
	private ArrayList BuildCrlsCollection(string storeName) { }
}

// Namespace: Mono.Security.X509
public sealed class X509StoreManager // TypeDefIndex: 12825
{
	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static string _newUserPath; // 0x10
	private static string _newLocalMachinePath; // 0x18
	private static X509Stores _userStore; // 0x20
	private static X509Stores _machineStore; // 0x28

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	internal static string NewCurrentUserPath { get; }
	internal static string NewLocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }
	public static X509CertificateCollection TrustedRootCertificates { get; }

	// Methods

	// RVA: 0x13203A0 Offset: 0x131E9A0 VA: 0x1813203A0
	internal static string get_CurrentUserPath() { }

	// RVA: 0x13206A0 Offset: 0x131ECA0 VA: 0x1813206A0
	internal static string get_LocalMachinePath() { }

	// RVA: 0x13209C0 Offset: 0x131EFC0 VA: 0x1813209C0
	internal static string get_NewCurrentUserPath() { }

	// RVA: 0x1320AF0 Offset: 0x131F0F0 VA: 0x181320AF0
	internal static string get_NewLocalMachinePath() { }

	// RVA: 0x13204C0 Offset: 0x131EAC0 VA: 0x1813204C0
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x13207D0 Offset: 0x131EDD0 VA: 0x1813207D0
	public static X509Stores get_LocalMachine() { }

	// RVA: 0x1320C20 Offset: 0x131F220 VA: 0x181320C20
	public static X509CertificateCollection get_TrustedRootCertificates() { }
}

// Namespace: Mono.Security.X509
public class X509Stores // TypeDefIndex: 12826
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Properties
	public X509Store TrustedRoot { get; }

	// Methods

	// RVA: 0x110C350 Offset: 0x110A950 VA: 0x18110C350
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0x1321B20 Offset: 0x1320120 VA: 0x181321B20
	public X509Store get_TrustedRoot() { }

	// RVA: 0x13219F0 Offset: 0x131FFF0 VA: 0x1813219F0
	public X509Store Open(string storeName, bool create) { }
}

// Namespace: Mono.Security.X509
public class X520 // TypeDefIndex: 12844
{}

