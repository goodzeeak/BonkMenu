// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public class Context // TypeDefIndex: 871
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStatic]
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x13C0FB0 Offset: 0x13BF5B0 VA: 0x1813C0FB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x13C11C0 Offset: 0x13BF7C0 VA: 0x1813C11C0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x13C16E0 Offset: 0x13BFCE0 VA: 0x1813C16E0
	public void .ctor() { }

	// RVA: 0x13C0430 Offset: 0x13BEA30 VA: 0x1813C0430 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13C17C0 Offset: 0x13BFDC0 VA: 0x1813C17C0
	public static Context get_DefaultContext() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x13C1760 Offset: 0x13BFD60 VA: 0x1813C1760 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x13C1A40 Offset: 0x13C0040 VA: 0x1813C1A40
	internal bool get_IsDefaultContext() { }

	// RVA: 0x13C1BD0 Offset: 0x13C01D0 VA: 0x1813C1BD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x13C0FC0 Offset: 0x13BF5C0 VA: 0x1813C0FC0
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x13C1460 Offset: 0x13BFA60 VA: 0x1813C1460
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x13C08B0 Offset: 0x13BEEB0 VA: 0x1813C08B0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x13C0E90 Offset: 0x13BF490 VA: 0x1813C0E90
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x13C1990 Offset: 0x13BFF90 VA: 0x1813C1990
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x13C0DF0 Offset: 0x13BF3F0 VA: 0x1813C0DF0
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x13C17D0 Offset: 0x13BFDD0 VA: 0x1813C17D0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x13C1820 Offset: 0x13BFE20 VA: 0x1813C1820
	internal bool get_HasExitSinks() { }

	// RVA: 0x13C0AD0 Offset: 0x13BF0D0 VA: 0x1813C0AD0 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x13C1220 Offset: 0x13BF820 VA: 0x1813C1220 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x13C0530 Offset: 0x13BEB30 VA: 0x1813C0530 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x13C1410 Offset: 0x13BFA10 VA: 0x1813C1410 Slot: 3
	public override string ToString() { }

	// RVA: 0x13C0C40 Offset: 0x13BF240 VA: 0x1813C0C40
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x13C06E0 Offset: 0x13BECE0 VA: 0x1813C06E0
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x13C0190 Offset: 0x13BE790 VA: 0x1813C0190
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x13BF8F0 Offset: 0x13BDEF0 VA: 0x1813BF8F0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x13C1400 Offset: 0x13BFA00 VA: 0x1813C1400
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x13BFA80 Offset: 0x13BE080 VA: 0x1813BFA80
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x13C0300 Offset: 0x13BE900 VA: 0x1813C0300
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x13C1A50 Offset: 0x13C0050 VA: 0x1813C1A50
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x13BF820 Offset: 0x13BDE20 VA: 0x1813BF820
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x13BF880 Offset: 0x13BDE80 VA: 0x1813BF880
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x13C04C0 Offset: 0x13BEAC0 VA: 0x1813C04C0
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x13C0A60 Offset: 0x13BF060 VA: 0x1813C0A60
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x13C0870 Offset: 0x13BEE70 VA: 0x1813C0870
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x13C11D0 Offset: 0x13BF7D0 VA: 0x1813C11D0
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x13C1660 Offset: 0x13BFC60 VA: 0x1813C1660
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class DynamicPropertyCollection // TypeDefIndex: 873
{
	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x13C30F0 Offset: 0x13C16F0 VA: 0x1813C30F0
	public bool get_HasProperties() { }

	// RVA: 0x13C2D10 Offset: 0x13C1310 VA: 0x1813C2D10
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x13C2F40 Offset: 0x13C1540 VA: 0x1813C2F40
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x13C2860 Offset: 0x13C0E60 VA: 0x1813C2860
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x13C2710 Offset: 0x13C0D10 VA: 0x1813C2710
	private int FindProperty(string name) { }

	// RVA: 0x13C3080 Offset: 0x13C1680 VA: 0x1813C3080
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class ContextCallbackObject : ContextBoundObject // TypeDefIndex: 874
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class CrossContextChannel : IMessageSink // TypeDefIndex: 876
{
	// Methods

	// RVA: 0x13C20A0 Offset: 0x13C06A0 VA: 0x1813C20A0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13C1CC0 Offset: 0x13C02C0 VA: 0x1813C1CC0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public sealed class CrossContextDelegate : MulticastDelegate // TypeDefIndex: 877
{
	// Methods

	// RVA: 0x3B5700 Offset: 0x3B3D00 VA: 0x1803B5700
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x345000 Offset: 0x343600 VA: 0x180345000 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextAttribute // TypeDefIndex: 878
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextProperty // TypeDefIndex: 879
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Freeze(Context newContext);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsNewContextOK(Context newCtx);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeClientContextSink // TypeDefIndex: 880
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetClientContextSink(IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeDynamicSink // TypeDefIndex: 881
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDynamicMessageSink GetDynamicSink();
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeEnvoySink // TypeDefIndex: 882
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeObjectSink // TypeDefIndex: 883
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeServerContextSink // TypeDefIndex: 884
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetServerContextSink(IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IDynamicMessageSink // TypeDefIndex: 885
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IDynamicProperty // TypeDefIndex: 886
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();
}

