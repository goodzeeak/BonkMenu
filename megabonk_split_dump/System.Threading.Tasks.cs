// Namespace: System.Threading.Tasks
[Serializable]
public class TaskCanceledException : OperationCanceledException // TypeDefIndex: 585
{
	// Fields
	private readonly Task _canceledTask; // 0x98

	// Methods

	// RVA: 0x15949A0 Offset: 0x1592FA0 VA: 0x1815949A0
	public void .ctor() { }

	// RVA: 0x1594900 Offset: 0x1592F00 VA: 0x181594900
	public void .ctor(Task task) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading.Tasks
public class TaskCompletionSource<TResult> // TypeDefIndex: 586
{
	// Fields
	private readonly Task<TResult> _task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CDDF0 Offset: 0x9CC3F0 VA: 0x1809CDDF0
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9CE2B0 Offset: 0x9CC8B0 VA: 0x1809CE2B0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x9CE490 Offset: 0x9CCA90 VA: 0x1809CE490
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x9CDD30 Offset: 0x9CC330 VA: 0x1809CDD30
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0x9CE350 Offset: 0x9CC950 VA: 0x1809CE350
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x9CE110 Offset: 0x9CC710 VA: 0x1809CE110
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0x9CE3F0 Offset: 0x9CC9F0 VA: 0x1809CE3F0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CDD10 Offset: 0x9CC310 VA: 0x1809CDD10
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9CDF90 Offset: 0x9CC590 VA: 0x1809CDF90
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x9CE470 Offset: 0x9CCA70 VA: 0x1809CE470
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x9CE3D0 Offset: 0x9CC9D0 VA: 0x1809CE3D0
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0x9CDFB0 Offset: 0x9CC5B0 VA: 0x1809CDFB0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x9CE250 Offset: 0x9CC850 VA: 0x1809CE250
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0x9CDDD0 Offset: 0x9CC3D0 VA: 0x1809CDDD0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CE190 Offset: 0x9CC790 VA: 0x1809CE190
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9CDDB0 Offset: 0x9CC3B0 VA: 0x1809CDDB0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x9CE270 Offset: 0x9CC870 VA: 0x1809CE270
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x9CDE90 Offset: 0x9CC490 VA: 0x1809CDE90
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0x9CE290 Offset: 0x9CC890 VA: 0x1809CE290
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x9CDED0 Offset: 0x9CC4D0 VA: 0x1809CDED0
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0x9CDEB0 Offset: 0x9CC4B0 VA: 0x1809CDEB0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CDEF0 Offset: 0x9CC4F0 VA: 0x1809CDEF0
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9CDFD0 Offset: 0x9CC5D0 VA: 0x1809CDFD0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x9CE530 Offset: 0x9CCB30 VA: 0x1809CE530
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x9CE070 Offset: 0x9CC670 VA: 0x1809CE070
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0x9CE5D0 Offset: 0x9CCBD0 VA: 0x1809CE5D0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x9CE670 Offset: 0x9CCC70 VA: 0x1809CE670
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0x9CE1B0 Offset: 0x9CC7B0 VA: 0x1809CE1B0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>.get_Task
	|-TaskCompletionSource<bool>.get_Task
	|-TaskCompletionSource<int>.get_Task
	|-TaskCompletionSource<long>.get_Task
	|-TaskCompletionSource<object>.get_Task
	|-TaskCompletionSource<SceneInstance>.get_Task
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CD230 Offset: 0x9CB830 VA: 0x1809CD230
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>.SpinUntilCompleted
	|
	|-RVA: 0x9CD3B0 Offset: 0x9CB9B0 VA: 0x1809CD3B0
	|-TaskCompletionSource<bool>.SpinUntilCompleted
	|
	|-RVA: 0x9CD330 Offset: 0x9CB930 VA: 0x1809CD330
	|-TaskCompletionSource<int>.SpinUntilCompleted
	|
	|-RVA: 0x9CD2B0 Offset: 0x9CB8B0 VA: 0x1809CD2B0
	|-TaskCompletionSource<long>.SpinUntilCompleted
	|
	|-RVA: 0x9CD1B0 Offset: 0x9CB7B0 VA: 0x1809CD1B0
	|-TaskCompletionSource<object>.SpinUntilCompleted
	|
	|-RVA: 0x9CD430 Offset: 0x9CBA30 VA: 0x1809CD430
	|-TaskCompletionSource<SceneInstance>.SpinUntilCompleted
	|
	|-RVA: 0x9CD4B0 Offset: 0x9CBAB0 VA: 0x1809CD4B0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CD770 Offset: 0x9CBD70 VA: 0x1809CD770
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>.TrySetException
	|
	|-RVA: 0x9CD5C0 Offset: 0x9CBBC0 VA: 0x1809CD5C0
	|-TaskCompletionSource<bool>.TrySetException
	|
	|-RVA: 0x9CD890 Offset: 0x9CBE90 VA: 0x1809CD890
	|-TaskCompletionSource<int>.TrySetException
	|
	|-RVA: 0x9CD800 Offset: 0x9CBE00 VA: 0x1809CD800
	|-TaskCompletionSource<long>.TrySetException
	|
	|-RVA: 0x9CD650 Offset: 0x9CBC50 VA: 0x1809CD650
	|-TaskCompletionSource<object>.TrySetException
	|
	|-RVA: 0x9CD6E0 Offset: 0x9CBCE0 VA: 0x1809CD6E0
	|-TaskCompletionSource<SceneInstance>.TrySetException
	|
	|-RVA: 0x9CD530 Offset: 0x9CBB30 VA: 0x1809CD530
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CD920 Offset: 0x9CBF20 VA: 0x1809CD920
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>.TrySetResult
	|
	|-RVA: 0x9CDA10 Offset: 0x9CC010 VA: 0x1809CDA10
	|-TaskCompletionSource<bool>.TrySetResult
	|
	|-RVA: 0x9CDCB0 Offset: 0x9CC2B0 VA: 0x1809CDCB0
	|-TaskCompletionSource<int>.TrySetResult
	|
	|-RVA: 0x9CDC50 Offset: 0x9CC250 VA: 0x1809CDC50
	|-TaskCompletionSource<long>.TrySetResult
	|
	|-RVA: 0x9CDBF0 Offset: 0x9CC1F0 VA: 0x1809CDBF0
	|-TaskCompletionSource<object>.TrySetResult
	|
	|-RVA: 0x9CDB80 Offset: 0x9CC180 VA: 0x1809CDB80
	|-TaskCompletionSource<SceneInstance>.TrySetResult
	|
	|-RVA: 0x9CDA70 Offset: 0x9CC070 VA: 0x1809CDA70
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CCFD0 Offset: 0x9CB5D0 VA: 0x1809CCFD0
	|-TaskCompletionSource<LocalizedDatabase.TableEntryResult<object, object>>.SetResult
	|
	|-RVA: 0x9CD0D0 Offset: 0x9CB6D0 VA: 0x1809CD0D0
	|-TaskCompletionSource<bool>.SetResult
	|
	|-RVA: 0x9CD140 Offset: 0x9CB740 VA: 0x1809CD140
	|-TaskCompletionSource<int>.SetResult
	|
	|-RVA: 0x9CCEF0 Offset: 0x9CB4F0 VA: 0x1809CCEF0
	|-TaskCompletionSource<long>.SetResult
	|
	|-RVA: 0x9CCF60 Offset: 0x9CB560 VA: 0x1809CCF60
	|-TaskCompletionSource<object>.SetResult
	|
	|-RVA: 0x9CCE70 Offset: 0x9CB470 VA: 0x1809CCE70
	|-TaskCompletionSource<SceneInstance>.SetResult
	|
	|-RVA: 0x9CCD70 Offset: 0x9CB370 VA: 0x1809CCD70
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetResult
	*/
}

// Namespace: System.Threading.Tasks
[Serializable]
public class TaskSchedulerException : Exception // TypeDefIndex: 587
{
	// Methods

	// RVA: 0x1596480 Offset: 0x1594A80 VA: 0x181596480
	public void .ctor() { }

	// RVA: 0x15964E0 Offset: 0x1594AE0 VA: 0x1815964E0
	public void .ctor(Exception innerException) { }

	// RVA: 0x1596400 Offset: 0x1594A00 VA: 0x181596400
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading.Tasks
internal static class TaskToApm // TypeDefIndex: 590
{
	// Methods

