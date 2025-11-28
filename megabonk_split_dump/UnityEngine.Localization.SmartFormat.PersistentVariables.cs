// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[Serializable]
public class Variable<T> : IVariableValueChanged, IVariable // TypeDefIndex: 11857
{
	// Fields
	[SerializeField]
	private T m_Value; // 0x0
	[CompilerGenerated]
	private Action<IVariable> ValueChanged; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public void add_ValueChanged(Action<IVariable> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB99590 Offset: 0xB97B90 VA: 0x180B99590
	|-Variable<bool>.add_ValueChanged
	|
	|-RVA: 0xB99750 Offset: 0xB97D50 VA: 0x180B99750
	|-Variable<byte>.add_ValueChanged
	|
	|-RVA: 0xB99960 Offset: 0xB97F60 VA: 0x180B99960
	|-Variable<double>.add_ValueChanged
	|
	|-RVA: 0xB992D0 Offset: 0xB978D0 VA: 0x180B992D0
	|-Variable<short>.add_ValueChanged
	|
	|-RVA: 0xB994E0 Offset: 0xB97AE0 VA: 0x180B994E0
	|-Variable<int>.add_ValueChanged
	|
	|-RVA: 0xB99430 Offset: 0xB97A30 VA: 0x180B99430
	|-Variable<long>.add_ValueChanged
	|
	|-RVA: 0xB99800 Offset: 0xB97E00 VA: 0x180B99800
	|-Variable<object>.add_ValueChanged
	|
	|-RVA: 0xB99220 Offset: 0xB97820 VA: 0x180B99220
	|-Variable<sbyte>.add_ValueChanged
	|
	|-RVA: 0xB99380 Offset: 0xB97980 VA: 0x180B99380
	|-Variable<float>.add_ValueChanged
	|
	|-RVA: 0xB99170 Offset: 0xB97770 VA: 0x180B99170
	|-Variable<ushort>.add_ValueChanged
	|
	|-RVA: 0xB990C0 Offset: 0xB976C0 VA: 0x180B990C0
	|-Variable<uint>.add_ValueChanged
	|
	|-RVA: 0xB998B0 Offset: 0xB97EB0 VA: 0x180B998B0
	|-Variable<ulong>.add_ValueChanged
	|
	|-RVA: 0xB99640 Offset: 0xB97C40 VA: 0x180B99640
	|-Variable<__Il2CppFullySharedGenericType>.add_ValueChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public void remove_ValueChanged(Action<IVariable> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB99F60 Offset: 0xB98560 VA: 0x180B99F60
	|-Variable<bool>.remove_ValueChanged
	|
	|-RVA: 0xB99B90 Offset: 0xB98190 VA: 0x180B99B90
	|-Variable<byte>.remove_ValueChanged
	|
	|-RVA: 0xB9A2D0 Offset: 0xB988D0 VA: 0x180B9A2D0
	|-Variable<double>.remove_ValueChanged
	|
	|-RVA: 0xB99EB0 Offset: 0xB984B0 VA: 0x180B99EB0
	|-Variable<short>.remove_ValueChanged
	|
	|-RVA: 0xB99E00 Offset: 0xB98400 VA: 0x180B99E00
	|-Variable<int>.remove_ValueChanged
	|
	|-RVA: 0xB99C40 Offset: 0xB98240 VA: 0x180B99C40
	|-Variable<long>.remove_ValueChanged
	|
	|-RVA: 0xB9A0C0 Offset: 0xB986C0 VA: 0x180B9A0C0
	|-Variable<object>.remove_ValueChanged
	|
	|-RVA: 0xB9A220 Offset: 0xB98820 VA: 0x180B9A220
	|-Variable<sbyte>.remove_ValueChanged
	|
	|-RVA: 0xB99AE0 Offset: 0xB980E0 VA: 0x180B99AE0
	|-Variable<float>.remove_ValueChanged
	|
	|-RVA: 0xB9A010 Offset: 0xB98610 VA: 0x180B9A010
	|-Variable<ushort>.remove_ValueChanged
	|
	|-RVA: 0xB9A170 Offset: 0xB98770 VA: 0x180B9A170
	|-Variable<uint>.remove_ValueChanged
	|
	|-RVA: 0xB99A30 Offset: 0xB98030 VA: 0x180B99A30
	|-Variable<ulong>.remove_ValueChanged
	|
	|-RVA: 0xB99CF0 Offset: 0xB982F0 VA: 0x180B99CF0
	|-Variable<__Il2CppFullySharedGenericType>.remove_ValueChanged
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	|-Variable<bool>.get_Value
	|-Variable<byte>.get_Value
	|-Variable<sbyte>.get_Value
	|
	|-RVA: 0xB99A20 Offset: 0xB98020 VA: 0x180B99A20
	|-Variable<double>.get_Value
	|
	|-RVA: 0xB99A10 Offset: 0xB98010 VA: 0x180B99A10
	|-Variable<short>.get_Value
	|-Variable<ushort>.get_Value
	|
	|-RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	|-Variable<int>.get_Value
	|-Variable<uint>.get_Value
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-Variable<long>.get_Value
	|-Variable<object>.get_Value
	|-Variable<ulong>.get_Value
	|
	|-RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	|-Variable<float>.get_Value
	|
	|-RVA: 0x86E550 Offset: 0x86CB50 VA: 0x18086E550
	|-Variable<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9A890 Offset: 0xB98E90 VA: 0x180B9A890
	|-Variable<bool>.set_Value
	|
	|-RVA: 0xB9A930 Offset: 0xB98F30 VA: 0x180B9A930
	|-Variable<byte>.set_Value
	|
	|-RVA: 0xB9A480 Offset: 0xB98A80 VA: 0x180B9A480
	|-Variable<double>.set_Value
	|
	|-RVA: 0xB9A700 Offset: 0xB98D00 VA: 0x180B9A700
	|-Variable<short>.set_Value
	|
	|-RVA: 0xB9A610 Offset: 0xB98C10 VA: 0x180B9A610
	|-Variable<int>.set_Value
	|
	|-RVA: 0xB9A400 Offset: 0xB98A00 VA: 0x180B9A400
	|-Variable<long>.set_Value
	|
	|-RVA: 0xB9A690 Offset: 0xB98C90 VA: 0x180B9A690
	|-Variable<object>.set_Value
	|
	|-RVA: 0xB9A590 Offset: 0xB98B90 VA: 0x180B9A590
	|-Variable<sbyte>.set_Value
	|
	|-RVA: 0xB9A800 Offset: 0xB98E00 VA: 0x180B9A800
	|-Variable<float>.set_Value
	|
	|-RVA: 0xB9A510 Offset: 0xB98B10 VA: 0x180B9A510
	|-Variable<ushort>.set_Value
	|
	|-RVA: 0xB9A380 Offset: 0xB98980 VA: 0x180B9A380
	|-Variable<uint>.set_Value
	|
	|-RVA: 0xB9A780 Offset: 0xB98D80 VA: 0x180B9A780
	|-Variable<ulong>.set_Value
	|
	|-RVA: 0xB9A9B0 Offset: 0xB98FB0 VA: 0x180B9A9B0
	|-Variable<__Il2CppFullySharedGenericType>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public object GetSourceValue(ISelectorInfo _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98B90 Offset: 0xB97190 VA: 0x180B98B90
	|-Variable<bool>.GetSourceValue
	|-Variable<byte>.GetSourceValue
	|-Variable<sbyte>.GetSourceValue
	|
	|-RVA: 0xB98C20 Offset: 0xB97220 VA: 0x180B98C20
	|-Variable<double>.GetSourceValue
	|
	|-RVA: 0xB98AC0 Offset: 0xB970C0 VA: 0x180B98AC0
	|-Variable<short>.GetSourceValue
	|-Variable<ushort>.GetSourceValue
	|
	|-RVA: 0xB98BF0 Offset: 0xB971F0 VA: 0x180B98BF0
	|-Variable<int>.GetSourceValue
	|-Variable<uint>.GetSourceValue
	|
	|-RVA: 0xB98BC0 Offset: 0xB971C0 VA: 0x180B98BC0
	|-Variable<long>.GetSourceValue
	|-Variable<ulong>.GetSourceValue
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-Variable<object>.GetSourceValue
	|
	|-RVA: 0xB98C50 Offset: 0xB97250 VA: 0x180B98C50
	|-Variable<float>.GetSourceValue
	|
	|-RVA: 0xB98AF0 Offset: 0xB970F0 VA: 0x180B98AF0
	|-Variable<__Il2CppFullySharedGenericType>.GetSourceValue
	*/

	// RVA: -1 Offset: -1
	private void SendValueChangedEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98C80 Offset: 0xB97280 VA: 0x180B98C80
	|-Variable<bool>.SendValueChangedEvent
	|-Variable<byte>.SendValueChangedEvent
	|-Variable<double>.SendValueChangedEvent
	|-Variable<short>.SendValueChangedEvent
	|-Variable<int>.SendValueChangedEvent
	|-Variable<long>.SendValueChangedEvent
	|-Variable<object>.SendValueChangedEvent
	|-Variable<sbyte>.SendValueChangedEvent
	|-Variable<float>.SendValueChangedEvent
	|-Variable<ushort>.SendValueChangedEvent
	|-Variable<uint>.SendValueChangedEvent
	|-Variable<ulong>.SendValueChangedEvent
	|
	|-RVA: 0xB98CA0 Offset: 0xB972A0 VA: 0x180B98CA0
	|-Variable<__Il2CppFullySharedGenericType>.SendValueChangedEvent
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB98D80 Offset: 0xB97380 VA: 0x180B98D80
	|-Variable<bool>.ToString
	|
	|-RVA: 0xB99090 Offset: 0xB97690 VA: 0x180B99090
	|-Variable<byte>.ToString
	|
	|-RVA: 0xB98FA0 Offset: 0xB975A0 VA: 0x180B98FA0
	|-Variable<double>.ToString
	|
	|-RVA: 0xB98D50 Offset: 0xB97350 VA: 0x180B98D50
	|-Variable<short>.ToString
	|
	|-RVA: 0xB98CF0 Offset: 0xB972F0 VA: 0x180B98CF0
	|-Variable<int>.ToString
	|
	|-RVA: 0xB99030 Offset: 0xB97630 VA: 0x180B99030
	|-Variable<long>.ToString
	|
	|-RVA: 0xB98DD0 Offset: 0xB973D0 VA: 0x180B98DD0
	|-Variable<object>.ToString
	|
	|-RVA: 0xB98E00 Offset: 0xB97400 VA: 0x180B98E00
	|-Variable<sbyte>.ToString
	|
	|-RVA: 0xB99060 Offset: 0xB97660 VA: 0x180B99060
	|-Variable<float>.ToString
	|
	|-RVA: 0xB98D20 Offset: 0xB97320 VA: 0x180B98D20
	|-Variable<ushort>.ToString
	|
	|-RVA: 0xB99000 Offset: 0xB97600 VA: 0x180B99000
	|-Variable<uint>.ToString
	|
	|-RVA: 0xB98FD0 Offset: 0xB975D0 VA: 0x180B98FD0
	|-Variable<ulong>.ToString
	|
	|-RVA: 0xB98E30 Offset: 0xB97430 VA: 0x180B98E30
	|-Variable<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-Variable<bool>..ctor
	|-Variable<byte>..ctor
	|-Variable<double>..ctor
	|-Variable<short>..ctor
	|-Variable<int>..ctor
	|-Variable<long>..ctor
	|-Variable<object>..ctor
	|-Variable<sbyte>..ctor
	|-Variable<float>..ctor
	|-Variable<ushort>..ctor
	|-Variable<uint>..ctor
	|-Variable<ulong>..ctor
	|-Variable<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Boolean", null)]
[Serializable]
public class BoolVariable : Variable<bool> // TypeDefIndex: 11858
{
	// Methods

	// RVA: 0x1EE5B10 Offset: 0x1EE4110 VA: 0x181EE5B10
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Signed Byte", null)]
[Serializable]
public class SByteVariable : Variable<sbyte> // TypeDefIndex: 11859
{
	// Methods

	// RVA: 0x1EF9330 Offset: 0x1EF7930 VA: 0x181EF9330
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Byte", null)]
[Serializable]
public class ByteVariable : Variable<byte> // TypeDefIndex: 11860
{
	// Methods

	// RVA: 0x1EE5B50 Offset: 0x1EE4150 VA: 0x181EE5B50
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Short", null)]
[Serializable]
public class ShortVariable : Variable<short> // TypeDefIndex: 11861
{
	// Methods

	// RVA: 0x1EF9430 Offset: 0x1EF7A30 VA: 0x181EF9430
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Unsigned Short", null)]
[Serializable]
public class UShortVariable : Variable<ushort> // TypeDefIndex: 11862
{
	// Methods

	// RVA: 0x1EFEB80 Offset: 0x1EFD180 VA: 0x181EFEB80
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Integer", null)]
[Serializable]
public class IntVariable : Variable<int> // TypeDefIndex: 11863
{
	// Methods

	// RVA: 0x1EEB690 Offset: 0x1EE9C90 VA: 0x181EEB690
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Unsigned Integer", null)]
[Serializable]
public class UIntVariable : Variable<uint> // TypeDefIndex: 11864
{
	// Methods

	// RVA: 0x1EFEB00 Offset: 0x1EFD100 VA: 0x181EFEB00
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Long", null)]
[Serializable]
public class LongVariable : Variable<long> // TypeDefIndex: 11865
{
	// Methods

	// RVA: 0x1EF2020 Offset: 0x1EF0620 VA: 0x181EF2020
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Unsigned Long", null)]
[Serializable]
public class ULongVariable : Variable<ulong> // TypeDefIndex: 11866
{
	// Methods

	// RVA: 0x1EFEB40 Offset: 0x1EFD140 VA: 0x181EFEB40
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("String", null)]
[Serializable]
public class StringVariable : Variable<string> // TypeDefIndex: 11867
{
	// Methods

	// RVA: 0x1EFA0C0 Offset: 0x1EF86C0 VA: 0x181EFA0C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Float", null)]
[Serializable]
public class FloatVariable : Variable<float> // TypeDefIndex: 11868
{
	// Methods

	// RVA: 0x1EE8FD0 Offset: 0x1EE75D0 VA: 0x181EE8FD0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Double", null)]
[Serializable]
public class DoubleVariable : Variable<double> // TypeDefIndex: 11869
{
	// Methods

	// RVA: 0x1EE8F90 Offset: 0x1EE7590 VA: 0x181EE8F90
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Object Reference", null)]
[Serializable]
public class ObjectVariable : Variable<Object> // TypeDefIndex: 11870
{
	// Methods

	// RVA: 0x1EF33F0 Offset: 0x1EF19F0 VA: 0x181EF33F0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
public interface IVariableGroup // TypeDefIndex: 11871
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue(string key, out IVariable value);
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
public interface IVariable // TypeDefIndex: 11872
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetSourceValue(ISelectorInfo selector);
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
public interface IMetadataVariable : IVariable // TypeDefIndex: 11873
{
	// Properties
	public abstract string VariableName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_VariableName();
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
public interface IVariableValueChanged : IVariable // TypeDefIndex: 11874
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_ValueChanged(Action<IVariable> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_ValueChanged(Action<IVariable> value);
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DisplayName("Nested Variables Group", null)]
public class NestedVariablesGroup : Variable<VariablesGroupAsset>, IVariableGroup // TypeDefIndex: 11875
{
	// Methods

	// RVA: 0x1EF3330 Offset: 0x1EF1930 VA: 0x181EF3330 Slot: 7
	public bool TryGetValue(string name, out IVariable value) { }

	// RVA: 0x1EF32F0 Offset: 0x1EF18F0 VA: 0x181EF32F0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[Serializable]
internal class VariableNameValuePair // TypeDefIndex: 11876
{
	// Fields
	public string name; // 0x10
	[SerializeReference]
	public IVariable variable; // 0x18

	// Methods

	// RVA: 0x1EFEFB0 Offset: 0x1EFD5B0 VA: 0x181EFEFB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.PersistentVariables
[DefaultMember("Item")]
[CreateAssetMenu(menuName = "Localization/Variables Group")]
public class VariablesGroupAsset : ScriptableObject, IVariableGroup, IVariable, IDictionary<string, IVariable>, ICollection<KeyValuePair<string, IVariable>>, IEnumerable<KeyValuePair<string, IVariable>>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 11880
{
	// Fields
	[SerializeField]
	internal List<VariableNameValuePair> m_Variables; // 0x18
	private Dictionary<string, VariableNameValuePair> m_VariableLookup; // 0x20

	// Properties
	public int Count { get; }
	public ICollection<string> Keys { get; }
	public ICollection<IVariable> Values { get; }
	public bool IsReadOnly { get; }
	public IVariable Item { get; set; }

	// Methods

	// RVA: 0x1EFFBE0 Offset: 0x1EFE1E0 VA: 0x181EFFBE0 Slot: 14
	public int get_Count() { }

	// RVA: 0x1EFFC90 Offset: 0x1EFE290 VA: 0x181EFFC90 Slot: 8
	public ICollection<string> get_Keys() { }

	// RVA: 0x1EFFCE0 Offset: 0x1EFE2E0 VA: 0x181EFFCE0 Slot: 9
	public ICollection<IVariable> get_Values() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	public bool get_IsReadOnly() { }

	// RVA: 0x1EFFC30 Offset: 0x1EFE230 VA: 0x181EFFC30 Slot: 6
	public IVariable get_Item(string name) { }

	// RVA: 0x1EFFE40 Offset: 0x1EFE440 VA: 0x181EFFE40 Slot: 7
	public void set_Item(string name, IVariable value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 5
	public object GetSourceValue(ISelectorInfo _) { }

	// RVA: 0x1EFFB20 Offset: 0x1EFE120 VA: 0x181EFFB20 Slot: 13
	public bool TryGetValue(string name, out IVariable value) { }

	// RVA: 0x1EFF0A0 Offset: 0x1EFD6A0 VA: 0x181EFF0A0 Slot: 11
	public void Add(string name, IVariable variable) { }

	// RVA: 0x1EFF040 Offset: 0x1EFD640 VA: 0x181EFF040 Slot: 16
	public void Add(KeyValuePair<string, IVariable> item) { }

	// RVA: 0x1EFF910 Offset: 0x1EFDF10 VA: 0x181EFF910 Slot: 12
	public bool Remove(string name) { }

	// RVA: 0x1EFF9D0 Offset: 0x1EFDFD0 VA: 0x181EFF9D0 Slot: 20
	public bool Remove(KeyValuePair<string, IVariable> item) { }

	// RVA: 0x1EFF370 Offset: 0x1EFD970 VA: 0x181EFF370 Slot: 10
	public bool ContainsKey(string name) { }

	// RVA: 0x1EFF3D0 Offset: 0x1EFD9D0 VA: 0x181EFF3D0 Slot: 18
	public bool Contains(KeyValuePair<string, IVariable> item) { }

	// RVA: 0x1EFF4B0 Offset: 0x1EFDAB0 VA: 0x181EFF4B0 Slot: 19
	public void CopyTo(KeyValuePair<string, IVariable>[] array, int arrayIndex) { }

	[IteratorStateMachine(typeof(VariablesGroupAsset.<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__22))]
	// RVA: 0x1EFFAB0 Offset: 0x1EFE0B0 VA: 0x181EFFAB0 Slot: 21
	private IEnumerator<KeyValuePair<string, IVariable>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.IVariable>>.GetEnumerator() { }

	[IteratorStateMachine(typeof(VariablesGroupAsset.<GetEnumerator>d__23))]
	// RVA: 0x1EFF6D0 Offset: 0x1EFDCD0 VA: 0x181EFF6D0 Slot: 22
	public IEnumerator GetEnumerator() { }

	[Obsolete("Please use ContainsKey instead.", False)]
	// RVA: 0x1EFF370 Offset: 0x1EFD970 VA: 0x181EFF370
	public bool ContainsName(string name) { }

	// RVA: 0x1EFF2E0 Offset: 0x1EFD8E0 VA: 0x181EFF2E0 Slot: 17
	public void Clear() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 23
	public void OnBeforeSerialize() { }

	// RVA: 0x1EFF740 Offset: 0x1EFDD40 VA: 0x181EFF740 Slot: 24
	public void OnAfterDeserialize() { }

	// RVA: 0x1EEB4D0 Offset: 0x1EE9AD0 VA: 0x181EEB4D0
	public void .ctor() { }
}

