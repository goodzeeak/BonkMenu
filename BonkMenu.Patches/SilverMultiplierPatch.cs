using HarmonyLib;
using BonkMenu.Features;
using Il2CppAssets.Scripts.Game.Other;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppAssets.Scripts.Actors.Player;
using Il2Cpp;
using MelonLoader;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(RunConfig), nameof(RunConfig.GetSilverMultiplier))]
public static class SilverMultiplierPatch
{
	public static void Postfix(ref float __result)
	{
		try
		{
			// Get the custom multiplier from our stats system (default 1.0 if not set)
			float customMult = StatsHelper.GetCurrentStatValue(EStat.SilverIncreaseMultiplier, 1f);
			
			// Apply it to the game's calculated multiplier
			if (customMult != 1f)
			{
				float original = __result;
				__result *= customMult;
				// MelonLogger.Msg($"[SilverMultiplierPatch] Applied custom multiplier: {customMult}. Result: {original} -> {__result}");
			}
		}
		catch (System.Exception ex)
		{
			MelonLogger.Error($"[SilverMultiplierPatch] Error: {ex.Message}");
		}
	}
}

[HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.AddSilver))]
public static class PlayerInventoryAddSilverPatch
{
	public static void Prefix(ref int amount)
	{
		try
		{
			float customMult = StatsHelper.GetCurrentStatValue(EStat.SilverIncreaseMultiplier, 1f);
			if (customMult > 1f)
			{
				int original = amount;
				amount = (int)(amount * customMult);
				MelonLogger.Msg($"[PlayerInventoryAddSilverPatch] Multiplied silver gain: {original} -> {amount} (Mult: {customMult})");
			}
		}
		catch (System.Exception ex)
		{
			MelonLogger.Error($"[PlayerInventoryAddSilverPatch] Error: {ex.Message}");
		}
	}
}
