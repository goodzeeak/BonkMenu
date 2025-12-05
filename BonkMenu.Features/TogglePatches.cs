using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;
using Il2CppAssets.Scripts.Saves___Serialization.Progression;
using Il2CppAssets.Scripts.Saves___Serialization.Progression.Achievements;
using Il2CppAssets.Scripts.Saves___Serialization.Progression.Unlocks;
using Il2CppAssets.Scripts.Saves___Serialization.SaveFiles;
using MelonLoader;
using UnityEngine;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime;

namespace BonkMenu.Features;

/// <summary>
/// Harmony patches to enable toggling of weapons, tomes, and items in the game's unlocks menu.
/// Based on MegabonkToggleEverything mod.
/// </summary>
[HarmonyPatch]
public static class TogglePatches
{
    private static bool _patchesEnabled = false;
    private static System.Type SafeTypeByName(string fullName)
    {
        try
        {
            var t = System.Type.GetType(fullName, throwOnError: false, ignoreCase: false);
            if (t != null) return t;
        }
        catch { }
        try
        {
            foreach (var asm in System.AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    var an = asm.GetName().Name;
                    if (an != null && an.StartsWith("UnityEngine", System.StringComparison.OrdinalIgnoreCase)) continue;
                    var tt = asm.GetType(fullName, throwOnError: false, ignoreCase: false);
                    if (tt != null) return tt;
                }
                catch { }
            }
        }
        catch { }
        return null;
    }

    /// <summary>
    /// Checks if an unlockable can be toggled (weapons, tomes, items).
    /// </summary>
    private static bool IsModTogglable(this UnlockableBase unlockable)
    {
        if (unlockable == null) return false;
        
        var asWeapon = ((Il2CppObjectBase)unlockable).TryCast<WeaponData>();
        var asTome = ((Il2CppObjectBase)unlockable).TryCast<TomeData>();
        var asItem = ((Il2CppObjectBase)unlockable).TryCast<ItemData>();
        
        return asWeapon != null || asTome != null || asItem != null;
    }

    /// <summary>
    /// Enables or disables the toggle patches.
    /// </summary>
    public static void SetEnabled(bool enabled)
    {
        _patchesEnabled = enabled;
        MelonLogger.Msg($"[TogglePatches] Patches {(enabled ? "enabled" : "disabled")}");
    }

    /// <summary>
    /// Gets whether patches are currently enabled.
    /// </summary>
    public static bool IsEnabled()
    {
        return _patchesEnabled;
    }

    /// <summary>
    /// Patch to allow weapons, tomes, and items to be toggled in the unlocks menu.
    /// </summary>
    [HarmonyPatch(typeof(MyAchievements), "CanToggleActivation")]
    [HarmonyPrefix]
    private static bool MyAchievements_CanToggleActivation_Prefix(ref bool __result, UnlockableBase unlockable)
    {
        if (!_patchesEnabled) return true;

        if (unlockable.IsModTogglable())
        {
            __result = true;
            return false; // Skip original method
        }
        return true; // Run original method
    }

    /// <summary>
    /// Patch to check activation status from the inactivated list.
    /// </summary>
    [HarmonyPatch(typeof(MyAchievements), "IsActivated")]
    [HarmonyPrefix]
    private static bool MyAchievements_IsActivated_Prefix(ref bool __result, UnlockableBase unlockable)
    {
        if (!_patchesEnabled) return true;

        try
        {
            var saveManager = SaveManager.Instance;
            if ((Object)(object)saveManager == (Object)null)
            {
                return true;
            }

            ProgressionSaveFile progression = saveManager.progression;
            if (progression == null)
            {
                return true;
            }

            string internalName = unlockable.GetInternalName();
            if (string.IsNullOrEmpty(internalName))
            {
                internalName = ((Object)unlockable).name;
            }

            __result = !progression.inactivated.Contains(internalName);
            return false; // Skip original method
        }
        catch (System.Exception ex)
        {
            MelonLogger.Error($"[TogglePatches.IsActivated] Error: {ex.Message}");
            return true;
        }
    }

   /// <summary>
    /// Patch to banish (disable) inactivated items when a run starts.
    /// Must be manually patched since RunUnlockables type may not be available at compile time.
    /// </summary>
    private static void RunUnlockables_OnNewRunStarted_Postfix()
    {
        if (!_patchesEnabled) return;

        try
        {
            var saveManager = SaveManager.Instance;
            if ((Object)(object)saveManager == (Object)null)
            {
                return;
            }

            ProgressionSaveFile progression = saveManager.progression;
            if (progression == null)
            {
                return;
            }

            if (progression.inactivated.Count == 0)
            {
                return;
            }

            var dataManager = DataManager.Instance;
            if ((Object)(object)dataManager == (Object)null)
            {
                return;
            }

            // Get first weapon to exclude it from banishment
            WeaponData firstWeapon = null;
            try
            {
                var player = Il2CppAssets.Scripts.Actors.Player.MyPlayer.Instance;
                if (player != null)
                {
                    var characterData = dataManager.characterData[player.character];
                    if (characterData != null)
                    {
                        firstWeapon = characterData.weapon;
                    }
                }
            }
            catch
            {
                // Ignore if we can't get the first weapon
            }

            MelonLogger.Msg("[TogglePatches] Banishing inactivated items:");

            var enumerator = progression.inactivated.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string inactivatedName = enumerator.Current;

                // Check if it's an upgradable (weapon/tome)
                if (dataManager.unsortedUnlockables != null)
                {
                    var unlockableEnumerator = dataManager.unsortedUnlockables.GetEnumerator();
                    while (unlockableEnumerator.MoveNext())
                    {
                        var unlockable = unlockableEnumerator.Current;
                        if (unlockable != null && 
                            unlockable.GetInternalName() == inactivatedName &&
                            (Object)(object)unlockable != (Object)(object)firstWeapon &&
                            unlockable.IsModTogglable())
                        {
                            // Use AccessTools to call RunUnlockables.BanishUpgradable
                            var runUnlockablesType = SafeTypeByName("Il2CppAssets.Scripts.Inventory__Items__Pickups.RunUnlockables");
                            if (runUnlockablesType != null)
                            {
                                var banishMethod = AccessTools.Method(runUnlockablesType, "BanishUpgradable");
                                if (banishMethod != null)
                                {
                                    banishMethod.Invoke(null, new object[] { unlockable });
                                    MelonLogger.Msg($"  - {((Object)unlockable).name} / {unlockable.GetInternalName()} (Upgradable)");
                                }
                            }
                            break;
                        }
                    }
                }

                // Check if it's an item
                if (dataManager.unsortedItems != null)
                {
                    var itemEnumerator = dataManager.unsortedItems.GetEnumerator();
                    while (itemEnumerator.MoveNext())
                    {
                        var item = itemEnumerator.Current;
                        if (item != null && ((UnlockableBase)item).GetInternalName() == inactivatedName)
                        {
                            // Use AccessTools to call RunUnlockables.BanishItem
                            var runUnlockablesType = SafeTypeByName("Il2CppAssets.Scripts.Inventory__Items__Pickups.RunUnlockables");
                            if (runUnlockablesType != null)
                            {
                                var banishMethod = AccessTools.Method(runUnlockablesType, "BanishItem");
                                if (banishMethod != null)
                                {
                                    banishMethod.Invoke(null, new object[] { item });
                                    MelonLogger.Msg($"  - {((Object)item).name} / {((UnlockableBase)item).GetInternalName()} (Item)");
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
        catch (System.Exception ex)
        {
            MelonLogger.Error($"[TogglePatches.OnNewRunStarted] Error: {ex.Message}");
        }
    }

    /// <summary>
    /// Manually patches the RunUnlockables.OnNewRunStarted method at runtime.
    /// This is necessary because the type isn't available at compile time.
    /// </summary>
    public static void ApplyRunUnlockablesPatch(HarmonyLib.Harmony harmony)
    {
        try
        {
            // Use AccessTools to find the type - it works better with IL2CPP
            var runUnlockablesType = SafeTypeByName("Il2CppAssets.Scripts.Inventory__Items__Pickups.RunUnlockables");
            if (runUnlockablesType != null)
            {
                var originalMethod = AccessTools.Method(runUnlockablesType, "OnNewRunStarted");
                if (originalMethod != null)
                {
                    var postfixMethod = AccessTools.Method(typeof(TogglePatches), nameof(RunUnlockables_OnNewRunStarted_Postfix));
                    harmony.Patch(originalMethod, postfix: new HarmonyMethod(postfixMethod));
                    MelonLogger.Msg("[TogglePatches] Successfully patched RunUnlockables.OnNewRunStarted");
                }
                else
                {
                    MelonLogger.Warning("[TogglePatches] Could not find RunUnlockables.OnNewRunStarted method");
                }
            }
            else
            {
                MelonLogger.Warning("[TogglePatches] Could not find RunUnlockables type");
            }
        }
        catch (System.Exception ex)
        {
            MelonLogger.Error($"[TogglePatches] Failed to patch RunUnlockables: {ex.Message}");
        }
    }
}
