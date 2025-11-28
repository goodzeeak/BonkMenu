// Namespace: System.Threading
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 493
{
	// Fields
	private int _mutexIndex; // 0x90
	private Mutex _mutex; // 0x98

	// Methods

	// RVA: 0x15733B0 Offset: 0x15719B0 VA: 0x1815733B0
	public void .ctor() { }

	// RVA: 0x1573400 Offset: 0x1571A00 VA: 0x181573400
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x15734C0 Offset: 0x1571AC0 VA: 0x1815734C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1573320 Offset: 0x1571920 VA: 0x181573320
	private void SetupException(int location, WaitHandle handle) { }
}

// Namespace: System.Threading
public sealed class AsyncLocal<T> // TypeDefIndex: 494
{}

// Namespace: System.Threading
internal interface IAsyncLocal // TypeDefIndex: 495
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
}

// Namespace: System.Threading
public sealed class AutoResetEvent : EventWaitHandle // TypeDefIndex: 496
{
	// Methods

	// RVA: 0x1573750 Offset: 0x1571D50 VA: 0x181573750
	public void .ctor(bool initialState) { }
}

// Namespace: System.Threading
public enum EventResetMode // TypeDefIndex: 497
{
	// Fields
	public int value__; // 0x0
	public const EventResetMode AutoReset = 0;
	public const EventResetMode ManualReset = 1;
}

// Namespace: System.Threading
public static class LazyInitializer // TypeDefIndex: 498
{
	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7162E0 Offset: 0x7148E0 VA: 0x1807162E0
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x716000 Offset: 0x714600 VA: 0x180716000
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7163D0 Offset: 0x7149D0 VA: 0x1807163D0
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7160A0 Offset: 0x7146A0 VA: 0x1807160A0
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x716150 Offset: 0x714750 VA: 0x180716150
	|-LazyInitializer.EnsureInitialized<bool>
	|
	|-RVA: 0x7161E0 Offset: 0x7147E0 VA: 0x1807161E0
	|-LazyInitializer.EnsureInitialized<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x715BE0 Offset: 0x7141E0 VA: 0x180715BE0
	|-LazyInitializer.EnsureInitializedCore<bool>
	|
	|-RVA: 0x715CF0 Offset: 0x7142F0 VA: 0x180715CF0
	|-LazyInitializer.EnsureInitializedCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x716350 Offset: 0x714950 VA: 0x180716350
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x715EC0 Offset: 0x7144C0 VA: 0x180715EC0
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: 0x157FD50 Offset: 0x157E350 VA: 0x18157FD50
	private static object EnsureLockInitialized(ref object syncLock) { }
}

// Namespace: System.Threading
public enum LazyThreadSafetyMode // TypeDefIndex: 499
{
	// Fields
	public int value__; // 0x0
	public const LazyThreadSafetyMode None = 0;
	public const LazyThreadSafetyMode PublicationOnly = 1;
	public const LazyThreadSafetyMode ExecutionAndPublication = 2;
}

// Namespace: System.Threading
[Serializable]
public class LockRecursionException : Exception // TypeDefIndex: 500
{
	// Methods

	// RVA: 0x1580310 Offset: 0x157E910 VA: 0x181580310
	public void .ctor() { }

	// RVA: 0x1580360 Offset: 0x157E960 VA: 0x181580360
	public void .ctor(string message) { }

	// RVA: 0x1580290 Offset: 0x157E890 VA: 0x181580290
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class ManualResetEvent : EventWaitHandle // TypeDefIndex: 501
{
	// Methods

	// RVA: 0x1581F60 Offset: 0x1580560 VA: 0x181581F60
	public void .ctor(bool initialState) { }
}

// Namespace: System.Threading
public sealed class ParameterizedThreadStart : MulticastDelegate // TypeDefIndex: 502
{
	// Methods

	// RVA: 0xC9DA00 Offset: 0xC9C000 VA: 0x180C9DA00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object obj) { }
}

// Namespace: System.Threading
[Serializable]
public class SemaphoreFullException : SystemException // TypeDefIndex: 503
{
	// Methods

