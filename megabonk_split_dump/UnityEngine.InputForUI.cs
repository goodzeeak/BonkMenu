// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct CommandEvent : IEventProperties // TypeDefIndex: 13713
{
	// Fields
	public CommandEvent.Type type; // 0x0
	public CommandEvent.Command command; // 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DiscreteTime <timestamp>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventSource <eventSource>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private uint <playerId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x18

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	public void set_timestamp(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x239CF20 Offset: 0x239B520 VA: 0x18239CF20 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct Event : IEventProperties // TypeDefIndex: 13719
{
	// Fields
	public static Event.Type[] TypesWithState; // 0x0
	private Event.Type _type; // 0x0
	private object _managedEvent; // 0x8
	private KeyEvent _keyEvent; // 0x10
	private PointerEvent _pointerEvent; // 0x10
	private TextInputEvent _textInputEvent; // 0x10
	private CommandEvent _commandEvent; // 0x10
	private NavigationEvent _navigationEvent; // 0x10

	// Properties
	public Event.Type type { get; }
	private IEventProperties asObject { get; }
	public EventSource eventSource { get; }
	public EventModifiers eventModifiers { get; }
	public KeyEvent asKeyEvent { get; }
	public PointerEvent asPointerEvent { get; }
	public TextInputEvent asTextInputEvent { get; }
	public IMECompositionEvent asIMECompositionEvent { get; }
	public CommandEvent asCommandEvent { get; }
	public NavigationEvent asNavigationEvent { get; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public Event.Type get_type() { }

	// RVA: 0x239F4F0 Offset: 0x239DAF0 VA: 0x18239F4F0
	private IEventProperties get_asObject() { }

	// RVA: 0x239F6E0 Offset: 0x239DCE0 VA: 0x18239F6E0 Slot: 4
	public EventSource get_eventSource() { }

	// RVA: 0x239F680 Offset: 0x239DC80 VA: 0x18239F680 Slot: 5
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x239EBC0 Offset: 0x239D1C0 VA: 0x18239EBC0
	private void Ensure(Event.Type t) { }

	// RVA: 0x239EFC0 Offset: 0x239D5C0 VA: 0x18239EFC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x239EE40 Offset: 0x239D440 VA: 0x18239EE40
	public static Event From(KeyEvent keyEvent) { }

	// RVA: 0x239F3C0 Offset: 0x239D9C0 VA: 0x18239F3C0
	public KeyEvent get_asKeyEvent() { }

	// RVA: 0x239EDD0 Offset: 0x239D3D0 VA: 0x18239EDD0
	public static Event From(PointerEvent pointerEvent) { }

	// RVA: 0x239F550 Offset: 0x239DB50 VA: 0x18239F550
	public PointerEvent get_asPointerEvent() { }

	// RVA: 0x239EF40 Offset: 0x239D540 VA: 0x18239EF40
	public static Event From(TextInputEvent textInputEvent) { }

	// RVA: 0x239F600 Offset: 0x239DC00 VA: 0x18239F600
	public TextInputEvent get_asTextInputEvent() { }

	// RVA: 0x239EC40 Offset: 0x239D240 VA: 0x18239EC40
	public static Event From(IMECompositionEvent imeCompositionEvent) { }

	// RVA: 0x239F300 Offset: 0x239D900 VA: 0x18239F300
	public IMECompositionEvent get_asIMECompositionEvent() { }

	// RVA: 0x239EEC0 Offset: 0x239D4C0 VA: 0x18239EEC0
	public static Event From(CommandEvent commandEvent) { }

	// RVA: 0x239F280 Offset: 0x239D880 VA: 0x18239F280
	public CommandEvent get_asCommandEvent() { }

	// RVA: 0x239ED50 Offset: 0x239D350 VA: 0x18239ED50
	public static Event From(NavigationEvent navigationEvent) { }

	// RVA: 0x239F460 Offset: 0x239DA60 VA: 0x18239F460
	public NavigationEvent get_asNavigationEvent() { }

	// RVA: -1 Offset: -1
	private TOutputType Map<TOutputType, TMapType>(TMapType fn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F8300 Offset: 0x6F6900 VA: 0x1806F8300
	|-Event.Map<EventModifiers, Event.MapAsEventModifiers>
	|
	|-RVA: 0x6F8C80 Offset: 0x6F7280 VA: 0x1806F8C80
	|-Event.Map<Int32Enum, Event.MapAsEventSource>
	|
	|-RVA: 0x6F8E70 Offset: 0x6F7470 VA: 0x1806F8E70
	|-Event.Map<object, Event.MapAsObject>
	|
	|-RVA: 0x6F8630 Offset: 0x6F6C30 VA: 0x1806F8630
	|-Event.Map<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private TOutputType Map<TOutputType, TMapType>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F8280 Offset: 0x6F6880 VA: 0x1806F8280
	|-Event.Map<EventModifiers, Event.MapAsEventModifiers>
	|
	|-RVA: 0x6F8C00 Offset: 0x6F7200 VA: 0x1806F8C00
	|-Event.Map<Int32Enum, Event.MapAsEventSource>
	|
	|-RVA: 0x6F9060 Offset: 0x6F7660 VA: 0x1806F9060
	|-Event.Map<object, Event.MapAsObject>
	|
	|-RVA: 0x6F84F0 Offset: 0x6F6AF0 VA: 0x1806F84F0
	|-Event.Map<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x239F1F0 Offset: 0x239D7F0 VA: 0x18239F1F0
	private static void .cctor() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct EventModifiers // TypeDefIndex: 13721
{
	// Fields
	private uint _state; // 0x0

	// Properties
	public bool isShiftPressed { get; }
	public bool isCtrlPressed { get; }
	public bool isAltPressed { get; }
	public bool isMetaPressed { get; }
	public bool isCapsLockEnabled { get; }
	public bool isFunctionKeyPressed { get; }
	public bool isNumericPressed { get; }

	// Methods

	// RVA: 0x239D180 Offset: 0x239B780 VA: 0x18239D180
	public bool IsPressed(EventModifiers.Modifiers mod) { }

	// RVA: 0x239D770 Offset: 0x239BD70 VA: 0x18239D770
	public bool get_isShiftPressed() { }

	// RVA: 0x239D730 Offset: 0x239BD30 VA: 0x18239D730
	public bool get_isCtrlPressed() { }

	// RVA: 0x239D710 Offset: 0x239BD10 VA: 0x18239D710
	public bool get_isAltPressed() { }

	// RVA: 0x239D750 Offset: 0x239BD50 VA: 0x18239D750
	public bool get_isMetaPressed() { }

	// RVA: 0x239D720 Offset: 0x239BD20 VA: 0x18239D720
	public bool get_isCapsLockEnabled() { }

	// RVA: 0x239D740 Offset: 0x239BD40 VA: 0x18239D740
	public bool get_isFunctionKeyPressed() { }

	// RVA: 0x239D760 Offset: 0x239BD60 VA: 0x18239D760
	public bool get_isNumericPressed() { }

	// RVA: 0x1E4A1D0 Offset: 0x1E487D0 VA: 0x181E4A1D0
	public void SetPressed(EventModifiers.Modifiers modifier, bool pressed) { }

	// RVA: 0x1368FB0 Offset: 0x13675B0 VA: 0x181368FB0
	public void Reset() { }

	// RVA: 0x239D110 Offset: 0x239B710 VA: 0x18239D110
	private static void Append(ref string str, string value) { }

	// RVA: 0x239D190 Offset: 0x239B790 VA: 0x18239D190 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum EventSource // TypeDefIndex: 13722
{
	// Fields
	public int value__; // 0x0
	public const EventSource Unspecified = 0;
	public const EventSource Keyboard = 1;
	public const EventSource Gamepad = 2;
	public const EventSource Mouse = 3;
	public const EventSource Pen = 4;
	public const EventSource Touch = 5;
}

// Namespace: UnityEngine.InputForUI
internal interface IEventProperties // TypeDefIndex: 13723
{
	// Properties
	public abstract EventSource eventSource { get; }
	public abstract EventModifiers eventModifiers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventSource get_eventSource();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract EventModifiers get_eventModifiers();
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct IMECompositionEvent : IEventProperties // TypeDefIndex: 13724
{
	// Fields
	public string compositionString; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DiscreteTime <timestamp>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventSource <eventSource>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private uint <playerId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x18

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	public void set_timestamp(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_playerId(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x239F740 Offset: 0x239DD40 VA: 0x18239F740 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct KeyEvent : IEventProperties // TypeDefIndex: 13729
{
	// Fields
	public KeyEvent.Type type; // 0x0
	public KeyCode keyCode; // 0x4
	public KeyEvent.ButtonsState buttonsState; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DiscreteTime <timestamp>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventSource <eventSource>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x40

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1641190 Offset: 0x163F790 VA: 0x181641190
	public void set_timestamp(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x23A4040 Offset: 0x23A2640 VA: 0x1823A4040 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct NavigationEvent : IEventProperties // TypeDefIndex: 13732
{
	// Fields
	public NavigationEvent.Type type; // 0x0
	public NavigationEvent.Direction direction; // 0x4
	public bool shouldBeUsed; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <timestamp>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventSource <eventSource>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x20

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_timestamp(DiscreteTime value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x23A4400 Offset: 0x23A2A00 VA: 0x1823A4400 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A4390 Offset: 0x23A2990 VA: 0x1823A4390
	internal static NavigationEvent.Direction DetermineMoveDirection(Vector2 vec, float deadZone = 0.6) { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct PointerEvent : IEventProperties // TypeDefIndex: 13736
{
	// Fields
	public PointerEvent.Type type; // 0x0
	public int pointerIndex; // 0x4
	public Vector2 position; // 0x8
	public Vector2 deltaPosition; // 0x10
	public Vector2 scroll; // 0x18
	public int displayIndex; // 0x20
	public Vector2 tilt; // 0x24
	public float twist; // 0x2C
	public float pressure; // 0x30
	public bool isInverted; // 0x34
	public PointerEvent.Button button; // 0x38
	public PointerEvent.ButtonsState buttonsState; // 0x3C
	public int clickCount; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <timestamp>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventSource <eventSource>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x54
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventModifiers <eventModifiers>k__BackingField; // 0x58

	// Properties
	public bool isPrimaryPointer { get; }
	public float azimuth { get; }
	public float altitude { get; }
	public DiscreteTime timestamp { get; set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	// RVA: 0x23A5520 Offset: 0x23A3B20 VA: 0x1823A5520
	public bool get_isPrimaryPointer() { }

	// RVA: 0x23A5450 Offset: 0x23A3A50 VA: 0x1823A5450
	public float get_azimuth() { }

	// RVA: 0x23A5400 Offset: 0x23A3A00 VA: 0x1823A5400
	public float get_altitude() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 6
	public DiscreteTime get_timestamp() { }

	[CompilerGenerated]
	// RVA: 0x1641130 Offset: 0x163F730 VA: 0x181641130
	public void set_timestamp(DiscreteTime value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x3AA880 Offset: 0x3A8E80 VA: 0x1803AA880
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x464C90 Offset: 0x463290 VA: 0x180464C90
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x23A4540 Offset: 0x23A2B40 VA: 0x1823A4540 Slot: 3
	public override string ToString() { }

	// RVA: 0x23A4520 Offset: 0x23A2B20 VA: 0x1823A4520
	internal static PointerEvent.Button ButtonFromButtonIndex(int index) { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct TextInputEvent : IEventProperties // TypeDefIndex: 13737
{
	// Fields
	public char character; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <timestamp>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventSource <eventSource>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private uint <playerId>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <eventModifiers>k__BackingField; // 0x18

	// Properties
	public DiscreteTime timestamp { set; }
	public EventSource eventSource { get; set; }
	public uint playerId { set; }
	public EventModifiers eventModifiers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	public void set_timestamp(DiscreteTime value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public EventSource get_eventSource() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_eventSource(EventSource value) { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_playerId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 5
	public EventModifiers get_eventModifiers() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x23A59A0 Offset: 0x23A3FA0 VA: 0x1823A59A0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal static class EventProvider // TypeDefIndex: 13741
{
	// Fields
	private static IEventProviderImpl s_impl; // 0x0
	private static EventSanitizer s_sanitizer; // 0x8
	private static IEventProviderImpl s_implMockBackup; // 0x10
	private static bool s_focusChangedRegistered; // 0x18
	private static bool m_IsEnabled; // 0x19
	private static bool m_IsInitialized; // 0x1A
	private static List<EventProvider.Registration> _registrations; // 0x20

	// Methods

	// RVA: 0x239E1B0 Offset: 0x239C7B0 VA: 0x18239E1B0
	public static void Subscribe(EventConsumer handler, int priority = 0, Nullable<int> playerId, Event.Type[] type) { }

	// RVA: 0x239E4B0 Offset: 0x239CAB0 VA: 0x18239E4B0
	public static void Unsubscribe(EventConsumer handler) { }

	// RVA: 0x239DE60 Offset: 0x239C460 VA: 0x18239DE60
	public static void SetEnabled(bool enable) { }

	// RVA: 0x239D7F0 Offset: 0x239BDF0 VA: 0x18239D7F0
	internal static void Dispatch(in Event ev) { }

	// RVA: 0x239D780 Offset: 0x239BD80 VA: 0x18239D780
	private static void Bootstrap() { }

	// RVA: 0x239DA80 Offset: 0x239C080 VA: 0x18239DA80
	private static void Initialize() { }

	// RVA: 0x239E040 Offset: 0x239C640 VA: 0x18239E040
	private static void Shutdown() { }

	// RVA: 0x239DD80 Offset: 0x239C380 VA: 0x18239DD80
	private static void OnFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	// RVA: 0x239DC20 Offset: 0x239C220 VA: 0x18239DC20
	internal static void NotifyUpdate() { }

	// RVA: 0x239E5C0 Offset: 0x239CBC0 VA: 0x18239E5C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.InputForUI
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal sealed class EventConsumer : MulticastDelegate // TypeDefIndex: 13742
{
	// Methods

	// RVA: 0xA82200 Offset: 0xA80800 VA: 0x180A82200
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950 Slot: 13
	public virtual bool Invoke(in Event ev) { }
}

// Namespace: UnityEngine.InputForUI
internal interface IEventProviderImpl // TypeDefIndex: 13743
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnFocusChanged(bool focus);
}

// Namespace: UnityEngine.InputForUI
internal class InputEventPartialProvider : IEventProviderImpl // TypeDefIndex: 13744
{
	// Fields
	private Event _ev; // 0x10
	private OperatingSystemFamily _operatingSystemFamily; // 0x18
	private KeyEvent.ButtonsState _keyboardButtonsState; // 0x1C
	internal EventModifiers _eventModifiers; // 0x44
	internal bool _sendNavigationEventOnTabKey; // 0x48
	private IDictionary<string, CommandEvent.Command> _IMGUICommandToInputForUICommandType; // 0x50

	// Methods

	// RVA: 0x239F7C0 Offset: 0x239DDC0 VA: 0x18239F7C0 Slot: 4
	public void Initialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void Shutdown() { }

	// RVA: 0x23A0150 Offset: 0x239E750 VA: 0x1823A0150 Slot: 6
	public void Update() { }

	// RVA: 0x239F7F0 Offset: 0x239DDF0 VA: 0x18239F7F0 Slot: 7
	public void OnFocusChanged(bool focus) { }

	// RVA: 0x239F790 Offset: 0x239DD90 VA: 0x18239F790
	private DiscreteTime GetTimestamp(in Event ev) { }

	// RVA: 0x239FE50 Offset: 0x239E450 VA: 0x18239FE50
	private void UpdateEventModifiers(in Event ev) { }

	// RVA: 0x239FBA0 Offset: 0x239E1A0 VA: 0x18239FBA0
	private KeyEvent ToKeyEvent(in Event ev) { }

	// RVA: 0x239FDA0 Offset: 0x239E3A0 VA: 0x18239FDA0
	private TextInputEvent ToTextInputEvent(in Event ev) { }

	// RVA: 0x239F810 Offset: 0x239DE10 VA: 0x18239F810
	private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(in Event ev) { }

	// RVA: 0x239F990 Offset: 0x239DF90 VA: 0x18239F990
	private CommandEvent ToCommandEvent(in Event ev) { }

	// RVA: 0x23A0490 Offset: 0x239EA90 VA: 0x1823A0490
	public void .ctor() { }
}

// Namespace: UnityEngine.InputForUI
internal class InputManagerProvider : IEventProviderImpl // TypeDefIndex: 13751
{
	// Fields
	private InputEventPartialProvider _inputEventPartialProvider; // 0x10
	private string _compositionString; // 0x18
	private InputManagerProvider.Configuration _configuration; // 0x20
	private InputManagerProvider.IInput _input; // 0x58
	private InputManagerProvider.ITime _time; // 0x60
	private NavigationEventRepeatHelper _navigationEventRepeatHelper; // 0x68
	private PointerState _mouseState; // 0x70
	private bool _isPenPresent; // 0x98
	private bool _seenAtLeastOnePenPosition; // 0x99
	private Vector2 _lastSeenPenPositionForDetection; // 0x9C
	private PointerState _penState; // 0xA8
	private PenData _lastPenData; // 0xD0
	private Dictionary<int, int> _touchFingerIdToFingerIndex; // 0xF8
	private int _touchNextFingerIndex; // 0x100
	private PointerState _touchState; // 0x108

	// Properties
	private EventModifiers _eventModifiers { get; }

	// Methods

	// RVA: 0x3A4E00 Offset: 0x3A3400 VA: 0x1803A4E00
	private EventModifiers get__eventModifiers() { }

	// RVA: 0x23A3C30 Offset: 0x23A2230 VA: 0x1823A3C30
	public void .ctor() { }

	// RVA: 0x23A2850 Offset: 0x23A0E50 VA: 0x1823A2850 Slot: 4
	public void Initialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void Shutdown() { }

	// RVA: 0x23A3740 Offset: 0x23A1D40 VA: 0x1823A3740 Slot: 6
	public void Update() { }

	// RVA: 0x23A1BF0 Offset: 0x23A01F0 VA: 0x1823A1BF0
	private bool CheckTouchEvents(DiscreteTime currentTime) { }

	// RVA: 0x23A2290 Offset: 0x23A0890 VA: 0x1823A2290
	private void DetectPen() { }

	// RVA: 0x23A3250 Offset: 0x23A1850 VA: 0x1823A3250
	private static PointerEvent.Button PenStatusToButton(PenStatus status) { }

	// RVA: 0x23A16E0 Offset: 0x239FCE0 VA: 0x1823A16E0
	private bool CheckPenEvent(DiscreteTime currentTime, in PenData currentPenData) { }

	// RVA: 0x23A0BA0 Offset: 0x239F1A0 VA: 0x1823A0BA0
	private void CheckMouseEvents(DiscreteTime currentTime, bool muted = False) { }

	// RVA: 0x23A1300 Offset: 0x239F900 VA: 0x1823A1300
	private void CheckMouseScroll(DiscreteTime currentTime) { }

	// RVA: 0x23A3080 Offset: 0x23A1680 VA: 0x1823A3080
	private void NextPreviousNavigation(DiscreteTime currentTime) { }

	// RVA: 0x23A3490 Offset: 0x23A1A90 VA: 0x1823A3490
	private void SubmitCancelNavigation(DiscreteTime currentTime) { }

	// RVA: 0x23A2360 Offset: 0x23A0960 VA: 0x1823A2360
	private void DirectionNavigation(DiscreteTime currentTime) { }

	// RVA: 0x23A0900 Offset: 0x239EF00 VA: 0x1823A0900
	private void CheckIfIMEChanged(DiscreteTime currentTime) { }

	// RVA: 0x23A3210 Offset: 0x23A1810 VA: 0x1823A3210 Slot: 7
	public void OnFocusChanged(bool focus) { }

	// RVA: 0x23A2750 Offset: 0x23A0D50 VA: 0x1823A2750
	private EventSource GetEventSourceFromPressedKey() { }

	// RVA: 0x23A2B80 Offset: 0x23A1180 VA: 0x1823A2B80
	private bool InputManagerJoystickWasPressed() { }

	// RVA: 0x23A2C00 Offset: 0x23A1200 VA: 0x1823A2C00
	private bool InputManagerKeyboardWasPressed() { }

	// RVA: 0x23A29A0 Offset: 0x23A0FA0 VA: 0x1823A29A0
	private float InputManagerGetAxisRawOrDefault(string axisName) { }

	// RVA: 0x23A2A90 Offset: 0x23A1090 VA: 0x1823A2A90
	private bool InputManagerGetButtonDownOrDefault(string axisName) { }

	// RVA: 0x23A3270 Offset: 0x23A1870 VA: 0x1823A3270
	private ValueTuple<Vector2, bool> ReadCurrentNavigationMoveVector() { }

	// RVA: 0x23A36B0 Offset: 0x23A1CB0 VA: 0x1823A36B0
	private IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString) { }

	// RVA: 0x12EC6C0 Offset: 0x12EACC0 VA: 0x1812EC6C0
	internal static float TiltToAzimuth(Vector2 tilt) { }

	// RVA: 0x12E8BD0 Offset: 0x12E71D0 VA: 0x1812E8BD0
	internal static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	// RVA: 0x12EC670 Offset: 0x12EAC70 VA: 0x1812EC670
	internal static float TiltToAltitude(Vector2 tilt) { }

	// RVA: 0x23A2C80 Offset: 0x23A1280 VA: 0x1823A2C80
	private static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int targetDisplay) { }

	// RVA: 0x23A2EE0 Offset: 0x23A14E0 VA: 0x1823A2EE0
	private static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<int> targetDisplay) { }

	// RVA: 0x23A33B0 Offset: 0x23A19B0 VA: 0x1823A33B0
	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }
}

// Namespace: UnityEngine.InputForUI
internal class NavigationEventRepeatHelper // TypeDefIndex: 13752
{
	// Fields
	private int m_ConsecutiveMoveCount; // 0x10
	private NavigationEvent.Direction m_LastDirection; // 0x14
	private DiscreteTime m_PrevActionTime; // 0x18
	private readonly DiscreteTime m_InitialRepeatDelay; // 0x20
	private readonly DiscreteTime m_ConsecutiveRepeatDelay; // 0x28

	// Methods

	// RVA: 0x23A4190 Offset: 0x23A2790 VA: 0x1823A4190
	public void Reset() { }

	// RVA: 0x23A41F0 Offset: 0x23A27F0 VA: 0x1823A41F0
	public bool ShouldSendMoveEvent(DiscreteTime timestamp, NavigationEvent.Direction direction, bool axisButtonsWherePressedThisFrame) { }

	// RVA: 0x23A42E0 Offset: 0x23A28E0 VA: 0x1823A42E0
	public void .ctor() { }
}

// Namespace: UnityEngine.InputForUI
internal struct PointerState // TypeDefIndex: 13753
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private PointerEvent.Button <LastPressedButton>k__BackingField; // 0x0
	private PointerEvent.ButtonsState _buttonsState; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DiscreteTime <NextPressTime>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <ClickCount>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <LastPosition>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <LastDisplayIndex>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <LastPositionValid>k__BackingField; // 0x20
	private static readonly DiscreteTime kClickDelay; // 0x0

	// Properties
	public PointerEvent.Button LastPressedButton { get; set; }
	public PointerEvent.ButtonsState ButtonsState { get; }
	public DiscreteTime NextPressTime { get; set; }
	public int ClickCount { get; set; }
	public Vector2 LastPosition { get; set; }
	public int LastDisplayIndex { get; set; }
	public bool LastPositionValid { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public PointerEvent.Button get_LastPressedButton() { }

	[CompilerGenerated]
	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	private void set_LastPressedButton(PointerEvent.Button value) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public PointerEvent.ButtonsState get_ButtonsState() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public DiscreteTime get_NextPressTime() { }

	[CompilerGenerated]
	// RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	private void set_NextPressTime(DiscreteTime value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_ClickCount() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	private void set_ClickCount(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8641B0 Offset: 0x8627B0 VA: 0x1808641B0
	public Vector2 get_LastPosition() { }

	[CompilerGenerated]
	// RVA: 0x23A5990 Offset: 0x23A3F90 VA: 0x1823A5990
	private void set_LastPosition(Vector2 value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_LastDisplayIndex() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	private void set_LastDisplayIndex(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_LastPositionValid() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_LastPositionValid(bool value) { }

	// RVA: 0x23A55F0 Offset: 0x23A3BF0 VA: 0x1823A55F0
	public void OnButtonDown(DiscreteTime currentTime, PointerEvent.Button button) { }

	// RVA: 0x23A5730 Offset: 0x23A3D30 VA: 0x1823A5730
	public void OnButtonUp(DiscreteTime currentTime, PointerEvent.Button button) { }

	// RVA: 0x23A5530 Offset: 0x23A3B30 VA: 0x1823A5530
	public void OnButtonChange(DiscreteTime currentTime, PointerEvent.Button button, bool previousState, bool newState) { }

	// RVA: 0x23A57B0 Offset: 0x23A3DB0 VA: 0x1823A57B0
	public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex) { }

	// RVA: 0x23A5820 Offset: 0x23A3E20 VA: 0x1823A5820
	public void Reset() { }

	// RVA: 0x23A58F0 Offset: 0x23A3EF0 VA: 0x1823A58F0
	private static void .cctor() { }
}

// Namespace: UnityEngine.InputForUI
internal struct EventSanitizer // TypeDefIndex: 13755
{
	// Fields
	private EventSanitizer.IEventSanitizer[] _sanitizers; // 0x0

	// Methods

	// RVA: 0x239EA80 Offset: 0x239D080 VA: 0x18239EA80
	public void Reset() { }

	// RVA: 0x239E820 Offset: 0x239CE20 VA: 0x18239E820
	public void BeforeProviderUpdate() { }

	// RVA: 0x239E6F0 Offset: 0x239CCF0 VA: 0x18239E6F0
	public void AfterProviderUpdate() { }

	// RVA: 0x239E950 Offset: 0x239CF50 VA: 0x18239E950
	public void Inspect(in Event ev) { }
}

