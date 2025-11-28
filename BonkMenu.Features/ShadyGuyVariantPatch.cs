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

    // Start Postfix: Apply visuals and ensure visibility
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
                
                // 2. Apply Material
                if (shadyGuy.meshRenderer != null)
                {
                    // DIAGNOSTIC: Check Mesh
                    if (shadyGuy.meshRenderer.sharedMesh != null)
                    {
                        MelonLogger.Msg($"[ShadyGuyVariantPatch] Mesh found: {shadyGuy.meshRenderer.sharedMesh.name} (Vertex Count: {shadyGuy.meshRenderer.sharedMesh.vertexCount})");
                    }
                    else
                    {
                        MelonLogger.Error("[ShadyGuyVariantPatch] CRITICAL: sharedMesh is NULL!");
                    }

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
                        if (targetMat.HasProperty("_Color"))
                        {
                             MelonLogger.Msg($"[ShadyGuyVariantPatch] Applied material: {targetMat.name} (Color: {targetMat.color})");
                        }
                        else
                        {
                             MelonLogger.Msg($"[ShadyGuyVariantPatch] Applied material: {targetMat.name} (No _Color property)");
                        }
                    }
                    else
                    {
                        MelonLogger.Error($"[ShadyGuyVariantPatch] Target material for rarity {SpawnNextRarity} is NULL!");
                    }
                    
                    // 3. Force Enable Renderer & its GameObject
                    shadyGuy.meshRenderer.enabled = true;
                    shadyGuy.meshRenderer.gameObject.SetActive(true);
                    
                    // Prevent culling
                    shadyGuy.meshRenderer.updateWhenOffscreen = true;
                    
                    // Recalculate Bounds
                    shadyGuy.meshRenderer.localBounds = new Bounds(Vector3.zero, Vector3.one * 5f); // Force large bounds
                    
                    MelonLogger.Msg($"[ShadyGuyVariantPatch] Force enabled MeshRenderer, GameObject, updateWhenOffscreen.");
                    MelonLogger.Msg($"[ShadyGuyVariantPatch] Bounds: {shadyGuy.meshRenderer.bounds}, IsVisible: {shadyGuy.meshRenderer.isVisible}");
                    
                    // FIX: Force Enable RootBone
                    if (shadyGuy.meshRenderer.rootBone != null)
                    {
                        shadyGuy.meshRenderer.rootBone.gameObject.SetActive(true);
                        MelonLogger.Msg($"[ShadyGuyVariantPatch] Force enabled RootBone: {shadyGuy.meshRenderer.rootBone.name}");
                        
                        // Also ensure parent of root bone is active if it exists
                        if (shadyGuy.meshRenderer.rootBone.parent != null)
                        {
                             shadyGuy.meshRenderer.rootBone.parent.gameObject.SetActive(true);
                        }
                    }
                    else
                    {
                        MelonLogger.Msg("[ShadyGuyVariantPatch] RootBone is NULL");
                    }
                }
                else
                {
                    MelonLogger.Error("[ShadyGuyVariantPatch] meshRenderer is null!");
                }

                // 4. Force Enable Collider
                var collider = shadyGuy.GetComponent<Collider>();
                if (collider != null)
                {
                    collider.enabled = true;
                    MelonLogger.Msg($"[ShadyGuyVariantPatch] Force enabled Collider ({collider.GetIl2CppType().Name})");
                }
                
                // 5. Ensure GameObject is active and scale is correct
                shadyGuy.gameObject.SetActive(true);
                
                // Check and fix scale if it's zero
                if (shadyGuy.transform.localScale == Vector3.zero)
                {
                    shadyGuy.transform.localScale = Vector3.one;
                    MelonLogger.Msg("[ShadyGuyVariantPatch] Fixed zero scale!");
                }

                // DIAGNOSTIC: Check SMR Quality
                if (shadyGuy.meshRenderer != null)
                {
                     MelonLogger.Msg($"[ShadyGuyVariantPatch] SMR Quality: {(int)shadyGuy.meshRenderer.quality}");
                     // Force high quality?
                     // shadyGuy.meshRenderer.quality = (SkinQuality)4; // Bone4
                }

                /* Animator logic removed due to missing UnityEngine.AnimationModule reference
                // DIAGNOSTIC: Check Animator
                var animator = shadyGuy.GetComponent<UnityEngine.Animator>();
                if (animator != null)
                {
                    animator.enabled = true;
                    MelonLogger.Msg($"[ShadyGuyVariantPatch] Force enabled Animator.");
                }
                else
                {
                    MelonLogger.Msg("[ShadyGuyVariantPatch] No Animator found.");
                }
                */
                
                // DIAGNOSTIC: Check hideAfterPurchase
                if (shadyGuy.hideAfterPurchase != null)
                {
                    foreach (var obj in shadyGuy.hideAfterPurchase)
                    {
                        if (obj != null)
                        {
                            MelonLogger.Msg($"[ShadyGuyVariantPatch] hideAfterPurchase object: {obj.name} (Active: {obj.activeSelf})");
                            // Ensure these are active initially
                            obj.SetActive(true);
                        }
                    }
                }
                
                MelonLogger.Msg($"[ShadyGuyVariantPatch] Final State - Pos: {shadyGuy.transform.position}, Scale: {shadyGuy.transform.localScale}, Active: {shadyGuy.gameObject.activeSelf}, Layer: {shadyGuy.gameObject.layer}");

                // Cleanup
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
            MelonLogger.Error($"[ShadyGuyVariantPatch] Start Postfix Error: {ex.Message}");
        }
    }
}
