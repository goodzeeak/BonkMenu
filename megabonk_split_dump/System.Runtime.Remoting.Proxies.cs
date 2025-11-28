// Namespace: System.Runtime.Remoting.Proxies
[ComVisible(True)]
[Usage(4)]
public class ProxyAttribute : Attribute, IContextAttribute // TypeDefIndex: 859
{
	// Methods

	// RVA: 0x13C6BF0 Offset: 0x13C51F0 VA: 0x1813C6BF0 Slot: 9
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x13C6D10 Offset: 0x13C5310 VA: 0x1813C6D10 Slot: 10
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[ComVisible(True)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[ComVisible(True)]
	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Proxies
internal class TransparentProxy // TypeDefIndex: 860
{
	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x13D3010 Offset: 0x13D1610 VA: 0x1813D3010
	internal RuntimeType GetProxyType() { }

	// RVA: 0x13D3840 Offset: 0x13D1E40 VA: 0x1813D3840
	private bool get_IsContextBoundObject() { }

	// RVA: 0xACFA50 Offset: 0xACE050 VA: 0x180ACFA50
	private Context get_TargetContext() { }

	// RVA: 0x13D30C0 Offset: 0x13D16C0 VA: 0x1813D30C0
	private bool InCurrentContext() { }

	// RVA: 0x13D31B0 Offset: 0x13D17B0 VA: 0x1813D31B0
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x13D34F0 Offset: 0x13D1AF0 VA: 0x1813D34F0
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Proxies
[ComVisible(True)]
public abstract class RealProxy // TypeDefIndex: 861
{
	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x13C8620 Offset: 0x13C6C20 VA: 0x1813C8620
	protected void .ctor() { }

	// RVA: 0x13C8740 Offset: 0x13C6D40 VA: 0x1813C8740
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x13C8550 Offset: 0x13C6B50 VA: 0x1813C8550
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x13C8630 Offset: 0x13C6C30 VA: 0x1813C8630
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x13C70D0 Offset: 0x13C56D0 VA: 0x1813C70D0
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x13C6F10 Offset: 0x13C5510 VA: 0x1813C6F10
	public Type GetProxiedType() { }

	// RVA: 0x13C6EA0 Offset: 0x13C54A0 VA: 0x1813C6EA0 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x13C70F0 Offset: 0x13C56F0 VA: 0x1813C70F0
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x13C70E0 Offset: 0x13C56E0 VA: 0x1813C70E0 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x13C6FA0 Offset: 0x13C55A0 VA: 0x1813C6FA0 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x13C6D70 Offset: 0x13C5370 VA: 0x1813C6D70
	internal object GetAppDomainTarget() { }

	// RVA: 0x13C7F60 Offset: 0x13C6560 VA: 0x1813C7F60
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }
}

// Namespace: System.Runtime.Remoting.Proxies
internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 862
{
	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x13CBC10 Offset: 0x13CA210 VA: 0x1813CBC10
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x13CBD20 Offset: 0x13CA320 VA: 0x1813CBD20
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x13CB510 Offset: 0x13C9B10 VA: 0x1813CB510 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x13CAEC0 Offset: 0x13C94C0 VA: 0x1813CAEC0
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x13CADE0 Offset: 0x13C93E0 VA: 0x1813CADE0
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x13CBE10 Offset: 0x13CA410 VA: 0x1813CBE10 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x13CB1C0 Offset: 0x13C97C0 VA: 0x1813CB1C0 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x13CB430 Offset: 0x13C9A30 VA: 0x1813CB430 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13CBB00 Offset: 0x13CA100 VA: 0x1813CBB00
	private static void .cctor() { }
}

