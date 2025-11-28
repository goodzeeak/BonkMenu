// Namespace: UnityEngine.AddressableAssets.Utility
internal class DiagnosticInfo // TypeDefIndex: 13134
{
	// Fields
	public string DisplayName; // 0x10
	public int ObjectId; // 0x18
	public int[] Dependencies; // 0x20

	// Methods

	// RVA: 0x1EB5EB0 Offset: 0x1EB44B0 VA: 0x181EB5EB0
	public DiagnosticEvent CreateEvent(string category, ResourceManager.DiagnosticEventType eventType, int frame, int val) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal class ResourceManagerDiagnostics : IDisposable // TypeDefIndex: 13135
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private const int k_NumberOfCompletedOpResultEntriesToShow = 4;
	private const int k_MaximumCompletedOpResultEntryLength = 30;
	private Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo; // 0x18

	// Methods

	// RVA: 0x1EC1530 Offset: 0x1EBFB30 VA: 0x181EC1530
	public void .ctor(ResourceManager resourceManager) { }

	// RVA: 0x1EC1300 Offset: 0x1EBF900 VA: 0x181EC1300
	internal int SumDependencyNameHashCodes(AsyncOperationHandle handle) { }

	// RVA: 0x1EC07D0 Offset: 0x1EBEDD0 VA: 0x181EC07D0
	internal int CalculateHashCode(AsyncOperationHandle handle) { }

	// RVA: 0x1EC0730 Offset: 0x1EBED30 VA: 0x181EC0730
	internal int CalculateCompletedOperationHashcode(AsyncOperationHandle handle) { }

	// RVA: 0x1EC0A60 Offset: 0x1EBF060 VA: 0x181EC0A60
	internal string GenerateCompletedOperationDisplayName(AsyncOperationHandle handle) { }

	// RVA: 0x1EC0EB0 Offset: 0x1EBF4B0 VA: 0x181EC0EB0
	private void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext) { }

	// RVA: 0x1EC0990 Offset: 0x1EBEF90 VA: 0x181EC0990 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.AddressableAssets.Utility
internal static class SerializationUtilities // TypeDefIndex: 13137
{
	// Methods

	// RVA: 0x140B7C0 Offset: 0x1409DC0 VA: 0x18140B7C0
	internal static int ReadInt32FromByteArray(byte[] data, int offset) { }

	// RVA: 0x1EC1A20 Offset: 0x1EC0020 VA: 0x181EC1A20
	internal static int WriteInt32ToByteArray(byte[] data, int val, int offset) { }

	// RVA: 0x1EC1620 Offset: 0x1EBFC20 VA: 0x181EC1620
	internal static object ReadObjectFromByteArray(byte[] keyData, int dataIndex) { }

	// RVA: 0x1EC1A90 Offset: 0x1EC0090 VA: 0x181EC1A90
	internal static int WriteObjectToByteList(object obj, List<byte> buffer) { }
}

