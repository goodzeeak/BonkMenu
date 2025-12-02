using System.Collections.Generic;
using System.Linq;
using Il2Cpp;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using BonkMenu.Core;
using HarmonyLib;

namespace BonkMenu.Features;

/// <summary>
/// Manages multiple passive abilities per player inventory.
/// </summary>
public static class MultiPassiveManager
{
	private static Dictionary<PlayerInventory, List<PassiveAbility>> multiPassives = new Dictionary<PlayerInventory, List<PassiveAbility>>();

    /// <summary>
    /// Gets the passive list associated with the inventory.
    /// </summary>
    public static List<PassiveAbility> GetPassives(PlayerInventory inventory)
	{
		if (inventory == null)
		{
			return new List<PassiveAbility>();
		}

		if (!multiPassives.ContainsKey(inventory))
		{
			multiPassives[inventory] = new List<PassiveAbility>();
		}

		return multiPassives[inventory];
	}

    /// <summary>
    /// Adds a passive to the inventory if not already present.
    /// </summary>
    public static void AddPassive(PlayerInventory inventory, PassiveAbility passive)
    {
        if (inventory == null || passive == null)
        {
            return;
        }

        var passives = GetPassives(inventory);
        var existing = passives.FirstOrDefault(p => p.GetPassiveType() == passive.GetPassiveType());
        if (existing != null)
        {
            if (TryLevelUpPassive(existing))
            {
                Log.Info($"[MultiPassiveManager] Leveled passive {existing.GetPassiveType()}");
                return;
            }
        }

        passives.Add(passive);
        try
        {
            passive.Init();
        }
        catch (System.Exception ex)
        {
            Log.Warn($"[MultiPassiveManager] Error initializing passive {passive.GetPassiveType()}: {ex.Message}");
        }
        Log.Info($"[MultiPassiveManager] Added passive {passive.GetPassiveType()}. Total passives: {passives.Count}");
    }

    private static bool TryLevelUpPassive(PassiveAbility passive)
    {
        try
        {
            var t = passive.GetType();
            var names = new string[] { "LevelUp", "IncreaseLevel", "AddLevel", "Upgrade", "IncrementLevel" };
            foreach (var n in names)
            {
                var m = AccessTools.Method(t, n);
                if (m != null && m.GetParameters().Length == 0)
                {
                    m.Invoke(passive, null);
                    InvokeIfExists(passive, new string[] { "OnLevelChanged", "ApplyLevel", "RecalculateStats", "Refresh" });
                    return true;
                }
            }

            var p = AccessTools.Property(t, "level") ?? AccessTools.Property(t, "Level");
            if (p != null)
            {
                var cur = p.GetValue(passive);
                if (cur is int ci)
                {
                    p.SetValue(passive, ci + 1);
                    InvokeIfExists(passive, new string[] { "OnLevelChanged", "ApplyLevel", "RecalculateStats", "Refresh" });
                    return true;
                }
            }

            var f = AccessTools.Field(t, "level") ?? AccessTools.Field(t, "Level");
            if (f != null)
            {
                var cur = f.GetValue(passive);
                if (cur is int ci)
                {
                    f.SetValue(passive, ci + 1);
                    InvokeIfExists(passive, new string[] { "OnLevelChanged", "ApplyLevel", "RecalculateStats", "Refresh" });
                    return true;
                }
            }
        }
        catch (System.Exception ex)
        {
            Log.Warn($"[MultiPassiveManager] TryLevelUpPassive error: {ex.Message}");
        }
        return false;
    }

    private static void InvokeIfExists(PassiveAbility passive, string[] methodNames)
    {
        var t = passive.GetType();
        foreach (var n in methodNames)
        {
            try
            {
                var m = AccessTools.Method(t, n);
                if (m != null && m.GetParameters().Length == 0)
                {
                    m.Invoke(passive, null);
                }
            }
            catch { }
        }
    }

    /// <summary>
    /// Removes a passive from the inventory.
    /// </summary>
    public static void RemovePassive(PlayerInventory inventory, PassiveAbility passive)
	{
		if (inventory == null || passive == null)
		{
			return;
		}

		var passives = GetPassives(inventory);
        passives.Remove(passive);
        Log.Info($"[MultiPassiveManager] Removed passive. Total passives: {passives.Count}");
    }

    /// <summary>
    /// Clears and removes all passives for the inventory.
    /// </summary>
    public static void ClearPassives(PlayerInventory inventory)
	{
		if (inventory == null)
		{
			return;
		}

		if (multiPassives.ContainsKey(inventory))
		{
            var passives = multiPassives[inventory];
            Log.Info($"[MultiPassiveManager] Clearing {passives.Count} passives");
            passives.Clear();
            multiPassives.Remove(inventory);
        }
    }

    /// <summary>
    /// Returns true if the inventory has a passive of the given type.
    /// </summary>
    public static bool HasPassive(PlayerInventory inventory, EPassive ePassive)
	{
		var passives = GetPassives(inventory);
		return passives.Any(p => p != null && p.GetPassiveType() == ePassive);
	}
}
