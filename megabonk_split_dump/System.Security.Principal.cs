// Namespace: System.Security.Principal
public interface IIdentity // TypeDefIndex: 814
{
	// Properties
	public abstract string Name { get; }
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_AuthenticationType();
}

// Namespace: System.Security.Principal
public interface IPrincipal // TypeDefIndex: 815
{}

// Namespace: System.Security.Principal
public enum TokenImpersonationLevel // TypeDefIndex: 816
{
	// Fields
	public int value__; // 0x0
	public const TokenImpersonationLevel None = 0;
	public const TokenImpersonationLevel Anonymous = 1;
	public const TokenImpersonationLevel Identification = 2;
	public const TokenImpersonationLevel Impersonation = 3;
	public const TokenImpersonationLevel Delegation = 4;
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public enum WindowsAccountType // TypeDefIndex: 817
{
	// Fields
	public int value__; // 0x0
	public const WindowsAccountType Normal = 0;
	public const WindowsAccountType Guest = 1;
	public const WindowsAccountType System = 2;
	public const WindowsAccountType Anonymous = 3;
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 818
{
	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x13D5800 Offset: 0x13D3E00 VA: 0x1813D5800
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x13D59D0 Offset: 0x13D3FD0 VA: 0x1813D59D0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x13D4EF0 Offset: 0x13D34F0 VA: 0x1813D4EF0 Slot: 14
	public void Dispose() { }

	// RVA: 0x13D4F10 Offset: 0x13D3510 VA: 0x1813D4F10
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x13D5130 Offset: 0x13D3730 VA: 0x1813D5130 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x13D5A30 Offset: 0x13D4030 VA: 0x1813D5A30 Slot: 8
	public override string get_Name() { }

	// RVA: 0x13D5350 Offset: 0x13D3950 VA: 0x1813D5350 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x13D5690 Offset: 0x13D3C90 VA: 0x1813D5690 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13D51F0 Offset: 0x13D37F0 VA: 0x1813D51F0
	private void SetToken(IntPtr token) { }

	// RVA: 0x13D4F00 Offset: 0x13D3500 VA: 0x1813D4F00
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x13D5120 Offset: 0x13D3720 VA: 0x1813D5120
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x13D57C0 Offset: 0x13D3DC0 VA: 0x1813D57C0
	private static void .cctor() { }
}

// Namespace: System.Security.Principal
[ComVisible(True)]
public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 819
{
	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x13D5C60 Offset: 0x13D4260 VA: 0x1813D5C60
	internal void .ctor(IntPtr token) { }

	[ComVisible(False)]
	// RVA: 0x13D5AC0 Offset: 0x13D40C0 VA: 0x1813D5AC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x13D5BB0 Offset: 0x13D41B0 VA: 0x1813D5BB0
	public void Undo() { }

	// RVA: 0x13D5AB0 Offset: 0x13D40B0 VA: 0x1813D5AB0
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x13D5B80 Offset: 0x13D4180 VA: 0x1813D5B80
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x13D5BA0 Offset: 0x13D41A0 VA: 0x1813D5BA0
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x13D5B90 Offset: 0x13D4190 VA: 0x1813D5B90
	private static bool RevertToSelf() { }
}

