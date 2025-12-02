using BonkMenu.Core;
using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using MelonLoader;

namespace BonkMenu.Patches;

/// <summary>
/// Ensures utility shop buttons respect InfiniteRefreshes.
/// </summary>
[HarmonyPatch(typeof(MyButtonOffersUtility))]
public class UtilityButtonPatches
{


	private static bool _hasLoggedError;

    /// <summary>
    /// Postfix that resets utility limits and grants resources.
    /// </summary>
    [HarmonyPatch("SetAmount")]
    [HarmonyPostfix]
    public static void SetAmount_Postfix(MyButtonOffersUtility __instance)
	{
		try
		{
			if (!ModConfig.InfiniteRefreshes)
			{
				return;
			}

			__instance.cantAfford = false;
			__instance.refreshedAtTime = 0f;
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				return;
			}
			MyPlayer player = instance.player;
			if (!((Object)(object)player == (Object)null))
			{
				PlayerInventory inventory = player.inventory;
				if (inventory != null)
				{
					inventory.refreshes = 999;
					inventory.banishes = 999;
					inventory.skips = 999;
				}
			}
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[BonkMenu] UtilityButtonPatches.SetAmount error: " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}

    /// <summary>
    /// Prefix that tops up refreshes/banishes/skips on click.
    /// </summary>
    [HarmonyPatch("OnClick")]
    [HarmonyPrefix]
    public static bool OnClick_Prefix()
	{
		try
		{
			if (!ModConfig.InfiniteRefreshes)
			{
				return true;
			}
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance != (Object)null && (Object)(object)instance.player != (Object)null && instance.player.inventory != null)
			{
				instance.player.inventory.refreshes = 999;
				instance.player.inventory.banishes = 999;
				instance.player.inventory.skips = 999;
			}
			return true;
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[BonkMenu] UtilityButtonPatches.OnClick error: " + ex.Message);
				_hasLoggedError = true;
			}
			return true;
		}
	}
}
