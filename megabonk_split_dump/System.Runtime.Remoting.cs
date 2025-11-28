// Namespace: System.Runtime.Remoting
[Serializable]
internal class ChannelInfo : IChannelInfo // TypeDefIndex: 825
{
	// Fields
	private object[] channelData; // 0x10

	// Properties
	public object[] ChannelData { get; }

	// Methods

	// RVA: 0x13B8F10 Offset: 0x13B7510 VA: 0x1813B8F10
	public void .ctor() { }

	// RVA: 0x13B8F70 Offset: 0x13B7570 VA: 0x1813B8F70
	public void .ctor(object remoteChannelData) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public object[] get_ChannelData() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 826
{
	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x13B7F50 Offset: 0x13B6550 VA: 0x1813B7F50
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_ApplicationUrl() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Type get_ObjectType() { }

	// RVA: 0x13B7F30 Offset: 0x13B6530 VA: 0x1813B7F30 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class ActivatedServiceTypeEntry : TypeEntry // TypeDefIndex: 827
{
	// Fields
	private Type obj_type; // 0x20

	// Properties
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x13B80B0 Offset: 0x13B66B0 VA: 0x1813B80B0
	public void .ctor(string typeName, string assemblyName) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_ObjectType() { }

	// RVA: 0x13B80A0 Offset: 0x13B66A0 VA: 0x1813B80A0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public enum CustomErrorsModes // TypeDefIndex: 828
{
	// Fields
	public int value__; // 0x0
	public const CustomErrorsModes On = 0;
	public const CustomErrorsModes Off = 1;
	public const CustomErrorsModes RemoteOnly = 2;
}

// Namespace: System.Runtime.Remoting
[Serializable]
internal class EnvoyInfo : IEnvoyInfo // TypeDefIndex: 829
{
	// Fields
	private IMessageSink envoySinks; // 0x10

	// Properties
	public IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(IMessageSink sinks) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public IMessageSink get_EnvoySinks() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IChannelInfo // TypeDefIndex: 830
{
	// Properties
	public abstract object[] ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] get_ChannelData();
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IEnvoyInfo // TypeDefIndex: 831
{
	// Properties
	public abstract IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink get_EnvoySinks();
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IRemotingTypeInfo // TypeDefIndex: 832
{
	// Properties
	public abstract string TypeName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanCastTo(Type fromType, object o);
}

// Namespace: System.Runtime.Remoting
internal abstract class Identity // TypeDefIndex: 833
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_ObjectUri() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_ObjectUri(string value) { }

	// RVA: 0x13C33E0 Offset: 0x13C19E0 VA: 0x1813C33E0
	public bool get_IsConnected() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_Disposed() { }

	// RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	public void set_Disposed(bool value) { }

	// RVA: 0x13C32D0 Offset: 0x13C18D0 VA: 0x1813C32D0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x13C3390 Offset: 0x13C1990 VA: 0x1813C3390
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x13C3190 Offset: 0x13C1790 VA: 0x1813C3190
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x13C3230 Offset: 0x13C1830 VA: 0x1813C3230
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

// Namespace: System.Runtime.Remoting
internal class ClientIdentity : Identity // TypeDefIndex: 834
{
	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0x13BBE30 Offset: 0x13BA430 VA: 0x1813BBE30
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0x13BBF10 Offset: 0x13BA510 VA: 0x1813BBF10
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0x13BBFD0 Offset: 0x13BA5D0 VA: 0x1813BBFD0
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x13BBFA0 Offset: 0x13BA5A0 VA: 0x1813BBFA0
	public string get_TargetUri() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class InternalRemotingServices // TypeDefIndex: 835
{
	// Fields
	private static Hashtable _soapAttributes; // 0x0

	// Methods

	// RVA: 0x13C33F0 Offset: 0x13C19F0 VA: 0x1813C33F0
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject) { }

	// RVA: 0x13C3950 Offset: 0x13C1F50 VA: 0x1813C3950
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 836
{
	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x13C6440 Offset: 0x13C4A40 VA: 0x1813C6440
	public void .ctor() { }

	// RVA: 0x13C63F0 Offset: 0x13C49F0 VA: 0x1813C63F0
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x13C5840 Offset: 0x13C3E40 VA: 0x1813C5840
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x13C5BF0 Offset: 0x13C41F0 VA: 0x1813C5BF0
	internal byte[] SerializeType() { }

	// RVA: 0x13C5D80 Offset: 0x13C4380 VA: 0x1813C5D80
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x13C5EA0 Offset: 0x13C44A0 VA: 0x1813C5EA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13C6460 Offset: 0x13C4A60 VA: 0x1813C6460
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x13C5980 Offset: 0x13C3F80 VA: 0x1813C5980 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13C5B20 Offset: 0x13C4120 VA: 0x1813C5B20 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x13C5C80 Offset: 0x13C4280 VA: 0x1813C5C80
	internal void UpdateChannelInfo() { }

	// RVA: 0x13C64C0 Offset: 0x13C4AC0 VA: 0x1813C64C0
	internal Type get_ServerType() { }

	// RVA: 0x13C5D30 Offset: 0x13C4330 VA: 0x1813C5D30
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingConfiguration // TypeDefIndex: 837
{
	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static CustomErrorsModes _errorMode; // 0x1C
	private static Hashtable wellKnownClientEntries; // 0x20
	private static Hashtable activatedClientEntries; // 0x28
	private static Hashtable wellKnownServiceEntries; // 0x30
	private static Hashtable activatedServiceEntries; // 0x38
	private static Hashtable channelTemplates; // 0x40
	private static Hashtable clientProviderTemplates; // 0x48
	private static Hashtable serverProviderTemplates; // 0x50

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x13CAC20 Offset: 0x13C9220 VA: 0x1813CAC20
	public static string get_ApplicationName() { }

	// RVA: 0x13CAD50 Offset: 0x13C9350 VA: 0x1813CAD50
	public static void set_ApplicationName(string value) { }

	// RVA: 0x13CAC70 Offset: 0x13C9270 VA: 0x1813CAC70
	public static string get_ProcessId() { }

	// RVA: 0x13C8CB0 Offset: 0x13C72B0 VA: 0x1813C8CB0
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x13C8880 Offset: 0x13C6E80 VA: 0x1813C8880
	public static bool IsActivationAllowed(Type svrType) { }

	// RVA: 0x13C89B0 Offset: 0x13C6FB0 VA: 0x1813C89B0
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x13C8B30 Offset: 0x13C7130 VA: 0x1813C8B30
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x13C8FF0 Offset: 0x13C75F0 VA: 0x1813C8FF0
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x13C9280 Offset: 0x13C7880 VA: 0x1813C9280
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x13CA310 Offset: 0x13C8910 VA: 0x1813CA310
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x13CA5A0 Offset: 0x13C8BA0 VA: 0x1813CA5A0
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x13C93B0 Offset: 0x13C79B0 VA: 0x1813C93B0
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x13C9D70 Offset: 0x13C8370 VA: 0x1813C9D70
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x13C9DF0 Offset: 0x13C83F0 VA: 0x1813C9DF0
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x13C9430 Offset: 0x13C7A30 VA: 0x1813C9430
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x13C9E70 Offset: 0x13C8470 VA: 0x1813C9E70
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x13C87F0 Offset: 0x13C6DF0 VA: 0x1813C87F0
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x13CA720 Offset: 0x13C8D20 VA: 0x1813CA720
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x13CA950 Offset: 0x13C8F50 VA: 0x1813CA950
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 838
{
	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0x13BF750 Offset: 0x13BDD50 VA: 0x1813BF750
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0x13BF660 Offset: 0x13BDC60 VA: 0x1813BF660
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0x13BC040 Offset: 0x13BA640 VA: 0x1813BC040
	private bool CheckPath(string path) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x13BC4D0 Offset: 0x13BAAD0 VA: 0x1813BC4D0 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BC630 Offset: 0x13BAC30 VA: 0x1813BC630
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BC310 Offset: 0x13BA910 VA: 0x1813BC310 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x13BE190 Offset: 0x13BC790 VA: 0x1813BE190
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BE720 Offset: 0x13BCD20 VA: 0x1813BE720
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BD3E0 Offset: 0x13BB9E0 VA: 0x1813BD3E0
	private TimeSpan ParseTime(string s) { }

	// RVA: 0x13BD760 Offset: 0x13BBD60 VA: 0x1813BD760
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x13BECC0 Offset: 0x13BD2C0 VA: 0x1813BECC0
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x13BDD30 Offset: 0x13BC330 VA: 0x1813BDD30
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BF1B0 Offset: 0x13BD7B0 VA: 0x1813BF1B0
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BDF90 Offset: 0x13BC590 VA: 0x1813BDF90
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BF370 Offset: 0x13BD970 VA: 0x1813BF370
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BE580 Offset: 0x13BCB80 VA: 0x1813BE580
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0x13BEA50 Offset: 0x13BD050 VA: 0x1813BEA50
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x13BC230 Offset: 0x13BA830 VA: 0x1813BC230
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0x13BC150 Offset: 0x13BA750 VA: 0x1813BC150
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x13BC3C0 Offset: 0x13BA9C0 VA: 0x1813BC3C0 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

// Namespace: System.Runtime.Remoting
internal class ChannelData // TypeDefIndex: 839
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0x13B8EA0 Offset: 0x13B74A0 VA: 0x1813B8EA0
	internal ArrayList get_ServerProviders() { }

	// RVA: 0x13B8DC0 Offset: 0x13B73C0 VA: 0x1813B8DC0
	public ArrayList get_ClientProviders() { }

	// RVA: 0x13B8E30 Offset: 0x13B7430 VA: 0x1813B8E30
	public Hashtable get_CustomProperties() { }

	// RVA: 0x13B8350 Offset: 0x13B6950 VA: 0x1813B8350
	public void CopyFrom(ChannelData other) { }

	// RVA: 0x13B8CF0 Offset: 0x13B72F0 VA: 0x1813B8CF0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
internal class ProviderData // TypeDefIndex: 840
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal Hashtable CustomProperties; // 0x28
	internal IList CustomData; // 0x30

	// Methods

	// RVA: 0x13C65A0 Offset: 0x13C4BA0 VA: 0x1813C65A0
	public void CopyFrom(ProviderData other) { }

	// RVA: 0x13C3120 Offset: 0x13C1720 VA: 0x1813C3120
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
internal class FormatterData : ProviderData // TypeDefIndex: 841
{
	// Methods

	// RVA: 0x13C3120 Offset: 0x13C1720 VA: 0x1813C3120
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public class RemotingException : SystemException // TypeDefIndex: 842
{
	// Methods

	// RVA: 0x13968D0 Offset: 0x1394ED0 VA: 0x1813968D0
	public void .ctor() { }

	// RVA: 0x13CADD0 Offset: 0x13C93D0 VA: 0x1813CADD0
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13CADC0 Offset: 0x13C93C0 VA: 0x1813CADC0
	public void .ctor(string message, Exception InnerException) { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingServices // TypeDefIndex: 844
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x13CFFF0 Offset: 0x13CE5F0 VA: 0x1813CFFF0
	private static void .cctor() { }

	// RVA: 0x13CEEA0 Offset: 0x13CD4A0 VA: 0x1813CEEA0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x13CE720 Offset: 0x13CCD20 VA: 0x1813CE720
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x13CEF40 Offset: 0x13CD540 VA: 0x1813CEF40
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x13CE730 Offset: 0x13CCD30 VA: 0x1813CE730
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisible(True)]
	// RVA: 0x13CC020 Offset: 0x13CA620 VA: 0x1813CC020
	public static object Connect(Type classToProxy, string url) { }

	[ComVisible(True)]
	// RVA: 0x13CBF30 Offset: 0x13CA530 VA: 0x1813CBF30
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x13CE680 Offset: 0x13CCC80 VA: 0x1813CE680
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x13CFAC0 Offset: 0x13CE0C0 VA: 0x1813CFAC0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x13CFB10 Offset: 0x13CE110 VA: 0x1813CFB10
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x13CEFF0 Offset: 0x13CD5F0 VA: 0x1813CEFF0
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x13CEF80 Offset: 0x13CD580 VA: 0x1813CEF80
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x13CF040 Offset: 0x13CD640 VA: 0x1813CF040
	private static string NewUri() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x13CE5C0 Offset: 0x13CCBC0 VA: 0x1813CE5C0
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x13CD7A0 Offset: 0x13CBDA0 VA: 0x1813CD7A0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x13CD9A0 Offset: 0x13CBFA0 VA: 0x1813CD9A0
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x13CCEB0 Offset: 0x13CB4B0 VA: 0x1813CCEB0
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x13CDC00 Offset: 0x13CC200 VA: 0x1813CDC00
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13CEEB0 Offset: 0x13CD4B0 VA: 0x1813CEEB0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x13CC6B0 Offset: 0x13CACB0 VA: 0x1813CC6B0
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x13CC350 Offset: 0x13CA950 VA: 0x1813CC350
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x13CC580 Offset: 0x13CAB80 VA: 0x1813CC580
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x13CC1B0 Offset: 0x13CA7B0 VA: 0x1813CC1B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x13CD110 Offset: 0x13CB710 VA: 0x1813CD110
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x13CF5D0 Offset: 0x13CDBD0 VA: 0x1813CF5D0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x13CDCB0 Offset: 0x13CC2B0 VA: 0x1813CDCB0
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x13CCFE0 Offset: 0x13CB5E0 VA: 0x1813CCFE0
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x13CC7C0 Offset: 0x13CADC0 VA: 0x1813CC7C0
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x13CC100 Offset: 0x13CA700 VA: 0x1813CC100
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x13CC8C0 Offset: 0x13CAEC0 VA: 0x1813CC8C0
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x13CF3C0 Offset: 0x13CD9C0 VA: 0x1813CF3C0
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x13CE4C0 Offset: 0x13CCAC0 VA: 0x1813CE4C0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x13CE610 Offset: 0x13CCC10 VA: 0x1813CE610
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x13CF6D0 Offset: 0x13CDCD0 VA: 0x1813CF6D0
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x13CC9F0 Offset: 0x13CAFF0 VA: 0x1813CC9F0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x13CF910 Offset: 0x13CDF10 VA: 0x1813CF910
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x13CF380 Offset: 0x13CD980 VA: 0x1813CF380
	private static void RegisterInternalChannels() { }

	// RVA: 0x13CCC60 Offset: 0x13CB260 VA: 0x1813CCC60
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x13CD460 Offset: 0x13CBA60 VA: 0x1813CD460
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x13CFA00 Offset: 0x13CE000 VA: 0x1813CFA00
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x13CFE80 Offset: 0x13CE480 VA: 0x1813CFE80
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x13CDB90 Offset: 0x13CC190 VA: 0x1813CDB90
	private static string GetNormalizedUri(string uri) { }
}

// Namespace: System.Runtime.Remoting
internal abstract class ServerIdentity : Identity // TypeDefIndex: 845
{
	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x13D0C10 Offset: 0x13CF210 VA: 0x1813D0C10
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public Type get_ObjectType() { }

	// RVA: 0x13D08F0 Offset: 0x13CEEF0 VA: 0x1813D08F0
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x13D08E0 Offset: 0x13CEEE0 VA: 0x1813D08E0 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x13D0650 Offset: 0x13CEC50 VA: 0x1813D0650 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x13D05D0 Offset: 0x13CEBD0 VA: 0x1813D05D0
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public Lease get_Lease() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public Context get_Context() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x13D0840 Offset: 0x13CEE40 VA: 0x1813D0840
	protected void DisposeServerObject() { }
}

// Namespace: System.Runtime.Remoting
internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 846
{
	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0x13BBDC0 Offset: 0x13BA3C0 VA: 0x1813BBDC0
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0x13BBCC0 Offset: 0x13BA2C0 VA: 0x1813BBCC0 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0x13BBD20 Offset: 0x13BA320 VA: 0x1813BBD20 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x13BBC10 Offset: 0x13BA210 VA: 0x1813BBC10 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class SingletonIdentity : ServerIdentity // TypeDefIndex: 847
{
	// Methods

	// RVA: 0x13D0C10 Offset: 0x13CF210 VA: 0x1813D0C10
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x13D1060 Offset: 0x13CF660 VA: 0x1813D1060
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x13D1180 Offset: 0x13CF780 VA: 0x1813D1180 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x13D0FB0 Offset: 0x13CF5B0 VA: 0x1813D0FB0 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class SingleCallIdentity : ServerIdentity // TypeDefIndex: 848
{
	// Methods

	// RVA: 0x13D0C10 Offset: 0x13CF210 VA: 0x1813D0C10
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x13D0E30 Offset: 0x13CF430 VA: 0x1813D0E30 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x13D0C80 Offset: 0x13CF280 VA: 0x1813D0C80 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class DisposerReplySink : IMessageSink // TypeDefIndex: 849
{
	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x13C2690 Offset: 0x13C0C90 VA: 0x1813C2690 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13C2650 Offset: 0x13C0C50 VA: 0x1813C2650 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class SoapServices // TypeDefIndex: 851
{
	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x13D2530 Offset: 0x13D0B30 VA: 0x1813D2530
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x13D2590 Offset: 0x13D0B90 VA: 0x1813D2590
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x13D2560 Offset: 0x13D0B60 VA: 0x1813D2560
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x13D1210 Offset: 0x13CF810 VA: 0x1813D1210
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x13D15A0 Offset: 0x13CFBA0 VA: 0x1813D15A0
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x13D1460 Offset: 0x13CFA60 VA: 0x1813D1460
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x13D1600 Offset: 0x13CFC00 VA: 0x1813D1600
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x13D1710 Offset: 0x13CFD10 VA: 0x1813D1710
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x13D17C0 Offset: 0x13CFDC0 VA: 0x1813D17C0
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x13D1870 Offset: 0x13CFE70 VA: 0x1813D1870
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x13D1FE0 Offset: 0x13D05E0 VA: 0x1813D1FE0
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x13D1960 Offset: 0x13CFF60 VA: 0x1813D1960
	public static void PreLoad(Type type) { }

	// RVA: 0x13D2090 Offset: 0x13D0690 VA: 0x1813D2090
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x13D2220 Offset: 0x13D0820 VA: 0x1813D2220
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x13D1390 Offset: 0x13CF990 VA: 0x1813D1390
	private static string EncodeNs(string ns) { }

	// RVA: 0x13D23A0 Offset: 0x13D09A0 VA: 0x1813D23A0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class TypeEntry // TypeDefIndex: 852
{
	// Fields
	private string assembly_name; // 0x10
	private string type_name; // 0x18

	// Properties
	public string AssemblyName { get; set; }
	public string TypeName { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_AssemblyName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_AssemblyName(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_TypeName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_TypeName(string value) { }
}

// Namespace: System.Runtime.Remoting
[Serializable]
internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 853
{
	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x13D4190 Offset: 0x13D2790 VA: 0x1813D4190
	public void .ctor(Type type) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public string get_TypeName() { }

	// RVA: 0x13D3F50 Offset: 0x13D2550 VA: 0x1813D3F50 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 854
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x13D4B40 Offset: 0x13D3140 VA: 0x1813D4B40
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_ApplicationUrl() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_ObjectType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_ObjectUrl() { }

	// RVA: 0x13D4B00 Offset: 0x13D3100 VA: 0x1813D4B00 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public enum WellKnownObjectMode // TypeDefIndex: 855
{
	// Fields
	public int value__; // 0x0
	public const WellKnownObjectMode Singleton = 1;
	public const WellKnownObjectMode SingleCall = 2;
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 856
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x13D4D90 Offset: 0x13D3390 VA: 0x1813D4D90
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_ObjectType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_ObjectUri() { }

	// RVA: 0x13D4C90 Offset: 0x13D3290 VA: 0x1813D4C90 Slot: 3
	public override string ToString() { }
}

