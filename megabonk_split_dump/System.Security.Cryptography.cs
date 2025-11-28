// Namespace: System.Security.Cryptography
public class CryptoStream : Stream, IDisposable // TypeDefIndex: 733
{
	// Fields
	private readonly Stream _stream; // 0x28
	private readonly ICryptoTransform _transform; // 0x30
	private readonly CryptoStreamMode _transformMode; // 0x38
	private byte[] _inputBuffer; // 0x40
	private int _inputBufferIndex; // 0x48
	private int _inputBlockSize; // 0x4C
	private byte[] _outputBuffer; // 0x50
	private int _outputBufferIndex; // 0x58
	private int _outputBlockSize; // 0x5C
	private bool _canRead; // 0x60
	private bool _canWrite; // 0x61
	private bool _finalBlockTransformed; // 0x62
	private SemaphoreSlim _lazyAsyncActiveSemaphore; // 0x68
	private readonly bool _leaveOpen; // 0x70

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }
	private SemaphoreSlim AsyncActiveSemaphore { get; }

	// Methods

	// RVA: 0x1380CE0 Offset: 0x137F2E0 VA: 0x181380CE0
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x13809E0 Offset: 0x137EFE0 VA: 0x1813809E0
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1380E10 Offset: 0x137F410 VA: 0x181380E10 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1380E30 Offset: 0x137F430 VA: 0x181380E30 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1380E80 Offset: 0x137F480 VA: 0x181380E80 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1380ED0 Offset: 0x137F4D0 VA: 0x181380ED0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1380E20 Offset: 0x137F420 VA: 0x181380E20
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x137FBF0 Offset: 0x137E1F0 VA: 0x18137FBF0
	public void FlushFinalBlock() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void Flush() { }

	// RVA: 0x137FA80 Offset: 0x137E080 VA: 0x18137FA80 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1380400 Offset: 0x137EA00 VA: 0x181380400 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1380140 Offset: 0x137E740 VA: 0x181380140 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x137F4D0 Offset: 0x137DAD0 VA: 0x18137F4D0 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x137FA30 Offset: 0x137E030 VA: 0x18137FA30 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncInternal>d__37))]
	// RVA: 0x137FFF0 Offset: 0x137E5F0 VA: 0x18137FFF0
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x13802A0 Offset: 0x137E8A0 VA: 0x1813802A0 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x1380830 Offset: 0x137EE30 VA: 0x181380830 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x1380320 Offset: 0x137E920 VA: 0x181380320 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x137F630 Offset: 0x137DC30 VA: 0x18137F630
	private void CheckReadArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncCore>d__42))]
	// RVA: 0x137FE90 Offset: 0x137E490 VA: 0x18137FE90
	private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x13806D0 Offset: 0x137ECD0 VA: 0x1813806D0 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x137F580 Offset: 0x137DB80 VA: 0x18137F580 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x137FA70 Offset: 0x137E070 VA: 0x18137FA70 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncInternal>d__46))]
	// RVA: 0x1380590 Offset: 0x137EB90 VA: 0x181380590
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1380880 Offset: 0x137EE80 VA: 0x181380880 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x137F7E0 Offset: 0x137DDE0 VA: 0x18137F7E0
	private void CheckWriteArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncCore>d__49))]
	// RVA: 0x1380450 Offset: 0x137EA50 VA: 0x181380450
	private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0xD13740 Offset: 0xD11D40 VA: 0x180D13740
	public void Clear() { }

	// RVA: 0x137F990 Offset: 0x137DF90 VA: 0x18137F990 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x137FDD0 Offset: 0x137E3D0 VA: 0x18137FDD0
	private void InitializeBuffer() { }

	// RVA: 0x1380D00 Offset: 0x137F300 VA: 0x181380D00
	private SemaphoreSlim get_AsyncActiveSemaphore() { }
}

// Namespace: System.Security.Cryptography
public enum CryptoStreamMode // TypeDefIndex: 734
{
	// Fields
	public int value__; // 0x0
	public const CryptoStreamMode Read = 0;
	public const CryptoStreamMode Write = 1;
}

// Namespace: System.Security.Cryptography
public static class CryptographicOperations // TypeDefIndex: 735
{
	// Methods

	// RVA: 0x13976C0 Offset: 0x1395CC0 VA: 0x1813976C0
	public static void ZeroMemory(Span<byte> buffer) { }
}

// Namespace: System.Security.Cryptography
public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 736
{
	// Fields
	private bool _disposed; // 0x10
	protected int HashSizeValue; // 0x14
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x139B760 Offset: 0x1399D60 VA: 0x18139B760
	public static HashAlgorithm Create(string hashName) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x139BC10 Offset: 0x139A210 VA: 0x18139BC10 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x139B4A0 Offset: 0x1399AA0 VA: 0x18139B4A0
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x139B570 Offset: 0x1399B70 VA: 0x18139B570
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x139B3A0 Offset: 0x13999A0 VA: 0x18139B3A0
	private byte[] CaptureHashCodeAndReinitialize() { }

	// RVA: 0x139B7F0 Offset: 0x1399DF0 VA: 0x18139B7F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x139B460 Offset: 0x1399A60 VA: 0x18139B460
	public void Clear() { }

	// RVA: 0x139B7E0 Offset: 0x1399DE0 VA: 0x18139B7E0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 13
	public virtual int get_InputBlockSize() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 14
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 15
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x139B850 Offset: 0x1399E50 VA: 0x18139B850 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x139B8F0 Offset: 0x1399EF0 VA: 0x18139B8F0 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x139BA50 Offset: 0x139A050 VA: 0x18139BA50
	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract byte[] HashFinal();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Initialize();
}

