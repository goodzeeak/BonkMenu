using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Pickups;
using Il2CppAssets.Scripts._Data.Tomes;
using UnityEngine;
using Il2Cpp;

namespace BonkMenu.UI.Tabs;

/// <summary>
/// Manages items, passives, and unlimited-by-name controls.
/// </summary>
public static class ItemsTab
{
	private static readonly string[] pickups = new string[11]
	{
		"XP", "Gold", "Health", "Nuke", "Time", "Shield", "Rage", "Haste", "Stonks", "Magnet",
		"Silver"
	};

	private static readonly string[] weapons = new string[30]
	{
		"FireStaff", "Bone", "Sword", "Revolver", "Aura", "Axe", "Bow", "Aegis", "Test", "LightningStaff",
		"Flamewalker", "Rockets", "Bananarang", "Tornado", "Dexecutioner", "Sniper", "Frostwalker", "SpaceNoodle", "DragonsBreath", "Chunkers",
		"Mine", "PoisonFlask", "BlackHole", "Katana", "BloodMagic", "BluetoothDagger", "Dice", "HeroSword", "CorruptSword", "Shotgun"
	};

	private static readonly string[] tomes = new string[27]
	{
		"Damage", "Agility", "Cooldown", "Quantity", "Knockback", "Armor", "Health", "Regeneration", "Size", "ProjectileSpeed",
		"Duration", "Evasion", "Attraction", "Luck", "Xp", "Golden", "Precision", "Shield", "Blood", "Thorns",
		"Bounce", "Cursed", "Silver", "Balance", "Chaos", "Gambler", "Hoarder"
	};

	private static readonly string[] items = new string[81]
	{
		"Key", "Beer", "SpikyShield", "Bonker", "SlipperyRing", "CowardsCloak", "GymSauce", "Battery", "PhantomShroud", "ForbiddenJuice",
		"DemonBlade", "GrandmasSecretTonic", "GiantFork", "MoldyCheese", "GoldenSneakers", "SpicyMeatball", "Chonkplate", "LightningOrb", "IceCube", "DemonicBlood",
		"DemonicSoul", "BeefyRing", "Dragonfire", "GoldenGlove", "GoldenShield", "ZaWarudo", "OverpoweredLamp", "Feathers", "Ghost", "SluttyCannon",
		"TurboSocks", "ShatteredWisdom", "EchoShard", "SuckyMagnet", "Backpack", "Clover", "Campfire", "Rollerblades", "Skuleg", "EagleClaw",
		"Scarf", "Anvil", "Oats", "CursedDoll", "EnergyCore", "ElectricPlug", "BobDead", "SoulHarvester", "Mirror", "JoesDagger",
		"WeebHeadset", "SpeedBoi", "Gasmask", "ToxicBarrel", "HolyBook", "BrassKnuckles", "IdleJuice", "Kevin", "Borgar", "Medkit",
		"GamerGoggles", "UnstableTransfusion", "BloodyCleaver", "CreditCardRed", "CreditCardGreen", "BossBuster", "LeechingCrystal", "TacticalGlasses", "Cactus", "CageKey",
		"IceCrystal", "TimeBracelet", "GloveLightning", "GlovePoison", "GloveBlood", "GloveCurse", "GlovePower", "Wrench", "Beacon", "GoldenRing",
		"QuinsMask"
	};

    private static readonly string[] passives = new string[21]
    {
        "Bullseye", "RngBlessing", "SpeedDemon", "Reinforced", "Flowstate", "CritHappens", "Warrior", "Flex", "WallClimb", "None",
        "Float", "Enduring", "Plague", "Quantum", "Shadowstep", "Gamba", "Vampire", "Curse", "Stonks", "LockIn",
        "Zap"
    };

    private static int selectedUnlimitedWeaponIndex = 0;
    private static int selectedUnlimitedTomeIndex = 0;
    

