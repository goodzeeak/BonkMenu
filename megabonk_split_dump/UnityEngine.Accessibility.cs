// Namespace: UnityEngine.Accessibility
[RequiredByNativeCode]
[NativeHeader("Modules/Accessibility/Native/AccessibilityAction.h")]
internal sealed class AccessibilityAction : IDisposable // TypeDefIndex: 14032
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<bool> <activated>k__BackingField; // 0x18

	// Properties
	public Func<bool> activated { get; }

	// Methods

	// RVA: 0x22D4830 Offset: 0x22D2E30 VA: 0x1822D4830 Slot: 4
	public void Dispose() { }

	// RVA: 0x22D47E0 Offset: 0x22D2DE0 VA: 0x1822D47E0
	private void Dispose(bool disposing) { }

	// RVA: 0x22D48C0 Offset: 0x22D2EC0 VA: 0x1822D48C0
	private static void Internal_Destroy(IntPtr ptr) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Func<bool> get_activated() { }

	[RequiredByNativeCode]
	// RVA: 0x22D4900 Offset: 0x22D2F00 VA: 0x1822D4900
	private bool Internal_InvokeActivated() { }
}

// Namespace: UnityEngine.Accessibility
[VisibleToOtherModules(new[] { "UnityEditor.AccessibilityModule" })]
[NativeHeader("Modules/Accessibility/Native/AccessibilityManager.h")]
internal static class AccessibilityManager // TypeDefIndex: 14035
{
	// Fields
	private static Queue<AccessibilityManager.NotificationContext> s_AsyncNotificationContexts; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> screenReaderStatusChanged; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<AccessibilityNode> nodeFocusChanged; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x22D6030 Offset: 0x22D4630 VA: 0x1822D6030
	public static void add_screenReaderStatusChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x22D6250 Offset: 0x22D4850 VA: 0x1822D6250
	public static void remove_screenReaderStatusChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x22D5F20 Offset: 0x22D4520 VA: 0x1822D5F20
	public static void add_nodeFocusChanged(Action<AccessibilityNode> value) { }

	[CompilerGenerated]
	// RVA: 0x22D6140 Offset: 0x22D4740 VA: 0x1822D6140
	public static void remove_nodeFocusChanged(Action<AccessibilityNode> value) { }

	// RVA: 0x22D5C50 Offset: 0x22D4250 VA: 0x1822D5C50
	internal static bool IsScreenReaderEnabled() { }

	// RVA: 0x22D5E20 Offset: 0x22D4420 VA: 0x1822D5E20
	internal static void SendAccessibilityNotification(in AccessibilityNotificationContext context) { }

	[VisibleToOtherModules(new[] { "UnityEditor.AccessibilityModule" })]
	[RequiredByNativeCode]
	// RVA: 0x22D56C0 Offset: 0x22D3CC0 VA: 0x1822D56C0
	internal static void Internal_Initialize() { }

	[RequiredByNativeCode]
	// RVA: 0x22D57D0 Offset: 0x22D3DD0 VA: 0x1822D57D0
	private static void Internal_Update() { }

	[RequiredByNativeCode]
	// RVA: 0x22D5410 Offset: 0x22D3A10 VA: 0x1822D5410
	private static int[] Internal_GetRootNodeIds() { }

	[RequiredByNativeCode]
	// RVA: 0x22D5330 Offset: 0x22D3930 VA: 0x1822D5330
	internal static void Internal_GetNode(int id, ref AccessibilityNodeData nodeData) { }

	[RequiredByNativeCode]
	// RVA: 0x22D5210 Offset: 0x22D3810 VA: 0x1822D5210
	private static int Internal_GetNodeIdAt(float x, float y) { }

	[RequiredByNativeCode]
	// RVA: 0x22D5700 Offset: 0x22D3D00 VA: 0x1822D5700
	private static void Internal_OnAccessibilityNotificationReceived(ref AccessibilityNotificationContext context) { }

	// RVA: 0x22D5CB0 Offset: 0x22D42B0 VA: 0x1822D5CB0
	internal static void QueueNotification(AccessibilityManager.NotificationContext notification) { }

