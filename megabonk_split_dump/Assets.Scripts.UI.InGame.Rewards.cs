// Namespace: Assets.Scripts.UI.InGame.Rewards
public abstract class BaseEncounterWindow : MonoBehaviour // TypeDefIndex: 5363
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Open(EEncounter encounterType);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnClose();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ChooseOffer(int index);

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: Assets.Scripts.UI.InGame.Rewards
public enum EEncounter // TypeDefIndex: 5364
{
	// Fields
	public int value__; // 0x0
	public const EEncounter Levelup = 0;
	public const EEncounter RandomStats = 1;
	public const EEncounter GreedAltar = 2;
	public const EEncounter ChestNormal = 3;
	public const EEncounter ChestFree = 4;
	public const EEncounter ChestEvil = 5;
	public const EEncounter Moai = 6;
	public const EEncounter ShadyGuy = 7;
	public const EEncounter BalanceShrine = 8;
	public const EEncounter Microwave = 9;
}

// Namespace: Assets.Scripts.UI.InGame.Rewards
[Serializable]
public class EffectStat // TypeDefIndex: 5365
{
	// Fields
	public EEncounterEffect effectType; // 0x10
	public StatModifier statModifier; // 0x18
	public bool permanent; // 0x20
	public float duration; // 0x24
	public float value; // 0x28
	public bool isPositiveEffect; // 0x2C

	// Methods

	// RVA: 0x3B70A0 Offset: 0x3B56A0 VA: 0x1803B70A0
	public string GetDescription() { }

	// RVA: 0x3B7A40 Offset: 0x3B6040 VA: 0x1803B7A40
	private float GetValue() { }

	// RVA: 0x3B7990 Offset: 0x3B5F90 VA: 0x1803B7990
	private string GetStatDescription(string color) { }

	// RVA: 0x3B78B0 Offset: 0x3B5EB0 VA: 0x1803B78B0
	public string GetShortDescription() { }

	// RVA: 0x3B7820 Offset: 0x3B5E20 VA: 0x1803B7820
	public string GetEffectNumber() { }

	// RVA: 0x3B77B0 Offset: 0x3B5DB0 VA: 0x1803B77B0
	public string GetEffectName() { }

	// RVA: 0x3B6B00 Offset: 0x3B5100 VA: 0x1803B6B00
	public void ApplyEffect() { }

	// RVA: 0x3B7020 Offset: 0x3B5620 VA: 0x1803B7020
	private string GetColor() { }

	// RVA: 0x3B7B50 Offset: 0x3B6150 VA: 0x1803B7B50
	private void HealthEffect() { }

	// RVA: 0x3B6E00 Offset: 0x3B5400 VA: 0x1803B6E00
	public bool CanApplyEffect(out string reason) { }

	// RVA: 0x3B7D40 Offset: 0x3B6340 VA: 0x1803B7D40
	public void .ctor() { }
}

// Namespace: Assets.Scripts.UI.InGame.Rewards
[CreateAssetMenu(menuName = "Me/EncounterData")]
public class EncounterData : ScriptableObject // TypeDefIndex: 5366
{
	// Fields
	public EEncounter encounterType; // 0x18
	public EncounterOffer[] offers; // 0x20
	public LocalizedString localizedName; // 0x28
	public LocalizedString localizedDescription; // 0x30

	// Methods

	// RVA: 0x3B7D70 Offset: 0x3B6370 VA: 0x1803B7D70
	public string GetName() { }

	// RVA: 0x3B7D50 Offset: 0x3B6350 VA: 0x1803B7D50
	public string GetDescription() { }

	// RVA: 0x3B7D90 Offset: 0x3B6390 VA: 0x1803B7D90
	public EncounterOffer[] GetOffers() { }

	// RVA: 0x3B8030 Offset: 0x3B6630 VA: 0x1803B8030
	public bool HasRarity() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Assets.Scripts.UI.InGame.Rewards
[Serializable]
public class EncounterOffer // TypeDefIndex: 5367
{
	// Fields
	public ERarity rarity; // 0x10
	public EffectStat[] effects; // 0x18

	// Methods

	// RVA: 0x3B8580 Offset: 0x3B6B80 VA: 0x1803B8580
	public string GetEffectsDescription() { }

	// RVA: 0x3B8040 Offset: 0x3B6640 VA: 0x1803B8040
	public void ApplyEffects(bool showInScoreUi = True) { }

	// RVA: 0x3B8290 Offset: 0x3B6890 VA: 0x1803B8290
	public bool CanAccept(out string reason) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

