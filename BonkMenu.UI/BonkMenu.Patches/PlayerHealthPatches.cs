using System;
using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using MelonLoader;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(PlayerHealth))]
public class PlayerHealthPatches
{


	private static bool _hasLoggedError;

	[HarmonyPatch("DamagePlayer")]
	[HarmonyPrefix]
	public static bool DamagePlayer_Prefix(PlayerHealth __instance)
	{
		try
		{
			if (ModConfig.InfiniteHealth || ModConfig.GodMode)
			{

				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[BonkMenu] PlayerHealthPatches.DamagePlayer error: " + ex.Message);
				_hasLoggedError = true;
			}
			return true;
		}
	}

	[HarmonyPatch("DamagePlayerExternal")]
	[HarmonyPrefix]
	public static bool DamagePlayerExternal_Prefix(PlayerHealth __instance)
	{
		try
		{
			if (ModConfig.InfiniteHealth || ModConfig.GodMode)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[BonkMenu] PlayerHealthPatches.DamagePlayerExternal error: " + ex.Message);
				_hasLoggedError = true;
			}
			return true;
		}
	}

	[HarmonyPatch("KillPlayer")]
	[HarmonyPrefix]
	public static bool KillPlayer_Prefix(PlayerHealth __instance)
	{
		try
		{
			if (ModConfig.InfiniteHealth || ModConfig.GodMode)
			{

				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[BonkMenu] PlayerHealthPatches.KillPlayer CRITICAL: " + ex.Message);
			MelonLogger.Error("[BonkMenu] Stack Trace: " + ex.StackTrace);
			return true;
		}
	}
	public static void Apply(HarmonyLib.Harmony harmony)
	{
		try
		{
			harmony.PatchAll(typeof(PlayerHealthPatches));
			MelonLogger.Msg("[PlayerHealthPatches] ✅ PlayerHealth patched (God Mode/Infinite Health enabled)");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[PlayerHealthPatches] Failed to patch: {ex.Message}");
		}
	}
}
