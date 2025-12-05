using System;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppAssets.Scripts.Game.MapGeneration;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using BonkMenu.Core;
using UnityEngine;

namespace BonkMenu.Features;

/// <summary>
/// World spawning utilities for chests, shrines, pots, merchants, and microwaves.
/// </summary>
public static class WorldFeatures
{
    // --- Spawning (Mirrored from BonkAdder) ---

    // Use prefab spawning for granular control
    /// <summary>
    /// Spawns standard chests using native placement.
    /// </summary>
    public static void SpawnChests(int amount = 1) => SpawnSpecificInteractable("Chest", amount, "Chests");

    // Use prefab spawning for granular control
    /// <summary>
    /// Spawns free chests using native placement.
    /// </summary>
    public static void SpawnFreeChests(int amount = 1) => SpawnSpecificInteractable("ChestFree", amount, "Free Chests");

    /// <summary>
    /// Triggers statue spawning via the game's SpawnInteractables.
    /// </summary>
    public static void SpawnStatues(int times = 1)
    {
        SpawnInteractables spawner = Object.FindObjectOfType<SpawnInteractables>();
        if ((Object)(object)spawner != (Object)null)
        {
            for (int i = 0; i < times; i++)
            {
                spawner.SpawnShrines();
            }
            Log.Info($"Spawned Statues {times} time(s)!");
        }
        else
        {
            Log.Warn("SpawnInteractables instance not found!");
        }
    }

    // Individual spawn methods for specific interactables
    // Use the game's native spawn system (RandomObjectPlacer) for proper positioning
    private static void SpawnSpecificInteractable(string prefabName, int amount, string displayName)
    {
        try
        {
            RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
            if ((Object)(object)placer == (Object)null)
            {
                Log.Error("RandomObjectPlacer not found!");
                return;
            }

            // 1. Try to find the prefab in RandomObjectPlacer (Best source - configured for spawning)
            GameObject prefab = null;
            if (placer.randomObjects != null)
            {
                foreach (var obj in placer.randomObjects)
                {
                    if (obj.prefabs != null && obj.prefabs.Length > 0)
                    {
                        // Check if any prefab in this map object matches the name
                        foreach (var p in obj.prefabs)
                        {
                            if (p != null && p.name.Equals(prefabName, StringComparison.OrdinalIgnoreCase))
                            {
                                prefab = p;
                                Log.Info($"Found prefab '{prefabName}' in RandomObjectPlacer");
                                break;
                            }
                        }
                    }
                    if (prefab != null) break;
                }
            }

            // 2. Fallback: Find in Resources (Might be incomplete/unconfigured)
            if (prefab == null)
            {
                var allInteractables = UnityEngine.Resources.FindObjectsOfTypeAll<BaseInteractable>();
                foreach (var interactable in allInteractables)
                {
                    if (interactable.gameObject.name.Equals(prefabName, StringComparison.OrdinalIgnoreCase) 
                        && !interactable.gameObject.scene.IsValid())
                    {
                        // CRITICAL: Ensure we use the ROOT object, not just the child with the component
                        // This ensures we get the full hierarchy including bones and UI icons
                        prefab = interactable.transform.root.gameObject;
                        Log.Warn($"Found prefab '{prefabName}' in Resources (Fallback) - Using Root: {prefab.name}");
                        break;
                    }
                }
            }

            if ((Object)(object)prefab == (Object)null)
            {
                Log.Warn($"Prefab '{prefabName}' not found for {displayName}");
                return;
            }

            // Create a RandomMapObject to hold this shrine
            RandomMapObject shrineMapObject = new RandomMapObject();
            shrineMapObject.prefabs = new GameObject[] { prefab };
            shrineMapObject.amount = amount;
            shrineMapObject.maxAmount = amount;
            shrineMapObject.checkRadius = 1f;
            shrineMapObject.scaleMin = 1f;
            shrineMapObject.scaleMax = 1f;
            shrineMapObject.maxSlopeAngle = 45f;
            shrineMapObject.upOffset = 0f;
            shrineMapObject.alignWithNormal = false;
            shrineMapObject.randomRotationVector = new Vector3(0f, 1f, 0f); // Only rotate on Y axis
            
            // Use the game's spawn system
            var shrineArray = new Il2CppReferenceArray<RandomMapObject>(1);
            shrineArray[0] = shrineMapObject;
            placer.Generate(shrineArray);
            
            Log.Info($"Spawned {amount} {displayName} using game's spawn system!");
        }
        catch (Exception ex)
        {
            Log.Error($"Failed to spawn {displayName}: " + ex.Message);
            Log.Error($"Stack trace: " + ex.StackTrace);
        }
    }