	// RVA: 0x1596CD0 Offset: 0x15952D0 VA: 0x181596CD0
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x1596EF0 Offset: 0x15954F0 VA: 0x181596EF0
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C1F20 Offset: 0x7C0520 VA: 0x1807C1F20
	|-TaskToApm.End<int>
	|
	|-RVA: 0x7C2080 Offset: 0x7C0680 VA: 0x1807C2080
	|-TaskToApm.End<object>
	|
	|-RVA: 0x7C1D50 Offset: 0x7C0350 VA: 0x1807C1D50
	|-TaskToApm.End<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1596FF0 Offset: 0x15955F0 VA: 0x181596FF0
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}

// Namespace: System.Threading.Tasks
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
[IsReadOnly]
public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 593
{
	// Fields
	private static readonly Task s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x15A4150 Offset: 0x15A2750 VA: 0x1815A4150
	internal static Task get_CompletedTask() { }

	// RVA: 0x15A4100 Offset: 0x15A2700 VA: 0x1815A4100
	public void .ctor(Task task) { }

	// RVA: 0x15A4070 Offset: 0x15A2670 VA: 0x1815A4070
	public void .ctor(IValueTaskSource source, short token) { }

	// RVA: 0x15A40C0 Offset: 0x15A26C0 VA: 0x1815A40C0
	private void .ctor(object obj, short token, bool continueOnCapturedContext) { }

	// RVA: 0x15A3BE0 Offset: 0x15A21E0 VA: 0x1815A3BE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15A3B10 Offset: 0x15A2110 VA: 0x1815A3B10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15A3BC0 Offset: 0x15A21C0 VA: 0x1815A3BC0 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x15A39D0 Offset: 0x15A1FD0 VA: 0x1815A39D0
	public Task AsTask() { }

	// RVA: 0x15A3C00 Offset: 0x15A2200 VA: 0x1815A3C00
	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	// RVA: 0x15A41E0 Offset: 0x15A27E0 VA: 0x1815A41E0
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x15A3F00 Offset: 0x15A2500 VA: 0x1815A3F00
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x1414E90 Offset: 0x1413490 VA: 0x181414E90
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x15A3AA0 Offset: 0x15A20A0 VA: 0x1815A3AA0
	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x15A3FA0 Offset: 0x15A25A0 VA: 0x1815A3FA0
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<TResult>))]
[IsReadOnly]
public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 596
{
	// Fields
	private static Task<TResult> s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04A80 Offset: 0xB03080 VA: 0x180B04A80
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xAF3B70 Offset: 0xAF2170 VA: 0x180AF3B70
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04AB0 Offset: 0xB030B0 VA: 0x180B04AB0
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xAF3D70 Offset: 0xAF2370 VA: 0x180AF3D70
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04B40 Offset: 0xB03140 VA: 0x180B04B40
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xAF39B0 Offset: 0xAF1FB0 VA: 0x180AF39B0
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(object obj, TResult result, short token, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04B00 Offset: 0xB03100 VA: 0x180B04B00
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xAF3F30 Offset: 0xAF2530 VA: 0x180AF3F30
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03B10 Offset: 0xB02110 VA: 0x180B03B10
	|-ValueTask<int>.GetHashCode
	|
	|-RVA: 0xB03830 Offset: 0xB01E30 VA: 0x180B03830
	|-ValueTask<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03010 Offset: 0xB01610 VA: 0x180B03010
	|-ValueTask<int>.Equals
	|
	|-RVA: 0xB03130 Offset: 0xB01730 VA: 0x180B03130
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02F70 Offset: 0xB01570 VA: 0x180B02F70
	|-ValueTask<int>.Equals
	|
	|-RVA: 0xB03270 Offset: 0xB01870 VA: 0x180B03270
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> AsTask() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02D70 Offset: 0xB01370 VA: 0x180B02D70
	|-ValueTask<int>.AsTask
	|
	|-RVA: 0xB02AE0 Offset: 0xB010E0 VA: 0x180B02AE0
	|-ValueTask<__Il2CppFullySharedGenericType>.AsTask
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03B70 Offset: 0xB02170 VA: 0x180B03B70
	|-ValueTask<int>.GetTaskForValueTaskSource
	|
	|-RVA: 0xB040B0 Offset: 0xB026B0 VA: 0x180B040B0
	|-ValueTask<__Il2CppFullySharedGenericType>.GetTaskForValueTaskSource
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04CA0 Offset: 0xB032A0 VA: 0x180B04CA0
	|-ValueTask<int>.get_IsCompleted
	|
	|-RVA: 0xAF42B0 Offset: 0xAF28B0 VA: 0x180AF42B0
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04BA0 Offset: 0xB031A0 VA: 0x180B04BA0
	|-ValueTask<int>.get_IsCompletedSuccessfully
	|
	|-RVA: 0xAF4140 Offset: 0xAF2740 VA: 0x180AF4140
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04DA0 Offset: 0xB033A0 VA: 0x180B04DA0
	|-ValueTask<int>.get_Result
	|
	|-RVA: 0xAF4420 Offset: 0xAF2A20 VA: 0x180AF4420
	|-ValueTask<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03670 Offset: 0xB01C70 VA: 0x180B03670
	|-ValueTask<int>.GetAwaiter
	|
	|-RVA: 0xB036C0 Offset: 0xB01CC0 VA: 0x180B036C0
	|-ValueTask<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02EB0 Offset: 0xB014B0 VA: 0x180B02EB0
	|-ValueTask<int>.ConfigureAwait
	|
	|-RVA: 0xAF3690 Offset: 0xAF1C90 VA: 0x180AF3690
	|-ValueTask<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB046F0 Offset: 0xB02CF0 VA: 0x180B046F0
	|-ValueTask<int>.ToString
	|
	|-RVA: 0xB047C0 Offset: 0xB02DC0 VA: 0x180B047C0
	|-ValueTask<__Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: System.Threading.Tasks
[Extension]
internal static class TaskAwaiters // TypeDefIndex: 597
{
	// Methods

	[Extension]
	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public static ForceAsyncAwaiter ForceAsync(Task task) { }
}

// Namespace: System.Threading.Tasks
[IsReadOnly]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 598
{
	// Fields
	private readonly Task _task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	internal void .ctor(Task task) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public ForceAsyncAwaiter GetAwaiter() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public bool get_IsCompleted() { }

	// RVA: 0x1590630 Offset: 0x158EC30 VA: 0x181590630
	public void GetResult() { }

	// RVA: 0x1590670 Offset: 0x158EC70 VA: 0x181590670 Slot: 4
	public void UnsafeOnCompleted(Action action) { }
}

// Namespace: System.Threading.Tasks
[Extension]
internal static class DebuggerSupport // TypeDefIndex: 599
{
	// Fields
	private static readonly LowLevelDictionary<int, Task> s_activeTasks; // 0x0
	private static readonly object s_activeTasksLock; // 0x8

	// Properties
	public static bool LoggingOn { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool get_LoggingOn() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	// RVA: 0x158D630 Offset: 0x158BC30 VA: 0x18158D630
	public static void AddToActiveTasks(Task task) { }

	// RVA: 0x158D4F0 Offset: 0x158BAF0 VA: 0x18158D4F0
	private static void AddToActiveTasksNonInlined(Task task) { }

	// RVA: 0x158D7F0 Offset: 0x158BDF0 VA: 0x18158D7F0
	public static void RemoveFromActiveTasks(Task task) { }

	// RVA: 0x158D6C0 Offset: 0x158BCC0 VA: 0x18158D6C0
	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	// RVA: 0x158D880 Offset: 0x158BE80 VA: 0x18158D880
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<TResult>))]
public class Task<TResult> : Task // TypeDefIndex: 600
{
	// Fields
	internal TResult m_result; // 0x0
	private static TaskFactory<TResult> s_defaultFactory; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E1250 Offset: 0x9DF850 VA: 0x1809E1250
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E2710 Offset: 0x9E0D10 VA: 0x1809E2710
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E24E0 Offset: 0x9E0AE0 VA: 0x1809E24E0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9E0360 Offset: 0x9DE960 VA: 0x1809E0360
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E05F0 Offset: 0x9DEBF0 VA: 0x1809E05F0
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9E19D0 Offset: 0x9DFFD0 VA: 0x1809E19D0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9DFC80 Offset: 0x9DE280 VA: 0x1809DFC80
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E3380 Offset: 0x9E1980 VA: 0x1809E3380
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E0B20 Offset: 0x9DF120 VA: 0x1809E0B20
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E2870 Offset: 0x9E0E70 VA: 0x1809E2870
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9E0F40 Offset: 0x9DF540 VA: 0x1809E0F40
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E17C0 Offset: 0x9DFDC0 VA: 0x1809E17C0
	|-Task<char>..ctor
	|
	|-RVA: 0x9DFCD0 Offset: 0x9DE2D0 VA: 0x1809DFCD0
	|-Task<int>..ctor
	|
	|-RVA: 0x9E6FE0 Offset: 0x9E55E0 VA: 0x1809E6FE0
	|-Task<long>..ctor
	|
	|-RVA: 0x9E67F0 Offset: 0x9E4DF0 VA: 0x1809E67F0
	|-Task<object>..ctor
	|
	|-RVA: 0x9E69F0 Offset: 0x9E4FF0 VA: 0x1809E69F0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E6880 Offset: 0x9E4E80 VA: 0x1809E6880
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E7840 Offset: 0x9E5E40 VA: 0x1809E7840
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E12A0 Offset: 0x9DF8A0 VA: 0x1809E12A0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E23D0 Offset: 0x9E09D0 VA: 0x1809E23D0
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E3010 Offset: 0x9E1610 VA: 0x1809E3010
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9DFF70 Offset: 0x9DE570 VA: 0x1809DFF70
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E02E0 Offset: 0x9DE8E0 VA: 0x1809E02E0
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9E2B20 Offset: 0x9E1120 VA: 0x1809E2B20
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9E0C00 Offset: 0x9DF200 VA: 0x1809E0C00
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E1FB0 Offset: 0x9E05B0 VA: 0x1809E1FB0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E1410 Offset: 0x9DFA10 VA: 0x1809E1410
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E2AA0 Offset: 0x9E10A0 VA: 0x1809E2AA0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9E0850 Offset: 0x9DEE50 VA: 0x1809E0850
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E0700 Offset: 0x9DED00 VA: 0x1809E0700
	|-Task<char>..ctor
	|
	|-RVA: 0x9E0680 Offset: 0x9DEC80 VA: 0x1809E0680
	|-Task<int>..ctor
	|
	|-RVA: 0x9E7400 Offset: 0x9E5A00 VA: 0x1809E7400
	|-Task<long>..ctor
	|
	|-RVA: 0x9E6E10 Offset: 0x9E5410 VA: 0x1809E6E10
	|-Task<object>..ctor
	|
	|-RVA: 0x9E7380 Offset: 0x9E5980 VA: 0x1809E7380
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E70C0 Offset: 0x9E56C0 VA: 0x1809E70C0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E68D0 Offset: 0x9E4ED0 VA: 0x1809E68D0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E2FA0 Offset: 0x9E15A0 VA: 0x1809E2FA0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E1640 Offset: 0x9DFC40 VA: 0x1809E1640
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E1C10 Offset: 0x9E0210 VA: 0x1809E1C10
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9E0960 Offset: 0x9DEF60 VA: 0x1809E0960
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E22D0 Offset: 0x9E08D0 VA: 0x1809E22D0
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9DFD20 Offset: 0x9DE320 VA: 0x1809DFD20
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9E2760 Offset: 0x9E0D60 VA: 0x1809E2760
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E0D60 Offset: 0x9DF360 VA: 0x1809E0D60
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E1740 Offset: 0x9DFD40 VA: 0x1809E1740
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E1540 Offset: 0x9DFB40 VA: 0x1809E1540
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9E2EA0 Offset: 0x9E14A0 VA: 0x1809E2EA0
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E28C0 Offset: 0x9E0EC0 VA: 0x1809E28C0
	|-Task<char>..ctor
	|
	|-RVA: 0x9E1EB0 Offset: 0x9E04B0 VA: 0x1809E1EB0
	|-Task<int>..ctor
	|
	|-RVA: 0x9E6F70 Offset: 0x9E5570 VA: 0x1809E6F70
	|-Task<long>..ctor
	|
	|-RVA: 0x9E7480 Offset: 0x9E5A80 VA: 0x1809E7480
	|-Task<object>..ctor
	|
	|-RVA: 0x9E7980 Offset: 0x9E5F80 VA: 0x1809E7980
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E6C30 Offset: 0x9E5230 VA: 0x1809E6C30
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E65A0 Offset: 0x9E4BA0 VA: 0x1809E65A0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E2450 Offset: 0x9E0A50 VA: 0x1809E2450
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E01B0 Offset: 0x9DE7B0 VA: 0x1809E01B0
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E11B0 Offset: 0x9DF7B0 VA: 0x1809E11B0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9E1060 Offset: 0x9DF660 VA: 0x1809E1060
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E0A90 Offset: 0x9DF090 VA: 0x1809E0A90
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9E2240 Offset: 0x9E0840 VA: 0x1809E2240
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9DFED0 Offset: 0x9DE4D0 VA: 0x1809DFED0
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E0240 Offset: 0x9DE840 VA: 0x1809E0240
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E1100 Offset: 0x9DF700 VA: 0x1809E1100
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E0E90 Offset: 0x9DF490 VA: 0x1809E0E90
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9E16B0 Offset: 0x9DFCB0 VA: 0x1809E16B0
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E1D70 Offset: 0x9E0370 VA: 0x1809E1D70
	|-Task<char>..ctor
	|
	|-RVA: 0x9E32F0 Offset: 0x9E18F0 VA: 0x1809E32F0
	|-Task<int>..ctor
	|
	|-RVA: 0x9E66B0 Offset: 0x9E4CB0 VA: 0x1809E66B0
	|-Task<long>..ctor
	|
	|-RVA: 0x9E6950 Offset: 0x9E4F50 VA: 0x1809E6950
	|-Task<object>..ctor
	|
	|-RVA: 0x9E7500 Offset: 0x9E5B00 VA: 0x1809E7500
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E72F0 Offset: 0x9E58F0 VA: 0x1809E72F0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E7A90 Offset: 0x9E6090 VA: 0x1809E7A90
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E2530 Offset: 0x9E0B30 VA: 0x1809E2530
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E1320 Offset: 0x9DF920 VA: 0x1809E1320
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E2200 Offset: 0x9E0800 VA: 0x1809E2200
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9E2030 Offset: 0x9E0630 VA: 0x1809E2030
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E1600 Offset: 0x9DFC00 VA: 0x1809E1600
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9E1020 Offset: 0x9DF620 VA: 0x1809E1020
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9E2570 Offset: 0x9E0B70 VA: 0x1809E2570
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E0640 Offset: 0x9DEC40 VA: 0x1809E0640
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E3140 Offset: 0x9E1740 VA: 0x1809E3140
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E1A60 Offset: 0x9E0060 VA: 0x1809E1A60
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9E0780 Offset: 0x9DED80 VA: 0x1809E0780
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E15C0 Offset: 0x9DFBC0 VA: 0x1809E15C0
	|-Task<char>..ctor
	|
	|-RVA: 0x9E1A20 Offset: 0x9E0020 VA: 0x1809E1A20
	|-Task<int>..ctor
	|
	|-RVA: 0x9E6840 Offset: 0x9E4E40 VA: 0x1809E6840
	|-Task<long>..ctor
	|
	|-RVA: 0x9E75A0 Offset: 0x9E5BA0 VA: 0x1809E75A0
	|-Task<object>..ctor
	|
	|-RVA: 0x9E7940 Offset: 0x9E5F40 VA: 0x1809E7940
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E6560 Offset: 0x9E4B60 VA: 0x1809E6560
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E71D0 Offset: 0x9E57D0 VA: 0x1809E71D0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E1C90 Offset: 0x9E0290 VA: 0x1809E1C90
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E1810 Offset: 0x9DFE10 VA: 0x1809E1810
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E2CE0 Offset: 0x9E12E0 VA: 0x1809E2CE0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9E3210 Offset: 0x9E1810 VA: 0x1809E3210
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E0510 Offset: 0x9DEB10 VA: 0x1809E0510
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9E0C80 Offset: 0x9DF280 VA: 0x1809E0C80
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9DFFF0 Offset: 0x9DE5F0 VA: 0x1809DFFF0
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E29C0 Offset: 0x9E0FC0 VA: 0x1809E29C0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E2070 Offset: 0x9E0670 VA: 0x1809E2070
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E18F0 Offset: 0x9DFEF0 VA: 0x1809E18F0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9E2DC0 Offset: 0x9E13C0 VA: 0x1809E2DC0
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E00D0 Offset: 0x9DE6D0 VA: 0x1809E00D0
	|-Task<char>..ctor
	|
	|-RVA: 0x9E1AA0 Offset: 0x9E00A0 VA: 0x1809E1AA0
	|-Task<int>..ctor
	|
	|-RVA: 0x9E7690 Offset: 0x9E5C90 VA: 0x1809E7690
	|-Task<long>..ctor
	|
	|-RVA: 0x9E6E90 Offset: 0x9E5490 VA: 0x1809E6E90
	|-Task<object>..ctor
	|
	|-RVA: 0x9E6D30 Offset: 0x9E5330 VA: 0x1809E6D30
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E7210 Offset: 0x9E5810 VA: 0x1809E7210
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E7770 Offset: 0x9E5D70 VA: 0x1809E7770
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E09E0 Offset: 0x9DEFE0 VA: 0x1809E09E0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E3090 Offset: 0x9E1690 VA: 0x1809E3090
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E2660 Offset: 0x9E0C60 VA: 0x1809E2660
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9E25B0 Offset: 0x9E0BB0 VA: 0x1809E25B0
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E0460 Offset: 0x9DEA60 VA: 0x1809E0460
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9E1E00 Offset: 0x9E0400 VA: 0x1809E1E00
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9E2150 Offset: 0x9E0750 VA: 0x1809E2150
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E03B0 Offset: 0x9DE9B0 VA: 0x1809E03B0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E1360 Offset: 0x9DF960 VA: 0x1809E1360
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E2C30 Offset: 0x9E1230 VA: 0x1809E2C30
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9DFD90 Offset: 0x9DE390 VA: 0x1809DFD90
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E0DE0 Offset: 0x9DF3E0 VA: 0x1809E0DE0
	|-Task<char>..ctor
	|
	|-RVA: 0x9E1490 Offset: 0x9DFA90 VA: 0x1809E1490
	|-Task<int>..ctor
	|
	|-RVA: 0x9E75E0 Offset: 0x9E5BE0 VA: 0x1809E75E0
	|-Task<long>..ctor
	|
	|-RVA: 0x9E6AF0 Offset: 0x9E50F0 VA: 0x1809E6AF0
	|-Task<object>..ctor
	|
	|-RVA: 0x9E7890 Offset: 0x9E5E90 VA: 0x1809E7890
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E6A40 Offset: 0x9E5040 VA: 0x1809E6A40
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E6740 Offset: 0x9E4D40 VA: 0x1809E6740
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E1F20 Offset: 0x9E0520 VA: 0x1809E1F20
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x9E2930 Offset: 0x9E0F30 VA: 0x1809E2930
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x9E27E0 Offset: 0x9E0DE0 VA: 0x1809E27E0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x9E3180 Offset: 0x9E1780 VA: 0x1809E3180
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x9E08D0 Offset: 0x9DEED0 VA: 0x1809E08D0
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x9E0B70 Offset: 0x9DF170 VA: 0x1809E0B70
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x9E07C0 Offset: 0x9DEDC0 VA: 0x1809E07C0
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0x9E0F90 Offset: 0x9DF590 VA: 0x1809E0F90
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x9E1B80 Offset: 0x9E0180 VA: 0x1809E1B80
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x9E2F10 Offset: 0x9E1510 VA: 0x1809E2F10
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x9E2BA0 Offset: 0x9E11A0 VA: 0x1809E2BA0
	|-Task<bool>..ctor
	|
	|-RVA: 0x9E2340 Offset: 0x9E0940 VA: 0x1809E2340
	|-Task<char>..ctor
	|
	|-RVA: 0x9DFE40 Offset: 0x9DE440 VA: 0x1809DFE40
	|-Task<int>..ctor
	|
	|-RVA: 0x9E6CA0 Offset: 0x9E52A0 VA: 0x1809E6CA0
	|-Task<long>..ctor
	|
	|-RVA: 0x9E7140 Offset: 0x9E5740 VA: 0x1809E7140
	|-Task<object>..ctor
	|
	|-RVA: 0x9E6BA0 Offset: 0x9E51A0 VA: 0x1809E6BA0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0x9E7030 Offset: 0x9E5630 VA: 0x1809E7030
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x9E7A00 Offset: 0x9E6000 VA: 0x1809E7A00
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DDFE0 Offset: 0x9DC5E0 VA: 0x1809DDFE0
	|-Task<Nullable<bool>>.StartNew
	|
	|-RVA: 0x9DE180 Offset: 0x9DC780 VA: 0x1809DE180
	|-Task<Nullable<DateTime>>.StartNew
	|
	|-RVA: 0x9DF3C0 Offset: 0x9DD9C0 VA: 0x1809DF3C0
	|-Task<Nullable<DateTimeOffset>>.StartNew
	|
	|-RVA: 0x9DCA50 Offset: 0x9DB050 VA: 0x1809DCA50
	|-Task<Nullable<Decimal>>.StartNew
	|
	|-RVA: 0x9DD100 Offset: 0x9DB700 VA: 0x1809DD100
	|-Task<Nullable<double>>.StartNew
	|
	|-RVA: 0x9DDCA0 Offset: 0x9DC2A0 VA: 0x1809DDCA0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x9DE830 Offset: 0x9DCE30 VA: 0x1809DE830
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.StartNew
	|
	|-RVA: 0x9DE9D0 Offset: 0x9DCFD0 VA: 0x1809DE9D0
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x9DF220 Offset: 0x9DD820 VA: 0x1809DF220
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x9DD450 Offset: 0x9DBA50 VA: 0x1809DD450
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x9DD7A0 Offset: 0x9DBDA0 VA: 0x1809DD7A0
	|-Task<bool>.StartNew
	|
	|-RVA: 0x9DDE40 Offset: 0x9DC440 VA: 0x1809DDE40
	|-Task<char>.StartNew
	|
	|-RVA: 0x9DEED0 Offset: 0x9DD4D0 VA: 0x1809DEED0
	|-Task<int>.StartNew
	|
	|-RVA: 0x9E5FF0 Offset: 0x9E45F0 VA: 0x1809E5FF0
	|-Task<long>.StartNew
	|
	|-RVA: 0x9E5290 Offset: 0x9E3890 VA: 0x1809E5290
	|-Task<object>.StartNew
	|
	|-RVA: 0x9E5790 Offset: 0x9E3D90 VA: 0x1809E5790
	|-Task<SceneInstance>.StartNew
	|
	|-RVA: 0x9E5E50 Offset: 0x9E4450 VA: 0x1809E5E50
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x9E5930 Offset: 0x9E3F30 VA: 0x1809E5930
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DED20 Offset: 0x9DD320 VA: 0x1809DED20
	|-Task<Nullable<bool>>.StartNew
	|
	|-RVA: 0x9DE4D0 Offset: 0x9DCAD0 VA: 0x1809DE4D0
	|-Task<Nullable<DateTime>>.StartNew
	|
	|-RVA: 0x9DDAF0 Offset: 0x9DC0F0 VA: 0x1809DDAF0
	|-Task<Nullable<DateTimeOffset>>.StartNew
	|
	|-RVA: 0x9DE320 Offset: 0x9DC920 VA: 0x1809DE320
	|-Task<Nullable<Decimal>>.StartNew
	|
	|-RVA: 0x9DCF50 Offset: 0x9DB550 VA: 0x1809DCF50
	|-Task<Nullable<double>>.StartNew
	|
	|-RVA: 0x9DD2A0 Offset: 0x9DB8A0 VA: 0x1809DD2A0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x9DE680 Offset: 0x9DCC80 VA: 0x1809DE680
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.StartNew
	|
	|-RVA: 0x9DD940 Offset: 0x9DBF40 VA: 0x1809DD940
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x9DEB70 Offset: 0x9DD170 VA: 0x1809DEB70
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x9DF070 Offset: 0x9DD670 VA: 0x1809DF070
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x9DD5F0 Offset: 0x9DBBF0 VA: 0x1809DD5F0
	|-Task<bool>.StartNew
	|
	|-RVA: 0x9DCDA0 Offset: 0x9DB3A0 VA: 0x1809DCDA0
	|-Task<char>.StartNew
	|
	|-RVA: 0x9DCBF0 Offset: 0x9DB1F0 VA: 0x1809DCBF0
	|-Task<int>.StartNew
	|
	|-RVA: 0x9E5AF0 Offset: 0x9E40F0 VA: 0x1809E5AF0
	|-Task<long>.StartNew
	|
	|-RVA: 0x9E55E0 Offset: 0x9E3BE0 VA: 0x1809E55E0
	|-Task<object>.StartNew
	|
	|-RVA: 0x9E5CA0 Offset: 0x9E42A0 VA: 0x1809E5CA0
	|-Task<SceneInstance>.StartNew
	|
	|-RVA: 0x9E5430 Offset: 0x9E3A30 VA: 0x1809E5430
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x9E6190 Offset: 0x9E4790 VA: 0x1809E6190
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DF560 Offset: 0x9DDB60 VA: 0x1809DF560
	|-Task<Nullable<bool>>.TrySetResult
	|-Task<char>.TrySetResult
	|
	|-RVA: 0x9DF610 Offset: 0x9DDC10 VA: 0x1809DF610
	|-Task<Nullable<DateTime>>.TrySetResult
	|-Task<Nullable<double>>.TrySetResult
	|
	|-RVA: 0x9DF830 Offset: 0x9DDE30 VA: 0x1809DF830
	|-Task<Nullable<DateTimeOffset>>.TrySetResult
	|-Task<Nullable<Decimal>>.TrySetResult
	|
	|-RVA: 0x9DF6C0 Offset: 0x9DDCC0 VA: 0x1809DF6C0
	|-Task<Nullable<int>>.TrySetResult
	|-Task<long>.TrySetResult
	|
	|-RVA: 0x9DFBC0 Offset: 0x9DE1C0 VA: 0x1809DFBC0
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.TrySetResult
	|
	|-RVA: 0x9DF990 Offset: 0x9DDF90 VA: 0x1809DF990
	|-Task<ValueTuple<bool, object>>.TrySetResult
	|-Task<SceneInstance>.TrySetResult
	|
	|-RVA: 0x9DFB00 Offset: 0x9DE100 VA: 0x1809DFB00
	|-Task<ValueTuple<object, object, int>>.TrySetResult
	|
	|-RVA: 0x9DF770 Offset: 0x9DDD70 VA: 0x1809DF770
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetResult
	|
	|-RVA: 0x9DF8E0 Offset: 0x9DDEE0 VA: 0x1809DF8E0
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x9DFA50 Offset: 0x9DE050 VA: 0x1809DFA50
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x9E6360 Offset: 0x9E4960 VA: 0x1809E6360
	|-Task<object>.TrySetResult
	|
	|-RVA: 0x9E6410 Offset: 0x9E4A10 VA: 0x1809E6410
	|-Task<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DBB90 Offset: 0x9DA190 VA: 0x1809DBB90
	|-Task<Nullable<bool>>.DangerousSetResult
	|-Task<char>.DangerousSetResult
	|
	|-RVA: 0x9DB8E0 Offset: 0x9D9EE0 VA: 0x1809DB8E0
	|-Task<Nullable<DateTime>>.DangerousSetResult
	|-Task<Nullable<double>>.DangerousSetResult
	|
	|-RVA: 0x9DB9A0 Offset: 0x9D9FA0 VA: 0x1809DB9A0
	|-Task<Nullable<DateTimeOffset>>.DangerousSetResult
	|-Task<Nullable<Decimal>>.DangerousSetResult
	|
	|-RVA: 0x9DBDF0 Offset: 0x9DA3F0 VA: 0x1809DBDF0
	|-Task<Nullable<int>>.DangerousSetResult
	|
	|-RVA: 0x9DBAC0 Offset: 0x9DA0C0 VA: 0x1809DBAC0
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.DangerousSetResult
	|
	|-RVA: 0x9DBCD0 Offset: 0x9DA2D0 VA: 0x1809DBCD0
	|-Task<ValueTuple<bool, object>>.DangerousSetResult
	|-Task<SceneInstance>.DangerousSetResult
	|
	|-RVA: 0x9DBBF0 Offset: 0x9DA1F0 VA: 0x1809DBBF0
	|-Task<ValueTuple<object, object, int>>.DangerousSetResult
	|
	|-RVA: 0x9DB800 Offset: 0x9D9E00 VA: 0x1809DB800
	|-Task<ValueTuple<object, bool, bool, object, object>>.DangerousSetResult
	|
	|-RVA: 0x9DBA70 Offset: 0x9DA070 VA: 0x1809DBA70
	|-Task<bool>.DangerousSetResult
	|
	|-RVA: 0x9DBDA0 Offset: 0x9DA3A0 VA: 0x1809DBDA0
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x9E4E90 Offset: 0x9E3490 VA: 0x1809E4E90
	|-Task<long>.DangerousSetResult
	|
	|-RVA: 0x9E4DC0 Offset: 0x9E33C0 VA: 0x1809E4DC0
	|-Task<object>.DangerousSetResult
	|
	|-RVA: 0x9E4D10 Offset: 0x9E3310 VA: 0x1809E4D10
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x9E4BD0 Offset: 0x9E31D0 VA: 0x1809E4BD0
	|-Task<__Il2CppFullySharedGenericType>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E38E0 Offset: 0x9E1EE0 VA: 0x1809E38E0
	|-Task<Nullable<bool>>.get_Result
	|-Task<char>.get_Result
	|
	|-RVA: 0x9E3790 Offset: 0x9E1D90 VA: 0x1809E3790
	|-Task<Nullable<DateTime>>.get_Result
	|-Task<Nullable<double>>.get_Result
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.get_Result
	|-Task<ValueTuple<bool, object>>.get_Result
	|-Task<SceneInstance>.get_Result
	|
	|-RVA: 0x9E35C0 Offset: 0x9E1BC0 VA: 0x1809E35C0
	|-Task<Nullable<DateTimeOffset>>.get_Result
	|-Task<Nullable<Decimal>>.get_Result
	|-Task<ValueTuple<object, object, int>>.get_Result
	|
	|-RVA: 0x9E3670 Offset: 0x9E1C70 VA: 0x1809E3670
	|-Task<Nullable<int>>.get_Result
	|-Task<long>.get_Result
	|-Task<object>.get_Result
	|
	|-RVA: 0x9E3830 Offset: 0x9E1E30 VA: 0x1809E3830
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Result
	|
	|-RVA: 0x9E3700 Offset: 0x9E1D00 VA: 0x1809E3700
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x9E3970 Offset: 0x9E1F70 VA: 0x1809E3970
	|-Task<int>.get_Result
	|
	|-RVA: 0x9E7F40 Offset: 0x9E6540 VA: 0x1809E7F40
	|-Task<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E35A0 Offset: 0x9E1BA0 VA: 0x1809E35A0
	|-Task<Nullable<bool>>.get_ResultOnSuccess
	|-Task<char>.get_ResultOnSuccess
	|
	|-RVA: 0x9E35B0 Offset: 0x9E1BB0 VA: 0x1809E35B0
	|-Task<Nullable<DateTime>>.get_ResultOnSuccess
	|-Task<Nullable<double>>.get_ResultOnSuccess
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.get_ResultOnSuccess
	|-Task<ValueTuple<bool, object>>.get_ResultOnSuccess
	|-Task<SceneInstance>.get_ResultOnSuccess
	|
	|-RVA: 0x9E3560 Offset: 0x9E1B60 VA: 0x1809E3560
	|-Task<Nullable<DateTimeOffset>>.get_ResultOnSuccess
	|-Task<Nullable<Decimal>>.get_ResultOnSuccess
	|-Task<ValueTuple<object, object, int>>.get_ResultOnSuccess
	|
	|-RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|-Task<long>.get_ResultOnSuccess
	|-Task<object>.get_ResultOnSuccess
	|
	|-RVA: 0x9E3580 Offset: 0x9E1B80 VA: 0x1809E3580
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x9E7E90 Offset: 0x9E6490 VA: 0x1809E7E90
	|-Task<__Il2CppFullySharedGenericType>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DBF90 Offset: 0x9DA590 VA: 0x1809DBF90
	|-Task<Nullable<bool>>.GetResultCore
	|-Task<char>.GetResultCore
	|
	|-RVA: 0x9DBE80 Offset: 0x9DA480 VA: 0x1809DBE80
	|-Task<Nullable<DateTime>>.GetResultCore
	|-Task<Nullable<double>>.GetResultCore
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.GetResultCore
	|-Task<ValueTuple<bool, object>>.GetResultCore
	|-Task<SceneInstance>.GetResultCore
	|
	|-RVA: 0x9DC010 Offset: 0x9DA610 VA: 0x1809DC010
	|-Task<Nullable<DateTimeOffset>>.GetResultCore
	|-Task<Nullable<Decimal>>.GetResultCore
	|-Task<ValueTuple<object, object, int>>.GetResultCore
	|
	|-RVA: 0x9DBF10 Offset: 0x9DA510 VA: 0x1809DBF10
	|-Task<Nullable<int>>.GetResultCore
	|-Task<long>.GetResultCore
	|-Task<object>.GetResultCore
	|
	|-RVA: 0x9DC0B0 Offset: 0x9DA6B0 VA: 0x1809DC0B0
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetResultCore
	|
	|-RVA: 0x9DC140 Offset: 0x9DA740 VA: 0x1809DC140
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x9DC1C0 Offset: 0x9DA7C0 VA: 0x1809DC1C0
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x9E4F40 Offset: 0x9E3540 VA: 0x1809E4F40
	|-Task<__Il2CppFullySharedGenericType>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E33D0 Offset: 0x9E19D0 VA: 0x1809E33D0
	|-Task<Nullable<bool>>.get_Factory
	|-Task<Nullable<DateTime>>.get_Factory
	|-Task<Nullable<DateTimeOffset>>.get_Factory
	|-Task<Nullable<Decimal>>.get_Factory
	|-Task<Nullable<double>>.get_Factory
	|-Task<Nullable<int>>.get_Factory
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.get_Factory
	|-Task<ValueTuple<bool, object>>.get_Factory
	|-Task<ValueTuple<object, object, int>>.get_Factory
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Factory
	|-Task<bool>.get_Factory
	|-Task<char>.get_Factory
	|-Task<int>.get_Factory
	|
	|-RVA: 0x9E7BC0 Offset: 0x9E61C0 VA: 0x1809E7BC0
	|-Task<long>.get_Factory
	|-Task<object>.get_Factory
	|-Task<SceneInstance>.get_Factory
	|-Task<VoidTaskResult>.get_Factory
	|
	|-RVA: 0x9E7D10 Offset: 0x9E6310 VA: 0x1809E7D10
	|-Task<__Il2CppFullySharedGenericType>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DC8D0 Offset: 0x9DAED0 VA: 0x1809DC8D0
	|-Task<Nullable<bool>>.InnerInvoke
	|-Task<char>.InnerInvoke
	|
	|-RVA: 0x9DC590 Offset: 0x9DAB90 VA: 0x1809DC590
	|-Task<Nullable<DateTime>>.InnerInvoke
	|-Task<Nullable<double>>.InnerInvoke
	|
	|-RVA: 0x9DC230 Offset: 0x9DA830 VA: 0x1809DC230
	|-Task<Nullable<DateTimeOffset>>.InnerInvoke
	|-Task<Nullable<Decimal>>.InnerInvoke
	|
	|-RVA: 0x9DC990 Offset: 0x9DAF90 VA: 0x1809DC990
	|-Task<Nullable<int>>.InnerInvoke
	|-Task<long>.InnerInvoke
	|
	|-RVA: 0x9DC660 Offset: 0x9DAC60 VA: 0x1809DC660
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.InnerInvoke
	|
	|-RVA: 0x9DC730 Offset: 0x9DAD30 VA: 0x1809DC730
	|-Task<ValueTuple<bool, object>>.InnerInvoke
	|-Task<SceneInstance>.InnerInvoke
	|
	|-RVA: 0x9DC300 Offset: 0x9DA900 VA: 0x1809DC300
	|-Task<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0x9DC4B0 Offset: 0x9DAAB0 VA: 0x1809DC4B0
	|-Task<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|
	|-RVA: 0x9DC800 Offset: 0x9DAE00 VA: 0x1809DC800
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x9DC3E0 Offset: 0x9DA9E0 VA: 0x1809DC3E0
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x9E51C0 Offset: 0x9E37C0 VA: 0x1809E51C0
	|-Task<object>.InnerInvoke
	|
	|-RVA: 0x9E5060 Offset: 0x9E3660 VA: 0x1809E5060
	|-Task<__Il2CppFullySharedGenericType>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DBE50 Offset: 0x9DA450 VA: 0x1809DBE50
	|-Task<Nullable<bool>>.GetAwaiter
	|-Task<Nullable<DateTime>>.GetAwaiter
	|-Task<Nullable<DateTimeOffset>>.GetAwaiter
	|-Task<Nullable<Decimal>>.GetAwaiter
	|-Task<Nullable<double>>.GetAwaiter
	|-Task<Nullable<int>>.GetAwaiter
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.GetAwaiter
	|-Task<ValueTuple<bool, object>>.GetAwaiter
	|-Task<ValueTuple<object, object, int>>.GetAwaiter
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|-Task<bool>.GetAwaiter
	|-Task<char>.GetAwaiter
	|-Task<int>.GetAwaiter
	|-Task<long>.GetAwaiter
	|-Task<object>.GetAwaiter
	|-Task<SceneInstance>.GetAwaiter
	|-Task<VoidTaskResult>.GetAwaiter
	|-Task<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9D8570 Offset: 0x9D6B70 VA: 0x1809D8570
	|-Task<Nullable<bool>>.ConfigureAwait
	|-Task<Nullable<DateTime>>.ConfigureAwait
	|-Task<Nullable<DateTimeOffset>>.ConfigureAwait
	|-Task<Nullable<Decimal>>.ConfigureAwait
	|-Task<Nullable<double>>.ConfigureAwait
	|-Task<Nullable<int>>.ConfigureAwait
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.ConfigureAwait
	|-Task<ValueTuple<bool, object>>.ConfigureAwait
	|-Task<ValueTuple<object, object, int>>.ConfigureAwait
	|-Task<ValueTuple<object, bool, bool, object, object>>.ConfigureAwait
	|-Task<bool>.ConfigureAwait
	|-Task<char>.ConfigureAwait
	|-Task<int>.ConfigureAwait
	|-Task<long>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<SceneInstance>.ConfigureAwait
	|-Task<VoidTaskResult>.ConfigureAwait
	|-Task<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9DA480 Offset: 0x9D8A80 VA: 0x1809DA480
	|-Task<Nullable<bool>>.ContinueWith
	|
	|-RVA: 0x9D9500 Offset: 0x9D7B00 VA: 0x1809D9500
	|-Task<Nullable<DateTime>>.ContinueWith
	|
	|-RVA: 0x9D9320 Offset: 0x9D7920 VA: 0x1809D9320
	|-Task<Nullable<DateTimeOffset>>.ContinueWith
	|
	|-RVA: 0x9DB440 Offset: 0x9D9A40 VA: 0x1809DB440
	|-Task<Nullable<Decimal>>.ContinueWith
	|
	|-RVA: 0x9DB620 Offset: 0x9D9C20 VA: 0x1809DB620
	|-Task<Nullable<double>>.ContinueWith
	|
	|-RVA: 0x9D8D40 Offset: 0x9D7340 VA: 0x1809D8D40
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x9D87A0 Offset: 0x9D6DA0 VA: 0x1809D87A0
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.ContinueWith
	|
	|-RVA: 0x9D8980 Offset: 0x9D6F80 VA: 0x1809D8980
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x9D9CC0 Offset: 0x9D82C0 VA: 0x1809D9CC0
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x9D98E0 Offset: 0x9D7EE0 VA: 0x1809D98E0
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x9DAC60 Offset: 0x9D9260 VA: 0x1809DAC60
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x9D8B60 Offset: 0x9D7160 VA: 0x1809D8B60
	|-Task<char>.ContinueWith
	|
	|-RVA: 0x9DA2A0 Offset: 0x9D88A0 VA: 0x1809DA2A0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x9E3A00 Offset: 0x9E2000 VA: 0x1809E3A00
	|-Task<long>.ContinueWith
	|
	|-RVA: 0x9E49F0 Offset: 0x9E2FF0 VA: 0x1809E49F0
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x9E4030 Offset: 0x9E2630 VA: 0x1809E4030
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0x9E4610 Offset: 0x9E2C10 VA: 0x1809E4610
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x9E3BE0 Offset: 0x9E21E0 VA: 0x1809E3BE0
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9D96E0 Offset: 0x9D7CE0 VA: 0x1809D96E0
	|-Task<Nullable<bool>>.ContinueWith
	|
	|-RVA: 0x9D85A0 Offset: 0x9D6BA0 VA: 0x1809D85A0
	|-Task<Nullable<DateTime>>.ContinueWith
	|
	|-RVA: 0x9DAE40 Offset: 0x9D9440 VA: 0x1809DAE40
	|-Task<Nullable<DateTimeOffset>>.ContinueWith
	|
	|-RVA: 0x9DA0A0 Offset: 0x9D86A0 VA: 0x1809DA0A0
	|-Task<Nullable<Decimal>>.ContinueWith
	|
	|-RVA: 0x9D9120 Offset: 0x9D7720 VA: 0x1809D9120
	|-Task<Nullable<double>>.ContinueWith
	|
	|-RVA: 0x9D9EA0 Offset: 0x9D84A0 VA: 0x1809D9EA0
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x9D8F20 Offset: 0x9D7520 VA: 0x1809D8F20
	|-Task<LocalizedDatabase.TableEntryResult<object, object>>.ContinueWith
	|
	|-RVA: 0x9DAA60 Offset: 0x9D9060 VA: 0x1809DAA60
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x9DB240 Offset: 0x9D9840 VA: 0x1809DB240
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x9DA860 Offset: 0x9D8E60 VA: 0x1809DA860
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x9DB040 Offset: 0x9D9640 VA: 0x1809DB040
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x9DA660 Offset: 0x9D8C60 VA: 0x1809DA660
	|-Task<char>.ContinueWith
	|
	|-RVA: 0x9D9AC0 Offset: 0x9D80C0 VA: 0x1809D9AC0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x9E47F0 Offset: 0x9E2DF0 VA: 0x1809E47F0
	|-Task<long>.ContinueWith
	|
	|-RVA: 0x9E3C30 Offset: 0x9E2230 VA: 0x1809E3C30
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x9E4210 Offset: 0x9E2810 VA: 0x1809E4210
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0x9E3E30 Offset: 0x9E2430 VA: 0x1809E3E30
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x9E4410 Offset: 0x9E2A10 VA: 0x1809E4410
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60C710 Offset: 0x60AD10 VA: 0x18060C710
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x60C920 Offset: 0x60AF20 VA: 0x18060C920
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x60C490 Offset: 0x60AA90 VA: 0x18060C490
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60CB30 Offset: 0x60B130 VA: 0x18060CB30
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x60C530 Offset: 0x60AB30 VA: 0x18060C530
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x60C2B0 Offset: 0x60A8B0 VA: 0x18060C2B0
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Threading.Tasks
internal class SystemThreadingTasks_FutureDebugView<TResult> // TypeDefIndex: 601
{}

// Namespace: System.Threading.Tasks
public class TaskFactory<TResult> // TypeDefIndex: 606
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9D8160 Offset: 0x9D6760 VA: 0x1809D8160
	|-TaskFactory<Nullable<bool>>..ctor
	|-TaskFactory<Nullable<DateTime>>..ctor
	|-TaskFactory<Nullable<DateTimeOffset>>..ctor
	|-TaskFactory<Nullable<Decimal>>..ctor
	|-TaskFactory<Nullable<double>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<char>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<long>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<SceneInstance>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x9D81C0 Offset: 0x9D67C0 VA: 0x1809D81C0
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9D80E0 Offset: 0x9D66E0 VA: 0x1809D80E0
	|-TaskFactory<Nullable<bool>>..ctor
	|-TaskFactory<Nullable<DateTime>>..ctor
	|-TaskFactory<Nullable<DateTimeOffset>>..ctor
	|-TaskFactory<Nullable<Decimal>>..ctor
	|-TaskFactory<Nullable<double>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<char>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<long>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<SceneInstance>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9D6DE0 Offset: 0x9D53E0 VA: 0x1809D6DE0
	|-TaskFactory<Nullable<bool>>.StartNew
	|
	|-RVA: 0x9D7480 Offset: 0x9D5A80 VA: 0x1809D7480
	|-TaskFactory<Nullable<DateTime>>.StartNew
	|
	|-RVA: 0x9D64A0 Offset: 0x9D4AA0 VA: 0x1809D64A0
	|-TaskFactory<Nullable<DateTimeOffset>>.StartNew
	|
	|-RVA: 0x9D6690 Offset: 0x9D4C90 VA: 0x1809D6690
	|-TaskFactory<Nullable<Decimal>>.StartNew
	|
	|-RVA: 0x9D7860 Offset: 0x9D5E60 VA: 0x1809D7860
	|-TaskFactory<Nullable<double>>.StartNew
	|
	|-RVA: 0x9D6FD0 Offset: 0x9D55D0 VA: 0x1809D6FD0
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x9D6A00 Offset: 0x9D5000 VA: 0x1809D6A00
	|-TaskFactory<LocalizedDatabase.TableEntryResult<object, object>>.StartNew
	|
	|-RVA: 0x9D7D00 Offset: 0x9D6300 VA: 0x1809D7D00
	|-TaskFactory<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x9D7670 Offset: 0x9D5C70 VA: 0x1809D7670
	|-TaskFactory<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x9D7EF0 Offset: 0x9D64F0 VA: 0x1809D7EF0
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x9D71C0 Offset: 0x9D57C0 VA: 0x1809D71C0
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x9D6BF0 Offset: 0x9D51F0 VA: 0x1809D6BF0
	|-TaskFactory<char>.StartNew
	|
	|-RVA: 0x9D7B10 Offset: 0x9D6110 VA: 0x1809D7B10
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x9D7A50 Offset: 0x9D6050 VA: 0x1809D7A50
	|-TaskFactory<long>.StartNew
	|
	|-RVA: 0x9D63E0 Offset: 0x9D49E0 VA: 0x1809D63E0
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x9D6880 Offset: 0x9D4E80 VA: 0x1809D6880
	|-TaskFactory<SceneInstance>.StartNew
	|
	|-RVA: 0x9D6940 Offset: 0x9D4F40 VA: 0x1809D6940
	|-TaskFactory<VoidTaskResult>.StartNew
	|
	|-RVA: 0x9D73B0 Offset: 0x9D59B0 VA: 0x1809D73B0
	|-TaskFactory<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CF400 Offset: 0x9CDA00 VA: 0x1809CF400
	|-TaskFactory<Nullable<bool>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9D0070 Offset: 0x9CE670 VA: 0x1809D0070
	|-TaskFactory<Nullable<DateTime>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CEA40 Offset: 0x9CD040 VA: 0x1809CEA40
	|-TaskFactory<Nullable<DateTimeOffset>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CF240 Offset: 0x9CD840 VA: 0x1809CF240
	|-TaskFactory<Nullable<Decimal>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CE8A0 Offset: 0x9CCEA0 VA: 0x1809CE8A0
	|-TaskFactory<Nullable<double>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CEF20 Offset: 0x9CD520 VA: 0x1809CEF20
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CED80 Offset: 0x9CD380 VA: 0x1809CED80
	|-TaskFactory<LocalizedDatabase.TableEntryResult<object, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CFED0 Offset: 0x9CE4D0 VA: 0x1809CFED0
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CF850 Offset: 0x9CDE50 VA: 0x1809CF850
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CFBA0 Offset: 0x9CE1A0 VA: 0x1809CFBA0
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CEC00 Offset: 0x9CD200 VA: 0x1809CEC00
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CF0B0 Offset: 0x9CD6B0 VA: 0x1809CF0B0
	|-TaskFactory<char>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CFD50 Offset: 0x9CE350 VA: 0x1809CFD50
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CE710 Offset: 0x9CCD10 VA: 0x1809CE710
	|-TaskFactory<long>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CFA10 Offset: 0x9CE010 VA: 0x1809CFA10
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x9D0210 Offset: 0x9CE810 VA: 0x1809D0210
	|-TaskFactory<SceneInstance>.FromAsyncCoreLogic
	|
	|-RVA: 0x9D03B0 Offset: 0x9CE9B0 VA: 0x1809D03B0
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x9CF590 Offset: 0x9CDB90 VA: 0x1809CF590
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9D5EC0 Offset: 0x9D44C0 VA: 0x1809D5EC0
	|-TaskFactory<Nullable<bool>>.FromAsync
	|
	|-RVA: 0x9D5F10 Offset: 0x9D4510 VA: 0x1809D5F10
	|-TaskFactory<Nullable<DateTime>>.FromAsync
	|
	|-RVA: 0x9D5F60 Offset: 0x9D4560 VA: 0x1809D5F60
	|-TaskFactory<Nullable<DateTimeOffset>>.FromAsync
	|
	|-RVA: 0x9D5E20 Offset: 0x9D4420 VA: 0x1809D5E20
	|-TaskFactory<Nullable<Decimal>>.FromAsync
	|
	|-RVA: 0x9D6110 Offset: 0x9D4710 VA: 0x1809D6110
	|-TaskFactory<Nullable<double>>.FromAsync
	|
	|-RVA: 0x9D6390 Offset: 0x9D4990 VA: 0x1809D6390
	|-TaskFactory<Nullable<int>>.FromAsync
	|
	|-RVA: 0x9D5FB0 Offset: 0x9D45B0 VA: 0x1809D5FB0
	|-TaskFactory<LocalizedDatabase.TableEntryResult<object, object>>.FromAsync
	|
	|-RVA: 0x9D6250 Offset: 0x9D4850 VA: 0x1809D6250
	|-TaskFactory<ValueTuple<bool, object>>.FromAsync
	|
	|-RVA: 0x9D60C0 Offset: 0x9D46C0 VA: 0x1809D60C0
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsync
	|
	|-RVA: 0x9D6000 Offset: 0x9D4600 VA: 0x1809D6000
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsync
	|
	|-RVA: 0x9D6160 Offset: 0x9D4760 VA: 0x1809D6160
	|-TaskFactory<bool>.FromAsync
	|
	|-RVA: 0x9D6340 Offset: 0x9D4940 VA: 0x1809D6340
	|-TaskFactory<char>.FromAsync
	|
	|-RVA: 0x9D5E70 Offset: 0x9D4470 VA: 0x1809D5E70
	|-TaskFactory<int>.FromAsync
	|
	|-RVA: 0x9D62A0 Offset: 0x9D48A0 VA: 0x1809D62A0
	|-TaskFactory<long>.FromAsync
	|
	|-RVA: 0x9D61B0 Offset: 0x9D47B0 VA: 0x1809D61B0
	|-TaskFactory<object>.FromAsync
	|
	|-RVA: 0x9D6200 Offset: 0x9D4800 VA: 0x1809D6200
	|-TaskFactory<SceneInstance>.FromAsync
	|
	|-RVA: 0x9D62F0 Offset: 0x9D48F0 VA: 0x1809D62F0
	|-TaskFactory<VoidTaskResult>.FromAsync
	|
	|-RVA: 0x9D6050 Offset: 0x9D4650 VA: 0x1809D6050
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9D45C0 Offset: 0x9D2BC0 VA: 0x1809D45C0
	|-TaskFactory<Nullable<bool>>.FromAsyncImpl
	|
	|-RVA: 0x9D2730 Offset: 0x9D0D30 VA: 0x1809D2730
	|-TaskFactory<Nullable<DateTime>>.FromAsyncImpl
	|
	|-RVA: 0x9D5450 Offset: 0x9D3A50 VA: 0x1809D5450
	|-TaskFactory<Nullable<DateTimeOffset>>.FromAsyncImpl
	|
	|-RVA: 0x9D0A10 Offset: 0x9CF010 VA: 0x1809D0A10
	|-TaskFactory<Nullable<Decimal>>.FromAsyncImpl
	|
	|-RVA: 0x9D40D0 Offset: 0x9D26D0 VA: 0x1809D40D0
	|-TaskFactory<Nullable<double>>.FromAsyncImpl
	|
	|-RVA: 0x9D0530 Offset: 0x9CEB30 VA: 0x1809D0530
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x9D5960 Offset: 0x9D3F60 VA: 0x1809D5960
	|-TaskFactory<LocalizedDatabase.TableEntryResult<object, object>>.FromAsyncImpl
	|
	|-RVA: 0x9D4F60 Offset: 0x9D3560 VA: 0x1809D4F60
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncImpl
	|
	|-RVA: 0x9D2C20 Offset: 0x9D1220 VA: 0x1809D2C20
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncImpl
	|
	|-RVA: 0x9D0F20 Offset: 0x9CF520 VA: 0x1809D0F20
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncImpl
	|
	|-RVA: 0x9D4AA0 Offset: 0x9D30A0 VA: 0x1809D4AA0
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x9D3130 Offset: 0x9D1730 VA: 0x1809D3130
	|-TaskFactory<char>.FromAsyncImpl
	|
	|-RVA: 0x9D2270 Offset: 0x9D0870 VA: 0x1809D2270
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x9D18F0 Offset: 0x9CFEF0 VA: 0x1809D18F0
	|-TaskFactory<long>.FromAsyncImpl
	|
	|-RVA: 0x9D1DB0 Offset: 0x9D03B0 VA: 0x1809D1DB0
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x9D3610 Offset: 0x9D1C10 VA: 0x1809D3610
	|-TaskFactory<SceneInstance>.FromAsyncImpl
	|
	|-RVA: 0x9D1430 Offset: 0x9CFA30 VA: 0x1809D1430
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	|
	|-RVA: 0x9D3AD0 Offset: 0x9D20D0 VA: 0x1809D3AD0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60C220 Offset: 0x60A820 VA: 0x18060C220
	|-TaskFactory<object>.FromAsync<object>
	|
	|-RVA: 0x60C0F0 Offset: 0x60A6F0 VA: 0x18060C0F0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B780 Offset: 0x609D80 VA: 0x18060B780
	|-TaskFactory<object>.FromAsyncImpl<object>
	|
	|-RVA: 0x60B300 Offset: 0x609900 VA: 0x18060B300
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object>
	|
	|-RVA: 0x60A840 Offset: 0x608E40 VA: 0x18060A840
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60AE70 Offset: 0x609470 VA: 0x18060AE70
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x60A190 Offset: 0x608790 VA: 0x18060A190
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BDF0 Offset: 0x60A3F0 VA: 0x18060BDF0
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x60BF70 Offset: 0x60A570 VA: 0x18060BF70
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x60BC00 Offset: 0x60A200 VA: 0x18060BC00
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncTrim<object, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Threading.Tasks
public enum TaskStatus // TypeDefIndex: 607
{
	// Fields
	public int value__; // 0x0
	public const TaskStatus Created = 0;
	public const TaskStatus WaitingForActivation = 1;
	public const TaskStatus WaitingToRun = 2;
	public const TaskStatus Running = 3;
	public const TaskStatus WaitingForChildrenToComplete = 4;
	public const TaskStatus RanToCompletion = 5;
	public const TaskStatus Canceled = 6;
	public const TaskStatus Faulted = 7;
}

// Namespace: System.Threading.Tasks
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 612
{
	// Fields
	internal static int s_taskIdCounter; // 0x0
	private int m_taskId; // 0x10
	internal Delegate m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x8
	internal static bool s_asyncDebuggingEnabled; // 0x10
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x18
	[ThreadStatic]
	internal static Task t_currentTask; // 0x80000000
	[ThreadStatic]
	private static StackGuard t_stackGuard; // 0x80000008
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x20
	[CompilerGenerated]
	private static readonly TaskFactory <Factory>k__BackingField; // 0x28
	[CompilerGenerated]
	private static readonly Task <CompletedTask>k__BackingField; // 0x30
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x38
	private static ContextCallback s_ecCallback; // 0x40
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x48
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x50
	private static readonly object s_activeTasksLock; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }

	// Methods

	// RVA: 0x159E3C0 Offset: 0x159C9C0 VA: 0x18159E3C0
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x159E580 Offset: 0x159CB80 VA: 0x18159E580
	internal void .ctor() { }

	// RVA: 0x159E5B0 Offset: 0x159CBB0 VA: 0x18159E5B0
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x159E6F0 Offset: 0x159CCF0 VA: 0x18159E6F0
	public void .ctor(Action action, CancellationToken cancellationToken) { }

	// RVA: 0x159E490 Offset: 0x159CA90 VA: 0x18159E490
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x159D180 Offset: 0x159B780 VA: 0x18159D180
	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x1598000 Offset: 0x1596600 VA: 0x181598000
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x159D090 Offset: 0x159B690 VA: 0x18159D090
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x159D4B0 Offset: 0x159BAB0 VA: 0x18159D4B0
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	// RVA: 0x159D4C0 Offset: 0x159BAC0 VA: 0x18159D4C0
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x159D5B0 Offset: 0x159BBB0 VA: 0x18159D5B0
	internal bool TrySetException(object exceptionObject) { }

	// RVA: 0x159EF60 Offset: 0x159D560 VA: 0x18159EF60
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x5941A0 Offset: 0x5927A0 VA: 0x1805941A0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x1598390 Offset: 0x1596990 VA: 0x181598390
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x15982D0 Offset: 0x15968D0 VA: 0x1815982D0
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x159C8E0 Offset: 0x159AEE0 VA: 0x18159C8E0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x159B8F0 Offset: 0x1599EF0 VA: 0x18159B8F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x159EF10 Offset: 0x159D510 VA: 0x18159EF10
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x159EF40 Offset: 0x159D540 VA: 0x18159EF40 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x159EF40 Offset: 0x159D540 VA: 0x18159EF40
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x159B950 Offset: 0x1599F50 VA: 0x18159B950
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x159B8D0 Offset: 0x1599ED0 VA: 0x18159B8D0
	internal bool MarkStarted() { }

	// RVA: 0x1597A00 Offset: 0x1596000 VA: 0x181597A00
	internal void AddNewChild() { }

	// RVA: 0x1599780 Offset: 0x1597D80 VA: 0x181599780
	internal void DisregardChild() { }

	// RVA: 0x159B220 Offset: 0x1599820 VA: 0x18159B220
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions) { }

	// RVA: 0x159EC60 Offset: 0x159D260 VA: 0x18159EC60
	public int get_Id() { }

	// RVA: 0x159ED00 Offset: 0x159D300 VA: 0x18159ED00
	internal static Task get_InternalCurrent() { }

	// RVA: 0x159B190 Offset: 0x1599790 VA: 0x18159B190
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x159EA90 Offset: 0x159D090 VA: 0x18159EA90
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x159EBC0 Offset: 0x159D1C0 VA: 0x18159EBC0
	public AggregateException get_Exception() { }

	// RVA: 0x159EFB0 Offset: 0x159D5B0 VA: 0x18159EFB0
	public TaskStatus get_Status() { }

	// RVA: 0x159ED50 Offset: 0x159D350 VA: 0x18159ED50
	public bool get_IsCanceled() { }

	// RVA: 0x159EDA0 Offset: 0x159D3A0 VA: 0x18159EDA0
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x1599930 Offset: 0x1597F30 VA: 0x181599930
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x1599840 Offset: 0x1597E40 VA: 0x181599840
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x159E7A0 Offset: 0x159CDA0 VA: 0x18159E7A0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x159ED80 Offset: 0x159D380 VA: 0x18159ED80
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x159EE50 Offset: 0x159D450 VA: 0x18159EE50 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x159B880 Offset: 0x1599E80 VA: 0x18159B880
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x159EE20 Offset: 0x159D420 VA: 0x18159EE20
	public bool get_IsCompletedSuccessfully() { }

	// RVA: 0x159EA40 Offset: 0x159D040 VA: 0x18159EA40
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x159CE60 Offset: 0x159B460 VA: 0x18159CE60 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	[CompilerGenerated]
	// RVA: 0x159EC10 Offset: 0x159D210 VA: 0x18159EC10
	public static TaskFactory get_Factory() { }

	[CompilerGenerated]
	// RVA: 0x159E9F0 Offset: 0x159CFF0 VA: 0x18159E9F0
	public static Task get_CompletedTask() { }

	// RVA: 0x159E850 Offset: 0x159CE50 VA: 0x18159E850
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x159EB50 Offset: 0x159D150 VA: 0x18159EB50
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x159EEF0 Offset: 0x159D4F0 VA: 0x18159EEF0
	public bool get_IsFaulted() { }

	// RVA: 0x159E7D0 Offset: 0x159CDD0 VA: 0x18159E7D0
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x159F040 Offset: 0x159D640 VA: 0x18159F040
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x1599720 Offset: 0x1597D20 VA: 0x181599720 Slot: 10
	public void Dispose() { }

	// RVA: 0x15995B0 Offset: 0x1597BB0 VA: 0x1815995B0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x159C570 Offset: 0x159AB70 VA: 0x18159C570
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x1597630 Offset: 0x1595C30 VA: 0x181597630
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1597310 Offset: 0x1595910 VA: 0x181597310
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x159AC00 Offset: 0x1599200 VA: 0x18159AC00
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x159A9E0 Offset: 0x1598FE0 VA: 0x18159A9E0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x159A9A0 Offset: 0x1598FA0 VA: 0x18159A9A0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x159D460 Offset: 0x159BA60 VA: 0x18159D460
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x159D6B0 Offset: 0x159BCB0 VA: 0x18159D6B0
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x159EED0 Offset: 0x159D4D0 VA: 0x18159EED0
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x159EEB0 Offset: 0x159D4B0 VA: 0x18159EEB0
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x159A680 Offset: 0x1598C80 VA: 0x18159A680
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x159A540 Offset: 0x1598B40 VA: 0x18159A540
	internal void FinishStageTwo() { }

	// RVA: 0x159A490 Offset: 0x1598A90 VA: 0x18159A490
	internal void FinishStageThree() { }

	// RVA: 0x159B980 Offset: 0x1599F80 VA: 0x18159B980
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1597640 Offset: 0x1595C40 VA: 0x181597640
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x1599E00 Offset: 0x1598400 VA: 0x181599E00
	private void Execute() { }

	// RVA: 0x159D080 Offset: 0x159B680 VA: 0x18159D080 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1599A30 Offset: 0x1598030 VA: 0x181599A30
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1599E40 Offset: 0x1598440 VA: 0x181599E40
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x159AF10 Offset: 0x1599510 VA: 0x18159AF10 Slot: 13
	internal virtual void InnerInvoke() { }

	// RVA: 0x159AE00 Offset: 0x1599400 VA: 0x18159AE00
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x15948E0 Offset: 0x1592EE0 VA: 0x1815948E0
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x1598520 Offset: 0x1596B20 VA: 0x181598520
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x159C720 Offset: 0x159AD20 VA: 0x18159C720
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x159D7C0 Offset: 0x159BDC0 VA: 0x18159D7C0
	public void Wait() { }

	// RVA: 0x159D8C0 Offset: 0x159BEC0 VA: 0x18159D8C0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x159DF10 Offset: 0x159C510 VA: 0x18159DF10
	private bool WrappedTryRunInline() { }

	// RVA: 0x159B3C0 Offset: 0x15999C0 VA: 0x18159B3C0
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x159C9B0 Offset: 0x159AFB0 VA: 0x18159C9B0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x159CD00 Offset: 0x159B300 VA: 0x18159CD00
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x159AFB0 Offset: 0x15995B0 VA: 0x18159AFB0
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x159BCB0 Offset: 0x159A2B0 VA: 0x18159BCB0
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x159BC20 Offset: 0x159A220 VA: 0x18159BC20
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x159BB60 Offset: 0x159A160 VA: 0x18159BB60
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1598450 Offset: 0x1596A50 VA: 0x181598450
	internal void CancellationCleanupLogic() { }

	// RVA: 0x159C6F0 Offset: 0x159ACF0 VA: 0x18159C6F0
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1599EC0 Offset: 0x15984C0 VA: 0x181599EC0
	internal void FinishContinuations() { }

	// RVA: 0x159B890 Offset: 0x1599E90 VA: 0x18159B890
	private void LogFinishCompletionNotification() { }

	// RVA: 0x15987D0 Offset: 0x1596DD0 VA: 0x1815987D0
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x15988D0 Offset: 0x1596ED0 VA: 0x1815988D0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x15987A0 Offset: 0x1596DA0 VA: 0x1815987A0
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1598B70 Offset: 0x1597170 VA: 0x181598B70
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x1598E10 Offset: 0x1597410 VA: 0x181598E10
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1598540 Offset: 0x1596B40 VA: 0x181598540
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1597220 Offset: 0x1595820 VA: 0x181597220
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1597290 Offset: 0x1595890 VA: 0x181597290
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1597B00 Offset: 0x1596100 VA: 0x181597B00
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1597DE0 Offset: 0x15963E0 VA: 0x181597DE0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x159BD70 Offset: 0x159A370 VA: 0x18159BD70
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C30B0 Offset: 0x7C16B0 VA: 0x1807C30B0
	|-Task.FromResult<Nullable<bool>>
	|
	|-RVA: 0x7C3190 Offset: 0x7C1790 VA: 0x1807C3190
	|-Task.FromResult<Nullable<DateTime>>
	|
	|-RVA: 0x7C2FA0 Offset: 0x7C15A0 VA: 0x1807C2FA0
	|-Task.FromResult<Nullable<DateTimeOffset>>
	|
	|-RVA: 0x7C2F10 Offset: 0x7C1510 VA: 0x1807C2F10
	|-Task.FromResult<Nullable<Decimal>>
	|
	|-RVA: 0x7C3030 Offset: 0x7C1630 VA: 0x1807C3030
	|-Task.FromResult<Nullable<double>>
	|
	|-RVA: 0x7C3120 Offset: 0x7C1720 VA: 0x1807C3120
	|-Task.FromResult<Nullable<int>>
	|
	|-RVA: 0x7C2D30 Offset: 0x7C1330 VA: 0x1807C2D30
	|-Task.FromResult<bool>
	|
	|-RVA: 0x7C2EA0 Offset: 0x7C14A0 VA: 0x1807C2EA0
	|-Task.FromResult<int>
	|
	|-RVA: 0x7C3210 Offset: 0x7C1810 VA: 0x1807C3210
	|-Task.FromResult<object>
	|
	|-RVA: 0x7C2DA0 Offset: 0x7C13A0 VA: 0x1807C2DA0
	|-Task.FromResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x159A940 Offset: 0x1598F40 VA: 0x18159A940
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C2B90 Offset: 0x7C1190 VA: 0x1807C2B90
	|-Task.FromException<int>
	|
	|-RVA: 0x7C2C60 Offset: 0x7C1260 VA: 0x1807C2C60
	|-Task.FromException<VoidTaskResult>
	|
	|-RVA: 0x7C2AC0 Offset: 0x7C10C0 VA: 0x1807C2AC0
	|-Task.FromException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x159A850 Offset: 0x1598E50 VA: 0x18159A850
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	// RVA: 0x159A800 Offset: 0x1598E00 VA: 0x18159A800
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C2390 Offset: 0x7C0990 VA: 0x1807C2390
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x7C2720 Offset: 0x7C0D20 VA: 0x1807C2720
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x7C28F0 Offset: 0x7C0EF0 VA: 0x1807C28F0
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x7C2560 Offset: 0x7C0B60 VA: 0x1807C2560
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C2250 Offset: 0x7C0850 VA: 0x1807C2250
	|-Task.FromCanceled<int>
	|
	|-RVA: 0x7C21E0 Offset: 0x7C07E0 VA: 0x1807C21E0
	|-Task.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C2820 Offset: 0x7C0E20 VA: 0x1807C2820
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x7C29F0 Offset: 0x7C0FF0 VA: 0x1807C29F0
	|-Task.FromCancellation<VoidTaskResult>
	|
	|-RVA: 0x7C2490 Offset: 0x7C0A90 VA: 0x1807C2490
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x159C100 Offset: 0x159A700 VA: 0x18159C100
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C3600 Offset: 0x7C1C00 VA: 0x1807C3600
	|-Task.Run<int>
	|
	|-RVA: 0x7C36D0 Offset: 0x7C1CD0 VA: 0x1807C36D0
	|-Task.Run<object>
	|
	|-RVA: 0x7C32F0 Offset: 0x7C18F0 VA: 0x1807C32F0
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x159C2E0 Offset: 0x159A8E0 VA: 0x18159C2E0
	public static Task Run(Func<Task> function) { }

	// RVA: 0x159C330 Offset: 0x159A930 VA: 0x18159C330
	public static Task Run(Func<Task> function, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C37A0 Offset: 0x7C1DA0 VA: 0x1807C37A0
	|-Task.Run<object>
	|
	|-RVA: 0x7C3280 Offset: 0x7C1880 VA: 0x1807C3280
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C3810 Offset: 0x7C1E10 VA: 0x1807C3810
	|-Task.Run<object>
	|
	|-RVA: 0x7C33C0 Offset: 0x7C19C0 VA: 0x1807C33C0
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1598F70 Offset: 0x1597570 VA: 0x181598F70
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1598FC0 Offset: 0x15975C0 VA: 0x181598FC0
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x159DCF0 Offset: 0x159C2F0 VA: 0x18159DCF0
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x159DA30 Offset: 0x159C030 VA: 0x18159DA30
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	[FriendAccessAllowed]
	// RVA: 0x1597EC0 Offset: 0x15964C0 VA: 0x181597EC0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowed]
	// RVA: 0x159BFE0 Offset: 0x159A5E0 VA: 0x18159BFE0
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }

	// RVA: 0x1599BE0 Offset: 0x15981E0 VA: 0x181599BE0
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x159DFB0 Offset: 0x159C5B0 VA: 0x18159DFB0
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 613
{
	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x158D160 Offset: 0x158B760 VA: 0x18158D160 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }
}

