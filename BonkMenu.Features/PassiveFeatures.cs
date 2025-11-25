using System;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using MelonLoader;
using UnityEngine;
using UniverseLib;

namespace BonkMenu.Features;

public static class PassiveFeatures
{
	public static void GrantPassive(int passiveId, string passiveName)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg($"[GrantPassive] Granting passive: {passiveName} (ID: {passiveId})");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[GrantPassive] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[GrantPassive] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[GrantPassive] Player inventory is null!");
				return;
			}
			EPassive val = (EPassive)passiveId;
			MelonLogger.Msg($"[GrantPassive] Passive enum value: {val}");
			// Removed HasPassive check to allow multiple passives
			MelonLogger.Msg("[GrantPassive] Searching for PassiveData");
			PassiveData[] array = RuntimeHelper.FindObjectsOfTypeAll<PassiveData>();
			if (array == null)
			{
				MelonLogger.Error("[GrantPassive] FindObjectsOfTypeAll returned null!");
				return;
			}
			MelonLogger.Msg($"[GrantPassive] Found {array.Length} total PassiveData objects");
			PassiveData val2 = null;
			PassiveData[] array2 = array;
			foreach (PassiveData val3 in array2)
			{
				try
				{
					if ((Object)(object)val3 != (Object)null && val3.ePassive == val)
					{
						val2 = val3;
						MelonLogger.Msg("[GrantPassive] Found matching PassiveData: " + val3.name);
						break;
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[GrantPassive] Error checking PassiveData: " + ex.Message);
				}
			}
			if ((Object)(object)val2 == (Object)null)
			{
				MelonLogger.Warning($"[GrantPassive] PassiveData not found for {passiveName} (ID: {passiveId})");
				return;
			}
			MelonLogger.Msg("[GrantPassive] Creating passive ability");
			PassiveAbility val4 = PassiveAbilityFactory.CreatePassiveAbility(val2);
			if (val4 == null)
			{
				MelonLogger.Error("[GrantPassive] Failed to create passive ability for " + passiveName);
				return;
			}
			MelonLogger.Msg("[GrantPassive] Created passive ability successfully");
			if (inventory.passiveAbility != null)
			{
				MelonLogger.Msg("[GrantPassive] Cleaning up old passive ability");
				try
				{
					inventory.passiveAbility.Cleanup();
				}
				catch (Exception ex2)
				{
					MelonLogger.Warning("[GrantPassive] Error during cleanup: " + ex2.Message);
				}
			}
			inventory.passiveAbility = val4; // Our Harmony patch will intercept this and add to collection
			val4.Init();
			MelonLogger.Msg("[GrantPassive] Successfully granted and initialized " + passiveName);
		}
		catch (Exception ex3)
		{
			MelonLogger.Error("[GrantPassive] CRITICAL ERROR granting " + passiveName + ": " + ex3.Message);
			MelonLogger.Error("[GrantPassive] Stack Trace: " + ex3.StackTrace);
		}
	}
}
