// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface ICachable // TypeDefIndex: 12730
{
	// Properties
	public abstract IOperationCacheKey Key { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOperationCacheKey get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Key(IOperationCacheKey value);
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface IAsyncOperation // TypeDefIndex: 12731
{
	// Properties
	public abstract Type ResultType { get; }
	public abstract int Version { get; }
	public abstract string DebugName { get; }
	public abstract int ReferenceCount { get; }
	public abstract float PercentComplete { get; }
	public abstract AsyncOperationStatus Status { get; }
	public abstract Exception OperationException { get; }
	public abstract bool IsDone { get; }
	public abstract Action<IAsyncOperation> OnDestroy { set; }
	public abstract bool IsRunning { get; }
	public abstract Task<object> Task { get; }
	public abstract AsyncOperationHandle Handle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetResultAsObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_ResultType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_DebugName();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DecrementReferenceCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void IncrementReferenceCount();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_ReferenceCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_PercentComplete();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DownloadStatus GetDownloadStatus(HashSet<object> visited);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract AsyncOperationStatus get_Status();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Exception get_OperationException();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsDone();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_OnDestroy(Action<IAsyncOperation> value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void GetDependencies(List<AsyncOperationHandle> deps);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsRunning();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void add_CompletedTypeless(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void remove_CompletedTypeless(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void add_Destroyed(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void remove_Destroyed(Action<AsyncOperationHandle> value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void InvokeCompletionEvent();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Task<object> get_Task();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract AsyncOperationHandle get_Handle();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WaitForCompletion();
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public abstract class AsyncOperationBase<TObject> : IAsyncOperation // TypeDefIndex: 12734
{
	// Fields
	[CompilerGenerated]
	private TObject <Result>k__BackingField; // 0x0
	private int m_referenceCount; // 0x0
	internal AsyncOperationStatus m_Status; // 0x0
	internal Exception m_Error; // 0x0
	internal ResourceManager m_RM; // 0x0
	internal int m_Version; // 0x0
	private DelegateList<AsyncOperationHandle> m_DestroyedAction; // 0x0
	private DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT; // 0x0
	private Action<IAsyncOperation> m_OnDestroyAction; // 0x0
	private Action<AsyncOperationHandle> m_dependencyCompleteAction; // 0x0
	protected internal bool HasExecuted; // 0x0
	[CompilerGenerated]
	private Action Executed; // 0x0
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; // 0x0
	private TaskCompletionSource<TObject> m_taskCompletionSource; // 0x0
	private TaskCompletionSource<object> m_taskCompletionSourceTypeless; // 0x0
	private bool m_InDeferredCallbackQueue; // 0x0
	private DelegateList<float> m_UpdateCallbacks; // 0x0
	private Action<float> m_UpdateCallback; // 0x0

	// Properties
	protected virtual float Progress { get; }
	protected virtual string DebugName { get; }
	public TObject Result { get; set; }
	internal int Version { get; }
	internal bool CompletedEventHasListeners { get; }
	internal bool DestroyedEventHasListeners { get; }
	internal Action<IAsyncOperation> OnDestroy { set; }
	protected internal int ReferenceCount { get; }
	public bool IsRunning { get; set; }
	internal Task<TObject> Task { get; }
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Task { get; }
	internal AsyncOperationStatus Status { get; }
	internal Exception OperationException { get; set; }
	internal object Current { get; }
	internal bool IsDone { get; }
	internal float PercentComplete { get; }
	internal AsyncOperationHandle<TObject> Handle { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Version { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ReferenceCount { get; }
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.PercentComplete { get; }
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Status { get; }
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OperationException { get; }
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IsDone { get; }
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Handle { get; }
	private Action<IAsyncOperation> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OnDestroy { set; }
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DebugName { get; }
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ResultType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void Execute();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.Destroy
	|-AsyncOperationBase<bool>.Destroy
	|-AsyncOperationBase<long>.Destroy
	|-AsyncOperationBase<object>.Destroy
	|-AsyncOperationBase<SceneInstance>.Destroy
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected virtual float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Progress
	|-AsyncOperationBase<bool>.get_Progress
	|-AsyncOperationBase<long>.get_Progress
	|-AsyncOperationBase<object>.get_Progress
	|-AsyncOperationBase<SceneInstance>.get_Progress
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected virtual string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCF890 Offset: 0xBCDE90 VA: 0x180BCF890
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_DebugName
	|-AsyncOperationBase<bool>.get_DebugName
	|-AsyncOperationBase<long>.get_DebugName
	|-AsyncOperationBase<object>.get_DebugName
	|-AsyncOperationBase<SceneInstance>.get_DebugName
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.GetDependencies
	|-AsyncOperationBase<bool>.GetDependencies
	|-AsyncOperationBase<long>.GetDependencies
	|-AsyncOperationBase<object>.GetDependencies
	|-AsyncOperationBase<SceneInstance>.GetDependencies
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Result
	|-AsyncOperationBase<SceneInstance>.get_Result
	|
	|-RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	|-AsyncOperationBase<bool>.get_Result
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-AsyncOperationBase<long>.get_Result
	|-AsyncOperationBase<object>.get_Result
	|
	|-RVA: 0x86E550 Offset: 0x86CB50 VA: 0x18086E550
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Result
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Result(TObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1880 Offset: 0xBCFE80 VA: 0x180BD1880
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.set_Result
	|
	|-RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	|-AsyncOperationBase<bool>.set_Result
	|
	|-RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	|-AsyncOperationBase<long>.set_Result
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-AsyncOperationBase<object>.set_Result
	|
	|-RVA: 0xBD1860 Offset: 0xBCFE60 VA: 0x180BD1860
	|-AsyncOperationBase<SceneInstance>.set_Result
	|
	|-RVA: 0xAC52F0 Offset: 0xAC38F0 VA: 0x180AC52F0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_Result
	*/

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Version
	|-AsyncOperationBase<SceneInstance>.get_Version
	|
	|-RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	|-AsyncOperationBase<bool>.get_Version
	|-AsyncOperationBase<long>.get_Version
	|-AsyncOperationBase<object>.get_Version
	|
	|-RVA: 0xBD0670 Offset: 0xBCEC70 VA: 0x180BD0670
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Version
	*/

	// RVA: -1 Offset: -1
	internal bool get_CompletedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCF760 Offset: 0xBCDD60 VA: 0x180BCF760
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_CompletedEventHasListeners
	|-AsyncOperationBase<SceneInstance>.get_CompletedEventHasListeners
	|
	|-RVA: 0xBCF850 Offset: 0xBCDE50 VA: 0x180BCF850
	|-AsyncOperationBase<bool>.get_CompletedEventHasListeners
	|-AsyncOperationBase<long>.get_CompletedEventHasListeners
	|-AsyncOperationBase<object>.get_CompletedEventHasListeners
	|
	|-RVA: 0xBCF7A0 Offset: 0xBCDDA0 VA: 0x180BCF7A0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_CompletedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal bool get_DestroyedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCF960 Offset: 0xBCDF60 VA: 0x180BCF960
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xBCF8C0 Offset: 0xBCDEC0 VA: 0x180BCF8C0
	|-AsyncOperationBase<bool>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xBCFA70 Offset: 0xBCE070 VA: 0x180BCFA70
	|-AsyncOperationBase<long>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xBCFAC0 Offset: 0xBCE0C0 VA: 0x180BCFAC0
	|-AsyncOperationBase<object>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xBCF910 Offset: 0xBCDF10 VA: 0x180BCF910
	|-AsyncOperationBase<SceneInstance>.get_DestroyedEventHasListeners
	|
	|-RVA: 0xBCF9B0 Offset: 0xBCDFB0 VA: 0x180BCF9B0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_DestroyedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal void set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.set_OnDestroy
	|-AsyncOperationBase<SceneInstance>.set_OnDestroy
	|
	|-RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	|-AsyncOperationBase<bool>.set_OnDestroy
	|-AsyncOperationBase<long>.set_OnDestroy
	|-AsyncOperationBase<object>.set_OnDestroy
	|
	|-RVA: 0xADB100 Offset: 0xAD9700 VA: 0x180ADB100
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_OnDestroy
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void add_Executed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCF580 Offset: 0xBCDB80 VA: 0x180BCF580
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.add_Executed
	|
	|-RVA: 0xBCF6C0 Offset: 0xBCDCC0 VA: 0x180BCF6C0
	|-AsyncOperationBase<bool>.add_Executed
	|
	|-RVA: 0xBCF620 Offset: 0xBCDC20 VA: 0x180BCF620
	|-AsyncOperationBase<long>.add_Executed
	|
	|-RVA: 0xBCF350 Offset: 0xBCD950 VA: 0x180BCF350
	|-AsyncOperationBase<object>.add_Executed
	|
	|-RVA: 0xBCF3F0 Offset: 0xBCD9F0 VA: 0x180BCF3F0
	|-AsyncOperationBase<SceneInstance>.add_Executed
	|
	|-RVA: 0xBCF490 Offset: 0xBCDA90 VA: 0x180BCF490
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Executed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void remove_Executed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0C20 Offset: 0xBCF220 VA: 0x180BD0C20
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.remove_Executed
	|
	|-RVA: 0xBD0E00 Offset: 0xBCF400 VA: 0x180BD0E00
	|-AsyncOperationBase<bool>.remove_Executed
	|
	|-RVA: 0xBD0CC0 Offset: 0xBCF2C0 VA: 0x180BD0CC0
	|-AsyncOperationBase<long>.remove_Executed
	|
	|-RVA: 0xBD0D60 Offset: 0xBCF360 VA: 0x180BD0D60
	|-AsyncOperationBase<object>.remove_Executed
	|
	|-RVA: 0xBD0EA0 Offset: 0xBCF4A0 VA: 0x180BD0EA0
	|-AsyncOperationBase<SceneInstance>.remove_Executed
	|
	|-RVA: 0xBD0B30 Offset: 0xBCF130 VA: 0x180BD0B30
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Executed
	*/

	// RVA: -1 Offset: -1
	protected internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_ReferenceCount
	|-AsyncOperationBase<SceneInstance>.get_ReferenceCount
	|
	|-RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	|-AsyncOperationBase<bool>.get_ReferenceCount
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-AsyncOperationBase<long>.get_ReferenceCount
	|-AsyncOperationBase<object>.get_ReferenceCount
	|
	|-RVA: 0x886C10 Offset: 0x885210 VA: 0x180886C10
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_ReferenceCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public bool get_IsRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCFCF0 Offset: 0xBCE2F0 VA: 0x180BCFCF0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_IsRunning
	|-AsyncOperationBase<SceneInstance>.get_IsRunning
	|
	|-RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	|-AsyncOperationBase<bool>.get_IsRunning
	|-AsyncOperationBase<long>.get_IsRunning
	|-AsyncOperationBase<object>.get_IsRunning
	|
	|-RVA: 0xBCFD00 Offset: 0xBCE300 VA: 0x180BCFD00
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_IsRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0F40 Offset: 0xBCF540 VA: 0x180BD0F40
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.set_IsRunning
	|-AsyncOperationBase<SceneInstance>.set_IsRunning
	|
	|-RVA: 0x528960 Offset: 0x526F60 VA: 0x180528960
	|-AsyncOperationBase<bool>.set_IsRunning
	|-AsyncOperationBase<long>.set_IsRunning
	|-AsyncOperationBase<object>.set_IsRunning
	|
	|-RVA: 0xBD0F50 Offset: 0xBCF550 VA: 0x180BD0F50
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_IsRunning
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCE190 Offset: 0xBCC790 VA: 0x180BCE190
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0xBCE430 Offset: 0xBCCA30 VA: 0x180BCE430
	|-AsyncOperationBase<bool>..ctor
	|
	|-RVA: 0xBCE270 Offset: 0xBCC870 VA: 0x180BCE270
	|-AsyncOperationBase<long>..ctor
	|
	|-RVA: 0xBCE6A0 Offset: 0xBCCCA0 VA: 0x180BCE6A0
	|-AsyncOperationBase<object>..ctor
	|
	|-RVA: 0xBCE350 Offset: 0xBCC950 VA: 0x180BCE350
	|-AsyncOperationBase<SceneInstance>..ctor
	|
	|-RVA: 0xBCE510 Offset: 0xBCCB10 VA: 0x180BCE510
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static string ShortenPath(string p, bool keepExtension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCA3D0 Offset: 0xBC89D0 VA: 0x180BCA3D0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.ShortenPath
	|-AsyncOperationBase<bool>.ShortenPath
	|-AsyncOperationBase<long>.ShortenPath
	|-AsyncOperationBase<object>.ShortenPath
	|-AsyncOperationBase<SceneInstance>.ShortenPath
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ShortenPath
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCDC50 Offset: 0xBCC250 VA: 0x180BCDC50
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.WaitForCompletion
	|
	|-RVA: 0xBCD9B0 Offset: 0xBCBFB0 VA: 0x180BCD9B0
	|-AsyncOperationBase<bool>.WaitForCompletion
	|
	|-RVA: 0xBCE040 Offset: 0xBCC640 VA: 0x180BCE040
	|-AsyncOperationBase<long>.WaitForCompletion
	|
	|-RVA: 0xBCDDA0 Offset: 0xBCC3A0 VA: 0x180BCDDA0
	|-AsyncOperationBase<object>.WaitForCompletion
	|
	|-RVA: 0xBCDB00 Offset: 0xBCC100 VA: 0x180BCDB00
	|-AsyncOperationBase<SceneInstance>.WaitForCompletion
	|
	|-RVA: 0xBCDEF0 Offset: 0xBCC4F0 VA: 0x180BCDEF0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected virtual bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.InvokeWaitForCompletion
	|-AsyncOperationBase<bool>.InvokeWaitForCompletion
	|-AsyncOperationBase<long>.InvokeWaitForCompletion
	|-AsyncOperationBase<object>.InvokeWaitForCompletion
	|-AsyncOperationBase<SceneInstance>.InvokeWaitForCompletion
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1
	protected internal void IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC8980 Offset: 0xBC6F80 VA: 0x180BC8980
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.IncrementReferenceCount
	|-AsyncOperationBase<SceneInstance>.IncrementReferenceCount
	|
	|-RVA: 0xBC8F00 Offset: 0xBC7500 VA: 0x180BC8F00
	|-AsyncOperationBase<bool>.IncrementReferenceCount
	|
	|-RVA: 0xBC8D90 Offset: 0xBC7390 VA: 0x180BC8D90
	|-AsyncOperationBase<long>.IncrementReferenceCount
	|-AsyncOperationBase<object>.IncrementReferenceCount
	|
	|-RVA: 0xBC8AF0 Offset: 0xBC70F0 VA: 0x180BC8AF0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	protected internal void DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC6E10 Offset: 0xBC5410 VA: 0x180BC6E10
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.DecrementReferenceCount
	|
	|-RVA: 0xBC7B00 Offset: 0xBC6100 VA: 0x180BC7B00
	|-AsyncOperationBase<bool>.DecrementReferenceCount
	|
	|-RVA: 0xBC7EA0 Offset: 0xBC64A0 VA: 0x180BC7EA0
	|-AsyncOperationBase<long>.DecrementReferenceCount
	|
	|-RVA: 0xBC6A60 Offset: 0xBC5060 VA: 0x180BC6A60
	|-AsyncOperationBase<object>.DecrementReferenceCount
	|
	|-RVA: 0xBC8240 Offset: 0xBC6840 VA: 0x180BC8240
	|-AsyncOperationBase<SceneInstance>.DecrementReferenceCount
	|
	|-RVA: 0xBC71C0 Offset: 0xBC57C0 VA: 0x180BC71C0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0460 Offset: 0xBCEA60 VA: 0x180BD0460
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Task
	|
	|-RVA: 0xBD0360 Offset: 0xBCE960 VA: 0x180BD0360
	|-AsyncOperationBase<bool>.get_Task
	|
	|-RVA: 0xBCFFC0 Offset: 0xBCE5C0 VA: 0x180BCFFC0
	|-AsyncOperationBase<long>.get_Task
	|
	|-RVA: 0xBD0570 Offset: 0xBCEB70 VA: 0x180BD0570
	|-AsyncOperationBase<object>.get_Task
	|
	|-RVA: 0xBCFEB0 Offset: 0xBCE4B0 VA: 0x180BCFEB0
	|-AsyncOperationBase<SceneInstance>.get_Task
	|
	|-RVA: 0xBD00C0 Offset: 0xBCE6C0 VA: 0x180BD00C0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCD1F0 Offset: 0xBCB7F0 VA: 0x180BCD1F0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xBCCBB0 Offset: 0xBCB1B0 VA: 0x180BCCBB0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xBCCF60 Offset: 0xBCB560 VA: 0x180BCCF60
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xBCD340 Offset: 0xBCB940 VA: 0x180BCD340
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xBCD0A0 Offset: 0xBCB6A0 VA: 0x180BCD0A0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0xBCCCF0 Offset: 0xBCB2F0 VA: 0x180BCCCF0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB810 Offset: 0xBC9E10 VA: 0x180BCB810
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.ToString
	|
	|-RVA: 0xBCBBF0 Offset: 0xBCA1F0 VA: 0x180BCBBF0
	|-AsyncOperationBase<bool>.ToString
	|
	|-RVA: 0xBCB3C0 Offset: 0xBC99C0 VA: 0x180BCB3C0
	|-AsyncOperationBase<long>.ToString
	|
	|-RVA: 0xBCBDE0 Offset: 0xBCA3E0 VA: 0x180BCBDE0
	|-AsyncOperationBase<object>.ToString
	|
	|-RVA: 0xBCBA00 Offset: 0xBCA000 VA: 0x180BCBA00
	|-AsyncOperationBase<SceneInstance>.ToString
	|
	|-RVA: 0xBCB5B0 Offset: 0xBC9BB0 VA: 0x180BCB5B0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCA280 Offset: 0xBC8880 VA: 0x180BCA280
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.RegisterForDeferredCallbackEvent
	|-AsyncOperationBase<SceneInstance>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0xBCA200 Offset: 0xBC8800 VA: 0x180BCA200
	|-AsyncOperationBase<bool>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0xBCA240 Offset: 0xBC8840 VA: 0x180BCA240
	|-AsyncOperationBase<long>.RegisterForDeferredCallbackEvent
	|-AsyncOperationBase<object>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0xBCA2C0 Offset: 0xBC88C0 VA: 0x180BCA2C0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.RegisterForDeferredCallbackEvent
	*/

	// RVA: -1 Offset: -1
	internal void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCEDD0 Offset: 0xBCD3D0 VA: 0x180BCEDD0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.add_Completed
	|-AsyncOperationBase<SceneInstance>.add_Completed
	|
	|-RVA: 0xBCEE90 Offset: 0xBCD490 VA: 0x180BCEE90
	|-AsyncOperationBase<bool>.add_Completed
	|
	|-RVA: 0xBCED10 Offset: 0xBCD310 VA: 0x180BCED10
	|-AsyncOperationBase<long>.add_Completed
	|-AsyncOperationBase<object>.add_Completed
	|
	|-RVA: 0xBCEBC0 Offset: 0xBCD1C0 VA: 0x180BCEBC0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD09F0 Offset: 0xBCEFF0 VA: 0x180BD09F0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.remove_Completed
	|-AsyncOperationBase<SceneInstance>.remove_Completed
	|
	|-RVA: 0xBD0A20 Offset: 0xBCF020 VA: 0x180BD0A20
	|-AsyncOperationBase<bool>.remove_Completed
	|-AsyncOperationBase<long>.remove_Completed
	|-AsyncOperationBase<object>.remove_Completed
	|
	|-RVA: 0xBD0A50 Offset: 0xBCF050 VA: 0x180BD0A50
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	internal void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCEFE0 Offset: 0xBCD5E0 VA: 0x180BCEFE0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.add_Destroyed
	|
	|-RVA: 0xBCEF50 Offset: 0xBCD550 VA: 0x180BCEF50
	|-AsyncOperationBase<bool>.add_Destroyed
	|
	|-RVA: 0xBCF2C0 Offset: 0xBCD8C0 VA: 0x180BCF2C0
	|-AsyncOperationBase<long>.add_Destroyed
	|
	|-RVA: 0xBCF230 Offset: 0xBCD830 VA: 0x180BCF230
	|-AsyncOperationBase<object>.add_Destroyed
	|
	|-RVA: 0xBCF1A0 Offset: 0xBCD7A0 VA: 0x180BCF1A0
	|-AsyncOperationBase<SceneInstance>.add_Destroyed
	|
	|-RVA: 0xBCF070 Offset: 0xBCD670 VA: 0x180BCF070
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCD640 Offset: 0xBCBC40 VA: 0x180BCD640
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.remove_Destroyed
	|
	|-RVA: 0xBCD5F0 Offset: 0xBCBBF0 VA: 0x180BCD5F0
	|-AsyncOperationBase<bool>.remove_Destroyed
	|
	|-RVA: 0xBCD550 Offset: 0xBCBB50 VA: 0x180BCD550
	|-AsyncOperationBase<long>.remove_Destroyed
	|
	|-RVA: 0xBCD500 Offset: 0xBCBB00 VA: 0x180BCD500
	|-AsyncOperationBase<object>.remove_Destroyed
	|
	|-RVA: 0xBCD5A0 Offset: 0xBCBBA0 VA: 0x180BCD5A0
	|-AsyncOperationBase<SceneInstance>.remove_Destroyed
	|
	|-RVA: 0xBD0AB0 Offset: 0xBCF0B0 VA: 0x180BD0AB0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCE9A0 Offset: 0xBCCFA0 VA: 0x180BCE9A0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.add_CompletedTypeless
	|-AsyncOperationBase<SceneInstance>.add_CompletedTypeless
	|
	|-RVA: 0xBCE890 Offset: 0xBCCE90 VA: 0x180BCE890
	|-AsyncOperationBase<bool>.add_CompletedTypeless
	|
	|-RVA: 0xBCE780 Offset: 0xBCCD80 VA: 0x180BCE780
	|-AsyncOperationBase<long>.add_CompletedTypeless
	|-AsyncOperationBase<object>.add_CompletedTypeless
	|
	|-RVA: 0xBCEAB0 Offset: 0xBCD0B0 VA: 0x180BCEAB0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD06A0 Offset: 0xBCECA0 VA: 0x180BD06A0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.remove_CompletedTypeless
	|-AsyncOperationBase<SceneInstance>.remove_CompletedTypeless
	|
	|-RVA: 0xBD07C0 Offset: 0xBCEDC0 VA: 0x180BD07C0
	|-AsyncOperationBase<bool>.remove_CompletedTypeless
	|-AsyncOperationBase<long>.remove_CompletedTypeless
	|-AsyncOperationBase<object>.remove_CompletedTypeless
	|
	|-RVA: 0xBD08E0 Offset: 0xBCEEE0 VA: 0x180BD08E0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Status
	|-AsyncOperationBase<SceneInstance>.get_Status
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-AsyncOperationBase<bool>.get_Status
	|
	|-RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	|-AsyncOperationBase<long>.get_Status
	|-AsyncOperationBase<object>.get_Status
	|
	|-RVA: 0xBCFE80 Offset: 0xBCE480 VA: 0x180BCFE80
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	internal Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_OperationException
	|-AsyncOperationBase<SceneInstance>.get_OperationException
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-AsyncOperationBase<bool>.get_OperationException
	|-AsyncOperationBase<long>.get_OperationException
	|-AsyncOperationBase<object>.get_OperationException
	|
	|-RVA: 0xBCFD30 Offset: 0xBCE330 VA: 0x180BCFD30
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	private void set_OperationException(Exception value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD15A0 Offset: 0xBCFBA0 VA: 0x180BD15A0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.set_OperationException
	|
	|-RVA: 0xBD0FC0 Offset: 0xBCF5C0 VA: 0x180BD0FC0
	|-AsyncOperationBase<bool>.set_OperationException
	|
	|-RVA: 0xBD1700 Offset: 0xBCFD00 VA: 0x180BD1700
	|-AsyncOperationBase<long>.set_OperationException
	|
	|-RVA: 0xBD1280 Offset: 0xBCF880 VA: 0x180BD1280
	|-AsyncOperationBase<object>.set_OperationException
	|
	|-RVA: 0xBD1120 Offset: 0xBCF720 VA: 0x180BD1120
	|-AsyncOperationBase<SceneInstance>.set_OperationException
	|
	|-RVA: 0xBD13E0 Offset: 0xBCF9E0 VA: 0x180BD13E0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_OperationException
	*/

	// RVA: -1 Offset: -1
	internal bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCA180 Offset: 0xBC8780 VA: 0x180BCA180
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.MoveNext
	|-AsyncOperationBase<SceneInstance>.MoveNext
	|
	|-RVA: 0xBCA1E0 Offset: 0xBC87E0 VA: 0x180BCA1E0
	|-AsyncOperationBase<bool>.MoveNext
	|
	|-RVA: 0xBCA160 Offset: 0xBC8760 VA: 0x180BCA160
	|-AsyncOperationBase<long>.MoveNext
	|-AsyncOperationBase<object>.MoveNext
	|
	|-RVA: 0xBCA1A0 Offset: 0xBC87A0 VA: 0x180BCA1A0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.Reset
	|-AsyncOperationBase<bool>.Reset
	|-AsyncOperationBase<long>.Reset
	|-AsyncOperationBase<object>.Reset
	|-AsyncOperationBase<SceneInstance>.Reset
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	internal object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Current
	|-AsyncOperationBase<bool>.get_Current
	|-AsyncOperationBase<long>.get_Current
	|-AsyncOperationBase<object>.get_Current
	|-AsyncOperationBase<SceneInstance>.get_Current
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCCA10 Offset: 0xBCB010 VA: 0x180BCCA10
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_IsDone
	|-AsyncOperationBase<SceneInstance>.get_IsDone
	|
	|-RVA: 0xBCC9F0 Offset: 0xBCAFF0 VA: 0x180BCC9F0
	|-AsyncOperationBase<bool>.get_IsDone
	|
	|-RVA: 0xBCCA30 Offset: 0xBCB030 VA: 0x180BCCA30
	|-AsyncOperationBase<long>.get_IsDone
	|-AsyncOperationBase<object>.get_IsDone
	|
	|-RVA: 0xBCFC60 Offset: 0xBCE260 VA: 0x180BCFC60
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	internal float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCFDA0 Offset: 0xBCE3A0 VA: 0x180BCFDA0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_PercentComplete
	|-AsyncOperationBase<SceneInstance>.get_PercentComplete
	|
	|-RVA: 0xBCFDE0 Offset: 0xBCE3E0 VA: 0x180BCFDE0
	|-AsyncOperationBase<bool>.get_PercentComplete
	|
	|-RVA: 0xBCFD60 Offset: 0xBCE360 VA: 0x180BCFD60
	|-AsyncOperationBase<long>.get_PercentComplete
	|-AsyncOperationBase<object>.get_PercentComplete
	|
	|-RVA: 0xBCFE20 Offset: 0xBCE420 VA: 0x180BCFE20
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal void InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC9AC0 Offset: 0xBC80C0 VA: 0x180BC9AC0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.InvokeCompletionEvent
	|
	|-RVA: 0xBC97B0 Offset: 0xBC7DB0 VA: 0x180BC97B0
	|-AsyncOperationBase<bool>.InvokeCompletionEvent
	|
	|-RVA: 0xBC9610 Offset: 0xBC7C10 VA: 0x180BC9610
	|-AsyncOperationBase<long>.InvokeCompletionEvent
	|
	|-RVA: 0xBC9950 Offset: 0xBC7F50 VA: 0x180BC9950
	|-AsyncOperationBase<object>.InvokeCompletionEvent
	|
	|-RVA: 0xBC9070 Offset: 0xBC7670 VA: 0x180BC9070
	|-AsyncOperationBase<SceneInstance>.InvokeCompletionEvent
	|
	|-RVA: 0xBC9210 Offset: 0xBC7810 VA: 0x180BC9210
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCFB40 Offset: 0xBCE140 VA: 0x180BCFB40
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Handle
	|-AsyncOperationBase<SceneInstance>.get_Handle
	|
	|-RVA: 0xBCFBD0 Offset: 0xBCE1D0 VA: 0x180BCFBD0
	|-AsyncOperationBase<bool>.get_Handle
	|-AsyncOperationBase<long>.get_Handle
	|-AsyncOperationBase<object>.get_Handle
	|
	|-RVA: 0xBCFB10 Offset: 0xBCE110 VA: 0x180BCFB10
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Handle
	*/

	// RVA: -1 Offset: -1
	private void UpdateCallback(float unscaledDeltaTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCD830 Offset: 0xBCBE30 VA: 0x180BCD830
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UpdateCallback
	|
	|-RVA: 0xBCD8B0 Offset: 0xBCBEB0 VA: 0x180BCD8B0
	|-AsyncOperationBase<bool>.UpdateCallback
	|
	|-RVA: 0xBCD6B0 Offset: 0xBCBCB0 VA: 0x180BCD6B0
	|-AsyncOperationBase<long>.UpdateCallback
	|
	|-RVA: 0xBCD7B0 Offset: 0xBCBDB0 VA: 0x180BCD7B0
	|-AsyncOperationBase<object>.UpdateCallback
	|
	|-RVA: 0xBCD930 Offset: 0xBCBF30 VA: 0x180BCD930
	|-AsyncOperationBase<SceneInstance>.UpdateCallback
	|
	|-RVA: 0xBCD730 Offset: 0xBCBD30 VA: 0x180BCD730
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UpdateCallback
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC54F0 Offset: 0xBC3AF0 VA: 0x180BC54F0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.Complete
	|
	|-RVA: 0xBC5200 Offset: 0xBC3800 VA: 0x180BC5200
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0xBC52E0 Offset: 0xBC38E0 VA: 0x180BC52E0
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0xBC3EB0 Offset: 0xBC24B0 VA: 0x180BC3EB0
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0xBC3F90 Offset: 0xBC2590 VA: 0x180BC3F90
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0xBC53C0 Offset: 0xBC39C0 VA: 0x180BC53C0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3CF0 Offset: 0xBC22F0 VA: 0x180BC3CF0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.Complete
	|
	|-RVA: 0xBC4B40 Offset: 0xBC3140 VA: 0x180BC4B40
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0xBC4C20 Offset: 0xBC3220 VA: 0x180BC4C20
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0xBC3DD0 Offset: 0xBC23D0 VA: 0x180BC3DD0
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0xBC4570 Offset: 0xBC2B70 VA: 0x180BC4570
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0xBC6810 Offset: 0xBC4E10 VA: 0x180BC6810
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC4D00 Offset: 0xBC3300 VA: 0x180BC4D00
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.Complete
	|
	|-RVA: 0xBC4080 Offset: 0xBC2680 VA: 0x180BC4080
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0xBC4650 Offset: 0xBC2C50 VA: 0x180BC4650
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0xBC55E0 Offset: 0xBC3BE0 VA: 0x180BC55E0
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0xBC6310 Offset: 0xBC4910 VA: 0x180BC6310
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0xBC5AE0 Offset: 0xBC40E0 VA: 0x180BC5AE0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB170 Offset: 0xBC9770 VA: 0x180BCB170
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.Start
	|
	|-RVA: 0xBCAA80 Offset: 0xBC9080 VA: 0x180BCAA80
	|-AsyncOperationBase<bool>.Start
	|
	|-RVA: 0xBCA450 Offset: 0xBC8A50 VA: 0x180BCA450
	|-AsyncOperationBase<long>.Start
	|
	|-RVA: 0xBCACD0 Offset: 0xBC92D0 VA: 0x180BCACD0
	|-AsyncOperationBase<object>.Start
	|
	|-RVA: 0xBCAF20 Offset: 0xBC9520 VA: 0x180BCAF20
	|-AsyncOperationBase<SceneInstance>.Start
	|
	|-RVA: 0xBCA6A0 Offset: 0xBC8CA0 VA: 0x180BCA6A0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Start
	*/

	// RVA: -1 Offset: -1
	internal void InvokeExecute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC9D10 Offset: 0xBC8310 VA: 0x180BC9D10
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.InvokeExecute
	|
	|-RVA: 0xBC9DC0 Offset: 0xBC83C0 VA: 0x180BC9DC0
	|-AsyncOperationBase<bool>.InvokeExecute
	|
	|-RVA: 0xBCA0B0 Offset: 0xBC86B0 VA: 0x180BCA0B0
	|-AsyncOperationBase<long>.InvokeExecute
	|
	|-RVA: 0xBC9E70 Offset: 0xBC8470 VA: 0x180BC9E70
	|-AsyncOperationBase<object>.InvokeExecute
	|
	|-RVA: 0xBC9C60 Offset: 0xBC8260 VA: 0x180BC9C60
	|-AsyncOperationBase<SceneInstance>.InvokeExecute
	|
	|-RVA: 0xBC9F20 Offset: 0xBC8520 VA: 0x180BC9F20
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeExecute
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC630 Offset: 0xBCAC30 VA: 0x180BCC630
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0xBCC650 Offset: 0xBCAC50 VA: 0x180BCC650
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0xBCC5F0 Offset: 0xBCABF0 VA: 0x180BCC5F0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0xBCC610 Offset: 0xBCAC10 VA: 0x180BCC610
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCD480 Offset: 0xBCBA80 VA: 0x180BCD480
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0xBCD4A0 Offset: 0xBCBAA0 VA: 0x180BCD4A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0xBCD4C0 Offset: 0xBCBAC0 VA: 0x180BCD4C0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC6B0 Offset: 0xBCACB0 VA: 0x180BCC6B0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xBCC710 Offset: 0xBCAD10 VA: 0x180BCC710
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xBCC690 Offset: 0xBCAC90 VA: 0x180BCC690
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xBCC670 Offset: 0xBCAC70 VA: 0x180BCC670
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xBCC6D0 Offset: 0xBCACD0 VA: 0x180BCC6D0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0xBCC6F0 Offset: 0xBCACF0 VA: 0x180BCC6F0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCD640 Offset: 0xBCBC40 VA: 0x180BCD640
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xBCD5F0 Offset: 0xBCBBF0 VA: 0x180BCD5F0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xBCD550 Offset: 0xBCBB50 VA: 0x180BCD550
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xBCD500 Offset: 0xBCBB00 VA: 0x180BCD500
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xBCD5A0 Offset: 0xBCBBA0 VA: 0x180BCD5A0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0xBCD4E0 Offset: 0xBCBAE0 VA: 0x180BCD4E0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0xBCD450 Offset: 0xBCBA50 VA: 0x180BCD450
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0xBCCB10 Offset: 0xBCB110 VA: 0x180BCCB10
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCCA80 Offset: 0xBCB080 VA: 0x180BCCA80
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0xBCCAF0 Offset: 0xBCB0F0 VA: 0x180BCCAF0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0xBCCAA0 Offset: 0xBCB0A0 VA: 0x180BCCAA0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0xBCCAC0 Offset: 0xBCB0C0 VA: 0x180BCCAC0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0xBCCB80 Offset: 0xBCB180 VA: 0x180BCCB80
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0xBCCA50 Offset: 0xBCB050 VA: 0x180BCCA50
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCCA10 Offset: 0xBCB010 VA: 0x180BCCA10
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0xBCC9F0 Offset: 0xBCAFF0 VA: 0x180BCC9F0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0xBCCA30 Offset: 0xBCB030 VA: 0x180BCCA30
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x94D430 Offset: 0x94BA30 VA: 0x18094D430
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC840 Offset: 0xBCAE40 VA: 0x180BCC840
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0xBCC750 Offset: 0xBCAD50 VA: 0x180BCC750
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0xBCC930 Offset: 0xBCAF30 VA: 0x180BCC930
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0xBCD690 Offset: 0xBCBC90 VA: 0x180BCD690
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC730 Offset: 0xBCAD30 VA: 0x180BCC730
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC190 Offset: 0xBCA790 VA: 0x180BCC190
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0xBCC1C0 Offset: 0xBCA7C0 VA: 0x180BCC1C0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0xBCC2A0 Offset: 0xBCA8A0 VA: 0x180BCC2A0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0xBCC1F0 Offset: 0xBCA7F0 VA: 0x180BCC1F0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCCB40 Offset: 0xBCB140 VA: 0x180BCCB40
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC130 Offset: 0xBCA730 VA: 0x180BCC130
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC110 Offset: 0xBCA710 VA: 0x180BCC110
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xBCC0D0 Offset: 0xBCA6D0 VA: 0x180BCC0D0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xBCC0F0 Offset: 0xBCA6F0 VA: 0x180BCC0F0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xBCC0B0 Offset: 0xBCA6B0 VA: 0x180BCC0B0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xBCC090 Offset: 0xBCA690 VA: 0x180BCC090
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0xBCC070 Offset: 0xBCA670 VA: 0x180BCC070
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC2F0 Offset: 0xBCA8F0 VA: 0x180BCC2F0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0xBCC330 Offset: 0xBCA930 VA: 0x180BCC330
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0xBCC2D0 Offset: 0xBCA8D0 VA: 0x180BCC2D0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0xBCC310 Offset: 0xBCA910 VA: 0x180BCC310
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC3B0 Offset: 0xBCA9B0 VA: 0x180BCC3B0
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xBCC3D0 Offset: 0xBCA9D0 VA: 0x180BCC3D0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xBCC3F0 Offset: 0xBCA9F0 VA: 0x180BCC3F0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xBCC350 Offset: 0xBCA950 VA: 0x180BCC350
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xBCC390 Offset: 0xBCA990 VA: 0x180BCC390
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0xBCC370 Offset: 0xBCA970 VA: 0x180BCC370
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC410 Offset: 0xBCAA10 VA: 0x180BCC410
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xBCC5A0 Offset: 0xBCABA0 VA: 0x180BCC5A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xBCC500 Offset: 0xBCAB00 VA: 0x180BCC500
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xBCC4B0 Offset: 0xBCAAB0 VA: 0x180BCC4B0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xBCC460 Offset: 0xBCAA60 VA: 0x180BCC460
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0xBCC550 Offset: 0xBCAB50 VA: 0x180BCC550
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal virtual void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.ReleaseDependencies
	|-AsyncOperationBase<bool>.ReleaseDependencies
	|-AsyncOperationBase<long>.ReleaseDependencies
	|-AsyncOperationBase<object>.ReleaseDependencies
	|-AsyncOperationBase<SceneInstance>.ReleaseDependencies
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC150 Offset: 0xBCA750 VA: 0x180BCC150
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal virtual DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC8860 Offset: 0xBC6E60 VA: 0x180BC8860
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.GetDownloadStatus
	|
	|-RVA: 0xBC8740 Offset: 0xBC6D40 VA: 0x180BC8740
	|-AsyncOperationBase<bool>.GetDownloadStatus
	|
	|-RVA: 0xBC85F0 Offset: 0xBC6BF0 VA: 0x180BC85F0
	|-AsyncOperationBase<long>.GetDownloadStatus
	|
	|-RVA: 0xBC88F0 Offset: 0xBC6EF0 VA: 0x180BC88F0
	|-AsyncOperationBase<object>.GetDownloadStatus
	|
	|-RVA: 0xBC87D0 Offset: 0xBC6DD0 VA: 0x180BC87D0
	|-AsyncOperationBase<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xBC8680 Offset: 0xBC6C80 VA: 0x180BC8680
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <.ctor>b__38_0(AsyncOperationHandle o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCC050 Offset: 0xBCA650 VA: 0x180BCC050
	|-AsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.<.ctor>b__38_0
	|
	|-RVA: 0xBCC030 Offset: 0xBCA630 VA: 0x180BCC030
	|-AsyncOperationBase<bool>.<.ctor>b__38_0
	|
	|-RVA: 0xBCBFB0 Offset: 0xBCA5B0 VA: 0x180BCBFB0
	|-AsyncOperationBase<long>.<.ctor>b__38_0
	|
	|-RVA: 0xBCBFF0 Offset: 0xBCA5F0 VA: 0x180BCBFF0
	|-AsyncOperationBase<object>.<.ctor>b__38_0
	|
	|-RVA: 0xBCBFD0 Offset: 0xBCA5D0 VA: 0x180BCBFD0
	|-AsyncOperationBase<SceneInstance>.<.ctor>b__38_0
	|
	|-RVA: 0xBCC010 Offset: 0xBCA610 VA: 0x180BCC010
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.<.ctor>b__38_0
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle<TObject> : IEnumerator, IEquatable<AsyncOperationHandle<TObject>> // TypeDefIndex: 12735
{
	// Fields
	internal AsyncOperationBase<TObject> m_InternalOp; // 0x0
	private int m_Version; // 0x0
	private string m_LocationName; // 0x0
	private bool m_UnloadSceneOpExcludeReleaseCallback; // 0x0

	// Properties
	internal string LocationName { get; set; }
	internal bool UnloadSceneOpExcludeReleaseCallback { get; set; }
	public string DebugName { get; }
	internal AsyncOperationBase<TObject> InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public TObject Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<TObject> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal string get_LocationName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_LocationName
	|-AsyncOperationHandle<bool>.get_LocationName
	|-AsyncOperationHandle<long>.get_LocationName
	|-AsyncOperationHandle<object>.get_LocationName
	|-AsyncOperationHandle<SceneInstance>.get_LocationName
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_LocationName
	*/

	// RVA: -1 Offset: -1
	internal void set_LocationName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.set_LocationName
	|-AsyncOperationHandle<bool>.set_LocationName
	|-AsyncOperationHandle<long>.set_LocationName
	|-AsyncOperationHandle<object>.set_LocationName
	|-AsyncOperationHandle<SceneInstance>.set_LocationName
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.set_LocationName
	*/

	// RVA: -1 Offset: -1
	internal bool get_UnloadSceneOpExcludeReleaseCallback() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<bool>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<long>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<object>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<SceneInstance>.get_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_UnloadSceneOpExcludeReleaseCallback
	*/

	// RVA: -1 Offset: -1
	internal void set_UnloadSceneOpExcludeReleaseCallback(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<bool>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<long>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<object>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<SceneInstance>.set_UnloadSceneOpExcludeReleaseCallback
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.set_UnloadSceneOpExcludeReleaseCallback
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle op_Implicit(AsyncOperationHandle<TObject> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD8590 Offset: 0xBD6B90 VA: 0x180BD8590
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.op_Implicit
	|-AsyncOperationHandle<bool>.op_Implicit
	|-AsyncOperationHandle<long>.op_Implicit
	|-AsyncOperationHandle<object>.op_Implicit
	|-AsyncOperationHandle<SceneInstance>.op_Implicit
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(AsyncOperationBase<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5490 Offset: 0xBD3A90 VA: 0x180BD5490
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0xBD4AA0 Offset: 0xBD30A0 VA: 0x180BD4AA0
	|-AsyncOperationHandle<bool>..ctor
	|-AsyncOperationHandle<long>..ctor
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0xBD4B10 Offset: 0xBD3110 VA: 0x180BD4B10
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public DownloadStatus GetDownloadStatus() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1F00 Offset: 0xBD0500 VA: 0x180BD1F00
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.GetDownloadStatus
	|
	|-RVA: 0xBD1E40 Offset: 0xBD0440 VA: 0x180BD1E40
	|-AsyncOperationHandle<bool>.GetDownloadStatus
	|
	|-RVA: 0xBD1FC0 Offset: 0xBD05C0 VA: 0x180BD1FC0
	|-AsyncOperationHandle<long>.GetDownloadStatus
	|
	|-RVA: 0xBD2080 Offset: 0xBD0680 VA: 0x180BD2080
	|-AsyncOperationHandle<object>.GetDownloadStatus
	|
	|-RVA: 0xBD2140 Offset: 0xBD0740 VA: 0x180BD2140
	|-AsyncOperationHandle<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xBD1D50 Offset: 0xBD0350 VA: 0x180BD1D50
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD23C0 Offset: 0xBD09C0 VA: 0x180BD23C0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.InternalGetDownloadStatus
	|
	|-RVA: 0xBD2730 Offset: 0xBD0D30 VA: 0x180BD2730
	|-AsyncOperationHandle<bool>.InternalGetDownloadStatus
	|
	|-RVA: 0xBD2240 Offset: 0xBD0840 VA: 0x180BD2240
	|-AsyncOperationHandle<long>.InternalGetDownloadStatus
	|
	|-RVA: 0xBD2A30 Offset: 0xBD1030 VA: 0x180BD2A30
	|-AsyncOperationHandle<object>.InternalGetDownloadStatus
	|
	|-RVA: 0xBD28B0 Offset: 0xBD0EB0 VA: 0x180BD28B0
	|-AsyncOperationHandle<SceneInstance>.InternalGetDownloadStatus
	|
	|-RVA: 0xBD2540 Offset: 0xBD0B40 VA: 0x180BD2540
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.InternalGetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5190 Offset: 0xBD3790 VA: 0x180BD5190
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0xBD4BC0 Offset: 0xBD31C0 VA: 0x180BD4BC0
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0xBD5950 Offset: 0xBD3F50 VA: 0x180BD5950
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0xBD5690 Offset: 0xBD3C90 VA: 0x180BD5690
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0xBD5DC0 Offset: 0xBD43C0 VA: 0x180BD5DC0
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0xBD5AC0 Offset: 0xBD40C0 VA: 0x180BD5AC0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4EC0 Offset: 0xBD34C0 VA: 0x180BD4EC0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|-AsyncOperationHandle<bool>..ctor
	|-AsyncOperationHandle<long>..ctor
	|-AsyncOperationHandle<object>..ctor
	|-AsyncOperationHandle<SceneInstance>..ctor
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4910 Offset: 0xBD2F10 VA: 0x180BD4910
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0xBD5500 Offset: 0xBD3B00 VA: 0x180BD5500
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0xBD5C30 Offset: 0xBD4230 VA: 0x180BD5C30
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0xBD4D30 Offset: 0xBD3330 VA: 0x180BD4D30
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0xBD5000 Offset: 0xBD3600 VA: 0x180BD5000
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0xBD5300 Offset: 0xBD3900 VA: 0x180BD5300
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5800 Offset: 0xBD3E00 VA: 0x180BD5800
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|-AsyncOperationHandle<bool>..ctor
	|-AsyncOperationHandle<long>..ctor
	|-AsyncOperationHandle<object>..ctor
	|-AsyncOperationHandle<SceneInstance>..ctor
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1950 Offset: 0xBCFF50 VA: 0x180BD1950
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.Acquire
	|-AsyncOperationHandle<SceneInstance>.Acquire
	|
	|-RVA: 0xBD1AF0 Offset: 0xBD00F0 VA: 0x180BD1AF0
	|-AsyncOperationHandle<bool>.Acquire
	|
	|-RVA: 0xBD18A0 Offset: 0xBCFEA0 VA: 0x180BD18A0
	|-AsyncOperationHandle<long>.Acquire
	|-AsyncOperationHandle<object>.Acquire
	|
	|-RVA: 0xBD1A00 Offset: 0xBD0000 VA: 0x180BD1A00
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD62E0 Offset: 0xBD48E0 VA: 0x180BD62E0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.add_Completed
	|-AsyncOperationHandle<SceneInstance>.add_Completed
	|
	|-RVA: 0xBD61C0 Offset: 0xBD47C0 VA: 0x180BD61C0
	|-AsyncOperationHandle<bool>.add_Completed
	|
	|-RVA: 0xBD6250 Offset: 0xBD4850 VA: 0x180BD6250
	|-AsyncOperationHandle<long>.add_Completed
	|-AsyncOperationHandle<object>.add_Completed
	|
	|-RVA: 0xBD6370 Offset: 0xBD4970 VA: 0x180BD6370
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1
	public void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD88B0 Offset: 0xBD6EB0 VA: 0x180BD88B0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.remove_Completed
	|-AsyncOperationHandle<SceneInstance>.remove_Completed
	|
	|-RVA: 0xBD8960 Offset: 0xBD6F60 VA: 0x180BD8960
	|-AsyncOperationHandle<bool>.remove_Completed
	|-AsyncOperationHandle<long>.remove_Completed
	|-AsyncOperationHandle<object>.remove_Completed
	|
	|-RVA: 0xBD87D0 Offset: 0xBD6DD0 VA: 0x180BD87D0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5FC0 Offset: 0xBD45C0 VA: 0x180BD5FC0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.add_CompletedTypeless
	|-AsyncOperationHandle<SceneInstance>.add_CompletedTypeless
	|
	|-RVA: 0xBD5F30 Offset: 0xBD4530 VA: 0x180BD5F30
	|-AsyncOperationHandle<bool>.add_CompletedTypeless
	|
	|-RVA: 0xBD6050 Offset: 0xBD4650 VA: 0x180BD6050
	|-AsyncOperationHandle<long>.add_CompletedTypeless
	|-AsyncOperationHandle<object>.add_CompletedTypeless
	|
	|-RVA: 0xBD60E0 Offset: 0xBD46E0 VA: 0x180BD60E0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD8660 Offset: 0xBD6C60 VA: 0x180BD8660
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.remove_CompletedTypeless
	|-AsyncOperationHandle<SceneInstance>.remove_CompletedTypeless
	|
	|-RVA: 0xBD85D0 Offset: 0xBD6BD0 VA: 0x180BD85D0
	|-AsyncOperationHandle<bool>.remove_CompletedTypeless
	|-AsyncOperationHandle<long>.remove_CompletedTypeless
	|-AsyncOperationHandle<object>.remove_CompletedTypeless
	|
	|-RVA: 0xBD86F0 Offset: 0xBD6CF0 VA: 0x180BD86F0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD68F0 Offset: 0xBD4EF0 VA: 0x180BD68F0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_DebugName
	|
	|-RVA: 0xBD6800 Offset: 0xBD4E00 VA: 0x180BD6800
	|-AsyncOperationHandle<bool>.get_DebugName
	|
	|-RVA: 0xBD6B00 Offset: 0xBD5100 VA: 0x180BD6B00
	|-AsyncOperationHandle<long>.get_DebugName
	|
	|-RVA: 0xBD6CE0 Offset: 0xBD52E0 VA: 0x180BD6CE0
	|-AsyncOperationHandle<object>.get_DebugName
	|
	|-RVA: 0xBD6BF0 Offset: 0xBD51F0 VA: 0x180BD6BF0
	|-AsyncOperationHandle<SceneInstance>.get_DebugName
	|
	|-RVA: 0xBD69E0 Offset: 0xBD4FE0 VA: 0x180BD69E0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1
	public void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1C40 Offset: 0xBD0240 VA: 0x180BD1C40
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.GetDependencies
	|-AsyncOperationHandle<SceneInstance>.GetDependencies
	|
	|-RVA: 0xBD1BD0 Offset: 0xBD01D0 VA: 0x180BD1BD0
	|-AsyncOperationHandle<bool>.GetDependencies
	|-AsyncOperationHandle<long>.GetDependencies
	|-AsyncOperationHandle<object>.GetDependencies
	|
	|-RVA: 0xBD1CB0 Offset: 0xBD02B0 VA: 0x180BD1CB0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD66E0 Offset: 0xBD4CE0 VA: 0x180BD66E0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.add_Destroyed
	|
	|-RVA: 0xBD6570 Offset: 0xBD4B70 VA: 0x180BD6570
	|-AsyncOperationHandle<bool>.add_Destroyed
	|
	|-RVA: 0xBD64E0 Offset: 0xBD4AE0 VA: 0x180BD64E0
	|-AsyncOperationHandle<long>.add_Destroyed
	|
	|-RVA: 0xBD6450 Offset: 0xBD4A50 VA: 0x180BD6450
	|-AsyncOperationHandle<object>.add_Destroyed
	|
	|-RVA: 0xBD6770 Offset: 0xBD4D70 VA: 0x180BD6770
	|-AsyncOperationHandle<SceneInstance>.add_Destroyed
	|
	|-RVA: 0xBD6600 Offset: 0xBD4C00 VA: 0x180BD6600
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD8C50 Offset: 0xBD7250 VA: 0x180BD8C50
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.remove_Destroyed
	|
	|-RVA: 0xBD8BA0 Offset: 0xBD71A0 VA: 0x180BD8BA0
	|-AsyncOperationHandle<bool>.remove_Destroyed
	|
	|-RVA: 0xBD8D00 Offset: 0xBD7300 VA: 0x180BD8D00
	|-AsyncOperationHandle<long>.remove_Destroyed
	|
	|-RVA: 0xBD8DB0 Offset: 0xBD73B0 VA: 0x180BD8DB0
	|-AsyncOperationHandle<object>.remove_Destroyed
	|
	|-RVA: 0xBD8A10 Offset: 0xBD7010 VA: 0x180BD8A10
	|-AsyncOperationHandle<SceneInstance>.remove_Destroyed
	|
	|-RVA: 0xBD8AC0 Offset: 0xBD70C0 VA: 0x180BD8AC0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(AsyncOperationHandle<TObject> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1BA0 Offset: 0xBD01A0 VA: 0x180BD1BA0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.Equals
	|-AsyncOperationHandle<bool>.Equals
	|-AsyncOperationHandle<long>.Equals
	|-AsyncOperationHandle<object>.Equals
	|-AsyncOperationHandle<SceneInstance>.Equals
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2200 Offset: 0xBD0800 VA: 0x180BD2200
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.GetHashCode
	|-AsyncOperationHandle<bool>.GetHashCode
	|-AsyncOperationHandle<long>.GetHashCode
	|-AsyncOperationHandle<object>.GetHashCode
	|-AsyncOperationHandle<SceneInstance>.GetHashCode
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public TObject WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD3C70 Offset: 0xBD2270 VA: 0x180BD3C70
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.WaitForCompletion
	|
	|-RVA: 0xBD4620 Offset: 0xBD2C20 VA: 0x180BD4620
	|-AsyncOperationHandle<bool>.WaitForCompletion
	|
	|-RVA: 0xBD3FA0 Offset: 0xBD25A0 VA: 0x180BD3FA0
	|-AsyncOperationHandle<long>.WaitForCompletion
	|
	|-RVA: 0xBD3980 Offset: 0xBD1F80 VA: 0x180BD3980
	|-AsyncOperationHandle<object>.WaitForCompletion
	|
	|-RVA: 0xBD3650 Offset: 0xBD1C50 VA: 0x180BD3650
	|-AsyncOperationHandle<SceneInstance>.WaitForCompletion
	|
	|-RVA: 0xBD4290 Offset: 0xBD2890 VA: 0x180BD4290
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationBase<TObject> get_InternalOp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD6E60 Offset: 0xBD5460 VA: 0x180BD6E60
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_InternalOp
	|-AsyncOperationHandle<SceneInstance>.get_InternalOp
	|
	|-RVA: 0xBD6DD0 Offset: 0xBD53D0 VA: 0x180BD6DD0
	|-AsyncOperationHandle<bool>.get_InternalOp
	|-AsyncOperationHandle<long>.get_InternalOp
	|-AsyncOperationHandle<object>.get_InternalOp
	|
	|-RVA: 0xBD6EF0 Offset: 0xBD54F0 VA: 0x180BD6EF0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_InternalOp
	*/

	// RVA: -1 Offset: -1
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD71C0 Offset: 0xBD57C0 VA: 0x180BD71C0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_IsDone
	|-AsyncOperationHandle<SceneInstance>.get_IsDone
	|
	|-RVA: 0xBD7290 Offset: 0xBD5890 VA: 0x180BD7290
	|-AsyncOperationHandle<bool>.get_IsDone
	|
	|-RVA: 0xBD70F0 Offset: 0xBD56F0 VA: 0x180BD70F0
	|-AsyncOperationHandle<long>.get_IsDone
	|-AsyncOperationHandle<object>.get_IsDone
	|
	|-RVA: 0xBD6FC0 Offset: 0xBD55C0 VA: 0x180BD6FC0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	public bool IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2BB0 Offset: 0xBD11B0 VA: 0x180BD2BB0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.IsValid
	|-AsyncOperationHandle<SceneInstance>.IsValid
	|
	|-RVA: 0xBD2CA0 Offset: 0xBD12A0 VA: 0x180BD2CA0
	|-AsyncOperationHandle<bool>.IsValid
	|-AsyncOperationHandle<long>.IsValid
	|-AsyncOperationHandle<object>.IsValid
	|
	|-RVA: 0xBD2C00 Offset: 0xBD1200 VA: 0x180BD2C00
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.IsValid
	*/

	// RVA: -1 Offset: -1
	public Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD73D0 Offset: 0xBD59D0 VA: 0x180BD73D0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_OperationException
	|-AsyncOperationHandle<SceneInstance>.get_OperationException
	|
	|-RVA: 0xBD7360 Offset: 0xBD5960 VA: 0x180BD7360
	|-AsyncOperationHandle<bool>.get_OperationException
	|-AsyncOperationHandle<long>.get_OperationException
	|-AsyncOperationHandle<object>.get_OperationException
	|
	|-RVA: 0xBD7440 Offset: 0xBD5A40 VA: 0x180BD7440
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	public float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD75E0 Offset: 0xBD5BE0 VA: 0x180BD75E0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_PercentComplete
	|-AsyncOperationHandle<SceneInstance>.get_PercentComplete
	|
	|-RVA: 0xBD76E0 Offset: 0xBD5CE0 VA: 0x180BD76E0
	|-AsyncOperationHandle<bool>.get_PercentComplete
	|
	|-RVA: 0xBD7660 Offset: 0xBD5C60 VA: 0x180BD7660
	|-AsyncOperationHandle<long>.get_PercentComplete
	|-AsyncOperationHandle<object>.get_PercentComplete
	|
	|-RVA: 0xBD7510 Offset: 0xBD5B10 VA: 0x180BD7510
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD7760 Offset: 0xBD5D60 VA: 0x180BD7760
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_ReferenceCount
	|-AsyncOperationHandle<SceneInstance>.get_ReferenceCount
	|
	|-RVA: 0xBD77D0 Offset: 0xBD5DD0 VA: 0x180BD77D0
	|-AsyncOperationHandle<bool>.get_ReferenceCount
	|
	|-RVA: 0xBD7910 Offset: 0xBD5F10 VA: 0x180BD7910
	|-AsyncOperationHandle<long>.get_ReferenceCount
	|-AsyncOperationHandle<object>.get_ReferenceCount
	|
	|-RVA: 0xBD7840 Offset: 0xBD5E40 VA: 0x180BD7840
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2D90 Offset: 0xBD1390 VA: 0x180BD2D90
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.Release
	|
	|-RVA: 0xBD2CF0 Offset: 0xBD12F0 VA: 0x180BD2CF0
	|-AsyncOperationHandle<bool>.Release
	|
	|-RVA: 0xBD2ED0 Offset: 0xBD14D0 VA: 0x180BD2ED0
	|-AsyncOperationHandle<long>.Release
	|
	|-RVA: 0xBD2E30 Offset: 0xBD1430 VA: 0x180BD2E30
	|-AsyncOperationHandle<object>.Release
	|
	|-RVA: 0xBD3060 Offset: 0xBD1660 VA: 0x180BD3060
	|-AsyncOperationHandle<SceneInstance>.Release
	|
	|-RVA: 0xBD2F70 Offset: 0xBD1570 VA: 0x180BD2F70
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD7BB0 Offset: 0xBD61B0 VA: 0x180BD7BB0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_Result
	|-AsyncOperationHandle<SceneInstance>.get_Result
	|
	|-RVA: 0xBD7B40 Offset: 0xBD6140 VA: 0x180BD7B40
	|-AsyncOperationHandle<bool>.get_Result
	|
	|-RVA: 0xBD7AD0 Offset: 0xBD60D0 VA: 0x180BD7AD0
	|-AsyncOperationHandle<long>.get_Result
	|-AsyncOperationHandle<object>.get_Result
	|
	|-RVA: 0xBD7980 Offset: 0xBD5F80 VA: 0x180BD7980
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD7CA0 Offset: 0xBD62A0 VA: 0x180BD7CA0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_Status
	|-AsyncOperationHandle<SceneInstance>.get_Status
	|
	|-RVA: 0xBD7910 Offset: 0xBD5F10 VA: 0x180BD7910
	|-AsyncOperationHandle<bool>.get_Status
	|
	|-RVA: 0xBD7C30 Offset: 0xBD6230 VA: 0x180BD7C30
	|-AsyncOperationHandle<long>.get_Status
	|-AsyncOperationHandle<object>.get_Status
	|
	|-RVA: 0xBD7D10 Offset: 0xBD6310 VA: 0x180BD7D10
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	public Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD7EB0 Offset: 0xBD64B0 VA: 0x180BD7EB0
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.get_Task
	|
	|-RVA: 0xBD8430 Offset: 0xBD6A30 VA: 0x180BD8430
	|-AsyncOperationHandle<bool>.get_Task
	|
	|-RVA: 0xBD8170 Offset: 0xBD6770 VA: 0x180BD8170
	|-AsyncOperationHandle<long>.get_Task
	|
	|-RVA: 0xBD82D0 Offset: 0xBD68D0 VA: 0x180BD82D0
	|-AsyncOperationHandle<object>.get_Task
	|
	|-RVA: 0xBD8010 Offset: 0xBD6610 VA: 0x180BD8010
	|-AsyncOperationHandle<SceneInstance>.get_Task
	|
	|-RVA: 0xBD7DE0 Offset: 0xBD63E0 VA: 0x180BD7DE0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD3350 Offset: 0xBD1950 VA: 0x180BD3350
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.System.Collections.IEnumerator.get_Current
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBD3580 Offset: 0xBD1B80 VA: 0x180BD3580
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBD3420 Offset: 0xBD1A20 VA: 0x180BD3420
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBD34F0 Offset: 0xBD1AF0 VA: 0x180BD34F0
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBD3240 Offset: 0xBD1840 VA: 0x180BD3240
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD3180 Offset: 0xBD1780 VA: 0x180BD3180
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.System.Collections.IEnumerator.MoveNext
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0xBD3100 Offset: 0xBD1700 VA: 0x180BD3100
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0xBD3140 Offset: 0xBD1740 VA: 0x180BD3140
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.MoveNext
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0xBD31C0 Offset: 0xBD17C0 VA: 0x180BD31C0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-AsyncOperationHandle<LocalizedDatabase.TableEntryResult<object, object>>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.Reset
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle : IEnumerator // TypeDefIndex: 12736
{
	// Fields
	internal IAsyncOperation m_InternalOp; // 0x0
	private int m_Version; // 0x8
	private string m_LocationName; // 0x10

	// Properties
	internal string LocationName { get; set; }
	public string DebugName { get; }
	private IAsyncOperation InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public object Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<object> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string get_LocationName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_LocationName(string value) { }

	// RVA: 0x21187B0 Offset: 0x2116DB0 VA: 0x1821187B0
	internal void .ctor(IAsyncOperation op) { }

	// RVA: 0x2118720 Offset: 0x2116D20 VA: 0x182118720
	internal void .ctor(IAsyncOperation op, int version) { }

	// RVA: 0x2118830 Offset: 0x2116E30 VA: 0x182118830
	internal void .ctor(IAsyncOperation op, string locationName) { }

	// RVA: 0x2118760 Offset: 0x2116D60 VA: 0x182118760
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }

	// RVA: 0x2118110 Offset: 0x2116710 VA: 0x182118110
	internal AsyncOperationHandle Acquire() { }

	// RVA: 0x21188C0 Offset: 0x2116EC0 VA: 0x1821188C0
	public void add_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x2118EC0 Offset: 0x21174C0 VA: 0x182118EC0
	public void remove_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> Convert<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65F480 Offset: 0x65DA80 VA: 0x18065F480
	|-AsyncOperationHandle.Convert<object>
	|-AsyncOperationHandle.Convert<SceneInstance>
	|-AsyncOperationHandle.Convert<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xBD1BA0 Offset: 0xBD01A0 VA: 0x180BD1BA0
	public bool Equals(AsyncOperationHandle other) { }

	// RVA: 0x21189A0 Offset: 0x2116FA0 VA: 0x1821189A0
	public string get_DebugName() { }

	// RVA: 0x2118930 Offset: 0x2116F30 VA: 0x182118930
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x2118F30 Offset: 0x2117530 VA: 0x182118F30
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x2118190 Offset: 0x2116790 VA: 0x182118190
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0xBD2200 Offset: 0xBD0800 VA: 0x180BD2200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2118A50 Offset: 0x2117050 VA: 0x182118A50
	private IAsyncOperation get_InternalOp() { }

	// RVA: 0x2118AF0 Offset: 0x21170F0 VA: 0x182118AF0
	public bool get_IsDone() { }

	// RVA: 0x21184A0 Offset: 0x2116AA0 VA: 0x1821184A0
	public bool IsValid() { }

	// RVA: 0x2118B90 Offset: 0x2117190 VA: 0x182118B90
	public Exception get_OperationException() { }

	// RVA: 0x2118C60 Offset: 0x2117260 VA: 0x182118C60
	public float get_PercentComplete() { }

	// RVA: 0x2118260 Offset: 0x2116860 VA: 0x182118260
	public DownloadStatus GetDownloadStatus() { }

	// RVA: 0x2118300 Offset: 0x2116900 VA: 0x182118300
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x2118D30 Offset: 0x2117330 VA: 0x182118D30
	internal int get_ReferenceCount() { }

	// RVA: 0x2118500 Offset: 0x2116B00 VA: 0x182118500
	internal void Release() { }

	// RVA: 0x2118590 Offset: 0x2116B90 VA: 0x182118590
	public object get_Result() { }

	// RVA: 0x2118D90 Offset: 0x2117390 VA: 0x182118D90
	public AsyncOperationStatus get_Status() { }

	// RVA: 0x2118DF0 Offset: 0x21173F0 VA: 0x182118DF0
	public Task<object> get_Task() { }

	// RVA: 0x2118590 Offset: 0x2116B90 VA: 0x182118590 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2118570 Offset: 0x2116B70 VA: 0x182118570 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x21185E0 Offset: 0x2116BE0 VA: 0x1821185E0
	public object WaitForCompletion() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public enum AsyncOperationStatus // TypeDefIndex: 12737
{
	// Fields
	public int value__; // 0x0
	public const AsyncOperationStatus None = 0;
	public const AsyncOperationStatus Succeeded = 1;
	public const AsyncOperationStatus Failed = 2;
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct DownloadStatus // TypeDefIndex: 12738
{
	// Fields
	public long TotalBytes; // 0x0
	public long DownloadedBytes; // 0x8
	public bool IsDone; // 0x10

	// Properties
	public float Percent { get; }

	// Methods

	// RVA: 0x211D0B0 Offset: 0x211B6B0 VA: 0x18211D0B0
	public float get_Percent() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>, ICachable // TypeDefIndex: 12740
{
	// Fields
	private Action<AsyncOperationHandle> m_InternalOnComplete; // 0x98
	private int m_LoadedCount; // 0xA0
	private GroupOperation.GroupOperationSettings m_Settings; // 0xA4
	private string debugName; // 0xA8
	private const int k_MaxDisplayedLocationLength = 45;
	[CompilerGenerated]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0xB0
	private HashSet<string> m_CachedDependencyLocations; // 0xB8

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x211E390 Offset: 0x211C990 VA: 0x18211E390
	public void .ctor() { }

	// RVA: 0x211DDF0 Offset: 0x211C3F0 VA: 0x18211DDF0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	[CompilerGenerated]
	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0 Slot: 36
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }

	[CompilerGenerated]
	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860 Slot: 37
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }

	// RVA: 0x211D980 Offset: 0x211BF80 VA: 0x18211D980
	internal IList<AsyncOperationHandle> GetDependentOps() { }

	// RVA: 0x211D920 Offset: 0x211BF20 VA: 0x18211D920 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x211E040 Offset: 0x211C640 VA: 0x18211E040 Slot: 34
	internal override void ReleaseDependencies() { }

	// RVA: 0x211D9C0 Offset: 0x211BFC0 VA: 0x18211D9C0 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x211D390 Offset: 0x211B990 VA: 0x18211D390
	private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps) { }

	// RVA: 0x211E4D0 Offset: 0x211CAD0 VA: 0x18211E4D0 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x211D550 Offset: 0x211BB50 VA: 0x18211D550 Slot: 28
	protected override void Execute() { }

	// RVA: 0x211D0E0 Offset: 0x211B6E0 VA: 0x18211D0E0
	private void CompleteIfDependenciesComplete() { }

	// RVA: 0x211D530 Offset: 0x211BB30 VA: 0x18211D530 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x211E790 Offset: 0x211CD90 VA: 0x18211E790 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x211DD30 Offset: 0x211C330 VA: 0x18211DD30
	public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = True, bool allowFailedDependencies = False) { }

	// RVA: 0x211DC90 Offset: 0x211C290 VA: 0x18211DC90
	public void Init(List<AsyncOperationHandle> operations, GroupOperation.GroupOperationSettings settings) { }

	// RVA: 0x211E030 Offset: 0x211C630 VA: 0x18211E030
	private void OnOperationCompleted(AsyncOperationHandle op) { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface IGenericProviderOperation // TypeDefIndex: 12741
{
	// Properties
	public abstract int ProvideHandleVersion { get; }
	public abstract IResourceLocation Location { get; }
	public abstract int DependencyCount { get; }
	public abstract Type RequestedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ProvideHandleVersion();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IResourceLocation get_Location();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetDependencies(IList<object> dstList);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TDepObject GetDependency<TDepObject>(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetProgressCallback(Func<float> callback);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ProviderCompleted<T>(T result, bool status, Exception e);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.ProviderCompleted<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_RequestedType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetDownloadProgressCallback(Func<DownloadStatus> callback);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetWaitForCompletionCallback(Func<bool> callback);
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
[Preserve]
internal class ProviderOperation<TObject> : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable // TypeDefIndex: 12742
{
	// Fields
	private bool m_ReleaseDependenciesOnFailure; // 0x0
	private Action<int, object, bool, Exception> m_CompletionCallback; // 0x0
	private Action<int, IList<object>> m_GetDepCallback; // 0x0
	private Func<float> m_GetProgressCallback; // 0x0
	private Func<DownloadStatus> m_GetDownloadProgressCallback; // 0x0
	private Func<bool> m_WaitForCompletionCallback; // 0x0
	private bool m_ProviderCompletedCalled; // 0x0
	private DownloadStatus m_DownloadStatus; // 0x0
	private IResourceProvider m_Provider; // 0x0
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x0
	private IResourceLocation m_Location; // 0x0
	private int m_ProvideHandleVersion; // 0x0
	private bool m_NeedsRelease; // 0x0
	[CompilerGenerated]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0x0
	private ResourceManager m_ResourceManager; // 0x0
	private const float k_OperationWaitingToCompletePercentComplete = 0.99;
	internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	public int ProvideHandleVersion { get; }
	public IResourceLocation Location { get; }
	protected override string DebugName { get; }
	public Type RequestedType { get; }
	public int DependencyCount { get; }
	protected override float Progress { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 48
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key
	|
	|-RVA: 0x8DA920 Offset: 0x8D8F20 VA: 0x1808DA920
	|-ProviderOperation<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 49
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DA9C0 Offset: 0x8D8FC0 VA: 0x1808DA9C0
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key
	|
	|-RVA: 0x8DA950 Offset: 0x8D8F50 VA: 0x1808DA950
	|-ProviderOperation<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public int get_ProvideHandleVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DB840 Offset: 0x8D9E40 VA: 0x1808DB840
	|-ProviderOperation<object>.get_ProvideHandleVersion
	|
	|-RVA: 0x8DB850 Offset: 0x8D9E50 VA: 0x1808DB850
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_ProvideHandleVersion
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public IResourceLocation get_Location() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	|-ProviderOperation<object>.get_Location
	|
	|-RVA: 0x8DB160 Offset: 0x8D9760 VA: 0x1808DB160
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_Location
	*/

	// RVA: -1 Offset: -1 Slot: 46
	public void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DA630 Offset: 0x8D8C30 VA: 0x1808DA630
	|-ProviderOperation<object>.SetDownloadProgressCallback
	|
	|-RVA: 0x8DA690 Offset: 0x8D8C90 VA: 0x1808DA690
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetDownloadProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 47
	public void SetWaitForCompletionCallback(Func<bool> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	|-ProviderOperation<object>.SetWaitForCompletionCallback
	|
	|-RVA: 0x8DA880 Offset: 0x8D8E80 VA: 0x1808DA880
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetWaitForCompletionCallback
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DA3B0 Offset: 0x8D89B0 VA: 0x1808DA3B0
	|-ProviderOperation<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x8DA140 Offset: 0x8D8740 VA: 0x1808DA140
	|-ProviderOperation<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D93A0 Offset: 0x8D79A0 VA: 0x1808D93A0
	|-ProviderOperation<object>.GetDownloadStatus
	|
	|-RVA: 0x8D94F0 Offset: 0x8D7AF0 VA: 0x1808D94F0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DACB0 Offset: 0x8D92B0 VA: 0x1808DACB0
	|-ProviderOperation<object>..ctor
	|
	|-RVA: 0x8DAC30 Offset: 0x8D9230 VA: 0x1808DAC30
	|-ProviderOperation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D89C0 Offset: 0x8D6FC0 VA: 0x1808D89C0
	|-ProviderOperation<object>.GetDependencies
	|
	|-RVA: 0x8D8E30 Offset: 0x8D7430 VA: 0x1808D8E30
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DA500 Offset: 0x8D8B00 VA: 0x1808DA500
	|-ProviderOperation<object>.ReleaseDependencies
	|
	|-RVA: 0x8DA570 Offset: 0x8D8B70 VA: 0x1808DA570
	|-ProviderOperation<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DAE40 Offset: 0x8D9440 VA: 0x1808DAE40
	|-ProviderOperation<object>.get_DebugName
	|
	|-RVA: 0x8DACD0 Offset: 0x8D92D0 VA: 0x1808DACD0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void GetDependencies(IList<object> dstList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D8B10 Offset: 0x8D7110 VA: 0x1808D8B10
	|-ProviderOperation<object>.GetDependencies
	|
	|-RVA: 0x8D8FD0 Offset: 0x8D75D0 VA: 0x1808D8FD0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public Type get_RequestedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DB880 Offset: 0x8D9E80 VA: 0x1808DB880
	|-ProviderOperation<object>.get_RequestedType
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_RequestedType
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int get_DependencyCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DAF60 Offset: 0x8D9560 VA: 0x1808DAF60
	|-ProviderOperation<object>.get_DependencyCount
	|
	|-RVA: 0x8DB010 Offset: 0x8D9610 VA: 0x1808DB010
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_DependencyCount
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6078A0 Offset: 0x605EA0 VA: 0x1806078A0
	|-ProviderOperation<object>.GetDependency<object>
	|
	|-RVA: 0x607670 Offset: 0x605C70 VA: 0x180607670
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 43
	public void SetProgressCallback(Func<float> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	|-ProviderOperation<object>.SetProgressCallback
	|
	|-RVA: 0x8DA7F0 Offset: 0x8D8DF0 VA: 0x1808DA7F0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public void ProviderCompleted<T>(T result, bool status, Exception e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x608440 Offset: 0x606A40 VA: 0x180608440
	|-ProviderOperation<object>.ProviderCompleted<object>
	|
	|-RVA: 0x607A30 Offset: 0x606030 VA: 0x180607A30
	|-ProviderOperation<__Il2CppFullySharedGenericType>.ProviderCompleted<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DB560 Offset: 0x8D9B60 VA: 0x1808DB560
	|-ProviderOperation<object>.get_Progress
	|
	|-RVA: 0x8DB190 Offset: 0x8D9790 VA: 0x1808DB190
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D82D0 Offset: 0x8D68D0 VA: 0x1808D82D0
	|-ProviderOperation<object>.Execute
	|
	|-RVA: 0x8D8540 Offset: 0x8D6B40 VA: 0x1808D8540
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D9CA0 Offset: 0x8D82A0 VA: 0x1808D9CA0
	|-ProviderOperation<object>.Init
	|
	|-RVA: 0x8D9E10 Offset: 0x8D8410 VA: 0x1808D9E10
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D9B30 Offset: 0x8D8130 VA: 0x1808D9B30
	|-ProviderOperation<object>.Init
	|
	|-RVA: 0x8D97F0 Offset: 0x8D7DF0 VA: 0x1808D97F0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1
	private bool WaitForCompletionHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DAB50 Offset: 0x8D9150 VA: 0x1808DAB50
	|-ProviderOperation<object>.WaitForCompletionHandler
	|
	|-RVA: 0x8DA9E0 Offset: 0x8D8FE0 VA: 0x1808DA9E0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.WaitForCompletionHandler
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D81F0 Offset: 0x8D67F0 VA: 0x1808D81F0
	|-ProviderOperation<object>.Destroy
	|
	|-RVA: 0x8D7EF0 Offset: 0x8D64F0 VA: 0x1808D7EF0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Destroy
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class UnityWebRequestOperation : AsyncOperationBase<UnityWebRequest> // TypeDefIndex: 12743
{
	// Fields
	private UnityWebRequest m_UWR; // 0x98

	// Methods

	// RVA: 0x212E150 Offset: 0x212C750 VA: 0x18212E150
	public void .ctor(UnityWebRequest webRequest) { }

	// RVA: 0x212E010 Offset: 0x212C610 VA: 0x18212E010 Slot: 28
	protected override void Execute() { }

	[CompilerGenerated]
	// RVA: 0x212E0B0 Offset: 0x212C6B0 VA: 0x18212E0B0
	private void <Execute>b__2_0(AsyncOperation request) { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class InitalizationObjectsOperation : AsyncOperationBase<bool> // TypeDefIndex: 13077
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp; // 0x98
	private AddressablesImpl m_Addressables; // 0xB8
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xC0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x1EB6F30 Offset: 0x1EB5530 VA: 0x181EB6F30
	public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables) { }

	// RVA: 0x1EB7500 Offset: 0x1EB5B00 VA: 0x181EB7500 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x1EB7140 Offset: 0x1EB5740 VA: 0x181EB7140
	internal bool LogRuntimeWarnings(string pathToBuildLogs) { }

	// RVA: 0x1EB6FB0 Offset: 0x1EB55B0 VA: 0x181EB6FB0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x1EB6950 Offset: 0x1EB4F50 VA: 0x181EB6950 Slot: 28
	protected override void Execute() { }

	// RVA: 0x1EB74C0 Offset: 0x1EB5AC0 VA: 0x181EB74C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EB7320 Offset: 0x1EB5920 VA: 0x181EB7320
	private void <Execute>b__8_0(AsyncOperationHandle<IList<AsyncOperationHandle>> obj) { }
}

