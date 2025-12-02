using BonkMenu.Core;
using HarmonyLib;
using Il2CppAssets.Scripts.Actors;
using Il2CppAssets.Scripts.Actors.Enemies;
using MelonLoader;

namespace BonkMenu.Patches;

/// <summary>
/// Modifies enemy damage behavior for OneHitKill.
/// </summary>
[HarmonyPatch(typeof(Enemy))]
public class EnemyPatches
{


	private static bool _hasLoggedError;

    /// <summary>
    /// Prefix that optionally sets huge damage for instakill.
    /// </summary>
    [HarmonyPatch("Damage")]
    [HarmonyPrefix]
    public static bool Damage_Prefix(DamageContainer damageContainer)
    {
        try
        {
            if (!ModConfig.OneHitKill)
            {
                return true;
            }
            if (damageContainer == null)
            {
                if (!_hasLoggedError)
                {
                    MelonLogger.Warning("[BonkMenu] EnemyPatches null DamageContainer warning");
                    _hasLoggedError = true;
                }
                return true;
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
        return true;
    }
}
