// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public enum EItem // TypeDefIndex: 5518
{
	// Fields
	public int value__; // 0x0
	public const EItem Key = 0;
	public const EItem Beer = 1;
	public const EItem SpikyShield = 2;
	public const EItem Bonker = 3;
	public const EItem SlipperyRing = 4;
	public const EItem CowardsCloak = 5;
	public const EItem GymSauce = 6;
	public const EItem Battery = 7;
	public const EItem PhantomShroud = 8;
	public const EItem ForbiddenJuice = 9;
	public const EItem DemonBlade = 10;
	public const EItem GrandmasSecretTonic = 11;
	public const EItem GiantFork = 12;
	public const EItem MoldyCheese = 13;
	public const EItem GoldenSneakers = 14;
	public const EItem SpicyMeatball = 15;
	public const EItem Chonkplate = 16;
	public const EItem LightningOrb = 17;
	public const EItem IceCube = 18;
	public const EItem DemonicBlood = 19;
	public const EItem DemonicSoul = 20;
	public const EItem BeefyRing = 21;
	public const EItem Dragonfire = 22;
	public const EItem GoldenGlove = 23;
	public const EItem GoldenShield = 24;
	public const EItem ZaWarudo = 25;
	public const EItem OverpoweredLamp = 26;
	public const EItem Feathers = 27;
	public const EItem Ghost = 28;
	public const EItem SluttyCannon = 29;
	public const EItem TurboSocks = 30;
	public const EItem ShatteredWisdom = 31;
	public const EItem EchoShard = 32;
	public const EItem SuckyMagnet = 33;
	public const EItem Backpack = 34;
	public const EItem Clover = 35;
	public const EItem Campfire = 36;
	public const EItem Rollerblades = 37;
	public const EItem Skuleg = 38;
	public const EItem EagleClaw = 39;
	public const EItem Scarf = 40;
	public const EItem Anvil = 41;
	public const EItem Oats = 42;
	public const EItem CursedDoll = 43;
	public const EItem EnergyCore = 44;
	public const EItem ElectricPlug = 45;
	public const EItem BobDead = 46;
	public const EItem SoulHarvester = 47;
	public const EItem Mirror = 48;
	public const EItem JoesDagger = 49;
	public const EItem WeebHeadset = 50;
	public const EItem SpeedBoi = 51;
	public const EItem Gasmask = 52;
	public const EItem ToxicBarrel = 53;
	public const EItem HolyBook = 54;
	public const EItem BrassKnuckles = 55;
	public const EItem IdleJuice = 56;
	public const EItem Kevin = 57;
	public const EItem Borgar = 58;
	public const EItem Medkit = 59;
	public const EItem GamerGoggles = 60;
	public const EItem UnstableTransfusion = 61;
	public const EItem BloodyCleaver = 62;
	public const EItem CreditCardRed = 63;
	public const EItem CreditCardGreen = 64;
	public const EItem BossBuster = 65;
	public const EItem LeechingCrystal = 66;
	public const EItem TacticalGlasses = 67;
	public const EItem Cactus = 68;
	public const EItem CageKey = 69;
	public const EItem IceCrystal = 70;
	public const EItem TimeBracelet = 71;
	public const EItem GloveLightning = 72;
	public const EItem GlovePoison = 73;
	public const EItem GloveBlood = 74;
	public const EItem GloveCurse = 75;
	public const EItem GlovePower = 76;
	public const EItem Wrench = 77;
	public const EItem Beacon = 78;
	public const EItem GoldenRing = 79;
	public const EItem QuinsMask = 80;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public enum EItemRarity // TypeDefIndex: 5519
{
	// Fields
	public int value__; // 0x0
	public const EItemRarity Common = 0;
	public const EItemRarity Rare = 1;
	public const EItemRarity Epic = 2;
	public const EItemRarity Legendary = 3;
	public const EItemRarity Corrupted = 4;
	public const EItemRarity Quest = 5;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public class ItemAttackModifier // TypeDefIndex: 5520
{
	// Fields
	public float flatValues; // 0x10
	public float additiveValues; // 0x14
	public float multiplicativeValues; // 0x18
	[CompilerGenerated]
	private float <damageMultiplier>k__BackingField; // 0x1C

	// Properties
	public float damageMultiplier { get; set; }

	// Methods

	// RVA: 0x410030 Offset: 0x40E630 VA: 0x180410030
	public void Recycle() { }

	[CompilerGenerated]
	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0
	public float get_damageMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450
	private void set_damageMultiplier(float value) { }

	// RVA: 0x410000 Offset: 0x40E600 VA: 0x180410000
	public void Apply(DamageContainer dc) { }

	// RVA: 0x40FFF0 Offset: 0x40E5F0 VA: 0x18040FFF0
	public void AddMultiplier(float multiplier) { }

	// RVA: 0x410040 Offset: 0x40E640 VA: 0x180410040
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public abstract class ItemBase // TypeDefIndex: 5521
{
	// Fields
	private string damageSource; // 0x10
	public int amount; // 0x18
	private ItemInventory itemInventoryRef; // 0x20
	public Dictionary<EStat, StatModifiersContainer> statModifiers; // 0x28
	public static Action<ItemBase> A_ItemAdded; // 0x0
	public static Action<ItemBase> A_ItemRemoved; // 0x8

	// Methods

	// RVA: 0x4105A0 Offset: 0x40EBA0 VA: 0x1804105A0
	protected void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x410400 Offset: 0x40EA00 VA: 0x180410400
	protected void SetStat(StatModifier statModifier) { }

	// RVA: 0x410210 Offset: 0x40E810 VA: 0x180410210
	public void AddAmount() { }

	// RVA: 0x410390 Offset: 0x40E990 VA: 0x180410390
	public void RemoveAmount() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Init();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Cleanup();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnInitOrAmountChanged();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Tick();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PreAttack(DamageContainer dc, StatComponents itemAttackModifier);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ProcOnHitEffects(DamageContainer dc);

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	protected virtual Dictionary<string, object> GetLocalizationKeys() { }

	// RVA: 0x410280 Offset: 0x40E880 VA: 0x180410280 Slot: 11
	public virtual string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public static class ItemConstants // TypeDefIndex: 5522
{
	// Fields
	public const float GHOST_RANGE = 30;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public static class ItemFactory // TypeDefIndex: 5523
{
	// Methods

	// RVA: 0x4158F0 Offset: 0x413EF0 VA: 0x1804158F0
	public static ItemBase CreateItem(EItem eItem, ItemInventory inventory) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public class ItemSuckyHoof : ItemBase // TypeDefIndex: 5524
{
	// Fields
	private float range; // 0x30
	private float interval; // 0x34
	private float nextSuckTime; // 0x38

	// Methods

	// RVA: 0x4186B0 Offset: 0x416CB0 VA: 0x1804186B0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4186F0 Offset: 0x416CF0 VA: 0x1804186F0 Slot: 7
	public override void Tick() { }

	// RVA: 0x4189F0 Offset: 0x416FF0 VA: 0x1804189F0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public class ItemInventory // TypeDefIndex: 5525
{
	// Fields
	public Dictionary<EItem, ItemBase> items; // 0x10
	public static Action<EStat> A_StatsChanged; // 0x0
	public static Action<EItem> A_ItemAdded; // 0x8
	public static Action<EItem, bool> A_ItemRemoved; // 0x10

	// Methods

	// RVA: 0x416D20 Offset: 0x415320 VA: 0x180416D20
	public void AddItem(EItem eItem) { }

	// RVA: 0x416B30 Offset: 0x415130 VA: 0x180416B30
	public void AddItem(EItem eItem, int count) { }

	// RVA: 0x4170A0 Offset: 0x4156A0 VA: 0x1804170A0
	public ItemBase GetItem(EItem eItem) { }

	// RVA: 0x4176B0 Offset: 0x415CB0 VA: 0x1804176B0
	public void RemoveItem(EItem eItem, bool showEffect = True) { }

	// RVA: 0x4178D0 Offset: 0x415ED0 VA: 0x1804178D0
	public void Tick() { }

	// RVA: 0x417530 Offset: 0x415B30 VA: 0x180417530
	public StatComponents PreAttack(DamageContainer dc, StatComponents itemModifierStatComponents) { }

	// RVA: 0x4172B0 Offset: 0x4158B0 VA: 0x1804172B0
	public void PostDamage(DamageContainer dc) { }

	// RVA: 0x417870 Offset: 0x415E70 VA: 0x180417870
	public void StatWasModified(EStat stat) { }

	// RVA: 0x417010 Offset: 0x415610 VA: 0x180417010
	public int GetAmount(EItem eItem) { }

	// RVA: 0x417130 Offset: 0x415730 VA: 0x180417130
	public int GetUniqueItemsInRarity(EItemRarity itemRarity) { }

	// RVA: 0x416EE0 Offset: 0x4154E0 VA: 0x180416EE0
	public void Cleanup() { }

	// RVA: 0x417A40 Offset: 0x416040 VA: 0x180417A40
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public static class ItemUtility // TypeDefIndex: 5526
{
	// Methods

	// RVA: 0x418A00 Offset: 0x417000 VA: 0x180418A00
	public static ItemData GetRandomChestItem(EChest chestType, float luck) { }

	// RVA: 0x418F40 Offset: 0x417540 VA: 0x180418F40
	public static ItemData GetRandomItem(float luck) { }

	// RVA: 0x418D20 Offset: 0x417320 VA: 0x180418D20
	public static ItemData GetRandomItemFromRarity(EItemRarity rarity) { }

	// RVA: 0x418F60 Offset: 0x417560 VA: 0x180418F60
	public static bool TryProc(float procCoefficient, float baseProcChance) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items
public class StatModifiersContainer // TypeDefIndex: 5527
{
	// Fields
	private Dictionary<EStatModifyType, StatModifier> statContainers; // 0x10

	// Methods

	// RVA: 0x422C70 Offset: 0x421270 VA: 0x180422C70
	public void SetModifier(StatModifier statModifier) { }

	// RVA: 0x422C20 Offset: 0x421220 VA: 0x180422C20
	public IEnumerable<StatModifier> GetModifiers() { }

	// RVA: 0x422CD0 Offset: 0x4212D0 VA: 0x180422CD0
	public void .ctor() { }
}

