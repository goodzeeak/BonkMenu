using System;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.UI.InGame.Rewards;
using Il2CppAssets.Scripts.UI.InGame.Levelup;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Chests;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Features;

public static class WorldFeatures
{
	public static void TeleportPlayer(Vector3 position)
	{
		try
		{
			MyPlayer player = Object.FindObjectOfType<MyPlayer>();
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Warning("[WorldFeatures] Player not found - are you in a run?");
				return;
			}

			player.transform.position = position;
			MelonLogger.Msg($"[WorldFeatures] Teleported player to {position}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[WorldFeatures] Failed to teleport player: {ex.Message}");
		}
	}

	public static void TeleportToPlayerPosition(float forwardOffset = 3f)
	{
		try
		{
			MyPlayer player = Object.FindObjectOfType<MyPlayer>();
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Warning("[WorldFeatures] Player not found - are you in a run?");
				return;
			}

			Vector3 spawnPosition = player.transform.position + player.transform.forward * forwardOffset;
			MelonLogger.Msg($"[WorldFeatures] Created spawn position at {spawnPosition}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[WorldFeatures] Failed to get spawn position: {ex.Message}");
		}
	}
	
	// Prefab cache structure
	private class EncounterPrefabCache
	{
		public GameObject chest;
		public GameObject chestFree;
		public GameObject greedAltar;
		public GameObject balanceShrine;
		public GameObject moai;
		public GameObject shadyGuy;
		public GameObject microwave;
		public GameObject pot;
	}

	// Static cache that persists even when scene is unloaded (paused)
	private static EncounterPrefabCache _prefabCache = null;
	private static bool _cacheInitialized = false;

	private static EncounterPrefabCache ExtractAllPrefabs()
	{
		// If we already have a cache, use it
		if (_cacheInitialized && _prefabCache != null)
		{
			MelonLogger.Msg("[WorldFeatures] Using cached prefabs");
			return _prefabCache;
		}

		MelonLogger.Msg("[WorldFeatures] Starting prefab extraction...");
		var cache = new EncounterPrefabCache();
		
		try
		{
			// DIAGNOSTIC: Dump ALL available assets to file
			var allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
			MelonLogger.Msg($"[WorldFeatures] Found {allObjects.Length} total GameObjects");
			
			// Export to file for analysis
			var exportPath = "BonkMenu_AssetDump.txt";
			var sb = new System.Text.StringBuilder();
			sb.AppendLine("=== BONKMENU ASSET DUMP ===");
			sb.AppendLine($"Total GameObjects found: {allObjects.Length}");
			sb.AppendLine($"Timestamp: {System.DateTime.Now}");
			sb.AppendLine("");
			sb.AppendLine("=== ALL GAMEOBJECTS ===");
			
			int potentialPrefabCount = 0;
			foreach (var obj in allObjects)
			{
				if (obj == null) continue;
				
				var name = obj.name;
				var scene = obj.scene.name;
				var isPrefab = string.IsNullOrEmpty(scene);
				
				// Look for interactable components
				var components = new System.Collections.Generic.List<string>();
				foreach (var comp in obj.GetComponents<MonoBehaviour>())
				{
					if (comp == null) continue;
					var typeName = comp.GetType().Name;
					components.Add(typeName);
					
					// Check for encounter-related components
					if (typeName.Contains("Interactable") || typeName.Contains("Chest") || typeName.Contains("Shrine") || typeName.Contains("Altar"))
					{
						potentialPrefabCount++;
						sb.AppendLine($">>> POTENTIAL: {name} | Scene: {(isPrefab ? "[PREFAB]" : scene)} | Component: {typeName}");
					}
				}
				
				// Log all objects with their components
				if (components.Count > 0)
				{
					sb.AppendLine($"{name} | Scene: {(isPrefab ? "[PREFAB]" : scene)} | Components: {string.Join(", ", components)}");
				}
			}
			
			sb.AppendLine("");
			sb.AppendLine($"=== SUMMARY ===");
			sb.AppendLine($"Total GameObjects: {allObjects.Length}");
			sb.AppendLine($"Potential Encounter Prefabs: {potentialPrefabCount}");
			
			System.IO.File.WriteAllText(exportPath, sb.ToString());
			MelonLogger.Msg($"[WorldFeatures] ✅ Asset dump exported to: {exportPath}");
			MelonLogger.Msg($"[WorldFeatures] Found {potentialPrefabCount} potential encounter-related objects");
			
			// Now try to extract from the dump
			foreach (var obj in allObjects)
			{
				if (obj == null) continue;
				
				foreach (var comp in obj.GetComponents<MonoBehaviour>())
				{
					if (comp == null) continue;
					var compType = comp.GetType().Name;
					
					if (cache.chest == null && compType == "InteractableChest" && !obj.name.ToLower().Contains("free"))
					{
						cache.chest = obj;
						MelonLogger.Msg($"[WorldFeatures] Found chest: {obj.name}");
					}
					if (cache.chestFree == null && compType == "InteractableChest" && obj.name.ToLower().Contains("free"))
					{
						cache.chestFree = obj;
						MelonLogger.Msg($"[WorldFeatures] Found free chest: {obj.name}");
					}
					if (cache.greedAltar == null && compType == "InteractableAltarGreed")
					{
						cache.greedAltar = obj;
						MelonLogger.Msg($"[WorldFeatures] Found greed altar: {obj.name}");
					}
					if (cache.moai == null && compType == "InteractableShrineMoai")
					{
						cache.moai = obj;
						MelonLogger.Msg($"[WorldFeatures] Found moai: {obj.name}");
					}
					if (cache.shadyGuy == null && compType == "InteractableShadyGuy")
					{
						cache.shadyGuy = obj;
						MelonLogger.Msg($"[WorldFeatures] Found shady guy: {obj.name}");
					}
					if (cache.balanceShrine == null && compType == "InteractableShrineBalance")
					{
						cache.balanceShrine = obj;
						MelonLogger.Msg($"[WorldFeatures] Found balance shrine: {obj.name}");
					}
					if (cache.microwave == null && compType == "InteractableMicrowave")
					{
						cache.microwave = obj;
						MelonLogger.Msg($"[WorldFeatures] Found microwave: {obj.name}");
					}
					if (cache.pot == null && compType == "InteractablePot")
					{
						cache.pot = obj;
						MelonLogger.Msg($"[WorldFeatures] Found pot: {obj.name}");
					}
				}
			}
			
			// Count what we found
			int foundCount = 0;
			if (cache.chest != null) foundCount++;
			if (cache.chestFree != null) foundCount++;
			if (cache.greedAltar != null) foundCount++;
			if (cache.moai != null) foundCount++;
			if (cache.shadyGuy != null) foundCount++;
			if (cache.balanceShrine != null) foundCount++;
			if (cache.microwave != null) foundCount++;
			if (cache.pot != null) foundCount++;
			
			if (foundCount > 0)
			{
				_prefabCache = cache;
				_cacheInitialized = true;
				MelonLogger.Msg($"[WorldFeatures] ✅ Found {foundCount}/8 encounter prefabs! Cache will persist.");
			}
			else
			{
				MelonLogger.Warning("[WorldFeatures] ⚠️ No prefabs found - check BonkMenu_AssetDump.txt for details");
			}
			
			MelonLogger.Msg("[WorldFeatures] Prefab extraction complete");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[WorldFeatures] Error extracting prefabs: {ex.Message}");
			MelonLogger.Error($"[WorldFeatures] Stack trace: {ex.StackTrace}");
		}
		
		return cache;
	}
	
	// Public method to force refresh the cache (useful for testing)
	public static void RefreshPrefabCache()
	{
		MelonLogger.Msg("[WorldFeatures] Forcing prefab cache refresh...");
		_cacheInitialized = false;
		_prefabCache = null;
		ExtractAllPrefabs();
	}

	public static void SpawnEncounter(int encounterId, string encounterName)
	{
		MelonLogger.Msg($"[WorldFeatures] Spawning encounter: {encounterName} (ID: {encounterId})");
		try
		{
			MyPlayer player = Object.FindObjectOfType<MyPlayer>();
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Warning("[WorldFeatures] Player not found - are you in a run?");
				return;
			}

			// Calculate spawn position in front of player
			Vector3 spawnPosition = player.transform.position + player.transform.forward * 5f;
			spawnPosition.y = player.transform.position.y;

			// Extract all prefabs
			var prefabs = ExtractAllPrefabs();
			
			// Spawn based on encounter type
			GameObject spawnedObject = null;
			GameObject prefabToSpawn = null;
			string spawnName = "";

			switch (encounterId)
			{
				case 2: // GreedAltar
					prefabToSpawn = prefabs.greedAltar;
					spawnName = "Greed Altar";
					break;
					
				case 3: // ChestNormal
					prefabToSpawn = prefabs.chest;
					spawnName = "Normal Chest";
					if (prefabToSpawn != null)
					{
						spawnedObject = Object.Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
						var chest = spawnedObject.GetComponent<InteractableChest>();
						if (chest != null) chest.chestType = (EChest)0;
					}
					break;

				case 4: // ChestFree
					prefabToSpawn = prefabs.chestFree;
					spawnName = "Free Chest";
					if (prefabToSpawn != null)
					{
						spawnedObject = Object.Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
						var chest = spawnedObject.GetComponent<InteractableChest>();
						if (chest != null) chest.chestType = (EChest)2;
					}
					break;

				case 5: // ChestEvil
					prefabToSpawn = prefabs.chest;
					spawnName = "Corrupt Chest";
					if (prefabToSpawn != null)
					{
						spawnedObject = Object.Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
						var chest = spawnedObject.GetComponent<InteractableChest>();
						if (chest != null) chest.chestType = (EChest)1;
					}
					break;

				case 6: // Moai
					prefabToSpawn = prefabs.moai;
					spawnName = "Moai";
					break;

				case 7: // ShadyGuy
					prefabToSpawn = prefabs.shadyGuy;
					spawnName = "Shady Guy";
					break;

				case 8: // BalanceShrine
					prefabToSpawn = prefabs.balanceShrine;
					spawnName = "Balance Shrine";
					break;

				case 9: // Microwave
					prefabToSpawn = prefabs.microwave;
					spawnName = "Microwave";
					break;

				default:
					MelonLogger.Warning($"[WorldFeatures] Encounter type {encounterName} triggers UI screen");
					EncounterWindows encounterWindows = Object.FindObjectOfType<EncounterWindows>();
					if ((Object)(object)encounterWindows != (Object)null)
					{
						encounterWindows.AddEncounter((EEncounter)encounterId);
						MelonLogger.Msg($"[WorldFeatures] Triggered UI encounter: {encounterName}");
					}
					return;
			}

			// Handle non-chest spawning (cases 2, 6, 7, 8, 9)
			if (spawnedObject == null && prefabToSpawn != null)
			{
				spawnedObject = Object.Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
			}

			if (spawnedObject != null)
			{
				MelonLogger.Msg($"[WorldFeatures] Successfully spawned {spawnName} at {spawnPosition}");
			}
			else
			{
				MelonLogger.Warning($"[WorldFeatures] Prefab not found for {spawnName} - falling back to UI");
				EncounterWindows encounterWindows = Object.FindObjectOfType<EncounterWindows>();
				if ((Object)(object)encounterWindows != (Object)null)
				{
					encounterWindows.AddEncounter((EEncounter)encounterId);
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[WorldFeatures] Failed to spawn encounter {encounterName}: {ex.Message}");
			MelonLogger.Error($"[WorldFeatures] Stack trace: {ex.StackTrace}");
		}
	}

	public static void SpawnWorldObject(string objectType)
	{
		try
		{
			MyPlayer player = Object.FindObjectOfType<MyPlayer>();
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Warning("[WorldFeatures] Player not found - are you in a run?");
				return;
			}

			Vector3 spawnPosition = player.transform.position + player.transform.forward * 3f;

			MelonLogger.Msg($"[WorldFeatures] Attempting to spawn {objectType} at {spawnPosition}");
			MelonLogger.Warning($"[WorldFeatures] World object spawning not yet fully implemented for {objectType}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[WorldFeatures] Failed to spawn world object {objectType}: {ex.Message}");
		}
	}

	public static Vector3 GetPlayerPosition()
	{
		try
		{
			MyPlayer player = Object.FindObjectOfType<MyPlayer>();
			if ((Object)(object)player != (Object)null)
			{
				return player.transform.position;
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[WorldFeatures] Failed to get player position: {ex.Message}");
		}
		return Vector3.zero;
	}

	public static void TeleportRelative(float x, float y, float z)
	{
		try
		{
			MyPlayer player = Object.FindObjectOfType<MyPlayer>();
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Warning("[WorldFeatures] Player not found - are you in a run?");
				return;
			}

			Vector3 currentPos = player.transform.position;
			Vector3 newPos = new Vector3(currentPos.x + x, currentPos.y + y, currentPos.z + z);
			player.transform.position = newPos;
			MelonLogger.Msg($"[WorldFeatures] Teleported player by offset ({x}, {y}, {z}) to {newPos}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[WorldFeatures] Failed to teleport relatively: {ex.Message}");
		}
	}
}
