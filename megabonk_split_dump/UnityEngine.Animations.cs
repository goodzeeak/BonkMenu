// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(256)]
public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 13926
{}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(260)]
public class NotKeyableAttribute : Attribute // TypeDefIndex: 13927
{}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[StaticAccessor("AnimationClipPlayableBindings", 2)]
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 13928
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E7280 Offset: 0x22E5880 VA: 0x1822E7280 Slot: 4
	public bool Equals(AnimationClipPlayable other) { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
public struct AnimationHumanStream // TypeDefIndex: 13929
{
	// Fields
	private IntPtr stream; // 0x0
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationLayerMixerPlayableBindings", 2)]
[RequiredByNativeCode]
public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 13930
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E7BF0 Offset: 0x22E61F0 VA: 0x1822E7BF0
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization = True) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E7A70 Offset: 0x22E6070 VA: 0x1822E7A70 Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	[NativeThrows]
	// RVA: 0x22E7B10 Offset: 0x22E6110 VA: 0x1822E7B10
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x22E7B60 Offset: 0x22E6160 VA: 0x1822E7B60
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMixerPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 13931
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E7F10 Offset: 0x22E6510 VA: 0x1822E7F10
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E7D30 Offset: 0x22E6330 VA: 0x1822E7D30 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x22E7DD0 Offset: 0x22E63D0 VA: 0x1822E7DD0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[RequiredByNativeCode]
internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 13932
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E81D0 Offset: 0x22E67D0 VA: 0x1822E81D0
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E7FF0 Offset: 0x22E65F0 VA: 0x1822E7FF0 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x22E8090 Offset: 0x22E6690 VA: 0x1822E8090
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationOffsetPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 13933
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E8490 Offset: 0x22E6A90 VA: 0x1822E8490
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E82B0 Offset: 0x22E68B0 VA: 0x1822E82B0 Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x22E8350 Offset: 0x22E6950 VA: 0x1822E8350
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[StaticAccessor("AnimationPlayableOutputBindings", 2)]
public struct AnimationPlayableOutput // TypeDefIndex: 13934
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationPosePlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 13935
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E8750 Offset: 0x22E6D50 VA: 0x1822E8750
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E8570 Offset: 0x22E6B70 VA: 0x1822E8570 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x22E8610 Offset: 0x22E6C10 VA: 0x1822E8610
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationRemoveScalePlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 13936
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E8A10 Offset: 0x22E7010 VA: 0x1822E8A10
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E8830 Offset: 0x22E6E30 VA: 0x1822E8830 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x22E88D0 Offset: 0x22E6ED0 VA: 0x1822E88D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationScriptPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 13937
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E8CD0 Offset: 0x22E72D0 VA: 0x1822E8CD0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E8AF0 Offset: 0x22E70F0 VA: 0x1822E8AF0 Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x22E8B90 Offset: 0x22E7190 VA: 0x1822E8B90
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[RequiredByNativeCode]
public struct AnimationStream // TypeDefIndex: 13938
{
	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[StaticAccessor("AnimatorControllerPlayableBindings", 2)]
[RequiredByNativeCode]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 13939
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x22E90A0 Offset: 0x22E76A0 VA: 0x1822E90A0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22E8E50 Offset: 0x22E7450 VA: 0x1822E8E50
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x22E8DB0 Offset: 0x22E73B0 VA: 0x1822E8DB0 Slot: 4
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x22E8FA0 Offset: 0x22E75A0 VA: 0x1822E8FA0
	private static void .cctor() { }
}

