using System;
using System.Linq;
using BonkMenu.Features;
using BonkMenu.UI;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Enemies;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Managers;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnityEngine;
using UniverseLib.Input;

namespace BonkMenu.Core;

/// <summary>
/// Main mod entrypoint: initializes patches, UI, and per-frame updates.
/// </summary>
public class BonkMenuMod : MelonMod
{
    /// <summary>
    /// Human-friendly mod name.
    /// </summary>
    public const string ModName = "BonkMenu";

    /// <summary>
    /// Mod version string.
    /// </summary>
    public const string ModVersion = "1.0.0";

    /// <summary>
    /// Mod author name.
    /// </summary>
    public const string ModAuthor = "Goodzy";

    private bool _uiInitialized = false;
    private bool _hasModifiedXpMultiplier = false;
    private bool _pendingXpUncap = false;
    private static readonly System.Collections.Generic.Dictionary<KeyCode, float> _nextSpawnTime = new System.Collections.Generic.Dictionary<KeyCode, float>();
    private const float SpawnRepeatInterval = 0.2f;
    private static readonly System.Collections.Generic.HashSet<KeyCode> _handledKeys = new System.Collections.Generic.HashSet<KeyCode>();

    /// <summary>
    /// Called when the mod is initialized.
    /// </summary>
    public override void OnInitializeMelon()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
        Log.Info("[BonkMenu] === BonkMenu Initialized ===");
        KeybindConfig.LoadKeybinds();
        Patches.Apply();
        Log.Info($"[BonkMenu] Press {KeybindConfig.ToggleMenuKey} to toggle menu");
        var mlVer = typeof(MelonMod).Assembly.GetName().Version;
        var uniVer = typeof(UniverseLib.Universe).Assembly.GetName().Version;
        Log.Info($"[BonkMenu] MelonLoader: {mlVer}");
        Log.Info($"[BonkMenu] UniverseLib: {uniVer}");
        try
        {
            var minVer = new Version(0,7,2,2367);
            if (mlVer != null && mlVer < minVer)
            {
                Log.Warn("[BonkMenu] MelonLoader below tested version 0.7.2.2367");
            }
        }
        catch {}
        Log.Info("[BonkMenu] ==============================");
	}

    /// <summary>
    /// Called after a scene is loaded.
    /// </summary>
    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
		// Automatically cache prefabs when entering a procedural run
		// if (sceneName == "GeneratedMap")
		// {
		// 	// Dump fields for discovery
		// 	// DumpFields("SpawnInteractables");
		// 	// DumpFields("RandomObjectPlacer");
		// }

        if ((ModConfig.UnlimitedXp || _pendingXpUncap) && !_hasModifiedXpMultiplier && sceneName == "GeneratedMap")
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
                        Log.Info("✅ XP MULT UNCAPPED!"); 
                        _hasModifiedXpMultiplier = true; 
                        _pendingXpUncap = false;
                    } 
                } 
            } 
            catch { }
        }
	}
	

    /// <summary>
    /// Per-frame update handler for UI and features.
    /// </summary>
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
        BonkMenu.UI.Components.UIFactory.TickToasts();
        _handledKeys.Clear();
		if (InputManager.GetKeyDown(KeybindConfig.ToggleMenuKey))
		{
			UniverseUI.Toggle();
		}

		if (InputManager.GetKeyDown(KeybindConfig.ToggleGodModeKey))
		{
			ModConfig.ToggleGodMode();
            BonkMenu.UI.Components.UIFactory.ShowToast("God Mode: " + (ModConfig.GodMode ? "ON" : "OFF"));
		}

        if (InputManager.GetKeyDown(KeybindConfig.ToggleUnlimitedXpKey))
        {
            ModConfig.ToggleUnlimitedXp();
            BonkMenu.UI.Components.UIFactory.ShowToast("Unlimited XP: " + (ModConfig.UnlimitedXp ? "ON" : "OFF"));
            if (ModConfig.UnlimitedXp)
            {
                _pendingXpUncap = true;
            }
            else
            {
                _pendingXpUncap = false;
                _hasModifiedXpMultiplier = false;
            }
        }

        HandleSpawnHold(KeybindConfig.SpawnChestsKey, () => WorldFeatures.SpawnChests(1), "Chest");
        HandleSpawnHold(KeybindConfig.SpawnFreeChestsKey, () => WorldFeatures.SpawnFreeChests(1), "Free Chest");
        HandleSpawnHold(KeybindConfig.SpawnChallengeShrinesKey, () => WorldFeatures.SpawnChallengeShrines(1), "Challenge Shrine");
        HandleSpawnHold(KeybindConfig.SpawnCursedShrinesKey, () => WorldFeatures.SpawnCursedShrines(1), "Cursed Shrine");
        HandleSpawnHold(KeybindConfig.SpawnGreedAltarsKey, () => WorldFeatures.SpawnGreedAltars(1), "Greed Altar");
        HandleSpawnHold(KeybindConfig.SpawnGreedShrinesKey, () => WorldFeatures.SpawnGreedShrines(1), "Greed Shrine");
        HandleSpawnHold(KeybindConfig.SpawnMagnetShrinesKey, () => WorldFeatures.SpawnMagnetShrines(1), "Magnet Shrine");
        HandleSpawnHold(KeybindConfig.SpawnMoaiShrinesKey, () => WorldFeatures.SpawnMoaiShrines(1), "Moai Shrine");
        HandleSpawnHold(KeybindConfig.SpawnChargeShrinesKey, () => WorldFeatures.SpawnShrines(1), "Charge Shrine");
        HandleSpawnHold(KeybindConfig.SpawnGoldChargeShrinesKey, () => WorldFeatures.SpawnGoldShrines(1), "Gold Shrine");
        HandleSpawnHold(KeybindConfig.SpawnPotsKey, () => WorldFeatures.SpawnPots(1), "Pots");
        HandleSpawnHold(KeybindConfig.SpawnMicrowavesKey, () => WorldFeatures.SpawnMicrowaves(1), "Microwaves");
        HandleSpawnHold(KeybindConfig.SpawnShadyMerchantKey, () => WorldFeatures.SpawnShadyMerchant(1), "Merchant");
        HandleSpawnHold(KeybindConfig.SpawnShadyMerchantRareKey, () => WorldFeatures.SpawnShadyMerchantRare(1), "Merchant (Rare)");
        HandleSpawnHold(KeybindConfig.SpawnShadyMerchantEpicKey, () => WorldFeatures.SpawnShadyMerchantEpic(1), "Merchant (Epic)");
        HandleSpawnHold(KeybindConfig.SpawnShadyMerchantLegendaryKey, () => WorldFeatures.SpawnShadyMerchantLegendary(1), "Merchant (Legendary)");

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

    

    


    private void HandleSpawnHold(KeyCode key, System.Action action, string toastLabel, int increment = 1)
    {
        bool down = InputManager.GetKeyDown(key);
        bool held = InputManager.GetKey(key);
        if (!down && !held) return;
        if (_handledKeys.Contains(key)) return;
        float now = Time.unscaledTime;
        float next;
        if (!_nextSpawnTime.TryGetValue(key, out next)) next = 0f;
        if (down || now >= next)
        {
            try { action(); } catch { }
            _nextSpawnTime[key] = now + SpawnRepeatInterval;
            BonkMenu.UI.Components.UIFactory.IncrementSpawnToast(key.ToString(), toastLabel, increment);
            _handledKeys.Add(key);
        }
    }
}
