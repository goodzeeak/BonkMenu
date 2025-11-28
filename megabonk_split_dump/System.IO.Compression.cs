// Namespace: System.IO.Compression
public enum CompressionMode // TypeDefIndex: 7712
{
	// Fields
	public int value__; // 0x0
	public const CompressionMode Decompress = 0;
	public const CompressionMode Compress = 1;
}

// Namespace: System.IO.Compression
public class GZipStream : Stream // TypeDefIndex: 7713
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E52170 Offset: 0x1E50770 VA: 0x181E52170
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1E52230 Offset: 0x1E50830 VA: 0x181E52230
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1E52300 Offset: 0x1E50900 VA: 0x181E52300 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1E52340 Offset: 0x1E50940 VA: 0x181E52340 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E52320 Offset: 0x1E50920 VA: 0x181E52320 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E52360 Offset: 0x1E50960 VA: 0x181E52360 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E523B0 Offset: 0x1E509B0 VA: 0x181E523B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E52400 Offset: 0x1E50A00 VA: 0x181E52400 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E51A90 Offset: 0x1E50090 VA: 0x181E51A90 Slot: 20
	public override void Flush() { }

	// RVA: 0x1E51E20 Offset: 0x1E50420 VA: 0x181E51E20 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E51BF0 Offset: 0x1E501F0 VA: 0x181E51BF0 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x1E51800 Offset: 0x1E4FE00 VA: 0x181E51800 Slot: 22
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1E51A20 Offset: 0x1E50020 VA: 0x181E51A20 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1E51C20 Offset: 0x1E50220 VA: 0x181E51C20 Slot: 31
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1E51C60 Offset: 0x1E50260 VA: 0x181E51C60 Slot: 32
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1E518B0 Offset: 0x1E4FEB0 VA: 0x181E518B0 Slot: 26
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x137FA70 Offset: 0x137E070 VA: 0x18137FA70 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1E52000 Offset: 0x1E50600 VA: 0x181E52000 Slot: 34
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1E52040 Offset: 0x1E50640 VA: 0x181E52040 Slot: 35
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1E51980 Offset: 0x1E4FF80 VA: 0x181E51980 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E51AC0 Offset: 0x1E500C0 VA: 0x181E51AC0 Slot: 24
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1E51B00 Offset: 0x1E50100 VA: 0x181E51B00 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1E51ED0 Offset: 0x1E504D0 VA: 0x181E51ED0 Slot: 28
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1E51F10 Offset: 0x1E50510 VA: 0x181E51F10 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1E51A60 Offset: 0x1E50060 VA: 0x181E51A60 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1E51960 Offset: 0x1E4FF60 VA: 0x181E51960
	private void CheckDeflateStream() { }

	// RVA: 0x1E51E70 Offset: 0x1E50470 VA: 0x181E51E70
	private static void ThrowStreamClosedException() { }
}

// Namespace: System.IO.Compression
public class DeflateStream : Stream // TypeDefIndex: 7716
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E514E0 Offset: 0x1E4FAE0 VA: 0x181E514E0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1E516A0 Offset: 0x1E4FCA0 VA: 0x181E516A0
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1E51500 Offset: 0x1E4FB00 VA: 0x181E51500
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x14C1390 Offset: 0x14BF990 VA: 0x1814C1390 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E504D0 Offset: 0x1E4EAD0 VA: 0x181E504D0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E50BA0 Offset: 0x1E4F1A0 VA: 0x181E50BA0
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1E50A50 Offset: 0x1E4F050 VA: 0x181E50A50
	internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x1E50A90 Offset: 0x1E4F090 VA: 0x181E50A90
	internal int ReadCore(Span<byte> destination) { }

	// RVA: 0x1E50CA0 Offset: 0x1E4F2A0 VA: 0x181E50CA0 Slot: 31
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1E510C0 Offset: 0x1E4F6C0 VA: 0x181E510C0
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1E51000 Offset: 0x1E4F600 VA: 0x181E51000
	internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x1E51040 Offset: 0x1E4F640 VA: 0x181E51040
	internal void WriteCore(ReadOnlySpan<byte> source) { }

	// RVA: 0x1E511C0 Offset: 0x1E4F7C0 VA: 0x181E511C0 Slot: 34
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1E50910 Offset: 0x1E4EF10 VA: 0x181E50910 Slot: 20
	public override void Flush() { }

	// RVA: 0x1E4FD90 Offset: 0x1E4E390 VA: 0x181E4FD90 Slot: 22
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1E50130 Offset: 0x1E4E730 VA: 0x181E50130 Slot: 26
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1E50590 Offset: 0x1E4EB90 VA: 0x181E50590 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1E50760 Offset: 0x1E4ED60 VA: 0x181E50760 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1E50FC0 Offset: 0x1E4F5C0 VA: 0x181E50FC0 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E516C0 Offset: 0x1E4FCC0 VA: 0x181E516C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E51700 Offset: 0x1E4FD00 VA: 0x181E51700 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E51740 Offset: 0x1E4FD40 VA: 0x181E51740 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E51780 Offset: 0x1E4FD80 VA: 0x181E51780 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E517C0 Offset: 0x1E4FDC0 VA: 0x181E517C0 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: System.IO.Compression
internal class DeflateStreamNative // TypeDefIndex: 7719
{
	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x30
	private byte[] io_buffer; // 0x38
	private Exception last_error; // 0x40

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x1E4F0E0 Offset: 0x1E4D6E0 VA: 0x181E4F0E0
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x1E4F470 Offset: 0x1E4DA70 VA: 0x181E4F470 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E4F360 Offset: 0x1E4D960 VA: 0x181E4F360
	public void Dispose(bool disposing) { }

	// RVA: 0x1E4F4D0 Offset: 0x1E4DAD0 VA: 0x181E4F4D0
	public void Flush() { }

	// RVA: 0x1E4F5F0 Offset: 0x1E4DBF0 VA: 0x181E4F5F0
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1E4FC50 Offset: 0x1E4E250 VA: 0x181E4FC50
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x1E4F730 Offset: 0x1E4DD30 VA: 0x181E4F730
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1E4F850 Offset: 0x1E4DE50 VA: 0x181E4F850
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x1E4FB30 Offset: 0x1E4E130 VA: 0x181E4FB30
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1E4F9B0 Offset: 0x1E4DFB0 VA: 0x181E4F9B0
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x1E4EEF0 Offset: 0x1E4D4F0 VA: 0x181E4EEF0
	private void CheckResult(int result, string where) { }

	// RVA: 0x1E4F050 Offset: 0x1E4D650 VA: 0x181E4F050
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x1E4F040 Offset: 0x1E4D640 VA: 0x181E4F040
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x1E4F580 Offset: 0x1E4DB80 VA: 0x181E4F580
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x1E4F6B0 Offset: 0x1E4DCB0 VA: 0x181E4F6B0
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x1E4FD10 Offset: 0x1E4E310 VA: 0x181E4FD10
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }
}

