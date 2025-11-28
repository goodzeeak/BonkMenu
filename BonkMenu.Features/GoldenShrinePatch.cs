using System;
using HarmonyLib;
using Il2CppInterop.Runtime;
using MelonLoader;

namespace BonkMenu.Patches;

public static class GoldenShrinePatch
{
    // Static flag to control when shrines should spawn as golden
    public static bool SpawnNextAsGolden = false;
    public static int GoldenShrinesRemaining = 0;
    
    // Track which shrines we've modified so we don't affect naturally spawned golden shrines
    private static System.Collections.Generic.HashSet<IntPtr> ModifiedShrines = new System.Collections.Generic.HashSet<IntPtr>();

    public static void Apply(HarmonyLib.Harmony harmony)
    {
        try
        {
            // Get the managed wrapper type for ChargeShrine
            var chargeShrineType = typeof(Il2Cpp.ChargeShrine);
            
            // Patch Awake
            var awakeMethod = AccessTools.Method(chargeShrineType, "Awake");
            if (awakeMethod == null)
            {
                MelonLogger.Error("[GoldenShrinePatch] Failed to find ChargeShrine.Awake method!");
                return;
            }
            
            var awakePrefix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineAwake_Prefix));
            var awakePostfix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineAwake_Postfix));
            harmony.Patch(awakeMethod, prefix: new HarmonyMethod(awakePrefix), postfix: new HarmonyMethod(awakePostfix));

            // Patch Start - this is where visuals are applied
            var startMethod = AccessTools.Method(chargeShrineType, "Start");
            if (startMethod != null)
            {
                var startPrefix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineStart_Prefix));
                var startPostfix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineStart_Postfix));
                harmony.Patch(startMethod, prefix: new HarmonyMethod(startPrefix), postfix: new HarmonyMethod(startPostfix));
                MelonLogger.Msg("[GoldenShrinePatch] ✅ ChargeShrine.Awake & Start patched - golden shrine support enabled");
            }
            else
            {
                MelonLogger.Msg("[GoldenShrinePatch] ✅ ChargeShrine.Awake patched - golden shrine support enabled (Start not found)");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed to patch: {ex.Message}");
            MelonLogger.Error($"[GoldenShrinePatch] Stack trace: {ex.StackTrace}");
        }
    }

    // Prefix runs BEFORE ChargeShrine.Awake
    private static void ChargeShrineAwake_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            if (SpawnNextAsGolden && GoldenShrinesRemaining > 0)
            {
                // Set isGolden flag at offset 0xD0 BEFORE Awake runs
                IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0xD0, 1);
                
                MelonLogger.Msg($"[GoldenShrinePatch] Awake Prefix: Set isGolden=true, {GoldenShrinesRemaining} remaining");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed in Awake prefix: {ex.Message}");
        }
    }

    // Postfix runs AFTER ChargeShrine.Awake - ensure isGolden is still set (in case Awake reset it)
    private static void ChargeShrineAwake_Postfix(Il2CppSystem.Object __instance)
    {
        try
        {
            if (SpawnNextAsGolden && GoldenShrinesRemaining > 0)
            {
                // Set/re-set isGolden flag at offset 0xD0 AFTER Awake runs (Awake resets it!)
                IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
                byte currentValue = System.Runtime.InteropServices.Marshal.ReadByte(ptr + 0xD0);
                
                MelonLogger.Msg($"[GoldenShrinePatch] Awake Postfix: isGolden currently = {currentValue}, setting to true");
                
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0xD0, 1);
                
                // Track this shrine as one we've modified
                ModifiedShrines.Add(ptr);
                
                GoldenShrinesRemaining--;
                
                // If we've converted all the shrines we wanted, turn off the flag
                if (GoldenShrinesRemaining <= 0)
                {
                    SpawnNextAsGolden = false;
                    GoldenShrinesRemaining = 0;
                }
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed in Awake postfix: {ex.Message}");
        }
    }

    // Prefix runs BEFORE ChargeShrine.Start - ensure our spawned shrines have isGolden set
    private static void ChargeShrineStart_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
            
            // Only modify shrines WE spawned
            if (!ModifiedShrines.Contains(ptr))
            {
                return; // Not our shrine, don't touch it
            }
            
            // Check if this shrine should be golden by reading the flag
            byte isGoldenValue = System.Runtime.InteropServices.Marshal.ReadByte(ptr + 0xD0);
            
            MelonLogger.Msg($"[GoldenShrinePatch] Start Prefix: Our shrine, isGolden = {isGoldenValue}");
            
            // Ensure it's set before Start runs (in case it got reset after Awake)
            if (isGoldenValue == 0)
            {
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0xD0, 1);
                MelonLogger.Msg($"[GoldenShrinePatch] Start Prefix: Set isGolden to true (was 0)");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed in Start prefix: {ex.Message}");
        }
    }

    // Postfix runs AFTER ChargeShrine.Start - manually apply gold material to OUR spawned shrines only
    private static void ChargeShrineStart_Postfix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
            
            // Only apply material if this is a shrine WE modified
            if (!ModifiedShrines.Contains(ptr))
            {
                return; // Not our shrine, don't touch it
            }
            
            byte isGoldenValue = System.Runtime.InteropServices.Marshal.ReadByte(ptr + 0xD0);
            MelonLogger.Msg($"[GoldenShrinePatch] Start Postfix: Our shrine, isGolden = {isGoldenValue}");
            
            // If it's golden, manually apply the gold material
            if (isGoldenValue == 1)
            {
                try
                {
                    // Offset 0xD8 is goldMaterial, 0x38 is meshRenderer
                    // Read goldMaterial pointer
                    IntPtr goldMaterialPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0xD8);
                    IntPtr meshRendererPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0x38);
                    
                    if (goldMaterialPtr != IntPtr.Zero && meshRendererPtr != IntPtr.Zero)
                    {
                        // Convert pointers to Unity objects
                        var goldMaterial = new UnityEngine.Material(goldMaterialPtr);
                        var meshRenderer = new UnityEngine.Renderer(meshRendererPtr);
                        
                        // Apply the gold material
                        meshRenderer.material = goldMaterial;
                        
                        MelonLogger.Msg($"[GoldenShrinePatch] Start Postfix: Applied gold material manually!");
                        
                        // Remove from tracking set since we're done with it
                        ModifiedShrines.Remove(ptr);
                    }
                    else
                    {
                        MelonLogger.Warning($"[GoldenShrinePatch] Start Postfix: goldMaterial or meshRenderer is null!");
                    }
                }
                catch (Exception e)
                {
                    MelonLogger.Error($"[GoldenShrinePatch] Failed to apply gold material: {e.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed in Start postfix: {ex.Message}");
        }
    }
}
