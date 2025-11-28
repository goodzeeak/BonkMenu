// Namespace: System.Net.Sockets
public class NetworkStream : Stream // TypeDefIndex: 7934
{
	// Fields
	private readonly Socket _streamSocket; // 0x28
	private readonly bool _ownsSocket; // 0x30
	private bool _readable; // 0x31
	private bool _writeable; // 0x32
	private int _closeTimeout; // 0x34
	private bool _cleanedUp; // 0x38
	private int _currentReadTimeout; // 0x3C
	private int _currentWriteTimeout; // 0x40

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }
	internal Socket InternalSocket { get; }

	// Methods

	// RVA: 0x1DB0FF0 Offset: 0x1DAF5F0 VA: 0x181DB0FF0
	public void .ctor(Socket socket) { }

	// RVA: 0x1DB1010 Offset: 0x1DAF610 VA: 0x181DB1010
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x1DB1040 Offset: 0x1DAF640 VA: 0x181DB1040
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x16ADFC0 Offset: 0x16AC5C0 VA: 0x1816ADFC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1D9AD50 Offset: 0x1D99350 VA: 0x181D9AD50 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1DB1380 Offset: 0x1DAF980 VA: 0x181DB1380 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1DB14B0 Offset: 0x1DAFAB0 VA: 0x181DB14B0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1DB13F0 Offset: 0x1DAF9F0 VA: 0x181DB13F0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1DB1550 Offset: 0x1DAFB50 VA: 0x181DB1550 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1DB12E0 Offset: 0x1DAF8E0 VA: 0x181DB12E0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1DB1330 Offset: 0x1DAF930 VA: 0x181DB1330 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1DB1460 Offset: 0x1DAFA60 VA: 0x181DB1460 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1DAFFF0 Offset: 0x1DAE5F0 VA: 0x181DAFFF0 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1DAFC00 Offset: 0x1DAE200 VA: 0x181DAFC00 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1DAF8E0 Offset: 0x1DADEE0 VA: 0x181DAF8E0 Slot: 32
	public override int Read(Span<byte> destination) { }

	// RVA: 0x1DAF860 Offset: 0x1DADE60 VA: 0x181DAF860 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x1DB0C00 Offset: 0x1DAF200 VA: 0x181DB0C00 Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1DB0950 Offset: 0x1DAEF50 VA: 0x181DB0950 Slot: 35
	public override void Write(ReadOnlySpan<byte> source) { }

	// RVA: 0x1DB08E0 Offset: 0x1DAEEE0 VA: 0x181DB08E0 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x1DAEAD0 Offset: 0x1DAD0D0 VA: 0x181DAEAD0
	public void Close(int timeout) { }

	// RVA: 0x1DAEB40 Offset: 0x1DAD140 VA: 0x181DAEB40 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x14C1390 Offset: 0x14BF990 VA: 0x1814C1390 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1DAE390 Offset: 0x1DAC990 VA: 0x181DAE390 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1DAEC30 Offset: 0x1DAD230 VA: 0x181DAEC30 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1DAE730 Offset: 0x1DACD30 VA: 0x181DAE730 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1DAEE80 Offset: 0x1DAD480 VA: 0x181DAEE80 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1DAF160 Offset: 0x1DAD760 VA: 0x181DAF160 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DAF5A0 Offset: 0x1DADBA0 VA: 0x181DAF5A0 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1DB01F0 Offset: 0x1DAE7F0 VA: 0x181DB01F0 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DB0630 Offset: 0x1DAEC30 VA: 0x181DB0630 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void Flush() { }

	// RVA: 0x1DAF0D0 Offset: 0x1DAD6D0 VA: 0x181DAF0D0 Slot: 21
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1DB0040 Offset: 0x1DAE640 VA: 0x181DB0040
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x1DB1240 Offset: 0x1DAF840 VA: 0x181DB1240
	internal Socket get_InternalSocket() { }
}

// Namespace: System.Net.Sockets
public class Socket : IDisposable // TypeDefIndex: 7945
{
	// Fields
	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler; // 0x0
	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x8
	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler; // 0x10
	private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel; // 0x18
	private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
	private static readonly Task<int> s_zeroTask; // 0x28
	private Socket.CachedEventArgs _cachedTaskEventArgs; // 0x10
	private static object s_InternalSyncObject; // 0x30
	internal static bool s_SupportsIPv4; // 0x38
	internal static bool s_SupportsIPv6; // 0x39
	internal static bool s_OSSupportsIPv6; // 0x3A
	internal static bool s_Initialized; // 0x3B
	private static bool s_LoggingEnabled; // 0x3C
	private bool is_closed; // 0x18
	private bool is_listening; // 0x19
	private int linger_timeout; // 0x1C
	private AddressFamily addressFamily; // 0x20
	private SocketType socketType; // 0x24
	private ProtocolType protocolType; // 0x28
	internal SafeSocketHandle m_Handle; // 0x30
	internal EndPoint seed_endpoint; // 0x38
	internal SemaphoreSlim ReadSem; // 0x40
	internal SemaphoreSlim WriteSem; // 0x48
	internal bool is_blocking; // 0x50
	internal bool is_bound; // 0x51
	internal bool is_connected; // 0x52
	private int m_IntCleanedUp; // 0x54
	internal bool connect_in_progress; // 0x58
	private static AsyncCallback AcceptAsyncCallback; // 0x40
	private static IOAsyncCallback BeginAcceptCallback; // 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
	private static AsyncCallback ConnectAsyncCallback; // 0x58
	private static IOAsyncCallback BeginConnectCallback; // 0x60
	private static AsyncCallback DisconnectAsyncCallback; // 0x68
	private static IOAsyncCallback BeginDisconnectCallback; // 0x70
	private static AsyncCallback ReceiveAsyncCallback; // 0x78
	private static IOAsyncCallback BeginReceiveCallback; // 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
	private static AsyncCallback SendAsyncCallback; // 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
	private static AsyncCallback SendToAsyncCallback; // 0xB0

