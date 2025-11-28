// Namespace: Assets.Scripts.Saves___Serialization.Progression.Stats
public class DamageSource // TypeDefIndex: 5417
{
	// Fields
	public string damageSource; // 0x10
	public float addedAtTime; // 0x18
	public float damage; // 0x1C

	// Methods

	// RVA: 0x3DDE90 Offset: 0x3DC490 VA: 0x1803DDE90
	public void .ctor(string damageSource, float addedAtTime) { }

	// RVA: 0x3DD860 Offset: 0x3DBE60 VA: 0x1803DD860
	public void AddDamage(float d) { }

	// RVA: 0x3DDC20 Offset: 0x3DC220 VA: 0x1803DDC20
	public int GetLevel() { }

	// RVA: 0x3DD870 Offset: 0x3DBE70 VA: 0x1803DD870
	public Texture GetIcon() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Stats
[Serializable]
public enum EMyStat // TypeDefIndex: 5418
{
	// Fields
	public int value__; // 0x0
	public const EMyStat kills = 0;
	public const EMyStat goldEarned = 1;
	public const EMyStat goldSpent = 2;
	public const EMyStat chestsOpened = 3;
	public const EMyStat itemsPickedUp = 4;
	public const EMyStat eliteKills = 5;
	public const EMyStat bossKills = 6;
	public const EMyStat xpGained = 7;
	public const EMyStat skeletonKills = 8;
	public const EMyStat damageReductionArmorAsKnight = 9;
	public const EMyStat damageReductionArmor = 10;
	public const EMyStat projectilesFired = 11;
	public const EMyStat evades = 12;
	public const EMyStat potsBroken = 13;
	public const EMyStat shrineSucc = 14;
	public const EMyStat fireKills = 15;
	public const EMyStat shrineCharge = 16;
	public const EMyStat lifestealHealing = 17;
	public const EMyStat shrineChallenge = 18;
	public const EMyStat crits = 19;
	public const EMyStat chestsBought = 20;
	public const EMyStat minibossKills = 21;
	public const EMyStat runs = 22;
	public const EMyStat silverEarned = 23;
	public const EMyStat cactusKillsWithThorns = 24;
	public const EMyStat lightningKills = 25;
	public const EMyStat standingStillKills = 26;
	public const EMyStat bloodMagicProcs = 27;
	public const EMyStat finalBossKills = 28;
	public const EMyStat icecubeFreezes = 29;
	public const EMyStat foxWispsKills = 30;
	public const EMyStat powerupsUsed = 31;
	public const EMyStat goblinKills = 32;
	public const EMyStat minibossKillsCalcium = 33;
	public const EMyStat killsInTornadoWithTornado = 34;
	public const EMyStat moldyCheeseProcs = 35;
	public const EMyStat questsCompleted = 36;
	public const EMyStat challengesCompleted = 37;
	public const EMyStat wallhugs = 38;
	public const EMyStat unlocksPurchased = 39;
	public const EMyStat shrineChargeSandstorm = 40;
	public const EMyStat aegisBlocks = 41;
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Stats
[Serializable]
public class MyStat // TypeDefIndex: 5419
{
	// Fields
	public string name; // 0x10
	public float value; // 0x18

	// Methods

