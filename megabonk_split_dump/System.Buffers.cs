// Namespace: System.Buffers
public sealed class SpanAction<T, TArg> : MulticastDelegate // TypeDefIndex: 1558
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9743B0 Offset: 0x9729B0 VA: 0x1809743B0
	|-SpanAction<char, ValueTuple<object, int, int>>..ctor
	|
	|-RVA: 0x974460 Offset: 0x972A60 VA: 0x180974460
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>..ctor
	|
	|-RVA: 0x974510 Offset: 0x972B10 VA: 0x180974510
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>..ctor
	|
	|-RVA: 0x9745C0 Offset: 0x972BC0 VA: 0x1809745C0
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(Span<T> span, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x974370 Offset: 0x972970 VA: 0x180974370
	|-SpanAction<char, ValueTuple<object, int, int>>.Invoke
	|
	|-RVA: 0x974330 Offset: 0x972930 VA: 0x180974330
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>.Invoke
	|
	|-RVA: 0x9742B0 Offset: 0x9728B0 VA: 0x1809742B0
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>.Invoke
	|
	|-RVA: 0x974300 Offset: 0x972900 VA: 0x180974300
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Buffers
public abstract class ArrayPool<T> // TypeDefIndex: 1559
{
	// Fields
	[CompilerGenerated]
	private static readonly ArrayPool<T> <Shared>k__BackingField; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1050960 Offset: 0x104EF60 VA: 0x181050960
	|-ArrayPool<byte>.get_Shared
	|-ArrayPool<char>.get_Shared
	|-ArrayPool<int>.get_Shared
	|-ArrayPool<__Il2CppFullySharedGenericType>.get_Shared
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-ArrayPool<byte>..ctor
	|-ArrayPool<char>..ctor
	|-ArrayPool<int>..ctor
	|-ArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1050250 Offset: 0x104E850 VA: 0x181050250
	|-ArrayPool<byte>..cctor
	|
	|-RVA: 0x1050570 Offset: 0x104EB70 VA: 0x181050570
	|-ArrayPool<char>..cctor
	|
	|-RVA: 0x1050350 Offset: 0x104E950 VA: 0x181050350
	|-ArrayPool<int>..cctor
	|
	|-RVA: 0x1050450 Offset: 0x104EA50 VA: 0x181050450
	|-ArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Buffers
[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
internal sealed class ArrayPoolEventSource : EventSource // TypeDefIndex: 1561
{
	// Fields
	internal static readonly ArrayPoolEventSource Log; // 0x0

	// Methods

	// RVA: 0x14A1AD0 Offset: 0x14A00D0 VA: 0x1814A1AD0
	private void .ctor() { }

	[Event(1, Level = 5)]
	// RVA: 0x14A1780 Offset: 0x149FD80 VA: 0x1814A1780
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Event(2, Level = 4)]
	// RVA: 0x14A16A0 Offset: 0x149FCA0 VA: 0x1814A16A0
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason) { }

	[Event(3, Level = 5)]
	// RVA: 0x14A1850 Offset: 0x149FE50 VA: 0x1814A1850
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	[Event(4, Level = 4)]
	// RVA: 0x14A19A0 Offset: 0x149FFA0 VA: 0x1814A19A0
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId) { }

	[Event(5, Level = 4)]
	// RVA: 0x14A1880 Offset: 0x149FE80 VA: 0x1814A1880
	internal void BufferTrimPoll(int milliseconds, int pressure) { }

	// RVA: 0x14A19D0 Offset: 0x149FFD0 VA: 0x1814A19D0
	private static void .cctor() { }
}

// Namespace: System.Buffers
public interface IPinnable // TypeDefIndex: 1562
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Unpin();
}

// Namespace: System.Buffers
public struct MemoryHandle : IDisposable // TypeDefIndex: 1563
{
	// Fields
	private void* _pointer; // 0x0
	private GCHandle _handle; // 0x8
	private IPinnable _pinnable; // 0x10