    /// <summary>
    /// Builds the Items tab UI under the given parent.
    /// </summary>
    public static void Create(GameObject parent)
    {

		UIFactory.CreateCollapsibleSection("Pickups", parent, CreatePickups);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Weapons", parent, CreateWeapons);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Tomes", parent, CreateTomes);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Items (Passive)", parent, CreateItems);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Abilities (Passive)", parent, CreatePassives);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Unlimited Levels By Name", parent, CreateUnlimitedByName);
    }



    private static void CreatePickups(GameObject parent)
    {
        int[] map;
        var sorted = SortWithMap(pickups, out map);
        UIFactory.CreateSpawner(parent, "Spawn Pickup", sorted, delegate(int id, int amount)
        {
            int originalId = map[id];
            string itemName = pickups[originalId];
            PlayerFeatures.SpawnPickup((EPickup)originalId, amount, itemName);
        });
    }

    private static void CreateWeapons(GameObject parent)
    {
		UIFactory.CreateButton("\ud83c\udf81 Grant All Weapons", delegate
		{
			WeaponFeatures.GrantAllWeapons();
		}, parent);
		UIFactory.CreateButton("⭐ Max All Weapons", delegate
		{
			WeaponFeatures.MaxAllWeapons();
		}, parent);
		UIFactory.CreateSpacer(4, parent);
        int[] map;
        var sorted = SortWithMap(weapons, out map);
        UIFactory.CreateSpawnerNoSlider(parent, "Grant Weapon", sorted, delegate(int id)
        {
            int originalId = map[id];
            string weaponName = weapons[originalId];
            WeaponFeatures.GrantWeapon(originalId, weaponName);
        });
    }

    private static void CreateTomes(GameObject parent)
    {
		UIFactory.CreateButton("\ud83c\udf81 Grant All Tomes", delegate
		{
			TomeFeatures.GrantAllTomes();
		}, parent);
		UIFactory.CreateButton("⭐ Max All Tomes", delegate
		{
			TomeFeatures.MaxAllTomes();
		}, parent);
		UIFactory.CreateSpacer(4, parent);
        int[] map;
        var sorted = SortWithMap(tomes, out map);
        UIFactory.CreateSpawnerNoSlider(parent, "Grant Tome", sorted, delegate(int id)
        {
            int originalId = map[id];
            string tomeName = tomes[originalId];
            TomeFeatures.GrantTome(originalId, tomeName);
        });
    }

    private static void CreateItems(GameObject parent)
    {
		UIFactory.CreateButton("\ud83c\udf81 Grant All Items", delegate
		{
			ItemFeatures.GrantAllItems();
		}, parent);
		UIFactory.CreateSpacer(4, parent);
        int[] map;
        var sorted = SortWithMap(items, out map);
        UIFactory.CreateSpawner(parent, "Grant Item", sorted, delegate(int id, int amount)
        {
            int originalId = map[id];
            string itemName = items[originalId];
            for (int i = 0; i < amount; i++)
            {
                ItemFeatures.GrantItem(originalId, itemName);
            }
        });
    }

    private static void CreatePassives(GameObject parent)
    {
        UIFactory.CreateSpacer(4, parent);
        int[] map;
        var sorted = SortWithMap(passives, out map);
        UIFactory.CreateSpawnerNoSlider(parent, "Grant Passive", sorted, delegate(int id)
        {
            int originalId = map[id];
            string passiveName = passives[originalId];
            PassiveFeatures.GrantPassive(originalId, passiveName);
        });
    }

    private static void CreateUnlimitedByName(GameObject parent)
    {
        // Weapons selector
        int[] wMap;
        var wSorted = SortWithMap(weapons, out wMap);
        UIFactory.CreateSelector(parent, wSorted, () => selectedUnlimitedWeaponIndex, (int val) => selectedUnlimitedWeaponIndex = val, (UnityEngine.UI.Text _) => { });
        UIFactory.CreateButton("Enable for Selected Weapon", () =>
        {
            var originalId = wMap[selectedUnlimitedWeaponIndex];
            var name = weapons[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var w = dm.GetWeapon((EWeapon)originalId);
                if (w != null && w.name != null)
                {
                    canonical = w.name;
                }
            }
            BonkMenu.Core.ModConfig.EnableUnlimitedForWeapon(name);
            BonkMenu.Core.ModConfig.EnableUnlimitedForWeapon(canonical);
        }, parent);
        UIFactory.CreateButton("Disable for Selected Weapon", () =>
        {
            var originalId = wMap[selectedUnlimitedWeaponIndex];
            var name = weapons[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var w = dm.GetWeapon((EWeapon)originalId);
                if (w != null && w.name != null)
                {
                    canonical = w.name;
                }
            }
            BonkMenu.Core.ModConfig.DisableUnlimitedForWeapon(name);
            BonkMenu.Core.ModConfig.DisableUnlimitedForWeapon(canonical);
        }, parent);

        UIFactory.CreateSpacer(8, parent);

        // Tomes selector
        int[] tMap;
        var tSorted = SortWithMap(tomes, out tMap);
        UIFactory.CreateSelector(parent, tSorted, () => selectedUnlimitedTomeIndex, (int val) => selectedUnlimitedTomeIndex = val, (UnityEngine.UI.Text _) => { });
        UIFactory.CreateButton("Enable for Selected Tome", () =>
        {
            var originalId = tMap[selectedUnlimitedTomeIndex];
            var name = tomes[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var t = dm.GetTome((ETome)originalId);
                if (t != null && t.name != null)
                {
                    canonical = t.name;
                }
            }
            BonkMenu.Core.ModConfig.EnableUnlimitedForTome(name);
            BonkMenu.Core.ModConfig.EnableUnlimitedForTome(canonical);
        }, parent);
        UIFactory.CreateButton("Disable for Selected Tome", () =>
        {
            var originalId = tMap[selectedUnlimitedTomeIndex];
            var name = tomes[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var t = dm.GetTome((ETome)originalId);
                if (t != null && t.name != null)
                {
                    canonical = t.name;
                }
            }
            BonkMenu.Core.ModConfig.DisableUnlimitedForTome(name);
            BonkMenu.Core.ModConfig.DisableUnlimitedForTome(canonical);
        }, parent);
    }

    private static string[] SortWithMap(string[] names, out int[] map)
    {
        var sorted = (string[])names.Clone();
        map = new int[names.Length];
        for (int i = 0; i < map.Length; i++) map[i] = i;
        System.Array.Sort(sorted, map, System.StringComparer.OrdinalIgnoreCase);
        return sorted;
    }
}
