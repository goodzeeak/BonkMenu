// Namespace: UnityEngine.ResourceManagement
internal class ChainOperation<TObject, TObjectDependency> : AsyncOperationBase<TObject> // TypeDefIndex: 12629
{
	// Fields
	private AsyncOperationHandle<TObjectDependency> m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9A7E0 Offset: 0xC98DE0 VA: 0x180C9A7E0
	|-ChainOperation<long, object>..ctor
	|
	|-RVA: 0xC9A880 Offset: 0xC98E80 VA: 0x180C9A880
	|-ChainOperation<object, object>..ctor
	|
	|-RVA: 0xC9AA50 Offset: 0xC99050 VA: 0x180C9AA50
	|-ChainOperation<SceneInstance, SceneInstance>..ctor
	|
	|-RVA: 0xC9A920 Offset: 0xC98F20 VA: 0x180C9A920
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9AD00 Offset: 0xC99300 VA: 0x180C9AD00
	|-ChainOperation<long, object>.get_DebugName
	|
	|-RVA: 0xC9B0C0 Offset: 0xC996C0 VA: 0x180C9B0C0
	|-ChainOperation<object, object>.get_DebugName
	|
	|-RVA: 0xC9AEE0 Offset: 0xC994E0 VA: 0x180C9AEE0
	|-ChainOperation<SceneInstance, SceneInstance>.get_DebugName
	|
	|-RVA: 0xC9AAF0 Offset: 0xC990F0 VA: 0x180C9AAF0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC986F0 Offset: 0xC96CF0 VA: 0x180C986F0
	|-ChainOperation<long, object>.GetDependencies
	|
	|-RVA: 0xC989D0 Offset: 0xC96FD0 VA: 0x180C989D0
	|-ChainOperation<object, object>.GetDependencies
	|
	|-RVA: 0xC98B20 Offset: 0xC97120 VA: 0x180C98B20
	|-ChainOperation<SceneInstance, SceneInstance>.GetDependencies
	|
	|-RVA: 0xC98840 Offset: 0xC96E40 VA: 0x180C98840
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC99050 Offset: 0xC97650 VA: 0x180C99050
	|-ChainOperation<long, object>.Init
	|
	|-RVA: 0xC98FA0 Offset: 0xC975A0 VA: 0x180C98FA0
	|-ChainOperation<object, object>.Init
	|
	|-RVA: 0xC99280 Offset: 0xC97880 VA: 0x180C99280
	|-ChainOperation<SceneInstance, SceneInstance>.Init
	|
	|-RVA: 0xC99100 Offset: 0xC97700 VA: 0x180C99100
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC994A0 Offset: 0xC97AA0 VA: 0x180C994A0
	|-ChainOperation<long, object>.InvokeWaitForCompletion
	|
	|-RVA: 0xC998F0 Offset: 0xC97EF0 VA: 0x180C998F0
	|-ChainOperation<object, object>.InvokeWaitForCompletion
	|
	|-RVA: 0xC99330 Offset: 0xC97930 VA: 0x180C99330
	|-ChainOperation<SceneInstance, SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0xC99600 Offset: 0xC97C00 VA: 0x180C99600
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC98370 Offset: 0xC96970 VA: 0x180C98370
	|-ChainOperation<long, object>.Execute
	|-ChainOperation<object, object>.Execute
	|
	|-RVA: 0xC98440 Offset: 0xC96A40 VA: 0x180C98440
	|-ChainOperation<SceneInstance, SceneInstance>.Execute
	|
	|-RVA: 0xC98510 Offset: 0xC96B10 VA: 0x180C98510
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC99A50 Offset: 0xC98050 VA: 0x180C99A50
	|-ChainOperation<long, object>.OnWrappedCompleted
	|
	|-RVA: 0xC99E00 Offset: 0xC98400 VA: 0x180C99E00
	|-ChainOperation<object, object>.OnWrappedCompleted
	|
	|-RVA: 0xC99F50 Offset: 0xC98550 VA: 0x180C99F50
	|-ChainOperation<SceneInstance, SceneInstance>.OnWrappedCompleted
	|
	|-RVA: 0xC99BA0 Offset: 0xC981A0 VA: 0x180C99BA0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC98050 Offset: 0xC96650 VA: 0x180C98050
	|-ChainOperation<long, object>.Destroy
	|
	|-RVA: 0xC98190 Offset: 0xC96790 VA: 0x180C98190
	|-ChainOperation<object, object>.Destroy
	|
	|-RVA: 0xC980F0 Offset: 0xC966F0 VA: 0x180C980F0
	|-ChainOperation<SceneInstance, SceneInstance>.Destroy
	|
	|-RVA: 0xC98230 Offset: 0xC96830 VA: 0x180C98230
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9A6D0 Offset: 0xC98CD0 VA: 0x180C9A6D0
	|-ChainOperation<long, object>.ReleaseDependencies
	|-ChainOperation<object, object>.ReleaseDependencies
	|
	|-RVA: 0xC9A670 Offset: 0xC98C70 VA: 0x180C9A670
	|-ChainOperation<SceneInstance, SceneInstance>.ReleaseDependencies
	|
	|-RVA: 0xC9A730 Offset: 0xC98D30 VA: 0x180C9A730
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC98F00 Offset: 0xC97500 VA: 0x180C98F00
	|-ChainOperation<long, object>.GetDownloadStatus
	|
	|-RVA: 0xC98C70 Offset: 0xC97270 VA: 0x180C98C70
	|-ChainOperation<object, object>.GetDownloadStatus
	|
	|-RVA: 0xC98E60 Offset: 0xC97460 VA: 0x180C98E60
	|-ChainOperation<SceneInstance, SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xC98D10 Offset: 0xC97310 VA: 0x180C98D10
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9A550 Offset: 0xC98B50 VA: 0x180C9A550
	|-ChainOperation<long, object>.RefreshDownloadStatus
	|
	|-RVA: 0xC9A0B0 Offset: 0xC986B0 VA: 0x180C9A0B0
	|-ChainOperation<object, object>.RefreshDownloadStatus
	|
	|-RVA: 0xC9A430 Offset: 0xC98A30 VA: 0x180C9A430
	|-ChainOperation<SceneInstance, SceneInstance>.RefreshDownloadStatus
	|
	|-RVA: 0xC9A1D0 Offset: 0xC987D0 VA: 0x180C9A1D0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9B2A0 Offset: 0xC998A0 VA: 0x180C9B2A0
	|-ChainOperation<long, object>.get_Progress
	|
	|-RVA: 0xC9B820 Offset: 0xC99E20 VA: 0x180C9B820
	|-ChainOperation<object, object>.get_Progress
	|
	|-RVA: 0xC9B440 Offset: 0xC99A40 VA: 0x180C9B440
	|-ChainOperation<SceneInstance, SceneInstance>.get_Progress
	|
	|-RVA: 0xC9B5E0 Offset: 0xC99BE0 VA: 0x180C9B5E0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Progress
	*/
}

