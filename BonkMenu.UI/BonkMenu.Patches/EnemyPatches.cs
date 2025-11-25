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
					MelonLogger.Warning("[BonkMenu] EnemyPatches null DamageContainer warning");
					_hasLoggedError = true;
				}
				return;
			}

			damageContainer.damage = 9999999f;
		}
		catch (Exception ex)
		{
			if (!_hasLoggedError)
			{
				MelonLogger.Error("[BonkMenu] EnemyPatches.Damage error: " + ex.Message);
				_hasLoggedError = true;
			}
		}
	}
}
