// Namespace: System.Text
[Serializable]
public class ASCIIEncoding : Encoding // TypeDefIndex: 651
{
	// Fields
	internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default; // 0x0

	// Methods

	// RVA: 0x158C6D0 Offset: 0x158ACD0 VA: 0x18158C6D0
	public void .ctor() { }

	// RVA: 0x158C5E0 Offset: 0x158ABE0 VA: 0x18158C5E0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x158A730 Offset: 0x1588D30 VA: 0x18158A730 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x158A8E0 Offset: 0x1588EE0 VA: 0x18158A8E0 Slot: 11
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x158A300 Offset: 0x1588900 VA: 0x18158A300 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x158B270 Offset: 0x1589870 VA: 0x18158B270 Slot: 19
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x158AFA0 Offset: 0x15895A0 VA: 0x18158AFA0 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x158AE70 Offset: 0x1589470 VA: 0x18158AE70 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x158B550 Offset: 0x1589B50 VA: 0x18158B550 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x158B700 Offset: 0x1589D00 VA: 0x18158B700 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x158BDE0 Offset: 0x158A3E0 VA: 0x18158BDE0 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x158B990 Offset: 0x1589F90 VA: 0x18158B990 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x158C430 Offset: 0x158AA30 VA: 0x18158C430 Slot: 35
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x158A400 Offset: 0x1588A00 VA: 0x18158A400 Slot: 14
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x158A980 Offset: 0x1588F80 VA: 0x18158A980 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x158B800 Offset: 0x1589E00 VA: 0x18158B800 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x158BAC0 Offset: 0x158A0C0 VA: 0x18158BAC0 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x158C1B0 Offset: 0x158A7B0 VA: 0x18158C1B0 Slot: 32
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x158C2F0 Offset: 0x158A8F0 VA: 0x18158C2F0 Slot: 33
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x158C0B0 Offset: 0x158A6B0 VA: 0x18158C0B0 Slot: 30
	public override Decoder GetDecoder() { }

	// RVA: 0x158C150 Offset: 0x158A750 VA: 0x18158C150 Slot: 31
	public override Encoder GetEncoder() { }

	// RVA: 0x158C620 Offset: 0x158AC20 VA: 0x18158C620
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
public abstract class Decoder // TypeDefIndex: 652
{
	// Fields
	internal DecoderFallback _fallback; // 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public DecoderFallback Fallback { get; }
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public DecoderFallback get_Fallback() { }

	// RVA: 0x1590400 Offset: 0x158EA00 VA: 0x181590400
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x136E330 Offset: 0x136C930 VA: 0x18136E330
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x15902D0 Offset: 0x158E8D0 VA: 0x1815902D0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	// RVA: 0x158FF20 Offset: 0x158E520 VA: 0x18158FF20 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x158FDA0 Offset: 0x158E3A0 VA: 0x18158FDA0 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x158FF40 Offset: 0x158E540 VA: 0x18158FF40 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x158FF60 Offset: 0x158E560 VA: 0x18158FF60 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x15901B0 Offset: 0x158E7B0 VA: 0x1815901B0 Slot: 11
	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush) { }

