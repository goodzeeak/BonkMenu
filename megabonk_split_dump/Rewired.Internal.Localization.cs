// Namespace: Rewired.Internal.Localization
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface ITryGetLocalizedName // TypeDefIndex: 2799
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetLocalizedName(out string value);
}

// Namespace: Rewired.Internal.Localization
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal sealed class DeviceLocalizationInfo // TypeDefIndex: 2804
{
	// Fields
	public readonly Guid guid; // 0x10
	public readonly ControllerType controllerType; // 0x20
	public readonly bool isControllerTemplate; // 0x24
	private readonly ReadOnlyList<string> mTEkfqzWuBgZPJNkQvSAUaqOZdBn; // 0x28
	private readonly IList<string> CRURAmzWXwwpaNRDJiVschHGBAhm; // 0x30
	private readonly ReadOnlyList<Guid> iEeEUWfWAfxPXaHycUmFnhykVemn; // 0x38
	private string kSimSoHnpGeThuTgSSJjBbTEVnB; // 0x40
	private Bytes20 xTuaXkiPQDMBTxjmLUoUsaucUgNg; // 0x48
	private bool kEfxvyBpPTsvamlEZoyXyDDhLIGR; // 0x60

	// Properties
	public ReadOnlyList<string> parentKeys { get; }
	public ReadOnlyList<Guid> controllerTemplateGuids { get; }
	public string additionalIdentifyingInformation { get; set; }
	public Bytes20 hash { get; }

	// Methods

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public ReadOnlyList<string> get_parentKeys() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public ReadOnlyList<Guid> get_controllerTemplateGuids() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_additionalIdentifyingInformation() { }

	// RVA: 0x17970C0 Offset: 0x17956C0 VA: 0x1817970C0
	public void set_additionalIdentifyingInformation(string value) { }

	// RVA: 0x1797030 Offset: 0x1795630 VA: 0x181797030
	public Bytes20 get_hash() { }

	// RVA: 0x1796E10 Offset: 0x1795410 VA: 0x181796E10
	public void .ctor() { }

	// RVA: 0x1796EE0 Offset: 0x17954E0 VA: 0x181796EE0
	public void .ctor(ControllerType , bool , Guid , IList<string> , IList<Guid> ) { }

	// RVA: 0x1796C30 Offset: 0x1795230 VA: 0x181796C30
	public void .ctor(DeviceLocalizationInfo ) { }

	// RVA: 0x1796B60 Offset: 0x1795160 VA: 0x181796B60
	public void InsertParentKey(int index, string key) { }

	// RVA: 0x1796B30 Offset: 0x1795130 VA: 0x181796B30
	public void FinishRuntimeSetup() { }

	// RVA: 0x1796600 Offset: 0x1794C00 VA: 0x181796600
	public Bytes20 ComputeHash() { }

	// RVA: 0x1797130 Offset: 0x1795730 VA: 0x181797130
	private void wJaNAyADkyGSccJcfNuVNQZOoQbP() { }

	// RVA: 0x1797050 Offset: 0x1795650 VA: 0x181797050
	private void sWbShoAVaUlQYMGCoyWCrOapIvaj() { }

	// RVA: 0x17968C0 Offset: 0x1794EC0 VA: 0x1817968C0
	public static bool DataMatches(DeviceLocalizationInfo a, DeviceLocalizationInfo b) { }
}

