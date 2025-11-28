// Namespace: Assets.Scripts.Audio.Music
public enum MusicCategory // TypeDefIndex: 5704
{
	// Fields
	public int value__; // 0x0
	public const MusicCategory Forest = 0;
	public const MusicCategory Desert = 1;
	public const MusicCategory Other = 2;
}

// Namespace: Assets.Scripts.Audio.Music
[CreateAssetMenu(menuName = "Me/MusicTrack", order = 1)]
public class MusicTrack : ScriptableObject, IComparable<MusicTrack> // TypeDefIndex: 5705
{
	// Fields
	public bool isEnabled; // 0x18
	public bool isInJukebox; // 0x19
	public bool isInRandomPool; // 0x1A
	public int maxStageCompatibility; // 0x1C
	public MusicCategory category; // 0x20
	public string trackName; // 0x28
	public AudioClip intro; // 0x30
	public AudioClip loop; // 0x38

	// Methods

	// RVA: 0x46E480 Offset: 0x46CA80 VA: 0x18046E480
	public void LoadToMemory() { }

	// RVA: 0x46E530 Offset: 0x46CB30 VA: 0x18046E530
	public void UnloadFromMemory() { }

	// RVA: 0x46E3A0 Offset: 0x46C9A0 VA: 0x18046E3A0
	public bool IsLoadedInMemory() { }

	// RVA: 0x46E2D0 Offset: 0x46C8D0 VA: 0x18046E2D0 Slot: 4
	public int CompareTo(MusicTrack other) { }

	// RVA: 0x46E5E0 Offset: 0x46CBE0 VA: 0x18046E5E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Audio.Music
public class MusicUtility // TypeDefIndex: 5706
{
	// Fields
	private static List<MusicTrack> tracks; // 0x0
	private static List<MusicTrack> tracksOther; // 0x8
	private static Dictionary<EMap, int> mapTrackRotation; // 0x10
	private static MusicTrack themeTrackPlayedLastRound; // 0x18

	// Methods

	// RVA: 0x46E600 Offset: 0x46CC00 VA: 0x18046E600
	public static MusicTrack GetMusicTrackToPlay(RunConfig runConfig) { }

	// RVA: 0x46EF40 Offset: 0x46D540 VA: 0x18046EF40
	public static List<MusicTrack> GetTracks() { }

	// RVA: 0x46EC70 Offset: 0x46D270 VA: 0x18046EC70
	public static List<MusicTrack> GetTracksOther() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x46F200 Offset: 0x46D800 VA: 0x18046F200
	private static void .cctor() { }
}

