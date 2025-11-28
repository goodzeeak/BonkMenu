// Namespace: System.Threading.Tasks.Sources
[Flags]
public enum ValueTaskSourceOnCompletedFlags // TypeDefIndex: 646
{
	// Fields
	public int value__; // 0x0
	public const ValueTaskSourceOnCompletedFlags None = 0;
	public const ValueTaskSourceOnCompletedFlags UseSchedulingContext = 1;
	public const ValueTaskSourceOnCompletedFlags FlowExecutionContext = 2;
}

// Namespace: System.Threading.Tasks.Sources
public enum ValueTaskSourceStatus // TypeDefIndex: 647
{
	// Fields
	public int value__; // 0x0
	public const ValueTaskSourceStatus Pending = 0;
	public const ValueTaskSourceStatus Succeeded = 1;
	public const ValueTaskSourceStatus Faulted = 2;
	public const ValueTaskSourceStatus Canceled = 3;
}

// Namespace: System.Threading.Tasks.Sources
public interface IValueTaskSource // TypeDefIndex: 648
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetResult(short token);
}

// Namespace: System.Threading.Tasks.Sources
public interface IValueTaskSource<TResult> // TypeDefIndex: 649
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult GetResult(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetResult
	*/
}