	// Properties
	[CLSCompliant(False)]
	public void* Pointer { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x14BD6A0 Offset: 0x14BBCA0 VA: 0x1814BD6A0
	public void .ctor(void* pointer, GCHandle handle, IPinnable pinnable) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public void* get_Pointer() { }

	// RVA: 0x14BD630 Offset: 0x14BBC30 VA: 0x1814BD630 Slot: 4
	public void Dispose() { }
}

// Namespace: System.Buffers
public abstract class MemoryManager<T> // TypeDefIndex: 1564
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Span<T> GetSpan();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.GetSpan
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract MemoryHandle Pin(int elementIndex = 0);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.Pin
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected internal virtual bool TryGetArray(out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D990 Offset: 0x128BF90 VA: 0x18128D990
	|-MemoryManager<byte>.TryGetArray
	|-MemoryManager<char>.TryGetArray
	|-MemoryManager<__Il2CppFullySharedGenericType>.TryGetArray
	*/
}

// Namespace: System.Buffers
internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T> // TypeDefIndex: 1568
{
	// Fields
	private readonly int[] _bucketArraySizes; // 0x0
	private readonly TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T>[] _buckets; // 0x0
	[ThreadStatic]
	private static T[][] t_tlsBuckets; // 0xFFFFFFFF
	private int _callbackCreated; // 0x0
	private static readonly bool s_trimBuffers; // 0x0
	private static readonly ConditionalWeakTable<T[][], object> s_allTlsBuckets; // 0x0

	// Properties
	private int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4D8A0 Offset: 0xA4BEA0 VA: 0x180A4D8A0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..ctor
	|
	|-RVA: 0xA51E30 Offset: 0xA50430 VA: 0x180A51E30
	|-TlsOverPerCoreLockedStacksArrayPool<char>..ctor
	|
	|-RVA: 0xA52070 Offset: 0xA50670 VA: 0x180A52070
	|-TlsOverPerCoreLockedStacksArrayPool<int>..ctor
	|
	|-RVA: 0xA51F50 Offset: 0xA50550 VA: 0x180A51F50
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C1E0 Offset: 0xA4A7E0 VA: 0x180A4C1E0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.CreatePerCoreLockedStacks
	|
	|-RVA: 0xA4DEB0 Offset: 0xA4C4B0 VA: 0x180A4DEB0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.CreatePerCoreLockedStacks
	|
	|-RVA: 0xA4DE00 Offset: 0xA4C400 VA: 0x180A4DE00
	|-TlsOverPerCoreLockedStacksArrayPool<int>.CreatePerCoreLockedStacks
	|
	|-RVA: 0xA4DD50 Offset: 0xA4C350 VA: 0x180A4DD50
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.CreatePerCoreLockedStacks
	*/

	// RVA: -1 Offset: -1
	private int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4D9C0 Offset: 0xA4BFC0 VA: 0x180A4D9C0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.get_Id
	|-TlsOverPerCoreLockedStacksArrayPool<char>.get_Id
	|-TlsOverPerCoreLockedStacksArrayPool<int>.get_Id
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.get_Id
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C470 Offset: 0xA4AA70 VA: 0x180A4C470
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Rent
	|
	|-RVA: 0xA4EEC0 Offset: 0xA4D4C0 VA: 0x180A4EEC0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Rent
	|
	|-RVA: 0xA4E530 Offset: 0xA4CB30 VA: 0x180A4E530
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Rent
	|
	|-RVA: 0xA4EA80 Offset: 0xA4D080 VA: 0x180A4EA80
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C9C0 Offset: 0xA4AFC0 VA: 0x180A4C9C0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Return
	|
	|-RVA: 0xA4F960 Offset: 0xA4DF60 VA: 0x180A4F960
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Return
	|
	|-RVA: 0xA4FEB0 Offset: 0xA4E4B0 VA: 0x180A4FEB0
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Return
	|
	|-RVA: 0xA4F410 Offset: 0xA4DA10 VA: 0x180A4F410
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	public bool Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4CF10 Offset: 0xA4B510 VA: 0x180A4CF10
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Trim
	|
	|-RVA: 0xA50400 Offset: 0xA4EA00 VA: 0x180A50400
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Trim
	|
	|-RVA: 0xA50C00 Offset: 0xA4F200 VA: 0x180A50C00
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Trim
	|
	|-RVA: 0xA51400 Offset: 0xA4FA00 VA: 0x180A51400
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	private static bool Gen2GcCallbackFunc(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C290 Offset: 0xA4A890 VA: 0x180A4C290
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Gen2GcCallbackFunc
	|
	|-RVA: 0xA4E1B0 Offset: 0xA4C7B0 VA: 0x180A4E1B0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Gen2GcCallbackFunc
	|
	|-RVA: 0xA4DF60 Offset: 0xA4C560 VA: 0x180A4DF60
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Gen2GcCallbackFunc
	|
	|-RVA: 0xA4E070 Offset: 0xA4C670 VA: 0x180A4E070
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Gen2GcCallbackFunc
	*/

	// RVA: -1 Offset: -1
	private static TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> GetMemoryPressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C3A0 Offset: 0xA4A9A0 VA: 0x180A4C3A0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetMemoryPressure
	|
	|-RVA: 0xA4E2C0 Offset: 0xA4C8C0 VA: 0x180A4E2C0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetMemoryPressure
	|
	|-RVA: 0xA4E460 Offset: 0xA4CA60 VA: 0x180A4E460
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetMemoryPressure
	|
	|-RVA: 0xA4E390 Offset: 0xA4C990 VA: 0x180A4E390
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetMemoryPressure
	*/

	// RVA: -1 Offset: -1
	private static bool GetTrimBuffers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetTrimBuffers
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetTrimBuffers
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetTrimBuffers
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetTrimBuffers
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4D710 Offset: 0xA4BD10 VA: 0x180A4D710
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..cctor
	|-TlsOverPerCoreLockedStacksArrayPool<char>..cctor
	|-TlsOverPerCoreLockedStacksArrayPool<int>..cctor
	|
	|-RVA: 0xA51C30 Offset: 0xA50230 VA: 0x180A51C30
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Buffers
internal static class Utilities // TypeDefIndex: 1569
{
	// Methods

	// RVA: 0xA2F310 Offset: 0xA2D910 VA: 0x180A2F310
	internal static int SelectBucketIndex(int bufferSize) { }

	// RVA: 0x14D2710 Offset: 0x14D0D10 VA: 0x1814D2710
	internal static int GetMaxSizeForBucket(int binIndex) { }
}

