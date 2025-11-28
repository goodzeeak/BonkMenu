// Namespace: System.Reflection
[Serializable]
public sealed class AmbiguousMatchException : SystemException // TypeDefIndex: 1209
{
	// Methods

	// RVA: 0x14134D0 Offset: 0x1411AD0 VA: 0x1814134D0
	public void .ctor() { }

	// RVA: 0x14134B0 Offset: 0x1411AB0 VA: 0x1814134B0
	public void .ctor(string message) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 1210
{
	// Fields
	[CompilerGenerated]
	private readonly string <Company>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string company) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 1211
{
	// Fields
	[CompilerGenerated]
	private readonly string <Configuration>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string configuration) { }
}

// Namespace: System.Reflection
public enum AssemblyContentType // TypeDefIndex: 1212
{
	// Fields
	public int value__; // 0x0
	public const AssemblyContentType Default = 0;
	public const AssemblyContentType WindowsRuntime = 1;
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyCopyrightAttribute : Attribute // TypeDefIndex: 1213
{
	// Fields
	[CompilerGenerated]
	private readonly string <Copyright>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string copyright) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 1214
{
	// Fields
	[CompilerGenerated]
	private readonly string <DefaultAlias>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string defaultAlias) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 1215
{
	// Fields
	[CompilerGenerated]
	private readonly bool <DelaySign>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool delaySign) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 1216
{
	// Fields
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string description) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 1217
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1413520 Offset: 0x1411B20 VA: 0x181413520
	public void .ctor(string version) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 1218
{
	// Fields
	[CompilerGenerated]
	private readonly string <InformationalVersion>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string informationalVersion) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 1219
{
	// Fields
	[CompilerGenerated]
	private readonly string <KeyFile>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string keyFile) { }
}

// Namespace: System.Reflection
[Usage(1, AllowMultiple = True, Inherited = False)]
public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 1220
{
	// Fields
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string key, string value) { }
}

// Namespace: System.Reflection
[Flags]
public enum AssemblyNameFlags // TypeDefIndex: 1221
{
	// Fields
	public int value__; // 0x0
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 1222
{
	// Fields
	[CompilerGenerated]
	private readonly string <Product>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string product) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 1223
{
	// Fields
	[CompilerGenerated]
	private readonly string <Title>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string title) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 1224
{
	// Fields
	[CompilerGenerated]
	private readonly string <Trademark>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string trademark) { }
}

// Namespace: System.Reflection
public abstract class Binder // TypeDefIndex: 1225
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ChangeType(object value, Type type, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ReorderArgumentArray(ref object[] args, object state);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers);
}

// Namespace: System.Reflection
[Flags]
public enum BindingFlags // TypeDefIndex: 1226
{
	// Fields
	public int value__; // 0x0
	public const BindingFlags Default = 0;
	public const BindingFlags IgnoreCase = 1;
	public const BindingFlags DeclaredOnly = 2;
	public const BindingFlags Instance = 4;
	public const BindingFlags Static = 8;
	public const BindingFlags Public = 16;
	public const BindingFlags NonPublic = 32;
	public const BindingFlags FlattenHierarchy = 64;
	public const BindingFlags InvokeMethod = 256;
	public const BindingFlags CreateInstance = 512;
	public const BindingFlags GetField = 1024;
	public const BindingFlags SetField = 2048;
	public const BindingFlags GetProperty = 4096;
	public const BindingFlags SetProperty = 8192;
	public const BindingFlags PutDispProperty = 16384;
	public const BindingFlags PutRefDispProperty = 32768;
	public const BindingFlags ExactBinding = 65536;
	public const BindingFlags SuppressChangeType = 131072;
	public const BindingFlags OptionalParamBinding = 262144;
	public const BindingFlags IgnoreReturn = 16777216;
	public const BindingFlags DoNotWrapExceptions = 33554432;
}

// Namespace: System.Reflection
[Flags]
public enum CallingConventions // TypeDefIndex: 1227
{
	// Fields
	public int value__; // 0x0
	public const CallingConventions Standard = 1;
	public const CallingConventions VarArgs = 2;
	public const CallingConventions Any = 3;
	public const CallingConventions HasThis = 32;
	public const CallingConventions ExplicitThis = 64;
}

// Namespace: System.Reflection
[Serializable]
public abstract class ConstructorInfo : MethodBase // TypeDefIndex: 1228
{
	// Fields
	public static readonly string ConstructorName; // 0x0
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x14151C0 Offset: 0x14137C0 VA: 0x1814151C0
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x14151B0 Offset: 0x14137B0 VA: 0x1814151B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x95BB90 Offset: 0x95A190 VA: 0x18095BB90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x14152E0 Offset: 0x14138E0 VA: 0x1814152E0
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x1415200 Offset: 0x1413800 VA: 0x181415200
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Serializable]
public class CustomAttributeFormatException : FormatException // TypeDefIndex: 1229
{
	// Methods

	// RVA: 0x14154E0 Offset: 0x1413AE0 VA: 0x1814154E0
	public void .ctor() { }

	// RVA: 0x1415530 Offset: 0x1413B30 VA: 0x181415530
	public void .ctor(string message) { }

	// RVA: 0x1415560 Offset: 0x1413B60 VA: 0x181415560
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x14154C0 Offset: 0x1413AC0 VA: 0x1814154C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Usage(1036)]
public sealed class DefaultMemberAttribute : Attribute // TypeDefIndex: 1230
{
	// Fields
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string memberName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_MemberName() { }
}

// Namespace: System.Reflection
[Flags]
public enum EventAttributes // TypeDefIndex: 1231
{
	// Fields
	public int value__; // 0x0
	public const EventAttributes None = 0;
	public const EventAttributes SpecialName = 512;
	public const EventAttributes RTSpecialName = 1024;
	public const EventAttributes ReservedMask = 1024;
}

// Namespace: System.Reflection
[Serializable]
public abstract class EventInfo : MemberInfo // TypeDefIndex: 1233
{
	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type EventHandlerType { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x14159B0 Offset: 0x1413FB0 VA: 0x1814159B0 Slot: 16
	public MethodInfo GetAddMethod() { }

	// RVA: 0x13D7110 Offset: 0x13D5710 VA: 0x1813D7110 Slot: 17
	public MethodInfo GetRemoveMethod() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: 0x1415A80 Offset: 0x1414080 VA: 0x181415A80 Slot: 21
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x14151B0 Offset: 0x14137B0 VA: 0x1814151B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x95BB90 Offset: 0x95A190 VA: 0x18095BB90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x1415BB0 Offset: 0x14141B0 VA: 0x181415BB0
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x1415BA0 Offset: 0x14141A0 VA: 0x181415BA0
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x14159D0 Offset: 0x1413FD0 VA: 0x1814159D0
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }
}

// Namespace: System.Reflection
[Flags]
public enum ExceptionHandlingClauseOptions // TypeDefIndex: 1234
{
	// Fields
	public int value__; // 0x0
	public const ExceptionHandlingClauseOptions Clause = 0;
	public const ExceptionHandlingClauseOptions Filter = 1;
	public const ExceptionHandlingClauseOptions Finally = 2;
	public const ExceptionHandlingClauseOptions Fault = 4;
}

// Namespace: System.Reflection
[Flags]
public enum FieldAttributes // TypeDefIndex: 1235
{
	// Fields
	public int value__; // 0x0
	public const FieldAttributes FieldAccessMask = 7;
	public const FieldAttributes PrivateScope = 0;
	public const FieldAttributes Private = 1;
	public const FieldAttributes FamANDAssem = 2;
	public const FieldAttributes Assembly = 3;
	public const FieldAttributes Family = 4;
	public const FieldAttributes FamORAssem = 5;
	public const FieldAttributes Public = 6;
	public const FieldAttributes Static = 16;
	public const FieldAttributes InitOnly = 32;
	public const FieldAttributes Literal = 64;
	public const FieldAttributes NotSerialized = 128;
	public const FieldAttributes SpecialName = 512;
	public const FieldAttributes PinvokeImpl = 8192;
	public const FieldAttributes RTSpecialName = 1024;
	public const FieldAttributes HasFieldMarshal = 4096;
	public const FieldAttributes HasDefault = 32768;
	public const FieldAttributes HasFieldRVA = 256;
	public const FieldAttributes ReservedMask = 38144;
}

// Namespace: System.Reflection
[Serializable]
public abstract class FieldInfo : MemberInfo // TypeDefIndex: 1236
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract FieldAttributes Attributes { get; }
	public abstract Type FieldType { get; }
	public bool IsInitOnly { get; }
	public bool IsLiteral { get; }
	public bool IsNotSerialized { get; }
	public bool IsSpecialName { get; }
	public bool IsStatic { get; }
	public bool IsPrivate { get; }
	public bool IsPublic { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Type get_FieldType();

	// RVA: 0x1417380 Offset: 0x1415980 VA: 0x181417380 Slot: 18
	public bool get_IsInitOnly() { }

	// RVA: 0x14173B0 Offset: 0x14159B0 VA: 0x1814173B0 Slot: 19
	public bool get_IsLiteral() { }

	// RVA: 0x14173E0 Offset: 0x14159E0 VA: 0x1814173E0 Slot: 20
	public bool get_IsNotSerialized() { }

	// RVA: 0x1417470 Offset: 0x1415A70 VA: 0x181417470 Slot: 21
	public bool get_IsSpecialName() { }

	// RVA: 0x14174A0 Offset: 0x1415AA0 VA: 0x1814174A0 Slot: 22
	public bool get_IsStatic() { }

	// RVA: 0x1417410 Offset: 0x1415A10 VA: 0x181417410 Slot: 23
	public bool get_IsPrivate() { }

	// RVA: 0x1417440 Offset: 0x1415A40 VA: 0x181417440 Slot: 24
	public bool get_IsPublic() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x14151B0 Offset: 0x14137B0 VA: 0x1814151B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x95BB90 Offset: 0x95A190 VA: 0x18095BB90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x1415BB0 Offset: 0x14141B0 VA: 0x181415BB0
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract object GetValue(object obj);

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1417300 Offset: 0x1415900 VA: 0x181417300 Slot: 27
	public void SetValue(object obj, object value) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[CLSCompliant(False)]
	// RVA: 0x14172B0 Offset: 0x14158B0 VA: 0x1814172B0 Slot: 29
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x1417260 Offset: 0x1415860 VA: 0x181417260 Slot: 30
	public virtual object GetRawConstantValue() { }

	// RVA: 0x14174D0 Offset: 0x1415AD0 VA: 0x1814174D0
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x14167D0 Offset: 0x1414DD0 VA: 0x1814167D0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisible(False)]
	// RVA: 0x1416840 Offset: 0x1414E40 VA: 0x181416840
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x14168F0 Offset: 0x1414EF0 VA: 0x1814168F0 Slot: 31
	internal virtual int GetFieldOffset() { }

	// RVA: 0x13D4F00 Offset: 0x13D3500 VA: 0x1813D4F00
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x1416FD0 Offset: 0x14155D0 VA: 0x181416FD0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x1416940 Offset: 0x1414F40 VA: 0x181416940
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }
}

// Namespace: System.Reflection
[Flags]
public enum GenericParameterAttributes // TypeDefIndex: 1237
{
	// Fields
	public int value__; // 0x0
	public const GenericParameterAttributes None = 0;
	public const GenericParameterAttributes VarianceMask = 3;
	public const GenericParameterAttributes Covariant = 1;
	public const GenericParameterAttributes Contravariant = 2;
	public const GenericParameterAttributes SpecialConstraintMask = 28;
	public const GenericParameterAttributes ReferenceTypeConstraint = 4;
	public const GenericParameterAttributes NotNullableValueTypeConstraint = 8;
	public const GenericParameterAttributes DefaultConstructorConstraint = 16;
}

// Namespace: System.Reflection
public interface ICustomAttributeProvider // TypeDefIndex: 1238
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsDefined(Type attributeType, bool inherit);
}

// Namespace: System.Reflection
public interface IReflectableType // TypeDefIndex: 1239
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeInfo GetTypeInfo();
}

