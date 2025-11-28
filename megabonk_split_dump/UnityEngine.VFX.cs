// Namespace: UnityEngine.VFX
[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
[RequiredByNativeCode]
public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 14178
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VisualEffectAsset m_VfxAsset; // 0x20

	// Methods

	// RVA: 0x2687960 Offset: 0x2685F60 VA: 0x182687960
	private void .ctor(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	// RVA: 0x2687430 Offset: 0x2685A30 VA: 0x182687430
	internal static VFXEventAttribute CreateEventAttributeWrapper() { }

	// RVA: 0x26878F0 Offset: 0x2685EF0 VA: 0x1826878F0
	internal void SetWrapValue(IntPtr ptrToEventAttribute) { }

	// RVA: 0x26875F0 Offset: 0x2685BF0 VA: 0x1826875F0
	internal static IntPtr Internal_Create() { }

	// RVA: 0x2687760 Offset: 0x2685D60 VA: 0x182687760
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	// RVA: 0x26876B0 Offset: 0x2685CB0 VA: 0x1826876B0
	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	// RVA: 0x2687880 Offset: 0x2685E80 VA: 0x182687880
	private void Release() { }

	// RVA: 0x2687530 Offset: 0x2685B30 VA: 0x182687530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2687490 Offset: 0x2685A90 VA: 0x182687490 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2687620 Offset: 0x2685C20 VA: 0x182687620
	internal static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2687660 Offset: 0x2685C60 VA: 0x182687660
	private static void Internal_InitFromAsset_Injected(IntPtr _unity_self, IntPtr vfxAsset) { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
public class VFXExpressionValues // TypeDefIndex: 14179
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x26879C0 Offset: 0x2685FC0 VA: 0x1826879C0
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
public struct VFXCameraXRSettings // TypeDefIndex: 14180
{
	// Fields
	public uint viewTotal; // 0x0
	public uint viewCount; // 0x4
	public uint viewOffset; // 0x8
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
public struct VFXBatchedEffectInfo // TypeDefIndex: 14181
{
	// Fields
	public VisualEffectAsset vfxAsset; // 0x0
	public uint activeBatchCount; // 0x8
	public uint inactiveBatchCount; // 0xC
	public uint activeInstanceCount; // 0x10
	public uint unbatchedInstanceCount; // 0x14
	public uint totalInstanceCapacity; // 0x18
	public uint maxInstancePerBatchCapacity; // 0x1C
	public ulong totalGPUSizeInBytes; // 0x20
	public ulong totalCPUSizeInBytes; // 0x28
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
internal struct VFXBatchInfo // TypeDefIndex: 14182
{
	// Fields
	public uint capacity; // 0x0
	public uint activeInstanceCount; // 0x4
}

// Namespace: UnityEngine.VFX
[StaticAccessor("GetVFXManager()", 0)]
[RequiredByNativeCode]
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
public static class VFXManager // TypeDefIndex: 14183
{
	// Fields
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; // 0x0

	// Methods

	// RVA: 0x2687A20 Offset: 0x2686020 VA: 0x182687A20
	private static void .cctor() { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 14184
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: UnityEngine.VFX
[RequiredByNativeCode]
[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 14185
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VFXEventAttribute m_WrapEventAttribute; // 0x20

	// Methods

	// RVA: 0x2688030 Offset: 0x2686630 VA: 0x182688030
	internal void .ctor(IntPtr ptr, bool owner) { }

	[RequiredByNativeCode]
	// RVA: 0x2687A80 Offset: 0x2686080 VA: 0x182687A80
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	// RVA: 0x2687D80 Offset: 0x2686380 VA: 0x182687D80
	private void PrepareWrapper() { }

	[RequiredByNativeCode]
	// RVA: 0x2687F10 Offset: 0x2686510 VA: 0x182687F10
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) { }

	// RVA: 0x2687EA0 Offset: 0x26864A0 VA: 0x182687EA0
	private void Release() { }

	// RVA: 0x2687C90 Offset: 0x2686290 VA: 0x182687C90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2687BF0 Offset: 0x26861F0 VA: 0x182687BF0 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2687D40 Offset: 0x2686340 VA: 0x182687D40
	private static void Internal_Destroy(IntPtr ptr) { }
}

// Namespace: UnityEngine.VFX
[UsedByNativeCode]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[NativeHeader("VFXScriptingClasses.h")]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectAssetBindings.h")]
public abstract class VisualEffectObject : Object // TypeDefIndex: 14186
{}

// Namespace: UnityEngine.VFX
[UsedByNativeCode]
[NativeHeader("VFXScriptingClasses.h")]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
public class VisualEffectAsset : VisualEffectObject // TypeDefIndex: 14187
{
	// Fields
	public static readonly int PlayEventID; // 0x0
	public static readonly int StopEventID; // 0x4

	// Methods

	// RVA: 0x2688070 Offset: 0x2686670 VA: 0x182688070
	private static void .cctor() { }
}

// Namespace: UnityEngine.VFX
public struct VFXOutputEventArgs // TypeDefIndex: 14188
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <nameId>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly VFXEventAttribute <eventAttribute>k__BackingField; // 0x8

	// Methods

	// RVA: 0xA4BD30 Offset: 0xA4A330 VA: 0x180A4BD30
	public void .ctor(int nameId, VFXEventAttribute eventAttribute) { }
}

// Namespace: UnityEngine.VFX
[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
[RequireComponent(typeof(Transform))]
public class VisualEffect : Behaviour // TypeDefIndex: 14189
{
	// Fields
	private VFXEventAttribute m_cachedEventAttribute; // 0x18
	public Action<VFXOutputEventArgs> outputEventReceived; // 0x20

	// Properties
	public VisualEffectAsset visualEffectAsset { get; }

	// Methods

	// RVA: 0x26884F0 Offset: 0x2686AF0 VA: 0x1826884F0
	public VisualEffectAsset get_visualEffectAsset() { }

	// RVA: 0x26880F0 Offset: 0x26866F0 VA: 0x1826880F0
	public VFXEventAttribute CreateVFXEventAttribute() { }

	[RequiredByNativeCode]
	// RVA: 0x2688280 Offset: 0x2686880 VA: 0x182688280
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[RequiredByNativeCode]
	// RVA: 0x2688450 Offset: 0x2686A50 VA: 0x182688450
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }

	// RVA: 0x26884B0 Offset: 0x2686AB0 VA: 0x1826884B0
	private static IntPtr get_visualEffectAsset_Injected(IntPtr _unity_self) { }
}

