using System;
using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Actors;
using Il2CppAssets.Scripts.Actors.Enemies;
using MelonLoader;

namespace BonkMenu.Patches;

[HarmonyPatch(typeof(Enemy))]
public class EnemyPatches
{
	private static bool _hasLoggedOneHitKill;

	private static bool _hasLoggedError;

	[HarmonyPatch("Damage")]
	[HarmonyPrefix]
	public static void Damage_Prefix(Enemy __instance, DamageContainer damageContainer)
	{
		try
		{
			if (!ModConfig.OneHitKill)
			{
				return;
			}
			if (damageContainer == null)
			{
				if (!_hasLoggedError)
				{
					MelonLogger.Warning("[EnemyPatches] DamageContainer is null, cannot apply one-hit kill");
					_hasLoggedError = true;
				}
				return;
			}
			if (!_hasLoggedOneHitKill)
			{
				MelonLogger.Msg("[EnemyPatches] One-hit kill active - setting massive damage");
				_hasLoggedOneHitKill = true;
			}
			damageContainer.damage = 9999999f;
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[EnemyPatches.Damage] Error (will not log again): " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}
}
