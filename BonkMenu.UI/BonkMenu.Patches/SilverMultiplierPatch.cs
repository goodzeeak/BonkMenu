using HarmonyLib;
using BonkMenu.Features;
using Il2CppAssets.Scripts.Game.Other;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2Cpp;
using MelonLoader;

namespace BonkMenu.Patches;

/// <summary>
/// Adjusts silver multiplier based on custom stat settings.
/// </summary>
[HarmonyPatch(typeof(RunConfig), nameof(RunConfig.GetSilverMultiplier))]
public static class SilverMultiplierPatch
{
    /// <summary>
    /// Postfix that multiplies the game's silver multiplier by a custom value.
    /// </summary>
    public static void Postfix(ref float __result)
	{
		try
		{
			// Get the custom multiplier from our stats system (default 1.0 if not set)
			float customMult = StatsHelper.GetCurrentStatValue(EStat.SilverIncreaseMultiplier, 1f);
			
			// Apply it to the game's calculated multiplier
			if (customMult != 1f)
			{
				__result *= customMult;
			}
		}
		catch (System.Exception ex)
		{
			MelonLogger.Error($"[BonkMenu] SilverMultiplierPatch error: {ex.Message}");
		}
	}
}

/// <summary>
/// Scales silver gains added to player inventory.
/// </summary>
[HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.AddSilver))]
public static class PlayerInventoryAddSilverPatch
{
    /// <summary>
    /// Prefix that scales the silver amount before it is added.
    /// </summary>
    public static void Prefix(ref int amount)
	{
		try
		{
			float customMult = StatsHelper.GetCurrentStatValue(EStat.SilverIncreaseMultiplier, 1f);
			if (customMult > 1f)
			{
				amount = (int)(amount * customMult);
			}
		}
		catch (System.Exception ex)
		{
			MelonLogger.Error($"[BonkMenu] AddSilverPatch error: {ex.Message}");
		}
	}
}