	// RVA: 0x22D5170 Offset: 0x22D3770 VA: 0x1822D5170
	internal static IDisposable GetExclusiveLock() { }

	[ThreadSafe]
	// RVA: 0x22D5C80 Offset: 0x22D4280 VA: 0x1822D5C80
	private static void Lock() { }

	[ThreadSafe]
	// RVA: 0x22D5E60 Offset: 0x22D4460 VA: 0x1822D5E60
	private static void Unlock() { }

	// RVA: 0x22D5E90 Offset: 0x22D4490 VA: 0x1822D5E90
	private static void .cctor() { }
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[Flags]
public enum AccessibilityRole // TypeDefIndex: 14036
{
	// Fields
	public ushort value__; // 0x0
	public const AccessibilityRole None = 0;
	public const AccessibilityRole Button = 1;
	public const AccessibilityRole Image = 2;
	public const AccessibilityRole StaticText = 4;
	public const AccessibilityRole SearchField = 8;
	public const AccessibilityRole KeyboardKey = 16;
	public const AccessibilityRole Header = 32;
	public const AccessibilityRole TabBar = 64;
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[Flags]
public enum AccessibilityState // TypeDefIndex: 14037
{
	// Fields
	public ushort value__; // 0x0
	public const AccessibilityState None = 0;
	public const AccessibilityState Disabled = 1;
	public const AccessibilityState Selected = 2;
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNodeData.bindings.h")]
[NativeType(1, "MonoAccessibilityNodeData")]
internal struct AccessibilityNodeData // TypeDefIndex: 14038
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isActive>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <label>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <value>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <hint>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AccessibilityRole <role>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <allowsDirectInteraction>k__BackingField; // 0x22
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AccessibilityState <state>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Rect <frame>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <parentId>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int[] <childIds>k__BackingField; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <isFocused>k__BackingField; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SystemLanguage <language>k__BackingField; // 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <implementsSelected>k__BackingField; // 0x50

