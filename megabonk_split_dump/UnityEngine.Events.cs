// Namespace: UnityEngine.Events
[Serializable]
public enum PersistentListenerMode // TypeDefIndex: 9843
{
	// Fields
	public int value__; // 0x0
	public const PersistentListenerMode EventDefined = 0;
	public const PersistentListenerMode Void = 1;
	public const PersistentListenerMode Object = 2;
	public const PersistentListenerMode Int = 3;
	public const PersistentListenerMode Float = 4;
	public const PersistentListenerMode String = 5;
	public const PersistentListenerMode Bool = 6;
}

// Namespace: UnityEngine.Events
internal class UnityEventTools // TypeDefIndex: 9844
{
	// Methods

	// RVA: 0x2369180 Offset: 0x2367780 VA: 0x182369180
	internal static string TidyAssemblyTypeName(string assemblyTypeName) { }
}

// Namespace: UnityEngine.Events
[Serializable]
internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 9845
{
	// Fields
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[FormerlySerializedAs("intArgument")]
	[SerializeField]
	private int m_IntArgument; // 0x20
	[SerializeField]
	[FormerlySerializedAs("floatArgument")]
	private float m_FloatArgument; // 0x24
	[FormerlySerializedAs("stringArgument")]
	[SerializeField]
	private string m_StringArgument; // 0x28
	[SerializeField]
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x101AB70 Offset: 0x1019170 VA: 0x18101AB70
	public Object get_unityObjectArgument() { }

	// RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0xA3D120 Offset: 0xA3B720 VA: 0x180A3D120
	public int get_intArgument() { }

	// RVA: 0x234CC70 Offset: 0x234B270 VA: 0x18234CC70
	public float get_floatArgument() { }

	// RVA: 0x234CC80 Offset: 0x234B280 VA: 0x18234CC80
	public string get_stringArgument() { }

	// RVA: 0x234CC60 Offset: 0x234B260 VA: 0x18234CC60
	public bool get_boolArgument() { }

	// RVA: 0x234CC30 Offset: 0x234B230 VA: 0x18234CC30 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x234CC30 Offset: 0x234B230 VA: 0x18234CC30 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall // TypeDefIndex: 9846
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x234CD50 Offset: 0x234B350 VA: 0x18234CD50
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B04B0 Offset: 0x6AEAB0 VA: 0x1806B04B0
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	|-BaseInvokableCall.ThrowOnInvalidArg<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x234CCC0 Offset: 0x234B2C0 VA: 0x18234CCC0
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);
}

