// Namespace: Assets.Scripts.Utility
public static class ChatUtility // TypeDefIndex: 5335
{
	// Fields
	private static Regex richRegex; // 0x0
	private static int maxNameLength; // 0x8

	// Methods

	// RVA: 0x3B5340 Offset: 0x3B3940 VA: 0x1803B5340
	public static string SanitizePlayerName(string name) { }

	// RVA: 0x3B55A0 Offset: 0x3B3BA0 VA: 0x1803B55A0
	public static string SanitizeString(string input) { }

	// RVA: 0x3B5280 Offset: 0x3B3880 VA: 0x1803B5280
	public static string RemoveRichEmbedding(string text) { }

	// RVA: 0x3B5630 Offset: 0x3B3C30 VA: 0x1803B5630
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Utility
public class CustomInput // TypeDefIndex: 5336
{
	// Methods

	// RVA: 0x3B5E00 Offset: 0x3B4400 VA: 0x1803B5E00
	public static bool CheckInputDown(int[] keyCodes) { }

	// RVA: 0x3B5ED0 Offset: 0x3B44D0 VA: 0x1803B5ED0
	public static bool CheckInputUp(int[] keyCodes) { }

	// RVA: 0x3B5F40 Offset: 0x3B4540 VA: 0x1803B5F40
	public static bool CheckInputs(int[] keyCodes) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Utility
public class EnemyUtility // TypeDefIndex: 5337
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Utility
public static class FxUtility // TypeDefIndex: 5338
{
	// Fields
	public static Dictionary<EWeapon, float> weaponCooldowns; // 0x0
	public static Dictionary<EWeapon, float> muzzleCooldowns; // 0x8

	// Methods

	// RVA: 0x3BD640 Offset: 0x3BBC40 VA: 0x1803BD640
	public static void Init() { }

	// RVA: 0x3BD520 Offset: 0x3BBB20 VA: 0x1803BD520
	public static void Cleanup() { }

	// RVA: 0x3BD760 Offset: 0x3BBD60 VA: 0x1803BD760
	private static void OnRunStarted() { }

	// RVA: 0x3BD850 Offset: 0x3BBE50 VA: 0x1803BD850
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Utility
public class Links // TypeDefIndex: 5339
{
	// Fields
	public static string discord; // 0x0
	public static string youtube; // 0x8

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3C0400 Offset: 0x3BEA00 VA: 0x1803C0400
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Utility
public static class MyColorUtility // TypeDefIndex: 5340
{
	// Fields
	public const string white = "#ffffff";
	public static string positiveColorString; // 0x0
	public static string negativeColorString; // 0x8
	public static Color aegisColor; // 0x10
	public static Color weakAegisColor; // 0x20
	public static Color bleedColor; // 0x30
	public static Color tier1Color; // 0x40
	public static Color tier2Color; // 0x50
	public static Color tier3Color; // 0x60
	private static Dictionary<EStatCategory, Color> statCategoryColors; // 0x70
	private static Color hasteColor; // 0x78
	private static Color magnetColor; // 0x88
	private static Color shieldColor; // 0x98
	private static Color timeFreezeColor; // 0xA8
	private static Color healthColor; // 0xB8
	private static Color rageColor; // 0xC8
	private static Color stonksColor; // 0xD8
	private static Color newColor; // 0xE8
	private static Color commonColor; // 0xF8
	private static Color uncommonColor; // 0x108
	private static Color rareColor; // 0x118
	private static Color epicColor; // 0x128
	private static Color legendaryColor; // 0x138
	public static Color interactOutlineColor; // 0x148
	public static Color interactDisabledOutlineColor; // 0x158
	public static string requirementCompletedColor; // 0x168
	public static string requirementMissingColor; // 0x170
	public static Color evadeColor; // 0x178
	public static Color evadePhantomColor; // 0x188
	public static Color critMegaColor; // 0x198
	public static Color bonkColor; // 0x1A8
	public static Color poisonColor; // 0x1B8
	public static Color fireColor; // 0x1C8
	public static Color executeColor; // 0x1D8
	public static Color echoColor; // 0x1E8
	public static Color bloodmarkColor; // 0x1F8
	private static Color easyColor; // 0x208
	private static Color mediumColor; // 0x218
	private static Color hardColor; // 0x228
	private static Color cookedColor; // 0x238
	private static Color rankTier1Color; // 0x248
	private static Color rankTier2Color; // 0x258
	private static Color rankTier3Color; // 0x268
	private static Color rankTier4Color; // 0x278
	private static Color rankTier5Color; // 0x288
	private static Color rankTier6Color; // 0x298

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Init() { }

	// RVA: 0x3C2670 Offset: 0x3C0C70 VA: 0x1803C2670
	public static Color GetStatCategoryColor(EStatCategory statCategory) { }

	// RVA: 0x3C1E20 Offset: 0x3C0420 VA: 0x1803C1E20
	private static Color StringToColor(string s) { }

	// RVA: 0x3C2840 Offset: 0x3C0E40 VA: 0x1803C2840
	public static Color PickupToColor(EPickup ePickup) { }

	// RVA: 0x3C2AB0 Offset: 0x3C10B0 VA: 0x1803C2AB0
	public static Color RarityToColor(ERarity rarity) { }

	// RVA: 0x3C23D0 Offset: 0x3C09D0 VA: 0x1803C23D0
	public static Color GetRarityColorBackground(ERarity rarity) { }

