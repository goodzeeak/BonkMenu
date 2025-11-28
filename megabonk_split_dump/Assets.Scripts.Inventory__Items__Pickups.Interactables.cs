// Namespace: Assets.Scripts.Inventory__Items__Pickups.Interactables
public class ChestUtility // TypeDefIndex: 5611
{
	// Methods

	// RVA: 0x42B0E0 Offset: 0x4296E0 VA: 0x18042B0E0
	public static EEncounter ChestTypeToEncounter(EChest chestType) { }

	// RVA: 0x42B1B0 Offset: 0x4297B0 VA: 0x18042B1B0
	public static EChest EncounterToChestType(EEncounter encounter) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Interactables
public enum EChest // TypeDefIndex: 5612
{
	// Fields
	public int value__; // 0x0
	public const EChest Normal = 0;
	public const EChest Corrupt = 1;
	public const EChest Free = 2;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Interactables
public class OpenChest : MonoBehaviour // TypeDefIndex: 5613
{
	// Fields
	public EChest chestType; // 0x20
	private float delay; // 0x24
	private float readyForPickupTime; // 0x28
	private bool pickedup; // 0x2C

	// Methods

	// RVA: 0x444F50 Offset: 0x443550 VA: 0x180444F50
	private void Awake() { }

	// RVA: 0x445020 Offset: 0x443620 VA: 0x180445020
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x444FB0 Offset: 0x4435B0 VA: 0x180444FB0
	private bool CanPickup() { }

	// RVA: 0x445160 Offset: 0x443760 VA: 0x180445160
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Interactables
public class DetectInteractables : MonoBehaviour // TypeDefIndex: 5614
{
	// Fields
	private float interactableRange; // 0x20
	public LayerMask whatIsInteractable; // 0x24
	private BaseInteractable currentInteractable; // 0x28
	public TextMeshProUGUI t_interact; // 0x30
	public Transform uiParent; // 0x38
	public MyGlyphDisplay glyphContainer; // 0x40
	public static Action<BaseInteractable, bool> A_Interacted; // 0x0
	private float animationTime; // 0x48
	private float animateOverTime; // 0x4C
	private Vector3 fromScale; // 0x50
	private Vector3 toScale; // 0x5C

	// Methods

	// RVA: 0x42B280 Offset: 0x429880 VA: 0x18042B280
	private void Awake() { }

	// RVA: 0x42B360 Offset: 0x429960 VA: 0x18042B360
	private void FixedUpdate() { }

	// RVA: 0x42BDA0 Offset: 0x42A3A0 VA: 0x18042BDA0
	public void TryInteract() { }

	// RVA: 0x42B2C0 Offset: 0x4298C0 VA: 0x18042B2C0
	private bool CanInteract() { }

	// RVA: 0x42BF40 Offset: 0x42A540 VA: 0x18042BF40
	private void Update() { }

	// RVA: 0x42BAA0 Offset: 0x42A0A0 VA: 0x18042BAA0
	private void StartHovering(GameObject newObject) { }

	// RVA: 0x42B9A0 Offset: 0x429FA0 VA: 0x18042B9A0
	public void RefreshCurrentInteractable() { }

	// RVA: 0x42BC40 Offset: 0x42A240 VA: 0x18042BC40
	private void StopHovering() { }

	// RVA: 0x42B990 Offset: 0x429F90 VA: 0x18042B990
	public void InteractableDestroyed() { }

	// RVA: 0x42BA10 Offset: 0x42A010 VA: 0x18042BA10
	private void RefreshGlyphContainer() { }

	// RVA: 0x42C270 Offset: 0x42A870 VA: 0x18042C270
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Interactables
public class InteractablePot : BaseInteractable // TypeDefIndex: 5615
{
	// Fields
	public GameObject goldPrefab; // 0x58
	public GameObject xpPrefab; // 0x60
	public GameObject hpPrefab; // 0x68
	public GameObject silverPrefab; // 0x70
	public GameObject potBreakFx; // 0x78
	private bool broken; // 0x80
	public bool isBig; // 0x81
	public bool isSilver; // 0x82

	// Methods

	// RVA: 0x42D2B0 Offset: 0x42B8B0 VA: 0x18042D2B0 Slot: 4
	public override bool Interact() { }

	// RVA: 0x42D1B0 Offset: 0x42B7B0 VA: 0x18042D1B0
	private int GetXp() { }

	// RVA: 0x42DDA0 Offset: 0x42C3A0 VA: 0x18042DDA0
	private void SpawnStuff(EPickup ePickup, int value, float pickupDelay, int amount) { }

	// RVA: 0x42D160 Offset: 0x42B760 VA: 0x18042D160 Slot: 5
	public override string GetInteractString() { }

	// RVA: 0x42E0C0 Offset: 0x42C6C0 VA: 0x18042E0C0
	public void .ctor() { }
}

