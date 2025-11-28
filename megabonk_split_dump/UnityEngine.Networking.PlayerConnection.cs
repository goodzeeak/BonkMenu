// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class MessageEventArgs // TypeDefIndex: 10043
{
	// Fields
	public int playerId; // 0x10
	public byte[] data; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class PlayerConnection : ScriptableObject // TypeDefIndex: 10047
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField]
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x235BFE0 Offset: 0x235A5E0 VA: 0x18235BFE0
	public static PlayerConnection get_instance() { }

	// RVA: 0x235C0F0 Offset: 0x235A6F0 VA: 0x18235C0F0
	public bool get_isConnected() { }

	// RVA: 0x235AD90 Offset: 0x2359390 VA: 0x18235AD90
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x235B250 Offset: 0x2359850 VA: 0x18235B250
	public void OnEnable() { }

	// RVA: 0x235AF70 Offset: 0x2359570 VA: 0x18235AF70
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x235B470 Offset: 0x2359A70 VA: 0x18235B470 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x235BB70 Offset: 0x235A170 VA: 0x18235BB70 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x235B2B0 Offset: 0x23598B0 VA: 0x18235B2B0 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x235B410 Offset: 0x2359A10 VA: 0x18235B410 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x235BAB0 Offset: 0x235A0B0 VA: 0x18235BAB0 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x235BB10 Offset: 0x235A110 VA: 0x18235BB10 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x235B710 Offset: 0x2359D10 VA: 0x18235B710 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x235B8E0 Offset: 0x2359EE0 VA: 0x18235B8E0 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x235AA00 Offset: 0x2359000 VA: 0x18235AA00
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x235AE40 Offset: 0x2359440 VA: 0x18235AE40 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCode]
	// RVA: 0x235AFE0 Offset: 0x23595E0 VA: 0x18235AFE0
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCode]
	// RVA: 0x235ACC0 Offset: 0x23592C0 VA: 0x18235ACC0
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCode]
	// RVA: 0x235AEE0 Offset: 0x23594E0 VA: 0x18235AEE0
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x235BE30 Offset: 0x235A430 VA: 0x18235BE30
	public void .ctor() { }
}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
internal class PlayerEditorConnectionEvents // TypeDefIndex: 10051
{
	// Fields
	[SerializeField]
	private List<PlayerEditorConnectionEvents.MessageTypeSubscribers> m_MessageTypeSubscribers; // 0x10
	private Dictionary<Guid, PlayerEditorConnectionEvents.MessageTypeSubscribers> m_SubscriberLookup; // 0x18
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x20
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x28

	// Properties
	public IReadOnlyList<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IReadOnlyList<PlayerEditorConnectionEvents.MessageTypeSubscribers> get_messageTypeSubscribers() { }

	// RVA: 0x235C400 Offset: 0x235AA00 VA: 0x18235C400
	private void BuildLookup() { }

	// RVA: 0x235C6F0 Offset: 0x235ACF0 VA: 0x18235C6F0
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x235C190 Offset: 0x235A790 VA: 0x18235C190
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x235C870 Offset: 0x235AE70 VA: 0x18235C870
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x235C9A0 Offset: 0x235AFA0 VA: 0x18235C9A0
	public void .ctor() { }
}