	// Properties
	public static bool OSSupportsIPv4 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x1DB84D0 Offset: 0x1DB6AD0 VA: 0x181DB84D0
	internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x1DB8090 Offset: 0x1DB6690 VA: 0x181DB8090
	private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1DBA7F0 Offset: 0x1DB8DF0 VA: 0x181DBA7F0
	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x1DBA380 Offset: 0x1DB8980 VA: 0x181DBA380
	private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1DB5070 Offset: 0x1DB3670 VA: 0x181DB5070
	private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x1DB5260 Offset: 0x1DB3860 VA: 0x181DB5260
	private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1DB6750 Offset: 0x1DB4D50 VA: 0x181DB6750
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = False) { }

	// RVA: 0x1DBA2F0 Offset: 0x1DB88F0 VA: 0x181DBA2F0
	private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1DBA280 Offset: 0x1DB8880 VA: 0x181DBA280
	private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x1DBD430 Offset: 0x1DBBA30 VA: 0x181DBD430
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x1DBDCC0 Offset: 0x1DBC2C0 VA: 0x181DBDCC0
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x1DBDD20 Offset: 0x1DBC320 VA: 0x181DBDD20
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x1CF2C70 Offset: 0x1CF1270 VA: 0x181CF2C70
	public IntPtr get_Handle() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public SocketType get_SocketType() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x1DBDF50 Offset: 0x1DBC550 VA: 0x181DBDF50
	public void set_DontFragment(bool value) { }

	// RVA: 0x1DBD870 Offset: 0x1DBBE70 VA: 0x181DBD870
	public bool get_DualMode() { }

	// RVA: 0x1DBDFE0 Offset: 0x1DBC5E0 VA: 0x181DBDFE0
	public void set_DualMode(bool value) { }

	// RVA: 0x1DBDB60 Offset: 0x1DBC160 VA: 0x181DBDB60
	private bool get_IsDualMode() { }

	// RVA: 0x1DB4F60 Offset: 0x1DB3560 VA: 0x181DB4F60
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x1DBB480 Offset: 0x1DB9A80 VA: 0x181DBB480
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1DBBD30 Offset: 0x1DBA330 VA: 0x181DBBD30
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1DB9620 Offset: 0x1DB7C20 VA: 0x181DB9620
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1DB9FC0 Offset: 0x1DB85C0 VA: 0x181DB9FC0
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1DB6CF0 Offset: 0x1DB52F0 VA: 0x181DB6CF0
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1DBBDB0 Offset: 0x1DBA3B0 VA: 0x181DBBDB0
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x1DB4A10 Offset: 0x1DB3010 VA: 0x181DB4A10
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1DB6630 Offset: 0x1DB4C30 VA: 0x181DB6630
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x1DB3DD0 Offset: 0x1DB23D0 VA: 0x181DB3DD0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1DB6360 Offset: 0x1DB4960 VA: 0x181DB6360
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x1DBDA70 Offset: 0x1DBC070 VA: 0x181DBDA70
	private static object get_InternalSyncObject() { }

	// RVA: 0x1DBD860 Offset: 0x1DBBE60 VA: 0x181DBD860
	internal bool get_CleanedUp() { }

	// RVA: 0x1DB7370 Offset: 0x1DB5970 VA: 0x181DB7370
	internal static void InitializeSockets() { }

	// RVA: 0x1DB5DD0 Offset: 0x1DB43D0 VA: 0x181DB5DD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1DB76B0 Offset: 0x1DB5CB0 VA: 0x181DB76B0
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x1DBC180 Offset: 0x1DBA780 VA: 0x181DBC180
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x1DBD730 Offset: 0x1DBBD30 VA: 0x181DBD730
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x1DBC410 Offset: 0x1DBAA10 VA: 0x181DBC410
	private void SocketDefaults() { }

	// RVA: 0x1DBC610 Offset: 0x1DBAC10 VA: 0x181DBC610
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x1DBDBC0 Offset: 0x1DBC1C0 VA: 0x181DBDBC0
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x1DB7B30 Offset: 0x1DB6130 VA: 0x181DB7B30
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1DB7B20 Offset: 0x1DB6120 VA: 0x181DB7B20
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	public bool get_Blocking() { }

	// RVA: 0x1DBDE80 Offset: 0x1DBC480 VA: 0x181DBDE80
	public void set_Blocking(bool value) { }

	// RVA: 0x1DB4E50 Offset: 0x1DB3450 VA: 0x181DB4E50
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x1DB4E40 Offset: 0x1DB3440 VA: 0x181DB4E40
	internal static void Blocking_icall(IntPtr socket, bool block, out int error) { }

	// RVA: 0x1B028C0 Offset: 0x1B00EC0 VA: 0x181B028C0
	public bool get_Connected() { }

	// RVA: 0x1DBE080 Offset: 0x1DBC680 VA: 0x181DBE080
	public void set_NoDelay(bool value) { }

	// RVA: 0x1DBDD80 Offset: 0x1DBC380 VA: 0x181DBDD80
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x1DBA150 Offset: 0x1DB8750 VA: 0x181DBA150
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1DBA140 Offset: 0x1DB8740 VA: 0x181DBA140
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x1DB7DB0 Offset: 0x1DB63B0 VA: 0x181DB7DB0
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x1DB7C70 Offset: 0x1DB6270 VA: 0x181DB7C70
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1DB7C60 Offset: 0x1DB6260 VA: 0x181DB7C60
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1DB3150 Offset: 0x1DB1750 VA: 0x181DB3150
	public Socket Accept() { }

	// RVA: 0x1DB32A0 Offset: 0x1DB18A0 VA: 0x181DB32A0
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x1DB33E0 Offset: 0x1DB19E0 VA: 0x181DB33E0
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x1DB5E30 Offset: 0x1DB4430 VA: 0x181DB5E30
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x1DB5F20 Offset: 0x1DB4520 VA: 0x181DB5F20
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x1DB3020 Offset: 0x1DB1620 VA: 0x181DB3020
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x1DB3010 Offset: 0x1DB1610 VA: 0x181DB3010
	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x1DB4BD0 Offset: 0x1DB31D0 VA: 0x181DB4BD0
	public void Bind(EndPoint localEP) { }

	// RVA: 0x1DB4AC0 Offset: 0x1DB30C0 VA: 0x181DB4AC0
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x1DB4AB0 Offset: 0x1DB30B0 VA: 0x181DB4AB0
	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x1DB7A10 Offset: 0x1DB6010 VA: 0x181DB7A10
	public void Listen(int backlog) { }

	// RVA: 0x1DB7900 Offset: 0x1DB5F00 VA: 0x181DB7900
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x1DB78F0 Offset: 0x1DB5EF0 VA: 0x181DB78F0
	private static void Listen_icall(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x1DB5950 Offset: 0x1DB3F50 VA: 0x181DB5950
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x1DB5540 Offset: 0x1DB3B40 VA: 0x181DB5540
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x1DB3700 Offset: 0x1DB1D00 VA: 0x181DB3700
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x1DB3580 Offset: 0x1DB1B80 VA: 0x181DB3580
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1DB39E0 Offset: 0x1DB1FE0 VA: 0x181DB39E0
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1DB3E70 Offset: 0x1DB2470 VA: 0x181DB3E70
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1DB6030 Offset: 0x1DB4630 VA: 0x181DB6030
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1DB5440 Offset: 0x1DB3A40 VA: 0x181DB5440
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1DB5430 Offset: 0x1DB3A30 VA: 0x181DB5430
	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1DB5AF0 Offset: 0x1DB40F0 VA: 0x181DB5AF0
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x1DB60E0 Offset: 0x1DB46E0 VA: 0x181DB60E0
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x1DB59E0 Offset: 0x1DB3FE0 VA: 0x181DB59E0
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x1DB59D0 Offset: 0x1DB3FD0 VA: 0x181DB59D0
	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x1DB9E50 Offset: 0x1DB8450 VA: 0x181DB9E50
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1DB96A0 Offset: 0x1DB7CA0 VA: 0x181DB96A0
	private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x1DB98B0 Offset: 0x1DB7EB0 VA: 0x181DB98B0
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1DB9500 Offset: 0x1DB7B00 VA: 0x181DB9500
	public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1DBB4F0 Offset: 0x1DB9AF0 VA: 0x181DBB4F0
	public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1DB8980 Offset: 0x1DB6F80 VA: 0x181DB8980
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1DB3BB0 Offset: 0x1DB21B0 VA: 0x181DB3BB0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1DB6270 Offset: 0x1DB4870 VA: 0x181DB6270
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1DB93D0 Offset: 0x1DB79D0 VA: 0x181DB93D0
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DB9280 Offset: 0x1DB7880 VA: 0x181DB9280
	private static int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DB92A0 Offset: 0x1DB78A0 VA: 0x181DB92A0
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DB9290 Offset: 0x1DB7890 VA: 0x181DB9290
	private static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DB8FC0 Offset: 0x1DB75C0 VA: 0x181DB8FC0
	private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x1DB6190 Offset: 0x1DB4790 VA: 0x181DB6190
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x1DB8E80 Offset: 0x1DB7480 VA: 0x181DB8E80
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1DB8E70 Offset: 0x1DB7470 VA: 0x181DB8E70
	private static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1DBBB80 Offset: 0x1DBA180 VA: 0x181DBBB80
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x1DBB580 Offset: 0x1DB9B80 VA: 0x181DBB580
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1DBAC60 Offset: 0x1DB9260 VA: 0x181DBAC60
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1DB4760 Offset: 0x1DB2D60 VA: 0x181DB4760
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1DB43E0 Offset: 0x1DB29E0 VA: 0x181DB43E0
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1DB6540 Offset: 0x1DB4B40 VA: 0x181DB6540
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1DBB350 Offset: 0x1DB9950 VA: 0x181DBB350
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DBB200 Offset: 0x1DB9800 VA: 0x181DBB200
	private static int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DBB220 Offset: 0x1DB9820 VA: 0x181DBB220
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DBB210 Offset: 0x1DB9810 VA: 0x181DBB210
	private static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1DB6480 Offset: 0x1DB4A80 VA: 0x181DB6480
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x1DB6840 Offset: 0x1DB4E40 VA: 0x181DB6840
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x1DB6A60 Offset: 0x1DB5060 VA: 0x181DB6A60
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1DB6A50 Offset: 0x1DB5050 VA: 0x181DB6A50
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1DBC040 Offset: 0x1DBA640 VA: 0x181DBC040
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x1DBBEE0 Offset: 0x1DBA4E0 VA: 0x181DBBEE0
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1DBBED0 Offset: 0x1DBA4D0 VA: 0x181DBBED0
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1DB6E90 Offset: 0x1DB5490 VA: 0x181DB6E90
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1DB6BB0 Offset: 0x1DB51B0 VA: 0x181DB6BB0
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1DB6BA0 Offset: 0x1DB51A0 VA: 0x181DB6BA0
	private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1DB4F90 Offset: 0x1DB3590 VA: 0x181DB4F90
	public void Close() { }

	// RVA: 0x1DB5000 Offset: 0x1DB3600 VA: 0x181DB5000
	public void Close(int timeout) { }

	// RVA: 0x1DB4F80 Offset: 0x1DB3580 VA: 0x181DB4F80
	internal static void Close_icall(IntPtr socket, out int error) { }

	// RVA: 0x1DBC300 Offset: 0x1DBA900 VA: 0x181DBC300
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x1DBC2F0 Offset: 0x1DBA8F0 VA: 0x181DBC2F0
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x1DB5C00 Offset: 0x1DB4200 VA: 0x181DB5C00 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1DB7780 Offset: 0x1DB5D80 VA: 0x181DB7780
	private void Linger(IntPtr handle) { }

	// RVA: 0x1DBC840 Offset: 0x1DBAE40 VA: 0x181DBC840
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1DBC620 Offset: 0x1DBAC20 VA: 0x181DBC620
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x1DBC680 Offset: 0x1DBAC80 VA: 0x181DBC680
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x1DBC8D0 Offset: 0x1DBAED0 VA: 0x181DBC8D0
	private void ThrowIfUdp() { }

	// RVA: 0x1DBC930 Offset: 0x1DBAF30 VA: 0x181DBC930
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x1DB7F40 Offset: 0x1DB6540 VA: 0x181DB7F40
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x1DB7030 Offset: 0x1DB5630 VA: 0x181DB7030
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1DBC4E0 Offset: 0x1DBAAE0 VA: 0x181DBC4E0
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x1DBA030 Offset: 0x1DB8630 VA: 0x181DBA030
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x1DBD850 Offset: 0x1DBBE50 VA: 0x181DBD850
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x1DBD940 Offset: 0x1DBBF40 VA: 0x181DBD940
	internal static int get_FamilyHint() { }

	// RVA: 0x1417710 Offset: 0x1415D10 VA: 0x181417710
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1DB7730 Offset: 0x1DB5D30 VA: 0x181DB7730
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1DBCAA0 Offset: 0x1DBB0A0 VA: 0x181DBCAA0
	private static void .cctor() { }
}

