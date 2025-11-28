// Namespace: UnityEngine.ResourceManagement.Diagnostics
[Serializable]
public struct DiagnosticEvent // TypeDefIndex: 12726
{
	// Fields
	[SerializeField]
	private string m_Graph; // 0x0
	[SerializeField]
	private int[] m_Dependencies; // 0x8
	[SerializeField]
	private int m_ObjectId; // 0x10
	[SerializeField]
	private string m_DisplayName; // 0x18
	[SerializeField]
	private int m_Stream; // 0x20
	[SerializeField]
	private int m_Frame; // 0x24
	[SerializeField]
	private int m_Value; // 0x28

	// Properties
	public string Graph { get; }
	public int ObjectId { get; }
	public string DisplayName { get; }
	public int[] Dependencies { get; }
	public int Stream { get; }
	public int Frame { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public string get_Graph() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_ObjectId() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_DisplayName() { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public int[] get_Dependencies() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_Stream() { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public int get_Frame() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_Value() { }

	// RVA: 0x211D040 Offset: 0x211B640 VA: 0x18211D040
	public void .ctor(string graph, string name, int id, int stream, int frame, int value, int[] deps) { }

	// RVA: 0x211CFA0 Offset: 0x211B5A0 VA: 0x18211CFA0
	internal byte[] Serialize() { }

	// RVA: 0x211CF00 Offset: 0x211B500 VA: 0x18211CF00
	public static DiagnosticEvent Deserialize(byte[] data) { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton> // TypeDefIndex: 12728
{
	// Fields
	private static Guid s_editorConnectionGuid; // 0x0
	internal Dictionary<int, DiagnosticEvent> m_CreatedEvents; // 0x20
	internal List<DiagnosticEvent> m_UnhandledEvents; // 0x28
	internal DelegateList<DiagnosticEvent> s_EventHandlers; // 0x30
	private float m_lastTickSent; // 0x38
	private int m_lastFrame; // 0x3C
	private float fpsAvg; // 0x40

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x211C9C0 Offset: 0x211AFC0 VA: 0x18211C9C0
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x211BDE0 Offset: 0x211A3E0 VA: 0x18211BDE0 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x211C030 Offset: 0x211A630 VA: 0x18211C030
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x211C190 Offset: 0x211A790 VA: 0x18211C190
	internal void RegisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x211C570 Offset: 0x211AB70 VA: 0x18211C570
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x211BE10 Offset: 0x211A410 VA: 0x18211BE10
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x211BCD0 Offset: 0x211A2D0 VA: 0x18211BCD0
	private void Awake() { }

	// RVA: 0x211C620 Offset: 0x211AC20 VA: 0x18211C620
	private void Update() { }

	// RVA: 0x211C8C0 Offset: 0x211AEC0 VA: 0x18211C8C0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollector : MonoBehaviour // TypeDefIndex: 12729
{
	// Fields
	private static DiagnosticEventCollector s_Collector; // 0x0

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x211CDF0 Offset: 0x211B3F0 VA: 0x18211CDF0
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x211CAE0 Offset: 0x211B0E0 VA: 0x18211CAE0
	public static DiagnosticEventCollector FindOrCreateGlobalInstance() { }

	// RVA: 0x211C030 Offset: 0x211A630 VA: 0x18211C030
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x211CD20 Offset: 0x211B320 VA: 0x18211CD20
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x211CCB0 Offset: 0x211B2B0 VA: 0x18211CCB0
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

