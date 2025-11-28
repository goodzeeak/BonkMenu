// Namespace: System.Reflection.Emit
public class AssemblyBuilder : Assembly // TypeDefIndex: 1308
{}

// Namespace: System.Reflection.Emit
public class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 1309
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x1434300 Offset: 0x1432900 VA: 0x181434300 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x1434340 Offset: 0x1432940 VA: 0x181434340 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x14343C0 Offset: 0x14329C0 VA: 0x1814343C0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1434200 Offset: 0x1432800 VA: 0x181434200 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x14341C0 Offset: 0x14327C0 VA: 0x1814341C0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x1434380 Offset: 0x1432980 VA: 0x181434380 Slot: 33
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x1434280 Offset: 0x1432880 VA: 0x181434280 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x14342C0 Offset: 0x14328C0 VA: 0x1814342C0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1434140 Offset: 0x1432740 VA: 0x181434140 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1434180 Offset: 0x1432780 VA: 0x181434180 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1434400 Offset: 0x1432A00 VA: 0x181434400 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1434240 Offset: 0x1432840 VA: 0x181434240 Slot: 32
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public sealed class DynamicMethod : MethodInfo // TypeDefIndex: 1310
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x143F0D0 Offset: 0x143D6D0 VA: 0x18143F0D0 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x143F110 Offset: 0x143D710 VA: 0x18143F110 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x143F190 Offset: 0x143D790 VA: 0x18143F190 Slot: 8
	public override string get_Name() { }

	// RVA: 0x143F010 Offset: 0x143D610 VA: 0x18143F010 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x143F150 Offset: 0x143D750 VA: 0x18143F150 Slot: 33
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x143F1D0 Offset: 0x143D7D0 VA: 0x18143F1D0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x143EF90 Offset: 0x143D590 VA: 0x18143EF90 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x143EF50 Offset: 0x143D550 VA: 0x18143EF50 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x143EFD0 Offset: 0x143D5D0 VA: 0x18143EFD0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x143EF10 Offset: 0x143D510 VA: 0x18143EF10 Slot: 44
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x143F050 Offset: 0x143D650 VA: 0x18143F050 Slot: 32
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x143F090 Offset: 0x143D690 VA: 0x18143F090 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection.Emit
public sealed class EnumBuilder : TypeInfo // TypeDefIndex: 1311
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x143F890 Offset: 0x143DE90 VA: 0x18143F890 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x143F850 Offset: 0x143DE50 VA: 0x18143F850 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x143F8D0 Offset: 0x143DED0 VA: 0x18143F8D0 Slot: 118
	public override Type get_BaseType() { }

	// RVA: 0x143F910 Offset: 0x143DF10 VA: 0x18143F910 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x143F950 Offset: 0x143DF50 VA: 0x18143F950 Slot: 117
	public override Guid get_GUID() { }

	// RVA: 0x143F990 Offset: 0x143DF90 VA: 0x18143F990 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x143F9D0 Offset: 0x143DFD0 VA: 0x18143F9D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x143FA10 Offset: 0x143E010 VA: 0x18143FA10 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x143FA50 Offset: 0x143E050 VA: 0x18143FA50 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x143F210 Offset: 0x143D810 VA: 0x18143F210 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x143F250 Offset: 0x143D850 VA: 0x18143F250 Slot: 82
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x143F290 Offset: 0x143D890 VA: 0x18143F290 Slot: 84
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x143F310 Offset: 0x143D910 VA: 0x18143F310 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x143F2D0 Offset: 0x143D8D0 VA: 0x18143F2D0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x143F350 Offset: 0x143D950 VA: 0x18143F350 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x143F390 Offset: 0x143D990 VA: 0x18143F390 Slot: 86
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x143F3D0 Offset: 0x143D9D0 VA: 0x18143F3D0 Slot: 87
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x143F410 Offset: 0x143DA10 VA: 0x18143F410 Slot: 89
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x143F450 Offset: 0x143DA50 VA: 0x18143F450 Slot: 91
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x143F490 Offset: 0x143DA90 VA: 0x18143F490 Slot: 121
	public override Type[] GetInterfaces() { }

	// RVA: 0x143F4D0 Offset: 0x143DAD0 VA: 0x18143F4D0 Slot: 95
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x143F510 Offset: 0x143DB10 VA: 0x18143F510 Slot: 102
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x143F550 Offset: 0x143DB50 VA: 0x18143F550 Slot: 104
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x143F590 Offset: 0x143DB90 VA: 0x18143F590 Slot: 105
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x143F5D0 Offset: 0x143DBD0 VA: 0x18143F5D0 Slot: 114
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x143F610 Offset: 0x143DC10 VA: 0x18143F610 Slot: 112
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x143F650 Offset: 0x143DC50 VA: 0x18143F650 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x143F690 Offset: 0x143DC90 VA: 0x18143F690 Slot: 120
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x143F6D0 Offset: 0x143DCD0 VA: 0x18143F6D0 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x143F710 Offset: 0x143DD10 VA: 0x18143F710 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x143F750 Offset: 0x143DD50 VA: 0x18143F750 Slot: 67
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x143F790 Offset: 0x143DD90 VA: 0x18143F790 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x143F7D0 Offset: 0x143DDD0 VA: 0x18143F7D0 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x143F810 Offset: 0x143DE10 VA: 0x18143F810 Slot: 75
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
public class EventBuilder // TypeDefIndex: 1312
{}

