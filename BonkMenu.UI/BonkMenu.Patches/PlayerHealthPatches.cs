using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using MelonLoader;

namespace BonkMenu.Patches;

/// <summary>
/// Implements God Mode and Infinite Health protections.
/// </summary>
[HarmonyPatch(typeof(PlayerHealth))]
public class PlayerHealthPatches
{


	private static bool _hasLoggedError;

    /// <summary>
    /// Prevents incoming damage when enabled.
    /// </summary>
    [HarmonyPatch("DamagePlayer")]
    [HarmonyPrefix]
    public static bool DamagePlayer_Prefix()
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

    /// <summary>
    /// Prevents external damage sources when enabled.
    /// </summary>
    [HarmonyPatch("DamagePlayerExternal")]
    [HarmonyPrefix]
    public static bool DamagePlayerExternal_Prefix()
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

    /// <summary>
    /// Blocks player kill when protections are active.
    /// </summary>
    [HarmonyPatch("KillPlayer")]
    [HarmonyPrefix]
    public static bool KillPlayer_Prefix()
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
    /// <summary>
    /// Applies patches on PlayerHealth API.
    /// </summary>
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
