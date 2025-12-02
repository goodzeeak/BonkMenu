using System;
using System.Reflection;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Enemies;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Managers;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Features;

/// <summary>
/// Combat utilities for killing and spawning enemies.
/// </summary>
public static class CombatFeatures
{
    /// <summary>
    /// Kills all living enemies currently present.
    /// </summary>
    public static void KillAllEnemies()
	{
		MelonLogger.Msg("[KillAllEnemies] Starting enemy kill sequence");
		try
		{
			Il2CppArrayBase<Enemy> val = Object.FindObjectsOfType<Enemy>();
			if (val == null)
			{
				MelonLogger.Warning("[KillAllEnemies] FindObjectsOfType returned null!");
				return;
			}
			MelonLogger.Msg($"[KillAllEnemies] Found {val.Length} total enemy objects");
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (Enemy item in val)
			{
				try
				{
					if ((Object)(object)item == (Object)null)
					{
						num3++;
						continue;
					}
					if (item.IsDead())
					{
						num2++;
						continue;
					}
					item.Kill();
					num++;
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[KillAllEnemies] Error killing individual enemy: " + ex.Message);
				}
			}
			MelonLogger.Msg($"[KillAllEnemies] Results - Killed: {num}, Already Dead: {num2}, Null: {num3}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[KillAllEnemies] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[KillAllEnemies] Stack Trace: " + ex2.StackTrace);
		}
	}

    /// <summary>
    /// Spawns the test enemy near the player.
    /// </summary>
    public static void SpawnEnemy()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg("[SpawnEnemy] Spawning test enemy");
		try
		{
			EnemyManager instance = EnemyManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[SpawnEnemy] EnemyManager.Instance is null!");
				return;
			}
			GameManager instance2 = GameManager.Instance;
			if ((Object)(object)instance2 == (Object)null)
			{
				MelonLogger.Error("[SpawnEnemy] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance2.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[SpawnEnemy] Player is null!");
				return;
			}
			EnemyData testEnemy = instance.testEnemy;
			if ((Object)(object)testEnemy == (Object)null)
			{
				MelonLogger.Error("[SpawnEnemy] Test enemy data is null!");
				return;
			}
			Vector3 val = ((Component)player).transform.position + new Vector3(3f, 0f, 3f);
			MelonLogger.Msg($"[SpawnEnemy] Spawn position: {val}, Enemy: {((Object)testEnemy).name}");
			instance.SpawnEnemy(testEnemy, val, 0, true, (EEnemyFlag)0, true);
			MelonLogger.Msg("[SpawnEnemy] Successfully spawned " + ((Object)testEnemy).name);
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SpawnEnemy] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[SpawnEnemy] Stack Trace: " + ex.StackTrace);
		}
	}

    /// <summary>
    /// Spawns a specific enemy by numeric id near the player.
    /// </summary>
    public static void SpawnSpecificEnemy(int enemyId)
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg($"[SpawnSpecificEnemy] Spawning enemy with ID: {enemyId}");
		try
		{
			EnemyManager instance = EnemyManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[SpawnSpecificEnemy] EnemyManager.Instance is null!");
				return;
			}
			GameManager instance2 = GameManager.Instance;
			if ((Object)(object)instance2 == (Object)null)
			{
				MelonLogger.Error("[SpawnSpecificEnemy] GameManager.Instance is null!");
				return;
			}
			MyPlayer player = instance2.player;
			if ((Object)(object)player == (Object)null)
			{
				MelonLogger.Error("[SpawnSpecificEnemy] Player is null!");
				return;
			}
			DataManager instance3 = DataManager.Instance;
			if ((Object)(object)instance3 == (Object)null)
			{
				MelonLogger.Error("[SpawnSpecificEnemy] DataManager.Instance is null!");
				return;
			}
			MethodInfo method = ((object)instance3).GetType().GetMethod("GetEnemyData");
			if (method == null)
			{
				MelonLogger.Error("[SpawnSpecificEnemy] Could not find GetEnemyData method!");
				return;
			}
			ParameterInfo[] parameters = method.GetParameters();
			if (parameters.Length == 0)
			{
				MelonLogger.Error("[SpawnSpecificEnemy] GetEnemyData has no parameters!");
				return;
			}
			Type parameterType = parameters[0].ParameterType;
			MelonLogger.Msg("[SpawnSpecificEnemy] Parameter type: " + parameterType.Name);
			object obj = Enum.ToObject(parameterType, enemyId);
			object obj2 = method.Invoke(instance3, new object[1] { obj });
			EnemyData val = (EnemyData)((obj2 is EnemyData) ? obj2 : null);
			if ((Object)(object)val == (Object)null)
			{
				MelonLogger.Warning($"[SpawnSpecificEnemy] EnemyData not found for ID: {enemyId}");
				return;
			}
			Vector3 val2 = ((Component)player).transform.position + new Vector3(3f, 0f, 3f);
			MelonLogger.Msg($"[SpawnSpecificEnemy] Spawning {((Object)val).name} at {val2}");
			instance.SpawnEnemy(val, val2, 0, true, (EEnemyFlag)0, true);
			MelonLogger.Msg("[SpawnSpecificEnemy] Successfully spawned " + ((Object)val).name);
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SpawnSpecificEnemy] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[SpawnSpecificEnemy] Stack Trace: " + ex.StackTrace);
		}
	}
}
