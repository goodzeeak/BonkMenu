// Namespace: Microsoft.Win32
public static class Registry // TypeDefIndex: 118
{
	// Fields
	public static readonly RegistryKey CurrentUser; // 0x0
	public static readonly RegistryKey LocalMachine; // 0x8
	public static readonly RegistryKey ClassesRoot; // 0x10
	public static readonly RegistryKey Users; // 0x18
	public static readonly RegistryKey PerformanceData; // 0x20
	public static readonly RegistryKey CurrentConfig; // 0x28
	[Obsolete("Use PerformanceData instead")]
	public static readonly RegistryKey DynData; // 0x30

	// Methods

	// RVA: 0x135CA20 Offset: 0x135B020 VA: 0x18135CA20
	private static void .cctor() { }
}

// Namespace: Microsoft.Win32
public enum RegistryHive // TypeDefIndex: 119
{
	// Fields
	public int value__; // 0x0
	public const RegistryHive ClassesRoot = -2147483648;
	public const RegistryHive CurrentUser = -2147483647;
	public const RegistryHive LocalMachine = -2147483646;
	public const RegistryHive Users = -2147483645;
	public const RegistryHive PerformanceData = -2147483644;
	public const RegistryHive CurrentConfig = -2147483643;
	public const RegistryHive DynData = -2147483642;
}

// Namespace: Microsoft.Win32
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 121
{
	// Fields
	internal static readonly IntPtr HKEY_CLASSES_ROOT; // 0x0
	internal static readonly IntPtr HKEY_CURRENT_USER; // 0x8
	internal static readonly IntPtr HKEY_LOCAL_MACHINE; // 0x10
	internal static readonly IntPtr HKEY_USERS; // 0x18
	internal static readonly IntPtr HKEY_PERFORMANCE_DATA; // 0x20
	internal static readonly IntPtr HKEY_CURRENT_CONFIG; // 0x28
	internal static readonly IntPtr HKEY_DYN_DATA; // 0x30
	private static readonly string[] s_hkeyNames; // 0x38
	private SafeRegistryHandle _hkey; // 0x18
	private string _keyName; // 0x20
	private bool _remoteKey; // 0x28
	private RegistryKey.StateFlags _state; // 0x2C
	private RegistryKeyPermissionCheck _checkMode; // 0x30
	private RegistryView _regView; // 0x34

	// Methods

	// RVA: 0x135A220 Offset: 0x1358820 VA: 0x18135A220
	private void ClosePerfDataKey() { }

	// RVA: 0x135BAC0 Offset: 0x135A0C0 VA: 0x18135BAC0
	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view) { }

	// RVA: 0x135B6F0 Offset: 0x1359CF0 VA: 0x18135B6F0
	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure) { }

	// RVA: 0x135B8E0 Offset: 0x1359EE0 VA: 0x18135B8E0
	private int InternalSubKeyCountCore() { }

	// RVA: 0x135AA90 Offset: 0x1359090 VA: 0x18135AA90
	private string[] InternalGetSubKeyNamesCore(int subkeys) { }

	// RVA: 0x135AD50 Offset: 0x1359350 VA: 0x18135AD50
	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand) { }

	// RVA: 0x135C410 Offset: 0x135AA10 VA: 0x18135C410
	private void Win32Error(int errorCode, string str) { }

	// RVA: 0x135A760 Offset: 0x1358D60 VA: 0x18135A760
	private static int GetRegistryKeyAccess(bool isWritable) { }

	// RVA: 0x135C8A0 Offset: 0x135AEA0 VA: 0x18135C8A0
	private void .ctor(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view) { }

	// RVA: 0x135A280 Offset: 0x1358880 VA: 0x18135A280 Slot: 6
	public void Dispose() { }

	// RVA: 0x135BC20 Offset: 0x135A220 VA: 0x18135BC20
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view) { }

	// RVA: 0x135BE10 Offset: 0x135A410 VA: 0x18135BE10
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x135B980 Offset: 0x1359F80 VA: 0x18135B980
	private int InternalSubKeyCount() { }

	// RVA: 0x135A780 Offset: 0x1358D80 VA: 0x18135A780
	public string[] GetSubKeyNames() { }

	// RVA: 0x135A780 Offset: 0x1358D80 VA: 0x18135A780
	private string[] InternalGetSubKeyNames() { }

	// RVA: 0x135A970 Offset: 0x1358F70 VA: 0x18135A970
	public object GetValue(string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x135B640 Offset: 0x1359C40 VA: 0x18135B640
	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity) { }

	// RVA: 0x135BEF0 Offset: 0x135A4F0 VA: 0x18135BEF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x135A430 Offset: 0x1358A30 VA: 0x18135A430
	private static string FixupName(string name) { }

	// RVA: 0x135A630 Offset: 0x1358C30 VA: 0x18135A630
	private static void FixupPath(StringBuilder path) { }

	// RVA: 0x135A3D0 Offset: 0x13589D0 VA: 0x18135A3D0
	private void EnsureNotDisposed() { }

	// RVA: 0x135A910 Offset: 0x1358F10 VA: 0x18135A910
	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable) { }

	// RVA: 0x135BF60 Offset: 0x135A560 VA: 0x18135BF60
	private static void ValidateKeyName(string name) { }

	// RVA: 0x135C3B0 Offset: 0x135A9B0 VA: 0x18135C3B0
	private static void ValidateKeyView(RegistryView view) { }

	// RVA: 0x135BAA0 Offset: 0x135A0A0 VA: 0x18135BAA0
	private bool IsSystemKey() { }

	// RVA: 0x135BA80 Offset: 0x135A080 VA: 0x18135BA80
	private bool IsPerfDataKey() { }

	// RVA: 0x135C5B0 Offset: 0x135ABB0 VA: 0x18135C5B0
	private static void .cctor() { }
}

