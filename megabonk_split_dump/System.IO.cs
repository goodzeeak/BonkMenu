// Namespace: System.IO
internal struct DisableMediaInsertionPrompt : IDisposable // TypeDefIndex: 1572
{
	// Fields
	private bool _disableSuccess; // 0x0
	private uint _oldMode; // 0x4
	private static bool useUWPFallback; // 0x0

	// Methods

	// RVA: 0x14B8790 Offset: 0x14B6D90 VA: 0x1814B8790
	public static DisableMediaInsertionPrompt Create() { }

	// RVA: 0x14B8810 Offset: 0x14B6E10 VA: 0x1814B8810 Slot: 4
	public void Dispose() { }
}

// Namespace: System.IO
internal static class FileSystem // TypeDefIndex: 1574
{
	// Methods

	// RVA: 0x14BB120 Offset: 0x14B9720 VA: 0x1814BB120
	public static void ReplaceFile(string sourceFullPath, string destFullPath, string destBackupFullPath, bool ignoreMetadataErrors) { }

	// RVA: 0x14BA1F0 Offset: 0x14B87F0 VA: 0x1814BA1F0
	public static void CreateDirectory(string fullPath) { }

	// RVA: 0x14BA7B0 Offset: 0x14B8DB0 VA: 0x1814BA7B0
	public static void DeleteFile(string fullPath) { }

	// RVA: 0x14BA8F0 Offset: 0x14B8EF0 VA: 0x1814BA8F0
	public static bool DirectoryExists(string fullPath) { }

	// RVA: 0x14BA940 Offset: 0x14B8F40 VA: 0x1814BA940
	private static bool DirectoryExists(string path, out int lastError) { }

	// RVA: 0x14BA9E0 Offset: 0x14B8FE0 VA: 0x1814BA9E0
	internal static int FillAttributeInfo(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound) { }

	// RVA: 0x14BA990 Offset: 0x14B8F90 VA: 0x1814BA990
	public static bool FileExists(string fullPath) { }

	// RVA: 0x14BAF90 Offset: 0x14B9590 VA: 0x1814BAF90
	public static FileAttributes GetAttributes(string fullPath) { }

	// RVA: 0x14BB000 Offset: 0x14B9600 VA: 0x1814BB000
	public static void MoveFile(string sourceFullPath, string destFullPath) { }

	// RVA: 0x14BB1B0 Offset: 0x14B97B0 VA: 0x1814BB1B0
	private static bool UnityCreateDirectory(string name) { }

	// RVA: 0x14BB5B0 Offset: 0x14B9BB0 VA: 0x1814BB5B0
	private static bool UnityGetFileAttributesEx(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data) { }

	// RVA: 0x14BB250 Offset: 0x14B9850 VA: 0x1814BB250
	internal static IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

	// RVA: 0x14BB320 Offset: 0x14B9920 VA: 0x1814BB320
	private static bool UnityDeleteFile(string path) { }

	// RVA: 0x14BB710 Offset: 0x14B9D10 VA: 0x1814BB710
	private static bool UnityMoveFile(string sourceFullPath, string destFullPath) { }

	// RVA: 0x14BB400 Offset: 0x14B9A00 VA: 0x1814BB400
	private static SafeFindHandle UnityFindFirstFile(string path, ref Interop.Kernel32.WIN32_FIND_DATA findData) { }

	// RVA: 0x14BA190 Offset: 0x14B8790 VA: 0x1814BA190
	private static bool BrokeredCreateDirectory(string path) { }

	// RVA: 0x14BA1B0 Offset: 0x14B87B0 VA: 0x1814BA1B0
	private static bool BrokeredGetFileAttributes(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data) { }

	// RVA: 0x14BA1D0 Offset: 0x14B87D0 VA: 0x1814BA1D0
	private static IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes) { }

	// RVA: 0x14BA1C0 Offset: 0x14B87C0 VA: 0x1814BA1C0
	private static bool BrokeredMoveFile(string sourceFullPath, string destFullPath) { }

	// RVA: 0x14BA190 Offset: 0x14B8790 VA: 0x1814BA190
	private static bool BrokeredDeleteFile(string path) { }

	// RVA: 0x14BA1A0 Offset: 0x14B87A0 VA: 0x1814BA1A0
	private static IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes) { }

	// RVA: 0x14BA1E0 Offset: 0x14B87E0 VA: 0x1814BA1E0
	private static int BrokeredSafeFindHandleDispose(IntPtr handle) { }

	// RVA: 0x14BB0B0 Offset: 0x14B96B0 VA: 0x1814BB0B0
	private static string RemoveExtendedPathPrefix(string path) { }
}

// Namespace: System.IO
[Serializable]
public class DirectoryNotFoundException : IOException // TypeDefIndex: 1575
{
	// Methods

	// RVA: 0x14B7E50 Offset: 0x14B6450 VA: 0x1814B7E50
	public void .ctor() { }

	// RVA: 0x14B7EA0 Offset: 0x14B64A0 VA: 0x1814B7EA0
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
[Serializable]
public class EndOfStreamException : IOException // TypeDefIndex: 1576
{
	// Methods

	// RVA: 0x14B8890 Offset: 0x14B6E90 VA: 0x1814B8890
	public void .ctor() { }

	// RVA: 0x14B88E0 Offset: 0x14B6EE0 VA: 0x1814B88E0
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
internal static class Error // TypeDefIndex: 1577
{
	// Methods

	// RVA: 0x14B8D70 Offset: 0x14B7370 VA: 0x1814B8D70
	internal static Exception GetStreamIsClosed() { }

	// RVA: 0x14B8CB0 Offset: 0x14B72B0 VA: 0x1814B8CB0
	internal static Exception GetEndOfFile() { }

	// RVA: 0x14B8D10 Offset: 0x14B7310 VA: 0x1814B8D10
	internal static Exception GetReadNotSupported() { }

