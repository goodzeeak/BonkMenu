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
		MelonLogger.Msg("[BonkMenu] === BonkMenu Initialized ===");
		KeybindConfig.LoadKeybinds();
		MelonLogger.Msg($"[BonkMenu] Press {KeybindConfig.ToggleMenuKey} to toggle menu");
		MelonLogger.Msg("[BonkMenu] ==============================");
	}

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)
	{

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
