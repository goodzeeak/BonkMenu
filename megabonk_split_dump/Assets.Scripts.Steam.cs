// Namespace: Assets.Scripts.Steam
public class LeaderboardContainer // TypeDefIndex: 5383
{
	// Fields
	public int numEntries; // 0x10
	public SteamLeaderboard_t leaderboardHandle; // 0x18
	public List<LeaderboardEntry> globalEntries; // 0x20
	public LeaderboardEntry localEntry; // 0x28

	// Methods

	// RVA: 0x3BDB10 Offset: 0x3BC110 VA: 0x1803BDB10
	public void .ctor(SteamLeaderboard_t handle) { }
}

// Namespace: Assets.Scripts.Steam
public class LeaderboardEntry // TypeDefIndex: 5384
{
	// Fields
	public LeaderboardEntry_t leaderboardEntry; // 0x10
	public int[] details; // 0x30

	// Methods

	// RVA: 0x3BDBF0 Offset: 0x3BC1F0 VA: 0x1803BDBF0
	public void .ctor(LeaderboardEntry_t leaderboardEntry, int[] details) { }

	// RVA: 0x3BDB40 Offset: 0x3BC140 VA: 0x1803BDB40
	public ECharacter GetCharacter() { }
}

// Namespace: Assets.Scripts.Steam
public class Leaderboards // TypeDefIndex: 5385
{
	// Fields
	public static int numMaxDeatils; // 0x0

	// Methods

	// RVA: 0x3BF2E0 Offset: 0x3BD8E0 VA: 0x1803BF2E0
	public static void UploadScore(int score) { }

	// RVA: 0x3BEFE0 Offset: 0x3BD5E0 VA: 0x1803BEFE0
	private static int[] GetWeapons() { }

	// RVA: 0x3BEDD0 Offset: 0x3BD3D0 VA: 0x1803BEDD0
	private static int[] GetTomes() { }

	// RVA: 0x3BECB0 Offset: 0x3BD2B0 VA: 0x1803BECB0
	public static ECharacter GetCharacter(int[] details) { }

	// RVA: 0x3BF210 Offset: 0x3BD810 VA: 0x1803BF210
	private static bool IsLegitCharacter(int[] details) { }

	// RVA: 0x3BE5F0 Offset: 0x3BCBF0 VA: 0x1803BE5F0
	public static bool CanShowScore(ulong steamid, int score, int[] leaderboardDetails, out string s) { }

	// RVA: 0x3BED20 Offset: 0x3BD320 VA: 0x1803BED20
	private static string GetSecretKey() { }

	// RVA: 0x3BEAF0 Offset: 0x3BD0F0 VA: 0x1803BEAF0
	private static int[] GenerateScoreHash(int score) { }

	// RVA: 0x3BE8D0 Offset: 0x3BCED0 VA: 0x1803BE8D0
	private static int[] GenerateScoreHashNew(int score, ulong steamid) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3C03C0 Offset: 0x3BE9C0 VA: 0x1803C03C0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Steam
public static class SteamAchievementsManager // TypeDefIndex: 5386
{
	// Fields
	public static bool ENABLED; // 0x0
	private static bool hasQueuedUpload; // 0x1
	private static float uploadAtTime; // 0x4

	// Methods

	// RVA: 0x3CC620 Offset: 0x3CAC20 VA: 0x1803CC620
	public static void Init() { }

	// RVA: 0x3CC870 Offset: 0x3CAE70 VA: 0x1803CC870
	public static void OnDestroy() { }

	// RVA: 0x3CCC80 Offset: 0x3CB280 VA: 0x1803CCC80
	private static void Update() { }

	// RVA: 0x3CCB40 Offset: 0x3CB140 VA: 0x1803CCB40
	public static void TryUnlockAchievement(string achievementKey) { }

	// RVA: 0x3CCAC0 Offset: 0x3CB0C0 VA: 0x1803CCAC0
	private static void QueueUpload() { }

	// RVA: 0x3CCC70 Offset: 0x3CB270 VA: 0x1803CCC70
	private static void TryUploadAchievements() { }

	// RVA: 0x3CC4A0 Offset: 0x3CAAA0 VA: 0x1803CC4A0
	public static void CheckAchievements() { }

	// RVA: 0x3CCD60 Offset: 0x3CB360 VA: 0x1803CCD60
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Steam
public static class SteamRichPresenceManager // TypeDefIndex: 5387
{
	// Fields
	public const string LEVEL_KEY = "lvl";
	public const string CHARACTER_KEY = "character";
	public const string MAP_KEY = "map";
	public const string TIME_KEY = "time";
	public const string MENU_STATUS_KEY = "menu_string";
	public const string DISPLAY_KEY = "steam_display";
	public const string TOKEN_MENU = "#Status_AtMainMenu";
	public const string TOKEN_INGAME = "#Status_InGame";
	private static float previousSecond; // 0x0

	// Methods

	// RVA: 0x3CD5B0 Offset: 0x3CBBB0 VA: 0x1803CD5B0
	public static void Init() { }

	// RVA: 0x3CD8C0 Offset: 0x3CBEC0 VA: 0x1803CD8C0
	private static void MainMenuOpened() { }

	// RVA: 0x3CDDF0 Offset: 0x3CC3F0 VA: 0x1803CDDF0
	public static void UpdateDisplayInGame() { }

