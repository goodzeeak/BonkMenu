// Namespace: Assets.Scripts.Menu.Shop.Leaderboards
public enum ELeaderboardCategory // TypeDefIndex: 5349
{
	// Fields
	public int value__; // 0x0
	public const ELeaderboardCategory Kills = 0;
	public const ELeaderboardCategory Speedrun = 1;
}

// Namespace: Assets.Scripts.Menu.Shop.Leaderboards
public static class LeaderboardUtility // TypeDefIndex: 5351
{
	// Methods

	// RVA: 0x3BE170 Offset: 0x3BC770 VA: 0x1803BE170
	public static List<LeaderboardEntry> GetEntriesKills(bool isGlobal, bool isWeekly, int numToShow) { }

	// RVA: 0x3BDC40 Offset: 0x3BC240 VA: 0x1803BDC40
	private static List<LeaderboardEntry> GetEntriesKills(List<LeaderboardEntry> globalEntries, List<LeaderboardEntry> friendsEntries, int numToShow) { }

	// RVA: 0x3BE3F0 Offset: 0x3BC9F0 VA: 0x1803BE3F0
	private static List<LeaderboardEntry> GetFriendsEntries(SteamLeaderboardNew leaderboard, int numToShow) { }
}

