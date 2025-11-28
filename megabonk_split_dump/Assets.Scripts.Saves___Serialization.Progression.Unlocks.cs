// Namespace: Assets.Scripts.Saves___Serialization.Progression.Unlocks
public static class MyAchievements // TypeDefIndex: 5427
{
	// Fields
	public static bool testUnlockEverything; // 0x0
	private static bool hasUnsavedChanges; // 0x1
	public static Action<MyAchievement> A_Unlocked; // 0x8
	public static Action<string> A_TryUnlock; // 0x10
	private static Dictionary<string, List<MyAchievement>> statTrackers; // 0x18
	private static bool startedTracking; // 0x20
	public static int fakeCharacters; // 0x24
	public static int fakeWeapons; // 0x28
	public static int fakeItems; // 0x2C
	public static int fakeMaps; // 0x30
	public static int fakeTomes; // 0x34
	public static int fakeAchievements; // 0x38
	private static HashSet<MyStat> queuedStatNames; // 0x40
	private static float statTrackersCooldown; // 0x48
	private static float nextStatTrackersCheck; // 0x4C
	private static float nextSaveTimeReady; // 0x50
	private static float saveCooldown; // 0x54

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool IsTestUnlockEverything() { }

	// RVA: 0x3E21C0 Offset: 0x3E07C0 VA: 0x1803E21C0
	public static void Init() { }

	// RVA: 0x3E18F0 Offset: 0x3DFEF0 VA: 0x1803E18F0
	public static void Cleanup() { }

	// RVA: 0x3E3870 Offset: 0x3E1E70 VA: 0x1803E3870
	private static void TryStartStatTracking() { }

	// RVA: 0x3E3D40 Offset: 0x3E2340 VA: 0x1803E3D40
	public static bool TryUnlock(string unlockName) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	private static bool AreAchievementsDisabled() { }

	// RVA: 0x3E3790 Offset: 0x3E1D90 VA: 0x1803E3790
	private static void OnStatUpdated(string statName, MyStat stat) { }

	// RVA: 0x3E3F80 Offset: 0x3E2580 VA: 0x1803E3F80
	public static void Update() { }

	// RVA: 0x3E2720 Offset: 0x3E0D20 VA: 0x1803E2720
	public static bool IsAchievementDone(string achName) { }

	// RVA: 0x3E17C0 Offset: 0x3DFDC0 VA: 0x1803E17C0
	public static bool CheckAchievementValue(string achievementName, int value) { }

	// RVA: 0x3E1E80 Offset: 0x3E0480 VA: 0x1803E1E80
	public static int GetAchievementTargetValue(string achName) { }

	// RVA: 0x3E1E20 Offset: 0x3E0420 VA: 0x1803E1E20
	public static float GetAchievementTargetValueFloat(string achName) { }

	// RVA: 0x3E2DD0 Offset: 0x3E13D0 VA: 0x1803E2DD0
	public static bool IsUnlocked(UnlockableBase unlockable, out string requirementsString) { }

	// RVA: 0x3E2D20 Offset: 0x3E1320 VA: 0x1803E2D20
	public static bool IsUnlocked(MyAchievement myAchievement) { }

	// RVA: 0x3E2CD0 Offset: 0x3E12D0 VA: 0x1803E2CD0
	public static bool IsUnlockedInternalNameAch(string achName) { }

	// RVA: 0x3E3300 Offset: 0x3E1900 VA: 0x1803E3300
	private static bool IsUnlocked(string unlockName) { }

	// RVA: 0x3E2BA0 Offset: 0x3E11A0 VA: 0x1803E2BA0
	public static bool IsPurchased(UnlockableBase unlockable) { }

	// RVA: 0x3E2990 Offset: 0x3E0F90 VA: 0x1803E2990
	public static bool IsAvailable(UnlockableBase unlockable) { }

	// RVA: 0x3E2800 Offset: 0x3E0E00 VA: 0x1803E2800
	public static bool IsActivated(UnlockableBase unlockable) { }

	// RVA: 0x3E15E0 Offset: 0x3DFBE0 VA: 0x1803E15E0
	public static bool CanToggleActivation(UnlockableBase unlockable) { }

	// RVA: 0x3E3740 Offset: 0x3E1D40 VA: 0x1803E3740
	private static void OnProgressionSaved() { }

	// RVA: 0x3E3700 Offset: 0x3E1D00 VA: 0x1803E3700
	private static void OnProgressionLoaded() { }

	// RVA: 0x3E3580 Offset: 0x3E1B80 VA: 0x1803E3580
	private static void OnDataLoaded() { }

	// RVA: 0x3E35C0 Offset: 0x3E1BC0 VA: 0x1803E35C0
	private static void OnPause(bool paused) { }

	// RVA: 0x3E33E0 Offset: 0x3E19E0 VA: 0x1803E33E0
	public static int NumCompletedAchievements() { }

	// RVA: 0x3E3490 Offset: 0x3E1A90 VA: 0x1803E3490
	public static int NumTotalAchievements() { }

	// RVA: 0x3E1410 Offset: 0x3DFA10 VA: 0x1803E1410
	public static bool AreAllQuestsCompleted() { }

	// RVA: 0x3E1EE0 Offset: 0x3E04E0 VA: 0x1803E1EE0
	public static void GetAchievementTypeProgress(EAchievementType achievementType, out int completed, out int total, out int unclaimed) { }

	// RVA: 0x3E45D0 Offset: 0x3E2BD0 VA: 0x1803E45D0
	private static void .cctor() { }
}

