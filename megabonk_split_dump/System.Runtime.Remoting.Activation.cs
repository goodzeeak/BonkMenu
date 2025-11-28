// Namespace: System.Runtime.Remoting.Activation
internal class ActivationServices // TypeDefIndex: 902
{
	// Fields
	private static IActivator _constructionActivator; // 0x0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0x13D95C0 Offset: 0x13D7BC0 VA: 0x1813D95C0
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0x13D85C0 Offset: 0x13D6BC0 VA: 0x1813D85C0
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0x13D9500 Offset: 0x13D7B00 VA: 0x1813D9500
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0x13D8790 Offset: 0x13D6D90 VA: 0x1813D8790
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x13D9070 Offset: 0x13D7670 VA: 0x1813D9070
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0x13D93B0 Offset: 0x13D79B0 VA: 0x1813D93B0
	public static object CreateProxyForType(Type type) { }

	// RVA: 0x13D8780 Offset: 0x13D6D80 VA: 0x1813D8780
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0x13D94F0 Offset: 0x13D7AF0 VA: 0x1813D94F0
	public static void EnableProxyActivation(Type type, bool enable) { }
}

// Namespace: System.Runtime.Remoting.Activation
internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 903
{
	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x13D9660 Offset: 0x13D7C60 VA: 0x1813D9660 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ConstructionLevelActivator : IActivator // TypeDefIndex: 904
{
	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x13E1DA0 Offset: 0x13E03A0 VA: 0x1813E1DA0 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ContextLevelActivator : IActivator // TypeDefIndex: 905
{
	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(IActivator next) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x13E2080 Offset: 0x13E0680 VA: 0x1813E2080 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IActivator // TypeDefIndex: 906
{
	// Properties
	public abstract IActivator NextActivator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IActivator get_NextActivator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 907
{
	// Properties
	public abstract Type ActivationType { get; }
	public abstract string ActivationTypeName { get; }
	public abstract IActivator Activator { get; set; }
	public abstract object[] CallSiteActivationAttributes { get; }
	public abstract IList ContextProperties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_ActivationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ActivationTypeName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IActivator get_Activator();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Activator(IActivator value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object[] get_CallSiteActivationAttributes();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList get_ContextProperties();
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IConstructionReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 908
{}

// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivationAttribute : Attribute, IContextAttribute // TypeDefIndex: 909
{
	// Fields
	private IList _contextProperties; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(IList contextProperties) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

	// RVA: 0x13F3800 Offset: 0x13F1E00 VA: 0x1813F3800 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }
}

// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivator : MarshalByRefObject, IActivator // TypeDefIndex: 910
{
	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x13F3B30 Offset: 0x13F2130 VA: 0x1813F3B30 Slot: 7
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	// RVA: 0x13F3E50 Offset: 0x13F2450 VA: 0x1813F3E50 Slot: 6
	public IActivator get_NextActivator() { }
}

