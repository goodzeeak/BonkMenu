// Namespace: System.Dynamic.Utils
[DefaultMember("Item")]
internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 11325
{
	// Fields
	private readonly int _mask; // 0x0
	private readonly CacheDict.Entry<TKey, TValue>[] _entries; // 0x0

	// Properties
	internal TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CCF0 Offset: 0xC8B2F0 VA: 0x180C8CCF0
	|-CacheDict<object, object>..ctor
	|
	|-RVA: 0xC8CD90 Offset: 0xC8B390 VA: 0x180C8CD90
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static int AlignSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8C7D0 Offset: 0xC8ADD0 VA: 0x180C8C7D0
	|-CacheDict<object, object>.AlignSize
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AlignSize
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8C800 Offset: 0xC8AE00 VA: 0x180C8C800
	|-CacheDict<object, object>.TryGetValue
	|
	|-RVA: 0xC8C8D0 Offset: 0xC8AED0 VA: 0x180C8C8D0
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8C680 Offset: 0xC8AC80 VA: 0x180C8C680
	|-CacheDict<object, object>.Add
	|
	|-RVA: 0xC8C170 Offset: 0xC8A770 VA: 0x180C8C170
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8CE30 Offset: 0xC8B430 VA: 0x180C8CE30
	|-CacheDict<object, object>.set_Item
	|
	|-RVA: 0xC8CF90 Offset: 0xC8B590 VA: 0x180C8CF90
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class CollectionExtensions // TypeDefIndex: 11326
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TrueReadOnlyCollection<T> AddFirst<T>(ReadOnlyCollection<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B4930 Offset: 0x6B2F30 VA: 0x1806B4930
	|-CollectionExtensions.AddFirst<object>
	|
	|-RVA: 0x6B4790 Offset: 0x6B2D90 VA: 0x1806B4790
	|-CollectionExtensions.AddFirst<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] AddLast<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B4BA0 Offset: 0x6B31A0 VA: 0x1806B4BA0
	|-CollectionExtensions.AddLast<object>
	|
	|-RVA: 0x6B4A30 Offset: 0x6B3030 VA: 0x1806B4A30
	|-CollectionExtensions.AddLast<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveFirst<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B52F0 Offset: 0x6B38F0 VA: 0x1806B52F0
	|-CollectionExtensions.RemoveFirst<object>
	|-CollectionExtensions.RemoveFirst<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveLast<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B5390 Offset: 0x6B3990 VA: 0x1806B5390
	|-CollectionExtensions.RemoveLast<object>
	|-CollectionExtensions.RemoveLast<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ToReadOnly<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B5600 Offset: 0x6B3C00 VA: 0x1806B5600
	|-CollectionExtensions.ToReadOnly<object>
	|
	|-RVA: 0x6B5430 Offset: 0x6B3A30 VA: 0x1806B5430
	|-CollectionExtensions.ToReadOnly<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Dynamic.Utils
internal static class ContractUtils // TypeDefIndex: 11327
{
	// Properties
	[ExcludeFromCodeCoverage]
	public static Exception Unreachable { get; }

	// Methods

	// RVA: 0x1A66D20 Offset: 0x1A65320 VA: 0x181A66D20
	public static Exception get_Unreachable() { }

	// RVA: 0x1A66CE0 Offset: 0x1A652E0 VA: 0x181A66CE0
	public static void Requires(bool precondition, string paramName) { }

	// RVA: 0x1A66C80 Offset: 0x1A65280 VA: 0x181A66C80
	public static void RequiresNotNull(object value, string paramName) { }

	// RVA: 0x1A66C00 Offset: 0x1A65200 VA: 0x181A66C00
	public static void RequiresNotNull(object value, string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BBC60 Offset: 0x6BA260 VA: 0x1806BBC60
	|-ContractUtils.RequiresNotNullItems<object>
	|
	|-RVA: 0x6BBA70 Offset: 0x6BA070 VA: 0x1806BBA70
	|-ContractUtils.RequiresNotNullItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A66B80 Offset: 0x1A65180 VA: 0x181A66B80
	private static string GetParamName(string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BB970 Offset: 0x6B9F70 VA: 0x1806BB970
	|-ContractUtils.RequiresArrayRange<KeyValuePair<object, object>>
	|-ContractUtils.RequiresArrayRange<object>
	|-ContractUtils.RequiresArrayRange<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Dynamic.Utils
internal static class EmptyReadOnlyCollection<T> // TypeDefIndex: 11328
{
	// Fields
	public static readonly ReadOnlyCollection<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE908E0 Offset: 0xE8EEE0 VA: 0x180E908E0
	|-EmptyReadOnlyCollection<object>..cctor
	|
	|-RVA: 0xE90A60 Offset: 0xE8F060 VA: 0x180E90A60
	|-EmptyReadOnlyCollection<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class ExpressionUtils // TypeDefIndex: 11329
{
	// Methods

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FF290 Offset: 0x6FD890 VA: 0x1806FF290
	|-ExpressionUtils.ReturnReadOnly<object>
	|
	|-RVA: 0x6FF180 Offset: 0x6FD780 VA: 0x1806FF180
	|-ExpressionUtils.ReturnReadOnly<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ReturnObject<T>(object collectionOrT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FF060 Offset: 0x6FD660 VA: 0x1806FF060
	|-ExpressionUtils.ReturnObject<object>
	*/

	// RVA: 0x1A67900 Offset: 0x1A65F00 VA: 0x181A67900
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x1A67820 Offset: 0x1A65E20 VA: 0x181A67820
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x1A67D10 Offset: 0x1A66310 VA: 0x181A67D10
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

	// RVA: 0x1A67390 Offset: 0x1A65990 VA: 0x181A67390
	public static void RequiresCanRead(Expression expression, string paramName) { }

	// RVA: 0x1A673A0 Offset: 0x1A659A0 VA: 0x181A673A0
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	// RVA: 0x1A675F0 Offset: 0x1A65BF0 VA: 0x181A675F0
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x1A67310 Offset: 0x1A65910 VA: 0x181A67310
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FF610 Offset: 0x6FDC10 VA: 0x1806FF610
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FF390 Offset: 0x6FD990 VA: 0x1806FF390
	|-ExpressionUtils.SameElementsInCollection<object>
	*/

	[Extension]
	// RVA: 0x1A677A0 Offset: 0x1A65DA0 VA: 0x181A677A0
	public static void ValidateArgumentCount(LambdaExpression lambda) { }
}

// Namespace: System.Dynamic.Utils
internal static class ExpressionVisitorUtils // TypeDefIndex: 11330
{
	// Methods

	// RVA: 0x1A68350 Offset: 0x1A66950 VA: 0x181A68350
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	// RVA: 0x1A68560 Offset: 0x1A66B60 VA: 0x181A68560
	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

	// RVA: 0x1A68130 Offset: 0x1A66730 VA: 0x181A68130
	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeExtensions // TypeDefIndex: 11331
{
	// Fields
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1A6D1A0 Offset: 0x1A6B7A0 VA: 0x181A6D1A0
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Extension]
	// RVA: 0x1A6D460 Offset: 0x1A6BA60 VA: 0x181A6D460
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

	[Extension]
	// RVA: 0x1A6D380 Offset: 0x1A6B980 VA: 0x181A6D380
	public static Type GetReturnType(MethodBase mi) { }

	[Extension]
	// RVA: 0x1A6D430 Offset: 0x1A6BA30 VA: 0x181A6D430
	public static TypeCode GetTypeCode(Type type) { }

	[Extension]
	// RVA: 0x1A6D250 Offset: 0x1A6B850 VA: 0x181A6D250
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	// RVA: 0x1A6D660 Offset: 0x1A6BC60 VA: 0x181A6D660
	private static void .cctor() { }
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeUtils // TypeDefIndex: 11333
{
	// Fields
	private static readonly Type[] s_arrayAssignableInterfaces; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1A6DF90 Offset: 0x1A6C590 VA: 0x181A6DF90
	public static Type GetNonNullableType(Type type) { }

	[Extension]
	// RVA: 0x1A6E070 Offset: 0x1A6C670 VA: 0x181A6E070
	public static Type GetNullableType(Type type) { }

	[Extension]
	// RVA: 0x1A70680 Offset: 0x1A6EC80 VA: 0x181A70680
	public static bool IsNullableType(Type type) { }

	[Extension]
	// RVA: 0x1A70610 Offset: 0x1A6EC10 VA: 0x181A70610
	public static bool IsNullableOrReferenceType(Type type) { }

	[Extension]
	// RVA: 0x1A6F330 Offset: 0x1A6D930 VA: 0x181A6F330
	public static bool IsBool(Type type) { }

	[Extension]
	// RVA: 0x1A70880 Offset: 0x1A6EE80 VA: 0x181A70880
	public static bool IsNumeric(Type type) { }

	[Extension]
	// RVA: 0x1A700A0 Offset: 0x1A6E6A0 VA: 0x181A700A0
	public static bool IsInteger(Type type) { }

	[Extension]
	// RVA: 0x1A6F200 Offset: 0x1A6D800 VA: 0x181A6F200
	public static bool IsArithmetic(Type type) { }

	[Extension]
	// RVA: 0x1A70A80 Offset: 0x1A6F080 VA: 0x181A70A80
	public static bool IsUnsignedInt(Type type) { }

	[Extension]
	// RVA: 0x1A6FF60 Offset: 0x1A6E560 VA: 0x181A6FF60
	public static bool IsIntegerOrBool(Type type) { }

	[Extension]
	// RVA: 0x1A70730 Offset: 0x1A6ED30 VA: 0x181A70730
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x1A70BD0 Offset: 0x1A6F1D0 VA: 0x181A70BD0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[Extension]
	// RVA: 0x1A6E9C0 Offset: 0x1A6CFC0 VA: 0x181A6E9C0
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1A6EF00 Offset: 0x1A6D500 VA: 0x181A6EF00
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1A710D0 Offset: 0x1A6F6D0 VA: 0x181A710D0
	private static bool StrictHasReferenceConversionTo(Type source, Type dest, bool skipNonArray) { }

	// RVA: 0x1A6E580 Offset: 0x1A6CB80 VA: 0x181A6E580
	private static bool HasArrayToInterfaceConversion(Type source, Type dest) { }

	// RVA: 0x1A6ECE0 Offset: 0x1A6D2E0 VA: 0x181A6ECE0
	private static bool HasInterfaceToArrayConversion(Type source, Type dest) { }

	// RVA: 0x1A6F590 Offset: 0x1A6DB90 VA: 0x181A6F590
	private static bool IsCovariant(Type t) { }

	// RVA: 0x1A6F430 Offset: 0x1A6DA30 VA: 0x181A6F430
	private static bool IsContravariant(Type t) { }

	// RVA: 0x1A701D0 Offset: 0x1A6E7D0 VA: 0x181A701D0
	private static bool IsInvariant(Type t) { }

	// RVA: 0x1A6F5C0 Offset: 0x1A6DBC0 VA: 0x181A6F5C0
	private static bool IsDelegate(Type t) { }

	// RVA: 0x1A70200 Offset: 0x1A6E800 VA: 0x181A70200
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1A6F460 Offset: 0x1A6DA60 VA: 0x181A6F460
	public static bool IsConvertible(Type type) { }

	// RVA: 0x1A6F110 Offset: 0x1A6D710 VA: 0x181A6F110
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x1A6E7A0 Offset: 0x1A6CDA0 VA: 0x181A6E7A0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[Extension]
	// RVA: 0x1A6FA90 Offset: 0x1A6E090 VA: 0x181A6FA90
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x1A6E1D0 Offset: 0x1A6C7D0 VA: 0x181A6E1D0
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x1A6D860 Offset: 0x1A6BE60 VA: 0x181A6D860
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x1A6F8F0 Offset: 0x1A6DEF0 VA: 0x181A6F8F0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x17B9E00 Offset: 0x17B8400 VA: 0x1817B9E00
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x1A6F640 Offset: 0x1A6DC40 VA: 0x181A6F640
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x1A6F770 Offset: 0x1A6DD70 VA: 0x181A6F770
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x1A6DA40 Offset: 0x1A6C040 VA: 0x181A6DA40
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x1A6DD40 Offset: 0x1A6C340 VA: 0x181A6DD40
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[Extension]
	// RVA: 0x1A6E020 Offset: 0x1A6C620 VA: 0x181A6E020
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x1A6D6F0 Offset: 0x1A6BCF0 VA: 0x181A6D6F0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x1A6D760 Offset: 0x1A6BD60 VA: 0x181A6D760
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x1A709B0 Offset: 0x1A6EFB0 VA: 0x181A709B0
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x1A71590 Offset: 0x1A6FB90 VA: 0x181A71590
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x1A713F0 Offset: 0x1A6F9F0 VA: 0x181A713F0
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x1A71600 Offset: 0x1A6FC00 VA: 0x181A71600
	public static bool ValidateType(Type type, string paramName, int index) { }

	[Extension]
	// RVA: 0x1A6DF40 Offset: 0x1A6C540 VA: 0x181A6DF40
	public static MethodInfo GetInvokeMethod(Type delegateType) { }

	// RVA: 0x1A716F0 Offset: 0x1A6FCF0 VA: 0x181A716F0
	private static void .cctor() { }
}