	// RVA: 0x1582B80 Offset: 0x1581180 VA: 0x181582B80
	public void .ctor() { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class SendOrPostCallback : MulticastDelegate // TypeDefIndex: 504
{
	// Methods

	// RVA: 0xC9DA00 Offset: 0xC9C000 VA: 0x180C9DA00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
[Serializable]
public class SynchronizationLockException : SystemException // TypeDefIndex: 505
{
	// Methods

	// RVA: 0x1585870 Offset: 0x1583E70 VA: 0x181585870
	public void .ctor() { }

	// RVA: 0x1585850 Offset: 0x1583E50 VA: 0x181585850
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class ThreadStart : MulticastDelegate // TypeDefIndex: 506
{
	// Methods

	// RVA: 0x3B5700 Offset: 0x3B3D00 VA: 0x1803B5700
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x345000 Offset: 0x343600 VA: 0x180345000 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: System.Threading
[Flags]
public enum ThreadState // TypeDefIndex: 507
{
	// Fields
	public int value__; // 0x0
	public const ThreadState Running = 0;
	public const ThreadState StopRequested = 1;
	public const ThreadState SuspendRequested = 2;
	public const ThreadState Background = 4;
	public const ThreadState Unstarted = 8;
	public const ThreadState Stopped = 16;
	public const ThreadState WaitSleepJoin = 32;
	public const ThreadState Suspended = 64;
	public const ThreadState AbortRequested = 128;
	public const ThreadState Aborted = 256;
}

// Namespace: System.Threading
[Serializable]
public class ThreadStateException : SystemException // TypeDefIndex: 508
{
	// Methods

	// RVA: 0x1585960 Offset: 0x1583F60 VA: 0x181585960
	public void .ctor() { }

	// RVA: 0x1585940 Offset: 0x1583F40 VA: 0x181585940
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public static class Timeout // TypeDefIndex: 509
{
	// Fields
	public static readonly TimeSpan InfiniteTimeSpan; // 0x0

	// Methods

	// RVA: 0x1585A00 Offset: 0x1584000 VA: 0x181585A00
	private static void .cctor() { }
}

// Namespace: System.Threading
[Serializable]
public class WaitHandleCannotBeOpenedException : ApplicationException // TypeDefIndex: 510
{
	// Methods

	// RVA: 0x1588F60 Offset: 0x1587560 VA: 0x181588F60
	public void .ctor() { }

	// RVA: 0x1588FB0 Offset: 0x15875B0 VA: 0x181588FB0
	public void .ctor(string message) { }

	// RVA: 0x1440750 Offset: 0x143ED50 VA: 0x181440750
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
[IsReadOnly]
public struct CancellationToken // TypeDefIndex: 512
{
	// Fields
	private readonly CancellationTokenSource _source; // 0x0
	private static readonly Action<object> s_actionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static CancellationToken get_None() { }

	// RVA: 0x1575E20 Offset: 0x1574420 VA: 0x181575E20
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10
	public bool get_CanBeCanceled() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x1575D70 Offset: 0x1574370 VA: 0x181575D70
	public void .ctor(bool canceled) { }

	// RVA: 0x1575950 Offset: 0x1573F50 VA: 0x181575950
	public CancellationTokenRegistration Register(Action callback) { }

	// RVA: 0x15758A0 Offset: 0x1573EA0 VA: 0x1815758A0
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x1575A60 Offset: 0x1574060 VA: 0x181575A60
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670
	public bool Equals(CancellationToken other) { }

	// RVA: 0x1575780 Offset: 0x1573D80 VA: 0x181575780 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1575820 Offset: 0x1573E20 VA: 0x181575820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1575E60 Offset: 0x1574460 VA: 0x181575E60
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1575EC0 Offset: 0x15744C0 VA: 0x181575EC0
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1575BC0 Offset: 0x15741C0 VA: 0x181575BC0
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x1575C40 Offset: 0x1574240 VA: 0x181575C40
	private void ThrowOperationCanceledException() { }

	// RVA: 0x1575CA0 Offset: 0x15742A0 VA: 0x181575CA0
	private static void .cctor() { }
}

// Namespace: System.Threading
[DebuggerDisplay("Set = {IsSet}")]
public class ManualResetEventSlim : IDisposable // TypeDefIndex: 513
{
	// Fields
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x1581D50 Offset: 0x1580350 VA: 0x181581D50
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1581C90 Offset: 0x1580290 VA: 0x181581C90
	public bool get_IsSet() { }

	// RVA: 0x1581E40 Offset: 0x1580440 VA: 0x181581E40
	private void set_IsSet(bool value) { }

	// RVA: 0x1581CF0 Offset: 0x15802F0 VA: 0x181581CF0
	public int get_SpinCount() { }

	// RVA: 0x1581E70 Offset: 0x1580470 VA: 0x181581E70
	private void set_SpinCount(int value) { }

	// RVA: 0x1581DF0 Offset: 0x15803F0 VA: 0x181581DF0
	private int get_Waiters() { }

	// RVA: 0x1581EB0 Offset: 0x15804B0 VA: 0x181581EB0
	private void set_Waiters(int value) { }

	// RVA: 0x1581A70 Offset: 0x1580070 VA: 0x181581A70
	public void .ctor(bool initialState) { }

	// RVA: 0x1581B70 Offset: 0x1580170 VA: 0x181581B70
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x15808C0 Offset: 0x157EEC0 VA: 0x1815808C0
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1580820 Offset: 0x157EE20 VA: 0x181580820
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1580980 Offset: 0x157EF80 VA: 0x181580980
	private bool LazyInitializeEvent() { }

	// RVA: 0x1580CB0 Offset: 0x157F2B0 VA: 0x181580CB0
	public void Set() { }

	// RVA: 0x1580CC0 Offset: 0x157F2C0 VA: 0x181580CC0
	private void Set(bool duringCancellation) { }

	// RVA: 0x15811C0 Offset: 0x157F7C0 VA: 0x1815811C0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1580670 Offset: 0x157EC70 VA: 0x181580670 Slot: 4
	public void Dispose() { }

	// RVA: 0x15806D0 Offset: 0x157ECD0 VA: 0x1815806D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1581040 Offset: 0x157F640 VA: 0x181581040
	private void ThrowIfDisposed() { }

	// RVA: 0x1580450 Offset: 0x157EA50 VA: 0x181580450
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x15810B0 Offset: 0x157F6B0 VA: 0x1815810B0
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x15808A0 Offset: 0x157EEA0 VA: 0x1815808A0
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x15808B0 Offset: 0x157EEB0 VA: 0x1815808B0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x15819E0 Offset: 0x157FFE0 VA: 0x1815819E0
	private static void .cctor() { }
}

// Namespace: System.Threading
public struct NativeOverlapped // TypeDefIndex: 514
{
	// Fields
	public IntPtr InternalLow; // 0x0
	public IntPtr InternalHigh; // 0x8
	public int OffsetLow; // 0x10
	public int OffsetHigh; // 0x14
	public IntPtr EventHandle; // 0x18
}

// Namespace: System.Threading
public struct SpinWait // TypeDefIndex: 515
{
	// Fields
	internal static readonly int SpinCountforSpinBeforeWait; // 0x0
	private int _count; // 0x0

	// Properties
	public int Count { get; }
	public bool NextSpinWillYield { get; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_Count() { }

	// RVA: 0x15857E0 Offset: 0x1583DE0 VA: 0x1815857E0
	public bool get_NextSpinWillYield() { }

	// RVA: 0x1585620 Offset: 0x1583C20 VA: 0x181585620
	public void SpinOnce() { }

	// RVA: 0x1585670 Offset: 0x1583C70 VA: 0x181585670
	public void SpinOnce(int sleep1Threshold) { }

	// RVA: 0x1585490 Offset: 0x1583A90 VA: 0x181585490
	private void SpinOnceCore(int sleep1Threshold) { }

	// RVA: 0x1585760 Offset: 0x1583D60 VA: 0x181585760
	private static void .cctor() { }
}

// Namespace: System.Threading
internal static class PlatformHelper // TypeDefIndex: 516
{
	// Fields
	private static int s_processorCount; // 0x0
	private static int s_lastProcessorCountRefreshTicks; // 0x4
	internal static readonly bool IsSingleProcessor; // 0x8

	// Properties
	internal static int ProcessorCount { get; }

	// Methods

	// RVA: 0x1582810 Offset: 0x1580E10 VA: 0x181582810
	internal static int get_ProcessorCount() { }

	// RVA: 0x15827C0 Offset: 0x1580DC0 VA: 0x1815827C0
	private static void .cctor() { }
}

// Namespace: System.Threading
internal static class TimeoutHelper // TypeDefIndex: 517
{
	// Methods

	// RVA: 0x15859B0 Offset: 0x1583FB0 VA: 0x1815859B0
	public static uint GetTime() { }

	// RVA: 0x15859C0 Offset: 0x1583FC0 VA: 0x1815859C0
	public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout) { }
}

// Namespace: System.Threading
[IsReadOnly]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 518
{
	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x10937B0 Offset: 0x1091DB0 VA: 0x1810937B0
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	// RVA: 0x1573FA0 Offset: 0x15725A0 VA: 0x181573FA0
	public bool Unregister() { }

	// RVA: 0x1573C20 Offset: 0x1572220 VA: 0x181573C20 Slot: 5
	public void Dispose() { }

	// RVA: 0x1573E00 Offset: 0x1572400 VA: 0x181573E00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1573D60 Offset: 0x1572360 VA: 0x181573D60 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x1573EF0 Offset: 0x15724F0 VA: 0x181573EF0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Threading
public class CancellationTokenSource : IDisposable // TypeDefIndex: 523
{
	// Fields
	internal static readonly CancellationTokenSource s_canceledSource; // 0x0
	internal static readonly CancellationTokenSource s_neverCanceledSource; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent _kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; // 0x18
	private int _state; // 0x20
	private int _threadIDExecutingCallbacks; // 0x24
	private bool _disposed; // 0x28
	private CancellationCallbackInfo _executingCallback; // 0x30
	private Timer _timer; // 0x38
	private static readonly TimerCallback s_timerCallback; // 0x18

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x15756B0 Offset: 0x1573CB0 VA: 0x1815756B0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1575690 Offset: 0x1573C90 VA: 0x181575690
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	internal bool get_IsDisposed() { }

	// RVA: 0x15756D0 Offset: 0x1573CD0 VA: 0x1815756D0
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x1575750 Offset: 0x1573D50 VA: 0x181575750
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x15756F0 Offset: 0x1573CF0 VA: 0x1815756F0
	public CancellationToken get_Token() { }

	// RVA: 0x148E600 Offset: 0x148CC00 VA: 0x18148E600
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x1575650 Offset: 0x1573C50 VA: 0x181575650
	public void .ctor() { }

	// RVA: 0x1574250 Offset: 0x1572850 VA: 0x181574250
	public void Cancel() { }

	// RVA: 0x15741F0 Offset: 0x15727F0 VA: 0x1815741F0
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x1574030 Offset: 0x1572630 VA: 0x181574030
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x15752D0 Offset: 0x15738D0 VA: 0x1815752D0
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x1574830 Offset: 0x1572E30 VA: 0x181574830 Slot: 4
	public void Dispose() { }

	// RVA: 0x1574890 Offset: 0x1572E90 VA: 0x181574890 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1575220 Offset: 0x1573820 VA: 0x181575220
	internal void ThrowIfDisposed() { }

	// RVA: 0x1575270 Offset: 0x1573870 VA: 0x181575270
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1574DE0 Offset: 0x15733E0 VA: 0x181574DE0
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x1575180 Offset: 0x1573780 VA: 0x181575180
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x1574940 Offset: 0x1572F40 VA: 0x181574940
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x15742B0 Offset: 0x15728B0 VA: 0x1815742B0
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x1574330 Offset: 0x1572930 VA: 0x181574330
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x15743F0 Offset: 0x15729F0 VA: 0x1815743F0
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1574760 Offset: 0x1572D60 VA: 0x181574760
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	// RVA: 0x15753C0 Offset: 0x15739C0 VA: 0x1815753C0
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x1575490 Offset: 0x1573A90 VA: 0x181575490
	private static void .cctor() { }
}

// Namespace: System.Threading
internal struct CancellationCallbackCoreWorkArguments // TypeDefIndex: 524
{
	// Fields
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment; // 0x0
	internal int _currArrayIndex; // 0x8

	// Methods

	// RVA: 0x970F90 Offset: 0x96F590 VA: 0x180970F90
	public void .ctor(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex) { }
}

// Namespace: System.Threading
internal class CancellationCallbackInfo // TypeDefIndex: 526
{
	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly ExecutionContext TargetExecutionContext; // 0x20
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x28
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x1573BA0 Offset: 0x15721A0 VA: 0x181573BA0
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x1573790 Offset: 0x1571D90 VA: 0x181573790
	internal void ExecuteCallback() { }

	// RVA: 0x1573B10 Offset: 0x1572110 VA: 0x181573B10
	private static void ExecutionContextCallback(object obj) { }
}

// Namespace: System.Threading
internal class SparselyPopulatedArray<T> // TypeDefIndex: 527
{
	// Fields
	private readonly SparselyPopulatedArrayFragment<T> _head; // 0x0
	private SparselyPopulatedArrayFragment<T> _tail; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Tail { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9962B0 Offset: 0x9948B0 VA: 0x1809962B0
	|-SparselyPopulatedArray<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Tail() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x996360 Offset: 0x994960 VA: 0x180996360
	|-SparselyPopulatedArray<object>.get_Tail
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayAddInfo<T> Add(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x996000 Offset: 0x994600 VA: 0x180996000
	|-SparselyPopulatedArray<object>.Add
	*/
}

// Namespace: System.Threading
internal struct SparselyPopulatedArrayAddInfo<T> // TypeDefIndex: 528
{
	// Fields
	private SparselyPopulatedArrayFragment<T> _source; // 0x0
	private int _index; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Source { get; }
	internal int Index { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SparselyPopulatedArrayFragment<T> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x970F90 Offset: 0x96F590 VA: 0x180970F90
	|-SparselyPopulatedArrayAddInfo<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-SparselyPopulatedArrayAddInfo<object>.get_Source
	*/

	// RVA: -1 Offset: -1
	internal int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	|-SparselyPopulatedArrayAddInfo<object>.get_Index
	*/
}

// Namespace: System.Threading
[DefaultMember("Item")]
internal class SparselyPopulatedArrayFragment<T> // TypeDefIndex: 529
{
	// Fields
	internal readonly T[] _elements; // 0x0
	internal int _freeCount; // 0x0
	internal SparselyPopulatedArrayFragment<T> _next; // 0x0
	internal SparselyPopulatedArrayFragment<T> _prev; // 0x0

	// Properties
	internal T Item { get; }
	internal int Length { get; }
	internal SparselyPopulatedArrayFragment<T> Prev { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x995EE0 Offset: 0x9944E0 VA: 0x180995EE0
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int size, SparselyPopulatedArrayFragment<T> prev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x995F00 Offset: 0x994500 VA: 0x180995F00
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x995FA0 Offset: 0x9945A0 VA: 0x180995FA0
	|-SparselyPopulatedArrayFragment<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	|-SparselyPopulatedArrayFragment<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x995FE0 Offset: 0x9945E0 VA: 0x180995FE0
	|-SparselyPopulatedArrayFragment<object>.get_Prev
	*/

	// RVA: -1 Offset: -1
	internal T SafeAtomicRemove(int index, T expectedElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x995E60 Offset: 0x994460 VA: 0x180995E60
	|-SparselyPopulatedArrayFragment<object>.SafeAtomicRemove
	*/
}

// Namespace: System.Threading
[ReflectionBlocked]
public struct LockHolder : IDisposable // TypeDefIndex: 530
{
	// Fields
	private Lock _lock; // 0x0

	// Methods

	// RVA: 0x1580250 Offset: 0x157E850 VA: 0x181580250
	public static LockHolder Hold(Lock l) { }

	// RVA: 0x1580230 Offset: 0x157E830 VA: 0x181580230 Slot: 4
	public void Dispose() { }
}

// Namespace: System.Threading
public class Lock // TypeDefIndex: 531
{
	// Fields
	private object _lock; // 0x10

	// Methods

	// RVA: 0x15803C0 Offset: 0x157E9C0 VA: 0x1815803C0
	public void Acquire() { }

	// RVA: 0x15803D0 Offset: 0x157E9D0 VA: 0x1815803D0
	public void Release() { }

	// RVA: 0x15803E0 Offset: 0x157E9E0 VA: 0x1815803E0
	public void .ctor() { }
}

// Namespace: System.Threading
[ComVisible(False)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
public class SemaphoreSlim : IDisposable // TypeDefIndex: 534
{
	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private static readonly Task<bool> s_falseTask; // 0x8
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x10

	// Methods

	// RVA: 0x1584650 Offset: 0x1582C50 VA: 0x181584650
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x15844D0 Offset: 0x1582AD0 VA: 0x1815844D0
	public void Wait() { }

	// RVA: 0x1583D80 Offset: 0x1582380 VA: 0x181583D80
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583C60 Offset: 0x1582260 VA: 0x181583C60
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x1583550 Offset: 0x1581B50 VA: 0x181583550
	public Task WaitAsync() { }

	// RVA: 0x1583560 Offset: 0x1581B60 VA: 0x181583560
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1582E70 Offset: 0x1581470 VA: 0x181582E70
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x1583460 Offset: 0x1581A60 VA: 0x181583460
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachine(typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32))]
	// RVA: 0x1583B10 Offset: 0x1582110 VA: 0x181583B10
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583450 Offset: 0x1581A50 VA: 0x181583450
	public int Release() { }

	// RVA: 0x1583080 Offset: 0x1581680 VA: 0x181583080
	public int Release(int releaseCount) { }

	// RVA: 0x1583070 Offset: 0x1581670 VA: 0x181583070
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1582F50 Offset: 0x1581550 VA: 0x181582F50 Slot: 4
	public void Dispose() { }

	// RVA: 0x1582FB0 Offset: 0x15815B0 VA: 0x181582FB0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1582BC0 Offset: 0x15811C0 VA: 0x181582BC0
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x1582DE0 Offset: 0x15813E0 VA: 0x181582DE0
	private void CheckDispose() { }

	// RVA: 0x1583060 Offset: 0x1581660 VA: 0x181583060
	private static string GetResourceString(string str) { }

	// RVA: 0x15844E0 Offset: 0x1582AE0 VA: 0x1815844E0
	private static void .cctor() { }
}

// Namespace: System.Threading
[ComVisible(False)]
[DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
[DebuggerDisplay("IsHeld = {IsHeld}")]
public struct SpinLock // TypeDefIndex: 536
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x1585350 Offset: 0x1583950 VA: 0x181585350
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x1584FC0 Offset: 0x15835C0 VA: 0x181584FC0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x1585240 Offset: 0x1583840 VA: 0x181585240
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1584A50 Offset: 0x1583050 VA: 0x181584A50
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1584EF0 Offset: 0x15834F0 VA: 0x181584EF0
	private void DecrementWaiters() { }

	// RVA: 0x1584820 Offset: 0x1582E20 VA: 0x181584820
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15851B0 Offset: 0x15837B0 VA: 0x1815851B0
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x1585070 Offset: 0x1583670 VA: 0x181585070
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1585390 Offset: 0x1583990 VA: 0x181585390
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1585470 Offset: 0x1583A70 VA: 0x181585470
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x1585310 Offset: 0x1583910 VA: 0x181585310
	private static void .cctor() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public class EventWaitHandle : WaitHandle // TypeDefIndex: 537
{
	// Methods

	// RVA: 0x157E360 Offset: 0x157C960 VA: 0x18157E360
	public void .ctor(bool initialState, EventResetMode mode) { }

	// RVA: 0x157E380 Offset: 0x157C980 VA: 0x18157E380
	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	// RVA: 0x157E2A0 Offset: 0x157C8A0 VA: 0x18157E2A0
	public bool Reset() { }

	// RVA: 0x157E300 Offset: 0x157C900 VA: 0x18157E300
	public bool Set() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class ContextCallback : MulticastDelegate // TypeDefIndex: 538
{
	// Methods

	// RVA: 0xC9DA00 Offset: 0xC9C000 VA: 0x180C9DA00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
internal struct ExecutionContextSwitcher // TypeDefIndex: 539
{
	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[ReliabilityContract(3, 1)]
	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x157E6A0 Offset: 0x157CCA0 VA: 0x18157E6A0
	internal bool UndoNoThrow() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x157E6C0 Offset: 0x157CCC0 VA: 0x18157E6C0
	internal void Undo() { }
}

// Namespace: System.Threading
[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 543
{
	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0
	internal static readonly ExecutionContext Default; // 0x8

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x157FD00 Offset: 0x157E300 VA: 0x18157FD00
	internal bool get_isNewCapture() { }

	// RVA: 0x157FD30 Offset: 0x157E330 VA: 0x18157FD30
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x157FCF0 Offset: 0x157E2F0 VA: 0x18157FCF0
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x157FD10 Offset: 0x157E310 VA: 0x18157FD10
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x157FC70 Offset: 0x157E270 VA: 0x18157FC70
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x157FA90 Offset: 0x157E090 VA: 0x18157FA90
	internal void .ctor(bool isPreAllocatedDefault) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x157EFD0 Offset: 0x157D5D0 VA: 0x18157EFD0
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x157FC80 Offset: 0x157E280 VA: 0x18157FC80
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x157FC00 Offset: 0x157E200 VA: 0x18157FC00
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00 Slot: 4
	public void Dispose() { }

	// RVA: 0x157F700 Offset: 0x157DD00 VA: 0x18157F700
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowed]
	// RVA: 0x157F670 Offset: 0x157DC70 VA: 0x18157F670
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x157F5F0 Offset: 0x157DBF0 VA: 0x18157F5F0
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x157F390 Offset: 0x157D990 VA: 0x18157F390
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x157ECF0 Offset: 0x157D2F0 VA: 0x18157ECF0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x157ED90 Offset: 0x157D390 VA: 0x18157ED90
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x157F860 Offset: 0x157DE60 VA: 0x18157F860
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x157E9C0 Offset: 0x157CFC0 VA: 0x18157E9C0
	public ExecutionContext CreateCopy() { }

	// RVA: 0x157EB50 Offset: 0x157D150 VA: 0x18157EB50
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x157EF90 Offset: 0x157D590 VA: 0x18157EF90
	public static bool IsFlowSuppressed() { }

	// RVA: 0x157E970 Offset: 0x157CF70 VA: 0x18157E970
	public static ExecutionContext Capture() { }

	[FriendAccessAllowed]
	// RVA: 0x157EE00 Offset: 0x157D400 VA: 0x18157EE00
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x157E770 Offset: 0x157CD70 VA: 0x18157E770
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x157EE50 Offset: 0x157D450 VA: 0x18157EE50 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x157FAC0 Offset: 0x157E0C0 VA: 0x18157FAC0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x157EF40 Offset: 0x157D540 VA: 0x18157EF40
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x157F9D0 Offset: 0x157DFD0 VA: 0x18157F9D0
	private static void .cctor() { }
}

// Namespace: System.Threading
public static class Monitor // TypeDefIndex: 544
{
	// Methods

	// RVA: 0x15820F0 Offset: 0x15806F0 VA: 0x1815820F0
	public static void Enter(object obj) { }

	// RVA: 0x1582070 Offset: 0x1580670 VA: 0x181582070
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x15825A0 Offset: 0x1580BA0 VA: 0x1815825A0
	private static void ThrowLockTakenException() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1582100 Offset: 0x1580700 VA: 0x181582100
	public static void Exit(object obj) { }

	// RVA: 0x1582610 Offset: 0x1580C10 VA: 0x181582610
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x1582690 Offset: 0x1580C90 VA: 0x181582690
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1582690 Offset: 0x1580C90 VA: 0x181582690
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x15823C0 Offset: 0x15809C0 VA: 0x1815823C0
	public static void Pulse(object obj) { }

	// RVA: 0x1582300 Offset: 0x1580900 VA: 0x181582300
	public static void PulseAll(object obj) { }

	// RVA: 0x1582130 Offset: 0x1580730 VA: 0x181582130
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x1582120 Offset: 0x1580720 VA: 0x181582120
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x15821C0 Offset: 0x15807C0 VA: 0x1815821C0
	private static void ObjPulse(object obj) { }

	// RVA: 0x1582110 Offset: 0x1580710 VA: 0x181582110
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x1582150 Offset: 0x1580750 VA: 0x181582150
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x1582140 Offset: 0x1580740 VA: 0x181582140
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x1582230 Offset: 0x1580830 VA: 0x181582230
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x15827B0 Offset: 0x1580DB0 VA: 0x1815827B0
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1582480 Offset: 0x1580A80 VA: 0x181582480
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x1582530 Offset: 0x1580B30 VA: 0x181582530
	private static void ReliableEnter(object obj, ref bool lockTaken) { }
}

// Namespace: System.Threading
[Flags]
internal enum SynchronizationContextProperties // TypeDefIndex: 545
{
	// Fields
	public int value__; // 0x0
	public const SynchronizationContextProperties None = 0;
	public const SynchronizationContextProperties RequireWaitNotification = 1;
}

// Namespace: System.Threading
public class SynchronizationContext // TypeDefIndex: 546
{
	// Fields
	private SynchronizationContextProperties _props; // 0x10

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }
	internal static SynchronizationContext CurrentExplicit { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1594460 Offset: 0x1592A60 VA: 0x181594460
	public bool IsWaitNotificationRequired() { }

	// RVA: 0x15944F0 Offset: 0x1592AF0 VA: 0x1815944F0 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1594470 Offset: 0x1592A70 VA: 0x181594470 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public virtual void OperationCompleted() { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	// RVA: 0x15946D0 Offset: 0x1592CD0 VA: 0x1815946D0 Slot: 8
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	[ReliabilityContract(3, 1)]
	// RVA: 0x1594630 Offset: 0x1592C30 VA: 0x181594630
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	// RVA: 0x1594520 Offset: 0x1592B20 VA: 0x181594520
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x1594850 Offset: 0x1592E50 VA: 0x181594850
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowed]
	// RVA: 0x15947C0 Offset: 0x1592DC0 VA: 0x1815947C0
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x15942A0 Offset: 0x15928A0 VA: 0x1815942A0
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x1594250 Offset: 0x1592850 VA: 0x181594250 Slot: 9
	public virtual SynchronizationContext CreateCopy() { }

	// RVA: 0x15947B0 Offset: 0x1592DB0 VA: 0x1815947B0
	internal static SynchronizationContext get_CurrentExplicit() { }
}

// Namespace: System.Threading
internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 550
{
	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x13E9320 Offset: 0x13E7920 VA: 0x1813E9320
	private void .ctor(object osContext) { }

	// RVA: 0x1591440 Offset: 0x158FA40 VA: 0x181591440
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x15913C0 Offset: 0x158F9C0 VA: 0x1815913C0 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x15918F0 Offset: 0x158FEF0 VA: 0x1815918F0 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1591730 Offset: 0x158FD30 VA: 0x181591730 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
	// RVA: 0x15915D0 Offset: 0x158FBD0 VA: 0x1815915D0
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x1591430 Offset: 0x158FA30 VA: 0x181591430
	private static object GetOSContext() { }

	// RVA: 0x1591720 Offset: 0x158FD20 VA: 0x181591720
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x1591930 Offset: 0x158FF30 VA: 0x181591930
	private static void .cctor() { }
}

// Namespace: System.Threading
internal class ThreadHelper // TypeDefIndex: 551
{
	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(Delegate start) { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x159F140 Offset: 0x159D740 VA: 0x18159F140
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x159F260 Offset: 0x159D860 VA: 0x18159F260
	internal void ThreadStart(object obj) { }

	// RVA: 0x159F380 Offset: 0x159D980 VA: 0x18159F380
	internal void ThreadStart() { }

	// RVA: 0x159F480 Offset: 0x159DA80 VA: 0x18159F480
	private static void .cctor() { }
}

// Namespace: System.Threading
public sealed class Thread : CriticalFinalizerObject // TypeDefIndex: 552
{
	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	[ThreadStatic]
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x28
	private ExecutionContext m_ExecutionContext; // 0x30
	private bool m_ExecutionContextBelongsToOuterScope; // 0x38
	private IPrincipal principal; // 0x40
	private int principal_version; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public CultureInfo CurrentUICulture { get; }
	public CultureInfo CurrentCulture { get; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsAlive { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x15A2360 Offset: 0x15A0960 VA: 0x1815A2360
	public void .ctor(ThreadStart start) { }

	// RVA: 0x15A23E0 Offset: 0x15A09E0 VA: 0x1815A23E0
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x15A2260 Offset: 0x15A0860 VA: 0x1815A2260
	public void .ctor(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x15A1F60 Offset: 0x15A0560 VA: 0x1815A1F60
	public void Start() { }

	// RVA: 0x15A20D0 Offset: 0x15A06D0 VA: 0x1815A20D0
	public void Start(object parameter) { }

	// RVA: 0x15A1F80 Offset: 0x15A0580 VA: 0x1815A1F80
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15A1970 Offset: 0x159FF70 VA: 0x1815A1970
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x15A25A0 Offset: 0x15A0BA0 VA: 0x1815A25A0
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x15A2650 Offset: 0x15A0C50 VA: 0x1815A2650
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15A19D0 Offset: 0x159FFD0 VA: 0x1815A19D0
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15A1B40 Offset: 0x15A0140 VA: 0x1815A1B40
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15A1B40 Offset: 0x15A0140 VA: 0x1815A1B40
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x15A1B20 Offset: 0x15A0120 VA: 0x1815A1B20
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x15A1B30 Offset: 0x15A0130 VA: 0x1815A1B30
	public void Join() { }

	// RVA: 0x15A1E10 Offset: 0x15A0410 VA: 0x1815A1E10
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x15A1E20 Offset: 0x15A0420 VA: 0x1815A1E20
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x15A2250 Offset: 0x15A0850 VA: 0x1815A2250
	private static bool YieldInternal() { }

	// RVA: 0x15A2250 Offset: 0x15A0850 VA: 0x1815A2250
	public static bool Yield() { }

	// RVA: 0x15A1BE0 Offset: 0x15A01E0 VA: 0x1815A1BE0
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x15A2560 Offset: 0x15A0B60 VA: 0x1815A2560
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x15A18C0 Offset: 0x159FEC0 VA: 0x1815A18C0
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x15A2460 Offset: 0x15A0A60 VA: 0x1815A2460
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x15A17E0 Offset: 0x159FDE0 VA: 0x1815A17E0
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x1590820 Offset: 0x158EE20 VA: 0x181590820
	public static void MemoryBarrier() { }

	// RVA: 0x15A1730 Offset: 0x159FD30 VA: 0x1815A1730
	private void ConstructInternalThread() { }

	// RVA: 0x15A25B0 Offset: 0x15A0BB0 VA: 0x1815A25B0
	private InternalThread get_Internal() { }

	// RVA: 0x13C17C0 Offset: 0x13BFDC0 VA: 0x1813C17C0
	public static Context get_CurrentContext() { }

	// RVA: 0x15A1880 Offset: 0x159FE80 VA: 0x1815A1880
	private static void GetCurrentThread_icall(ref Thread thread) { }

	// RVA: 0x15A1890 Offset: 0x159FE90 VA: 0x1815A1890
	private static Thread GetCurrentThread() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15A2510 Offset: 0x15A0B10 VA: 0x1815A2510
	public static Thread get_CurrentThread() { }

	// RVA: 0x15A24A0 Offset: 0x15A0AA0 VA: 0x1815A24A0
	internal static int get_CurrentThreadId() { }

	// RVA: 0x15A1960 Offset: 0x159FF60 VA: 0x1815A1960
	public static int GetDomainID() { }

	// RVA: 0x15A21C0 Offset: 0x15A07C0 VA: 0x1815A21C0
	private bool Thread_internal(MulticastDelegate start) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15921E0 Offset: 0x15907E0 VA: 0x1815921E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15A2610 Offset: 0x15A0C10 VA: 0x1815A2610
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x15A2610 Offset: 0x15A0C10 VA: 0x1815A2610
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x15A25E0 Offset: 0x15A0BE0 VA: 0x1815A25E0
	public bool get_IsAlive() { }

	// RVA: 0x15A2660 Offset: 0x15A0C60 VA: 0x1815A2660
	public void set_IsBackground(bool value) { }

	// RVA: 0x15A1B80 Offset: 0x15A0180 VA: 0x1815A1B80
	private static void SetName_icall(InternalThread thread, char* name, int nameLength) { }

	// RVA: 0x15A1B90 Offset: 0x15A0190 VA: 0x1815A1B90
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x15A2730 Offset: 0x15A0D30 VA: 0x1815A2730
	public void set_Name(string value) { }

	// RVA: 0x144A4C0 Offset: 0x1448AC0 VA: 0x18144A4C0
	private static void SpinWait_nop() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15A1EB0 Offset: 0x15A04B0 VA: 0x1815A1EB0
	public static void SpinWait(int iterations) { }

	// RVA: 0x15A1EE0 Offset: 0x15A04E0 VA: 0x1815A1EE0
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x15A1E00 Offset: 0x15A0400 VA: 0x1815A1E00
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x15A1720 Offset: 0x159FD20 VA: 0x1815A1720
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x15A1B10 Offset: 0x15A0110 VA: 0x1815A1B10
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x15A21B0 Offset: 0x15A07B0 VA: 0x1815A21B0
	private static int SystemMaxStackStize() { }

	// RVA: 0x15A1A70 Offset: 0x15A0070 VA: 0x1815A1A70
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x15A1DB0 Offset: 0x15A03B0 VA: 0x1815A1DB0
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15A19A0 Offset: 0x159FFA0 VA: 0x1815A19A0
	public int get_ManagedThreadId() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15A1680 Offset: 0x159FC80 VA: 0x1815A1680
	public static void BeginCriticalRegion() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15A1740 Offset: 0x159FD40 VA: 0x1815A1740
	public static void EndCriticalRegion() { }

	[ComVisible(False)]
	// RVA: 0x15A19A0 Offset: 0x159FFA0 VA: 0x1815A19A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15A21D0 Offset: 0x15A07D0 VA: 0x1815A21D0
	private ThreadState ValidateThreadState() { }
}

// Namespace: System.Threading
[Serializable]
internal enum StackCrawlMark // TypeDefIndex: 553
{
	// Fields
	public int value__; // 0x0
	public const StackCrawlMark LookForMe = 0;
	public const StackCrawlMark LookForMyCaller = 1;
	public const StackCrawlMark LookForMyCallersCaller = 2;
	public const StackCrawlMark LookForThread = 3;
}

// Namespace: System.Threading
[ComVisible(True)]
[Serializable]
public sealed class ThreadAbortException : SystemException // TypeDefIndex: 554
{
	// Methods

	// RVA: 0x159F0D0 Offset: 0x159D6D0 VA: 0x18159F0D0
	private void .ctor() { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
[ComVisible(True)]
[Serializable]
public class ThreadInterruptedException : SystemException // TypeDefIndex: 555
{
	// Methods

	// RVA: 0x159F510 Offset: 0x159DB10 VA: 0x18159F510
	public void .ctor() { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
internal interface IThreadPoolWorkItem // TypeDefIndex: 556
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ExecuteWorkItem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarkAborted(ThreadAbortException tae);
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class WaitCallback : MulticastDelegate // TypeDefIndex: 557
{
	// Methods

	// RVA: 0xC9DA00 Offset: 0xC9C000 VA: 0x180C9DA00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class WaitOrTimerCallback : MulticastDelegate // TypeDefIndex: 558
{
	// Methods

	// RVA: 0xF26EF0 Offset: 0xF254F0 VA: 0x180F26EF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object state, bool timedOut) { }
}

// Namespace: System.Threading
internal static class ThreadPoolGlobals // TypeDefIndex: 559
{
	// Fields
	public static int processorCount; // 0x0
	public static bool vmTpInitialized; // 0x4
	public static bool enableWorkerTracking; // 0x5
	public static readonly ThreadPoolWorkQueue workQueue; // 0x8

	// Methods

	// RVA: 0x159F580 Offset: 0x159DB80 VA: 0x18159F580
	private static void .cctor() { }
}

// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 563
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x15A0C00 Offset: 0x159F200 VA: 0x1815A0C00
	public void .ctor() { }

	// RVA: 0x15A0980 Offset: 0x159EF80 VA: 0x1815A0980
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x15A0A20 Offset: 0x159F020 VA: 0x1815A0A20
	internal void EnsureThreadRequested() { }

	// RVA: 0x15A0B20 Offset: 0x159F120 VA: 0x1815A0B20
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x15A0750 Offset: 0x159ED50 VA: 0x1815A0750
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x15A0AC0 Offset: 0x159F0C0 VA: 0x1815A0AC0
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x159FF40 Offset: 0x159E540 VA: 0x18159FF40
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x15A02A0 Offset: 0x159E8A0 VA: 0x1815A02A0
	internal static bool Dispatch() { }

	// RVA: 0x15A0B70 Offset: 0x159F170 VA: 0x1815A0B70
	private static void .cctor() { }
}

// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 564
{
	// Fields
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x159FD40 Offset: 0x159E340 VA: 0x18159FD40
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x159FB80 Offset: 0x159E180 VA: 0x18159FB80
	private void CleanUp() { }

	// RVA: 0x159FCB0 Offset: 0x159E2B0 VA: 0x18159FCB0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Threading
internal static class _ThreadPoolWaitCallback // TypeDefIndex: 565
{
	// Methods

	// RVA: 0x15A6750 Offset: 0x15A4D50 VA: 0x1815A6750
	internal static bool PerformWaitCallback() { }
}

// Namespace: System.Threading
internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 566
{
	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x1591F60 Offset: 0x1590560 VA: 0x181591F60
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x1591D70 Offset: 0x1590370 VA: 0x181591D70 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1591E60 Offset: 0x1590460 VA: 0x181591E60
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x1591ED0 Offset: 0x15904D0 VA: 0x181591ED0
	private static void .cctor() { }
}

// Namespace: System.Threading
public static class ThreadPool // TypeDefIndex: 568
{
	// Properties
	internal static bool IsThreadPoolThread { get; }

	// Methods

	// RVA: 0x15A11A0 Offset: 0x159F7A0 VA: 0x1815A11A0
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x15A10E0 Offset: 0x159F6E0 VA: 0x1815A10E0
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { }

	// RVA: 0x15A0F50 Offset: 0x159F550 VA: 0x1815A0F50
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x15A0F20 Offset: 0x159F520 VA: 0x1815A0F20
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x15A0EF0 Offset: 0x159F4F0 VA: 0x1815A0EF0
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x15A15D0 Offset: 0x159FBD0 VA: 0x1815A15D0
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: -1 Offset: -1
	public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C58F0 Offset: 0x7C3EF0 VA: 0x1807C58F0
	|-ThreadPool.QueueUserWorkItem<object>
	|
	|-RVA: 0x7C5730 Offset: 0x7C3D30 VA: 0x1807C5730
	|-ThreadPool.QueueUserWorkItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A0D90 Offset: 0x159F390 VA: 0x1815A0D90
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = True) { }

	// RVA: 0x15A1540 Offset: 0x159FB40 VA: 0x1815A1540
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x15A1450 Offset: 0x159FA50 VA: 0x1815A1450
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x15A1440 Offset: 0x159FA40 VA: 0x1815A1440
	internal static bool RequestWorkerThread() { }

	// RVA: 0x15A0CC0 Offset: 0x159F2C0 VA: 0x1815A0CC0
	private static void EnsureVMInitialized() { }

	// RVA: 0x15A0D70 Offset: 0x159F370 VA: 0x1815A0D70
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0x1447A70 Offset: 0x1446070 VA: 0x181447A70
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x159F6C0 Offset: 0x159DCC0 VA: 0x18159F6C0
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x15A0D80 Offset: 0x159F380 VA: 0x1815A0D80
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0x144A4C0 Offset: 0x1448AC0 VA: 0x18144A4C0
	internal static void NotifyWorkItemQueued() { }

	// RVA: 0x15A0D60 Offset: 0x159F360 VA: 0x1815A0D60
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	// RVA: 0x15A1600 Offset: 0x159FC00 VA: 0x1815A1600
	internal static bool get_IsThreadPoolThread() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 569
{
	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	private const int ERROR_NOT_OWNED_BY_CALLER = 299;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; }

	// Methods

	// RVA: 0x15A54C0 Offset: 0x15A3AC0 VA: 0x1815A54C0
	protected void .ctor() { }

	// RVA: 0x15A4480 Offset: 0x15A2A80 VA: 0x1815A4480
	private void Init() { }

	// RVA: 0x15A5610 Offset: 0x15A3C10 VA: 0x1815A5610 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15A5540 Offset: 0x15A3B40 VA: 0x1815A5540
	public SafeWaitHandle get_SafeWaitHandle() { }

	// RVA: 0x15A4620 Offset: 0x15A2C20 VA: 0x1815A4620
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x15A51A0 Offset: 0x15A37A0 VA: 0x1815A51A0 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x15A5380 Offset: 0x15A3980 VA: 0x1815A5380 Slot: 9
	public virtual bool WaitOne(TimeSpan timeout, bool exitContext) { }

	// RVA: 0x15A5180 Offset: 0x15A3780 VA: 0x1815A5180 Slot: 10
	public virtual bool WaitOne() { }

	// RVA: 0x15A5160 Offset: 0x15A3760 VA: 0x1815A5160 Slot: 11
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0 Slot: 12
	public virtual bool WaitOne(TimeSpan timeout) { }

	// RVA: 0x15A5230 Offset: 0x15A3830 VA: 0x1815A5230
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x15A4500 Offset: 0x15A2B00 VA: 0x1815A4500
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15A4830 Offset: 0x15A2E30 VA: 0x1815A4830
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15A4710 Offset: 0x15A2D10 VA: 0x1815A4710
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x15A46D0 Offset: 0x15A2CD0 VA: 0x1815A46D0
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x15A4670 Offset: 0x15A2C70 VA: 0x1815A4670
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x15A4370 Offset: 0x15A2970 VA: 0x1815A4370 Slot: 13
	public virtual void Close() { }

	// RVA: 0x15A4430 Offset: 0x15A2A30 VA: 0x1815A4430 Slot: 14
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x15A43D0 Offset: 0x15A29D0 VA: 0x1815A43D0 Slot: 6
	public void Dispose() { }

	// RVA: 0x15A4F60 Offset: 0x15A3560 VA: 0x1815A4F60
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x15A4BE0 Offset: 0x15A31E0 VA: 0x1815A4BE0
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x15A5470 Offset: 0x15A3A70 VA: 0x1815A5470
	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x15A5480 Offset: 0x15A3A80 VA: 0x1815A5480
	private static void .cctor() { }
}

// Namespace: System.Threading
public static class Interlocked // TypeDefIndex: 570
{
	// Methods

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590700 Offset: 0x158ED00 VA: 0x181590700
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15906E0 Offset: 0x158ECE0 VA: 0x1815906E0
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15906D0 Offset: 0x158ECD0 VA: 0x1815906D0
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590710 Offset: 0x158ED10 VA: 0x181590710
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x1590750 Offset: 0x158ED50 VA: 0x181590750
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590770 Offset: 0x158ED70 VA: 0x181590770
	public static int Decrement(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590810 Offset: 0x158EE10 VA: 0x181590810
	public static int Increment(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590800 Offset: 0x158EE00 VA: 0x181590800
	public static long Increment(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15907A0 Offset: 0x158EDA0 VA: 0x1815907A0
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590780 Offset: 0x158ED80 VA: 0x181590780
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15907B0 Offset: 0x158EDB0 VA: 0x1815907B0
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x15907E0 Offset: 0x158EDE0 VA: 0x1815907E0
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x15906F0 Offset: 0x158ECF0 VA: 0x1815906F0
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15906F0 Offset: 0x158ECF0 VA: 0x1815906F0
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x1590760 Offset: 0x158ED60 VA: 0x181590760
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x1590790 Offset: 0x158ED90 VA: 0x181590790
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590790 Offset: 0x158ED90 VA: 0x181590790
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x15907F0 Offset: 0x158EDF0 VA: 0x1815907F0
	public static double Exchange(ref double location1, double value) { }

	[ComVisible(False)]
	[ReliabilityContract(3, 2)]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x1590830 Offset: 0x158EE30 VA: 0x181590830
	public static long Read(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15906C0 Offset: 0x158ECC0 VA: 0x1815906C0
	public static int Add(ref int location1, int value) { }

	// RVA: 0x1590820 Offset: 0x158EE20 VA: 0x181590820
	public static void MemoryBarrier() { }
}

// Namespace: System.Threading
internal class LockQueue // TypeDefIndex: 571
{
	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x1590F80 Offset: 0x158F580 VA: 0x181590F80
	public bool Wait(int timeout) { }

	// RVA: 0x15910D0 Offset: 0x158F6D0 VA: 0x1815910D0
	public bool get_IsEmpty() { }

	// RVA: 0x1590EF0 Offset: 0x158F4F0 VA: 0x181590EF0
	public void Pulse() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class Mutex : WaitHandle // TypeDefIndex: 572
{}

// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 573
{
	// Methods

	// RVA: 0x1591190 Offset: 0x158F790 VA: 0x181591190
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x1591180 Offset: 0x158F780 VA: 0x181591180
	private static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode) { }

	// RVA: 0x15912F0 Offset: 0x158F8F0 VA: 0x1815912F0
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x15912E0 Offset: 0x158F8E0 VA: 0x1815912E0
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x1591210 Offset: 0x158F810 VA: 0x181591210
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1591200 Offset: 0x158F800 VA: 0x181591200
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x1591170 Offset: 0x158F770 VA: 0x181591170
	public static void CloseEvent_internal(IntPtr handle) { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 574
{
	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x15923E0 Offset: 0x15909E0 VA: 0x1815923E0
	public void .ctor() { }

	// RVA: 0x15921E0 Offset: 0x15907E0 VA: 0x1815921E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15921D0 Offset: 0x15907D0 VA: 0x1815921D0
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x1592040 Offset: 0x1590640 VA: 0x181592040
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1592250 Offset: 0x1590850 VA: 0x181592250
	public void ReleaseWriterLock() { }

	// RVA: 0x1592380 Offset: 0x1590980 VA: 0x181592380
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x1592220 Offset: 0x1590820 VA: 0x181592220
	private bool HasWriterLock() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 575
{
	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x1592C70 Offset: 0x1591270 VA: 0x181592C70
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1592690 Offset: 0x1590C90 VA: 0x181592690
	internal void Wait(object state) { }

	// RVA: 0x15924C0 Offset: 0x1590AC0 VA: 0x1815924C0
	private void DoCallBack(object timedOut) { }

	[ComVisible(True)]
	// RVA: 0x15925A0 Offset: 0x1590BA0 VA: 0x1815925A0
	public bool Unregister(WaitHandle waitObject) { }
}

// Namespace: System.Threading
internal sealed class InternalThread : CriticalFinalizerObject // TypeDefIndex: 576
{
	// Fields
	private int lock_thread_id; // 0x10
	private IntPtr handle; // 0x18
	private IntPtr native_handle; // 0x20
	private IntPtr name_chars; // 0x28
	private int name_free; // 0x30
	private int name_length; // 0x34
	private ThreadState state; // 0x38
	private object abort_exc; // 0x40
	private int abort_state_handle; // 0x48
	internal long thread_id; // 0x50
	private IntPtr debugger_thread; // 0x58
	private UIntPtr static_data; // 0x60
	private IntPtr runtime_thread_info; // 0x68
	private object current_appcontext; // 0x70
	private object root_domain_thread; // 0x78
	internal byte[] _serialized_principal; // 0x80
	internal int _serialized_principal_version; // 0x88
	private IntPtr appdomain_refs; // 0x90
	private int interruption_requested; // 0x98
	private IntPtr longlived; // 0xA0
	internal bool threadpool_thread; // 0xA8
	private bool thread_interrupt_requested; // 0xA9
	internal int stack_size; // 0xAC
	internal byte apartment_state; // 0xB0
	internal int critical_region_level; // 0xB4
	internal int managed_id; // 0xB8
	private int small_id; // 0xBC
	private IntPtr manage_callback; // 0xC0
	private IntPtr flags; // 0xC8
	private IntPtr thread_pinning_ref; // 0xD0
	private IntPtr abort_protected_block_count; // 0xD8
	private int priority; // 0xE0
	private IntPtr owned_mutex; // 0xE8
	private IntPtr suspended_event; // 0xF0
	private int self_suspended; // 0xF8
	private IntPtr thread_state; // 0x100
	private IntPtr netcore0; // 0x108
	private IntPtr netcore1; // 0x110
	private IntPtr netcore2; // 0x118
	private IntPtr last; // 0x120

	// Methods

	// RVA: 0x1590E90 Offset: 0x158F490 VA: 0x181590E90
	private void Thread_free_internal() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1590E30 Offset: 0x158F430 VA: 0x181590E30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1590EA0 Offset: 0x158F4A0 VA: 0x181590EA0
	public void .ctor() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 579
{
	// Fields
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private bool is_dead; // 0x41
	private bool is_added; // 0x42

	// Properties
	private static Timer.Scheduler scheduler { get; }

	// Methods

	// RVA: 0x15A2F20 Offset: 0x15A1520 VA: 0x1815A2F20
	private static Timer.Scheduler get_scheduler() { }

	// RVA: 0x15A2D20 Offset: 0x15A1320 VA: 0x1815A2D20
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x15A2DF0 Offset: 0x15A13F0 VA: 0x1815A2DF0
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x15A2C60 Offset: 0x15A1260 VA: 0x1815A2C60
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x15A2B60 Offset: 0x15A1160 VA: 0x1815A2B60
	public bool Change(int dueTime, int period) { }

	// RVA: 0x15A2B80 Offset: 0x15A1180 VA: 0x1815A2B80
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x15A2C10 Offset: 0x15A1210 VA: 0x1815A2C10 Slot: 6
	public void Dispose() { }

	// RVA: 0x15A28F0 Offset: 0x15A0EF0 VA: 0x1815A28F0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x15A2C50 Offset: 0x15A1250 VA: 0x1815A2C50
	private static long GetTimeMonotonic() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class TimerCallback : MulticastDelegate // TypeDefIndex: 580
{
	// Methods

	// RVA: 0xC9DA00 Offset: 0xC9C000 VA: 0x180C9DA00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
public static class Volatile // TypeDefIndex: 584
{
	// Methods

	[Intrinsic]
	// RVA: 0x15A42F0 Offset: 0x15A28F0 VA: 0x1815A42F0
	public static bool Read(ref bool location) { }

	[Intrinsic]
	// RVA: 0x15A4340 Offset: 0x15A2940 VA: 0x1815A4340
	public static void Write(ref bool location, bool value) { }

	[Intrinsic]
	// RVA: 0x15A42D0 Offset: 0x15A28D0 VA: 0x1815A42D0
	public static int Read(ref int location) { }

	[Intrinsic]
	// RVA: 0x15A4310 Offset: 0x15A2910 VA: 0x1815A4310
	public static void Write(ref int location, int value) { }

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x813390 Offset: 0x811990 VA: 0x180813390
	|-Volatile.Read<object>
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8133B0 Offset: 0x8119B0 VA: 0x1808133B0
	|-Volatile.Write<object>
	*/
}

// Namespace: System.Threading
public enum LockRecursionPolicy // TypeDefIndex: 11341
{
	// Fields
	public int value__; // 0x0
	public const LockRecursionPolicy NoRecursion = 0;
	public const LockRecursionPolicy SupportsRecursion = 1;
}

// Namespace: System.Threading
internal class ReaderWriterCount // TypeDefIndex: 11342
{
	// Fields
	public long lockID; // 0x10
	public int readercount; // 0x18
	public int writercount; // 0x1C
	public int upgradecount; // 0x20
	public ReaderWriterCount next; // 0x28

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Threading
public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 11344
{
	// Fields
	private bool fIsReentrant; // 0x10
	private int myLock; // 0x14
	private const int LockSpinCycles = 20;
	private const int LockSpinCount = 10;
	private const int LockSleep0Count = 5;
	private uint numWriteWaiters; // 0x18
	private uint numReadWaiters; // 0x1C
	private uint numWriteUpgradeWaiters; // 0x20
	private uint numUpgradeWaiters; // 0x24
	private bool fNoWaiters; // 0x28
	private int upgradeLockOwnerId; // 0x2C
	private int writeLockOwnerId; // 0x30
	private EventWaitHandle writeEvent; // 0x38
	private EventWaitHandle readEvent; // 0x40
	private EventWaitHandle upgradeEvent; // 0x48
	private EventWaitHandle waitUpgradeEvent; // 0x50
	private static long s_nextLockID; // 0x0
	private long lockID; // 0x58
	[ThreadStatic]
	private static ReaderWriterCount t_rwc; // 0x80000000
	private bool fUpgradeThreadHoldingRead; // 0x60
	private const int MaxSpinCount = 20;
	private uint owners; // 0x64
	private const uint WRITER_HELD = 2147483648;
	private const uint WAITING_WRITERS = 1073741824;
	private const uint WAITING_UPGRADER = 536870912;
	private const uint MAX_READER = 268435454;
	private const uint READER_MASK = 268435455;
	private bool fDisposed; // 0x68

	// Properties
	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }

	// Methods

	// RVA: 0x1A6B5E0 Offset: 0x1A69BE0 VA: 0x181A6B5E0
	private void InitializeThreadCounts() { }

	// RVA: 0x1A6C810 Offset: 0x1A6AE10 VA: 0x181A6C810
	public void .ctor() { }

	// RVA: 0x1A6C7A0 Offset: 0x1A6ADA0 VA: 0x181A6C7A0
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x1A6B5F0 Offset: 0x1A69BF0 VA: 0x181A6B5F0
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x1A6B630 Offset: 0x1A69C30 VA: 0x181A6B630
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x1A6B4A0 Offset: 0x1A69AA0 VA: 0x181A6B4A0
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x1A6AB60 Offset: 0x1A69160 VA: 0x181A6AB60
	public void EnterReadLock() { }

	// RVA: 0x1A6BB90 Offset: 0x1A6A190 VA: 0x181A6BB90
	public bool TryEnterReadLock(int millisecondsTimeout) { }

	// RVA: 0x1A6BC20 Offset: 0x1A6A220 VA: 0x181A6BC20
	private bool TryEnterReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A6B810 Offset: 0x1A69E10 VA: 0x181A6B810
	private bool TryEnterReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A6ABA0 Offset: 0x1A691A0 VA: 0x181A6ABA0
	public void EnterWriteLock() { }

	// RVA: 0x1A6C5B0 Offset: 0x1A6ABB0 VA: 0x181A6C5B0
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x1A6C5A0 Offset: 0x1A6ABA0 VA: 0x181A6C5A0
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A6C130 Offset: 0x1A6A730 VA: 0x181A6C130
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A6AB80 Offset: 0x1A69180 VA: 0x181A6AB80
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x1A6C0A0 Offset: 0x1A6A6A0 VA: 0x181A6C0A0
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x1A6C090 Offset: 0x1A6A690 VA: 0x181A6C090
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A6BC30 Offset: 0x1A6A230 VA: 0x181A6BC30
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A6ADB0 Offset: 0x1A693B0 VA: 0x181A6ADB0
	public void ExitReadLock() { }

	// RVA: 0x1A6B290 Offset: 0x1A69890 VA: 0x181A6B290
	public void ExitWriteLock() { }

	// RVA: 0x1A6AF90 Offset: 0x1A69590 VA: 0x181A6AF90
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x1A6B660 Offset: 0x1A69C60 VA: 0x181A6B660
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x1A6C640 Offset: 0x1A6AC40 VA: 0x181A6C640
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x1A6ACF0 Offset: 0x1A692F0 VA: 0x181A6ACF0
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x1A6AC60 Offset: 0x1A69260 VA: 0x181A6AC60
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x1A6ABC0 Offset: 0x1A691C0 VA: 0x181A6ABC0
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x1A6B650 Offset: 0x1A69C50 VA: 0x181A6B650
	private bool IsWriterAcquired() { }

	// RVA: 0x1A6B770 Offset: 0x1A69D70 VA: 0x181A6B770
	private void SetWriterAcquired() { }

	// RVA: 0x1A6A700 Offset: 0x1A68D00 VA: 0x181A6A700
	private void ClearWriterAcquired() { }

	// RVA: 0x1A6B780 Offset: 0x1A69D80 VA: 0x181A6B780
	private void SetWritersWaiting() { }

	// RVA: 0x1A6A710 Offset: 0x1A68D10 VA: 0x181A6A710
	private void ClearWritersWaiting() { }

	// RVA: 0x1A6B760 Offset: 0x1A69D60 VA: 0x181A6B760
	private void SetUpgraderWaiting() { }

	// RVA: 0x1A6A6F0 Offset: 0x1A68CF0 VA: 0x181A6A6F0
	private void ClearUpgraderWaiting() { }

	// RVA: 0x1A6B490 Offset: 0x1A69A90 VA: 0x181A6B490
	private uint GetNumReaders() { }

	// RVA: 0x1A6AB20 Offset: 0x1A69120 VA: 0x181A6AB20
	private void EnterMyLock() { }

	// RVA: 0x1A6AA60 Offset: 0x1A69060 VA: 0x181A6AA60
	private void EnterMyLockSpin() { }

	// RVA: 0x1A6AD90 Offset: 0x1A69390 VA: 0x181A6AD90
	private void ExitMyLock() { }

	// RVA: 0x1A6B790 Offset: 0x1A69D90 VA: 0x181A6B790
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x1A6AA50 Offset: 0x1A69050 VA: 0x181A6AA50 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A6A720 Offset: 0x1A68D20 VA: 0x181A6A720
	private void Dispose(bool disposing) { }

	// RVA: 0x1A6C870 Offset: 0x1A6AE70 VA: 0x181A6C870
	public bool get_IsReadLockHeld() { }

	// RVA: 0x1A6C8E0 Offset: 0x1A6AEE0 VA: 0x181A6C8E0
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x1A6C980 Offset: 0x1A6AF80 VA: 0x181A6C980
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x1A6CA20 Offset: 0x1A6B020 VA: 0x181A6CA20
	public int get_RecursiveReadCount() { }

	// RVA: 0x1A6CA90 Offset: 0x1A6B090 VA: 0x181A6CA90
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x1A6CB50 Offset: 0x1A6B150 VA: 0x181A6CB50
	public int get_RecursiveWriteCount() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_WaitingReadCount() { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public int get_WaitingUpgradeCount() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_WaitingWriteCount() { }
}