// Namespace: System.Threading.Tasks
internal class SystemThreadingTasks_TaskDebugView // TypeDefIndex: 614
{}

// Namespace: System.Threading.Tasks
[Flags]
public enum TaskCreationOptions // TypeDefIndex: 615
{
	// Fields
	public int value__; // 0x0
	public const TaskCreationOptions None = 0;
	public const TaskCreationOptions PreferFairness = 1;
	public const TaskCreationOptions LongRunning = 2;
	public const TaskCreationOptions AttachedToParent = 4;
	public const TaskCreationOptions DenyChildAttach = 8;
	public const TaskCreationOptions HideScheduler = 16;
	public const TaskCreationOptions RunContinuationsAsynchronously = 64;
}

// Namespace: System.Threading.Tasks
[Flags]
internal enum InternalTaskOptions // TypeDefIndex: 616
{
	// Fields
	public int value__; // 0x0
	public const InternalTaskOptions None = 0;
	public const InternalTaskOptions InternalOptionsMask = 65280;
	public const InternalTaskOptions ContinuationTask = 512;
	public const InternalTaskOptions PromiseTask = 1024;
	public const InternalTaskOptions LazyCancellation = 4096;
	public const InternalTaskOptions QueuedByRuntime = 8192;
	public const InternalTaskOptions DoNotDispose = 16384;
}

