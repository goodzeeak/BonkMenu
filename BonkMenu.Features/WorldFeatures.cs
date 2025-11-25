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

			// Try to find SpawnInteractables which holds prefab references
			// This is more reliable than finding existing objects in scene
			var spawners = Object.FindObjectsOfType<MonoBehaviour>();
			GameObject chestPrefab = null;
			GameObject chestFreePrefab = null;

			// Search for SpawnInteractables component (it's in GlobalNamespace, so we search by field names)
			foreach (var spawner in spawners)
			{
				if (spawner.GetType().Name == "SpawnInteractables")
				{
					// Use reflection to get the prefab fields
					var chestField = spawner.GetType().GetField("chest");
					var chestFreeField = spawner.GetType().GetField("chestFree");

					if (chestField != null)
						chestPrefab = chestField.GetValue(spawner) as GameObject;
					if (chestFreeField != null)
						chestFreePrefab = chestFreeField.GetValue(spawner) as GameObject;

					if (chestPrefab != null || chestFreePrefab != null)
					{
						MelonLogger.Msg($"[WorldFeatures] Found SpawnInteractables with prefab references");
						break;
					}
				}
			}

			// Spawn based on encounter type
			GameObject spawnedObject = null;
			switch (encounterId)
			{
				case 3: // ChestNormal
					if ((Object)(object)chestPrefab != (Object)null)
					{
						spawnedObject = Object.Instantiate(chestPrefab, spawnPosition, Quaternion.identity);
						var chestComponent = spawnedObject.GetComponent<InteractableChest>();
						if ((Object)(object)chestComponent != (Object)null)
						{
							chestComponent.chestType = (EChest)0; // Normal chest
						}
						MelonLogger.Msg($"[WorldFeatures] Spawned normal chest at {spawnPosition}");
					}
					else
					{
						MelonLogger.Warning("[WorldFeatures] Normal chest prefab not found");
					}
					break;

				case 4: // ChestFree
					if ((Object)(object)chestFreePrefab != (Object)null)
					{
						spawnedObject = Object.Instantiate(chestFreePrefab, spawnPosition, Quaternion.identity);
						var chestComponent = spawnedObject.GetComponent<InteractableChest>();
						if ((Object)(object)chestComponent != (Object)null)
						{
							chestComponent.chestType = (EChest)2; // Free chest
						}
						MelonLogger.Msg($"[WorldFeatures] Spawned free chest at {spawnPosition}");
					}
					else
					{
						MelonLogger.Warning("[WorldFeatures] Free chest prefab not found");
					}
					break;

				case 5: // ChestEvil (Corrupt)
					if ((Object)(object)chestPrefab != (Object)null)
					{
						spawnedObject = Object.Instantiate(chestPrefab, spawnPosition, Quaternion.identity);
						var chestComponent = spawnedObject.GetComponent<InteractableChest>();
						if ((Object)(object)chestComponent != (Object)null)
						{
							chestComponent.chestType = (EChest)1; // Corrupt chest
						}
						MelonLogger.Msg($"[WorldFeatures] Spawned corrupt chest at {spawnPosition}");
					}
					else
					{
						MelonLogger.Warning("[WorldFeatures] Corrupt chest prefab not found");
					}
					break;

				default:
					MelonLogger.Warning($"[WorldFeatures] Encounter type {encounterName} cannot be spawned as physical object yet");
					// Fall back to UI encounter for unsupported types
					EncounterWindows encounterWindows = Object.FindObjectOfType<EncounterWindows>();
					if ((Object)(object)encounterWindows != (Object)null)
					{
						EEncounter encounter = (EEncounter)encounterId;
						encounterWindows.AddEncounter(encounter);
						MelonLogger.Msg($"[WorldFeatures] Triggered UI encounter instead: {encounterName}");
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
