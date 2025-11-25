using System;
using System.Collections.Generic;
using System.Reflection;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Game.MapGeneration;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using UnityEngine;
using UniverseLib;

namespace BonkMenu.Features;

public static class WorldFeatures
{
	public static Vector3 savedPosition = Vector3.zero;

	public static void ForceSandstorm()
	{
		MelonLogger.Msg("Force Sandstorm - Coming Soon");
	}

	public static void SpawnMapObject(string type)
	{
		MelonLogger.Msg("[SpawnMapObject] Starting spawn for: " + type);
		try
		{
			MapGenerationController val = Object.FindObjectOfType<MapGenerationController>();
			if ((Object)(object)val == (Object)null)
			{
				MelonLogger.Error("[SpawnMapObject] MapGenerationController not found!");
				return;
			}
			MelonLogger.Msg("[SpawnMapObject] MapGenerationController found");
			SpawnInteractables interactablesSpawner = val.interactablesSpawner;
			RandomObjectPlacer randomObjectPlacer = val.randomObjectPlacer;
			string text = type.ToLower();
			MelonLogger.Msg("[SpawnMapObject] Processing type: " + text);
			switch (text)
			{
			case "microwave":
			case "charge shrine":
			case "greed altar":
			case "pot small":
			case "pot big":
			case "pot small silver":
			case "pot big silver":
			case "boulder":
			case "tree 0":
				SpawnSpecificObject(GetPrefabName(text));
				break;
			case "log 0":
				SpawnMoai(interactablesSpawner);
				break;
			default:
				SpawnSpecificObject(type);
				break;
			}
			MelonLogger.Msg("[SpawnMapObject]Completed processing for: " + type);
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SpawnMapObject] CRITICAL ERROR spawning " + type + ": " + ex.Message);
			MelonLogger.Error("[SpawnMapObject] Stack Trace: " + ex.StackTrace);
		}
	}

	private static string GetPrefabName(string type)
	{
		if (1 == 0)
		{
		}
		string result = type switch
		{
			"microwave" => "Microwave", 
			"charge shrine" => "ChargeShrine", 
			"greed altar" => "GreedShrine", 
			"pot small" => "PotSmall", 
			"pot big" => "PotBig", 
			"pot small silver" => "PotSmallSilver", 
			"pot big silver" => "PotBigSilver", 
			"boulder" => "Boulder", 
			"tree 0" => "Tree0", 
			_ => type, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	private static void SpawnMoai(SpawnInteractables interactables)
	{
		MelonLogger.Msg("[SpawnMoai] Attempting to spawn Moai");
		try
		{
			MethodInfo method = typeof(SpawnInteractables).GetMethod("SpawnOther", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method != null)
			{
				method.Invoke(interactables, null);
				MelonLogger.Msg("[SpawnMoai] Successfully spawned Moai via SpawnOther");
			}
			else
			{
				MelonLogger.Error("[SpawnMoai] Could not find SpawnOther method");
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SpawnMoai] Error: " + ex.Message);
			MelonLogger.Error("[SpawnMoai] Stack Trace: " + ex.StackTrace);
		}
	}

	public static void SpawnSpecificObject(string prefabName)
	{
		MelonLogger.Msg("[SpawnSpecificObject] Searching for: " + prefabName);
		try
		{
			MapGenerationController val = Object.FindObjectOfType<MapGenerationController>();
			if ((Object)(object)val == (Object)null)
			{
				MelonLogger.Error("[SpawnSpecificObject] MapGenerationController not found!");
				return;
			}
			RandomObjectPlacer randomObjectPlacer = val.randomObjectPlacer;
			if ((Object)(object)randomObjectPlacer == (Object)null)
			{
				MelonLogger.Error("[SpawnSpecificObject] RandomObjectPlacer not found!");
				return;
			}
			MelonLogger.Msg("[SpawnSpecificObject] Searching in RandomObjectPlacer.randomObjects");
			if (TrySpawnFromList(randomObjectPlacer.randomObjects, prefabName, randomObjectPlacer))
			{
				MelonLogger.Msg("[SpawnSpecificObject] Found and spawned " + prefabName + " from RandomObjectPlacer");
				return;
			}
			if ((Object)(object)val.testStageData != (Object)null && val.testStageData.randomMapObjects != null)
			{
				MelonLogger.Msg("[SpawnSpecificObject] Searching in StageData");
				if (TrySpawnFromList(val.testStageData.randomMapObjects, prefabName, randomObjectPlacer))
				{
					MelonLogger.Msg("[SpawnSpecificObject] Found and spawned " + prefabName + " from StageData");
					return;
				}
			}
			MelonLogger.Msg("[SpawnSpecificObject] Starting fallback search for: " + prefabName);
			GameObject[] array = RuntimeHelper.FindObjectsOfTypeAll<GameObject>();
			MelonLogger.Msg($"[SpawnSpecificObject] Found {array.Length} total GameObjects");
			GameObject[] array2 = array;
			foreach (GameObject val2 in array2)
			{
				try
				{
					if ((Object)(object)val2 != (Object)null && ((Object)val2).name == prefabName)
					{
						MelonLogger.Msg("[SpawnSpecificObject] Found matching GameObject: " + prefabName);
						SpawnOther(val2);
						return;
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[SpawnSpecificObject] Error checking object: " + ex.Message);
				}
			}
			MelonLogger.Warning("[SpawnSpecificObject] Could not find prefab: " + prefabName);
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[SpawnSpecificObject] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[SpawnSpecificObject] Stack Trace: " + ex2.StackTrace);
		}
	}

	private static void SpawnOther(GameObject prefab)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)prefab == (Object)null)
		{
			MelonLogger.Error("[SpawnOther] Prefab is null!");
			return;
		}
		MelonLogger.Msg("[SpawnOther] Spawning: " + ((Object)prefab).name);
		try
		{
			MyPlayer instance = MyPlayer.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[SpawnOther] Player instance not found!");
				return;
			}
			Vector2 val = Random.insideUnitCircle * 15f;
			Vector3 val2 = default(Vector3);
			val2 = new Vector3(val.x, 0f, val.y);
			Vector3 val3 = ((Component)instance).transform.position + val2;
			Vector3 val4;
			if (GetGroundPosition(val3, out var groundPos))
			{
				val4 = groundPos;
				MelonLogger.Msg($"[SpawnOther] Ground found at: {val4}");
			}
			else
			{
				val4 = val3;
				MelonLogger.Warning($"[SpawnOther] Ground NOT found, using default height: {val4}");
			}
			Quaternion val5 = ((!((Object)prefab).name.Contains("ShadyGuy") && !((Object)prefab).name.Contains("Moai")) ? Quaternion.Euler(-90f, (float)Random.Range(0, 360), 0f) : Quaternion.Euler(0f, (float)Random.Range(0, 360), 0f));
			GameObject val6 = Object.Instantiate<GameObject>(prefab, val4, val5);
			if ((Object)(object)val6 == (Object)null)
			{
				MelonLogger.Error("[SpawnOther] Failed to instantiate " + ((Object)prefab).name);
				return;
			}
			val6.transform.localScale = Vector3.one;
			val6.SetActive(true);
			Component component = val6.GetComponent("ShadyGuy");
			if ((Object)(object)component != (Object)null)
			{
				MelonLogger.Msg("[SpawnOther] Destroying ShadyGuy script to prevent invisibility");
				Object.Destroy((Object)(object)component);
			}
			Il2CppArrayBase<Renderer> componentsInChildren = val6.GetComponentsInChildren<Renderer>(true);
			MelonLogger.Msg($"[SpawnOther] Active: {val6.activeInHierarchy}, Renderers: {componentsInChildren.Length}");
			foreach (Renderer item in componentsInChildren)
			{
				item.enabled = true;
				((Component)item).gameObject.SetActive(true);
			}
			MelonLogger.Msg($"[SpawnOther] Successfully spawned {((Object)prefab).name} at {val4}");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SpawnOther] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[SpawnOther] Stack Trace: " + ex.StackTrace);
		}
	}

	private static bool GetGroundPosition(Vector3 startPos, out Vector3 groundPos)
	{
		Vector3 val = startPos;
		val.y += 20f;
		RaycastHit val2;
		if (Physics.Raycast(val, Vector3.down, out val2, 50f) && !val2.collider.isTrigger && val2.transform.name != "Player")
		{
			groundPos = val2.point;
			MelonLogger.Msg($"[GetGroundPosition] Hit: {val2.collider.name} on Layer: {val2.collider.gameObject.layer}");
			return true;
		}
		groundPos = startPos;
		return false;
	}

	private static bool TrySpawnFromList(Il2CppReferenceArray<RandomMapObject> list, string prefabName, RandomObjectPlacer placer)
	{
		if (list == null)
		{
			MelonLogger.Msg("[TrySpawnFromList] List is null");
			return false;
		}
		try
		{
			foreach (RandomMapObject item in (Il2CppArrayBase<RandomMapObject>)(object)list)
			{
				if (item == null || item.prefabs == null)
				{
					continue;
				}
				foreach (GameObject item2 in (Il2CppArrayBase<GameObject>)(object)item.prefabs)
				{
					if ((Object)(object)item2 != (Object)null && ((Object)item2).name == prefabName)
					{
						MelonLogger.Msg("[TrySpawnFromList] Found prefab: " + prefabName);
						MethodInfo method = typeof(RandomObjectPlacer).GetMethod("RandomObjectSpawner", BindingFlags.Instance | BindingFlags.NonPublic);
						if (method != null)
						{
							method.Invoke(placer, new object[1] { item });
							MelonLogger.Msg("[TrySpawnFromList] Successfully spawned: " + prefabName);
							return true;
						}
						MelonLogger.Error("[TrySpawnFromList] RandomObjectSpawner method not found");
					}
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[TrySpawnFromList] Error: " + ex.Message);
			MelonLogger.Error("[TrySpawnFromList] Stack Trace: " + ex.StackTrace);
		}
		return false;
	}

	public static void ListSpawnableObjects()
	{
		MelonLogger.Msg("[ListSpawnableObjects] Starting...");
		try
		{
			MapGenerationController val = Object.FindObjectOfType<MapGenerationController>();
			if ((Object)(object)val == (Object)null)
			{
				MelonLogger.Warning("[ListSpawnableObjects] MapGenerationController not found!");
				return;
			}
			MelonLogger.Msg("=== SPAWNABLE OBJECTS LIST ===");
			RandomObjectPlacer randomObjectPlacer = val.randomObjectPlacer;
			if ((Object)(object)randomObjectPlacer != (Object)null)
			{
				MelonLogger.Msg("--- RandomObjectPlacer ---");
				LogObjects(randomObjectPlacer.randomObjects);
				if (randomObjectPlacer.chargeShrineSpawns != null)
				{
					LogObject(randomObjectPlacer.chargeShrineSpawns);
				}
				if (randomObjectPlacer.greedShrines != null)
				{
					LogObject(randomObjectPlacer.greedShrines);
				}
			}
			if ((Object)(object)val.testStageData != (Object)null)
			{
				MelonLogger.Msg("--- StageData: " + ((Object)val.testStageData).name + " ---");
				LogObjects(val.testStageData.randomMapObjects);
			}
			SpawnInteractables interactablesSpawner = val.interactablesSpawner;
			if ((Object)(object)interactablesSpawner != (Object)null)
			{
				MelonLogger.Msg("--- Interactables ---");
				if ((Object)(object)interactablesSpawner.chest != (Object)null)
				{
					MelonLogger.Msg("  " + ((Object)interactablesSpawner.chest).name);
				}
				if ((Object)(object)interactablesSpawner.chestFree != (Object)null)
				{
					MelonLogger.Msg("  " + ((Object)interactablesSpawner.chestFree).name);
				}
			}
			MelonLogger.Msg("==============================");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[ListSpawnableObjects] Error: " + ex.Message);
			MelonLogger.Error("[ListSpawnableObjects] Stack Trace: " + ex.StackTrace);
		}
	}

	public static void DumpAllObjectNames()
	{
		MelonLogger.Msg("[DumpAllObjectNames] Starting full dump...");
		try
		{
			GameObject[] array = RuntimeHelper.FindObjectsOfTypeAll<GameObject>();
			HashSet<string> hashSet = new HashSet<string>();
			GameObject[] array2 = array;
			foreach (GameObject val in array2)
			{
				try
				{
					if ((Object)(object)val != (Object)null)
					{
						hashSet.Add(((Object)val).name);
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[DumpAllObjectNames] Error processing object: " + ex.Message);
				}
			}
			List<string> list = new List<string>(hashSet);
			list.Sort();
			MelonLogger.Msg($"=== ALL GAMEOBJECTS ({hashSet.Count}) ===");
			foreach (string item in list)
			{
				MelonLogger.Msg("  " + item);
			}
			MelonLogger.Msg("========================================");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[DumpAllObjectNames] Error: " + ex2.Message);
			MelonLogger.Error("[DumpAllObjectNames] Stack Trace: " + ex2.StackTrace);
		}
	}

	private static void LogObjects(Il2CppReferenceArray<RandomMapObject> list)
	{
		if (list == null)
		{
			return;
		}
		try
		{
			foreach (RandomMapObject item in (Il2CppArrayBase<RandomMapObject>)(object)list)
			{
				LogObject(item);
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[LogObjects] Error: " + ex.Message);
		}
	}

	private static void LogObject(RandomMapObject obj)
	{
		try
		{
			if (obj == null || obj.prefabs == null)
			{
				return;
			}
			foreach (GameObject item in (Il2CppArrayBase<GameObject>)(object)obj.prefabs)
			{
				if ((Object)(object)item != (Object)null)
				{
					MelonLogger.Msg("  " + ((Object)item).name);
				}
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[LogObject] Error: " + ex.Message);
		}
	}
}
