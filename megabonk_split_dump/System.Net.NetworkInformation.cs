// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties // TypeDefIndex: 7916
{
	// Properties
	public abstract string DomainName { get; }

	// Methods

	// RVA: 0x1DAE110 Offset: 0x1DAC710 VA: 0x181DAE110
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x1DAE110 Offset: 0x1DAC710 VA: 0x181DAE110
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_DomainName();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
public enum NetworkInterfaceComponent // TypeDefIndex: 7917
{
	// Fields
	public int value__; // 0x0
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;
}

// Namespace: System.Net.NetworkInformation
public enum NetBiosNodeType // TypeDefIndex: 7918
{
	// Fields
	public int value__; // 0x0
	public const NetBiosNodeType Unknown = 0;
	public const NetBiosNodeType Broadcast = 1;
	public const NetBiosNodeType Peer2Peer = 2;
	public const NetBiosNodeType Mixed = 4;
	public const NetBiosNodeType Hybrid = 8;
}

// Namespace: System.Net.NetworkInformation
internal static class IPGlobalPropertiesFactoryPal // TypeDefIndex: 7919
{
	// Methods

	// RVA: 0x1DAE110 Offset: 0x1DAC710 VA: 0x181DAE110
	public static IPGlobalProperties Create() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32IPGlobalProperties : IPGlobalProperties // TypeDefIndex: 7920
{
	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x1DC6340 Offset: 0x1DC4940 VA: 0x181DC6340 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal static class Win32IPGlobalPropertiesFactoryPal // TypeDefIndex: 7921
{
	// Methods

	// RVA: 0x1DC62F0 Offset: 0x1DC48F0 VA: 0x181DC62F0
	public static IPGlobalProperties Create() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32NetworkInterface // TypeDefIndex: 7922
{
	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0x1DC6560 Offset: 0x1DC4B60 VA: 0x181DC6560
	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	// RVA: 0x1DC65F0 Offset: 0x1DC4BF0 VA: 0x181DC65F0
	public static Win32_FIXED_INFO get_FixedInfo() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_FIXED_INFO // TypeDefIndex: 7923
{
	// Fields
	public string HostName; // 0x0
	public string DomainName; // 0x8
	public IntPtr CurrentDnsServer; // 0x10
	public Win32_IP_ADDR_STRING DnsServerList; // 0x18
	public NetBiosNodeType NodeType; // 0x38
	public string ScopeId; // 0x40
	public uint EnableRouting; // 0x48
	public uint EnableProxy; // 0x4C
	public uint EnableDns; // 0x50
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADDR_STRING // TypeDefIndex: 7924
{
	// Fields
	public IntPtr Next; // 0x0
	public string IpAddress; // 0x8
	public string IpMask; // 0x10
	public uint Context; // 0x18
}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal // TypeDefIndex: 7925
{
	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static IPGlobalProperties Create() { }
}

