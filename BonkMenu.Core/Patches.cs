namespace BonkMenu.Core;

/// <summary>
/// Coordinates application of Harmony patches across BonkMenu modules.
/// </summary>
public static class Patches
{
	private static HarmonyLib.Harmony _harmonyInstance;

    /// <summary>
    /// Applies all Harmony patches and logs status.
    /// </summary>
    public static void Apply()
	{
		try
		{
			// Initialize Harmony instance
			_harmonyInstance = new HarmonyLib.Harmony("com.bonkmenu.patches");
            Log.Info("[Patches] Initializing Harmony patches...");

			// Apply level cap patches
            BonkMenu.Patches.LevelCapPatches.Apply(_harmonyInstance);

            

			// Apply golden shrine patch
            BonkMenu.Patches.GoldenShrinePatch.Apply(_harmonyInstance);

			// Apply pot variant patch
            BonkMenu.Patches.PotVariantPatch.Apply();

			// Apply shady guy variant patch
            BonkMenu.Patches.ShadyGuyVariantPatch.Apply(_harmonyInstance);

			// Apply player health patches (God Mode, etc.)
            BonkMenu.Patches.PlayerHealthPatches.Apply(_harmonyInstance);

			// Flight Mode removed

			// Apply passive inventory patches (multi-passive support)
            try
            {
                _harmonyInstance.PatchAll(typeof(BonkMenu.Patches.PassiveInventoryPatches));
                Log.Info("[Patches] ✅ PassiveInventory patches applied");
            }
            catch (Exception ex)
            {
                Log.Error($"[Patches] Failed to apply PassiveInventory patches: {ex.Message}");
            }
            
            Log.Info("[Patches] All patches applied successfully!");
        }
        catch (Exception ex)
        {
            Log.Error($"[Patches] Failed to apply patches: {ex.Message}");
            Log.Error($"[Patches] Stack trace: {ex.StackTrace}");
        }
	}
}
