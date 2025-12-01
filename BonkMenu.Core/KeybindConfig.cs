using MelonLoader;
using BonkMenu.Core;
using UnityEngine;

namespace BonkMenu.Core;

public static class KeybindConfig
{
    private static MelonPreferences_Category _category;
    private static MelonPreferences_Entry<KeyCode> _toggleMenuKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _toggleGodModeKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _toggleUnlimitedXpKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnChestsKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnFreeChestsKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnStatuesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnChallengeShrinesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnCursedShrinesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnGreedShrinesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnGreedAltarsKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnMagnetShrinesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnMoaiShrinesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnChargeShrinesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnGoldChargeShrinesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnPotsKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnMicrowavesKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnShadyMerchantKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnShadyMerchantRareKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnShadyMerchantEpicKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnShadyMerchantLegendaryKeyEntry;

    public static KeyCode ToggleMenuKey 
    { 
        get => _toggleMenuKeyEntry?.Value ?? KeyCode.F1;
        set 
        {
            if (_toggleMenuKeyEntry != null)
            {
                _toggleMenuKeyEntry.Value = value;
                MelonPreferences.Save();
            }
        }
    }

    public static KeyCode ToggleGodModeKey => _toggleGodModeKeyEntry?.Value ?? KeyCode.F2;
    public static KeyCode ToggleUnlimitedXpKey => _toggleUnlimitedXpKeyEntry?.Value ?? KeyCode.F3;
    public static KeyCode SpawnChestsKey => _spawnChestsKeyEntry?.Value ?? KeyCode.Alpha1;
    public static KeyCode SpawnFreeChestsKey => _spawnFreeChestsKeyEntry?.Value ?? KeyCode.Alpha2;
    public static KeyCode SpawnStatuesKey => _spawnStatuesKeyEntry?.Value ?? KeyCode.Alpha3;
    public static KeyCode SpawnChallengeShrinesKey => _spawnChallengeShrinesKeyEntry?.Value ?? KeyCode.Alpha4;
    public static KeyCode SpawnCursedShrinesKey => _spawnCursedShrinesKeyEntry?.Value ?? KeyCode.Alpha5;
    public static KeyCode SpawnGreedShrinesKey => _spawnGreedShrinesKeyEntry?.Value ?? KeyCode.Alpha6;
    public static KeyCode SpawnGreedAltarsKey => _spawnGreedAltarsKeyEntry?.Value ?? KeyCode.F11;
    public static KeyCode SpawnMagnetShrinesKey => _spawnMagnetShrinesKeyEntry?.Value ?? KeyCode.Alpha7;
    public static KeyCode SpawnMoaiShrinesKey => _spawnMoaiShrinesKeyEntry?.Value ?? KeyCode.Alpha8;
    public static KeyCode SpawnChargeShrinesKey => _spawnChargeShrinesKeyEntry?.Value ?? KeyCode.Alpha9;
    public static KeyCode SpawnGoldChargeShrinesKey => _spawnGoldChargeShrinesKeyEntry?.Value ?? KeyCode.Alpha0;
    public static KeyCode SpawnPotsKey => _spawnPotsKeyEntry?.Value ?? KeyCode.F5;
    public static KeyCode SpawnMicrowavesKey => _spawnMicrowavesKeyEntry?.Value ?? KeyCode.F6;
    public static KeyCode SpawnShadyMerchantKey => _spawnShadyMerchantKeyEntry?.Value ?? KeyCode.F7;
    public static KeyCode SpawnShadyMerchantRareKey => _spawnShadyMerchantRareKeyEntry?.Value ?? KeyCode.F8;
    public static KeyCode SpawnShadyMerchantEpicKey => _spawnShadyMerchantEpicKeyEntry?.Value ?? KeyCode.F9;
    public static KeyCode SpawnShadyMerchantLegendaryKey => _spawnShadyMerchantLegendaryKeyEntry?.Value ?? KeyCode.F10;

