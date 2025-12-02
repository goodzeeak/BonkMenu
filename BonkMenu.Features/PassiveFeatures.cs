using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using BonkMenu.Core;
using UniverseLib;

namespace BonkMenu.Features;

/// <summary>
/// Grants passive abilities to the player.
/// </summary>
public static class PassiveFeatures
{
    /// <summary>
    /// Grants a passive by id, initializing and tracking it.
    /// </summary>
    public static void GrantPassive(int passiveId, string passiveName)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
        Log.Info($"[GrantPassive] Granting passive: {passiveName} (ID: {passiveId})");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
                Log.Error("[GrantPassive] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
                Log.Error("[GrantPassive] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
                Log.Error("[GrantPassive] Player inventory is null!");
				return;
			}
			EPassive val = (EPassive)passiveId;
            Log.Info($"[GrantPassive] Passive enum value: {val}");
			// Removed HasPassive check to allow multiple passives
            Log.Info("[GrantPassive] Searching for PassiveData");
			PassiveData[] array = RuntimeHelper.FindObjectsOfTypeAll<PassiveData>();
			if (array == null)
			{
                Log.Error("[GrantPassive] FindObjectsOfTypeAll returned null!");
				return;
			}
            Log.Info($"[GrantPassive] Found {array.Length} total PassiveData objects");
			PassiveData val2 = null;
			PassiveData[] array2 = array;
			foreach (PassiveData val3 in array2)
			{
				try
				{
					if ((Object)(object)val3 != (Object)null && val3.ePassive == val)
					{
						val2 = val3;
                        Log.Info("[GrantPassive] Found matching PassiveData: " + val3.name);
						break;
					}
				}
				catch (Exception ex)
				{
                    Log.Warn("[GrantPassive] Error checking PassiveData: " + ex.Message);
				}
			}
			if ((Object)(object)val2 == (Object)null)
			{
                Log.Warn($"[GrantPassive] PassiveData not found for {passiveName} (ID: {passiveId})");
				return;
			}
            Log.Info("[GrantPassive] Creating passive ability");
			PassiveAbility val4 = PassiveAbilityFactory.CreatePassiveAbility(val2);
			if (val4 == null)
			{
                Log.Error("[GrantPassive] Failed to create passive ability for " + passiveName);
				return;
			}
            Log.Info("[GrantPassive] Created passive ability successfully");
			
            // Add to multi-passive collection (initialization handled inside)
            MultiPassiveManager.AddPassive(inventory, val4);
            Log.Info("[GrantPassive] Successfully granted and initialized " + passiveName);
		}
		catch (Exception ex3)
		{
            Log.Error("[GrantPassive] CRITICAL ERROR granting " + passiveName + ": " + ex3.Message);
            Log.Error("[GrantPassive] Stack Trace: " + ex3.StackTrace);
		}
	}
}
