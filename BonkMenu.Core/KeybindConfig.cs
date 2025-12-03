using MelonLoader;
using UnityEngine;
using UniverseLib.Input;
using System.Collections.Generic;

namespace BonkMenu.Core;

/// <summary>
/// Centralized keybinds for toggles and spawn actions.
/// </summary>
public static class KeybindConfig
{
    private static MelonPreferences_Category _category;
    private static MelonPreferences_Entry<KeyCode> _toggleMenuKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _toggleGodModeKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _toggleUnlimitedXpKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnChestsKeyEntry;
    private static MelonPreferences_Entry<KeyCode> _spawnFreeChestsKeyEntry;
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

    /// <summary>
    /// Key to toggle the BonkMenu UI.
    /// </summary>
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

    /// <summary>
    /// Key to toggle God Mode.
    /// </summary>
    public static KeyCode ToggleGodModeKey { get => _toggleGodModeKeyEntry?.Value ?? KeyCode.F2; set { if (_toggleGodModeKeyEntry != null) { _toggleGodModeKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to toggle Unlimited XP.
    /// </summary>
    public static KeyCode ToggleUnlimitedXpKey { get => _toggleUnlimitedXpKeyEntry?.Value ?? KeyCode.F3; set { if (_toggleUnlimitedXpKeyEntry != null) { _toggleUnlimitedXpKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn chests.
    /// </summary>
    public static KeyCode SpawnChestsKey { get => _spawnChestsKeyEntry?.Value ?? KeyCode.Alpha1; set { if (_spawnChestsKeyEntry != null) { _spawnChestsKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn free chests.
    /// </summary>
    public static KeyCode SpawnFreeChestsKey { get => _spawnFreeChestsKeyEntry?.Value ?? KeyCode.Alpha2; set { if (_spawnFreeChestsKeyEntry != null) { _spawnFreeChestsKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn challenge shrines.
    /// </summary>
    public static KeyCode SpawnChallengeShrinesKey { get => _spawnChallengeShrinesKeyEntry?.Value ?? KeyCode.Alpha4; set { if (_spawnChallengeShrinesKeyEntry != null) { _spawnChallengeShrinesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn cursed shrines.
    /// </summary>
    public static KeyCode SpawnCursedShrinesKey { get => _spawnCursedShrinesKeyEntry?.Value ?? KeyCode.Alpha5; set { if (_spawnCursedShrinesKeyEntry != null) { _spawnCursedShrinesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn greed shrines.
    /// </summary>
    public static KeyCode SpawnGreedShrinesKey { get => _spawnGreedShrinesKeyEntry?.Value ?? KeyCode.Alpha6; set { if (_spawnGreedShrinesKeyEntry != null) { _spawnGreedShrinesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn greed altars.
    /// </summary>
    public static KeyCode SpawnGreedAltarsKey { get => _spawnGreedAltarsKeyEntry?.Value ?? KeyCode.F11; set { if (_spawnGreedAltarsKeyEntry != null) { _spawnGreedAltarsKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn magnet shrines.
    /// </summary>
    public static KeyCode SpawnMagnetShrinesKey { get => _spawnMagnetShrinesKeyEntry?.Value ?? KeyCode.Alpha7; set { if (_spawnMagnetShrinesKeyEntry != null) { _spawnMagnetShrinesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn moai shrines.
    /// </summary>
    public static KeyCode SpawnMoaiShrinesKey { get => _spawnMoaiShrinesKeyEntry?.Value ?? KeyCode.Alpha8; set { if (_spawnMoaiShrinesKeyEntry != null) { _spawnMoaiShrinesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn charge shrines.
    /// </summary>
    public static KeyCode SpawnChargeShrinesKey { get => _spawnChargeShrinesKeyEntry?.Value ?? KeyCode.Alpha9; set { if (_spawnChargeShrinesKeyEntry != null) { _spawnChargeShrinesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn gold charge shrines.
    /// </summary>
    public static KeyCode SpawnGoldChargeShrinesKey { get => _spawnGoldChargeShrinesKeyEntry?.Value ?? KeyCode.Alpha0; set { if (_spawnGoldChargeShrinesKeyEntry != null) { _spawnGoldChargeShrinesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn pots.
    /// </summary>
    public static KeyCode SpawnPotsKey { get => _spawnPotsKeyEntry?.Value ?? KeyCode.F5; set { if (_spawnPotsKeyEntry != null) { _spawnPotsKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn microwaves.
    /// </summary>
    public static KeyCode SpawnMicrowavesKey { get => _spawnMicrowavesKeyEntry?.Value ?? KeyCode.F6; set { if (_spawnMicrowavesKeyEntry != null) { _spawnMicrowavesKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn a Shady Merchant.
    /// </summary>
    public static KeyCode SpawnShadyMerchantKey { get => _spawnShadyMerchantKeyEntry?.Value ?? KeyCode.F7; set { if (_spawnShadyMerchantKeyEntry != null) { _spawnShadyMerchantKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn a Rare Shady Merchant.
    /// </summary>
    public static KeyCode SpawnShadyMerchantRareKey { get => _spawnShadyMerchantRareKeyEntry?.Value ?? KeyCode.F8; set { if (_spawnShadyMerchantRareKeyEntry != null) { _spawnShadyMerchantRareKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn an Epic Shady Merchant.
    /// </summary>
    public static KeyCode SpawnShadyMerchantEpicKey { get => _spawnShadyMerchantEpicKeyEntry?.Value ?? KeyCode.F9; set { if (_spawnShadyMerchantEpicKeyEntry != null) { _spawnShadyMerchantEpicKeyEntry.Value = value; MelonPreferences.Save(); } } }
    /// <summary>
    /// Key to spawn a Legendary Shady Merchant.
    /// </summary>
    public static KeyCode SpawnShadyMerchantLegendaryKey { get => _spawnShadyMerchantLegendaryKeyEntry?.Value ?? KeyCode.F10; set { if (_spawnShadyMerchantLegendaryKeyEntry != null) { _spawnShadyMerchantLegendaryKeyEntry.Value = value; MelonPreferences.Save(); } } }

    /// <summary>
    /// Initializes keybind entries and loads defaults.
    /// </summary>
    public static void LoadKeybinds()
    {
        _category = MelonPreferences.CreateCategory("BonkMenu", "BonkMenu Settings");
        _toggleMenuKeyEntry = _category.CreateEntry("ToggleMenuKey", KeyCode.F1, "Toggle Menu Key", "Key to toggle the menu visibility");
        _toggleGodModeKeyEntry = _category.CreateEntry("ToggleGodModeKey", KeyCode.F2, "Toggle God Mode", "Key to toggle God Mode");
        _toggleUnlimitedXpKeyEntry = _category.CreateEntry("ToggleUnlimitedXpKey", KeyCode.F3, "Toggle Unlimited XP", "Key to toggle Unlimited XP");
        _spawnChestsKeyEntry = _category.CreateEntry("SpawnChestsKey", KeyCode.Alpha1, "Spawn Chests", "Spawn 1 Chest");
        _spawnFreeChestsKeyEntry = _category.CreateEntry("SpawnFreeChestsKey", KeyCode.Alpha2, "Spawn Free Chests", "Spawn 1 Free Chest");
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

    /// <summary>
    /// Persists current keybind values.
    /// </summary>
    public static void SaveKeybinds()
    {
        MelonPreferences.Save();
    }

    // Interactive rebinding state
    public static bool IsCapturingKeybind { get; private set; }
    public static System.Func<KeyCode> PendingGetter { get; private set; }
    public static System.Action<KeyCode> PendingSetter { get; private set; }
    public static System.Action<string> PendingApplyUi { get; private set; }
    public static string PendingLabel { get; private set; }

    public static void BeginCapture(string label, System.Func<KeyCode> getter, System.Action<KeyCode> setter, System.Action<string> applyUi)
    {
        PendingLabel = label;
        PendingGetter = getter;
        PendingSetter = setter;
        PendingApplyUi = applyUi;
        IsCapturingKeybind = true;
    }

    public static void ClearCapture()
    {
        IsCapturingKeybind = false;
        PendingLabel = null;
        PendingGetter = null;
        PendingSetter = null;
        PendingApplyUi = null;
    }

    // Modifiers storage per binding label
    private static Dictionary<string, MelonPreferences_Entry<string>> _mods = new Dictionary<string, MelonPreferences_Entry<string>>();
    private static string Sanitize(string label)
    {
        if (string.IsNullOrEmpty(label)) return "Unnamed";
        var s = label.Replace(" ", "_").Replace("(", "").Replace(")", "").Replace("/", "_");
        return s;
    }
    private static MelonPreferences_Entry<string> GetModifiersEntry(string label)
    {
        if (_category == null) _category = MelonPreferences.CreateCategory("BonkMenu", "BonkMenu Settings");
        MelonPreferences_Entry<string> entry;
        if (_mods.TryGetValue(label, out entry)) return entry;
        entry = _category.CreateEntry("Modifiers_" + Sanitize(label), "", label + " Modifiers", "Required modifiers: comma-separated tokens: LeftShift,RightShift,Shift,LeftCtrl,RightCtrl,Ctrl,LeftAlt,RightAlt,Alt");
        _mods[label] = entry;
        return entry;
    }
    public static void SetModifiers(string label, bool shift, bool ctrl, bool alt)
    {
        var parts = new List<string>();
        if (shift) parts.Add("Shift");
        if (ctrl) parts.Add("Ctrl");
        if (alt) parts.Add("Alt");
        GetModifiersEntry(label).Value = string.Join(",", parts);
        MelonPreferences.Save();
    }
    public static void SetModifiersDetailed(string label, bool leftShift, bool rightShift, bool leftCtrl, bool rightCtrl, bool leftAlt, bool rightAlt)
    {
        var parts = new List<string>();
        if (leftShift) parts.Add("LeftShift");
        if (rightShift) parts.Add("RightShift");
        if (leftCtrl) parts.Add("LeftCtrl");
        if (rightCtrl) parts.Add("RightCtrl");
        if (leftAlt) parts.Add("LeftAlt");
        if (rightAlt) parts.Add("RightAlt");
        GetModifiersEntry(label).Value = string.Join(",", parts);
        MelonPreferences.Save();
    }
    private static bool HasToken(string label, string token)
    {
        var v = GetModifiersEntry(label).Value;
        return !string.IsNullOrEmpty(v) && v.IndexOf(token) >= 0;
    }
    private static bool IsShiftHeld()
    {
        return UniverseLib.Input.InputManager.GetKey(KeyCode.LeftShift) || UniverseLib.Input.InputManager.GetKey(KeyCode.RightShift);
    }
    private static bool IsCtrlHeld()
    {
        return UniverseLib.Input.InputManager.GetKey(KeyCode.LeftControl) || UniverseLib.Input.InputManager.GetKey(KeyCode.RightControl);
    }
    private static bool IsAltHeld()
    {
        return UniverseLib.Input.InputManager.GetKey(KeyCode.LeftAlt) || UniverseLib.Input.InputManager.GetKey(KeyCode.RightAlt);
    }
    public static bool IsChordDown(string label, KeyCode key)
    {
        if (key == KeyCode.None) return false;
        if (!InputManager.GetKeyDown(key)) return false;
        if (HasToken(label, "LeftShift") && !InputManager.GetKey(KeyCode.LeftShift)) return false;
        if (HasToken(label, "RightShift") && !InputManager.GetKey(KeyCode.RightShift)) return false;
        if (HasToken(label, "Shift") && !(InputManager.GetKey(KeyCode.LeftShift) || InputManager.GetKey(KeyCode.RightShift))) return false;
        if (HasToken(label, "LeftCtrl") && !InputManager.GetKey(KeyCode.LeftControl)) return false;
        if (HasToken(label, "RightCtrl") && !InputManager.GetKey(KeyCode.RightControl)) return false;
        if (HasToken(label, "Ctrl") && !(InputManager.GetKey(KeyCode.LeftControl) || InputManager.GetKey(KeyCode.RightControl))) return false;
        if (HasToken(label, "LeftAlt") && !InputManager.GetKey(KeyCode.LeftAlt)) return false;
        if (HasToken(label, "RightAlt") && !InputManager.GetKey(KeyCode.RightAlt)) return false;
        if (HasToken(label, "Alt") && !(InputManager.GetKey(KeyCode.LeftAlt) || InputManager.GetKey(KeyCode.RightAlt))) return false;
        return true;
    }
    public static bool IsChordHeld(string label, KeyCode key)
    {
        if (key == KeyCode.None) return false;
        if (!InputManager.GetKey(key)) return false;
        if (HasToken(label, "LeftShift") && !InputManager.GetKey(KeyCode.LeftShift)) return false;
        if (HasToken(label, "RightShift") && !InputManager.GetKey(KeyCode.RightShift)) return false;
        if (HasToken(label, "Shift") && !(InputManager.GetKey(KeyCode.LeftShift) || InputManager.GetKey(KeyCode.RightShift))) return false;
        if (HasToken(label, "LeftCtrl") && !InputManager.GetKey(KeyCode.LeftControl)) return false;
        if (HasToken(label, "RightCtrl") && !InputManager.GetKey(KeyCode.RightControl)) return false;
        if (HasToken(label, "Ctrl") && !(InputManager.GetKey(KeyCode.LeftControl) || InputManager.GetKey(KeyCode.RightControl))) return false;
        if (HasToken(label, "LeftAlt") && !InputManager.GetKey(KeyCode.LeftAlt)) return false;
        if (HasToken(label, "RightAlt") && !InputManager.GetKey(KeyCode.RightAlt)) return false;
        if (HasToken(label, "Alt") && !(InputManager.GetKey(KeyCode.LeftAlt) || InputManager.GetKey(KeyCode.RightAlt))) return false;
        return true;
    }
    public static string FormatKeyLabel(string label, KeyCode key)
    {
        if (key == KeyCode.None) return "None";
        var mods = new List<string>();
        var v = GetModifiersEntry(label).Value;
        if (!string.IsNullOrEmpty(v))
        {
            if (v.IndexOf("LeftShift") >= 0) mods.Add("LeftShift");
            else if (v.IndexOf("RightShift") >= 0) mods.Add("RightShift");
            else if (v.IndexOf("Shift") >= 0) mods.Add("Shift");
            if (v.IndexOf("LeftCtrl") >= 0) mods.Add("LeftCtrl");
            else if (v.IndexOf("RightCtrl") >= 0) mods.Add("RightCtrl");
            else if (v.IndexOf("Ctrl") >= 0) mods.Add("Ctrl");
            if (v.IndexOf("LeftAlt") >= 0) mods.Add("LeftAlt");
            else if (v.IndexOf("RightAlt") >= 0) mods.Add("RightAlt");
            else if (v.IndexOf("Alt") >= 0) mods.Add("Alt");
        }
        string keyLabel;
        if (key >= KeyCode.Alpha0 && key <= KeyCode.Alpha9)
        {
            keyLabel = ((int)key - (int)KeyCode.Alpha0).ToString();
        }
        else if (key >= KeyCode.Keypad0 && key <= KeyCode.Keypad9)
        {
            keyLabel = ((int)key - (int)KeyCode.Keypad0).ToString();
        }
        else
        {
            keyLabel = key.ToString();
        }
        if (mods.Count > 0) return string.Join("+", mods) + "+" + keyLabel;
        return keyLabel;
    }
}
