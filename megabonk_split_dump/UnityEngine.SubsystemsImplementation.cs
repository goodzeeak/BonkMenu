// Namespace: UnityEngine.SubsystemsImplementation
[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemDescriptorStore // TypeDefIndex: 14211
{
	// Fields
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23E0450 Offset: 0x23DEA50 VA: 0x1823E0450
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[RequiredByNativeCode]
	// RVA: 0x23E02C0 Offset: 0x23DE8C0 VA: 0x1823E02C0
	internal static void ClearManagedDescriptors() { }

	// RVA: 0x23E05F0 Offset: 0x23DEBF0 VA: 0x1823E05F0
	private static void ReportSingleSubsystemAnalytics(string id) { }

	// RVA: -1 Offset: -1
	internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C01B0 Offset: 0x7BE7B0 VA: 0x1807C01B0
	|-SubsystemDescriptorStore.RegisterDescriptor<object, object>
	|
	|-RVA: 0x7BFBA0 Offset: 0x7BE1A0 VA: 0x1807BFBA0
	|-SubsystemDescriptorStore.RegisterDescriptor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23E0540 Offset: 0x23DEB40 VA: 0x1823E0540
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	// RVA: 0x23E0780 Offset: 0x23DED80 VA: 0x1823E0780
	private static void .cctor() { }

	// RVA: 0x23E05B0 Offset: 0x23DEBB0 VA: 0x1823E05B0
	private static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id) { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor // TypeDefIndex: 14212
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10

	// Properties
	public string id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public string get_id() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.SubsystemsImplementation
public abstract class SubsystemWithProvider // TypeDefIndex: 14213
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