// Namespace: System.Reflection.Emit
public sealed class FieldBuilder : FieldInfo // TypeDefIndex: 1313
{
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 25
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 26
	public override object GetValue(object obj) { }

	// RVA: 0x143FDA0 Offset: 0x143E3A0 VA: 0x18143FDA0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x143FDB0 Offset: 0x143E3B0 VA: 0x18143FDB0 Slot: 28
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public sealed class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 1314
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x1440470 Offset: 0x143EA70 VA: 0x181440470 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x1440430 Offset: 0x143EA30 VA: 0x181440430 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x14404B0 Offset: 0x143EAB0 VA: 0x1814404B0 Slot: 118
	public override Type get_BaseType() { }

	// RVA: 0x14404F0 Offset: 0x143EAF0 VA: 0x1814404F0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x1440530 Offset: 0x143EB30 VA: 0x181440530 Slot: 117
	public override Guid get_GUID() { }

	// RVA: 0x1440570 Offset: 0x143EB70 VA: 0x181440570 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x14405B0 Offset: 0x143EBB0 VA: 0x1814405B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x14405F0 Offset: 0x143EBF0 VA: 0x1814405F0 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x1440630 Offset: 0x143EC30 VA: 0x181440630 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x143FDF0 Offset: 0x143E3F0 VA: 0x18143FDF0 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x143FE30 Offset: 0x143E430 VA: 0x18143FE30 Slot: 82
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x143FE70 Offset: 0x143E470 VA: 0x18143FE70 Slot: 84
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x143FEF0 Offset: 0x143E4F0 VA: 0x18143FEF0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x143FEB0 Offset: 0x143E4B0 VA: 0x18143FEB0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x143FF30 Offset: 0x143E530 VA: 0x18143FF30 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x143FF70 Offset: 0x143E570 VA: 0x18143FF70 Slot: 86
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x143FFB0 Offset: 0x143E5B0 VA: 0x18143FFB0 Slot: 87
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x143FFF0 Offset: 0x143E5F0 VA: 0x18143FFF0 Slot: 89
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1440030 Offset: 0x143E630 VA: 0x181440030 Slot: 91
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1440070 Offset: 0x143E670 VA: 0x181440070 Slot: 121
	public override Type[] GetInterfaces() { }

