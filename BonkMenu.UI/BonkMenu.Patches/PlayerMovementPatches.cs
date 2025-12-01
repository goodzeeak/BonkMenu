using System;
using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Player.Movement;
using MelonLoader;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(PlayerMovementValues))]
public class PlayerMovementPatches
{


	private static bool _hasLoggedError;

	[HarmonyPatch("GetGravity")]
	[HarmonyPostfix]
	public static void GetGravity_Postfix(ref float __result)
	{
		try
		{
			if (ModConfig.FlightMode)
			{

				__result = 0f;
			}
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[BonkMenu] PlayerMovementPatches.GetGravity error: " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}
	public static void Apply(HarmonyLib.Harmony harmony)
	{
		try
		{
			harmony.PatchAll(typeof(PlayerMovementPatches));
			MelonLogger.Msg("[PlayerMovementPatches] ✅ PlayerMovementValues.GetGravity patched");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[PlayerMovementPatches] Failed to patch: {ex.Message}");
		}
	}
}
