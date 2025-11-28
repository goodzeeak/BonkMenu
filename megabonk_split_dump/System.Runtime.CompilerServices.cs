// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
public sealed class AsyncMethodBuilderAttribute : Attribute // TypeDefIndex: 1122
{
	// Fields
	[CompilerGenerated]
	private readonly Type <BuilderType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type builderType) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class AsyncStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 1123
{
	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type stateMachineType) { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncValueTaskMethodBuilder // TypeDefIndex: 1124
{
	// Fields
	private AsyncTaskMethodBuilder _methodBuilder; // 0x0
	private bool _haveResult; // 0x18
	private bool _useBuilder; // 0x19
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 1125
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC284D0 Offset: 0xC26AD0 VA: 0x180C284D0
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0xC283F0 Offset: 0xC269F0 VA: 0x180C283F0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FD5E0 Offset: 0x5FBBE0 VA: 0x1805FD5E0
	|-AsyncValueTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x5FD550 Offset: 0x5FBB50 VA: 0x1805FD550
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x5FD470 Offset: 0x5FBA70 VA: 0x1805FD470
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC28AF0 Offset: 0xC270F0 VA: 0x180C28AF0
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0xC289F0 Offset: 0xC26FF0 VA: 0x180C289F0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC28680 Offset: 0xC26C80 VA: 0x180C28680
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0xC28730 Offset: 0xC26D30 VA: 0x180C28730
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC285E0 Offset: 0xC26BE0 VA: 0x180C285E0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0xC284E0 Offset: 0xC26AE0 VA: 0x180C284E0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC28ED0 Offset: 0xC274D0 VA: 0x180C28ED0
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0xC28B80 Offset: 0xC27180 VA: 0x180C28B80
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FD200 Offset: 0x5FB800 VA: 0x1805FD200
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x5FD160 Offset: 0x5FB760 VA: 0x1805FD160
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x5FD2A0 Offset: 0x5FB8A0 VA: 0x1805FD2A0
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x5FD340 Offset: 0x5FB940 VA: 0x1805FD340
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(2048, Inherited = False)]
public sealed class CallerMemberNameAttribute : Attribute // TypeDefIndex: 1126
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(32767, Inherited = True)]
[Serializable]
public sealed class CompilerGeneratedAttribute : Attribute // TypeDefIndex: 1127
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable // TypeDefIndex: 1129
{
	// Fields
	private readonly ValueTask _value; // 0x0

	// Methods

	// RVA: 0xB02430 Offset: 0xB00A30 VA: 0x180B02430
	internal void .ctor(ValueTask value) { }

	// RVA: 0x1414E90 Offset: 0x1413490 VA: 0x181414E90
	public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable<TResult> // TypeDefIndex: 1131
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02430 Offset: 0xB00A30 VA: 0x180B02430
	|-ConfiguredValueTaskAwaitable<int>..ctor
	|
	|-RVA: 0xB02360 Offset: 0xB00960 VA: 0x180B02360
	|-ConfiguredValueTaskAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03670 Offset: 0xB01C70 VA: 0x180B03670
	|-ConfiguredValueTaskAwaitable<int>.GetAwaiter
	|
	|-RVA: 0xD26280 Offset: 0xD24880 VA: 0x180D26280
	|-ConfiguredValueTaskAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public abstract class CustomConstantAttribute : Attribute // TypeDefIndex: 1132
{
	// Properties
	public abstract object Value { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract object get_Value();

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute // TypeDefIndex: 1133
{
	// Fields
	private DateTime _date; // 0x10

	// Properties
	public override object Value { get; }

	// Methods

	// RVA: 0x1415580 Offset: 0x1413B80 VA: 0x181415580 Slot: 7
	public override object get_Value() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public sealed class DecimalConstantAttribute : Attribute // TypeDefIndex: 1134
{
	// Fields
	private Decimal _dec; // 0x10

	// Properties
	public Decimal Value { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x14155D0 Offset: 0x1413BD0 VA: 0x1814155D0
	public void .ctor(byte scale, byte sign, uint hi, uint mid, uint low) { }

	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public Decimal get_Value() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(69)]
public sealed class ExtensionAttribute : Attribute // TypeDefIndex: 1135
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(256, Inherited = False)]
public sealed class FixedBufferAttribute : Attribute // TypeDefIndex: 1136
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ElementType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; // 0x18

	// Properties
	public Type ElementType { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	public void .ctor(Type elementType, int length) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Length() { }
}

// Namespace: System.Runtime.CompilerServices
public static class FormattableStringFactory // TypeDefIndex: 1138
{
	// Methods

	// RVA: 0x14174E0 Offset: 0x1415AE0 VA: 0x1814174E0
	public static FormattableString Create(string format, object[] arguments) { }
}

// Namespace: System.Runtime.CompilerServices
public interface IAsyncStateMachine // TypeDefIndex: 1139
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetStateMachine(IAsyncStateMachine stateMachine);
}

// Namespace: System.Runtime.CompilerServices
public interface ICriticalNotifyCompletion // TypeDefIndex: 1140
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UnsafeOnCompleted(Action continuation);
}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
public interface ITuple // TypeDefIndex: 1141
{
	// Properties
	public abstract int Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();
}

// Namespace: System.Runtime.CompilerServices
[Usage(364, Inherited = False)]
internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 1142
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(8)]
public sealed class IsByRefLikeAttribute : Attribute // TypeDefIndex: 1143
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(32767, Inherited = False)]
public sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 1144
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
public static class IsVolatile // TypeDefIndex: 1145
{}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class IteratorStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 1146
{
	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type stateMachineType) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class RuntimeCompatibilityAttribute : Attribute // TypeDefIndex: 1147
{
	// Fields
	[CompilerGenerated]
	private bool <WrapNonExceptionThrows>k__BackingField; // 0x10

	// Properties
	public bool WrapNonExceptionThrows { set; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_WrapNonExceptionThrows(bool value) { }
}

// Namespace: System.Runtime.CompilerServices
public static class RuntimeFeature // TypeDefIndex: 1148
{
	// Properties
	public static bool IsDynamicCodeSupported { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool get_IsDynamicCodeSupported() { }
}

// Namespace: System.Runtime.CompilerServices
[Serializable]
public sealed class RuntimeWrappedException : Exception // TypeDefIndex: 1149
{
	// Fields
	private object _wrappedException; // 0x90

	// Properties
	public object WrappedException { get; }

	// Methods

	// RVA: 0x1423A00 Offset: 0x1422000 VA: 0x181423A00
	public void .ctor(object thrownObject) { }

	// RVA: 0x1423920 Offset: 0x1421F20 VA: 0x181423920
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1423830 Offset: 0x1421E30 VA: 0x181423830 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public object get_WrappedException() { }

	// RVA: 0x14238F0 Offset: 0x1421EF0 VA: 0x1814238F0
	internal void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public class StateMachineAttribute : Attribute // TypeDefIndex: 1150
{
	// Fields
	[CompilerGenerated]
	private readonly Type <StateMachineType>k__BackingField; // 0x10

	// Properties
	public Type StateMachineType { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type stateMachineType) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_StateMachineType() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, Inherited = False)]
[Serializable]
public sealed class StringFreezingAttribute : Attribute // TypeDefIndex: 1151
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(3)]
public sealed class SuppressIldasmAttribute : Attribute // TypeDefIndex: 1152
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CLSCompliant(False)]
[Usage(11148)]
public sealed class TupleElementNamesAttribute : Attribute // TypeDefIndex: 1153
{
	// Fields
	private readonly string[] _transformNames; // 0x10

	// Methods

	// RVA: 0x1425240 Offset: 0x1423840 VA: 0x181425240
	public void .ctor(string[] transformNames) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
public sealed class TypeForwardedFromAttribute : Attribute // TypeDefIndex: 1154
{
	// Fields
	[CompilerGenerated]
	private readonly string <AssemblyFullName>k__BackingField; // 0x10

	// Properties
	public string AssemblyFullName { get; }

	// Methods

