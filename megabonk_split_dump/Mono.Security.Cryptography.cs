// Namespace: Mono.Security.Cryptography
internal sealed class KeyBuilder // TypeDefIndex: 97
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x13529D0 Offset: 0x1350FD0 VA: 0x1813529D0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1352960 Offset: 0x1350F60 VA: 0x181352960
	public static byte[] Key(int size) { }

	// RVA: 0x13528F0 Offset: 0x1350EF0 VA: 0x1813528F0
	public static byte[] IV(int size) { }
}

// Namespace: Mono.Security.Cryptography
internal class KeyPairPersistence // TypeDefIndex: 98
{
	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x1353930 Offset: 0x1351F30 VA: 0x181353930
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1353800 Offset: 0x1351E00 VA: 0x181353800
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x1353BD0 Offset: 0x13521D0 VA: 0x181353BD0
	public string get_Filename() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_KeyValue() { }

	// RVA: 0x13549A0 Offset: 0x1352FA0 VA: 0x1813549A0
	public void set_KeyValue(string value) { }

	// RVA: 0x1352F00 Offset: 0x1351500 VA: 0x181352F00
	public bool Load() { }

	// RVA: 0x1353390 Offset: 0x1351990 VA: 0x181353390
	public void Save() { }

	// RVA: 0x1353370 Offset: 0x1351970 VA: 0x181353370
	public void Remove() { }

	// RVA: 0x1354450 Offset: 0x1352A50 VA: 0x181354450
	private static string get_UserPath() { }