	// RVA: 0x14400B0 Offset: 0x143E6B0 VA: 0x1814400B0 Slot: 95
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x14400F0 Offset: 0x143E6F0 VA: 0x1814400F0 Slot: 102
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1440130 Offset: 0x143E730 VA: 0x181440130 Slot: 104
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x1440170 Offset: 0x143E770 VA: 0x181440170 Slot: 105
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x14401B0 Offset: 0x143E7B0 VA: 0x1814401B0 Slot: 114
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x14401F0 Offset: 0x143E7F0 VA: 0x1814401F0 Slot: 112
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1440230 Offset: 0x143E830 VA: 0x181440230 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1440270 Offset: 0x143E870 VA: 0x181440270 Slot: 120
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x14402B0 Offset: 0x143E8B0 VA: 0x1814402B0 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x14402F0 Offset: 0x143E8F0 VA: 0x1814402F0 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x1440330 Offset: 0x143E930 VA: 0x181440330 Slot: 67
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1440370 Offset: 0x143E970 VA: 0x181440370 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x14403B0 Offset: 0x143E9B0 VA: 0x1814403B0 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x14403F0 Offset: 0x143E9F0 VA: 0x1814403F0 Slot: 75
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
public class ILGenerator // TypeDefIndex: 1315
{}

// Namespace: System.Reflection.Emit
public sealed class LocalBuilder : LocalVariableInfo // TypeDefIndex: 1316
{
	// Fields
	private string name; // 0x20
	internal ILGenerator ilgen; // 0x28
	private int startOffset; // 0x30
	private int endOffset; // 0x34
}

// Namespace: System.Reflection.Emit
public sealed class MethodBuilder : MethodInfo // TypeDefIndex: 1317
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x1443080 Offset: 0x1441680 VA: 0x181443080 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x14430C0 Offset: 0x14416C0 VA: 0x1814430C0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1443100 Offset: 0x1441700 VA: 0x181443100 Slot: 33
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x1443140 Offset: 0x1441740 VA: 0x181443140 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1443180 Offset: 0x1441780 VA: 0x181443180 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1442EC0 Offset: 0x14414C0 VA: 0x181442EC0 Slot: 44
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x1442F00 Offset: 0x1441500 VA: 0x181442F00 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1442F40 Offset: 0x1441540 VA: 0x181442F40 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1442F80 Offset: 0x1441580 VA: 0x181442F80 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x1442FC0 Offset: 0x14415C0 VA: 0x181442FC0 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x1443000 Offset: 0x1441600 VA: 0x181443000 Slot: 32
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x1443040 Offset: 0x1441640 VA: 0x181443040 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection.Emit
public class ModuleBuilder : Module // TypeDefIndex: 1318
{}

// Namespace: System.Reflection.Emit
public class ParameterBuilder // TypeDefIndex: 1319
{}

// Namespace: System.Reflection.Emit
public sealed class PropertyBuilder : PropertyInfo // TypeDefIndex: 1320
{
	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x1444760 Offset: 0x1442D60 VA: 0x181444760 Slot: 18
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x14447A0 Offset: 0x1442DA0 VA: 0x1814447A0 Slot: 20
	public override bool get_CanRead() { }

	// RVA: 0x14447E0 Offset: 0x1442DE0 VA: 0x1814447E0 Slot: 21
	public override bool get_CanWrite() { }

	// RVA: 0x1444820 Offset: 0x1442E20 VA: 0x181444820 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1444860 Offset: 0x1442E60 VA: 0x181444860 Slot: 8
	public override string get_Name() { }

