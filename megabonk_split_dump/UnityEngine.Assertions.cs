// Namespace: UnityEngine.Assertions
[DebuggerStepThrough]
public static class Assert // TypeDefIndex: 10172
{
	// Fields
	[Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x236A2E0 Offset: 0x23688E0 VA: 0x18236A2E0
	private static void Fail(string message, string userMessage) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x236A720 Offset: 0x2368D20 VA: 0x18236A720
	public static void IsTrue(bool condition) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x236A630 Offset: 0x2368C30 VA: 0x18236A630
	public static void IsTrue(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x236A400 Offset: 0x2368A00 VA: 0x18236A400
	public static void IsFalse(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65D990 Offset: 0x65BF90 VA: 0x18065D990
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0x65DFD0 Offset: 0x65C5D0 VA: 0x18065DFD0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x65D5B0 Offset: 0x65BBB0 VA: 0x18065D5B0
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65DB20 Offset: 0x65C120 VA: 0x18065DB20
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x65DA70 Offset: 0x65C070 VA: 0x18065DA70
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0x65DF20 Offset: 0x65C520 VA: 0x18065DF20
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x65D030 Offset: 0x65B630 VA: 0x18065D030
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65D710 Offset: 0x65BD10 VA: 0x18065D710
	|-Assert.AreEqual<int>
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0x65DCB0 Offset: 0x65C2B0 VA: 0x18065DCB0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x65D1A0 Offset: 0x65B7A0 VA: 0x18065D1A0
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x236A230 Offset: 0x2368830 VA: 0x18236A230
	public static void AreEqual(Object expected, Object actual, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E3F0 Offset: 0x65C9F0 VA: 0x18065E3F0
	|-Assert.IsNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E5B0 Offset: 0x65CBB0 VA: 0x18065E5B0
	|-Assert.IsNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x236A590 Offset: 0x2368B90 VA: 0x18236A590
	public static void IsNull(Object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E230 Offset: 0x65C830 VA: 0x18065E230
	|-Assert.IsNotNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E0B0 Offset: 0x65C6B0 VA: 0x18065E0B0
	|-Assert.IsNotNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x236A4F0 Offset: 0x2368AF0 VA: 0x18236A4F0
	public static void IsNotNull(Object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x236A1C0 Offset: 0x23687C0 VA: 0x18236A1C0
	public static void AreEqual(int expected, int actual) { }

	// RVA: 0x236A830 Offset: 0x2368E30 VA: 0x18236A830
	private static void .cctor() { }
}

// Namespace: UnityEngine.Assertions
public class AssertionException : Exception // TypeDefIndex: 10173
{
	// Fields
	private string m_UserMessage; // 0x90

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x236A870 Offset: 0x2368E70 VA: 0x18236A870
	public void .ctor(string message, string userMessage) { }

	// RVA: 0x236A8F0 Offset: 0x2368EF0 VA: 0x18236A8F0 Slot: 5
	public override string get_Message() { }
}

// Namespace: UnityEngine.Assertions
internal class AssertionMessageUtil // TypeDefIndex: 10174
{
	// Methods

	// RVA: 0x236AF10 Offset: 0x2369510 VA: 0x18236AF10
	public static string GetMessage(string failureMessage) { }

	// RVA: 0x236AC40 Offset: 0x2369240 VA: 0x18236AC40
	public static string GetMessage(string failureMessage, string expected) { }

	// RVA: 0x236A9E0 Offset: 0x2368FE0 VA: 0x18236A9E0
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	// RVA: 0x236B030 Offset: 0x2369630 VA: 0x18236B030
	public static string NullFailureMessage(object value, bool expectNull) { }

	// RVA: 0x236A950 Offset: 0x2368F50 VA: 0x18236A950
	public static string BooleanFailureMessage(bool expected) { }
}

