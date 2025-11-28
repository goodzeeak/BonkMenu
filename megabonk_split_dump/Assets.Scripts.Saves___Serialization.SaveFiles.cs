// Namespace: Assets.Scripts.Saves___Serialization.SaveFiles
[Serializable]
public class ProgressionSaveFile // TypeDefIndex: 5405
{
	// Fields
	public int gold; // 0x10
	public int silver; // 0x14
	public Dictionary<EShopItem, int> shopItems; // 0x18
	public Dictionary<ECharacter, CharacterProgression> characterProgression; // 0x20
	public HashSet<string> achievements; // 0x28
	public HashSet<string> claimedAchievements; // 0x30
	public HashSet<string> purchases; // 0x38
	public HashSet<string> inactivated; // 0x40
	public bool hasNewQuestDone; // 0x48
	public MenuMeta menuMeta; // 0x50
	public HashSet<string> newUnlockables; // 0x58
	public HashSet<string> newShopItems; // 0x60
	public HashSet<string> newMaps; // 0x68
	public static Action<int> A_SilverChanged; // 0x0
	public static Action<MyAchievement> A_AchievementClaimed; // 0x8
	public static Action<UnlockableBase> A_UnlockablePurchased; // 0x10

	// Methods

	// RVA: 0x3E6610 Offset: 0x3E4C10 VA: 0x1803E6610
	public void Init() { }

	// RVA: 0x3E6B50 Offset: 0x3E5150 VA: 0x1803E6B50
	public void OnDestroy() { }

	// RVA: 0x3E61E0 Offset: 0x3E47E0 VA: 0x1803E61E0
	public void CompleteAchievement(MyAchievement achievement) { }

	// RVA: 0x3E6FB0 Offset: 0x3E55B0 VA: 0x1803E6FB0
	public bool PurchaseUnlockable(UnlockableBase unlockable) { }

	// RVA: 0x3E65C0 Offset: 0x3E4BC0 VA: 0x1803E65C0
	public bool HasUnclaimedQuests() { }

	// RVA: 0x3E6E90 Offset: 0x3E5490 VA: 0x1803E6E90
	public bool PurchaseShopItem(ShopItemData shopItemData) { }

	// RVA: 0x3E7190 Offset: 0x3E5790 VA: 0x1803E7190
	public bool RefundShopItem(ShopItemData shopItemData) { }

	// RVA: 0x3E6090 Offset: 0x3E4690 VA: 0x1803E6090
	public void AddSilver(int change) { }

	// RVA: 0x3E7250 Offset: 0x3E5850 VA: 0x1803E7250
	public void RemoveSilver(int change) { }

	// RVA: 0x3E6110 Offset: 0x3E4710 VA: 0x1803E6110
	public void ClaimAchievement(MyAchievement achievement) { }

	// RVA: 0x3E6560 Offset: 0x3E4B60 VA: 0x1803E6560
	public bool HasShopItem(EShopItem eShopItem) { }

	// RVA: 0x3E6500 Offset: 0x3E4B00 VA: 0x1803E6500
	public int GetShopItemLevel(EShopItem eShopItem) { }

	// RVA: 0x3E6C80 Offset: 0x3E5280 VA: 0x1803E6C80
	private void OnGameOver() { }

	// RVA: 0x3E6410 Offset: 0x3E4A10 VA: 0x1803E6410
	public CharacterProgression GetCharacterProgression(ECharacter character) { }

	// RVA: 0x3E72B0 Offset: 0x3E58B0 VA: 0x1803E72B0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.SaveFiles
[Serializable]
public class StatsSaveFile // TypeDefIndex: 5406
{
	// Fields
	public Dictionary<string, MyStat> stats; // 0x10
	public Dictionary<EEnemy, EnemyLog> enemyLogs; // 0x18

	// Methods

	// RVA: 0x3E9310 Offset: 0x3E7910 VA: 0x1803E9310
	public void Init() { }

	// RVA: 0x3E96B0 Offset: 0x3E7CB0 VA: 0x1803E96B0
	public void .ctor() { }
}

