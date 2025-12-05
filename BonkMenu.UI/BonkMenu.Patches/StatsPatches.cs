using System.Collections.Generic;
using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using MelonLoader;

namespace BonkMenu.Patches;

/// <summary>
/// Modifies player stat calculations and clamps to support custom values.
/// </summary>
[HarmonyPatch(typeof(PlayerStatsNew))]
public class StatsPatches
{
	private static bool _hasLoggedError;
	
	// Store custom stat values as OFFSETS from base values (public so XpPatches can access)
    /// <summary>
    /// Custom stat offsets applied on top of base values.
    /// </summary>
    public static Dictionary<EStat, float> _customStatOffsets = new Dictionary<EStat, float>();

	// Public method to set a stat to an absolute value
    /// <summary>
    /// Sets a stat to an absolute value by computing and storing its offset.
    /// </summary>
    public static void SetStatAbsolute(EStat stat, float value)
	{
		float baseValue = PlayerStatsNew.GetBaseValue(stat);
		float offset = value - baseValue;
		_customStatOffsets[stat] = offset;

	}

    /// <summary>
    /// Postfix that applies custom offsets and special toggles to stat values.
    /// </summary>
    [HarmonyPatch("GetStat")]
    [HarmonyPostfix]
    public static void GetStat_Postfix(EStat stat, ref float __result)
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
                Log.Error("StatsPatches.GetStat error: " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}

    /// <summary>
    /// Prefix that bypasses clamping and returns the raw value.
    /// </summary>
    [HarmonyPatch("CheckFinalValue")]
    [HarmonyPrefix]
    public static bool CheckFinalValue_Prefix(EStat stat, float value, ref float __result)
{
    _ = stat;
    //IL_0000: Unknown result type (might be due to invalid IL or missing references)
    try
    {
			// Bypass clamping for ALL stats - let players go wild!
			__result = value;
			return false; // Skip original method - NO CAPS ON ANYTHING!
		}
		catch (Exception ex)
		{
            Log.Warn($"StatsPatches clamp bypass error: {ex.Message}");
		}
		
		return true; // Run original method only on error
	}
	
    /// <summary>
    /// Postfix that applies custom offsets to unclamped stat queries.
    /// </summary>
    [HarmonyPatch("GetUnclampedStat")]
    [HarmonyPostfix]
    public static void GetUnclampedStat_Postfix(EStat stat, ref float __result)
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

			}
		}
		catch (Exception ex)
		{
            Log.Warn($"StatsPatches.GetUnclampedStat error: {ex.Message}");
		}
	}
}
