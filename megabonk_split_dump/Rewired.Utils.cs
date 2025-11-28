// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class EmptyObjects<T> // TypeDefIndex: 2866
{
	// Fields
	private static T[] JFqEAPfOYAgawUzAiGLIcSgeVmoic; // 0x0
	private static IList<T> CARhPHkGKcAuceXAGJQnMWEyPJzYA; // 0x0

	// Properties
	public static T[] array { get; }
	public static IList<T> EmptyReadOnlyIListT { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T[] get_array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE907C0 Offset: 0xE8EDC0 VA: 0x180E907C0
	|-EmptyObjects<byte>.get_array
	|-EmptyObjects<ControllerPollingInfo>.get_array
	|-EmptyObjects<ElementAssignmentConflictInfo>.get_array
	|-EmptyObjects<InputActionSourceData>.get_array
	|-EmptyObjects<int>.get_array
	|-EmptyObjects<Int32Enum>.get_array
	|-EmptyObjects<object>.get_array
	|-EmptyObjects<__Il2CppFullySharedGenericType>.get_array
	*/

	// RVA: -1 Offset: -1
	public static IList<T> get_EmptyReadOnlyIListT() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90400 Offset: 0xE8EA00 VA: 0x180E90400
	|-EmptyObjects<byte>.get_EmptyReadOnlyIListT
	|-EmptyObjects<ControllerPollingInfo>.get_EmptyReadOnlyIListT
	|-EmptyObjects<ElementAssignmentConflictInfo>.get_EmptyReadOnlyIListT
	|-EmptyObjects<InputActionSourceData>.get_EmptyReadOnlyIListT
	|-EmptyObjects<int>.get_EmptyReadOnlyIListT
	|-EmptyObjects<Int32Enum>.get_EmptyReadOnlyIListT
	|-EmptyObjects<object>.get_EmptyReadOnlyIListT
	|
	|-RVA: 0xE905C0 Offset: 0xE8EBC0 VA: 0x180E905C0
	|-EmptyObjects<__Il2CppFullySharedGenericType>.get_EmptyReadOnlyIListT
	*/
}

// Namespace: Rewired.Utils
[Extension]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal static class ExtensionMethods // TypeDefIndex: 2873
{
	// Methods

	[Extension]
	// RVA: 0x17AE800 Offset: 0x17ACE00 VA: 0x1817AE800
	public static bool IsNullOrDestroyed(object object) { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal abstract class SafeDelegate : ICloneable // TypeDefIndex: 2874
{
	// Fields
	private static Action<Exception> GBOyThQoIjPTXtEZPWAyjurHTsvq; // 0x0

	// Properties
	internal abstract int Count { get; }
	internal abstract Action<Exception> ExceptionHandler { get; set; }
	internal static Action<Exception> S_ExceptionHandler { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void RemoveDelegateOrAllDelegatesFromAnObject(object obj);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract Action<Exception> get_ExceptionHandler();

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void set_ExceptionHandler(Action<Exception> value);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract object Clone();

	// RVA: 0x17BB7D0 Offset: 0x17B9DD0 VA: 0x1817BB7D0
	internal static Action<Exception> get_S_ExceptionHandler() { }

	// RVA: 0x17BB810 Offset: 0x17B9E10 VA: 0x1817BB810
	internal static void set_S_ExceptionHandler(Action<Exception> value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal abstract class SafeDelegate<T> : SafeDelegate // TypeDefIndex: 2876
{
	// Fields
	private Action<Exception> qfUsPslikDPefdexjqshsFXUxRNn; // 0x0
	private readonly List<SafeDelegate.bqUgaHQLJmuOTzstpeFuwcCLWQzI<T>> BZCPwzxLQuDaWLdGUhSSWhxTSJsR; // 0x0
	private readonly List<SafeDelegate.bqUgaHQLJmuOTzstpeFuwcCLWQzI<T>> ZschuhHUoKDGcQbEAZJBfUZeObiw; // 0x0

	// Properties
	internal override int Count { get; }
	internal override Action<Exception> ExceptionHandler { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal override int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965B90 Offset: 0x964190 VA: 0x180965B90
	|-SafeDelegate<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override Action<Exception> get_ExceptionHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-SafeDelegate<object>.get_ExceptionHandler
	*/

	// RVA: -1 Offset: -1 Slot: 8
	internal override void set_ExceptionHandler(Action<Exception> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-SafeDelegate<object>.set_ExceptionHandler
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9657B0 Offset: 0x963DB0 VA: 0x1809657B0
	|-SafeDelegate<object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(Action<Exception> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965720 Offset: 0x963D20 VA: 0x180965720
	|-SafeDelegate<object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SafeDelegate<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9659D0 Offset: 0x963FD0 VA: 0x1809659D0
	|-SafeDelegate<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddDelegate(T delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9646E0 Offset: 0x962CE0 VA: 0x1809646E0
	|-SafeDelegate<object>.AddDelegate
	*/

	// RVA: -1 Offset: -1
	public void RemoveDelegate(T delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9654D0 Offset: 0x963AD0 VA: 0x1809654D0
	|-SafeDelegate<object>.RemoveDelegate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override void RemoveDelegateOrAllDelegatesFromAnObject(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965290 Offset: 0x963890 VA: 0x180965290
	|-SafeDelegate<object>.RemoveDelegateOrAllDelegatesFromAnObject
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964B80 Offset: 0x963180 VA: 0x180964B80
	|-SafeDelegate<object>.Clear
	*/

	// RVA: -1 Offset: -1
	protected void Invoke(Action<object, T> invokeCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964E80 Offset: 0x963480 VA: 0x180964E80
	|-SafeDelegate<object>.Invoke
	*/

	// RVA: -1 Offset: -1
	protected T GetCombinedDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964BC0 Offset: 0x9631C0 VA: 0x180964BC0
	|-SafeDelegate<object>.GetCombinedDelegate
	*/

	// RVA: -1 Offset: -1
	private bool BCMAfLrTfaZmMLkFZQLAbjYWwFxT(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964A90 Offset: 0x963090 VA: 0x180964A90
	|-SafeDelegate<object>.BCMAfLrTfaZmMLkFZQLAbjYWwFxT
	*/

	// RVA: -1 Offset: -1
	private int GgYjHJtVjhhSpFPRWRKVRvDrMtrw(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964DA0 Offset: 0x9633A0 VA: 0x180964DA0
	|-SafeDelegate<object>.GgYjHJtVjhhSpFPRWRKVRvDrMtrw
	*/

	// RVA: -1 Offset: -1
	private static Delegate miGOHPNFhIydUuwwmOIJnnyJTiRv(object , Delegate ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965D60 Offset: 0x964360 VA: 0x180965D60
	|-SafeDelegate<object>.miGOHPNFhIydUuwwmOIJnnyJTiRv
	*/

	// RVA: -1 Offset: -1
	private static Delegate rTeBdEDgpZdSKUiBGNjxGoCJYYFGb(Delegate , Delegate ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965F90 Offset: 0x964590 VA: 0x180965F90
	|-SafeDelegate<object>.rTeBdEDgpZdSKUiBGNjxGoCJYYFGb
	*/

	// RVA: -1 Offset: -1
	private static int jMQPWAthsqKHeYNzyFAlvqDagaUP(Delegate ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965BB0 Offset: 0x9641B0 VA: 0x180965BB0
	|-SafeDelegate<object>.jMQPWAthsqKHeYNzyFAlvqDagaUP
	*/

	// RVA: -1 Offset: -1
	private static List<Delegate> jTYiOSNDBnjcgBasVEiSfsKJlFRi(Delegate ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965BE0 Offset: 0x9641E0 VA: 0x180965BE0
	|-SafeDelegate<object>.jTYiOSNDBnjcgBasVEiSfsKJlFRi
	*/
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal sealed class SafeAction : SafeDelegate<Action> // TypeDefIndex: 2877
{
	// Fields
	private static Action<object, Action> sfowRRXNBzguQgOAxGBaqFFywahlA; // 0x0

	// Properties
	private static Action<object, Action> invokeDelegate { get; }

	// Methods

	// RVA: 0x17BB530 Offset: 0x17B9B30 VA: 0x1817BB530
	public void .ctor() { }

	// RVA: 0x17BB4E0 Offset: 0x17B9AE0 VA: 0x1817BB4E0
	public void .ctor(Action<Exception> ) { }

	// RVA: 0x17BB570 Offset: 0x17B9B70 VA: 0x1817BB570
	private void .ctor(SafeAction ) { }

	// RVA: 0x17BB2D0 Offset: 0x17B98D0 VA: 0x1817BB2D0
	public void Invoke() { }

	// RVA: 0x17BB250 Offset: 0x17B9850 VA: 0x1817BB250 Slot: 10
	public override object Clone() { }

	// RVA: 0x17BB410 Offset: 0x17B9A10 VA: 0x1817BB410
	private static Action<object, Action> KkBDqQJEopqfdbGYmmsNhkIjIQBo() { }

	// RVA: 0x17BB4C0 Offset: 0x17B9AC0 VA: 0x1817BB4C0
	private static void ShRLOYSggpBuFguiycroxjIgZFBqA(object , Action ) { }

	// RVA: 0x17BB5C0 Offset: 0x17B9BC0 VA: 0x1817BB5C0
	public static SafeAction op_Addition(SafeAction eventList, Action listener) { }

	// RVA: 0x17BB770 Offset: 0x17B9D70 VA: 0x1817BB770
	public static SafeAction op_Subtraction(SafeAction eventList, Action listener) { }

	// RVA: 0x17BB720 Offset: 0x17B9D20 VA: 0x1817BB720
	public static Action op_Implicit(SafeAction obj) { }

	// RVA: 0x17BB670 Offset: 0x17B9C70 VA: 0x1817BB670
	public static SafeAction op_Implicit(Action obj) { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal sealed class SafeAction<T> : SafeDelegate<Action<T>> // TypeDefIndex: 2878
{
	// Fields
	private T nYZPBydCNRqjCwjTDeUaOwgFCRIm; // 0x0
	private static Action<object, Action<T>> LtOsTChgNHUrkJTSdmYHyevvJEi; // 0x0

	// Properties
	private static Action<object, Action<T>> invokeDelegate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963550 Offset: 0x961B50 VA: 0x180963550
	|-SafeAction<object>..ctor
	|
	|-RVA: 0x95D160 Offset: 0x95B760 VA: 0x18095D160
	|-SafeAction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Action<Exception> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9635D0 Offset: 0x961BD0 VA: 0x1809635D0
	|-SafeAction<object>..ctor
	|
	|-RVA: 0x963590 Offset: 0x961B90 VA: 0x180963590
	|-SafeAction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SafeAction<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963570 Offset: 0x961B70 VA: 0x180963570
	|-SafeAction<object>..ctor
	|
	|-RVA: 0x9635B0 Offset: 0x961BB0 VA: 0x1809635B0
	|-SafeAction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963050 Offset: 0x961650 VA: 0x180963050
	|-SafeAction<object>.Invoke
	|
	|-RVA: 0x9630D0 Offset: 0x9616D0 VA: 0x1809630D0
	|-SafeAction<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override object Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x962F60 Offset: 0x961560 VA: 0x180962F60
	|-SafeAction<object>.Clone
	|
	|-RVA: 0x962FE0 Offset: 0x9615E0 VA: 0x180962FE0
	|-SafeAction<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1
	private static Action<object, Action<T>> YYVyBmZibuNitJalfVbnlJqBWxxk() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963240 Offset: 0x961840 VA: 0x180963240
	|-SafeAction<object>.YYVyBmZibuNitJalfVbnlJqBWxxk
	|
	|-RVA: 0x9633B0 Offset: 0x9619B0 VA: 0x1809633B0
	|-SafeAction<__Il2CppFullySharedGenericType>.YYVyBmZibuNitJalfVbnlJqBWxxk
	*/

	// RVA: -1 Offset: -1
	private static void BAWmzxzHbpjzSIbjJKPoROwjXrKD(object , Action<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x962EC0 Offset: 0x9614C0 VA: 0x180962EC0
	|-SafeAction<object>.BAWmzxzHbpjzSIbjJKPoROwjXrKD
	|
	|-RVA: 0x962D20 Offset: 0x961320 VA: 0x180962D20
	|-SafeAction<__Il2CppFullySharedGenericType>.BAWmzxzHbpjzSIbjJKPoROwjXrKD
	*/

	// RVA: -1 Offset: -1
	public static SafeAction<T> op_Addition(SafeAction<T> eventList, Action<T> listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9637A0 Offset: 0x961DA0 VA: 0x1809637A0
	|-SafeAction<object>.op_Addition
	|
	|-RVA: 0x963670 Offset: 0x961C70 VA: 0x180963670
	|-SafeAction<__Il2CppFullySharedGenericType>.op_Addition
	*/

	// RVA: -1 Offset: -1
	public static SafeAction<T> op_Subtraction(SafeAction<T> eventList, Action<T> listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963C20 Offset: 0x962220 VA: 0x180963C20
	|-SafeAction<object>.op_Subtraction
	|
	|-RVA: 0x963B80 Offset: 0x962180 VA: 0x180963B80
	|-SafeAction<__Il2CppFullySharedGenericType>.op_Subtraction
	*/

	// RVA: -1 Offset: -1
	public static Action<T> op_Implicit(SafeAction<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963A00 Offset: 0x962000 VA: 0x180963A00
	|-SafeAction<object>.op_Implicit
	|
	|-RVA: 0x963880 Offset: 0x961E80 VA: 0x180963880
	|-SafeAction<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static SafeAction<T> op_Implicit(Action<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963910 Offset: 0x961F10 VA: 0x180963910
	|-SafeAction<object>.op_Implicit
	|
	|-RVA: 0x963A50 Offset: 0x962050 VA: 0x180963A50
	|-SafeAction<__Il2CppFullySharedGenericType>.op_Implicit
	*/
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal sealed class SafeAction<T, T2> : SafeDelegate<Action<T, T2>> // TypeDefIndex: 2879
{
	// Fields
	private T bkODlfdbVANOstJULKTTZQlujWJMA; // 0x0
	private T2 SOONjIIDHGNAnZmkDnXCFqXOLpWk; // 0x0
	private static Action<object, Action<T, T2>> NZUsFgNkoRhXqNlNDDFObEoRQIZIA; // 0x0

	// Properties
	private static Action<object, Action<T, T2>> invokeDelegate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D160 Offset: 0x95B760 VA: 0x18095D160
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Action<Exception> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963590 Offset: 0x961B90 VA: 0x180963590
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SafeAction<T, T2> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9635B0 Offset: 0x961BB0 VA: 0x1809635B0
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T arg0, T2 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963CF0 Offset: 0x9622F0 VA: 0x180963CF0
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override object Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963C80 Offset: 0x962280 VA: 0x180963C80
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1
	private static Action<object, Action<T, T2>> UkzJxUJDytBKOLmzUWBRiFLOyGYx() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963F40 Offset: 0x962540 VA: 0x180963F40
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.UkzJxUJDytBKOLmzUWBRiFLOyGYx
	*/

	// RVA: -1 Offset: -1
	private static void sZmUTsgKfmZEAYmkKQFfXrGZPOnc(object , Action<T, T2> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964470 Offset: 0x962A70 VA: 0x180964470
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.sZmUTsgKfmZEAYmkKQFfXrGZPOnc
	*/

	// RVA: -1 Offset: -1
	public static SafeAction<T, T2> op_Addition(SafeAction<T, T2> eventList, Action<T, T2> listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9640E0 Offset: 0x9626E0 VA: 0x1809640E0
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Addition
	*/

	// RVA: -1 Offset: -1
	public static SafeAction<T, T2> op_Subtraction(SafeAction<T, T2> eventList, Action<T, T2> listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9643D0 Offset: 0x9629D0 VA: 0x1809643D0
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Subtraction
	*/

	// RVA: -1 Offset: -1
	public static Action<T, T2> op_Implicit(SafeAction<T, T2> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964210 Offset: 0x962810 VA: 0x180964210
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static SafeAction<T, T2> op_Implicit(Action<T, T2> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9642A0 Offset: 0x9628A0 VA: 0x1809642A0
	|-SafeAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Implicit
	*/
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class SafeFunc<T, TResult> : SafeDelegate<Func<T, TResult>> // TypeDefIndex: 2880
{
	// Fields
	private T qfgAbJCGTaJbbizrbmJOyQleDPdPB; // 0x0
	private TResult utDSQATaheXpGBWPfjFJFAxArXcw; // 0x0
	private static Action<object, Func<T, TResult>> gPlEjeAjASQubXQAorMYUgEHqElDb; // 0x0

	// Properties
	private static Action<object, Func<T, TResult>> invokeDelegate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D160 Offset: 0x95B760 VA: 0x18095D160
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Action<Exception> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963590 Offset: 0x961B90 VA: 0x180963590
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SafeFunc<T, TResult> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9635B0 Offset: 0x961BB0 VA: 0x1809635B0
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TResult Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966150 Offset: 0x964750 VA: 0x180966150
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override object Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963C80 Offset: 0x962280 VA: 0x180963C80
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1
	private static Action<object, Func<T, TResult>> MtMmQuVwzogefEJCDsWpqAWNZnOU() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966480 Offset: 0x964A80 VA: 0x180966480
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MtMmQuVwzogefEJCDsWpqAWNZnOU
	*/

	// RVA: -1 Offset: -1
	private static void sxeYkfJQxZxeDLTOQDKEvngefLxi(object , Func<T, TResult> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966620 Offset: 0x964C20 VA: 0x180966620
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.sxeYkfJQxZxeDLTOQDKEvngefLxi
	*/

	// RVA: -1 Offset: -1
	public static SafeFunc<T, TResult> op_Addition(SafeFunc<T, TResult> eventList, Func<T, TResult> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9640E0 Offset: 0x9626E0 VA: 0x1809640E0
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Addition
	*/

	// RVA: -1 Offset: -1
	public static SafeFunc<T, TResult> op_Subtraction(SafeFunc<T, TResult> eventList, Func<T, TResult> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9643D0 Offset: 0x9629D0 VA: 0x1809643D0
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Subtraction
	*/

	// RVA: -1 Offset: -1
	public static Func<T, TResult> op_Implicit(SafeFunc<T, TResult> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964210 Offset: 0x962810 VA: 0x180964210
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static SafeFunc<T, TResult> op_Implicit(Func<T, TResult> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9642A0 Offset: 0x9628A0 VA: 0x1809642A0
	|-SafeFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Implicit
	*/
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class SafePredicate<T> : SafeDelegate<Predicate<T>> // TypeDefIndex: 2881
{
	// Fields
	private T WFklaQRKiufqnhNbEhJUDHMvaQRdA; // 0x0
	private bool MvogrjIVoexWCUSrDfEvvgBtNGmZ; // 0x0
	private static Action<object, Predicate<T>> cLfafJeHvtAtNvzwpGetDlODBchc; // 0x0

	// Properties
	private static Action<object, Predicate<T>> invokeDelegate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963550 Offset: 0x961B50 VA: 0x180963550
	|-SafePredicate<ControllerPollingInfo>..ctor
	|
	|-RVA: 0x95D160 Offset: 0x95B760 VA: 0x18095D160
	|-SafePredicate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Action<Exception> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9635D0 Offset: 0x961BD0 VA: 0x1809635D0
	|-SafePredicate<ControllerPollingInfo>..ctor
	|
	|-RVA: 0x963590 Offset: 0x961B90 VA: 0x180963590
	|-SafePredicate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SafePredicate<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963570 Offset: 0x961B70 VA: 0x180963570
	|-SafePredicate<ControllerPollingInfo>..ctor
	|
	|-RVA: 0x9635B0 Offset: 0x961BB0 VA: 0x1809635B0
	|-SafePredicate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9668D0 Offset: 0x964ED0 VA: 0x1809668D0
	|-SafePredicate<ControllerPollingInfo>.Invoke
	|
	|-RVA: 0x966A20 Offset: 0x965020 VA: 0x180966A20
	|-SafePredicate<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override object Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x962F60 Offset: 0x961560 VA: 0x180962F60
	|-SafePredicate<ControllerPollingInfo>.Clone
	|
	|-RVA: 0x962FE0 Offset: 0x9615E0 VA: 0x180962FE0
	|-SafePredicate<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1
	private static Action<object, Predicate<T>> quwKuZzbXOypRvIzvCpPqhZdLFEQ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963240 Offset: 0x961840 VA: 0x180963240
	|-SafePredicate<ControllerPollingInfo>.quwKuZzbXOypRvIzvCpPqhZdLFEQ
	|
	|-RVA: 0x9633B0 Offset: 0x9619B0 VA: 0x1809633B0
	|-SafePredicate<__Il2CppFullySharedGenericType>.quwKuZzbXOypRvIzvCpPqhZdLFEQ
	*/

	// RVA: -1 Offset: -1
	private static void NqUeVEirRHJSAhzZABgadYkeQvtPb(object , Predicate<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966C30 Offset: 0x965230 VA: 0x180966C30
	|-SafePredicate<ControllerPollingInfo>.NqUeVEirRHJSAhzZABgadYkeQvtPb
	|
	|-RVA: 0x966D50 Offset: 0x965350 VA: 0x180966D50
	|-SafePredicate<__Il2CppFullySharedGenericType>.NqUeVEirRHJSAhzZABgadYkeQvtPb
	*/

	// RVA: -1 Offset: -1
	public static SafePredicate<T> op_Addition(SafePredicate<T> eventList, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9637A0 Offset: 0x961DA0 VA: 0x1809637A0
	|-SafePredicate<ControllerPollingInfo>.op_Addition
	|
	|-RVA: 0x963670 Offset: 0x961C70 VA: 0x180963670
	|-SafePredicate<__Il2CppFullySharedGenericType>.op_Addition
	*/

	// RVA: -1 Offset: -1
	public static SafePredicate<T> op_Subtraction(SafePredicate<T> eventList, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963C20 Offset: 0x962220 VA: 0x180963C20
	|-SafePredicate<ControllerPollingInfo>.op_Subtraction
	|
	|-RVA: 0x963B80 Offset: 0x962180 VA: 0x180963B80
	|-SafePredicate<__Il2CppFullySharedGenericType>.op_Subtraction
	*/

	// RVA: -1 Offset: -1
	public static Predicate<T> op_Implicit(SafePredicate<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963A00 Offset: 0x962000 VA: 0x180963A00
	|-SafePredicate<ControllerPollingInfo>.op_Implicit
	|
	|-RVA: 0x963880 Offset: 0x961E80 VA: 0x180963880
	|-SafePredicate<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static SafePredicate<T> op_Implicit(Predicate<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963910 Offset: 0x961F10 VA: 0x180963910
	|-SafePredicate<ControllerPollingInfo>.op_Implicit
	|
	|-RVA: 0x963A50 Offset: 0x962050 VA: 0x180963A50
	|-SafePredicate<__Il2CppFullySharedGenericType>.op_Implicit
	*/
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class SystemInfo // TypeDefIndex: 2882
{
	// Fields
	public static readonly bool is64Bit; // 0x0

	// Methods

	// RVA: 0x17C1820 Offset: 0x17BFE20 VA: 0x1817C1820
	private static void .cctor() { }
}

// Namespace: Rewired.Utils
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal static class TempListPool // TypeDefIndex: 2886
{
	// Fields
	private const int WKyKGKlvHEbxULZLbWrvBHemhFUe = 3;
	private const int FbzcFwOWKhGsKGRFvorDjFZAjSLm = 10;
	private static ADictionary<Type, List<IList>> ZAmHMlelUaXnDoAtnKXroqRSiVrVA; // 0x0

	// Properties
	private static ADictionary<Type, List<IList>> lists { get; }

	// Methods

	// RVA: 0x17C1B30 Offset: 0x17C0130 VA: 0x1817C1B30
	private static ADictionary<Type, List<IList>> yXiDLYJEQRiuHrHlcvEGgdxogaaoA() { }

	// RVA: -1 Offset: -1
	public static TempListPool.TList<T> GetTList<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C3B70 Offset: 0x7C2170 VA: 0x1807C3B70
	|-TempListPool.GetTList<ControllerTemplateElementTarget>
	|-TempListPool.GetTList<object>
	|-TempListPool.GetTList<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|
	|-RVA: 0x7C3C10 Offset: 0x7C2210 VA: 0x1807C3C10
	|-TempListPool.GetTList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TempListPool.TList<T> GetTList<T>(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C3BC0 Offset: 0x7C21C0 VA: 0x1807C3BC0
	|-TempListPool.GetTList<ControllerTemplateElementTarget>
	|-TempListPool.GetTList<Int32Enum>
	|-TempListPool.GetTList<object>
	|-TempListPool.GetTList<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|
	|-RVA: 0x7C3C40 Offset: 0x7C2240 VA: 0x1807C3C40
	|-TempListPool.GetTList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ReturnTList<T>(TempListPool.TList<T> tList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C44F0 Offset: 0x7C2AF0 VA: 0x1807C44F0
	|-TempListPool.ReturnTList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<T> Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C44C0 Offset: 0x7C2AC0 VA: 0x1807C44C0
	|-TempListPool.Get<int>
	|
	|-RVA: 0x7C3C10 Offset: 0x7C2210 VA: 0x1807C3C10
	|-TempListPool.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<T> Get<T>(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C3C90 Offset: 0x7C2290 VA: 0x1807C3C90
	|-TempListPool.Get<ControllerTemplateElementTarget>
	|-TempListPool.Get<int>
	|-TempListPool.Get<Int32Enum>
	|-TempListPool.Get<object>
	|-TempListPool.Get<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|
	|-RVA: 0x7C40A0 Offset: 0x7C26A0 VA: 0x1807C40A0
	|-TempListPool.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Return<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C4530 Offset: 0x7C2B30 VA: 0x1807C4530
	|-TempListPool.Return<ControllerTemplateElementTarget>
	|-TempListPool.Return<object>
	|
	|-RVA: 0x7C4960 Offset: 0x7C2F60 VA: 0x1807C4960
	|-TempListPool.Return<int>
	|-TempListPool.Return<Int32Enum>
	|-TempListPool.Return<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>
	|
	|-RVA: 0x7C46E0 Offset: 0x7C2CE0 VA: 0x1807C46E0
	|-TempListPool.Return<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Return<T>(List<T> list1, List<T> list2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C4900 Offset: 0x7C2F00 VA: 0x1807C4900
	|-TempListPool.Return<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Return<T>(List<T> list1, List<T> list2, List<T> list3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C4880 Offset: 0x7C2E80 VA: 0x1807C4880
	|-TempListPool.Return<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17C1870 Offset: 0x17BFE70 VA: 0x1817C1870
	public static void Clear() { }

	// RVA: 0x17C1910 Offset: 0x17BFF10 VA: 0x1817C1910
	public static void Clear(Type listType) { }
}

// Namespace: Rewired.Utils
public static class ArrayTools // TypeDefIndex: 2887
{
	// Methods

	// RVA: 0x17AB7D0 Offset: 0x17A9DD0 VA: 0x1817AB7D0
	public static int[] ConvertToIntArray(Array array) { }

	// RVA: -1 Offset: -1
	public static T[] DeepClone<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6394F0 Offset: 0x637AF0 VA: 0x1806394F0
	|-ArrayTools.DeepClone<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] ShallowCopy<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63C1A0 Offset: 0x63A7A0 VA: 0x18063C1A0
	|-ArrayTools.ShallowCopy<int>
	|-ArrayTools.ShallowCopy<Int32Enum>
	|-ArrayTools.ShallowCopy<object>
	|-ArrayTools.ShallowCopy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ShallowCopy<T>(T[] sourceArray, T[] targetArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63C230 Offset: 0x63A830 VA: 0x18063C230
	|-ArrayTools.ShallowCopy<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17AC320 Offset: 0x17AA920 VA: 0x1817AC320
	public static void ShallowCopy(int[] sourceArray, int[] targetArray) { }

	// RVA: 0x17AC3A0 Offset: 0x17AA9A0 VA: 0x1817AC3A0
	public static void ShallowCopy(float[] sourceArray, float[] targetArray) { }

	// RVA: 0x17AC420 Offset: 0x17AAA20 VA: 0x1817AC420
	public static void ShallowCopy(bool[] sourceArray, bool[] targetArray) { }

	// RVA: 0x17ABB20 Offset: 0x17AA120 VA: 0x1817ABB20
	public static byte[] CopyRange(byte[] inArray, int startPos, int length) { }

	// RVA: 0x17ABA60 Offset: 0x17AA060 VA: 0x1817ABA60
	public static int[] CopyRange(int[] inArray, int startPos, int length) { }

	// RVA: 0x17ABCC0 Offset: 0x17AA2C0 VA: 0x1817ABCC0
	public static float[] CopyRange(float[] inArray, int startPos, int length) { }

	// RVA: 0x17ABBE0 Offset: 0x17AA1E0 VA: 0x1817ABBE0
	public static string[] CopyRange(string[] inArray, int startPos, int length) { }

	// RVA: 0x17AB610 Offset: 0x17A9C10 VA: 0x1817AB610
	public static byte[] Combine(byte[] inArray1, byte[] inArray2) { }

	// RVA: 0x17AB3F0 Offset: 0x17A99F0 VA: 0x1817AB3F0
	public static int[] Combine(int[] inArray1, int[] inArray2) { }

	// RVA: 0x17AB500 Offset: 0x17A9B00 VA: 0x1817AB500
	public static float[] Combine(float[] inArray1, float[] inArray2) { }

	// RVA: 0x17AB290 Offset: 0x17A9890 VA: 0x1817AB290
	public static string[] Combine(string[] inArray1, string[] inArray2) { }

	// RVA: -1 Offset: -1
	public static T[] ParseArray<T>(string line) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63AD30 Offset: 0x639330 VA: 0x18063AD30
	|-ArrayTools.ParseArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] SortAscending<T>(T[] array, out int[] sortedIndices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63C2B0 Offset: 0x63A8B0 VA: 0x18063C2B0
	|-ArrayTools.SortAscending<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] SortDescending<T>(T[] array, out int[] sortedIndices, bool ascending = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63C6E0 Offset: 0x63ACE0 VA: 0x18063C6E0
	|-ArrayTools.SortDescending<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int Add<T>(ref T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x637F90 Offset: 0x636590 VA: 0x180637F90
	|-ArrayTools.Add<object>
	|
	|-RVA: 0x637D50 Offset: 0x636350 VA: 0x180637D50
	|-ArrayTools.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int AddIfUnique<T>(ref T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6379C0 Offset: 0x635FC0 VA: 0x1806379C0
	|-ArrayTools.AddIfUnique<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int Insert<T>(ref T[] array, int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63A380 Offset: 0x638980 VA: 0x18063A380
	|-ArrayTools.Insert<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool RemoveAt<T>(ref T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63BD20 Offset: 0x63A320 VA: 0x18063BD20
	|-ArrayTools.RemoveAt<object>
	|
	|-RVA: 0x63BA80 Offset: 0x63A080 VA: 0x18063BA80
	|-ArrayTools.RemoveAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool Remove<T>(ref T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63C000 Offset: 0x63A600 VA: 0x18063C000
	|-ArrayTools.Remove<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Combine<T>(ref T[] array1, T[] array2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6386F0 Offset: 0x636CF0 VA: 0x1806386F0
	|-ArrayTools.Combine<object>
	|
	|-RVA: 0x638370 Offset: 0x636970 VA: 0x180638370
	|-ArrayTools.Combine<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] Add<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x637B30 Offset: 0x636130 VA: 0x180637B30
	|-ArrayTools.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] AddIfUnique<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x637850 Offset: 0x635E50 VA: 0x180637850
	|-ArrayTools.AddIfUnique<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] Insert<T>(T[] array, int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63A000 Offset: 0x638600 VA: 0x18063A000
	|-ArrayTools.Insert<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] RemoveAt<T>(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63B820 Offset: 0x639E20 VA: 0x18063B820
	|-ArrayTools.RemoveAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] Remove<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63BE70 Offset: 0x63A470 VA: 0x18063BE70
	|-ArrayTools.Remove<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] Combine<T>(T[] array1, T[] array2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6380A0 Offset: 0x6366A0 VA: 0x1806380A0
	|-ArrayTools.Combine<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x639E80 Offset: 0x638480 VA: 0x180639E80
	|-ArrayTools.IndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool Contains<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x638B00 Offset: 0x637100 VA: 0x180638B00
	|-ArrayTools.Contains<Guid>
	|
	|-RVA: 0x638E50 Offset: 0x637450 VA: 0x180638E50
	|-ArrayTools.Contains<int>
	|
	|-RVA: 0x6391D0 Offset: 0x6377D0 VA: 0x1806391D0
	|-ArrayTools.Contains<object>
	|
	|-RVA: 0x639010 Offset: 0x637610 VA: 0x180639010
	|-ArrayTools.Contains<PidVid>
	|
	|-RVA: 0x638CD0 Offset: 0x6372D0 VA: 0x180638CD0
	|-ArrayTools.Contains<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Find<T>(T[] array, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x639C70 Offset: 0x638270 VA: 0x180639C70
	|-ArrayTools.Find<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SubArray<T>(ref T[] array, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63CD10 Offset: 0x63B310 VA: 0x18063CD10
	|-ArrayTools.SubArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SubArray<T>(ref T[] array, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63CB10 Offset: 0x63B110 VA: 0x18063CB10
	|-ArrayTools.SubArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Expand<T>(ref T[] array, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x639620 Offset: 0x637C20 VA: 0x180639620
	|-ArrayTools.Expand<object>
	|-ArrayTools.Expand<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17AC990 Offset: 0x17AAF90 VA: 0x1817AC990
	public static void Trim(string[] array) { }

	// RVA: 0x17AC4A0 Offset: 0x17AAAA0 VA: 0x1817AC4A0
	public static RaycastHit[] SortNearToFar(RaycastHit[] hits) { }

	// RVA: -1 Offset: -1
	public static void MoveEntryUp<T>(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63AAC0 Offset: 0x6390C0 VA: 0x18063AAC0
	|-ArrayTools.MoveEntryUp<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void MoveEntryDown<T>(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63A850 Offset: 0x638E50 VA: 0x18063A850
	|-ArrayTools.MoveEntryDown<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Compact<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x638940 Offset: 0x636F40 VA: 0x180638940
	|-ArrayTools.Compact<object>
	*/

	// RVA: 0x17ABDD0 Offset: 0x17AA3D0 VA: 0x1817ABDD0
	public static int IndexOf(int[] array, int value) { }

	// RVA: 0x17ABF10 Offset: 0x17AA510 VA: 0x1817ABF10
	public static int IndexOf(float[] array, float value) { }

	// RVA: 0x17ABE10 Offset: 0x17AA410 VA: 0x1817ABE10
	public static int IndexOf(short[] array, short value) { }

	// RVA: 0x17ABE10 Offset: 0x17AA410 VA: 0x1817ABE10
	public static int IndexOf(ushort[] array, ushort value) { }

	// RVA: 0x17ABDD0 Offset: 0x17AA3D0 VA: 0x1817ABDD0
	public static int IndexOf(uint[] array, uint value) { }

	// RVA: 0x17ABD80 Offset: 0x17AA380 VA: 0x1817ABD80
	public static int IndexOf(double[] array, double value) { }

	// RVA: 0x17ABED0 Offset: 0x17AA4D0 VA: 0x1817ABED0
	public static int IndexOf(bool[] array, bool value) { }

	// RVA: 0x17ABE50 Offset: 0x17AA450 VA: 0x1817ABE50
	public static int IndexOf(string[] array, string value) { }

	// RVA: 0x17ABF60 Offset: 0x17AA560 VA: 0x1817ABF60
	public static int IndexOf(string[] array, string value, StringComparison stringComparison) { }

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6396C0 Offset: 0x637CC0 VA: 0x1806396C0
	|-ArrayTools.Fill<byte>
	|
	|-RVA: 0x639C30 Offset: 0x638230 VA: 0x180639C30
	|-ArrayTools.Fill<int>
	|
	|-RVA: 0x639AF0 Offset: 0x6380F0 VA: 0x180639AF0
	|-ArrayTools.Fill<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x639960 Offset: 0x637F60 VA: 0x180639960
	|-ArrayTools.Fill<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value, int startIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x639700 Offset: 0x637D00 VA: 0x180639700
	|-ArrayTools.Fill<byte>
	|
	|-RVA: 0x6397B0 Offset: 0x637DB0 VA: 0x1806397B0
	|-ArrayTools.Fill<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Populate<T>(T[] array, int startIndex, int length, Func<T> instantiator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63B3A0 Offset: 0x6399A0 VA: 0x18063B3A0
	|-ArrayTools.Populate<object>
	|
	|-RVA: 0x63B030 Offset: 0x639630 VA: 0x18063B030
	|-ArrayTools.Populate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Populate<T>(T[] array, int startIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63B640 Offset: 0x639C40 VA: 0x18063B640
	|-ArrayTools.Populate<object>
	*/

	// RVA: -1 Offset: -1
	public static void Populate<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63B5B0 Offset: 0x639BB0 VA: 0x18063B5B0
	|-ArrayTools.Populate<object>
	*/

	// RVA: -1 Offset: -1
	public static void Populate<T>(T[] array, Func<T> instantiator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63B300 Offset: 0x639900 VA: 0x18063B300
	|-ArrayTools.Populate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int Count<T>(T[] array, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x639390 Offset: 0x637990 VA: 0x180639390
	|-ArrayTools.Count<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17ABFE0 Offset: 0x17AA5E0 VA: 0x1817ABFE0
	public static bool IsEqual(byte[] a1, byte[] a2) { }

	// RVA: 0x17AB720 Offset: 0x17A9D20 VA: 0x1817AB720
	public static bool Contains(string[] array, string item, bool ignoreCase) { }

	// RVA: 0x17AB1A0 Offset: 0x17A97A0 VA: 0x1817AB1A0
	public static int AddIfUnique(ref string[] array, string item, bool ignoreCase) { }

	// RVA: 0x17AC050 Offset: 0x17AA650 VA: 0x1817AC050
	public static void RemoveDuplicates(ref string[] array, bool ignoreCase) { }

	// RVA: 0x17AC1D0 Offset: 0x17AA7D0 VA: 0x1817AC1D0
	public static bool Remove(ref string[] array, string item, bool ignoreCase) { }

	// RVA: 0x17AC880 Offset: 0x17AAE80 VA: 0x1817AC880
	public static string[] ToLowerStripSpaces(string[] array) { }

	// RVA: 0x17AC6D0 Offset: 0x17AACD0 VA: 0x1817AC6D0
	public static int ToBitmask(bool[] array, int startIndex, int count = 32) { }

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x63A720 Offset: 0x638D20 VA: 0x18063A720
	|-ArrayTools.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class BitTools // TypeDefIndex: 2888
{
	// Fields
	private static byte[] FzrnunGHtkRgLOqSFwjCWVtKTqz; // 0x0

	// Properties
	private static byte[] intToFloatBuffer { get; }

	// Methods

	// RVA: 0x17ACC30 Offset: 0x17AB230 VA: 0x1817ACC30
	public static void GetBytes(short value, byte[] buffer) { }

	// RVA: 0x17ACB40 Offset: 0x17AB140 VA: 0x1817ACB40
	public static void GetBytes(int value, byte[] buffer) { }

	// RVA: 0x17AC9F0 Offset: 0x17AAFF0 VA: 0x1817AC9F0
	public static void GetBytes(long value, byte[] buffer) { }

	// RVA: 0x17ACF00 Offset: 0x17AB500 VA: 0x1817ACF00
	private static byte[] kGhteybvBefafIDmpImiexdKzKol() { }

	// RVA: 0x17ACD00 Offset: 0x17AB300 VA: 0x1817ACD00
	public static float IntToFloat(IntPtr pointer, int offset = 0) { }
}

// Namespace: Rewired.Utils
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal static class CollectionTools // TypeDefIndex: 2889
{
	// Methods

	// RVA: -1 Offset: -1
	public static Dictionary<TValue, TKey> CreateInverseDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B5ED0 Offset: 0x6B44D0 VA: 0x1806B5ED0
	|-CollectionTools.CreateInverseDictionary<object, ulong>
	|
	|-RVA: 0x6B5A50 Offset: 0x6B4050 VA: 0x1806B5A50
	|-CollectionTools.CreateInverseDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B6620 Offset: 0x6B4C20 VA: 0x1806B6620
	|-CollectionTools.GetDictionaryValueSafe<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key, out bool success) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B66F0 Offset: 0x6B4CF0 VA: 0x1806B66F0
	|-CollectionTools.GetDictionaryValueSafe<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TValue GetDictionaryValueSafe<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B64E0 Offset: 0x6B4AE0 VA: 0x1806B64E0
	|-CollectionTools.GetDictionaryValueSafe<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TValue GetDictionaryValueSafe<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, out bool success) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B6310 Offset: 0x6B4910 VA: 0x1806B6310
	|-CollectionTools.GetDictionaryValueSafe<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key, ref TReturn value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B6880 Offset: 0x6B4E80 VA: 0x1806B6880
	|-CollectionTools.GetDictionaryValueSafe<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17AD950 Offset: 0x17ABF50 VA: 0x1817AD950
	public static bool GetDictionaryValueSafe(Dictionary<string, object> dictionary, string key, Type type, ref object value) { }

	// RVA: 0x17AD6A0 Offset: 0x17ABCA0 VA: 0x1817AD6A0
	public static bool GetDictionaryValueSafe_float(Dictionary<string, object> dictionary, string key, ref float value) { }

	// RVA: 0x17AD800 Offset: 0x17ABE00 VA: 0x1817AD800
	public static bool GetDictionaryValueSafe_int(Dictionary<string, object> dictionary, string key, ref int value) { }

	// RVA: 0x17AD5B0 Offset: 0x17ABBB0 VA: 0x1817AD5B0
	public static void AddValueSafe(Dictionary<string, object> data, string key, object value) { }

	// RVA: -1 Offset: -1
	public static T GetValue<T>(IEnumerable<T> enumerable, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B6D80 Offset: 0x6B5380 VA: 0x1806B6D80
	|-CollectionTools.GetValue<object>
	|
	|-RVA: 0x6B6BF0 Offset: 0x6B51F0 VA: 0x1806B6BF0
	|-CollectionTools.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T GetValue<T>(IEnumerable enumerable, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B6A50 Offset: 0x6B5050 VA: 0x1806B6A50
	|-CollectionTools.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Enqueue<T>(IObjectPool<T> pool, RingBuffer<T> buffer, T item, out bool overrun) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B6240 Offset: 0x6B4840 VA: 0x1806B6240
	|-CollectionTools.Enqueue<object>
	|
	|-RVA: 0x6B60A0 Offset: 0x6B46A0 VA: 0x1806B60A0
	|-CollectionTools.Enqueue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Clear<T>(IObjectPool<T> pool, RingBuffer<T> buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B5910 Offset: 0x6B3F10 VA: 0x1806B5910
	|-CollectionTools.Clear<object>
	|
	|-RVA: 0x6B57C0 Offset: 0x6B3DC0 VA: 0x1806B57C0
	|-CollectionTools.Clear<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Rewired.Utils
public static class EnumTools // TypeDefIndex: 2890
{
	// Methods

	// RVA: -1 Offset: -1
	public static string GetName<TEnum>(TEnum value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D97F0 Offset: 0x6D7DF0 VA: 0x1806D97F0
	|-EnumTools.GetName<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool ConvertByName<TEnumFrom, TEnumTo>(TEnumFrom convertFrom, out TEnumTo value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D9460 Offset: 0x6D7A60 VA: 0x1806D9460
	|-EnumTools.ConvertByName<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x17AE510 Offset: 0x17ACB10 VA: 0x1817AE510
	public static int[] GetIntValues(Type enumType) { }

	// RVA: 0x17AE600 Offset: 0x17ACC00 VA: 0x1817AE600
	public static bool IsEnum(Type type) { }

	// RVA: 0x17AE550 Offset: 0x17ACB50 VA: 0x1817AE550
	public static Type GetUnderlyingType(Type type) { }

	// RVA: 0x17AE660 Offset: 0x17ACC60 VA: 0x1817AE660
	public static bool IsValidUnderlyingType(Type underlyingType) { }
}

// Namespace: Rewired.Utils
public static class GUITools // TypeDefIndex: 2891
{
	// Methods

	// RVA: 0x17AEB20 Offset: 0x17AD120 VA: 0x1817AEB20
	public static GUIContent[] ToGUIContentArray(string[] items) { }

	// RVA: 0x17AE8C0 Offset: 0x17ACEC0 VA: 0x1817AE8C0
	public static GUIContent[] ToGUIContentArray(IList<string> items) { }
}

// Namespace: Rewired.Utils
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False)]
internal static class InputTools // TypeDefIndex: 2892
{
	// Methods

	// RVA: 0x17B1000 Offset: 0x17AF600 VA: 0x1817B1000
	public static float TransformAxis2DComponentValue(float value, float zero, float min, float max) { }

	// RVA: 0x17B0A40 Offset: 0x17AF040 VA: 0x1817B0A40
	public static float GetCalibratedAxisValueClamped(float value, float zero, float min, float max, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	// RVA: 0x17B0C20 Offset: 0x17AF220 VA: 0x1817B0C20
	public static float GetCalibratedAxisValue(float value, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	// RVA: 0x17B0330 Offset: 0x17AE930 VA: 0x1817B0330
	public static Vector2 ApplyRadialDeadZone(float xValue, float yValue, float deadzone) { }

	// RVA: 0x17B06B0 Offset: 0x17AECB0 VA: 0x1817B06B0
	public static float ApplySensitivity(float value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	// RVA: 0x17B11D0 Offset: 0x17AF7D0 VA: 0x1817B11D0
	private static bool ndtKfQGBQjGhMYFnScaADMPFMVhCb(AnimationCurve ) { }

	// RVA: 0x17B0560 Offset: 0x17AEB60 VA: 0x1817B0560
	public static void ApplyRadialSensitivity(ref Vector2 value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) { }

	// RVA: 0x17B09B0 Offset: 0x17AEFB0 VA: 0x1817B09B0
	public static string FormatHardwareIdentifierString(string str) { }

	// RVA: 0x17B0DE0 Offset: 0x17AF3E0 VA: 0x1817B0DE0
	public static AxisRange InvertAxisRange(AxisRange axisRange) { }

	// RVA: 0x17B0930 Offset: 0x17AEF30 VA: 0x1817B0930
	public static void CompareLastActiveController(Controller controller, ref Controller lastController, ref double lastTime) { }

	// RVA: 0x17B0E50 Offset: 0x17AF450 VA: 0x1817B0E50
	public static bool IsMappableControllerElementType(object type) { }

	// RVA: 0x17B0FE0 Offset: 0x17AF5E0 VA: 0x1817B0FE0
	public static bool IsMappableType(ControllerElementType type) { }

	// RVA: 0x17B0FF0 Offset: 0x17AF5F0 VA: 0x1817B0FF0
	public static bool IsMappableType(ControllerTemplateElementType type) { }

	// RVA: 0x17B0D10 Offset: 0x17AF310 VA: 0x1817B0D10
	public static bool HandleForced4WayHatsOnUnknownControllers(int direction, ref HatType hatType) { }

	// RVA: 0x17B08D0 Offset: 0x17AEED0 VA: 0x1817B08D0
	public static float AxisToDigitalValue(float value) { }

	// RVA: 0x17B0880 Offset: 0x17AEE80 VA: 0x1817B0880
	public static float AxisToDigitalValue(float value, float threshold) { }
}

// Namespace: Rewired.Utils
public static class ListTools // TypeDefIndex: 2893
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool OffsetAtIndex<T>(IList<T> list, int index, bool offsetDown, bool offsetNow = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72C0A0 Offset: 0x72A6A0 VA: 0x18072C0A0
	|-ListTools.OffsetAtIndex<object>
	|
	|-RVA: 0x72BDC0 Offset: 0x72A3C0 VA: 0x18072BDC0
	|-ListTools.OffsetAtIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<T> ShallowCopy<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72C410 Offset: 0x72AA10 VA: 0x18072C410
	|-ListTools.ShallowCopy<int>
	|
	|-RVA: 0x72C540 Offset: 0x72AB40 VA: 0x18072C540
	|-ListTools.ShallowCopy<object>
	|
	|-RVA: 0x72C2A0 Offset: 0x72A8A0 VA: 0x18072C2A0
	|-ListTools.ShallowCopy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CopyTo<T>(IList<T> fromList, IList<T> toList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72B200 Offset: 0x729800 VA: 0x18072B200
	|-ListTools.CopyTo<object>
	|
	|-RVA: 0x72AF30 Offset: 0x729530 VA: 0x18072AF30
	|-ListTools.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72B190 Offset: 0x729790 VA: 0x18072B190
	|-ListTools.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72B260 Offset: 0x729860 VA: 0x18072B260
	|-ListTools.CopyTo<object>
	|
	|-RVA: 0x72AF90 Offset: 0x729590 VA: 0x18072AF90
	|-ListTools.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] ToArray<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72C8B0 Offset: 0x72AEB0 VA: 0x18072C8B0
	|-ListTools.ToArray<object>
	|
	|-RVA: 0x72C680 Offset: 0x72AC80 VA: 0x18072C680
	|-ListTools.ToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<T> Combine<T>(IList<T> list1, IList<T> list2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72A3E0 Offset: 0x7289E0 VA: 0x18072A3E0
	|-ListTools.Combine<int>
	|
	|-RVA: 0x72A6E0 Offset: 0x728CE0 VA: 0x18072A6E0
	|-ListTools.Combine<object>
	|
	|-RVA: 0x72A080 Offset: 0x728680 VA: 0x18072A080
	|-ListTools.Combine<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72BC70 Offset: 0x72A270 VA: 0x18072BC70
	|-ListTools.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static List<object> ConvertToObjeclist<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72AC40 Offset: 0x729240 VA: 0x18072AC40
	|-ListTools.ConvertToObjeclist<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Concat<T>(IList<T> list1, IList<T> list2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72AA00 Offset: 0x729000 VA: 0x18072AA00
	|-ListTools.Concat<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool AddIfUnique<T>(IList<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x729F60 Offset: 0x728560 VA: 0x180729F60
	|-ListTools.AddIfUnique<object>
	|
	|-RVA: 0x729D70 Offset: 0x728370 VA: 0x180729D70
	|-ListTools.AddIfUnique<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int Count<T>(IList<T> list, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72B630 Offset: 0x729C30 VA: 0x18072B630
	|-ListTools.Count<object>
	|
	|-RVA: 0x72B450 Offset: 0x729A50 VA: 0x18072B450
	|-ListTools.Count<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void TryClear<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72CA40 Offset: 0x72B040 VA: 0x18072CA40
	|-ListTools.TryClear<object>
	|-ListTools.TryClear<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool ZsLpzgducDtTIwFopDwyMkhutEJi<>(IList<> ,  ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72CAA0 Offset: 0x72B0A0 VA: 0x18072CAA0
	|-ListTools.ZsLpzgducDtTIwFopDwyMkhutEJi<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int AddAndCreateList<T>(ref IList<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x729990 Offset: 0x727F90 VA: 0x180729990
	|-ListTools.AddAndCreateList<ControllerTemplateElementTarget>
	|
	|-RVA: 0x729C70 Offset: 0x728270 VA: 0x180729C70
	|-ListTools.AddAndCreateList<object>
	|
	|-RVA: 0x729B00 Offset: 0x728100 VA: 0x180729B00
	|-ListTools.AddAndCreateList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Find<T>(IList<T> list, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72BA90 Offset: 0x72A090 VA: 0x18072BA90
	|-ListTools.Find<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(IList<T> list, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72B7A0 Offset: 0x729DA0 VA: 0x18072B7A0
	|-ListTools.FindIndex<ElementAssignmentConflictInfo>
	|
	|-RVA: 0x72B940 Offset: 0x729F40 VA: 0x18072B940
	|-ListTools.FindIndex<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Rewired.Utils
public class MathTools // TypeDefIndex: 2894
{
	// Fields
	private const float RviPGMisBNqSldluQzhFSmRanhWN = 1E-10;
	private const double MjmTYuJlqjiNKwHslLVhCieBSeEK = 1E-10;
	private const float WQBDCoGXuoxeqmLLNvEKCQXWAUsY = 0.0001;
	public const float PI = 3.1415927;
	public const float Infinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float Deg2Rad = 0.017453292;
	public const float Rad2Deg = 57.29578;
	public const float Epsilon = 1E-45;

	// Methods

	// RVA: 0x17B3590 Offset: 0x17B1B90 VA: 0x1817B3590
	public static sbyte Abs(sbyte value) { }

	// RVA: 0x17B3600 Offset: 0x17B1C00 VA: 0x1817B3600
	public static short Abs(short value) { }

	// RVA: 0x17B3670 Offset: 0x17B1C70 VA: 0x1817B3670
	public static int Abs(int value) { }

	// RVA: 0x17B3490 Offset: 0x17B1A90 VA: 0x1817B3490
	public static long Abs(long value) { }

	// RVA: 0x17B36E0 Offset: 0x17B1CE0 VA: 0x1817B36E0
	public static float Abs(float value) { }

	// RVA: 0x17B3510 Offset: 0x17B1B10 VA: 0x1817B3510
	public static double Abs(double value) { }

	// RVA: 0x17B3920 Offset: 0x17B1F20 VA: 0x1817B3920
	public static bool Approximately(float a, float b) { }

	// RVA: 0x17B38E0 Offset: 0x17B1EE0 VA: 0x1817B38E0
	public static bool ApproximatelyZero(float a) { }

	// RVA: 0x17B4A30 Offset: 0x17B3030 VA: 0x1817B4A30
	public static bool IsZero(float value) { }

	// RVA: 0x17B4AA0 Offset: 0x17B30A0 VA: 0x1817B4AA0
	public static bool IsZero(float value, float threshold) { }

	// RVA: 0x17B4A80 Offset: 0x17B3080 VA: 0x1817B4A80
	public static bool IsZero(double value) { }

	// RVA: 0x17B4A50 Offset: 0x17B3050 VA: 0x1817B4A50
	public static bool IsZero(double value, double threshold) { }

	// RVA: 0x17B43B0 Offset: 0x17B29B0 VA: 0x1817B43B0
	public static bool IsExactlyEqual(float a, float b) { }

	// RVA: 0x17B43E0 Offset: 0x17B29E0 VA: 0x1817B43E0
	public static bool IsExactlyEqual(double a, double b) { }

	// RVA: 0x17B49C0 Offset: 0x17B2FC0 VA: 0x1817B49C0
	public static bool IsNear(float value, float targetValue) { }

	// RVA: 0x17B4A00 Offset: 0x17B3000 VA: 0x1817B4A00
	public static bool IsNear(float value, float targetValue, float threshold) { }

	// RVA: 0x17B4960 Offset: 0x17B2F60 VA: 0x1817B4960
	public static bool IsNearZero(float value) { }

	// RVA: 0x17B4990 Offset: 0x17B2F90 VA: 0x1817B4990
	public static bool IsNearZero(float value, float threshold) { }

	// RVA: 0x17B48E0 Offset: 0x17B2EE0 VA: 0x1817B48E0
	public static bool IsNearOrWholeNumber(float value) { }

	// RVA: 0x17B4790 Offset: 0x17B2D90 VA: 0x1817B4790
	public static bool IsNearOrWholeNumber(float value, float threshold) { }

	// RVA: 0x17B4820 Offset: 0x17B2E20 VA: 0x1817B4820
	public static bool IsNearOrWholeNumber(float value, out int number) { }

	// RVA: 0x17B46B0 Offset: 0x17B2CB0 VA: 0x1817B46B0
	public static bool IsNearOrWholeNumber(float value, out int number, float threshold) { }

	// RVA: 0x17B5D30 Offset: 0x17B4330 VA: 0x1817B5D30
	public static float RoundOffIfNearWholeNumber(float value) { }

	// RVA: 0x17B5E10 Offset: 0x17B4410 VA: 0x1817B5E10
	public static float RoundOffIfNearWholeNumber(float value, float threshold) { }

	// RVA: 0x1417700 Offset: 0x1415D00 VA: 0x181417700
	public static bool IsEven(int value) { }

	// RVA: 0x17B69C0 Offset: 0x17B4FC0 VA: 0x1817B69C0
	public static float ValueInNewRange(float oldValue, float oldMin, float oldMax, float newMin, float newMax) { }

	// RVA: 0x17B6990 Offset: 0x17B4F90 VA: 0x1817B6990
	public static int ValueInNewRange(int oldValue, int oldMin, int oldMax, int newMin, int newMax) { }

	// RVA: 0x150B1B0 Offset: 0x15097B0 VA: 0x18150B1B0
	public static sbyte Max(sbyte a, sbyte b) { }

	// RVA: 0x150B130 Offset: 0x1509730 VA: 0x18150B130
	public static byte Max(byte a, byte b) { }

	// RVA: 0x150B1A0 Offset: 0x15097A0 VA: 0x18150B1A0
	public static short Max(short a, short b) { }

	// RVA: 0x150B160 Offset: 0x1509760 VA: 0x18150B160
	public static ushort Max(ushort a, ushort b) { }

	// RVA: 0x150B140 Offset: 0x1509740 VA: 0x18150B140
	public static int Max(int a, int b) { }

	// RVA: 0x150B150 Offset: 0x1509750 VA: 0x18150B150
	public static uint Max(uint a, uint b) { }

	// RVA: 0x150B1F0 Offset: 0x15097F0 VA: 0x18150B1F0
	public static long Max(long a, long b) { }

	// RVA: 0x150B1C0 Offset: 0x15097C0 VA: 0x18150B1C0
	public static ulong Max(ulong a, ulong b) { }

	// RVA: 0x17B5510 Offset: 0x17B3B10 VA: 0x1817B5510
	public static float Max(float a, float b) { }

	// RVA: 0x17B5500 Offset: 0x17B3B00 VA: 0x1817B5500
	public static double Max(double a, double b) { }

	// RVA: 0x150B290 Offset: 0x1509890 VA: 0x18150B290
	public static sbyte Min(sbyte a, sbyte b) { }

	// RVA: 0x150B330 Offset: 0x1509930 VA: 0x18150B330
	public static byte Min(byte a, byte b) { }

	// RVA: 0x150B320 Offset: 0x1509920 VA: 0x18150B320
	public static short Min(short a, short b) { }

	// RVA: 0x150B390 Offset: 0x1509990 VA: 0x18150B390
	public static ushort Min(ushort a, ushort b) { }

	// RVA: 0x150B340 Offset: 0x1509940 VA: 0x18150B340
	public static int Min(int a, int b) { }

	// RVA: 0x150B350 Offset: 0x1509950 VA: 0x18150B350
	public static uint Min(uint a, uint b) { }

	// RVA: 0x150B3A0 Offset: 0x15099A0 VA: 0x18150B3A0
	public static long Min(long a, long b) { }

	// RVA: 0x150B2A0 Offset: 0x15098A0 VA: 0x18150B2A0
	public static ulong Min(ulong a, ulong b) { }

	// RVA: 0x17B5730 Offset: 0x17B3D30 VA: 0x1817B5730
	public static float Min(float a, float b) { }

	// RVA: 0x17B5740 Offset: 0x17B3D40 VA: 0x1817B5740
	public static double Min(double a, double b) { }

	// RVA: 0x17B5330 Offset: 0x17B3930 VA: 0x1817B5330
	public static sbyte MaxMagnitude(sbyte a, sbyte b) { }

	// RVA: 0x150B130 Offset: 0x1509730 VA: 0x18150B130
	public static byte MaxMagnitude(byte a, byte b) { }

	// RVA: 0x17B5480 Offset: 0x17B3A80 VA: 0x1817B5480
	public static short MaxMagnitude(short a, short b) { }

	// RVA: 0x150B160 Offset: 0x1509760 VA: 0x18150B160
	public static ushort MaxMagnitude(ushort a, ushort b) { }

	// RVA: 0x17B53D0 Offset: 0x17B39D0 VA: 0x1817B53D0
	public static int MaxMagnitude(int a, int b) { }

	// RVA: 0x150B150 Offset: 0x1509750 VA: 0x18150B150
	public static uint MaxMagnitude(uint a, uint b) { }

	// RVA: 0x17B5360 Offset: 0x17B3960 VA: 0x1817B5360
	public static long MaxMagnitude(long a, long b) { }

	// RVA: 0x150B1C0 Offset: 0x15097C0 VA: 0x18150B1C0
	public static ulong MaxMagnitude(ulong a, ulong b) { }

	// RVA: 0x17B5390 Offset: 0x17B3990 VA: 0x1817B5390
	public static float MaxMagnitude(float a, float b) { }

	// RVA: 0x17B52F0 Offset: 0x17B38F0 VA: 0x1817B52F0
	public static double MaxMagnitude(double a, double b) { }

	// RVA: 0x17B5520 Offset: 0x17B3B20 VA: 0x1817B5520
	public static sbyte MinMagnitude(sbyte a, sbyte b) { }

	// RVA: 0x150B330 Offset: 0x1509930 VA: 0x18150B330
	public static byte MinMagnitude(byte a, byte b) { }

	// RVA: 0x17B5690 Offset: 0x17B3C90 VA: 0x1817B5690
	public static short MinMagnitude(short a, short b) { }

	// RVA: 0x150B390 Offset: 0x1509990 VA: 0x18150B390
	public static ushort MinMagnitude(ushort a, ushort b) { }

	// RVA: 0x17B5700 Offset: 0x17B3D00 VA: 0x1817B5700
	public static int MinMagnitude(int a, int b) { }

	// RVA: 0x150B350 Offset: 0x1509950 VA: 0x18150B350
	public static uint MinMagnitude(uint a, uint b) { }

	// RVA: 0x17B5550 Offset: 0x17B3B50 VA: 0x1817B5550
	public static long MinMagnitude(long a, long b) { }

	// RVA: 0x150B2A0 Offset: 0x15098A0 VA: 0x18150B2A0
	public static ulong MinMagnitude(ulong a, ulong b) { }

	// RVA: 0x17B5600 Offset: 0x17B3C00 VA: 0x1817B5600
	public static float MinMagnitude(float a, float b) { }

	// RVA: 0x17B56C0 Offset: 0x17B3CC0 VA: 0x1817B56C0
	public static double MinMagnitude(double a, double b) { }

	// RVA: 0x17B4680 Offset: 0x17B2C80 VA: 0x1817B4680
	public static bool IsMoreMagnitudeOrEqual(sbyte a, sbyte b) { }

	// RVA: 0x17B4660 Offset: 0x17B2C60 VA: 0x1817B4660
	public static bool IsMoreMagnitudeOrEqual(byte a, byte b) { }

	// RVA: 0x17B4600 Offset: 0x17B2C00 VA: 0x1817B4600
	public static bool IsMoreMagnitudeOrEqual(short a, short b) { }

	// RVA: 0x17B45C0 Offset: 0x17B2BC0 VA: 0x1817B45C0
	public static bool IsMoreMagnitudeOrEqual(ushort a, ushort b) { }

	// RVA: 0x17B4560 Offset: 0x17B2B60 VA: 0x1817B4560
	public static bool IsMoreMagnitudeOrEqual(int a, int b) { }

	// RVA: 0x17B45B0 Offset: 0x17B2BB0 VA: 0x1817B45B0
	public static bool IsMoreMagnitudeOrEqual(uint a, uint b) { }

	// RVA: 0x17B45D0 Offset: 0x17B2BD0 VA: 0x1817B45D0
	public static bool IsMoreMagnitudeOrEqual(long a, long b) { }

	// RVA: 0x17B4670 Offset: 0x17B2C70 VA: 0x1817B4670
	public static bool IsMoreMagnitudeOrEqual(ulong a, ulong b) { }

	// RVA: 0x17B4580 Offset: 0x17B2B80 VA: 0x1817B4580
	public static bool IsMoreMagnitudeOrEqual(float a, float b) { }

	// RVA: 0x17B4630 Offset: 0x17B2C30 VA: 0x1817B4630
	public static bool IsMoreMagnitudeOrEqual(double a, double b) { }

	// RVA: 0x17B4460 Offset: 0x17B2A60 VA: 0x1817B4460
	public static bool IsLessMagnitudeOrEqual(sbyte a, sbyte b) { }

	// RVA: 0x17B44F0 Offset: 0x17B2AF0 VA: 0x1817B44F0
	public static bool IsLessMagnitudeOrEqual(byte a, byte b) { }

	// RVA: 0x17B44C0 Offset: 0x17B2AC0 VA: 0x1817B44C0
	public static bool IsLessMagnitudeOrEqual(short a, short b) { }

	// RVA: 0x17B4490 Offset: 0x17B2A90 VA: 0x1817B4490
	public static bool IsLessMagnitudeOrEqual(ushort a, ushort b) { }

	// RVA: 0x17B4410 Offset: 0x17B2A10 VA: 0x1817B4410
	public static bool IsLessMagnitudeOrEqual(int a, int b) { }

	// RVA: 0x17B44A0 Offset: 0x17B2AA0 VA: 0x1817B44A0
	public static bool IsLessMagnitudeOrEqual(uint a, uint b) { }

	// RVA: 0x17B4430 Offset: 0x17B2A30 VA: 0x1817B4430
	public static bool IsLessMagnitudeOrEqual(long a, long b) { }

	// RVA: 0x17B44B0 Offset: 0x17B2AB0 VA: 0x1817B44B0
	public static bool IsLessMagnitudeOrEqual(ulong a, ulong b) { }

	// RVA: 0x17B4500 Offset: 0x17B2B00 VA: 0x1817B4500
	public static bool IsLessMagnitudeOrEqual(float a, float b) { }

	// RVA: 0x17B4530 Offset: 0x17B2B30 VA: 0x1817B4530
	public static bool IsLessMagnitudeOrEqual(double a, double b) { }

	// RVA: 0x17B3E40 Offset: 0x17B2440 VA: 0x1817B3E40
	public static byte Clamp(byte value, byte min, byte max) { }

	// RVA: 0x17B3DB0 Offset: 0x17B23B0 VA: 0x1817B3DB0
	public static sbyte Clamp(sbyte value, sbyte min, sbyte max) { }

	// RVA: 0x17B3CB0 Offset: 0x17B22B0 VA: 0x1817B3CB0
	public static short Clamp(short value, short min, short max) { }

	// RVA: 0x17B3D50 Offset: 0x17B2350 VA: 0x1817B3D50
	public static ushort Clamp(ushort value, ushort min, ushort max) { }

	// RVA: 0x17B3D90 Offset: 0x17B2390 VA: 0x1817B3D90
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x17B3E20 Offset: 0x17B2420 VA: 0x1817B3E20
	public static uint Clamp(uint value, uint min, uint max) { }

	// RVA: 0x17B3D30 Offset: 0x17B2330 VA: 0x1817B3D30
	public static long Clamp(long value, long min, long max) { }

	// RVA: 0x17B3F20 Offset: 0x17B2520 VA: 0x1817B3F20
	public static ulong Clamp(ulong value, ulong min, ulong max) { }

	// RVA: 0x17B3F00 Offset: 0x17B2500 VA: 0x1817B3F00
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x17B3D70 Offset: 0x17B2370 VA: 0x1817B3D70
	public static double Clamp(double value, double min, double max) { }

	// RVA: 0x17B3B90 Offset: 0x17B2190 VA: 0x1817B3B90
	public static float Clamp01(float value) { }

	// RVA: 0x17B3BB0 Offset: 0x17B21B0 VA: 0x1817B3BB0
	public static float ClampAngle360(float angle) { }

	// RVA: 0x17B5AC0 Offset: 0x17B40C0 VA: 0x1817B5AC0
	public static float ReverseAngleRotationDirection(float angle) { }

	// RVA: 0x17B3840 Offset: 0x17B1E40 VA: 0x1817B3840
	public static bool AngleIsNear(float angle, float targetAngle, float threshold) { }

	// RVA: 0x17B37C0 Offset: 0x17B1DC0 VA: 0x1817B37C0
	public static bool AngleIsBetween(float angle, float min, float max) { }

	// RVA: 0x17B6A70 Offset: 0x17B5070 VA: 0x1817B6A70
	internal static bool XmZLDeRdWmaXvdTHznqKohvtLKxy(int , int ) { }

	// RVA: 0x17B4390 Offset: 0x17B2990 VA: 0x1817B4390
	public static int IntPow(int x, uint pow) { }

	// RVA: 0x17B5F60 Offset: 0x17B4560 VA: 0x1817B5F60
	public static uint RoundUpToPowerOf2(uint value) { }

	// RVA: 0x17B3AB0 Offset: 0x17B20B0 VA: 0x1817B3AB0
	public static float BooleanToSign(bool b) { }

	// RVA: 0x17B6000 Offset: 0x17B4600 VA: 0x1817B6000
	public static bool SignToBoolean(float sign) { }

	// RVA: 0x17B6120 Offset: 0x17B4720 VA: 0x1817B6120
	public static float Sin(float value) { }

	// RVA: 0x17B3F40 Offset: 0x17B2540 VA: 0x1817B3F40
	public static float Cos(float value) { }

	// RVA: 0x17B6610 Offset: 0x17B4C10 VA: 0x1817B6610
	public static float Tan(float value) { }

	// RVA: 0x17B3980 Offset: 0x17B1F80 VA: 0x1817B3980
	public static float Asin(float value) { }

	// RVA: 0x17B3760 Offset: 0x17B1D60 VA: 0x1817B3760
	public static float Acos(float value) { }

	// RVA: 0x17B3A50 Offset: 0x17B2050 VA: 0x1817B3A50
	public static float Atan(float value) { }

	// RVA: 0x17B39E0 Offset: 0x17B1FE0 VA: 0x1817B39E0
	public static float Atan2(float y, float x) { }

	// RVA: 0x17B6590 Offset: 0x17B4B90 VA: 0x1817B6590
	public static float Sqrt(float value) { }

	// RVA: 0x17B5780 Offset: 0x17B3D80 VA: 0x1817B5780
	public static float Pow(float value, float p) { }

	// RVA: 0x17B41A0 Offset: 0x17B27A0 VA: 0x1817B41A0
	public static float Exp(float power) { }

	// RVA: 0x17B5220 Offset: 0x17B3820 VA: 0x1817B5220
	public static float Log(float value, float p) { }

	// RVA: 0x17B5290 Offset: 0x17B3890 VA: 0x1817B5290
	public static float Log(float value) { }

	// RVA: 0x17B51C0 Offset: 0x17B37C0 VA: 0x1817B51C0
	public static float Log10(float value) { }

	// RVA: 0x17B3B30 Offset: 0x17B2130 VA: 0x1817B3B30
	public static float Ceil(float value) { }

	// RVA: 0x17B4260 Offset: 0x17B2860 VA: 0x1817B4260
	public static float Floor(float value) { }

	// RVA: 0x17B5FA0 Offset: 0x17B45A0 VA: 0x1817B5FA0
	public static float Round(float value) { }

	// RVA: 0x17B3AD0 Offset: 0x17B20D0 VA: 0x1817B3AD0
	public static int CeilToInt(float value) { }

	// RVA: 0x17B4200 Offset: 0x17B2800 VA: 0x1817B4200
	public static int FloorToInt(float value) { }

	// RVA: 0x17B5F00 Offset: 0x17B4500 VA: 0x1817B5F00
	public static int RoundToInt(float value) { }

	// RVA: 0x17B6020 Offset: 0x17B4620 VA: 0x1817B6020
	public static float Sign(float value) { }

	// RVA: 0x17B6010 Offset: 0x17B4610 VA: 0x1817B6010
	public static int Sign(int value) { }

	// RVA: 0x17B5A30 Offset: 0x17B4030 VA: 0x1817B5A30
	public static float Repeat(float t, float length) { }

	// RVA: 0x17B3FD0 Offset: 0x17B25D0 VA: 0x1817B3FD0
	public static float DeltaAngle(float current, float target) { }

	// RVA: 0x17B54B0 Offset: 0x17B3AB0 VA: 0x1817B54B0
	public static Vector2 MaxMagnitude(Vector2 a, Vector2 b) { }

	// RVA: 0x17B5400 Offset: 0x17B3A00 VA: 0x1817B5400
	public static Vector3 MaxMagnitude(Vector3 a, Vector3 b) { }

	// RVA: 0x17B5640 Offset: 0x17B3C40 VA: 0x1817B5640
	public static Vector2 MinMagnitude(Vector2 a, Vector2 b) { }

	// RVA: 0x17B5580 Offset: 0x17B3B80 VA: 0x1817B5580
	public static Vector3 MinMagnitude(Vector3 a, Vector3 b) { }

	// RVA: 0x17B3CD0 Offset: 0x17B22D0 VA: 0x1817B3CD0
	public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max) { }

	// RVA: 0x17B3E60 Offset: 0x17B2460 VA: 0x1817B3E60
	public static Vector2 Clamp(Vector2 value, float min, float max) { }

	// RVA: 0x17B3DD0 Offset: 0x17B23D0 VA: 0x1817B3DD0
	public static Vector2 Clamp(Vector3 value, Vector3 min, Vector3 max) { }

	// RVA: 0x17B3EC0 Offset: 0x17B24C0 VA: 0x1817B3EC0
	public static Vector2 Clamp(Vector3 value, float min, float max) { }

	// RVA: 0x17B3FA0 Offset: 0x17B25A0 VA: 0x1817B3FA0
	public static float Cross(Vector2 a, Vector2 b) { }

	// RVA: 0x17B5750 Offset: 0x17B3D50 VA: 0x1817B5750
	public static float Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x17B5840 Offset: 0x17B3E40 VA: 0x1817B5840
	public static bool RectContains(Rect rect, Vector2 pos, float rotation = 0) { }

	// RVA: 0x17B5C00 Offset: 0x17B4200 VA: 0x1817B5C00
	public static Vector2 RotateWorldPoint(Vector2 point, Vector2 center, float angle) { }

	// RVA: 0x17B5B00 Offset: 0x17B4100 VA: 0x1817B5B00
	public static Vector2 RotateLocalPoint(Vector2 point, float angle) { }

	// RVA: 0x17B4AD0 Offset: 0x17B30D0 VA: 0x1817B4AD0
	public static bool LineIntersectsRect(Vector2 point1, Vector2 point2, Rect rect, out float sqrMagnitude) { }

	// RVA: 0x17B4EF0 Offset: 0x17B34F0 VA: 0x1817B4EF0
	public static bool LineSegementsIntersect(Vector2 line1p1, Vector2 line1p2, Vector2 line2p1, Vector2 line2p2, out Vector2 intersection, bool collinearIntersects = False) { }

	// RVA: 0x17B4070 Offset: 0x17B2670 VA: 0x1817B4070
	private static bool DmRajBbbvfZwYTcIUZnLhNmtnuLw(Vector2 , Vector2 , Vector2 , Vector2 , out Vector2 ) { }

	// RVA: 0x17B57F0 Offset: 0x17B3DF0 VA: 0x1817B57F0
	public static bool RectContains(Rect container, Rect child) { }

	// RVA: 0x17B42C0 Offset: 0x17B28C0 VA: 0x1817B42C0
	public static bool GetOffsetToContainRect(Rect container, Rect child, out Vector2 offset) { }

	// RVA: 0x17B6870 Offset: 0x17B4E70 VA: 0x1817B6870
	public static Matrix4x4 TransformTo(Transform from, Transform to) { }

	// RVA: 0x17B6670 Offset: 0x17B4C70 VA: 0x1817B6670
	public static Rect TransformRect(Rect fromRect, Transform from, Transform to) { }

	// RVA: 0x17B6180 Offset: 0x17B4780 VA: 0x1817B6180
	public static Vector2 SnapVectorToNearestAngle(Vector2 vector, float angle) { }

	// RVA: 0x17B6040 Offset: 0x17B4640 VA: 0x1817B6040
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class MiscTools // TypeDefIndex: 2895
{
	// Fields
	private static uint wlkvxaHCCTIMKdscVFkzHArAkONfA; // 0x0
	private static uint DemnSrzZMRTVtBeIFgIgLbhuQcOr; // 0x4
	private static uint FBVyimDIUBjACloznAJvhjzmAzzR; // 0x8
	private static int DexzCEyWHcFCfNgXsrfuHAgYQHPf; // 0xC
	private static int zVFrgFZJXEUVQvNzouwuNvnlXaPB; // 0x10
	private static int xAXcoleMtPMmQQpSgBCEAjueeaVj; // 0x14

	// Methods

	// RVA: 0x17B6C00 Offset: 0x17B5200 VA: 0x1817B6C00
	public static object Clone(object obj) { }

	// RVA: -1 Offset: -1
	public static T Clone<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x735B10 Offset: 0x734110 VA: 0x180735B10
	|-MiscTools.Clone<object>
	*/

	// RVA: -1 Offset: -1
	public static T DeepClone<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x736250 Offset: 0x734850 VA: 0x180736250
	|-MiscTools.DeepClone<object>
	*/

	// RVA: -1 Offset: -1
	public static T DeepClone<T>(T obj, bool createIfNull) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7362E0 Offset: 0x7348E0 VA: 0x1807362E0
	|-MiscTools.DeepClone<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] DeepClone<T>(T[] obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x736550 Offset: 0x734B50 VA: 0x180736550
	|-MiscTools.DeepClone<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> DeepClone<T>(List<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x736370 Offset: 0x734970 VA: 0x180736370
	|-MiscTools.DeepClone<object>
	*/

	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x736000 Offset: 0x734600 VA: 0x180736000
	|-MiscTools.DeepClone<int, object>
	|
	|-RVA: 0x735BA0 Offset: 0x7341A0 VA: 0x180735BA0
	|-MiscTools.DeepClone<__Il2CppFullySharedGenericType, object>
	*/

	// RVA: 0x17B6DE0 Offset: 0x17B53E0 VA: 0x1817B6DE0
	public static Guid CreateGuidHashSHA256(string text) { }

	// RVA: 0x17B6C80 Offset: 0x17B5280 VA: 0x1817B6C80
	public static Guid CreateGuidHashSHA1(string text) { }

	// RVA: 0x17B6FC0 Offset: 0x17B55C0 VA: 0x1817B6FC0
	public static Bytes20 HashSHA1(string text) { }

	// RVA: 0x17B6F10 Offset: 0x17B5510 VA: 0x1817B6F10
	public static Guid CreateHIDProductGuid(int vendorId, int productId) { }

	// RVA: 0x17B7830 Offset: 0x17B5E30 VA: 0x1817B7830
	public static uint Tick(uint counter) { }

	// RVA: 0x17B78B0 Offset: 0x17B5EB0 VA: 0x1817B78B0
	public static int Tick(int counter) { }

	// RVA: 0x17B77B0 Offset: 0x17B5DB0 VA: 0x1817B77B0
	public static uint TickPrev(uint counter) { }

	// RVA: 0x17B76E0 Offset: 0x17B5CE0 VA: 0x1817B76E0
	public static int TickPrev(int counter) { }

	// RVA: 0x17B73F0 Offset: 0x17B59F0 VA: 0x1817B73F0
	public static bool IsTickValid(uint tick) { }

	// RVA: 0x17B7450 Offset: 0x17B5A50 VA: 0x1817B7450
	public static bool IsTickValid(int tick) { }

	// RVA: 0x17B7290 Offset: 0x17B5890 VA: 0x1817B7290
	public static bool IsTickNewer(uint tick1, uint tick2) { }

	// RVA: 0x17B7340 Offset: 0x17B5940 VA: 0x1817B7340
	public static bool IsTickNewer(int tick1, int tick2) { }

	// RVA: 0x17B71E0 Offset: 0x17B57E0 VA: 0x1817B71E0
	public static bool IsTickNewerOrEqualTo(uint tick1, uint tick2) { }

	// RVA: 0x17B7130 Offset: 0x17B5730 VA: 0x1817B7130
	public static bool IsTickNewerOrEqualTo(int tick1, int tick2) { }

	// RVA: 0x17B74E0 Offset: 0x17B5AE0 VA: 0x1817B74E0
	public static long TickDifference(uint tick1, uint tick2) { }

	// RVA: 0x17B75E0 Offset: 0x17B5BE0 VA: 0x1817B75E0
	public static int TickDifference(int tick1, int tick2) { }

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x736870 Offset: 0x734E70 VA: 0x180736870
	|-MiscTools.Swap<object>
	|
	|-RVA: 0x7366D0 Offset: 0x734CD0 VA: 0x1807366D0
	|-MiscTools.Swap<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17B7930 Offset: 0x17B5F30 VA: 0x1817B7930
	public static long ToLongUnchecked(object value) { }

	// RVA: 0x17B74B0 Offset: 0x17B5AB0 VA: 0x1817B74B0
	public static bool IsValidGuid(string guid) { }

	// RVA: 0x17B7C90 Offset: 0x17B6290 VA: 0x1817B7C90
	private static void .cctor() { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class NativeTools // TypeDefIndex: 2896
{
	// Fields
	private static byte[] GblhcqRovoODkWBcueHqwaOcgVGk; // 0x0

	// Methods

	// RVA: 0x17B9B10 Offset: 0x17B8110 VA: 0x1817B9B10
	public static IntPtr OffsetIntPtr(IntPtr intPtr, int offset) { }

	// RVA: 0x17B87E0 Offset: 0x17B6DE0 VA: 0x1817B87E0
	public static bool CopyMemory(IntPtr source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = True) { }

	// RVA: 0x17B8550 Offset: 0x17B6B50 VA: 0x1817B8550
	public static bool CopyMemory(byte[] source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = True) { }

	// RVA: 0x17B8BB0 Offset: 0x17B71B0 VA: 0x1817B8BB0
	public static bool CopyMemory(IntPtr source, byte[] destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = True) { }

	// RVA: 0x17B8F90 Offset: 0x17B7590 VA: 0x1817B8F90
	public static bool FillMemory(IntPtr buffer, int length, byte value, bool throwOnError = True) { }

	// RVA: 0x17B9240 Offset: 0x17B7840 VA: 0x1817B9240
	public static bool FillMemory(IntPtr buffer, int startIndex, int length, byte value, bool throwOnError = True) { }

	// RVA: 0x17B9A70 Offset: 0x17B8070 VA: 0x1817B9A70
	public static bool FillMemory(byte[] buffer, int length, byte value, bool throwOnError = True) { }

	// RVA: 0x17B8FC0 Offset: 0x17B75C0 VA: 0x1817B8FC0
	public static bool FillMemory(byte[] buffer, int startIndex, int length, byte value, bool throwOnError = True) { }

	// RVA: 0x17B9BE0 Offset: 0x17B81E0 VA: 0x1817B9BE0
	public static void ZeroFillMemory(IntPtr buffer, int length) { }

	// RVA: 0x17B8E40 Offset: 0x17B7440 VA: 0x1817B8E40
	public static string DumpToString(IntPtr buffer, int length, string stringFormat = "x2") { }

	// RVA: 0x17B9AA0 Offset: 0x17B80A0 VA: 0x1817B9AA0
	public static void FreeHGlobalSafe(ref IntPtr pointer) { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
public static class ReflectionTools // TypeDefIndex: 2898
{
	// Methods

	// RVA: 0x16335D0 Offset: 0x1631BD0 VA: 0x1816335D0
	public static bool IsValueType(Type type) { }

	// RVA: 0x17AE600 Offset: 0x17ACC00 VA: 0x1817AE600
	public static bool IsEnum(Type type) { }

	// RVA: 0x17AE550 Offset: 0x17ACB50 VA: 0x1817AE550
	public static Type GetUnderlyingEnumType(Type enumType) { }

	// RVA: 0x16334C0 Offset: 0x1631AC0 VA: 0x1816334C0
	public static bool IsClass(Type type) { }

	// RVA: 0x1633590 Offset: 0x1631B90 VA: 0x181633590
	public static bool IsPrimitive(Type type) { }

	// RVA: 0x17BA2F0 Offset: 0x17B88F0 VA: 0x1817BA2F0
	public static bool IsArray(Type type) { }

	// RVA: 0x17B9E00 Offset: 0x17B8400 VA: 0x1817B9E00
	public static bool DoesTypeImplement(Type type, Type baseOrInterfaceType) { }

	// RVA: 0x17BA570 Offset: 0x17B8B70 VA: 0x1817BA570
	public static bool IsGenericType(Type type) { }

	// RVA: 0x17B9F00 Offset: 0x17B8500 VA: 0x1817B9F00
	public static Type[] GetGenericArguments(Type type) { }

	// RVA: 0x17B9EA0 Offset: 0x17B84A0 VA: 0x1817B9EA0
	public static IEnumerable<FieldInfo> GetFields(Type type) { }

	// RVA: 0x17B9E30 Offset: 0x17B8430 VA: 0x1817B9E30
	public static IEnumerable<FieldInfo> GetFields(Type type, ReflectionTools.BindingFlags bindingFlags) { }

	// RVA: 0x17BA040 Offset: 0x17B8640 VA: 0x1817BA040
	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	// RVA: 0x17BA0A0 Offset: 0x17B86A0 VA: 0x1817BA0A0
	public static IEnumerable<PropertyInfo> GetProperties(Type type, ReflectionTools.BindingFlags bindingFlags) { }

	// RVA: 0x17B9FE0 Offset: 0x17B85E0 VA: 0x1817B9FE0
	public static IEnumerable<MethodInfo> GetMethods(Type type) { }

	// RVA: 0x17B9F70 Offset: 0x17B8570 VA: 0x1817B9F70
	public static IEnumerable<MethodInfo> GetMethods(Type type, ReflectionTools.BindingFlags bindingFlags) { }

	// RVA: 0x17BA4C0 Offset: 0x17B8AC0 VA: 0x1817BA4C0
	public static bool IsDefined(Type type, Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x790060 Offset: 0x78E660 VA: 0x180790060
	|-ReflectionTools.GetAttribute<object>
	*/

	// RVA: 0x17BA310 Offset: 0x17B8910 VA: 0x1817BA310
	internal static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase) { }

	// RVA: 0x17BA1F0 Offset: 0x17B87F0 VA: 0x1817BA1F0
	internal static Type GetTypeInUnityEditorAssembly(string classPath, bool ignoreCase = False) { }

	// RVA: 0x17BA1E0 Offset: 0x17B87E0 VA: 0x1817BA1E0
	internal static Type GetTypeInUnityBuildAssembly(string classPath, bool ignoreCase = False) { }

	// RVA: 0x17BA200 Offset: 0x17B8800 VA: 0x1817BA200
	private static Type HCvyACfqqnhGPmCEUYNNqOqKtmtn(string , bool , bool  = False) { }

	// RVA: 0x17BA110 Offset: 0x17B8710 VA: 0x1817BA110
	internal static Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = False) { }

	// RVA: -1 Offset: -1
	public static TRet GetPrivateField<T, TRet>(T obj, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x790170 Offset: 0x78E770 VA: 0x180790170
	|-ReflectionTools.GetPrivateField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TRet GetPrivateProperty<T, TRet>(T obj, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x790310 Offset: 0x78E910 VA: 0x180790310
	|-ReflectionTools.GetPrivateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetPrivateField<T>(T obj, string name, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7904A0 Offset: 0x78EAA0 VA: 0x1807904A0
	|-ReflectionTools.SetPrivateField<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetPrivateProperty<T>(T obj, string name, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7905D0 Offset: 0x78EBD0 VA: 0x1807905D0
	|-ReflectionTools.SetPrivateProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TRet CallPrivateMethod<T, TRet>(T obj, string name, object[] param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78FED0 Offset: 0x78E4D0 VA: 0x18078FED0
	|-ReflectionTools.CallPrivateMethod<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17B9F60 Offset: 0x17B8560 VA: 0x1817B9F60
	public static MethodInfo GetMethodInfo(Delegate delegate) { }
}

// Namespace: Rewired.Utils
public static class SerializationTools // TypeDefIndex: 2899
{
	// Methods

	// RVA: -1 Offset: -1
	public static string SerializeObjectToXmlString<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x799420 Offset: 0x797A20 VA: 0x180799420
	|-SerializationTools.SerializeObjectToXmlString<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17BC610 Offset: 0x17BAC10 VA: 0x1817BC610
	public static void WriteXmlElement(XmlWriter writer, string name, object value) { }

	// RVA: -1 Offset: -1
	public static void WriteXmlElement<T>(XmlWriter writer, string name, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x799F40 Offset: 0x798540 VA: 0x180799F40
	|-SerializationTools.WriteXmlElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17BC7B0 Offset: 0x17BADB0 VA: 0x1817BC7B0
	private static void gMScYWHwmtnFyFoIOCKVjOPsWQxpA(XmlWriter , object ) { }

	// RVA: 0x17BC3D0 Offset: 0x17BA9D0 VA: 0x1817BC3D0
	public static string ReadXmlElement(XmlReader reader, string name) { }

	// RVA: -1 Offset: -1
	public static T ReadXmlElement<T>(XmlReader reader, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x798D00 Offset: 0x797300 VA: 0x180798D00
	|-SerializationTools.ReadXmlElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17BC480 Offset: 0x17BAA80 VA: 0x1817BC480
	public static bool TryReadXmlElement(XmlReader reader, string name, out string outValue) { }

	// RVA: -1 Offset: -1
	public static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x799680 Offset: 0x797C80 VA: 0x180799680
	|-SerializationTools.TryReadXmlElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x799E30 Offset: 0x798430 VA: 0x180799E30
	|-SerializationTools.TryReadXmlElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17BC590 Offset: 0x17BAB90 VA: 0x1817BC590
	public static bool TryReadXmlStartElement(XmlReader reader, string name, out bool isEmpty) { }

	// RVA: 0x17BC560 Offset: 0x17BAB60 VA: 0x1817BC560
	public static bool TryReadXmlEndElement(XmlReader reader) { }

	// RVA: 0x17BC310 Offset: 0x17BA910 VA: 0x1817BC310
	public static string CleanInvalidXmlChars(string text) { }
}

// Namespace: Rewired.Utils
public static class StringTools // TypeDefIndex: 2900
{
	// Fields
	private static string eaIClwMTtOjgVMAtkXQhOgOUkCBu; // 0x0

	// Methods

	// RVA: 0x17C0B30 Offset: 0x17BF130 VA: 0x1817C0B30
	public static string ToString(int[] inArray) { }

	// RVA: 0x17C01B0 Offset: 0x17BE7B0 VA: 0x1817C01B0
	public static string ToString(float[] inArray) { }

	// RVA: 0x17C07B0 Offset: 0x17BEDB0 VA: 0x1817C07B0
	public static string ToString(string[] inArray) { }

	// RVA: 0x17C0990 Offset: 0x17BEF90 VA: 0x1817C0990
	public static string ToString(bool[] inArray) { }

	// RVA: 0x17C0A70 Offset: 0x17BF070 VA: 0x1817C0A70
	public static string ToString(byte[] inArray) { }

	// RVA: 0x17C0270 Offset: 0x17BE870 VA: 0x1817C0270
	public static string ToString(byte[] inArray, string stringOptions, int maxItemsPerLine = 0) { }

	// RVA: 0x17C0850 Offset: 0x17BEE50 VA: 0x1817C0850
	public static string ToString(Vector3[] inArray) { }

	// RVA: 0x17C0390 Offset: 0x17BE990 VA: 0x1817C0390
	public static string ToString(List<object> list) { }

	// RVA: 0x17C0930 Offset: 0x17BEF30 VA: 0x1817C0930
	public static string ToString(Vector2 v) { }

	// RVA: 0x17C0480 Offset: 0x17BEA80 VA: 0x1817C0480
	public static string ToString(Vector3 v) { }

	// RVA: -1 Offset: -1
	public static string ToString<T>(T[] inArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B86E0 Offset: 0x7B6CE0 VA: 0x1807B86E0
	|-StringTools.ToString<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string ToString<T>(List<T> inList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B84B0 Offset: 0x7B6AB0 VA: 0x1807B84B0
	|-StringTools.ToString<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17BF7B0 Offset: 0x17BDDB0 VA: 0x1817BF7B0
	public static string[] Split(string str, string delimiter) { }

	// RVA: 0x17BF680 Offset: 0x17BDC80 VA: 0x1817BF680
	public static string[] SplitAndTrim(string str, string delimiter) { }

	// RVA: 0x17BF150 Offset: 0x17BD750 VA: 0x1817BF150
	public static string DecodeNewlines(string s) { }

	// RVA: 0x17BF1B0 Offset: 0x17BD7B0 VA: 0x1817BF1B0
	public static string EncodeNewlines(string s) { }

	// RVA: 0x17BE670 Offset: 0x17BCC70 VA: 0x1817BE670
	public static string ArrayToText(string[] sA) { }

	// RVA: 0x17BFCD0 Offset: 0x17BE2D0 VA: 0x1817BFCD0
	public static string[] TextToArray(string s) { }

	// RVA: 0x17BFAB0 Offset: 0x17BE0B0 VA: 0x1817BFAB0
	public static string StringToString(string s) { }

	// RVA: 0x17BF9C0 Offset: 0x17BDFC0 VA: 0x1817BF9C0
	public static int StringToInt(string s) { }

	// RVA: 0x17BF940 Offset: 0x17BDF40 VA: 0x1817BF940
	public static float StringToFloat(string s) { }

	// RVA: 0x17BF860 Offset: 0x17BDE60 VA: 0x1817BF860
	public static bool StringToBoolean(string s) { }

	// RVA: 0x17BF9F0 Offset: 0x17BDFF0 VA: 0x1817BF9F0
	public static KeyCode StringToKeyCode(string s) { }

	// RVA: 0x17BF8B0 Offset: 0x17BDEB0 VA: 0x1817BF8B0
	public static Enum StringToEnum(string str, Type type) { }

	// RVA: 0x17C0090 Offset: 0x17BE690 VA: 0x1817C0090
	public static string ToStringWithCount(string s) { }

	// RVA: 0x17BF8A0 Offset: 0x17BDEA0 VA: 0x1817BF8A0
	public static char[] StringToCharArray(string s) { }

	// RVA: 0x17BEFC0 Offset: 0x17BD5C0 VA: 0x1817BEFC0
	public static string CharArrayToString(char[] c) { }

	// RVA: 0x17BEA60 Offset: 0x17BD060 VA: 0x1817BEA60
	public static string CSVEncode(string s) { }

	// RVA: 0x17BE8A0 Offset: 0x17BCEA0 VA: 0x1817BE8A0
	public static string CSVDecode(string s) { }

	// RVA: 0x17BEB40 Offset: 0x17BD140 VA: 0x1817BEB40
	public static string[] CSVToArray(string s) { }

	// RVA: -1 Offset: -1
	public static bool TryParseEnum<TEnum>(string value, out TEnum enumeration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B8860 Offset: 0x7B6E60 VA: 0x1807B8860
	|-StringTools.TryParseEnum<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17BFFE0 Offset: 0x17BE5E0 VA: 0x1817BFFE0
	public static string TimeToString(int seconds) { }

	// RVA: 0x17BFD30 Offset: 0x17BE330 VA: 0x1817BFD30
	public static string TimeToString(float seconds) { }

	// RVA: 0x17C1760 Offset: 0x17BFD60 VA: 0x1817C1760
	private static void .cctor() { }

	// RVA: 0x17BEFE0 Offset: 0x17BD5E0 VA: 0x1817BEFE0
	public static string CleanUpFileName(string name) { }

	// RVA: 0x17BFC70 Offset: 0x17BE270 VA: 0x1817BFC70
	public static string StripTrailingNumbers(string name) { }

	// RVA: 0x17BFAF0 Offset: 0x17BE0F0 VA: 0x1817BFAF0
	public static string StripTrailingNumbers(string name, out int number) { }

	// RVA: 0x17C1150 Offset: 0x17BF750 VA: 0x1817C1150
	public static string VerifyName(string name, int indexInNameList, string[] names, bool cleanUpIllegalFileChars) { }

	// RVA: 0x17C0F40 Offset: 0x17BF540 VA: 0x1817C0F40
	public static string VerifyName(string name, int indexInNameList, string[] names, bool cleanUpIllegalFileChars, bool allowBlank) { }

	// RVA: 0x17BF3D0 Offset: 0x17BD9D0 VA: 0x1817BF3D0
	public static string IterateName(string name, int indexInNameList = -1, string[] names) { }

	// RVA: 0x17C05A0 Offset: 0x17BEBA0 VA: 0x1817C05A0
	public static string ToString(Rect rect) { }

	// RVA: 0x17C0030 Offset: 0x17BE630 VA: 0x1817C0030
	public static Guid ToGuid(string guid) { }

	// RVA: 0x17BF210 Offset: 0x17BD810 VA: 0x1817BF210
	public static byte[] GetBytes(string str) { }

	// RVA: 0x17BF340 Offset: 0x17BD940 VA: 0x1817BF340
	public static string GetString(byte[] bytes) { }

	// RVA: 0x17BE720 Offset: 0x17BCD20 VA: 0x1817BE720
	public static string ByteShiftEncode(string source, short shift) { }

	// RVA: 0x17BF2A0 Offset: 0x17BD8A0 VA: 0x1817BF2A0
	public static string GetNullTerminatedUnicodeString(byte[] bytes) { }

	// RVA: 0x17BF5D0 Offset: 0x17BDBD0 VA: 0x1817BF5D0
	public static string SanitizeDeviceString(string text) { }

	// RVA: 0x17BF540 Offset: 0x17BDB40 VA: 0x1817BF540
	public static string ReplaceChar(string string, int index, char replacement) { }

	// RVA: 0x17BE440 Offset: 0x17BCA40 VA: 0x1817BE440
	public static string AddSpacesToSentence(string text, bool preserveAcronyms) { }

	// RVA: 0x17C1310 Offset: 0x17BF910 VA: 0x1817C1310
	public static string WriteVar(string name, object value) { }

	// RVA: 0x17C14D0 Offset: 0x17BFAD0 VA: 0x1817C14D0
	public static string WriteVar(string name, object value, char delimiter) { }

	// RVA: 0x17C11E0 Offset: 0x17BF7E0 VA: 0x1817C11E0
	public static void WriteVar(StringBuilder sb, string name, object value) { }

	// RVA: 0x17C1660 Offset: 0x17BFC60 VA: 0x1817C1660
	public static void WriteVar(StringBuilder sb, string name, object value, char delimiter) { }

	// RVA: 0x17C0BF0 Offset: 0x17BF1F0 VA: 0x1817C0BF0
	public static string Trim(string str) { }

	// RVA: 0x17C0C30 Offset: 0x17BF230 VA: 0x1817C0C30
	public static string VariableNameToDisplayName(string fieldName) { }

	// RVA: 0x17BF0D0 Offset: 0x17BD6D0 VA: 0x1817BF0D0
	public static int CountChars(string text, char character) { }

	// RVA: 0x17BE130 Offset: 0x17BC730 VA: 0x1817BE130
	public static string AddSpacesToCamelCase(string text) { }

	// RVA: 0x17BE180 Offset: 0x17BC780 VA: 0x1817BE180
	public static string AddSpacesToCamelCase(string text, bool preserveAcronyms) { }

	// RVA: 0x17BEE30 Offset: 0x17BD430 VA: 0x1817BEE30
	public static string CamelCaseToSnakeCase(string text) { }
}

// Namespace: Rewired.Utils
public static class UnityTools // TypeDefIndex: 2906
{
	// Fields
	private const UnityTools.UnityVersion pQwfELRcjEgwRwilNVDYBPiNwTpR = 26;
	private static UnityTools.UnityVersionClass EhZIfezsNCoJvuKFUbDPHNnPcSEI; // 0x0
	private static UnityTools.UnityVersion lJWnywzpcrUMGVXncLNDYSMckHRd; // 0x8
	private static string hOUiLNwsEVAIEGndyVkcrLjEyfdh; // 0x10
	private static Platform NQwWUQONHVBzuKOrtimYXaVnceNs; // 0x18
	private static EditorPlatform JbBSgFCuJCQMEAozhYGzljxbdLJb; // 0x1C
	private static bool ryQWrberCTgqxeQPXZmoviqjOrPk; // 0x20
	private static bool UDfopEAFLItWlHoCQijNDQlgIpyM; // 0x21
	private static bool guOfGCkAbmwEiBDOivazEMUulzTrA; // 0x22
	private static WebplayerPlatform kgAfAMpvxBDzuSHLnaOlgBjpSAEl; // 0x24
	private static bool JifOihCdpMvjhZOJOITFTikmJkYs; // 0x28
	private static bool OyJvgXYkBaNKQmhuSQgGNLVcrJjN; // 0x29
	private static bool ywxvUnqOuMbUXkTsaZQhvWswScMi; // 0x2A
	private static bool RqJcJHFawNygFBLFlrRjuFgiruDAA; // 0x2B
	private static bool uRYeTzfxbVBpcdTJNLYinvQRvDJk; // 0x2C
	private static bool ldPQTUenbQilQyDXibokDXiUcZXKA; // 0x2D
	private static string oWHwOqPusOhHTJfhphaTakmzhvWp; // 0x30
	private static ScriptingBackend CFrEDSYMzoxjyggySJuyxlPlAcXS; // 0x38
	private static ScriptingAPILevel DbUxfdphUfamSFvkstNhOeAOdsWP; // 0x3C
	private static bool xGYLwRoGwNMlJDFZuDtscYheZPnIA; // 0x40
	private static IExternalTools uTEMKwGjYgieuOMjrSkhjVSDuwpE; // 0x48
	[CompilerGenerated]
	private static IAndroidFallbackPlatformHelper LmHbaTQjjZJNJqwIppalhawheTLHA; // 0x50
	private static bool IyefxeBODCdkhKOzPDXGmKfxCdLvA; // 0x58

	// Properties
	[CustomObfuscation(rename = False)]
	internal static UnityTools.UnityVersionClass unityVersionObj { get; }
	public static UnityTools.UnityVersion unityVersion { get; }
	public static string unityVersionString { get; }
	public static Platform platform { get; }
	[CustomObfuscation(rename = False)]
	internal static Platform effectivePlatform { get; }
	public static EditorPlatform editorPlatform { get; }
	public static bool isEditor { get; }
	public static bool isPlaying { get; }
	public static bool isDebugBuild { get; }
	public static WebplayerPlatform webplayerPlatform { get; }
	public static bool logToDebugLog { get; }
	[CustomObfuscation(rename = False)]
	internal static bool editorPlatformMatchesBuildPlatform { get; }
	public static bool isSupportedVersion3 { get; }
	public static bool isSupportedVersion4 { get; }
	public static bool supports2DColliders { get; }
	public static bool supportsSortingLayers { get; }
	public static bool supportsUnityUI { get; }
	public static bool supportsTouchControls { get; }
	public static bool supportsPhysicalKeys { get; }
	public static bool isAndroidPlatform { get; }
	public static bool isIOSPlatform { get; }
	public static bool isStandalonePlatform { get; }
	public static bool windowsJoystickNamesReturnsEmptyStringsIfJoystickNull { get; }
	public static bool supportsUnityUIGraphicRaycastTarget { get; }
	public static bool supportsNestedPrefabs { get; }
	public static bool supportsWindowsAppStore { get; }
	public static bool supportsWindowsUWP { get; }
	public static bool supportsWindowsUWP_IL2CPP { get; }
	public static bool supportsXboxOne { get; }
	public static bool windowsStandalone_supportsRawInputForwarding { get; }
	[CustomObfuscation(rename = False)]
	internal static ScriptingBackend scriptingBackend { get; }
	[CustomObfuscation(rename = False)]
	internal static ScriptingAPILevel scriptingAPILevel { get; }
	public static IExternalTools externalTools { get; }
	internal static IAndroidFallbackPlatformHelper xQsaKpOBEHsSabSmNncFrECApPQJ { get; set; }
	[CustomObfuscation(rename = False)]
	internal static bool isInitialized { get; }
	private static bool HjdkDxSbyAJtPSSuRuhWxdGpkQqg { get; }

	// Methods

	// RVA: 0x17FF1D0 Offset: 0x17FD7D0 VA: 0x1817FF1D0
	internal static UnityTools.UnityVersionClass get_unityVersionObj() { }

	// RVA: 0x17FF340 Offset: 0x17FD940 VA: 0x1817FF340
	public static UnityTools.UnityVersion get_unityVersion() { }

	// RVA: 0x17FF280 Offset: 0x17FD880 VA: 0x1817FF280
	public static string get_unityVersionString() { }

	// RVA: 0x17FE8D0 Offset: 0x17FCED0 VA: 0x1817FE8D0
	public static Platform get_platform() { }

	// RVA: 0x17FDF00 Offset: 0x17FC500 VA: 0x1817FDF00
	internal static Platform get_effectivePlatform() { }

	// RVA: 0x17FDE50 Offset: 0x17FC450 VA: 0x1817FDE50
	public static EditorPlatform get_editorPlatform() { }

	// RVA: 0x17FE2A0 Offset: 0x17FC8A0 VA: 0x1817FE2A0
	public static bool get_isEditor() { }

	// RVA: 0x17FE470 Offset: 0x17FCA70 VA: 0x1817FE470
	public static bool get_isPlaying() { }

	// RVA: 0x17FE1F0 Offset: 0x17FC7F0 VA: 0x1817FE1F0
	public static bool get_isDebugBuild() { }

	// RVA: 0x17FF3F0 Offset: 0x17FD9F0 VA: 0x1817FF3F0
	public static WebplayerPlatform get_webplayerPlatform() { }

	// RVA: 0x17FE720 Offset: 0x17FCD20 VA: 0x1817FE720
	public static bool get_logToDebugLog() { }

	// RVA: 0x17FDCF0 Offset: 0x17FC2F0 VA: 0x1817FDCF0
	internal static bool get_editorPlatformMatchesBuildPlatform() { }

	// RVA: 0x17FE5C0 Offset: 0x17FCBC0 VA: 0x1817FE5C0
	public static bool get_isSupportedVersion3() { }

	// RVA: 0x17FE670 Offset: 0x17FCC70 VA: 0x1817FE670
	public static bool get_isSupportedVersion4() { }

	// RVA: 0x17FEA20 Offset: 0x17FD020 VA: 0x1817FEA20
	public static bool get_supports2DColliders() { }

	// RVA: 0x17FEC30 Offset: 0x17FD230 VA: 0x1817FEC30
	public static bool get_supportsSortingLayers() { }

	// RVA: 0x17FEE40 Offset: 0x17FD440 VA: 0x1817FEE40
	public static bool get_supportsUnityUI() { }

	// RVA: 0x17FECE0 Offset: 0x17FD2E0 VA: 0x1817FECE0
	public static bool get_supportsTouchControls() { }

	// RVA: 0x17FEB80 Offset: 0x17FD180 VA: 0x1817FEB80
	public static bool get_supportsPhysicalKeys() { }

	// RVA: 0x17FE0D0 Offset: 0x17FC6D0 VA: 0x1817FE0D0
	public static bool get_isAndroidPlatform() { }

	// RVA: 0x17FE350 Offset: 0x17FC950 VA: 0x1817FE350
	public static bool get_isIOSPlatform() { }

	// RVA: 0x17FE4C0 Offset: 0x17FCAC0 VA: 0x1817FE4C0
	public static bool get_isStandalonePlatform() { }

	// RVA: 0x17FF4A0 Offset: 0x17FDAA0 VA: 0x1817FF4A0
	public static bool get_windowsJoystickNamesReturnsEmptyStringsIfJoystickNull() { }

	// RVA: 0x17FED90 Offset: 0x17FD390 VA: 0x1817FED90
	public static bool get_supportsUnityUIGraphicRaycastTarget() { }

	// RVA: 0x17FEAD0 Offset: 0x17FD0D0 VA: 0x1817FEAD0
	public static bool get_supportsNestedPrefabs() { }

	// RVA: 0x17FEEF0 Offset: 0x17FD4F0 VA: 0x1817FEEF0
	public static bool get_supportsWindowsAppStore() { }

	// RVA: 0x17FF070 Offset: 0x17FD670 VA: 0x1817FF070
	public static bool get_supportsWindowsUWP() { }

	// RVA: 0x17FEFC0 Offset: 0x17FD5C0 VA: 0x1817FEFC0
	public static bool get_supportsWindowsUWP_IL2CPP() { }

	// RVA: 0x17FF120 Offset: 0x17FD720 VA: 0x1817FF120
	public static bool get_supportsXboxOne() { }

	// RVA: 0x17FF550 Offset: 0x17FDB50 VA: 0x1817FF550
	public static bool get_windowsStandalone_supportsRawInputForwarding() { }

	// RVA: 0x17FE9D0 Offset: 0x17FCFD0 VA: 0x1817FE9D0
	internal static ScriptingBackend get_scriptingBackend() { }

	// RVA: 0x17FE980 Offset: 0x17FCF80 VA: 0x1817FE980
	internal static ScriptingAPILevel get_scriptingAPILevel() { }

	// RVA: 0x17FE020 Offset: 0x17FC620 VA: 0x1817FE020
	public static IExternalTools get_externalTools() { }

	[CompilerGenerated]
	// RVA: 0x17FDB80 Offset: 0x17FC180 VA: 0x1817FDB80
	internal static IAndroidFallbackPlatformHelper aVsnNmBCmymjUHoicpicsLdehQjBA() { }

	[CompilerGenerated]
	// RVA: 0x18007B0 Offset: 0x17FEDB0 VA: 0x1818007B0
	internal static void ywLNDWrwSBSGWXrxwperBcBZdqcP(IAndroidFallbackPlatformHelper ) { }

	// RVA: 0x17FE420 Offset: 0x17FCA20 VA: 0x1817FE420
	internal static bool get_isInitialized() { }

	// RVA: 0x17FDCB0 Offset: 0x17FC2B0 VA: 0x1817FDCB0
	private static bool eUkknwbPXrHLUcsEBKnEoYEcBXwp() { }

	// RVA: 0x17FC640 Offset: 0x17FAC40 VA: 0x1817FC640
	private static bool RcFiAxaOkZBAYgSsGNPAxLxcrMfS() { }

	// RVA: 0x18002D0 Offset: 0x17FE8D0 VA: 0x1818002D0
	internal static void psKYLBSdWUVHpBtIgrlByAXACKyv(UnityTools.EeMzBLeLNTmTALqdvIAKIfdYhceUA ) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static WebplayerPlatform DetermineWebplayerPlatformType(Platform platform, EditorPlatform editorPlatform) { }

	// RVA: 0x17FC070 Offset: 0x17FA670 VA: 0x1817FC070
	public static bool IsUnityVersionInRange(string minVersionStr, string maxVersionStr) { }

	// RVA: 0x17FC540 Offset: 0x17FAB40 VA: 0x1817FC540
	private static bool MBEDGORwnqIsBaPtZYEyAPHPXqiB(string , out int ) { }

	// RVA: 0x17FBA60 Offset: 0x17FA060 VA: 0x1817FBA60
	private static void HeCjkPHhOaKHvBkNQVBjYVIMJJGf() { }

	// RVA: 0x17FF600 Offset: 0x17FDC00 VA: 0x1817FF600
	private static UnityTools.UnityVersion jgBfqrhPviuTqehVeRRCnaDgNleO(string ) { }

	// RVA: 0x17FDA60 Offset: 0x17FC060 VA: 0x1817FDA60
	private static UnityTools.UnityVersion YOZreNSLvXZSVUBIvBjdZQefawGfA(int ) { }

	// RVA: 0x17FDBD0 Offset: 0x17FC1D0 VA: 0x1817FDBD0
	private static UnityTools.UnityVersion dBUaShkvcXqSkZMyvJdxzkYsLYNwA(int ) { }

	// RVA: 0x17FC8F0 Offset: 0x17FAEF0 VA: 0x1817FC8F0
	private static void SSlDhIcqlDuRUETPjqlfOrAkDuvL() { }

	// RVA: 0x1800640 Offset: 0x17FEC40 VA: 0x181800640
	internal static Type ybmKmVfxiArOtNjxsquBMEfThzcbA(JYVfxadmCrgsMlznxhveVeOoxcWs ) { }

	// RVA: 0x1800570 Offset: 0x17FEB70 VA: 0x181800570
	private static Type tfylgdYjPNiiPebjfGvldJlZnpXYA(JYVfxadmCrgsMlznxhveVeOoxcWs ) { }

	// RVA: 0x17FB5D0 Offset: 0x17F9BD0 VA: 0x1817FB5D0
	public static List<string> GetCurrentPlatformResourecesDLLPaths() { }

	// RVA: 0x17F81E0 Offset: 0x17F67E0 VA: 0x1817F81E0
	public static Transform FindTransformInChildren(Transform transform, string name) { }

	// RVA: 0x17F8330 Offset: 0x17F6930 VA: 0x1817F8330
	public static Transform FindTransformInChildren(GameObject gameObject, string name) { }

	// RVA: 0x17F8010 Offset: 0x17F6610 VA: 0x1817F8010
	public static GameObject FindGameObjectInChildren(GameObject gameObject, string name) { }

	// RVA: 0x17F8100 Offset: 0x17F6700 VA: 0x1817F8100
	public static GameObject FindGameObjectInChildren(Transform transform, string name) { }

	// RVA: -1 Offset: -1
	public static T GetComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809DE0 Offset: 0x8083E0 VA: 0x180809DE0
	|-UnityTools.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809DE0 Offset: 0x8083E0 VA: 0x180809DE0
	|-UnityTools.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809CC0 Offset: 0x8082C0 VA: 0x180809CC0
	|-UnityTools.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponent<T>(Transform transform, bool includeDisabledComponents) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809BF0 Offset: 0x8081F0 VA: 0x180809BF0
	|-UnityTools.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponent<T>(Component component, bool includeDisabledComponents) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809BF0 Offset: 0x8081F0 VA: 0x180809BF0
	|-UnityTools.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponent<T>(GameObject gameObject, bool includeDisabledComponents) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809EA0 Offset: 0x8084A0 VA: 0x180809EA0
	|-UnityTools.GetComponent<object>
	*/

	// RVA: 0x17F8F20 Offset: 0x17F7520 VA: 0x1817F8F20
	public static Component GetComponent(Transform transform, Type type, bool includeDisabledComponents) { }

	// RVA: 0x17F8AA0 Offset: 0x17F70A0 VA: 0x1817F8AA0
	public static Component GetComponent(Component component, Type type, bool includeDisabledComponents) { }

	// RVA: 0x17F8B70 Offset: 0x17F7170 VA: 0x1817F8B70
	public static Component GetComponent(GameObject gameObject, Type type, bool includeDisabledComponents) { }

	// RVA: 0x17F8DC0 Offset: 0x17F73C0 VA: 0x1817F8DC0
	public static Component GetComponent(Transform transform, Type type) { }

	// RVA: 0x17F8E70 Offset: 0x17F7470 VA: 0x1817F8E70
	public static Component GetComponent(Component component, Type type) { }

	// RVA: 0x17F8FF0 Offset: 0x17F75F0 VA: 0x1817F8FF0
	public static Component GetComponent(GameObject gameObject, Type type) { }

	// RVA: -1 Offset: -1
	public static T GetComponentInChildren<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x808C30 Offset: 0x807230 VA: 0x180808C30
	|-UnityTools.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInChildren<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8089D0 Offset: 0x806FD0 VA: 0x1808089D0
	|-UnityTools.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInChildren<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x808EC0 Offset: 0x8074C0 VA: 0x180808EC0
	|-UnityTools.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInChildren<T>(GameObject gameObject, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x808B60 Offset: 0x807160 VA: 0x180808B60
	|-UnityTools.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInChildren<T>(Component component, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x808A90 Offset: 0x807090 VA: 0x180808A90
	|-UnityTools.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInChildren<T>(Transform transform, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x808CF0 Offset: 0x8072F0 VA: 0x180808CF0
	|-UnityTools.GetComponentInChildren<object>
	*/

	// RVA: 0x17F8560 Offset: 0x17F6B60 VA: 0x1817F8560
	public static Component GetComponentInChildren(GameObject gameObject, Type type) { }

	// RVA: 0x17F84B0 Offset: 0x17F6AB0 VA: 0x1817F84B0
	public static Component GetComponentInChildren(Component component, Type type) { }

	// RVA: 0x17F86E0 Offset: 0x17F6CE0 VA: 0x1817F86E0
	public static Component GetComponentInChildren(Transform transform, Type type) { }

	// RVA: 0x17F83E0 Offset: 0x17F69E0 VA: 0x1817F83E0
	public static Component GetComponentInChildren(GameObject gameObject, Type type, UnityTools.GetComponentFlags options) { }

	// RVA: 0x17F8610 Offset: 0x17F6C10 VA: 0x1817F8610
	public static Component GetComponentInChildren(Component component, Type type, UnityTools.GetComponentFlags options) { }

	// RVA: 0x17F88C0 Offset: 0x17F6EC0 VA: 0x1817F88C0
	public static Component GetComponentInChildren(Transform transform, Type type, UnityTools.GetComponentFlags options) { }

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrChildren<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8093A0 Offset: 0x8079A0 VA: 0x1808093A0
	|-UnityTools.GetComponentInSelfOrChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrChildren<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8093A0 Offset: 0x8079A0 VA: 0x1808093A0
	|-UnityTools.GetComponentInSelfOrChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrChildren<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8096D0 Offset: 0x807CD0 VA: 0x1808096D0
	|-UnityTools.GetComponentInSelfOrChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrChildren<T>(Transform transform, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809460 Offset: 0x807A60 VA: 0x180809460
	|-UnityTools.GetComponentInSelfOrChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrChildren<T>(Component component, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809460 Offset: 0x807A60 VA: 0x180809460
	|-UnityTools.GetComponentInSelfOrChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrChildren<T>(GameObject gameObject, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809530 Offset: 0x807B30 VA: 0x180809530
	|-UnityTools.GetComponentInSelfOrChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInParents<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8090B0 Offset: 0x8076B0 VA: 0x1808090B0
	|-UnityTools.GetComponentInParents<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInParents<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8092E0 Offset: 0x8078E0 VA: 0x1808092E0
	|-UnityTools.GetComponentInParents<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInParents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809170 Offset: 0x807770 VA: 0x180809170
	|-UnityTools.GetComponentInParents<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrParents<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809870 Offset: 0x807E70 VA: 0x180809870
	|-UnityTools.GetComponentInSelfOrParents<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrParents<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809B30 Offset: 0x808130 VA: 0x180809B30
	|-UnityTools.GetComponentInSelfOrParents<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetComponentInSelfOrParents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x809930 Offset: 0x807F30 VA: 0x180809930
	|-UnityTools.GetComponentInSelfOrParents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D270 Offset: 0x80B870 VA: 0x18080D270
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponents<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D270 Offset: 0x80B870 VA: 0x18080D270
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponents<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D810 Offset: 0x80BE10 VA: 0x18080D810
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponents<T>(Transform transform, bool includeDisabledComponents) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D160 Offset: 0x80B760 VA: 0x18080D160
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponents<T>(Component component, bool includeDisabledComponents) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D160 Offset: 0x80B760 VA: 0x18080D160
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponents<T>(GameObject gameObject, bool includeDisabledComponents) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80C980 Offset: 0x80AF80 VA: 0x18080C980
	|-UnityTools.GetComponents<object>
	*/

	// RVA: 0x17FAC90 Offset: 0x17F9290 VA: 0x1817FAC90
	public static List<Component> GetComponents(Transform transform, Type type) { }

	// RVA: 0x17FB3C0 Offset: 0x17F99C0 VA: 0x1817FB3C0
	public static List<Component> GetComponents(Component component, Type type) { }

	// RVA: 0x17FB160 Offset: 0x17F9760 VA: 0x1817FB160
	public static List<Component> GetComponents(GameObject gameObject, Type type) { }

	// RVA: 0x17FAA90 Offset: 0x17F9090 VA: 0x1817FAA90
	public static List<Component> GetComponents(Transform transform, Type type, bool includeDisabledComponents) { }

	// RVA: 0x17FAB90 Offset: 0x17F9190 VA: 0x1817FAB90
	public static List<Component> GetComponents(Component component, Type type, bool includeDisabledComponents) { }

	// RVA: 0x17FB250 Offset: 0x17F9850 VA: 0x1817FB250
	public static List<Component> GetComponents(GameObject gameObject, Type type, bool includeDisabledComponents) { }

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInChildren<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80AC30 Offset: 0x809230 VA: 0x18080AC30
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInChildren<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80AEE0 Offset: 0x8094E0 VA: 0x18080AEE0
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInChildren<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A2D0 Offset: 0x8088D0 VA: 0x18080A2D0
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInChildren<T>(Transform transform, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A6E0 Offset: 0x808CE0 VA: 0x18080A6E0
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInChildren<T>(Component component, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A5E0 Offset: 0x808BE0 VA: 0x18080A5E0
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInChildren<T>(GameObject gameObject, UnityTools.GetComponentFlags options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A860 Offset: 0x808E60 VA: 0x18080A860
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: 0x17F96A0 Offset: 0x17F7CA0 VA: 0x1817F96A0
	public static List<Component> GetComponentsInChildren(Transform transform) { }

	// RVA: 0x17F95C0 Offset: 0x17F7BC0 VA: 0x1817F95C0
	public static List<Component> GetComponentsInChildren(Component component) { }

	// RVA: 0x17F9300 Offset: 0x17F7900 VA: 0x1817F9300
	public static List<Component> GetComponentsInChildren(GameObject gameObject) { }

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInSelfAndChildren<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80BD70 Offset: 0x80A370 VA: 0x18080BD70
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInSelfAndChildren<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80BD70 Offset: 0x80A370 VA: 0x18080BD70
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInSelfAndChildren<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80B9E0 Offset: 0x809FE0 VA: 0x18080B9E0
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInParents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80B680 Offset: 0x809C80 VA: 0x18080B680
	|-UnityTools.GetComponentsInParents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInParents<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80B0E0 Offset: 0x8096E0 VA: 0x18080B0E0
	|-UnityTools.GetComponentsInParents<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetComponentsInParents<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80B1D0 Offset: 0x8097D0 VA: 0x18080B1D0
	|-UnityTools.GetComponentsInParents<object>
	*/

	// RVA: 0x17F9A00 Offset: 0x17F8000 VA: 0x1817F9A00
	public static List<Component> GetComponentsInParents(Transform transform) { }

	// RVA: 0x17F9C70 Offset: 0x17F8270 VA: 0x1817F9C70
	public static List<Component> GetComponentsInParents(Component component) { }

	// RVA: 0x17F9920 Offset: 0x17F7F20 VA: 0x1817F9920
	public static List<Component> GetComponentsInParents(GameObject gameObject) { }

	// RVA: -1 Offset: -1
	public static int GetComponents<T>(Transform transform, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80DA90 Offset: 0x80C090 VA: 0x18080DA90
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponents<T>(Component component, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80DBA0 Offset: 0x80C1A0 VA: 0x18080DBA0
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponents<T>(GameObject gameObject, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D360 Offset: 0x80B960 VA: 0x18080D360
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponents<T>(Transform transform, bool includeDisabledComponents, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D030 Offset: 0x80B630 VA: 0x18080D030
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponents<T>(Component component, bool includeDisabledComponents, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80D6E0 Offset: 0x80BCE0 VA: 0x18080D6E0
	|-UnityTools.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponents<T>(GameObject gameObject, bool includeDisabledComponents, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80CC50 Offset: 0x80B250 VA: 0x18080CC50
	|-UnityTools.GetComponents<object>
	*/

	// RVA: 0x17FA980 Offset: 0x17F8F80 VA: 0x1817FA980
	public static int GetComponents(Transform transform, List<Component> results, bool append) { }

	// RVA: 0x17FA870 Offset: 0x17F8E70 VA: 0x1817FA870
	public static int GetComponents(Component component, List<Component> results, bool append) { }

	// RVA: 0x17FAD80 Offset: 0x17F9380 VA: 0x1817FAD80
	public static int GetComponents(GameObject gameObject, List<Component> results, bool append) { }

	// RVA: 0x17FB040 Offset: 0x17F9640 VA: 0x1817FB040
	public static int GetComponents(Transform transform, Type type, List<Component> results, bool append) { }

	// RVA: 0x17FB4B0 Offset: 0x17F9AB0 VA: 0x1817FB4B0
	public static int GetComponents(Component component, Type type, List<Component> results, bool append) { }

	// RVA: 0x17FA5C0 Offset: 0x17F8BC0 VA: 0x1817FA5C0
	public static int GetComponents(GameObject gameObject, Type type, List<Component> results, bool append) { }

	// RVA: 0x17FA160 Offset: 0x17F8760 VA: 0x1817FA160
	public static int GetComponentsInSelfAndChildren(Transform transform, List<Component> results, bool append) { }

	// RVA: 0x17FA050 Offset: 0x17F8650 VA: 0x1817FA050
	public static int GetComponentsInSelfAndChildren(Component component, List<Component> results, bool append) { }

	// RVA: 0x17FA4B0 Offset: 0x17F8AB0 VA: 0x1817FA4B0
	public static int GetComponentsInSelfAndChildren(GameObject gameObject, List<Component> results, bool append) { }

	// RVA: -1 Offset: -1
	public static int GetComponentsInSelfAndChildren<T>(Transform transform, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80BE60 Offset: 0x80A460 VA: 0x18080BE60
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInSelfAndChildren<T>(Component component, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80B8D0 Offset: 0x809ED0 VA: 0x18080B8D0
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInSelfAndChildren<T>(GameObject gameObject, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80BC60 Offset: 0x80A260 VA: 0x18080BC60
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInSelfAndChildren<T>(Transform transform, UnityTools.GetComponentFlags options, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80C4C0 Offset: 0x80AAC0 VA: 0x18080C4C0
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInSelfAndChildren<T>(Component component, UnityTools.GetComponentFlags options, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80C260 Offset: 0x80A860 VA: 0x18080C260
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInSelfAndChildren<T>(GameObject gameObject, UnityTools.GetComponentFlags options, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80C390 Offset: 0x80A990 VA: 0x18080C390
	|-UnityTools.GetComponentsInSelfAndChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInChildren<T>(Transform transform, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A960 Offset: 0x808F60 VA: 0x18080A960
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInChildren<T>(Component component, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A3C0 Offset: 0x8089C0 VA: 0x18080A3C0
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInChildren<T>(GameObject gameObject, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A4D0 Offset: 0x808AD0 VA: 0x18080A4D0
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInChildren<T>(Transform transform, UnityTools.GetComponentFlags options, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80A110 Offset: 0x808710 VA: 0x18080A110
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInChildren<T>(Component component, UnityTools.GetComponentFlags options, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80AB00 Offset: 0x809100 VA: 0x18080AB00
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInChildren<T>(GameObject gameObject, UnityTools.GetComponentFlags options, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80ADB0 Offset: 0x8093B0 VA: 0x18080ADB0
	|-UnityTools.GetComponentsInChildren<object>
	*/

	// RVA: 0x17F93E0 Offset: 0x17F79E0 VA: 0x1817F93E0
	public static int GetComponentsInChildren(Transform transform, List<Component> results, bool append) { }

	// RVA: 0x17F91F0 Offset: 0x17F77F0 VA: 0x1817F91F0
	public static int GetComponentsInChildren(Component component, List<Component> results, bool append) { }

	// RVA: 0x17F9810 Offset: 0x17F7E10 VA: 0x1817F9810
	public static int GetComponentsInChildren(GameObject gameObject, List<Component> results, bool append) { }

	// RVA: -1 Offset: -1
	public static int GetComponentsInParents<T>(Transform transform, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80AFD0 Offset: 0x8095D0 VA: 0x18080AFD0
	|-UnityTools.GetComponentsInParents<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInParents<T>(Component component, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80B2C0 Offset: 0x8098C0 VA: 0x18080B2C0
	|-UnityTools.GetComponentsInParents<object>
	*/

	// RVA: -1 Offset: -1
	public static int GetComponentsInParents<T>(GameObject gameObject, List<T> results, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80B3D0 Offset: 0x8099D0 VA: 0x18080B3D0
	|-UnityTools.GetComponentsInParents<object>
	*/

	// RVA: 0x17F9B60 Offset: 0x17F8160 VA: 0x1817F9B60
	public static int GetComponentsInParents(Transform transform, List<Component> results, bool append) { }

	// RVA: 0x17F9F40 Offset: 0x17F8540 VA: 0x1817F9F40
	public static int GetComponentsInParents(Component component, List<Component> results, bool append) { }

	// RVA: 0x17F9D50 Offset: 0x17F8350 VA: 0x1817F9D50
	public static int GetComponentsInParents(GameObject gameObject, List<Component> results, bool append) { }

	// RVA: -1 Offset: -1
	public static void ForEachComponent<T>(Transform transform, Action<T> delegate, bool includeChildren) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8050C0 Offset: 0x8036C0 VA: 0x1808050C0
	|-UnityTools.ForEachComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponent<T>(Transform transform, Action<T> delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8053E0 Offset: 0x8039E0 VA: 0x1808053E0
	|-UnityTools.ForEachComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponent<T>(Component component, Action<T> delegate, bool includeChildren) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x805460 Offset: 0x803A60 VA: 0x180805460
	|-UnityTools.ForEachComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponent<T>(Component component, Action<T> delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8055A0 Offset: 0x803BA0 VA: 0x1808055A0
	|-UnityTools.ForEachComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponent<T>(GameObject gameObject, Action<T> delegate, bool includeChildren) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x805500 Offset: 0x803B00 VA: 0x180805500
	|-UnityTools.ForEachComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponent<T>(GameObject gameObject, Action<T> delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x805630 Offset: 0x803C30 VA: 0x180805630
	|-UnityTools.ForEachComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponentInChildren<T>(Transform transform, Action<T> delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x808750 Offset: 0x806D50 VA: 0x180808750
	|-UnityTools.ForEachComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponentInChildren<T>(Component component, Action<T> delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x808650 Offset: 0x806C50 VA: 0x180808650
	|-UnityTools.ForEachComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEachComponentInChildren<T>(GameObject gameObject, Action<T> delegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8088D0 Offset: 0x806ED0 VA: 0x1808088D0
	|-UnityTools.ForEachComponentInChildren<object>
	*/

	// RVA: 0x17FBEA0 Offset: 0x17FA4A0 VA: 0x1817FBEA0
	public static bool IsEnabled(Component component) { }

	// RVA: 0x17FBD70 Offset: 0x17FA370 VA: 0x1817FBD70
	public static bool IsActiveAndEnabled(Component component) { }

	// RVA: 0x17FBB90 Offset: 0x17FA190 VA: 0x1817FBB90
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x17FBCB0 Offset: 0x17FA2B0 VA: 0x1817FBCB0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Object original, Transform parent, bool instantiateInWorldSpace) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E330 Offset: 0x80C930 VA: 0x18080E330
	|-UnityTools.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80DCB0 Offset: 0x80C2B0 VA: 0x18080DCB0
	|-UnityTools.Instantiate<object>
	*/

	// RVA: 0x17FCFA0 Offset: 0x17FB5A0 VA: 0x1817FCFA0
	public static Vector3 TransformPoint(Transform from, Transform to, Vector3 point) { }

	// RVA: 0x17FD0E0 Offset: 0x17FB6E0 VA: 0x1817FD0E0
	public static Vector3 TransformPoint(Transform from, Transform to) { }

	// RVA: 0x17FCCC0 Offset: 0x17FB2C0 VA: 0x1817FCCC0
	public static Vector3 TransformDirection(Transform from, Transform to, Vector3 direction) { }

	// RVA: 0x17FCE00 Offset: 0x17FB400 VA: 0x1817FCE00
	public static Vector3 TransformDirection(Transform from, Transform to) { }

	// RVA: 0x17FD850 Offset: 0x17FBE50 VA: 0x1817FD850
	public static Vector3 TransformVector(Transform from, Transform to, Vector3 vector) { }

	// RVA: 0x17FD5E0 Offset: 0x17FBBE0 VA: 0x1817FD5E0
	public static Vector3 TransformVector(Transform from, Transform to) { }

	// RVA: 0x17FD280 Offset: 0x17FB880 VA: 0x1817FD280
	public static Rect TransformRect(Transform from, Transform to, Rect rect) { }

	// RVA: 0x17F7720 Offset: 0x17F5D20 VA: 0x1817F7720
	public static void DebugDrawCross(Vector3 position, float length, Color color) { }

	// RVA: 0x17F7B80 Offset: 0x17F6180 VA: 0x1817F7B80
	public static void DebugDrawCross(Vector3 position, float length, Color color, float duration) { }

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	internal static bool IsObjectInScene<T>(T object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E530 Offset: 0x80CB30 VA: 0x18080E530
	|-UnityTools.IsObjectInScene<object>
	*/

	// RVA: 0x17FB860 Offset: 0x17F9E60 VA: 0x1817FB860
	public static string GetUnityInputAxisName(int unityJoystickIndex, int axisIndex) { }

	// RVA: 0x17FB7D0 Offset: 0x17F9DD0 VA: 0x1817FB7D0
	public static string GetUnityInputAxisNameByJoystickId(int unityJoystickId, int axisIndex) { }

	// RVA: 0x17FB9A0 Offset: 0x17F9FA0 VA: 0x1817FB9A0
	public static string GetUnityInputButtonName(int unityJoystickIndex, int buttonIndex) { }

	// RVA: 0x17FB920 Offset: 0x17F9F20 VA: 0x1817FB920
	public static string GetUnityInputButtonNameByJoystickId(int unityJoystickId, int buttonIndex) { }

	// RVA: 0x17FC3B0 Offset: 0x17FA9B0 VA: 0x1817FC3B0
	public static bool IsValidUnityJoystickName(string name) { }

	// RVA: 0x17F7650 Offset: 0x17F5C50 VA: 0x1817F7650
	public static AnimationCurve Copy(AnimationCurve orig) { }

	// RVA: 0x17FBFA0 Offset: 0x17FA5A0 VA: 0x1817FBFA0
	public static bool IsNullOrDestroyed(object object) { }

	// RVA: -1 Offset: -1
	public static bool IsNullOrDestroyed<T>(T object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E460 Offset: 0x80CA60 VA: 0x18080E460
	|-UnityTools.IsNullOrDestroyed<object>
	*/

	// RVA: -1 Offset: -1
	private static  inBIKxZvtYWAEPqUToPvRxACpxD<>( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E600 Offset: 0x80CC00 VA: 0x18080E600
	|-UnityTools.inBIKxZvtYWAEPqUToPvRxACpxD<object>
	*/

	// RVA: 0x1800280 Offset: 0x17FE880 VA: 0x181800280
	internal static ButtonStateFlags nckyPBRZVfXeVpznRIzCdrcoaQmL(KeyCode ) { }

	// RVA: 0x17F7600 Offset: 0x17F5C00 VA: 0x1817F7600
	internal static ButtonStateFlags BPghflXjRGUVgYZoMBasViRqnnGr(string ) { }

	// RVA: 0x17FDB40 Offset: 0x17FC140 VA: 0x1817FDB40
	private static void .cctor() { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class EqualityComparerNoAlloc<T> // TypeDefIndex: 2919
{
	// Properties
	public static IEqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static IEqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF8760 Offset: 0xEF6D60 VA: 0x180EF8760
	|-EqualityComparerNoAlloc<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_Default
	|
	|-RVA: 0xEFDB30 Offset: 0xEFC130 VA: 0x180EFDB30
	|-EqualityComparerNoAlloc<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_Default
	|
	|-RVA: 0xEFE590 Offset: 0xEFCB90 VA: 0x180EFE590
	|-EqualityComparerNoAlloc<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_Default
	|
	|-RVA: 0xEFEFF0 Offset: 0xEFD5F0 VA: 0x180EFEFF0
	|-EqualityComparerNoAlloc<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_Default
	|
	|-RVA: 0xEFBC10 Offset: 0xEFA210 VA: 0x180EFBC10
	|-EqualityComparerNoAlloc<bool>.get_Default
	|
	|-RVA: 0xEF7D00 Offset: 0xEF6300 VA: 0x180EF7D00
	|-EqualityComparerNoAlloc<Bytes20>.get_Default
	|
	|-RVA: 0xEF72A0 Offset: 0xEF58A0 VA: 0x180EF72A0
	|-EqualityComparerNoAlloc<Guid>.get_Default
	|
	|-RVA: 0xEFA680 Offset: 0xEF8C80 VA: 0x180EFA680
	|-EqualityComparerNoAlloc<int>.get_Default
	|
	|-RVA: 0xEFC670 Offset: 0xEFAC70 VA: 0x180EFC670
	|-EqualityComparerNoAlloc<Int32Enum>.get_Default
	|
	|-RVA: 0xEFD0D0 Offset: 0xEFB6D0 VA: 0x180EFD0D0
	|-EqualityComparerNoAlloc<IntPtr>.get_Default
	|
	|-RVA: 0xEF9C20 Offset: 0xEF8220 VA: 0x180EF9C20
	|-EqualityComparerNoAlloc<object>.get_Default
	|
	|-RVA: 0xEF91C0 Offset: 0xEF77C0 VA: 0x180EF91C0
	|-EqualityComparerNoAlloc<float>.get_Default
	|
	|-RVA: 0xEF6840 Offset: 0xEF4E40 VA: 0x180EF6840
	|-EqualityComparerNoAlloc<uint>.get_Default
	|
	|-RVA: 0xEFB0E0 Offset: 0xEF96E0 VA: 0x180EFB0E0
	|-EqualityComparerNoAlloc<__Il2CppFullySharedGenericType>.get_Default
	|
	|-RVA: 0xF00F10 Offset: 0xEFF510 VA: 0x180F00F10
	|-EqualityComparerNoAlloc<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.get_Default
	|
	|-RVA: 0xF004B0 Offset: 0xEFEAB0 VA: 0x180F004B0
	|-EqualityComparerNoAlloc<SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_Default
	|
	|-RVA: 0xEFFA50 Offset: 0xEFE050 VA: 0x180EFFA50
	|-EqualityComparerNoAlloc<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_Default
	*/
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class PlatformTools // TypeDefIndex: 2921
{
	// Methods

	// RVA: 0x17E9180 Offset: 0x17E7780 VA: 0x1817E9180
	public static bool IsSysVersionInRange(string min, string max) { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class Factory // TypeDefIndex: 2922
{
	// Methods

	// RVA: 0x17E2700 Offset: 0x17E0D00 VA: 0x1817E2700
	public static object CreateInstance(Type type, object[] args) { }
}

// Namespace: Rewired.Utils
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class EnumValueHelper<TEnum> // TypeDefIndex: 2923
{
	// Fields
	private static EnumValueHelper<TEnum> TbhLQBxFVMaJCgQSZhVaDSqelHcJ; // 0x0
	private TEnum[] hbtxQdqQbMonAdiZleikFRbnyqWrA; // 0x0
	private ReadOnlyCollection<TEnum> PypSMfFNLkCnwCMtEIXkCvYKBMQBb; // 0x0
	private string[] tyaGAfjRDBTtAaJLAiiFnfITjPRVA; // 0x0
	private ReadOnlyCollection<string> OfpmNukvOUWconsLILOiIGCzEuYx; // 0x0

	// Properties
	public static EnumValueHelper<TEnum> Default { get; }
	public IList<TEnum> values { get; }
	public IList<string> names { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EnumValueHelper<TEnum> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE937F0 Offset: 0xE91DF0 VA: 0x180E937F0
	|-EnumValueHelper<Int32Enum>.get_Default
	|
	|-RVA: 0xACEF90 Offset: 0xACD590 VA: 0x180ACEF90
	|-EnumValueHelper<__Il2CppFullySharedGenericType>.get_Default
	*/

	// RVA: -1 Offset: -1
	public IList<TEnum> get_values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-EnumValueHelper<Int32Enum>.get_values
	|-EnumValueHelper<__Il2CppFullySharedGenericType>.get_values
	*/

	// RVA: -1 Offset: -1
	public IList<string> get_names() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE93A30 Offset: 0xE92030 VA: 0x180E93A30
	|-EnumValueHelper<Int32Enum>.get_names
	|
	|-RVA: 0xE93930 Offset: 0xE91F30 VA: 0x180E93930
	|-EnumValueHelper<__Il2CppFullySharedGenericType>.get_names
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE935D0 Offset: 0xE91BD0 VA: 0x180E935D0
	|-EnumValueHelper<Int32Enum>..ctor
	|
	|-RVA: 0xE933B0 Offset: 0xE919B0 VA: 0x180E933B0
	|-EnumValueHelper<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Rewired.Utils
[EditorBrowsable(1)]
public class ExternalTools : IExternalTools // TypeDefIndex: 5182
{
	// Fields
	private static Func<object> _getPlatformInitializerDelegate; // 0x0
	private bool _isEditorPaused; // 0x10
	private Action<bool> _EditorPausedStateChangedEvent; // 0x18
	[CompilerGenerated]
	private Action<uint, bool> XboxOneInput_OnGamepadStateChange; // 0x20

	// Properties
	public static Func<object> getPlatformInitializerDelegate { get; set; }
	public bool isEditorPaused { get; }
	public bool UnityInput_IsTouchPressureSupported { get; }

	// Methods

	// RVA: 0x37ACC0 Offset: 0x3792C0 VA: 0x18037ACC0
	public static Func<object> get_getPlatformInitializerDelegate() { }

	// RVA: 0x37AE70 Offset: 0x379470 VA: 0x18037AE70
	public static void set_getPlatformInitializerDelegate(Func<object> value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public void Destroy() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00 Slot: 4
	public bool get_isEditorPaused() { }

	// RVA: 0x37AB50 Offset: 0x379150 VA: 0x18037AB50 Slot: 5
	public void add_EditorPausedStateChangedEvent(Action<bool> value) { }

	// RVA: 0x37AD10 Offset: 0x379310 VA: 0x18037AD10 Slot: 6
	public void remove_EditorPausedStateChangedEvent(Action<bool> value) { }

	// RVA: 0x37A890 Offset: 0x378E90 VA: 0x18037A890 Slot: 8
	public object GetPlatformInitializer() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 9
	public string GetFocusedEditorWindowTitle() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	public bool IsEditorSceneViewFocused() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 11
	public bool LinuxInput_IsJoystickPreconfigured(string name) { }

	[CompilerGenerated]
	// RVA: 0x37AC00 Offset: 0x379200 VA: 0x18037AC00 Slot: 14
	public void add_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x37ADC0 Offset: 0x3793C0 VA: 0x18037ADC0 Slot: 15
	public void remove_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 12
	public int XboxOneInput_GetUserIdForGamepad(uint id) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 13
	public ulong XboxOneInput_GetControllerId(uint unityJoystickId) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 17
	public string XboxOneInput_GetControllerType(ulong xboxControllerId) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 18
	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 19
	public void XboxOne_Gamepad_UpdatePlugin() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 20
	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS) { }

	// RVA: 0x37A7C0 Offset: 0x378DC0 VA: 0x18037A7C0 Slot: 22
	public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids) { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690 Slot: 23
	public int GetAndroidAPILevel() { }

	// RVA: 0x37AB10 Offset: 0x379110 VA: 0x18037AB10 Slot: 24
	public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize) { }

	// RVA: 0x37A8D0 Offset: 0x378ED0 VA: 0x18037A8D0 Slot: 25
	public bool UnityUI_Graphic_GetRaycastTarget(object graphic) { }

	// RVA: 0x37A9F0 Offset: 0x378FF0 VA: 0x18037A9F0 Slot: 26
	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value) { }

	// RVA: 0x37ACB0 Offset: 0x3792B0 VA: 0x18037ACB0 Slot: 27
	public bool get_UnityInput_IsTouchPressureSupported() { }

	// RVA: 0x37A8C0 Offset: 0x378EC0 VA: 0x18037A8C0 Slot: 28
	public float UnityInput_GetTouchPressure(ref Touch touch) { }

	// RVA: 0x37A8B0 Offset: 0x378EB0 VA: 0x18037A8B0 Slot: 29
	public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) { }

	// RVA: 0x37A620 Offset: 0x378C20 VA: 0x18037A620 Slot: 30
	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) { }

	// RVA: 0x37A730 Offset: 0x378D30 VA: 0x18037A730 Slot: 31
	public Type[] GetControllerTemplateTypes() { }

	// RVA: 0x37A6A0 Offset: 0x378CA0 VA: 0x18037A6A0 Slot: 32
	public Type[] GetControllerTemplateInterfaceTypes() { }
}

