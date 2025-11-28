// Namespace: Assets.Scripts.Player.Movement
public struct InputState // TypeDefIndex: 5708
{
	// Fields
	public float moveHorizontal; // 0x0
	public float moveVertical; // 0x4
	public float rotationHorizontal; // 0x8
	public float rotationVertical; // 0xC
	public bool jumping; // 0x10
	public bool crouching; // 0x11
	public bool holdingJump; // 0x12

	// Methods

	// RVA: 0x46E290 Offset: 0x46C890 VA: 0x18046E290
	public void .ctor(float mH, float mV, float rH, float rV, bool ju, bool cr, bool holdingJump) { }
}

// Namespace: Assets.Scripts.Player.Movement
public class PlayerMovementValues // TypeDefIndex: 5709
{
	// Fields
	private const float defaultMoveSpeed = 2700;
	private const float defaultSwimSpeed = 10;
	public const float defaultMaxSpeed = 10;
	private const float defaultSlideForce = 200;
	private const float defaultAirDeceleration = 0.003;
	private const float defaultExtraGravity = 11;
	[CompilerGenerated]
	private float <moveSpeed>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <maxRunSpeed>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <airDeceleration>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <slideForce>k__BackingField; // 0x1C
	[CompilerGenerated]
	private float <extraGravity>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <swimSpeed>k__BackingField; // 0x24
	private bool inited; // 0x28
	private ECharacter currentCharacter; // 0x2C
	private float counterMovement; // 0x30

	// Properties
	public float moveSpeed { get; set; }
	public float maxRunSpeed { get; set; }
	public float airDeceleration { get; set; }
	public float slideForce { get; set; }
	public float extraGravity { get; set; }
	public float swimSpeed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_moveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	private void set_moveSpeed(float value) { }

	[CompilerGenerated]
	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_maxRunSpeed() { }

	[CompilerGenerated]
	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	private void set_maxRunSpeed(float value) { }

	[CompilerGenerated]
	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70
	public float get_airDeceleration() { }

	[CompilerGenerated]
	// RVA: 0x3A4C30 Offset: 0x3A3230 VA: 0x1803A4C30
	private void set_airDeceleration(float value) { }

	[CompilerGenerated]
	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0
	public float get_slideForce() { }

	[CompilerGenerated]
	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450
	private void set_slideForce(float value) { }

	[CompilerGenerated]
	// RVA: 0x3CB400 Offset: 0x3C9A00 VA: 0x1803CB400
	public float get_extraGravity() { }

	[CompilerGenerated]
	// RVA: 0x3CB460 Offset: 0x3C9A60 VA: 0x1803CB460
	private void set_extraGravity(float value) { }

	[CompilerGenerated]
	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490
	public float get_swimSpeed() { }

	[CompilerGenerated]
	// RVA: 0x3CB500 Offset: 0x3C9B00 VA: 0x1803CB500
	private void set_swimSpeed(float value) { }

	// RVA: 0x472230 Offset: 0x470830 VA: 0x180472230
	private void Init(Rigidbody rb) { }

	// RVA: 0x471F30 Offset: 0x470530 VA: 0x180471F30
	public void CreateMovement(Rigidbody rb, ECharacter character) { }

	// RVA: 0x4720A0 Offset: 0x4706A0 VA: 0x1804720A0
	private static float GetCounterMovementMultiplier(ECharacter character) { }

	// RVA: 0x472170 Offset: 0x470770 VA: 0x180472170
	private static float GetMoveSpeedMultiplier(ECharacter character) { }

	// RVA: 0x472080 Offset: 0x470680 VA: 0x180472080
	public float GetCounterMovementMultiplier(FrictionModifier.EFrictionSurface surface) { }

	// RVA: 0x4721F0 Offset: 0x4707F0 VA: 0x1804721F0
	public static float GetSlowdownMultiplier(FrictionModifier.EFrictionSurface surface, ECharacter character) { }

	// RVA: 0x472180 Offset: 0x470780 VA: 0x180472180
	public float GetMoveSpeed(FrictionModifier.EFrictionSurface surface, bool grounded) { }

	// RVA: 0x4720D0 Offset: 0x4706D0 VA: 0x1804720D0
	public float GetGravity(Rigidbody rb, ECharacter character) { }

	// RVA: 0x472140 Offset: 0x470740 VA: 0x180472140
	public float GetMaxSpeed() { }

	// RVA: 0x472280 Offset: 0x470880 VA: 0x180472280
	public void .ctor() { }
}

