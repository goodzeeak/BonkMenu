using System.Reflection;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppAssets.Scripts.Saves___Serialization.SaveFiles;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Features;

/// <summary>
/// Player utilities for healing, pickups, currency, status effects, and stats.
/// </summary>
public static class PlayerFeatures
{
    /// <summary>
    /// Fully heals HP and Shield to their maximum values.
    /// </summary>
    public static void FullHeal()
	{
		BonkMenu.Core.Log.Info("[FullHeal] Starting full heal...");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[FullHeal] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[FullHeal] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[FullHeal] Player inventory is null!");
				return;
			}
			PlayerHealth playerHealth = inventory.playerHealth;
			if (playerHealth == null)
			{
				MelonLogger.Error("[FullHeal] PlayerHealth is null!");
				return;
			}
			BonkMenu.Core.Log.Info($"[FullHeal] Current HP: {playerHealth.hp}/{playerHealth.maxHp}, Shield: {playerHealth.shield}/{playerHealth.maxShield}");
			playerHealth.hp = playerHealth.maxHp;
			playerHealth.shield = playerHealth.maxShield;
			BonkMenu.Core.Log.Info($"[FullHeal] Successfully healed! HP: {playerHealth.hp}/{playerHealth.maxHp}, Shield: {playerHealth.shield}/{playerHealth.maxShield}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[FullHeal] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[FullHeal] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Spawns a pickup of the given type near the player.
    /// </summary>
    public static void SpawnPickup(EPickup type, int amount, string itemName)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		BonkMenu.Core.Log.Info($"[SpawnPickup] Spawning {itemName} with value {amount}");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[SpawnPickup] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[SpawnPickup] Player is null!");
				return;
			}
			PickupManager instance2 = PickupManager.Instance;
			if ((Object)(object)instance2 == (Object)null)
			{
				MelonLogger.Error("[SpawnPickup] PickupManager.Instance is null!");
				return;
			}
			Vector3 val = ((Component)player).transform.position + new Vector3(0f, 1f, 0f);
			BonkMenu.Core.Log.Info($"[SpawnPickup] Spawn position: {val}");
			instance2.SpawnPickup(type, val, amount, true, 0f);
			BonkMenu.Core.Log.Info($"[SpawnPickup] Successfully spawned {itemName} (Value: {amount})");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SpawnPickup] CRITICAL ERROR spawning " + itemName + ": " + ex.Message);
			MelonLogger.Error("[SpawnPickup] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Adds silver (progression currency) to the save file.
    /// </summary>
    public static void AddProgressionCurrency(int amount)
	{
		BonkMenu.Core.Log.Info($"[AddProgressionCurrency] Adding {amount} silver");
		try
		{
			SaveManager instance = SaveManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[AddProgressionCurrency] SaveManager.Instance is null!");
				return;
			}
			ProgressionSaveFile progression = instance.progression;
			if (progression == null)
			{
				MelonLogger.Error("[AddProgressionCurrency] Progression save file is null!");
				return;
			}
			PropertyInfo property = typeof(ProgressionSaveFile).GetProperty("silver");
			if (property == null)
			{
				MelonLogger.Error("[AddProgressionCurrency] Could not find 'silver' property!");
				return;
			}
			int num = (int)property.GetValue(progression);
			int num2 = num + amount;
			BonkMenu.Core.Log.Info($"[AddProgressionCurrency] Current: {num}, Adding: {amount}, New: {num2}");
			property.SetValue(progression, num2);
			instance.SaveProgression();
			BonkMenu.Core.Log.Info("[AddProgressionCurrency] Successfully saved progression with new silver amount");
			TryInvokeSilverChangedEvent(num2);
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[AddProgressionCurrency] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[AddProgressionCurrency] Stack Trace: " + ex.StackTrace);
		}
	}

	private static void TryInvokeSilverChangedEvent(int newValue)
	{
		BonkMenu.Core.Log.Info("[TryInvokeSilverChangedEvent] Attempting to invoke UI update event");
		try
		{
			object obj = null;
			FieldInfo field = typeof(ProgressionSaveFile).GetField("A_SilverChanged", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field != null)
			{
				obj = field.GetValue(null);
				BonkMenu.Core.Log.Info("[TryInvokeSilverChangedEvent] Found A_SilverChanged as Field");
			}
			else
			{
				PropertyInfo property = typeof(ProgressionSaveFile).GetProperty("A_SilverChanged", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				if (property != null)
				{
					obj = property.GetValue(null);
					BonkMenu.Core.Log.Info("[TryInvokeSilverChangedEvent] Found A_SilverChanged as Property");
				}
			}
			if (obj != null)
			{
				Il2CppSystem.Action<int> val = obj as Il2CppSystem.Action<int>;
				if ((Delegate)(object)val != (Delegate)null)
				{
					val.Invoke(newValue);
					BonkMenu.Core.Log.Info($"[TryInvokeSilverChangedEvent] Successfully invoked event with value: {newValue}");
				}
				else
				{
					MelonLogger.Warning("[TryInvokeSilverChangedEvent] Event object is not Action<int>, Type: " + obj.GetType().FullName);
				}
			}
			else
			{
				MelonLogger.Warning("[TryInvokeSilverChangedEvent] Could not find A_SilverChanged event");
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("[TryInvokeSilverChangedEvent] Error invoking event: " + ex.Message);
		}
	}

    /// <summary>
    /// Removes all active status effects from the player.
    /// </summary>
    public static void ClearAllStatusEffects()
	{
		BonkMenu.Core.Log.Info("[ClearAllStatusEffects] Clearing all status effects");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[ClearAllStatusEffects] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[ClearAllStatusEffects] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[ClearAllStatusEffects] Player inventory is null!");
				return;
			}
			PlayerStatusEffects statusEffects = inventory.statusEffects;
			if (statusEffects == null)
			{
				MelonLogger.Error("[ClearAllStatusEffects] StatusEffects is null!");
				return;
			}
			statusEffects.RemoveAllStatusEffects();
			BonkMenu.Core.Log.Info("[ClearAllStatusEffects] Successfully cleared all status effects");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[ClearAllStatusEffects] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[ClearAllStatusEffects] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Sets a player stat to the specified value.
    /// </summary>
    public static void SetStat(EStat stat, float value)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		BonkMenu.Core.Log.Info($"[SetStat] Setting {stat} to {value}");
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
			stats[stat] = value;
			BonkMenu.Core.Log.Info($"[SetStat] Successfully set {stat} to {value}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SetStat] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[SetStat] Stack Trace: " + ex.StackTrace);
		}
	}
}
