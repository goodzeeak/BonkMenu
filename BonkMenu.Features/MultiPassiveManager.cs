using System.Collections.Generic;
using System.Linq;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using MelonLoader;

namespace BonkMenu.Features;

public static class MultiPassiveManager
{
	private static Dictionary<PlayerInventory, List<PassiveAbility>> multiPassives = new Dictionary<PlayerInventory, List<PassiveAbility>>();

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

	public static void AddPassive(PlayerInventory inventory, PassiveAbility passive)
	{
		if (inventory == null || passive == null)
		{
			return;
		}

		var passives = GetPassives(inventory);
		
		// Check if already have this passive type
		var existingPassive = passives.FirstOrDefault(p => p.GetPassiveType() == passive.GetPassiveType());
		if (existingPassive != null)
		{
			MelonLogger.Msg($"[MultiPassiveManager] Player already has passive {passive.GetPassiveType()}, skipping");
			return;
		}

		passives.Add(passive);
		MelonLogger.Msg($"[MultiPassiveManager] Added passive {passive.GetPassiveType()}. Total passives: {passives.Count}");
	}

	public static void RemovePassive(PlayerInventory inventory, PassiveAbility passive)
	{
		if (inventory == null || passive == null)
		{
			return;
		}

		var passives = GetPassives(inventory);
		passives.Remove(passive);
		MelonLogger.Msg($"[MultiPassiveManager] Removed passive. Total passives: {passives.Count}");
	}

	public static void ClearPassives(PlayerInventory inventory)
	{
		if (inventory == null)
		{
			return;
		}

		if (multiPassives.ContainsKey(inventory))
		{
			var passives = multiPassives[inventory];
			MelonLogger.Msg($"[MultiPassiveManager] Clearing {passives.Count} passives");
			passives.Clear();
			multiPassives.Remove(inventory);
		}
	}

	public static bool HasPassive(PlayerInventory inventory, EPassive ePassive)
	{
		var passives = GetPassives(inventory);
		return passives.Any(p => p != null && p.GetPassiveType() == ePassive);
	}
}
