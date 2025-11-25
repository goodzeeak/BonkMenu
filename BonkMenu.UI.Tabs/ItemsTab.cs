using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Pickups;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

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

	public static void Create(GameObject parent)
	{
		UIFactory.CreateSectionHeader("Currencies", parent);
		CreateCurrencies(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Pickups", parent);
		CreatePickups(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Weapons", parent);
		CreateWeapons(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Tomes", parent);
		CreateTomes(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Items (Passive)", parent);
		CreateItems(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Abilities (Passive)", parent);
		CreatePassives(parent);
	}

	private static void CreateCurrencies(GameObject parent)
	{
		UIFactory.CreateButton("Add 1,000 Gold", delegate
		{
			PlayerFeatures.SpawnPickup((EPickup)1, 1000, "Gold");
		}, parent);
		UIFactory.CreateButton("Add 10,000 Gold", delegate
		{
			PlayerFeatures.SpawnPickup((EPickup)1, 10000, "Gold");
		}, parent);
		UIFactory.CreateButton("Add 1,000 Silver", delegate
		{
			PlayerFeatures.SpawnPickup((EPickup)10, 1000, "Silver");
		}, parent);
		UIFactory.CreateButton("Add 1000 Silver (Progression)", delegate
		{
			PlayerFeatures.AddProgressionCurrency(1000);
		}, parent);
	}

	private static void CreatePickups(GameObject parent)
	{
		UIFactory.CreateSpawner(parent, "Spawn Pickup", pickups, delegate(int id, int amount)
		{
			string itemName = pickups[id];
			PlayerFeatures.SpawnPickup((EPickup)id, amount, itemName);
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
		UIFactory.CreateSpawner(parent, "Grant Weapon", weapons, delegate(int id, int amount)
		{
			int weaponId = id + 1;
			string weaponName = weapons[id];
			for (int i = 0; i < amount; i++)
			{
				WeaponFeatures.GrantWeapon(weaponId, weaponName);
			}
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
		UIFactory.CreateSpawner(parent, "Grant Tome", tomes, delegate(int id, int amount)
		{
			string tomeName = tomes[id];
			for (int i = 0; i < amount; i++)
			{
				TomeFeatures.GrantTome(id, tomeName);
			}
		});
	}

	private static void CreateItems(GameObject parent)
	{
		UIFactory.CreateButton("\ud83c\udf81 Grant All Items", delegate
		{
			ItemFeatures.GrantAllItems();
		}, parent);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateSpawner(parent, "Grant Item", items, delegate(int id, int amount)
		{
			string itemName = items[id];
			for (int i = 0; i < amount; i++)
			{
				ItemFeatures.GrantItem(id, itemName);
			}
		});
	}

	private static void CreatePassives(GameObject parent)
	{
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateSpawner(parent, "Grant Passive", passives, delegate(int id, int amount)
		{
			string passiveName = passives[id];
			for (int i = 0; i < amount; i++)
			{
				PassiveFeatures.GrantPassive(id, passiveName);
			}
		});
	}
}