	// RVA: 0x3CD090 Offset: 0x3CB690 VA: 0x1803CD090
	public static string GetPlayerLevel() { }

	// RVA: 0x3CE240 Offset: 0x3CC840 VA: 0x1803CE240
	private static void Update() { }

	// RVA: 0x3CE1A0 Offset: 0x3CC7A0 VA: 0x1803CE1A0
	private static void UpdateTimer() { }

	// RVA: 0x3CDD70 Offset: 0x3CC370 VA: 0x1803CDD70
	private static void SetKeyValue(string key, string value) { }

	// RVA: 0x3CCDA0 Offset: 0x3CB3A0 VA: 0x1803CCDA0
	public static string GetCharacter() { }

	// RVA: 0x3CCEB0 Offset: 0x3CB4B0 VA: 0x1803CCEB0
	public static ECharacter GetEnumCharacter() { }

	// RVA: 0x3CCF80 Offset: 0x3CB580 VA: 0x1803CCF80
	public static string GetMapString() { }

	// RVA: 0x3CD450 Offset: 0x3CBA50 VA: 0x1803CD450
	private static string GetTime() { }

	// RVA: 0x3CD160 Offset: 0x3CB760 VA: 0x1803CD160
	public static string GetRandomMenuStatus() { }

	// RVA: 0x3CDC90 Offset: 0x3CC290 VA: 0x1803CDC90
	private static void Refresh() { }

	// RVA: 0x3CD930 Offset: 0x3CBF30 VA: 0x1803CD930
	public static void OnDestroy() { }
}

// Namespace: Assets.Scripts.Steam
public static class SteamStatsManager // TypeDefIndex: 5388
{
	// Fields
	public static bool areStatsReady; // 0x0
	private static Callback<UserStatsReceived_t> m_UserStatsReceived; // 0x8
	private static bool hasQueuedUpload; // 0x10
	private static float uploadReadyAtTime; // 0x14
	private static float uploadCooldown; // 0x18
	private static Dictionary<string, int> cachedStatUpdates; // 0x20
	private static float setCachedStatsInterval; // 0x28
	private static float nextSetCachedStatsTime; // 0x2C
	private static bool hasChanges; // 0x30

	// Methods

	// RVA: 0x3EA590 Offset: 0x3E8B90 VA: 0x1803EA590
	public static void Init() { }

	// RVA: 0x3EABB0 Offset: 0x3E91B0 VA: 0x1803EABB0
	public static void OnDestroy() { }

	// RVA: 0x3EB390 Offset: 0x3E9990 VA: 0x1803EB390
	public static void RequestStats() { }

	// RVA: 0x3EB320 Offset: 0x3E9920 VA: 0x1803EB320
	private static void QueueUpload() { }

	// RVA: 0x3EB7B0 Offset: 0x3E9DB0 VA: 0x1803EB7B0
	private static void Update() { }

	// RVA: 0x3EB5D0 Offset: 0x3E9BD0 VA: 0x1803EB5D0
	private static void TryUploadStats() { }

	// RVA: 0x3EB0B0 Offset: 0x3E96B0 VA: 0x1803EB0B0
	private static void OnStatUpdated(string arg1, MyStat arg2) { }

	// RVA: 0x3EB3A0 Offset: 0x3E99A0 VA: 0x1803EB3A0
	private static void SetCachedStats() { }

	// RVA: 0x3EB150 Offset: 0x3E9750 VA: 0x1803EB150
	private static void OnUserStatsReceived(UserStatsReceived_t param) { }

	// RVA: 0x3EBA80 Offset: 0x3EA080 VA: 0x1803EBA80
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Steam
public static class SteamTimelineManager // TypeDefIndex: 5389
{
	// Methods

	// RVA: 0x3EBB60 Offset: 0x3EA160 VA: 0x1803EBB60
	public static void Init() { }

	// RVA: 0x3EC280 Offset: 0x3EA880 VA: 0x1803EC280
	public static void OnDestroy() { }

	// RVA: 0x3ECAB0 Offset: 0x3EB0B0 VA: 0x1803ECAB0
	private static void OnStageStarted() { }

	// RVA: 0x3ECA30 Offset: 0x3EB030 VA: 0x1803ECA30
	private static void OnPlayerDied() { }

	// RVA: 0x3EC9A0 Offset: 0x3EAFA0 VA: 0x1803EC9A0
	public static void OnMainMenu() { }

	// RVA: 0x3EC200 Offset: 0x3EA800 VA: 0x1803EC200
	private static void OnBossSpawned() { }

	// RVA: 0x3EC9B0 Offset: 0x3EAFB0 VA: 0x1803EC9B0
	private static void OnMiniBoss() { }

	// RVA: 0x3ECCD0 Offset: 0x3EB2D0 VA: 0x1803ECCD0
	private static void OnSwarmStarted() { }

	// RVA: 0x3EC920 Offset: 0x3EAF20 VA: 0x1803EC920
	private static void OnFinalSwarmStarted() { }
}

// Namespace: Assets.Scripts.Steam
public class SteamUtility // TypeDefIndex: 5390
{
	// Methods

	// RVA: 0x3ECEF0 Offset: 0x3EB4F0 VA: 0x1803ECEF0
	public static Texture2D LoadAvatar(ulong steamId, int quality = 0) { }

	// RVA: 0x3ECD50 Offset: 0x3EB350 VA: 0x1803ECD50
	public static Texture2D FlipTexture(Texture2D original) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

