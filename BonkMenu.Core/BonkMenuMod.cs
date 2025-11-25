using System;
using System.Linq;
using BonkMenu.Features;
using BonkMenu.UI;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Enemies;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Managers;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnityEngine;
using UniverseLib.Input;

namespace BonkMenu.Core;

public class BonkMenuMod : MelonMod
{
	public const string ModName = "BonkMenu";

	public const string ModVersion = "1.0.0";

	public const string ModAuthor = "Goodzy";

	private bool _uiInitialized = false;
	private bool _hasModifiedXpMultiplier = false;

	public override void OnInitializeMelon()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg("=== BonkMenu Initialized ===");
		KeybindConfig.LoadKeybinds();
		MelonLogger.Msg("Key binds:");
		MelonLogger.Msg($"  {KeybindConfig.ToggleMenuKey} - Toggle UI Menu");
		MelonLogger.Msg($"  {KeybindConfig.GodModeKey} - Toggle God Mode");
		MelonLogger.Msg($"  {KeybindConfig.AddGoldKey} - Add 10k Gold");
		MelonLogger.Msg($"  {KeybindConfig.KillEnemiesKey} - Kill All Enemies");
		MelonLogger.Msg($"  {KeybindConfig.SpawnEnemyKey} - Spawn Enemy");
		MelonLogger.Msg("==============================");
	}

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)
	{
		MelonLogger.Msg($"Scene loaded: {sceneName} (index: {buildIndex})");
		if (!_hasModifiedXpMultiplier && sceneName == "GeneratedMap")
		{
			try 
			{ 
				System.Type playerXpType = null;
				foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
				{
					try { playerXpType = asm.GetTypes().FirstOrDefault(x => x.Name == "PlayerXp"); if (playerXpType != null) break; } catch { }
				}
				if (playerXpType != null) 
				{ 
					var prop = playerXpType.GetProperty("maxXpMultiplier", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public); 
					if (prop != null) 
					{ 
						prop.SetValue(null, 99999f); 
						MelonLogger.Msg("✅ XP MULT UNCAPPED!"); 
						_hasModifiedXpMultiplier = true; 
					} 
				} 
			} 
			catch { }
		}
	}

	public override void OnUpdate()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		if (!_uiInitialized)
		{
			UniverseUI.Initialize();
			_uiInitialized = true;
		}
		UniverseUI.Update();
		StatsFeatures.Update();
		if (InputManager.GetKeyDown(KeybindConfig.ToggleMenuKey))
		{
			UniverseUI.Toggle();
		}
		if (InputManager.GetKeyDown(KeybindConfig.GodModeKey))
		{
			ModConfig.ToggleInfiniteHealth();
		}
		if (InputManager.GetKeyDown(KeybindConfig.AddGoldKey))
		{
			try
			{
				GameManager instance = GameManager.Instance;
				object obj;
				if ((Object)(object)instance == (Object)null)
				{
					obj = null;
				}
				else
				{
					MyPlayer player = instance.player;
					obj = (((Object)(object)player != (Object)null) ? player.inventory : null);
				}
				if (obj != null)
				{
					GameManager.Instance.player.inventory.ChangeGold(ModConfig.GoldAmount);
					MelonLogger.Msg($"Added {ModConfig.GoldAmount} gold! Total: {GameManager.Instance.player.inventory.goldInt}");
				}
			}
			catch
			{
				MelonLogger.Error("Failed to add gold - player not loaded yet");
			}
		}
		if (InputManager.GetKeyDown(KeybindConfig.KillEnemiesKey))
		{
			try
			{
				Il2CppArrayBase<Enemy> val = Object.FindObjectsOfType<Enemy>();
				if (val != null && val.Length > 0)
				{
					int num = 0;
					foreach (Enemy item in val)
					{
						if ((Object)item != (Object)null && !item.IsDead())
						{
							item.Kill();
							num++;
						}
					}
					MelonLogger.Msg($"\ud83d\udc80 Killed {num} enemies!");
				}
				else
				{
					MelonLogger.Msg("No enemies found to kill");
				}
			}
			catch (Exception ex)
			{
				MelonLogger.Error("Failed to kill enemies: " + ex.Message);
			}
		}
		if (InputManager.GetKeyDown(KeybindConfig.SpawnEnemyKey))
		{
			try
			{
				EnemyManager instance2 = EnemyManager.Instance;
				if (!((Object)(((Object)(object)instance2 != (Object)null) ? instance2.testEnemy : null) != (Object)null))
				{
					goto IL_034b;
				}
				GameManager instance3 = GameManager.Instance;
				if (!((Object)(((Object)(object)instance3 != (Object)null) ? instance3.player : null) != (Object)null))
				{
					goto IL_034b;
				}
				Vector3 position = ((Component)GameManager.Instance.player).transform.position;
				Vector3 val2 = position + new Vector3(3f, 0f, 3f);
				Enemy val3 = instance2.SpawnEnemy(instance2.testEnemy, val2, 0, true, (EEnemyFlag)0, true);
				if ((Object)val3 != (Object)null)
				{
					MelonLogger.Msg("\ud83d\udc79 Spawned enemy: " + instance2.testEnemy.displayName);
				}
				else
				{
					MelonLogger.Error("Failed to spawn enemy - SpawnEnemy returned null");
				}
				goto end_IL_0255;
				IL_034b:
				MelonLogger.Error("EnemyManager or testEnemy is null");
				end_IL_0255:;
			}
			catch (Exception ex2)
			{
				MelonLogger.Error("Failed to spawn enemy: " + ex2.Message);
			}
		}
		if (ModConfig.InfiniteRefreshes)
		{
			try
			{
				GameManager instance4 = GameManager.Instance;
				object obj3;
				if ((Object)(object)instance4 == (Object)null)
				{
					obj3 = null;
				}
				else
				{
					MyPlayer player2 = instance4.player;
					obj3 = (((Object)(object)player2 != (Object)null) ? player2.inventory : null);
				}
				if (obj3 != null)
				{
					GameManager.Instance.player.inventory.refreshes = 999;
					GameManager.Instance.player.inventory.banishes = 999;
					GameManager.Instance.player.inventory.skips = 999;
					GameManager.Instance.player.inventory.refreshesUsed = 0;
					GameManager.Instance.player.inventory.banishesUsed = 0;
					GameManager.Instance.player.inventory.skipsUsed = 0;
				}
			}
			catch
			{
			}
		}
		if (ModConfig.NoCooldowns)
		{
			try
			{
				GameManager instance5 = GameManager.Instance;
				object obj5;
				if ((Object)(object)instance5 == (Object)null)
				{
					obj5 = null;
				}
				else
				{
					MyPlayer player3 = instance5.player;
					if ((Object)(object)player3 == (Object)null)
					{
						obj5 = null;
					}
					else
					{
						PlayerInventory inventory = player3.inventory;
						obj5 = ((inventory != null) ? inventory.activeAbility : null);
					}
				}
				if (obj5 != null)
				{
					GameManager.Instance.player.inventory.activeAbility.readyAtTime = 0f;
				}
			}
			catch
			{
			}
		}
		if (!ModConfig.FreezeEnemies)
		{
			return;
		}
		try
		{
			if (!((Object)EnemyManager.Instance != (Object)null))
			{
				return;
			}
			var enumerator2 = EnemyManager.Instance.enemies.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				KeyValuePair<uint, Enemy> current2 = enumerator2.Current;
				Enemy value = current2.Value;
				if ((Object)value != (Object)null && !value.IsDead())
				{
					value.Freeze();
				}
			}
		}
		catch
		{
		}
	}
}
