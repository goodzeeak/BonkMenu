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

	private static EncounterPrefabCache ExtractAllPrefabs()
	{
		var cache = new EncounterPrefabCache();
		
		MelonLogger.Msg("[WorldFeatures] Starting prefab extraction...");
		
		try
		{
			var allComponents = Object.FindObjectsOfType<MonoBehaviour>();
			MelonLogger.Msg($"[WorldFeatures] Found {allComponents.Length} total MonoBehaviour components");
			
			// Extract from SpawnInteractables
			foreach (var component in allComponents)
			{
				if (component.GetType().Name == "SpawnInteractables")
				{
					MelonLogger.Msg("[WorldFeatures] Found SpawnInteractables component!");
					
					var chestField = component.GetType().GetField("chest");
					var chestFreeField = component.GetType().GetField("chestFree");
					
					if (chestField != null)
					{
						cache.chest = chestField.GetValue(component) as GameObject;
						MelonLogger.Msg($"[WorldFeatures] Chest prefab: {(cache.chest != null ? "FOUND" : "NULL")}");
					}
					if (chestFreeField != null)
					{
						cache.chestFree = chestFreeField.GetValue(component) as GameObject;
						MelonLogger.Msg($"[WorldFeatures] ChestFree prefab: {(cache.chestFree != null ? "FOUND" : "NULL")}");
					}
				}
				
				// Extract from RandomObjectPlacer
				if (component.GetType().Name == "RandomObjectPlacer")
				{
					MelonLogger.Msg("[WorldFeatures] Found RandomObjectPlacer component!");
					
					var greedShrinesField = component.GetType().GetField("greedShrines");
					var chargeShrinesField = component.GetType().GetField("chargeShrineSpawns");
					var randomObjectsField = component.GetType().GetField("randomObjects");
					
					// Get greed shrine prefabs
					if (greedShrinesField != null)
					{
						var greedShrineObj = greedShrinesField.GetValue(component);
						if (greedShrineObj != null)
						{
							var prefabsField = greedShrineObj.GetType().GetField("prefabs");
							if (prefabsField != null)
							{
								var prefabs = prefabsField.GetValue(greedShrineObj) as GameObject[];
								if (prefabs != null && prefabs.Length > 0)
								{
									cache.greedAltar = prefabs[0];
									MelonLogger.Msg($"[WorldFeatures] Greed altar prefab: FOUND ({prefabs.Length} variants)");
								}
							}
						}
					}
					
					// Get charge shrine prefabs
					if (chargeShrinesField != null)
					{
						var chargeShrineObj = chargeShrinesField.GetValue(component);
						if (chargeShrineObj != null)
						{
							var prefabsField = chargeShrineObj.GetType().GetField("prefabs");
							if (prefabsField != null)
							{
								var prefabs = prefabsField.GetValue(chargeShrineObj) as GameObject[];
								if (prefabs != null && prefabs.Length > 0)
								{
									cache.chargeShrine = prefabs[0];
									MelonLogger.Msg($"[WorldFeatures] Charge shrine prefab: FOUND ({prefabs.Length} variants)");
								}
							}
						}
					}
					
					// Get random objects (contains pots, shrines, altars, etc.)
					if (randomObjectsField != null)
					{
						var randomObjects = randomObjectsField.GetValue(component) as Array;
						if (randomObjects != null)
						{
							MelonLogger.Msg($"[WorldFeatures] Found {randomObjects.Length} random object groups");
							
							foreach (var randomObj in randomObjects)
							{
								if (randomObj == null) continue;
								
								var prefabsField = randomObj.GetType().GetField("prefabs");
								if (prefabsField != null)
								{
									var prefabs = prefabsField.GetValue(randomObj) as GameObject[];
									if (prefabs != null)
									{
										foreach (var prefab in prefabs)
										{
											if (prefab == null) continue;
											
											// Identify prefab by component type names
											foreach (var comp in prefab.GetComponents<MonoBehaviour>())
											{
												var compType = comp.GetType().Name;
												
												if (cache.pot == null && compType == "InteractablePot")
												{
													cache.pot = prefab;
													MelonLogger.Msg("[WorldFeatures] Pot prefab: FOUND");
												}
												if (cache.shadyGuy == null && compType == "InteractableShadyGuy")
												{
													cache.shadyGuy = prefab;
													MelonLogger.Msg("[WorldFeatures] Shady Guy prefab: FOUND");
												}
												if (cache.microwave == null && compType == "InteractableMicrowave")
												{
													cache.microwave = prefab;
													MelonLogger.Msg("[WorldFeatures] Microwave prefab: FOUND");
												}
												if (cache.moai == null && compType == "InteractableShrineMoai")
												{
													cache.moai = prefab;
													MelonLogger.Msg("[WorldFeatures] Moai prefab: FOUND");
												}
												if (cache.balanceShrine == null && compType == "InteractableShrineBalance")
												{
													cache.balanceShrine = prefab;
													MelonLogger.Msg("[WorldFeatures] Balance Shrine prefab: FOUND");
												}
											}
										}
									}
								}
							}
						}
					}
				}
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