    public static void LoadKeybinds()
    {
        _category = MelonPreferences.CreateCategory("BonkMenu", "BonkMenu Settings");
        _toggleMenuKeyEntry = _category.CreateEntry("ToggleMenuKey", KeyCode.F1, "Toggle Menu Key", "Key to toggle the menu visibility");
        _toggleGodModeKeyEntry = _category.CreateEntry("ToggleGodModeKey", KeyCode.F2, "Toggle God Mode", "Key to toggle God Mode");
        _toggleUnlimitedXpKeyEntry = _category.CreateEntry("ToggleUnlimitedXpKey", KeyCode.F3, "Toggle Unlimited XP", "Key to toggle Unlimited XP");
        _spawnChestsKeyEntry = _category.CreateEntry("SpawnChestsKey", KeyCode.Alpha1, "Spawn Chests", "Spawn 1 Chest");
        _spawnFreeChestsKeyEntry = _category.CreateEntry("SpawnFreeChestsKey", KeyCode.Alpha2, "Spawn Free Chests", "Spawn 1 Free Chest");
        _spawnStatuesKeyEntry = _category.CreateEntry("SpawnStatuesKey", KeyCode.Alpha3, "Spawn All Statues", "Spawn statues once");
        _spawnChallengeShrinesKeyEntry = _category.CreateEntry("SpawnChallengeShrinesKey", KeyCode.Alpha4, "Spawn Challenge Shrine", "Spawn 1 Challenge Shrine");
        _spawnCursedShrinesKeyEntry = _category.CreateEntry("SpawnCursedShrinesKey", KeyCode.Alpha5, "Spawn Cursed Shrine", "Spawn 1 Cursed Shrine");
        _spawnGreedShrinesKeyEntry = _category.CreateEntry("SpawnGreedShrinesKey", KeyCode.Alpha6, "Spawn Greed Shrine", "Spawn 1 Greed Shrine");
        _spawnGreedAltarsKeyEntry = _category.CreateEntry("SpawnGreedAltarsKey", KeyCode.F11, "Spawn Greed Altar", "Spawn 1 Greed Altar");
        _spawnMagnetShrinesKeyEntry = _category.CreateEntry("SpawnMagnetShrinesKey", KeyCode.Alpha7, "Spawn Magnet Shrine", "Spawn 1 Magnet Shrine");
        _spawnMoaiShrinesKeyEntry = _category.CreateEntry("SpawnMoaiShrinesKey", KeyCode.Alpha8, "Spawn Moai Shrine", "Spawn 1 Moai Shrine");
        _spawnChargeShrinesKeyEntry = _category.CreateEntry("SpawnChargeShrinesKey", KeyCode.Alpha9, "Spawn Charge Shrine", "Spawn 1 Charge Shrine");
        _spawnGoldChargeShrinesKeyEntry = _category.CreateEntry("SpawnGoldChargeShrinesKey", KeyCode.Alpha0, "Spawn Gold Charge Shrine", "Spawn 1 Gold Charge Shrine");
        _spawnPotsKeyEntry = _category.CreateEntry("SpawnPotsKey", KeyCode.F5, "Spawn Pots", "Spawn 1 set of pots");
        _spawnMicrowavesKeyEntry = _category.CreateEntry("SpawnMicrowavesKey", KeyCode.F6, "Spawn Microwaves", "Spawn microwaves once");
        _spawnShadyMerchantKeyEntry = _category.CreateEntry("SpawnShadyMerchantKey", KeyCode.F7, "Spawn Shady Merchant", "Spawn 1 merchant");
        _spawnShadyMerchantRareKeyEntry = _category.CreateEntry("SpawnShadyMerchantRareKey", KeyCode.F8, "Spawn Shady Merchant (Rare)", "Spawn 1 rare merchant");
        _spawnShadyMerchantEpicKeyEntry = _category.CreateEntry("SpawnShadyMerchantEpicKey", KeyCode.F9, "Spawn Shady Merchant (Epic)", "Spawn 1 epic merchant");
        _spawnShadyMerchantLegendaryKeyEntry = _category.CreateEntry("SpawnShadyMerchantLegendaryKey", KeyCode.F10, "Spawn Shady Merchant (Legendary)", "Spawn 1 legendary merchant");
        
        Log.Info($"[BonkMenu] Keybinds loaded. Toggle Key: {ToggleMenuKey}");
    }

    public static void SaveKeybinds()
    {
        MelonPreferences.Save();
    }
}
