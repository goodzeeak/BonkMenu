using System;
using BonkMenu.Core;
using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(MyButtonOffersUtility))]
public class UtilityButtonPatches
{
	private static bool _hasLoggedInfiniteRefreshes;

	private static bool _hasLoggedError;

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
			if (!_hasLoggedInfiniteRefreshes)
			{
				MelonLogger.Msg("[UtilityButtonPatches] Infinite refreshes active - making buttons always affordable");
				_hasLoggedInfiniteRefreshes = true;
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
				MelonLogger.Error("[UtilityButtonPatches.SetAmount] Error: " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}

	[HarmonyPatch("OnClick")]
	[HarmonyPrefix]
	public static bool OnClick_Prefix(MyButtonOffersUtility __instance)
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
				MelonLogger.Error("[UtilityButtonPatches.OnClick] Error: " + ex.Message);
				_hasLoggedError = true;
			}
			return true;
		}
	}
}
