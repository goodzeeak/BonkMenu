// Namespace: UnityEngine.UIElements.Layout
[IsReadOnly]
internal struct LayoutConfig // TypeDefIndex: 4461
{
	// Fields
	private readonly LayoutDataAccess m_Access; // 0x0
	private readonly LayoutHandle m_Handle; // 0x28

	// Properties
	public static LayoutConfig Undefined { get; }
	public LayoutHandle Handle { get; }
	public float PointScaleFactor { get; }

	// Methods

	// RVA: 0x25289A0 Offset: 0x2526FA0 VA: 0x1825289A0
	public static LayoutConfig get_Undefined() { }

	// RVA: 0x2528970 Offset: 0x2526F70 VA: 0x182528970
	internal void .ctor(LayoutDataAccess access, LayoutHandle handle) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public LayoutHandle get_Handle() { }

	// RVA: 0x2528990 Offset: 0x2526F90 VA: 0x182528990
	public ref float get_PointScaleFactor() { }
}

// Namespace: UnityEngine.UIElements.Layout
[IsReadOnly]
internal struct LayoutHandle // TypeDefIndex: 4462
{
	// Fields
	public readonly int Index; // 0x0
	public readonly int Version; // 0x4

	// Properties
	public static LayoutHandle Undefined { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static LayoutHandle get_Undefined() { }

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	internal void .ctor(int index, int version) { }

	// RVA: 0x2313C60 Offset: 0x2312260 VA: 0x182313C60
	public bool Equals(LayoutHandle other) { }

	// RVA: 0x252A3D0 Offset: 0x25289D0 VA: 0x18252A3D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24A8DF0 Offset: 0x24A73F0 VA: 0x1824A8DF0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements.Layout
[RequiredByNativeCode]
internal enum LayoutNodeDataType // TypeDefIndex: 4463
{
	// Fields
	public int value__; // 0x0
	public const LayoutNodeDataType Node = 0;
	public const LayoutNodeDataType Style = 1;
	public const LayoutNodeDataType Computed = 2;
	public const LayoutNodeDataType Cache = 3;
	public const LayoutNodeDataType StyleDimensions = 4;
	public const LayoutNodeDataType StyleMargin = 5;
	public const LayoutNodeDataType StyleBorder = 6;
}

// Namespace: UnityEngine.UIElements.Layout
[RequiredByNativeCode]
internal enum LayoutConfigDataType // TypeDefIndex: 4464
{
	// Fields
	public int value__; // 0x0
	public const LayoutConfigDataType Config = 0;
}

// Namespace: UnityEngine.UIElements.Layout
internal sealed class LayoutMeasureFunction : MulticastDelegate // TypeDefIndex: 4465
{
	// Methods

	// RVA: 0x252C1F0 Offset: 0x252A7F0 VA: 0x18252C1F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x252C1D0 Offset: 0x252A7D0 VA: 0x18252C1D0 Slot: 13
	public virtual void Invoke(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal sealed class LayoutBaselineFunction : MulticastDelegate // TypeDefIndex: 4466
{
	// Methods

	// RVA: 0x2528460 Offset: 0x2526A60 VA: 0x182528460
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2528440 Offset: 0x2526A40 VA: 0x182528440 Slot: 13
	public virtual float Invoke(ref LayoutNode node, float width, float height) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal class ManagedObjectStore<T> // TypeDefIndex: 4467
{
	// Fields
	private int m_Length; // 0x0
	private readonly List<T[]> m_Chunks; // 0x0
	private readonly Queue<int> m_Free; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128B080 Offset: 0x1289680 VA: 0x18128B080
	|-ManagedObjectStore<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T GetValue(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128AD40 Offset: 0x1289340 VA: 0x18128AD40
	|-ManagedObjectStore<object>.GetValue
	*/

	// RVA: -1 Offset: -1
	public void UpdateValue(ref int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128ADC0 Offset: 0x12893C0 VA: 0x18128ADC0
	|-ManagedObjectStore<object>.UpdateValue
	*/
}

// Namespace: UnityEngine.UIElements.Layout
internal class LayoutManager : IDisposable // TypeDefIndex: 4469
{
	// Fields
	private static bool s_Initialized; // 0x0
	private static bool s_AppDomainUnloadRegistered; // 0x1
	private static LayoutManager s_SharedInstance; // 0x8
	private static readonly List<LayoutManager> s_Managers; // 0x10
	private readonly int m_Index; // 0x10
	private LayoutDataStore m_Nodes; // 0x18
	private LayoutDataStore m_Configs; // 0x28
	private readonly object m_SyncRoot; // 0x38
	private readonly Stack<LayoutHandle> m_NodesToFree; // 0x40
	private readonly LayoutHandle m_DefaultConfig; // 0x48
	private readonly ManagedObjectStore<LayoutMeasureFunction> m_ManagedMeasureFunctions; // 0x50
	private readonly ManagedObjectStore<LayoutBaselineFunction> m_ManagedBaselineFunctions; // 0x58
	private readonly ManagedObjectStore<WeakReference<VisualElement>> m_ManagedOwners; // 0x60
	private int m_HighMark; // 0x68

	// Properties
	public static LayoutManager SharedManager { get; }

	// Methods

	// RVA: 0x252C180 Offset: 0x252A780 VA: 0x18252C180
	public static LayoutManager get_SharedManager() { }

	// RVA: 0x252BC50 Offset: 0x252A250 VA: 0x18252BC50
	private static void .cctor() { }

	// RVA: 0x252B3D0 Offset: 0x25299D0 VA: 0x18252B3D0
	private static void Initialize() { }

	// RVA: 0x252B7D0 Offset: 0x2529DD0 VA: 0x18252B7D0
	private static void Shutdown() { }

	// RVA: 0x252B0E0 Offset: 0x25296E0 VA: 0x18252B0E0
	internal static LayoutManager GetManager(int index) { }

	// RVA: 0x252BCE0 Offset: 0x252A2E0 VA: 0x18252BCE0
	public void .ctor(Allocator allocator) { }

	// RVA: 0x252ACD0 Offset: 0x25292D0 VA: 0x18252ACD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x252AF70 Offset: 0x2529570 VA: 0x18252AF70
	private LayoutDataAccess GetAccess() { }

	// RVA: 0x252B080 Offset: 0x2529680 VA: 0x18252B080
	public LayoutConfig GetDefaultConfig() { }

	// RVA: 0x252A460 Offset: 0x2528A60 VA: 0x18252A460
	public LayoutConfig CreateConfig() { }

	// RVA: 0x252AA30 Offset: 0x2529030 VA: 0x18252AA30
	public void DestroyConfig(ref LayoutConfig config) { }

	// RVA: 0x252A9E0 Offset: 0x2528FE0 VA: 0x18252A9E0
	public LayoutNode CreateNode() { }

	// RVA: 0x252A550 Offset: 0x2528B50 VA: 0x18252A550
	private LayoutNode CreateNodeInternal(LayoutHandle configHandle) { }

	// RVA: 0x252B9D0 Offset: 0x2529FD0 VA: 0x18252B9D0
	private void TryFreeNodes() { }

	// RVA: 0x252AA90 Offset: 0x2529090 VA: 0x18252AA90
	public void DestroyNode(ref LayoutNode node) { }

	// RVA: 0x252AE40 Offset: 0x2529440 VA: 0x18252AE40
	private void FreeNode(LayoutHandle handle) { }

	// RVA: 0x252B1A0 Offset: 0x25297A0 VA: 0x18252B1A0
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	// RVA: 0x252B5F0 Offset: 0x2529BF0 VA: 0x18252B5F0
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	// RVA: 0x252B260 Offset: 0x2529860 VA: 0x18252B260
	public VisualElement GetOwner(LayoutHandle handle) { }

	// RVA: 0x252B6C0 Offset: 0x2529CC0 VA: 0x18252B6C0
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

	// RVA: 0x252AFC0 Offset: 0x25295C0 VA: 0x18252AFC0
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }
}

// Namespace: UnityEngine.UIElements.Layout
[DefaultMember("Item")]
internal struct LayoutNode : IEquatable<LayoutNode> // TypeDefIndex: 4470
{
	// Fields
	private const int k_DefaultChildCapacity = 4;
	private readonly LayoutDataAccess m_Access; // 0x0
	private readonly LayoutHandle m_Handle; // 0x28

	// Properties
	public float LayoutX { get; }
	public float LayoutY { get; }
	public float LayoutRight { get; }
	public float LayoutBottom { get; }
	public float LayoutWidth { get; }
	public float LayoutHeight { get; }
	public float LayoutMarginLeft { get; }
	public float LayoutMarginTop { get; }
	public float LayoutMarginRight { get; }
	public float LayoutMarginBottom { get; }
	public float LayoutPaddingLeft { get; }
	public float LayoutPaddingTop { get; }
	public float LayoutPaddingRight { get; }
	public float LayoutPaddingBottom { get; }
	public float LayoutBorderLeft { get; }
	public float LayoutBorderTop { get; }
	public float LayoutBorderRight { get; }
	public float LayoutBorderBottom { get; }
	public float ComputedFlexBasis { get; }
	public LayoutNode Parent { get; set; }
	private LayoutList<LayoutHandle> Children { get; }
	public int Count { get; }
	public LayoutFlexDirection FlexDirection { set; }
	public LayoutJustify JustifyContent { set; }
	public LayoutDisplay Display { set; }
	public LayoutAlign AlignItems { set; }
	public LayoutAlign AlignSelf { set; }
	public LayoutAlign AlignContent { set; }
	public LayoutPositionType PositionType { set; }
	public LayoutWrap Wrap { set; }
	public float FlexGrow { set; }
	public float FlexShrink { set; }
	public LayoutValue FlexBasis { set; }
	public LayoutValue Width { set; }
	public LayoutValue Height { set; }
	public LayoutValue MaxWidth { set; }
	public LayoutValue MaxHeight { set; }
	public LayoutValue MinWidth { set; }
	public LayoutValue MinHeight { set; }
	public LayoutOverflow Overflow { set; }
	public LayoutValue Left { set; }
	public LayoutValue Top { set; }
	public LayoutValue Right { set; }
	public LayoutValue Bottom { set; }
	public LayoutValue MarginLeft { set; }
	public LayoutValue MarginTop { set; }
	public LayoutValue MarginRight { set; }
	public LayoutValue MarginBottom { set; }
	public LayoutValue PaddingLeft { set; }
	public LayoutValue PaddingTop { set; }
	public LayoutValue PaddingRight { set; }
	public LayoutValue PaddingBottom { set; }
	public float BorderLeftWidth { set; }
	public float BorderTopWidth { set; }
	public float BorderRightWidth { set; }
	public float BorderBottomWidth { set; }
	public static LayoutNode Undefined { get; }
	public bool IsUndefined { get; }
	public LayoutHandle Handle { get; }
	public LayoutComputedData Layout { get; }
	public LayoutStyleData Style { get; }
	public LayoutStyleBorderData StyleBorders { get; }
	public LayoutStyleMarginData StyleMargins { get; }
	public LayoutStyleDimensionData StyleDimensions { get; }
	public bool IsDirty { get; set; }
	public bool HasNewLayout { get; set; }
	public bool IsMeasureDefined { get; }
	public LayoutMeasureFunction Measure { get; set; }
	public LayoutBaselineFunction Baseline { get; }
	public LayoutConfig Config { set; }

	// Methods

	// RVA: 0x252E180 Offset: 0x252C780 VA: 0x18252E180
	public float get_LayoutX() { }

	// RVA: 0x252E1A0 Offset: 0x252C7A0 VA: 0x18252E1A0
	public float get_LayoutY() { }

	// RVA: 0x252E140 Offset: 0x252C740 VA: 0x18252E140
	public float get_LayoutRight() { }

	// RVA: 0x252DF00 Offset: 0x252C500 VA: 0x18252DF00
	public float get_LayoutBottom() { }

	// RVA: 0x252E160 Offset: 0x252C760 VA: 0x18252E160
	public float get_LayoutWidth() { }

	// RVA: 0x252DF20 Offset: 0x252C520 VA: 0x18252DF20
	public float get_LayoutHeight() { }

	// RVA: 0x252DF60 Offset: 0x252C560 VA: 0x18252DF60
	public float get_LayoutMarginLeft() { }

	// RVA: 0x252E020 Offset: 0x252C620 VA: 0x18252E020
	public float get_LayoutMarginTop() { }

	// RVA: 0x252DFC0 Offset: 0x252C5C0 VA: 0x18252DFC0
	public float get_LayoutMarginRight() { }

	// RVA: 0x252DF40 Offset: 0x252C540 VA: 0x18252DF40
	public float get_LayoutMarginBottom() { }

	// RVA: 0x252E060 Offset: 0x252C660 VA: 0x18252E060
	public float get_LayoutPaddingLeft() { }

	// RVA: 0x252E120 Offset: 0x252C720 VA: 0x18252E120
	public float get_LayoutPaddingTop() { }

	// RVA: 0x252E0C0 Offset: 0x252C6C0 VA: 0x18252E0C0
	public float get_LayoutPaddingRight() { }

	// RVA: 0x252E040 Offset: 0x252C640 VA: 0x18252E040
	public float get_LayoutPaddingBottom() { }

	// RVA: 0x252DE20 Offset: 0x252C420 VA: 0x18252DE20
	public float get_LayoutBorderLeft() { }

	// RVA: 0x252DEE0 Offset: 0x252C4E0 VA: 0x18252DEE0
	public float get_LayoutBorderTop() { }

	// RVA: 0x252DE80 Offset: 0x252C480 VA: 0x18252DE80
	public float get_LayoutBorderRight() { }

	// RVA: 0x252DE00 Offset: 0x252C400 VA: 0x18252DE00
	public float get_LayoutBorderBottom() { }

	// RVA: 0x252DCD0 Offset: 0x252C2D0 VA: 0x18252DCD0
	public float get_ComputedFlexBasis() { }

	// RVA: 0x252CF00 Offset: 0x252B500 VA: 0x18252CF00
	private float GetLayoutValue(float* buffer, LayoutEdge edge) { }

	// RVA: 0x252E240 Offset: 0x252C840 VA: 0x18252E240
	public LayoutNode get_Parent() { }

	// RVA: 0x252EAE0 Offset: 0x252D0E0 VA: 0x18252EAE0
	public void set_Parent(LayoutNode value) { }

	// RVA: 0x252DCA0 Offset: 0x252C2A0 VA: 0x18252DCA0
	private LayoutList<LayoutHandle> get_Children() { }

	// RVA: 0x252DCF0 Offset: 0x252C2F0 VA: 0x18252DCF0
	public int get_Count() { }

	// RVA: 0x252CFD0 Offset: 0x252B5D0 VA: 0x18252CFD0
	public void Insert(int index, LayoutNode child) { }

	// RVA: 0x252D1F0 Offset: 0x252B7F0 VA: 0x18252D1F0
	public void RemoveAt(int index) { }

	// RVA: 0x252C570 Offset: 0x252AB70 VA: 0x18252C570
	public void Clear() { }

	// RVA: 0x252E630 Offset: 0x252CC30 VA: 0x18252E630
	public void set_FlexDirection(LayoutFlexDirection value) { }

	// RVA: 0x252E820 Offset: 0x252CE20 VA: 0x18252E820
	public void set_JustifyContent(LayoutJustify value) { }

	// RVA: 0x252E5A0 Offset: 0x252CBA0 VA: 0x18252E5A0
	public void set_Display(LayoutDisplay value) { }

	// RVA: 0x252E340 Offset: 0x252C940 VA: 0x18252E340
	public void set_AlignItems(LayoutAlign value) { }

	// RVA: 0x252E390 Offset: 0x252C990 VA: 0x18252E390
	public void set_AlignSelf(LayoutAlign value) { }

	// RVA: 0x252E2F0 Offset: 0x252C8F0 VA: 0x18252E2F0
	public void set_AlignContent(LayoutAlign value) { }

	// RVA: 0x252EB10 Offset: 0x252D110 VA: 0x18252EB10
	public void set_PositionType(LayoutPositionType value) { }

	// RVA: 0x252EBE0 Offset: 0x252D1E0 VA: 0x18252EBE0
	public void set_Wrap(LayoutWrap value) { }

	// RVA: 0x252E680 Offset: 0x252CC80 VA: 0x18252E680
	public void set_FlexGrow(float value) { }

	// RVA: 0x252E6E0 Offset: 0x252CCE0 VA: 0x18252E6E0
	public void set_FlexShrink(float value) { }

	// RVA: 0x252E5F0 Offset: 0x252CBF0 VA: 0x18252E5F0
	public void set_FlexBasis(LayoutValue value) { }

	// RVA: 0x252EB80 Offset: 0x252D180 VA: 0x18252EB80
	public void set_Width(LayoutValue value) { }

	// RVA: 0x252E780 Offset: 0x252CD80 VA: 0x18252E780
	public void set_Height(LayoutValue value) { }

	// RVA: 0x252E920 Offset: 0x252CF20 VA: 0x18252E920
	public void set_MaxWidth(LayoutValue value) { }

	// RVA: 0x252E8C0 Offset: 0x252CEC0 VA: 0x18252E8C0
	public void set_MaxHeight(LayoutValue value) { }

	// RVA: 0x252E9F0 Offset: 0x252CFF0 VA: 0x18252E9F0
	public void set_MinWidth(LayoutValue value) { }

	// RVA: 0x252E990 Offset: 0x252CF90 VA: 0x18252E990
	public void set_MinHeight(LayoutValue value) { }

	// RVA: 0x252EA50 Offset: 0x252D050 VA: 0x18252EA50
	public void set_Overflow(LayoutOverflow value) { }

	// RVA: 0x252E870 Offset: 0x252CE70 VA: 0x18252E870
	public void set_Left(LayoutValue value) { }

	// RVA: 0x252EB70 Offset: 0x252D170 VA: 0x18252EB70
	public void set_Top(LayoutValue value) { }

	// RVA: 0x252EB60 Offset: 0x252D160 VA: 0x18252EB60
	public void set_Right(LayoutValue value) { }

	// RVA: 0x252E560 Offset: 0x252CB60 VA: 0x18252E560
	public void set_Bottom(LayoutValue value) { }

	// RVA: 0x252E890 Offset: 0x252CE90 VA: 0x18252E890
	public void set_MarginLeft(LayoutValue value) { }

	// RVA: 0x252E8B0 Offset: 0x252CEB0 VA: 0x18252E8B0
	public void set_MarginTop(LayoutValue value) { }

	// RVA: 0x252E8A0 Offset: 0x252CEA0 VA: 0x18252E8A0
	public void set_MarginRight(LayoutValue value) { }

	// RVA: 0x252E880 Offset: 0x252CE80 VA: 0x18252E880
	public void set_MarginBottom(LayoutValue value) { }

	// RVA: 0x252EAB0 Offset: 0x252D0B0 VA: 0x18252EAB0
	public void set_PaddingLeft(LayoutValue value) { }

	// RVA: 0x252EAD0 Offset: 0x252D0D0 VA: 0x18252EAD0
	public void set_PaddingTop(LayoutValue value) { }

	// RVA: 0x252EAC0 Offset: 0x252D0C0 VA: 0x18252EAC0
	public void set_PaddingRight(LayoutValue value) { }

	// RVA: 0x252EAA0 Offset: 0x252D0A0 VA: 0x18252EAA0
	public void set_PaddingBottom(LayoutValue value) { }

	// RVA: 0x252E440 Offset: 0x252CA40 VA: 0x18252E440
	public void set_BorderLeftWidth(float value) { }

	// RVA: 0x252E500 Offset: 0x252CB00 VA: 0x18252E500
	public void set_BorderTopWidth(float value) { }

	// RVA: 0x252E4A0 Offset: 0x252CAA0 VA: 0x18252E4A0
	public void set_BorderRightWidth(float value) { }

	// RVA: 0x252E3E0 Offset: 0x252C9E0 VA: 0x18252E3E0
	public void set_BorderBottomWidth(float value) { }

	// RVA: 0x252DAD0 Offset: 0x252C0D0 VA: 0x18252DAD0
	private void SetValue(ref float currentValue, float newValue) { }

	// RVA: 0x252D990 Offset: 0x252BF90 VA: 0x18252D990
	private void SetStyleValue(ref LayoutValue currentValue, LayoutValue newValue) { }

	// RVA: 0x252D8F0 Offset: 0x252BEF0 VA: 0x18252D8F0
	private void SetStyleValueUnit(ref LayoutValue currentValue, LayoutValue newValue) { }

	// RVA: 0x252D840 Offset: 0x252BE40 VA: 0x18252D840
	private void SetStyleValuePoint(ref LayoutValue currentValue, LayoutValue newValue) { }

	// RVA: 0x252D7D0 Offset: 0x252BDD0 VA: 0x18252D7D0
	private void SetStyleValuePercent(ref LayoutValue currentValue, LayoutValue newValue) { }

	// RVA: 0x252D7A0 Offset: 0x252BDA0 VA: 0x18252D7A0
	private void SetStyleValueAuto(ref LayoutValue currentValue) { }

	// RVA: 0x252D670 Offset: 0x252BC70 VA: 0x18252D670
	private void SetStyleEdgePosition(LayoutEdge edge, LayoutValue value) { }

	// RVA: 0x252D390 Offset: 0x252B990 VA: 0x18252D390
	private void SetStyleEdgeMargin(LayoutEdge edge, LayoutValue value) { }

	// RVA: 0x252D540 Offset: 0x252BB40 VA: 0x18252D540
	private void SetStyleEdgePadding(LayoutEdge edge, LayoutValue value) { }

	// RVA: 0x252DB40 Offset: 0x252C140 VA: 0x18252DB40
	private void StyleEdgeSetPercent(ref LayoutValue value, float newValue) { }

	// RVA: 0x252D7A0 Offset: 0x252BDA0 VA: 0x18252D7A0
	private void StyleEdgeSetAuto(ref LayoutValue value) { }

	// RVA: 0x252DBB0 Offset: 0x252C1B0 VA: 0x18252DBB0
	private void StyleEdgeSetPoint(ref LayoutValue value, float newValue) { }

	// RVA: 0x25289A0 Offset: 0x2526FA0 VA: 0x1825289A0
	public static LayoutNode get_Undefined() { }

	// RVA: 0x2528970 Offset: 0x2526F70 VA: 0x182528970
	internal void .ctor(LayoutDataAccess access, LayoutHandle handle) { }

	// RVA: 0x252DDF0 Offset: 0x252C3F0 VA: 0x18252DDF0
	public bool get_IsUndefined() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public LayoutHandle get_Handle() { }

	// RVA: 0x252E1C0 Offset: 0x252C7C0 VA: 0x18252E1C0
	public ref LayoutComputedData get_Layout() { }

	// RVA: 0x252E2E0 Offset: 0x252C8E0 VA: 0x18252E2E0
	public ref LayoutStyleData get_Style() { }

	// RVA: 0x252E2B0 Offset: 0x252C8B0 VA: 0x18252E2B0
	public ref LayoutStyleBorderData get_StyleBorders() { }

	// RVA: 0x252E2D0 Offset: 0x252C8D0 VA: 0x18252E2D0
	public ref LayoutStyleMarginData get_StyleMargins() { }

	// RVA: 0x252E2C0 Offset: 0x252C8C0 VA: 0x18252E2C0
	public ref LayoutStyleDimensionData get_StyleDimensions() { }

	// RVA: 0x252DDB0 Offset: 0x252C3B0 VA: 0x18252DDB0
	public bool get_IsDirty() { }

	// RVA: 0x252E7E0 Offset: 0x252CDE0 VA: 0x18252E7E0
	public void set_IsDirty(bool value) { }

	// RVA: 0x252DD90 Offset: 0x252C390 VA: 0x18252DD90
	public bool get_HasNewLayout() { }

	// RVA: 0x252E740 Offset: 0x252CD40 VA: 0x18252E740
	public void set_HasNewLayout(bool value) { }

	// RVA: 0x252DDD0 Offset: 0x252C3D0 VA: 0x18252DDD0
	public bool get_IsMeasureDefined() { }

	// RVA: 0x252E1D0 Offset: 0x252C7D0 VA: 0x18252E1D0
	public LayoutMeasureFunction get_Measure() { }

	// RVA: 0x252E980 Offset: 0x252CF80 VA: 0x18252E980
	public void set_Measure(LayoutMeasureFunction value) { }

	// RVA: 0x252D380 Offset: 0x252B980 VA: 0x18252D380
	public void SetOwner(VisualElement func) { }

	// RVA: 0x252CF60 Offset: 0x252B560 VA: 0x18252CF60
	public VisualElement GetOwner() { }

	// RVA: 0x252DC30 Offset: 0x252C230 VA: 0x18252DC30
	public LayoutBaselineFunction get_Baseline() { }

	// RVA: 0x252E570 Offset: 0x252CB70 VA: 0x18252E570
	public void set_Config(LayoutConfig value) { }

	// RVA: 0x252D0D0 Offset: 0x252B6D0 VA: 0x18252D0D0
	public void MarkDirty() { }

	// RVA: 0x252D1D0 Offset: 0x252B7D0 VA: 0x18252D1D0
	public void MarkLayoutSeen() { }

	// RVA: 0x252C620 Offset: 0x252AC20 VA: 0x18252C620
	public void CopyFromComputedStyle(ComputedStyle style) { }

	// RVA: 0x252DB20 Offset: 0x252C120 VA: 0x18252DB20
	public void SoftReset() { }

	// RVA: 0x252CE10 Offset: 0x252B410 VA: 0x18252CE10 Slot: 4
	public bool Equals(LayoutNode other) { }

	// RVA: 0x252CE50 Offset: 0x252B450 VA: 0x18252CE50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x252CEF0 Offset: 0x252B4F0 VA: 0x18252CEF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x252C3D0 Offset: 0x252A9D0 VA: 0x18252C3D0
	public void CalculateLayout(float width = NaN, float height = NaN) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal interface ILayoutProcessor // TypeDefIndex: 4471
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayout(LayoutNode node, float parentWidth, float parentHeight, LayoutDirection parentDirection);
}

// Namespace: UnityEngine.UIElements.Layout
internal static class LayoutProcessor // TypeDefIndex: 4472
{
	// Fields
	private static ILayoutProcessor s_Processor; // 0x0

	// Methods

	// RVA: 0x252ED50 Offset: 0x252D350 VA: 0x18252ED50
	public static void CalculateLayout(LayoutNode node, float parentWidth, float parentHeight, LayoutDirection parentDirection) { }

	// RVA: 0x252EE90 Offset: 0x252D490 VA: 0x18252EE90
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
[UnmanagedFunctionPointer(2)]
internal sealed class InvokeMeasureFunctionDelegate : MulticastDelegate // TypeDefIndex: 4473
{
	// Methods

	// RVA: 0x2528540 Offset: 0x2526B40 VA: 0x182528540
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2528520 Offset: 0x2526B20 VA: 0x182528520 Slot: 13
	public virtual void Invoke(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result) { }
}

// Namespace: UnityEngine.UIElements.Layout
[UnmanagedFunctionPointer(2)]
internal sealed class InvokeBaselineFunctionDelegate : MulticastDelegate // TypeDefIndex: 4474
{
	// Methods

	// RVA: 0x2528460 Offset: 0x2526A60 VA: 0x182528460
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2528440 Offset: 0x2526A40 VA: 0x182528440 Slot: 13
	public virtual float Invoke(ref LayoutNode node, float width, float height) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal static class LayoutDelegates // TypeDefIndex: 4475
{
	// Fields
	private static readonly ProfilerMarker s_InvokeMeasureFunctionMarker; // 0x0
	private static readonly ProfilerMarker s_InvokeBaselineFunctionMarker; // 0x8
	private static readonly InvokeMeasureFunctionDelegate s_InvokeMeasureDelegate; // 0x10
	private static readonly InvokeBaselineFunctionDelegate s_InvokeBaselineDelegate; // 0x18
	internal static readonly IntPtr s_InvokeMeasureFunction; // 0x20
	internal static readonly IntPtr s_InvokeBaselineFunction; // 0x28

	// Methods

	[MonoPInvokeCallback(typeof(InvokeMeasureFunctionDelegate))]
	// RVA: 0x2529F00 Offset: 0x2528500 VA: 0x182529F00
	private static void InvokeMeasureFunction(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result) { }

	[MonoPInvokeCallback(typeof(InvokeBaselineFunctionDelegate))]
	// RVA: 0x2529DB0 Offset: 0x25283B0 VA: 0x182529DB0
	private static float InvokeBaselineFunction(ref LayoutNode node, float width, float height) { }

	// RVA: 0x252A0B0 Offset: 0x25286B0 VA: 0x18252A0B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutCacheData // TypeDefIndex: 4476
{
	// Fields
	public static LayoutCacheData Default; // 0x0
	public uint NextCachedMeasurementsIndex; // 0x0
	public FixedBuffer16<LayoutCachedMeasurement> cachedMeasurements; // 0x4
	public LayoutCachedMeasurement CachedLayout; // 0x204

	// Methods

	// RVA: 0x2528600 Offset: 0x2526C00 VA: 0x182528600
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutCachedMeasurement // TypeDefIndex: 4477
{
	// Fields
	public static LayoutCachedMeasurement Default; // 0x0
	public float AvailableWidth; // 0x0
	public float AvailableHeight; // 0x4
	public float ParentWidth; // 0x8
	public float ParentHeight; // 0xC
	public LayoutMeasureMode WidthMeasureMode; // 0x10
	public LayoutMeasureMode HeightMeasureMode; // 0x14
	public float ComputedWidth; // 0x18
	public float ComputedHeight; // 0x1C

	// Methods

	// RVA: 0x2528710 Offset: 0x2526D10 VA: 0x182528710
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutComputedData // TypeDefIndex: 4484
{
	// Fields
	[FixedBuffer(typeof(float), 4)]
	public LayoutComputedData.<Position>e__FixedBuffer Position; // 0x0
	[FixedBuffer(typeof(float), 2)]
	public LayoutComputedData.<Dimensions>e__FixedBuffer Dimensions; // 0x10
	[FixedBuffer(typeof(float), 6)]
	public LayoutComputedData.<Margin>e__FixedBuffer Margin; // 0x18
	[FixedBuffer(typeof(float), 6)]
	public LayoutComputedData.<Border>e__FixedBuffer Border; // 0x30
	[FixedBuffer(typeof(float), 6)]
	public LayoutComputedData.<Padding>e__FixedBuffer Padding; // 0x48
	public LayoutDirection Direction; // 0x60
	public uint ComputedFlexBasisGeneration; // 0x64
	public float ComputedFlexBasis; // 0x68
	public bool HadOverflow; // 0x6C
	public uint GenerationCount; // 0x70
	public LayoutDirection LastParentDirection; // 0x74
	public float LastPointScaleFactor; // 0x78
	[FixedBuffer(typeof(float), 2)]
	public LayoutComputedData.<MeasuredDimensions>e__FixedBuffer MeasuredDimensions; // 0x7C

	// Properties
	public static LayoutComputedData Default { get; }
	public float* MarginBuffer { get; }
	public float* BorderBuffer { get; }
	public float* PaddingBuffer { get; }

	// Methods

	// RVA: 0x2528780 Offset: 0x2526D80 VA: 0x182528780
	public static LayoutComputedData get_Default() { }

	// RVA: 0x2528940 Offset: 0x2526F40 VA: 0x182528940
	public float* get_MarginBuffer() { }

	// RVA: 0x2528770 Offset: 0x2526D70 VA: 0x182528770
	public float* get_BorderBuffer() { }

	// RVA: 0x2528950 Offset: 0x2526F50 VA: 0x182528950
	public float* get_PaddingBuffer() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutConfigData // TypeDefIndex: 4485
{
	// Fields
	public float PointScaleFactor; // 0x0

	// Properties
	public static LayoutConfigData Default { get; }

	// Methods

	// RVA: 0x2528960 Offset: 0x2526F60 VA: 0x182528960
	public static LayoutConfigData get_Default() { }
}

// Namespace: UnityEngine.UIElements.Layout
[IsReadOnly]
[RequiredByNativeCode]
internal struct LayoutDataAccess // TypeDefIndex: 4486
{
	// Fields
	private readonly int m_Manager; // 0x0
	private readonly LayoutDataStore m_Nodes; // 0x8
	private readonly LayoutDataStore m_Configs; // 0x18

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x2528FC0 Offset: 0x25275C0 VA: 0x182528FC0
	public bool get_IsValid() { }

	// RVA: 0x2528FA0 Offset: 0x25275A0 VA: 0x182528FA0
	internal void .ctor(int manager, LayoutDataStore nodes, LayoutDataStore configs) { }

	// RVA: -1 Offset: -1
	private ref T GetTypedNodeDataRef<T>(LayoutHandle handle, LayoutNodeDataType type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x715520 Offset: 0x713B20 VA: 0x180715520
	|-LayoutDataAccess.GetTypedNodeDataRef<LayoutComputedData>
	|-LayoutDataAccess.GetTypedNodeDataRef<LayoutNodeData>
	|-LayoutDataAccess.GetTypedNodeDataRef<LayoutStyleBorderData>
	|-LayoutDataAccess.GetTypedNodeDataRef<LayoutStyleData>
	|-LayoutDataAccess.GetTypedNodeDataRef<LayoutStyleDimensionData>
	|-LayoutDataAccess.GetTypedNodeDataRef<LayoutStyleMarginData>
	|-LayoutDataAccess.GetTypedNodeDataRef<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private ref T GetTypedConfigDataRef<T>(LayoutHandle handle, LayoutConfigDataType type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7154F0 Offset: 0x713AF0 VA: 0x1807154F0
	|-LayoutDataAccess.GetTypedConfigDataRef<LayoutConfigData>
	|-LayoutDataAccess.GetTypedConfigDataRef<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2528BB0 Offset: 0x25271B0 VA: 0x182528BB0
	public ref LayoutNodeData GetNodeData(LayoutHandle handle) { }

	// RVA: 0x2528D20 Offset: 0x2527320 VA: 0x182528D20
	public ref LayoutStyleData GetStyleData(LayoutHandle handle) { }

	// RVA: 0x2528CA0 Offset: 0x25272A0 VA: 0x182528CA0
	public ref LayoutStyleBorderData GetStyleBorderData(LayoutHandle handle) { }

	// RVA: 0x2528E20 Offset: 0x2527420 VA: 0x182528E20
	public ref LayoutStyleMarginData GetStyleMarginData(LayoutHandle handle) { }

	// RVA: 0x2528DA0 Offset: 0x25273A0 VA: 0x182528DA0
	public ref LayoutStyleDimensionData GetStyleDimensionData(LayoutHandle handle) { }

	// RVA: 0x2528A40 Offset: 0x2527040 VA: 0x182528A40
	public ref LayoutComputedData GetComputedData(LayoutHandle handle) { }

	// RVA: 0x2528AC0 Offset: 0x25270C0 VA: 0x182528AC0
	public ref LayoutConfigData GetConfigData(LayoutHandle handle) { }

	// RVA: 0x2528B40 Offset: 0x2527140 VA: 0x182528B40
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	// RVA: 0x2528EA0 Offset: 0x25274A0 VA: 0x182528EA0
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	// RVA: 0x2528C30 Offset: 0x2527230 VA: 0x182528C30
	public VisualElement GetOwner(LayoutHandle handle) { }

	// RVA: 0x2528F20 Offset: 0x2527520 VA: 0x182528F20
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

	// RVA: 0x25289D0 Offset: 0x2526FD0 VA: 0x1825289D0
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct ComponentType // TypeDefIndex: 4487
{
	// Fields
	public int Size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static ComponentType Create<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9F30 Offset: 0x6B8530 VA: 0x1806B9F30
	|-ComponentType.Create<LayoutCacheData>
	|
	|-RVA: 0x6B9F50 Offset: 0x6B8550 VA: 0x1806B9F50
	|-ComponentType.Create<LayoutComputedData>
	|
	|-RVA: 0x6B9F70 Offset: 0x6B8570 VA: 0x1806B9F70
	|-ComponentType.Create<LayoutConfigData>
	|
	|-RVA: 0x6B9F90 Offset: 0x6B8590 VA: 0x1806B9F90
	|-ComponentType.Create<LayoutNodeData>
	|
	|-RVA: 0x6B9FB0 Offset: 0x6B85B0 VA: 0x1806B9FB0
	|-ComponentType.Create<LayoutStyleBorderData>
	|-ComponentType.Create<LayoutStyleMarginData>
	|
	|-RVA: 0x6B9FD0 Offset: 0x6B85D0 VA: 0x1806B9FD0
	|-ComponentType.Create<LayoutStyleData>
	|
	|-RVA: 0x6B9FF0 Offset: 0x6B85F0 VA: 0x1806B9FF0
	|-ComponentType.Create<LayoutStyleDimensionData>
	|
	|-RVA: 0x6B9F00 Offset: 0x6B8500 VA: 0x1806B9F00
	|-ComponentType.Create<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutDataStore : IDisposable // TypeDefIndex: 4491
{
	// Fields
	private const int k_ChunkSize = 32768;
	private readonly Allocator m_Allocator; // 0x0
	[NativeDisableUnsafePtrRestriction]
	private LayoutDataStore.Data* m_Data; // 0x8

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1111C40 Offset: 0x1110240 VA: 0x181111C40
	public bool get_IsValid() { }

	// RVA: 0x2529940 Offset: 0x2527F40 VA: 0x182529940
	public void .ctor(ComponentType[] components, int initialCapacity, Allocator allocator) { }

	// RVA: 0x2529250 Offset: 0x2527850 VA: 0x182529250 Slot: 4
	public void Dispose() { }

	// RVA: 0x2529390 Offset: 0x2527990 VA: 0x182529390
	public bool Exists(in LayoutHandle handle) { }

	[IsReadOnly]
	// RVA: 0x2529520 Offset: 0x2527B20 VA: 0x182529520
	internal void* GetComponentDataPtr(int index, int componentIndex) { }

	// RVA: 0x2528FF0 Offset: 0x25275F0 VA: 0x182528FF0
	private LayoutHandle Allocate(byte** data, int count) { }

	// RVA: 0x25293D0 Offset: 0x25279D0 VA: 0x1825293D0
	public void Free(in LayoutHandle handle) { }

	// RVA: 0x25298E0 Offset: 0x2527EE0 VA: 0x1825298E0
	private static void SetNextFreeIndex(LayoutDataStore.ComponentDataStore* ptr, int index, int value) { }

	// RVA: 0x2529580 Offset: 0x2527B80 VA: 0x182529580
	private static int GetNextFreeIndex(LayoutDataStore.ComponentDataStore* ptr, int index) { }

	// RVA: 0x25295D0 Offset: 0x2527BD0 VA: 0x1825295D0
	private void IncreaseCapacity() { }

	// RVA: 0x25296F0 Offset: 0x2527CF0 VA: 0x1825296F0
	private void ResizeCapacity(int capacity) { }

	// RVA: 0x2529610 Offset: 0x2527C10 VA: 0x182529610
	private static void* ResizeArray(void* fromPtr, long fromCount, long toCount, long size, int align, Allocator allocator) { }

	// RVA: -1 Offset: -1
	public LayoutHandle Allocate<T0>(in T0 component0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7155B0 Offset: 0x713BB0 VA: 0x1807155B0
	|-LayoutDataStore.Allocate<LayoutConfigData>
	|-LayoutDataStore.Allocate<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public LayoutHandle Allocate<T0, T1, T2, T3, T4, T5, T6>(in T0 component0, in T1 component1, in T2 component2, in T3 component3, in T4 component4, in T5 component5, in T6 component6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x715550 Offset: 0x713B50 VA: 0x180715550
	|-LayoutDataStore.Allocate<LayoutNodeData, LayoutStyleData, LayoutComputedData, LayoutCacheData, LayoutStyleDimensionData, LayoutStyleMarginData, LayoutStyleBorderData>
	|-LayoutDataStore.Allocate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutNodeData // TypeDefIndex: 4493
{
	// Fields
	public FixedBuffer2<LayoutValue> ResolvedDimensions; // 0x0
	private float TargetSize; // 0x10
	public int ManagedMeasureFunctionIndex; // 0x14
	public int ManagedBaselineFunctionIndex; // 0x18
	public int ManagedOwnerIndex; // 0x1C
	public int LineIndex; // 0x20
	public LayoutHandle Config; // 0x24
	public LayoutHandle Parent; // 0x2C
	public LayoutHandle NextChild; // 0x34
	public LayoutList<LayoutHandle> Children; // 0x40
	private LayoutNodeData.FlexStatus Status; // 0x50

	// Properties
	public bool HasNewLayout { get; set; }
	public bool IsDirty { get; set; }

	// Methods

	// RVA: 0x252C380 Offset: 0x252A980 VA: 0x18252C380
	public bool get_HasNewLayout() { }

	// RVA: 0x252C390 Offset: 0x252A990 VA: 0x18252C390
	public void set_HasNewLayout(bool value) { }

	// RVA: 0x13EEC00 Offset: 0x13ED200 VA: 0x1813EEC00
	public bool get_IsDirty() { }

	// RVA: 0x252C3B0 Offset: 0x252A9B0 VA: 0x18252C3B0
	public void set_IsDirty(bool value) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutStyleData // TypeDefIndex: 4494
{
	// Fields
	public static LayoutStyleData Default; // 0x0
	public LayoutDirection Direction; // 0x0
	public LayoutFlexDirection FlexDirection; // 0x4
	public LayoutJustify JustifyContent; // 0x8
	public LayoutAlign AlignContent; // 0xC
	public LayoutAlign AlignItems; // 0x10
	public LayoutAlign AlignSelf; // 0x14
	public LayoutPositionType PositionType; // 0x18
	public float AspectRatio; // 0x1C
	public LayoutWrap FlexWrap; // 0x20
	public LayoutOverflow Overflow; // 0x24
	public LayoutDisplay Display; // 0x28
	public float FlexGrow; // 0x2C
	public float FlexShrink; // 0x30
	public LayoutValue FlexBasis; // 0x34

	// Methods

	// RVA: 0x252F120 Offset: 0x252D720 VA: 0x18252F120
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutStyleBorderData // TypeDefIndex: 4495
{
	// Fields
	public static LayoutStyleBorderData Default; // 0x0
	public FixedBuffer9<LayoutValue> border; // 0x0
	public FixedBuffer9<LayoutValue> position; // 0x48

	// Methods

	// RVA: 0x252EFF0 Offset: 0x252D5F0 VA: 0x18252EFF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutStyleMarginData // TypeDefIndex: 4496
{
	// Fields
	public static LayoutStyleMarginData Default; // 0x0
	public FixedBuffer9<LayoutValue> margin; // 0x0
	public FixedBuffer9<LayoutValue> padding; // 0x48

	// Methods

	// RVA: 0x252F250 Offset: 0x252D850 VA: 0x18252F250
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutStyleDimensionData // TypeDefIndex: 4497
{
	// Fields
	public static LayoutStyleDimensionData Default; // 0x0
	public FixedBuffer2<LayoutValue> maxDimensions; // 0x0
	public FixedBuffer2<LayoutValue> minDimensions; // 0x10
	public FixedBuffer2<LayoutValue> dimensions; // 0x20

	// Methods

	// RVA: 0x252F1D0 Offset: 0x252D7D0 VA: 0x18252F1D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
[DefaultMember("Item")]
internal struct FixedBuffer2<T> // TypeDefIndex: 4498
{
	// Fields
	private T __0; // 0x0
	private T __1; // 0x0

	// Properties
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D7B0 Offset: 0x100BDB0 VA: 0x18100D7B0
	|-FixedBuffer2<LayoutValue>.get_Item
	|
	|-RVA: 0x100D820 Offset: 0x100BE20 VA: 0x18100D820
	|-FixedBuffer2<__Il2CppFullySharedGenericStructType>.get_Item
	*/
}

// Namespace: UnityEngine.UIElements.Layout
[DefaultMember("Item")]
internal struct FixedBuffer9<T> // TypeDefIndex: 4499
{
	// Fields
	private T __0; // 0x0
	private T __1; // 0x0
	private T __2; // 0x0
	private T __3; // 0x0
	private T __4; // 0x0
	private T __5; // 0x0
	private T __6; // 0x0
	private T __7; // 0x0
	private T __8; // 0x0

	// Properties
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D960 Offset: 0x100BF60 VA: 0x18100D960
	|-FixedBuffer9<LayoutValue>.get_Item
	|
	|-RVA: 0x100D8C0 Offset: 0x100BEC0 VA: 0x18100D8C0
	|-FixedBuffer9<__Il2CppFullySharedGenericStructType>.get_Item
	*/
}

// Namespace: UnityEngine.UIElements.Layout
[DefaultMember("Item")]
internal struct FixedBuffer16<T> // TypeDefIndex: 4500
{
	// Fields
	private T __0; // 0x0
	private T __1; // 0x0
	private T __2; // 0x0
	private T __3; // 0x0
	private T __4; // 0x0
	private T __5; // 0x0
	private T __6; // 0x0
	private T __7; // 0x0
	private T __8; // 0x0
	private T __9; // 0x0
	private T _10; // 0x0
	private T _11; // 0x0
	private T _12; // 0x0
	private T _13; // 0x0
	private T _14; // 0x0
	private T _15; // 0x0
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutAlign // TypeDefIndex: 4501
{
	// Fields
	public int value__; // 0x0
	public const LayoutAlign Auto = 0;
	public const LayoutAlign FlexStart = 1;
	public const LayoutAlign Center = 2;
	public const LayoutAlign FlexEnd = 3;
	public const LayoutAlign Stretch = 4;
	public const LayoutAlign Baseline = 5;
	public const LayoutAlign SpaceBetween = 6;
	public const LayoutAlign SpaceAround = 7;
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutDefaults // TypeDefIndex: 4502
{
	// Fields
	public static readonly FixedBuffer9<LayoutValue> EdgeValuesUnit; // 0x0
	public static readonly float[] DimensionValues; // 0x48
	public static readonly FixedBuffer2<LayoutValue> DimensionValuesUnit; // 0x50
	public static readonly FixedBuffer2<LayoutValue> DimensionValuesAutoUnit; // 0x60

	// Methods

	// RVA: 0x2529B90 Offset: 0x2528190 VA: 0x182529B90
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutDirection // TypeDefIndex: 4503
{
	// Fields
	public int value__; // 0x0
	public const LayoutDirection Inherit = 0;
	public const LayoutDirection LTR = 1;
	public const LayoutDirection RTL = 2;
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutDisplay // TypeDefIndex: 4504
{
	// Fields
	public int value__; // 0x0
	public const LayoutDisplay Flex = 0;
	public const LayoutDisplay None = 1;
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutEdge // TypeDefIndex: 4505
{
	// Fields
	public int value__; // 0x0
	public const LayoutEdge Left = 0;
	public const LayoutEdge Top = 1;
	public const LayoutEdge Right = 2;
	public const LayoutEdge Bottom = 3;
	public const LayoutEdge Start = 4;
	public const LayoutEdge End = 5;
	public const LayoutEdge Horizontal = 6;
	public const LayoutEdge Vertical = 7;
	public const LayoutEdge All = 8;
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutFlexDirection // TypeDefIndex: 4506
{
	// Fields
	public int value__; // 0x0
	public const LayoutFlexDirection Column = 0;
	public const LayoutFlexDirection ColumnReverse = 1;
	public const LayoutFlexDirection Row = 2;
	public const LayoutFlexDirection RowReverse = 3;
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutJustify // TypeDefIndex: 4507
{
	// Fields
	public int value__; // 0x0
	public const LayoutJustify FlexStart = 0;
	public const LayoutJustify Center = 1;
	public const LayoutJustify FlexEnd = 2;
	public const LayoutJustify SpaceBetween = 3;
	public const LayoutJustify SpaceAround = 4;
	public const LayoutJustify SpaceEvenly = 5;
}

// Namespace: UnityEngine.UIElements.Layout
[DefaultMember("Item")]
internal struct LayoutList<T> : IDisposable // TypeDefIndex: 4509
{
	// Fields
	private readonly Allocator m_Allocator; // 0x0
	private LayoutList.Data<T>* m_Data; // 0x0

	// Properties
	public int Count { get; }
	public bool IsCreated { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111C20 Offset: 0x1110220 VA: 0x181111C20
	|-LayoutList<LayoutHandle>.get_Count
	|-LayoutList<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111C40 Offset: 0x1110240 VA: 0x181111C40
	|-LayoutList<LayoutHandle>.get_IsCreated
	|-LayoutList<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111D00 Offset: 0x1110300 VA: 0x181111D00
	|-LayoutList<LayoutHandle>.get_Item
	|
	|-RVA: 0x1111C50 Offset: 0x1110250 VA: 0x181111C50
	|-LayoutList<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111A80 Offset: 0x1110080 VA: 0x181111A80
	|-LayoutList<LayoutHandle>..ctor
	|-LayoutList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111990 Offset: 0x110FF90 VA: 0x181111990
	|-LayoutList<LayoutHandle>..ctor
	|
	|-RVA: 0x1111A90 Offset: 0x1110090 VA: 0x181111A90
	|-LayoutList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110C90 Offset: 0x110F290 VA: 0x181110C90
	|-LayoutList<LayoutHandle>.Dispose
	|-LayoutList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110EF0 Offset: 0x110F4F0 VA: 0x181110EF0
	|-LayoutList<LayoutHandle>.Insert
	|
	|-RVA: 0x1111020 Offset: 0x110F620 VA: 0x181111020
	|-LayoutList<__Il2CppFullySharedGenericStructType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11113E0 Offset: 0x110F9E0 VA: 0x1811113E0
	|-LayoutList<LayoutHandle>.RemoveAt
	|
	|-RVA: 0x1111270 Offset: 0x110F870 VA: 0x181111270
	|-LayoutList<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void IncreaseCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110DD0 Offset: 0x110F3D0 VA: 0x181110DD0
	|-LayoutList<LayoutHandle>.IncreaseCapacity
	|
	|-RVA: 0x1110E60 Offset: 0x110F460 VA: 0x181110E60
	|-LayoutList<__Il2CppFullySharedGenericStructType>.IncreaseCapacity
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110CE0 Offset: 0x110F2E0 VA: 0x181110CE0
	|-LayoutList<LayoutHandle>.EnsureCapacity
	|
	|-RVA: 0x1110D40 Offset: 0x110F340 VA: 0x181110D40
	|-LayoutList<__Il2CppFullySharedGenericStructType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private void ResizeCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111810 Offset: 0x110FE10 VA: 0x181111810
	|-LayoutList<LayoutHandle>.ResizeCapacity
	|
	|-RVA: 0x11116A0 Offset: 0x110FCA0 VA: 0x1811116A0
	|-LayoutList<__Il2CppFullySharedGenericStructType>.ResizeCapacity
	*/

	// RVA: -1 Offset: -1
	private static void* ResizeArray(void* fromPtr, long fromCount, long toCount, long size, int align, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11114E0 Offset: 0x110FAE0 VA: 0x1811114E0
	|-LayoutList<LayoutHandle>.ResizeArray
	|
	|-RVA: 0x11115C0 Offset: 0x110FBC0 VA: 0x1811115C0
	|-LayoutList<__Il2CppFullySharedGenericStructType>.ResizeArray
	*/
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutMeasureMode // TypeDefIndex: 4510
{
	// Fields
	public int value__; // 0x0
	public const LayoutMeasureMode Undefined = 0;
	public const LayoutMeasureMode Exactly = 1;
	public const LayoutMeasureMode AtMost = 2;
	public const LayoutMeasureMode Invalid = -1;
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutOverflow // TypeDefIndex: 4511
{
	// Fields
	public int value__; // 0x0
	public const LayoutOverflow Visible = 0;
	public const LayoutOverflow Hidden = 1;
	public const LayoutOverflow Scroll = 2;
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutPositionType // TypeDefIndex: 4512
{
	// Fields
	public int value__; // 0x0
	public const LayoutPositionType Relative = 0;
	public const LayoutPositionType Absolute = 1;
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutSize // TypeDefIndex: 4513
{
	// Fields
	public float width; // 0x0
	public float height; // 0x4

	// Methods

	// RVA: 0xB1E9A0 Offset: 0xB1CFA0 VA: 0x180B1E9A0
	public void .ctor(float width, float height) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutUnit // TypeDefIndex: 4514
{
	// Fields
	public int value__; // 0x0
	public const LayoutUnit Undefined = 0;
	public const LayoutUnit Point = 1;
	public const LayoutUnit Percent = 2;
	public const LayoutUnit Auto = 3;
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutValue // TypeDefIndex: 4515
{
	// Fields
	private float value; // 0x0
	private LayoutUnit unit; // 0x4

	// Properties
	public LayoutUnit Unit { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public LayoutUnit get_Unit() { }

	// RVA: 0x3A4AA0 Offset: 0x3A30A0 VA: 0x1803A4AA0
	public float get_Value() { }

	// RVA: 0x252F550 Offset: 0x252DB50 VA: 0x18252F550
	public static LayoutValue Point(float value) { }

	// RVA: 0x252F490 Offset: 0x252DA90 VA: 0x18252F490
	public bool Equals(LayoutValue other) { }

	// RVA: 0x252F3A0 Offset: 0x252D9A0 VA: 0x18252F3A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x252F4F0 Offset: 0x252DAF0 VA: 0x18252F4F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x252F580 Offset: 0x252DB80 VA: 0x18252F580
	public static LayoutValue Undefined() { }

	// RVA: 0x252F380 Offset: 0x252D980 VA: 0x18252F380
	public static LayoutValue Auto() { }

	// RVA: 0x252F520 Offset: 0x252DB20 VA: 0x18252F520
	public static LayoutValue Percent(float value) { }

	// RVA: 0x252F550 Offset: 0x252DB50 VA: 0x18252F550
	public static LayoutValue op_Implicit(float value) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal enum LayoutWrap // TypeDefIndex: 4516
{
	// Fields
	public int value__; // 0x0
	public const LayoutWrap NoWrap = 0;
	public const LayoutWrap Wrap = 1;
	public const LayoutWrap WrapReverse = 2;
}

// Namespace: UnityEngine.UIElements.Layout
[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutNative.h")]
internal static class LayoutNative // TypeDefIndex: 4517
{
	// Methods

	[NativeMethod(IsThreadSafe = False)]
	// RVA: 0x252C310 Offset: 0x252A910 VA: 0x18252C310
	internal static void CalculateLayout(IntPtr node, float parentWidth, float parentHeight, int parentDirection, IntPtr state) { }
}

// Namespace: UnityEngine.UIElements.Layout
internal struct LayoutState // TypeDefIndex: 4518
{
	// Fields
	public IntPtr measureFunctionCallback; // 0x0
	public IntPtr baselineFunctionCallback; // 0x8
	public uint depth; // 0x10
	public uint currentGenerationCount; // 0x14
	public bool error; // 0x18

	// Properties
	public static LayoutState Default { get; }

	// Methods

	// RVA: 0x252EF80 Offset: 0x252D580 VA: 0x18252EF80
	public static LayoutState get_Default() { }
}

// Namespace: UnityEngine.UIElements.Layout
internal class LayoutProcessorNative : ILayoutProcessor // TypeDefIndex: 4519
{
	// Fields
	private LayoutState m_State; // 0x10

	// Methods

	// RVA: 0x252EC30 Offset: 0x252D230 VA: 0x18252EC30 Slot: 4
	private void UnityEngine.UIElements.Layout.ILayoutProcessor.CalculateLayout(LayoutNode node, float parentWidth, float parentHeight, LayoutDirection parentDirection) { }

	// RVA: 0x252ECC0 Offset: 0x252D2C0 VA: 0x18252ECC0
	public void .ctor() { }
}

