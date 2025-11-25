using System;
using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Player.Movement;
using MelonLoader;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(PlayerMovementValues))]
public class PlayerMovementPatches
{
	private static bool _hasLoggedFlightMode;

	private static bool _hasLoggedError;

	[HarmonyPatch("GetGravity")]
	[HarmonyPostfix]
	public static void GetGravity_Postfix(ref float __result)
	{
		try
		{
			if (ModConfig.FlightMode)
			{
				if (!_hasLoggedFlightMode)
				{
					MelonLogger.Msg("[PlayerMovementPatches] Flight mode active - disabling gravity");
					_hasLoggedFlightMode = true;
				}
				__result = 0f;
			}
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[PlayerMovementPatches.GetGravity] Error: " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}
}
