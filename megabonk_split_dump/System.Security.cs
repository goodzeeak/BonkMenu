// Namespace: System.Security
public interface IPermission : ISecurityEncodable // TypeDefIndex: 702
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Demand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSubsetOf(IPermission target);
}

// Namespace: System.Security
public interface ISecurityEncodable // TypeDefIndex: 703
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SecurityElement ToXml();
}

// Namespace: System.Security
[Serializable]
public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 704
{
	// Methods

	// RVA: 0x13968D0 Offset: 0x1394ED0 VA: 0x1813968D0
	public void .ctor() { }

	// RVA: 0x13968D0 Offset: 0x1394ED0 VA: 0x1813968D0
	public void .ctor(int lineNumber) { }

	// RVA: 0x13968D0 Offset: 0x1394ED0 VA: 0x1813968D0
	public void .ctor(int lineNumber, string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security
[Serializable]
internal sealed class SecurityDocument // TypeDefIndex: 705
{
	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x138CAE0 Offset: 0x138B0E0 VA: 0x18138CAE0
	public void .ctor(int numData) { }

	// RVA: 0x138C7B0 Offset: 0x138ADB0 VA: 0x18138C7B0
	public void GuaranteeSize(int size) { }

	// RVA: 0x138C040 Offset: 0x138A640 VA: 0x18138C040
	public void AddString(string str, ref int position) { }

	// RVA: 0x138C2F0 Offset: 0x138A8F0 VA: 0x18138C2F0
	public void AppendString(string str, ref int position) { }

	// RVA: 0x138C390 Offset: 0x138A990 VA: 0x18138C390
	public static int EncodedStringSize(string str) { }

	// RVA: 0x138C400 Offset: 0x138AA00 VA: 0x18138C400
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x138C200 Offset: 0x138A800 VA: 0x18138C200
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x138C3D0 Offset: 0x138A9D0 VA: 0x18138C3D0
	public SecurityElement GetRootElement() { }

	// RVA: 0x138C3B0 Offset: 0x138A9B0 VA: 0x18138C3B0
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x138C860 Offset: 0x138AE60 VA: 0x18138C860
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }
}

// Namespace: System.Security
[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
[Serializable]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 706
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	[Conditional("MONO_FEATURE_CAS")]
	// RVA: 0x137F320 Offset: 0x137D920 VA: 0x18137F320 Slot: 7
	public void Demand() { }

	[ComVisible(False)]
	// RVA: 0x137F350 Offset: 0x137D950 VA: 0x18137F350 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x137F490 Offset: 0x137DA90 VA: 0x18137F490 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x137F260 Offset: 0x137D860 VA: 0x18137F260
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	private void System.Security.IPermission.Demand() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 707
{
	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x1386C70 Offset: 0x1385270 VA: 0x181386C70
	internal void .ctor() { }

	// RVA: 0x1386D10 Offset: 0x1385310 VA: 0x181386D10
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x1386C60 Offset: 0x1385260 VA: 0x181386C60
	public void .ctor(string name) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Name() { }

	// RVA: 0x1386EF0 Offset: 0x13854F0 VA: 0x181386EF0
	public void set_Name(string value) { }

	// RVA: 0x1386BC0 Offset: 0x13851C0 VA: 0x181386BC0 Slot: 13
	public override SecurityElement ToXml() { }

	[ComVisible(False)]
	// RVA: 0x1386AC0 Offset: 0x13850C0 VA: 0x181386AC0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x1386B40 Offset: 0x1385140 VA: 0x181386B40 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Security
[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
[Serializable]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 708
{
	// Fields
	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x138B700 Offset: 0x1389D00 VA: 0x18138B700
	internal void .ctor() { }

	// RVA: 0x138B770 Offset: 0x1389D70 VA: 0x18138B770
	public void .ctor(PermissionState state) { }

	// RVA: 0x138B660 Offset: 0x1389C60 VA: 0x18138B660
	internal void .ctor(IPermission perm) { }

	// RVA: 0x138A720 Offset: 0x1388D20 VA: 0x18138A720 Slot: 11
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x138A8B0 Offset: 0x1388EB0 VA: 0x18138A8B0 Slot: 12
	public void Demand() { }

	// RVA: 0x138A6A0 Offset: 0x1388CA0 VA: 0x18138A6A0
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x138AC80 Offset: 0x1389280 VA: 0x18138AC80 Slot: 9
	public IEnumerator GetEnumerator() { }

	// RVA: 0x138AD00 Offset: 0x1389300 VA: 0x18138AD00
	public bool IsEmpty() { }

	// RVA: 0x95D540 Offset: 0x95BB40 VA: 0x18095D540
	public bool IsUnrestricted() { }

	// RVA: 0x138AFD0 Offset: 0x13895D0 VA: 0x18138AFD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x138B010 Offset: 0x1389610 VA: 0x18138B010 Slot: 13
	public virtual SecurityElement ToXml() { }

	// RVA: 0x138B880 Offset: 0x1389E80 VA: 0x18138B880 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x138B8B0 Offset: 0x1389EB0 VA: 0x18138B8B0 Slot: 15
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 16
	public virtual object get_SyncRoot() { }

	[MonoTODO("may not be required")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisible(False)]
	// RVA: 0x138AAB0 Offset: 0x13890B0 VA: 0x18138AAB0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x138ACB0 Offset: 0x13892B0 VA: 0x18138ACB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x138B4B0 Offset: 0x1389AB0 VA: 0x18138B4B0
	private static void .cctor() { }
}

// Namespace: System.Security
[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable // TypeDefIndex: 709
{
	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x138BD00 Offset: 0x138A300 VA: 0x18138BD00
	public void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x138BB90 Offset: 0x138A190 VA: 0x18138BB90
	public void .ctor(char* value, int length) { }

	// RVA: 0x138BD60 Offset: 0x138A360 VA: 0x18138BD60
	public int get_Length() { }

	// RVA: 0x138BA80 Offset: 0x138A080 VA: 0x18138BA80 Slot: 4
	public void Dispose() { }

	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	private void Encrypt() { }

	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	private void Decrypt() { }

	// RVA: 0x138B8E0 Offset: 0x1389EE0 VA: 0x18138B8E0
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x138BAE0 Offset: 0x138A0E0 VA: 0x18138BAE0
	internal byte[] GetBuffer() { }
}

// Namespace: System.Security
internal enum SecurityElementType // TypeDefIndex: 710
{
	// Fields
	public int value__; // 0x0
	public const SecurityElementType Regular = 0;
	public const SecurityElementType Format = 1;
	public const SecurityElementType Comment = 2;
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class SecurityElement // TypeDefIndex: 712
{
	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x138E1D0 Offset: 0x138C7D0 VA: 0x18138E1D0
	public void .ctor(string tag) { }

	// RVA: 0x138E1E0 Offset: 0x138C7E0 VA: 0x18138E1E0
	public void .ctor(string tag, string text) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public ArrayList get_Children() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Tag() { }

	// RVA: 0x138E4B0 Offset: 0x138CAB0 VA: 0x18138E4B0
	public void set_Text(string value) { }

	// RVA: 0x138CB40 Offset: 0x138B140 VA: 0x18138CB40
	public void AddAttribute(string name, string value) { }

	// RVA: 0x138CD30 Offset: 0x138B330 VA: 0x18138CD30
	public void AddChild(SecurityElement child) { }

	// RVA: 0x138CE20 Offset: 0x138B420 VA: 0x18138CE20
	public static string Escape(string str) { }

	// RVA: 0x138DE20 Offset: 0x138C420 VA: 0x18138DE20
	private static string Unescape(string str) { }

	// RVA: 0x138D250 Offset: 0x138B850 VA: 0x18138D250
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x138D2D0 Offset: 0x138B8D0 VA: 0x18138D2D0
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x138D350 Offset: 0x138B950 VA: 0x18138D350
	public static bool IsValidTag(string tag) { }

	// RVA: 0x138D3D0 Offset: 0x138B9D0 VA: 0x18138D3D0
	public static bool IsValidText(string text) { }

	// RVA: 0x138D450 Offset: 0x138BA50 VA: 0x18138D450
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x138D7A0 Offset: 0x138BDA0 VA: 0x18138D7A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x138D830 Offset: 0x138BE30 VA: 0x18138D830
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x138D040 Offset: 0x138B640 VA: 0x18138D040
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_m_strText(string value) { }

	// RVA: 0x138D5B0 Offset: 0x138BBB0 VA: 0x18138D5B0
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x138DFB0 Offset: 0x138C5B0 VA: 0x18138DFB0
	private static void .cctor() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public class SecurityException : SystemException // TypeDefIndex: 713
{
	// Fields
	private string permissionState; // 0x90

	// Methods

	// RVA: 0x138E6E0 Offset: 0x138CCE0 VA: 0x18138E6E0
	public void .ctor() { }

	// RVA: 0x138E6A0 Offset: 0x138CCA0 VA: 0x18138E6A0
	public void .ctor(string message) { }

	// RVA: 0x138E730 Offset: 0x138CD30 VA: 0x18138E730
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x138E6C0 Offset: 0x138CCC0 VA: 0x18138E6C0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x138E600 Offset: 0x138CC00 VA: 0x18138E600 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x138E690 Offset: 0x138CC90 VA: 0x18138E690 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Security
[ComVisible(True)]
public static class SecurityManager // TypeDefIndex: 714
{
	// Properties
	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool get_SecurityEnabled() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal static void EnsureElevatedPermissions() { }
}

