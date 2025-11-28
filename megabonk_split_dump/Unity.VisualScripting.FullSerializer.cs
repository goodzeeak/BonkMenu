// Namespace: Unity.VisualScripting.FullSerializer
public class fsArrayConverter : fsConverter // TypeDefIndex: 9320
{
	// Methods

	// RVA: 0x21EC010 Offset: 0x21EA610 VA: 0x1821EC010 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type storageType) { }

	// RVA: 0x22B5A90 Offset: 0x22B4090 VA: 0x1822B5A90 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22B56A0 Offset: 0x22B3CA0 VA: 0x1822B56A0 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x22B5620 Offset: 0x22B3C20 VA: 0x1822B5620 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsDateConverter : fsConverter // TypeDefIndex: 9321
{
	// Fields
	private const string DefaultDateTimeFormatString = "o";
	private const string DateTimeOffsetFormatString = "o";

	// Properties
	private string DateTimeFormatString { get; }

	// Methods

	// RVA: 0x22B8E90 Offset: 0x22B7490 VA: 0x1822B8E90
	private string get_DateTimeFormatString() { }

	// RVA: 0x22B8420 Offset: 0x22B6A20 VA: 0x1822B8420 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x22B8BC0 Offset: 0x22B71C0 VA: 0x1822B8BC0 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22B8520 Offset: 0x22B6B20 VA: 0x1822B8520 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsDictionaryConverter : fsConverter // TypeDefIndex: 9322
{
	// Methods

	// RVA: 0x22B92E0 Offset: 0x22B78E0 VA: 0x1822B92E0 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x22B9360 Offset: 0x22B7960 VA: 0x1822B9360 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22B9520 Offset: 0x22B7B20 VA: 0x1822B9520 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType) { }

	// RVA: 0x22BA730 Offset: 0x22B8D30 VA: 0x1822BA730 Slot: 7
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType) { }

	// RVA: 0x22B8EF0 Offset: 0x22B74F0 VA: 0x1822B8EF0
	private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value) { }