	// RVA: 0x14B8DD0 Offset: 0x14B73D0 VA: 0x1814B8DD0
	internal static Exception GetWriteNotSupported() { }
}

// Namespace: System.IO
[Flags]
public enum FileAccess // TypeDefIndex: 1578
{
	// Fields
	public int value__; // 0x0
	public const FileAccess Read = 1;
	public const FileAccess Write = 2;
	public const FileAccess ReadWrite = 3;
}

// Namespace: System.IO
[Serializable]
public class FileLoadException : IOException // TypeDefIndex: 1579
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public string FileName { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x14B95D0 Offset: 0x14B7BD0 VA: 0x1814B95D0
	public void .ctor() { }

	// RVA: 0x14B95B0 Offset: 0x14B7BB0 VA: 0x1814B95B0
	public void .ctor(string message) { }

	// RVA: 0x14B9620 Offset: 0x14B7C20 VA: 0x1814B9620 Slot: 5
	public override string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_FusionLog() { }

	// RVA: 0x14B92F0 Offset: 0x14B78F0 VA: 0x1814B92F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14B94E0 Offset: 0x14B7AE0 VA: 0x1814B94E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14B91E0 Offset: 0x14B77E0 VA: 0x1814B91E0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14B9180 Offset: 0x14B7780 VA: 0x1814B9180
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }
}

// Namespace: System.IO
public enum FileMode // TypeDefIndex: 1580
{
	// Fields
	public int value__; // 0x0
	public const FileMode CreateNew = 1;
	public const FileMode Create = 2;
	public const FileMode Open = 3;
	public const FileMode OpenOrCreate = 4;
	public const FileMode Truncate = 5;
	public const FileMode Append = 6;
}

// Namespace: System.IO
[Serializable]
public class FileNotFoundException : IOException // TypeDefIndex: 1581
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public string FileName { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x14B9A80 Offset: 0x14B8080 VA: 0x1814B9A80
	public void .ctor() { }

	// RVA: 0x14B9BA0 Offset: 0x14B81A0 VA: 0x1814B9BA0
	public void .ctor(string message) { }

	// RVA: 0x14B9BC0 Offset: 0x14B81C0 VA: 0x1814B9BC0
	public void .ctor(string message, string fileName) { }

	// RVA: 0x14B9C00 Offset: 0x14B8200 VA: 0x1814B9C00 Slot: 5
	public override string get_Message() { }

	// RVA: 0x14B97C0 Offset: 0x14B7DC0 VA: 0x1814B97C0
	private void SetMessageField() { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_FusionLog() { }

	// RVA: 0x14B9890 Offset: 0x14B7E90 VA: 0x1814B9890 Slot: 3
	public override string ToString() { }

	// RVA: 0x14B9AD0 Offset: 0x14B80D0 VA: 0x1814B9AD0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14B96B0 Offset: 0x14B7CB0 VA: 0x1814B96B0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
[Flags]
public enum FileOptions // TypeDefIndex: 1582
{
	// Fields
	public int value__; // 0x0
	public const FileOptions None = 0;
	public const FileOptions WriteThrough = -2147483648;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions Encrypted = 16384;
}

// Namespace: System.IO
[Flags]
public enum FileShare // TypeDefIndex: 1583
{
	// Fields
	public int value__; // 0x0
	public const FileShare None = 0;
	public const FileShare Read = 1;
	public const FileShare Write = 2;
	public const FileShare ReadWrite = 3;
	public const FileShare Delete = 4;
	public const FileShare Inheritable = 16;
}

// Namespace: System.IO
[Serializable]
public class IOException : SystemException // TypeDefIndex: 1584
{
	// Methods

	// RVA: 0x14BD5C0 Offset: 0x14BBBC0 VA: 0x1814BD5C0
	public void .ctor() { }

	// RVA: 0x14BD5A0 Offset: 0x14BBBA0 VA: 0x1814BD5A0
	public void .ctor(string message) { }

	// RVA: 0x14161E0 Offset: 0x14147E0 VA: 0x1814161E0
	public void .ctor(string message, int hresult) { }

	// RVA: 0x14BD610 Offset: 0x14BBC10 VA: 0x1814BD610
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
[Serializable]
public class MemoryStream : Stream // TypeDefIndex: 1585
{
	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x14BF9A0 Offset: 0x14BDFA0 VA: 0x1814BF9A0
	public void .ctor() { }

	// RVA: 0x14BFA40 Offset: 0x14BE040 VA: 0x1814BFA40
	public void .ctor(int capacity) { }

	// RVA: 0x14BF8C0 Offset: 0x14BDEC0 VA: 0x1814BF8C0
	public void .ctor(byte[] buffer) { }

	// RVA: 0x14BF7D0 Offset: 0x14BDDD0 VA: 0x1814BF7D0
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x14BF570 Offset: 0x14BDB70 VA: 0x1814BF570
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x14BF5A0 Offset: 0x14BDBA0 VA: 0x1814BF5A0
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0x14BFB60 Offset: 0x14BE160 VA: 0x1814BFB60 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x14BFB60 Offset: 0x14BE160 VA: 0x1814BFB60 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x14BD7F0 Offset: 0x14BBDF0 VA: 0x1814BD7F0
	private void EnsureNotClosed() { }

	// RVA: 0x14BD830 Offset: 0x14BBE30 VA: 0x1814BD830
	private void EnsureWriteable() { }

	// RVA: 0x14BD6C0 Offset: 0x14BBCC0 VA: 0x1814BD6C0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x14BD730 Offset: 0x14BBD30 VA: 0x1814BD730
	private bool EnsureCapacity(int value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void Flush() { }

	// RVA: 0x14BD880 Offset: 0x14BBE80 VA: 0x1814BD880 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14BD9B0 Offset: 0x14BBFB0 VA: 0x1814BD9B0 Slot: 37
	public virtual byte[] GetBuffer() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	internal int InternalGetPosition() { }

	// RVA: 0x14BDA80 Offset: 0x14BC080 VA: 0x1814BDA80
	internal int InternalReadInt32() { }

	// RVA: 0x14BDA20 Offset: 0x14BC020 VA: 0x1814BDA20
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x14BFB80 Offset: 0x14BE180 VA: 0x1814BFB80 Slot: 38
	public virtual int get_Capacity() { }

	// RVA: 0x14BFC60 Offset: 0x14BE260 VA: 0x1814BFC60 Slot: 39
	public virtual void set_Capacity(int value) { }

	// RVA: 0x14BFBC0 Offset: 0x14BE1C0 VA: 0x1814BFBC0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x14BFC10 Offset: 0x14BE210 VA: 0x1814BFC10 Slot: 12
	public override long get_Position() { }

	// RVA: 0x14BFE10 Offset: 0x14BE410 VA: 0x1814BFE10 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x14BE250 Offset: 0x14BC850 VA: 0x1814BE250 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x14BE4C0 Offset: 0x14BCAC0 VA: 0x1814BE4C0 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x14BDE90 Offset: 0x14BC490 VA: 0x1814BDE90 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14BDB60 Offset: 0x14BC160 VA: 0x1814BDB60 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x14BE1D0 Offset: 0x14BC7D0 VA: 0x1814BE1D0 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x14BE690 Offset: 0x14BCC90 VA: 0x1814BE690 Slot: 30
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x14BE8F0 Offset: 0x14BCEF0 VA: 0x1814BE8F0 Slot: 40
	public virtual byte[] ToArray() { }

	// RVA: 0x14BF270 Offset: 0x14BD870 VA: 0x1814BF270 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x14BF010 Offset: 0x14BD610 VA: 0x1814BF010 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x14BEC20 Offset: 0x14BD220 VA: 0x1814BEC20 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14BE990 Offset: 0x14BCF90 VA: 0x1814BE990 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x14BEEF0 Offset: 0x14BD4F0 VA: 0x1814BEEF0 Slot: 36
	public override void WriteByte(byte value) { }
}

// Namespace: System.IO
internal static class PathInternal // TypeDefIndex: 1586
{
	// Fields
	private static readonly bool s_isCaseSensitive; // 0x0

	// Properties
	internal static bool IsCaseSensitive { get; }

	// Methods

	// RVA: 0x14C0DF0 Offset: 0x14BF3F0 VA: 0x1814C0DF0
	internal static bool IsValidDriveChar(char value) { }

	// RVA: 0x14C0240 Offset: 0x14BE840 VA: 0x1814C0240
	internal static bool EndsWithPeriodOrSpace(string path) { }

	// RVA: 0x14C02A0 Offset: 0x14BE8A0 VA: 0x1814C02A0
	internal static string EnsureExtendedPrefixIfNeeded(string path) { }

	// RVA: 0x14C0350 Offset: 0x14BE950 VA: 0x1814C0350
	internal static string EnsureExtendedPrefix(string path) { }

	// RVA: 0x14C0B30 Offset: 0x14BF130 VA: 0x1814C0B30
	internal static bool IsDevice(ReadOnlySpan<char> path) { }

	// RVA: 0x14C0A40 Offset: 0x14BF040 VA: 0x1814C0A40
	internal static bool IsDeviceUNC(ReadOnlySpan<char> path) { }

	// RVA: 0x14C0D00 Offset: 0x14BF300 VA: 0x1814C0D00
	internal static bool IsExtended(ReadOnlySpan<char> path) { }

	// RVA: 0x14C0660 Offset: 0x14BEC60 VA: 0x1814C0660
	internal static int GetRootLength(ReadOnlySpan<char> path) { }

	// RVA: 0x14C0CE0 Offset: 0x14BF2E0 VA: 0x1814C0CE0
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x14C01B0 Offset: 0x14BE7B0 VA: 0x1814C01B0
	internal static bool EndsInDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x14C0E10 Offset: 0x14BF410 VA: 0x1814C0E10
	internal static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x14C0E90 Offset: 0x14BF490 VA: 0x1814C0E90
	internal static string TrimEndingDirectorySeparator(string path) { }

	// RVA: 0x14C1090 Offset: 0x14BF690 VA: 0x1814C1090
	internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x14C0D80 Offset: 0x14BF380 VA: 0x1814C0D80
	internal static bool IsRoot(ReadOnlySpan<char> path) { }

	// RVA: 0x14C1290 Offset: 0x14BF890 VA: 0x1814C1290
	internal static bool get_IsCaseSensitive() { }

	// RVA: 0x14C04A0 Offset: 0x14BEAA0 VA: 0x1814C04A0
	private static bool GetIsCaseSensitive() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool IsPartiallyQualified(string path) { }

	// RVA: 0x14C1250 Offset: 0x14BF850 VA: 0x1814C1250
	private static void .cctor() { }
}

// Namespace: System.IO
[Serializable]
public class PathTooLongException : IOException // TypeDefIndex: 1587
{
	// Methods

	// RVA: 0x14C12E0 Offset: 0x14BF8E0 VA: 0x1814C12E0
	public void .ctor() { }

	// RVA: 0x14C1330 Offset: 0x14BF930 VA: 0x1814C1330
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream // TypeDefIndex: 1588
{
	// Fields
	private byte[] _array; // 0x68
	private GCHandle _pinningHandle; // 0x70

	// Methods

	// RVA: 0x14C1440 Offset: 0x14BFA40 VA: 0x1814C1440
	internal void .ctor(byte[] array) { }

	// RVA: 0x14C1400 Offset: 0x14BFA00 VA: 0x1814C1400 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x14C1420 Offset: 0x14BFA20 VA: 0x1814C1420 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x14C1390 Offset: 0x14BF990 VA: 0x1814C1390 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x14C1350 Offset: 0x14BF950 VA: 0x1814C1350 Slot: 19
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.IO
public enum SeekOrigin // TypeDefIndex: 1589
{
	// Fields
	public int value__; // 0x0
	public const SeekOrigin Begin = 0;
	public const SeekOrigin Current = 1;
	public const SeekOrigin End = 2;
}

// Namespace: System.IO
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 1593
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream _stream; // 0x18
	private Encoding _encoding; // 0x20
	private Decoder _decoder; // 0x28
	private byte[] _byteBuffer; // 0x30
	private char[] _charBuffer; // 0x38
	private int _charPos; // 0x40
	private int _charLen; // 0x44
	private int _byteLen; // 0x48
	private int _bytePos; // 0x4C
	private int _maxCharsPerBuffer; // 0x50
	private bool _detectEncoding; // 0x54
	private bool _checkPreamble; // 0x55
	private bool _isBlocked; // 0x56
	private bool _closable; // 0x57
	private Task _asyncReadTask; // 0x58

	// Properties
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x14C1560 Offset: 0x14BFB60 VA: 0x1814C1560
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x14C3880 Offset: 0x14C1E80 VA: 0x1814C3880
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x14C3B40 Offset: 0x14C2140 VA: 0x1814C3B40
	internal void .ctor() { }

	// RVA: 0x14C4160 Offset: 0x14C2760 VA: 0x1814C4160
	public void .ctor(Stream stream) { }

	// RVA: 0x14C3C00 Offset: 0x14C2200 VA: 0x1814C3C00
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x14C3B10 Offset: 0x14C2110 VA: 0x1814C3B10
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x14C41D0 Offset: 0x14C27D0 VA: 0x1814C41D0
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x14C3C60 Offset: 0x14C2260 VA: 0x1814C3C60
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x14C3A60 Offset: 0x14C2060 VA: 0x1814C3A60
	public void .ctor(string path) { }

	// RVA: 0x14C3AB0 Offset: 0x14C20B0 VA: 0x1814C3AB0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x14C41B0 Offset: 0x14C27B0 VA: 0x1814C41B0
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x14C3EA0 Offset: 0x14C24A0 VA: 0x1814C3EA0
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x14C19B0 Offset: 0x14BFFB0 VA: 0x1814C19B0
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x14C1990 Offset: 0x14BFF90 VA: 0x1814C1990
	internal void Init(Stream stream) { }

	// RVA: 0x13D6060 Offset: 0x13D4660 VA: 0x1813D6060 Slot: 7
	public override void Close() { }

	// RVA: 0x14C1900 Offset: 0x14BFF00 VA: 0x1814C1900 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 17
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 18
	public virtual Stream get_BaseStream() { }

	// RVA: 0x14C4200 Offset: 0x14C2800 VA: 0x1814C4200
	internal bool get_LeaveOpen() { }

	// RVA: 0x14C1C50 Offset: 0x14C0250 VA: 0x1814C1C50 Slot: 9
	public override int Peek() { }

	// RVA: 0x14C35A0 Offset: 0x14C1BA0 VA: 0x1814C35A0 Slot: 10
	public override int Read() { }

	// RVA: 0x14C36B0 Offset: 0x14C1CB0 VA: 0x1814C36B0 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x14C34F0 Offset: 0x14C1AF0 VA: 0x1814C34F0 Slot: 12
	public override int Read(Span<char> buffer) { }

	// RVA: 0x14C30E0 Offset: 0x14C16E0 VA: 0x1814C30E0
	private int ReadSpan(Span<char> buffer) { }

	// RVA: 0x14C3370 Offset: 0x14C1970 VA: 0x1814C3370 Slot: 13
	public override string ReadToEnd() { }

	// RVA: 0x14C15C0 Offset: 0x14BFBC0 VA: 0x1814C15C0
	private void CompressBuffer(int n) { }

	// RVA: 0x14C1610 Offset: 0x14BFC10 VA: 0x1814C1610
	private void DetectEncoding() { }

	// RVA: 0x14C1B20 Offset: 0x14C0120 VA: 0x1814C1B20
	private bool IsPreamble() { }

	// RVA: 0x14C2330 Offset: 0x14C0930 VA: 0x1814C2330 Slot: 19
	internal virtual int ReadBuffer() { }

	// RVA: 0x14C27C0 Offset: 0x14C0DC0 VA: 0x1814C27C0
	private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer) { }

	// RVA: 0x14C2E50 Offset: 0x14C1450 VA: 0x1814C2E50 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x14C1F00 Offset: 0x14C0500 VA: 0x1814C1F00 Slot: 15
	public override Task<int> ReadAsync(char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(StreamReader.<ReadAsyncInternal>d__66))]
	// RVA: 0x14C1D60 Offset: 0x14C0360 VA: 0x1814C1D60 Slot: 16
	internal override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(StreamReader.<ReadBufferAsync>d__69))]
	// RVA: 0x14C2220 Offset: 0x14C0820 VA: 0x1814C2220
	private Task<int> ReadBufferAsync() { }

	// RVA: 0x14C1600 Offset: 0x14BFC00 VA: 0x1814C1600
	internal bool DataAvailable() { }

	// RVA: 0x14C38D0 Offset: 0x14C1ED0 VA: 0x1814C38D0
	private static void .cctor() { }
}

// Namespace: System.IO
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 1598
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream _stream; // 0x30
	private Encoding _encoding; // 0x38
	private Encoder _encoder; // 0x40
	private byte[] _byteBuffer; // 0x48
	private char[] _charBuffer; // 0x50
	private int _charPos; // 0x58
	private int _charLen; // 0x5C
	private bool _autoFlush; // 0x60
	private bool _haveWrittenPreamble; // 0x61
	private bool _closable; // 0x62
	private Task _asyncWriteTask; // 0x68

	// Properties
	private static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }
	private int CharPos_Prop { set; }
	private bool HaveWrittenPreamble_Prop { set; }