	// RVA: 0x3C21E0 Offset: 0x3C07E0 VA: 0x1803C21E0
	public static Color GetRarityColorBackground(EItemRarity rarity) { }

	// RVA: 0x3C1E50 Offset: 0x3C0450 VA: 0x1803C1E50
	public static Color GetItemRarityColor(EItemRarity rarity) { }

	// RVA: 0x3C1AF0 Offset: 0x3C00F0 VA: 0x1803C1AF0
	public static Color GetDamageEffectColor(EDamageEffect effect) { }

	// RVA: 0x3C2710 Offset: 0x3C0D10 VA: 0x1803C2710
	public static string GetStatTextColor(bool isPositive) { }

	// RVA: 0x3C2600 Offset: 0x3C0C00 VA: 0x1803C2600
	public static Color GetRedToGreenGradient(float t) { }

	// RVA: 0x3C1DC0 Offset: 0x3C03C0 VA: 0x1803C1DC0
	public static Color GetHealthBarColor(EHpBarColor color) { }

	// RVA: 0x3C2760 Offset: 0x3C0D60 VA: 0x1803C2760
	public static Color GetTierColor(int tier) { }

	// RVA: 0x3C1FF0 Offset: 0x3C05F0 VA: 0x1803C1FF0
	public static Color GetRankColor(int rank) { }

	// RVA: 0x3C1990 Offset: 0x3BFF90 VA: 0x1803C1990
	public static Color DifficultyToColor(EAchievementDifficulty difficulty) { }

	// RVA: 0x3C1E20 Offset: 0x3C0420 VA: 0x1803C1E20
	public static Color GetHexToColor(string hex) { }

	// RVA: 0x3C1970 Offset: 0x3BFF70 VA: 0x1803C1970
	public static string ColorToHex(Color color) { }

	// RVA: 0x3C2C90 Offset: 0x3C1290 VA: 0x1803C2C90
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Utility
public static class MyLogger // TypeDefIndex: 5341
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Log(string s, GameObject context) { }

	// RVA: 0x3C3A50 Offset: 0x3C2050 VA: 0x1803C3A50
	public static void LogInBuild(string s, GameObject context) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void LogError(string s, GameObject context) { }

	// RVA: 0x3C39A0 Offset: 0x3C1FA0 VA: 0x1803C39A0
	public static void LogErrorInBuild(string s, GameObject context) { }
}

// Namespace: Assets.Scripts.Utility
public class MyStringUtil // TypeDefIndex: 5342
{
	// Methods

	// RVA: 0x3C3D50 Offset: 0x3C2350 VA: 0x1803C3D50
	public static string ShowOnlyDecimals(float number) { }

	// RVA: 0x3C3B80 Offset: 0x3C2180 VA: 0x1803C3B80
	public static void ApplyEllipsisIfTruncated(TextMeshProUGUI tmp) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Utility
public static class MyTime // TypeDefIndex: 5343
{
	// Fields
	public static bool paused; // 0x0
	public static float time; // 0x4
	public static float deltaTime; // 0x8
	public static float fixedDeltaTime; // 0xC
	[CompilerGenerated]
	private static float <timeScale>k__BackingField; // 0x10
	public static int tick; // 0x14
	public static int unpauseTick; // 0x18
	public static float stageTimer; // 0x1C
	public static float runTimer; // 0x20
	public static float finalSwarmTimer; // 0x24
	public static float difficultyTimer; // 0x28
	public static Action<bool> A_Pause; // 0x30
	public static Action A_Tick; // 0x38
	public static Action A_TimeScaleChange; // 0x40
	private static float timescaleTimeRemaining; // 0x48

	// Properties
	public static float timeScale { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3C4E50 Offset: 0x3C3450 VA: 0x1803C4E50
	public static float get_timeScale() { }

	[CompilerGenerated]
	// RVA: 0x3C4EA0 Offset: 0x3C34A0 VA: 0x1803C4EA0
	private static void set_timeScale(float value) { }

	// RVA: 0x3C4260 Offset: 0x3C2860 VA: 0x1803C4260
	public static void Init() { }

	// RVA: 0x3C3F30 Offset: 0x3C2530 VA: 0x1803C3F30
	public static void Cleanup() { }

	// RVA: 0x3C4460 Offset: 0x3C2A60 VA: 0x1803C4460
	private static void OnNewRunStarted() { }

	// RVA: 0x3C4530 Offset: 0x3C2B30 VA: 0x1803C4530
	private static void OnNewStageStarted() { }

	// RVA: 0x3C49F0 Offset: 0x3C2FF0 VA: 0x1803C49F0
	public static void Update() { }

	// RVA: 0x3C4130 Offset: 0x3C2730 VA: 0x1803C4130
	public static void FixedUpdate() { }

	// RVA: 0x3C4850 Offset: 0x3C2E50 VA: 0x1803C4850
	public static void SetTimeScale(float newTimeScale, float duration) { }

	// RVA: 0x3C47A0 Offset: 0x3C2DA0 VA: 0x1803C47A0
	private static void ResetTimeScale() { }

	// RVA: 0x3C46F0 Offset: 0x3C2CF0 VA: 0x1803C46F0
	public static void Pause() { }

	// RVA: 0x3C4920 Offset: 0x3C2F20 VA: 0x1803C4920
	public static void Unpause() { }

	// RVA: 0x3C4E10 Offset: 0x3C3410 VA: 0x1803C4E10
	private static void .cctor() { }
}