// Namespace: UnityEngine.Events
internal class InvokableCall : BaseInvokableCall // TypeDefIndex: 9847
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction Delegate; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x2355310 Offset: 0x2353910 VA: 0x182355310
	private void add_Delegate(UnityAction value) { }

	[CompilerGenerated]
	// RVA: 0x23553B0 Offset: 0x23539B0 VA: 0x1823553B0
	private void remove_Delegate(UnityAction value) { }

	// RVA: 0x2355120 Offset: 0x2353720 VA: 0x182355120
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x23550F0 Offset: 0x23536F0 VA: 0x1823550F0
	public void .ctor(UnityAction action) { }

	// RVA: 0x2355040 Offset: 0x2353640 VA: 0x182355040 Slot: 4
	public override void Invoke(object[] args) { }

	// RVA: 0x2355040 Offset: 0x2353640 VA: 0x182355040
	public void Invoke() { }

	// RVA: 0x10C7320 Offset: 0x10C5920 VA: 0x1810C7320 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 9848
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityAction<T1> Delegate; // 0x0

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F7C0 Offset: 0xC8DDC0 VA: 0x180C8F7C0
	|-InvokableCall<bool>.add_Delegate
	|-InvokableCall<Color>.add_Delegate
	|-InvokableCall<int>.add_Delegate
	|-InvokableCall<Int32Enum>.add_Delegate
	|-InvokableCall<object>.add_Delegate
	|-InvokableCall<float>.add_Delegate
	|-InvokableCall<Vector2>.add_Delegate
	|-InvokableCall<__Il2CppFullySharedGenericType>.add_Delegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F890 Offset: 0xC8DE90 VA: 0x180C8F890
	|-InvokableCall<bool>.remove_Delegate
	|-InvokableCall<Color>.remove_Delegate
	|-InvokableCall<int>.remove_Delegate
	|-InvokableCall<Int32Enum>.remove_Delegate
	|-InvokableCall<object>.remove_Delegate
	|-InvokableCall<float>.remove_Delegate
	|-InvokableCall<Vector2>.remove_Delegate
	|-InvokableCall<__Il2CppFullySharedGenericType>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C7F50 Offset: 0x10C6550 VA: 0x1810C7F50
	|-InvokableCall<bool>..ctor
	|-InvokableCall<Color>..ctor
	|-InvokableCall<int>..ctor
	|-InvokableCall<Int32Enum>..ctor
	|-InvokableCall<object>..ctor
	|-InvokableCall<float>..ctor
	|-InvokableCall<Vector2>..ctor
	|
	|-RVA: 0x10C8040 Offset: 0x10C6640 VA: 0x1810C8040
	|-InvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C7F00 Offset: 0x10C6500 VA: 0x1810C7F00
	|-InvokableCall<bool>..ctor
	|-InvokableCall<Color>..ctor
	|-InvokableCall<int>..ctor
	|-InvokableCall<Int32Enum>..ctor
	|-InvokableCall<object>..ctor
	|-InvokableCall<float>..ctor
	|-InvokableCall<Vector2>..ctor
	|
	|-RVA: 0x10C8140 Offset: 0x10C6740 VA: 0x1810C8140
	|-InvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C7B70 Offset: 0x10C6170 VA: 0x1810C7B70
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x10C79F0 Offset: 0x10C5FF0 VA: 0x1810C79F0
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x10C7D90 Offset: 0x10C6390 VA: 0x1810C7D90
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x10C73E0 Offset: 0x10C59E0 VA: 0x1810C73E0
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x10C7740 Offset: 0x10C5D40 VA: 0x1810C7740
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x10C78C0 Offset: 0x10C5EC0 VA: 0x1810C78C0
	|-InvokableCall<Vector2>.Invoke
	|
	|-RVA: 0x10C7560 Offset: 0x10C5B60 VA: 0x1810C7560
	|-InvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C76F0 Offset: 0x10C5CF0 VA: 0x1810C76F0
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x10C7860 Offset: 0x10C5E60 VA: 0x1810C7860
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x10C7390 Offset: 0x10C5990 VA: 0x1810C7390
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x10C7510 Offset: 0x10C5B10 VA: 0x1810C7510
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x10C7EB0 Offset: 0x10C64B0 VA: 0x1810C7EB0
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x10C7B20 Offset: 0x10C6120 VA: 0x1810C7B20
	|-InvokableCall<Vector2>.Invoke
	|
	|-RVA: 0x10C7C90 Offset: 0x10C6290 VA: 0x1810C7C90
	|-InvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C7320 Offset: 0x10C5920 VA: 0x1810C7320
	|-InvokableCall<bool>.Find
	|-InvokableCall<Color>.Find
	|-InvokableCall<int>.Find
	|-InvokableCall<Int32Enum>.Find
	|-InvokableCall<object>.Find
	|-InvokableCall<float>.Find
	|-InvokableCall<Vector2>.Find
	|-InvokableCall<__Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2> : BaseInvokableCall // TypeDefIndex: 9849
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityAction<T1, T2> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C89B0 Offset: 0x10C6FB0 VA: 0x1810C89B0
	|-InvokableCall<int, bool>..ctor
	|-InvokableCall<int, float>..ctor
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C8600 Offset: 0x10C6C00 VA: 0x1810C8600
	|-InvokableCall<int, bool>.Invoke
	|
	|-RVA: 0x10C8440 Offset: 0x10C6A40 VA: 0x1810C8440
	|-InvokableCall<int, float>.Invoke
	|
	|-RVA: 0x10C81F0 Offset: 0x10C67F0 VA: 0x1810C81F0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 args0, T2 args1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C8190 Offset: 0x10C6790 VA: 0x1810C8190
	|-InvokableCall<int, bool>.Invoke
	|
	|-RVA: 0x10C8950 Offset: 0x10C6F50 VA: 0x1810C8950
	|-InvokableCall<int, float>.Invoke
	|
	|-RVA: 0x10C87B0 Offset: 0x10C6DB0 VA: 0x1810C87B0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C7320 Offset: 0x10C5920 VA: 0x1810C7320
	|-InvokableCall<int, bool>.Find
	|-InvokableCall<int, float>.Find
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3> : BaseInvokableCall // TypeDefIndex: 9850
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction<T1, T2, T3> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C89B0 Offset: 0x10C6FB0 VA: 0x1810C89B0
	|-InvokableCall<object, int, int>..ctor
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C9090 Offset: 0x10C7690 VA: 0x1810C9090
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x10C8D10 Offset: 0x10C7310 VA: 0x1810C8D10
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 args0, T2 args1, T3 args2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C9020 Offset: 0x10C7620 VA: 0x1810C9020
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x10C8AE0 Offset: 0x10C70E0 VA: 0x1810C8AE0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C7320 Offset: 0x10C5920 VA: 0x1810C7320
	|-InvokableCall<object, int, int>.Find
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall // TypeDefIndex: 9851
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityAction<T1, T2, T3, T4> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C89B0 Offset: 0x10C6FB0 VA: 0x1810C89B0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C92E0 Offset: 0x10C78E0 VA: 0x1810C92E0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C7320 Offset: 0x10C5920 VA: 0x1810C7320
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class CachedInvokableCall<T> : InvokableCall<T> // TypeDefIndex: 9852
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Object target, MethodInfo theFunction, T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8D580 Offset: 0xC8BB80 VA: 0x180C8D580
	|-CachedInvokableCall<bool>..ctor
	|
	|-RVA: 0xC8D6E0 Offset: 0xC8BCE0 VA: 0x180C8D6E0
	|-CachedInvokableCall<int>..ctor
	|
	|-RVA: 0xC8D530 Offset: 0xC8BB30 VA: 0x180C8D530
	|-CachedInvokableCall<object>..ctor
	|
	|-RVA: 0xC8D5C0 Offset: 0xC8BBC0 VA: 0x180C8D5C0
	|-CachedInvokableCall<float>..ctor
	|
	|-RVA: 0xC8D600 Offset: 0xC8BC00 VA: 0x180C8D600
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8D380 Offset: 0xC8B980 VA: 0x180C8D380
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0xC8D4D0 Offset: 0xC8BAD0 VA: 0x180C8D4D0
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0xC8D500 Offset: 0xC8BB00 VA: 0x180C8D500
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0xC8D3B0 Offset: 0xC8B9B0 VA: 0x180C8D3B0
	|-CachedInvokableCall<float>.Invoke
	|
	|-RVA: 0xC8D3E0 Offset: 0xC8B9E0 VA: 0x180C8D3E0
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8D380 Offset: 0xC8B980 VA: 0x180C8D380
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0xC8D4D0 Offset: 0xC8BAD0 VA: 0x180C8D4D0
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0xC8D500 Offset: 0xC8BB00 VA: 0x180C8D500
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0xC8D3B0 Offset: 0xC8B9B0 VA: 0x180C8D3B0
	|-CachedInvokableCall<float>.Invoke
	|
	|-RVA: 0xC8D3E0 Offset: 0xC8B9E0 VA: 0x180C8D3E0
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public enum UnityEventCallState // TypeDefIndex: 9853
{
	// Fields
	public int value__; // 0x0
	public const UnityEventCallState Off = 0;
	public const UnityEventCallState EditorAndRuntime = 1;
	public const UnityEventCallState RuntimeOnly = 2;
}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCall : ISerializationCallbackReceiver // TypeDefIndex: 9854
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("instance")]
	private Object m_Target; // 0x10
	[SerializeField]
	private string m_TargetAssemblyTypeName; // 0x18
	[SerializeField]
	[FormerlySerializedAs("methodName")]
	private string m_MethodName; // 0x20
	[SerializeField]
	[FormerlySerializedAs("mode")]
	private PersistentListenerMode m_Mode; // 0x28
	[SerializeField]
	[FormerlySerializedAs("arguments")]
	private ArgumentCache m_Arguments; // 0x30
	[SerializeField]
	[FormerlySerializedAs("m_Enabled")]
	[FormerlySerializedAs("enabled")]
	private UnityEventCallState m_CallState; // 0x38

	// Properties
	public Object target { get; }
	public string targetAssemblyTypeName { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x101AB70 Offset: 0x1019170 VA: 0x18101AB70
	public Object get_target() { }

	// RVA: 0x2358D30 Offset: 0x2357330 VA: 0x182358D30
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x2358D20 Offset: 0x2357320 VA: 0x182358D20
	public string get_methodName() { }

	// RVA: 0xA3D1A0 Offset: 0xA3B7A0 VA: 0x180A3D1A0
	public PersistentListenerMode get_mode() { }

	// RVA: 0x2358D10 Offset: 0x2357310 VA: 0x182358D10
	public ArgumentCache get_arguments() { }

	// RVA: 0x2358C50 Offset: 0x2357250 VA: 0x182358C50
	public bool IsValid() { }

	// RVA: 0x2358940 Offset: 0x2356F40 VA: 0x182358940
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x2358430 Offset: 0x2356A30 VA: 0x182358430
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x234CC30 Offset: 0x234B230 VA: 0x18234CC30 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x234CC30 Offset: 0x234B230 VA: 0x18234CC30 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2358C90 Offset: 0x2357290 VA: 0x182358C90
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCallGroup // TypeDefIndex: 9855
{
	// Fields
	[FormerlySerializedAs("m_Listeners")]
	[SerializeField]
	private List<PersistentCall> m_Calls; // 0x10

	// Methods

	// RVA: 0x23583B0 Offset: 0x23569B0 VA: 0x1823583B0
	public void .ctor() { }

	// RVA: 0x2358210 Offset: 0x2356810 VA: 0x182358210
	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }
}

