// Namespace: Assets.Scripts.Steam.LeaderboardsNew
public class LeaderboardUploadQueued // TypeDefIndex: 5391
{
	// Fields
	public string name; // 0x10
	public int score; // 0x18
	public int[] details; // 0x20
	public bool isFriends; // 0x28

	// Methods

	// RVA: 0x3DDEE0 Offset: 0x3DC4E0 VA: 0x1803DDEE0
	public void .ctor(string name, int score, int[] details, bool isFriends) { }
}

// Namespace: Assets.Scripts.Steam.LeaderboardsNew
public class SteamLeaderboardNew // TypeDefIndex: 5392
{
	// Fields
	public string lbName; // 0x10
	public string lbNameFriends; // 0x18
	public SteamLeaderboard_t lbHandle; // 0x20
	public SteamLeaderboard_t lbHandleFriends; // 0x28
	public List<LeaderboardEntry> globalEntries; // 0x30
	public List<LeaderboardEntry> friendsEntries; // 0x38
	public LeaderboardEntry localEntry; // 0x40
	public int localEntryRankFriends; // 0x48
	public static Action<SteamLeaderboardNew> A_LeaderboardReady; // 0x0
	private bool isSingleBoard; // 0x4C
	public bool scanForLegit; // 0x4D
	private int leaderboardEntriesPerRequest; // 0x50
	private int currentIndex; // 0x54
	private int numEntriesGlobal; // 0x58
	private int numEntriesFriends; // 0x5C
	private int numDesiredGlobalEntries; // 0x60
	private bool hasFriends; // 0x64
	private bool hasGlobal; // 0x65

	// Methods

	// RVA: 0x3EA430 Offset: 0x3E8A30 VA: 0x1803EA430
	public void .ctor(string name, bool singleBoard = False, int entriesPerRequest = 200, int desiredNumEntries = 200, bool scanForLegit = True) { }

	// RVA: 0x3EA3B0 Offset: 0x3E89B0 VA: 0x1803EA3B0
	public void SetHandle(SteamLeaderboard_t handle, string lb) { }

	// RVA: 0x3E9850 Offset: 0x3E7E50 VA: 0x1803E9850
	private bool IsFriendsLb(string lb) { }

	// RVA: 0x3E98B0 Offset: 0x3E7EB0 VA: 0x1803E98B0
	public bool IsReadyToDownloadEntries() { }

	// RVA: 0x3E98A0 Offset: 0x3E7EA0 VA: 0x1803E98A0
	public bool IsReadyToDisplay() { }

	// RVA: 0x3E97E0 Offset: 0x3E7DE0 VA: 0x1803E97E0
	public int GetTotalEntries(string lb) { }

	// RVA: 0x3EA1D0 Offset: 0x3E87D0 VA: 0x1803EA1D0
	public void Refresh() { }

	// RVA: 0x3EA300 Offset: 0x3E8900 VA: 0x1803EA300
	private void RequestGlobalEntries() { }

	// RVA: 0x3EA0E0 Offset: 0x3E86E0 VA: 0x1803EA0E0
	public void OnDownloadResults(string lbNameDownloaded, LeaderboardScoresDownloaded_t param) { }

	// RVA: 0x3E9BF0 Offset: 0x3E81F0 VA: 0x1803E9BF0
	private void OnDownloadResultsGlobal(LeaderboardScoresDownloaded_t param) { }

	// RVA: 0x3E98E0 Offset: 0x3E7EE0 VA: 0x1803E98E0
	private void OnDownloadResultsFriends(LeaderboardScoresDownloaded_t param) { }

	// RVA: 0x3E9770 Offset: 0x3E7D70 VA: 0x1803E9770
	private void CheckIfLeaderboardsAreReady() { }

	// RVA: 0x3E9F30 Offset: 0x3E8530 VA: 0x1803E9F30
	public void OnDownloadResultsLocal(string lbNameDownloaded, LeaderboardScoresDownloaded_t param) { }
}

// Namespace: Assets.Scripts.Steam.LeaderboardsNew
public static class Sus // TypeDefIndex: 5393
{
	// Methods

	// RVA: 0x3ED990 Offset: 0x3EBF90 VA: 0x1803ED990
	public static bool Check() { }

	// RVA: 0x3ED1D0 Offset: 0x3EB7D0 VA: 0x1803ED1D0
	public static bool CheckMods(out string reason) { }
}

