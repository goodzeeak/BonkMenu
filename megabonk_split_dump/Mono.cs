// Namespace: Mono
[Flags]
internal enum CertificateImportFlags // TypeDefIndex: 42
{
	// Fields
	public int value__; // 0x0
	public const CertificateImportFlags None = 0;
	public const CertificateImportFlags DisableNativeBackend = 1;
	public const CertificateImportFlags DisableAutomaticFallback = 2;
}

// Namespace: Mono
internal static class DependencyInjector // TypeDefIndex: 43
{
	// Fields
	private static object locker; // 0x0
	private static ISystemDependencyProvider systemDependency; // 0x8

	// Properties
	internal static ISystemDependencyProvider SystemProvider { get; }

	// Methods

	// RVA: 0x1338670 Offset: 0x1336C70 VA: 0x181338670
	internal static ISystemDependencyProvider get_SystemProvider() { }

	// RVA: 0x1338460 Offset: 0x1336A60 VA: 0x181338460
	internal static void Register(ISystemDependencyProvider provider) { }

	// RVA: 0x1338330 Offset: 0x1336930 VA: 0x181338330
	private static ISystemDependencyProvider ReflectionLoad() { }

	// RVA: 0x13385F0 Offset: 0x1336BF0 VA: 0x1813385F0
	private static void .cctor() { }
}

// Namespace: Mono
internal interface ISystemCertificateProvider // TypeDefIndex: 44
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract X509CertificateImpl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = 0);
}

// Namespace: Mono
internal interface ISystemDependencyProvider // TypeDefIndex: 45
{
	// Properties
	public abstract ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISystemCertificateProvider get_CertificateProvider();
}

// Namespace: Mono
public static class Runtime // TypeDefIndex: 46
{
	// Fields
	private static object dump; // 0x0

	// Methods

	// RVA: 0x133DD10 Offset: 0x133C310 VA: 0x18133DD10
	private static void .cctor() { }
}

// Namespace: Mono
internal struct RuntimeClassHandle // TypeDefIndex: 47
{
	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x133D590 Offset: 0x133BB90 VA: 0x18133D590
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x133D450 Offset: 0x133BA50 VA: 0x18133D450 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x133D540 Offset: 0x133BB40 VA: 0x18133D540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x133D570 Offset: 0x133BB70 VA: 0x18133D570
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x133D580 Offset: 0x133BB80 VA: 0x18133D580
	internal RuntimeTypeHandle GetTypeHandle() { }
}

// Namespace: Mono
internal struct RuntimeRemoteClassHandle // TypeDefIndex: 48
{
	// Fields
	private RuntimeStructs.RemoteClass* value; // 0x0

	// Properties
	internal RuntimeClassHandle ProxyClass { get; }

	// Methods

	// RVA: 0x133DCF0 Offset: 0x133C2F0 VA: 0x18133DCF0
	internal RuntimeClassHandle get_ProxyClass() { }
}

// Namespace: Mono
internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 49
{
	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x133D590 Offset: 0x133BB90 VA: 0x18133D590
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x133D910 Offset: 0x133BF10 VA: 0x18133D910
	internal Type[] get_Constraints() { }

	// RVA: 0x133D8F0 Offset: 0x133BEF0 VA: 0x18133D8F0
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x133D7B0 Offset: 0x133BDB0 VA: 0x18133D7B0
	private Type[] GetConstraints() { }

	// RVA: 0x133D780 Offset: 0x133BD80 VA: 0x18133D780
	private int GetConstraintsCount() { }
}

// Namespace: Mono
internal struct RuntimeEventHandle // TypeDefIndex: 50
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	internal void .ctor(IntPtr v) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public IntPtr get_Value() { }

	// RVA: 0x133D5B0 Offset: 0x133BBB0 VA: 0x18133D5B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono
internal struct RuntimePropertyHandle // TypeDefIndex: 51
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	internal void .ctor(IntPtr v) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public IntPtr get_Value() { }

	// RVA: 0x133DC00 Offset: 0x133C200 VA: 0x18133DC00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono
[DefaultMember("Item")]
internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 52
{
	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x133D590 Offset: 0x133BB90 VA: 0x18133D590
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x133D760 Offset: 0x133BD60 VA: 0x18133D760
	internal int get_Length() { }

	// RVA: 0x133D750 Offset: 0x133BD50 VA: 0x18133D750
	internal IntPtr get_Item(int i) { }

	// RVA: 0x133D6D0 Offset: 0x133BCD0 VA: 0x18133D6D0
	internal IntPtr Lookup(int i) { }

	// RVA: 0x133D6C0 Offset: 0x133BCC0 VA: 0x18133D6C0
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x133D6A0 Offset: 0x133BCA0 VA: 0x18133D6A0
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }
}

// Namespace: Mono
internal static class RuntimeMarshal // TypeDefIndex: 53
{
	// Methods

	// RVA: 0x133DB00 Offset: 0x133C100 VA: 0x18133DB00
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x133DAD0 Offset: 0x133C0D0 VA: 0x18133DAD0
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x133DA40 Offset: 0x133C040 VA: 0x18133DA40
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x133D940 Offset: 0x133BF40 VA: 0x18133D940
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x133D920 Offset: 0x133BF20 VA: 0x18133D920
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x133DAC0 Offset: 0x133C0C0 VA: 0x18133DAC0
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }
}

// Namespace: Mono
internal static class RuntimeStructs // TypeDefIndex: 58
{}

// Namespace: Mono
internal struct MonoAssemblyName // TypeDefIndex: 60
{
	// Fields
	internal IntPtr name; // 0x0
	internal IntPtr culture; // 0x8
	internal IntPtr hash_value; // 0x10
	internal IntPtr public_key; // 0x18
	[FixedBuffer(typeof(byte), 17)]
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; // 0x20
	internal uint hash_alg; // 0x34
	internal uint hash_len; // 0x38
	internal uint flags; // 0x3C
	internal ushort major; // 0x40
	internal ushort minor; // 0x42
	internal ushort build; // 0x44
	internal ushort revision; // 0x46
	internal ushort arch; // 0x48
}

// Namespace: Mono
internal struct ValueTuple // TypeDefIndex: 61
{}

// Namespace: Mono
internal struct ValueTuple<T1> // TypeDefIndex: 62
{
	// Fields
	public T1 Item1; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2> // TypeDefIndex: 63
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3> // TypeDefIndex: 64
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3, T4> // TypeDefIndex: 65
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3, T4, T5> // TypeDefIndex: 66
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
}

// Namespace: Mono
[DefaultMember("Item")]
internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 67
{
	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x133D590 Offset: 0x133BB90 VA: 0x18133D590
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x133D6A0 Offset: 0x133BCA0 VA: 0x18133D6A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x133D760 Offset: 0x133BD60 VA: 0x18133D760
	internal int get_Length() { }

	// RVA: 0x133D750 Offset: 0x133BD50 VA: 0x18133D750
	internal IntPtr get_Item(int i) { }
}

// Namespace: Mono
internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 68
{
	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x133E030 Offset: 0x133C630 VA: 0x18133E030
	private static IntPtr StringToUtf8_icall(ref string str) { }

	// RVA: 0x133E040 Offset: 0x133C640 VA: 0x18133E040
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x133E020 Offset: 0x133C620 VA: 0x18133E020
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x133E060 Offset: 0x133C660 VA: 0x18133E060
	public void .ctor(string str) { }

	// RVA: 0x133E080 Offset: 0x133C680 VA: 0x18133E080
	public IntPtr get_Value() { }

	// RVA: 0x133DFF0 Offset: 0x133C5F0 VA: 0x18133DFF0 Slot: 4
	public void Dispose() { }
}

// Namespace: Mono
internal class SystemCertificateProvider : ISystemCertificateProvider // TypeDefIndex: 7224
{
	// Fields
	private static MonoTlsProvider provider; // 0x0
	private static int initialized; // 0x8
	private static X509PalImpl x509pal; // 0x10
	private static object syncRoot; // 0x18

