using System;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MelonLoader;
using UnityEngine;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;

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
            var shadyGuyType = typeof(Il2Cpp.InteractableShadyGuy);
            
            // Patch Start
            var startMethod = AccessTools.Method(shadyGuyType, "Start");
            if (startMethod != null)
            {
                var startPrefix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyStart_Prefix));
                var startPostfix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyStart_Postfix));
                harmony.Patch(startMethod, prefix: new HarmonyMethod(startPrefix), postfix: new HarmonyMethod(startPostfix));
                MelonLogger.Msg("[ShadyGuyVariantPatch] ✅ InteractableShadyGuy.Start patched");
            }
            
            // Patch FindItems - crucial because Start() resets rarity before calling this!
            var findItemsMethod = AccessTools.Method(shadyGuyType, "FindItems");
            if (findItemsMethod != null)
            {
                var findItemsPrefix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyFindItems_Prefix));
                harmony.Patch(findItemsMethod, prefix: new HarmonyMethod(findItemsPrefix));
                MelonLogger.Msg("[ShadyGuyVariantPatch] ✅ InteractableShadyGuy.FindItems patched");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Failed to patch: {ex.Message}");
        }
    }

    // Start Prefix: Register merchant and set initial rarity
    private static void ShadyGuyStart_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            if (SpawnNextRarity >= 0 && RarityMerchantsRemaining > 0)
            {
                var shadyGuy = __instance.Cast<Il2Cpp.InteractableShadyGuy>();
                IntPtr ptr = shadyGuy.Pointer;
                
                // Set rarity using managed property (safer than offset)
                shadyGuy.rarity = (EItemRarity)SpawnNextRarity;
                
                ModifiedMerchants.Add(ptr);
                MelonLogger.Msg($"[ShadyGuyVariantPatch] Start Prefix: Set rarity to {SpawnNextRarity}");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Start Prefix Error: {ex.Message}");
        }
    }

    // FindItems Prefix: Re-set rarity because Start() likely randomized it just before calling this
    private static void ShadyGuyFindItems_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppObjectBase)__instance).Pointer;
            if (ModifiedMerchants.Contains(ptr) && SpawnNextRarity >= 0)
            {
                var shadyGuy = __instance.Cast<Il2Cpp.InteractableShadyGuy>();
                
                // Force rarity again so items are generated correctly
                shadyGuy.rarity = (EItemRarity)SpawnNextRarity;
                MelonLogger.Msg($"[ShadyGuyVariantPatch] FindItems Prefix: Re-enforced rarity {SpawnNextRarity}");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] FindItems Prefix Error: {ex.Message}");
        }
    }

    // Start Postfix: Apply visuals matching natural spawn configuration
    private static void ShadyGuyStart_Postfix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppObjectBase)__instance).Pointer;
            if (!ModifiedMerchants.Contains(ptr)) return;
            
            if (SpawnNextRarity >= 0 && RarityMerchantsRemaining > 0)
            {
                var shadyGuy = __instance.Cast<Il2Cpp.InteractableShadyGuy>();
                
                // 1. Re-set rarity one last time
                shadyGuy.rarity = (EItemRarity)SpawnNextRarity;
                MelonLogger.Msg($"[ShadyGuyVariantPatch] Set rarity to {SpawnNextRarity}");
                
                // 2. Apply Material (matching natural spawn)
                if (shadyGuy.meshRenderer != null)
                {
                    Material targetMat = null;
                    switch (SpawnNextRarity)
                    {
                        case 1: targetMat = shadyGuy.matRare; break;
                        case 2: targetMat = shadyGuy.matEpic; break;
                        case 3: targetMat = shadyGuy.matLegendary; break;
                    }

                    if (targetMat != null)
                    {
                        shadyGuy.meshRenderer.material = targetMat;
                        MelonLogger.Msg($"[ShadyGuyVariantPatch] Applied material: {targetMat.name}");
                    }
                    
                    // 3. Configure SkinnedMeshRenderer (match natural spawn exactly)
                    shadyGuy.meshRenderer.enabled = true;
                    shadyGuy.meshRenderer.gameObject.SetActive(true);
                    shadyGuy.meshRenderer.updateWhenOffscreen = true;
                    
                    // CRITICAL: Use Auto quality like natural spawns (not 4)
                    shadyGuy.meshRenderer.quality = SkinQuality.Auto;
                    
                    // 4. Enable bone hierarchy
                    if (shadyGuy.meshRenderer.bones != null && shadyGuy.meshRenderer.bones.Length > 0)
                    {
                        foreach (var bone in shadyGuy.meshRenderer.bones)
                        {
                            if (bone != null)
                            {
                                bone.gameObject.SetActive(true);
                            }
                        }
                        MelonLogger.Msg($"[ShadyGuyVariantPatch] Activated {shadyGuy.meshRenderer.bones.Length} bones");
                    }
                    
                    MelonLogger.Msg($"[ShadyGuyVariantPatch] SkinnedMeshRenderer configured (Auto quality)");
                    
                    // 5. STATIC MESH FALLBACK REMOVED - Animated mesh is working!
                    
                }

                // 6. Ensure collider is enabled
                var collider = shadyGuy.GetComponent<Collider>();
                if (collider != null)
                {
                    collider.enabled = true;
                }
                
                // 6. Ensure GameObject is active
                shadyGuy.gameObject.SetActive(true);
                
                // Fix scale if zero
                if (shadyGuy.transform.localScale == Vector3.zero)
                {
                    shadyGuy.transform.localScale = Vector3.one;
                }
                
                // 7. CRITICAL: Fix UI Icons (MinimapIcon, AltarIcon)
                // These are in hideAfterPurchase. We now trust the native hierarchy.
                if (shadyGuy.hideAfterPurchase != null)
                {
                    MelonLogger.Msg($"[ShadyGuyVariantPatch] Processing {shadyGuy.hideAfterPurchase.Length} hideAfterPurchase objects (UI Icons):");
                    for (int i = 0; i < shadyGuy.hideAfterPurchase.Length; i++)
                    {
                        var obj = shadyGuy.hideAfterPurchase[i];
                        if (obj != null)
                        {
                            // Just activate it. Don't move it. Don't reparent it.
                            obj.SetActive(true);
                            MelonLogger.Msg($"[ShadyGuyVariantPatch]   [{i}] {obj.name} - Activated. Pos: {obj.transform.localPosition}, Parent: {obj.transform.parent?.name ?? "null"}");
                        }
                    }
                }
                
                // Cleanup
                ModifiedMerchants.Remove(ptr);
                RarityMerchantsRemaining--;
                if (RarityMerchantsRemaining <= 0)
                {
                    SpawnNextRarity = -1;
                    RarityMerchantsRemaining = 0;
                }
                
                MelonLogger.Msg($"[ShadyGuyVariantPatch] ✅ Shady Guy spawn complete - matches natural configuration");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Start Postfix Error: {ex.Message}");
        }
    }
}
