using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using MelonLoader;

namespace BonkMenu.Features;

/// <summary>
/// Manages granting and removing active abilities.
/// </summary>
public static class AbilityFeatures
{
    /// <summary>
    /// Attempts to grant an ability by id.
    /// </summary>
    public static void GrantAbility(int abilityId, string abilityName)
	{
		BonkMenu.Core.Log.Info($"[GrantAbility] Granting ability: {abilityName} (ID: {abilityId})");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[GrantAbility] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[GrantAbility] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[GrantAbility] Player inventory is null!");
				return;
			}
			MelonLogger.Warning("[GrantAbility] Active ability system not fully implemented");
			MelonLogger.Warning("[GrantAbility] Abilities may be tied to unlock/achievement system");
			BonkMenu.Core.Log.Info($"[GrantAbility] Attempted to grant: {abilityName} (ID: {abilityId})");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[GrantAbility] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[GrantAbility] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Attempts to grant all abilities.
    /// </summary>
    public static void GrantAllAbilities()
	{
		BonkMenu.Core.Log.Info("[GrantAllAbilities] Starting grant all abilities");
		try
		{
			MelonLogger.Warning("[GrantAllAbilities] Active ability direct grant system not found");
			MelonLogger.Warning("[GrantAllAbilities] Abilities appear to be progression-based unlocks");
			MelonLogger.Warning("[GrantAllAbilities] Recommend using UnlockFeatures.UnlockEverything() instead");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[GrantAllAbilities] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[GrantAllAbilities] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Attempts to remove an ability by id.
    /// </summary>
    public static void RemoveAbility(int abilityId)
	{
		BonkMenu.Core.Log.Info($"[RemoveAbility] Removing ability ID: {abilityId}");
		try
		{
			MelonLogger.Warning("[RemoveAbility] Ability removal not yet implemented");
			MelonLogger.Warning("[RemoveAbility] No API found for removing active abilities");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[RemoveAbility] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[RemoveAbility] Stack Trace: " + ex.StackTrace);
		}
	}
}
