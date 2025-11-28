// Namespace: UnityEngine.Internal
[Usage(18432)]
[Serializable]
public class DefaultValueAttribute : Attribute // TypeDefIndex: 10052
{
	// Fields
	private object DefaultValue; // 0x10

	// Properties
	public object Value { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string value) { }

	// RVA: 0x101AB70 Offset: 0x1019170 VA: 0x18101AB70
	public object get_Value() { }

	// RVA: 0x2352CA0 Offset: 0x23512A0 VA: 0x182352CA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2352D50 Offset: 0x2351350 VA: 0x182352D50 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Internal
[Serializable]
public class ExcludeFromDocsAttribute : Attribute // TypeDefIndex: 10053
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Internal
[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility // TypeDefIndex: 13992
{
	// Methods

	[NativeThrows]
	// RVA: 0x23A6AC0 Offset: 0x23A50C0 VA: 0x1823A6AC0
	internal static bool GetKeyString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x23A6B00 Offset: 0x23A5100 VA: 0x1823A6B00
	internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x23A6A80 Offset: 0x23A5080 VA: 0x1823A6A80
	internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x23A62F0 Offset: 0x23A48F0 VA: 0x1823A62F0
	internal static float GetAxis(string axisName) { }

	[NativeThrows]
	// RVA: 0x23A62B0 Offset: 0x23A48B0 VA: 0x1823A62B0
	internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x23A60E0 Offset: 0x23A46E0 VA: 0x1823A60E0
	internal static float GetAxisRaw(string axisName) { }

	[NativeThrows]
	// RVA: 0x23A60A0 Offset: 0x23A46A0 VA: 0x1823A60A0
	internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x23A6900 Offset: 0x23A4F00 VA: 0x1823A6900
	internal static bool GetButton(string buttonName) { }

	[NativeThrows]
	// RVA: 0x23A68C0 Offset: 0x23A4EC0 VA: 0x1823A68C0
	internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x23A6500 Offset: 0x23A4B00 VA: 0x1823A6500
	internal static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	// RVA: 0x23A64C0 Offset: 0x23A4AC0 VA: 0x1823A64C0
	internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x23A6700 Offset: 0x23A4D00 VA: 0x1823A6700
	internal static bool GetButtonUp(string buttonName) { }

	[NativeThrows]
	// RVA: 0x23A66C0 Offset: 0x23A4CC0 VA: 0x1823A66C0
	internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen) { }

	// RVA: 0x23A6270 Offset: 0x23A4870 VA: 0x1823A6270
	private static float GetAxis_Injected(ref ManagedSpanWrapper axisName) { }

	// RVA: 0x23A6060 Offset: 0x23A4660 VA: 0x1823A6060
	private static float GetAxisRaw_Injected(ref ManagedSpanWrapper axisName) { }

	// RVA: 0x23A6880 Offset: 0x23A4E80 VA: 0x1823A6880
	private static bool GetButton_Injected(ref ManagedSpanWrapper buttonName) { }

	// RVA: 0x23A6480 Offset: 0x23A4A80 VA: 0x1823A6480
	private static bool GetButtonDown_Injected(ref ManagedSpanWrapper buttonName) { }

	// RVA: 0x23A6680 Offset: 0x23A4C80 VA: 0x1823A6680
	private static bool GetButtonUp_Injected(ref ManagedSpanWrapper buttonName) { }
}