// Namespace: System.Net.Sockets
[Serializable]
public class SocketException : Win32Exception // TypeDefIndex: 7946
{
	// Fields
	private EndPoint m_EndPoint; // 0x98

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x1DB2F10 Offset: 0x1DB1510 VA: 0x181DB2F10
	private static int WSAGetLastError_icall() { }

	// RVA: 0x1DB2F60 Offset: 0x1DB1560 VA: 0x181DB2F60
	public void .ctor() { }

	// RVA: 0x1DB2F20 Offset: 0x1DB1520 VA: 0x181DB2F20
	internal void .ctor(int error, string message) { }

	// RVA: 0x1DB2F30 Offset: 0x1DB1530 VA: 0x181DB2F30
	public void .ctor(int errorCode) { }

	// RVA: 0x1DB2F30 Offset: 0x1DB1530 VA: 0x181DB2F30
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x1DB2F40 Offset: 0x1DB1540 VA: 0x181DB2F40
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1DB2F80 Offset: 0x1DB1580 VA: 0x181DB2F80 Slot: 5
	public override string get_Message() { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public SocketError get_SocketErrorCode() { }
}

// Namespace: System.Net.Sockets
public enum AddressFamily // TypeDefIndex: 7947
{
	// Fields
	public int value__; // 0x0
	public const AddressFamily Unknown = -1;
	public const AddressFamily Unspecified = 0;
	public const AddressFamily Unix = 1;
	public const AddressFamily InterNetwork = 2;
	public const AddressFamily ImpLink = 3;
	public const AddressFamily Pup = 4;
	public const AddressFamily Chaos = 5;
	public const AddressFamily NS = 6;
	public const AddressFamily Ipx = 6;
	public const AddressFamily Iso = 7;
	public const AddressFamily Osi = 7;
	public const AddressFamily Ecma = 8;
	public const AddressFamily DataKit = 9;
	public const AddressFamily Ccitt = 10;
	public const AddressFamily Sna = 11;
	public const AddressFamily DecNet = 12;
	public const AddressFamily DataLink = 13;
	public const AddressFamily Lat = 14;
	public const AddressFamily HyperChannel = 15;
	public const AddressFamily AppleTalk = 16;
	public const AddressFamily NetBios = 17;
	public const AddressFamily VoiceView = 18;
	public const AddressFamily FireFox = 19;
	public const AddressFamily Banyan = 21;
	public const AddressFamily Atm = 22;
	public const AddressFamily InterNetworkV6 = 23;
	public const AddressFamily Cluster = 24;
	public const AddressFamily Ieee12844 = 25;
	public const AddressFamily Irda = 26;
	public const AddressFamily NetworkDesigners = 28;
	public const AddressFamily Max = 29;
}

// Namespace: System.Net.Sockets
public enum IOControlCode // TypeDefIndex: 7948
{
	// Fields
	public long value__; // 0x0
	public const IOControlCode AsyncIO = 2147772029;
	public const IOControlCode NonBlockingIO = 2147772030;
	public const IOControlCode DataToRead = 1074030207;
	public const IOControlCode OobDataRead = 1074033415;
	public const IOControlCode AssociateHandle = 2281701377;
	public const IOControlCode EnableCircularQueuing = 671088642;
	public const IOControlCode Flush = 671088644;
	public const IOControlCode GetBroadcastAddress = 1207959557;
	public const IOControlCode GetExtensionFunctionPointer = 3355443206;
	public const IOControlCode GetQos = 3355443207;
	public const IOControlCode GetGroupQos = 3355443208;
	public const IOControlCode MultipointLoopback = 2281701385;
	public const IOControlCode MulticastScope = 2281701386;
	public const IOControlCode SetQos = 2281701387;
	public const IOControlCode SetGroupQos = 2281701388;
	public const IOControlCode TranslateHandle = 3355443213;
	public const IOControlCode RoutingInterfaceQuery = 3355443220;
	public const IOControlCode RoutingInterfaceChange = 2281701397;
	public const IOControlCode AddressListQuery = 1207959574;
	public const IOControlCode AddressListChange = 671088663;
	public const IOControlCode QueryTargetPnpHandle = 1207959576;
	public const IOControlCode NamespaceChange = 2281701401;
	public const IOControlCode AddressListSort = 3355443225;
	public const IOControlCode ReceiveAll = 2550136833;
	public const IOControlCode ReceiveAllMulticast = 2550136834;
	public const IOControlCode ReceiveAllIgmpMulticast = 2550136835;
	public const IOControlCode KeepAliveValues = 2550136836;
	public const IOControlCode AbsorbRouterAlert = 2550136837;
	public const IOControlCode UnicastInterface = 2550136838;
	public const IOControlCode LimitBroadcasts = 2550136839;
	public const IOControlCode BindToInterface = 2550136840;
	public const IOControlCode MulticastInterface = 2550136841;
	public const IOControlCode AddMulticastGroupOnInterface = 2550136842;
	public const IOControlCode DeleteMulticastGroupFromInterface = 2550136843;
}

// Namespace: System.Net.Sockets
public enum IPProtectionLevel // TypeDefIndex: 7949
{
	// Fields
	public int value__; // 0x0
	public const IPProtectionLevel Unspecified = -1;
	public const IPProtectionLevel Unrestricted = 10;
	public const IPProtectionLevel EdgeRestricted = 20;
	public const IPProtectionLevel Restricted = 30;
}

// Namespace: System.Net.Sockets
public class LingerOption // TypeDefIndex: 7950
{
	// Fields
	private bool enabled; // 0x10
	private int lingerTime; // 0x14

