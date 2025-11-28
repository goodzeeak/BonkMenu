// Namespace: System.Runtime
[Serializable]
public sealed class AmbiguousImplementationException : Exception // TypeDefIndex: 823
{
	// Methods

	// RVA: 0x13B81F0 Offset: 0x13B67F0 VA: 0x1813B81F0
	public void .ctor() { }

	// RVA: 0x13B82E0 Offset: 0x13B68E0 VA: 0x1813B82E0
	public void .ctor(string message) { }

	// RVA: 0x13B8260 Offset: 0x13B6860 VA: 0x1813B8260
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Runtime
public static class RuntimeImports // TypeDefIndex: 824
{
	// Methods

	// RVA: 0x13D04B0 Offset: 0x13CEAB0 VA: 0x1813D04B0
	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	// RVA: 0x13D04B0 Offset: 0x13CEAB0 VA: 0x1813D04B0
	private static void ZeroMemory(void* p, uint byteLength) { }

	// RVA: 0x13D0490 Offset: 0x13CEA90 VA: 0x1813D0490
	internal static void Memmove(byte* dest, byte* src, uint len) { }

	// RVA: 0x13D04A0 Offset: 0x13CEAA0 VA: 0x1813D04A0
	internal static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle) { }

	// RVA: 0x13D04C0 Offset: 0x13CEAC0 VA: 0x1813D04C0
	internal static void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign) { }
}