	// RVA: 0x3DDE90 Offset: 0x3DC490 VA: 0x1803DDE90
	public void .ctor(string name, float value) { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Stats
public static class MyStats // TypeDefIndex: 5420
{
	// Fields
	private static bool hasUnsavedChanges; // 0x0
	public static Action<string, MyStat> A_StatUpdated; // 0x8
	private static float nextSaveTimeReady; // 0x10
	private static float saveCooldown; // 0x14

	// Methods

	// RVA: 0x3E4FE0 Offset: 0x3E35E0 VA: 0x1803E4FE0
	public static void Init() { }

	// RVA: 0x3E4A80 Offset: 0x3E3080 VA: 0x1803E4A80
	public static void Cleanup() { }

	// RVA: 0x3E49F0 Offset: 0x3E2FF0 VA: 0x1803E49F0
	public static void AddValue(EMyStat statName, float value) { }

	// RVA: 0x3E4760 Offset: 0x3E2D60 VA: 0x1803E4760
	public static void AddValue(string statName, float value) { }

	// RVA: 0x3E58D0 Offset: 0x3E3ED0 VA: 0x1803E58D0
	private static void SetValue(string statName, float value) { }

	// RVA: 0x3E5580 Offset: 0x3E3B80 VA: 0x1803E5580
	public static void SetValueForce(string statName, float value) { }

	// RVA: 0x3E4F20 Offset: 0x3E3520 VA: 0x1803E4F20
	public static bool HasStat(string statName) { }

	// RVA: 0x3E4DB0 Offset: 0x3E33B0 VA: 0x1803E4DB0
	public static float GetStat(string statName) { }

	// RVA: 0x3E54E0 Offset: 0x3E3AE0 VA: 0x1803E54E0
	private static void OnProgressionLoaded() { }

	// RVA: 0x3E5530 Offset: 0x3E3B30 VA: 0x1803E5530
	private static void OnProgressionSaved() { }

	// RVA: 0x3E53A0 Offset: 0x3E39A0 VA: 0x1803E53A0
	private static void OnPause(bool paused) { }

	// RVA: 0x3E5D00 Offset: 0x3E4300 VA: 0x1803E5D00
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Stats
public static class RunStats // TypeDefIndex: 5421
{
	// Fields
	private static Dictionary<string, float> stats; // 0x0
	public static Dictionary<string, DamageSource> damageSources; // 0x8
	public static List<MyAchievement> achievements; // 0x10
	public static Action<string, float> A_StatChange; // 0x18

	// Methods

	// RVA: 0x3E7E70 Offset: 0x3E6470 VA: 0x1803E7E70
	public static void Init() { }

	// RVA: 0x3E7AD0 Offset: 0x3E60D0 VA: 0x1803E7AD0
	public static void Cleanup() { }

	// RVA: 0x3E82A0 Offset: 0x3E68A0 VA: 0x1803E82A0
	private static void OnNewRun() { }

	// RVA: 0x3E8480 Offset: 0x3E6A80 VA: 0x1803E8480
	private static void Reset() { }

	// RVA: 0x3E7880 Offset: 0x3E5E80 VA: 0x1803E7880
	public static void AddValue(EMyStat stat, int value) { }

	// RVA: 0x3E7D10 Offset: 0x3E6310 VA: 0x1803E7D10
	public static int GetStat(EMyStat stat) { }

	// RVA: 0x3E7910 Offset: 0x3E5F10 VA: 0x1803E7910
	public static void AddValue(string stat, int value) { }

	// RVA: 0x3E7D90 Offset: 0x3E6390 VA: 0x1803E7D90
	public static int GetStat(string stat) { }

	// RVA: 0x3E77B0 Offset: 0x3E5DB0 VA: 0x1803E77B0
	public static void AddAchievement(MyAchievement achievement) { }

	// RVA: 0x3E80B0 Offset: 0x3E66B0 VA: 0x1803E80B0
	private static void OnEnemyDamaged(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x3E8630 Offset: 0x3E6C30 VA: 0x1803E8630
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Stats
public class StatTrackingUtility // TypeDefIndex: 5422
{
	// Fields
	private static HashSet<EEnemy> skeletonEnemies; // 0x0
	private static HashSet<EEnemy> wispEnemies; // 0x8
	private static HashSet<EEnemy> goblinEnemies; // 0x10
	private static Dictionary<ECharacter, string> keysKillsCharacters; // 0x18
	private static Dictionary<EEnemy, string> keysKillsEnemies; // 0x20
	private static Dictionary<string, string> keysKillsSources; // 0x28

	// Methods

	// RVA: 0x3E8EC0 Offset: 0x3E74C0 VA: 0x1803E8EC0
	public static bool IsSkeleton(Enemy enemy) { }

	// RVA: 0x3E8F50 Offset: 0x3E7550 VA: 0x1803E8F50
	public static bool IsWisp(Enemy enemy) { }

	// RVA: 0x3E8E30 Offset: 0x3E7430 VA: 0x1803E8E30
	public static bool IsGoblin(Enemy enemy) { }

	// RVA: 0x3E87C0 Offset: 0x3E6DC0 VA: 0x1803E87C0
	public static string GetKeyKillsCharacter(ECharacter character) { }

	// RVA: 0x3E89E0 Offset: 0x3E6FE0 VA: 0x1803E89E0
	public static string GetKeyKillsEnemy(Enemy enemy) { }

	// RVA: 0x3E8C50 Offset: 0x3E7250 VA: 0x1803E8C50
	public static string GetKeyKillsSource(DamageContainer dc) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3E8FE0 Offset: 0x3E75E0 VA: 0x1803E8FE0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression.Stats
public static class TrackStats // TypeDefIndex: 5423
{
	// Fields
	public static Action A_PotBroken; // 0x0
	private static string tornadoDamageSource; // 0x8
	private static HashSet<EPickup> nonPowerupPickups; // 0x10
	private static Dictionary<EMyStat, string> statStrings; // 0x18

	// Methods

	// RVA: 0x3EF160 Offset: 0x3ED760 VA: 0x1803EF160
	public static void Init() { }

	// RVA: 0x3EDBA0 Offset: 0x3EC1A0 VA: 0x1803EDBA0
	public static void Cleanup() { }

	// RVA: 0x3ED9B0 Offset: 0x3EBFB0 VA: 0x1803ED9B0
	private static void AddValue(EMyStat stat, int value) { }

	// RVA: 0x3EDB10 Offset: 0x3EC110 VA: 0x1803EDB10
	private static void AddValue(string statKey, int value) { }

	// RVA: 0x3F11E0 Offset: 0x3EF7E0 VA: 0x1803F11E0
	private static void OnGoldChange(PlayerInventory inv, int amount) { }

	// RVA: 0x3F17F0 Offset: 0x3EFDF0 VA: 0x1803F17F0
	private static void OnSilverChange(int change) { }

	// RVA: 0x3F0A10 Offset: 0x3EF010 VA: 0x1803F0A10
	private static void OnEnemyDied(Enemy enemy, DamageContainer deathSource) { }

	// RVA: 0x3F09A0 Offset: 0x3EEFA0 VA: 0x1803F09A0
	private static void OnEnemyDamage(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x3F0900 Offset: 0x3EEF00 VA: 0x1803F0900
	private static void OnChestOpened() { }

	// RVA: 0x3F1410 Offset: 0x3EFA10 VA: 0x1803F1410
	private static void OnItemAdded(EItem eItem) { }

	// RVA: 0x3F1980 Offset: 0x3EFF80 VA: 0x1803F1980
	private static void OnXpAdded(PlayerXp playerXp, int amount) { }

	// RVA: 0x3F0550 Offset: 0x3EEB50 VA: 0x1803F0550
	private static void OnAchievementUnlocked(MyAchievement ach) { }

	// RVA: 0x3F1850 Offset: 0x3EFE50 VA: 0x1803F1850
	private static void OnUnlockPurchased(UnlockableBase unlock) { }

	// RVA: 0x3F1650 Offset: 0x3EFC50 VA: 0x1803F1650
	private static void OnProjectileSpawned(ProjectileBase projectileBase) { }

	// RVA: 0x3F12B0 Offset: 0x3EF8B0 VA: 0x1803F12B0
	private static void OnInteracted(BaseInteractable interactable, bool success) { }

	// RVA: 0x3F16A0 Offset: 0x3EFCA0 VA: 0x1803F16A0
	private static void OnShrineCharged(bool notInterrupted) { }

	// RVA: 0x3F0860 Offset: 0x3EEE60 VA: 0x1803F0860
	private static void OnChallengeShrineCompleted() { }

	// RVA: 0x3F08B0 Offset: 0x3EEEB0 VA: 0x1803F08B0
	private static void OnChestBought() { }

	// RVA: 0x3F1560 Offset: 0x3EFB60 VA: 0x1803F1560
	private static void OnPlayerTakeDamage(PlayerHealth ph, DamageContainer dc, bool brokeShield) { }

	// RVA: 0x3F1190 Offset: 0x3EF790 VA: 0x1803F1190
	private static void OnEvade(Enemy attacker) { }

	// RVA: 0x3F1460 Offset: 0x3EFA60 VA: 0x1803F1460
	private static void OnLifestealHealing(int amount) { }

	// RVA: 0x3F0950 Offset: 0x3EEF50 VA: 0x1803F0950
	private static void OnDead() { }

	// RVA: 0x3F1260 Offset: 0x3EF860 VA: 0x1803F1260
	private static void OnIcecubeFreezeEnemy() { }

	// RVA: 0x3F14B0 Offset: 0x3EFAB0 VA: 0x1803F14B0
	private static void OnPickup(Pickup pickup) { }

	// RVA: 0x3EF000 Offset: 0x3ED600 VA: 0x1803EF000
	public static string GetStatString(EMyStat stat) { }

	// RVA: 0x3EEF90 Offset: 0x3ED590 VA: 0x1803EEF90
	public static string GetCharacterRunsString(ECharacter character) { }

	// RVA: 0x3F19D0 Offset: 0x3EFFD0 VA: 0x1803F19D0
	private static void .cctor() { }
}