	// RVA: 0x1353EC0 Offset: 0x13524C0 VA: 0x181353EC0
	private static string get_MachinePath() { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	internal static bool _CanSecure(char* root) { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	internal static bool _ProtectUser(char* path) { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	internal static bool _ProtectMachine(char* path) { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	internal static bool _IsUserProtected(char* path) { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	internal static bool _IsMachineProtected(char* path) { }

	// RVA: 0x1352A50 Offset: 0x1351050 VA: 0x181352A50
	private static bool CanSecure(string path) { }

	// RVA: 0x1353270 Offset: 0x1351870 VA: 0x181353270
	private static bool ProtectUser(string path) { }

	// RVA: 0x1353170 Offset: 0x1351770 VA: 0x181353170
	private static bool ProtectMachine(string path) { }

	// RVA: 0x1352E00 Offset: 0x1351400 VA: 0x181352E00
	private static bool IsUserProtected(string path) { }

	// RVA: 0x1352D00 Offset: 0x1351300 VA: 0x181352D00
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x1353A60 Offset: 0x1352060 VA: 0x181353A60
	private bool get_CanChange() { }

	// RVA: 0x1354410 Offset: 0x1352A10 VA: 0x181354410
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x1354430 Offset: 0x1352A30 VA: 0x181354430
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x1353A70 Offset: 0x1352070 VA: 0x181353A70
	private string get_ContainerName() { }

	// RVA: 0x1352AE0 Offset: 0x13510E0 VA: 0x181352AE0
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1352B90 Offset: 0x1351190 VA: 0x181352B90
	private void FromXml(string xml) { }

	// RVA: 0x1353560 Offset: 0x1351B60 VA: 0x181353560
	private string ToXml() { }

	// RVA: 0x1353780 Offset: 0x1351D80 VA: 0x181353780
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class MD2 : HashAlgorithm // TypeDefIndex: 99
{
	// Methods

	// RVA: 0x132B580 Offset: 0x1329B80 VA: 0x18132B580
	protected void .ctor() { }

	// RVA: 0x1355080 Offset: 0x1353680 VA: 0x181355080
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
internal class MD2Managed : MD2 // TypeDefIndex: 100
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x1354E90 Offset: 0x1353490 VA: 0x181354E90
	private byte[] Padding(int nLength) { }

	// RVA: 0x1354FA0 Offset: 0x13535A0 VA: 0x181354FA0
	public void .ctor() { }

	// RVA: 0x132AFB0 Offset: 0x13295B0 VA: 0x18132AFB0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x13549C0 Offset: 0x1352FC0 VA: 0x1813549C0 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1354AC0 Offset: 0x13530C0 VA: 0x181354AC0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1354C10 Offset: 0x1353210 VA: 0x181354C10
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x1354F10 Offset: 0x1353510 VA: 0x181354F10
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class MD4 : HashAlgorithm // TypeDefIndex: 101
{
	// Methods

	// RVA: 0x132B580 Offset: 0x1329B80 VA: 0x18132B580
	protected void .ctor() { }

	// RVA: 0x13555D0 Offset: 0x1353BD0 VA: 0x1813555D0
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
internal class MD4Managed : MD4 // TypeDefIndex: 102
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x13554D0 Offset: 0x1353AD0 VA: 0x1813554D0
	public void .ctor() { }

	// RVA: 0x132BC90 Offset: 0x132A290 VA: 0x18132BC90 Slot: 18
	public override void Initialize() { }

	// RVA: 0x132B820 Offset: 0x1329E20 VA: 0x18132B820 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1355180 Offset: 0x1353780 VA: 0x181355180 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1355470 Offset: 0x1353A70 VA: 0x181355470
	private byte[] Padding(int nLength) { }

	// RVA: 0x132B760 Offset: 0x1329D60 VA: 0x18132B760
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x132B7C0 Offset: 0x1329DC0 VA: 0x18132B7C0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x132B810 Offset: 0x1329E10 VA: 0x18132B810
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x132C7F0 Offset: 0x132ADF0 VA: 0x18132C7F0
	private uint ROL(uint x, byte n) { }

	// RVA: 0x132B720 Offset: 0x1329D20 VA: 0x18132B720
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x132B770 Offset: 0x1329D70 VA: 0x18132B770
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x132B7D0 Offset: 0x1329DD0 VA: 0x18132B7D0
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x132B650 Offset: 0x1329C50 VA: 0x18132B650
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x132B5A0 Offset: 0x1329BA0 VA: 0x18132B5A0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x132BD60 Offset: 0x132A360 VA: 0x18132BD60
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

// Namespace: Mono.Security.Cryptography
internal sealed class PKCS1 // TypeDefIndex: 103
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x132E4A0 Offset: 0x132CAA0 VA: 0x18132E4A0
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x1356EA0 Offset: 0x13554A0 VA: 0x181356EA0
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x1356F20 Offset: 0x1355520 VA: 0x181356F20
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x132F370 Offset: 0x132D970 VA: 0x18132F370
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x1357480 Offset: 0x1355A80 VA: 0x181357480
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature) { }

	// RVA: 0x1357360 Offset: 0x1355960 VA: 0x181357360
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x1357000 Offset: 0x1355600 VA: 0x181357000
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x1356B50 Offset: 0x1355150 VA: 0x181356B50
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x13564B0 Offset: 0x1354AB0 VA: 0x1813564B0
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x1357510 Offset: 0x1355B10 VA: 0x181357510
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
internal class RSAManaged : RSA // TypeDefIndex: 105
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1359E40 Offset: 0x1358440 VA: 0x181359E40
	public void .ctor(int keySize) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1358AB0 Offset: 0x13570B0 VA: 0x181358AB0
	private void GenerateKeyPair() { }

	// RVA: 0x1359FD0 Offset: 0x13585D0 VA: 0x181359FD0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x135A090 Offset: 0x1358690 VA: 0x18135A090
	public bool get_PublicOnly() { }

	// RVA: 0x13584B0 Offset: 0x1356AB0 VA: 0x1813584B0 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1358640 Offset: 0x1356C40 VA: 0x181358640 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x13590B0 Offset: 0x13576B0 VA: 0x1813590B0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1358060 Offset: 0x1356660 VA: 0x181358060 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x1359F30 Offset: 0x1358530 VA: 0x181359F30
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x135A130 Offset: 0x1358730 VA: 0x18135A130
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x13598C0 Offset: 0x1357EC0 VA: 0x1813598C0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x1359000 Offset: 0x1357600 VA: 0x181359000
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 106
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x136AA70 Offset: 0x1369070 VA: 0x18136AA70
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x1369F80 Offset: 0x1368580 VA: 0x181369F80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x136A300 Offset: 0x1368900 VA: 0x18136A300 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13698E0 Offset: 0x1367EE0 VA: 0x1813698E0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x136A890 Offset: 0x1368E90 VA: 0x18136A890 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x13693E0 Offset: 0x13679E0 VA: 0x1813693E0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x1369520 Offset: 0x1367B20 VA: 0x181369520 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x136A1E0 Offset: 0x13687E0 VA: 0x18136A1E0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x13696F0 Offset: 0x1367CF0 VA: 0x1813696F0 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x1369740 Offset: 0x1367D40 VA: 0x181369740
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x136A4A0 Offset: 0x1368AA0 VA: 0x18136A4A0 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x136ADC0 Offset: 0x13693C0 VA: 0x18136ADC0
	private bool get_KeepLastBlock() { }

	// RVA: 0x1369FF0 Offset: 0x13685F0 VA: 0x181369FF0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x136A230 Offset: 0x1368830 VA: 0x18136A230
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x136A360 Offset: 0x1368960 VA: 0x18136A360
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x1369C60 Offset: 0x1368260 VA: 0x181369C60 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1369950 Offset: 0x1367F50 VA: 0x181369950 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x136A7C0 Offset: 0x1368DC0 VA: 0x18136A7C0 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

// Namespace: Mono.Security.Cryptography
internal class DSAManaged : DSA // TypeDefIndex: 108
{
	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGenerated]
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1350520 Offset: 0x134EB20 VA: 0x181350520
	public void .ctor(int dwKeySize) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x134F9D0 Offset: 0x134DFD0 VA: 0x18134F9D0
	private void Generate() { }

	// RVA: 0x134EE10 Offset: 0x134D410 VA: 0x18134EE10
	private void GenerateKeyPair() { }

	// RVA: 0x1350690 Offset: 0x134EC90 VA: 0x181350690
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x134F060 Offset: 0x134D660 VA: 0x18134F060
	private void GenerateParams(int keyLength) { }

	// RVA: 0x13507A0 Offset: 0x134EDA0 VA: 0x1813507A0
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x1350710 Offset: 0x134ED10 VA: 0x181350710 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1350740 Offset: 0x134ED40 VA: 0x181350740
	public bool get_PublicOnly() { }

	// RVA: 0x134FEB0 Offset: 0x134E4B0 VA: 0x18134FEB0
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x134EA60 Offset: 0x134D060 VA: 0x18134EA60 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x134FA20 Offset: 0x134E020 VA: 0x18134FA20 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x134FF60 Offset: 0x134E560 VA: 0x18134FF60 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x134E690 Offset: 0x134CC90 VA: 0x18134E690 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x13505F0 Offset: 0x134EBF0 VA: 0x1813505F0
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x13507E0 Offset: 0x134EDE0 VA: 0x1813507E0
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class CryptoConvert // TypeDefIndex: 12872
{
	// Methods

	// RVA: 0x13280B0 Offset: 0x13266B0 VA: 0x1813280B0
	public static string ToHex(byte[] input) { }

	// RVA: 0x1327DC0 Offset: 0x13263C0 VA: 0x181327DC0
	private static byte FromHexChar(char c) { }

	// RVA: 0x1327E50 Offset: 0x1326450 VA: 0x181327E50
	public static byte[] FromHex(string hex) { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD2 : HashAlgorithm // TypeDefIndex: 12873
{
	// Methods

	// RVA: 0x132B580 Offset: 0x1329B80 VA: 0x18132B580
	protected void .ctor() { }

	// RVA: 0x132B480 Offset: 0x1329A80 VA: 0x18132B480
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD2Managed : MD2 // TypeDefIndex: 12874
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x132B290 Offset: 0x1329890 VA: 0x18132B290
	private byte[] Padding(int nLength) { }

	// RVA: 0x132B3A0 Offset: 0x13299A0 VA: 0x18132B3A0
	public void .ctor() { }

	// RVA: 0x132AFB0 Offset: 0x13295B0 VA: 0x18132AFB0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x132AD60 Offset: 0x1329360 VA: 0x18132AD60 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x132AE60 Offset: 0x1329460 VA: 0x18132AE60 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x132B010 Offset: 0x1329610 VA: 0x18132B010
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x132B310 Offset: 0x1329910 VA: 0x18132B310
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD4 : HashAlgorithm // TypeDefIndex: 12875
{
	// Methods

	// RVA: 0x132B580 Offset: 0x1329B80 VA: 0x18132B580
	protected void .ctor() { }

	// RVA: 0x132C910 Offset: 0x132AF10 VA: 0x18132C910
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD4Managed : MD4 // TypeDefIndex: 12876
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x132C810 Offset: 0x132AE10 VA: 0x18132C810
	public void .ctor() { }

	// RVA: 0x132BC90 Offset: 0x132A290 VA: 0x18132BC90 Slot: 18
	public override void Initialize() { }

	// RVA: 0x132B820 Offset: 0x1329E20 VA: 0x18132B820 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x132B9A0 Offset: 0x1329FA0 VA: 0x18132B9A0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x132C790 Offset: 0x132AD90 VA: 0x18132C790
	private byte[] Padding(int nLength) { }

	// RVA: 0x132B760 Offset: 0x1329D60 VA: 0x18132B760
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x132B7C0 Offset: 0x1329DC0 VA: 0x18132B7C0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x132B810 Offset: 0x1329E10 VA: 0x18132B810
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x132C7F0 Offset: 0x132ADF0 VA: 0x18132C7F0
	private uint ROL(uint x, byte n) { }

	// RVA: 0x132B720 Offset: 0x1329D20 VA: 0x18132B720
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x132B770 Offset: 0x1329D70 VA: 0x18132B770
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x132B7D0 Offset: 0x1329DD0 VA: 0x18132B7D0
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x132B650 Offset: 0x1329C50 VA: 0x18132B650
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x132B5A0 Offset: 0x1329BA0 VA: 0x18132B5A0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x132BD60 Offset: 0x132A360 VA: 0x18132BD60
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS1 // TypeDefIndex: 12877
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x132E4A0 Offset: 0x132CAA0 VA: 0x18132E4A0
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x132F210 Offset: 0x132D810 VA: 0x18132F210
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x132F290 Offset: 0x132D890 VA: 0x18132F290
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x132F370 Offset: 0x132D970 VA: 0x18132F370
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x132F3A0 Offset: 0x132D9A0 VA: 0x18132F3A0
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x132EAF0 Offset: 0x132D0F0 VA: 0x18132EAF0
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x132EE40 Offset: 0x132D440 VA: 0x18132EE40
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x132EA90 Offset: 0x132D090 VA: 0x18132EA90
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x132E530 Offset: 0x132CB30 VA: 0x18132E530
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x132F700 Offset: 0x132DD00 VA: 0x18132F700
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8 // TypeDefIndex: 12880
{}

// Namespace: Mono.Security.Cryptography
public class RSAManaged : RSA // TypeDefIndex: 12882
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x13337C0 Offset: 0x1331DC0 VA: 0x1813337C0
	public void .ctor() { }

	// RVA: 0x13338B0 Offset: 0x1331EB0 VA: 0x1813338B0
	public void .ctor(int keySize) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1332430 Offset: 0x1330A30 VA: 0x181332430
	private void GenerateKeyPair() { }

	// RVA: 0x13339A0 Offset: 0x1331FA0 VA: 0x1813339A0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1333A60 Offset: 0x1332060 VA: 0x181333A60
	public bool get_PublicOnly() { }

	// RVA: 0x1331D60 Offset: 0x1330360 VA: 0x181331D60 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1331F50 Offset: 0x1330550 VA: 0x181331F50 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1332A30 Offset: 0x1331030 VA: 0x181332A30 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1331910 Offset: 0x132FF10 VA: 0x181331910 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1333240 Offset: 0x1331840 VA: 0x181333240 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x1332980 Offset: 0x1330F80 VA: 0x181332980
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