	// RVA: 0x158F760 Offset: 0x158DD60 VA: 0x18158F760 Slot: 12
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x158FB40 Offset: 0x158E140 VA: 0x18158FB40 Slot: 13
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Text
[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 653
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18
	internal char _cReplacement; // 0x20

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1590DF0 Offset: 0x158F3F0 VA: 0x181590DF0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1590CD0 Offset: 0x158F2D0 VA: 0x181590CD0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1590D30 Offset: 0x158F330 VA: 0x181590D30 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13703A0 Offset: 0x136E9A0 VA: 0x1813703A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 654
{
	// Fields
	private char _cBestFit; // 0x20
	private int _iCount; // 0x24
	private int _iSize; // 0x28
	private InternalDecoderBestFitFallback _oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1590C30 Offset: 0x158F230 VA: 0x181590C30
	private static object get_InternalSyncObject() { }

	// RVA: 0x1590A80 Offset: 0x158F080 VA: 0x181590A80
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x1590840 Offset: 0x158EE40 VA: 0x181590840 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1590890 Offset: 0x158EE90 VA: 0x181590890 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x136B500 Offset: 0x1369B00 VA: 0x18136B500 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x136B4E0 Offset: 0x1369AE0 VA: 0x18136B4E0 Slot: 7
	public override void Reset() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x15908C0 Offset: 0x158EEC0 VA: 0x1815908C0
	private char TryBestFit(byte[] bytesCheck) { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderExceptionFallback : DecoderFallback // TypeDefIndex: 655
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x158DB70 Offset: 0x158C170 VA: 0x18158DB70 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x158DBC0 Offset: 0x158C1C0 VA: 0x18158DBC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x158DC10 Offset: 0x158C210 VA: 0x18158DC10 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 656
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x158D960 Offset: 0x158BF60 VA: 0x18158D960 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x158D970 Offset: 0x158BF70 VA: 0x18158D970
	private void Throw(byte[] bytesUnknown, int index) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderFallbackException : ArgumentException // TypeDefIndex: 657
{
	// Fields
	private byte[] _bytesUnknown; // 0x98
	private int _index; // 0xA0

	// Methods

	// RVA: 0x158E300 Offset: 0x158C900 VA: 0x18158E300
	public void .ctor() { }

	// RVA: 0x158E2B0 Offset: 0x158C8B0 VA: 0x18158E2B0
	public void .ctor(string message, byte[] bytesUnknown, int index) { }

	// RVA: 0x136BF60 Offset: 0x136A560 VA: 0x18136BF60
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Text
[Serializable]
public abstract class DecoderFallback // TypeDefIndex: 658
{
	// Fields
	private static DecoderFallback s_replacementFallback; // 0x0
	private static DecoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x158E3F0 Offset: 0x158C9F0 VA: 0x18158E3F0
	public static DecoderFallback get_ReplacementFallback() { }

	// RVA: 0x158E350 Offset: 0x158C950 VA: 0x18158E350
	public static DecoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Text
public abstract class DecoderFallbackBuffer // TypeDefIndex: 659
{
	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x158E060 Offset: 0x158C660 VA: 0x18158E060 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x158E040 Offset: 0x158C640 VA: 0x18158E040
	internal void InternalReset() { }

	// RVA: 0x158E030 Offset: 0x158C630 VA: 0x18158E030
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x158DE10 Offset: 0x158C410 VA: 0x18158DE10 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x158DC20 Offset: 0x158C220 VA: 0x18158DC20 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x158E0A0 Offset: 0x158C6A0 VA: 0x18158E0A0
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Text
internal class DecoderNLS : Decoder // TypeDefIndex: 660
{
	// Fields
	private Encoding _encoding; // 0x20
	private bool _mustFlush; // 0x28
	internal bool _throwOnOverflow; // 0x29
	internal int _bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x158F1E0 Offset: 0x158D7E0 VA: 0x18158F1E0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x158F1C0 Offset: 0x158D7C0 VA: 0x18158F1C0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1380FB0 Offset: 0x137F5B0 VA: 0x181380FB0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x158EB60 Offset: 0x158D160 VA: 0x18158EB60 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x158EA40 Offset: 0x158D040 VA: 0x18158EA40 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x1381010 Offset: 0x137F610 VA: 0x181381010 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x158EEB0 Offset: 0x158D4B0 VA: 0x18158EEB0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x158ED50 Offset: 0x158D350 VA: 0x18158ED50 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x158E680 Offset: 0x158CC80 VA: 0x18158E680 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x158E4A0 Offset: 0x158CAA0 VA: 0x18158E4A0 Slot: 13
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_MustFlush() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x158E490 Offset: 0x158CA90 VA: 0x18158E490
	internal void ClearMustFlush() { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable // TypeDefIndex: 661
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x158F380 Offset: 0x158D980 VA: 0x18158F380
	public void .ctor() { }

	// RVA: 0x158F520 Offset: 0x158DB20 VA: 0x18158F520
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x158F320 Offset: 0x158D920 VA: 0x18158F320 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x158F5E0 Offset: 0x158DBE0 VA: 0x18158F5E0
	public void .ctor(string replacement) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_DefaultString() { }

	// RVA: 0x158F250 Offset: 0x158D850 VA: 0x18158F250 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x3A4D20 Offset: 0x3A3320 VA: 0x1803A4D20 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x158F2B0 Offset: 0x158D8B0 VA: 0x18158F2B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 662
{
	// Fields
	private string _strDefault; // 0x20
	private int _fallbackCount; // 0x28
	private int _fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x136B390 Offset: 0x1369990 VA: 0x18136B390
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x136B2B0 Offset: 0x13698B0 VA: 0x18136B2B0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x136B300 Offset: 0x1369900 VA: 0x18136B300 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x136B3E0 Offset: 0x13699E0 VA: 0x18136B3E0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x136B370 Offset: 0x1369970 VA: 0x18136B370 Slot: 7
	public override void Reset() { }

	// RVA: 0x136B350 Offset: 0x1369950 VA: 0x18136B350 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

// Namespace: System.Text
[Serializable]
public abstract class Encoder // TypeDefIndex: 663
{
	// Fields
	internal EncoderFallback _fallback; // 0x10
	internal EncoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public EncoderFallback Fallback { get; }
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public EncoderFallback get_Fallback() { }

	// RVA: 0x136E200 Offset: 0x136C800 VA: 0x18136E200
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x136E330 Offset: 0x136C930 VA: 0x18136E330
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x136E120 Offset: 0x136C720 VA: 0x18136E120 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x136DD10 Offset: 0x136C310 VA: 0x18136DD10 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x136DEA0 Offset: 0x136C4A0 VA: 0x18136DEA0 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x136D930 Offset: 0x136BF30 VA: 0x18136D930 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x136D6D0 Offset: 0x136BCD0 VA: 0x18136D6D0 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }
}

// Namespace: System.Text
[Serializable]
internal class InternalEncoderBestFitFallback : EncoderFallback // TypeDefIndex: 664
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1370280 Offset: 0x136E880 VA: 0x181370280 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x13702E0 Offset: 0x136E8E0 VA: 0x1813702E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13703A0 Offset: 0x136E9A0 VA: 0x1813703A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 665
{
	// Fields
	private char _cBestFit; // 0x30
	private InternalEncoderBestFitFallback _oFallback; // 0x38
	private int _iCount; // 0x40
	private int _iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x13701D0 Offset: 0x136E7D0 VA: 0x1813701D0
	private static object get_InternalSyncObject() { }

	// RVA: 0x1370020 Offset: 0x136E620 VA: 0x181370020
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x136FBA0 Offset: 0x136E1A0 VA: 0x18136FBA0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x136FCB0 Offset: 0x136E2B0 VA: 0x18136FCB0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x136FE90 Offset: 0x136E490 VA: 0x18136FE90 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x136FEC0 Offset: 0x136E4C0 VA: 0x18136FEC0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1370270 Offset: 0x136E870 VA: 0x181370270 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x136FEE0 Offset: 0x136E4E0 VA: 0x18136FEE0 Slot: 9
	public override void Reset() { }

	// RVA: 0x136FF00 Offset: 0x136E500 VA: 0x18136FF00
	private char TryBestFit(char cUnknown) { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 666
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x136B930 Offset: 0x1369F30 VA: 0x18136B930 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x136B980 Offset: 0x1369F80 VA: 0x18136B980 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x136B9D0 Offset: 0x1369FD0 VA: 0x18136B9D0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 667
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x136B610 Offset: 0x1369C10 VA: 0x18136B610 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x136B6C0 Offset: 0x1369CC0 VA: 0x18136B6C0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	public override int get_Remaining() { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 668
{
	// Fields
	private char _charUnknown; // 0x98
	private char _charUnknownHigh; // 0x9A
	private char _charUnknownLow; // 0x9C
	private int _index; // 0xA0

	// Methods

	// RVA: 0x136BCF0 Offset: 0x136A2F0 VA: 0x18136BCF0
	public void .ctor() { }

	// RVA: 0x136BF20 Offset: 0x136A520 VA: 0x18136BF20
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x136BD40 Offset: 0x136A340 VA: 0x18136BD40
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x136BF60 Offset: 0x136A560 VA: 0x18136BF60
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Text
[Serializable]
public abstract class EncoderFallback // TypeDefIndex: 669
{
	// Fields
	private static EncoderFallback s_replacementFallback; // 0x0
	private static EncoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x136C020 Offset: 0x136A620 VA: 0x18136C020
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x136BF80 Offset: 0x136A580 VA: 0x18136BF80
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Text
public abstract class EncoderFallbackBuffer // TypeDefIndex: 670
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x136BC20 Offset: 0x136A220 VA: 0x18136BC20 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x136BC00 Offset: 0x136A200 VA: 0x18136BC00
	internal void InternalReset() { }

	// RVA: 0x136BBC0 Offset: 0x136A1C0 VA: 0x18136BBC0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x136BB80 Offset: 0x136A180 VA: 0x18136BB80
	internal char InternalGetNextChar() { }

	// RVA: 0x136B9E0 Offset: 0x1369FE0 VA: 0x18136B9E0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x136BC60 Offset: 0x136A260 VA: 0x18136BC60
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Text
internal class EncoderNLS : Encoder // TypeDefIndex: 671
{
	// Fields
	internal char _charLeftOver; // 0x20
	private Encoding _encoding; // 0x28
	private bool _mustFlush; // 0x30
	internal bool _throwOnOverflow; // 0x31
	internal int _charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x136CE20 Offset: 0x136B420 VA: 0x18136CE20
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x136CDF0 Offset: 0x136B3F0 VA: 0x18136CDF0 Slot: 4
	public override void Reset() { }

	// RVA: 0x136C680 Offset: 0x136AC80 VA: 0x18136C680 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x136C870 Offset: 0x136AE70 VA: 0x18136C870 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x136C990 Offset: 0x136AF90 VA: 0x18136C990 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x136CCA0 Offset: 0x136B2A0 VA: 0x18136CCA0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x136C2C0 Offset: 0x136A8C0 VA: 0x18136C2C0 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x136C0E0 Offset: 0x136A6E0 VA: 0x18136C0E0 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Encoding get_Encoding() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_MustFlush() { }

	// RVA: 0x136CE90 Offset: 0x136B490 VA: 0x18136CE90 Slot: 11
	internal virtual bool get_HasState() { }

	// RVA: 0x3B5CA0 Offset: 0x3B42A0 VA: 0x1803B5CA0
	internal void ClearMustFlush() { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable // TypeDefIndex: 672
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x136D450 Offset: 0x136BA50 VA: 0x18136D450
	public void .ctor() { }

	// RVA: 0x136D490 Offset: 0x136BA90 VA: 0x18136D490
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x136D3F0 Offset: 0x136B9F0 VA: 0x18136D3F0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x136D550 Offset: 0x136BB50 VA: 0x18136D550
	public void .ctor(string replacement) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_DefaultString() { }

	// RVA: 0x136D2F0 Offset: 0x136B8F0 VA: 0x18136D2F0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x3A4D20 Offset: 0x3A3320 VA: 0x1803A4D20 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x136D380 Offset: 0x136B980 VA: 0x18136D380 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 673
{
	// Fields
	private string _strDefault; // 0x30
	private int _fallbackCount; // 0x38
	private int _fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x136D280 Offset: 0x136B880 VA: 0x18136D280
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x136D0C0 Offset: 0x136B6C0 VA: 0x18136D0C0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x136CEA0 Offset: 0x136B4A0 VA: 0x18136CEA0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x136D1F0 Offset: 0x136B7F0 VA: 0x18136D1F0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x136D240 Offset: 0x136B840 VA: 0x18136D240 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x136D2E0 Offset: 0x136B8E0 VA: 0x18136D2E0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x136D260 Offset: 0x136B860 VA: 0x18136D260 Slot: 9
	public override void Reset() { }
}

// Namespace: System.Text
[Serializable]
internal abstract class EncodingNLS : Encoding // TypeDefIndex: 674
{
	// Methods

	// RVA: 0x136F6D0 Offset: 0x136DCD0 VA: 0x18136F6D0
	protected void .ctor(int codePage) { }

	// RVA: 0x136E4E0 Offset: 0x136CAE0 VA: 0x18136E4E0 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x136E340 Offset: 0x136C940 VA: 0x18136E340 Slot: 11
	public override int GetByteCount(string s) { }

	// RVA: 0x136E3E0 Offset: 0x136C9E0 VA: 0x18136E3E0 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x136E690 Offset: 0x136CC90 VA: 0x18136E690 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x136EAA0 Offset: 0x136D0A0 VA: 0x18136EAA0 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x136E970 Offset: 0x136CF70 VA: 0x18136E970 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x136ED70 Offset: 0x136D370 VA: 0x18136ED70 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x136EF20 Offset: 0x136D520 VA: 0x18136EF20 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x136F150 Offset: 0x136D750 VA: 0x18136F150 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x136F020 Offset: 0x136D620 VA: 0x18136F020 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x136F520 Offset: 0x136DB20 VA: 0x18136F520 Slot: 35
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x136F420 Offset: 0x136DA20 VA: 0x18136F420 Slot: 30
	public override Decoder GetDecoder() { }

	// RVA: 0x136F480 Offset: 0x136DA80 VA: 0x18136F480 Slot: 31
	public override Encoder GetEncoder() { }
}

// Namespace: System.Text
public abstract class EncodingProvider // TypeDefIndex: 675
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x136FA00 Offset: 0x136E000 VA: 0x18136FA00 Slot: 6
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x136F800 Offset: 0x136DE00 VA: 0x18136F800
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x136F900 Offset: 0x136DF00 VA: 0x18136F900
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x136F6E0 Offset: 0x136DCE0 VA: 0x18136F6E0
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

	// RVA: 0x136FB20 Offset: 0x136E120 VA: 0x18136FB20
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 676
{
	// Fields
	internal static readonly Latin1Encoding s_default; // 0x0
	private static readonly char[] arrayCharBestFit; // 0x8

	// Methods

	// RVA: 0x1371090 Offset: 0x136F690 VA: 0x181371090
	public void .ctor() { }

	// RVA: 0x1371040 Offset: 0x136F640 VA: 0x181371040
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1370E80 Offset: 0x136F480 VA: 0x181370E80 Slot: 38
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1370420 Offset: 0x136EA20 VA: 0x181370420 Slot: 14
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x1370690 Offset: 0x136EC90 VA: 0x181370690 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1370B70 Offset: 0x136F170 VA: 0x181370B70 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1370B80 Offset: 0x136F180 VA: 0x181370B80 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x1370C00 Offset: 0x136F200 VA: 0x181370C00 Slot: 32
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1370D40 Offset: 0x136F340 VA: 0x181370D40 Slot: 33
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x13703D0 Offset: 0x136E9D0 VA: 0x1813703D0 Slot: 36
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1370F60 Offset: 0x136F560 VA: 0x181370F60
	private static void .cctor() { }
}

// Namespace: System.Text
public enum NormalizationForm // TypeDefIndex: 677
{
	// Fields
	public int value__; // 0x0
	public const NormalizationForm FormC = 1;
	public const NormalizationForm FormD = 2;
	public const NormalizationForm FormKC = 5;
	public const NormalizationForm FormKD = 6;
}

// Namespace: System.Text
[DefaultMember("Chars")]
[Serializable]
public sealed class StringBuilder : ISerializable // TypeDefIndex: 678
{
	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28

	// Properties
	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }
	private Span<char> RemainingCurrentChunk { get; }

	// Methods

	// RVA: 0x1375450 Offset: 0x1373A50 VA: 0x181375450
	public void .ctor() { }

	// RVA: 0x13754B0 Offset: 0x1373AB0 VA: 0x1813754B0
	public void .ctor(int capacity) { }

	// RVA: 0x1375DF0 Offset: 0x13743F0 VA: 0x181375DF0
	public void .ctor(string value) { }

	// RVA: 0x1375E20 Offset: 0x1374420 VA: 0x181375E20
	public void .ctor(string value, int capacity) { }

	// RVA: 0x13756B0 Offset: 0x1373CB0 VA: 0x1813756B0
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x13754C0 Offset: 0x1373AC0 VA: 0x1813754C0
	public void .ctor(int capacity, int maxCapacity) { }

	// RVA: 0x13759A0 Offset: 0x1373FA0 VA: 0x1813759A0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1374D40 Offset: 0x1373340 VA: 0x181374D40 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1375E50 Offset: 0x1374450 VA: 0x181375E50
	public int get_Capacity() { }

	// RVA: 0x1375FF0 Offset: 0x13745F0 VA: 0x181375FF0
	public void set_Capacity(int value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_MaxCapacity() { }

	// RVA: 0x1375320 Offset: 0x1373920 VA: 0x181375320 Slot: 3
	public override string ToString() { }

	// RVA: 0x13750E0 Offset: 0x13736E0 VA: 0x1813750E0
	public string ToString(int startIndex, int length) { }

	// RVA: 0x1372E20 Offset: 0x1371420 VA: 0x181372E20
	public StringBuilder Clear() { }

	// RVA: 0x1375F40 Offset: 0x1374540 VA: 0x181375F40
	public int get_Length() { }

	// RVA: 0x13762E0 Offset: 0x13748E0 VA: 0x1813762E0
	public void set_Length(int value) { }

	// RVA: 0x1375E70 Offset: 0x1374470 VA: 0x181375E70
	public char get_Chars(int index) { }

	// RVA: 0x13761C0 Offset: 0x13747C0 VA: 0x1813761C0
	public void set_Chars(int index, char value) { }

	// RVA: 0x1372AB0 Offset: 0x13710B0 VA: 0x181372AB0
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x1372800 Offset: 0x1370E00 VA: 0x181372800
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x1372320 Offset: 0x1370920 VA: 0x181372320
	public StringBuilder Append(string value) { }

	// RVA: 0x1372220 Offset: 0x1370820 VA: 0x181372220
	private void AppendHelper(string value) { }

	// RVA: 0x1372C30 Offset: 0x1371230 VA: 0x181372C30
	public StringBuilder Append(string value, int startIndex, int count) { }

	// RVA: 0x1372780 Offset: 0x1370D80 VA: 0x181372780
	public StringBuilder Append(StringBuilder value) { }

	// RVA: 0x13712A0 Offset: 0x136F8A0 VA: 0x1813712A0
	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	// RVA: 0x1372270 Offset: 0x1370870 VA: 0x181372270
	public StringBuilder AppendLine() { }

	// RVA: 0x13722A0 Offset: 0x13708A0 VA: 0x1813722A0
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x1372E40 Offset: 0x1371440 VA: 0x181372E40
	public void CopyTo(int sourceIndex, Span<char> destination, int count) { }

	// RVA: 0x1373EE0 Offset: 0x13724E0 VA: 0x181373EE0
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x13729E0 Offset: 0x1370FE0 VA: 0x1813729E0
	public StringBuilder Append(bool value) { }

	// RVA: 0x1372710 Offset: 0x1370D10 VA: 0x181372710
	public StringBuilder Append(char value) { }

	// RVA: 0x1372470 Offset: 0x1370A70 VA: 0x181372470
	public StringBuilder Append(byte value) { }

	// RVA: 0x1372420 Offset: 0x1370A20 VA: 0x181372420
	public StringBuilder Append(int value) { }

	// RVA: 0x13722D0 Offset: 0x13708D0 VA: 0x1813722D0
	public StringBuilder Append(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x13726C0 Offset: 0x1370CC0 VA: 0x1813726C0
	public StringBuilder Append(uint value) { }

	// RVA: -1 Offset: -1
	private StringBuilder AppendSpanFormattable<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B8130 Offset: 0x7B6730 VA: 0x1807B8130
	|-StringBuilder.AppendSpanFormattable<byte>
	|
	|-RVA: 0x7B81C0 Offset: 0x7B67C0 VA: 0x1807B81C0
	|-StringBuilder.AppendSpanFormattable<double>
	|
	|-RVA: 0x7B8390 Offset: 0x7B6990 VA: 0x1807B8390
	|-StringBuilder.AppendSpanFormattable<int>
	|
	|-RVA: 0x7B8420 Offset: 0x7B6A20 VA: 0x1807B8420
	|-StringBuilder.AppendSpanFormattable<uint>
	|
	|-RVA: 0x7B8250 Offset: 0x7B6850 VA: 0x1807B8250
	|-StringBuilder.AppendSpanFormattable<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x13724C0 Offset: 0x1370AC0 VA: 0x1813724C0
	public StringBuilder Append(object value) { }

	// RVA: 0x13727C0 Offset: 0x1370DC0 VA: 0x1813727C0
	public StringBuilder Append(char[] value) { }

	// RVA: 0x1372A30 Offset: 0x1371030 VA: 0x181372A30
	public StringBuilder Append(ReadOnlySpan<char> value) { }

	// RVA: 0x1373940 Offset: 0x1371F40 VA: 0x181373940
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x13732E0 Offset: 0x13718E0 VA: 0x1813732E0
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x13721B0 Offset: 0x13707B0 VA: 0x1813721B0
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x1372130 Offset: 0x1370730 VA: 0x181372130
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x1371F50 Offset: 0x1370550 VA: 0x181371F50
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x13720B0 Offset: 0x13706B0 VA: 0x1813720B0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x1372020 Offset: 0x1370620 VA: 0x181372020
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1371E70 Offset: 0x1370470 VA: 0x181371E70
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x1373290 Offset: 0x1371890 VA: 0x181373290
	private static void FormatError() { }

	// RVA: 0x1371500 Offset: 0x136FB00 VA: 0x181371500
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x1374C40 Offset: 0x1373240 VA: 0x181374C40
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x13747A0 Offset: 0x1372DA0 VA: 0x1813747A0
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1372510 Offset: 0x1370B10 VA: 0x181372510
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x1373310 Offset: 0x1371910 VA: 0x181373310
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x13743E0 Offset: 0x13729E0 VA: 0x1813743E0
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x1374C70 Offset: 0x1373270 VA: 0x181374C70
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x13745E0 Offset: 0x1372BE0 VA: 0x1813745E0
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x1374E70 Offset: 0x1373470 VA: 0x181374E70
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1374F40 Offset: 0x1373540 VA: 0x181374F40
	private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count) { }

	// RVA: 0x1373250 Offset: 0x1371850 VA: 0x181373250
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x1375F50 Offset: 0x1374550 VA: 0x181375F50
	private Span<char> get_RemainingCurrentChunk() { }

	// RVA: 0x1373E80 Offset: 0x1372480 VA: 0x181373E80
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x1373060 Offset: 0x1371660 VA: 0x181373060
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x1375D80 Offset: 0x1374380 VA: 0x181375D80
	private void .ctor(StringBuilder from) { }

	// RVA: 0x1373A00 Offset: 0x1372000 VA: 0x181373A00
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	// RVA: 0x1375CE0 Offset: 0x13742E0 VA: 0x181375CE0
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x1374200 Offset: 0x1372800 VA: 0x181374200
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }
}

// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 679
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x13710A0 Offset: 0x136F6A0 VA: 0x1813710A0
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x1371220 Offset: 0x136F820 VA: 0x181371220
	public static void Release(StringBuilder sb) { }

	// RVA: 0x1371180 Offset: 0x136F780 VA: 0x181371180
	public static string GetStringAndRelease(StringBuilder sb) { }
}

// Namespace: System.Text
[Serializable]
public sealed class UTF32Encoding : Encoding // TypeDefIndex: 681
{
	// Fields
	internal static readonly UTF32Encoding s_default; // 0x0
	internal static readonly UTF32Encoding s_bigEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	private bool _emitUTF32ByteOrderMark; // 0x38
	private bool _isThrowException; // 0x39
	private bool _bigEndian; // 0x3A

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x1379000 Offset: 0x1377600 VA: 0x181379000
	public void .ctor() { }

	// RVA: 0x13790A0 Offset: 0x13776A0 VA: 0x1813790A0
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1379030 Offset: 0x1377630 VA: 0x181379030
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x1378D70 Offset: 0x1377370 VA: 0x181378D70 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x13769E0 Offset: 0x1374FE0 VA: 0x1813769E0 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1376B90 Offset: 0x1375190 VA: 0x181376B90 Slot: 11
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1376C30 Offset: 0x1375230 VA: 0x181376C30 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1377130 Offset: 0x1375730 VA: 0x181377130 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1376D30 Offset: 0x1375330 VA: 0x181376D30 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1377000 Offset: 0x1375600 VA: 0x181377000 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1377CC0 Offset: 0x13762C0 VA: 0x181377CC0 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1377BC0 Offset: 0x13761C0 VA: 0x181377BC0 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1377FA0 Offset: 0x13765A0 VA: 0x181377FA0 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1377E70 Offset: 0x1376470 VA: 0x181377E70 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1378BA0 Offset: 0x13771A0 VA: 0x181378BA0 Slot: 35
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1376680 Offset: 0x1374C80 VA: 0x181376680 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1377410 Offset: 0x1375A10 VA: 0x181377410 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1377870 Offset: 0x1375E70 VA: 0x181377870 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1378270 Offset: 0x1376870 VA: 0x181378270 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1378D50 Offset: 0x1377350 VA: 0x181378D50
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x1378890 Offset: 0x1376E90 VA: 0x181378890
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x13788B0 Offset: 0x1376EB0 VA: 0x1813788B0
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x13786E0 Offset: 0x1376CE0 VA: 0x1813786E0 Slot: 30
	public override Decoder GetDecoder() { }

	// RVA: 0x1378740 Offset: 0x1376D40 VA: 0x181378740 Slot: 31
	public override Encoder GetEncoder() { }

	// RVA: 0x13788D0 Offset: 0x1376ED0 VA: 0x1813788D0 Slot: 32
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1378A10 Offset: 0x1377010 VA: 0x181378A10 Slot: 33
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1378AF0 Offset: 0x13770F0 VA: 0x181378AF0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x13790F0 Offset: 0x13776F0 VA: 0x1813790F0 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x13765B0 Offset: 0x1374BB0 VA: 0x1813765B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13787E0 Offset: 0x1376DE0 VA: 0x1813787E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1378E60 Offset: 0x1377460 VA: 0x181378E60
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 686
{
	// Fields
	internal static readonly UTF7Encoding s_default; // 0x0
	private byte[] _base64Bytes; // 0x38
	private sbyte[] _base64Values; // 0x40
	private bool[] _directEncode; // 0x48
	private bool _allowOptionals; // 0x50

	// Methods

	// RVA: 0x137B2A0 Offset: 0x13798A0 VA: 0x18137B2A0
	public void .ctor() { }

	// RVA: 0x137B2D0 Offset: 0x13798D0 VA: 0x18137B2D0
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x137AF10 Offset: 0x1379510 VA: 0x18137AF10
	private void MakeTables() { }

	// RVA: 0x137B170 Offset: 0x1379770 VA: 0x18137B170 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1379250 Offset: 0x1377850 VA: 0x181379250 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x137AB60 Offset: 0x1379160 VA: 0x18137AB60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1379500 Offset: 0x1377B00 VA: 0x181379500 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1379460 Offset: 0x1377A60 VA: 0x181379460 Slot: 11
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1379320 Offset: 0x1377920 VA: 0x181379320 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1379980 Offset: 0x1377F80 VA: 0x181379980 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x13796B0 Offset: 0x1377CB0 VA: 0x1813796B0 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1379FF0 Offset: 0x13785F0 VA: 0x181379FF0 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x137A220 Offset: 0x1378820 VA: 0x18137A220 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x137A120 Offset: 0x1378720 VA: 0x18137A120 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x137A660 Offset: 0x1378C60 VA: 0x18137A660 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x137A930 Offset: 0x1378F30 VA: 0x18137A930 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x137AD60 Offset: 0x1379360 VA: 0x18137AD60 Slot: 35
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1379420 Offset: 0x1377A20 VA: 0x181379420 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1379C60 Offset: 0x1378260 VA: 0x181379C60 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x137A3D0 Offset: 0x13789D0 VA: 0x18137A3D0 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x137A410 Offset: 0x1378A10 VA: 0x18137A410 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x137AA60 Offset: 0x1379060 VA: 0x18137AA60 Slot: 30
	public override Decoder GetDecoder() { }

	// RVA: 0x137AAC0 Offset: 0x13790C0 VA: 0x18137AAC0 Slot: 31
	public override Encoder GetEncoder() { }

	// RVA: 0x137ABE0 Offset: 0x13791E0 VA: 0x18137ABE0 Slot: 32
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x137ACD0 Offset: 0x13792D0 VA: 0x18137ACD0 Slot: 33
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x137B220 Offset: 0x1379820 VA: 0x18137B220
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 690
{
	// Fields
	internal static readonly UTF8Encoding.UTF8EncodingSealed s_default; // 0x0
	internal static readonly byte[] s_preamble; // 0x8
	internal readonly bool _emitUTF8Identifier; // 0x38
	private bool _isThrowException; // 0x39

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x137EC30 Offset: 0x137D230 VA: 0x18137EC30
	public void .ctor() { }

	// RVA: 0x137EC60 Offset: 0x137D260 VA: 0x18137EC60
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x137EBD0 Offset: 0x137D1D0 VA: 0x18137EBD0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x137EA00 Offset: 0x137D000 VA: 0x18137EA00 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x137BC20 Offset: 0x137A220 VA: 0x18137BC20 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x137B4B0 Offset: 0x1379AB0 VA: 0x18137B4B0 Slot: 11
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x137BDD0 Offset: 0x137A3D0 VA: 0x18137BDD0 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x137CAA0 Offset: 0x137B0A0 VA: 0x18137CAA0 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x137CD80 Offset: 0x137B380 VA: 0x18137CD80 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x137C970 Offset: 0x137AF70 VA: 0x18137C970 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x137D620 Offset: 0x137BC20 VA: 0x18137D620 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x137D520 Offset: 0x137BB20 VA: 0x18137D520 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x137D7D0 Offset: 0x137BDD0 VA: 0x18137D7D0 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x137E2B0 Offset: 0x137C8B0 VA: 0x18137E2B0 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x137E820 Offset: 0x137CE20 VA: 0x18137E820 Slot: 35
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x137B550 Offset: 0x1379B50 VA: 0x18137B550 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x137E9F0 Offset: 0x137CFF0 VA: 0x18137E9F0
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x137E9E0 Offset: 0x137CFE0 VA: 0x18137E9E0
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x137E9D0 Offset: 0x137CFD0 VA: 0x18137E9D0
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x137C130 Offset: 0x137A730 VA: 0x18137C130 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x137D050 Offset: 0x137B650 VA: 0x18137D050 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x137DAA0 Offset: 0x137C0A0 VA: 0x18137DAA0 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x137B430 Offset: 0x1379A30 VA: 0x18137B430
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x137B3E0 Offset: 0x13799E0 VA: 0x18137B3E0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x137BED0 Offset: 0x137A4D0 VA: 0x18137BED0
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x137E3E0 Offset: 0x137C9E0 VA: 0x18137E3E0 Slot: 30
	public override Decoder GetDecoder() { }

	// RVA: 0x137E440 Offset: 0x137CA40 VA: 0x18137E440 Slot: 31
	public override Encoder GetEncoder() { }

	// RVA: 0x137E510 Offset: 0x137CB10 VA: 0x18137E510 Slot: 32
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x137E650 Offset: 0x137CC50 VA: 0x18137E650 Slot: 33
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x137E790 Offset: 0x137CD90 VA: 0x18137E790 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x137EC90 Offset: 0x137D290 VA: 0x18137EC90 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x137B310 Offset: 0x1379910 VA: 0x18137B310 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x137E4A0 Offset: 0x137CAA0 VA: 0x18137E4A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x137EAF0 Offset: 0x137D0F0 VA: 0x18137EAF0
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
public class UnicodeEncoding : Encoding // TypeDefIndex: 692
{
	// Fields
	internal static readonly UnicodeEncoding s_bigEndianDefault; // 0x0
	internal static readonly UnicodeEncoding s_littleEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x20

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x1395C40 Offset: 0x1394240 VA: 0x181395C40
	public void .ctor() { }

	// RVA: 0x1395BF0 Offset: 0x13941F0 VA: 0x181395BF0
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1395B80 Offset: 0x1394180 VA: 0x181395B80
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	// RVA: 0x13958C0 Offset: 0x1393EC0 VA: 0x1813958C0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1391D50 Offset: 0x1390350 VA: 0x181391D50 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1392640 Offset: 0x1390C40 VA: 0x181392640 Slot: 11
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x13926E0 Offset: 0x1390CE0 VA: 0x1813926E0 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x13927E0 Offset: 0x1390DE0 VA: 0x1813927E0 Slot: 19
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1393420 Offset: 0x1391A20 VA: 0x181393420 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x13936F0 Offset: 0x1391CF0 VA: 0x1813936F0 Slot: 21
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x13941C0 Offset: 0x13927C0 VA: 0x1813941C0 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x13940C0 Offset: 0x13926C0 VA: 0x1813940C0 Slot: 23
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1394FA0 Offset: 0x13935A0 VA: 0x181394FA0 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1394E70 Offset: 0x1393470 VA: 0x181394E70 Slot: 27
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1395710 Offset: 0x1393D10 VA: 0x181395710 Slot: 35
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1391F00 Offset: 0x1390500 VA: 0x181391F00 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1392AC0 Offset: 0x13910C0 VA: 0x181392AC0 Slot: 20
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1393820 Offset: 0x1391E20 VA: 0x181393820 Slot: 24
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1394370 Offset: 0x1392970 VA: 0x181394370 Slot: 28
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x13952D0 Offset: 0x13938D0 VA: 0x1813952D0 Slot: 31
	public override Encoder GetEncoder() { }

	// RVA: 0x1395270 Offset: 0x1393870 VA: 0x181395270 Slot: 30
	public override Decoder GetDecoder() { }

	// RVA: 0x1395660 Offset: 0x1393C60 VA: 0x181395660 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1395C70 Offset: 0x1394270 VA: 0x181395C70 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x13953D0 Offset: 0x13939D0 VA: 0x1813953D0 Slot: 32
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1395510 Offset: 0x1393B10 VA: 0x181395510 Slot: 33
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1391C30 Offset: 0x1390230 VA: 0x181391C30 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1395330 Offset: 0x1393930 VA: 0x181395330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13959B0 Offset: 0x1393FB0 VA: 0x1813959B0
	private static void .cctor() { }
}

// Namespace: System.Text
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 693
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }
	public char Item { get; }

	// Methods

	// RVA: 0x1396880 Offset: 0x1394E80 VA: 0x181396880
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Length() { }

	// RVA: 0x1396890 Offset: 0x1394E90 VA: 0x181396890
	public ref char get_Item(int index) { }

	// RVA: 0x13966B0 Offset: 0x1394CB0 VA: 0x1813966B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1396790 Offset: 0x1394D90 VA: 0x181396790
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x1396380 Offset: 0x1394980 VA: 0x181396380
	public void Append(char c) { }

	// RVA: 0x13960E0 Offset: 0x13946E0 VA: 0x1813960E0
	public void Append(string s) { }

	// RVA: 0x1395DD0 Offset: 0x13943D0 VA: 0x181395DD0
	private void AppendSlow(string s) { }

	// RVA: 0x13962A0 Offset: 0x13948A0 VA: 0x1813962A0
	public void Append(char c, int count) { }

	// RVA: 0x1396000 Offset: 0x1394600 VA: 0x181396000
	public void Append(char* value, int length) { }

	// RVA: 0x1395F20 Offset: 0x1394520 VA: 0x181395F20
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x1396490 Offset: 0x1394A90 VA: 0x181396490
	private void GrowAndAppend(char c) { }

	// RVA: 0x1396500 Offset: 0x1394B00 VA: 0x181396500
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x13963F0 Offset: 0x13949F0 VA: 0x1813963F0
	public void Dispose() { }
}

// Namespace: System.Text
[ComVisible(True)]
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 698
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Dictionary<int, Encoding> encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x21
	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual ReadOnlySpan<byte> Preamble { get; }
	public virtual string EncodingName { get; }
	public virtual string WebName { get; }
	[ComVisible(False)]
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisible(False)]
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisible(False)]
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x1385BE0 Offset: 0x13841E0 VA: 0x181385BE0
	protected void .ctor() { }

	// RVA: 0x1385C20 Offset: 0x1384220 VA: 0x181385C20
	protected void .ctor(int codePage) { }

	// RVA: 0x13857E0 Offset: 0x1383DE0 VA: 0x1813857E0 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x1385630 Offset: 0x1383C30 VA: 0x181385630
	internal void OnDeserializing() { }

	// RVA: 0x13855E0 Offset: 0x1383BE0 VA: 0x1813855E0
	internal void OnDeserialized() { }

	[OnDeserializing]
	// RVA: 0x1385630 Offset: 0x1383C30 VA: 0x181385630
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x13855E0 Offset: 0x1383BE0 VA: 0x1813855E0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x1122980 Offset: 0x1120F80 VA: 0x181122980
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1382F10 Offset: 0x1381510 VA: 0x181382F10
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1385670 Offset: 0x1383C70 VA: 0x181385670
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1385F30 Offset: 0x1384530 VA: 0x181385F30
	private static object get_InternalSyncObject() { }

	// RVA: 0x1384660 Offset: 0x1382C60 VA: 0x181384660
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x1384350 Offset: 0x1382950 VA: 0x181384350
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x13845D0 Offset: 0x1382BD0 VA: 0x1813845D0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x1385250 Offset: 0x1383850 VA: 0x181385250 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x1386090 Offset: 0x1384690 VA: 0x181386090 Slot: 7
	public virtual ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x1384140 Offset: 0x1382740 VA: 0x181384140
	private void GetDataItem() { }

	// RVA: 0x1385F20 Offset: 0x1384520 VA: 0x181385F20 Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x1386410 Offset: 0x1384A10 VA: 0x181386410 Slot: 9
	public virtual string get_WebName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x1386620 Offset: 0x1384C20 VA: 0x181386620
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x1386550 Offset: 0x1384B50 VA: 0x181386550
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisible(False)]
	// RVA: 0x1382E30 Offset: 0x1381430 VA: 0x181382E30 Slot: 10
	public virtual object Clone() { }

	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	public bool get_IsReadOnly() { }

	// RVA: 0x1385CB0 Offset: 0x13842B0 VA: 0x181385CB0
	public static Encoding get_ASCII() { }

	// RVA: 0x1385FD0 Offset: 0x13845D0 VA: 0x181385FD0
	private static Encoding get_Latin1() { }

	// RVA: 0x1383410 Offset: 0x1381A10 VA: 0x181383410 Slot: 11
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetByteCount(char[] chars, int index, int count);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x13834B0 Offset: 0x1381AB0 VA: 0x1813834B0 Slot: 13
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x1383650 Offset: 0x1381C50 VA: 0x181383650 Slot: 14
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x13839C0 Offset: 0x1381FC0 VA: 0x1813839C0 Slot: 15
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x13838D0 Offset: 0x1381ED0 VA: 0x1813838D0 Slot: 16
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x1383A70 Offset: 0x1382070 VA: 0x181383A70 Slot: 18
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1383B80 Offset: 0x1382180 VA: 0x181383B80 Slot: 19
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x13839A0 Offset: 0x1381FA0 VA: 0x1813839A0 Slot: 20
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x1383670 Offset: 0x1381C70 VA: 0x181383670 Slot: 21
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x1383C30 Offset: 0x1382230 VA: 0x181383C30 Slot: 23
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1383DD0 Offset: 0x13823D0 VA: 0x181383DD0 Slot: 24
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1383DF0 Offset: 0x13823F0 VA: 0x181383DF0 Slot: 25
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x1383EE0 Offset: 0x13824E0 VA: 0x181383EE0 Slot: 27
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1383EC0 Offset: 0x13824C0 VA: 0x181383EC0 Slot: 28
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x1385350 Offset: 0x1383950 VA: 0x181385350
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x1385450 Offset: 0x1383A50 VA: 0x181385450
	public string GetString(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 29
	public virtual int get_CodePage() { }

	// RVA: 0x1384270 Offset: 0x1382870 VA: 0x181384270 Slot: 30
	public virtual Decoder GetDecoder() { }

	// RVA: 0x1382EC0 Offset: 0x13814C0 VA: 0x181382EC0
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x38E210 Offset: 0x38C810 VA: 0x18038E210
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x1385E40 Offset: 0x1384440 VA: 0x181385E40
	public static Encoding get_Default() { }

	// RVA: 0x13842E0 Offset: 0x13828E0 VA: 0x1813842E0 Slot: 31
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x13852A0 Offset: 0x13838A0 VA: 0x1813852A0 Slot: 34
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x13855B0 Offset: 0x1383BB0 VA: 0x1813855B0 Slot: 35
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1386340 Offset: 0x1384940 VA: 0x181386340
	public static Encoding get_Unicode() { }

	// RVA: 0x1385D70 Offset: 0x1384370 VA: 0x181385D70
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x13861C0 Offset: 0x13847C0 VA: 0x1813861C0
	public static Encoding get_UTF7() { }

	// RVA: 0x1386280 Offset: 0x1384880 VA: 0x181386280
	public static Encoding get_UTF8() { }

	// RVA: 0x1386100 Offset: 0x1384700 VA: 0x181386100
	public static Encoding get_UTF32() { }

	// RVA: 0x13832A0 Offset: 0x13818A0 VA: 0x1813832A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13851E0 Offset: 0x13837E0 VA: 0x1813851E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13833C0 Offset: 0x13819C0 VA: 0x1813833C0 Slot: 36
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1383370 Offset: 0x1381970 VA: 0x181383370 Slot: 37
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x1385880 Offset: 0x1383E80 VA: 0x181385880
	internal void ThrowBytesOverflow() { }

	// RVA: 0x1385990 Offset: 0x1383F90 VA: 0x181385990
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x1385A30 Offset: 0x1384030 VA: 0x181385A30
	internal void ThrowCharsOverflow() { }

	// RVA: 0x1385B40 Offset: 0x1384140 VA: 0x181385B40
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

// Namespace: System.Text
internal enum NormalizationCheck // TypeDefIndex: 699
{
	// Fields
	public int value__; // 0x0
	public const NormalizationCheck Yes = 0;
	public const NormalizationCheck No = 1;
	public const NormalizationCheck Maybe = 2;
}

// Namespace: System.Text
internal class Normalization // TypeDefIndex: 700
{
	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x1388A30 Offset: 0x1387030 VA: 0x181388A30
	private static uint PropValue(int cp) { }

	// RVA: 0x1386FA0 Offset: 0x13855A0 VA: 0x181386FA0
	private static int CharMapIdx(int cp) { }

	// RVA: 0x13886B0 Offset: 0x1386CB0 VA: 0x1813886B0
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x1388760 Offset: 0x1386D60 VA: 0x181388760
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x1388810 Offset: 0x1386E10 VA: 0x181388810
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x1387580 Offset: 0x1385B80 VA: 0x181387580
	private static string Compose(string source, int checkType) { }

	// RVA: 0x1387220 Offset: 0x1385820 VA: 0x181387220
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x1387350 Offset: 0x1385950 VA: 0x181387350
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x1387030 Offset: 0x1385630 VA: 0x181387030
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x1388200 Offset: 0x1386800 VA: 0x181388200
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x1388E90 Offset: 0x1387490 VA: 0x181388E90
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x1389210 Offset: 0x1387810 VA: 0x181389210
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x1387990 Offset: 0x1385F90 VA: 0x181387990
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x1387F10 Offset: 0x1386510 VA: 0x181387F10
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x1388C00 Offset: 0x1387200 VA: 0x181388C00
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x1387770 Offset: 0x1385D70 VA: 0x181387770
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x1388AC0 Offset: 0x13870C0 VA: 0x181388AC0
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x1388250 Offset: 0x1386850 VA: 0x181388250
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x1388380 Offset: 0x1386980 VA: 0x181388380
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x13888C0 Offset: 0x1386EC0 VA: 0x1813888C0
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x1388990 Offset: 0x1386F90 VA: 0x181388990
	public static string Normalize(string source, int type) { }

	// RVA: 0x13895C0 Offset: 0x1387BC0 VA: 0x1813895C0
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x1389370 Offset: 0x1387970 VA: 0x181389370
	private static void .cctor() { }
}

// Namespace: System.Text
internal static class EncodingHelper // TypeDefIndex: 701
{
	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x1382C30 Offset: 0x1381230 VA: 0x181382C30
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x1382630 Offset: 0x1380C30 VA: 0x181382630
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x1382520 Offset: 0x1380B20 VA: 0x181382520
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x1382640 Offset: 0x1380C40 VA: 0x181382640
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x1382BB0 Offset: 0x13811B0 VA: 0x181382BB0
	private static void .cctor() { }
}

// Namespace: System.Text
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 13645
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x1396880 Offset: 0x1394E80 VA: 0x181396880
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Length() { }

	// RVA: 0x1BAF640 Offset: 0x1BADC40 VA: 0x181BAF640 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BAF720 Offset: 0x1BADD20 VA: 0x181BAF720
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x1BAF460 Offset: 0x1BADA60 VA: 0x181BAF460
	public void Insert(int index, char value, int count) { }

	// RVA: 0x1BAF160 Offset: 0x1BAD760 VA: 0x181BAF160
	public void Append(char c) { }

	// RVA: 0x1BAEFD0 Offset: 0x1BAD5D0 VA: 0x181BAEFD0
	public void Append(string s) { }

	// RVA: 0x1BAECC0 Offset: 0x1BAD2C0 VA: 0x181BAECC0
	private void AppendSlow(string s) { }

	// RVA: 0x1BAEEF0 Offset: 0x1BAD4F0 VA: 0x181BAEEF0
	public void Append(char c, int count) { }

	// RVA: 0x1BAF080 Offset: 0x1BAD680 VA: 0x181BAF080
	public void Append(char* value, int length) { }

	// RVA: 0x1BAEE10 Offset: 0x1BAD410 VA: 0x181BAEE10
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x1BAF270 Offset: 0x1BAD870 VA: 0x181BAF270
	private void GrowAndAppend(char c) { }

	// RVA: 0x1BAF2B0 Offset: 0x1BAD8B0 VA: 0x181BAF2B0
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x1BAF1D0 Offset: 0x1BAD7D0 VA: 0x181BAF1D0
	public void Dispose() { }
}

// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 13860
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x1BC8C60 Offset: 0x1BC7260 VA: 0x181BC8C60
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x1BC8DC0 Offset: 0x1BC73C0 VA: 0x181BC8DC0
	public static void Release(StringBuilder sb) { }

	// RVA: 0x1BC8D30 Offset: 0x1BC7330 VA: 0x181BC8D30
	public static string GetStringAndRelease(StringBuilder sb) { }
}