	// Properties
	public int id { set; }
	public bool isActive { set; }
	public string label { set; }
	public string value { set; }
	public string hint { set; }
	public AccessibilityRole role { set; }
	public bool allowsDirectInteraction { set; }
	public AccessibilityState state { set; }
	public Rect frame { set; }
	public int parentId { set; }
	public int[] childIds { set; }
	internal SystemLanguage language { set; }
	public bool implementsSelected { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_id(int value) { }

	[CompilerGenerated]
	// RVA: 0x22D6360 Offset: 0x22D4960 VA: 0x1822D6360
	public void set_isActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	public void set_label(string value) { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_value(string value) { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_hint(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B31B0 Offset: 0x15B17B0 VA: 0x1815B31B0
	public void set_role(AccessibilityRole value) { }

	[CompilerGenerated]
	// RVA: 0x38E220 Offset: 0x38C820 VA: 0x18038E220
	public void set_allowsDirectInteraction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1641110 Offset: 0x163F710 VA: 0x181641110
	public void set_state(AccessibilityState value) { }

	[CompilerGenerated]
	// RVA: 0x14DAB40 Offset: 0x14D9140 VA: 0x1814DAB40
	public void set_frame(Rect value) { }

	[CompilerGenerated]
	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_parentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_childIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x9CC920 Offset: 0x9CAF20 VA: 0x1809CC920
	internal void set_language(SystemLanguage value) { }

	[CompilerGenerated]
	// RVA: 0x1031CD0 Offset: 0x10302D0 VA: 0x181031CD0
	public void set_implementsSelected(bool value) { }
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeManager.h")]
internal static class AccessibilityNodeManager // TypeDefIndex: 14039
{
	// Methods

	// RVA: 0x22D6370 Offset: 0x22D4970 VA: 0x1822D6370
	internal static void DestroyNativeNode(int id, int parentId) { }

	// RVA: 0x22D6820 Offset: 0x22D4E20 VA: 0x1822D6820
	internal static void SetFrame(int id, Rect frame) { }

	// RVA: 0x22D6710 Offset: 0x22D4D10 VA: 0x1822D6710
	internal static void SetChildren(int id, int[] childIds) { }

	// RVA: 0x22D6690 Offset: 0x22D4C90 VA: 0x1822D6690
	internal static void SetActions(int id, AccessibilityAction[] actions) { }

	[RequiredByNativeCode]
	// RVA: 0x22D65A0 Offset: 0x22D4BA0 VA: 0x1822D65A0
	internal static bool Internal_InvokeSelected(int id) { }

	[RequiredByNativeCode]
	// RVA: 0x22D63B0 Offset: 0x22D49B0 VA: 0x1822D63B0
	internal static void Internal_InvokeFocusChanged(int id, bool isNodeFocused) { }

	// RVA: 0x22D67E0 Offset: 0x22D4DE0 VA: 0x1822D67E0
	private static void SetFrame_Injected(int id, in Rect frame) { }

	// RVA: 0x22D66D0 Offset: 0x22D4CD0 VA: 0x1822D66D0
	private static void SetChildren_Injected(int id, ref ManagedSpanWrapper childIds) { }
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Native/AccessibilityNotificationContext.h")]
internal enum AccessibilityNotification // TypeDefIndex: 14040
{
	// Fields
	public int value__; // 0x0
	public const AccessibilityNotification None = 0;
	public const AccessibilityNotification Announcement = 1;
	public const AccessibilityNotification AnnouncementFinished = 2;
	public const AccessibilityNotification ScreenReaderStatusChanged = 3;
	public const AccessibilityNotification ScreenChanged = 4;
	public const AccessibilityNotification LayoutChanged = 5;
	public const AccessibilityNotification PageScrolled = 6;
	public const AccessibilityNotification ElementFocused = 7;
	public const AccessibilityNotification ElementUnfocused = 8;
}

// Namespace: UnityEngine.Accessibility
[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNotificationContext.bindings.h")]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNotificationContext.h")]
[NativeType(1, "MonoAccessibilityNotificationContext")]
[RequiredByNativeCode]
internal struct AccessibilityNotificationContext // TypeDefIndex: 14041
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AccessibilityNotification <notification>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <isScreenReaderEnabled>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <announcement>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <wasAnnouncementSuccessful>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <currentNodeId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <nextNodeId>k__BackingField; // 0x18

	// Properties
	public AccessibilityNotification notification { get; set; }
	public bool isScreenReaderEnabled { get; }
	public string announcement { get; }
	public bool wasAnnouncementSuccessful { get; }
	public int currentNodeId { get; }
	public int nextNodeId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public AccessibilityNotification get_notification() { }

	[CompilerGenerated]
	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_notification(AccessibilityNotification value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1105D60 Offset: 0x1104360 VA: 0x181105D60
	public bool get_isScreenReaderEnabled() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public string get_announcement() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_wasAnnouncementSuccessful() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_currentNodeId() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_nextNodeId() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_nextNodeId(int value) { }
}

// Namespace: UnityEngine.Accessibility
public static class AssistiveSupport // TypeDefIndex: 14043
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<AccessibilityNode> nodeFocusChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool> screenReaderStatusChanged; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <isScreenReaderEnabled>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly IAccessibilityNotificationDispatcher <notificationDispatcher>k__BackingField; // 0x18
	private static ServiceManager s_ServiceManager; // 0x20

	// Properties
	public static bool isScreenReaderEnabled { get; set; }
	public static IAccessibilityNotificationDispatcher notificationDispatcher { get; }
	public static AccessibilityHierarchy activeHierarchy { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x22D7DA0 Offset: 0x22D63A0 VA: 0x1822D7DA0
	public static bool get_isScreenReaderEnabled() { }

	[CompilerGenerated]
	// RVA: 0x22D7E40 Offset: 0x22D6440 VA: 0x1822D7E40
	private static void set_isScreenReaderEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22D7DF0 Offset: 0x22D63F0 VA: 0x1822D7DF0
	public static IAccessibilityNotificationDispatcher get_notificationDispatcher() { }

	// RVA: 0x22D7730 Offset: 0x22D5D30 VA: 0x1822D7730
	internal static void Initialize() { }

	// RVA: -1 Offset: -1
	internal static T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65F3E0 Offset: 0x65D9E0 VA: 0x18065F3E0
	|-AssistiveSupport.GetService<object>
	|
	|-RVA: 0x65F230 Offset: 0x65D830 VA: 0x18065F230
	|-AssistiveSupport.GetService<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22D7B60 Offset: 0x22D6160 VA: 0x1822D7B60
	private static void ScreenReaderStatusChanged(bool screenReaderEnabled) { }

	// RVA: 0x22D7AF0 Offset: 0x22D60F0 VA: 0x1822D7AF0
	private static void NodeFocusChanged(AccessibilityNode currentNode) { }

	// RVA: 0x22D7D40 Offset: 0x22D6340 VA: 0x1822D7D40
	public static AccessibilityHierarchy get_activeHierarchy() { }

	// RVA: 0x22D7CC0 Offset: 0x22D62C0 VA: 0x1822D7CC0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Accessibility
public class AccessibilityHierarchy // TypeDefIndex: 14044
{
	// Fields
	internal List<AccessibilityNode> m_RootNodes; // 0x10
	private readonly IDictionary<int, AccessibilityNode> m_Nodes; // 0x18

	// Methods

	// RVA: 0x22D4E30 Offset: 0x22D3430 VA: 0x1822D4E30
	public bool TryGetNode(int id, out AccessibilityNode node) { }

	// RVA: 0x22D4CF0 Offset: 0x22D32F0 VA: 0x1822D4CF0
	internal void FreeNative() { }

	// RVA: 0x22D4DF0 Offset: 0x22D33F0 VA: 0x1822D4DF0
	public bool TryGetNodeAt(float horizontalPosition, float verticalPosition, out AccessibilityNode node) { }

	[CompilerGenerated]
	// RVA: 0x22D4F00 Offset: 0x22D3500 VA: 0x1822D4F00
	internal static AccessibilityNode <TryGetNodeAt>g__FindNodeContainingPoint|27_0(IList<AccessibilityNode> nodes, Vector2 pos) { }
}

// Namespace: UnityEngine.Accessibility
public class AccessibilityNode // TypeDefIndex: 14046
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <id>k__BackingField; // 0x10
	private Func<Rect> m_FrameGetter; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<bool> selected; // 0x20
	private string m_Label; // 0x28
	private string m_Value; // 0x30
	private string m_Hint; // 0x38
	private bool m_IsActive; // 0x40
	private AccessibilityRole m_Role; // 0x42
	private bool m_AllowsDirectInteraction; // 0x44
	private AccessibilityState m_State; // 0x46
	private AccessibilityNode m_Parent; // 0x48
	private AccessibilityNode.ObservableList<AccessibilityNode> m_Children; // 0x50
	private AccessibilityNode.ObservableList<AccessibilityAction> m_Actions; // 0x58
	private Rect m_Frame; // 0x60
	private SystemLanguage m_Language; // 0x70
	private AccessibilityHierarchy m_Hierarchy; // 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<AccessibilityNode, bool> focusChanged; // 0x80

	// Properties
	public int id { get; }
	public string label { get; }
	public string value { get; }
	public string hint { get; }
	public bool isActive { get; }
	public AccessibilityRole role { get; }
	public bool allowsDirectInteraction { get; }
	public AccessibilityState state { get; }
	public AccessibilityNode parent { get; }
	internal IList<AccessibilityNode> childList { get; }
	public Rect frame { get; }
	public Func<Rect> frameGetter { get; }
	internal SystemLanguage language { get; }

	// Methods

	// RVA: 0x22D6E50 Offset: 0x22D5450 VA: 0x1822D6E50
	internal void FreeNative(bool freeChildren) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_id() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_label() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_value() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_hint() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_isActive() { }

	// RVA: 0x1ECA570 Offset: 0x1EC8B70 VA: 0x181ECA570
	public AccessibilityRole get_role() { }

	// RVA: 0x43C000 Offset: 0x43A600 VA: 0x18043C000
	public bool get_allowsDirectInteraction() { }

	// RVA: 0x22D7720 Offset: 0x22D5D20 VA: 0x1822D7720
	public AccessibilityState get_state() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public AccessibilityNode get_parent() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal IList<AccessibilityNode> get_childList() { }

	// RVA: 0x22D7580 Offset: 0x22D5B80 VA: 0x1822D7580
	public Rect get_frame() { }

	// RVA: 0x22D7490 Offset: 0x22D5A90 VA: 0x1822D7490
	private void SetFrame(Rect frame) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Func<Rect> get_frameGetter() { }

	// RVA: 0x22D69F0 Offset: 0x22D4FF0 VA: 0x1822D69F0
	internal void CalculateFrame() { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	internal SystemLanguage get_language() { }

	// RVA: 0x22D7210 Offset: 0x22D5810 VA: 0x1822D7210
	internal void GetNodeData(ref AccessibilityNodeData nodeData) { }

	// RVA: 0x22D6B10 Offset: 0x22D5110 VA: 0x1822D6B10
	private void ChildrenChanged() { }

	// RVA: 0x22D6860 Offset: 0x22D4E60 VA: 0x1822D6860
	private void ActionsChanged() { }

	// RVA: 0x22D73D0 Offset: 0x22D59D0 VA: 0x1822D73D0
	private bool IsInActiveHierarchy() { }

	// RVA: 0x22D6D30 Offset: 0x22D5330 VA: 0x1822D6D30
	internal void FocusChanged(bool isNodeFocused) { }

	// RVA: 0x22D7430 Offset: 0x22D5A30 VA: 0x1822D7430
	internal void NotifyFocusChanged(bool isNodeFocused) { }

	// RVA: 0x22D7450 Offset: 0x22D5A50 VA: 0x1822D7450
	internal bool Selected() { }
}

// Namespace: UnityEngine.Accessibility
public interface IAccessibilityNotificationDispatcher // TypeDefIndex: 14047
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendScreenChanged(AccessibilityNode nodeToFocus);
}

// Namespace: UnityEngine.Accessibility
internal class AccessibilityHierarchyService : IService // TypeDefIndex: 14048
{
	// Fields
	private AccessibilityHierarchy m_Hierarchy; // 0x10

	// Properties
	internal AccessibilityHierarchy hierarchy { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal AccessibilityHierarchy get_hierarchy() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void Start() { }

	// RVA: 0x22D4AB0 Offset: 0x22D30B0 VA: 0x1822D4AB0 Slot: 4
	public void Stop() { }

	// RVA: 0x22D4960 Offset: 0x22D2F60 VA: 0x1822D4960
	private void RemoveActiveHierarchy(bool notifyScreenChanged) { }

	// RVA: 0x22D4C80 Offset: 0x22D3280 VA: 0x1822D4C80
	internal bool TryGetNode(int id, out AccessibilityNode node) { }

	// RVA: 0x22D4940 Offset: 0x22D2F40 VA: 0x1822D4940
	internal List<AccessibilityNode> GetRootNodes() { }

	// RVA: 0x22D4BF0 Offset: 0x22D31F0 VA: 0x1822D4BF0
	internal bool TryGetNodeAt(float x, float y, out AccessibilityNode node) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Accessibility
internal interface IService // TypeDefIndex: 14049
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Stop();
}

// Namespace: UnityEngine.Accessibility
internal class ServiceManager // TypeDefIndex: 14050
{
	// Fields
	private readonly IDictionary<Type, IService> m_Services; // 0x10

	// Methods

	// RVA: 0x22D85E0 Offset: 0x22D6BE0 VA: 0x1822D85E0
	public void .ctor() { }

	// RVA: -1 Offset: -1
	public T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C2A0 Offset: 0x79A8A0 VA: 0x18079C2A0
	|-ServiceManager.GetService<object>
	|
	|-RVA: 0x79C0C0 Offset: 0x79A6C0 VA: 0x18079C0C0
	|-ServiceManager.GetService<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void StopService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C600 Offset: 0x79AC00 VA: 0x18079C600
	|-ServiceManager.StopService<object>
	|
	|-RVA: 0x79C400 Offset: 0x79AA00 VA: 0x18079C400
	|-ServiceManager.StopService<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22D83A0 Offset: 0x22D69A0 VA: 0x1822D83A0
	private void UpdateServices(bool isScreenReaderEnabled) { }

	// RVA: 0x22D8390 Offset: 0x22D6990 VA: 0x1822D8390
	protected void ScreenReaderStatusChanged(bool isScreenReaderEnabled) { }
}