// Namespace: Rewired.Internal.Localization
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class LocalizedString // TypeDefIndex: 2805
{
	// Fields
	public const uint INVALID_VERSION = 0;
	private uint PzQRXVytQPjWfAlzYiuheUjhZkcA; // 0x10
	private uint CcfpWHGYEETfeiCDxLBqheRTqDbD; // 0x14
	private string rNhOotwlgLbFGbdLIWuZTVzxiecSA; // 0x18
	private bool YMyQuojCTrtmwFplnUGFxxyuhxmd; // 0x20

	// Properties
	public bool hasCachedValue { get; }
	public string cachedValue { get; set; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_hasCachedValue() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_cachedValue() { }

	// RVA: 0x17998E0 Offset: 0x1797EE0 VA: 0x1817998E0
	public void set_cachedValue(string value) { }

	// RVA: 0x1799860 Offset: 0x1797E60 VA: 0x181799860
	public void .ctor() { }

	// RVA: 0x1799880 Offset: 0x1797E80 VA: 0x181799880
	public void .ctor(LocalizedString ) { }

	// RVA: 0x17995D0 Offset: 0x1797BD0 VA: 0x1817995D0
	public void Clear() { }

	// RVA: 0x1799600 Offset: 0x1797C00 VA: 0x181799600
	public bool TryGetLocalizedValue(string key, ILocalizedStringProvider localizer, uint localizerVersion, uint userVersion, out bool versionChanged, out string result) { }
}

// Namespace: Rewired.Internal.Localization
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal static class LocalizationManager // TypeDefIndex: 2834
{
	// Fields
	private const char DIwcujasDgDiwvcqrFnokrWNeOTxA = '\x5f';
	private const char ffNtARzDGmKwugKuuJMIrxqXQTGr = '\x2f';
	private const string KSoRMaknUqfCsCIkLzfupkEeyNFxA = "/";
	internal const string hardwareTypeKey_universalKeyboard = "keyboard";
	internal const string hardwareTypeKey_universalMouse = "mouse";
	internal const string hardwareTypeKey_unknownController = "unknown_controller";
	internal const string localizationKeyAxisPoleSuffix_positive = "positive";
	internal const string localizationKeyAxisPoleSuffix_negative = "negative";
	internal const string localizationKeyAxisDirectionSuffix_horizontal = "horizontal";
	internal const string localizationKeyAxisDirectionSuffix_vertical = "vertical";
	internal const string localizationAndGlyphKeyCategory_controller = "controller";
	internal const string localizationAndGlyphKeyCategory_customController = "controller/custom";
	internal const string localizationAndGlyphKeyCategory_controllerTemplate = "controller/template";
	internal const string localizationAndGlyphKeyCategory_action = "action";
	internal const string localizationAndGlyphKeyCategory_inputActionCategory = "action/category";
	internal const string localizationAndGlyphKeyCategory_controllerMap = "controller_map";
	internal const string localizationAndGlyphKeyCategory_controllerMapCategory = "controller_map/category";
	internal const string localizationAndGlyphKeyCategory_layout = "controller_map/layout";
	internal const string localizationAndGlyphKeyCategory_player = "player";
	internal const string localizationAndGlyphKeyCategory_controllerElement = "controller/element";
	internal const string nonLocalizedDisplayNameAxisDirectionSuffix_horizontal = "Horizontal";
	internal const string nonLocalizedDisplayNameAxisDirectionSuffix_vertical = "Vertical";
	private static LocalizationManager.LOCDDLgcAGdpGblIPiLkVCfVvMmA AkZxBDDwwRQcLJdTeOaBkRXDXqNl; // 0x0
	private static StringBuilder ddUYmnAQCdahFiviIWAEFEeSpQJnA; // 0x8

	// Properties
	public static bool isEnabled { get; }
	public static uint version { get; }
	public static ILocalizedStringProvider localizedStringProvider { get; set; }
	public static bool autoPrefetch { get; set; }

	// Methods

	// RVA: 0x17B2730 Offset: 0x17B0D30 VA: 0x1817B2730
	public static void Initialize() { }

	// RVA: 0x17B1F70 Offset: 0x17B0570 VA: 0x1817B1F70
	public static void Deinitialize() { }

	// RVA: 0x17B2DF0 Offset: 0x17B13F0 VA: 0x1817B2DF0
	public static bool get_isEnabled() { }

	// RVA: 0x17B2E90 Offset: 0x17B1490 VA: 0x1817B2E90
	public static uint get_version() { }

	// RVA: 0x17B2E40 Offset: 0x17B1440 VA: 0x1817B2E40
	public static ILocalizedStringProvider get_localizedStringProvider() { }

	// RVA: 0x17B3080 Offset: 0x17B1680 VA: 0x1817B3080
	public static void set_localizedStringProvider(ILocalizedStringProvider value) { }

	// RVA: 0x17B2DA0 Offset: 0x17B13A0 VA: 0x1817B2DA0
	public static bool get_autoPrefetch() { }

	// RVA: 0x17B2FD0 Offset: 0x17B15D0 VA: 0x1817B2FD0
	public static void set_autoPrefetch(bool value) { }

	// RVA: 0x17B1A80 Offset: 0x17B0080 VA: 0x1817B1A80
	public static void Add(cryqoiWRpPKiZeXotNLjGSdyqzFJ obj, ref Id id) { }

	// RVA: 0x17B2AF0 Offset: 0x17B10F0 VA: 0x1817B2AF0
	public static bool Remove(ref Id id) { }

	// RVA: 0x17B2970 Offset: 0x17B0F70 VA: 0x1817B2970
	public static void Prefetch() { }

	// RVA: 0x17B2A00 Offset: 0x17B1000 VA: 0x1817B2A00
	public static void Reload() { }

	// RVA: 0x17B2EE0 Offset: 0x17B14E0 VA: 0x1817B2EE0
	private static void mLmqOTweyedDKnkdofrLINcHPCLk() { }

	// RVA: 0x17B2BA0 Offset: 0x17B11A0 VA: 0x1817B2BA0
	public static bool TryGetCachedLocalizedString(LocalizedString localizedString, string fallback, uint localizationVersion, uint dependenciesVersion, out bool localizationVersionChanged, out string result) { }

	// RVA: 0x17B2CA0 Offset: 0x17B12A0 VA: 0x1817B2CA0
	public static bool TryLocalizeString(LocalizedString localizedString, string key, uint localizationVersion, uint dependenciesVersion, out string result) { }

	// RVA: 0x17B24A0 Offset: 0x17B0AA0 VA: 0x1817B24A0
	public static LocalizationManager.GetAndUpdateLocalizedStringResultFlags GetAndUpdateLocalizedString(LocalizedString localizedString, IReadOnlyList<string> parentKeys, string keyCategory, string fallback, out string result) { }

	// RVA: 0x17B22C0 Offset: 0x17B08C0 VA: 0x1817B22C0
	public static LocalizationManager.GetAndUpdateLocalizedStringResultFlags GetAndUpdateLocalizedString(LocalizedString localizedString, string key, string keyCategory, IReadOnlyList<string> parentKeys, string fallback, out string result) { }

	// RVA: 0x17B1FD0 Offset: 0x17B05D0 VA: 0x1817B1FD0
	private static bool DxerXNVVnOjhSwwakNipCizCAbju(LocalizedString , IReadOnlyList<string> , string , string , out string ) { }

	// RVA: 0x17B3140 Offset: 0x17B1740 VA: 0x1817B3140
	private static bool vczJBAopvaERfGvEXQkjyBCtheuW(LocalizedString , string , string , string , IReadOnlyList<string> , out string ) { }

	// RVA: 0x17B1EB0 Offset: 0x17B04B0 VA: 0x1817B1EB0
	public static string ConcatenateKeyStrings(string a, string b) { }

	// RVA: 0x17B1BA0 Offset: 0x17B01A0 VA: 0x1817B1BA0
	public static string AppendToKeyAsPath(string a, string b) { }

	// RVA: 0x17B1B30 Offset: 0x17B0130 VA: 0x1817B1B30
	public static StringBuilder AppendToKeyAsPath(StringBuilder sb, string value) { }

	// RVA: 0x17B1CF0 Offset: 0x17B02F0 VA: 0x1817B1CF0
	public static string AppendToKeyAxisPole(string a, Pole pole) { }

	// RVA: 0x17B1E20 Offset: 0x17B0420 VA: 0x1817B1E20
	public static string AppendToNameAxisPole(string text, Pole pole) { }

	// RVA: 0x17B1C60 Offset: 0x17B0260 VA: 0x1817B1C60
	public static string AppendToKeyAxisDirection(string a, AxisDirection direction) { }

	// RVA: 0x17B1D80 Offset: 0x17B0380 VA: 0x1817B1D80
	public static string AppendToNameAxisDirection(string a, AxisDirection direction) { }

	// RVA: 0x17B21F0 Offset: 0x17B07F0 VA: 0x1817B21F0
	public static string FormatKey(string text) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17B2660 Offset: 0x17B0C60 VA: 0x1817B2660
	public static StringBuilder GetSharedStringBuilder() { }
}

