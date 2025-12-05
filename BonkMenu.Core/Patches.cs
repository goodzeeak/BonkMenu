using HarmonyLib;
using System;
using System.Reflection;
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

            // Apply TogglePatches - apply the runtime patch for RunUnlockables
            try
            {
                _harmonyInstance.PatchAll(typeof(BonkMenu.Features.TogglePatches));
                Log.Info("[Patches] ✅ TogglePatches applied");
            }
            catch (Exception ex)
            {
                Log.Error($"[Patches] Failed to apply TogglePatches: {ex.Message}");
            }

            
            
            Log.Info("[Patches] All patches applied successfully!");
        }
        catch (Exception ex)
        {
            Log.Error($"[Patches] Failed to apply patches: {ex.Message}");
            Log.Error($"[Patches] Stack trace: {ex.StackTrace}");
        }
    }

    private static Type SafeTypeByName(string fullName)
    {
        try
        {
            var t = Type.GetType(fullName, throwOnError: false, ignoreCase: false);
            if (t != null) return t;
        }
        catch { }
        try
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    var an = asm.GetName().Name;
                    if (an != null && an.StartsWith("UnityEngine", StringComparison.OrdinalIgnoreCase)) continue;
                    var tt = asm.GetType(fullName, throwOnError: false, ignoreCase: false);
                    if (tt != null) return tt;
                }
                catch (ReflectionTypeLoadException) { }
                catch { }
            }
        }
        catch { }
        return null;
    }

    public static void ApplyDeferred()
    {
        try
        {
            if (_harmonyInstance == null) _harmonyInstance = new HarmonyLib.Harmony("com.bonkmenu.patches");
            BonkMenu.Features.TogglePatches.ApplyRunUnlockablesPatch(_harmonyInstance);
            var il2cppRefType = SafeTypeByName("UniverseLib.Il2CppReflection");
            MethodInfo buildMethod = null;
            MethodInfo prefix = null;
            if (il2cppRefType != null)
            {
                buildMethod = il2cppRefType.GetMethod("BuildDeobfuscationCache", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            }
            prefix = typeof(BonkMenu.Patches.UniverseLibPatchesRT).GetMethod(nameof(BonkMenu.Patches.UniverseLibPatchesRT.BuildDeobfuscationCache_Prefix), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (il2cppRefType != null && buildMethod != null && prefix != null)
            {
                _harmonyInstance.Patch(buildMethod, new HarmonyLib.HarmonyMethod(prefix));
            }
        }
        catch { }
    }
}
