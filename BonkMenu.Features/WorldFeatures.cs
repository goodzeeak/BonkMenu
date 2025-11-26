using System;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.UI.InGame.Rewards;
using Il2CppAssets.Scripts.UI.InGame.Levelup;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Chests;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

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
			
			// Now try to extract by GameObject NAME (since IL2CPP hides component types)
			MelonLogger.Msg("[WorldFeatures] Searching for prefabs by name...");
			
			foreach (var obj in allObjects)
			{
				if (obj == null) continue;
				
				var name = obj.name;
				var nameLower = name.ToLower();
				var scene = obj.scene.name;
				
				// Look for scene objects we can clone as prefabs
				// Chests
				if (cache.chest == null && name.Contains("Chest") && !name.Contains("Free") && scene == "GeneratedMap")
				{
					cache.chest = obj;
					MelonLogger.Msg($"[WorldFeatures] Found chest prefab: {name}");
				}
				if (cache.chestFree == null && name.Contains("ChestFree") && scene == "GeneratedMap")
				{
					cache.chestFree = obj;
					MelonLogger.Msg($"[WorldFeatures] Found free chest prefab: {name}");
				}
				
				// Shrines and Altars
				if (cache.greedAltar == null && name.Contains("GreedShrine") && scene == "GeneratedMap")
				{
					cache.greedAltar = obj;
					MelonLogger.Msg($"[WorldFeatures] Found greed altar prefab: {name}");
				}
				if (cache.moai == null && name.Contains("ShrineMaoi") && scene == "GeneratedMap")
				{
					cache.moai = obj;
					MelonLogger.Msg($"[WorldFeatures] Found moai prefab: {name}");
				}
				if (cache.balanceShrine == null && nameLower.Contains("balance") && nameLower.Contains("shrine") && scene == "GeneratedMap")
				{
					cache.balanceShrine = obj;
					MelonLogger.Msg($"[WorldFeatures] Found balance shrine prefab: {name}");
				}
				
				// NPCs
				if (cache.shadyGuy == null && name.Contains("ShadyGuy") && scene == "GeneratedMap")
				{
					cache.shadyGuy = obj;
					MelonLogger.Msg($"[WorldFeatures] Found shady guy prefab: {name}");
				}
				
				// Interactables
				if (cache.microwave == null && name.Contains("Microwave") && scene == "GeneratedMap")
				{
					cache.microwave = obj;
					MelonLogger.Msg($"[WorldFeatures] Found microwave prefab: {name}");
				}
				if (cache.pot == null && nameLower.Contains("pot") && scene == "GeneratedMap")
				{
					cache.pot = obj;
					MelonLogger.Msg($"[WorldFeatures] Found pot prefab: {name}");
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

		// Use typed FindObjectOfType (BonkAdder's approach)
		SpawnInteractables spawner = Object.FindObjectOfType<SpawnInteractables>();
		if ((Object)(object)spawner == (Object)null)
		{
			MelonLogger.Error("[WorldFeatures] SpawnInteractables instance not found!");
			return;
		}

		// Call native methods directly
		switch (encounterId)
		{
			case 3: // ChestNormal
			case 4: // ChestFree
			case 5: // ChestEvil
				spawner.SpawnChests();
				MelonLogger.Msg("[WorldFeatures] ✅ Spawned chests batch");
				break;

			case 2: // GreedAltar
			case 8: // BalanceShrine
				// Use RandomObjectPlacer for actual shrines (BonkAdder's method)
				RandomObjectPlacer placer = Object.FindObjectOfType<RandomObjectPlacer>();
				if ((Object)(object)placer == (Object)null)
				{
					MelonLogger.Error("[WorldFeatures] RandomObjectPlacer not found!");
					break;
				}
				
				try
				{
					int numChargeShrines = 6;
					var field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomObjectPlacer>.NativeClassPtr, "numChargeShrines");
					unsafe
					{
						*(int*)(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)placer) + (int)IL2CPP.il2cpp_field_get_offset(field)) = numChargeShrines;
					}
					placer.GenerateInteractables();
					MelonLogger.Msg($"[WorldFeatures] ✅ Spawned {numChargeShrines} charge shrines");
				}
				catch (Exception ex)
				{
					MelonLogger.Error("[WorldFeatures] Failed to spawn shrines: " + ex.Message);
				}
				break;

			case 6: // Moai
			case 7: // ShadyGuy
			case 9: // Microwave
				// SpawnShrines() actually spawns statues/moai
				spawner.SpawnShrines();
				MelonLogger.Msg("[WorldFeatures] ✅ Spawned statues batch");
				break;

			default:
				MelonLogger.Warning($"[WorldFeatures] Encounter type {encounterName} triggers UI screen");
				EncounterWindows encounterWindows = Object.FindObjectOfType<EncounterWindows>();
				if ((Object)(object)encounterWindows != (Object)null)
				{
					encounterWindows.AddEncounter((EEncounter)encounterId);
					MelonLogger.Msg($"[WorldFeatures] Triggered UI encounter: {encounterName}");
				}
				break;
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
