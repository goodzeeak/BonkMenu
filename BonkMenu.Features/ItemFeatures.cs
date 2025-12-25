using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;
using MelonLoader;

namespace BonkMenu.Features;

/// <summary>
/// Grants items to the player and bulk-grants all items.
/// </summary>
public static class ItemFeatures
{
    /// <summary>
    /// Grants a specific item by id to the player.
    /// </summary>
    public static void GrantItem(int itemId, string itemName)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		BonkMenu.Core.Log.Info($"[GrantItem] Granting item: {itemName} (ID: {itemId})");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[GrantItem] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[GrantItem] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[GrantItem] Player inventory is null!");
				return;
			}
			ItemInventory itemInventory = inventory.itemInventory;
			if (itemInventory == null)
			{
				MelonLogger.Error("[GrantItem] Item inventory is null!");
				return;
			}
			EItem val = (EItem)itemId;
			BonkMenu.Core.Log.Info($"[GrantItem] Adding item enum value: {val}");
			itemInventory.AddItem(val, 1);
			BonkMenu.Core.Log.Info("[GrantItem] Successfully granted " + itemName);
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[GrantItem] CRITICAL ERROR granting " + itemName + ": " + ex.Message);
			MelonLogger.Error("[GrantItem] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Grants all items to the player.
    /// </summary>
    public static void GrantAllItems()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		BonkMenu.Core.Log.Info("[GrantAllItems] Granting all 87 items (ID: 0-86)");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[GrantAllItems] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[GrantAllItems] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[GrantAllItems] Player inventory is null!");
				return;
			}
			ItemInventory itemInventory = inventory.itemInventory;
			if (itemInventory == null)
			{
				MelonLogger.Error("[GrantAllItems] Item inventory is null!");
				return;
			}
			int num = 0;
			int num2 = 0;
			for (int i = 0; i <= 86; i++)
			{
				try
				{
					EItem val = (EItem)i;
					itemInventory.AddItem(val, 1);
					num++;
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[GrantAllItems] Failed to grant item {i}: {ex.Message}");
					num2++;
				}
			}
			BonkMenu.Core.Log.Info($"[GrantAllItems] Completed - Granted: {num}/87, Failed: {num2}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[GrantAllItems] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[GrantAllItems] Stack Trace: " + ex2.StackTrace);
		}
	}
}