    /// <summary>
    /// Spawns Challenge Shrines using native placement.
    /// </summary>
    public static void SpawnChallengeShrines(int amount = 3) => SpawnSpecificInteractable("ChallengeShrine", amount, "Challenge Shrines");
    /// <summary>
    /// Spawns Cursed Shrines using native placement.
    /// </summary>
    public static void SpawnCursedShrines(int amount = 3) => SpawnSpecificInteractable("CursedShrine", amount, "Cursed Shrines");
    /// <summary>
    /// Spawns Greed Shrines using native placement.
    /// </summary>
    public static void SpawnGreedShrines(int amount = 3) => SpawnSpecificInteractable("GreedShrine", amount, "Greed Shrines");
    /// <summary>
    /// Spawns Magnet Shrines using native placement.
    /// </summary>
    public static void SpawnMagnetShrines(int amount = 3) => SpawnSpecificInteractable("MagnetShrine", amount, "Magnet Shrines");
    /// <summary>
    /// Spawns Moai Shrines using native placement.
    /// </summary>
    public static void SpawnMoaiShrines(int amount = 3) => SpawnSpecificInteractable("ShrineMaoi", amount, "Moai Shrines");
    /// <summary>
    /// Spawns Shady Merchant using native placement.
    /// </summary>
    public static void SpawnShadyMerchant(int amount = 1) => SpawnSpecificInteractable("ShadyGuy", amount, "Shady Merchant");
    
