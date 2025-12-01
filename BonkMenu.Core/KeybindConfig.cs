using MelonLoader;
using UnityEngine;

namespace BonkMenu.Core;

public static class KeybindConfig
{
    private static MelonPreferences_Category _category;
    private static MelonPreferences_Entry<KeyCode> _toggleMenuKeyEntry;

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

    public static void LoadKeybinds()
    {
        _category = MelonPreferences.CreateCategory("BonkMenu", "BonkMenu Settings");
        _toggleMenuKeyEntry = _category.CreateEntry("ToggleMenuKey", KeyCode.F1, "Toggle Menu Key", "Key to toggle the menu visibility");
        
        MelonLogger.Msg($"[BonkMenu] Keybinds loaded. Toggle Key: {ToggleMenuKey}");
    }

    public static void SaveKeybinds()
    {
        MelonPreferences.Save();
    }
}
