// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[NativeConditional("ENABLE_VR")]
[StaticAccessor("XRInputTrackingFacade::Get()", 0)]
public static class InputTracking // TypeDefIndex: 13953
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> trackingLost; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2689290 Offset: 0x2687890 VA: 0x182689290
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }
}

// Namespace: UnityEngine.XR
public enum XRNode // TypeDefIndex: 13954
{
	// Fields
	public int value__; // 0x0
	public const XRNode LeftEye = 0;
	public const XRNode RightEye = 1;
	public const XRNode CenterEye = 2;
	public const XRNode Head = 3;
	public const XRNode LeftHand = 4;
	public const XRNode RightHand = 5;
	public const XRNode GameController = 6;
	public const XRNode TrackingReference = 7;
	public const XRNode HardwareTracker = 8;
}

// Namespace: UnityEngine.XR
[Flags]
internal enum AvailableTrackingData // TypeDefIndex: 13955
{
	// Fields
	public int value__; // 0x0
	public const AvailableTrackingData None = 0;
	public const AvailableTrackingData PositionAvailable = 1;
	public const AvailableTrackingData RotationAvailable = 2;
	public const AvailableTrackingData VelocityAvailable = 4;
	public const AvailableTrackingData AngularVelocityAvailable = 8;
	public const AvailableTrackingData AccelerationAvailable = 16;
	public const AvailableTrackingData AngularAccelerationAvailable = 32;
}

