// Namespace: Internal.Cryptography
[Extension]
internal static class Helpers // TypeDefIndex: 142
{
	// Methods

	[Extension]
	// RVA: 0x1350880 Offset: 0x134EE80 VA: 0x181350880
	public static byte[] CloneByteArray(byte[] src) { }

	[Extension]
	// RVA: 0x1350920 Offset: 0x134EF20 VA: 0x181350920
	public static char[] ToHexArrayUpper(byte[] bytes) { }

	[Extension]
	// RVA: 0x1350A30 Offset: 0x134F030 VA: 0x181350A30
	public static string ToHexStringUpper(byte[] bytes) { }

	// RVA: 0x1350900 Offset: 0x134EF00 VA: 0x181350900
	private static char NibbleToHex(byte b) { }
}

// Namespace: Internal.Cryptography
internal static class OidLookup // TypeDefIndex: 7395
{
	// Fields
	private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName; // 0x0
	private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid; // 0x8
	private static readonly Dictionary<string, string> s_friendlyNameToOid; // 0x10
	private static readonly Dictionary<string, string> s_oidToFriendlyName; // 0x18
	private static readonly Dictionary<string, string> s_compatOids; // 0x20

	// Methods

	// RVA: 0x1DD86B0 Offset: 0x1DD6CB0 VA: 0x181DD86B0
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1DD8920 Offset: 0x1DD6F20 VA: 0x181DD8920
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x1DD8360 Offset: 0x1DD6960 VA: 0x181DD8360
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1DD8010 Offset: 0x1DD6610 VA: 0x181DD8010
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1DD8B60 Offset: 0x1DD7160 VA: 0x181DD8B60
	private static void .cctor() { }
}