	// Properties
	public bool Enabled { set; }
	public int LingerTime { set; }

	// Methods

	// RVA: 0x170B790 Offset: 0x1709D90 VA: 0x18170B790
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_Enabled(bool value) { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_LingerTime(int value) { }
}

// Namespace: System.Net.Sockets
public class MulticastOption // TypeDefIndex: 7951
{}

// Namespace: System.Net.Sockets
public enum ProtocolType // TypeDefIndex: 7952
{
	// Fields
	public int value__; // 0x0
	public const ProtocolType IP = 0;
	public const ProtocolType IPv6HopByHopOptions = 0;
	public const ProtocolType Icmp = 1;
	public const ProtocolType Igmp = 2;
	public const ProtocolType Ggp = 3;
	public const ProtocolType IPv4 = 4;
	public const ProtocolType Tcp = 6;
	public const ProtocolType Pup = 12;
	public const ProtocolType Udp = 17;
	public const ProtocolType Idp = 22;
	public const ProtocolType IPv6 = 41;
	public const ProtocolType IPv6RoutingHeader = 43;
	public const ProtocolType IPv6FragmentHeader = 44;
	public const ProtocolType IPSecEncapsulatingSecurityPayload = 50;
	public const ProtocolType IPSecAuthenticationHeader = 51;
	public const ProtocolType IcmpV6 = 58;
	public const ProtocolType IPv6NoNextHeader = 59;
	public const ProtocolType IPv6DestinationOptions = 60;
	public const ProtocolType ND = 77;
	public const ProtocolType Raw = 255;
	public const ProtocolType Unspecified = 0;
	public const ProtocolType Ipx = 1000;
	public const ProtocolType Spx = 1256;
	public const ProtocolType SpxII = 1257;
	public const ProtocolType Unknown = -1;
}

// Namespace: System.Net.Sockets
public enum SelectMode // TypeDefIndex: 7953
{
	// Fields
	public int value__; // 0x0
	public const SelectMode SelectRead = 0;
	public const SelectMode SelectWrite = 1;
	public const SelectMode SelectError = 2;
}

// Namespace: System.Net.Sockets
public enum SocketAsyncOperation // TypeDefIndex: 7954
{
	// Fields
	public int value__; // 0x0
	public const SocketAsyncOperation None = 0;
	public const SocketAsyncOperation Accept = 1;
	public const SocketAsyncOperation Connect = 2;
	public const SocketAsyncOperation Disconnect = 3;
	public const SocketAsyncOperation Receive = 4;
	public const SocketAsyncOperation ReceiveFrom = 5;
	public const SocketAsyncOperation ReceiveMessageFrom = 6;
	public const SocketAsyncOperation Send = 7;
	public const SocketAsyncOperation SendPackets = 8;
	public const SocketAsyncOperation SendTo = 9;
}

// Namespace: System.Net.Sockets
public enum SocketError // TypeDefIndex: 7955
{
	// Fields
	public int value__; // 0x0
	public const SocketError Success = 0;
	public const SocketError SocketError = -1;
	public const SocketError Interrupted = 10004;
	public const SocketError AccessDenied = 10013;
	public const SocketError Fault = 10014;
	public const SocketError InvalidArgument = 10022;
	public const SocketError TooManyOpenSockets = 10024;
	public const SocketError WouldBlock = 10035;
	public const SocketError InProgress = 10036;
	public const SocketError AlreadyInProgress = 10037;
	public const SocketError NotSocket = 10038;
	public const SocketError DestinationAddressRequired = 10039;
	public const SocketError MessageSize = 10040;
	public const SocketError ProtocolType = 10041;
	public const SocketError ProtocolOption = 10042;
	public const SocketError ProtocolNotSupported = 10043;
	public const SocketError SocketNotSupported = 10044;
	public const SocketError OperationNotSupported = 10045;
	public const SocketError ProtocolFamilyNotSupported = 10046;
	public const SocketError AddressFamilyNotSupported = 10047;
	public const SocketError AddressAlreadyInUse = 10048;
	public const SocketError AddressNotAvailable = 10049;
	public const SocketError NetworkDown = 10050;
	public const SocketError NetworkUnreachable = 10051;
	public const SocketError NetworkReset = 10052;
	public const SocketError ConnectionAborted = 10053;
	public const SocketError ConnectionReset = 10054;
	public const SocketError NoBufferSpaceAvailable = 10055;
	public const SocketError IsConnected = 10056;
	public const SocketError NotConnected = 10057;
	public const SocketError Shutdown = 10058;
	public const SocketError TimedOut = 10060;
	public const SocketError ConnectionRefused = 10061;
	public const SocketError HostDown = 10064;
	public const SocketError HostUnreachable = 10065;
	public const SocketError ProcessLimit = 10067;
	public const SocketError SystemNotReady = 10091;
	public const SocketError VersionNotSupported = 10092;
	public const SocketError NotInitialized = 10093;
	public const SocketError Disconnecting = 10101;
	public const SocketError TypeNotFound = 10109;
	public const SocketError HostNotFound = 11001;
	public const SocketError TryAgain = 11002;
	public const SocketError NoRecovery = 11003;
	public const SocketError NoData = 11004;
	public const SocketError IOPending = 997;
	public const SocketError OperationAborted = 995;
}

// Namespace: System.Net.Sockets
[Flags]
public enum SocketFlags // TypeDefIndex: 7956
{
	// Fields
	public int value__; // 0x0
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;
}

// Namespace: System.Net.Sockets
public enum SocketOptionLevel // TypeDefIndex: 7957
{
	// Fields
	public int value__; // 0x0
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;
}

// Namespace: System.Net.Sockets
public enum SocketOptionName // TypeDefIndex: 7958
{
	// Fields
	public int value__; // 0x0
	public const SocketOptionName Debug = 1;
	public const SocketOptionName AcceptConnection = 2;
	public const SocketOptionName ReuseAddress = 4;
	public const SocketOptionName KeepAlive = 8;
	public const SocketOptionName DontRoute = 16;
	public const SocketOptionName Broadcast = 32;
	public const SocketOptionName UseLoopback = 64;
	public const SocketOptionName Linger = 128;
	public const SocketOptionName OutOfBandInline = 256;
	public const SocketOptionName DontLinger = -129;
	public const SocketOptionName ExclusiveAddressUse = -5;
	public const SocketOptionName SendBuffer = 4097;
	public const SocketOptionName ReceiveBuffer = 4098;
	public const SocketOptionName SendLowWater = 4099;
	public const SocketOptionName ReceiveLowWater = 4100;
	public const SocketOptionName SendTimeout = 4101;
	public const SocketOptionName ReceiveTimeout = 4102;
	public const SocketOptionName Error = 4103;
	public const SocketOptionName Type = 4104;
	public const SocketOptionName ReuseUnicastPort = 12295;
	public const SocketOptionName MaxConnections = 2147483647;
	public const SocketOptionName IPOptions = 1;
	public const SocketOptionName HeaderIncluded = 2;
	public const SocketOptionName TypeOfService = 3;
	public const SocketOptionName IpTimeToLive = 4;
	public const SocketOptionName MulticastInterface = 9;
	public const SocketOptionName MulticastTimeToLive = 10;
	public const SocketOptionName MulticastLoopback = 11;
	public const SocketOptionName AddMembership = 12;
	public const SocketOptionName DropMembership = 13;
	public const SocketOptionName DontFragment = 14;
	public const SocketOptionName AddSourceMembership = 15;
	public const SocketOptionName DropSourceMembership = 16;
	public const SocketOptionName BlockSource = 17;
	public const SocketOptionName UnblockSource = 18;
	public const SocketOptionName PacketInformation = 19;
	public const SocketOptionName HopLimit = 21;
	public const SocketOptionName IPProtectionLevel = 23;
	public const SocketOptionName IPv6Only = 27;
	public const SocketOptionName NoDelay = 1;
	public const SocketOptionName BsdUrgent = 2;
	public const SocketOptionName Expedited = 2;
	public const SocketOptionName NoChecksum = 1;
	public const SocketOptionName ChecksumCoverage = 20;
	public const SocketOptionName UpdateAcceptContext = 28683;
	public const SocketOptionName UpdateConnectContext = 28688;
}

// Namespace: System.Net.Sockets
public enum SocketShutdown // TypeDefIndex: 7959
{
	// Fields
	public int value__; // 0x0
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;
}

// Namespace: System.Net.Sockets
public enum SocketType // TypeDefIndex: 7960
{
	// Fields
	public int value__; // 0x0
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = -1;
}

// Namespace: System.Net.Sockets
public class TcpClient : IDisposable // TypeDefIndex: 7961
{
	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C