// Namespace: UnityEngine.ResourceManagement
internal class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 12630
{
	// Fields
	private AsyncOperationHandle m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	internal AsyncOperationHandle<TObject> WrappedOp { get; }
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> get_WrappedOp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC98010 Offset: 0xC96610 VA: 0x180C98010
	|-ChainOperationTypelessDepedency<bool>.get_WrappedOp
	|-ChainOperationTypelessDepedency<long>.get_WrappedOp
	|-ChainOperationTypelessDepedency<object>.get_WrappedOp
	|
	|-RVA: 0xC98030 Offset: 0xC96630 VA: 0x180C98030
	|-ChainOperationTypelessDepedency<SceneInstance>.get_WrappedOp
	|
	|-RVA: 0xC97FC0 Offset: 0xC965C0 VA: 0x180C97FC0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_WrappedOp
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC97250 Offset: 0xC95850 VA: 0x180C97250
	|-ChainOperationTypelessDepedency<bool>..ctor
	|
	|-RVA: 0xC972F0 Offset: 0xC958F0 VA: 0x180C972F0
	|-ChainOperationTypelessDepedency<long>..ctor
	|
	|-RVA: 0xC971B0 Offset: 0xC957B0 VA: 0x180C971B0
	|-ChainOperationTypelessDepedency<object>..ctor
	|
	|-RVA: 0xC96FE0 Offset: 0xC955E0 VA: 0x180C96FE0
	|-ChainOperationTypelessDepedency<SceneInstance>..ctor
	|
	|-RVA: 0xC97080 Offset: 0xC95680 VA: 0x180C97080
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC97390 Offset: 0xC95990 VA: 0x180C97390
	|-ChainOperationTypelessDepedency<bool>.get_DebugName
	|
	|-RVA: 0xC97530 Offset: 0xC95B30 VA: 0x180C97530
	|-ChainOperationTypelessDepedency<long>.get_DebugName
	|
	|-RVA: 0xC97460 Offset: 0xC95A60 VA: 0x180C97460
	|-ChainOperationTypelessDepedency<object>.get_DebugName
	|
	|-RVA: 0xC97600 Offset: 0xC95C00 VA: 0x180C97600
	|-ChainOperationTypelessDepedency<SceneInstance>.get_DebugName
	|
	|-RVA: 0xC976D0 Offset: 0xC95CD0 VA: 0x180C976D0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC94ED0 Offset: 0xC934D0 VA: 0x180C94ED0
	|-ChainOperationTypelessDepedency<bool>.GetDependencies
	|
	|-RVA: 0xC950B0 Offset: 0xC936B0 VA: 0x180C950B0
	|-ChainOperationTypelessDepedency<long>.GetDependencies
	|
	|-RVA: 0xC94FC0 Offset: 0xC935C0 VA: 0x180C94FC0
	|-ChainOperationTypelessDepedency<object>.GetDependencies
	|
	|-RVA: 0xC951A0 Offset: 0xC937A0 VA: 0x180C951A0
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDependencies
	|
	|-RVA: 0xC94DA0 Offset: 0xC933A0 VA: 0x180C94DA0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC95900 Offset: 0xC93F00 VA: 0x180C95900
	|-ChainOperationTypelessDepedency<bool>.Init
	|
	|-RVA: 0xC956F0 Offset: 0xC93CF0 VA: 0x180C956F0
	|-ChainOperationTypelessDepedency<long>.Init
	|
	|-RVA: 0xC95650 Offset: 0xC93C50 VA: 0x180C95650
	|-ChainOperationTypelessDepedency<object>.Init
	|
	|-RVA: 0xC959A0 Offset: 0xC93FA0 VA: 0x180C959A0
	|-ChainOperationTypelessDepedency<SceneInstance>.Init
	|
	|-RVA: 0xC95790 Offset: 0xC93D90 VA: 0x180C95790
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC95D80 Offset: 0xC94380 VA: 0x180C95D80
	|-ChainOperationTypelessDepedency<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0xC95C70 Offset: 0xC94270 VA: 0x180C95C70
	|-ChainOperationTypelessDepedency<long>.InvokeWaitForCompletion
	|
	|-RVA: 0xC95B60 Offset: 0xC94160 VA: 0x180C95B60
	|-ChainOperationTypelessDepedency<object>.InvokeWaitForCompletion
	|
	|-RVA: 0xC95A40 Offset: 0xC94040 VA: 0x180C95A40
	|-ChainOperationTypelessDepedency<SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0xC95E80 Offset: 0xC94480 VA: 0x180C95E80
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC94940 Offset: 0xC92F40 VA: 0x180C94940
	|-ChainOperationTypelessDepedency<bool>.Execute
	|
	|-RVA: 0xC94A10 Offset: 0xC93010 VA: 0x180C94A10
	|-ChainOperationTypelessDepedency<long>.Execute
	|-ChainOperationTypelessDepedency<object>.Execute
	|
	|-RVA: 0xC94AE0 Offset: 0xC930E0 VA: 0x180C94AE0
	|-ChainOperationTypelessDepedency<SceneInstance>.Execute
	|
	|-RVA: 0xC94BB0 Offset: 0xC931B0 VA: 0x180C94BB0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC96780 Offset: 0xC94D80 VA: 0x180C96780
	|-ChainOperationTypelessDepedency<bool>.OnWrappedCompleted
	|
	|-RVA: 0xC96270 Offset: 0xC94870 VA: 0x180C96270
	|-ChainOperationTypelessDepedency<long>.OnWrappedCompleted
	|
	|-RVA: 0xC96120 Offset: 0xC94720 VA: 0x180C96120
	|-ChainOperationTypelessDepedency<object>.OnWrappedCompleted
	|
	|-RVA: 0xC96620 Offset: 0xC94C20 VA: 0x180C96620
	|-ChainOperationTypelessDepedency<SceneInstance>.OnWrappedCompleted
	|
	|-RVA: 0xC963C0 Offset: 0xC949C0 VA: 0x180C963C0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC948C0 Offset: 0xC92EC0 VA: 0x180C948C0
	|-ChainOperationTypelessDepedency<bool>.Destroy
	|
	|-RVA: 0xC94840 Offset: 0xC92E40 VA: 0x180C94840
	|-ChainOperationTypelessDepedency<long>.Destroy
	|
	|-RVA: 0xC946B0 Offset: 0xC92CB0 VA: 0x180C946B0
	|-ChainOperationTypelessDepedency<object>.Destroy
	|
	|-RVA: 0xC94630 Offset: 0xC92C30 VA: 0x180C94630
	|-ChainOperationTypelessDepedency<SceneInstance>.Destroy
	|
	|-RVA: 0xC94730 Offset: 0xC92D30 VA: 0x180C94730
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC96F30 Offset: 0xC95530 VA: 0x180C96F30
	|-ChainOperationTypelessDepedency<bool>.ReleaseDependencies
	|-ChainOperationTypelessDepedency<long>.ReleaseDependencies
	|-ChainOperationTypelessDepedency<object>.ReleaseDependencies
	|
	|-RVA: 0xC96EF0 Offset: 0xC954F0 VA: 0x180C96EF0
	|-ChainOperationTypelessDepedency<SceneInstance>.ReleaseDependencies
	|
	|-RVA: 0xC96F70 Offset: 0xC95570 VA: 0x180C96F70
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC953D0 Offset: 0xC939D0 VA: 0x180C953D0
	|-ChainOperationTypelessDepedency<bool>.GetDownloadStatus
	|
	|-RVA: 0xC95290 Offset: 0xC93890 VA: 0x180C95290
	|-ChainOperationTypelessDepedency<long>.GetDownloadStatus
	|
	|-RVA: 0xC955B0 Offset: 0xC93BB0 VA: 0x180C955B0
	|-ChainOperationTypelessDepedency<object>.GetDownloadStatus
	|
	|-RVA: 0xC95330 Offset: 0xC93930 VA: 0x180C95330
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0xC95470 Offset: 0xC93A70 VA: 0x180C95470
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC96DF0 Offset: 0xC953F0 VA: 0x180C96DF0
	|-ChainOperationTypelessDepedency<bool>.RefreshDownloadStatus
	|
	|-RVA: 0xC96CF0 Offset: 0xC952F0 VA: 0x180C96CF0
	|-ChainOperationTypelessDepedency<long>.RefreshDownloadStatus
	|
	|-RVA: 0xC96AF0 Offset: 0xC950F0 VA: 0x180C96AF0
	|-ChainOperationTypelessDepedency<object>.RefreshDownloadStatus
	|
	|-RVA: 0xC96BF0 Offset: 0xC951F0 VA: 0x180C96BF0
	|-ChainOperationTypelessDepedency<SceneInstance>.RefreshDownloadStatus
	|
	|-RVA: 0xC968D0 Offset: 0xC94ED0 VA: 0x180C968D0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC97E40 Offset: 0xC96440 VA: 0x180C97E40
	|-ChainOperationTypelessDepedency<bool>.get_Progress
	|
	|-RVA: 0xC977C0 Offset: 0xC95DC0 VA: 0x180C977C0
	|-ChainOperationTypelessDepedency<long>.get_Progress
	|
	|-RVA: 0xC97B40 Offset: 0xC96140 VA: 0x180C97B40
	|-ChainOperationTypelessDepedency<object>.get_Progress
	|
	|-RVA: 0xC97CC0 Offset: 0xC962C0 VA: 0x180C97CC0
	|-ChainOperationTypelessDepedency<SceneInstance>.get_Progress
	|
	|-RVA: 0xC97940 Offset: 0xC95F40 VA: 0x180C97940
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_Progress
	*/
}

