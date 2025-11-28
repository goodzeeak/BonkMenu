// Namespace: Assets.Scripts.UI.InGame.Rewards.Effects
public enum EEncounterEffect // TypeDefIndex: 5368
{
	// Fields
	public int value__; // 0x0
	public const EEncounterEffect StatChange = 0;
	public const EEncounterEffect EGold = 1;
	public const EEncounterEffect EHealth = 2;
	public const EEncounterEffect StatChangeBalanceShrine = 3;
}

// Namespace: Assets.Scripts.UI.InGame.Rewards.Effects
public interface IEncounterEffect // TypeDefIndex: 5369
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetDescription();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ApplyEffect();
}