// Namespace: UnityEngine.Events
internal class InvokableCallList // TypeDefIndex: 9856
{
	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x2354AD0 Offset: 0x23530D0 VA: 0x182354AD0
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x2354A10 Offset: 0x2353010 VA: 0x182354A10
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x2354D00 Offset: 0x2353300 VA: 0x182354D00
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2354B90 Offset: 0x2353190 VA: 0x182354B90
	public void ClearPersistent() { }

	// RVA: 0x2354C50 Offset: 0x2353250 VA: 0x182354C50
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2354F60 Offset: 0x2353560 VA: 0x182354F60
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
[UsedByNativeCode]
[Serializable]
public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 9857
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAs("m_PersistentListeners")]
	[SerializeField]
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x2368FC0 Offset: 0x23675C0 VA: 0x182368FC0
	protected void .ctor() { }

	// RVA: 0x2368FB0 Offset: 0x23675B0 VA: 0x182368FB0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2368FB0 Offset: 0x23675B0 VA: 0x182368FB0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x23686B0 Offset: 0x2366CB0 VA: 0x1823686B0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x2368880 Offset: 0x2366E80 VA: 0x182368880
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x23685D0 Offset: 0x2366BD0 VA: 0x1823685D0
	private void DirtyPersistentCalls() { }

	// RVA: 0x2368EC0 Offset: 0x23674C0 VA: 0x182368EC0
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x2368510 Offset: 0x2366B10 VA: 0x182368510
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x2368F00 Offset: 0x2367500 VA: 0x182368F00
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2368DE0 Offset: 0x23673E0 VA: 0x182368DE0
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2368F20 Offset: 0x2367520 VA: 0x182368F20 Slot: 3
	public override string ToString() { }

	// RVA: 0x2368C00 Offset: 0x2367200 VA: 0x182368C00
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }
}

