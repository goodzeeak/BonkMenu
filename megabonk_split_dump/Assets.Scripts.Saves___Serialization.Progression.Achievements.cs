// Namespace: Assets.Scripts.Saves___Serialization.Progression.Achievements
public static class AchievementTracker // TypeDefIndex: 5428
{
	// Fields
	private static float baseMovementSpeed; // 0x0
	private static float noDamageTimer; // 0x4
	private static bool hasTakenDamageThisRun; // 0x8
	private static bool hasDealtDamageThisRun; // 0x9
	private static int consecutiveIceCrystalCooks; // 0xC
	private static int consecutiveMoldyCheeseCooks; // 0x10
	private static int runChestsBought; // 0x14
	private static bool hasSpawnedLuckTomeQuest; // 0x18
	private static string aegisDamageSource; // 0x20
	private static int chargedShrines; // 0x28
	private static int chargedShrinesNoInterruptions; // 0x2C
	private static int totalChargeShrines; // 0x30
	private static int numBoomboxes; // 0x34

	// Methods

	// RVA: 0x3D23A0 Offset: 0x3D09A0 VA: 0x1803D23A0
	public static void Init() { }

	// RVA: 0x3D0CD0 Offset: 0x3CF2D0 VA: 0x1803D0CD0
	public static void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void OnFinalSwarmStart() { }

	// RVA: 0x3D5350 Offset: 0x3D3950 VA: 0x1803D5350
	private static void OnRunStarted() { }

	// RVA: 0x3D61E0 Offset: 0x3D47E0 VA: 0x1803D61E0
	private static void OnStageStarted() { }

	// RVA: 0x3D4F50 Offset: 0x3D3550 VA: 0x1803D4F50
	private static void OnPLayerInventoryInited(PlayerInventory inv) { }

	// RVA: 0x3D6380 Offset: 0x3D4980 VA: 0x1803D6380
	private static void OnStatUpdate(EStat stat) { }

	// RVA: 0x3D6560 Offset: 0x3D4B60 VA: 0x1803D6560
	private static void OnTick() { }

	// RVA: 0x3D3C70 Offset: 0x3D2270 VA: 0x1803D3C70
	private static void OnEnemyDied(Enemy enemy, DamageContainer deathSource) { }

	// RVA: 0x3D55F0 Offset: 0x3D3BF0 VA: 0x1803D55F0
	private static void OnStageBossDefeated(bool isOpeningPortal) { }

	// RVA: 0x3D3BB0 Offset: 0x3D21B0 VA: 0x1803D3BB0
	private static void OnDamageTaken(PlayerHealth ph, DamageContainer dc, bool brokeShield) { }

	// RVA: 0x3D3C20 Offset: 0x3D2220 VA: 0x1803D3C20
	private static void OnEnemyDamaged(Enemy arg1, DamageContainer arg2) { }

	// RVA: 0x3D49D0 Offset: 0x3D2FD0 VA: 0x1803D49D0
	private static void OnLevelUp(int level) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void OnChestBought() { }

	// RVA: 0x3D5410 Offset: 0x3D3A10 VA: 0x1803D5410
	private static void OnShrineCharged(bool noChargeInterruption) { }

	// RVA: 0x3D3B50 Offset: 0x3D2150 VA: 0x1803D3B50
	private static void OnChargeShrineSpawned() { }

	// RVA: 0x3D4D10 Offset: 0x3D3310 VA: 0x1803D4D10
	private static void OnMicrowaveUsed(EItem eItem) { }

	// RVA: 0x3D7A10 Offset: 0x3D6010 VA: 0x1803D7A10
	private static void OnWeaponAddedOrUpgraded(WeaponBase weapon) { }

	// RVA: 0x3D69C0 Offset: 0x3D4FC0 VA: 0x1803D69C0
	private static void OnTomeAddedOrUpgraded(ETome eTome, EStat stat) { }

	// RVA: 0x3D48B0 Offset: 0x3D2EB0 VA: 0x1803D48B0
	private static void OnItemAdded(EItem item) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void OnPickupTriggered(Pickup pickup) { }

	// RVA: 0x3D4FF0 Offset: 0x3D35F0 VA: 0x1803D4FF0
	private static void OnPotBroken() { }

	// RVA: 0x3D4290 Offset: 0x3D2890 VA: 0x1803D4290
	private static void OnInteracted(BaseInteractable interactable, bool success) { }

	// RVA: 0x3D77F0 Offset: 0x3D5DF0 VA: 0x1803D77F0
	private static void OnUnlock(MyAchievement achUnlocked) { }

	// RVA: 0x3D5130 Offset: 0x3D3730 VA: 0x1803D5130
	private static void OnPurchased(UnlockableBase unlockable) { }

	// RVA: 0x3D7B80 Offset: 0x3D6180 VA: 0x1803D7B80
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Achievements
[CreateAssetMenu(menuName = "Me/Progression/Unlock", order = 1)]
public class MyAchievement : ScriptableObject, IComparable<MyAchievement> // TypeDefIndex: 5429
{
	// Fields
	public LocalizedString localizedName; // 0x18
	public LocalizedString localizedDescription; // 0x20
	public bool isEnabled; // 0x28
	public bool isHidden; // 0x29
	[HideInInspector]
	public string internalName; // 0x30
	public string statName; // 0x38
	public int targetValue; // 0x40
	public float targetValueFloat; // 0x44
	public string targetValueString; // 0x48
	public Texture icon; // 0x50
	public int sortingOrder; // 0x58
	public EAchievementDifficulty difficulty; // 0x5C
	public EAchievementType achievementType; // 0x60
	public List<LocalizationKey> serializedLocalizationKeys; // 0x68
	public int achIteration; // 0x70
	public bool useIterations; // 0x74
	[CompilerGenerated]
	private UnlockableBase <unlockable>k__BackingField; // 0x78

