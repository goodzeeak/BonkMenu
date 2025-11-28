// Namespace: UnityEngine.Playables
public struct FrameData // TypeDefIndex: 10126
{
	// Fields
	internal ulong m_FrameID; // 0x0
	internal double m_DeltaTime; // 0x8
	internal float m_Weight; // 0x10
	internal float m_EffectiveWeight; // 0x14
	internal double m_EffectiveParentDelay; // 0x18
	internal float m_EffectiveParentSpeed; // 0x20
	internal float m_EffectiveSpeed; // 0x24
	internal FrameData.Flags m_Flags; // 0x28
	internal PlayableOutput m_Output; // 0x30
}

// Namespace: UnityEngine.Playables
public interface INotification // TypeDefIndex: 10127
{}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public interface INotificationReceiver // TypeDefIndex: 10128
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNotify(Playable origin, INotification notification, object context);
}

// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour // TypeDefIndex: 10129
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct Playable : IEquatable<Playable> // TypeDefIndex: 10130
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x235A9A0 Offset: 0x2358FA0 VA: 0x18235A9A0
	public static Playable get_Null() { }

	[VisibleToOtherModules]
	// RVA: 0x3A43C0 Offset: 0x3A29C0 VA: 0x1803A43C0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x235A820 Offset: 0x2358E20 VA: 0x18235A820 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x235A900 Offset: 0x2358F00 VA: 0x18235A900
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[AssetFileNameExtension("playable", new[] {  })]
[RequiredByNativeCode]
[Serializable]
public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 10131
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x2359ED0 Offset: 0x23584D0 VA: 0x182359ED0 Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x2359F20 Offset: 0x2358520 VA: 0x182359F20 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCode]
	// RVA: 0x2359D60 Offset: 0x2358360 VA: 0x182359D60
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x2359E90 Offset: 0x2358490 VA: 0x182359E90
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
[Serializable]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 10132
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x2359F70 Offset: 0x2358570 VA: 0x182359F70 Slot: 21
	public virtual object Clone() { }
}

// Namespace: UnityEngine.Playables
public struct PlayableBinding // TypeDefIndex: 10134
{
	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Methods

	// RVA: 0x2359F80 Offset: 0x2358580 VA: 0x182359F80
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
public struct PlayableGraph // TypeDefIndex: 10135
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 10136
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	[VisibleToOtherModules]
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x749610 Offset: 0x747C10 VA: 0x180749610
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	|-PlayableHandle.IsPlayableOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x235A280 Offset: 0x2358880 VA: 0x18235A280
	public static PlayableHandle get_Null() { }

	// RVA: 0x235A2E0 Offset: 0x23588E0 VA: 0x18235A2E0
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x235A010 Offset: 0x2358610 VA: 0x18235A010 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x235A100 Offset: 0x2358700 VA: 0x18235A100 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x235A190 Offset: 0x2358790 VA: 0x18235A190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x129ACA0 Offset: 0x12992A0 VA: 0x18129ACA0
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModules]
	// RVA: 0x235A200 Offset: 0x2358800 VA: 0x18235A200
	internal bool IsValid() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x235A1C0 Offset: 0x23587C0 VA: 0x18235A1C0
	internal Type GetPlayableType() { }

	// RVA: 0x235A240 Offset: 0x2358840 VA: 0x18235A240
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct PlayableOutput : IEquatable<PlayableOutput> // TypeDefIndex: 10137
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	[VisibleToOtherModules]
	// RVA: 0x3A43C0 Offset: 0x3A29C0 VA: 0x1803A43C0
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x235A6A0 Offset: 0x2358CA0 VA: 0x18235A6A0 Slot: 4
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x235A780 Offset: 0x2358D80 VA: 0x18235A780
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 10138
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x235A5B0 Offset: 0x2358BB0 VA: 0x18235A5B0
	public static PlayableOutputHandle get_Null() { }

	[VisibleToOtherModules]
	// RVA: -1 Offset: -1
	internal bool IsPlayableOutputOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7496B0 Offset: 0x747CB0 VA: 0x1807496B0
	|-PlayableOutputHandle.IsPlayableOutputOfType<DataPlayableOutput>
	|-PlayableOutputHandle.IsPlayableOutputOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x235A190 Offset: 0x2358790 VA: 0x18235A190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235A610 Offset: 0x2358C10 VA: 0x18235A610
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x235A370 Offset: 0x2358970 VA: 0x18235A370 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x235A460 Offset: 0x2358A60 VA: 0x18235A460 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x129ACA0 Offset: 0x12992A0 VA: 0x18129ACA0
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[VisibleToOtherModules]
	// RVA: 0x235A530 Offset: 0x2358B30 VA: 0x18235A530
	internal bool IsValid() { }

	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x235A4F0 Offset: 0x2358AF0 VA: 0x18235A4F0
	internal Type GetPlayableOutputType() { }

	// RVA: 0x235A570 Offset: 0x2358B70 VA: 0x18235A570
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct ScriptPlayableOutput // TypeDefIndex: 10139
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("DataPlayableOutputBindings", 2)]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutput.bindings.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutputExtensions.bindings.h")]
[NativeHeader("Modules/Director/DataPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
internal struct DataPlayableOutput // TypeDefIndex: 14215
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x236BB00 Offset: 0x236A100 VA: 0x18236BB00
	internal void .ctor(PlayableOutputHandle handle) { }

	[RequiredByNativeCode]
	// RVA: 0x236B8C0 Offset: 0x2369EC0 VA: 0x18236B8C0
	private static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, object previousPlayer, object currentPlayer) { }
}

// Namespace: UnityEngine.Playables
internal interface IDataPlayer // TypeDefIndex: 14216
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Bind(DataPlayableOutput output);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Release(DataPlayableOutput output);
}

// Namespace: UnityEngine.Playables
[NativeHeader("Modules/Director/PlayableDirector.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class PlayableDirector : Behaviour // TypeDefIndex: 14217
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<PlayableDirector> played; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> paused; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> stopped; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x236BC00 Offset: 0x236A200 VA: 0x18236BC00
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	// RVA: 0x236BBE0 Offset: 0x236A1E0 VA: 0x18236BBE0
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	// RVA: 0x236BC20 Offset: 0x236A220 VA: 0x18236BC20
	private void SendOnPlayableDirectorStop() { }
}

// Namespace: UnityEngine.Playables
[StaticAccessor("PlayableSystemsBindings", 2)]
[NativeHeader("Modules/Director/ScriptBindings/PlayableSystems.bindings.h")]
internal static class PlayableSystems // TypeDefIndex: 14222
{
	// Fields
	private static Dictionary<int, Type> s_SystemTypes; // 0x0
	private static Dictionary<int, PlayableSystems.PlayableSystemDelegate> s_Delegates; // 0x8
	private static ReaderWriterLockSlim s_RWLock; // 0x10

	// Methods

	// RVA: 0x236BC40 Offset: 0x236A240 VA: 0x18236BC40
	private static int CombineTypeAndIndex(int typeIndex, PlayableSystems.PlayableSystemStage stage) { }

	[RequiredByNativeCode]
	// RVA: 0x236BC50 Offset: 0x236A250 VA: 0x18236BC50
	private static bool Internal_CallSystemDelegate(int systemIndex, PlayableSystems.PlayableSystemStage stage, IntPtr outputsPtr, int numOutputs) { }

	// RVA: 0x236BE40 Offset: 0x236A440 VA: 0x18236BE40
	private static void .cctor() { }
}