	// Methods

	// RVA: 0x14C4210 Offset: 0x14C2810 VA: 0x1814C4210
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x14C4D10 Offset: 0x14C3310 VA: 0x1814C4D10
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x14C6D20 Offset: 0x14C5320 VA: 0x1814C6D20
	private static Encoding get_UTF8NoBOM() { }

	// RVA: 0x14C6C50 Offset: 0x14C5250 VA: 0x1814C6C50
	internal void .ctor() { }

	// RVA: 0x14C6A30 Offset: 0x14C5030 VA: 0x1814C6A30
	public void .ctor(Stream stream) { }

	// RVA: 0x14C66C0 Offset: 0x14C4CC0 VA: 0x1814C66C0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x14C6480 Offset: 0x14C4A80 VA: 0x1814C6480
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x14C6BA0 Offset: 0x14C51A0 VA: 0x1814C6BA0
	public void .ctor(string path) { }

	// RVA: 0x14C6AE0 Offset: 0x14C50E0 VA: 0x1814C6AE0
	public void .ctor(string path, bool append) { }

	// RVA: 0x14C66F0 Offset: 0x14C4CF0 VA: 0x1814C66F0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x14C4BA0 Offset: 0x14C31A0 VA: 0x1814C4BA0
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x14C4270 Offset: 0x14C2870 VA: 0x1814C4270 Slot: 8
	public override void Close() { }

	// RVA: 0x14C42D0 Offset: 0x14C28D0 VA: 0x1814C42D0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x14C4970 Offset: 0x14C2F70 VA: 0x1814C4970 Slot: 10
	public override void Flush() { }

	// RVA: 0x14C49E0 Offset: 0x14C2FE0 VA: 0x1814C49E0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x14C6D60 Offset: 0x14C5360 VA: 0x1814C6D60 Slot: 29
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 30
	public virtual Stream get_BaseStream() { }

	// RVA: 0x14C6D10 Offset: 0x14C5310 VA: 0x1814C6D10
	internal bool get_LeaveOpen() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x14C5FE0 Offset: 0x14C45E0 VA: 0x1814C5FE0 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x14C60A0 Offset: 0x14C46A0 VA: 0x1814C60A0 Slot: 14
	public override void Write(char[] buffer) { }

	// RVA: 0x14C6110 Offset: 0x14C4710 VA: 0x1814C6110 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x14C5C90 Offset: 0x14C4290 VA: 0x1814C5C90
	private void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine) { }

	// RVA: 0x14C5F60 Offset: 0x14C4560 VA: 0x1814C5F60 Slot: 17
	public override void Write(string value) { }

	// RVA: 0x14C5BC0 Offset: 0x14C41C0 VA: 0x1814C5BC0 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0x14C5180 Offset: 0x14C3780 VA: 0x1814C5180 Slot: 25
	public override Task WriteAsync(char value) { }

	[AsyncStateMachine(typeof(StreamWriter.<WriteAsyncInternal>d__57))]
	// RVA: 0x14C5030 Offset: 0x14C3630 VA: 0x1814C5030
	private static Task WriteAsyncInternal(StreamWriter _this, char value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine) { }

	// RVA: 0x14C5440 Offset: 0x14C3A40 VA: 0x1814C5440 Slot: 26
	public override Task WriteAsync(string value) { }

	[AsyncStateMachine(typeof(StreamWriter.<WriteAsyncInternal>d__59))]
	// RVA: 0x14C4D60 Offset: 0x14C3360 VA: 0x1814C4D60
	private static Task WriteAsyncInternal(StreamWriter _this, string value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine) { }

	// RVA: 0x14C5740 Offset: 0x14C3D40 VA: 0x1814C5740 Slot: 27
	public override Task WriteAsync(char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(StreamWriter.<WriteAsyncInternal>d__62))]
	// RVA: 0x14C4EC0 Offset: 0x14C34C0 VA: 0x1814C4EC0
	private static Task WriteAsyncInternal(StreamWriter _this, ReadOnlyMemory<char> source, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine, CancellationToken cancellationToken) { }

	// RVA: 0x14C47F0 Offset: 0x14C2DF0 VA: 0x1814C47F0 Slot: 28
	public override Task FlushAsync() { }

	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	private void set_CharPos_Prop(int value) { }

	// RVA: 0x14C6DE0 Offset: 0x14C53E0 VA: 0x1814C6DE0
	private void set_HaveWrittenPreamble_Prop(bool value) { }

	// RVA: 0x14C4540 Offset: 0x14C2B40 VA: 0x1814C4540
	private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, char[] sCharBuffer, int sCharPos, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(StreamWriter.<FlushAsyncInternal>d__74))]
	// RVA: 0x14C43A0 Offset: 0x14C29A0 VA: 0x1814C43A0
	private static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, byte[] byteBuffer, Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x14C6370 Offset: 0x14C4970 VA: 0x1814C6370
	private static void .cctor() { }
}

// Namespace: System.IO
[Serializable]
public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 1602
{
	// Fields
	public static readonly TextReader Null; // 0x0

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x14CA1E0 Offset: 0x14C87E0 VA: 0x1814CA1E0 Slot: 7
	public virtual void Close() { }

	// RVA: 0x14CA240 Offset: 0x14C8840 VA: 0x1814CA240 Slot: 6
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690 Slot: 9
	public virtual int Peek() { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690 Slot: 10
	public virtual int Read() { }

	// RVA: 0x14CABE0 Offset: 0x14C91E0 VA: 0x1814CABE0 Slot: 11
	public virtual int Read(char[] buffer, int index, int count) { }

	// RVA: 0x14CA940 Offset: 0x14C8F40 VA: 0x1814CA940 Slot: 12
	public virtual int Read(Span<char> buffer) { }

	// RVA: 0x14CA840 Offset: 0x14C8E40 VA: 0x1814CA840 Slot: 13
	public virtual string ReadToEnd() { }

	// RVA: 0x14CA720 Offset: 0x14C8D20 VA: 0x1814CA720 Slot: 14
	public virtual string ReadLine() { }

	// RVA: 0x14CA500 Offset: 0x14C8B00 VA: 0x1814CA500 Slot: 15
	public virtual Task<int> ReadAsync(char[] buffer, int index, int count) { }

	// RVA: 0x14CA2A0 Offset: 0x14C88A0 VA: 0x1814CA2A0 Slot: 16
	internal virtual ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x14CADF0 Offset: 0x14C93F0 VA: 0x1814CADF0
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x14CAEF0 Offset: 0x14C94F0 VA: 0x1814CAEF0
	private static void .cctor() { }
}

// Namespace: System.IO
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 1606
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static readonly char[] s_coreNewLine; // 0x8
	protected char[] CoreNewLine; // 0x18
	private string CoreNewLineStr; // 0x20
	private IFormatProvider _internalFormatProvider; // 0x28

	// Properties
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }
	public virtual string NewLine { get; }

	// Methods

	// RVA: 0x14CC260 Offset: 0x14CA860 VA: 0x1814CC260
	protected void .ctor() { }

	// RVA: 0x14CC300 Offset: 0x14CA900 VA: 0x1814CC300
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x14CC3A0 Offset: 0x14CA9A0 VA: 0x1814CC3A0 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x14CAFA0 Offset: 0x14C95A0 VA: 0x1814CAFA0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14CB000 Offset: 0x14C9600 VA: 0x1814CB000 Slot: 6
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 12
	public virtual string get_NewLine() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	public virtual void Write(char value) { }

	// RVA: 0x14CBEC0 Offset: 0x14CA4C0 VA: 0x1814CBEC0 Slot: 14
	public virtual void Write(char[] buffer) { }

	// RVA: 0x14CBEF0 Offset: 0x14CA4F0 VA: 0x1814CBEF0 Slot: 15
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x14CBE70 Offset: 0x14CA470 VA: 0x1814CBE70 Slot: 16
	public virtual void Write(long value) { }

	// RVA: 0x14CC0F0 Offset: 0x14CA6F0 VA: 0x1814CC0F0 Slot: 17
	public virtual void Write(string value) { }

	// RVA: 0x14CBC20 Offset: 0x14CA220 VA: 0x1814CBC20 Slot: 18
	public virtual void WriteLine() { }

	// RVA: 0x14CBB50 Offset: 0x14CA150 VA: 0x1814CBB50 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x14CBCB0 Offset: 0x14CA2B0 VA: 0x1814CBCB0 Slot: 20
	public virtual void WriteLine(object value) { }

	// RVA: 0x14CBC40 Offset: 0x14CA240 VA: 0x1814CBC40 Slot: 21
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x14CBDF0 Offset: 0x14CA3F0 VA: 0x1814CBDF0 Slot: 22
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x14CBB90 Offset: 0x14CA190 VA: 0x1814CBB90 Slot: 23
	public virtual void WriteLine(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x14CBAE0 Offset: 0x14CA0E0 VA: 0x1814CBAE0 Slot: 24
	public virtual void WriteLine(string format, object[] arg) { }

	// RVA: 0x14CB3A0 Offset: 0x14C99A0 VA: 0x1814CB3A0 Slot: 25
	public virtual Task WriteAsync(char value) { }

	// RVA: 0x14CB880 Offset: 0x14C9E80 VA: 0x1814CB880 Slot: 26
	public virtual Task WriteAsync(string value) { }

	// RVA: 0x14CB600 Offset: 0x14C9C00 VA: 0x1814CB600 Slot: 27
	public virtual Task WriteAsync(char[] buffer, int index, int count) { }

	// RVA: 0x14CB060 Offset: 0x14C9660 VA: 0x1814CB060 Slot: 28
	public virtual Task FlushAsync() { }

	// RVA: 0x14CB280 Offset: 0x14C9880 VA: 0x1814CB280
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x14CC130 Offset: 0x14CA730 VA: 0x1814CC130
	private static void .cctor() { }
}

