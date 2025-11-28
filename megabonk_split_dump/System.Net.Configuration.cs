// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal // TypeDefIndex: 7926
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Properties
	internal static object ClassSyncObject { get; }
	internal IWebProxy WebProxy { get; }

	// Methods

	// RVA: 0x1DADDA0 Offset: 0x1DAC3A0 VA: 0x181DADDA0
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x1DADDA0 Offset: 0x1DAC3A0 VA: 0x181DADDA0
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x1DADF20 Offset: 0x1DAC520 VA: 0x181DADF20
	internal static object get_ClassSyncObject() { }

	// RVA: 0x1DADDB0 Offset: 0x1DAC3B0 VA: 0x181DADDB0
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal // TypeDefIndex: 7927
{
	// Fields
	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14

	// Properties
	internal static SettingsSectionInternal Section { get; }
	internal bool Ipv6Enabled { get; }

	// Methods

	// RVA: 0x1DB2460 Offset: 0x1DB0A60 VA: 0x181DB2460
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x17CD420 Offset: 0x17CBA20 VA: 0x1817CD420
	public void .ctor() { }

	// RVA: 0x1DB23E0 Offset: 0x1DB09E0 VA: 0x181DB23E0
	private static void .cctor() { }
}

// Namespace: System.Net.Configuration
public sealed class BypassElement : ConfigurationElement // TypeDefIndex: 7989
{}

// Namespace: System.Net.Configuration
[DefaultMember("Item")]
[ConfigurationCollection(typeof(BypassElement))]
public sealed class BypassElementCollection : ConfigurationElementCollection // TypeDefIndex: 7990
{
	// Methods

	// RVA: 0x1DADCE0 Offset: 0x1DAC2E0 VA: 0x181DADCE0
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement : ConfigurationElement // TypeDefIndex: 7991
{}

// Namespace: System.Net.Configuration
[DefaultMember("Item")]
[ConfigurationCollection(typeof(ConnectionManagementElement))]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 7992
{
	// Methods

	// RVA: 0x1DADD10 Offset: 0x1DAC310 VA: 0x181DADD10
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 7993
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DADD40 Offset: 0x1DAC340 VA: 0x181DADD40
	public void .ctor() { }

	// RVA: 0x1DADD70 Offset: 0x1DAC370 VA: 0x181DADD70 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection : ConfigurationSection // TypeDefIndex: 7994
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DADFF0 Offset: 0x1DAC5F0 VA: 0x181DADFF0
	public void .ctor() { }

	// RVA: 0x1DAE020 Offset: 0x1DAC620 VA: 0x181DAE020 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1DADFC0 Offset: 0x1DAC5C0 VA: 0x181DADFC0 Slot: 6
	protected override void Reset(ConfigurationElement parentElement) { }
}

// Namespace: System.Net.Configuration
public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 7995
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DB1650 Offset: 0x1DAFC50 VA: 0x181DB1650
	public void .ctor() { }

	// RVA: 0x1DB1680 Offset: 0x1DAFC80 VA: 0x181DB1680 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement : ConfigurationElement // TypeDefIndex: 7996
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DAE0B0 Offset: 0x1DAC6B0 VA: 0x181DAE0B0
	public void .ctor() { }

	// RVA: 0x1DAE0E0 Offset: 0x1DAC6E0 VA: 0x181DAE0E0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element : ConfigurationElement // TypeDefIndex: 7997
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DAE1E0 Offset: 0x1DAC7E0 VA: 0x181DAE1E0
	public void .ctor() { }

	// RVA: 0x1DAE210 Offset: 0x1DAC810 VA: 0x181DAE210 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 7998
{
	// Methods

	// RVA: 0x1DAE360 Offset: 0x1DAC960 VA: 0x181DAE360
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class SettingsSection : ConfigurationSection // TypeDefIndex: 7999
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DB24B0 Offset: 0x1DB0AB0 VA: 0x181DB24B0
	public void .ctor() { }

	// RVA: 0x1DB24E0 Offset: 0x1DB0AE0 VA: 0x181DB24E0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement : ConfigurationElement // TypeDefIndex: 8000
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DB15F0 Offset: 0x1DAFBF0 VA: 0x181DB15F0
	public void .ctor() { }

	// RVA: 0x1DB1620 Offset: 0x1DAFC20 VA: 0x181DB1620 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement : ConfigurationElement // TypeDefIndex: 8001
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DB2380 Offset: 0x1DB0980 VA: 0x181DB2380
	public void .ctor() { }

	// RVA: 0x1DB23B0 Offset: 0x1DB09B0 VA: 0x181DB23B0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class SocketElement : ConfigurationElement // TypeDefIndex: 8002
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DB2EB0 Offset: 0x1DB14B0 VA: 0x181DB2EB0
	public void .ctor() { }

	// RVA: 0x1DB2EE0 Offset: 0x1DB14E0 VA: 0x181DB2EE0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement : ConfigurationElement // TypeDefIndex: 8003
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DC6200 Offset: 0x1DC4800 VA: 0x181DC6200
	public void .ctor() { }

	// RVA: 0x1DC6230 Offset: 0x1DC4830 VA: 0x181DC6230 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection : ConfigurationSection // TypeDefIndex: 8004
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1DC6290 Offset: 0x1DC4890 VA: 0x181DC6290
	public void .ctor() { }

	// RVA: 0x1DC62C0 Offset: 0x1DC48C0 VA: 0x181DC62C0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
[DefaultMember("Item")]
[ConfigurationCollection(typeof(WebRequestModuleElement))]
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection // TypeDefIndex: 8005
{
	// Methods

	// RVA: 0x1DC6260 Offset: 0x1DC4860 VA: 0x181DC6260
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement : ConfigurationElement // TypeDefIndex: 8006
{}