	// RVA: 0x1425340 Offset: 0x1423940 VA: 0x181425340
	public void .ctor(string assemblyFullName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_AssemblyFullName() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(8)]
[Serializable]
public sealed class UnsafeValueTypeAttribute : Attribute // TypeDefIndex: 1155
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 1157
{
	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xB02430 Offset: 0xB00A30 VA: 0x180B02430
	internal void .ctor(ValueTask value) { }

	// RVA: 0x1426030 Offset: 0x1424630 VA: 0x181426030
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x1425CE0 Offset: 0x14242E0 VA: 0x181425CE0
	public void GetResult() { }

	// RVA: 0x1425D30 Offset: 0x1424330 VA: 0x181425D30 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x1425F60 Offset: 0x1424560 VA: 0x181425F60
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 1158
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02430 Offset: 0xB00A30 VA: 0x180B02430
	|-ValueTaskAwaiter<int>..ctor
	|
	|-RVA: 0xB02360 Offset: 0xB00960 VA: 0x180B02360
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB024F0 Offset: 0xB00AF0 VA: 0x180B024F0
	|-ValueTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0xB02440 Offset: 0xB00A40 VA: 0x180B02440
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB01D00 Offset: 0xB00300 VA: 0x180B01D00
	|-ValueTaskAwaiter<int>.GetResult
	|
	|-RVA: 0xB01D40 Offset: 0xB00340 VA: 0x180B01D40
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB01E60 Offset: 0xB00460 VA: 0x180B01E60
	|-ValueTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0xB02050 Offset: 0xB00650 VA: 0x180B02050
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 1160
{
	// Fields
	internal readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	internal void .ctor(Task task) { }

	// RVA: 0x9CCD50 Offset: 0x9CB350 VA: 0x1809CCD50
	public bool get_IsCompleted() { }

	// RVA: 0x1425140 Offset: 0x1423740 VA: 0x181425140 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x1414CC0 Offset: 0x14132C0 VA: 0x181414CC0
	public void GetResult() { }

	[StackTraceHidden]
	// RVA: 0x14251F0 Offset: 0x14237F0 VA: 0x1814251F0
	internal static void ValidateEnd(Task task) { }

	[StackTraceHidden]
	// RVA: 0x1424B90 Offset: 0x1423190 VA: 0x181424B90
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	[StackTraceHidden]
	// RVA: 0x1424FE0 Offset: 0x14235E0 VA: 0x181424FE0
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0x1424D20 Offset: 0x1423320 VA: 0x181424D20
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x1424DF0 Offset: 0x14233F0 VA: 0x181424DF0
	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 1161
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	|-TaskAwaiter<Nullable<bool>>..ctor
	|-TaskAwaiter<Nullable<DateTime>>..ctor
	|-TaskAwaiter<Nullable<DateTimeOffset>>..ctor
	|-TaskAwaiter<Nullable<Decimal>>..ctor
	|-TaskAwaiter<Nullable<double>>..ctor
	|-TaskAwaiter<Nullable<int>>..ctor
	|-TaskAwaiter<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|-TaskAwaiter<ValueTuple<bool, object>>..ctor
	|-TaskAwaiter<ValueTuple<object, object, int>>..ctor
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskAwaiter<bool>..ctor
	|-TaskAwaiter<char>..ctor
	|-TaskAwaiter<int>..ctor
	|-TaskAwaiter<long>..ctor
	|-TaskAwaiter<object>..ctor
	|-TaskAwaiter<SceneInstance>..ctor
	|-TaskAwaiter<VoidTaskResult>..ctor
	|-TaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CCD50 Offset: 0x9CB350 VA: 0x1809CCD50
	|-TaskAwaiter<Nullable<bool>>.get_IsCompleted
	|-TaskAwaiter<Nullable<DateTime>>.get_IsCompleted
	|-TaskAwaiter<Nullable<DateTimeOffset>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Decimal>>.get_IsCompleted
	|-TaskAwaiter<Nullable<double>>.get_IsCompleted
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|-TaskAwaiter<LocalizedDatabase.TableEntryResult<object, object>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|-TaskAwaiter<bool>.get_IsCompleted
	|-TaskAwaiter<char>.get_IsCompleted
	|-TaskAwaiter<int>.get_IsCompleted
	|-TaskAwaiter<long>.get_IsCompleted
	|-TaskAwaiter<object>.get_IsCompleted
	|-TaskAwaiter<SceneInstance>.get_IsCompleted
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CCD30 Offset: 0x9CB330 VA: 0x1809CCD30
	|-TaskAwaiter<Nullable<bool>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<DateTime>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<DateTimeOffset>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Decimal>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<double>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-TaskAwaiter<LocalizedDatabase.TableEntryResult<object, object>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|-TaskAwaiter<char>.UnsafeOnCompleted
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|-TaskAwaiter<long>.UnsafeOnCompleted
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|-TaskAwaiter<SceneInstance>.UnsafeOnCompleted
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CCAC0 Offset: 0x9CB0C0 VA: 0x1809CCAC0
	|-TaskAwaiter<Nullable<bool>>.GetResult
	|-TaskAwaiter<char>.GetResult
	|
	|-RVA: 0x9CC9A0 Offset: 0x9CAFA0 VA: 0x1809CC9A0
	|-TaskAwaiter<Nullable<DateTime>>.GetResult
	|-TaskAwaiter<Nullable<double>>.GetResult
	|-TaskAwaiter<LocalizedDatabase.TableEntryResult<object, object>>.GetResult
	|-TaskAwaiter<ValueTuple<bool, object>>.GetResult
	|-TaskAwaiter<SceneInstance>.GetResult
	|
	|-RVA: 0x9CCA50 Offset: 0x9CB050 VA: 0x1809CCA50
	|-TaskAwaiter<Nullable<DateTimeOffset>>.GetResult
	|-TaskAwaiter<Nullable<Decimal>>.GetResult
	|-TaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x9CCA00 Offset: 0x9CB000 VA: 0x1809CCA00
	|-TaskAwaiter<Nullable<int>>.GetResult
	|-TaskAwaiter<long>.GetResult
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x9CCCC0 Offset: 0x9CB2C0 VA: 0x1809CCCC0
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x9CCC20 Offset: 0x9CB220 VA: 0x1809CCC20
	|-TaskAwaiter<bool>.GetResult
	|-TaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x9CCC70 Offset: 0x9CB270 VA: 0x1809CCC70
	|-TaskAwaiter<int>.GetResult
	|
	|-RVA: 0x9CCB10 Offset: 0x9CB110 VA: 0x1809CCB10
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable // TypeDefIndex: 1163
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: 0x1414C70 Offset: 0x1413270 VA: 0x181414C70
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1165
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2A910 Offset: 0xD28F10 VA: 0x180D2A910
	|-ConfiguredTaskAwaitable<Nullable<bool>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<DateTime>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<DateTimeOffset>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Decimal>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<double>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>..ctor
	|-ConfiguredTaskAwaitable<bool>..ctor
	|-ConfiguredTaskAwaitable<char>..ctor
	|-ConfiguredTaskAwaitable<int>..ctor
	|-ConfiguredTaskAwaitable<long>..ctor
	|-ConfiguredTaskAwaitable<object>..ctor
	|-ConfiguredTaskAwaitable<SceneInstance>..ctor
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	|-ConfiguredTaskAwaitable<Nullable<bool>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<DateTime>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<DateTimeOffset>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Decimal>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<double>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<LocalizedDatabase.TableEntryResult<object, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|-ConfiguredTaskAwaitable<char>.GetAwaiter
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|-ConfiguredTaskAwaitable<long>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<SceneInstance>.GetAwaiter
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
internal class ReflectionBlockedAttribute : Attribute // TypeDefIndex: 1166
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncVoidMethodBuilder // TypeDefIndex: 1167
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	internal Task Task { get; }

	// Methods

	// RVA: 0x1414660 Offset: 0x1412C60 VA: 0x181414660
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F9F90 Offset: 0x5F8590 VA: 0x1805F9F90
	|-AsyncVoidMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6664C0 Offset: 0x664AC0 VA: 0x1806664C0
	|-AsyncVoidMethodBuilder.Start<FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x666580 Offset: 0x664B80 VA: 0x180666580
	|-AsyncVoidMethodBuilder.Start<WebOperation.<Run>d__58>
	*/

	// RVA: 0x14148A0 Offset: 0x1412EA0 VA: 0x1814148A0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x665B50 Offset: 0x664150 VA: 0x180665B50
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<Run>d__58>
	|
	|-RVA: 0x6661F0 Offset: 0x6647F0 VA: 0x1806661F0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x665D90 Offset: 0x664390 VA: 0x180665D90
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x665FB0 Offset: 0x6645B0 VA: 0x180665FB0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebOperation.<Run>d__58>
	*/

	// RVA: 0x1414840 Offset: 0x1412E40 VA: 0x181414840
	public void SetResult() { }

	// RVA: 0x1414720 Offset: 0x1412D20 VA: 0x181414720
	public void SetException(Exception exception) { }

	// RVA: 0x14146D0 Offset: 0x1412CD0 VA: 0x1814146D0
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x1414970 Offset: 0x1412F70 VA: 0x181414970
	internal Task get_Task() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder // TypeDefIndex: 1168
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x86A2D0 Offset: 0x8688D0 VA: 0x18086A2D0
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F9F90 Offset: 0x5F8590 VA: 0x1805F9F90
	|-AsyncTaskMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6627E0 Offset: 0x660DE0 VA: 0x1806627E0
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x6619A0 Offset: 0x65FFA0 VA: 0x1806619A0
	|-AsyncTaskMethodBuilder.Start<Base64Encoder.<EncodeAsync>d__13>
	|
	|-RVA: 0x663560 Offset: 0x661B60 VA: 0x180663560
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x6636E0 Offset: 0x661CE0 VA: 0x1806636E0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x664160 Offset: 0x662760 VA: 0x180664160
	|-AsyncTaskMethodBuilder.Start<JArray.<WriteToAsync>d__0>
	|
	|-RVA: 0x6640A0 Offset: 0x6626A0 VA: 0x1806640A0
	|-AsyncTaskMethodBuilder.Start<JConstructor.<WriteToAsync>d__0>
	|
	|-RVA: 0x662A20 Offset: 0x661020 VA: 0x180662A20
	|-AsyncTaskMethodBuilder.Start<JContainer.<ReadContentFromAsync>d__1>
	|
	|-RVA: 0x662DE0 Offset: 0x6613E0 VA: 0x180662DE0
	|-AsyncTaskMethodBuilder.Start<JContainer.<ReadTokenFromAsync>d__0>
	|
	|-RVA: 0x6634A0 Offset: 0x661AA0 VA: 0x1806634A0
	|-AsyncTaskMethodBuilder.Start<JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>
	|
	|-RVA: 0x664220 Offset: 0x662820 VA: 0x180664220
	|-AsyncTaskMethodBuilder.Start<JProperty.<WriteToAsync>d__1>
	|
	|-RVA: 0x6639E0 Offset: 0x661FE0 VA: 0x1806639E0
	|-AsyncTaskMethodBuilder.Start<JavaScriptUtils.<WriteCharAsync>d__14>
	|
	|-RVA: 0x663CE0 Offset: 0x6622E0 VA: 0x180663CE0
	|-AsyncTaskMethodBuilder.Start<JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16>
	|
	|-RVA: 0x663DA0 Offset: 0x6623A0 VA: 0x180663DA0
	|-AsyncTaskMethodBuilder.Start<JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13>
	|
	|-RVA: 0x662EA0 Offset: 0x6614A0 VA: 0x180662EA0
	|-AsyncTaskMethodBuilder.Start<JsonReader.<ReaderReadAndAssertAsync>d__2>
	|
	|-RVA: 0x6630E0 Offset: 0x6616E0 VA: 0x1806630E0
	|-AsyncTaskMethodBuilder.Start<JsonReader.<SkipAsync>d__1>
	|
	|-RVA: 0x6618E0 Offset: 0x65FEE0 VA: 0x1806618E0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<EatWhitespaceAsync>d__17>
	|
	|-RVA: 0x661D60 Offset: 0x660360 VA: 0x180661D60
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<HandleNullAsync>d__35>
	|
	|-RVA: 0x6621E0 Offset: 0x6607E0 VA: 0x1806621E0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<MatchAndSetAsync>d__21>
	|
	|-RVA: 0x6622A0 Offset: 0x6608A0 VA: 0x1806622A0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseCommentAsync>d__16>
	|
	|-RVA: 0x662360 Offset: 0x660960 VA: 0x180662360
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseConstructorAsync>d__25>
	|
	|-RVA: 0x662420 Offset: 0x660A20 VA: 0x180662420
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseNumberAsync>d__29>
	|
	|-RVA: 0x6624E0 Offset: 0x660AE0 VA: 0x1806624E0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseStringAsync>d__18>
	|
	|-RVA: 0x6625A0 Offset: 0x660BA0 VA: 0x1806625A0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseUnquotedPropertyAsync>d__33>
	|
	|-RVA: 0x662720 Offset: 0x660D20 VA: 0x180662720
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ProcessCarriageReturnAsync>d__11>
	|
	|-RVA: 0x662AE0 Offset: 0x6610E0 VA: 0x180662AE0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadFinishedAsync>d__36>
	|
	|-RVA: 0x662BA0 Offset: 0x6611A0 VA: 0x180662BA0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43>
	|
	|-RVA: 0x662C60 Offset: 0x661260 VA: 0x180662C60
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadNumberIntoBufferAsync>d__32>
	|
	|-RVA: 0x662D20 Offset: 0x661320 VA: 0x180662D20
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|
	|-RVA: 0x660E60 Offset: 0x65F460 VA: 0x180660E60
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoCloseAsync>d__8>
	|
	|-RVA: 0x660F20 Offset: 0x65F520 VA: 0x180660F20
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteCommentAsync>d__114>
	|
	|-RVA: 0x660FE0 Offset: 0x65F5E0 VA: 0x180660FE0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWritePropertyNameAsync>d__29>
	|
	|-RVA: 0x6610A0 Offset: 0x65F6A0 VA: 0x1806610A0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWritePropertyNameAsync>d__31>
	|
	|-RVA: 0x661160 Offset: 0x65F760 VA: 0x180661160
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteRawValueAsync>d__120>
	|
	|-RVA: 0x661220 Offset: 0x65F820 VA: 0x180661220
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteStartArrayAsync>d__34>
	|
	|-RVA: 0x6612E0 Offset: 0x65F8E0 VA: 0x1806612E0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteStartConstructorAsync>d__39>
	|
	|-RVA: 0x6613A0 Offset: 0x65F9A0 VA: 0x1806613A0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteStartObjectAsync>d__37>
	|
	|-RVA: 0x661460 Offset: 0x65FA60 VA: 0x180661460
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteUndefinedAsync>d__42>
	|
	|-RVA: 0x661520 Offset: 0x65FB20 VA: 0x180661520
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__59>
	|
	|-RVA: 0x6615E0 Offset: 0x65FBE0 VA: 0x1806615E0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__63>
	|
	|-RVA: 0x6616A0 Offset: 0x65FCA0 VA: 0x1806616A0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__77>
	|
	|-RVA: 0x661760 Offset: 0x65FD60 VA: 0x180661760
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__96>
	|
	|-RVA: 0x661820 Offset: 0x65FE20 VA: 0x180661820
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__98>
	|
	|-RVA: 0x663E60 Offset: 0x662460 VA: 0x180663E60
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteIndentAsync>d__12>
	|
	|-RVA: 0x663F20 Offset: 0x662520 VA: 0x180663F20
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteIntegerValueAsync>d__23>
	|
	|-RVA: 0x664460 Offset: 0x662A60 VA: 0x180664460
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteValueInternalAsync>d__14>
	|
	|-RVA: 0x664520 Offset: 0x662B20 VA: 0x180664520
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteValueNonNullAsync>d__53>
	|
	|-RVA: 0x6645E0 Offset: 0x662BE0 VA: 0x1806645E0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteValueNotNullAsync>d__109>
	|
	|-RVA: 0x6631A0 Offset: 0x6617A0 VA: 0x1806631A0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d>
	|
	|-RVA: 0x663260 Offset: 0x661860 VA: 0x180663260
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d>
	|
	|-RVA: 0x663320 Offset: 0x661920 VA: 0x180663320
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d>
	|
	|-RVA: 0x6633E0 Offset: 0x6619E0 VA: 0x1806633E0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d>
	|
	|-RVA: 0x660CE0 Offset: 0x65F2E0 VA: 0x180660CE0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<AutoCompleteAsync>d__1>
	|
	|-RVA: 0x662120 Offset: 0x660720 VA: 0x180662120
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<InternalWriteStartAsync>d__20>
	|
	|-RVA: 0x663C20 Offset: 0x662220 VA: 0x180663C20
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<WriteConstructorDateAsync>d__32>
	|
	|-RVA: 0x6642E0 Offset: 0x6628E0 VA: 0x1806642E0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<WriteTokenAsync>d__30>
	|
	|-RVA: 0x6643A0 Offset: 0x6629A0 VA: 0x1806643A0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<WriteTokenSyncReadingAsync>d__31>
	|
	|-RVA: 0x662060 Offset: 0x660660 VA: 0x180662060
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x662660 Offset: 0x660C60 VA: 0x180662660
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x661A60 Offset: 0x660060 VA: 0x180661A60
	|-AsyncTaskMethodBuilder.Start<MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x662F60 Offset: 0x661560 VA: 0x180662F60
	|-AsyncTaskMethodBuilder.Start<ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x661B20 Offset: 0x660120 VA: 0x180661B20
	|-AsyncTaskMethodBuilder.Start<Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x661CA0 Offset: 0x6602A0 VA: 0x180661CA0
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x6637A0 Offset: 0x661DA0 VA: 0x1806637A0
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<WriteAsyncInternal>d__57>
	|
	|-RVA: 0x663860 Offset: 0x661E60 VA: 0x180663860
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<WriteAsyncInternal>d__59>
	|
	|-RVA: 0x663920 Offset: 0x661F20 VA: 0x180663920
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0x660DA0 Offset: 0x65F3A0 VA: 0x180660DA0
	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	|
	|-RVA: 0x661FA0 Offset: 0x6605A0 VA: 0x180661FA0
	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x661BE0 Offset: 0x6601E0 VA: 0x180661BE0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x661EE0 Offset: 0x6604E0 VA: 0x180661EE0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x6628A0 Offset: 0x660EA0 VA: 0x1806628A0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x663020 Offset: 0x661620 VA: 0x180663020
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x663620 Offset: 0x661C20 VA: 0x180663620
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x663AA0 Offset: 0x6620A0 VA: 0x180663AA0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x663B60 Offset: 0x662160 VA: 0x180663B60
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x663FE0 Offset: 0x6625E0 VA: 0x180663FE0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x661E20 Offset: 0x660420 VA: 0x180661E20
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x662960 Offset: 0x660F60 VA: 0x180662960
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<ReadAllAsync>d__48>
	*/

	// RVA: 0x1414510 Offset: 0x1412B10 VA: 0x181414510
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65FFF0 Offset: 0x65E5F0 VA: 0x18065FFF0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchAndSetAsync>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x65FF60 Offset: 0x65E560 VA: 0x18065FF60
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x65FED0 Offset: 0x65E4D0 VA: 0x18065FED0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x660620 Offset: 0x65EC20 VA: 0x180660620
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseCommentAsync>d__16>
	|
	|-RVA: 0x6607D0 Offset: 0x65EDD0 VA: 0x1806607D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReaderReadAndAssertAsync>d__2>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ProcessCarriageReturnAsync>d__11>
	|
	|-RVA: 0x6606B0 Offset: 0x65ECB0 VA: 0x1806606B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<SkipAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseUnquotedPropertyAsync>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadNumberIntoBufferAsync>d__32>
	|
	|-RVA: 0x65FE40 Offset: 0x65E440 VA: 0x18065FE40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenSyncReadingAsync>d__31>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x660740 Offset: 0x65ED40 VA: 0x180660740
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|
	|-RVA: 0x6608F0 Offset: 0x65EEF0 VA: 0x1806608F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x660B30 Offset: 0x65F130 VA: 0x180660B30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x660A10 Offset: 0x65F010 VA: 0x180660A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x660AA0 Offset: 0x65F0A0 VA: 0x180660AA0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x660BC0 Offset: 0x65F1C0 VA: 0x180660BC0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x660C50 Offset: 0x65F250 VA: 0x180660C50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x660980 Offset: 0x65EF80 VA: 0x180660980
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6602C0 Offset: 0x65E8C0 VA: 0x1806602C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Base64Encoder.<EncodeAsync>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JArray.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JConstructor.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JProperty.<WriteToAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIntegerValueAsync>d__23>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x660470 Offset: 0x65EA70 VA: 0x180660470
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseConstructorAsync>d__25>
	|
	|-RVA: 0x6603E0 Offset: 0x65E9E0 VA: 0x1806603E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__57>
	|
	|-RVA: 0x660110 Offset: 0x65E710 VA: 0x180660110
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x660230 Offset: 0x65E830 VA: 0x180660230
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteCharAsync>d__14>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseNumberAsync>d__29>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__29>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__31>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteRawValueAsync>d__120>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__63>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__77>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__96>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueInternalAsync>d__14>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNotNullAsync>d__109>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<InternalWriteStartAsync>d__20>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x660590 Offset: 0x65EB90 VA: 0x180660590
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0x660500 Offset: 0x65EB00 VA: 0x180660500
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__59>
	|
	|-RVA: 0x6601A0 Offset: 0x65E7A0 VA: 0x1806601A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseStringAsync>d__18>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteCommentAsync>d__114>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartArrayAsync>d__34>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartConstructorAsync>d__39>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartObjectAsync>d__37>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteUndefinedAsync>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__59>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__98>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIndentAsync>d__12>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNonNullAsync>d__53>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x660080 Offset: 0x65E680 VA: 0x180660080
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoCloseAsync>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<AutoCompleteAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x660350 Offset: 0x65E950 VA: 0x180660350
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x660860 Offset: 0x65EE60 VA: 0x180660860
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	*/

	// RVA: 0x1414600 Offset: 0x1412C00 VA: 0x181414600
	public Task get_Task() { }

	// RVA: 0x1414470 Offset: 0x1412A70 VA: 0x181414470
	public void SetResult() { }

	// RVA: 0x1414400 Offset: 0x1412A00 VA: 0x181414400
	public void SetException(Exception exception) { }

	// RVA: 0x1414580 Offset: 0x1412B80 VA: 0x181414580
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 1169
{
	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x86A2D0 Offset: 0x8688D0 VA: 0x18086A2D0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.Create
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.Create
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.Create
	|-AsyncTaskMethodBuilder<Nullable<double>>.Create
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Create
	|-AsyncTaskMethodBuilder<bool>.Create
	|-AsyncTaskMethodBuilder<char>.Create
	|-AsyncTaskMethodBuilder<int>.Create
	|-AsyncTaskMethodBuilder<object>.Create
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FA3A0 Offset: 0x5F89A0 VA: 0x1805FA3A0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.Start<JsonTextReader.<DoReadAsBooleanAsync>d__40>
	|
	|-RVA: 0x5FA520 Offset: 0x5F8B20 VA: 0x1805FA520
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.Start<JsonTextReader.<DoReadAsDateTimeAsync>d__45>
	|
	|-RVA: 0x5FA5E0 Offset: 0x5F8BE0 VA: 0x1805FA5E0
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.Start<JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47>
	|
	|-RVA: 0x5FA6A0 Offset: 0x5F8CA0 VA: 0x1805FA6A0
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.Start<JsonTextReader.<DoReadAsDecimalAsync>d__49>
	|
	|-RVA: 0x5FA760 Offset: 0x5F8D60 VA: 0x1805FA760
	|-AsyncTaskMethodBuilder<Nullable<double>>.Start<JsonTextReader.<DoReadAsDoubleAsync>d__51>
	|
	|-RVA: 0x5FAD60 Offset: 0x5F9360 VA: 0x1805FAD60
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x5FA820 Offset: 0x5F8E20 VA: 0x1805FA820
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<JsonTextReader.<DoReadAsInt32Async>d__53>
	|
	|-RVA: 0x5FCFE0 Offset: 0x5FB5E0 VA: 0x1805FCFE0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Start<WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0x5FC6E0 Offset: 0x5FACE0 VA: 0x1805FC6E0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x5FABE0 Offset: 0x5F91E0 VA: 0x1805FABE0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Start<HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x5FB360 Offset: 0x5F9960 VA: 0x1805FB360
	|-AsyncTaskMethodBuilder<bool>.Start<JsonReader.<MoveToContentFromNonContentAsync>d__14>
	|
	|-RVA: 0x5FBDE0 Offset: 0x5FA3E0 VA: 0x1805FBDE0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonReader.<ReadAndMoveToContentAsync>d__12>
	|
	|-RVA: 0x5FA9A0 Offset: 0x5F8FA0 VA: 0x1805FA9A0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<DoReadAsync>d__3>
	|
	|-RVA: 0x5FB1E0 Offset: 0x5F97E0 VA: 0x1805FB1E0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<MatchValueAsync>d__19>
	|
	|-RVA: 0x5FB2A0 Offset: 0x5F98A0 VA: 0x1805FB2A0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20>
	|
	|-RVA: 0x5FB720 Offset: 0x5F9D20 VA: 0x1805FB720
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParseObjectAsync>d__15>
	|
	|-RVA: 0x5FB7E0 Offset: 0x5F9DE0 VA: 0x1805FB7E0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParsePostValueAsync>d__4>
	|
	|-RVA: 0x5FB8A0 Offset: 0x5F9EA0 VA: 0x1805FB8A0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParsePropertyAsync>d__31>
	|
	|-RVA: 0x5FBA20 Offset: 0x5FA020 VA: 0x1805FBA20
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParseValueAsync>d__8>
	|
	|-RVA: 0x5FC3E0 Offset: 0x5FA9E0 VA: 0x1805FC3E0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ReadCharsAsync>d__14>
	|
	|-RVA: 0x5FC620 Offset: 0x5FAC20 VA: 0x1805FC620
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ReadFromFinishedAsync>d__5>
	|
	|-RVA: 0x5FC7A0 Offset: 0x5FADA0 VA: 0x1805FC7A0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ReadNullCharAsync>d__34>
	|
	|-RVA: 0x5FD0A0 Offset: 0x5FB6A0 VA: 0x1805FD0A0
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0x5FCE60 Offset: 0x5FB460 VA: 0x1805FCE60
	|-AsyncTaskMethodBuilder<bool>.Start<ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0x5FA2E0 Offset: 0x5F88E0 VA: 0x1805FA2E0
	|-AsyncTaskMethodBuilder<bool>.Start<WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x5FB960 Offset: 0x5F9F60 VA: 0x1805FB960
	|-AsyncTaskMethodBuilder<char>.Start<JsonTextReader.<ParseUnicodeAsync>d__12>
	|
	|-RVA: 0x5FCAA0 Offset: 0x5FB0A0 VA: 0x1805FCAA0
	|-AsyncTaskMethodBuilder<int>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|
	|-RVA: 0x5FBAE0 Offset: 0x5FA0E0 VA: 0x1805FBAE0
	|-AsyncTaskMethodBuilder<int>.Start<BufferedReadStream.<ProcessReadAsync>d__2>
	|
	|-RVA: 0x5FBF60 Offset: 0x5FA560 VA: 0x1805FBF60
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0x5FC020 Offset: 0x5FA620 VA: 0x1805FC020
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x5FBBA0 Offset: 0x5FA1A0 VA: 0x1805FBBA0
	|-AsyncTaskMethodBuilder<int>.Start<FixedSizeReadStream.<ProcessReadAsync>d__5>
	|
	|-RVA: 0x5FC4A0 Offset: 0x5FAAA0 VA: 0x1805FC4A0
	|-AsyncTaskMethodBuilder<int>.Start<JsonTextReader.<ReadDataAsync>d__7>
	|
	|-RVA: 0x5FAE20 Offset: 0x5F9420 VA: 0x1805FAE20
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x5FCC20 Offset: 0x5FB220 VA: 0x1805FCC20
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0x5FBC60 Offset: 0x5FA260 VA: 0x1805FBC60
	|-AsyncTaskMethodBuilder<int>.Start<MonoChunkStream.<ProcessReadAsync>d__7>
	|
	|-RVA: 0x5FCDA0 Offset: 0x5FB3A0 VA: 0x1805FCDA0
	|-AsyncTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x5FC0E0 Offset: 0x5FA6E0 VA: 0x1805FC0E0
	|-AsyncTaskMethodBuilder<int>.Start<StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x5FC320 Offset: 0x5FA920 VA: 0x1805FC320
	|-AsyncTaskMethodBuilder<int>.Start<StreamReader.<ReadBufferAsync>d__69>
	|
	|-RVA: 0x5FC1A0 Offset: 0x5FA7A0 VA: 0x1805FC1A0
	|-AsyncTaskMethodBuilder<int>.Start<WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x5FC260 Offset: 0x5FA860 VA: 0x1805FC260
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0x5FC9E0 Offset: 0x5FAFE0 VA: 0x1805FC9E0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|
	|-RVA: 0x5FCF20 Offset: 0x5FB520 VA: 0x1805FCF20
	|-AsyncTaskMethodBuilder<object>.Start<WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0x5FCB60 Offset: 0x5FB160 VA: 0x1805FCB60
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x5FCCE0 Offset: 0x5FB2E0 VA: 0x1805FCCE0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0x5FB420 Offset: 0x5F9A20 VA: 0x1805FB420
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x5FAFA0 Offset: 0x5F95A0 VA: 0x1805FAFA0
	|-AsyncTaskMethodBuilder<object>.Start<JArray.<LoadAsync>d__2>
	|
	|-RVA: 0x5FAEE0 Offset: 0x5F94E0 VA: 0x1805FAEE0
	|-AsyncTaskMethodBuilder<object>.Start<JConstructor.<LoadAsync>d__2>
	|
	|-RVA: 0x5FB060 Offset: 0x5F9660 VA: 0x1805FB060
	|-AsyncTaskMethodBuilder<object>.Start<JObject.<LoadAsync>d__2>
	|
	|-RVA: 0x5FB120 Offset: 0x5F9720 VA: 0x1805FB120
	|-AsyncTaskMethodBuilder<object>.Start<JProperty.<LoadAsync>d__4>
	|
	|-RVA: 0x5FA160 Offset: 0x5F8760 VA: 0x1805FA160
	|-AsyncTaskMethodBuilder<object>.Start<JRaw.<CreateAsync>d__0>
	|
	|-RVA: 0x5FC560 Offset: 0x5FAB60 VA: 0x1805FC560
	|-AsyncTaskMethodBuilder<object>.Start<JToken.<ReadFromAsync>d__3>
	|
	|-RVA: 0x5FBEA0 Offset: 0x5FA4A0 VA: 0x1805FBEA0
	|-AsyncTaskMethodBuilder<object>.Start<JsonReader.<ReadArrayIntoByteArrayAsync>d__5>
	|
	|-RVA: 0x5FA460 Offset: 0x5F8A60 VA: 0x1805FA460
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<DoReadAsBytesAsync>d__42>
	|
	|-RVA: 0x5FA8E0 Offset: 0x5F8EE0 VA: 0x1805FA8E0
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<DoReadAsStringAsync>d__55>
	|
	|-RVA: 0x5FB4E0 Offset: 0x5F9AE0 VA: 0x1805FB4E0
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ParseNumberNaNAsync>d__26>
	|
	|-RVA: 0x5FB5A0 Offset: 0x5F9BA0 VA: 0x1805FB5A0
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28>
	|
	|-RVA: 0x5FB660 Offset: 0x5F9C60 VA: 0x1805FB660
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27>
	|
	|-RVA: 0x5FC860 Offset: 0x5FAE60 VA: 0x1805FC860
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ReadNumberValueAsync>d__38>
	|
	|-RVA: 0x5FC920 Offset: 0x5FAF20 VA: 0x1805FC920
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ReadStringValueAsync>d__37>
	|
	|-RVA: 0x5FA220 Offset: 0x5F8820 VA: 0x1805FA220
	|-AsyncTaskMethodBuilder<object>.Start<MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0x5FACA0 Offset: 0x5F92A0 VA: 0x1805FACA0
	|-AsyncTaskMethodBuilder<object>.Start<WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x5FBD20 Offset: 0x5FA320 VA: 0x1805FBD20
	|-AsyncTaskMethodBuilder<object>.Start<WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0x5FAB20 Offset: 0x5F9120 VA: 0x1805FAB20
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x5FAA60 Offset: 0x5F9060 VA: 0x1805FAA60
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x5F9F90 Offset: 0x5F8590 VA: 0x1805F9F90
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDF050 Offset: 0xBDD650 VA: 0x180BDF050
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetStateMachine
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|-AsyncTaskMethodBuilder<char>.SetStateMachine
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F7880 Offset: 0x5F5E80 VA: 0x1805F7880
	|-AsyncTaskMethodBuilder<Nullable<bool>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<DoReadAsBooleanAsync>d__40>
	|
	|-RVA: 0x5F3590 Offset: 0x5F1B90 VA: 0x1805F3590
	|-AsyncTaskMethodBuilder<Nullable<bool>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<DoReadAsBooleanAsync>d__40>
	|
	|-RVA: 0x5F0230 Offset: 0x5EE830 VA: 0x1805F0230
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDateTimeAsync>d__45>
	|
	|-RVA: 0x5F0410 Offset: 0x5EEA10 VA: 0x1805F0410
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47>
	|
	|-RVA: 0x5F05F0 Offset: 0x5EEBF0 VA: 0x1805F05F0
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDecimalAsync>d__49>
	|
	|-RVA: 0x5F07D0 Offset: 0x5EEDD0 VA: 0x1805F07D0
	|-AsyncTaskMethodBuilder<Nullable<double>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDoubleAsync>d__51>
	|
	|-RVA: 0x5F5E50 Offset: 0x5F4450 VA: 0x1805F5E50
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x5F09B0 Offset: 0x5EEFB0 VA: 0x1805F09B0
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsInt32Async>d__53>
	|
	|-RVA: 0x5F29D0 Offset: 0x5F0FD0 VA: 0x1805F29D0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0x5F7260 Offset: 0x5F5860 VA: 0x1805F7260
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x5F1160 Offset: 0x5EF760 VA: 0x1805F1160
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x5F41C0 Offset: 0x5F27C0 VA: 0x1805F41C0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x5F7470 Offset: 0x5F5A70 VA: 0x1805F7470
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<MoveToContentFromNonContentAsync>d__14>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReadAndMoveToContentAsync>d__12>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadNullCharAsync>d__34>
	|
	|-RVA: 0x5F7A90 Offset: 0x5F6090 VA: 0x1805F7A90
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<DoReadAsync>d__3>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchValueAsync>d__19>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20>
	|
	|-RVA: 0x5F6440 Offset: 0x5F4A40 VA: 0x1805F6440
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseObjectAsync>d__15>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseObjectAsync>d__15>
	|
	|-RVA: 0x5F15A0 Offset: 0x5EFBA0 VA: 0x1805F15A0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseValueAsync>d__8>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseValueAsync>d__8>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<ParseValueAsync>d__8>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0x5F2600 Offset: 0x5F0C00 VA: 0x1805F2600
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadFromFinishedAsync>d__5>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadCharsAsync>d__14>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0x5F6640 Offset: 0x5F4C40 VA: 0x1805F6640
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParsePostValueAsync>d__4>
	|
	|-RVA: 0x5EFE10 Offset: 0x5EE410 VA: 0x1805EFE10
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x5F4C20 Offset: 0x5F3220 VA: 0x1805F4C20
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseObjectAsync>d__15>
	|
	|-RVA: 0x5F4E20 Offset: 0x5F3420 VA: 0x1805F4E20
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParsePostValueAsync>d__4>
	|
	|-RVA: 0x5F5020 Offset: 0x5F3620 VA: 0x1805F5020
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParsePropertyAsync>d__31>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadFromFinishedAsync>d__5>
	|
	|-RVA: 0x5F5210 Offset: 0x5F3810 VA: 0x1805F5210
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseValueAsync>d__8>
	|
	|-RVA: 0x5F3380 Offset: 0x5F1980 VA: 0x1805F3380
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x5F7E70 Offset: 0x5F6470 VA: 0x1805F7E70
	|-AsyncTaskMethodBuilder<char>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseUnicodeAsync>d__12>
	|
	|-RVA: 0x5F6A30 Offset: 0x5F5030 VA: 0x1805F6A30
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, BufferedReadStream.<ProcessReadAsync>d__2>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, FixedSizeReadStream.<ProcessReadAsync>d__5>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<ProcessReadAsync>d__7>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x5F6040 Offset: 0x5F4640 VA: 0x1805F6040
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadDataAsync>d__7>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x5F6E30 Offset: 0x5F5430 VA: 0x1805F6E30
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x5F7060 Offset: 0x5F5660 VA: 0x1805F7060
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x5F1BB0 Offset: 0x5F01B0 VA: 0x1805F1BB0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAsync>d__40>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0x5F2410 Offset: 0x5F0A10 VA: 0x1805F2410
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0x5F8460 Offset: 0x5F6A60 VA: 0x1805F8460
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x5F8690 Offset: 0x5F6C90 VA: 0x1805F8690
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadBufferAsync>d__69>
	|
	|-RVA: 0x5F9150 Offset: 0x5F7750 VA: 0x1805F9150
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x5F9B30 Offset: 0x5F8130 VA: 0x1805F9B30
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<int>, CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0x5F8880 Offset: 0x5F6E80 VA: 0x1805F8880
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x5F5420 Offset: 0x5F3A20 VA: 0x1805F5420
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x5F1370 Offset: 0x5EF970 VA: 0x1805F1370
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x5F6C30 Offset: 0x5F5230 VA: 0x1805F6C30
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0x5F0F60 Offset: 0x5EF560 VA: 0x1805F0F60
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JArray.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JConstructor.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JObject.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JProperty.<LoadAsync>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x5F1DD0 Offset: 0x5F03D0 VA: 0x1805F1DD0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JToken.<ReadFromAsync>d__3>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JToken.<ReadFromAsync>d__3>
	|
	|-RVA: 0x5F0D70 Offset: 0x5EF370 VA: 0x1805F0D70
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReadArrayIntoByteArrayAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x5F0020 Offset: 0x5EE620 VA: 0x1805F0020
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<DoReadAsBytesAsync>d__42>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadStringValueAsync>d__37>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsBytesAsync>d__42>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<ReadStringValueAsync>d__37>
	|
	|-RVA: 0x5F7C80 Offset: 0x5F6280 VA: 0x1805F7C80
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseNumberNaNAsync>d__26>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27>
	|
	|-RVA: 0x5F2000 Offset: 0x5F0600 VA: 0x1805F2000
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadNumberValueAsync>d__38>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<ReadNumberValueAsync>d__38>
	|
	|-RVA: 0x5F27F0 Offset: 0x5F0DF0 VA: 0x1805F27F0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0x5F0B90 Offset: 0x5EF190 VA: 0x1805F0B90
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsStringAsync>d__55>
	|
	|-RVA: 0x5F8F20 Offset: 0x5F7520 VA: 0x1805F8F20
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x5F5830 Offset: 0x5F3E30 VA: 0x1805F5830
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0x5F45D0 Offset: 0x5F2BD0 VA: 0x1805F45D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x5F43D0 Offset: 0x5F29D0 VA: 0x1805F43D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JArray.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JConstructor.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JObject.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JProperty.<LoadAsync>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x5F3190 Offset: 0x5F1790 VA: 0x1805F3190
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JRaw.<CreateAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0x5F37A0 Offset: 0x5F1DA0 VA: 0x1805F37A0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<DoReadAsBytesAsync>d__42>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadStringValueAsync>d__37>
	|
	|-RVA: 0x5F5620 Offset: 0x5F3C20 VA: 0x1805F5620
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadNumberValueAsync>d__38>
	|
	|-RVA: 0x5F2BB0 Offset: 0x5F11B0 VA: 0x1805F2BB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchAndSetAsync>d__21>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x5F2210 Offset: 0x5F0810 VA: 0x1805F2210
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x5F19A0 Offset: 0x5EFFA0 VA: 0x1805F19A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x5F6230 Offset: 0x5F4830 VA: 0x1805F6230
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseCommentAsync>d__16>
	|
	|-RVA: 0x5F8050 Offset: 0x5F6650 VA: 0x1805F8050
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReaderReadAndAssertAsync>d__2>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ProcessCarriageReturnAsync>d__11>
	|
	|-RVA: 0x5F6840 Offset: 0x5F4E40 VA: 0x1805F6840
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<SkipAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseUnquotedPropertyAsync>d__33>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadNumberIntoBufferAsync>d__32>
	|
	|-RVA: 0x5F17B0 Offset: 0x5EFDB0 VA: 0x1805F17B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenSyncReadingAsync>d__31>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x5F7650 Offset: 0x5F5C50 VA: 0x1805F7650
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|
	|-RVA: 0x5F8A80 Offset: 0x5F7080 VA: 0x1805F8A80
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x5F9740 Offset: 0x5F7D40 VA: 0x1805F9740
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x5F9350 Offset: 0x5F7950 VA: 0x1805F9350
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x5F9540 Offset: 0x5F7B40 VA: 0x1805F9540
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x5F9940 Offset: 0x5F7F40 VA: 0x1805F9940
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x5F9D50 Offset: 0x5F8350 VA: 0x1805F9D50
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x5F3D90 Offset: 0x5F2390 VA: 0x1805F3D90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Base64Encoder.<EncodeAsync>d__13>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JArray.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JConstructor.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JProperty.<WriteToAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIntegerValueAsync>d__23>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x5F4A10 Offset: 0x5F3010 VA: 0x1805F4A10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseConstructorAsync>d__25>
	|
	|-RVA: 0x5F4800 Offset: 0x5F2E00 VA: 0x1805F4800
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__57>
	|
	|-RVA: 0x5F2F90 Offset: 0x5F1590 VA: 0x1805F2F90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x5F3BA0 Offset: 0x5F21A0 VA: 0x1805F3BA0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteCharAsync>d__14>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseNumberAsync>d__29>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__29>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__31>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteRawValueAsync>d__120>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__63>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__77>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__96>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueInternalAsync>d__14>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNotNullAsync>d__109>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<InternalWriteStartAsync>d__20>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x5F5C30 Offset: 0x5F4230 VA: 0x1805F5C30
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0x5F5A10 Offset: 0x5F4010 VA: 0x1805F5A10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__59>
	|
	|-RVA: 0x5F39B0 Offset: 0x5F1FB0 VA: 0x1805F39B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseStringAsync>d__18>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteCommentAsync>d__114>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartArrayAsync>d__34>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartConstructorAsync>d__39>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartObjectAsync>d__37>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteUndefinedAsync>d__42>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__59>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__98>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIndentAsync>d__12>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNonNullAsync>d__53>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x5F2DB0 Offset: 0x5F13B0 VA: 0x1805F2DB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoCloseAsync>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<AutoCompleteAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x5F3F90 Offset: 0x5F2590 VA: 0x1805F3F90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x5F8230 Offset: 0x5F6830 VA: 0x1805F8230
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x5F8C80 Offset: 0x5F7280 VA: 0x1805F8C80
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDF9A0 Offset: 0xBDDFA0 VA: 0x180BDF9A0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.get_Task
	|
	|-RVA: 0xBDFB00 Offset: 0xBDE100 VA: 0x180BDFB00
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.get_Task
	|
	|-RVA: 0xBDFBB0 Offset: 0xBDE1B0 VA: 0x180BDFBB0
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.get_Task
	|
	|-RVA: 0xBDF790 Offset: 0xBDDD90 VA: 0x180BDF790
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.get_Task
	|
	|-RVA: 0xBDF8F0 Offset: 0xBDDEF0 VA: 0x180BDF8F0
	|-AsyncTaskMethodBuilder<Nullable<double>>.get_Task
	|
	|-RVA: 0xBDFA50 Offset: 0xBDE050 VA: 0x180BDFA50
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|
	|-RVA: 0xBDF840 Offset: 0xBDDE40 VA: 0x180BDF840
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0xC27FA0 Offset: 0xC265A0 VA: 0x180C27FA0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.get_Task
	|
	|-RVA: 0xC28050 Offset: 0xC26650 VA: 0x180C28050
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.get_Task
	|
	|-RVA: 0xC27E40 Offset: 0xC26440 VA: 0x180C27E40
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0xC28100 Offset: 0xC26700 VA: 0x180C28100
	|-AsyncTaskMethodBuilder<char>.get_Task
	|
	|-RVA: 0xC27EF0 Offset: 0xC264F0 VA: 0x180C27EF0
	|-AsyncTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0xC28340 Offset: 0xC26940 VA: 0x180C28340
	|-AsyncTaskMethodBuilder<object>.get_Task
	|
	|-RVA: 0xC28290 Offset: 0xC26890 VA: 0x180C28290
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	|
	|-RVA: 0xC281B0 Offset: 0xC267B0 VA: 0x180C281B0
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDDB90 Offset: 0xBDC190 VA: 0x180BDDB90
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetResult
	|
	|-RVA: 0xBDE370 Offset: 0xBDC970 VA: 0x180BDE370
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetResult
	|
	|-RVA: 0xBDDF30 Offset: 0xBDC530 VA: 0x180BDDF30
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetResult
	|
	|-RVA: 0xBDEB90 Offset: 0xBDD190 VA: 0x180BDEB90
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetResult
	|
	|-RVA: 0xBDE9A0 Offset: 0xBDCFA0 VA: 0x180BDE9A0
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetResult
	|
	|-RVA: 0xBDE6D0 Offset: 0xBDCCD0 VA: 0x180BDE6D0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0xBDED90 Offset: 0xBDD390 VA: 0x180BDED90
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0xC26810 Offset: 0xC24E10 VA: 0x180C26810
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0xC260C0 Offset: 0xC246C0 VA: 0x180C260C0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0xC273A0 Offset: 0xC259A0 VA: 0x180C273A0
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0xC271D0 Offset: 0xC257D0 VA: 0x180C271D0
	|-AsyncTaskMethodBuilder<char>.SetResult
	|
	|-RVA: 0xC26CA0 Offset: 0xC252A0 VA: 0x180C26CA0
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0xC25D30 Offset: 0xC24330 VA: 0x180C25D30
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0xC26370 Offset: 0xC24970 VA: 0x180C26370
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0xC26E70 Offset: 0xC25470 VA: 0x180C26E70
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDE1F0 Offset: 0xBDC7F0 VA: 0x180BDE1F0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetResult
	|
	|-RVA: 0xBDE610 Offset: 0xBDCC10 VA: 0x180BDE610
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetResult
	|
	|-RVA: 0xBDDE60 Offset: 0xBDC460 VA: 0x180BDDE60
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetResult
	|
	|-RVA: 0xBDEF80 Offset: 0xBDD580 VA: 0x180BDEF80
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetResult
	|
	|-RVA: 0xBDE2B0 Offset: 0xBDC8B0 VA: 0x180BDE2B0
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetResult
	|
	|-RVA: 0xBDE560 Offset: 0xBDCB60 VA: 0x180BDE560
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0xBDE130 Offset: 0xBDC730 VA: 0x180BDE130
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0xC26BD0 Offset: 0xC251D0 VA: 0x180C26BD0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0xC26540 Offset: 0xC24B40 VA: 0x180C26540
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0xC26010 Offset: 0xC24610 VA: 0x180C26010
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0xC26760 Offset: 0xC24D60 VA: 0x180C26760
	|-AsyncTaskMethodBuilder<char>.SetResult
	|
	|-RVA: 0xC262C0 Offset: 0xC248C0 VA: 0x180C262C0
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0xC26600 Offset: 0xC24C00 VA: 0x180C26600
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0xC266B0 Offset: 0xC24CB0 VA: 0x180C266B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0xC26A10 Offset: 0xC25010 VA: 0x180C26A10
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDD170 Offset: 0xBDB770 VA: 0x180BDD170
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetException
	|
	|-RVA: 0xBDCFC0 Offset: 0xBDB5C0 VA: 0x180BDCFC0
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetException
	|
	|-RVA: 0xBDD9E0 Offset: 0xBDBFE0 VA: 0x180BDD9E0
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetException
	|
	|-RVA: 0xBDD830 Offset: 0xBDBE30 VA: 0x180BDD830
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetException
	|
	|-RVA: 0xBDD680 Offset: 0xBDBC80 VA: 0x180BDD680
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetException
	|
	|-RVA: 0xBDD320 Offset: 0xBDB920 VA: 0x180BDD320
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0xBDD4D0 Offset: 0xBDBAD0 VA: 0x180BDD4D0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetException
	|
	|-RVA: 0xC25B80 Offset: 0xC24180 VA: 0x180C25B80
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetException
	|
	|-RVA: 0xC25160 Offset: 0xC23760 VA: 0x180C25160
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetException
	|
	|-RVA: 0xC25820 Offset: 0xC23E20 VA: 0x180C25820
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0xC254C0 Offset: 0xC23AC0 VA: 0x180C254C0
	|-AsyncTaskMethodBuilder<char>.SetException
	|
	|-RVA: 0xC25670 Offset: 0xC23C70 VA: 0x180C25670
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0xC259D0 Offset: 0xC23FD0 VA: 0x180C259D0
	|-AsyncTaskMethodBuilder<object>.SetException
	|
	|-RVA: 0xC25310 Offset: 0xC23910 VA: 0x180C25310
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	|
	|-RVA: 0xC24F80 Offset: 0xC23580 VA: 0x180C24F80
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC050 Offset: 0xBDA650 VA: 0x180BDC050
	|-AsyncTaskMethodBuilder<Nullable<bool>>.GetTaskForResult
	|
	|-RVA: 0xBDB3F0 Offset: 0xBD99F0 VA: 0x180BDB3F0
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.GetTaskForResult
	|
	|-RVA: 0xBD9AC0 Offset: 0xBD80C0 VA: 0x180BD9AC0
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.GetTaskForResult
	|
	|-RVA: 0xBDC190 Offset: 0xBDA790 VA: 0x180BDC190
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.GetTaskForResult
	|
	|-RVA: 0xBD8E60 Offset: 0xBD7460 VA: 0x180BD8E60
	|-AsyncTaskMethodBuilder<Nullable<double>>.GetTaskForResult
	|
	|-RVA: 0xBDCE80 Offset: 0xBDB480 VA: 0x180BDCE80
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0xBDA7B0 Offset: 0xBD8DB0 VA: 0x180BDA7B0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.GetTaskForResult
	|
	|-RVA: 0xC20BD0 Offset: 0xC1F1D0 VA: 0x180C20BD0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.GetTaskForResult
	|
	|-RVA: 0xC236C0 Offset: 0xC21CC0 VA: 0x180C236C0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.GetTaskForResult
	|
	|-RVA: 0xC24370 Offset: 0xC22970 VA: 0x180C24370
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0xC1F3B0 Offset: 0xC1D9B0 VA: 0x180C1F3B0
	|-AsyncTaskMethodBuilder<char>.GetTaskForResult
	|
	|-RVA: 0xC22AB0 Offset: 0xC210B0 VA: 0x180C22AB0
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0xC22970 Offset: 0xC20F70 VA: 0x180C22970
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0xC1FFC0 Offset: 0xC1E5C0 VA: 0x180C1FFC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	|
	|-RVA: 0xC218A0 Offset: 0xC1FEA0 VA: 0x180C218A0
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDF390 Offset: 0xBDD990 VA: 0x180BDF390
	|-AsyncTaskMethodBuilder<Nullable<bool>>..cctor
	|
	|-RVA: 0xBDF170 Offset: 0xBDD770 VA: 0x180BDF170
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>..cctor
	|
	|-RVA: 0xBDF280 Offset: 0xBDD880 VA: 0x180BDF280
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>..cctor
	|
	|-RVA: 0xBDF680 Offset: 0xBDDC80 VA: 0x180BDF680
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>..cctor
	|
	|-RVA: 0xBDF570 Offset: 0xBDDB70 VA: 0x180BDF570
	|-AsyncTaskMethodBuilder<Nullable<double>>..cctor
	|
	|-RVA: 0xBDF480 Offset: 0xBDDA80 VA: 0x180BDF480
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0xBDF060 Offset: 0xBDD660 VA: 0x180BDF060
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0xC27860 Offset: 0xC25E60 VA: 0x180C27860
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>..cctor
	|
	|-RVA: 0xC27580 Offset: 0xC25B80 VA: 0x180C27580
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>..cctor
	|
	|-RVA: 0xC27D50 Offset: 0xC26350 VA: 0x180C27D50
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0xC27680 Offset: 0xC25C80 VA: 0x180C27680
	|-AsyncTaskMethodBuilder<char>..cctor
	|
	|-RVA: 0xC27770 Offset: 0xC25D70 VA: 0x180C27770
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0xC27C60 Offset: 0xC26260 VA: 0x180C27C60
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0xC27970 Offset: 0xC25F70 VA: 0x180C27970
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	|
	|-RVA: 0xC27A60 Offset: 0xC26060 VA: 0x180C27A60
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Runtime.CompilerServices
internal static class AsyncTaskCache // TypeDefIndex: 1170
{
	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0x1414140 Offset: 0x1412740 VA: 0x181414140
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65F9A0 Offset: 0x65DFA0 VA: 0x18065F9A0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<bool>>
	|
	|-RVA: 0x65FAC0 Offset: 0x65E0C0 VA: 0x18065FAC0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<DateTime>>
	|
	|-RVA: 0x65F870 Offset: 0x65DE70 VA: 0x18065F870
	|-AsyncTaskCache.CreateCacheableTask<Nullable<DateTimeOffset>>
	|
	|-RVA: 0x65F7D0 Offset: 0x65DDD0 VA: 0x18065F7D0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Decimal>>
	|
	|-RVA: 0x65F910 Offset: 0x65DF10 VA: 0x18065F910
	|-AsyncTaskCache.CreateCacheableTask<Nullable<double>>
	|
	|-RVA: 0x65FA30 Offset: 0x65E030 VA: 0x18065FA30
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|
	|-RVA: 0x65FBE0 Offset: 0x65E1E0 VA: 0x18065FBE0
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<bool, object>>
	|
	|-RVA: 0x65FC70 Offset: 0x65E270 VA: 0x18065FC70
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, object, int>>
	|
	|-RVA: 0x65FD10 Offset: 0x65E310 VA: 0x18065FD10
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, bool, bool, object, object>>
	|
	|-RVA: 0x65F4F0 Offset: 0x65DAF0 VA: 0x18065F4F0
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0x65F580 Offset: 0x65DB80 VA: 0x18065F580
	|-AsyncTaskCache.CreateCacheableTask<char>
	|
	|-RVA: 0x65F740 Offset: 0x65DD40 VA: 0x18065F740
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0x65FB50 Offset: 0x65E150 VA: 0x18065FB50
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0x65FDB0 Offset: 0x65E3B0 VA: 0x18065FDB0
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	|
	|-RVA: 0x65F610 Offset: 0x65DC10 VA: 0x18065F610
	|-AsyncTaskCache.CreateCacheableTask<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1414240 Offset: 0x1412840 VA: 0x181414240
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
internal struct AsyncMethodBuilderCore // TypeDefIndex: 1175
{
	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x1413D00 Offset: 0x1412300 VA: 0x181413D00
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x1413730 Offset: 0x1411D30 VA: 0x181413730
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x1413950 Offset: 0x1411F50 VA: 0x181413950
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x1413B30 Offset: 0x1412130 VA: 0x181413B30
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0x1413DD0 Offset: 0x14123D0 VA: 0x181413DD0
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0x14135F0 Offset: 0x1411BF0 VA: 0x1814135F0
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x14140C0 Offset: 0x14126C0 VA: 0x1814140C0
	internal static Task TryGetContinuationTask(Action action) { }
}

// Namespace: System.Runtime.CompilerServices
[Serializable]
public enum LoadHint // TypeDefIndex: 1176
{
	// Fields
	public int value__; // 0x0
	public const LoadHint Default = 0;
	public const LoadHint Always = 1;
	public const LoadHint Sometimes = 2;
}

// Namespace: System.Runtime.CompilerServices
[Usage(1)]
[Serializable]
public sealed class DefaultDependencyAttribute : Attribute // TypeDefIndex: 1177
{
	// Fields
	private LoadHint loadHint; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(LoadHint loadHintArgument) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, AllowMultiple = True)]
[Serializable]
public sealed class DependencyAttribute : Attribute // TypeDefIndex: 1178
{
	// Fields
	private string dependentAssembly; // 0x10
	private LoadHint loadHint; // 0x18

	// Methods

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	public void .ctor(string dependentAssemblyArgument, LoadHint loadHintArgument) { }
}

// Namespace: System.Runtime.CompilerServices
[Flags]
[ComVisible(True)]
[Serializable]
public enum CompilationRelaxations // TypeDefIndex: 1179
{
	// Fields
	public int value__; // 0x0
	public const CompilationRelaxations NoStringInterning = 8;
}

// Namespace: System.Runtime.CompilerServices
[ComVisible(True)]
[Usage(71)]
[Serializable]
public class CompilationRelaxationsAttribute : Attribute // TypeDefIndex: 1180
{
	// Fields
	private int m_relaxations; // 0x10

	// Properties
	public int CompilationRelaxations { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int relaxations) { }

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(CompilationRelaxations relaxations) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_CompilationRelaxations() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, AllowMultiple = True, Inherited = False)]
public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1181
{
	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public bool AllInternalsVisible { set; }

	// Methods

	// RVA: 0x14180B0 Offset: 0x14166B0 VA: 0x1814180B0
	public void .ctor(string assemblyName) { }

	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_AllInternalsVisible(bool value) { }
}

// Namespace: System.Runtime.CompilerServices
[FriendAccessAllowed]
[Usage(2044, AllowMultiple = False, Inherited = False)]
internal sealed class FriendAccessAllowedAttribute : Attribute // TypeDefIndex: 1182
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1036, AllowMultiple = True, Inherited = False)]
internal sealed class TypeDependencyAttribute : Attribute // TypeDefIndex: 1183
{
	// Fields
	private string typeName; // 0x10

