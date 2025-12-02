using System.Collections.Generic;

namespace BonkMenu.Core;

/// <summary>
/// Runtime configuration flags and helpers for BonkMenu.
/// </summary>
public static class ModConfig
{
    /// <summary>
    /// Default silver amount used by features that add currency.
    /// </summary>
    public static int GoldAmount = 10000;

    /// <summary>
    /// When true, prevents health from decreasing.
    /// </summary>
    public static bool InfiniteHealth { get; set; } = false;

    /// <summary>
    /// When true, prevents shield from decreasing.
    /// </summary>
    public static bool InfiniteShield { get; set; } = false;

    /// <summary>
    /// When true, removes the jump count limit.
    /// </summary>
    public static bool InfiniteJumps { get; set; } = false;

    /// <summary>
    /// When true, blocks damage and death.
    /// </summary>
    public static bool GodMode { get; set; } = false;


    /// <summary>
    /// When true, shop and upgrades cost nothing.
    /// </summary>
    public static bool FreePurchases { get; set; } = false;

    /// <summary>
    /// When true, grants large refreshes/banishes/skips.
    /// </summary>
    public static bool InfiniteRefreshes { get; set; } = false;

    /// <summary>
    /// When true, enemies take extreme damage.
    /// </summary>
    public static bool OneHitKill { get; set; } = false;

    /// <summary>
    /// When true, removes ability cooldown restrictions.
    /// </summary>
    public static bool NoCooldowns { get; set; } = false;

    /// <summary>
    /// When true, pauses enemy movement/actions.
    /// </summary>
    public static bool FreezeEnemies { get; set; } = false;

    /// <summary>
    /// When true, removes weapon level cap globally.
    /// </summary>
    public static bool UnlimitedWeaponLevels { get; set; } = false;
    /// <summary>
    /// When true, removes tome level cap globally.
    /// </summary>
    public static bool UnlimitedTomeLevels { get; set; } = false;

