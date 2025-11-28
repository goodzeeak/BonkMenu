// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemProjectiles
public class ItemProjectileOrb : ItemProjectile // TypeDefIndex: 5528
{
	// Fields
	private float startTime; // 0xA8
	private float hoverTime; // 0xAC
	private float offsetTime; // 0xB0
	private float spinSpeed; // 0xB4
	private float currentAngle; // 0xB8
	private float moveTimer; // 0xBC
	private Vector3 offset; // 0xC0
	private Transform orbitTarget; // 0xD0
	private Vector3 defaultScale; // 0xD8
	private bool fired; // 0xE4
	public GameObject fireSfx; // 0xE8
	private Vector3 movementDirection; // 0xF0

	// Methods

	// RVA: 0x417E60 Offset: 0x416460 VA: 0x180417E60 Slot: 4
	protected override void Init() { }

	// RVA: 0x417AC0 Offset: 0x4160C0 VA: 0x180417AC0
	private void FireOrb() { }

	// RVA: 0x418540 Offset: 0x416B40 VA: 0x180418540 Slot: 5
	protected override void Step() { }

	// RVA: 0x352A50 Offset: 0x351050 VA: 0x180352A50 Slot: 6
	protected override Vector3 GetMovementDirection() { }

	// RVA: 0x4181C0 Offset: 0x4167C0 VA: 0x1804181C0
	protected void StepHoverMovement() { }

	// RVA: 0x418130 Offset: 0x416730 VA: 0x180418130 Slot: 10
	protected override void ProjectileDone() { }

	// RVA: 0x4185F0 Offset: 0x416BF0 VA: 0x1804185F0
	public void .ctor() { }
}

