using System;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes;
using MelonLoader;
using UnityEngine;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;

namespace BonkMenu.Patches;

public static class ShadyGuyVariantPatch
{
    public static int SpawnNextRarity = -1;
    public static int RarityMerchantsRemaining = 0;
    
    private static System.Collections.Generic.HashSet<IntPtr> ModifiedMerchants = new System.Collections.Generic.HashSet<IntPtr>();

    public static void Apply(HarmonyLib.Harmony harmony)
    {
        try
        {
            var shadyGuyType = typeof(Il2Cpp.InteractableShadyGuy);
            
            var startMethod = AccessTools.Method(shadyGuyType, "Start");
            if (startMethod != null)
            {
                var startPrefix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyStart_Prefix));
                var startPostfix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyStart_Postfix));
                harmony.Patch(startMethod, prefix: new HarmonyMethod(startPrefix), postfix: new HarmonyMethod(startPostfix));
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg("[ShadyGuyVariantPatch] ✅ InteractableShadyGuy.Start patched");
            }
            
            var findItemsMethod = AccessTools.Method(shadyGuyType, "FindItems");
            if (findItemsMethod != null)
            {
                var findItemsPrefix = AccessTools.Method(typeof(ShadyGuyVariantPatch), nameof(ShadyGuyFindItems_Prefix));
                harmony.Patch(findItemsMethod, prefix: new HarmonyMethod(findItemsPrefix));
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg("[ShadyGuyVariantPatch] ✅ InteractableShadyGuy.FindItems patched");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Failed to patch: {ex.Message}");
        }
    }

    private static void ShadyGuyStart_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            if (SpawnNextRarity >= 0 && RarityMerchantsRemaining > 0)
            {
                var shadyGuy = __instance.Cast<Il2Cpp.InteractableShadyGuy>();
                IntPtr ptr = shadyGuy.Pointer;
                
                shadyGuy.rarity = (EItemRarity)SpawnNextRarity;
                
                ModifiedMerchants.Add(ptr);
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch] Start Prefix: Set rarity to {SpawnNextRarity}");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Start Prefix Error: {ex.Message}");
        }
    }

    private static void ShadyGuyFindItems_Prefix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppObjectBase)__instance).Pointer;
            if (ModifiedMerchants.Contains(ptr) && SpawnNextRarity >= 0)
            {
                var shadyGuy = __instance.Cast<Il2Cpp.InteractableShadyGuy>();
                
                shadyGuy.rarity = (EItemRarity)SpawnNextRarity;
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch] FindItems Prefix: Re-enforced rarity {SpawnNextRarity}");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] FindItems Prefix Error: {ex.Message}");
        }
    }

    private static void ShadyGuyStart_Postfix(Il2CppSystem.Object __instance)
    {
        try
        {
            IntPtr ptr = ((Il2CppObjectBase)__instance).Pointer;
            if (!ModifiedMerchants.Contains(ptr)) return;
            
            if (SpawnNextRarity >= 0 && RarityMerchantsRemaining > 0)
            {
                var shadyGuy = __instance.Cast<Il2Cpp.InteractableShadyGuy>();
                
                shadyGuy.rarity = (EItemRarity)SpawnNextRarity;
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch] Set rarity to {SpawnNextRarity}");
                
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
                    
                    shadyGuy.meshRenderer.enabled = true;
                    shadyGuy.meshRenderer.gameObject.SetActive(true);
                    shadyGuy.meshRenderer.updateWhenOffscreen = true;
                    
                    shadyGuy.meshRenderer.quality = SkinQuality.Auto;
                    
                    if (shadyGuy.meshRenderer.bones != null && shadyGuy.meshRenderer.bones.Length > 0)
                    {
                        foreach (var bone in shadyGuy.meshRenderer.bones)
                        {
                            if (bone != null)
                            {
                                bone.gameObject.SetActive(true);
                            }
                        }
                        if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch] Activated {shadyGuy.meshRenderer.bones.Length} bones");
                    }
                    
                    if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch] SkinnedMeshRenderer configured (Auto quality)");
                }

                var collider = shadyGuy.GetComponent<Collider>();
                if (collider != null)
                {
                    collider.enabled = true;
                }
                
                shadyGuy.gameObject.SetActive(true);
                
                if (shadyGuy.transform.localScale == Vector3.zero)
                {
                    shadyGuy.transform.localScale = Vector3.one;
                }
                
                if (shadyGuy.hideAfterPurchase != null)
                {
                    if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch] Processing {shadyGuy.hideAfterPurchase.Length} hideAfterPurchase objects (UI Icons):");
                    for (int i = 0; i < shadyGuy.hideAfterPurchase.Length; i++)
                    {
                        var obj = shadyGuy.hideAfterPurchase[i];
                        if (obj != null)
                        {
                            obj.SetActive(true);
                            if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch]   [{i}] {obj.name} - Activated. Pos: {obj.transform.localPosition}, Parent: {obj.transform.parent?.name ?? "null"}");
                        }
                    }
                }
                
                ModifiedMerchants.Remove(ptr);
                RarityMerchantsRemaining--;
                if (RarityMerchantsRemaining <= 0)
                {
                    SpawnNextRarity = -1;
                    RarityMerchantsRemaining = 0;
                }
                
                if (BonkMenu.Core.ModConfig.VerboseLogging) MelonLogger.Msg($"[ShadyGuyVariantPatch] ✅ Shady Guy spawn complete - matches natural configuration");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[ShadyGuyVariantPatch] Start Postfix Error: {ex.Message}");
        }
    }
}
