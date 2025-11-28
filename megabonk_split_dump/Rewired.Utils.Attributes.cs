// Namespace: Rewired.Utils.Attributes
public class BitmaskAttribute : PropertyAttribute // TypeDefIndex: 3057
{
	// Fields
	public Type propType; // 0x10

	// Methods

	// RVA: 0x169A1F0 Offset: 0x16987F0 VA: 0x18169A1F0
	public void .ctor(Type ) { }
}

// Namespace: Rewired.Utils.Attributes
public class BitmaskToggleAttribute : PropertyAttribute // TypeDefIndex: 3058
{
	// Fields
	public Type propType; // 0x10
	public bool showNone; // 0x18
	public bool showAll; // 0x19

	// Methods

	// RVA: 0x18034C0 Offset: 0x1801AC0 VA: 0x1818034C0
	public void .ctor(Type ) { }
}

// Namespace: Rewired.Utils.Attributes
[Usage(256, AllowMultiple = False, Inherited = True)]
public class FieldRangeAttribute : PropertyAttribute // TypeDefIndex: 3059
{
	// Fields
	private float KCRKtIhPerzMzYpChziZWjTsekBT; // 0x10
	private float PaqKLWUHGDtzIvtHOIKGtGZInhEv; // 0x14
	private int uuvJgPQQRNOiIzDISELPTtsmKLOn; // 0x18
	private int MMiiVyiOPehKWWDKtFjjFgHDxYgTA; // 0x1C

	// Properties
	public float minFloat { get; }
	public float maxFloat { get; }
	public int minInt { get; }
	public int maxInt { get; }

	// Methods

	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_minFloat() { }

	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_maxFloat() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_minInt() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_maxInt() { }

	// RVA: 0x1813770 Offset: 0x1811D70 VA: 0x181813770
	public void .ctor(float , float ) { }

	// RVA: 0x1813720 Offset: 0x1811D20 VA: 0x181813720
	public void .ctor(int , int ) { }
}

// Namespace: Rewired.Utils.Attributes
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Usage(32767, AllowMultiple = True, Inherited = True)]
public class PreserveAttribute : Attribute // TypeDefIndex: 3060
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Rewired.Utils.Attributes
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 3061
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type ) { }
}

// Namespace: Rewired.Utils.Attributes
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Usage(4, AllowMultiple = True, Inherited = True)]
public class SerializationTypeAttribute : Attribute // TypeDefIndex: 3063
{
	// Fields
	private SerializationTypeAttribute.SerializationType _serializationType; // 0x10

	// Properties
	public SerializationTypeAttribute.SerializationType serializationType { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public SerializationTypeAttribute.SerializationType get_serializationType() { }

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(SerializationTypeAttribute.SerializationType ) { }
}

