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

    public static void SpawnChests()
    {
        SpawnInteractables spawner = Object.FindObjectOfType<SpawnInteractables>();
        if ((Object)(object)spawner != (Object)null)
        {
            spawner.SpawnChests();
            MelonLogger.Msg("[BonkMenu] Chests Spawned!");
        }
        else
        {
            MelonLogger.Warning("[BonkMenu] SpawnInteractables instance not found!");
        }
    }

    public static void SpawnFreeChests()
    {
        SpawnInteractables spawner = Object.FindObjectOfType<SpawnInteractables>();
        if ((Object)(object)spawner != (Object)null)
        {
            try
            {
                // Reflection to force free chest chance to 100%
                IntPtr il2CppClass = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpawnInteractables");
                IntPtr il2CppField = IL2CPP.GetIl2CppField(il2CppClass, "chanceForFreeChest");
                
                unsafe
                {
                    nint offset = (nint)IL2CPP.il2cpp_field_get_offset(il2CppField);
                    nint ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)spawner);
                    nint fieldAddr = ptr + (int)offset;
                    
                    float originalChance = *(float*)fieldAddr;
                    *(float*)fieldAddr = 1f;
                    
                    spawner.SpawnChests();
                    MelonLogger.Msg("[BonkMenu] Spawned FREE chests!");
                    
                    *(float*)fieldAddr = originalChance;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[BonkMenu] Error spawning free chests: " + ex);
            }
        }
        else
        {
            MelonLogger.Warning("[BonkMenu] SpawnInteractables instance not found!");
        }
    }

    public static void SpawnStatues()
    {
        SpawnInteractables spawner = Object.FindObjectOfType<SpawnInteractables>();
        if ((Object)(object)spawner != (Object)null)
        {
            spawner.SpawnShrines();
            MelonLogger.Msg("[BonkMenu] Statues Spawned!");
        }
        else
        {
            MelonLogger.Warning("[BonkMenu] SpawnInteractables instance not found!");
        }
    }

    public static void SpawnShrines()
    {
        RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
        if ((Object)(object)placer == (Object)null)
        {
            MelonLogger.Error("[BonkMenu] RandomObjectPlacer not found!");
            return;
        }
        try
        {
            int amount = 6;
            var field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomObjectPlacer>.NativeClassPtr, "numChargeShrines");
            unsafe
            {
                *(int*)(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)placer) + (int)IL2CPP.il2cpp_field_get_offset(field)) = amount;
            }
            
            // Create array with just the chargeShrineSpawns object to avoid spawning pots
            var shrineArray = new Il2CppReferenceArray<RandomMapObject>(1);
            shrineArray[0] = placer.chargeShrineSpawns;
            placer.Generate(shrineArray);
            
            MelonLogger.Msg($"[BonkMenu] Spawned {amount} Shrines!");
        }
        catch (Exception ex)
        {
            MelonLogger.Error("[BonkMenu] Failed to spawn shrines: " + ex.Message);
        }
    }

    public static void SpawnPots()
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
                var potArray = new Il2CppReferenceArray<RandomMapObject>(potsToSpawn.Count);
                for (int i = 0; i < potsToSpawn.Count; i++)
                {
                    potArray[i] = potsToSpawn[i];
                }
                placer.Generate(potArray);
                MelonLogger.Msg($"[BonkMenu] Spawned {potsToSpawn.Count} types of pots!");
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

    public static void SpawnMicrowaves()
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
                var microwaveArray = new Il2CppReferenceArray<RandomMapObject>(microwavesToSpawn.Count);
                for (int i = 0; i < microwavesToSpawn.Count; i++)
                {
                    microwaveArray[i] = microwavesToSpawn[i];
                }
                placer.Generate(microwaveArray);
                MelonLogger.Msg("[BonkMenu] Spawned Microwaves!");
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
}
