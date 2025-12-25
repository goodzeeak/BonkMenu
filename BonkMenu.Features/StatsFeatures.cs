using BonkMenu.Core;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace BonkMenu.Features;

/// <summary>
/// Runtime stat helpers for toggles and direct manipulation.
/// </summary>
public static class StatsFeatures
{
	private static bool _hasLoggedUpdateError;

    /// <summary>
    /// Applies runtime toggles (e.g., infinite jumps, free purchases).
    /// </summary>
    public static void Update()
	{
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
			if (stats != null)
			{
				if (ModConfig.InfiniteJumps)
				{
					stats[(EStat)46] = 999f;
				}
				if (ModConfig.FreePurchases)
				{
					stats[(EStat)34] = 0f;
					stats[(EStat)35] = 1f;
				}
			}
		}
		catch (Exception ex)
		{
			if (!_hasLoggedUpdateError)
			{
				MelonLogger.Error("[StatsFeatures.Update] Error (will not log again): " + ex.Message);
				_hasLoggedUpdateError = true;
			}
		}
	}

    /// <summary>
    /// Sets a player stat value.
    /// </summary>
    public static void SetStat(EStat stat, float value)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		Log.Info($"[SetStat] Setting {stat} to {value}");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[SetStat] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[SetStat] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[SetStat] Player inventory is null!");
				return;
			}
			PlayerStatsNew playerStats = inventory.playerStats;
			if (playerStats == null)
			{
				MelonLogger.Error("[SetStat] PlayerStats is null!");
				return;
			}
			Dictionary<EStat, float> stats = playerStats.stats;
			if (stats == null)
			{
				MelonLogger.Error("[SetStat] Stats dictionary is null!");
				return;
			}
			float value2 = (stats.ContainsKey(stat) ? stats[stat] : 0f);
			stats[stat] = value;
			Log.Info($"[SetStat] Successfully set {stat} from {value2} to {value}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SetStat] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[SetStat] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Gets a player stat value, or 0 if unavailable.
    /// </summary>
    public static float GetStat(EStat stat)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			GameManager instance = GameManager.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				MyPlayer player = instance.player;
				if (player == null)
				{
					obj = null;
				}
				else
				{
					PlayerInventory inventory = player.inventory;
					if (inventory == null)
					{
						obj = null;
					}
					else
					{
						PlayerStatsNew playerStats = inventory.playerStats;
						obj = ((playerStats != null) ? playerStats.stats : null);
					}
				}
			}
			Dictionary<EStat, float> val = (Dictionary<EStat, float>)obj;
			if (val != null && val.ContainsKey(stat))
			{
				return val[stat];
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[GetStat] Error getting {stat}: {ex.Message}");
		}
		return 0f;
	}
}
