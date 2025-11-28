// Namespace: Assets.Scripts.Saves___Serialization.Progression
public class CharacterProgression // TypeDefIndex: 5410
{
	// Fields
	public int xp; // 0x10
	public int numRuns; // 0x14
	private float xpModifier; // 0x18

	// Methods

	// RVA: 0x3DAA50 Offset: 0x3D9050 VA: 0x1803DAA50
	public void OnRunFinished(int xp) { }

	// RVA: 0x3DA9A0 Offset: 0x3D8FA0 VA: 0x1803DA9A0
	public int GetRank() { }

	// RVA: 0x3DA9F0 Offset: 0x3D8FF0 VA: 0x1803DA9F0
	public bool HasStar() { }

	// RVA: 0x3DAA90 Offset: 0x3D9090 VA: 0x1803DAA90
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression
[Serializable]
public class LocalizationKey // TypeDefIndex: 5411
{
	// Fields
	public string key; // 0x10
	public LocalizedString localizedValue; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(string key, LocalizedString localizedValue) { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression
[Serializable]
public class EnemyLog // TypeDefIndex: 5412
{
	// Fields
	public int kills; // 0x10
	public int currentChallengeTier; // 0x14

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression
public static class LogUtility // TypeDefIndex: 5413
{
	// Fields
	public static int numMaxChallenges; // 0x0

	// Methods

	// RVA: 0x3DE390 Offset: 0x3DC990 VA: 0x1803DE390
	public static int GetNumMaxEntries() { }

	// RVA: 0x3DE420 Offset: 0x3DCA20 VA: 0x1803DE420
	public static int GetNumUnlockedEntries() { }

	// RVA: 0x3DED40 Offset: 0x3DD340 VA: 0x1803DED40
	public static bool IsEntryUnlocked(EEnemy enemy) { }

	// RVA: 0x3DDFA0 Offset: 0x3DC5A0 VA: 0x1803DDFA0
	public static void GetChallengeProgress(EEnemy eEnemy, out float currentChallengeProgress, out int numChallengesClaimed, out int numKills, out int numKillsForNextChallengeTier) { }

	// RVA: 0x3DEC70 Offset: 0x3DD270 VA: 0x1803DEC70
	public static bool HasUnclaimedReward(EEnemy eEnemy) { }

	// RVA: 0x3DE860 Offset: 0x3DCE60 VA: 0x1803DE860
	public static bool HasAnyUnclaimedReward() { }

	// RVA: 0x3DEB70 Offset: 0x3DD170 VA: 0x1803DEB70
	public static bool HasClaimedAllRewards(EEnemy eEnemy) { }

	// RVA: 0x3DE240 Offset: 0x3DC840 VA: 0x1803DE240
	public static int GetNumChallengeKills(EEnemy eEnemy, int tier) { }

	// RVA: 0x3DE790 Offset: 0x3DCD90 VA: 0x1803DE790
	public static int GetReward(EEnemy eEnemy) { }

	// RVA: 0x3DEE10 Offset: 0x3DD410 VA: 0x1803DEE10
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression
[Serializable]
public class MapProgress // TypeDefIndex: 5414
{
	// Fields
	public HashSet<int> tierNotifications; // 0x10
	public HashSet<int> tierChallengeNotifications; // 0x18
	public bool newMapNotification; // 0x20
	public int lastSelectTier; // 0x24
	public List<int> completedTiers; // 0x28
	public Dictionary<int, HashSet<ECharacter>> tierCompletionsWithCharacters; // 0x30
	public Dictionary<int, int> numRunsByTier; // 0x38
	public Dictionary<int, float> tierHighscores; // 0x40
	public Dictionary<int, float> tierFastestTimes; // 0x48

	// Methods

	// RVA: 0x3DF470 Offset: 0x3DDA70 VA: 0x1803DF470
	public void OnRunFinished(ECharacter character, bool victory, int tier) { }

	// RVA: 0x3DEF50 Offset: 0x3DD550 VA: 0x1803DEF50
	public int GetNumTierRuns(int tier) { }

	// RVA: 0x3DEFF0 Offset: 0x3DD5F0 VA: 0x1803DEFF0
	public List<ECharacter> GetTierCompletionCharacters(int tier) { }

	// RVA: 0x3DEE50 Offset: 0x3DD450 VA: 0x1803DEE50
	public void CompleteTier(int tier) { }

	// RVA: 0x3DF410 Offset: 0x3DDA10 VA: 0x1803DF410
	public bool IsTierCompleted(int tier) { }

	// RVA: 0x3DF650 Offset: 0x3DDC50 VA: 0x1803DF650
	public void SetCompletedTime(float time) { }

	// RVA: 0x3DF700 Offset: 0x3DDD00 VA: 0x1803DF700
	public void SetKills(int kills) { }

	// RVA: 0x3DF300 Offset: 0x3DD900 VA: 0x1803DF300
	public string GetTierHighscoreString(int tier) { }

	// RVA: 0x3DF100 Offset: 0x3DD700 VA: 0x1803DF100
	public string GetTierFastestTimeString(int tier) { }

	// RVA: 0x3DF7C0 Offset: 0x3DDDC0 VA: 0x1803DF7C0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression
[Serializable]
public class MenuMeta // TypeDefIndex: 5415
{
	// Fields
	public EMap lastSelectedMap; // 0x10
	public Dictionary<EMap, MapProgress> mapsProgress; // 0x18
	private int numRunsForUnlocks; // 0x20
	private int numRunsForLeaderboards; // 0x24
	private int numRunsForQuests; // 0x28
	private int numRunsForQuickQuests; // 0x2C
	private int numRunsForShop; // 0x30
	public bool hasVisitedUnlocks; // 0x34
	public bool hasVisitedQuests; // 0x35
	public bool hasVisitedShop; // 0x36

	// Methods

	// RVA: 0x3DFE90 Offset: 0x3DE490 VA: 0x1803DFE90
	public bool HasMenuUnlocks() { }

	// RVA: 0x3DFD50 Offset: 0x3DE350 VA: 0x1803DFD50
	public bool HasMenuQuests() { }

	// RVA: 0x3DFDF0 Offset: 0x3DE3F0 VA: 0x1803DFDF0
	public bool HasMenuShop() { }

	// RVA: 0x3DFF30 Offset: 0x3DE530 VA: 0x1803DFF30
	public bool HasQuickQuests() { }

	// RVA: 0x3DFC10 Offset: 0x3DE210 VA: 0x1803DFC10
	public bool HasLeaderboards() { }

	// RVA: 0x3DFBB0 Offset: 0x3DE1B0 VA: 0x1803DFBB0
	public MapProgress GetMapProgress(EMap map) { }

	// RVA: 0x3E01E0 Offset: 0x3DE7E0 VA: 0x1803E01E0
	private void VerifyMap(EMap map) { }

	// RVA: 0x3E0160 Offset: 0x3DE760 VA: 0x1803E0160
	public void SetTier(EMap map, int tier) { }

	// RVA: 0x3E0090 Offset: 0x3DE690 VA: 0x1803E0090
	public void SetTierCompletion(EMap map, int tier) { }

	// RVA: 0x3DFB40 Offset: 0x3DE140 VA: 0x1803DFB40
	public int GetLastSelectedTier(EMap map) { }

	// RVA: 0x3DFFD0 Offset: 0x3DE5D0 VA: 0x1803DFFD0
	public bool IsTierCompleted(EMap map, int tier) { }

	// RVA: 0x3DF9B0 Offset: 0x3DDFB0 VA: 0x1803DF9B0
	public int GetHighestCompletedTier(EMap map) { }

	// RVA: 0x3E0290 Offset: 0x3DE890 VA: 0x1803E0290
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Saves___Serialization.Progression
public static class Progression // TypeDefIndex: 5416
{
	// Methods

	// RVA: 0x3E76A0 Offset: 0x3E5CA0 VA: 0x1803E76A0
	public static void Init() { }

	// RVA: 0x3E7590 Offset: 0x3E5B90 VA: 0x1803E7590
	public static void Cleanup() { }
}

