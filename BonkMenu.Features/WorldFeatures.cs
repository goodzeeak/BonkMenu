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
		public GameObject chargeShrine;
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
			// Try Method 1: Load from Resources by name
			MelonLogger.Msg("[WorldFeatures] Method 1: Attempting to load prefabs from Resources...");
			
			// Try loading common prefab names
			var resourcePrefabs = Resources.LoadAll<GameObject>("");
			MelonLogger.Msg($"[WorldFeatures] Found {resourcePrefabs.Length} total GameObjects in Resources");
			
			foreach (var prefab in resourcePrefabs)
			{
				if (prefab == null) continue;
				var name = prefab.name.ToLower();
				
				// Check for chest types
				if (name.Contains("chest") && !name.Contains("free"))
				{
					if (cache.chest == null) cache.chest = prefab;
					MelonLogger.Msg($"[WorldFeatures] Found chest: {prefab.name}");
				}
				if (name.Contains("chestfree") || (name.Contains("chest") && name.Contains("free")))
				{
					if (cache.chestFree == null) cache.chestFree = prefab;
					MelonLogger.Msg($"[WorldFeatures] Found free chest: {prefab.name}");
				}
				
				// Check components for other types
				foreach (var comp in prefab.GetComponents<MonoBehaviour>())
				{
					var compType = comp.GetType().Name;
					
					if (cache.greedAltar == null && compType == "InteractableAltarGreed")
					{
						cache.greedAltar = prefab;
						MelonLogger.Msg($"[WorldFeatures] Found greed altar: {prefab.name}");
					}
					if (cache.moai == null && compType == "InteractableShrineMoai")
					{
						cache.moai = prefab;
						MelonLogger.Msg($"[WorldFeatures] Found moai: {prefab.name}");
					}
					if (cache.shadyGuy == null && compType == "InteractableShadyGuy")
					{
						cache.shadyGuy = prefab;
						MelonLogger.Msg($"[WorldFeatures] Found shady guy: {prefab.name}");
					}
					if (cache.balanceShrine == null && compType == "InteractableShrineBalance")
					{
						cache.balanceShrine = prefab;
						MelonLogger.Msg($"[WorldFeatures] Found balance shrine: {prefab.name}");
					}
					if (cache.microwave == null && compType == "InteractableMicrowave")
					{
						cache.microwave = prefab;
						MelonLogger.Msg($"[WorldFeatures] Found microwave: {prefab.name}");
					}
					if (cache.pot == null && compType == "InteractablePot")
					{
						cache.pot = prefab;
						MelonLogger.Msg($"[WorldFeatures] Found pot: {prefab.name}");
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
				MelonLogger.Msg($"[WorldFeatures] ✅ Found {foundCount}/8 prefabs from Resources! Cache will persist.");
			}
			else
			{
				MelonLogger.Warning("[WorldFeatures] ⚠️ No prefabs found in Resources");
				MelonLogger.Warning("[WorldFeatures] Physical encounter spawning may not work");
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
