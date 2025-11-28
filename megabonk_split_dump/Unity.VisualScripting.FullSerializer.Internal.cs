// Namespace: Unity.VisualScripting.FullSerializer.Internal
public class fsCyclicReferenceManager // TypeDefIndex: 9382
{
	// Fields
	private Dictionary<object, int> _objectIds; // 0x10
	private int _nextId; // 0x18
	private Dictionary<int, object> _marked; // 0x20
	private int _depth; // 0x28

	// Methods

	// RVA: 0xA5BAA0 Offset: 0xA5A0A0 VA: 0x180A5BAA0
	public void Enter() { }

	// RVA: 0x22CEC50 Offset: 0x22CD250 VA: 0x1822CEC50
	public bool Exit() { }

	// RVA: 0x22CEE60 Offset: 0x22CD460 VA: 0x1822CEE60
	public object GetReferenceObject(int id) { }

	// RVA: 0x22CEBE0 Offset: 0x22CD1E0 VA: 0x1822CEBE0
	public void AddReferenceWithId(int id, object reference) { }

	// RVA: 0x22CEDC0 Offset: 0x22CD3C0 VA: 0x1822CEDC0
	public int GetReferenceId(object item) { }

	// RVA: 0x22CEF60 Offset: 0x22CD560 VA: 0x1822CEF60
	public bool IsReference(object item) { }

	// RVA: 0x22CEFD0 Offset: 0x22CD5D0 VA: 0x1822CEFD0
	public void MarkSerialized(object item) { }

	// RVA: 0x22CF100 Offset: 0x22CD700 VA: 0x1822CF100
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer.Internal
public struct fsOption<T> // TypeDefIndex: 9383
{
	// Fields
	private bool _hasValue; // 0x0
	private T _value; // 0x0
	public static fsOption<T> Empty; // 0x0

	// Properties
	public bool HasValue { get; }
	public bool IsEmpty { get; }
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC08610 Offset: 0xC06C10 VA: 0x180C08610
	|-fsOption<__Il2CppFullySharedGenericType>.get_HasValue
	|
	|-RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	|-fsOption<fsVersionedType>.get_HasValue
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC08660 Offset: 0xC06C60 VA: 0x180C08660
	|-fsOption<__Il2CppFullySharedGenericType>.get_IsEmpty
	|
	|-RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0
	|-fsOption<fsVersionedType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC08750 Offset: 0xC06D50 VA: 0x180C08750
	|-fsOption<__Il2CppFullySharedGenericType>.get_Value
	|
	|-RVA: 0xC086C0 Offset: 0xC06CC0 VA: 0x180C086C0
	|-fsOption<fsVersionedType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC084C0 Offset: 0xC06AC0 VA: 0x180C084C0
	|-fsOption<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xC084A0 Offset: 0xC06AA0 VA: 0x180C084A0
	|-fsOption<fsVersionedType>..ctor
	*/
}

// Namespace: Unity.VisualScripting.FullSerializer.Internal
public static class fsOption // TypeDefIndex: 9384
{
	// Methods

	// RVA: -1 Offset: -1
	public static fsOption<T> Just<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x832A90 Offset: 0x831090 VA: 0x180832A90
	|-fsOption.Just<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x832BE0 Offset: 0x8311E0 VA: 0x180832BE0
	|-fsOption.Just<fsVersionedType>
	*/
}

// Namespace: Unity.VisualScripting.FullSerializer.Internal
[Extension]
public static class fsPortableReflection // TypeDefIndex: 9388
{
	// Fields
	public static Type[] EmptyTypes; // 0x0
	private static IDictionary<fsPortableReflection.AttributeQuery, Attribute> _cachedAttributeQueries; // 0x8
	private static BindingFlags DeclaredFlags; // 0x10

	// Methods

	// RVA: -1 Offset: -1
	public static bool HasAttribute<TAttribute>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x832F00 Offset: 0x831500 VA: 0x180832F00
	|-fsPortableReflection.HasAttribute<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool HasAttribute<TAttribute>(MemberInfo element, bool shouldCache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x832E60 Offset: 0x831460 VA: 0x180832E60
	|-fsPortableReflection.HasAttribute<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22D2AC0 Offset: 0x22D10C0 VA: 0x1822D2AC0
	public static bool HasAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x153B7E0 Offset: 0x1539DE0 VA: 0x18153B7E0
	public static bool HasAttribute(MemberInfo element, Type attributeType, bool shouldCache) { }

	// RVA: 0x22D1A70 Offset: 0x22D0070 VA: 0x1822D1A70
	public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache) { }

	// RVA: -1 Offset: -1
	public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x832D70 Offset: 0x831370 VA: 0x180832D70
	|-fsPortableReflection.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static TAttribute GetAttribute<TAttribute>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x832C50 Offset: 0x831250 VA: 0x180832C50
	|-fsPortableReflection.GetAttribute<object>
	*/

	[Extension]
	// RVA: 0x22D23A0 Offset: 0x22D09A0 VA: 0x1822D23A0
	public static PropertyInfo GetDeclaredProperty(Type type, string propertyName) { }

	[Extension]
	// RVA: 0x22D2170 Offset: 0x22D0770 VA: 0x1822D2170
	public static MethodInfo GetDeclaredMethod(Type type, string methodName) { }

	[Extension]
	// RVA: 0x22D1CF0 Offset: 0x22D02F0 VA: 0x1822D1CF0
	public static ConstructorInfo GetDeclaredConstructor(Type type, Type[] parameters) { }