	// Properties
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x1A83240 Offset: 0x1A81840 VA: 0x181A83240
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0x1A830A0 Offset: 0x1A816A0 VA: 0x181A830A0
	private static void EnsureInitialized() { }

	// RVA: 0x1A83880 Offset: 0x1A81E80 VA: 0x181A83880
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x1A83460 Offset: 0x1A81A60 VA: 0x181A83460 Slot: 4
	public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x1A83740 Offset: 0x1A81D40 VA: 0x181A83740 Slot: 5
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0x1A83500 Offset: 0x1A81B00 VA: 0x181A83500
	public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x1A835C0 Offset: 0x1A81BC0 VA: 0x181A835C0 Slot: 6
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0x1A835C0 Offset: 0x1A81BC0 VA: 0x181A835C0
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1A83800 Offset: 0x1A81E00 VA: 0x181A83800
	private static void .cctor() { }
}

// Namespace: Mono
internal class SystemDependencyProvider : ISystemDependencyProvider // TypeDefIndex: 7225
{
	// Fields
	private static SystemDependencyProvider instance; // 0x0
	private static object syncRoot; // 0x8
	[CompilerGenerated]
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; // 0x10

	// Properties
	public static SystemDependencyProvider Instance { get; }
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider { get; }
	public SystemCertificateProvider CertificateProvider { get; }
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x1A83C20 Offset: 0x1A82220 VA: 0x181A83C20
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0x1A83930 Offset: 0x1A81F30 VA: 0x181A83930
	internal static void Initialize() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x1A83C80 Offset: 0x1A82280 VA: 0x181A83C80
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x1A83B80 Offset: 0x1A82180 VA: 0x181A83B80
	private void .ctor() { }

	// RVA: 0x1A83B00 Offset: 0x1A82100 VA: 0x181A83B00
	private static void .cctor() { }
}

// Namespace: Mono
internal static class X509Pal // TypeDefIndex: 7226
{
	// Properties
	public static X509PalImpl Instance { get; }

	// Methods

	// RVA: 0x1A8BCC0 Offset: 0x1A8A2C0 VA: 0x181A8BCC0
	public static X509PalImpl get_Instance() { }
}

// Namespace: Mono
internal class X509PalImplMono : X509PalImpl // TypeDefIndex: 7227
{
	// Methods

	// RVA: 0x1A8B410 Offset: 0x1A89A10 VA: 0x181A8B410 Slot: 4
	public override X509CertificateImpl Import(byte[] data) { }

	// RVA: 0x1A8B400 Offset: 0x1A89A00 VA: 0x181A8B400 Slot: 5
	public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public override X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0x1A8B420 Offset: 0x1A89A20 VA: 0x181A8B420
	public void .ctor() { }
}

// Namespace: Mono
internal abstract class X509PalImpl // TypeDefIndex: 7228
{
	// Fields
	private static byte[] signedData; // 0x0

	// Properties
	public bool SupportsLegacyBasicConstraintsExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract X509CertificateImpl Import(byte[] data);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509Certificate2Impl Import(X509Certificate cert);

	// RVA: 0x1A8BB10 Offset: 0x1A8A110 VA: 0x181A8BB10
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x1A8B470 Offset: 0x1A89A70 VA: 0x181A8B470
	protected static byte[] ConvertData(byte[] data) { }

	// RVA: 0x1A8B950 Offset: 0x1A89F50 VA: 0x181A8B950
	internal X509Certificate2Impl ImportFallback(byte[] data) { }

	// RVA: 0x1A8BA90 Offset: 0x1A8A090 VA: 0x181A8BA90
	internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0x1A8B630 Offset: 0x1A89C30 VA: 0x181A8B630
	public X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1A8BC30 Offset: 0x1A8A230 VA: 0x181A8BC30
	private static void .cctor() { }
}

