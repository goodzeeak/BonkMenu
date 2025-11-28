// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public sealed class CallContext // TypeDefIndex: 916
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	// RVA: 0x13DDB70 Offset: 0x13DC170 VA: 0x1813DDB70
	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

	// RVA: 0x13DD8E0 Offset: 0x13DBEE0 VA: 0x1813DD8E0
	public static object LogicalGetData(string name) { }

	// RVA: 0x13DD9C0 Offset: 0x13DBFC0 VA: 0x1813DD9C0
	public static void LogicalSetData(string name, object data) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class IllogicalCallContext // TypeDefIndex: 917
{
	// Fields
	private Hashtable m_Datastore; // 0x10
	private object m_HostContext; // 0x18

	// Properties
	private Hashtable Datastore { get; }
	internal object HostContext { get; set; }
	internal bool HasUserData { get; }

	// Methods

	// RVA: 0x13E6CF0 Offset: 0x13E52F0 VA: 0x1813E6CF0
	private Hashtable get_Datastore() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal object get_HostContext() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_HostContext(object value) { }

	// RVA: 0x13E6D60 Offset: 0x13E5360 VA: 0x1813E6D60
	internal bool get_HasUserData() { }

	// RVA: 0x13E6C50 Offset: 0x13E5250 VA: 0x1813E6C50
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x13E6920 Offset: 0x13E4F20 VA: 0x1813E6920
	public IllogicalCallContext CreateCopy() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 919
{
	// Fields
	private static Type s_callContextType; // 0x0
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13E7E10 Offset: 0x13E6410 VA: 0x1813E7E10
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13E75E0 Offset: 0x13E5BE0 VA: 0x1813E75E0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13E6DA0 Offset: 0x13E53A0 VA: 0x1813E6DA0 Slot: 5
	public object Clone() { }

	// RVA: 0x13E79A0 Offset: 0x13E5FA0 VA: 0x1813E79A0
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x13E8240 Offset: 0x13E6840 VA: 0x1813E8240
	public bool get_HasInfo() { }

	// RVA: 0x13E6D60 Offset: 0x13E5360 VA: 0x1813E6D60
	private bool get_HasUserData() { }

	// RVA: 0x13E81D0 Offset: 0x13E67D0 VA: 0x1813E81D0
	private Hashtable get_Datastore() { }

	// RVA: 0x13E7540 Offset: 0x13E5B40 VA: 0x1813E7540
	public object GetData(string name) { }

	// RVA: 0x13E7CB0 Offset: 0x13E62B0 VA: 0x1813E7CB0
	public void SetData(string name, object data) { }

	// RVA: 0x13E7D90 Offset: 0x13E6390 VA: 0x1813E7D90
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextSecurityData : ICloneable // TypeDefIndex: 920
{
	// Fields
	private IPrincipal _principal; // 0x10

	// Properties
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x13C33E0 Offset: 0x13C19E0 VA: 0x1813C33E0
	internal bool get_HasInfo() { }

	// RVA: 0x13DD870 Offset: 0x13DBE70 VA: 0x1813DD870 Slot: 4
	public object Clone() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextRemotingData : ICloneable // TypeDefIndex: 921
{
	// Fields
	private string _logicalCallID; // 0x10

	// Properties
	internal string LogicalCallID { get; set; }
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string get_LogicalCallID() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_LogicalCallID(string value) { }

	// RVA: 0x13C33E0 Offset: 0x13C19E0 VA: 0x1813C33E0
	internal bool get_HasInfo() { }

	// RVA: 0x13DD800 Offset: 0x13DBE00 VA: 0x1813DD800 Slot: 4
	public object Clone() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal enum ArgInfoType // TypeDefIndex: 922
{
	// Fields
	public byte value__; // 0x0
	public const ArgInfoType In = 0;
	public const ArgInfoType Out = 1;
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ArgInfo // TypeDefIndex: 923
{
	// Fields
	private int[] _paramMap; // 0x10
	private int _inoutArgCount; // 0x18
	private MethodBase _method; // 0x20

	// Methods

	// RVA: 0x13D9A60 Offset: 0x13D8060 VA: 0x1813D9A60
	public void .ctor(MethodBase method, ArgInfoType type) { }

	// RVA: 0x13D9950 Offset: 0x13D7F50 VA: 0x1813D9950
	public object[] GetInOutArgs(object[] args) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 924
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x13D9EF0 Offset: 0x13D84F0 VA: 0x1813D9EF0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x13D9FF0 Offset: 0x13D85F0 VA: 0x1813D9FF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x13D9C30 Offset: 0x13D8230 VA: 0x1813D9C30 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x13D9C70 Offset: 0x13D8270 VA: 0x1813D9C70
	internal IMessage EndInvoke() { }

	// RVA: 0x13D9D70 Offset: 0x13D8370 VA: 0x1813D9D70 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x13D9D60 Offset: 0x13D8360 VA: 0x1813D9D60 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x13D9D60 Offset: 0x13D8360 VA: 0x1813D9D60
	internal object Invoke() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADArgHolder // TypeDefIndex: 925
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	public void .ctor(int i) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADObjRef // TypeDefIndex: 926
{
	// Fields
	internal ObjRef objref; // 0x10
	internal int SourceDomain; // 0x18
	internal byte[] TypeInfo; // 0x20

	// Methods

	// RVA: 0x13DD3A0 Offset: 0x13DB9A0 VA: 0x1813DD3A0
	public void .ctor(ObjRef o, int sourceDomain) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CADMethodRef // TypeDefIndex: 927
{
	// Fields
	private bool ctor; // 0x10
	private string typeName; // 0x18
	private string methodName; // 0x20
	private string[] param_names; // 0x28
	private string[] generic_arg_names; // 0x30

	// Methods

	// RVA: 0x13DC510 Offset: 0x13DAB10 VA: 0x1813DC510
	private Type[] GetTypes(string[] typeArray) { }

	// RVA: 0x13DC640 Offset: 0x13DAC40 VA: 0x1813DC640
	public MethodBase Resolve() { }

	// RVA: 0x13DCB40 Offset: 0x13DB140 VA: 0x1813DCB40
	public void .ctor(IMethodMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMessageBase // TypeDefIndex: 928
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x13DBF40 Offset: 0x13DA540 VA: 0x1813DBF40
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x13DA0E0 Offset: 0x13D86E0 VA: 0x1813DA0E0
	internal MethodBase GetMethod() { }

	// RVA: 0x13DA260 Offset: 0x13D8860 VA: 0x1813DA260
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x13DAA90 Offset: 0x13D9090 VA: 0x1813DAA90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x13DBDD0 Offset: 0x13DA3D0 VA: 0x1813DBDD0
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x13DA470 Offset: 0x13D8A70 VA: 0x1813DA470
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x13DA600 Offset: 0x13D8C00 VA: 0x1813DA600
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x13DB170 Offset: 0x13D9770 VA: 0x1813DB170
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x13DA970 Offset: 0x13D8F70 VA: 0x1813DA970
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x13DBCB0 Offset: 0x13DA2B0 VA: 0x1813DBCB0
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x13DAFB0 Offset: 0x13D95B0 VA: 0x1813DAFB0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x13DA050 Offset: 0x13D8650 VA: 0x1813DA050
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 929
{
	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal string get_Uri() { }

	// RVA: 0x13DBFF0 Offset: 0x13DA5F0 VA: 0x1813DBFF0
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x13DC240 Offset: 0x13DA840 VA: 0x1813DC240
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x13DC090 Offset: 0x13DA690 VA: 0x1813DC090
	internal ArrayList GetArguments() { }

	// RVA: 0x13DC080 Offset: 0x13DA680 VA: 0x1813DC080
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal int get_PropertiesCount() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 930
{
	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x13DCE00 Offset: 0x13DB400 VA: 0x1813DCE00
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x13DD110 Offset: 0x13DB710 VA: 0x1813DD110
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x13DCE90 Offset: 0x13DB490 VA: 0x1813DCE90
	internal ArrayList GetArguments() { }

	// RVA: 0x13DC080 Offset: 0x13DA680 VA: 0x1813DC080
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x13DD100 Offset: 0x13DB700 VA: 0x1813DD100
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x13DD040 Offset: 0x13DB640 VA: 0x1813DD040
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal int get_PropertiesCount() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 931
{
	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(Context ctx) { }

	// RVA: 0x13E0AA0 Offset: 0x13DF0A0 VA: 0x1813E0AA0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13E0860 Offset: 0x13DEE60 VA: 0x1813E0860 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 932
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0x8B6980 Offset: 0x8B4F80 VA: 0x1808B6980
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x13E07A0 Offset: 0x13DEDA0 VA: 0x1813E07A0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13E0760 Offset: 0x13DED60 VA: 0x1813E0760 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 933
{
	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x13E1BB0 Offset: 0x13E01B0 VA: 0x1813E1BB0
	internal void .ctor(Type type) { }

	// RVA: 0x13E1B00 Offset: 0x13E0100 VA: 0x1813E1B00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13E15D0 Offset: 0x13DFBD0 VA: 0x1813E15D0 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x534920 Offset: 0x532F20 VA: 0x180534920
	internal bool get_IsContextOk() { }

	// RVA: 0x534950 Offset: 0x532F50 VA: 0x180534950
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x13E1C30 Offset: 0x13E0230 VA: 0x1813E1C30 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x13E1CF0 Offset: 0x13E02F0 VA: 0x1813E1CF0 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x13E16D0 Offset: 0x13DFCD0 VA: 0x1813E16D0 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x13E1490 Offset: 0x13DFA90 VA: 0x1813E1490 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13E1D60 Offset: 0x13E0360 VA: 0x1813E1D60 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	internal void set_SourceProxy(RemotingProxy value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ConstructionCallDictionary : MessageDictionary // TypeDefIndex: 934
{
	// Fields
	public static string[] InternalKeys; // 0x0

	// Methods

	// RVA: 0x13E1400 Offset: 0x13DFA00 VA: 0x1813E1400
	public void .ctor(IConstructionCallMessage message) { }

	// RVA: 0x13E0C50 Offset: 0x13DF250 VA: 0x1813E0C50 Slot: 21
	protected override object GetMethodProperty(string key) { }

	// RVA: 0x13E0F90 Offset: 0x13DF590 VA: 0x1813E0F90 Slot: 22
	protected override void SetMethodProperty(string key, object value) { }

	// RVA: 0x13E11B0 Offset: 0x13DF7B0 VA: 0x1813E11B0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[CLSCompliant(False)]
[Serializable]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 935
{
	// Properties
	public override IDictionary Properties { get; }

	// Methods

	// RVA: 0x13E1E50 Offset: 0x13E0450 VA: 0x1813E1E50
	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x13E1F10 Offset: 0x13E0510 VA: 0x1813E1F10
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x13E1F20 Offset: 0x13E0520 VA: 0x1813E1F20
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13E1FC0 Offset: 0x13E05C0 VA: 0x1813E1FC0 Slot: 22
	public override IDictionary get_Properties() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class EnvoyTerminatorSink : IMessageSink // TypeDefIndex: 936
{
	// Fields
	public static EnvoyTerminatorSink Instance; // 0x0

	// Methods

	// RVA: 0x13E39D0 Offset: 0x13E1FD0 VA: 0x1813E39D0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13E3950 Offset: 0x13E1F50 VA: 0x1813E3950 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x13E3A30 Offset: 0x13E2030 VA: 0x1813E3A30
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 937
{
	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x13E3AA0 Offset: 0x13E20A0 VA: 0x1813E3AA0
	public void .ctor() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x13E3AF0 Offset: 0x13E20F0 VA: 0x1813E3AF0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x13E3B20 Offset: 0x13E2120 VA: 0x1813E3B20 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 11
	public string get_Uri() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public class Header // TypeDefIndex: 938
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public sealed class HeaderHandler : MulticastDelegate // TypeDefIndex: 939
{
	// Methods

	// RVA: 0x13D0380 Offset: 0x13CE980 VA: 0x1813D0380
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950 Slot: 13
	public virtual object Invoke(Header[] headers) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal interface IInternalMessage // TypeDefIndex: 940
{
	// Properties
	public abstract Identity TargetIdentity { get; set; }
	public abstract string Uri { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Identity get_TargetIdentity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_TargetIdentity(Identity value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Uri(string value);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessage // TypeDefIndex: 941
{
	// Properties
	public abstract IDictionary Properties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary get_Properties();
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessageCtrl // TypeDefIndex: 942
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessageSink // TypeDefIndex: 943
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodCallMessage : IMethodMessage, IMessage // TypeDefIndex: 944
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodMessage : IMessage // TypeDefIndex: 945
{
	// Properties
	public abstract int ArgCount { get; }
	public abstract object[] Args { get; }
	public abstract LogicalCallContext LogicalCallContext { get; }
	public abstract MethodBase MethodBase { get; }
	public abstract string MethodName { get; }
	public abstract object MethodSignature { get; }
	public abstract string TypeName { get; }
	public abstract string Uri { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ArgCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_Args();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract LogicalCallContext get_LogicalCallContext();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MethodBase get_MethodBase();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_MethodName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object get_MethodSignature();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArg(int argNum);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 946
{
	// Properties
	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_Exception();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_OutArgs();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_ReturnValue();
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 947
{
	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x13E1B00 Offset: 0x13E0100 VA: 0x1813E1B00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13EB240 Offset: 0x13E9840 VA: 0x1813EB240
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13E9F90 Offset: 0x13E8590 VA: 0x1813E9F90
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x13EA640 Offset: 0x13E8C40 VA: 0x1813EA640 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x13EA190 Offset: 0x13E8790 VA: 0x1813EA190 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x9A5750 Offset: 0x9A3D50 VA: 0x1809A5750 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x13EB5E0 Offset: 0x13E9BE0 VA: 0x1813EB5E0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x13EB650 Offset: 0x13E9C50 VA: 0x1813EB650 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x13EB680 Offset: 0x13E9C80 VA: 0x1813EB680 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x13EB6D0 Offset: 0x13E9CD0 VA: 0x1813EB6D0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x13E1D60 Offset: 0x13E0360 VA: 0x1813E1D60 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x13EA590 Offset: 0x13E8B90 VA: 0x1813EA590 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x13EB840 Offset: 0x13E9E40 VA: 0x1813EB840 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 11
	public string get_Uri() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Uri(string value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x13EA160 Offset: 0x13E8760 VA: 0x1813EA160 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 23
	public virtual void Init() { }

	// RVA: 0x13EAB30 Offset: 0x13E9130 VA: 0x1813EAB30
	public void ResolveMethod() { }

	// RVA: 0x13E9DA0 Offset: 0x13E83A0 VA: 0x1813E9DA0
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x13EA500 Offset: 0x13E8B00 VA: 0x1813EA500
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x13EB570 Offset: 0x13E9B70 VA: 0x1813EB570
	private Type[] get_GenericArguments() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class MCMDictionary : MessageDictionary // TypeDefIndex: 948
{
	// Fields
	public static string[] InternalKeys; // 0x0

	// Methods

	// RVA: 0x13E8420 Offset: 0x13E6A20 VA: 0x1813E8420
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x13E82A0 Offset: 0x13E68A0 VA: 0x1813E82A0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[DefaultMember("Item")]
[Serializable]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 950
{
	// Fields
	private IDictionary _internalProperties; // 0x10
	protected IMethodMessage _message; // 0x18
	private string[] _methodKeys; // 0x20
	private bool _ownProperties; // 0x28

	// Properties
	internal IDictionary InternalDictionary { get; }
	public string[] MethodKeys { set; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public object Item { get; set; }
	public ICollection Keys { get; }
	public ICollection Values { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x13E9320 Offset: 0x13E7920 VA: 0x1813E9320
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x13E8D00 Offset: 0x13E7300 VA: 0x1813E8D00
	internal bool HasUserData() { }

	// RVA: 0x13E93D0 Offset: 0x13E79D0 VA: 0x1813E93D0
	internal IDictionary get_InternalDictionary() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_MethodKeys(string[] value) { }

	// RVA: 0x13E8680 Offset: 0x13E6C80 VA: 0x1813E8680 Slot: 20
	protected virtual IDictionary AllocInternalProperties() { }

	// RVA: 0x13E88F0 Offset: 0x13E6EF0 VA: 0x1813E88F0
	public IDictionary GetInternalProperties() { }

	// RVA: 0x13E8DE0 Offset: 0x13E73E0 VA: 0x1813E8DE0
	private bool IsOverridenKey(string key) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x13E9480 Offset: 0x13E7A80 VA: 0x1813E9480 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x13E8530 Offset: 0x13E6B30 VA: 0x1813E8530 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x13E8940 Offset: 0x13E6F40 VA: 0x1813E8940 Slot: 21
	protected virtual object GetMethodProperty(string key) { }

	// RVA: 0x13E8F90 Offset: 0x13E7590 VA: 0x1813E8F90 Slot: 22
	protected virtual void SetMethodProperty(string key, object value) { }

	// RVA: 0x13E9590 Offset: 0x13E7B90 VA: 0x1813E9590 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x13E9970 Offset: 0x13E7F70 VA: 0x1813E9970 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x13E8530 Offset: 0x13E6B30 VA: 0x1813E8530 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x13E86D0 Offset: 0x13E6CD0 VA: 0x1813E86D0 Slot: 10
	public void Clear() { }

	// RVA: 0x13E8720 Offset: 0x13E6D20 VA: 0x1813E8720 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x13E8E60 Offset: 0x13E7460 VA: 0x1813E8E60 Slot: 14
	public void Remove(object key) { }

	// RVA: 0x13E9360 Offset: 0x13E7960 VA: 0x1813E9360 Slot: 16
	public int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x13E8810 Offset: 0x13E6E10 VA: 0x1813E8810 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x13E92C0 Offset: 0x13E78C0 VA: 0x1813E92C0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x13E8890 Offset: 0x13E6E90 VA: 0x1813E8890 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 951
{
	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x13EC270 Offset: 0x13EA870 VA: 0x1813EC270
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x13EC360 Offset: 0x13EA960 VA: 0x1813EC360
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x13EC430 Offset: 0x13EAA30 VA: 0x1813EC430
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x13E1F20 Offset: 0x13E0520 VA: 0x1813E1F20
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13EBC90 Offset: 0x13EA290 VA: 0x1813EBC90
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x13EC870 Offset: 0x13EAE70 VA: 0x1813EC870 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x13EC890 Offset: 0x13EAE90 VA: 0x1813EC890 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x13EC900 Offset: 0x13EAF00 VA: 0x1813EC900 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x13ECA60 Offset: 0x13EB060 VA: 0x1813ECA60 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x13ECAD0 Offset: 0x13EB0D0 VA: 0x1813ECAD0 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x13ECBB0 Offset: 0x13EB1B0 VA: 0x1813ECBB0 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x13E1FC0 Offset: 0x13E05C0 VA: 0x1813E1FC0 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x13ECDC0 Offset: 0x13EB3C0 VA: 0x1813ECDC0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x13EC200 Offset: 0x13EA800 VA: 0x1813EC200 Slot: 14
	public string get_Uri() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Uri(string value) { }

	// RVA: 0x13EC200 Offset: 0x13EA800 VA: 0x1813EC200 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x13EB8B0 Offset: 0x13E9EB0 VA: 0x1813EB8B0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x13EB8E0 Offset: 0x13E9EE0 VA: 0x1813EB8E0 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class MethodReturnDictionary : MessageDictionary // TypeDefIndex: 952
{
	// Fields
	public static string[] InternalReturnKeys; // 0x0
	public static string[] InternalExceptionKeys; // 0x8

	// Methods

	// RVA: 0x13ED040 Offset: 0x13EB640 VA: 0x1813ED040
	public void .ctor(IMethodReturnMessage message) { }

	// RVA: 0x13ECE30 Offset: 0x13EB430 VA: 0x1813ECE30
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 953
{
	// Fields
	private RuntimeMethodInfo method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Identity identity; // 0x68
	private Type[] methodSignature; // 0x70

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x13ED210 Offset: 0x13EB810 VA: 0x1813ED210
	internal void InitMessage(RuntimeMethodInfo method, object[] out_args) { }

	// RVA: 0x13ED880 Offset: 0x13EBE80 VA: 0x1813ED880
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x13ED740 Offset: 0x13EBD40 VA: 0x1813ED740
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x13ED150 Offset: 0x13EB750 VA: 0x1813ED150
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x13ED560 Offset: 0x13EBB60 VA: 0x1813ED560
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x13EDE00 Offset: 0x13EC400 VA: 0x1813EDE00 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x13ED950 Offset: 0x13EBF50 VA: 0x1813ED950 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x13EDA50 Offset: 0x13EC050 VA: 0x1813EDA50 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x13EDAB0 Offset: 0x13EC0B0 VA: 0x1813EDAB0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x13EDE70 Offset: 0x13EC470 VA: 0x1813EDE70 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 19
	public string get_Uri() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x13ED120 Offset: 0x13EB720 VA: 0x1813ED120 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x13EDC00 Offset: 0x13EC200 VA: 0x1813EDC00 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x13EDC60 Offset: 0x13EC260 VA: 0x1813EDC60 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x13ED9E0 Offset: 0x13EBFE0 VA: 0x1813ED9E0
	internal CallType get_CallType() { }

	// RVA: 0x13ED4E0 Offset: 0x13EBAE0 VA: 0x1813ED4E0
	public bool NeedsOutProcessing(out int outCount) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal enum CallType // TypeDefIndex: 954
{
	// Fields
	public int value__; // 0x0
	public const CallType Sync = 0;
	public const CallType BeginInvoke = 1;
	public const CallType EndInvoke = 2;
	public const CallType OneWay = 3;
}

// Namespace: System.Runtime.Remoting.Messaging
[Usage(64)]
[ComVisible(True)]
public class OneWayAttribute : Attribute // TypeDefIndex: 955
{}

// Namespace: System.Runtime.Remoting.Messaging
internal class RemotingSurrogate : ISerializationSurrogate // TypeDefIndex: 956
{
	// Methods

	// RVA: 0x13F4160 Offset: 0x13F2760 VA: 0x1813F4160 Slot: 6
	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x13F42A0 Offset: 0x13F28A0 VA: 0x1813F42A0 Slot: 7
	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ObjRefSurrogate : ISerializationSurrogate // TypeDefIndex: 957
{
	// Methods

	// RVA: 0x13EDEF0 Offset: 0x13EC4F0 VA: 0x1813EDEF0 Slot: 6
	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x13EE000 Offset: 0x13EC600 VA: 0x1813EE000 Slot: 7
	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 958
{
	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x13F3E90 Offset: 0x13F2490 VA: 0x1813F3E90 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x13F4030 Offset: 0x13F2630 VA: 0x1813F4030
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 959
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x13F43F0 Offset: 0x13F29F0 VA: 0x1813F43F0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x13F4310 Offset: 0x13F2910 VA: 0x1813F4310
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x965B90 Offset: 0x964190 VA: 0x180965B90 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x13F4500 Offset: 0x13F2B00 VA: 0x1813F4500 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x13F4570 Offset: 0x13F2B70 VA: 0x1813F4570 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x13F45D0 Offset: 0x13F2BD0 VA: 0x1813F45D0 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x13F4800 Offset: 0x13F2E00 VA: 0x1813F4800 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x13F4870 Offset: 0x13F2E70 VA: 0x1813F4870 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_Uri(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x13F42E0 Offset: 0x13F28E0 VA: 0x1813F42E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x13F4740 Offset: 0x13F2D40 VA: 0x1813F4740 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerContextTerminatorSink : IMessageSink // TypeDefIndex: 960
{
	// Methods

	// RVA: 0x13F5A50 Offset: 0x13F4050 VA: 0x1813F5A50 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13F5990 Offset: 0x13F3F90 VA: 0x1813F5990 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 961
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x13F5DE0 Offset: 0x13F43E0 VA: 0x1813F5DE0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13F5C40 Offset: 0x13F4240 VA: 0x1813F5C40 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 962
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0x8B6980 Offset: 0x8B4F80 VA: 0x1808B6980
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x13F5BC0 Offset: 0x13F41C0 VA: 0x1813F5BC0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13F5B80 Offset: 0x13F4180 VA: 0x1813F5B80 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class StackBuilderSink : IMessageSink // TypeDefIndex: 963
{
	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x13F70A0 Offset: 0x13F56A0 VA: 0x1813F70A0
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x13F6F90 Offset: 0x13F5590 VA: 0x1813F6F90 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13F64C0 Offset: 0x13F4AC0 VA: 0x1813F64C0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x13F69F0 Offset: 0x13F4FF0 VA: 0x1813F69F0
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x13F6610 Offset: 0x13F4C10 VA: 0x1813F6610
	private void CheckParameters(IMessage msg) { }

	[CompilerGenerated]
	// RVA: 0x13F7080 Offset: 0x13F5680 VA: 0x1813F7080
	private void <AsyncProcessMessage>b__4_0(object data) { }
}

