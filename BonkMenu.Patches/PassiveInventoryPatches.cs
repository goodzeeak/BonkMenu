using System;
using System.Linq;
using BonkMenu.Features;
using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using MelonLoader;

namespace BonkMenu.Patches;

[HarmonyPatch]
public static class PassiveInventoryPatches
{
	// Patch the passive ability setter to add to our collection instead of replacing
	[HarmonyPrefix]
	[HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.passiveAbility), MethodType.Setter)]
	public static bool SetPassiveAbility_Prefix(PlayerInventory __instance, PassiveAbility value)
	{
		try
		{
			if (value != null)
			{
				MelonLogger.Msg($"[PassiveInventoryPatches] Intercepting passive set: {value.GetPassiveType()}");
				
				// Clean up old passive from game's single slot if it exists
				if (__instance.passiveAbility != null && !MultiPassiveManager.GetPassives(__instance).Contains(__instance.passiveAbility))
				{
					try
					{
						__instance.passiveAbility.Cleanup();
					}
					catch (Exception ex)
					{
						MelonLogger.Warning($"[PassiveInventoryPatches] Error cleaning up old passive: {ex.Message}");
					}
				}
				
				// Add to our multi-passive collection
				MultiPassiveManager.AddPassive(__instance, value);
				
				// Still set it in the game's slot so the game knows *a* passive is equipped
				// (some game logic might check if passiveAbility != null)
			}
			
			// Allow the original setter to run so game's internal state is updated
			return true;
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[PassiveInventoryPatches] Error in SetPassiveAbility: {ex.Message}");
			return true; // Let original run on error
		}
	}

	// Patch HasPassive to check our collection
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
			MelonLogger.Error($"[PassiveInventoryPatches] Error in HasPassive: {ex.Message}");
			return true; // Let original run on error
		}
	}

	// Patch Update to update all active passives
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
					MelonLogger.Warning($"[PassiveInventoryPatches] Error updating passive {passive.GetPassiveType()}: {ex.Message}");
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[PassiveInventoryPatches] Error in Update: {ex.Message}");
		}
	}

	// Patch PhysicsTick to physics-update all active passives  
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
					MelonLogger.Warning($"[PassiveInventoryPatches] Error in PhysicsTick for passive {passive.GetPassiveType()}: {ex.Message}");
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[PassiveInventoryPatches] Error in PhysicsTick: {ex.Message}");
		}
	}

	// Patch Cleanup to clean up all passives
	[HarmonyPostfix]
	[HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.Cleanup))]
	public static void Cleanup_Postfix(PlayerInventory __instance)
	{
		try
		{
			MelonLogger.Msg("[PassiveInventoryPatches] Cleaning up all passives");
			var passives = MultiPassiveManager.GetPassives(__instance);
			foreach (var passive in passives.Where(p => p != null))
			{
				try
				{
					passive.Cleanup();
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[PassiveInventoryPatches] Error cleaning up passive {passive.GetPassiveType()}: {ex.Message}");
				}
			}
			MultiPassiveManager.ClearPassives(__instance);
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[PassiveInventoryPatches] Error in Cleanup: {ex.Message}");
		}
	}
}
