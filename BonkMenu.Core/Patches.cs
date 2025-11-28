using System;
using HarmonyLib;
using MelonLoader;

namespace BonkMenu.Core;

public static class Patches
{
	private static HarmonyLib.Harmony _harmonyInstance;

	public static void Apply()
	{
		try
		{
			// Initialize Harmony instance
			_harmonyInstance = new HarmonyLib.Harmony("com.bonkmenu.patches");
			MelonLogger.Msg("[Patches] Initializing Harmony patches...");

			// Apply level cap patches
			BonkMenu.Patches.LevelCapPatches.Apply(_harmonyInstance);

			// Apply XP display patch
			BonkMenu.Patches.XpDisplayPatch.Apply(_harmonyInstance);

			// Apply golden shrine patch
			BonkMenu.Patches.GoldenShrinePatch.Apply(_harmonyInstance);

			MelonLogger.Msg("[Patches] All patches applied successfully!");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[Patches] Failed to apply patches: {ex.Message}");
			MelonLogger.Error($"[Patches] Stack trace: {ex.StackTrace}");
		}
	}
}