    /// <summary>
    /// Names of weapons with unlimited levels enabled.
    /// </summary>
    public static HashSet<string> UnlimitedWeaponNames { get; } = new HashSet<string>(System.StringComparer.OrdinalIgnoreCase);
    /// <summary>
    /// Names of tomes with unlimited levels enabled.
    /// </summary>
    public static HashSet<string> UnlimitedTomeNames { get; } = new HashSet<string>(System.StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// When true, uses uncapped XP multiplier in UI and systems.
    /// </summary>
    public static bool UnlimitedXp { get; set; } = false;

    /// <summary>
    /// When true, shows toast notifications in UI.
    /// </summary>
    public static bool EnableToasts { get; set; } = true;

    /// <summary>
    /// Toggles Infinite Health.
    /// </summary>
    public static void ToggleInfiniteHealth()
	{
		InfiniteHealth = !InfiniteHealth;
        Log.Info("Infinite Health: " + (InfiniteHealth ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles Infinite Shield.
    /// </summary>
    public static void ToggleInfiniteShield()
	{
		InfiniteShield = !InfiniteShield;
        Log.Info("Infinite Shield: " + (InfiniteShield ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles Infinite Jumps.
    /// </summary>
    public static void ToggleInfiniteJumps()
	{
		InfiniteJumps = !InfiniteJumps;
        Log.Info("Infinite Jumps: " + (InfiniteJumps ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles Free Purchases.
    /// </summary>
    public static void ToggleFreePurchases()
	{
		FreePurchases = !FreePurchases;
        Log.Info("Free Purchases: " + (FreePurchases ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles Infinite Refreshes.
    /// </summary>
    public static void ToggleInfiniteRefreshes()
	{
		InfiniteRefreshes = !InfiniteRefreshes;
        Log.Info("Infinite Refreshes: " + (InfiniteRefreshes ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles One Hit Kill.
    /// </summary>
    public static void ToggleOneHitKill()
	{
		OneHitKill = !OneHitKill;
        Log.Info("One Hit Kill: " + (OneHitKill ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles No Cooldowns.
    /// </summary>
    public static void ToggleNoCooldowns()
	{
		NoCooldowns = !NoCooldowns;
        Log.Info("No Cooldowns: " + (NoCooldowns ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles Freeze Enemies.
    /// </summary>
    public static void ToggleFreezeEnemies()
	{
		FreezeEnemies = !FreezeEnemies;
        Log.Info("Freeze Enemies: " + (FreezeEnemies ? "ON" : "OFF"));
	}

    /// <summary>
    /// Toggles God Mode and updates UI.
    /// </summary>
    public static void ToggleGodMode()
    {
        GodMode = !GodMode;
        Log.Info("God Mode: " + (GodMode ? "ON" : "OFF"));
        BonkMenu.UI.Components.UIFactory.SetToggleState("🛡️ God Mode", GodMode);
    }


    /// <summary>
    /// Toggles unlimited weapon level caps globally.
    /// </summary>
    public static void ToggleUnlimitedWeaponLevels()
    {
        UnlimitedWeaponLevels = !UnlimitedWeaponLevels;
        Log.Info("Unlimited Weapon Levels: " + (UnlimitedWeaponLevels ? "ON" : "OFF"));
    }

    /// <summary>
    /// Toggles unlimited tome level caps globally.
    /// </summary>
    public static void ToggleUnlimitedTomeLevels()
    {
        UnlimitedTomeLevels = !UnlimitedTomeLevels;
        Log.Info("Unlimited Tome Levels: " + (UnlimitedTomeLevels ? "ON" : "OFF"));
    }

    /// <summary>
    /// Enables unlimited level cap for a specific weapon by name.
    /// </summary>
    public static void EnableUnlimitedForWeapon(string weaponName)
    {
        if (!string.IsNullOrWhiteSpace(weaponName))
        {
            UnlimitedWeaponNames.Add(weaponName);
            Log.Info($"Unlimited Levels enabled for weapon '{weaponName}'");
        }
    }

    /// <summary>
    /// Disables unlimited level cap for a specific weapon by name.
    /// </summary>
    public static void DisableUnlimitedForWeapon(string weaponName)
    {
        if (!string.IsNullOrWhiteSpace(weaponName))
        {
            UnlimitedWeaponNames.Remove(weaponName);
            Log.Info($"Unlimited Levels disabled for weapon '{weaponName}'");
        }
    }

    /// <summary>
    /// Enables unlimited level cap for a specific tome by name.
    /// </summary>
    public static void EnableUnlimitedForTome(string tomeName)
    {
        if (!string.IsNullOrWhiteSpace(tomeName))
        {
            UnlimitedTomeNames.Add(tomeName);
            Log.Info($"Unlimited Levels enabled for tome '{tomeName}'");
        }
    }

    /// <summary>
    /// Disables unlimited level cap for a specific tome by name.
    /// </summary>
    public static void DisableUnlimitedForTome(string tomeName)
    {
        if (!string.IsNullOrWhiteSpace(tomeName))
        {
            UnlimitedTomeNames.Remove(tomeName);
            Log.Info($"Unlimited Levels disabled for tome '{tomeName}'");
        }
    }

    /// <summary>
    /// Toggles uncapped XP multiplier setting.
    /// </summary>
    public static void ToggleUnlimitedXp()
    {
        UnlimitedXp = !UnlimitedXp;
        Log.Info("Unlimited XP: " + (UnlimitedXp ? "ON" : "OFF"));
        BonkMenu.UI.Components.UIFactory.SetToggleState("∞ Unlimited XP", UnlimitedXp);
    }

    /// <summary>
    /// Toggles UI toast notifications.
    /// </summary>
    public static void ToggleToasts()
    {
        EnableToasts = !EnableToasts;
        Log.Info("Toasts: " + (EnableToasts ? "ON" : "OFF"));
    }
}
