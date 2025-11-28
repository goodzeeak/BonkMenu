// Namespace: UnityEngine.EventSystems
public class AxisEventData : BaseEventData // TypeDefIndex: 12240
{
	// Fields
	[CompilerGenerated]
	private Vector2 <moveVector>k__BackingField; // 0x20
	[CompilerGenerated]
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Properties
	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16ADB50 Offset: 0x16AC150 VA: 0x1816ADB50
	public Vector2 get_moveVector() { }

	[CompilerGenerated]
	// RVA: 0x163E100 Offset: 0x163C700 VA: 0x18163E100
	public void set_moveVector(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public MoveDirection get_moveDir() { }

	[CompilerGenerated]
	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x266C750 Offset: 0x266AD50 VA: 0x18266C750
	public void .ctor(EventSystem eventSystem) { }
}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData // TypeDefIndex: 12241
{
	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x164F4B0 Offset: 0x164DAB0 VA: 0x18164F4B0 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x1E9D770 Offset: 0x1E9BD70 VA: 0x181E9D770 Slot: 5
	public virtual void Use() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00 Slot: 6
	public virtual bool get_used() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseEventData : AbstractEventData // TypeDefIndex: 12242
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x13E9320 Offset: 0x13E7920 VA: 0x1813E9320
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x168F8F0 Offset: 0x168DEF0 VA: 0x18168F8F0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x168F8A0 Offset: 0x168DEA0 VA: 0x18168F8A0
	public GameObject get_selectedObject() { }

	// RVA: 0x266C7D0 Offset: 0x266ADD0 VA: 0x18266C7D0
	public void set_selectedObject(GameObject value) { }
}

// Namespace: UnityEngine.EventSystems
public class PointerEventData : BaseEventData // TypeDefIndex: 12245
{
	// Fields
	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGenerated]
	private GameObject <pointerClick>k__BackingField; // 0x48
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0xA0
	public List<GameObject> hovered; // 0xF0
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; // 0xF8
	[CompilerGenerated]
	private int <displayIndex>k__BackingField; // 0xFC
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x100
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; // 0x104
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; // 0x10C
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; // 0x114
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; // 0x11C
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; // 0x128
	[CompilerGenerated]
	private float <clickTime>k__BackingField; // 0x134
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x138
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; // 0x13C
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; // 0x144
	[CompilerGenerated]
	private bool <dragging>k__BackingField; // 0x145
	[CompilerGenerated]
	private PointerEventData.InputButton <button>k__BackingField; // 0x148
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x14C
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; // 0x150
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; // 0x154
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; // 0x158
	[CompilerGenerated]
	private float <twist>k__BackingField; // 0x15C
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; // 0x160
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; // 0x168
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x16C
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x174
	[CompilerGenerated]
	private bool <fullyExited>k__BackingField; // 0x17C
	[CompilerGenerated]
	private bool <reentered>k__BackingField; // 0x17D

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public GameObject pointerClick { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int displayIndex { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public bool fullyExited { get; set; }
	public bool reentered { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public GameObject get_pointerEnter() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_pointerEnter(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public GameObject get_lastPress() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_lastPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public GameObject get_rawPointerPress() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public GameObject get_pointerDrag() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_pointerDrag(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public GameObject get_pointerClick() { }

	[CompilerGenerated]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_pointerClick(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x26779A0 Offset: 0x2675FA0 VA: 0x1826779A0
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGenerated]
	// RVA: 0x2677C90 Offset: 0x2676290 VA: 0x182677C90
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x26779E0 Offset: 0x2675FE0 VA: 0x1826779E0
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGenerated]
	// RVA: 0x2677CD0 Offset: 0x26762D0 VA: 0x182677CD0
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x21CADA0 Offset: 0x21C93A0 VA: 0x1821CADA0
	public bool get_eligibleForClick() { }

	[CompilerGenerated]
	// RVA: 0x2677C60 Offset: 0x2676260 VA: 0x182677C60
	public void set_eligibleForClick(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2677900 Offset: 0x2675F00 VA: 0x182677900
	public int get_displayIndex() { }

	[CompilerGenerated]
	// RVA: 0x2677C50 Offset: 0x2676250 VA: 0x182677C50
	public void set_displayIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x561290 Offset: 0x55F890 VA: 0x180561290
	public int get_pointerId() { }

	[CompilerGenerated]
	// RVA: 0x5615D0 Offset: 0x55FBD0 VA: 0x1805615D0
	public void set_pointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2677A20 Offset: 0x2676020 VA: 0x182677A20
	public Vector2 get_position() { }

	[CompilerGenerated]
	// RVA: 0x2677DB0 Offset: 0x26763B0 VA: 0x182677DB0
	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x26778E0 Offset: 0x2675EE0 VA: 0x1826778E0
	public Vector2 get_delta() { }

	[CompilerGenerated]
	// RVA: 0x2677C40 Offset: 0x2676240 VA: 0x182677C40
	public void set_delta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2677AE0 Offset: 0x26760E0 VA: 0x182677AE0
	public Vector2 get_pressPosition() { }

	[CompilerGenerated]
	// RVA: 0x2677DC0 Offset: 0x26763C0 VA: 0x182677DC0
	public void set_pressPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2677BD0 Offset: 0x26761D0 VA: 0x182677BD0
	public Vector3 get_worldPosition() { }

	[CompilerGenerated]
	// RVA: 0x2677E80 Offset: 0x2676480 VA: 0x182677E80
	public void set_worldPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x2677BB0 Offset: 0x26761B0 VA: 0x182677BB0
	public Vector3 get_worldNormal() { }

	[CompilerGenerated]
	// RVA: 0x2677E60 Offset: 0x2676460 VA: 0x182677E60
	public void set_worldNormal(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x26778D0 Offset: 0x2675ED0 VA: 0x1826778D0
	public float get_clickTime() { }

	[CompilerGenerated]
	// RVA: 0x2677C30 Offset: 0x2676230 VA: 0x182677C30
	public void set_clickTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x17870A0 Offset: 0x17856A0 VA: 0x1817870A0
	public int get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x2677C20 Offset: 0x2676220 VA: 0x182677C20
	public void set_clickCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x2677B50 Offset: 0x2676150 VA: 0x182677B50
	public Vector2 get_scrollDelta() { }

	[CompilerGenerated]
	// RVA: 0x2677E10 Offset: 0x2676410 VA: 0x182677E10
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2677BA0 Offset: 0x26761A0 VA: 0x182677BA0
	public bool get_useDragThreshold() { }

	[CompilerGenerated]
	// RVA: 0x2677E50 Offset: 0x2676450 VA: 0x182677E50
	public void set_useDragThreshold(bool value) { }

	[CompilerGenerated]
	// RVA: 0x561260 Offset: 0x55F860 VA: 0x180561260
	public bool get_dragging() { }

	[CompilerGenerated]
	// RVA: 0x5615C0 Offset: 0x55FBC0 VA: 0x1805615C0
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	// RVA: 0x26778C0 Offset: 0x2675EC0 VA: 0x1826778C0
	public PointerEventData.InputButton get_button() { }

	[CompilerGenerated]
	// RVA: 0x2677C10 Offset: 0x2676210 VA: 0x182677C10
	public void set_button(PointerEventData.InputButton value) { }

	[CompilerGenerated]
	// RVA: 0x2677B00 Offset: 0x2676100 VA: 0x182677B00
	public float get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x2677DD0 Offset: 0x26763D0 VA: 0x182677DD0
	public void set_pressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x2677B70 Offset: 0x2676170 VA: 0x182677B70
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	// RVA: 0x2677E20 Offset: 0x2676420 VA: 0x182677E20
	public void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x46A710 Offset: 0x468D10 VA: 0x18046A710
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	// RVA: 0x2677BF0 Offset: 0x26761F0 VA: 0x182677BF0
	public void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x1791C10 Offset: 0x1790210 VA: 0x181791C10
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	// RVA: 0x2677C00 Offset: 0x2676200 VA: 0x182677C00
	public void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x21CA930 Offset: 0x21C8F30 VA: 0x1821CA930
	public float get_twist() { }

	[CompilerGenerated]
	// RVA: 0x2677E40 Offset: 0x2676440 VA: 0x182677E40
	public void set_twist(float value) { }

	[CompilerGenerated]
	// RVA: 0x2677B80 Offset: 0x2676180 VA: 0x182677B80
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	// RVA: 0x2677E30 Offset: 0x2676430 VA: 0x182677E30
	public void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1791B70 Offset: 0x1790170 VA: 0x181791B70
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	// RVA: 0x2677C80 Offset: 0x2676280 VA: 0x182677C80
	public void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	// RVA: 0x2677B30 Offset: 0x2676130 VA: 0x182677B30
	public Vector2 get_radius() { }

	[CompilerGenerated]
	// RVA: 0x2677DF0 Offset: 0x26763F0 VA: 0x182677DF0
	public void set_radius(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2677B10 Offset: 0x2676110 VA: 0x182677B10
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	// RVA: 0x2677DE0 Offset: 0x26763E0 VA: 0x182677DE0
	public void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x17A2450 Offset: 0x17A0A50 VA: 0x1817A2450
	public bool get_fullyExited() { }

	[CompilerGenerated]
	// RVA: 0x2677C70 Offset: 0x2676270 VA: 0x182677C70
	public void set_fullyExited(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21CAB00 Offset: 0x21C9100 VA: 0x1821CAB00
	public bool get_reentered() { }

	[CompilerGenerated]
	// RVA: 0x2677E00 Offset: 0x2676400 VA: 0x182677E00
	public void set_reentered(bool value) { }

	// RVA: 0x2677640 Offset: 0x2675C40 VA: 0x182677640
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x2676F00 Offset: 0x2675500 VA: 0x182676F00
	public bool IsPointerMoving() { }

	// RVA: 0x2676F30 Offset: 0x2675530 VA: 0x182676F30
	public bool IsScrolling() { }

	// RVA: 0x2677910 Offset: 0x2675F10 VA: 0x182677910
	public Camera get_enterEventCamera() { }

	// RVA: 0x2677A40 Offset: 0x2676040 VA: 0x182677A40
	public Camera get_pressEventCamera() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public GameObject get_pointerPress() { }

	// RVA: 0x2677D20 Offset: 0x2676320 VA: 0x182677D20
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x2676F60 Offset: 0x2675560 VA: 0x182676F60 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
[Flags]
public enum EventHandle // TypeDefIndex: 12246
{
	// Fields
	public int value__; // 0x0
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;
}

// Namespace: UnityEngine.EventSystems
public interface IEventSystemHandler // TypeDefIndex: 12247
{}

// Namespace: UnityEngine.EventSystems
public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 12248
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerMove(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 12249
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerEnter(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 12250
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerExit(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 12251
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerDown(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 12252
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerUp(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 12253
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerClick(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 12254
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeginDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 12255
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializePotentialDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 12256
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 12257
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 12258
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrop(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 12259
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnScroll(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 12260
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdateSelected(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 12261
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSelect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 12262
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeselect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 12263
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMove(AxisEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 12264
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSubmit(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 12265
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCancel(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
public class EventSystem : UIBehaviour // TypeDefIndex: 12268
{
	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x20
	private BaseInputModule m_CurrentInputModule; // 0x28
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_Selected")]
	private GameObject m_FirstSelected; // 0x30
	[SerializeField]
	private bool m_sendNavigationEvents; // 0x38
	[SerializeField]
	private int m_DragThreshold; // 0x3C
	private GameObject m_CurrentSelected; // 0x40
	private bool m_HasFocus; // 0x48
	private bool m_SelectionGuard; // 0x49
	private BaseEventData m_DummyData; // 0x50
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8
	private static EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
	private bool m_Started; // 0x58
	private bool m_IsTrackingUIToolkitPanels; // 0x59

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }
	private bool isUIToolkitActiveEventSystem { get; }
	private bool sendUIToolkitEvents { get; }
	private bool createUIToolkitPanelGameObjectsOnStart { get; }

	// Methods

	// RVA: 0x26707C0 Offset: 0x266EDC0 VA: 0x1826707C0
	public static EventSystem get_current() { }

	// RVA: 0x26709D0 Offset: 0x266EFD0 VA: 0x1826709D0
	public static void set_current(EventSystem value) { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_sendNavigationEvents() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public int get_pixelDragThreshold() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_isFocused() { }

	// RVA: 0x2670640 Offset: 0x266EC40 VA: 0x182670640
	protected void .ctor() { }

	// RVA: 0x2670150 Offset: 0x266E750 VA: 0x182670150
	public void UpdateModules() { }

	// RVA: 0x16EE300 Offset: 0x16EC900 VA: 0x1816EE300
	public bool get_alreadySelecting() { }

	// RVA: 0x266F570 Offset: 0x266DB70 VA: 0x18266F570
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x26706D0 Offset: 0x266ECD0 VA: 0x1826706D0
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x266F4D0 Offset: 0x266DAD0 VA: 0x18266F4D0
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x266EF90 Offset: 0x266D590 VA: 0x18266EF90
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x266EDA0 Offset: 0x266D3A0 VA: 0x18266EDA0
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x266E9F0 Offset: 0x266CFF0 VA: 0x18266E9F0
	public bool IsPointerOverGameObject() { }

	// RVA: 0x266E950 Offset: 0x266CF50 VA: 0x18266E950
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x2670870 Offset: 0x266EE70 VA: 0x182670870
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x2670960 Offset: 0x266EF60 VA: 0x182670960
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x2670750 Offset: 0x266ED50 VA: 0x182670750
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x266F790 Offset: 0x266DD90 VA: 0x18266F790
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = True, bool createPanelGameObjectsOnStart = True) { }

	// RVA: 0x266F950 Offset: 0x266DF50 VA: 0x18266F950
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x266FE50 Offset: 0x266E450 VA: 0x18266FE50
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x266E6A0 Offset: 0x266CCA0 VA: 0x18266E6A0
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x266FE40 Offset: 0x266E440 VA: 0x18266FE40 Slot: 6
	protected override void Start() { }

	// RVA: 0x266EC20 Offset: 0x266D220 VA: 0x18266EC20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x266EA90 Offset: 0x266D090 VA: 0x18266EA90 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x266FEF0 Offset: 0x266E4F0 VA: 0x18266FEF0
	private void TickModules() { }

	// RVA: 0x266EA80 Offset: 0x266D080 VA: 0x18266EA80 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x2670290 Offset: 0x266E890 VA: 0x182670290 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x266E590 Offset: 0x266CB90 VA: 0x18266E590
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x266FFF0 Offset: 0x266E5F0 VA: 0x18266FFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2670500 Offset: 0x266EB00 VA: 0x182670500
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event Trigger")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 12271
{
	// Fields
	[FormerlySerializedAs("delegates")]
	[SerializeField]
	private List<EventTrigger.Entry> m_Delegates; // 0x20

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x2670E10 Offset: 0x266F410 VA: 0x182670E10
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }

	// RVA: 0x2670E20 Offset: 0x266F420 VA: 0x182670E20
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x2670B60 Offset: 0x266F160 VA: 0x182670B60
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x2670DA0 Offset: 0x266F3A0 VA: 0x182670DA0 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2670DB0 Offset: 0x266F3B0 VA: 0x182670DB0 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2670D30 Offset: 0x266F330 VA: 0x182670D30 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2670D40 Offset: 0x266F340 VA: 0x182670D40 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x2670D90 Offset: 0x266F390 VA: 0x182670D90 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2670DC0 Offset: 0x266F3C0 VA: 0x182670DC0 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2670D80 Offset: 0x266F380 VA: 0x182670D80 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2670DE0 Offset: 0x266F3E0 VA: 0x182670DE0 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2670D20 Offset: 0x266F320 VA: 0x182670D20 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2670DD0 Offset: 0x266F3D0 VA: 0x182670DD0 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2670D70 Offset: 0x266F370 VA: 0x182670D70 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x2670E00 Offset: 0x266F400 VA: 0x182670E00 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2670D60 Offset: 0x266F360 VA: 0x182670D60 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2670D00 Offset: 0x266F300 VA: 0x182670D00 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2670D50 Offset: 0x266F350 VA: 0x182670D50 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2670DF0 Offset: 0x266F3F0 VA: 0x182670DF0 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2670D10 Offset: 0x266F310 VA: 0x182670D10 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }
}

// Namespace: UnityEngine.EventSystems
public enum EventTriggerType // TypeDefIndex: 12272
{
	// Fields
	public int value__; // 0x0
	public const EventTriggerType PointerEnter = 0;
	public const EventTriggerType PointerExit = 1;
	public const EventTriggerType PointerDown = 2;
	public const EventTriggerType PointerUp = 3;
	public const EventTriggerType PointerClick = 4;
	public const EventTriggerType Drag = 5;
	public const EventTriggerType Drop = 6;
	public const EventTriggerType Scroll = 7;
	public const EventTriggerType UpdateSelected = 8;
	public const EventTriggerType Select = 9;
	public const EventTriggerType Deselect = 10;
	public const EventTriggerType Move = 11;
	public const EventTriggerType InitializePotentialDrag = 12;
	public const EventTriggerType BeginDrag = 13;
	public const EventTriggerType EndDrag = 14;
	public const EventTriggerType Submit = 15;
	public const EventTriggerType Cancel = 16;
}

// Namespace: UnityEngine.EventSystems
public static class ExecuteEvents // TypeDefIndex: 12274
{
	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x80
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FA960 Offset: 0x6F8F60 VA: 0x1806FA960
	|-ExecuteEvents.ValidateEventData<object>
	*/

	// RVA: 0x26710A0 Offset: 0x266F6A0 VA: 0x1826710A0
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x26713C0 Offset: 0x266F9C0 VA: 0x1826713C0
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x26711E0 Offset: 0x266F7E0 VA: 0x1826711E0
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671140 Offset: 0x266F740 VA: 0x182671140
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x26717F0 Offset: 0x266FDF0 VA: 0x1826717F0
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671320 Offset: 0x266F920 VA: 0x182671320
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671750 Offset: 0x266FD50 VA: 0x182671750
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671280 Offset: 0x266F880 VA: 0x182671280
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x26716B0 Offset: 0x266FCB0 VA: 0x1826716B0
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2670FA0 Offset: 0x266F5A0 VA: 0x182670FA0
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x26714C0 Offset: 0x266FAC0 VA: 0x1826714C0
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x2670F00 Offset: 0x266F500 VA: 0x182670F00
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671890 Offset: 0x266FE90 VA: 0x182671890
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671650 Offset: 0x266FC50 VA: 0x182671650
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x2670EA0 Offset: 0x266F4A0 VA: 0x182670EA0
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671560 Offset: 0x266FB60 VA: 0x182671560
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671460 Offset: 0x266FA60 VA: 0x182671460
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x2671040 Offset: 0x266F640 VA: 0x182671040
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x2672610 Offset: 0x2670C10 VA: 0x182672610
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x2672570 Offset: 0x2670B70 VA: 0x182672570
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x26725C0 Offset: 0x2670BC0 VA: 0x1826725C0
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x2672520 Offset: 0x2670B20 VA: 0x182672520
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x2672660 Offset: 0x2670C60 VA: 0x182672660
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x26724D0 Offset: 0x2670AD0 VA: 0x1826724D0
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x2672430 Offset: 0x2670A30 VA: 0x182672430
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x2672240 Offset: 0x2670840 VA: 0x182672240
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x2672340 Offset: 0x2670940 VA: 0x182672340
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x26723E0 Offset: 0x26709E0 VA: 0x1826723E0
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x2672390 Offset: 0x2670990 VA: 0x182672390
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x26726B0 Offset: 0x2670CB0 VA: 0x1826726B0
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x26727B0 Offset: 0x2670DB0 VA: 0x1826727B0
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x2672700 Offset: 0x2670D00 VA: 0x182672700
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x26722F0 Offset: 0x26708F0 VA: 0x1826722F0
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x2672480 Offset: 0x2670A80 VA: 0x182672480
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x2672750 Offset: 0x2670D50 VA: 0x182672750
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x2672290 Offset: 0x2670890 VA: 0x182672290
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x26718F0 Offset: 0x266FEF0 VA: 0x1826718F0
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F9C10 Offset: 0x6F8210 VA: 0x1806F9C10
	|-ExecuteEvents.Execute<object>
	|
	|-RVA: 0x6F97F0 Offset: 0x6F7DF0 VA: 0x1806F97F0
	|-ExecuteEvents.Execute<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F9680 Offset: 0x6F7C80 VA: 0x1806F9680
	|-ExecuteEvents.ExecuteHierarchy<object>
	|
	|-RVA: 0x6F9510 Offset: 0x6F7B10 VA: 0x1806F9510
	|-ExecuteEvents.ExecuteHierarchy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FA850 Offset: 0x6F8E50 VA: 0x1806FA850
	|-ExecuteEvents.ShouldSendToComponent<object>
	|-ExecuteEvents.ShouldSendToComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FA500 Offset: 0x6F8B00 VA: 0x1806FA500
	|-ExecuteEvents.GetEventList<object>
	|
	|-RVA: 0x6FA2A0 Offset: 0x6F88A0 VA: 0x1806FA2A0
	|-ExecuteEvents.GetEventList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F9420 Offset: 0x6F7A20 VA: 0x1806F9420
	|-ExecuteEvents.CanHandleEvent<object>
	|
	|-RVA: 0x6F9330 Offset: 0x6F7930 VA: 0x1806F9330
	|-ExecuteEvents.CanHandleEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FA0C0 Offset: 0x6F86C0 VA: 0x1806FA0C0
	|-ExecuteEvents.GetEventHandler<object>
	|
	|-RVA: 0x6F9F90 Offset: 0x6F8590 VA: 0x1806F9F90
	|-ExecuteEvents.GetEventHandler<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2671A60 Offset: 0x2670060 VA: 0x182671A60
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseInput : UIBehaviour // TypeDefIndex: 12275
{
	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x23A3FD0 Offset: 0x23A25D0 VA: 0x1823A3FD0 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x266DD00 Offset: 0x266C300 VA: 0x18266DD00 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x266DD60 Offset: 0x266C360 VA: 0x18266DD60 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x266DCF0 Offset: 0x266C2F0 VA: 0x18266DCF0 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x266DD40 Offset: 0x266C340 VA: 0x18266DD40 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x23A4010 Offset: 0x23A2610 VA: 0x1823A4010 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x23A3FA0 Offset: 0x23A25A0 VA: 0x1823A3FA0 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x23A3FB0 Offset: 0x23A25B0 VA: 0x1823A3FB0 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x23A3FC0 Offset: 0x23A25C0 VA: 0x1823A3FC0 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x266DD10 Offset: 0x266C310 VA: 0x18266DD10 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x23A4020 Offset: 0x23A2620 VA: 0x1823A4020 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x23A4030 Offset: 0x23A2630 VA: 0x1823A4030 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x16FD880 Offset: 0x16FBE80 VA: 0x1816FD880 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x16FD810 Offset: 0x16FBE10 VA: 0x1816FD810 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x23A3F30 Offset: 0x23A2530 VA: 0x1823A3F30 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x23A3F40 Offset: 0x23A2540 VA: 0x1823A3F40 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[RequireComponent(typeof(EventSystem))]
public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 12276
{
	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x20
	[SerializeField]
	private bool m_SendPointerHoverToParent; // 0x28
	private AxisEventData m_AxisEventData; // 0x30
	private EventSystem m_EventSystem; // 0x38
	private BaseEventData m_BaseEventData; // 0x40
	protected BaseInput m_InputOverride; // 0x48
	private BaseInput m_DefaultInput; // 0x50

	// Properties
	internal bool sendPointerHoverToParent { get; set; }
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x266DAD0 Offset: 0x266C0D0 VA: 0x18266DAD0
	public BaseInput get_input() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public BaseInput get_inputOverride() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	protected EventSystem get_eventSystem() { }

	// RVA: 0x266D9B0 Offset: 0x266BFB0 VA: 0x18266D9B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x266D990 Offset: 0x266BF90 VA: 0x18266D990 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x266CB20 Offset: 0x266B120 VA: 0x18266CB20
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x266C920 Offset: 0x266AF20 VA: 0x18266C920
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x266C8A0 Offset: 0x266AEA0 VA: 0x18266C8A0
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x266C990 Offset: 0x266AF90 VA: 0x18266C990
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x266CE60 Offset: 0x266B460 VA: 0x18266CE60
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x266CC60 Offset: 0x266B260 VA: 0x18266CC60 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x266CDB0 Offset: 0x266B3B0 VA: 0x18266CDB0 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x266DA10 Offset: 0x266C010 VA: 0x18266DA10 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x266C800 Offset: 0x266AE00 VA: 0x18266C800 Slot: 26
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x266DA50 Offset: 0x266C050 VA: 0x18266DA50
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 12280
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x58
	private readonly PointerInputModule.MouseState m_MouseState; // 0x60

	// Methods

	// RVA: 0x2679170 Offset: 0x2677770 VA: 0x182679170
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x2679A90 Offset: 0x2678090 VA: 0x182679A90
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x2679280 Offset: 0x2677880 VA: 0x182679280
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x2678750 Offset: 0x2676D50 VA: 0x182678750
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x2679AF0 Offset: 0x26780F0 VA: 0x182679AF0
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x26789D0 Offset: 0x2676FD0 VA: 0x1826789D0 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x26789F0 Offset: 0x2676FF0 VA: 0x1826789F0 Slot: 28
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x26789A0 Offset: 0x2676FA0 VA: 0x1826789A0
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x3822C0 Offset: 0x3808C0 VA: 0x1803822C0
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x2679A40 Offset: 0x2678040 VA: 0x182679A40 Slot: 29
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x2679770 Offset: 0x2677D70 VA: 0x182679770 Slot: 30
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x26796E0 Offset: 0x2677CE0 VA: 0x1826796E0 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x26785B0 Offset: 0x2676BB0 VA: 0x1826785B0
	protected void ClearSelection() { }

	// RVA: 0x2679BB0 Offset: 0x26781B0 VA: 0x182679BB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x26788C0 Offset: 0x2676EC0 VA: 0x1826788C0
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x2679E20 Offset: 0x2678420 VA: 0x182679E20
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Standalone Input Module")]
public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 12282
{
	// Fields
	private float m_PrevActionTime; // 0x68
	private Vector2 m_LastMoveVector; // 0x6C
	private int m_ConsecutiveMoveCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private Vector2 m_MousePosition; // 0x80
	private GameObject m_CurrentFocusedGameObject; // 0x88
	private PointerEventData m_InputPointerEvent; // 0x90
	private const float doubleClickTime = 0.3;
	[SerializeField]
	private string m_HorizontalAxis; // 0x98
	[SerializeField]
	private string m_VerticalAxis; // 0xA0
	[SerializeField]
	private string m_SubmitButton; // 0xA8
	[SerializeField]
	private string m_CancelButton; // 0xB0
	[SerializeField]
	private float m_InputActionsPerSecond; // 0xB8
	[SerializeField]
	private float m_RepeatDelay; // 0xBC
	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[HideInInspector]
	private bool m_ForceModuleActive; // 0xC0

	// Properties
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	public StandaloneInputModule.InputMode inputMode { get; }
	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice { get; set; }
	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x267DBD0 Offset: 0x267C1D0 VA: 0x18267DBD0
	protected void .ctor() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x1AA21F0 Offset: 0x1AA07F0 VA: 0x181AA21F0
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x24F83B0 Offset: 0x24F69B0 VA: 0x1824F83B0
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x1AA21F0 Offset: 0x1AA07F0 VA: 0x181AA21F0
	public bool get_forceModuleActive() { }

	// RVA: 0x24F83B0 Offset: 0x24F69B0 VA: 0x1824F83B0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x267DCC0 Offset: 0x267C2C0 VA: 0x18267DCC0
	public float get_inputActionsPerSecond() { }

	// RVA: 0x267DCE0 Offset: 0x267C2E0 VA: 0x18267DCE0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x267DCD0 Offset: 0x267C2D0 VA: 0x18267DCD0
	public float get_repeatDelay() { }

	// RVA: 0x267DCF0 Offset: 0x267C2F0 VA: 0x18267DCF0
	public void set_repeatDelay(float value) { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_horizontalAxis() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public void set_horizontalAxis(string value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public string get_verticalAxis() { }

	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	public void set_verticalAxis(string value) { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public string get_submitButton() { }

	// RVA: 0x163E0C0 Offset: 0x163C6C0 VA: 0x18163E0C0
	public void set_submitButton(string value) { }

	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0
	public string get_cancelButton() { }

	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	public void set_cancelButton(string value) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x267DA90 Offset: 0x267C090 VA: 0x18267DA90 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x267CD90 Offset: 0x267B390 VA: 0x18267CD90
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x267D860 Offset: 0x267BE60 VA: 0x18267D860 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x267B1A0 Offset: 0x26797A0 VA: 0x18267B1A0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x267B300 Offset: 0x2679900 VA: 0x18267B300 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x267CBB0 Offset: 0x267B1B0 VA: 0x18267CBB0 Slot: 17
	public override void Process() { }

	// RVA: 0x267BBA0 Offset: 0x267A1A0 VA: 0x18267BBA0
	private bool ProcessTouchEvents() { }

	// RVA: 0x267C480 Offset: 0x267AA80 VA: 0x18267C480
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x267D4C0 Offset: 0x267BAC0 VA: 0x18267D4C0
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x267B310 Offset: 0x2679910 VA: 0x18267B310
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x267D150 Offset: 0x267B750 VA: 0x18267D150
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x267B730 Offset: 0x2679D30 VA: 0x18267B730
	protected void ProcessMouseEvent() { }

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 31
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x267B480 Offset: 0x2679A80 VA: 0x18267B480
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x267D710 Offset: 0x267BD10 VA: 0x18267D710
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x267B740 Offset: 0x2679D40 VA: 0x18267B740
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	protected GameObject GetCurrentFocusedGameObject() { }
}

// Namespace: UnityEngine.EventSystems
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
[AddComponentMenu("Event/Touch Input Module")]
public class TouchInputModule : PointerInputModule // TypeDefIndex: 12283
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private PointerEventData m_InputPointerEvent; // 0x78
	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	private bool m_ForceModuleActive; // 0x80

	// Properties
	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x267F550 Offset: 0x267DB50 VA: 0x18267F550
	protected void .ctor() { }

	// RVA: 0x100F470 Offset: 0x100DA70 VA: 0x18100F470
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x100F480 Offset: 0x100DA80 VA: 0x18100F480
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x100F470 Offset: 0x100DA70 VA: 0x18100F470
	public bool get_forceModuleActive() { }

	// RVA: 0x100F480 Offset: 0x100DA80 VA: 0x18100F480
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x267F3B0 Offset: 0x267D9B0 VA: 0x18267F3B0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x267DE70 Offset: 0x267C470 VA: 0x18267DE70 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x267EFF0 Offset: 0x267D5F0 VA: 0x18267EFF0 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x267F510 Offset: 0x267DB10 VA: 0x18267F510
	private bool UseFakeInput() { }

	// RVA: 0x267EE40 Offset: 0x267D440 VA: 0x18267EE40 Slot: 17
	public override void Process() { }

	// RVA: 0x267DD00 Offset: 0x267C300 VA: 0x18267DD00
	private void FakeTouches() { }

	// RVA: 0x267DEC0 Offset: 0x267C4C0 VA: 0x18267DEC0
	private void ProcessTouchEvents() { }

	// RVA: 0x267E750 Offset: 0x267CD50 VA: 0x18267E750
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x267B300 Offset: 0x2679900 VA: 0x18267B300 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x267F110 Offset: 0x267D710 VA: 0x18267F110 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public enum MoveDirection // TypeDefIndex: 12284
{
	// Fields
	public int value__; // 0x0
	public const MoveDirection Left = 0;
	public const MoveDirection Up = 1;
	public const MoveDirection Right = 2;
	public const MoveDirection Down = 3;
	public const MoveDirection None = 4;
}

// Namespace: UnityEngine.EventSystems
public static class RaycasterManager // TypeDefIndex: 12285
{
	// Fields
	private static readonly List<BaseRaycaster> s_Raycasters; // 0x0

	// Methods

	// RVA: 0x267A720 Offset: 0x2678D20 VA: 0x18267A720
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x267A850 Offset: 0x2678E50 VA: 0x18267A850
	public static List<BaseRaycaster> GetRaycasters() { }

	// RVA: 0x267A8A0 Offset: 0x2678EA0 VA: 0x18267A8A0
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x267A970 Offset: 0x2678F70 VA: 0x18267A970
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 12286
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x20

	// Properties
	public abstract Camera eventCamera { get; }
	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x266E200 Offset: 0x266C800 VA: 0x18266E200 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x266E200 Offset: 0x266C800 VA: 0x18266E200 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x266E210 Offset: 0x266C810 VA: 0x18266E210
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x266DFD0 Offset: 0x266C5D0 VA: 0x18266DFD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x266DE70 Offset: 0x266C470 VA: 0x18266DE70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x266DD70 Offset: 0x266C370 VA: 0x18266DD70 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x195CFA0 Offset: 0x195B5A0 VA: 0x18195CFA0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x195CFA0 Offset: 0x195B5A0 VA: 0x18195CFA0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 12287
{
	// Fields
	private RaycastHit2D[] m_Hits; // 0x48

	// Methods

	// RVA: 0x26763F0 Offset: 0x26749F0 VA: 0x1826763F0
	protected void .ctor() { }

	// RVA: 0x2675BC0 Offset: 0x26741C0 VA: 0x182675BC0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics Raycaster")]
[RequireComponent(typeof(Camera))]
public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 12289
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x28
	[SerializeField]
	protected LayerMask m_EventMask; // 0x30
	[SerializeField]
	protected int m_MaxRayIntersections; // 0x34
	protected int m_LastMaxRayIntersections; // 0x38
	private RaycastHit[] m_Hits; // 0x40

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x26763F0 Offset: 0x26749F0 VA: 0x1826763F0
	protected void .ctor() { }

	// RVA: 0x2676D70 Offset: 0x2675370 VA: 0x182676D70 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x2676CB0 Offset: 0x26752B0 VA: 0x182676CB0 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x2676E40 Offset: 0x2675440 VA: 0x182676E40
	public int get_finalEventMask() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public LayerMask get_eventMask() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public int get_maxRayIntersections() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x2676420 Offset: 0x2674A20 VA: 0x182676420
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x26767A0 Offset: 0x2674DA0 VA: 0x1826767A0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: UnityEngine.EventSystems
public struct RaycastResult // TypeDefIndex: 12290
{
	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingGroupID; // 0x1C
	public int sortingGroupOrder; // 0x20
	public int sortingLayer; // 0x24
	public int sortingOrder; // 0x28
	public Vector3 worldPosition; // 0x2C
	public Vector3 worldNormal; // 0x38
	public Vector2 screenPosition; // 0x44
	public int displayIndex; // 0x4C

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public GameObject get_gameObject() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void set_gameObject(GameObject value) { }

	// RVA: 0x267A690 Offset: 0x2678C90 VA: 0x18267A690
	public bool get_isValid() { }

	// RVA: 0x267A040 Offset: 0x2678640 VA: 0x18267A040
	public void Clear() { }

	// RVA: 0x267A130 Offset: 0x2678730 VA: 0x18267A130 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 12291
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void OnDestroy() { }

	// RVA: 0x267F5F0 Offset: 0x267DBF0 VA: 0x18267F5F0 Slot: 9
	public virtual bool IsActive() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 14
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x267F600 Offset: 0x267DC00 VA: 0x18267F600 Slot: 16
	public bool IsDestroyed() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

