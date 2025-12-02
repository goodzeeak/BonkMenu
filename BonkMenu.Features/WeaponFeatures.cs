using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Weapons;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace BonkMenu.Features;

/// <summary>
/// Grants and maximizes weapons for the player.
/// </summary>
public static class WeaponFeatures
{
    /// <summary>
    /// Grants a specific weapon to the player by id and name.
    /// </summary>
    public static void GrantWeapon(int weaponId, string weaponName)
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg($"[GrantWeapon] Granting weapon: {weaponName} (ID: {weaponId})");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[GrantWeapon] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[GrantWeapon] Player is null!");
				return;
			}
			PlayerInventory inventory = player.inventory;
			if (inventory == null)
			{
				MelonLogger.Error("[GrantWeapon] Player inventory is null!");
				return;
			}
			WeaponInventory weaponInventory = inventory.weaponInventory;
			if (weaponInventory == null)
			{
				MelonLogger.Error("[GrantWeapon] Weapon inventory is null!");
				return;
			}
			DataManager instance2 = DataManager.Instance;
			if ((Object)(object)instance2 == (Object)null)
			{
				MelonLogger.Error("[GrantWeapon] DataManager.Instance is null!");
				return;
			}
			EWeapon val = (EWeapon)weaponId;
			WeaponData weapon = instance2.GetWeapon(val);
			if ((Object)(object)weapon == (Object)null)
			{
				MelonLogger.Warning($"[GrantWeapon] WeaponData not found for {weaponName} (ID: {weaponId})");
			}
			else
			{
				MelonLogger.Msg("[GrantWeapon] Adding weapon: " + ((Object)weapon).name);
				weaponInventory.AddWeapon(weapon, (List<StatModifier>)null);
				MelonLogger.Msg("[GrantWeapon] Successfully granted " + ((Object)weapon).name);
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[GrantWeapon] CRITICAL ERROR granting " + weaponName + ": " + ex.Message);
			MelonLogger.Error("[GrantWeapon] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Grants all available weapons to the player.
    /// </summary>
    public static void GrantAllWeapons()
	{
		MelonLogger.Msg("[GrantAllWeapons] Granting all 30 weapons");
		try
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < 30; i++)
			{
				try
				{
					GrantWeapon(i, $"Weapon_{i}");
					num++;
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[GrantAllWeapons] Failed to grant weapon {i}: {ex.Message}");
					num2++;
				}
			}
			MelonLogger.Msg($"[GrantAllWeapons] Completed - Success: {num}, Failed: {num2}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[GrantAllWeapons] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[GrantAllWeapons] Stack Trace: " + ex2.StackTrace);
		}
	}

    /// <summary>
    /// Maxes all currently owned weapons.
    /// </summary>
    public static void MaxAllWeapons()
	{
		MelonLogger.Msg("[MaxAllWeapons] Maxing currently owned weapons...");
		try
		{
			GameManager instance = GameManager.Instance;
			if ((Object)(object)instance == (Object)null) return;
			MyPlayer player = instance.player;
			if ((Object)(object)player == (Object)null) return;
			PlayerInventory inventory = player.inventory;
			if (inventory == null) return;
			WeaponInventory weaponInventory = inventory.weaponInventory;
			if (weaponInventory == null) return;

			// Get list of owned weapons to avoid modification errors during iteration
			List<EWeapon> ownedWeapons = new List<EWeapon>();
			foreach (var weapon in weaponInventory.weapons)
			{
				ownedWeapons.Add(weapon.Key);
			}

			int count = 0;
			foreach (EWeapon weaponId in ownedWeapons)
			{
				MelonLogger.Msg($"[MaxAllWeapons] Maxing weapon: {weaponId}");
				// Try to max it out (40 levels should be enough for most)
				for (int i = 0; i < 40; i++)
				{
					// Check if maxed to avoid unnecessary calls (if IsMaxLevel is accessible/reliable)
					// For now, we'll just spam grant as it's safer than relying on private/internal checks
					GrantWeapon((int)weaponId, weaponId.ToString());
				}
				count++;
			}
			MelonLogger.Msg($"[MaxAllWeapons] Completed - Maxed {count} weapons");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[MaxAllWeapons] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[MaxAllWeapons] Stack Trace: " + ex.StackTrace);
		}
	}
}
