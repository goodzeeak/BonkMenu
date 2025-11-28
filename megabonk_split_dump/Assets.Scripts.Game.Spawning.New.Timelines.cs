// Namespace: Assets.Scripts.Game.Spawning.New.Timelines
public enum ETimelineEvent // TypeDefIndex: 5653
{
	// Fields
	public int value__; // 0x0
	public const ETimelineEvent EAddEnemyCard = 0;
	public const ETimelineEvent EMiniBoss = 1;
	public const ETimelineEvent ESwarm = 2;
}

// Namespace: Assets.Scripts.Game.Spawning.New.Timelines
[Serializable]
public class StageTimeline // TypeDefIndex: 5655
{
	// Fields
	public float stageTime; // 0x10
	public float checkNewEnemyInterval; // 0x14
	public List<EEnemy> startEnemies; // 0x18
	public List<TimelineEvent> events; // 0x20
	public EnemyData boss; // 0x28
	public List<EEnemy> minibosses; // 0x30

	// Methods

	// RVA: 0x4629F0 Offset: 0x460FF0 VA: 0x1804629F0
	public float GetStageTime() { }

	// RVA: 0x462A50 Offset: 0x461050 VA: 0x180462A50
	public void Sort() { }

	// RVA: 0x462B70 Offset: 0x461170 VA: 0x180462B70
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Spawning.New.Timelines
[Serializable]
public class TimelineEvent // TypeDefIndex: 5656
{
	// Fields
	public ETimelineEvent eTimelineEvent; // 0x10
	public List<EEnemy> enemies; // 0x18
	public float timeMinutes; // 0x20
	public float duration; // 0x24

	// Methods

	// RVA: 0x465670 Offset: 0x463C70 VA: 0x180465670
	public float GetTimeSeconds() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

