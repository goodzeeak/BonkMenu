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
		public static bool Prefix(ref int __result)
		{
			if (ModConfig.UnlimitedLevels)
			{
				__result = int.MaxValue;
				return false; // Skip original method
			}
			return true; // Execute original method
		}
	}

	[HarmonyPatch(typeof(TomeData), nameof(TomeData.GetMaxLevel))]
	public static class TomeData_GetMaxLevel_Patch
	{
		public static bool Prefix(ref int __result)
		{
			if (ModConfig.UnlimitedLevels)
			{
				__result = int.MaxValue;
				return false; // Skip original method
			}
			return true; // Execute original method
		}
	}

	public static void Apply(HarmonyLib.Harmony harmony)
	{
		try
		{
			harmony.PatchAll(typeof(WeaponData_GetMaxLevel_Patch));
			MelonLogger.Msg("[LevelCapPatches] ✅ WeaponData.GetMaxLevel patched - max level set to int.MaxValue");
		}
		catch (System.Exception ex)
		{
			MelonLogger.Error($"[LevelCapPatches] Failed to patch WeaponData.GetMaxLevel: {ex.Message}");
		}

		try
		{
			harmony.PatchAll(typeof(TomeData_GetMaxLevel_Patch));
			MelonLogger.Msg("[LevelCapPatches] ✅ TomeData.GetMaxLevel patched - max level set to int.MaxValue");
		}
		catch (System.Exception ex)
		{
			MelonLogger.Error($"[LevelCapPatches] Failed to patch TomeData.GetMaxLevel: {ex.Message}");
		}
	}
}
