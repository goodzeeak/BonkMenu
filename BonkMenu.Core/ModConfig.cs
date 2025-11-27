using MelonLoader;

namespace BonkMenu.Core;

public static class ModConfig
{
	public static int GoldAmount = 10000;

	public static bool InfiniteHealth { get; set; } = false;

	public static bool InfiniteShield { get; set; } = false;

	public static bool InfiniteJumps { get; set; } = false;

	public static bool GodMode { get; set; } = false;

	public static bool FlightMode { get; set; } = false;

	public static bool FreePurchases { get; set; } = false;

	public static bool InfiniteRefreshes { get; set; } = false;

	public static bool OneHitKill { get; set; } = false;

	public static bool NoCooldowns { get; set; } = false;

	public static bool FreezeEnemies { get; set; } = false;

	public static bool UnlimitedLevels { get; set; } = true;

	public static void ToggleInfiniteHealth()
	{
		InfiniteHealth = !InfiniteHealth;
		MelonLogger.Msg("Infinite Health: " + (InfiniteHealth ? "ON" : "OFF"));
	}

	public static void ToggleInfiniteShield()
	{
		InfiniteShield = !InfiniteShield;
		MelonLogger.Msg("Infinite Shield: " + (InfiniteShield ? "ON" : "OFF"));
	}

	public static void ToggleInfiniteJumps()
	{
		InfiniteJumps = !InfiniteJumps;
		MelonLogger.Msg("Infinite Jumps: " + (InfiniteJumps ? "ON" : "OFF"));
	}

	public static void ToggleFreePurchases()
	{
		FreePurchases = !FreePurchases;
		MelonLogger.Msg("Free Purchases: " + (FreePurchases ? "ON" : "OFF"));
	}

	public static void ToggleInfiniteRefreshes()
	{
		InfiniteRefreshes = !InfiniteRefreshes;
		MelonLogger.Msg("Infinite Refreshes: " + (InfiniteRefreshes ? "ON" : "OFF"));
	}

	public static void ToggleOneHitKill()
	{
		OneHitKill = !OneHitKill;
		MelonLogger.Msg("One Hit Kill: " + (OneHitKill ? "ON" : "OFF"));
	}

	public static void ToggleNoCooldowns()
	{
		NoCooldowns = !NoCooldowns;
		MelonLogger.Msg("No Cooldowns: " + (NoCooldowns ? "ON" : "OFF"));
	}

	public static void ToggleFreezeEnemies()
	{
		FreezeEnemies = !FreezeEnemies;
		MelonLogger.Msg("Freeze Enemies: " + (FreezeEnemies ? "ON" : "OFF"));
	}

	public static void ToggleGodMode()
	{
		GodMode = !GodMode;
		MelonLogger.Msg("God Mode: " + (GodMode ? "ON" : "OFF"));
	}

	public static void ToggleFlightMode()
	{
		FlightMode = !FlightMode;
		MelonLogger.Msg("Flight Mode: " + (FlightMode ? "ON" : "OFF"));
	}

	public static void ToggleUnlimitedLevels()
	{
		UnlimitedLevels = !UnlimitedLevels;
		MelonLogger.Msg("Unlimited Levels: " + (UnlimitedLevels ? "ON" : "OFF"));
	}
}
