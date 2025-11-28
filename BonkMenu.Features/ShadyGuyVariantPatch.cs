using System;
using HarmonyLib;
using Il2CppInterop.Runtime;
using MelonLoader;

namespace BonkMenu.Patches;

public static class ShadyGuyVariantPatch
{
    // Static flags to control shady merchant rarity
    public static int SpawnNextRarity = -1; // -1 = none, 1 = Rare, 2 = Epic, 3 = Legendary
    public static int RarityMerchantsRemaining = 0;
    
    // Track which merchants we've modified
    private static System.Collections.Generic.HashSet<IntPtr> ModifiedMerchants = new System.Collections.Generic.HashSet<IntPtr>();

    public static void Apply(HarmonyLib.Harmony harmony)
    {
        try
        {
            // Get the managed wrapper type for InteractableShadyGuy
            var shadyGuyType = typeof(Il2Cpp.InteractableShadyGuy);
            
            // Patch Start where rarity is initialized
            var startMethod = AccessTools.Method(shadyGuyType, "Start");
            if (startMethod != null)
            {
                var startPrefix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyStart_Prefix));
                var startPostfix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyStart_Postfix));
                harmony.Patch(startMethod, prefix: new HarmonyMethod(startPrefix), postfix: new HarmonyMethod(startPostfix));
                
                MelonLogger.Msg("[ShadyGuyVariantPatch] ✅ InteractableShadyGuy.Start patched - variant support enabled");
            }
            else
            {
                MelonLogger.Error("[ShadyGuyVariantPatch] Failed to find InteractableShadyGuy.Start method!");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Failed to patch: {ex.Message}");
            MelonLogger.Error($"[ShadyGuyVariantPatch] Stack trace: {ex.StackTrace}");
        }
    }

    // Prefix runs BEFORE Start - set rarity before initialization
    private static void ShadyGuyStart_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            if (SpawnNextRarity >= 0 && RarityMerchantsRemaining > 0)
            {
                IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
                
                // Offset 0x90 is EItemRarity rarity field (4 bytes for enum)
                System.Runtime.InteropServices.Marshal.WriteInt32(ptr + 0x90, SpawnNextRarity);
                
                ModifiedMerchants.Add(ptr);
                
                MelonLogger.Msg($"[ShadyGuyVariantPatch] Start Prefix: Set rarity to {SpawnNextRarity}");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Failed in Start prefix: {ex.Message}");
        }
    }

    // Postfix runs AFTER Start - apply material and cleanup
    private static void ShadyGuyStart_Postfix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)__instance).Pointer;
            
            // Only process merchants we modified
            if (!ModifiedMerchants.Contains(ptr))
            {
                return;
            }
            
            if (SpawnNextRarity >= 0 && RarityMerchantsRemaining > 0)
            {
                // Apply the corresponding material
                IntPtr meshRendererPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0x70); // meshRenderer at 0x70
                
                if (meshRendererPtr != IntPtr.Zero)
                {
                    var meshRenderer = new UnityEngine.SkinnedMeshRenderer(meshRendererPtr);
                    UnityEngine.Material rarityMaterial = null;
                    
                    // Get the appropriate material based on rarity
                    if (SpawnNextRarity == 1) // Rare
                    {
                        IntPtr matPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0x58); // matRare at 0x58
                        if (matPtr != IntPtr.Zero) rarityMaterial = new UnityEngine.Material(matPtr);
                    }
                    else if (SpawnNextRarity == 2) // Epic
                    {
                        IntPtr matPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0x60); // matEpic at 0x60
                        if (matPtr != IntPtr.Zero) rarityMaterial = new UnityEngine.Material(matPtr);
                    }
                    else if (SpawnNextRarity == 3) // Legendary
                    {
                        IntPtr matPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr + 0x68); // matLegendary at 0x68
                        if (matPtr != IntPtr.Zero) rarityMaterial = new UnityEngine.Material(matPtr);
                    }
                    
                    if (rarityMaterial != null)
                    {
                        meshRenderer.material = rarityMaterial;
                        MelonLogger.Msg($"[ShadyGuyVariantPatch] Start Postfix: Applied rarity material for level {SpawnNextRarity}");
                    }
                }
                
                ModifiedMerchants.Remove(ptr);
                RarityMerchantsRemaining--;
                
                if (RarityMerchantsRemaining <= 0)
                {
                    SpawnNextRarity = -1;
                    RarityMerchantsRemaining = 0;
                }
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Failed in Start postfix: {ex.Message}");
        }
    }
}