	// Properties
	public Socket Client { get; set; }

	// Methods

	// RVA: 0x1DC01F0 Offset: 0x1DBE7F0 VA: 0x181DC01F0
	public void .ctor() { }

	// RVA: 0x1DC02B0 Offset: 0x1DBE8B0 VA: 0x181DC02B0
	public void .ctor(AddressFamily family) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Socket get_Client() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Client(Socket value) { }

	// RVA: 0x1DBF870 Offset: 0x1DBDE70 VA: 0x181DBF870
	public void Connect(string hostname, int port) { }

	// RVA: 0x1DBF760 Offset: 0x1DBDD60 VA: 0x181DBF760
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x1DBF570 Offset: 0x1DBDB70 VA: 0x181DBF570
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1DC0020 Offset: 0x1DBE620 VA: 0x181DC0020
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1DBF5F0 Offset: 0x1DBDBF0 VA: 0x181DBF5F0
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x1DC0070 Offset: 0x1DBE670 VA: 0x181DC0070
	public NetworkStream GetStream() { }

	// RVA: 0x1DBFF00 Offset: 0x1DBE500 VA: 0x181DBFF00 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1DBFEE0 Offset: 0x1DBE4E0 VA: 0x181DBFEE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1DC0420 Offset: 0x1DBEA20 VA: 0x181DC0420
	private void initialize() { }
}

// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid // TypeDefIndex: 7962
{
	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0x1DB22B0 Offset: 0x1DB08B0 VA: 0x181DB22B0
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x1DB1B60 Offset: 0x1DB0160 VA: 0x181DB1B60 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1DB1A00 Offset: 0x1DB0000 VA: 0x181DB1A00
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x1DB20A0 Offset: 0x1DB06A0 VA: 0x181DB20A0
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x1DB2240 Offset: 0x1DB0840 VA: 0x181DB2240
	private static void .cctor() { }
}

// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 7963
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	private EndPoint remote_ep; // 0x18
	private Socket current_socket; // 0x20
	internal SocketAsyncResult socket_async_result; // 0x28
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; // 0x38
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; // 0x3C
	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; // 0x40
	[CompilerGenerated]
	private SocketFlags <SocketFlags>k__BackingField; // 0x44
	[CompilerGenerated]
	private object <UserToken>k__BackingField; // 0x48
	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x50
	private Memory<byte> _buffer; // 0x58
	private int _offset; // 0x68
	private int _count; // 0x6C
	private bool _bufferIsExplicitArray; // 0x70
	private IList<ArraySegment<byte>> _bufferList; // 0x78