// Namespace: System.Threading.Tasks
[Flags]
public enum TaskContinuationOptions // TypeDefIndex: 617
{
	// Fields
	public int value__; // 0x0
	public const TaskContinuationOptions None = 0;
	public const TaskContinuationOptions PreferFairness = 1;
	public const TaskContinuationOptions LongRunning = 2;
	public const TaskContinuationOptions AttachedToParent = 4;
	public const TaskContinuationOptions DenyChildAttach = 8;
	public const TaskContinuationOptions HideScheduler = 16;
	public const TaskContinuationOptions LazyCancellation = 32;
	public const TaskContinuationOptions RunContinuationsAsynchronously = 64;
	public const TaskContinuationOptions NotOnRanToCompletion = 65536;
	public const TaskContinuationOptions NotOnFaulted = 131072;
	public const TaskContinuationOptions NotOnCanceled = 262144;
	public const TaskContinuationOptions OnlyOnRanToCompletion = 393216;
	public const TaskContinuationOptions OnlyOnFaulted = 327680;
	public const TaskContinuationOptions OnlyOnCanceled = 196608;
	public const TaskContinuationOptions ExecuteSynchronously = 524288;
}

// Namespace: System.Threading.Tasks
internal class StackGuard // TypeDefIndex: 618
{
	// Fields
	private int m_inliningDepth; // 0x10