// Namespace: System.Reflection
[Extension]
public static class IntrospectionExtensions // TypeDefIndex: 1240
{
	// Methods

	[Extension]
	// RVA: 0x14180F0 Offset: 0x14166F0 VA: 0x1814180F0
	public static TypeInfo GetTypeInfo(Type type) { }
}

// Namespace: System.Reflection
[Serializable]
public class InvalidFilterCriteriaException : ApplicationException // TypeDefIndex: 1241
{
	// Methods

	// RVA: 0x1440790 Offset: 0x143ED90 VA: 0x181440790
	public void .ctor() { }

	// RVA: 0x1440720 Offset: 0x143ED20 VA: 0x181440720
	public void .ctor(string message) { }

	// RVA: 0x1440770 Offset: 0x143ED70 VA: 0x181440770
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1440750 Offset: 0x143ED50 VA: 0x181440750
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
public class ManifestResourceInfo // TypeDefIndex: 1242
{
	// Fields
	[CompilerGenerated]
	private readonly Assembly <ReferencedAssembly>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ResourceLocation <ResourceLocation>k__BackingField; // 0x20

	// Properties
	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }

	// Methods

	// RVA: 0x1440870 Offset: 0x143EE70 VA: 0x181440870
	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public virtual Assembly get_ReferencedAssembly() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 5
	public virtual string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 6
	public virtual ResourceLocation get_ResourceLocation() { }
}

// Namespace: System.Reflection
public sealed class MemberFilter : MulticastDelegate // TypeDefIndex: 1243
{
	// Methods

