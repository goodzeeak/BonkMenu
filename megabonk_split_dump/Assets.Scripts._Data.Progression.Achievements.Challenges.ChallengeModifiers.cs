// Namespace: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/Blind", order = 1)]
public class ChallengeModifierBlind : ChallengeModifier // TypeDefIndex: 5327
{
	// Methods

	// RVA: 0x3B3A10 Offset: 0x3B2010 VA: 0x1803B3A10 Slot: 4
	public override void Init() { }

	// RVA: 0x3B38F0 Offset: 0x3B1EF0 VA: 0x1803B38F0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3B3B30 Offset: 0x3B2130 VA: 0x1803B3B30
	private void OnGenerationComplete() { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/InvertedControls", order = 1)]
public class ChallengeModifierInvertedControls : ChallengeModifier // TypeDefIndex: 5328
{
	// Fields
	public static bool disableInvertedControlsOptions; // 0x0

	// Methods

	// RVA: 0x3B3D60 Offset: 0x3B2360 VA: 0x1803B3D60 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/Lava", order = 1)]
public class ChallengeModifierLava : ChallengeModifier // TypeDefIndex: 5329
{
	// Fields
	private GameObject lavaObject; // 0x28
	private Vector3 topPosition; // 0x30
	private Vector3 lowPosition; // 0x3C
	private float riseTime; // 0x48
	private float stayTop; // 0x4C
	private float lowerTime; // 0x50
	private float stayBottom; // 0x54
	private float cycleDuration; // 0x58
	private float startDelay; // 0x5C
	private float startTime; // 0x60

	// Methods

	// RVA: 0x3B3EC0 Offset: 0x3B24C0 VA: 0x1803B3EC0 Slot: 4
	public override void Init() { }

	// RVA: 0x3B3DA0 Offset: 0x3B23A0 VA: 0x1803B3DA0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3B3FE0 Offset: 0x3B25E0 VA: 0x1803B3FE0
	private void OnGenerationComplete() { }

	// RVA: 0x3B4430 Offset: 0x3B2A30 VA: 0x1803B4430 Slot: 6
	public override void Tick() { }

	// RVA: 0x3B4720 Offset: 0x3B2D20 VA: 0x1803B4720
	public void .ctor() { }
}

// Namespace: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/1 HP", order = 1)]
public class ChallengeModifierNoDamage : ChallengeModifier // TypeDefIndex: 5330
{
	// Fields
	private bool hasBeenCalled; // 0x28
	private bool hasBeenKilled; // 0x29

	// Methods

	// RVA: 0x3B4890 Offset: 0x3B2E90 VA: 0x1803B4890 Slot: 4
	public override void Init() { }

	// RVA: 0x3B4750 Offset: 0x3B2D50 VA: 0x1803B4750 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3B49D0 Offset: 0x3B2FD0 VA: 0x1803B49D0
	private void OnDamagePlayer() { }

	// RVA: 0x3B4B20 Offset: 0x3B3120 VA: 0x1803B4B20 Slot: 6
	public override void Tick() { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/No items", order = 1)]
public class ChallengeModifierNoItems : ChallengeModifier // TypeDefIndex: 5331
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Assets.Scripts._Data.Progression.Achievements.Challenges.ChallengeModifiers
[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/No movement", order = 1)]
public class ChallengeModifierNoMovement : ChallengeModifier // TypeDefIndex: 5332
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