// Namespace: UnityEngine.ResourceManagement
public class ResourceManager : IDisposable // TypeDefIndex: 12637
{
	// Fields
	internal bool postProfilerEvents; // 0x10
	[CompilerGenerated]
	private static Action<AsyncOperationHandle, Exception> <ExceptionHandler>k__BackingField; // 0x0
	[CompilerGenerated]
	private Func<IResourceLocation, string> <InternalIdTransformFunc>k__BackingField; // 0x18
	[CompilerGenerated]
	private Action<UnityWebRequest> <WebRequestOverride>k__BackingField; // 0x20
	internal bool CallbackHooksEnabled; // 0x28
	private ListWithEvents<IResourceProvider> m_ResourceProviders; // 0x30
	private IAllocationStrategy m_allocator; // 0x38
	internal ListWithEvents<IUpdateReceiver> m_UpdateReceivers; // 0x40
	private List<IUpdateReceiver> m_UpdateReceiversToRemove; // 0x48
	private bool m_UpdatingReceivers; // 0x50
	private bool m_InsideUpdateMethod; // 0x51
	internal Dictionary<int, IResourceProvider> m_providerMap; // 0x58
	private Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache; // 0x60
	private HashSet<ResourceManager.InstanceOperation> m_TrackedInstanceOperations; // 0x68
	internal DelegateList<float> m_UpdateCallbacks; // 0x70
	private List<IAsyncOperation> m_DeferredCompleteCallbacks; // 0x78
	private HashSet<IResourceProvider> m_AssetBundleProviders; // 0x80
	private bool m_InsideExecuteDeferredCallbacksMethod; // 0x88
	private List<ResourceManager.DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister; // 0x90
	private Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> m_obsoleteDiagnosticsHandler; // 0x98
	private Action<ResourceManager.DiagnosticEventContext> m_diagnosticsHandler; // 0xA0
	private Action<IAsyncOperation> m_ReleaseOpNonCached; // 0xA8
	private Action<IAsyncOperation> m_ReleaseOpCached; // 0xB0
	private Action<IAsyncOperation> m_ReleaseInstanceOp; // 0xB8
	private static int s_GroupOperationTypeHash; // 0x8
	private static int s_InstanceOperationTypeHash; // 0xC
	[CompilerGenerated]
	private CertificateHandler <CertificateHandlerInstance>k__BackingField; // 0xC0
	private bool m_RegisteredForCallbacks; // 0xC8
	private Dictionary<Type, Type> m_ProviderOperationTypeCache; // 0xD0

