// Namespace: Unity.Hierarchy
[RequiredByNativeCode(GenerateProxy = True)]
public abstract class HierarchyNodeTypeHandlerBase : IDisposable // TypeDefIndex: 14224
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEditor.HierarchyModule" })]
	[RequiredByNativeCode]
	internal IntPtr m_Ptr; // 0x10
	[VisibleToOtherModules(new[] { "UnityEditor.HierarchyModule" })]
	[RequiredByNativeCode]
	internal bool m_IsWrapper; // 0x18
	[RequiredByNativeCode]
	private readonly Hierarchy m_Hierarchy; // 0x20
	private static readonly Dictionary<Type, int> s_NodeTypes; // 0x0

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	internal virtual void Initialize() { }

	// RVA: 0x236BF80 Offset: 0x236A580 VA: 0x18236BF80 Slot: 4
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x236C0D0 Offset: 0x236A6D0 VA: 0x18236C0D0 Slot: 7
	public virtual string GetNodeTypeName() { }

	// RVA: 0x236BFE0 Offset: 0x236A5E0 VA: 0x18236BFE0 Slot: 8
	public virtual HierarchyNodeFlags GetDefaultNodeFlags(in HierarchyNode node, HierarchyNodeFlags defaultFlags = 0) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool ChangesPending();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract bool IntegrateChanges(HierarchyCommandList cmdList);

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	protected virtual void SearchBegin(HierarchySearchQueryDescriptor query) { }

	// RVA: 0x22F0DD0 Offset: 0x22EF3D0 VA: 0x1822F0DD0 Slot: 12
	protected virtual bool SearchMatch(in HierarchyNode node) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	protected virtual void SearchEnd() { }

	// RVA: 0x236C0F0 Offset: 0x236A6F0 VA: 0x18236C0F0
	internal void Internal_SearchBegin(HierarchySearchQueryDescriptor query) { }

	// RVA: 0x236BFF0 Offset: 0x236A5F0 VA: 0x18236BFF0
	private static HierarchyNodeTypeHandlerBase GetHandlerFromPtr(IntPtr ptr) { }

	[UsedByNativeCode]
	// RVA: 0x236C180 Offset: 0x236A780 VA: 0x18236C180
	private static HierarchyNodeTypeHandlerBase InvokeCreateInstance(Type type, Hierarchy hierarchy) { }

	[UsedByNativeCode]
	// RVA: 0x236C600 Offset: 0x236AC00 VA: 0x18236C600
	private static bool InvokeTryGetNodeType(Type type, out int nodeType) { }

	[UsedByNativeCode]
	// RVA: 0x236C420 Offset: 0x236AA20 VA: 0x18236C420
	private static void InvokeInitialize(IntPtr ptr) { }

	[UsedByNativeCode]
	// RVA: 0x236C270 Offset: 0x236A870 VA: 0x18236C270
	private static void InvokeDispose(IntPtr ptr) { }

	[UsedByNativeCode]
	// RVA: 0x236C3B0 Offset: 0x236A9B0 VA: 0x18236C3B0
	private static string InvokeGetNodeTypeName(IntPtr ptr) { }

	[UsedByNativeCode]
	// RVA: 0x236C320 Offset: 0x236A920 VA: 0x18236C320
	private static HierarchyNodeFlags InvokeGetDefaultNodeFlags(IntPtr ptr, in HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	[UsedByNativeCode]
	// RVA: 0x236C110 Offset: 0x236A710 VA: 0x18236C110
	private static bool InvokeChangesPending(IntPtr ptr) { }

	[UsedByNativeCode]
	// RVA: 0x236C490 Offset: 0x236AA90 VA: 0x18236C490
	private static bool InvokeIntegrateChanges(IntPtr ptr, HierarchyCommandList cmdList) { }

	[UsedByNativeCode]
	// RVA: 0x236C580 Offset: 0x236AB80 VA: 0x18236C580
	private static bool InvokeSearchMatch(IntPtr ptr, in HierarchyNode node) { }

	[UsedByNativeCode]
	// RVA: 0x236C510 Offset: 0x236AB10 VA: 0x18236C510
	private static void InvokeSearchEnd(IntPtr ptr) { }

	// RVA: 0x236C790 Offset: 0x236AD90 VA: 0x18236C790
	private static void .cctor() { }
}