	// Methods

	// RVA: 0x1593BD0 Offset: 0x15921D0 VA: 0x181593BD0
	internal bool TryBeginInliningScope() { }

	// RVA: 0x1593BC0 Offset: 0x15921C0 VA: 0x181593BC0
	internal void EndInliningScope() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Threading.Tasks
internal struct VoidTaskResult // TypeDefIndex: 619
{}

// Namespace: System.Threading.Tasks
internal interface ITaskCompletionAction // TypeDefIndex: 620
{
	// Properties
	public abstract bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Invoke(Task completingTask);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_InvokeMayRunArbitraryCode();
}

// Namespace: System.Threading.Tasks
internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 622
{
	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACE9E0 Offset: 0xACCFE0 VA: 0x180ACE9E0
	|-UnwrapPromise<object>..ctor
	|
	|-RVA: 0xACED00 Offset: 0xACD300 VA: 0x180ACED00
	|-UnwrapPromise<VoidTaskResult>..ctor
	|
	|-RVA: 0xACEB30 Offset: 0xACD130 VA: 0x180ACEB30
	|-UnwrapPromise<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACD5A0 Offset: 0xACBBA0 VA: 0x180ACD5A0
	|-UnwrapPromise<object>.Invoke
	|
	|-RVA: 0xACD700 Offset: 0xACBD00 VA: 0x180ACD700
	|-UnwrapPromise<VoidTaskResult>.Invoke
	|
	|-RVA: 0xACD470 Offset: 0xACBA70 VA: 0x180ACD470
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACD2F0 Offset: 0xACB8F0 VA: 0x180ACD2F0
	|-UnwrapPromise<object>.InvokeCore
	|
	|-RVA: 0xACD420 Offset: 0xACBA20 VA: 0x180ACD420
	|-UnwrapPromise<VoidTaskResult>.InvokeCore
	|
	|-RVA: 0xACD340 Offset: 0xACB940 VA: 0x180ACD340
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACCD70 Offset: 0xACB370 VA: 0x180ACCD70
	|-UnwrapPromise<object>.InvokeCoreAsync
	|
	|-RVA: 0xACCF40 Offset: 0xACB540 VA: 0x180ACCF40
	|-UnwrapPromise<VoidTaskResult>.InvokeCoreAsync
	|
	|-RVA: 0xACD110 Offset: 0xACB710 VA: 0x180ACD110
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACD860 Offset: 0xACBE60 VA: 0x180ACD860
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	|
	|-RVA: 0xACDC10 Offset: 0xACC210 VA: 0x180ACDC10
	|-UnwrapPromise<VoidTaskResult>.ProcessCompletedOuterTask
	|
	|-RVA: 0xACDA20 Offset: 0xACC020 VA: 0x180ACDA20
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACE3E0 Offset: 0xACC9E0 VA: 0x180ACE3E0
	|-UnwrapPromise<object>.TrySetFromTask
	|
	|-RVA: 0xACE6E0 Offset: 0xACCCE0 VA: 0x180ACE6E0
	|-UnwrapPromise<VoidTaskResult>.TrySetFromTask
	|
	|-RVA: 0xACDFC0 Offset: 0xACC5C0 VA: 0x180ACDFC0
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACDDD0 Offset: 0xACC3D0 VA: 0x180ACDDD0
	|-UnwrapPromise<object>.ProcessInnerTask
	|
	|-RVA: 0xACDE60 Offset: 0xACC460 VA: 0x180ACDE60
	|-UnwrapPromise<VoidTaskResult>.ProcessInnerTask
	|
	|-RVA: 0xACDEF0 Offset: 0xACC4F0 VA: 0x180ACDEF0
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessInnerTask
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-UnwrapPromise<object>.get_InvokeMayRunArbitraryCode
	|-UnwrapPromise<VoidTaskResult>.get_InvokeMayRunArbitraryCode
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.get_InvokeMayRunArbitraryCode
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromTask : Task // TypeDefIndex: 623
{
	// Fields
	private Task m_antecedent; // 0x50

	// Methods

	// RVA: 0x158D3C0 Offset: 0x158B9C0 VA: 0x18158D3C0
	public void .ctor(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	// RVA: 0x158D2C0 Offset: 0x158B8C0 VA: 0x18158D2C0 Slot: 13
	internal override void InnerInvoke() { }
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 624
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2FF50 Offset: 0xD2E550 VA: 0x180D2FF50
	|-ContinuationTaskFromResultTask<Nullable<bool>>..ctor
	|
	|-RVA: 0xD30500 Offset: 0xD2EB00 VA: 0x180D30500
	|-ContinuationTaskFromResultTask<Nullable<DateTime>>..ctor
	|
	|-RVA: 0xD2FDB0 Offset: 0xD2E3B0 VA: 0x180D2FDB0
	|-ContinuationTaskFromResultTask<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0xD2FB40 Offset: 0xD2E140 VA: 0x180D2FB40
	|-ContinuationTaskFromResultTask<Nullable<Decimal>>..ctor
	|
	|-RVA: 0xD30430 Offset: 0xD2EA30 VA: 0x180D30430
	|-ContinuationTaskFromResultTask<Nullable<double>>..ctor
	|
	|-RVA: 0xD30770 Offset: 0xD2ED70 VA: 0x180D30770
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0xD2FC10 Offset: 0xD2E210 VA: 0x180D2FC10
	|-ContinuationTaskFromResultTask<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0xD300F0 Offset: 0xD2E6F0 VA: 0x180D300F0
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xD30290 Offset: 0xD2E890 VA: 0x180D30290
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xD2FCE0 Offset: 0xD2E2E0 VA: 0x180D2FCE0
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xD301C0 Offset: 0xD2E7C0 VA: 0x180D301C0
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0xD30360 Offset: 0xD2E960 VA: 0x180D30360
	|-ContinuationTaskFromResultTask<char>..ctor
	|
	|-RVA: 0xD306A0 Offset: 0xD2ECA0 VA: 0x180D306A0
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0xD2FE80 Offset: 0xD2E480 VA: 0x180D2FE80
	|-ContinuationTaskFromResultTask<long>..ctor
	|
	|-RVA: 0xD30020 Offset: 0xD2E620 VA: 0x180D30020
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0xD305D0 Offset: 0xD2EBD0 VA: 0x180D305D0
	|-ContinuationTaskFromResultTask<SceneInstance>..ctor
	|
	|-RVA: 0xD30910 Offset: 0xD2EF10 VA: 0x180D30910
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	|
	|-RVA: 0xD30840 Offset: 0xD2EE40 VA: 0x180D30840
	|-ContinuationTaskFromResultTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2F930 Offset: 0xD2DF30 VA: 0x180D2F930
	|-ContinuationTaskFromResultTask<Nullable<bool>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<DateTime>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<DateTimeOffset>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Decimal>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<double>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<int>>.InnerInvoke
	|-ContinuationTaskFromResultTask<LocalizedDatabase.TableEntryResult<object, object>>.InnerInvoke
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>.InnerInvoke
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>.InnerInvoke
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|-ContinuationTaskFromResultTask<bool>.InnerInvoke
	|-ContinuationTaskFromResultTask<char>.InnerInvoke
	|-ContinuationTaskFromResultTask<int>.InnerInvoke
	|-ContinuationTaskFromResultTask<long>.InnerInvoke
	|-ContinuationTaskFromResultTask<object>.InnerInvoke
	|-ContinuationTaskFromResultTask<SceneInstance>.InnerInvoke
	|-ContinuationTaskFromResultTask<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0xD2FA20 Offset: 0xD2E020 VA: 0x180D2FA20
	|-ContinuationTaskFromResultTask<__Il2CppFullySharedGenericType>.InnerInvoke
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 625
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2F850 Offset: 0xD2DE50 VA: 0x180D2F850
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>..ctor
	|
	|-RVA: 0xD2F660 Offset: 0xD2DC60 VA: 0x180D2F660
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>..ctor
	|
	|-RVA: 0xD2F740 Offset: 0xD2DD40 VA: 0x180D2F740
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2F380 Offset: 0xD2D980 VA: 0x180D2F380
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>.InnerInvoke
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0xD2F480 Offset: 0xD2DA80 VA: 0x180D2F480
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InnerInvoke
	*/
}

// Namespace: System.Threading.Tasks
internal abstract class TaskContinuation // TypeDefIndex: 626
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	// RVA: 0x15949E0 Offset: 0x1592FE0 VA: 0x1815949E0
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Threading.Tasks
internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 627
{
	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x1593D40 Offset: 0x1592340 VA: 0x181593D40
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x1593C00 Offset: 0x1592200 VA: 0x181593C00 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }
}

// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 629
{
	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x1594210 Offset: 0x1592810 VA: 0x181594210
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	// RVA: 0x1593F90 Offset: 0x1592590 VA: 0x181593F90 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x1593EF0 Offset: 0x15924F0 VA: 0x181593EF0
	private static void PostAction(object state) { }

	// RVA: 0x1593E10 Offset: 0x1592410 VA: 0x181593E10
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x1594140 Offset: 0x1592740 VA: 0x181594140
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 631
{
	// Fields
	private readonly TaskScheduler m_scheduler; // 0x20

	// Methods

	// RVA: 0x1594210 Offset: 0x1592810 VA: 0x181594210
	internal void .ctor(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	// RVA: 0x1596060 Offset: 0x1594660 VA: 0x181596060 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }
}

// Namespace: System.Threading.Tasks
internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 632
{
	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x158CD20 Offset: 0x158B320 VA: 0x18158CD20
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x158C6E0 Offset: 0x158ACE0 VA: 0x18158C6E0
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x158CAE0 Offset: 0x158B0E0 VA: 0x18158CAE0 Slot: 4
	internal override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x158CDB0 Offset: 0x158B3B0 VA: 0x18158CDB0
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x158CBA0 Offset: 0x158B1A0 VA: 0x18158CBA0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x158C870 Offset: 0x158AE70 VA: 0x18158C870
	private static void InvokeAction(object state) { }

	// RVA: 0x158C7C0 Offset: 0x158ADC0 VA: 0x18158C7C0
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x158C8E0 Offset: 0x158AEE0 VA: 0x18158C8E0
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x158C9D0 Offset: 0x158AFD0 VA: 0x18158C9D0
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x158CC90 Offset: 0x158B290 VA: 0x18158CC90
	internal static void UnsafeScheduleAction(Action action) { }

	// RVA: 0x158CC40 Offset: 0x158B240 VA: 0x18158CC40
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public void MarkAborted(ThreadAbortException e) { }
}

// Namespace: System.Threading.Tasks
internal class TaskExceptionHolder // TypeDefIndex: 633
{
	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private readonly Task m_task; // 0x10
	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(Task task) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x1595220 Offset: 0x1593820 VA: 0x181595220 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1595710 Offset: 0x1593D10 VA: 0x181595710
	internal bool get_ContainsFaultList() { }

	// RVA: 0x1594F20 Offset: 0x1593520 VA: 0x181594F20
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x15955D0 Offset: 0x1593BD0 VA: 0x1815955D0
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x1594AE0 Offset: 0x15930E0 VA: 0x181594AE0
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x1595560 Offset: 0x1593B60 VA: 0x181595560
	private void MarkAsUnhandled() { }

	// RVA: 0x15954E0 Offset: 0x1593AE0 VA: 0x1815954E0
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x1595030 Offset: 0x1593630 VA: 0x181595030
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x1595410 Offset: 0x1593A10 VA: 0x181595410
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15956D0 Offset: 0x1593CD0 VA: 0x1815956D0
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
public class TaskFactory // TypeDefIndex: 635
{
	// Fields
	private readonly CancellationToken m_defaultCancellationToken; // 0x10
	private readonly TaskScheduler m_defaultScheduler; // 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; // 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x1595E30 Offset: 0x1594430 VA: 0x181595E30
	public void .ctor() { }

	// RVA: 0x1595E80 Offset: 0x1594480 VA: 0x181595E80
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1595730 Offset: 0x1593D30 VA: 0x181595730
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: 0x1595C60 Offset: 0x1594260 VA: 0x181595C60
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C1BE0 Offset: 0x7C01E0 VA: 0x1807C1BE0
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0x7C1A70 Offset: 0x7C0070 VA: 0x1807C1A70
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C19B0 Offset: 0x7BFFB0 VA: 0x1807C19B0
	|-TaskFactory.StartNew<bool>
	|
	|-RVA: 0x7C1C90 Offset: 0x7C0290 VA: 0x1807C1C90
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0x7C1B20 Offset: 0x7C0120 VA: 0x1807C1B20
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C1910 Offset: 0x7BFF10 VA: 0x1807C1910
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0x7C1540 Offset: 0x7BFB40 VA: 0x1807C1540
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C18A0 Offset: 0x7BFEA0 VA: 0x1807C18A0
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0x7C1660 Offset: 0x7BFC60 VA: 0x1807C1660
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C17F0 Offset: 0x7BFDF0 VA: 0x1807C17F0
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0x7C13A0 Offset: 0x7BF9A0 VA: 0x1807C13A0
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C1780 Offset: 0x7BFD80 VA: 0x1807C1780
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0x7C11F0 Offset: 0x7BF7F0 VA: 0x1807C11F0
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15957A0 Offset: 0x1593DA0 VA: 0x1815957A0
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	// RVA: 0x1595A10 Offset: 0x1594010 VA: 0x181595A10
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x15958D0 Offset: 0x1593ED0 VA: 0x1815958D0
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }
}

// Namespace: System.Threading.Tasks
[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
public abstract class TaskScheduler // TypeDefIndex: 637
{
	// Fields
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x0
	internal static int s_taskSchedulerIdCounter; // 0x8
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x10
	private static readonly Lock _unobservedTaskExceptionLockObject; // 0x18

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0x1596690 Offset: 0x1594C90 VA: 0x181596690
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1596B00 Offset: 0x1595100 VA: 0x181596B00
	public static TaskScheduler get_Default() { }

	// RVA: 0x1596A60 Offset: 0x1595060 VA: 0x181596A60
	public static TaskScheduler get_Current() { }

	// RVA: 0x1596BF0 Offset: 0x15951F0 VA: 0x181596BF0
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x1596B50 Offset: 0x1595150 VA: 0x181596B50
	public int get_Id() { }

	// RVA: 0x1596550 Offset: 0x1594B50 VA: 0x181596550
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x1596960 Offset: 0x1594F60 VA: 0x181596960
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
public class UnobservedTaskExceptionEventArgs : EventArgs // TypeDefIndex: 638
{
	// Fields
	private AggregateException m_exception; // 0x10
	internal bool m_observed; // 0x18

	// Methods

	// RVA: 0x15A3730 Offset: 0x15A1D30 VA: 0x1815A3730
	public void .ctor(AggregateException exception) { }
}

// Namespace: System.Threading.Tasks
internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 640
{
	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x159FB30 Offset: 0x159E130 VA: 0x18159FB30
	internal void .ctor() { }

	// RVA: 0x159F6E0 Offset: 0x159DCE0 VA: 0x18159F6E0 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x159F990 Offset: 0x159DF90 VA: 0x18159F990 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x159F980 Offset: 0x159DF80 VA: 0x18159F980 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x159F6C0 Offset: 0x159DCC0 VA: 0x18159F6C0 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x159FA60 Offset: 0x159E060 VA: 0x18159FA60
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal enum CausalityTraceLevel // TypeDefIndex: 641
{
	// Fields
	public int value__; // 0x0
	public const CausalityTraceLevel Required = 0;
	public const CausalityTraceLevel Important = 1;
	public const CausalityTraceLevel Verbose = 2;
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal enum AsyncCausalityStatus // TypeDefIndex: 642
{
	// Fields
	public int value__; // 0x0
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;
}

// Namespace: System.Threading.Tasks
internal enum CausalityRelation // TypeDefIndex: 643
{
	// Fields
	public int value__; // 0x0
	public const CausalityRelation AssignDelegate = 0;
	public const CausalityRelation Join = 1;
	public const CausalityRelation Choice = 2;
	public const CausalityRelation Cancel = 3;
	public const CausalityRelation Error = 4;
}

// Namespace: System.Threading.Tasks
internal enum CausalitySynchronousWork // TypeDefIndex: 644
{
	// Fields
	public int value__; // 0x0
	public const CausalitySynchronousWork CompletionNotification = 0;
	public const CausalitySynchronousWork ProgressNotification = 1;
	public const CausalitySynchronousWork Execution = 2;
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal static class AsyncCausalityTracer // TypeDefIndex: 645
{
	// Properties
	[FriendAccessAllowed]
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowed]
	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowed]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowed]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }
}

