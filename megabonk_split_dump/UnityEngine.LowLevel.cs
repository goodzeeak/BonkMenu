// Namespace: UnityEngine.LowLevel
[RequiredByNativeCode]
[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
[MovedFrom("UnityEngine.Experimental.LowLevel")]
internal struct PlayerLoopSystemInternal // TypeDefIndex: 9892
{
	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x8
	public IntPtr updateFunction; // 0x10
	public IntPtr loopConditionFunction; // 0x18
	public int numSubSystems; // 0x20
}

// Namespace: UnityEngine.LowLevel
[MovedFrom("UnityEngine.Experimental.LowLevel")]
public struct PlayerLoopSystem // TypeDefIndex: 9894
{
	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem[] subSystemList; // 0x8
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x10
	public IntPtr updateFunction; // 0x18
	public IntPtr loopConditionFunction; // 0x20

	// Methods

	// RVA: 0x235CAC0 Offset: 0x235B0C0 VA: 0x18235CAC0 Slot: 3
	public override string ToString() { }
}

