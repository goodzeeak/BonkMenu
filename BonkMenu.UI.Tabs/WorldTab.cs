using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Actors.Player;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

public static class WorldTab
{
	private static readonly string[] encounters = new string[10] { "Levelup", "RandomStats", "GreedAltar", "ChestNormal", "ChestFree", "ChestEvil", "Moai", "ShadyGuy", "BalanceShrine", "Microwave" };

	private static readonly string[] environmentObjects = new string[23]
	{
		"ShrineMaoi", "ChallengeShrine", "MagnetShrine", "CursedShrine", "Greed Altar", "ChargeShrine", "Chest", "ChestFree", "BossSpawner", "BossSpawnerFinal",
		"Microwave", "PotSmall", "PotBig", "PotSmallSilver", "PotBigSilver", "Boulder", "Tree0", "Log0", "Bush0", "Bush1",
		"Rock Medium 1", "Rock Small 1", "ShadyGuy"
	};

	public static void Create(GameObject parent)
	{
		UIFactory.CreateSectionHeader("Teleportation", parent);
		CreateTeleportation(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Time Control", parent);
		CreateTimeControl(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Encounters", parent);
		CreateEncounters(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Environment", parent);
		CreateEnvironmentButtons(parent);
	}

	private static void CreateTeleportation(GameObject parent)
	{
		UIFactory.CreateButton("\ud83d\udccd Save Position", delegate
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			MyPlayer instance = MyPlayer.Instance;
			if ((Object)(object)instance != (Object)null)
			{
				WorldFeatures.savedPosition = ((Component)instance).transform.position;
				MelonLogger.Msg($"Position saved: {WorldFeatures.savedPosition}");
			}
		}, parent);
		UIFactory.CreateButton("\ud83d\ude80 Load Position", delegate
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			MyPlayer instance = MyPlayer.Instance;
			if ((Object)(object)instance != (Object)null)
			{
				if (WorldFeatures.savedPosition != Vector3.zero)
				{
					((Component)instance).transform.position = WorldFeatures.savedPosition;
					MelonLogger.Msg("Teleported to saved position");
				}
				else
				{
					MelonLogger.Warning("No saved position!");
				}
			}
		}, parent);
		UIFactory.CreateButton("\ud83d\udd04 Reset Position", delegate
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			MyPlayer instance = MyPlayer.Instance;
			if ((Object)(object)instance != (Object)null)
			{
				((Component)instance).transform.position = Vector3.zero;
				MelonLogger.Msg("Player position reset to origin");
			}
		}, parent);
	}

	private static void CreateTimeControl(GameObject parent)
	{
		UIFactory.CreateCircularToggle("⏸\ufe0f Freeze Time", initialValue: false, delegate(bool value)
		{
			Time.timeScale = (value ? 0f : 1f);
			MelonLogger.Msg("Time " + (value ? "Frozen" : "Resumed"));
		}, parent);
		UIFactory.CreateSlider("Time Scale", 0.1f, 50000f, 1f, delegate(float value)
		{
			Time.timeScale = value;
			MelonLogger.Msg($"Time Scale: {value}x");
		}, parent);
	}

	private static void CreateEncounters(GameObject parent)
	{
		UIFactory.CreateSpawner(parent, "Spawn Encounter", encounters, delegate(int id, int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				EncounterFeatures.ForceEncounter(id, encounters[id]);
			}
		});
		UIFactory.CreateButton("⏭\ufe0f Skip Current Encounter", delegate
		{
			EncounterFeatures.SkipEncounter();
		}, parent);
	}

	private static void CreateEnvironmentButtons(GameObject parent)
	{
		UIFactory.CreateSpawner(parent, "Spawn Object", environmentObjects, delegate(int id, int amount)
		{
			string type = environmentObjects[id];
			for (int i = 0; i < amount; i++)
			{
				WorldFeatures.SpawnMapObject(type);
			}
		});
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateButton("Debug: List Spawnables", delegate
		{
			WorldFeatures.ListSpawnableObjects();
		}, parent);
		UIFactory.CreateButton("Debug: Dump ALL Objects (Lag Warning)", delegate
		{
			WorldFeatures.DumpAllObjectNames();
		}, parent);
	}
}