	// RVA: 0x14448A0 Offset: 0x1442EA0 VA: 0x1814448A0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x14448E0 Offset: 0x1442EE0 VA: 0x1814448E0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x14445A0 Offset: 0x1442BA0 VA: 0x1814445A0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1444560 Offset: 0x1442B60 VA: 0x181444560 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x14445E0 Offset: 0x1442BE0 VA: 0x1814445E0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x1444620 Offset: 0x1442C20 VA: 0x181444620 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x1444660 Offset: 0x1442C60 VA: 0x181444660 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x14446A0 Offset: 0x1442CA0 VA: 0x1814446A0 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x14446E0 Offset: 0x1442CE0 VA: 0x1814446E0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1444720 Offset: 0x1442D20 VA: 0x181444720 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public class SignatureHelper // TypeDefIndex: 1321
{}

// Namespace: System.Reflection.Emit
public sealed class TypeBuilder : TypeInfo // TypeDefIndex: 1322
{
	// Fields
	public const int UnspecifiedTypeSize = 0;

	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x14503A0 Offset: 0x144E9A0 VA: 0x1814503A0 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x1450360 Offset: 0x144E960 VA: 0x181450360 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x14503E0 Offset: 0x144E9E0 VA: 0x1814503E0 Slot: 118
	public override Type get_BaseType() { }

	// RVA: 0x1450420 Offset: 0x144EA20 VA: 0x181450420 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x1450460 Offset: 0x144EA60 VA: 0x181450460 Slot: 117
	public override Guid get_GUID() { }

	// RVA: 0x14504A0 Offset: 0x144EAA0 VA: 0x1814504A0 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x14504E0 Offset: 0x144EAE0 VA: 0x1814504E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1450520 Offset: 0x144EB20 VA: 0x181450520 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x1450560 Offset: 0x144EB60 VA: 0x181450560 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x144FD20 Offset: 0x144E320 VA: 0x18144FD20 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x144FD60 Offset: 0x144E360 VA: 0x18144FD60 Slot: 82
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x144FDA0 Offset: 0x144E3A0 VA: 0x18144FDA0 Slot: 84
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x144FDE0 Offset: 0x144E3E0 VA: 0x18144FDE0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x144FE20 Offset: 0x144E420 VA: 0x18144FE20 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x144FE60 Offset: 0x144E460 VA: 0x18144FE60 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x144FEA0 Offset: 0x144E4A0 VA: 0x18144FEA0 Slot: 86
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x144FEE0 Offset: 0x144E4E0 VA: 0x18144FEE0 Slot: 87
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x144FF20 Offset: 0x144E520 VA: 0x18144FF20 Slot: 89
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x144FF60 Offset: 0x144E560 VA: 0x18144FF60 Slot: 91
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x144FFA0 Offset: 0x144E5A0 VA: 0x18144FFA0 Slot: 121
	public override Type[] GetInterfaces() { }

	// RVA: 0x144FFE0 Offset: 0x144E5E0 VA: 0x18144FFE0 Slot: 95
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1450020 Offset: 0x144E620 VA: 0x181450020 Slot: 102
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1450060 Offset: 0x144E660 VA: 0x181450060 Slot: 104
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x14500A0 Offset: 0x144E6A0 VA: 0x1814500A0 Slot: 105
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x14500E0 Offset: 0x144E6E0 VA: 0x1814500E0 Slot: 114
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1450120 Offset: 0x144E720 VA: 0x181450120 Slot: 112
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1450160 Offset: 0x144E760 VA: 0x181450160 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x14501A0 Offset: 0x144E7A0 VA: 0x1814501A0 Slot: 120
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x14501E0 Offset: 0x144E7E0 VA: 0x1814501E0 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x1450220 Offset: 0x144E820 VA: 0x181450220 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x1450260 Offset: 0x144E860 VA: 0x181450260 Slot: 67
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x14502A0 Offset: 0x144E8A0 VA: 0x1814502A0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x14502E0 Offset: 0x144E8E0 VA: 0x1814502E0 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x1450320 Offset: 0x144E920 VA: 0x181450320 Slot: 75
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
[ComVisible(True)]
[Serializable]
public sealed class UnmanagedMarshal // TypeDefIndex: 1323
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }
}

