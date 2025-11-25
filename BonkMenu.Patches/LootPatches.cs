using System;
using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using MelonLoader;

namespace BonkMenu.Patches;

public static class LootPatches
{
	[HarmonyPatch(typeof(Rarity), "GetUpgradeOfferRarity")]
	public static class Rarity_GetUpgradeOfferRarity_Patch
	{
		public static void Postfix(ref ERarity __result)
		{
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (LootConfig.ForceUpgradeRarity)
				{
					if (!_hasLoggedUpgradeRarity)
					{
						MelonLogger.Msg($"[LootPatches] Forcing upgrade rarity to: {LootConfig.DesiredUpgradeRarity}");
						_hasLoggedUpgradeRarity = true;
					}
					__result = (ERarity)(int)LootConfig.DesiredUpgradeRarity;
				}
			}
			catch (Exception ex)
			{
				if (!_hasLoggedError)
				{
					MelonLogger.Error("[LootPatches.GetUpgradeOfferRarity] Error: " + ex.Message);
					_hasLoggedError = true;
				}
			}
		}
	}

	[HarmonyPatch(typeof(Rarity), "GetItemRarity")]
	public static class Rarity_GetItemRarity_Patch
	{
		public static void Postfix(ref EItemRarity __result)
		{
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				if (LootConfig.ForceItemRarity)
				{
					if (!_hasLoggedItemRarity)
					{
						MelonLogger.Msg($"[LootPatches] Forcing item rarity to: {LootConfig.DesiredItemRarity}");
						_hasLoggedItemRarity = true;
					}
					__result = (EItemRarity)(int)LootConfig.DesiredItemRarity;
				}
			}
			catch (Exception ex)
			{
				if (!_hasLoggedError)
				{
					MelonLogger.Error("[LootPatches.GetItemRarity] Error: " + ex.Message);
					_hasLoggedError = true;
				}
			}
		}
	}

	[HarmonyPatch(typeof(PlayerStatsNew), "GetStat")]
	public static class PlayerStatsNew_GetStat_Patch
	{
		private static bool _hasLoggedMaxLuck;

		public static void Postfix(EStat stat, ref float __result)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Invalid comparison between Unknown and I4
			try
			{
				if (LootConfig.MaxLuck && (int)stat == 30)
				{
					if (!_hasLoggedMaxLuck)
					{
						MelonLogger.Msg("[LootPatches] Max luck active - setting luck to 100");
						_hasLoggedMaxLuck = true;
					}
					__result = 100f;
				}
			}
			catch (Exception ex)
			{
				if (!_hasLoggedError)
				{
					MelonLogger.Error("[LootPatches.GetStat] Error: " + ex.Message);
					_hasLoggedError = true;
				}
			}
		}
	}

	private static bool _hasLoggedUpgradeRarity;

	private static bool _hasLoggedItemRarity;

	private static bool _hasLoggedError;
}
