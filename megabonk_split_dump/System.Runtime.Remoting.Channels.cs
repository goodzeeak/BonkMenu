// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public sealed class ChannelServices // TypeDefIndex: 887
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x13E0710 Offset: 0x13DED10 VA: 0x1813E0710
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x13DE060 Offset: 0x13DC660 VA: 0x1813DE060
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x13DDF50 Offset: 0x13DC550 VA: 0x1813DDF50
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	// RVA: 0x13E03F0 Offset: 0x13DE9F0 VA: 0x1813E03F0
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x13DFDC0 Offset: 0x13DE3C0 VA: 0x1813DFDC0
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x13DEF50 Offset: 0x13DD550 VA: 0x1813DEF50
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x13DE870 Offset: 0x13DCE70 VA: 0x1813DE870
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x13E0440 Offset: 0x13DEA40 VA: 0x1813E0440
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x13DDBE0 Offset: 0x13DC1E0 VA: 0x1813DDBE0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x13DDDE0 Offset: 0x13DC3E0 VA: 0x1813DDDE0
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x13DEBA0 Offset: 0x13DD1A0 VA: 0x1813DEBA0
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x13E0510 Offset: 0x13DEB10 VA: 0x1813E0510
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainData // TypeDefIndex: 888
{
	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0x13E2940 Offset: 0x13E0F40 VA: 0x1813E2940
	internal void .ctor(int domainId) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	internal int get_DomainID() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_ProcessID() { }
}

// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 889
{
	// Fields
	private static object s_lock; // 0x0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0x13E2680 Offset: 0x13E0C80 VA: 0x1813E2680
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0x13E2910 Offset: 0x13E0F10 VA: 0x1813E2910 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x429C80 Offset: 0x428280 VA: 0x180429C80 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0x13E2840 Offset: 0x13E0E40 VA: 0x1813E2840 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0x13E2500 Offset: 0x13E0B00 VA: 0x1813E2500 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x13E27C0 Offset: 0x13E0DC0 VA: 0x1813E27C0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Channels
[MonoTODO("Handle domain unloading?")]
internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 891
{
	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	internal void .ctor(int domainID) { }

	// RVA: 0x13E2AC0 Offset: 0x13E10C0 VA: 0x1813E2AC0
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal int get_TargetDomainId() { }

	// RVA: 0x13E2D80 Offset: 0x13E1380 VA: 0x1813E2D80
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0x13E2F40 Offset: 0x13E1540 VA: 0x1813E2F40 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0x13E29E0 Offset: 0x13E0FE0 VA: 0x1813E29E0 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0x13E2E80 Offset: 0x13E1480 VA: 0x1813E2E80
	public void SendAsyncMessage(object data) { }

	// RVA: 0x13E33E0 Offset: 0x13E19E0 VA: 0x1813E33E0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x13E3320 Offset: 0x13E1920 VA: 0x1813E3320
	private void <AsyncProcessMessage>b__10_0(object data) { }
}

// Namespace: System.Runtime.Remoting.Channels
internal class CADSerializer // TypeDefIndex: 892
{
	// Methods

	// RVA: 0x13DD410 Offset: 0x13DBA10 VA: 0x1813DD410
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	// RVA: 0x13DD600 Offset: 0x13DBC00 VA: 0x1813DD600
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	// RVA: 0x13DD450 Offset: 0x13DBA50 VA: 0x1813DD450
	internal static object DeserializeObjectSafe(byte[] mem) { }

	// RVA: 0x13DD700 Offset: 0x13DBD00 VA: 0x1813DD700
	internal static MemoryStream SerializeObject(object obj) { }

	// RVA: 0x13DD560 Offset: 0x13DBB60 VA: 0x1813DD560
	internal static object DeserializeObject(MemoryStream mem) { }
}

// Namespace: System.Runtime.Remoting.Channels
internal class AsyncRequest // TypeDefIndex: 893
{
	// Fields
	internal IMessageSink ReplySink; // 0x10
	internal IMessage MsgRequest; // 0x18

	// Methods

	// RVA: 0x8B6980 Offset: 0x8B4F80 VA: 0x1808B6980
	public void .ctor(IMessage msgRequest, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannel // TypeDefIndex: 894
{
	// Properties
	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ChannelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ChannelPriority();
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
[DefaultMember("Item")]
public interface IChannelDataStore // TypeDefIndex: 895
{}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelReceiver : IChannel // TypeDefIndex: 896
{
	// Properties
	public abstract object ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ChannelData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartListening(object data);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelSender : IChannel // TypeDefIndex: 897
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IClientChannelSinkProvider // TypeDefIndex: 898
{
	// Properties
	public abstract IClientChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IClientChannelSinkProvider value);
}

// Namespace: System.Runtime.Remoting.Channels
public interface ISecurableChannel // TypeDefIndex: 899
{
	// Properties
	public abstract bool IsSecured { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_IsSecured(bool value);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IServerChannelSinkProvider // TypeDefIndex: 900
{
	// Properties
	public abstract IServerChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IServerChannelSinkProvider value);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public class SinkProviderData // TypeDefIndex: 901
{
	// Fields
	private string sinkName; // 0x10
	private ArrayList children; // 0x18
	private Hashtable properties; // 0x20

	// Properties
	public IList Children { get; }
	public IDictionary Properties { get; }

	// Methods

	// RVA: 0x13F5F10 Offset: 0x13F4510 VA: 0x1813F5F10
	public void .ctor(string name) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public IList get_Children() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IDictionary get_Properties() { }
}

