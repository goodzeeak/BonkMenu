using BonkMenu.Core;
using BonkMenu.Features;
using BonkMenu.UI.Components;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

public static class WorldTab
{
    public static void Create(GameObject parent)
    {
        UIFactory.CreateSectionHeader("Spawning", parent);
        CreateSpawning(parent);
    }

    private static void CreateSpawning(GameObject parent)
    {
        string[] spawnOptions = new string[] 
        { 
            "Chests", 
            "Free Chests", 
            "Statues", 
            "Shrines",
            "Pots",
            "Microwaves"
        };

        UIFactory.CreateSpawnerNoSlider(parent, "Spawn Object", spawnOptions, delegate(int index)
        {
            switch (index)
            {
                case 0: // Chests
                    WorldFeatures.SpawnChests();
                    break;
                case 1: // Free Chests
                    WorldFeatures.SpawnFreeChests();
                    break;
                case 2: // Statues
                    WorldFeatures.SpawnStatues();
                    break;
                case 3: // Shrines
                    WorldFeatures.SpawnShrines();
                    break;
                case 4: // Pots
                    WorldFeatures.SpawnPots();
                    break;
                case 5: // Microwaves
                    WorldFeatures.SpawnMicrowaves();
                    break;
            }
        });
    }
}
