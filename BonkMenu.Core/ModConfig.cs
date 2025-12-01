using BonkMenu.Core;
using System.Collections.Generic;

namespace BonkMenu.Core;

public static class ModConfig
{
	public static int GoldAmount = 10000;

	public static bool InfiniteHealth { get; set; } = false;

	public static bool InfiniteShield { get; set; } = false;

	public static bool InfiniteJumps { get; set; } = false;

	public static bool GodMode { get; set; } = false;


	public static bool FreePurchases { get; set; } = false;

	public static bool InfiniteRefreshes { get; set; } = false;

	public static bool OneHitKill { get; set; } = false;

	public static bool NoCooldowns { get; set; } = false;

    public static bool FreezeEnemies { get; set; } = false;

    public static bool UnlimitedWeaponLevels { get; set; } = false;
    public static bool UnlimitedTomeLevels { get; set; } = false;

    public static HashSet<string> UnlimitedWeaponNames { get; } = new HashSet<string>(System.StringComparer.OrdinalIgnoreCase);
    public static HashSet<string> UnlimitedTomeNames { get; } = new HashSet<string>(System.StringComparer.OrdinalIgnoreCase);

    public static bool UnlimitedXp { get; set; } = false;

    public static bool EnableToasts { get; set; } = true;

	public static void ToggleInfiniteHealth()
	{
		InfiniteHealth = !InfiniteHealth;
        Log.Info("Infinite Health: " + (InfiniteHealth ? "ON" : "OFF"));
	}

	public static void ToggleInfiniteShield()
	{
		InfiniteShield = !InfiniteShield;
        Log.Info("Infinite Shield: " + (InfiniteShield ? "ON" : "OFF"));
	}

	public static void ToggleInfiniteJumps()
	{
		InfiniteJumps = !InfiniteJumps;
        Log.Info("Infinite Jumps: " + (InfiniteJumps ? "ON" : "OFF"));
	}

	public static void ToggleFreePurchases()
	{
		FreePurchases = !FreePurchases;
        Log.Info("Free Purchases: " + (FreePurchases ? "ON" : "OFF"));
	}

	public static void ToggleInfiniteRefreshes()
	{
		InfiniteRefreshes = !InfiniteRefreshes;
        Log.Info("Infinite Refreshes: " + (InfiniteRefreshes ? "ON" : "OFF"));
	}

	public static void ToggleOneHitKill()
	{
		OneHitKill = !OneHitKill;
        Log.Info("One Hit Kill: " + (OneHitKill ? "ON" : "OFF"));
	}

	public static void ToggleNoCooldowns()
	{
		NoCooldowns = !NoCooldowns;
        Log.Info("No Cooldowns: " + (NoCooldowns ? "ON" : "OFF"));
	}

	public static void ToggleFreezeEnemies()
	{
		FreezeEnemies = !FreezeEnemies;
        Log.Info("Freeze Enemies: " + (FreezeEnemies ? "ON" : "OFF"));
	}

    public static void ToggleGodMode()
    {
        GodMode = !GodMode;
        Log.Info("God Mode: " + (GodMode ? "ON" : "OFF"));
        BonkMenu.UI.Components.UIFactory.SetToggleState("🛡️ God Mode", GodMode);
    }


    public static void ToggleUnlimitedWeaponLevels()
    {
        UnlimitedWeaponLevels = !UnlimitedWeaponLevels;
        Log.Info("Unlimited Weapon Levels: " + (UnlimitedWeaponLevels ? "ON" : "OFF"));
    }

    public static void ToggleUnlimitedTomeLevels()
    {
        UnlimitedTomeLevels = !UnlimitedTomeLevels;
        Log.Info("Unlimited Tome Levels: " + (UnlimitedTomeLevels ? "ON" : "OFF"));
    }

    public static void EnableUnlimitedForWeapon(string weaponName)
    {
        if (!string.IsNullOrWhiteSpace(weaponName))
        {
            UnlimitedWeaponNames.Add(weaponName);
            Log.Info($"Unlimited Levels enabled for weapon '{weaponName}'");
        }
    }

    public static void DisableUnlimitedForWeapon(string weaponName)
    {
        if (!string.IsNullOrWhiteSpace(weaponName))
        {
            UnlimitedWeaponNames.Remove(weaponName);
            Log.Info($"Unlimited Levels disabled for weapon '{weaponName}'");
        }
    }

    public static void EnableUnlimitedForTome(string tomeName)
    {
        if (!string.IsNullOrWhiteSpace(tomeName))
        {
            UnlimitedTomeNames.Add(tomeName);
            Log.Info($"Unlimited Levels enabled for tome '{tomeName}'");
        }
    }

    public static void DisableUnlimitedForTome(string tomeName)
    {
        if (!string.IsNullOrWhiteSpace(tomeName))
        {
            UnlimitedTomeNames.Remove(tomeName);
            Log.Info($"Unlimited Levels disabled for tome '{tomeName}'");
        }
    }

    public static void ToggleUnlimitedXp()
    {
        UnlimitedXp = !UnlimitedXp;
        Log.Info("Unlimited XP: " + (UnlimitedXp ? "ON" : "OFF"));
        BonkMenu.UI.Components.UIFactory.SetToggleState("∞ Unlimited XP", UnlimitedXp);
    }

    public static void ToggleToasts()
    {
        EnableToasts = !EnableToasts;
        Log.Info("Toasts: " + (EnableToasts ? "ON" : "OFF"));
    }
}
