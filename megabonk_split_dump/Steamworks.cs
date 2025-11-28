// Namespace: Steamworks
public static class SteamApps // TypeDefIndex: 10185
{
	// Methods

	// RVA: 0x561CE0 Offset: 0x5602E0 VA: 0x180561CE0
	public static bool BIsSubscribed() { }

	// RVA: 0x561BA0 Offset: 0x5601A0 VA: 0x180561BA0
	public static bool BIsLowViolence() { }

	// RVA: 0x561B00 Offset: 0x560100 VA: 0x180561B00
	public static bool BIsCybercafe() { }

	// RVA: 0x561D90 Offset: 0x560390 VA: 0x180561D90
	public static bool BIsVACBanned() { }

	// RVA: 0x5622A0 Offset: 0x5608A0 VA: 0x1805622A0
	public static string GetCurrentGameLanguage() { }

	// RVA: 0x561FD0 Offset: 0x5605D0 VA: 0x180561FD0
	public static string GetAvailableGameLanguages() { }

	// RVA: 0x561BF0 Offset: 0x5601F0 VA: 0x180561BF0
	public static bool BIsSubscribedApp(AppId_t appID) { }

	// RVA: 0x561B50 Offset: 0x560150 VA: 0x180561B50
	public static bool BIsDlcInstalled(AppId_t appID) { }

	// RVA: 0x5623C0 Offset: 0x5609C0 VA: 0x1805623C0
	public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID) { }

	// RVA: 0x561C90 Offset: 0x560290 VA: 0x180561C90
	public static bool BIsSubscribedFromFreeWeekend() { }

	// RVA: 0x5622F0 Offset: 0x5608F0 VA: 0x1805622F0
	public static int GetDLCCount() { }

	// RVA: 0x561980 Offset: 0x55FF80 VA: 0x180561980
	public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize) { }

	// RVA: 0x562840 Offset: 0x560E40 VA: 0x180562840
	public static void InstallDLC(AppId_t nAppID) { }

	// RVA: 0x562AE0 Offset: 0x5610E0 VA: 0x180562AE0
	public static void UninstallDLC(AppId_t nAppID) { }

	// RVA: 0x562930 Offset: 0x560F30 VA: 0x180562930
	public static void RequestAppProofOfPurchaseKey(AppId_t nAppID) { }

	// RVA: 0x5621B0 Offset: 0x5607B0 VA: 0x1805621B0
	public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize) { }

	// RVA: 0x562890 Offset: 0x560E90 VA: 0x180562890
	public static bool MarkContentCorrupt(bool bMissingFilesOnly) { }

	// RVA: 0x562550 Offset: 0x560B50 VA: 0x180562550
	public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots) { }

	// RVA: 0x561E30 Offset: 0x560430 VA: 0x180561E30
	public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize) { }

	// RVA: 0x561AB0 Offset: 0x5600B0 VA: 0x180561AB0
	public static bool BIsAppInstalled(AppId_t appID) { }

	// RVA: 0x561F40 Offset: 0x560540 VA: 0x180561F40
	public static CSteamID GetAppOwner() { }

	// RVA: 0x5626C0 Offset: 0x560CC0 VA: 0x1805626C0
	public static string GetLaunchQueryParam(string pchKey) { }

	// RVA: 0x562340 Offset: 0x560940 VA: 0x180562340
	public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0x561DE0 Offset: 0x5603E0 VA: 0x180561DE0
	public static int GetAppBuildId() { }

	// RVA: 0x5628E0 Offset: 0x560EE0 VA: 0x1805628E0
	public static void RequestAllProofOfPurchaseKeys() { }

	// RVA: 0x562410 Offset: 0x560A10 VA: 0x180562410
	public static SteamAPICall_t GetFileDetails(string pszFileName) { }

	// RVA: 0x5625D0 Offset: 0x560BD0 VA: 0x1805625D0
	public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine) { }

	// RVA: 0x561C40 Offset: 0x560240 VA: 0x180561C40
	public static bool BIsSubscribedFromFamilySharing() { }

	// RVA: 0x561D30 Offset: 0x560330 VA: 0x180561D30
	public static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed) { }

	// RVA: 0x562A90 Offset: 0x561090 VA: 0x180562A90
	public static bool SetDlcContext(AppId_t nAppID) { }

	// RVA: 0x5627E0 Offset: 0x560DE0 VA: 0x1805627E0
	public static int GetNumBetas(out int pnAvailable, out int pnPrivate) { }

	// RVA: 0x562020 Offset: 0x560620 VA: 0x180562020
	public static bool GetBetaInfo(int iBetaIndex, out uint punFlags, out uint punBuildID, out string pchBetaName, int cchBetaName, out string pchDescription, int cchDescription) { }

	// RVA: 0x562980 Offset: 0x560F80 VA: 0x180562980
	public static bool SetActiveBeta(string pchBetaName) { }
}

// Namespace: Steamworks
public static class SteamClient // TypeDefIndex: 10186
{
	// Methods

	// RVA: 0x562CA0 Offset: 0x5612A0 VA: 0x180562CA0
	public static HSteamPipe CreateSteamPipe() { }

	// RVA: 0x562B30 Offset: 0x561130 VA: 0x180562B30
	public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) { }

	// RVA: 0x562BD0 Offset: 0x5611D0 VA: 0x180562BD0
	public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) { }

	// RVA: 0x562C30 Offset: 0x561230 VA: 0x180562C30
	public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	// RVA: 0x564DA0 Offset: 0x5633A0 VA: 0x180564DA0
	public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) { }

	// RVA: 0x564A00 Offset: 0x563000 VA: 0x180564A00
	public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563380 Offset: 0x561980 VA: 0x180563380
	public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564E00 Offset: 0x563400 VA: 0x180564E00
	public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) { }

	// RVA: 0x562FC0 Offset: 0x5615C0 VA: 0x180562FC0
	public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564B40 Offset: 0x563140 VA: 0x180564B40
	public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563C40 Offset: 0x562240 VA: 0x180563C40
	public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563B00 Offset: 0x562100 VA: 0x180563B00
	public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5634C0 Offset: 0x561AC0 VA: 0x1805634C0
	public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5648C0 Offset: 0x562EC0 VA: 0x1805648C0
	public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563240 Offset: 0x561840 VA: 0x180563240
	public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x562D40 Offset: 0x561340 VA: 0x180562D40
	public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564000 Offset: 0x562600 VA: 0x180564000
	public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564500 Offset: 0x562B00 VA: 0x180564500
	public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564640 Offset: 0x562C40 VA: 0x180564640
	public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563100 Offset: 0x561700 VA: 0x180563100
	public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x562CF0 Offset: 0x5612F0 VA: 0x180562CF0
	public static uint GetIPCCallCount() { }

	// RVA: 0x564E60 Offset: 0x563460 VA: 0x180564E60
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0x562B80 Offset: 0x561180 VA: 0x180562B80
	public static bool BShutdownIfAllPipesClosed() { }

	// RVA: 0x563740 Offset: 0x561D40 VA: 0x180563740
	public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x562E80 Offset: 0x561480 VA: 0x180562E80
	public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564780 Offset: 0x562D80 VA: 0x180564780
	public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563EC0 Offset: 0x5624C0 VA: 0x180563EC0
	public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563D80 Offset: 0x562380 VA: 0x180563D80
	public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563600 Offset: 0x561C00 VA: 0x180563600
	public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5639C0 Offset: 0x561FC0 VA: 0x1805639C0
	public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564C60 Offset: 0x563260 VA: 0x180564C60
	public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564140 Offset: 0x562740 VA: 0x180564140
	public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x563880 Offset: 0x561E80 VA: 0x180563880
	public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x564280 Offset: 0x562880 VA: 0x180564280
	public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5643C0 Offset: 0x5629C0 VA: 0x1805643C0
	public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }
}

// Namespace: Steamworks
public static class SteamFriends // TypeDefIndex: 10187
{
	// Methods

	// RVA: 0x566830 Offset: 0x564E30 VA: 0x180566830
	public static string GetPersonaName() { }

	// RVA: 0x567590 Offset: 0x565B90 VA: 0x180567590
	public static SteamAPICall_t SetPersonaName(string pchPersonaName) { }

	// RVA: 0x566880 Offset: 0x564E80 VA: 0x180566880
	public static EPersonaState GetPersonaState() { }

	// RVA: 0x565F10 Offset: 0x564510 VA: 0x180565F10
	public static int GetFriendCount(EFriendFlags iFriendFlags) { }

	// RVA: 0x565D40 Offset: 0x564340 VA: 0x180565D40
	public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags) { }

	// RVA: 0x5662A0 Offset: 0x5648A0 VA: 0x1805662A0
	public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend) { }

	// RVA: 0x566250 Offset: 0x564850 VA: 0x180566250
	public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend) { }

	// RVA: 0x5661F0 Offset: 0x5647F0 VA: 0x1805661F0
	public static string GetFriendPersonaName(CSteamID steamIDFriend) { }

	// RVA: 0x566000 Offset: 0x564600 VA: 0x180566000
	public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x566180 Offset: 0x564780 VA: 0x180566180
	public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName) { }

	// RVA: 0x5664E0 Offset: 0x564AE0 VA: 0x1805664E0
	public static int GetFriendSteamLevel(CSteamID steamIDFriend) { }

	// RVA: 0x5668D0 Offset: 0x564ED0 VA: 0x1805668D0
	public static string GetPlayerNickname(CSteamID steamIDPlayer) { }

	// RVA: 0x566530 Offset: 0x564B30 VA: 0x180566530
	public static int GetFriendsGroupCount() { }

	// RVA: 0x566580 Offset: 0x564B80 VA: 0x180566580
	public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG) { }

	// RVA: 0x5666E0 Offset: 0x564CE0 VA: 0x1805666E0
	public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID) { }

	// RVA: 0x566610 Offset: 0x564C10 VA: 0x180566610
	public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID) { }

	// RVA: 0x566660 Offset: 0x564C60 VA: 0x180566660
	public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount) { }

	// RVA: 0x566AD0 Offset: 0x5650D0 VA: 0x180566AD0
	public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags) { }

	// RVA: 0x565940 Offset: 0x563F40 VA: 0x180565940
	public static int GetClanCount() { }

	// RVA: 0x565730 Offset: 0x563D30 VA: 0x180565730
	public static CSteamID GetClanByIndex(int iClan) { }

	// RVA: 0x565990 Offset: 0x563F90 VA: 0x180565990
	public static string GetClanName(CSteamID steamIDClan) { }

	// RVA: 0x565B70 Offset: 0x564170 VA: 0x180565B70
	public static string GetClanTag(CSteamID steamIDClan) { }

	// RVA: 0x5656A0 Offset: 0x563CA0 VA: 0x1805656A0
	public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) { }

	// RVA: 0x5654D0 Offset: 0x563AD0 VA: 0x1805654D0
	public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest) { }

	// RVA: 0x565EC0 Offset: 0x5644C0 VA: 0x180565EC0
	public static int GetFriendCountFromSource(CSteamID steamIDSource) { }

	// RVA: 0x565F60 Offset: 0x564560 VA: 0x180565F60
	public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend) { }

	// RVA: 0x566E30 Offset: 0x565430 VA: 0x180566E30
	public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource) { }

	// RVA: 0x5674E0 Offset: 0x565AE0 VA: 0x1805674E0
	public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking) { }

	// RVA: 0x5652D0 Offset: 0x5638D0 VA: 0x1805652D0
	public static void ActivateGameOverlay(string pchDialog) { }

	// RVA: 0x5650B0 Offset: 0x5636B0 VA: 0x1805650B0
	public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID) { }

	// RVA: 0x5651C0 Offset: 0x5637C0 VA: 0x1805651C0
	public static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = 0) { }

	// RVA: 0x565050 Offset: 0x563650 VA: 0x180565050
	public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	// RVA: 0x5676D0 Offset: 0x565CD0 VA: 0x1805676D0
	public static void SetPlayedWith(CSteamID steamIDUserPlayedWith) { }

	// RVA: 0x564FB0 Offset: 0x5635B0 VA: 0x180564FB0
	public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby) { }

	// RVA: 0x566A30 Offset: 0x565030 VA: 0x180566A30
	public static int GetSmallFriendAvatar(CSteamID steamIDFriend) { }

	// RVA: 0x566790 Offset: 0x564D90 VA: 0x180566790
	public static int GetMediumFriendAvatar(CSteamID steamIDFriend) { }

	// RVA: 0x566740 Offset: 0x564D40 VA: 0x180566740
	public static int GetLargeFriendAvatar(CSteamID steamIDFriend) { }

	// RVA: 0x567360 Offset: 0x565960 VA: 0x180567360
	public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x5671F0 Offset: 0x5657F0 VA: 0x1805671F0
	public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan) { }

	// RVA: 0x565AE0 Offset: 0x5640E0 VA: 0x180565AE0
	public static CSteamID GetClanOwner(CSteamID steamIDClan) { }

	// RVA: 0x565A90 Offset: 0x564090 VA: 0x180565A90
	public static int GetClanOfficerCount(CSteamID steamIDClan) { }

	// RVA: 0x5659F0 Offset: 0x563FF0 VA: 0x1805659F0
	public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer) { }

	// RVA: 0x566A80 Offset: 0x565080 VA: 0x180566A80
	public static uint GetUserRestrictions() { }

	// RVA: 0x567720 Offset: 0x565D20 VA: 0x180567720
	public static bool SetRichPresence(string pchKey, string pchValue) { }

	// RVA: 0x565430 Offset: 0x563A30 VA: 0x180565430
	public static void ClearRichPresence() { }

	// RVA: 0x5663B0 Offset: 0x5649B0 VA: 0x1805663B0
	public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey) { }

	// RVA: 0x566360 Offset: 0x564960 VA: 0x180566360
	public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend) { }

	// RVA: 0x5662F0 Offset: 0x5648F0 VA: 0x1805662F0
	public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey) { }

	// RVA: 0x567310 Offset: 0x565910 VA: 0x180567310
	public static void RequestFriendRichPresence(CSteamID steamIDFriend) { }

	// RVA: 0x566B30 Offset: 0x565130 VA: 0x180566B30
	public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString) { }

	// RVA: 0x565BD0 Offset: 0x5641D0 VA: 0x180565BD0
	public static int GetCoplayFriendCount() { }

	// RVA: 0x565C20 Offset: 0x564220 VA: 0x180565C20
	public static CSteamID GetCoplayFriend(int iCoplayFriend) { }

	// RVA: 0x565E70 Offset: 0x564470 VA: 0x180565E70
	public static int GetFriendCoplayTime(CSteamID steamIDFriend) { }

	// RVA: 0x565DE0 Offset: 0x5643E0 VA: 0x180565DE0
	public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend) { }

	// RVA: 0x566E90 Offset: 0x565490 VA: 0x180566E90
	public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan) { }

	// RVA: 0x566F20 Offset: 0x565520 VA: 0x180566F20
	public static bool LeaveClanChatRoom(CSteamID steamIDClan) { }

	// RVA: 0x5657C0 Offset: 0x563DC0 VA: 0x1805657C0
	public static int GetClanChatMemberCount(CSteamID steamIDClan) { }

	// RVA: 0x565600 Offset: 0x563C00 VA: 0x180565600
	public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser) { }

	// RVA: 0x5673C0 Offset: 0x5659C0 VA: 0x1805673C0
	public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText) { }

	// RVA: 0x565810 Offset: 0x563E10 VA: 0x180565810
	public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) { }

	// RVA: 0x566C50 Offset: 0x565250 VA: 0x180566C50
	public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser) { }

	// RVA: 0x566CB0 Offset: 0x5652B0 VA: 0x180566CB0
	public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat) { }

	// RVA: 0x566F70 Offset: 0x565570 VA: 0x180566F70
	public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	// RVA: 0x565480 Offset: 0x563A80 VA: 0x180565480
	public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	// RVA: 0x567540 Offset: 0x565B40 VA: 0x180567540
	public static bool SetListenForFriendsMessages(bool bInterceptEnabled) { }

	// RVA: 0x5670D0 Offset: 0x5656D0 VA: 0x1805670D0
	public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend) { }

	// RVA: 0x566060 Offset: 0x564660 VA: 0x180566060
	public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType) { }

	// RVA: 0x565CB0 Offset: 0x5642B0 VA: 0x180565CB0
	public static SteamAPICall_t GetFollowerCount(CSteamID steamID) { }

	// RVA: 0x566DA0 Offset: 0x5653A0 VA: 0x180566DA0
	public static SteamAPICall_t IsFollowing(CSteamID steamID) { }

	// RVA: 0x565570 Offset: 0x563B70 VA: 0x180565570
	public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex) { }

	// RVA: 0x566D50 Offset: 0x565350 VA: 0x180566D50
	public static bool IsClanPublic(CSteamID steamIDClan) { }

	// RVA: 0x566D00 Offset: 0x565300 VA: 0x180566D00
	public static bool IsClanOfficialGameGroup(CSteamID steamIDClan) { }

	// RVA: 0x5667E0 Offset: 0x564DE0 VA: 0x1805667E0
	public static int GetNumChatsWithUnreadPriorityMessages() { }

	// RVA: 0x565000 Offset: 0x563600 VA: 0x180565000
	public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby) { }

	// RVA: 0x566FC0 Offset: 0x5655C0 VA: 0x180566FC0
	public static bool RegisterProtocolInOverlayBrowser(string pchProtocol) { }

	// RVA: 0x564EB0 Offset: 0x5634B0 VA: 0x180564EB0
	public static void ActivateGameOverlayInviteDialogConnectString(string pchConnectString) { }

	// RVA: 0x567280 Offset: 0x565880 VA: 0x180567280
	public static SteamAPICall_t RequestEquippedProfileItems(CSteamID steamID) { }

	// RVA: 0x5653D0 Offset: 0x5639D0 VA: 0x1805653D0
	public static bool BHasEquippedProfileItem(CSteamID steamID, ECommunityProfileItemType itemType) { }

	// RVA: 0x566930 Offset: 0x564F30 VA: 0x180566930
	public static string GetProfileItemPropertyString(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	// RVA: 0x5669B0 Offset: 0x564FB0 VA: 0x1805669B0
	public static uint GetProfileItemPropertyUint(CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }
}

// Namespace: Steamworks
public static class SteamGameServer // TypeDefIndex: 10188
{
	// Methods

	// RVA: 0x577DF0 Offset: 0x5763F0 VA: 0x180577DF0
	public static void SetProduct(string pszProduct) { }

	// RVA: 0x5777C0 Offset: 0x575DC0 VA: 0x1805777C0
	public static void SetGameDescription(string pszGameDescription) { }

	// RVA: 0x577CA0 Offset: 0x5762A0 VA: 0x180577CA0
	public static void SetModDir(string pszModDir) { }

	// RVA: 0x577670 Offset: 0x575C70 VA: 0x180577670
	public static void SetDedicatedServer(bool bDedicated) { }

	// RVA: 0x577390 Offset: 0x575990 VA: 0x180577390
	public static void LogOn(string pszToken) { }

	// RVA: 0x577340 Offset: 0x575940 VA: 0x180577340
	public static void LogOnAnonymous() { }

	// RVA: 0x5772F0 Offset: 0x5758F0 VA: 0x1805772F0
	public static void LogOff() { }

	// RVA: 0x576AE0 Offset: 0x5750E0 VA: 0x180576AE0
	public static bool BLoggedOn() { }

	// RVA: 0x576B30 Offset: 0x575130 VA: 0x180576B30
	public static bool BSecure() { }

	// RVA: 0x5771D0 Offset: 0x5757D0 VA: 0x1805771D0
	public static CSteamID GetSteamID() { }

	// RVA: 0x5782A0 Offset: 0x5768A0 VA: 0x1805782A0
	public static bool WasRestartRequested() { }

	// RVA: 0x577C50 Offset: 0x576250 VA: 0x180577C50
	public static void SetMaxPlayerCount(int cPlayersMax) { }

	// RVA: 0x577620 Offset: 0x575C20 VA: 0x180577620
	public static void SetBotPlayerCount(int cBotplayers) { }

	// RVA: 0x577FF0 Offset: 0x5765F0 VA: 0x180577FF0
	public static void SetServerName(string pszServerName) { }

	// RVA: 0x577B50 Offset: 0x576150 VA: 0x180577B50
	public static void SetMapName(string pszMapName) { }

	// RVA: 0x577DA0 Offset: 0x5763A0 VA: 0x180577DA0
	public static void SetPasswordProtected(bool bPasswordProtected) { }

	// RVA: 0x5780F0 Offset: 0x5766F0 VA: 0x1805780F0
	public static void SetSpectatorPort(ushort unSpectatorPort) { }

	// RVA: 0x578140 Offset: 0x576740 VA: 0x180578140
	public static void SetSpectatorServerName(string pszSpectatorServerName) { }

	// RVA: 0x576D80 Offset: 0x575380 VA: 0x180576D80
	public static void ClearAllKeyValues() { }

	// RVA: 0x5779C0 Offset: 0x575FC0 VA: 0x1805779C0
	public static void SetKeyValue(string pKey, string pValue) { }

	// RVA: 0x5778C0 Offset: 0x575EC0 VA: 0x1805778C0
	public static void SetGameTags(string pchGameTags) { }

	// RVA: 0x5776C0 Offset: 0x575CC0 VA: 0x1805776C0
	public static void SetGameData(string pchGameData) { }

	// RVA: 0x577EF0 Offset: 0x5764F0 VA: 0x180577EF0
	public static void SetRegion(string pszRegion) { }

	// RVA: 0x5775D0 Offset: 0x575BD0 VA: 0x1805775D0
	public static void SetAdvertiseServerActive(bool bActive) { }

	// RVA: 0x576F40 Offset: 0x575540 VA: 0x180576F40
	public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSnid) { }

	// RVA: 0x576CB0 Offset: 0x5752B0 VA: 0x180576CB0
	public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	// RVA: 0x576EF0 Offset: 0x5754F0 VA: 0x180576EF0
	public static void EndAuthSession(CSteamID steamID) { }

	// RVA: 0x576D30 Offset: 0x575330 VA: 0x180576D30
	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0x578240 Offset: 0x576840 VA: 0x180578240
	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

	// RVA: 0x577490 Offset: 0x575A90 VA: 0x180577490
	public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup) { }

	// RVA: 0x577000 Offset: 0x575600 VA: 0x180577000
	public static void GetGameplayStats() { }

	// RVA: 0x577140 Offset: 0x575740 VA: 0x180577140
	public static SteamAPICall_t GetServerReputation() { }

	// RVA: 0x5770E0 Offset: 0x5756E0 VA: 0x1805770E0
	public static SteamIPAddress_t GetPublicIP() { }

	// RVA: 0x577260 Offset: 0x575860 VA: 0x180577260
	public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort) { }

	// RVA: 0x577050 Offset: 0x575650 VA: 0x180577050
	public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) { }

	// RVA: 0x576A50 Offset: 0x575050 VA: 0x180576A50
	public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan) { }

	// RVA: 0x576DD0 Offset: 0x5753D0 VA: 0x180576DD0
	public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer) { }

	// RVA: 0x5774F0 Offset: 0x575AF0 VA: 0x1805774F0
	public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) { }

	// RVA: 0x576E60 Offset: 0x575460 VA: 0x180576E60
	public static CSteamID CreateUnauthenticatedUserConnection() { }

	// RVA: 0x577580 Offset: 0x575B80 VA: 0x180577580
	public static void SendUserDisconnect_DEPRECATED(CSteamID steamIDUser) { }

	// RVA: 0x576B80 Offset: 0x575180 VA: 0x180576B80
	public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore) { }
}

// Namespace: Steamworks
public static class SteamGameServerClient // TypeDefIndex: 10189
{
	// Methods

	// RVA: 0x568360 Offset: 0x566960 VA: 0x180568360
	public static HSteamPipe CreateSteamPipe() { }

	// RVA: 0x5681F0 Offset: 0x5667F0 VA: 0x1805681F0
	public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) { }

	// RVA: 0x568290 Offset: 0x566890 VA: 0x180568290
	public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) { }

	// RVA: 0x5682F0 Offset: 0x5668F0 VA: 0x1805682F0
	public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	// RVA: 0x56A460 Offset: 0x568A60 VA: 0x18056A460
	public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) { }

	// RVA: 0x56A0C0 Offset: 0x5686C0 VA: 0x18056A0C0
	public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x568A40 Offset: 0x567040 VA: 0x180568A40
	public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x56A4C0 Offset: 0x568AC0 VA: 0x18056A4C0
	public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) { }

	// RVA: 0x568680 Offset: 0x566C80 VA: 0x180568680
	public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x56A200 Offset: 0x568800 VA: 0x18056A200
	public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569300 Offset: 0x567900 VA: 0x180569300
	public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5691C0 Offset: 0x5677C0 VA: 0x1805691C0
	public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x568B80 Offset: 0x567180 VA: 0x180568B80
	public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569F80 Offset: 0x568580 VA: 0x180569F80
	public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x568900 Offset: 0x566F00 VA: 0x180568900
	public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x568400 Offset: 0x566A00 VA: 0x180568400
	public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5696C0 Offset: 0x567CC0 VA: 0x1805696C0
	public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569BC0 Offset: 0x5681C0 VA: 0x180569BC0
	public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569D00 Offset: 0x568300 VA: 0x180569D00
	public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5687C0 Offset: 0x566DC0 VA: 0x1805687C0
	public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x5683B0 Offset: 0x5669B0 VA: 0x1805683B0
	public static uint GetIPCCallCount() { }

	// RVA: 0x56A520 Offset: 0x568B20 VA: 0x18056A520
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0x568240 Offset: 0x566840 VA: 0x180568240
	public static bool BShutdownIfAllPipesClosed() { }

	// RVA: 0x568E00 Offset: 0x567400 VA: 0x180568E00
	public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x568540 Offset: 0x566B40 VA: 0x180568540
	public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569E40 Offset: 0x568440 VA: 0x180569E40
	public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569580 Offset: 0x567B80 VA: 0x180569580
	public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569440 Offset: 0x567A40 VA: 0x180569440
	public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x568CC0 Offset: 0x5672C0 VA: 0x180568CC0
	public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569080 Offset: 0x567680 VA: 0x180569080
	public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x56A320 Offset: 0x568920 VA: 0x18056A320
	public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569800 Offset: 0x567E00 VA: 0x180569800
	public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x568F40 Offset: 0x567540 VA: 0x180568F40
	public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569940 Offset: 0x567F40 VA: 0x180569940
	public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }

	// RVA: 0x569A80 Offset: 0x568080 VA: 0x180569A80
	public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) { }
}

// Namespace: Steamworks
public static class SteamGameServerHTTP // TypeDefIndex: 10190
{
	// Methods

	// RVA: 0x56A600 Offset: 0x568C00 VA: 0x18056A600
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) { }

	// RVA: 0x56B0A0 Offset: 0x5696A0 VA: 0x18056B0A0
	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) { }

	// RVA: 0x56B4E0 Offset: 0x569AE0 VA: 0x18056B4E0
	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	// RVA: 0x56B320 Offset: 0x569920 VA: 0x18056B320
	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) { }

	// RVA: 0x56B160 Offset: 0x569760 VA: 0x18056B160
	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) { }

	// RVA: 0x56AD90 Offset: 0x569390 VA: 0x18056AD90
	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0x56AD30 Offset: 0x569330 VA: 0x18056AD30
	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0x56A750 Offset: 0x568D50 VA: 0x18056A750
	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0x56AC40 Offset: 0x569240 VA: 0x18056AC40
	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0x56A940 Offset: 0x568F40 VA: 0x18056A940
	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) { }

	// RVA: 0x56AA70 Offset: 0x569070 VA: 0x18056AA70
	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize) { }

	// RVA: 0x56A8E0 Offset: 0x568EE0 VA: 0x18056A8E0
	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) { }

	// RVA: 0x56A860 Offset: 0x568E60 VA: 0x18056A860
	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0x56ABB0 Offset: 0x5691B0 VA: 0x18056ABB0
	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0x56ACE0 Offset: 0x5692E0 VA: 0x18056ACE0
	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0x56A7A0 Offset: 0x568DA0 VA: 0x18056A7A0
	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) { }

	// RVA: 0x56B540 Offset: 0x569B40 VA: 0x18056B540
	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen) { }

	// RVA: 0x56A570 Offset: 0x568B70 VA: 0x18056A570
	public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) { }

	// RVA: 0x56AC90 Offset: 0x569290 VA: 0x18056AC90
	public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0x56ADF0 Offset: 0x5693F0 VA: 0x18056ADF0
	public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) { }

	// RVA: 0x56B100 Offset: 0x569700 VA: 0x18056B100
	public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0x56B6E0 Offset: 0x569CE0 VA: 0x18056B6E0
	public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) { }

	// RVA: 0x56B680 Offset: 0x569C80 VA: 0x18056B680
	public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	// RVA: 0x56B040 Offset: 0x569640 VA: 0x18056B040
	public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) { }

	// RVA: 0x56A800 Offset: 0x568E00 VA: 0x18056A800
	public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }
}

// Namespace: Steamworks
public static class SteamGameServerInventory // TypeDefIndex: 10191
{
	// Methods

	// RVA: 0x56C500 Offset: 0x56AB00 VA: 0x18056C500
	public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x56C430 Offset: 0x56AA30 VA: 0x18056C430
	public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x56C270 Offset: 0x56A870 VA: 0x18056C270
	public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x56C550 Offset: 0x56AB50 VA: 0x18056C550
	public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x56B8E0 Offset: 0x569EE0 VA: 0x18056B8E0
	public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	// RVA: 0x56BA50 Offset: 0x56A050 VA: 0x18056BA50
	public static void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x56BBE0 Offset: 0x56A1E0 VA: 0x18056BBE0
	public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x56C000 Offset: 0x56A600 VA: 0x18056C000
	public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	// RVA: 0x56CA00 Offset: 0x56B000 VA: 0x18056CA00
	public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize) { }

	// RVA: 0x56B9C0 Offset: 0x569FC0 VA: 0x18056B9C0
	public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = False) { }

	// RVA: 0x56BB50 Offset: 0x56A150 VA: 0x18056BB50
	public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x56C5A0 Offset: 0x56ABA0 VA: 0x18056C5A0
	public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x56B800 Offset: 0x569E00 VA: 0x18056B800
	public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	// RVA: 0x56B860 Offset: 0x569E60 VA: 0x18056B860
	public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	// RVA: 0x56B940 Offset: 0x569F40 VA: 0x18056B940
	public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	// RVA: 0x56BAA0 Offset: 0x56A0A0 VA: 0x18056BAA0
	public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x56D290 Offset: 0x56B890 VA: 0x18056D290
	public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	// RVA: 0x56C9B0 Offset: 0x56AFB0 VA: 0x18056C9B0
	public static void SendItemDropHeartbeat() { }

	// RVA: 0x56D320 Offset: 0x56B920 VA: 0x18056D320
	public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

	// RVA: 0x56D1D0 Offset: 0x56B7D0 VA: 0x18056D1D0
	public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength) { }

	// RVA: 0x56C710 Offset: 0x56AD10 VA: 0x18056C710
	public static bool LoadItemDefinitions() { }

	// RVA: 0x56BD00 Offset: 0x56A300 VA: 0x18056BD00
	public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x56BDC0 Offset: 0x56A3C0 VA: 0x18056BDC0
	public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x56C890 Offset: 0x56AE90 VA: 0x18056C890
	public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) { }

	// RVA: 0x56BC30 Offset: 0x56A230 VA: 0x18056BC30
	public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x56D020 Offset: 0x56B620 VA: 0x18056D020
	public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x56C920 Offset: 0x56AF20 VA: 0x18056C920
	public static SteamAPICall_t RequestPrices() { }

	// RVA: 0x56C220 Offset: 0x56A820 VA: 0x18056C220
	public static uint GetNumItemsWithPrices() { }

	// RVA: 0x56C080 Offset: 0x56A680 VA: 0x18056C080
	public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x56BF80 Offset: 0x56A580 VA: 0x18056BF80
	public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	// RVA: 0x56D0E0 Offset: 0x56B6E0 VA: 0x18056D0E0
	public static SteamInventoryUpdateHandle_t StartUpdateProperties() { }

	// RVA: 0x56C760 Offset: 0x56AD60 VA: 0x18056C760
	public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) { }

	// RVA: 0x56CA80 Offset: 0x56B080 VA: 0x18056CA80
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) { }

	// RVA: 0x56CEE0 Offset: 0x56B4E0 VA: 0x18056CEE0
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) { }

	// RVA: 0x56CC50 Offset: 0x56B250 VA: 0x18056CC50
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) { }

	// RVA: 0x56CD90 Offset: 0x56B390 VA: 0x18056CD90
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) { }

	// RVA: 0x56D170 Offset: 0x56B770 VA: 0x18056D170
	public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x56C5F0 Offset: 0x56ABF0 VA: 0x18056C5F0
	public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken) { }
}

// Namespace: Steamworks
public static class SteamGameServerNetworking // TypeDefIndex: 10192
{
	// Methods

	// RVA: 0x5706C0 Offset: 0x56ECC0 VA: 0x1805706C0
	public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0) { }

	// RVA: 0x570420 Offset: 0x56EA20 VA: 0x180570420
	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0) { }

	// RVA: 0x570480 Offset: 0x56EA80 VA: 0x180570480
	public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0) { }

	// RVA: 0x56FD60 Offset: 0x56E360 VA: 0x18056FD60
	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0x56FE60 Offset: 0x56E460 VA: 0x18056FE60
	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0x56FE00 Offset: 0x56E400 VA: 0x18056FE00
	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) { }

	// RVA: 0x570200 Offset: 0x56E800 VA: 0x180570200
	public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	// RVA: 0x56FDB0 Offset: 0x56E3B0 VA: 0x18056FDB0
	public static bool AllowP2PPacketRelay(bool bAllow) { }

	// RVA: 0x56FF40 Offset: 0x56E540 VA: 0x18056FF40
	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	// RVA: 0x56FFE0 Offset: 0x56E5E0 VA: 0x18056FFE0
	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	// RVA: 0x56FEB0 Offset: 0x56E4B0 VA: 0x18056FEB0
	public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	// RVA: 0x5700D0 Offset: 0x56E6D0 VA: 0x1805700D0
	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0x570070 Offset: 0x56E670 VA: 0x180570070
	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0x570630 Offset: 0x56EC30 VA: 0x180570630
	public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable) { }

	// RVA: 0x570340 Offset: 0x56E940 VA: 0x180570340
	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) { }

	// RVA: 0x570510 Offset: 0x56EB10 VA: 0x180570510
	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	// RVA: 0x5703A0 Offset: 0x56E9A0 VA: 0x1805703A0
	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0x5705A0 Offset: 0x56EBA0 VA: 0x1805705A0
	public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0x5702B0 Offset: 0x56E8B0 VA: 0x1805702B0
	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	// RVA: 0x570130 Offset: 0x56E730 VA: 0x180570130
	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	// RVA: 0x570260 Offset: 0x56E860 VA: 0x180570260
	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) { }

	// RVA: 0x5701B0 Offset: 0x56E7B0 VA: 0x1805701B0
	public static int GetMaxPacketSize(SNetSocket_t hSocket) { }
}

// Namespace: Steamworks
public static class SteamGameServerNetworkingMessages // TypeDefIndex: 10193
{
	// Methods

	// RVA: 0x56D5D0 Offset: 0x56BBD0 VA: 0x18056D5D0
	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

	// RVA: 0x56D500 Offset: 0x56BB00 VA: 0x18056D500
	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x56D380 Offset: 0x56B980 VA: 0x18056D380
	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0x56D430 Offset: 0x56BA30 VA: 0x18056D430
	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0x56D3D0 Offset: 0x56B9D0 VA: 0x18056D3D0
	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	// RVA: 0x56D480 Offset: 0x56BA80 VA: 0x18056D480
	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }
}

// Namespace: Steamworks
public static class SteamGameServerNetworkingSockets // TypeDefIndex: 10194
{
	// Methods

	// RVA: 0x56DD20 Offset: 0x56C320 VA: 0x18056DD20
	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56D920 Offset: 0x56BF20 VA: 0x18056D920
	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56DE80 Offset: 0x56C480 VA: 0x18056DE80
	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56DAA0 Offset: 0x56C0A0 VA: 0x18056DAA0
	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56D660 Offset: 0x56BC60 VA: 0x18056D660
	public static EResult AcceptConnection(HSteamNetConnection hConn) { }

	// RVA: 0x56D700 Offset: 0x56BD00 VA: 0x18056D700
	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x56D840 Offset: 0x56BE40 VA: 0x18056D840
	public static bool CloseListenSocket(HSteamListenSocket hSocket) { }

	// RVA: 0x56EF20 Offset: 0x56D520 VA: 0x18056EF20
	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) { }

	// RVA: 0x56E450 Offset: 0x56CA50 VA: 0x18056E450
	public static long GetConnectionUserData(HSteamNetConnection hPeer) { }

	// RVA: 0x56EDB0 Offset: 0x56D3B0 VA: 0x18056EDB0
	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) { }

	// RVA: 0x56E2B0 Offset: 0x56C8B0 VA: 0x18056E2B0
	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) { }

	// RVA: 0x56EC20 Offset: 0x56D220 VA: 0x18056EC20
	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	// RVA: 0x56ECB0 Offset: 0x56D2B0 VA: 0x18056ECB0
	public static void SendMessages(int nMessages, IntPtr[] pMessages, long[] pOutMessageNumberOrResult) { }

	// RVA: 0x56E130 Offset: 0x56C730 VA: 0x18056E130
	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) { }

	// RVA: 0x56E8E0 Offset: 0x56CEE0 VA: 0x18056E8E0
	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x56E250 Offset: 0x56C850 VA: 0x18056E250
	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	// RVA: 0x56E3C0 Offset: 0x56C9C0 VA: 0x18056E3C0
	public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	// RVA: 0x56E4A0 Offset: 0x56CAA0 VA: 0x18056E4A0
	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) { }

	// RVA: 0x56E7D0 Offset: 0x56CDD0 VA: 0x18056E7D0
	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	// RVA: 0x56DFC0 Offset: 0x56C5C0 VA: 0x18056DFC0
	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	// RVA: 0x56D890 Offset: 0x56BE90 VA: 0x18056D890
	public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int[] pLanePriorities, ushort[] pLaneWeights) { }

	// RVA: 0x56E780 Offset: 0x56CD80 VA: 0x18056E780
	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) { }

	// RVA: 0x56E890 Offset: 0x56CE90 VA: 0x18056E890
	public static ESteamNetworkingAvailability InitAuthentication() { }

	// RVA: 0x56E180 Offset: 0x56C780 VA: 0x18056E180
	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) { }

	// RVA: 0x56DF30 Offset: 0x56C530 VA: 0x18056DF30
	public static HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0x56E060 Offset: 0x56C660 VA: 0x18056E060
	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x56EEC0 Offset: 0x56D4C0 VA: 0x18056EEC0
	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x56E9B0 Offset: 0x56CFB0 VA: 0x18056E9B0
	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0x56E0B0 Offset: 0x56C6B0 VA: 0x18056E0B0
	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0x56DB60 Offset: 0x56C160 VA: 0x18056DB60
	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56E730 Offset: 0x56CD30 VA: 0x18056E730
	public static ushort GetHostedDedicatedServerPort() { }

	// RVA: 0x56E6E0 Offset: 0x56CCE0 VA: 0x18056E6E0
	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() { }

	// RVA: 0x56E690 Offset: 0x56CC90 VA: 0x18056E690
	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) { }

	// RVA: 0x56DC70 Offset: 0x56C270 VA: 0x18056DC70
	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56E610 Offset: 0x56CC10 VA: 0x18056E610
	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	// RVA: 0x56D9D0 Offset: 0x56BFD0 VA: 0x18056D9D0
	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56EA80 Offset: 0x56D080 VA: 0x18056EA80
	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	// RVA: 0x56E1D0 Offset: 0x56C7D0 VA: 0x18056E1D0
	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0x56ED30 Offset: 0x56D330 VA: 0x18056ED30
	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0x56EB80 Offset: 0x56D180 VA: 0x18056EB80
	public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity) { }

	// RVA: 0x56EBD0 Offset: 0x56D1D0 VA: 0x18056EBD0
	public static void RunCallbacks() { }

	// RVA: 0x56D6B0 Offset: 0x56BCB0 VA: 0x18056D6B0
	public static bool BeginAsyncRequestFakeIP(int nNumPorts) { }

	// RVA: 0x56E5B0 Offset: 0x56CBB0 VA: 0x18056E5B0
	public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x56DDD0 Offset: 0x56C3D0 VA: 0x18056DDD0
	public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x56E830 Offset: 0x56CE30 VA: 0x18056E830
	public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	// RVA: 0x56DC20 Offset: 0x56C220 VA: 0x18056DC20
	public static IntPtr CreateFakeUDPPort(int idxFakeServerPort) { }
}

// Namespace: Steamworks
public static class SteamGameServerNetworkingUtils // TypeDefIndex: 10195
{
	// Methods

	// RVA: 0x56EF80 Offset: 0x56D580 VA: 0x18056EF80
	public static IntPtr AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0x56F5E0 Offset: 0x56DBE0 VA: 0x18056F5E0
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x56F590 Offset: 0x56DB90 VA: 0x18056F590
	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) { }

	// RVA: 0x56F380 Offset: 0x56D980 VA: 0x18056F380
	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) { }

	// RVA: 0x56F110 Offset: 0x56D710 VA: 0x18056F110
	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	// RVA: 0x56F170 Offset: 0x56D770 VA: 0x18056F170
	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) { }

	// RVA: 0x56F030 Offset: 0x56D630 VA: 0x18056F030
	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) { }

	// RVA: 0x56F6E0 Offset: 0x56DCE0 VA: 0x18056F6E0
	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) { }

	// RVA: 0x56EFD0 Offset: 0x56D5D0 VA: 0x18056EFD0
	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) { }

	// RVA: 0x56F4D0 Offset: 0x56DAD0 VA: 0x18056F4D0
	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	// RVA: 0x56F2E0 Offset: 0x56D8E0 VA: 0x18056F2E0
	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) { }

	// RVA: 0x56F420 Offset: 0x56DA20 VA: 0x18056F420
	public static int GetPOPCount() { }

	// RVA: 0x56F470 Offset: 0x56DA70 VA: 0x18056F470
	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) { }

	// RVA: 0x56F3D0 Offset: 0x56D9D0 VA: 0x18056F3D0
	public static SteamNetworkingMicroseconds GetLocalTimestamp() { }

	// RVA: 0x56F890 Offset: 0x56DE90 VA: 0x18056F890
	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	// RVA: 0x56F630 Offset: 0x56DC30 VA: 0x18056F630
	public static bool IsFakeIPv4(uint nIPv4) { }

	// RVA: 0x56F330 Offset: 0x56D930 VA: 0x18056F330
	public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) { }

	// RVA: 0x56F530 Offset: 0x56DB30 VA: 0x18056F530
	public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	// RVA: 0x56F800 Offset: 0x56DE00 VA: 0x18056F800
	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	// RVA: 0x56F240 Offset: 0x56D840 VA: 0x18056F240
	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	// RVA: 0x56F1C0 Offset: 0x56D7C0 VA: 0x18056F1C0
	public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	// RVA: 0x56F680 Offset: 0x56DC80 VA: 0x18056F680
	public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	// RVA: 0x56FA60 Offset: 0x56E060 VA: 0x18056FA60
	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x56F940 Offset: 0x56DF40 VA: 0x18056F940
	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) { }

	// RVA: 0x56F8F0 Offset: 0x56DEF0 VA: 0x18056F8F0
	public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) { }

	// RVA: 0x56FC80 Offset: 0x56E280 VA: 0x18056FC80
	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) { }

	// RVA: 0x56FB60 Offset: 0x56E160 VA: 0x18056FB60
	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) { }
}

// Namespace: Steamworks
public static class SteamGameServerStats // TypeDefIndex: 10196
{
	// Methods

	// RVA: 0x570C00 Offset: 0x56F200 VA: 0x180570C00
	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	// RVA: 0x5709A0 Offset: 0x56EFA0 VA: 0x1805709A0
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	// RVA: 0x570AD0 Offset: 0x56F0D0 VA: 0x180570AD0
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	// RVA: 0x570870 Offset: 0x56EE70 VA: 0x180570870
	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	// RVA: 0x570DB0 Offset: 0x56F3B0 VA: 0x180570DB0
	public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData) { }

	// RVA: 0x570EE0 Offset: 0x56F4E0 VA: 0x180570EE0
	public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData) { }

	// RVA: 0x5710A0 Offset: 0x56F6A0 VA: 0x1805710A0
	public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength) { }

	// RVA: 0x570C90 Offset: 0x56F290 VA: 0x180570C90
	public static bool SetUserAchievement(CSteamID steamIDUser, string pchName) { }

	// RVA: 0x570750 Offset: 0x56ED50 VA: 0x180570750
	public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName) { }

	// RVA: 0x571010 Offset: 0x56F610 VA: 0x180571010
	public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser) { }
}

// Namespace: Steamworks
public static class SteamGameServerUGC // TypeDefIndex: 10197
{
	// Methods

	// RVA: 0x5721E0 Offset: 0x5707E0 VA: 0x1805721E0
	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0x571EE0 Offset: 0x5704E0 VA: 0x180571EE0
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0x571FB0 Offset: 0x5705B0 VA: 0x180571FB0
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor) { }

	// RVA: 0x572140 Offset: 0x570740 VA: 0x180572140
	public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x573CD0 Offset: 0x5722D0 VA: 0x180573CD0
	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0x573100 Offset: 0x571700 VA: 0x180573100
	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	// RVA: 0x572F90 Offset: 0x571590 VA: 0x180572F90
	public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x573340 Offset: 0x571940 VA: 0x180573340
	public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0x573210 Offset: 0x571810 VA: 0x180573210
	public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0x572FF0 Offset: 0x5715F0 VA: 0x180572FF0
	public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) { }

	// RVA: 0x572DC0 Offset: 0x5713C0 VA: 0x180572DC0
	public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) { }

	// RVA: 0x572900 Offset: 0x570F00 VA: 0x180572900
	public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0x573180 Offset: 0x571780 VA: 0x180573180
	public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	// RVA: 0x572ED0 Offset: 0x5714D0 VA: 0x180572ED0
	public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x572760 Offset: 0x570D60 VA: 0x180572760
	public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	// RVA: 0x572F30 Offset: 0x571530 VA: 0x180572F30
	public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x572C30 Offset: 0x571230 VA: 0x180572C30
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) { }

	// RVA: 0x572A70 Offset: 0x571070 VA: 0x180572A70
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) { }

	// RVA: 0x572700 Offset: 0x570D00 VA: 0x180572700
	public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x5734D0 Offset: 0x571AD0 VA: 0x1805734D0
	public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize) { }

	// RVA: 0x572990 Offset: 0x570F90 VA: 0x180572990
	public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	// RVA: 0x5737D0 Offset: 0x571DD0 VA: 0x1805737D0
	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0x571C00 Offset: 0x570200 VA: 0x180571C00
	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0x571B40 Offset: 0x570140 VA: 0x180571B40
	public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups) { }

	// RVA: 0x571390 Offset: 0x56F990 VA: 0x180571390
	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0x574D30 Offset: 0x573330 VA: 0x180574D30
	public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0x574C10 Offset: 0x573210 VA: 0x180574C10
	public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0x574C70 Offset: 0x573270 VA: 0x180574C70
	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0x574CD0 Offset: 0x5732D0 VA: 0x180574CD0
	public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0x574BB0 Offset: 0x5731B0 VA: 0x180574BB0
	public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0x574B50 Offset: 0x573150 VA: 0x180574B50
	public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0x574DF0 Offset: 0x5733F0 VA: 0x180574DF0
	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0x574D90 Offset: 0x573390 VA: 0x180574D90
	public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0x5747A0 Offset: 0x572DA0 VA: 0x1805747A0
	public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) { }

	// RVA: 0x573DC0 Offset: 0x5723C0 VA: 0x180573DC0
	public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0x573D60 Offset: 0x572360 VA: 0x180573D60
	public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery) { }

	// RVA: 0x573E80 Offset: 0x572480 VA: 0x180573E80
	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) { }

	// RVA: 0x5748C0 Offset: 0x572EC0 VA: 0x1805748C0
	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0x574E50 Offset: 0x573450 VA: 0x180574E50
	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0x574920 Offset: 0x572F20 VA: 0x180574920
	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0x574F70 Offset: 0x573570 VA: 0x180574F70
	public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0x574FF0 Offset: 0x5735F0 VA: 0x180574FF0
	public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0x571970 Offset: 0x56FF70 VA: 0x180571970
	public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0x573C30 Offset: 0x572230 VA: 0x180573C30
	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	// RVA: 0x571E40 Offset: 0x570440 VA: 0x180571E40
	public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	// RVA: 0x575160 Offset: 0x573760 VA: 0x180575160
	public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x574500 Offset: 0x572B00 VA: 0x180574500
	public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0x5740C0 Offset: 0x5726C0 VA: 0x1805740C0
	public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0x574620 Offset: 0x572C20 VA: 0x180574620
	public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0x5741E0 Offset: 0x5727E0 VA: 0x1805741E0
	public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0x574740 Offset: 0x572D40 VA: 0x180574740
	public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0x574420 Offset: 0x572A20 VA: 0x180574420
	public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags, bool bAllowAdminTags = False) { }

	// RVA: 0x573FA0 Offset: 0x5725A0 VA: 0x180573FA0
	public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0x573E20 Offset: 0x572420 VA: 0x180573E20
	public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	// RVA: 0x573820 Offset: 0x571E20 VA: 0x180573820
	public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) { }

	// RVA: 0x573AB0 Offset: 0x5720B0 VA: 0x180573AB0
	public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0x5714B0 Offset: 0x56FAB0 VA: 0x1805714B0
	public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0x571680 Offset: 0x56FC80 VA: 0x180571680
	public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) { }

	// RVA: 0x5717B0 Offset: 0x56FDB0 VA: 0x1805717B0
	public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) { }

	// RVA: 0x575690 Offset: 0x573C90 VA: 0x180575690
	public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) { }

	// RVA: 0x5757C0 Offset: 0x573DC0 VA: 0x1805757C0
	public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) { }

	// RVA: 0x573BD0 Offset: 0x5721D0 VA: 0x180573BD0
	public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) { }

	// RVA: 0x571290 Offset: 0x56F890 VA: 0x180571290
	public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0x573910 Offset: 0x571F10 VA: 0x180573910
	public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0x574980 Offset: 0x572F80 VA: 0x180574980
	public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax) { }

	// RVA: 0x5753D0 Offset: 0x5739D0 VA: 0x1805753D0
	public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0x572630 Offset: 0x570C30 VA: 0x180572630
	public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	// RVA: 0x575070 Offset: 0x573670 VA: 0x180575070
	public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	// RVA: 0x5736B0 Offset: 0x571CB0 VA: 0x1805736B0
	public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5718D0 Offset: 0x56FED0 VA: 0x1805718D0
	public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x573A10 Offset: 0x572010 VA: 0x180573A10
	public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x575520 Offset: 0x573B20 VA: 0x180575520
	public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x575600 Offset: 0x573C00 VA: 0x180575600
	public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5726B0 Offset: 0x570CB0 VA: 0x1805726B0
	public static uint GetNumSubscribedItems() { }

	// RVA: 0x573470 Offset: 0x571A70 VA: 0x180573470
	public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0x5725E0 Offset: 0x570BE0 VA: 0x1805725E0
	public static uint GetItemState(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5724C0 Offset: 0x570AC0 VA: 0x1805724C0
	public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	// RVA: 0x572440 Offset: 0x570A40 VA: 0x180572440
	public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0x572350 Offset: 0x570950 VA: 0x180572350
	public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	// RVA: 0x571D20 Offset: 0x570320 VA: 0x180571D20
	public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) { }

	// RVA: 0x5755B0 Offset: 0x573BB0 VA: 0x1805755B0
	public static void SuspendDownloads(bool bSuspend) { }

	// RVA: 0x575200 Offset: 0x573800 VA: 0x180575200
	public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x575330 Offset: 0x573930 VA: 0x180575330
	public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x5752A0 Offset: 0x5738A0 VA: 0x1805752A0
	public static SteamAPICall_t StopPlaytimeTrackingForAllItems() { }

	// RVA: 0x5712F0 Offset: 0x56F8F0 VA: 0x1805712F0
	public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0x573970 Offset: 0x571F70 VA: 0x180573970
	public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0x5711F0 Offset: 0x56F7F0 VA: 0x1805711F0
	public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0x573870 Offset: 0x571E70 VA: 0x180573870
	public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0x5723B0 Offset: 0x5709B0 VA: 0x1805723B0
	public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5722C0 Offset: 0x5708C0 VA: 0x1805722C0
	public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x575110 Offset: 0x573710 VA: 0x180575110
	public static bool ShowWorkshopEULA() { }

	// RVA: 0x573740 Offset: 0x571D40 VA: 0x180573740
	public static SteamAPICall_t GetWorkshopEULAStatus() { }

	// RVA: 0x573650 Offset: 0x571C50 VA: 0x180573650
	public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }
}

// Namespace: Steamworks
public static class SteamGameServerUtils // TypeDefIndex: 10198
{
	// Methods

	// RVA: 0x576220 Offset: 0x574820 VA: 0x180576220
	public static uint GetSecondsSinceAppActive() { }

	// RVA: 0x576270 Offset: 0x574870 VA: 0x180576270
	public static uint GetSecondsSinceComputerActive() { }

	// RVA: 0x575E50 Offset: 0x574450 VA: 0x180575E50
	public static EUniverse GetConnectedUniverse() { }

	// RVA: 0x5762C0 Offset: 0x5748C0 VA: 0x1805762C0
	public static uint GetServerRealTime() { }

	// RVA: 0x576080 Offset: 0x574680 VA: 0x180576080
	public static string GetIPCountry() { }

	// RVA: 0x5761A0 Offset: 0x5747A0 VA: 0x1805761A0
	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	// RVA: 0x576120 Offset: 0x574720 VA: 0x180576120
	public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0x575EA0 Offset: 0x5744A0 VA: 0x180575EA0
	public static byte GetCurrentBatteryPower() { }

	// RVA: 0x575DC0 Offset: 0x5743C0 VA: 0x180575DC0
	public static AppId_t GetAppID() { }

	// RVA: 0x5766A0 Offset: 0x574CA0 VA: 0x1805766A0
	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) { }

	// RVA: 0x5763B0 Offset: 0x5749B0 VA: 0x1805763B0
	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	// RVA: 0x575CE0 Offset: 0x5742E0 VA: 0x180575CE0
	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) { }

	// RVA: 0x575D30 Offset: 0x574330 VA: 0x180575D30
	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	// RVA: 0x576030 Offset: 0x574630 VA: 0x180576030
	public static uint GetIPCCallCount() { }

	// RVA: 0x576740 Offset: 0x574D40 VA: 0x180576740
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0x576410 Offset: 0x574A10 VA: 0x180576410
	public static bool IsOverlayEnabled() { }

	// RVA: 0x5758F0 Offset: 0x573EF0 VA: 0x1805758F0
	public static bool BOverlayNeedsPresent() { }

	// RVA: 0x575940 Offset: 0x573F40 VA: 0x180575940
	public static SteamAPICall_t CheckFileSignature(string szFileName) { }

	// RVA: 0x576820 Offset: 0x574E20 VA: 0x180576820
	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) { }

	// RVA: 0x575FE0 Offset: 0x5745E0 VA: 0x180575FE0
	public static uint GetEnteredGamepadTextLength() { }

	// RVA: 0x575EF0 Offset: 0x5744F0 VA: 0x180575EF0
	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) { }

	// RVA: 0x576310 Offset: 0x574910 VA: 0x180576310
	public static string GetSteamUILanguage() { }

	// RVA: 0x576500 Offset: 0x574B00 VA: 0x180576500
	public static bool IsSteamRunningInVR() { }

	// RVA: 0x576640 Offset: 0x574C40 VA: 0x180576640
	public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) { }

	// RVA: 0x5764B0 Offset: 0x574AB0 VA: 0x1805764B0
	public static bool IsSteamInBigPictureMode() { }

	// RVA: 0x576A00 Offset: 0x575000 VA: 0x180576A00
	public static void StartVRDashboard() { }

	// RVA: 0x5765A0 Offset: 0x574BA0 VA: 0x1805765A0
	public static bool IsVRHeadsetStreamingEnabled() { }

	// RVA: 0x5766F0 Offset: 0x574CF0 VA: 0x1805766F0
	public static void SetVRHeadsetStreamingEnabled(bool bEnabled) { }

	// RVA: 0x576460 Offset: 0x574A60 VA: 0x180576460
	public static bool IsSteamChinaLauncher() { }

	// RVA: 0x576360 Offset: 0x574960 VA: 0x180576360
	public static bool InitFilterText(uint unFilterOptions = 0) { }

	// RVA: 0x575B20 Offset: 0x574120 VA: 0x180575B20
	public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0x5760D0 Offset: 0x5746D0 VA: 0x1805760D0
	public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) { }

	// RVA: 0x576550 Offset: 0x574B50 VA: 0x180576550
	public static bool IsSteamRunningOnSteamDeck() { }

	// RVA: 0x576790 Offset: 0x574D90 VA: 0x180576790
	public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	// RVA: 0x5765F0 Offset: 0x574BF0 VA: 0x1805765F0
	public static void SetGameLauncherMode(bool bLauncherMode) { }

	// RVA: 0x575A80 Offset: 0x574080 VA: 0x180575A80
	public static bool DismissFloatingGamepadTextInput() { }

	// RVA: 0x575AD0 Offset: 0x5740D0 VA: 0x180575AD0
	public static bool DismissGamepadTextInput() { }
}

// Namespace: Steamworks
public static class SteamHTMLSurface // TypeDefIndex: 10199
{
	// Methods

	// RVA: 0x578AF0 Offset: 0x5770F0 VA: 0x180578AF0
	public static bool Init() { }

	// RVA: 0x579820 Offset: 0x577E20 VA: 0x180579820
	public static bool Shutdown() { }

	// RVA: 0x578560 Offset: 0x576B60 VA: 0x180578560
	public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS) { }

	// RVA: 0x5791E0 Offset: 0x5777E0 VA: 0x1805791E0
	public static void RemoveBrowser(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x578D30 Offset: 0x577330 VA: 0x180578D30
	public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData) { }

	// RVA: 0x579740 Offset: 0x577D40 VA: 0x180579740
	public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) { }

	// RVA: 0x5798C0 Offset: 0x577EC0 VA: 0x1805798C0
	public static void StopLoad(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x579190 Offset: 0x577790 VA: 0x180579190
	public static void Reload(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x578A50 Offset: 0x577050 VA: 0x180578A50
	public static void GoBack(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x578AA0 Offset: 0x5770A0 VA: 0x180578AA0
	public static void GoForward(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5782F0 Offset: 0x5768F0 VA: 0x1805782F0
	public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue) { }

	// RVA: 0x578730 Offset: 0x576D30 VA: 0x180578730
	public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript) { }

	// RVA: 0x579030 Offset: 0x577630 VA: 0x180579030
	public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0x578F50 Offset: 0x577550 VA: 0x180578F50
	public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0x578EF0 Offset: 0x5774F0 VA: 0x180578EF0
	public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0x578FB0 Offset: 0x5775B0 VA: 0x180578FB0
	public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) { }

	// RVA: 0x579090 Offset: 0x577690 VA: 0x180579090
	public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) { }

	// RVA: 0x578C20 Offset: 0x577220 VA: 0x180578C20
	public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = False) { }

	// RVA: 0x578CB0 Offset: 0x5772B0 VA: 0x180578CB0
	public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	// RVA: 0x578BA0 Offset: 0x5771A0 VA: 0x180578BA0
	public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	// RVA: 0x5795F0 Offset: 0x577BF0 VA: 0x1805795F0
	public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	// RVA: 0x5797C0 Offset: 0x577DC0 VA: 0x1805797C0
	public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	// RVA: 0x579650 Offset: 0x577C50 VA: 0x180579650
	public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) { }

	// RVA: 0x579910 Offset: 0x577F10 VA: 0x180579910
	public static void ViewSource(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x578510 Offset: 0x576B10 VA: 0x180578510
	public static void CopyToClipboard(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x579140 Offset: 0x577740 VA: 0x180579140
	public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5788A0 Offset: 0x576EA0 VA: 0x1805788A0
	public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse) { }

	// RVA: 0x579870 Offset: 0x577E70 VA: 0x180579870
	public static void StopFind(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5789D0 Offset: 0x576FD0 VA: 0x1805789D0
	public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) { }

	// RVA: 0x579290 Offset: 0x577890 VA: 0x180579290
	public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0, bool bSecure = False, bool bHTTPOnly = False) { }

	// RVA: 0x5796B0 Offset: 0x577CB0 VA: 0x1805796B0
	public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) { }

	// RVA: 0x579230 Offset: 0x577830 VA: 0x180579230
	public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) { }

	// RVA: 0x579590 Offset: 0x577B90 VA: 0x180579590
	public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) { }

	// RVA: 0x5790F0 Offset: 0x5776F0 VA: 0x1805790F0
	public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5784B0 Offset: 0x576AB0 VA: 0x1805784B0
	public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) { }

	// RVA: 0x578B40 Offset: 0x577140 VA: 0x180578B40
	public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) { }

	// RVA: 0x578840 Offset: 0x576E40 VA: 0x180578840
	public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) { }
}

// Namespace: Steamworks
public static class SteamHTTP // TypeDefIndex: 10200
{
	// Methods

	// RVA: 0x5799F0 Offset: 0x577FF0 VA: 0x1805799F0
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) { }

	// RVA: 0x57A490 Offset: 0x578A90 VA: 0x18057A490
	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) { }

	// RVA: 0x57A8D0 Offset: 0x578ED0 VA: 0x18057A8D0
	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	// RVA: 0x57A710 Offset: 0x578D10 VA: 0x18057A710
	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) { }

	// RVA: 0x57A550 Offset: 0x578B50 VA: 0x18057A550
	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) { }

	// RVA: 0x57A180 Offset: 0x578780 VA: 0x18057A180
	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0x57A120 Offset: 0x578720 VA: 0x18057A120
	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0x579B40 Offset: 0x578140 VA: 0x180579B40
	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0x57A030 Offset: 0x578630 VA: 0x18057A030
	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0x579D30 Offset: 0x578330 VA: 0x180579D30
	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) { }

	// RVA: 0x579E60 Offset: 0x578460 VA: 0x180579E60
	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize) { }

	// RVA: 0x579CD0 Offset: 0x5782D0 VA: 0x180579CD0
	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) { }

	// RVA: 0x579C50 Offset: 0x578250 VA: 0x180579C50
	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0x579FA0 Offset: 0x5785A0 VA: 0x180579FA0
	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0x57A0D0 Offset: 0x5786D0 VA: 0x18057A0D0
	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0x579B90 Offset: 0x578190 VA: 0x180579B90
	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) { }

	// RVA: 0x57A930 Offset: 0x578F30 VA: 0x18057A930
	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen) { }

	// RVA: 0x579960 Offset: 0x577F60 VA: 0x180579960
	public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) { }

	// RVA: 0x57A080 Offset: 0x578680 VA: 0x18057A080
	public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0x57A1E0 Offset: 0x5787E0 VA: 0x18057A1E0
	public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) { }

	// RVA: 0x57A4F0 Offset: 0x578AF0 VA: 0x18057A4F0
	public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0x57AAD0 Offset: 0x5790D0 VA: 0x18057AAD0
	public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) { }

	// RVA: 0x57AA70 Offset: 0x579070 VA: 0x18057AA70
	public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	// RVA: 0x57A430 Offset: 0x578A30 VA: 0x18057A430
	public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) { }

	// RVA: 0x579BF0 Offset: 0x5781F0 VA: 0x180579BF0
	public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }
}

// Namespace: Steamworks
public static class SteamInput // TypeDefIndex: 10201
{
	// Methods

	// RVA: 0x57BD20 Offset: 0x57A320 VA: 0x18057BD20
	public static bool Init(bool bExplicitlyCallRunFrame) { }

	// RVA: 0x57C170 Offset: 0x57A770 VA: 0x18057C170
	public static bool Shutdown() { }

	// RVA: 0x57BF60 Offset: 0x57A560 VA: 0x18057BF60
	public static bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath) { }

	// RVA: 0x57BEA0 Offset: 0x57A4A0 VA: 0x18057BEA0
	public static void RunFrame(bool bReservedValue = True) { }

	// RVA: 0x57AD00 Offset: 0x579300 VA: 0x18057AD00
	public static bool BWaitForData(bool bWaitForever, uint unTimeout) { }

	// RVA: 0x57ACB0 Offset: 0x5792B0 VA: 0x18057ACB0
	public static bool BNewDataAvailable() { }

	// RVA: 0x57B3B0 Offset: 0x5799B0 VA: 0x18057B3B0
	public static int GetConnectedControllers(InputHandle_t[] handlesOut) { }

	// RVA: 0x57AE80 Offset: 0x579480 VA: 0x18057AE80
	public static void EnableDeviceCallbacks() { }

	// RVA: 0x57AE20 Offset: 0x579420 VA: 0x18057AE20
	public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback) { }

	// RVA: 0x57AF30 Offset: 0x579530 VA: 0x18057AF30
	public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName) { }

	// RVA: 0x57AC50 Offset: 0x579250 VA: 0x18057AC50
	public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) { }

	// RVA: 0x57B4C0 Offset: 0x579AC0 VA: 0x18057B4C0
	public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle) { }

	// RVA: 0x57ABF0 Offset: 0x5791F0 VA: 0x18057ABF0
	public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	// RVA: 0x57AD60 Offset: 0x579360 VA: 0x18057AD60
	public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	// RVA: 0x57ADC0 Offset: 0x5793C0 VA: 0x18057ADC0
	public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle) { }

	// RVA: 0x57B050 Offset: 0x579650 VA: 0x18057B050
	public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut) { }

	// RVA: 0x57B600 Offset: 0x579C00 VA: 0x18057B600
	public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName) { }

	// RVA: 0x57B5A0 Offset: 0x579BA0 VA: 0x18057B5A0
	public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) { }

	// RVA: 0x57B720 Offset: 0x579D20 VA: 0x18057B720
	public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut) { }

	// RVA: 0x57BC60 Offset: 0x57A260 VA: 0x18057BC60
	public static string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle) { }

	// RVA: 0x57B1B0 Offset: 0x5797B0 VA: 0x18057B1B0
	public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName) { }

	// RVA: 0x57B110 Offset: 0x579710 VA: 0x18057B110
	public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) { }

	// RVA: 0x57B2D0 Offset: 0x5798D0 VA: 0x18057B2D0
	public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut) { }

	// RVA: 0x57B920 Offset: 0x579F20 VA: 0x18057B920
	public static string GetGlyphPNGForActionOrigin(EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags) { }

	// RVA: 0x57B9A0 Offset: 0x579FA0 VA: 0x18057B9A0
	public static string GetGlyphSVGForActionOrigin(EInputActionOrigin eOrigin, uint unFlags) { }

	// RVA: 0x57B860 Offset: 0x579E60 VA: 0x18057B860
	public static string GetGlyphForActionOrigin_Legacy(EInputActionOrigin eOrigin) { }

	// RVA: 0x57BBA0 Offset: 0x57A1A0 VA: 0x18057BBA0
	public static string GetStringForActionOrigin(EInputActionOrigin eOrigin) { }

	// RVA: 0x57BC00 Offset: 0x57A200 VA: 0x18057BC00
	public static string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle) { }

	// RVA: 0x57C1C0 Offset: 0x57A7C0 VA: 0x18057C1C0
	public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) { }

	// RVA: 0x57BA70 Offset: 0x57A070 VA: 0x18057BA70
	public static InputMotionData_t GetMotionData(InputHandle_t inputHandle) { }

	// RVA: 0x57C3C0 Offset: 0x57A9C0 VA: 0x18057C3C0
	public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) { }

	// RVA: 0x57C320 Offset: 0x57A920 VA: 0x18057C320
	public static void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) { }

	// RVA: 0x57C280 Offset: 0x57A880 VA: 0x18057C280
	public static void TriggerSimpleHapticEvent(InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) { }

	// RVA: 0x57C070 Offset: 0x57A670 VA: 0x18057C070
	public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) { }

	// RVA: 0x57BD80 Offset: 0x57A380 VA: 0x18057BD80
	public static void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) { }

	// RVA: 0x57BE00 Offset: 0x57A400 VA: 0x18057BE00
	public static void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) { }

	// RVA: 0x57C110 Offset: 0x57A710 VA: 0x18057C110
	public static bool ShowBindingPanel(InputHandle_t inputHandle) { }

	// RVA: 0x57BA10 Offset: 0x57A010 VA: 0x18057BA10
	public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle) { }

	// RVA: 0x57B460 Offset: 0x579A60 VA: 0x18057B460
	public static InputHandle_t GetControllerForGamepadIndex(int nIndex) { }

	// RVA: 0x57B800 Offset: 0x579E00 VA: 0x18057B800
	public static int GetGamepadIndexForController(InputHandle_t ulinputHandle) { }

	// RVA: 0x57BCC0 Offset: 0x57A2C0 VA: 0x18057BCC0
	public static string GetStringForXboxOrigin(EXboxOrigin eOrigin) { }

	// RVA: 0x57B8C0 Offset: 0x579EC0 VA: 0x18057B8C0
	public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin) { }

	// RVA: 0x57AED0 Offset: 0x5794D0 VA: 0x18057AED0
	public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin) { }

	// RVA: 0x57C220 Offset: 0x57A820 VA: 0x18057C220
	public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) { }

	// RVA: 0x57B520 Offset: 0x579B20 VA: 0x18057B520
	public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor) { }

	// RVA: 0x57BAF0 Offset: 0x57A0F0 VA: 0x18057BAF0
	public static uint GetRemotePlaySessionID(InputHandle_t inputHandle) { }

	// RVA: 0x57BB50 Offset: 0x57A150 VA: 0x18057BB50
	public static ushort GetSessionInputConfigurationSettings() { }

	// RVA: 0x57BF00 Offset: 0x57A500 VA: 0x18057BF00
	public static void SetDualSenseTriggerEffect(InputHandle_t inputHandle, IntPtr pParam) { }
}

// Namespace: Steamworks
public static class SteamInventory // TypeDefIndex: 10202
{
	// Methods

	// RVA: 0x57D160 Offset: 0x57B760 VA: 0x18057D160
	public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x57D090 Offset: 0x57B690 VA: 0x18057D090
	public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x57CEC0 Offset: 0x57B4C0 VA: 0x18057CEC0
	public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x57D1B0 Offset: 0x57B7B0 VA: 0x18057D1B0
	public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x57C520 Offset: 0x57AB20 VA: 0x18057C520
	public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	// RVA: 0x57C690 Offset: 0x57AC90 VA: 0x18057C690
	public static void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x57C820 Offset: 0x57AE20 VA: 0x18057C820
	public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x57CC50 Offset: 0x57B250 VA: 0x18057CC50
	public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	// RVA: 0x57D680 Offset: 0x57BC80 VA: 0x18057D680
	public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize) { }

	// RVA: 0x57C600 Offset: 0x57AC00 VA: 0x18057C600
	public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = False) { }

	// RVA: 0x57C790 Offset: 0x57AD90 VA: 0x18057C790
	public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x57D200 Offset: 0x57B800 VA: 0x18057D200
	public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x57C440 Offset: 0x57AA40 VA: 0x18057C440
	public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	// RVA: 0x57C4A0 Offset: 0x57AAA0 VA: 0x18057C4A0
	public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	// RVA: 0x57C580 Offset: 0x57AB80 VA: 0x18057C580
	public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	// RVA: 0x57C6E0 Offset: 0x57ACE0 VA: 0x18057C6E0
	public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x57DF20 Offset: 0x57C520 VA: 0x18057DF20
	public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	// RVA: 0x57D630 Offset: 0x57BC30 VA: 0x18057D630
	public static void SendItemDropHeartbeat() { }

	// RVA: 0x57DFB0 Offset: 0x57C5B0 VA: 0x18057DFB0
	public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

	// RVA: 0x57DE60 Offset: 0x57C460 VA: 0x18057DE60
	public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength) { }

	// RVA: 0x57D380 Offset: 0x57B980 VA: 0x18057D380
	public static bool LoadItemDefinitions() { }

	// RVA: 0x57C950 Offset: 0x57AF50 VA: 0x18057C950
	public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x57CA10 Offset: 0x57B010 VA: 0x18057CA10
	public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x57D510 Offset: 0x57BB10 VA: 0x18057D510
	public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) { }

	// RVA: 0x57C880 Offset: 0x57AE80 VA: 0x18057C880
	public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x57DCB0 Offset: 0x57C2B0 VA: 0x18057DCB0
	public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x57D5A0 Offset: 0x57BBA0 VA: 0x18057D5A0
	public static SteamAPICall_t RequestPrices() { }

	// RVA: 0x57CE70 Offset: 0x57B470 VA: 0x18057CE70
	public static uint GetNumItemsWithPrices() { }

	// RVA: 0x57CCD0 Offset: 0x57B2D0 VA: 0x18057CCD0
	public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x57CBD0 Offset: 0x57B1D0 VA: 0x18057CBD0
	public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	// RVA: 0x57DD70 Offset: 0x57C370 VA: 0x18057DD70
	public static SteamInventoryUpdateHandle_t StartUpdateProperties() { }

	// RVA: 0x57D3D0 Offset: 0x57B9D0 VA: 0x18057D3D0
	public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) { }

	// RVA: 0x57D9A0 Offset: 0x57BFA0 VA: 0x18057D9A0
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) { }

	// RVA: 0x57D700 Offset: 0x57BD00 VA: 0x18057D700
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) { }

	// RVA: 0x57DB70 Offset: 0x57C170 VA: 0x18057DB70
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) { }

	// RVA: 0x57D840 Offset: 0x57BE40 VA: 0x18057D840
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) { }

	// RVA: 0x57DE00 Offset: 0x57C400 VA: 0x18057DE00
	public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x57D260 Offset: 0x57B860 VA: 0x18057D260
	public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken) { }
}

// Namespace: Steamworks
public static class SteamMatchmaking // TypeDefIndex: 10203
{
	// Methods

	// RVA: 0x57F380 Offset: 0x57D980 VA: 0x18057F380
	public static int GetFavoriteGameCount() { }

	// RVA: 0x57F3D0 Offset: 0x57D9D0 VA: 0x18057F3D0
	public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x57EBF0 Offset: 0x57D1F0 VA: 0x18057EBF0
	public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x57FDA0 Offset: 0x57E3A0 VA: 0x18057FDA0
	public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x57FE80 Offset: 0x57E480 VA: 0x18057FE80
	public static SteamAPICall_t RequestLobbyList() { }

	// RVA: 0x57F000 Offset: 0x57D600 VA: 0x18057F000
	public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType) { }

	// RVA: 0x57EE90 Offset: 0x57D490 VA: 0x18057EE90
	public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) { }

	// RVA: 0x57ED80 Offset: 0x57D380 VA: 0x18057ED80
	public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo) { }

	// RVA: 0x57ED30 Offset: 0x57D330 VA: 0x18057ED30
	public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) { }

	// RVA: 0x57ECE0 Offset: 0x57D2E0 VA: 0x18057ECE0
	public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter) { }

	// RVA: 0x57EFB0 Offset: 0x57D5B0 VA: 0x18057EFB0
	public static void AddRequestLobbyListResultCountFilter(int cMaxResults) { }

	// RVA: 0x57EC90 Offset: 0x57D290 VA: 0x18057EC90
	public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby) { }

	// RVA: 0x57F480 Offset: 0x57DA80 VA: 0x18057F480
	public static CSteamID GetLobbyByIndex(int iLobby) { }

	// RVA: 0x57F1C0 Offset: 0x57D7C0 VA: 0x18057F1C0
	public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers) { }

	// RVA: 0x57FCC0 Offset: 0x57E2C0 VA: 0x18057FCC0
	public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby) { }

	// RVA: 0x57FD50 Offset: 0x57E350 VA: 0x18057FD50
	public static void LeaveLobby(CSteamID steamIDLobby) { }

	// RVA: 0x57FC60 Offset: 0x57E260 VA: 0x18057FC60
	public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee) { }

	// RVA: 0x57FC10 Offset: 0x57E210 VA: 0x18057FC10
	public static int GetNumLobbyMembers(CSteamID steamIDLobby) { }

	// RVA: 0x57F940 Offset: 0x57DF40 VA: 0x18057F940
	public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember) { }

	// RVA: 0x57F780 Offset: 0x57DD80 VA: 0x18057F780
	public static string GetLobbyData(CSteamID steamIDLobby, string pchKey) { }

	// RVA: 0x57FFF0 Offset: 0x57E5F0 VA: 0x18057FFF0
	public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	// RVA: 0x57F730 Offset: 0x57DD30 VA: 0x18057F730
	public static int GetLobbyDataCount(CSteamID steamIDLobby) { }

	// RVA: 0x57F5B0 Offset: 0x57DBB0 VA: 0x18057F5B0
	public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize) { }

	// RVA: 0x57F260 Offset: 0x57D860 VA: 0x18057F260
	public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey) { }

	// RVA: 0x57F9E0 Offset: 0x57DFE0 VA: 0x18057F9E0
	public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey) { }

	// RVA: 0x5802B0 Offset: 0x57E8B0 VA: 0x1805802B0
	public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	// RVA: 0x57FF10 Offset: 0x57E510 VA: 0x18057FF10
	public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody) { }

	// RVA: 0x57F510 Offset: 0x57DB10 VA: 0x18057F510
	public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType) { }

	// RVA: 0x57FE30 Offset: 0x57E430 VA: 0x18057FE30
	public static bool RequestLobbyData(CSteamID steamIDLobby) { }

	// RVA: 0x5801C0 Offset: 0x57E7C0 VA: 0x1805801C0
	public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) { }

	// RVA: 0x57F8B0 Offset: 0x57DEB0 VA: 0x18057F8B0
	public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) { }

	// RVA: 0x580470 Offset: 0x57EA70 VA: 0x180580470
	public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers) { }

	// RVA: 0x57FB30 Offset: 0x57E130 VA: 0x18057FB30
	public static int GetLobbyMemberLimit(CSteamID steamIDLobby) { }

	// RVA: 0x580530 Offset: 0x57EB30 VA: 0x180580530
	public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType) { }

	// RVA: 0x580250 Offset: 0x57E850 VA: 0x180580250
	public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable) { }

	// RVA: 0x57FB80 Offset: 0x57E180 VA: 0x18057FB80
	public static CSteamID GetLobbyOwner(CSteamID steamIDLobby) { }

	// RVA: 0x5804D0 Offset: 0x57EAD0 VA: 0x1805804D0
	public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner) { }

	// RVA: 0x57FF90 Offset: 0x57E590 VA: 0x18057FF90
	public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) { }
}

// Namespace: Steamworks
public static class SteamMatchmakingServers // TypeDefIndex: 10204
{
	// Methods

	// RVA: 0x57E850 Offset: 0x57CE50 VA: 0x18057E850
	public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0x57E960 Offset: 0x57CF60 VA: 0x18057E960
	public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0x57E630 Offset: 0x57CC30 VA: 0x18057E630
	public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0x57E520 Offset: 0x57CB20 VA: 0x18057E520
	public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0x57E740 Offset: 0x57CD40 VA: 0x18057E740
	public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0x57EA10 Offset: 0x57D010 VA: 0x18057EA10
	public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	// RVA: 0x57E4D0 Offset: 0x57CAD0 VA: 0x18057E4D0
	public static void ReleaseRequest(HServerListRequest hServerListRequest) { }

	// RVA: 0x57E100 Offset: 0x57C700 VA: 0x18057E100
	public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	// RVA: 0x57E010 Offset: 0x57C610 VA: 0x18057E010
	public static void CancelQuery(HServerListRequest hRequest) { }

	// RVA: 0x57E420 Offset: 0x57CA20 VA: 0x18057E420
	public static void RefreshQuery(HServerListRequest hRequest) { }

	// RVA: 0x57E230 Offset: 0x57C830 VA: 0x18057E230
	public static bool IsRefreshing(HServerListRequest hRequest) { }

	// RVA: 0x57E0B0 Offset: 0x57C6B0 VA: 0x18057E0B0
	public static int GetServerCount(HServerListRequest hRequest) { }

	// RVA: 0x57E470 Offset: 0x57CA70 VA: 0x18057E470
	public static void RefreshServer(HServerListRequest hRequest, int iServer) { }

	// RVA: 0x57E280 Offset: 0x57C880 VA: 0x18057E280
	public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse) { }

	// RVA: 0x57E350 Offset: 0x57C950 VA: 0x18057E350
	public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse) { }

	// RVA: 0x57EB20 Offset: 0x57D120 VA: 0x18057EB20
	public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse) { }

	// RVA: 0x57E060 Offset: 0x57C660 VA: 0x18057E060
	public static void CancelServerQuery(HServerQuery hServerQuery) { }
}

// Namespace: Steamworks
public static class SteamGameSearch // TypeDefIndex: 10205
{
	// Methods

	// RVA: 0x567910 Offset: 0x565F10 VA: 0x180567910
	public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind) { }

	// RVA: 0x567E30 Offset: 0x566430 VA: 0x180567E30
	public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) { }

	// RVA: 0x567DD0 Offset: 0x5663D0 VA: 0x180567DD0
	public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax) { }

	// RVA: 0x5678C0 Offset: 0x565EC0 VA: 0x1805678C0
	public static EGameSearchErrorCode_t AcceptGame() { }

	// RVA: 0x567B00 Offset: 0x566100 VA: 0x180567B00
	public static EGameSearchErrorCode_t DeclineGame() { }

	// RVA: 0x567CC0 Offset: 0x5662C0 VA: 0x180567CC0
	public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails) { }

	// RVA: 0x567B50 Offset: 0x566150 VA: 0x180567B50
	public static EGameSearchErrorCode_t EndGameSearch() { }

	// RVA: 0x567FD0 Offset: 0x5665D0 VA: 0x180567FD0
	public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue) { }

	// RVA: 0x567EB0 Offset: 0x5664B0 VA: 0x180567EB0
	public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails) { }

	// RVA: 0x567C40 Offset: 0x566240 VA: 0x180567C40
	public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) { }

	// RVA: 0x567BF0 Offset: 0x5661F0 VA: 0x180567BF0
	public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID) { }

	// RVA: 0x567AB0 Offset: 0x5660B0 VA: 0x180567AB0
	public static EGameSearchErrorCode_t CancelRequestPlayersForGame() { }

	// RVA: 0x568170 Offset: 0x566770 VA: 0x180568170
	public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) { }

	// RVA: 0x567BA0 Offset: 0x5661A0 VA: 0x180567BA0
	public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID) { }
}

// Namespace: Steamworks
public static class SteamParties // TypeDefIndex: 10206
{
	// Methods

	// RVA: 0x585490 Offset: 0x583A90 VA: 0x180585490
	public static uint GetNumActiveBeacons() { }

	// RVA: 0x5851B0 Offset: 0x5837B0 VA: 0x1805851B0
	public static PartyBeaconID_t GetBeaconByIndex(uint unIndex) { }

	// RVA: 0x585240 Offset: 0x583840 VA: 0x180585240
	public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata) { }

	// RVA: 0x585540 Offset: 0x583B40 VA: 0x180585540
	public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID) { }

	// RVA: 0x5854E0 Offset: 0x583AE0 VA: 0x1805854E0
	public static bool GetNumAvailableBeaconLocations(out uint puNumLocations) { }

	// RVA: 0x585150 Offset: 0x583750 VA: 0x180585150
	public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) { }

	// RVA: 0x584EE0 Offset: 0x5834E0 VA: 0x180584EE0
	public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata) { }

	// RVA: 0x5855D0 Offset: 0x583BD0 VA: 0x1805855D0
	public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	// RVA: 0x584DE0 Offset: 0x5833E0 VA: 0x180584DE0
	public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	// RVA: 0x584E40 Offset: 0x583440 VA: 0x180584E40
	public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots) { }

	// RVA: 0x5850F0 Offset: 0x5836F0 VA: 0x1805850F0
	public static bool DestroyBeacon(PartyBeaconID_t ulBeacon) { }

	// RVA: 0x585370 Offset: 0x583970 VA: 0x180585370
	public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut) { }
}

// Namespace: Steamworks
public static class SteamMusic // TypeDefIndex: 10207
{
	// Methods

	// RVA: 0x581460 Offset: 0x57FA60 VA: 0x180581460
	public static bool BIsEnabled() { }

	// RVA: 0x5814B0 Offset: 0x57FAB0 VA: 0x1805814B0
	public static bool BIsPlaying() { }

	// RVA: 0x581500 Offset: 0x57FB00 VA: 0x180581500
	public static AudioPlayback_Status GetPlaybackStatus() { }

	// RVA: 0x581690 Offset: 0x57FC90 VA: 0x180581690
	public static void Play() { }

	// RVA: 0x5815A0 Offset: 0x57FBA0 VA: 0x1805815A0
	public static void Pause() { }

	// RVA: 0x581640 Offset: 0x57FC40 VA: 0x180581640
	public static void PlayPrevious() { }

	// RVA: 0x5815F0 Offset: 0x57FBF0 VA: 0x1805815F0
	public static void PlayNext() { }

	// RVA: 0x5816E0 Offset: 0x57FCE0 VA: 0x1805816E0
	public static void SetVolume(float flVolume) { }

	// RVA: 0x581550 Offset: 0x57FB50 VA: 0x180581550
	public static float GetVolume() { }
}

// Namespace: Steamworks
public static class SteamMusicRemote // TypeDefIndex: 10208
{
	// Methods

	// RVA: 0x580B10 Offset: 0x57F110 VA: 0x180580B10
	public static bool RegisterSteamMusicRemote(string pchName) { }

	// RVA: 0x580740 Offset: 0x57ED40 VA: 0x180580740
	public static bool DeregisterSteamMusicRemote() { }

	// RVA: 0x5805F0 Offset: 0x57EBF0 VA: 0x1805805F0
	public static bool BIsCurrentMusicRemote() { }

	// RVA: 0x580590 Offset: 0x57EB90 VA: 0x180580590
	public static bool BActivationSuccess(bool bValue) { }

	// RVA: 0x580D60 Offset: 0x57F360 VA: 0x180580D60
	public static bool SetDisplayName(string pchDisplayName) { }

	// RVA: 0x580E70 Offset: 0x57F470 VA: 0x180580E70
	public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength) { }

	// RVA: 0x580850 Offset: 0x57EE50 VA: 0x180580850
	public static bool EnablePlayPrevious(bool bValue) { }

	// RVA: 0x5807F0 Offset: 0x57EDF0 VA: 0x1805807F0
	public static bool EnablePlayNext(bool bValue) { }

	// RVA: 0x580970 Offset: 0x57EF70 VA: 0x180580970
	public static bool EnableShuffled(bool bValue) { }

	// RVA: 0x580790 Offset: 0x57ED90 VA: 0x180580790
	public static bool EnableLooped(bool bValue) { }

	// RVA: 0x580910 Offset: 0x57EF10 VA: 0x180580910
	public static bool EnableQueue(bool bValue) { }

	// RVA: 0x5808B0 Offset: 0x57EEB0 VA: 0x1805808B0
	public static bool EnablePlaylists(bool bValue) { }

	// RVA: 0x581350 Offset: 0x57F950 VA: 0x180581350
	public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) { }

	// RVA: 0x5813A0 Offset: 0x57F9A0 VA: 0x1805813A0
	public static bool UpdateShuffled(bool bValue) { }

	// RVA: 0x5812F0 Offset: 0x57F8F0 VA: 0x1805812F0
	public static bool UpdateLooped(bool bValue) { }

	// RVA: 0x581400 Offset: 0x57FA00 VA: 0x180581400
	public static bool UpdateVolume(float flValue) { }

	// RVA: 0x5806F0 Offset: 0x57ECF0 VA: 0x1805806F0
	public static bool CurrentEntryWillChange() { }

	// RVA: 0x580690 Offset: 0x57EC90 VA: 0x180580690
	public static bool CurrentEntryIsAvailable(bool bAvailable) { }

	// RVA: 0x5811E0 Offset: 0x57F7E0 VA: 0x1805811E0
	public static bool UpdateCurrentEntryText(string pchText) { }

	// RVA: 0x581190 Offset: 0x57F790 VA: 0x180581190
	public static bool UpdateCurrentEntryElapsedSeconds(int nValue) { }

	// RVA: 0x581130 Offset: 0x57F730 VA: 0x180581130
	public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength) { }

	// RVA: 0x580640 Offset: 0x57EC40 VA: 0x180580640
	public static bool CurrentEntryDidChange() { }

	// RVA: 0x580AC0 Offset: 0x57F0C0 VA: 0x180580AC0
	public static bool QueueWillChange() { }

	// RVA: 0x580C70 Offset: 0x57F270 VA: 0x180580C70
	public static bool ResetQueueEntries() { }

	// RVA: 0x581000 Offset: 0x57F600 VA: 0x180581000
	public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText) { }

	// RVA: 0x580D10 Offset: 0x57F310 VA: 0x180580D10
	public static bool SetCurrentQueueEntry(int nID) { }

	// RVA: 0x580A70 Offset: 0x57F070 VA: 0x180580A70
	public static bool QueueDidChange() { }

	// RVA: 0x580A20 Offset: 0x57F020 VA: 0x180580A20
	public static bool PlaylistWillChange() { }

	// RVA: 0x580C20 Offset: 0x57F220 VA: 0x180580C20
	public static bool ResetPlaylistEntries() { }

	// RVA: 0x580ED0 Offset: 0x57F4D0 VA: 0x180580ED0
	public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText) { }

	// RVA: 0x580CC0 Offset: 0x57F2C0 VA: 0x180580CC0
	public static bool SetCurrentPlaylistEntry(int nID) { }

	// RVA: 0x5809D0 Offset: 0x57EFD0 VA: 0x1805809D0
	public static bool PlaylistDidChange() { }
}

// Namespace: Steamworks
public static class SteamNetworking // TypeDefIndex: 10209
{
	// Methods

	// RVA: 0x584B70 Offset: 0x583170 VA: 0x180584B70
	public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0) { }

	// RVA: 0x5848D0 Offset: 0x582ED0 VA: 0x1805848D0
	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0) { }

	// RVA: 0x584930 Offset: 0x582F30 VA: 0x180584930
	public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0) { }

	// RVA: 0x584210 Offset: 0x582810 VA: 0x180584210
	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0x584310 Offset: 0x582910 VA: 0x180584310
	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	// RVA: 0x5842B0 Offset: 0x5828B0 VA: 0x1805842B0
	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) { }

	// RVA: 0x5846B0 Offset: 0x582CB0 VA: 0x1805846B0
	public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	// RVA: 0x584260 Offset: 0x582860 VA: 0x180584260
	public static bool AllowP2PPacketRelay(bool bAllow) { }

	// RVA: 0x5843F0 Offset: 0x5829F0 VA: 0x1805843F0
	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	// RVA: 0x584490 Offset: 0x582A90 VA: 0x180584490
	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	// RVA: 0x584360 Offset: 0x582960 VA: 0x180584360
	public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	// RVA: 0x584580 Offset: 0x582B80 VA: 0x180584580
	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0x584520 Offset: 0x582B20 VA: 0x180584520
	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0x584AE0 Offset: 0x5830E0 VA: 0x180584AE0
	public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable) { }

	// RVA: 0x5847F0 Offset: 0x582DF0 VA: 0x1805847F0
	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) { }

	// RVA: 0x5849C0 Offset: 0x582FC0 VA: 0x1805849C0
	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	// RVA: 0x584850 Offset: 0x582E50 VA: 0x180584850
	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0x584A50 Offset: 0x583050 VA: 0x180584A50
	public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0x584760 Offset: 0x582D60 VA: 0x180584760
	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	// RVA: 0x5845E0 Offset: 0x582BE0 VA: 0x1805845E0
	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	// RVA: 0x584710 Offset: 0x582D10 VA: 0x180584710
	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) { }

	// RVA: 0x584660 Offset: 0x582C60 VA: 0x180584660
	public static int GetMaxPacketSize(SNetSocket_t hSocket) { }
}

// Namespace: Steamworks
public static class SteamNetworkingMessages // TypeDefIndex: 10210
{
	// Methods

	// RVA: 0x5819B0 Offset: 0x57FFB0 VA: 0x1805819B0
	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

	// RVA: 0x5818E0 Offset: 0x57FEE0 VA: 0x1805818E0
	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x581740 Offset: 0x57FD40 VA: 0x180581740
	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0x581800 Offset: 0x57FE00 VA: 0x180581800
	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0x5817A0 Offset: 0x57FDA0 VA: 0x1805817A0
	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	// RVA: 0x581860 Offset: 0x57FE60 VA: 0x180581860
	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }
}

// Namespace: Steamworks
public static class SteamNetworkingSockets // TypeDefIndex: 10211
{
	// Methods

	// RVA: 0x582130 Offset: 0x580730 VA: 0x180582130
	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x581D00 Offset: 0x580300 VA: 0x180581D00
	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5822A0 Offset: 0x5808A0 VA: 0x1805822A0
	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x581E90 Offset: 0x580490 VA: 0x180581E90
	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x581A40 Offset: 0x580040 VA: 0x180581A40
	public static EResult AcceptConnection(HSteamNetConnection hConn) { }

	// RVA: 0x581AE0 Offset: 0x5800E0 VA: 0x180581AE0
	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x581C20 Offset: 0x580220 VA: 0x180581C20
	public static bool CloseListenSocket(HSteamListenSocket hSocket) { }

	// RVA: 0x583380 Offset: 0x581980 VA: 0x180583380
	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) { }

	// RVA: 0x582880 Offset: 0x580E80 VA: 0x180582880
	public static long GetConnectionUserData(HSteamNetConnection hPeer) { }

	// RVA: 0x583210 Offset: 0x581810 VA: 0x180583210
	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) { }

	// RVA: 0x5826E0 Offset: 0x580CE0 VA: 0x1805826E0
	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) { }

	// RVA: 0x583080 Offset: 0x581680 VA: 0x180583080
	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	// RVA: 0x583110 Offset: 0x581710 VA: 0x180583110
	public static void SendMessages(int nMessages, IntPtr[] pMessages, long[] pOutMessageNumberOrResult) { }

	// RVA: 0x582550 Offset: 0x580B50 VA: 0x180582550
	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) { }

	// RVA: 0x582D30 Offset: 0x581330 VA: 0x180582D30
	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x582680 Offset: 0x580C80 VA: 0x180582680
	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	// RVA: 0x5827F0 Offset: 0x580DF0 VA: 0x1805827F0
	public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0
	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) { }

	// RVA: 0x582C20 Offset: 0x581220 VA: 0x180582C20
	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	// RVA: 0x5823E0 Offset: 0x5809E0 VA: 0x1805823E0
	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	// RVA: 0x581C70 Offset: 0x580270 VA: 0x180581C70
	public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int[] pLanePriorities, ushort[] pLaneWeights) { }

	// RVA: 0x582BC0 Offset: 0x5811C0 VA: 0x180582BC0
	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) { }

	// RVA: 0x582CE0 Offset: 0x5812E0 VA: 0x180582CE0
	public static ESteamNetworkingAvailability InitAuthentication() { }

	// RVA: 0x5825A0 Offset: 0x580BA0 VA: 0x1805825A0
	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) { }

	// RVA: 0x582350 Offset: 0x580950 VA: 0x180582350
	public static HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0x582480 Offset: 0x580A80 VA: 0x180582480
	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x583320 Offset: 0x581920 VA: 0x180583320
	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x582E00 Offset: 0x581400 VA: 0x180582E00
	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x582F50 Offset: 0x581550 VA: 0x180582F50
	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0x5824D0 Offset: 0x580AD0 VA: 0x1805824D0
	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0x581F60 Offset: 0x580560 VA: 0x180581F60
	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x582B70 Offset: 0x581170 VA: 0x180582B70
	public static ushort GetHostedDedicatedServerPort() { }

	// RVA: 0x582B20 Offset: 0x581120 VA: 0x180582B20
	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() { }

	// RVA: 0x582AC0 Offset: 0x5810C0 VA: 0x180582AC0
	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) { }

	// RVA: 0x582080 Offset: 0x580680 VA: 0x180582080
	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x582A40 Offset: 0x581040 VA: 0x180582A40
	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	// RVA: 0x581DC0 Offset: 0x5803C0 VA: 0x180581DC0
	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x582ED0 Offset: 0x5814D0 VA: 0x180582ED0
	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	// RVA: 0x582600 Offset: 0x580C00 VA: 0x180582600
	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0x583190 Offset: 0x581790 VA: 0x180583190
	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0x582FD0 Offset: 0x5815D0 VA: 0x180582FD0
	public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity) { }

	// RVA: 0x583030 Offset: 0x581630 VA: 0x180583030
	public static void RunCallbacks() { }

	// RVA: 0x581A90 Offset: 0x580090 VA: 0x180581A90
	public static bool BeginAsyncRequestFakeIP(int nNumPorts) { }

	// RVA: 0x5829E0 Offset: 0x580FE0 VA: 0x1805829E0
	public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x5821F0 Offset: 0x5807F0 VA: 0x1805821F0
	public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x582C80 Offset: 0x581280 VA: 0x180582C80
	public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	// RVA: 0x582030 Offset: 0x580630 VA: 0x180582030
	public static IntPtr CreateFakeUDPPort(int idxFakeServerPort) { }
}

// Namespace: Steamworks
public static class SteamNetworkingUtils // TypeDefIndex: 10212
{
	// Methods

	// RVA: 0x5833E0 Offset: 0x5819E0 VA: 0x1805833E0
	public static IntPtr AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0x583A80 Offset: 0x582080 VA: 0x180583A80
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x583A20 Offset: 0x582020 VA: 0x180583A20
	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) { }

	// RVA: 0x5837F0 Offset: 0x581DF0 VA: 0x1805837F0
	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) { }

	// RVA: 0x583570 Offset: 0x581B70 VA: 0x180583570
	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	// RVA: 0x5835D0 Offset: 0x581BD0 VA: 0x1805835D0
	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) { }

	// RVA: 0x583490 Offset: 0x581A90 VA: 0x180583490
	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) { }

	// RVA: 0x583B80 Offset: 0x582180 VA: 0x180583B80
	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) { }

	// RVA: 0x583430 Offset: 0x581A30 VA: 0x180583430
	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) { }

	// RVA: 0x583960 Offset: 0x581F60 VA: 0x180583960
	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	// RVA: 0x583750 Offset: 0x581D50 VA: 0x180583750
	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) { }

	// RVA: 0x5838B0 Offset: 0x581EB0 VA: 0x1805838B0
	public static int GetPOPCount() { }

	// RVA: 0x583900 Offset: 0x581F00 VA: 0x180583900
	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) { }

	// RVA: 0x583850 Offset: 0x581E50 VA: 0x180583850
	public static SteamNetworkingMicroseconds GetLocalTimestamp() { }

	// RVA: 0x583D30 Offset: 0x582330 VA: 0x180583D30
	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	// RVA: 0x583AD0 Offset: 0x5820D0 VA: 0x180583AD0
	public static bool IsFakeIPv4(uint nIPv4) { }

	// RVA: 0x5837A0 Offset: 0x581DA0 VA: 0x1805837A0
	public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) { }

	// RVA: 0x5839C0 Offset: 0x581FC0 VA: 0x1805839C0
	public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	// RVA: 0x583CA0 Offset: 0x5822A0 VA: 0x180583CA0
	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	// RVA: 0x5836B0 Offset: 0x581CB0 VA: 0x1805836B0
	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	// RVA: 0x583630 Offset: 0x581C30 VA: 0x180583630
	public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	// RVA: 0x583B20 Offset: 0x582120 VA: 0x180583B20
	public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	// RVA: 0x583F10 Offset: 0x582510 VA: 0x180583F10
	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x583DF0 Offset: 0x5823F0 VA: 0x180583DF0
	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) { }

	// RVA: 0x583D90 Offset: 0x582390 VA: 0x180583D90
	public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) { }

	// RVA: 0x584130 Offset: 0x582730 VA: 0x180584130
	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) { }

	// RVA: 0x584010 Offset: 0x582610 VA: 0x180584010
	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) { }
}

// Namespace: Steamworks
public static class SteamParentalSettings // TypeDefIndex: 10213
{
	// Methods

	// RVA: 0x584D40 Offset: 0x583340 VA: 0x180584D40
	public static bool BIsParentalLockEnabled() { }

	// RVA: 0x584D90 Offset: 0x583390 VA: 0x180584D90
	public static bool BIsParentalLockLocked() { }

	// RVA: 0x584C00 Offset: 0x583200 VA: 0x180584C00
	public static bool BIsAppBlocked(AppId_t nAppID) { }

	// RVA: 0x584C50 Offset: 0x583250 VA: 0x180584C50
	public static bool BIsAppInBlockList(AppId_t nAppID) { }

	// RVA: 0x584CA0 Offset: 0x5832A0 VA: 0x180584CA0
	public static bool BIsFeatureBlocked(EParentalFeature eFeature) { }

	// RVA: 0x584CF0 Offset: 0x5832F0 VA: 0x180584CF0
	public static bool BIsFeatureInBlockList(EParentalFeature eFeature) { }
}

// Namespace: Steamworks
public static class SteamRemotePlay // TypeDefIndex: 10214
{
	// Methods

	// RVA: 0x585820 Offset: 0x583E20 VA: 0x180585820
	public static uint GetSessionCount() { }

	// RVA: 0x585870 Offset: 0x583E70 VA: 0x180585870
	public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) { }

	// RVA: 0x5858D0 Offset: 0x583ED0 VA: 0x1805858D0
	public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) { }

	// RVA: 0x5857C0 Offset: 0x583DC0 VA: 0x1805857C0
	public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) { }

	// RVA: 0x585770 Offset: 0x583D70 VA: 0x180585770
	public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) { }

	// RVA: 0x585630 Offset: 0x583C30 VA: 0x180585630
	public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	// RVA: 0x585710 Offset: 0x583D10 VA: 0x180585710
	public static bool BStartRemotePlayTogether(bool bShowOverlay = True) { }

	// RVA: 0x5856B0 Offset: 0x583CB0 VA: 0x1805856B0
	public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) { }
}

// Namespace: Steamworks
public static class SteamRemoteStorage // TypeDefIndex: 10215
{
	// Methods

	// RVA: 0x586C70 Offset: 0x585270 VA: 0x180586C70
	public static bool FileWrite(string pchFile, byte[] pvData, int cubData) { }

	// RVA: 0x586620 Offset: 0x584C20 VA: 0x180586620
	public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead) { }

	// RVA: 0x5868A0 Offset: 0x584EA0 VA: 0x1805868A0
	public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData) { }

	// RVA: 0x5864B0 Offset: 0x584AB0 VA: 0x1805864B0
	public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead) { }

	// RVA: 0x586430 Offset: 0x584A30 VA: 0x180586430
	public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead) { }

	// RVA: 0x586210 Offset: 0x584810 VA: 0x180586210
	public static bool FileForget(string pchFile) { }

	// RVA: 0x585FF0 Offset: 0x5845F0 VA: 0x180585FF0
	public static bool FileDelete(string pchFile) { }

	// RVA: 0x586760 Offset: 0x584D60 VA: 0x180586760
	public static SteamAPICall_t FileShare(string pchFile) { }

	// RVA: 0x587F70 Offset: 0x586570 VA: 0x180587F70
	public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) { }

	// RVA: 0x586AB0 Offset: 0x5850B0 VA: 0x180586AB0
	public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile) { }

	// RVA: 0x586BF0 Offset: 0x5851F0 VA: 0x180586BF0
	public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData) { }

	// RVA: 0x586A60 Offset: 0x585060 VA: 0x180586A60
	public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle) { }

	// RVA: 0x586A10 Offset: 0x585010 VA: 0x180586A10
	public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle) { }

	// RVA: 0x586100 Offset: 0x584700 VA: 0x180586100
	public static bool FileExists(string pchFile) { }

	// RVA: 0x586320 Offset: 0x584920 VA: 0x180586320
	public static bool FilePersisted(string pchFile) { }

	// RVA: 0x586F40 Offset: 0x585540 VA: 0x180586F40
	public static int GetFileSize(string pchFile) { }

	// RVA: 0x587050 Offset: 0x585650 VA: 0x180587050
	public static long GetFileTimestamp(string pchFile) { }

	// RVA: 0x5873D0 Offset: 0x5859D0 VA: 0x1805873D0
	public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile) { }

	// RVA: 0x586E80 Offset: 0x585480 VA: 0x180586E80
	public static int GetFileCount() { }

	// RVA: 0x586ED0 Offset: 0x5854D0 VA: 0x180586ED0
	public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes) { }

	// RVA: 0x587370 Offset: 0x585970 VA: 0x180587370
	public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes) { }

	// RVA: 0x5876B0 Offset: 0x585CB0 VA: 0x1805876B0
	public static bool IsCloudEnabledForAccount() { }

	// RVA: 0x587700 Offset: 0x585D00 VA: 0x180587700
	public static bool IsCloudEnabledForApp() { }

	// RVA: 0x587F20 Offset: 0x586520 VA: 0x180587F20
	public static void SetCloudEnabledForApp(bool bEnabled) { }

	// RVA: 0x588330 Offset: 0x586930 VA: 0x180588330
	public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority) { }

	// RVA: 0x5875A0 Offset: 0x585BA0 VA: 0x1805875A0
	public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) { }

	// RVA: 0x5874E0 Offset: 0x585AE0 VA: 0x1805874E0
	public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) { }

	// RVA: 0x5883D0 Offset: 0x5869D0 VA: 0x1805883D0
	public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) { }

	// RVA: 0x586DA0 Offset: 0x5853A0 VA: 0x180586DA0
	public static int GetCachedUGCCount() { }

	// RVA: 0x586DF0 Offset: 0x5853F0 VA: 0x180586DF0
	public static UGCHandle_t GetCachedUGCHandle(int iCachedContent) { }

	// RVA: 0x587B80 Offset: 0x586180 VA: 0x180587B80
	public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType) { }

	// RVA: 0x585A40 Offset: 0x584040 VA: 0x180585A40
	public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x588610 Offset: 0x586C10 VA: 0x180588610
	public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile) { }

	// RVA: 0x588730 Offset: 0x586D30 VA: 0x180588730
	public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile) { }

	// RVA: 0x588A30 Offset: 0x587030 VA: 0x180588A30
	public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle) { }

	// RVA: 0x5884F0 Offset: 0x586AF0 VA: 0x1805884F0
	public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription) { }

	// RVA: 0x588B50 Offset: 0x587150 VA: 0x180588B50
	public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0x588970 Offset: 0x586F70 VA: 0x180588970
	public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags) { }

	// RVA: 0x5859B0 Offset: 0x583FB0 VA: 0x1805859B0
	public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle) { }

	// RVA: 0x587240 Offset: 0x585840 VA: 0x180587240
	public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) { }

	// RVA: 0x585AD0 Offset: 0x5840D0 VA: 0x180585AD0
	public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x585DA0 Offset: 0x5843A0 VA: 0x180585DA0
	public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex) { }

	// RVA: 0x588130 Offset: 0x586730 VA: 0x180588130
	public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x585F60 Offset: 0x584560 VA: 0x180585F60
	public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex) { }

	// RVA: 0x588460 Offset: 0x586A60 VA: 0x180588460
	public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x588850 Offset: 0x586E50 VA: 0x180588850
	public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription) { }

	// RVA: 0x5872E0 Offset: 0x5858E0 VA: 0x1805872E0
	public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x588BB0 Offset: 0x5871B0 VA: 0x180588BB0
	public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp) { }

	// RVA: 0x587620 Offset: 0x585C20 VA: 0x180587620
	public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x585E30 Offset: 0x584430 VA: 0x180585E30
	public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags) { }

	// RVA: 0x587750 Offset: 0x585D50 VA: 0x180587750
	public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags) { }

	// RVA: 0x588090 Offset: 0x586690 VA: 0x180588090
	public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) { }

	// RVA: 0x585BB0 Offset: 0x5841B0 VA: 0x180585BB0
	public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex) { }

	// RVA: 0x585C50 Offset: 0x584250 VA: 0x180585C50
	public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags) { }

	// RVA: 0x5881C0 Offset: 0x5867C0 VA: 0x1805881C0
	public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority) { }

	// RVA: 0x587170 Offset: 0x585770 VA: 0x180587170
	public static int GetLocalFileChangeCount() { }

	// RVA: 0x5871C0 Offset: 0x5857C0 VA: 0x1805871C0
	public static string GetLocalFileChange(int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType) { }

	// RVA: 0x585960 Offset: 0x583F60 VA: 0x180585960
	public static bool BeginFileWriteBatch() { }

	// RVA: 0x585B60 Offset: 0x584160 VA: 0x180585B60
	public static bool EndFileWriteBatch() { }
}

// Namespace: Steamworks
public static class SteamScreenshots // TypeDefIndex: 10216
{
	// Methods

	// RVA: 0x589300 Offset: 0x587900 VA: 0x180589300
	public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) { }

	// RVA: 0x588C50 Offset: 0x587250 VA: 0x180588C50
	public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight) { }

	// RVA: 0x5892B0 Offset: 0x5878B0 VA: 0x1805892B0
	public static void TriggerScreenshot() { }

	// RVA: 0x589030 Offset: 0x587630 VA: 0x180589030
	public static void HookScreenshots(bool bHook) { }

	// RVA: 0x5890D0 Offset: 0x5876D0 VA: 0x1805890D0
	public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation) { }

	// RVA: 0x589250 Offset: 0x587850 VA: 0x180589250
	public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID) { }

	// RVA: 0x5891F0 Offset: 0x5877F0 VA: 0x1805891F0
	public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) { }

	// RVA: 0x589080 Offset: 0x587680 VA: 0x180589080
	public static bool IsScreenshotsHooked() { }

	// RVA: 0x588E40 Offset: 0x587440 VA: 0x180588E40
	public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename) { }
}

// Namespace: Steamworks
public static class SteamTimeline // TypeDefIndex: 10217
{
	// Methods

	// RVA: 0x5896F0 Offset: 0x587CF0 VA: 0x1805896F0
	public static void SetTimelineStateDescription(string pchDescription, float flTimeDelta) { }

	// RVA: 0x589640 Offset: 0x587C40 VA: 0x180589640
	public static void ClearTimelineStateDescription(float flTimeDelta) { }

	// RVA: 0x5893C0 Offset: 0x5879C0 VA: 0x1805893C0
	public static void AddTimelineEvent(string pchIcon, string pchTitle, string pchDescription, uint unPriority, float flStartOffsetSeconds, float flDurationSeconds, ETimelineEventClipPriority ePossibleClip) { }

	// RVA: 0x5896A0 Offset: 0x587CA0 VA: 0x1805896A0
	public static void SetTimelineGameMode(ETimelineGameMode eMode) { }
}

// Namespace: Steamworks
public static class SteamUGC // TypeDefIndex: 10218
{
	// Methods

	// RVA: 0x58A7F0 Offset: 0x588DF0 VA: 0x18058A7F0
	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0x58A4F0 Offset: 0x588AF0 VA: 0x18058A4F0
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0x58A5C0 Offset: 0x588BC0 VA: 0x18058A5C0
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor) { }

	// RVA: 0x58A750 Offset: 0x588D50 VA: 0x18058A750
	public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x58C2E0 Offset: 0x58A8E0 VA: 0x18058C2E0
	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0x58B710 Offset: 0x589D10 VA: 0x18058B710
	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	// RVA: 0x58B5A0 Offset: 0x589BA0 VA: 0x18058B5A0
	public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x58B950 Offset: 0x589F50 VA: 0x18058B950
	public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0x58B820 Offset: 0x589E20 VA: 0x18058B820
	public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0x58B600 Offset: 0x589C00 VA: 0x18058B600
	public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) { }

	// RVA: 0x58B3D0 Offset: 0x5899D0 VA: 0x18058B3D0
	public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) { }

	// RVA: 0x58AF10 Offset: 0x589510 VA: 0x18058AF10
	public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0x58B790 Offset: 0x589D90 VA: 0x18058B790
	public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	// RVA: 0x58B4E0 Offset: 0x589AE0 VA: 0x18058B4E0
	public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x58AD70 Offset: 0x589370 VA: 0x18058AD70
	public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	// RVA: 0x58B540 Offset: 0x589B40 VA: 0x18058B540
	public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x58B080 Offset: 0x589680 VA: 0x18058B080
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) { }

	// RVA: 0x58B210 Offset: 0x589810 VA: 0x18058B210
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) { }

	// RVA: 0x58AD10 Offset: 0x589310 VA: 0x18058AD10
	public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x58BAE0 Offset: 0x58A0E0 VA: 0x18058BAE0
	public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize) { }

	// RVA: 0x58AFA0 Offset: 0x5895A0 VA: 0x18058AFA0
	public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	// RVA: 0x58BDE0 Offset: 0x58A3E0 VA: 0x18058BDE0
	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0x58A210 Offset: 0x588810 VA: 0x18058A210
	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0x58A150 Offset: 0x588750 VA: 0x18058A150
	public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups) { }

	// RVA: 0x5899A0 Offset: 0x587FA0 VA: 0x1805899A0
	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0x58D340 Offset: 0x58B940 VA: 0x18058D340
	public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0x58D220 Offset: 0x58B820 VA: 0x18058D220
	public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0x58D280 Offset: 0x58B880 VA: 0x18058D280
	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0x58D2E0 Offset: 0x58B8E0 VA: 0x18058D2E0
	public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0x58D1C0 Offset: 0x58B7C0 VA: 0x18058D1C0
	public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0x58D160 Offset: 0x58B760 VA: 0x18058D160
	public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0x58D400 Offset: 0x58BA00 VA: 0x18058D400
	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0x58D3A0 Offset: 0x58B9A0 VA: 0x18058D3A0
	public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0x58CDB0 Offset: 0x58B3B0 VA: 0x18058CDB0
	public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) { }

	// RVA: 0x58C3D0 Offset: 0x58A9D0 VA: 0x18058C3D0
	public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0x58C370 Offset: 0x58A970 VA: 0x18058C370
	public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery) { }

	// RVA: 0x58C490 Offset: 0x58AA90 VA: 0x18058C490
	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) { }

	// RVA: 0x58CED0 Offset: 0x58B4D0 VA: 0x18058CED0
	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0x58D460 Offset: 0x58BA60 VA: 0x18058D460
	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0x58CF30 Offset: 0x58B530 VA: 0x18058CF30
	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0x58D580 Offset: 0x58BB80 VA: 0x18058D580
	public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0x58D600 Offset: 0x58BC00 VA: 0x18058D600
	public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0x589F80 Offset: 0x588580 VA: 0x180589F80
	public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0x58C240 Offset: 0x58A840 VA: 0x18058C240
	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	// RVA: 0x58A450 Offset: 0x588A50 VA: 0x18058A450
	public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	// RVA: 0x58D770 Offset: 0x58BD70 VA: 0x18058D770
	public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58CB10 Offset: 0x58B110 VA: 0x18058CB10
	public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0x58C6D0 Offset: 0x58ACD0 VA: 0x18058C6D0
	public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0x58CC30 Offset: 0x58B230 VA: 0x18058CC30
	public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0x58C7F0 Offset: 0x58ADF0 VA: 0x18058C7F0
	public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0x58CD50 Offset: 0x58B350 VA: 0x18058CD50
	public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0x58CA30 Offset: 0x58B030 VA: 0x18058CA30
	public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags, bool bAllowAdminTags = False) { }

	// RVA: 0x58C5B0 Offset: 0x58ABB0 VA: 0x18058C5B0
	public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0x58C910 Offset: 0x58AF10 VA: 0x18058C910
	public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0x58C430 Offset: 0x58AA30 VA: 0x18058C430
	public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	// RVA: 0x58BE30 Offset: 0x58A430 VA: 0x18058BE30
	public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) { }

	// RVA: 0x58C0C0 Offset: 0x58A6C0 VA: 0x18058C0C0
	public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0x589AC0 Offset: 0x5880C0 VA: 0x180589AC0
	public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0x589C90 Offset: 0x588290 VA: 0x180589C90
	public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) { }

	// RVA: 0x589DC0 Offset: 0x5883C0 VA: 0x180589DC0
	public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) { }

	// RVA: 0x58DCA0 Offset: 0x58C2A0 VA: 0x18058DCA0
	public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) { }

	// RVA: 0x58DDD0 Offset: 0x58C3D0 VA: 0x18058DDD0
	public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) { }

	// RVA: 0x58C1E0 Offset: 0x58A7E0 VA: 0x18058C1E0
	public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) { }

	// RVA: 0x5898A0 Offset: 0x587EA0 VA: 0x1805898A0
	public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0x58BF20 Offset: 0x58A520 VA: 0x18058BF20
	public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0x58CF90 Offset: 0x58B590 VA: 0x18058CF90
	public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax) { }

	// RVA: 0x58D9E0 Offset: 0x58BFE0 VA: 0x18058D9E0
	public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0x58AC40 Offset: 0x589240 VA: 0x18058AC40
	public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	// RVA: 0x58D680 Offset: 0x58BC80 VA: 0x18058D680
	public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	// RVA: 0x58BCC0 Offset: 0x58A2C0 VA: 0x18058BCC0
	public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x589EE0 Offset: 0x5884E0 VA: 0x180589EE0
	public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58C020 Offset: 0x58A620 VA: 0x18058C020
	public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58DB30 Offset: 0x58C130 VA: 0x18058DB30
	public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58DC10 Offset: 0x58C210 VA: 0x18058DC10
	public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58ACC0 Offset: 0x5892C0 VA: 0x18058ACC0
	public static uint GetNumSubscribedItems() { }

	// RVA: 0x58BA80 Offset: 0x58A080 VA: 0x18058BA80
	public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0x58ABF0 Offset: 0x5891F0 VA: 0x18058ABF0
	public static uint GetItemState(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58AAD0 Offset: 0x5890D0 VA: 0x18058AAD0
	public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	// RVA: 0x58AA50 Offset: 0x589050 VA: 0x18058AA50
	public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0x58A960 Offset: 0x588F60 VA: 0x18058A960
	public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	// RVA: 0x58A330 Offset: 0x588930 VA: 0x18058A330
	public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) { }

	// RVA: 0x58DBC0 Offset: 0x58C1C0 VA: 0x18058DBC0
	public static void SuspendDownloads(bool bSuspend) { }

	// RVA: 0x58D810 Offset: 0x58BE10 VA: 0x18058D810
	public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x58D940 Offset: 0x58BF40 VA: 0x18058D940
	public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x58D8B0 Offset: 0x58BEB0 VA: 0x18058D8B0
	public static SteamAPICall_t StopPlaytimeTrackingForAllItems() { }

	// RVA: 0x589900 Offset: 0x587F00 VA: 0x180589900
	public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0x58BF80 Offset: 0x58A580 VA: 0x18058BF80
	public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0x589800 Offset: 0x587E00 VA: 0x180589800
	public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0x58BE80 Offset: 0x58A480 VA: 0x18058BE80
	public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0x58A9C0 Offset: 0x588FC0 VA: 0x18058A9C0
	public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58A8D0 Offset: 0x588ED0 VA: 0x18058A8D0
	public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x58D720 Offset: 0x58BD20 VA: 0x18058D720
	public static bool ShowWorkshopEULA() { }

	// RVA: 0x58BD50 Offset: 0x58A350 VA: 0x18058BD50
	public static SteamAPICall_t GetWorkshopEULAStatus() { }

	// RVA: 0x58BC60 Offset: 0x58A260 VA: 0x18058BC60
	public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }
}

// Namespace: Steamworks
public static class SteamUser // TypeDefIndex: 10219
{
	// Methods

	// RVA: 0x5CBCD0 Offset: 0x5CA2D0 VA: 0x1805CBCD0
	public static HSteamUser GetHSteamUser() { }

	// RVA: 0x5CB130 Offset: 0x5C9730 VA: 0x1805CB130
	public static bool BLoggedOn() { }

	// RVA: 0x5CBF30 Offset: 0x5CA530 VA: 0x1805CBF30
	public static CSteamID GetSteamID() { }

	// RVA: 0x5CC350 Offset: 0x5CA950 VA: 0x1805CC350
	public static int InitiateGameConnection_DEPRECATED(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) { }

	// RVA: 0x5CC900 Offset: 0x5CAF00 VA: 0x1805CC900
	public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer) { }

	// RVA: 0x5CC9D0 Offset: 0x5CAFD0 VA: 0x1805CC9D0
	public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "") { }

	// RVA: 0x5CC020 Offset: 0x5CA620 VA: 0x1805CC020
	public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer) { }

	// RVA: 0x5CC7A0 Offset: 0x5CADA0 VA: 0x1805CC7A0
	public static void StartVoiceRecording() { }

	// RVA: 0x5CC850 Offset: 0x5CAE50 VA: 0x1805CC850
	public static void StopVoiceRecording() { }

	// RVA: 0x5CB960 Offset: 0x5C9F60 VA: 0x1805CB960
	public static EVoiceResult GetAvailableVoice(out uint pcbCompressed) { }

	// RVA: 0x5CC230 Offset: 0x5CA830 VA: 0x1805CC230
	public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten) { }

	// RVA: 0x5CB450 Offset: 0x5C9A50 VA: 0x1805CB450
	public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0x5CC180 Offset: 0x5CA780 VA: 0x1805CC180
	public static uint GetVoiceOptimalSampleRate() { }

	// RVA: 0x5CB630 Offset: 0x5C9C30 VA: 0x1805CB630
	public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSteamNetworkingIdentity) { }

	// RVA: 0x5CB760 Offset: 0x5C9D60 VA: 0x1805CB760
	public static HAuthTicket GetAuthTicketForWebApi(string pchIdentity) { }

	// RVA: 0x5CB2A0 Offset: 0x5C98A0 VA: 0x1805CB2A0
	public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	// RVA: 0x5CB570 Offset: 0x5C9B70 VA: 0x1805CB570
	public static void EndAuthSession(CSteamID steamID) { }

	// RVA: 0x5CB390 Offset: 0x5C9990 VA: 0x1805CB390
	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0x5CCBB0 Offset: 0x5CB1B0 VA: 0x1805CCBB0
	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

	// RVA: 0x5CADC0 Offset: 0x5C93C0 VA: 0x1805CADC0
	public static bool BIsBehindNAT() { }

	// RVA: 0x5CACE0 Offset: 0x5C92E0 VA: 0x1805CACE0
	public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) { }

	// RVA: 0x5CC470 Offset: 0x5CAA70 VA: 0x1805CC470
	public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude) { }

	// RVA: 0x5CBB10 Offset: 0x5CA110 VA: 0x1805CBB10
	public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	// RVA: 0x5CBC00 Offset: 0x5CA200 VA: 0x1805CBC00
	public static int GetGameBadgeLevel(int nSeries, bool bFoil) { }

	// RVA: 0x5CBE80 Offset: 0x5CA480 VA: 0x1805CBE80
	public static int GetPlayerSteamLevel() { }

	// RVA: 0x5CC580 Offset: 0x5CAB80 VA: 0x1805CC580
	public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL) { }

	// RVA: 0x5CAFD0 Offset: 0x5C95D0 VA: 0x1805CAFD0
	public static bool BIsPhoneVerified() { }

	// RVA: 0x5CB080 Offset: 0x5C9680 VA: 0x1805CB080
	public static bool BIsTwoFactorEnabled() { }

	// RVA: 0x5CAE70 Offset: 0x5C9470 VA: 0x1805CAE70
	public static bool BIsPhoneIdentifying() { }

	// RVA: 0x5CAF20 Offset: 0x5C9520 VA: 0x1805CAF20
	public static bool BIsPhoneRequiringVerification() { }

	// RVA: 0x5CBD90 Offset: 0x5CA390 VA: 0x1805CBD90
	public static SteamAPICall_t GetMarketEligibility() { }

	// RVA: 0x5CBA20 Offset: 0x5CA020 VA: 0x1805CBA20
	public static SteamAPICall_t GetDurationControl() { }

	// RVA: 0x5CB1E0 Offset: 0x5C97E0 VA: 0x1805CB1E0
	public static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState) { }
}

// Namespace: Steamworks
public static class SteamUserStats // TypeDefIndex: 10220
{
	// Methods

	// RVA: 0x5C9EB0 Offset: 0x5C84B0 VA: 0x1805C9EB0
	public static bool RequestCurrentStats() { }

	// RVA: 0x5C9290 Offset: 0x5C7890 VA: 0x1805C9290
	public static bool GetStat(string pchName, out int pData) { }

	// RVA: 0x5C90A0 Offset: 0x5C76A0 VA: 0x1805C90A0
	public static bool GetStat(string pchName, out float pData) { }

	// RVA: 0x5CA500 Offset: 0x5C8B00 VA: 0x1805CA500
	public static bool SetStat(string pchName, int nData) { }

	// RVA: 0x5CA6F0 Offset: 0x5C8CF0 VA: 0x1805CA6F0
	public static bool SetStat(string pchName, float fData) { }

	// RVA: 0x5CA990 Offset: 0x5C8F90 VA: 0x1805CA990
	public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength) { }

	// RVA: 0x5C7DF0 Offset: 0x5C63F0 VA: 0x1805C7DF0
	public static bool GetAchievement(string pchName, out bool pbAchieved) { }

	// RVA: 0x5CA310 Offset: 0x5C8910 VA: 0x1805CA310
	public static bool SetAchievement(string pchName) { }

	// RVA: 0x5C6800 Offset: 0x5C4E00 VA: 0x1805C6800
	public static bool ClearAchievement(string pchName) { }

	// RVA: 0x5C7270 Offset: 0x5C5870 VA: 0x1805C7270
	public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	// RVA: 0x5CA8E0 Offset: 0x5C8EE0 VA: 0x1805CA8E0
	public static bool StoreStats() { }

	// RVA: 0x5C7750 Offset: 0x5C5D50 VA: 0x1805C7750
	public static int GetAchievementIcon(string pchName) { }

	// RVA: 0x5C7480 Offset: 0x5C5A80 VA: 0x1805C7480
	public static string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	// RVA: 0x5C9CB0 Offset: 0x5C82B0 VA: 0x1805C9CB0
	public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress) { }

	// RVA: 0x5C8F00 Offset: 0x5C7500 VA: 0x1805C8F00
	public static uint GetNumAchievements() { }

	// RVA: 0x5C7930 Offset: 0x5C5F30 VA: 0x1805C7930
	public static string GetAchievementName(uint iAchievement) { }

	// RVA: 0x5CA150 Offset: 0x5C8750 VA: 0x1805CA150
	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	// RVA: 0x5C9AB0 Offset: 0x5C80B0 VA: 0x1805C9AB0
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	// RVA: 0x5C98B0 Offset: 0x5C7EB0 VA: 0x1805C98B0
	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	// RVA: 0x5C96A0 Offset: 0x5C7CA0 VA: 0x1805C96A0
	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	// RVA: 0x5C9480 Offset: 0x5C7A80 VA: 0x1805C9480
	public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	// RVA: 0x5CA250 Offset: 0x5C8850 VA: 0x1805CA250
	public static bool ResetAllStats(bool bAchievementsToo) { }

	// RVA: 0x5C6E60 Offset: 0x5C5460 VA: 0x1805C6E60
	public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) { }

	// RVA: 0x5C6C40 Offset: 0x5C5240 VA: 0x1805C6C40
	public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName) { }

	// RVA: 0x5C8A40 Offset: 0x5C7040 VA: 0x1805C8A40
	public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5C8980 Offset: 0x5C6F80 VA: 0x1805C8980
	public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5C8B10 Offset: 0x5C7110 VA: 0x1805C8B10
	public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5C88C0 Offset: 0x5C6EC0 VA: 0x1805C88C0
	public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5C6B10 Offset: 0x5C5110 VA: 0x1805C6B10
	public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) { }

	// RVA: 0x5C69F0 Offset: 0x5C4FF0 VA: 0x1805C69F0
	public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers) { }

	// RVA: 0x5C7FF0 Offset: 0x5C65F0 VA: 0x1805C7FF0
	public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax) { }

	// RVA: 0x5CAB90 Offset: 0x5C9190 VA: 0x1805CAB90
	public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount) { }

	// RVA: 0x5C66F0 Offset: 0x5C4CF0 VA: 0x1805C66F0
	public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) { }

	// RVA: 0x5C8FB0 Offset: 0x5C75B0 VA: 0x1805C8FB0
	public static SteamAPICall_t GetNumberOfCurrentPlayers() { }

	// RVA: 0x5C9F60 Offset: 0x5C8560 VA: 0x1805C9F60
	public static SteamAPICall_t RequestGlobalAchievementPercentages() { }

	// RVA: 0x5C8BD0 Offset: 0x5C71D0 VA: 0x1805C8BD0
	public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	// RVA: 0x5C8D60 Offset: 0x5C7360 VA: 0x1805C8D60
	public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	// RVA: 0x5C7080 Offset: 0x5C5680 VA: 0x1805C7080
	public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent) { }

	// RVA: 0x5CA050 Offset: 0x5C8650 VA: 0x1805CA050
	public static SteamAPICall_t RequestGlobalStats(int nHistoryDays) { }

	// RVA: 0x5C86D0 Offset: 0x5C6CD0 VA: 0x1805C86D0
	public static bool GetGlobalStat(string pchStatName, out long pData) { }

	// RVA: 0x5C84E0 Offset: 0x5C6AE0 VA: 0x1805C84E0
	public static bool GetGlobalStat(string pchStatName, out double pData) { }

	// RVA: 0x5C8100 Offset: 0x5C6700 VA: 0x1805C8100
	public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData) { }

	// RVA: 0x5C82F0 Offset: 0x5C68F0 VA: 0x1805C82F0
	public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData) { }

	// RVA: 0x5C7BF0 Offset: 0x5C61F0 VA: 0x1805C7BF0
	public static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress) { }

	// RVA: 0x5C79F0 Offset: 0x5C5FF0 VA: 0x1805C79F0
	public static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress) { }
}

// Namespace: Steamworks
public static class SteamUtils // TypeDefIndex: 10221
{
	// Methods

	// RVA: 0x5CDD50 Offset: 0x5CC350 VA: 0x1805CDD50
	public static uint GetSecondsSinceAppActive() { }

	// RVA: 0x5CDE00 Offset: 0x5CC400 VA: 0x1805CDE00
	public static uint GetSecondsSinceComputerActive() { }

	// RVA: 0x5CD5E0 Offset: 0x5CBBE0 VA: 0x1805CD5E0
	public static EUniverse GetConnectedUniverse() { }

	// RVA: 0x5CDEB0 Offset: 0x5CC4B0 VA: 0x1805CDEB0
	public static uint GetServerRealTime() { }

	// RVA: 0x5CDA00 Offset: 0x5CC000 VA: 0x1805CDA00
	public static string GetIPCountry() { }

	// RVA: 0x5CDC70 Offset: 0x5CC270 VA: 0x1805CDC70
	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	// RVA: 0x5CDB80 Offset: 0x5CC180 VA: 0x1805CDB80
	public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0x5CD690 Offset: 0x5CBC90 VA: 0x1805CD690
	public static byte GetCurrentBatteryPower() { }

	// RVA: 0x5CD500 Offset: 0x5CBB00 VA: 0x1805CD500
	public static AppId_t GetAppID() { }

	// RVA: 0x5CE780 Offset: 0x5CCD80 VA: 0x1805CE780
	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) { }

	// RVA: 0x5CE0E0 Offset: 0x5CC6E0 VA: 0x1805CE0E0
	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	// RVA: 0x5CD330 Offset: 0x5CB930 VA: 0x1805CD330
	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) { }

	// RVA: 0x5CD3F0 Offset: 0x5CB9F0 VA: 0x1805CD3F0
	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	// RVA: 0x5CD950 Offset: 0x5CBF50 VA: 0x1805CD950
	public static uint GetIPCCallCount() { }

	// RVA: 0x5CE900 Offset: 0x5CCF00 VA: 0x1805CE900
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0x5CE1D0 Offset: 0x5CC7D0 VA: 0x1805CE1D0
	public static bool IsOverlayEnabled() { }

	// RVA: 0x5CCC80 Offset: 0x5CB280 VA: 0x1805CCC80
	public static bool BOverlayNeedsPresent() { }

	// RVA: 0x5CCD30 Offset: 0x5CB330 VA: 0x1805CCD30
	public static SteamAPICall_t CheckFileSignature(string szFileName) { }

	// RVA: 0x5CEAD0 Offset: 0x5CD0D0 VA: 0x1805CEAD0
	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) { }

	// RVA: 0x5CD8A0 Offset: 0x5CBEA0 VA: 0x1805CD8A0
	public static uint GetEnteredGamepadTextLength() { }

	// RVA: 0x5CD740 Offset: 0x5CBD40 VA: 0x1805CD740
	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) { }

	// RVA: 0x5CDF60 Offset: 0x5CC560 VA: 0x1805CDF60
	public static string GetSteamUILanguage() { }

	// RVA: 0x5CE3E0 Offset: 0x5CC9E0 VA: 0x1805CE3E0
	public static bool IsSteamRunningInVR() { }

	// RVA: 0x5CE6B0 Offset: 0x5CCCB0 VA: 0x1805CE6B0
	public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) { }

	// RVA: 0x5CE330 Offset: 0x5CC930 VA: 0x1805CE330
	public static bool IsSteamInBigPictureMode() { }

	// RVA: 0x5CEDC0 Offset: 0x5CD3C0 VA: 0x1805CEDC0
	public static void StartVRDashboard() { }

	// RVA: 0x5CE540 Offset: 0x5CCB40 VA: 0x1805CE540
	public static bool IsVRHeadsetStreamingEnabled() { }

	// RVA: 0x5CE840 Offset: 0x5CCE40 VA: 0x1805CE840
	public static void SetVRHeadsetStreamingEnabled(bool bEnabled) { }

	// RVA: 0x5CE280 Offset: 0x5CC880 VA: 0x1805CE280
	public static bool IsSteamChinaLauncher() { }

	// RVA: 0x5CE020 Offset: 0x5CC620 VA: 0x1805CE020
	public static bool InitFilterText(uint unFilterOptions = 0) { }

	// RVA: 0x5CD0B0 Offset: 0x5CB6B0 VA: 0x1805CD0B0
	public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0x5CDAC0 Offset: 0x5CC0C0 VA: 0x1805CDAC0
	public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) { }

	// RVA: 0x5CE490 Offset: 0x5CCA90 VA: 0x1805CE490
	public static bool IsSteamRunningOnSteamDeck() { }

	// RVA: 0x5CE9D0 Offset: 0x5CCFD0 VA: 0x1805CE9D0
	public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	// RVA: 0x5CE5F0 Offset: 0x5CCBF0 VA: 0x1805CE5F0
	public static void SetGameLauncherMode(bool bLauncherMode) { }

	// RVA: 0x5CCF50 Offset: 0x5CB550 VA: 0x1805CCF50
	public static bool DismissFloatingGamepadTextInput() { }

	// RVA: 0x5CD000 Offset: 0x5CB600 VA: 0x1805CD000
	public static bool DismissGamepadTextInput() { }
}

// Namespace: Steamworks
public static class SteamVideo // TypeDefIndex: 10222
{
	// Methods

	// RVA: 0x5CF0A0 Offset: 0x5CD6A0 VA: 0x1805CF0A0
	public static void GetVideoURL(AppId_t unVideoAppID) { }

	// RVA: 0x5CF160 Offset: 0x5CD760 VA: 0x1805CF160
	public static bool IsBroadcasting(out int pnNumViewers) { }

	// RVA: 0x5CEE70 Offset: 0x5CD470 VA: 0x1805CEE70
	public static void GetOPFSettings(AppId_t unVideoAppID) { }

	// RVA: 0x5CEF30 Offset: 0x5CD530 VA: 0x1805CEF30
	public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize) { }
}

// Namespace: Steamworks
internal static class NativeMethods // TypeDefIndex: 10223
{
	// Fields
	internal const string NativeLibraryName = "steam_api64";
	internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64";

	// Methods

	// RVA: 0x5C2820 Offset: 0x5C0E20 VA: 0x1805C2820
	public static extern ESteamAPIInitResult SteamInternal_SteamAPI_Init(InteropHelp.UTF8StringHandle pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg) { }

	// RVA: 0x5BF8E0 Offset: 0x5BDEE0 VA: 0x1805BF8E0
	public static extern void SteamAPI_Shutdown() { }

	// RVA: 0x5BF630 Offset: 0x5BDC30 VA: 0x1805BF630
	public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID) { }

	// RVA: 0x5BF5C0 Offset: 0x5BDBC0 VA: 0x1805BF5C0
	public static extern void SteamAPI_ReleaseCurrentThreadMemory() { }

	// RVA: 0x5C18C0 Offset: 0x5BFEC0 VA: 0x1805C18C0
	public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID) { }

	// RVA: 0x5BF7A0 Offset: 0x5BDDA0 VA: 0x1805BF7A0
	public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg) { }

	// RVA: 0x5BF6B0 Offset: 0x5BDCB0 VA: 0x1805BF6B0
	public static extern void SteamAPI_RunCallbacks() { }

	// RVA: 0x5BF530 Offset: 0x5BDB30 VA: 0x1805BF530
	public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback) { }

	// RVA: 0x5C1680 Offset: 0x5BFC80 VA: 0x1805C1680
	public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

	// RVA: 0x5BF4A0 Offset: 0x5BDAA0 VA: 0x1805BF4A0
	public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall) { }

	// RVA: 0x5C15F0 Offset: 0x5BFBF0 VA: 0x1805C15F0
	public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall) { }

	// RVA: 0x5BF150 Offset: 0x5BD750 VA: 0x1805BF150
	public static extern bool SteamAPI_IsSteamRunning() { }

	// RVA: 0x5BF0E0 Offset: 0x5BD6E0 VA: 0x1805BF0E0
	public static extern int SteamAPI_GetSteamInstallPath() { }

	// RVA: 0x5BF000 Offset: 0x5BD600 VA: 0x1805BF000
	public static extern int SteamAPI_GetHSteamPipe() { }

	// RVA: 0x5BF860 Offset: 0x5BDE60 VA: 0x1805BF860
	public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks) { }

	// RVA: 0x5BF070 Offset: 0x5BD670 VA: 0x1805BF070
	public static extern int SteamAPI_GetHSteamUser() { }

	// RVA: 0x5C23A0 Offset: 0x5C09A0 VA: 0x1805C23A0
	public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData) { }

	// RVA: 0x5C2420 Offset: 0x5C0A20 VA: 0x1805C2420
	public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver) { }

	// RVA: 0x5C25C0 Offset: 0x5C0BC0 VA: 0x1805C25C0
	public static extern IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion) { }

	// RVA: 0x5C24F0 Offset: 0x5C0AF0 VA: 0x1805C24F0
	public static extern IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion) { }

	// RVA: 0x5C1700 Offset: 0x5BFD00 VA: 0x1805C1700
	public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback) { }

	// RVA: 0x5BF720 Offset: 0x5BDD20 VA: 0x1805BF720
	public static extern void SteamAPI_SetBreakpadAppID(uint unAppID) { }

	// RVA: 0x5BF3B0 Offset: 0x5BD9B0 VA: 0x1805BF3B0
	public static extern void SteamAPI_ManualDispatch_Init() { }

	// RVA: 0x5BF420 Offset: 0x5BDA20 VA: 0x1805BF420
	public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe) { }

	// RVA: 0x5BF320 Offset: 0x5BD920 VA: 0x1805BF320
	public static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg) { }

	// RVA: 0x5BF1C0 Offset: 0x5BD7C0 VA: 0x1805BF1C0
	public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe) { }

	// RVA: 0x5BF240 Offset: 0x5BD840 VA: 0x1805BF240
	public static extern bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	// RVA: 0x5C2330 Offset: 0x5C0930 VA: 0x1805C2330
	public static extern void SteamGameServer_Shutdown() { }

	// RVA: 0x5C22C0 Offset: 0x5C08C0 VA: 0x1805C22C0
	public static extern void SteamGameServer_RunCallbacks() { }

	// RVA: 0x594CD0 Offset: 0x5932D0 VA: 0x180594CD0
	public static extern void SteamGameServer_ReleaseCurrentThreadMemory() { }

	// RVA: 0x594520 Offset: 0x592B20 VA: 0x180594520
	public static extern bool SteamGameServer_BSecure() { }

	// RVA: 0x5C2250 Offset: 0x5C0850 VA: 0x1805C2250
	public static extern ulong SteamGameServer_GetSteamID() { }

	// RVA: 0x5C2170 Offset: 0x5C0770 VA: 0x1805C2170
	public static extern int SteamGameServer_GetHSteamPipe() { }

	// RVA: 0x5C21E0 Offset: 0x5C07E0 VA: 0x1805C21E0
	public static extern int SteamGameServer_GetHSteamUser() { }

	// RVA: 0x5C2690 Offset: 0x5C0C90 VA: 0x1805C2690
	public static extern ESteamAPIInitResult SteamInternal_GameServer_Init_V2(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString, InteropHelp.UTF8StringHandle pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg) { }

	// RVA: 0x5C1960 Offset: 0x5BFF60 VA: 0x1805C1960
	public static extern IntPtr SteamClient() { }

	// RVA: 0x5C2100 Offset: 0x5C0700 VA: 0x1805C2100
	public static extern IntPtr SteamGameServerClient() { }

	// RVA: 0x5BF950 Offset: 0x5BDF50 VA: 0x1805BF950
	public static extern void SteamAPI_SteamNetworkingIPAddr_Clear(ref SteamNetworkingIPAddr self) { }

	// RVA: 0x5BFED0 Offset: 0x5BE4D0 VA: 0x1805BFED0
	public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(ref SteamNetworkingIPAddr self) { }

	// RVA: 0x5C03B0 Offset: 0x5BE9B0 VA: 0x1805C03B0
	public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6(ref SteamNetworkingIPAddr self, [In] [Out] byte[] ipv6, ushort nPort) { }

	// RVA: 0x5C01E0 Offset: 0x5BE7E0 VA: 0x1805C01E0
	public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv4(ref SteamNetworkingIPAddr self, uint nIP, ushort nPort) { }

	// RVA: 0x5BFDF0 Offset: 0x5BE3F0 VA: 0x1805BFDF0
	public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv4(ref SteamNetworkingIPAddr self) { }

	// RVA: 0x5BFB00 Offset: 0x5BE100 VA: 0x1805BFB00
	public static extern uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(ref SteamNetworkingIPAddr self) { }

	// RVA: 0x5C02D0 Offset: 0x5BE8D0 VA: 0x1805C02D0
	public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(ref SteamNetworkingIPAddr self, ushort nPort) { }

	// RVA: 0x5BFFB0 Offset: 0x5BE5B0 VA: 0x1805BFFB0
	public static extern bool SteamAPI_SteamNetworkingIPAddr_IsLocalHost(ref SteamNetworkingIPAddr self) { }

	// RVA: 0x5C04A0 Offset: 0x5BEAA0 VA: 0x1805C04A0
	public static extern void SteamAPI_SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x5C0090 Offset: 0x5BE690 VA: 0x1805C0090
	public static extern bool SteamAPI_SteamNetworkingIPAddr_ParseString(ref SteamNetworkingIPAddr self, InteropHelp.UTF8StringHandle pszStr) { }

	// RVA: 0x5BFBE0 Offset: 0x5BE1E0 VA: 0x1805BFBE0
	public static extern bool SteamAPI_SteamNetworkingIPAddr_IsEqualTo(ref SteamNetworkingIPAddr self, ref SteamNetworkingIPAddr x) { }

	// RVA: 0x5BFA20 Offset: 0x5BE020 VA: 0x1805BFA20
	public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr self) { }

	// RVA: 0x5BFD10 Offset: 0x5BE310 VA: 0x1805BFD10
	public static extern bool SteamAPI_SteamNetworkingIPAddr_IsFakeIP(ref SteamNetworkingIPAddr self) { }

	// RVA: 0x5C05A0 Offset: 0x5BEBA0 VA: 0x1805C05A0
	public static extern void SteamAPI_SteamNetworkingIdentity_Clear(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C0C40 Offset: 0x5BF240 VA: 0x1805C0C40
	public static extern bool SteamAPI_SteamNetworkingIdentity_IsInvalid(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C1360 Offset: 0x5BF960 VA: 0x1805C1360
	public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID(ref SteamNetworkingIdentity self, ulong steamID) { }

	// RVA: 0x5C0A30 Offset: 0x5BF030 VA: 0x1805C0A30
	public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C12D0 Offset: 0x5BF8D0 VA: 0x1805C12D0
	public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID64(ref SteamNetworkingIdentity self, ulong steamID) { }

	// RVA: 0x5C09B0 Offset: 0x5BEFB0 VA: 0x1805C09B0
	public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C13F0 Offset: 0x5BF9F0 VA: 0x1805C13F0
	public static extern bool SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString) { }

	// RVA: 0x5C0AB0 Offset: 0x5BF0B0 VA: 0x1805C0AB0
	public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C11B0 Offset: 0x5BF7B0 VA: 0x1805C11B0
	public static extern void SteamAPI_SteamNetworkingIdentity_SetPSNID(ref SteamNetworkingIdentity self, ulong id) { }

	// RVA: 0x5C08B0 Offset: 0x5BEEB0 VA: 0x1805C08B0
	public static extern ulong SteamAPI_SteamNetworkingIdentity_GetPSNID(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C1240 Offset: 0x5BF840 VA: 0x1805C1240
	public static extern void SteamAPI_SteamNetworkingIdentity_SetStadiaID(ref SteamNetworkingIdentity self, ulong id) { }

	// RVA: 0x5C0930 Offset: 0x5BEF30 VA: 0x1805C0930
	public static extern ulong SteamAPI_SteamNetworkingIdentity_GetStadiaID(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C0FB0 Offset: 0x5BF5B0 VA: 0x1805C0FB0
	public static extern IntPtr SteamAPI_SteamNetworkingIdentity_SetIPAddr(ref SteamNetworkingIdentity self, ref SteamNetworkingIPAddr addr) { }

	// RVA: 0x5C07B0 Offset: 0x5BEDB0 VA: 0x1805C07B0
	public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetIPAddr(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C1090 Offset: 0x5BF690 VA: 0x1805C1090
	public static extern void SteamAPI_SteamNetworkingIdentity_SetIPv4Addr(ref SteamNetworkingIdentity self, uint nIPv4, ushort nPort) { }

	// RVA: 0x5C0830 Offset: 0x5BEE30 VA: 0x1805C0830
	public static extern uint SteamAPI_SteamNetworkingIdentity_GetIPv4(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C0620 Offset: 0x5BEC20 VA: 0x1805C0620
	public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIdentity_GetFakeIPType(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C0BC0 Offset: 0x5BF1C0 VA: 0x1805C0BC0
	public static extern bool SteamAPI_SteamNetworkingIdentity_IsFakeIP(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C1130 Offset: 0x5BF730 VA: 0x1805C1130
	public static extern void SteamAPI_SteamNetworkingIdentity_SetLocalHost(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C0CC0 Offset: 0x5BF2C0 VA: 0x1805C0CC0
	public static extern bool SteamAPI_SteamNetworkingIdentity_IsLocalHost(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C0ED0 Offset: 0x5BF4D0 VA: 0x1805C0ED0
	public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString) { }

	// RVA: 0x5C0730 Offset: 0x5BED30 VA: 0x1805C0730
	public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericString(ref SteamNetworkingIdentity self) { }

	// RVA: 0x5C0E20 Offset: 0x5BF420 VA: 0x1805C0E20
	public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericBytes(ref SteamNetworkingIdentity self, [In] [Out] byte[] data, uint cbLen) { }

	// RVA: 0x5C06A0 Offset: 0x5BECA0 VA: 0x1805C06A0
	public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericBytes(ref SteamNetworkingIdentity self, out int cbLen) { }

	// RVA: 0x5C0B30 Offset: 0x5BF130 VA: 0x1805C0B30
	public static extern bool SteamAPI_SteamNetworkingIdentity_IsEqualTo(ref SteamNetworkingIdentity self, ref SteamNetworkingIdentity x) { }

	// RVA: 0x5C14D0 Offset: 0x5BFAD0 VA: 0x1805C14D0
	public static extern void SteamAPI_SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity self, IntPtr buf, uint cbBuf) { }

	// RVA: 0x5C0D40 Offset: 0x5BF340 VA: 0x1805C0D40
	public static extern bool SteamAPI_SteamNetworkingIdentity_ParseString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszStr) { }

	// RVA: 0x5C1570 Offset: 0x5BFB70 VA: 0x1805C1570
	public static extern void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr self) { }

	// RVA: 0x596E40 Offset: 0x595440 VA: 0x180596E40
	public static extern bool SteamAPI_ISteamNetworkingConnectionSignaling_SendSignal(ref ISteamNetworkingConnectionSignaling self, HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg) { }

	// RVA: 0x596DC0 Offset: 0x5953C0 VA: 0x180596DC0
	public static extern void SteamAPI_ISteamNetworkingConnectionSignaling_Release(ref ISteamNetworkingConnectionSignaling self) { }

	// RVA: 0x596FE0 Offset: 0x5955E0 VA: 0x180596FE0
	public static extern IntPtr SteamAPI_ISteamNetworkingSignalingRecvContext_OnConnectRequest(ref ISteamNetworkingSignalingRecvContext self, HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort) { }

	// RVA: 0x597080 Offset: 0x595680 VA: 0x180597080
	public static extern void SteamAPI_ISteamNetworkingSignalingRecvContext_SendRejectionSignal(ref ISteamNetworkingSignalingRecvContext self, ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg) { }

	// RVA: 0x5C19D0 Offset: 0x5BFFD0 VA: 0x1805C19D0
	public static extern bool SteamEncryptedAppTicket_BDecryptTicket([In] [Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In] [Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey) { }

	// RVA: 0x5C1C00 Offset: 0x5C0200 VA: 0x1805C1C00
	public static extern bool SteamEncryptedAppTicket_BIsTicketForApp([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	// RVA: 0x5C1F30 Offset: 0x5C0530 VA: 0x1805C1F30
	public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5C1FC0 Offset: 0x5C05C0 VA: 0x1805C1FC0
	public static extern void SteamEncryptedAppTicket_GetTicketSteamID([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	// RVA: 0x5C1EA0 Offset: 0x5C04A0 VA: 0x1805C1EA0
	public static extern uint SteamEncryptedAppTicket_GetTicketAppID([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5C1E00 Offset: 0x5C0400 VA: 0x1805C1E00
	public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	// RVA: 0x5C1D60 Offset: 0x5C0360 VA: 0x1805C1D60
	public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5C2060 Offset: 0x5C0660 VA: 0x1805C2060
	public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

	// RVA: 0x5C1CA0 Offset: 0x5C02A0 VA: 0x1805C1CA0
	public static extern bool SteamEncryptedAppTicket_BIsTicketSigned([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, [In] [Out] byte[] pubRSAKey, uint cubRSAKey) { }

	// RVA: 0x5C1AC0 Offset: 0x5C00C0 VA: 0x1805C1AC0
	public static extern bool SteamEncryptedAppTicket_BIsLicenseBorrowed([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5C1B60 Offset: 0x5C0160 VA: 0x1805C1B60
	public static extern bool SteamEncryptedAppTicket_BIsLicenseTemporary([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5986D0 Offset: 0x596CD0 VA: 0x1805986D0
	public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr) { }

	// RVA: 0x5984C0 Offset: 0x596AC0 VA: 0x1805984C0
	public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr) { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr) { }

	// RVA: 0x5987F0 Offset: 0x596DF0 VA: 0x1805987F0
	public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr) { }

	// RVA: 0x598C10 Offset: 0x597210 VA: 0x180598C10
	public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr) { }

	// RVA: 0x598A10 Offset: 0x597010 VA: 0x180598A10
	public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr) { }

	// RVA: 0x598540 Offset: 0x596B40 VA: 0x180598540
	public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID) { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID) { }

	// RVA: 0x598DC0 Offset: 0x5973C0 VA: 0x180598DC0
	public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID) { }

	// RVA: 0x598650 Offset: 0x596C50 VA: 0x180598650
	public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr) { }

	// RVA: 0x598C90 Offset: 0x597290 VA: 0x180598C90
	public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr) { }

	// RVA: 0x598240 Offset: 0x596840 VA: 0x180598240
	public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize) { }

	// RVA: 0x599200 Offset: 0x597800 VA: 0x180599200
	public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID) { }

	// RVA: 0x5995A0 Offset: 0x597BA0 VA: 0x1805995A0
	public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID) { }

	// RVA: 0x5993A0 Offset: 0x5979A0 VA: 0x1805993A0
	public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID) { }

	// RVA: 0x598B70 Offset: 0x597170 VA: 0x180598B70
	public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize) { }

	// RVA: 0x599290 Offset: 0x597890 VA: 0x180599290
	public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly) { }

	// RVA: 0x598F30 Offset: 0x597530 VA: 0x180598F30
	public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In] [Out] DepotId_t[] pvecDepots, uint cMaxDepots) { }

	// RVA: 0x5988F0 Offset: 0x596EF0 VA: 0x1805988F0
	public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize) { }

	// RVA: 0x598320 Offset: 0x596920 VA: 0x180598320
	public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID) { }

	// RVA: 0x598990 Offset: 0x596F90 VA: 0x180598990
	public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr) { }

	// RVA: 0x599080 Offset: 0x597680 VA: 0x180599080
	public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey) { }

	// RVA: 0x598D10 Offset: 0x597310 VA: 0x180598D10
	public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0x598870 Offset: 0x596E70 VA: 0x180598870
	public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr) { }

	// RVA: 0x599320 Offset: 0x597920 VA: 0x180599320
	public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr) { }

	// RVA: 0x598E50 Offset: 0x597450 VA: 0x180598E50
	public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName) { }

	// RVA: 0x598FE0 Offset: 0x5975E0 VA: 0x180598FE0
	public static extern int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine) { }

	// RVA: 0x5985D0 Offset: 0x596BD0 VA: 0x1805985D0
	public static extern bool ISteamApps_BIsSubscribedFromFamilySharing(IntPtr instancePtr) { }

	// RVA: 0x598750 Offset: 0x596D50 VA: 0x180598750
	public static extern bool ISteamApps_BIsTimedTrial(IntPtr instancePtr, out uint punSecondsAllowed, out uint punSecondsPlayed) { }

	// RVA: 0x599510 Offset: 0x597B10 VA: 0x180599510
	public static extern bool ISteamApps_SetDlcContext(IntPtr instancePtr, AppId_t nAppID) { }

	// RVA: 0x599160 Offset: 0x597760 VA: 0x180599160
	public static extern int ISteamApps_GetNumBetas(IntPtr instancePtr, out int pnAvailable, out int pnPrivate) { }

	// RVA: 0x598A90 Offset: 0x597090 VA: 0x180598A90
	public static extern bool ISteamApps_GetBetaInfo(IntPtr instancePtr, int iBetaIndex, out uint punFlags, out uint punBuildID, IntPtr pchBetaName, int cchBetaName, IntPtr pchDescription, int cchDescription) { }

	// RVA: 0x599430 Offset: 0x597A30 VA: 0x180599430
	public static extern bool ISteamApps_SetActiveBeta(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchBetaName) { }

	// RVA: 0x599870 Offset: 0x597E70 VA: 0x180599870
	public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr) { }

	// RVA: 0x599630 Offset: 0x597C30 VA: 0x180599630
	public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe) { }

	// RVA: 0x599740 Offset: 0x597D40 VA: 0x180599740
	public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe) { }

	// RVA: 0x5997D0 Offset: 0x597DD0 VA: 0x1805997D0
	public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	// RVA: 0x59B1C0 Offset: 0x5997C0 VA: 0x18059B1C0
	public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser) { }

	// RVA: 0x59AF00 Offset: 0x599500 VA: 0x18059AF00
	public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x599E20 Offset: 0x598420 VA: 0x180599E20
	public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59B260 Offset: 0x599860 VA: 0x18059B260
	public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, ref SteamIPAddress_t unIP, ushort usPort) { }

	// RVA: 0x599B50 Offset: 0x598150 VA: 0x180599B50
	public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59AFF0 Offset: 0x5995F0 VA: 0x18059AFF0
	public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A4B0 Offset: 0x598AB0 VA: 0x18059A4B0
	public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A3C0 Offset: 0x5989C0 VA: 0x18059A3C0
	public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x599F10 Offset: 0x598510 VA: 0x180599F10
	public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59AE10 Offset: 0x599410 VA: 0x18059AE10
	public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x599D30 Offset: 0x598330 VA: 0x180599D30
	public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x599970 Offset: 0x597F70 VA: 0x180599970
	public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A780 Offset: 0x598D80 VA: 0x18059A780
	public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59AB40 Offset: 0x599140 VA: 0x18059AB40
	public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59AC30 Offset: 0x599230 VA: 0x18059AC30
	public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x599C40 Offset: 0x598240 VA: 0x180599C40
	public static extern IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x5998F0 Offset: 0x597EF0 VA: 0x1805998F0
	public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr) { }

	// RVA: 0x59B300 Offset: 0x599900 VA: 0x18059B300
	public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0x5996C0 Offset: 0x597CC0 VA: 0x1805996C0
	public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr) { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x599A60 Offset: 0x598060 VA: 0x180599A60
	public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59AD20 Offset: 0x599320 VA: 0x18059AD20
	public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A690 Offset: 0x598C90 VA: 0x18059A690
	public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A5A0 Offset: 0x598BA0 VA: 0x18059A5A0
	public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A000 Offset: 0x598600 VA: 0x18059A000
	public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A2D0 Offset: 0x5988D0 VA: 0x18059A2D0
	public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59B0D0 Offset: 0x5996D0 VA: 0x18059B0D0
	public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A870 Offset: 0x598E70 VA: 0x18059A870
	public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A1E0 Offset: 0x5987E0 VA: 0x18059A1E0
	public static extern IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59A960 Offset: 0x598F60 VA: 0x18059A960
	public static extern IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59AA50 Offset: 0x599050 VA: 0x18059AA50
	public static extern IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion) { }

	// RVA: 0x59D240 Offset: 0x59B840 VA: 0x18059D240
	public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr) { }

	// RVA: 0x59E310 Offset: 0x59C910 VA: 0x18059E310
	public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName) { }

	// RVA: 0x59D2C0 Offset: 0x59B8C0 VA: 0x18059D2C0
	public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr) { }

	// RVA: 0x59C640 Offset: 0x59AC40 VA: 0x18059C640
	public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags) { }

	// RVA: 0x59C3F0 Offset: 0x59A9F0 VA: 0x18059C3F0
	public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags) { }

	// RVA: 0x59CA90 Offset: 0x59B090 VA: 0x18059CA90
	public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59CA00 Offset: 0x59B000 VA: 0x18059CA00
	public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59C970 Offset: 0x59AF70 VA: 0x18059C970
	public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59C770 Offset: 0x59AD70 VA: 0x18059C770
	public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x59C8D0 Offset: 0x59AED0 VA: 0x18059C8D0
	public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName) { }

	// RVA: 0x59CD30 Offset: 0x59B330 VA: 0x18059CD30
	public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59D340 Offset: 0x59B940 VA: 0x18059D340
	public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer) { }

	// RVA: 0x59CDC0 Offset: 0x59B3C0 VA: 0x18059CDC0
	public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr) { }

	// RVA: 0x59CE40 Offset: 0x59B440 VA: 0x18059CE40
	public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG) { }

	// RVA: 0x59D010 Offset: 0x59B610 VA: 0x18059D010
	public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID) { }

	// RVA: 0x59CED0 Offset: 0x59B4D0 VA: 0x18059CED0
	public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID) { }

	// RVA: 0x59CF60 Offset: 0x59B560 VA: 0x18059CF60
	public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In] [Out] CSteamID[] pOutSteamIDMembers, int nMembersCount) { }

	// RVA: 0x59D640 Offset: 0x59BC40 VA: 0x18059D640
	public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags) { }

	// RVA: 0x59BEF0 Offset: 0x59A4F0 VA: 0x18059BEF0
	public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr) { }

	// RVA: 0x59BD00 Offset: 0x59A300 VA: 0x18059BD00
	public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan) { }

	// RVA: 0x59BF70 Offset: 0x59A570 VA: 0x18059BF70
	public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59C1C0 Offset: 0x59A7C0 VA: 0x18059C1C0
	public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59BC40 Offset: 0x59A240 VA: 0x18059BC40
	public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) { }

	// RVA: 0x59BA70 Offset: 0x59A070 VA: 0x18059BA70
	public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In] [Out] CSteamID[] psteamIDClans, int cClansToRequest) { }

	// RVA: 0x59C5B0 Offset: 0x59ABB0 VA: 0x18059C5B0
	public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource) { }

	// RVA: 0x59C6D0 Offset: 0x59ACD0 VA: 0x18059C6D0
	public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend) { }

	// RVA: 0x59DAA0 Offset: 0x59C0A0 VA: 0x18059DAA0
	public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource) { }

	// RVA: 0x59E1E0 Offset: 0x59C7E0 VA: 0x18059E1E0
	public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking) { }

	// RVA: 0x59B7F0 Offset: 0x599DF0 VA: 0x18059B7F0
	public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog) { }

	// RVA: 0x59B630 Offset: 0x599C30 VA: 0x18059B630
	public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID) { }

	// RVA: 0x59B710 Offset: 0x599D10 VA: 0x18059B710
	public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x59B590 Offset: 0x599B90 VA: 0x18059B590
	public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	// RVA: 0x59E3F0 Offset: 0x59C9F0 VA: 0x18059E3F0
	public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith) { }

	// RVA: 0x59B470 Offset: 0x599A70 VA: 0x18059B470
	public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x59D530 Offset: 0x59BB30 VA: 0x18059D530
	public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59D130 Offset: 0x59B730 VA: 0x18059D130
	public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59D0A0 Offset: 0x59B6A0 VA: 0x18059D0A0
	public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59E060 Offset: 0x59C660 VA: 0x18059E060
	public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x59DEB0 Offset: 0x59C4B0 VA: 0x18059DEB0
	public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59C130 Offset: 0x59A730 VA: 0x18059C130
	public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59C0A0 Offset: 0x59A6A0 VA: 0x18059C0A0
	public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59C000 Offset: 0x59A600 VA: 0x18059C000
	public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer) { }

	// RVA: 0x59D5C0 Offset: 0x59BBC0 VA: 0x18059D5C0
	public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr) { }

	// RVA: 0x59E480 Offset: 0x59CA80 VA: 0x18059E480
	public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue) { }

	// RVA: 0x59B960 Offset: 0x599F60 VA: 0x18059B960
	public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr) { }

	// RVA: 0x59CC50 Offset: 0x59B250 VA: 0x18059CC50
	public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey) { }

	// RVA: 0x59CBC0 Offset: 0x59B1C0 VA: 0x18059CBC0
	public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59CB20 Offset: 0x59B120 VA: 0x18059CB20
	public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey) { }

	// RVA: 0x59DFD0 Offset: 0x59C5D0 VA: 0x18059DFD0
	public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59D6E0 Offset: 0x59BCE0 VA: 0x18059D6E0
	public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString) { }

	// RVA: 0x59C250 Offset: 0x59A850 VA: 0x18059C250
	public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr) { }

	// RVA: 0x59C2D0 Offset: 0x59A8D0 VA: 0x18059C2D0
	public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend) { }

	// RVA: 0x59C520 Offset: 0x59AB20 VA: 0x18059C520
	public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59C490 Offset: 0x59AA90 VA: 0x18059C490
	public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x59DB40 Offset: 0x59C140 VA: 0x18059DB40
	public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59DBD0 Offset: 0x59C1D0 VA: 0x18059DBD0
	public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59BD90 Offset: 0x59A390 VA: 0x18059BD90
	public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59BBA0 Offset: 0x59A1A0 VA: 0x18059BBA0
	public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser) { }

	// RVA: 0x59E100 Offset: 0x59C700 VA: 0x18059E100
	public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText) { }

	// RVA: 0x59BE20 Offset: 0x59A420 VA: 0x18059BE20
	public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) { }

	// RVA: 0x59D7C0 Offset: 0x59BDC0 VA: 0x18059D7C0
	public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser) { }

	// RVA: 0x59D860 Offset: 0x59BE60 VA: 0x18059D860
	public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	// RVA: 0x59DC60 Offset: 0x59C260 VA: 0x18059DC60
	public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	// RVA: 0x59B9E0 Offset: 0x599FE0 VA: 0x18059B9E0
	public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	// RVA: 0x59E280 Offset: 0x59C880 VA: 0x18059E280
	public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled) { }

	// RVA: 0x59DDD0 Offset: 0x59C3D0 VA: 0x18059DDD0
	public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend) { }

	// RVA: 0x59C810 Offset: 0x59AE10 VA: 0x18059C810
	public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType) { }

	// RVA: 0x59C360 Offset: 0x59A960 VA: 0x18059C360
	public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID) { }

	// RVA: 0x59DA10 Offset: 0x59C010 VA: 0x18059DA10
	public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID) { }

	// RVA: 0x59BB10 Offset: 0x59A110 VA: 0x18059BB10
	public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex) { }

	// RVA: 0x59D980 Offset: 0x59BF80 VA: 0x18059D980
	public static extern bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59D8F0 Offset: 0x59BEF0 VA: 0x18059D8F0
	public static extern bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59D1C0 Offset: 0x59B7C0 VA: 0x18059D1C0
	public static extern int ISteamFriends_GetNumChatsWithUnreadPriorityMessages(IntPtr instancePtr) { }

	// RVA: 0x59B500 Offset: 0x599B00 VA: 0x18059B500
	public static extern void ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x59DCF0 Offset: 0x59C2F0 VA: 0x18059DCF0
	public static extern bool ISteamFriends_RegisterProtocolInOverlayBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchProtocol) { }

	// RVA: 0x59B3A0 Offset: 0x5999A0 VA: 0x18059B3A0
	public static extern void ISteamFriends_ActivateGameOverlayInviteDialogConnectString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectString) { }

	// RVA: 0x59DF40 Offset: 0x59C540 VA: 0x18059DF40
	public static extern ulong ISteamFriends_RequestEquippedProfileItems(IntPtr instancePtr, CSteamID steamID) { }

	// RVA: 0x59B8C0 Offset: 0x599EC0 VA: 0x18059B8C0
	public static extern bool ISteamFriends_BHasEquippedProfileItem(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType) { }

	// RVA: 0x59D3D0 Offset: 0x59B9D0 VA: 0x18059D3D0
	public static extern IntPtr ISteamFriends_GetProfileItemPropertyString(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	// RVA: 0x59D480 Offset: 0x59BA80 VA: 0x18059D480
	public static extern uint ISteamFriends_GetProfileItemPropertyUint(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop) { }

	// RVA: 0x5A0E80 Offset: 0x59F480 VA: 0x1805A0E80
	public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct) { }

	// RVA: 0x5A08F0 Offset: 0x59EEF0 VA: 0x1805A08F0
	public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription) { }

	// RVA: 0x5A0D20 Offset: 0x59F320 VA: 0x1805A0D20
	public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir) { }

	// RVA: 0x5A0790 Offset: 0x59ED90 VA: 0x1805A0790
	public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated) { }

	// RVA: 0x5A03B0 Offset: 0x59E9B0 VA: 0x1805A03B0
	public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken) { }

	// RVA: 0x5A0330 Offset: 0x59E930 VA: 0x1805A0330
	public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr) { }

	// RVA: 0x5A02B0 Offset: 0x59E8B0 VA: 0x1805A02B0
	public static extern void ISteamGameServer_LogOff(IntPtr instancePtr) { }

	// RVA: 0x59F8F0 Offset: 0x59DEF0 VA: 0x18059F8F0
	public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr) { }

	// RVA: 0x59F970 Offset: 0x59DF70 VA: 0x18059F970
	public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr) { }

	// RVA: 0x5A0160 Offset: 0x59E760 VA: 0x1805A0160
	public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr) { }

	// RVA: 0x5A12F0 Offset: 0x59F8F0 VA: 0x1805A12F0
	public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr) { }

	// RVA: 0x5A0C90 Offset: 0x59F290 VA: 0x1805A0C90
	public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax) { }

	// RVA: 0x5A0700 Offset: 0x59ED00 VA: 0x1805A0700
	public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers) { }

	// RVA: 0x5A1020 Offset: 0x59F620 VA: 0x1805A1020
	public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName) { }

	// RVA: 0x5A0BC0 Offset: 0x59F1C0 VA: 0x1805A0BC0
	public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName) { }

	// RVA: 0x5A0DF0 Offset: 0x59F3F0 VA: 0x1805A0DF0
	public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected) { }

	// RVA: 0x5A10F0 Offset: 0x59F6F0 VA: 0x1805A10F0
	public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort) { }

	// RVA: 0x5A1180 Offset: 0x59F780 VA: 0x1805A1180
	public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName) { }

	// RVA: 0x59FC20 Offset: 0x59E220 VA: 0x18059FC20
	public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr) { }

	// RVA: 0x5A0A90 Offset: 0x59F090 VA: 0x1805A0A90
	public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue) { }

	// RVA: 0x5A09C0 Offset: 0x59EFC0 VA: 0x1805A09C0
	public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags) { }

	// RVA: 0x5A0820 Offset: 0x59EE20 VA: 0x1805A0820
	public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData) { }

	// RVA: 0x5A0F50 Offset: 0x59F550 VA: 0x1805A0F50
	public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion) { }

	// RVA: 0x5A0670 Offset: 0x59EC70 VA: 0x1805A0670
	public static extern void ISteamGameServer_SetAdvertiseServerActive(IntPtr instancePtr, bool bActive) { }

	// RVA: 0x59FE40 Offset: 0x59E440 VA: 0x18059FE40
	public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSnid) { }

	// RVA: 0x59FAE0 Offset: 0x59E0E0 VA: 0x18059FAE0
	public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	// RVA: 0x59FDB0 Offset: 0x59E3B0 VA: 0x18059FDB0
	public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID) { }

	// RVA: 0x59FB90 Offset: 0x59E190 VA: 0x18059FB90
	public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket) { }

	// RVA: 0x5A1250 Offset: 0x59F850 VA: 0x1805A1250
	public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID) { }

	// RVA: 0x5A0480 Offset: 0x59EA80 VA: 0x1805A0480
	public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup) { }

	// RVA: 0x59FF00 Offset: 0x59E500 VA: 0x18059FF00
	public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr) { }

	// RVA: 0x5A00E0 Offset: 0x59E6E0 VA: 0x1805A00E0
	public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr) { }

	// RVA: 0x5A0040 Offset: 0x59E640 VA: 0x1805A0040
	public static extern SteamIPAddress_t ISteamGameServer_GetPublicIP(IntPtr instancePtr) { }

	// RVA: 0x5A01E0 Offset: 0x59E7E0 VA: 0x1805A01E0
	public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort) { }

	// RVA: 0x59FF80 Offset: 0x59E580 VA: 0x18059FF80
	public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) { }

	// RVA: 0x59F860 Offset: 0x59DE60 VA: 0x18059F860
	public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan) { }

	// RVA: 0x59FCA0 Offset: 0x59E2A0 VA: 0x18059FCA0
	public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer) { }

	// RVA: 0x5A0520 Offset: 0x59EB20 VA: 0x1805A0520
	public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) { }

	// RVA: 0x59FD30 Offset: 0x59E330 VA: 0x18059FD30
	public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr) { }

	// RVA: 0x5A05E0 Offset: 0x59EBE0 VA: 0x1805A05E0
	public static extern void ISteamGameServer_SendUserDisconnect_DEPRECATED(IntPtr instancePtr, CSteamID steamIDUser) { }

	// RVA: 0x59F9F0 Offset: 0x59DFF0 VA: 0x18059F9F0
	public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore) { }

	// RVA: 0x59F360 Offset: 0x59D960 VA: 0x18059F360
	public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	// RVA: 0x59F270 Offset: 0x59D870 VA: 0x18059F270
	public static extern bool ISteamGameServerStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData) { }

	// RVA: 0x59F180 Offset: 0x59D780 VA: 0x18059F180
	public static extern bool ISteamGameServerStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData) { }

	// RVA: 0x59F070 Offset: 0x59D670 VA: 0x18059F070
	public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved) { }

	// RVA: 0x59F5D0 Offset: 0x59DBD0 VA: 0x18059F5D0
	public static extern bool ISteamGameServerStats_SetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData) { }

	// RVA: 0x59F4D0 Offset: 0x59DAD0 VA: 0x18059F4D0
	public static extern bool ISteamGameServerStats_SetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData) { }

	// RVA: 0x59F750 Offset: 0x59DD50 VA: 0x18059F750
	public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength) { }

	// RVA: 0x59F3F0 Offset: 0x59D9F0 VA: 0x18059F3F0
	public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName) { }

	// RVA: 0x59EF90 Offset: 0x59D590 VA: 0x18059EF90
	public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName) { }

	// RVA: 0x59F6C0 Offset: 0x59DCC0 VA: 0x18059F6C0
	public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	// RVA: 0x5A1B70 Offset: 0x5A0170 VA: 0x1805A1B70
	public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr) { }

	// RVA: 0x5A2BE0 Offset: 0x5A11E0 VA: 0x1805A2BE0
	public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr) { }

	// RVA: 0x5A15F0 Offset: 0x59FBF0 VA: 0x1805A15F0
	public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS) { }

	// RVA: 0x5A24A0 Offset: 0x5A0AA0 VA: 0x1805A24A0
	public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A1E80 Offset: 0x5A0480 VA: 0x1805A1E80
	public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData) { }

	// RVA: 0x5A2AA0 Offset: 0x5A10A0 VA: 0x1805A2AA0
	public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) { }

	// RVA: 0x5A2CF0 Offset: 0x5A12F0 VA: 0x1805A2CF0
	public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A2410 Offset: 0x5A0A10 VA: 0x1805A2410
	public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A1A50 Offset: 0x5A0050 VA: 0x1805A1A50
	public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A1AE0 Offset: 0x5A00E0 VA: 0x1805A1AE0
	public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A1370 Offset: 0x59F970 VA: 0x1805A1370
	public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue) { }

	// RVA: 0x5A1730 Offset: 0x59FD30 VA: 0x1805A1730
	public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript) { }

	// RVA: 0x5A21B0 Offset: 0x5A07B0 VA: 0x1805A21B0
	public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0x5A2070 Offset: 0x5A0670 VA: 0x1805A2070
	public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0x5A1FD0 Offset: 0x5A05D0 VA: 0x1805A1FD0
	public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0x5A2110 Offset: 0x5A0710 VA: 0x1805A2110
	public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y) { }

	// RVA: 0x5A2250 Offset: 0x5A0850 VA: 0x1805A2250
	public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta) { }

	// RVA: 0x5A1D30 Offset: 0x5A0330 VA: 0x1805A1D30
	public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey) { }

	// RVA: 0x5A1DE0 Offset: 0x5A03E0 VA: 0x1805A1DE0
	public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	// RVA: 0x5A1C90 Offset: 0x5A0290 VA: 0x1805A1C90
	public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	// RVA: 0x5A28B0 Offset: 0x5A0EB0 VA: 0x1805A28B0
	public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	// RVA: 0x5A2B40 Offset: 0x5A1140 VA: 0x1805A2B40
	public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	// RVA: 0x5A2950 Offset: 0x5A0F50 VA: 0x1805A2950
	public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) { }

	// RVA: 0x5A2D80 Offset: 0x5A1380 VA: 0x1805A2D80
	public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A1560 Offset: 0x59FB60 VA: 0x1805A1560
	public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A2380 Offset: 0x5A0980 VA: 0x1805A2380
	public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A18B0 Offset: 0x59FEB0 VA: 0x1805A18B0
	public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse) { }

	// RVA: 0x5A2C60 Offset: 0x5A1260 VA: 0x1805A2C60
	public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A19B0 Offset: 0x59FFB0 VA: 0x1805A19B0
	public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y) { }

	// RVA: 0x5A25D0 Offset: 0x5A0BD0 VA: 0x1805A25D0
	public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly) { }

	// RVA: 0x5A29F0 Offset: 0x5A0FF0 VA: 0x1805A29F0
	public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) { }

	// RVA: 0x5A2530 Offset: 0x5A0B30 VA: 0x1805A2530
	public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode) { }

	// RVA: 0x5A2810 Offset: 0x5A0E10 VA: 0x1805A2810
	public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling) { }

	// RVA: 0x5A22F0 Offset: 0x5A08F0 VA: 0x1805A22F0
	public static extern void ISteamHTMLSurface_OpenDeveloperTools(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	// RVA: 0x5A14C0 Offset: 0x59FAC0 VA: 0x1805A14C0
	public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed) { }

	// RVA: 0x5A1BF0 Offset: 0x5A01F0 VA: 0x1805A1BF0
	public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult) { }

	// RVA: 0x5A1810 Offset: 0x59FE10 VA: 0x1805A1810
	public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) { }

	// RVA: 0x5A2EA0 Offset: 0x5A14A0 VA: 0x1805A2EA0
	public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL) { }

	// RVA: 0x5A3AC0 Offset: 0x5A20C0 VA: 0x1805A3AC0
	public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue) { }

	// RVA: 0x5A3EA0 Offset: 0x5A24A0 VA: 0x1805A3EA0
	public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	// RVA: 0x5A3D50 Offset: 0x5A2350 VA: 0x1805A3D50
	public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue) { }

	// RVA: 0x5A3C00 Offset: 0x5A2200 VA: 0x1805A3C00
	public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue) { }

	// RVA: 0x5A37C0 Offset: 0x5A1DC0 VA: 0x1805A37C0
	public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0x5A3720 Offset: 0x5A1D20 VA: 0x1805A3720
	public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0x5A2F80 Offset: 0x5A1580 VA: 0x1805A2F80
	public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	// RVA: 0x5A3570 Offset: 0x5A1B70 VA: 0x1805A3570
	public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	// RVA: 0x5A32B0 Offset: 0x5A18B0 VA: 0x1805A32B0
	public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize) { }

	// RVA: 0x5A33A0 Offset: 0x5A19A0 VA: 0x1805A33A0
	public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize) { }

	// RVA: 0x5A3210 Offset: 0x5A1810 VA: 0x1805A3210
	public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize) { }

	// RVA: 0x5A3160 Offset: 0x5A1760 VA: 0x1805A3160
	public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0x5A34B0 Offset: 0x5A1AB0 VA: 0x1805A34B0
	public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0x5A3690 Offset: 0x5A1C90 VA: 0x1805A3690
	public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	// RVA: 0x5A3010 Offset: 0x5A1610 VA: 0x1805A3010
	public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut) { }

	// RVA: 0x5A3F40 Offset: 0x5A2540 VA: 0x1805A3F40
	public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen) { }

	// RVA: 0x5A2E10 Offset: 0x5A1410 VA: 0x1805A2E10
	public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify) { }

	// RVA: 0x5A3600 Offset: 0x5A1C00 VA: 0x1805A3600
	public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0x5A3860 Offset: 0x5A1E60 VA: 0x1805A3860
	public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie) { }

	// RVA: 0x5A3B60 Offset: 0x5A2160 VA: 0x1805A3B60
	public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0x5A40F0 Offset: 0x5A26F0 VA: 0x1805A40F0
	public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo) { }

	// RVA: 0x5A4050 Offset: 0x5A2650 VA: 0x1805A4050
	public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	// RVA: 0x5A3A20 Offset: 0x5A2020 VA: 0x1805A3A20
	public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds) { }

	// RVA: 0x5A30B0 Offset: 0x5A16B0 VA: 0x1805A30B0
	public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }

	// RVA: 0x5A5740 Offset: 0x5A3D40 VA: 0x1805A5740
	public static extern bool ISteamInput_Init(IntPtr instancePtr, bool bExplicitlyCallRunFrame) { }

	// RVA: 0x5A5CB0 Offset: 0x5A42B0 VA: 0x1805A5CB0
	public static extern bool ISteamInput_Shutdown(IntPtr instancePtr) { }

	// RVA: 0x5A5A80 Offset: 0x5A4080 VA: 0x1805A5A80
	public static extern bool ISteamInput_SetInputActionManifestFilePath(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchInputActionManifestAbsolutePath) { }

	// RVA: 0x5A5950 Offset: 0x5A3F50 VA: 0x1805A5950
	public static extern void ISteamInput_RunFrame(IntPtr instancePtr, bool bReservedValue) { }

	// RVA: 0x5A4390 Offset: 0x5A2990 VA: 0x1805A4390
	public static extern bool ISteamInput_BWaitForData(IntPtr instancePtr, bool bWaitForever, uint unTimeout) { }

	// RVA: 0x5A4310 Offset: 0x5A2910 VA: 0x1805A4310
	public static extern bool ISteamInput_BNewDataAvailable(IntPtr instancePtr) { }

	// RVA: 0x5A4B00 Offset: 0x5A3100 VA: 0x1805A4B00
	public static extern int ISteamInput_GetConnectedControllers(IntPtr instancePtr, [In] [Out] InputHandle_t[] handlesOut) { }

	// RVA: 0x5A4600 Offset: 0x5A2C00 VA: 0x1805A4600
	public static extern void ISteamInput_EnableDeviceCallbacks(IntPtr instancePtr) { }

	// RVA: 0x5A4560 Offset: 0x5A2B60 VA: 0x1805A4560
	public static extern void ISteamInput_EnableActionEventCallbacks(IntPtr instancePtr, SteamInputActionEventCallbackPointer pCallback) { }

	// RVA: 0x5A4720 Offset: 0x5A2D20 VA: 0x1805A4720
	public static extern ulong ISteamInput_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName) { }

	// RVA: 0x5A4270 Offset: 0x5A2870 VA: 0x1805A4270
	public static extern void ISteamInput_ActivateActionSet(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) { }

	// RVA: 0x5A4C30 Offset: 0x5A3230 VA: 0x1805A4C30
	public static extern ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle) { }

	// RVA: 0x5A41D0 Offset: 0x5A27D0 VA: 0x1805A41D0
	public static extern void ISteamInput_ActivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	// RVA: 0x5A4430 Offset: 0x5A2A30 VA: 0x1805A4430
	public static extern void ISteamInput_DeactivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	// RVA: 0x5A44D0 Offset: 0x5A2AD0 VA: 0x1805A44D0
	public static extern void ISteamInput_DeactivateAllActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle) { }

	// RVA: 0x5A4800 Offset: 0x5A2E00 VA: 0x1805A4800
	public static extern int ISteamInput_GetActiveActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle, [In] [Out] InputActionSetHandle_t[] handlesOut) { }

	// RVA: 0x5A4E10 Offset: 0x5A3410 VA: 0x1805A4E10
	public static extern ulong ISteamInput_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName) { }

	// RVA: 0x5A4D70 Offset: 0x5A3370 VA: 0x1805A4D70
	public static extern InputDigitalActionData_t ISteamInput_GetDigitalActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) { }

	// RVA: 0x5A4EF0 Offset: 0x5A34F0 VA: 0x1805A4EF0
	public static extern int ISteamInput_GetDigitalActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, [In] [Out] EInputActionOrigin[] originsOut) { }

	// RVA: 0x5A5620 Offset: 0x5A3C20 VA: 0x1805A5620
	public static extern IntPtr ISteamInput_GetStringForDigitalActionName(IntPtr instancePtr, InputDigitalActionHandle_t eActionHandle) { }

	// RVA: 0x5A4960 Offset: 0x5A2F60 VA: 0x1805A4960
	public static extern ulong ISteamInput_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName) { }

	// RVA: 0x5A48A0 Offset: 0x5A2EA0 VA: 0x1805A48A0
	public static extern InputAnalogActionData_t ISteamInput_GetAnalogActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) { }

	// RVA: 0x5A4A40 Offset: 0x5A3040 VA: 0x1805A4A40
	public static extern int ISteamInput_GetAnalogActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, [In] [Out] EInputActionOrigin[] originsOut) { }

	// RVA: 0x5A5160 Offset: 0x5A3760 VA: 0x1805A5160
	public static extern IntPtr ISteamInput_GetGlyphPNGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags) { }

	// RVA: 0x5A5200 Offset: 0x5A3800 VA: 0x1805A5200
	public static extern IntPtr ISteamInput_GetGlyphSVGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, uint unFlags) { }

	// RVA: 0x5A5040 Offset: 0x5A3640 VA: 0x1805A5040
	public static extern IntPtr ISteamInput_GetGlyphForActionOrigin_Legacy(IntPtr instancePtr, EInputActionOrigin eOrigin) { }

	// RVA: 0x5A5500 Offset: 0x5A3B00 VA: 0x1805A5500
	public static extern IntPtr ISteamInput_GetStringForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin) { }

	// RVA: 0x5A5590 Offset: 0x5A3B90 VA: 0x1805A5590
	public static extern IntPtr ISteamInput_GetStringForAnalogActionName(IntPtr instancePtr, InputAnalogActionHandle_t eActionHandle) { }

	// RVA: 0x5A5D30 Offset: 0x5A4330 VA: 0x1805A5D30
	public static extern void ISteamInput_StopAnalogActionMomentum(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) { }

	// RVA: 0x5A5330 Offset: 0x5A3930 VA: 0x1805A5330
	public static extern InputMotionData_t ISteamInput_GetMotionData(IntPtr instancePtr, InputHandle_t inputHandle) { }

	// RVA: 0x5A6010 Offset: 0x5A4610 VA: 0x1805A6010
	public static extern void ISteamInput_TriggerVibration(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) { }

	// RVA: 0x5A5F40 Offset: 0x5A4540 VA: 0x1805A5F40
	public static extern void ISteamInput_TriggerVibrationExtended(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) { }

	// RVA: 0x5A5E70 Offset: 0x5A4470 VA: 0x1805A5E70
	public static extern void ISteamInput_TriggerSimpleHapticEvent(IntPtr instancePtr, InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) { }

	// RVA: 0x5A5B60 Offset: 0x5A4160 VA: 0x1805A5B60
	public static extern void ISteamInput_SetLEDColor(IntPtr instancePtr, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) { }

	// RVA: 0x5A57D0 Offset: 0x5A3DD0 VA: 0x1805A57D0
	public static extern void ISteamInput_Legacy_TriggerHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) { }

	// RVA: 0x5A5880 Offset: 0x5A3E80 VA: 0x1805A5880
	public static extern void ISteamInput_Legacy_TriggerRepeatedHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) { }

	// RVA: 0x5A5C20 Offset: 0x5A4220 VA: 0x1805A5C20
	public static extern bool ISteamInput_ShowBindingPanel(IntPtr instancePtr, InputHandle_t inputHandle) { }

	// RVA: 0x5A52A0 Offset: 0x5A38A0 VA: 0x1805A52A0
	public static extern ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle) { }

	// RVA: 0x5A4BA0 Offset: 0x5A31A0 VA: 0x1805A4BA0
	public static extern ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex) { }

	// RVA: 0x5A4FB0 Offset: 0x5A35B0 VA: 0x1805A4FB0
	public static extern int ISteamInput_GetGamepadIndexForController(IntPtr instancePtr, InputHandle_t ulinputHandle) { }

	// RVA: 0x5A56B0 Offset: 0x5A3CB0 VA: 0x1805A56B0
	public static extern IntPtr ISteamInput_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin) { }

	// RVA: 0x5A50D0 Offset: 0x5A36D0 VA: 0x1805A50D0
	public static extern IntPtr ISteamInput_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin) { }

	// RVA: 0x5A4680 Offset: 0x5A2C80 VA: 0x1805A4680
	public static extern EInputActionOrigin ISteamInput_GetActionOriginFromXboxOrigin(IntPtr instancePtr, InputHandle_t inputHandle, EXboxOrigin eOrigin) { }

	// RVA: 0x5A5DD0 Offset: 0x5A43D0 VA: 0x1805A5DD0
	public static extern EInputActionOrigin ISteamInput_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) { }

	// RVA: 0x5A4CC0 Offset: 0x5A32C0 VA: 0x1805A4CC0
	public static extern bool ISteamInput_GetDeviceBindingRevision(IntPtr instancePtr, InputHandle_t inputHandle, out int pMajor, out int pMinor) { }

	// RVA: 0x5A53F0 Offset: 0x5A39F0 VA: 0x1805A53F0
	public static extern uint ISteamInput_GetRemotePlaySessionID(IntPtr instancePtr, InputHandle_t inputHandle) { }

	// RVA: 0x5A5480 Offset: 0x5A3A80 VA: 0x1805A5480
	public static extern ushort ISteamInput_GetSessionInputConfigurationSettings(IntPtr instancePtr) { }

	// RVA: 0x5A59E0 Offset: 0x5A3FE0 VA: 0x1805A59E0
	public static extern void ISteamInput_SetDualSenseTriggerEffect(IntPtr instancePtr, InputHandle_t inputHandle, IntPtr pParam) { }

	// RVA: 0x5A6E50 Offset: 0x5A5450 VA: 0x1805A6E50
	public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x5A6DA0 Offset: 0x5A53A0 VA: 0x1805A6DA0
	public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x5A6C80 Offset: 0x5A5280 VA: 0x1805A6C80
	public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x5A6EE0 Offset: 0x5A54E0 VA: 0x1805A6EE0
	public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x5A6220 Offset: 0x5A4820 VA: 0x1805A6220
	public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	// RVA: 0x5A6430 Offset: 0x5A4A30 VA: 0x1805A6430
	public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x5A66A0 Offset: 0x5A4CA0 VA: 0x1805A66A0
	public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x5A6A60 Offset: 0x5A5060 VA: 0x1805A6A60
	public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	// RVA: 0x5A73F0 Offset: 0x5A59F0 VA: 0x1805A73F0
	public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize) { }

	// RVA: 0x5A6370 Offset: 0x5A4970 VA: 0x1805A6370
	public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE) { }

	// RVA: 0x5A65D0 Offset: 0x5A4BD0 VA: 0x1805A65D0
	public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x5A6F70 Offset: 0x5A5570 VA: 0x1805A6F70
	public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x5A60C0 Offset: 0x5A46C0 VA: 0x1805A60C0
	public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	// RVA: 0x5A6160 Offset: 0x5A4760 VA: 0x1805A6160
	public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	// RVA: 0x5A62C0 Offset: 0x5A48C0 VA: 0x1805A62C0
	public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	// RVA: 0x5A64C0 Offset: 0x5A4AC0 VA: 0x1805A64C0
	public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] SteamItemInstanceID_t[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x5A7C50 Offset: 0x5A6250 VA: 0x1805A7C50
	public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	// RVA: 0x5A7370 Offset: 0x5A5970 VA: 0x1805A7370
	public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr) { }

	// RVA: 0x5A7D10 Offset: 0x5A6310 VA: 0x1805A7D10
	public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

	// RVA: 0x5A7B20 Offset: 0x5A6120 VA: 0x1805A7B20
	public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In] [Out] SteamItemInstanceID_t[] pArrayGive, [In] [Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In] [Out] SteamItemInstanceID_t[] pArrayGet, [In] [Out] uint[] pArrayGetQuantity, uint nArrayGetLength) { }

	// RVA: 0x5A70F0 Offset: 0x5A56F0 VA: 0x1805A70F0
	public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr) { }

	// RVA: 0x5A67F0 Offset: 0x5A4DF0 VA: 0x1805A67F0
	public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x5A68A0 Offset: 0x5A4EA0 VA: 0x1805A68A0
	public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x5A7260 Offset: 0x5A5860 VA: 0x1805A7260
	public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID) { }

	// RVA: 0x5A6730 Offset: 0x5A4D30 VA: 0x1805A6730
	public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In] [Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x5A7940 Offset: 0x5A5F40 VA: 0x1805A7940
	public static extern ulong ISteamInventory_StartPurchase(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x5A72F0 Offset: 0x5A58F0 VA: 0x1805A72F0
	public static extern ulong ISteamInventory_RequestPrices(IntPtr instancePtr) { }

	// RVA: 0x5A6C00 Offset: 0x5A5200 VA: 0x1805A6C00
	public static extern uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr) { }

	// RVA: 0x5A6B20 Offset: 0x5A5120 VA: 0x1805A6B20
	public static extern bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x5A69B0 Offset: 0x5A4FB0 VA: 0x1805A69B0
	public static extern bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	// RVA: 0x5A7A00 Offset: 0x5A6000 VA: 0x1805A7A00
	public static extern ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr) { }

	// RVA: 0x5A7170 Offset: 0x5A5770 VA: 0x1805A7170
	public static extern bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName) { }

	// RVA: 0x5A77D0 Offset: 0x5A5DD0 VA: 0x1805A77D0
	public static extern bool ISteamInventory_SetPropertyString(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, InteropHelp.UTF8StringHandle pchPropertyValue) { }

	// RVA: 0x5A74A0 Offset: 0x5A5AA0 VA: 0x1805A74A0
	public static extern bool ISteamInventory_SetPropertyBool(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, bool bValue) { }

	// RVA: 0x5A76C0 Offset: 0x5A5CC0 VA: 0x1805A76C0
	public static extern bool ISteamInventory_SetPropertyInt64(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, long nValue) { }

	// RVA: 0x5A75B0 Offset: 0x5A5BB0 VA: 0x1805A75B0
	public static extern bool ISteamInventory_SetPropertyFloat(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, float flValue) { }

	// RVA: 0x5A7A80 Offset: 0x5A6080 VA: 0x1805A7A80
	public static extern bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x5A7000 Offset: 0x5A5600 VA: 0x1805A7000
	public static extern bool ISteamInventory_InspectItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, InteropHelp.UTF8StringHandle pchItemToken) { }

	// RVA: 0x5A9020 Offset: 0x5A7620 VA: 0x1805A9020
	public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr) { }

	// RVA: 0x5A90A0 Offset: 0x5A76A0 VA: 0x1805A90A0
	public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x5A8870 Offset: 0x5A6E70 VA: 0x1805A8870
	public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x5A9AF0 Offset: 0x5A80F0 VA: 0x1805A9AF0
	public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x5A9C50 Offset: 0x5A8250 VA: 0x1805A9C50
	public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr) { }

	// RVA: 0x5A8D50 Offset: 0x5A7350 VA: 0x1805A8D50
	public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType) { }

	// RVA: 0x5A8BD0 Offset: 0x5A71D0 VA: 0x1805A8BD0
	public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) { }

	// RVA: 0x5A8AF0 Offset: 0x5A70F0 VA: 0x1805A8AF0
	public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo) { }

	// RVA: 0x5A8A60 Offset: 0x5A7060 VA: 0x1805A8A60
	public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable) { }

	// RVA: 0x5A89D0 Offset: 0x5A6FD0 VA: 0x1805A89D0
	public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter) { }

	// RVA: 0x5A8CC0 Offset: 0x5A72C0 VA: 0x1805A8CC0
	public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults) { }

	// RVA: 0x5A8940 Offset: 0x5A6F40 VA: 0x1805A8940
	public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5A9180 Offset: 0x5A7780 VA: 0x1805A9180
	public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby) { }

	// RVA: 0x5A8EA0 Offset: 0x5A74A0 VA: 0x1805A8EA0
	public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers) { }

	// RVA: 0x5A99D0 Offset: 0x5A7FD0 VA: 0x1805A99D0
	public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5A9A60 Offset: 0x5A8060 VA: 0x1805A9A60
	public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5A9930 Offset: 0x5A7F30 VA: 0x1805A9930
	public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee) { }

	// RVA: 0x5A98A0 Offset: 0x5A7EA0 VA: 0x1805A98A0
	public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5A95F0 Offset: 0x5A7BF0 VA: 0x1805A95F0
	public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember) { }

	// RVA: 0x5A9450 Offset: 0x5A7A50 VA: 0x1805A9450
	public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey) { }

	// RVA: 0x5A9E30 Offset: 0x5A8430 VA: 0x1805A9E30
	public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue) { }

	// RVA: 0x5A93C0 Offset: 0x5A79C0 VA: 0x1805A93C0
	public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5A92F0 Offset: 0x5A78F0 VA: 0x1805A92F0
	public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize) { }

	// RVA: 0x5A8F40 Offset: 0x5A7540 VA: 0x1805A8F40
	public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey) { }

	// RVA: 0x5A9690 Offset: 0x5A7C90 VA: 0x1805A9690
	public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey) { }

	// RVA: 0x5AA0E0 Offset: 0x5A86E0 VA: 0x1805AA0E0
	public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue) { }

	// RVA: 0x5A9CD0 Offset: 0x5A82D0 VA: 0x1805A9CD0
	public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody) { }

	// RVA: 0x5A9210 Offset: 0x5A7810 VA: 0x1805A9210
	public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType) { }

	// RVA: 0x5A9BC0 Offset: 0x5A81C0 VA: 0x1805A9BC0
	public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5A9F80 Offset: 0x5A8580 VA: 0x1805A9F80
	public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) { }

	// RVA: 0x5A9530 Offset: 0x5A7B30 VA: 0x1805A9530
	public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) { }

	// RVA: 0x5AA230 Offset: 0x5A8830 VA: 0x1805AA230
	public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers) { }

	// RVA: 0x5A9780 Offset: 0x5A7D80 VA: 0x1805A9780
	public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5AA370 Offset: 0x5A8970 VA: 0x1805AA370
	public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType) { }

	// RVA: 0x5AA040 Offset: 0x5A8640 VA: 0x1805AA040
	public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable) { }

	// RVA: 0x5A9810 Offset: 0x5A7E10 VA: 0x1805A9810
	public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby) { }

	// RVA: 0x5AA2D0 Offset: 0x5A88D0 VA: 0x1805AA2D0
	public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner) { }

	// RVA: 0x5A9D90 Offset: 0x5A8390 VA: 0x1805A9D90
	public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) { }

	// RVA: 0x5A85C0 Offset: 0x5A6BC0 VA: 0x1805A85C0
	public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A8670 Offset: 0x5A6C70 VA: 0x1805A8670
	public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A8460 Offset: 0x5A6A60 VA: 0x1805A8460
	public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A83B0 Offset: 0x5A69B0 VA: 0x1805A83B0
	public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A8510 Offset: 0x5A6B10 VA: 0x1805A8510
	public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A8710 Offset: 0x5A6D10 VA: 0x1805A8710
	public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A8320 Offset: 0x5A6920 VA: 0x1805A8320
	public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest) { }

	// RVA: 0x5A7F60 Offset: 0x5A6560 VA: 0x1805A7F60
	public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x5A7DB0 Offset: 0x5A63B0 VA: 0x1805A7DB0
	public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest) { }

	// RVA: 0x5A81F0 Offset: 0x5A67F0 VA: 0x1805A81F0
	public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest) { }

	// RVA: 0x5A8000 Offset: 0x5A6600 VA: 0x1805A8000
	public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest) { }

	// RVA: 0x5A7ED0 Offset: 0x5A64D0 VA: 0x1805A7ED0
	public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest) { }

	// RVA: 0x5A8280 Offset: 0x5A6880 VA: 0x1805A8280
	public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x5A8090 Offset: 0x5A6690 VA: 0x1805A8090
	public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A8140 Offset: 0x5A6740 VA: 0x1805A8140
	public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A87C0 Offset: 0x5A6DC0 VA: 0x1805A87C0
	public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	// RVA: 0x5A7E40 Offset: 0x5A6440 VA: 0x1805A7E40
	public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery) { }

	// RVA: 0x59E640 Offset: 0x59CC40 VA: 0x18059E640
	public static extern EGameSearchErrorCode_t ISteamGameSearch_AddGameSearchParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToFind, InteropHelp.UTF8StringHandle pchValuesToFind) { }

	// RVA: 0x59EC10 Offset: 0x59D210 VA: 0x18059EC10
	public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameWithLobby(IntPtr instancePtr, CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) { }

	// RVA: 0x59EB70 Offset: 0x59D170 VA: 0x18059EB70
	public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameSolo(IntPtr instancePtr, int nPlayerMin, int nPlayerMax) { }

	// RVA: 0x59E5C0 Offset: 0x59CBC0 VA: 0x18059E5C0
	public static extern EGameSearchErrorCode_t ISteamGameSearch_AcceptGame(IntPtr instancePtr) { }

	// RVA: 0x59E800 Offset: 0x59CE00 VA: 0x18059E800
	public static extern EGameSearchErrorCode_t ISteamGameSearch_DeclineGame(IntPtr instancePtr) { }

	// RVA: 0x59EAC0 Offset: 0x59D0C0 VA: 0x18059EAC0
	public static extern EGameSearchErrorCode_t ISteamGameSearch_RetrieveConnectionDetails(IntPtr instancePtr, CSteamID steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails) { }

	// RVA: 0x59E880 Offset: 0x59CE80 VA: 0x18059E880
	public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGameSearch(IntPtr instancePtr) { }

	// RVA: 0x59EDA0 Offset: 0x59D3A0 VA: 0x18059EDA0
	public static extern EGameSearchErrorCode_t ISteamGameSearch_SetGameHostParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue) { }

	// RVA: 0x59ECC0 Offset: 0x59D2C0 VA: 0x18059ECC0
	public static extern EGameSearchErrorCode_t ISteamGameSearch_SetConnectionDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectionDetails, int cubConnectionDetails) { }

	// RVA: 0x59EA20 Offset: 0x59D020 VA: 0x18059EA20
	public static extern EGameSearchErrorCode_t ISteamGameSearch_RequestPlayersForGame(IntPtr instancePtr, int nPlayerMin, int nPlayerMax, int nMaxTeamSize) { }

	// RVA: 0x59E990 Offset: 0x59CF90 VA: 0x18059E990
	public static extern EGameSearchErrorCode_t ISteamGameSearch_HostConfirmGameStart(IntPtr instancePtr, ulong ullUniqueGameID) { }

	// RVA: 0x59E780 Offset: 0x59CD80 VA: 0x18059E780
	public static extern EGameSearchErrorCode_t ISteamGameSearch_CancelRequestPlayersForGame(IntPtr instancePtr) { }

	// RVA: 0x59EEE0 Offset: 0x59D4E0 VA: 0x18059EEE0
	public static extern EGameSearchErrorCode_t ISteamGameSearch_SubmitPlayerResult(IntPtr instancePtr, ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) { }

	// RVA: 0x59E900 Offset: 0x59CF00 VA: 0x18059E900
	public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGame(IntPtr instancePtr, ulong ullUniqueGameID) { }

	// RVA: 0x5B1A00 Offset: 0x5B0000 VA: 0x1805B1A00
	public static extern uint ISteamParties_GetNumActiveBeacons(IntPtr instancePtr) { }

	// RVA: 0x5B17E0 Offset: 0x5AFDE0 VA: 0x1805B17E0
	public static extern ulong ISteamParties_GetBeaconByIndex(IntPtr instancePtr, uint unIndex) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870
	public static extern bool ISteamParties_GetBeaconDetails(IntPtr instancePtr, PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata) { }

	// RVA: 0x5B1B10 Offset: 0x5B0110 VA: 0x1805B1B10
	public static extern ulong ISteamParties_JoinParty(IntPtr instancePtr, PartyBeaconID_t ulBeaconID) { }

	// RVA: 0x5B1A80 Offset: 0x5B0080 VA: 0x1805B1A80
	public static extern bool ISteamParties_GetNumAvailableBeaconLocations(IntPtr instancePtr, out uint puNumLocations) { }

	// RVA: 0x5B1730 Offset: 0x5AFD30 VA: 0x1805B1730
	public static extern bool ISteamParties_GetAvailableBeaconLocations(IntPtr instancePtr, [In] [Out] SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) { }

	// RVA: 0x5B1530 Offset: 0x5AFB30 VA: 0x1805B1530
	public static extern ulong ISteamParties_CreateBeacon(IntPtr instancePtr, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, InteropHelp.UTF8StringHandle pchConnectString, InteropHelp.UTF8StringHandle pchMetadata) { }

	// RVA: 0x5B1BA0 Offset: 0x5B01A0 VA: 0x1805B1BA0
	public static extern void ISteamParties_OnReservationCompleted(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	// RVA: 0x5B13F0 Offset: 0x5AF9F0 VA: 0x1805B13F0
	public static extern void ISteamParties_CancelReservation(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	// RVA: 0x5B1490 Offset: 0x5AFA90 VA: 0x1805B1490
	public static extern ulong ISteamParties_ChangeNumOpenSlots(IntPtr instancePtr, PartyBeaconID_t ulBeacon, uint unOpenSlots) { }

	// RVA: 0x5B16A0 Offset: 0x5AFCA0 VA: 0x1805B16A0
	public static extern bool ISteamParties_DestroyBeacon(IntPtr instancePtr, PartyBeaconID_t ulBeacon) { }

	// RVA: 0x5B1940 Offset: 0x5AFF40 VA: 0x1805B1940
	public static extern bool ISteamParties_GetBeaconLocationData(IntPtr instancePtr, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut) { }

	// RVA: 0x5AB760 Offset: 0x5A9D60 VA: 0x1805AB760
	public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr) { }

	// RVA: 0x5AB7E0 Offset: 0x5A9DE0 VA: 0x1805AB7E0
	public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr) { }

	// RVA: 0x5AB860 Offset: 0x5A9E60 VA: 0x1805AB860
	public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr) { }

	// RVA: 0x5ABAE0 Offset: 0x5AA0E0 VA: 0x1805ABAE0
	public static extern void ISteamMusic_Play(IntPtr instancePtr) { }

	// RVA: 0x5AB960 Offset: 0x5A9F60 VA: 0x1805AB960
	public static extern void ISteamMusic_Pause(IntPtr instancePtr) { }

	// RVA: 0x5ABA60 Offset: 0x5AA060 VA: 0x1805ABA60
	public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr) { }

	// RVA: 0x5AB9E0 Offset: 0x5A9FE0 VA: 0x1805AB9E0
	public static extern void ISteamMusic_PlayNext(IntPtr instancePtr) { }

	// RVA: 0x5ABB60 Offset: 0x5AA160 VA: 0x1805ABB60
	public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume) { }

	// RVA: 0x5AB8E0 Offset: 0x5A9EE0 VA: 0x1805AB8E0
	public static extern float ISteamMusic_GetVolume(IntPtr instancePtr) { }

	// RVA: 0x5AAC90 Offset: 0x5A9290 VA: 0x1805AAC90
	public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName) { }

	// RVA: 0x5AA6B0 Offset: 0x5A8CB0 VA: 0x1805AA6B0
	public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr) { }

	// RVA: 0x5AA4A0 Offset: 0x5A8AA0 VA: 0x1805AA4A0
	public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr) { }

	// RVA: 0x5AA410 Offset: 0x5A8A10 VA: 0x1805AA410
	public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AAF90 Offset: 0x5A9590 VA: 0x1805AAF90
	public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName) { }

	// RVA: 0x5AB070 Offset: 0x5A9670 VA: 0x1805AB070
	public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength) { }

	// RVA: 0x5AA850 Offset: 0x5A8E50 VA: 0x1805AA850
	public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AA7C0 Offset: 0x5A8DC0 VA: 0x1805AA7C0
	public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AAA00 Offset: 0x5A9000 VA: 0x1805AAA00
	public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AA730 Offset: 0x5A8D30 VA: 0x1805AA730
	public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AA970 Offset: 0x5A8F70 VA: 0x1805AA970
	public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AA8E0 Offset: 0x5A8EE0 VA: 0x1805AA8E0
	public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AB5B0 Offset: 0x5A9BB0 VA: 0x1805AB5B0
	public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus) { }

	// RVA: 0x5AB640 Offset: 0x5A9C40 VA: 0x1805AB640
	public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AB520 Offset: 0x5A9B20 VA: 0x1805AB520
	public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue) { }

	// RVA: 0x5AB6D0 Offset: 0x5A9CD0 VA: 0x1805AB6D0
	public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue) { }

	// RVA: 0x5AA630 Offset: 0x5A8C30 VA: 0x1805AA630
	public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr) { }

	// RVA: 0x5AA5A0 Offset: 0x5A8BA0 VA: 0x1805AA5A0
	public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable) { }

	// RVA: 0x5AB440 Offset: 0x5A9A40 VA: 0x1805AB440
	public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText) { }

	// RVA: 0x5AB3B0 Offset: 0x5A99B0 VA: 0x1805AB3B0
	public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue) { }

	// RVA: 0x5AB300 Offset: 0x5A9900 VA: 0x1805AB300
	public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength) { }

	// RVA: 0x5AA520 Offset: 0x5A8B20 VA: 0x1805AA520
	public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr) { }

	// RVA: 0x5AAC10 Offset: 0x5A9210 VA: 0x1805AAC10
	public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr) { }

	// RVA: 0x5AADF0 Offset: 0x5A93F0 VA: 0x1805AADF0
	public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr) { }

	// RVA: 0x5AB210 Offset: 0x5A9810 VA: 0x1805AB210
	public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText) { }

	// RVA: 0x5AAF00 Offset: 0x5A9500 VA: 0x1805AAF00
	public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID) { }

	// RVA: 0x5AAB90 Offset: 0x5A9190 VA: 0x1805AAB90
	public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr) { }

	// RVA: 0x5AAB10 Offset: 0x5A9110 VA: 0x1805AAB10
	public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr) { }

	// RVA: 0x5AAD70 Offset: 0x5A9370 VA: 0x1805AAD70
	public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr) { }

	// RVA: 0x5AB120 Offset: 0x5A9720 VA: 0x1805AB120
	public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText) { }

	// RVA: 0x5AAE70 Offset: 0x5A9470 VA: 0x1805AAE70
	public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID) { }

	// RVA: 0x5AAA90 Offset: 0x5A9090 VA: 0x1805AAA90
	public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr) { }

	// RVA: 0x5B0FE0 Offset: 0x5AF5E0 VA: 0x1805B0FE0
	public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel) { }

	// RVA: 0x5B0C20 Offset: 0x5AF220 VA: 0x1805B0C20
	public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel) { }

	// RVA: 0x5B0CC0 Offset: 0x5AF2C0 VA: 0x1805B0CC0
	public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel) { }

	// RVA: 0x5B01B0 Offset: 0x5AE7B0 VA: 0x1805B01B0
	public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote) { }

	// RVA: 0x5B0370 Offset: 0x5AE970 VA: 0x1805B0370
	public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote) { }

	// RVA: 0x5B02D0 Offset: 0x5AE8D0 VA: 0x1805B02D0
	public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel) { }

	// RVA: 0x5B08D0 Offset: 0x5AEED0 VA: 0x1805B08D0
	public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	// RVA: 0x5B0240 Offset: 0x5AE840 VA: 0x1805B0240
	public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow) { }

	// RVA: 0x5B04C0 Offset: 0x5AEAC0 VA: 0x1805B04C0
	public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	// RVA: 0x5B0590 Offset: 0x5AEB90 VA: 0x1805B0590
	public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	// RVA: 0x5B0400 Offset: 0x5AEA00 VA: 0x1805B0400
	public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	// RVA: 0x5B06F0 Offset: 0x5AECF0 VA: 0x1805B06F0
	public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0x5B0650 Offset: 0x5AEC50 VA: 0x1805B0650
	public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	// RVA: 0x5B0F20 Offset: 0x5AF520 VA: 0x1805B0F20
	public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable) { }

	// RVA: 0x5B0AD0 Offset: 0x5AF0D0 VA: 0x1805B0AD0
	public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize) { }

	// RVA: 0x5B0D90 Offset: 0x5AF390 VA: 0x1805B0D90
	public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	// RVA: 0x5B0B70 Offset: 0x5AF170 VA: 0x1805B0B70
	public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0x5B0E50 Offset: 0x5AF450 VA: 0x1805B0E50
	public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	// RVA: 0x5B0A00 Offset: 0x5AF000 VA: 0x1805B0A00
	public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	// RVA: 0x5B0790 Offset: 0x5AED90 VA: 0x1805B0790
	public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	// RVA: 0x5B0970 Offset: 0x5AEF70 VA: 0x1805B0970
	public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket) { }

	// RVA: 0x5B0840 Offset: 0x5AEE40 VA: 0x1805B0840
	public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket) { }

	// RVA: 0x5AC060 Offset: 0x5AA660 VA: 0x1805AC060
	public static extern EResult ISteamNetworkingMessages_SendMessageToUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

	// RVA: 0x5ABFB0 Offset: 0x5AA5B0 VA: 0x1805ABFB0
	public static extern int ISteamNetworkingMessages_ReceiveMessagesOnChannel(IntPtr instancePtr, int nLocalChannel, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x5ABBF0 Offset: 0x5AA1F0 VA: 0x1805ABBF0
	public static extern bool ISteamNetworkingMessages_AcceptSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0x5ABD20 Offset: 0x5AA320 VA: 0x1805ABD20
	public static extern bool ISteamNetworkingMessages_CloseSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote) { }

	// RVA: 0x5ABC80 Offset: 0x5AA280 VA: 0x1805ABC80
	public static extern bool ISteamNetworkingMessages_CloseChannelWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	// RVA: 0x5ABDB0 Offset: 0x5AA3B0 VA: 0x1805ABDB0
	public static extern ESteamNetworkingConnectionState ISteamNetworkingMessages_GetSessionConnectionInfo(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }

	// RVA: 0x5AC940 Offset: 0x5AAF40 VA: 0x1805AC940
	public static extern uint ISteamNetworkingSockets_CreateListenSocketIP(IntPtr instancePtr, ref SteamNetworkingIPAddr localAddress, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5AC4B0 Offset: 0x5AAAB0 VA: 0x1805AC4B0
	public static extern uint ISteamNetworkingSockets_ConnectByIPAddress(IntPtr instancePtr, ref SteamNetworkingIPAddr address, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5ACAF0 Offset: 0x5AB0F0 VA: 0x1805ACAF0
	public static extern uint ISteamNetworkingSockets_CreateListenSocketP2P(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5AC680 Offset: 0x5AAC80 VA: 0x1805AC680
	public static extern uint ISteamNetworkingSockets_ConnectP2P(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5AC120 Offset: 0x5AA720 VA: 0x1805AC120
	public static extern EResult ISteamNetworkingSockets_AcceptConnection(IntPtr instancePtr, HSteamNetConnection hConn) { }

	// RVA: 0x5AC240 Offset: 0x5AA840 VA: 0x1805AC240
	public static extern bool ISteamNetworkingSockets_CloseConnection(IntPtr instancePtr, HSteamNetConnection hPeer, int nReason, InteropHelp.UTF8StringHandle pszDebug, bool bEnableLinger) { }

	// RVA: 0x5AC350 Offset: 0x5AA950 VA: 0x1805AC350
	public static extern bool ISteamNetworkingSockets_CloseListenSocket(IntPtr instancePtr, HSteamListenSocket hSocket) { }

	// RVA: 0x5AE9E0 Offset: 0x5ACFE0 VA: 0x1805AE9E0
	public static extern bool ISteamNetworkingSockets_SetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer, long nUserData) { }

	// RVA: 0x5AD800 Offset: 0x5ABE00 VA: 0x1805AD800
	public static extern long ISteamNetworkingSockets_GetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer) { }

	// RVA: 0x5AE860 Offset: 0x5ACE60 VA: 0x1805AE860
	public static extern void ISteamNetworkingSockets_SetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, InteropHelp.UTF8StringHandle pszName) { }

	// RVA: 0x5AD380 Offset: 0x5AB980 VA: 0x1805AD380
	public static extern bool ISteamNetworkingSockets_GetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, IntPtr pszName, int nMaxLen) { }

	// RVA: 0x5AE5E0 Offset: 0x5ACBE0 VA: 0x1805AE5E0
	public static extern EResult ISteamNetworkingSockets_SendMessageToConnection(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	// RVA: 0x5AE6A0 Offset: 0x5ACCA0 VA: 0x1805AE6A0
	public static extern void ISteamNetworkingSockets_SendMessages(IntPtr instancePtr, int nMessages, [In] [Out] IntPtr[] pMessages, [In] [Out] long[] pOutMessageNumberOrResult) { }

	// RVA: 0x5ACF10 Offset: 0x5AB510 VA: 0x1805ACF10
	public static extern EResult ISteamNetworkingSockets_FlushMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn) { }

	// RVA: 0x5AE120 Offset: 0x5AC720 VA: 0x1805AE120
	public static extern int ISteamNetworkingSockets_ReceiveMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x5AD200 Offset: 0x5AB800 VA: 0x1805AD200
	public static extern bool ISteamNetworkingSockets_GetConnectionInfo(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	// RVA: 0x5AD430 Offset: 0x5ABA30 VA: 0x1805AD430
	public static extern EResult ISteamNetworkingSockets_GetConnectionRealTimeStatus(IntPtr instancePtr, HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	// RVA: 0x5AD890 Offset: 0x5ABE90 VA: 0x1805AD890
	public static extern int ISteamNetworkingSockets_GetDetailedConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pszBuf, int cbBuf) { }

	// RVA: 0x5ADEE0 Offset: 0x5AC4E0 VA: 0x1805ADEE0
	public static extern bool ISteamNetworkingSockets_GetListenSocketAddress(IntPtr instancePtr, HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	// RVA: 0x5ACC20 Offset: 0x5AB220 VA: 0x1805ACC20
	public static extern bool ISteamNetworkingSockets_CreateSocketPair(IntPtr instancePtr, out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	// RVA: 0x5AC3E0 Offset: 0x5AA9E0 VA: 0x1805AC3E0
	public static extern EResult ISteamNetworkingSockets_ConfigureConnectionLanes(IntPtr instancePtr, HSteamNetConnection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x5ADE50 Offset: 0x5AC450 VA: 0x1805ADE50
	public static extern bool ISteamNetworkingSockets_GetIdentity(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity) { }

	// RVA: 0x5AE0A0 Offset: 0x5AC6A0 VA: 0x1805AE0A0
	public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_InitAuthentication(IntPtr instancePtr) { }

	// RVA: 0x5ACFA0 Offset: 0x5AB5A0 VA: 0x1805ACFA0
	public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr instancePtr, out SteamNetAuthenticationStatus_t pDetails) { }

	// RVA: 0x5ACBA0 Offset: 0x5AB1A0 VA: 0x1805ACBA0
	public static extern uint ISteamNetworkingSockets_CreatePollGroup(IntPtr instancePtr) { }

	// RVA: 0x5ACCF0 Offset: 0x5AB2F0 VA: 0x1805ACCF0
	public static extern bool ISteamNetworkingSockets_DestroyPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x5AE940 Offset: 0x5ACF40 VA: 0x1805AE940
	public static extern bool ISteamNetworkingSockets_SetConnectionPollGroup(IntPtr instancePtr, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x5AE1D0 Offset: 0x5AC7D0 VA: 0x1805AE1D0
	public static extern int ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages) { }

	// RVA: 0x5AE330 Offset: 0x5AC930 VA: 0x1805AE330
	public static extern bool ISteamNetworkingSockets_ReceivedRelayAuthTicket(IntPtr instancePtr, IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0x5ACD80 Offset: 0x5AB380 VA: 0x1805ACD80
	public static extern int ISteamNetworkingSockets_FindRelayAuthTicketForServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	// RVA: 0x5AC740 Offset: 0x5AAD40 VA: 0x1805AC740
	public static extern uint ISteamNetworkingSockets_ConnectToHostedDedicatedServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5ADDD0 Offset: 0x5AC3D0 VA: 0x1805ADDD0
	public static extern ushort ISteamNetworkingSockets_GetHostedDedicatedServerPort(IntPtr instancePtr) { }

	// RVA: 0x5ADD50 Offset: 0x5AC350 VA: 0x1805ADD50
	public static extern uint ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(IntPtr instancePtr) { }

	// RVA: 0x5ADC40 Offset: 0x5AC240 VA: 0x1805ADC40
	public static extern EResult ISteamNetworkingSockets_GetHostedDedicatedServerAddress(IntPtr instancePtr, out SteamDatagramHostedAddress pRouting) { }

	// RVA: 0x5AC890 Offset: 0x5AAE90 VA: 0x1805AC890
	public static extern uint ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5ADB90 Offset: 0x5AC190 VA: 0x1805ADB90
	public static extern EResult ISteamNetworkingSockets_GetGameCoordinatorServerLogin(IntPtr instancePtr, IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	// RVA: 0x5AC5B0 Offset: 0x5AABB0 VA: 0x1805AC5B0
	public static extern uint ISteamNetworkingSockets_ConnectP2PCustomSignaling(IntPtr instancePtr, out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5AE280 Offset: 0x5AC880 VA: 0x1805AE280
	public static extern bool ISteamNetworkingSockets_ReceivedP2PCustomSignal(IntPtr instancePtr, IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	// RVA: 0x5AD100 Offset: 0x5AB700 VA: 0x1805AD100
	public static extern bool ISteamNetworkingSockets_GetCertificateRequest(IntPtr instancePtr, out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0x5AE760 Offset: 0x5ACD60 VA: 0x1805AE760
	public static extern bool ISteamNetworkingSockets_SetCertificate(IntPtr instancePtr, IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	// RVA: 0x5AE4D0 Offset: 0x5ACAD0 VA: 0x1805AE4D0
	public static extern void ISteamNetworkingSockets_ResetIdentity(IntPtr instancePtr, ref SteamNetworkingIdentity pIdentity) { }

	// RVA: 0x5AE560 Offset: 0x5ACB60 VA: 0x1805AE560
	public static extern void ISteamNetworkingSockets_RunCallbacks(IntPtr instancePtr) { }

	// RVA: 0x5AC1B0 Offset: 0x5AA7B0 VA: 0x1805AC1B0
	public static extern bool ISteamNetworkingSockets_BeginAsyncRequestFakeIP(IntPtr instancePtr, int nNumPorts) { }

	// RVA: 0x5AD930 Offset: 0x5ABF30 VA: 0x1805AD930
	public static extern void ISteamNetworkingSockets_GetFakeIP(IntPtr instancePtr, int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x5ACA40 Offset: 0x5AB040 VA: 0x1805ACA40
	public static extern uint ISteamNetworkingSockets_CreateListenSocketP2PFakeIP(IntPtr instancePtr, int idxFakePort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions) { }

	// RVA: 0x5ADFC0 Offset: 0x5AC5C0 VA: 0x1805ADFC0
	public static extern EResult ISteamNetworkingSockets_GetRemoteFakeIPForConnection(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	// RVA: 0x5AC800 Offset: 0x5AAE00 VA: 0x1805AC800
	public static extern IntPtr ISteamNetworkingSockets_CreateFakeUDPPort(IntPtr instancePtr, int idxFakeServerPort) { }

	// RVA: 0x5AEA80 Offset: 0x5AD080 VA: 0x1805AEA80
	public static extern IntPtr ISteamNetworkingUtils_AllocateMessage(IntPtr instancePtr, int cbAllocateBuffer) { }

	// RVA: 0x5AF8B0 Offset: 0x5ADEB0 VA: 0x1805AF8B0
	public static extern void ISteamNetworkingUtils_InitRelayNetworkAccess(IntPtr instancePtr) { }

	// RVA: 0x5AF720 Offset: 0x5ADD20 VA: 0x1805AF720
	public static extern ESteamNetworkingAvailability ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr instancePtr, out SteamRelayNetworkStatus_t pDetails) { }

	// RVA: 0x5AF2F0 Offset: 0x5AD8F0 VA: 0x1805AF2F0
	public static extern float ISteamNetworkingUtils_GetLocalPingLocation(IntPtr instancePtr, out SteamNetworkPingLocation_t result) { }

	// RVA: 0x5AED00 Offset: 0x5AD300 VA: 0x1805AED00
	public static extern int ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(IntPtr instancePtr, ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	// RVA: 0x5AEF10 Offset: 0x5AD510 VA: 0x1805AEF10
	public static extern int ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(IntPtr instancePtr, ref SteamNetworkPingLocation_t remoteLocation) { }

	// RVA: 0x5AEBA0 Offset: 0x5AD1A0 VA: 0x1805AEBA0
	public static extern void ISteamNetworkingUtils_ConvertPingLocationToString(IntPtr instancePtr, ref SteamNetworkPingLocation_t location, IntPtr pszBuf, int cchBufSize) { }

	// RVA: 0x5AFA60 Offset: 0x5AE060 VA: 0x1805AFA60
	public static extern bool ISteamNetworkingUtils_ParsePingLocationString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszString, out SteamNetworkPingLocation_t result) { }

	// RVA: 0x5AEB10 Offset: 0x5AD110 VA: 0x1805AEB10
	public static extern bool ISteamNetworkingUtils_CheckPingDataUpToDate(IntPtr instancePtr, float flMaxAgeSeconds) { }

	// RVA: 0x5AF590 Offset: 0x5ADB90 VA: 0x1805AF590
	public static extern int ISteamNetworkingUtils_GetPingToDataCenter(IntPtr instancePtr, SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	// RVA: 0x5AF1D0 Offset: 0x5AD7D0 VA: 0x1805AF1D0
	public static extern int ISteamNetworkingUtils_GetDirectPingToPOP(IntPtr instancePtr, SteamNetworkingPOPID popID) { }

	// RVA: 0x5AF470 Offset: 0x5ADA70 VA: 0x1805AF470
	public static extern int ISteamNetworkingUtils_GetPOPCount(IntPtr instancePtr) { }

	// RVA: 0x5AF4F0 Offset: 0x5ADAF0 VA: 0x1805AF4F0
	public static extern int ISteamNetworkingUtils_GetPOPList(IntPtr instancePtr, out SteamNetworkingPOPID list, int nListSz) { }

	// RVA: 0x5AF3F0 Offset: 0x5AD9F0 VA: 0x1805AF3F0
	public static extern long ISteamNetworkingUtils_GetLocalTimestamp(IntPtr instancePtr) { }

	// RVA: 0x5AFC60 Offset: 0x5AE260 VA: 0x1805AFC60
	public static extern void ISteamNetworkingUtils_SetDebugOutputFunction(IntPtr instancePtr, ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	// RVA: 0x5AF930 Offset: 0x5ADF30 VA: 0x1805AF930
	public static extern bool ISteamNetworkingUtils_IsFakeIPv4(IntPtr instancePtr, uint nIPv4) { }

	// RVA: 0x5AF260 Offset: 0x5AD860 VA: 0x1805AF260
	public static extern ESteamNetworkingFakeIPType ISteamNetworkingUtils_GetIPv4FakeIPType(IntPtr instancePtr, uint nIPv4) { }

	// RVA: 0x5AF630 Offset: 0x5ADC30 VA: 0x1805AF630
	public static extern EResult ISteamNetworkingUtils_GetRealIdentityForFakeIP(IntPtr instancePtr, ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	// RVA: 0x5AFBA0 Offset: 0x5AE1A0 VA: 0x1805AFBA0
	public static extern bool ISteamNetworkingUtils_SetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	// RVA: 0x5AF100 Offset: 0x5AD700 VA: 0x1805AF100
	public static extern ESteamNetworkingGetConfigValueResult ISteamNetworkingUtils_GetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	// RVA: 0x5AF060 Offset: 0x5AD660 VA: 0x1805AF060
	public static extern IntPtr ISteamNetworkingUtils_GetConfigValueInfo(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	// RVA: 0x5AF9C0 Offset: 0x5ADFC0 VA: 0x1805AF9C0
	public static extern ESteamNetworkingConfigValue ISteamNetworkingUtils_IterateGenericEditableConfigValues(IntPtr instancePtr, ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	// RVA: 0x5AFF10 Offset: 0x5AE510 VA: 0x1805AFF10
	public static extern void ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(IntPtr instancePtr, ref SteamNetworkingIPAddr addr, IntPtr buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x5AFDE0 Offset: 0x5AE3E0 VA: 0x1805AFDE0
	public static extern bool ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(IntPtr instancePtr, out SteamNetworkingIPAddr pAddr, InteropHelp.UTF8StringHandle pszStr) { }

	// RVA: 0x5AFD00 Offset: 0x5AE300 VA: 0x1805AFD00
	public static extern ESteamNetworkingFakeIPType ISteamNetworkingUtils_SteamNetworkingIPAddr_GetFakeIPType(IntPtr instancePtr, ref SteamNetworkingIPAddr addr) { }

	// RVA: 0x5B0100 Offset: 0x5AE700 VA: 0x1805B0100
	public static extern void ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(IntPtr instancePtr, ref SteamNetworkingIdentity identity, IntPtr buf, uint cbBuf) { }

	// RVA: 0x5B0010 Offset: 0x5AE610 VA: 0x1805B0010
	public static extern bool ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity, InteropHelp.UTF8StringHandle pszStr) { }

	// RVA: 0x5B12F0 Offset: 0x5AF8F0 VA: 0x1805B12F0
	public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr) { }

	// RVA: 0x5B1370 Offset: 0x5AF970 VA: 0x1805B1370
	public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr) { }

	// RVA: 0x5B10B0 Offset: 0x5AF6B0 VA: 0x1805B10B0
	public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID) { }

	// RVA: 0x5B1140 Offset: 0x5AF740 VA: 0x1805B1140
	public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID) { }

	// RVA: 0x5B11D0 Offset: 0x5AF7D0 VA: 0x1805B11D0
	public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature) { }

	// RVA: 0x5B1260 Offset: 0x5AF860 VA: 0x1805B1260
	public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature) { }

	// RVA: 0x5B1F30 Offset: 0x5B0530 VA: 0x1805B1F30
	public static extern uint ISteamRemotePlay_GetSessionCount(IntPtr instancePtr) { }

	// RVA: 0x5B1FB0 Offset: 0x5B05B0 VA: 0x1805B1FB0
	public static extern uint ISteamRemotePlay_GetSessionID(IntPtr instancePtr, int iSessionIndex) { }

	// RVA: 0x5B2040 Offset: 0x5B0640 VA: 0x1805B2040
	public static extern ulong ISteamRemotePlay_GetSessionSteamID(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	// RVA: 0x5B1EA0 Offset: 0x5B04A0 VA: 0x1805B1EA0
	public static extern IntPtr ISteamRemotePlay_GetSessionClientName(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	// RVA: 0x5B1E10 Offset: 0x5B0410 VA: 0x1805B1E10
	public static extern ESteamDeviceFormFactor ISteamRemotePlay_GetSessionClientFormFactor(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	// RVA: 0x5B1C40 Offset: 0x5B0240 VA: 0x1805B1C40
	public static extern bool ISteamRemotePlay_BGetSessionClientResolution(IntPtr instancePtr, RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	// RVA: 0x5B1D80 Offset: 0x5B0380 VA: 0x1805B1D80
	public static extern bool ISteamRemotePlay_BStartRemotePlayTogether(IntPtr instancePtr, bool bShowOverlay) { }

	// RVA: 0x5B1CF0 Offset: 0x5B02F0 VA: 0x1805B1CF0
	public static extern bool ISteamRemotePlay_BSendRemotePlayTogetherInvite(IntPtr instancePtr, CSteamID steamIDFriend) { }

	// RVA: 0x5B31A0 Offset: 0x5B17A0 VA: 0x1805B31A0
	public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData) { }

	// RVA: 0x5B2C00 Offset: 0x5B1200 VA: 0x1805B2C00
	public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead) { }

	// RVA: 0x5B2DE0 Offset: 0x5B13E0 VA: 0x1805B2DE0
	public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData) { }

	// RVA: 0x5B2B10 Offset: 0x5B1110 VA: 0x1805B2B10
	public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead) { }

	// RVA: 0x5B2A50 Offset: 0x5B1050 VA: 0x1805B2A50
	public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead) { }

	// RVA: 0x5B2890 Offset: 0x5B0E90 VA: 0x1805B2890
	public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B26D0 Offset: 0x5B0CD0 VA: 0x1805B26D0
	public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B2D00 Offset: 0x5B1300 VA: 0x1805B2D00
	public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B42D0 Offset: 0x5B28D0 VA: 0x1805B42D0
	public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) { }

	// RVA: 0x5B3000 Offset: 0x5B1600 VA: 0x1805B3000
	public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B30E0 Offset: 0x5B16E0 VA: 0x1805B30E0
	public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData) { }

	// RVA: 0x5B2F70 Offset: 0x5B1570 VA: 0x1805B2F70
	public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle) { }

	// RVA: 0x5B2EE0 Offset: 0x5B14E0 VA: 0x1805B2EE0
	public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle) { }

	// RVA: 0x5B27B0 Offset: 0x5B0DB0 VA: 0x1805B27B0
	public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B2970 Offset: 0x5B0F70 VA: 0x1805B2970
	public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B34D0 Offset: 0x5B1AD0 VA: 0x1805B34D0
	public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B35A0 Offset: 0x5B1BA0 VA: 0x1805B35A0
	public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B3970 Offset: 0x5B1F70 VA: 0x1805B3970
	public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B33B0 Offset: 0x5B19B0 VA: 0x1805B33B0
	public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr) { }

	// RVA: 0x5B3430 Offset: 0x5B1A30 VA: 0x1805B3430
	public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes) { }

	// RVA: 0x5B38D0 Offset: 0x5B1ED0 VA: 0x1805B38D0
	public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes) { }

	// RVA: 0x5B3C50 Offset: 0x5B2250 VA: 0x1805B3C50
	public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr) { }

	// RVA: 0x5B3CD0 Offset: 0x5B22D0 VA: 0x1805B3CD0
	public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr) { }

	// RVA: 0x5B4240 Offset: 0x5B2840 VA: 0x1805B4240
	public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled) { }

	// RVA: 0x5B45E0 Offset: 0x5B2BE0 VA: 0x1805B45E0
	public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority) { }

	// RVA: 0x5B3B10 Offset: 0x5B2110 VA: 0x1805B3B10
	public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) { }

	// RVA: 0x5B3A40 Offset: 0x5B2040 VA: 0x1805B3A40
	public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) { }

	// RVA: 0x5B4680 Offset: 0x5B2C80 VA: 0x1805B4680
	public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) { }

	// RVA: 0x5B32A0 Offset: 0x5B18A0 VA: 0x1805B32A0
	public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr) { }

	// RVA: 0x5B3320 Offset: 0x5B1920 VA: 0x1805B3320
	public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent) { }

	// RVA: 0x5B3FE0 Offset: 0x5B25E0 VA: 0x1805B3FE0
	public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType) { }

	// RVA: 0x5B21E0 Offset: 0x5B07E0 VA: 0x1805B21E0
	public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x5B48C0 Offset: 0x5B2EC0 VA: 0x1805B48C0
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile) { }

	// RVA: 0x5B49A0 Offset: 0x5B2FA0 VA: 0x1805B49A0
	public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile) { }

	// RVA: 0x5B4C00 Offset: 0x5B3200 VA: 0x1805B4C00
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle) { }

	// RVA: 0x5B47E0 Offset: 0x5B2DE0 VA: 0x1805B47E0
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription) { }

	// RVA: 0x5B4CE0 Offset: 0x5B32E0 VA: 0x1805B4CE0
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0x5B4B60 Offset: 0x5B3160 VA: 0x1805B4B60
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags) { }

	// RVA: 0x5B2150 Offset: 0x5B0750 VA: 0x1805B2150
	public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle) { }

	// RVA: 0x5B37A0 Offset: 0x5B1DA0 VA: 0x1805B37A0
	public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) { }

	// RVA: 0x5B2270 Offset: 0x5B0870 VA: 0x1805B2270
	public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x5B24F0 Offset: 0x5B0AF0 VA: 0x1805B24F0
	public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex) { }

	// RVA: 0x5B4460 Offset: 0x5B2A60 VA: 0x1805B4460
	public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x5B2640 Offset: 0x5B0C40 VA: 0x1805B2640
	public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex) { }

	// RVA: 0x5B4750 Offset: 0x5B2D50 VA: 0x1805B4750
	public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x5B4A80 Offset: 0x5B3080 VA: 0x1805B4A80
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription) { }

	// RVA: 0x5B3840 Offset: 0x5B1E40 VA: 0x1805B3840
	public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x5B4D80 Offset: 0x5B3380 VA: 0x1805B4D80
	public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp) { }

	// RVA: 0x5B3BC0 Offset: 0x5B21C0 VA: 0x1805B3BC0
	public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	// RVA: 0x5B2580 Offset: 0x5B0B80 VA: 0x1805B2580
	public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags) { }

	// RVA: 0x5B3D50 Offset: 0x5B2350 VA: 0x1805B3D50
	public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags) { }

	// RVA: 0x5B43C0 Offset: 0x5B29C0 VA: 0x1805B43C0
	public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) { }

	// RVA: 0x5B2380 Offset: 0x5B0980 VA: 0x1805B2380
	public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex) { }

	// RVA: 0x5B2420 Offset: 0x5B0A20 VA: 0x1805B2420
	public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags) { }

	// RVA: 0x5B44F0 Offset: 0x5B2AF0 VA: 0x1805B44F0
	public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority) { }

	// RVA: 0x5B3680 Offset: 0x5B1C80 VA: 0x1805B3680
	public static extern int ISteamRemoteStorage_GetLocalFileChangeCount(IntPtr instancePtr) { }

	// RVA: 0x5B3700 Offset: 0x5B1D00 VA: 0x1805B3700
	public static extern IntPtr ISteamRemoteStorage_GetLocalFileChange(IntPtr instancePtr, int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType) { }

	// RVA: 0x5B20D0 Offset: 0x5B06D0 VA: 0x1805B20D0
	public static extern bool ISteamRemoteStorage_BeginFileWriteBatch(IntPtr instancePtr) { }

	// RVA: 0x5B2300 Offset: 0x5B0900 VA: 0x1805B2300
	public static extern bool ISteamRemoteStorage_EndFileWriteBatch(IntPtr instancePtr) { }

	// RVA: 0x5B5480 Offset: 0x5B3A80 VA: 0x1805B5480
	public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) { }

	// RVA: 0x5B4E20 Offset: 0x5B3420 VA: 0x1805B4E20
	public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight) { }

	// RVA: 0x5B5400 Offset: 0x5B3A00 VA: 0x1805B5400
	public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr) { }

	// RVA: 0x5B50D0 Offset: 0x5B36D0 VA: 0x1805B50D0
	public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook) { }

	// RVA: 0x5B51E0 Offset: 0x5B37E0 VA: 0x1805B51E0
	public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation) { }

	// RVA: 0x5B5360 Offset: 0x5B3960 VA: 0x1805B5360
	public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID) { }

	// RVA: 0x5B52C0 Offset: 0x5B38C0 VA: 0x1805B52C0
	public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) { }

	// RVA: 0x5B5160 Offset: 0x5B3760 VA: 0x1805B5160
	public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr) { }

	// RVA: 0x5B4F80 Offset: 0x5B3580 VA: 0x1805B4F80
	public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename) { }

	// RVA: 0x5B5840 Offset: 0x5B3E40 VA: 0x1805B5840
	public static extern void ISteamTimeline_SetTimelineStateDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDescription, float flTimeDelta) { }

	// RVA: 0x5B5720 Offset: 0x5B3D20 VA: 0x1805B5720
	public static extern void ISteamTimeline_ClearTimelineStateDescription(IntPtr instancePtr, float flTimeDelta) { }

	// RVA: 0x5B5540 Offset: 0x5B3B40 VA: 0x1805B5540
	public static extern void ISteamTimeline_AddTimelineEvent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchIcon, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, uint unPriority, float flStartOffsetSeconds, float flDurationSeconds, ETimelineEventClipPriority ePossibleClip) { }

	// RVA: 0x5B57B0 Offset: 0x5B3DB0 VA: 0x1805B57B0
	public static extern void ISteamTimeline_SetTimelineGameMode(IntPtr instancePtr, ETimelineGameMode eMode) { }

	// RVA: 0x5B6670 Offset: 0x5B4C70 VA: 0x1805B6670
	public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0x5B6510 Offset: 0x5B4B10 VA: 0x1805B6510
	public static extern ulong ISteamUGC_CreateQueryAllUGCRequestPage(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0x5B63F0 Offset: 0x5B49F0 VA: 0x1805B63F0
	public static extern ulong ISteamUGC_CreateQueryAllUGCRequestCursor(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, InteropHelp.UTF8StringHandle pchCursor) { }

	// RVA: 0x5B65D0 Offset: 0x5B4BD0 VA: 0x1805B65D0
	public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x5B8170 Offset: 0x5B6770 VA: 0x1805B8170
	public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle) { }

	// RVA: 0x5B74B0 Offset: 0x5B5AB0 VA: 0x1805B74B0
	public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	// RVA: 0x5B7350 Offset: 0x5B5950 VA: 0x1805B7350
	public static extern uint ISteamUGC_GetQueryUGCNumTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x5B77C0 Offset: 0x5B5DC0 VA: 0x1805B77C0
	public static extern bool ISteamUGC_GetQueryUGCTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0x5B76F0 Offset: 0x5B5CF0 VA: 0x1805B76F0
	public static extern bool ISteamUGC_GetQueryUGCTagDisplayName(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0x5B73F0 Offset: 0x5B59F0 VA: 0x1805B73F0
	public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	// RVA: 0x5B7150 Offset: 0x5B5750 VA: 0x1805B7150
	public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	// RVA: 0x5B6EF0 Offset: 0x5B54F0 VA: 0x1805B6EF0
	public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0x5B7630 Offset: 0x5B5C30 VA: 0x1805B7630
	public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	// RVA: 0x5B7210 Offset: 0x5B5810 VA: 0x1805B7210
	public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x5B6E00 Offset: 0x5B5400 VA: 0x1805B6E00
	public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	// RVA: 0x5B72B0 Offset: 0x5B58B0 VA: 0x1805B72B0
	public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x5B7070 Offset: 0x5B5670 VA: 0x1805B7070
	public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0x5B6CE0 Offset: 0x5B52E0 VA: 0x1805B6CE0
	public static extern bool ISteamUGC_GetQueryFirstUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, InteropHelp.UTF8StringHandle pchKey, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0x5B6C40 Offset: 0x5B5240 VA: 0x1805B6C40
	public static extern uint ISteamUGC_GetNumSupportedGameVersions(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0x5B7930 Offset: 0x5B5F30 VA: 0x1805B7930
	public static extern bool ISteamUGC_GetSupportedGameVersionData(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint versionIndex, IntPtr pchGameBranchMin, IntPtr pchGameBranchMax, uint cchGameBranchSize) { }

	// RVA: 0x5B6FB0 Offset: 0x5B55B0 VA: 0x1805B6FB0
	public static extern uint ISteamUGC_GetQueryUGCContentDescriptors(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In] [Out] EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	// RVA: 0x5B7BB0 Offset: 0x5B61B0 VA: 0x1805B7BB0
	public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle) { }

	// RVA: 0x5B6190 Offset: 0x5B4790 VA: 0x1805B6190
	public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName) { }

	// RVA: 0x5B60F0 Offset: 0x5B46F0 VA: 0x1805B60F0
	public static extern bool ISteamUGC_AddRequiredTagGroup(IntPtr instancePtr, UGCQueryHandle_t handle, IntPtr pTagGroups) { }

	// RVA: 0x5B5B00 Offset: 0x5B4100 VA: 0x1805B5B00
	public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName) { }

	// RVA: 0x5B91E0 Offset: 0x5B77E0 VA: 0x1805B91E0
	public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0x5B9000 Offset: 0x5B7600 VA: 0x1805B9000
	public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0x5B90A0 Offset: 0x5B76A0 VA: 0x1805B90A0
	public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0x5B9140 Offset: 0x5B7740 VA: 0x1805B9140
	public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0x5B8F60 Offset: 0x5B7560 VA: 0x1805B8F60
	public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0x5B8EC0 Offset: 0x5B74C0 VA: 0x1805B8EC0
	public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0x5B9320 Offset: 0x5B7920 VA: 0x1805B9320
	public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0x5B9280 Offset: 0x5B7880 VA: 0x1805B9280
	public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0x5B8B50 Offset: 0x5B7150 VA: 0x1805B8B50
	public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage) { }

	// RVA: 0x5B82A0 Offset: 0x5B68A0 VA: 0x1805B82A0
	public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0x5B8200 Offset: 0x5B6800 VA: 0x1805B8200
	public static extern bool ISteamUGC_SetAdminQuery(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAdminQuery) { }

	// RVA: 0x5B83E0 Offset: 0x5B69E0 VA: 0x1805B83E0
	public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName) { }

	// RVA: 0x5B8C30 Offset: 0x5B7230 VA: 0x1805B8C30
	public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0x5B93C0 Offset: 0x5B79C0 VA: 0x1805B93C0
	public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText) { }

	// RVA: 0x5B8CD0 Offset: 0x5B72D0 VA: 0x1805B8CD0
	public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0x5B94A0 Offset: 0x5B7AA0 VA: 0x1805B94A0
	public static extern bool ISteamUGC_SetTimeCreatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0x5B9550 Offset: 0x5B7B50 VA: 0x1805B9550
	public static extern bool ISteamUGC_SetTimeUpdatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0x5B5FA0 Offset: 0x5B45A0 VA: 0x1805B5FA0
	public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue) { }

	// RVA: 0x5B80D0 Offset: 0x5B66D0 VA: 0x1805B80D0
	public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	// RVA: 0x5B6350 Offset: 0x5B4950 VA: 0x1805B6350
	public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	// RVA: 0x5B9720 Offset: 0x5B7D20 VA: 0x1805B9720
	public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B88F0 Offset: 0x5B6EF0 VA: 0x1805B88F0
	public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle) { }

	// RVA: 0x5B85A0 Offset: 0x5B6BA0 VA: 0x1805B85A0
	public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription) { }

	// RVA: 0x5B89D0 Offset: 0x5B6FD0 VA: 0x1805B89D0
	public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage) { }

	// RVA: 0x5B8680 Offset: 0x5B6C80 VA: 0x1805B8680
	public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData) { }

	// RVA: 0x5B8AB0 Offset: 0x5B70B0 VA: 0x1805B8AB0
	public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0x5B8840 Offset: 0x5B6E40 VA: 0x1805B8840
	public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags, bool bAllowAdminTags) { }

	// RVA: 0x5B84C0 Offset: 0x5B6AC0 VA: 0x1805B84C0
	public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder) { }

	// RVA: 0x5B8760 Offset: 0x5B6D60 VA: 0x1805B8760
	public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile) { }

	// RVA: 0x5B8340 Offset: 0x5B6940 VA: 0x1805B8340
	public static extern bool ISteamUGC_SetAllowLegacyUpload(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	// RVA: 0x5B7C40 Offset: 0x5B6240 VA: 0x1805B7C40
	public static extern bool ISteamUGC_RemoveAllItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle) { }

	// RVA: 0x5B7F50 Offset: 0x5B6550 VA: 0x1805B7F50
	public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey) { }

	// RVA: 0x5B5BE0 Offset: 0x5B41E0 VA: 0x1805B5BE0
	public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue) { }

	// RVA: 0x5B5D30 Offset: 0x5B4330 VA: 0x1805B5D30
	public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type) { }

	// RVA: 0x5B5E20 Offset: 0x5B4420 VA: 0x1805B5E20
	public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID) { }

	// RVA: 0x5B9C10 Offset: 0x5B8210 VA: 0x1805B9C10
	public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile) { }

	// RVA: 0x5B9D00 Offset: 0x5B8300 VA: 0x1805B9D00
	public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID) { }

	// RVA: 0x5B8030 Offset: 0x5B6630 VA: 0x1805B8030
	public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index) { }

	// RVA: 0x5B59C0 Offset: 0x5B3FC0 VA: 0x1805B59C0
	public static extern bool ISteamUGC_AddContentDescriptor(IntPtr instancePtr, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0x5B7D70 Offset: 0x5B6370 VA: 0x1805B7D70
	public static extern bool ISteamUGC_RemoveContentDescriptor(IntPtr instancePtr, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0x5B8D70 Offset: 0x5B7370 VA: 0x1805B8D70
	public static extern bool ISteamUGC_SetRequiredGameVersions(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszGameBranchMin, InteropHelp.UTF8StringHandle pszGameBranchMax) { }

	// RVA: 0x5B9980 Offset: 0x5B7F80 VA: 0x1805B9980
	public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote) { }

	// RVA: 0x5B6B10 Offset: 0x5B5110 VA: 0x1805B6B10
	public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	// RVA: 0x5B9600 Offset: 0x5B7C00 VA: 0x1805B9600
	public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	// RVA: 0x5B7AA0 Offset: 0x5B60A0 VA: 0x1805B7AA0
	public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B5F00 Offset: 0x5B4500 VA: 0x1805B5F00
	public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B7EB0 Offset: 0x5B64B0 VA: 0x1805B7EB0
	public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B9A60 Offset: 0x5B8060 VA: 0x1805B9A60
	public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B9B80 Offset: 0x5B8180 VA: 0x1805B9B80
	public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B6BC0 Offset: 0x5B51C0 VA: 0x1805B6BC0
	public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr) { }

	// RVA: 0x5B7890 Offset: 0x5B5E90 VA: 0x1805B7890
	public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0x5B6A80 Offset: 0x5B5080 VA: 0x1805B6A80
	public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B69B0 Offset: 0x5B4FB0 VA: 0x1805B69B0
	public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	// RVA: 0x5B6900 Offset: 0x5B4F00 VA: 0x1805B6900
	public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0x5B67D0 Offset: 0x5B4DD0 VA: 0x1805B67D0
	public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	// RVA: 0x5B6270 Offset: 0x5B4870 VA: 0x1805B6270
	public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder) { }

	// RVA: 0x5B9AF0 Offset: 0x5B80F0 VA: 0x1805B9AF0
	public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend) { }

	// RVA: 0x5B97C0 Offset: 0x5B7DC0 VA: 0x1805B97C0
	public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x5B98E0 Offset: 0x5B7EE0 VA: 0x1805B98E0
	public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0x5B9860 Offset: 0x5B7E60 VA: 0x1805B9860
	public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr) { }

	// RVA: 0x5B5A60 Offset: 0x5B4060 VA: 0x1805B5A60
	public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0x5B7E10 Offset: 0x5B6410 VA: 0x1805B7E10
	public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0x5B5920 Offset: 0x5B3F20 VA: 0x1805B5920
	public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0x5B7CD0 Offset: 0x5B62D0 VA: 0x1805B7CD0
	public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0x5B6870 Offset: 0x5B4E70 VA: 0x1805B6870
	public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B6740 Offset: 0x5B4D40 VA: 0x1805B6740
	public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0x5B96A0 Offset: 0x5B7CA0 VA: 0x1805B96A0
	public static extern bool ISteamUGC_ShowWorkshopEULA(IntPtr instancePtr) { }

	// RVA: 0x5B7B30 Offset: 0x5B6130 VA: 0x1805B7B30
	public static extern ulong ISteamUGC_GetWorkshopEULAStatus(IntPtr instancePtr) { }

	// RVA: 0x5B7A00 Offset: 0x5B6000 VA: 0x1805B7A00
	public static extern uint ISteamUGC_GetUserContentDescriptorPreferences(IntPtr instancePtr, [In] [Out] EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	// RVA: 0x5BCD80 Offset: 0x5BB380 VA: 0x1805BCD80
	public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr) { }

	// RVA: 0x5BC5A0 Offset: 0x5BABA0 VA: 0x1805BC5A0
	public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr) { }

	// RVA: 0x5BCF00 Offset: 0x5BB500 VA: 0x1805BCF00
	public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr) { }

	// RVA: 0x5BD1B0 Offset: 0x5BB7B0 VA: 0x1805BD1B0
	public static extern int ISteamUser_InitiateGameConnection_DEPRECATED(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) { }

	// RVA: 0x5BD510 Offset: 0x5BBB10 VA: 0x1805BD510
	public static extern void ISteamUser_TerminateGameConnection_DEPRECATED(IntPtr instancePtr, uint unIPServer, ushort usPortServer) { }

	// RVA: 0x5BD5B0 Offset: 0x5BBBB0 VA: 0x1805BD5B0
	public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo) { }

	// RVA: 0x5BCF80 Offset: 0x5BB580 VA: 0x1805BCF80
	public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer) { }

	// RVA: 0x5BD410 Offset: 0x5BBA10 VA: 0x1805BD410
	public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr) { }

	// RVA: 0x5BD490 Offset: 0x5BBA90 VA: 0x1805BD490
	public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr) { }

	// RVA: 0x5BCAF0 Offset: 0x5BB0F0 VA: 0x1805BCAF0
	public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0x5BD0A0 Offset: 0x5BB6A0 VA: 0x1805BD0A0
	public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0x5BC7F0 Offset: 0x5BADF0 VA: 0x1805BC7F0
	public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0x5BD020 Offset: 0x5BB620 VA: 0x1805BD020
	public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr) { }

	// RVA: 0x5BC960 Offset: 0x5BAF60 VA: 0x1805BC960
	public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSteamNetworkingIdentity) { }

	// RVA: 0x5BCA20 Offset: 0x5BB020 VA: 0x1805BCA20
	public static extern uint ISteamUser_GetAuthTicketForWebApi(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchIdentity) { }

	// RVA: 0x5BC6B0 Offset: 0x5BACB0 VA: 0x1805BC6B0
	public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	// RVA: 0x5BC8D0 Offset: 0x5BAED0 VA: 0x1805BC8D0
	public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID) { }

	// RVA: 0x5BC760 Offset: 0x5BAD60 VA: 0x1805BC760
	public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket) { }

	// RVA: 0x5BD6A0 Offset: 0x5BBCA0 VA: 0x1805BD6A0
	public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID) { }

	// RVA: 0x5BC320 Offset: 0x5BA920 VA: 0x1805BC320
	public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr) { }

	// RVA: 0x5BC270 Offset: 0x5BA870 VA: 0x1805BC270
	public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) { }

	// RVA: 0x5BD290 Offset: 0x5BB890 VA: 0x1805BD290
	public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude) { }

	// RVA: 0x5BCC20 Offset: 0x5BB220 VA: 0x1805BCC20
	public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	// RVA: 0x5BCCE0 Offset: 0x5BB2E0 VA: 0x1805BCCE0
	public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil) { }

	// RVA: 0x5BCE80 Offset: 0x5BB480 VA: 0x1805BCE80
	public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr) { }

	// RVA: 0x5BD330 Offset: 0x5BB930 VA: 0x1805BD330
	public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL) { }

	// RVA: 0x5BC4A0 Offset: 0x5BAAA0 VA: 0x1805BC4A0
	public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr) { }

	// RVA: 0x5BC520 Offset: 0x5BAB20 VA: 0x1805BC520
	public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr) { }

	// RVA: 0x5BC3A0 Offset: 0x5BA9A0 VA: 0x1805BC3A0
	public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr) { }

	// RVA: 0x5BC420 Offset: 0x5BAA20 VA: 0x1805BC420
	public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr) { }

	// RVA: 0x5BCE00 Offset: 0x5BB400 VA: 0x1805BCE00
	public static extern ulong ISteamUser_GetMarketEligibility(IntPtr instancePtr) { }

	// RVA: 0x5BCBA0 Offset: 0x5BB1A0 VA: 0x1805BCBA0
	public static extern ulong ISteamUser_GetDurationControl(IntPtr instancePtr) { }

	// RVA: 0x5BC620 Offset: 0x5BAC20 VA: 0x1805BC620
	public static extern bool ISteamUser_BSetDurationControlOnlineState(IntPtr instancePtr, EDurationControlOnlineState eNewState) { }

	// RVA: 0x5BBAA0 Offset: 0x5BA0A0 VA: 0x1805BBAA0
	public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr) { }

	// RVA: 0x5BB4B0 Offset: 0x5B9AB0 VA: 0x1805BB4B0
	public static extern bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData) { }

	// RVA: 0x5BB3C0 Offset: 0x5B99C0 VA: 0x1805BB3C0
	public static extern bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData) { }

	// RVA: 0x5BBF20 Offset: 0x5BA520 VA: 0x1805BBF20
	public static extern bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData) { }

	// RVA: 0x5BBE30 Offset: 0x5BA430 VA: 0x1805BBE30
	public static extern bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData) { }

	// RVA: 0x5BC090 Offset: 0x5BA690 VA: 0x1805BC090
	public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength) { }

	// RVA: 0x5BA920 Offset: 0x5B8F20 VA: 0x1805BA920
	public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved) { }

	// RVA: 0x5BBD50 Offset: 0x5BA350 VA: 0x1805BBD50
	public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName) { }

	// RVA: 0x5B9E90 Offset: 0x5B8490 VA: 0x1805B9E90
	public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName) { }

	// RVA: 0x5BA390 Offset: 0x5B8990 VA: 0x1805BA390
	public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime) { }

	// RVA: 0x5BC010 Offset: 0x5BA610 VA: 0x1805BC010
	public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr) { }

	// RVA: 0x5BA5E0 Offset: 0x5B8BE0 VA: 0x1805BA5E0
	public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName) { }

	// RVA: 0x5BA4A0 Offset: 0x5B8AA0 VA: 0x1805BA4A0
	public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey) { }

	// RVA: 0x5BB9B0 Offset: 0x5B9FB0 VA: 0x1805BB9B0
	public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress) { }

	// RVA: 0x5BB2C0 Offset: 0x5B98C0 VA: 0x1805BB2C0
	public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr) { }

	// RVA: 0x5BA6B0 Offset: 0x5B8CB0 VA: 0x1805BA6B0
	public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement) { }

	// RVA: 0x5BBC30 Offset: 0x5BA230 VA: 0x1805BBC30
	public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	// RVA: 0x5BB8C0 Offset: 0x5B9EC0 VA: 0x1805BB8C0
	public static extern bool ISteamUserStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData) { }

	// RVA: 0x5BB7D0 Offset: 0x5B9DD0 VA: 0x1805BB7D0
	public static extern bool ISteamUserStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData) { }

	// RVA: 0x5BB6C0 Offset: 0x5B9CC0 VA: 0x1805BB6C0
	public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved) { }

	// RVA: 0x5BB5A0 Offset: 0x5B9BA0 VA: 0x1805BB5A0
	public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime) { }

	// RVA: 0x5BBCC0 Offset: 0x5BA2C0 VA: 0x1805BBCC0
	public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo) { }

	// RVA: 0x5BA1B0 Offset: 0x5B87B0 VA: 0x1805BA1B0
	public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) { }

	// RVA: 0x5BA0D0 Offset: 0x5B86D0 VA: 0x1805BA0D0
	public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName) { }

	// RVA: 0x5BAFF0 Offset: 0x5B95F0 VA: 0x1805BAFF0
	public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5BAF60 Offset: 0x5B9560 VA: 0x1805BAF60
	public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5BB080 Offset: 0x5B9680 VA: 0x1805BB080
	public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5BAED0 Offset: 0x5B94D0 VA: 0x1805BAED0
	public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	// RVA: 0x5BA020 Offset: 0x5B8620 VA: 0x1805BA020
	public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) { }

	// RVA: 0x5B9F70 Offset: 0x5B8570 VA: 0x1805B9F70
	public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In] [Out] CSteamID[] prgUsers, int cUsers) { }

	// RVA: 0x5BAA20 Offset: 0x5B9020 VA: 0x1805BAA20
	public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In] [Out] int[] pDetails, int cDetailsMax) { }

	// RVA: 0x5BC1A0 Offset: 0x5BA7A0 VA: 0x1805BC1A0
	public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In] [Out] int[] pScoreDetails, int cScoreDetailsCount) { }

	// RVA: 0x5B9DF0 Offset: 0x5B83F0 VA: 0x1805B9DF0
	public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) { }

	// RVA: 0x5BB340 Offset: 0x5B9940 VA: 0x1805BB340
	public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr) { }

	// RVA: 0x5BBB20 Offset: 0x5BA120 VA: 0x1805BBB20
	public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr) { }

	// RVA: 0x5BB110 Offset: 0x5B9710 VA: 0x1805BB110
	public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	// RVA: 0x5BB1E0 Offset: 0x5B97E0 VA: 0x1805BB1E0
	public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	// RVA: 0x5BA2A0 Offset: 0x5B88A0 VA: 0x1805BA2A0
	public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent) { }

	// RVA: 0x5BBBA0 Offset: 0x5BA1A0 VA: 0x1805BBBA0
	public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays) { }

	// RVA: 0x5BADE0 Offset: 0x5B93E0 VA: 0x1805BADE0
	public static extern bool ISteamUserStats_GetGlobalStatInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData) { }

	// RVA: 0x5BAAF0 Offset: 0x5B90F0 VA: 0x1805BAAF0
	public static extern bool ISteamUserStats_GetGlobalStatDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData) { }

	// RVA: 0x5BACE0 Offset: 0x5B92E0 VA: 0x1805BACE0
	public static extern int ISteamUserStats_GetGlobalStatHistoryInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] long[] pData, uint cubData) { }

	// RVA: 0x5BABE0 Offset: 0x5B91E0 VA: 0x1805BABE0
	public static extern int ISteamUserStats_GetGlobalStatHistoryDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] double[] pData, uint cubData) { }

	// RVA: 0x5BA830 Offset: 0x5B8E30 VA: 0x1805BA830
	public static extern bool ISteamUserStats_GetAchievementProgressLimitsInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pnMinProgress, out int pnMaxProgress) { }

	// RVA: 0x5BA740 Offset: 0x5B8D40 VA: 0x1805BA740
	public static extern bool ISteamUserStats_GetAchievementProgressLimitsFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pfMinProgress, out float pfMaxProgress) { }

	// RVA: 0x5BE1B0 Offset: 0x5BC7B0 VA: 0x1805BE1B0
	public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr) { }

	// RVA: 0x5BE230 Offset: 0x5BC830 VA: 0x1805BE230
	public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr) { }

	// RVA: 0x5BDCA0 Offset: 0x5BC2A0 VA: 0x1805BDCA0
	public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr) { }

	// RVA: 0x5BE2B0 Offset: 0x5BC8B0 VA: 0x1805BE2B0
	public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr) { }

	// RVA: 0x5BDF40 Offset: 0x5BC540 VA: 0x1805BDF40
	public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr) { }

	// RVA: 0x5BE100 Offset: 0x5BC700 VA: 0x1805BE100
	public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight) { }

	// RVA: 0x5BE050 Offset: 0x5BC650 VA: 0x1805BE050
	public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0x5BDD20 Offset: 0x5BC320 VA: 0x1805BDD20
	public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr) { }

	// RVA: 0x5BDC20 Offset: 0x5BC220 VA: 0x1805BDC20
	public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr) { }

	// RVA: 0x5BE920 Offset: 0x5BCF20 VA: 0x1805BE920
	public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition) { }

	// RVA: 0x5BE440 Offset: 0x5BCA40 VA: 0x1805BE440
	public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	// RVA: 0x5BDAB0 Offset: 0x5BC0B0 VA: 0x1805BDAB0
	public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall) { }

	// RVA: 0x5BDB40 Offset: 0x5BC140 VA: 0x1805BDB40
	public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	// RVA: 0x5BDEC0 Offset: 0x5BC4C0 VA: 0x1805BDEC0
	public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr) { }

	// RVA: 0x5BEA40 Offset: 0x5BD040 VA: 0x1805BEA40
	public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction) { }

	// RVA: 0x5BE4F0 Offset: 0x5BCAF0 VA: 0x1805BE4F0
	public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr) { }

	// RVA: 0x5BD740 Offset: 0x5BBD40 VA: 0x1805BD740
	public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr) { }

	// RVA: 0x5BD7C0 Offset: 0x5BBDC0 VA: 0x1805BD7C0
	public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName) { }

	// RVA: 0x5BEBA0 Offset: 0x5BD1A0 VA: 0x1805BEBA0
	public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText) { }

	// RVA: 0x5BDE40 Offset: 0x5BC440 VA: 0x1805BDE40
	public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr) { }

	// RVA: 0x5BDDA0 Offset: 0x5BC3A0 VA: 0x1805BDDA0
	public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText) { }

	// RVA: 0x5BE330 Offset: 0x5BC930 VA: 0x1805BE330
	public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr) { }

	// RVA: 0x5BE670 Offset: 0x5BCC70 VA: 0x1805BE670
	public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr) { }

	// RVA: 0x5BE880 Offset: 0x5BCE80 VA: 0x1805BE880
	public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset) { }

	// RVA: 0x5BE5F0 Offset: 0x5BCBF0 VA: 0x1805BE5F0
	public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr) { }

	// RVA: 0x5BED20 Offset: 0x5BD320 VA: 0x1805BED20
	public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr) { }

	// RVA: 0x5BE770 Offset: 0x5BCD70 VA: 0x1805BE770
	public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr) { }

	// RVA: 0x5BE9B0 Offset: 0x5BCFB0 VA: 0x1805BE9B0
	public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled) { }

	// RVA: 0x5BE570 Offset: 0x5BCB70 VA: 0x1805BE570
	public static extern bool ISteamUtils_IsSteamChinaLauncher(IntPtr instancePtr) { }

	// RVA: 0x5BE3B0 Offset: 0x5BC9B0 VA: 0x1805BE3B0
	public static extern bool ISteamUtils_InitFilterText(IntPtr instancePtr, uint unFilterOptions) { }

	// RVA: 0x5BD9A0 Offset: 0x5BBFA0 VA: 0x1805BD9A0
	public static extern int ISteamUtils_FilterText(IntPtr instancePtr, ETextFilteringContext eContext, CSteamID sourceSteamID, InteropHelp.UTF8StringHandle pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0x5BDFC0 Offset: 0x5BC5C0 VA: 0x1805BDFC0
	public static extern ESteamIPv6ConnectivityState ISteamUtils_GetIPv6ConnectivityState(IntPtr instancePtr, ESteamIPv6ConnectivityProtocol eProtocol) { }

	// RVA: 0x5BE6F0 Offset: 0x5BCCF0 VA: 0x1805BE6F0
	public static extern bool ISteamUtils_IsSteamRunningOnSteamDeck(IntPtr instancePtr) { }

	// RVA: 0x5BEAE0 Offset: 0x5BD0E0 VA: 0x1805BEAE0
	public static extern bool ISteamUtils_ShowFloatingGamepadTextInput(IntPtr instancePtr, EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	// RVA: 0x5BE7F0 Offset: 0x5BCDF0 VA: 0x1805BE7F0
	public static extern void ISteamUtils_SetGameLauncherMode(IntPtr instancePtr, bool bLauncherMode) { }

	// RVA: 0x5BD8A0 Offset: 0x5BBEA0 VA: 0x1805BD8A0
	public static extern bool ISteamUtils_DismissFloatingGamepadTextInput(IntPtr instancePtr) { }

	// RVA: 0x5BD920 Offset: 0x5BBF20 VA: 0x1805BD920
	public static extern bool ISteamUtils_DismissGamepadTextInput(IntPtr instancePtr) { }

	// RVA: 0x5BEEE0 Offset: 0x5BD4E0 VA: 0x1805BEEE0
	public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID) { }

	// RVA: 0x5BEF70 Offset: 0x5BD570 VA: 0x1805BEF70
	public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers) { }

	// RVA: 0x5BEDA0 Offset: 0x5BD3A0 VA: 0x1805BEDA0
	public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID) { }

	// RVA: 0x5BEE30 Offset: 0x5BD430 VA: 0x1805BEE30
	public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize) { }
}

// Namespace: Steamworks
[CallbackIdentity(1005)]
public struct DlcInstalled_t // TypeDefIndex: 10224
{
	// Fields
	public const int k_iCallback = 1005;
	public AppId_t m_nAppID; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1014)]
public struct NewUrlLaunchParameters_t // TypeDefIndex: 10225
{
	// Fields
	public const int k_iCallback = 1014;
}

// Namespace: Steamworks
[CallbackIdentity(1021)]
public struct AppProofOfPurchaseKeyResponse_t // TypeDefIndex: 10226
{
	// Fields
	public const int k_iCallback = 1021;
	public EResult m_eResult; // 0x0
	public uint m_nAppID; // 0x4
	public uint m_cchKeyLength; // 0x8
	private byte[] m_rgchKey_; // 0x10

	// Properties
	public string m_rgchKey { get; set; }

	// Methods

	// RVA: 0x58E490 Offset: 0x58CA90 VA: 0x18058E490
	public string get_m_rgchKey() { }

	// RVA: 0x58E510 Offset: 0x58CB10 VA: 0x18058E510
	public void set_m_rgchKey(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1023)]
public struct FileDetailsResult_t // TypeDefIndex: 10227
{
	// Fields
	public const int k_iCallback = 1023;
	public EResult m_eResult; // 0x0
	public ulong m_ulFileSize; // 0x8
	public byte[] m_FileSHA; // 0x10
	public uint m_unFlags; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(1030)]
public struct TimedTrialStatus_t // TypeDefIndex: 10228
{
	// Fields
	public const int k_iCallback = 1030;
	public AppId_t m_unAppID; // 0x0
	public bool m_bIsOffline; // 0x4
	public uint m_unSecondsAllowed; // 0x8
	public uint m_unSecondsPlayed; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(304)]
public struct PersonaStateChange_t // TypeDefIndex: 10229
{
	// Fields
	public const int k_iCallback = 304;
	public ulong m_ulSteamID; // 0x0
	public EPersonaChange m_nChangeFlags; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(331)]
public struct GameOverlayActivated_t // TypeDefIndex: 10230
{
	// Fields
	public const int k_iCallback = 331;
	public byte m_bActive; // 0x0
	public bool m_bUserInitiated; // 0x1
	public AppId_t m_nAppID; // 0x4
	public uint m_dwOverlayPID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(332)]
public struct GameServerChangeRequested_t // TypeDefIndex: 10231
{
	// Fields
	public const int k_iCallback = 332;
	private byte[] m_rgchServer_; // 0x0
	private byte[] m_rgchPassword_; // 0x8

	// Properties
	public string m_rgchServer { get; set; }
	public string m_rgchPassword { get; set; }

	// Methods

	// RVA: 0x5943F0 Offset: 0x5929F0 VA: 0x1805943F0
	public string get_m_rgchServer() { }

	// RVA: 0x594470 Offset: 0x592A70 VA: 0x180594470
	public void set_m_rgchServer(string value) { }

	// RVA: 0x594210 Offset: 0x592810 VA: 0x180594210
	public string get_m_rgchPassword() { }

	// RVA: 0x594470 Offset: 0x592A70 VA: 0x180594470
	public void set_m_rgchPassword(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(333)]
public struct GameLobbyJoinRequested_t // TypeDefIndex: 10232
{
	// Fields
	public const int k_iCallback = 333;
	public CSteamID m_steamIDLobby; // 0x0
	public CSteamID m_steamIDFriend; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(334)]
public struct AvatarImageLoaded_t // TypeDefIndex: 10233
{
	// Fields
	public const int k_iCallback = 334;
	public CSteamID m_steamID; // 0x0
	public int m_iImage; // 0x8
	public int m_iWide; // 0xC
	public int m_iTall; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(335)]
public struct ClanOfficerListResponse_t // TypeDefIndex: 10234
{
	// Fields
	public const int k_iCallback = 335;
	public CSteamID m_steamIDClan; // 0x0
	public int m_cOfficers; // 0x8
	public byte m_bSuccess; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(336)]
public struct FriendRichPresenceUpdate_t // TypeDefIndex: 10235
{
	// Fields
	public const int k_iCallback = 336;
	public CSteamID m_steamIDFriend; // 0x0
	public AppId_t m_nAppID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(337)]
public struct GameRichPresenceJoinRequested_t // TypeDefIndex: 10236
{
	// Fields
	public const int k_iCallback = 337;
	public CSteamID m_steamIDFriend; // 0x0
	private byte[] m_rgchConnect_; // 0x8

	// Properties
	public string m_rgchConnect { get; set; }

	// Methods

	// RVA: 0x594210 Offset: 0x592810 VA: 0x180594210
	public string get_m_rgchConnect() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_rgchConnect(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(338)]
public struct GameConnectedClanChatMsg_t // TypeDefIndex: 10237
{
	// Fields
	public const int k_iCallback = 338;
	public CSteamID m_steamIDClanChat; // 0x0
	public CSteamID m_steamIDUser; // 0x8
	public int m_iMessageID; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(339)]
public struct GameConnectedChatJoin_t // TypeDefIndex: 10238
{
	// Fields
	public const int k_iCallback = 339;
	public CSteamID m_steamIDClanChat; // 0x0
	public CSteamID m_steamIDUser; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(340)]
public struct GameConnectedChatLeave_t // TypeDefIndex: 10239
{
	// Fields
	public const int k_iCallback = 340;
	public CSteamID m_steamIDClanChat; // 0x0
	public CSteamID m_steamIDUser; // 0x8
	public bool m_bKicked; // 0x10
	public bool m_bDropped; // 0x11
}

// Namespace: Steamworks
[CallbackIdentity(341)]
public struct DownloadClanActivityCountsResult_t // TypeDefIndex: 10240
{
	// Fields
	public const int k_iCallback = 341;
	public bool m_bSuccess; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(342)]
public struct JoinClanChatRoomCompletionResult_t // TypeDefIndex: 10241
{
	// Fields
	public const int k_iCallback = 342;
	public CSteamID m_steamIDClanChat; // 0x0
	public EChatRoomEnterResponse m_eChatRoomEnterResponse; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(343)]
public struct GameConnectedFriendChatMsg_t // TypeDefIndex: 10242
{
	// Fields
	public const int k_iCallback = 343;
	public CSteamID m_steamIDUser; // 0x0
	public int m_iMessageID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(344)]
public struct FriendsGetFollowerCount_t // TypeDefIndex: 10243
{
	// Fields
	public const int k_iCallback = 344;
	public EResult m_eResult; // 0x0
	public CSteamID m_steamID; // 0x4
	public int m_nCount; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(345)]
public struct FriendsIsFollowing_t // TypeDefIndex: 10244
{
	// Fields
	public const int k_iCallback = 345;
	public EResult m_eResult; // 0x0
	public CSteamID m_steamID; // 0x4
	public bool m_bIsFollowing; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(346)]
public struct FriendsEnumerateFollowingList_t // TypeDefIndex: 10245
{
	// Fields
	public const int k_iCallback = 346;
	public EResult m_eResult; // 0x0
	public CSteamID[] m_rgSteamID; // 0x8
	public int m_nResultsReturned; // 0x10
	public int m_nTotalResultCount; // 0x14
}

// Namespace: Steamworks
[CallbackIdentity(347)]
public struct SetPersonaNameResponse_t // TypeDefIndex: 10246
{
	// Fields
	public const int k_iCallback = 347;
	public bool m_bSuccess; // 0x0
	public bool m_bLocalSuccess; // 0x1
	public EResult m_result; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(348)]
public struct UnreadChatMessagesChanged_t // TypeDefIndex: 10247
{
	// Fields
	public const int k_iCallback = 348;
}

// Namespace: Steamworks
[CallbackIdentity(349)]
public struct OverlayBrowserProtocolNavigation_t // TypeDefIndex: 10248
{
	// Fields
	public const int k_iCallback = 349;
	private byte[] rgchURI_; // 0x0

	// Properties
	public string rgchURI { get; set; }

	// Methods

	// RVA: 0x5943F0 Offset: 0x5929F0 VA: 0x1805943F0
	public string get_rgchURI() { }

	// RVA: 0x5C28F0 Offset: 0x5C0EF0 VA: 0x1805C28F0
	public void set_rgchURI(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(350)]
public struct EquippedProfileItemsChanged_t // TypeDefIndex: 10249
{
	// Fields
	public const int k_iCallback = 350;
	public CSteamID m_steamID; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(351)]
public struct EquippedProfileItems_t // TypeDefIndex: 10250
{
	// Fields
	public const int k_iCallback = 351;
	public EResult m_eResult; // 0x0
	public CSteamID m_steamID; // 0x4
	public bool m_bHasAnimatedAvatar; // 0xC
	public bool m_bHasAvatarFrame; // 0xD
	public bool m_bHasProfileModifier; // 0xE
	public bool m_bHasProfileBackground; // 0xF
	public bool m_bHasMiniProfileBackground; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1701)]
public struct GCMessageAvailable_t // TypeDefIndex: 10251
{
	// Fields
	public const int k_iCallback = 1701;
	public uint m_nMessageSize; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1702)]
public struct GCMessageFailed_t // TypeDefIndex: 10252
{
	// Fields
	public const int k_iCallback = 1702;
}

// Namespace: Steamworks
[CallbackIdentity(201)]
public struct GSClientApprove_t // TypeDefIndex: 10253
{
	// Fields
	public const int k_iCallback = 201;
	public CSteamID m_SteamID; // 0x0
	public CSteamID m_OwnerSteamID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(202)]
public struct GSClientDeny_t // TypeDefIndex: 10254
{
	// Fields
	public const int k_iCallback = 202;
	public CSteamID m_SteamID; // 0x0
	public EDenyReason m_eDenyReason; // 0x8
	private byte[] m_rgchOptionalText_; // 0x10

	// Properties
	public string m_rgchOptionalText { get; set; }

	// Methods

	// RVA: 0x58E490 Offset: 0x58CA90 VA: 0x18058E490
	public string get_m_rgchOptionalText() { }

	// RVA: 0x594290 Offset: 0x592890 VA: 0x180594290
	public void set_m_rgchOptionalText(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(203)]
public struct GSClientKick_t // TypeDefIndex: 10255
{
	// Fields
	public const int k_iCallback = 203;
	public CSteamID m_SteamID; // 0x0
	public EDenyReason m_eDenyReason; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(206)]
public struct GSClientAchievementStatus_t // TypeDefIndex: 10256
{
	// Fields
	public const int k_iCallback = 206;
	public ulong m_SteamID; // 0x0
	private byte[] m_pchAchievement_; // 0x8
	public bool m_bUnlocked; // 0x10

	// Properties
	public string m_pchAchievement { get; set; }

	// Methods

	// RVA: 0x594210 Offset: 0x592810 VA: 0x180594210
	public string get_m_pchAchievement() { }

	// RVA: 0x594290 Offset: 0x592890 VA: 0x180594290
	public void set_m_pchAchievement(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(115)]
public struct GSPolicyResponse_t // TypeDefIndex: 10257
{
	// Fields
	public const int k_iCallback = 115;
	public byte m_bSecure; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(207)]
public struct GSGameplayStats_t // TypeDefIndex: 10258
{
	// Fields
	public const int k_iCallback = 207;
	public EResult m_eResult; // 0x0
	public int m_nRank; // 0x4
	public uint m_unTotalConnects; // 0x8
	public uint m_unTotalMinutesPlayed; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(208)]
public struct GSClientGroupStatus_t // TypeDefIndex: 10259
{
	// Fields
	public const int k_iCallback = 208;
	public CSteamID m_SteamIDUser; // 0x0
	public CSteamID m_SteamIDGroup; // 0x8
	public bool m_bMember; // 0x10
	public bool m_bOfficer; // 0x11
}

// Namespace: Steamworks
[CallbackIdentity(209)]
public struct GSReputation_t // TypeDefIndex: 10260
{
	// Fields
	public const int k_iCallback = 209;
	public EResult m_eResult; // 0x0
	public uint m_unReputationScore; // 0x4
	public bool m_bBanned; // 0x8
	public uint m_unBannedIP; // 0xC
	public ushort m_usBannedPort; // 0x10
	public ulong m_ulBannedGameID; // 0x18
	public uint m_unBanExpires; // 0x20
}

// Namespace: Steamworks
[CallbackIdentity(210)]
public struct AssociateWithClanResult_t // TypeDefIndex: 10261
{
	// Fields
	public const int k_iCallback = 210;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(211)]
public struct ComputeNewPlayerCompatibilityResult_t // TypeDefIndex: 10262
{
	// Fields
	public const int k_iCallback = 211;
	public EResult m_eResult; // 0x0
	public int m_cPlayersThatDontLikeCandidate; // 0x4
	public int m_cPlayersThatCandidateDoesntLike; // 0x8
	public int m_cClanPlayersThatDontLikeCandidate; // 0xC
	public CSteamID m_SteamIDCandidate; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1800)]
public struct GSStatsReceived_t // TypeDefIndex: 10263
{
	// Fields
	public const int k_iCallback = 1800;
	public EResult m_eResult; // 0x0
	public CSteamID m_steamIDUser; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(1801)]
public struct GSStatsStored_t // TypeDefIndex: 10264
{
	// Fields
	public const int k_iCallback = 1801;
	public EResult m_eResult; // 0x0
	public CSteamID m_steamIDUser; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(1108)]
public struct GSStatsUnloaded_t // TypeDefIndex: 10265
{
	// Fields
	public const int k_iCallback = 1108;
	public CSteamID m_steamIDUser; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4501)]
public struct HTML_BrowserReady_t // TypeDefIndex: 10266
{
	// Fields
	public const int k_iCallback = 4501;
	public HHTMLBrowser unBrowserHandle; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4502)]
public struct HTML_NeedsPaint_t // TypeDefIndex: 10267
{
	// Fields
	public const int k_iCallback = 4502;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public IntPtr pBGRA; // 0x8
	public uint unWide; // 0x10
	public uint unTall; // 0x14
	public uint unUpdateX; // 0x18
	public uint unUpdateY; // 0x1C
	public uint unUpdateWide; // 0x20
	public uint unUpdateTall; // 0x24
	public uint unScrollX; // 0x28
	public uint unScrollY; // 0x2C
	public float flPageScale; // 0x30
	public uint unPageSerial; // 0x34
}

// Namespace: Steamworks
[CallbackIdentity(4503)]
public struct HTML_StartRequest_t // TypeDefIndex: 10268
{
	// Fields
	public const int k_iCallback = 4503;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchURL; // 0x8
	public string pchTarget; // 0x10
	public string pchPostData; // 0x18
	public bool bIsRedirect; // 0x20
}

// Namespace: Steamworks
[CallbackIdentity(4504)]
public struct HTML_CloseBrowser_t // TypeDefIndex: 10269
{
	// Fields
	public const int k_iCallback = 4504;
	public HHTMLBrowser unBrowserHandle; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4505)]
public struct HTML_URLChanged_t // TypeDefIndex: 10270
{
	// Fields
	public const int k_iCallback = 4505;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchURL; // 0x8
	public string pchPostData; // 0x10
	public bool bIsRedirect; // 0x18
	public string pchPageTitle; // 0x20
	public bool bNewNavigation; // 0x28
}

// Namespace: Steamworks
[CallbackIdentity(4506)]
public struct HTML_FinishedRequest_t // TypeDefIndex: 10271
{
	// Fields
	public const int k_iCallback = 4506;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchURL; // 0x8
	public string pchPageTitle; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(4507)]
public struct HTML_OpenLinkInNewTab_t // TypeDefIndex: 10272
{
	// Fields
	public const int k_iCallback = 4507;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchURL; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4508)]
public struct HTML_ChangedTitle_t // TypeDefIndex: 10273
{
	// Fields
	public const int k_iCallback = 4508;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchTitle; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4509)]
public struct HTML_SearchResults_t // TypeDefIndex: 10274
{
	// Fields
	public const int k_iCallback = 4509;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public uint unResults; // 0x4
	public uint unCurrentMatch; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4510)]
public struct HTML_CanGoBackAndForward_t // TypeDefIndex: 10275
{
	// Fields
	public const int k_iCallback = 4510;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public bool bCanGoBack; // 0x4
	public bool bCanGoForward; // 0x5
}

// Namespace: Steamworks
[CallbackIdentity(4511)]
public struct HTML_HorizontalScroll_t // TypeDefIndex: 10276
{
	// Fields
	public const int k_iCallback = 4511;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public uint unScrollMax; // 0x4
	public uint unScrollCurrent; // 0x8
	public float flPageScale; // 0xC
	public bool bVisible; // 0x10
	public uint unPageSize; // 0x14
}

// Namespace: Steamworks
[CallbackIdentity(4512)]
public struct HTML_VerticalScroll_t // TypeDefIndex: 10277
{
	// Fields
	public const int k_iCallback = 4512;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public uint unScrollMax; // 0x4
	public uint unScrollCurrent; // 0x8
	public float flPageScale; // 0xC
	public bool bVisible; // 0x10
	public uint unPageSize; // 0x14
}

// Namespace: Steamworks
[CallbackIdentity(4513)]
public struct HTML_LinkAtPosition_t // TypeDefIndex: 10278
{
	// Fields
	public const int k_iCallback = 4513;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public uint x; // 0x4
	public uint y; // 0x8
	public string pchURL; // 0x10
	public bool bInput; // 0x18
	public bool bLiveLink; // 0x19
}

// Namespace: Steamworks
[CallbackIdentity(4514)]
public struct HTML_JSAlert_t // TypeDefIndex: 10279
{
	// Fields
	public const int k_iCallback = 4514;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchMessage; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4515)]
public struct HTML_JSConfirm_t // TypeDefIndex: 10280
{
	// Fields
	public const int k_iCallback = 4515;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchMessage; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4516)]
public struct HTML_FileOpenDialog_t // TypeDefIndex: 10281
{
	// Fields
	public const int k_iCallback = 4516;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchTitle; // 0x8
	public string pchInitialFile; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(4521)]
public struct HTML_NewWindow_t // TypeDefIndex: 10282
{
	// Fields
	public const int k_iCallback = 4521;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchURL; // 0x8
	public uint unX; // 0x10
	public uint unY; // 0x14
	public uint unWide; // 0x18
	public uint unTall; // 0x1C
	public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE; // 0x20
}

// Namespace: Steamworks
[CallbackIdentity(4522)]
public struct HTML_SetCursor_t // TypeDefIndex: 10283
{
	// Fields
	public const int k_iCallback = 4522;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public uint eMouseCursor; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(4523)]
public struct HTML_StatusText_t // TypeDefIndex: 10284
{
	// Fields
	public const int k_iCallback = 4523;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchMsg; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4524)]
public struct HTML_ShowToolTip_t // TypeDefIndex: 10285
{
	// Fields
	public const int k_iCallback = 4524;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchMsg; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4525)]
public struct HTML_UpdateToolTip_t // TypeDefIndex: 10286
{
	// Fields
	public const int k_iCallback = 4525;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public string pchMsg; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(4526)]
public struct HTML_HideToolTip_t // TypeDefIndex: 10287
{
	// Fields
	public const int k_iCallback = 4526;
	public HHTMLBrowser unBrowserHandle; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4527)]
public struct HTML_BrowserRestarted_t // TypeDefIndex: 10288
{
	// Fields
	public const int k_iCallback = 4527;
	public HHTMLBrowser unBrowserHandle; // 0x0
	public HHTMLBrowser unOldBrowserHandle; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(2101)]
public struct HTTPRequestCompleted_t // TypeDefIndex: 10289
{
	// Fields
	public const int k_iCallback = 2101;
	public HTTPRequestHandle m_hRequest; // 0x0
	public ulong m_ulContextValue; // 0x8
	public bool m_bRequestSuccessful; // 0x10
	public EHTTPStatusCode m_eStatusCode; // 0x14
	public uint m_unBodySize; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(2102)]
public struct HTTPRequestHeadersReceived_t // TypeDefIndex: 10290
{
	// Fields
	public const int k_iCallback = 2102;
	public HTTPRequestHandle m_hRequest; // 0x0
	public ulong m_ulContextValue; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(2103)]
public struct HTTPRequestDataReceived_t // TypeDefIndex: 10291
{
	// Fields
	public const int k_iCallback = 2103;
	public HTTPRequestHandle m_hRequest; // 0x0
	public ulong m_ulContextValue; // 0x8
	public uint m_cOffset; // 0x10
	public uint m_cBytesReceived; // 0x14
}

// Namespace: Steamworks
[CallbackIdentity(2801)]
public struct SteamInputDeviceConnected_t // TypeDefIndex: 10292
{
	// Fields
	public const int k_iCallback = 2801;
	public InputHandle_t m_ulConnectedDeviceHandle; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(2802)]
public struct SteamInputDeviceDisconnected_t // TypeDefIndex: 10293
{
	// Fields
	public const int k_iCallback = 2802;
	public InputHandle_t m_ulDisconnectedDeviceHandle; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(2803)]
public struct SteamInputConfigurationLoaded_t // TypeDefIndex: 10294
{
	// Fields
	public const int k_iCallback = 2803;
	public AppId_t m_unAppID; // 0x0
	public InputHandle_t m_ulDeviceHandle; // 0x8
	public CSteamID m_ulMappingCreator; // 0x10
	public uint m_unMajorRevision; // 0x18
	public uint m_unMinorRevision; // 0x1C
	public bool m_bUsesSteamInputAPI; // 0x20
	public bool m_bUsesGamepadAPI; // 0x21
}

// Namespace: Steamworks
[CallbackIdentity(2804)]
public struct SteamInputGamepadSlotChange_t // TypeDefIndex: 10295
{
	// Fields
	public const int k_iCallback = 2804;
	public AppId_t m_unAppID; // 0x0
	public InputHandle_t m_ulDeviceHandle; // 0x8
	public ESteamInputType m_eDeviceType; // 0x10
	public int m_nOldGamepadSlot; // 0x14
	public int m_nNewGamepadSlot; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(4700)]
public struct SteamInventoryResultReady_t // TypeDefIndex: 10296
{
	// Fields
	public const int k_iCallback = 4700;
	public SteamInventoryResult_t m_handle; // 0x0
	public EResult m_result; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(4701)]
public struct SteamInventoryFullUpdate_t // TypeDefIndex: 10297
{
	// Fields
	public const int k_iCallback = 4701;
	public SteamInventoryResult_t m_handle; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4702)]
public struct SteamInventoryDefinitionUpdate_t // TypeDefIndex: 10298
{
	// Fields
	public const int k_iCallback = 4702;
}

// Namespace: Steamworks
[CallbackIdentity(4703)]
public struct SteamInventoryEligiblePromoItemDefIDs_t // TypeDefIndex: 10299
{
	// Fields
	public const int k_iCallback = 4703;
	public EResult m_result; // 0x0
	public CSteamID m_steamID; // 0x4
	public int m_numEligiblePromoItemDefs; // 0xC
	public bool m_bCachedData; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(4704)]
public struct SteamInventoryStartPurchaseResult_t // TypeDefIndex: 10300
{
	// Fields
	public const int k_iCallback = 4704;
	public EResult m_result; // 0x0
	public ulong m_ulOrderID; // 0x8
	public ulong m_ulTransID; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(4705)]
public struct SteamInventoryRequestPricesResult_t // TypeDefIndex: 10301
{
	// Fields
	public const int k_iCallback = 4705;
	public EResult m_result; // 0x0
	private byte[] m_rgchCurrency_; // 0x8

	// Properties
	public string m_rgchCurrency { get; set; }

	// Methods

	// RVA: 0x594210 Offset: 0x592810 VA: 0x180594210
	public string get_m_rgchCurrency() { }

	// RVA: 0x5C4960 Offset: 0x5C2F60 VA: 0x1805C4960
	public void set_m_rgchCurrency(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(502)]
public struct FavoritesListChanged_t // TypeDefIndex: 10302
{
	// Fields
	public const int k_iCallback = 502;
	public uint m_nIP; // 0x0
	public uint m_nQueryPort; // 0x4
	public uint m_nConnPort; // 0x8
	public uint m_nAppID; // 0xC
	public uint m_nFlags; // 0x10
	public bool m_bAdd; // 0x14
	public AccountID_t m_unAccountId; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(503)]
public struct LobbyInvite_t // TypeDefIndex: 10303
{
	// Fields
	public const int k_iCallback = 503;
	public ulong m_ulSteamIDUser; // 0x0
	public ulong m_ulSteamIDLobby; // 0x8
	public ulong m_ulGameID; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(504)]
public struct LobbyEnter_t // TypeDefIndex: 10304
{
	// Fields
	public const int k_iCallback = 504;
	public ulong m_ulSteamIDLobby; // 0x0
	public uint m_rgfChatPermissions; // 0x8
	public bool m_bLocked; // 0xC
	public uint m_EChatRoomEnterResponse; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(505)]
public struct LobbyDataUpdate_t // TypeDefIndex: 10305
{
	// Fields
	public const int k_iCallback = 505;
	public ulong m_ulSteamIDLobby; // 0x0
	public ulong m_ulSteamIDMember; // 0x8
	public byte m_bSuccess; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(506)]
public struct LobbyChatUpdate_t // TypeDefIndex: 10306
{
	// Fields
	public const int k_iCallback = 506;
	public ulong m_ulSteamIDLobby; // 0x0
	public ulong m_ulSteamIDUserChanged; // 0x8
	public ulong m_ulSteamIDMakingChange; // 0x10
	public uint m_rgfChatMemberStateChange; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(507)]
public struct LobbyChatMsg_t // TypeDefIndex: 10307
{
	// Fields
	public const int k_iCallback = 507;
	public ulong m_ulSteamIDLobby; // 0x0
	public ulong m_ulSteamIDUser; // 0x8
	public byte m_eChatEntryType; // 0x10
	public uint m_iChatID; // 0x14
}

// Namespace: Steamworks
[CallbackIdentity(509)]
public struct LobbyGameCreated_t // TypeDefIndex: 10308
{
	// Fields
	public const int k_iCallback = 509;
	public ulong m_ulSteamIDLobby; // 0x0
	public ulong m_ulSteamIDGameServer; // 0x8
	public uint m_unIP; // 0x10
	public ushort m_usPort; // 0x14
}

// Namespace: Steamworks
[CallbackIdentity(510)]
public struct LobbyMatchList_t // TypeDefIndex: 10309
{
	// Fields
	public const int k_iCallback = 510;
	public uint m_nLobbiesMatching; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(512)]
public struct LobbyKicked_t // TypeDefIndex: 10310
{
	// Fields
	public const int k_iCallback = 512;
	public ulong m_ulSteamIDLobby; // 0x0
	public ulong m_ulSteamIDAdmin; // 0x8
	public byte m_bKickedDueToDisconnect; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(513)]
public struct LobbyCreated_t // TypeDefIndex: 10311
{
	// Fields
	public const int k_iCallback = 513;
	public EResult m_eResult; // 0x0
	public ulong m_ulSteamIDLobby; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(516)]
public struct FavoritesListAccountsUpdated_t // TypeDefIndex: 10312
{
	// Fields
	public const int k_iCallback = 516;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(5201)]
public struct SearchForGameProgressCallback_t // TypeDefIndex: 10313
{
	// Fields
	public const int k_iCallback = 5201;
	public ulong m_ullSearchID; // 0x0
	public EResult m_eResult; // 0x8
	public CSteamID m_lobbyID; // 0xC
	public CSteamID m_steamIDEndedSearch; // 0x14
	public int m_nSecondsRemainingEstimate; // 0x1C
	public int m_cPlayersSearching; // 0x20
}

// Namespace: Steamworks
[CallbackIdentity(5202)]
public struct SearchForGameResultCallback_t // TypeDefIndex: 10314
{
	// Fields
	public const int k_iCallback = 5202;
	public ulong m_ullSearchID; // 0x0
	public EResult m_eResult; // 0x8
	public int m_nCountPlayersInGame; // 0xC
	public int m_nCountAcceptedGame; // 0x10
	public CSteamID m_steamIDHost; // 0x14
	public bool m_bFinalCallback; // 0x1C
}

// Namespace: Steamworks
[CallbackIdentity(5211)]
public struct RequestPlayersForGameProgressCallback_t // TypeDefIndex: 10315
{
	// Fields
	public const int k_iCallback = 5211;
	public EResult m_eResult; // 0x0
	public ulong m_ullSearchID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(5212)]
public struct RequestPlayersForGameResultCallback_t // TypeDefIndex: 10316
{
	// Fields
	public const int k_iCallback = 5212;
	public EResult m_eResult; // 0x0
	public ulong m_ullSearchID; // 0x8
	public CSteamID m_SteamIDPlayerFound; // 0x10
	public CSteamID m_SteamIDLobby; // 0x18
	public PlayerAcceptState_t m_ePlayerAcceptState; // 0x20
	public int m_nPlayerIndex; // 0x24
	public int m_nTotalPlayersFound; // 0x28
	public int m_nTotalPlayersAcceptedGame; // 0x2C
	public int m_nSuggestedTeamIndex; // 0x30
	public ulong m_ullUniqueGameID; // 0x38
}

// Namespace: Steamworks
[CallbackIdentity(5213)]
public struct RequestPlayersForGameFinalResultCallback_t // TypeDefIndex: 10317
{
	// Fields
	public const int k_iCallback = 5213;
	public EResult m_eResult; // 0x0
	public ulong m_ullSearchID; // 0x8
	public ulong m_ullUniqueGameID; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(5214)]
public struct SubmitPlayerResultResultCallback_t // TypeDefIndex: 10318
{
	// Fields
	public const int k_iCallback = 5214;
	public EResult m_eResult; // 0x0
	public ulong ullUniqueGameID; // 0x8
	public CSteamID steamIDPlayer; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(5215)]
public struct EndGameResultCallback_t // TypeDefIndex: 10319
{
	// Fields
	public const int k_iCallback = 5215;
	public EResult m_eResult; // 0x0
	public ulong ullUniqueGameID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(5301)]
public struct JoinPartyCallback_t // TypeDefIndex: 10320
{
	// Fields
	public const int k_iCallback = 5301;
	public EResult m_eResult; // 0x0
	public PartyBeaconID_t m_ulBeaconID; // 0x8
	public CSteamID m_SteamIDBeaconOwner; // 0x10
	private byte[] m_rgchConnectString_; // 0x18

	// Properties
	public string m_rgchConnectString { get; set; }

	// Methods

	// RVA: 0x597EA0 Offset: 0x5964A0 VA: 0x180597EA0
	public string get_m_rgchConnectString() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_rgchConnectString(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(5302)]
public struct CreateBeaconCallback_t // TypeDefIndex: 10321
{
	// Fields
	public const int k_iCallback = 5302;
	public EResult m_eResult; // 0x0
	public PartyBeaconID_t m_ulBeaconID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(5303)]
public struct ReservationNotificationCallback_t // TypeDefIndex: 10322
{
	// Fields
	public const int k_iCallback = 5303;
	public PartyBeaconID_t m_ulBeaconID; // 0x0
	public CSteamID m_steamIDJoiner; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(5304)]
public struct ChangeNumOpenSlotsCallback_t // TypeDefIndex: 10323
{
	// Fields
	public const int k_iCallback = 5304;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(5305)]
public struct AvailableBeaconLocationsUpdated_t // TypeDefIndex: 10324
{
	// Fields
	public const int k_iCallback = 5305;
}

// Namespace: Steamworks
[CallbackIdentity(5306)]
public struct ActiveBeaconsUpdated_t // TypeDefIndex: 10325
{
	// Fields
	public const int k_iCallback = 5306;
}

// Namespace: Steamworks
[CallbackIdentity(4001)]
public struct PlaybackStatusHasChanged_t // TypeDefIndex: 10326
{
	// Fields
	public const int k_iCallback = 4001;
}

// Namespace: Steamworks
[CallbackIdentity(4002)]
public struct VolumeHasChanged_t // TypeDefIndex: 10327
{
	// Fields
	public const int k_iCallback = 4002;
	public float m_flNewVolume; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4101)]
public struct MusicPlayerRemoteWillActivate_t // TypeDefIndex: 10328
{
	// Fields
	public const int k_iCallback = 4101;
}

// Namespace: Steamworks
[CallbackIdentity(4102)]
public struct MusicPlayerRemoteWillDeactivate_t // TypeDefIndex: 10329
{
	// Fields
	public const int k_iCallback = 4102;
}

// Namespace: Steamworks
[CallbackIdentity(4103)]
public struct MusicPlayerRemoteToFront_t // TypeDefIndex: 10330
{
	// Fields
	public const int k_iCallback = 4103;
}

// Namespace: Steamworks
[CallbackIdentity(4104)]
public struct MusicPlayerWillQuit_t // TypeDefIndex: 10331
{
	// Fields
	public const int k_iCallback = 4104;
}

// Namespace: Steamworks
[CallbackIdentity(4105)]
public struct MusicPlayerWantsPlay_t // TypeDefIndex: 10332
{
	// Fields
	public const int k_iCallback = 4105;
}

// Namespace: Steamworks
[CallbackIdentity(4106)]
public struct MusicPlayerWantsPause_t // TypeDefIndex: 10333
{
	// Fields
	public const int k_iCallback = 4106;
}

// Namespace: Steamworks
[CallbackIdentity(4107)]
public struct MusicPlayerWantsPlayPrevious_t // TypeDefIndex: 10334
{
	// Fields
	public const int k_iCallback = 4107;
}

// Namespace: Steamworks
[CallbackIdentity(4108)]
public struct MusicPlayerWantsPlayNext_t // TypeDefIndex: 10335
{
	// Fields
	public const int k_iCallback = 4108;
}

// Namespace: Steamworks
[CallbackIdentity(4109)]
public struct MusicPlayerWantsShuffled_t // TypeDefIndex: 10336
{
	// Fields
	public const int k_iCallback = 4109;
	public bool m_bShuffled; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4110)]
public struct MusicPlayerWantsLooped_t // TypeDefIndex: 10337
{
	// Fields
	public const int k_iCallback = 4110;
	public bool m_bLooped; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4011)]
public struct MusicPlayerWantsVolume_t // TypeDefIndex: 10338
{
	// Fields
	public const int k_iCallback = 4011;
	public float m_flNewVolume; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4012)]
public struct MusicPlayerSelectsQueueEntry_t // TypeDefIndex: 10339
{
	// Fields
	public const int k_iCallback = 4012;
	public int nID; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4013)]
public struct MusicPlayerSelectsPlaylistEntry_t // TypeDefIndex: 10340
{
	// Fields
	public const int k_iCallback = 4013;
	public int nID; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4114)]
public struct MusicPlayerWantsPlayingRepeatStatus_t // TypeDefIndex: 10341
{
	// Fields
	public const int k_iCallback = 4114;
	public int m_nPlayingRepeatStatus; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1202)]
public struct P2PSessionRequest_t // TypeDefIndex: 10342
{
	// Fields
	public const int k_iCallback = 1202;
	public CSteamID m_steamIDRemote; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1203)]
public struct P2PSessionConnectFail_t // TypeDefIndex: 10343
{
	// Fields
	public const int k_iCallback = 1203;
	public CSteamID m_steamIDRemote; // 0x0
	public byte m_eP2PSessionError; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1201)]
public struct SocketStatusCallback_t // TypeDefIndex: 10344
{
	// Fields
	public const int k_iCallback = 1201;
	public SNetSocket_t m_hSocket; // 0x0
	public SNetListenSocket_t m_hListenSocket; // 0x4
	public CSteamID m_steamIDRemote; // 0x8
	public int m_eSNetSocketState; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1251)]
public struct SteamNetworkingMessagesSessionRequest_t // TypeDefIndex: 10345
{
	// Fields
	public const int k_iCallback = 1251;
	public SteamNetworkingIdentity m_identityRemote; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1252)]
public struct SteamNetworkingMessagesSessionFailed_t // TypeDefIndex: 10346
{
	// Fields
	public const int k_iCallback = 1252;
	public SteamNetConnectionInfo_t m_info; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1221)]
public struct SteamNetConnectionStatusChangedCallback_t // TypeDefIndex: 10347
{
	// Fields
	public const int k_iCallback = 1221;
	public HSteamNetConnection m_hConn; // 0x0
	public SteamNetConnectionInfo_t m_info; // 0x8
	public ESteamNetworkingConnectionState m_eOldState; // 0xE8
}

// Namespace: Steamworks
[CallbackIdentity(1222)]
public struct SteamNetAuthenticationStatus_t // TypeDefIndex: 10348
{
	// Fields
	public const int k_iCallback = 1222;
	public ESteamNetworkingAvailability m_eAvail; // 0x0
	private byte[] m_debugMsg_; // 0x8

	// Properties
	public string m_debugMsg { get; set; }

	// Methods

	// RVA: 0x594210 Offset: 0x592810 VA: 0x180594210
	public string get_m_debugMsg() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_debugMsg(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1281)]
public struct SteamRelayNetworkStatus_t // TypeDefIndex: 10349
{
	// Fields
	public const int k_iCallback = 1281;
	public ESteamNetworkingAvailability m_eAvail; // 0x0
	public int m_bPingMeasurementInProgress; // 0x4
	public ESteamNetworkingAvailability m_eAvailNetworkConfig; // 0x8
	public ESteamNetworkingAvailability m_eAvailAnyRelay; // 0xC
	private byte[] m_debugMsg_; // 0x10

	// Properties
	public string m_debugMsg { get; set; }

	// Methods

	// RVA: 0x58E490 Offset: 0x58CA90 VA: 0x18058E490
	public string get_m_debugMsg() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_debugMsg(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(5001)]
public struct SteamParentalSettingsChanged_t // TypeDefIndex: 10350
{
	// Fields
	public const int k_iCallback = 5001;
}

// Namespace: Steamworks
[CallbackIdentity(5701)]
public struct SteamRemotePlaySessionConnected_t // TypeDefIndex: 10351
{
	// Fields
	public const int k_iCallback = 5701;
	public RemotePlaySessionID_t m_unSessionID; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(5702)]
public struct SteamRemotePlaySessionDisconnected_t // TypeDefIndex: 10352
{
	// Fields
	public const int k_iCallback = 5702;
	public RemotePlaySessionID_t m_unSessionID; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(5703)]
public struct SteamRemotePlayTogetherGuestInvite_t // TypeDefIndex: 10353
{
	// Fields
	public const int k_iCallback = 5703;
	private byte[] m_szConnectURL_; // 0x0

	// Properties
	public string m_szConnectURL { get; set; }

	// Methods

	// RVA: 0x5943F0 Offset: 0x5929F0 VA: 0x1805943F0
	public string get_m_szConnectURL() { }

	// RVA: 0x5C28F0 Offset: 0x5C0EF0 VA: 0x1805C28F0
	public void set_m_szConnectURL(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1307)]
public struct RemoteStorageFileShareResult_t // TypeDefIndex: 10354
{
	// Fields
	public const int k_iCallback = 1307;
	public EResult m_eResult; // 0x0
	public UGCHandle_t m_hFile; // 0x8
	private byte[] m_rgchFilename_; // 0x10

	// Properties
	public string m_rgchFilename { get; set; }

	// Methods

	// RVA: 0x58E490 Offset: 0x58CA90 VA: 0x18058E490
	public string get_m_rgchFilename() { }

	// RVA: 0x5C3000 Offset: 0x5C1600 VA: 0x1805C3000
	public void set_m_rgchFilename(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1309)]
public struct RemoteStoragePublishFileResult_t // TypeDefIndex: 10355
{
	// Fields
	public const int k_iCallback = 1309;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1311)]
public struct RemoteStorageDeletePublishedFileResult_t // TypeDefIndex: 10356
{
	// Fields
	public const int k_iCallback = 1311;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1312)]
public struct RemoteStorageEnumerateUserPublishedFilesResult_t // TypeDefIndex: 10357
{
	// Fields
	public const int k_iCallback = 1312;
	public EResult m_eResult; // 0x0
	public int m_nResultsReturned; // 0x4
	public int m_nTotalResultCount; // 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1313)]
public struct RemoteStorageSubscribePublishedFileResult_t // TypeDefIndex: 10358
{
	// Fields
	public const int k_iCallback = 1313;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1314)]
public struct RemoteStorageEnumerateUserSubscribedFilesResult_t // TypeDefIndex: 10359
{
	// Fields
	public const int k_iCallback = 1314;
	public EResult m_eResult; // 0x0
	public int m_nResultsReturned; // 0x4
	public int m_nTotalResultCount; // 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
	public uint[] m_rgRTimeSubscribed; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(1315)]
public struct RemoteStorageUnsubscribePublishedFileResult_t // TypeDefIndex: 10360
{
	// Fields
	public const int k_iCallback = 1315;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1316)]
public struct RemoteStorageUpdatePublishedFileResult_t // TypeDefIndex: 10361
{
	// Fields
	public const int k_iCallback = 1316;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1317)]
public struct RemoteStorageDownloadUGCResult_t // TypeDefIndex: 10362
{
	// Fields
	public const int k_iCallback = 1317;
	public EResult m_eResult; // 0x0
	public UGCHandle_t m_hFile; // 0x8
	public AppId_t m_nAppID; // 0x10
	public int m_nSizeInBytes; // 0x14
	private byte[] m_pchFileName_; // 0x18
	public ulong m_ulSteamIDOwner; // 0x20

	// Properties
	public string m_pchFileName { get; set; }

	// Methods

	// RVA: 0x597EA0 Offset: 0x5964A0 VA: 0x180597EA0
	public string get_m_pchFileName() { }

	// RVA: 0x5C3000 Offset: 0x5C1600 VA: 0x1805C3000
	public void set_m_pchFileName(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1318)]
public struct RemoteStorageGetPublishedFileDetailsResult_t // TypeDefIndex: 10363
{
	// Fields
	public const int k_iCallback = 1318;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public AppId_t m_nCreatorAppID; // 0x10
	public AppId_t m_nConsumerAppID; // 0x14
	private byte[] m_rgchTitle_; // 0x18
	private byte[] m_rgchDescription_; // 0x20
	public UGCHandle_t m_hFile; // 0x28
	public UGCHandle_t m_hPreviewFile; // 0x30
	public ulong m_ulSteamIDOwner; // 0x38
	public uint m_rtimeCreated; // 0x40
	public uint m_rtimeUpdated; // 0x44
	public ERemoteStoragePublishedFileVisibility m_eVisibility; // 0x48
	public bool m_bBanned; // 0x4C
	private byte[] m_rgchTags_; // 0x50
	public bool m_bTagsTruncated; // 0x58
	private byte[] m_pchFileName_; // 0x60
	public int m_nFileSize; // 0x68
	public int m_nPreviewFileSize; // 0x6C
	private byte[] m_rgchURL_; // 0x70
	public EWorkshopFileType m_eFileType; // 0x78
	public bool m_bAcceptedForUse; // 0x7C

	// Properties
	public string m_rgchTitle { get; set; }
	public string m_rgchDescription { get; set; }
	public string m_rgchTags { get; set; }
	public string m_pchFileName { get; set; }
	public string m_rgchURL { get; set; }

	// Methods

	// RVA: 0x597EA0 Offset: 0x5964A0 VA: 0x180597EA0
	public string get_m_rgchTitle() { }

	// RVA: 0x5C3410 Offset: 0x5C1A10 VA: 0x1805C3410
	public void set_m_rgchTitle(string value) { }

	// RVA: 0x5C3130 Offset: 0x5C1730 VA: 0x1805C3130
	public string get_m_rgchDescription() { }

	// RVA: 0x5C32B0 Offset: 0x5C18B0 VA: 0x1805C32B0
	public void set_m_rgchDescription(string value) { }

	// RVA: 0x5C31B0 Offset: 0x5C17B0 VA: 0x1805C31B0
	public string get_m_rgchTags() { }

	// RVA: 0x5C3360 Offset: 0x5C1960 VA: 0x1805C3360
	public void set_m_rgchTags(string value) { }

	// RVA: 0x5C30B0 Offset: 0x5C16B0 VA: 0x1805C30B0
	public string get_m_pchFileName() { }

	// RVA: 0x5C3000 Offset: 0x5C1600 VA: 0x1805C3000
	public void set_m_pchFileName(string value) { }

	// RVA: 0x5C3230 Offset: 0x5C1830 VA: 0x1805C3230
	public string get_m_rgchURL() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_rgchURL(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1319)]
public struct RemoteStorageEnumerateWorkshopFilesResult_t // TypeDefIndex: 10364
{
	// Fields
	public const int k_iCallback = 1319;
	public EResult m_eResult; // 0x0
	public int m_nResultsReturned; // 0x4
	public int m_nTotalResultCount; // 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
	public float[] m_rgScore; // 0x18
	public AppId_t m_nAppId; // 0x20
	public uint m_unStartIndex; // 0x24
}

// Namespace: Steamworks
[CallbackIdentity(1320)]
public struct RemoteStorageGetPublishedItemVoteDetailsResult_t // TypeDefIndex: 10365
{
	// Fields
	public const int k_iCallback = 1320;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_unPublishedFileId; // 0x8
	public int m_nVotesFor; // 0x10
	public int m_nVotesAgainst; // 0x14
	public int m_nReports; // 0x18
	public float m_fScore; // 0x1C
}

// Namespace: Steamworks
[CallbackIdentity(1321)]
public struct RemoteStoragePublishedFileSubscribed_t // TypeDefIndex: 10366
{
	// Fields
	public const int k_iCallback = 1321;
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public AppId_t m_nAppID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1322)]
public struct RemoteStoragePublishedFileUnsubscribed_t // TypeDefIndex: 10367
{
	// Fields
	public const int k_iCallback = 1322;
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public AppId_t m_nAppID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1323)]
public struct RemoteStoragePublishedFileDeleted_t // TypeDefIndex: 10368
{
	// Fields
	public const int k_iCallback = 1323;
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public AppId_t m_nAppID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1324)]
public struct RemoteStorageUpdateUserPublishedItemVoteResult_t // TypeDefIndex: 10369
{
	// Fields
	public const int k_iCallback = 1324;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1325)]
public struct RemoteStorageUserVoteDetails_t // TypeDefIndex: 10370
{
	// Fields
	public const int k_iCallback = 1325;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public EWorkshopVote m_eVote; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1326)]
public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t // TypeDefIndex: 10371
{
	// Fields
	public const int k_iCallback = 1326;
	public EResult m_eResult; // 0x0
	public int m_nResultsReturned; // 0x4
	public int m_nTotalResultCount; // 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1327)]
public struct RemoteStorageSetUserPublishedFileActionResult_t // TypeDefIndex: 10372
{
	// Fields
	public const int k_iCallback = 1327;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public EWorkshopFileAction m_eAction; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1328)]
public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t // TypeDefIndex: 10373
{
	// Fields
	public const int k_iCallback = 1328;
	public EResult m_eResult; // 0x0
	public EWorkshopFileAction m_eAction; // 0x4
	public int m_nResultsReturned; // 0x8
	public int m_nTotalResultCount; // 0xC
	public PublishedFileId_t[] m_rgPublishedFileId; // 0x10
	public uint[] m_rgRTimeUpdated; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(1329)]
public struct RemoteStoragePublishFileProgress_t // TypeDefIndex: 10374
{
	// Fields
	public const int k_iCallback = 1329;
	public double m_dPercentFile; // 0x0
	public bool m_bPreview; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1330)]
public struct RemoteStoragePublishedFileUpdated_t // TypeDefIndex: 10375
{
	// Fields
	public const int k_iCallback = 1330;
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public AppId_t m_nAppID; // 0x8
	public ulong m_ulUnused; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1331)]
public struct RemoteStorageFileWriteAsyncComplete_t // TypeDefIndex: 10376
{
	// Fields
	public const int k_iCallback = 1331;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1332)]
public struct RemoteStorageFileReadAsyncComplete_t // TypeDefIndex: 10377
{
	// Fields
	public const int k_iCallback = 1332;
	public SteamAPICall_t m_hFileReadAsync; // 0x0
	public EResult m_eResult; // 0x8
	public uint m_nOffset; // 0xC
	public uint m_cubRead; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1333)]
public struct RemoteStorageLocalFileChange_t // TypeDefIndex: 10378
{
	// Fields
	public const int k_iCallback = 1333;
}

// Namespace: Steamworks
[CallbackIdentity(2301)]
public struct ScreenshotReady_t // TypeDefIndex: 10379
{
	// Fields
	public const int k_iCallback = 2301;
	public ScreenshotHandle m_hLocal; // 0x0
	public EResult m_eResult; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(2302)]
public struct ScreenshotRequested_t // TypeDefIndex: 10380
{
	// Fields
	public const int k_iCallback = 2302;
}

// Namespace: Steamworks
[CallbackIdentity(3401)]
public struct SteamUGCQueryCompleted_t // TypeDefIndex: 10381
{
	// Fields
	public const int k_iCallback = 3401;
	public UGCQueryHandle_t m_handle; // 0x0
	public EResult m_eResult; // 0x8
	public uint m_unNumResultsReturned; // 0xC
	public uint m_unTotalMatchingResults; // 0x10
	public bool m_bCachedData; // 0x14
	private byte[] m_rgchNextCursor_; // 0x18

	// Properties
	public string m_rgchNextCursor { get; set; }

	// Methods

	// RVA: 0x597EA0 Offset: 0x5964A0 VA: 0x180597EA0
	public string get_m_rgchNextCursor() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_rgchNextCursor(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(3402)]
public struct SteamUGCRequestUGCDetailsResult_t // TypeDefIndex: 10382
{
	// Fields
	public const int k_iCallback = 3402;
	public SteamUGCDetails_t m_details; // 0x0
	public bool m_bCachedData; // 0x90
}

// Namespace: Steamworks
[CallbackIdentity(3403)]
public struct CreateItemResult_t // TypeDefIndex: 10383
{
	// Fields
	public const int k_iCallback = 3403;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(3404)]
public struct SubmitItemUpdateResult_t // TypeDefIndex: 10384
{
	// Fields
	public const int k_iCallback = 3404;
	public EResult m_eResult; // 0x0
	public bool m_bUserNeedsToAcceptWorkshopLegalAgreement; // 0x4
	public PublishedFileId_t m_nPublishedFileId; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(3405)]
public struct ItemInstalled_t // TypeDefIndex: 10385
{
	// Fields
	public const int k_iCallback = 3405;
	public AppId_t m_unAppID; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public UGCHandle_t m_hLegacyContent; // 0x10
	public ulong m_unManifestID; // 0x18
}

// Namespace: Steamworks
[CallbackIdentity(3406)]
public struct DownloadItemResult_t // TypeDefIndex: 10386
{
	// Fields
	public const int k_iCallback = 3406;
	public AppId_t m_unAppID; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public EResult m_eResult; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(3407)]
public struct UserFavoriteItemsListChanged_t // TypeDefIndex: 10387
{
	// Fields
	public const int k_iCallback = 3407;
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public EResult m_eResult; // 0x8
	public bool m_bWasAddRequest; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(3408)]
public struct SetUserItemVoteResult_t // TypeDefIndex: 10388
{
	// Fields
	public const int k_iCallback = 3408;
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public EResult m_eResult; // 0x8
	public bool m_bVoteUp; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(3409)]
public struct GetUserItemVoteResult_t // TypeDefIndex: 10389
{
	// Fields
	public const int k_iCallback = 3409;
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public EResult m_eResult; // 0x8
	public bool m_bVotedUp; // 0xC
	public bool m_bVotedDown; // 0xD
	public bool m_bVoteSkipped; // 0xE
}

// Namespace: Steamworks
[CallbackIdentity(3410)]
public struct StartPlaytimeTrackingResult_t // TypeDefIndex: 10390
{
	// Fields
	public const int k_iCallback = 3410;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(3411)]
public struct StopPlaytimeTrackingResult_t // TypeDefIndex: 10391
{
	// Fields
	public const int k_iCallback = 3411;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(3412)]
public struct AddUGCDependencyResult_t // TypeDefIndex: 10392
{
	// Fields
	public const int k_iCallback = 3412;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public PublishedFileId_t m_nChildPublishedFileId; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(3413)]
public struct RemoveUGCDependencyResult_t // TypeDefIndex: 10393
{
	// Fields
	public const int k_iCallback = 3413;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public PublishedFileId_t m_nChildPublishedFileId; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(3414)]
public struct AddAppDependencyResult_t // TypeDefIndex: 10394
{
	// Fields
	public const int k_iCallback = 3414;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public AppId_t m_nAppID; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(3415)]
public struct RemoveAppDependencyResult_t // TypeDefIndex: 10395
{
	// Fields
	public const int k_iCallback = 3415;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public AppId_t m_nAppID; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(3416)]
public struct GetAppDependenciesResult_t // TypeDefIndex: 10396
{
	// Fields
	public const int k_iCallback = 3416;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
	public AppId_t[] m_rgAppIDs; // 0x10
	public uint m_nNumAppDependencies; // 0x18
	public uint m_nTotalNumAppDependencies; // 0x1C
}

// Namespace: Steamworks
[CallbackIdentity(3417)]
public struct DeleteItemResult_t // TypeDefIndex: 10397
{
	// Fields
	public const int k_iCallback = 3417;
	public EResult m_eResult; // 0x0
	public PublishedFileId_t m_nPublishedFileId; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(3418)]
public struct UserSubscribedItemsListChanged_t // TypeDefIndex: 10398
{
	// Fields
	public const int k_iCallback = 3418;
	public AppId_t m_nAppID; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(3420)]
public struct WorkshopEULAStatus_t // TypeDefIndex: 10399
{
	// Fields
	public const int k_iCallback = 3420;
	public EResult m_eResult; // 0x0
	public AppId_t m_nAppID; // 0x4
	public uint m_unVersion; // 0x8
	public RTime32 m_rtAction; // 0xC
	public bool m_bAccepted; // 0x10
	public bool m_bNeedsAction; // 0x11
}

// Namespace: Steamworks
[CallbackIdentity(101)]
public struct SteamServersConnected_t // TypeDefIndex: 10400
{
	// Fields
	public const int k_iCallback = 101;
}

// Namespace: Steamworks
[CallbackIdentity(102)]
public struct SteamServerConnectFailure_t // TypeDefIndex: 10401
{
	// Fields
	public const int k_iCallback = 102;
	public EResult m_eResult; // 0x0
	public bool m_bStillRetrying; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(103)]
public struct SteamServersDisconnected_t // TypeDefIndex: 10402
{
	// Fields
	public const int k_iCallback = 103;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(113)]
public struct ClientGameServerDeny_t // TypeDefIndex: 10403
{
	// Fields
	public const int k_iCallback = 113;
	public uint m_uAppID; // 0x0
	public uint m_unGameServerIP; // 0x4
	public ushort m_usGameServerPort; // 0x8
	public ushort m_bSecure; // 0xA
	public uint m_uReason; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(117)]
public struct IPCFailure_t // TypeDefIndex: 10404
{
	// Fields
	public const int k_iCallback = 117;
	public byte m_eFailureType; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(125)]
public struct LicensesUpdated_t // TypeDefIndex: 10405
{
	// Fields
	public const int k_iCallback = 125;
}

// Namespace: Steamworks
[CallbackIdentity(143)]
public struct ValidateAuthTicketResponse_t // TypeDefIndex: 10406
{
	// Fields
	public const int k_iCallback = 143;
	public CSteamID m_SteamID; // 0x0
	public EAuthSessionResponse m_eAuthSessionResponse; // 0x8
	public CSteamID m_OwnerSteamID; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(152)]
public struct MicroTxnAuthorizationResponse_t // TypeDefIndex: 10407
{
	// Fields
	public const int k_iCallback = 152;
	public uint m_unAppID; // 0x0
	public ulong m_ulOrderID; // 0x8
	public byte m_bAuthorized; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(154)]
public struct EncryptedAppTicketResponse_t // TypeDefIndex: 10408
{
	// Fields
	public const int k_iCallback = 154;
	public EResult m_eResult; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(163)]
public struct GetAuthSessionTicketResponse_t // TypeDefIndex: 10409
{
	// Fields
	public const int k_iCallback = 163;
	public HAuthTicket m_hAuthTicket; // 0x0
	public EResult m_eResult; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(164)]
public struct GameWebCallback_t // TypeDefIndex: 10410
{
	// Fields
	public const int k_iCallback = 164;
	private byte[] m_szURL_; // 0x0

	// Properties
	public string m_szURL { get; set; }

	// Methods

	// RVA: 0x5943F0 Offset: 0x5929F0 VA: 0x1805943F0
	public string get_m_szURL() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_szURL(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(165)]
public struct StoreAuthURLResponse_t // TypeDefIndex: 10411
{
	// Fields
	public const int k_iCallback = 165;
	private byte[] m_szURL_; // 0x0

	// Properties
	public string m_szURL { get; set; }

	// Methods

	// RVA: 0x5943F0 Offset: 0x5929F0 VA: 0x1805943F0
	public string get_m_szURL() { }

	// RVA: 0x5CF230 Offset: 0x5CD830 VA: 0x1805CF230
	public void set_m_szURL(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(166)]
public struct MarketEligibilityResponse_t // TypeDefIndex: 10412
{
	// Fields
	public const int k_iCallback = 166;
	public bool m_bAllowed; // 0x0
	public EMarketNotAllowedReasonFlags m_eNotAllowedReason; // 0x4
	public RTime32 m_rtAllowedAtTime; // 0x8
	public int m_cdaySteamGuardRequiredDays; // 0xC
	public int m_cdayNewDeviceCooldown; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(167)]
public struct DurationControl_t // TypeDefIndex: 10413
{
	// Fields
	public const int k_iCallback = 167;
	public EResult m_eResult; // 0x0
	public AppId_t m_appid; // 0x4
	public bool m_bApplicable; // 0x8
	public int m_csecsLast5h; // 0xC
	public EDurationControlProgress m_progress; // 0x10
	public EDurationControlNotification m_notification; // 0x14
	public int m_csecsToday; // 0x18
	public int m_csecsRemaining; // 0x1C
}

// Namespace: Steamworks
[CallbackIdentity(168)]
public struct GetTicketForWebApiResponse_t // TypeDefIndex: 10414
{
	// Fields
	public const int k_iCallback = 168;
	public HAuthTicket m_hAuthTicket; // 0x0
	public EResult m_eResult; // 0x4
	public int m_cubTicket; // 0x8
	public byte[] m_rgubTicket; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1101)]
public struct UserStatsReceived_t // TypeDefIndex: 10415
{
	// Fields
	public const int k_iCallback = 1101;
	public ulong m_nGameID; // 0x0
	public EResult m_eResult; // 0x8
	public CSteamID m_steamIDUser; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(1102)]
public struct UserStatsStored_t // TypeDefIndex: 10416
{
	// Fields
	public const int k_iCallback = 1102;
	public ulong m_nGameID; // 0x0
	public EResult m_eResult; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1103)]
public struct UserAchievementStored_t // TypeDefIndex: 10417
{
	// Fields
	public const int k_iCallback = 1103;
	public ulong m_nGameID; // 0x0
	public bool m_bGroupAchievement; // 0x8
	private byte[] m_rgchAchievementName_; // 0x10
	public uint m_nCurProgress; // 0x18
	public uint m_nMaxProgress; // 0x1C

	// Properties
	public string m_rgchAchievementName { get; set; }

	// Methods

	// RVA: 0x58E490 Offset: 0x58CA90 VA: 0x18058E490
	public string get_m_rgchAchievementName() { }

	// RVA: 0x594290 Offset: 0x592890 VA: 0x180594290
	public void set_m_rgchAchievementName(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1104)]
public struct LeaderboardFindResult_t // TypeDefIndex: 10418
{
	// Fields
	public const int k_iCallback = 1104;
	public SteamLeaderboard_t m_hSteamLeaderboard; // 0x0
	public byte m_bLeaderboardFound; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1105)]
public struct LeaderboardScoresDownloaded_t // TypeDefIndex: 10419
{
	// Fields
	public const int k_iCallback = 1105;
	public SteamLeaderboard_t m_hSteamLeaderboard; // 0x0
	public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries; // 0x8
	public int m_cEntryCount; // 0x10
}

// Namespace: Steamworks
[CallbackIdentity(1106)]
public struct LeaderboardScoreUploaded_t // TypeDefIndex: 10420
{
	// Fields
	public const int k_iCallback = 1106;
	public byte m_bSuccess; // 0x0
	public SteamLeaderboard_t m_hSteamLeaderboard; // 0x8
	public int m_nScore; // 0x10
	public byte m_bScoreChanged; // 0x14
	public int m_nGlobalRankNew; // 0x18
	public int m_nGlobalRankPrevious; // 0x1C
}

// Namespace: Steamworks
[CallbackIdentity(1107)]
public struct NumberOfCurrentPlayers_t // TypeDefIndex: 10421
{
	// Fields
	public const int k_iCallback = 1107;
	public byte m_bSuccess; // 0x0
	public int m_cPlayers; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(1108)]
public struct UserStatsUnloaded_t // TypeDefIndex: 10422
{
	// Fields
	public const int k_iCallback = 1108;
	public CSteamID m_steamIDUser; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(1109)]
public struct UserAchievementIconFetched_t // TypeDefIndex: 10423
{
	// Fields
	public const int k_iCallback = 1109;
	public CGameID m_nGameID; // 0x0
	private byte[] m_rgchAchievementName_; // 0x8
	public bool m_bAchieved; // 0x10
	public int m_nIconHandle; // 0x14

	// Properties
	public string m_rgchAchievementName { get; set; }

	// Methods

	// RVA: 0x594210 Offset: 0x592810 VA: 0x180594210
	public string get_m_rgchAchievementName() { }

	// RVA: 0x594290 Offset: 0x592890 VA: 0x180594290
	public void set_m_rgchAchievementName(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(1110)]
public struct GlobalAchievementPercentagesReady_t // TypeDefIndex: 10424
{
	// Fields
	public const int k_iCallback = 1110;
	public ulong m_nGameID; // 0x0
	public EResult m_eResult; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1111)]
public struct LeaderboardUGCSet_t // TypeDefIndex: 10425
{
	// Fields
	public const int k_iCallback = 1111;
	public EResult m_eResult; // 0x0
	public SteamLeaderboard_t m_hSteamLeaderboard; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(1112)]
public struct GlobalStatsReceived_t // TypeDefIndex: 10426
{
	// Fields
	public const int k_iCallback = 1112;
	public ulong m_nGameID; // 0x0
	public EResult m_eResult; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(701)]
public struct IPCountry_t // TypeDefIndex: 10427
{
	// Fields
	public const int k_iCallback = 701;
}

// Namespace: Steamworks
[CallbackIdentity(702)]
public struct LowBatteryPower_t // TypeDefIndex: 10428
{
	// Fields
	public const int k_iCallback = 702;
	public byte m_nMinutesBatteryLeft; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(703)]
public struct SteamAPICallCompleted_t // TypeDefIndex: 10429
{
	// Fields
	public const int k_iCallback = 703;
	public SteamAPICall_t m_hAsyncCall; // 0x0
	public int m_iCallback; // 0x8
	public uint m_cubParam; // 0xC
}

// Namespace: Steamworks
[CallbackIdentity(704)]
public struct SteamShutdown_t // TypeDefIndex: 10430
{
	// Fields
	public const int k_iCallback = 704;
}

// Namespace: Steamworks
[CallbackIdentity(705)]
public struct CheckFileSignature_t // TypeDefIndex: 10431
{
	// Fields
	public const int k_iCallback = 705;
	public ECheckFileSignature m_eCheckFileSignature; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(714)]
public struct GamepadTextInputDismissed_t // TypeDefIndex: 10432
{
	// Fields
	public const int k_iCallback = 714;
	public bool m_bSubmitted; // 0x0
	public uint m_unSubmittedText; // 0x4
	public AppId_t m_unAppID; // 0x8
}

// Namespace: Steamworks
[CallbackIdentity(736)]
public struct AppResumingFromSuspend_t // TypeDefIndex: 10433
{
	// Fields
	public const int k_iCallback = 736;
}

// Namespace: Steamworks
[CallbackIdentity(738)]
public struct FloatingGamepadTextInputDismissed_t // TypeDefIndex: 10434
{
	// Fields
	public const int k_iCallback = 738;
}

// Namespace: Steamworks
[CallbackIdentity(739)]
public struct FilterTextDictionaryChanged_t // TypeDefIndex: 10435
{
	// Fields
	public const int k_iCallback = 739;
	public int m_eLanguage; // 0x0
}

// Namespace: Steamworks
[CallbackIdentity(4611)]
public struct GetVideoURLResult_t // TypeDefIndex: 10436
{
	// Fields
	public const int k_iCallback = 4611;
	public EResult m_eResult; // 0x0
	public AppId_t m_unVideoAppID; // 0x4
	private byte[] m_rgchURL_; // 0x8

	// Properties
	public string m_rgchURL { get; set; }

	// Methods

	// RVA: 0x594210 Offset: 0x592810 VA: 0x180594210
	public string get_m_rgchURL() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_rgchURL(string value) { }
}

// Namespace: Steamworks
[CallbackIdentity(4624)]
public struct GetOPFSettingsResult_t // TypeDefIndex: 10437
{
	// Fields
	public const int k_iCallback = 4624;
	public EResult m_eResult; // 0x0
	public AppId_t m_unVideoAppID; // 0x4
}

// Namespace: Steamworks
[CallbackIdentity(1223)]
public struct SteamNetworkingFakeIPResult_t // TypeDefIndex: 10438
{
	// Fields
	public const int k_iCallback = 1223;
	public EResult m_eResult; // 0x0
	public SteamNetworkingIdentity m_identity; // 0x4
	public uint m_unIP; // 0x8C
	public ushort[] m_unPorts; // 0x90
}

// Namespace: Steamworks
public static class Constants // TypeDefIndex: 10439
{
	// Fields
	public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008";
	public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";
	public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient021";
	public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends017";
	public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";
	public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer015";
	public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";
	public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_005";
	public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION003";
	public const string STEAMINPUT_INTERFACE_VERSION = "SteamInput006";
	public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V003";
	public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";
	public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";
	public const string STEAMGAMESEARCH_INTERFACE_VERSION = "SteamMatchGameSearch001";
	public const string STEAMPARTIES_INTERFACE_VERSION = "SteamParties002";
	public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";
	public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";
	public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking006";
	public const string STEAMNETWORKINGMESSAGES_INTERFACE_VERSION = "SteamNetworkingMessages002";
	public const string STEAMNETWORKINGSOCKETS_INTERFACE_VERSION = "SteamNetworkingSockets012";
	public const string STEAMNETWORKINGUTILS_INTERFACE_VERSION = "SteamNetworkingUtils004";
	public const string STEAMPARENTALSETTINGS_INTERFACE_VERSION = "STEAMPARENTALSETTINGS_INTERFACE_VERSION001";
	public const string STEAMREMOTEPLAY_INTERFACE_VERSION = "STEAMREMOTEPLAY_INTERFACE_VERSION002";
	public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION016";
	public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003";
	public const string STEAMTIMELINE_INTERFACE_VERSION = "STEAMTIMELINE_INTERFACE_V001";
	public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION020";
	public const string STEAMUSER_INTERFACE_VERSION = "SteamUser023";
	public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION012";
	public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils010";
	public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V007";
	public const int k_cubAppProofOfPurchaseKeyMax = 240;
	public const int k_cchMaxFriendsGroupName = 64;
	public const int k_cFriendsGroupLimit = 100;
	public const int k_cEnumerateFollowersMax = 50;
	public const ushort k_usFriendGameInfoQueryPort_NotInitialized = 65535;
	public const ushort k_usFriendGameInfoQueryPort_Error = 65534;
	public const int k_cchPersonaNameMax = 128;
	public const int k_cwchPersonaNameMax = 32;
	public const int k_cubChatMetadataMax = 8192;
	public const int k_cchMaxRichPresenceKeys = 30;
	public const int k_cchMaxRichPresenceKeyLength = 64;
	public const int k_cchMaxRichPresenceValueLength = 256;
	public const int k_unFavoriteFlagNone = 0;
	public const int k_unFavoriteFlagFavorite = 1;
	public const int k_unFavoriteFlagHistory = 2;
	public const int k_unMaxCloudFileChunkSize = 104857600;
	public const int k_cchPublishedDocumentTitleMax = 129;
	public const int k_cchPublishedDocumentDescriptionMax = 8000;
	public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;
	public const int k_unEnumeratePublishedFilesMaxResults = 50;
	public const int k_cchTagListMax = 1025;
	public const int k_cchFilenameMax = 260;
	public const int k_cchPublishedFileURLMax = 256;
	public const int k_nScreenshotMaxTaggedUsers = 32;
	public const int k_nScreenshotMaxTaggedPublishedFiles = 32;
	public const int k_cubUFSTagTypeMax = 255;
	public const int k_cubUFSTagValueMax = 255;
	public const int k_ScreenshotThumbWidth = 200;
	public const int k_unMaxTimelinePriority = 1000;
	public const float k_flMaxTimelineEventDuration = 600;
	public const int kNumUGCResultsPerPage = 50;
	public const int k_cchDeveloperMetadataMax = 5000;
	public const int k_nCubTicketMaxLength = 2560;
	public const int k_cchStatNameMax = 128;
	public const int k_cchLeaderboardNameMax = 128;
	public const int k_cLeaderboardDetailsMax = 64;
	public const int k_cbMaxGameServerGameDir = 32;
	public const int k_cbMaxGameServerMapName = 32;
	public const int k_cbMaxGameServerGameDescription = 64;
	public const int k_cbMaxGameServerName = 64;
	public const int k_cbMaxGameServerTags = 128;
	public const int k_cbMaxGameServerGameData = 2048;
	public const int k_cchMaxSteamErrMsg = 1024;
	public const int k_iSteamUserCallbacks = 100;
	public const int k_iSteamGameServerCallbacks = 200;
	public const int k_iSteamFriendsCallbacks = 300;
	public const int k_iSteamBillingCallbacks = 400;
	public const int k_iSteamMatchmakingCallbacks = 500;
	public const int k_iSteamContentServerCallbacks = 600;
	public const int k_iSteamUtilsCallbacks = 700;
	public const int k_iSteamAppsCallbacks = 1000;
	public const int k_iSteamUserStatsCallbacks = 1100;
	public const int k_iSteamNetworkingCallbacks = 1200;
	public const int k_iSteamNetworkingSocketsCallbacks = 1220;
	public const int k_iSteamNetworkingMessagesCallbacks = 1250;
	public const int k_iSteamNetworkingUtilsCallbacks = 1280;
	public const int k_iSteamRemoteStorageCallbacks = 1300;
	public const int k_iSteamGameServerItemsCallbacks = 1500;
	public const int k_iSteamGameCoordinatorCallbacks = 1700;
	public const int k_iSteamGameServerStatsCallbacks = 1800;
	public const int k_iSteam2AsyncCallbacks = 1900;
	public const int k_iSteamGameStatsCallbacks = 2000;
	public const int k_iSteamHTTPCallbacks = 2100;
	public const int k_iSteamScreenshotsCallbacks = 2300;
	public const int k_iSteamStreamLauncherCallbacks = 2600;
	public const int k_iSteamControllerCallbacks = 2800;
	public const int k_iSteamUGCCallbacks = 3400;
	public const int k_iSteamStreamClientCallbacks = 3500;
	public const int k_iSteamMusicCallbacks = 4000;
	public const int k_iSteamMusicRemoteCallbacks = 4100;
	public const int k_iSteamGameNotificationCallbacks = 4400;
	public const int k_iSteamHTMLSurfaceCallbacks = 4500;
	public const int k_iSteamVideoCallbacks = 4600;
	public const int k_iSteamInventoryCallbacks = 4700;
	public const int k_ISteamParentalSettingsCallbacks = 5000;
	public const int k_iSteamGameSearchCallbacks = 5200;
	public const int k_iSteamPartiesCallbacks = 5300;
	public const int k_iSteamSTARCallbacks = 5500;
	public const int k_iSteamRemotePlayCallbacks = 5700;
	public const int k_iSteamChatCallbacks = 5900;
	public const int k_iSteamTimelineCallbacks = 6000;
	public const ushort STEAMGAMESERVER_QUERY_PORT_SHARED = 65535;
	public const int k_unSteamAccountIDMask = -1;
	public const int k_unSteamAccountInstanceMask = 1048575;
	public const int k_unSteamUserDefaultInstance = 1;
	public const int k_cchGameExtraInfoMax = 64;
	public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;
	public const int k_nMaxReturnPorts = 8;
	public const int k_cchMaxSteamNetworkingErrMsg = 1024;
	public const int k_cchSteamNetworkingMaxConnectionCloseReason = 128;
	public const int k_cchSteamNetworkingMaxConnectionDescription = 128;
	public const int k_cchSteamNetworkingMaxConnectionAppName = 32;
	public const int k_nSteamNetworkConnectionInfoFlags_Unauthenticated = 1;
	public const int k_nSteamNetworkConnectionInfoFlags_Unencrypted = 2;
	public const int k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers = 4;
	public const int k_nSteamNetworkConnectionInfoFlags_Fast = 8;
	public const int k_nSteamNetworkConnectionInfoFlags_Relayed = 16;
	public const int k_nSteamNetworkConnectionInfoFlags_DualWifi = 32;
	public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 524288;
	public const int k_nSteamNetworkingSend_Unreliable = 0;
	public const int k_nSteamNetworkingSend_NoNagle = 1;
	public const int k_nSteamNetworkingSend_UnreliableNoNagle = 1;
	public const int k_nSteamNetworkingSend_NoDelay = 4;
	public const int k_nSteamNetworkingSend_UnreliableNoDelay = 5;
	public const int k_nSteamNetworkingSend_Reliable = 8;
	public const int k_nSteamNetworkingSend_ReliableNoNagle = 9;
	public const int k_nSteamNetworkingSend_UseCurrentThread = 16;
	public const int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;
	public const int k_cchMaxSteamNetworkingPingLocationString = 1024;
	public const int k_nSteamNetworkingPing_Failed = -1;
	public const int k_nSteamNetworkingPing_Unknown = -2;
	public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default = -1;
	public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable = 0;
	public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay = 1;
	public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private = 2;
	public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public = 4;
	public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All = 2147483647;
	public const ulong k_ulPartyBeaconIdInvalid = 0;
	public const int INVALID_HTTPREQUEST_HANDLE = 0;
	public const int STEAM_INPUT_MAX_COUNT = 16;
	public const int STEAM_INPUT_MAX_ANALOG_ACTIONS = 24;
	public const int STEAM_INPUT_MAX_DIGITAL_ACTIONS = 256;
	public const int STEAM_INPUT_MAX_ORIGINS = 8;
	public const int STEAM_INPUT_MAX_ACTIVE_LAYERS = 16;
	public const ulong STEAM_INPUT_HANDLE_ALL_CONTROLLERS = 18446744073709551615;
	public const float STEAM_INPUT_MIN_ANALOG_ACTION_DATA = -1;
	public const float STEAM_INPUT_MAX_ANALOG_ACTION_DATA = 1;
	public const byte k_nMaxLobbyKeyLength = 255;
	public const int k_SteamMusicNameMaxLength = 255;
	public const int k_SteamMusicPNGMaxLength = 65535;
}

// Namespace: Steamworks
public enum EFriendRelationship // TypeDefIndex: 10440
{
	// Fields
	public int value__; // 0x0
	public const EFriendRelationship k_EFriendRelationshipNone = 0;
	public const EFriendRelationship k_EFriendRelationshipBlocked = 1;
	public const EFriendRelationship k_EFriendRelationshipRequestRecipient = 2;
	public const EFriendRelationship k_EFriendRelationshipFriend = 3;
	public const EFriendRelationship k_EFriendRelationshipRequestInitiator = 4;
	public const EFriendRelationship k_EFriendRelationshipIgnored = 5;
	public const EFriendRelationship k_EFriendRelationshipIgnoredFriend = 6;
	public const EFriendRelationship k_EFriendRelationshipSuggested_DEPRECATED = 7;
	public const EFriendRelationship k_EFriendRelationshipMax = 8;
}

// Namespace: Steamworks
public enum EPersonaState // TypeDefIndex: 10441
{
	// Fields
	public int value__; // 0x0
	public const EPersonaState k_EPersonaStateOffline = 0;
	public const EPersonaState k_EPersonaStateOnline = 1;
	public const EPersonaState k_EPersonaStateBusy = 2;
	public const EPersonaState k_EPersonaStateAway = 3;
	public const EPersonaState k_EPersonaStateSnooze = 4;
	public const EPersonaState k_EPersonaStateLookingToTrade = 5;
	public const EPersonaState k_EPersonaStateLookingToPlay = 6;
	public const EPersonaState k_EPersonaStateInvisible = 7;
	public const EPersonaState k_EPersonaStateMax = 8;
}

// Namespace: Steamworks
[Flags]
public enum EFriendFlags // TypeDefIndex: 10442
{
	// Fields
	public int value__; // 0x0
	public const EFriendFlags k_EFriendFlagNone = 0;
	public const EFriendFlags k_EFriendFlagBlocked = 1;
	public const EFriendFlags k_EFriendFlagFriendshipRequested = 2;
	public const EFriendFlags k_EFriendFlagImmediate = 4;
	public const EFriendFlags k_EFriendFlagClanMember = 8;
	public const EFriendFlags k_EFriendFlagOnGameServer = 16;
	public const EFriendFlags k_EFriendFlagRequestingFriendship = 128;
	public const EFriendFlags k_EFriendFlagRequestingInfo = 256;
	public const EFriendFlags k_EFriendFlagIgnored = 512;
	public const EFriendFlags k_EFriendFlagIgnoredFriend = 1024;
	public const EFriendFlags k_EFriendFlagChatMember = 4096;
	public const EFriendFlags k_EFriendFlagAll = 65535;
}

// Namespace: Steamworks
public enum EUserRestriction // TypeDefIndex: 10443
{
	// Fields
	public int value__; // 0x0
	public const EUserRestriction k_nUserRestrictionNone = 0;
	public const EUserRestriction k_nUserRestrictionUnknown = 1;
	public const EUserRestriction k_nUserRestrictionAnyChat = 2;
	public const EUserRestriction k_nUserRestrictionVoiceChat = 4;
	public const EUserRestriction k_nUserRestrictionGroupChat = 8;
	public const EUserRestriction k_nUserRestrictionRating = 16;
	public const EUserRestriction k_nUserRestrictionGameInvites = 32;
	public const EUserRestriction k_nUserRestrictionTrading = 64;
}

// Namespace: Steamworks
public enum EOverlayToStoreFlag // TypeDefIndex: 10444
{
	// Fields
	public int value__; // 0x0
	public const EOverlayToStoreFlag k_EOverlayToStoreFlag_None = 0;
	public const EOverlayToStoreFlag k_EOverlayToStoreFlag_AddToCart = 1;
	public const EOverlayToStoreFlag k_EOverlayToStoreFlag_AddToCartAndShow = 2;
}

// Namespace: Steamworks
public enum EActivateGameOverlayToWebPageMode // TypeDefIndex: 10445
{
	// Fields
	public int value__; // 0x0
	public const EActivateGameOverlayToWebPageMode k_EActivateGameOverlayToWebPageMode_Default = 0;
	public const EActivateGameOverlayToWebPageMode k_EActivateGameOverlayToWebPageMode_Modal = 1;
}

// Namespace: Steamworks
public enum ECommunityProfileItemType // TypeDefIndex: 10446
{
	// Fields
	public int value__; // 0x0
	public const ECommunityProfileItemType k_ECommunityProfileItemType_AnimatedAvatar = 0;
	public const ECommunityProfileItemType k_ECommunityProfileItemType_AvatarFrame = 1;
	public const ECommunityProfileItemType k_ECommunityProfileItemType_ProfileModifier = 2;
	public const ECommunityProfileItemType k_ECommunityProfileItemType_ProfileBackground = 3;
	public const ECommunityProfileItemType k_ECommunityProfileItemType_MiniProfileBackground = 4;
}

// Namespace: Steamworks
public enum ECommunityProfileItemProperty // TypeDefIndex: 10447
{
	// Fields
	public int value__; // 0x0
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_ImageSmall = 0;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_ImageLarge = 1;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_InternalName = 2;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_Title = 3;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_Description = 4;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_AppID = 5;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_TypeID = 6;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_Class = 7;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_MovieWebM = 8;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_MovieMP4 = 9;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_MovieWebMSmall = 10;
	public const ECommunityProfileItemProperty k_ECommunityProfileItemProperty_MovieMP4Small = 11;
}

// Namespace: Steamworks
[Flags]
public enum EPersonaChange // TypeDefIndex: 10448
{
	// Fields
	public int value__; // 0x0
	public const EPersonaChange k_EPersonaChangeName = 1;
	public const EPersonaChange k_EPersonaChangeStatus = 2;
	public const EPersonaChange k_EPersonaChangeComeOnline = 4;
	public const EPersonaChange k_EPersonaChangeGoneOffline = 8;
	public const EPersonaChange k_EPersonaChangeGamePlayed = 16;
	public const EPersonaChange k_EPersonaChangeGameServer = 32;
	public const EPersonaChange k_EPersonaChangeAvatar = 64;
	public const EPersonaChange k_EPersonaChangeJoinedSource = 128;
	public const EPersonaChange k_EPersonaChangeLeftSource = 256;
	public const EPersonaChange k_EPersonaChangeRelationshipChanged = 512;
	public const EPersonaChange k_EPersonaChangeNameFirstSet = 1024;
	public const EPersonaChange k_EPersonaChangeBroadcast = 2048;
	public const EPersonaChange k_EPersonaChangeNickname = 4096;
	public const EPersonaChange k_EPersonaChangeSteamLevel = 8192;
	public const EPersonaChange k_EPersonaChangeRichPresence = 16384;
}

// Namespace: Steamworks
public enum EGCResults // TypeDefIndex: 10449
{
	// Fields
	public int value__; // 0x0
	public const EGCResults k_EGCResultOK = 0;
	public const EGCResults k_EGCResultNoMessage = 1;
	public const EGCResults k_EGCResultBufferTooSmall = 2;
	public const EGCResults k_EGCResultNotLoggedOn = 3;
	public const EGCResults k_EGCResultInvalidMessage = 4;
}

// Namespace: Steamworks
public enum EHTMLMouseButton // TypeDefIndex: 10450
{
	// Fields
	public int value__; // 0x0
	public const EHTMLMouseButton eHTMLMouseButton_Left = 0;
	public const EHTMLMouseButton eHTMLMouseButton_Right = 1;
	public const EHTMLMouseButton eHTMLMouseButton_Middle = 2;
}

// Namespace: Steamworks
public enum EMouseCursor // TypeDefIndex: 10451
{
	// Fields
	public int value__; // 0x0
	public const EMouseCursor dc_user = 0;
	public const EMouseCursor dc_none = 1;
	public const EMouseCursor dc_arrow = 2;
	public const EMouseCursor dc_ibeam = 3;
	public const EMouseCursor dc_hourglass = 4;
	public const EMouseCursor dc_waitarrow = 5;
	public const EMouseCursor dc_crosshair = 6;
	public const EMouseCursor dc_up = 7;
	public const EMouseCursor dc_sizenw = 8;
	public const EMouseCursor dc_sizese = 9;
	public const EMouseCursor dc_sizene = 10;
	public const EMouseCursor dc_sizesw = 11;
	public const EMouseCursor dc_sizew = 12;
	public const EMouseCursor dc_sizee = 13;
	public const EMouseCursor dc_sizen = 14;
	public const EMouseCursor dc_sizes = 15;
	public const EMouseCursor dc_sizewe = 16;
	public const EMouseCursor dc_sizens = 17;
	public const EMouseCursor dc_sizeall = 18;
	public const EMouseCursor dc_no = 19;
	public const EMouseCursor dc_hand = 20;
	public const EMouseCursor dc_blank = 21;
	public const EMouseCursor dc_middle_pan = 22;
	public const EMouseCursor dc_north_pan = 23;
	public const EMouseCursor dc_north_east_pan = 24;
	public const EMouseCursor dc_east_pan = 25;
	public const EMouseCursor dc_south_east_pan = 26;
	public const EMouseCursor dc_south_pan = 27;
	public const EMouseCursor dc_south_west_pan = 28;
	public const EMouseCursor dc_west_pan = 29;
	public const EMouseCursor dc_north_west_pan = 30;
	public const EMouseCursor dc_alias = 31;
	public const EMouseCursor dc_cell = 32;
	public const EMouseCursor dc_colresize = 33;
	public const EMouseCursor dc_copycur = 34;
	public const EMouseCursor dc_verticaltext = 35;
	public const EMouseCursor dc_rowresize = 36;
	public const EMouseCursor dc_zoomin = 37;
	public const EMouseCursor dc_zoomout = 38;
	public const EMouseCursor dc_help = 39;
	public const EMouseCursor dc_custom = 40;
	public const EMouseCursor dc_last = 41;
}

// Namespace: Steamworks
[Flags]
public enum EHTMLKeyModifiers // TypeDefIndex: 10452
{
	// Fields
	public int value__; // 0x0
	public const EHTMLKeyModifiers k_eHTMLKeyModifier_None = 0;
	public const EHTMLKeyModifiers k_eHTMLKeyModifier_AltDown = 1;
	public const EHTMLKeyModifiers k_eHTMLKeyModifier_CtrlDown = 2;
	public const EHTMLKeyModifiers k_eHTMLKeyModifier_ShiftDown = 4;
}

// Namespace: Steamworks
public enum EInputSourceMode // TypeDefIndex: 10453
{
	// Fields
	public int value__; // 0x0
	public const EInputSourceMode k_EInputSourceMode_None = 0;
	public const EInputSourceMode k_EInputSourceMode_Dpad = 1;
	public const EInputSourceMode k_EInputSourceMode_Buttons = 2;
	public const EInputSourceMode k_EInputSourceMode_FourButtons = 3;
	public const EInputSourceMode k_EInputSourceMode_AbsoluteMouse = 4;
	public const EInputSourceMode k_EInputSourceMode_RelativeMouse = 5;
	public const EInputSourceMode k_EInputSourceMode_JoystickMove = 6;
	public const EInputSourceMode k_EInputSourceMode_JoystickMouse = 7;
	public const EInputSourceMode k_EInputSourceMode_JoystickCamera = 8;
	public const EInputSourceMode k_EInputSourceMode_ScrollWheel = 9;
	public const EInputSourceMode k_EInputSourceMode_Trigger = 10;
	public const EInputSourceMode k_EInputSourceMode_TouchMenu = 11;
	public const EInputSourceMode k_EInputSourceMode_MouseJoystick = 12;
	public const EInputSourceMode k_EInputSourceMode_MouseRegion = 13;
	public const EInputSourceMode k_EInputSourceMode_RadialMenu = 14;
	public const EInputSourceMode k_EInputSourceMode_SingleButton = 15;
	public const EInputSourceMode k_EInputSourceMode_Switches = 16;
}

// Namespace: Steamworks
public enum EInputActionOrigin // TypeDefIndex: 10454
{
	// Fields
	public int value__; // 0x0
	public const EInputActionOrigin k_EInputActionOrigin_None = 0;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_A = 1;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_B = 2;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_X = 3;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Y = 4;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftBumper = 5;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightBumper = 6;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftGrip = 7;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightGrip = 8;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Start = 9;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Back = 10;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftPad_Touch = 11;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftPad_Swipe = 12;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftPad_Click = 13;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftPad_DPadNorth = 14;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftPad_DPadSouth = 15;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftPad_DPadWest = 16;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftPad_DPadEast = 17;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightPad_Touch = 18;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightPad_Swipe = 19;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightPad_Click = 20;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightPad_DPadNorth = 21;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightPad_DPadSouth = 22;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightPad_DPadWest = 23;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightPad_DPadEast = 24;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftTrigger_Pull = 25;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftTrigger_Click = 26;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightTrigger_Pull = 27;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_RightTrigger_Click = 28;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftStick_Move = 29;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftStick_Click = 30;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftStick_DPadNorth = 31;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftStick_DPadSouth = 32;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftStick_DPadWest = 33;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_LeftStick_DPadEast = 34;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Gyro_Move = 35;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Gyro_Pitch = 36;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Gyro_Yaw = 37;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Gyro_Roll = 38;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved0 = 39;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved1 = 40;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved2 = 41;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved3 = 42;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved4 = 43;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved5 = 44;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved6 = 45;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved7 = 46;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved8 = 47;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved9 = 48;
	public const EInputActionOrigin k_EInputActionOrigin_SteamController_Reserved10 = 49;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_X = 50;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Circle = 51;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Triangle = 52;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Square = 53;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftBumper = 54;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightBumper = 55;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Options = 56;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Share = 57;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftPad_Touch = 58;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftPad_Swipe = 59;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftPad_Click = 60;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftPad_DPadNorth = 61;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftPad_DPadSouth = 62;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftPad_DPadWest = 63;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftPad_DPadEast = 64;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightPad_Touch = 65;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightPad_Swipe = 66;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightPad_Click = 67;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightPad_DPadNorth = 68;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightPad_DPadSouth = 69;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightPad_DPadWest = 70;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightPad_DPadEast = 71;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_CenterPad_Touch = 72;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_CenterPad_Swipe = 73;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_CenterPad_Click = 74;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_CenterPad_DPadNorth = 75;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_CenterPad_DPadSouth = 76;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_CenterPad_DPadWest = 77;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_CenterPad_DPadEast = 78;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftTrigger_Pull = 79;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftTrigger_Click = 80;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightTrigger_Pull = 81;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightTrigger_Click = 82;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftStick_Move = 83;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftStick_Click = 84;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftStick_DPadNorth = 85;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftStick_DPadSouth = 86;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftStick_DPadWest = 87;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_LeftStick_DPadEast = 88;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightStick_Move = 89;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightStick_Click = 90;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightStick_DPadNorth = 91;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightStick_DPadSouth = 92;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightStick_DPadWest = 93;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_RightStick_DPadEast = 94;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_DPad_North = 95;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_DPad_South = 96;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_DPad_West = 97;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_DPad_East = 98;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Gyro_Move = 99;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Gyro_Pitch = 100;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Gyro_Yaw = 101;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Gyro_Roll = 102;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_DPad_Move = 103;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved1 = 104;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved2 = 105;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved3 = 106;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved4 = 107;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved5 = 108;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved6 = 109;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved7 = 110;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved8 = 111;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved9 = 112;
	public const EInputActionOrigin k_EInputActionOrigin_PS4_Reserved10 = 113;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_A = 114;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_B = 115;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_X = 116;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Y = 117;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftBumper = 118;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightBumper = 119;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Menu = 120;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_View = 121;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftTrigger_Pull = 122;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftTrigger_Click = 123;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightTrigger_Pull = 124;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightTrigger_Click = 125;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftStick_Move = 126;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftStick_Click = 127;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftStick_DPadNorth = 128;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftStick_DPadSouth = 129;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftStick_DPadWest = 130;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftStick_DPadEast = 131;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightStick_Move = 132;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightStick_Click = 133;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightStick_DPadNorth = 134;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightStick_DPadSouth = 135;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightStick_DPadWest = 136;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightStick_DPadEast = 137;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_DPad_North = 138;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_DPad_South = 139;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_DPad_West = 140;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_DPad_East = 141;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_DPad_Move = 142;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftGrip_Lower = 143;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_LeftGrip_Upper = 144;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightGrip_Lower = 145;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_RightGrip_Upper = 146;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Share = 147;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Reserved6 = 148;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Reserved7 = 149;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Reserved8 = 150;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Reserved9 = 151;
	public const EInputActionOrigin k_EInputActionOrigin_XBoxOne_Reserved10 = 152;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_A = 153;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_B = 154;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_X = 155;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Y = 156;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftBumper = 157;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightBumper = 158;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Start = 159;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Back = 160;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftTrigger_Pull = 161;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftTrigger_Click = 162;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightTrigger_Pull = 163;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightTrigger_Click = 164;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftStick_Move = 165;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftStick_Click = 166;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftStick_DPadNorth = 167;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftStick_DPadSouth = 168;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftStick_DPadWest = 169;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_LeftStick_DPadEast = 170;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightStick_Move = 171;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightStick_Click = 172;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightStick_DPadNorth = 173;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightStick_DPadSouth = 174;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightStick_DPadWest = 175;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_RightStick_DPadEast = 176;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_DPad_North = 177;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_DPad_South = 178;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_DPad_West = 179;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_DPad_East = 180;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_DPad_Move = 181;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved1 = 182;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved2 = 183;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved3 = 184;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved4 = 185;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved5 = 186;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved6 = 187;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved7 = 188;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved8 = 189;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved9 = 190;
	public const EInputActionOrigin k_EInputActionOrigin_XBox360_Reserved10 = 191;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_A = 192;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_B = 193;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_X = 194;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Y = 195;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftBumper = 196;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightBumper = 197;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Plus = 198;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Minus = 199;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Capture = 200;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftTrigger_Pull = 201;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftTrigger_Click = 202;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightTrigger_Pull = 203;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightTrigger_Click = 204;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftStick_Move = 205;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftStick_Click = 206;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftStick_DPadNorth = 207;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftStick_DPadSouth = 208;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftStick_DPadWest = 209;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftStick_DPadEast = 210;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightStick_Move = 211;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightStick_Click = 212;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightStick_DPadNorth = 213;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightStick_DPadSouth = 214;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightStick_DPadWest = 215;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightStick_DPadEast = 216;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_DPad_North = 217;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_DPad_South = 218;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_DPad_West = 219;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_DPad_East = 220;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_ProGyro_Move = 221;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_ProGyro_Pitch = 222;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_ProGyro_Yaw = 223;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_ProGyro_Roll = 224;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_DPad_Move = 225;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved1 = 226;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved2 = 227;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved3 = 228;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved4 = 229;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved5 = 230;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved6 = 231;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved7 = 232;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved8 = 233;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved9 = 234;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved10 = 235;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightGyro_Move = 236;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightGyro_Pitch = 237;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightGyro_Yaw = 238;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightGyro_Roll = 239;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftGyro_Move = 240;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftGyro_Pitch = 241;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftGyro_Yaw = 242;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftGyro_Roll = 243;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftGrip_Lower = 244;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_LeftGrip_Upper = 245;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightGrip_Lower = 246;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_RightGrip_Upper = 247;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_JoyConButton_N = 248;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_JoyConButton_E = 249;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_JoyConButton_S = 250;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_JoyConButton_W = 251;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved15 = 252;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved16 = 253;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved17 = 254;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved18 = 255;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved19 = 256;
	public const EInputActionOrigin k_EInputActionOrigin_Switch_Reserved20 = 257;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_X = 258;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Circle = 259;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Triangle = 260;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Square = 261;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftBumper = 262;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightBumper = 263;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Option = 264;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Create = 265;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Mute = 266;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftPad_Touch = 267;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftPad_Swipe = 268;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftPad_Click = 269;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftPad_DPadNorth = 270;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftPad_DPadSouth = 271;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftPad_DPadWest = 272;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftPad_DPadEast = 273;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightPad_Touch = 274;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightPad_Swipe = 275;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightPad_Click = 276;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightPad_DPadNorth = 277;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightPad_DPadSouth = 278;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightPad_DPadWest = 279;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightPad_DPadEast = 280;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_CenterPad_Touch = 281;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_CenterPad_Swipe = 282;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_CenterPad_Click = 283;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_CenterPad_DPadNorth = 284;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_CenterPad_DPadSouth = 285;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_CenterPad_DPadWest = 286;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_CenterPad_DPadEast = 287;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftTrigger_Pull = 288;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftTrigger_Click = 289;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightTrigger_Pull = 290;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightTrigger_Click = 291;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftStick_Move = 292;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftStick_Click = 293;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftStick_DPadNorth = 294;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftStick_DPadSouth = 295;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftStick_DPadWest = 296;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftStick_DPadEast = 297;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightStick_Move = 298;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightStick_Click = 299;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightStick_DPadNorth = 300;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightStick_DPadSouth = 301;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightStick_DPadWest = 302;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightStick_DPadEast = 303;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_DPad_North = 304;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_DPad_South = 305;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_DPad_West = 306;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_DPad_East = 307;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Gyro_Move = 308;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Gyro_Pitch = 309;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Gyro_Yaw = 310;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Gyro_Roll = 311;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_DPad_Move = 312;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftGrip = 313;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightGrip = 314;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_LeftFn = 315;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_RightFn = 316;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved5 = 317;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved6 = 318;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved7 = 319;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved8 = 320;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved9 = 321;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved10 = 322;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved11 = 323;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved12 = 324;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved13 = 325;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved14 = 326;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved15 = 327;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved16 = 328;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved17 = 329;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved18 = 330;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved19 = 331;
	public const EInputActionOrigin k_EInputActionOrigin_PS5_Reserved20 = 332;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_A = 333;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_B = 334;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_X = 335;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Y = 336;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_L1 = 337;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_R1 = 338;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Menu = 339;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_View = 340;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftPad_Touch = 341;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftPad_Swipe = 342;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftPad_Click = 343;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftPad_DPadNorth = 344;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftPad_DPadSouth = 345;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftPad_DPadWest = 346;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftPad_DPadEast = 347;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightPad_Touch = 348;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightPad_Swipe = 349;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightPad_Click = 350;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightPad_DPadNorth = 351;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightPad_DPadSouth = 352;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightPad_DPadWest = 353;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightPad_DPadEast = 354;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_L2_SoftPull = 355;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_L2 = 356;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_R2_SoftPull = 357;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_R2 = 358;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftStick_Move = 359;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_L3 = 360;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftStick_DPadNorth = 361;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftStick_DPadSouth = 362;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftStick_DPadWest = 363;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftStick_DPadEast = 364;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_LeftStick_Touch = 365;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightStick_Move = 366;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_R3 = 367;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightStick_DPadNorth = 368;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightStick_DPadSouth = 369;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightStick_DPadWest = 370;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightStick_DPadEast = 371;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_RightStick_Touch = 372;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_L4 = 373;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_R4 = 374;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_L5 = 375;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_R5 = 376;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_DPad_Move = 377;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_DPad_North = 378;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_DPad_South = 379;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_DPad_West = 380;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_DPad_East = 381;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Gyro_Move = 382;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Gyro_Pitch = 383;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Gyro_Yaw = 384;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Gyro_Roll = 385;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved1 = 386;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved2 = 387;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved3 = 388;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved4 = 389;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved5 = 390;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved6 = 391;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved7 = 392;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved8 = 393;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved9 = 394;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved10 = 395;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved11 = 396;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved12 = 397;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved13 = 398;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved14 = 399;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved15 = 400;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved16 = 401;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved17 = 402;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved18 = 403;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved19 = 404;
	public const EInputActionOrigin k_EInputActionOrigin_SteamDeck_Reserved20 = 405;
	public const EInputActionOrigin k_EInputActionOrigin_Count = 406;
	public const EInputActionOrigin k_EInputActionOrigin_MaximumPossibleValue = 32767;
}

// Namespace: Steamworks
public enum EXboxOrigin // TypeDefIndex: 10455
{
	// Fields
	public int value__; // 0x0
	public const EXboxOrigin k_EXboxOrigin_A = 0;
	public const EXboxOrigin k_EXboxOrigin_B = 1;
	public const EXboxOrigin k_EXboxOrigin_X = 2;
	public const EXboxOrigin k_EXboxOrigin_Y = 3;
	public const EXboxOrigin k_EXboxOrigin_LeftBumper = 4;
	public const EXboxOrigin k_EXboxOrigin_RightBumper = 5;
	public const EXboxOrigin k_EXboxOrigin_Menu = 6;
	public const EXboxOrigin k_EXboxOrigin_View = 7;
	public const EXboxOrigin k_EXboxOrigin_LeftTrigger_Pull = 8;
	public const EXboxOrigin k_EXboxOrigin_LeftTrigger_Click = 9;
	public const EXboxOrigin k_EXboxOrigin_RightTrigger_Pull = 10;
	public const EXboxOrigin k_EXboxOrigin_RightTrigger_Click = 11;
	public const EXboxOrigin k_EXboxOrigin_LeftStick_Move = 12;
	public const EXboxOrigin k_EXboxOrigin_LeftStick_Click = 13;
	public const EXboxOrigin k_EXboxOrigin_LeftStick_DPadNorth = 14;
	public const EXboxOrigin k_EXboxOrigin_LeftStick_DPadSouth = 15;
	public const EXboxOrigin k_EXboxOrigin_LeftStick_DPadWest = 16;
	public const EXboxOrigin k_EXboxOrigin_LeftStick_DPadEast = 17;
	public const EXboxOrigin k_EXboxOrigin_RightStick_Move = 18;
	public const EXboxOrigin k_EXboxOrigin_RightStick_Click = 19;
	public const EXboxOrigin k_EXboxOrigin_RightStick_DPadNorth = 20;
	public const EXboxOrigin k_EXboxOrigin_RightStick_DPadSouth = 21;
	public const EXboxOrigin k_EXboxOrigin_RightStick_DPadWest = 22;
	public const EXboxOrigin k_EXboxOrigin_RightStick_DPadEast = 23;
	public const EXboxOrigin k_EXboxOrigin_DPad_North = 24;
	public const EXboxOrigin k_EXboxOrigin_DPad_South = 25;
	public const EXboxOrigin k_EXboxOrigin_DPad_West = 26;
	public const EXboxOrigin k_EXboxOrigin_DPad_East = 27;
	public const EXboxOrigin k_EXboxOrigin_Count = 28;
}

// Namespace: Steamworks
public enum ESteamControllerPad // TypeDefIndex: 10456
{
	// Fields
	public int value__; // 0x0
	public const ESteamControllerPad k_ESteamControllerPad_Left = 0;
	public const ESteamControllerPad k_ESteamControllerPad_Right = 1;
}

// Namespace: Steamworks
[Flags]
public enum EControllerHapticLocation // TypeDefIndex: 10457
{
	// Fields
	public int value__; // 0x0
	public const EControllerHapticLocation k_EControllerHapticLocation_Left = 1;
	public const EControllerHapticLocation k_EControllerHapticLocation_Right = 2;
	public const EControllerHapticLocation k_EControllerHapticLocation_Both = 3;
}

// Namespace: Steamworks
public enum EControllerHapticType // TypeDefIndex: 10458
{
	// Fields
	public int value__; // 0x0
	public const EControllerHapticType k_EControllerHapticType_Off = 0;
	public const EControllerHapticType k_EControllerHapticType_Tick = 1;
	public const EControllerHapticType k_EControllerHapticType_Click = 2;
}

// Namespace: Steamworks
public enum ESteamInputType // TypeDefIndex: 10459
{
	// Fields
	public int value__; // 0x0
	public const ESteamInputType k_ESteamInputType_Unknown = 0;
	public const ESteamInputType k_ESteamInputType_SteamController = 1;
	public const ESteamInputType k_ESteamInputType_XBox360Controller = 2;
	public const ESteamInputType k_ESteamInputType_XBoxOneController = 3;
	public const ESteamInputType k_ESteamInputType_GenericGamepad = 4;
	public const ESteamInputType k_ESteamInputType_PS4Controller = 5;
	public const ESteamInputType k_ESteamInputType_AppleMFiController = 6;
	public const ESteamInputType k_ESteamInputType_AndroidController = 7;
	public const ESteamInputType k_ESteamInputType_SwitchJoyConPair = 8;
	public const ESteamInputType k_ESteamInputType_SwitchJoyConSingle = 9;
	public const ESteamInputType k_ESteamInputType_SwitchProController = 10;
	public const ESteamInputType k_ESteamInputType_MobileTouch = 11;
	public const ESteamInputType k_ESteamInputType_PS3Controller = 12;
	public const ESteamInputType k_ESteamInputType_PS5Controller = 13;
	public const ESteamInputType k_ESteamInputType_SteamDeckController = 14;
	public const ESteamInputType k_ESteamInputType_Count = 15;
	public const ESteamInputType k_ESteamInputType_MaximumPossibleValue = 255;
}

// Namespace: Steamworks
public enum ESteamInputConfigurationEnableType // TypeDefIndex: 10460
{
	// Fields
	public int value__; // 0x0
	public const ESteamInputConfigurationEnableType k_ESteamInputConfigurationEnableType_None = 0;
	public const ESteamInputConfigurationEnableType k_ESteamInputConfigurationEnableType_Playstation = 1;
	public const ESteamInputConfigurationEnableType k_ESteamInputConfigurationEnableType_Xbox = 2;
	public const ESteamInputConfigurationEnableType k_ESteamInputConfigurationEnableType_Generic = 4;
	public const ESteamInputConfigurationEnableType k_ESteamInputConfigurationEnableType_Switch = 8;
}

// Namespace: Steamworks
public enum ESteamInputLEDFlag // TypeDefIndex: 10461
{
	// Fields
	public int value__; // 0x0
	public const ESteamInputLEDFlag k_ESteamInputLEDFlag_SetColor = 0;
	public const ESteamInputLEDFlag k_ESteamInputLEDFlag_RestoreUserDefault = 1;
}

// Namespace: Steamworks
public enum ESteamInputGlyphSize // TypeDefIndex: 10462
{
	// Fields
	public int value__; // 0x0
	public const ESteamInputGlyphSize k_ESteamInputGlyphSize_Small = 0;
	public const ESteamInputGlyphSize k_ESteamInputGlyphSize_Medium = 1;
	public const ESteamInputGlyphSize k_ESteamInputGlyphSize_Large = 2;
	public const ESteamInputGlyphSize k_ESteamInputGlyphSize_Count = 3;
}

// Namespace: Steamworks
public enum ESteamInputGlyphStyle // TypeDefIndex: 10463
{
	// Fields
	public int value__; // 0x0
	public const ESteamInputGlyphStyle ESteamInputGlyphStyle_Knockout = 0;
	public const ESteamInputGlyphStyle ESteamInputGlyphStyle_Light = 1;
	public const ESteamInputGlyphStyle ESteamInputGlyphStyle_Dark = 2;
	public const ESteamInputGlyphStyle ESteamInputGlyphStyle_NeutralColorABXY = 16;
	public const ESteamInputGlyphStyle ESteamInputGlyphStyle_SolidABXY = 32;
}

// Namespace: Steamworks
public enum ESteamInputActionEventType // TypeDefIndex: 10464
{
	// Fields
	public int value__; // 0x0
	public const ESteamInputActionEventType ESteamInputActionEventType_DigitalAction = 0;
	public const ESteamInputActionEventType ESteamInputActionEventType_AnalogAction = 1;
}

// Namespace: Steamworks
[Flags]
public enum ESteamItemFlags // TypeDefIndex: 10465
{
	// Fields
	public int value__; // 0x0
	public const ESteamItemFlags k_ESteamItemNoTrade = 1;
	public const ESteamItemFlags k_ESteamItemRemoved = 256;
	public const ESteamItemFlags k_ESteamItemConsumed = 512;
}

// Namespace: Steamworks
public enum ELobbyType // TypeDefIndex: 10466
{
	// Fields
	public int value__; // 0x0
	public const ELobbyType k_ELobbyTypePrivate = 0;
	public const ELobbyType k_ELobbyTypeFriendsOnly = 1;
	public const ELobbyType k_ELobbyTypePublic = 2;
	public const ELobbyType k_ELobbyTypeInvisible = 3;
	public const ELobbyType k_ELobbyTypePrivateUnique = 4;
}

// Namespace: Steamworks
public enum ELobbyComparison // TypeDefIndex: 10467
{
	// Fields
	public int value__; // 0x0
	public const ELobbyComparison k_ELobbyComparisonEqualToOrLessThan = -2;
	public const ELobbyComparison k_ELobbyComparisonLessThan = -1;
	public const ELobbyComparison k_ELobbyComparisonEqual = 0;
	public const ELobbyComparison k_ELobbyComparisonGreaterThan = 1;
	public const ELobbyComparison k_ELobbyComparisonEqualToOrGreaterThan = 2;
	public const ELobbyComparison k_ELobbyComparisonNotEqual = 3;
}

// Namespace: Steamworks
public enum ELobbyDistanceFilter // TypeDefIndex: 10468
{
	// Fields
	public int value__; // 0x0
	public const ELobbyDistanceFilter k_ELobbyDistanceFilterClose = 0;
	public const ELobbyDistanceFilter k_ELobbyDistanceFilterDefault = 1;
	public const ELobbyDistanceFilter k_ELobbyDistanceFilterFar = 2;
	public const ELobbyDistanceFilter k_ELobbyDistanceFilterWorldwide = 3;
}

// Namespace: Steamworks
[Flags]
public enum EChatMemberStateChange // TypeDefIndex: 10469
{
	// Fields
	public int value__; // 0x0
	public const EChatMemberStateChange k_EChatMemberStateChangeEntered = 1;
	public const EChatMemberStateChange k_EChatMemberStateChangeLeft = 2;
	public const EChatMemberStateChange k_EChatMemberStateChangeDisconnected = 4;
	public const EChatMemberStateChange k_EChatMemberStateChangeKicked = 8;
	public const EChatMemberStateChange k_EChatMemberStateChangeBanned = 16;
}

// Namespace: Steamworks
public enum ESteamPartyBeaconLocationType // TypeDefIndex: 10470
{
	// Fields
	public int value__; // 0x0
	public const ESteamPartyBeaconLocationType k_ESteamPartyBeaconLocationType_Invalid = 0;
	public const ESteamPartyBeaconLocationType k_ESteamPartyBeaconLocationType_ChatGroup = 1;
	public const ESteamPartyBeaconLocationType k_ESteamPartyBeaconLocationType_Max = 2;
}

// Namespace: Steamworks
public enum ESteamPartyBeaconLocationData // TypeDefIndex: 10471
{
	// Fields
	public int value__; // 0x0
	public const ESteamPartyBeaconLocationData k_ESteamPartyBeaconLocationDataInvalid = 0;
	public const ESteamPartyBeaconLocationData k_ESteamPartyBeaconLocationDataName = 1;
	public const ESteamPartyBeaconLocationData k_ESteamPartyBeaconLocationDataIconURLSmall = 2;
	public const ESteamPartyBeaconLocationData k_ESteamPartyBeaconLocationDataIconURLMedium = 3;
	public const ESteamPartyBeaconLocationData k_ESteamPartyBeaconLocationDataIconURLLarge = 4;
}

// Namespace: Steamworks
public enum PlayerAcceptState_t // TypeDefIndex: 10472
{
	// Fields
	public int value__; // 0x0
	public const PlayerAcceptState_t k_EStateUnknown = 0;
	public const PlayerAcceptState_t k_EStatePlayerAccepted = 1;
	public const PlayerAcceptState_t k_EStatePlayerDeclined = 2;
}

// Namespace: Steamworks
public enum AudioPlayback_Status // TypeDefIndex: 10473
{
	// Fields
	public int value__; // 0x0
	public const AudioPlayback_Status AudioPlayback_Undefined = 0;
	public const AudioPlayback_Status AudioPlayback_Playing = 1;
	public const AudioPlayback_Status AudioPlayback_Paused = 2;
	public const AudioPlayback_Status AudioPlayback_Idle = 3;
}

// Namespace: Steamworks
public enum EP2PSessionError // TypeDefIndex: 10474
{
	// Fields
	public int value__; // 0x0
	public const EP2PSessionError k_EP2PSessionErrorNone = 0;
	public const EP2PSessionError k_EP2PSessionErrorNoRightsToApp = 2;
	public const EP2PSessionError k_EP2PSessionErrorTimeout = 4;
	public const EP2PSessionError k_EP2PSessionErrorNotRunningApp_DELETED = 1;
	public const EP2PSessionError k_EP2PSessionErrorDestinationNotLoggedIn_DELETED = 3;
	public const EP2PSessionError k_EP2PSessionErrorMax = 5;
}

// Namespace: Steamworks
public enum EP2PSend // TypeDefIndex: 10475
{
	// Fields
	public int value__; // 0x0
	public const EP2PSend k_EP2PSendUnreliable = 0;
	public const EP2PSend k_EP2PSendUnreliableNoDelay = 1;
	public const EP2PSend k_EP2PSendReliable = 2;
	public const EP2PSend k_EP2PSendReliableWithBuffering = 3;
}

// Namespace: Steamworks
public enum ESNetSocketState // TypeDefIndex: 10476
{
	// Fields
	public int value__; // 0x0
	public const ESNetSocketState k_ESNetSocketStateInvalid = 0;
	public const ESNetSocketState k_ESNetSocketStateConnected = 1;
	public const ESNetSocketState k_ESNetSocketStateInitiated = 10;
	public const ESNetSocketState k_ESNetSocketStateLocalCandidatesFound = 11;
	public const ESNetSocketState k_ESNetSocketStateReceivedRemoteCandidates = 12;
	public const ESNetSocketState k_ESNetSocketStateChallengeHandshake = 15;
	public const ESNetSocketState k_ESNetSocketStateDisconnecting = 21;
	public const ESNetSocketState k_ESNetSocketStateLocalDisconnect = 22;
	public const ESNetSocketState k_ESNetSocketStateTimeoutDuringConnect = 23;
	public const ESNetSocketState k_ESNetSocketStateRemoteEndDisconnected = 24;
	public const ESNetSocketState k_ESNetSocketStateConnectionBroken = 25;
}

// Namespace: Steamworks
public enum ESNetSocketConnectionType // TypeDefIndex: 10477
{
	// Fields
	public int value__; // 0x0
	public const ESNetSocketConnectionType k_ESNetSocketConnectionTypeNotConnected = 0;
	public const ESNetSocketConnectionType k_ESNetSocketConnectionTypeUDP = 1;
	public const ESNetSocketConnectionType k_ESNetSocketConnectionTypeUDPRelay = 2;
}

// Namespace: Steamworks
public enum EParentalFeature // TypeDefIndex: 10478
{
	// Fields
	public int value__; // 0x0
	public const EParentalFeature k_EFeatureInvalid = 0;
	public const EParentalFeature k_EFeatureStore = 1;
	public const EParentalFeature k_EFeatureCommunity = 2;
	public const EParentalFeature k_EFeatureProfile = 3;
	public const EParentalFeature k_EFeatureFriends = 4;
	public const EParentalFeature k_EFeatureNews = 5;
	public const EParentalFeature k_EFeatureTrading = 6;
	public const EParentalFeature k_EFeatureSettings = 7;
	public const EParentalFeature k_EFeatureConsole = 8;
	public const EParentalFeature k_EFeatureBrowser = 9;
	public const EParentalFeature k_EFeatureParentalSetup = 10;
	public const EParentalFeature k_EFeatureLibrary = 11;
	public const EParentalFeature k_EFeatureTest = 12;
	public const EParentalFeature k_EFeatureSiteLicense = 13;
	public const EParentalFeature k_EFeatureKioskMode_Deprecated = 14;
	public const EParentalFeature k_EFeatureBlockAlways = 15;
	public const EParentalFeature k_EFeatureMax = 16;
}

// Namespace: Steamworks
public enum ESteamDeviceFormFactor // TypeDefIndex: 10479
{
	// Fields
	public int value__; // 0x0
	public const ESteamDeviceFormFactor k_ESteamDeviceFormFactorUnknown = 0;
	public const ESteamDeviceFormFactor k_ESteamDeviceFormFactorPhone = 1;
	public const ESteamDeviceFormFactor k_ESteamDeviceFormFactorTablet = 2;
	public const ESteamDeviceFormFactor k_ESteamDeviceFormFactorComputer = 3;
	public const ESteamDeviceFormFactor k_ESteamDeviceFormFactorTV = 4;
	public const ESteamDeviceFormFactor k_ESteamDeviceFormFactorVRHeadset = 5;
}

// Namespace: Steamworks
[Flags]
public enum ERemoteStoragePlatform // TypeDefIndex: 10480
{
	// Fields
	public int value__; // 0x0
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformNone = 0;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformWindows = 1;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformOSX = 2;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformPS3 = 4;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformLinux = 8;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformSwitch = 16;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformAndroid = 32;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformIOS = 64;
	public const ERemoteStoragePlatform k_ERemoteStoragePlatformAll = -1;
}

// Namespace: Steamworks
public enum ERemoteStoragePublishedFileVisibility // TypeDefIndex: 10481
{
	// Fields
	public int value__; // 0x0
	public const ERemoteStoragePublishedFileVisibility k_ERemoteStoragePublishedFileVisibilityPublic = 0;
	public const ERemoteStoragePublishedFileVisibility k_ERemoteStoragePublishedFileVisibilityFriendsOnly = 1;
	public const ERemoteStoragePublishedFileVisibility k_ERemoteStoragePublishedFileVisibilityPrivate = 2;
	public const ERemoteStoragePublishedFileVisibility k_ERemoteStoragePublishedFileVisibilityUnlisted = 3;
}

// Namespace: Steamworks
public enum EWorkshopFileType // TypeDefIndex: 10482
{
	// Fields
	public int value__; // 0x0
	public const EWorkshopFileType k_EWorkshopFileTypeFirst = 0;
	public const EWorkshopFileType k_EWorkshopFileTypeCommunity = 0;
	public const EWorkshopFileType k_EWorkshopFileTypeMicrotransaction = 1;
	public const EWorkshopFileType k_EWorkshopFileTypeCollection = 2;
	public const EWorkshopFileType k_EWorkshopFileTypeArt = 3;
	public const EWorkshopFileType k_EWorkshopFileTypeVideo = 4;
	public const EWorkshopFileType k_EWorkshopFileTypeScreenshot = 5;
	public const EWorkshopFileType k_EWorkshopFileTypeGame = 6;
	public const EWorkshopFileType k_EWorkshopFileTypeSoftware = 7;
	public const EWorkshopFileType k_EWorkshopFileTypeConcept = 8;
	public const EWorkshopFileType k_EWorkshopFileTypeWebGuide = 9;
	public const EWorkshopFileType k_EWorkshopFileTypeIntegratedGuide = 10;
	public const EWorkshopFileType k_EWorkshopFileTypeMerch = 11;
	public const EWorkshopFileType k_EWorkshopFileTypeControllerBinding = 12;
	public const EWorkshopFileType k_EWorkshopFileTypeSteamworksAccessInvite = 13;
	public const EWorkshopFileType k_EWorkshopFileTypeSteamVideo = 14;
	public const EWorkshopFileType k_EWorkshopFileTypeGameManagedItem = 15;
	public const EWorkshopFileType k_EWorkshopFileTypeClip = 16;
	public const EWorkshopFileType k_EWorkshopFileTypeMax = 17;
}

// Namespace: Steamworks
public enum EWorkshopVote // TypeDefIndex: 10483
{
	// Fields
	public int value__; // 0x0
	public const EWorkshopVote k_EWorkshopVoteUnvoted = 0;
	public const EWorkshopVote k_EWorkshopVoteFor = 1;
	public const EWorkshopVote k_EWorkshopVoteAgainst = 2;
	public const EWorkshopVote k_EWorkshopVoteLater = 3;
}

// Namespace: Steamworks
public enum EWorkshopFileAction // TypeDefIndex: 10484
{
	// Fields
	public int value__; // 0x0
	public const EWorkshopFileAction k_EWorkshopFileActionPlayed = 0;
	public const EWorkshopFileAction k_EWorkshopFileActionCompleted = 1;
}

// Namespace: Steamworks
public enum EWorkshopEnumerationType // TypeDefIndex: 10485
{
	// Fields
	public int value__; // 0x0
	public const EWorkshopEnumerationType k_EWorkshopEnumerationTypeRankedByVote = 0;
	public const EWorkshopEnumerationType k_EWorkshopEnumerationTypeRecent = 1;
	public const EWorkshopEnumerationType k_EWorkshopEnumerationTypeTrending = 2;
	public const EWorkshopEnumerationType k_EWorkshopEnumerationTypeFavoritesOfFriends = 3;
	public const EWorkshopEnumerationType k_EWorkshopEnumerationTypeVotedByFriends = 4;
	public const EWorkshopEnumerationType k_EWorkshopEnumerationTypeContentByFriends = 5;
	public const EWorkshopEnumerationType k_EWorkshopEnumerationTypeRecentFromFollowedUsers = 6;
}

// Namespace: Steamworks
public enum EWorkshopVideoProvider // TypeDefIndex: 10486
{
	// Fields
	public int value__; // 0x0
	public const EWorkshopVideoProvider k_EWorkshopVideoProviderNone = 0;
	public const EWorkshopVideoProvider k_EWorkshopVideoProviderYoutube = 1;
}

// Namespace: Steamworks
public enum EUGCReadAction // TypeDefIndex: 10487
{
	// Fields
	public int value__; // 0x0
	public const EUGCReadAction k_EUGCRead_ContinueReadingUntilFinished = 0;
	public const EUGCReadAction k_EUGCRead_ContinueReading = 1;
	public const EUGCReadAction k_EUGCRead_Close = 2;
}

// Namespace: Steamworks
public enum ERemoteStorageLocalFileChange // TypeDefIndex: 10488
{
	// Fields
	public int value__; // 0x0
	public const ERemoteStorageLocalFileChange k_ERemoteStorageLocalFileChange_Invalid = 0;
	public const ERemoteStorageLocalFileChange k_ERemoteStorageLocalFileChange_FileUpdated = 1;
	public const ERemoteStorageLocalFileChange k_ERemoteStorageLocalFileChange_FileDeleted = 2;
}

// Namespace: Steamworks
public enum ERemoteStorageFilePathType // TypeDefIndex: 10489
{
	// Fields
	public int value__; // 0x0
	public const ERemoteStorageFilePathType k_ERemoteStorageFilePathType_Invalid = 0;
	public const ERemoteStorageFilePathType k_ERemoteStorageFilePathType_Absolute = 1;
	public const ERemoteStorageFilePathType k_ERemoteStorageFilePathType_APIFilename = 2;
}

// Namespace: Steamworks
public enum EVRScreenshotType // TypeDefIndex: 10490
{
	// Fields
	public int value__; // 0x0
	public const EVRScreenshotType k_EVRScreenshotType_None = 0;
	public const EVRScreenshotType k_EVRScreenshotType_Mono = 1;
	public const EVRScreenshotType k_EVRScreenshotType_Stereo = 2;
	public const EVRScreenshotType k_EVRScreenshotType_MonoCubemap = 3;
	public const EVRScreenshotType k_EVRScreenshotType_MonoPanorama = 4;
	public const EVRScreenshotType k_EVRScreenshotType_StereoPanorama = 5;
}

// Namespace: Steamworks
public enum ETimelineGameMode // TypeDefIndex: 10491
{
	// Fields
	public int value__; // 0x0
	public const ETimelineGameMode k_ETimelineGameMode_Invalid = 0;
	public const ETimelineGameMode k_ETimelineGameMode_Playing = 1;
	public const ETimelineGameMode k_ETimelineGameMode_Staging = 2;
	public const ETimelineGameMode k_ETimelineGameMode_Menus = 3;
	public const ETimelineGameMode k_ETimelineGameMode_LoadingScreen = 4;
	public const ETimelineGameMode k_ETimelineGameMode_Max = 5;
}

// Namespace: Steamworks
public enum ETimelineEventClipPriority // TypeDefIndex: 10492
{
	// Fields
	public int value__; // 0x0
	public const ETimelineEventClipPriority k_ETimelineEventClipPriority_Invalid = 0;
	public const ETimelineEventClipPriority k_ETimelineEventClipPriority_None = 1;
	public const ETimelineEventClipPriority k_ETimelineEventClipPriority_Standard = 2;
	public const ETimelineEventClipPriority k_ETimelineEventClipPriority_Featured = 3;
}

// Namespace: Steamworks
public enum EUGCMatchingUGCType // TypeDefIndex: 10493
{
	// Fields
	public int value__; // 0x0
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_Items = 0;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_Items_Mtx = 1;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_Items_ReadyToUse = 2;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_Collections = 3;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_Artwork = 4;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_Videos = 5;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_Screenshots = 6;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_AllGuides = 7;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_WebGuides = 8;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_IntegratedGuides = 9;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_UsableInGame = 10;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_ControllerBindings = 11;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_GameManagedItems = 12;
	public const EUGCMatchingUGCType k_EUGCMatchingUGCType_All = -1;
}

// Namespace: Steamworks
public enum EUserUGCList // TypeDefIndex: 10494
{
	// Fields
	public int value__; // 0x0
	public const EUserUGCList k_EUserUGCList_Published = 0;
	public const EUserUGCList k_EUserUGCList_VotedOn = 1;
	public const EUserUGCList k_EUserUGCList_VotedUp = 2;
	public const EUserUGCList k_EUserUGCList_VotedDown = 3;
	public const EUserUGCList k_EUserUGCList_WillVoteLater = 4;
	public const EUserUGCList k_EUserUGCList_Favorited = 5;
	public const EUserUGCList k_EUserUGCList_Subscribed = 6;
	public const EUserUGCList k_EUserUGCList_UsedOrPlayed = 7;
	public const EUserUGCList k_EUserUGCList_Followed = 8;
}

// Namespace: Steamworks
public enum EUserUGCListSortOrder // TypeDefIndex: 10495
{
	// Fields
	public int value__; // 0x0
	public const EUserUGCListSortOrder k_EUserUGCListSortOrder_CreationOrderDesc = 0;
	public const EUserUGCListSortOrder k_EUserUGCListSortOrder_CreationOrderAsc = 1;
	public const EUserUGCListSortOrder k_EUserUGCListSortOrder_TitleAsc = 2;
	public const EUserUGCListSortOrder k_EUserUGCListSortOrder_LastUpdatedDesc = 3;
	public const EUserUGCListSortOrder k_EUserUGCListSortOrder_SubscriptionDateDesc = 4;
	public const EUserUGCListSortOrder k_EUserUGCListSortOrder_VoteScoreDesc = 5;
	public const EUserUGCListSortOrder k_EUserUGCListSortOrder_ForModeration = 6;
}

// Namespace: Steamworks
public enum EUGCQuery // TypeDefIndex: 10496
{
	// Fields
	public int value__; // 0x0
	public const EUGCQuery k_EUGCQuery_RankedByVote = 0;
	public const EUGCQuery k_EUGCQuery_RankedByPublicationDate = 1;
	public const EUGCQuery k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate = 2;
	public const EUGCQuery k_EUGCQuery_RankedByTrend = 3;
	public const EUGCQuery k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate = 4;
	public const EUGCQuery k_EUGCQuery_CreatedByFriendsRankedByPublicationDate = 5;
	public const EUGCQuery k_EUGCQuery_RankedByNumTimesReported = 6;
	public const EUGCQuery k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate = 7;
	public const EUGCQuery k_EUGCQuery_NotYetRated = 8;
	public const EUGCQuery k_EUGCQuery_RankedByTotalVotesAsc = 9;
	public const EUGCQuery k_EUGCQuery_RankedByVotesUp = 10;
	public const EUGCQuery k_EUGCQuery_RankedByTextSearch = 11;
	public const EUGCQuery k_EUGCQuery_RankedByTotalUniqueSubscriptions = 12;
	public const EUGCQuery k_EUGCQuery_RankedByPlaytimeTrend = 13;
	public const EUGCQuery k_EUGCQuery_RankedByTotalPlaytime = 14;
	public const EUGCQuery k_EUGCQuery_RankedByAveragePlaytimeTrend = 15;
	public const EUGCQuery k_EUGCQuery_RankedByLifetimeAveragePlaytime = 16;
	public const EUGCQuery k_EUGCQuery_RankedByPlaytimeSessionsTrend = 17;
	public const EUGCQuery k_EUGCQuery_RankedByLifetimePlaytimeSessions = 18;
	public const EUGCQuery k_EUGCQuery_RankedByLastUpdatedDate = 19;
}

// Namespace: Steamworks
public enum EItemUpdateStatus // TypeDefIndex: 10497
{
	// Fields
	public int value__; // 0x0
	public const EItemUpdateStatus k_EItemUpdateStatusInvalid = 0;
	public const EItemUpdateStatus k_EItemUpdateStatusPreparingConfig = 1;
	public const EItemUpdateStatus k_EItemUpdateStatusPreparingContent = 2;
	public const EItemUpdateStatus k_EItemUpdateStatusUploadingContent = 3;
	public const EItemUpdateStatus k_EItemUpdateStatusUploadingPreviewFile = 4;
	public const EItemUpdateStatus k_EItemUpdateStatusCommittingChanges = 5;
}

// Namespace: Steamworks
[Flags]
public enum EItemState // TypeDefIndex: 10498
{
	// Fields
	public int value__; // 0x0
	public const EItemState k_EItemStateNone = 0;
	public const EItemState k_EItemStateSubscribed = 1;
	public const EItemState k_EItemStateLegacyItem = 2;
	public const EItemState k_EItemStateInstalled = 4;
	public const EItemState k_EItemStateNeedsUpdate = 8;
	public const EItemState k_EItemStateDownloading = 16;
	public const EItemState k_EItemStateDownloadPending = 32;
	public const EItemState k_EItemStateDisabledLocally = 64;
}

// Namespace: Steamworks
public enum EItemStatistic // TypeDefIndex: 10499
{
	// Fields
	public int value__; // 0x0
	public const EItemStatistic k_EItemStatistic_NumSubscriptions = 0;
	public const EItemStatistic k_EItemStatistic_NumFavorites = 1;
	public const EItemStatistic k_EItemStatistic_NumFollowers = 2;
	public const EItemStatistic k_EItemStatistic_NumUniqueSubscriptions = 3;
	public const EItemStatistic k_EItemStatistic_NumUniqueFavorites = 4;
	public const EItemStatistic k_EItemStatistic_NumUniqueFollowers = 5;
	public const EItemStatistic k_EItemStatistic_NumUniqueWebsiteViews = 6;
	public const EItemStatistic k_EItemStatistic_ReportScore = 7;
	public const EItemStatistic k_EItemStatistic_NumSecondsPlayed = 8;
	public const EItemStatistic k_EItemStatistic_NumPlaytimeSessions = 9;
	public const EItemStatistic k_EItemStatistic_NumComments = 10;
	public const EItemStatistic k_EItemStatistic_NumSecondsPlayedDuringTimePeriod = 11;
	public const EItemStatistic k_EItemStatistic_NumPlaytimeSessionsDuringTimePeriod = 12;
}

// Namespace: Steamworks
public enum EItemPreviewType // TypeDefIndex: 10500
{
	// Fields
	public int value__; // 0x0
	public const EItemPreviewType k_EItemPreviewType_Image = 0;
	public const EItemPreviewType k_EItemPreviewType_YouTubeVideo = 1;
	public const EItemPreviewType k_EItemPreviewType_Sketchfab = 2;
	public const EItemPreviewType k_EItemPreviewType_EnvironmentMap_HorizontalCross = 3;
	public const EItemPreviewType k_EItemPreviewType_EnvironmentMap_LatLong = 4;
	public const EItemPreviewType k_EItemPreviewType_Clip = 5;
	public const EItemPreviewType k_EItemPreviewType_ReservedMax = 255;
}

// Namespace: Steamworks
public enum EUGCContentDescriptorID // TypeDefIndex: 10501
{
	// Fields
	public int value__; // 0x0
	public const EUGCContentDescriptorID k_EUGCContentDescriptor_NudityOrSexualContent = 1;
	public const EUGCContentDescriptorID k_EUGCContentDescriptor_FrequentViolenceOrGore = 2;
	public const EUGCContentDescriptorID k_EUGCContentDescriptor_AdultOnlySexualContent = 3;
	public const EUGCContentDescriptorID k_EUGCContentDescriptor_GratuitousSexualContent = 4;
	public const EUGCContentDescriptorID k_EUGCContentDescriptor_AnyMatureContent = 5;
}

// Namespace: Steamworks
public enum EFailureType // TypeDefIndex: 10502
{
	// Fields
	public int value__; // 0x0
	public const EFailureType k_EFailureFlushedCallbackQueue = 0;
	public const EFailureType k_EFailurePipeFail = 1;
}

// Namespace: Steamworks
public enum ELeaderboardDataRequest // TypeDefIndex: 10503
{
	// Fields
	public int value__; // 0x0
	public const ELeaderboardDataRequest k_ELeaderboardDataRequestGlobal = 0;
	public const ELeaderboardDataRequest k_ELeaderboardDataRequestGlobalAroundUser = 1;
	public const ELeaderboardDataRequest k_ELeaderboardDataRequestFriends = 2;
	public const ELeaderboardDataRequest k_ELeaderboardDataRequestUsers = 3;
}

// Namespace: Steamworks
public enum ELeaderboardSortMethod // TypeDefIndex: 10504
{
	// Fields
	public int value__; // 0x0
	public const ELeaderboardSortMethod k_ELeaderboardSortMethodNone = 0;
	public const ELeaderboardSortMethod k_ELeaderboardSortMethodAscending = 1;
	public const ELeaderboardSortMethod k_ELeaderboardSortMethodDescending = 2;
}

// Namespace: Steamworks
public enum ELeaderboardDisplayType // TypeDefIndex: 10505
{
	// Fields
	public int value__; // 0x0
	public const ELeaderboardDisplayType k_ELeaderboardDisplayTypeNone = 0;
	public const ELeaderboardDisplayType k_ELeaderboardDisplayTypeNumeric = 1;
	public const ELeaderboardDisplayType k_ELeaderboardDisplayTypeTimeSeconds = 2;
	public const ELeaderboardDisplayType k_ELeaderboardDisplayTypeTimeMilliSeconds = 3;
}

// Namespace: Steamworks
public enum ELeaderboardUploadScoreMethod // TypeDefIndex: 10506
{
	// Fields
	public int value__; // 0x0
	public const ELeaderboardUploadScoreMethod k_ELeaderboardUploadScoreMethodNone = 0;
	public const ELeaderboardUploadScoreMethod k_ELeaderboardUploadScoreMethodKeepBest = 1;
	public const ELeaderboardUploadScoreMethod k_ELeaderboardUploadScoreMethodForceUpdate = 2;
}

// Namespace: Steamworks
public enum ESteamAPICallFailure // TypeDefIndex: 10507
{
	// Fields
	public int value__; // 0x0
	public const ESteamAPICallFailure k_ESteamAPICallFailureNone = -1;
	public const ESteamAPICallFailure k_ESteamAPICallFailureSteamGone = 0;
	public const ESteamAPICallFailure k_ESteamAPICallFailureNetworkFailure = 1;
	public const ESteamAPICallFailure k_ESteamAPICallFailureInvalidHandle = 2;
	public const ESteamAPICallFailure k_ESteamAPICallFailureMismatchedCallback = 3;
}

// Namespace: Steamworks
public enum EGamepadTextInputMode // TypeDefIndex: 10508
{
	// Fields
	public int value__; // 0x0
	public const EGamepadTextInputMode k_EGamepadTextInputModeNormal = 0;
	public const EGamepadTextInputMode k_EGamepadTextInputModePassword = 1;
}

// Namespace: Steamworks
public enum EGamepadTextInputLineMode // TypeDefIndex: 10509
{
	// Fields
	public int value__; // 0x0
	public const EGamepadTextInputLineMode k_EGamepadTextInputLineModeSingleLine = 0;
	public const EGamepadTextInputLineMode k_EGamepadTextInputLineModeMultipleLines = 1;
}

// Namespace: Steamworks
public enum EFloatingGamepadTextInputMode // TypeDefIndex: 10510
{
	// Fields
	public int value__; // 0x0
	public const EFloatingGamepadTextInputMode k_EFloatingGamepadTextInputModeModeSingleLine = 0;
	public const EFloatingGamepadTextInputMode k_EFloatingGamepadTextInputModeModeMultipleLines = 1;
	public const EFloatingGamepadTextInputMode k_EFloatingGamepadTextInputModeModeEmail = 2;
	public const EFloatingGamepadTextInputMode k_EFloatingGamepadTextInputModeModeNumeric = 3;
}

// Namespace: Steamworks
public enum ETextFilteringContext // TypeDefIndex: 10511
{
	// Fields
	public int value__; // 0x0
	public const ETextFilteringContext k_ETextFilteringContextUnknown = 0;
	public const ETextFilteringContext k_ETextFilteringContextGameContent = 1;
	public const ETextFilteringContext k_ETextFilteringContextChat = 2;
	public const ETextFilteringContext k_ETextFilteringContextName = 3;
}

// Namespace: Steamworks
public enum ECheckFileSignature // TypeDefIndex: 10512
{
	// Fields
	public int value__; // 0x0
	public const ECheckFileSignature k_ECheckFileSignatureInvalidSignature = 0;
	public const ECheckFileSignature k_ECheckFileSignatureValidSignature = 1;
	public const ECheckFileSignature k_ECheckFileSignatureFileNotFound = 2;
	public const ECheckFileSignature k_ECheckFileSignatureNoSignaturesFoundForThisApp = 3;
	public const ECheckFileSignature k_ECheckFileSignatureNoSignaturesFoundForThisFile = 4;
}

// Namespace: Steamworks
public enum EMatchMakingServerResponse // TypeDefIndex: 10513
{
	// Fields
	public int value__; // 0x0
	public const EMatchMakingServerResponse eServerResponded = 0;
	public const EMatchMakingServerResponse eServerFailedToRespond = 1;
	public const EMatchMakingServerResponse eNoServersListedOnMasterServer = 2;
}

// Namespace: Steamworks
public enum ESteamAPIInitResult // TypeDefIndex: 10514
{
	// Fields
	public int value__; // 0x0
	public const ESteamAPIInitResult k_ESteamAPIInitResult_OK = 0;
	public const ESteamAPIInitResult k_ESteamAPIInitResult_FailedGeneric = 1;
	public const ESteamAPIInitResult k_ESteamAPIInitResult_NoSteamClient = 2;
	public const ESteamAPIInitResult k_ESteamAPIInitResult_VersionMismatch = 3;
}

// Namespace: Steamworks
public enum EServerMode // TypeDefIndex: 10515
{
	// Fields
	public int value__; // 0x0
	public const EServerMode eServerModeInvalid = 0;
	public const EServerMode eServerModeNoAuthentication = 1;
	public const EServerMode eServerModeAuthentication = 2;
	public const EServerMode eServerModeAuthenticationAndSecure = 3;
}

// Namespace: Steamworks
public enum EResult // TypeDefIndex: 10516
{
	// Fields
	public int value__; // 0x0
	public const EResult k_EResultNone = 0;
	public const EResult k_EResultOK = 1;
	public const EResult k_EResultFail = 2;
	public const EResult k_EResultNoConnection = 3;
	public const EResult k_EResultInvalidPassword = 5;
	public const EResult k_EResultLoggedInElsewhere = 6;
	public const EResult k_EResultInvalidProtocolVer = 7;
	public const EResult k_EResultInvalidParam = 8;
	public const EResult k_EResultFileNotFound = 9;
	public const EResult k_EResultBusy = 10;
	public const EResult k_EResultInvalidState = 11;
	public const EResult k_EResultInvalidName = 12;
	public const EResult k_EResultInvalidEmail = 13;
	public const EResult k_EResultDuplicateName = 14;
	public const EResult k_EResultAccessDenied = 15;
	public const EResult k_EResultTimeout = 16;
	public const EResult k_EResultBanned = 17;
	public const EResult k_EResultAccountNotFound = 18;
	public const EResult k_EResultInvalidSteamID = 19;
	public const EResult k_EResultServiceUnavailable = 20;
	public const EResult k_EResultNotLoggedOn = 21;
	public const EResult k_EResultPending = 22;
	public const EResult k_EResultEncryptionFailure = 23;
	public const EResult k_EResultInsufficientPrivilege = 24;
	public const EResult k_EResultLimitExceeded = 25;
	public const EResult k_EResultRevoked = 26;
	public const EResult k_EResultExpired = 27;
	public const EResult k_EResultAlreadyRedeemed = 28;
	public const EResult k_EResultDuplicateRequest = 29;
	public const EResult k_EResultAlreadyOwned = 30;
	public const EResult k_EResultIPNotFound = 31;
	public const EResult k_EResultPersistFailed = 32;
	public const EResult k_EResultLockingFailed = 33;
	public const EResult k_EResultLogonSessionReplaced = 34;
	public const EResult k_EResultConnectFailed = 35;
	public const EResult k_EResultHandshakeFailed = 36;
	public const EResult k_EResultIOFailure = 37;
	public const EResult k_EResultRemoteDisconnect = 38;
	public const EResult k_EResultShoppingCartNotFound = 39;
	public const EResult k_EResultBlocked = 40;
	public const EResult k_EResultIgnored = 41;
	public const EResult k_EResultNoMatch = 42;
	public const EResult k_EResultAccountDisabled = 43;
	public const EResult k_EResultServiceReadOnly = 44;
	public const EResult k_EResultAccountNotFeatured = 45;
	public const EResult k_EResultAdministratorOK = 46;
	public const EResult k_EResultContentVersion = 47;
	public const EResult k_EResultTryAnotherCM = 48;
	public const EResult k_EResultPasswordRequiredToKickSession = 49;
	public const EResult k_EResultAlreadyLoggedInElsewhere = 50;
	public const EResult k_EResultSuspended = 51;
	public const EResult k_EResultCancelled = 52;
	public const EResult k_EResultDataCorruption = 53;
	public const EResult k_EResultDiskFull = 54;
	public const EResult k_EResultRemoteCallFailed = 55;
	public const EResult k_EResultPasswordUnset = 56;
	public const EResult k_EResultExternalAccountUnlinked = 57;
	public const EResult k_EResultPSNTicketInvalid = 58;
	public const EResult k_EResultExternalAccountAlreadyLinked = 59;
	public const EResult k_EResultRemoteFileConflict = 60;
	public const EResult k_EResultIllegalPassword = 61;
	public const EResult k_EResultSameAsPreviousValue = 62;
	public const EResult k_EResultAccountLogonDenied = 63;
	public const EResult k_EResultCannotUseOldPassword = 64;
	public const EResult k_EResultInvalidLoginAuthCode = 65;
	public const EResult k_EResultAccountLogonDeniedNoMail = 66;
	public const EResult k_EResultHardwareNotCapableOfIPT = 67;
	public const EResult k_EResultIPTInitError = 68;
	public const EResult k_EResultParentalControlRestricted = 69;
	public const EResult k_EResultFacebookQueryError = 70;
	public const EResult k_EResultExpiredLoginAuthCode = 71;
	public const EResult k_EResultIPLoginRestrictionFailed = 72;
	public const EResult k_EResultAccountLockedDown = 73;
	public const EResult k_EResultAccountLogonDeniedVerifiedEmailRequired = 74;
	public const EResult k_EResultNoMatchingURL = 75;
	public const EResult k_EResultBadResponse = 76;
	public const EResult k_EResultRequirePasswordReEntry = 77;
	public const EResult k_EResultValueOutOfRange = 78;
	public const EResult k_EResultUnexpectedError = 79;
	public const EResult k_EResultDisabled = 80;
	public const EResult k_EResultInvalidCEGSubmission = 81;
	public const EResult k_EResultRestrictedDevice = 82;
	public const EResult k_EResultRegionLocked = 83;
	public const EResult k_EResultRateLimitExceeded = 84;
	public const EResult k_EResultAccountLoginDeniedNeedTwoFactor = 85;
	public const EResult k_EResultItemDeleted = 86;
	public const EResult k_EResultAccountLoginDeniedThrottle = 87;
	public const EResult k_EResultTwoFactorCodeMismatch = 88;
	public const EResult k_EResultTwoFactorActivationCodeMismatch = 89;
	public const EResult k_EResultAccountAssociatedToMultiplePartners = 90;
	public const EResult k_EResultNotModified = 91;
	public const EResult k_EResultNoMobileDevice = 92;
	public const EResult k_EResultTimeNotSynced = 93;
	public const EResult k_EResultSmsCodeFailed = 94;
	public const EResult k_EResultAccountLimitExceeded = 95;
	public const EResult k_EResultAccountActivityLimitExceeded = 96;
	public const EResult k_EResultPhoneActivityLimitExceeded = 97;
	public const EResult k_EResultRefundToWallet = 98;
	public const EResult k_EResultEmailSendFailure = 99;
	public const EResult k_EResultNotSettled = 100;
	public const EResult k_EResultNeedCaptcha = 101;
	public const EResult k_EResultGSLTDenied = 102;
	public const EResult k_EResultGSOwnerDenied = 103;
	public const EResult k_EResultInvalidItemType = 104;
	public const EResult k_EResultIPBanned = 105;
	public const EResult k_EResultGSLTExpired = 106;
	public const EResult k_EResultInsufficientFunds = 107;
	public const EResult k_EResultTooManyPending = 108;
	public const EResult k_EResultNoSiteLicensesFound = 109;
	public const EResult k_EResultWGNetworkSendExceeded = 110;
	public const EResult k_EResultAccountNotFriends = 111;
	public const EResult k_EResultLimitedUserAccount = 112;
	public const EResult k_EResultCantRemoveItem = 113;
	public const EResult k_EResultAccountDeleted = 114;
	public const EResult k_EResultExistingUserCancelledLicense = 115;
	public const EResult k_EResultCommunityCooldown = 116;
	public const EResult k_EResultNoLauncherSpecified = 117;
	public const EResult k_EResultMustAgreeToSSA = 118;
	public const EResult k_EResultLauncherMigrated = 119;
	public const EResult k_EResultSteamRealmMismatch = 120;
	public const EResult k_EResultInvalidSignature = 121;
	public const EResult k_EResultParseFailure = 122;
	public const EResult k_EResultNoVerifiedPhone = 123;
	public const EResult k_EResultInsufficientBattery = 124;
	public const EResult k_EResultChargerRequired = 125;
	public const EResult k_EResultCachedCredentialInvalid = 126;
	public const EResult K_EResultPhoneNumberIsVOIP = 127;
	public const EResult k_EResultNotSupported = 128;
	public const EResult k_EResultFamilySizeLimitExceeded = 129;
}

// Namespace: Steamworks
public enum EVoiceResult // TypeDefIndex: 10517
{
	// Fields
	public int value__; // 0x0
	public const EVoiceResult k_EVoiceResultOK = 0;
	public const EVoiceResult k_EVoiceResultNotInitialized = 1;
	public const EVoiceResult k_EVoiceResultNotRecording = 2;
	public const EVoiceResult k_EVoiceResultNoData = 3;
	public const EVoiceResult k_EVoiceResultBufferTooSmall = 4;
	public const EVoiceResult k_EVoiceResultDataCorrupted = 5;
	public const EVoiceResult k_EVoiceResultRestricted = 6;
	public const EVoiceResult k_EVoiceResultUnsupportedCodec = 7;
	public const EVoiceResult k_EVoiceResultReceiverOutOfDate = 8;
	public const EVoiceResult k_EVoiceResultReceiverDidNotAnswer = 9;
}

// Namespace: Steamworks
public enum EDenyReason // TypeDefIndex: 10518
{
	// Fields
	public int value__; // 0x0
	public const EDenyReason k_EDenyInvalid = 0;
	public const EDenyReason k_EDenyInvalidVersion = 1;
	public const EDenyReason k_EDenyGeneric = 2;
	public const EDenyReason k_EDenyNotLoggedOn = 3;
	public const EDenyReason k_EDenyNoLicense = 4;
	public const EDenyReason k_EDenyCheater = 5;
	public const EDenyReason k_EDenyLoggedInElseWhere = 6;
	public const EDenyReason k_EDenyUnknownText = 7;
	public const EDenyReason k_EDenyIncompatibleAnticheat = 8;
	public const EDenyReason k_EDenyMemoryCorruption = 9;
	public const EDenyReason k_EDenyIncompatibleSoftware = 10;
	public const EDenyReason k_EDenySteamConnectionLost = 11;
	public const EDenyReason k_EDenySteamConnectionError = 12;
	public const EDenyReason k_EDenySteamResponseTimedOut = 13;
	public const EDenyReason k_EDenySteamValidationStalled = 14;
	public const EDenyReason k_EDenySteamOwnerLeftGuestUser = 15;
}

// Namespace: Steamworks
public enum EBeginAuthSessionResult // TypeDefIndex: 10519
{
	// Fields
	public int value__; // 0x0
	public const EBeginAuthSessionResult k_EBeginAuthSessionResultOK = 0;
	public const EBeginAuthSessionResult k_EBeginAuthSessionResultInvalidTicket = 1;
	public const EBeginAuthSessionResult k_EBeginAuthSessionResultDuplicateRequest = 2;
	public const EBeginAuthSessionResult k_EBeginAuthSessionResultInvalidVersion = 3;
	public const EBeginAuthSessionResult k_EBeginAuthSessionResultGameMismatch = 4;
	public const EBeginAuthSessionResult k_EBeginAuthSessionResultExpiredTicket = 5;
}

// Namespace: Steamworks
public enum EAuthSessionResponse // TypeDefIndex: 10520
{
	// Fields
	public int value__; // 0x0
	public const EAuthSessionResponse k_EAuthSessionResponseOK = 0;
	public const EAuthSessionResponse k_EAuthSessionResponseUserNotConnectedToSteam = 1;
	public const EAuthSessionResponse k_EAuthSessionResponseNoLicenseOrExpired = 2;
	public const EAuthSessionResponse k_EAuthSessionResponseVACBanned = 3;
	public const EAuthSessionResponse k_EAuthSessionResponseLoggedInElseWhere = 4;
	public const EAuthSessionResponse k_EAuthSessionResponseVACCheckTimedOut = 5;
	public const EAuthSessionResponse k_EAuthSessionResponseAuthTicketCanceled = 6;
	public const EAuthSessionResponse k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed = 7;
	public const EAuthSessionResponse k_EAuthSessionResponseAuthTicketInvalid = 8;
	public const EAuthSessionResponse k_EAuthSessionResponsePublisherIssuedBan = 9;
	public const EAuthSessionResponse k_EAuthSessionResponseAuthTicketNetworkIdentityFailure = 10;
}

// Namespace: Steamworks
public enum EUserHasLicenseForAppResult // TypeDefIndex: 10521
{
	// Fields
	public int value__; // 0x0
	public const EUserHasLicenseForAppResult k_EUserHasLicenseResultHasLicense = 0;
	public const EUserHasLicenseForAppResult k_EUserHasLicenseResultDoesNotHaveLicense = 1;
	public const EUserHasLicenseForAppResult k_EUserHasLicenseResultNoAuth = 2;
}

// Namespace: Steamworks
public enum EAccountType // TypeDefIndex: 10522
{
	// Fields
	public int value__; // 0x0
	public const EAccountType k_EAccountTypeInvalid = 0;
	public const EAccountType k_EAccountTypeIndividual = 1;
	public const EAccountType k_EAccountTypeMultiseat = 2;
	public const EAccountType k_EAccountTypeGameServer = 3;
	public const EAccountType k_EAccountTypeAnonGameServer = 4;
	public const EAccountType k_EAccountTypePending = 5;
	public const EAccountType k_EAccountTypeContentServer = 6;
	public const EAccountType k_EAccountTypeClan = 7;
	public const EAccountType k_EAccountTypeChat = 8;
	public const EAccountType k_EAccountTypeConsoleUser = 9;
	public const EAccountType k_EAccountTypeAnonUser = 10;
	public const EAccountType k_EAccountTypeMax = 11;
}

// Namespace: Steamworks
public enum EChatEntryType // TypeDefIndex: 10523
{
	// Fields
	public int value__; // 0x0
	public const EChatEntryType k_EChatEntryTypeInvalid = 0;
	public const EChatEntryType k_EChatEntryTypeChatMsg = 1;
	public const EChatEntryType k_EChatEntryTypeTyping = 2;
	public const EChatEntryType k_EChatEntryTypeInviteGame = 3;
	public const EChatEntryType k_EChatEntryTypeEmote = 4;
	public const EChatEntryType k_EChatEntryTypeLeftConversation = 6;
	public const EChatEntryType k_EChatEntryTypeEntered = 7;
	public const EChatEntryType k_EChatEntryTypeWasKicked = 8;
	public const EChatEntryType k_EChatEntryTypeWasBanned = 9;
	public const EChatEntryType k_EChatEntryTypeDisconnected = 10;
	public const EChatEntryType k_EChatEntryTypeHistoricalChat = 11;
	public const EChatEntryType k_EChatEntryTypeLinkBlocked = 14;
}

// Namespace: Steamworks
public enum EChatRoomEnterResponse // TypeDefIndex: 10524
{
	// Fields
	public int value__; // 0x0
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseSuccess = 1;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseDoesntExist = 2;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseNotAllowed = 3;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseFull = 4;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseError = 5;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseBanned = 6;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseLimited = 7;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseClanDisabled = 8;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseCommunityBan = 9;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseMemberBlockedYou = 10;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseYouBlockedMember = 11;
	public const EChatRoomEnterResponse k_EChatRoomEnterResponseRatelimitExceeded = 15;
}

// Namespace: Steamworks
[Flags]
public enum EChatSteamIDInstanceFlags // TypeDefIndex: 10525
{
	// Fields
	public int value__; // 0x0
	public const EChatSteamIDInstanceFlags k_EChatAccountInstanceMask = 4095;
	public const EChatSteamIDInstanceFlags k_EChatInstanceFlagClan = 524288;
	public const EChatSteamIDInstanceFlags k_EChatInstanceFlagLobby = 262144;
	public const EChatSteamIDInstanceFlags k_EChatInstanceFlagMMSLobby = 131072;
}

// Namespace: Steamworks
public enum ENotificationPosition // TypeDefIndex: 10526
{
	// Fields
	public int value__; // 0x0
	public const ENotificationPosition k_EPositionInvalid = -1;
	public const ENotificationPosition k_EPositionTopLeft = 0;
	public const ENotificationPosition k_EPositionTopRight = 1;
	public const ENotificationPosition k_EPositionBottomLeft = 2;
	public const ENotificationPosition k_EPositionBottomRight = 3;
}

// Namespace: Steamworks
public enum EBroadcastUploadResult // TypeDefIndex: 10527
{
	// Fields
	public int value__; // 0x0
	public const EBroadcastUploadResult k_EBroadcastUploadResultNone = 0;
	public const EBroadcastUploadResult k_EBroadcastUploadResultOK = 1;
	public const EBroadcastUploadResult k_EBroadcastUploadResultInitFailed = 2;
	public const EBroadcastUploadResult k_EBroadcastUploadResultFrameFailed = 3;
	public const EBroadcastUploadResult k_EBroadcastUploadResultTimeout = 4;
	public const EBroadcastUploadResult k_EBroadcastUploadResultBandwidthExceeded = 5;
	public const EBroadcastUploadResult k_EBroadcastUploadResultLowFPS = 6;
	public const EBroadcastUploadResult k_EBroadcastUploadResultMissingKeyFrames = 7;
	public const EBroadcastUploadResult k_EBroadcastUploadResultNoConnection = 8;
	public const EBroadcastUploadResult k_EBroadcastUploadResultRelayFailed = 9;
	public const EBroadcastUploadResult k_EBroadcastUploadResultSettingsChanged = 10;
	public const EBroadcastUploadResult k_EBroadcastUploadResultMissingAudio = 11;
	public const EBroadcastUploadResult k_EBroadcastUploadResultTooFarBehind = 12;
	public const EBroadcastUploadResult k_EBroadcastUploadResultTranscodeBehind = 13;
	public const EBroadcastUploadResult k_EBroadcastUploadResultNotAllowedToPlay = 14;
	public const EBroadcastUploadResult k_EBroadcastUploadResultBusy = 15;
	public const EBroadcastUploadResult k_EBroadcastUploadResultBanned = 16;
	public const EBroadcastUploadResult k_EBroadcastUploadResultAlreadyActive = 17;
	public const EBroadcastUploadResult k_EBroadcastUploadResultForcedOff = 18;
	public const EBroadcastUploadResult k_EBroadcastUploadResultAudioBehind = 19;
	public const EBroadcastUploadResult k_EBroadcastUploadResultShutdown = 20;
	public const EBroadcastUploadResult k_EBroadcastUploadResultDisconnect = 21;
	public const EBroadcastUploadResult k_EBroadcastUploadResultVideoInitFailed = 22;
	public const EBroadcastUploadResult k_EBroadcastUploadResultAudioInitFailed = 23;
}

// Namespace: Steamworks
[Flags]
public enum EMarketNotAllowedReasonFlags // TypeDefIndex: 10528
{
	// Fields
	public int value__; // 0x0
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_None = 0;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_TemporaryFailure = 1;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountDisabled = 2;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountLockedDown = 4;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountLimited = 8;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_TradeBanned = 16;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountNotTrusted = 32;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_SteamGuardNotEnabled = 64;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_RecentPasswordReset = 256;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_NewPaymentMethod = 512;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_InvalidCookie = 1024;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_UsingNewDevice = 2048;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_RecentSelfRefund = 4096;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_NoRecentPurchases = 16384;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AcceptedWalletGift = 32768;
}

// Namespace: Steamworks
public enum EDurationControlProgress // TypeDefIndex: 10529
{
	// Fields
	public int value__; // 0x0
	public const EDurationControlProgress k_EDurationControlProgress_Full = 0;
	public const EDurationControlProgress k_EDurationControlProgress_Half = 1;
	public const EDurationControlProgress k_EDurationControlProgress_None = 2;
	public const EDurationControlProgress k_EDurationControl_ExitSoon_3h = 3;
	public const EDurationControlProgress k_EDurationControl_ExitSoon_5h = 4;
	public const EDurationControlProgress k_EDurationControl_ExitSoon_Night = 5;
}

// Namespace: Steamworks
public enum EDurationControlNotification // TypeDefIndex: 10530
{
	// Fields
	public int value__; // 0x0
	public const EDurationControlNotification k_EDurationControlNotification_None = 0;
	public const EDurationControlNotification k_EDurationControlNotification_1Hour = 1;
	public const EDurationControlNotification k_EDurationControlNotification_3Hours = 2;
	public const EDurationControlNotification k_EDurationControlNotification_HalfProgress = 3;
	public const EDurationControlNotification k_EDurationControlNotification_NoProgress = 4;
	public const EDurationControlNotification k_EDurationControlNotification_ExitSoon_3h = 5;
	public const EDurationControlNotification k_EDurationControlNotification_ExitSoon_5h = 6;
	public const EDurationControlNotification k_EDurationControlNotification_ExitSoon_Night = 7;
}

// Namespace: Steamworks
public enum EDurationControlOnlineState // TypeDefIndex: 10531
{
	// Fields
	public int value__; // 0x0
	public const EDurationControlOnlineState k_EDurationControlOnlineState_Invalid = 0;
	public const EDurationControlOnlineState k_EDurationControlOnlineState_Offline = 1;
	public const EDurationControlOnlineState k_EDurationControlOnlineState_Online = 2;
	public const EDurationControlOnlineState k_EDurationControlOnlineState_OnlineHighPri = 3;
}

// Namespace: Steamworks
[Flags]
public enum EBetaBranchFlags // TypeDefIndex: 10532
{
	// Fields
	public int value__; // 0x0
	public const EBetaBranchFlags k_EBetaBranch_None = 0;
	public const EBetaBranchFlags k_EBetaBranch_Default = 1;
	public const EBetaBranchFlags k_EBetaBranch_Available = 2;
	public const EBetaBranchFlags k_EBetaBranch_Private = 4;
	public const EBetaBranchFlags k_EBetaBranch_Selected = 8;
	public const EBetaBranchFlags k_EBetaBranch_Installed = 16;
}

// Namespace: Steamworks
public enum EGameSearchErrorCode_t // TypeDefIndex: 10533
{
	// Fields
	public int value__; // 0x0
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_OK = 1;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_Search_Already_In_Progress = 2;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_No_Search_In_Progress = 3;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_Not_Lobby_Leader = 4;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_No_Host_Available = 5;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_Search_Params_Invalid = 6;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_Offline = 7;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_NotAuthorized = 8;
	public const EGameSearchErrorCode_t k_EGameSearchErrorCode_Failed_Unknown_Error = 9;
}

// Namespace: Steamworks
public enum EPlayerResult_t // TypeDefIndex: 10534
{
	// Fields
	public int value__; // 0x0
	public const EPlayerResult_t k_EPlayerResultFailedToConnect = 1;
	public const EPlayerResult_t k_EPlayerResultAbandoned = 2;
	public const EPlayerResult_t k_EPlayerResultKicked = 3;
	public const EPlayerResult_t k_EPlayerResultIncomplete = 4;
	public const EPlayerResult_t k_EPlayerResultCompleted = 5;
}

// Namespace: Steamworks
public enum ESteamIPv6ConnectivityProtocol // TypeDefIndex: 10535
{
	// Fields
	public int value__; // 0x0
	public const ESteamIPv6ConnectivityProtocol k_ESteamIPv6ConnectivityProtocol_Invalid = 0;
	public const ESteamIPv6ConnectivityProtocol k_ESteamIPv6ConnectivityProtocol_HTTP = 1;
	public const ESteamIPv6ConnectivityProtocol k_ESteamIPv6ConnectivityProtocol_UDP = 2;
}

// Namespace: Steamworks
public enum ESteamIPv6ConnectivityState // TypeDefIndex: 10536
{
	// Fields
	public int value__; // 0x0
	public const ESteamIPv6ConnectivityState k_ESteamIPv6ConnectivityState_Unknown = 0;
	public const ESteamIPv6ConnectivityState k_ESteamIPv6ConnectivityState_Good = 1;
	public const ESteamIPv6ConnectivityState k_ESteamIPv6ConnectivityState_Bad = 2;
}

// Namespace: Steamworks
public enum EHTTPMethod // TypeDefIndex: 10537
{
	// Fields
	public int value__; // 0x0
	public const EHTTPMethod k_EHTTPMethodInvalid = 0;
	public const EHTTPMethod k_EHTTPMethodGET = 1;
	public const EHTTPMethod k_EHTTPMethodHEAD = 2;
	public const EHTTPMethod k_EHTTPMethodPOST = 3;
	public const EHTTPMethod k_EHTTPMethodPUT = 4;
	public const EHTTPMethod k_EHTTPMethodDELETE = 5;
	public const EHTTPMethod k_EHTTPMethodOPTIONS = 6;
	public const EHTTPMethod k_EHTTPMethodPATCH = 7;
}

// Namespace: Steamworks
public enum EHTTPStatusCode // TypeDefIndex: 10538
{
	// Fields
	public int value__; // 0x0
	public const EHTTPStatusCode k_EHTTPStatusCodeInvalid = 0;
	public const EHTTPStatusCode k_EHTTPStatusCode100Continue = 100;
	public const EHTTPStatusCode k_EHTTPStatusCode101SwitchingProtocols = 101;
	public const EHTTPStatusCode k_EHTTPStatusCode200OK = 200;
	public const EHTTPStatusCode k_EHTTPStatusCode201Created = 201;
	public const EHTTPStatusCode k_EHTTPStatusCode202Accepted = 202;
	public const EHTTPStatusCode k_EHTTPStatusCode203NonAuthoritative = 203;
	public const EHTTPStatusCode k_EHTTPStatusCode204NoContent = 204;
	public const EHTTPStatusCode k_EHTTPStatusCode205ResetContent = 205;
	public const EHTTPStatusCode k_EHTTPStatusCode206PartialContent = 206;
	public const EHTTPStatusCode k_EHTTPStatusCode300MultipleChoices = 300;
	public const EHTTPStatusCode k_EHTTPStatusCode301MovedPermanently = 301;
	public const EHTTPStatusCode k_EHTTPStatusCode302Found = 302;
	public const EHTTPStatusCode k_EHTTPStatusCode303SeeOther = 303;
	public const EHTTPStatusCode k_EHTTPStatusCode304NotModified = 304;
	public const EHTTPStatusCode k_EHTTPStatusCode305UseProxy = 305;
	public const EHTTPStatusCode k_EHTTPStatusCode307TemporaryRedirect = 307;
	public const EHTTPStatusCode k_EHTTPStatusCode308PermanentRedirect = 308;
	public const EHTTPStatusCode k_EHTTPStatusCode400BadRequest = 400;
	public const EHTTPStatusCode k_EHTTPStatusCode401Unauthorized = 401;
	public const EHTTPStatusCode k_EHTTPStatusCode402PaymentRequired = 402;
	public const EHTTPStatusCode k_EHTTPStatusCode403Forbidden = 403;
	public const EHTTPStatusCode k_EHTTPStatusCode404NotFound = 404;
	public const EHTTPStatusCode k_EHTTPStatusCode405MethodNotAllowed = 405;
	public const EHTTPStatusCode k_EHTTPStatusCode406NotAcceptable = 406;
	public const EHTTPStatusCode k_EHTTPStatusCode407ProxyAuthRequired = 407;
	public const EHTTPStatusCode k_EHTTPStatusCode408RequestTimeout = 408;
	public const EHTTPStatusCode k_EHTTPStatusCode409Conflict = 409;
	public const EHTTPStatusCode k_EHTTPStatusCode410Gone = 410;
	public const EHTTPStatusCode k_EHTTPStatusCode411LengthRequired = 411;
	public const EHTTPStatusCode k_EHTTPStatusCode412PreconditionFailed = 412;
	public const EHTTPStatusCode k_EHTTPStatusCode413RequestEntityTooLarge = 413;
	public const EHTTPStatusCode k_EHTTPStatusCode414RequestURITooLong = 414;
	public const EHTTPStatusCode k_EHTTPStatusCode415UnsupportedMediaType = 415;
	public const EHTTPStatusCode k_EHTTPStatusCode416RequestedRangeNotSatisfiable = 416;
	public const EHTTPStatusCode k_EHTTPStatusCode417ExpectationFailed = 417;
	public const EHTTPStatusCode k_EHTTPStatusCode4xxUnknown = 418;
	public const EHTTPStatusCode k_EHTTPStatusCode429TooManyRequests = 429;
	public const EHTTPStatusCode k_EHTTPStatusCode444ConnectionClosed = 444;
	public const EHTTPStatusCode k_EHTTPStatusCode500InternalServerError = 500;
	public const EHTTPStatusCode k_EHTTPStatusCode501NotImplemented = 501;
	public const EHTTPStatusCode k_EHTTPStatusCode502BadGateway = 502;
	public const EHTTPStatusCode k_EHTTPStatusCode503ServiceUnavailable = 503;
	public const EHTTPStatusCode k_EHTTPStatusCode504GatewayTimeout = 504;
	public const EHTTPStatusCode k_EHTTPStatusCode505HTTPVersionNotSupported = 505;
	public const EHTTPStatusCode k_EHTTPStatusCode5xxUnknown = 599;
}

// Namespace: Steamworks
public enum ESteamNetworkingAvailability // TypeDefIndex: 10539
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_CannotTry = -102;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_Failed = -101;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_Previously = -100;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_Retrying = -10;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_NeverTried = 1;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_Waiting = 2;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_Attempting = 3;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_Current = 100;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability_Unknown = 0;
	public const ESteamNetworkingAvailability k_ESteamNetworkingAvailability__Force32bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingIdentityType // TypeDefIndex: 10540
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_Invalid = 0;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_SteamID = 16;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_XboxPairwiseID = 17;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_SonyPSN = 18;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_GoogleStadia = 19;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_IPAddress = 1;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_GenericString = 2;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_GenericBytes = 3;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType_UnknownType = 4;
	public const ESteamNetworkingIdentityType k_ESteamNetworkingIdentityType__Force32bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingFakeIPType // TypeDefIndex: 10541
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingFakeIPType k_ESteamNetworkingFakeIPType_Invalid = 0;
	public const ESteamNetworkingFakeIPType k_ESteamNetworkingFakeIPType_NotFake = 1;
	public const ESteamNetworkingFakeIPType k_ESteamNetworkingFakeIPType_GlobalIPv4 = 2;
	public const ESteamNetworkingFakeIPType k_ESteamNetworkingFakeIPType_LocalIPv4 = 3;
	public const ESteamNetworkingFakeIPType k_ESteamNetworkingFakeIPType__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingConnectionState // TypeDefIndex: 10542
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_None = 0;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Connecting = 1;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_FindingRoute = 2;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Connected = 3;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_ClosedByPeer = 4;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_ProblemDetectedLocally = 5;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_FinWait = -1;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Linger = -2;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState_Dead = -3;
	public const ESteamNetworkingConnectionState k_ESteamNetworkingConnectionState__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetConnectionEnd // TypeDefIndex: 10543
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Invalid = 0;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_App_Min = 1000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_App_Generic = 1000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_App_Max = 1999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_AppException_Min = 2000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_AppException_Generic = 2000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_AppException_Max = 2999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_Min = 3000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_OfflineMode = 3001;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_ManyRelayConnectivity = 3002;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_HostedServerPrimaryRelay = 3003;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_NetworkConfig = 3004;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_Rights = 3005;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_P2P_ICE_NoPublicAddresses = 3006;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Local_Max = 3999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_Min = 4000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_Timeout = 4001;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_BadCrypt = 4002;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_BadCert = 4003;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_BadProtocolVersion = 4006;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_P2P_ICE_NoPublicAddresses = 4007;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Remote_Max = 4999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Min = 5000;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Generic = 5001;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_InternalError = 5002;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Timeout = 5003;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_SteamConnectivity = 5005;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_NoRelaySessionsToClient = 5006;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_P2P_Rendezvous = 5008;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_P2P_NAT_Firewall = 5009;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_PeerSentNoConnection = 5010;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd_Misc_Max = 5999;
	public const ESteamNetConnectionEnd k_ESteamNetConnectionEnd__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingConfigScope // TypeDefIndex: 10544
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingConfigScope k_ESteamNetworkingConfig_Global = 1;
	public const ESteamNetworkingConfigScope k_ESteamNetworkingConfig_SocketsInterface = 2;
	public const ESteamNetworkingConfigScope k_ESteamNetworkingConfig_ListenSocket = 3;
	public const ESteamNetworkingConfigScope k_ESteamNetworkingConfig_Connection = 4;
	public const ESteamNetworkingConfigScope k_ESteamNetworkingConfigScope__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingConfigDataType // TypeDefIndex: 10545
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingConfigDataType k_ESteamNetworkingConfig_Int32 = 1;
	public const ESteamNetworkingConfigDataType k_ESteamNetworkingConfig_Int64 = 2;
	public const ESteamNetworkingConfigDataType k_ESteamNetworkingConfig_Float = 3;
	public const ESteamNetworkingConfigDataType k_ESteamNetworkingConfig_String = 4;
	public const ESteamNetworkingConfigDataType k_ESteamNetworkingConfig_Ptr = 5;
	public const ESteamNetworkingConfigDataType k_ESteamNetworkingConfigDataType__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingConfigValue // TypeDefIndex: 10546
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Invalid = 0;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_TimeoutInitial = 24;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_TimeoutConnected = 25;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SendBufferSize = 9;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_RecvBufferSize = 47;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_RecvBufferMessages = 48;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_RecvMaxMessageSize = 49;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_RecvMaxSegmentsPerPacket = 50;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_ConnectionUserData = 40;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SendRateMin = 10;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SendRateMax = 11;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_NagleTime = 12;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_IP_AllowWithoutAuth = 23;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_IPLocalHost_AllowWithoutAuth = 52;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_MTU_PacketSize = 32;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_MTU_DataSize = 33;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Unencrypted = 34;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SymmetricConnect = 37;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_LocalVirtualPort = 38;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_DualWifi_Enable = 39;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_EnableDiagnosticsUI = 46;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketLoss_Send = 2;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketLoss_Recv = 3;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketLag_Send = 4;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketLag_Recv = 5;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketReorder_Send = 6;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketReorder_Recv = 7;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketReorder_Time = 8;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketDup_Send = 26;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketDup_Recv = 27;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakePacketDup_TimeMax = 28;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_PacketTraceMaxBytes = 41;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakeRateLimit_Send_Rate = 42;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakeRateLimit_Send_Burst = 43;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakeRateLimit_Recv_Rate = 44;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_FakeRateLimit_Recv_Burst = 45;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_OutOfOrderCorrectionWindowMicroseconds = 51;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged = 201;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Callback_AuthStatusChanged = 202;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged = 203;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Callback_MessagesSessionRequest = 204;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Callback_MessagesSessionFailed = 205;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Callback_CreateConnectionSignaling = 206;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_Callback_FakeIPResult = 207;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_STUN_ServerList = 103;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable = 104;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty = 105;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty = 106;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_TURN_ServerList = 107;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_TURN_UserList = 108;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_TURN_PassList = 109;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_P2P_Transport_ICE_Implementation = 110;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail = 20;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate = 21;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_SingleSocket = 22;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster = 29;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_DevTicket = 30;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr = 31;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_FakeClusterPing = 36;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN = 60;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_LogLevel_AckRTT = 13;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_LogLevel_PacketDecode = 14;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_LogLevel_Message = 15;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_LogLevel_PacketGaps = 16;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_LogLevel_P2PRendezvous = 17;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_LogLevel_SDRRelayPings = 18;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_ECN = 999;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfig_DELETED_EnumerateDevVars = 35;
	public const ESteamNetworkingConfigValue k_ESteamNetworkingConfigValue__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingGetConfigValueResult // TypeDefIndex: 10547
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingGetConfigValueResult k_ESteamNetworkingGetConfigValue_BadValue = -1;
	public const ESteamNetworkingGetConfigValueResult k_ESteamNetworkingGetConfigValue_BadScopeObj = -2;
	public const ESteamNetworkingGetConfigValueResult k_ESteamNetworkingGetConfigValue_BufferTooSmall = -3;
	public const ESteamNetworkingGetConfigValueResult k_ESteamNetworkingGetConfigValue_OK = 1;
	public const ESteamNetworkingGetConfigValueResult k_ESteamNetworkingGetConfigValue_OKInherited = 2;
	public const ESteamNetworkingGetConfigValueResult k_ESteamNetworkingGetConfigValueResult__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamNetworkingSocketsDebugOutputType // TypeDefIndex: 10548
{
	// Fields
	public int value__; // 0x0
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_None = 0;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Bug = 1;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Error = 2;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Important = 3;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Warning = 4;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Msg = 5;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Verbose = 6;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Debug = 7;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType_Everything = 8;
	public const ESteamNetworkingSocketsDebugOutputType k_ESteamNetworkingSocketsDebugOutputType__Force32Bit = 2147483647;
}

// Namespace: Steamworks
public enum ESteamIPType // TypeDefIndex: 10549
{
	// Fields
	public int value__; // 0x0
	public const ESteamIPType k_ESteamIPTypeIPv4 = 0;
	public const ESteamIPType k_ESteamIPTypeIPv6 = 1;
}

// Namespace: Steamworks
public enum EUniverse // TypeDefIndex: 10550
{
	// Fields
	public int value__; // 0x0
	public const EUniverse k_EUniverseInvalid = 0;
	public const EUniverse k_EUniversePublic = 1;
	public const EUniverse k_EUniverseBeta = 2;
	public const EUniverse k_EUniverseInternal = 3;
	public const EUniverse k_EUniverseDev = 4;
	public const EUniverse k_EUniverseMax = 5;
}

// Namespace: Steamworks
public struct FriendGameInfo_t // TypeDefIndex: 10551
{
	// Fields
	public CGameID m_gameID; // 0x0
	public uint m_unGameIP; // 0x8
	public ushort m_usGamePort; // 0xC
	public ushort m_usQueryPort; // 0xE
	public CSteamID m_steamIDLobby; // 0x10
}

// Namespace: Steamworks
public struct InputAnalogActionData_t // TypeDefIndex: 10552
{
	// Fields
	public EInputSourceMode eMode; // 0x0
	public float x; // 0x4
	public float y; // 0x8
	public byte bActive; // 0xC
}

// Namespace: Steamworks
public struct InputDigitalActionData_t // TypeDefIndex: 10553
{
	// Fields
	public byte bState; // 0x0
	public byte bActive; // 0x1
}

// Namespace: Steamworks
public struct InputMotionData_t // TypeDefIndex: 10554
{
	// Fields
	public float rotQuatX; // 0x0
	public float rotQuatY; // 0x4
	public float rotQuatZ; // 0x8
	public float rotQuatW; // 0xC
	public float posAccelX; // 0x10
	public float posAccelY; // 0x14
	public float posAccelZ; // 0x18
	public float rotVelX; // 0x1C
	public float rotVelY; // 0x20
	public float rotVelZ; // 0x24
}

// Namespace: Steamworks
public struct SteamItemDetails_t // TypeDefIndex: 10555
{
	// Fields
	public SteamItemInstanceID_t m_itemId; // 0x0
	public SteamItemDef_t m_iDefinition; // 0x8
	public ushort m_unQuantity; // 0xC
	public ushort m_unFlags; // 0xE
}

// Namespace: Steamworks
public struct SteamPartyBeaconLocation_t // TypeDefIndex: 10556
{
	// Fields
	public ESteamPartyBeaconLocationType m_eType; // 0x0
	public ulong m_ulLocationID; // 0x8
}

// Namespace: Steamworks
public struct P2PSessionState_t // TypeDefIndex: 10557
{
	// Fields
	public byte m_bConnectionActive; // 0x0
	public byte m_bConnecting; // 0x1
	public byte m_eP2PSessionError; // 0x2
	public byte m_bUsingRelay; // 0x3
	public int m_nBytesQueuedForSend; // 0x4
	public int m_nPacketsQueuedForSend; // 0x8
	public uint m_nRemoteIP; // 0xC
	public ushort m_nRemotePort; // 0x10
}

// Namespace: Steamworks
public struct SteamParamStringArray_t // TypeDefIndex: 10558
{
	// Fields
	public IntPtr m_ppStrings; // 0x0
	public int m_nNumStrings; // 0x8
}

// Namespace: Steamworks
public struct SteamUGCDetails_t // TypeDefIndex: 10559
{
	// Fields
	public PublishedFileId_t m_nPublishedFileId; // 0x0
	public EResult m_eResult; // 0x8
	public EWorkshopFileType m_eFileType; // 0xC
	public AppId_t m_nCreatorAppID; // 0x10
	public AppId_t m_nConsumerAppID; // 0x14
	private byte[] m_rgchTitle_; // 0x18
	private byte[] m_rgchDescription_; // 0x20
	public ulong m_ulSteamIDOwner; // 0x28
	public uint m_rtimeCreated; // 0x30
	public uint m_rtimeUpdated; // 0x34
	public uint m_rtimeAddedToUserList; // 0x38
	public ERemoteStoragePublishedFileVisibility m_eVisibility; // 0x3C
	public bool m_bBanned; // 0x40
	public bool m_bAcceptedForUse; // 0x41
	public bool m_bTagsTruncated; // 0x42
	private byte[] m_rgchTags_; // 0x48
	public UGCHandle_t m_hFile; // 0x50
	public UGCHandle_t m_hPreviewFile; // 0x58
	private byte[] m_pchFileName_; // 0x60
	public int m_nFileSize; // 0x68
	public int m_nPreviewFileSize; // 0x6C
	private byte[] m_rgchURL_; // 0x70
	public uint m_unVotesUp; // 0x78
	public uint m_unVotesDown; // 0x7C
	public float m_flScore; // 0x80
	public uint m_unNumChildren; // 0x84
	public ulong m_ulTotalFilesSize; // 0x88

	// Properties
	public string m_rgchTitle { get; set; }
	public string m_rgchDescription { get; set; }
	public string m_rgchTags { get; set; }
	public string m_pchFileName { get; set; }
	public string m_rgchURL { get; set; }

	// Methods

	// RVA: 0x597EA0 Offset: 0x5964A0 VA: 0x180597EA0
	public string get_m_rgchTitle() { }

	// RVA: 0x5C3410 Offset: 0x5C1A10 VA: 0x1805C3410
	public void set_m_rgchTitle(string value) { }

	// RVA: 0x5C3130 Offset: 0x5C1730 VA: 0x1805C3130
	public string get_m_rgchDescription() { }

	// RVA: 0x5C32B0 Offset: 0x5C18B0 VA: 0x1805C32B0
	public void set_m_rgchDescription(string value) { }

	// RVA: 0x5C6670 Offset: 0x5C4C70 VA: 0x1805C6670
	public string get_m_rgchTags() { }

	// RVA: 0x5C3360 Offset: 0x5C1960 VA: 0x1805C3360
	public void set_m_rgchTags(string value) { }

	// RVA: 0x5C30B0 Offset: 0x5C16B0 VA: 0x1805C30B0
	public string get_m_pchFileName() { }

	// RVA: 0x5C3000 Offset: 0x5C1600 VA: 0x1805C3000
	public void set_m_pchFileName(string value) { }

	// RVA: 0x5C3230 Offset: 0x5C1830 VA: 0x1805C3230
	public string get_m_rgchURL() { }

	// RVA: 0x594340 Offset: 0x592940 VA: 0x180594340
	public void set_m_rgchURL(string value) { }
}

// Namespace: Steamworks
public struct LeaderboardEntry_t // TypeDefIndex: 10560
{
	// Fields
	public CSteamID m_steamIDUser; // 0x0
	public int m_nGlobalRank; // 0x8
	public int m_nScore; // 0xC
	public int m_cDetails; // 0x10
	public UGCHandle_t m_hUGC; // 0x18
}

// Namespace: Steamworks
public struct MatchMakingKeyValuePair_t // TypeDefIndex: 10561
{
	// Fields
	public string m_szKey; // 0x0
	public string m_szValue; // 0x8

	// Methods

	// RVA: 0x598200 Offset: 0x596800 VA: 0x180598200
	private void .ctor(string strKey, string strValue) { }
}

// Namespace: Steamworks
public struct CallbackMsg_t // TypeDefIndex: 10562
{
	// Fields
	public int m_hSteamUser; // 0x0
	public int m_iCallback; // 0x4
	public IntPtr m_pubParam; // 0x8
	public int m_cubParam; // 0x10
}

// Namespace: Steamworks
public struct SteamNetConnectionInfo_t // TypeDefIndex: 10563
{
	// Fields
	public SteamNetworkingIdentity m_identityRemote; // 0x0
	public long m_nUserData; // 0x88
	public HSteamListenSocket m_hListenSocket; // 0x90
	public SteamNetworkingIPAddr m_addrRemote; // 0x98
	public ushort m__pad1; // 0xA8
	public SteamNetworkingPOPID m_idPOPRemote; // 0xAC
	public SteamNetworkingPOPID m_idPOPRelay; // 0xB0
	public ESteamNetworkingConnectionState m_eState; // 0xB4
	public int m_eEndReason; // 0xB8
	private byte[] m_szEndDebug_; // 0xC0
	private byte[] m_szConnectionDescription_; // 0xC8
	public int m_nFlags; // 0xD0
	public uint[] reserved; // 0xD8

	// Properties
	public string m_szEndDebug { get; set; }
	public string m_szConnectionDescription { get; set; }

	// Methods

	// RVA: 0x5C4EC0 Offset: 0x5C34C0 VA: 0x1805C4EC0
	public string get_m_szEndDebug() { }

	// RVA: 0x594290 Offset: 0x592890 VA: 0x180594290
	public void set_m_szEndDebug(string value) { }

	// RVA: 0x5C4E40 Offset: 0x5C3440 VA: 0x1805C4E40
	public string get_m_szConnectionDescription() { }

	// RVA: 0x594290 Offset: 0x592890 VA: 0x180594290
	public void set_m_szConnectionDescription(string value) { }
}

// Namespace: Steamworks
public struct SteamNetConnectionRealTimeStatus_t // TypeDefIndex: 10564
{
	// Fields
	public ESteamNetworkingConnectionState m_eState; // 0x0
	public int m_nPing; // 0x4
	public float m_flConnectionQualityLocal; // 0x8
	public float m_flConnectionQualityRemote; // 0xC
	public float m_flOutPacketsPerSec; // 0x10
	public float m_flOutBytesPerSec; // 0x14
	public float m_flInPacketsPerSec; // 0x18
	public float m_flInBytesPerSec; // 0x1C
	public int m_nSendRateBytesPerSecond; // 0x20
	public int m_cbPendingUnreliable; // 0x24
	public int m_cbPendingReliable; // 0x28
	public int m_cbSentUnackedReliable; // 0x2C
	public SteamNetworkingMicroseconds m_usecQueueTime; // 0x30
	public uint[] reserved; // 0x38
}

// Namespace: Steamworks
public struct SteamNetConnectionRealTimeLaneStatus_t // TypeDefIndex: 10565
{
	// Fields
	public int m_cbPendingUnreliable; // 0x0
	public int m_cbPendingReliable; // 0x4
	public int m_cbSentUnackedReliable; // 0x8
	public int _reservePad1; // 0xC
	public SteamNetworkingMicroseconds m_usecQueueTime; // 0x10
	public uint[] reserved; // 0x18
}

// Namespace: Steamworks
public struct SteamNetworkPingLocation_t // TypeDefIndex: 10566
{
	// Fields
	public byte[] m_data; // 0x0
}

// Namespace: Steamworks
public static class CallbackDispatcher // TypeDefIndex: 10567
{
	// Fields
	private static Dictionary<int, List<Callback>> m_registeredCallbacks; // 0x0
	private static Dictionary<int, List<Callback>> m_registeredGameServerCallbacks; // 0x8
	private static Dictionary<ulong, List<CallResult>> m_registeredCallResults; // 0x10
	private static object m_sync; // 0x18
	private static IntPtr m_pCallbackMsg; // 0x20
	private static int m_initCount; // 0x28

	// Properties
	public static bool IsInitialized { get; }

	// Methods

	// RVA: 0x591940 Offset: 0x58FF40 VA: 0x180591940
	public static void ExceptionHandler(Exception e) { }

	// RVA: 0x593BF0 Offset: 0x5921F0 VA: 0x180593BF0
	public static bool get_IsInitialized() { }

	// RVA: 0x591990 Offset: 0x58FF90 VA: 0x180591990
	internal static void Initialize() { }

	// RVA: 0x592C90 Offset: 0x591290 VA: 0x180592C90
	internal static void Shutdown() { }

	// RVA: 0x591BD0 Offset: 0x5901D0 VA: 0x180591BD0
	internal static void Register(Callback cb) { }

	// RVA: 0x591E60 Offset: 0x590460 VA: 0x180591E60
	internal static void Register(SteamAPICall_t asyncCall, CallResult cr) { }

	// RVA: 0x593850 Offset: 0x591E50 VA: 0x180593850
	internal static void Unregister(Callback cb) { }

	// RVA: 0x593630 Offset: 0x591C30 VA: 0x180593630
	internal static void Unregister(SteamAPICall_t asyncCall, CallResult cr) { }

	// RVA: 0x592E00 Offset: 0x591400 VA: 0x180592E00
	private static void UnregisterAll() { }

	// RVA: 0x592100 Offset: 0x590700 VA: 0x180592100
	internal static void RunFrame(bool isGameServer) { }

	// RVA: 0x593A60 Offset: 0x592060 VA: 0x180593A60
	private static void .cctor() { }
}

// Namespace: Steamworks
public abstract class Callback // TypeDefIndex: 10568
{
	// Properties
	public abstract bool IsGameServer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsGameServer();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract Type GetCallbackType();

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void OnRunCallback(IntPtr pvParam);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void SetUnregistered();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Steamworks
public sealed class Callback<T> : Callback, IDisposable // TypeDefIndex: 10570
{
	// Fields
	[CompilerGenerated]
	private Callback.DispatchDelegate<T> m_Func; // 0x0
	private bool m_bGameServer; // 0x0
	private bool m_bIsRegistered; // 0x0
	private bool m_bDisposed; // 0x0

	// Properties
	public override bool IsGameServer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void add_m_Func(Callback.DispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F7C0 Offset: 0xC8DDC0 VA: 0x180C8F7C0
	|-Callback<GameOverlayActivated_t>.add_m_Func
	|-Callback<PersonaStateChange_t>.add_m_Func
	|-Callback<UserStatsReceived_t>.add_m_Func
	|-Callback<__Il2CppFullySharedGenericType>.add_m_Func
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void remove_m_Func(Callback.DispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F890 Offset: 0xC8DE90 VA: 0x180C8F890
	|-Callback<GameOverlayActivated_t>.remove_m_Func
	|-Callback<PersonaStateChange_t>.remove_m_Func
	|-Callback<UserStatsReceived_t>.remove_m_Func
	|-Callback<__Il2CppFullySharedGenericType>.remove_m_Func
	*/

	// RVA: -1 Offset: -1
	public static Callback<T> Create(Callback.DispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC92930 Offset: 0xC90F30 VA: 0x180C92930
	|-Callback<GameOverlayActivated_t>.Create
	|
	|-RVA: 0xC92890 Offset: 0xC90E90 VA: 0x180C92890
	|-Callback<PersonaStateChange_t>.Create
	|
	|-RVA: 0xC929D0 Offset: 0xC90FD0 VA: 0x180C929D0
	|-Callback<UserStatsReceived_t>.Create
	|
	|-RVA: 0xC927D0 Offset: 0xC90DD0 VA: 0x180C927D0
	|-Callback<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public static Callback<T> CreateGameServer(Callback.DispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC925D0 Offset: 0xC90BD0 VA: 0x180C925D0
	|-Callback<GameOverlayActivated_t>.CreateGameServer
	|
	|-RVA: 0xC92670 Offset: 0xC90C70 VA: 0x180C92670
	|-Callback<PersonaStateChange_t>.CreateGameServer
	|
	|-RVA: 0xC92530 Offset: 0xC90B30 VA: 0x180C92530
	|-Callback<UserStatsReceived_t>.CreateGameServer
	|
	|-RVA: 0xC92710 Offset: 0xC90D10 VA: 0x180C92710
	|-Callback<__Il2CppFullySharedGenericType>.CreateGameServer
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Callback.DispatchDelegate<T> func, bool bGameServer = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC93B70 Offset: 0xC92170 VA: 0x180C93B70
	|-Callback<GameOverlayActivated_t>..ctor
	|
	|-RVA: 0xC93DD0 Offset: 0xC923D0 VA: 0x180C93DD0
	|-Callback<PersonaStateChange_t>..ctor
	|
	|-RVA: 0xC93CA0 Offset: 0xC922A0 VA: 0x180C93CA0
	|-Callback<UserStatsReceived_t>..ctor
	|
	|-RVA: 0xC93F00 Offset: 0xC92500 VA: 0x180C93F00
	|-Callback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC92CD0 Offset: 0xC912D0 VA: 0x180C92CD0
	|-Callback<GameOverlayActivated_t>.Finalize
	|
	|-RVA: 0xC92DD0 Offset: 0xC913D0 VA: 0x180C92DD0
	|-Callback<PersonaStateChange_t>.Finalize
	|
	|-RVA: 0xC92ED0 Offset: 0xC914D0 VA: 0x180C92ED0
	|-Callback<UserStatsReceived_t>.Finalize
	|
	|-RVA: 0xC92FD0 Offset: 0xC915D0 VA: 0x180C92FD0
	|-Callback<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC92A70 Offset: 0xC91070 VA: 0x180C92A70
	|-Callback<GameOverlayActivated_t>.Dispose
	|
	|-RVA: 0xC92C30 Offset: 0xC91230 VA: 0x180C92C30
	|-Callback<PersonaStateChange_t>.Dispose
	|
	|-RVA: 0xC92B10 Offset: 0xC91110 VA: 0x180C92B10
	|-Callback<UserStatsReceived_t>.Dispose
	|
	|-RVA: 0xC92BB0 Offset: 0xC911B0 VA: 0x180C92BB0
	|-Callback<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Register(Callback.DispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC936F0 Offset: 0xC91CF0 VA: 0x180C936F0
	|-Callback<GameOverlayActivated_t>.Register
	|
	|-RVA: 0xC93800 Offset: 0xC91E00 VA: 0x180C93800
	|-Callback<PersonaStateChange_t>.Register
	|
	|-RVA: 0xC93910 Offset: 0xC91F10 VA: 0x180C93910
	|-Callback<UserStatsReceived_t>.Register
	|
	|-RVA: 0xC93610 Offset: 0xC91C10 VA: 0x180C93610
	|-Callback<__Il2CppFullySharedGenericType>.Register
	*/

	// RVA: -1 Offset: -1
	public void Unregister() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC93AD0 Offset: 0xC920D0 VA: 0x180C93AD0
	|-Callback<GameOverlayActivated_t>.Unregister
	|
	|-RVA: 0xC93A30 Offset: 0xC92030 VA: 0x180C93A30
	|-Callback<PersonaStateChange_t>.Unregister
	|
	|-RVA: 0xC93A80 Offset: 0xC92080 VA: 0x180C93A80
	|-Callback<UserStatsReceived_t>.Unregister
	|
	|-RVA: 0xC93B20 Offset: 0xC92120 VA: 0x180C93B20
	|-Callback<__Il2CppFullySharedGenericType>.Unregister
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override bool get_IsGameServer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	|-Callback<GameOverlayActivated_t>.get_IsGameServer
	|-Callback<PersonaStateChange_t>.get_IsGameServer
	|-Callback<UserStatsReceived_t>.get_IsGameServer
	|-Callback<__Il2CppFullySharedGenericType>.get_IsGameServer
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override Type GetCallbackType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DB880 Offset: 0x8D9E80 VA: 0x1808DB880
	|-Callback<GameOverlayActivated_t>.GetCallbackType
	|-Callback<PersonaStateChange_t>.GetCallbackType
	|-Callback<UserStatsReceived_t>.GetCallbackType
	|-Callback<__Il2CppFullySharedGenericType>.GetCallbackType
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override void OnRunCallback(IntPtr pvParam) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC93060 Offset: 0xC91660 VA: 0x180C93060
	|-Callback<GameOverlayActivated_t>.OnRunCallback
	|
	|-RVA: 0xC934C0 Offset: 0xC91AC0 VA: 0x180C934C0
	|-Callback<PersonaStateChange_t>.OnRunCallback
	|
	|-RVA: 0xC931C0 Offset: 0xC917C0 VA: 0x180C931C0
	|-Callback<UserStatsReceived_t>.OnRunCallback
	|
	|-RVA: 0xC93320 Offset: 0xC91920 VA: 0x180C93320
	|-Callback<__Il2CppFullySharedGenericType>.OnRunCallback
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override void SetUnregistered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC93A20 Offset: 0xC92020 VA: 0x180C93A20
	|-Callback<GameOverlayActivated_t>.SetUnregistered
	|-Callback<PersonaStateChange_t>.SetUnregistered
	|-Callback<UserStatsReceived_t>.SetUnregistered
	|-Callback<__Il2CppFullySharedGenericType>.SetUnregistered
	*/
}

// Namespace: Steamworks
public abstract class CallResult // TypeDefIndex: 10571
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Type GetCallbackType();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void SetUnregistered();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Steamworks
public sealed class CallResult<T> : CallResult, IDisposable // TypeDefIndex: 10573
{
	// Fields
	[CompilerGenerated]
	private CallResult.APIDispatchDelegate<T> m_Func; // 0x0
	private SteamAPICall_t m_hAPICall; // 0x0
	private bool m_bDisposed; // 0x0

	// Properties
	public SteamAPICall_t Handle { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void add_m_Func(CallResult.APIDispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F7C0 Offset: 0xC8DDC0 VA: 0x180C8F7C0
	|-CallResult<LeaderboardFindResult_t>.add_m_Func
	|-CallResult<LeaderboardScoreUploaded_t>.add_m_Func
	|-CallResult<LeaderboardScoresDownloaded_t>.add_m_Func
	|-CallResult<__Il2CppFullySharedGenericType>.add_m_Func
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void remove_m_Func(CallResult.APIDispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F890 Offset: 0xC8DE90 VA: 0x180C8F890
	|-CallResult<LeaderboardFindResult_t>.remove_m_Func
	|-CallResult<LeaderboardScoreUploaded_t>.remove_m_Func
	|-CallResult<LeaderboardScoresDownloaded_t>.remove_m_Func
	|-CallResult<__Il2CppFullySharedGenericType>.remove_m_Func
	*/

	// RVA: -1 Offset: -1
	public SteamAPICall_t get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-CallResult<LeaderboardFindResult_t>.get_Handle
	|-CallResult<LeaderboardScoreUploaded_t>.get_Handle
	|-CallResult<LeaderboardScoresDownloaded_t>.get_Handle
	|-CallResult<__Il2CppFullySharedGenericType>.get_Handle
	*/

	// RVA: -1 Offset: -1
	public static CallResult<T> Create(CallResult.APIDispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8DAD0 Offset: 0xC8C0D0 VA: 0x180C8DAD0
	|-CallResult<LeaderboardFindResult_t>.Create
	|
	|-RVA: 0xC8D9F0 Offset: 0xC8BFF0 VA: 0x180C8D9F0
	|-CallResult<LeaderboardScoreUploaded_t>.Create
	|
	|-RVA: 0xC8DC70 Offset: 0xC8C270 VA: 0x180C8DC70
	|-CallResult<LeaderboardScoresDownloaded_t>.Create
	|
	|-RVA: 0xC8DBB0 Offset: 0xC8C1B0 VA: 0x180C8DBB0
	|-CallResult<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CallResult.APIDispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F640 Offset: 0xC8DC40 VA: 0x180C8F640
	|-CallResult<LeaderboardFindResult_t>..ctor
	|
	|-RVA: 0xC8F5C0 Offset: 0xC8DBC0 VA: 0x180C8F5C0
	|-CallResult<LeaderboardScoreUploaded_t>..ctor
	|
	|-RVA: 0xC8F6C0 Offset: 0xC8DCC0 VA: 0x180C8F6C0
	|-CallResult<LeaderboardScoresDownloaded_t>..ctor
	|
	|-RVA: 0xC8F740 Offset: 0xC8DD40 VA: 0x180C8F740
	|-CallResult<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8E230 Offset: 0xC8C830 VA: 0x180C8E230
	|-CallResult<LeaderboardFindResult_t>.Finalize
	|
	|-RVA: 0xC8E0D0 Offset: 0xC8C6D0 VA: 0x180C8E0D0
	|-CallResult<LeaderboardScoreUploaded_t>.Finalize
	|
	|-RVA: 0xC8E390 Offset: 0xC8C990 VA: 0x180C8E390
	|-CallResult<LeaderboardScoresDownloaded_t>.Finalize
	|
	|-RVA: 0xC8E4F0 Offset: 0xC8CAF0 VA: 0x180C8E4F0
	|-CallResult<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8DED0 Offset: 0xC8C4D0 VA: 0x180C8DED0
	|-CallResult<LeaderboardFindResult_t>.Dispose
	|
	|-RVA: 0xC8DDD0 Offset: 0xC8C3D0 VA: 0x180C8DDD0
	|-CallResult<LeaderboardScoreUploaded_t>.Dispose
	|
	|-RVA: 0xC8DFD0 Offset: 0xC8C5D0 VA: 0x180C8DFD0
	|-CallResult<LeaderboardScoresDownloaded_t>.Dispose
	|
	|-RVA: 0xC8DD50 Offset: 0xC8C350 VA: 0x180C8DD50
	|-CallResult<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Set(SteamAPICall_t hAPICall, CallResult.APIDispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8EFC0 Offset: 0xC8D5C0 VA: 0x180C8EFC0
	|-CallResult<LeaderboardFindResult_t>.Set
	|
	|-RVA: 0xC8F140 Offset: 0xC8D740 VA: 0x180C8F140
	|-CallResult<LeaderboardScoreUploaded_t>.Set
	|
	|-RVA: 0xC8F440 Offset: 0xC8DA40 VA: 0x180C8F440
	|-CallResult<LeaderboardScoresDownloaded_t>.Set
	|
	|-RVA: 0xC8F2C0 Offset: 0xC8D8C0 VA: 0x180C8F2C0
	|-CallResult<__Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public bool IsActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8E580 Offset: 0xC8CB80 VA: 0x180C8E580
	|-CallResult<LeaderboardFindResult_t>.IsActive
	|
	|-RVA: 0xC8E6D0 Offset: 0xC8CCD0 VA: 0x180C8E6D0
	|-CallResult<LeaderboardScoreUploaded_t>.IsActive
	|
	|-RVA: 0xC8E5F0 Offset: 0xC8CBF0 VA: 0x180C8E5F0
	|-CallResult<LeaderboardScoresDownloaded_t>.IsActive
	|
	|-RVA: 0xC8E660 Offset: 0xC8CC60 VA: 0x180C8E660
	|-CallResult<__Il2CppFullySharedGenericType>.IsActive
	*/

	// RVA: -1 Offset: -1
	public void Cancel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8D720 Offset: 0xC8BD20 VA: 0x180C8D720
	|-CallResult<LeaderboardFindResult_t>.Cancel
	|
	|-RVA: 0xC8D930 Offset: 0xC8BF30 VA: 0x180C8D930
	|-CallResult<LeaderboardScoreUploaded_t>.Cancel
	|
	|-RVA: 0xC8D870 Offset: 0xC8BE70 VA: 0x180C8D870
	|-CallResult<LeaderboardScoresDownloaded_t>.Cancel
	|
	|-RVA: 0xC8D7E0 Offset: 0xC8BDE0 VA: 0x180C8D7E0
	|-CallResult<__Il2CppFullySharedGenericType>.Cancel
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override Type GetCallbackType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DB880 Offset: 0x8D9E80 VA: 0x1808DB880
	|-CallResult<LeaderboardFindResult_t>.GetCallbackType
	|-CallResult<LeaderboardScoreUploaded_t>.GetCallbackType
	|-CallResult<LeaderboardScoresDownloaded_t>.GetCallbackType
	|-CallResult<__Il2CppFullySharedGenericType>.GetCallbackType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8E740 Offset: 0xC8CD40 VA: 0x180C8E740
	|-CallResult<LeaderboardFindResult_t>.OnRunCallResult
	|
	|-RVA: 0xC8EC90 Offset: 0xC8D290 VA: 0x180C8EC90
	|-CallResult<LeaderboardScoreUploaded_t>.OnRunCallResult
	|
	|-RVA: 0xC8E8E0 Offset: 0xC8CEE0 VA: 0x180C8E8E0
	|-CallResult<LeaderboardScoresDownloaded_t>.OnRunCallResult
	|
	|-RVA: 0xC8EA90 Offset: 0xC8D090 VA: 0x180C8EA90
	|-CallResult<__Il2CppFullySharedGenericType>.OnRunCallResult
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override void SetUnregistered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8EE40 Offset: 0xC8D440 VA: 0x180C8EE40
	|-CallResult<LeaderboardFindResult_t>.SetUnregistered
	|
	|-RVA: 0xC8EF60 Offset: 0xC8D560 VA: 0x180C8EF60
	|-CallResult<LeaderboardScoreUploaded_t>.SetUnregistered
	|
	|-RVA: 0xC8EEA0 Offset: 0xC8D4A0 VA: 0x180C8EEA0
	|-CallResult<LeaderboardScoresDownloaded_t>.SetUnregistered
	|
	|-RVA: 0xC8EF00 Offset: 0xC8D500 VA: 0x180C8EF00
	|-CallResult<__Il2CppFullySharedGenericType>.SetUnregistered
	*/
}

// Namespace: Steamworks
internal class CallbackIdentities // TypeDefIndex: 10574
{
	// Methods

	// RVA: 0x593C50 Offset: 0x592250 VA: 0x180593C50
	public static int GetCallbackIdentity(Type callbackStruct) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Steamworks
[Usage(8, AllowMultiple = False)]
internal class CallbackIdentityAttribute : Attribute // TypeDefIndex: 10575
{
	// Fields
	[CompilerGenerated]
	private int <Identity>k__BackingField; // 0x10

	// Properties
	public int Identity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Identity() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_Identity(int value) { }

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int callbackNum) { }
}

// Namespace: Steamworks
public class InteropHelp // TypeDefIndex: 10578
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void TestIfPlatformSupported() { }

	// RVA: 0x597D60 Offset: 0x596360 VA: 0x180597D60
	public static void TestIfAvailableClient() { }

	// RVA: 0x597E00 Offset: 0x596400 VA: 0x180597E00
	public static void TestIfAvailableGameServer() { }

	// RVA: 0x597B80 Offset: 0x596180 VA: 0x180597B80
	public static string PtrToStringUTF8(IntPtr nativeUtf8) { }

	// RVA: 0x597B00 Offset: 0x596100 VA: 0x180597B00
	public static string ByteArrayToStringUTF8(byte[] buffer) { }

	// RVA: 0x597CB0 Offset: 0x5962B0 VA: 0x180597CB0
	public static void StringToByteArrayUTF8(string str, byte[] outArrayBuffer, int outArrayBufferSize) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Steamworks
public class MMKVPMarshaller // TypeDefIndex: 10579
{
	// Fields
	private IntPtr m_pNativeArray; // 0x10
	private IntPtr m_pArrayEntries; // 0x18

	// Methods

	// RVA: 0x597FF0 Offset: 0x5965F0 VA: 0x180597FF0
	public void .ctor(MatchMakingKeyValuePair_t[] filters) { }

	// RVA: 0x597F20 Offset: 0x596520 VA: 0x180597F20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x5981E0 Offset: 0x5967E0 VA: 0x1805981E0
	public static IntPtr op_Implicit(MMKVPMarshaller that) { }
}

// Namespace: Steamworks
public class DllCheck // TypeDefIndex: 10580
{
	// Methods

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	public static bool Test() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Steamworks
public class ISteamMatchmakingServerListResponse // TypeDefIndex: 10588
{
	// Fields
	private ISteamMatchmakingServerListResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingServerListResponse.ServerResponded m_ServerResponded; // 0x28
	private ISteamMatchmakingServerListResponse.ServerFailedToRespond m_ServerFailedToRespond; // 0x30
	private ISteamMatchmakingServerListResponse.RefreshComplete m_RefreshComplete; // 0x38

	// Methods

	// RVA: 0x596A00 Offset: 0x595000 VA: 0x180596A00
	public void .ctor(ISteamMatchmakingServerListResponse.ServerResponded onServerResponded, ISteamMatchmakingServerListResponse.ServerFailedToRespond onServerFailedToRespond, ISteamMatchmakingServerListResponse.RefreshComplete onRefreshComplete) { }

	// RVA: 0x596800 Offset: 0x594E00 VA: 0x180596800 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x596990 Offset: 0x594F90 VA: 0x180596990
	private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x596920 Offset: 0x594F20 VA: 0x180596920
	private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x5968B0 Offset: 0x594EB0 VA: 0x1805968B0
	private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	// RVA: 0x595E20 Offset: 0x594420 VA: 0x180595E20
	public static IntPtr op_Explicit(ISteamMatchmakingServerListResponse that) { }
}

// Namespace: Steamworks
public class ISteamMatchmakingPingResponse // TypeDefIndex: 10594
{
	// Fields
	private ISteamMatchmakingPingResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingPingResponse.ServerResponded m_ServerResponded; // 0x28
	private ISteamMatchmakingPingResponse.ServerFailedToRespond m_ServerFailedToRespond; // 0x30

	// Methods

	// RVA: 0x595B20 Offset: 0x594120 VA: 0x180595B20
	public void .ctor(ISteamMatchmakingPingResponse.ServerResponded onServerResponded, ISteamMatchmakingPingResponse.ServerFailedToRespond onServerFailedToRespond) { }

	// RVA: 0x595A10 Offset: 0x594010 VA: 0x180595A10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x595AF0 Offset: 0x5940F0 VA: 0x180595AF0
	private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server) { }

	// RVA: 0x595AC0 Offset: 0x5940C0 VA: 0x180595AC0
	private void InternalOnServerFailedToRespond(IntPtr thisptr) { }

	// RVA: 0x595E20 Offset: 0x594420 VA: 0x180595E20
	public static IntPtr op_Explicit(ISteamMatchmakingPingResponse that) { }
}

// Namespace: Steamworks
public class ISteamMatchmakingPlayersResponse // TypeDefIndex: 10602
{
	// Fields
	private ISteamMatchmakingPlayersResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingPlayersResponse.AddPlayerToList m_AddPlayerToList; // 0x28
	private ISteamMatchmakingPlayersResponse.PlayersFailedToRespond m_PlayersFailedToRespond; // 0x30
	private ISteamMatchmakingPlayersResponse.PlayersRefreshComplete m_PlayersRefreshComplete; // 0x38

	// Methods

	// RVA: 0x595F70 Offset: 0x594570 VA: 0x180595F70
	public void .ctor(ISteamMatchmakingPlayersResponse.AddPlayerToList onAddPlayerToList, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond onPlayersFailedToRespond, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete onPlayersRefreshComplete) { }

	// RVA: 0x595E40 Offset: 0x594440 VA: 0x180595E40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x595EF0 Offset: 0x5944F0 VA: 0x180595EF0
	private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	// RVA: 0x595AC0 Offset: 0x5940C0 VA: 0x180595AC0
	private void InternalOnPlayersFailedToRespond(IntPtr thisptr) { }

	// RVA: 0x595F40 Offset: 0x594540 VA: 0x180595F40
	private void InternalOnPlayersRefreshComplete(IntPtr thisptr) { }

	// RVA: 0x595E20 Offset: 0x594420 VA: 0x180595E20
	public static IntPtr op_Explicit(ISteamMatchmakingPlayersResponse that) { }
}

// Namespace: Steamworks
public class ISteamMatchmakingRulesResponse // TypeDefIndex: 10610
{
	// Fields
	private ISteamMatchmakingRulesResponse.VTable m_VTable; // 0x10
	private IntPtr m_pVTable; // 0x18
	private GCHandle m_pGCHandle; // 0x20
	private ISteamMatchmakingRulesResponse.RulesResponded m_RulesResponded; // 0x28
	private ISteamMatchmakingRulesResponse.RulesFailedToRespond m_RulesFailedToRespond; // 0x30
	private ISteamMatchmakingRulesResponse.RulesRefreshComplete m_RulesRefreshComplete; // 0x38

	// Methods

	// RVA: 0x596440 Offset: 0x594A40 VA: 0x180596440
	public void .ctor(ISteamMatchmakingRulesResponse.RulesResponded onRulesResponded, ISteamMatchmakingRulesResponse.RulesFailedToRespond onRulesFailedToRespond, ISteamMatchmakingRulesResponse.RulesRefreshComplete onRulesRefreshComplete) { }

	// RVA: 0x596330 Offset: 0x594930 VA: 0x180596330 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x5963E0 Offset: 0x5949E0 VA: 0x1805963E0
	private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue) { }

	// RVA: 0x595AC0 Offset: 0x5940C0 VA: 0x180595AC0
	private void InternalOnRulesFailedToRespond(IntPtr thisptr) { }

	// RVA: 0x595F40 Offset: 0x594540 VA: 0x180595F40
	private void InternalOnRulesRefreshComplete(IntPtr thisptr) { }

	// RVA: 0x595E20 Offset: 0x594420 VA: 0x180595E20
	public static IntPtr op_Explicit(ISteamMatchmakingRulesResponse that) { }
}

// Namespace: Steamworks
public static class Packsize // TypeDefIndex: 10612
{
	// Fields
	public const int value = 8;

	// Methods

	// RVA: 0x5C29A0 Offset: 0x5C0FA0 VA: 0x1805C29A0
	public static bool Test() { }
}

// Namespace: Steamworks
public static class SteamAPI // TypeDefIndex: 10613
{
	// Methods

	// RVA: 0x5C3C30 Offset: 0x5C2230 VA: 0x1805C3C30
	public static ESteamAPIInitResult InitEx(out string OutSteamErrMsg) { }

	// RVA: 0x5C4470 Offset: 0x5C2A70 VA: 0x1805C4470
	public static bool Init() { }

	// RVA: 0x5C44F0 Offset: 0x5C2AF0 VA: 0x1805C44F0
	public static void Shutdown() { }

	// RVA: 0x5BF630 Offset: 0x5BDC30 VA: 0x1805BF630
	public static bool RestartAppIfNecessary(AppId_t unOwnAppID) { }

	// RVA: 0x5BF5C0 Offset: 0x5BDBC0 VA: 0x1805BF5C0
	public static void ReleaseCurrentThreadMemory() { }

	// RVA: 0x5C44A0 Offset: 0x5C2AA0 VA: 0x1805C44A0
	public static void RunCallbacks() { }

	// RVA: 0x5BF150 Offset: 0x5BD750 VA: 0x1805BF150
	public static bool IsSteamRunning() { }

	// RVA: 0x5C3BA0 Offset: 0x5C21A0 VA: 0x1805C3BA0
	public static HSteamPipe GetHSteamPipe() { }

	// RVA: 0x5C3BC0 Offset: 0x5C21C0 VA: 0x1805C3BC0
	public static HSteamUser GetHSteamUser() { }
}

// Namespace: Steamworks
public static class GameServer // TypeDefIndex: 10614
{
	// Methods

	// RVA: 0x5946D0 Offset: 0x592CD0 VA: 0x1805946D0
	public static ESteamAPIInitResult InitEx(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString, out string OutSteamErrMsg) { }

	// RVA: 0x594C90 Offset: 0x593290 VA: 0x180594C90
	public static bool Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString) { }

	// RVA: 0x594D90 Offset: 0x593390 VA: 0x180594D90
	public static void Shutdown() { }

	// RVA: 0x594D40 Offset: 0x593340 VA: 0x180594D40
	public static void RunCallbacks() { }

	// RVA: 0x594CD0 Offset: 0x5932D0 VA: 0x180594CD0
	public static void ReleaseCurrentThreadMemory() { }

	// RVA: 0x594520 Offset: 0x592B20 VA: 0x180594520
	public static bool BSecure() { }

	// RVA: 0x594620 Offset: 0x592C20 VA: 0x180594620
	public static CSteamID GetSteamID() { }

	// RVA: 0x594590 Offset: 0x592B90 VA: 0x180594590
	public static HSteamPipe GetHSteamPipe() { }

	// RVA: 0x5945B0 Offset: 0x592BB0 VA: 0x1805945B0
	public static HSteamUser GetHSteamUser() { }
}

// Namespace: Steamworks
public static class SteamEncryptedAppTicket // TypeDefIndex: 10615
{
	// Methods

	// RVA: 0x5C19D0 Offset: 0x5BFFD0 VA: 0x1805C19D0
	public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey) { }

	// RVA: 0x5C1C00 Offset: 0x5C0200 VA: 0x1805C1C00
	public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	// RVA: 0x5C1F30 Offset: 0x5C0530 VA: 0x1805C1F30
	public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5C1FC0 Offset: 0x5C05C0 VA: 0x1805C1FC0
	public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	// RVA: 0x5C1EA0 Offset: 0x5C04A0 VA: 0x1805C1EA0
	public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5C1E00 Offset: 0x5C0400 VA: 0x1805C1E00
	public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	// RVA: 0x5C1D60 Offset: 0x5C0360 VA: 0x1805C1D60
	public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	// RVA: 0x5C4840 Offset: 0x5C2E40 VA: 0x1805C4840
	public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

	// RVA: 0x5C1CA0 Offset: 0x5C02A0 VA: 0x1805C1CA0
	public static bool BIsTicketSigned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, byte[] pubRSAKey, uint cubRSAKey) { }
}

// Namespace: Steamworks
internal static class CSteamAPIContext // TypeDefIndex: 10616
{
	// Fields
	private static IntPtr m_pSteamClient; // 0x0
	private static IntPtr m_pSteamUser; // 0x8
	private static IntPtr m_pSteamFriends; // 0x10
	private static IntPtr m_pSteamUtils; // 0x18
	private static IntPtr m_pSteamMatchmaking; // 0x20
	private static IntPtr m_pSteamUserStats; // 0x28
	private static IntPtr m_pSteamApps; // 0x30
	private static IntPtr m_pSteamMatchmakingServers; // 0x38
	private static IntPtr m_pSteamNetworking; // 0x40
	private static IntPtr m_pSteamRemoteStorage; // 0x48
	private static IntPtr m_pSteamScreenshots; // 0x50
	private static IntPtr m_pSteamGameSearch; // 0x58
	private static IntPtr m_pSteamHTTP; // 0x60
	private static IntPtr m_pController; // 0x68
	private static IntPtr m_pSteamUGC; // 0x70
	private static IntPtr m_pSteamMusic; // 0x78
	private static IntPtr m_pSteamMusicRemote; // 0x80
	private static IntPtr m_pSteamHTMLSurface; // 0x88
	private static IntPtr m_pSteamInventory; // 0x90
	private static IntPtr m_pSteamVideo; // 0x98
	private static IntPtr m_pSteamParentalSettings; // 0xA0
	private static IntPtr m_pSteamInput; // 0xA8
	private static IntPtr m_pSteamParties; // 0xB0
	private static IntPtr m_pSteamRemotePlay; // 0xB8
	private static IntPtr m_pSteamNetworkingUtils; // 0xC0
	private static IntPtr m_pSteamNetworkingSockets; // 0xC8
	private static IntPtr m_pSteamNetworkingMessages; // 0xD0
	private static IntPtr m_pSteamTimeline; // 0xD8

	// Methods

	// RVA: 0x58EA60 Offset: 0x58D060 VA: 0x18058EA60
	internal static void Clear() { }

	// RVA: 0x58F3C0 Offset: 0x58D9C0 VA: 0x18058F3C0
	internal static bool Init() { }

	// RVA: 0x58ED00 Offset: 0x58D300 VA: 0x18058ED00
	internal static IntPtr GetSteamClient() { }

	// RVA: 0x58F300 Offset: 0x58D900 VA: 0x18058F300
	internal static IntPtr GetSteamUser() { }

	// RVA: 0x58ED80 Offset: 0x58D380 VA: 0x18058ED80
	internal static IntPtr GetSteamFriends() { }

	// RVA: 0x58F340 Offset: 0x58D940 VA: 0x18058F340
	internal static IntPtr GetSteamUtils() { }

	// RVA: 0x58EF40 Offset: 0x58D540 VA: 0x18058EF40
	internal static IntPtr GetSteamMatchmaking() { }

	// RVA: 0x58F2C0 Offset: 0x58D8C0 VA: 0x18058F2C0
	internal static IntPtr GetSteamUserStats() { }

	// RVA: 0x58ECC0 Offset: 0x58D2C0 VA: 0x18058ECC0
	internal static IntPtr GetSteamApps() { }

	// RVA: 0x58EF00 Offset: 0x58D500 VA: 0x18058EF00
	internal static IntPtr GetSteamMatchmakingServers() { }

	// RVA: 0x58F0C0 Offset: 0x58D6C0 VA: 0x18058F0C0
	internal static IntPtr GetSteamNetworking() { }

	// RVA: 0x58F1C0 Offset: 0x58D7C0 VA: 0x18058F1C0
	internal static IntPtr GetSteamRemoteStorage() { }

	// RVA: 0x58F200 Offset: 0x58D800 VA: 0x18058F200
	internal static IntPtr GetSteamScreenshots() { }

	// RVA: 0x58EDC0 Offset: 0x58D3C0 VA: 0x18058EDC0
	internal static IntPtr GetSteamGameSearch() { }

	// RVA: 0x58EE40 Offset: 0x58D440 VA: 0x18058EE40
	internal static IntPtr GetSteamHTTP() { }

	// RVA: 0x58ED40 Offset: 0x58D340 VA: 0x18058ED40
	internal static IntPtr GetSteamController() { }

	// RVA: 0x58F280 Offset: 0x58D880 VA: 0x18058F280
	internal static IntPtr GetSteamUGC() { }

	// RVA: 0x58EFC0 Offset: 0x58D5C0 VA: 0x18058EFC0
	internal static IntPtr GetSteamMusic() { }

	// RVA: 0x58EF80 Offset: 0x58D580 VA: 0x18058EF80
	internal static IntPtr GetSteamMusicRemote() { }

	// RVA: 0x58EE00 Offset: 0x58D400 VA: 0x18058EE00
	internal static IntPtr GetSteamHTMLSurface() { }

	// RVA: 0x58EEC0 Offset: 0x58D4C0 VA: 0x18058EEC0
	internal static IntPtr GetSteamInventory() { }

	// RVA: 0x58F380 Offset: 0x58D980 VA: 0x18058F380
	internal static IntPtr GetSteamVideo() { }

	// RVA: 0x58F100 Offset: 0x58D700 VA: 0x18058F100
	internal static IntPtr GetSteamParentalSettings() { }

	// RVA: 0x58EE80 Offset: 0x58D480 VA: 0x18058EE80
	internal static IntPtr GetSteamInput() { }

	// RVA: 0x58F140 Offset: 0x58D740 VA: 0x18058F140
	internal static IntPtr GetSteamParties() { }

	// RVA: 0x58F180 Offset: 0x58D780 VA: 0x18058F180
	internal static IntPtr GetSteamRemotePlay() { }

	// RVA: 0x58F080 Offset: 0x58D680 VA: 0x18058F080
	internal static IntPtr GetSteamNetworkingUtils() { }

	// RVA: 0x58F040 Offset: 0x58D640 VA: 0x18058F040
	internal static IntPtr GetSteamNetworkingSockets() { }

	// RVA: 0x58F000 Offset: 0x58D600 VA: 0x18058F000
	internal static IntPtr GetSteamNetworkingMessages() { }

	// RVA: 0x58F240 Offset: 0x58D840 VA: 0x18058F240
	internal static IntPtr GetSteamTimeline() { }
}

// Namespace: Steamworks
internal static class CSteamGameServerAPIContext // TypeDefIndex: 10617
{
	// Fields
	private static IntPtr m_pSteamClient; // 0x0
	private static IntPtr m_pSteamGameServer; // 0x8
	private static IntPtr m_pSteamUtils; // 0x10
	private static IntPtr m_pSteamNetworking; // 0x18
	private static IntPtr m_pSteamGameServerStats; // 0x20
	private static IntPtr m_pSteamHTTP; // 0x28
	private static IntPtr m_pSteamInventory; // 0x30
	private static IntPtr m_pSteamUGC; // 0x38
	private static IntPtr m_pSteamNetworkingUtils; // 0x40
	private static IntPtr m_pSteamNetworkingSockets; // 0x48
	private static IntPtr m_pSteamNetworkingMessages; // 0x50

	// Methods

	// RVA: 0x58FF90 Offset: 0x58E590 VA: 0x18058FF90
	internal static void Clear() { }

	// RVA: 0x590340 Offset: 0x58E940 VA: 0x180590340
	internal static bool Init() { }

	// RVA: 0x590080 Offset: 0x58E680 VA: 0x180590080
	internal static IntPtr GetSteamClient() { }

	// RVA: 0x590100 Offset: 0x58E700 VA: 0x180590100
	internal static IntPtr GetSteamGameServer() { }

	// RVA: 0x590300 Offset: 0x58E900 VA: 0x180590300
	internal static IntPtr GetSteamUtils() { }

	// RVA: 0x590280 Offset: 0x58E880 VA: 0x180590280
	internal static IntPtr GetSteamNetworking() { }

	// RVA: 0x5900C0 Offset: 0x58E6C0 VA: 0x1805900C0
	internal static IntPtr GetSteamGameServerStats() { }

	// RVA: 0x590140 Offset: 0x58E740 VA: 0x180590140
	internal static IntPtr GetSteamHTTP() { }

	// RVA: 0x590180 Offset: 0x58E780 VA: 0x180590180
	internal static IntPtr GetSteamInventory() { }

	// RVA: 0x5902C0 Offset: 0x58E8C0 VA: 0x1805902C0
	internal static IntPtr GetSteamUGC() { }

	// RVA: 0x590240 Offset: 0x58E840 VA: 0x180590240
	internal static IntPtr GetSteamNetworkingUtils() { }

	// RVA: 0x590200 Offset: 0x58E800 VA: 0x180590200
	internal static IntPtr GetSteamNetworkingSockets() { }

	// RVA: 0x5901C0 Offset: 0x58E7C0 VA: 0x1805901C0
	internal static IntPtr GetSteamNetworkingMessages() { }
}

// Namespace: Steamworks
[Serializable]
public class gameserveritem_t // TypeDefIndex: 10618
{
	// Fields
	public servernetadr_t m_NetAdr; // 0x10
	public int m_nPing; // 0x18
	public bool m_bHadSuccessfulResponse; // 0x1C
	public bool m_bDoNotRefresh; // 0x1D
	private byte[] m_szGameDir; // 0x20
	private byte[] m_szMap; // 0x28
	private byte[] m_szGameDescription; // 0x30
	public uint m_nAppID; // 0x38
	public int m_nPlayers; // 0x3C
	public int m_nMaxPlayers; // 0x40
	public int m_nBotPlayers; // 0x44
	public bool m_bPassword; // 0x48
	public bool m_bSecure; // 0x49
	public uint m_ulTimeLastPlayed; // 0x4C
	public int m_nServerVersion; // 0x50
	private byte[] m_szServerName; // 0x58
	private byte[] m_szGameTags; // 0x60
	public CSteamID m_steamID; // 0x68

	// Methods

	// RVA: 0x5CF7A0 Offset: 0x5CDDA0 VA: 0x1805CF7A0
	public string GetGameDir() { }

	// RVA: 0x5CFAC0 Offset: 0x5CE0C0 VA: 0x1805CFAC0
	public void SetGameDir(string dir) { }

	// RVA: 0x5CF8C0 Offset: 0x5CDEC0 VA: 0x1805CF8C0
	public string GetMap() { }

	// RVA: 0x5CFC00 Offset: 0x5CE200 VA: 0x1805CFC00
	public void SetMap(string map) { }

	// RVA: 0x5CF710 Offset: 0x5CDD10 VA: 0x1805CF710
	public string GetGameDescription() { }

	// RVA: 0x5CFA20 Offset: 0x5CE020 VA: 0x1805CFA20
	public void SetGameDescription(string desc) { }

	// RVA: 0x5CF950 Offset: 0x5CDF50 VA: 0x1805CF950
	public string GetServerName() { }

	// RVA: 0x5CFCA0 Offset: 0x5CE2A0 VA: 0x1805CFCA0
	public void SetServerName(string name) { }

	// RVA: 0x5CF830 Offset: 0x5CDE30 VA: 0x1805CF830
	public string GetGameTags() { }

	// RVA: 0x5CFB60 Offset: 0x5CE160 VA: 0x1805CFB60
	public void SetGameTags(string tags) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct servernetadr_t // TypeDefIndex: 10619
{
	// Fields
	private ushort m_usConnectionPort; // 0x0
	private ushort m_usQueryPort; // 0x2
	private uint m_unIP; // 0x4

	// Methods

	// RVA: 0x5CFF30 Offset: 0x5CE530 VA: 0x1805CFF30
	public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort) { }

	// RVA: 0x5CFF20 Offset: 0x5CE520 VA: 0x1805CFF20
	public ushort GetQueryPort() { }

	// RVA: 0x5CFF50 Offset: 0x5CE550 VA: 0x1805CFF50
	public void SetQueryPort(ushort usPort) { }

	// RVA: 0x5CFEA0 Offset: 0x5CE4A0 VA: 0x1805CFEA0
	public ushort GetConnectionPort() { }

	// RVA: 0x594180 Offset: 0x592780 VA: 0x180594180
	public void SetConnectionPort(ushort usPort) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public uint GetIP() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void SetIP(uint unIP) { }

	// RVA: 0x5CFE90 Offset: 0x5CE490 VA: 0x1805CFE90
	public string GetConnectionAddressString() { }

	// RVA: 0x5CFF10 Offset: 0x5CE510 VA: 0x1805CFF10
	public string GetQueryAddressString() { }

	// RVA: 0x5CFF60 Offset: 0x5CE560 VA: 0x1805CFF60
	public static string ToString(uint unIP, ushort usPort) { }

	// RVA: 0x5D02A0 Offset: 0x5CE8A0 VA: 0x1805D02A0
	public static bool op_LessThan(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0x5D0220 Offset: 0x5CE820 VA: 0x1805D0220
	public static bool op_GreaterThan(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0x5CFDE0 Offset: 0x5CE3E0 VA: 0x1805CFDE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x5CFEB0 Offset: 0x5CE4B0 VA: 0x1805CFEB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5D01E0 Offset: 0x5CE7E0 VA: 0x1805D01E0
	public static bool op_Equality(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0x5D0260 Offset: 0x5CE860 VA: 0x1805D0260
	public static bool op_Inequality(servernetadr_t x, servernetadr_t y) { }

	// RVA: 0x5CFDB0 Offset: 0x5CE3B0 VA: 0x1805CFDB0
	public bool Equals(servernetadr_t other) { }

	// RVA: 0x5CFD40 Offset: 0x5CE340 VA: 0x1805CFD40
	public int CompareTo(servernetadr_t other) { }
}

// Namespace: Steamworks
[UnmanagedFunctionPointer(2)]
public sealed class SteamAPIWarningMessageHook_t : MulticastDelegate // TypeDefIndex: 10620
{
	// Methods

	// RVA: 0x593FB0 Offset: 0x5925B0 VA: 0x180593FB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(int nSeverity, StringBuilder pchDebugText) { }

	// RVA: 0x5C3A20 Offset: 0x5C2020 VA: 0x1805C3A20 Slot: 14
	public virtual IAsyncResult BeginInvoke(int nSeverity, StringBuilder pchDebugText, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Steamworks
[UnmanagedFunctionPointer(3)]
public sealed class SteamAPI_CheckCallbackRegistered_t : MulticastDelegate // TypeDefIndex: 10621
{
	// Methods

	// RVA: 0x5C3AF0 Offset: 0x5C20F0 VA: 0x1805C3AF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(int iCallbackNum) { }

	// RVA: 0x5C3A90 Offset: 0x5C2090 VA: 0x1805C3A90 Slot: 14
	public virtual IAsyncResult BeginInvoke(int iCallbackNum, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Steamworks
[Serializable]
public struct CGameID : IEquatable<CGameID>, IComparable<CGameID> // TypeDefIndex: 10623
{
	// Fields
	public ulong m_GameID; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong GameID) { }

	// RVA: 0x58E9E0 Offset: 0x58CFE0 VA: 0x18058E9E0
	public void .ctor(AppId_t nAppID) { }

	// RVA: 0x58E960 Offset: 0x58CF60 VA: 0x18058E960
	public void .ctor(AppId_t nAppID, uint nModID) { }

	// RVA: 0x58E6C0 Offset: 0x58CCC0 VA: 0x18058E6C0
	public bool IsSteamApp() { }

	// RVA: 0x58E690 Offset: 0x58CC90 VA: 0x18058E690
	public bool IsMod() { }

	// RVA: 0x58E6B0 Offset: 0x58CCB0 VA: 0x18058E6B0
	public bool IsShortcut() { }

	// RVA: 0x58E6A0 Offset: 0x58CCA0 VA: 0x18058E6A0
	public bool IsP2PFile() { }

	// RVA: 0x58E5C0 Offset: 0x58CBC0 VA: 0x18058E5C0
	public AppId_t AppID() { }

	// RVA: 0x58E950 Offset: 0x58CF50 VA: 0x18058E950
	public CGameID.EGameIDType Type() { }

	// RVA: 0x58E860 Offset: 0x58CE60 VA: 0x18058E860
	public uint ModID() { }

	// RVA: 0x58E6D0 Offset: 0x58CCD0 VA: 0x18058E6D0
	public bool IsValid() { }

	// RVA: 0x58E870 Offset: 0x58CE70 VA: 0x18058E870
	public void Reset() { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void Set(ulong GameID) { }

	// RVA: 0x58E880 Offset: 0x58CE80 VA: 0x18058E880
	private void SetAppID(AppId_t other) { }

	// RVA: 0x58E910 Offset: 0x58CF10 VA: 0x18058E910
	private void SetType(CGameID.EGameIDType other) { }

	// RVA: 0x58E8F0 Offset: 0x58CEF0 VA: 0x18058E8F0
	private void SetModID(uint other) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x58E5E0 Offset: 0x58CBE0 VA: 0x18058E5E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(CGameID x, CGameID y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(CGameID x, CGameID y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static CGameID op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(CGameID that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(CGameID other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(CGameID other) { }
}

// Namespace: Steamworks
[Serializable]
public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID> // TypeDefIndex: 10624
{
	// Fields
	public static readonly CSteamID Nil; // 0x0
	public static readonly CSteamID OutofDateGS; // 0x8
	public static readonly CSteamID LanModeGS; // 0x10
	public static readonly CSteamID NotInitYetGS; // 0x18
	public static readonly CSteamID NonSteamGS; // 0x20
	public ulong m_SteamID; // 0x0

	// Methods

	// RVA: 0x591850 Offset: 0x58FE50 VA: 0x180591850
	public void .ctor(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0x5917C0 Offset: 0x58FDC0 VA: 0x1805917C0
	public void .ctor(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong ulSteamID) { }

	// RVA: 0x591490 Offset: 0x58FA90 VA: 0x180591490
	public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0x591040 Offset: 0x58F640 VA: 0x180591040
	public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	// RVA: 0x58E870 Offset: 0x58CE70 VA: 0x18058E870
	public void Clear() { }

	// RVA: 0x590E20 Offset: 0x58F420 VA: 0x180590E20
	public void CreateBlankAnonLogon(EUniverse eUniverse) { }

	// RVA: 0x590EC0 Offset: 0x58F4C0 VA: 0x180590EC0
	public void CreateBlankAnonUserLogon(EUniverse eUniverse) { }

	// RVA: 0x590AC0 Offset: 0x58F0C0 VA: 0x180590AC0
	public bool BBlankAnonAccount() { }

	// RVA: 0x590CD0 Offset: 0x58F2D0 VA: 0x180590CD0
	public bool BGameServerAccount() { }

	// RVA: 0x590DD0 Offset: 0x58F3D0 VA: 0x180590DD0
	public bool BPersistentGameServerAccount() { }

	// RVA: 0x590A20 Offset: 0x58F020 VA: 0x180590A20
	public bool BAnonGameServerAccount() { }

	// RVA: 0x590C80 Offset: 0x58F280 VA: 0x180590C80
	public bool BContentServerAccount() { }

	// RVA: 0x590BE0 Offset: 0x58F1E0 VA: 0x180590BE0
	public bool BClanAccount() { }

	// RVA: 0x590B90 Offset: 0x58F190 VA: 0x180590B90
	public bool BChatAccount() { }

	// RVA: 0x591110 Offset: 0x58F710 VA: 0x180591110
	public bool IsLobby() { }

	// RVA: 0x590D50 Offset: 0x58F350 VA: 0x180590D50
	public bool BIndividualAccount() { }

	// RVA: 0x5909A0 Offset: 0x58EFA0 VA: 0x1805909A0
	public bool BAnonAccount() { }

	// RVA: 0x590A70 Offset: 0x58F070 VA: 0x180590A70
	public bool BAnonUserAccount() { }

	// RVA: 0x590C30 Offset: 0x58F230 VA: 0x180590C30
	public bool BConsoleUserAccount() { }

	// RVA: 0x5913C0 Offset: 0x58F9C0 VA: 0x1805913C0
	public void SetAccountID(AccountID_t other) { }

	// RVA: 0x591430 Offset: 0x58FA30 VA: 0x180591430
	public void SetAccountInstance(uint other) { }

	// RVA: 0x591450 Offset: 0x58FA50 VA: 0x180591450
	public void SetEAccountType(EAccountType other) { }

	// RVA: 0x591470 Offset: 0x58FA70 VA: 0x180591470
	public void SetEUniverse(EUniverse other) { }

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public AccountID_t GetAccountID() { }

	// RVA: 0x591030 Offset: 0x58F630 VA: 0x180591030
	public uint GetUnAccountInstance() { }

	// RVA: 0x591010 Offset: 0x58F610 VA: 0x180591010
	public EAccountType GetEAccountType() { }

	// RVA: 0x591020 Offset: 0x58F620 VA: 0x180591020
	public EUniverse GetEUniverse() { }

	// RVA: 0x591190 Offset: 0x58F790 VA: 0x180591190
	public bool IsValid() { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x590F60 Offset: 0x58F560 VA: 0x180590F60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(CSteamID x, CSteamID y) { }

	// RVA: 0x5918E0 Offset: 0x58FEE0 VA: 0x1805918E0
	public static bool op_Inequality(CSteamID x, CSteamID y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static CSteamID op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(CSteamID that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(CSteamID other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(CSteamID other) { }

	// RVA: 0x5915E0 Offset: 0x58FBE0 VA: 0x1805915E0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket> // TypeDefIndex: 10625
{
	// Fields
	public static readonly HAuthTicket Invalid; // 0x0
	public uint m_HAuthTicket; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x594F20 Offset: 0x593520 VA: 0x180594F20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HAuthTicket x, HAuthTicket y) { }

	// RVA: 0x595000 Offset: 0x593600 VA: 0x180595000
	public static bool op_Inequality(HAuthTicket x, HAuthTicket y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HAuthTicket op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(HAuthTicket that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HAuthTicket other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(HAuthTicket other) { }

	// RVA: 0x594FC0 Offset: 0x5935C0 VA: 0x180594FC0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamDatagramHostedAddress // TypeDefIndex: 10626
{
	// Fields
	public int m_cbSize; // 0x0
	public byte[] m_data; // 0x8

	// Methods

	// RVA: 0x5C47E0 Offset: 0x5C2DE0 VA: 0x1805C47E0
	public void Clear() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamDatagramRelayAuthTicket // TypeDefIndex: 10630
{
	// Fields
	private SteamNetworkingIdentity m_identityGameserver; // 0x0
	private SteamNetworkingIdentity m_identityAuthorizedClient; // 0x88
	private uint m_unPublicIP; // 0x110
	private RTime32 m_rtimeTicketExpiry; // 0x114
	private SteamDatagramHostedAddress m_routing; // 0x118
	private uint m_nAppID; // 0x128
	private int m_nRestrictToVirtualPort; // 0x12C
	private const int k_nMaxExtraFields = 16;
	private int m_nExtraFields; // 0x130
	private SteamDatagramRelayAuthTicket.ExtraField[] m_vecExtraFields; // 0x138

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Clear() { }
}

// Namespace: Steamworks
[Serializable]
public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t> // TypeDefIndex: 10631
{
	// Fields
	public static readonly FriendsGroupID_t Invalid; // 0x0
	public short m_FriendsGroupID; // 0x0

	// Methods

	// RVA: 0x594180 Offset: 0x592780 VA: 0x180594180
	public void .ctor(short value) { }

	// RVA: 0x594130 Offset: 0x592730 VA: 0x180594130 Slot: 3
	public override string ToString() { }

	// RVA: 0x594080 Offset: 0x592680 VA: 0x180594080 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x594120 Offset: 0x592720 VA: 0x180594120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x594190 Offset: 0x592790 VA: 0x180594190
	public static bool op_Equality(FriendsGroupID_t x, FriendsGroupID_t y) { }

	// RVA: 0x5941B0 Offset: 0x5927B0 VA: 0x1805941B0
	public static bool op_Inequality(FriendsGroupID_t x, FriendsGroupID_t y) { }

	// RVA: 0x5941A0 Offset: 0x5927A0 VA: 0x1805941A0
	public static FriendsGroupID_t op_Explicit(short value) { }

	// RVA: 0x5941A0 Offset: 0x5927A0 VA: 0x1805941A0
	public static short op_Explicit(FriendsGroupID_t that) { }

	// RVA: 0x594070 Offset: 0x592670 VA: 0x180594070 Slot: 4
	public bool Equals(FriendsGroupID_t other) { }

	// RVA: 0x594060 Offset: 0x592660 VA: 0x180594060 Slot: 5
	public int CompareTo(FriendsGroupID_t other) { }

	// RVA: 0x594140 Offset: 0x592740 VA: 0x180594140
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser> // TypeDefIndex: 10632
{
	// Fields
	public static readonly HHTMLBrowser Invalid; // 0x0
	public uint m_HHTMLBrowser; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x595050 Offset: 0x593650 VA: 0x180595050 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HHTMLBrowser x, HHTMLBrowser y) { }

	// RVA: 0x595130 Offset: 0x593730 VA: 0x180595130
	public static bool op_Inequality(HHTMLBrowser x, HHTMLBrowser y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HHTMLBrowser op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(HHTMLBrowser that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HHTMLBrowser other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(HHTMLBrowser other) { }

	// RVA: 0x5950F0 Offset: 0x5936F0 VA: 0x1805950F0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle> // TypeDefIndex: 10633
{
	// Fields
	public static readonly HTTPCookieContainerHandle Invalid; // 0x0
	public uint m_HTTPCookieContainerHandle; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5957B0 Offset: 0x593DB0 VA: 0x1805957B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y) { }

	// RVA: 0x595890 Offset: 0x593E90 VA: 0x180595890
	public static bool op_Inequality(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HTTPCookieContainerHandle op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(HTTPCookieContainerHandle that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HTTPCookieContainerHandle other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(HTTPCookieContainerHandle other) { }

	// RVA: 0x595850 Offset: 0x593E50 VA: 0x180595850
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle> // TypeDefIndex: 10634
{
	// Fields
	public static readonly HTTPRequestHandle Invalid; // 0x0
	public uint m_HTTPRequestHandle; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5958E0 Offset: 0x593EE0 VA: 0x1805958E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	// RVA: 0x5959C0 Offset: 0x593FC0 VA: 0x1805959C0
	public static bool op_Inequality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HTTPRequestHandle op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(HTTPRequestHandle that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HTTPRequestHandle other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(HTTPRequestHandle other) { }

	// RVA: 0x595980 Offset: 0x593F80 VA: 0x180595980
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t> // TypeDefIndex: 10635
{
	// Fields
	public ulong m_InputActionSetHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x597130 Offset: 0x595730 VA: 0x180597130 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(InputActionSetHandle_t x, InputActionSetHandle_t y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(InputActionSetHandle_t x, InputActionSetHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static InputActionSetHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(InputActionSetHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(InputActionSetHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(InputActionSetHandle_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>, IComparable<InputAnalogActionHandle_t> // TypeDefIndex: 10636
{
	// Fields
	public ulong m_InputAnalogActionHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5971C0 Offset: 0x5957C0 VA: 0x1805971C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static InputAnalogActionHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(InputAnalogActionHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(InputAnalogActionHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(InputAnalogActionHandle_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t> // TypeDefIndex: 10637
{
	// Fields
	public ulong m_InputDigitalActionHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x597250 Offset: 0x595850 VA: 0x180597250 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static InputDigitalActionHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(InputDigitalActionHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(InputDigitalActionHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(InputDigitalActionHandle_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t> // TypeDefIndex: 10638
{
	// Fields
	public ulong m_InputHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5972E0 Offset: 0x5958E0 VA: 0x1805972E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(InputHandle_t x, InputHandle_t y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(InputHandle_t x, InputHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static InputHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(InputHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(InputHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(InputHandle_t other) { }
}

// Namespace: Steamworks
[UnmanagedFunctionPointer(2)]
public sealed class SteamInputActionEventCallbackPointer : MulticastDelegate // TypeDefIndex: 10639
{
	// Methods

	// RVA: 0x597540 Offset: 0x595B40 VA: 0x180597540
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(IntPtr SteamInputActionEvent) { }

	// RVA: 0x5974E0 Offset: 0x595AE0 VA: 0x1805974E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr SteamInputActionEvent, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamInputActionEvent_t // TypeDefIndex: 10643
{
	// Fields
	public InputHandle_t controllerHandle; // 0x0
	public ESteamInputActionEventType eEventType; // 0x8
	public SteamInputActionEvent_t.OptionValue m_val; // 0x10
}

// Namespace: Steamworks
[Serializable]
public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t> // TypeDefIndex: 10644
{
	// Fields
	public static readonly SteamInventoryResult_t Invalid; // 0x0
	public int m_SteamInventoryResult; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(int value) { }

	// RVA: 0x595380 Offset: 0x593980 VA: 0x180595380 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C4A10 Offset: 0x5C3010 VA: 0x1805C4A10 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(SteamInventoryResult_t x, SteamInventoryResult_t y) { }

	// RVA: 0x5C4AF0 Offset: 0x5C30F0 VA: 0x1805C4AF0
	public static bool op_Inequality(SteamInventoryResult_t x, SteamInventoryResult_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static SteamInventoryResult_t op_Explicit(int value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static int op_Explicit(SteamInventoryResult_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(SteamInventoryResult_t other) { }

	// RVA: 0x5952D0 Offset: 0x5938D0 VA: 0x1805952D0 Slot: 5
	public int CompareTo(SteamInventoryResult_t other) { }

	// RVA: 0x5C4AB0 Offset: 0x5C30B0 VA: 0x1805C4AB0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t> // TypeDefIndex: 10645
{
	// Fields
	public static readonly SteamInventoryUpdateHandle_t Invalid; // 0x0
	public ulong m_SteamInventoryUpdateHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C4B40 Offset: 0x5C3140 VA: 0x1805C4B40 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	// RVA: 0x5C4C20 Offset: 0x5C3220 VA: 0x1805C4C20
	public static bool op_Inequality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static SteamInventoryUpdateHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(SteamInventoryUpdateHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(SteamInventoryUpdateHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(SteamInventoryUpdateHandle_t other) { }

	// RVA: 0x5C4BE0 Offset: 0x5C31E0 VA: 0x1805C4BE0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t> // TypeDefIndex: 10646
{
	// Fields
	public int m_SteamItemDef; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(int value) { }

	// RVA: 0x595380 Offset: 0x593980 VA: 0x180595380 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C4C80 Offset: 0x5C3280 VA: 0x1805C4C80 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(SteamItemDef_t x, SteamItemDef_t y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(SteamItemDef_t x, SteamItemDef_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static SteamItemDef_t op_Explicit(int value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static int op_Explicit(SteamItemDef_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(SteamItemDef_t other) { }

	// RVA: 0x5952D0 Offset: 0x5938D0 VA: 0x1805952D0 Slot: 5
	public int CompareTo(SteamItemDef_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t> // TypeDefIndex: 10647
{
	// Fields
	public static readonly SteamItemInstanceID_t Invalid; // 0x0
	public ulong m_SteamItemInstanceID; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C4D00 Offset: 0x5C3300 VA: 0x1805C4D00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	// RVA: 0x5C4DE0 Offset: 0x5C33E0 VA: 0x1805C4DE0
	public static bool op_Inequality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static SteamItemInstanceID_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(SteamItemInstanceID_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(SteamItemInstanceID_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(SteamItemInstanceID_t other) { }

	// RVA: 0x5C4DA0 Offset: 0x5C33A0 VA: 0x1805C4DA0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HServerListRequest : IEquatable<HServerListRequest> // TypeDefIndex: 10648
{
	// Fields
	public static readonly HServerListRequest Invalid; // 0x0
	public IntPtr m_HServerListRequest; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(IntPtr value) { }

	// RVA: 0x595220 Offset: 0x593820 VA: 0x180595220 Slot: 3
	public override string ToString() { }

	// RVA: 0x595180 Offset: 0x593780 VA: 0x180595180 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(HServerListRequest x, HServerListRequest y) { }

	// RVA: 0x595270 Offset: 0x593870 VA: 0x180595270
	public static bool op_Inequality(HServerListRequest x, HServerListRequest y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static HServerListRequest op_Explicit(IntPtr value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static IntPtr op_Explicit(HServerListRequest that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(HServerListRequest other) { }

	// RVA: 0x595230 Offset: 0x593830 VA: 0x180595230
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery> // TypeDefIndex: 10649
{
	// Fields
	public static readonly HServerQuery Invalid; // 0x0
	public int m_HServerQuery; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(int value) { }

	// RVA: 0x595380 Offset: 0x593980 VA: 0x180595380 Slot: 3
	public override string ToString() { }

	// RVA: 0x5952E0 Offset: 0x5938E0 VA: 0x1805952E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HServerQuery x, HServerQuery y) { }

	// RVA: 0x5953D0 Offset: 0x5939D0 VA: 0x1805953D0
	public static bool op_Inequality(HServerQuery x, HServerQuery y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HServerQuery op_Explicit(int value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static int op_Explicit(HServerQuery that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HServerQuery other) { }

	// RVA: 0x5952D0 Offset: 0x5938D0 VA: 0x1805952D0 Slot: 5
	public int CompareTo(HServerQuery other) { }

	// RVA: 0x595390 Offset: 0x593990 VA: 0x180595390
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t> // TypeDefIndex: 10650
{
	// Fields
	public uint m_SNetListenSocket; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C35C0 Offset: 0x5C1BC0 VA: 0x1805C35C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(SNetListenSocket_t x, SNetListenSocket_t y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(SNetListenSocket_t x, SNetListenSocket_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static SNetListenSocket_t op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(SNetListenSocket_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(SNetListenSocket_t other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(SNetListenSocket_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t> // TypeDefIndex: 10651
{
	// Fields
	public uint m_SNetSocket; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C3640 Offset: 0x5C1C40 VA: 0x1805C3640 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(SNetSocket_t x, SNetSocket_t y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(SNetSocket_t x, SNetSocket_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static SNetSocket_t op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(SNetSocket_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(SNetSocket_t other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(SNetSocket_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct ISteamNetworkingConnectionSignaling // TypeDefIndex: 10652
{
	// Methods

	// RVA: 0x596E40 Offset: 0x595440 VA: 0x180596E40
	public bool SendSignal(HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg) { }

	// RVA: 0x596DC0 Offset: 0x5953C0 VA: 0x180596DC0
	public void Release() { }
}

// Namespace: Steamworks
[Serializable]
public struct ISteamNetworkingSignalingRecvContext // TypeDefIndex: 10653
{
	// Methods

	// RVA: 0x596FE0 Offset: 0x5955E0 VA: 0x180596FE0
	public IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort) { }

	// RVA: 0x597080 Offset: 0x595680 VA: 0x180597080
	public void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg) { }
}

// Namespace: Steamworks
[UnmanagedFunctionPointer(2)]
public sealed class FSteamNetworkingSocketsDebugOutput : MulticastDelegate // TypeDefIndex: 10654
{
	// Methods

	// RVA: 0x593FB0 Offset: 0x5925B0 VA: 0x180593FB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg) { }

	// RVA: 0x593F10 Offset: 0x592510 VA: 0x180593F10 Slot: 14
	public virtual IAsyncResult BeginInvoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Steamworks
[Serializable]
public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket> // TypeDefIndex: 10655
{
	// Fields
	public static readonly HSteamListenSocket Invalid; // 0x0
	public uint m_HSteamListenSocket; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x595420 Offset: 0x593A20 VA: 0x180595420 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HSteamListenSocket x, HSteamListenSocket y) { }

	// RVA: 0x595500 Offset: 0x593B00 VA: 0x180595500
	public static bool op_Inequality(HSteamListenSocket x, HSteamListenSocket y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HSteamListenSocket op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(HSteamListenSocket that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HSteamListenSocket other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(HSteamListenSocket other) { }

	// RVA: 0x5954C0 Offset: 0x593AC0 VA: 0x1805954C0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection> // TypeDefIndex: 10656
{
	// Fields
	public static readonly HSteamNetConnection Invalid; // 0x0
	public uint m_HSteamNetConnection; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x595550 Offset: 0x593B50 VA: 0x180595550 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HSteamNetConnection x, HSteamNetConnection y) { }

	// RVA: 0x595630 Offset: 0x593C30 VA: 0x180595630
	public static bool op_Inequality(HSteamNetConnection x, HSteamNetConnection y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HSteamNetConnection op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(HSteamNetConnection that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HSteamNetConnection other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(HSteamNetConnection other) { }

	// RVA: 0x5955F0 Offset: 0x593BF0 VA: 0x1805955F0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup> // TypeDefIndex: 10657
{
	// Fields
	public static readonly HSteamNetPollGroup Invalid; // 0x0
	public uint m_HSteamNetPollGroup; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x595680 Offset: 0x593C80 VA: 0x180595680 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HSteamNetPollGroup x, HSteamNetPollGroup y) { }

	// RVA: 0x595760 Offset: 0x593D60 VA: 0x180595760
	public static bool op_Inequality(HSteamNetPollGroup x, HSteamNetPollGroup y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HSteamNetPollGroup op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(HSteamNetPollGroup that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HSteamNetPollGroup other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(HSteamNetPollGroup other) { }

	// RVA: 0x595720 Offset: 0x593D20 VA: 0x180595720
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamNetworkingConfigValue_t // TypeDefIndex: 10659
{
	// Fields
	public ESteamNetworkingConfigValue m_eValue; // 0x0
	public ESteamNetworkingConfigDataType m_eDataType; // 0x4
	public SteamNetworkingConfigValue_t.OptionValue m_val; // 0x8
}

// Namespace: Steamworks
[Serializable]
public struct SteamNetworkingErrMsg // TypeDefIndex: 10660
{
	// Fields
	public byte[] m_SteamNetworkingErrMsg; // 0x0
}

// Namespace: Steamworks
[Serializable]
public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity> // TypeDefIndex: 10661
{
	// Fields
	public ESteamNetworkingIdentityType m_eType; // 0x0
	private int m_cbSize; // 0x4
	private uint m_reserved0; // 0x8
	private uint m_reserved1; // 0xC
	private uint m_reserved2; // 0x10
	private uint m_reserved3; // 0x14
	private uint m_reserved4; // 0x18
	private uint m_reserved5; // 0x1C
	private uint m_reserved6; // 0x20
	private uint m_reserved7; // 0x24
	private uint m_reserved8; // 0x28
	private uint m_reserved9; // 0x2C
	private uint m_reserved10; // 0x30
	private uint m_reserved11; // 0x34
	private uint m_reserved12; // 0x38
	private uint m_reserved13; // 0x3C
	private uint m_reserved14; // 0x40
	private uint m_reserved15; // 0x44
	private uint m_reserved16; // 0x48
	private uint m_reserved17; // 0x4C
	private uint m_reserved18; // 0x50
	private uint m_reserved19; // 0x54
	private uint m_reserved20; // 0x58
	private uint m_reserved21; // 0x5C
	private uint m_reserved22; // 0x60
	private uint m_reserved23; // 0x64
	private uint m_reserved24; // 0x68
	private uint m_reserved25; // 0x6C
	private uint m_reserved26; // 0x70
	private uint m_reserved27; // 0x74
	private uint m_reserved28; // 0x78
	private uint m_reserved29; // 0x7C
	private uint m_reserved30; // 0x80
	private uint m_reserved31; // 0x84
	public const int k_cchMaxString = 128;
	public const int k_cchMaxGenericString = 32;
	public const int k_cchMaxXboxPairwiseID = 33;
	public const int k_cbMaxGenericBytes = 32;

	// Methods

	// RVA: 0x5C05A0 Offset: 0x5BEBA0 VA: 0x1805C05A0
	public void Clear() { }

	// RVA: 0x5C0C40 Offset: 0x5BF240 VA: 0x1805C0C40
	public bool IsInvalid() { }

	// RVA: 0x5C5980 Offset: 0x5C3F80 VA: 0x1805C5980
	public void SetSteamID(CSteamID steamID) { }

	// RVA: 0x5C53E0 Offset: 0x5C39E0 VA: 0x1805C53E0
	public CSteamID GetSteamID() { }

	// RVA: 0x5C12D0 Offset: 0x5BF8D0 VA: 0x1805C12D0
	public void SetSteamID64(ulong steamID) { }

	// RVA: 0x5C09B0 Offset: 0x5BEFB0 VA: 0x1805C09B0
	public ulong GetSteamID64() { }

	// RVA: 0x5C5A40 Offset: 0x5C4040 VA: 0x1805C5A40
	public bool SetXboxPairwiseID(string pszString) { }

	// RVA: 0x5C5490 Offset: 0x5C3A90 VA: 0x1805C5490
	public string GetXboxPairwiseID() { }

	// RVA: 0x5C11B0 Offset: 0x5BF7B0 VA: 0x1805C11B0
	public void SetPSNID(ulong id) { }

	// RVA: 0x5C08B0 Offset: 0x5BEEB0 VA: 0x1805C08B0
	public ulong GetPSNID() { }

	// RVA: 0x5C1240 Offset: 0x5BF840 VA: 0x1805C1240
	public void SetStadiaID(ulong id) { }

	// RVA: 0x5C0930 Offset: 0x5BEF30 VA: 0x1805C0930
	public ulong GetStadiaID() { }

	// RVA: 0x5C58A0 Offset: 0x5C3EA0 VA: 0x1805C58A0
	public void SetIPAddr(SteamNetworkingIPAddr addr) { }

	// RVA: 0x5C53A0 Offset: 0x5C39A0 VA: 0x1805C53A0
	public SteamNetworkingIPAddr GetIPAddr() { }

	// RVA: 0x5C1090 Offset: 0x5BF690 VA: 0x1805C1090
	public void SetIPv4Addr(uint nIPv4, ushort nPort) { }

	// RVA: 0x5C0830 Offset: 0x5BEE30 VA: 0x1805C0830
	public uint GetIPv4() { }

	// RVA: 0x5C0620 Offset: 0x5BEC20 VA: 0x1805C0620
	public ESteamNetworkingFakeIPType GetFakeIPType() { }

	// RVA: 0x5C5520 Offset: 0x5C3B20 VA: 0x1805C5520
	public bool IsFakeIP() { }

	// RVA: 0x5C1130 Offset: 0x5BF730 VA: 0x1805C1130
	public void SetLocalHost() { }

	// RVA: 0x5C0CC0 Offset: 0x5BF2C0 VA: 0x1805C0CC0
	public bool IsLocalHost() { }

	// RVA: 0x5C56F0 Offset: 0x5C3CF0 VA: 0x1805C56F0
	public bool SetGenericString(string pszString) { }

	// RVA: 0x5C5310 Offset: 0x5C3910 VA: 0x1805C5310
	public string GetGenericString() { }

	// RVA: 0x5C0E20 Offset: 0x5BF420 VA: 0x1805C0E20
	public bool SetGenericBytes(byte[] data, uint cbLen) { }

	// RVA: 0x5C52D0 Offset: 0x5C38D0 VA: 0x1805C52D0
	public byte[] GetGenericBytes(out int cbLen) { }

	// RVA: 0x5C0B30 Offset: 0x5BF130 VA: 0x1805C0B30 Slot: 4
	public bool Equals(SteamNetworkingIdentity x) { }

	// RVA: 0x5C5BF0 Offset: 0x5C41F0 VA: 0x1805C5BF0
	public void ToString(out string buf) { }

	// RVA: 0x5C5540 Offset: 0x5C3B40 VA: 0x1805C5540
	public bool ParseString(string pszStr) { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr> // TypeDefIndex: 10662
{
	// Fields
	public byte[] m_ipv6; // 0x0
	public ushort m_port; // 0x8
	public const int k_cchMaxString = 48;

	// Methods

	// RVA: 0x5BF950 Offset: 0x5BDF50 VA: 0x1805BF950
	public void Clear() { }

	// RVA: 0x5BFED0 Offset: 0x5BE4D0 VA: 0x1805BFED0
	public bool IsIPv6AllZeros() { }

	// RVA: 0x5C03B0 Offset: 0x5BE9B0 VA: 0x1805C03B0
	public void SetIPv6(byte[] ipv6, ushort nPort) { }

	// RVA: 0x5C01E0 Offset: 0x5BE7E0 VA: 0x1805C01E0
	public void SetIPv4(uint nIP, ushort nPort) { }

	// RVA: 0x5BFDF0 Offset: 0x5BE3F0 VA: 0x1805BFDF0
	public bool IsIPv4() { }

	// RVA: 0x5BFB00 Offset: 0x5BE100 VA: 0x1805BFB00
	public uint GetIPv4() { }

	// RVA: 0x5C02D0 Offset: 0x5BE8D0 VA: 0x1805C02D0
	public void SetIPv6LocalHost(ushort nPort = 0) { }

	// RVA: 0x5BFFB0 Offset: 0x5BE5B0 VA: 0x1805BFFB0
	public bool IsLocalHost() { }

	// RVA: 0x5C5170 Offset: 0x5C3770 VA: 0x1805C5170
	public void ToString(out string buf, bool bWithPort) { }

	// RVA: 0x5C4F60 Offset: 0x5C3560 VA: 0x1805C4F60
	public bool ParseString(string pszStr) { }

	// RVA: 0x5BFBE0 Offset: 0x5BE1E0 VA: 0x1805BFBE0 Slot: 4
	public bool Equals(SteamNetworkingIPAddr x) { }

	// RVA: 0x5BFA20 Offset: 0x5BE020 VA: 0x1805BFA20
	public ESteamNetworkingFakeIPType GetFakeIPType() { }

	// RVA: 0x5C4F40 Offset: 0x5C3540 VA: 0x1805C4F40
	public bool IsFakeIP() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamNetworkingMessage_t // TypeDefIndex: 10663
{
	// Fields
	public IntPtr m_pData; // 0x0
	public int m_cbSize; // 0x8
	public HSteamNetConnection m_conn; // 0xC
	public SteamNetworkingIdentity m_identityPeer; // 0x10
	public long m_nConnUserData; // 0x98
	public SteamNetworkingMicroseconds m_usecTimeReceived; // 0xA0
	public long m_nMessageNumber; // 0xA8
	public IntPtr m_pfnFreeData; // 0xB0
	internal IntPtr m_pfnRelease; // 0xB8
	public int m_nChannel; // 0xC0
	public int m_nFlags; // 0xC4
	public long m_nUserData; // 0xC8
	public ushort m_idxLane; // 0xD0
	public ushort _pad1__; // 0xD2

	// Methods

	// RVA: 0x5C5E50 Offset: 0x5C4450 VA: 0x1805C5E50
	public void Release() { }

	// RVA: 0x5C1570 Offset: 0x5BFB70 VA: 0x1805C1570
	public static void Release(IntPtr pointer) { }

	// RVA: 0x5C5CF0 Offset: 0x5C42F0 VA: 0x1805C5CF0
	public static SteamNetworkingMessage_t FromIntPtr(IntPtr pointer) { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamNetworkingMicroseconds : IEquatable<SteamNetworkingMicroseconds>, IComparable<SteamNetworkingMicroseconds> // TypeDefIndex: 10664
{
	// Fields
	public long m_SteamNetworkingMicroseconds; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(long value) { }

	// RVA: 0x5C5F50 Offset: 0x5C4550 VA: 0x1805C5F50 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C5EB0 Offset: 0x5C44B0 VA: 0x1805C5EB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x5C5F40 Offset: 0x5C4540 VA: 0x1805C5F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static SteamNetworkingMicroseconds op_Explicit(long value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static long op_Explicit(SteamNetworkingMicroseconds that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(SteamNetworkingMicroseconds other) { }

	// RVA: 0x5C5EA0 Offset: 0x5C44A0 VA: 0x1805C5EA0 Slot: 5
	public int CompareTo(SteamNetworkingMicroseconds other) { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID> // TypeDefIndex: 10665
{
	// Fields
	public uint m_SteamNetworkingPOPID; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C5F60 Offset: 0x5C4560 VA: 0x1805C5F60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static SteamNetworkingPOPID op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(SteamNetworkingPOPID that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(SteamNetworkingPOPID other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(SteamNetworkingPOPID other) { }
}

// Namespace: Steamworks
[Serializable]
public struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t> // TypeDefIndex: 10666
{
	// Fields
	public uint m_RemotePlaySessionID; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C2F70 Offset: 0x5C1570 VA: 0x1805C2F70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(RemotePlaySessionID_t x, RemotePlaySessionID_t y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(RemotePlaySessionID_t x, RemotePlaySessionID_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static RemotePlaySessionID_t op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(RemotePlaySessionID_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(RemotePlaySessionID_t other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(RemotePlaySessionID_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t> // TypeDefIndex: 10667
{
	// Fields
	public static readonly PublishedFileId_t Invalid; // 0x0
	public ulong m_PublishedFileId; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C2BA0 Offset: 0x5C11A0 VA: 0x1805C2BA0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(PublishedFileId_t x, PublishedFileId_t y) { }

	// RVA: 0x5C2C80 Offset: 0x5C1280 VA: 0x1805C2C80
	public static bool op_Inequality(PublishedFileId_t x, PublishedFileId_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static PublishedFileId_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(PublishedFileId_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(PublishedFileId_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(PublishedFileId_t other) { }

	// RVA: 0x5C2C40 Offset: 0x5C1240 VA: 0x1805C2C40
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t> // TypeDefIndex: 10668
{
	// Fields
	public static readonly PublishedFileUpdateHandle_t Invalid; // 0x0
	public ulong m_PublishedFileUpdateHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C2CE0 Offset: 0x5C12E0 VA: 0x1805C2CE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y) { }

	// RVA: 0x5C2DC0 Offset: 0x5C13C0 VA: 0x1805C2DC0
	public static bool op_Inequality(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static PublishedFileUpdateHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(PublishedFileUpdateHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(PublishedFileUpdateHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(PublishedFileUpdateHandle_t other) { }

	// RVA: 0x5C2D80 Offset: 0x5C1380 VA: 0x1805C2D80
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t> // TypeDefIndex: 10669
{
	// Fields
	public static readonly UGCFileWriteStreamHandle_t Invalid; // 0x0
	public ulong m_UGCFileWriteStreamHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5CF2E0 Offset: 0x5CD8E0 VA: 0x1805CF2E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y) { }

	// RVA: 0x5CF3C0 Offset: 0x5CD9C0 VA: 0x1805CF3C0
	public static bool op_Inequality(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static UGCFileWriteStreamHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(UGCFileWriteStreamHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(UGCFileWriteStreamHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(UGCFileWriteStreamHandle_t other) { }

	// RVA: 0x5CF380 Offset: 0x5CD980 VA: 0x1805CF380
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t> // TypeDefIndex: 10670
{
	// Fields
	public static readonly UGCHandle_t Invalid; // 0x0
	public ulong m_UGCHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5CF420 Offset: 0x5CDA20 VA: 0x1805CF420 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(UGCHandle_t x, UGCHandle_t y) { }

	// RVA: 0x5CF500 Offset: 0x5CDB00 VA: 0x1805CF500
	public static bool op_Inequality(UGCHandle_t x, UGCHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static UGCHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(UGCHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(UGCHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(UGCHandle_t other) { }

	// RVA: 0x5CF4C0 Offset: 0x5CDAC0 VA: 0x1805CF4C0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle> // TypeDefIndex: 10671
{
	// Fields
	public static readonly ScreenshotHandle Invalid; // 0x0
	public uint m_ScreenshotHandle; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C36C0 Offset: 0x5C1CC0 VA: 0x1805C36C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(ScreenshotHandle x, ScreenshotHandle y) { }

	// RVA: 0x5C37A0 Offset: 0x5C1DA0 VA: 0x1805C37A0
	public static bool op_Inequality(ScreenshotHandle x, ScreenshotHandle y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static ScreenshotHandle op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(ScreenshotHandle that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(ScreenshotHandle other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(ScreenshotHandle other) { }

	// RVA: 0x5C3760 Offset: 0x5C1D60 VA: 0x1805C3760
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t> // TypeDefIndex: 10672
{
	// Fields
	public static readonly AccountID_t Invalid; // 0x0
	public uint m_AccountID; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x58E080 Offset: 0x58C680 VA: 0x18058E080 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(AccountID_t x, AccountID_t y) { }

	// RVA: 0x58E1C0 Offset: 0x58C7C0 VA: 0x18058E1C0
	public static bool op_Inequality(AccountID_t x, AccountID_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static AccountID_t op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(AccountID_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(AccountID_t other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(AccountID_t other) { }

	// RVA: 0x58E150 Offset: 0x58C750 VA: 0x18058E150
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t> // TypeDefIndex: 10673
{
	// Fields
	public static readonly AppId_t Invalid; // 0x0
	public uint m_AppId; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x58E360 Offset: 0x58C960 VA: 0x18058E360 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(AppId_t x, AppId_t y) { }

	// RVA: 0x58E440 Offset: 0x58CA40 VA: 0x18058E440
	public static bool op_Inequality(AppId_t x, AppId_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static AppId_t op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(AppId_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(AppId_t other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(AppId_t other) { }

	// RVA: 0x58E400 Offset: 0x58CA00 VA: 0x18058E400
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t> // TypeDefIndex: 10674
{
	// Fields
	public static readonly DepotId_t Invalid; // 0x0
	public uint m_DepotId; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x593DE0 Offset: 0x5923E0 VA: 0x180593DE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(DepotId_t x, DepotId_t y) { }

	// RVA: 0x593EC0 Offset: 0x5924C0 VA: 0x180593EC0
	public static bool op_Inequality(DepotId_t x, DepotId_t y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static DepotId_t op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(DepotId_t that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(DepotId_t other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(DepotId_t other) { }

	// RVA: 0x593E80 Offset: 0x592480 VA: 0x180593E80
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t> // TypeDefIndex: 10675
{
	// Fields
	public static readonly PartyBeaconID_t Invalid; // 0x0
	public ulong m_PartyBeaconID; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C2A60 Offset: 0x5C1060 VA: 0x1805C2A60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	// RVA: 0x5C2B40 Offset: 0x5C1140 VA: 0x1805C2B40
	public static bool op_Inequality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static PartyBeaconID_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(PartyBeaconID_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(PartyBeaconID_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(PartyBeaconID_t other) { }

	// RVA: 0x5C2B00 Offset: 0x5C1100 VA: 0x1805C2B00
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct RTime32 : IEquatable<RTime32>, IComparable<RTime32> // TypeDefIndex: 10676
{
	// Fields
	public uint m_RTime32; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint value) { }

	// RVA: 0x58E140 Offset: 0x58C740 VA: 0x18058E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D03E0 Offset: 0x5CE9E0 VA: 0x1805D03E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(RTime32 x, RTime32 y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(RTime32 x, RTime32 y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static RTime32 op_Explicit(uint value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Explicit(RTime32 that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(RTime32 other) { }

	// RVA: 0x58E070 Offset: 0x58C670 VA: 0x18058E070 Slot: 5
	public int CompareTo(RTime32 other) { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t> // TypeDefIndex: 10677
{
	// Fields
	public static readonly SteamAPICall_t Invalid; // 0x0
	public ulong m_SteamAPICall; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D0460 Offset: 0x5CEA60 VA: 0x1805D0460 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(SteamAPICall_t x, SteamAPICall_t y) { }

	// RVA: 0x5D0540 Offset: 0x5CEB40 VA: 0x1805D0540
	public static bool op_Inequality(SteamAPICall_t x, SteamAPICall_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static SteamAPICall_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(SteamAPICall_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(SteamAPICall_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(SteamAPICall_t other) { }

	// RVA: 0x5D0500 Offset: 0x5CEB00 VA: 0x1805D0500
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamIPAddress_t // TypeDefIndex: 10678
{
	// Fields
	private long m_ip0; // 0x0
	private long m_ip1; // 0x8
	private ESteamIPType m_eType; // 0x10

	// Methods

	// RVA: 0x5D0750 Offset: 0x5CED50 VA: 0x1805D0750
	public void .ctor(IPAddress iPAddress) { }

	// RVA: 0x5D05C0 Offset: 0x5CEBC0 VA: 0x1805D05C0
	public IPAddress ToIPAddress() { }

	// RVA: 0x5D0710 Offset: 0x5CED10 VA: 0x1805D0710 Slot: 3
	public override string ToString() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ESteamIPType GetIPType() { }

	// RVA: 0x5D05A0 Offset: 0x5CEBA0 VA: 0x1805D05A0
	public bool IsSet() { }
}

// Namespace: Steamworks
[Serializable]
public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t> // TypeDefIndex: 10679
{
	// Fields
	public static readonly UGCQueryHandle_t Invalid; // 0x0
	public ulong m_UGCQueryHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D0BD0 Offset: 0x5CF1D0 VA: 0x1805D0BD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	// RVA: 0x5D0CB0 Offset: 0x5CF2B0 VA: 0x1805D0CB0
	public static bool op_Inequality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static UGCQueryHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(UGCQueryHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(UGCQueryHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(UGCQueryHandle_t other) { }

	// RVA: 0x5D0C70 Offset: 0x5CF270 VA: 0x1805D0C70
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t> // TypeDefIndex: 10680
{
	// Fields
	public static readonly UGCUpdateHandle_t Invalid; // 0x0
	public ulong m_UGCUpdateHandle; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D0D10 Offset: 0x5CF310 VA: 0x1805D0D10 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	// RVA: 0x5D0DF0 Offset: 0x5CF3F0 VA: 0x1805D0DF0
	public static bool op_Inequality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static UGCUpdateHandle_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(UGCUpdateHandle_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(UGCUpdateHandle_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(UGCUpdateHandle_t other) { }

	// RVA: 0x5D0DB0 Offset: 0x5CF3B0 VA: 0x1805D0DB0
	private static void .cctor() { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t> // TypeDefIndex: 10681
{
	// Fields
	public ulong m_SteamLeaderboardEntries; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D0AB0 Offset: 0x5CF0B0 VA: 0x1805D0AB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static SteamLeaderboardEntries_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(SteamLeaderboardEntries_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(SteamLeaderboardEntries_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(SteamLeaderboardEntries_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t> // TypeDefIndex: 10682
{
	// Fields
	public ulong m_SteamLeaderboard; // 0x0

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(ulong value) { }

	// RVA: 0x58E940 Offset: 0x58CF40 VA: 0x18058E940 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D0B40 Offset: 0x5CF140 VA: 0x1805D0B40 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E680 Offset: 0x58CC80 VA: 0x18058E680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static SteamLeaderboard_t op_Explicit(ulong value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static ulong op_Explicit(SteamLeaderboard_t that) { }

	// RVA: 0x58E670 Offset: 0x58CC70 VA: 0x18058E670 Slot: 4
	public bool Equals(SteamLeaderboard_t other) { }

	// RVA: 0x58E5D0 Offset: 0x58CBD0 VA: 0x18058E5D0 Slot: 5
	public int CompareTo(SteamLeaderboard_t other) { }
}

// Namespace: Steamworks
[Serializable]
public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe> // TypeDefIndex: 10683
{
	// Fields
	public int m_HSteamPipe; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(int value) { }

	// RVA: 0x595380 Offset: 0x593980 VA: 0x180595380 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D02E0 Offset: 0x5CE8E0 VA: 0x1805D02E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HSteamPipe x, HSteamPipe y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(HSteamPipe x, HSteamPipe y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HSteamPipe op_Explicit(int value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static int op_Explicit(HSteamPipe that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HSteamPipe other) { }

	// RVA: 0x5952D0 Offset: 0x5938D0 VA: 0x1805952D0 Slot: 5
	public int CompareTo(HSteamPipe other) { }
}

// Namespace: Steamworks
[Serializable]
public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser> // TypeDefIndex: 10684
{
	// Fields
	public int m_HSteamUser; // 0x0

	// Methods

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(int value) { }

	// RVA: 0x595380 Offset: 0x593980 VA: 0x180595380 Slot: 3
	public override string ToString() { }

	// RVA: 0x5D0360 Offset: 0x5CE960 VA: 0x1805D0360 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(HSteamUser x, HSteamUser y) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(HSteamUser x, HSteamUser y) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static HSteamUser op_Explicit(int value) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static int op_Explicit(HSteamUser that) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(HSteamUser other) { }

	// RVA: 0x5952D0 Offset: 0x5938D0 VA: 0x1805952D0 Slot: 5
	public int CompareTo(HSteamUser other) { }
}

// Namespace: Steamworks
public static class Version // TypeDefIndex: 10685
{
	// Fields
	public const string SteamworksNETVersion = "2024.8.0";
	public const string SteamworksSDKVersion = "1.60";
	public const string SteamAPIDLLVersion = "08.97.99.70";
	public const int SteamAPIDLLSize = 265064;
	public const int SteamAPI64DLLSize = 300392;
}

