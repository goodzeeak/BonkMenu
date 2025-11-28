// Namespace: Assets.Scripts.Movement
[Flags]
public enum EMovementState // TypeDefIndex: 5710
{
	// Fields
	public int value__; // 0x0
	public const EMovementState Idle = 1;
	public const EMovementState Walking = 2;
	public const EMovementState Crouching = 4;
	public const EMovementState Sliding = 8;
	public const EMovementState Airborne = 16;
	public const EMovementState Wallrunning = 32;
	public const EMovementState CategoryCrouched = 12;
	public const EMovementState CategoryFootstepNoise = 34;
}