// Namespace: System.IO
public class UnmanagedMemoryStream : Stream // TypeDefIndex: 1607
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliant(False)]
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x14D2400 Offset: 0x14D0A00 VA: 0x1814D2400
	protected void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x14D2370 Offset: 0x14D0970 VA: 0x1814D2370
	public void .ctor(byte* pointer, long length) { }

	[CLSCompliant(False)]
	// RVA: 0x14D22E0 Offset: 0x14D08E0 VA: 0x1814D22E0
	public void .ctor(byte* pointer, long length, long capacity, FileAccess access) { }

	[CLSCompliant(False)]
	// RVA: 0x14D02B0 Offset: 0x14CE8B0 VA: 0x1814D02B0
	protected void Initialize(byte* pointer, long length, long capacity, FileAccess access) { }

	// RVA: 0x14D2460 Offset: 0x14D0A60 VA: 0x1814D2460 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x14D2470 Offset: 0x14D0A70 VA: 0x1814D2470 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x14D2480 Offset: 0x14D0A80 VA: 0x1814D2480 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x14D0090 Offset: 0x14CE690 VA: 0x1814D0090 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x14D00A0 Offset: 0x14CE6A0 VA: 0x1814D00A0
	private void EnsureNotClosed() { }

	// RVA: 0x14D00E0 Offset: 0x14CE6E0 VA: 0x1814D00E0
	private void EnsureReadable() { }

	// RVA: 0x14D0130 Offset: 0x14CE730 VA: 0x1814D0130
	private void EnsureWriteable() { }

	// RVA: 0x14D00A0 Offset: 0x14CE6A0 VA: 0x1814D00A0 Slot: 20
	public override void Flush() { }

	// RVA: 0x14D0180 Offset: 0x14CE780 VA: 0x1814D0180 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14D24A0 Offset: 0x14D0AA0 VA: 0x1814D24A0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x14D25E0 Offset: 0x14D0BE0 VA: 0x1814D25E0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x14D2640 Offset: 0x14D0C40 VA: 0x1814D2640 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x14D24F0 Offset: 0x14D0AF0 VA: 0x1814D24F0
	public byte* get_PositionPointer() { }

	// RVA: 0x14D1070 Offset: 0x14CF670 VA: 0x1814D1070 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x14D0FC0 Offset: 0x14CF5C0 VA: 0x1814D0FC0 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x14D0D00 Offset: 0x14CF300 VA: 0x1814D0D00
	internal int ReadCore(Span<byte> buffer) { }

	// RVA: 0x14D0840 Offset: 0x14CEE40 VA: 0x1814D0840 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14D0540 Offset: 0x14CEB40 VA: 0x1814D0540 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x14D0B50 Offset: 0x14CF150 VA: 0x1814D0B50 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x14D1290 Offset: 0x14CF890 VA: 0x1814D1290 Slot: 30
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x14D1FE0 Offset: 0x14D05E0 VA: 0x1814D1FE0 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x14D2230 Offset: 0x14D0830 VA: 0x1814D2230 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x14D1C20 Offset: 0x14D0220 VA: 0x1814D1C20
	internal void WriteCore(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x14D1470 Offset: 0x14CFA70 VA: 0x1814D1470 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14D1700 Offset: 0x14CFD00 VA: 0x1814D1700 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x14D1960 Offset: 0x14CFF60 VA: 0x1814D1960 Slot: 36
	public override void WriteByte(byte value) { }
}

// Namespace: System.IO
internal static class Win32Marshal // TypeDefIndex: 1608
{
	// Methods

	// RVA: 0x14D2720 Offset: 0x14D0D20 VA: 0x1814D2720
	internal static Exception GetExceptionForLastWin32Error(string path = "") { }

	// RVA: 0x14D2780 Offset: 0x14D0D80 VA: 0x1814D2780
	internal static Exception GetExceptionForWin32Error(int errorCode, string path = "") { }

	// RVA: 0x14D2C80 Offset: 0x14D1280 VA: 0x1814D2C80
	internal static int MakeHRFromErrorCode(int errorCode) { }

	// RVA: 0x14D2C70 Offset: 0x14D1270 VA: 0x1814D2C70
	internal static string GetMessage(int errorCode) { }
}

// Namespace: System.IO
[Serializable]
public class DriveNotFoundException : IOException // TypeDefIndex: 1609
{
	// Methods

	// RVA: 0x14B8840 Offset: 0x14B6E40 VA: 0x1814B8840
	public void .ctor() { }

	// RVA: 0x14B7EA0 Offset: 0x14B64A0 VA: 0x1814B7EA0
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
public static class Directory // TypeDefIndex: 1610
{
	// Methods

	// RVA: 0x14B7EC0 Offset: 0x14B64C0 VA: 0x1814B7EC0
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x14B81F0 Offset: 0x14B67F0 VA: 0x1814B81F0
	public static bool Exists(string path) { }

	// RVA: 0x14B82B0 Offset: 0x14B68B0 VA: 0x1814B82B0
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x14B8390 Offset: 0x14B6990 VA: 0x1814B8390
	public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x14B84A0 Offset: 0x14B6AA0 VA: 0x1814B84A0
	internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	// RVA: 0x14B8040 Offset: 0x14B6640 VA: 0x1814B8040
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x14B8020 Offset: 0x14B6620 VA: 0x1814B8020
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x14B86E0 Offset: 0x14B6CE0 VA: 0x1814B86E0
	internal static string InternalGetDirectoryRoot(string path) { }

	// RVA: 0x14B82A0 Offset: 0x14B68A0 VA: 0x1814B82A0
	public static string GetCurrentDirectory() { }