// Namespace: UnityEngine.Events
public sealed class UnityAction : MulticastDelegate // TypeDefIndex: 9858
{
	// Methods

	// RVA: 0x3B5700 Offset: 0x3B3D00 VA: 0x1803B5700
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x345000 Offset: 0x343600 VA: 0x180345000 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent : UnityEventBase // TypeDefIndex: 9859
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2369870 Offset: 0x2367E70 VA: 0x182369870
	public void .ctor() { }

	// RVA: 0x2369360 Offset: 0x2367960 VA: 0x182369360
	public void AddListener(UnityAction call) { }

	// RVA: 0x2369820 Offset: 0x2367E20 VA: 0x182369820
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x2369470 Offset: 0x2367A70 VA: 0x182369470 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x23694D0 Offset: 0x2367AD0 VA: 0x1823694D0 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x2369540 Offset: 0x2367B40 VA: 0x182369540
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x23695A0 Offset: 0x2367BA0 VA: 0x1823695A0
	public void Invoke() { }
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 9860
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EE7D0 Offset: 0x5ECDD0 VA: 0x1805EE7D0
	|-UnityAction<bool>..ctor
	|
	|-RVA: 0xAC80F0 Offset: 0xAC66F0 VA: 0x180AC80F0
	|-UnityAction<Color>..ctor
	|
	|-RVA: 0x5C3AF0 Offset: 0x5C20F0 VA: 0x1805C3AF0
	|-UnityAction<int>..ctor
	|-UnityAction<Int32Enum>..ctor
	|
	|-RVA: 0xAC7F30 Offset: 0xAC6530 VA: 0x180AC7F30
	|-UnityAction<object>..ctor
	|
	|-RVA: 0xAC8040 Offset: 0xAC6640 VA: 0x180AC8040
	|-UnityAction<Scene>..ctor
	|
	|-RVA: 0xAC8370 Offset: 0xAC6970 VA: 0x180AC8370
	|-UnityAction<float>..ctor
	|
	|-RVA: 0xAC82C0 Offset: 0xAC68C0 VA: 0x180AC82C0
	|-UnityAction<Vector2>..ctor
	|
	|-RVA: 0xAC81A0 Offset: 0xAC67A0 VA: 0x180AC81A0
	|-UnityAction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0
	|-UnityAction<bool>.Invoke
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|-UnityAction<object>.Invoke
	|-UnityAction<Scene>.Invoke
	|-UnityAction<float>.Invoke
	|-UnityAction<Vector2>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0xAC7F00 Offset: 0xAC6500 VA: 0x180AC7F00
	|-UnityAction<Color>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 9861
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAB00 Offset: 0xAC9100 VA: 0x180ACAB00
	|-UnityEvent<bool>..ctor
	|-UnityEvent<Color>..ctor
	|-UnityEvent<int>..ctor
	|-UnityEvent<Int32Enum>..ctor
	|-UnityEvent<object>..ctor
	|-UnityEvent<float>..ctor
	|-UnityEvent<Vector2>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8A40 Offset: 0xAC7040 VA: 0x180AC8A40
	|-UnityEvent<bool>.AddListener
	|-UnityEvent<Color>.AddListener
	|-UnityEvent<int>.AddListener
	|-UnityEvent<Int32Enum>.AddListener
	|-UnityEvent<object>.AddListener
	|-UnityEvent<float>.AddListener
	|-UnityEvent<Vector2>.AddListener
	|
	|-RVA: 0xAC8B00 Offset: 0xAC7100 VA: 0x180AC8B00
	|-UnityEvent<__Il2CppFullySharedGenericType>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAAB0 Offset: 0xAC90B0 VA: 0x180ACAAB0
	|-UnityEvent<bool>.RemoveListener
	|-UnityEvent<Color>.RemoveListener
	|-UnityEvent<int>.RemoveListener
	|-UnityEvent<Int32Enum>.RemoveListener
	|-UnityEvent<object>.RemoveListener
	|-UnityEvent<float>.RemoveListener
	|-UnityEvent<Vector2>.RemoveListener
	|-UnityEvent<__Il2CppFullySharedGenericType>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8E60 Offset: 0xAC7460 VA: 0x180AC8E60
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0xAC9060 Offset: 0xAC7660 VA: 0x180AC9060
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0xAC8B60 Offset: 0xAC7160 VA: 0x180AC8B60
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0xAC9160 Offset: 0xAC7760 VA: 0x180AC9160
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|
	|-RVA: 0xAC8F60 Offset: 0xAC7560 VA: 0x180AC8F60
	|-UnityEvent<object>.FindMethod_Impl
	|
	|-RVA: 0xAC8C60 Offset: 0xAC7260 VA: 0x180AC8C60
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0xAC9260 Offset: 0xAC7860 VA: 0x180AC9260
	|-UnityEvent<Vector2>.FindMethod_Impl
	|
	|-RVA: 0xAC8D60 Offset: 0xAC7360 VA: 0x180AC8D60
	|-UnityEvent<__Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC93E0 Offset: 0xAC79E0 VA: 0x180AC93E0
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	|
	|-RVA: 0xAC9360 Offset: 0xAC7960 VA: 0x180AC9360
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9460 Offset: 0xAC7A60 VA: 0x180AC9460
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	|
	|-RVA: 0xAC94F0 Offset: 0xAC7AF0 VA: 0x180AC94F0
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC98D0 Offset: 0xAC7ED0 VA: 0x180AC98D0
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0xAC9DC0 Offset: 0xAC83C0 VA: 0x180AC9DC0
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0xACA820 Offset: 0xAC8E20 VA: 0x180ACA820
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0xACA590 Offset: 0xAC8B90 VA: 0x180ACA590
	|-UnityEvent<Int32Enum>.Invoke
	|
	|-RVA: 0xAC9B60 Offset: 0xAC8160 VA: 0x180AC9B60
	|-UnityEvent<object>.Invoke
	|
	|-RVA: 0xACA300 Offset: 0xAC8900 VA: 0x180ACA300
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0xACA060 Offset: 0xAC8660 VA: 0x180ACA060
	|-UnityEvent<Vector2>.Invoke
	|
	|-RVA: 0xAC95B0 Offset: 0xAC7BB0 VA: 0x180AC95B0
	|-UnityEvent<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 9862
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8580 Offset: 0xAC6B80 VA: 0x180AC8580
	|-UnityAction<int, bool>..ctor
	|
	|-RVA: 0xAC8420 Offset: 0xAC6A20 VA: 0x180AC8420
	|-UnityAction<int, float>..ctor
	|
	|-RVA: 0xAC8630 Offset: 0xAC6C30 VA: 0x180AC8630
	|-UnityAction<Scene, Int32Enum>..ctor
	|
	|-RVA: 0xAC84D0 Offset: 0xAC6AD0 VA: 0x180AC84D0
	|-UnityAction<Scene, Scene>..ctor
	|
	|-RVA: 0x8DB990 Offset: 0x8D9F90 VA: 0x1808DB990
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0
	|-UnityAction<int, bool>.Invoke
	|-UnityAction<int, float>.Invoke
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, Scene>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 9863
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAB00 Offset: 0xAC9100 VA: 0x180ACAB00
	|-UnityEvent<int, bool>..ctor
	|-UnityEvent<int, float>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAB30 Offset: 0xAC9130 VA: 0x180ACAB30
	|-UnityEvent<int, bool>.FindMethod_Impl
	|
	|-RVA: 0xACACA0 Offset: 0xAC92A0 VA: 0x180ACACA0
	|-UnityEvent<int, float>.FindMethod_Impl
	|
	|-RVA: 0xACAE10 Offset: 0xAC9410 VA: 0x180ACAE10
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACB000 Offset: 0xAC9600 VA: 0x180ACB000
	|-UnityEvent<int, bool>.GetDelegate
	|-UnityEvent<int, float>.GetDelegate
	|
	|-RVA: 0xACAF80 Offset: 0xAC9580 VA: 0x180ACAF80
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACB830 Offset: 0xAC9E30 VA: 0x180ACB830
	|-UnityEvent<int, bool>.Invoke
	|
	|-RVA: 0xACB500 Offset: 0xAC9B00 VA: 0x180ACB500
	|-UnityEvent<int, float>.Invoke
	|
	|-RVA: 0xACB080 Offset: 0xAC9680 VA: 0x180ACB080
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 9864
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8800 Offset: 0xAC6E00 VA: 0x180AC8800
	|-UnityAction<object, int, int>..ctor
	|
	|-RVA: 0xAC86E0 Offset: 0xAC6CE0 VA: 0x180AC86E0
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5976A0 Offset: 0x595CA0 VA: 0x1805976A0
	|-UnityAction<object, int, int>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 9865
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAB00 Offset: 0xAC9100 VA: 0x180ACAB00
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACBB60 Offset: 0xACA160 VA: 0x180ACBB60
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|
	|-RVA: 0xACC2F0 Offset: 0xACA8F0 VA: 0x180ACC2F0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACBD30 Offset: 0xACA330 VA: 0x180ACBD30
	|-UnityEvent<object, int, int>.GetDelegate
	|
	|-RVA: 0xACC4C0 Offset: 0xACAAC0 VA: 0x180ACC4C0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACBDB0 Offset: 0xACA3B0 VA: 0x180ACBDB0
	|-UnityEvent<object, int, int>.Invoke
	|
	|-RVA: 0xACC540 Offset: 0xACAB40 VA: 0x180ACC540
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 9866
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8920 Offset: 0xAC6F20 VA: 0x180AC8920
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x597410 Offset: 0x595A10 VA: 0x180597410
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 9867
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAB00 Offset: 0xAC9100 VA: 0x180ACAB00
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACCB40 Offset: 0xACB140 VA: 0x180ACCB40
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9360 Offset: 0xAC7960 VA: 0x180AC9360
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/
}

