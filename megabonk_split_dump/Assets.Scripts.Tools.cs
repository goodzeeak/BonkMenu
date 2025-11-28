// Namespace: Assets.Scripts.Tools
public class AchievementGenerator : MonoBehaviour // TypeDefIndex: 5379
{
	// Fields
	public LocalizedString stageBossLocalizedKey; // 0x20
	public LocalizedString tierLocalizedKey; // 0x28
	public LocalizedString finalBossLocalizedKey; // 0x30
	public LocalizedString rankLocalizedKey; // 0x38
	public LocalizedString localizedKills; // 0x40
	public LocalizedString localizedLevel; // 0x48
	public LocalizedString localizedFinalBoss; // 0x50
	public LocalizedString localizedSpeedrun; // 0x58
	public LocalizedString localizedGold; // 0x60
	public DataManager dataManager; // 0x68
	private static Dictionary<ValueTuple<ECharacter, ESkinType>, string> skinAchievementNameCache; // 0x0

	// Methods

	// RVA: 0x3B3380 Offset: 0x3B1980 VA: 0x1803B3380
	private string GetPath() { }

	// RVA: 0x3B3580 Offset: 0x3B1B80 VA: 0x1803B3580
	public static int GetSkinAchValue(ESkinType skinType) { }

	// RVA: 0x3B33B0 Offset: 0x3B19B0 VA: 0x1803B33B0
	private string GetSkinAchValueStat(ESkinType skinType, ECharacter character) { }

	// RVA: 0x3B2FE0 Offset: 0x3B15E0 VA: 0x1803B2FE0
	private LocalizedString GetLocalizedDescription(ESkinType skinType) { }

	// RVA: 0x3B3030 Offset: 0x3B1630 VA: 0x1803B3030
	private List<LocalizationKey> GetLocalizedKeys(ESkinType skinType, CharacterData characterData) { }

	// RVA: 0x3B35E0 Offset: 0x3B1BE0 VA: 0x1803B35E0
	public static string GetSkinAchievementName(ECharacter character, ESkinType skinType) { }

	// RVA: 0x3B3840 Offset: 0x3B1E40 VA: 0x1803B3840
	private static EAchievementDifficulty GetSkinDifficulty(ESkinType skinType) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	// RVA: 0x3B3860 Offset: 0x3B1E60 VA: 0x1803B3860
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Tools
[Flags]
public enum EPotatoFlags // TypeDefIndex: 5380
{
	// Fields
	public int value__; // 0x0
	public const EPotatoFlags None = 0;
	public const EPotatoFlags Collision = 1;
	public const EPotatoFlags Kills = 2;
	public const EPotatoFlags Gold = 4;
	public const EPotatoFlags Hp = 8;
	public const EPotatoFlags Damage = 16;
	public const EPotatoFlags KillsPerMinute = 32;
	public const EPotatoFlags HpTamper = 64;
}

// Namespace: Assets.Scripts.Tools
public static class Potato // TypeDefIndex: 5381
{
	// Fields
	private static float lastCollisionTime; // 0x0
	private static float noCollisionTimeThreshold; // 0x4
	public static EPotatoFlags flags; // 0x8
	public static float totalDamageDone; // 0xC
	public static float dmgMin1; // 0x10
	public static float dmgMin2; // 0x14
	public static float dmgMin5; // 0x18
	public static float dmgMin10; // 0x1C
	private static float dmgMin1Max; // 0x20
	private static float dmgMin2Max; // 0x24
	private static float dmgMin5Max; // 0x28
	private static int totalKills; // 0x2C
	public static int killsMinute1; // 0x30
	public static int killsMinute2; // 0x34
	public static int killsMinute5; // 0x38
	public static int killsMinute10; // 0x3C
	private static int maxKillsMinute1; // 0x40
	private static int maxKillsMinute2; // 0x44
	private static int maxKillsMinute5; // 0x48
	private static int maxKillsMinute10; // 0x4C
	public static int enemyCollisionCalls; // 0x50
	public static int playerDamageCalls; // 0x54
	public static int damageBlocksCount; // 0x58
	public static int damageTakenCount; // 0x5C
	public static int totalDamageTaken; // 0x60
	private static int lastKillCount; // 0x64
	private static int lastGoldCount; // 0x68
	private static bool isRunning; // 0x6C
	private static float nextCheckTime; // 0x70

	// Methods

	// RVA: 0x3C67A0 Offset: 0x3C4DA0 VA: 0x1803C67A0
	public static void Init() { }

	// RVA: 0x3C5EE0 Offset: 0x3C44E0 VA: 0x1803C5EE0
	public static void Cleanup() { }

	// RVA: 0x3C7820 Offset: 0x3C5E20 VA: 0x1803C7820
	private static void OnRunStarted() { }

	// RVA: 0x3C77D0 Offset: 0x3C5DD0 VA: 0x1803C77D0
	private static void OnRunOver() { }

	// RVA: 0x3C7780 Offset: 0x3C5D80 VA: 0x1803C7780
	private static void OnRunEnded() { }

	// RVA: 0x3C76D0 Offset: 0x3C5CD0 VA: 0x1803C76D0
	private static void OnPlayerCollided() { }

	// RVA: 0x3C79D0 Offset: 0x3C5FD0 VA: 0x1803C79D0
	public static void Update() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void TestInput() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void CheckCollision() { }

	// RVA: 0x3C8640 Offset: 0x3C6C40 VA: 0x1803C8640
	private static void VerifyKillCount() { }

	// RVA: 0x3C7F50 Offset: 0x3C6550 VA: 0x1803C7F50
	private static void VerifyGold() { }

	// RVA: 0x3C80F0 Offset: 0x3C66F0 VA: 0x1803C80F0
	private static void VerifyHp() { }

	// RVA: 0x3C72B0 Offset: 0x3C58B0 VA: 0x1803C72B0
	private static void OnEnemyDamaged(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x3C8250 Offset: 0x3C6850 VA: 0x1803C8250
	private static void VerifyKillCountPerMinute() { }

	// RVA: 0x3C7650 Offset: 0x3C5C50 VA: 0x1803C7650
	private static void OnHpTamper() { }

	// RVA: 0x3C7250 Offset: 0x3C5850 VA: 0x1803C7250
	private static void OnEnemyCollision() { }

	// RVA: 0x3C7120 Offset: 0x3C5720 VA: 0x1803C7120
	private static void OnDamageCalled() { }

	// RVA: 0x3C7180 Offset: 0x3C5780 VA: 0x1803C7180
	private static void OnDamageStopped() { }

	// RVA: 0x3C71E0 Offset: 0x3C57E0 VA: 0x1803C71E0
	private static void OnDamageTaken(PlayerHealth arg1, DamageContainer arg2, bool arg3) { }

	// RVA: 0x3C7060 Offset: 0x3C5660 VA: 0x1803C7060
	private static void MarkPotato(EPotatoFlags flag, string message) { }

	// RVA: 0x3C87A0 Offset: 0x3C6DA0 VA: 0x1803C87A0
	private static void .cctor() { }
}