	// Properties
	public static Action<AsyncOperationHandle, Exception> ExceptionHandler { get; set; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public Action<UnityWebRequest> WebRequestOverride { get; set; }
	internal int OperationCacheCount { get; }
	internal int InstanceOperationCount { get; }
	public IAllocationStrategy Allocator { get; set; }
	public IList<IResourceProvider> ResourceProviders { get; }
	public CertificateHandler CertificateHandlerInstance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x212B810 Offset: 0x2129E10 VA: 0x18212B810
	public static Action<AsyncOperationHandle, Exception> get_ExceptionHandler() { }

	[CompilerGenerated]
	// RVA: 0x212B8F0 Offset: 0x2129EF0 VA: 0x18212B8F0
	public static void set_ExceptionHandler(Action<AsyncOperationHandle, Exception> value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x212AC50 Offset: 0x2129250 VA: 0x18212AC50
	public string TransformInternalId(IResourceLocation location) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Action<UnityWebRequest> get_WebRequestOverride() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x212B8A0 Offset: 0x2129EA0 VA: 0x18212B8A0
	internal int get_OperationCacheCount() { }

	// RVA: 0x212B860 Offset: 0x2129E60 VA: 0x18212B860
	internal int get_InstanceOperationCount() { }

	// RVA: 0x21274C0 Offset: 0x2125AC0 VA: 0x1821274C0
	public void AddUpdateReceiver(IUpdateReceiver receiver) { }

	// RVA: 0x212A9D0 Offset: 0x2128FD0 VA: 0x18212A9D0
	public void RemoveUpdateReciever(IUpdateReceiver receiver) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public IAllocationStrategy get_Allocator() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Allocator(IAllocationStrategy value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public IList<IResourceProvider> get_ResourceProviders() { }

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public CertificateHandler get_CertificateHandlerInstance() { }

	[CompilerGenerated]
	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	public void set_CertificateHandlerInstance(CertificateHandler value) { }

	// RVA: 0x212B300 Offset: 0x2129900 VA: 0x18212B300
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x2128950 Offset: 0x2126F50 VA: 0x182128950
	private void OnObjectAdded(object obj) { }

	// RVA: 0x21289E0 Offset: 0x2126FE0 VA: 0x1821289E0
	private void OnObjectRemoved(object obj) { }

	// RVA: 0x212A3E0 Offset: 0x21289E0 VA: 0x18212A3E0
	internal void RegisterForCallbacks() { }

	[Obsolete("ClearDiagnosticsCallback is Obsolete, use ClearDiagnosticCallbacks instead.")]
	// RVA: 0x2127B10 Offset: 0x2126110 VA: 0x182127B10
	public void ClearDiagnosticsCallback() { }

	// RVA: 0x2127B10 Offset: 0x2126110 VA: 0x182127B10
	public void ClearDiagnosticCallbacks() { }

	// RVA: 0x212ACE0 Offset: 0x21292E0 VA: 0x18212ACE0
	public void UnregisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	[Obsolete]
	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public void RegisterDiagnosticCallback(Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> func) { }

	// RVA: 0x212A320 Offset: 0x2128920 VA: 0x18212A320
	public void RegisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	// RVA: 0x2128C50 Offset: 0x2127250 VA: 0x182128C50
	internal void PostDiagnosticEvent(ResourceManager.DiagnosticEventContext context) { }

	// RVA: 0x2128560 Offset: 0x2126B60 VA: 0x182128560
	public IResourceProvider GetResourceProvider(Type t, IResourceLocation location) { }

	// RVA: 0x21283F0 Offset: 0x21269F0 VA: 0x1821283F0
	private Type GetDefaultTypeForLocation(IResourceLocation loc) { }

	// RVA: 0x2127570 Offset: 0x2125B70 VA: 0x182127570
	private int CalculateLocationsHash(IList<IResourceLocation> locations, Type t) { }

	// RVA: 0x21298A0 Offset: 0x2127EA0 VA: 0x1821298A0
	private AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType, bool releaseDependenciesOnFailure = True) { }

	// RVA: 0x21284B0 Offset: 0x2126AB0 VA: 0x1821284B0
	internal IAsyncOperation GetOperationFromCache(IResourceLocation location, Type desiredType) { }

	// RVA: 0x2127B50 Offset: 0x2126150 VA: 0x182127B50
	internal IOperationCacheKey CreateCacheKeyForLocation(IResourceProvider provider, IResourceLocation location, Type desiredType) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x796580 Offset: 0x794B80 VA: 0x180796580
	|-ResourceManager.ProvideResource<object>
	|
	|-RVA: 0x796490 Offset: 0x794A90 VA: 0x180796490
	|-ResourceManager.ProvideResource<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x797220 Offset: 0x795820 VA: 0x180797220
	|-ResourceManager.StartOperation<LocalizedDatabase.TableEntryResult<object, object>>
	|
	|-RVA: 0x796E20 Offset: 0x795420 VA: 0x180796E20
	|-ResourceManager.StartOperation<bool>
	|
	|-RVA: 0x796FB0 Offset: 0x7955B0 VA: 0x180796FB0
	|-ResourceManager.StartOperation<long>
	|
	|-RVA: 0x797080 Offset: 0x795680 VA: 0x180797080
	|-ResourceManager.StartOperation<object>
	|
	|-RVA: 0x797150 Offset: 0x795750 VA: 0x180797150
	|-ResourceManager.StartOperation<SceneInstance>
	|
	|-RVA: 0x796EF0 Offset: 0x7954F0 VA: 0x180796EF0
	|-ResourceManager.StartOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x212AB10 Offset: 0x2129110 VA: 0x18212AB10
	internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency) { }

	// RVA: 0x2128840 Offset: 0x2126E40 VA: 0x182128840
	private void OnInstanceOperationDestroy(IAsyncOperation o) { }

	// RVA: 0x2128BC0 Offset: 0x21271C0 VA: 0x182128BC0
	private void OnOperationDestroyNonCached(IAsyncOperation o) { }

	// RVA: 0x2128A40 Offset: 0x2127040 VA: 0x182128A40
	private void OnOperationDestroyCached(IAsyncOperation o) { }

	// RVA: -1 Offset: -1
	internal T CreateOperation<T>(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7962C0 Offset: 0x7948C0 VA: 0x1807962C0
	|-ResourceManager.CreateOperation<object>
	|
	|-RVA: 0x795F10 Offset: 0x794510 VA: 0x180795F10
	|-ResourceManager.CreateOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2127420 Offset: 0x2125A20 VA: 0x182127420
	internal void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation) { }

	// RVA: 0x212A930 Offset: 0x2128F30 VA: 0x18212A930
	internal bool RemoveOperationFromCache(IOperationCacheKey key) { }

	// RVA: 0x21287E0 Offset: 0x2126DE0 VA: 0x1821287E0
	internal bool IsOperationCached(IOperationCacheKey key) { }

	// RVA: 0x2127520 Offset: 0x2125B20 VA: 0x182127520
	internal int CachedOperationCount() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7943A0 Offset: 0x7929A0 VA: 0x1807943A0
	|-ResourceManager.CreateCompletedOperation<bool>
	|
	|-RVA: 0x794810 Offset: 0x792E10 VA: 0x180794810
	|-ResourceManager.CreateCompletedOperation<long>
	|
	|-RVA: 0x794910 Offset: 0x792F10 VA: 0x180794910
	|-ResourceManager.CreateCompletedOperation<object>
	|
	|-RVA: 0x794A10 Offset: 0x793010 VA: 0x180794A10
	|-ResourceManager.CreateCompletedOperation<SceneInstance>
	|
	|-RVA: 0x7945B0 Offset: 0x792BB0 VA: 0x1807945B0
	|-ResourceManager.CreateCompletedOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7941B0 Offset: 0x7927B0 VA: 0x1807941B0
	|-ResourceManager.CreateCompletedOperationWithException<long>
	|
	|-RVA: 0x794250 Offset: 0x792850 VA: 0x180794250
	|-ResourceManager.CreateCompletedOperationWithException<object>
	|
	|-RVA: 0x7942F0 Offset: 0x7928F0 VA: 0x1807942F0
	|-ResourceManager.CreateCompletedOperationWithException<SceneInstance>
	|
	|-RVA: 0x794080 Offset: 0x792680 VA: 0x180794080
	|-ResourceManager.CreateCompletedOperationWithException<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x793770 Offset: 0x791D70 VA: 0x180793770
	|-ResourceManager.CreateCompletedOperationInternal<bool>
	|
	|-RVA: 0x793B60 Offset: 0x792160 VA: 0x180793B60
	|-ResourceManager.CreateCompletedOperationInternal<long>
	|
	|-RVA: 0x793D10 Offset: 0x792310 VA: 0x180793D10
	|-ResourceManager.CreateCompletedOperationInternal<object>
	|
	|-RVA: 0x793EC0 Offset: 0x7924C0 VA: 0x180793EC0
	|-ResourceManager.CreateCompletedOperationInternal<SceneInstance>
	|
	|-RVA: 0x793920 Offset: 0x791F20 VA: 0x180793920
	|-ResourceManager.CreateCompletedOperationInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x212A8C0 Offset: 0x2128EC0 VA: 0x18212A8C0
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x21273C0 Offset: 0x21259C0 VA: 0x1821273C0
	public void Acquire(AsyncOperationHandle handle) { }

	// RVA: 0x21272B0 Offset: 0x21258B0 VA: 0x1821272B0
	private GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x795470 Offset: 0x793A70 VA: 0x180795470
	|-ResourceManager.CreateGroupOperation<object>
	|
	|-RVA: 0x794B20 Offset: 0x793120 VA: 0x180794B20
	|-ResourceManager.CreateGroupOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7959B0 Offset: 0x793FB0 VA: 0x1807959B0
	|-ResourceManager.CreateGroupOperation<object>
	|
	|-RVA: 0x794FB0 Offset: 0x7935B0 VA: 0x180794FB0
	|-ResourceManager.CreateGroupOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2127E00 Offset: 0x2126400 VA: 0x182127E00
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = False) { }

