// Namespace: System.Resources
public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 1191
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionaryEnumerator GetEnumerator();
}

// Namespace: System.Resources
[Serializable]
public class MissingManifestResourceException : SystemException // TypeDefIndex: 1192
{
	// Methods

	// RVA: 0x141B0E0 Offset: 0x14196E0 VA: 0x18141B0E0
	public void .ctor() { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Resources
[Usage(1, AllowMultiple = False)]
public sealed class NeutralResourcesLanguageAttribute : Attribute // TypeDefIndex: 1193
{
	// Fields
	[CompilerGenerated]
	private readonly string <CultureName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly UltimateResourceFallbackLocation <Location>k__BackingField; // 0x18

	// Properties
	public string CultureName { get; }
	public UltimateResourceFallbackLocation Location { get; }

	// Methods

	// RVA: 0x141B640 Offset: 0x1419C40 VA: 0x18141B640
	public void .ctor(string cultureName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_CultureName() { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public UltimateResourceFallbackLocation get_Location() { }
}

// Namespace: System.Resources
internal enum ResourceTypeCode // TypeDefIndex: 1194
{
	// Fields
	public int value__; // 0x0
	public const ResourceTypeCode Null = 0;
	public const ResourceTypeCode String = 1;
	public const ResourceTypeCode Boolean = 2;
	public const ResourceTypeCode Char = 3;
	public const ResourceTypeCode Byte = 4;
	public const ResourceTypeCode SByte = 5;
	public const ResourceTypeCode Int16 = 6;
	public const ResourceTypeCode UInt16 = 7;
	public const ResourceTypeCode Int32 = 8;
	public const ResourceTypeCode UInt32 = 9;
	public const ResourceTypeCode Int64 = 10;
	public const ResourceTypeCode UInt64 = 11;
	public const ResourceTypeCode Single = 12;
	public const ResourceTypeCode Double = 13;
	public const ResourceTypeCode Decimal = 14;
	public const ResourceTypeCode DateTime = 15;
	public const ResourceTypeCode TimeSpan = 16;
	public const ResourceTypeCode LastPrimitive = 16;
	public const ResourceTypeCode ByteArray = 32;
	public const ResourceTypeCode Stream = 33;
	public const ResourceTypeCode StartOfUserTypes = 64;
}

// Namespace: System.Resources
internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 1195
{
	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0x14236C0 Offset: 0x1421CC0 VA: 0x1814236C0
	internal void .ctor(string fileName) { }

	// RVA: 0x14235A0 Offset: 0x1421BA0 VA: 0x1814235A0
	internal void .ctor(Stream stream) { }

	// RVA: 0x1422640 Offset: 0x1420C40 VA: 0x181422640 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1422820 Offset: 0x1420E20 VA: 0x181422820 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1422820 Offset: 0x1420E20 VA: 0x181422820 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1422780 Offset: 0x1420D80 VA: 0x181422780
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x1423390 Offset: 0x1421990 VA: 0x181423390 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0x1423350 Offset: 0x1421950 VA: 0x181423350 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0x1422830 Offset: 0x1420E30 VA: 0x181422830 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0x1423330 Offset: 0x1421930 VA: 0x181423330 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0x1422850 Offset: 0x1420E50 VA: 0x181422850
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0x14233E0 Offset: 0x14219E0 VA: 0x1814233E0
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }
}

// Namespace: System.Resources
[Usage(1, AllowMultiple = False)]
public sealed class SatelliteContractVersionAttribute : Attribute // TypeDefIndex: 1196
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1424160 Offset: 0x1422760 VA: 0x181424160
	public void .ctor(string version) { }
}

// Namespace: System.Resources
public enum UltimateResourceFallbackLocation // TypeDefIndex: 1197
{
	// Fields
	public int value__; // 0x0
	public const UltimateResourceFallbackLocation MainAssembly = 0;
	public const UltimateResourceFallbackLocation Satellite = 1;
}

// Namespace: System.Resources
internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 1198
{
	// Fields
	internal static readonly FastResourceComparer Default; // 0x0

	// Methods

	// RVA: 0x14165C0 Offset: 0x1414BC0 VA: 0x1814165C0 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0x1416670 Offset: 0x1414C70 VA: 0x181416670 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0x1416700 Offset: 0x1414D00 VA: 0x181416700
	internal static int HashFunction(string key) { }

	// RVA: 0x14164C0 Offset: 0x1414AC0 VA: 0x1814164C0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x14164A0 Offset: 0x1414AA0 VA: 0x1814164A0 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0x14165A0 Offset: 0x1414BA0 VA: 0x1814165A0 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0x1416530 Offset: 0x1414B30 VA: 0x181416530 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0x14163C0 Offset: 0x14149C0 VA: 0x1814163C0
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0x1416210 Offset: 0x1414810 VA: 0x181416210
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0x1416310 Offset: 0x1414910 VA: 0x181416310
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1416760 Offset: 0x1414D60 VA: 0x181416760
	private static void .cctor() { }
}

// Namespace: System.Resources
internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 1199
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }
}

// Namespace: System.Resources
internal interface IResourceGroveler // TypeDefIndex: 1200
{}

// Namespace: System.Resources
internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 1201
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x14182E0 Offset: 0x14168E0 VA: 0x1814182E0
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0x1418250 Offset: 0x1416850 VA: 0x181418250
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }
}

// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceManager // TypeDefIndex: 1204
{
	// Fields
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets; // 0x10
	private Dictionary<string, ResourceSet> _resourceSets; // 0x18
	protected Assembly MainAssembly; // 0x20
	private CultureInfo _neutralResourcesCulture; // 0x28
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x30
	private bool UseManifest; // 0x38
	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem; // 0x39
	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x3C
	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly; // 0x40
	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly; // 0x48
	private IResourceGroveler resourceGroveler; // 0x50
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	// Methods

	// RVA: 0x141CE30 Offset: 0x141B430 VA: 0x18141CE30
	private void Init() { }

	// RVA: 0x141D420 Offset: 0x141BA20 VA: 0x18141D420
	protected void .ctor() { }

	[OnDeserializing]
	// RVA: 0x141D140 Offset: 0x141B740 VA: 0x18141D140
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x141CF00 Offset: 0x141B500 VA: 0x18141CF00
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x141D190 Offset: 0x141B790 VA: 0x18141D190
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x141CBF0 Offset: 0x141B1F0 VA: 0x18141CBF0
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x141D210 Offset: 0x141B810 VA: 0x18141D210
	private static void .cctor() { }
}

// Namespace: System.Resources
internal struct ResourceLocator // TypeDefIndex: 1205
{
	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x140E400 Offset: 0x140CA00 VA: 0x18140E400
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	internal int get_DataPosition() { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	internal object get_Value() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	internal void set_Value(object value) { }

	// RVA: 0x141CB60 Offset: 0x141B160 VA: 0x18141CB60
	internal static bool CanCache(ResourceTypeCode value) { }
}

// Namespace: System.Resources
[ComVisible(True)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 1207
{
	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0x14217E0 Offset: 0x141FDE0 VA: 0x1814217E0
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0x141DC70 Offset: 0x141C270 VA: 0x18141DC70 Slot: 4
	public void Close() { }

	// RVA: 0x141E390 Offset: 0x141C990 VA: 0x18141E390 Slot: 7
	public void Dispose() { }

	// RVA: 0x141E2D0 Offset: 0x141C8D0 VA: 0x18141E2D0
	private void Dispose(bool disposing) { }

	// RVA: 0x141F920 Offset: 0x141DF20 VA: 0x18141F920
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0x141F940 Offset: 0x141DF40 VA: 0x18141F940
	private void SkipString() { }

	// RVA: 0x141EDF0 Offset: 0x141D3F0 VA: 0x18141EDF0
	private int GetNameHash(int index) { }

	// RVA: 0x141EE60 Offset: 0x141D460 VA: 0x18141EE60
	private int GetNamePosition(int index) { }

	// RVA: 0x141ED20 Offset: 0x141D320 VA: 0x18141ED20 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x141ED20 Offset: 0x141D320 VA: 0x18141ED20 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x141ECB0 Offset: 0x141D2B0 VA: 0x18141ECB0
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0x141E3A0 Offset: 0x141C9A0 VA: 0x18141E3A0
	internal int FindPosForResource(string name) { }

	// RVA: 0x141DD20 Offset: 0x141C320 VA: 0x18141DD20
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0x141D520 Offset: 0x141BB20 VA: 0x18141D520
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0x141EF90 Offset: 0x141D590 VA: 0x18141EF90
	private object GetValueForNameIndex(int index) { }

	// RVA: 0x141F4B0 Offset: 0x141DAB0 VA: 0x18141F4B0
	internal string LoadString(int pos) { }

	// RVA: 0x141F420 Offset: 0x141DA20 VA: 0x18141F420
	internal object LoadObject(int pos) { }

	// RVA: 0x141F450 Offset: 0x141DA50 VA: 0x18141F450
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x141F220 Offset: 0x141D820 VA: 0x18141F220
	internal object LoadObjectV1(int pos) { }

	// RVA: 0x141FA10 Offset: 0x141E010 VA: 0x18141FA10
	private object _LoadObjectV1(int pos) { }

	// RVA: 0x141F320 Offset: 0x141D920 VA: 0x18141F320
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x1420210 Offset: 0x141E810 VA: 0x181420210
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x141E120 Offset: 0x141C720 VA: 0x18141E120
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0x141F7A0 Offset: 0x141DDA0 VA: 0x18141F7A0
	private void ReadResources() { }

	// RVA: 0x1420D60 Offset: 0x141F360 VA: 0x181420D60
	private void _ReadResources() { }

	// RVA: 0x141E890 Offset: 0x141CE90 VA: 0x18141E890
	private RuntimeType FindType(int typeIndex) { }
}

// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 1208
{
	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0x14224B0 Offset: 0x1420AB0 VA: 0x1814224B0
	protected void .ctor() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor(bool junk) { }

	// RVA: 0x1421930 Offset: 0x141FF30 VA: 0x181421930
	private void CommonInit() { }

	// RVA: 0x1421990 Offset: 0x141FF90 VA: 0x181421990 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1421A30 Offset: 0x1420030 VA: 0x181421A30 Slot: 4
	public void Dispose() { }

	[ComVisible(False)]
	// RVA: 0x1421E50 Offset: 0x1420450 VA: 0x181421E50 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1421E50 Offset: 0x1420450 VA: 0x181421E50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1421DC0 Offset: 0x14203C0 VA: 0x181421DC0
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x1422050 Offset: 0x1420650 VA: 0x181422050 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0x1422200 Offset: 0x1420800 VA: 0x181422200 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0x1421E60 Offset: 0x1420460 VA: 0x181421E60 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0x1421F40 Offset: 0x1420540 VA: 0x181421F40 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0x1421E60 Offset: 0x1420460 VA: 0x181421E60
	private object GetObjectInternal(string name) { }

	// RVA: 0x1421A50 Offset: 0x1420050 VA: 0x181421A50
	private object GetCaseInsensitiveObjectInternal(string name) { }
}

