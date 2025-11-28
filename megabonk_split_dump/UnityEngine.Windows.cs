// Namespace: UnityEngine.Windows
[NativeHeader("PlatformDependent/Win/Bindings/InputBindings.h")]
public static class Input // TypeDefIndex: 9805
{
	// Methods

	[StaticAccessor("", 2)]
	[NativeName("ForwardRawInput")]
	[ThreadSafe]
	// RVA: 0x23546C0 Offset: 0x2352CC0 VA: 0x1823546C0
	private static void ForwardRawInputImpl(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize) { }

	// RVA: 0x2354890 Offset: 0x2352E90 VA: 0x182354890
	public static void ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize) { }

	// RVA: 0x2354730 Offset: 0x2352D30 VA: 0x182354730
	public static void ForwardRawInput(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize) { }
}

