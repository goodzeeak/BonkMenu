// Namespace: System.Linq
internal static class Error // TypeDefIndex: 10711
{
	// Methods

	// RVA: 0x19E96D0 Offset: 0x19E7CD0 VA: 0x1819E96D0
	internal static Exception ArgumentNull(string s) { }

	// RVA: 0x19E9730 Offset: 0x19E7D30 VA: 0x1819E9730
	internal static Exception ArgumentOutOfRange(string s) { }

	// RVA: 0x19E9790 Offset: 0x19E7D90 VA: 0x1819E9790
	internal static Exception MoreThanOneElement() { }

	// RVA: 0x19E97F0 Offset: 0x19E7DF0 VA: 0x1819E97F0
	internal static Exception MoreThanOneMatch() { }

	// RVA: 0x19E9850 Offset: 0x19E7E50 VA: 0x1819E9850
	internal static Exception NoElements() { }

	// RVA: 0x19E98B0 Offset: 0x19E7EB0 VA: 0x1819E98B0
	internal static Exception NoMatch() { }

	// RVA: 0x19E9910 Offset: 0x19E7F10 VA: 0x1819E9910
	internal static Exception NotSupported() { }
}

// Namespace: System.Linq
[Extension]
public static class Enumerable // TypeDefIndex: 10733
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F5390 Offset: 0x6F3990 VA: 0x1806F5390
	|-Enumerable.Where<KeyValuePair<Edge, object>>
	|-Enumerable.Where<KeyValuePair<long, object>>
	|-Enumerable.Where<KeyValuePair<object, bool>>
	|-Enumerable.Where<KeyValuePair<object, object>>
	|
	|-RVA: 0x6F4CC0 Offset: 0x6F32C0 VA: 0x1806F4CC0
	|-Enumerable.Where<KeyValuePair<int, int>>
	|-Enumerable.Where<char>
	|-Enumerable.Where<Edge>
	|-Enumerable.Where<Int32Enum>
	|-Enumerable.Where<object>
	|
	|-RVA: 0x6F5020 Offset: 0x6F3620 VA: 0x1806F5020
	|-Enumerable.Where<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6F56F0 Offset: 0x6F3CF0 VA: 0x1806F56F0
	|-Enumerable.Where<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EC2D0 Offset: 0x6EA8D0 VA: 0x1806EC2D0
	|-Enumerable.Select<DataPoint<int>, float>
	|-Enumerable.Select<DataPoint<object>, float>
	|-Enumerable.Select<DataPoint<float>, float>
	|-Enumerable.Select<DataPoint<float4>, float>
	|-Enumerable.Select<KeyValuePair<Edge, object>, Edge>
	|-Enumerable.Select<KeyValuePair<Edge, object>, object>
	|-Enumerable.Select<KeyValuePair<int, int>, KeyValuePair<int, int>>
	|-Enumerable.Select<KeyValuePair<int, int>, int>
	|-Enumerable.Select<KeyValuePair<long, object>, object>
	|-Enumerable.Select<KeyValuePair<object, bool>, object>
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|-Enumerable.Select<SimpleTuple<object, object>, int>
	|-Enumerable.Select<SimpleTuple<float, Vector2>, Vector2>
	|-Enumerable.Select<Edge, Edge>
	|-Enumerable.Select<EdgeLookup, Edge>
	|-Enumerable.Select<int, int>
	|-Enumerable.Select<int, object>
	|-Enumerable.Select<Int32Enum, object>
	|-Enumerable.Select<object, Edge>
	|-Enumerable.Select<object, int>
	|-Enumerable.Select<object, object>
	|-Enumerable.Select<object, float>
	|-Enumerable.Select<StyleSelectorPart, object>
	|-Enumerable.Select<Vector2, object>
	|-Enumerable.Select<Vector4, Vector2>
	|-Enumerable.Select<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object>
	|
	|-RVA: 0x6EC650 Offset: 0x6EAC50 VA: 0x1806EC650
	|-Enumerable.Select<Edge, EdgeLookup>
	|-Enumerable.Select<object, ValueTuple<object, object>>
	|-Enumerable.Select<object, Color>
	|-Enumerable.Select<object, Guid>
	|-Enumerable.Select<object, Vector3>
	|
	|-RVA: 0x6EC9D0 Offset: 0x6EAFD0 VA: 0x1806EC9D0
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6ECD60 Offset: 0x6EB360 VA: 0x1806ECD60
	|-Enumerable.Select<Vector3, KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x6EBDB0 Offset: 0x6EA3B0 VA: 0x1806EBDB0
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectIterator>d__5<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EBBA0 Offset: 0x6EA1A0 VA: 0x1806EBBA0
	|-Enumerable.SelectIterator<Vector3, KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x6E3010 Offset: 0x6E1610 VA: 0x1806E3010
	|-Enumerable.SelectIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DCC60 Offset: 0x6DB260 VA: 0x1806DCC60
	|-Enumerable.CombinePredicates<KeyValuePair<Edge, object>>
	|-Enumerable.CombinePredicates<KeyValuePair<long, object>>
	|-Enumerable.CombinePredicates<KeyValuePair<object, bool>>
	|-Enumerable.CombinePredicates<KeyValuePair<object, object>>
	|-Enumerable.CombinePredicates<ValueTuple<object, object>>
	|-Enumerable.CombinePredicates<Color>
	|-Enumerable.CombinePredicates<EdgeLookup>
	|-Enumerable.CombinePredicates<Guid>
	|
	|-RVA: 0x6DCD40 Offset: 0x6DB340 VA: 0x1806DCD40
	|-Enumerable.CombinePredicates<KeyValuePair<int, int>>
	|-Enumerable.CombinePredicates<Edge>
	|
	|-RVA: 0x6DCB80 Offset: 0x6DB180 VA: 0x1806DCB80
	|-Enumerable.CombinePredicates<char>
	|
	|-RVA: 0x6DCF00 Offset: 0x6DB500 VA: 0x1806DCF00
	|-Enumerable.CombinePredicates<int>
	|-Enumerable.CombinePredicates<Int32Enum>
	|
	|-RVA: 0x6DCFE0 Offset: 0x6DB5E0 VA: 0x1806DCFE0
	|-Enumerable.CombinePredicates<object>
	|
	|-RVA: 0x6DD0C0 Offset: 0x6DB6C0 VA: 0x1806DD0C0
	|-Enumerable.CombinePredicates<float>
	|
	|-RVA: 0x6DD1A0 Offset: 0x6DB7A0 VA: 0x1806DD1A0
	|-Enumerable.CombinePredicates<Vector2>
	|
	|-RVA: 0x6DD280 Offset: 0x6DB880 VA: 0x1806DD280
	|-Enumerable.CombinePredicates<Vector3>
	|
	|-RVA: 0x6DCE20 Offset: 0x6DB420 VA: 0x1806DCE20
	|-Enumerable.CombinePredicates<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6DD360 Offset: 0x6DB960 VA: 0x1806DD360
	|-Enumerable.CombinePredicates<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DD520 Offset: 0x6DBB20 VA: 0x1806DD520
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, Edge, Edge>
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, Edge>
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, Edge>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, Edge>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, object>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Edge>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|-Enumerable.CombineSelectors<SimpleTuple<object, object>, int, object>
	|-Enumerable.CombineSelectors<EdgeLookup, Edge, Edge>
	|-Enumerable.CombineSelectors<Vector4, Vector2, object>
	|
	|-RVA: 0x6DD440 Offset: 0x6DBA40 VA: 0x1806DD440
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, Edge, EdgeLookup>
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, Color>
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, Guid>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, Color>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, Guid>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, Color>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, Guid>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Color>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Guid>
	|-Enumerable.CombineSelectors<EdgeLookup, Edge, EdgeLookup>
	|
	|-RVA: 0x6DD600 Offset: 0x6DBC00 VA: 0x1806DD600
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, int>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, int>
	|-Enumerable.CombineSelectors<SimpleTuple<object, object>, int, int>
	|
	|-RVA: 0x6DD6E0 Offset: 0x6DBCE0 VA: 0x1806DD6E0
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, float>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, float>
	|
	|-RVA: 0x6E1A90 Offset: 0x6E0090 VA: 0x1806E1A90
	|-Enumerable.CombineSelectors<KeyValuePair<Edge, object>, object, Vector3>
	|-Enumerable.CombineSelectors<KeyValuePair<long, object>, object, Vector3>
	|-Enumerable.CombineSelectors<KeyValuePair<object, bool>, object, Vector3>
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, Vector3>
	|
	|-RVA: 0x6E1390 Offset: 0x6DF990 VA: 0x1806E1390
	|-Enumerable.CombineSelectors<KeyValuePair<int, int>, KeyValuePair<int, int>, KeyValuePair<int, int>>
	|-Enumerable.CombineSelectors<KeyValuePair<int, int>, int, object>
	|-Enumerable.CombineSelectors<Edge, Edge, Edge>
	|-Enumerable.CombineSelectors<Edge, EdgeLookup, Edge>
	|
	|-RVA: 0x6E1B70 Offset: 0x6E0170 VA: 0x1806E1B70
	|-Enumerable.CombineSelectors<KeyValuePair<int, int>, KeyValuePair<int, int>, int>
	|-Enumerable.CombineSelectors<KeyValuePair<int, int>, int, int>
	|
	|-RVA: 0x6E20B0 Offset: 0x6E06B0 VA: 0x1806E20B0
	|-Enumerable.CombineSelectors<SimpleTuple<float, Vector2>, Vector2, object>
	|
	|-RVA: 0x6E1470 Offset: 0x6DFA70 VA: 0x1806E1470
	|-Enumerable.CombineSelectors<Edge, Edge, EdgeLookup>
	|
	|-RVA: 0x6E17F0 Offset: 0x6DFDF0 VA: 0x1806E17F0
	|-Enumerable.CombineSelectors<int, int, int>
	|-Enumerable.CombineSelectors<int, object, int>
	|-Enumerable.CombineSelectors<Int32Enum, object, int>
	|
	|-RVA: 0x6E1710 Offset: 0x6DFD10 VA: 0x1806E1710
	|-Enumerable.CombineSelectors<int, int, object>
	|-Enumerable.CombineSelectors<int, object, Edge>
	|-Enumerable.CombineSelectors<int, object, object>
	|-Enumerable.CombineSelectors<Int32Enum, object, Edge>
	|-Enumerable.CombineSelectors<Int32Enum, object, object>
	|
	|-RVA: 0x6E1630 Offset: 0x6DFC30 VA: 0x1806E1630
	|-Enumerable.CombineSelectors<int, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<int, object, Color>
	|-Enumerable.CombineSelectors<int, object, Guid>
	|-Enumerable.CombineSelectors<Int32Enum, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<Int32Enum, object, Color>
	|-Enumerable.CombineSelectors<Int32Enum, object, Guid>
	|
	|-RVA: 0x6E18D0 Offset: 0x6DFED0 VA: 0x1806E18D0
	|-Enumerable.CombineSelectors<int, object, float>
	|-Enumerable.CombineSelectors<Int32Enum, object, float>
	|
	|-RVA: 0x6E19B0 Offset: 0x6DFFB0 VA: 0x1806E19B0
	|-Enumerable.CombineSelectors<int, object, Vector3>
	|-Enumerable.CombineSelectors<Int32Enum, object, Vector3>
	|
	|-RVA: 0x6E1D30 Offset: 0x6E0330 VA: 0x1806E1D30
	|-Enumerable.CombineSelectors<object, Edge, Edge>
	|-Enumerable.CombineSelectors<object, int, object>
	|-Enumerable.CombineSelectors<object, object, Edge>
	|-Enumerable.CombineSelectors<object, object, object>
	|
	|-RVA: 0x6E1C50 Offset: 0x6E0250 VA: 0x1806E1C50
	|-Enumerable.CombineSelectors<object, Edge, EdgeLookup>
	|-Enumerable.CombineSelectors<object, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<object, object, Color>
	|-Enumerable.CombineSelectors<object, object, Guid>
	|
	|-RVA: 0x6E1E10 Offset: 0x6E0410 VA: 0x1806E1E10
	|-Enumerable.CombineSelectors<object, int, int>
	|-Enumerable.CombineSelectors<object, object, int>
	|
	|-RVA: 0x6E1EF0 Offset: 0x6E04F0 VA: 0x1806E1EF0
	|-Enumerable.CombineSelectors<object, object, float>
	|
	|-RVA: 0x6E1FD0 Offset: 0x6E05D0 VA: 0x1806E1FD0
	|-Enumerable.CombineSelectors<object, object, Vector3>
	|
	|-RVA: 0x6E2190 Offset: 0x6E0790 VA: 0x1806E2190
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, Color>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, Guid>
	|
	|-RVA: 0x6E2270 Offset: 0x6E0870 VA: 0x1806E2270
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, Edge>
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, object>
	|
	|-RVA: 0x6E2350 Offset: 0x6E0950 VA: 0x1806E2350
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, int>
	|
	|-RVA: 0x6E2430 Offset: 0x6E0A30 VA: 0x1806E2430
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, float>
	|
	|-RVA: 0x6E2510 Offset: 0x6E0B10 VA: 0x1806E2510
	|-Enumerable.CombineSelectors<StyleSelectorPart, object, Vector3>
	|
	|-RVA: 0x6E25F0 Offset: 0x6E0BF0 VA: 0x1806E25F0
	|-Enumerable.CombineSelectors<Vector2, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<Vector2, object, Color>
	|-Enumerable.CombineSelectors<Vector2, object, Guid>
	|
	|-RVA: 0x6E26D0 Offset: 0x6E0CD0 VA: 0x1806E26D0
	|-Enumerable.CombineSelectors<Vector2, object, Edge>
	|-Enumerable.CombineSelectors<Vector2, object, object>
	|
	|-RVA: 0x6E27B0 Offset: 0x6E0DB0 VA: 0x1806E27B0
	|-Enumerable.CombineSelectors<Vector2, object, int>
	|
	|-RVA: 0x6E2890 Offset: 0x6E0E90 VA: 0x1806E2890
	|-Enumerable.CombineSelectors<Vector2, object, float>
	|
	|-RVA: 0x6E2970 Offset: 0x6E0F70 VA: 0x1806E2970
	|-Enumerable.CombineSelectors<Vector2, object, Vector3>
	|
	|-RVA: 0x6E1550 Offset: 0x6DFB50 VA: 0x1806E1550
	|-Enumerable.CombineSelectors<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6E2A50 Offset: 0x6E1050 VA: 0x1806E2A50
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, ValueTuple<object, object>>
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, Color>
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, Guid>
	|
	|-RVA: 0x6E2B30 Offset: 0x6E1130 VA: 0x1806E2B30
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, Edge>
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, object>
	|
	|-RVA: 0x6E2C10 Offset: 0x6E1210 VA: 0x1806E2C10
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, int>
	|
	|-RVA: 0x6E2CF0 Offset: 0x6E12F0 VA: 0x1806E2CF0
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, float>
	|
	|-RVA: 0x6E2DD0 Offset: 0x6E13D0 VA: 0x1806E2DD0
	|-Enumerable.CombineSelectors<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL, object, Vector3>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EBE50 Offset: 0x6EA450 VA: 0x1806EBE50
	|-Enumerable.SelectMany<int, Edge>
	|-Enumerable.SelectMany<object, Edge>
	|
	|-RVA: 0x6EBF70 Offset: 0x6EA570 VA: 0x1806EBF70
	|-Enumerable.SelectMany<int, int>
	|-Enumerable.SelectMany<object, int>
	|-Enumerable.SelectMany<Triangle, int>
	|
	|-RVA: 0x6EC1B0 Offset: 0x6EA7B0 VA: 0x1806EC1B0
	|-Enumerable.SelectMany<object, ValueTuple<object, object>>
	|
	|-RVA: 0x6EC090 Offset: 0x6EA690 VA: 0x1806EC090
	|-Enumerable.SelectMany<object, object>
	|
	|-RVA: 0x6EBDB0 Offset: 0x6EA3B0 VA: 0x1806EBDB0
	|-Enumerable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectManyIterator>d__17<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EBC50 Offset: 0x6EA250 VA: 0x1806EBC50
	|-Enumerable.SelectManyIterator<int, Edge>
	|-Enumerable.SelectManyIterator<object, Edge>
	|
	|-RVA: 0x6E2EB0 Offset: 0x6E14B0 VA: 0x1806E2EB0
	|-Enumerable.SelectManyIterator<int, int>
	|-Enumerable.SelectManyIterator<object, int>
	|-Enumerable.SelectManyIterator<Triangle, int>
	|
	|-RVA: 0x6EBD00 Offset: 0x6EA300 VA: 0x1806EBD00
	|-Enumerable.SelectManyIterator<object, ValueTuple<object, object>>
	|
	|-RVA: 0x6E3130 Offset: 0x6E1730 VA: 0x1806E3130
	|-Enumerable.SelectManyIterator<object, object>
	|
	|-RVA: 0x6E3010 Offset: 0x6E1610 VA: 0x1806E3010
	|-Enumerable.SelectManyIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F1A40 Offset: 0x6F0040 VA: 0x1806F1A40
	|-Enumerable.Take<object>
	|
	|-RVA: 0x6F15A0 Offset: 0x6EFBA0 VA: 0x1806F15A0
	|-Enumerable.Take<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<TakeIterator>d__25<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F19A0 Offset: 0x6EFFA0 VA: 0x1806F19A0
	|-Enumerable.TakeIterator<object>
	|
	|-RVA: 0x6F1880 Offset: 0x6EFE80 VA: 0x1806F1880
	|-Enumerable.TakeIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Skip<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F1620 Offset: 0x6EFC20 VA: 0x1806F1620
	|-Enumerable.Skip<object>
	|
	|-RVA: 0x6F15A0 Offset: 0x6EFBA0 VA: 0x1806F15A0
	|-Enumerable.Skip<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SkipIterator>d__31<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F1500 Offset: 0x6EFB00 VA: 0x1806F1500
	|-Enumerable.SkipIterator<object>
	|
	|-RVA: 0x6F13E0 Offset: 0x6EF9E0 VA: 0x1806F13E0
	|-Enumerable.SkipIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EB650 Offset: 0x6E9C50 VA: 0x1806EB650
	|-Enumerable.OrderBy<char, char>
	|
	|-RVA: 0x6EB6E0 Offset: 0x6E9CE0 VA: 0x1806EB6E0
	|-Enumerable.OrderBy<DiagnosticEvent, int>
	|-Enumerable.OrderBy<object, int>
	|
	|-RVA: 0x6EB770 Offset: 0x6E9D70 VA: 0x1806EB770
	|-Enumerable.OrderBy<GlyphPairAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.OrderBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.OrderBy<object, uint>
	|
	|-RVA: 0x6EB9D0 Offset: 0x6E9FD0 VA: 0x1806EB9D0
	|-Enumerable.OrderBy<object, float>
	|
	|-RVA: 0x6EB8A0 Offset: 0x6E9EA0 VA: 0x1806EB8A0
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EB930 Offset: 0x6E9F30 VA: 0x1806EB930
	|-Enumerable.OrderBy<object, object>
	|
	|-RVA: 0x6EB800 Offset: 0x6E9E00 VA: 0x1806EB800
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EB530 Offset: 0x6E9B30 VA: 0x1806EB530
	|-Enumerable.OrderByDescending<object, int>
	|
	|-RVA: 0x6EB5C0 Offset: 0x6E9BC0 VA: 0x1806EB5C0
	|-Enumerable.OrderByDescending<object, float>
	|-Enumerable.OrderByDescending<float, float>
	|
	|-RVA: 0x6EB4A0 Offset: 0x6E9AA0 VA: 0x1806EB4A0
	|-Enumerable.OrderByDescending<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F1B20 Offset: 0x6F0120 VA: 0x1806F1B20
	|-Enumerable.ThenBy<GlyphPairAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToBaseAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.ThenBy<MarkToMarkAdjustmentRecord, uint>
	|-Enumerable.ThenBy<object, uint>
	|-Enumerable.ThenBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E95D0 Offset: 0x6E7BD0 VA: 0x1806E95D0
	|-Enumerable.GroupBy<KeyValuePair<Vector3, int>, Vector3>
	|
	|-RVA: 0x6E9680 Offset: 0x6E7C80 VA: 0x1806E9680
	|-Enumerable.GroupBy<object, CSteamID>
	|-Enumerable.GroupBy<object, object>
	|
	|-RVA: 0x6E9520 Offset: 0x6E7B20 VA: 0x1806E9520
	|-Enumerable.GroupBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E31E0 Offset: 0x6E17E0 VA: 0x1806E31E0
	|-Enumerable.Concat<char>
	|
	|-RVA: 0x6E3300 Offset: 0x6E1900 VA: 0x1806E3300
	|-Enumerable.Concat<DiagnosticEvent>
	|
	|-RVA: 0x6E34C0 Offset: 0x6E1AC0 VA: 0x1806E34C0
	|-Enumerable.Concat<object>
	|
	|-RVA: 0x6E3420 Offset: 0x6E1A20 VA: 0x1806E3420
	|-Enumerable.Concat<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ConcatIterator>d__59<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E2EB0 Offset: 0x6E14B0 VA: 0x1806E2EB0
	|-Enumerable.ConcatIterator<char>
	|
	|-RVA: 0x6E2F60 Offset: 0x6E1560 VA: 0x1806E2F60
	|-Enumerable.ConcatIterator<DiagnosticEvent>
	|
	|-RVA: 0x6E3130 Offset: 0x6E1730 VA: 0x1806E3130
	|-Enumerable.ConcatIterator<object>
	|
	|-RVA: 0x6E3010 Offset: 0x6E1610 VA: 0x1806E3010
	|-Enumerable.ConcatIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E57C0 Offset: 0x6E3DC0 VA: 0x1806E57C0
	|-Enumerable.Distinct<char>
	|-Enumerable.Distinct<int>
	|-Enumerable.Distinct<float>
	|
	|-RVA: 0x6E5980 Offset: 0x6E3F80 VA: 0x1806E5980
	|-Enumerable.Distinct<Edge>
	|
	|-RVA: 0x6E58A0 Offset: 0x6E3EA0 VA: 0x1806E58A0
	|-Enumerable.Distinct<EdgeLookup>
	|
	|-RVA: 0x6E5AD0 Offset: 0x6E40D0 VA: 0x1806E5AD0
	|-Enumerable.Distinct<object>
	|
	|-RVA: 0x6E5A60 Offset: 0x6E4060 VA: 0x1806E5A60
	|-Enumerable.Distinct<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<DistinctIterator>d__68<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E53E0 Offset: 0x6E39E0 VA: 0x1806E53E0
	|-Enumerable.DistinctIterator<char>
	|-Enumerable.DistinctIterator<int>
	|-Enumerable.DistinctIterator<float>
	|
	|-RVA: 0x6E5540 Offset: 0x6E3B40 VA: 0x1806E5540
	|-Enumerable.DistinctIterator<Edge>
	|
	|-RVA: 0x6E5490 Offset: 0x6E3A90 VA: 0x1806E5490
	|-Enumerable.DistinctIterator<EdgeLookup>
	|
	|-RVA: 0x6E5710 Offset: 0x6E3D10 VA: 0x1806E5710
	|-Enumerable.DistinctIterator<object>
	|
	|-RVA: 0x6E55F0 Offset: 0x6E3BF0 VA: 0x1806E55F0
	|-Enumerable.DistinctIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F4A60 Offset: 0x6F3060 VA: 0x1806F4A60
	|-Enumerable.Union<char>
	|
	|-RVA: 0x6F4B90 Offset: 0x6F3190 VA: 0x1806F4B90
	|-Enumerable.Union<object>
	|
	|-RVA: 0x6E6710 Offset: 0x6E4D10 VA: 0x1806E6710
	|-Enumerable.Union<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<UnionIterator>d__71<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F4760 Offset: 0x6F2D60 VA: 0x1806F4760
	|-Enumerable.UnionIterator<char>
	|
	|-RVA: 0x6F4990 Offset: 0x6F2F90 VA: 0x1806F4990
	|-Enumerable.UnionIterator<object>
	|
	|-RVA: 0x6F4830 Offset: 0x6F2E30 VA: 0x1806F4830
	|-Enumerable.UnionIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E67B0 Offset: 0x6E4DB0 VA: 0x1806E67B0
	|-Enumerable.Except<object>
	|
	|-RVA: 0x6E6710 Offset: 0x6E4D10 VA: 0x1806E6710
	|-Enumerable.Except<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ExceptIterator>d__77<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E6640 Offset: 0x6E4C40 VA: 0x1806E6640
	|-Enumerable.ExceptIterator<object>
	|
	|-RVA: 0x6E64E0 Offset: 0x6E4AE0 VA: 0x1806E64E0
	|-Enumerable.ExceptIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EBAD0 Offset: 0x6EA0D0 VA: 0x1806EBAD0
	|-Enumerable.Reverse<Vector2>
	|
	|-RVA: 0x6EBA60 Offset: 0x6EA060 VA: 0x1806EBA60
	|-Enumerable.Reverse<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ReverseIterator>d__79<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DC6A0 Offset: 0x6DACA0 VA: 0x1806DC6A0
	|-Enumerable.ReverseIterator<Vector2>
	|
	|-RVA: 0x6DC4C0 Offset: 0x6DAAC0 VA: 0x1806DC4C0
	|-Enumerable.ReverseIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6ECE80 Offset: 0x6EB480 VA: 0x1806ECE80
	|-Enumerable.SequenceEqual<byte>
	|
	|-RVA: 0x6ED7D0 Offset: 0x6EBDD0 VA: 0x1806ED7D0
	|-Enumerable.SequenceEqual<EasingFunction>
	|
	|-RVA: 0x6EDCA0 Offset: 0x6EC2A0 VA: 0x1806EDCA0
	|-Enumerable.SequenceEqual<Edge>
	|
	|-RVA: 0x6EE4D0 Offset: 0x6ECAD0 VA: 0x1806EE4D0
	|-Enumerable.SequenceEqual<int>
	|
	|-RVA: 0x6EE8B0 Offset: 0x6ECEB0 VA: 0x1806EE8B0
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0x6EF370 Offset: 0x6ED970 VA: 0x1806EF370
	|-Enumerable.SequenceEqual<StylePropertyName>
	|
	|-RVA: 0x6EF3C0 Offset: 0x6ED9C0 VA: 0x1806EF3C0
	|-Enumerable.SequenceEqual<TimeValue>
	|
	|-RVA: 0x6EE0F0 Offset: 0x6EC6F0 VA: 0x1806EE0F0
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6EEE10 Offset: 0x6ED410 VA: 0x1806EEE10
	|-Enumerable.SequenceEqual<MultiColumnCollectionHeader.SortedColumnState>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6ECED0 Offset: 0x6EB4D0 VA: 0x1806ECED0
	|-Enumerable.SequenceEqual<byte>
	|
	|-RVA: 0x6ED350 Offset: 0x6EB950 VA: 0x1806ED350
	|-Enumerable.SequenceEqual<EasingFunction>
	|
	|-RVA: 0x6ED820 Offset: 0x6EBE20 VA: 0x1806ED820
	|-Enumerable.SequenceEqual<Edge>
	|
	|-RVA: 0x6EE140 Offset: 0x6EC740 VA: 0x1806EE140
	|-Enumerable.SequenceEqual<int>
	|
	|-RVA: 0x6EE520 Offset: 0x6ECB20 VA: 0x1806EE520
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0x6EEE60 Offset: 0x6ED460 VA: 0x1806EEE60
	|-Enumerable.SequenceEqual<StylePropertyName>
	|
	|-RVA: 0x6EF410 Offset: 0x6EDA10 VA: 0x1806EF410
	|-Enumerable.SequenceEqual<TimeValue>
	|
	|-RVA: 0x6EDCF0 Offset: 0x6EC2F0 VA: 0x1806EDCF0
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6EE900 Offset: 0x6ECF00 VA: 0x1806EE900
	|-Enumerable.SequenceEqual<MultiColumnCollectionHeader.SortedColumnState>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> AsEnumerable<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-Enumerable.AsEnumerable<char>
	|-Enumerable.AsEnumerable<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F2010 Offset: 0x6F0610 VA: 0x1806F2010
	|-Enumerable.ToArray<SplineSlice<object>>
	|
	|-RVA: 0x6F1C20 Offset: 0x6F0220 VA: 0x1806F1C20
	|-Enumerable.ToArray<char>
	|
	|-RVA: 0x6F1CB0 Offset: 0x6F02B0 VA: 0x1806F1CB0
	|-Enumerable.ToArray<Color>
	|
	|-RVA: 0x6F1D40 Offset: 0x6F0340 VA: 0x1806F1D40
	|-Enumerable.ToArray<Edge>
	|
	|-RVA: 0x6F1E60 Offset: 0x6F0460 VA: 0x1806F1E60
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x6F1EF0 Offset: 0x6F04F0 VA: 0x1806F1EF0
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0x6F1F80 Offset: 0x6F0580 VA: 0x1806F1F80
	|-Enumerable.ToArray<float>
	|
	|-RVA: 0x6F20A0 Offset: 0x6F06A0 VA: 0x1806F20A0
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x6F2130 Offset: 0x6F0730 VA: 0x1806F2130
	|-Enumerable.ToArray<Vector2>
	|
	|-RVA: 0x6F21C0 Offset: 0x6F07C0 VA: 0x1806F21C0
	|-Enumerable.ToArray<Vector3>
	|
	|-RVA: 0x6F2250 Offset: 0x6F0850 VA: 0x1806F2250
	|-Enumerable.ToArray<Vector4>
	|
	|-RVA: 0x6F1DD0 Offset: 0x6F03D0 VA: 0x1806F1DD0
	|-Enumerable.ToArray<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F4080 Offset: 0x6F2680 VA: 0x1806F4080
	|-Enumerable.ToList<KeyValuePair<object, object>>
	|
	|-RVA: 0x6F3AE0 Offset: 0x6F20E0 VA: 0x1806F3AE0
	|-Enumerable.ToList<BezierKnot>
	|
	|-RVA: 0x6F3B80 Offset: 0x6F2180 VA: 0x1806F3B80
	|-Enumerable.ToList<bool>
	|
	|-RVA: 0x6F3C20 Offset: 0x6F2220 VA: 0x1806F3C20
	|-Enumerable.ToList<Color>
	|
	|-RVA: 0x6F3D60 Offset: 0x6F2360 VA: 0x1806F3D60
	|-Enumerable.ToList<Edge>
	|
	|-RVA: 0x6F3CC0 Offset: 0x6F22C0 VA: 0x1806F3CC0
	|-Enumerable.ToList<EdgeLookup>
	|
	|-RVA: 0x6F3E00 Offset: 0x6F2400 VA: 0x1806F3E00
	|-Enumerable.ToList<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x6F3FE0 Offset: 0x6F25E0 VA: 0x1806F3FE0
	|-Enumerable.ToList<int>
	|
	|-RVA: 0x6F3F40 Offset: 0x6F2540 VA: 0x1806F3F40
	|-Enumerable.ToList<Int32Enum>
	|
	|-RVA: 0x6F4120 Offset: 0x6F2720 VA: 0x1806F4120
	|-Enumerable.ToList<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x6F41C0 Offset: 0x6F27C0 VA: 0x1806F41C0
	|-Enumerable.ToList<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x6F4260 Offset: 0x6F2860 VA: 0x1806F4260
	|-Enumerable.ToList<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x6F4300 Offset: 0x6F2900 VA: 0x1806F4300
	|-Enumerable.ToList<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x6F43A0 Offset: 0x6F29A0 VA: 0x1806F43A0
	|-Enumerable.ToList<object>
	|
	|-RVA: 0x6F4440 Offset: 0x6F2A40 VA: 0x1806F4440
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x6F44E0 Offset: 0x6F2AE0 VA: 0x1806F44E0
	|-Enumerable.ToList<SplineKnotIndex>
	|
	|-RVA: 0x6F4580 Offset: 0x6F2B80 VA: 0x1806F4580
	|-Enumerable.ToList<Vector2>
	|
	|-RVA: 0x6F4620 Offset: 0x6F2C20 VA: 0x1806F4620
	|-Enumerable.ToList<Vector3>
	|
	|-RVA: 0x6F46C0 Offset: 0x6F2CC0 VA: 0x1806F46C0
	|-Enumerable.ToList<Vector4>
	|
	|-RVA: 0x6F3EA0 Offset: 0x6F24A0 VA: 0x1806F3EA0
	|-Enumerable.ToList<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F3A70 Offset: 0x6F2070 VA: 0x1806F3A70
	|-Enumerable.ToDictionary<object, object>
	|
	|-RVA: 0x6F27D0 Offset: 0x6F0DD0 VA: 0x1806F27D0
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F2E40 Offset: 0x6F1440 VA: 0x1806F2E40
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|-Enumerable.ToDictionary<ValueTuple<object, object>, object, object>
	|
	|-RVA: 0x6F2840 Offset: 0x6F0E40 VA: 0x1806F2840
	|-Enumerable.ToDictionary<Int32Enum, Int32Enum, object>
	|
	|-RVA: 0x6F2EB0 Offset: 0x6F14B0 VA: 0x1806F2EB0
	|-Enumerable.ToDictionary<object, long, object>
	|
	|-RVA: 0x6F3420 Offset: 0x6F1A20 VA: 0x1806F3420
	|-Enumerable.ToDictionary<object, object, bool>
	|
	|-RVA: 0x6F3490 Offset: 0x6F1A90 VA: 0x1806F3490
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x6F3A00 Offset: 0x6F2000 VA: 0x1806F3A00
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x6F2760 Offset: 0x6F0D60 VA: 0x1806F2760
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F2B30 Offset: 0x6F1130 VA: 0x1806F2B30
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|-Enumerable.ToDictionary<ValueTuple<object, object>, object, object>
	|
	|-RVA: 0x6F28B0 Offset: 0x6F0EB0 VA: 0x1806F28B0
	|-Enumerable.ToDictionary<Int32Enum, Int32Enum, object>
	|
	|-RVA: 0x6F2F20 Offset: 0x6F1520 VA: 0x1806F2F20
	|-Enumerable.ToDictionary<object, long, object>
	|
	|-RVA: 0x6F31A0 Offset: 0x6F17A0 VA: 0x1806F31A0
	|-Enumerable.ToDictionary<object, object, bool>
	|
	|-RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x6F3780 Offset: 0x6F1D80 VA: 0x1806F3780
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x6F22E0 Offset: 0x6F08E0 VA: 0x1806F22E0
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EB3D0 Offset: 0x6E99D0 VA: 0x1806EB3D0
	|-Enumerable.OfType<object>
	|
	|-RVA: 0x6EB370 Offset: 0x6E9970 VA: 0x1806EB370
	|-Enumerable.OfType<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<OfTypeIterator>d__97<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DC610 Offset: 0x6DAC10 VA: 0x1806DC610
	|-Enumerable.OfTypeIterator<object>
	|
	|-RVA: 0x6DC4C0 Offset: 0x6DAAC0 VA: 0x1806DC4C0
	|-Enumerable.OfTypeIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DC730 Offset: 0x6DAD30 VA: 0x1806DC730
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0x6DC8B0 Offset: 0x6DAEB0 VA: 0x1806DC8B0
	|-Enumerable.Cast<Int32Enum>
	|
	|-RVA: 0x6DC9A0 Offset: 0x6DAFA0 VA: 0x1806DC9A0
	|-Enumerable.Cast<object>
	|
	|-RVA: 0x6DCA90 Offset: 0x6DB090 VA: 0x1806DCA90
	|-Enumerable.Cast<Vector2>
	|
	|-RVA: 0x6DC820 Offset: 0x6DAE20 VA: 0x1806DC820
	|-Enumerable.Cast<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<CastIterator>d__99<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DC430 Offset: 0x6DAA30 VA: 0x1806DC430
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x6DC580 Offset: 0x6DAB80 VA: 0x1806DC580
	|-Enumerable.CastIterator<Int32Enum>
	|
	|-RVA: 0x6DC610 Offset: 0x6DAC10 VA: 0x1806DC610
	|-Enumerable.CastIterator<object>
	|
	|-RVA: 0x6DC6A0 Offset: 0x6DACA0 VA: 0x1806DC6A0
	|-Enumerable.CastIterator<Vector2>
	|
	|-RVA: 0x6DC4C0 Offset: 0x6DAAC0 VA: 0x1806DC4C0
	|-Enumerable.CastIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E8E60 Offset: 0x6E7460 VA: 0x1806E8E60
	|-Enumerable.First<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x6E83A0 Offset: 0x6E69A0 VA: 0x1806E83A0
	|-Enumerable.First<AsyncOperationHandle>
	|
	|-RVA: 0x6E8C50 Offset: 0x6E7250 VA: 0x1806E8C50
	|-Enumerable.First<int>
	|-Enumerable.First<Int32Enum>
	|
	|-RVA: 0x6E9310 Offset: 0x6E7910 VA: 0x1806E9310
	|-Enumerable.First<object>
	|
	|-RVA: 0x6E89B0 Offset: 0x6E6FB0 VA: 0x1806E89B0
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E9150 Offset: 0x6E7750 VA: 0x1806E9150
	|-Enumerable.First<object>
	|
	|-RVA: 0x6E86A0 Offset: 0x6E6CA0 VA: 0x1806E86A0
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E7D80 Offset: 0x6E6380 VA: 0x1806E7D80
	|-Enumerable.FirstOrDefault<SimpleTuple<object, int>>
	|
	|-RVA: 0x6E7970 Offset: 0x6E5F70 VA: 0x1806E7970
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x6E7630 Offset: 0x6E5C30 VA: 0x1806E7630
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E6DD0 Offset: 0x6E53D0 VA: 0x1806E6DD0
	|-Enumerable.FirstOrDefault<DataPoint<int>>
	|
	|-RVA: 0x6E7010 Offset: 0x6E5610 VA: 0x1806E7010
	|-Enumerable.FirstOrDefault<DataPoint<object>>
	|-Enumerable.FirstOrDefault<KeyValuePair<object, object>>
	|
	|-RVA: 0x6E6B80 Offset: 0x6E5180 VA: 0x1806E6B80
	|-Enumerable.FirstOrDefault<DataPoint<float>>
	|
	|-RVA: 0x6E68E0 Offset: 0x6E4EE0 VA: 0x1806E68E0
	|-Enumerable.FirstOrDefault<DataPoint<float4>>
	|
	|-RVA: 0x6E7BA0 Offset: 0x6E61A0 VA: 0x1806E7BA0
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x6E7290 Offset: 0x6E5890 VA: 0x1806E7290
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x6E8070 Offset: 0x6E6670 VA: 0x1806E8070
	|-Enumerable.FirstOrDefault<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EA500 Offset: 0x6E8B00 VA: 0x1806EA500
	|-Enumerable.Last<Edge>
	|
	|-RVA: 0x6EAC90 Offset: 0x6E9290 VA: 0x1806EAC90
	|-Enumerable.Last<Int32Enum>
	|
	|-RVA: 0x6EAFA0 Offset: 0x6E95A0 VA: 0x1806EAFA0
	|-Enumerable.Last<object>
	|
	|-RVA: 0x6EA880 Offset: 0x6E8E80 VA: 0x1806EA880
	|-Enumerable.Last<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E9F90 Offset: 0x6E8590 VA: 0x1806E9F90
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0x6E9730 Offset: 0x6E7D30 VA: 0x1806E9730
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EA2C0 Offset: 0x6E88C0 VA: 0x1806EA2C0
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0x6E9BE0 Offset: 0x6E81E0 VA: 0x1806E9BE0
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F1170 Offset: 0x6EF770 VA: 0x1806F1170
	|-Enumerable.Single<object>
	|
	|-RVA: 0x6F08B0 Offset: 0x6EEEB0 VA: 0x1806F08B0
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F0BF0 Offset: 0x6EF1F0 VA: 0x1806F0BF0
	|-Enumerable.Single<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x6F0EF0 Offset: 0x6EF4F0 VA: 0x1806F0EF0
	|-Enumerable.Single<object>
	|
	|-RVA: 0x6F04E0 Offset: 0x6EEAE0 VA: 0x1806F04E0
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F0280 Offset: 0x6EE880 VA: 0x1806F0280
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x6EF890 Offset: 0x6EDE90 VA: 0x1806EF890
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F0000 Offset: 0x6EE600 VA: 0x1806F0000
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x6EFBF0 Offset: 0x6EE1F0 VA: 0x1806EFBF0
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E5F10 Offset: 0x6E4510 VA: 0x1806E5F10
	|-Enumerable.ElementAt<KeyValuePair<object, object>>
	|
	|-RVA: 0x6E6240 Offset: 0x6E4840 VA: 0x1806E6240
	|-Enumerable.ElementAt<object>
	|
	|-RVA: 0x6E5BB0 Offset: 0x6E41B0 VA: 0x1806E5BB0
	|-Enumerable.ElementAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19E9270 Offset: 0x19E7870 VA: 0x1819E9270
	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachine(typeof(Enumerable.<RangeIterator>d__115))]
	// RVA: 0x19E91F0 Offset: 0x19E77F0 VA: 0x1819E91F0
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Empty<TResult>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FD9B0 Offset: 0x5FBFB0 VA: 0x1805FD9B0
	|-Enumerable.Empty<int>
	|-Enumerable.Empty<object>
	|-Enumerable.Empty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DB9B0 Offset: 0x6D9FB0 VA: 0x1806DB9B0
	|-Enumerable.Any<Color>
	|-Enumerable.Any<int>
	|-Enumerable.Any<object>
	|-Enumerable.Any<Vector2>
	|-Enumerable.Any<Vector3>
	|-Enumerable.Any<Vector4>
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DB590 Offset: 0x6D9B90 VA: 0x1806DB590
	|-Enumerable.Any<bool>
	|
	|-RVA: 0x6DB770 Offset: 0x6D9D70 VA: 0x1806DB770
	|-Enumerable.Any<byte>
	|
	|-RVA: 0x6DBDB0 Offset: 0x6DA3B0 VA: 0x1806DBDB0
	|-Enumerable.Any<object>
	|
	|-RVA: 0x6DBF90 Offset: 0x6DA590 VA: 0x1806DBF90
	|-Enumerable.Any<Triangle>
	|
	|-RVA: 0x6DC1F0 Offset: 0x6DA7F0 VA: 0x1806DC1F0
	|-Enumerable.Any<ulong>
	|
	|-RVA: 0x6DBAF0 Offset: 0x6DA0F0 VA: 0x1806DBAF0
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DB3B0 Offset: 0x6D99B0 VA: 0x1806DB3B0
	|-Enumerable.All<object>
	|
	|-RVA: 0x6DB0F0 Offset: 0x6D96F0 VA: 0x1806DB0F0
	|-Enumerable.All<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E4D20 Offset: 0x6E3320 VA: 0x1806E4D20
	|-Enumerable.Count<KeyValuePair<Vector3, int>>
	|-Enumerable.Count<int>
	|-Enumerable.Count<object>
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E4AD0 Offset: 0x6E30D0 VA: 0x1806E4AD0
	|-Enumerable.Count<char>
	|
	|-RVA: 0x6E5200 Offset: 0x6E3800 VA: 0x1806E5200
	|-Enumerable.Count<object>
	|
	|-RVA: 0x6E4F20 Offset: 0x6E3520 VA: 0x1806E4F20
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E41C0 Offset: 0x6E27C0 VA: 0x1806E41C0
	|-Enumerable.Contains<KeyValuePair<long, object>>
	|
	|-RVA: 0x6E3CC0 Offset: 0x6E22C0 VA: 0x1806E3CC0
	|-Enumerable.Contains<int>
	|
	|-RVA: 0x6E47C0 Offset: 0x6E2DC0 VA: 0x1806E47C0
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x6E46B0 Offset: 0x6E2CB0 VA: 0x1806E46B0
	|-Enumerable.Contains<PidVid>
	|
	|-RVA: 0x6E35E0 Offset: 0x6E1BE0 VA: 0x1806E35E0
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E3DD0 Offset: 0x6E23D0 VA: 0x1806E3DD0
	|-Enumerable.Contains<KeyValuePair<long, object>>
	|
	|-RVA: 0x6E3AC0 Offset: 0x6E20C0 VA: 0x1806E3AC0
	|-Enumerable.Contains<int>
	|
	|-RVA: 0x6E48D0 Offset: 0x6E2ED0 VA: 0x1806E48D0
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x6E42F0 Offset: 0x6E28F0 VA: 0x1806E42F0
	|-Enumerable.Contains<PidVid>
	|
	|-RVA: 0x6E37B0 Offset: 0x6E1DB0 VA: 0x1806E37B0
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x19E9330 Offset: 0x19E7930 VA: 0x1819E9330
	public static int Sum(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x19E94E0 Offset: 0x19E7AE0 VA: 0x1819E94E0
	public static float Sum(IEnumerable<float> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F1820 Offset: 0x6EFE20 VA: 0x1806F1820
	|-Enumerable.Sum<SimpleTuple<object, object>>
	|-Enumerable.Sum<object>
	|
	|-RVA: 0x6F1700 Offset: 0x6EFD00 VA: 0x1806F1700
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float Sum<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F17C0 Offset: 0x6EFDC0 VA: 0x1806F17C0
	|-Enumerable.Sum<object>
	|
	|-RVA: 0x6F1760 Offset: 0x6EFD60 VA: 0x1806F1760
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x19E8FA0 Offset: 0x19E75A0 VA: 0x1819E8FA0
	public static int Min(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x19E8D50 Offset: 0x19E7350 VA: 0x1819E8D50
	public static int Max(IEnumerable<int> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int Max<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6EB310 Offset: 0x6E9910 VA: 0x1806EB310
	|-Enumerable.Max<object>
	|
	|-RVA: 0x6EB2B0 Offset: 0x6E98B0 VA: 0x1806EB2B0
	|-Enumerable.Max<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x19E8B10 Offset: 0x19E7110 VA: 0x1819E8B10
	public static float Average(IEnumerable<float> source) { }
}

// Namespace: System.Linq
internal class EmptyEnumerable<TElement> // TypeDefIndex: 10734
{
	// Fields
	public static readonly TElement[] Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA70 Offset: 0xE8E070 VA: 0x180E8FA70
	|-EmptyEnumerable<int>..cctor
	|-EmptyEnumerable<object>..cctor
	|-EmptyEnumerable<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Linq
internal class IdentityFunction<TElement> // TypeDefIndex: 10736
{
	// Properties
	public static Func<TElement, TElement> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1091D60 Offset: 0x1090360 VA: 0x181091D60
	|-IdentityFunction<KeyValuePair<Vector3, int>>.get_Instance
	|
	|-RVA: 0x10918B0 Offset: 0x108FEB0 VA: 0x1810918B0
	|-IdentityFunction<object>.get_Instance
	|
	|-RVA: 0x1091AF0 Offset: 0x10900F0 VA: 0x181091AF0
	|-IdentityFunction<__Il2CppFullySharedGenericType>.get_Instance
	*/
}

// Namespace: System.Linq
public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 10737
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IOrderedEnumerable<__Il2CppFullySharedGenericType>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Linq
public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 10738
{}

// Namespace: System.Linq
[DefaultMember("Item")]
public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 10742
{
	// Fields
	private IEqualityComparer<TKey> comparer; // 0x0
	private Lookup.Grouping<TKey, TElement>[] groupings; // 0x0
	private Lookup.Grouping<TKey, TElement> lastGrouping; // 0x0
	private int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x605E40 Offset: 0x604440 VA: 0x180605E40
	|-Lookup<CSteamID, object>.Create<object>
	|
	|-RVA: 0x605B30 Offset: 0x604130 VA: 0x180605B30
	|-Lookup<object, object>.Create<object>
	|
	|-RVA: 0x605760 Offset: 0x603D60 VA: 0x180605760
	|-Lookup<Vector3, KeyValuePair<Vector3, int>>.Create<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x605170 Offset: 0x603770 VA: 0x180605170
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1285840 Offset: 0x1283E40 VA: 0x181285840
	|-Lookup<CSteamID, object>..ctor
	|
	|-RVA: 0x12859D0 Offset: 0x1283FD0 VA: 0x1812859D0
	|-Lookup<object, object>..ctor
	|
	|-RVA: 0x12856B0 Offset: 0x1283CB0 VA: 0x1812856B0
	|-Lookup<Vector3, KeyValuePair<Vector3, int>>..ctor
	|
	|-RVA: 0x1285600 Offset: 0x1283C00 VA: 0x181285600
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(Lookup.<GetEnumerator>d__12<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12837D0 Offset: 0x1281DD0 VA: 0x1812837D0
	|-Lookup<CSteamID, object>.GetEnumerator
	|-Lookup<object, object>.GetEnumerator
	|-Lookup<Vector3, KeyValuePair<Vector3, int>>.GetEnumerator
	|
	|-RVA: 0x1283860 Offset: 0x1281E60 VA: 0x181283860
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1285560 Offset: 0x1283B60 VA: 0x181285560
	|-Lookup<CSteamID, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup<Vector3, KeyValuePair<Vector3, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8FB170 Offset: 0x8F9770 VA: 0x1808FB170
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1284E30 Offset: 0x1283430 VA: 0x181284E30
	|-Lookup<CSteamID, object>.InternalGetHashCode
	|
	|-RVA: 0x1284FE0 Offset: 0x12835E0 VA: 0x181284FE0
	|-Lookup<object, object>.InternalGetHashCode
	|
	|-RVA: 0x1284F00 Offset: 0x1283500 VA: 0x181284F00
	|-Lookup<Vector3, KeyValuePair<Vector3, int>>.InternalGetHashCode
	|
	|-RVA: 0x1284CD0 Offset: 0x12832D0 VA: 0x181284CD0
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InternalGetHashCode
	*/

	// RVA: -1 Offset: -1
	internal Lookup.Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1284850 Offset: 0x1282E50 VA: 0x181284850
	|-Lookup<CSteamID, object>.GetGrouping
	|
	|-RVA: 0x12843D0 Offset: 0x12829D0 VA: 0x1812843D0
	|-Lookup<object, object>.GetGrouping
	|
	|-RVA: 0x1283E90 Offset: 0x1282490 VA: 0x181283E90
	|-Lookup<Vector3, KeyValuePair<Vector3, int>>.GetGrouping
	|
	|-RVA: 0x12838F0 Offset: 0x1281EF0 VA: 0x1812838F0
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetGrouping
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1285400 Offset: 0x1283A00 VA: 0x181285400
	|-Lookup<CSteamID, object>.Resize
	|-Lookup<object, object>.Resize
	|
	|-RVA: 0x12850B0 Offset: 0x12836B0 VA: 0x1812850B0
	|-Lookup<Vector3, KeyValuePair<Vector3, int>>.Resize
	|
	|-RVA: 0x1285210 Offset: 0x1283810 VA: 0x181285210
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	*/
}

// Namespace: System.Linq
internal class Set<TElement> // TypeDefIndex: 10744
{
	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96E760 Offset: 0x96CD60 VA: 0x18096E760
	|-Set<char>..ctor
	|
	|-RVA: 0x96E580 Offset: 0x96CB80 VA: 0x18096E580
	|-Set<Edge>..ctor
	|
	|-RVA: 0x96EC00 Offset: 0x96D200 VA: 0x18096EC00
	|-Set<EdgeLookup>..ctor
	|
	|-RVA: 0x96E940 Offset: 0x96CF40 VA: 0x18096E940
	|-Set<int>..ctor
	|
	|-RVA: 0x96EB20 Offset: 0x96D120 VA: 0x18096EB20
	|-Set<object>..ctor
	|
	|-RVA: 0x96E3A0 Offset: 0x96C9A0 VA: 0x18096E3A0
	|-Set<float>..ctor
	|
	|-RVA: 0x96EDE0 Offset: 0x96D3E0 VA: 0x18096EDE0
	|-Set<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96B0A0 Offset: 0x9696A0 VA: 0x18096B0A0
	|-Set<char>.Add
	|
	|-RVA: 0x96B280 Offset: 0x969880 VA: 0x18096B280
	|-Set<Edge>.Add
	|
	|-RVA: 0x96B100 Offset: 0x969700 VA: 0x18096B100
	|-Set<EdgeLookup>.Add
	|
	|-RVA: 0x96B070 Offset: 0x969670 VA: 0x18096B070
	|-Set<int>.Add
	|
	|-RVA: 0x96B140 Offset: 0x969740 VA: 0x18096B140
	|-Set<object>.Add
	|
	|-RVA: 0x96B0D0 Offset: 0x9696D0 VA: 0x18096B0D0
	|-Set<float>.Add
	|
	|-RVA: 0x96B170 Offset: 0x969770 VA: 0x18096B170
	|-Set<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96CD00 Offset: 0x96B300 VA: 0x18096CD00
	|-Set<char>.Find
	|
	|-RVA: 0x96BA30 Offset: 0x96A030 VA: 0x18096BA30
	|-Set<Edge>.Find
	|
	|-RVA: 0x96C2D0 Offset: 0x96A8D0 VA: 0x18096C2D0
	|-Set<EdgeLookup>.Find
	|
	|-RVA: 0x96BE80 Offset: 0x96A480 VA: 0x18096BE80
	|-Set<int>.Find
	|
	|-RVA: 0x96B710 Offset: 0x969D10 VA: 0x18096B710
	|-Set<object>.Find
	|
	|-RVA: 0x96B2B0 Offset: 0x9698B0 VA: 0x18096B2B0
	|-Set<float>.Find
	|
	|-RVA: 0x96C7B0 Offset: 0x96ADB0 VA: 0x18096C7B0
	|-Set<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96E210 Offset: 0x96C810 VA: 0x18096E210
	|-Set<char>.Resize
	|
	|-RVA: 0x96DD70 Offset: 0x96C370 VA: 0x18096DD70
	|-Set<Edge>.Resize
	|
	|-RVA: 0x96DBE0 Offset: 0x96C1E0 VA: 0x18096DBE0
	|-Set<EdgeLookup>.Resize
	|
	|-RVA: 0x96E080 Offset: 0x96C680 VA: 0x18096E080
	|-Set<int>.Resize
	|
	|-RVA: 0x96DA50 Offset: 0x96C050 VA: 0x18096DA50
	|-Set<object>.Resize
	|
	|-RVA: 0x96DEF0 Offset: 0x96C4F0 VA: 0x18096DEF0
	|-Set<float>.Resize
	|
	|-RVA: 0x96D810 Offset: 0x96BE10 VA: 0x18096D810
	|-Set<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96D670 Offset: 0x96BC70 VA: 0x18096D670
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x96D740 Offset: 0x96BD40 VA: 0x18096D740
	|-Set<Edge>.InternalGetHashCode
	|
	|-RVA: 0x96D400 Offset: 0x96BA00 VA: 0x18096D400
	|-Set<EdgeLookup>.InternalGetHashCode
	|
	|-RVA: 0x96D5A0 Offset: 0x96BBA0 VA: 0x18096D5A0
	|-Set<int>.InternalGetHashCode
	|
	|-RVA: 0x96D4D0 Offset: 0x96BAD0 VA: 0x18096D4D0
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x96D160 Offset: 0x96B760 VA: 0x18096D160
	|-Set<float>.InternalGetHashCode
	|
	|-RVA: 0x96D230 Offset: 0x96B830 VA: 0x18096D230
	|-Set<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/
}

// Namespace: System.Linq
internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 10745
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033910 Offset: 0x1031F10 VA: 0x181033910
	|-GroupedEnumerable<KeyValuePair<Vector3, int>, Vector3, KeyValuePair<Vector3, int>>..ctor
	|-GroupedEnumerable<object, CSteamID, object>..ctor
	|-GroupedEnumerable<object, object, object>..ctor
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033680 Offset: 0x1031C80 VA: 0x181033680
	|-GroupedEnumerable<KeyValuePair<Vector3, int>, Vector3, KeyValuePair<Vector3, int>>.GetEnumerator
	|
	|-RVA: 0x1033620 Offset: 0x1031C20 VA: 0x181033620
	|-GroupedEnumerable<object, CSteamID, object>.GetEnumerator
	|
	|-RVA: 0x1033760 Offset: 0x1031D60 VA: 0x181033760
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|
	|-RVA: 0x10336E0 Offset: 0x1031CE0 VA: 0x1810336E0
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10338A0 Offset: 0x1031EA0 VA: 0x1810338A0
	|-GroupedEnumerable<KeyValuePair<Vector3, int>, Vector3, KeyValuePair<Vector3, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1033830 Offset: 0x1031E30 VA: 0x181033830
	|-GroupedEnumerable<object, CSteamID, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10337C0 Offset: 0x1031DC0 VA: 0x1810337C0
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x865830 Offset: 0x863E30 VA: 0x180865830
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Linq
internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 10747
{
	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachine(typeof(OrderedEnumerable.<GetEnumerator>d__1<TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E1320 Offset: 0x12DF920 VA: 0x1812E1320
	|-OrderedEnumerable<char>.GetEnumerator
	|-OrderedEnumerable<float>.GetEnumerator
	|
	|-RVA: 0x12E10B0 Offset: 0x12DF6B0 VA: 0x1812E10B0
	|-OrderedEnumerable<DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x12E1020 Offset: 0x12DF620 VA: 0x1812E1020
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x12E11D0 Offset: 0x12DF7D0 VA: 0x1812E11D0
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x12E1140 Offset: 0x12DF740 VA: 0x1812E1140
	|-OrderedEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x12E1260 Offset: 0x12DF860 VA: 0x1812E1260
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E14F0 Offset: 0x12DFAF0 VA: 0x1812E14F0
	|-OrderedEnumerable<char>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12E1450 Offset: 0x12DFA50 VA: 0x1812E1450
	|-OrderedEnumerable<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12E1590 Offset: 0x12DFB90 VA: 0x1812E1590
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12E13B0 Offset: 0x12DF9B0 VA: 0x1812E13B0
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12E1630 Offset: 0x12DFC30 VA: 0x1812E1630
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD0FB10 Offset: 0xD0E110 VA: 0x180D0FB10
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x607360 Offset: 0x605960 VA: 0x180607360
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x607290 Offset: 0x605890 VA: 0x180607290
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-OrderedEnumerable<char>..ctor
	|-OrderedEnumerable<DiagnosticEvent>..ctor
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>..ctor
	|-OrderedEnumerable<object>..ctor
	|-OrderedEnumerable<float>..ctor
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Linq
internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 10748
{
	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E1BA0 Offset: 0x12E01A0 VA: 0x1812E1BA0
	|-OrderedEnumerable<char, char>..ctor
	|
	|-RVA: 0x12E1A90 Offset: 0x12E0090 VA: 0x1812E1A90
	|-OrderedEnumerable<DiagnosticEvent, int>..ctor
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x12E1870 Offset: 0x12DFE70 VA: 0x1812E1870
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>..ctor
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0x12E1CB0 Offset: 0x12E02B0 VA: 0x1812E1CB0
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x12E1980 Offset: 0x12DFF80 VA: 0x1812E1980
	|-OrderedEnumerable<object, float>..ctor
	|-OrderedEnumerable<float, float>..ctor
	|
	|-RVA: 0x12E1DC0 Offset: 0x12E03C0 VA: 0x1812E1DC0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E16D0 Offset: 0x12DFCD0 VA: 0x1812E16D0
	|-OrderedEnumerable<char, char>.GetEnumerableSorter
	|-OrderedEnumerable<DiagnosticEvent, int>.GetEnumerableSorter
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>.GetEnumerableSorter
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|-OrderedEnumerable<object, float>.GetEnumerableSorter
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	|-OrderedEnumerable<float, float>.GetEnumerableSorter
	|
	|-RVA: 0x12E17A0 Offset: 0x12DFDA0 VA: 0x1812E17A0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/
}

// Namespace: System.Linq
internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 10749
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94160 Offset: 0xE92760 VA: 0x180E94160
	|-EnumerableSorter<char>.Sort
	|
	|-RVA: 0xE94080 Offset: 0xE92680 VA: 0x180E94080
	|-EnumerableSorter<DiagnosticEvent>.Sort
	|
	|-RVA: 0xE944D0 Offset: 0xE92AD0 VA: 0x180E944D0
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.Sort
	|
	|-RVA: 0xE94690 Offset: 0xE92C90 VA: 0x180E94690
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0xE943F0 Offset: 0xE929F0 VA: 0x180E943F0
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0xE94770 Offset: 0xE92D70 VA: 0x180E94770
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0xE93FA0 Offset: 0xE925A0 VA: 0x180E93FA0
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0xE945B0 Offset: 0xE92BB0 VA: 0x180E945B0
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0xE94310 Offset: 0xE92910 VA: 0x180E94310
	|-EnumerableSorter<float>.Sort
	|
	|-RVA: 0xE94240 Offset: 0xE92840 VA: 0x180E94240
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE93C30 Offset: 0xE92230 VA: 0x180E93C30
	|-EnumerableSorter<char>.QuickSort
	|-EnumerableSorter<DiagnosticEvent>.QuickSort
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.QuickSort
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.QuickSort
	|-EnumerableSorter<object>.QuickSort
	|-EnumerableSorter<float>.QuickSort
	|
	|-RVA: 0xE93DF0 Offset: 0xE923F0 VA: 0x180E93DF0
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-EnumerableSorter<char>..ctor
	|-EnumerableSorter<DiagnosticEvent>..ctor
	|-EnumerableSorter<GlyphPairAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>..ctor
	|-EnumerableSorter<object>..ctor
	|-EnumerableSorter<float>..ctor
	|-EnumerableSorter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Linq
internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 10750
{
	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE95A10 Offset: 0xE94010 VA: 0x180E95A10
	|-EnumerableSorter<char, char>..ctor
	|-EnumerableSorter<DiagnosticEvent, int>..ctor
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>..ctor
	|-EnumerableSorter<object, int>..ctor
	|-EnumerableSorter<object, object>..ctor
	|-EnumerableSorter<object, float>..ctor
	|-EnumerableSorter<object, uint>..ctor
	|-EnumerableSorter<float, float>..ctor
	|
	|-RVA: 0xE95A90 Offset: 0xE94090 VA: 0x180E95A90
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE95910 Offset: 0xE93F10 VA: 0x180E95910
	|-EnumerableSorter<char, char>.ComputeKeys
	|
	|-RVA: 0xE957E0 Offset: 0xE93DE0 VA: 0x180E957E0
	|-EnumerableSorter<DiagnosticEvent, int>.ComputeKeys
	|
	|-RVA: 0xE95010 Offset: 0xE93610 VA: 0x180E95010
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0xE95150 Offset: 0xE93750 VA: 0x180E95150
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.ComputeKeys
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.ComputeKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.ComputeKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0xE954E0 Offset: 0xE93AE0 VA: 0x180E954E0
	|-EnumerableSorter<object, int>.ComputeKeys
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0xE94EF0 Offset: 0xE934F0 VA: 0x180E94EF0
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0xE956E0 Offset: 0xE93CE0 VA: 0x180E956E0
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0xE955E0 Offset: 0xE93BE0 VA: 0x180E955E0
	|-EnumerableSorter<float, float>.ComputeKeys
	|
	|-RVA: 0xE95280 Offset: 0xE93880 VA: 0x180E95280
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94C60 Offset: 0xE93260 VA: 0x180E94C60
	|-EnumerableSorter<char, char>.CompareKeys
	|
	|-RVA: 0xE94850 Offset: 0xE92E50 VA: 0x180E94850
	|-EnumerableSorter<DiagnosticEvent, int>.CompareKeys
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.CompareKeys
	|-EnumerableSorter<object, int>.CompareKeys
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0xE94DB0 Offset: 0xE933B0 VA: 0x180E94DB0
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0xE94940 Offset: 0xE92F40 VA: 0x180E94940
	|-EnumerableSorter<object, float>.CompareKeys
	|-EnumerableSorter<float, float>.CompareKeys
	|
	|-RVA: 0xE94A40 Offset: 0xE93040 VA: 0x180E94A40
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareKeys
	*/
}

// Namespace: System.Linq
internal struct Buffer<TElement> // TypeDefIndex: 10751
{
	// Fields
	internal TElement[] items; // 0x0
	internal int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC88A00 Offset: 0xC87000 VA: 0x180C88A00
	|-Buffer<SplineSlice<object>>..ctor
	|
	|-RVA: 0xC89E10 Offset: 0xC88410 VA: 0x180C89E10
	|-Buffer<char>..ctor
	|
	|-RVA: 0xC88500 Offset: 0xC86B00 VA: 0x180C88500
	|-Buffer<Color>..ctor
	|
	|-RVA: 0xC8B750 Offset: 0xC89D50 VA: 0x180C8B750
	|-Buffer<DiagnosticEvent>..ctor
	|
	|-RVA: 0xC8A810 Offset: 0xC88E10 VA: 0x180C8A810
	|-Buffer<Edge>..ctor
	|
	|-RVA: 0xC8AD00 Offset: 0xC89300 VA: 0x180C8AD00
	|-Buffer<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0xC88F80 Offset: 0xC87580 VA: 0x180C88F80
	|-Buffer<int>..ctor
	|
	|-RVA: 0xC8A300 Offset: 0xC88900 VA: 0x180C8A300
	|-Buffer<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0xC86B50 Offset: 0xC85150 VA: 0x180C86B50
	|-Buffer<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0xC87A40 Offset: 0xC86040 VA: 0x180C87A40
	|-Buffer<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0xC89900 Offset: 0xC87F00 VA: 0x180C89900
	|-Buffer<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0xC866C0 Offset: 0xC84CC0 VA: 0x180C866C0
	|-Buffer<object>..ctor
	|
	|-RVA: 0xC87560 Offset: 0xC85B60 VA: 0x180C87560
	|-Buffer<float>..ctor
	|
	|-RVA: 0xC8BC80 Offset: 0xC8A280 VA: 0x180C8BC80
	|-Buffer<uint>..ctor
	|
	|-RVA: 0xC89400 Offset: 0xC87A00 VA: 0x180C89400
	|-Buffer<Vector2>..ctor
	|
	|-RVA: 0xC8B240 Offset: 0xC89840 VA: 0x180C8B240
	|-Buffer<Vector3>..ctor
	|
	|-RVA: 0xC87060 Offset: 0xC85660 VA: 0x180C87060
	|-Buffer<Vector4>..ctor
	|
	|-RVA: 0xC87F50 Offset: 0xC86550 VA: 0x180C87F50
	|-Buffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC865D0 Offset: 0xC84BD0 VA: 0x180C865D0
	|-Buffer<SplineSlice<object>>.ToArray
	|-Buffer<char>.ToArray
	|-Buffer<Color>.ToArray
	|-Buffer<DiagnosticEvent>.ToArray
	|-Buffer<Edge>.ToArray
	|-Buffer<GlyphPairAdjustmentRecord>.ToArray
	|-Buffer<int>.ToArray
	|-Buffer<MarkToBaseAdjustmentRecord>.ToArray
	|-Buffer<MarkToBaseAdjustmentRecord>.ToArray
	|-Buffer<MarkToMarkAdjustmentRecord>.ToArray
	|-Buffer<MarkToMarkAdjustmentRecord>.ToArray
	|-Buffer<object>.ToArray
	|-Buffer<float>.ToArray
	|-Buffer<uint>.ToArray
	|-Buffer<Vector2>.ToArray
	|-Buffer<Vector3>.ToArray
	|-Buffer<Vector4>.ToArray
	|-Buffer<__Il2CppFullySharedGenericType>.ToArray
	*/
}

