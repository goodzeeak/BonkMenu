// Namespace: Assets.Scripts.Inventory__Items__Pickups.Chests
public class InteractableChest : BaseInteractable // TypeDefIndex: 5609
{
	// Fields
	public EChest chestType; // 0x58
	private float rotation; // 0x5C
	public Transform icon; // 0x60
	public static Action A_ChestBought; // 0x0
	private bool opening; // 0x68
	private bool isHoveringAndCantAfford; // 0x69

	// Methods

	// RVA: 0x42C290 Offset: 0x42A890 VA: 0x18042C290
	private void Awake() { }

	// RVA: 0x42CE70 Offset: 0x42B470 VA: 0x18042CE70
	private void OnDestroy() { }

	// RVA: 0x42CFA0 Offset: 0x42B5A0 VA: 0x18042CFA0
	private void Start() { }

	// RVA: 0x42C760 Offset: 0x42AD60 VA: 0x18042C760 Slot: 4
	public override bool Interact() { }

	// RVA: 0x42C950 Offset: 0x42AF50 VA: 0x18042C950
	private void OnChestWindowClose() { }

	// RVA: 0x42C5E0 Offset: 0x42ABE0 VA: 0x18042C5E0 Slot: 5
	public override string GetInteractString() { }

	// RVA: 0x42C490 Offset: 0x42AA90 VA: 0x18042C490
	private void FixedUpdate() { }

	// RVA: 0x42C530 Offset: 0x42AB30 VA: 0x18042C530 Slot: 6
	public override Color GetColor() { }

	// RVA: 0x42C700 Offset: 0x42AD00 VA: 0x18042C700
	private int GetPrice() { }

	// RVA: 0x42C3C0 Offset: 0x42A9C0 VA: 0x18042C3C0
	private bool CanAfford() { }

	// RVA: 0x42D150 Offset: 0x42B750 VA: 0x18042D150
	public void .ctor() { }
}

