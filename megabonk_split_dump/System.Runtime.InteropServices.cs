// Namespace: System.Runtime.InteropServices
public enum CharSet // TypeDefIndex: 1071
{
	// Fields
	public int value__; // 0x0
	public const CharSet None = 1;
	public const CharSet Ansi = 2;
	public const CharSet Unicode = 3;
	public const CharSet Auto = 4;
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class ExternalException : SystemException // TypeDefIndex: 1072
{
	// Methods

	// RVA: 0x1414BB0 Offset: 0x14131B0 VA: 0x181414BB0
	public void .ctor() { }

	// RVA: 0x14161C0 Offset: 0x14147C0 VA: 0x1814161C0
	public void .ctor(string message) { }

	// RVA: 0x14161E0 Offset: 0x14147E0 VA: 0x1814161E0
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1415FE0 Offset: 0x14145E0 VA: 0x181415FE0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.InteropServices
[IsReadOnly]
public struct HandleRef // TypeDefIndex: 1073
{
	// Fields
	private readonly object _wrapper; // 0x0
	private readonly IntPtr _handle; // 0x8

	// Properties
	public IntPtr Handle { get; }

	// Methods

	// RVA: 0x1105450 Offset: 0x1103A50 VA: 0x181105450
	public void .ctor(object wrapper, IntPtr handle) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public IntPtr get_Handle() { }
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class MarshalDirectiveException : SystemException // TypeDefIndex: 1074
{
	// Methods

	// RVA: 0x1418660 Offset: 0x1416C60 VA: 0x181418660
	public void .ctor() { }

	// RVA: 0x14186B0 Offset: 0x1416CB0 VA: 0x1814186B0
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Runtime.InteropServices
public static class MemoryMarshal // TypeDefIndex: 1075
{
	// Methods

	// RVA: -1 Offset: -1
	public static Span<byte> AsBytes<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731760 Offset: 0x72FD60 VA: 0x180731760
	|-MemoryMarshal.AsBytes<char>
	|
	|-RVA: 0x731930 Offset: 0x72FF30 VA: 0x180731930
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731A60 Offset: 0x730060 VA: 0x180731A60
	|-MemoryMarshal.AsBytes<ushort>
	|
	|-RVA: 0x731B00 Offset: 0x730100 VA: 0x180731B00
	|-MemoryMarshal.AsBytes<uint>
	|
	|-RVA: 0x731800 Offset: 0x72FE00 VA: 0x180731800
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	|-MemoryMarshal.AsMemory<byte>
	|-MemoryMarshal.AsMemory<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|-MemoryMarshal.GetReference<int>
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|-MemoryMarshal.GetReference<ushort>
	|-MemoryMarshal.GetReference<uint>
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731BF0 Offset: 0x7301F0 VA: 0x180731BF0
	|-MemoryMarshal.GetNonNullPinnableReference<char>
	|
	|-RVA: 0x731C30 Offset: 0x730230 VA: 0x180731C30
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731BF0 Offset: 0x7301F0 VA: 0x180731BF0
	|-MemoryMarshal.GetNonNullPinnableReference<byte>
	|
	|-RVA: 0x731C30 Offset: 0x730230 VA: 0x180731C30
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731BA0 Offset: 0x7301A0 VA: 0x180731BA0
	|-MemoryMarshal.CreateReadOnlySpan<char>
	|-MemoryMarshal.CreateReadOnlySpan<uint>
	|-MemoryMarshal.CreateReadOnlySpan<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731CA0 Offset: 0x7302A0 VA: 0x180731CA0
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x731F60 Offset: 0x730560 VA: 0x180731F60
	|-MemoryMarshal.TryGetArray<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.InteropServices
public enum GCHandleType // TypeDefIndex: 1076
{
	// Fields
	public int value__; // 0x0
	public const GCHandleType Weak = 0;
	public const GCHandleType WeakTrackResurrection = 1;
	public const GCHandleType Normal = 2;
	public const GCHandleType Pinned = 3;
}

// Namespace: System.Runtime.InteropServices
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1077
{
	// Fields
	private static readonly UIntPtr Uninitialized; // 0x0
	private UIntPtr _numBytes; // 0x20

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1423A90 Offset: 0x1422090 VA: 0x181423A90
	public void AcquirePointer(ref byte* pointer) { }

	// RVA: 0x1423BD0 Offset: 0x14221D0 VA: 0x181423BD0
	public void ReleasePointer() { }

	// RVA: 0x1423B70 Offset: 0x1422170 VA: 0x181423B70
	private static InvalidOperationException NotInitialized() { }

	// RVA: 0x1423C90 Offset: 0x1422290 VA: 0x181423C90
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class COMException : ExternalException // TypeDefIndex: 1078
{
	// Methods

	// RVA: 0x1414BB0 Offset: 0x14131B0 VA: 0x181414BB0
	public void .ctor() { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14149E0 Offset: 0x1412FE0 VA: 0x1814149E0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.InteropServices
public sealed class ErrorWrapper // TypeDefIndex: 1079
{
	// Fields
	private int m_ErrorCode; // 0x10
}

// Namespace: System.Runtime.InteropServices
public interface ICustomMarshaler // TypeDefIndex: 1080
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object MarshalNativeToManaged(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IntPtr MarshalManagedToNative(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CleanUpNativeData(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CleanUpManagedData(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetNativeDataSize();
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(4096, AllowMultiple = False, Inherited = False)]
public sealed class UnmanagedFunctionPointerAttribute : Attribute // TypeDefIndex: 1081
{
	// Fields
	private CallingConvention m_callingConvention; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(CallingConvention callingConvention) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum ComInterfaceType // TypeDefIndex: 1082
{
	// Fields
	public int value__; // 0x0
	public const ComInterfaceType InterfaceIsDual = 0;
	public const ComInterfaceType InterfaceIsIUnknown = 1;
	public const ComInterfaceType InterfaceIsIDispatch = 2;
	[ComVisible(False)]
	public const ComInterfaceType InterfaceIsIInspectable = 3;
}

// Namespace: System.Runtime.InteropServices
[Usage(1024, Inherited = False)]
[ComVisible(True)]
public sealed class InterfaceTypeAttribute : Attribute // TypeDefIndex: 1083
{
	// Fields
	internal ComInterfaceType _val; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(ComInterfaceType interfaceType) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(4, Inherited = False)]
[ComVisible(True)]
public sealed class ComDefaultInterfaceAttribute : Attribute // TypeDefIndex: 1084
{
	// Fields
	internal Type _val; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type defaultInterface) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum ClassInterfaceType // TypeDefIndex: 1085
{
	// Fields
	public int value__; // 0x0
	public const ClassInterfaceType None = 0;
	public const ClassInterfaceType AutoDispatch = 1;
	public const ClassInterfaceType AutoDual = 2;
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(5, Inherited = False)]
public sealed class ClassInterfaceAttribute : Attribute // TypeDefIndex: 1086
{
	// Fields
	internal ClassInterfaceType _val; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(ClassInterfaceType classInterfaceType) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(5597, Inherited = False)]
[ComVisible(True)]
public sealed class ComVisibleAttribute : Attribute // TypeDefIndex: 1087
{
	// Fields
	internal bool _val; // 0x10

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool visibility) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum VarEnum // TypeDefIndex: 1088
{
	// Fields
	public int value__; // 0x0
	public const VarEnum VT_EMPTY = 0;
	public const VarEnum VT_NULL = 1;
	public const VarEnum VT_I2 = 2;
	public const VarEnum VT_I4 = 3;
	public const VarEnum VT_R4 = 4;
	public const VarEnum VT_R8 = 5;
	public const VarEnum VT_CY = 6;
	public const VarEnum VT_DATE = 7;
	public const VarEnum VT_BSTR = 8;
	public const VarEnum VT_DISPATCH = 9;
	public const VarEnum VT_ERROR = 10;
	public const VarEnum VT_BOOL = 11;
	public const VarEnum VT_VARIANT = 12;
	public const VarEnum VT_UNKNOWN = 13;
	public const VarEnum VT_DECIMAL = 14;
	public const VarEnum VT_I1 = 16;
	public const VarEnum VT_UI1 = 17;
	public const VarEnum VT_UI2 = 18;
	public const VarEnum VT_UI4 = 19;
	public const VarEnum VT_I8 = 20;
	public const VarEnum VT_UI8 = 21;
	public const VarEnum VT_INT = 22;
	public const VarEnum VT_UINT = 23;
	public const VarEnum VT_VOID = 24;
	public const VarEnum VT_HRESULT = 25;
	public const VarEnum VT_PTR = 26;
	public const VarEnum VT_SAFEARRAY = 27;
	public const VarEnum VT_CARRAY = 28;
	public const VarEnum VT_USERDEFINED = 29;
	public const VarEnum VT_LPSTR = 30;
	public const VarEnum VT_LPWSTR = 31;
	public const VarEnum VT_RECORD = 36;
	public const VarEnum VT_FILETIME = 64;
	public const VarEnum VT_BLOB = 65;
	public const VarEnum VT_STREAM = 66;
	public const VarEnum VT_STORAGE = 67;
	public const VarEnum VT_STREAMED_OBJECT = 68;
	public const VarEnum VT_STORED_OBJECT = 69;
	public const VarEnum VT_BLOB_OBJECT = 70;
	public const VarEnum VT_CF = 71;
	public const VarEnum VT_CLSID = 72;
	public const VarEnum VT_VECTOR = 4096;
	public const VarEnum VT_ARRAY = 8192;
	public const VarEnum VT_BYREF = 16384;
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum UnmanagedType // TypeDefIndex: 1089
{
	// Fields
	public int value__; // 0x0
	public const UnmanagedType Bool = 2;
	public const UnmanagedType I1 = 3;
	public const UnmanagedType U1 = 4;
	public const UnmanagedType I2 = 5;
	public const UnmanagedType U2 = 6;
	public const UnmanagedType I4 = 7;
	public const UnmanagedType U4 = 8;
	public const UnmanagedType I8 = 9;
	public const UnmanagedType U8 = 10;
	public const UnmanagedType R4 = 11;
	public const UnmanagedType R8 = 12;
	public const UnmanagedType Currency = 15;
	public const UnmanagedType BStr = 19;
	public const UnmanagedType LPStr = 20;
	public const UnmanagedType LPWStr = 21;
	public const UnmanagedType LPTStr = 22;
	public const UnmanagedType ByValTStr = 23;
	public const UnmanagedType IUnknown = 25;
	public const UnmanagedType IDispatch = 26;
	public const UnmanagedType Struct = 27;
	public const UnmanagedType Interface = 28;
	public const UnmanagedType SafeArray = 29;
	public const UnmanagedType ByValArray = 30;
	public const UnmanagedType SysInt = 31;
	public const UnmanagedType SysUInt = 32;
	public const UnmanagedType VBByRefStr = 34;
	public const UnmanagedType AnsiBStr = 35;
	public const UnmanagedType TBStr = 36;
	public const UnmanagedType VariantBool = 37;
	public const UnmanagedType FunctionPtr = 38;
	public const UnmanagedType AsAny = 40;
	public const UnmanagedType LPArray = 42;
	public const UnmanagedType LPStruct = 43;
	public const UnmanagedType CustomMarshaler = 44;
	public const UnmanagedType Error = 45;
	[ComVisible(False)]
	public const UnmanagedType IInspectable = 46;
	[ComVisible(False)]
	public const UnmanagedType HString = 47;
	[ComVisible(False)]
	public const UnmanagedType LPUTF8Str = 48;
}

// Namespace: System.Runtime.InteropServices
[Usage(1028, Inherited = False)]
[ComVisible(True)]
public sealed class ComImportAttribute : Attribute // TypeDefIndex: 1090
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(5149, Inherited = False)]
[ComVisible(True)]
public sealed class GuidAttribute : Attribute // TypeDefIndex: 1091
{
	// Fields
	internal string _val; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string guid) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class PreserveSigAttribute : Attribute // TypeDefIndex: 1092
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(2048, Inherited = False)]
public sealed class InAttribute : Attribute // TypeDefIndex: 1093
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(2048, Inherited = False)]
public sealed class OutAttribute : Attribute // TypeDefIndex: 1094
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(2048, Inherited = False)]
[ComVisible(True)]
public sealed class OptionalAttribute : Attribute // TypeDefIndex: 1095
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Flags]
public enum DllImportSearchPath // TypeDefIndex: 1096
{
	// Fields
	public int value__; // 0x0
	public const DllImportSearchPath UseDllDirectoryForDependencies = 256;
	public const DllImportSearchPath ApplicationDirectory = 512;
	public const DllImportSearchPath UserDirectories = 1024;
	public const DllImportSearchPath System32 = 2048;
	public const DllImportSearchPath SafeDirectories = 4096;
	public const DllImportSearchPath AssemblyDirectory = 2;
	public const DllImportSearchPath LegacyBehavior = 0;
}

// Namespace: System.Runtime.InteropServices
[Usage(65, AllowMultiple = False)]
[ComVisible(False)]
public sealed class DefaultDllImportSearchPathsAttribute : Attribute // TypeDefIndex: 1097
{
	// Fields
	internal DllImportSearchPath _paths; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(DllImportSearchPath paths) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1098
{
	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x14156B0 Offset: 0x1413CB0 VA: 0x1814156B0
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0x14158F0 Offset: 0x1413EF0 VA: 0x1814158F0
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0x1415920 Offset: 0x1413F20 VA: 0x181415920
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string dllName) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Value() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(256, Inherited = False)]
[ComVisible(True)]
public sealed class FieldOffsetAttribute : Attribute // TypeDefIndex: 1099
{
	// Fields
	internal int _val; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int offset) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(1, Inherited = False)]
[ComVisible(True)]
public sealed class ComCompatibleVersionAttribute : Attribute // TypeDefIndex: 1100
{
	// Fields
	internal int _major; // 0x10
	internal int _minor; // 0x14
	internal int _build; // 0x18
	internal int _revision; // 0x1C

	// Methods

	// RVA: 0x1414C00 Offset: 0x1413200 VA: 0x181414C00
	public void .ctor(int major, int minor, int build, int revision) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum CallingConvention // TypeDefIndex: 1101
{
	// Fields
	public int value__; // 0x0
	public const CallingConvention Winapi = 1;
	public const CallingConvention Cdecl = 2;
	public const CallingConvention StdCall = 3;
	public const CallingConvention ThisCall = 4;
	public const CallingConvention FastCall = 5;
}

// Namespace: System.Runtime.InteropServices
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1102
{
	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x14240C0 Offset: 0x14226C0 VA: 0x1814240C0
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0x1423EF0 Offset: 0x14224F0 VA: 0x181423EF0 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1424150 Offset: 0x1422750 VA: 0x181424150
	public bool get_IsClosed() { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContract(3, 2)]
	// RVA: 0x1421A30 Offset: 0x1420030 VA: 0x181421A30
	public void Close() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1421A30 Offset: 0x1420030 VA: 0x181421A30 Slot: 4
	public void Dispose() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1423E30 Offset: 0x1422430 VA: 0x181423E30 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContract(3, 2)]
	// RVA: 0x1424020 Offset: 0x1422620 VA: 0x181424020
	public void SetHandleAsInvalid() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1423CF0 Offset: 0x14222F0 VA: 0x181423CF0
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1423E20 Offset: 0x1422420 VA: 0x181423E20
	public void DangerousRelease() { }

	// RVA: 0x1423F60 Offset: 0x1422560 VA: 0x181423F60
	private void InternalDispose() { }

	// RVA: 0x1424000 Offset: 0x1422600 VA: 0x181424000
	private void InternalFinalize() { }

	// RVA: 0x1423D80 Offset: 0x1422380 VA: 0x181423D80
	private void DangerousReleaseInternal(bool dispose) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
public struct GCHandle // TypeDefIndex: 1103
{
	// Fields
	private IntPtr handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	private void .ctor(IntPtr h) { }

	// RVA: 0x14179B0 Offset: 0x1415FB0 VA: 0x1814179B0
	private void .ctor(object obj) { }

	// RVA: 0x1417980 Offset: 0x1415F80 VA: 0x181417980
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x12A0130 Offset: 0x129E730 VA: 0x1812A0130
	public bool get_IsAllocated() { }

	// RVA: 0x1417910 Offset: 0x1415F10 VA: 0x181417910
	internal static object GetRef(IntPtr handle) { }

	// RVA: 0x1417950 Offset: 0x1415F50 VA: 0x181417950
	internal static void SetRef(IntPtr handle, object value) { }

	// RVA: 0x1417700 Offset: 0x1415D00 VA: 0x181417700
	internal static bool CanDereferenceHandle(IntPtr handle) { }

	// RVA: 0x14179E0 Offset: 0x1415FE0 VA: 0x1814179E0
	public object get_Target() { }

	// RVA: 0x1417A70 Offset: 0x1416070 VA: 0x181417A70
	public void set_Target(object value) { }

	// RVA: 0x1417600 Offset: 0x1415C00 VA: 0x181417600
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0x14176F0 Offset: 0x1415CF0 VA: 0x1814176F0
	public static GCHandle Alloc(object value) { }

	// RVA: 0x14176D0 Offset: 0x1415CD0 VA: 0x1814176D0
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x14177C0 Offset: 0x1415DC0 VA: 0x1814177C0
	public void Free() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0x1417840 Offset: 0x1415E40 VA: 0x181417840
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0x1417710 Offset: 0x1415D10 VA: 0x181417710
	private static bool CheckCurrentDomain(IntPtr handle) { }

	// RVA: 0x1417940 Offset: 0x1415F40 VA: 0x181417940
	private static object GetTarget(IntPtr handle) { }

	// RVA: 0x1417930 Offset: 0x1415F30 VA: 0x181417930
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	// RVA: 0x14177B0 Offset: 0x1415DB0 VA: 0x1814177B0
	private static void FreeHandle(IntPtr handle) { }

	// RVA: 0x1417900 Offset: 0x1415F00 VA: 0x181417900
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x1417720 Offset: 0x1415D20 VA: 0x181417720 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1417840 Offset: 0x1415E40 VA: 0x181417840
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static IntPtr ToIntPtr(GCHandle value) { }
}

// Namespace: System.Runtime.InteropServices
public static class Marshal // TypeDefIndex: 1107
{
	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4
	internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache; // 0x8
	internal static readonly object MarshalerInstanceCacheLock; // 0x10

	// Methods

	// RVA: 0x14186D0 Offset: 0x1416CD0 VA: 0x1814186D0
	private static int AddRefInternal(IntPtr pUnk) { }

	// RVA: 0x14186E0 Offset: 0x1416CE0 VA: 0x1814186E0
	public static int AddRef(IntPtr pUnk) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1418780 Offset: 0x1416D80 VA: 0x181418780
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1418790 Offset: 0x1416D90 VA: 0x181418790
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0x141AE70 Offset: 0x1419470 VA: 0x18141AE70
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x141AE60 Offset: 0x1419460 VA: 0x18141AE60
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element) { }

	// RVA: 0x141B000 Offset: 0x1419600 VA: 0x18141B000
	private static bool skip_fixed(Array array, int startIndex) { }

	// RVA: 0x141AEF0 Offset: 0x14194F0 VA: 0x18141AEF0
	internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x14189D0 Offset: 0x1416FD0 VA: 0x1814189D0
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1418D50 Offset: 0x1417350 VA: 0x181418D50
	public static void Copy(short[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1418B30 Offset: 0x1417130 VA: 0x181418B30
	public static void Copy(int[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1418C40 Offset: 0x1417240 VA: 0x181418C40
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x141ADE0 Offset: 0x14193E0 VA: 0x18141ADE0
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0x141ADD0 Offset: 0x14193D0 VA: 0x18141ADD0
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element) { }

	// RVA: 0x1419190 Offset: 0x1417790 VA: 0x181419190
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0x1418E60 Offset: 0x1417460 VA: 0x181418E60
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0x1418F70 Offset: 0x1417570 VA: 0x181418F70
	public static void Copy(IntPtr source, int[] destination, int startIndex, int length) { }

	// RVA: 0x1419080 Offset: 0x1417680 VA: 0x181419080
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	// RVA: 0x14192A0 Offset: 0x14178A0 VA: 0x1814192A0
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x14192B0 Offset: 0x14178B0 VA: 0x1814192B0
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0x1418800 Offset: 0x1416E00 VA: 0x181418800
	private static void ClearBSTR(IntPtr ptr) { }

	// RVA: 0x141AAE0 Offset: 0x14190E0 VA: 0x18141AAE0
	public static void ZeroFreeBSTR(IntPtr s) { }

	// RVA: 0x14188D0 Offset: 0x1416ED0 VA: 0x1814188D0
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0x141ABE0 Offset: 0x14191E0 VA: 0x18141ABE0
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0x1419C00 Offset: 0x1418200 VA: 0x181419C00
	public static int GetHRForException(Exception e) { }

	// RVA: 0x1419C10 Offset: 0x1418210 VA: 0x181419C10
	private static IntPtr GetIUnknownForObjectInternal(object o) { }

	// RVA: 0x1419C20 Offset: 0x1418220 VA: 0x181419C20
	public static IntPtr GetIUnknownForObject(object o) { }

	// RVA: 0x1419D10 Offset: 0x1418310 VA: 0x181419D10
	public static bool IsComObject(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1419D00 Offset: 0x1418300 VA: 0x181419D00
	public static int GetLastWin32Error() { }

	// RVA: 0x1419D20 Offset: 0x1418320 VA: 0x181419D20
	public static IntPtr OffsetOf(Type t, string fieldName) { }

	// RVA: 0x1419D30 Offset: 0x1418330 VA: 0x181419D30
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0x1419D40 Offset: 0x1418340 VA: 0x181419D40
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	// RVA: 0x1419D50 Offset: 0x1418350 VA: 0x181419D50
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0x1419D60 Offset: 0x1418360 VA: 0x181419D60
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisible(True)]
	// RVA: 0x1419D70 Offset: 0x1418370 VA: 0x181419D70
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72DC60 Offset: 0x72C260 VA: 0x18072DC60
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0x72DD40 Offset: 0x72C340 VA: 0x18072DD40
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	|
	|-RVA: 0x72DB40 Offset: 0x72C140 VA: 0x18072DB40
	|-Marshal.PtrToStructure<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1419D80 Offset: 0x1418380 VA: 0x181419D80
	private static int QueryInterfaceInternal(IntPtr pUnk, ref Guid iid, out IntPtr ppv) { }

	// RVA: 0x1419D90 Offset: 0x1418390 VA: 0x181419D90
	public static int QueryInterface(IntPtr pUnk, ref Guid iid, out IntPtr ppv) { }

	// RVA: 0x1419E50 Offset: 0x1418450 VA: 0x181419E50
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0x1419E70 Offset: 0x1418470 VA: 0x181419E70
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1419EC0 Offset: 0x14184C0 VA: 0x181419EC0
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	// RVA: 0x1419F10 Offset: 0x1418510 VA: 0x181419F10
	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1419F60 Offset: 0x1418560 VA: 0x181419F60
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x141A070 Offset: 0x1418670 VA: 0x18141A070
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x141A080 Offset: 0x1418680 VA: 0x18141A080
	public static int Release(IntPtr pUnk) { }

	// RVA: 0x141A6E0 Offset: 0x1418CE0 VA: 0x18141A6E0
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72E1A0 Offset: 0x72C7A0 VA: 0x18072E1A0
	|-Marshal.SizeOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x72DE60 Offset: 0x72C460 VA: 0x18072DE60
	|-Marshal.SizeOf<AchievementManager.FFIEvents>
	|-Marshal.SizeOf<OverlayManager.FFIEvents>
	|-Marshal.SizeOf<UserManager.FFIEvents>
	|-Marshal.SizeOf<VoiceManager.FFIEvents>
	|
	|-RVA: 0x72E0F0 Offset: 0x72C6F0 VA: 0x18072E0F0
	|-Marshal.SizeOf<ActivityManager.FFIEvents>
	|-Marshal.SizeOf<niVcjWyfiGBKhvdDrLudThrVJGC.tXsVFvgxZcjXLZmLLNueaegUBrNq>
	|-Marshal.SizeOf<nmZPFrHROjwSJoqMeikFKQsYgJoz.jHrbAPFEJGzDjcUMXSlZXrdJkEwC.pypgrfBmTUiZzsVOZmNBdclitsKNc>
	|
	|-RVA: 0x72E060 Offset: 0x72C660 VA: 0x18072E060
	|-Marshal.SizeOf<ApplicationManager.FFIEvents>
	|-Marshal.SizeOf<Discord.FFIEvents>
	|-Marshal.SizeOf<ImageManager.FFIEvents>
	|-Marshal.SizeOf<StorageManager.FFIEvents>
	|
	|-RVA: 0x72DFA0 Offset: 0x72C5A0 VA: 0x18072DFA0
	|-Marshal.SizeOf<LobbyManager.FFIEvents>
	|
	|-RVA: 0x72DF00 Offset: 0x72C500 VA: 0x18072DF00
	|-Marshal.SizeOf<NetworkManager.FFIEvents>
	|-Marshal.SizeOf<RelationshipManager.FFIEvents>
	|-Marshal.SizeOf<StoreManager.FFIEvents>
	|
	|-RVA: 0x72E2B0 Offset: 0x72C8B0 VA: 0x18072E2B0
	|-Marshal.SizeOf<niVcjWyfiGBKhvdDrLudThrVJGC.rDobWKLhxuVukUpQtHlNDOoECQBX>
	*/

	// RVA: 0x141A6F0 Offset: 0x1418CF0 VA: 0x18141A6F0
	private static IntPtr StringToHGlobalAnsi(char* s, int length) { }

	// RVA: 0x141A700 Offset: 0x1418D00 VA: 0x18141A700
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0x141A800 Offset: 0x1418E00 VA: 0x18141A800
	private static IntPtr StringToHGlobalUni(char* s, int length) { }

	// RVA: 0x141A780 Offset: 0x1418D80 VA: 0x18141A780
	public static IntPtr StringToHGlobalUni(string s) { }

	// RVA: 0x141A1B0 Offset: 0x14187B0 VA: 0x18141A1B0
	public static IntPtr SecureStringToBSTR(SecureString s) { }

	// RVA: 0x141A120 Offset: 0x1418720 VA: 0x18141A120
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	// RVA: 0x141A460 Offset: 0x1418A60 VA: 0x18141A460
	internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator) { }

	// RVA: 0x141A2F0 Offset: 0x14188F0 VA: 0x18141A2F0
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisible(True)]
	[ReliabilityContract(3, 1)]
	// RVA: 0x141A810 Offset: 0x1418E10 VA: 0x18141A810
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72E400 Offset: 0x72CA00 VA: 0x18072E400
	|-Marshal.StructureToPtr<MatchMakingKeyValuePair_t>
	|-Marshal.StructureToPtr<SteamParamStringArray_t>
	|-Marshal.StructureToPtr<NetworkManager.FFIEvents>
	|-Marshal.StructureToPtr<RelationshipManager.FFIEvents>
	|-Marshal.StructureToPtr<StoreManager.FFIEvents>
	|
	|-RVA: 0x72E7A0 Offset: 0x72CDA0 VA: 0x18072E7A0
	|-Marshal.StructureToPtr<object>
	|
	|-RVA: 0x72E6A0 Offset: 0x72CCA0 VA: 0x18072E6A0
	|-Marshal.StructureToPtr<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x72E360 Offset: 0x72C960 VA: 0x18072E360
	|-Marshal.StructureToPtr<AchievementManager.FFIEvents>
	|-Marshal.StructureToPtr<OverlayManager.FFIEvents>
	|-Marshal.StructureToPtr<UserManager.FFIEvents>
	|-Marshal.StructureToPtr<VoiceManager.FFIEvents>
	|
	|-RVA: 0x72E5F0 Offset: 0x72CBF0 VA: 0x18072E5F0
	|-Marshal.StructureToPtr<ActivityManager.FFIEvents>
	|-Marshal.StructureToPtr<nmZPFrHROjwSJoqMeikFKQsYgJoz.jHrbAPFEJGzDjcUMXSlZXrdJkEwC.pypgrfBmTUiZzsVOZmNBdclitsKNc>
	|
	|-RVA: 0x72E560 Offset: 0x72CB60 VA: 0x18072E560
	|-Marshal.StructureToPtr<ApplicationManager.FFIEvents>
	|-Marshal.StructureToPtr<Discord.FFIEvents>
	|-Marshal.StructureToPtr<ImageManager.FFIEvents>
	|-Marshal.StructureToPtr<StorageManager.FFIEvents>
	|
	|-RVA: 0x72E4A0 Offset: 0x72CAA0 VA: 0x18072E4A0
	|-Marshal.StructureToPtr<LobbyManager.FFIEvents>
	*/

	// RVA: 0x14187F0 Offset: 0x1416DF0 VA: 0x1814187F0
	private static IntPtr BufferToBSTR(char* ptr, int slen) { }

	// RVA: 0x141A820 Offset: 0x1418E20 VA: 0x18141A820
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72E810 Offset: 0x72CE10 VA: 0x18072E810
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0x72E870 Offset: 0x72CE70 VA: 0x18072E870
	|-Marshal.UnsafeAddrOfPinnedArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x141A830 Offset: 0x1418E30 VA: 0x18141A830
	public static void WriteByte(IntPtr ptr, byte val) { }

	// RVA: 0x141A850 Offset: 0x1418E50 VA: 0x18141A850
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	// RVA: 0x141A880 Offset: 0x1418E80 VA: 0x18141A880
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0x141A8D0 Offset: 0x1418ED0 VA: 0x18141A8D0
	public static void WriteInt32(IntPtr ptr, int val) { }

	// RVA: 0x141A910 Offset: 0x1418F10 VA: 0x18141A910
	public static void WriteInt32(IntPtr ptr, int ofs, int val) { }

	// RVA: 0x141A950 Offset: 0x1418F50 VA: 0x18141A950
	public static void WriteInt64(IntPtr ptr, long val) { }

	// RVA: 0x141A990 Offset: 0x1418F90 VA: 0x18141A990
	public static void WriteInt64(IntPtr ptr, int ofs, long val) { }

	// RVA: 0x141A9E0 Offset: 0x1418FE0 VA: 0x18141A9E0
	public static void WriteIntPtr(IntPtr ptr, IntPtr val) { }

	// RVA: 0x1419B50 Offset: 0x1418150 VA: 0x181419B50
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: 0x1419B60 Offset: 0x1418160 VA: 0x181419B60
	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72DA60 Offset: 0x72C060 VA: 0x18072DA60
	|-Marshal.GetFunctionPointerForDelegate<object>
	|
	|-RVA: 0x72D8C0 Offset: 0x72BEC0 VA: 0x18072D8C0
	|-Marshal.GetFunctionPointerForDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x14192C0 Offset: 0x14178C0 VA: 0x1814192C0
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	// RVA: 0x141AD20 Offset: 0x1419320 VA: 0x18141AD20
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(10496, Inherited = False)]
public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 1108
{
	// Fields
	public string MarshalCookie; // 0x10
	[ComVisible(True)]
	public string MarshalType; // 0x18
	[ComVisible(True)]
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44

	// Properties
	public UnmanagedType Value { get; }

	// Methods

	// RVA: 0x1418630 Offset: 0x1416C30 VA: 0x181418630
	public void .ctor(UnmanagedType unmanagedType) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public UnmanagedType get_Value() { }

	// RVA: 0x14185D0 Offset: 0x1416BD0 VA: 0x1814185D0
	internal MarshalAsAttribute Copy() { }
}

// Namespace: System.Runtime.InteropServices
[InterfaceType(1)]
[ComVisible(True)]
[CLSCompliant(False)]
[Guid("03973551-57A1-3900-A2B5-9083E3FF2943")]
public interface _Activator // TypeDefIndex: 1109
{}

// Namespace: System.Runtime.InteropServices
[InterfaceType(0)]
[Guid("17156360-2F1A-384A-BC52-FDE93C215C5B")]
[ComVisible(True)]
[CLSCompliant(False)]
public interface _Assembly // TypeDefIndex: 1110
{}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[CLSCompliant(False)]
[InterfaceType(1)]
[Guid("B42B6AAC-317E-34D5-9FA9-093BB4160C50")]
public interface _AssemblyName // TypeDefIndex: 1111
{}

// Namespace: System.Runtime.InteropServices
[InterfaceType(1)]
[CLSCompliant(False)]
[ComVisible(True)]
[Guid("D002E9BA-D9E3-3749-B1D3-D565A08B13E7")]
public interface _Module // TypeDefIndex: 1112
{}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[CLSCompliant(False)]
[InterfaceType(1)]
[Guid("993634C4-E47A-32CC-BE08-85F567DC27D6")]
public interface _ParameterInfo // TypeDefIndex: 1113
{}