// Namespace: System.Security.Cryptography
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public abstract class Aes : SymmetricAlgorithm // TypeDefIndex: 737
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Methods

	// RVA: 0x1397230 Offset: 0x1395830 VA: 0x181397230
	protected void .ctor() { }

	// RVA: 0x1396F80 Offset: 0x1395580 VA: 0x181396F80
	public static Aes Create() { }

	// RVA: 0x1396E80 Offset: 0x1395480 VA: 0x181396E80
	public static Aes Create(string algorithmName) { }

	// RVA: 0x13970C0 Offset: 0x13956C0 VA: 0x1813970C0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 738
{
	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x13972E0 Offset: 0x13958E0 VA: 0x1813972E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x13972E0 Offset: 0x13958E0 VA: 0x1813972E0
	public void Clear() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x13973C0 Offset: 0x13959C0 VA: 0x1813973C0 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x1397340 Offset: 0x1395940 VA: 0x181397340 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x1397380 Offset: 0x1395980 VA: 0x181397380 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricSignatureDeformatter // TypeDefIndex: 739
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetKey(AsymmetricAlgorithm key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetHashAlgorithm(string strName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricSignatureFormatter // TypeDefIndex: 740
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public enum CipherMode // TypeDefIndex: 741
{
	// Fields
	public int value__; // 0x0
	public const CipherMode CBC = 1;
	public const CipherMode ECB = 2;
	public const CipherMode OFB = 3;
	public const CipherMode CFB = 4;
	public const CipherMode CTS = 5;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public enum PaddingMode // TypeDefIndex: 742
{
	// Fields
	public int value__; // 0x0
	public const PaddingMode None = 1;
	public const PaddingMode PKCS7 = 2;
	public const PaddingMode Zeros = 3;
	public const PaddingMode ANSIX923 = 4;
	public const PaddingMode ISO10126 = 5;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class KeySizes // TypeDefIndex: 743
{
	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_MinSize() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_MaxSize() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_SkipSize() { }

	// RVA: 0x139BDD0 Offset: 0x139A3D0 VA: 0x18139BDD0
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x139BDA0 Offset: 0x139A3A0 VA: 0x18139BDA0
	internal bool IsLegal(int keySize) { }

	// RVA: 0x139BD20 Offset: 0x139A320 VA: 0x18139BD20
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public class CryptographicException : SystemException // TypeDefIndex: 744
{
	// Methods

	// RVA: 0x1397630 Offset: 0x1395C30 VA: 0x181397630
	public void .ctor() { }

	// RVA: 0x1397690 Offset: 0x1395C90 VA: 0x181397690
	public void .ctor(string message) { }

	// RVA: 0x1397570 Offset: 0x1395B70 VA: 0x181397570
	public void .ctor(string format, string insert) { }

	// RVA: 0x1397600 Offset: 0x1395C00 VA: 0x181397600
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1397510 Offset: 0x1395B10 VA: 0x181397510
	public void .ctor(int hr) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public class CryptographicUnexpectedOperationException : CryptographicException // TypeDefIndex: 745
{
	// Methods

	// RVA: 0x1397710 Offset: 0x1395D10 VA: 0x181397710
	public void .ctor() { }

	// RVA: 0x1397780 Offset: 0x1395D80 VA: 0x181397780
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.Cryptography
[Flags]
[ComVisible(True)]
[Serializable]
public enum CspProviderFlags // TypeDefIndex: 746
{
	// Fields
	public int value__; // 0x0
	public const CspProviderFlags NoFlags = 0;
	public const CspProviderFlags UseMachineKeyStore = 1;
	public const CspProviderFlags UseDefaultKeyContainer = 2;
	public const CspProviderFlags UseNonExportableKey = 4;
	public const CspProviderFlags UseExistingKey = 8;
	public const CspProviderFlags UseArchivableKey = 16;
	public const CspProviderFlags UseUserProtectedKey = 32;
	public const CspProviderFlags NoPrompt = 64;
	public const CspProviderFlags CreateEphemeralKey = 128;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class CspParameters // TypeDefIndex: 747
{
	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public CspProviderFlags get_Flags() { }

	// RVA: 0x1397980 Offset: 0x1395F80 VA: 0x181397980
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x1397820 Offset: 0x1395E20 VA: 0x181397820
	public void .ctor() { }

	// RVA: 0x13977C0 Offset: 0x1395DC0 VA: 0x1813977C0
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x1397900 Offset: 0x1395F00 VA: 0x181397900
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x1397880 Offset: 0x1395E80 VA: 0x181397880
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 748
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x13986C0 Offset: 0x1396CC0 VA: 0x1813986C0
	protected void .ctor() { }

	// RVA: 0x1398760 Offset: 0x1396D60 VA: 0x181398760 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1398850 Offset: 0x1396E50 VA: 0x181398850 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1398050 Offset: 0x1396650 VA: 0x181398050
	public static DES Create() { }

	// RVA: 0x1398390 Offset: 0x1396990 VA: 0x181398390
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x13981E0 Offset: 0x13967E0 VA: 0x1813981E0
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x13981D0 Offset: 0x13967D0 VA: 0x1813981D0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x13984B0 Offset: 0x1396AB0 VA: 0x1813984B0
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x1398560 Offset: 0x1396B60 VA: 0x181398560
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DESCryptoServiceProvider : DES // TypeDefIndex: 749
{
	// Methods

	// RVA: 0x1397F00 Offset: 0x1396500 VA: 0x181397F00
	public void .ctor() { }

	// RVA: 0x1397C00 Offset: 0x1396200 VA: 0x181397C00 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1397A60 Offset: 0x1396060 VA: 0x181397A60 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1397E20 Offset: 0x1396420 VA: 0x181397E20 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1397DA0 Offset: 0x13963A0 VA: 0x181397DA0 Slot: 25
	public override void GenerateIV() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public struct DSAParameters // TypeDefIndex: 750
{
	// Fields
	public byte[] P; // 0x0
	public byte[] Q; // 0x8
	public byte[] G; // 0x10
	public byte[] Y; // 0x18
	public byte[] J; // 0x20
	public byte[] X; // 0x28
	public byte[] Seed; // 0x30
	public int Counter; // 0x38
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 751
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1399070 Offset: 0x1397670 VA: 0x181399070
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x13990C0 Offset: 0x13976C0 VA: 0x1813990C0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1399A90 Offset: 0x1398090 VA: 0x181399A90 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 752
{
	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x1398F70 Offset: 0x1397570 VA: 0x181398F70
	public void .ctor() { }

	// RVA: 0x1398E00 Offset: 0x1397400 VA: 0x181398E00
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x1398BC0 Offset: 0x13971C0 VA: 0x181398BC0 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x1398B00 Offset: 0x1397100 VA: 0x181398B00 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x1398CD0 Offset: 0x13972D0 VA: 0x181398CD0 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class DSASignatureFormatter : AsymmetricSignatureFormatter // TypeDefIndex: 753
{
	// Fields
	private string _oid; // 0x10

	// Methods

	// RVA: 0x1398FF0 Offset: 0x13975F0 VA: 0x181398FF0
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 754
{
	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	protected int get_BlockSizeValue() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x139B130 Offset: 0x1399730 VA: 0x18139B130
	private void UpdateIOPadBuffers() { }

	// RVA: 0x139AF60 Offset: 0x1399560 VA: 0x18139AF60
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x139B2A0 Offset: 0x13998A0 VA: 0x18139B2A0 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x139B320 Offset: 0x1399920 VA: 0x18139B320 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x139AA30 Offset: 0x1399030 VA: 0x18139AA30
	public static HMAC Create() { }

	// RVA: 0x139B0E0 Offset: 0x13996E0 VA: 0x18139B0E0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x139AC30 Offset: 0x1399230 VA: 0x18139AC30 Slot: 16
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x139AD40 Offset: 0x1399340 VA: 0x18139AD40 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x139AB50 Offset: 0x1399150 VA: 0x18139AB50 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x139B290 Offset: 0x1399890 VA: 0x18139B290
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACMD5 : HMAC // TypeDefIndex: 755
{
	// Methods

	// RVA: 0x1399F50 Offset: 0x1398550 VA: 0x181399F50
	public void .ctor() { }

	// RVA: 0x1399E70 Offset: 0x1398470 VA: 0x181399E70
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACRIPEMD160 : HMAC // TypeDefIndex: 756
{
	// Methods

	// RVA: 0x139A040 Offset: 0x1398640 VA: 0x18139A040
	public void .ctor() { }

	// RVA: 0x139A130 Offset: 0x1398730 VA: 0x18139A130
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA1 : HMAC // TypeDefIndex: 757
{
	// Methods

	// RVA: 0x139A2F0 Offset: 0x13988F0 VA: 0x18139A2F0
	public void .ctor() { }

	// RVA: 0x139A210 Offset: 0x1398810 VA: 0x18139A210
	public void .ctor(byte[] key) { }

	// RVA: 0x139A210 Offset: 0x1398810 VA: 0x18139A210
	public void .ctor(byte[] key, bool useManagedSha1) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA256 : HMAC // TypeDefIndex: 758
{
	// Methods

	// RVA: 0x139A3E0 Offset: 0x13989E0 VA: 0x18139A3E0
	public void .ctor() { }

	// RVA: 0x139A4D0 Offset: 0x1398AD0 VA: 0x18139A4D0
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA384 : HMAC // TypeDefIndex: 759
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x68

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x139A5B0 Offset: 0x1398BB0 VA: 0x18139A5B0
	public void .ctor() { }

	// RVA: 0x139A6D0 Offset: 0x1398CD0 VA: 0x18139A6D0
	public void .ctor(byte[] key) { }

	// RVA: 0x139A7E0 Offset: 0x1398DE0 VA: 0x18139A7E0
	private int get_BlockSize() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA512 : HMAC // TypeDefIndex: 760
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x68

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x139A910 Offset: 0x1398F10 VA: 0x18139A910
	public void .ctor() { }

	// RVA: 0x139A800 Offset: 0x1398E00 VA: 0x18139A800
	public void .ctor(byte[] key) { }

	// RVA: 0x139A7E0 Offset: 0x1398DE0 VA: 0x18139A7E0
	private int get_BlockSize() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public interface ICryptoTransform : IDisposable // TypeDefIndex: 761
{
	// Properties
	public abstract int InputBlockSize { get; }
	public abstract int OutputBlockSize { get; }
	public abstract bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_InputBlockSize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_OutputBlockSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanTransformMultipleBlocks();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 762
{
	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x139BE20 Offset: 0x139A420 VA: 0x18139BE20 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x139BE70 Offset: 0x139A470 VA: 0x18139BE70 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x139BEF0 Offset: 0x139A4F0 VA: 0x18139BEF0 Slot: 20
	public virtual void set_Key(byte[] value) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 763
{
	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x139C4A0 Offset: 0x139AAA0 VA: 0x18139C4A0
	public void .ctor() { }

	// RVA: 0x139C480 Offset: 0x139AA80 VA: 0x18139C480 Slot: 18
	public override void Initialize() { }

	// RVA: 0x139C0E0 Offset: 0x139A6E0 VA: 0x18139C0E0 Slot: 16
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x139C290 Offset: 0x139A890 VA: 0x18139C290 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x139C010 Offset: 0x139A610 VA: 0x18139C010 Slot: 12
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
internal sealed class TailStream : Stream // TypeDefIndex: 764
{
	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x13A5330 Offset: 0x13A3930 VA: 0x1813A5330
	public void .ctor(int bufferSize) { }

	// RVA: 0xD13740 Offset: 0xD11D40 VA: 0x180D13740
	public void Clear() { }

	// RVA: 0x13A5040 Offset: 0x13A3640 VA: 0x1813A5040 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13A53C0 Offset: 0x13A39C0 VA: 0x1813A53C0
	public byte[] get_Buffer() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x13A5440 Offset: 0x13A3A40 VA: 0x1813A5440 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x13A5450 Offset: 0x13A3A50 VA: 0x1813A5450 Slot: 11
	public override long get_Length() { }

	// RVA: 0x13A54B0 Offset: 0x13A3AB0 VA: 0x1813A54B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x13A5510 Offset: 0x13A3B10 VA: 0x1813A5510 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void Flush() { }

	// RVA: 0x13A5150 Offset: 0x13A3750 VA: 0x1813A5150 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x13A50F0 Offset: 0x13A36F0 VA: 0x1813A50F0 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A51B0 Offset: 0x13A37B0 VA: 0x1813A51B0 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class MD5 : HashAlgorithm // TypeDefIndex: 765
{
	// Methods

	// RVA: 0x139C670 Offset: 0x139AC70 VA: 0x18139C670
	protected void .ctor() { }

	// RVA: 0x139C620 Offset: 0x139AC20 VA: 0x18139C620
	public static MD5 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 766
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x13A0FF0 Offset: 0x139F5F0 VA: 0x1813A0FF0
	public static RandomNumberGenerator Create() { }

	// RVA: 0x13A1040 Offset: 0x139F640 VA: 0x1813A1040 Slot: 4
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 767
{
	// Fields
	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x139CDA0 Offset: 0x139B3A0 VA: 0x18139CDA0
	protected void .ctor() { }

	// RVA: 0x139CE40 Offset: 0x139B440 VA: 0x18139CE40 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x139CE50 Offset: 0x139B450 VA: 0x18139CE50 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x139CC30 Offset: 0x139B230 VA: 0x18139CC30
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 768
{
	// Fields
	private bool m_use40bitSalt; // 0x50
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x139CA10 Offset: 0x139B010 VA: 0x18139CA10
	public void .ctor() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x139C760 Offset: 0x139AD60 VA: 0x18139C760 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x139C690 Offset: 0x139AC90 VA: 0x18139C690 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x139C8B0 Offset: 0x139AEB0 VA: 0x18139C8B0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x139C830 Offset: 0x139AE30 VA: 0x18139C830 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x139C930 Offset: 0x139AF30 VA: 0x18139C930
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class Rijndael : SymmetricAlgorithm // TypeDefIndex: 769
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Methods

	// RVA: 0x13A4FA0 Offset: 0x13A35A0 VA: 0x1813A4FA0
	protected void .ctor() { }

	// RVA: 0x13A4E30 Offset: 0x13A3430 VA: 0x1813A4E30
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 770
{
	// Methods

	// RVA: 0x13A4CD0 Offset: 0x13A32D0 VA: 0x1813A4CD0
	public void .ctor() { }

	// RVA: 0x13A4A70 Offset: 0x13A3070 VA: 0x1813A4A70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x13A4980 Offset: 0x13A2F80 VA: 0x1813A4980 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x13A4BA0 Offset: 0x13A31A0 VA: 0x1813A4BA0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x13A4B60 Offset: 0x13A3160 VA: 0x1813A4B60 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x13A4BE0 Offset: 0x13A31E0 VA: 0x1813A4BE0
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }
}

// Namespace: System.Security.Cryptography
[Serializable]
internal enum RijndaelManagedTransformMode // TypeDefIndex: 771
{
	// Fields
	public int value__; // 0x0
	public const RijndaelManagedTransformMode Encrypt = 0;
	public const RijndaelManagedTransformMode Decrypt = 1;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 772
{
	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x13A42D0 Offset: 0x13A28D0 VA: 0x1813A42D0
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x13A20C0 Offset: 0x13A06C0 VA: 0x1813A20C0 Slot: 9
	public void Dispose() { }

	// RVA: 0x13A21E0 Offset: 0x13A07E0 VA: 0x1813A21E0
	private void Dispose(bool disposing) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x13A38A0 Offset: 0x13A1EA0 VA: 0x1813A38A0 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x13A3C90 Offset: 0x13A2290 VA: 0x1813A3C90 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x13A3740 Offset: 0x13A1D40 VA: 0x1813A3740
	public void Reset() { }

	// RVA: 0x13A2510 Offset: 0x13A0B10 VA: 0x1813A2510
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x13A12D0 Offset: 0x139F8D0 VA: 0x1813A12D0
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x13A2300 Offset: 0x13A0900 VA: 0x1813A2300
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x13A10A0 Offset: 0x139F6A0 VA: 0x1813A10A0
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x13A3130 Offset: 0x13A1730 VA: 0x1813A3130
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x13A4950 Offset: 0x13A2F50 VA: 0x1813A4950
	private static int rot1(int val) { }

	// RVA: 0x13A4960 Offset: 0x13A2F60 VA: 0x1813A4960
	private static int rot2(int val) { }

	// RVA: 0x13A4970 Offset: 0x13A2F70 VA: 0x1813A4970
	private static int rot3(int val) { }

	// RVA: 0x13A37C0 Offset: 0x13A1DC0 VA: 0x1813A37C0
	private static int SubWord(int a) { }

	// RVA: 0x13A3710 Offset: 0x13A1D10 VA: 0x1813A3710
	private static int MulX(int x) { }

	// RVA: 0x13A4060 Offset: 0x13A2660 VA: 0x1813A4060
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RIPEMD160 : HashAlgorithm // TypeDefIndex: 773
{
	// Methods

	// RVA: 0x139F5C0 Offset: 0x139DBC0 VA: 0x18139F5C0
	protected void .ctor() { }

	// RVA: 0x139F570 Offset: 0x139DB70 VA: 0x18139F570
	public static RIPEMD160 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 774
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x139F430 Offset: 0x139DA30 VA: 0x18139F430
	public void .ctor() { }

	// RVA: 0x139CFC0 Offset: 0x139B5C0 VA: 0x18139CFC0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x139CF00 Offset: 0x139B500 VA: 0x18139CF00 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x139CF10 Offset: 0x139B510 VA: 0x18139CF10 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x139CF30 Offset: 0x139B530 VA: 0x18139CF30
	private void InitializeState() { }

	// RVA: 0x139F290 Offset: 0x139D890 VA: 0x18139F290
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x139F0D0 Offset: 0x139D6D0 VA: 0x18139F0D0
	private byte[] _EndHash() { }

	// RVA: 0x139D020 Offset: 0x139B620 VA: 0x18139D020
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x139CED0 Offset: 0x139B4D0 VA: 0x18139CED0
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x139CEE0 Offset: 0x139B4E0 VA: 0x18139CEE0
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x139CEF0 Offset: 0x139B4F0 VA: 0x18139CEF0
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x139CF20 Offset: 0x139B520 VA: 0x18139CF20
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x139D010 Offset: 0x139B610 VA: 0x18139D010
	private static uint J(uint x, uint y, uint z) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public struct RSAParameters // TypeDefIndex: 775
{
	// Fields
	public byte[] Exponent; // 0x0
	public byte[] Modulus; // 0x8
	public byte[] P; // 0x10
	public byte[] Q; // 0x18
	public byte[] DP; // 0x20
	public byte[] DQ; // 0x28
	public byte[] InverseQ; // 0x30
	public byte[] D; // 0x38
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 776
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x13A0560 Offset: 0x139EB60 VA: 0x1813A0560
	public static RSA Create() { }

	// RVA: 0x13A05C0 Offset: 0x139EBC0 VA: 0x1813A05C0 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x13A0620 Offset: 0x139EC20 VA: 0x1813A0620 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x13A0C50 Offset: 0x139F250 VA: 0x1813A0C50 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 777
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x13A0510 Offset: 0x139EB10 VA: 0x1813A0510
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x13A0490 Offset: 0x139EA90 VA: 0x1813A0490
	public void .ctor() { }

	// RVA: 0x13A0340 Offset: 0x139E940 VA: 0x1813A0340
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x13A01B0 Offset: 0x139E7B0 VA: 0x1813A01B0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x13A01F0 Offset: 0x139E7F0 VA: 0x1813A01F0
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x139F5E0 Offset: 0x139DBE0 VA: 0x18139F5E0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x139F870 Offset: 0x139DE70 VA: 0x18139F870
	private void Common(CspParameters p) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13A04C0 Offset: 0x139EAC0 VA: 0x1813A04C0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x13A04F0 Offset: 0x139EAF0 VA: 0x1813A04F0
	public bool get_PublicOnly() { }

	// RVA: 0x139F9E0 Offset: 0x139DFE0 VA: 0x18139F9E0 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x139FA10 Offset: 0x139E010 VA: 0x18139FA10 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x139FD90 Offset: 0x139E390 VA: 0x18139FD90 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x139FBE0 Offset: 0x139E1E0 VA: 0x18139FBE0
	private string GetHashNameFromOID(string oid) { }

	// RVA: 0x139FE70 Offset: 0x139E470 VA: 0x18139FE70
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { }

	// RVA: 0x139F990 Offset: 0x139DF90 VA: 0x18139F990 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x139FDE0 Offset: 0x139E3E0 VA: 0x18139FDE0
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 778
{
	// Methods

	// RVA: 0x13B10B0 Offset: 0x13AF6B0 VA: 0x1813B10B0
	protected void .ctor() { }

	// RVA: 0x13B1060 Offset: 0x13AF660 VA: 0x1813B1060
	public static SHA1 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA1Managed : SHA1 // TypeDefIndex: 779
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x13B0F80 Offset: 0x13AF580 VA: 0x1813B0F80
	public void .ctor() { }

	// RVA: 0x13B0550 Offset: 0x13AEB50 VA: 0x1813B0550 Slot: 18
	public override void Initialize() { }

	// RVA: 0x13B0530 Offset: 0x13AEB30 VA: 0x1813B0530 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x13B0540 Offset: 0x13AEB40 VA: 0x1813B0540 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x139CF30 Offset: 0x139B530 VA: 0x18139CF30
	private void InitializeState() { }

	// RVA: 0x13B0DE0 Offset: 0x13AF3E0 VA: 0x1813B0DE0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x13B0B80 Offset: 0x13AF180 VA: 0x1813B0B80
	private byte[] _EndHash() { }

	// RVA: 0x13B05E0 Offset: 0x13AEBE0 VA: 0x1813B05E0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x13B05A0 Offset: 0x13AEBA0 VA: 0x1813B05A0
	private static void SHAExpand(uint* x) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 780
{
	// Methods

	// RVA: 0x13B2730 Offset: 0x13B0D30 VA: 0x1813B2730
	protected void .ctor() { }

	// RVA: 0x13B26E0 Offset: 0x13B0CE0 VA: 0x1813B26E0
	public static SHA256 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA256Managed : SHA256 // TypeDefIndex: 781
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x13B2540 Offset: 0x13B0B40 VA: 0x1813B2540
	public void .ctor() { }

	// RVA: 0x13B11F0 Offset: 0x13AF7F0 VA: 0x1813B11F0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x13B10E0 Offset: 0x13AF6E0 VA: 0x1813B10E0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x13B10F0 Offset: 0x13AF6F0 VA: 0x1813B10F0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x13B1100 Offset: 0x13AF700 VA: 0x1813B1100
	private void InitializeState() { }

	// RVA: 0x13B22D0 Offset: 0x13B08D0 VA: 0x1813B22D0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x13B2070 Offset: 0x13B0670 VA: 0x1813B2070
	private byte[] _EndHash() { }

	// RVA: 0x13B13B0 Offset: 0x13AF9B0 VA: 0x1813B13B0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x13B1250 Offset: 0x13AF850 VA: 0x1813B1250
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x13B10D0 Offset: 0x13AF6D0 VA: 0x1813B10D0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x13B1240 Offset: 0x13AF840 VA: 0x1813B1240
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x13B2620 Offset: 0x13B0C20 VA: 0x1813B2620
	private static uint sigma_0(uint x) { }

	// RVA: 0x13B2680 Offset: 0x13B0C80 VA: 0x1813B2680
	private static uint sigma_1(uint x) { }

	// RVA: 0x13B1F90 Offset: 0x13B0590 VA: 0x1813B1F90
	private static uint Sigma_0(uint x) { }

	// RVA: 0x13B2000 Offset: 0x13B0600 VA: 0x1813B2000
	private static uint Sigma_1(uint x) { }

	// RVA: 0x13B1270 Offset: 0x13AF870 VA: 0x1813B1270
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x13B24B0 Offset: 0x13B0AB0 VA: 0x1813B24B0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 782
{
	// Methods

	// RVA: 0x13B3F60 Offset: 0x13B2560 VA: 0x1813B3F60
	protected void .ctor() { }

	// RVA: 0x13B3F10 Offset: 0x13B2510 VA: 0x1813B3F10
	public static SHA384 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA384Managed : SHA384 // TypeDefIndex: 783
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x13B3D50 Offset: 0x13B2350 VA: 0x1813B3D50
	public void .ctor() { }

	// RVA: 0x13B28B0 Offset: 0x13B0EB0 VA: 0x1813B28B0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x13B2760 Offset: 0x13B0D60 VA: 0x1813B2760 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x13B2770 Offset: 0x13B0D70 VA: 0x1813B2770 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x13B2780 Offset: 0x13B0D80 VA: 0x1813B2780
	private void InitializeState() { }

	// RVA: 0x13B3AD0 Offset: 0x13B20D0 VA: 0x1813B3AD0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x13B3910 Offset: 0x13B1F10 VA: 0x1813B3910
	private byte[] _EndHash() { }

	// RVA: 0x13B2A90 Offset: 0x13B1090 VA: 0x1813B2A90
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x13B2910 Offset: 0x13B0F10 VA: 0x1813B2910
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x13B2750 Offset: 0x13B0D50 VA: 0x1813B2750
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x13B2900 Offset: 0x13B0F00 VA: 0x1813B2900
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x13B3810 Offset: 0x13B1E10 VA: 0x1813B3810
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x13B3890 Offset: 0x13B1E90 VA: 0x1813B3890
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x13B3E30 Offset: 0x13B2430 VA: 0x1813B3E30
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x13B3EA0 Offset: 0x13B24A0 VA: 0x1813B3EA0
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x13B2930 Offset: 0x13B0F30 VA: 0x1813B2930
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x13B3CC0 Offset: 0x13B22C0 VA: 0x1813B3CC0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 784
{
	// Methods

	// RVA: 0x13B5750 Offset: 0x13B3D50 VA: 0x1813B5750
	protected void .ctor() { }

	// RVA: 0x13B5700 Offset: 0x13B3D00 VA: 0x1813B5700
	public static SHA512 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA512Managed : SHA512 // TypeDefIndex: 785
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x13B5540 Offset: 0x13B3B40 VA: 0x1813B5540
	public void .ctor() { }

	// RVA: 0x13B40D0 Offset: 0x13B26D0 VA: 0x1813B40D0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x13B3F80 Offset: 0x13B2580 VA: 0x1813B3F80 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x13B3F90 Offset: 0x13B2590 VA: 0x1813B3F90 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x13B3FA0 Offset: 0x13B25A0 VA: 0x1813B3FA0
	private void InitializeState() { }

	// RVA: 0x13B52C0 Offset: 0x13B38C0 VA: 0x1813B52C0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x13B5100 Offset: 0x13B3700 VA: 0x1813B5100
	private byte[] _EndHash() { }

	// RVA: 0x13B4280 Offset: 0x13B2880 VA: 0x1813B4280
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x13B2910 Offset: 0x13B0F10 VA: 0x1813B2910
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x13B2750 Offset: 0x13B0D50 VA: 0x1813B2750
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x13B2900 Offset: 0x13B0F00 VA: 0x1813B2900
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x13B5000 Offset: 0x13B3600 VA: 0x1813B5000
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x13B5080 Offset: 0x13B3680 VA: 0x1813B5080
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x13B5620 Offset: 0x13B3C20 VA: 0x1813B5620
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x13B5690 Offset: 0x13B3C90 VA: 0x1813B5690
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x13B4120 Offset: 0x13B2720 VA: 0x1813B4120
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x13B54B0 Offset: 0x13B3AB0 VA: 0x1813B54B0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SignatureDescription // TypeDefIndex: 786
{
	// Fields
	private string _strKey; // 0x10
	private string _strDigest; // 0x18
	private string _strFormatter; // 0x20
	private string _strDeformatter; // 0x28

	// Properties
	public string KeyAlgorithm { set; }
	public string DigestAlgorithm { set; }
	public string FormatterAlgorithm { set; }
	public string DeformatterAlgorithm { set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_KeyAlgorithm(string value) { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_DigestAlgorithm(string value) { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_FormatterAlgorithm(string value) { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_DeformatterAlgorithm(string value) { }
}

// Namespace: System.Security.Cryptography
internal abstract class RSAPKCS1SignatureDescription : SignatureDescription // TypeDefIndex: 787
{
	// Fields
	private string _hashAlgorithm; // 0x30

	// Methods

	// RVA: 0x13AEAF0 Offset: 0x13AD0F0 VA: 0x1813AEAF0
	protected void .ctor(string hashAlgorithm, string digestAlgorithm) { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 788
{
	// Methods

	// RVA: 0x13AE600 Offset: 0x13ACC00 VA: 0x1813AE600
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 789
{
	// Methods

	// RVA: 0x13AE650 Offset: 0x13ACC50 VA: 0x1813AE650
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 790
{
	// Methods

	// RVA: 0x13AE6A0 Offset: 0x13ACCA0 VA: 0x1813AE6A0
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 791
{
	// Methods

	// RVA: 0x13AE6F0 Offset: 0x13ACCF0 VA: 0x1813AE6F0
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class DSASignatureDescription : SignatureDescription // TypeDefIndex: 792
{
	// Methods

	// RVA: 0x13AB030 Offset: 0x13A9630 VA: 0x1813AB030
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 793
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x13B5B40 Offset: 0x13B4140 VA: 0x1813B5B40
	protected void .ctor() { }

	// RVA: 0x13B5A40 Offset: 0x13B4040 VA: 0x1813B5A40 Slot: 4
	public void Dispose() { }

	// RVA: 0x13B5770 Offset: 0x13B3D70 VA: 0x1813B5770
	public void Clear() { }

	// RVA: 0x13B59D0 Offset: 0x13B3FD0 VA: 0x1813B59D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x13B5D30 Offset: 0x13B4330 VA: 0x1813B5D30 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x13B5B70 Offset: 0x13B4170 VA: 0x1813B5B70 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x13B5EA0 Offset: 0x13B44A0 VA: 0x1813B5EA0 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x13B5C10 Offset: 0x13B4210 VA: 0x1813B5C10 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x13B60B0 Offset: 0x13B46B0 VA: 0x1813B60B0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x13B5CB0 Offset: 0x13B42B0 VA: 0x1813B5CB0 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x13B6010 Offset: 0x13B4610 VA: 0x1813B6010 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x13B6240 Offset: 0x13B4840 VA: 0x1813B6240 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x13B62C0 Offset: 0x13B48C0 VA: 0x1813B62C0 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x13B5AA0 Offset: 0x13B40A0 VA: 0x1813B5AA0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x13B5900 Offset: 0x13B3F00 VA: 0x1813B5900
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x13B5890 Offset: 0x13B3E90 VA: 0x1813B5890 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x13B5820 Offset: 0x13B3E20 VA: 0x1813B5820 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 794
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x13B6DC0 Offset: 0x13B53C0 VA: 0x1813B6DC0
	protected void .ctor() { }

	// RVA: 0x13B6E70 Offset: 0x13B5470 VA: 0x1813B6E70 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x13B6F40 Offset: 0x13B5540 VA: 0x1813B6F40 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x13B67B0 Offset: 0x13B4DB0 VA: 0x1813B67B0
	public static TripleDES Create() { }

	// RVA: 0x13B6A60 Offset: 0x13B5060 VA: 0x1813B6A60
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x13B6800 Offset: 0x13B4E00 VA: 0x1813B6800
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x13B6A40 Offset: 0x13B5040 VA: 0x1813B6A40
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x13B6C50 Offset: 0x13B5250 VA: 0x1813B6C50
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class TripleDESCryptoServiceProvider : TripleDES // TypeDefIndex: 795
{
	// Methods

	// RVA: 0x13B66C0 Offset: 0x13B4CC0 VA: 0x1813B66C0
	public void .ctor() { }

	// RVA: 0x13B6460 Offset: 0x13B4A60 VA: 0x1813B6460 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x13B6340 Offset: 0x13B4940 VA: 0x1813B6340 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x13B6600 Offset: 0x13B4C00 VA: 0x1813B6600 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x13B6580 Offset: 0x13B4B80 VA: 0x1813B6580 Slot: 25
	public override void GenerateIV() { }
}

// Namespace: System.Security.Cryptography
internal static class Utils // TypeDefIndex: 796
{
	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x0

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x13B7BA0 Offset: 0x13B61A0 VA: 0x1813B7BA0
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x13B7900 Offset: 0x13B5F00 VA: 0x1813B7900
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x13B7560 Offset: 0x13B5B60 VA: 0x1813B7560
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x13B76D0 Offset: 0x13B5CD0 VA: 0x1813B76D0
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x13B7160 Offset: 0x13B5760 VA: 0x1813B7160
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x13B71C0 Offset: 0x13B57C0 VA: 0x1813B71C0
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x13B7850 Offset: 0x13B5E50 VA: 0x1813B7850
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x13B7340 Offset: 0x13B5940 VA: 0x1813B7340
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x13B7480 Offset: 0x13B5A80 VA: 0x1813B7480
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x13B72E0 Offset: 0x13B58E0 VA: 0x1813B72E0
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x13B73A0 Offset: 0x13B59A0 VA: 0x1813B73A0
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x13B7970 Offset: 0x13B5F70 VA: 0x1813B7970
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x13B7A00 Offset: 0x13B6000 VA: 0x1813B7A00
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	internal static bool _ProduceLegacyHmacValues() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class CryptoConfig // TypeDefIndex: 797
{
	// Fields
	private static readonly object lockObject; // 0x0
	private static Dictionary<string, Type> algorithms; // 0x8

	// Properties
	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms { get; }

	// Methods

	// RVA: 0x13A87F0 Offset: 0x13A6DF0 VA: 0x1813A87F0
	public static object CreateFromName(string name) { }

	// RVA: 0x13A6A10 Offset: 0x13A5010 VA: 0x1813A6A10
	public static object CreateFromName(string name, object[] args) { }

	// RVA: 0x13A8E00 Offset: 0x13A7400 VA: 0x1813A8E00
	public static string MapNameToOID(string name) { }

	// RVA: 0x13A89D0 Offset: 0x13A6FD0 VA: 0x1813A89D0
	public static byte[] EncodeOID(string str) { }

	// RVA: 0x13A8840 Offset: 0x13A6E40 VA: 0x1813A8840
	private static byte[] EncodeLongNumber(long x) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool get_AllowOnlyFipsAlgorithms() { }

	// RVA: 0x13A94C0 Offset: 0x13A7AC0 VA: 0x1813A94C0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class DESTransform : SymmetricTransform // TypeDefIndex: 798
{
	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x13AA870 Offset: 0x13A8E70 VA: 0x1813AA870
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x13A95D0 Offset: 0x13A7BD0 VA: 0x1813A95D0
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x13A9A40 Offset: 0x13A8040 VA: 0x1813A9A40
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x13A9540 Offset: 0x13A7B40 VA: 0x1813A9540
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x13AA1B0 Offset: 0x13A87B0 VA: 0x1813AA1B0
	internal void SetKey(byte[] key) { }

	// RVA: 0x13A9DD0 Offset: 0x13A83D0 VA: 0x1813A9DD0
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x13A98A0 Offset: 0x13A7EA0 VA: 0x1813A98A0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x13A9970 Offset: 0x13A7F70 VA: 0x1813A9970
	internal static byte[] GetStrongKey() { }

	// RVA: 0x13AA580 Offset: 0x13A8B80 VA: 0x1813AA580
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 799
{
	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x13AAFB0 Offset: 0x13A95B0 VA: 0x1813AAFB0
	public void .ctor() { }

	// RVA: 0x13AAF70 Offset: 0x13A9570 VA: 0x1813AAF70
	public void .ctor(int dwKeySize) { }

	// RVA: 0x13AABA0 Offset: 0x13A91A0 VA: 0x1813AABA0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13AAFE0 Offset: 0x13A95E0 VA: 0x1813AAFE0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x13AB010 Offset: 0x13A9610 VA: 0x1813AB010
	public bool get_PublicOnly() { }

	// RVA: 0x13AADE0 Offset: 0x13A93E0 VA: 0x1813AADE0 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x139FD90 Offset: 0x139E390 VA: 0x18139FD90 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x13AAF40 Offset: 0x13A9540 VA: 0x1813AAF40 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x139F990 Offset: 0x139DF90 VA: 0x18139F990 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13AAEB0 Offset: 0x13A94B0 VA: 0x1813AAEB0
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 800
{
	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x13ACF30 Offset: 0x13AB530 VA: 0x1813ACF30
	public void .ctor() { }

	// RVA: 0x13AB240 Offset: 0x13A9840 VA: 0x1813AB240 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13AB1C0 Offset: 0x13A97C0 VA: 0x1813AB1C0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13AB2B0 Offset: 0x13A98B0 VA: 0x1813AB2B0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x13AB400 Offset: 0x13A9A00 VA: 0x1813AB400 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x13AB4F0 Offset: 0x13A9AF0 VA: 0x1813AB4F0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x13AB570 Offset: 0x13A9B70 VA: 0x1813AB570
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x13ACC70 Offset: 0x13AB270 VA: 0x1813ACC70
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x13AB0E0 Offset: 0x13A96E0 VA: 0x1813AB0E0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x13ACEA0 Offset: 0x13AB4A0 VA: 0x1813ACEA0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class RC2Transform : SymmetricTransform // TypeDefIndex: 801
{
	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x13ADC20 Offset: 0x13AC220 VA: 0x1813ADC20
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x13ACFF0 Offset: 0x13AB5F0 VA: 0x1813ACFF0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x13ADB90 Offset: 0x13AC190 VA: 0x1813ADB90
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 802
{
	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x13AE510 Offset: 0x13ACB10 VA: 0x1813AE510
	private static void .cctor() { }

	// RVA: 0x13AE5A0 Offset: 0x13ACBA0 VA: 0x1813AE5A0
	public void .ctor() { }

	// RVA: 0x13AE190 Offset: 0x13AC790 VA: 0x1813AE190
	private void Check() { }

	// RVA: 0x13AE500 Offset: 0x13ACB00 VA: 0x1813AE500
	private static bool RngOpen() { }

	// RVA: 0x13AE4F0 Offset: 0x13ACAF0 VA: 0x1813AE4F0
	private static IntPtr RngInitialize(byte* seed, IntPtr seed_length) { }

	// RVA: 0x13AE4E0 Offset: 0x13ACAE0 VA: 0x1813AE4E0
	private static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length) { }

	// RVA: 0x13AE4D0 Offset: 0x13ACAD0 VA: 0x1813AE4D0
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x13AE2D0 Offset: 0x13AC8D0 VA: 0x1813AE2D0 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x13AE220 Offset: 0x13AC820 VA: 0x1813AE220 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13AE210 Offset: 0x13AC810 VA: 0x1813AE210 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 803
{
	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x13AEAB0 Offset: 0x13AD0B0 VA: 0x1813AEAB0
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x13AE740 Offset: 0x13ACD40 VA: 0x1813AE740 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x13AE7B0 Offset: 0x13ACDB0 VA: 0x1813AE7B0 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x13AE8C0 Offset: 0x13ACEC0 VA: 0x1813AE8C0 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter // TypeDefIndex: 804
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class SHA1Internal // TypeDefIndex: 805
{
	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x13B0400 Offset: 0x13AEA00 VA: 0x1813B0400
	public void .ctor() { }

	// RVA: 0x13AF080 Offset: 0x13AD680 VA: 0x1813AF080
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x13AF1D0 Offset: 0x13AD7D0 VA: 0x1813AF1D0
	public byte[] HashFinal() { }

	// RVA: 0x13AFA40 Offset: 0x13AE040 VA: 0x1813AFA40
	public void Initialize() { }

	// RVA: 0x13AFAD0 Offset: 0x13AE0D0 VA: 0x1813AFAD0
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x13AF2C0 Offset: 0x13AD8C0 VA: 0x1813AF2C0
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x13AECB0 Offset: 0x13AD2B0 VA: 0x1813AECB0
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x13B01C0 Offset: 0x13AE7C0 VA: 0x1813B01C0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x13AEBC0 Offset: 0x13AD1C0 VA: 0x1813AEBC0
	internal void AddLength(ulong length, byte[] buffer, int position) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 806
{
	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x13D0560 Offset: 0x13CEB60 VA: 0x1813D0560
	public void .ctor() { }

	// RVA: 0x13AB240 Offset: 0x13A9840 VA: 0x1813AB240 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13D04D0 Offset: 0x13CEAD0 VA: 0x1813D04D0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13D04E0 Offset: 0x13CEAE0 VA: 0x1813D04E0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x13D0510 Offset: 0x13CEB10 VA: 0x1813D0510 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x13D0540 Offset: 0x13CEB40 VA: 0x1813D0540 Slot: 18
	public override void Initialize() { }
}

// Namespace: System.Security.Cryptography
internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 807
{
	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x13D3B10 Offset: 0x13D2110 VA: 0x1813D3B10
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x13D3900 Offset: 0x13D1F00 VA: 0x1813D3900 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x13D3A60 Offset: 0x13D2060 VA: 0x1813D3A60
	internal static byte[] GetStrongKey() { }
}

// Namespace: System.Security.Cryptography
internal static class CryptoConfigForwarder // TypeDefIndex: 808
{
	// Methods

	// RVA: 0x13C2600 Offset: 0x13C0C00 VA: 0x1813C2600
	internal static object CreateFromName(string name) { }
}

// Namespace: System.Security.Cryptography
internal class DerSequenceReader // TypeDefIndex: 7504
{
	// Fields
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; // 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; // 0x8
	private static Encoding s_latin1Encoding; // 0x10
	private readonly byte[] _data; // 0x10
	private readonly int _end; // 0x18
	private int _position; // 0x1C
	[CompilerGenerated]
	private int <ContentLength>k__BackingField; // 0x20

	// Properties
	private int ContentLength { set; }
	internal bool HasData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	private void set_ContentLength(int value) { }

	// RVA: 0x1DFB8F0 Offset: 0x1DF9EF0 VA: 0x181DFB8F0
	internal void .ctor(byte[] data) { }

	// RVA: 0x1DFB930 Offset: 0x1DF9F30 VA: 0x181DFB930
	internal void .ctor(byte[] data, int offset, int length) { }

	// RVA: 0x1DFB780 Offset: 0x1DF9D80 VA: 0x181DFB780
	private void .ctor(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length) { }

	// RVA: 0x1DFB960 Offset: 0x1DF9F60 VA: 0x181DFB960
	internal bool get_HasData() { }

	// RVA: 0x1DF9F60 Offset: 0x1DF8560 VA: 0x181DF9F60
	internal byte PeekTag() { }

	// RVA: 0x1DFB6C0 Offset: 0x1DF9CC0 VA: 0x181DFB6C0
	internal void SkipValue() { }

	// RVA: 0x1DFA710 Offset: 0x1DF8D10 VA: 0x181DFA710
	internal byte[] ReadNextEncodedValue() { }

	// RVA: 0x1DFA2B0 Offset: 0x1DF88B0 VA: 0x181DFA2B0
	internal bool ReadBoolean() { }

	// RVA: 0x1DFA660 Offset: 0x1DF8C60 VA: 0x181DFA660
	internal int ReadInteger() { }

	// RVA: 0x1DFA630 Offset: 0x1DF8C30 VA: 0x181DFA630
	internal byte[] ReadIntegerBytes() { }

	// RVA: 0x1DFA120 Offset: 0x1DF8720 VA: 0x181DFA120
	internal byte[] ReadBitString() { }

	// RVA: 0x1DFA7C0 Offset: 0x1DF8DC0 VA: 0x181DFA7C0
	internal byte[] ReadOctetString() { }

	// RVA: 0x1DFA7F0 Offset: 0x1DF8DF0 VA: 0x181DFA7F0
	internal string ReadOidAsString() { }

	// RVA: 0x1DFB210 Offset: 0x1DF9810 VA: 0x181DFB210
	internal string ReadUtf8String() { }

	// RVA: 0x1DFA380 Offset: 0x1DF8980 VA: 0x181DFA380
	private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x1DFAC30 Offset: 0x1DF9230 VA: 0x181DFAC30
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x1DFAC40 Offset: 0x1DF9240 VA: 0x181DFAC40
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x1DFAB50 Offset: 0x1DF9150 VA: 0x181DFAB50
	internal string ReadPrintableString() { }

	// RVA: 0x1DFA550 Offset: 0x1DF8B50 VA: 0x181DFA550
	internal string ReadIA5String() { }

	// RVA: 0x1DFAC50 Offset: 0x1DF9250 VA: 0x181DFAC50
	internal string ReadT61String() { }

	// RVA: 0x1DFB2F0 Offset: 0x1DF98F0 VA: 0x181DFB2F0
	internal DateTime ReadX509Date() { }

	// RVA: 0x1DFB1D0 Offset: 0x1DF97D0 VA: 0x181DFB1D0
	internal DateTime ReadUtcTime() { }

	// RVA: 0x1DFA510 Offset: 0x1DF8B10 VA: 0x181DFA510
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x1DFA040 Offset: 0x1DF8640 VA: 0x181DFA040
	internal string ReadBMPString() { }

	// RVA: 0x1DFB710 Offset: 0x1DF9D10 VA: 0x181DFB710
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x1DFAF70 Offset: 0x1DF9570 VA: 0x181DFAF70
	private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString) { }

	// RVA: 0x1DFA460 Offset: 0x1DF8A60 VA: 0x181DFA460
	private byte[] ReadContentAsBytes() { }

	// RVA: 0x1DF9EE0 Offset: 0x1DF84E0 VA: 0x181DF9EE0
	private void EatTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x1DF9D70 Offset: 0x1DF8370 VA: 0x181DF9D70
	private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position) { }

	// RVA: 0x1DF9EA0 Offset: 0x1DF84A0 VA: 0x181DF9EA0
	private int EatLength() { }

	// RVA: 0x1DFB3C0 Offset: 0x1DF99C0 VA: 0x181DFB3C0
	private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed) { }
}

// Namespace: System.Security.Cryptography
public sealed class Oid // TypeDefIndex: 7505
{
	// Fields
	private string _value; // 0x10
	private string _friendlyName; // 0x18
	private OidGroup _group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1E18CB0 Offset: 0x1E172B0 VA: 0x181E18CB0
	public void .ctor(string oid) { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x1E18C10 Offset: 0x1E17210 VA: 0x181E18C10
	public void .ctor(Oid oid) { }

	// RVA: 0x1E18AA0 Offset: 0x1E170A0 VA: 0x181E18AA0
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Value() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Value(string value) { }

	// RVA: 0x1E18D40 Offset: 0x1E17340 VA: 0x181E18D40
	public string get_FriendlyName() { }

	// RVA: 0x1440870 Offset: 0x143EE70 VA: 0x181440870
	private void .ctor(string value, string friendlyName, OidGroup group) { }
}

// Namespace: System.Security.Cryptography
[DefaultMember("Item")]
public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 7506
{
	// Fields
	private readonly List<Oid> _list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1E188A0 Offset: 0x1E16EA0 VA: 0x181E188A0
	public void .ctor() { }

	// RVA: 0x1E18510 Offset: 0x1E16B10 VA: 0x181E18510
	public int Add(Oid oid) { }

	// RVA: 0x1E18960 Offset: 0x1E16F60 VA: 0x181E18960
	public Oid get_Item(int index) { }

	// RVA: 0x1E18920 Offset: 0x1E16F20 VA: 0x181E18920 Slot: 5
	public int get_Count() { }

	// RVA: 0x1E185F0 Offset: 0x1E16BF0 VA: 0x181E185F0
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x1E185F0 Offset: 0x1E16BF0 VA: 0x181E185F0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E18660 Offset: 0x1E16C60 VA: 0x181E18660 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 6
	public object get_SyncRoot() { }
}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator : IEnumerator // TypeDefIndex: 7507
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Properties
	public Oid Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1471E60 Offset: 0x1470460 VA: 0x181471E60
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x1E18A40 Offset: 0x1E17040 VA: 0x181E18A40
	public Oid get_Current() { }

	// RVA: 0x1E18A40 Offset: 0x1E17040 VA: 0x181E18A40 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1E189C0 Offset: 0x1E16FC0 VA: 0x181E189C0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1539310 Offset: 0x1537910 VA: 0x181539310 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.Cryptography
public enum OidGroup // TypeDefIndex: 7508
{
	// Fields
	public int value__; // 0x0
	public const OidGroup All = 0;
	public const OidGroup HashAlgorithm = 1;
	public const OidGroup EncryptionAlgorithm = 2;
	public const OidGroup PublicKeyAlgorithm = 3;
	public const OidGroup SignatureAlgorithm = 4;
	public const OidGroup Attribute = 5;
	public const OidGroup ExtensionOrAttribute = 6;
	public const OidGroup EnhancedKeyUsage = 7;
	public const OidGroup Policy = 8;
	public const OidGroup Template = 9;
	public const OidGroup KeyDerivationFunction = 10;
}

// Namespace: System.Security.Cryptography
internal enum AsnDecodeStatus // TypeDefIndex: 7509
{
	// Fields
	public int value__; // 0x0
	public const AsnDecodeStatus NotDecoded = -1;
	public const AsnDecodeStatus Ok = 0;
	public const AsnDecodeStatus BadAsn = 1;
	public const AsnDecodeStatus BadTag = 2;
	public const AsnDecodeStatus BadLength = 3;
	public const AsnDecodeStatus InformationNotAvailable = 4;
}

// Namespace: System.Security.Cryptography
public class AsnEncodedData // TypeDefIndex: 7510
{
	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1E10510 Offset: 0x1E0EB10 VA: 0x181E10510
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x1E10450 Offset: 0x1E0EA50 VA: 0x181E10450
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x1E105B0 Offset: 0x1E0EBB0 VA: 0x181E105B0
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Oid get_Oid() { }

	// RVA: 0x1E106C0 Offset: 0x1E0ECC0 VA: 0x181E106C0
	public void set_Oid(Oid value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public byte[] get_RawData() { }

	// RVA: 0x1E10770 Offset: 0x1E0ED70 VA: 0x181E10770
	public void set_RawData(byte[] value) { }

	// RVA: 0x1E0F530 Offset: 0x1E0DB30 VA: 0x181E0F530 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1E0F900 Offset: 0x1E0DF00 VA: 0x181E0F900 Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x1E10280 Offset: 0x1E0E880 VA: 0x181E10280 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x1E0F670 Offset: 0x1E0DC70 VA: 0x181E0F670
	internal string Default(bool multiLine) { }

	// RVA: 0x1E0F3D0 Offset: 0x1E0D9D0 VA: 0x181E0F3D0
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x1E0F7A0 Offset: 0x1E0DDA0 VA: 0x181E0F7A0
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x1E0F940 Offset: 0x1E0DF40 VA: 0x181E0F940
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x1E10120 Offset: 0x1E0E720 VA: 0x181E10120
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x1E0FE50 Offset: 0x1E0E450 VA: 0x181E0FE50
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x1E0FAA0 Offset: 0x1E0E0A0 VA: 0x181E0FAA0
	internal string NetscapeCertType(bool multiLine) { }
}

// Namespace: System.Security.Cryptography
public sealed class AesManaged : Aes // TypeDefIndex: 10707
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x19DED00 Offset: 0x19DD300 VA: 0x1819DED00
	public void .ctor() { }

	// RVA: 0x19DEE90 Offset: 0x19DD490 VA: 0x1819DEE90 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x19DEEC0 Offset: 0x19DD4C0 VA: 0x1819DEEC0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x19DEFB0 Offset: 0x19DD5B0 VA: 0x1819DEFB0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x19DEF20 Offset: 0x19DD520 VA: 0x1819DEF20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x19DF010 Offset: 0x19DD610 VA: 0x1819DF010 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x19DEEF0 Offset: 0x19DD4F0 VA: 0x1819DEEF0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x19DEFE0 Offset: 0x19DD5E0 VA: 0x1819DEFE0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x19DEF50 Offset: 0x19DD550 VA: 0x1819DEF50 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x19DF040 Offset: 0x19DD640 VA: 0x1819DF040 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x19DEF80 Offset: 0x19DD580 VA: 0x1819DEF80 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x19DF0E0 Offset: 0x19DD6E0 VA: 0x1819DF0E0 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x19DE9F0 Offset: 0x19DCFF0 VA: 0x1819DE9F0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x19DE850 Offset: 0x19DCE50 VA: 0x1819DE850 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x19DEBC0 Offset: 0x19DD1C0 VA: 0x1819DEBC0 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x19DEA20 Offset: 0x19DD020 VA: 0x1819DEA20 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x19DEBF0 Offset: 0x19DD1F0 VA: 0x1819DEBF0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19DECA0 Offset: 0x19DD2A0 VA: 0x1819DECA0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x19DECD0 Offset: 0x19DD2D0 VA: 0x1819DECD0 Slot: 24
	public override void GenerateKey() { }
}

// Namespace: System.Security.Cryptography
public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 10708
{
	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x19DE720 Offset: 0x19DCD20 VA: 0x1819DE720
	public void .ctor() { }

	// RVA: 0x19DE6C0 Offset: 0x19DCCC0 VA: 0x1819DE6C0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x19DE6F0 Offset: 0x19DCCF0 VA: 0x1819DE6F0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x19DE4B0 Offset: 0x19DCAB0 VA: 0x1819DE4B0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x19DE5B0 Offset: 0x19DCBB0 VA: 0x1819DE5B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x19DE780 Offset: 0x19DCD80 VA: 0x1819DE780 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x19DE7A0 Offset: 0x19DCDA0 VA: 0x1819DE7A0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x19DE790 Offset: 0x19DCD90 VA: 0x1819DE790 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x19DE7C0 Offset: 0x19DCDC0 VA: 0x1819DE7C0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x19DE7B0 Offset: 0x19DCDB0 VA: 0x1819DE7B0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x19DE7D0 Offset: 0x19DCDD0 VA: 0x1819DE7D0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x19DE840 Offset: 0x19DCE40 VA: 0x1819DE840 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x13B5820 Offset: 0x13B3E20 VA: 0x1813B5820 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x13B5890 Offset: 0x13B3E90 VA: 0x1813B5890 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x19DE6B0 Offset: 0x19DCCB0 VA: 0x1819DE6B0 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
internal class AesTransform : SymmetricTransform // TypeDefIndex: 10709
{
	// Fields
	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50

	// Methods

	// RVA: 0x19E5280 Offset: 0x19E3880 VA: 0x1819E5280
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x19E1F30 Offset: 0x19E0530 VA: 0x1819E1F30 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x19E4D50 Offset: 0x19E3350 VA: 0x1819E4D50
	private uint SubByte(uint a) { }

	// RVA: 0x19E1F60 Offset: 0x19E0560 VA: 0x1819E1F60
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x19DF110 Offset: 0x19DD710 VA: 0x1819DF110
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x19E4E30 Offset: 0x19E3430 VA: 0x1819E4E30
	private static void .cctor() { }
}

