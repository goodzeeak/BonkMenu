// Namespace: System.Net.Cache
internal abstract class RequestCache // TypeDefIndex: 7928
{
	// Fields
	internal static readonly char[] LineSplits; // 0x0

	// Methods

	// RVA: 0x1DB1960 Offset: 0x1DAFF60 VA: 0x181DB1960
	private static void .cctor() { }
}

// Namespace: System.Net.Cache
internal class RequestCacheValidator // TypeDefIndex: 7929
{
	// Methods

	// RVA: 0x1DB1920 Offset: 0x1DAFF20 VA: 0x181DB1920
	public object CreateValidator() { }
}

// Namespace: System.Net.Cache
internal class RequestCacheBinding // TypeDefIndex: 7930
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Properties
	internal RequestCache Cache { get; }
	internal RequestCacheValidator Validator { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal RequestCache get_Cache() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal RequestCacheValidator get_Validator() { }
}

// Namespace: System.Net.Cache
public enum RequestCacheLevel // TypeDefIndex: 7931
{
	// Fields
	public int value__; // 0x0
	public const RequestCacheLevel Default = 0;
	public const RequestCacheLevel BypassCache = 1;
	public const RequestCacheLevel CacheOnly = 2;
	public const RequestCacheLevel CacheIfAvailable = 3;
	public const RequestCacheLevel Revalidate = 4;
	public const RequestCacheLevel Reload = 5;
	public const RequestCacheLevel NoCacheNoStore = 6;
}

// Namespace: System.Net.Cache
public class RequestCachePolicy // TypeDefIndex: 7932
{
	// Fields
	private RequestCacheLevel m_Level; // 0x10

	// Properties
	public RequestCacheLevel Level { get; }

	// Methods

	// RVA: 0x1DB1850 Offset: 0x1DAFE50 VA: 0x181DB1850
	public void .ctor(RequestCacheLevel level) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public RequestCacheLevel get_Level() { }

	// RVA: 0x1DB17D0 Offset: 0x1DAFDD0 VA: 0x181DB17D0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol // TypeDefIndex: 7933
{
	// Methods

	// RVA: 0x1DB18D0 Offset: 0x1DAFED0 VA: 0x181DB18D0
	public void .ctor(object arg1, object arg2) { }
}