// Namespace: UnityEngine.XR
[UsedByNativeCode]
public struct XRNodeState // TypeDefIndex: 13956
{
	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x1623860 Offset: 0x1621E60 VA: 0x181623860
	public void set_uniqueID(ulong value) { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_nodeType(XRNode value) { }

	// RVA: 0x2689F30 Offset: 0x2688530 VA: 0x182689F30
	public void set_tracked(bool value) { }
}

// Namespace: UnityEngine.XR
internal enum InputFeatureType // TypeDefIndex: 13957
{
	// Fields
	public uint value__; // 0x0
	public const InputFeatureType Custom = 0;
	public const InputFeatureType Binary = 1;
	public const InputFeatureType DiscreteStates = 2;
	public const InputFeatureType Axis1D = 3;
	public const InputFeatureType Axis2D = 4;
	public const InputFeatureType Axis3D = 5;
	public const InputFeatureType Rotation = 6;
	public const InputFeatureType Hand = 7;
	public const InputFeatureType Bone = 8;
	public const InputFeatureType Eyes = 9;
	public const InputFeatureType kUnityXRInputFeatureTypeInvalid = 4294967295;
}

// Namespace: UnityEngine.XR
internal enum ConnectionChangeType // TypeDefIndex: 13958
{
	// Fields
	public uint value__; // 0x0
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeConditional("ENABLE_VR")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 13959
{
	// Fields
	internal string m_Name; // 0x0
	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	public string get_name() { }

	// RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	internal InputFeatureType get_internalType() { }

	// RVA: 0x2689120 Offset: 0x2687720 VA: 0x182689120 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26891E0 Offset: 0x26877E0 VA: 0x1826891E0 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x2689230 Offset: 0x2687830 VA: 0x182689230 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 13960
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x2689030 Offset: 0x2687630 VA: 0x182689030
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x2689040 Offset: 0x2687640 VA: 0x182689040
	private ulong get_deviceId() { }

	// RVA: 0x2688F20 Offset: 0x2687520 VA: 0x182688F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2688FD0 Offset: 0x26875D0 VA: 0x182688FD0 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x2689000 Offset: 0x2687600 VA: 0x182689000 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", 0)]
public struct Hand : IEquatable<Hand> // TypeDefIndex: 13961
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	internal ulong get_deviceId() { }

	// RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	internal uint get_featureIndex() { }

	// RVA: 0x2688D20 Offset: 0x2687320 VA: 0x182688D20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2688B50 Offset: 0x2687150 VA: 0x182688B50 Slot: 4
	public bool Equals(Hand other) { }

	// RVA: 0x2688C20 Offset: 0x2687220 VA: 0x182688C20 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeConditional("ENABLE_VR")]
[RequiredByNativeCode]
public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 13962
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	internal ulong get_deviceId() { }

	// RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	internal uint get_featureIndex() { }

	// RVA: 0x2688C70 Offset: 0x2687270 VA: 0x182688C70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2688B50 Offset: 0x2687150 VA: 0x182688B50 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x2688C20 Offset: 0x2687220 VA: 0x182688C20 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeConditional("ENABLE_VR")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", 0)]
[NativeHeader("XRScriptingClasses.h")]
public struct Bone : IEquatable<Bone> // TypeDefIndex: 13963
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	internal ulong get_deviceId() { }

	// RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	internal uint get_featureIndex() { }

	// RVA: 0x2688B70 Offset: 0x2687170 VA: 0x182688B70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2688B50 Offset: 0x2687150 VA: 0x182688B50 Slot: 4
	public bool Equals(Bone other) { }

	// RVA: 0x2688C20 Offset: 0x2687220 VA: 0x182688C20 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[UsedByNativeCode]
[StaticAccessor("XRInputDevices::Get()", 0)]
public class InputDevices // TypeDefIndex: 13964
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceConnected; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<InputDevice> deviceConfigChanged; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2689060 Offset: 0x2687660 VA: 0x182689060
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UsedByNativeCode]
[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 13968
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<bool> displayFocusChanged; // 0x20

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x22EBB20 Offset: 0x22EA120 VA: 0x1822EBB20
	private void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x2689C10 Offset: 0x2688210 VA: 0x182689C10
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
[UsedByNativeCode]
public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 13969
{
	// Methods

	// RVA: 0x2689BD0 Offset: 0x26881D0 VA: 0x182689BD0
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 13970
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x2689D50 Offset: 0x2688350 VA: 0x182689D50
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x2689C90 Offset: 0x2688290 VA: 0x182689C90
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x2689E10 Offset: 0x2688410 VA: 0x182689E10
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
[UsedByNativeCode]
[NativeConditional("ENABLE_XR")]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 13971
{
	// Methods

	// RVA: 0x2689C50 Offset: 0x2688250 VA: 0x182689C50
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[UsedByNativeCode]
public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 13972
{
	// Fields
	private static MeshId s_InvalidId; // 0x0
	private ulong m_SubId1; // 0x0
	private ulong m_SubId2; // 0x8

	// Methods

	// RVA: 0x2689A90 Offset: 0x2688090 VA: 0x182689A90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2319FF0 Offset: 0x23185F0 VA: 0x182319FF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26899D0 Offset: 0x2687FD0 VA: 0x1826899D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x231A3B0 Offset: 0x23189B0 VA: 0x18231A3B0 Slot: 4
	public bool Equals(MeshId other) { }

	// RVA: 0x2689B10 Offset: 0x2688110 VA: 0x182689B10
	private static void .cctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[RequiredByNativeCode]
public enum MeshGenerationStatus // TypeDefIndex: 13973
{
	// Fields
	public int value__; // 0x0
	public const MeshGenerationStatus Success = 0;
	public const MeshGenerationStatus InvalidMeshId = 1;
	public const MeshGenerationStatus GenerationAlreadyInProgress = 2;
	public const MeshGenerationStatus Canceled = 3;
	public const MeshGenerationStatus UnknownError = 4;
}

// Namespace: UnityEngine.XR
internal static class HashCodeHelper // TypeDefIndex: 13974
{
	// Methods

	// RVA: 0x2688E10 Offset: 0x2687410 VA: 0x182688E10
	public static int Combine(int hash1, int hash2) { }

	// RVA: 0x2688EE0 Offset: 0x26874E0 VA: 0x182688EE0
	public static int Combine(int hash1, int hash2, int hash3) { }

	// RVA: 0x2688F00 Offset: 0x2687500 VA: 0x182688F00
	public static int Combine(int hash1, int hash2, int hash3, int hash4) { }

	// RVA: 0x2688E60 Offset: 0x2687460 VA: 0x182688E60
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5) { }

	// RVA: 0x2688E20 Offset: 0x2687420 VA: 0x182688E20
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6) { }

	// RVA: 0x2688DD0 Offset: 0x26873D0 VA: 0x182688DD0
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7) { }

	// RVA: 0x2688E90 Offset: 0x2687490 VA: 0x182688E90
	public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8) { }
}

// Namespace: UnityEngine.XR
[RequiredByNativeCode]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 13975
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <Timestamp>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Vector3 <Position>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Quaternion <Rotation>k__BackingField; // 0x3C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Vector3 <Scale>k__BackingField; // 0x4C

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Scale { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public MeshId get_MeshId() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Mesh get_Mesh() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public MeshCollider get_MeshCollider() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public MeshGenerationStatus get_Status() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public MeshVertexAttributes get_Attributes() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3CB430 Offset: 0x3C9A30 VA: 0x1803CB430
	public Vector3 get_Position() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x2449E20 Offset: 0x2448420 VA: 0x182449E20
	public Quaternion get_Rotation() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x26899B0 Offset: 0x2687FB0 VA: 0x1826899B0
	public Vector3 get_Scale() { }

	// RVA: 0x2689450 Offset: 0x2687A50 VA: 0x182689450 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2689530 Offset: 0x2687B30 VA: 0x182689530 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x2689750 Offset: 0x2687D50 VA: 0x182689750 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.XR
[Flags]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[UsedByNativeCode]
public enum MeshVertexAttributes // TypeDefIndex: 13976
{
	// Fields
	public int value__; // 0x0
	public const MeshVertexAttributes None = 0;
	public const MeshVertexAttributes Normals = 1;
	public const MeshVertexAttributes Tangents = 2;
	public const MeshVertexAttributes UVs = 4;
	public const MeshVertexAttributes Colors = 8;
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[NativeConditional("ENABLE_XR")]
[UsedByNativeCode]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 13978
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2689E90 Offset: 0x2688490 VA: 0x182689E90
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x2689EF0 Offset: 0x26884F0 VA: 0x182689EF0
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
[UsedByNativeCode]
public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 13979
{
	// Methods

	// RVA: 0x2689E50 Offset: 0x2688450 VA: 0x182689E50
	public void .ctor() { }
}

// Namespace: UnityEngine.XR
[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
[NativeHeader("Modules/VR/VRModule.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeConditional("ENABLE_VR")]
public static class XRSettings // TypeDefIndex: 14283
{
	// Properties
	public static bool enabled { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static int eyeTextureWidth { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static int eyeTextureHeight { get; }
	[NativeName("IntermediateEyeTextureDesc")]
	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static RenderTextureDescriptor eyeTextureDesc { get; }
	public static float renderViewportScale { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	[NativeName("RenderViewportScale")]
	internal static float renderViewportScaleInternal { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static XRSettings.StereoRenderingMode stereoRenderingMode { get; }

	// Methods

	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	// RVA: 0x26889D0 Offset: 0x2686FD0 VA: 0x1826889D0
	public static bool get_enabled() { }

	// RVA: 0x2688AC0 Offset: 0x26870C0 VA: 0x182688AC0
	public static int get_eyeTextureWidth() { }

	// RVA: 0x2688A90 Offset: 0x2687090 VA: 0x182688A90
	public static int get_eyeTextureHeight() { }

	// RVA: 0x2688A40 Offset: 0x2687040 VA: 0x182688A40
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	// RVA: 0x2688AF0 Offset: 0x26870F0 VA: 0x182688AF0
	public static float get_renderViewportScale() { }

	// RVA: 0x2688AF0 Offset: 0x26870F0 VA: 0x182688AF0
	internal static float get_renderViewportScaleInternal() { }

	// RVA: 0x2688B20 Offset: 0x2687120 VA: 0x182688B20
	public static XRSettings.StereoRenderingMode get_stereoRenderingMode() { }

	// RVA: 0x2688A00 Offset: 0x2687000 VA: 0x182688A00
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }
}

// Namespace: UnityEngine.XR
[NativeConditional("ENABLE_VR")]
public static class XRDevice // TypeDefIndex: 14284
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string> deviceLoaded; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2688970 Offset: 0x2686F70 VA: 0x182688970
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }
}