	[Extension]
	// RVA: 0x22D1EC0 Offset: 0x22D04C0 VA: 0x1822D1EC0
	public static ConstructorInfo[] GetDeclaredConstructors(Type type) { }

	[Extension]
	// RVA: 0x22D24D0 Offset: 0x22D0AD0 VA: 0x1822D24D0
	public static MemberInfo[] GetFlattenedMember(Type type, string memberName) { }

	[Extension]
	// RVA: 0x22D26F0 Offset: 0x22D0CF0 VA: 0x1822D26F0
	public static MethodInfo GetFlattenedMethod(Type type, string methodName) { }

	[IteratorStateMachine(typeof(fsPortableReflection.<GetFlattenedMethods>d__18))]
	[Extension]
	// RVA: 0x22D2890 Offset: 0x22D0E90 VA: 0x1822D2890
	public static IEnumerable<MethodInfo> GetFlattenedMethods(Type type, string methodName) { }

	[Extension]
	// RVA: 0x22D2920 Offset: 0x22D0F20 VA: 0x1822D2920
	public static PropertyInfo GetFlattenedProperty(Type type, string propertyName) { }

	[Extension]
	// RVA: 0x22D1FC0 Offset: 0x22D05C0 VA: 0x1822D1FC0
	public static MemberInfo GetDeclaredMember(Type type, string memberName) { }

	[Extension]
	// RVA: 0x22D22A0 Offset: 0x22D08A0 VA: 0x1822D22A0
	public static MethodInfo[] GetDeclaredMethods(Type type) { }

	[Extension]
	// RVA: 0x22D2320 Offset: 0x22D0920 VA: 0x1822D2320
	public static PropertyInfo[] GetDeclaredProperties(Type type) { }

	[Extension]
	// RVA: 0x22D1F40 Offset: 0x22D0540 VA: 0x1822D1F40
	public static FieldInfo[] GetDeclaredFields(Type type) { }

	[Extension]
	// RVA: 0x22D20F0 Offset: 0x22D06F0 VA: 0x1822D20F0
	public static MemberInfo[] GetDeclaredMembers(Type type) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static MemberInfo AsMemberInfo(Type type) { }

	// RVA: 0x22D2B20 Offset: 0x22D1120 VA: 0x1822D2B20
	public static bool IsType(MemberInfo member) { }

	// RVA: 0x22D1A20 Offset: 0x22D0020 VA: 0x1822D1A20
	public static Type AsType(MemberInfo member) { }

	[Extension]
	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static Type Resolve(Type type) { }

	// RVA: 0x22D2B80 Offset: 0x22D1180 VA: 0x1822D2B80
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer.Internal
[Extension]
public static class fsTypeExtensions // TypeDefIndex: 9390
{
	// Methods

	[Extension]
	// RVA: 0x22D3540 Offset: 0x22D1B40 VA: 0x1822D3540
	public static string CSharpName(Type type) { }

	[Extension]
	// RVA: 0x22D2F10 Offset: 0x22D1510 VA: 0x1822D2F10
	public static string CSharpName(Type type, bool includeNamespace, bool ensureSafeDeclarationName) { }

	[Extension]
	// RVA: 0x22D2F90 Offset: 0x22D1590 VA: 0x1822D2F90
	public static string CSharpName(Type type, bool includeNamespace) { }
}

// Namespace: Unity.VisualScripting.FullSerializer.Internal
public struct fsVersionedType // TypeDefIndex: 9391
{
	// Fields
	public fsVersionedType[] Ancestors; // 0x0
	public string VersionString; // 0x8
	public Type ModelType; // 0x10

	// Methods

	// RVA: 0x22D4510 Offset: 0x22D2B10 VA: 0x1822D4510
	public object Migrate(object ancestorInstance) { }

	// RVA: 0x22D45D0 Offset: 0x22D2BD0 VA: 0x1822D45D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22D4760 Offset: 0x22D2D60 VA: 0x1822D4760
	public static bool op_Equality(fsVersionedType a, fsVersionedType b) { }

	// RVA: 0x22D47A0 Offset: 0x22D2DA0 VA: 0x1822D47A0
	public static bool op_Inequality(fsVersionedType a, fsVersionedType b) { }

	// RVA: 0x22D4460 Offset: 0x22D2A60 VA: 0x1822D4460 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Unity.VisualScripting.FullSerializer.Internal
public static class fsVersionManager // TypeDefIndex: 9392
{
	// Fields
	private static readonly Dictionary<Type, fsOption<fsVersionedType>> _cache; // 0x0

	// Methods

	// RVA: 0x22D36C0 Offset: 0x22D1CC0 VA: 0x1822D36C0
	public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path) { }

	// RVA: 0x22D3550 Offset: 0x22D1B50 VA: 0x1822D3550
	private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current) { }

	// RVA: 0x22D39C0 Offset: 0x22D1FC0 VA: 0x1822D39C0
	public static fsOption<fsVersionedType> GetVersionedType(Type type) { }

	// RVA: 0x22D3EC0 Offset: 0x22D24C0 VA: 0x1822D3EC0
	private static void VerifyConstructors(fsVersionedType type) { }

	// RVA: 0x22D4120 Offset: 0x22D2720 VA: 0x1822D4120
	private static void VerifyUniqueVersionStrings(fsVersionedType type) { }

	// RVA: 0x22D43D0 Offset: 0x22D29D0 VA: 0x1822D43D0
	private static void .cctor() { }
}

