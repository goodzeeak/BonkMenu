using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using BonkMenu.Core;

namespace BonkMenu.Patches;

/// <summary>
/// Patches to override GetMaxLevel() for weapons and tomes to return int.MaxValue
/// </summary>
public static class LevelCapPatches
{
	[HarmonyPatch(typeof(WeaponData), nameof(WeaponData.GetMaxLevel))]
    public static class WeaponData_GetMaxLevel_Patch
    {
        public static bool Prefix(Il2Cpp.WeaponData __instance, ref int __result)
        {
            if (ModConfig.UnlimitedWeaponLevels)
            {
                __result = int.MaxValue;
                return false; // Skip original method
            }
            try
            {
                var name = ((object)__instance)?.ToString(); // fallback to name
                // Prefer Unity name property if available
                if (__instance != null && __instance.name != null)
                {
                    name = __instance.name;
                }
                if (!string.IsNullOrEmpty(name) && BonkMenu.Core.ModConfig.UnlimitedWeaponNames.Contains(name))
                {
                    __result = int.MaxValue;
                    return false;
                }
            }
            catch { }
            return true; // Execute original method
        }
    }

	[HarmonyPatch(typeof(TomeData), nameof(TomeData.GetMaxLevel))]
    public static class TomeData_GetMaxLevel_Patch
    {
        public static bool Prefix(Il2Cpp.TomeData __instance, ref int __result)
        {
            if (ModConfig.UnlimitedTomeLevels)
            {
                __result = int.MaxValue;
                return false; // Skip original method
            }
            try
            {
                var name = ((object)__instance)?.ToString();
                if (__instance != null && __instance.name != null)
                {
                    name = __instance.name;
                }
                if (!string.IsNullOrEmpty(name) && BonkMenu.Core.ModConfig.UnlimitedTomeNames.Contains(name))
                {
                    __result = int.MaxValue;
                    return false;
                }
            }
            catch { }
            return true; // Execute original method
        }
    }

	public static void Apply(HarmonyLib.Harmony harmony)
	{
        try
        {
            harmony.PatchAll(typeof(WeaponData_GetMaxLevel_Patch));
            BonkMenu.Core.Log.Info("[LevelCapPatches] ✅ WeaponData.GetMaxLevel patched - max level set to int.MaxValue");
        }
        catch (System.Exception ex)
        {
            BonkMenu.Core.Log.Error($"[LevelCapPatches] Failed to patch WeaponData.GetMaxLevel: {ex.Message}");
        }

        try
        {
            harmony.PatchAll(typeof(TomeData_GetMaxLevel_Patch));
            BonkMenu.Core.Log.Info("[LevelCapPatches] ✅ TomeData.GetMaxLevel patched - max level set to int.MaxValue");
        }
        catch (System.Exception ex)
        {
            BonkMenu.Core.Log.Error($"[LevelCapPatches] Failed to patch TomeData.GetMaxLevel: {ex.Message}");
        }
	}
}
