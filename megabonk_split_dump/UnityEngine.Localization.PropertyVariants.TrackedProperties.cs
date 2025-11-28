// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
public interface IStringProperty : ITrackedProperty // TypeDefIndex: 12047
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetValueAsString(LocaleIdentifier localeIdentifier);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetValueFromString(LocaleIdentifier localeIdentifier, string value);
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
public interface ITrackedProperty // TypeDefIndex: 12048
{
	// Properties
	public abstract string PropertyPath { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_PropertyPath();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_PropertyPath(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool HasVariant(LocaleIdentifier localeIdentifier);
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class LocalizedAssetProperty : ITrackedProperty // TypeDefIndex: 12049
{
	// Fields
	[SerializeReference]
	private LocalizedAssetBase m_Localized; // 0x10
	[SerializeField]
	private string m_PropertyPath; // 0x18

	// Properties
	public LocalizedAssetBase LocalizedObject { get; set; }
	public string PropertyPath { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LocalizedAssetBase get_LocalizedObject() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_LocalizedObject(LocalizedAssetBase value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 4
	public string get_PropertyPath() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 5
	public void set_PropertyPath(string value) { }

	// RVA: 0x1F08B00 Offset: 0x1F07100 VA: 0x181F08B00 Slot: 6
	public bool HasVariant(LocaleIdentifier localeIdentifier) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class LocalizedStringProperty : ITrackedProperty // TypeDefIndex: 12050
{
	// Fields
	[SerializeField]
	private LocalizedString m_Localized; // 0x10
	[SerializeField]
	private string m_PropertyPath; // 0x18

	// Properties
	public LocalizedString LocalizedString { get; set; }
	public string PropertyPath { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LocalizedString get_LocalizedString() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_LocalizedString(LocalizedString value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 4
	public string get_PropertyPath() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 5
	public void set_PropertyPath(string value) { }

	// RVA: 0x1F08B00 Offset: 0x1F07100 VA: 0x181F08B00 Slot: 6
	public bool HasVariant(LocaleIdentifier localeIdentifier) { }

	// RVA: 0x1F08CE0 Offset: 0x1F072E0 VA: 0x181F08CE0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
public interface ITrackedPropertyValue<T> : ITrackedProperty // TypeDefIndex: 12051
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool GetValue(LocaleIdentifier localeIdentifier, out T foundValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITrackedPropertyValue<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out T foundValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITrackedPropertyValue<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetValue(LocaleIdentifier localeIdentifier, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITrackedPropertyValue<__Il2CppFullySharedGenericType>.SetValue
	*/
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
internal interface ITrackedPropertyRemoveVariant // TypeDefIndex: 12052
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RemoveVariant(LocaleIdentifier localeIdentifier);
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class TrackedProperty<TPrimitive> : ITrackedPropertyValue<TPrimitive>, ITrackedProperty, IStringProperty, ISerializationCallbackReceiver, ITrackedPropertyRemoveVariant // TypeDefIndex: 12054
{
	// Fields
	[SerializeField]
	private string m_PropertyPath; // 0x0
	[SerializeField]
	private List<TrackedProperty.LocaleIdentifierValuePair<TPrimitive>> m_VariantData; // 0x0
	internal Dictionary<LocaleIdentifier, TrackedProperty.LocaleIdentifierValuePair<TPrimitive>> m_VariantLookup; // 0x0

	// Properties
	public string PropertyPath { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public string get_PropertyPath() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-TrackedProperty<bool>.get_PropertyPath
	|-TrackedProperty<byte>.get_PropertyPath
	|-TrackedProperty<char>.get_PropertyPath
	|-TrackedProperty<double>.get_PropertyPath
	|-TrackedProperty<short>.get_PropertyPath
	|-TrackedProperty<int>.get_PropertyPath
	|-TrackedProperty<long>.get_PropertyPath
	|-TrackedProperty<object>.get_PropertyPath
	|-TrackedProperty<sbyte>.get_PropertyPath
	|-TrackedProperty<float>.get_PropertyPath
	|-TrackedProperty<ushort>.get_PropertyPath
	|-TrackedProperty<uint>.get_PropertyPath
	|-TrackedProperty<ulong>.get_PropertyPath
	|-TrackedProperty<__Il2CppFullySharedGenericType>.get_PropertyPath
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_PropertyPath(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-TrackedProperty<bool>.set_PropertyPath
	|-TrackedProperty<byte>.set_PropertyPath
	|-TrackedProperty<char>.set_PropertyPath
	|-TrackedProperty<double>.set_PropertyPath
	|-TrackedProperty<short>.set_PropertyPath
	|-TrackedProperty<int>.set_PropertyPath
	|-TrackedProperty<long>.set_PropertyPath
	|-TrackedProperty<object>.set_PropertyPath
	|-TrackedProperty<sbyte>.set_PropertyPath
	|-TrackedProperty<float>.set_PropertyPath
	|-TrackedProperty<ushort>.set_PropertyPath
	|-TrackedProperty<uint>.set_PropertyPath
	|-TrackedProperty<ulong>.set_PropertyPath
	|-TrackedProperty<__Il2CppFullySharedGenericType>.set_PropertyPath
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool HasVariant(LocaleIdentifier localeIdentifier) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54D40 Offset: 0xA53340 VA: 0x180A54D40
	|-TrackedProperty<bool>.HasVariant
	|-TrackedProperty<byte>.HasVariant
	|-TrackedProperty<char>.HasVariant
	|-TrackedProperty<double>.HasVariant
	|-TrackedProperty<short>.HasVariant
	|-TrackedProperty<int>.HasVariant
	|-TrackedProperty<long>.HasVariant
	|-TrackedProperty<object>.HasVariant
	|-TrackedProperty<sbyte>.HasVariant
	|-TrackedProperty<float>.HasVariant
	|-TrackedProperty<ushort>.HasVariant
	|-TrackedProperty<uint>.HasVariant
	|-TrackedProperty<ulong>.HasVariant
	|
	|-RVA: 0xA54CE0 Offset: 0xA532E0 VA: 0x180A54CE0
	|-TrackedProperty<__Il2CppFullySharedGenericType>.HasVariant
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public void RemoveVariant(LocaleIdentifier localeIdentifier) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA555B0 Offset: 0xA53BB0 VA: 0x180A555B0
	|-TrackedProperty<bool>.RemoveVariant
	|-TrackedProperty<byte>.RemoveVariant
	|-TrackedProperty<char>.RemoveVariant
	|-TrackedProperty<double>.RemoveVariant
	|-TrackedProperty<short>.RemoveVariant
	|-TrackedProperty<int>.RemoveVariant
	|-TrackedProperty<long>.RemoveVariant
	|-TrackedProperty<object>.RemoveVariant
	|-TrackedProperty<sbyte>.RemoveVariant
	|-TrackedProperty<float>.RemoveVariant
	|-TrackedProperty<ushort>.RemoveVariant
	|-TrackedProperty<uint>.RemoveVariant
	|-TrackedProperty<ulong>.RemoveVariant
	|
	|-RVA: 0xA555F0 Offset: 0xA53BF0 VA: 0x180A555F0
	|-TrackedProperty<__Il2CppFullySharedGenericType>.RemoveVariant
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool GetValue(LocaleIdentifier localeIdentifier, out TPrimitive foundValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54880 Offset: 0xA52E80 VA: 0x180A54880
	|-TrackedProperty<bool>.GetValue
	|-TrackedProperty<byte>.GetValue
	|-TrackedProperty<sbyte>.GetValue
	|
	|-RVA: 0xA54430 Offset: 0xA52A30 VA: 0x180A54430
	|-TrackedProperty<char>.GetValue
	|-TrackedProperty<short>.GetValue
	|-TrackedProperty<ushort>.GetValue
	|
	|-RVA: 0xA54740 Offset: 0xA52D40 VA: 0x180A54740
	|-TrackedProperty<double>.GetValue
	|-TrackedProperty<long>.GetValue
	|-TrackedProperty<ulong>.GetValue
	|
	|-RVA: 0xA546D0 Offset: 0xA52CD0 VA: 0x180A546D0
	|-TrackedProperty<int>.GetValue
	|-TrackedProperty<float>.GetValue
	|-TrackedProperty<uint>.GetValue
	|
	|-RVA: 0xA54B90 Offset: 0xA53190 VA: 0x180A54B90
	|-TrackedProperty<object>.GetValue
	|
	|-RVA: 0xA54570 Offset: 0xA52B70 VA: 0x180A54570
	|-TrackedProperty<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out TPrimitive foundValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54360 Offset: 0xA52960 VA: 0x180A54360
	|-TrackedProperty<bool>.GetValue
	|-TrackedProperty<byte>.GetValue
	|-TrackedProperty<sbyte>.GetValue
	|
	|-RVA: 0xA544A0 Offset: 0xA52AA0 VA: 0x180A544A0
	|-TrackedProperty<char>.GetValue
	|-TrackedProperty<short>.GetValue
	|-TrackedProperty<ushort>.GetValue
	|
	|-RVA: 0xA547B0 Offset: 0xA52DB0 VA: 0x180A547B0
	|-TrackedProperty<double>.GetValue
	|-TrackedProperty<long>.GetValue
	|-TrackedProperty<ulong>.GetValue
	|
	|-RVA: 0xA54C10 Offset: 0xA53210 VA: 0x180A54C10
	|-TrackedProperty<int>.GetValue
	|-TrackedProperty<float>.GetValue
	|-TrackedProperty<uint>.GetValue
	|
	|-RVA: 0xA548F0 Offset: 0xA52EF0 VA: 0x180A548F0
	|-TrackedProperty<object>.GetValue
	|
	|-RVA: 0xA549D0 Offset: 0xA52FD0 VA: 0x180A549D0
	|-TrackedProperty<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void SetValue(LocaleIdentifier localeIdentifier, TPrimitive value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA56410 Offset: 0xA54A10 VA: 0x180A56410
	|-TrackedProperty<bool>.SetValue
	|-TrackedProperty<byte>.SetValue
	|-TrackedProperty<sbyte>.SetValue
	|
	|-RVA: 0xA562F0 Offset: 0xA548F0 VA: 0x180A562F0
	|-TrackedProperty<char>.SetValue
	|-TrackedProperty<short>.SetValue
	|-TrackedProperty<ushort>.SetValue
	|
	|-RVA: 0xA56790 Offset: 0xA54D90 VA: 0x180A56790
	|-TrackedProperty<double>.SetValue
	|
	|-RVA: 0xA561D0 Offset: 0xA547D0 VA: 0x180A561D0
	|-TrackedProperty<int>.SetValue
	|-TrackedProperty<uint>.SetValue
	|
	|-RVA: 0xA560B0 Offset: 0xA546B0 VA: 0x180A560B0
	|-TrackedProperty<long>.SetValue
	|-TrackedProperty<ulong>.SetValue
	|
	|-RVA: 0xA56660 Offset: 0xA54C60 VA: 0x180A56660
	|-TrackedProperty<object>.SetValue
	|
	|-RVA: 0xA56530 Offset: 0xA54B30 VA: 0x180A56530
	|-TrackedProperty<float>.SetValue
	|
	|-RVA: 0xA568C0 Offset: 0xA54EC0 VA: 0x180A568C0
	|-TrackedProperty<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public string GetValueAsString(LocaleIdentifier localeIdentifier) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA53E70 Offset: 0xA52470 VA: 0x180A53E70
	|-TrackedProperty<bool>.GetValueAsString
	|-TrackedProperty<byte>.GetValueAsString
	|-TrackedProperty<sbyte>.GetValueAsString
	|
	|-RVA: 0xA53630 Offset: 0xA51C30 VA: 0x180A53630
	|-TrackedProperty<char>.GetValueAsString
	|-TrackedProperty<short>.GetValueAsString
	|-TrackedProperty<ushort>.GetValueAsString
	|
	|-RVA: 0xA53CC0 Offset: 0xA522C0 VA: 0x180A53CC0
	|-TrackedProperty<double>.GetValueAsString
	|
	|-RVA: 0xA53D50 Offset: 0xA52350 VA: 0x180A53D50
	|-TrackedProperty<int>.GetValueAsString
	|-TrackedProperty<uint>.GetValueAsString
	|
	|-RVA: 0xA53FA0 Offset: 0xA525A0 VA: 0x180A53FA0
	|-TrackedProperty<long>.GetValueAsString
	|-TrackedProperty<ulong>.GetValueAsString
	|
	|-RVA: 0xA53F00 Offset: 0xA52500 VA: 0x180A53F00
	|-TrackedProperty<object>.GetValueAsString
	|
	|-RVA: 0xA53DE0 Offset: 0xA523E0 VA: 0x180A53DE0
	|-TrackedProperty<float>.GetValueAsString
	|
	|-RVA: 0xA538B0 Offset: 0xA51EB0 VA: 0x180A538B0
	|-TrackedProperty<__Il2CppFullySharedGenericType>.GetValueAsString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA53AE0 Offset: 0xA520E0 VA: 0x180A53AE0
	|-TrackedProperty<bool>.GetValueAsString
	|-TrackedProperty<byte>.GetValueAsString
	|-TrackedProperty<sbyte>.GetValueAsString
	|
	|-RVA: 0xA536C0 Offset: 0xA51CC0 VA: 0x180A536C0
	|-TrackedProperty<char>.GetValueAsString
	|-TrackedProperty<short>.GetValueAsString
	|-TrackedProperty<ushort>.GetValueAsString
	|
	|-RVA: 0xA54120 Offset: 0xA52720 VA: 0x180A54120
	|-TrackedProperty<double>.GetValueAsString
	|
	|-RVA: 0xA539F0 Offset: 0xA51FF0 VA: 0x180A539F0
	|-TrackedProperty<int>.GetValueAsString
	|-TrackedProperty<uint>.GetValueAsString
	|
	|-RVA: 0xA53BD0 Offset: 0xA521D0 VA: 0x180A53BD0
	|-TrackedProperty<long>.GetValueAsString
	|-TrackedProperty<ulong>.GetValueAsString
	|
	|-RVA: 0xA537B0 Offset: 0xA51DB0 VA: 0x180A537B0
	|-TrackedProperty<object>.GetValueAsString
	|
	|-RVA: 0xA54030 Offset: 0xA52630 VA: 0x180A54030
	|-TrackedProperty<float>.GetValueAsString
	|
	|-RVA: 0xA54210 Offset: 0xA52810 VA: 0x180A54210
	|-TrackedProperty<__Il2CppFullySharedGenericType>.GetValueAsString
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void SetValueFromString(LocaleIdentifier localeIdentifier, string stringValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA557A0 Offset: 0xA53DA0 VA: 0x180A557A0
	|-TrackedProperty<bool>.SetValueFromString
	|-TrackedProperty<byte>.SetValueFromString
	|-TrackedProperty<sbyte>.SetValueFromString
	|
	|-RVA: 0xA55A20 Offset: 0xA54020 VA: 0x180A55A20
	|-TrackedProperty<char>.SetValueFromString
	|-TrackedProperty<short>.SetValueFromString
	|-TrackedProperty<ushort>.SetValueFromString
	|
	|-RVA: 0xA55CB0 Offset: 0xA542B0 VA: 0x180A55CB0
	|-TrackedProperty<double>.SetValueFromString
	|
	|-RVA: 0xA55E00 Offset: 0xA54400 VA: 0x180A55E00
	|-TrackedProperty<int>.SetValueFromString
	|-TrackedProperty<uint>.SetValueFromString
	|
	|-RVA: 0xA558E0 Offset: 0xA53EE0 VA: 0x180A558E0
	|-TrackedProperty<long>.SetValueFromString
	|-TrackedProperty<ulong>.SetValueFromString
	|
	|-RVA: 0xA55B60 Offset: 0xA54160 VA: 0x180A55B60
	|-TrackedProperty<object>.SetValueFromString
	|
	|-RVA: 0xA55650 Offset: 0xA53C50 VA: 0x180A55650
	|-TrackedProperty<float>.SetValueFromString
	|
	|-RVA: 0xA55F40 Offset: 0xA54540 VA: 0x180A55F40
	|-TrackedProperty<__Il2CppFullySharedGenericType>.SetValueFromString
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual string ConvertToString(TPrimitive value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA52EF0 Offset: 0xA514F0 VA: 0x180A52EF0
	|-TrackedProperty<bool>.ConvertToString
	|
	|-RVA: 0xA534E0 Offset: 0xA51AE0 VA: 0x180A534E0
	|-TrackedProperty<byte>.ConvertToString
	|
	|-RVA: 0xA53460 Offset: 0xA51A60 VA: 0x180A53460
	|-TrackedProperty<char>.ConvertToString
	|
	|-RVA: 0xA532E0 Offset: 0xA518E0 VA: 0x180A532E0
	|-TrackedProperty<double>.ConvertToString
	|
	|-RVA: 0xA53160 Offset: 0xA51760 VA: 0x180A53160
	|-TrackedProperty<short>.ConvertToString
	|
	|-RVA: 0xA533E0 Offset: 0xA519E0 VA: 0x180A533E0
	|-TrackedProperty<int>.ConvertToString
	|
	|-RVA: 0xA52F70 Offset: 0xA51570 VA: 0x180A52F70
	|-TrackedProperty<long>.ConvertToString
	|
	|-RVA: 0xA535E0 Offset: 0xA51BE0 VA: 0x180A535E0
	|-TrackedProperty<object>.ConvertToString
	|
	|-RVA: 0xA53260 Offset: 0xA51860 VA: 0x180A53260
	|-TrackedProperty<sbyte>.ConvertToString
	|
	|-RVA: 0xA53360 Offset: 0xA51960 VA: 0x180A53360
	|-TrackedProperty<float>.ConvertToString
	|
	|-RVA: 0xA531E0 Offset: 0xA517E0 VA: 0x180A531E0
	|-TrackedProperty<ushort>.ConvertToString
	|
	|-RVA: 0xA53560 Offset: 0xA51B60 VA: 0x180A53560
	|-TrackedProperty<uint>.ConvertToString
	|
	|-RVA: 0xA52FF0 Offset: 0xA515F0 VA: 0x180A52FF0
	|-TrackedProperty<ulong>.ConvertToString
	|
	|-RVA: 0xA53070 Offset: 0xA51670 VA: 0x180A53070
	|-TrackedProperty<__Il2CppFullySharedGenericType>.ConvertToString
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected virtual TPrimitive ConvertFromString(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA52770 Offset: 0xA50D70 VA: 0x180A52770
	|-TrackedProperty<bool>.ConvertFromString
	|
	|-RVA: 0xA52A40 Offset: 0xA51040 VA: 0x180A52A40
	|-TrackedProperty<byte>.ConvertFromString
	|
	|-RVA: 0xA52D10 Offset: 0xA51310 VA: 0x180A52D10
	|-TrackedProperty<char>.ConvertFromString
	|
	|-RVA: 0xA52E00 Offset: 0xA51400 VA: 0x180A52E00
	|-TrackedProperty<double>.ConvertFromString
	|
	|-RVA: 0xA52860 Offset: 0xA50E60 VA: 0x180A52860
	|-TrackedProperty<short>.ConvertFromString
	|
	|-RVA: 0xA52B30 Offset: 0xA51130 VA: 0x180A52B30
	|-TrackedProperty<int>.ConvertFromString
	|
	|-RVA: 0xA52950 Offset: 0xA50F50 VA: 0x180A52950
	|-TrackedProperty<long>.ConvertFromString
	|
	|-RVA: 0xA524A0 Offset: 0xA50AA0 VA: 0x180A524A0
	|-TrackedProperty<object>.ConvertFromString
	|
	|-RVA: 0xA522C0 Offset: 0xA508C0 VA: 0x180A522C0
	|-TrackedProperty<sbyte>.ConvertFromString
	|
	|-RVA: 0xA52C20 Offset: 0xA51220 VA: 0x180A52C20
	|-TrackedProperty<float>.ConvertFromString
	|
	|-RVA: 0xA52590 Offset: 0xA50B90 VA: 0x180A52590
	|-TrackedProperty<ushort>.ConvertFromString
	|
	|-RVA: 0xA523B0 Offset: 0xA509B0 VA: 0x180A523B0
	|-TrackedProperty<uint>.ConvertFromString
	|
	|-RVA: 0xA52680 Offset: 0xA50C80 VA: 0x180A52680
	|-TrackedProperty<ulong>.ConvertFromString
	|
	|-RVA: 0xA52190 Offset: 0xA50790 VA: 0x180A52190
	|-TrackedProperty<__Il2CppFullySharedGenericType>.ConvertFromString
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55160 Offset: 0xA53760 VA: 0x180A55160
	|-TrackedProperty<bool>.OnBeforeSerialize
	|-TrackedProperty<byte>.OnBeforeSerialize
	|-TrackedProperty<char>.OnBeforeSerialize
	|-TrackedProperty<double>.OnBeforeSerialize
	|-TrackedProperty<short>.OnBeforeSerialize
	|-TrackedProperty<int>.OnBeforeSerialize
	|-TrackedProperty<long>.OnBeforeSerialize
	|-TrackedProperty<object>.OnBeforeSerialize
	|-TrackedProperty<sbyte>.OnBeforeSerialize
	|-TrackedProperty<float>.OnBeforeSerialize
	|-TrackedProperty<ushort>.OnBeforeSerialize
	|-TrackedProperty<uint>.OnBeforeSerialize
	|-TrackedProperty<ulong>.OnBeforeSerialize
	|
	|-RVA: 0xA55360 Offset: 0xA53960 VA: 0x180A55360
	|-TrackedProperty<__Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54D80 Offset: 0xA53380 VA: 0x180A54D80
	|-TrackedProperty<bool>.OnAfterDeserialize
	|-TrackedProperty<byte>.OnAfterDeserialize
	|-TrackedProperty<char>.OnAfterDeserialize
	|-TrackedProperty<double>.OnAfterDeserialize
	|-TrackedProperty<short>.OnAfterDeserialize
	|-TrackedProperty<int>.OnAfterDeserialize
	|-TrackedProperty<long>.OnAfterDeserialize
	|-TrackedProperty<object>.OnAfterDeserialize
	|-TrackedProperty<sbyte>.OnAfterDeserialize
	|-TrackedProperty<float>.OnAfterDeserialize
	|-TrackedProperty<ushort>.OnAfterDeserialize
	|-TrackedProperty<uint>.OnAfterDeserialize
	|-TrackedProperty<ulong>.OnAfterDeserialize
	|
	|-RVA: 0xA54F10 Offset: 0xA53510 VA: 0x180A54F10
	|-TrackedProperty<__Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA56AF0 Offset: 0xA550F0 VA: 0x180A56AF0
	|-TrackedProperty<bool>.ToString
	|
	|-RVA: 0xA56F50 Offset: 0xA55550 VA: 0x180A56F50
	|-TrackedProperty<byte>.ToString
	|
	|-RVA: 0xA57030 Offset: 0xA55630 VA: 0x180A57030
	|-TrackedProperty<char>.ToString
	|
	|-RVA: 0xA570A0 Offset: 0xA556A0 VA: 0x180A570A0
	|-TrackedProperty<double>.ToString
	|
	|-RVA: 0xA56CB0 Offset: 0xA552B0 VA: 0x180A56CB0
	|-TrackedProperty<short>.ToString
	|
	|-RVA: 0xA56C40 Offset: 0xA55240 VA: 0x180A56C40
	|-TrackedProperty<int>.ToString
	|
	|-RVA: 0xA56EE0 Offset: 0xA554E0 VA: 0x180A56EE0
	|-TrackedProperty<long>.ToString
	|
	|-RVA: 0xA56BD0 Offset: 0xA551D0 VA: 0x180A56BD0
	|-TrackedProperty<object>.ToString
	|
	|-RVA: 0xA56B60 Offset: 0xA55160 VA: 0x180A56B60
	|-TrackedProperty<sbyte>.ToString
	|
	|-RVA: 0xA56D20 Offset: 0xA55320 VA: 0x180A56D20
	|-TrackedProperty<float>.ToString
	|
	|-RVA: 0xA56E70 Offset: 0xA55470 VA: 0x180A56E70
	|-TrackedProperty<ushort>.ToString
	|
	|-RVA: 0xA56FC0 Offset: 0xA555C0 VA: 0x180A56FC0
	|-TrackedProperty<uint>.ToString
	|
	|-RVA: 0xA56E00 Offset: 0xA55400 VA: 0x180A56E00
	|-TrackedProperty<ulong>.ToString
	|
	|-RVA: 0xA56D90 Offset: 0xA55390 VA: 0x180A56D90
	|-TrackedProperty<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA57110 Offset: 0xA55710 VA: 0x180A57110
	|-TrackedProperty<bool>..ctor
	|-TrackedProperty<byte>..ctor
	|-TrackedProperty<char>..ctor
	|-TrackedProperty<double>..ctor
	|-TrackedProperty<short>..ctor
	|-TrackedProperty<int>..ctor
	|-TrackedProperty<long>..ctor
	|-TrackedProperty<object>..ctor
	|-TrackedProperty<sbyte>..ctor
	|-TrackedProperty<float>..ctor
	|-TrackedProperty<ushort>..ctor
	|-TrackedProperty<uint>..ctor
	|-TrackedProperty<ulong>..ctor
	|
	|-RVA: 0xA571F0 Offset: 0xA557F0 VA: 0x180A571F0
	|-TrackedProperty<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class ByteTrackedProperty : TrackedProperty<byte> // TypeDefIndex: 12055
{
	// Methods

	// RVA: 0x1F00F60 Offset: 0x1EFF560 VA: 0x181F00F60
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class SByteTrackedProperty : TrackedProperty<sbyte> // TypeDefIndex: 12056
{
	// Methods

	// RVA: 0x1F0AAE0 Offset: 0x1F090E0 VA: 0x181F0AAE0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class CharTrackedProperty : TrackedProperty<char> // TypeDefIndex: 12057
{
	// Methods

	// RVA: 0x1F00FA0 Offset: 0x1EFF5A0 VA: 0x181F00FA0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class ShortTrackedProperty : TrackedProperty<short> // TypeDefIndex: 12058
{
	// Methods

	// RVA: 0x1F0B7C0 Offset: 0x1F09DC0 VA: 0x181F0B7C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class UShortTrackedProperty : TrackedProperty<ushort> // TypeDefIndex: 12059
{
	// Methods

	// RVA: 0x1F0E4B0 Offset: 0x1F0CAB0 VA: 0x181F0E4B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class IntTrackedProperty : TrackedProperty<int> // TypeDefIndex: 12060
{
	// Methods

	// RVA: 0x1F02240 Offset: 0x1F00840 VA: 0x181F02240
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class UIntTrackedProperty : TrackedProperty<uint> // TypeDefIndex: 12061
{
	// Methods

	// RVA: 0x1F00BC0 Offset: 0x1EFF1C0 VA: 0x181F00BC0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class LongTrackedProperty : TrackedProperty<long> // TypeDefIndex: 12062
{
	// Methods

	// RVA: 0x1F08D50 Offset: 0x1F07350 VA: 0x181F08D50
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class ULongTrackedProperty : TrackedProperty<ulong> // TypeDefIndex: 12063
{
	// Methods

	// RVA: 0x1F0E470 Offset: 0x1F0CA70 VA: 0x181F0E470
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class FloatTrackedProperty : TrackedProperty<float> // TypeDefIndex: 12064
{
	// Methods

	// RVA: 0x1F03EE0 Offset: 0x1F024E0 VA: 0x181F03EE0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class DoubleTrackedProperty : TrackedProperty<double> // TypeDefIndex: 12065
{
	// Methods

	// RVA: 0x1F02060 Offset: 0x1F00660 VA: 0x181F02060
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class ArraySizeTrackedProperty : UIntTrackedProperty // TypeDefIndex: 12066
{
	// Methods

	// RVA: 0x1F00BC0 Offset: 0x1EFF1C0 VA: 0x181F00BC0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class EnumTrackedProperty : IntTrackedProperty // TypeDefIndex: 12067
{
	// Methods

	// RVA: 0x1F02240 Offset: 0x1F00840 VA: 0x181F02240
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class BoolTrackedProperty : TrackedProperty<bool> // TypeDefIndex: 12068
{
	// Methods

	// RVA: 0x1F00DB0 Offset: 0x1EFF3B0 VA: 0x181F00DB0 Slot: 17
	protected override bool ConvertFromString(string value) { }

	// RVA: 0x1F00ED0 Offset: 0x1EFF4D0 VA: 0x181F00ED0 Slot: 16
	protected override string ConvertToString(bool value) { }

	// RVA: 0x1F00F20 Offset: 0x1EFF520 VA: 0x181F00F20
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class StringTrackedProperty : TrackedProperty<string> // TypeDefIndex: 12069
{
	// Methods

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 17
	protected override string ConvertFromString(string value) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 16
	protected override string ConvertToString(string value) { }

	// RVA: 0x1F0B800 Offset: 0x1F09E00 VA: 0x181F0B800
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedProperties
[Serializable]
public class UnityObjectProperty : ITrackedPropertyValue<Object>, ITrackedProperty, ISerializationCallbackReceiver // TypeDefIndex: 12071
{
	// Fields
	[SerializeField]
	private string m_PropertyPath; // 0x10
	[SerializeField]
	private string m_TypeString; // 0x18
	[SerializeField]
	private List<UnityObjectProperty.LocaleIdentifierValuePair> m_VariantData; // 0x20
	internal Dictionary<LocaleIdentifier, UnityObjectProperty.LocaleIdentifierValuePair> m_VariantLookup; // 0x28
	[CompilerGenerated]
	private Type <PropertyType>k__BackingField; // 0x30

	// Properties
	public string PropertyPath { get; set; }
	public Type PropertyType { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public string get_PropertyPath() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 8
	public void set_PropertyPath(string value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Type get_PropertyType() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_PropertyType(Type value) { }

	// RVA: 0x1F0E820 Offset: 0x1F0CE20 VA: 0x181F0E820 Slot: 9
	public bool HasVariant(LocaleIdentifier localeIdentifier) { }

	// RVA: 0x1F0EC70 Offset: 0x1F0D270 VA: 0x181F0EC70
	public void RemoveVariant(LocaleIdentifier localeIdentifier) { }

	// RVA: 0x1F0E630 Offset: 0x1F0CC30 VA: 0x181F0E630 Slot: 4
	public bool GetValue(LocaleIdentifier localeIdentifier, out Object foundValue) { }

	// RVA: 0x1F0E710 Offset: 0x1F0CD10 VA: 0x181F0E710 Slot: 5
	public bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out Object foundValue) { }

	// RVA: 0x1F0ECD0 Offset: 0x1F0D2D0 VA: 0x181F0ECD0 Slot: 6
	public void SetValue(LocaleIdentifier localeIdentifier, Object newValue) { }

	// RVA: 0x1F0EA70 Offset: 0x1F0D070 VA: 0x181F0EA70 Slot: 10
	public void OnBeforeSerialize() { }

	// RVA: 0x1F0E880 Offset: 0x1F0CE80 VA: 0x181F0E880 Slot: 11
	public void OnAfterDeserialize() { }

	// RVA: 0x1F0EE00 Offset: 0x1F0D400 VA: 0x181F0EE00
	public void .ctor() { }
}

