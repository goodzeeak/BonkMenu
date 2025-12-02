using System.Linq;
using BonkMenu.Features;
using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using MelonLoader;

namespace BonkMenu.Patches;

/// <summary>
/// Supports multiple passive abilities on the player inventory.
/// </summary>
[HarmonyPatch]
public static class PassiveInventoryPatches
{
	// Patch HasPassive to check our collection
    /// <summary>
    /// Prefix that resolves multi-passive state against the inventory.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.HasPassive))]
    public static bool HasPassive_Prefix(PlayerInventory __instance, EPassive passive, ref bool __result)
	{
		try
		{
			__result = MultiPassiveManager.HasPassive(__instance, passive);
			return false; // Skip original method
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[BonkMenu] PassiveInventoryPatches.HasPassive error: {ex.Message}");
			return true; // Let original run on error
		}
	}

	// Patch Update to update all active passives
    /// <summary>
    /// Postfix that ticks all active passives.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.Update))]
    public static void Update_Postfix(PlayerInventory __instance)
	{
		try
		{
			var passives = MultiPassiveManager.GetPassives(__instance);
			foreach (var passive in passives.Where(p => p != null))
			{
				try
				{
					passive.Tick();
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[BonkMenu] PassiveInventoryPatches passive update error: {ex.Message}");
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[BonkMenu] PassiveInventoryPatches.Update error: {ex.Message}");
		}
	}

	// Patch PhysicsTick to physics-update all active passives  
    /// <summary>
    /// Postfix that performs physics ticks for passives when appropriate.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.PhysicsTick))]
    public static void PhysicsTick_Postfix(PlayerInventory __instance)
	{
		try
		{
			var passives = MultiPassiveManager.GetPassives(__instance);
			foreach (var passive in passives.Where(p => p != null))
			{
				try
				{
					passive.Tick(); // PassiveAbility has Tick(), not PhysicsTick
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[BonkMenu] PassiveInventoryPatches PhysicsTick error: {ex.Message}");
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[BonkMenu] PassiveInventoryPatches.PhysicsTick error: {ex.Message}");
		}
	}

	// Patch Cleanup to clean up all passives
    /// <summary>
    /// Postfix that cleans up all passives and clears the manager.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.Cleanup))]
    public static void Cleanup_Postfix(PlayerInventory __instance)
	{
		try
		{

			var passives = MultiPassiveManager.GetPassives(__instance);
			foreach (var passive in passives.Where(p => p != null))
			{
				try
				{
					passive.Cleanup();
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[BonkMenu] PassiveInventoryPatches cleanup error: {ex.Message}");
				}
			}
			MultiPassiveManager.ClearPassives(__instance);
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[BonkMenu] PassiveInventoryPatches.Cleanup error: {ex.Message}");
		}
	}
}
