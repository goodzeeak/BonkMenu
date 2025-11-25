using BonkMenu.Features;
using BonkMenu.UI.Components;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

public static class WorldTab
{
	private static readonly string[] encounters = new string[10]
	{
		"Levelup", "Random Stats", "Greed Altar", "Chest Normal", "Chest Free",
		"Chest Evil", "Moai", "Shady Guy", "Balance Shrine", "Microwave"
	};

	private static readonly string[] worldObjects = new string[5]
	{
		"Pot", "Big Pot", "Silver Pot", "Chest", "Gold Pile"
	};

	public static void Create(GameObject parent)
	{
		UIFactory.CreateSectionHeader("Encounters", parent);
		CreateEncounters(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("World Objects", parent);
		CreateWorldObjects(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Teleportation", parent);
		CreateTeleportation(parent);
	}

	private static void CreateEncounters(GameObject parent)
	{
		UIFactory.CreateSpawnerNoSlider(parent, "Spawn Encounter", encounters, delegate(int id)
		{
			string encounterName = encounters[id];
			EncounterFeatures.ForceEncounter(id, encounterName);
		});

		UIFactory.CreateButton("⏭️ Skip Current Encounter", delegate
		{
			EncounterFeatures.SkipEncounter();
		}, parent);
	}

	private static void CreateWorldObjects(GameObject parent)
	{
		UIFactory.CreateSpawnerNoSlider(parent, "Spawn Object", worldObjects, delegate(int id)
		{
			string objectType = worldObjects[id];
			WorldFeatures.SpawnWorldObject(objectType);
		});
	}

	private static void CreateTeleportation(GameObject parent)
	{
		UIFactory.CreateButton("⬆️ Teleport Up 10", delegate
		{
			WorldFeatures.TeleportRelative(0f, 10f, 0f);
		}, parent);

		UIFactory.CreateButton("⬇️ Teleport Down 10", delegate
		{
			WorldFeatures.TeleportRelative(0f, -10f, 0f);
		}, parent);

		UIFactory.CreateLabel("Quick Teleports:", parent);

		UIFactory.CreateButton("⬅️ Left 10", delegate
		{
			WorldFeatures.TeleportRelative(-10f, 0f, 0f);
		}, parent);

		UIFactory.CreateButton("➡️ Right 10", delegate
		{
			WorldFeatures.TeleportRelative(10f, 0f, 0f);
		}, parent);

		UIFactory.CreateButton("⬆️ Forward 10", delegate
		{
			WorldFeatures.TeleportRelative(0f, 0f, 10f);
		}, parent);

		UIFactory.CreateButton("⬇️ Backward 10", delegate
		{
			WorldFeatures.TeleportRelative(0f, 0f, -10f);
		}, parent);
	}
}
