// Namespace: System.Runtime.Serialization
public interface IDeserializationCallback // TypeDefIndex: 967
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeserialization(object sender);
}

// Namespace: System.Runtime.Serialization
[CLSCompliant(False)]
public interface IFormatterConverter // TypeDefIndex: 968
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Convert(object value, Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(object value);
}

// Namespace: System.Runtime.Serialization
public interface IObjectReference // TypeDefIndex: 969
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetRealObject(StreamingContext context);
}

// Namespace: System.Runtime.Serialization
public interface ISerializable // TypeDefIndex: 970
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(SerializationInfo info, StreamingContext context);
}

// Namespace: System.Runtime.Serialization
[Serializable]
public class SerializationException : SystemException // TypeDefIndex: 971
{
	// Fields
	private static string s_nullMessage; // 0x0

	// Methods

	// RVA: 0x13F5220 Offset: 0x13F3820 VA: 0x1813F5220
	public void .ctor() { }

	// RVA: 0x13F5200 Offset: 0x13F3800 VA: 0x1813F5200
	public void .ctor(string message) { }

	// RVA: 0x13F5290 Offset: 0x13F3890 VA: 0x1813F5290
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13F5190 Offset: 0x13F3790 VA: 0x1813F5190
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
[IsReadOnly]
public struct SerializationEntry // TypeDefIndex: 972
{
	// Fields
	private readonly string _name; // 0x0
	private readonly object _value; // 0x8
	private readonly Type _type; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0xB2ED20 Offset: 0xB2D320 VA: 0x180B2ED20
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public object get_Value() { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public string get_Name() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 973
{
	// Fields
	private readonly string[] _members; // 0x10
	private readonly object[] _data; // 0x18
	private readonly Type[] _types; // 0x20
	private readonly int _numItems; // 0x28
	private int _currItem; // 0x2C
	private bool _current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x13F5340 Offset: 0x13F3940 VA: 0x1813F5340
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x13F52B0 Offset: 0x13F38B0 VA: 0x1813F52B0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x13F52E0 Offset: 0x13F38E0 VA: 0x1813F52E0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13F53C0 Offset: 0x13F39C0 VA: 0x1813F53C0
	public SerializationEntry get_Current() { }

	// RVA: 0x13F52D0 Offset: 0x13F38D0 VA: 0x1813F52D0 Slot: 6
	public void Reset() { }

	// RVA: 0x13F54E0 Offset: 0x13F3AE0 VA: 0x1813F54E0
	public string get_Name() { }

	// RVA: 0x13F5600 Offset: 0x13F3C00 VA: 0x1813F5600
	public object get_Value() { }

	// RVA: 0x13F5570 Offset: 0x13F3B70 VA: 0x1813F5570
	public Type get_ObjectType() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class DeserializationEventHandler : MulticastDelegate // TypeDefIndex: 974
{
	// Methods

	// RVA: 0x5C3910 Offset: 0x5C1F10 VA: 0x1805C3910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object sender) { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 975
{
	// Methods

	// RVA: 0xAC80F0 Offset: 0xAC66F0 VA: 0x180AC80F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAC7F00 Offset: 0xAC6500 VA: 0x180AC7F00 Slot: 13
	public virtual void Invoke(StreamingContext context) { }
}

// Namespace: System.Runtime.Serialization
public class FormatterConverter : IFormatterConverter // TypeDefIndex: 976
{
	// Methods

	// RVA: 0x13E3B50 Offset: 0x13E2150 VA: 0x1813E3B50 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x13E3C40 Offset: 0x13E2240 VA: 0x1813E3C40 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x13E3CD0 Offset: 0x13E22D0 VA: 0x1813E3CD0 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x13E3D60 Offset: 0x13E2360 VA: 0x1813E3D60 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x13E3DF0 Offset: 0x13E23F0 VA: 0x1813E3DF0 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x13E3E80 Offset: 0x13E2480 VA: 0x1813E3E80 Slot: 9
	public string ToString(object value) { }

	// RVA: 0x13E3BF0 Offset: 0x13E21F0 VA: 0x1813E3BF0
	private static void ThrowValueNullException() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
public interface ISerializationSurrogate // TypeDefIndex: 977
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
}

// Namespace: System.Runtime.Serialization
public interface ISurrogateSelector // TypeDefIndex: 978
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class MemberHolder // TypeDefIndex: 979
{
	// Fields
	internal readonly Type _memberType; // 0x10
	internal readonly StreamingContext _context; // 0x18

	// Methods

	// RVA: 0xA672D0 Offset: 0xA658D0 VA: 0x180A672D0
	internal void .ctor(Type type, StreamingContext ctx) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13E84B0 Offset: 0x13E6AB0 VA: 0x1813E84B0 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
public abstract class SerializationBinder // TypeDefIndex: 980
{
	// Methods

	// RVA: 0x13F48F0 Offset: 0x13F2EF0 VA: 0x1813F48F0 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SerializationEvents // TypeDefIndex: 981
{
	// Fields
	private readonly List<MethodInfo> _onSerializingMethods; // 0x10
	private readonly List<MethodInfo> _onSerializedMethods; // 0x18
	private readonly List<MethodInfo> _onDeserializingMethods; // 0x20
	private readonly List<MethodInfo> _onDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x13F5020 Offset: 0x13F3620 VA: 0x1813F5020
	internal void .ctor(Type t) { }

	// RVA: 0x13F4D50 Offset: 0x13F3350 VA: 0x1813F4D50
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x13F5170 Offset: 0x13F3770 VA: 0x1813F5170
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x13F4FE0 Offset: 0x13F35E0 VA: 0x1813F4FE0
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x13F4FA0 Offset: 0x13F35A0 VA: 0x1813F4FA0
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x13F4F60 Offset: 0x13F3560 VA: 0x1813F4F60
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x13F4D30 Offset: 0x13F3330 VA: 0x1813F4D30
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x13F4D10 Offset: 0x13F3310 VA: 0x1813F4D10
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x13F4F20 Offset: 0x13F3520 VA: 0x1813F4F20
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	// RVA: 0x13F4B10 Offset: 0x13F3110 VA: 0x1813F4B10
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }
}

// Namespace: System.Runtime.Serialization
internal static class SerializationEventsCache // TypeDefIndex: 983
{
	// Fields
	private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache; // 0x0

	// Methods

	// RVA: 0x13F4920 Offset: 0x13F2F20 VA: 0x1813F4920
	internal static SerializationEvents GetSerializationEventsForType(Type t) { }

	// RVA: 0x13F4A80 Offset: 0x13F3080 VA: 0x1813F4A80
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationObjectManager // TypeDefIndex: 984
{
	// Fields
	private readonly Dictionary<object, object> _objectSeenTable; // 0x10
	private readonly StreamingContext _context; // 0x18
	private SerializationEventHandler _onSerializedHandler; // 0x28

	// Methods

	// RVA: 0x13F5900 Offset: 0x13F3F00 VA: 0x1813F5900
	public void .ctor(StreamingContext context) { }

	// RVA: 0x13F5760 Offset: 0x13F3D60 VA: 0x1813F5760
	public void RegisterObject(object obj) { }

	// RVA: 0x13F5730 Offset: 0x13F3D30 VA: 0x1813F5730
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x13F5690 Offset: 0x13F3C90 VA: 0x1813F5690
	private void AddOnSerialized(object obj) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class ValueTypeFixupInfo // TypeDefIndex: 985
{
	// Fields
	private readonly long _containerID; // 0x10
	private readonly FieldInfo _parentField; // 0x18
	private readonly int[] _parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x13F7660 Offset: 0x13F5C60 VA: 0x1813F7660
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public long get_ContainerID() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public FieldInfo get_ParentField() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public int[] get_ParentIndex() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public static class FormatterServices // TypeDefIndex: 987
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x13E6750 Offset: 0x13E4D50 VA: 0x1813E6750
	private static void .cctor() { }

	// RVA: 0x13E5230 Offset: 0x13E3830 VA: 0x1813E5230
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x13E3F10 Offset: 0x13E2510 VA: 0x1813E3F10
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x13E5910 Offset: 0x13E3F10 VA: 0x1813E5910
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x13E4B60 Offset: 0x13E3160 VA: 0x1813E4B60
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x13E53D0 Offset: 0x13E39D0 VA: 0x1813E53D0
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x13E5740 Offset: 0x13E3D40 VA: 0x1813E5740
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x13E4F80 Offset: 0x13E3580 VA: 0x1813E4F80
	public static object GetSafeUninitializedObject(Type type) { }

	// RVA: 0x13D8780 Offset: 0x13D6D80 VA: 0x1813D8780
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x13D8780 Offset: 0x13D6D80 VA: 0x1813D8780
	private static object nativeGetSafeUninitializedObject(RuntimeType type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x13E6680 Offset: 0x13E4C80 VA: 0x1813E6680
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x13E6460 Offset: 0x13E4A60 VA: 0x1813E6460
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x13E60D0 Offset: 0x13E46D0 VA: 0x1813E60D0
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x13E4750 Offset: 0x13E2D50 VA: 0x1813E4750
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x13E5690 Offset: 0x13E3C90 VA: 0x1813E5690
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x13E60C0 Offset: 0x13E46C0 VA: 0x1813E60C0
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x13E6060 Offset: 0x13E4660 VA: 0x1813E6060
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x13E3F40 Offset: 0x13E2540 VA: 0x1813E3F40
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x13E46D0 Offset: 0x13E2CD0 VA: 0x1813E46D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x13E40D0 Offset: 0x13E26D0 VA: 0x1813E40D0
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x13E4300 Offset: 0x13E2900 VA: 0x1813E4300
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate // TypeDefIndex: 988
{
	// Fields
	private ISerializationSurrogate innerSurrogate; // 0x10

	// Methods

	// RVA: 0x13F7160 Offset: 0x13F5760 VA: 0x1813F7160 Slot: 4
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13F7250 Offset: 0x13F5850 VA: 0x1813F7250 Slot: 5
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Serializable]
public class ObjectIDGenerator // TypeDefIndex: 989
{
	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x13EF3B0 Offset: 0x13ED9B0 VA: 0x1813EF3B0
	public void .ctor() { }

	// RVA: 0x13EECE0 Offset: 0x13ED2E0 VA: 0x1813EECE0
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x13EEDA0 Offset: 0x13ED3A0 VA: 0x1813EEDA0 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x13EEF40 Offset: 0x13ED540 VA: 0x1813EEF40 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x13EF020 Offset: 0x13ED620 VA: 0x1813EF020
	private void Rehash() { }

	// RVA: 0x13EF320 Offset: 0x13ED920 VA: 0x1813EF320
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public class ObjectManager // TypeDefIndex: 990
{
	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x13F3550 Offset: 0x13F1B50 VA: 0x1813F3550
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private bool CanCallGetType(object obj) { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_TopObject(object value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal object get_TopObject() { }

	// RVA: 0x13F35E0 Offset: 0x13F1BE0 VA: 0x1813F35E0
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x13F15F0 Offset: 0x13EFBF0 VA: 0x1813F15F0
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x13F1640 Offset: 0x13EFC40 VA: 0x1813F1640
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x13EF490 Offset: 0x13EDA90 VA: 0x1813EF490
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x13F1AC0 Offset: 0x13F00C0 VA: 0x1813F1AC0
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x13F1790 Offset: 0x13EFD90 VA: 0x1813F1790
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x13F3310 Offset: 0x13F1910 VA: 0x1813F3310
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x13F1040 Offset: 0x13EF640 VA: 0x1813F1040
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x13EFA80 Offset: 0x13EE080 VA: 0x1813EFA80
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x13F0EF0 Offset: 0x13EF4F0 VA: 0x1813F0EF0
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x13F1FA0 Offset: 0x13F05A0 VA: 0x1813F1FA0 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x13F3210 Offset: 0x13F1810 VA: 0x1813F3210
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x13F2A20 Offset: 0x13F1020 VA: 0x1813F2A20
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x13EF700 Offset: 0x13EDD00 VA: 0x1813EF700
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13F1E70 Offset: 0x13F0470 VA: 0x1813F1E70
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x13F0AC0 Offset: 0x13EF0C0 VA: 0x1813F0AC0 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x13F2820 Offset: 0x13F0E20 VA: 0x1813F2820
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x13F2570 Offset: 0x13F0B70 VA: 0x1813F2570 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x13F23F0 Offset: 0x13F09F0 VA: 0x1813F23F0 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x13F2270 Offset: 0x13F0870 VA: 0x1813F2270 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x13F2090 Offset: 0x13F0690 VA: 0x1813F2090 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x13EF5C0 Offset: 0x13EDBC0 VA: 0x1813EF5C0 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x13EF660 Offset: 0x13EDC60 VA: 0x1813EF660 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x13F20F0 Offset: 0x13F06F0 VA: 0x1813F20F0 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x13F21B0 Offset: 0x13F07B0 VA: 0x1813F21B0
	public void RaiseOnDeserializingEvent(object obj) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class ObjectHolder // TypeDefIndex: 991
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x13EE680 Offset: 0x13ECC80 VA: 0x1813EE680
	internal void .ctor(long objID) { }

	// RVA: 0x13EE740 Offset: 0x13ECD40 VA: 0x1813EE740
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x13EE9D0 Offset: 0x13ECFD0 VA: 0x1813EE9D0
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x13EE230 Offset: 0x13EC830 VA: 0x1813EE230
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x13EE1D0 Offset: 0x13EC7D0 VA: 0x1813EE1D0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x13EE250 Offset: 0x13EC850 VA: 0x1813EE250
	internal void RemoveDependency(long id) { }

	// RVA: 0x13EE0E0 Offset: 0x13EC6E0 VA: 0x1813EE0E0
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x13EE620 Offset: 0x13ECC20 VA: 0x1813EE620
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x13EE050 Offset: 0x13EC650 VA: 0x1813EE050
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x13EE430 Offset: 0x13ECA30 VA: 0x1813EE430
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x13EE240 Offset: 0x13EC840 VA: 0x1813EE240
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x13EE270 Offset: 0x13EC870 VA: 0x1813EE270
	internal void SetFlags() { }

	// RVA: 0x13EEC00 Offset: 0x13ED200 VA: 0x1813EEC00
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x13EEC90 Offset: 0x13ED290 VA: 0x1813EEC90
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x13EEC10 Offset: 0x13ED210 VA: 0x1813EEC10
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x13EEC40 Offset: 0x13ED240 VA: 0x1813EEC40
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x13EEC60 Offset: 0x13ED260 VA: 0x1813EEC60
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x13EECD0 Offset: 0x13ED2D0 VA: 0x1813EECD0
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x13EEBE0 Offset: 0x13ED1E0 VA: 0x1813EEBE0
	internal bool get_HasISerializable() { }

	// RVA: 0x13EEBF0 Offset: 0x13ED1F0 VA: 0x1813EEBF0
	internal bool get_HasSurrogate() { }

	// RVA: 0x13EEB10 Offset: 0x13ED110 VA: 0x1813EEB10
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x13EEAF0 Offset: 0x13ED0F0 VA: 0x1813EEAF0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x1375F40 Offset: 0x1374540 VA: 0x181375F40
	internal int get_TotalDependentObjects() { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	internal bool get_Reachable() { }

	// RVA: 0x528960 Offset: 0x526F60 VA: 0x180528960
	internal void set_Reachable(bool value) { }

	// RVA: 0x13EEC50 Offset: 0x13ED250 VA: 0x1813EEC50
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal object get_ObjectValue() { }

	// RVA: 0x13EE300 Offset: 0x13EC900 VA: 0x1813EE300
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal LongList get_DependentObjects() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x13EEC20 Offset: 0x13ED220 VA: 0x1813EEC20
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x13EECB0 Offset: 0x13ED2B0 VA: 0x1813EECB0
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x13EEBA0 Offset: 0x13ED1A0 VA: 0x1813EEBA0
	internal bool get_CompletelyFixed() { }

	// RVA: 0x13EEBC0 Offset: 0x13ED1C0 VA: 0x1813EEBC0
	internal long get_ContainerID() { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolder // TypeDefIndex: 992
{
	// Fields
	internal long m_id; // 0x10
	internal object m_fixupInfo; // 0x18
	internal int m_fixupType; // 0x20

	// Methods

	// RVA: 0x13FE270 Offset: 0x13FC870 VA: 0x1813FE270
	internal void .ctor(long id, object fixupInfo, int fixupType) { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolderList // TypeDefIndex: 993
{
	// Fields
	internal FixupHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Methods

	// RVA: 0x13FE210 Offset: 0x13FC810 VA: 0x1813FE210
	internal void .ctor() { }

	// RVA: 0x13FE1A0 Offset: 0x13FC7A0 VA: 0x1813FE1A0
	internal void .ctor(int startingSize) { }

	// RVA: 0x13FE000 Offset: 0x13FC600 VA: 0x1813FE000 Slot: 4
	internal virtual void Add(FixupHolder fixup) { }

	// RVA: 0x13FE110 Offset: 0x13FC710 VA: 0x1813FE110
	private void EnlargeArray() { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class LongList // TypeDefIndex: 994
{
	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x13FE730 Offset: 0x13FCD30 VA: 0x1813FE730
	internal void .ctor() { }

	// RVA: 0x13FE790 Offset: 0x13FCD90 VA: 0x1813FE790
	internal void .ctor(int startingSize) { }

	// RVA: 0x13FE4F0 Offset: 0x13FCAF0 VA: 0x1813FE4F0
	internal void Add(long value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	internal int get_Count() { }

	// RVA: 0x13FE720 Offset: 0x13FCD20 VA: 0x1813FE720
	internal void StartEnumeration() { }

	// RVA: 0x13FE650 Offset: 0x13FCC50 VA: 0x1813FE650
	internal bool MoveNext() { }

	// RVA: 0x13FE800 Offset: 0x13FCE00 VA: 0x1813FE800
	internal long get_Current() { }

	// RVA: 0x13FE6A0 Offset: 0x13FCCA0 VA: 0x1813FE6A0
	internal bool RemoveElement(long value) { }

	// RVA: 0x13FE5C0 Offset: 0x13FCBC0 VA: 0x1813FE5C0
	private void EnlargeArray() { }
}

// Namespace: System.Runtime.Serialization
internal class ObjectHolderList // TypeDefIndex: 995
{
	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x13FED10 Offset: 0x13FD310 VA: 0x1813FED10
	internal void .ctor() { }

	// RVA: 0x13FED70 Offset: 0x13FD370 VA: 0x1813FED70
	internal void .ctor(int startingSize) { }

	// RVA: 0x13FEB20 Offset: 0x13FD120 VA: 0x1813FEB20 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x13FEC90 Offset: 0x13FD290 VA: 0x1813FEC90
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x13FEC00 Offset: 0x13FD200 VA: 0x1813FEC00
	private void EnlargeArray() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	internal int get_Version() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	internal int get_Count() { }
}

// Namespace: System.Runtime.Serialization
internal class ObjectHolderListEnumerator // TypeDefIndex: 996
{
	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x13FEA80 Offset: 0x13FD080 VA: 0x1813FEA80
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x13FE9F0 Offset: 0x13FCFF0 VA: 0x1813FE9F0
	internal bool MoveNext() { }

	// RVA: 0x13FEAE0 Offset: 0x13FD0E0 VA: 0x1813FEAE0
	internal ObjectHolder get_Current() { }
}

// Namespace: System.Runtime.Serialization
internal class TypeLoadExceptionHolder // TypeDefIndex: 997
{
	// Fields
	private string m_typeName; // 0x10

	// Properties
	internal string TypeName { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(string typeName) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string get_TypeName() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 998
{
	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x140A460 Offset: 0x1408A60 VA: 0x18140A460
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal IList<object> get_SerializedStates() { }
}

// Namespace: System.Runtime.Serialization
public interface ISafeSerializationData // TypeDefIndex: 999
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CompleteDeserialization(object deserialized);
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1000
{
	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGenerated]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30

	// Properties
	internal bool IsActive { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x140AFA0 Offset: 0x14095A0 VA: 0x18140AFA0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x140B1F0 Offset: 0x14097F0 VA: 0x18140B1F0
	internal bool get_IsActive() { }

	// RVA: 0x140A800 Offset: 0x1408E00 VA: 0x18140A800
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x140A520 Offset: 0x1408B20 VA: 0x18140A520
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x140AE60 Offset: 0x1409460 VA: 0x18140AE60 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x140AB40 Offset: 0x1409140 VA: 0x18140AB40 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x140AA90 Offset: 0x1409090 VA: 0x18140AA90
	private void OnDeserialized(StreamingContext context) { }
}

// Namespace: System.Runtime.Serialization
[Usage(256, Inherited = False)]
[ComVisible(True)]
public sealed class OptionalFieldAttribute : Attribute // TypeDefIndex: 1001
{
	// Fields
	private int versionAdded; // 0x10

	// Properties
	public int VersionAdded { set; }

	// Methods

	// RVA: 0x1408640 Offset: 0x1406C40 VA: 0x181408640
	public void .ctor() { }

	// RVA: 0x1408650 Offset: 0x1406C50 VA: 0x181408650
	public void set_VersionAdded(int value) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnSerializingAttribute : Attribute // TypeDefIndex: 1002
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class OnSerializedAttribute : Attribute // TypeDefIndex: 1003
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnDeserializingAttribute : Attribute // TypeDefIndex: 1004
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnDeserializedAttribute : Attribute // TypeDefIndex: 1005
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 1006
{
	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x140B760 Offset: 0x1409D60 VA: 0x18140B760 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x140B730 Offset: 0x1409D30 VA: 0x18140B730 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x140B5C0 Offset: 0x1409BC0 VA: 0x18140B5C0
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	public override string get_Name() { }

	// RVA: 0x140B6A0 Offset: 0x1409CA0 VA: 0x18140B6A0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x140B790 Offset: 0x1409D90 VA: 0x18140B790 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x140B360 Offset: 0x1409960 VA: 0x18140B360 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x140B390 Offset: 0x1409990 VA: 0x18140B390 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x140B560 Offset: 0x1409B60 VA: 0x18140B560 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x140B700 Offset: 0x1409D00 VA: 0x18140B700 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x86F3B0 Offset: 0x86D9B0 VA: 0x18086F3B0 Slot: 26
	public override object GetValue(object obj) { }

	// RVA: 0x140B3C0 Offset: 0x14099C0 VA: 0x18140B3C0
	internal object InternalGetValue(object obj) { }

	// RVA: 0x140B590 Offset: 0x1409B90 VA: 0x18140B590 Slot: 28
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x140B470 Offset: 0x1409A70 VA: 0x18140B470
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0x140B6D0 Offset: 0x1409CD0 VA: 0x18140B6D0 Slot: 25
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x140B670 Offset: 0x1409C70 VA: 0x18140B670 Slot: 16
	public override FieldAttributes get_Attributes() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public sealed class SerializationInfo // TypeDefIndex: 1007
{
	// Fields
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x140E080 Offset: 0x140C680 VA: 0x18140E080
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliant(False)]
	// RVA: 0x140E0A0 Offset: 0x140C6A0 VA: 0x18140E0A0
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_FullTypeName() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public string get_AssemblyName() { }

	// RVA: 0x140DCF0 Offset: 0x140C2F0 VA: 0x18140DCF0
	public void SetType(Type type) { }

	// RVA: 0x140CAE0 Offset: 0x140B0E0 VA: 0x18140CAE0
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x140CB60 Offset: 0x140B160 VA: 0x18140CB60
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x140DB50 Offset: 0x140C150 VA: 0x18140DB50
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_MemberCount() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public Type get_ObjectType() { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x140E320 Offset: 0x140C920 VA: 0x18140E320
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x140D1B0 Offset: 0x140B7B0 VA: 0x18140D1B0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x140CB70 Offset: 0x140B170 VA: 0x18140CB70
	private void ExpandArrays() { }

	// RVA: 0x140BEB0 Offset: 0x140A4B0 VA: 0x18140BEB0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x140C0A0 Offset: 0x140A6A0 VA: 0x18140C0A0
	public void AddValue(string name, object value) { }

	// RVA: 0x140C9B0 Offset: 0x140AFB0 VA: 0x18140C9B0
	public void AddValue(string name, bool value) { }

	// RVA: 0x140C3A0 Offset: 0x140A9A0 VA: 0x18140C3A0
	public void AddValue(string name, byte value) { }

	// RVA: 0x140C4D0 Offset: 0x140AAD0 VA: 0x18140C4D0
	public void AddValue(string name, short value) { }

	// RVA: 0x140C750 Offset: 0x140AD50 VA: 0x18140C750
	public void AddValue(string name, int value) { }

	// RVA: 0x140BF70 Offset: 0x140A570 VA: 0x18140BF70
	public void AddValue(string name, long value) { }

	[CLSCompliant(False)]
	// RVA: 0x140C880 Offset: 0x140AE80 VA: 0x18140C880
	public void AddValue(string name, ulong value) { }

	// RVA: 0x140C270 Offset: 0x140A870 VA: 0x18140C270
	public void AddValue(string name, float value) { }

	// RVA: 0x140C600 Offset: 0x140AC00 VA: 0x18140C600
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x140BBB0 Offset: 0x140A1B0 VA: 0x18140BBB0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x140DEB0 Offset: 0x140C4B0 VA: 0x18140DEB0
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x140CC80 Offset: 0x140B280 VA: 0x18140CC80
	private int FindElement(string name) { }

	// RVA: 0x140CFE0 Offset: 0x140B5E0 VA: 0x18140CFE0
	private object GetElement(string name, out Type foundType) { }

	[ComVisible(True)]
	// RVA: 0x140CE90 Offset: 0x140B490 VA: 0x18140CE90
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x140D970 Offset: 0x140BF70 VA: 0x18140D970
	public object GetValue(string name, Type type) { }

	[ComVisible(True)]
	// RVA: 0x140D790 Offset: 0x140BD90 VA: 0x18140D790
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x140CD40 Offset: 0x140B340 VA: 0x18140CD40
	public bool GetBoolean(string name) { }

	// RVA: 0x140D250 Offset: 0x140B850 VA: 0x18140D250
	public int GetInt32(string name) { }

	// RVA: 0x140D3A0 Offset: 0x140B9A0 VA: 0x18140D3A0
	public long GetInt64(string name) { }

	// RVA: 0x140D4F0 Offset: 0x140BAF0 VA: 0x18140D4F0
	public float GetSingle(string name) { }

	// RVA: 0x140D640 Offset: 0x140BC40 VA: 0x18140D640
	public string GetString(string name) { }
}

// Namespace: System.Runtime.Serialization
[IsReadOnly]
[ComVisible(True)]
[Serializable]
public struct StreamingContext // TypeDefIndex: 1008
{
	// Fields
	internal readonly object m_additionalContext; // 0x0
	internal readonly StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x140E3E0 Offset: 0x140C9E0 VA: 0x18140E3E0
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x140E400 Offset: 0x140CA00 VA: 0x18140E400
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public object get_Context() { }

	// RVA: 0x140E330 Offset: 0x140C930 VA: 0x18140E330 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public StreamingContextStates get_State() { }
}

// Namespace: System.Runtime.Serialization
[Flags]
[ComVisible(True)]
[Serializable]
public enum StreamingContextStates // TypeDefIndex: 1009
{
	// Fields
	public int value__; // 0x0
	public const StreamingContextStates CrossProcess = 1;
	public const StreamingContextStates CrossMachine = 2;
	public const StreamingContextStates File = 4;
	public const StreamingContextStates Persistence = 8;
	public const StreamingContextStates Remoting = 16;
	public const StreamingContextStates Other = 32;
	public const StreamingContextStates Clone = 64;
	public const StreamingContextStates CrossAppDomain = 128;
	public const StreamingContextStates All = 255;
}

// Namespace: System.Runtime.Serialization
[Usage(28, Inherited = False, AllowMultiple = False)]
public sealed class DataContractAttribute : Attribute // TypeDefIndex: 14295
{
	// Fields
	private bool isReference; // 0x10

	// Properties
	public bool IsReference { get; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_IsReference() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 14296
{
	// Fields
	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	// Properties
	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Order() { }

	// RVA: 0x39A900 Offset: 0x398F00 VA: 0x18039A900
	public bool get_IsRequired() { }

	// RVA: 0x197EBE0 Offset: 0x197D1E0 VA: 0x18197EBE0
	public bool get_EmitDefaultValue() { }
}

// Namespace: System.Runtime.Serialization
[Usage(256, Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 14297
{
	// Fields
	private string value; // 0x10

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Value() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 14298
{}

