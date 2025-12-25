using System;
using HarmonyLib;
using MelonLoader;

namespace BonkMenu.Patches;

public static class GoldenShrinePatch
{
    public static bool SpawnNextAsGolden = false;
    public static int GoldenShrinesRemaining = 0;
    
    private static System.Collections.Generic.HashSet<IntPtr> ModifiedShrines = new System.Collections.Generic.HashSet<IntPtr>();

    public static void Apply(HarmonyLib.Harmony harmony)
    {
        try
        {
            var chargeShrineType = typeof(Il2Cpp.ChargeShrine);
            
            var awakeMethod = AccessTools.Method(chargeShrineType, "Awake");
            if (awakeMethod == null)
            {
                MelonLogger.Error("[GoldenShrinePatch] Failed to find ChargeShrine.Awake method!");
                return;
            }
            
            var awakePrefix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineAwake_Prefix));
            var awakePostfix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineAwake_Postfix));
            harmony.Patch(awakeMethod, prefix: new HarmonyMethod(awakePrefix), postfix: new HarmonyMethod(awakePostfix));

            var startMethod = AccessTools.Method(chargeShrineType, "Start");
            if (startMethod != null)
            {
                var startPrefix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineStart_Prefix));
                var startPostfix = AccessTools.Method(typeof(GoldenShrinePatch), nameof(ChargeShrineStart_Postfix));
                harmony.Patch(startMethod, prefix: new HarmonyMethod(startPrefix), postfix: new HarmonyMethod(startPostfix));
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg("[GoldenShrinePatch] ✅ ChargeShrine.Awake & Start patched - golden shrine support enabled");
            }
            else
            {
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg("[GoldenShrinePatch] ✅ ChargeShrine.Awake patched - golden shrine support enabled (Start not found)");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed to patch: {ex.Message}");
            MelonLogger.Error($"[GoldenShrinePatch] Stack trace: {ex.StackTrace}");
        }
    }

    private static void ChargeShrineAwake_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            if (SpawnNextAsGolden && GoldenShrinesRemaining > 0)
            {
                IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0x108, 1);
                
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[GoldenShrinePatch] Awake Prefix: Set isGolden=true, {GoldenShrinesRemaining} remaining");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed in Awake prefix: {ex.Message}");
        }
    }

    private static void ChargeShrineAwake_Postfix(Il2CppSystem.Object __instance)
    {
        try
        {
            if (SpawnNextAsGolden && GoldenShrinesRemaining > 0)
            {
                IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
                byte currentValue = System.Runtime.InteropServices.Marshal.ReadByte(ptr + 0x108);
                
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[GoldenShrinePatch] Awake Postfix: isGolden currently = {currentValue}, setting to true");
                
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0x108, 1);
                
                ModifiedShrines.Add(ptr);
                
                GoldenShrinesRemaining--;
                
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

    private static void ChargeShrineStart_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
            
            if (!ModifiedShrines.Contains(ptr))
            {
                return;
            }
            
            byte isGoldenValue = System.Runtime.InteropServices.Marshal.ReadByte(ptr + 0x108);
            
            if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[GoldenShrinePatch] Start Prefix: Our shrine, isGolden = {isGoldenValue}");
            
            if (isGoldenValue == 0)
            {
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0x108, 1);
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[GoldenShrinePatch] Start Prefix: Set isGolden to true (was 0)");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[GoldenShrinePatch] Failed in Start prefix: {ex.Message}");
        }
    }

    private static void ChargeShrineStart_Postfix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
            
            if (!ModifiedShrines.Contains(ptr))
            {
                return;
            }
            
            byte isGoldenValue = System.Runtime.InteropServices.Marshal.ReadByte(ptr + 0x108);
            if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[GoldenShrinePatch] Start Postfix: Our shrine, isGolden = {isGoldenValue}");
            
            if (isGoldenValue == 1)
            {
                try
                {
                    IntPtr goldMaterialPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0x110);
                    IntPtr meshRendererPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0x70);
                    
                    if (goldMaterialPtr != IntPtr.Zero && meshRendererPtr != IntPtr.Zero)
                    {
                        var goldMaterial = new UnityEngine.Material(goldMaterialPtr);
                        var meshRenderer = new UnityEngine.Renderer(meshRendererPtr);
                        
                        meshRenderer.material = goldMaterial;
                        
                        if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[GoldenShrinePatch] Start Postfix: Applied gold material manually!");
                        
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

