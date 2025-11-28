// Namespace: Assets.Scripts.Game.MapGeneration.MapEvents
public abstract class MapEvents // TypeDefIndex: 5666
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Tick();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Init();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Cleanup();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Assets.Scripts.Game.MapGeneration.MapEvents
public class MapEventsDesert : MapEvents // TypeDefIndex: 5667
{
	// Fields
	public bool ENABLE_SANDSTORM; // 0x10
	private int numStorms; // 0x14
	private List<float> stormTimes; // 0x18
	private float minDuration; // 0x20
	private float maxDuration; // 0x24
	private static bool isActiveStorm; // 0x0
	private float nextStormTime; // 0x28
	private float stormOverAtTime; // 0x2C
	private int stormIndex; // 0x30
	public static float currentStormStartedAtTime; // 0x4
	private float tumbleweedSpawnInterval; // 0x34
	private float lastSpawnedTumbleweedTime; // 0x38

	// Properties
	private float minGapBetweenStorms { get; }

	// Methods

	// RVA: 0x452A00 Offset: 0x451000 VA: 0x180452A00
	private float get_minGapBetweenStorms() { }

	// RVA: 0x451E20 Offset: 0x450420 VA: 0x180451E20 Slot: 5
	public override void Init() { }

	// RVA: 0x451DE0 Offset: 0x4503E0 VA: 0x180451DE0 Slot: 6
	public override void Cleanup() { }

	// RVA: 0x4522B0 Offset: 0x4508B0 VA: 0x1804522B0
	public static bool IsActiveStorm() { }

	// RVA: 0x452860 Offset: 0x450E60 VA: 0x180452860 Slot: 4
	public override void Tick() { }

	// RVA: 0x4525C0 Offset: 0x450BC0 VA: 0x1804525C0
	private void TickStorms() { }

	// RVA: 0x4522F0 Offset: 0x4508F0 VA: 0x1804522F0
	private void SpawnTumbleWeeds() { }

	// RVA: 0x4523D0 Offset: 0x4509D0 VA: 0x1804523D0
	private void StartStorm() { }

	// RVA: 0x4524E0 Offset: 0x450AE0 VA: 0x1804524E0
	private void StopStorm() { }

	// RVA: 0x452970 Offset: 0x450F70 VA: 0x180452970
	public void .ctor() { }
}