	// Properties
	public UnlockableBase unlockable { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public UnlockableBase get_unlockable() { }

	[CompilerGenerated]
	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	private void set_unlockable(UnlockableBase value) { }

	// RVA: 0x3E0C90 Offset: 0x3DF290 VA: 0x1803E0C90
	public string GetUnlockDescription() { }

	// RVA: 0x3E06D0 Offset: 0x3DECD0 VA: 0x1803E06D0 Slot: 5
	public virtual string GetDisplayName() { }

	// RVA: 0x3E0850 Offset: 0x3DEE50 VA: 0x1803E0850
	private Dictionary<string, string> GetKeys() { }

	// RVA: 0x3E07C0 Offset: 0x3DEDC0 VA: 0x1803E07C0
	public Texture GetIcon() { }

	// RVA: 0x3E10D0 Offset: 0x3DF6D0 VA: 0x1803E10D0
	public bool IsUsingTargetValue() { }

	// RVA: 0x3E1060 Offset: 0x3DF660 VA: 0x1803E1060
	public bool IsTrackingStat() { }

	// RVA: 0x3E0C90 Offset: 0x3DF290 VA: 0x1803E0C90 Slot: 6
	public virtual string GetUnlockRequirement() { }

	// RVA: 0x3E0DF0 Offset: 0x3DF3F0 VA: 0x1803E0DF0
	public string GetUnlockedString() { }

	// RVA: 0x3E0B90 Offset: 0x3DF190 VA: 0x1803E0B90
	public string GetRewardString() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void SetUnlockable(UnlockableBase unlockable) { }

	// RVA: 0x3E0FB0 Offset: 0x3DF5B0 VA: 0x1803E0FB0
	public bool IsCompleted() { }

	// RVA: 0x3E0EF0 Offset: 0x3DF4F0 VA: 0x1803E0EF0
	public bool IsClaimed() { }

	// RVA: 0x3E0AA0 Offset: 0x3DF0A0 VA: 0x1803E0AA0
	public float GetProgress() { }

	// RVA: 0x3E0620 Offset: 0x3DEC20 VA: 0x1803E0620
	public int GetCurrentValue() { }

	// RVA: 0x3E1000 Offset: 0x3DF600 VA: 0x1803E1000
	public bool IsHiddenInMenus() { }

	// RVA: 0x3E13C0 Offset: 0x3DF9C0 VA: 0x1803E13C0
	private void OnValidate() { }

	// RVA: 0x3E1110 Offset: 0x3DF710 VA: 0x1803E1110
	public bool IsVisible() { }

	// RVA: 0x3E1080 Offset: 0x3DF680 VA: 0x1803E1080
	public bool IsUnlocked() { }

	// RVA: 0x3E0C60 Offset: 0x3DF260 VA: 0x1803E0C60
	public int GetSilverReward() { }

	// RVA: 0x3E0470 Offset: 0x3DEA70 VA: 0x1803E0470 Slot: 7
	public virtual int CompareTo(MyAchievement other) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Achievements
public abstract class UnlockableBase : ScriptableObject, IComparable<UnlockableBase> // TypeDefIndex: 5430
{
	// Fields
	public bool isEnabled; // 0x18
	public bool showInUnlocks; // 0x19
	public bool canAlwaysToggle; // 0x1A
	public string author; // 0x20
	public int price; // 0x28
	public LocalizedString localizedName; // 0x30
	public LocalizedString localizedDescription; // 0x38
	public List<LocalizationKey> serializedLocalizationKeys; // 0x40
	public List<LocalizationKey> serializedLocalizationKeysName; // 0x48

	// Methods

	// RVA: 0x3F2360 Offset: 0x3F0960 VA: 0x1803F2360 Slot: 5
	public virtual string GetName() { }

	// RVA: 0x3F1EC0 Offset: 0x3F04C0 VA: 0x1803F1EC0 Slot: 6
	public virtual string GetDescription() { }

	// RVA: 0x3F2020 Offset: 0x3F0620 VA: 0x1803F2020
	private Dictionary<string, string> GetKeysDesc() { }

	// RVA: 0x3F21C0 Offset: 0x3F07C0 VA: 0x1803F21C0
	private Dictionary<string, string> GetKeysName() { }

	// RVA: 0x3F24C0 Offset: 0x3F0AC0 VA: 0x1803F24C0 Slot: 7
	public virtual int GetPrice() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Texture GetIcon();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract MyAchievement GetUnlockRequirement();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract UnlockableBase GetUnlockableRequirement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string GetUnlockableTypeDisplayString();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string GetInternalName();

	// RVA: 0x3F1DA0 Offset: 0x3F03A0 VA: 0x1803F1DA0
	public bool CanBuy() { }

	// RVA: 0x3F1E60 Offset: 0x3F0460 VA: 0x1803F1E60 Slot: 13
	public virtual int CompareTo(UnlockableBase other) { }

	// RVA: 0x3F24E0 Offset: 0x3F0AE0 VA: 0x1803F24E0
	protected void .ctor() { }
}