	// RVA: 0x2129030 Offset: 0x2127630 VA: 0x182129030
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = True) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x796670 Offset: 0x794C70 VA: 0x180796670
	|-ResourceManager.ProvideResources<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x796A10 Offset: 0x795010 VA: 0x180796A10
	|-ResourceManager.ProvideResources<object>
	|
	|-RVA: 0x796700 Offset: 0x794D00 VA: 0x180796700
	|-ResourceManager.ProvideResources<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x792CC0 Offset: 0x7912C0 VA: 0x180792CC0
	|-ResourceManager.CreateChainOperation<long, object>
	|
	|-RVA: 0x792FE0 Offset: 0x7915E0 VA: 0x180792FE0
	|-ResourceManager.CreateChainOperation<object, object>
	|
	|-RVA: 0x793450 Offset: 0x791A50 VA: 0x180793450
	|-ResourceManager.CreateChainOperation<SceneInstance, SceneInstance>
	|
	|-RVA: 0x792700 Offset: 0x790D00 VA: 0x180792700
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7925B0 Offset: 0x790BB0 VA: 0x1807925B0
	|-ResourceManager.CreateChainOperation<bool>
	|
	|-RVA: 0x792E90 Offset: 0x791490 VA: 0x180792E90
	|-ResourceManager.CreateChainOperation<long>
	|
	|-RVA: 0x7931B0 Offset: 0x7917B0 VA: 0x1807931B0
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0x793620 Offset: 0x791C20 VA: 0x180793620
	|-ResourceManager.CreateChainOperation<SceneInstance>
	|
	|-RVA: 0x792BB0 Offset: 0x7911B0 VA: 0x180792BB0
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7928C0 Offset: 0x790EC0 VA: 0x1807928C0
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x793300 Offset: 0x791900 VA: 0x180793300
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0x792A90 Offset: 0x791090 VA: 0x180792A90
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x212A200 Offset: 0x2128800 VA: 0x18212A200
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	// RVA: 0x212A100 Offset: 0x2128700 VA: 0x18212A100
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x212A760 Offset: 0x2128D60 VA: 0x18212A760
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x2128D20 Offset: 0x2127320 VA: 0x182128D20
	public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters) { }

	// RVA: 0x21277D0 Offset: 0x2125DD0 VA: 0x1821277D0
	public void CleanupSceneInstances(Scene scene) { }

	// RVA: 0x21281D0 Offset: 0x21267D0 VA: 0x1821281D0
	private void ExecuteDeferredCallbacks() { }

	// RVA: 0x212A530 Offset: 0x2128B30 VA: 0x18212A530
	internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = True) { }

	// RVA: 0x212ADF0 Offset: 0x21293F0 VA: 0x18212ADF0
	internal void Update(float unscaledDeltaTime) { }

	// RVA: 0x2128060 Offset: 0x2126660 VA: 0x182128060 Slot: 4
	public void Dispose() { }

	// RVA: 0x212B220 Offset: 0x2129820 VA: 0x18212B220
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x212ACD0 Offset: 0x21292D0 VA: 0x18212ACD0
	private void <.ctor>b__54_0(IUpdateReceiver x) { }
}

