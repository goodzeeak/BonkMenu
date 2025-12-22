using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace BonkMenu.Features;

/// <summary>
/// Convenience helpers for reading and writing player stats.
/// </summary>
public static class StatsHelper
{
    /// <summary>
    /// Sets a stat and triggers a stat update event if available.
    /// </summary>
    public static void SetStatAndUpdate(EStat stat, float value)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				return;
			}
			PlayerStatsNew playerStats = inventory.playerStats;
			if (playerStats == null)
			{
				return;
			}
			Dictionary<EStat, float> stats = playerStats.stats;
			if (stats == null)
			{
				return;
			}
			stats[stat] = value;
			
			// Register this as a custom value using the new offset-based approach
			BonkMenu.Patches.StatsPatches.SetStatAbsolute(stat, value);
			
			// Try to invoke A_StatUpdate using Il2CppSystem.Action
			try
			{
				if (PlayerStatsNew.A_StatUpdate != null)
				{
					PlayerStatsNew.A_StatUpdate.Invoke(stat);
				}
			}
			catch
			{
				// Silently ignore if invoke fails
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[StatsHelper.SetStatAndUpdate] Error setting stat {stat}: {ex.Message}");
		}
	}

    /// <summary>
    /// Reads the current stat value or returns a default.
    /// </summary>
    public static float GetCurrentStatValue(EStat stat, float defaultValue = 0f)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				return defaultValue;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				return defaultValue;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				return defaultValue;
			}
			PlayerStatsNew playerStats = inventory.playerStats;
			if (playerStats == null)
			{
				return defaultValue;
			}
			Dictionary<EStat, float> stats = playerStats.stats;
			if (stats == null || !stats.ContainsKey(stat))
			{
				return defaultValue;
			}
			return stats[stat];
		}
		catch
		{
			return defaultValue;
		}
	}

    private static readonly EStat[] PercentageStats = new EStat[]
	{
		(EStat)4,
		(EStat)5,
		(EStat)15,
		(EStat)17,
		(EStat)18,
		(EStat)30,
		(EStat)38,
		(EStat)39,
		(EStat)41,
		(EStat)42,
		(EStat)43,
	};

    /// <summary>
    /// Returns true if the stat is displayed as a percentage.
    /// </summary>
    public static bool IsPercentageStat(EStat stat)
	{
		foreach (var pStat in PercentageStats)
		{
			if ((int)pStat == (int)stat) return true;
		}
		return false;
	}

    /// <summary>
    /// Returns a stat value formatted for display (percent-aware).
    /// </summary>
    public static float GetDisplayValue(EStat stat, float defaultValue = 0f)
	{
		float value = GetCurrentStatValue(stat, defaultValue);
		// Convert decimal to percentage for display (0.5 -> 50)
		return IsPercentageStat(stat) ? value * 100f : value;
	}

    /// <summary>
    /// Converts a display value into the stored value and sets it.
    /// </summary>
    public static void SetStatFromDisplay(EStat stat, float displayValue)
	{
		// Convert percentage to decimal for storage (50 -> 0.5)
		float actualValue = IsPercentageStat(stat) ? displayValue / 100f : displayValue;
		SetStatAndUpdate(stat, actualValue);
	}
}
