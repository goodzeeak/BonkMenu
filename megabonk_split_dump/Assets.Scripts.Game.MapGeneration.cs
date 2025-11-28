// Namespace: Assets.Scripts.Game.MapGeneration
[Serializable]
public class RandomMapObject // TypeDefIndex: 5664
{
	// Fields
	public int amount; // 0x10
	public int maxAmount; // 0x14
	public float checkRadius; // 0x18
	public float scaleMin; // 0x1C
	public float scaleMax; // 0x20
	public float maxSlopeAngle; // 0x24
	public float upOffset; // 0x28
	public GameObject[] prefabs; // 0x30
	public Vector3 randomRotationVector; // 0x38
	public bool alignWithNormal; // 0x44

	// Methods

	// RVA: 0x45E580 Offset: 0x45CB80 VA: 0x18045E580
	public int GetAmount() { }

	// RVA: 0x45E610 Offset: 0x45CC10 VA: 0x18045E610
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.MapGeneration
[Serializable]
public class StageTilePrefabs // TypeDefIndex: 5665
{
	// Fields
	public GameObject[] flatTilePrefabs; // 0x10
	public float populateTilesRatio; // 0x18

	// Methods

	// RVA: 0x4629E0 Offset: 0x460FE0 VA: 0x1804629E0
	public void .ctor() { }
}