	// RVA: 0x14B8400 Offset: 0x14B6A00 VA: 0x1814B8400
	internal static string InsecureGetCurrentDirectory() { }
}

// Namespace: System.IO
[Serializable]
public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 1611
{
	// Methods

	// RVA: 0x14B79D0 Offset: 0x14B5FD0 VA: 0x1814B79D0
	internal void .ctor(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x14B7560 Offset: 0x14B5B60 VA: 0x1814B7560
	private void Init(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x14B7E30 Offset: 0x14B6430 VA: 0x1814B7E30
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
public class EnumerationOptions // TypeDefIndex: 1612
{
	// Fields
	[CompilerGenerated]
	private static readonly EnumerationOptions <Compatible>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly EnumerationOptions <Default>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <RecurseSubdirectories>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IgnoreInaccessible>k__BackingField; // 0x11
	[CompilerGenerated]
	private int <BufferSize>k__BackingField; // 0x14
	[CompilerGenerated]
	private FileAttributes <AttributesToSkip>k__BackingField; // 0x18
	[CompilerGenerated]
	private MatchType <MatchType>k__BackingField; // 0x1C
	[CompilerGenerated]
	private MatchCasing <MatchCasing>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ReturnSpecialDirectories>k__BackingField; // 0x24

	// Properties
	internal static EnumerationOptions Compatible { get; }
	private static EnumerationOptions CompatibleRecursive { get; }
	internal static EnumerationOptions Default { get; }
	public bool RecurseSubdirectories { get; set; }
	public bool IgnoreInaccessible { get; set; }
	public int BufferSize { get; }
	public FileAttributes AttributesToSkip { get; set; }
	public MatchType MatchType { get; set; }
	public MatchCasing MatchCasing { get; }
	public bool ReturnSpecialDirectories { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x14B8C00 Offset: 0x14B7200 VA: 0x1814B8C00
	internal static EnumerationOptions get_Compatible() { }

	[CompilerGenerated]
	// RVA: 0x14B8BB0 Offset: 0x14B71B0 VA: 0x1814B8BB0
	private static EnumerationOptions get_CompatibleRecursive() { }

	[CompilerGenerated]
	// RVA: 0x14B8C50 Offset: 0x14B7250 VA: 0x1814B8C50
	internal static EnumerationOptions get_Default() { }

	// RVA: 0x14B8B80 Offset: 0x14B7180 VA: 0x1814B8B80
	public void .ctor() { }

	// RVA: 0x14B8900 Offset: 0x14B6F00 VA: 0x1814B8900
	internal static EnumerationOptions FromSearchOption(SearchOption searchOption) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_RecurseSubdirectories() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_RecurseSubdirectories(bool value) { }

	[CompilerGenerated]
	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_IgnoreInaccessible() { }

	[CompilerGenerated]
	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_IgnoreInaccessible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_BufferSize() { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public FileAttributes get_AttributesToSkip() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_AttributesToSkip(FileAttributes value) { }

	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public MatchType get_MatchType() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_MatchType(MatchType value) { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public MatchCasing get_MatchCasing() { }

	[CompilerGenerated]
	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_ReturnSpecialDirectories() { }

	// RVA: 0x14B8A50 Offset: 0x14B7050 VA: 0x1814B8A50
	private static void .cctor() { }
}

// Namespace: System.IO
public static class File // TypeDefIndex: 1613
{
	// Methods

	// RVA: 0x14BC500 Offset: 0x14BAB00 VA: 0x1814BC500
	public static StreamReader OpenText(string path) { }

	// RVA: 0x14BBA10 Offset: 0x14BA010 VA: 0x1814BBA10
	public static StreamWriter CreateText(string path) { }

	// RVA: 0x14BB960 Offset: 0x14B9F60 VA: 0x1814BB960
	public static StreamWriter AppendText(string path) { }

	// RVA: 0x14BBB40 Offset: 0x14BA140 VA: 0x1814BBB40
	public static FileStream Create(string path) { }

	// RVA: 0x14BBAC0 Offset: 0x14BA0C0 VA: 0x1814BBAC0
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x14BBBB0 Offset: 0x14BA1B0 VA: 0x1814BBBB0
	public static void Delete(string path) { }

	// RVA: 0x14BBD80 Offset: 0x14BA380 VA: 0x1814BBD80
	public static bool Exists(string path) { }

	// RVA: 0x14BC5C0 Offset: 0x14BABC0 VA: 0x1814BC5C0
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x14BC650 Offset: 0x14BAC50 VA: 0x1814BC650
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x14BBEA0 Offset: 0x14BA4A0 VA: 0x1814BBEA0
	public static FileAttributes GetAttributes(string path) { }

	// RVA: 0x14BC490 Offset: 0x14BAA90 VA: 0x1814BC490
	public static FileStream OpenRead(string path) { }

	// RVA: 0x14BCE10 Offset: 0x14BB410 VA: 0x1814BCE10
	public static string ReadAllText(string path) { }

	// RVA: 0x14BBF50 Offset: 0x14BA550 VA: 0x1814BBF50
	private static string InternalReadAllText(string path, Encoding encoding) { }

	// RVA: 0x14BD220 Offset: 0x14BB820 VA: 0x1814BD220
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x14BCBC0 Offset: 0x14BB1C0 VA: 0x1814BCBC0
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x14BC6E0 Offset: 0x14BACE0 VA: 0x1814BC6E0
	private static byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	// RVA: 0x14BD0F0 Offset: 0x14BB6F0 VA: 0x1814BD0F0
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x14BC070 Offset: 0x14BA670 VA: 0x1814BC070
	private static void InternalWriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x14BB7B0 Offset: 0x14B9DB0 VA: 0x1814BB7B0
	public static void AppendAllText(string path, string contents) { }

	// RVA: 0x14BCEF0 Offset: 0x14BB4F0 VA: 0x1814BCEF0
	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) { }

	// RVA: 0x14BCF10 Offset: 0x14BB510 VA: 0x1814BCF10
	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) { }

	// RVA: 0x14BC190 Offset: 0x14BA790 VA: 0x1814BC190
	public static void Move(string sourceFileName, string destFileName) { }
}

// Namespace: System.IO
[Serializable]
public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 1614
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x14B9170 Offset: 0x14B7770 VA: 0x1814B9170
	private void .ctor() { }

	// RVA: 0x14B8F10 Offset: 0x14B7510 VA: 0x1814B8F10
	public void .ctor(string fileName) { }

	// RVA: 0x14B9020 Offset: 0x14B7620 VA: 0x1814B9020
	internal void .ctor(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x14B8EA0 Offset: 0x14B74A0 VA: 0x1814B8EA0
	public StreamWriter CreateText() { }

	// RVA: 0x14B8E30 Offset: 0x14B7430 VA: 0x1814B8E30
	public StreamWriter AppendText() { }

	// RVA: 0x14B7E30 Offset: 0x14B6430 VA: 0x1814B7E30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 8
	public override string get_Name() { }
}

// Namespace: System.IO
[Serializable]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 1615
{
	// Fields
	private Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data; // 0x18
	private int _dataInitialized; // 0x3C
	protected string FullPath; // 0x40
	protected string OriginalPath; // 0x48
	internal string _name; // 0x50

	// Properties
	internal bool ExistsCore { get; }
	internal string NormalizedPath { get; }
	public virtual string Name { get; }
	public virtual bool Exists { get; }

	// Methods

	// RVA: 0x14B9170 Offset: 0x14B7770 VA: 0x1814B9170
	protected void .ctor() { }

	// RVA: 0x14B9FC0 Offset: 0x14B85C0 VA: 0x1814B9FC0
	internal bool get_ExistsCore() { }

	// RVA: 0x14B9E20 Offset: 0x14B8420 VA: 0x1814B9E20
	public void Refresh() { }

	// RVA: 0x14BA0D0 Offset: 0x14B86D0 VA: 0x1814BA0D0
	internal string get_NormalizedPath() { }

	// RVA: 0x14B9E70 Offset: 0x14B8470 VA: 0x1814B9E70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x14B9CE0 Offset: 0x14B82E0 VA: 0x1814B9CE0 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x14BA040 Offset: 0x14B8640 VA: 0x1814BA040 Slot: 9
	public virtual bool get_Exists() { }

	// RVA: 0x14B9E50 Offset: 0x14B8450 VA: 0x1814B9E50 Slot: 3
	public override string ToString() { }
}

// Namespace: System.IO
public enum MatchCasing // TypeDefIndex: 1616
{
	// Fields
	public int value__; // 0x0
	public const MatchCasing PlatformDefault = 0;
	public const MatchCasing CaseSensitive = 1;
	public const MatchCasing CaseInsensitive = 2;
}

// Namespace: System.IO
public enum MatchType // TypeDefIndex: 1617
{
	// Fields
	public int value__; // 0x0
	public const MatchType Simple = 0;
	public const MatchType Win32 = 1;
}

// Namespace: System.IO
public enum SearchOption // TypeDefIndex: 1618
{
	// Fields
	public int value__; // 0x0
	public const SearchOption TopDirectoryOnly = 0;
	public const SearchOption AllDirectories = 1;
}

// Namespace: System.IO
internal enum SearchTarget // TypeDefIndex: 1619
{
	// Fields
	public int value__; // 0x0
	public const SearchTarget Files = 1;
	public const SearchTarget Directories = 2;
	public const SearchTarget Both = 3;
}

// Namespace: System.IO
[Flags]
public enum FileAttributes // TypeDefIndex: 1620
{
	// Fields
	public int value__; // 0x0
	public const FileAttributes ReadOnly = 1;
	public const FileAttributes Hidden = 2;
	public const FileAttributes System = 4;
	public const FileAttributes Directory = 16;
	public const FileAttributes Archive = 32;
	public const FileAttributes Device = 64;
	public const FileAttributes Normal = 128;
	public const FileAttributes Temporary = 256;
	public const FileAttributes SparseFile = 512;
	public const FileAttributes ReparsePoint = 1024;
	public const FileAttributes Compressed = 2048;
	public const FileAttributes Offline = 4096;
	public const FileAttributes NotContentIndexed = 8192;
	public const FileAttributes Encrypted = 16384;
	public const FileAttributes IntegrityStream = 32768;
	public const FileAttributes NoScrubData = 131072;
}

// Namespace: System.IO
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 1629
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public virtual bool CanTimeout { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	public virtual int ReadTimeout { get; set; }
	public virtual int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x14C7E40 Offset: 0x14C6440 VA: 0x1814C7E40
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	public virtual bool get_CanTimeout() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_Position(long value);

	// RVA: 0x14C9700 Offset: 0x14C7D00 VA: 0x1814C9700 Slot: 14
	public virtual int get_ReadTimeout() { }

	// RVA: 0x14C97A0 Offset: 0x14C7DA0 VA: 0x1814C97A0 Slot: 15
	public virtual void set_ReadTimeout(int value) { }

	// RVA: 0x14C9750 Offset: 0x14C7D50 VA: 0x1814C9750 Slot: 16
	public virtual int get_WriteTimeout() { }

	// RVA: 0x14C97F0 Offset: 0x14C7DF0 VA: 0x1814C97F0 Slot: 17
	public virtual void set_WriteTimeout(int value) { }

	// RVA: 0x14C7950 Offset: 0x14C5F50 VA: 0x1814C7950 Slot: 18
	public virtual void Close() { }

	// RVA: 0xD13740 Offset: 0xD11D40 VA: 0x180D13740 Slot: 6
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Flush();

	// RVA: 0x14C8090 Offset: 0x14C6690 VA: 0x1814C8090 Slot: 21
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14C7490 Offset: 0x14C5A90 VA: 0x1814C7490 Slot: 22
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x14C7250 Offset: 0x14C5850 VA: 0x1814C7250
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x14C79B0 Offset: 0x14C5FB0 VA: 0x1814C79B0 Slot: 23
	public virtual int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x14C8730 Offset: 0x14C6D30 VA: 0x1814C8730
	public Task<int> ReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x14C82A0 Offset: 0x14C68A0 VA: 0x1814C82A0 Slot: 24
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14C8380 Offset: 0x14C6980 VA: 0x1814C8380 Slot: 25
	public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x14C6DF0 Offset: 0x14C53F0 VA: 0x1814C6DF0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x14C7710 Offset: 0x14C5D10 VA: 0x1814C7710 Slot: 26
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x14C74D0 Offset: 0x14C5AD0 VA: 0x1814C74D0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x14C8B10 Offset: 0x14C7110 VA: 0x1814C8B10
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x14C8CE0 Offset: 0x14C72E0 VA: 0x1814C8CE0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x14C7F50 Offset: 0x14C6550 VA: 0x1814C7F50
	private void FinishTrackingAsyncOperation() { }

	// RVA: 0x14C7C00 Offset: 0x14C6200 VA: 0x1814C7C00 Slot: 27
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x14C92B0 Offset: 0x14C78B0 VA: 0x1814C92B0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x14C9350 Offset: 0x14C7950 VA: 0x1814C9350 Slot: 28
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14C8F40 Offset: 0x14C7540 VA: 0x1814C8F40 Slot: 29
	public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(Stream.<FinishWriteAsync>d__57))]
	// RVA: 0x14C7F90 Offset: 0x14C6590 VA: 0x1814C7F90
	private Task FinishWriteAsync(Task writeTask, byte[] localBuffer) { }

	// RVA: 0x14C7020 Offset: 0x14C5620 VA: 0x1814C7020
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int Read(byte[] buffer, int offset, int count);

	// RVA: 0x14C8870 Offset: 0x14C6E70 VA: 0x1814C8870 Slot: 32
	public virtual int Read(Span<byte> buffer) { }

	// RVA: 0x14C87D0 Offset: 0x14C6DD0 VA: 0x1814C87D0 Slot: 33
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x14C94B0 Offset: 0x14C7AB0 VA: 0x1814C94B0 Slot: 35
	public virtual void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x14C9420 Offset: 0x14C7A20 VA: 0x1814C9420 Slot: 36
	public virtual void WriteByte(byte value) { }

	// RVA: 0x14C7750 Offset: 0x14C5D50 VA: 0x1814C7750
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x14C7930 Offset: 0x14C5F30 VA: 0x1814C7930
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x14C7840 Offset: 0x14C5E40 VA: 0x1814C7840
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x14C7940 Offset: 0x14C5F40 VA: 0x1814C7940
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private bool HasOverriddenBeginEndRead() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private bool HasOverriddenBeginEndWrite() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x14C9680 Offset: 0x14C7C80 VA: 0x1814C9680
	private static void .cctor() { }

	[AsyncStateMachine(typeof(Stream.<<ReadAsync>g__FinishReadAsync|44_0>d))]
	[CompilerGenerated]
	// RVA: 0x14C8DB0 Offset: 0x14C73B0 VA: 0x1814C8DB0
	internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination) { }
}

// Namespace: System.IO
internal static class __Error // TypeDefIndex: 1630
{
	// Methods

	// RVA: 0x14E6370 Offset: 0x14E4970 VA: 0x1814E6370
	internal static void EndOfFile() { }

	// RVA: 0x14E63D0 Offset: 0x14E49D0 VA: 0x1814E63D0
	internal static void FileNotOpen() { }

	// RVA: 0x14E65A0 Offset: 0x14E4BA0 VA: 0x1814E65A0
	internal static void ReaderClosed() { }

	// RVA: 0x14E6440 Offset: 0x14E4A40 VA: 0x1814E6440
	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	// RVA: 0x14E6610 Offset: 0x14E4C10 VA: 0x1814E6610
	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	// RVA: 0x14E6E30 Offset: 0x14E5430 VA: 0x1814E6E30
	internal static void WriterClosed() { }
}

// Namespace: System.IO
[ComVisible(True)]
public class BinaryReader : IDisposable // TypeDefIndex: 1631
{
	// Fields
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x14D4810 Offset: 0x14D2E10 VA: 0x1814D4810
	public void .ctor(Stream input) { }

	// RVA: 0x14D4890 Offset: 0x14D2E90 VA: 0x1814D4890
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x14D4550 Offset: 0x14D2B50 VA: 0x1814D4550
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x14D2DF0 Offset: 0x14D13F0 VA: 0x1814D2DF0 Slot: 6
	public virtual void Close() { }

	// RVA: 0x14D2E10 Offset: 0x14D1410 VA: 0x1814D2E10 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14D2DF0 Offset: 0x14D13F0 VA: 0x1814D2DF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D4340 Offset: 0x14D2940 VA: 0x1814D4340 Slot: 8
	public virtual int Read() { }

	// RVA: 0x14D3710 Offset: 0x14D1D10 VA: 0x1814D3710 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x14D3760 Offset: 0x14D1D60 VA: 0x1814D3760 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliant(False)]
	// RVA: 0x14D3EE0 Offset: 0x14D24E0 VA: 0x1814D3EE0 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x14D3950 Offset: 0x14D1F50 VA: 0x1814D3950 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x14D3C80 Offset: 0x14D2280 VA: 0x1814D3C80 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliant(False)]
	// RVA: 0x14D3C80 Offset: 0x14D2280 VA: 0x1814D3C80 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x14D3CE0 Offset: 0x14D22E0 VA: 0x1814D3CE0 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliant(False)]
	// RVA: 0x14D42C0 Offset: 0x14D28C0 VA: 0x1814D42C0 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x14D3DF0 Offset: 0x14D23F0 VA: 0x1814D3DF0 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliant(False)]
	// RVA: 0x14D3DF0 Offset: 0x14D23F0 VA: 0x1814D3DF0 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x14D3F30 Offset: 0x14D2530 VA: 0x1814D3F30 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x14D3C40 Offset: 0x14D2240 VA: 0x1814D3C40 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x14D3B00 Offset: 0x14D2100 VA: 0x1814D3B00 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x14D3F70 Offset: 0x14D2570 VA: 0x1814D3F70 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x14D3040 Offset: 0x14D1640 VA: 0x1814D3040
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x14D33D0 Offset: 0x14D19D0 VA: 0x1814D33D0
	private int InternalReadOneChar() { }

	// RVA: 0x14D3980 Offset: 0x14D1F80 VA: 0x1814D3980 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x14D4360 Offset: 0x14D2960 VA: 0x1814D4360 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x14D37A0 Offset: 0x14D1DA0 VA: 0x1814D37A0 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x14D2ED0 Offset: 0x14D14D0 VA: 0x1814D2ED0 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x14D3660 Offset: 0x14D1C60 VA: 0x1814D3660
	protected internal int Read7BitEncodedInt() { }
}

// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class BinaryWriter : IDisposable // TypeDefIndex: 1632
{
	// Fields
	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalField]
	private bool _leaveOpen; // 0x30
	private byte[] _largeByteBuffer; // 0x38
	private int _maxChars; // 0x40

	// Methods

	// RVA: 0x14D5760 Offset: 0x14D3D60 VA: 0x1814D5760
	protected void .ctor() { }

	// RVA: 0x14D5A60 Offset: 0x14D4060 VA: 0x1814D5A60
	public void .ctor(Stream output) { }

	// RVA: 0x14D5740 Offset: 0x14D3D40 VA: 0x1814D5740
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x14D5870 Offset: 0x14D3E70 VA: 0x1814D5870
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x1421A30 Offset: 0x1420030 VA: 0x181421A30 Slot: 5
	public virtual void Close() { }

	// RVA: 0x14D48B0 Offset: 0x14D2EB0 VA: 0x1814D48B0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1421A30 Offset: 0x1420030 VA: 0x181421A30 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D4910 Offset: 0x14D2F10 VA: 0x1814D4910 Slot: 7
	public virtual void Flush() { }

	// RVA: 0x14D50B0 Offset: 0x14D36B0 VA: 0x1814D50B0 Slot: 8
	public virtual void Write(bool value) { }

	// RVA: 0x14D4EE0 Offset: 0x14D34E0 VA: 0x1814D4EE0 Slot: 9
	public virtual void Write(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x14D4EE0 Offset: 0x14D34E0 VA: 0x1814D4EE0 Slot: 10
	public virtual void Write(sbyte value) { }

	// RVA: 0x14D4F10 Offset: 0x14D3510 VA: 0x1814D4F10 Slot: 11
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x14D5500 Offset: 0x14D3B00 VA: 0x1814D5500 Slot: 12
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x14D53C0 Offset: 0x14D39C0 VA: 0x1814D53C0 Slot: 13
	public virtual void Write(char ch) { }

	// RVA: 0x14D4FA0 Offset: 0x14D35A0 VA: 0x1814D4FA0 Slot: 14
	public virtual void Write(char[] chars) { }

	// RVA: 0x14D52C0 Offset: 0x14D38C0 VA: 0x1814D52C0 Slot: 15
	public virtual void Write(double value) { }

	// RVA: 0x14D4D30 Offset: 0x14D3330 VA: 0x1814D4D30 Slot: 16
	public virtual void Write(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x14D5250 Offset: 0x14D3850 VA: 0x1814D5250 Slot: 17
	public virtual void Write(ushort value) { }

	// RVA: 0x14D5310 Offset: 0x14D3910 VA: 0x1814D5310 Slot: 18
	public virtual void Write(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x14D5530 Offset: 0x14D3B30 VA: 0x1814D5530 Slot: 19
	public virtual void Write(uint value) { }

	// RVA: 0x14D5110 Offset: 0x14D3710 VA: 0x1814D5110 Slot: 20
	public virtual void Write(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x14D4DA0 Offset: 0x14D33A0 VA: 0x1814D4DA0 Slot: 21
	public virtual void Write(ulong value) { }

	// RVA: 0x14D5060 Offset: 0x14D3660 VA: 0x1814D5060 Slot: 22
	public virtual void Write(float value) { }

	// RVA: 0x14D49B0 Offset: 0x14D2FB0 VA: 0x1814D49B0 Slot: 23
	public virtual void Write(string value) { }

	// RVA: 0x14D4940 Offset: 0x14D2F40 VA: 0x1814D4940
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x14D55E0 Offset: 0x14D3BE0 VA: 0x1814D55E0
	private static void .cctor() { }
}

// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class StringReader : TextReader // TypeDefIndex: 1633
{
	// Fields
	private string _s; // 0x18
	private int _pos; // 0x20
	private int _length; // 0x24

	// Methods

	// RVA: 0x14E3780 Offset: 0x14E1D80 VA: 0x1814E3780
	public void .ctor(string s) { }

	// RVA: 0x13D6060 Offset: 0x13D4660 VA: 0x1813D6060 Slot: 7
	public override void Close() { }

	// RVA: 0x14E3130 Offset: 0x14E1730 VA: 0x1814E3130 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x14E3180 Offset: 0x14E1780 VA: 0x1814E3180 Slot: 9
	public override int Peek() { }

	// RVA: 0x14E3730 Offset: 0x14E1D30 VA: 0x1814E3730 Slot: 10
	public override int Read() { }

	// RVA: 0x14E3520 Offset: 0x14E1B20 VA: 0x1814E3520 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x14E34C0 Offset: 0x14E1AC0 VA: 0x1814E34C0 Slot: 13
	public override string ReadToEnd() { }

	// RVA: 0x14E33C0 Offset: 0x14E19C0 VA: 0x1814E33C0 Slot: 14
	public override string ReadLine() { }

	[ComVisible(False)]
	// RVA: 0x14E31C0 Offset: 0x14E17C0 VA: 0x1814E31C0 Slot: 15
	public override Task<int> ReadAsync(char[] buffer, int index, int count) { }
}

// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class StringWriter : TextWriter // TypeDefIndex: 1634
{
	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x30
	private bool _isOpen; // 0x38

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x14E3DF0 Offset: 0x14E23F0 VA: 0x1814E3DF0
	public void .ctor() { }

	// RVA: 0x14E4020 Offset: 0x14E2620 VA: 0x1814E4020
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x14E4140 Offset: 0x14E2740 VA: 0x1814E4140
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x14E3F30 Offset: 0x14E2530 VA: 0x1814E3F30
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x14E3840 Offset: 0x14E1E40 VA: 0x1814E3840 Slot: 8
	public override void Close() { }

	// RVA: 0x14E3860 Offset: 0x14E1E60 VA: 0x1814E3860 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x14E4260 Offset: 0x14E2860 VA: 0x1814E4260 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x14E3DC0 Offset: 0x14E23C0 VA: 0x1814E3DC0 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x14E3B90 Offset: 0x14E2190 VA: 0x1814E3B90 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x14E3D80 Offset: 0x14E2380 VA: 0x1814E3D80 Slot: 17
	public override void Write(string value) { }

	[ComVisible(False)]
	// RVA: 0x14E3A10 Offset: 0x14E2010 VA: 0x1814E3A10 Slot: 25
	public override Task WriteAsync(char value) { }

	[ComVisible(False)]
	// RVA: 0x14E3AD0 Offset: 0x14E20D0 VA: 0x1814E3AD0 Slot: 26
	public override Task WriteAsync(string value) { }

	[ComVisible(False)]
	// RVA: 0x14E3930 Offset: 0x14E1F30 VA: 0x1814E3930 Slot: 27
	public override Task WriteAsync(char[] buffer, int index, int count) { }

	[ComVisible(False)]
	// RVA: 0x14E3870 Offset: 0x14E1E70 VA: 0x1814E3870 Slot: 28
	public override Task FlushAsync() { }

	// RVA: 0x14E3900 Offset: 0x14E1F00 VA: 0x1814E3900 Slot: 3
	public override string ToString() { }
}

// Namespace: System.IO
[ComVisible(True)]
public class FileStream : Stream // TypeDefIndex: 1637
{
	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public virtual string Name { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead")]
	// RVA: 0x14DA260 Offset: 0x14D8860 VA: 0x1814DA260
	public void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize) { }

	// RVA: 0x14D9490 Offset: 0x14D7A90 VA: 0x1814D9490
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x14D9640 Offset: 0x14D7C40 VA: 0x1814D9640
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x14DA1A0 Offset: 0x14D87A0 VA: 0x1814DA1A0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x14D9450 Offset: 0x14D7A50 VA: 0x1814D9450
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x14DA1D0 Offset: 0x14D87D0 VA: 0x1814DA1D0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x14DA220 Offset: 0x14D8820 VA: 0x1814DA220
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x14DA0E0 Offset: 0x14D86E0 VA: 0x1814DA0E0
	public void .ctor(SafeFileHandle handle, FileAccess access) { }

	// RVA: 0x14D9FC0 Offset: 0x14D85C0 VA: 0x1814D9FC0
	public void .ctor(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) { }

	// RVA: 0x14DA090 Offset: 0x14D8690 VA: 0x1814DA090
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x14D9680 Offset: 0x14D7C80 VA: 0x1814D9680
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x14D7E20 Offset: 0x14D6420 VA: 0x1814D7E20
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x14DA400 Offset: 0x14D8A00 VA: 0x1814DA400 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x14DA430 Offset: 0x14D8A30 VA: 0x1814DA430 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x14DA420 Offset: 0x14D8A20 VA: 0x1814DA420 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 37
	public virtual string get_Name() { }

	// RVA: 0x14DA450 Offset: 0x14D8A50 VA: 0x1814DA450 Slot: 11
	public override long get_Length() { }

	// RVA: 0x14DA600 Offset: 0x14D8C00 VA: 0x1814DA600 Slot: 12
	public override long get_Position() { }

	// RVA: 0x14DA800 Offset: 0x14D8E00 VA: 0x1814DA800 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x14DA7C0 Offset: 0x14D8DC0 VA: 0x1814DA7C0 Slot: 38
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x14D75C0 Offset: 0x14D5BC0 VA: 0x1814D75C0
	private void ExposeHandle() { }

	// RVA: 0x14D81A0 Offset: 0x14D67A0 VA: 0x1814D81A0 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x14D8CE0 Offset: 0x14D72E0 VA: 0x1814D8CE0 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x14D85D0 Offset: 0x14D6BD0 VA: 0x1814D85D0 Slot: 31
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x14D8450 Offset: 0x14D6A50 VA: 0x1814D8450
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x14D65E0 Offset: 0x14D4BE0 VA: 0x1814D65E0 Slot: 22
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x14D71E0 Offset: 0x14D57E0 VA: 0x1814D71E0 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x14D9100 Offset: 0x14D7700 VA: 0x1814D9100 Slot: 34
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x14D8E50 Offset: 0x14D7450 VA: 0x1814D8E50
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x14D69D0 Offset: 0x14D4FD0 VA: 0x1814D69D0 Slot: 26
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x14D73E0 Offset: 0x14D59E0 VA: 0x1814D73E0 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x14D89C0 Offset: 0x14D6FC0 VA: 0x1814D89C0 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x14D7960 Offset: 0x14D5F60 VA: 0x1814D7960 Slot: 20
	public override void Flush() { }

	// RVA: 0x14D7880 Offset: 0x14D5E80 VA: 0x1814D7880 Slot: 39
	public virtual void Flush(bool flushToDisk) { }

	// RVA: 0x14C1390 Offset: 0x14BF990 VA: 0x1814C1390 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x14D6EC0 Offset: 0x14D54C0 VA: 0x1814D6EC0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x14D75F0 Offset: 0x14D5BF0 VA: 0x1814D75F0 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14D8190 Offset: 0x14D6790 VA: 0x1814D8190 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14D8CD0 Offset: 0x14D72D0 VA: 0x1814D8CD0 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x14D8520 Offset: 0x14D6B20 VA: 0x1814D8520
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x14D9090 Offset: 0x14D7690 VA: 0x1814D9090
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x14D7690 Offset: 0x14D5C90 VA: 0x1814D7690
	private void FlushBuffer() { }

	// RVA: 0x14D7680 Offset: 0x14D5C80 VA: 0x1814D7680
	private void FlushBufferIfDirty() { }

	// RVA: 0x14D8980 Offset: 0x14D6F80 VA: 0x1814D8980
	private void RefillBuffer() { }

	// RVA: 0x14D8310 Offset: 0x14D6910 VA: 0x1814D8310
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x14D7B80 Offset: 0x14D6180 VA: 0x1814D7B80
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x14D7AC0 Offset: 0x14D60C0 VA: 0x1814D7AC0
	private string GetSecureFileName(string filename) { }

	// RVA: 0x14D79E0 Offset: 0x14D5FE0 VA: 0x1814D79E0
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x14D93D0 Offset: 0x14D79D0 VA: 0x1814D93D0
	private static void .cctor() { }
}

// Namespace: System.IO
internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 1638
{
	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x14D64F0 Offset: 0x14D4AF0 VA: 0x1814D64F0
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x14D6460 Offset: 0x14D4A60 VA: 0x1814D6460
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10 Slot: 4
	public bool get_IsCompleted() { }
}

// Namespace: System.IO
internal enum MonoFileType // TypeDefIndex: 1639
{
	// Fields
	public int value__; // 0x0
	public const MonoFileType Unknown = 0;
	public const MonoFileType Disk = 1;
	public const MonoFileType Char = 2;
	public const MonoFileType Pipe = 3;
	public const MonoFileType Remote = 32768;
}

// Namespace: System.IO
internal static class MonoIO // TypeDefIndex: 1640
{
	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x14DD2B0 Offset: 0x14DB8B0 VA: 0x1814DD2B0
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x14DCBC0 Offset: 0x14DB1C0 VA: 0x1814DCBC0
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x14DCBB0 Offset: 0x14DB1B0 VA: 0x1814DCBB0
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x14DD4C0 Offset: 0x14DBAC0 VA: 0x1814DD4C0
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x14DD3B0 Offset: 0x14DB9B0 VA: 0x1814DD3B0
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x14DCA70 Offset: 0x14DB070 VA: 0x1814DCA70
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x14DD5F0 Offset: 0x14DBBF0 VA: 0x1814DD5F0
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x14DD600 Offset: 0x14DBC00 VA: 0x1814DD600
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x14DC910 Offset: 0x14DAF10 VA: 0x1814DC910
	private static bool Cancel_internal(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x14DC920 Offset: 0x14DAF20 VA: 0x1814DC920
	internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x14DCA40 Offset: 0x14DB040 VA: 0x1814DCA40
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x14DD7D0 Offset: 0x14DBDD0 VA: 0x1814DD7D0
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x14DD690 Offset: 0x14DBC90 VA: 0x1814DD690
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x14DDA80 Offset: 0x14DC080 VA: 0x1814DDA80
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x14DD940 Offset: 0x14DBF40 VA: 0x1814DD940
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x14DD930 Offset: 0x14DBF30 VA: 0x1814DD930
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x14DD7F0 Offset: 0x14DBDF0 VA: 0x1814DD7F0
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x14DCA80 Offset: 0x14DB080 VA: 0x1814DCA80
	private static bool Flush(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x14DCA90 Offset: 0x14DB090 VA: 0x1814DCA90
	public static bool Flush(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x14DD4D0 Offset: 0x14DBAD0 VA: 0x1814DD4D0
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x14DD4E0 Offset: 0x14DBAE0 VA: 0x1814DD4E0
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x14DDB40 Offset: 0x14DC140 VA: 0x1814DDB40
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x14DDB30 Offset: 0x14DC130 VA: 0x1814DDB30
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x14DDB20 Offset: 0x14DC120 VA: 0x1814DDB20
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x14DCA50 Offset: 0x14DB050 VA: 0x1814DCA50
	public static bool CreatePipe(out IntPtr read_handle, out IntPtr write_handle, out MonoIOError error) { }

	// RVA: 0x14DCA60 Offset: 0x14DB060 VA: 0x1814DCA60
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	// RVA: 0x14DDB70 Offset: 0x14DC170 VA: 0x1814DDB70
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x14DDB50 Offset: 0x14DC150 VA: 0x1814DDB50
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x14DDB10 Offset: 0x14DC110 VA: 0x1814DDB10
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x14DDB60 Offset: 0x14DC160 VA: 0x1814DDB60
	public static char get_PathSeparator() { }

	// RVA: 0x1447A70 Offset: 0x1446070 VA: 0x181447A70
	private static void DumpHandles() { }

	// RVA: 0x14DD7E0 Offset: 0x14DBDE0 VA: 0x1814DD7E0
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x14DDA90 Offset: 0x14DC090 VA: 0x1814DDA90
	private static void .cctor() { }
}

// Namespace: System.IO
internal enum MonoIOError // TypeDefIndex: 1641
{
	// Fields
	public int value__; // 0x0
	public const MonoIOError ERROR_SUCCESS = 0;
	public const MonoIOError ERROR_FILE_NOT_FOUND = 2;
	public const MonoIOError ERROR_PATH_NOT_FOUND = 3;
	public const MonoIOError ERROR_TOO_MANY_OPEN_FILES = 4;
	public const MonoIOError ERROR_ACCESS_DENIED = 5;
	public const MonoIOError ERROR_INVALID_HANDLE = 6;
	public const MonoIOError ERROR_INVALID_DRIVE = 15;
	public const MonoIOError ERROR_NOT_SAME_DEVICE = 17;
	public const MonoIOError ERROR_NO_MORE_FILES = 18;
	public const MonoIOError ERROR_NOT_READY = 21;
	public const MonoIOError ERROR_WRITE_FAULT = 29;
	public const MonoIOError ERROR_READ_FAULT = 30;
	public const MonoIOError ERROR_GEN_FAILURE = 31;
	public const MonoIOError ERROR_SHARING_VIOLATION = 32;
	public const MonoIOError ERROR_LOCK_VIOLATION = 33;
	public const MonoIOError ERROR_HANDLE_DISK_FULL = 39;
	public const MonoIOError ERROR_NOT_SUPPORTED = 50;
	public const MonoIOError ERROR_FILE_EXISTS = 80;
	public const MonoIOError ERROR_CANNOT_MAKE = 82;
	public const MonoIOError ERROR_INVALID_PARAMETER = 87;
	public const MonoIOError ERROR_BROKEN_PIPE = 109;
	public const MonoIOError ERROR_INVALID_NAME = 123;
	public const MonoIOError ERROR_DIR_NOT_EMPTY = 145;
	public const MonoIOError ERROR_ALREADY_EXISTS = 183;
	public const MonoIOError ERROR_FILENAME_EXCED_RANGE = 206;
	public const MonoIOError ERROR_DIRECTORY = 267;
	public const MonoIOError ERROR_ENCRYPTION_FAILED = 6000;
}

// Namespace: System.IO
internal struct MonoIOStat // TypeDefIndex: 1642
{
	// Fields
	public FileAttributes fileAttributes; // 0x0
	public long Length; // 0x8
	public long CreationTime; // 0x10
	public long LastAccessTime; // 0x18
	public long LastWriteTime; // 0x20
}

// Namespace: System.IO
[ComVisible(True)]
public static class Path // TypeDefIndex: 1644
{
	// Fields
	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	public static readonly char[] InvalidPathChars; // 0x0
	public static readonly char AltDirectorySeparatorChar; // 0x8
	public static readonly char DirectorySeparatorChar; // 0xA
	public static readonly char PathSeparator; // 0xC
	internal static readonly string DirectorySeparatorStr; // 0x10
	public static readonly char VolumeSeparatorChar; // 0x18
	internal static readonly char[] PathSeparatorChars; // 0x20
	private static readonly bool dirEqualsVolume; // 0x28
	internal static readonly char[] trimEndCharsWindows; // 0x30
	internal static readonly char[] trimEndCharsUnix; // 0x38

	// Methods

	// RVA: 0x14DE950 Offset: 0x14DCF50 VA: 0x1814DE950
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x14DEFC0 Offset: 0x14DD5C0 VA: 0x1814DEFC0
	public static string Combine(string path1, string path2) { }

	// RVA: 0x14DEB70 Offset: 0x14DD170 VA: 0x1814DEB70
	internal static string CleanPath(string s) { }

	// RVA: 0x14DF930 Offset: 0x14DDF30 VA: 0x1814DF930
	public static string GetDirectoryName(string path) { }

	// RVA: 0x14DF850 Offset: 0x14DDE50 VA: 0x1814DF850
	public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path) { }

	// RVA: 0x14DFD60 Offset: 0x14DE360 VA: 0x1814DFD60
	public static string GetExtension(string path) { }

	// RVA: 0x14E0050 Offset: 0x14DE650 VA: 0x1814E0050
	public static string GetFileName(string path) { }

	// RVA: 0x14DFE70 Offset: 0x14DE470 VA: 0x1814DFE70
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x14E0560 Offset: 0x14DEB60 VA: 0x1814E0560
	public static string GetFullPath(string path) { }

	// RVA: 0x14E0160 Offset: 0x14DE760 VA: 0x1814E0160
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x14E0480 Offset: 0x14DEA80 VA: 0x1814E0480
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	// RVA: 0x14E01B0 Offset: 0x14DE7B0 VA: 0x1814E01B0
	internal static string GetFullPathName(string path) { }

	// RVA: 0x14E2650 Offset: 0x14E0C50 VA: 0x1814E2650
	internal static string WindowsDriveAdjustment(string path) { }

	// RVA: 0x14E0E90 Offset: 0x14DF490 VA: 0x1814E0E90
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x14E1590 Offset: 0x14DFB90 VA: 0x1814E1590
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x14E06E0 Offset: 0x14DECE0 VA: 0x1814E06E0
	public static string GetPathRoot(string path) { }

	// RVA: 0x14E0D80 Offset: 0x14DF380 VA: 0x1814E0D80
	public static string GetTempPath() { }

	// RVA: 0x14E2C80 Offset: 0x14E1280 VA: 0x1814E2C80
	private static string get_temp_path() { }

	// RVA: 0x14E1840 Offset: 0x14DFE40 VA: 0x1814E1840
	public static bool IsPathRooted(ReadOnlySpan<char> path) { }

	// RVA: 0x14E1610 Offset: 0x14DFC10 VA: 0x1814E1610
	public static bool IsPathRooted(string path) { }

	// RVA: 0x14E05C0 Offset: 0x14DEBC0 VA: 0x1814E05C0
	public static char[] GetInvalidFileNameChars() { }

	// RVA: 0x14E0660 Offset: 0x14DEC60 VA: 0x1814E0660
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x14E2BE0 Offset: 0x14E11E0 VA: 0x1814E2BE0
	private static int findExtension(string path) { }

	// RVA: 0x14E28C0 Offset: 0x14E0EC0 VA: 0x1814E28C0
	private static void .cctor() { }

	// RVA: 0x14E0B80 Offset: 0x14DF180 VA: 0x1814E0B80
	private static string GetServerAndShare(string path) { }

	// RVA: 0x14E2350 Offset: 0x14E0950 VA: 0x1814E2350
	private static bool SameRoot(string root, string path) { }

	// RVA: 0x14DE220 Offset: 0x14DC820 VA: 0x1814DE220
	private static string CanonicalizePath(string path) { }

	// RVA: 0x14DF4E0 Offset: 0x14DDAE0 VA: 0x1814DF4E0
	public static string Combine(string[] paths) { }

	// RVA: 0x14DF2F0 Offset: 0x14DD8F0 VA: 0x1814DF2F0
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x14DFED0 Offset: 0x14DE4D0 VA: 0x1814DFED0
	public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path) { }

	// RVA: 0x14E2030 Offset: 0x14E0630 VA: 0x1814E2030
	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2) { }

	// RVA: 0x14E20E0 Offset: 0x14E06E0 VA: 0x1814E20E0
	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3) { }

	// RVA: 0x14E1D60 Offset: 0x14E0360 VA: 0x1814E1D60
	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second) { }

	// RVA: 0x14E1960 Offset: 0x14DFF60 VA: 0x1814E1960
	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third) { }
}

// Namespace: System.IO
internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 1645
{
	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x14E6070 Offset: 0x14E4670 VA: 0x1814E6070
	private static void .cctor() { }

	// RVA: 0x14E6120 Offset: 0x14E4720 VA: 0x1814E6120
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x14D5AE0 Offset: 0x14D40E0 VA: 0x1814D5AE0 Slot: 9
	public override int Peek() { }

	// RVA: 0x14E6050 Offset: 0x14E4650 VA: 0x1814E6050 Slot: 10
	public override int Read() { }

	// RVA: 0x14E5DF0 Offset: 0x14E43F0 VA: 0x1814E5DF0 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x14E5BD0 Offset: 0x14E41D0 VA: 0x1814E5BD0
	private bool CheckEOL(char current) { }

	// RVA: 0x14E5DB0 Offset: 0x14E43B0 VA: 0x1814E5DB0 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x14E5DD0 Offset: 0x14E43D0 VA: 0x1814E5DD0 Slot: 13
	public override string ReadToEnd() { }
}

// Namespace: System.IO
internal class UnexceptionalStreamWriter : StreamWriter // TypeDefIndex: 1646
{
	// Methods

	// RVA: 0x14E6230 Offset: 0x14E4830 VA: 0x1814E6230
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x14E6190 Offset: 0x14E4790 VA: 0x1814E6190 Slot: 10
	public override void Flush() { }

	// RVA: 0x14E61F0 Offset: 0x14E47F0 VA: 0x1814E61F0 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x14E61B0 Offset: 0x14E47B0 VA: 0x1814E61B0 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x14E6210 Offset: 0x14E4810 VA: 0x1814E6210 Slot: 14
	public override void Write(char[] value) { }

	// RVA: 0x14E61D0 Offset: 0x14E47D0 VA: 0x1814E61D0 Slot: 17
	public override void Write(string value) { }
}

// Namespace: System.IO
internal class CStreamReader : StreamReader // TypeDefIndex: 1647
{
	// Fields
	private TermInfoDriver driver; // 0x60

	// Methods

	// RVA: 0x14D5D70 Offset: 0x14D4370 VA: 0x1814D5D70
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x14D5AE0 Offset: 0x14D40E0 VA: 0x1814D5AE0 Slot: 9
	public override int Peek() { }

	// RVA: 0x14D5B60 Offset: 0x14D4160 VA: 0x1814D5B60 Slot: 10
	public override int Read() { }

	// RVA: 0x14D5BC0 Offset: 0x14D41C0 VA: 0x1814D5BC0 Slot: 11
	public override int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x14D5B00 Offset: 0x14D4100 VA: 0x1814D5B00 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x14D5B30 Offset: 0x14D4130 VA: 0x1814D5B30 Slot: 13
	public override string ReadToEnd() { }
}

// Namespace: System.IO
internal class CStreamWriter : StreamWriter // TypeDefIndex: 1648
{
	// Fields
	private TermInfoDriver driver; // 0x70

	// Methods

	// RVA: 0x14D6300 Offset: 0x14D4900 VA: 0x1814D6300
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x14D5F50 Offset: 0x14D4550 VA: 0x1814D5F50 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x14D6170 Offset: 0x14D4770 VA: 0x1814D6170 Slot: 13
	public override void Write(char val) { }

	// RVA: 0x14D5EE0 Offset: 0x14D44E0 VA: 0x1814D5EE0
	public void InternalWriteString(string val) { }

	// RVA: 0x14D5EA0 Offset: 0x14D44A0 VA: 0x1814D5EA0
	public void InternalWriteChar(char val) { }

	// RVA: 0x14D5EC0 Offset: 0x14D44C0 VA: 0x1814D5EC0
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x14D62C0 Offset: 0x14D48C0 VA: 0x1814D62C0 Slot: 14
	public override void Write(char[] val) { }

	// RVA: 0x14D6260 Offset: 0x14D4860 VA: 0x1814D6260 Slot: 17
	public override void Write(string val) { }

	// RVA: 0x14D5F00 Offset: 0x14D4500 VA: 0x1814D5F00 Slot: 19
	public override void WriteLine(string val) { }
}

// Namespace: System.IO
[Extension]
internal static class MonoLinqHelper // TypeDefIndex: 1649
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] ToArray<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x736980 Offset: 0x734F80 VA: 0x180736980
	|-MonoLinqHelper.ToArray<object>
	|
	|-RVA: 0x736940 Offset: 0x734F40 VA: 0x180736940
	|-MonoLinqHelper.ToArray<__Il2CppFullySharedGenericType>
	*/
}

