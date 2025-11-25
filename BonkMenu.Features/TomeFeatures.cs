using System;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts._Data.Tomes;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Features;

public static class TomeFeatures
{
	public static void GrantTome(int tomeId, string tomeName)
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg($"[GrantTome] Granting tome: {tomeName} (ID: {tomeId})");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[GrantTome] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[GrantTome] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[GrantTome] Player inventory is null!");
				return;
			}
			TomeInventory tomeInventory = inventory.tomeInventory;
			if (tomeInventory == null)
			{
				MelonLogger.Error("[GrantTome] Tome inventory is null!");
				return;
			}
			DataManager instance2 = DataManager.Instance;
			if ((Object)(object)instance2 == (Object)null)
			{
				MelonLogger.Error("[GrantTome] DataManager.Instance is null!");
				return;
			}
			ETome val = (ETome)tomeId;
			TomeData tome = instance2.GetTome(val);
			if ((Object)(object)tome == (Object)null)
			{
				MelonLogger.Warning($"[GrantTome] TomeData not found for {tomeName} (ID: {tomeId})");
			}
			else
			{
				MelonLogger.Msg("[GrantTome] Adding maxed tome: " + ((Object)tome).name);
				tomeInventory.AddMaxedTome(tome);
				MelonLogger.Msg("[GrantTome] Successfully granted maxed tome: " + ((Object)tome).name);
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[GrantTome] CRITICAL ERROR granting " + tomeName + ": " + ex.Message);
			MelonLogger.Error("[GrantTome] Stack Trace: " + ex.StackTrace);
		}
	}

	public static void GrantAllTomes()
	{
		MelonLogger.Msg("[GrantAllTomes] Granting all 27 tomes (maxed)");
		try
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < 27; i++)
			{
				try
				{
					GrantTome(i, $"Tome_{i}");
					num++;
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[GrantAllTomes] Failed to grant tome {i}: {ex.Message}");
					num2++;
				}
			}
			MelonLogger.Msg($"[GrantAllTomes] Completed - Success: {num}/27, Failed: {num2}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[GrantAllTomes] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[GrantAllTomes] Stack Trace: " + ex2.StackTrace);
		}
	}

	public static void MaxAllTomes()
	{
		MelonLogger.Msg("[MaxAllTomes] All tomes are granted at max level by default");
		GrantAllTomes();
	}
}
