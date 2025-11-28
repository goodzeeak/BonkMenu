// Namespace: Rewired.Utils.Libraries.TinyJson
[Usage(384, Inherited = True, AllowMultiple = False)]
public class SerializeAttribute : Attribute // TypeDefIndex: 2929
{
	// Fields
	public string Name; // 0x10

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Rewired.Utils.Libraries.TinyJson
[Usage(384, Inherited = True, AllowMultiple = False)]
public class DoNotSerializeAttribute : Attribute // TypeDefIndex: 2930
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Rewired.Utils.Libraries.TinyJson
public static class JsonTools // TypeDefIndex: 2931
{
	// Methods

	// RVA: -1 Offset: -1
	public static T Clone<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x713150 Offset: 0x711750 VA: 0x180713150
	|-JsonTools.Clone<object>
	*/
}

// Namespace: Rewired.Utils.Libraries.TinyJson
public static class JsonParser // TypeDefIndex: 2933
{
	// Fields
	[CustomObfuscation(rename = False)]
	internal static Stack<List<string>> splitArrayPool; // 0x0
	private static StringBuilder PrPbaVbKDFJRNdElZQIrJUoiqeVcb; // 0x8
	private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> GFvWTLRkLXMRgMIHxZxGOajxELzcA; // 0x10
	private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> tTdhAcdFjISOxNlsBtThwfacrYOS; // 0x18

	// Methods

	// RVA: -1 Offset: -1
	public static bool TryFromJson<T>(string json, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x712C40 Offset: 0x711240 VA: 0x180712C40
	|-JsonParser.TryFromJson<object>
	|
	|-RVA: 0x7128E0 Offset: 0x710EE0 VA: 0x1807128E0
	|-JsonParser.TryFromJson<__Il2CppFullySharedGenericType>
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	internal static bool TryFromJson<T>(string json, out T value, Type preferredAnonymousObjectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x712CC0 Offset: 0x7112C0 VA: 0x180712CC0
	|-JsonParser.TryFromJson<object>
	|
	|-RVA: 0x712960 Offset: 0x710F60 VA: 0x180712960
	|-JsonParser.TryFromJson<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x712870 Offset: 0x710E70 VA: 0x180712870
	|-JsonParser.FromJson<object>
	|
	|-RVA: 0x712530 Offset: 0x710B30 VA: 0x180712530
	|-JsonParser.FromJson<__Il2CppFullySharedGenericType>
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	internal static T FromJson<T>(string json, Type preferredAnonymousObjectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x712620 Offset: 0x710C20 VA: 0x180712620
	|-JsonParser.FromJson<object>
	|
	|-RVA: 0x712260 Offset: 0x710860 VA: 0x180712260
	|-JsonParser.FromJson<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17E2CB0 Offset: 0x17E12B0 VA: 0x1817E2CB0
	public static object FromJson(Type type, string json) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17E2AD0 Offset: 0x17E10D0 VA: 0x1817E2AD0
	internal static object FromJson(Type type, string json, Type preferredAnonymousObjectType) { }

	// RVA: 0x17E3A40 Offset: 0x17E2040 VA: 0x1817E3A40
	private static object csoXKAvpXpDRDOTgUazpPvoUGHEjA(Type , string , Type , out bool ) { }

	// RVA: 0x17E4F20 Offset: 0x17E3520 VA: 0x1817E4F20
	private static object zJhgpSFiBOhFgUQvUbNzlPZAWRkvA(string , Type , out bool ) { }

	// RVA: 0x17E2F30 Offset: 0x17E1530 VA: 0x1817E2F30
	private static object OTdCSOgamqiRvYYUFRTkejFuZSve(Type , string , Type ) { }

	// RVA: 0x17E2D10 Offset: 0x17E1310 VA: 0x1817E2D10
	private static int MdXgBybnYtdJtoIsTtlBjSErhYHq(bool , int , string ) { }

	// RVA: 0x17E4B20 Offset: 0x17E3120 VA: 0x1817E4B20
	private static List<string> fRozRQcNXuJojCgJGhDChteeaktpA(string ) { }

	// RVA: 0x17E38A0 Offset: 0x17E1EA0 VA: 0x1817E38A0
	private static void .cctor() { }
}

// Namespace: Rewired.Utils.Libraries.TinyJson
public static class JsonWriter // TypeDefIndex: 2934
{
	// Fields
	private static Action<StringBuilder, object> shgJEYUsKstTAMpqUlciHYAfGNvR; // 0x0

	// Properties
	private static Action<StringBuilder, object> fXeyjEzomnRapIQUIRmXNZpwFDoL { get; }

	// Methods

	// RVA: 0x17E5C40 Offset: 0x17E4240 VA: 0x1817E5C40
	private static Action<StringBuilder, object> GlNrGGrMbkWCInCpJOuwpBDUfeSs() { }

	// RVA: 0x17E5CF0 Offset: 0x17E42F0 VA: 0x1817E5CF0
	public static string ToJson(object item) { }

	// RVA: 0x17E5D70 Offset: 0x17E4370 VA: 0x1817E5D70
	private static void XvtsFTqLvEGWtRGRocyQadWQrsDV(StringBuilder , object ) { }

	// RVA: 0x17E5B70 Offset: 0x17E4170 VA: 0x1817E5B70
	private static void FbwwWprkpWvwAWDsKdQgehXVGdSq(StringBuilder , string ) { }
}