    /// <summary>
    /// Logs spawnable objects and special prefabs in the current map.
    /// </summary>
    public static void ListSpawnableObjects()
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null) return;
        
        MelonLogger.Msg("--- Spawnable Objects List ---");
        
        // Log special fields
        if (placer.chargeShrineSpawns != null && placer.chargeShrineSpawns.prefabs != null && placer.chargeShrineSpawns.prefabs.Length > 0)
        {
            MelonLogger.Msg($"[SPECIAL] Charge Shrine Prefab: {placer.chargeShrineSpawns.prefabs[0].name}");
        }
        
        if (placer.greedShrines != null && placer.greedShrines.prefabs != null && placer.greedShrines.prefabs.Length > 0)
        {
            MelonLogger.Msg($"[SPECIAL] Greed Shrine (Gold) Prefab: {placer.greedShrines.prefabs[0].name}");
        }

        // Log random objects
        foreach (var obj in placer.randomObjects)
        {
            if (obj.prefabs != null && obj.prefabs.Length > 0)
            {
                MelonLogger.Msg($"Prefab Name: {obj.prefabs[0].name}");
            }
        }
        MelonLogger.Msg("------------------------------");
    }


    // Use prefab spawning for granular control
    /// <summary>
    /// Spawns Charge Shrines using template from RandomObjectPlacer.
    /// </summary>
    public static void SpawnShrines(int amount = 6)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            Log.Error("RandomObjectPlacer not found!");
            return;
        }

        if (placer.chargeShrineSpawns != null && placer.chargeShrineSpawns.prefabs != null && placer.chargeShrineSpawns.prefabs.Length > 0)
        {
            try
            {
                // Create a new RandomMapObject based on the template
                RandomMapObject template = placer.chargeShrineSpawns;
                RandomMapObject newObj = new RandomMapObject();
                newObj.prefabs = template.prefabs;
                newObj.amount = amount;
                newObj.maxAmount = amount;
                newObj.checkRadius = template.checkRadius;
                newObj.scaleMin = template.scaleMin;
                newObj.scaleMax = template.scaleMax;
                newObj.maxSlopeAngle = template.maxSlopeAngle;
                newObj.upOffset = template.upOffset;
                newObj.alignWithNormal = template.alignWithNormal;
                newObj.randomRotationVector = template.randomRotationVector;

                var array = new Il2CppReferenceArray<RandomMapObject>(1);
                array[0] = newObj;
                placer.Generate(array);
                Log.Info($"Spawned {amount} Charge Shrines!");
            }
            catch (Exception ex)
            {
                Log.Error("Failed to spawn Charge Shrines: " + ex.Message);
            }
        }
        else
        {
            Log.Error("Charge Shrine prefabs not found in RandomObjectPlacer!");
        }
    }

    // Gold Charge Shrines - Uses Harmony patch to convert shrines to golden during native spawn
    /// <summary>
    /// Spawns Charge Shrines and converts them to golden via Harmony.
    /// </summary>
    public static void SpawnGoldShrines(int amount = 6)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            Log.Error("RandomObjectPlacer not found!");
            return;
        }

        if (placer.chargeShrineSpawns == null || placer.chargeShrineSpawns.prefabs == null || placer.chargeShrineSpawns.prefabs.Length == 0)
        {
            Log.Error("Charge Shrine prefabs not found in RandomObjectPlacer!");
            return;
        }

        try
        {
            // Set the flag for the Harmony patch to convert shrines to golden
            BonkMenu.Patches.GoldenShrinePatch.SpawnNextAsGolden = true;
            BonkMenu.Patches.GoldenShrinePatch.GoldenShrinesRemaining = amount;

            // Spawn charge shrines using native positioning - the Harmony patch will make them golden
            RandomMapObject template = placer.chargeShrineSpawns;
            RandomMapObject newObj = new RandomMapObject();
            newObj.prefabs = template.prefabs;
            newObj.amount = amount;
            newObj.maxAmount = amount;
            newObj.checkRadius = template.checkRadius;
            newObj.scaleMin = template.scaleMin;
            newObj.scaleMax = template.scaleMax;
            newObj.maxSlopeAngle = template.maxSlopeAngle;
            newObj.upOffset = template.upOffset;
            newObj.alignWithNormal = template.alignWithNormal;
            newObj.randomRotationVector = template.randomRotationVector;

            var array = new Il2CppReferenceArray<RandomMapObject>(1);
            array[0] = newObj;
            placer.Generate(array);
            
            Log.Info($"Spawned {amount} Golden Shrines using native positioning + Harmony patch!");
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn Golden Shrines: " + ex.Message);
            Log.Error($"Stack trace: " + ex.StackTrace);
            
            // Reset the flag on error
            BonkMenu.Patches.GoldenShrinePatch.SpawnNextAsGolden = false;
            BonkMenu.Patches.GoldenShrinePatch.GoldenShrinesRemaining = 0;
        }
    }

    // Silver Pots - Spawns normal pots then modifies them to silver
    /// <summary>
    /// Spawns pots and converts newly spawned ones to silver.
    /// </summary>
    public static void SpawnSilverPots(int amount = 5)
    {
        try
        {
            // Get existing pots before spawning
            var existingPots = Object.FindObjectsOfType(Il2CppType.Of<InteractablePot>());
            var existingPotSet = new System.Collections.Generic.HashSet<IntPtr>();
            foreach (var pot in existingPots)
            {
                existingPotSet.Add(((Il2CppObjectBase)pot).Pointer);
            }

            // Spawn normal pots
            SpawnPots(1);
            
            // Find newly spawned pots and make them silver
            var allPots = Object.FindObjectsOfType(Il2CppType.Of<InteractablePot>());
            int silverCount = 0;
            
            foreach (var pot in allPots)
            {
                IntPtr potPtr = ((Il2CppObjectBase)pot).Pointer;
                if (!existingPotSet.Contains(potPtr) && silverCount < amount)
                {
                    // Offset 0x82 is isSilver
                    System.Runtime.InteropServices.Marshal.WriteByte(potPtr + 0x82, 1);
                    silverCount++;
                }
            }
            
            Log.Info("Spawned {silverCount} Silver Pots!");
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn Silver Pots: " + ex.Message);
        }
    }

    // Big Pots (Microwaves) - Spawns normal microwaves then modifies them to big
    /// <summary>
    /// Spawns microwaves and converts newly spawned pots to big.
    /// </summary>
    public static void SpawnBigPots(int amount = 5)
    {
        try
        {
            // Get existing pots before spawning
            var existingPots = Object.FindObjectsOfType(Il2CppType.Of<InteractablePot>());
            var existingPotSet = new System.Collections.Generic.HashSet<IntPtr>();
            foreach (var pot in existingPots)
            {
                existingPotSet.Add(((Il2CppObjectBase)pot).Pointer);
            }

            // Spawn microwaves
            SpawnMicrowaves(1);
            
            // Find newly spawned pots and make them big
            var allPots = Object.FindObjectsOfType(Il2CppType.Of<InteractablePot>());
            int bigCount = 0;
            
            foreach (var pot in allPots)
            {
                IntPtr potPtr = ((Il2CppObjectBase)pot).Pointer;
                if (!existingPotSet.Contains(potPtr) && bigCount < amount)
                {
                    // Offset 0x81 is isBig
                    System.Runtime.InteropServices.Marshal.WriteByte(potPtr + 0x81, 1);
                    bigCount++;
                }
            }
            
            Log.Info($"Spawned {bigCount} Big Pots (Microwaves)!");
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn Big Pots: " + ex.Message);
        }
    }

    // Shady Merchant Rare - Uses ShadyGuyVariantPatch
    /// <summary>
    /// Spawns Shady Merchant with Rare visual/rarity.
    /// </summary>
    public static void SpawnShadyMerchantRare(int amount = 1)
    {
        try
        {
            BonkMenu.Patches.ShadyGuyVariantPatch.SpawnNextRarity = 1; // Rare
            BonkMenu.Patches.ShadyGuyVariantPatch.RarityMerchantsRemaining = amount;
            
            SpawnShadyMerchant(amount);
            
            Log.Info($"Initiated spawning of {amount} Rare Shady Merchant(s)!");
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn Rare Shady Merchant: " + ex.Message);
            BonkMenu.Patches.ShadyGuyVariantPatch.SpawnNextRarity = -1;
            BonkMenu.Patches.ShadyGuyVariantPatch.RarityMerchantsRemaining = 0;
        }
    }

    // Shady Merchant Epic - Uses ShadyGuyVariantPatch
    /// <summary>
    /// Spawns Shady Merchant with Epic visual/rarity.
    /// </summary>
    public static void SpawnShadyMerchantEpic(int amount = 1)
    {
        try
        {
            BonkMenu.Patches.ShadyGuyVariantPatch.SpawnNextRarity = 2; // Epic
            BonkMenu.Patches.ShadyGuyVariantPatch.RarityMerchantsRemaining = amount;
            
            SpawnShadyMerchant(amount);
            
            Log.Info($"Initiated spawning of {amount} Epic Shady Merchant(s)!");
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn Epic Shady Merchant: " + ex.Message);
            BonkMenu.Patches.ShadyGuyVariantPatch.SpawnNextRarity = -1;
            BonkMenu.Patches.ShadyGuyVariantPatch.RarityMerchantsRemaining = 0;
        }
    }

    // Shady Merchant Legendary - Uses ShadyGuyVariantPatch
    /// <summary>
    /// Spawns Shady Merchant with Legendary visual/rarity.
    /// </summary>
    public static void SpawnShadyMerchantLegendary(int amount = 1)
    {
        try
        {
            BonkMenu.Patches.ShadyGuyVariantPatch.SpawnNextRarity = 3; // Legendary
            BonkMenu.Patches.ShadyGuyVariantPatch.RarityMerchantsRemaining = amount;
            
            SpawnShadyMerchant(amount);
            
            Log.Info($"Initiated spawning of {amount} Legendary Shady Merchant(s)!");
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn Legendary Shady Merchant: " + ex.Message);
            BonkMenu.Patches.ShadyGuyVariantPatch.SpawnNextRarity = -1;
            BonkMenu.Patches.ShadyGuyVariantPatch.RarityMerchantsRemaining = 0;
        }
    }

    /// <summary>
    /// Spawns standard pots; adds silver variant if prefab is found.
    /// </summary>
    public static void SpawnPots(int amountMultiplier = 1)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        
        if ((Object)(object)placer == (Object)null)
        {
            Log.Error("RandomObjectPlacer not found!");
            return;
        }
        try
        {
            List<RandomMapObject> potsToSpawn = new List<RandomMapObject>();
            GameObject silverPrefab = null;
            
            // Find existing pot objects and look for silver prefab
            foreach (var obj in placer.randomObjects)
            {
                if (obj.prefabs != null && obj.prefabs.Length > 0)
                {
                    string name = obj.prefabs[0].name.ToLower();
                    if (name.Contains("pot") && !name.Contains("microwave"))
                    {
                        potsToSpawn.Add(obj);
                        
                        // Try to find silver prefab on the pot component
                        if (silverPrefab == null)
                        {
                            var potComp = obj.prefabs[0].GetComponent<InteractablePot>();
                            if ((Object)(object)potComp != (Object)null)
                            {
                                silverPrefab = potComp.silverPrefab;
                            }
                        }
                    }
                }
            }

            // Create a custom RandomMapObject for Silver Pots
            if ((Object)(object)silverPrefab != (Object)null)
            {
                RandomMapObject silverPotObj = new RandomMapObject();
                // Copy settings from a standard pot if available, otherwise use defaults
                if (potsToSpawn.Count > 0)
                {
                    var template = potsToSpawn[0];
                    silverPotObj.amount = template.amount;
                    silverPotObj.maxAmount = template.maxAmount;
                    silverPotObj.checkRadius = template.checkRadius;
                    silverPotObj.scaleMin = template.scaleMin;
                    silverPotObj.scaleMax = template.scaleMax;
                    silverPotObj.maxSlopeAngle = template.maxSlopeAngle;
                    silverPotObj.upOffset = template.upOffset;
                    silverPotObj.alignWithNormal = template.alignWithNormal;
                    silverPotObj.randomRotationVector = template.randomRotationVector;
                }
                else
                {
                    // Fallback defaults
                    silverPotObj.amount = 5;
                    silverPotObj.maxAmount = 10;
                    silverPotObj.checkRadius = 1f;
                    silverPotObj.scaleMin = 1f;
                    silverPotObj.scaleMax = 1f;
                }

                // Assign silver prefab
                silverPotObj.prefabs = new GameObject[] { silverPrefab };
                potsToSpawn.Add(silverPotObj);
                Log.Info("Found and added Silver Pot!");
            }
            else
            {
                Log.Warn("Could not find Silver Pot prefab on any pot objects.");
            }

            // Convert to Il2Cpp array and spawn
            if (potsToSpawn.Count > 0)
            {
                // Apply amount multiplier to each pot type
                var field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMapObject>.NativeClassPtr, "amount");
                foreach (var pot in potsToSpawn)
                {
                    unsafe
                    {
                        nint ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pot);
                        nint fieldAddr = ptr + (int)IL2CPP.il2cpp_field_get_offset(field);
                        int originalAmount = *(int*)fieldAddr;
                        *(int*)fieldAddr = originalAmount * amountMultiplier;
                    }
                }
                
                var potArray = new Il2CppReferenceArray<RandomMapObject>(potsToSpawn.Count);
                for (int i = 0; i < potsToSpawn.Count; i++)
                {
                    potArray[i] = potsToSpawn[i];
                }
                placer.Generate(potArray);
                Log.Info($"Spawned {potsToSpawn.Count} types of pots (x{amountMultiplier} multiplier)!");
            }
            else
            {
                Log.Warn("No pot objects found to spawn.");
            }
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn pots: " + ex.Message);
        }
    }

    /// <summary>
    /// Spawns microwave interactables with multiplier on amount.
    /// </summary>
    public static void SpawnMicrowaves(int amountMultiplier = 1)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            Log.Error("RandomObjectPlacer not found!");
            return;
        }
        try
        {
            List<RandomMapObject> microwavesToSpawn = new List<RandomMapObject>();
            
            foreach (var obj in placer.randomObjects)
            {
                if (obj.prefabs != null && obj.prefabs.Length > 0)
                {
                    string name = obj.prefabs[0].name.ToLower();
                    if (name.Contains("microwave"))
                    {
                        microwavesToSpawn.Add(obj);
                    }
                }
            }

            if (microwavesToSpawn.Count > 0)
            {
                // Apply amount multiplier to each microwave type
                var field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMapObject>.NativeClassPtr, "amount");
                foreach (var microwave in microwavesToSpawn)
                {
                    unsafe
                    {
                        nint ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)microwave);
                        nint fieldAddr = ptr + (int)IL2CPP.il2cpp_field_get_offset(field);
                        int originalAmount = *(int*)fieldAddr;
                        *(int*)fieldAddr = originalAmount * amountMultiplier;
                    }
                }
                
                var microwaveArray = new Il2CppReferenceArray<RandomMapObject>(microwavesToSpawn.Count);
                for (int i = 0; i < microwavesToSpawn.Count; i++)
                {
                    microwaveArray[i] = microwavesToSpawn[i];
                }
                placer.Generate(microwaveArray);
                Log.Info($"Spawned Microwaves (x{amountMultiplier} multiplier)!");
            }
            else
            {
                Log.Warn("No microwave objects found.");
            }
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn microwaves: " + ex.Message);
        }
    }



    /// <summary>
    /// Spawns Greed Altars by configuring matching random map objects.
    /// </summary>
    public static void SpawnGreedAltars(int amount = 3)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            Log.Error("RandomObjectPlacer not found!");
            return;
        }

        try
        {
            List<RandomMapObject> altarsToSpawn = new List<RandomMapObject>();
            
            // Find Greed Altar objects in randomObjects
            foreach (var obj in placer.randomObjects)
            {
                if (obj.prefabs != null && obj.prefabs.Length > 0)
                {
                    string name = obj.prefabs[0].name.ToLower();
                    if (name.Contains("greed") && name.Contains("altar"))
                    {
                        // Set the amount to spawn
                        var field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMapObject>.NativeClassPtr, "amount");
                        unsafe
                        {
                            nint ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)obj);
                            nint fieldAddr = ptr + (int)IL2CPP.il2cpp_field_get_offset(field);
                            *(int*)fieldAddr = amount;
                        }
                        altarsToSpawn.Add(obj);
                    }
                }
            }

            if (altarsToSpawn.Count > 0)
            {
                var altarArray = new Il2CppReferenceArray<RandomMapObject>(altarsToSpawn.Count);
                for (int i = 0; i < altarsToSpawn.Count; i++)
                {
                    altarArray[i] = altarsToSpawn[i];
                }
                placer.Generate(altarArray);
                Log.Info($"Spawned {amount} Greed Altars!");
            }
            else
            {
                Log.Warn("No Greed Altar objects found.");
            }
        }
        catch (Exception ex)
        {
            Log.Error("Failed to spawn Greed Altars: " + ex.Message);
        }
    }
}