// Namespace: Microsoft.Win32
public enum RegistryKeyPermissionCheck // TypeDefIndex: 122
{
	// Fields
	public int value__; // 0x0
	public const RegistryKeyPermissionCheck Default = 0;
	public const RegistryKeyPermissionCheck ReadSubTree = 1;
	public const RegistryKeyPermissionCheck ReadWriteSubTree = 2;
}

// Namespace: Microsoft.Win32
[Flags]
public enum RegistryValueOptions // TypeDefIndex: 123
{
	// Fields
	public int value__; // 0x0
	public const RegistryValueOptions None = 0;
	public const RegistryValueOptions DoNotExpandEnvironmentNames = 1;
}

// Namespace: Microsoft.Win32
public enum RegistryView // TypeDefIndex: 124
{
	// Fields
	public int value__; // 0x0
	public const RegistryView Default = 0;
	public const RegistryView Registry64 = 256;
	public const RegistryView Registry32 = 512;
}

// Namespace: Microsoft.Win32
internal static class ThrowHelper // TypeDefIndex: 125
{
	// Methods

	// RVA: 0x136B050 Offset: 0x1369650 VA: 0x18136B050
	internal static void ThrowArgumentException(string msg, string argument) { }

	// RVA: 0x136B0B0 Offset: 0x13696B0 VA: 0x18136B0B0
	internal static void ThrowArgumentNullException(string argument) { }

	// RVA: 0x136B160 Offset: 0x1369760 VA: 0x18136B160
	internal static void ThrowSecurityException(string msg) { }

	// RVA: 0x136B100 Offset: 0x1369700 VA: 0x18136B100
	internal static void ThrowObjectDisposedException(string objectName, string msg) { }
}

// Namespace: Microsoft.Win32
internal static class Win32Native // TypeDefIndex: 126
{
	// Methods

	// RVA: 0x136B1B0 Offset: 0x13697B0 VA: 0x18136B1B0
	public static string GetMessage(int hr) { }

	// RVA: 0x136B200 Offset: 0x1369800 VA: 0x18136B200
	public static int MakeHRFromErrorCode(int errorCode) { }
}

// Namespace: Microsoft.Win32
internal static class NativeMethods // TypeDefIndex: 7392
{
	// Methods

	// RVA: 0x1DD7CB0 Offset: 0x1DD62B0 VA: 0x181DD7CB0
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x1DD7E10 Offset: 0x1DD6410 VA: 0x181DD7E10
	public static IntPtr GetCurrentProcess() { }

	// RVA: 0x1DD7EF0 Offset: 0x1DD64F0 VA: 0x181DD7EF0
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	// RVA: 0x1DD7E20 Offset: 0x1DD6420 VA: 0x181DD7E20
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

	// RVA: 0x1DD7E00 Offset: 0x1DD6400 VA: 0x181DD7E00
	public static int GetCurrentProcessId() { }

	// RVA: 0x1DD7CA0 Offset: 0x1DD62A0 VA: 0x181DD7CA0
	public static bool CloseProcess(IntPtr handle) { }
}

