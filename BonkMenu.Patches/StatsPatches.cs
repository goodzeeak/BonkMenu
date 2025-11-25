using System;
using System.Collections.Generic;
using BonkMenu.Core;
using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppSystem;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(PlayerStatsNew))]
public class StatsPatches
{
	private static bool _hasLoggedError;
	
	// Store custom stat values as OFFSETS from base values (public so XpPatches can access)
	public static Dictionary<EStat, float> _customStatOffsets = new Dictionary<EStat, float>();

	// Public method to set a stat to an absolute value
	public static void SetStatAbsolute(EStat stat, float value)
	{
		float baseValue = PlayerStatsNew.GetBaseValue(stat);
		float offset = value - baseValue;
		_customStatOffsets[stat] = offset;
		MelonLogger.Msg($"[StatsPatches] Set absolute: {stat} = {value} (base: {baseValue}, offset: {offset})");
	}

	[HarmonyPatch("GetStat")]
	[HarmonyPostfix]
	public static void GetStat_Postfix(PlayerStatsNew __instance, EStat stat, ref float __result)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			// Apply our custom offset on top of whatever the game calculated
			if (_customStatOffsets.ContainsKey(stat))
			{
				float baseValue = PlayerStatsNew.GetBaseValue(stat);
				float finalValue = baseValue + _customStatOffsets[stat];
				__result = finalValue;
				
				// Debug log for XP multiplier (stat 33)
				if ((int)stat == 33)
				{
					MelonLogger.Msg($"[GetStat] XP Mult: base={baseValue}, offset={_customStatOffsets[stat]}, final={finalValue}");
				}
			}
			
			if ((int)stat != 34)
			{
				if ((int)stat != 35)
				{
					if ((int)stat == 46 && ModConfig.InfiniteJumps)
					{
						__result = 999f;
					}
				}
				else if (ModConfig.FreePurchases)
				{
					__result = 1f;
				}
			}
			else if (ModConfig.FreePurchases)
			{
				__result = 0f;
			}
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[StatsPatches.GetStat] Error (will not log again): " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}

	[HarmonyPatch("CheckFinalValue")]
	[HarmonyPrefix]
	public static bool CheckFinalValue_Prefix(EStat stat, float value, ref float __result)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			// Bypass clamping for ALL stats - let players go wild!
			__result = value;
			return false; // Skip original method - NO CAPS ON ANYTHING!
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[StatsPatches.CheckFinalValue] Error bypassing clamp for stat {stat}: {ex.Message}");
		}
		
		return true; // Run original method only on error
	}
	
	[HarmonyPatch("GetUnclampedStat")]
	[HarmonyPostfix]
	public static void GetUnclampedStat_Postfix(PlayerStatsNew __instance, EStat stat, ref float __result)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			// Apply our custom offset for unclamped stat queries too!
			if (_customStatOffsets.ContainsKey(stat))
			{
				float baseValue = PlayerStatsNew.GetBaseValue(stat);
				float finalValue = baseValue + _customStatOffsets[stat];
				__result = finalValue;
				
				// Debug log for XP multiplier (stat 33)
				if ((int)stat == 33)
				{
					MelonLogger.Msg($"[GetUnclampedStat] XP Mult: base={baseValue}, offset={_customStatOffsets[stat]}, final={finalValue}");
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[StatsPatches.GetUnclampedStat] Error: {ex.Message}");
		}
	}
}
