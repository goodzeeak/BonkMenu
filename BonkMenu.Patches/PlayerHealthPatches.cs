using System;
using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using MelonLoader;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(PlayerHealth))]
public class PlayerHealthPatches
{
	private static bool _hasLoggedDamageBlock;

	private static bool _hasLoggedError;

	[HarmonyPatch("DamagePlayer")]
	[HarmonyPrefix]
	public static bool DamagePlayer_Prefix(PlayerHealth __instance)
	{
		try
		{
			if (ModConfig.InfiniteHealth || ModConfig.GodMode)
			{
				if (!_hasLoggedDamageBlock)
				{
					MelonLogger.Msg("[PlayerPatches] God mode active - blocking damage");
					_hasLoggedDamageBlock = true;
				}
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[PlayerPatches.DamagePlayer] Error (will not log again): " + ex.Message);
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
				MelonLogger.Error("[PlayerPatches.DamagePlayerExternal] Error: " + ex.Message);
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
				MelonLogger.Msg("[PlayerPatches] God mode prevented instant death");
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[PlayerPatches.KillPlayer] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[PlayerPatches.KillPlayer] Stack Trace: " + ex.StackTrace);
			return true;
		}
	}
}
