using Il2Cpp;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using BonkMenu.Core;
using UniverseLib;
using HarmonyLib;

namespace BonkMenu.Features;

/// <summary>
/// Grants passive abilities to the player.
/// </summary>
public static class PassiveFeatures
{
    private static Dictionary<EPassive, PassiveData> _passiveCache;
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
            // Manual ability path with stacking via MultiPassiveManager
            if (_passiveCache == null)
            {
                _passiveCache = new Dictionary<EPassive, PassiveData>();
                var all = RuntimeHelper.FindObjectsOfTypeAll<PassiveData>();
                if (all != null)
                {
                    foreach (var pd in all)
                    {
                        if ((Object)(object)pd != (Object)null)
                        {
                            if (!_passiveCache.ContainsKey(pd.ePassive))
                            {
                                _passiveCache[pd.ePassive] = pd;
                            }
                        }
                    }
                }
            }
            PassiveData val2 = null;
            _passiveCache?.TryGetValue(val, out val2);
			if ((Object)(object)val2 == (Object)null)
			{
                Log.Warn($"[GrantPassive] PassiveData not found for {passiveName} (ID: {passiveId})");
				return;
			}
            PassiveAbility val4 = PassiveAbilityFactory.CreatePassiveAbility(val2);
            if (val4 == null)
            {
                Log.Error("[GrantPassive] Failed to create passive ability for " + passiveName);
                return;
            }
			
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