	// Properties
	public Socket AcceptSocket { get; set; }
	public int BytesTransferred { get; set; }
	private SocketAsyncOperation LastOperation { set; }
	public EndPoint RemoteEndPoint { set; }
	public SocketError SocketError { get; set; }
	public SocketFlags SocketFlags { set; }
	public object UserToken { get; set; }
	internal Socket CurrentSocket { get; }
	public Memory<byte> MemoryBuffer { get; }
	public int Offset { get; }
	public int Count { get; }
	public IList<ArraySegment<byte>> BufferList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Socket get_AcceptSocket() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_AcceptSocket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public int get_BytesTransferred() { }

	[CompilerGenerated]
	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	private void set_BytesTransferred(int value) { }

	[CompilerGenerated]
	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_RemoteEndPoint(EndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public SocketError get_SocketError() { }

	[CompilerGenerated]
	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	public void set_SocketError(SocketError value) { }

	[CompilerGenerated]
	// RVA: 0x1978180 Offset: 0x1976780 VA: 0x181978180
	public void set_SocketFlags(SocketFlags value) { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public object get_UserToken() { }

	[CompilerGenerated]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_UserToken(object value) { }

	// RVA: 0x1DB27F0 Offset: 0x1DB0DF0 VA: 0x181DB27F0
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x1DB25C0 Offset: 0x1DB0BC0 VA: 0x181DB25C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1DB25B0 Offset: 0x1DB0BB0 VA: 0x181DB25B0
	private void Dispose(bool disposing) { }

	// RVA: 0x1DB2550 Offset: 0x1DB0B50 VA: 0x181DB2550 Slot: 4
	public void Dispose() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal Socket get_CurrentSocket() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x1DB2720 Offset: 0x1DB0D20 VA: 0x181DB2720
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x1DB2510 Offset: 0x1DB0B10 VA: 0x181DB2510
	internal void Complete_internal() { }

	// RVA: 0x1DB2600 Offset: 0x1DB0C00 VA: 0x181DB2600 Slot: 5
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x199B300 Offset: 0x1999900 VA: 0x18199B300
	public Memory<byte> get_MemoryBuffer() { }

	// RVA: 0xC9D690 Offset: 0xC9BC90 VA: 0x180C9D690
	public int get_Offset() { }

	// RVA: 0xC9D570 Offset: 0xC9BB70 VA: 0x180C9D570
	public int get_Count() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public IList<ArraySegment<byte>> get_BufferList() { }

	// RVA: 0x1DB2630 Offset: 0x1DB0C30 VA: 0x181DB2630
	public void SetBuffer(Memory<byte> buffer) { }
}

// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 7965
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public Memory<byte> Buffer; // 0x50
	public int Offset; // 0x60
	public int Size; // 0x64
	public SocketFlags SockFlags; // 0x68
	public Socket AcceptSocket; // 0x70
	public IPAddress[] Addresses; // 0x78
	public int Port; // 0x80
	public IList<ArraySegment<byte>> Buffers; // 0x88
	public bool ReuseSocket; // 0x90
	public int CurrentAddress; // 0x94
	public Socket AcceptedSocket; // 0x98
	public int Total; // 0xA0
	internal int error; // 0xA4
	public int EndCalled; // 0xA8

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x1DB2E80 Offset: 0x1DB1480 VA: 0x181DB2E80
	public IntPtr get_Handle() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1DB2C70 Offset: 0x1DB1270 VA: 0x181DB2C70
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1DB2DA0 Offset: 0x1DB13A0 VA: 0x181DB2DA0
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1DB2DF0 Offset: 0x1DB13F0 VA: 0x181DB2DF0
	public SocketError get_ErrorCode() { }

	// RVA: 0x1DB2880 Offset: 0x1DB0E80 VA: 0x181DB2880
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x1DB2930 Offset: 0x1DB0F30 VA: 0x181DB2930 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x1DB2A40 Offset: 0x1DB1040 VA: 0x181DB2A40
	public void Complete() { }

	// RVA: 0x1DB2940 Offset: 0x1DB0F40 VA: 0x181DB2940
	public void Complete(bool synch) { }

	// RVA: 0x1DB2A00 Offset: 0x1DB1000 VA: 0x181DB2A00
	public void Complete(int total) { }

	// RVA: 0x1DB2980 Offset: 0x1DB0F80 VA: 0x181DB2980
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x1DB2950 Offset: 0x1DB0F50 VA: 0x181DB2950
	public void Complete(Exception e) { }

	// RVA: 0x1DB2A10 Offset: 0x1DB1010 VA: 0x181DB2A10
	public void Complete(Socket s) { }

	// RVA: 0x1DB29C0 Offset: 0x1DB0FC0 VA: 0x181DB29C0
	public void Complete(Socket s, int total) { }
}

// Namespace: System.Net.Sockets
internal enum SocketOperation // TypeDefIndex: 7966
{
	// Fields
	public int value__; // 0x0
	public const SocketOperation Accept = 0;
	public const SocketOperation Connect = 1;
	public const SocketOperation Receive = 2;
	public const SocketOperation ReceiveFrom = 3;
	public const SocketOperation Send = 4;
	public const SocketOperation SendTo = 5;
	public const SocketOperation RecvJustCallback = 6;
	public const SocketOperation SendJustCallback = 7;
	public const SocketOperation Disconnect = 8;
	public const SocketOperation AcceptReceive = 9;
	public const SocketOperation ReceiveGeneric = 10;
	public const SocketOperation SendGeneric = 11;
}

