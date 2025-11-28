// Namespace: Assets.Scripts.UI.InGame.Levelup
public class EncounterWindows : MonoBehaviour // TypeDefIndex: 5361
{
	// Fields
	public BaseEncounterWindow levelupScreen; // 0x20
	public BaseEncounterWindow genericEncounterWindow; // 0x28
	public BaseEncounterWindow chestWindow; // 0x30
	public BaseEncounterWindow itemPickWindow; // 0x38
	public BaseEncounterWindow microwaveWindow; // 0x40
	private BaseEncounterWindow activeEncounterWindow; // 0x48
	private Queue<EEncounter> rewardQueue; // 0x50
	[CompilerGenerated]
	private bool <encounterInProgress>k__BackingField; // 0x58
	private bool closedEncounterThisFrame; // 0x59
	private static List<EEncounter> nextMapQueue; // 0x0
	public static Action A_WindowOpened; // 0x8
	public static Action A_WindowClosed; // 0x10
	public int currentLevel; // 0x5C

	// Properties
	public bool encounterInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_encounterInProgress() { }

	[CompilerGenerated]
	// RVA: 0x3B9A60 Offset: 0x3B8060 VA: 0x1803B9A60
	private void set_encounterInProgress(bool value) { }

	// RVA: 0x3B8840 Offset: 0x3B6E40 VA: 0x1803B8840
	private void Awake() { }

	// RVA: 0x3B8CB0 Offset: 0x3B72B0 VA: 0x1803B8CB0
	private void OnDestroy() { }

	// RVA: 0x3B9100 Offset: 0x3B7700 VA: 0x1803B9100
	private void OnGameOver() { }

	// RVA: 0x3B92D0 Offset: 0x3B78D0 VA: 0x1803B92D0
	private void OnPortalClosed() { }

	// RVA: 0x3B9730 Offset: 0x3B7D30 VA: 0x1803B9730
	private bool QueueEncountersForNextMap() { }

	// RVA: 0x3B8C90 Offset: 0x3B7290 VA: 0x1803B8C90
	public bool HasEncounter() { }

	// RVA: 0x3B86D0 Offset: 0x3B6CD0 VA: 0x1803B86D0
	public void AddEncounter(EEncounter rewardWindowType) { }

	// RVA: 0x3B97A0 Offset: 0x3B7DA0 VA: 0x1803B97A0
	public void RewardFinished() { }

	// RVA: 0x3B94A0 Offset: 0x3B7AA0 VA: 0x1803B94A0
	private void PopReward() { }

	// RVA: 0x3B91A0 Offset: 0x3B77A0 VA: 0x1803B91A0
	private void OnInventoryInitialized(PlayerInventory inventory) { }

	// RVA: 0x3B8CA0 Offset: 0x3B72A0 VA: 0x1803B8CA0
	private void LateUpdate() { }

	// RVA: 0x3B98A0 Offset: 0x3B7EA0 VA: 0x1803B98A0
	private void Start() { }

	// RVA: 0x3B91D0 Offset: 0x3B77D0 VA: 0x1803B91D0
	private void OnLevelUp(int level) { }

	// RVA: 0x3B99E0 Offset: 0x3B7FE0 VA: 0x1803B99E0
	public void .ctor() { }

	// RVA: 0x3B9950 Offset: 0x3B7F50 VA: 0x1803B9950
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.UI.InGame.Levelup
public enum ERewardWindowType // TypeDefIndex: 5362
{
	// Fields
	public int value__; // 0x0
	public const ERewardWindowType Levelup = 0;
	public const ERewardWindowType ChargeShrine = 1;
}