// Namespace: UnityEngine.ResourceManagement
public interface IUpdateReceiver // TypeDefIndex: 12638
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update(float unscaledDeltaTime);
}

// Namespace: UnityEngine.ResourceManagement
public class WebRequestQueueOperation // TypeDefIndex: 12639
{
	// Fields
	private bool m_Completed; // 0x10
	public UnityWebRequestAsyncOperation Result; // 0x18
	public Action<UnityWebRequestAsyncOperation> OnComplete; // 0x20
	internal UnityWebRequest m_WebRequest; // 0x28

	// Properties
	public bool IsDone { get; }
	public UnityWebRequest WebRequest { get; set; }

	// Methods

	// RVA: 0x212F010 Offset: 0x212D610 VA: 0x18212F010
	public bool get_IsDone() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public UnityWebRequest get_WebRequest() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_WebRequest(UnityWebRequest value) { }

	// RVA: 0x11161C0 Offset: 0x11147C0 VA: 0x1811161C0
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x212EFD0 Offset: 0x212D5D0 VA: 0x18212EFD0
	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }
}

// Namespace: UnityEngine.ResourceManagement
public static class WebRequestQueue // TypeDefIndex: 12640
{
	// Fields
	internal static int s_MaxRequest; // 0x0
	internal static Queue<WebRequestQueueOperation> s_QueuedOperations; // 0x8
	internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests; // 0x10

