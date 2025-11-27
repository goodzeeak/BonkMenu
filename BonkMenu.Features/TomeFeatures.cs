using System;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts._Data.Tomes;
using MelonLoader;
using UnityEngine;
using Il2CppSystem.Collections.Generic;

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
				MelonLogger.Msg("[GrantTome] Adding tome at level 1: " + ((Object)tome).name);
				// Get level 1 upgrade offer (Common rarity = 1)
				var upgradeOffer = tome.GetUpgradeOffer((ERarity)1);
				if (upgradeOffer == null)
				{
					MelonLogger.Warning($"[GrantTome] GetUpgradeOffer() returned null for {tomeName}");
					return;
				}
				// Add tome at level 1 with Common rarity
				tomeInventory.AddTome(tome, upgradeOffer, (ERarity)1);
				tomeInventory.CheckMaxed();
				MelonLogger.Msg($"[GrantTome] Successfully granted tome at level 1: {((Object)tome).name}");
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
		MelonLogger.Msg("[MaxAllTomes] Maxing currently owned tomes...");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null) return;
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null) return;
			PlayerInventory inventory = player.inventory;
			if (inventory == null) return;
			TomeInventory tomeInventory = inventory.tomeInventory;
			if (tomeInventory == null) return;

			// Get list of owned tomes
			List<ETome> ownedTomes = new List<ETome>();
			foreach (var tome in tomeInventory.tomeLevels)
			{
				ownedTomes.Add(tome.Key);
			}

			int count = 0;
			foreach (ETome tomeId in ownedTomes)
			{
				MelonLogger.Msg($"[MaxAllTomes] Maxing tome: {tomeId}");
				// Try to max it out (99 levels is the default max for tomes)
				for (int i = 0; i < 99; i++)
				{
					GrantTome((int)tomeId, tomeId.ToString());
				}
				count++;
			}
			MelonLogger.Msg($"[MaxAllTomes] Completed - Maxed {count} tomes");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[MaxAllTomes] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[MaxAllTomes] Stack Trace: " + ex.StackTrace);
		}
	}
}
