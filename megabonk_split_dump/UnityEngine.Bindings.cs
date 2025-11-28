// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal struct Unmarshal // TypeDefIndex: 9869
{
	// Methods

	// RVA: -1 Offset: -1
	public static T UnmarshalUnityObject<T>(IntPtr gcHandlePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E6D0 Offset: 0x80CCD0 VA: 0x18080E6D0
	|-Unmarshal.UnmarshalUnityObject<object>
	*/

	// RVA: 0x2369A40 Offset: 0x2368040 VA: 0x182369A40
	public static GCHandle FromIntPtrUnsafe(IntPtr gcHandle) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal static class ThrowHelper // TypeDefIndex: 9870
{
	// Methods

	[DoesNotReturn]
	// RVA: 0x23641F0 Offset: 0x23627F0 VA: 0x1823641F0
	public static void ThrowArgumentNullException(object obj, string parameterName) { }

	[DoesNotReturn]
	// RVA: 0x2364270 Offset: 0x2362870 VA: 0x182364270
	public static void ThrowNullReferenceException(object obj) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[StaticAccessor("Marshalling::BindingsAllocator", 2)]
[NativeHeader("Runtime/Scripting/Marshalling/BindingsAllocator.h")]
internal static class BindingsAllocator // TypeDefIndex: 9872
{
	// Methods

	[ThreadSafe]
	// RVA: 0x234D5E0 Offset: 0x234BBE0 VA: 0x18234D5E0
	public static void Free(void* ptr) { }

	[ThreadSafe]
	// RVA: 0x234D5A0 Offset: 0x234BBA0 VA: 0x18234D5A0
	public static void FreeNativeOwnedMemory(void* ptr) { }

	// RVA: 0x234D620 Offset: 0x234BC20 VA: 0x18234D620
	public static void* GetNativeOwnedDataPointer(void* ptr) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct BlittableArrayWrapper // TypeDefIndex: 9874
{
	// Fields
	internal void* data; // 0x0
	internal int size; // 0x8
	internal BlittableArrayWrapper.UpdateFlags updateFlags; // 0xC

	// Methods

	// RVA: 0x234D640 Offset: 0x234BC40 VA: 0x18234D640
	public void .ctor(void* data, int size) { }

	// RVA: -1 Offset: -1
	internal void Unmarshal<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B1950 Offset: 0x6AFF50 VA: 0x1806B1950
	|-BlittableArrayWrapper.Unmarshal<bool>
	|-BlittableArrayWrapper.Unmarshal<byte>
	|
	|-RVA: 0x6B1AB0 Offset: 0x6B00B0 VA: 0x1806B1AB0
	|-BlittableArrayWrapper.Unmarshal<GlyphMarshallingStruct>
	|
	|-RVA: 0x6B1C10 Offset: 0x6B0210 VA: 0x1806B1C10
	|-BlittableArrayWrapper.Unmarshal<GlyphPairAdjustmentRecord>
	|-BlittableArrayWrapper.Unmarshal<RaycastHit>
	|
	|-RVA: 0x6B1D70 Offset: 0x6B0370 VA: 0x1806B1D70
	|-BlittableArrayWrapper.Unmarshal<GlyphRect>
	|-BlittableArrayWrapper.Unmarshal<Resolution>
	|
	|-RVA: 0x6B1ED0 Offset: 0x6B04D0 VA: 0x1806B1ED0
	|-BlittableArrayWrapper.Unmarshal<GradientAlphaKey>
	|
	|-RVA: 0x6B2030 Offset: 0x6B0630 VA: 0x1806B2030
	|-BlittableArrayWrapper.Unmarshal<GradientColorKey>
	|
	|-RVA: 0x6B22F0 Offset: 0x6B08F0 VA: 0x1806B22F0
	|-BlittableArrayWrapper.Unmarshal<int>
	|
	|-RVA: 0x6B2450 Offset: 0x6B0A50 VA: 0x1806B2450
	|-BlittableArrayWrapper.Unmarshal<Keyframe>
	|
	|-RVA: 0x6B25B0 Offset: 0x6B0BB0 VA: 0x1806B25B0
	|-BlittableArrayWrapper.Unmarshal<MarkToBaseAdjustmentRecord>
	|-BlittableArrayWrapper.Unmarshal<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x6B2870 Offset: 0x6B0E70 VA: 0x1806B2870
	|-BlittableArrayWrapper.Unmarshal<RaycastHit2D>
	|
	|-RVA: 0x6B2190 Offset: 0x6B0790 VA: 0x1806B2190
	|-BlittableArrayWrapper.Unmarshal<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x6B2710 Offset: 0x6B0D10 VA: 0x1806B2710
	|-BlittableArrayWrapper.Unmarshal<ParticleSystem.Particle>
	*/
}

// Namespace: UnityEngine.Bindings
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[VisibleToOtherModules]
internal struct BlittableListWrapper // TypeDefIndex: 9875
{
	// Fields
	private BlittableArrayWrapper arrayWrapper; // 0x0
	private int listSize; // 0x10

	// Methods

	// RVA: 0x11054F0 Offset: 0x1103AF0 VA: 0x1811054F0
	public void .ctor(BlittableArrayWrapper arrayWrapper, int listSize) { }

	// RVA: -1 Offset: -1
	internal void Unmarshal<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B2B20 Offset: 0x6B1120 VA: 0x1806B2B20
	|-BlittableListWrapper.Unmarshal<RaycastHit2D>
	|
	|-RVA: 0x6B29D0 Offset: 0x6B0FD0 VA: 0x1806B29D0
	|-BlittableListWrapper.Unmarshal<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal static class ExceptionMarshaller // TypeDefIndex: 9876
{
	// Fields
	[ThreadStatic]
	private static Exception s_pendingException; // 0x80000000

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2352FF0 Offset: 0x23515F0 VA: 0x182352FF0
	private static void SetPendingException(Exception ex) { }
}

// Namespace: UnityEngine.Bindings
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
[IsReadOnly]
[VisibleToOtherModules]
internal struct ManagedSpanWrapper // TypeDefIndex: 9877
{
	// Fields
	public readonly void* begin; // 0x0
	public readonly int length; // 0x8

	// Methods

	// RVA: 0x908A30 Offset: 0x907030 VA: 0x180908A30
	public void .ctor(void* begin, int length) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal static class StringMarshaller // TypeDefIndex: 9878
{
	// Methods

	// RVA: 0x23630D0 Offset: 0x23616D0 VA: 0x1823630D0
	public static bool TryMarshalEmptyOrNullString(string s, ref ManagedSpanWrapper managedSpanWrapper) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct OutStringMarshaller // TypeDefIndex: 9879
{
	// Methods

	// RVA: 0x2358180 Offset: 0x2356780 VA: 0x182358180
	public static string GetStringAndDispose(ManagedSpanWrapper managedSpan) { }
}

// Namespace: UnityEngine.Bindings
[Usage(5628, Inherited = False)]
[VisibleToOtherModules]
internal class VisibleToOtherModulesAttribute : Attribute // TypeDefIndex: 14155
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor(string[] modules) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(204)]
internal class NativeConditionalAttribute : Attribute // TypeDefIndex: 14156
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Condition>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <StubReturnStatement>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; // 0x20

	// Properties
	public string Condition { set; }
	public string StubReturnStatement { set; }
	public bool Enabled { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Condition(string value) { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_StubReturnStatement(string value) { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_Enabled(bool value) { }

	// RVA: 0x23DF940 Offset: 0x23DDF40 VA: 0x1823DF940
	public void .ctor(string condition) { }

	// RVA: 0x23DF8E0 Offset: 0x23DDEE0 VA: 0x1823DF8E0
	public void .ctor(string condition, string stubReturnStatement) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(10716, AllowMultiple = True)]
internal class NativeHeaderAttribute : Attribute // TypeDefIndex: 14157
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Header>k__BackingField; // 0x10

	// Properties
	public string Header { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 7
	public void set_Header(string value) { }

	// RVA: 0x23DF980 Offset: 0x23DDF80 VA: 0x1823DF980
	public void .ctor(string header) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(448)]
internal class NativeNameAttribute : Attribute // TypeDefIndex: 14158
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 7
	public void set_Name(string value) { }

	// RVA: 0x23DFC10 Offset: 0x23DE210 VA: 0x1823DFC10
	public void .ctor(string name) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(192)]
internal class NativeMethodAttribute : Attribute // TypeDefIndex: 14159
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsThreadSafe>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsFreeFunction>k__BackingField; // 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <ThrowsException>k__BackingField; // 0x1A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Properties
	public string Name { set; }
	public bool IsThreadSafe { set; }
	public bool IsFreeFunction { set; }
	public bool ThrowsException { set; }
	public bool HasExplicitThis { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 7
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40 Slot: 8
	public void set_IsThreadSafe(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B50 Offset: 0x4E4150 VA: 0x1804E5B50 Slot: 9
	public void set_IsFreeFunction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1698DC0 Offset: 0x16973C0 VA: 0x181698DC0 Slot: 10
	public void set_ThrowsException(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1897450 Offset: 0x1895A50 VA: 0x181897450 Slot: 11
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x23DFAD0 Offset: 0x23DE0D0 VA: 0x1823DFAD0
	public void .ctor(string name) { }

	// RVA: 0x23DFBE0 Offset: 0x23DE1E0 VA: 0x1823DFBE0
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x23DFA90 Offset: 0x23DE090 VA: 0x1823DFA90
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum TargetType // TypeDefIndex: 14160
{
	// Fields
	public int value__; // 0x0
	public const TargetType Function = 0;
	public const TargetType Field = 1;
}

// Namespace: UnityEngine.Bindings
[Usage(128)]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute // TypeDefIndex: 14161
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TargetType <TargetType>k__BackingField; // 0x20

	// Properties
	public TargetType TargetType { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_TargetType(TargetType value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x23DFD20 Offset: 0x23DE320 VA: 0x1823DFD20
	public void .ctor(string name) { }

	// RVA: 0x23DFD30 Offset: 0x23DE330 VA: 0x1823DFD30
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x23DFD70 Offset: 0x23DE370 VA: 0x1823DFD70
	public void .ctor(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum CodegenOptions // TypeDefIndex: 14162
{
	// Fields
	public int value__; // 0x0
	public const CodegenOptions Auto = 0;
	public const CodegenOptions Custom = 1;
	public const CodegenOptions Force = 2;
}

// Namespace: UnityEngine.Bindings
[Usage(4)]
[VisibleToOtherModules]
internal class NativeAsStructAttribute : Attribute // TypeDefIndex: 14163
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(28)]
internal class NativeTypeAttribute : Attribute // TypeDefIndex: 14164
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Header>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 7
	public void set_Header(string value) { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230 Slot: 8
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x23DFF60 Offset: 0x23DE560 VA: 0x1823DFF60
	public void .ctor() { }

	// RVA: 0x23DFEF0 Offset: 0x23DE4F0 VA: 0x1823DFEF0
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x23DFDD0 Offset: 0x23DE3D0 VA: 0x1823DFDD0
	public void .ctor(string header) { }

	// RVA: 0x23DFF20 Offset: 0x23DE520 VA: 0x1823DFF20
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(2048)]
internal class NotNullAttribute : Attribute // TypeDefIndex: 14165
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(10240)]
internal class UnmarshalledAttribute : Attribute // TypeDefIndex: 14166
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(64)]
internal class FreeFunctionAttribute : NativeMethodAttribute // TypeDefIndex: 14167
{
	// Methods

	// RVA: 0x23DF7F0 Offset: 0x23DDDF0 VA: 0x1823DF7F0
	public void .ctor() { }

	// RVA: 0x23DF810 Offset: 0x23DDE10 VA: 0x1823DF810
	public void .ctor(string name) { }

	// RVA: 0x23DF830 Offset: 0x23DDE30 VA: 0x1823DF830
	public void .ctor(string name, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(64)]
internal class ThreadSafeAttribute : NativeMethodAttribute // TypeDefIndex: 14168
{
	// Methods

	// RVA: 0x23DFFB0 Offset: 0x23DE5B0 VA: 0x1823DFFB0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum StaticAccessorType // TypeDefIndex: 14169
{
	// Fields
	public int value__; // 0x0
	public const StaticAccessorType Dot = 0;
	public const StaticAccessorType Arrow = 1;
	public const StaticAccessorType DoubleColon = 2;
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3;
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(204)]
internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 14170
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties
	public string Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_Type(StaticAccessorType value) { }

	[VisibleToOtherModules]
	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	internal void .ctor(string name) { }

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	public void .ctor(string name, StaticAccessorType type) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(192)]
internal class NativeThrowsAttribute : Attribute // TypeDefIndex: 14171
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; // 0x10

	// Properties
	public bool ThrowsException { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0 Slot: 7
	public void set_ThrowsException(bool value) { }

	// RVA: 0x23DFDB0 Offset: 0x23DE3B0 VA: 0x1823DFDB0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(256)]
internal class IgnoreAttribute : Attribute // TypeDefIndex: 14172
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Properties
	public bool DoesNotContributeToSize { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4, AllowMultiple = False, Inherited = False)]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute // TypeDefIndex: 14173
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