	// RVA: 0x14408D0 Offset: 0x143EED0 VA: 0x1814408D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D4320 Offset: 0x5D2920 VA: 0x1805D4320 Slot: 13
	public virtual bool Invoke(MemberInfo m, object filterCriteria) { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class MemberInfo : ICustomAttributeProvider // TypeDefIndex: 1244
{
	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual Module Module { get; }
	public virtual int MetadataToken { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_ReflectedType();

	// RVA: 0x1441E30 Offset: 0x1440430 VA: 0x181441E30 Slot: 11
	public virtual Module get_Module() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: 0x1441DF0 Offset: 0x14403F0 VA: 0x181441DF0 Slot: 15
	public virtual int get_MetadataToken() { }

	// RVA: 0x142DC10 Offset: 0x142C210 VA: 0x18142DC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1441EF0 Offset: 0x14404F0 VA: 0x181441EF0
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x1442330 Offset: 0x1440930 VA: 0x181442330
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }
}

// Namespace: System.Reflection
[Flags]
public enum MemberTypes // TypeDefIndex: 1245
{
	// Fields
	public int value__; // 0x0
	public const MemberTypes Constructor = 1;
	public const MemberTypes Event = 2;
	public const MemberTypes Field = 4;
	public const MemberTypes Method = 8;
	public const MemberTypes Property = 16;
	public const MemberTypes TypeInfo = 32;
	public const MemberTypes Custom = 64;
	public const MemberTypes NestedType = 128;
	public const MemberTypes All = 191;
}

// Namespace: System.Reflection
[Flags]
public enum MethodAttributes // TypeDefIndex: 1246
{
	// Fields
	public int value__; // 0x0
	public const MethodAttributes MemberAccessMask = 7;
	public const MethodAttributes PrivateScope = 0;
	public const MethodAttributes Private = 1;
	public const MethodAttributes FamANDAssem = 2;
	public const MethodAttributes Assembly = 3;
	public const MethodAttributes Family = 4;
	public const MethodAttributes FamORAssem = 5;
	public const MethodAttributes Public = 6;
	public const MethodAttributes Static = 16;
	public const MethodAttributes Final = 32;
	public const MethodAttributes Virtual = 64;
	public const MethodAttributes HideBySig = 128;
	public const MethodAttributes CheckAccessOnOverride = 512;
	public const MethodAttributes VtableLayoutMask = 256;
	public const MethodAttributes ReuseSlot = 0;
	public const MethodAttributes NewSlot = 256;
	public const MethodAttributes Abstract = 1024;
	public const MethodAttributes SpecialName = 2048;
	public const MethodAttributes PinvokeImpl = 8192;
	public const MethodAttributes UnmanagedExport = 8;
	public const MethodAttributes RTSpecialName = 4096;
	public const MethodAttributes HasSecurity = 16384;
	public const MethodAttributes RequireSecObject = 32768;
	public const MethodAttributes ReservedMask = 53248;
}

// Namespace: System.Reflection
[Serializable]
public abstract class MethodBase : MemberInfo // TypeDefIndex: 1247
{
	// Properties
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public bool IsAbstract { get; }
	public bool IsConstructor { get; }
	public bool IsFinal { get; }
	public bool IsSpecialName { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsPublic { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public virtual bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 19
	public virtual CallingConventions get_CallingConvention() { }

	// RVA: 0x1442AD0 Offset: 0x14410D0 VA: 0x181442AD0 Slot: 20
	public bool get_IsAbstract() { }

	// RVA: 0x1442B00 Offset: 0x1441100 VA: 0x181442B00 Slot: 21
	public bool get_IsConstructor() { }

	// RVA: 0x1442BA0 Offset: 0x14411A0 VA: 0x181442BA0 Slot: 22
	public bool get_IsFinal() { }

	// RVA: 0x1442C30 Offset: 0x1441230 VA: 0x181442C30 Slot: 23
	public bool get_IsSpecialName() { }

	// RVA: 0x1442C60 Offset: 0x1441260 VA: 0x181442C60 Slot: 24
	public bool get_IsStatic() { }

	// RVA: 0x1442C90 Offset: 0x1441290 VA: 0x181442C90 Slot: 25
	public bool get_IsVirtual() { }

	// RVA: 0x1442BD0 Offset: 0x14411D0 VA: 0x181442BD0 Slot: 26
	public bool get_IsPublic() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 27
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 28
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x1442690 Offset: 0x1440C90 VA: 0x181442690 Slot: 29
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 30
	public virtual bool get_ContainsGenericParameters() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1442A90 Offset: 0x1441090 VA: 0x181442A90 Slot: 31
	public object Invoke(object obj, object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 32
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: 0x1442C00 Offset: 0x1441200 VA: 0x181442C00 Slot: 34
	public virtual bool get_IsSecurityCritical() { }

	// RVA: 0x142DC10 Offset: 0x142C210 VA: 0x18142DC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1442CC0 Offset: 0x14412C0 VA: 0x181442CC0
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x1442EA0 Offset: 0x14414A0 VA: 0x181442EA0
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x1442A70 Offset: 0x1441070 VA: 0x181442A70 Slot: 35
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x1442A40 Offset: 0x1441040 VA: 0x181442A40 Slot: 36
	internal virtual int GetParametersCount() { }

	// RVA: 0x1442550 Offset: 0x1440B50 VA: 0x181442550 Slot: 37
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x1442920 Offset: 0x1440F20 VA: 0x181442920 Slot: 38
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x1442A70 Offset: 0x1441070 VA: 0x181442A70 Slot: 39
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: 0x14426E0 Offset: 0x1440CE0 VA: 0x1814426E0
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x1442350 Offset: 0x1440950 VA: 0x181442350
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }
}

// Namespace: System.Reflection
public enum MethodImplAttributes // TypeDefIndex: 1248
{
	// Fields
	public int value__; // 0x0
	public const MethodImplAttributes CodeTypeMask = 3;
	public const MethodImplAttributes IL = 0;
	public const MethodImplAttributes Native = 1;
	public const MethodImplAttributes OPTIL = 2;
	public const MethodImplAttributes Runtime = 3;
	public const MethodImplAttributes ManagedMask = 4;
	public const MethodImplAttributes Unmanaged = 4;
	public const MethodImplAttributes Managed = 0;
	public const MethodImplAttributes ForwardRef = 16;
	public const MethodImplAttributes PreserveSig = 128;
	public const MethodImplAttributes InternalCall = 4096;
	public const MethodImplAttributes Synchronized = 32;
	public const MethodImplAttributes NoInlining = 8;
	public const MethodImplAttributes AggressiveInlining = 256;
	public const MethodImplAttributes NoOptimization = 64;
	public const MethodImplAttributes MaxMethodImplVal = 65535;
	public const MethodImplAttributes SecurityMitigations = 1024;
}

// Namespace: System.Reflection
[Serializable]
public abstract class MethodInfo : MethodBase // TypeDefIndex: 1249
{
	// Properties
	public override MemberTypes MemberType { get; }
	public virtual ParameterInfo ReturnParameter { get; }
	public virtual Type ReturnType { get; }
	internal virtual int GenericParameterCount { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1443380 Offset: 0x1441980 VA: 0x181443380 Slot: 40
	public virtual ParameterInfo get_ReturnParameter() { }

	// RVA: 0x14433B0 Offset: 0x14419B0 VA: 0x1814433B0 Slot: 41
	public virtual Type get_ReturnType() { }

	// RVA: 0x1443260 Offset: 0x1441860 VA: 0x181443260 Slot: 29
	public override Type[] GetGenericArguments() { }

	// RVA: 0x14432B0 Offset: 0x14418B0 VA: 0x1814432B0 Slot: 42
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x1443300 Offset: 0x1441900 VA: 0x181443300 Slot: 43
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: -1 Offset: -1 Slot: 44
	public abstract MethodInfo GetBaseDefinition();

	// RVA: 0x14431C0 Offset: 0x14417C0 VA: 0x1814431C0 Slot: 45
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x1443210 Offset: 0x1441810 VA: 0x181443210 Slot: 46
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x142DC10 Offset: 0x142C210 VA: 0x18142DC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x1415BB0 Offset: 0x14141B0 VA: 0x181415BB0
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x1443350 Offset: 0x1441950 VA: 0x181443350 Slot: 47
	internal virtual int get_GenericParameterCount() { }
}

// Namespace: System.Reflection
public sealed class Missing : ISerializable // TypeDefIndex: 1250
{
	// Fields
	public static readonly Missing Value; // 0x0

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x14433F0 Offset: 0x14419F0 VA: 0x1814433F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1443430 Offset: 0x1441A30 VA: 0x181443430
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module // TypeDefIndex: 1251
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	private const BindingFlags DefaultLookup = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual Guid ModuleVersionId { get; }
	public virtual string ScopeName { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x14439D0 Offset: 0x1441FD0 VA: 0x1814439D0 Slot: 8
	public virtual Assembly get_Assembly() { }

	// RVA: 0x1443A00 Offset: 0x1442000 VA: 0x181443A00 Slot: 9
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x1443A30 Offset: 0x1442030 VA: 0x181443A30 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x1443890 Offset: 0x1441E90 VA: 0x181443890 Slot: 11
	public virtual bool IsResource() { }

	// RVA: 0x1443860 Offset: 0x1441E60 VA: 0x181443860 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x14437C0 Offset: 0x1441DC0 VA: 0x1814437C0 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1443790 Offset: 0x1441D90 VA: 0x181443790 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1443830 Offset: 0x1441E30 VA: 0x181443830 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x142DC10 Offset: 0x142C210 VA: 0x18142DC10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x14438C0 Offset: 0x1441EC0 VA: 0x1814438C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1443640 Offset: 0x1441C40 VA: 0x181443640
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	// RVA: 0x14434A0 Offset: 0x1441AA0 VA: 0x1814434A0
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	// RVA: 0x14437F0 Offset: 0x1441DF0 VA: 0x1814437F0 Slot: 16
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x14438E0 Offset: 0x1441EE0 VA: 0x1814438E0
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Flags]
public enum ParameterAttributes // TypeDefIndex: 1252
{
	// Fields
	public int value__; // 0x0
	public const ParameterAttributes None = 0;
	public const ParameterAttributes In = 1;
	public const ParameterAttributes Out = 2;
	public const ParameterAttributes Lcid = 4;
	public const ParameterAttributes Retval = 8;
	public const ParameterAttributes Optional = 16;
	public const ParameterAttributes HasDefault = 4096;
	public const ParameterAttributes HasFieldMarshal = 8192;
	public const ParameterAttributes Reserved3 = 16384;
	public const ParameterAttributes Reserved4 = 32768;
	public const ParameterAttributes ReservedMask = 61440;
}

// Namespace: System.Reflection
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 1253
{
	// Fields
	protected ParameterAttributes AttrsImpl; // 0x10
	protected Type ClassImpl; // 0x18
	protected object DefaultValueImpl; // 0x20
	protected MemberInfo MemberImpl; // 0x28
	protected string NameImpl; // 0x30
	protected int PositionImpl; // 0x38
	private const int MetadataToken_ParamDef = 134217728;

	// Properties
	public virtual ParameterAttributes Attributes { get; }
	public virtual MemberInfo Member { get; }
	public virtual string Name { get; }
	public virtual Type ParameterType { get; }
	public virtual int Position { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 9
	public virtual MemberInfo get_Member() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 10
	public virtual string get_Name() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 11
	public virtual Type get_ParameterType() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x1444280 Offset: 0x1442880 VA: 0x181444280
	public bool get_IsIn() { }

	// RVA: 0x14442A0 Offset: 0x14428A0 VA: 0x1814442A0
	public bool get_IsOptional() { }

	// RVA: 0x14442D0 Offset: 0x14428D0 VA: 0x1814442D0
	public bool get_IsOut() { }

	// RVA: 0x1444250 Offset: 0x1442850 VA: 0x181444250 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x1444140 Offset: 0x1442740 VA: 0x181444140 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1443C70 Offset: 0x1442270 VA: 0x181443C70 Slot: 15
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1443CA0 Offset: 0x14422A0 VA: 0x181443CA0 Slot: 16
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1443D50 Offset: 0x1442350 VA: 0x181443D50 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x14441C0 Offset: 0x14427C0 VA: 0x1814441C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[DefaultMember("Item")]
[IsReadOnly]
public struct ParameterModifier // TypeDefIndex: 1254
{
	// Fields
	private readonly bool[] _byRef; // 0x0
}

// Namespace: System.Reflection
[CLSCompliant(False)]
public sealed class Pointer : ISerializable // TypeDefIndex: 1255
{
	// Fields
	private readonly void* _ptr; // 0x10
	private readonly Type _ptrType; // 0x18

	// Methods

	// RVA: 0x1444510 Offset: 0x1442B10 VA: 0x181444510
	private void .ctor(void* ptr, Type ptrType) { }

	// RVA: 0x1444300 Offset: 0x1442900 VA: 0x181444300
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x14444D0 Offset: 0x1442AD0 VA: 0x1814444D0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
public enum ProcessorArchitecture // TypeDefIndex: 1256
{
	// Fields
	public int value__; // 0x0
	public const ProcessorArchitecture None = 0;
	public const ProcessorArchitecture MSIL = 1;
	public const ProcessorArchitecture X86 = 2;
	public const ProcessorArchitecture IA64 = 3;
	public const ProcessorArchitecture Amd64 = 4;
	public const ProcessorArchitecture Arm = 5;
}

// Namespace: System.Reflection
[Flags]
public enum PropertyAttributes // TypeDefIndex: 1257
{
	// Fields
	public int value__; // 0x0
	public const PropertyAttributes None = 0;
	public const PropertyAttributes SpecialName = 512;
	public const PropertyAttributes RTSpecialName = 1024;
	public const PropertyAttributes HasDefault = 4096;
	public const PropertyAttributes Reserved2 = 8192;
	public const PropertyAttributes Reserved3 = 16384;
	public const PropertyAttributes Reserved4 = 32768;
	public const PropertyAttributes ReservedMask = 62464;
}

// Namespace: System.Reflection
[Serializable]
public abstract class PropertyInfo : MemberInfo // TypeDefIndex: 1258
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }
	public abstract PropertyAttributes Attributes { get; }
	public bool IsSpecialName { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public virtual MethodInfo GetMethod { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x44EB70 Offset: 0x44D170 VA: 0x18044EB70 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract PropertyAttributes get_Attributes();

	// RVA: 0x1444A50 Offset: 0x1443050 VA: 0x181444A50 Slot: 19
	public bool get_IsSpecialName() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool get_CanWrite();

	// RVA: 0x1444A30 Offset: 0x1443030 VA: 0x181444A30 Slot: 22
	public virtual MethodInfo get_GetMethod() { }

	// RVA: 0x1444920 Offset: 0x1442F20 VA: 0x181444920 Slot: 23
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: 0x1444940 Offset: 0x1442F40 VA: 0x181444940 Slot: 25
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1444960 Offset: 0x1442F60 VA: 0x181444960
	public object GetValue(object obj) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1444980 Offset: 0x1442F80 VA: 0x181444980 Slot: 27
	public virtual object GetValue(object obj, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x14449C0 Offset: 0x1442FC0 VA: 0x1814449C0
	public void SetValue(object obj, object value) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x14449F0 Offset: 0x1442FF0 VA: 0x1814449F0 Slot: 29
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x142DC10 Offset: 0x142C210 VA: 0x18142DC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x1415BB0 Offset: 0x14141B0 VA: 0x181415BB0
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 1259
{
	// Fields
	[CompilerGenerated]
	private readonly Type[] <Types>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly Exception[] <LoaderExceptions>k__BackingField; // 0x98

	// Properties
	public Type[] Types { get; }
	public Exception[] LoaderExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1444E20 Offset: 0x1443420 VA: 0x181444E20
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x1444CF0 Offset: 0x14432F0 VA: 0x181444CF0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1444BD0 Offset: 0x14431D0 VA: 0x181444BD0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public Type[] get_Types() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public Exception[] get_LoaderExceptions() { }

	// RVA: 0x1444E90 Offset: 0x1443490 VA: 0x181444E90 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1444CE0 Offset: 0x14432E0 VA: 0x181444CE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1444A80 Offset: 0x1443080 VA: 0x181444A80
	private string CreateString(bool isMessage) { }
}

// Namespace: System.Reflection
[Flags]
public enum ResourceLocation // TypeDefIndex: 1260
{
	// Fields
	public int value__; // 0x0
	public const ResourceLocation ContainedInAnotherAssembly = 2;
	public const ResourceLocation ContainedInManifestFile = 4;
	public const ResourceLocation Embedded = 1;
}

// Namespace: System.Reflection
internal sealed class SignatureArrayType : SignatureHasElementType // TypeDefIndex: 1261
{
	// Fields
	private readonly int _rank; // 0x20
	private readonly bool _isMultiDim; // 0x24

	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x144CDD0 Offset: 0x144B3D0 VA: 0x18144CDD0
	internal void .ctor(SignatureType elementType, int rank, bool isMultiDim) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x144CE40 Offset: 0x144B440 VA: 0x18144CE40 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x144CE50 Offset: 0x144B450 VA: 0x18144CE50 Slot: 137
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal sealed class SignatureByRefType : SignatureHasElementType // TypeDefIndex: 1262
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x144CF50 Offset: 0x144B550 VA: 0x18144CF50
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x144CF00 Offset: 0x144B500 VA: 0x18144CF00 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x144CFA0 Offset: 0x144B5A0 VA: 0x18144CFA0 Slot: 137
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal sealed class SignatureConstructedGenericType : SignatureType // TypeDefIndex: 1263
{
	// Fields
	private readonly Type _genericTypeDefinition; // 0x18
	private readonly Type[] _genericTypeArguments; // 0x20

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public sealed override bool IsByRefLike { get; }
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }

	// Methods

	// RVA: 0x144D190 Offset: 0x144B790 VA: 0x18144D190
	internal void .ctor(Type genericTypeDefinition, Type[] typeArguments) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 46
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x144D540 Offset: 0x144BB40 VA: 0x18144D540 Slot: 44
	public sealed override bool get_IsByRefLike() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x144D3E0 Offset: 0x144B9E0 VA: 0x18144D3E0 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 136
	internal sealed override SignatureType get_ElementType() { }

	// RVA: 0x144CFD0 Offset: 0x144B5D0 VA: 0x18144CFD0 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 49
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x144D020 Offset: 0x144B620 VA: 0x18144D020 Slot: 51
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x144D4C0 Offset: 0x144BAC0 VA: 0x18144D4C0 Slot: 50
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x144D470 Offset: 0x144BA70 VA: 0x18144D470 Slot: 52
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x144D570 Offset: 0x144BB70 VA: 0x18144D570 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x144D5A0 Offset: 0x144BBA0 VA: 0x18144D5A0 Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x144D040 Offset: 0x144B640 VA: 0x18144D040 Slot: 3
	public sealed override string ToString() { }
}

// Namespace: System.Reflection
internal abstract class SignatureHasElementType : SignatureType // TypeDefIndex: 1264
{
	// Fields
	private readonly SignatureType _elementType; // 0x18

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public sealed override bool IsByRefLike { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }
	protected abstract string Suffix { get; }

	// Methods

	// RVA: 0x144CF50 Offset: 0x144B550 VA: 0x18144CF50
	protected void .ctor(SignatureType elementType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 46
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 44
	public sealed override bool get_IsByRefLike() { }

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x144D6C0 Offset: 0x144BCC0 VA: 0x18144D6C0 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 136
	internal sealed override SignatureType get_ElementType() { }

	// RVA: -1 Offset: -1 Slot: 48
	public abstract override int GetArrayRank();

	// RVA: 0x144D600 Offset: 0x144BC00 VA: 0x18144D600 Slot: 49
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x144D5D0 Offset: 0x144BBD0 VA: 0x18144D5D0 Slot: 51
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x144D740 Offset: 0x144BD40 VA: 0x18144D740 Slot: 50
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x144D6F0 Offset: 0x144BCF0 VA: 0x18144D6F0 Slot: 52
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x144D770 Offset: 0x144BD70 VA: 0x18144D770 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x144D5A0 Offset: 0x144BBA0 VA: 0x18144D5A0 Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x144D650 Offset: 0x144BC50 VA: 0x18144D650 Slot: 3
	public sealed override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 137
	protected abstract string get_Suffix();
}

// Namespace: System.Reflection
internal sealed class SignaturePointerType : SignatureHasElementType // TypeDefIndex: 1265
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x144CF50 Offset: 0x144B550 VA: 0x18144CF50
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x144D7E0 Offset: 0x144BDE0 VA: 0x18144D7E0 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x144D830 Offset: 0x144BE30 VA: 0x18144D830 Slot: 137
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal abstract class SignatureType : Type // TypeDefIndex: 1266
{
	// Properties
	public sealed override bool IsSignatureType { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public abstract override bool IsByRefLike { get; }
	public sealed override bool IsGenericType { get; }
	public abstract override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsConstructedGenericType { get; }
	public abstract override bool IsGenericParameter { get; }
	public abstract override bool IsGenericMethodParameter { get; }
	public abstract override bool ContainsGenericParameters { get; }
	public sealed override MemberTypes MemberType { get; }
	public abstract override Type[] GenericTypeArguments { get; }
	public abstract override int GenericParameterPosition { get; }
	internal abstract SignatureType ElementType { get; }
	public sealed override Type UnderlyingSystemType { get; }
	public abstract override string Name { get; }
	public abstract override string Namespace { get; }
	public sealed override string FullName { get; }
	public sealed override string AssemblyQualifiedName { get; }
	public sealed override Assembly Assembly { get; }
	public sealed override Module Module { get; }
	public sealed override Type ReflectedType { get; }
	public sealed override Type BaseType { get; }
	public sealed override int MetadataToken { get; }
	public sealed override Type DeclaringType { get; }
	public sealed override MethodBase DeclaringMethod { get; }
	public sealed override GenericParameterAttributes GenericParameterAttributes { get; }
	public sealed override Guid GUID { get; }
	public sealed override bool IsEnum { get; }
	public sealed override bool IsSerializable { get; }
	public sealed override RuntimeTypeHandle TypeHandle { get; }

	// Methods

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 78
	public sealed override bool get_IsSignatureType() { }

	// RVA: -1 Offset: -1 Slot: 46
	protected abstract override bool HasElementTypeImpl();

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract override bool get_IsByRefLike();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: 0x144F690 Offset: 0x144DC90 VA: 0x18144F690 Slot: 40
	public sealed override bool get_IsGenericType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract override bool get_IsGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract override bool get_IsConstructedGenericType();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract override bool get_IsGenericParameter();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract override bool get_IsGenericMethodParameter();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract override bool get_ContainsGenericParameters();

	// RVA: 0x44EB30 Offset: 0x44D130 VA: 0x18044EB30 Slot: 7
	public sealed override MemberTypes get_MemberType() { }

	// RVA: 0x144F190 Offset: 0x144D790 VA: 0x18144F190 Slot: 126
	public sealed override Type MakeArrayType() { }

	// RVA: 0x144F210 Offset: 0x144D810 VA: 0x18144F210 Slot: 127
	public sealed override Type MakeArrayType(int rank) { }

	// RVA: 0x144F2E0 Offset: 0x144D8E0 VA: 0x18144F2E0 Slot: 128
	public sealed override Type MakeByRefType() { }

	// RVA: 0x144F3B0 Offset: 0x144D9B0 VA: 0x18144F3B0 Slot: 130
	public sealed override Type MakePointerType() { }

	// RVA: 0x144F360 Offset: 0x144D960 VA: 0x18144F360 Slot: 129
	public sealed override Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x144E7C0 Offset: 0x144CDC0 VA: 0x18144E7C0 Slot: 47
	public sealed override Type GetElementType() { }

	// RVA: -1 Offset: -1 Slot: 48
	public abstract override int GetArrayRank();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract override Type GetGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract override Type[] get_GenericTypeArguments();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract override Type[] GetGenericArguments();

	// RVA: -1 Offset: -1 Slot: 52
	public abstract override int get_GenericParameterPosition();

	// RVA: -1 Offset: -1 Slot: 136
	internal abstract SignatureType get_ElementType();

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 30
	public sealed override Type get_UnderlyingSystemType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract override string get_Name();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract override string get_Namespace();

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 26
	public sealed override string get_FullName() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 25
	public sealed override string get_AssemblyQualifiedName() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract override string ToString();

	// RVA: 0x144F460 Offset: 0x144DA60 VA: 0x18144F460 Slot: 27
	public sealed override Assembly get_Assembly() { }

	// RVA: 0x144F780 Offset: 0x144DD80 VA: 0x18144F780 Slot: 28
	public sealed override Module get_Module() { }

	// RVA: 0x144F7D0 Offset: 0x144DDD0 VA: 0x18144F7D0 Slot: 10
	public sealed override Type get_ReflectedType() { }

	// RVA: 0x144F4B0 Offset: 0x144DAB0 VA: 0x18144F4B0 Slot: 118
	public sealed override Type get_BaseType() { }

	// RVA: 0x144EAB0 Offset: 0x144D0B0 VA: 0x18144EAB0 Slot: 121
	public sealed override Type[] GetInterfaces() { }

	// RVA: 0x144EE20 Offset: 0x144D420 VA: 0x18144EE20 Slot: 22
	public sealed override bool IsAssignableFrom(Type c) { }

	// RVA: 0x144F730 Offset: 0x144DD30 VA: 0x18144F730 Slot: 15
	public sealed override int get_MetadataToken() { }

	// RVA: 0x144F550 Offset: 0x144DB50 VA: 0x18144F550 Slot: 9
	public sealed override Type get_DeclaringType() { }

	// RVA: 0x144F500 Offset: 0x144DB00 VA: 0x18144F500 Slot: 29
	public sealed override MethodBase get_DeclaringMethod() { }

	// RVA: 0x144EA60 Offset: 0x144D060 VA: 0x18144EA60 Slot: 54
	public sealed override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x144F5F0 Offset: 0x144DBF0 VA: 0x18144F5F0 Slot: 53
	public sealed override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x144EF60 Offset: 0x144D560 VA: 0x18144EF60 Slot: 16
	public sealed override bool IsEnumDefined(object value) { }

	// RVA: 0x144E7E0 Offset: 0x144CDE0 VA: 0x18144E7E0 Slot: 17
	public sealed override string GetEnumName(object value) { }

	// RVA: 0x144E830 Offset: 0x144CE30 VA: 0x18144E830 Slot: 18
	public sealed override string[] GetEnumNames() { }

	// RVA: 0x144E880 Offset: 0x144CE80 VA: 0x18144E880 Slot: 124
	public sealed override Type GetEnumUnderlyingType() { }

	// RVA: 0x144E8D0 Offset: 0x144CED0 VA: 0x18144E8D0 Slot: 125
	public sealed override Array GetEnumValues() { }

	// RVA: 0x144F5A0 Offset: 0x144DBA0 VA: 0x18144F5A0 Slot: 117
	public sealed override Guid get_GUID() { }

	// RVA: 0x144ED80 Offset: 0x144D380 VA: 0x18144ED80 Slot: 116
	protected sealed override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x144E630 Offset: 0x144CC30 VA: 0x18144E630 Slot: 56
	protected sealed override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x144E6D0 Offset: 0x144CCD0 VA: 0x18144E6D0 Slot: 84
	public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x144E920 Offset: 0x144CF20 VA: 0x18144E920 Slot: 86
	public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x144E970 Offset: 0x144CF70 VA: 0x18144E970 Slot: 87
	public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x144E9C0 Offset: 0x144CFC0 VA: 0x18144E9C0 Slot: 89
	public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x144EA10 Offset: 0x144D010 VA: 0x18144EA10 Slot: 91
	public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x144EBA0 Offset: 0x144D1A0 VA: 0x18144EBA0 Slot: 95
	public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x144EC40 Offset: 0x144D240 VA: 0x18144EC40 Slot: 104
	public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x144EC90 Offset: 0x144D290 VA: 0x18144EC90 Slot: 105
	public sealed override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x144ECE0 Offset: 0x144D2E0 VA: 0x18144ECE0 Slot: 114
	public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x144EDD0 Offset: 0x144D3D0 VA: 0x18144EDD0 Slot: 120
	public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x144EBF0 Offset: 0x144D1F0 VA: 0x18144EBF0 Slot: 102
	protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x144ED30 Offset: 0x144D330 VA: 0x18144ED30 Slot: 112
	protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x144EB50 Offset: 0x144D150 VA: 0x18144EB50 Slot: 93
	public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x144EB00 Offset: 0x144D100 VA: 0x18144EB00 Slot: 94
	public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x144E720 Offset: 0x144CD20 VA: 0x18144E720 Slot: 13
	public sealed override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x144E770 Offset: 0x144CD70 VA: 0x18144E770 Slot: 14
	public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x144EF10 Offset: 0x144D510 VA: 0x18144EF10 Slot: 12
	public sealed override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x144E680 Offset: 0x144CC80 VA: 0x18144E680 Slot: 82
	protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x144EE70 Offset: 0x144D470 VA: 0x18144EE70 Slot: 67
	protected sealed override bool IsCOMObjectImpl() { }

	// RVA: 0x144F0A0 Offset: 0x144D6A0 VA: 0x18144F0A0 Slot: 75
	protected sealed override bool IsPrimitiveImpl() { }

	// RVA: 0x144EEC0 Offset: 0x144D4C0 VA: 0x18144EEC0 Slot: 69
	protected sealed override bool IsContextfulImpl() { }

	// RVA: 0x144F640 Offset: 0x144DC40 VA: 0x18144F640 Slot: 71
	public sealed override bool get_IsEnum() { }

	// RVA: 0x144EFB0 Offset: 0x144D5B0 VA: 0x18144EFB0 Slot: 123
	public sealed override bool IsEquivalentTo(Type other) { }

	// RVA: 0x144F000 Offset: 0x144D600 VA: 0x18144F000 Slot: 122
	public sealed override bool IsInstanceOfType(object o) { }

	// RVA: 0x144F050 Offset: 0x144D650 VA: 0x18144F050 Slot: 73
	protected sealed override bool IsMarshalByRefImpl() { }

	// RVA: 0x144F6E0 Offset: 0x144DCE0 VA: 0x18144F6E0 Slot: 19
	public sealed override bool get_IsSerializable() { }

	// RVA: 0x144F0F0 Offset: 0x144D6F0 VA: 0x18144F0F0 Slot: 21
	public sealed override bool IsSubclassOf(Type c) { }

	// RVA: 0x144F140 Offset: 0x144D740 VA: 0x18144F140 Slot: 77
	protected sealed override bool IsValueTypeImpl() { }

	// RVA: 0x144F820 Offset: 0x144DE20 VA: 0x18144F820 Slot: 115
	public sealed override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x144F430 Offset: 0x144DA30 VA: 0x18144F430
	protected void .ctor() { }
}

// Namespace: System.Reflection
[Extension]
internal static class SignatureTypeExtensions // TypeDefIndex: 1267
{
	// Methods

	[Extension]
	// RVA: 0x144DC50 Offset: 0x144C250 VA: 0x18144DC50
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Extension]
	// RVA: 0x144D860 Offset: 0x144BE60 VA: 0x18144D860
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Extension]
	// RVA: 0x144E1D0 Offset: 0x144C7D0 VA: 0x18144E1D0
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

	[Extension]
	// RVA: 0x144E210 Offset: 0x144C810 VA: 0x18144E210
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Extension]
	// RVA: 0x144E110 Offset: 0x144C710 VA: 0x18144E110
	private static Type TryMakeArrayType(Type type) { }

	[Extension]
	// RVA: 0x144E0E0 Offset: 0x144C6E0 VA: 0x18144E0E0
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Extension]
	// RVA: 0x144E140 Offset: 0x144C740 VA: 0x18144E140
	private static Type TryMakeByRefType(Type type) { }

	[Extension]
	// RVA: 0x144E1A0 Offset: 0x144C7A0 VA: 0x18144E1A0
	private static Type TryMakePointerType(Type type) { }

	[Extension]
	// RVA: 0x144E170 Offset: 0x144C770 VA: 0x18144E170
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }
}

// Namespace: System.Reflection
[Serializable]
public class TargetException : ApplicationException // TypeDefIndex: 1268
{
	// Methods

	// RVA: 0x144FBD0 Offset: 0x144E1D0 VA: 0x18144FBD0
	public void .ctor() { }

	// RVA: 0x144FC00 Offset: 0x144E200 VA: 0x18144FC00
	public void .ctor(string message) { }

	// RVA: 0x144FBB0 Offset: 0x144E1B0 VA: 0x18144FBB0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1440750 Offset: 0x143ED50 VA: 0x181440750
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class TargetInvocationException : ApplicationException // TypeDefIndex: 1269
{
	// Methods

	// RVA: 0x144FC30 Offset: 0x144E230 VA: 0x18144FC30
	public void .ctor(Exception inner) { }

	// RVA: 0x144FC90 Offset: 0x144E290 VA: 0x18144FC90
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1440750 Offset: 0x143ED50 VA: 0x181440750
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class TargetParameterCountException : ApplicationException // TypeDefIndex: 1270
{
	// Methods

	// RVA: 0x144FCD0 Offset: 0x144E2D0 VA: 0x18144FCD0
	public void .ctor() { }

	// RVA: 0x144FCB0 Offset: 0x144E2B0 VA: 0x18144FCB0
	public void .ctor(string message) { }

	// RVA: 0x1440750 Offset: 0x143ED50 VA: 0x181440750
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Flags]
public enum TypeAttributes // TypeDefIndex: 1271
{
	// Fields
	public int value__; // 0x0
	public const TypeAttributes VisibilityMask = 7;
	public const TypeAttributes NotPublic = 0;
	public const TypeAttributes Public = 1;
	public const TypeAttributes NestedPublic = 2;
	public const TypeAttributes NestedPrivate = 3;
	public const TypeAttributes NestedFamily = 4;
	public const TypeAttributes NestedAssembly = 5;
	public const TypeAttributes NestedFamANDAssem = 6;
	public const TypeAttributes NestedFamORAssem = 7;
	public const TypeAttributes LayoutMask = 24;
	public const TypeAttributes AutoLayout = 0;
	public const TypeAttributes SequentialLayout = 8;
	public const TypeAttributes ExplicitLayout = 16;
	public const TypeAttributes ClassSemanticsMask = 32;
	public const TypeAttributes Class = 0;
	public const TypeAttributes Interface = 32;
	public const TypeAttributes Abstract = 128;
	public const TypeAttributes Sealed = 256;
	public const TypeAttributes SpecialName = 1024;
	public const TypeAttributes Import = 4096;
	public const TypeAttributes Serializable = 8192;
	public const TypeAttributes WindowsRuntime = 16384;
	public const TypeAttributes StringFormatMask = 196608;
	public const TypeAttributes AnsiClass = 0;
	public const TypeAttributes UnicodeClass = 65536;
	public const TypeAttributes AutoClass = 131072;
	public const TypeAttributes CustomFormatClass = 196608;
	public const TypeAttributes CustomFormatMask = 12582912;
	public const TypeAttributes BeforeFieldInit = 1048576;
	public const TypeAttributes RTSpecialName = 2048;
	public const TypeAttributes HasSecurity = 262144;
	public const TypeAttributes ReservedMask = 264192;
}

// Namespace: System.Reflection
public class TypeDelegator : TypeInfo // TypeDefIndex: 1272
{
	// Fields
	protected Type typeImpl; // 0x18

	// Properties
	public override Guid GUID { get; }
	public override int MetadataToken { get; }
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override string Name { get; }
	public override string FullName { get; }
	public override string Namespace { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override bool IsSZArray { get; }
	public override bool IsGenericMethodParameter { get; }
	public override bool IsByRefLike { get; }
	public override bool IsConstructedGenericType { get; }
	public override bool IsCollectible { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x1450B00 Offset: 0x144F100 VA: 0x181450B00
	public void .ctor(Type delegatingType) { }

	// RVA: 0x1450C50 Offset: 0x144F250 VA: 0x181450C50 Slot: 117
	public override Guid get_GUID() { }

	// RVA: 0x1450D20 Offset: 0x144F320 VA: 0x181450D20 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x14509D0 Offset: 0x144EFD0 VA: 0x1814509D0 Slot: 120
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x1450D50 Offset: 0x144F350 VA: 0x181450D50 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x1450BC0 Offset: 0x144F1C0 VA: 0x181450BC0 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x1450D80 Offset: 0x144F380 VA: 0x181450D80 Slot: 115
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x144D570 Offset: 0x144BB70 VA: 0x18144D570 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1450C20 Offset: 0x144F220 VA: 0x181450C20 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x144D5A0 Offset: 0x144BBA0 VA: 0x18144D5A0 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x138B8B0 Offset: 0x1389EB0 VA: 0x18138B8B0 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x1450BF0 Offset: 0x144F1F0 VA: 0x181450BF0 Slot: 118
	public override Type get_BaseType() { }

	// RVA: 0x14505C0 Offset: 0x144EBC0 VA: 0x1814505C0 Slot: 82
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x14505F0 Offset: 0x144EBF0 VA: 0x1814505F0 Slot: 84
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1450800 Offset: 0x144EE00 VA: 0x181450800 Slot: 102
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1450850 Offset: 0x144EE50 VA: 0x181450850 Slot: 104
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x1450710 Offset: 0x144ED10 VA: 0x181450710 Slot: 89
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1450740 Offset: 0x144ED40 VA: 0x181450740 Slot: 91
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1450770 Offset: 0x144ED70 VA: 0x181450770 Slot: 121
	public override Type[] GetInterfaces() { }

	// RVA: 0x14506B0 Offset: 0x144ECB0 VA: 0x1814506B0 Slot: 86
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x14508E0 Offset: 0x144EEE0 VA: 0x1814508E0 Slot: 112
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x14508B0 Offset: 0x144EEB0 VA: 0x1814508B0 Slot: 114
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x14506E0 Offset: 0x144ECE0 VA: 0x1814506E0 Slot: 87
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x1450880 Offset: 0x144EE80 VA: 0x181450880 Slot: 105
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x14507A0 Offset: 0x144EDA0 VA: 0x1814507A0 Slot: 94
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x14507D0 Offset: 0x144EDD0 VA: 0x1814507D0 Slot: 95
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x14505A0 Offset: 0x144EBA0 VA: 0x1814505A0 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1450CF0 Offset: 0x144F2F0 VA: 0x181450CF0 Slot: 42
	public override bool get_IsSZArray() { }

	// RVA: 0x1450A10 Offset: 0x144F010 VA: 0x181450A10 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x1450AC0 Offset: 0x144F0C0 VA: 0x181450AC0 Slot: 75
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1450A30 Offset: 0x144F030 VA: 0x181450A30 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x1450CC0 Offset: 0x144F2C0 VA: 0x181450CC0 Slot: 39
	public override bool get_IsGenericMethodParameter() { }

	// RVA: 0x1450AA0 Offset: 0x144F0A0 VA: 0x181450AA0 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x1450AE0 Offset: 0x144F0E0 VA: 0x181450AE0 Slot: 77
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x1450A50 Offset: 0x144F050 VA: 0x181450A50 Slot: 67
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x144D540 Offset: 0x144BB40 VA: 0x18144D540 Slot: 44
	public override bool get_IsByRefLike() { }

	// RVA: 0x138AC80 Offset: 0x1389280 VA: 0x18138AC80 Slot: 37
	public override bool get_IsConstructedGenericType() { }

	// RVA: 0x1450C90 Offset: 0x144F290 VA: 0x181450C90 Slot: 70
	public override bool get_IsCollectible() { }

	// RVA: 0x1450680 Offset: 0x144EC80 VA: 0x181450680 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x14509B0 Offset: 0x144EFB0 VA: 0x1814509B0 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1450DB0 Offset: 0x144F3B0 VA: 0x181450DB0 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1450650 Offset: 0x144EC50 VA: 0x181450650 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1450620 Offset: 0x144EC20 VA: 0x181450620 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1450A70 Offset: 0x144F070 VA: 0x181450A70 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection
public sealed class TypeFilter : MulticastDelegate // TypeDefIndex: 1273
{
	// Methods

	// RVA: 0x14408D0 Offset: 0x143EED0 VA: 0x1814408D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D4320 Offset: 0x5D2920 VA: 0x1805D4320 Slot: 13
	public virtual bool Invoke(Type m, object filterCriteria) { }
}

// Namespace: System.Reflection
public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 1274
{
	// Properties
	public virtual IEnumerable<Type> ImplementedInterfaces { get; }

	// Methods

	// RVA: 0x144F430 Offset: 0x144DA30 VA: 0x18144F430
	protected void .ctor() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 136
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0x1450DE0 Offset: 0x144F3E0 VA: 0x181450DE0 Slot: 137
	public virtual IEnumerable<Type> get_ImplementedInterfaces() { }
}

// Namespace: System.Reflection
[Extension]
public static class RuntimeReflectionExtensions // TypeDefIndex: 1275
{
	// Methods

	[Extension]
	// RVA: 0x144CD20 Offset: 0x144B320 VA: 0x18144CD20
	public static FieldInfo GetRuntimeField(Type type, string name) { }
}

// Namespace: System.Reflection
public struct CustomAttributeNamedArgument // TypeDefIndex: 1276
{
	// Fields
	[CompilerGenerated]
	private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <IsField>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x18
	private readonly Type _attributeType; // 0x20
	private MemberInfo _lazyMemberInfo; // 0x28

	// Properties
	public CustomAttributeTypedArgument TypedValue { get; }
	public bool IsField { get; }
	public string MemberName { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x1436300 Offset: 0x1434900 VA: 0x181436300
	internal void .ctor(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue) { }

	// RVA: 0x1436370 Offset: 0x1434970 VA: 0x181436370
	public void .ctor(MemberInfo memberInfo, object value) { }

	// RVA: 0x1436660 Offset: 0x1434C60 VA: 0x181436660
	public void .ctor(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public CustomAttributeTypedArgument get_TypedValue() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_IsField() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_MemberName() { }

	// RVA: 0x14367F0 Offset: 0x1434DF0 VA: 0x1814367F0
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x1435F50 Offset: 0x1434550 VA: 0x181435F50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1435FC0 Offset: 0x14345C0 VA: 0x181435FC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1436970 Offset: 0x1434F70 VA: 0x181436970
	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x1436A30 Offset: 0x1435030 VA: 0x181436A30
	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x1436020 Offset: 0x1434620 VA: 0x181436020 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
public struct CustomAttributeTypedArgument // TypeDefIndex: 1277
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ArgumentType>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x8

	// Properties
	public Type ArgumentType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x14375A0 Offset: 0x1435BA0 VA: 0x1814375A0
	public void .ctor(object value) { }

	// RVA: 0x14372F0 Offset: 0x14358F0 VA: 0x1814372F0
	public void .ctor(Type argumentType, object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public Type get_ArgumentType() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public object get_Value() { }

	// RVA: 0x1436B80 Offset: 0x1435180 VA: 0x181436B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1436BE0 Offset: 0x14351E0 VA: 0x181436BE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14376C0 Offset: 0x1435CC0 VA: 0x1814376C0
	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x1437750 Offset: 0x1435D50 VA: 0x181437750
	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x14372E0 Offset: 0x14358E0 VA: 0x1814372E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1436C30 Offset: 0x1435230 VA: 0x181436C30
	internal string ToString(bool typed) { }

	// RVA: 0x1436AF0 Offset: 0x14350F0 VA: 0x181436AF0
	private static object CanonicalizeValue(object value) { }
}

// Namespace: System.Reflection
public sealed class MissingMetadataException : TypeAccessException // TypeDefIndex: 1278
{
	// Methods

	// RVA: 0x14433E0 Offset: 0x14419E0 VA: 0x1814433E0
	public void .ctor() { }
}

// Namespace: System.Reflection
[Extension]
public static class CustomAttributeExtensions // TypeDefIndex: 1279
{
	// Methods

	[Extension]
	// RVA: 0x1435EE0 Offset: 0x14344E0 VA: 0x181435EE0
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Extension]
	// RVA: 0x1435EF0 Offset: 0x14344F0 VA: 0x181435EF0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C1640 Offset: 0x6BFC40 VA: 0x1806C1640
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C16F0 Offset: 0x6BFCF0 VA: 0x1806C16F0
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x1435F00 Offset: 0x1434500 VA: 0x181435F00
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C17A0 Offset: 0x6BFDA0 VA: 0x1806C17A0
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x1435F10 Offset: 0x1434510 VA: 0x181435F10
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[Extension]
	// RVA: 0x1435F30 Offset: 0x1434530 VA: 0x181435F30
	public static IEnumerable<Attribute> GetCustomAttributes(Assembly element, Type attributeType) { }

	[Extension]
	// RVA: 0x1435F20 Offset: 0x1434520 VA: 0x181435F20
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C1860 Offset: 0x6BFE60 VA: 0x1806C1860
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: 0x1435F40 Offset: 0x1434540 VA: 0x181435F40
	public static bool IsDefined(MemberInfo element, Type attributeType) { }
}

// Namespace: System.Reflection
[Serializable]
internal enum CorElementType // TypeDefIndex: 1280
{
	// Fields
	public byte value__; // 0x0
	public const CorElementType End = 0;
	public const CorElementType Void = 1;
	public const CorElementType Boolean = 2;
	public const CorElementType Char = 3;
	public const CorElementType I1 = 4;
	public const CorElementType U1 = 5;
	public const CorElementType I2 = 6;
	public const CorElementType U2 = 7;
	public const CorElementType I4 = 8;
	public const CorElementType U4 = 9;
	public const CorElementType I8 = 10;
	public const CorElementType U8 = 11;
	public const CorElementType R4 = 12;
	public const CorElementType R8 = 13;
	public const CorElementType String = 14;
	public const CorElementType Ptr = 15;
	public const CorElementType ByRef = 16;
	public const CorElementType ValueType = 17;
	public const CorElementType Class = 18;
	public const CorElementType Var = 19;
	public const CorElementType Array = 20;
	public const CorElementType GenericInst = 21;
	public const CorElementType TypedByRef = 22;
	public const CorElementType I = 24;
	public const CorElementType U = 25;
	public const CorElementType FnPtr = 27;
	public const CorElementType Object = 28;
	public const CorElementType SzArray = 29;
	public const CorElementType MVar = 30;
	public const CorElementType CModReqd = 31;
	public const CorElementType CModOpt = 32;
	public const CorElementType Internal = 33;
	public const CorElementType Max = 34;
	public const CorElementType Modifier = 64;
	public const CorElementType Sentinel = 65;
	public const CorElementType Pinned = 69;
	public const CorElementType ELEMENT_TYPE_END = 0;
	public const CorElementType ELEMENT_TYPE_VOID = 1;
	public const CorElementType ELEMENT_TYPE_BOOLEAN = 2;
	public const CorElementType ELEMENT_TYPE_CHAR = 3;
	public const CorElementType ELEMENT_TYPE_I1 = 4;
	public const CorElementType ELEMENT_TYPE_U1 = 5;
	public const CorElementType ELEMENT_TYPE_I2 = 6;
	public const CorElementType ELEMENT_TYPE_U2 = 7;
	public const CorElementType ELEMENT_TYPE_I4 = 8;
	public const CorElementType ELEMENT_TYPE_U4 = 9;
	public const CorElementType ELEMENT_TYPE_I8 = 10;
	public const CorElementType ELEMENT_TYPE_U8 = 11;
	public const CorElementType ELEMENT_TYPE_R4 = 12;
	public const CorElementType ELEMENT_TYPE_R8 = 13;
	public const CorElementType ELEMENT_TYPE_STRING = 14;
	public const CorElementType ELEMENT_TYPE_PTR = 15;
	public const CorElementType ELEMENT_TYPE_BYREF = 16;
	public const CorElementType ELEMENT_TYPE_VALUETYPE = 17;
	public const CorElementType ELEMENT_TYPE_CLASS = 18;
	public const CorElementType ELEMENT_TYPE_VAR = 19;
	public const CorElementType ELEMENT_TYPE_ARRAY = 20;
	public const CorElementType ELEMENT_TYPE_GENERICINST = 21;
	public const CorElementType ELEMENT_TYPE_TYPEDBYREF = 22;
	public const CorElementType ELEMENT_TYPE_I = 24;
	public const CorElementType ELEMENT_TYPE_U = 25;
	public const CorElementType ELEMENT_TYPE_FNPTR = 27;
	public const CorElementType ELEMENT_TYPE_OBJECT = 28;
	public const CorElementType ELEMENT_TYPE_SZARRAY = 29;
	public const CorElementType ELEMENT_TYPE_MVAR = 30;
	public const CorElementType ELEMENT_TYPE_CMOD_REQD = 31;
	public const CorElementType ELEMENT_TYPE_CMOD_OPT = 32;
	public const CorElementType ELEMENT_TYPE_INTERNAL = 33;
	public const CorElementType ELEMENT_TYPE_MAX = 34;
	public const CorElementType ELEMENT_TYPE_MODIFIER = 64;
	public const CorElementType ELEMENT_TYPE_SENTINEL = 65;
	public const CorElementType ELEMENT_TYPE_PINNED = 69;
}

// Namespace: System.Reflection
[Flags]
[Serializable]
internal enum PInvokeAttributes // TypeDefIndex: 1281
{
	// Fields
	public int value__; // 0x0
	public const PInvokeAttributes NoMangle = 1;
	public const PInvokeAttributes CharSetMask = 6;
	public const PInvokeAttributes CharSetNotSpec = 0;
	public const PInvokeAttributes CharSetAnsi = 2;
	public const PInvokeAttributes CharSetUnicode = 4;
	public const PInvokeAttributes CharSetAuto = 6;
	public const PInvokeAttributes BestFitUseAssem = 0;
	public const PInvokeAttributes BestFitEnabled = 16;
	public const PInvokeAttributes BestFitDisabled = 32;
	public const PInvokeAttributes BestFitMask = 48;
	public const PInvokeAttributes ThrowOnUnmappableCharUseAssem = 0;
	public const PInvokeAttributes ThrowOnUnmappableCharEnabled = 4096;
	public const PInvokeAttributes ThrowOnUnmappableCharDisabled = 8192;
	public const PInvokeAttributes ThrowOnUnmappableCharMask = 12288;
	public const PInvokeAttributes SupportsLastError = 64;
	public const PInvokeAttributes CallConvMask = 1792;
	public const PInvokeAttributes CallConvWinapi = 256;
	public const PInvokeAttributes CallConvCdecl = 512;
	public const PInvokeAttributes CallConvStdcall = 768;
	public const PInvokeAttributes CallConvThiscall = 1024;
	public const PInvokeAttributes CallConvFastcall = 1280;
	public const PInvokeAttributes MaxValue = 65535;
}

// Namespace: System.Reflection
[Serializable]
internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 1282
{
	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x1441A40 Offset: 0x1440040 VA: 0x181441A40
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x1441760 Offset: 0x143FD60 VA: 0x181441760
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x1441A70 Offset: 0x1440070 VA: 0x181441A70
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14409F0 Offset: 0x143EFF0 VA: 0x1814409F0 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1440A50 Offset: 0x143F050 VA: 0x181440A50 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[ComDefaultInterface(typeof(_Assembly))]
[ClassInterface(0)]
[Serializable]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 1284
{
	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	internal virtual IntPtr MonoAssembly { get; }
	internal virtual bool FromByteArray { set; }
	public virtual string Location { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x142E240 Offset: 0x142C840 VA: 0x18142E240 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0x142E280 Offset: 0x142C880 VA: 0x18142E280 Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x142E300 Offset: 0x142C900 VA: 0x18142E300 Slot: 10
	internal virtual IntPtr get_MonoAssembly() { }

	// RVA: 0x142E410 Offset: 0x142CA10 VA: 0x18142E410 Slot: 11
	internal virtual void set_FromByteArray(bool value) { }

	// RVA: 0x142E2C0 Offset: 0x142C8C0 VA: 0x18142E2C0 Slot: 12
	public virtual string get_Location() { }

	// RVA: 0x142DF00 Offset: 0x142C500 VA: 0x18142DF00 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x142DFF0 Offset: 0x142C5F0 VA: 0x18142DFF0 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x142DD10 Offset: 0x142C310 VA: 0x18142DD10 Slot: 15
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x142DCD0 Offset: 0x142C2D0 VA: 0x18142DCD0 Slot: 16
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x142DDC0 Offset: 0x142C3C0 VA: 0x18142DDC0 Slot: 17
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x142DFD0 Offset: 0x142C5D0 VA: 0x18142DFD0 Slot: 18
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x14159B0 Offset: 0x1413FB0 VA: 0x1814159B0 Slot: 19
	public virtual Type[] GetTypes() { }

	// RVA: 0x142DF70 Offset: 0x142C570 VA: 0x18142DF70 Slot: 20
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x142DF40 Offset: 0x142C540 VA: 0x18142DF40 Slot: 21
	public virtual Type GetType(string name) { }

	// RVA: 0x142DFE0 Offset: 0x142C5E0 VA: 0x18142DFE0
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x142DEA0 Offset: 0x142C4A0 VA: 0x18142DEA0 Slot: 22
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x142DEE0 Offset: 0x142C4E0 VA: 0x18142DEE0 Slot: 23
	public virtual AssemblyName GetName() { }

	// RVA: 0x142E230 Offset: 0x142C830 VA: 0x18142E230 Slot: 3
	public override string ToString() { }

	// RVA: 0x142DC20 Offset: 0x142C220 VA: 0x18142DC20
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x142E180 Offset: 0x142C780 VA: 0x18142E180
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x142E1B0 Offset: 0x142C7B0 VA: 0x18142E1B0
	public static Assembly Load(byte[] rawAssembly) { }

	// RVA: 0x142E1E0 Offset: 0x142C7E0 VA: 0x18142E1E0
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x142E030 Offset: 0x142C630 VA: 0x18142E030
	public static Assembly LoadWithPartialName(string partialName) { }

	// RVA: 0x142E340 Offset: 0x142C940 VA: 0x18142E340
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x142E120 Offset: 0x142C720 VA: 0x18142E120
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x142E090 Offset: 0x142C690 VA: 0x18142E090
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x142DE30 Offset: 0x142C430 VA: 0x18142DE30 Slot: 24
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x142DD50 Offset: 0x142C350 VA: 0x18142DD50
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x142DCC0 Offset: 0x142C2C0 VA: 0x18142DCC0
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x142DD80 Offset: 0x142C380 VA: 0x18142DD80 Slot: 25
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x142DC10 Offset: 0x142C210 VA: 0x18142DC10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x142DBB0 Offset: 0x142C1B0 VA: 0x18142DBB0
	private static Exception CreateNIE() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	public bool get_IsFullyTrusted() { }

	// RVA: 0x142DFA0 Offset: 0x142C5A0 VA: 0x18142DFA0 Slot: 26
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x142DE00 Offset: 0x142C400 VA: 0x18142DE00 Slot: 27
	public virtual Module GetModule(string name) { }

	// RVA: 0x142DE70 Offset: 0x142C470 VA: 0x18142DE70 Slot: 28
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x142E350 Offset: 0x142C950 VA: 0x18142E350
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x142E3B0 Offset: 0x142C9B0 VA: 0x18142E3B0
	public static bool op_Inequality(Assembly left, Assembly right) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(True)]
[ClassInterface(0)]
[Serializable]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 1285
{
	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; }
	public CultureInfo CultureInfo { get; }
	public AssemblyNameFlags Flags { get; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }
	public string CultureName { get; }

	// Methods

	// RVA: 0x142D0A0 Offset: 0x142B6A0 VA: 0x18142D0A0
	public void .ctor() { }

	// RVA: 0x142CE10 Offset: 0x142B410 VA: 0x18142CE10
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x142CE50 Offset: 0x142B450 VA: 0x18142CE50
	public void .ctor(string assemblyName) { }

	// RVA: 0x142D0C0 Offset: 0x142B6C0 VA: 0x18142D0C0
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0x142D680 Offset: 0x142BC80 VA: 0x18142D680
	public string get_FullName() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public Version get_Version() { }

	// RVA: 0x142DB30 Offset: 0x142C130 VA: 0x18142DB30
	public void set_Version(Version value) { }

	// RVA: 0x142CE20 Offset: 0x142B420 VA: 0x18142CE20 Slot: 3
	public override string ToString() { }

	// RVA: 0x142CBB0 Offset: 0x142B1B0 VA: 0x18142CBB0
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x142DA70 Offset: 0x142C070 VA: 0x18142DA70
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x142CCA0 Offset: 0x142B2A0 VA: 0x18142CCA0
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0x142DB20 Offset: 0x142C120 VA: 0x18142DB20
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x142C490 Offset: 0x142AA90 VA: 0x18142C490
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x142C8E0 Offset: 0x142AEE0 VA: 0x18142C8E0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x142C390 Offset: 0x142A990 VA: 0x18142C390 Slot: 4
	public object Clone() { }

	// RVA: 0x142CD90 Offset: 0x142B390 VA: 0x18142CD90 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x142D650 Offset: 0x142BC50 VA: 0x18142D650
	public string get_CultureName() { }

	// RVA: 0x142C8D0 Offset: 0x142AED0 VA: 0x18142C8D0
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x142C610 Offset: 0x142AC10 VA: 0x18142C610
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x142C520 Offset: 0x142AB20 VA: 0x18142C520
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class CustomAttributeData // TypeDefIndex: 1287
{
	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisible(True)]
	public virtual ConstructorInfo Constructor { get; }
	[ComVisible(True)]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1435D20 Offset: 0x1434320 VA: 0x181435D20
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x1435DF0 Offset: 0x14343F0 VA: 0x181435DF0
	internal void .ctor(ConstructorInfo ctorInfo) { }

	// RVA: 0xA68FD0 Offset: 0xA675D0 VA: 0x180A68FD0
	internal void .ctor(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	// RVA: 0x14355C0 Offset: 0x1433BC0 VA: 0x1814355C0
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x14355D0 Offset: 0x1433BD0 VA: 0x1814355D0
	private void ResolveArguments() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x1435EA0 Offset: 0x14344A0 VA: 0x181435EA0 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x1435EC0 Offset: 0x14344C0 VA: 0x181435EC0 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x14350E0 Offset: 0x14336E0 VA: 0x1814350E0
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x1435090 Offset: 0x1433690 VA: 0x181435090
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x1434FA0 Offset: 0x14335A0 VA: 0x181434FA0
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x1434FF0 Offset: 0x14335F0 VA: 0x181434FF0
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x1435040 Offset: 0x1433640 VA: 0x181435040
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0x140B6A0 Offset: 0x1409CA0 VA: 0x18140B6A0
	public Type get_AttributeType() { }

	// RVA: 0x1435720 Offset: 0x1433D20 VA: 0x181435720 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C1240 Offset: 0x6BF840 VA: 0x1806C1240
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x6C1380 Offset: 0x6BF980 VA: 0x1806C1380
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	|
	|-RVA: 0x6C14A0 Offset: 0x6BFAA0 VA: 0x1806C14A0
	|-CustomAttributeData.UnboxValues<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1434A80 Offset: 0x1433080 VA: 0x181434A80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1435130 Offset: 0x1433730 VA: 0x181435130 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
public class ExceptionHandlingClause // TypeDefIndex: 1288
{
	// Fields
	internal Type catch_type; // 0x10
	internal int filter_offset; // 0x18
	internal ExceptionHandlingClauseOptions flags; // 0x1C
	internal int try_offset; // 0x20
	internal int try_length; // 0x24
	internal int handler_offset; // 0x28
	internal int handler_length; // 0x2C

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x143FA90 Offset: 0x143E090 VA: 0x18143FA90 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
public class LocalVariableInfo // TypeDefIndex: 1289
{
	// Fields
	internal Type type; // 0x10
	internal bool is_pinned; // 0x18
	internal ushort position; // 0x1A

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x14407E0 Offset: 0x143EDE0 VA: 0x1814407E0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[ComDefaultInterface(typeof(_Assembly))]
[ClassInterface(0)]
[Serializable]
internal class RuntimeAssembly : Assembly // TypeDefIndex: 1291
{
	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private object _evidence; // 0x18
	internal Assembly.ResolveEventHolder resolve_event_holder; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	internal bool fromByteArray; // 0x50
	internal string assemblyName; // 0x58

	// Properties
	public override string CodeBase { get; }
	public override string FullName { get; }
	internal override IntPtr MonoAssembly { get; }
	internal override bool FromByteArray { set; }
	public override string Location { get; }

	// Methods

	// RVA: 0x1445D30 Offset: 0x1444330 VA: 0x181445D30
	protected void .ctor() { }

	// RVA: 0x1445940 Offset: 0x1443F40 VA: 0x181445940 Slot: 13
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1445C10 Offset: 0x1444210 VA: 0x181445C10
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x1445B20 Offset: 0x1444120 VA: 0x181445B20
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x1445870 Offset: 0x1443E70 VA: 0x181445870 Slot: 22
	public override AssemblyName GetName(bool copiedName) { }

	// RVA: 0x14459E0 Offset: 0x1443FE0 VA: 0x1814459E0 Slot: 26
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x14455C0 Offset: 0x1443BC0 VA: 0x1814455C0 Slot: 27
	public override Module GetModule(string name) { }

	// RVA: 0x1445730 Offset: 0x1443D30 VA: 0x181445730 Slot: 28
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x1444F60 Offset: 0x1443560 VA: 0x181444F60
	internal static byte[] GetAotId() { }

	// RVA: 0x1444FB0 Offset: 0x14435B0 VA: 0x181444FB0
	private static string get_code_base(Assembly a, bool escaped) { }

	// RVA: 0x1445DE0 Offset: 0x14443E0 VA: 0x181445DE0
	private string get_location() { }

	// RVA: 0x1445DB0 Offset: 0x14443B0 VA: 0x181445DB0
	internal static string get_fullname(Assembly a) { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	internal static bool GetAotIdInternal(byte[] aotid) { }

	// RVA: 0x1444FB0 Offset: 0x14435B0 VA: 0x181444FB0
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	// RVA: 0x1445DA0 Offset: 0x14443A0 VA: 0x181445DA0 Slot: 8
	public override string get_CodeBase() { }

	// RVA: 0x1445DB0 Offset: 0x14443B0 VA: 0x181445DB0 Slot: 9
	public override string get_FullName() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 10
	internal override IntPtr get_MonoAssembly() { }

	// RVA: 0x1031CD0 Offset: 0x10302D0 VA: 0x181031CD0 Slot: 11
	internal override void set_FromByteArray(bool value) { }

	// RVA: 0x1445DC0 Offset: 0x14443C0 VA: 0x181445DC0 Slot: 12
	public override string get_Location() { }

	// RVA: 0x1445090 Offset: 0x1443690 VA: 0x181445090
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x14450A0 Offset: 0x14436A0 VA: 0x1814450A0 Slot: 25
	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x14451E0 Offset: 0x14437E0 VA: 0x1814451E0
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x14451F0 Offset: 0x14437F0 VA: 0x1814451F0 Slot: 17
	public override Stream GetManifestResourceStream(string name) { }

	// RVA: 0x1445AB0 Offset: 0x14440B0 VA: 0x181445AB0 Slot: 14
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1444FC0 Offset: 0x14435C0 VA: 0x181444FC0 Slot: 15
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1445020 Offset: 0x1443620 VA: 0x181445020 Slot: 16
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1445720 Offset: 0x1443D20 VA: 0x181445720 Slot: 24
	internal override Module[] GetModulesInternal() { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1444EA0 Offset: 0x14434A0 VA: 0x181444EA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1445CE0 Offset: 0x14442E0 VA: 0x181445CE0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
internal struct MonoEventInfo // TypeDefIndex: 1292
{
	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38
}

// Namespace: System.Reflection
[Serializable]
internal sealed class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 1293
{
	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x1447240 Offset: 0x1445840 VA: 0x181447240
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	// RVA: 0x1446D60 Offset: 0x1445360 VA: 0x181446D60
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	// RVA: 0x1446FE0 Offset: 0x14455E0 VA: 0x181446FE0 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1446AA0 Offset: 0x14450A0 VA: 0x181446AA0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1446CD0 Offset: 0x14452D0 VA: 0x181446CD0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x1447180 Offset: 0x1445780 VA: 0x181447180
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1446FE0 Offset: 0x14455E0 VA: 0x181446FE0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1446DA0 Offset: 0x14453A0 VA: 0x181446DA0 Slot: 22
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1446AA0 Offset: 0x14450A0 VA: 0x181446AA0
	internal BindingFlags GetBindingFlags() { }

	// RVA: 0x1446A20 Offset: 0x1445020 VA: 0x181446A20 Slot: 18
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x1446EE0 Offset: 0x14454E0 VA: 0x181446EE0 Slot: 20
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x1446F60 Offset: 0x1445560 VA: 0x181446F60 Slot: 19
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x1447120 Offset: 0x1445720 VA: 0x181447120 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1447210 Offset: 0x1445810 VA: 0x181447210 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1447150 Offset: 0x1445750 VA: 0x181447150 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1447080 Offset: 0x1445680 VA: 0x181447080 Slot: 3
	public override string ToString() { }

	// RVA: 0x1447010 Offset: 0x1445610 VA: 0x181447010 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1446C70 Offset: 0x1445270 VA: 0x181446C70 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1446C00 Offset: 0x1445200 VA: 0x181446C00 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.Reflection
internal abstract class RtFieldInfo : FieldInfo // TypeDefIndex: 1294
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract object UnsafeGetValue(object obj);

	// RVA: -1 Offset: -1 Slot: 33
	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 34
	internal abstract void CheckConsistency(object target);

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	protected void .ctor() { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeFieldInfo : RtFieldInfo, ISerializable // TypeDefIndex: 1295
{
	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x14477B0 Offset: 0x1445DB0 VA: 0x1814477B0 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1447580 Offset: 0x1445B80 VA: 0x181447580
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x1448050 Offset: 0x1446650 VA: 0x181448050
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x14477B0 Offset: 0x1445DB0 VA: 0x1814477B0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1447620 Offset: 0x1445C20 VA: 0x181447620 Slot: 35
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1447840 Offset: 0x1445E40 VA: 0x181447840 Slot: 32
	internal override object UnsafeGetValue(object obj) { }

	// RVA: 0x1447250 Offset: 0x1445850 VA: 0x181447250 Slot: 34
	internal override void CheckConsistency(object target) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1447F70 Offset: 0x1446570 VA: 0x181447F70 Slot: 33
	internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1447A80 Offset: 0x1446080 VA: 0x181447A80 Slot: 29
	public override void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 25
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x1447A70 Offset: 0x1446070 VA: 0x181447A70
	private Type ResolveType() { }

	// RVA: 0x1447FF0 Offset: 0x14465F0 VA: 0x181447FF0 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x1447790 Offset: 0x1445D90 VA: 0x181447790
	private Type GetParentType(bool declaring) { }

	// RVA: 0x14480E0 Offset: 0x14466E0 VA: 0x1814480E0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1447FE0 Offset: 0x14465E0 VA: 0x181447FE0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1447A00 Offset: 0x1446000 VA: 0x181447A00 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x14474B0 Offset: 0x1445AB0 VA: 0x1814474B0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1447510 Offset: 0x1445B10 VA: 0x181447510 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1447610 Offset: 0x1445C10 VA: 0x181447610 Slot: 31
	internal override int GetFieldOffset() { }

	// RVA: 0x1447840 Offset: 0x1445E40 VA: 0x181447840
	private object GetValueInternal(object obj) { }

	// RVA: 0x1447850 Offset: 0x1445E50 VA: 0x181447850 Slot: 26
	public override object GetValue(object obj) { }

	// RVA: 0x1447F10 Offset: 0x1446510 VA: 0x181447F10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1447C20 Offset: 0x1446220 VA: 0x181447C20
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x1447C30 Offset: 0x1446230 VA: 0x181447C30 Slot: 28
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x14477A0 Offset: 0x1445DA0 VA: 0x1814477A0 Slot: 30
	public override object GetRawConstantValue() { }

	// RVA: 0x1447410 Offset: 0x1445A10 VA: 0x181447410
	private void CheckGeneric() { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.Reflection
internal struct MonoMethodInfo // TypeDefIndex: 1296
{
	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x1443C60 Offset: 0x1442260 VA: 0x181443C60
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x1443A60 Offset: 0x1442060 VA: 0x181443A60
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x1443B00 Offset: 0x1442100 VA: 0x181443B00
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x1443AA0 Offset: 0x14420A0 VA: 0x181443AA0
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x1443C30 Offset: 0x1442230 VA: 0x181443C30
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x1443A60 Offset: 0x1442060 VA: 0x181443A60
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x1443A70 Offset: 0x1442070 VA: 0x181443A70
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x1443AD0 Offset: 0x14420D0 VA: 0x181443AD0
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x1443B30 Offset: 0x1442130 VA: 0x181443B30
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x1443B30 Offset: 0x1442130 VA: 0x181443B30
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	// RVA: 0x13D4F00 Offset: 0x13D3500 VA: 0x1813D4F00
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	// RVA: 0x1443B40 Offset: 0x1442140 VA: 0x181443B40
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 1297
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override ParameterInfo ReturnParameter { get; }
	public override Type ReturnType { get; }
	public override int MetadataToken { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1449980 Offset: 0x1447F80 VA: 0x181449980 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x144A310 Offset: 0x1448910 VA: 0x18144A310
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1448480 Offset: 0x1446A80 VA: 0x181448480 Slot: 37
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x1448440 Offset: 0x1446A40 VA: 0x181448440 Slot: 45
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x1448460 Offset: 0x1446A60 VA: 0x181448460 Slot: 46
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x144A170 Offset: 0x1448770 VA: 0x18144A170 Slot: 3
	public override string ToString() { }

	// RVA: 0x1449980 Offset: 0x1447F80 VA: 0x181449980
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1449310 Offset: 0x1447910 VA: 0x181449310 Slot: 48
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x144A0D0 Offset: 0x14486D0 VA: 0x18144A0D0
	internal string SerializationToString() { }

	// RVA: 0x14492F0 Offset: 0x14478F0 VA: 0x1814492F0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x1449300 Offset: 0x1447900 VA: 0x181449300
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x14492D0 Offset: 0x14478D0 VA: 0x1814492D0
	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x14492E0 Offset: 0x14478E0 VA: 0x1814492E0
	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x144A3E0 Offset: 0x14489E0 VA: 0x18144A3E0
	internal static string get_name(MethodBase method) { }

	// RVA: 0x144A3D0 Offset: 0x14489D0 VA: 0x18144A3D0
	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970
	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	// RVA: 0x1448600 Offset: 0x1446C00 VA: 0x181448600 Slot: 44
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x1448610 Offset: 0x1446C10 VA: 0x181448610
	internal MethodInfo GetBaseMethod() { }

	// RVA: 0x1443B40 Offset: 0x1442140 VA: 0x181443B40 Slot: 40
	public override ParameterInfo get_ReturnParameter() { }

	// RVA: 0x144A3A0 Offset: 0x14489A0 VA: 0x18144A3A0 Slot: 41
	public override Type get_ReturnType() { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1446100 Offset: 0x1444700 VA: 0x181446100 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x1449530 Offset: 0x1447B30 VA: 0x181449530 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x14462E0 Offset: 0x14448E0 VA: 0x1814462E0 Slot: 35
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x1449500 Offset: 0x1447B00 VA: 0x181449500 Slot: 36
	internal override int GetParametersCount() { }

	// RVA: 0x1449A10 Offset: 0x1448010 VA: 0x181449A10
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1449A20 Offset: 0x1448020 VA: 0x181449A20 Slot: 32
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x14480F0 Offset: 0x14466F0 VA: 0x1814480F0
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 33
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x14468C0 Offset: 0x1444EC0 VA: 0x1814468C0 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x14468D0 Offset: 0x1444ED0 VA: 0x1814468D0 Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1446940 Offset: 0x1444F40 VA: 0x181446940 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1446980 Offset: 0x1444F80 VA: 0x181446980 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1449CF0 Offset: 0x14482F0 VA: 0x181449CF0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1448690 Offset: 0x1446C90 VA: 0x181448690 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1448620 Offset: 0x1446C20 VA: 0x181448620 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x14494F0 Offset: 0x1447AF0 VA: 0x1814494F0
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x14497D0 Offset: 0x1447DD0 VA: 0x1814497D0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x14495C0 Offset: 0x1447BC0 VA: 0x1814495C0
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x14486F0 Offset: 0x1446CF0 VA: 0x1814486F0
	private CustomAttributeData GetDllImportAttributeData() { }

	// RVA: 0x1449D70 Offset: 0x1448370 VA: 0x181449D70 Slot: 43
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x1449D60 Offset: 0x1448360 VA: 0x181449D60
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x1449250 Offset: 0x1447850 VA: 0x181449250 Slot: 29
	public override Type[] GetGenericArguments() { }

	// RVA: 0x1449260 Offset: 0x1447860 VA: 0x181449260
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x1449270 Offset: 0x1447870 VA: 0x181449270 Slot: 42
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x144A2F0 Offset: 0x14488F0 VA: 0x18144A2F0 Slot: 28
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x144A300 Offset: 0x1448900 VA: 0x18144A300 Slot: 27
	public override bool get_IsGenericMethod() { }

	// RVA: 0x144A200 Offset: 0x1448800 VA: 0x18144A200 Slot: 30
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	private static int get_core_clr_security_level() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 34
	public override bool get_IsSecurityCritical() { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 1298
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x14462F0 Offset: 0x14448F0 VA: 0x1814462F0 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x14462F0 Offset: 0x14448F0 VA: 0x1814462F0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1446990 Offset: 0x1444F90 VA: 0x181446990
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1446130 Offset: 0x1444730 VA: 0x181446130 Slot: 41
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14467F0 Offset: 0x1444DF0 VA: 0x1814467F0
	internal string SerializationToString() { }

	// RVA: 0x1446680 Offset: 0x1444C80 VA: 0x181446680
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1446100 Offset: 0x1444700 VA: 0x181446100 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x14462E0 Offset: 0x14448E0 VA: 0x1814462E0 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x14462E0 Offset: 0x14448E0 VA: 0x1814462E0 Slot: 35
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x14462B0 Offset: 0x14448B0 VA: 0x1814462B0 Slot: 36
	internal override int GetParametersCount() { }

	// RVA: 0x1446390 Offset: 0x1444990 VA: 0x181446390
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x14464C0 Offset: 0x1444AC0 VA: 0x1814464C0 Slot: 32
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x1445DF0 Offset: 0x14443F0 VA: 0x181445DF0
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x14463A0 Offset: 0x14449A0 VA: 0x1814463A0
	public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1446490 Offset: 0x1444A90 VA: 0x181446490 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 33
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x14468C0 Offset: 0x1444EC0 VA: 0x1814468C0 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x14468D0 Offset: 0x1444ED0 VA: 0x1814468D0 Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x1446900 Offset: 0x1444F00 VA: 0x181446900 Slot: 30
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1446940 Offset: 0x1444F40 VA: 0x181446940 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1446980 Offset: 0x1444F80 VA: 0x181446980 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1446610 Offset: 0x1444C10 VA: 0x181446610 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1446030 Offset: 0x1444630 VA: 0x181446030 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1446090 Offset: 0x1444690 VA: 0x181446090 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1446810 Offset: 0x1444E10 VA: 0x181446810 Slot: 3
	public override string ToString() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	private static int get_core_clr_security_level() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 34
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970
	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	// RVA: 0x1446870 Offset: 0x1444E70 VA: 0x181446870
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[ClassInterface(0)]
[ComDefaultInterface(typeof(_Module))]
[Serializable]
internal class RuntimeModule : Module // TypeDefIndex: 1299
{
	// Fields
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C

	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	public override Assembly get_Assembly() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 10
	public override string get_ScopeName() { }

	// RVA: 0x144A790 Offset: 0x1448D90 VA: 0x18144A790 Slot: 9
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630 Slot: 11
	public override bool IsResource() { }

	// RVA: 0x144A460 Offset: 0x1448A60 VA: 0x18144A460 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x144A3F0 Offset: 0x14489F0 VA: 0x18144A3F0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x144A6D0 Offset: 0x1448CD0 VA: 0x18144A6D0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x144A550 Offset: 0x1448B50 VA: 0x18144A550 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x144A660 Offset: 0x1448C60 VA: 0x18144A660
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x144A4D0 Offset: 0x1448AD0 VA: 0x18144A4D0 Slot: 16
	internal override Guid GetModuleVersionId() { }

	// RVA: 0x144A4C0 Offset: 0x1448AC0 VA: 0x18144A4C0
	private static void GetGuidInternal(IntPtr module, byte[] guid) { }

	// RVA: 0x144A740 Offset: 0x1448D40 VA: 0x18144A740
	public void .ctor() { }
}

// Namespace: System.Reflection
[ClassInterface(0)]
[ComDefaultInterface(typeof(_ParameterInfo))]
[ComVisible(True)]
[Serializable]
internal class RuntimeParameterInfo : ParameterInfo // TypeDefIndex: 1300
{
	// Fields
	internal MarshalAsAttribute marshalAs; // 0x40

	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x144B610 Offset: 0x1449C10 VA: 0x18144B610
	internal void .ctor(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x144A7C0 Offset: 0x1448DC0 VA: 0x18144A7C0
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x144B740 Offset: 0x1449D40 VA: 0x18144B740
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x144B6B0 Offset: 0x1449CB0 VA: 0x18144B6B0
	internal void .ctor(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x144B8C0 Offset: 0x1449EC0 VA: 0x18144B8C0 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x144AA20 Offset: 0x1449020 VA: 0x18144AA20 Slot: 15
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x144A9C0 Offset: 0x1448FC0 VA: 0x18144A9C0 Slot: 16
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x144AA70 Offset: 0x1449070 VA: 0x18144AA70
	internal object GetDefaultValueImpl(ParameterInfo pinfo) { }

	// RVA: 0x144B470 Offset: 0x1449A70 VA: 0x18144B470 Slot: 14
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x144B150 Offset: 0x1449750 VA: 0x18144B150
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x144AB30 Offset: 0x1449130 VA: 0x18144AB30
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x144B4E0 Offset: 0x1449AE0 VA: 0x18144B4E0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x144B550 Offset: 0x1449B50 VA: 0x18144B550
	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }
}

// Namespace: System.Reflection
internal struct MonoPropertyInfo // TypeDefIndex: 1301
{
	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28
}

// Namespace: System.Reflection
[Flags]
internal enum PInfo // TypeDefIndex: 1302
{
	// Fields
	public int value__; // 0x0
	public const PInfo Attributes = 1;
	public const PInfo GetMethod = 2;
	public const PInfo SetMethod = 4;
	public const PInfo ReflectedType = 8;
	public const PInfo DeclaringType = 16;
	public const PInfo Name = 32;
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 1306
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private RuntimePropertyInfo.GetterAdapter cached_getter; // 0x58

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x144CD00 Offset: 0x144B300 VA: 0x18144CD00
	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x144C4F0 Offset: 0x144AAF0 VA: 0x18144C4F0 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x144BFC0 Offset: 0x144A5C0 VA: 0x18144BFC0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x144CC30 Offset: 0x144B230 VA: 0x18144CC30
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x144C4F0 Offset: 0x144AAF0 VA: 0x18144C4F0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x144CA50 Offset: 0x144B050 VA: 0x18144CA50 Slot: 3
	public override string ToString() { }

	// RVA: 0x144BC20 Offset: 0x144A220 VA: 0x18144BC20
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x144C2D0 Offset: 0x144A8D0 VA: 0x18144C2D0 Slot: 31
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x144C800 Offset: 0x144AE00 VA: 0x18144C800
	internal string SerializationToString() { }

	// RVA: 0x144BBE0 Offset: 0x144A1E0 VA: 0x18144BBE0
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x144CA60 Offset: 0x144B060 VA: 0x18144CA60 Slot: 18
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x144CAA0 Offset: 0x144B0A0 VA: 0x18144CAA0 Slot: 20
	public override bool get_CanRead() { }

	// RVA: 0x144CAD0 Offset: 0x144B0D0 VA: 0x18144CAD0 Slot: 21
	public override bool get_CanWrite() { }

	// RVA: 0x144CB80 Offset: 0x144B180 VA: 0x18144CB80 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x144CCC0 Offset: 0x144B2C0 VA: 0x18144CCC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x144CB00 Offset: 0x144B100 VA: 0x18144CB00 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x144CB40 Offset: 0x144B140 VA: 0x18144CB40 Slot: 8
	public override string get_Name() { }

	// RVA: 0x144C050 Offset: 0x144A650 VA: 0x18144C050 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x144C0C0 Offset: 0x144A6C0 VA: 0x18144C0C0 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x144C580 Offset: 0x144AB80 VA: 0x18144C580 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x144C7A0 Offset: 0x144ADA0 VA: 0x18144C7A0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x144BF10 Offset: 0x144A510 VA: 0x18144BF10 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x144BF60 Offset: 0x144A560 VA: 0x18144BF60 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x797E90 Offset: 0x796490 VA: 0x180797E90
	|-RuntimePropertyInfo.GetterAdapterFrame<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x797FC0 Offset: 0x7965C0 VA: 0x180797FC0
	|-RuntimePropertyInfo.StaticGetterAdapterFrame<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1444980 Offset: 0x1442F80 VA: 0x181444980 Slot: 27
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x144C5F0 Offset: 0x144ABF0 VA: 0x18144C5F0 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x144C810 Offset: 0x144AE10 VA: 0x18144C810 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1446970 Offset: 0x1444F70 VA: 0x181446970
	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	// RVA: 0x144CD10 Offset: 0x144B310 VA: 0x18144CD10
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x144C440 Offset: 0x144AA40 VA: 0x18144C440
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 1307
{
	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x144F9A0 Offset: 0x144DFA0 VA: 0x18144F9A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x144F870 Offset: 0x144DE70 VA: 0x18144F870 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}

