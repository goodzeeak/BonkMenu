using System;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppAssets.Scripts.Game.MapGeneration;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Features;

public static class WorldFeatures
{
    // --- Spawning (Mirrored from BonkAdder) ---

    // Use prefab spawning for granular control
    public static void SpawnChests(int amount = 1) => SpawnSpecificInteractable("Chest", amount, "Chests");

    // Use prefab spawning for granular control
    public static void SpawnFreeChests(int amount = 1) => SpawnSpecificInteractable("ChestFree", amount, "Free Chests");

    public static void SpawnStatues(int times = 1)
    {
        SpawnInteractables spawner = Object.FindObjectOfType<SpawnInteractables>();
        if ((Object)(object)spawner != (Object)null)
        {
            for (int i = 0; i < times; i++)
            {
                spawner.SpawnShrines();
            }
            MelonLogger.Msg($"[BonkMenu] Spawned Statues {times} time(s)!");
        }
        else
        {
            MelonLogger.Warning("[BonkMenu] SpawnInteractables instance not found!");
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
                MelonLogger.Error("[BonkMenu] RandomObjectPlacer not found!");
                return;
            }

            // Find the prefab among all BaseInteractables
            var allInteractables = UnityEngine.Resources.FindObjectsOfTypeAll<BaseInteractable>();
            
            GameObject prefab = null;
            foreach (var interactable in allInteractables)
            {
                if (interactable.gameObject.name.Equals(prefabName, StringComparison.OrdinalIgnoreCase) 
                    && !interactable.gameObject.scene.IsValid())
                {
                    prefab = interactable.gameObject;
                    break;
                }
            }

            if ((Object)(object)prefab == (Object)null)
            {
                MelonLogger.Warning($"[BonkMenu] Prefab '{prefabName}' not found for {displayName}");
                MelonLogger.Warning("[BonkMenu] Available Interactables:");
                foreach (var interactable in allInteractables)
                {
                    if (interactable.gameObject.scene.IsValid()) continue; // Skip scene objects
                    MelonLogger.Warning($" - {interactable.gameObject.name}");
                }
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
            
            MelonLogger.Msg($"[BonkMenu] Spawned {amount} {displayName} using game's spawn system!");
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[BonkMenu] Failed to spawn {displayName}: " + ex.Message);
            MelonLogger.Error($"[BonkMenu] Stack trace: " + ex.StackTrace);
        }
    }

    public static void SpawnChallengeShrines(int amount = 3) => SpawnSpecificInteractable("ChallengeShrine", amount, "Challenge Shrines");
    public static void SpawnCursedShrines(int amount = 3) => SpawnSpecificInteractable("CursedShrine", amount, "Cursed Shrines");
    public static void SpawnGreedShrines(int amount = 3) => SpawnSpecificInteractable("GreedShrine", amount, "Greed Shrines");
    public static void SpawnMagnetShrines(int amount = 3) => SpawnSpecificInteractable("MagnetShrine", amount, "Magnet Shrines");
    public static void SpawnMoaiShrines(int amount = 3) => SpawnSpecificInteractable("ShrineMaoi", amount, "Moai Shrines");
    public static void SpawnShadyMerchant(int amount = 1) => SpawnSpecificInteractable("ShadyGuy", amount, "Shady Merchant");
    
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
    public static void SpawnShrines(int amount = 6)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            MelonLogger.Error("[BonkMenu] RandomObjectPlacer not found!");
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
                MelonLogger.Msg($"[BonkMenu] Spawned {amount} Charge Shrines!");
            }
            catch (Exception ex)
            {
                MelonLogger.Error("[BonkMenu] Failed to spawn Charge Shrines: " + ex.Message);
            }
        }
        else
        {
            MelonLogger.Error("[BonkMenu] Charge Shrine prefabs not found in RandomObjectPlacer!");
        }
    }

    // Gold Charge Shrines - Uses Harmony patch to convert shrines to golden during native spawn
    public static void SpawnGoldShrines(int amount = 6)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            MelonLogger.Error("[BonkMenu] RandomObjectPlacer not found!");
            return;
        }

        if (placer.chargeShrineSpawns == null || placer.chargeShrineSpawns.prefabs == null || placer.chargeShrineSpawns.prefabs.Length == 0)
        {
            MelonLogger.Error("[BonkMenu] Charge Shrine prefabs not found in RandomObjectPlacer!");
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
            
            MelonLogger.Msg($"[BonkMenu] Spawned {amount} Golden Shrines using native positioning + Harmony patch!");
        }
        catch (Exception ex)
        {
            MelonLogger.Error("[BonkMenu] Failed to spawn Golden Shrines: " + ex.Message);
            MelonLogger.Error($"[BonkMenu] Stack trace: " + ex.StackTrace);
            
            // Reset the flag on error
            BonkMenu.Patches.GoldenShrinePatch.SpawnNextAsGolden = false;
            BonkMenu.Patches.GoldenShrinePatch.GoldenShrinesRemaining = 0;
        }
    }

    public static void SpawnPots(int amountMultiplier = 1)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        
        if ((Object)(object)placer == (Object)null)
        {
            MelonLogger.Error("[BonkMenu] RandomObjectPlacer not found!");
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
                MelonLogger.Msg("[BonkMenu] Found and added Silver Pot!");
            }
            else
            {
                MelonLogger.Warning("[BonkMenu] Could not find Silver Pot prefab on any pot objects.");
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
                MelonLogger.Msg($"[BonkMenu] Spawned {potsToSpawn.Count} types of pots (x{amountMultiplier} multiplier)!");
            }
            else
            {
                MelonLogger.Warning("[BonkMenu] No pot objects found to spawn.");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error("[BonkMenu] Failed to spawn pots: " + ex.Message);
        }
    }

    public static void SpawnMicrowaves(int amountMultiplier = 1)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            MelonLogger.Error("[BonkMenu] RandomObjectPlacer not found!");
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
                MelonLogger.Msg($"[BonkMenu] Spawned Microwaves (x{amountMultiplier} multiplier)!");
            }
            else
            {
                MelonLogger.Warning("[BonkMenu] No microwave objects found.");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error("[BonkMenu] Failed to spawn microwaves: " + ex.Message);
        }
    }



    public static void SpawnGreedAltars(int amount = 3)
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            MelonLogger.Error("[BonkMenu] RandomObjectPlacer not found!");
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
                MelonLogger.Msg($"[BonkMenu] Spawned {amount} Greed Altars!");
            }
            else
            {
                MelonLogger.Warning("[BonkMenu] No Greed Altar objects found.");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error("[BonkMenu] Failed to spawn Greed Altars: " + ex.Message);
        }
    }
}
