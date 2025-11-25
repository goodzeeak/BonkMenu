using HarmonyLib;
using BonkMenu.Features;
using Il2CppAssets.Scripts.Game.Other;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
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
			// If the game ignores this stat, we force it here.
			// If the game caps it inside GetSilverMultiplier, we multiply after the cap.
			if (customMult != 1f)
			{
				__result *= customMult;
			}
		}
		catch
		{
			// Silently fail to avoid console spam in critical path
		}
	}
}