	// Methods

	// RVA: 0x14252C0 Offset: 0x14238C0 VA: 0x1814252C0
	public void .ctor(string typeName) { }
}

// Namespace: System.Runtime.CompilerServices
internal static class JitHelpers // TypeDefIndex: 1184
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7108A0 Offset: 0x70EEA0 VA: 0x1807108A0
	|-JitHelpers.UnsafeCast<object>
	*/

	// RVA: -1 Offset: -1
	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x710A20 Offset: 0x70F020 VA: 0x180710A20
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	|-JitHelpers.UnsafeEnumCast<UInt32Enum>
	|
	|-RVA: 0x710980 Offset: 0x70EF80 VA: 0x180710980
	|-JitHelpers.UnsafeEnumCast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static long UnsafeEnumCastLong<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7108E0 Offset: 0x70EEE0 VA: 0x1807108E0
	|-JitHelpers.UnsafeEnumCastLong<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Runtime.CompilerServices
internal struct Ephemeron // TypeDefIndex: 1185
{
	// Fields
	internal object key; // 0x0
	internal object value; // 0x8
}

// Namespace: System.Runtime.CompilerServices
public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1188
{
	// Fields
	private Ephemeron[] data; // 0x0
	private object _lock; // 0x0
	private int size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2A840 Offset: 0xD28E40 VA: 0x180D2A840
	|-ConditionalWeakTable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD29900 Offset: 0xD27F00 VA: 0x180D29900
	|-ConditionalWeakTable<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1
	private void RehashWithoutResize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD29B30 Offset: 0xD28130 VA: 0x180D29B30
	|-ConditionalWeakTable<object, object>.RehashWithoutResize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD29AD0 Offset: 0xD280D0 VA: 0x180D29AD0
	|-ConditionalWeakTable<object, object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void Rehash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD29E00 Offset: 0xD28400 VA: 0x180D29E00
	|-ConditionalWeakTable<object, object>.Rehash
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD295A0 Offset: 0xD27BA0 VA: 0x180D295A0
	|-ConditionalWeakTable<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2A150 Offset: 0xD28750 VA: 0x180D2A150
	|-ConditionalWeakTable<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2A5A0 Offset: 0xD28BA0 VA: 0x180D2A5A0
	|-ConditionalWeakTable<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key, ConditionalWeakTable.CreateValueCallback<TKey, TValue> createValueCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD29950 Offset: 0xD27F50 VA: 0x180D29950
	|-ConditionalWeakTable<object, object>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2A410 Offset: 0xD28A10 VA: 0x180D2A410
	|-ConditionalWeakTable<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7CFD0 Offset: 0xA7B5D0 VA: 0x180A7CFD0
	|-ConditionalWeakTable<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Runtime.CompilerServices
public static class RuntimeHelpers // TypeDefIndex: 1189
{
	// Properties
	public static int OffsetToStringData { get; }

	// Methods

	// RVA: 0x1422590 Offset: 0x1420B90 VA: 0x181422590
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	// RVA: 0x1422530 Offset: 0x1420B30 VA: 0x181422530
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	// RVA: 0x1422630 Offset: 0x1420C30 VA: 0x181422630
	public static int get_OffsetToStringData() { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480
	public static int GetHashCode(object o) { }

	// RVA: 0x1422520 Offset: 0x1420B20 VA: 0x181422520
	public static object GetObjectValue(object obj) { }

	// RVA: 0x14225A0 Offset: 0x1420BA0 VA: 0x1814225A0
	private static void RunClassConstructor(IntPtr type) { }

	// RVA: 0x14225B0 Offset: 0x1420BB0 VA: 0x1814225B0
	public static void RunClassConstructor(RuntimeTypeHandle type) { }

	// RVA: 0x1417710 Offset: 0x1415D10 VA: 0x181417710
	private static bool SufficientExecutionStack() { }

	// RVA: 0x1417710 Offset: 0x1415D10 VA: 0x181417710
	public static bool TryEnsureSufficientExecutionStack() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void PrepareConstrainedRegions() { }

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7976C0 Offset: 0x795CC0 VA: 0x1807976C0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AsyncOperationHandle<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataPoint<int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataPoint<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataPoint<float>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataPoint<float4>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LRUCache.Entry<uint, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Edge, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<long, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, bool>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<ConvertMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<CopyMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<NudgeJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<ConvertMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<CopyMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<NudgeJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<ushort>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<Vertex>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Nullable<Vector2Int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TempAllocator.Page<ushort>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TempAllocator.Page<Vertex>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SimpleTuple<int, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SimpleTuple<object, Edge>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SimpleTuple<object, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SimpleTuple<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SimpleTuple<float, Vector2>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SimpleTuple<Vector3, Vector3, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StructMultiKey<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeViewItemData<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, AsyncOperationHandle>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Int32Enum, Int32Enum>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Int32Enum, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<IntPtr, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<LocaleIdentifier, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<uint, uint>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Vector2Int, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Rect, Rect, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<fsOption<fsVersionedType>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AddDebuffContainer>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AsyncOperationHandle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BezierKnot>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BezierPoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BindingId>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BindingResult>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<bool>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<byte>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<char>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color32>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CombineInstance>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ComputedStyle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ComputedTransitionProperty>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ContactPoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ControllerPollingInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ControllerTemplateElementTarget>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataSourceContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTime>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTimeOffset>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Decimal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DiagnosticEvent>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DisplayInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<double>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EasingFunction>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Edge>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EdgeLookup>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ElementAssignmentConflictInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Entitlement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EnumData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Event>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventHook>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FileStat>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GCHandle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphMarshallingStruct>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphPairAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphRect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GradientAlphaKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GradientColorKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Guid>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Hash128>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputActionSourceData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<short>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<int>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int32Enum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<long>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPtr>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntVec3>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InterpretedFrameInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JobHandle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonPosition>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Keyframe>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LayoutHandle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LgZBqyIHTMUoDtFYcTxmpaLstKtU>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LigatureSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LigatureSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LocaleIdentifier>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ManipulatorActivationFilter>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToBaseAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToBaseAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToMarkAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToMarkAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Matrix4x4>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultipleSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultipleSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<object>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ObjectInitializationData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PropertyName>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PropertyPath>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PropertyPathInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PropertyPathPart>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Quaternion>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RangePositionInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastHit>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastHit2D>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastResult>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Rect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderInstancedDataLayout>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderTargetIdentifier>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Resolution>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceLocator>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RuleMatcher>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<sbyte>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Scene>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SelectorMatchRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SerializedCommand>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<float>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Sku>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SplineKnotIndex>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyName>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSelectorPart>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSyntaxToken>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleValueManaged>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleVariable>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TerrainTileCoord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureId>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeSpan>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeViewItemWrapper>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Triangle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TypeWrapper>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UICharInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UILineInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIVertex>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ushort>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<uint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UInt32Enum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ulong>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<User>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UxmlDescription>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UxmlNamespaceDefinition>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UxmlTypeDescription>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2Int>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector4>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vertex>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VertexAttributeDescriptor>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<X509ChainStatus>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XPathNodeRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<__Il2CppFullySharedGenericType>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<float3>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<fsVersionedType>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<jvalue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AccessibilityManager.NotificationContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AnimatedMeshScriptableObject.Animation>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Awaitable.AwaitableAndFrameIndex>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BaseStyleMatcher.MatchContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BeforeRenderHelper.OrderBlock>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BinaryOperatorHandler.OperatorQuery>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BitmapAllocator32.Page>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CharacterSubstitutor.CharReplacement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ConversionRegistry.ConverterKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ConversionUtility.ConversionQuery>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CreationContext.AttributeOverrideRange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CreationContext.SerializedDataOverrideRange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataBindingManager.BindingData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataBindingManager.BindingDataCollection>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataBindingManager.BindingRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataBindingManager.SourceOwner>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DelayedActionManager.DelegateInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EntryPreProcessor.AllocSize>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EntryProcessor.MaskMesh>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.DispatchContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.EventRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventInterestReflectionUtils.DefaultEventInterests>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventProvider.Registration>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Expander.ExpansionRule>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FocusController.FocusedElement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GrassChunkManager.GrassData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GrassChunkManager.GrassInstance>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputSettingNew.InputKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MeshGenerationDeferrer.CallbackInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MeshGenerator.RepeatRectUV>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MeshGenerator.TessellationJobParameters>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultiColumnCollectionHeader.SortedColumnState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Painter2D.Painter2DJobData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ParticleSystem.Particle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastUtility.ConeSphere>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Regex.CachedCodeEntryKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RegexCharClass.SingleRange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceManager.DeferredCallbackRegisterRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceNode.SequenceConstructPosContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SplineInstantiate.InstantiableItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleComplexSelector.PseudoStateData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyAnimationSystem.ElementPropertyPair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSheetCache.SheetHandleKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleVariableResolver.ResolveContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TMP_DynamicFontAssetUtilities.FontReference>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TMP_ResourceManager.FontAssetRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TemplateAsset.AttributeOverride>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TemplateAsset.UxmlSerializedDataOverride>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextResourceManager.FontAssetRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextSettings.FontReferenceMap>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureBlitter.BlitInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TexturePacker_JsonArray.Frame>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureRegistry.TextureInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TypeConverterRegistry.ConverterKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRenderDevice.AllocToFree>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRenderDevice.AllocToUpdate>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnitySynchronizationContext.WorkRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.AssetEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.SlotDefinition>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.SlotUsageEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.UsingEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.UxmlObjectEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeDataBindingsUpdater.VersionInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XboxOneInputSource.miyZWpTlfrgbhFZVVSteyfKElQFk>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<fsAotCompilationManager.AotCompilation>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<fsPortableReflection.AttributeQuery>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BindingRestrictions.TestBuilder.AndNode>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InstructionList.DebugView.InstructionView>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderChain.VisualChangesProcessor.EntryProcessingInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>
	*/
}

// Namespace: System.Runtime.CompilerServices
internal static class Unsafe // TypeDefIndex: 1190
{
	// Methods

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80FCE0 Offset: 0x80E2E0 VA: 0x18080FCE0
	|-Unsafe.Add<AsyncOperationHandle<object>>
	|-Unsafe.Add<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>
	|-Unsafe.Add<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>
	|-Unsafe.Add<PropertyPathPart>
	|-Unsafe.Add<TypeWrapper>
	|-Unsafe.Add<DelayedActionManager.DelegateInfo>
	|-Unsafe.Add<EventProvider.Registration>
	|-Unsafe.Add<MeshGenerator.RepeatRectUV>
	|-Unsafe.Add<VisualTreeAsset.AssetEntry>
	|-Unsafe.Add<InstructionList.DebugView.InstructionView>
	|-Unsafe.Add<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0x80FC90 Offset: 0x80E290 VA: 0x18080FC90
	|-Unsafe.Add<DataPoint<int>>
	|-Unsafe.Add<DataPoint<float>>
	|-Unsafe.Add<KeyValuePair<int, int>>
	|-Unsafe.Add<SimpleTuple<int, int>>
	|-Unsafe.Add<ValueTuple<int, int>>
	|-Unsafe.Add<DateTime>
	|-Unsafe.Add<double>
	|-Unsafe.Add<Edge>
	|-Unsafe.Add<GCHandle>
	|-Unsafe.Add<GradientAlphaKey>
	|-Unsafe.Add<long>
	|-Unsafe.Add<IntPtr>
	|-Unsafe.Add<object>
	|-Unsafe.Add<SplineKnotIndex>
	|-Unsafe.Add<TimeSpan>
	|-Unsafe.Add<TimeValue>
	|-Unsafe.Add<ulong>
	|-Unsafe.Add<Vector2>
	|-Unsafe.Add<Vector2Int>
	|-Unsafe.Add<jvalue>
	|-Unsafe.Add<BitmapAllocator32.Page>
	|-Unsafe.Add<EntryPreProcessor.AllocSize>
	|-Unsafe.Add<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>
	|
	|-RVA: 0x80FCC0 Offset: 0x80E2C0 VA: 0x18080FCC0
	|-Unsafe.Add<DataPoint<object>>
	|-Unsafe.Add<KeyValuePair<Edge, object>>
	|-Unsafe.Add<KeyValuePair<int, object>>
	|-Unsafe.Add<KeyValuePair<long, object>>
	|-Unsafe.Add<KeyValuePair<object, bool>>
	|-Unsafe.Add<KeyValuePair<object, object>>
	|-Unsafe.Add<NativeArray<ConvertMeshJobData>>
	|-Unsafe.Add<NativeArray<CopyMeshJobData>>
	|-Unsafe.Add<NativeArray<NudgeJobData>>
	|-Unsafe.Add<NativeSlice<ConvertMeshJobData>>
	|-Unsafe.Add<NativeSlice<CopyMeshJobData>>
	|-Unsafe.Add<NativeSlice<NudgeJobData>>
	|-Unsafe.Add<NativeSlice<ushort>>
	|-Unsafe.Add<NativeSlice<Vertex>>
	|-Unsafe.Add<SimpleTuple<object, Edge>>
	|-Unsafe.Add<SimpleTuple<object, int>>
	|-Unsafe.Add<SimpleTuple<object, object>>
	|-Unsafe.Add<StructMultiKey<object, object>>
	|-Unsafe.Add<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>
	|-Unsafe.Add<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>
	|-Unsafe.Add<Color>
	|-Unsafe.Add<ControllerTemplateElementTarget>
	|-Unsafe.Add<DateTimeOffset>
	|-Unsafe.Add<Decimal>
	|-Unsafe.Add<EdgeLookup>
	|-Unsafe.Add<GlyphRect>
	|-Unsafe.Add<Guid>
	|-Unsafe.Add<InterpretedFrameInfo>
	|-Unsafe.Add<LigatureSubstitutionRecord>
	|-Unsafe.Add<LigatureSubstitutionRecord>
	|-Unsafe.Add<MultipleSubstitutionRecord>
	|-Unsafe.Add<MultipleSubstitutionRecord>
	|-Unsafe.Add<Quaternion>
	|-Unsafe.Add<RangePositionInfo>
	|-Unsafe.Add<Resolution>
	|-Unsafe.Add<RuleMatcher>
	|-Unsafe.Add<StylePropertyName>
	|-Unsafe.Add<StylePropertyValue>
	|-Unsafe.Add<StyleValueManaged>
	|-Unsafe.Add<UILineInfo>
	|-Unsafe.Add<UxmlNamespaceDefinition>
	|-Unsafe.Add<Vector4>
	|-Unsafe.Add<VertexAttributeDescriptor>
	|-Unsafe.Add<X509ChainStatus>
	|-Unsafe.Add<AnimatedMeshScriptableObject.Animation>
	|-Unsafe.Add<Awaitable.AwaitableAndFrameIndex>
	|-Unsafe.Add<BeforeRenderHelper.OrderBlock>
	|-Unsafe.Add<CreationContext.AttributeOverrideRange>
	|-Unsafe.Add<CreationContext.SerializedDataOverrideRange>
	|-Unsafe.Add<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>
	|-Unsafe.Add<FocusController.FocusedElement>
	|-Unsafe.Add<GrassChunkManager.GrassInstance>
	|-Unsafe.Add<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|-Unsafe.Add<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>
	|-Unsafe.Add<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>
	|-Unsafe.Add<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>
	|-Unsafe.Add<MultiColumnCollectionHeader.SortedColumnState>
	|-Unsafe.Add<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-Unsafe.Add<Painter2D.Painter2DJobData>
	|-Unsafe.Add<RaycastUtility.ConeSphere>
	|-Unsafe.Add<ResourceManager.DeferredCallbackRegisterRequest>
	|-Unsafe.Add<TemplateAsset.UxmlSerializedDataOverride>
	|-Unsafe.Add<TextSettings.FontReferenceMap>
	|-Unsafe.Add<TextureRegistry.TextureInfo>
	|-Unsafe.Add<VisualTreeAsset.SlotDefinition>
	|-Unsafe.Add<VisualTreeAsset.SlotUsageEntry>
	|-Unsafe.Add<VisualTreeAsset.UxmlObjectEntry>
	|-Unsafe.Add<VisualTreeDataBindingsUpdater.VersionInfo>
	|-Unsafe.Add<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x80FD80 Offset: 0x80E380 VA: 0x18080FD80
	|-Unsafe.Add<DataPoint<float4>>
	|-Unsafe.Add<GradientColorKey>
	|-Unsafe.Add<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>
	|-Unsafe.Add<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>
	|
	|-RVA: 0x80FCD0 Offset: 0x80E2D0 VA: 0x18080FCD0
	|-Unsafe.Add<TempAllocator.Page<ushort>>
	|-Unsafe.Add<TempAllocator.Page<Vertex>>
	|-Unsafe.Add<ValueTuple<LocaleIdentifier, object>>
	|-Unsafe.Add<AsyncOperationHandle>
	|-Unsafe.Add<ComputedTransitionProperty>
	|-Unsafe.Add<Entitlement>
	|-Unsafe.Add<FileStat>
	|-Unsafe.Add<InputActionSourceData>
	|-Unsafe.Add<JsonPosition>
	|-Unsafe.Add<MarkToBaseAdjustmentRecord>
	|-Unsafe.Add<MarkToBaseAdjustmentRecord>
	|-Unsafe.Add<MarkToMarkAdjustmentRecord>
	|-Unsafe.Add<MarkToMarkAdjustmentRecord>
	|-Unsafe.Add<SelectorMatchRecord>
	|-Unsafe.Add<StyleSelectorPart>
	|-Unsafe.Add<StyleSyntaxToken>
	|-Unsafe.Add<StyleValue>
	|-Unsafe.Add<StyleVariable>
	|-Unsafe.Add<TreeViewItemWrapper>
	|-Unsafe.Add<fsVersionedType>
	|-Unsafe.Add<SplineInstantiate.InstantiableItem>
	|-Unsafe.Add<TemplateAsset.AttributeOverride>
	|-Unsafe.Add<UnitySynchronizationContext.WorkRequest>
	|-Unsafe.Add<UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-Unsafe.Add<VisualTreeAsset.UsingEntry>
	|-Unsafe.Add<fsAotCompilationManager.AotCompilation>
	|-Unsafe.Add<RenderChain.VisualChangesProcessor.EntryProcessingInfo>
	|
	|-RVA: 0x80FDA0 Offset: 0x80E3A0 VA: 0x18080FDA0
	|-Unsafe.Add<SimpleTuple<float, Vector2>>
	|-Unsafe.Add<ValueTuple<Vector2Int, int>>
	|-Unsafe.Add<ManipulatorActivationFilter>
	|-Unsafe.Add<Triangle>
	|-Unsafe.Add<UICharInfo>
	|-Unsafe.Add<Vector3>
	|-Unsafe.Add<float3>
	|-Unsafe.Add<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>
	|-Unsafe.Add<Expander.ExpansionRule>
	|-Unsafe.Add<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>
	|
	|-RVA: 0x80FCA0 Offset: 0x80E2A0 VA: 0x18080FCA0
	|-Unsafe.Add<ValueTuple<Rect, Rect, object>>
	|-Unsafe.Add<RenderTargetIdentifier>
	|-Unsafe.Add<Sku>
	|-Unsafe.Add<User>
	|-Unsafe.Add<UxmlDescription>
	|-Unsafe.Add<UIRenderDevice.AllocToFree>
	|
	|-RVA: 0x80FCF0 Offset: 0x80E2F0 VA: 0x18080FCF0
	|-Unsafe.Add<BezierKnot>
	|-Unsafe.Add<BezierPoint>
	|-Unsafe.Add<GlyphMarshallingStruct>
	|
	|-RVA: 0x80FD20 Offset: 0x80E320 VA: 0x18080FD20
	|-Unsafe.Add<bool>
	|-Unsafe.Add<byte>
	|-Unsafe.Add<sbyte>
	|
	|-RVA: 0x80FD40 Offset: 0x80E340 VA: 0x18080FD40
	|-Unsafe.Add<char>
	|-Unsafe.Add<short>
	|-Unsafe.Add<ushort>
	|
	|-RVA: 0x80FD30 Offset: 0x80E330 VA: 0x18080FD30
	|-Unsafe.Add<Color32>
	|-Unsafe.Add<EasingFunction>
	|-Unsafe.Add<int>
	|-Unsafe.Add<Int32Enum>
	|-Unsafe.Add<float>
	|-Unsafe.Add<uint>
	|-Unsafe.Add<UInt32Enum>
	|-Unsafe.Add<CharacterSubstitutor.CharReplacement>
	|-Unsafe.Add<RegexCharClass.SingleRange>
	|
	|-RVA: 0x80FD60 Offset: 0x80E360 VA: 0x18080FD60
	|-Unsafe.Add<CombineInstance>
	|
	|-RVA: 0x80FD70 Offset: 0x80E370 VA: 0x18080FD70
	|-Unsafe.Add<ContactPoint>
	|-Unsafe.Add<DiagnosticEvent>
	|-Unsafe.Add<DisplayInfo>
	|-Unsafe.Add<ObjectInitializationData>
	|
	|-RVA: 0x80FD10 Offset: 0x80E310 VA: 0x18080FD10
	|-Unsafe.Add<ControllerPollingInfo>
	|-Unsafe.Add<TextureBlitter.BlitInfo>
	|
	|-RVA: 0x80FD90 Offset: 0x80E390 VA: 0x18080FD90
	|-Unsafe.Add<ElementAssignmentConflictInfo>
	|-Unsafe.Add<GlyphPairAdjustmentRecord>
	|-Unsafe.Add<RaycastHit>
	|
	|-RVA: 0x80FED0 Offset: 0x80E4D0 VA: 0x18080FED0
	|-Unsafe.Add<Keyframe>
	|
	|-RVA: 0x80FF00 Offset: 0x80E500 VA: 0x18080FF00
	|-Unsafe.Add<PropertyPath>
	|
	|-RVA: 0x80FEF0 Offset: 0x80E4F0 VA: 0x18080FEF0
	|-Unsafe.Add<PropertyPathInfo>
	|
	|-RVA: 0x80FF10 Offset: 0x80E510 VA: 0x18080FF10
	|-Unsafe.Add<RaycastHit2D>
	|
	|-RVA: 0x80FCB0 Offset: 0x80E2B0 VA: 0x18080FCB0
	|-Unsafe.Add<RaycastResult>
	|-Unsafe.Add<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0x80FF20 Offset: 0x80E520 VA: 0x18080FF20
	|-Unsafe.Add<SerializedCommand>
	|
	|-RVA: 0x80FF40 Offset: 0x80E540 VA: 0x18080FF40
	|-Unsafe.Add<UIVertex>
	|
	|-RVA: 0x80FDB0 Offset: 0x80E3B0 VA: 0x18080FDB0
	|-Unsafe.Add<Vertex>
	|-Unsafe.Add<GrassChunkManager.GrassData>
	|-Unsafe.Add<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x80FE60 Offset: 0x80E460 VA: 0x18080FE60
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x80FD00 Offset: 0x80E300 VA: 0x18080FD00
	|-Unsafe.Add<DataBindingManager.BindingData>
	|-Unsafe.Add<DataBindingManager.BindingRequest>
	|
	|-RVA: 0x80FF50 Offset: 0x80E550 VA: 0x18080FF50
	|-Unsafe.Add<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>
	|
	|-RVA: 0x80FF30 Offset: 0x80E530 VA: 0x18080FF30
	|-Unsafe.Add<MeshGenerator.TessellationJobParameters>
	|
	|-RVA: 0x80FEE0 Offset: 0x80E4E0 VA: 0x18080FEE0
	|-Unsafe.Add<ParticleSystem.Particle>
	*/

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80FC20 Offset: 0x80E220 VA: 0x18080FC20
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x80FD50 Offset: 0x80E350 VA: 0x18080FD50
	|-Unsafe.Add<char>
	|
	|-RVA: 0x80FEB0 Offset: 0x80E4B0 VA: 0x18080FEB0
	|-Unsafe.Add<int>
	|
	|-RVA: 0x80FEC0 Offset: 0x80E4C0 VA: 0x18080FEC0
	|-Unsafe.Add<IntPtr>
	|
	|-RVA: 0x80FE10 Offset: 0x80E410 VA: 0x18080FE10
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void* Add<T>(void* source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80FD20 Offset: 0x80E320 VA: 0x18080FD20
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x80FD40 Offset: 0x80E340 VA: 0x18080FD40
	|-Unsafe.Add<char>
	|
	|-RVA: 0x80FDC0 Offset: 0x80E3C0 VA: 0x18080FDC0
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80FC20 Offset: 0x80E220 VA: 0x18080FC20
	|-Unsafe.AddByteOffset<bool>
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<Color>
	|-Unsafe.AddByteOffset<Color32>
	|-Unsafe.AddByteOffset<CombineInstance>
	|-Unsafe.AddByteOffset<ContactPoint>
	|-Unsafe.AddByteOffset<GlyphMarshallingStruct>
	|-Unsafe.AddByteOffset<GlyphPairAdjustmentRecord>
	|-Unsafe.AddByteOffset<GlyphRect>
	|-Unsafe.AddByteOffset<GradientAlphaKey>
	|-Unsafe.AddByteOffset<GradientColorKey>
	|-Unsafe.AddByteOffset<int>
	|-Unsafe.AddByteOffset<Int32Enum>
	|-Unsafe.AddByteOffset<Keyframe>
	|-Unsafe.AddByteOffset<MarkToBaseAdjustmentRecord>
	|-Unsafe.AddByteOffset<MarkToMarkAdjustmentRecord>
	|-Unsafe.AddByteOffset<object>
	|-Unsafe.AddByteOffset<RaycastHit>
	|-Unsafe.AddByteOffset<RaycastHit2D>
	|-Unsafe.AddByteOffset<RenderTargetIdentifier>
	|-Unsafe.AddByteOffset<Resolution>
	|-Unsafe.AddByteOffset<float>
	|-Unsafe.AddByteOffset<ushort>
	|-Unsafe.AddByteOffset<uint>
	|-Unsafe.AddByteOffset<Vector3>
	|-Unsafe.AddByteOffset<Vector4>
	|-Unsafe.AddByteOffset<Vertex>
	|-Unsafe.AddByteOffset<VertexAttributeDescriptor>
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	|-Unsafe.AddByteOffset<jvalue>
	|-Unsafe.AddByteOffset<ParticleSystem.Particle>
	*/

	// RVA: -1 Offset: -1
	public static bool AreSame<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	|-Unsafe.AreSame<byte>
	|-Unsafe.AreSame<char>
	|-Unsafe.AreSame<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-Unsafe.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-Unsafe.As<Memory<byte>, ReadOnlyMemory<byte>>
	|-Unsafe.As<Memory<char>, ReadOnlyMemory<char>>
	|-Unsafe.As<ReadOnlyMemory<byte>, Memory<byte>>
	|-Unsafe.As<bool, byte>
	|-Unsafe.As<bool, char>
	|-Unsafe.As<bool, IntPtr>
	|-Unsafe.As<bool, Volatile.VolatileBoolean>
	|-Unsafe.As<byte, AsyncOperationHandle<object>>
	|-Unsafe.As<byte, DataPoint<int>>
	|-Unsafe.As<byte, DataPoint<object>>
	|-Unsafe.As<byte, DataPoint<float>>
	|-Unsafe.As<byte, DataPoint<float4>>
	|-Unsafe.As<byte, KeyValuePair<Edge, object>>
	|-Unsafe.As<byte, KeyValuePair<int, int>>
	|-Unsafe.As<byte, KeyValuePair<int, object>>
	|-Unsafe.As<byte, KeyValuePair<long, object>>
	|-Unsafe.As<byte, KeyValuePair<object, bool>>
	|-Unsafe.As<byte, KeyValuePair<object, object>>
	|-Unsafe.As<byte, NativeArray<ConvertMeshJobData>>
	|-Unsafe.As<byte, NativeArray<CopyMeshJobData>>
	|-Unsafe.As<byte, NativeArray<NudgeJobData>>
	|-Unsafe.As<byte, NativeSlice<ConvertMeshJobData>>
	|-Unsafe.As<byte, NativeSlice<CopyMeshJobData>>
	|-Unsafe.As<byte, NativeSlice<NudgeJobData>>
	|-Unsafe.As<byte, NativeSlice<ushort>>
	|-Unsafe.As<byte, NativeSlice<Vertex>>
	|-Unsafe.As<byte, TempAllocator.Page<ushort>>
	|-Unsafe.As<byte, TempAllocator.Page<Vertex>>
	|-Unsafe.As<byte, SimpleTuple<int, int>>
	|-Unsafe.As<byte, SimpleTuple<object, Edge>>
	|-Unsafe.As<byte, SimpleTuple<object, int>>
	|-Unsafe.As<byte, SimpleTuple<object, object>>
	|-Unsafe.As<byte, SimpleTuple<float, Vector2>>
	|-Unsafe.As<byte, StructMultiKey<object, object>>
	|-Unsafe.As<byte, IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>
	|-Unsafe.As<byte, IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>
	|-Unsafe.As<byte, IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>
	|-Unsafe.As<byte, IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>
	|-Unsafe.As<byte, ValueTuple<int, int>>
	|-Unsafe.As<byte, ValueTuple<LocaleIdentifier, object>>
	|-Unsafe.As<byte, ValueTuple<Vector2Int, int>>
	|-Unsafe.As<byte, ValueTuple<Rect, Rect, object>>
	|-Unsafe.As<byte, AsyncOperationHandle>
	|-Unsafe.As<byte, BezierKnot>
	|-Unsafe.As<byte, BezierPoint>
	|-Unsafe.As<byte, bool>
	|-Unsafe.As<byte, byte>
	|-Unsafe.As<byte, char>
	|-Unsafe.As<byte, Color>
	|-Unsafe.As<byte, Color32>
	|-Unsafe.As<byte, CombineInstance>
	|-Unsafe.As<byte, ComputedTransitionProperty>
	|-Unsafe.As<byte, ContactPoint>
	|-Unsafe.As<byte, ControllerPollingInfo>
	|-Unsafe.As<byte, ControllerTemplateElementTarget>
	|-Unsafe.As<byte, DateTime>
	|-Unsafe.As<byte, DateTimeOffset>
	|-Unsafe.As<byte, Decimal>
	|-Unsafe.As<byte, DiagnosticEvent>
	|-Unsafe.As<byte, DisplayInfo>
	|-Unsafe.As<byte, double>
	|-Unsafe.As<byte, EasingFunction>
	|-Unsafe.As<byte, Edge>
	|-Unsafe.As<byte, EdgeLookup>
	|-Unsafe.As<byte, ElementAssignmentConflictInfo>
	|-Unsafe.As<byte, Entitlement>
	|-Unsafe.As<byte, FileStat>
	|-Unsafe.As<byte, GCHandle>
	|-Unsafe.As<byte, GlyphMarshallingStruct>
	|-Unsafe.As<byte, GlyphPairAdjustmentRecord>
	|-Unsafe.As<byte, GlyphRect>
	|-Unsafe.As<byte, GradientAlphaKey>
	|-Unsafe.As<byte, GradientColorKey>
	|-Unsafe.As<byte, Guid>
	|-Unsafe.As<byte, InputActionSourceData>
	|-Unsafe.As<byte, short>
	|-Unsafe.As<byte, int>
	|-Unsafe.As<byte, Int32Enum>
	|-Unsafe.As<byte, long>
	|-Unsafe.As<byte, IntPtr>
	|-Unsafe.As<byte, InterpretedFrameInfo>
	|-Unsafe.As<byte, JsonPosition>
	|-Unsafe.As<byte, Keyframe>
	|-Unsafe.As<byte, LigatureSubstitutionRecord>
	|-Unsafe.As<byte, LigatureSubstitutionRecord>
	|-Unsafe.As<byte, ManipulatorActivationFilter>
	|-Unsafe.As<byte, MarkToBaseAdjustmentRecord>
	|-Unsafe.As<byte, MarkToBaseAdjustmentRecord>
	|-Unsafe.As<byte, MarkToMarkAdjustmentRecord>
	|-Unsafe.As<byte, MarkToMarkAdjustmentRecord>
	|-Unsafe.As<byte, MultipleSubstitutionRecord>
	|-Unsafe.As<byte, MultipleSubstitutionRecord>
	|-Unsafe.As<byte, object>
	|-Unsafe.As<byte, ObjectInitializationData>
	|-Unsafe.As<byte, PropertyPath>
	|-Unsafe.As<byte, PropertyPathInfo>
	|-Unsafe.As<byte, PropertyPathPart>
	|-Unsafe.As<byte, Quaternion>
	|-Unsafe.As<byte, RangePositionInfo>
	|-Unsafe.As<byte, RaycastHit>
	|-Unsafe.As<byte, RaycastHit2D>
	|-Unsafe.As<byte, RaycastResult>
	|-Unsafe.As<byte, RenderTargetIdentifier>
	|-Unsafe.As<byte, Resolution>
	|-Unsafe.As<byte, RuleMatcher>
	|-Unsafe.As<byte, sbyte>
	|-Unsafe.As<byte, SelectorMatchRecord>
	|-Unsafe.As<byte, SerializedCommand>
	|-Unsafe.As<byte, float>
	|-Unsafe.As<byte, Sku>
	|-Unsafe.As<byte, SplineKnotIndex>
	|-Unsafe.As<byte, StylePropertyName>
	|-Unsafe.As<byte, StylePropertyValue>
	|-Unsafe.As<byte, StyleSelectorPart>
	|-Unsafe.As<byte, StyleSyntaxToken>
	|-Unsafe.As<byte, StyleValue>
	|-Unsafe.As<byte, StyleValueManaged>
	|-Unsafe.As<byte, StyleVariable>
	|-Unsafe.As<byte, TimeSpan>
	|-Unsafe.As<byte, TimeValue>
	|-Unsafe.As<byte, TreeViewItemWrapper>
	|-Unsafe.As<byte, Triangle>
	|-Unsafe.As<byte, TypeWrapper>
	|-Unsafe.As<byte, UICharInfo>
	|-Unsafe.As<byte, UILineInfo>
	|-Unsafe.As<byte, UIVertex>
	|-Unsafe.As<byte, ushort>
	|-Unsafe.As<byte, uint>
	|-Unsafe.As<byte, UInt32Enum>
	|-Unsafe.As<byte, ulong>
	|-Unsafe.As<byte, User>
	|-Unsafe.As<byte, UxmlDescription>
	|-Unsafe.As<byte, UxmlNamespaceDefinition>
	|-Unsafe.As<byte, Vector2>
	|-Unsafe.As<byte, Vector2Int>
	|-Unsafe.As<byte, Vector3>
	|-Unsafe.As<byte, Vector4>
	|-Unsafe.As<byte, Vertex>
	|-Unsafe.As<byte, VertexAttributeDescriptor>
	|-Unsafe.As<byte, X509ChainStatus>
	|-Unsafe.As<byte, float3>
	|-Unsafe.As<byte, fsVersionedType>
	|-Unsafe.As<byte, jvalue>
	|-Unsafe.As<byte, AnimatedMeshScriptableObject.Animation>
	|-Unsafe.As<byte, Awaitable.AwaitableAndFrameIndex>
	|-Unsafe.As<byte, BeforeRenderHelper.OrderBlock>
	|-Unsafe.As<byte, BitmapAllocator32.Page>
	|-Unsafe.As<byte, CharacterSubstitutor.CharReplacement>
	|-Unsafe.As<byte, CreationContext.AttributeOverrideRange>
	|-Unsafe.As<byte, CreationContext.SerializedDataOverrideRange>
	|-Unsafe.As<byte, CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>
	|-Unsafe.As<byte, DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>
	|-Unsafe.As<byte, DataBindingManager.BindingData>
	|-Unsafe.As<byte, DataBindingManager.BindingRequest>
	|-Unsafe.As<byte, DelayedActionManager.DelegateInfo>
	|-Unsafe.As<byte, EntryPreProcessor.AllocSize>
	|-Unsafe.As<byte, EventProvider.Registration>
	|-Unsafe.As<byte, Expander.ExpansionRule>
	|-Unsafe.As<byte, FocusController.FocusedElement>
	|-Unsafe.As<byte, GrassChunkManager.GrassData>
	|-Unsafe.As<byte, GrassChunkManager.GrassInstance>
	|-Unsafe.As<byte, HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|-Unsafe.As<byte, HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>
	|-Unsafe.As<byte, ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>
	|-Unsafe.As<byte, ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>
	|-Unsafe.As<byte, ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>
	|-Unsafe.As<byte, MeshGenerator.RepeatRectUV>
	|-Unsafe.As<byte, MeshGenerator.TessellationJobParameters>
	|-Unsafe.As<byte, MultiColumnCollectionHeader.SortedColumnState>
	|-Unsafe.As<byte, PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-Unsafe.As<byte, Painter2D.Painter2DJobData>
	|-Unsafe.As<byte, ParticleSystem.Particle>
	|-Unsafe.As<byte, RaycastUtility.ConeSphere>
	|-Unsafe.As<byte, RegexCharClass.SingleRange>
	|-Unsafe.As<byte, ResourceManager.DeferredCallbackRegisterRequest>
	|-Unsafe.As<byte, SplineInstantiate.InstantiableItem>
	|-Unsafe.As<byte, TemplateAsset.AttributeOverride>
	|-Unsafe.As<byte, TemplateAsset.UxmlSerializedDataOverride>
	|-Unsafe.As<byte, TextSettings.FontReferenceMap>
	|-Unsafe.As<byte, TextureBlitter.BlitInfo>
	|-Unsafe.As<byte, TexturePacker_JsonArray.Frame>
	|-Unsafe.As<byte, TextureRegistry.TextureInfo>
	|-Unsafe.As<byte, UIRenderDevice.AllocToFree>
	|-Unsafe.As<byte, UIRenderDevice.AllocToUpdate>
	|-Unsafe.As<byte, UnitySynchronizationContext.WorkRequest>
	|-Unsafe.As<byte, UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-Unsafe.As<byte, VisualTreeAsset.AssetEntry>
	|-Unsafe.As<byte, VisualTreeAsset.SlotDefinition>
	|-Unsafe.As<byte, VisualTreeAsset.SlotUsageEntry>
	|-Unsafe.As<byte, VisualTreeAsset.UsingEntry>
	|-Unsafe.As<byte, VisualTreeAsset.UxmlObjectEntry>
	|-Unsafe.As<byte, VisualTreeDataBindingsUpdater.VersionInfo>
	|-Unsafe.As<byte, XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Unsafe.As<byte, fsAotCompilationManager.AotCompilation>
	|-Unsafe.As<byte, niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>
	|-Unsafe.As<byte, InstructionList.DebugView.InstructionView>
	|-Unsafe.As<byte, MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Unsafe.As<byte, PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>
	|-Unsafe.As<byte, RenderChain.VisualChangesProcessor.EntryProcessingInfo>
	|-Unsafe.As<byte, UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>
	|-Unsafe.As<byte, UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>
	|-Unsafe.As<char, byte>
	|-Unsafe.As<char, char>
	|-Unsafe.As<char, IntPtr>
	|-Unsafe.As<Color, byte>
	|-Unsafe.As<Color, char>
	|-Unsafe.As<Color, IntPtr>
	|-Unsafe.As<Color32, byte>
	|-Unsafe.As<Color32, char>
	|-Unsafe.As<Color32, IntPtr>
	|-Unsafe.As<CombineInstance, byte>
	|-Unsafe.As<CombineInstance, char>
	|-Unsafe.As<CombineInstance, IntPtr>
	|-Unsafe.As<ContactPoint, byte>
	|-Unsafe.As<ContactPoint, char>
	|-Unsafe.As<ContactPoint, IntPtr>
	|-Unsafe.As<Decimal, Decimal.DecCalc>
	|-Unsafe.As<GlyphMarshallingStruct, byte>
	|-Unsafe.As<GlyphMarshallingStruct, char>
	|-Unsafe.As<GlyphMarshallingStruct, IntPtr>
	|-Unsafe.As<GlyphPairAdjustmentRecord, byte>
	|-Unsafe.As<GlyphPairAdjustmentRecord, char>
	|-Unsafe.As<GlyphPairAdjustmentRecord, IntPtr>
	|-Unsafe.As<GlyphRect, byte>
	|-Unsafe.As<GlyphRect, char>
	|-Unsafe.As<GlyphRect, IntPtr>
	|-Unsafe.As<GradientAlphaKey, byte>
	|-Unsafe.As<GradientAlphaKey, char>
	|-Unsafe.As<GradientAlphaKey, IntPtr>
	|-Unsafe.As<GradientColorKey, byte>
	|-Unsafe.As<GradientColorKey, char>
	|-Unsafe.As<GradientColorKey, IntPtr>
	|-Unsafe.As<int, byte>
	|-Unsafe.As<int, char>
	|-Unsafe.As<int, IntPtr>
	|-Unsafe.As<int, uint>
	|-Unsafe.As<int, Volatile.VolatileInt32>
	|-Unsafe.As<Int32Enum, byte>
	|-Unsafe.As<Int32Enum, char>
	|-Unsafe.As<Int32Enum, IntPtr>
	|-Unsafe.As<long, ulong>
	|-Unsafe.As<IntPtr, object>
	|-Unsafe.As<Keyframe, byte>
	|-Unsafe.As<Keyframe, char>
	|-Unsafe.As<Keyframe, IntPtr>
	|-Unsafe.As<MarkToBaseAdjustmentRecord, byte>
	|-Unsafe.As<MarkToBaseAdjustmentRecord, char>
	|-Unsafe.As<MarkToBaseAdjustmentRecord, IntPtr>
	|-Unsafe.As<MarkToMarkAdjustmentRecord, byte>
	|-Unsafe.As<MarkToMarkAdjustmentRecord, char>
	|-Unsafe.As<MarkToMarkAdjustmentRecord, IntPtr>
	|-Unsafe.As<object, byte>
	|-Unsafe.As<object, char>
	|-Unsafe.As<object, IntPtr>
	|-Unsafe.As<object, object>
	|-Unsafe.As<object, Volatile.VolatileObject>
	|-Unsafe.As<RaycastHit, byte>
	|-Unsafe.As<RaycastHit, char>
	|-Unsafe.As<RaycastHit, IntPtr>
	|-Unsafe.As<RaycastHit2D, byte>
	|-Unsafe.As<RaycastHit2D, char>
	|-Unsafe.As<RaycastHit2D, IntPtr>
	|-Unsafe.As<RenderTargetIdentifier, byte>
	|-Unsafe.As<RenderTargetIdentifier, char>
	|-Unsafe.As<RenderTargetIdentifier, IntPtr>
	|-Unsafe.As<Resolution, byte>
	|-Unsafe.As<Resolution, char>
	|-Unsafe.As<Resolution, IntPtr>
	|-Unsafe.As<float, byte>
	|-Unsafe.As<float, char>
	|-Unsafe.As<float, IntPtr>
	|-Unsafe.As<ushort, byte>
	|-Unsafe.As<ushort, char>
	|-Unsafe.As<ushort, IntPtr>
	|-Unsafe.As<uint, byte>
	|-Unsafe.As<uint, char>
	|-Unsafe.As<uint, IntPtr>
	|-Unsafe.As<Vector3, byte>
	|-Unsafe.As<Vector3, char>
	|-Unsafe.As<Vector3, IntPtr>
	|-Unsafe.As<Vector4, byte>
	|-Unsafe.As<Vector4, char>
	|-Unsafe.As<Vector4, IntPtr>
	|-Unsafe.As<Vertex, byte>
	|-Unsafe.As<Vertex, char>
	|-Unsafe.As<Vertex, IntPtr>
	|-Unsafe.As<VertexAttributeDescriptor, byte>
	|-Unsafe.As<VertexAttributeDescriptor, char>
	|-Unsafe.As<VertexAttributeDescriptor, IntPtr>
	|-Unsafe.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|-Unsafe.As<jvalue, byte>
	|-Unsafe.As<jvalue, char>
	|-Unsafe.As<jvalue, IntPtr>
	|-Unsafe.As<Decimal.DecCalc, Decimal>
	|-Unsafe.As<ParticleSystem.Particle, byte>
	|-Unsafe.As<ParticleSystem.Particle, char>
	|-Unsafe.As<ParticleSystem.Particle, IntPtr>
	*/

	// RVA: -1 Offset: -1
	public static void* AsPointer<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-Unsafe.AsPointer<byte>
	|-Unsafe.AsPointer<char>
	|-Unsafe.AsPointer<object>
	|-Unsafe.AsPointer<__Il2CppFullySharedGenericType>
	|-Unsafe.AsPointer<Number.NumberBuffer.DigitsAndNullTerminator>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-Unsafe.AsRef<bool>
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<Color>
	|-Unsafe.AsRef<Color32>
	|-Unsafe.AsRef<CombineInstance>
	|-Unsafe.AsRef<ContactPoint>
	|-Unsafe.AsRef<GlyphMarshallingStruct>
	|-Unsafe.AsRef<GlyphPairAdjustmentRecord>
	|-Unsafe.AsRef<GlyphRect>
	|-Unsafe.AsRef<GradientAlphaKey>
	|-Unsafe.AsRef<GradientColorKey>
	|-Unsafe.AsRef<int>
	|-Unsafe.AsRef<Int32Enum>
	|-Unsafe.AsRef<Keyframe>
	|-Unsafe.AsRef<MarkToBaseAdjustmentRecord>
	|-Unsafe.AsRef<MarkToMarkAdjustmentRecord>
	|-Unsafe.AsRef<object>
	|-Unsafe.AsRef<RaycastHit>
	|-Unsafe.AsRef<RaycastHit2D>
	|-Unsafe.AsRef<RenderTargetIdentifier>
	|-Unsafe.AsRef<Resolution>
	|-Unsafe.AsRef<float>
	|-Unsafe.AsRef<ushort>
	|-Unsafe.AsRef<uint>
	|-Unsafe.AsRef<Vector3>
	|-Unsafe.AsRef<Vector4>
	|-Unsafe.AsRef<Vertex>
	|-Unsafe.AsRef<VertexAttributeDescriptor>
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	|-Unsafe.AsRef<jvalue>
	|-Unsafe.AsRef<ParticleSystem.Particle>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(in T source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x14258B0 Offset: 0x1423EB0 VA: 0x1814258B0
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	// RVA: -1 Offset: -1
	public static T Read<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	|-Unsafe.Read<Vector<ushort>>
	|
	|-RVA: 0x80FF70 Offset: 0x80E570 VA: 0x18080FF70
	|-Unsafe.Read<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	|-Unsafe.ReadUnaligned<Vector<ushort>>
	|
	|-RVA: 0x5CFEA0 Offset: 0x5CE4A0 VA: 0x1805CFEA0
	|-Unsafe.ReadUnaligned<short>
	|-Unsafe.ReadUnaligned<ushort>
	|
	|-RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	|-Unsafe.ReadUnaligned<int>
	|-Unsafe.ReadUnaligned<uint>
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-Unsafe.ReadUnaligned<long>
	|-Unsafe.ReadUnaligned<UIntPtr>
	|
	|-RVA: 0x80FF70 Offset: 0x80E570 VA: 0x18080FF70
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44EB70 Offset: 0x44D170 VA: 0x18044EB70
	|-Unsafe.SizeOf<Vector<ushort>>
	|-Unsafe.SizeOf<Color>
	|-Unsafe.SizeOf<GlyphRect>
	|-Unsafe.SizeOf<Resolution>
	|-Unsafe.SizeOf<Vector4>
	|-Unsafe.SizeOf<VertexAttributeDescriptor>
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-Unsafe.SizeOf<bool>
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270
	|-Unsafe.SizeOf<char>
	|-Unsafe.SizeOf<ushort>
	|
	|-RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0
	|-Unsafe.SizeOf<Color32>
	|-Unsafe.SizeOf<int>
	|-Unsafe.SizeOf<Int32Enum>
	|-Unsafe.SizeOf<float>
	|-Unsafe.SizeOf<uint>
	|
	|-RVA: 0x80F400 Offset: 0x80DA00 VA: 0x18080F400
	|-Unsafe.SizeOf<CombineInstance>
	|
	|-RVA: 0x80F2E0 Offset: 0x80D8E0 VA: 0x18080F2E0
	|-Unsafe.SizeOf<ContactPoint>
	|
	|-RVA: 0x80F330 Offset: 0x80D930 VA: 0x18080F330
	|-Unsafe.SizeOf<GlyphMarshallingStruct>
	|
	|-RVA: 0x810010 Offset: 0x80E610 VA: 0x180810010
	|-Unsafe.SizeOf<GlyphPairAdjustmentRecord>
	|-Unsafe.SizeOf<RaycastHit>
	|
	|-RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0
	|-Unsafe.SizeOf<GradientAlphaKey>
	|-Unsafe.SizeOf<object>
	|-Unsafe.SizeOf<jvalue>
	|
	|-RVA: 0x412DA0 Offset: 0x4113A0 VA: 0x180412DA0
	|-Unsafe.SizeOf<GradientColorKey>
	|
	|-RVA: 0x810020 Offset: 0x80E620 VA: 0x180810020
	|-Unsafe.SizeOf<Keyframe>
	|
	|-RVA: 0x80F2C0 Offset: 0x80D8C0 VA: 0x18080F2C0
	|-Unsafe.SizeOf<MarkToBaseAdjustmentRecord>
	|-Unsafe.SizeOf<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x80F2D0 Offset: 0x80D8D0 VA: 0x18080F2D0
	|-Unsafe.SizeOf<RaycastHit2D>
	|
	|-RVA: 0x5513C0 Offset: 0x54F9C0 VA: 0x1805513C0
	|-Unsafe.SizeOf<RenderTargetIdentifier>
	|
	|-RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0
	|-Unsafe.SizeOf<Vector3>
	|
	|-RVA: 0x44E5E0 Offset: 0x44CBE0 VA: 0x18044E5E0
	|-Unsafe.SizeOf<Vertex>
	|
	|-RVA: 0x80F380 Offset: 0x80D980 VA: 0x18080F380
	|-Unsafe.SizeOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x80F3C0 Offset: 0x80D9C0 VA: 0x18080F3C0
	|-Unsafe.SizeOf<ParticleSystem.Particle>
	*/

	// RVA: -1 Offset: -1
	public static void WriteUnaligned<T>(ref byte destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	|-Unsafe.WriteUnaligned<uint>
	|
	|-RVA: 0x810030 Offset: 0x80E630 VA: 0x180810030
	|-Unsafe.WriteUnaligned<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsAddressLessThan<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80FF60 Offset: 0x80E560 VA: 0x18080FF60
	|-Unsafe.IsAddressLessThan<AsyncOperationHandle<object>>
	|-Unsafe.IsAddressLessThan<DataPoint<int>>
	|-Unsafe.IsAddressLessThan<DataPoint<object>>
	|-Unsafe.IsAddressLessThan<DataPoint<float>>
	|-Unsafe.IsAddressLessThan<DataPoint<float4>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<Edge, object>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<int, int>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<int, object>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<long, object>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, bool>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, object>>
	|-Unsafe.IsAddressLessThan<NativeArray<ConvertMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeArray<CopyMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeArray<NudgeJobData>>
	|-Unsafe.IsAddressLessThan<NativeSlice<ConvertMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeSlice<CopyMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeSlice<NudgeJobData>>
	|-Unsafe.IsAddressLessThan<NativeSlice<ushort>>
	|-Unsafe.IsAddressLessThan<NativeSlice<Vertex>>
	|-Unsafe.IsAddressLessThan<TempAllocator.Page<ushort>>
	|-Unsafe.IsAddressLessThan<TempAllocator.Page<Vertex>>
	|-Unsafe.IsAddressLessThan<SimpleTuple<int, int>>
	|-Unsafe.IsAddressLessThan<SimpleTuple<object, Edge>>
	|-Unsafe.IsAddressLessThan<SimpleTuple<object, int>>
	|-Unsafe.IsAddressLessThan<SimpleTuple<object, object>>
	|-Unsafe.IsAddressLessThan<SimpleTuple<float, Vector2>>
	|-Unsafe.IsAddressLessThan<StructMultiKey<object, object>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>
	|-Unsafe.IsAddressLessThan<ValueTuple<int, int>>
	|-Unsafe.IsAddressLessThan<ValueTuple<LocaleIdentifier, object>>
	|-Unsafe.IsAddressLessThan<ValueTuple<Vector2Int, int>>
	|-Unsafe.IsAddressLessThan<ValueTuple<Rect, Rect, object>>
	|-Unsafe.IsAddressLessThan<AsyncOperationHandle>
	|-Unsafe.IsAddressLessThan<BezierKnot>
	|-Unsafe.IsAddressLessThan<BezierPoint>
	|-Unsafe.IsAddressLessThan<bool>
	|-Unsafe.IsAddressLessThan<byte>
	|-Unsafe.IsAddressLessThan<char>
	|-Unsafe.IsAddressLessThan<Color>
	|-Unsafe.IsAddressLessThan<Color32>
	|-Unsafe.IsAddressLessThan<CombineInstance>
	|-Unsafe.IsAddressLessThan<ComputedTransitionProperty>
	|-Unsafe.IsAddressLessThan<ControllerPollingInfo>
	|-Unsafe.IsAddressLessThan<ControllerTemplateElementTarget>
	|-Unsafe.IsAddressLessThan<DateTime>
	|-Unsafe.IsAddressLessThan<DateTimeOffset>
	|-Unsafe.IsAddressLessThan<Decimal>
	|-Unsafe.IsAddressLessThan<DiagnosticEvent>
	|-Unsafe.IsAddressLessThan<DisplayInfo>
	|-Unsafe.IsAddressLessThan<double>
	|-Unsafe.IsAddressLessThan<EasingFunction>
	|-Unsafe.IsAddressLessThan<Edge>
	|-Unsafe.IsAddressLessThan<EdgeLookup>
	|-Unsafe.IsAddressLessThan<ElementAssignmentConflictInfo>
	|-Unsafe.IsAddressLessThan<Entitlement>
	|-Unsafe.IsAddressLessThan<FileStat>
	|-Unsafe.IsAddressLessThan<GCHandle>
	|-Unsafe.IsAddressLessThan<GlyphPairAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<GlyphRect>
	|-Unsafe.IsAddressLessThan<Guid>
	|-Unsafe.IsAddressLessThan<InputActionSourceData>
	|-Unsafe.IsAddressLessThan<short>
	|-Unsafe.IsAddressLessThan<int>
	|-Unsafe.IsAddressLessThan<Int32Enum>
	|-Unsafe.IsAddressLessThan<long>
	|-Unsafe.IsAddressLessThan<IntPtr>
	|-Unsafe.IsAddressLessThan<InterpretedFrameInfo>
	|-Unsafe.IsAddressLessThan<JsonPosition>
	|-Unsafe.IsAddressLessThan<LigatureSubstitutionRecord>
	|-Unsafe.IsAddressLessThan<LigatureSubstitutionRecord>
	|-Unsafe.IsAddressLessThan<ManipulatorActivationFilter>
	|-Unsafe.IsAddressLessThan<MarkToBaseAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<MarkToBaseAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<MarkToMarkAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<MarkToMarkAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<MultipleSubstitutionRecord>
	|-Unsafe.IsAddressLessThan<MultipleSubstitutionRecord>
	|-Unsafe.IsAddressLessThan<object>
	|-Unsafe.IsAddressLessThan<ObjectInitializationData>
	|-Unsafe.IsAddressLessThan<PropertyPath>
	|-Unsafe.IsAddressLessThan<PropertyPathInfo>
	|-Unsafe.IsAddressLessThan<PropertyPathPart>
	|-Unsafe.IsAddressLessThan<Quaternion>
	|-Unsafe.IsAddressLessThan<RangePositionInfo>
	|-Unsafe.IsAddressLessThan<RaycastHit2D>
	|-Unsafe.IsAddressLessThan<RaycastResult>
	|-Unsafe.IsAddressLessThan<RenderTargetIdentifier>
	|-Unsafe.IsAddressLessThan<Resolution>
	|-Unsafe.IsAddressLessThan<RuleMatcher>
	|-Unsafe.IsAddressLessThan<sbyte>
	|-Unsafe.IsAddressLessThan<SelectorMatchRecord>
	|-Unsafe.IsAddressLessThan<SerializedCommand>
	|-Unsafe.IsAddressLessThan<float>
	|-Unsafe.IsAddressLessThan<Sku>
	|-Unsafe.IsAddressLessThan<SplineKnotIndex>
	|-Unsafe.IsAddressLessThan<StylePropertyName>
	|-Unsafe.IsAddressLessThan<StylePropertyValue>
	|-Unsafe.IsAddressLessThan<StyleSelectorPart>
	|-Unsafe.IsAddressLessThan<StyleSyntaxToken>
	|-Unsafe.IsAddressLessThan<StyleValue>
	|-Unsafe.IsAddressLessThan<StyleValueManaged>
	|-Unsafe.IsAddressLessThan<StyleVariable>
	|-Unsafe.IsAddressLessThan<TimeSpan>
	|-Unsafe.IsAddressLessThan<TimeValue>
	|-Unsafe.IsAddressLessThan<TreeViewItemWrapper>
	|-Unsafe.IsAddressLessThan<Triangle>
	|-Unsafe.IsAddressLessThan<TypeWrapper>
	|-Unsafe.IsAddressLessThan<UICharInfo>
	|-Unsafe.IsAddressLessThan<UILineInfo>
	|-Unsafe.IsAddressLessThan<UIVertex>
	|-Unsafe.IsAddressLessThan<ushort>
	|-Unsafe.IsAddressLessThan<uint>
	|-Unsafe.IsAddressLessThan<UInt32Enum>
	|-Unsafe.IsAddressLessThan<ulong>
	|-Unsafe.IsAddressLessThan<User>
	|-Unsafe.IsAddressLessThan<UxmlDescription>
	|-Unsafe.IsAddressLessThan<UxmlNamespaceDefinition>
	|-Unsafe.IsAddressLessThan<Vector2>
	|-Unsafe.IsAddressLessThan<Vector2Int>
	|-Unsafe.IsAddressLessThan<Vector3>
	|-Unsafe.IsAddressLessThan<Vector4>
	|-Unsafe.IsAddressLessThan<X509ChainStatus>
	|-Unsafe.IsAddressLessThan<__Il2CppFullySharedGenericType>
	|-Unsafe.IsAddressLessThan<float3>
	|-Unsafe.IsAddressLessThan<fsVersionedType>
	|-Unsafe.IsAddressLessThan<AnimatedMeshScriptableObject.Animation>
	|-Unsafe.IsAddressLessThan<Awaitable.AwaitableAndFrameIndex>
	|-Unsafe.IsAddressLessThan<BeforeRenderHelper.OrderBlock>
	|-Unsafe.IsAddressLessThan<BitmapAllocator32.Page>
	|-Unsafe.IsAddressLessThan<CharacterSubstitutor.CharReplacement>
	|-Unsafe.IsAddressLessThan<CreationContext.AttributeOverrideRange>
	|-Unsafe.IsAddressLessThan<CreationContext.SerializedDataOverrideRange>
	|-Unsafe.IsAddressLessThan<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>
	|-Unsafe.IsAddressLessThan<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>
	|-Unsafe.IsAddressLessThan<DataBindingManager.BindingData>
	|-Unsafe.IsAddressLessThan<DataBindingManager.BindingRequest>
	|-Unsafe.IsAddressLessThan<DelayedActionManager.DelegateInfo>
	|-Unsafe.IsAddressLessThan<EntryPreProcessor.AllocSize>
	|-Unsafe.IsAddressLessThan<EventProvider.Registration>
	|-Unsafe.IsAddressLessThan<Expander.ExpansionRule>
	|-Unsafe.IsAddressLessThan<FocusController.FocusedElement>
	|-Unsafe.IsAddressLessThan<GrassChunkManager.GrassData>
	|-Unsafe.IsAddressLessThan<GrassChunkManager.GrassInstance>
	|-Unsafe.IsAddressLessThan<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|-Unsafe.IsAddressLessThan<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>
	|-Unsafe.IsAddressLessThan<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>
	|-Unsafe.IsAddressLessThan<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>
	|-Unsafe.IsAddressLessThan<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>
	|-Unsafe.IsAddressLessThan<MeshGenerator.RepeatRectUV>
	|-Unsafe.IsAddressLessThan<MeshGenerator.TessellationJobParameters>
	|-Unsafe.IsAddressLessThan<MultiColumnCollectionHeader.SortedColumnState>
	|-Unsafe.IsAddressLessThan<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-Unsafe.IsAddressLessThan<Painter2D.Painter2DJobData>
	|-Unsafe.IsAddressLessThan<RaycastUtility.ConeSphere>
	|-Unsafe.IsAddressLessThan<RegexCharClass.SingleRange>
	|-Unsafe.IsAddressLessThan<ResourceManager.DeferredCallbackRegisterRequest>
	|-Unsafe.IsAddressLessThan<SplineInstantiate.InstantiableItem>
	|-Unsafe.IsAddressLessThan<TemplateAsset.AttributeOverride>
	|-Unsafe.IsAddressLessThan<TemplateAsset.UxmlSerializedDataOverride>
	|-Unsafe.IsAddressLessThan<TextSettings.FontReferenceMap>
	|-Unsafe.IsAddressLessThan<TextureBlitter.BlitInfo>
	|-Unsafe.IsAddressLessThan<TexturePacker_JsonArray.Frame>
	|-Unsafe.IsAddressLessThan<TextureRegistry.TextureInfo>
	|-Unsafe.IsAddressLessThan<UIRenderDevice.AllocToFree>
	|-Unsafe.IsAddressLessThan<UIRenderDevice.AllocToUpdate>
	|-Unsafe.IsAddressLessThan<UnitySynchronizationContext.WorkRequest>
	|-Unsafe.IsAddressLessThan<UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.AssetEntry>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.SlotDefinition>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.SlotUsageEntry>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.UsingEntry>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.UxmlObjectEntry>
	|-Unsafe.IsAddressLessThan<VisualTreeDataBindingsUpdater.VersionInfo>
	|-Unsafe.IsAddressLessThan<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Unsafe.IsAddressLessThan<fsAotCompilationManager.AotCompilation>
	|-Unsafe.IsAddressLessThan<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>
	|-Unsafe.IsAddressLessThan<InstructionList.DebugView.InstructionView>
	|-Unsafe.IsAddressLessThan<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Unsafe.IsAddressLessThan<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>
	|-Unsafe.IsAddressLessThan<RenderChain.VisualChangesProcessor.EntryProcessingInfo>
	|-Unsafe.IsAddressLessThan<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>
	|-Unsafe.IsAddressLessThan<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>
	*/

	// RVA: -1 Offset: -1
	internal static ref T AddByteOffset<T>(ref T source, ulong byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80FC00 Offset: 0x80E200 VA: 0x18080FC00
	|-Unsafe.AddByteOffset<bool>
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<Color>
	|-Unsafe.AddByteOffset<Color32>
	|-Unsafe.AddByteOffset<CombineInstance>
	|-Unsafe.AddByteOffset<ContactPoint>
	|-Unsafe.AddByteOffset<GlyphMarshallingStruct>
	|-Unsafe.AddByteOffset<GlyphPairAdjustmentRecord>
	|-Unsafe.AddByteOffset<GlyphRect>
	|-Unsafe.AddByteOffset<GradientAlphaKey>
	|-Unsafe.AddByteOffset<GradientColorKey>
	|-Unsafe.AddByteOffset<int>
	|-Unsafe.AddByteOffset<Int32Enum>
	|-Unsafe.AddByteOffset<Keyframe>
	|-Unsafe.AddByteOffset<MarkToBaseAdjustmentRecord>
	|-Unsafe.AddByteOffset<MarkToMarkAdjustmentRecord>
	|-Unsafe.AddByteOffset<object>
	|-Unsafe.AddByteOffset<RaycastHit>
	|-Unsafe.AddByteOffset<RaycastHit2D>
	|-Unsafe.AddByteOffset<RenderTargetIdentifier>
	|-Unsafe.AddByteOffset<Resolution>
	|-Unsafe.AddByteOffset<float>
	|-Unsafe.AddByteOffset<ushort>
	|-Unsafe.AddByteOffset<uint>
	|-Unsafe.AddByteOffset<Vector3>
	|-Unsafe.AddByteOffset<Vector4>
	|-Unsafe.AddByteOffset<Vertex>
	|-Unsafe.AddByteOffset<VertexAttributeDescriptor>
	|-Unsafe.AddByteOffset<jvalue>
	|-Unsafe.AddByteOffset<ParticleSystem.Particle>
	|
	|-RVA: 0x80FC30 Offset: 0x80E230 VA: 0x18080FC30
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 3085
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 4604
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x34D4E0 Offset: 0x34BAE0 VA: 0x18034D4E0
	public void .ctor(byte ) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 4605
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 8114
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 8115
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x15C6E50 Offset: 0x15C5450 VA: 0x1815C6E50
	public void .ctor(byte ) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 8116
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 8607
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1AC9270 Offset: 0x1AC7870 VA: 0x181AC9270
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5196, AllowMultiple = False, Inherited = False)]
[CompilerGenerated]
[Embedded]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 8608
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 9402
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public static class RuntimeOps // TypeDefIndex: 11274
{
	// Methods

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A619A0 Offset: 0x1A5FFA0 VA: 0x181A619A0
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A619D0 Offset: 0x1A5FFD0 VA: 0x181A619D0
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1A618F0 Offset: 0x1A5FEF0 VA: 0x181A618F0
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A618A0 Offset: 0x1A5FEA0 VA: 0x181A618A0
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A618D0 Offset: 0x1A5FED0 VA: 0x181A618D0
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass) { }
}

// Namespace: System.Runtime.CompilerServices
public class CallSite // TypeDefIndex: 11275
{
	// Fields
	internal readonly CallSiteBinder _binder; // 0x10
	internal bool _match; // 0x18

	// Properties
	public CallSiteBinder Binder { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(CallSiteBinder binder) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public CallSiteBinder get_Binder() { }
}

// Namespace: System.Runtime.CompilerServices
public class CallSite<T> : CallSite // TypeDefIndex: 11277
{
	// Fields
	public T Target; // 0x0
	internal T[] Rules; // 0x0
	private static T s_cachedUpdate; // 0x0
	private static T s_cachedNoMatch; // 0x0

	// Properties
	public T Update { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91B70 Offset: 0xC90170 VA: 0x180C91B70
	|-CallSite<object>.get_Update
	*/

	// RVA: -1 Offset: -1
	private void .ctor(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC919A0 Offset: 0xC8FFA0 VA: 0x180C919A0
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91B60 Offset: 0xC90160 VA: 0x180C91B60
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal CallSite<T> CreateMatchMaker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC912D0 Offset: 0xC8F8D0 VA: 0x180C912D0
	|-CallSite<object>.CreateMatchMaker
	*/

	// RVA: -1 Offset: -1
	public static CallSite<T> Create(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91320 Offset: 0xC8F920 VA: 0x180C91320
	|-CallSite<object>.Create
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91480 Offset: 0xC8FA80 VA: 0x180C91480
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate(ref T addr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91620 Offset: 0xC8FC20 VA: 0x180C91620
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8F960 Offset: 0xC8DF60 VA: 0x180C8F960
	|-CallSite<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC918E0 Offset: 0xC8FEE0 VA: 0x180C918E0
	|-CallSite<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal T MakeUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC917A0 Offset: 0xC8FDA0 VA: 0x180C917A0
	|-CallSite<object>.MakeUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8FEE0 Offset: 0xC8E4E0 VA: 0x180C8FEE0
	|-CallSite<object>.CreateCustomUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8FB70 Offset: 0xC8E170 VA: 0x180C8FB70
	|-CallSite<object>.CreateCustomNoMatchDelegate
	*/

	// RVA: -1 Offset: -1
	private static Expression Convert(Expression arg, Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8FAA0 Offset: 0xC8E0A0 VA: 0x180C8FAA0
	|-CallSite<object>.Convert
	*/
}

// Namespace: System.Runtime.CompilerServices
public abstract class CallSiteBinder // TypeDefIndex: 11279
{
	// Fields
	internal Dictionary<Type, object> Cache; // 0x10
	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; // 0x0

	// Properties
	public static LabelTarget UpdateLabel { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A4AC60 Offset: 0x1A49260 VA: 0x181A4AC60
	public static LabelTarget get_UpdateLabel() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T BindDelegate<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	|-CallSiteBinder.BindDelegate<object>
	*/

	// RVA: -1 Offset: -1
	internal T BindCore<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B2FF0 Offset: 0x6B15F0 VA: 0x1806B2FF0
	|-CallSiteBinder.BindCore<object>
	*/

	// RVA: -1 Offset: -1
	protected void CacheTarget<T>(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B3170 Offset: 0x6B1770 VA: 0x1806B3170
	|-CallSiteBinder.CacheTarget<object>
	*/

	// RVA: -1 Offset: -1
	private static Expression<T> Stitch<T>(Expression binding, CallSiteBinder.LambdaSignature<T> signature) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B3440 Offset: 0x6B1A40 VA: 0x1806B3440
	|-CallSiteBinder.Stitch<object>
	*/

	// RVA: -1 Offset: -1
	internal RuleCache<T> GetRuleCache<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B31E0 Offset: 0x6B17E0 VA: 0x1806B31E0
	|-CallSiteBinder.GetRuleCache<object>
	*/

	// RVA: 0x1A4ABD0 Offset: 0x1A491D0 VA: 0x181A4ABD0
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public static class CallSiteOps // TypeDefIndex: 11280
{
	// Methods

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B38D0 Offset: 0x6B1ED0 VA: 0x1806B38D0
	|-CallSiteOps.CreateMatchmaker<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A4ACD0 Offset: 0x1A492D0 VA: 0x181A4ACD0
	public static bool SetNotMatched(CallSite site) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x12E7510 Offset: 0x12E5B10 VA: 0x1812E7510
	public static bool GetMatch(CallSite site) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A4ACB0 Offset: 0x1A492B0 VA: 0x181A4ACB0
	public static void ClearMatch(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void AddRule<T>(CallSite<T> site, T rule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B3800 Offset: 0x6B1E00 VA: 0x1806B3800
	|-CallSiteOps.AddRule<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static void UpdateRules<T>(CallSite<T> this, int matched) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B3A30 Offset: 0x6B2030 VA: 0x1806B3A30
	|-CallSiteOps.UpdateRules<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static T[] GetRules<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B39A0 Offset: 0x6B1FA0 VA: 0x1806B39A0
	|-CallSiteOps.GetRules<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B3950 Offset: 0x6B1F50 VA: 0x1806B3950
	|-CallSiteOps.GetRuleCache<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B39C0 Offset: 0x6B1FC0 VA: 0x1806B39C0
	|-CallSiteOps.MoveRule<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static T[] GetCachedRules<T>(RuleCache<T> cache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B3920 Offset: 0x6B1F20 VA: 0x1806B3920
	|-CallSiteOps.GetCachedRules<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B3860 Offset: 0x6B1E60 VA: 0x1806B3860
	|-CallSiteOps.Bind<object>
	*/
}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
public interface IRuntimeVariables // TypeDefIndex: 11281
{}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
[Serializable]
public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 11283
{
	// Fields
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DD8F0 Offset: 0x8DBEF0 VA: 0x1808DD8F0
	|-ReadOnlyCollectionBuilder<object>..ctor
	|
	|-RVA: 0x8E07A0 Offset: 0x8DEDA0 VA: 0x1808E07A0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FC8C0 Offset: 0x8FAEC0 VA: 0x1808FC8C0
	|-ReadOnlyCollectionBuilder<object>..ctor
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FCB00 Offset: 0x8FB100 VA: 0x1808FCB00
	|-ReadOnlyCollectionBuilder<object>.set_Capacity
	|
	|-RVA: 0x8FCC10 Offset: 0x8FB210 VA: 0x1808FCC10
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-ReadOnlyCollectionBuilder<object>.get_Count
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FA650 Offset: 0x8F8C50 VA: 0x1808FA650
	|-ReadOnlyCollectionBuilder<object>.IndexOf
	|
	|-RVA: 0x8FA530 Offset: 0x8F8B30 VA: 0x1808FA530
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FA680 Offset: 0x8F8C80 VA: 0x1808FA680
	|-ReadOnlyCollectionBuilder<object>.Insert
	|
	|-RVA: 0x8FA790 Offset: 0x8F8D90 VA: 0x1808FA790
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FAB20 Offset: 0x8F9120 VA: 0x1808FAB20
	|-ReadOnlyCollectionBuilder<object>.RemoveAt
	|
	|-RVA: 0x8FABE0 Offset: 0x8F91E0 VA: 0x1808FABE0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FC970 Offset: 0x8FAF70 VA: 0x1808FC970
	|-ReadOnlyCollectionBuilder<object>.get_Item
	|
	|-RVA: 0x8FC9F0 Offset: 0x8FAFF0 VA: 0x1808FC9F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FCEA0 Offset: 0x8FB4A0 VA: 0x1808FCEA0
	|-ReadOnlyCollectionBuilder<object>.set_Item
	|
	|-RVA: 0x8FCD20 Offset: 0x8FB320 VA: 0x1808FCD20
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9DA0 Offset: 0x8F83A0 VA: 0x1808F9DA0
	|-ReadOnlyCollectionBuilder<object>.Add
	|
	|-RVA: 0x8F9C30 Offset: 0x8F8230 VA: 0x1808F9C30
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9E30 Offset: 0x8F8430 VA: 0x1808F9E30
	|-ReadOnlyCollectionBuilder<object>.Clear
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9E70 Offset: 0x8F8470 VA: 0x1808F9E70
	|-ReadOnlyCollectionBuilder<object>.Contains
	|
	|-RVA: 0x8FA040 Offset: 0x8F8640 VA: 0x1808FA040
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FA290 Offset: 0x8F8890 VA: 0x1808FA290
	|-ReadOnlyCollectionBuilder<object>.CopyTo
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FADC0 Offset: 0x8F93C0 VA: 0x1808FADC0
	|-ReadOnlyCollectionBuilder<object>.Remove
	|
	|-RVA: 0x8FAEE0 Offset: 0x8F94E0 VA: 0x1808FAEE0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FA450 Offset: 0x8F8A50 VA: 0x1808FA450
	|-ReadOnlyCollectionBuilder<object>.GetEnumerator
	|
	|-RVA: 0x8FA4C0 Offset: 0x8F8AC0 VA: 0x1808FA4C0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FB0F0 Offset: 0x8F96F0 VA: 0x1808FB0F0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8FB170 Offset: 0x8F9770 VA: 0x1808FB170
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FB370 Offset: 0x8F9970 VA: 0x1808FB370
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Add
	|
	|-RVA: 0x8FB1A0 Offset: 0x8F97A0 VA: 0x1808FB1A0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FB500 Offset: 0x8F9B00 VA: 0x1808FB500
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x8FB600 Offset: 0x8F9C00 VA: 0x1808FB600
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FB860 Offset: 0x8F9E60 VA: 0x1808FB860
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x8FB730 Offset: 0x8F9D30 VA: 0x1808FB730
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FBB30 Offset: 0x8FA130 VA: 0x1808FBB30
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x8FB980 Offset: 0x8F9F80 VA: 0x1808FB980
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FBE50 Offset: 0x8FA450 VA: 0x1808FBE50
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x8FBD30 Offset: 0x8FA330 VA: 0x1808FBD30
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FC030 Offset: 0x8FA630 VA: 0x1808FC030
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x8FC0C0 Offset: 0x8FA6C0 VA: 0x1808FC0C0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FC330 Offset: 0x8FA930 VA: 0x1808FC330
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x8FC180 Offset: 0x8FA780 VA: 0x1808FC180
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FB000 Offset: 0x8F9600 VA: 0x1808FB000
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.CopyTo
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_SyncRoot
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FC4C0 Offset: 0x8FAAC0 VA: 0x1808FC4C0
	|-ReadOnlyCollectionBuilder<object>.ToArray
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FC630 Offset: 0x8FAC30 VA: 0x1808FC630
	|-ReadOnlyCollectionBuilder<object>.ToReadOnlyCollection
	|
	|-RVA: 0x8FC530 Offset: 0x8FAB30 VA: 0x1808FC530
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FA2C0 Offset: 0x8F88C0 VA: 0x1808FA2C0
	|-ReadOnlyCollectionBuilder<object>.EnsureCapacity
	|
	|-RVA: 0x8FA3F0 Offset: 0x8F89F0 VA: 0x1808FA3F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FAAC0 Offset: 0x8F90C0 VA: 0x1808FAAC0
	|-ReadOnlyCollectionBuilder<object>.IsCompatibleObject
	|
	|-RVA: 0x8FA970 Offset: 0x8F8F70 VA: 0x1808FA970
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void ValidateNullValue(object value, string argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	|-ReadOnlyCollectionBuilder<object>.ValidateNullValue
	|
	|-RVA: 0x8FC760 Offset: 0x8FAD60 VA: 0x1808FC760
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ValidateNullValue
	*/
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public class RuleCache<T> // TypeDefIndex: 11284
{
	// Fields
	private T[] _rules; // 0x0
	private readonly object _cacheLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x962B70 Offset: 0x961170 VA: 0x180962B70
	|-RuleCache<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] GetRules() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-RuleCache<object>.GetRules
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9628E0 Offset: 0x960EE0 VA: 0x1809628E0
	|-RuleCache<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9626F0 Offset: 0x960CF0 VA: 0x1809626F0
	|-RuleCache<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	private static T[] AddOrInsert(T[] rules, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9625A0 Offset: 0x960BA0 VA: 0x1809625A0
	|-RuleCache<object>.AddOrInsert
	*/
}

// Namespace: System.Runtime.CompilerServices
internal sealed class TrueReadOnlyCollection<T> : ReadOnlyCollection<T> // TypeDefIndex: 11285
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64B80 Offset: 0xA63180 VA: 0x180A64B80
	|-TrueReadOnlyCollection<object>..ctor
	|
	|-RVA: 0xA39740 Offset: 0xA37D40 VA: 0x180A39740
	|-TrueReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Runtime.CompilerServices
public class StrongBox<T> : IStrongBox // TypeDefIndex: 11286
{
	// Fields
	public T Value; // 0x0

	// Properties
	private object System.Runtime.CompilerServices.IStrongBox.Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-StrongBox<int>..ctor
	|-StrongBox<object>..ctor
	|-StrongBox<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	|-StrongBox<int>..ctor
	|
	|-RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	|-StrongBox<object>..ctor
	|
	|-RVA: 0x8F9980 Offset: 0x8F7F80 VA: 0x1808F9980
	|-StrongBox<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object System.Runtime.CompilerServices.IStrongBox.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BAA10 Offset: 0x9B9010 VA: 0x1809BAA10
	|-StrongBox<int>.System.Runtime.CompilerServices.IStrongBox.get_Value
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-StrongBox<object>.System.Runtime.CompilerServices.IStrongBox.get_Value
	|
	|-RVA: 0x9BAA40 Offset: 0x9B9040 VA: 0x1809BAA40
	|-StrongBox<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.IStrongBox.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Runtime.CompilerServices.IStrongBox.set_Value(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BABC0 Offset: 0x9B91C0 VA: 0x1809BABC0
	|-StrongBox<int>.System.Runtime.CompilerServices.IStrongBox.set_Value
	|
	|-RVA: 0x9BAC30 Offset: 0x9B9230 VA: 0x1809BAC30
	|-StrongBox<object>.System.Runtime.CompilerServices.IStrongBox.set_Value
	|
	|-RVA: 0x9BAAF0 Offset: 0x9B90F0 VA: 0x1809BAAF0
	|-StrongBox<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.IStrongBox.set_Value
	*/
}

// Namespace: System.Runtime.CompilerServices
public interface IStrongBox // TypeDefIndex: 11287
{
	// Properties
	public abstract object Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Value(object value);
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 12623
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(364, Inherited = False)]
internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 13646
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