	// Methods

	// RVA: 0x212F5B0 Offset: 0x212DBB0 VA: 0x18212F5B0
	public static void SetMaxConcurrentRequests(int maxRequests) { }

	// RVA: 0x212F480 Offset: 0x212DA80 VA: 0x18212F480
	public static WebRequestQueueOperation QueueRequest(UnityWebRequest request) { }

	// RVA: 0x212F670 Offset: 0x212DC70 VA: 0x18212F670
	public static void WaitForRequestToBeActive(WebRequestQueueOperation request, int millisecondsTimeout) { }

	// RVA: 0x212F220 Offset: 0x212D820 VA: 0x18212F220
	internal static void DequeueRequest(UnityWebRequestAsyncOperation operation) { }

	// RVA: 0x212F2D0 Offset: 0x212D8D0 VA: 0x18212F2D0
	private static void OnWebAsyncOpComplete(AsyncOperation operation) { }

	// RVA: 0x212F370 Offset: 0x212D970 VA: 0x18212F370
	private static void OnWebAsyncOpComplete(UnityWebRequestAsyncOperation operation) { }

	// RVA: 0x212F030 Offset: 0x212D630 VA: 0x18212F030
	private static void BeginWebRequest(WebRequestQueueOperation queueOperation) { }

	// RVA: 0x212FA70 Offset: 0x212E070 VA: 0x18212FA70
	private static void .cctor() { }
}