// Namespace: Unity.Hierarchy
[VisibleToOtherModules(new[] { "UnityEditor.HierarchyModule" })]
internal interface IHierarchySearchQueryParser // TypeDefIndex: 14225
{}

// Namespace: Unity.Hierarchy
[NativeType(Header = "Modules/HierarchyCore/Public/Hierarchy.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public sealed class Hierarchy : IDisposable // TypeDefIndex: 14227
{
	// Fields
	[RequiredByNativeCode]
	private IntPtr m_Ptr; // 0x10
	[RequiredByNativeCode]
	private readonly bool m_IsWrapper; // 0x18

	// Methods

	[FreeFunction("HierarchyBindings::Destroy")]
	// RVA: 0x236E100 Offset: 0x236C700 VA: 0x18236E100
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x236DFC0 Offset: 0x236C5C0 VA: 0x18236DFC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x236DF60 Offset: 0x236C560 VA: 0x18236DF60
	private void Dispose(bool disposing) { }

	[FreeFunction("HierarchyBindings::GetAllNodeTypeHandlersBase", HasExplicitThis = True)]
	// RVA: 0x236E0A0 Offset: 0x236C6A0 VA: 0x18236E0A0
	public void GetAllNodeTypeHandlersBase(List<HierarchyNodeTypeHandlerBase> handlers) { }

	// RVA: 0x236E050 Offset: 0x236C650 VA: 0x18236E050
	private static void GetAllNodeTypeHandlersBase_Injected(IntPtr _unity_self, List<HierarchyNodeTypeHandlerBase> handlers) { }
}

// Namespace: Unity.Hierarchy
[NativeType(Header = "Modules/HierarchyCore/Public/HierarchyCommandList.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyCommandListBindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public sealed class HierarchyCommandList // TypeDefIndex: 14228
{
	// Fields
	[RequiredByNativeCode]
	private IntPtr m_Ptr; // 0x10
	[RequiredByNativeCode]
	private readonly bool m_IsWrapper; // 0x18
	[RequiredByNativeCode]
	[VisibleToOtherModules(new[] { "UnityEngine.HierarchyModule" })]
	internal readonly Hierarchy m_Hierarchy; // 0x20
}

// Namespace: Unity.Hierarchy
[DefaultMember("Item")]
[NativeType(Header = "Modules/HierarchyCore/Public/HierarchyFlattened.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyFlattenedBindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public sealed class HierarchyFlattened // TypeDefIndex: 14229
{
	// Fields
	[RequiredByNativeCode]
	private IntPtr m_Ptr; // 0x10
	[RequiredByNativeCode]
	private readonly bool m_IsWrapper; // 0x18
	[RequiredByNativeCode]
	private readonly Hierarchy m_Hierarchy; // 0x20
	[RequiredByNativeCode]
	private readonly IntPtr m_NodesPtr; // 0x28
	[RequiredByNativeCode]
	private readonly int m_NodesCount; // 0x30
	[RequiredByNativeCode]
	private readonly int m_Version; // 0x34
}

// Namespace: Unity.Hierarchy
[IsReadOnly]
[NativeType(Header = "Modules/HierarchyCore/Public/HierarchyNode.h")]
public struct HierarchyNode : IEquatable<HierarchyNode> // TypeDefIndex: 14230
{
	// Fields
	private static readonly HierarchyNode s_Null; // 0x0
	private readonly int m_Id; // 0x0
	private readonly int m_Version; // 0x4

	// Properties
	[IsReadOnly]
	public static HierarchyNode Null { get; }
	public int Id { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x236CA50 Offset: 0x236B050 VA: 0x18236CA50
	public static ref HierarchyNode get_Null() { }

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_Id() { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_Version() { }

	[ExcludeFromDocs]
	// RVA: 0x236CA90 Offset: 0x236B090 VA: 0x18236CA90
	public static bool op_Equality(in HierarchyNode lhs, in HierarchyNode rhs) { }

	[ExcludeFromDocs]
	// RVA: 0x236C8B0 Offset: 0x236AEB0 VA: 0x18236C8B0 Slot: 4
	public bool Equals(HierarchyNode other) { }

	[ExcludeFromDocs]
	// RVA: 0x236C940 Offset: 0x236AF40 VA: 0x18236C940 Slot: 3
	public override string ToString() { }

	[ExcludeFromDocs]
	// RVA: 0x236C820 Offset: 0x236AE20 VA: 0x18236C820 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x236C8D0 Offset: 0x236AED0 VA: 0x18236C8D0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Unity.Hierarchy
[Flags]
[NativeType("Modules/HierarchyCore/Public/HierarchyNodeFlags.h")]
public enum HierarchyNodeFlags // TypeDefIndex: 14231
{
	// Fields
	public uint value__; // 0x0
	public const HierarchyNodeFlags None = 0;
	public const HierarchyNodeFlags Expanded = 1;
	public const HierarchyNodeFlags Selected = 2;
	public const HierarchyNodeFlags Cut = 4;
}

// Namespace: Unity.Hierarchy
[NativeType("Modules/HierarchyCore/Public/HierarchySearch.h")]
public enum HierarchySearchFilterOperator // TypeDefIndex: 14232
{
	// Fields
	public int value__; // 0x0
	public const HierarchySearchFilterOperator Equal = 0;
	public const HierarchySearchFilterOperator Contains = 1;
	public const HierarchySearchFilterOperator Greater = 2;
	public const HierarchySearchFilterOperator GreaterOrEqual = 3;
	public const HierarchySearchFilterOperator Lesser = 4;
	public const HierarchySearchFilterOperator LesserOrEqual = 5;
	public const HierarchySearchFilterOperator NotEqual = 6;
	public const HierarchySearchFilterOperator Not = 7;
}

// Namespace: Unity.Hierarchy
[NativeType("Modules/HierarchyCore/Public/HierarchySearch.h")]
[RequiredByNativeCode]
[Serializable]
public struct HierarchySearchFilter // TypeDefIndex: 14233
{
	// Fields
	private static readonly char[] s_WhiteSpaces; // 0x0
	private static readonly HierarchySearchFilter s_Invalid; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Value>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <NumValue>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private HierarchySearchFilterOperator <Op>k__BackingField; // 0x14

	// Properties
	[IsReadOnly]
	public static HierarchySearchFilter Invalid { get; }
	public bool IsValid { get; }
	public string Name { get; }
	public string Value { get; }
	public float NumValue { get; }
	public HierarchySearchFilterOperator Op { get; }

	// Methods

	// RVA: 0x236D000 Offset: 0x236B600 VA: 0x18236D000
	public static ref HierarchySearchFilter get_Invalid() { }

	// RVA: 0x236D050 Offset: 0x236B650 VA: 0x18236D050
	public bool get_IsValid() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public string get_Name() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public string get_Value() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_NumValue() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public HierarchySearchFilterOperator get_Op() { }

	// RVA: 0x236CB70 Offset: 0x236B170 VA: 0x18236CB70
	public static string ToString(HierarchySearchFilterOperator op) { }

	// RVA: 0x236CD10 Offset: 0x236B310 VA: 0x18236CD10 Slot: 3
	public override string ToString() { }

	// RVA: 0x236CAB0 Offset: 0x236B0B0 VA: 0x18236CAB0
	internal static string QuoteStringIfNeeded(string s) { }

	// RVA: 0x236CF70 Offset: 0x236B570 VA: 0x18236CF70
	private static void .cctor() { }
}

// Namespace: Unity.Hierarchy
[NativeAsStruct]
[NativeType("Modules/HierarchyCore/Public/HierarchySearch.h")]
[RequiredByNativeCode]
[Serializable]
public sealed class HierarchySearchQueryDescriptor // TypeDefIndex: 14235
{
	// Fields
	private static readonly HashSet<string> s_SystemFilters; // 0x0
	private static readonly HierarchySearchQueryDescriptor s_Empty; // 0x8
	private static readonly HierarchySearchQueryDescriptor s_InvalidQuery; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private HierarchySearchFilter[] <SystemFilters>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private HierarchySearchFilter[] <Filters>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string[] <TextValues>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Strict>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <Invalid>k__BackingField; // 0x29

	// Properties
	public HierarchySearchFilter[] SystemFilters { get; set; }
	public HierarchySearchFilter[] Filters { get; set; }
	public string[] TextValues { get; set; }
	public bool Strict { set; }
	public bool Invalid { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public HierarchySearchFilter[] get_SystemFilters() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_SystemFilters(HierarchySearchFilter[] value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public HierarchySearchFilter[] get_Filters() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Filters(HierarchySearchFilter[] value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string[] get_TextValues() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_TextValues(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_Strict(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EC4A60 Offset: 0x1EC3060 VA: 0x181EC4A60
	public void set_Invalid(bool value) { }

	// RVA: 0x236D7F0 Offset: 0x236BDF0 VA: 0x18236D7F0
	public void .ctor(HierarchySearchFilter[] filters, string[] textValues) { }

	// RVA: 0x236D620 Offset: 0x236BC20 VA: 0x18236D620 Slot: 3
	public override string ToString() { }

	[VisibleToOtherModules(new[] { "UnityEditor.HierarchyModule" })]
	// RVA: 0x236D0A0 Offset: 0x236B6A0 VA: 0x18236D0A0
	internal string BuildFilterQuery() { }

	// RVA: 0x236D410 Offset: 0x236BA10 VA: 0x18236D410
	internal string BuildSystemFilterQuery() { }

	// RVA: 0x236D460 Offset: 0x236BA60 VA: 0x18236D460
	internal string BuildTextQuery() { }

	// RVA: 0x236D0F0 Offset: 0x236B6F0 VA: 0x18236D0F0
	internal string BuildQuery() { }

	// RVA: -1 Offset: -1
	private static T[] Where<T>(IEnumerable<T> src, Func<T, bool> pred) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7095D0 Offset: 0x707BD0 VA: 0x1807095D0
	|-HierarchySearchQueryDescriptor.Where<HierarchySearchFilter>
	|
	|-RVA: 0x709AF0 Offset: 0x7080F0 VA: 0x180709AF0
	|-HierarchySearchQueryDescriptor.Where<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x236D630 Offset: 0x236BC30 VA: 0x18236D630
	private static void .cctor() { }
}

// Namespace: Unity.Hierarchy
[NativeType(Header = "Modules/HierarchyCore/Public/HierarchyViewModel.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyViewModelBindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[DefaultMember("Item")]
public sealed class HierarchyViewModel // TypeDefIndex: 14237
{
	// Fields
	[RequiredByNativeCode]
	private IntPtr m_Ptr; // 0x10
	[RequiredByNativeCode]
	private readonly bool m_IsWrapper; // 0x18
	[RequiredByNativeCode]
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x20
	[RequiredByNativeCode]
	private readonly Hierarchy m_Hierarchy; // 0x28
	[RequiredByNativeCode]
	private readonly IntPtr m_NodesPtr; // 0x30
	[RequiredByNativeCode]
	private readonly int m_NodesCount; // 0x38
	[RequiredByNativeCode]
	private readonly int m_Version; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private IHierarchySearchQueryParser <QueryParser>k__BackingField; // 0x40

	// Properties
	internal HierarchySearchQueryDescriptor Query { get; }

	// Methods

	[VisibleToOtherModules(new[] { "UnityEngine.HierarchyModule" })]
	// RVA: 0x236DF00 Offset: 0x236C500 VA: 0x18236DF00
	internal HierarchySearchQueryDescriptor get_Query() { }

	[RequiredByNativeCode]
	// RVA: 0x236DC20 Offset: 0x236C220 VA: 0x18236DC20
	internal void SearchBegin() { }

	// RVA: 0x236DEC0 Offset: 0x236C4C0 VA: 0x18236DEC0
	private static HierarchySearchQueryDescriptor get_Query_Injected(IntPtr _unity_self) { }
}

