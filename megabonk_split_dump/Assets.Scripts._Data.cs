// Namespace: Assets.Scripts._Data
public enum ESkinType // TypeDefIndex: 5319
{
	// Fields
	public int value__; // 0x0
	public const ESkinType Default = 0;
	public const ESkinType Kills = 1;
	public const ESkinType FinalBoss = 3;
	public const ESkinType Speedrun = 2;
	public const ESkinType Gold = 4;
	public const ESkinType Extra1 = 5;
	public const ESkinType Extra2 = 6;
	public const ESkinType Extra3 = 7;
	public const ESkinType Extra4 = 8;
	public const ESkinType Extra5 = 9;
	public const ESkinType Extra6 = 10;
}

// Namespace: Assets.Scripts._Data
public interface IUpgradable // TypeDefIndex: 5320
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetUpgradeDescription(int level, List<StatModifier> upgradeOffer, ERarity rarity);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Texture GetIcon();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int GetLevel();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetMaxLevel();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract List<StatModifier> GetUpgradeOffer(ERarity rarity);
}