	// RVA: 0x22B93E0 Offset: 0x22B79E0 VA: 0x1822B93E0
	private static void GetKeyValueTypes(Type dictionaryType, out Type keyStorageType, out Type valueStorageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsEnumConverter : fsConverter // TypeDefIndex: 9325
{
	// Methods

	// RVA: 0x22BB100 Offset: 0x22B9700 VA: 0x1822BB100 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type storageType) { }

	// RVA: 0x22BB170 Offset: 0x22B9770 VA: 0x1822BB170 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22BBB40 Offset: 0x22BA140 VA: 0x1822BBB40 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22BB1D0 Offset: 0x22B97D0 VA: 0x1822BB1D0 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: -1 Offset: -1
	private static bool ArrayContains<T>(T[] values, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8328E0 Offset: 0x830EE0 VA: 0x1808328E0
	|-fsEnumConverter.ArrayContains<object>
	|
	|-RVA: 0x832770 Offset: 0x830D70 VA: 0x180832770
	|-fsEnumConverter.ArrayContains<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
[Usage(1036)]
public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 9326
{
	// Fields
	public string MemberName; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string memberName) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsForwardConverter : fsConverter // TypeDefIndex: 9327
{
	// Fields
	private string _memberName; // 0x18

	// Methods

	// RVA: 0x22BC860 Offset: 0x22BAE60 VA: 0x1822BC860
	public void .ctor(fsForwardAttribute attribute) { }

	// RVA: 0x22BC020 Offset: 0x22BA620 VA: 0x1822BC020 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x22BC0F0 Offset: 0x22BA6F0 VA: 0x1822BC0F0
	private fsResult GetProperty(object instance, out fsMetaProperty property) { }

	// RVA: 0x22BC600 Offset: 0x22BAC00 VA: 0x1822BC600 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22BC2F0 Offset: 0x22BA8F0 VA: 0x1822BC2F0 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x22BC070 Offset: 0x22BA670 VA: 0x1822BC070 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsGuidConverter : fsConverter // TypeDefIndex: 9328
{
	// Methods

	// RVA: 0x22BC930 Offset: 0x22BAF30 VA: 0x1822BC930 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type storageType) { }

	// RVA: 0x22BCB40 Offset: 0x22BB140 VA: 0x1822BCB40 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22BC9E0 Offset: 0x22BAFE0 VA: 0x1822BC9E0 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x22BC9A0 Offset: 0x22BAFA0 VA: 0x1822BC9A0 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 9329
{
	// Methods

	// RVA: 0x22BCC70 Offset: 0x22BB270 VA: 0x1822BCC70 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x22BCD20 Offset: 0x22BB320 VA: 0x1822BCD20 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22BD850 Offset: 0x22BBE50 VA: 0x1822BD850 Slot: 7
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType) { }

	// RVA: 0x22BD0F0 Offset: 0x22BB6F0 VA: 0x1822BD0F0
	private bool IsStack(Type type) { }

	// RVA: 0x22BD2A0 Offset: 0x22BB8A0 VA: 0x1822BD2A0 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType) { }

	// RVA: 0x22BD040 Offset: 0x22BB640 VA: 0x1822BD040
	private static int HintSize(IEnumerable collection) { }

	// RVA: 0x22BCF20 Offset: 0x22BB520 VA: 0x1822BCF20
	private static Type GetElementType(Type objectType) { }

	// RVA: 0x22BD200 Offset: 0x22BB800 VA: 0x1822BD200
	private static void TryClear(Type type, object instance) { }

	// RVA: 0x22BD760 Offset: 0x22BBD60 VA: 0x1822BD760
	private static int TryGetExistingSize(Type type, object instance) { }

	// RVA: 0x22BCDA0 Offset: 0x22BB3A0 VA: 0x1822BCDA0
	private static MethodInfo GetAddMethod(Type type) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsKeyValuePairConverter : fsConverter // TypeDefIndex: 9330
{
	// Methods

	// RVA: 0x22C2040 Offset: 0x22C0640 VA: 0x1822C2040 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type storageType) { }

	// RVA: 0x22C2130 Offset: 0x22C0730 VA: 0x1822C2130 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x22C2660 Offset: 0x22C0C60 VA: 0x1822C2660 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsNullableConverter : fsConverter // TypeDefIndex: 9331
{
	// Methods

	// RVA: 0x22C2B60 Offset: 0x22C1160 VA: 0x1822C2B60 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x22C2CD0 Offset: 0x22C12D0 VA: 0x1822C2CD0 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22C2C50 Offset: 0x22C1250 VA: 0x1822C2C50 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x2119520 Offset: 0x2117B20 VA: 0x182119520 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 9332
{
	// Methods

	// RVA: 0x22C2E00 Offset: 0x22C1400 VA: 0x1822C2E00 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type storageType) { }

	// RVA: 0x22C3720 Offset: 0x22C1D20 VA: 0x1822C3720 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22C2F00 Offset: 0x22C1500 VA: 0x1822C2F00 Slot: 8
	public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType) { }

	// RVA: 0x22C3E50 Offset: 0x22C2450 VA: 0x1822C3E50
	private static bool UseBool(Type type) { }

	// RVA: 0x22C3F90 Offset: 0x22C2590 VA: 0x1822C3F90
	private static bool UseInt64(Type type) { }

	// RVA: 0x22C3EA0 Offset: 0x22C24A0 VA: 0x1822C3EA0
	private static bool UseDouble(Type type) { }

	// RVA: 0x22C4190 Offset: 0x22C2790 VA: 0x1822C4190
	private static bool UseString(Type type) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsReflectedConverter : fsConverter // TypeDefIndex: 9333
{
	// Methods

	// RVA: 0x22C4230 Offset: 0x22C2830 VA: 0x1822C4230 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x22C46D0 Offset: 0x22C2CD0 VA: 0x1822C46D0 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22C4380 Offset: 0x22C2980 VA: 0x1822C4380 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x22C4300 Offset: 0x22C2900 VA: 0x1822C4300 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsTypeConverter : fsConverter // TypeDefIndex: 9334
{
	// Methods

	// RVA: 0x22CCA20 Offset: 0x22CB020 VA: 0x1822CCA20 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type type) { }

	// RVA: 0x22CCC80 Offset: 0x22CB280 VA: 0x1822CCC80 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22CCA80 Offset: 0x22CB080 VA: 0x1822CCA80 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x2119520 Offset: 0x2117B20 VA: 0x182119520 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 9335
{
	// Methods

	// RVA: 0x22CCDC0 Offset: 0x22CB3C0 VA: 0x1822CCDC0 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type storageType) { }

	// RVA: 0x22CD310 Offset: 0x22CB910 VA: 0x1822CD310 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22CCE80 Offset: 0x22CB480 VA: 0x1822CCE80 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x22CCE30 Offset: 0x22CB430 VA: 0x1822CCE30 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsConverterRegistrar // TypeDefIndex: 9336
{
	// Fields
	public static AnimationCurve_DirectConverter Register_AnimationCurve_DirectConverter; // 0x0
	public static Bounds_DirectConverter Register_Bounds_DirectConverter; // 0x8
	public static Gradient_DirectConverter Register_Gradient_DirectConverter; // 0x10
	public static GUIStyleState_DirectConverter Register_GUIStyleState_DirectConverter; // 0x18
	public static GUIStyle_DirectConverter Register_GUIStyle_DirectConverter; // 0x20
	public static Keyframe_DirectConverter Register_Keyframe_DirectConverter; // 0x28
	public static LayerMask_DirectConverter Register_LayerMask_DirectConverter; // 0x30
	public static RectOffset_DirectConverter Register_RectOffset_DirectConverter; // 0x38
	public static Rect_DirectConverter Register_Rect_DirectConverter; // 0x40
	public static List<Type> Converters; // 0x48

	// Methods

	// RVA: 0x22B6FB0 Offset: 0x22B55B0 VA: 0x1822B6FB0
	private static void .cctor() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 9337
{
	// Methods

	// RVA: 0x22A1BE0 Offset: 0x22A01E0 VA: 0x1822A1BE0 Slot: 10
	protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22A1740 Offset: 0x229FD40 VA: 0x1822A1740 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model) { }

	// RVA: 0x22A16F0 Offset: 0x229FCF0 VA: 0x1822A16F0 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22A2000 Offset: 0x22A0600 VA: 0x1822A2000
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class Bounds_DirectConverter : fsDirectConverter<Bounds> // TypeDefIndex: 9338
{
	// Methods

	// RVA: 0x22A2850 Offset: 0x22A0E50 VA: 0x1822A2850 Slot: 10
	protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22A24D0 Offset: 0x22A0AD0 VA: 0x1822A24D0 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model) { }

	// RVA: 0x22A2470 Offset: 0x22A0A70 VA: 0x1822A2470 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22A2B90 Offset: 0x22A1190 VA: 0x1822A2B90
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class Gradient_DirectConverter : fsDirectConverter<Gradient> // TypeDefIndex: 9339
{
	// Methods

	// RVA: 0x22A9970 Offset: 0x22A7F70 VA: 0x1822A9970 Slot: 10
	protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22A9450 Offset: 0x22A7A50 VA: 0x1822A9450 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model) { }

	// RVA: 0x22A9DF0 Offset: 0x22A83F0 VA: 0x1822A9DF0
	private static void LogWarning(string phase) { }

	// RVA: 0x22A9400 Offset: 0x22A7A00 VA: 0x1822A9400 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22A9F60 Offset: 0x22A8560 VA: 0x1822A9F60
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState> // TypeDefIndex: 9340
{
	// Methods

	// RVA: 0x22A4F10 Offset: 0x22A3510 VA: 0x1822A4F10 Slot: 10
	protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22A4BB0 Offset: 0x22A31B0 VA: 0x1822A4BB0 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model) { }

	// RVA: 0x22A4B60 Offset: 0x22A3160 VA: 0x1822A4B60 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22A5250 Offset: 0x22A3850 VA: 0x1822A5250
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> // TypeDefIndex: 9341
{
	// Methods

	// RVA: 0x22A75F0 Offset: 0x22A5BF0 VA: 0x1822A75F0 Slot: 10
	protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22A52E0 Offset: 0x22A38E0 VA: 0x1822A52E0 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model) { }

	// RVA: 0x22A5290 Offset: 0x22A3890 VA: 0x1822A5290 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22A93C0 Offset: 0x22A79C0 VA: 0x1822A93C0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 9342
{
	// Methods

	// RVA: 0x22AA750 Offset: 0x22A8D50 VA: 0x1822AA750 Slot: 10
	protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22AA080 Offset: 0x22A8680 VA: 0x1822AA080 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model) { }

	// RVA: 0x22AA020 Offset: 0x22A8620 VA: 0x1822AA020 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22AADA0 Offset: 0x22A93A0 VA: 0x1822AADA0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 9343
{
	// Methods

	// RVA: 0x22AB000 Offset: 0x22A9600 VA: 0x1822AB000 Slot: 10
	protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22AAE20 Offset: 0x22A9420 VA: 0x1822AAE20 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model) { }

	// RVA: 0x22AADE0 Offset: 0x22A93E0 VA: 0x1822AADE0 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22AB1C0 Offset: 0x22A97C0 VA: 0x1822AB1C0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class RectOffset_DirectConverter : fsDirectConverter<RectOffset> // TypeDefIndex: 9344
{
	// Methods

	// RVA: 0x22ABC90 Offset: 0x22AA290 VA: 0x1822ABC90 Slot: 10
	protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22AB6C0 Offset: 0x22A9CC0 VA: 0x1822AB6C0 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model) { }

	// RVA: 0x22AB670 Offset: 0x22A9C70 VA: 0x1822AB670 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22AC1C0 Offset: 0x22AA7C0 VA: 0x1822AC1C0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 9345
{
	// Methods

	// RVA: 0x22AC7D0 Offset: 0x22AADD0 VA: 0x1822AC7D0 Slot: 10
	protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22AC240 Offset: 0x22AA840 VA: 0x1822AC240 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model) { }

	// RVA: 0x22AC200 Offset: 0x22AA800 VA: 0x1822AC200 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22ACD00 Offset: 0x22AB300 VA: 0x1822ACD00
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsAotCompilationManager // TypeDefIndex: 9347
{
	// Fields
	private static Dictionary<Type, string> _computedAotCompilations; // 0x0
	private static List<fsAotCompilationManager.AotCompilation> _uncomputedAotCompilations; // 0x8

	// Properties
	public static Dictionary<Type, string> AvailableAotCompilations { get; }

	// Methods

	// RVA: 0x22B5480 Offset: 0x22B3A80 VA: 0x1822B5480
	public static Dictionary<Type, string> get_AvailableAotCompilations() { }

	// RVA: 0x22B5100 Offset: 0x22B3700 VA: 0x1822B5100
	public static bool TryToPerformAotCompilation(fsConfig config, Type type, out string aotCompiledClassInCSharp) { }

	// RVA: 0x22B4370 Offset: 0x22B2970 VA: 0x1822B4370
	public static void AddAotCompilation(Type type, fsMetaProperty[] members, bool isConstructorPublic) { }

	// RVA: 0x22B5040 Offset: 0x22B3640 VA: 0x1822B5040
	private static string GetConverterString(fsMetaProperty member) { }

	// RVA: 0x22B44C0 Offset: 0x22B2AC0 VA: 0x1822B44C0
	private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x22B5390 Offset: 0x22B3990 VA: 0x1822B5390
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public abstract class fsBaseConverter // TypeDefIndex: 9349
{
	// Fields
	public fsSerializer Serializer; // 0x10

	// Methods

	// RVA: 0x22B6400 Offset: 0x22B4A00 VA: 0x1822B6400 Slot: 4
	public virtual object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22B6910 Offset: 0x22B4F10 VA: 0x1822B6910 Slot: 5
	public virtual bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x22B6A00 Offset: 0x22B5000 VA: 0x1822B6A00 Slot: 6
	public virtual bool RequestInheritanceSupport(Type storageType) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

	// RVA: 0x22B65A0 Offset: 0x22B4BA0 VA: 0x1822B65A0
	protected fsResult FailExpectedType(fsData data, fsDataType[] types) { }

	// RVA: 0x22B6150 Offset: 0x22B4750 VA: 0x1822B6150
	protected fsResult CheckType(fsData data, fsDataType type) { }

	// RVA: 0x22B5EA0 Offset: 0x22B44A0 VA: 0x1822B5EA0
	protected fsResult CheckKey(fsData data, string key, out fsData subitem) { }

	// RVA: 0x22B5F40 Offset: 0x22B4540 VA: 0x1822B5F40
	protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem) { }

	// RVA: -1 Offset: -1
	protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x830A20 Offset: 0x82F020 VA: 0x180830A20
	|-fsBaseConverter.SerializeMember<bool>
	|
	|-RVA: 0x830B80 Offset: 0x82F180 VA: 0x180830B80
	|-fsBaseConverter.SerializeMember<Color>
	|
	|-RVA: 0x830E80 Offset: 0x82F480 VA: 0x180830E80
	|-fsBaseConverter.SerializeMember<int>
	|-fsBaseConverter.SerializeMember<Int32Enum>
	|
	|-RVA: 0x830FE0 Offset: 0x82F5E0 VA: 0x180830FE0
	|-fsBaseConverter.SerializeMember<object>
	|
	|-RVA: 0x831120 Offset: 0x82F720 VA: 0x180831120
	|-fsBaseConverter.SerializeMember<float>
	|
	|-RVA: 0x831280 Offset: 0x82F880 VA: 0x180831280
	|-fsBaseConverter.SerializeMember<Vector2>
	|
	|-RVA: 0x8313E0 Offset: 0x82F9E0 VA: 0x1808313E0
	|-fsBaseConverter.SerializeMember<Vector3>
	|
	|-RVA: 0x830CE0 Offset: 0x82F2E0 VA: 0x180830CE0
	|-fsBaseConverter.SerializeMember<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82FB80 Offset: 0x82E180 VA: 0x18082FB80
	|-fsBaseConverter.DeserializeMember<bool>
	|
	|-RVA: 0x82FD80 Offset: 0x82E380 VA: 0x18082FD80
	|-fsBaseConverter.DeserializeMember<Color>
	|
	|-RVA: 0x8301C0 Offset: 0x82E7C0 VA: 0x1808301C0
	|-fsBaseConverter.DeserializeMember<int>
	|-fsBaseConverter.DeserializeMember<Int32Enum>
	|-fsBaseConverter.DeserializeMember<float>
	|
	|-RVA: 0x8303C0 Offset: 0x82E9C0 VA: 0x1808303C0
	|-fsBaseConverter.DeserializeMember<object>
	|
	|-RVA: 0x830610 Offset: 0x82EC10 VA: 0x180830610
	|-fsBaseConverter.DeserializeMember<Vector2>
	|
	|-RVA: 0x830810 Offset: 0x82EE10 VA: 0x180830810
	|-fsBaseConverter.DeserializeMember<Vector3>
	|
	|-RVA: 0x82FF80 Offset: 0x82E580 VA: 0x18082FF80
	|-fsBaseConverter.DeserializeMember<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public static class fsGlobalConfig // TypeDefIndex: 9350
{
	// Fields
	public static bool IsCaseSensitive; // 0x0
	public static bool AllowInternalExceptions; // 0x1
	public static string InternalFieldPrefix; // 0x8

	// Methods

	// RVA: 0x22BC8A0 Offset: 0x22BAEA0 VA: 0x1822BC8A0
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsConfig // TypeDefIndex: 9352
{
	// Fields
	public Type[] SerializeAttributes; // 0x10
	public Type[] IgnoreSerializeAttributes; // 0x18
	public fsMemberSerialization DefaultMemberSerialization; // 0x20
	public Func<string, MemberInfo, string> GetJsonNameFromMemberName; // 0x28
	public bool EnablePropertySerialization; // 0x30
	public bool SerializeNonAutoProperties; // 0x31
	public bool SerializeNonPublicSetProperties; // 0x32
	public string CustomDateTimeFormatString; // 0x38
	public bool Serialize64BitIntegerAsString; // 0x40
	public bool SerializeEnumsAsInteger; // 0x41

	// Methods

	// RVA: 0x22B6A70 Offset: 0x22B5070 VA: 0x1822B6A70
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public sealed class fsContext // TypeDefIndex: 9353
{
	// Fields
	private readonly Dictionary<Type, object> _contextObjects; // 0x10

	// Methods

	// RVA: 0x22B6EE0 Offset: 0x22B54E0 VA: 0x1822B6EE0
	public void Reset() { }

	// RVA: -1 Offset: -1
	public void Set<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x831A70 Offset: 0x830070 VA: 0x180831A70
	|-fsContext.Set<object>
	|
	|-RVA: 0x831950 Offset: 0x82FF50 VA: 0x180831950
	|-fsContext.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool Has<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8318C0 Offset: 0x82FEC0 VA: 0x1808318C0
	|-fsContext.Has<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x831720 Offset: 0x82FD20 VA: 0x180831720
	|-fsContext.Get<object>
	|
	|-RVA: 0x831550 Offset: 0x82FB50 VA: 0x180831550
	|-fsContext.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22B6F30 Offset: 0x22B5530 VA: 0x1822B6F30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 9354
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool CanProcess(Type type);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public enum fsDataType // TypeDefIndex: 9355
{
	// Fields
	public int value__; // 0x0
	public const fsDataType Array = 0;
	public const fsDataType Object = 1;
	public const fsDataType Double = 2;
	public const fsDataType Int64 = 3;
	public const fsDataType Boolean = 4;
	public const fsDataType String = 5;
	public const fsDataType Null = 6;
}

// Namespace: Unity.VisualScripting.FullSerializer
public sealed class fsData // TypeDefIndex: 9356
{
	// Fields
	private object _value; // 0x10
	public static readonly fsData True; // 0x0
	public static readonly fsData False; // 0x8
	public static readonly fsData Null; // 0x10

	// Properties
	public fsDataType Type { get; }
	public bool IsNull { get; }
	public bool IsDouble { get; }
	public bool IsInt64 { get; }
	public bool IsBool { get; }
	public bool IsString { get; }
	public bool IsDictionary { get; }
	public bool IsList { get; }
	[DebuggerBrowsable(0)]
	public double AsDouble { get; }
	[DebuggerBrowsable(0)]
	public long AsInt64 { get; }
	[DebuggerBrowsable(0)]
	public bool AsBool { get; }
	[DebuggerBrowsable(0)]
	public string AsString { get; }
	[DebuggerBrowsable(0)]
	public Dictionary<string, fsData> AsDictionary { get; }
	[DebuggerBrowsable(0)]
	public List<fsData> AsList { get; }

	// Methods

	// RVA: 0x22B7B60 Offset: 0x22B6160 VA: 0x1822B7B60 Slot: 3
	public override string ToString() { }

	// RVA: 0x22B7D60 Offset: 0x22B6360 VA: 0x1822B7D60
	public void .ctor() { }

	// RVA: 0x22B7CC0 Offset: 0x22B62C0 VA: 0x1822B7CC0
	public void .ctor(bool boolean) { }

	// RVA: 0x22B7D10 Offset: 0x22B6310 VA: 0x1822B7D10
	public void .ctor(double f) { }

	// RVA: 0x22B7D90 Offset: 0x22B6390 VA: 0x1822B7D90
	public void .ctor(long i) { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(string str) { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(Dictionary<string, fsData> dict) { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(List<fsData> list) { }

	// RVA: 0x22B7350 Offset: 0x22B5950 VA: 0x1822B7350
	public static fsData CreateDictionary() { }

	// RVA: 0x22B74E0 Offset: 0x22B5AE0 VA: 0x1822B74E0
	public static fsData CreateList() { }

	// RVA: 0x22B7580 Offset: 0x22B5B80 VA: 0x1822B7580
	public static fsData CreateList(int capacity) { }

	// RVA: 0x22B7260 Offset: 0x22B5860 VA: 0x1822B7260
	internal void BecomeDictionary() { }

	// RVA: 0x22B72D0 Offset: 0x22B58D0 VA: 0x1822B72D0
	internal fsData Clone() { }

	// RVA: 0x22B8100 Offset: 0x22B6700 VA: 0x1822B8100
	public fsDataType get_Type() { }

	// RVA: 0x1A7CA80 Offset: 0x1A7B080 VA: 0x181A7CA80
	public bool get_IsNull() { }

	// RVA: 0x22B8010 Offset: 0x22B6610 VA: 0x1822B8010
	public bool get_IsDouble() { }

	// RVA: 0x22B8030 Offset: 0x22B6630 VA: 0x1822B8030
	public bool get_IsInt64() { }

	// RVA: 0x22B7F60 Offset: 0x22B6560 VA: 0x1822B7F60
	public bool get_IsBool() { }

	// RVA: 0x22B80E0 Offset: 0x22B66E0 VA: 0x1822B80E0
	public bool get_IsString() { }

	// RVA: 0x22B7F80 Offset: 0x22B6580 VA: 0x1822B7F80
	public bool get_IsDictionary() { }

	// RVA: 0x22B8050 Offset: 0x22B6650 VA: 0x1822B8050
	public bool get_IsList() { }

	// RVA: 0x22B7E60 Offset: 0x22B6460 VA: 0x1822B7E60
	public double get_AsDouble() { }

	// RVA: 0x22B7EA0 Offset: 0x22B64A0 VA: 0x1822B7EA0
	public long get_AsInt64() { }

	// RVA: 0x22B7DE0 Offset: 0x22B63E0 VA: 0x1822B7DE0
	public bool get_AsBool() { }

	// RVA: 0x22B7F20 Offset: 0x22B6520 VA: 0x1822B7F20
	public string get_AsString() { }

	// RVA: 0x22B7E20 Offset: 0x22B6420 VA: 0x1822B7E20
	public Dictionary<string, fsData> get_AsDictionary() { }

	// RVA: 0x22B7EE0 Offset: 0x22B64E0 VA: 0x1822B7EE0
	public List<fsData> get_AsList() { }

	// RVA: -1 Offset: -1
	private T Cast<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x831B10 Offset: 0x830110 VA: 0x180831B10
	|-fsData.Cast<bool>
	|
	|-RVA: 0x831D80 Offset: 0x830380 VA: 0x180831D80
	|-fsData.Cast<double>
	|
	|-RVA: 0x832290 Offset: 0x830890 VA: 0x180832290
	|-fsData.Cast<long>
	|
	|-RVA: 0x832500 Offset: 0x830B00 VA: 0x180832500
	|-fsData.Cast<object>
	|
	|-RVA: 0x831FF0 Offset: 0x8305F0 VA: 0x180831FF0
	|-fsData.Cast<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22B7620 Offset: 0x22B5C20 VA: 0x1822B7620 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22B7680 Offset: 0x22B5C80 VA: 0x1822B7680
	public bool Equals(fsData other) { }

	// RVA: 0x22B82A0 Offset: 0x22B68A0 VA: 0x1822B82A0
	public static bool op_Equality(fsData a, fsData b) { }

	// RVA: 0x22B83C0 Offset: 0x22B69C0 VA: 0x1822B83C0
	public static bool op_Inequality(fsData a, fsData b) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22B7B70 Offset: 0x22B6170 VA: 0x1822B7B70
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 9357
{
	// Properties
	public abstract Type ModelType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_ModelType();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 9358
{
	// Properties
	public override Type ModelType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public override Type get_ModelType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC08460 Offset: 0xC06A60 VA: 0x180C08460
	|-fsDirectConverter<Bounds>.get_ModelType
	|-fsDirectConverter<Keyframe>.get_ModelType
	|-fsDirectConverter<LayerMask>.get_ModelType
	|-fsDirectConverter<object>.get_ModelType
	|-fsDirectConverter<Ray>.get_ModelType
	|-fsDirectConverter<Ray2D>.get_ModelType
	|-fsDirectConverter<Rect>.get_ModelType
	|-fsDirectConverter<__Il2CppFullySharedGenericType>.get_ModelType
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC08300 Offset: 0xC06900 VA: 0x180C08300
	|-fsDirectConverter<Bounds>.TrySerialize
	|
	|-RVA: 0xC07A90 Offset: 0xC06090 VA: 0x180C07A90
	|-fsDirectConverter<Keyframe>.TrySerialize
	|
	|-RVA: 0xC07C00 Offset: 0xC06200 VA: 0x180C07C00
	|-fsDirectConverter<LayerMask>.TrySerialize
	|
	|-RVA: 0xC07950 Offset: 0xC05F50 VA: 0x180C07950
	|-fsDirectConverter<object>.TrySerialize
	|
	|-RVA: 0xC07D50 Offset: 0xC06350 VA: 0x180C07D50
	|-fsDirectConverter<Ray>.TrySerialize
	|
	|-RVA: 0xC081A0 Offset: 0xC067A0 VA: 0x180C081A0
	|-fsDirectConverter<Ray2D>.TrySerialize
	|
	|-RVA: 0xC07EB0 Offset: 0xC064B0 VA: 0x180C07EB0
	|-fsDirectConverter<Rect>.TrySerialize
	|
	|-RVA: 0xC08010 Offset: 0xC06610 VA: 0x180C08010
	|-fsDirectConverter<__Il2CppFullySharedGenericType>.TrySerialize
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC06FA0 Offset: 0xC055A0 VA: 0x180C06FA0
	|-fsDirectConverter<Bounds>.TryDeserialize
	|
	|-RVA: 0xC07480 Offset: 0xC05A80 VA: 0x180C07480
	|-fsDirectConverter<Keyframe>.TryDeserialize
	|
	|-RVA: 0xC07700 Offset: 0xC05D00 VA: 0x180C07700
	|-fsDirectConverter<LayerMask>.TryDeserialize
	|
	|-RVA: 0xC06D60 Offset: 0xC05360 VA: 0x180C06D60
	|-fsDirectConverter<object>.TryDeserialize
	|
	|-RVA: 0xC07210 Offset: 0xC05810 VA: 0x180C07210
	|-fsDirectConverter<Ray>.TryDeserialize
	|
	|-RVA: 0xC06B00 Offset: 0xC05100 VA: 0x180C06B00
	|-fsDirectConverter<Ray2D>.TryDeserialize
	|
	|-RVA: 0xC065E0 Offset: 0xC04BE0 VA: 0x180C065E0
	|-fsDirectConverter<Rect>.TryDeserialize
	|
	|-RVA: 0xC06840 Offset: 0xC04E40 VA: 0x180C06840
	|-fsDirectConverter<__Il2CppFullySharedGenericType>.TryDeserialize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-fsDirectConverter<__Il2CppFullySharedGenericType>.DoSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-fsDirectConverter<__Il2CppFullySharedGenericType>.DoDeserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	|-fsDirectConverter<Bounds>..ctor
	|-fsDirectConverter<Keyframe>..ctor
	|-fsDirectConverter<LayerMask>..ctor
	|-fsDirectConverter<object>..ctor
	|-fsDirectConverter<Ray>..ctor
	|-fsDirectConverter<Ray2D>..ctor
	|-fsDirectConverter<Rect>..ctor
	|-fsDirectConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting.FullSerializer
public sealed class fsMissingVersionConstructorException : Exception // TypeDefIndex: 9359
{
	// Methods

	// RVA: 0x22C2A70 Offset: 0x22C1070 VA: 0x1822C2A70
	public void .ctor(Type versionedType, Type constructorType) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public sealed class fsDuplicateVersionNameException : Exception // TypeDefIndex: 9360
{
	// Methods

	// RVA: 0x22BAF30 Offset: 0x22B9530 VA: 0x1822BAF30
	public void .ctor(Type typeA, Type typeB, string version) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
[Usage(384)]
public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 9361
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public interface fsISerializationCallbacks // TypeDefIndex: 9362
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeforeSerialize(Type storageType);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAfterSerialize(Type storageType, ref fsData data);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnBeforeDeserialize(Type storageType, ref fsData data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnAfterDeserialize(Type storageType);
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 9363
{
	// Methods

	// RVA: 0x22C54C0 Offset: 0x22C3AC0 VA: 0x1822C54C0 Slot: 4
	public override bool CanProcess(Type type) { }

	// RVA: 0x22C5860 Offset: 0x22C3E60 VA: 0x1822C5860 Slot: 5
	public override void OnBeforeSerialize(Type storageType, object instance) { }

	// RVA: 0x22C55E0 Offset: 0x22C3BE0 VA: 0x1822C55E0 Slot: 6
	public override void OnAfterSerialize(Type storageType, object instance, ref fsData data) { }

	// RVA: 0x22C56A0 Offset: 0x22C3CA0 VA: 0x1822C56A0 Slot: 8
	public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data) { }

	// RVA: 0x22C5540 Offset: 0x22C3B40 VA: 0x1822C5540 Slot: 9
	public override void OnAfterDeserialize(Type storageType, object instance) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor // TypeDefIndex: 9364
{
	// Methods

	// RVA: 0x22C5900 Offset: 0x22C3F00 VA: 0x1822C5900 Slot: 4
	public override bool CanProcess(Type type) { }

	// RVA: 0x22C5A50 Offset: 0x22C4050 VA: 0x1822C5A50 Slot: 5
	public override void OnBeforeSerialize(Type storageType, object instance) { }

	// RVA: 0x22C5980 Offset: 0x22C3F80 VA: 0x1822C5980 Slot: 9
	public override void OnAfterDeserialize(Type storageType, object instance) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsJsonParser // TypeDefIndex: 9365
{
	// Fields
	private readonly StringBuilder _cachedStringBuilder; // 0x10
	private int _start; // 0x18
	private string _input; // 0x20

	// Methods

	// RVA: 0x22C0A90 Offset: 0x22BF090 VA: 0x1822C0A90
	private void .ctor(string input) { }

	// RVA: 0x22BDFD0 Offset: 0x22BC5D0 VA: 0x1822BDFD0
	private fsResult MakeFailure(string message) { }

	// RVA: 0x22BEE60 Offset: 0x22BD460 VA: 0x1822BEE60
	private bool TryMoveNext() { }

	// RVA: 0x22BDEE0 Offset: 0x22BC4E0 VA: 0x1822BDEE0
	private bool HasValue() { }

	// RVA: 0x22BDF10 Offset: 0x22BC510 VA: 0x1822BDF10
	private bool HasValue(int offset) { }

	// RVA: 0x22BDE80 Offset: 0x22BC480 VA: 0x1822BDE80
	private char Character() { }

	// RVA: 0x22BDEB0 Offset: 0x22BC4B0 VA: 0x1822BDEB0
	private char Character(int offset) { }

	// RVA: 0x22BEBB0 Offset: 0x22BD1B0 VA: 0x1822BEBB0
	private void SkipSpace() { }

	// RVA: 0x22BF1E0 Offset: 0x22BD7E0 VA: 0x1822BF1E0
	private fsResult TryParseExact(string content) { }

	// RVA: 0x22C01B0 Offset: 0x22BE7B0 VA: 0x1822C01B0
	private fsResult TryParseTrue(out fsData data) { }

	// RVA: 0x22BF350 Offset: 0x22BD950 VA: 0x1822BF350
	private fsResult TryParseFalse(out fsData data) { }

	// RVA: 0x22BF490 Offset: 0x22BDA90 VA: 0x1822BF490
	private fsResult TryParseNull(out fsData data) { }

	// RVA: 0x22BDF80 Offset: 0x22BC580 VA: 0x1822BDF80
	private bool IsSeparator(char c) { }

	// RVA: 0x22BF5B0 Offset: 0x22BDBB0 VA: 0x1822BF5B0
	private fsResult TryParseNumber(out fsData data) { }

	// RVA: 0x22BFEA0 Offset: 0x22BE4A0 VA: 0x1822BFEA0
	private fsResult TryParseString(out string str) { }

	// RVA: 0x22BEE90 Offset: 0x22BD490 VA: 0x1822BEE90
	private fsResult TryParseArray(out fsData arr) { }

	// RVA: 0x22BF980 Offset: 0x22BDF80 VA: 0x1822BF980
	private fsResult TryParseObject(out fsData obj) { }

	// RVA: 0x22BE6A0 Offset: 0x22BCCA0 VA: 0x1822BE6A0
	private fsResult RunParse(out fsData data) { }

	// RVA: 0x22BE540 Offset: 0x22BCB40 VA: 0x1822BE540
	public static fsResult Parse(string input, out fsData data) { }

	// RVA: 0x22BE340 Offset: 0x22BC940 VA: 0x1822BE340
	public static fsData Parse(string input) { }

	// RVA: 0x22BDF50 Offset: 0x22BC550 VA: 0x1822BDF50
	private bool IsHex(char c) { }

	// RVA: 0x22BE1C0 Offset: 0x22BC7C0 VA: 0x1822BE1C0
	private uint ParseSingleChar(char c1, uint multipliyer) { }

	// RVA: 0x22BE200 Offset: 0x22BC800 VA: 0x1822BE200
	private uint ParseUnicode(char c1, char c2, char c3, char c4) { }

	// RVA: 0x22C02F0 Offset: 0x22BE8F0 VA: 0x1822C02F0
	private fsResult TryUnescapeChar(out char escaped) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public static class fsJsonPrinter // TypeDefIndex: 9366
{
	// Methods

	// RVA: 0x22C1E70 Offset: 0x22C0470 VA: 0x1822C1E70
	private static void InsertSpacing(TextWriter stream, int count) { }

	// RVA: 0x22C1A80 Offset: 0x22C0080 VA: 0x1822C1A80
	private static string EscapeString(string str) { }

	// RVA: 0x22C0B30 Offset: 0x22BF130 VA: 0x1822C0B30
	private static void BuildCompressedString(fsData data, TextWriter stream) { }

	// RVA: 0x22C1080 Offset: 0x22BF680 VA: 0x1822C1080
	private static void BuildPrettyString(fsData data, TextWriter stream, int depth) { }

	// RVA: 0x22C1EF0 Offset: 0x22C04F0 VA: 0x1822C1EF0
	public static void PrettyJson(fsData data, TextWriter outputStream) { }

	// RVA: 0x22C1F00 Offset: 0x22C0500 VA: 0x1822C1F00
	public static string PrettyJson(fsData data) { }

	// RVA: 0x22C17D0 Offset: 0x22BFDD0 VA: 0x1822C17D0
	public static void CompressedJson(fsData data, StreamWriter outputStream) { }

	// RVA: 0x22C17E0 Offset: 0x22BFDE0 VA: 0x1822C17E0
	public static string CompressedJson(fsData data) { }

	// RVA: 0x22C1910 Offset: 0x22BFF10 VA: 0x1822C1910
	private static string ConvertDoubleToString(double d) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public enum fsMemberSerialization // TypeDefIndex: 9367
{
	// Fields
	public int value__; // 0x0
	public const fsMemberSerialization OptIn = 0;
	public const fsMemberSerialization OptOut = 1;
	public const fsMemberSerialization Default = 2;
}

// Namespace: Unity.VisualScripting.FullSerializer
[Usage(12)]
public class fsObjectAttribute : Attribute // TypeDefIndex: 9368
{
	// Fields
	public Type[] PreviousModels; // 0x10
	public string VersionString; // 0x18
	public fsMemberSerialization MemberSerialization; // 0x20
	public Type Converter; // 0x28
	public Type Processor; // 0x30

	// Methods

	// RVA: 0x22C2DB0 Offset: 0x22C13B0 VA: 0x1822C2DB0
	public void .ctor() { }

	// RVA: 0x22C2D50 Offset: 0x22C1350 VA: 0x1822C2D50
	public void .ctor(string versionString, Type[] previousModels) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public abstract class fsObjectProcessor // TypeDefIndex: 9369
{
	// Methods

	// RVA: 0x22C2DC0 Offset: 0x22C13C0 VA: 0x1822C2DC0 Slot: 4
	public virtual bool CanProcess(Type type) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public virtual void OnBeforeSerialize(Type storageType, object instance) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public virtual void OnBeforeDeserialize(Type storageType, ref fsData data) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public virtual void OnAfterDeserialize(Type storageType, object instance) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
[Usage(384)]
public class fsPropertyAttribute : Attribute // TypeDefIndex: 9370
{
	// Fields
	public string Name; // 0x10
	public Type Converter; // 0x18

	// Methods

	// RVA: 0x1E179E0 Offset: 0x1E15FE0 VA: 0x181E179E0
	public void .ctor() { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string name) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public struct fsResult // TypeDefIndex: 9371
{
	// Fields
	private static readonly string[] EmptyStringArray; // 0x0
	private bool _success; // 0x0
	private List<string> _messages; // 0x8
	public static fsResult Success; // 0x8

	// Properties
	public bool Failed { get; }
	public bool Succeeded { get; }
	public bool HasWarnings { get; }
	public Exception AsException { get; }
	public IEnumerable<string> RawMessages { get; }
	public string FormattedMessages { get; }

	// Methods

	// RVA: 0x22C4980 Offset: 0x22C2F80 VA: 0x1822C4980
	public void AddMessage(string message) { }

	// RVA: 0x22C4A80 Offset: 0x22C3080 VA: 0x1822C4A80
	public void AddMessages(fsResult result) { }

	// RVA: 0x22C4E00 Offset: 0x22C3400 VA: 0x1822C4E00
	public fsResult Merge(fsResult other) { }

	// RVA: 0x22C4EE0 Offset: 0x22C34E0 VA: 0x1822C4EE0
	public static fsResult Warn(string warning) { }

	// RVA: 0x22C4D00 Offset: 0x22C3300 VA: 0x1822C4D00
	public static fsResult Fail(string warning) { }

	// RVA: 0x22C5390 Offset: 0x22C3990 VA: 0x1822C5390
	public static fsResult op_Addition(fsResult a, fsResult b) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0
	public bool get_Failed() { }

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_Succeeded() { }

	// RVA: 0x22C52D0 Offset: 0x22C38D0 VA: 0x1822C52D0
	public bool get_HasWarnings() { }

	// RVA: 0x22C4C60 Offset: 0x22C3260 VA: 0x1822C4C60
	public fsResult AssertSuccess() { }

	// RVA: 0x22C4B40 Offset: 0x22C3140 VA: 0x1822C4B40
	public fsResult AssertSuccessWithoutWarnings() { }

	// RVA: 0x22C5090 Offset: 0x22C3690 VA: 0x1822C5090
	public Exception get_AsException() { }

	// RVA: 0x22C5320 Offset: 0x22C3920 VA: 0x1822C5320
	public IEnumerable<string> get_RawMessages() { }

	// RVA: 0x22C5200 Offset: 0x22C3800 VA: 0x1822C5200
	public string get_FormattedMessages() { }

	// RVA: 0x22C4FE0 Offset: 0x22C35E0 VA: 0x1822C4FE0
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsSerializer // TypeDefIndex: 9373
{
	// Fields
	private readonly List<fsConverter> _availableConverters; // 0x10
	private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters; // 0x18
	private readonly List<fsObjectProcessor> _processors; // 0x20
	private readonly fsCyclicReferenceManager _references; // 0x28
	private readonly fsSerializer.fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x30
	private readonly Dictionary<Type, Type> _abstractTypeRemap; // 0x38
	private Dictionary<Type, fsBaseConverter> _cachedConverterTypeInstances; // 0x40
	private Dictionary<Type, fsBaseConverter> _cachedConverters; // 0x48
	private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors; // 0x50
	public fsContext Context; // 0x58
	public fsConfig Config; // 0x60
	private static HashSet<string> _reservedKeywords; // 0x0
	private static readonly string Key_ObjectReference; // 0x8
	private static readonly string Key_ObjectDefinition; // 0x10
	private static readonly string Key_InstanceType; // 0x18
	private static readonly string Key_Version; // 0x20
	private static readonly string Key_Content; // 0x28
	internal static readonly string Key_UnitDefault; // 0x30
	internal static readonly string Key_UnitPosition; // 0x38
	internal static readonly string Key_UnitGuid; // 0x40
	internal static readonly string Key_UnitFormerType; // 0x48
	internal static readonly string Key_UnitFormerValue; // 0x50
	internal static readonly string TypeName_Unit; // 0x58
	private static readonly Type Type_Unit; // 0x60
	internal static readonly string TypeName_MissingType; // 0x68
	private static readonly Type Type_MissingType; // 0x70

	// Methods

	// RVA: 0x22CBBF0 Offset: 0x22CA1F0 VA: 0x1822CBBF0
	public void .ctor() { }

	// RVA: 0x22CA7C0 Offset: 0x22C8DC0 VA: 0x1822CA7C0
	private void RemapAbstractStorageTypeToDefaultType(ref Type storageType) { }

	// RVA: 0x22C5E00 Offset: 0x22C4400 VA: 0x1822C5E00
	public void AddProcessor(fsObjectProcessor processor) { }

	// RVA: -1 Offset: -1
	public void RemoveProcessor<TProcessor>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x832F90 Offset: 0x831590 VA: 0x180832F90
	|-fsSerializer.RemoveProcessor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22CA9E0 Offset: 0x22C8FE0 VA: 0x1822CA9E0
	public void SetDefaultStorageType(Type abstractType, Type defaultStorageType) { }

	// RVA: 0x22C7B20 Offset: 0x22C6120 VA: 0x1822C7B20
	private List<fsObjectProcessor> GetProcessors(Type type) { }

	// RVA: 0x22C5B20 Offset: 0x22C4120 VA: 0x1822C5B20
	public void AddConverter(fsBaseConverter converter) { }

	// RVA: 0x22C6430 Offset: 0x22C4A30 VA: 0x1822C6430
	private fsBaseConverter GetConverter(Type type, Type overrideConverterType) { }

	// RVA: -1 Offset: -1
	public fsResult TrySerialize<T>(T instance, out fsData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x833530 Offset: 0x831B30 VA: 0x180833530
	|-fsSerializer.TrySerialize<object>
	|
	|-RVA: 0x833410 Offset: 0x831A10 VA: 0x180833410
	|-fsSerializer.TrySerialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public fsResult TryDeserialize<T>(fsData data, ref T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x833270 Offset: 0x831870 VA: 0x180833270
	|-fsSerializer.TryDeserialize<object>
	|
	|-RVA: 0x8330D0 Offset: 0x8316D0 VA: 0x1808330D0
	|-fsSerializer.TryDeserialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22CB600 Offset: 0x22C9C00 VA: 0x1822CB600
	public fsResult TrySerialize(Type storageType, object instance, out fsData data) { }

	// RVA: 0x22CB240 Offset: 0x22C9840 VA: 0x1822CB240
	public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data) { }

	// RVA: 0x22C91A0 Offset: 0x22C77A0 VA: 0x1822C91A0
	private fsResult InternalSerialize_1_ProcessCycles(Type storageType, Type overrideConverterType, object instance, out fsData data) { }

	// RVA: 0x22C9660 Offset: 0x22C7C60 VA: 0x1822C9660
	private fsResult InternalSerialize_2_Inheritance(Type storageType, Type overrideConverterType, object instance, out fsData data) { }

	// RVA: 0x22C99C0 Offset: 0x22C7FC0 VA: 0x1822C99C0
	private fsResult InternalSerialize_3_ProcessVersioning(Type overrideConverterType, object instance, out fsData data) { }

	// RVA: 0x22C9CA0 Offset: 0x22C82A0 VA: 0x1822C9CA0
	private fsResult InternalSerialize_4_Converter(Type overrideConverterType, object instance, out fsData data) { }

	// RVA: 0x22CB200 Offset: 0x22C9800 VA: 0x1822CB200
	public fsResult TryDeserialize(fsData data, Type storageType, ref object result) { }

	// RVA: 0x22CAD80 Offset: 0x22C9380 VA: 0x1822CAD80
	public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result) { }

	// RVA: 0x22C7DB0 Offset: 0x22C63B0 VA: 0x1822C7DB0
	private fsResult InternalDeserialize_1_CycleReference(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors) { }

	// RVA: 0x22C8080 Offset: 0x22C6680 VA: 0x1822C8080
	private fsResult InternalDeserialize_2_Version(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors) { }

	// RVA: 0x22C86D0 Offset: 0x22C6CD0 VA: 0x1822C86D0
	private fsResult InternalDeserialize_3_Inheritance(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors) { }

	// RVA: 0x22C8DF0 Offset: 0x22C73F0 VA: 0x1822C8DF0
	private fsResult InternalDeserialize_4_Cycles(Type overrideConverterType, fsData data, Type resultType, ref object result) { }

	// RVA: 0x22C8FA0 Offset: 0x22C75A0 VA: 0x1822C8FA0
	private fsResult InternalDeserialize_5_Converter(Type overrideConverterType, fsData data, Type resultType, ref object result) { }

	// RVA: 0x22C68F0 Offset: 0x22C4EF0 VA: 0x1822C68F0
	private static Type GetDataType(ref fsData data, Type defaultType, ref fsResult deserializeResult) { }

	// RVA: 0x22C62A0 Offset: 0x22C48A0 VA: 0x1822C62A0
	private static void EnsureDictionary(fsData data) { }

	// RVA: 0x22CB640 Offset: 0x22C9C40 VA: 0x1822CB640
	private static void .cctor() { }

	// RVA: 0x22CA280 Offset: 0x22C8880 VA: 0x1822CA280
	public static bool IsReservedKeyword(string key) { }

	// RVA: 0x22CA1B0 Offset: 0x22C87B0 VA: 0x1822CA1B0
	private static bool IsObjectReference(fsData data) { }

	// RVA: 0x22CA0E0 Offset: 0x22C86E0 VA: 0x1822CA0E0
	private static bool IsObjectDefinition(fsData data) { }

	// RVA: 0x22CA3D0 Offset: 0x22C89D0 VA: 0x1822CA3D0
	private static bool IsVersioned(fsData data) { }

	// RVA: 0x22CA300 Offset: 0x22C8900 VA: 0x1822CA300
	private static bool IsTypeSpecified(fsData data) { }

	// RVA: 0x22CA6F0 Offset: 0x22C8CF0 VA: 0x1822CA6F0
	private static bool IsWrappedData(fsData data) { }

	// RVA: 0x22CA4A0 Offset: 0x22C8AA0 VA: 0x1822CA4A0
	private static bool IsVisualScriptingUnit(fsData data) { }

	// RVA: 0x22CAB00 Offset: 0x22C9100 VA: 0x1822CAB00
	public static void StripDeserializationMetadata(ref fsData data) { }

	// RVA: 0x22C5EF0 Offset: 0x22C44F0 VA: 0x1822C5EF0
	private static void ConvertLegacyData(ref fsData data) { }

	// RVA: 0x22CA030 Offset: 0x22C8630 VA: 0x1822CA030
	private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance) { }

	// RVA: 0x22C9E00 Offset: 0x22C8400 VA: 0x1822C9E00
	private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data) { }

	// RVA: 0x22C9F80 Offset: 0x22C8580 VA: 0x1822C9F80
	private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data) { }

	// RVA: 0x22C9EC0 Offset: 0x22C84C0 VA: 0x1822C9EC0
	private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data) { }

	// RVA: 0x22C9D50 Offset: 0x22C8350 VA: 0x1822C9D50
	private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsMetaProperty // TypeDefIndex: 9374
{
	// Fields
	internal MemberInfo _memberInfo; // 0x10
	[CompilerGenerated]
	private Type <StorageType>k__BackingField; // 0x18
	[CompilerGenerated]
	private Type <OverrideConverterType>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <CanRead>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <CanWrite>k__BackingField; // 0x29
	[CompilerGenerated]
	private string <JsonName>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <MemberName>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsPublic>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsReadOnly>k__BackingField; // 0x41

	// Properties
	public Type StorageType { get; set; }
	public Type OverrideConverterType { get; set; }
	public bool CanRead { get; set; }
	public bool CanWrite { get; set; }
	public string JsonName { get; set; }
	public string MemberName { get; set; }
	public bool IsPublic { get; set; }
	public bool IsReadOnly { get; set; }

	// Methods

	// RVA: 0x22CFD40 Offset: 0x22CE340 VA: 0x1822CFD40
	internal void .ctor(fsConfig config, FieldInfo field) { }

	// RVA: 0x22CFBE0 Offset: 0x22CE1E0 VA: 0x1822CFBE0
	internal void .ctor(fsConfig config, PropertyInfo property) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Type get_StorageType() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_StorageType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_OverrideConverterType() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_OverrideConverterType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_CanRead() { }

	[CompilerGenerated]
	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	private void set_CanRead(bool value) { }

	[CompilerGenerated]
	// RVA: 0x179F980 Offset: 0x179DF80 VA: 0x18179F980
	public bool get_CanWrite() { }

	[CompilerGenerated]
	// RVA: 0x1EC4A60 Offset: 0x1EC3060 VA: 0x181EC4A60
	private void set_CanWrite(bool value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_JsonName() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_JsonName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_MemberName() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_MemberName(string value) { }

	[CompilerGenerated]
	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_IsPublic() { }

	[CompilerGenerated]
	// RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	private void set_IsPublic(bool value) { }

	[CompilerGenerated]
	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70
	public bool get_IsReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x1C3AE90 Offset: 0x1C39490 VA: 0x181C3AE90
	private void set_IsReadOnly(bool value) { }

	// RVA: 0x22CF6C0 Offset: 0x22CDCC0 VA: 0x1822CF6C0
	private void CommonInitialize(fsConfig config) { }

	// RVA: 0x22CF900 Offset: 0x22CDF00 VA: 0x1822CF900
	public void Write(object context, object value) { }

	// RVA: 0x22CF7B0 Offset: 0x22CDDB0 VA: 0x1822CF7B0
	public object Read(object context) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public class fsMetaType // TypeDefIndex: 9378
{
	// Fields
	public Type ReflectedType; // 0x10
	private bool _hasEmittedAotData; // 0x18
	private Nullable<bool> _hasDefaultConstructorCache; // 0x19
	private bool _isDefaultConstructorPublic; // 0x1B
	[CompilerGenerated]
	private fsMetaProperty[] <Properties>k__BackingField; // 0x20
	private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes; // 0x0

	// Properties
	public fsMetaProperty[] Properties { get; set; }
	public bool HasDefaultConstructor { get; }

	// Methods

	// RVA: 0x22D1760 Offset: 0x22CFD60 VA: 0x1822D1760
	private void .ctor(fsConfig config, Type reflectedType) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public fsMetaProperty[] get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_Properties(fsMetaProperty[] value) { }

	// RVA: 0x22D1860 Offset: 0x22CFE60 VA: 0x1822D1860
	public bool get_HasDefaultConstructor() { }

	// RVA: 0x22D1190 Offset: 0x22CF790 VA: 0x1822D1190
	public bool EmitAotData() { }

	// RVA: 0x22D0CC0 Offset: 0x22CF2C0 VA: 0x1822D0CC0
	public object CreateInstance() { }

	// RVA: 0x22D1290 Offset: 0x22CF890 VA: 0x1822D1290
	public static fsMetaType Get(fsConfig config, Type type) { }

	// RVA: 0x22D0410 Offset: 0x22CEA10 VA: 0x1822D0410
	public static void ClearCache() { }

	// RVA: 0x22D0560 Offset: 0x22CEB60 VA: 0x1822D0560
	private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType) { }

	// RVA: 0x22D15E0 Offset: 0x22CFBE0 VA: 0x1822D15E0
	private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members) { }

	// RVA: 0x22D0020 Offset: 0x22CE620 VA: 0x1822D0020
	private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue) { }

	// RVA: 0x22CFE10 Offset: 0x22CE410 VA: 0x1822CFE10
	private static bool CanSerializeField(fsConfig config, FieldInfo field, bool annotationFreeValue) { }

	// RVA: 0x22D16D0 Offset: 0x22CFCD0 VA: 0x1822D16D0
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public static class fsReflectionUtility // TypeDefIndex: 9379
{
	// Methods

	// RVA: 0x22D2CA0 Offset: 0x22D12A0 VA: 0x1822D2CA0
	public static Type GetInterface(Type type, Type interfaceType) { }
}

// Namespace: Unity.VisualScripting.FullSerializer
public static class fsTypeCache // TypeDefIndex: 9380
{}

