// Namespace: Assets.Scripts.Saves___Serialization.Progression.Challenges
public class ChallengesTracker // TypeDefIndex: 5424
{
	// Fields
	public const string MODIFIER_NO_MOVEMENT = "no_movement";
	public const string MODIFIER_NO_ITEMS = "no_items";
	public const string MODIFIER_NO_WEAPONS = "no_weapons";
	private static ChallengeWinCondition winCondition; // 0x0
	public static ChallengeModifier[] challengeModifiers; // 0x8
	private static HashSet<string> modifierNames; // 0x10
	public const float silverAddPerChallenge = 0.01;
	private static bool victory; // 0x18
	public static Action<ChallengeData> A_ChallengeCompleted; // 0x20

	// Methods

	// RVA: 0x3D9380 Offset: 0x3D7980 VA: 0x1803D9380
	public static void Init() { }

	// RVA: 0x3D8BF0 Offset: 0x3D71F0 VA: 0x1803D8BF0
	public static void Cleanup() { }

	// RVA: 0x3D9F10 Offset: 0x3D8510 VA: 0x1803D9F10
	private static void OnNewRunStarted() { }

	// RVA: 0x3DA800 Offset: 0x3D8E00 VA: 0x1803DA800
	public static void Tick() { }

	// RVA: 0x3D8A10 Offset: 0x3D7010 VA: 0x1803D8A10
	private static void CleanupChallengeModifiers() { }

	// RVA: 0x3D9040 Offset: 0x3D7640 VA: 0x1803D9040
	public static void CompleteChallenge() { }

	// RVA: 0x3D9200 Offset: 0x3D7800 VA: 0x1803D9200
	public static bool HasChallengeModifier(string internalName) { }

	// RVA: 0x3D9190 Offset: 0x3D7790 VA: 0x1803D9190
	public static List<string> GetChallengeModifiers() { }

	// RVA: 0x3D99B0 Offset: 0x3D7FB0 VA: 0x1803D99B0
	private static void OnInventoryInitialized(PlayerInventory pinv) { }

	// RVA: 0x3D9280 Offset: 0x3D7880 VA: 0x1803D9280
	public static bool HasChallenge() { }

	// RVA: 0x3D97A0 Offset: 0x3D7DA0 VA: 0x1803D97A0
	private static void OnGameOver() { }

	// RVA: 0x3DA470 Offset: 0x3D8A70 VA: 0x1803DA470
	private static void OnStagebossDefeated() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3DA900 Offset: 0x3D8F00 VA: 0x1803DA900
	private static void .cctor() { }
}

