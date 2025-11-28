// Namespace: Rewired
public class ActionIdPropertyAttribute : PropertyAttribute // TypeDefIndex: 1720
{
	// Fields
	private Type CkcnhTByboCbxfEbygGRvfLFWvRH; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_Type() { }

	// RVA: 0x169A1F0 Offset: 0x16987F0 VA: 0x18169A1F0
	public void .ctor(Type ) { }
}

// Namespace: Rewired
public class PlayerIdPropertyAttribute : PropertyAttribute // TypeDefIndex: 1721
{
	// Fields
	private Type GVENUMMRUzBlrCmzwQvjpgRAdELl; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_Type() { }

	// RVA: 0x169A1F0 Offset: 0x16987F0 VA: 0x18169A1F0
	public void .ctor(Type ) { }
}

// Namespace: Rewired
public sealed class ControllerStatusChangedEventArgs : EventArgs // TypeDefIndex: 1722
{
	// Fields
	private string OqyXghGHHPwcJSBFjFojWdKFsOPs; // 0x10
	private int iXAVgsIWgELasbcfAfmXauTcmuqDA; // 0x18
	private ControllerType TBJGBmgQOKlmSbcCWSMuasdljEDyA; // 0x1C

	// Properties
	public string name { get; }
	public int controllerId { get; }
	public ControllerType controllerType { get; }
	public Controller controller { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_controllerId() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public ControllerType get_controllerType() { }

	// RVA: 0x16A4870 Offset: 0x16A2E70 VA: 0x1816A4870
	public Controller get_controller() { }

	// RVA: 0x16A47E0 Offset: 0x16A2DE0 VA: 0x1816A47E0
	public void .ctor(string , int , ControllerType ) { }
}

// Namespace: Rewired
public sealed class ControllerAssignmentChangedEventArgs : EventArgs // TypeDefIndex: 1723
{
	// Fields
	private bool vnTXmTIVMamUSoahuKZhtIUmoevS; // 0x10
	private int GOZIMkcfmJGQJZlEtnQQcoWPAJUJ; // 0x14
	private int rMmMcukjsYwNnJVgjKMqslAqqjdK; // 0x18
	private ControllerType SVathpbBPSHEJfLeeUcHKYOXFIbo; // 0x1C

	// Properties
	public bool state { get; }
	public Controller controller { get; }
	public Player player { get; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_state() { }

	// RVA: 0x16A29B0 Offset: 0x16A0FB0 VA: 0x1816A29B0
	public Controller get_controller() { }

	// RVA: 0x16A2A80 Offset: 0x16A1080 VA: 0x1816A2A80
	public Player get_player() { }

	// RVA: 0x16A2930 Offset: 0x16A0F30 VA: 0x1816A2930
	internal void .ctor(int , int , ControllerType , bool ) { }
}

// Namespace: Rewired
public struct InputActionEventData // TypeDefIndex: 1724
{
	// Fields
	private ksUUeloGhUnKxVlWzoyLhFoETsrR PuhyMvLSRdWzukCcSBfdAUZwfbSr; // 0x0
	private InputActionEventType bWRAJAyEyohDwetHGStDPTPKxRXU; // 0x8
	public readonly int playerId; // 0xC
	public readonly int actionId; // 0x10
	public readonly UpdateLoopType updateLoop; // 0x14

	// Properties
	public InputActionEventType eventType { get; set; }
	public Player player { get; }
	public string actionName { get; }
	public string actionDescriptiveName { get; }

	// Methods

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public InputActionEventType get_eventType() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	internal void ULnbFUrAdGTULcGdJBZmdRKFYAsO(InputActionEventType ) { }

	// RVA: 0x16A9BF0 Offset: 0x16A81F0 VA: 0x1816A9BF0
	public Player get_player() { }

	// RVA: 0x16A9B00 Offset: 0x16A8100 VA: 0x1816A9B00
	public string get_actionName() { }

	// RVA: 0x16A9A10 Offset: 0x16A8010 VA: 0x1816A9A10
	public string get_actionDescriptiveName() { }

	// RVA: 0x16A9000 Offset: 0x16A7600 VA: 0x1816A9000
	public float GetAxis() { }

	// RVA: 0x16A8EC0 Offset: 0x16A74C0 VA: 0x1816A8EC0
	public float GetAxisPrev() { }

	// RVA: 0x16A8EA0 Offset: 0x16A74A0 VA: 0x1816A8EA0
	public float GetAxisDelta() { }

	// RVA: 0x16A8FC0 Offset: 0x16A75C0 VA: 0x1816A8FC0
	public double GetAxisTimeActive() { }

	// RVA: 0x16A8FE0 Offset: 0x16A75E0 VA: 0x1816A8FE0
	public double GetAxisTimeInactive() { }

	// RVA: 0x16A8FA0 Offset: 0x16A75A0 VA: 0x1816A8FA0
	public float GetAxisRaw() { }

	// RVA: 0x16A8F20 Offset: 0x16A7520 VA: 0x1816A8F20
	public float GetAxisRawDelta() { }

	// RVA: 0x16A8F40 Offset: 0x16A7540 VA: 0x1816A8F40
	public float GetAxisRawPrev() { }

	// RVA: 0x16A8F60 Offset: 0x16A7560 VA: 0x1816A8F60
	public double GetAxisRawTimeActive() { }

	// RVA: 0x16A8F80 Offset: 0x16A7580 VA: 0x1816A8F80
	public double GetAxisRawTimeInactive() { }

	// RVA: 0x16A8E80 Offset: 0x16A7480 VA: 0x1816A8E80
	public AxisCoordinateMode GetAxisCoordinateMode() { }

	// RVA: 0x16A8E60 Offset: 0x16A7460 VA: 0x1816A8E60
	public AxisCoordinateMode GetAxisCoordinateModePrev() { }

	// RVA: 0x16A8F00 Offset: 0x16A7500 VA: 0x1816A8F00
	public AxisCoordinateMode GetAxisRawCoordinateMode() { }

	// RVA: 0x16A8EE0 Offset: 0x16A74E0 VA: 0x1816A8EE0
	public AxisCoordinateMode GetAxisRawCoordinateModePrev() { }

	// RVA: 0x16A9380 Offset: 0x16A7980 VA: 0x1816A9380
	public bool GetButton() { }

	// RVA: 0x16A9160 Offset: 0x16A7760 VA: 0x1816A9160
	public bool GetButtonPrev() { }

	// RVA: 0x16A90E0 Offset: 0x16A76E0 VA: 0x1816A90E0
	public bool GetButtonDown() { }

	// RVA: 0x16A9360 Offset: 0x16A7960 VA: 0x1816A9360
	public bool GetButtonUp() { }

	// RVA: 0x16A9220 Offset: 0x16A7820 VA: 0x1816A9220
	public bool GetButtonSinglePressHold() { }

	// RVA: 0x16A9200 Offset: 0x16A7800 VA: 0x1816A9200
	public bool GetButtonSinglePressDown() { }

	// RVA: 0x16A9240 Offset: 0x16A7840 VA: 0x1816A9240
	public bool GetButtonSinglePressUp() { }

	// RVA: 0x16A9020 Offset: 0x16A7620 VA: 0x1816A9020
	public bool GetButtonDoublePressDown() { }

	// RVA: 0x16A9040 Offset: 0x16A7640 VA: 0x1816A9040
	public bool GetButtonDoublePressDown(float speed) { }

	// RVA: 0x16A9060 Offset: 0x16A7660 VA: 0x1816A9060
	public bool GetButtonDoublePressHold() { }

	// RVA: 0x16A9080 Offset: 0x16A7680 VA: 0x1816A9080
	public bool GetButtonDoublePressHold(float speed) { }

	// RVA: 0x16A90A0 Offset: 0x16A76A0 VA: 0x1816A90A0
	public bool GetButtonDoublePressUp() { }

	// RVA: 0x16A90C0 Offset: 0x16A76C0 VA: 0x1816A90C0
	public bool GetButtonDoublePressUp(float speed) { }

	// RVA: 0x16A9310 Offset: 0x16A7910 VA: 0x1816A9310
	public bool GetButtonTimedPress(float time) { }

	// RVA: 0x16A9340 Offset: 0x16A7940 VA: 0x1816A9340
	public bool GetButtonTimedPress(float time, float expireIn) { }

	// RVA: 0x16A92A0 Offset: 0x16A78A0 VA: 0x1816A92A0
	public bool GetButtonTimedPressDown(float time) { }

	// RVA: 0x16A92C0 Offset: 0x16A78C0 VA: 0x1816A92C0
	public bool GetButtonTimedPressUp(float time) { }

	// RVA: 0x16A92F0 Offset: 0x16A78F0 VA: 0x1816A92F0
	public bool GetButtonTimedPressUp(float time, float expireIn) { }

	// RVA: 0x16A91E0 Offset: 0x16A77E0 VA: 0x1816A91E0
	public bool GetButtonShortPress() { }

	// RVA: 0x16A91A0 Offset: 0x16A77A0 VA: 0x1816A91A0
	public bool GetButtonShortPressDown() { }

	// RVA: 0x16A91C0 Offset: 0x16A77C0 VA: 0x1816A91C0
	public bool GetButtonShortPressUp() { }

	// RVA: 0x16A9140 Offset: 0x16A7740 VA: 0x1816A9140
	public bool GetButtonLongPress() { }

	// RVA: 0x16A9100 Offset: 0x16A7700 VA: 0x1816A9100
	public bool GetButtonLongPressDown() { }

	// RVA: 0x16A9120 Offset: 0x16A7720 VA: 0x1816A9120
	public bool GetButtonLongPressUp() { }

	// RVA: 0x16A9180 Offset: 0x16A7780 VA: 0x1816A9180
	public bool GetButtonRepeating() { }

	// RVA: 0x16A9260 Offset: 0x16A7860 VA: 0x1816A9260
	public double GetButtonTimePressed() { }

	// RVA: 0x16A9280 Offset: 0x16A7880 VA: 0x1816A9280
	public double GetButtonTimeUnpressed() { }

	// RVA: 0x16A9790 Offset: 0x16A7D90 VA: 0x1816A9790
	public bool GetNegativeButton() { }

	// RVA: 0x16A9570 Offset: 0x16A7B70 VA: 0x1816A9570
	public bool GetNegativeButtonPrev() { }

	// RVA: 0x16A94F0 Offset: 0x16A7AF0 VA: 0x1816A94F0
	public bool GetNegativeButtonDown() { }

	// RVA: 0x16A9770 Offset: 0x16A7D70 VA: 0x1816A9770
	public bool GetNegativeButtonUp() { }

	// RVA: 0x16A9630 Offset: 0x16A7C30 VA: 0x1816A9630
	public bool GetNegativeButtonSinglePressHold() { }

	// RVA: 0x16A9610 Offset: 0x16A7C10 VA: 0x1816A9610
	public bool GetNegativeButtonSinglePressDown() { }

	// RVA: 0x16A9650 Offset: 0x16A7C50 VA: 0x1816A9650
	public bool GetNegativeButtonSinglePressUp() { }

	// RVA: 0x16A9450 Offset: 0x16A7A50 VA: 0x1816A9450
	public bool GetNegativeButtonDoublePressDown() { }

	// RVA: 0x16A9430 Offset: 0x16A7A30 VA: 0x1816A9430
	public bool GetNegativeButtonDoublePressDown(float speed) { }

	// RVA: 0x16A9470 Offset: 0x16A7A70 VA: 0x1816A9470
	public bool GetNegativeButtonDoublePressHold() { }

	// RVA: 0x16A9490 Offset: 0x16A7A90 VA: 0x1816A9490
	public bool GetNegativeButtonDoublePressHold(float speed) { }

	// RVA: 0x16A94B0 Offset: 0x16A7AB0 VA: 0x1816A94B0
	public bool GetNegativeButtonDoublePressUp() { }

	// RVA: 0x16A94D0 Offset: 0x16A7AD0 VA: 0x1816A94D0
	public bool GetNegativeButtonDoublePressUp(float speed) { }

	// RVA: 0x16A9720 Offset: 0x16A7D20 VA: 0x1816A9720
	public bool GetNegativeButtonTimedPress(float time) { }

	// RVA: 0x16A9750 Offset: 0x16A7D50 VA: 0x1816A9750
	public bool GetNegativeButtonTimedPress(float time, float expireIn) { }

	// RVA: 0x16A96B0 Offset: 0x16A7CB0 VA: 0x1816A96B0
	public bool GetNegativeButtonTimedPressDown(float time) { }

	// RVA: 0x16A96D0 Offset: 0x16A7CD0 VA: 0x1816A96D0
	public bool GetNegativeButtonTimedPressUp(float time) { }

	// RVA: 0x16A9700 Offset: 0x16A7D00 VA: 0x1816A9700
	public bool GetNegativeButtonTimedPressUp(float time, float expireIn) { }

	// RVA: 0x16A95F0 Offset: 0x16A7BF0 VA: 0x1816A95F0
	public bool GetNegativeButtonShortPress() { }

	// RVA: 0x16A95B0 Offset: 0x16A7BB0 VA: 0x1816A95B0
	public bool GetNegativeButtonShortPressDown() { }

	// RVA: 0x16A95D0 Offset: 0x16A7BD0 VA: 0x1816A95D0
	public bool GetNegativeButtonShortPressUp() { }

	// RVA: 0x16A9550 Offset: 0x16A7B50 VA: 0x1816A9550
	public bool GetNegativeButtonLongPress() { }

	// RVA: 0x16A9510 Offset: 0x16A7B10 VA: 0x1816A9510
	public bool GetNegativeButtonLongPressDown() { }

	// RVA: 0x16A9530 Offset: 0x16A7B30 VA: 0x1816A9530
	public bool GetNegativeButtonLongPressUp() { }

	// RVA: 0x16A9590 Offset: 0x16A7B90 VA: 0x1816A9590
	public bool GetNegativeButtonRepeating() { }

	// RVA: 0x16A9670 Offset: 0x16A7C70 VA: 0x1816A9670
	public double GetNegativeButtonTimePressed() { }

	// RVA: 0x16A9690 Offset: 0x16A7C90 VA: 0x1816A9690
	public double GetNegativeButtonTimeUnpressed() { }

	// RVA: 0x16A93A0 Offset: 0x16A79A0 VA: 0x1816A93A0
	public IList<InputActionSourceData> GetCurrentInputSources() { }

	// RVA: 0x16A9920 Offset: 0x16A7F20 VA: 0x1816A9920
	public bool IsCurrentInputSource(ControllerType controllerType) { }

	// RVA: 0x16A9860 Offset: 0x16A7E60 VA: 0x1816A9860
	public bool IsCurrentInputSource(ControllerType controllerType, int controllerId) { }

	// RVA: 0x16A97B0 Offset: 0x16A7DB0 VA: 0x1816A97B0
	public bool IsCurrentInputSource(Controller controller) { }

	// RVA: 0x16A99C0 Offset: 0x16A7FC0 VA: 0x1816A99C0
	internal void .ctor(ksUUeloGhUnKxVlWzoyLhFoETsrR , int , int , UpdateLoopType ) { }
}

// Namespace: Rewired
public struct ControllerPollingInfo // TypeDefIndex: 1725
{
	// Fields
	private bool dZPwnpBBWcjbTDRTwrtfXoKVDkOG; // 0x0
	private int XznALMigXOFpXdUxUhZqhJBmIOGD; // 0x4
	private int takGHkxvKUCGXDmzeBBaBPxBDRpoA; // 0x8
	private string jmKcYKuGaFQhcOSqFXWjxaNtwhSp; // 0x10
	private ControllerType EdvopBzNRzTeJyoLGVvFRMFgfypS; // 0x18
	private ControllerElementType zRKBKNYzHBlamgEPnsIYmLlKBbUB; // 0x1C
	private int xczdoOtlPVzpzCqpjWetkKGfsKlF; // 0x20
	private Pole kSsDHRgzYbEVBFwFYoBmJBKbqHxmA; // 0x24
	private string kYhOuCmGstkjngIWSgmKaAFBzUnCA; // 0x28
	private int SuMCypVLKCBKCafNdvGgrkCablSoA; // 0x30
	private KeyCode qXfUcUfJKuQOjRFFXysVTxVSfalv; // 0x34

	// Properties
	public bool success { get; set; }
	public int playerId { get; set; }
	public int controllerId { get; set; }
	public string controllerName { get; set; }
	public ControllerType controllerType { get; set; }
	public ControllerElementType elementType { get; set; }
	public int elementIndex { get; set; }
	public Pole axisPole { get; set; }
	public string elementIdentifierName { get; set; }
	public int elementIdentifierId { get; set; }
	public KeyCode keyboardKey { get; set; }
	public Player player { get; }
	public Controller controller { get; }
	public ControllerElementIdentifier elementIdentifier { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_success() { }

	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	internal void onCaCgepsYfDaomNiWNUPYPTaFeXA(bool ) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_playerId() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	internal void XfusaqZyKacWwbVuRnoNWqILORbd(int ) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_controllerId() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	internal void vUsjqoZbHqupirvlOPvGcaicgGeeA(int ) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_controllerName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void hhQNYEucTybzUKcxwBgxeWbGkXbJA(string ) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public ControllerType get_controllerType() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	internal void hVZBweQbniDSNduuuwKbFNsgAPEq(ControllerType ) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public ControllerElementType get_elementType() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	internal void rxAenkcdGqUsASFyAoczmHseDhkKA(ControllerElementType ) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_elementIndex() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	internal void JjaCRlUqIlCyPtwyLaxLeYVuTSeuA(int ) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public Pole get_axisPole() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	internal void jWBNmAbgtVRUYXFCrTfZTpetxsCK(Pole ) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_elementIdentifierName() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void CNCfmolVzRMUhDovDlVTpIrSqitC(string ) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_elementIdentifierId() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	internal void qprGqYqiJmPGCMtNluYBbeTbRgTU(int ) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public KeyCode get_keyboardKey() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	internal void sZQyoLqCJIAjhfIQPSIqkByylJeV(KeyCode ) { }

	// RVA: 0x16A2EF0 Offset: 0x16A14F0 VA: 0x1816A2EF0
	public Player get_player() { }

	// RVA: 0x16A2D70 Offset: 0x16A1370 VA: 0x1816A2D70
	public Controller get_controller() { }

	// RVA: 0x16A2E40 Offset: 0x16A1440 VA: 0x1816A2E40
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x16A2C80 Offset: 0x16A1280 VA: 0x1816A2C80
	internal void .ctor(bool , int , int , string , ControllerType , ControllerElementType , int , Pole , string , int , KeyCode ) { }

	// RVA: 0x16A2CF0 Offset: 0x16A12F0 VA: 0x1816A2CF0
	internal void .ctor(ControllerPollingInfo ) { }

	// RVA: 0x16A2BF0 Offset: 0x16A11F0 VA: 0x1816A2BF0
	internal static ControllerPollingInfo UFfPPFyuSNhxHNxTdsaPnlMzdiJz() { }
}

// Namespace: Rewired
public struct ElementAssignmentConflictInfo // TypeDefIndex: 1726
{
	// Fields
	private bool CYLXbaXOwVpFAXZaRcbePWxRBvaN; // 0x0
	private bool QLJQbjBzhZDwglNZItyIcdYXFpmA; // 0x1
	private int ebmYDVYDRGhHlzipMcytEeqVkemJA; // 0x4
	private ControllerType ZIYDvVUNpHrVznfTceplRvKlAYkCA; // 0x8
	private int CtDhdiHysdIzBqnLIpcnieCKacipb; // 0xC
	private int bzUqsPmARNoIjuRhagcnJvLGvKeA; // 0x10
	private int sbhovmfGiflFiIUvNmXzMMNCgzbR; // 0x14
	private ControllerElementType xltwrDeMBHiEDQTEHiLSfIMStgKPA; // 0x18
	private int odzqbZHHFBpSzXptQOAboHTSvcze; // 0x1C
	private KeyCode dVwajEbYTzJutxzQMfyznXmyMdZp; // 0x20
	private ModifierKeyFlags duYGhfjklCGsPeiEqJaWHpzfKTHtb; // 0x24
	private int zDxuHQtfLjjmAPViKvynnpswjTmI; // 0x28

	// Properties
	public bool isConflict { get; set; }
	public bool isUserAssignable { get; set; }
	public int playerId { get; set; }
	public ControllerType controllerType { get; set; }
	public int controllerId { get; set; }
	public int controllerMapId { get; set; }
	public int elementMapId { get; set; }
	public ControllerElementType elementType { get; set; }
	public int elementIdentifierId { get; set; }
	public KeyCode keyCode { get; set; }
	public ModifierKeyFlags modifierKeyFlags { get; set; }
	public int actionId { get; set; }
	public Player player { get; }
	public InputAction action { get; }
	public Controller controller { get; }
	public ControllerMap controllerMap { get; }
	public ControllerElementIdentifier elementIdentifier { get; }
	public ActionElementMap elementMap { get; }
	public string elementDisplayName { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_isConflict() { }

	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	internal void lPQwrlRcLbVCJhgcunYNwdmXAlqgA(bool ) { }

	// RVA: 0x12B1970 Offset: 0x12AFF70 VA: 0x1812B1970
	public bool get_isUserAssignable() { }

	// RVA: 0x16A56B0 Offset: 0x16A3CB0 VA: 0x1816A56B0
	internal void veFeKrkxcXypmwwwXEKlCmVJYJwr(bool ) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_playerId() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	internal void BNvVqcBoMIIWxFHhlSkxqTzgiwLzA(int ) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public ControllerType get_controllerType() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	internal void wQqzLodNMdyHsWaUBJjGEcFeaLGcA(ControllerType ) { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_controllerId() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	internal void rOXbwYbyopIRFHylOWYdPnuCnfwGb(int ) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_controllerMapId() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void rSFtVzPadIlJtaVDonKRFErEUjPk(int ) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_elementMapId() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	internal void FDwjZCmbxXhzNaJEbPwYBWiUDSnR(int ) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public ControllerElementType get_elementType() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	internal void dGmSWkrcmLSMktwfRzUGbrCmFiXC(ControllerElementType ) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_elementIdentifierId() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	internal void KgTwvVLoqZdJugXHdDhbyvedKjMRA(int ) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public KeyCode get_keyCode() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	internal void EMcZhvqwoyPPhMotRGLGUUQnzied(KeyCode ) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	internal void EVGQAujjdfKuMRMkSZkixpEsmTno(ModifierKeyFlags ) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_actionId() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	internal void ceNVMnNJLrbgPwcxXmLHckUxMxme(int ) { }

	// RVA: 0x16A55E0 Offset: 0x16A3BE0 VA: 0x1816A55E0
	public Player get_player() { }

	// RVA: 0x16A5220 Offset: 0x16A3820 VA: 0x1816A5220
	public InputAction get_action() { }

	// RVA: 0x16A5360 Offset: 0x16A3960 VA: 0x1816A5360
	public Controller get_controller() { }

	// RVA: 0x16A52F0 Offset: 0x16A38F0 VA: 0x1816A52F0
	public ControllerMap get_controllerMap() { }

	// RVA: 0x16A54B0 Offset: 0x16A3AB0 VA: 0x1816A54B0
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x16A5500 Offset: 0x16A3B00 VA: 0x1816A5500
	public ActionElementMap get_elementMap() { }

	// RVA: 0x16A5430 Offset: 0x16A3A30 VA: 0x1816A5430
	public string get_elementDisplayName() { }

	// RVA: 0x16A5180 Offset: 0x16A3780 VA: 0x1816A5180
	public void .ctor(bool , bool , int , ControllerType , int , int , int , int , ControllerElementType , int , KeyCode , ModifierKeyFlags ) { }

	// RVA: 0x16A51D0 Offset: 0x16A37D0 VA: 0x1816A51D0
	public void .ctor(ElementAssignmentConflictInfo ) { }
}

// Namespace: Rewired
public struct ElementAssignmentConflictCheck // TypeDefIndex: 1727
{
	// Fields
	private ElementAssignmentType ijbuwnLnuoxLChjLmTqAdKpEVuQj; // 0x0
	private int aHaTdohxCxcgWYPILhZdsWvxmhji; // 0x4
	private ControllerType SvYhcygZgGbAAKNFPdERvIInQKej; // 0x8
	private int DEtLrmNmbsJDAWQVcJAWvpYMsKYX; // 0xC
	private int oarTrGaaUPNEuYohIetgoMXGDpWk; // 0x10
	private int oqofhdeyMMFeCrdWFRGYFrXheRZvA; // 0x14
	private int axOeJuBSVdBBXfJwCAKOxPBpnLJy; // 0x18
	private int gzEOWsPEaKhuThLHIgmCWevuyhVV; // 0x1C
	private AxisRange QtOhfOMHDxieEiGMGmpzImSiGsAIB; // 0x20
	private KeyCode neNLJfKcGelEVVZzspPoTVmzUqzw; // 0x24
	private ModifierKeyFlags mhjFxniZNeKBrXYlWbCVRBgqDeYQ; // 0x28
	private int MGiFYoDxASrNHllLESjiJUGrrJDHA; // 0x2C
	private Pole EqsbUjZPQiGUtgxUNTALJjEPTKZVA; // 0x30
	private bool JoabtkWZylxVFXYfqIEuxvlZWeFl; // 0x34

	// Properties
	public ElementAssignmentType elementAssignmentType { get; set; }
	public int playerId { get; set; }
	public ControllerType controllerType { get; set; }
	public int controllerId { get; set; }
	public int controllerMapId { get; set; }
	public int controllerMapCategoryId { get; set; }
	public int elementMapId { get; set; }
	public int elementIdentifierId { get; set; }
	public AxisRange axisRange { get; set; }
	public KeyCode keyboardKey { get; set; }
	public ModifierKeyFlags modifierKeyFlags { get; set; }
	public int actionId { get; set; }
	public Pole axisContribution { get; set; }
	public bool invert { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public ElementAssignmentType get_elementAssignmentType() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_elementAssignmentType(ElementAssignmentType value) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_playerId() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_playerId(int value) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public ControllerType get_controllerType() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_controllerId() { }

	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	public void set_controllerId(int value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_controllerMapId() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_controllerMapId(int value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_controllerMapCategoryId() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_controllerMapCategoryId(int value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_elementMapId() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_elementMapId(int value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_elementIdentifierId() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_elementIdentifierId(int value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public AxisRange get_axisRange() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public KeyCode get_keyboardKey() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_keyboardKey(KeyCode value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_modifierKeyFlags(ModifierKeyFlags value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_actionId() { }

	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	public void set_actionId(int value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public Pole get_axisContribution() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_axisContribution(Pole value) { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_invert() { }

	// RVA: 0x16A5170 Offset: 0x16A3770 VA: 0x1816A5170
	public void set_invert(bool value) { }

	// RVA: 0x16A50E0 Offset: 0x16A36E0 VA: 0x1816A50E0
	public void .ctor(int , ControllerType , int , int , ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x16A4CA0 Offset: 0x16A32A0 VA: 0x1816A4CA0
	public void .ctor(int , ControllerType , int , int , ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x16A5040 Offset: 0x16A3640 VA: 0x1816A5040
	public void .ctor(int , ControllerType , int , int , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x16A4EF0 Offset: 0x16A34F0 VA: 0x1816A4EF0
	public void .ctor(int , ControllerType , int , int , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x16A4DD0 Offset: 0x16A33D0 VA: 0x1816A4DD0
	public void .ctor(int , ControllerType , int , int , int , int , bool ) { }

	// RVA: 0x16A4D10 Offset: 0x16A3310 VA: 0x1816A4D10
	public void .ctor(int , ControllerType , int , int , int , int , bool , int ) { }

	// RVA: 0x16A4E30 Offset: 0x16A3430 VA: 0x1816A4E30
	public void .ctor(int , ControllerType , int , int , int , AxisRange , int , Pole ) { }

	// RVA: 0x16A4BE0 Offset: 0x16A31E0 VA: 0x1816A4BE0
	public void .ctor(int , ControllerType , int , int , int , AxisRange , int , Pole , int ) { }

	// RVA: 0x16A4E90 Offset: 0x16A3490 VA: 0x1816A4E90
	public void .ctor(int , ControllerType , int , int , int , int , Pole ) { }

	// RVA: 0x16A4D70 Offset: 0x16A3370 VA: 0x1816A4D70
	public void .ctor(int , ControllerType , int , int , int , int , Pole , int ) { }

	// RVA: 0x16A4B70 Offset: 0x16A3170 VA: 0x1816A4B70
	public void .ctor(int , ControllerType , int , int , KeyCode , ModifierKeyFlags , int , Pole ) { }

	// RVA: 0x16A4FD0 Offset: 0x16A35D0 VA: 0x1816A4FD0
	public void .ctor(int , ControllerType , int , int , KeyCode , ModifierKeyFlags , int , Pole , int ) { }

	// RVA: 0x16A4C40 Offset: 0x16A3240 VA: 0x1816A4C40
	public void .ctor(ElementAssignmentConflictCheck ) { }

	// RVA: 0x16A4A00 Offset: 0x16A3000 VA: 0x1816A4A00
	public ElementAssignment ToElementAssignment() { }

	// RVA: 0x16A4A80 Offset: 0x16A3080 VA: 0x1816A4A80
	public ElementAssignment ToFullAxisAssignment() { }

	// RVA: 0x16A4B30 Offset: 0x16A3130 VA: 0x1816A4B30
	public ElementAssignment ToSplitAxisAssignment() { }

	// RVA: 0x16A4990 Offset: 0x16A2F90 VA: 0x1816A4990
	public ElementAssignment ToButtonAssignment() { }

	// RVA: 0x16A4AC0 Offset: 0x16A30C0 VA: 0x1816A4AC0
	public ElementAssignment ToKeyboardKeyAssignment() { }

	// RVA: 0x16A5150 Offset: 0x16A3750 VA: 0x1816A5150
	private void dCsezwROzQAbyJIsDmFhsMOslYwM() { }
}

// Namespace: Rewired
public struct ElementAssignment // TypeDefIndex: 1728
{
	// Fields
	public ElementAssignmentType type; // 0x0
	public int elementMapId; // 0x4
	public int elementIdentifierId; // 0x8
	public AxisRange axisRange; // 0xC
	public KeyCode keyboardKey; // 0x10
	public ModifierKeyFlags modifierKeyFlags; // 0x14
	public int actionId; // 0x18
	public Pole axisContribution; // 0x1C
	public bool invert; // 0x20

	// Methods

	// RVA: 0x16A6220 Offset: 0x16A4820 VA: 0x1816A6220
	public void .ctor(ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x16A6260 Offset: 0x16A4860 VA: 0x1816A6260
	public void .ctor(ControllerType , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool , int ) { }

	// RVA: 0x16A6500 Offset: 0x16A4B00 VA: 0x1816A6500
	public void .ctor(ElementAssignmentType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x16A62E0 Offset: 0x16A48E0 VA: 0x1816A62E0
	public void .ctor(ControllerType , ControllerElementType , int , AxisRange , KeyCode , ModifierKeyFlags , int , Pole , bool ) { }

	// RVA: 0x16A64D0 Offset: 0x16A4AD0 VA: 0x1816A64D0
	public void .ctor(int , int , bool ) { }

	// RVA: 0x16A6390 Offset: 0x16A4990 VA: 0x1816A6390
	public void .ctor(int , int , bool , int ) { }

	// RVA: 0x16A6360 Offset: 0x16A4960 VA: 0x1816A6360
	public void .ctor(int , AxisRange , int , Pole ) { }

	// RVA: 0x16A63C0 Offset: 0x16A49C0 VA: 0x1816A63C0
	public void .ctor(int , AxisRange , int , Pole , int ) { }

	// RVA: 0x16A64A0 Offset: 0x16A4AA0 VA: 0x1816A64A0
	public void .ctor(int , int , Pole ) { }

	// RVA: 0x16A63F0 Offset: 0x16A49F0 VA: 0x1816A63F0
	public void .ctor(int , int , Pole , int ) { }

	// RVA: 0x16A6420 Offset: 0x16A4A20 VA: 0x1816A6420
	public void .ctor(KeyCode , ModifierKeyFlags , int , Pole ) { }

	// RVA: 0x16A6540 Offset: 0x16A4B40 VA: 0x1816A6540
	public void .ctor(KeyCode , ModifierKeyFlags , int , Pole , int ) { }

	// RVA: 0x16A5E90 Offset: 0x16A4490 VA: 0x1816A5E90
	public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) { }

	// RVA: 0x16A5E00 Offset: 0x16A4400 VA: 0x1816A5E00
	public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) { }

	// RVA: 0x16A5F70 Offset: 0x16A4570 VA: 0x1816A5F70
	public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert) { }

	// RVA: 0x16A5EE0 Offset: 0x16A44E0 VA: 0x1816A5EE0
	public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert) { }

	// RVA: 0x16A5FC0 Offset: 0x16A45C0 VA: 0x1816A5FC0
	public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert) { }

	// RVA: 0x16A5FF0 Offset: 0x16A45F0 VA: 0x1816A5FF0
	public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId) { }

	// RVA: 0x16A6180 Offset: 0x16A4780 VA: 0x1816A6180
	public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution) { }

	// RVA: 0x16A6140 Offset: 0x16A4740 VA: 0x1816A6140
	public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId) { }

	// RVA: 0x16A5D80 Offset: 0x16A4380 VA: 0x1816A5D80
	public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution) { }

	// RVA: 0x16A5DC0 Offset: 0x16A43C0 VA: 0x1816A5DC0
	public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId) { }

	// RVA: 0x16A60B0 Offset: 0x16A46B0 VA: 0x1816A60B0
	public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution) { }

	// RVA: 0x16A6020 Offset: 0x16A4620 VA: 0x1816A6020
	public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId) { }

	// RVA: 0x16A61C0 Offset: 0x16A47C0 VA: 0x1816A61C0
	public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck() { }
}

// Namespace: Rewired
public sealed class ElementAssignmentInfo // TypeDefIndex: 1729
{
	// Fields
	private readonly ControllerMap VcoEqHsQQYyycwygferrDYRIApRy; // 0x10
	private readonly ControllerElementType yRjxufMKjdjmlCHZnPAcZchGzCEJA; // 0x18
	private readonly int TQebltOfkXZtKZAcBqFStYLAZRp; // 0x1C
	private readonly int fjYEUYGjkoleUkyIqxDeTTPdXNqMA; // 0x20
	private readonly AxisRange cmoIfcOlVyEAHmZHdfpBPEVuUoIG; // 0x24
	private readonly KeyCode oqPAlZjtGKOirKvwFbRfiAdidDIT; // 0x28
	private readonly ModifierKeyFlags ORxfARJUGgwvfOebswuACVkvcmRcb; // 0x2C
	private readonly int usFAwwzGUfxvOKKLqsNCqLeNADBt; // 0x30
	private readonly Pole BQJyQjybpwaAfChXpjUnQhxAwhUV; // 0x34
	private readonly bool twSIhrxBjyLrtJWkaonkHEbJAfnb; // 0x38

	// Properties
	public Player player { get; }
	public InputAction action { get; }
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public int controllerId { get; }
	public ControllerMap controllerMap { get; }
	public ControllerElementIdentifier elementIdentifier { get; }
	public ActionElementMap elementMap { get; }
	public ControllerElementType elementType { get; }
	public Pole axisContribution { get; }
	public AxisRange axisRange { get; }
	public bool invert { get; }
	public KeyCode keyCode { get; }
	public ModifierKeyFlags modifierKeyFlags { get; }
	public string elementDisplayName { get; }

	// Methods

	// RVA: 0x16A5CE0 Offset: 0x16A42E0 VA: 0x1816A5CE0
	public Player get_player() { }

	// RVA: 0x16A57F0 Offset: 0x16A3DF0 VA: 0x1816A57F0
	public InputAction get_action() { }

	// RVA: 0x16A5A10 Offset: 0x16A4010 VA: 0x1816A5A10
	public Controller get_controller() { }

	// RVA: 0x16A5970 Offset: 0x16A3F70 VA: 0x1816A5970
	public ControllerType get_controllerType() { }

	// RVA: 0x16A58C0 Offset: 0x16A3EC0 VA: 0x1816A58C0
	public int get_controllerId() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ControllerMap get_controllerMap() { }

	// RVA: 0x16A5C60 Offset: 0x16A4260 VA: 0x1816A5C60
	public ControllerElementIdentifier get_elementIdentifier() { }

	// RVA: 0x16A5CB0 Offset: 0x16A42B0 VA: 0x1816A5CB0
	public ActionElementMap get_elementMap() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public ControllerElementType get_elementType() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public Pole get_axisContribution() { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public AxisRange get_axisRange() { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_invert() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public KeyCode get_keyCode() { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x16A5B20 Offset: 0x16A4120 VA: 0x1816A5B20
	public string get_elementDisplayName() { }

	// RVA: 0x16A56C0 Offset: 0x16A3CC0 VA: 0x1816A56C0
	internal void .ctor(ControllerMap , ElementAssignment ) { }
}

// Namespace: Rewired
public struct InputActionSourceData // TypeDefIndex: 1730
{
	// Fields
	private Controller dBDMDuMaGygpnMNpaRLgoiqozrDp; // 0x0
	private ControllerMap kqFMDdZplBDHyPKIXtbheZPTaUIs; // 0x8
	private ActionElementMap VsEugCLKjvPoVmzfGjbocBYWmlsC; // 0x10

	// Properties
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public ControllerMap controllerMap { get; }
	public ActionElementMap actionElementMap { get; }
	public string elementIdentifierName { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public Controller get_controller() { }

	// RVA: 0x16A9D20 Offset: 0x16A8320 VA: 0x1816A9D20
	public ControllerType get_controllerType() { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public ControllerMap get_controllerMap() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ActionElementMap get_actionElementMap() { }

	// RVA: 0x16A9D40 Offset: 0x16A8340 VA: 0x1816A9D40
	public string get_elementIdentifierName() { }

	// RVA: 0xB2ED20 Offset: 0xB2D320 VA: 0x180B2ED20
	internal void .ctor(Controller , ControllerMap , ActionElementMap ) { }

	// RVA: 0x16A9CC0 Offset: 0x16A82C0 VA: 0x1816A9CC0
	internal void .ctor(kmjACmxxUYamGJIGIaCfkwExoDCp ) { }
}

// Namespace: Rewired
public struct ControllerIdentifier // TypeDefIndex: 1731
{
	// Fields
	private int geiFrJCKClSdmONIywDTURjYPJnTA; // 0x0
	private ControllerType jWEHFBYpJqUErvsQFOkVsnBjEAQe; // 0x4
	private Guid RKtQsXAZcumTLjWzMqyhDpcCPQTx; // 0x8
	private string WqKxtyoOHIsKgjtDISLXKYcsazCQ; // 0x18
	private Guid GJgdWGVVIcKdNIXnufUhLdsqTUZH; // 0x20

	// Properties
	public int controllerId { get; set; }
	public ControllerType controllerType { get; set; }
	public Guid hardwareTypeGuid { get; set; }
	public string hardwareIdentifier { get; set; }
	public Guid deviceInstanceGuid { get; set; }
	public static ControllerIdentifier Blank { get; }

	// Methods

	// RVA: 0x16A2B50 Offset: 0x16A1150 VA: 0x1816A2B50
	internal void .ctor(Controller ) { }

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_controllerId() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_controllerId(int value) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public ControllerType get_controllerType() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x1105D70 Offset: 0x1104370 VA: 0x181105D70
	public Guid get_hardwareTypeGuid() { }

	// RVA: 0x14DAB30 Offset: 0x14D9130 VA: 0x1814DAB30
	public void set_hardwareTypeGuid(Guid value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_hardwareIdentifier() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_hardwareIdentifier(string value) { }

	// RVA: 0x95D410 Offset: 0x95BA10 VA: 0x18095D410
	public Guid get_deviceInstanceGuid() { }

	// RVA: 0x132E3D0 Offset: 0x132C9D0 VA: 0x18132E3D0
	public void set_deviceInstanceGuid(Guid value) { }

	// RVA: 0x16A2BD0 Offset: 0x16A11D0 VA: 0x1816A2BD0
	public static ControllerIdentifier get_Blank() { }
}

// Namespace: Rewired
[Preserve]
[Serializable]
public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable // TypeDefIndex: 1733
{
	// Fields
	[SerializeField]
	[Serialize(Name = "type")]
	private ControllerSetSelector.Type _type; // 0x10
	[SerializeField]
	[Serialize(Name = "controllerType")]
	private ControllerType _controllerType; // 0x14
	[SerializeField]
	[Serialize(Name = "guid")]
	private string _guid; // 0x18
	[SerializeField]
	[Serialize(Name = "hardwareIdentifier")]
	private string _hardwareIdentifier; // 0x20
	[SerializeField]
	[Serialize(Name = "controllerId")]
	private int _controllerId; // 0x28
	private Guid rYwHoLMdXLmZAIFuTCRbBkXXdxQu; // 0x2C

	// Properties
	internal bool MyKCzqaeZamTvQdCjVcLiZSbfKIWA { get; }
	public ControllerSetSelector.Type type { get; set; }
	public ControllerType controllerType { get; set; }
	public Guid hardwareTypeGuid { get; set; }
	public string hardwareIdentifier { get; set; }
	public Guid controllerTemplateTypeGuid { get; set; }
	public Guid deviceInstanceGuid { get; set; }
	public int controllerId { get; set; }

	// Methods

	// RVA: 0x16A4200 Offset: 0x16A2800 VA: 0x1816A4200
	internal void .ctor(ControllerSetSelector.Type ) { }

	// RVA: 0x16A41E0 Offset: 0x16A27E0 VA: 0x1816A41E0
	public void .ctor() { }

	// RVA: 0x16A4230 Offset: 0x16A2830 VA: 0x1816A4230
	public void .ctor(ControllerSetSelector ) { }

	// RVA: 0x16A42E0 Offset: 0x16A28E0 VA: 0x1816A42E0
	internal void .ctor(ControllerSetSelector.Type , ControllerType , string , string , int ) { }

	// RVA: 0x16A41D0 Offset: 0x16A27D0 VA: 0x1816A41D0
	internal bool XgdzOccrkMIIsBmEiMVfHdwZTFwd() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ControllerSetSelector.Type get_type() { }

	// RVA: 0x16A4760 Offset: 0x16A2D60 VA: 0x1816A4760
	public void set_type(ControllerSetSelector.Type value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public ControllerType get_controllerType() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x16A4480 Offset: 0x16A2A80 VA: 0x1816A4480
	public Guid get_hardwareTypeGuid() { }

	// RVA: 0x16A4690 Offset: 0x16A2C90 VA: 0x1816A4690
	public void set_hardwareTypeGuid(Guid value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_hardwareIdentifier() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_hardwareIdentifier(string value) { }

	// RVA: 0x16A43A0 Offset: 0x16A29A0 VA: 0x1816A43A0
	public Guid get_controllerTemplateTypeGuid() { }

	// RVA: 0x16A44F0 Offset: 0x16A2AF0 VA: 0x1816A44F0
	public void set_controllerTemplateTypeGuid(Guid value) { }

	// RVA: 0x16A4410 Offset: 0x16A2A10 VA: 0x1816A4410
	public Guid get_deviceInstanceGuid() { }

	// RVA: 0x16A45C0 Offset: 0x16A2BC0 VA: 0x1816A45C0
	public void set_deviceInstanceGuid(Guid value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_controllerId() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_controllerId(int value) { }

	// RVA: 0x16A3000 Offset: 0x16A1600 VA: 0x1816A3000
	public bool Matches(Controller controller) { }

	// RVA: 0x16A3F70 Offset: 0x16A2570 VA: 0x1816A3F70 Slot: 3
	public override string ToString() { }

	// RVA: 0x16A3240 Offset: 0x16A1840 VA: 0x1816A3240
	private void QkKbJfYXZpaMIfKfxsWLMQmUjVsAA() { }

	// RVA: 0x16A4160 Offset: 0x16A2760 VA: 0x1816A4160 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x16A32A0 Offset: 0x16A18A0 VA: 0x1816A32A0 Slot: 6
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	// RVA: 0x16A3380 Offset: 0x16A1980 VA: 0x1816A3380
	public static ControllerSetSelector SelectAll() { }

	// RVA: 0x16A37F0 Offset: 0x16A1DF0 VA: 0x1816A37F0
	public static ControllerSetSelector SelectControllerType(ControllerType controllerType) { }

	// RVA: 0x16A3850 Offset: 0x16A1E50 VA: 0x1816A3850
	public static ControllerSetSelector SelectHardwareType(ControllerType controllerType, Guid hardwareTypeGuid, string hardwareIdentifier) { }

	// RVA: 0x16A3990 Offset: 0x16A1F90 VA: 0x1816A3990
	public static ControllerSetSelector SelectHardwareType(Controller controller) { }

	// RVA: 0x16A33E0 Offset: 0x16A19E0 VA: 0x1816A33E0
	public static ControllerSetSelector SelectControllerTemplateType(ControllerType controllerType, Guid controllerTemplateTypeGuid) { }

	// RVA: 0x16A3520 Offset: 0x16A1B20 VA: 0x1816A3520
	public static ControllerSetSelector SelectControllerTemplateType(IControllerTemplate controllerTemplate) { }

	// RVA: 0x16A3B40 Offset: 0x16A2140 VA: 0x1816A3B40
	public static ControllerSetSelector SelectPersistentControllerInstance(ControllerType controllerType, Guid deviceInstanceGuid) { }

	// RVA: 0x16A3C80 Offset: 0x16A2280 VA: 0x1816A3C80
	public static ControllerSetSelector SelectPersistentControllerInstance(Controller controller) { }

	// RVA: 0x16A3F00 Offset: 0x16A2500 VA: 0x1816A3F00
	public static ControllerSetSelector SelectSessionControllerInstance(ControllerType controllerType, int controllerId) { }

	// RVA: 0x16A3E30 Offset: 0x16A2430 VA: 0x1816A3E30
	public static ControllerSetSelector SelectSessionControllerInstance(Controller controller) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal class ButtonStateRecorder // TypeDefIndex: 1737
{
	// Fields
	private const int mYyVuxFWtwaypuDjYZPznQHplSlK = 3;
	private ButtonStateRecorder.LroDSvEDAqKaYqFMLvJqVExxiJFZA[] ocgCjRKjgLUdcNQUEAjaxCrkVsdQA; // 0x10
	private ButtonStateRecorder.LroDSvEDAqKaYqFMLvJqVExxiJFZA[] hpmZArBGRPBuIGuNpUvXRQLWOdOu; // 0x18
	private int pvIivysMFoogByeCvphSfhxpdmxw; // 0x20
	private int DrONEwaaJdZNhBbJWhVKSmAarpLl; // 0x24
	private uint lhnypYVAlLbbmlDSYFdeBnaVgtGzA; // 0x28

	// Properties
	public double aUusERiDNXXcKpAjnBKFVZXzfJuB { get; }
	public double GJaTEbxLaJrFpzmRWAJORvUuSBmX { get; }
	public double KNSbNSPjagajMSqzCIGMbGqHzeiP { get; }
	public double WuNzFwhpozNRrGdwYcQBEladtCpwA { get; }
	public double ajNCJwCopCxxVKeyUQGRhODBPAFsA { get; }
	public double hjiYSxztsZoGtwDlKbxaDjPQEgDgA { get; }
	public double GtCMOEpQLyIgnyylvcyIKNNPpc { get; }

	// Methods

	// RVA: 0x169B6B0 Offset: 0x1699CB0 VA: 0x18169B6B0
	public double kAehFRjbHdnHuSsEXnoPfmabralXA() { }

	// RVA: 0x169B5F0 Offset: 0x1699BF0 VA: 0x18169B5F0
	public double eqJnNVbnkpyjyKmxDSIUDrFRkZnj() { }

	// RVA: 0x169B9B0 Offset: 0x1699FB0 VA: 0x18169B9B0
	public double sJYOQXgiPXzvByyRaucOUmwjHLhu() { }

	// RVA: 0x169B2E0 Offset: 0x16998E0 VA: 0x18169B2E0
	public double RQvsyFhXArukibqBeLkdkhcvbnFFA() { }

	// RVA: 0x169B050 Offset: 0x1699650 VA: 0x18169B050
	public double IuIPGKlWqvqaeoQDKjBeXOMrdOoM() { }

	// RVA: 0x169B0C0 Offset: 0x16996C0 VA: 0x18169B0C0
	public double KIKiVdiPhfKAJeYtnBNSDtWeSOEg() { }

	// RVA: 0x169BA50 Offset: 0x169A050 VA: 0x18169BA50
	public double sidTvBcnxcZUvhnhAMYkjASLzCvf() { }

	// RVA: 0x169B420 Offset: 0x1699A20 VA: 0x18169B420
	public void .ctor() { }

	// RVA: 0x169B130 Offset: 0x1699730 VA: 0x18169B130
	public void McopxuRUnANFAImjcJOhxuIvquak(bool , bool , double ) { }

	// RVA: 0x169B910 Offset: 0x1699F10 VA: 0x18169B910
	public bool rgofHgGUQlvXOMgxODdbcwYVHsOF(float ) { }

	// RVA: 0x169B870 Offset: 0x1699E70 VA: 0x18169B870
	public bool pbaumNcOTPIIevzAEHIgDdtVddIM(float ) { }

	// RVA: 0x169B380 Offset: 0x1699980 VA: 0x18169B380
	private static bool ZqDcGkZiztXKppjeIHSIuUvSgxRx(ButtonStateRecorder.LroDSvEDAqKaYqFMLvJqVExxiJFZA[] , int , float ) { }

	// RVA: 0x169B7F0 Offset: 0x1699DF0 VA: 0x18169B7F0
	private void pJgARENWJMdxAfniLqyiBwjKAPlqA() { }

	// RVA: 0x169B770 Offset: 0x1699D70 VA: 0x18169B770
	public void mBYKttdbGkaWhZXOcFyZYqOAeJWq() { }

	// RVA: 0x169BA90 Offset: 0x169A090 VA: 0x18169BA90
	public void tHPoWLtnQnboEjmxqbUZXfWcbQGI(double ) { }

	// RVA: 0x169B5C0 Offset: 0x1699BC0 VA: 0x18169B5C0
	private static int cnhcnWFSMBnGADqszAoKIkzqcsel(int , int ) { }

	// RVA: 0x169BC40 Offset: 0x169A240 VA: 0x18169BC40
	private static int tTenbRYXSDOawXvZugKdThnljfOi(int , int ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal abstract class PlatformInitializer // TypeDefIndex: 1744
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object Initialize(IConfigVars_Internal configVars);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IElementIdentifierTool CreateTool(string inputSourceString);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal abstract class PlatformInputManager // TypeDefIndex: 1745
{
	// Fields
	protected Action<BridgedController> _DeviceConnectedEvent; // 0x10
	protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent; // 0x18
	protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent; // 0x20
	protected Action _SystemDeviceConnectedEvent; // 0x28
	protected Action _SystemDeviceDisconnectedEvent; // 0x30

	// Properties
	public abstract int deviceCount { get; }
	public abstract PlatformInputManager primaryInputManager { get; }
	public abstract IInputSource inputSource { get; }
	public abstract InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x16AC390 Offset: 0x16AA990 VA: 0x1816AC390
	public void add_DeviceConnectedEvent(Action<BridgedController> value) { }

	// RVA: 0x16AC6E0 Offset: 0x16AACE0 VA: 0x1816AC6E0
	public void remove_DeviceConnectedEvent(Action<BridgedController> value) { }

	// RVA: 0x16AC440 Offset: 0x16AAA40 VA: 0x1816AC440
	public void add_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value) { }

	// RVA: 0x16AC790 Offset: 0x16AAD90 VA: 0x1816AC790
	public void remove_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value) { }

	// RVA: 0x16AC630 Offset: 0x16AAC30 VA: 0x1816AC630
	public void add_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value) { }

	// RVA: 0x16AC980 Offset: 0x16AAF80 VA: 0x1816AC980
	public void remove_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value) { }

	// RVA: 0x16AC4F0 Offset: 0x16AAAF0 VA: 0x1816AC4F0
	public void add_SystemDeviceConnectedEvent(Action value) { }

	// RVA: 0x16AC840 Offset: 0x16AAE40 VA: 0x1816AC840
	public void remove_SystemDeviceConnectedEvent(Action value) { }

	// RVA: 0x16AC590 Offset: 0x16AAB90 VA: 0x1816AC590
	public void add_SystemDeviceDisconnectedEvent(Action value) { }

	// RVA: 0x16AC8E0 Offset: 0x16AAEE0 VA: 0x1816AC8E0
	public void remove_SystemDeviceDisconnectedEvent(Action value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_deviceCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PlatformInputManager get_primaryInputManager();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IInputSource get_inputSource();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract InputSource get_inputSourceType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Update(UpdateLoopType currentUpdateLoop);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnDestroy();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SystemDeviceConnected();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void SystemDeviceDisconnected();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IUnifiedMouseSource GetUnifiedMouseSource();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class UnknownControllerHat // TypeDefIndex: 1747
{
	// Fields
	private UnknownControllerHat.HatButtons hPUMJIebDgJlzougMudjRcmRHYbl; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(UnknownControllerHat.HatButtons ) { }

	// RVA: 0x16ADB90 Offset: 0x16AC190 VA: 0x1816ADB90
	public bool ContainsButtonIndex(int index) { }

	// RVA: 0x16ADC00 Offset: 0x16AC200 VA: 0x1816ADC00
	public bool IsButtonIndexCardinal(int index) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public UnknownControllerHat.HatButtons GetButtons() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class InputSourceWrapper<T> : IInputSource, IDisposable // TypeDefIndex: 1766
{
	// Fields
	private T HwFfyFKCiAapogQDehYdhQJHmbWeb; // 0x0
	private bool fqCgsIsMaXIFyYzycQrbykqxklZu; // 0x0

	// Properties
	public T source { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-InputSourceWrapper<object>.get_source
	|
	|-RVA: 0x86E550 Offset: 0x86CB50 VA: 0x18086E550
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.get_source
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	|-InputSourceWrapper<object>..ctor
	|
	|-RVA: 0x10B2300 Offset: 0x10B0900 VA: 0x1810B2300
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void add_DeviceChangedEvent(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-InputSourceWrapper<object>.add_DeviceChangedEvent
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.add_DeviceChangedEvent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void remove_DeviceChangedEvent(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-InputSourceWrapper<object>.remove_DeviceChangedEvent
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.remove_DeviceChangedEvent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void SystemDeviceConnected() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-InputSourceWrapper<object>.SystemDeviceConnected
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.SystemDeviceConnected
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SystemDeviceDisconnected() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-InputSourceWrapper<object>.SystemDeviceDisconnected
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.SystemDeviceDisconnected
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603570 Offset: 0x601B70 VA: 0x180603570
	|-InputSourceWrapper<object>.Update
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Update
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void UpdateDevices(UpdateLoopType updateLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-InputSourceWrapper<object>.UpdateDevices
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.UpdateDevices
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void UpdateFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603570 Offset: 0x601B70 VA: 0x180603570
	|-InputSourceWrapper<object>.UpdateFinished
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.UpdateFinished
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IList<TJoy> GetJoysticks<TJoy>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603570 Offset: 0x601B70 VA: 0x180603570
	|-InputSourceWrapper<object>.GetJoysticks<object>
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.GetJoysticks<object>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B21D0 Offset: 0x10B07D0 VA: 0x1810B21D0
	|-InputSourceWrapper<object>.Dispose
	|
	|-RVA: 0x10B20F0 Offset: 0x10B06F0 VA: 0x1810B20F0
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B2240 Offset: 0x10B0840 VA: 0x1810B2240
	|-InputSourceWrapper<object>.Finalize
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B2230 Offset: 0x10B0830 VA: 0x1810B2230
	|-InputSourceWrapper<object>.Dispose
	|
	|-RVA: 0x10B2150 Offset: 0x10B0750 VA: 0x1810B2150
	|-InputSourceWrapper<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: Rewired
[DefaultMember("Item")]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class UpdateLoopDataSet<T> // TypeDefIndex: 1769
{
	// Fields
	private const int sRVcTvoccAfUqHDUOTyhnqZBrlkRA = 0;
	private UpdateLoopDataSet.RowFlISNeGYchoObvqhDyaCoBEjhA<T> AVkKFAaoQcEPBScBrkpqqDcNMYmg; // 0x0
	private int ODRYHDmPjBvPUtERKHOfoonStulR; // 0x0
	public readonly int fixedUpdateSetIndex; // 0x0
	private readonly int[] BhDoLMtIgfOrurBLxIkZKWZfTlhy; // 0x0
	private readonly UpdateLoopDataSet.RowFlISNeGYchoObvqhDyaCoBEjhA<T>[] IIVFvbnXFTbMqAwXGiLvBFAgggtG; // 0x0
	private UpdateLoopType eJQDPpyfrqCvhOknUFjxQJcwIvJN; // 0x0

	// Properties
	public T Current { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFA50 Offset: 0xACE050 VA: 0x180ACFA50
	|-UpdateLoopDataSet<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-UpdateLoopDataSet<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF4C0 Offset: 0xACDAC0 VA: 0x180ACF4C0
	|-UpdateLoopDataSet<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF5A0 Offset: 0xACDBA0 VA: 0x180ACF5A0
	|-UpdateLoopDataSet<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UpdateLoopSetting ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFA30 Offset: 0xACE030 VA: 0x180ACFA30
	|-UpdateLoopDataSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UpdateLoopSetting , Func<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF630 Offset: 0xACDC30 VA: 0x180ACF630
	|-UpdateLoopDataSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void SetUpdateLoop(UpdateLoopType updateLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF540 Offset: 0xACDB40 VA: 0x180ACF540
	|-UpdateLoopDataSet<object>.SetUpdateLoop
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF4C0 Offset: 0xACDAC0 VA: 0x180ACF4C0
	|-UpdateLoopDataSet<object>.Get
	*/

	// RVA: -1 Offset: -1
	public T Get(UpdateLoopType updateLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF470 Offset: 0xACDA70 VA: 0x180ACF470
	|-UpdateLoopDataSet<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Set(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF5A0 Offset: 0xACDBA0 VA: 0x180ACF5A0
	|-UpdateLoopDataSet<object>.Set
	*/

	// RVA: -1 Offset: -1
	public UpdateLoopType GetUpdateLoopType(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF3E0 Offset: 0xACD9E0 VA: 0x180ACF3E0
	|-UpdateLoopDataSet<object>.GetUpdateLoopType
	*/
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class ButtonLoopSet : UpdateLoopDataSet<ButtonLoopSet.ButtonData> // TypeDefIndex: 1771
{
	// Fields
	public readonly int buttonCount; // 0x38

	// Methods

	// RVA: 0x169AE30 Offset: 0x1699430 VA: 0x18169AE30
	public void .ctor(UpdateLoopSetting , int ) { }

	// RVA: 0x169ACC0 Offset: 0x16992C0 VA: 0x18169ACC0
	public void SetValue(int index, bool value, double timestamp) { }

	// RVA: 0x169A9C0 Offset: 0x1698FC0 VA: 0x18169A9C0
	public void Clear() { }

	// RVA: 0x169AB70 Offset: 0x1699170 VA: 0x18169AB70
	public void Import(ButtonLoopSet set) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct TouchInfo // TypeDefIndex: 1772
{
	// Fields
	private bool SzxDbpYCjRjSoFUWmwIaBjpkpIRBb; // 0x0
	private int GDUcodTspyBMRLFQMApCnfIlPCEV; // 0x4
	private Vector2 QDERvbvlvKdQsHHwmMJViylETdidB; // 0x8
	private Vector2 cyCBQtxmWLirkGyOzslMhpmxTJSv; // 0x10
	private Vector2 NuQMOigPVNqmSnxwxrtLnapBABLFA; // 0x18
	private Vector2 cJsOLqOzmHBAGwMrJUIXMflpNoai; // 0x20
	private float tJLGYmJboKKMFumqoMaEaaghsDCy; // 0x28
	private int cMcDrKoLZfaYSDTEJxYsVvJNfEnC; // 0x2C

	// Properties
	public bool isValid { get; set; }
	public int touchId { get; set; }
	public Vector2 touchPos { get; set; }
	public Vector2 touchPosRaw { get; set; }
	public Vector2 deltaPos { get; set; }
	public Vector2 deltaPosRaw { get; set; }
	public float deltaTime { get; set; }
	public int tapCount { get; set; }
	internal static TouchInfo Invalid { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public bool get_isValid() { }

	// RVA: 0xB07550 Offset: 0xB05B50 VA: 0x180B07550
	internal void set_isValid(bool value) { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_touchId() { }

	// RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	internal void set_touchId(int value) { }

	// RVA: 0x16ADB70 Offset: 0x16AC170 VA: 0x1816ADB70
	public Vector2 get_touchPos() { }

	// RVA: 0x9714A0 Offset: 0x96FAA0 VA: 0x1809714A0
	internal void set_touchPos(Vector2 value) { }

	// RVA: 0xE96BD0 Offset: 0xE951D0 VA: 0x180E96BD0
	public Vector2 get_touchPosRaw() { }

	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	internal void set_touchPosRaw(Vector2 value) { }

	// RVA: 0x10C9BB0 Offset: 0x10C81B0 VA: 0x1810C9BB0
	public Vector2 get_deltaPos() { }

	// RVA: 0x14A5B00 Offset: 0x14A4100 VA: 0x1814A5B00
	internal void set_deltaPos(Vector2 value) { }

	// RVA: 0x16ADB50 Offset: 0x16AC150 VA: 0x1816ADB50
	public Vector2 get_deltaPosRaw() { }

	// RVA: 0x163E100 Offset: 0x163C700 VA: 0x18163E100
	internal void set_deltaPosRaw(Vector2 value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0
	public float get_deltaTime() { }

	// RVA: 0x3CB510 Offset: 0x3C9B10 VA: 0x1803CB510
	internal void set_deltaTime(float value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_tapCount() { }

	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	internal void set_tapCount(int value) { }

	// RVA: 0x16ADAF0 Offset: 0x16AC0F0 VA: 0x1816ADAF0
	internal void .ctor(bool , int , Vector2 , Vector2 , Vector2 , Vector2 , float , int ) { }

	// RVA: 0x16ADB30 Offset: 0x16AC130 VA: 0x1816ADB30
	internal static TouchInfo get_Invalid() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class SteamAction // TypeDefIndex: 1773
{
	// Fields
	public readonly string name; // 0x10
	public readonly ulong handle; // 0x18

	// Methods

	// RVA: 0x16AD4B0 Offset: 0x16ABAB0 VA: 0x1816AD4B0
	public void .ctor(string , ulong ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class SteamActionSet // TypeDefIndex: 1774
{
	// Fields
	public readonly string name; // 0x10
	public readonly ulong handle; // 0x18
	public readonly Dictionary<string, SteamAction> actions; // 0x20

	// Methods

	// RVA: 0x16AD410 Offset: 0x16ABA10 VA: 0x1816AD410
	public void .ctor(string , ulong ) { }

	// RVA: 0x16AD370 Offset: 0x16AB970 VA: 0x1816AD370
	public void AddAction(SteamAction action) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct HardwareControllerMapIdentifier // TypeDefIndex: 1775
{
	// Fields
	public readonly Guid guid; // 0x0
	public readonly InputSource inputSource; // 0x10
	public readonly InputPlatform actualInputPlatform; // 0x14
	public readonly int variantIndex; // 0x18

	// Methods

	// RVA: 0x16A68A0 Offset: 0x16A4EA0 VA: 0x1816A68A0
	public void .ctor(Guid , InputSource , InputPlatform , int ) { }

	// RVA: 0x16A67F0 Offset: 0x16A4DF0 VA: 0x1816A67F0
	public static bool Matches(HardwareControllerMapIdentifier a, HardwareControllerMapIdentifier b) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct RewiredVersion // TypeDefIndex: 1776
{
	// Fields
	public int version1; // 0x0
	public int version2; // 0x4
	public int version3; // 0x8
	public int version4; // 0xC
	public string unityVersion; // 0x10

	// Methods

	// RVA: 0x16ACE40 Offset: 0x16AB440 VA: 0x1816ACE40
	public void .ctor(int , int , int , int , string ) { }

	// RVA: 0x16ACE70 Offset: 0x16AB470 VA: 0x1816ACE70
	public void .ctor(string ) { }

	// RVA: 0x16ACB40 Offset: 0x16AB140 VA: 0x1816ACB40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16ACC00 Offset: 0x16AB200 VA: 0x1816ACC00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16ACCB0 Offset: 0x16AB2B0 VA: 0x1816ACCB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16ACF80 Offset: 0x16AB580 VA: 0x1816ACF80
	public static bool op_Equality(RewiredVersion a, RewiredVersion b) { }

	// RVA: 0x16AD220 Offset: 0x16AB820 VA: 0x1816AD220
	public static bool op_Inequality(RewiredVersion a, RewiredVersion b) { }

	// RVA: 0x16AD120 Offset: 0x16AB720 VA: 0x1816AD120
	public static bool op_GreaterThan(RewiredVersion a, RewiredVersion b) { }

	// RVA: 0x16AD270 Offset: 0x16AB870 VA: 0x1816AD270
	public static bool op_LessThan(RewiredVersion a, RewiredVersion b) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal struct PidVid : IEquatable<PidVid> // TypeDefIndex: 1777
{
	// Fields
	private const string vbXEONyobQtjAHVqimxORhmRrsoB = "[^a-fA-F0-9]";
	public ushort productId; // 0x0
	public ushort vendorId; // 0x2

	// Properties
	public bool isZero { get; }

	// Methods

	// RVA: 0x11054C0 Offset: 0x1103AC0 VA: 0x1811054C0
	public void .ctor(ushort , ushort ) { }

	// RVA: 0x16AC150 Offset: 0x16AA750 VA: 0x1816AC150
	public void .ctor(string ) { }

	// RVA: 0x16AC200 Offset: 0x16AA800 VA: 0x1816AC200
	public void .ctor(Guid ) { }

	// RVA: 0x16AC330 Offset: 0x16AA930 VA: 0x1816AC330
	public bool get_isZero() { }

	// RVA: 0x16ABE90 Offset: 0x16AA490 VA: 0x1816ABE90
	public bool Equals(string pidVid) { }

	// RVA: 0x16AC060 Offset: 0x16AA660 VA: 0x1816AC060
	public Guid ToProductGuid() { }

	// RVA: 0x16ABFB0 Offset: 0x16AA5B0 VA: 0x1816ABFB0
	private bool NbWccrBTkaAtoNMcQzarSmpWCbJu(string ) { }

	// RVA: 0x16ABEE0 Offset: 0x16AA4E0 VA: 0x1816ABEE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16ABF70 Offset: 0x16AA570 VA: 0x1816ABF70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16ABEC0 Offset: 0x16AA4C0 VA: 0x1816ABEC0 Slot: 4
	public bool Equals(PidVid other) { }

	// RVA: 0x16AC350 Offset: 0x16AA950 VA: 0x1816AC350
	public static bool op_Equality(PidVid x, PidVid y) { }

	// RVA: 0x16AC370 Offset: 0x16AA970 VA: 0x1816AC370
	public static bool op_Inequality(PidVid x, PidVid y) { }

	// RVA: 0x16AC0E0 Offset: 0x16AA6E0 VA: 0x1816AC0E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16ABE10 Offset: 0x16AA410 VA: 0x1816ABE10
	public static bool ArrayContains(string[] pidVids, ref PidVid vidPid) { }

	// RVA: 0x16AC250 Offset: 0x16AA850 VA: 0x1816AC250
	private static string bcViaQOCeyIFHaQVRtXYPnymcwqJ(string ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False)]
internal static class Profiler // TypeDefIndex: 1778
{
	// Fields
	private const string UfSVvaFbOkEszHFDnPikguJzRUeM = "ENABLE_PROFILER must be set in Rewired Core to use the profiler.";

	// Properties
	public static bool enableBinaryLog { get; set; }
	public static bool enabled { get; set; }
	public static string logFile { get; set; }
	public static bool supported { get; }
	public static uint usedHeapSize { get; }
	public static long usedHeapSizeLong { get; }

	// Methods

	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	private static void GDuDOtECHFBvXOjYmWaidkHTAysGA() { }

	// RVA: 0x16ACAB0 Offset: 0x16AB0B0 VA: 0x1816ACAB0
	public static bool get_enableBinaryLog() { }

	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	public static void set_enableBinaryLog(bool value) { }

	// RVA: 0x16ACAB0 Offset: 0x16AB0B0 VA: 0x1816ACAB0
	public static bool get_enabled() { }

	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	public static void set_enabled(bool value) { }

	// RVA: 0x16ACAF0 Offset: 0x16AB0F0 VA: 0x1816ACAF0
	public static string get_logFile() { }

	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	public static void set_logFile(string value) { }

	// RVA: 0x16ACAB0 Offset: 0x16AB0B0 VA: 0x1816ACAB0
	public static bool get_supported() { }

	// RVA: 0x16ACA70 Offset: 0x16AB070 VA: 0x1816ACA70
	public static uint get_usedHeapSize() { }

	// RVA: 0x16ACA70 Offset: 0x16AB070 VA: 0x1816ACA70
	public static long get_usedHeapSizeLong() { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	public static void AddFramesFromFile(string file) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	public static void BeginSample(string name) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	public static void BeginSample(string name, Object targetObject) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x16ACA30 Offset: 0x16AB030 VA: 0x1816ACA30
	public static void EndSample() { }

	// RVA: 0x16ACA70 Offset: 0x16AB070 VA: 0x1816ACA70
	public static uint GetMonoHeapSize() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static long GetMonoHeapSizeLong() { }

	// RVA: 0x16ACA70 Offset: 0x16AB070 VA: 0x1816ACA70
	public static uint GetMonoUsedSize() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static long GetMonoUsedSizeLong() { }

	// RVA: 0x16ACA70 Offset: 0x16AB070 VA: 0x1816ACA70
	public static int GetRuntimeMemorySize(Object o) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static long GetRuntimeMemorySizeLong(Object o) { }

	// RVA: 0x16ACA70 Offset: 0x16AB070 VA: 0x1816ACA70
	public static uint GetTotalAllocatedMemory() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static long GetTotalAllocatedMemoryLong() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static uint GetTotalReservedMemory() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static long GetTotalReservedMemoryLong() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static uint GetTotalUnusedReservedMemory() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static long GetTotalUnusedReservedMemoryLong() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal static class EnumConverter // TypeDefIndex: 1779
{
	// Methods

	// RVA: 0x16A6620 Offset: 0x16A4C20 VA: 0x1816A6620
	public static int ToUpdateLoopTypes(UpdateLoopSetting updateLoopSetting, List<UpdateLoopType> results) { }

	// RVA: 0x16A65C0 Offset: 0x16A4BC0 VA: 0x1816A65C0
	public static AlternateAxisCalibrationType ToAlternateAxisCalibrationType(ThrottleCalibrationMode throttleCalibrationMode) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal static class ThreadSafeUnityInput // TypeDefIndex: 1782
{
	// Fields
	private static ThreadSafeUnityInput.Mouse yVAgyXAsctqjwHYHNXibVCIznkfEA; // 0x0
	private static ThreadSafeUnityInput.Keyboard SaLbwsCqEKLmDnNiKaIAHUDhVbSCB; // 0x8

	// Properties
	public static ThreadSafeUnityInput.Mouse mouse { get; }
	public static ThreadSafeUnityInput.Keyboard keyboard { get; }

	// Methods

	// RVA: 0x16AD9A0 Offset: 0x16ABFA0 VA: 0x1816AD9A0
	public static ThreadSafeUnityInput.Mouse get_mouse() { }

	// RVA: 0x16AD7B0 Offset: 0x16ABDB0 VA: 0x1816AD7B0
	public static ThreadSafeUnityInput.Keyboard get_keyboard() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Initialize() { }

	// RVA: 0x16AD590 Offset: 0x16ABB90 VA: 0x1816AD590
	public static void PostInitialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void PostInitialize2() { }

	// RVA: 0x16AD500 Offset: 0x16ABB00 VA: 0x1816AD500
	public static void Deinitialize() { }

	// RVA: 0x16AD600 Offset: 0x16ABC00 VA: 0x1816AD600
	public static void Update() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal struct LowLevelInputEvent // TypeDefIndex: 1784
{
	// Fields
	private const int gnlfnPCZwbhDWDJVKxipNplCvpASA = 4;
	private const int EQsgkkmHQkwvqzZkQkRTKINEuEuO = 8;
	private const int GRRRNiYjazbmuFazATTpefrEpeSfA = 12;
	public const int buttonsPerPage = 32;
	public const int bytesPerButtonPage = 4;
	private const int gRbYZIHWTNrrIBIIpLbrpFSldiHKA = 4;
	private const int ctXStOeNQrKKDABpCptOIptSsYMG = 4;
	public const int byteIndex_id = 0;
	public const int byteIndex_timestamp = 4;
	public const int byteIndex_elementsStart = 12;
	public IntPtr _buffer; // 0x0
	private int QeGNiiEKdwCsFQqErBXMNNyXHWKp; // 0x8
	private int GEctTLnSBLomBlkOOWIgiETLyUYQ; // 0xC
	private int gqzBkXdwUEIzcexXhZIUcGLRPgrhA; // 0x10
	private int WHBDdufeqIUXWrCJeOQIdoYIHeVUB; // 0x14
	private int ONgQEahCbkHNzbVNovVTBmSZHHcaA; // 0x18
	private int tYqOTzUxdZRDlEQIJEFbOsYsuNYT; // 0x1C

	// Properties
	public bool isValid { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public int byteIndex_axesStart { get; }
	public int byteIndex_buttonsStart { get; }
	public int byteIndex_hatsStart { get; }

	// Methods

	// RVA: 0x12A0130 Offset: 0x129E730 VA: 0x1812A0130
	public bool get_isValid() { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_buttonCount() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_axisCount() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_byteIndex_axesStart() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_byteIndex_buttonsStart() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_byteIndex_hatsStart() { }

	// RVA: 0x16AAE70 Offset: 0x16A9470 VA: 0x1816AAE70
	public void .ctor(IntPtr , int , int , int ) { }

	// RVA: 0x16AAC80 Offset: 0x16A9280 VA: 0x1816AAC80
	public void SetButtonsBitMask(int bitMask, int startButtonIndex) { }

	// RVA: 0x16AABD0 Offset: 0x16A91D0 VA: 0x1816AABD0
	public void SetAxisValue(int index, float value) { }

	// RVA: 0x16AAD70 Offset: 0x16A9370 VA: 0x1816AAD70
	public void SetId(uint id) { }

	// RVA: 0x16AADE0 Offset: 0x16A93E0 VA: 0x1816AADE0
	public void SetTimestamp(double value) { }

	// RVA: 0x16AA8E0 Offset: 0x16A8EE0 VA: 0x1816AA8E0
	public bool GetButtonValue(int index) { }

	// RVA: 0x16AA9D0 Offset: 0x16A8FD0 VA: 0x1816AA9D0
	public int GetButtonsBitMask(int startButtonIndex) { }

	// RVA: 0x16AA840 Offset: 0x16A8E40 VA: 0x1816AA840
	public float GetAxisValue(int index) { }

	// RVA: 0x16AAAC0 Offset: 0x16A90C0 VA: 0x1816AAAC0
	public uint GetId() { }

	// RVA: 0x16AAB50 Offset: 0x16A9150 VA: 0x1816AAB50
	public double GetTimestamp() { }

	// RVA: 0x16AAB20 Offset: 0x16A9120 VA: 0x1816AAB20
	public static int GetReportSize(int buttonCount, int axisCount, int hatCount) { }
}

// Namespace: Rewired
[EditorBrowsable(1)]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
public static class Consts // TypeDefIndex: 1785
{
	// Fields
	public const int systemPlayerId = 9999999;
	public const string menuRoot = "Window/Rewired";
	internal const int programVersion1 = 1;
	internal const int programVersion2 = 1;
	internal const int programVersion3 = 59;
	internal const int programVersion4 = 0;
	internal const int dataVersion = 1;
	internal const int unityMajorVersion = 2023;
	internal const string unityMajorVersionIdentifier = "U2023";
	internal const bool isTrial = False;
	internal const string copyrightYear = "2025";
	internal const string defaultNamespace = "Rewired";
	internal const LogLevelFlags defaultLogLevel = 7;
	internal const bool allowInputWhenEditorPaused = True;
	internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers = "[SplitTriggers]";
	internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers = "[CombinedTriggers]";
	internal const float editorGUIUpdateInterval = 0.5;
	internal const float joystickRefreshPollCheckTimeout = 1;
	internal const float controllerRefreshWaitTimeout = 0.5;
	internal const int buttonsPerHat = 8;
	internal const int keyboardKeyCount = 132;
	internal const int keyboardModifierKeyCount = 8;
	internal const int unityMouseButtonCount = 7;
	internal const int unityMouseAxisCount = 4;
	internal const int unityMaxJoysticks = 16;
	internal const int unityJoystickButtonCount = 20;
	internal const int unityJoystickStartingButtonKeycodeValue = 350;
	internal const int unityJoystickAxisCount = 29;
	internal const int unityJoystickLastJoystickIdWithButtonKeyCodes = 16;
	internal const string unityJoystickPrefix = "Joy";
	internal const string unityJoystickAxisSuffix = "Axis";
	internal const string unityJoystickButtonSuffix = "Button";
	internal const int directInputMaxButtons = 128;
	internal const int directInputMaxAxes = 32;
	internal const int directInputMaxHats = 4;
	internal const int directInputMaxSliders = 2;
	internal const int directInputMaxAxisValue = 65535;
	internal const int directInputMinAxisValue = -65535;
	internal const int directInputMaxHatValue = 36000;
	internal const int directInputHatZeroValue = -1;
	internal const int directInputHatSpan = 4500;
	internal const int directInputHatSpan4Way = 9000;
	internal const int directInput_hatValue_up = 0;
	internal const int directInput_hatValue_right = 9000;
	internal const int directInput_hatValue_down = 18000;
	internal const int directInput_hatValue_left = 27000;
	internal const int directInputLastDirectionValue = 31500;
	internal const int directInputLastDirectionValue4Way = 27000;
	internal const int directInputUnknownJoystickHatCount = 2;
	internal const int directInputUnknownJoystickHatButtonStartIndex = 128;
	internal const int directInputJoystickStateByteSize = 264;
	internal const int rawInputMaxButtons = 256;
	internal const int rawInputMaxAxes = 56;
	internal const int rawInputMaxHats = 4;
	internal const int rawInputMaxSliders = 2;
	internal const int rawInputMaxAxisValue = 65535;
	internal const int rawInputMinAxisValue = -65535;
	internal const int rawInputMaxHatValue = 36000;
	internal const int rawInputHatZeroValue = -1;
	internal const int rawInputHatSpan = 4500;
	internal const int rawInputHatSpan4Way = 9000;
	internal const int rawInput_hatValue_up = 0;
	internal const int rawInput_hatValue_right = 9000;
	internal const int rawInput_hatValue_down = 18000;
	internal const int rawInput_hatValue_left = 27000;
	internal const int rawInputLastDirectionValue = 31500;
	internal const int rawInputLastDirectionValue4Way = 27000;
	internal const int rawInputUnknownJoystickHatCount = 2;
	internal const int rawInputUnknownJoystickHatButtonStartIndex = 128;
	internal const int rawInputUnifiedMouseButtonCount = 5;
	internal const int rawInputUnifiedMouseAxisCount = 4;
	internal const float rawInputUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5;
	internal const int rawInputUnifiedKeyboardButtonCount = 132;
	internal const int osxMaxSticks = 4;
	internal const int osxMaxButtons = 128;
	internal const int osxMaxAxesPerStick = 14;
	internal const int osxMaxHatsPerStick = 4;
	internal const int osxMaxAxisValue = 65536;
	internal const int osxMinAxisValue = -65536;
	internal const int osxMaxPressureSensitiveButtonValue = 65536;
	internal const int osxMinPressureSensitiveButtonValue = 0;
	internal const int osxMaxHatValue = 36000;
	internal const int osxInputHatZeroValue = -1;
	internal const int osxHatSpan = 4500;
	internal const int osxHatSpan4Way = 9000;
	internal const int osx_hatValue_up = 0;
	internal const int osx_hatValue_right = 9000;
	internal const int osx_hatValue_down = 18000;
	internal const int osx_hatValue_left = 27000;
	internal const int osxLastDirectionValue = 31500;
	internal const int osxLastDirectionValue4Way = 27000;
	internal const int osxUnknownJoystickHatCount = 16;
	internal const int osxUnknownJoystickHatButtonStartIndex = 128;
	internal const int linuxMaxButtons = 256;
	internal const int linuxMaxAxes = 56;
	internal const int linuxMaxHats = 4;
	internal const int linuxMaxSliders = 2;
	internal const int linuxMaxAxisValue = 32767;
	internal const int linuxMinAxisValue = -32768;
	internal const int linuxMaxHatValue = 36000;
	internal const int linuxHatZeroValue = -1;
	internal const int linuxHatSpan = 4500;
	internal const int linuxHatSpan4Way = 9000;
	internal const int linux_hatValue_up = 0;
	internal const int linux_hatValue_right = 9000;
	internal const int linux_hatValue_down = 18000;
	internal const int linux_hatValue_left = 27000;
	internal const int linuxLastDirectionValue = 31500;
	internal const int linuxLastDirectionValue4Way = 27000;
	internal const int linuxUnknownJoystickHatCount = 2;
	internal const int linuxUnknownJoystickHatButtonStartIndex = 128;
	internal const int linuxUnifiedMouseButtonCount = 5;
	internal const int linuxUnifiedMouseAxisCount = 3;
	internal const float linuxUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5;
	internal const int sdl2MaxButtons = 256;
	internal const int sdl2MaxAxes = 56;
	internal const int sdl2MaxHats = 4;
	internal const int sdl2MaxSliders = 2;
	internal const int sdl2MaxAxisValue = 32768;
	internal const int sdl2MinAxisValue = -32767;
	internal const int sdl2AxisZeroValue = 0;
	internal const int sdl2MaxHatValue = 36000;
	internal const int sdl2HatZeroValue = -1;
	internal const int sdl2HatSpan = 4500;
	internal const int sdl2HatSpan4Way = 9000;
	internal const int sdl2_hatValue_up = 0;
	internal const int sdl2_hatValue_right = 9000;
	internal const int sdl2_hatValue_down = 18000;
	internal const int sdl2_hatValue_left = 27000;
	internal const int sdl2LastDirectionValue = 31500;
	internal const int sdl2LastDirectionValue4Way = 27000;
	internal const int sdl2UnknownJoystickHatCount = 2;
	internal const int sdl2UnknownJoystickHatButtonStartIndex = 128;
	internal const int sdl2UnifiedMouseButtonCount = 5;
	internal const int sdl2UnifiedMouseAxisCount = 3;
	internal const float sdl2UnifiedMouseAxisUnityEquivalencyMultiplier = 0.5;
	internal const int windowsUWPMaxButtons = 256;
	internal const int windowsUWPMaxAxes = 56;
	internal const int windowsUWPMaxHats = 4;
	internal const int windowsUWPMaxSliders = 2;
	internal const int windowsUWPMaxAxisValue = 32767;
	internal const int windowsUWPMinAxisValue = -32768;
	internal const int windowsUWPMaxHatValue = 36000;
	internal const int windowsUWPHatZeroValue = -1;
	internal const int windowsUWPDirectionsPerHat = 8;
	internal const int windowsUWPHatSpan = 4500;
	internal const int windowsUWPHatSpan4Way = 9000;
	internal const int windowsUWPLastDirectionValue = 31500;
	internal const int windowsUWPLastDirectionValue4Way = 27000;
	internal const int windowsUWPUnknownJoystickHatCount = 2;
	internal const int windowsUWPUnknownJoystickHatButtonStartIndex = 128;
	internal const int windowsUWPUnifiedMouseButtonCount = 5;
	internal const int windowsUWPUnifiedMouseAxisCount = 3;
	internal const float windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5;
	internal const int windowsGamingInputHatZeroValue = -1;
	internal const int xInputMaxVibration = 65535;
	internal const int xInputMinVibration = 0;
	internal const float xInputAllowedVibrationInterval = 0.01;
	internal const int customPlatformMaxButtons = 256;
	internal const int customPlatformMaxAxes = 128;
	internal const int internalDriverMaxButtons = 256;
	internal const int internalDriverMaxAxes = 56;
	internal const int internalDriverMaxHats = 4;
	internal const int internalDriverMaxSliders = 2;
	internal const int internalDriverMaxAxisValue = 65535;
	internal const int internalDriverMinAxisValue = -65535;
	internal const int internalDriverMaxHatValue = 36000;
	internal const int internalDriverHatZeroValue = -1;
	internal const int internalDriverHatSpan = 4500;
	internal const int internalDriverHatSpan4Way = 9000;
	internal const int internalDriver_hatValue_up = 0;
	internal const int internalDriver_hatValue_right = 9000;
	internal const int internalDriver_hatValue_down = 18000;
	internal const int internalDriver_hatValue_left = 27000;
	internal const int internalDriverLastDirectionValue = 31500;
	internal const int internalDriverLastDirectionValue4Way = 27000;
	internal const int internalDriverUnknownJoystickHatCount = 2;
	internal const int internalDriverUnknownJoystickHatButtonStartIndex = 128;
	internal const int internalDriverUnifiedMouseButtonCount = 5;
	internal const int internalDriverUnifiedMouseAxisCount = 3;
	internal const float internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5;
	internal const int webGLMaxButtons = 256;
	internal const int webGLMaxAxes = 128;
	internal const int gameCoreMaxButtons = 256;
	internal const int gameCoreMaxAxes = 32;
	internal const int gameCoreMaxHats = 4;
	internal const int gameCoreUnknownJoystickButtonCount = 128;
	internal const int gameCoreUnknownJoystickAxisCount = 32;
	internal const int gameCoreUnknownJoystickHatCount = 2;
	internal const int appleGCControllerMaxButtons = 128;
	internal const int appleGCControllerMaxAxes = 32;
	internal const int appleGCControllerMaxCompoundElements = 32;
	internal const int appleGCControllerUnknownJoystickButtonCount = 128;
	internal const int appleGCControllerUnknownJoystickAxisCount = 32;
	internal const int windowsGamingInputMaxButtons = 128;
	internal const int windowsGamingInputMaxAxes = 32;
	internal const int windowsGamingInputMaxHats = 16;
	internal const int windowsGamingInputMaxCompoundElements = 32;
	internal const int windowsGamingInputUnknownJoystickButtonCount = 128;
	internal const int windowsGamingInputUnknownJoystickAxisCount = 32;
	internal const int windowsGamingInputUnknownJoystickHatCount = 16;
	internal const int unknownJoystickMaxButtons = 128;
	internal const int unknownJoystickMaxAxes = 32;
	internal const int unknownJoystickMaxHats = 16;
	internal const int unknownJoystickButtonsPerHat = 8;
	internal const int unknownJoystickAxisElementIdentifierStartIndex = 0;
	internal const int unknownJoystickButtonElementIdentifierStartIndex = 32;
	internal const int unknownJoystickHatElementIdentifierStartIndex = 160;
	internal const float unknownJoystickDefaultAxisDeadZone = 0.1;
	internal const float defaultAbsoluteAxisPollingDeadZone = 0.7;
	internal const float defaultRelativeAxisPollingDeadZone = 100;
	internal const float defaultMouseXYAxisPollingDeadzone = 100;
	internal const float defaultMouseOtherAxisPollingDeadzone = 2;
	internal const float defaultButtonDeadZone = 0.5;
	internal const float hardwareButtonDeadZone = 0.01;
	internal const float axisDefaultSensitivity = 1;
	internal const AxisSensitivityType axisDefaultSensitivityType = 0;
	internal const float defaultButtonDoublePressSpeed = 0.3;
	internal const float minDoubleButtonPressSpeed = 0.01;
	internal const float maxDoubleButtonPressSpeed = 10;
	internal const float defaultButtonShortPressTime = 0.25;
	internal const float minButtonShortPressTime = 0;
	internal const float maxButtonShortPressTime = 3.4028235E+38;
	internal const float defaultButtonShortPressExpiresIn = 0;
	internal const float minButtonShortPressExpiresIn = 0;
	internal const float maxButtonShortPressExpiresIn = 3.4028235E+38;
	internal const float defaultButtonLongPressTime = 1;
	internal const float minButtonLongPressTime = 0;
	internal const float maxButtonLongPressTime = 3.4028235E+38;
	internal const float defaultButtonLongPressExpiresIn = 0;
	internal const float minButtonLongPressExpiresIn = 0;
	internal const float maxButtonLongPressExpiresIn = 3.4028235E+38;
	internal const float defaultButtonRepeatDelay = 0;
	internal const float defaultButtonRepeatRate = 30;
	internal const float minButtonRepeatRate = 0.001;
	internal const float mouseAxisPollingTimerLength = 1;
	internal const float relativeAxisPollingTimerLength = 1;
	internal const float fallbackPollingTimeout = 1;
	internal const KeyCombinationOverrideMode defaultKeyCombinationOverrideMode = 2;
	internal const bool defaultGenerateKeyEventsOnKeyCombinationOverride = True;
	internal const string unknownJoystickName = "Unknown Controller";
	internal const float xInputControllerVibrationRenewalInterval = 1.5;
	internal const int defaultInputThreadUpdateRateFPS = 240;
	internal const int maxInputThreadUpdateRateFPS = 2000;
	internal const int osxXInputOutputReportRefreshRateFPS = 60;
	internal const int defaultOutputRefreshRateFPS = 100;
	internal const int hidOutputReportRefreshRateFPS = 100;
	internal const int hidOutputReportThreadKillTimeout = 10000;
	internal const int joystickInputReportRingBufferCapacity = 60;
	internal const float joystickInputReportRingBufferCapacityDuration = 0.25;
	internal const string resourecesDLLPath_windowsStandalone = "Libs/Rewired_Windows";
	internal const string resourecesDLLPath_osxStandalone = "Libs/Rewired_OSX";
	internal const string resourecesDLLPath_linux = "Libs/Rewired_Linux";
	internal const float defaultInputBehaviorAxisSensitivity = 1;
	internal const float defaultInputBehaviorAxisSimulation_gravity = 3;
	internal const float defaultInputBehaviorAxisSimulation_sensitivity = 3;
	internal const bool defaultInputBehaviorAxisSmoothing_snap = True;
	internal const bool defaultInputBehaviorAxisSmoothing_instantReverse = False;
	internal const bool defaultInputBehaviorAxisSimulation_enabled = False;
	internal const int allFlagsIntEnum = -1;
	internal const float osxPreventSystemSleepInterval = 30;
	internal const string schemaNameSpace = "http://guavaman.com/rewired";
	internal const string schemaBaseLocation = "http://guavaman.com/schemas/rewired/";
	internal const string schemaVersionControllerMap = "1.1";
	internal const string schemaVersionCalibrationMap = "1.3";
	internal const string schemaVersionInputBehavior = "1.4";
	internal const string schemaVersionControllerTemplateMap = "1.0";
	internal const string schemaVersionPlayerEnabledMapsHelperData = "1.0";
	internal const string schemaVersionPlayerControllerMapLayoutManagerData = "1.0";
	internal const int controllerMapDataVersion = 2;
	internal const int calibrationMapDataVersion = 4;
	internal const int inputBehaviorDataVersion = 5;
	internal const int controllerTemplateMapDataVersion = 1;
	internal const int playerMapEnablerDataVersion = 1;
	internal const int playerControllerMapLayoutManagerDataVersion = 1;
	internal static readonly PidVid[] questionablePidVids; // 0x0
	internal static readonly int[] questionableVIDs; // 0x8
	internal const int controllerElementType_trueElements_minValue = 0;
	internal const int controllerElementType_trueElements_maxValue = 99;
	internal const float pressureSensitiveButtonDeadZone = 0.001;
	internal const string rewiredEditorAssembly = "Rewired_Editor";
	internal const string rewiredEditorInputEditorClassFullName = "Rewired.Editor.InputEditor";
	internal const string nintendoSwitchPluginEditorRuntimeAssembly = "Rewired_NintendoSwitch_EditorRuntime";
	internal const string nintendoSwitch2PluginEditorRuntimeAssembly = "Rewired_NintendoSwitch2_EditorRuntime";
	internal const string nintendoSwitchPluginInputManagerFullClassPath = "Rewired.Platforms.Switch.NintendoSwitchInputManager";
	internal const string nintendoSwitch2PluginInputManagerFullClassPath = "Rewired.Platforms.Switch2.NintendoSwitch2InputManager";
	internal const string nintendoSwitchPluginHWJoystickMapGuid_JoyConDual = "521b808c-0248-4526-bc10-f1d16ee76bf1";
	internal const string nintendoSwitchPluginHWJoystickMapGuid_Handheld = "1fbdd13b-0795-4173-8a95-a2a75de9d204";
	internal const string nintendoSwitch2PluginHWJoystickMapGuid_JoyConDual = "b5cb8488-8551-41c2-944a-64dfcf74b4c7";
	internal const string nintendoSwitch2PluginHWJoystickMapGuid_Handheld = "2560014c-e7a5-4675-bc63-1b46337b12cb";
	internal const string gameCorePluginEditorRuntimeAssembly = "Rewired_GameCore_EditorRuntime";
	internal const string gameCorePluginInputManagerFullClassPath = "Rewired.Platforms.GameCore.GameCoreInputManager";
	internal const string ps4PluginEditorRuntimeAssembly = "Rewired_PlayStation4_EditorRuntime";
	internal const string ps5PluginEditorRuntimeAssembly = "Rewired_PlayStation5_EditorRuntime";
	internal static Guid joystickGuid_unknownController; // 0x10
	internal static Guid joystickGuid_appleMFiController; // 0x20
	internal static Guid joystickGuid_standardizedGamepad; // 0x30
	internal static Guid joystickGuid_steamController; // 0x40
	internal static Guid joystickGuid_SonyDualShock4; // 0x50
	internal static Guid joystickGuid_SonyPS4AimController; // 0x60
	internal static Guid joystickGuid_SonyPS4Drums; // 0x70
	internal static Guid joystickGuid_SonyPS4FlightStick; // 0x80
	internal static Guid joystickGuid_SonyPS4Guitar; // 0x90
	internal static Guid joystickGuid_SonyPS4SteeringWheel; // 0xA0
	internal static Guid joystickGuid_SonyDualSense; // 0xB0
	internal static Guid joystickGuid_NintendoSwitchHandheld; // 0xC0
	internal static Guid joystickGuid_NintendoSwitchJoyConDual; // 0xD0
	internal static Guid joystickGuid_NintendoSwitchJoyConL; // 0xE0
	internal static Guid joystickGuid_NintendoSwitchJoyConR; // 0xF0
	internal static Guid hardwareTypeGuid_universalKeyboard; // 0x100
	internal static Guid hardwareTypeGuid_universalMouse; // 0x110
	private static readonly Guid[] nMJeYqtRmqTPdOlvvxYisfiZollg; // 0x120
	internal static readonly ReadOnlyCollection<Guid> reservedHardwareTypeGuids; // 0x128
	private static ControllerElementIdentifier.bGyzYlFkGvakUcfidQcMxjXLDSsDA[] bgsOcxvjnoNZpJhxKKMMgLWlWhpy; // 0x130
	private static ReadOnlyCollection<ControllerElementIdentifier> MKkQEiuJyWCQrkKGpYKSSgTYvOoTA; // 0x138
	private static ReadOnlyCollection<ControllerElementIdentifier> xdFYEJSGZlvKCznXOFNprWhAysAe; // 0x140
	internal static readonly IList<string> mouseAxisUnityNames; // 0x148
	private static readonly string[] dHIcYlBHqHsZynttFCZGVdoAufFEA; // 0x150
	internal static readonly IList<string> mouseButtonUnityNames; // 0x158
	private static readonly string[] gwPayGFVfYTPbAZRIOFnbzbrYnOEA; // 0x160
	internal static readonly IList<string> keyboardKeyNames; // 0x168
	private static readonly string[] wpbktqsGIhszPkgfDHiiVeStpxCQ; // 0x170
	internal static readonly IList<int> keyboardKeyValues; // 0x178
	internal static readonly int[] _keyboardKeyValues; // 0x180
	private static readonly IList<string> JMfOnhxbvMQvgsnCkihomrEYbzzfA; // 0x188
	private static readonly string[] HjEnwglFzWMBOoozkWsThgwmIirx; // 0x190
	private static readonly IList<string> iudFYwPXJvulksploFoxwbSmbNTiA; // 0x198
	private static readonly string[] vCkqBrocDNjUqTaGiswCPuwZpBDh; // 0x1A0
	internal static readonly IReadOnlyDictionary<int, Keyboard.ModifierKeyInfo> modifierKeyInfo; // 0x1A8
	public const int vendorId_sony = 1356;
	internal static readonly IList<PidVid> pidVids_sony_dualShock4; // 0x1B0
	private static readonly PidVid[] lsKEqfBvufsaqgdJQpaIxidYzGlhA; // 0x1B8
	internal static readonly IList<string> productNames_sony_dualShock4; // 0x1C0
	private static readonly string[] yQEgOfbQAffkyudYAnQEDtqbRVefB; // 0x1C8
	internal static readonly IList<PidVid> pidVids_sony_dualSense; // 0x1D0
	private static readonly PidVid[] MpyMFaSimvLXLOIZDiulETAjkHdr; // 0x1D8
	internal static readonly IList<string> productNames_sony_dualSense; // 0x1E0
	private static readonly string[] cSYHbLIyNPCuNFqVoauVNMdaSJzP; // 0x1E8
	private static readonly ControllerElementIdentifier[] xmmvCPghwUPLLdLCSHJmWVVacbVHA; // 0x1F0
	internal const int updateLoopTypeCount = 3;

	// Properties
	internal static int nintendoSwitchPlugin_minPluginVersion { get; }
	internal static int nintendoSwitch2Plugin_minPluginVersion { get; }
	internal static int gameCorePlugin_minPluginVersion { get; }
	internal static int ps4Plugin_minPluginVersion { get; }
	internal static int ps5Plugin_minPluginVersion { get; }
	internal static ControllerElementIdentifier.bGyzYlFkGvakUcfidQcMxjXLDSsDA[] commonMouseElementIdentifierInitOptions { get; }
	internal static IList<ControllerElementIdentifier> unityUnifiedMouseElementIdentifiers { get; }
	internal static IList<ControllerElementIdentifier> rawInputUnifiedMouseElementIdentifiers { get; }
	public static IList<string> keyboardKeyKeys { get; }
	public static IList<string> keyboardModifierKeyKeys { get; }
	internal static ControllerElementIdentifier[] unknownJoystickElementIdentifiers_orig { get; }

	// Methods

	// RVA: 0x16A1FB0 Offset: 0x16A05B0 VA: 0x1816A1FB0
	internal static int get_nintendoSwitchPlugin_minPluginVersion() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	internal static int get_nintendoSwitch2Plugin_minPluginVersion() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	internal static int get_gameCorePlugin_minPluginVersion() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	internal static int get_ps4Plugin_minPluginVersion() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	internal static int get_ps5Plugin_minPluginVersion() { }

	// RVA: 0x169C8B0 Offset: 0x169AEB0 VA: 0x18169C8B0
	private static void .cctor() { }

	// RVA: 0x16A0FC0 Offset: 0x169F5C0 VA: 0x1816A0FC0
	internal static ControllerElementIdentifier.bGyzYlFkGvakUcfidQcMxjXLDSsDA[] get_commonMouseElementIdentifierInitOptions() { }

	// RVA: 0x16A23F0 Offset: 0x16A09F0 VA: 0x1816A23F0
	internal static IList<ControllerElementIdentifier> get_unityUnifiedMouseElementIdentifiers() { }

	// RVA: 0x16A1FC0 Offset: 0x16A05C0 VA: 0x1816A1FC0
	internal static IList<ControllerElementIdentifier> get_rawInputUnifiedMouseElementIdentifiers() { }

	// RVA: 0x16A1EF0 Offset: 0x16A04F0 VA: 0x1816A1EF0
	public static IList<string> get_keyboardKeyKeys() { }

	// RVA: 0x16A1F50 Offset: 0x16A0550 VA: 0x1816A1F50
	public static IList<string> get_keyboardModifierKeyKeys() { }

	// RVA: 0x16A28D0 Offset: 0x16A0ED0 VA: 0x1816A28D0
	internal static ControllerElementIdentifier[] get_unknownJoystickElementIdentifiers_orig() { }

	// RVA: 0x169BC70 Offset: 0x169A270 VA: 0x18169BC70
	private static ControllerElementIdentifier[] WgNYZiMvhvKSmkAkEdGYiElEcDHm() { }
}

// Namespace: Rewired
public abstract class Controller // TypeDefIndex: 1805
{
	// Fields
	public readonly int id; // 0x10
	protected string _tag; // 0x18
	protected string _name; // 0x20
	private readonly DeviceLocalizationInfo ktjfKAkXSgEWtcoYvESsrEStHfXqA; // 0x28
	protected string _hardwareName; // 0x30
	protected readonly ControllerType _type; // 0x38
	internal readonly Guid htGdydDAehGzXKOjwvJrpfYYBoFN; // 0x3C
	protected string _hardwareIdentifier; // 0x50
	protected bool _isConnected; // 0x58
	private Controller.Extension mXyhTrJiPocfooPtAbtrFUUoZfVQA; // 0x60
	private bool WZnwJFsgrFufeGLwcawLfxcertDpA; // 0x68
	private ControllerIdentifier oTTDACSTacXivteChZwMofyljqVj; // 0x70
	internal int QfoMlUwoZvbDNduOcBCPbqzLkAzv; // 0xA0
	protected readonly int _buttonCount; // 0xA4
	protected readonly Controller.Button[] buttons; // 0xA8
	protected readonly ReadOnlyCollection<Controller.Button> buttons_readOnly; // 0xB0
	private readonly IList<Controller.Element> kOMFLyVHwCgTNBZeCTreLijZfQsFA; // 0xB8
	private readonly ReadOnlyCollection<Controller.Element> yBRftUKxGuMYhFbsFwhGqioibowt; // 0xC0
	private readonly IList<Controller.CompoundElement> XxOUIvqgKqeKuiEtmctGgQJJLbghB; // 0xC8
	private readonly ReadOnlyCollection<Controller.CompoundElement> xijdTwCVYLlxfdRqtMCYWxYtXCxW; // 0xD0
	[CustomObfuscation(rename = False)]
	internal readonly InputSource inputSource; // 0xD8
	internal readonly ControllerDataUpdater mayyHLPNyfbJMAsCWGYjuZVIlqBiA; // 0xE0
	internal readonly HardwareControllerMap_Game YgLFpavjNVbLIfOsDIGTYgZxcZNGA; // 0xE8
	internal uint YLqFtssdtUyhXDdfndGyLhzwfixEA; // 0xF0
	private uint fHuJEDgVYkqOzAoYSvDHUIFVORUK; // 0xF4
	private uint XMjqrIsAFleJEEtXbbbpEQYZcFhGb; // 0xF8
	private ITryGetLocalizedName ERfsfJXzYgxEPrWWcYspfwCNSeob; // 0x100
	private readonly LocalizedString sqhkOfIBPiNECSsUCyDZMDfwHZkt; // 0x108
	private readonly tmpzpaZXCvsusfPERWtQvkUUQTDv YsFTKkFzzDauoADFsCcXlxUNByxh; // 0x110
	private Action<bool> AdBonhKDXEcbJiraBMzkaKtHnYqvb; // 0x118
	private IControllerTemplate[] LbGiaijFqfdmkxyDQbqFXqtTxzNp; // 0x120
	private ReadOnlyCollection<IControllerTemplate> bZczXLzRChgVIAtaXtQvhyLxADnH; // 0x128
	private static Func<Controller, Guid, bool> EAWhCuAlLavjLUqfKnJFjLPpqFUwA; // 0x0
	private static Func<Controller, Type, bool> aGLEooQIApkDLOJsNcvwyVrSinvf; // 0x8

	// Properties
	internal bool FTtJwTdFneoivxdrzzjlJnaRVZrm { get; }
	public bool enabled { get; set; }
	public string name { get; set; }
	public string tag { get; set; }
	public string hardwareName { get; }
	public ControllerType type { get; }
	public Guid hardwareTypeGuid { get; }
	public abstract Guid deviceInstanceGuid { get; }
	public ControllerIdentifier identifier { get; }
	public bool isConnected { get; set; }
	public string hardwareIdentifier { get; }
	public string mapTypeString { get; }
	public int elementCount { get; }
	public int buttonCount { get; }
	public IList<Controller.Element> Elements { get; }
	public IList<Controller.CompoundElement> CompoundElements { get; }
	public IList<Controller.Button> Buttons { get; }
	public Controller.Extension extension { get; }
	public IList<ControllerElementIdentifier> ElementIdentifiers { get; }
	public IList<ControllerElementIdentifier> ButtonElementIdentifiers { get; }
	internal ITryGetLocalizedName OXxiuXsyOqbRHnVEHGAokXPXcsTE { get; set; }
	public IList<IControllerTemplate> Templates { get; }
	public int templateCount { get; }
	internal static Func<Controller, Guid, bool> NOKxMiqhpFtwrmFsIQHvLDEbomRt { get; }
	internal static Func<Controller, Type, bool> yuITUvnUXlCglxExnvwJIzKaPWyj { get; }

	// Methods

	// RVA: 0x16BE430 Offset: 0x16BCA30 VA: 0x1816BE430
	internal bool UUZtIeZoxobmpTTjdKFqrcBwKjcf() { }

	// RVA: 0x16BF5F0 Offset: 0x16BDBF0 VA: 0x1816BF5F0
	public bool get_enabled() { }

	// RVA: 0x16C00B0 Offset: 0x16BE6B0 VA: 0x1816C00B0
	public void set_enabled(bool value) { }

	// RVA: 0x16BFA60 Offset: 0x16BE060 VA: 0x1816BFA60
	public string get_name() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void bBmQnydqmurKGRRDFDRSJhhUKZIN(string ) { }

	// RVA: 0x16BFCC0 Offset: 0x16BE2C0 VA: 0x1816BFCC0
	public string get_tag() { }

	// RVA: 0x16C00D0 Offset: 0x16BE6D0 VA: 0x1816C00D0
	public void set_tag(string value) { }

	// RVA: 0x16BF7B0 Offset: 0x16BDDB0 VA: 0x1816BF7B0
	public string get_hardwareName() { }

	// RVA: 0x16BFE00 Offset: 0x16BE400 VA: 0x1816BFE00
	public ControllerType get_type() { }

	// RVA: 0x16BF850 Offset: 0x16BDE50 VA: 0x1816BF850
	public Guid get_hardwareTypeGuid() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_deviceInstanceGuid();

	// RVA: 0x16BF920 Offset: 0x16BDF20 VA: 0x1816BF920
	public ControllerIdentifier get_identifier() { }

	// RVA: 0x16BF950 Offset: 0x16BDF50 VA: 0x1816BF950
	public bool get_isConnected() { }

	// RVA: 0x16BD1C0 Offset: 0x16BB7C0 VA: 0x1816BD1C0
	internal void HYsEENYLXIEcUJrjKPRMYUefrffdb(bool ) { }

	// RVA: 0x16BF710 Offset: 0x16BDD10 VA: 0x1816BF710
	public string get_hardwareIdentifier() { }

	// RVA: 0x16BF9E0 Offset: 0x16BDFE0 VA: 0x1816BF9E0
	public string get_mapTypeString() { }

	// RVA: 0x16BF540 Offset: 0x16BDB40 VA: 0x1816BF540
	public int get_elementCount() { }

	// RVA: 0x16BF4B0 Offset: 0x16BDAB0 VA: 0x1816BF4B0
	public int get_buttonCount() { }

	// RVA: 0x16BF370 Offset: 0x16BD970 VA: 0x1816BF370
	public IList<Controller.Element> get_Elements() { }

	// RVA: 0x16BF220 Offset: 0x16BD820 VA: 0x1816BF220
	public IList<Controller.CompoundElement> get_CompoundElements() { }

	// RVA: 0x16BF180 Offset: 0x16BD780 VA: 0x1816BF180
	public IList<Controller.Button> get_Buttons() { }

	// RVA: 0x16BF680 Offset: 0x16BDC80 VA: 0x1816BF680
	public Controller.Extension get_extension() { }

	// RVA: 0x16BF2C0 Offset: 0x16BD8C0 VA: 0x1816BF2C0
	public IList<ControllerElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x16BF0D0 Offset: 0x16BD6D0 VA: 0x1816BF0D0
	public IList<ControllerElementIdentifier> get_ButtonElementIdentifiers() { }

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	internal ITryGetLocalizedName UZfXjpogeSFtFbPZxZEnMfvrldyK() { }

	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	internal void pStJBKfYATpvVvTeVsNrfQQGLNLQ(ITryGetLocalizedName ) { }

	// RVA: 0x16BDB40 Offset: 0x16BC140 VA: 0x1816BDB40
	internal void OlAokcdVAEYYBebJwhGnTsvxdLxL(Action<bool> ) { }

	// RVA: 0x16C0270 Offset: 0x16BE870 VA: 0x1816C0270
	internal void wJSoMSCbHeGYPfGANLPmzcZFOIXI(Action<bool> ) { }

	// RVA: 0x16BE5B0 Offset: 0x16BCBB0 VA: 0x1816BE5B0
	internal void .ctor(int , InputSource , string , string , string , ControllerType , Guid , int , bool[] , HardwareButtonInfo[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x16C0180 Offset: 0x16BE780 VA: 0x1816C0180 Slot: 5
	internal virtual void uZjQGmTJhFKwensHdNpNIzWKmruB() { }

	// RVA: 0x16BC5F0 Offset: 0x16BABF0 VA: 0x1816BC5F0 Slot: 6
	public virtual Controller.Element GetElementById(int elementIdentifierId) { }

	// RVA: 0x16BC450 Offset: 0x16BAA50 VA: 0x1816BC450 Slot: 7
	public virtual Controller.CompoundElement GetCompoundElementById(int elementIdentifierId) { }

	[Obsolete("This method is deprecated. Use GetCompoundElementById instead.", False)]
	// RVA: 0x16BC5D0 Offset: 0x16BABD0 VA: 0x1816BC5D0 Slot: 8
	public virtual Controller.CompoundElement GetCompundElementById(int elementIdentifierId) { }

	// RVA: 0x16BB840 Offset: 0x16B9E40 VA: 0x1816BB840
	public int GetButtonIndexById(int elementIdentifierId) { }

	// RVA: 0x16BC6D0 Offset: 0x16BACD0 VA: 0x1816BC6D0
	public ControllerElementIdentifier GetElementIdentifierById(int elementIdentifierId) { }

	// RVA: 0x16BC380 Offset: 0x16BA980 VA: 0x1816BC380 Slot: 9
	public virtual bool GetButton(int index) { }

	// RVA: 0x16BB770 Offset: 0x16B9D70 VA: 0x1816BB770 Slot: 10
	public virtual bool GetButtonDown(int index) { }

	// RVA: 0x16BC2B0 Offset: 0x16BA8B0 VA: 0x1816BC2B0 Slot: 11
	public virtual bool GetButtonUp(int index) { }

	// RVA: 0x16BAE90 Offset: 0x16B9490 VA: 0x1816BAE90 Slot: 12
	public virtual bool GetButtonChanged(int index) { }

	// RVA: 0x16BBD70 Offset: 0x16BA370 VA: 0x1816BBD70 Slot: 13
	public virtual bool GetButtonPrev(int index) { }

	// RVA: 0x16BB5D0 Offset: 0x16B9BD0 VA: 0x1816BB5D0 Slot: 14
	public virtual bool GetButtonDoublePressHold(int index) { }

	// RVA: 0x16BB4E0 Offset: 0x16B9AE0 VA: 0x1816BB4E0 Slot: 15
	public virtual bool GetButtonDoublePressHold(int index, float speed) { }

	// RVA: 0x16BB260 Offset: 0x16B9860 VA: 0x1816BB260 Slot: 16
	public virtual bool GetButtonDoublePressDown(int index) { }

	// RVA: 0x16BB170 Offset: 0x16B9770 VA: 0x1816BB170 Slot: 17
	public virtual bool GetButtonDoublePressDown(int index, float speed) { }

	// RVA: 0x16BBF30 Offset: 0x16BA530 VA: 0x1816BBF30 Slot: 18
	public virtual double GetButtonTimePressed(int index) { }

	// RVA: 0x16BC0F0 Offset: 0x16BA6F0 VA: 0x1816BC0F0 Slot: 19
	public virtual double GetButtonTimeUnpressed(int index) { }

	// RVA: 0x16BB9F0 Offset: 0x16B9FF0 VA: 0x1816BB9F0 Slot: 20
	public virtual double GetButtonLastTimePressed(int index) { }

	// RVA: 0x16BBBB0 Offset: 0x16BA1B0 VA: 0x1816BBBB0 Slot: 21
	public virtual double GetButtonLastTimeUnpressed(int index) { }

	// RVA: 0x16BACB0 Offset: 0x16B92B0 VA: 0x1816BACB0 Slot: 22
	public virtual bool GetAnyButton() { }

	// RVA: 0x16BA9E0 Offset: 0x16B8FE0 VA: 0x1816BA9E0 Slot: 23
	public virtual bool GetAnyButtonDown() { }

	// RVA: 0x16BABC0 Offset: 0x16B91C0 VA: 0x1816BABC0 Slot: 24
	public virtual bool GetAnyButtonUp() { }

	// RVA: 0x16BAAD0 Offset: 0x16B90D0 VA: 0x1816BAAD0 Slot: 25
	public virtual bool GetAnyButtonPrev() { }

	// RVA: 0x16BA7E0 Offset: 0x16B8DE0 VA: 0x1816BA7E0 Slot: 26
	public virtual bool GetAnyButtonChanged() { }

	// RVA: 0x16BADA0 Offset: 0x16B93A0 VA: 0x1816BADA0 Slot: 27
	public virtual bool GetButtonById(int elementIdentifierId) { }

	// RVA: 0x16BB680 Offset: 0x16B9C80 VA: 0x1816BB680 Slot: 28
	public virtual bool GetButtonDownById(int elementIdentifierId) { }

	// RVA: 0x16BC1C0 Offset: 0x16BA7C0 VA: 0x1816BC1C0 Slot: 29
	public virtual bool GetButtonUpById(int elementIdentifierId) { }

	// RVA: 0x16BB3E0 Offset: 0x16B99E0 VA: 0x1816BB3E0 Slot: 30
	public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId, float speed) { }

	// RVA: 0x16BAFA0 Offset: 0x16B95A0 VA: 0x1816BAFA0 Slot: 31
	public virtual bool GetButtonDoublePressDownById(int elementIdentifierId, float speed) { }

	// RVA: 0x16BB310 Offset: 0x16B9910 VA: 0x1816BB310 Slot: 32
	public virtual bool GetButtonDoublePressHoldById(int elementIdentifierId) { }

	// RVA: 0x16BB0A0 Offset: 0x16B96A0 VA: 0x1816BB0A0 Slot: 33
	public virtual bool GetButtonDoublePressDownById(int elementIdentifierId) { }

	// RVA: 0x16BBC80 Offset: 0x16BA280 VA: 0x1816BBC80 Slot: 34
	public virtual bool GetButtonPrevById(int elementIdentifierId) { }

	// RVA: 0x16BBE40 Offset: 0x16BA440 VA: 0x1816BBE40 Slot: 35
	public virtual double GetButtonTimePressedById(int elementIdentifierId) { }

	// RVA: 0x16BC000 Offset: 0x16BA600 VA: 0x1816BC000 Slot: 36
	public virtual double GetButtonTimeUnpressedById(int elementIdentifierId) { }

	// RVA: 0x16BB900 Offset: 0x16B9F00 VA: 0x1816BB900 Slot: 37
	public virtual double GetButtonLastTimePressedById(int elementIdentifierId) { }

	// RVA: 0x16BBAC0 Offset: 0x16BA0C0 VA: 0x1816BBAC0 Slot: 38
	public virtual double GetButtonLastTimeUnpressedById(int elementIdentifierId) { }

	// RVA: 0x16BE170 Offset: 0x16BC770 VA: 0x1816BE170 Slot: 39
	public virtual ControllerPollingInfo PollForFirstElement() { }

	// RVA: 0x16BE120 Offset: 0x16BC720 VA: 0x1816BE120 Slot: 40
	public virtual ControllerPollingInfo PollForFirstElementDown() { }

	// RVA: 0x16BDF10 Offset: 0x16BC510 VA: 0x1816BDF10 Slot: 41
	public virtual ControllerPollingInfo PollForFirstButton() { }

	// RVA: 0x16BDD00 Offset: 0x16BC300 VA: 0x1816BDD00 Slot: 42
	public virtual ControllerPollingInfo PollForFirstButtonDown() { }

	// RVA: 0x16B79A0 Offset: 0x16B5FA0 VA: 0x1816B79A0 Slot: 43
	public virtual IEnumerable<ControllerPollingInfo> PollForAllElements() { }

	// RVA: 0x1532960 Offset: 0x1530F60 VA: 0x181532960 Slot: 44
	public virtual IEnumerable<ControllerPollingInfo> PollForAllElementsDown() { }

	[IteratorStateMachine(typeof(Controller.UkiZSmKCYrVlAuEbMDQeEKtiKseP))]
	// RVA: 0x16BDC80 Offset: 0x16BC280 VA: 0x1816BDC80 Slot: 45
	public virtual IEnumerable<ControllerPollingInfo> PollForAllButtons() { }

	[IteratorStateMachine(typeof(Controller.WyVDHNUPVCrwqHquOipBszoIShNr))]
	// RVA: 0x16BDC00 Offset: 0x16BC200 VA: 0x1816BDC00 Slot: 46
	public virtual IEnumerable<ControllerPollingInfo> PollForAllButtonsDown() { }

	// RVA: 0x16BEFF0 Offset: 0x16BD5F0 VA: 0x1816BEFF0
	private bool fYAPCdOQhnCiDgwIsTdARFpuqBOV(int , out int ) { }

	// RVA: 0x16BA700 Offset: 0x16B8D00 VA: 0x1816BA700
	private bool FffcURYUkBAEMKXsJaAGatDFwdhmA(int , out int ) { }

	// RVA: 0x16BE490 Offset: 0x16BCA90 VA: 0x1816BE490
	protected void UpdatePollingFrameTracking() { }

	// RVA: 0x16BC910 Offset: 0x16BAF10 VA: 0x1816BC910 Slot: 47
	public virtual double GetLastTimeActive() { }

	// RVA: 0x16BC780 Offset: 0x16BAD80 VA: 0x1816BC780 Slot: 48
	public virtual double GetLastTimeActive(bool useRawValues) { }

	// RVA: 0x16BCD70 Offset: 0x16BB370 VA: 0x1816BCD70 Slot: 49
	public virtual double GetLastTimeAnyElementChanged() { }

	// RVA: 0x16BCCE0 Offset: 0x16BB2E0 VA: 0x1816BCCE0 Slot: 50
	public virtual double GetLastTimeAnyElementChanged(bool useRawValues) { }

	// RVA: 0x16BCBD0 Offset: 0x16BB1D0 VA: 0x1816BCBD0
	public double GetLastTimeAnyButtonPressed() { }

	// RVA: 0x16BC9B0 Offset: 0x16BAFB0 VA: 0x1816BC9B0
	public double GetLastTimeAnyButtonChanged() { }

	// RVA: -1 Offset: -1
	public T GetExtension<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC600 Offset: 0x6BAC00 VA: 0x1806BC600
	|-Controller.GetExtension<object>
	*/

	// RVA: 0x16BF410 Offset: 0x16BDA10 VA: 0x1816BF410
	public IList<IControllerTemplate> get_Templates() { }

	// RVA: 0x16BFD60 Offset: 0x16BE360 VA: 0x1816BFD60
	public int get_templateCount() { }

	// RVA: 0x16BCF50 Offset: 0x16BB550 VA: 0x1816BCF50
	public IControllerTemplate GetTemplate(Guid typeGuid) { }

	// RVA: 0x16BCE10 Offset: 0x16BB410 VA: 0x1816BCE10
	public IControllerTemplate GetTemplate(Type type) { }

	// RVA: -1 Offset: -1
	public T GetTemplate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC6C0 Offset: 0x6BACC0 VA: 0x1806BC6C0
	|-Controller.GetTemplate<object>
	*/

	// RVA: 0x16BD430 Offset: 0x16BBA30 VA: 0x1816BD430
	public bool ImplementsTemplate(Guid typeGuid) { }

	// RVA: 0x16BD290 Offset: 0x16BB890 VA: 0x1816BD290
	public bool ImplementsTemplate(Type type) { }

	// RVA: -1 Offset: -1
	public bool ImplementsTemplate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC840 Offset: 0x6BAE40 VA: 0x1806BC840
	|-Controller.ImplementsTemplate<object>
	*/

	// RVA: 0x16BE280 Offset: 0x16BC880 VA: 0x1816BE280
	internal void QxemHteCHgaRWDFZhbXXDOeXXWOzA(IControllerTemplate[] ) { }

	// RVA: 0x16BD620 Offset: 0x16BBC20 VA: 0x1816BD620 Slot: 51
	internal virtual void JXxDIRZpnsgiGXNGCAUihWVkSdwx(UpdateLoopType ) { }

	// RVA: 0x16BEE50 Offset: 0x16BD450 VA: 0x1816BEE50 Slot: 52
	internal virtual ButtonStateFlags dbWXilhpsuaozfsrLNKPdReTVsTz(int ) { }

	// RVA: 0x16BE330 Offset: 0x16BC930 VA: 0x1816BE330
	internal void SPXuKnPjyjbxzfWDiqFDuSePMoeyA(Controller.Extension ) { }

	// RVA: 0x16BE1C0 Offset: 0x16BC7C0 VA: 0x1816BE1C0
	internal void QRTRQBWkxyvvePOVredTwUDEzpzf(Controller.Extension ) { }

	// RVA: 0x16BEF50 Offset: 0x16BD550 VA: 0x1816BEF50 Slot: 53
	internal virtual void fDlKuMABpdnNzezjAcKGsqfGpGcE() { }

	// RVA: 0x16BA680 Offset: 0x16B8C80 VA: 0x1816BA680 Slot: 54
	internal virtual bool ElEvIvMPwHGEirtSjuwsUVBdtARp(bool ) { }

	// RVA: 0x16BD8D0 Offset: 0x16BBED0 VA: 0x1816BD8D0 Slot: 55
	internal virtual void NgSVRXtzGmXahkQxjWThqqmlVJXH(ControllerMap ) { }

	// RVA: 0x16BA390 Offset: 0x16B8990 VA: 0x1816BA390 Slot: 56
	internal virtual void BEMHamOlnupxqKxDqmuyQAAUjGvI(ControllerMap , ActionElementMap ) { }

	// RVA: 0x16BA3B0 Offset: 0x16B89B0 VA: 0x1816BA3B0
	internal bool BhzdfiHmvjPaSSQWVEBDFmbjimpGA(ActionElementMap , int , out float , out bool ) { }

	// RVA: 0x16C01E0 Offset: 0x16BE7E0 VA: 0x1816C01E0
	internal bool vnFaGDYjXsKhIsXTfBghxGrFaRBU(ActionElementMap , int , bool , out float ) { }

	// RVA: 0x16BD160 Offset: 0x16BB760 VA: 0x1816BD160
	internal void HDTybFzIBBMQxccCIHrbcPWPQJSwA(Controller.Element ) { }

	// RVA: 0x16C0050 Offset: 0x16BE650 VA: 0x1816C0050
	internal void sHiwsqKNZVpsDoPyHvVjwyOsEbIq(Controller.CompoundElement ) { }

	// RVA: 0x16C0330 Offset: 0x16BE930 VA: 0x1816C0330 Slot: 57
	internal virtual Guid yVyNmGlVHDfMrWvbxQEMBlvOGLSCA() { }

	// RVA: 0x16BFFD0 Offset: 0x16BE5D0 VA: 0x1816BFFD0 Slot: 58
	internal virtual void pmKeldfEgYcUHdSZgCOYBoCGnvRfc(bool ) { }

	// RVA: 0x16BA650 Offset: 0x16B8C50 VA: 0x1816BA650 Slot: 59
	protected virtual void Connected() { }

	// RVA: 0x16BA660 Offset: 0x16B8C60 VA: 0x1816BA660 Slot: 60
	protected virtual void Disconnected() { }

	// RVA: 0x16BD790 Offset: 0x16BBD90 VA: 0x1816BD790
	internal static Func<Controller, Guid, bool> JwqrWkIaiNaMrDpOTxHiSQecJUdEA() { }

	// RVA: 0x16BFE90 Offset: 0x16BE490 VA: 0x1816BFE90
	internal static Func<Controller, Type, bool> nQncvRzizCXrirWhtWVmIKiKnHNH() { }

	[CompilerGenerated]
	// RVA: 0x16BA6F0 Offset: 0x16B8CF0 VA: 0x1816BA6F0
	private void FNJwgtObXlUDXpqfYIEPAYbPxfIGA() { }
}

// Namespace: Rewired
public abstract class ControllerWithAxes : ControllerWithMap // TypeDefIndex: 1809
{
	// Fields
	protected readonly int _axisCount; // 0x130
	protected readonly int _axis2DCount; // 0x134
	protected readonly Controller.Axis[] axes; // 0x138
	protected readonly ReadOnlyCollection<Controller.Axis> axes_readOnly; // 0x140
	protected readonly Controller.Axis2D[] axes2D; // 0x148
	protected readonly ReadOnlyCollection<Controller.Axis2D> axes2D_readOnly; // 0x150
	protected readonly CalibrationMap _calibrationMap; // 0x158
	private float[] YVaFlCtCgKKVdIEByDBjmIQhCeVC; // 0x160
	private uint FBzvJfAnCDYFXWRyZhBgJDHaetEl; // 0x168
	private TimerAbs ZcqrjRxJMVfjSPFLFZNzTTCuocxu; // 0x170
	private float[] bkkTdHVzxktjSxnPucMgvtOhjqLl; // 0x178
	private Func<int, int> FoPeMLbkOHGcORuiphsVCkEJYLHWb; // 0x180

	// Properties
	public int axisCount { get; }
	public int axis2DCount { get; }
	public IList<Controller.Axis> Axes { get; }
	public IList<Controller.Axis2D> Axes2D { get; }
	public CalibrationMap calibrationMap { get; }
	public IList<ControllerElementIdentifier> AxisElementIdentifiers { get; }

	// Methods

	// RVA: 0x16B9E10 Offset: 0x16B8410 VA: 0x1816B9E10
	public int get_axisCount() { }

	// RVA: 0x16B9D80 Offset: 0x16B8380 VA: 0x1816B9D80
	public int get_axis2DCount() { }

	// RVA: 0x16B9C20 Offset: 0x16B8220 VA: 0x1816B9C20
	public IList<Controller.Axis> get_Axes() { }

	// RVA: 0x16B9B80 Offset: 0x16B8180 VA: 0x1816B9B80
	public IList<Controller.Axis2D> get_Axes2D() { }

	// RVA: 0x16B9EA0 Offset: 0x16B84A0 VA: 0x1816B9EA0
	public CalibrationMap get_calibrationMap() { }

	// RVA: 0x16B9CC0 Offset: 0x16B82C0 VA: 0x1816B9CC0
	public IList<ControllerElementIdentifier> get_AxisElementIdentifiers() { }

	// RVA: 0x16B8AF0 Offset: 0x16B70F0 VA: 0x1816B8AF0
	internal void .ctor(int , InputSource , string , string , string , ControllerType , Guid , int , int , bool[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x16B69E0 Offset: 0x16B4FE0 VA: 0x1816B69E0 Slot: 6
	public override Controller.Element GetElementById(int elementIdentifierId) { }

	// RVA: 0x16B5510 Offset: 0x16B3B10 VA: 0x1816B5510
	public int GetAxisIndexById(int elementIdentifierId) { }

	// RVA: 0x16B6910 Offset: 0x16B4F10 VA: 0x1816B6910
	public float GetAxis(int index) { }

	// RVA: 0x16B5A40 Offset: 0x16B4040 VA: 0x1816B5A40
	public float GetAxisPrev(int index) { }

	// RVA: 0x16B64C0 Offset: 0x16B4AC0 VA: 0x1816B64C0
	public float GetAxisRaw(int index) { }

	// RVA: 0x16B6070 Offset: 0x16B4670 VA: 0x1816B6070
	public float GetAxisRawPrev(int index) { }

	// RVA: 0x16B6680 Offset: 0x16B4C80 VA: 0x1816B6680
	public double GetAxisTimeActive(int index) { }

	// RVA: 0x16B6840 Offset: 0x16B4E40 VA: 0x1816B6840
	public double GetAxisTimeInactive(int index) { }

	// RVA: 0x16B56C0 Offset: 0x16B3CC0 VA: 0x1816B56C0
	public double GetAxisLastTimeActive(int index) { }

	// RVA: 0x16B5880 Offset: 0x16B3E80 VA: 0x1816B5880
	public double GetAxisLastTimeInactive(int index) { }

	// RVA: 0x16B6230 Offset: 0x16B4830 VA: 0x1816B6230
	public double GetAxisRawTimeActive(int index) { }

	// RVA: 0x16B63F0 Offset: 0x16B49F0 VA: 0x1816B63F0
	public double GetAxisRawTimeInactive(int index) { }

	// RVA: 0x16B5CF0 Offset: 0x16B42F0 VA: 0x1816B5CF0
	public double GetAxisRawLastTimeActive(int index) { }

	// RVA: 0x16B5EB0 Offset: 0x16B44B0 VA: 0x1816B5EB0
	public double GetAxisRawLastTimeInactive(int index) { }

	// RVA: 0x16B5420 Offset: 0x16B3A20 VA: 0x1816B5420
	public float GetAxisById(int elementIdentifierId) { }

	// RVA: 0x16B5950 Offset: 0x16B3F50 VA: 0x1816B5950
	public float GetAxisPrevById(int elementIdentifierId) { }

	// RVA: 0x16B5B10 Offset: 0x16B4110 VA: 0x1816B5B10
	public float GetAxisRawById(int elementIdentifierId) { }

	// RVA: 0x16B5F80 Offset: 0x16B4580 VA: 0x1816B5F80
	public float GetAxisRawPrevById(int elementIdentifierId) { }

	// RVA: 0x16B6590 Offset: 0x16B4B90 VA: 0x1816B6590
	public double GetAxisTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x16B6750 Offset: 0x16B4D50 VA: 0x1816B6750
	public double GetAxisTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x16B55D0 Offset: 0x16B3BD0 VA: 0x1816B55D0
	public double GetAxisLastTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x16B5790 Offset: 0x16B3D90 VA: 0x1816B5790
	public double GetAxisLastTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x16B6140 Offset: 0x16B4740 VA: 0x1816B6140
	public double GetAxisRawTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x16B6300 Offset: 0x16B4900 VA: 0x1816B6300
	public double GetAxisRawTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x16B5C00 Offset: 0x16B4200 VA: 0x1816B5C00
	public double GetAxisRawLastTimeActiveById(int elementIdentifierId) { }

	// RVA: 0x16B5DC0 Offset: 0x16B43C0 VA: 0x1816B5DC0
	public double GetAxisRawLastTimeInactiveById(int elementIdentifierId) { }

	// RVA: 0x16B52F0 Offset: 0x16B38F0 VA: 0x1816B52F0
	public Vector2 GetAxis2D(int index) { }

	// RVA: 0x16B4F60 Offset: 0x16B3560 VA: 0x1816B4F60
	public Vector2 GetAxis2DPrev(int index) { }

	// RVA: 0x16B51C0 Offset: 0x16B37C0 VA: 0x1816B51C0
	public Vector2 GetAxis2DRaw(int index) { }

	// RVA: 0x16B5090 Offset: 0x16B3690 VA: 0x1816B5090
	public Vector2 GetAxis2DRawPrev(int index) { }

	// RVA: 0x16B6DB0 Offset: 0x16B53B0 VA: 0x1816B6DB0 Slot: 47
	public override double GetLastTimeActive() { }

	// RVA: 0x16B6B90 Offset: 0x16B5190 VA: 0x1816B6B90 Slot: 48
	public override double GetLastTimeActive(bool useRawValues) { }

	// RVA: 0x16B7280 Offset: 0x16B5880 VA: 0x1816B7280 Slot: 49
	public override double GetLastTimeAnyElementChanged() { }

	// RVA: 0x16B7130 Offset: 0x16B5730 VA: 0x1816B7130 Slot: 50
	public override double GetLastTimeAnyElementChanged(bool useRawValues) { }

	// RVA: 0x16B6FB0 Offset: 0x16B55B0 VA: 0x1816B6FB0
	public double GetLastTimeAnyAxisActive() { }

	// RVA: 0x16B6E50 Offset: 0x16B5450 VA: 0x1816B6E50
	public double GetLastTimeAnyAxisActive(bool useRawValues) { }

	// RVA: 0x16B6FC0 Offset: 0x16B55C0 VA: 0x1816B6FC0
	public double GetLastTimeAnyAxisChanged() { }

	// RVA: 0x16B6FD0 Offset: 0x16B55D0 VA: 0x1816B6FD0
	public double GetLastTimeAnyAxisChanged(bool useRawValues) { }

	// RVA: 0x16B7E90 Offset: 0x16B6490 VA: 0x1816B7E90 Slot: 39
	public override ControllerPollingInfo PollForFirstElement() { }

	// RVA: 0x16B7D90 Offset: 0x16B6390 VA: 0x1816B7D90 Slot: 40
	public override ControllerPollingInfo PollForFirstElementDown() { }

	// RVA: 0x16B7B40 Offset: 0x16B6140 VA: 0x1816B7B40
	public ControllerPollingInfo PollForFirstAxis() { }

	[IteratorStateMachine(typeof(ControllerWithAxes.YHfhRCzgItJfAVTZhHnJtzferlJA))]
	// RVA: 0x16B7AC0 Offset: 0x16B60C0 VA: 0x1816B7AC0 Slot: 43
	public override IEnumerable<ControllerPollingInfo> PollForAllElements() { }

	[IteratorStateMachine(typeof(ControllerWithAxes.WRjcgPAtkNFlYEZFDjSBjAcfMnhnb))]
	// RVA: 0x16B7A40 Offset: 0x16B6040 VA: 0x1816B7A40 Slot: 44
	public override IEnumerable<ControllerPollingInfo> PollForAllElementsDown() { }

	[IteratorStateMachine(typeof(ControllerWithAxes.gylTxPKNEpTIBybdrINKFVmXzzhbA))]
	// RVA: 0x16B79C0 Offset: 0x16B5FC0 VA: 0x1816B79C0
	public IEnumerable<ControllerPollingInfo> PollForAllAxes() { }

	// RVA: 0x16B7F90 Offset: 0x16B6590 VA: 0x1816B7F90
	private void TpsmdwzPbCfAmnFUPpjeOpCinsUx() { }

	// RVA: 0x16B7420 Offset: 0x16B5A20 VA: 0x1816B7420 Slot: 61
	protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId) { }

	// RVA: 0x16B7360 Offset: 0x16B5960 VA: 0x1816B7360
	public bool ImportCalibrationMapFromXmlString(string xmlString) { }

	// RVA: 0x16B72A0 Offset: 0x16B58A0 VA: 0x1816B72A0
	public bool ImportCalibrationMapFromJsonString(string jsonString) { }

	// RVA: 0x16B8120 Offset: 0x16B6720 VA: 0x1816B8120 Slot: 51
	internal override void XPMWBbLQOgfdOWigvMdlSHghuCCn(UpdateLoopType ) { }

	// RVA: 0x16B9F30 Offset: 0x16B8530 VA: 0x1816B9F30
	internal bool hxoYAYjjcTqqBrYrzijEIwbqJdkT(ActionElementMap , int , bool , bool , out float ) { }

	// RVA: 0x16B9670 Offset: 0x16B7C70 VA: 0x1816B9670 Slot: 55
	internal override void ayveSUNYIJQGbUPYytExxWPznumS(ControllerMap ) { }

	// RVA: 0x16B8AA0 Offset: 0x16B70A0 VA: 0x1816B8AA0 Slot: 56
	internal override void YXTzJfxTclasVpAFOQQBVnawJHMR(ControllerMap , ActionElementMap ) { }

	// RVA: 0x16B9950 Offset: 0x16B7F50 VA: 0x1816B9950
	internal void cYqklMiHMRxwYryLwXUBXCRcwLlj() { }

	// RVA: 0x16BA1D0 Offset: 0x16B87D0 VA: 0x1816BA1D0 Slot: 53
	internal override void pSRpZDXDrStnCeLKVVZEpZflUbTe() { }

	[CompilerGenerated]
	// RVA: 0x16BA0F0 Offset: 0x16B86F0 VA: 0x1816BA0F0
	private int mPjdoDVveSptqWtMVjQGnfKQLnEE(int ) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x16B79A0 Offset: 0x16B5FA0 VA: 0x1816B79A0
	private IEnumerable<ControllerPollingInfo> PceawZRGrDZhqJNrDdrzRNEczAVF() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1532960 Offset: 0x1530F60 VA: 0x181532960
	private IEnumerable<ControllerPollingInfo> ufQRZpnhTCqIdpQegKGukctCECgw() { }
}

// Namespace: Rewired
public abstract class ControllerWithMap : Controller // TypeDefIndex: 1810
{
	// Methods

	// RVA: 0x16BA2E0 Offset: 0x16B88E0 VA: 0x1816BA2E0
	internal void .ctor(int , InputSource , string , string , string , ControllerType , Guid , int , bool[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }
}

// Namespace: Rewired
public sealed class CustomController : ControllerWithAxes // TypeDefIndex: 1811
{
	// Fields
	private int ghkAiSeofZmDWfpcFAaQxxukRSNyA; // 0x188
	private Func<int, float> pMmEycEDoWIxGekINoBQaAHORowA; // 0x190
	private Func<int, bool> uZJAfobtFCrJqUpCYUoDEUmuqyfsA; // 0x198
	private bool jgvDbJjcuVKpsAujAYRUNDimTRGKb; // 0x1A0
	private Guid qToQHXWtoiPXwsePDkOTaKOArUtA; // 0x1A4

	// Properties
	public int sourceControllerId { get; }
	public override Guid deviceInstanceGuid { get; }

	// Methods

	// RVA: 0x16C1A70 Offset: 0x16C0070 VA: 0x1816C1A70
	public int get_sourceControllerId() { }

	// RVA: 0x16C19A0 Offset: 0x16BFFA0 VA: 0x1816C19A0 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x16C1440 Offset: 0x16BFA40 VA: 0x1816C1440
	internal void .ctor(jToFkZQsFXrnqRxvCpoiCDeiecsF ) { }

	// RVA: 0x16C16E0 Offset: 0x16BFCE0 VA: 0x1816C16E0
	private void .ctor(int , int , Guid , InputSource , string , string , string , int , int , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x16C1880 Offset: 0x16BFE80 VA: 0x1816C1880
	internal void aseKnKwpWutTTaCvqUpwSJIbRlbo() { }

	// RVA: 0x16C0E50 Offset: 0x16BF450 VA: 0x1816C0E50
	public void SetAxisValue(int index, float value) { }

	// RVA: 0x16C0CD0 Offset: 0x16BF2D0 VA: 0x1816C0CD0
	public void SetAxisValue(string elementName, float value) { }

	// RVA: 0x16C0B80 Offset: 0x16BF180 VA: 0x1816C0B80
	public void SetAxisValueById(int elementId, float value) { }

	// RVA: 0x16C1190 Offset: 0x16BF790 VA: 0x1816C1190
	public void SetButtonValue(int index, bool value) { }

	// RVA: 0x16C12C0 Offset: 0x16BF8C0 VA: 0x1816C12C0
	public void SetButtonValue(string elementName, bool value) { }

	// RVA: 0x16C1040 Offset: 0x16BF640 VA: 0x1816C1040
	public void SetButtonValueById(int elementId, bool value) { }

	// RVA: 0x16C0AC0 Offset: 0x16BF0C0 VA: 0x1816C0AC0
	public void SetAxisUpdateCallback(Func<int, float> callback) { }

	// RVA: 0x16C0F80 Offset: 0x16BF580 VA: 0x1816C0F80
	public void SetButtonUpdateCallback(Func<int, bool> callback) { }

	// RVA: 0x16C0490 Offset: 0x16BEA90 VA: 0x1816C0490
	public void ClearAxisValue(int index) { }

	// RVA: 0x16C05E0 Offset: 0x16BEBE0 VA: 0x1816C05E0
	public void ClearAxisValue(string elementName) { }

	// RVA: 0x16C0380 Offset: 0x16BE980 VA: 0x1816C0380
	public void ClearAxisValueById(int elementId) { }

	// RVA: 0x16C0970 Offset: 0x16BEF70 VA: 0x1816C0970
	public void ClearButtonValue(int index) { }

	// RVA: 0x16C0830 Offset: 0x16BEE30 VA: 0x1816C0830
	public void ClearButtonValue(string elementName) { }

	// RVA: 0x16C0720 Offset: 0x16BED20 VA: 0x1816C0720
	public void ClearButtonValueById(int elementId) { }
}

// Namespace: Rewired
public class Joystick : ControllerWithAxes // TypeDefIndex: 1812
{
	// Fields
	private const int wMOHxtXJjPsFraGiTITbqRvDiRTN = 0;
	private const int LudXNlMIqtfBbCpfpbMmefqosbuJA = 1;
	private IInputManagerJoystickPublic DeWFseQblgGCkfjXAiQINbZBpksgA; // 0x188
	private readonly JoystickType[] TRIJRNofnOvnYTYpsnVhAToTNDvI; // 0x190
	private readonly ReadOnlyCollection<JoystickType> zZeMzvnsksFpqxALlxBzNASChiXK; // 0x198
	private readonly bool OHiSYRPgKXDKQstZLbfFAoSwuuXs; // 0x1A0
	private readonly bool FhVTYKNbzaYOZzFLbePxawlUmjTv; // 0x1A1
	private readonly bool gxlFxcRbeJTKMGwWgEAjcxiITtTU; // 0x1A2
	private readonly int BQrqNTzusmnngpPZiBncKmRusdRwA; // 0x1A4
	private readonly float[] ozqEWpdVxPWtiDtTIkmmGystSpMEb; // 0x1A8
	private readonly TimerAbs[] LybXtDUWRVDTykDnipNkCngtYksn; // 0x1B0
	private readonly int HAYEsgJzBrjnRewobgvUlUjoagXGb; // 0x1B8
	private readonly Controller.Hat[] LoRODOATTXgyQcwioZVAeCKenLFA; // 0x1C0
	private readonly ReadOnlyCollection<Controller.Hat> GNVDwEgGGmYQNrFFCYdxQGbhaiTy; // 0x1C8
	private readonly int VkefnUJPZWahJSUQVypocQhxPOivA; // 0x1D0
	private readonly Controller.DirectionalPad[] fAlbPEAWEYhdDViywmYMHiStBcNpA; // 0x1D8
	private readonly ReadOnlyCollection<Controller.DirectionalPad> sZbbXBaJUIVqvnAiLbqHExoFGgZUb; // 0x1E0

	// Properties
	internal IList<JoystickType> GcdNOMcKonnJGQYjPAQMCdGUIgDx { get; }
	public Nullable<long> systemId { get; }
	public int unityId { get; }
	public override Guid deviceInstanceGuid { get; }
	public bool supportsVibration { get; }
	public float vibrationLeftMotor { get; set; }
	public float vibrationRightMotor { get; set; }
	public int vibrationMotorCount { get; }
	public int hatCount { get; }
	public IList<Controller.Hat> Hats { get; }
	public int directionalPadCount { get; }
	public IList<Controller.DirectionalPad> DirectionalPads { get; }
	internal int LUdhTWFTWdKKsZQqDLwilQYeKhndA { get; }
	internal HardwareControllerMapIdentifier VQwWOHkkzHSYKvnOxlHTqDGpWAth { get; }

	// Methods

	// RVA: 0x16C3F40 Offset: 0x16C2540 VA: 0x1816C3F40
	internal IList<JoystickType> JZMGEMtaHqBZqBDvfUAQqJLvtyDTA() { }

	// RVA: 0x16C6830 Offset: 0x16C4E30 VA: 0x1816C6830
	public Nullable<long> get_systemId() { }

	// RVA: 0x16C69A0 Offset: 0x16C4FA0 VA: 0x1816C69A0
	public int get_unityId() { }

	// RVA: 0x16C6520 Offset: 0x16C4B20 VA: 0x1816C6520 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x16C67A0 Offset: 0x16C4DA0 VA: 0x1816C67A0
	public bool get_supportsVibration() { }

	// RVA: 0x16C6A60 Offset: 0x16C5060 VA: 0x1816C6A60
	public float get_vibrationLeftMotor() { }

	// RVA: 0x16C70D0 Offset: 0x16C56D0 VA: 0x1816C70D0
	public void set_vibrationLeftMotor(float value) { }

	// RVA: 0x16C6CB0 Offset: 0x16C52B0 VA: 0x1816C6CB0
	public float get_vibrationRightMotor() { }

	// RVA: 0x16C7210 Offset: 0x16C5810 VA: 0x1816C7210
	public void set_vibrationRightMotor(float value) { }

	// RVA: 0x16C6BB0 Offset: 0x16C51B0 VA: 0x1816C6BB0
	public int get_vibrationMotorCount() { }

	// RVA: 0x16C6710 Offset: 0x16C4D10 VA: 0x1816C6710
	public int get_hatCount() { }

	// RVA: 0x16C6480 Offset: 0x16C4A80 VA: 0x1816C6480
	public IList<Controller.Hat> get_Hats() { }

	// RVA: 0x16C6680 Offset: 0x16C4C80 VA: 0x1816C6680
	public int get_directionalPadCount() { }

	// RVA: 0x16C63E0 Offset: 0x16C49E0 VA: 0x1816C63E0
	public IList<Controller.DirectionalPad> get_DirectionalPads() { }

	// RVA: 0x16C4A20 Offset: 0x16C3020 VA: 0x1816C4A20
	internal int XqEgLstOlrhiatUgmFoXEPEFYBGLA() { }

	// RVA: 0x16C3EE0 Offset: 0x16C24E0 VA: 0x1816C3EE0
	internal HardwareControllerMapIdentifier HeCFxMhFCaDstEeFJZxPPBPQWTvgA() { }

	// RVA: 0x16C4CD0 Offset: 0x16C32D0 VA: 0x1816C4CD0
	internal void .ctor(BridgedController ) { }

	// RVA: 0x16C54A0 Offset: 0x16C3AA0 VA: 0x1816C54A0
	private void .ctor(int , InputSource , string , string , string , Guid , int , int , bool[] , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x16C4BF0 Offset: 0x16C31F0 VA: 0x1816C4BF0
	internal bool ZhlnjWLhRzSILcUjWcafYlalBBAM(JoystickType ) { }

	// RVA: 0x16C3BD0 Offset: 0x16C21D0 VA: 0x1816C3BD0
	public JoystickCalibrationMapSaveData GetCalibrationMapSaveData() { }

	// RVA: 0x16C4790 Offset: 0x16C2D90 VA: 0x1816C4790
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x16C4260 Offset: 0x16C2860 VA: 0x1816C4260
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	// RVA: 0x16C4770 Offset: 0x16C2D70 VA: 0x1816C4770
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x16C4570 Offset: 0x16C2B70 VA: 0x1816C4570
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x16C4860 Offset: 0x16C2E60 VA: 0x1816C4860
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x16C4590 Offset: 0x16C2B90 VA: 0x1816C4590
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x16C3D70 Offset: 0x16C2370 VA: 0x1816C3D70
	public float GetVibration(int motorIndex) { }

	// RVA: 0x16C4880 Offset: 0x16C2E80 VA: 0x1816C4880
	public void StopVibration() { }

	// RVA: 0x16C40F0 Offset: 0x16C26F0 VA: 0x1816C40F0 Slot: 51
	internal override void MQaLlADKlYhXVdMaQJIFldKjZvlP(UpdateLoopType ) { }

	// RVA: 0x16C4240 Offset: 0x16C2840 VA: 0x1816C4240
	internal void QZgWghrJEuQMOBEtZAJiGrNGidTw(UpdateControllerInfoEventArgs ) { }

	// RVA: 0x16C4A00 Offset: 0x16C3000 VA: 0x1816C4A00
	internal void XIJRrxRHogPdxwFYzFWbRvNRzNbj(BridgedController ) { }

	// RVA: 0x16C6210 Offset: 0x16C4810 VA: 0x1816C6210
	private void gXQySzeEYLpWudVwIDPXuaoICWHaA(IInputManagerJoystickPublic ) { }

	// RVA: 0x16C3FE0 Offset: 0x16C25E0 VA: 0x1816C3FE0 Slot: 53
	internal override void MFfgVidyrqHaeUjyXRWKwpYwgZAM() { }

	// RVA: 0x16C3990 Offset: 0x16C1F90 VA: 0x1816C3990 Slot: 58
	internal override void AUeMIUeawVVbAiyiujjsSctJPQBr(bool ) { }

	// RVA: 0x16C3A60 Offset: 0x16C2060 VA: 0x1816C3A60 Slot: 60
	protected override void Disconnected() { }

	// RVA: 0x16C7350 Offset: 0x16C5950 VA: 0x1816C7350
	private void tkWmMofhebhKoAvvJOfVEpdUjGpnA() { }

	// RVA: 0x16C4A70 Offset: 0x16C3070 VA: 0x1816C4A70
	private void YpinGhHrBEBzjPjDnwFWGmFQwqVj(int , float , float , bool , bool ) { }

	// RVA: 0x16C6F60 Offset: 0x16C5560 VA: 0x1816C6F60
	private void mGBAlZvSEtPDMpbdVAQspfFeANKk() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void KrzJnmGxBktLeGvMgpKQYguMhSfc() { }

	// RVA: 0x16C6E00 Offset: 0x16C5400 VA: 0x1816C6E00
	internal static int kUrqalpiNSvssqfhkZEVnlvAfbubA(Joystick , Joystick ) { }
}

// Namespace: Rewired
public sealed class Keyboard : ControllerWithMap // TypeDefIndex: 1819
{
	// Fields
	private const string kFdJOVYhkJXDdZkgOusERAxKLLKG = " + ";
	private static Keyboard IZKjUHSZnRkqRQtybtgutvvVgKXT; // 0x0
	private static KeyboardKeyCode[] zMjluNMCZwhofQMGyobZQkSbjOIO; // 0x8
	private static Guid QHsIuDtDWiLOYRnovEnvUcNHKlRk; // 0x10
	private readonly IUnifiedKeyboardSource DMvfRLbwSeRowxJcmPesLdSNcLNhA; // 0x130
	private ModifierKeyFlags FVzStiHLYfbvxcSnFHYWQrdJEFwF; // 0x138
	private ModifierKeyFlags qMnmYSvKGDkotCELJzAOFrhUjbON; // 0x13C
	private Func<KeyboardKeyCode, int> UbXYpSHbAIHZmAPnShiXLDudzAby; // 0x140
	private readonly int[] XVlWrTFTCHTrWYlqyqygQkJSPGkG; // 0x148
	private readonly int vbVYzdlENjTjCYjinrtITvdNufRL; // 0x150
	private readonly tmpzpaZXCvsusfPERWtQvkUUQTDv KlDSQgAfuwAKmgdOzvcOjQZiWhATA; // 0x158
	private readonly lDKrtrlDbWluAJFFxknaEkZiWUrU MWNAkNXnOxuAiEgazHmzTxFzNtqF; // 0x160
	private Dictionary<int, Keyboard.hpHzgEwOuSFebIuJHhOUAvbcUgEaB> LmmeDggrRvdysfrbGczkIDzlxToqb; // 0x168
	private Dictionary<int, Keyboard.MZAKWzmSMiCMuQCLOljwzGGkFpTo> NYIJZHElJbgTRkFmJfimFADvwdJo; // 0x170

	// Properties
	private static KeyboardKeyCode[] oWuJWYEbmxyydgxXoBLPTmnEHPPX { get; }
	private Dictionary<int, Keyboard.hpHzgEwOuSFebIuJHhOUAvbcUgEaB> KmtrWzgZVSKuspXfqOcBCguYmmFH { get; }
	private Dictionary<int, Keyboard.MZAKWzmSMiCMuQCLOljwzGGkFpTo> SupTIqpjHieQJKCZzKhjHNtqSRcTA { get; }
	public override Guid deviceInstanceGuid { get; }

	// Methods

	// RVA: 0x17D1180 Offset: 0x17CF780 VA: 0x1817D1180
	private static KeyboardKeyCode[] ODLYdgiKeMMTFhCBLrfRYNvwGtiDA() { }

	// RVA: 0x17D2BE0 Offset: 0x17D11E0 VA: 0x1817D2BE0
	private Dictionary<int, Keyboard.hpHzgEwOuSFebIuJHhOUAvbcUgEaB> qTSgbKBtfDwSktroTIRQqcDBNmsu() { }

	// RVA: 0x17D05A0 Offset: 0x17CEBA0 VA: 0x1817D05A0
	private Dictionary<int, Keyboard.MZAKWzmSMiCMuQCLOljwzGGkFpTo> IavjxrAWbLZBZgLSCMAGynYpoazQ() { }

	// RVA: 0x17D1D00 Offset: 0x17D0300 VA: 0x1817D1D00
	internal void .ctor(string , IUnifiedKeyboardSource ) { }

	// RVA: 0x17D2230 Offset: 0x17D0830 VA: 0x1817D2230
	private void .ctor(int , InputSource , string , string , HardwareControllerMap_Game , int , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x17D2A10 Offset: 0x17D1010 VA: 0x1817D2A10 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x17CF500 Offset: 0x17CDB00 VA: 0x1817CF500
	public bool GetKey(KeyCode keyCode) { }

	// RVA: 0x17CEEB0 Offset: 0x17CD4B0 VA: 0x1817CEEB0
	public bool GetKeyDown(KeyCode keyCode) { }

	// RVA: 0x17CF410 Offset: 0x17CDA10 VA: 0x1817CF410
	public bool GetKeyUp(KeyCode keyCode) { }

	// RVA: 0x17CED40 Offset: 0x17CD340 VA: 0x1817CED40
	public bool GetKeyDoublePressHold(KeyCode keyCode, float speed) { }

	// RVA: 0x17CEE40 Offset: 0x17CD440 VA: 0x1817CEE40
	public bool GetKeyDoublePressHold(KeyCode keyCode) { }

	// RVA: 0x17CEC40 Offset: 0x17CD240 VA: 0x1817CEC40
	public bool GetKeyDoublePressDown(KeyCode keyCode, float speed) { }

	// RVA: 0x17CEB50 Offset: 0x17CD150 VA: 0x1817CEB50
	public bool GetKeyDoublePressDown(KeyCode keyCode) { }

	// RVA: 0x17CF140 Offset: 0x17CD740 VA: 0x1817CF140
	public bool GetKeyPrev(KeyCode keyCode) { }

	// RVA: 0x17CF230 Offset: 0x17CD830 VA: 0x1817CF230
	public double GetKeyTimePressed(KeyCode keyCode) { }

	// RVA: 0x17CF320 Offset: 0x17CD920 VA: 0x1817CF320
	public double GetKeyTimeUnpressed(KeyCode keyCode) { }

	// RVA: 0x17CFE60 Offset: 0x17CE460 VA: 0x1817CFE60
	public bool GetModifierKey(ModifierKey key) { }

	// RVA: 0x17CF760 Offset: 0x17CDD60 VA: 0x1817CF760
	public bool GetModifierKeyDown(ModifierKey key) { }

	// RVA: 0x17CFD20 Offset: 0x17CE320 VA: 0x1817CFD20
	public bool GetModifierKeyUp(ModifierKey key) { }

	// RVA: 0x17CF9F0 Offset: 0x17CDFF0 VA: 0x1817CF9F0
	public bool GetModifierKeyPrev(ModifierKey key) { }

	// RVA: 0x17CFB00 Offset: 0x17CE100 VA: 0x1817CFB00
	public double GetModifierKeyTimePressed(ModifierKey key) { }

	// RVA: 0x17CFC10 Offset: 0x17CE210 VA: 0x1817CFC10
	public double GetModifierKeyTimeUnpressed(ModifierKey key) { }

	// RVA: 0x17CE6D0 Offset: 0x17CCCD0 VA: 0x1817CE6D0
	public KeyCode GetKeyCodeByButtonIndex(int buttonIndex) { }

	// RVA: 0x17CE8D0 Offset: 0x17CCED0 VA: 0x1817CE8D0
	public KeyCode GetKeyCodeById(int elementIdentifierId) { }

	// RVA: 0x17CE4D0 Offset: 0x17CCAD0 VA: 0x1817CE4D0
	public int GetButtonIndexByKeyCode(KeyCode keyCode) { }

	// RVA: 0x17CE5E0 Offset: 0x17CCBE0 VA: 0x1817CE5E0
	public ControllerElementIdentifier GetElementIdentifierByKeyCode(KeyCode keyCode) { }

	// RVA: 0x17D1710 Offset: 0x17CFD10 VA: 0x1817D1710
	public ControllerPollingInfo PollForFirstKey() { }

	[IteratorStateMachine(typeof(Keyboard.dmUDKkPtrEIsUdNuchuygbqtRhUn))]
	// RVA: 0x17D1350 Offset: 0x17CF950 VA: 0x1817D1350
	public IEnumerable<ControllerPollingInfo> PollForAllKeys() { }

	[IteratorStateMachine(typeof(Keyboard.MMtsuTYNhTwzlwnyEMGylARzGaPt))]
	// RVA: 0x17D12D0 Offset: 0x17CF8D0 VA: 0x1817D12D0
	public IEnumerable<ControllerPollingInfo> PollForAllKeysDown() { }

	// RVA: 0x17D1450 Offset: 0x17CFA50 VA: 0x1817D1450
	public ControllerPollingInfo PollForFirstKeyDown() { }

	// RVA: 0x17D1410 Offset: 0x17CFA10 VA: 0x1817D1410 Slot: 41
	public override ControllerPollingInfo PollForFirstButton() { }

	// RVA: 0x17D13D0 Offset: 0x17CF9D0 VA: 0x1817D13D0 Slot: 42
	public override ControllerPollingInfo PollForFirstButtonDown() { }

	// RVA: 0x17D1350 Offset: 0x17CF950 VA: 0x1817D1350 Slot: 45
	public override IEnumerable<ControllerPollingInfo> PollForAllButtons() { }

	// RVA: 0x17D12D0 Offset: 0x17CF8D0 VA: 0x1817D12D0 Slot: 46
	public override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown() { }

	// RVA: 0x17CDFB0 Offset: 0x17CC5B0 VA: 0x1817CDFB0
	public static bool IsModifierKey(KeyCode key) { }

	// RVA: 0x17CDFB0 Offset: 0x17CC5B0 VA: 0x1817CDFB0
	internal static bool BBHQOtmOpKzBeqoPFlkQsNBLwqRj(KeyboardKeyCode ) { }

	// RVA: 0x17D0940 Offset: 0x17CEF40 VA: 0x1817D0940
	public static ModifierKey KeyCodeToModifierKey(KeyCode key) { }

	// RVA: 0x17D08C0 Offset: 0x17CEEC0 VA: 0x1817D08C0
	public static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key) { }

	// RVA: 0x17D0B60 Offset: 0x17CF160 VA: 0x1817D0B60
	public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key) { }

	// RVA: 0x17D0BB0 Offset: 0x17CF1B0 VA: 0x1817D0BB0
	public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key) { }

	// RVA: 0x17D0CA0 Offset: 0x17CF2A0 VA: 0x1817D0CA0
	public static ModifierKey ModifierKeyFlagsToModifierKey(ModifierKeyFlags flags) { }

	// RVA: 0x17D0C40 Offset: 0x17CF240 VA: 0x1817D0C40
	public static KeyCode ModifierKeyFlagsToKeyCode(ModifierKeyFlags flags) { }

	// RVA: 0x17D0F00 Offset: 0x17CF500 VA: 0x1817D0F00
	public static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key) { }

	// RVA: 0x17CEFA0 Offset: 0x17CD5A0 VA: 0x1817CEFA0
	public static string GetKeyName(KeyCode key) { }

	// RVA: 0x17CF070 Offset: 0x17CD670 VA: 0x1817CF070
	public static string GetKeyName(KeyCode key, ModifierKeyFlags flags) { }

	// RVA: 0x17CF900 Offset: 0x17CDF00 VA: 0x1817CF900
	public static string GetModifierKeyName(ModifierKey modifierKey) { }

	// RVA: 0x17CF970 Offset: 0x17CDF70 VA: 0x1817CF970
	public static string GetModifierKeyName(ModifierKey modifierKey, bool getShortName) { }

	// RVA: 0x17D0CF0 Offset: 0x17CF2F0 VA: 0x1817D0CF0
	public static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool getShortName) { }

	// RVA: 0x17D0EF0 Offset: 0x17CF4F0 VA: 0x1817D0EF0
	public static string ModifierKeyFlagsToString(ModifierKeyFlags flags) { }

	// RVA: 0x17CF8A0 Offset: 0x17CDEA0 VA: 0x1817CF8A0
	public static object GetModifierKeyGlyph(ModifierKey modifierKey) { }

	// RVA: 0x17D1110 Offset: 0x17CF710 VA: 0x1817D1110
	internal static string NrAgrljgKOxSXhgkxUckCtDILNWjA(ModifierKey ) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	internal static KeyboardKeyCode XVdkvuoGDKxohBZUvsrVhHhCxiSJ(KeyCode ) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	internal static KeyCode LvowmrmGAMPVmXyxLIreIvQBSkOv(KeyboardKeyCode ) { }

	// RVA: 0x17D19D0 Offset: 0x17CFFD0 VA: 0x1817D19D0
	internal static ModifierKeyFlags SsYNWLnlmjwfNjmYirjgTxFyenSE(ModifierKeyFlags ) { }

	// RVA: 0x17D2AF0 Offset: 0x17D10F0 VA: 0x1817D2AF0
	internal static int imtvHUnUfMvFfurPtnCUylyeTnhl(ModifierKeyFlags ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17CF5F0 Offset: 0x17CDBF0 VA: 0x1817CF5F0
	internal static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex) { }

	// RVA: 0x17D1B60 Offset: 0x17D0160 VA: 0x1817D1B60
	internal static int YHInZoQWkLppjyCADRSwpbYjUCdC(KeyboardKeyCode ) { }

	// RVA: 0x17CE130 Offset: 0x17CC730 VA: 0x1817CE130
	internal static void FbQXIIsNODblhHYOtiejkukecbMNA(ref int , ref KeyCode ) { }

	// RVA: 0x17D2F00 Offset: 0x17D1500 VA: 0x1817D2F00 Slot: 51
	internal override void vLmyYvrLYCtWLWVfNSFNMczuugEN(UpdateLoopType ) { }

	// RVA: 0x17CFF70 Offset: 0x17CE570 VA: 0x1817CFF70
	internal void GyoIYzBTWSggmvIUTyzTrngMEPzb(UpdateLoopType ) { }

	// RVA: 0x17D2640 Offset: 0x17D0C40 VA: 0x1817D2640
	internal bool fWHzGSIrvBTWssJmmjvTCvRbhLRf(KeyboardKeyCode ) { }

	// RVA: 0x17D1AF0 Offset: 0x17D00F0 VA: 0x1817D1AF0
	internal bool WjkHQelnQmNbjxDxVGyuXUdWKDvf(KeyboardKeyCode ) { }

	// RVA: 0x17D2360 Offset: 0x17D0960 VA: 0x1817D2360
	internal bool bEGRAFtbnjFKbJWLZGtTLsahiJYw(KeyboardKeyCode , ModifierKeyFlags ) { }

	// RVA: 0x17D09A0 Offset: 0x17CEFA0 VA: 0x1817D09A0
	internal bool LPEWuLRNzXHCAtxNaBrnPoYTjNgb(KeyboardKeyCode , ModifierKeyFlags ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17CE5A0 Offset: 0x17CCBA0 VA: 0x1817CE5A0
	internal int GetButtonIndex(KeyboardKeyCode keyCode) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17CDFF0 Offset: 0x17CC5F0 VA: 0x1817CDFF0 Slot: 55
	internal override void BakeMap(ControllerMap controllerMap) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17CDFD0 Offset: 0x17CC5D0 VA: 0x1817CDFD0 Slot: 56
	internal override void BakeActionElementMap(ControllerMap controllerMap, ActionElementMap map) { }

	// RVA: 0x17D1C20 Offset: 0x17D0220 VA: 0x1817D1C20 Slot: 53
	internal override void YRIQWSDnmoVaobyPFkoHiFhweYDK() { }

	// RVA: 0x17D1A30 Offset: 0x17D0030 VA: 0x1817D1A30 Slot: 54
	internal override bool TXAutACHvlknrGedjcJsxsrPBGyhA(bool ) { }

	// RVA: 0x17D3310 Offset: 0x17D1910 VA: 0x1817D3310
	private bool ylVKrdZzrfjVGFwGkwCjCfEugErD(out Controller.Button , out Controller.Button , ModifierKey ) { }

	// RVA: 0x17D26B0 Offset: 0x17D0CB0 VA: 0x1817D26B0
	private void frIMSRNKFEkfHRwZCWhcwEWHcPHs() { }

	// RVA: 0x17D2F80 Offset: 0x17D1580 VA: 0x1817D2F80
	private string xYmeialDIiKDjUSOHFgrigFpujfL(ModifierKey , bool ) { }

	// RVA: 0x17D1C40 Offset: 0x17D0240 VA: 0x1817D1C40
	private static bool YYZtayyhFYQJKDFEvTVoluCMqpQb(Keyboard.fsKdBRjmVoMEpvprcZrtLlbvdaMy , string , string , DeviceLocalizationInfo , out string ) { }

	// RVA: 0x17D0F40 Offset: 0x17CF540 VA: 0x1817D0F40
	private object NmjBduUDkYgdPBFRjfetRywKfykw(ModifierKey ) { }

	// RVA: 0x17D03B0 Offset: 0x17CE9B0 VA: 0x1817D03B0
	private string HybfMFCXotJLLeDFEqQDpcbcVrK(ModifierKey ) { }

	// RVA: 0x17D2B30 Offset: 0x17D1130 VA: 0x1817D2B30
	private static bool mudUxdYloFACcPsHyJuRotphUgLV(Keyboard.MZAKWzmSMiCMuQCLOljwzGGkFpTo , string , DeviceLocalizationInfo , out object ) { }

	// RVA: 0x17D2560 Offset: 0x17D0B60 VA: 0x1817D2560
	private static bool csHBbuSaRBUxZGqNINEkyNHtBEag(Keyboard.MZAKWzmSMiCMuQCLOljwzGGkFpTo , string , DeviceLocalizationInfo , out string ) { }

	[CompilerGenerated]
	// RVA: 0x17CE280 Offset: 0x17CC880 VA: 0x1817CE280
	private void GMlqEdMyuccpBLFvAmbzaSmIFajd() { }

	[CompilerGenerated]
	// RVA: 0x17D01F0 Offset: 0x17CE7F0 VA: 0x1817D01F0
	private void HdNAhGBbDECvDFFkeQHnGbLZbzKAc() { }
}

// Namespace: Rewired
public sealed class Mouse : ControllerWithAxes // TypeDefIndex: 1820
{
	// Fields
	private TimerAbs NSJtCpJpmoWOkZdYSNscxmfmmXri; // 0x188
	private float[] ugVDtZOcyAWhPZawZcFrbdNMdjkBA; // 0x190
	private Vector2 kecCOiFPqamgNlnMkVMGjqjMCzcoA; // 0x198
	private Vector2 aQEMmtwJyWlJybYRrzwuUFvSVjlf; // 0x1A0
	private int KWJZgPBtwXRZHrhUKjnUKOHILVcT; // 0x1A8
	private readonly IUnifiedMouseSource BFlDSqbfPhELnikreWPnFJUqhFXgc; // 0x1B0
	private static Guid okeBOiuhcKeDQTvcItgKwtcsixLo; // 0x0

	// Properties
	public Vector2 screenPosition { get; }
	public Vector2 screenPositionPrev { get; }
	public Vector2 screenPositionDelta { get; }
	public override Guid deviceInstanceGuid { get; }

	// Methods

	// RVA: 0x17D4C70 Offset: 0x17D3270 VA: 0x1817D4C70
	public Vector2 get_screenPosition() { }

	// RVA: 0x17D4B90 Offset: 0x17D3190 VA: 0x1817D4B90
	public Vector2 get_screenPositionPrev() { }

	// RVA: 0x17D4AA0 Offset: 0x17D30A0 VA: 0x1817D4AA0
	public Vector2 get_screenPositionDelta() { }

	// RVA: 0x17D49E0 Offset: 0x17D2FE0 VA: 0x1817D49E0 Slot: 4
	public override Guid get_deviceInstanceGuid() { }

	// RVA: 0x17D45A0 Offset: 0x17D2BA0 VA: 0x1817D45A0
	internal void .ctor(string , IUnifiedMouseSource ) { }

	// RVA: 0x17D4490 Offset: 0x17D2A90 VA: 0x1817D4490
	private void .ctor(int , InputSource , string , string , int , int , HardwareControllerMap_Game , Controller.Extension , ControllerDataUpdater ) { }

	// RVA: 0x17D4F10 Offset: 0x17D3510 VA: 0x1817D4F10 Slot: 51
	internal override void mhlXZHIVURFLPIhvWBpnCVohvvctA(UpdateLoopType ) { }

	// RVA: 0x17D4020 Offset: 0x17D2620 VA: 0x1817D4020 Slot: 61
	protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId) { }

	// RVA: 0x17D43D0 Offset: 0x17D29D0 VA: 0x1817D43D0 Slot: 53
	internal override void VVBPRPaXKRsFrmfcCfeiduCOUWof() { }

	// RVA: 0x17D4D50 Offset: 0x17D3350 VA: 0x1817D4D50 Slot: 54
	internal override bool heydyuOroyCPBSyFhkulitqKkeCX(bool ) { }

	// RVA: 0x17D48A0 Offset: 0x17D2EA0 VA: 0x1817D48A0
	private void fDOiKVgzjFeTWfHjwjisIrzkpREjA() { }
}

// Namespace: Rewired
public abstract class ControllerTemplate : IControllerTemplate, IControllerTemplate_Internal, dmwPlHfCHErBELjQlGwCmsUXbNbq // TypeDefIndex: 1841
{
	// Fields
	private const string sBKIhDPoPDuUlbKHmCxujkQqMuBP = "controller/template";
	private string EMCJFfUBEHGeTBhDKAxQEcPhqOSAA; // 0x10
	private string UctAIDsxHHygInqdcYvwefHJrKtK; // 0x18
	private int rlDiZrIWfsGJAtcMUdeZCbmWAfacA; // 0x20
	private readonly Guid wSbhKVxuqCuhnPBXAdCgJtQtNRWHA; // 0x24
	private readonly DeviceLocalizationInfo rqGDwvfJyWFUFYrakVTaqnJOGtTU; // 0x38
	private readonly Controller khvizTtULLpIgsvmzhCBnHwjtUle; // 0x40
	private readonly ADictionary<int, IControllerTemplateElement> QsOrjjwEVISOWSOItFjJMzNPvabS; // 0x48
	private readonly ADictionary<string, IControllerTemplateElement> byhKRznMHwvuPqBoelrsszIKRAYj; // 0x50
	private IControllerTemplateElement[] ivfJcJMcavuoUVuUuhYFNiyKQmtC; // 0x58
	private ReadOnlyCollection<IControllerTemplateElement> ErpCrrzWeUIWUsBxIwCIdtlARycS; // 0x60
	private readonly kHQCdvDFmtugtOEvKzWXyTgZIwTh GeTjmzTTXtsUpceJYPdAFxBtBEYP; // 0x68
	private readonly int DWrOyPwpeIaRGZkiCNNUwaYsDpVfA; // 0x70

	// Properties
	internal DeviceLocalizationInfo PzKxfqlhOjyJTfaGZBTPFtTrKzbo { get; }
	private DeviceLocalizationInfo Rewired.IControllerTemplate_Internal.deviceLocalizationInfo { get; }
	private Controller Rewired.IControllerTemplate.controller { get; }
	private string Rewired.IControllerTemplate.name { get; }
	private Guid Rewired.IControllerTemplate.typeGuid { get; }
	private IList<IControllerTemplateElement> Rewired.IControllerTemplate.elements { get; }
	private int Rewired.IControllerTemplate.elementCount { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x17CD160 Offset: 0x17CB760 VA: 0x1817CD160
	protected void .ctor(object ) { }

	// RVA: 0x17CB0A0 Offset: 0x17C96A0 VA: 0x1817CB0A0
	private void .ctor(ControllerTemplate.YsWrcFqqSGghQvlmsmJmoUqYunTO ) { }

	// RVA: 0x17CA280 Offset: 0x17C8880 VA: 0x1817CA280
	protected IControllerTemplateElement GetElement(int id) { }

	// RVA: -1 Offset: -1
	protected T GetElement<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC490 Offset: 0x6BAA90 VA: 0x1806BC490
	|-ControllerTemplate.GetElement<object>
	*/

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal DeviceLocalizationInfo ubEOrEboFoWenrTqaojLENMvCnmc() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 12
	private DeviceLocalizationInfo Rewired.IControllerTemplate_Internal.get_deviceLocalizationInfo() { }

	// RVA: 0x17CA9F0 Offset: 0x17C8FF0 VA: 0x1817CA9F0 Slot: 4
	private Controller Rewired.IControllerTemplate.get_controller() { }

	// RVA: 0x17CABB0 Offset: 0x17C91B0 VA: 0x1817CABB0 Slot: 5
	private string Rewired.IControllerTemplate.get_name() { }

	// RVA: 0x17CAC70 Offset: 0x17C9270 VA: 0x1817CAC70 Slot: 6
	private Guid Rewired.IControllerTemplate.get_typeGuid() { }

	// RVA: 0x17CAB20 Offset: 0x17C9120 VA: 0x1817CAB20 Slot: 7
	private IList<IControllerTemplateElement> Rewired.IControllerTemplate.get_elements() { }

	// RVA: 0x17CAA80 Offset: 0x17C9080 VA: 0x1817CAA80 Slot: 8
	private int Rewired.IControllerTemplate.get_elementCount() { }

	// RVA: 0x17CA7D0 Offset: 0x17C8DD0 VA: 0x1817CA7D0 Slot: 9
	private IControllerTemplateElement Rewired.IControllerTemplate.GetElement(int id) { }

	// RVA: -1 Offset: -1 Slot: 10
	private T Rewired.IControllerTemplate.GetElement<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC500 Offset: 0x6BAB00 VA: 0x1806BC500
	|-ControllerTemplate.Rewired.IControllerTemplate.GetElement<object>
	*/

	// RVA: 0x17CA6C0 Offset: 0x17C8CC0 VA: 0x1817CA6C0 Slot: 11
	private int Rewired.IControllerTemplate.GetElementTargets(ControllerElementTarget find, IList<ControllerTemplateElementTarget> results) { }

	// RVA: 0x17CAD30 Offset: 0x17C9330 VA: 0x1817CAD30 Slot: 13
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 14
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 15
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 16
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 17
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 18
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230 Slot: 19
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x17CA070 Offset: 0x17C8670 VA: 0x1817CA070
	private int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> results) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17CA420 Offset: 0x17C8A20 VA: 0x1817CA420
	internal static Type GetInterfaceType(ControllerTemplateElementType elementType) { }

	// RVA: 0x17CAD60 Offset: 0x17C9360 VA: 0x1817CAD60
	private static IList<ControllerTemplate.kjCDHDVKEPdQkfgBqEtkakUwFxPUA> SrUIXsypecPdBKYtRHwGLzvdLYoD(Controller , IControllerTemplateAxisSource ) { }

	// RVA: 0x17CA5A0 Offset: 0x17C8BA0 VA: 0x1817CA5A0
	private static IList<ControllerTemplate.kjCDHDVKEPdQkfgBqEtkakUwFxPUA> HAKBhVCfhpnIOGuPyoJlGbSihqmg(Controller , IControllerTemplateButtonSource ) { }

	// RVA: 0x17CD290 Offset: 0x17CB890 VA: 0x1817CD290
	private static IList<ControllerTemplate.kjCDHDVKEPdQkfgBqEtkakUwFxPUA> yZrGXaRIgPYoQKkJmrZWdbnytvTF(Controller , IControllerElementTarget ) { }

	// RVA: 0x17CAFD0 Offset: 0x17C95D0 VA: 0x1817CAFD0
	private static IControllerTemplateElement XGUZyVLJLDaZDwDqchiKHusnOMszA(List<IControllerTemplateElement> , int ) { }

	// RVA: 0x17CD1E0 Offset: 0x17CB7E0 VA: 0x1817CD1E0
	private static ControllerTemplate.RvVLyanCokdPajbnkRIRIkwKJqbKA jBsFloWSInnjDlmmgCcGBimLidGxA(IControllerTemplate_Internal , ADictionary<int, IControllerTemplateElement> , int ) { }

	// RVA: 0x17CA610 Offset: 0x17C8C10 VA: 0x1817CA610
	private static ControllerTemplate.RvVLyanCokdPajbnkRIRIkwKJqbKA LDQscEsUcNqwDtXygPRteSLrqCfQ(IControllerTemplate_Internal , ADictionary<int, IControllerTemplateElement> , int ) { }
}

// Namespace: Rewired
public abstract class ControllerTemplateActionElementMap // TypeDefIndex: 1842
{
	// Fields
	private readonly int QUtBlhkPSdCRcmWlyCIEtUryqOQab; // 0x10
	private readonly ControllerTemplateElementType rmxDLppiUzKashWvdOHSIIFIOXvT; // 0x14
	private bool cZYQXbkWzfqrgDfBgiJTMXCMxjnp; // 0x18
	private int sjZjIGfPvhlxlHQMjNmlEfVvBzZ; // 0x1C
	private int IrsBesXrgOddccdwPenEJWwcimSK; // 0x20
	private static int msWEnHvUMujNijuXrJzAvBpxWOBxA; // 0x0

	// Properties
	public int id { get; }
	public ControllerTemplateElementType elementType { get; }
	public bool enabled { get; set; }
	public int actionId { get; set; }
	public int elementIdentifierId { get; set; }

	// Methods

	// RVA: 0x17C7100 Offset: 0x17C5700 VA: 0x1817C7100
	internal void .ctor(ControllerTemplateElementType ) { }

	// RVA: 0x17C7030 Offset: 0x17C5630 VA: 0x1817C7030
	internal void .ctor(ControllerTemplateElementType , int , ActionElementMap ) { }

	// RVA: 0x17C70C0 Offset: 0x17C56C0 VA: 0x1817C70C0
	internal void .ctor(ControllerTemplateElementType , int , int , bool ) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor(ActionElementMap ) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_id() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public ControllerTemplateElementType get_elementType() { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_enabled() { }

	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_enabled(bool value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_actionId() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_actionId(int value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_elementIdentifierId() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_elementIdentifierId(int value) { }

	// RVA: 0x17C7200 Offset: 0x17C5800 VA: 0x1817C7200
	internal int bwrjpCZuNQBFIyaxpCJlXzsFqqbq(IControllerTemplate , List<ActionElementMap> , bool ) { }

	// RVA: 0x17C7470 Offset: 0x17C5A70 VA: 0x1817C7470
	internal SerializedObject gsQBuBvWbjPQlTqHDGfIvxfTSAXc() { }

	// RVA: 0x17C75E0 Offset: 0x17C5BE0 VA: 0x1817C75E0 Slot: 4
	internal virtual void oiikMoGPXxHrWWAmySsrShTMOjeF(SerializedObject ) { }

	// RVA: 0x17C7500 Offset: 0x17C5B00 VA: 0x1817C7500 Slot: 5
	internal virtual void jJPALPBcdpGVBtOLPKWIgCEPQQYdA(SerializedObject ) { }

	// RVA: 0x17C7700 Offset: 0x17C5D00 VA: 0x1817C7700 Slot: 6
	internal virtual void ujhfinIWijkRrqaSLRLgIWAfqGCfA() { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract int IOQalCkuHRUTkGrJvpFDBKFSHNIW(IControllerTemplateElementSource , List<ActionElementMap> , bool );

	// RVA: 0x17C6ED0 Offset: 0x17C54D0 VA: 0x1817C6ED0
	private int TcJEkZFtmdYCnrccPpMSvUVJVliPA(IControllerTemplate , List<ActionElementMap> , bool ) { }

	// RVA: 0x17C6DA0 Offset: 0x17C53A0 VA: 0x1817C6DA0
	internal static ControllerTemplateActionElementMap RzFwGcKPMabzpXaNqYJkQUuwEczk(SerializedObject ) { }

	// RVA: 0x17C6B70 Offset: 0x17C5170 VA: 0x1817C6B70
	internal static ControllerTemplateActionElementMap FpkaBiXeyMbNFGSfQlEewOOHpXzaA(ControllerTemplateElementTarget , ActionElementMap ) { }

	// RVA: 0x17C7710 Offset: 0x17C5D10 VA: 0x1817C7710
	internal static ControllerTemplateActionElementMap vEDDQtiLOFmxZFEDHicQqnmwJoJvb(ActionElementMap ) { }
}

// Namespace: Rewired
public sealed class ControllerTemplateActionButtonMap : ControllerTemplateActionElementMap // TypeDefIndex: 1843
{
	// Fields
	private Pole IDkGcbkpswWnyxJXQvpEqaFvBbBu; // 0x28

	// Properties
	public Pole axisContribution { get; }

	// Methods

	// RVA: 0x17C6890 Offset: 0x17C4E90 VA: 0x1817C6890
	internal void .ctor(SerializedObject ) { }

	// RVA: 0x17C6980 Offset: 0x17C4F80 VA: 0x1817C6980
	internal void .ctor(int , ActionElementMap ) { }

	// RVA: 0x17C6920 Offset: 0x17C4F20 VA: 0x1817C6920
	internal void .ctor(int , int , Pole , bool ) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public Pole get_axisContribution() { }

	// RVA: 0x17C6A20 Offset: 0x17C5020 VA: 0x1817C6A20 Slot: 4
	internal override void gQxryeBiiceDrBdgNxKMGyIqltmn(SerializedObject ) { }

	// RVA: 0x17C6810 Offset: 0x17C4E10 VA: 0x1817C6810 Slot: 5
	internal override void DvqehGeXrKgCHEhTVXYugwMXFegx(SerializedObject ) { }

	// RVA: 0x17C66C0 Offset: 0x17C4CC0 VA: 0x1817C66C0 Slot: 6
	internal override void CwlZMeKrZtIYLOkPeBlLsmdLPzlV() { }

	// RVA: 0x17C6AA0 Offset: 0x17C50A0 VA: 0x1817C6AA0 Slot: 7
	internal override int zQAOzmJgLhUQjRCzuMoyrSACBhXu(IControllerTemplateElementSource , List<ActionElementMap> , bool ) { }

	// RVA: 0x17C66D0 Offset: 0x17C4CD0 VA: 0x1817C66D0
	private ActionElementMap DskznQxYJjyymkPPQzNkRSncSKQ(IControllerElementTarget , Pole ) { }
}

// Namespace: Rewired
public sealed class ControllerTemplateActionAxisMap : ControllerTemplateActionElementMap // TypeDefIndex: 1844
{
	// Fields
	private AxisRange fkARYnHZMEqINUGLzIWTCfAwMrVA; // 0x28
	private Pole MmrVwGGWEDXIalwYouIdmUiZRmgk; // 0x2C
	private bool vjepuYiaNAAXrBHNmFQaPxwVrsoZ; // 0x30

	// Properties
	public AxisRange axisRange { get; }
	public Pole axisContribution { get; }
	public bool invert { get; }

	// Methods

	// RVA: 0x17C63E0 Offset: 0x17C49E0 VA: 0x1817C63E0
	internal void .ctor(SerializedObject ) { }

	// RVA: 0x17C6330 Offset: 0x17C4930 VA: 0x1817C6330
	internal void .ctor(int , AxisRange , ActionElementMap ) { }

	// RVA: 0x17C6470 Offset: 0x17C4A70 VA: 0x1817C6470
	internal void .ctor(int , int , AxisRange , Pole , bool , bool ) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public AxisRange get_axisRange() { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public Pole get_axisContribution() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_invert() { }

	// RVA: 0x17C64E0 Offset: 0x17C4AE0 VA: 0x1817C64E0 Slot: 4
	internal override void pJcYPJxwmwyswzOpPgWrQmxrmfSi(SerializedObject ) { }

	// RVA: 0x17C65E0 Offset: 0x17C4BE0 VA: 0x1817C65E0 Slot: 5
	internal override void reqhrpDczbrnVoKeoRsCHPoPLTYk(SerializedObject ) { }

	// RVA: 0x17C64D0 Offset: 0x17C4AD0 VA: 0x1817C64D0 Slot: 6
	internal override void nexirYINjRnBnebrTqiBeDkIxBYQ() { }

	// RVA: 0x17C6110 Offset: 0x17C4710 VA: 0x1817C6110 Slot: 7
	internal override int LNJeCZLiUiqdZIMeDbqfvwLuPHHM(IControllerTemplateElementSource , List<ActionElementMap> , bool ) { }

	// RVA: 0x17C5E30 Offset: 0x17C4430 VA: 0x1817C5E30
	private ActionElementMap CMOFBsJTzdYvpsMWPrwEnQlGdsHnA(IControllerElementTarget , AxisRange , Pole ) { }

	// RVA: 0x17C5FB0 Offset: 0x17C45B0 VA: 0x1817C5FB0
	private ActionElementMap JYRpcRbIoprzRhaeCZzPKHYcDOKl(IControllerElementTarget , Pole , Pole ) { }
}

// Namespace: Rewired
public struct ControllerTemplateElementTarget // TypeDefIndex: 1846
{
	// Fields
	private IControllerTemplateElement EPixozjsdsKvmnHjWWyhRuoMkydB; // 0x0
	private AxisRange SVIQBVLCufwgEVYHufRZngwdEgyaA; // 0x8

	// Properties
	public AxisRange axisRange { get; set; }
	public ControllerTemplateElementType elementType { get; }
	public string descriptiveName { get; }
	public IControllerTemplateElement element { get; set; }
	public IControllerTemplate template { get; }
	public bool hasTarget { get; }

	// Methods

	// RVA: 0x17C78E0 Offset: 0x17C5EE0 VA: 0x1817C78E0
	internal void .ctor(IControllerTemplateElement , AxisRange ) { }

	// RVA: 0x17C5C50 Offset: 0x17C4250 VA: 0x1817C5C50
	public void .ctor(ControllerTemplateElementTarget ) { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public AxisRange get_axisRange() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x17C7B80 Offset: 0x17C6180 VA: 0x1817C7B80
	public ControllerTemplateElementType get_elementType() { }

	// RVA: 0x17C7960 Offset: 0x17C5F60 VA: 0x1817C7960
	public string get_descriptiveName() { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public IControllerTemplateElement get_element() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void set_element(IControllerTemplateElement value) { }

	// RVA: 0x17C7BD0 Offset: 0x17C61D0 VA: 0x1817C7BD0
	public IControllerTemplate get_template() { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10
	public bool get_hasTarget() { }
}

// Namespace: Rewired
public struct ControllerElementTarget // TypeDefIndex: 1847
{
	// Fields
	private Controller.Element BOkULUSvauVsTKSDnLkgNjKCcIgs; // 0x0
	private AxisRange PVceuRaveoIdAQiUahVVgKJjGJakc; // 0x8

	// Properties
	public int elementIdentifierId { get; }
	public AxisRange axisRange { get; set; }
	public bool hasTarget { get; }
	public ControllerElementType elementType { get; }
	public string descriptiveName { get; }
	public Controller controller { get; }
	public Controller.Element element { get; set; }

	// Methods

	// RVA: 0x17C5AF0 Offset: 0x17C40F0 VA: 0x1817C5AF0
	public void .ctor(ActionElementMap ) { }

	// RVA: 0x17C5C50 Offset: 0x17C4250 VA: 0x1817C5C50
	public void .ctor(ControllerElementTarget ) { }

	// RVA: 0x17C5C80 Offset: 0x17C4280 VA: 0x1817C5C80
	public void .ctor(IControllerElementTarget ) { }

	// RVA: 0x17C5DC0 Offset: 0x17C43C0 VA: 0x1817C5DC0
	public int get_elementIdentifierId() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public AxisRange get_axisRange() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10
	public bool get_hasTarget() { }

	// RVA: 0x17C5DE0 Offset: 0x17C43E0 VA: 0x1817C5DE0
	public ControllerElementType get_elementType() { }

	// RVA: 0x17C5D60 Offset: 0x17C4360 VA: 0x1817C5D60
	public string get_descriptiveName() { }

	// RVA: 0x17C5D40 Offset: 0x17C4340 VA: 0x1817C5D40
	public Controller get_controller() { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public Controller.Element get_element() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void set_element(Controller.Element value) { }

	// RVA: 0x17C5DF0 Offset: 0x17C43F0 VA: 0x1817C5DF0
	public static ControllerElementTarget op_Implicit(ActionElementMap actionElementMap) { }
}

// Namespace: Rewired
public enum ControllerTemplateElementType // TypeDefIndex: 1850
{
	// Fields
	public int value__; // 0x0
	public const ControllerTemplateElementType Axis = 0;
	public const ControllerTemplateElementType Button = 1;
	public const ControllerTemplateElementType ThumbStick = 2;
	public const ControllerTemplateElementType DPad = 4;
	public const ControllerTemplateElementType Stick = 5;
	public const ControllerTemplateElementType Throttle = 6;
	public const ControllerTemplateElementType Hat = 7;
	public const ControllerTemplateElementType Yoke = 8;
	public const ControllerTemplateElementType Stick6D = 9;
}

// Namespace: Rewired
public enum ControllerTemplateElementSourceType // TypeDefIndex: 1851
{
	// Fields
	public int value__; // 0x0
	public const ControllerTemplateElementSourceType Axis = 0;
	public const ControllerTemplateElementSourceType Button = 1;
}

// Namespace: Rewired
public interface IControllerTemplate // TypeDefIndex: 1852
{
	// Properties
	public abstract Controller controller { get; }
	public abstract string name { get; }
	public abstract Guid typeGuid { get; }
	public abstract IList<IControllerTemplateElement> elements { get; }
	public abstract int elementCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Controller get_controller();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Guid get_typeGuid();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IList<IControllerTemplateElement> get_elements();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_elementCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateElement GetElement(int id);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract T GetElement<T>(int id);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IControllerTemplate.GetElement<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results);
}

// Namespace: Rewired
public interface IControllerTemplateElement // TypeDefIndex: 1853
{
	// Properties
	public abstract int id { get; }
	public abstract string descriptiveName { get; }
	public abstract ControllerTemplateElementType type { get; }
	public abstract bool exists { get; }
	public abstract IControllerTemplateElementSource source { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_descriptiveName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ControllerTemplateElementType get_type();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_exists();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateElementSource get_source();
}

// Namespace: Rewired
public interface IControllerTemplateButton : IControllerTemplateElement // TypeDefIndex: 1854
{
	// Properties
	public abstract bool value { get; }
	public abstract bool valuePrev { get; }
	public abstract float pressure { get; }
	public abstract float pressurePrev { get; }
	public abstract bool justPressed { get; }
	public abstract bool justReleased { get; }
	public abstract bool justChangedState { get; }
	public abstract IControllerTemplateButtonSource source { get; }
	public abstract IControllerTemplateAxis AsAxis { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_pressure();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_pressurePrev();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_justPressed();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_justReleased();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_justChangedState();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButtonSource get_source();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateAxis get_AsAxis();
}

// Namespace: Rewired
public interface IControllerTemplateAxis : IControllerTemplateElement // TypeDefIndex: 1855
{
	// Properties
	public abstract string positiveDescriptiveName { get; }
	public abstract string negativeDescriptiveName { get; }
	public abstract float value { get; }
	public abstract float valuePrev { get; }
	public abstract IControllerTemplateAxisSource source { get; }
	public abstract IControllerTemplateButton AsButton { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_positiveDescriptiveName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_negativeDescriptiveName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetDescriptiveName(AxisRange axisRange);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_value();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateAxisSource get_source();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_AsButton();
}

// Namespace: Rewired
public interface IControllerTemplateStick : IControllerTemplateElement // TypeDefIndex: 1856
{
	// Properties
	public abstract Vector3 value { get; }
	public abstract Vector3 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }
	public abstract IControllerTemplateAxis rotation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_rotation();
}

// Namespace: Rewired
public interface IControllerTemplateThumbStick : IControllerTemplateElement // TypeDefIndex: 1857
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }
	public abstract IControllerTemplateButton press { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_press();
}

// Namespace: Rewired
public interface IControllerTemplateDPad : IControllerTemplateElement // TypeDefIndex: 1858
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateButton up { get; }
	public abstract IControllerTemplateButton right { get; }
	public abstract IControllerTemplateButton down { get; }
	public abstract IControllerTemplateButton left { get; }
	public abstract IControllerTemplateButton press { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_up();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_right();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_down();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_left();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_press();
}

// Namespace: Rewired
public interface IControllerTemplateThrottle : IControllerTemplateElement // TypeDefIndex: 1859
{
	// Properties
	public abstract float value { get; }
	public abstract float valuePrev { get; }
	public abstract IControllerTemplateAxis throttle { get; }
	public abstract IControllerTemplateButton minDetent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_throttle();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_minDetent();
}

// Namespace: Rewired
public interface IControllerTemplateHat : IControllerTemplateElement // TypeDefIndex: 1860
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateButton up { get; }
	public abstract IControllerTemplateButton upRight { get; }
	public abstract IControllerTemplateButton right { get; }
	public abstract IControllerTemplateButton downRight { get; }
	public abstract IControllerTemplateButton down { get; }
	public abstract IControllerTemplateButton downLeft { get; }
	public abstract IControllerTemplateButton left { get; }
	public abstract IControllerTemplateButton upLeft { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_up();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_upRight();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_right();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_downRight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_down();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_downLeft();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_left();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_upLeft();
}

// Namespace: Rewired
public interface IControllerTemplateYoke : IControllerTemplateElement // TypeDefIndex: 1861
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateAxis rotation { get; }
	public abstract IControllerTemplateAxis pushPull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_rotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_pushPull();
}

// Namespace: Rewired
public interface IControllerTemplateStick6D : IControllerTemplateElement // TypeDefIndex: 1862
{
	// Properties
	public abstract Vector3 position { get; }
	public abstract Vector3 positionPrev { get; }
	public abstract Vector3 rotation { get; }
	public abstract Vector3 rotationPrev { get; }
	public abstract IControllerTemplateAxis positionX { get; }
	public abstract IControllerTemplateAxis positionY { get; }
	public abstract IControllerTemplateAxis positionZ { get; }
	public abstract IControllerTemplateAxis rotationX { get; }
	public abstract IControllerTemplateAxis rotationY { get; }
	public abstract IControllerTemplateAxis rotationZ { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_positionPrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 get_rotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 get_rotationPrev();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_positionX();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateAxis get_positionY();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateAxis get_positionZ();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateAxis get_rotationX();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateAxis get_rotationY();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateAxis get_rotationZ();
}

// Namespace: Rewired
public interface IControllerTemplateElementSource // TypeDefIndex: 1863
{
	// Properties
	public abstract ControllerTemplateElementSourceType type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ControllerTemplateElementSourceType get_type();
}

// Namespace: Rewired
public interface IControllerTemplateAxisSource : IControllerTemplateElementSource // TypeDefIndex: 1864
{
	// Properties
	public abstract bool splitAxis { get; }
	public abstract IControllerElementTarget fullTarget { get; }
	public abstract IControllerElementTarget positiveTarget { get; }
	public abstract IControllerElementTarget negativeTarget { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_splitAxis();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerElementTarget get_fullTarget();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerElementTarget get_positiveTarget();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerElementTarget get_negativeTarget();
}

// Namespace: Rewired
public interface IControllerTemplateButtonSource : IControllerTemplateElementSource // TypeDefIndex: 1865
{
	// Properties
	public abstract IControllerElementTarget target { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerElementTarget get_target();
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplateAxis2D : IControllerTemplateElement // TypeDefIndex: 1866
{
	// Properties
	public abstract Vector2 value { get; }
	public abstract Vector2 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplateAxis3D : IControllerTemplateElement // TypeDefIndex: 1867
{
	// Properties
	public abstract Vector3 value { get; }
	public abstract Vector3 valuePrev { get; }
	public abstract IControllerTemplateAxis horizontal { get; }
	public abstract IControllerTemplateAxis vertical { get; }
	public abstract IControllerTemplateAxis depth { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_valuePrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_horizontal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_vertical();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_depth();
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplateAxis6D : IControllerTemplateElement // TypeDefIndex: 1868
{
	// Properties
	public abstract Vector3 position { get; }
	public abstract Vector3 positionPrev { get; }
	public abstract Vector3 rotation { get; }
	public abstract Vector3 rotationPrev { get; }
	public abstract IControllerTemplateAxis positionX { get; }
	public abstract IControllerTemplateAxis positionY { get; }
	public abstract IControllerTemplateAxis positionZ { get; }
	public abstract IControllerTemplateAxis rotationX { get; }
	public abstract IControllerTemplateAxis rotationY { get; }
	public abstract IControllerTemplateAxis rotationZ { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_positionPrev();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 get_rotation();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 get_rotationPrev();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateAxis get_positionX();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateAxis get_positionY();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateAxis get_positionZ();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateAxis get_rotationX();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateAxis get_rotationY();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateAxis get_rotationZ();
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplateElement_Internal // TypeDefIndex: 1869
{
	// Properties
	public abstract IControllerTemplate parent { get; }
	public abstract int elementCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplate get_parent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_elementCount();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateElement GetElement(int index);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplate_Internal : IControllerTemplate // TypeDefIndex: 1870
{
	// Properties
	public abstract DeviceLocalizationInfo deviceLocalizationInfo { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DeviceLocalizationInfo get_deviceLocalizationInfo();
}

// Namespace: Rewired
public class ControllerTemplateMap // TypeDefIndex: 1871
{
	// Fields
	private readonly int GjvSjKjbtdtEULtQlMEMinrKgXYhA; // 0x10
	private readonly int kvOFLKdOXgxumFXbzbNOVZXwLAaVA; // 0x14
	private readonly Guid aIcLZbqnDIdhSiFZDMVhyalVKsQr; // 0x18
	private readonly List<ControllerTemplateActionElementMap> pjxaNJfmZIvCrsoszvZDsvPVmumX; // 0x28
	private readonly ReadOnlyCollection<ControllerTemplateActionElementMap> czsMxSoKtoAsXlSGpUgxVqUWwFBX; // 0x30
	private bool CoqbzKdBPfaOrkFxKpwlwexRfIPF; // 0x38
	private int ODnKUvMCdHhStBsKevwaKEAHsqLu; // 0x3C
	private int TTnQWtNOnubKDmBFFztMlAvfMIBO; // 0x40
	private int SXLbmEaapxAobBZkDfhtETiDvtVQb; // 0x44
	private static int ylCggCHHfJaVjtpRtFGMmiWjBlCw; // 0x0

	// Properties
	public int id { get; }
	public Guid templateTypeGuid { get; }
	public bool enabled { get; set; }
	public int categoryId { get; set; }
	public int layoutId { get; set; }
	public IList<ControllerTemplateActionElementMap> ElementMaps { get; }

	// Methods

	// RVA: 0x17C92A0 Offset: 0x17C78A0 VA: 0x1817C92A0
	internal void .ctor(Guid ) { }

	// RVA: 0x17C93F0 Offset: 0x17C79F0 VA: 0x1817C93F0
	internal void .ctor(Guid , int , int , int ) { }

	// RVA: 0x17C9680 Offset: 0x17C7C80 VA: 0x1817C9680
	public int get_id() { }

	// RVA: 0x17C97A0 Offset: 0x17C7DA0 VA: 0x1817C97A0
	public Guid get_templateTypeGuid() { }

	// RVA: 0x17C95F0 Offset: 0x17C7BF0 VA: 0x1817C95F0
	public bool get_enabled() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_enabled(bool value) { }

	// RVA: 0x17C9560 Offset: 0x17C7B60 VA: 0x1817C9560
	public int get_categoryId() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	internal void pXqfOwqdGyWEgBlPHwuJpUhlSmqK(int ) { }

	// RVA: 0x17C9710 Offset: 0x17C7D10 VA: 0x1817C9710
	public int get_layoutId() { }

	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	internal void zhZSpPcbQDqWFkuxDnLNflnIXhbW(int ) { }

	// RVA: 0x17C94C0 Offset: 0x17C7AC0 VA: 0x1817C94C0
	public IList<ControllerTemplateActionElementMap> get_ElementMaps() { }

	// RVA: 0x17C8CE0 Offset: 0x17C72E0 VA: 0x1817C8CE0
	public string ToXmlString() { }

	// RVA: 0x17C8B50 Offset: 0x17C7150 VA: 0x1817C8B50
	public string ToJsonString() { }

	// RVA: 0x17C8800 Offset: 0x17C6E00 VA: 0x1817C8800
	public ControllerMap ToControllerMap(Controller controller) { }

	// RVA: 0x17C7C50 Offset: 0x17C6250 VA: 0x1817C7C50 Slot: 4
	internal virtual void DuwDMQRKNqjSqxPvXcXNsgQsCZxDA(SerializedObject ) { }

	// RVA: 0x17C8F80 Offset: 0x17C7580 VA: 0x1817C8F80 Slot: 5
	internal virtual void ZAMvDYUViRmYWGOoeHgqTMklhDQL(SerializedObject ) { }

	// RVA: 0x17C9440 Offset: 0x17C7A40 VA: 0x1817C9440
	private void dNdGjWFBBvcHQRckpMYMJlSYnuSl() { }

	// RVA: 0x17C9F20 Offset: 0x17C8520 VA: 0x1817C9F20
	private SerializedObject rdfuyqjxoaxFiUKjYgaEUrYuNgXm() { }

	// RVA: 0x17C9FB0 Offset: 0x17C85B0 VA: 0x1817C9FB0
	internal void yqEpmiSklQMqyzdHDgWyibDDUcok(ControllerTemplateActionElementMap ) { }

	// RVA: 0x17C9860 Offset: 0x17C7E60 VA: 0x1817C9860
	internal static ControllerTemplateMap qEDqpZxktjVtAPykbzCeeVUyeQNg(IControllerTemplate , ControllerMap ) { }

	// RVA: 0x17C8710 Offset: 0x17C6D10 VA: 0x1817C8710
	public static ControllerTemplateMap FromXml(string xmlString) { }

	// RVA: 0x17C8620 Offset: 0x17C6C20 VA: 0x1817C8620
	public static ControllerTemplateMap FromJson(string jsonString) { }

	// RVA: 0x17C8E70 Offset: 0x17C7470 VA: 0x1817C8E70
	private static ControllerTemplateMap XKrZrCoiNEcsOgHkyVpFRQbACmMj(SerializedObject ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IPlayerController // TypeDefIndex: 1872
{
	// Properties
	public abstract bool enabled { get; set; }
	public abstract int playerId { get; set; }
	public abstract IList<PlayerController.Button> buttons { get; }
	public abstract IList<PlayerController.Axis> axes { get; }
	public abstract IList<PlayerController.Element> elements { get; }
	public abstract int buttonCount { get; }
	public abstract int axisCount { get; }
	public abstract int elementCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_playerId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_playerId(int value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IList<PlayerController.Button> get_buttons();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList<PlayerController.Axis> get_axes();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IList<PlayerController.Element> get_elements();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_buttonCount();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_axisCount();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_elementCount();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_ButtonStateChangedEvent(Action<int, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_ButtonStateChangedEvent(Action<int, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract void add_AxisValueChangedEvent(Action<int, float> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public abstract void remove_AxisValueChangedEvent(Action<int, float> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	public abstract void add_EnabledStateChangedEvent(Action<bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void remove_EnabledStateChangedEvent(Action<bool> value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool GetButton(int index);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool GetButtonDown(int index);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool GetButtonUp(int index);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract float GetAxis(int index);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract float GetAxisRaw(int index);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract PlayerController.Element GetElement(int index);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract T GetElement<T>(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPlayerController.GetElement<object>
	*/
}

// Namespace: Rewired
public class PlayerController : IPlayerController // TypeDefIndex: 1900
{
	// Fields
	internal readonly int EtDTrCkgXWCVmfcsJUFnAASNpBvo; // 0x10
	private bool bpRXeeKvcVladxNEdOzuZIhhPQJd; // 0x14
	private int ZLxxoULFMZiSQIUJEfJDjagEXjlGB; // 0x18
	private readonly AList<PlayerController.Element> mLSbTRnKSADMZHIQRzfZfFiYQYNuA; // 0x20
	private readonly AList<PlayerController.Button> oHWKPuKKFChLvqMjouPrGNuwmsQc; // 0x28
	private readonly AList<PlayerController.Axis> NmmVGdpNSZyfoJaGQdGXbMikjSkk; // 0x30
	private readonly ReadOnlyCollection<PlayerController.Element> sRHgFbaUMhcQyMCOtexpAUmsFJaZ; // 0x38
	private readonly ReadOnlyCollection<PlayerController.Button> chHxSZGlLaWaLCQqmUCcBDsYLwwV; // 0x40
	private readonly ReadOnlyCollection<PlayerController.Axis> YBtkDAnCSGwMPchboalywBvcCgnhA; // 0x48
	private readonly List<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ> plyYEvxsAsMBXjylAjCxKRRjFujB; // 0x50
	private Action<int, bool> QvliIZkuPjTCJjLDwARLhsDJBtud; // 0x58
	private Action<int, float> bdEhIqjsnvfecLWGEfjQALNiNYHpB; // 0x60
	private Action<bool> wJVdsoVtleIFhavQyhWfeqCATSdgA; // 0x68
	private static Vector2 cdqfrFdTidTZqPoWJzuACYfVKvYr; // 0x0

	// Properties
	public bool enabled { get; set; }
	public int playerId { get; set; }
	public IList<PlayerController.Button> buttons { get; }
	public IList<PlayerController.Axis> axes { get; }
	public IList<PlayerController.Element> elements { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public int elementCount { get; }
	internal Player QMTyOBCODLzgqaVXvCyPMMbiIRYu { get; }
	public static Vector2 absoluteToRelativeScalingReferenceResolution { get; set; }

	// Methods

	// RVA: 0x17D6400 Offset: 0x17D4A00 VA: 0x1817D6400
	internal void .ctor(PlayerController.Definition ) { }

	// RVA: 0x17D4FE0 Offset: 0x17D35E0 VA: 0x1817D4FE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17D72E0 Offset: 0x17D58E0 VA: 0x1817D72E0 Slot: 4
	public bool get_enabled() { }

	// RVA: 0x17D76F0 Offset: 0x17D5CF0 VA: 0x1817D76F0 Slot: 5
	public void set_enabled(bool value) { }

	// RVA: 0x17D7370 Offset: 0x17D5970 VA: 0x1817D7370 Slot: 6
	public int get_playerId() { }

	// RVA: 0x17D78C0 Offset: 0x17D5EC0 VA: 0x1817D78C0 Slot: 7
	public void set_playerId(int value) { }

	// RVA: 0x17D7130 Offset: 0x17D5730 VA: 0x1817D7130 Slot: 8
	public IList<PlayerController.Button> get_buttons() { }

	// RVA: 0x17D6F80 Offset: 0x17D5580 VA: 0x1817D6F80 Slot: 9
	public IList<PlayerController.Axis> get_axes() { }

	// RVA: 0x17D7250 Offset: 0x17D5850 VA: 0x1817D7250 Slot: 10
	public IList<PlayerController.Element> get_elements() { }

	// RVA: 0x17D70A0 Offset: 0x17D56A0 VA: 0x1817D70A0 Slot: 11
	public int get_buttonCount() { }

	// RVA: 0x17D7010 Offset: 0x17D5610 VA: 0x1817D7010 Slot: 12
	public int get_axisCount() { }

	// RVA: 0x17D71C0 Offset: 0x17D57C0 VA: 0x1817D71C0 Slot: 13
	public int get_elementCount() { }

	// RVA: 0x17D6BA0 Offset: 0x17D51A0 VA: 0x1817D6BA0 Slot: 14
	public void add_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x17D74F0 Offset: 0x17D5AF0 VA: 0x1817D74F0 Slot: 15
	public void remove_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x17D6A80 Offset: 0x17D5080 VA: 0x1817D6A80 Slot: 16
	public void add_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x17D7440 Offset: 0x17D5A40 VA: 0x1817D7440 Slot: 17
	public void remove_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x17D6CC0 Offset: 0x17D52C0 VA: 0x1817D6CC0 Slot: 18
	public void add_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x17D75A0 Offset: 0x17D5BA0 VA: 0x1817D75A0 Slot: 19
	public void remove_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x17D5430 Offset: 0x17D3A30 VA: 0x1817D5430 Slot: 20
	public bool GetButton(int index) { }

	// RVA: 0x17D5270 Offset: 0x17D3870 VA: 0x1817D5270 Slot: 21
	public bool GetButtonDown(int index) { }

	// RVA: 0x17D5350 Offset: 0x17D3950 VA: 0x1817D5350 Slot: 22
	public bool GetButtonUp(int index) { }

	// RVA: 0x17D5190 Offset: 0x17D3790 VA: 0x1817D5190 Slot: 23
	public float GetAxis(int index) { }

	// RVA: 0x17D50B0 Offset: 0x17D36B0 VA: 0x1817D50B0 Slot: 24
	public float GetAxisRaw(int index) { }

	// RVA: 0x17D5510 Offset: 0x17D3B10 VA: 0x1817D5510 Slot: 25
	public PlayerController.Element GetElement(int index) { }

	// RVA: -1 Offset: -1 Slot: 26
	public T GetElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x749820 Offset: 0x747E20 VA: 0x180749820
	|-PlayerController.GetElement<object>
	*/

	// RVA: 0x17D5CF0 Offset: 0x17D42F0 VA: 0x1817D5CF0
	internal Player VKfllUIXPeaUMVdWWvydnwpzozpM() { }

	// RVA: 0x17D7400 Offset: 0x17D5A00 VA: 0x1817D7400
	private void qLPtsrIEPKuPqkvfgakokPGuSrAw(UpdateLoopType ) { }

	// RVA: 0x17D57F0 Offset: 0x17D3DF0 VA: 0x1817D57F0 Slot: 27
	protected virtual bool Update(UpdateLoopType updateLoop) { }

	// RVA: 0x17D55E0 Offset: 0x17D3BE0 VA: 0x1817D55E0 Slot: 28
	protected virtual void UpdateFinished() { }

	// RVA: 0x17D4F90 Offset: 0x17D3590 VA: 0x1817D4F90 Slot: 29
	protected virtual void ClearVars() { }

	// RVA: 0x17D6DE0 Offset: 0x17D53E0 VA: 0x1817D6DE0
	internal void gYLncwnwYMMNpoFTNbmHCFQOgvrLA(PlayerController.Element ) { }

	// RVA: 0x17D5E40 Offset: 0x17D4440 VA: 0x1817D5E40
	private void YIxzfyNKAhqyFReUVFXZYgIzaoOKA(PlayerController.Element , List<PlayerController.Element> , List<PlayerController.Element> , List<PlayerController.Button> , List<PlayerController.Axis> ) { }

	// RVA: 0x17D6F20 Offset: 0x17D5520 VA: 0x1817D6F20
	public static Vector2 get_absoluteToRelativeScalingReferenceResolution() { }

	// RVA: 0x17D7650 Offset: 0x17D5C50 VA: 0x1817D7650
	public static void set_absoluteToRelativeScalingReferenceResolution(Vector2 value) { }

	// RVA: -1 Offset: -1
	internal static int qcFDkNBCLnKGIflXJVdrTQGBhzzWB<>(IList<> , Predicate<> , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x749890 Offset: 0x747E90 VA: 0x180749890
	|-PlayerController.qcFDkNBCLnKGIflXJVdrTQGBhzzWB<object>
	*/

	// RVA: 0x17D63C0 Offset: 0x17D49C0 VA: 0x1817D63C0
	private static void .cctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IPlayerMouse : IPlayerController // TypeDefIndex: 1901
{
	// Properties
	public abstract bool defaultToCenter { get; }
	public abstract ScreenRect movementArea { get; set; }
	public abstract PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; }
	public abstract Vector2 screenPosition { get; }
	public abstract Vector2 screenPositionPrev { get; }
	public abstract Vector2 screenPositionDelta { get; }
	public abstract PlayerController.MouseAxis xAxis { get; }
	public abstract PlayerController.MouseAxis yAxis { get; }
	public abstract PlayerController.MouseWheel wheel { get; }
	public abstract PlayerController.Button leftButton { get; }
	public abstract PlayerController.Button rightButton { get; }
	public abstract PlayerController.Button middleButton { get; }
	public abstract float pointerSpeed { get; }
	public abstract bool useHardwarePointerPosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_defaultToCenter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ScreenRect get_movementArea();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_movementArea(ScreenRect value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PlayerMouse.MovementAreaUnit get_movementAreaUnit();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_movementAreaUnit(PlayerMouse.MovementAreaUnit value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector2 get_screenPosition();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Vector2 get_screenPositionPrev();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector2 get_screenPositionDelta();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PlayerController.MouseAxis get_xAxis();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PlayerController.MouseAxis get_yAxis();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract PlayerController.MouseWheel get_wheel();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract PlayerController.Button get_leftButton();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract PlayerController.Button get_rightButton();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract PlayerController.Button get_middleButton();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_pointerSpeed();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_useHardwarePointerPosition();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void add_ScreenPositionChangedEvent(Action<Vector2> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void remove_ScreenPositionChangedEvent(Action<Vector2> value);
}

// Namespace: Rewired
public sealed class PlayerMouse : PlayerController, IPlayerMouse, IPlayerController, IMouseInputSource // TypeDefIndex: 1906
{
	// Fields
	internal const bool zOThhKUPATOrbfFqPNPuTTVXhZCp = True;
	internal const float EIKwKUxXXqbyFvFjNBfHpYPbxegT = 1;
	internal const bool GQYJfDHEVRLoTCGlMTWXDUiHErEi = True;
	internal const bool mpTphRLjSnCsXxunAyKoytxtsgZK = True;
	internal const PlayerMouse.MovementAreaUnit YNYevsoLVEbGmrpKoJbAnFKYRNau = 0;
	internal static readonly ScreenRect KyAGvDQHiWlbufnchERazoLjHUADA; // 0x0
	private const int ZQhgVJKvdUSdSLMPTitvZysjTCSA = 3;
	private const int qtOGGpwYJHuWpEeToOAvheaVnvcr = 3;
	internal const string OFIFGlgBwJnnMNFUpBzPFRreseuQA = "Movement";
	internal const string lphyUQgodEVyXFkfDwFPErrtaHDy = "Horizontal";
	internal const string LyKCePksKqUtysEzVKAmCdHBpDdHA = "Vertical";
	internal const string lHNPpODkaIkFtxFHigCKUWuLSBio = "Wheel";
	internal const string GkHUNfoixqeknPMyuwEFVajYcQMR = "Wheel Horizontal";
	internal const string MhlhsjcWvqOVIyRvuksStJoIFLrY = "Wheel Vertical";
	internal const string UvVhgGTNshAnncYMDsWwQDMJDTKt = "Left Button";
	internal const string fYuOEHoIHkAavNgUdmJLCrCwfLYT = "Right Button";
	internal const string wdvsMiOATOJopvGWWqEXpdDmHjJY = "Middle Button";
	private readonly int zoTBJNKKvrnECwJTcriMfrAZFsKpA; // 0x70
	private readonly int OXYfjRWJZwqKbkFoOZPvumuRJMzf; // 0x74
	private readonly int TnrknZJaWVYEKxyAjhjIckLWqPMl; // 0x78
	private readonly int bLceVAnyRCdeHwwokXEsfeWvTTML; // 0x7C
	private readonly int fEMboZpZkKCPfPLFfJxBoEzdNTac; // 0x80
	private readonly int FDhRDOfqJVBDryjRqQQsEimqrUpE; // 0x84
	private bool kmWmInnEJSyrzqmTTeOGyvJoibIU; // 0x88
	private Vector2 XufPqYXCUcDKdkOfmIUgixuGSvPKA; // 0x8C
	private Vector2 COUXLwBjzdXylLTMDhcOuPXjFewJA; // 0x94
	private Vector2 nRuLuQPSVTWUVWhiBJbDUwVCMVxI; // 0x9C
	private Vector2 XzKcesXCPKkJfUpOOkWGrpFyTEng; // 0xA4
	private Vector2 JxmdFMmpuXcqjszSlmDwIBocpCeN; // 0xAC
	private float dXfPESJpMgabTUiOkfcrEYMgowKjA; // 0xB4
	private bool FtHVcljMmcpofwnopEDselWrIJoqA; // 0xB8
	private Action<Vector2> HmoTkmmyBbSPtpKkaGgwgCtGgToBA; // 0xC0
	private bool nrxsSJYxzLAJTTqkocXhoTJkYusv; // 0xC8
	private ScreenRect GzCGhoaplahyyYyiueeWTSZudxbBA; // 0xCC
	private bool xIGkvlKLUGmTCBKREUieOgIQlHNy; // 0xDC
	private PlayerMouse.MovementAreaUnit dNipanQmlMqbTrHFJPGXBdmSxNyD; // 0xE0

	// Properties
	public bool defaultToCenter { get; set; }
	public bool clampToMovementArea { get; set; }
	public ScreenRect movementArea { get; set; }
	public PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; }
	public Vector2 screenPosition { get; set; }
	public Vector2 screenPositionPrev { get; }
	public Vector2 screenPositionDelta { get; }
	public PlayerController.MouseAxis xAxis { get; }
	public PlayerController.MouseAxis yAxis { get; }
	public PlayerController.MouseWheel wheel { get; }
	public PlayerController.Button leftButton { get; }
	public PlayerController.Button rightButton { get; }
	public PlayerController.Button middleButton { get; }
	public float pointerSpeed { get; set; }
	public bool useHardwarePointerPosition { get; set; }
	private bool Rewired.UI.IMouseInputSource.enabled { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPosition { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta { get; }
	private Vector2 Rewired.UI.IMouseInputSource.wheelDelta { get; }
	private bool Rewired.UI.IMouseInputSource.locked { get; }

	// Methods

	// RVA: 0x182D9A0 Offset: 0x182BFA0 VA: 0x18182D9A0
	private void .ctor(PlayerMouse.Definition ) { }

	// RVA: 0x182EB40 Offset: 0x182D140 VA: 0x18182EB40 Slot: 30
	public bool get_defaultToCenter() { }

	// RVA: 0x182F7B0 Offset: 0x182DDB0 VA: 0x18182F7B0
	public void set_defaultToCenter(bool value) { }

	// RVA: 0x182EB30 Offset: 0x182D130 VA: 0x18182EB30
	public bool get_clampToMovementArea() { }

	// RVA: 0x182F7A0 Offset: 0x182DDA0 VA: 0x18182F7A0
	public void set_clampToMovementArea(bool value) { }

	// RVA: 0x182EDF0 Offset: 0x182D3F0 VA: 0x18182EDF0 Slot: 31
	public ScreenRect get_movementArea() { }

	// RVA: 0x182F7C0 Offset: 0x182DDC0 VA: 0x18182F7C0 Slot: 32
	public void set_movementArea(ScreenRect value) { }

	// RVA: 0x182ED60 Offset: 0x182D360 VA: 0x18182ED60 Slot: 33
	public PlayerMouse.MovementAreaUnit get_movementAreaUnit() { }

	// RVA: 0x16EE3B0 Offset: 0x16EC9B0 VA: 0x1816EE3B0 Slot: 34
	public void set_movementAreaUnit(PlayerMouse.MovementAreaUnit value) { }

	// RVA: 0x182F1C0 Offset: 0x182D7C0 VA: 0x18182F1C0 Slot: 35
	public Vector2 get_screenPosition() { }

	// RVA: 0x182F870 Offset: 0x182DE70 VA: 0x18182F870
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x182F0E0 Offset: 0x182D6E0 VA: 0x18182F0E0 Slot: 36
	public Vector2 get_screenPositionPrev() { }

	// RVA: 0x182F000 Offset: 0x182D600 VA: 0x18182F000 Slot: 37
	public Vector2 get_screenPositionDelta() { }

	// RVA: 0x182F420 Offset: 0x182DA20 VA: 0x18182F420 Slot: 38
	public PlayerController.MouseAxis get_xAxis() { }

	// RVA: 0x182F530 Offset: 0x182DB30 VA: 0x18182F530 Slot: 39
	public PlayerController.MouseAxis get_yAxis() { }

	// RVA: 0x182F330 Offset: 0x182D930 VA: 0x18182F330 Slot: 40
	public PlayerController.MouseWheel get_wheel() { }

	// RVA: 0x182EBD0 Offset: 0x182D1D0 VA: 0x18182EBD0 Slot: 41
	public PlayerController.Button get_leftButton() { }

	// RVA: 0x182EF30 Offset: 0x182D530 VA: 0x18182EF30 Slot: 42
	public PlayerController.Button get_rightButton() { }

	// RVA: 0x182EC90 Offset: 0x182D290 VA: 0x18182EC90 Slot: 43
	public PlayerController.Button get_middleButton() { }

	// RVA: 0x182EEA0 Offset: 0x182D4A0 VA: 0x18182EEA0 Slot: 44
	public float get_pointerSpeed() { }

	// RVA: 0x182F7D0 Offset: 0x182DDD0 VA: 0x18182F7D0
	public void set_pointerSpeed(float value) { }

	// RVA: 0x182F2A0 Offset: 0x182D8A0 VA: 0x18182F2A0 Slot: 45
	public bool get_useHardwarePointerPosition() { }

	// RVA: 0x182F880 Offset: 0x182DE80 VA: 0x18182F880
	public void set_useHardwarePointerPosition(bool value) { }

	// RVA: 0x182EA00 Offset: 0x182D000 VA: 0x18182EA00 Slot: 46
	public void add_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x182F6E0 Offset: 0x182DCE0 VA: 0x18182F6E0 Slot: 47
	public void remove_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x182D620 Offset: 0x182BC20 VA: 0x18182D620 Slot: 27
	protected override bool Update(UpdateLoopType updateLoop) { }

	// RVA: 0x182D530 Offset: 0x182BB30 VA: 0x18182D530 Slot: 28
	protected override void UpdateFinished() { }

	// RVA: 0x182D220 Offset: 0x182B820 VA: 0x18182D220 Slot: 29
	protected override void ClearVars() { }

	// RVA: 0x182FA00 Offset: 0x182E000 VA: 0x18182FA00
	private void xrhBLYdfCeJRGjdHqWDJQozPNeBqA(Vector2 ) { }

	// RVA: 0x182D2B0 Offset: 0x182B8B0 VA: 0x18182D2B0
	private ScreenRect OdueVpgcgiVKxFqZYRHfmrwZSLnO() { }

	// RVA: 0x182F640 Offset: 0x182DC40 VA: 0x18182F640
	private void pDBePebZzgzHSqMTdQHPeXzIRMRy() { }

	// RVA: 0x182F930 Offset: 0x182DF30 VA: 0x18182F930
	private static float wLNRmgbGKJmVryPkFaEAffqHOwgf(PlayerController.Axis , float , float ) { }

	// RVA: 0x182D450 Offset: 0x182BA50 VA: 0x18182D450 Slot: 49
	private bool Rewired.UI.IMouseInputSource.get_enabled() { }

	// RVA: 0x182D420 Offset: 0x182BA20 VA: 0x18182D420 Slot: 52
	private bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

	// RVA: 0x182D430 Offset: 0x182BA30 VA: 0x18182D430 Slot: 53
	private bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

	// RVA: 0x182D440 Offset: 0x182BA40 VA: 0x18182D440 Slot: 54
	private bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

	// RVA: 0x182D480 Offset: 0x182BA80 VA: 0x18182D480 Slot: 55
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

	// RVA: 0x182D460 Offset: 0x182BA60 VA: 0x18182D460 Slot: 56
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

	// RVA: 0x182D4A0 Offset: 0x182BAA0 VA: 0x18182D4A0 Slot: 57
	private Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 50
	private bool Rewired.UI.IMouseInputSource.get_locked() { }

	// RVA: 0x182D930 Offset: 0x182BF30 VA: 0x18182D930
	private static void .cctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal static class Logger // TypeDefIndex: 1907
{
	// Fields
	private const int screenLogLength = 50;
	private static List<string> __screenLog; // 0x0
	private static GUIText _guiText; // 0x8
	private static bool _logToScreen; // 0x10

	// Properties
	private static List<string> screenLog { get; }
	private static LogLevelFlags logLevel { get; }
	public static bool logToScreen { get; set; }

	// Methods

	// RVA: 0x182C660 Offset: 0x182AC60 VA: 0x18182C660
	private static List<string> get_screenLog() { }

	// RVA: 0x182C4D0 Offset: 0x182AAD0 VA: 0x18182C4D0
	private static LogLevelFlags get_logLevel() { }

	// RVA: 0x182C620 Offset: 0x182AC20 VA: 0x18182C620
	public static bool get_logToScreen() { }

	// RVA: 0x182C710 Offset: 0x182AD10 VA: 0x18182C710
	public static void set_logToScreen(bool value) { }

	// RVA: 0x182A070 Offset: 0x1828670 VA: 0x18182A070
	public static void LogEditor(object msg) { }

	// RVA: 0x1829F70 Offset: 0x1828570 VA: 0x181829F70
	public static void LogEditor(object msg, bool requiredThreadSafety) { }

	// RVA: 0x182BDC0 Offset: 0x182A3C0 VA: 0x18182BDC0
	public static void LogWarningEditor(object msg) { }

	// RVA: 0x182BCC0 Offset: 0x182A2C0 VA: 0x18182BCC0
	public static void LogWarningEditor(object msg, bool requiredThreadSafety) { }

	// RVA: 0x182A260 Offset: 0x1828860 VA: 0x18182A260
	public static void LogErrorEditor(object msg) { }

	// RVA: 0x182A160 Offset: 0x1828760 VA: 0x18182A160
	public static void LogErrorEditor(object msg, bool requiredThreadSafety) { }

	// RVA: 0x182C2F0 Offset: 0x182A8F0 VA: 0x18182C2F0
	public static void Log(object msg) { }

	// RVA: 0x182C300 Offset: 0x182A900 VA: 0x18182C300
	public static void Log(object msg, bool requiredThreadSafety) { }

	// RVA: 0x182C2E0 Offset: 0x182A8E0 VA: 0x18182C2E0
	public static void LogWarning(object msg) { }

	// RVA: 0x182C030 Offset: 0x182A630 VA: 0x18182C030
	public static void LogWarning(object msg, bool requiredThreadSafety) { }

	// RVA: 0x182ACD0 Offset: 0x18292D0 VA: 0x18182ACD0
	public static void LogError(object msg) { }

	// RVA: 0x182A4D0 Offset: 0x1828AD0 VA: 0x18182A4D0
	public static void LogError(object msg, bool requiredThreadSafety) { }

	// RVA: 0x182B6C0 Offset: 0x1829CC0 VA: 0x18182B6C0
	public static void LogException(Exception exception, object msg) { }

	// RVA: 0x182AFE0 Offset: 0x18295E0 VA: 0x18182AFE0
	public static void LogException(Exception exception, object msg, bool requiredThreadSafety) { }

	// RVA: 0x182B7F0 Offset: 0x1829DF0 VA: 0x18182B7F0
	private static void LogNow(object msg, bool requireThreadSafety) { }

	// RVA: 0x182BEB0 Offset: 0x182A4B0 VA: 0x18182BEB0
	private static void LogWarningNow(object msg, bool requireThreadSafety) { }

	// RVA: 0x182A350 Offset: 0x1828950 VA: 0x18182A350
	private static void LogErrorNow(object msg, bool requireThreadSafety) { }

	// RVA: 0x182ACE0 Offset: 0x18292E0 VA: 0x18182ACE0
	private static void LogExceptionNow(Exception exception, object msg, bool requireThreadSafety) { }

	// RVA: 0x1829ED0 Offset: 0x18284D0 VA: 0x181829ED0
	private static bool IsLoggingAllowed(LogLevel logLevel) { }

	// RVA: 0x182B970 Offset: 0x1829F70 VA: 0x18182B970
	private static void LogToScreen(object msg) { }

	[Conditional("LOG_INIT")]
	// RVA: 0x182B6F0 Offset: 0x1829CF0 VA: 0x18182B6F0
	public static void LogInit(object o) { }

	[Conditional("LOG_INIT")]
	// RVA: 0x182B6D0 Offset: 0x1829CD0 VA: 0x18182B6D0
	public static void LogInitError(object o) { }

	[Conditional("LOG_INIT")]
	// RVA: 0x182B6E0 Offset: 0x1829CE0 VA: 0x18182B6E0
	public static void LogInitWarning(object o) { }

	[Conditional("LOG_VC")]
	// RVA: 0x182C2F0 Offset: 0x182A8F0 VA: 0x18182C2F0
	public static void Log_VCTest(object o) { }

	[Conditional("LOG_UPDATE")]
	// RVA: 0x182B6F0 Offset: 0x1829CF0 VA: 0x18182B6F0
	public static void LogUpdate(object o) { }

	// RVA: 0x1829E20 Offset: 0x1828420 VA: 0x181829E20
	private static object FormatMessage(object o) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal static class GCProfiler // TypeDefIndex: 1909
{
	// Methods

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Begin(string name) { }

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void End() { }

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void LogReport() { }

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Clear() { }
}

// Namespace: Rewired
public sealed class ActiveControllerChangedDelegate : MulticastDelegate // TypeDefIndex: 1910
{
	// Methods

	// RVA: 0x5C3910 Offset: 0x5C1F10 VA: 0x1805C3910
	public void .ctor(object , IntPtr ) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(Controller controller) { }

	// RVA: 0x346290 Offset: 0x344890 VA: 0x180346290 Slot: 14
	public virtual IAsyncResult BeginInvoke(Controller controller, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Rewired
public sealed class PlayerActiveControllerChangedDelegate : MulticastDelegate // TypeDefIndex: 1911
{
	// Methods

	// RVA: 0x5C3500 Offset: 0x5C1B00 VA: 0x1805C3500
	public void .ctor(object , IntPtr ) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(Player player, Controller controller) { }

	// RVA: 0x5C34C0 Offset: 0x5C1AC0 VA: 0x1805C34C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Player player, Controller controller, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Rewired
public enum ModifierKey // TypeDefIndex: 1912
{
	// Fields
	public int value__; // 0x0
	public const ModifierKey None = 0;
	public const ModifierKey Control = 1;
	public const ModifierKey Alt = 2;
	public const ModifierKey Shift = 3;
	public const ModifierKey Command = 4;
}

// Namespace: Rewired
[Flags]
public enum ModifierKeyFlags // TypeDefIndex: 1913
{
	// Fields
	public int value__; // 0x0
	public const ModifierKeyFlags None = 0;
	public const ModifierKeyFlags LeftControl = 1;
	public const ModifierKeyFlags RightControl = 2;
	public const ModifierKeyFlags LeftAlt = 4;
	public const ModifierKeyFlags RightAlt = 8;
	public const ModifierKeyFlags LeftShift = 16;
	public const ModifierKeyFlags RightShift = 32;
	public const ModifierKeyFlags LeftCommand = 64;
	public const ModifierKeyFlags RightCommand = 128;
}

// Namespace: Rewired
public enum KeyboardKeyCode // TypeDefIndex: 1914
{
	// Fields
	public int value__; // 0x0
	public const KeyboardKeyCode None = 0;
	public const KeyboardKeyCode A = 97;
	public const KeyboardKeyCode B = 98;
	public const KeyboardKeyCode C = 99;
	public const KeyboardKeyCode D = 100;
	public const KeyboardKeyCode E = 101;
	public const KeyboardKeyCode F = 102;
	public const KeyboardKeyCode G = 103;
	public const KeyboardKeyCode H = 104;
	public const KeyboardKeyCode I = 105;
	public const KeyboardKeyCode J = 106;
	public const KeyboardKeyCode K = 107;
	public const KeyboardKeyCode L = 108;
	public const KeyboardKeyCode M = 109;
	public const KeyboardKeyCode N = 110;
	public const KeyboardKeyCode O = 111;
	public const KeyboardKeyCode P = 112;
	public const KeyboardKeyCode Q = 113;
	public const KeyboardKeyCode R = 114;
	public const KeyboardKeyCode S = 115;
	public const KeyboardKeyCode T = 116;
	public const KeyboardKeyCode U = 117;
	public const KeyboardKeyCode V = 118;
	public const KeyboardKeyCode W = 119;
	public const KeyboardKeyCode X = 120;
	public const KeyboardKeyCode Y = 121;
	public const KeyboardKeyCode Z = 122;
	public const KeyboardKeyCode Alpha0 = 48;
	public const KeyboardKeyCode Alpha1 = 49;
	public const KeyboardKeyCode Alpha2 = 50;
	public const KeyboardKeyCode Alpha3 = 51;
	public const KeyboardKeyCode Alpha4 = 52;
	public const KeyboardKeyCode Alpha5 = 53;
	public const KeyboardKeyCode Alpha6 = 54;
	public const KeyboardKeyCode Alpha7 = 55;
	public const KeyboardKeyCode Alpha8 = 56;
	public const KeyboardKeyCode Alpha9 = 57;
	public const KeyboardKeyCode Keypad0 = 256;
	public const KeyboardKeyCode Keypad1 = 257;
	public const KeyboardKeyCode Keypad2 = 258;
	public const KeyboardKeyCode Keypad3 = 259;
	public const KeyboardKeyCode Keypad4 = 260;
	public const KeyboardKeyCode Keypad5 = 261;
	public const KeyboardKeyCode Keypad6 = 262;
	public const KeyboardKeyCode Keypad7 = 263;
	public const KeyboardKeyCode Keypad8 = 264;
	public const KeyboardKeyCode Keypad9 = 265;
	public const KeyboardKeyCode KeypadPeriod = 266;
	public const KeyboardKeyCode KeypadDivide = 267;
	public const KeyboardKeyCode KeypadMultiply = 268;
	public const KeyboardKeyCode KeypadMinus = 269;
	public const KeyboardKeyCode KeypadPlus = 270;
	public const KeyboardKeyCode KeypadEnter = 271;
	public const KeyboardKeyCode KeypadEquals = 272;
	public const KeyboardKeyCode Backspace = 8;
	public const KeyboardKeyCode Tab = 9;
	public const KeyboardKeyCode Clear = 12;
	public const KeyboardKeyCode Return = 13;
	public const KeyboardKeyCode Pause = 19;
	public const KeyboardKeyCode Escape = 27;
	public const KeyboardKeyCode Space = 32;
	public const KeyboardKeyCode Exclaim = 33;
	public const KeyboardKeyCode DoubleQuote = 34;
	public const KeyboardKeyCode Hash = 35;
	public const KeyboardKeyCode Dollar = 36;
	public const KeyboardKeyCode Ampersand = 38;
	public const KeyboardKeyCode Quote = 39;
	public const KeyboardKeyCode LeftParen = 40;
	public const KeyboardKeyCode RightParen = 41;
	public const KeyboardKeyCode Asterisk = 42;
	public const KeyboardKeyCode Plus = 43;
	public const KeyboardKeyCode Comma = 44;
	public const KeyboardKeyCode Minus = 45;
	public const KeyboardKeyCode Period = 46;
	public const KeyboardKeyCode Slash = 47;
	public const KeyboardKeyCode Colon = 58;
	public const KeyboardKeyCode Semicolon = 59;
	public const KeyboardKeyCode Less = 60;
	public const KeyboardKeyCode Equals = 61;
	public const KeyboardKeyCode Greater = 62;
	public const KeyboardKeyCode Question = 63;
	public const KeyboardKeyCode At = 64;
	public const KeyboardKeyCode LeftBracket = 91;
	public const KeyboardKeyCode Backslash = 92;
	public const KeyboardKeyCode RightBracket = 93;
	public const KeyboardKeyCode Caret = 94;
	public const KeyboardKeyCode Underscore = 95;
	public const KeyboardKeyCode BackQuote = 96;
	public const KeyboardKeyCode Delete = 127;
	public const KeyboardKeyCode UpArrow = 273;
	public const KeyboardKeyCode DownArrow = 274;
	public const KeyboardKeyCode RightArrow = 275;
	public const KeyboardKeyCode LeftArrow = 276;
	public const KeyboardKeyCode Insert = 277;
	public const KeyboardKeyCode Home = 278;
	public const KeyboardKeyCode End = 279;
	public const KeyboardKeyCode PageUp = 280;
	public const KeyboardKeyCode PageDown = 281;
	public const KeyboardKeyCode F1 = 282;
	public const KeyboardKeyCode F2 = 283;
	public const KeyboardKeyCode F3 = 284;
	public const KeyboardKeyCode F4 = 285;
	public const KeyboardKeyCode F5 = 286;
	public const KeyboardKeyCode F6 = 287;
	public const KeyboardKeyCode F7 = 288;
	public const KeyboardKeyCode F8 = 289;
	public const KeyboardKeyCode F9 = 290;
	public const KeyboardKeyCode F10 = 291;
	public const KeyboardKeyCode F11 = 292;
	public const KeyboardKeyCode F12 = 293;
	public const KeyboardKeyCode F13 = 294;
	public const KeyboardKeyCode F14 = 295;
	public const KeyboardKeyCode F15 = 296;
	public const KeyboardKeyCode Numlock = 300;
	public const KeyboardKeyCode CapsLock = 301;
	public const KeyboardKeyCode ScrollLock = 302;
	public const KeyboardKeyCode RightShift = 303;
	public const KeyboardKeyCode LeftShift = 304;
	public const KeyboardKeyCode RightControl = 305;
	public const KeyboardKeyCode LeftControl = 306;
	public const KeyboardKeyCode RightAlt = 307;
	public const KeyboardKeyCode LeftAlt = 308;
	public const KeyboardKeyCode RightCommand = 309;
	public const KeyboardKeyCode LeftCommand = 310;
	public const KeyboardKeyCode LeftWindows = 311;
	public const KeyboardKeyCode RightWindows = 312;
	public const KeyboardKeyCode AltGr = 313;
	public const KeyboardKeyCode Help = 315;
	public const KeyboardKeyCode Print = 316;
	public const KeyboardKeyCode SysReq = 317;
	public const KeyboardKeyCode Break = 318;
	public const KeyboardKeyCode Menu = 319;
}

// Namespace: Rewired
public enum MouseInputElement // TypeDefIndex: 1915
{
	// Fields
	public int value__; // 0x0
	public const MouseInputElement AxisX = 0;
	public const MouseInputElement AxisY = 1;
	public const MouseInputElement Axis3 = 2;
	public const MouseInputElement Button0 = 3;
	public const MouseInputElement Button1 = 4;
	public const MouseInputElement Button2 = 5;
	public const MouseInputElement Button3 = 6;
	public const MouseInputElement Button4 = 7;
	public const MouseInputElement Button5 = 8;
	public const MouseInputElement Button6 = 9;
	public const MouseInputElement Axis4 = 10;
}

// Namespace: Rewired
public enum MouseXYAxisMode // TypeDefIndex: 1916
{
	// Fields
	public int value__; // 0x0
	public const MouseXYAxisMode MouseAxis = 0;
	public const MouseXYAxisMode DigitalAxis = 1;
	public const MouseXYAxisMode ScreenPositionDelta = 3;
	public const MouseXYAxisMode Speed = 4;
}

// Namespace: Rewired
public enum MouseXYAxisDeltaCalc // TypeDefIndex: 1917
{
	// Fields
	public int value__; // 0x0
	public const MouseXYAxisDeltaCalc Normal = 0;
	public const MouseXYAxisDeltaCalc ScreenWidth = 1;
	public const MouseXYAxisDeltaCalc ScreenHeight = 2;
}

// Namespace: Rewired
public enum MouseOtherAxisMode // TypeDefIndex: 1918
{
	// Fields
	public int value__; // 0x0
	public const MouseOtherAxisMode MouseAxis = 0;
	public const MouseOtherAxisMode DigitalAxis = 1;
}

// Namespace: Rewired
public enum InputActionType // TypeDefIndex: 1919
{
	// Fields
	public int value__; // 0x0
	public const InputActionType Axis = 0;
	public const InputActionType Button = 1;
}

// Namespace: Rewired
public enum AxisType // TypeDefIndex: 1920
{
	// Fields
	public int value__; // 0x0
	public const AxisType None = 0;
	public const AxisType Normal = 1;
	public const AxisType Split = 2;
}

// Namespace: Rewired
public enum Pole // TypeDefIndex: 1921
{
	// Fields
	public int value__; // 0x0
	public const Pole Positive = 0;
	public const Pole Negative = 1;
}

// Namespace: Rewired
public enum AxisRange // TypeDefIndex: 1922
{
	// Fields
	public int value__; // 0x0
	public const AxisRange Full = 0;
	public const AxisRange Positive = 1;
	public const AxisRange Negative = 2;
}

// Namespace: Rewired
public enum AxisCoordinateMode // TypeDefIndex: 1923
{
	// Fields
	public int value__; // 0x0
	public const AxisCoordinateMode Absolute = 0;
	public const AxisCoordinateMode Relative = 1;
}

// Namespace: Rewired
public enum ControllerType // TypeDefIndex: 1924
{
	// Fields
	public int value__; // 0x0
	public const ControllerType Keyboard = 0;
	public const ControllerType Mouse = 1;
	public const ControllerType Joystick = 2;
	public const ControllerType Custom = 20;
}

// Namespace: Rewired
public enum ControllerElementType // TypeDefIndex: 1925
{
	// Fields
	public int value__; // 0x0
	public const ControllerElementType Axis = 0;
	public const ControllerElementType Button = 1;
	public const ControllerElementType CompoundElement = 100;
}

// Namespace: Rewired
public enum CompoundControllerElementType // TypeDefIndex: 1926
{
	// Fields
	public int value__; // 0x0
	public const CompoundControllerElementType Axis2D = 0;
	public const CompoundControllerElementType DPad = 10;
	public const CompoundControllerElementType Hat = 11;
}

// Namespace: Rewired
public enum DeadZone2DType // TypeDefIndex: 1927
{
	// Fields
	public int value__; // 0x0
	public const DeadZone2DType Radial = 1;
	public const DeadZone2DType Axial = 2;
}

// Namespace: Rewired
public enum AxisSensitivity2DType // TypeDefIndex: 1928
{
	// Fields
	public int value__; // 0x0
	public const AxisSensitivity2DType Radial = 0;
	public const AxisSensitivity2DType Axial = 1;
}

// Namespace: Rewired
public enum ElementAssignmentType // TypeDefIndex: 1929
{
	// Fields
	public int value__; // 0x0
	public const ElementAssignmentType FullAxis = 0;
	public const ElementAssignmentType SplitAxis = 1;
	public const ElementAssignmentType Button = 2;
	public const ElementAssignmentType KeyboardKey = 3;
}

// Namespace: Rewired
public enum UpdateLoopType // TypeDefIndex: 1930
{
	// Fields
	public int value__; // 0x0
	public const UpdateLoopType Update = 0;
	public const UpdateLoopType FixedUpdate = 1;
	public const UpdateLoopType OnGUI = 2;
}

// Namespace: Rewired
public enum InputActionEventType // TypeDefIndex: 1931
{
	// Fields
	public int value__; // 0x0
	public const InputActionEventType Update = 0;
	public const InputActionEventType ButtonPressed = 1;
	public const InputActionEventType ButtonUnpressed = 2;
	public const InputActionEventType ButtonJustPressed = 3;
	public const InputActionEventType ButtonJustReleased = 4;
	public const InputActionEventType ButtonDoublePressed = 5;
	public const InputActionEventType ButtonJustDoublePressed = 6;
	public const InputActionEventType ButtonPressedForTime = 7;
	public const InputActionEventType ButtonJustPressedForTime = 8;
	public const InputActionEventType ButtonPressedForTimeJustReleased = 9;
	public const InputActionEventType ButtonShortPressed = 10;
	public const InputActionEventType ButtonJustShortPressed = 11;
	public const InputActionEventType ButtonShortPressJustReleased = 12;
	public const InputActionEventType ButtonLongPressed = 13;
	public const InputActionEventType ButtonJustLongPressed = 14;
	public const InputActionEventType ButtonLongPressJustReleased = 15;
	public const InputActionEventType ButtonRepeating = 16;
	public const InputActionEventType NegativeButtonPressed = 17;
	public const InputActionEventType NegativeButtonUnpressed = 18;
	public const InputActionEventType NegativeButtonJustPressed = 19;
	public const InputActionEventType NegativeButtonJustReleased = 20;
	public const InputActionEventType NegativeButtonDoublePressed = 21;
	public const InputActionEventType NegativeButtonJustDoublePressed = 22;
	public const InputActionEventType NegativeButtonPressedForTime = 23;
	public const InputActionEventType NegativeButtonJustPressedForTime = 24;
	public const InputActionEventType NegativeButtonPressedForTimeJustReleased = 25;
	public const InputActionEventType NegativeButtonShortPressed = 26;
	public const InputActionEventType NegativeButtonJustShortPressed = 27;
	public const InputActionEventType NegativeButtonShortPressJustReleased = 28;
	public const InputActionEventType NegativeButtonLongPressed = 29;
	public const InputActionEventType NegativeButtonJustLongPressed = 30;
	public const InputActionEventType NegativeButtonLongPressJustReleased = 31;
	public const InputActionEventType NegativeButtonRepeating = 32;
	public const InputActionEventType AxisActive = 33;
	public const InputActionEventType AxisInactive = 34;
	public const InputActionEventType AxisRawActive = 35;
	public const InputActionEventType AxisRawInactive = 36;
	public const InputActionEventType AxisActiveOrJustInactive = 37;
	public const InputActionEventType AxisRawActiveOrJustInactive = 38;
	public const InputActionEventType ButtonDoublePressJustReleased = 100;
	public const InputActionEventType ButtonSinglePressed = 101;
	public const InputActionEventType ButtonJustSinglePressed = 102;
	public const InputActionEventType ButtonSinglePressJustReleased = 103;
	public const InputActionEventType NegativeButtonDoublePressJustReleased = 150;
	public const InputActionEventType NegativeButtonSinglePressed = 151;
	public const InputActionEventType NegativeButtonJustSinglePressed = 152;
	public const InputActionEventType NegativeButtonSinglePressJustReleased = 153;
}

// Namespace: Rewired
public enum AxisSensitivityType // TypeDefIndex: 1932
{
	// Fields
	public int value__; // 0x0
	public const AxisSensitivityType Multiplier = 0;
	public const AxisSensitivityType Power = 1;
	public const AxisSensitivityType Curve = 2;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum JoystickType // TypeDefIndex: 1933
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const JoystickType Unknown = 0;
	[CustomObfuscation(rename = False)]
	public const JoystickType Gamepad = 1;
	[CustomObfuscation(rename = False)]
	public const JoystickType DualAnalogGamepad = 2;
	[CustomObfuscation(rename = False)]
	public const JoystickType SingleAnalogGamepad = 3;
	[CustomObfuscation(rename = False)]
	public const JoystickType DigitalGamepad = 4;
	[CustomObfuscation(rename = False)]
	public const JoystickType Joystick = 10;
	[CustomObfuscation(rename = False)]
	public const JoystickType AnalogJoystick = 11;
	[CustomObfuscation(rename = False)]
	public const JoystickType DigitalJoystick = 12;
	[CustomObfuscation(rename = False)]
	public const JoystickType Throttle = 20;
	[CustomObfuscation(rename = False)]
	public const JoystickType HOTAS = 21;
	[CustomObfuscation(rename = False)]
	public const JoystickType FlightYoke = 22;
	[CustomObfuscation(rename = False)]
	public const JoystickType FlightPedals = 23;
	[CustomObfuscation(rename = False)]
	public const JoystickType ThrottleQuadrant = 24;
	[CustomObfuscation(rename = False)]
	public const JoystickType TrimWheel = 25;
	[CustomObfuscation(rename = False)]
	public const JoystickType DrivingWheel = 40;
	[CustomObfuscation(rename = False)]
	public const JoystickType Pedals = 41;
	[CustomObfuscation(rename = False)]
	public const JoystickType GearShifter = 42;
	[CustomObfuscation(rename = False)]
	public const JoystickType Guitar = 50;
	[CustomObfuscation(rename = False)]
	public const JoystickType Drums = 51;
	[CustomObfuscation(rename = False)]
	public const JoystickType DancePad = 70;
	[CustomObfuscation(rename = False)]
	public const JoystickType Paddle = 80;
	[CustomObfuscation(rename = False)]
	public const JoystickType Spinner = 81;
	[CustomObfuscation(rename = False)]
	public const JoystickType Trackball = 82;
	[CustomObfuscation(rename = False)]
	public const JoystickType Gun = 83;
	[CustomObfuscation(rename = False)]
	public const JoystickType RemoteControl = 100;
	[CustomObfuscation(rename = False)]
	public const JoystickType PointingDevice = 101;
	[CustomObfuscation(rename = False)]
	public const JoystickType ShipController = 120;
	[CustomObfuscation(rename = False)]
	public const JoystickType TrainController = 121;
	[CustomObfuscation(rename = False)]
	public const JoystickType HelicopterController = 122;
	[CustomObfuscation(rename = False)]
	public const JoystickType FootController = 123;
	[CustomObfuscation(rename = False)]
	public const JoystickType ControlPanel = 140;
	[CustomObfuscation(rename = False)]
	public const JoystickType Keypad = 141;
	[CustomObfuscation(rename = False)]
	public const JoystickType VRController = 150;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum InputSource // TypeDefIndex: 1934
{
	// Fields
	public int value__; // 0x0
	public const InputSource None = 0;
	public const InputSource DirectInput = 1;
	public const InputSource XInput = 2;
	public const InputSource OSX = 3;
	public const InputSource Fallback = 4;
	public const InputSource RawInput = 5;
	public const InputSource Fallback_PreConfigured = 6;
	public const InputSource Linux = 7;
	public const InputSource WindowsUWP = 8;
	public const InputSource WebGL = 9;
	public const InputSource Steam = 18;
	public const InputSource SDL2 = 19;
	public const InputSource Ouya = 20;
	public const InputSource XboxOne = 21;
	public const InputSource PS4 = 22;
	public const InputSource NintendoSwitch = 24;
	public const InputSource GameCoreXboxOne = 26;
	public const InputSource GameCoreScarlett = 27;
	public const InputSource PS5 = 28;
	public const InputSource AppleGameController = 29;
	public const InputSource WindowsGamingInput = 30;
	public const InputSource NintendoSwitch2 = 31;
	public const InputSource InternalDriver = 49;
	public const InputSource UnityKeyboardAndMouse = 50;
	public const InputSource Custom = 100;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum InputPlatform // TypeDefIndex: 1935
{
	// Fields
	public int value__; // 0x0
	public const InputPlatform Unknown = 0;
	public const InputPlatform WindowsDirectInput = 1;
	public const InputPlatform WindowsRawInput = 2;
	public const InputPlatform WindowsXInput = 3;
	public const InputPlatform WindowsFallback = 4;
	public const InputPlatform WindowsUWP = 5;
	public const InputPlatform WindowsUWPFallback = 6;
	public const InputPlatform WindowsWGI = 7;
	public const InputPlatform OSXNative = 8;
	public const InputPlatform OSXFallback = 9;
	public const InputPlatform LinuxNative = 10;
	public const InputPlatform LinuxFallback = 11;
	public const InputPlatform LinuxFallback_PreConfigured = 12;
	public const InputPlatform AndroidFallback = 13;
	public const InputPlatform AmazonFireTVFallback = 14;
	public const InputPlatform RazerForgeTVFallback = 15;
	public const InputPlatform iOSFallback = 16;
	public const InputPlatform WindowsPhone8Fallback = 17;
	public const InputPlatform BlackberryFallback = 18;
	public const InputPlatform PS3Fallback = 19;
	public const InputPlatform PS4Fallback = 20;
	public const InputPlatform PSMFallback = 21;
	public const InputPlatform PSVitaFallback = 22;
	public const InputPlatform XBox360Fallback = 23;
	public const InputPlatform XBoxOneFallback = 24;
	public const InputPlatform WiiFallback = 25;
	public const InputPlatform WiiUFallback = 26;
	public const InputPlatform Fallback = 27;
	public const InputPlatform Ouya = 28;
	public const InputPlatform XboxOne = 29;
	public const InputPlatform GameCore = 30;
	public const InputPlatform PS4 = 31;
	public const InputPlatform PS5 = 32;
	public const InputPlatform NintendoSwitch = 33;
	public const InputPlatform NintendoSwitchFallback = 34;
	public const InputPlatform NintendoSwitch2 = 35;
	public const InputPlatform Custom = 36;
	public const InputPlatform InternalDriver = 37;
	public const InputPlatform SDL2 = 38;
	public const InputPlatform SDL2Windows = 39;
	public const InputPlatform SDL2OSX = 40;
	public const InputPlatform SDL2Linux = 41;
	public const InputPlatform Steam = 42;
	public const InputPlatform WebGL = 43;
	public const InputPlatform AppleGameController = 44;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum ControlDeviceType // TypeDefIndex: 1936
{
	// Fields
	public int value__; // 0x0
	public const ControlDeviceType Keyboard = 0;
	public const ControlDeviceType Mouse = 1;
	public const ControlDeviceType Joystick = 2;
	public const ControlDeviceType Gamepad = 3;
	public const ControlDeviceType ArcadeStick = 4;
	public const ControlDeviceType DancePad = 5;
	public const ControlDeviceType DrumKit = 6;
	public const ControlDeviceType Flight = 7;
	public const ControlDeviceType Throttle = 8;
	public const ControlDeviceType Guitar = 9;
	public const ControlDeviceType Wheel = 10;
	public const ControlDeviceType Paddle = 11;
	public const ControlDeviceType Custom = 99;
	public const ControlDeviceType Unknown = 100;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum ControllerSubType // TypeDefIndex: 1937
{
	// Fields
	public int value__; // 0x0
	public const ControllerSubType None = 0;
	public const ControllerSubType Gamepad = 1;
	public const ControllerSubType Guitar = 2;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum BoolOption // TypeDefIndex: 1938
{
	// Fields
	public int value__; // 0x0
	public const BoolOption Default = 0;
	public const BoolOption True = 1;
	public const BoolOption False = 2;
}

// Namespace: Rewired
[Flags]
[CustomObfuscation(rename = False)]
internal enum ButtonStateFlags // TypeDefIndex: 1939
{
	// Fields
	public int value__; // 0x0
	public const ButtonStateFlags Off = 0;
	public const ButtonStateFlags On = 1;
	public const ButtonStateFlags Down = 2;
	public const ButtonStateFlags Up = 4;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum MultiBoolValue // TypeDefIndex: 1940
{
	// Fields
	public int value__; // 0x0
	public const MultiBoolValue Off = 0;
	public const MultiBoolValue On = 1;
	public const MultiBoolValue Mixed = 2;
}

// Namespace: Rewired
[Browsable(False)]
[EditorBrowsable(1)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
public sealed class Initializer : MonoBehaviour // TypeDefIndex: 1941
{
	// Fields
	[SerializeField]
	private GameObject _inputManagerPrefab; // 0x20
	[SerializeField]
	private bool _destroySelf; // 0x28

	// Properties
	public GameObject inputManagerPrefab { get; set; }
	public bool destroySelf { get; set; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public GameObject get_inputManagerPrefab() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_inputManagerPrefab(GameObject value) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_destroySelf() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_destroySelf(bool value) { }

	// RVA: 0x1826230 Offset: 0x1824830 VA: 0x181826230
	private void Awake() { }

	// RVA: 0x1826240 Offset: 0x1824840 VA: 0x181826240
	public bool Initialize() { }

	// RVA: 0x18267C0 Offset: 0x1824DC0 VA: 0x1818267C0
	public void .ctor() { }
}

// Namespace: Rewired
public interface IControllerElementTarget // TypeDefIndex: 1942
{
	// Properties
	public abstract int elementIdentifierId { get; }
	public abstract AxisRange axisRange { get; }
	public abstract bool hasTarget { get; }
	public abstract ControllerElementType elementType { get; }
	public abstract string descriptiveName { get; }
	public abstract Controller controller { get; }
	public abstract Controller.Element element { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_elementIdentifierId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AxisRange get_axisRange();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_hasTarget();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ControllerElementType get_elementType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_descriptiveName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Controller get_controller();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Controller.Element get_element();
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class BridgedControllerHWInfo // TypeDefIndex: 1943
{
	// Fields
	public bool isMock; // 0x10
	public InputSource inputManagerSource; // 0x14
	public InputSource inputSource; // 0x18
	public ControlDeviceType deviceType; // 0x1C
	public string hardwareIdentifier; // 0x20
	public int hardwareAxisCount; // 0x28
	public int hardwareButtonCount; // 0x2C
	public int hardwareHatCount; // 0x30
	public string hw_productName; // 0x38
	public PidVid hw_pidVid; // 0x40
	public Guid hw_deviceGuid; // 0x44
	public int hw_productId; // 0x54
	public string hw_bluetoothDeviceName; // 0x58
	public bool hw_isBluetoothDevice; // 0x60
	public bool hw_supportsVoice; // 0x61
	public bool hw_supportsVibration; // 0x62
	public XInputDeviceSubType hw_xInputSubType; // 0x64
	public string hw_manufacturer; // 0x68
	public string hw_serialNumber; // 0x70
	public int hw_vendorId; // 0x78
	public int hw_version; // 0x7C
	public string hw_systemDeviceName; // 0x80
	public bool hw_isSDL2Gamepad; // 0x88
	public WebGLWebBrowserType webGL_webBrowserType; // 0x8C
	public WebGLOSType webGL_osType; // 0x90
	public WebGLGamepadMappingType webGL_mappingType; // 0x94
	public string[] webGL_webBrowserVersionSplit; // 0x98
	public string[] webGL_osVersionSplit; // 0xA0
	public int hw_localVibrationMotorCount; // 0xA8
	public string definitionMatchTag; // 0xB0
	public object userCustomIdentifier; // 0xB8

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x18225F0 Offset: 0x1820BF0 VA: 0x1818225F0
	public void .ctor(BridgedControllerHWInfo ) { }

	// RVA: 0x1822490 Offset: 0x1820A90 VA: 0x181822490
	private void VzcNwgyKQZJGjVIAoENNjrFgaygoA(BridgedControllerHWInfo ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class BridgedController : BridgedControllerHWInfo // TypeDefIndex: 1944
{
	// Fields
	public IInputManagerJoystickPublic sourceJoystick; // 0xC0
	public HardwareControllerMap_Game gameHardwareMap; // 0xC8
	public Guid controllerTypeGuid; // 0xD0
	public Controller.Extension controllerExtension; // 0xE0
	public string instanceName; // 0xE8
	public string productName; // 0xF0
	public bool isXInputDevice; // 0xF8
	public int axisCount; // 0xFC
	public int buttonCount; // 0x100
	public bool[] isButtonPressureSensitive; // 0x108
	public UnknownControllerHat[] unknownControllerHats; // 0x110
	public CustomInputSource customInputSource; // 0x118

	// Properties
	public bool isUnknownController { get; }

	// Methods

	// RVA: 0x1822760 Offset: 0x1820D60 VA: 0x181822760
	public bool get_isUnknownController() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class ControllerDataUpdater // TypeDefIndex: 1946
{
	// Fields
	public readonly InputSource source; // 0x10
	public readonly int axisCount; // 0x14
	public readonly int buttonCount; // 0x18
	public readonly float[] axisValues; // 0x20
	public readonly bool[] buttonValues; // 0x28
	public readonly float[] buttonPressureValues; // 0x30
	public readonly bool[] axisHasBeenPressedOSXLinux; // 0x38
	private readonly UnknownControllerHat[] GYbbxBeKXEFESneuUYTcSHBBkbxtA; // 0x40
	public bool hasReceivedInput; // 0x48

	// Methods

	// RVA: 0x1823100 Offset: 0x1821700 VA: 0x181823100
	public void .ctor(InputSource , int , int , UnknownControllerHat[] ) { }

	// RVA: 0x1823070 Offset: 0x1821670 VA: 0x181823070
	public bool IsUnknownHatCardinal(int buttonIndex) { }

	// RVA: 0x1822FC0 Offset: 0x18215C0 VA: 0x181822FC0
	public UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex) { }

	// RVA: 0x1822F30 Offset: 0x1821530 VA: 0x181822F30
	public void ClearData() { }
}

// Namespace: Rewired
[Usage(32767, AllowMultiple = False, Inherited = False)]
[ComVisible(False)]
internal sealed class CustomObfuscation : Attribute // TypeDefIndex: 1947
{
	// Fields
	public bool rename; // 0x10

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Rewired
[Usage(1036, AllowMultiple = False, Inherited = False)]
[ComVisible(False)]
internal sealed class CustomClassObfuscation : Attribute // TypeDefIndex: 1948
{
	// Fields
	public bool renamePubIntMembers; // 0x10
	public bool renamePrivateMembers; // 0x11

	// Methods

	// RVA: 0x18232B0 Offset: 0x18218B0 VA: 0x1818232B0
	public void .ctor() { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class UpdateControllerInfoEventArgs : EventArgs // TypeDefIndex: 1949
{
	// Fields
	public readonly IInputManagerJoystickPublic sourceJoystick; // 0x10

	// Methods

	// RVA: 0x1832010 Offset: 0x1830610 VA: 0x181832010
	public void .ctor(IInputManagerJoystickPublic ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class ControllerDisconnectedEventArgs : EventArgs // TypeDefIndex: 1950
{
	// Fields
	public readonly int rewiredId; // 0x10

	// Methods

	// RVA: 0x1823250 Offset: 0x1821850 VA: 0x181823250
	public void .ctor(int ) { }
}

// Namespace: Rewired
[AddComponentMenu("")]
[Browsable(False)]
[EditorBrowsable(1)]
[ExecuteInEditMode]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public abstract class InputManager_Base : MonoBehaviour // TypeDefIndex: 1954
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _dontDestroyOnLoad; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private UserData _userData; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerDataFiles _controllerDataFiles; // 0x30
	protected bool isCompiling; // 0x38
	private bool mPjnmUdcNAdNdjdLQJnWIScJMKDaB; // 0x39
	private bool CYxzjvczYzAmRgjUhDDfbMilcbzEA; // 0x3A
	protected EditorPlatform editorPlatform; // 0x3C
	protected Platform platform; // 0x40
	protected WebplayerPlatform webplayerPlatform; // 0x44
	protected bool isEditor; // 0x48
	protected bool _detectedPlatformInEditor; // 0x49
	[CustomObfuscation(rename = False)]
	protected ScriptingBackend scriptingBackend; // 0x4C
	[CustomObfuscation(rename = False)]
	protected ScriptingAPILevel scriptingAPILevel; // 0x50
	private bool ENWhVqIeJMWIDUzZbYjlldowOuZc; // 0x54
	private bool lgaFMjcuYeLtXtZRBOHSVvwqQHmkA; // 0x55

	// Properties
	public UserData userData { get; set; }
	public ControllerDataFiles dataFiles { get; set; }
	public bool runInEditMode { get; set; }
	internal bool isRunningInEditMode { get; }

	// Methods

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public UserData get_userData() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_userData(UserData value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public ControllerDataFiles get_dataFiles() { }

	// RVA: 0x1829070 Offset: 0x1827670 VA: 0x181829070
	public void set_dataFiles(ControllerDataFiles value) { }

	// RVA: 0x18286A0 Offset: 0x1826CA0 VA: 0x1818286A0
	public bool get_runInEditMode() { }

	// RVA: 0x1829140 Offset: 0x1827740 VA: 0x181829140
	public void set_runInEditMode(bool value) { }

	// RVA: 0x1828580 Offset: 0x1826B80 VA: 0x181828580
	internal bool get_isRunningInEditMode() { }

	// RVA: 0x18269D0 Offset: 0x1824FD0 VA: 0x1818269D0
	internal void DontDestroyOnLoad() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18267D0 Offset: 0x1824DD0 VA: 0x1818267D0
	private void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18277B0 Offset: 0x1825DB0 VA: 0x1818277B0
	private void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1827730 Offset: 0x1825D30 VA: 0x181827730
	private void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1827720 Offset: 0x1825D20 VA: 0x181827720
	private void OnDestroy() { }

	// RVA: 0x1828D20 Offset: 0x1827320 VA: 0x181828D20
	private void qhzftSMVHFSrPufVPRpAUzyRPyTV(bool ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1827660 Offset: 0x1825C60 VA: 0x181827660
	private void OnApplicationFocus(bool isFocused) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18276C0 Offset: 0x1825CC0 VA: 0x1818276C0
	private void OnApplicationPause(bool isPaused) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1827BE0 Offset: 0x18261E0 VA: 0x181827BE0
	private void Start() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1828300 Offset: 0x1826900 VA: 0x181828300
	private void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1826A80 Offset: 0x1825080 VA: 0x181826A80
	private void FixedUpdate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1827570 Offset: 0x1825B70 VA: 0x181827570
	private void LateUpdate() { }

	// RVA: 0x1827860 Offset: 0x1825E60 VA: 0x181827860
	internal void OnGUIUpdate() { }

	// RVA: 0x1826860 Offset: 0x1824E60 VA: 0x181826860
	internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit) { }

	// RVA: 0x1827C90 Offset: 0x1826290 VA: 0x181827C90
	internal void TryStartRunInEditMode() { }

	// RVA: 0x1828060 Offset: 0x1826660 VA: 0x181828060
	internal void TryStopRunInEditMode() { }

	// RVA: 0x1829320 Offset: 0x1827920 VA: 0x181829320
	private bool uOYQmplcLUacpcvjtfzLfLXTbmlt() { }

	// RVA: 0x1826CF0 Offset: 0x18252F0 VA: 0x181826CF0
	private void JuanJwxCSEdCpEyDivLkYBNFSMNr() { }

	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	private void JsqpzmVNCVaUVlFMiyKkUPUjJlGC(Platform ) { }

	// RVA: 0x1828E50 Offset: 0x1827450 VA: 0x181828E50
	private object qiQVhbuKtxujcokzwQzUlQzxFpm(ConfigVars ) { }

	// RVA: 0x18286D0 Offset: 0x1826CD0 VA: 0x1818286D0
	private List<Assembly> iNYeDHFfoemdacAZFeLmNerOaxoBB() { }

	// RVA: 0x1828A30 Offset: 0x1827030 VA: 0x181828A30
	private List<Assembly> jLTNpmsbESxjPpqgqmCBQVgbhefG() { }

	// RVA: 0x1828F10 Offset: 0x1827510 VA: 0x181828F10
	private byte[] rrgEWqHXXfBxyFnPiaXVmqdEWLcK() { }

	// RVA: 0x1828150 Offset: 0x1826750 VA: 0x181828150
	private void UWZpVzRliNMmxLNOnUaJIXBqrgvn(List<TextAsset> , List<string> ) { }

	// RVA: 0x1827AF0 Offset: 0x18260F0 VA: 0x181827AF0
	private string SkNJJkUyDLauiCQzxdQYTNyeoOeX() { }

	// RVA: 0x1828CF0 Offset: 0x18272F0 VA: 0x181828CF0
	private bool keifQOBCdclsxiyefVNRoIfBYAiL() { }

	// RVA: 0x18294F0 Offset: 0x1827AF0 VA: 0x1818294F0
	private string xFSKUwWThBPLKKPHeTLglwngGgIh() { }

	// RVA: 0x1829390 Offset: 0x1827990 VA: 0x181829390
	private bool vwRdueGlHeOizsprArmwgrTzWgKNA() { }

	// RVA: 0x1827A30 Offset: 0x1826030 VA: 0x181827A30
	protected void RecompileStart() { }

	// RVA: 0x18279C0 Offset: 0x1825FC0 VA: 0x1818279C0
	protected void RecompileEnd() { }

	// RVA: 0x1827920 Offset: 0x1825F20 VA: 0x181827920
	protected void OnSceneLoaded() { }

	// RVA: 0x1828440 Offset: 0x1826A40 VA: 0x181828440
	private void eAmAbQiYZBdRfElJwaKelHwhIEtG(InputManager_Base.QUoxAJmttWIyokUYauKeHTWUhRXw , string , Exception ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1827A80 Offset: 0x1826080 VA: 0x181827A80
	internal void ResetAll() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1826B40 Offset: 0x1825140 VA: 0x181826B40
	internal EditorPlatform GetEditorPlatform() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1826B80 Offset: 0x1825180 VA: 0x181826B80
	internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1826C30 Offset: 0x1825230 VA: 0x181826C30
	internal bool IsEditModeSupported() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnInitialized();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnDeinitialized();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void DetectPlatform();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void CheckRecompile();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract IExternalTools GetExternalTools();

	// RVA: 0x18283C0 Offset: 0x18269C0 VA: 0x1818283C0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1828C80 Offset: 0x1827280 VA: 0x181828C80
	private bool kWomsPbUaTFogJEFBlkTIfWdNKcH(Assembly ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal static class UnityInputHelper // TypeDefIndex: 1962
{
	// Fields
	private static UnityInputHelper.VfUAcpjDSmwPKsInrjNfARLeVXNzb[] TcVgoPCDsHqzHrlKYIAUNeYePrMnA; // 0x0

	// Methods

	// RVA: 0x18304B0 Offset: 0x182EAB0 VA: 0x1818304B0
	private static void .cctor() { }

	// RVA: 0x1830210 Offset: 0x182E810 VA: 0x181830210
	public static float GetJoystickAxisValueByJoystickId(int joystickId, int axisIndex) { }

	// RVA: 0x1830070 Offset: 0x182E670 VA: 0x181830070
	public static float GetJoystickAxisRawValueByJoystickId(int joystickId, int axisIndex) { }

	// RVA: 0x18302D0 Offset: 0x182E8D0 VA: 0x1818302D0
	public static float GetJoystickAxisValueByJoystickIndex(int joystickIndex, int axisIndex) { }

	// RVA: 0x1830130 Offset: 0x182E730 VA: 0x181830130
	public static float GetJoystickAxisRawValueByJoystickIndex(int joystickIndex, int axisIndex) { }

	// RVA: 0x18303B0 Offset: 0x182E9B0 VA: 0x1818303B0
	public static bool GetJoystickButtonValueByJoystickId(int joystickId, int buttonIndex) { }

	// RVA: 0x1830420 Offset: 0x182EA20 VA: 0x181830420
	public static bool GetJoystickButtonValueByJoystickIndex(int joystickIndex, int buttonIndex) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class UnityUnifiedKeyboardSource : IUnifiedKeyboardSource, IGetSetEnabled, IDisposable // TypeDefIndex: 1963
{
	// Fields
	private const int KplWGBLvaiAbXfnYoNoSNypBIJQv = 132;
	private static HardwareControllerMap_Game PeDDdOquhtyFztdeYGKPbDpUHfeE; // 0x0
	private bool kdthRHaFrzpNRTHjHPrNqbnFRisW; // 0x10
	private bool mJHqQkpsNhRKTLGhKuRsZMaFHRSr; // 0x11

	// Properties
	public bool enabled { get; set; }
	public InputSource inputSource { get; }
	public HardwareControllerMap_Game hardwareMap { get; }
	public int buttonCount { get; }
	public Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00 Slot: 10
	public bool get_enabled() { }

	// RVA: 0x1830DC0 Offset: 0x182F3C0 VA: 0x181830DC0 Slot: 11
	public void set_enabled(bool value) { }

	// RVA: 0x1830DB0 Offset: 0x182F3B0 VA: 0x181830DB0 Slot: 4
	public InputSource get_inputSource() { }

	// RVA: 0x1830D30 Offset: 0x182F330 VA: 0x181830D30 Slot: 5
	public HardwareControllerMap_Game get_hardwareMap() { }

	// RVA: 0x80F3C0 Offset: 0x80D9C0 VA: 0x18080F3C0 Slot: 6
	public int get_buttonCount() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public Controller.Extension get_controllerExtension() { }

	// RVA: 0x1830CE0 Offset: 0x182F2E0 VA: 0x181830CE0
	public void .ctor() { }

	// RVA: 0x1830CA0 Offset: 0x182F2A0 VA: 0x181830CA0 Slot: 8
	public void UpdateInputData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public void Clear() { }

	// RVA: 0x1830610 Offset: 0x182EC10 VA: 0x181830610
	internal static HardwareControllerMap_Game CreateHardwareMap() { }

	// RVA: 0x1830B30 Offset: 0x182F130 VA: 0x181830B30 Slot: 12
	public void Dispose() { }

	// RVA: 0x1830B90 Offset: 0x182F190 VA: 0x181830B90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1830AE0 Offset: 0x182F0E0 VA: 0x181830AE0 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1830C00 Offset: 0x182F200 VA: 0x181830C00
	public static ControllerElementType GetHardwareElementType(int elementIdentifierId) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class UnityUnifiedMouseSource : IUnifiedMouseSource, IGetSetEnabled, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private static HardwareControllerMap_Game mjyRRfaJNIclGOidfciztIdHRYon; // 0x0
	private UpdateLoopDataSet<UnityUnifiedMouseSource.RoNRJyCyELCVlYHkQYCrSweDMDxl> IWmaejqetnMPOnsPglurKqFiTXkQ; // 0x10
	private float[] WDRPMgHdbNeVGroTFbHQQgBGyadN; // 0x18
	private bool[] PjYevSEDCoyoScclzCFiUiNXFPVFb; // 0x20
	private bool FQlyjSVnnJnZYjsoLwNylhDeTemG; // 0x28
	private bool CLhUHcpMuseLqHbLirEAiAGlFNGx; // 0x29

	// Properties
	public bool enabled { get; set; }
	public InputSource inputSource { get; }
	public HardwareControllerMap_Game hardwareMap { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public Vector2 mousePosition { get; }
	public Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150 Slot: 12
	public bool get_enabled() { }

	// RVA: 0x1831F00 Offset: 0x1830500 VA: 0x181831F00 Slot: 13
	public void set_enabled(bool value) { }

	// RVA: 0x1830DB0 Offset: 0x182F3B0 VA: 0x181830DB0 Slot: 4
	public InputSource get_inputSource() { }

	// RVA: 0x1831E30 Offset: 0x1830430 VA: 0x181831E30 Slot: 5
	public HardwareControllerMap_Game get_hardwareMap() { }

	// RVA: 0x4565D0 Offset: 0x454BD0 VA: 0x1804565D0 Slot: 7
	public int get_buttonCount() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 6
	public int get_axisCount() { }

	// RVA: 0x1831EB0 Offset: 0x18304B0 VA: 0x181831EB0 Slot: 8
	public Vector2 get_mousePosition() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	public Controller.Extension get_controllerExtension() { }

	// RVA: 0x1831910 Offset: 0x182FF10 VA: 0x181831910
	public void .ctor() { }

	// RVA: 0x1831810 Offset: 0x182FE10 VA: 0x181831810 Slot: 10
	public void UpdateInputData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1830E00 Offset: 0x182F400 VA: 0x181830E00 Slot: 11
	public void Clear() { }

	// RVA: 0x1831CC0 Offset: 0x18302C0 VA: 0x181831CC0
	private void dhutwRzWLsfygZiGurVQxcJjrnPT() { }

	// RVA: 0x18317A0 Offset: 0x182FDA0 VA: 0x1818317A0
	private void MGujvODkaJIZPfqbkfGmgqNaMkMwB(UpdateLoopType ) { }

	// RVA: 0x1830ED0 Offset: 0x182F4D0 VA: 0x181830ED0
	internal static HardwareControllerMap_Game CreateHardwareMap() { }

	// RVA: 0x1831630 Offset: 0x182FC30 VA: 0x181831630 Slot: 14
	public void Dispose() { }

	// RVA: 0x1831690 Offset: 0x182FC90 VA: 0x181831690 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1831510 Offset: 0x182FB10 VA: 0x181831510 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1831700 Offset: 0x182FD00 VA: 0x181831700
	public static ControllerElementType GetHardwareElementType(int elementIdentifierId) { }
}

// Namespace: Rewired
[Serializable]
public sealed class ActionElementMap // TypeDefIndex: 1991
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal int _actionCategoryId; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal int _actionId; // 0x14
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal ControllerElementType _elementType; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal int _elementIdentifierId; // 0x1C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal AxisRange _axisRange; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal bool _invert; // 0x24
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal Pole _axisContribution; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal KeyboardKeyCode _keyboardKeyCode; // 0x2C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal ModifierKey _modifierKey1; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal ModifierKey _modifierKey2; // 0x34
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal ModifierKey _modifierKey3; // 0x38
	internal ControllerMap VZbcOnbGHkbQCctumTLcvpEpIcLe; // 0x40
	internal bool sJiZjarByPFOekuKHAIndKOqaLbdb; // 0x48
	internal int obegvRevRhSJpQYUkeELmTdhTSxx; // 0x4C
	internal readonly int nhahTzMMoVhwYeqkXRELLTHoCNHkA; // 0x50
	private uint MGlaOHQemlvwWFnItuHvCsGmNWxe; // 0x54
	private string lQXqaXehGhWeYxLfvsGpxRTzSjlc; // 0x58
	private string cqnMvchlbyATNjFDrUDpLCcehfdIA; // 0x60
	private ModifierKeyFlags iPLbxrayPJsdbnNjhLOBReCoRLEXA; // 0x68
	private HardwareControllerMap_Game aCtigVbbtwGnJVcmyoWkPAbDYtLv; // 0x70
	private double vYksJvjEEqENWeUQhnowZlLbPMnW; // 0x78
	private static int uidCounter; // 0x0
	private static StringBuilder s_toStringSB; // 0x8

	// Properties
	public int actionId { get; set; }
	public ControllerElementType elementType { get; set; }
	public int elementIdentifierId { get; set; }
	public AxisRange axisRange { get; set; }
	public bool invert { get; set; }
	public Pole axisContribution { get; set; }
	public KeyboardKeyCode keyboardKeyCode { get; set; }
	public ModifierKey modifierKey1 { get; set; }
	public ModifierKey modifierKey2 { get; set; }
	public ModifierKey modifierKey3 { get; set; }
	public AxisType axisType { get; }
	public ModifierKeyFlags modifierKeyFlags { get; }
	public KeyCode keyCode { get; set; }
	public bool hasModifiers { get; }
	[CustomObfuscation(rename = False)]
	internal double modifiedTime { get; }
	[CustomObfuscation(rename = False)]
	internal bool isModified { get; set; }
	public ControllerMap controllerMap { get; }
	public bool enabled { get; set; }
	public string elementIdentifierName { get; }
	public string actionDescriptiveName { get; }
	public int elementIndex { get; }
	public int id { get; }
	public object elementIdentifierGlyph { get; }
	public int elementIdentifierGlyphCount { get; }
	private bool kVXCxBngBYyNDEoJkiCdfDGgyjis { get; }
	private static int zWyqvvRcfcLlAnCJiudIOyLLgyET { get; }

	// Methods

	// RVA: 0x183CC80 Offset: 0x183B280 VA: 0x18183CC80
	internal static bool nbmwXKvMPFMOrqQhkTwczlggEOQP(ActionElementMap ) { }

	// RVA: 0x183CB50 Offset: 0x183B150 VA: 0x18183CB50
	internal static void mSizZbtBNHCtLNwiUEuUAHBnRqdEA(ActionElementMap , ActionElementMap ) { }

	// RVA: 0x183B700 Offset: 0x1839D00 VA: 0x18183B700
	public static bool TryGetCombinedElementIdentifierName(IList<ActionElementMap> actionElementMaps, out string result) { }

	// RVA: 0x183B6D0 Offset: 0x1839CD0 VA: 0x18183B6D0
	public static bool TryGetCombinedElementIdentifierGlyph(IList<ActionElementMap> actionElementMaps, out object result) { }

	// RVA: 0x183B6A0 Offset: 0x1839CA0 VA: 0x18183B6A0
	public static bool TryGetCombinedElementIdentifierFinalGlyphKey(IList<ActionElementMap> actionElementMaps, out string result) { }

	// RVA: 0x183D0A0 Offset: 0x183B6A0 VA: 0x18183D0A0
	private static bool scsicGBbABJGJqYcabNqpBoQnsci(IList<ActionElementMap> , bool , bool , out object , out string ) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_actionId() { }

	// RVA: 0x183D260 Offset: 0x183B860 VA: 0x18183D260
	public void set_actionId(int value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public ControllerElementType get_elementType() { }

	// RVA: 0x183AF80 Offset: 0x1839580 VA: 0x18183AF80
	internal void TCuOAEDCfSqfwOkkOtiGdbJxjnqM(ControllerElementType ) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_elementIdentifierId() { }

	// RVA: 0x183D540 Offset: 0x183BB40 VA: 0x18183D540
	public void set_elementIdentifierId(int value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public AxisRange get_axisRange() { }

	// RVA: 0x183D3C0 Offset: 0x183B9C0 VA: 0x18183D3C0
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_invert() { }

	// RVA: 0x183D770 Offset: 0x183BD70 VA: 0x18183D770
	public void set_invert(bool value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public Pole get_axisContribution() { }

	// RVA: 0x183D2C0 Offset: 0x183B8C0 VA: 0x18183D2C0
	public void set_axisContribution(Pole value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public KeyboardKeyCode get_keyboardKeyCode() { }

	// RVA: 0x183D980 Offset: 0x183BF80 VA: 0x18183D980
	public void set_keyboardKeyCode(KeyboardKeyCode value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public ModifierKey get_modifierKey1() { }

	// RVA: 0x183DAB0 Offset: 0x183C0B0 VA: 0x18183DAB0
	public void set_modifierKey1(ModifierKey value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public ModifierKey get_modifierKey2() { }

	// RVA: 0x183DBF0 Offset: 0x183C1F0 VA: 0x18183DBF0
	public void set_modifierKey2(ModifierKey value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public ModifierKey get_modifierKey3() { }

	// RVA: 0x183DD30 Offset: 0x183C330 VA: 0x18183DD30
	public void set_modifierKey3(ModifierKey value) { }

	// RVA: 0x183BFF0 Offset: 0x183A5F0 VA: 0x18183BFF0
	public AxisType get_axisType() { }

	// RVA: 0x183C3D0 Offset: 0x183A9D0 VA: 0x18183C3D0
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x183C3B0 Offset: 0x183A9B0 VA: 0x18183C3B0
	public KeyCode get_keyCode() { }

	// RVA: 0x183D840 Offset: 0x183BE40 VA: 0x18183D840
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x183C380 Offset: 0x183A980 VA: 0x18183C380
	public bool get_hasModifiers() { }

	// RVA: 0x183C3C0 Offset: 0x183A9C0 VA: 0x18183C3C0
	internal double get_modifiedTime() { }

	// RVA: 0x183C3A0 Offset: 0x183A9A0 VA: 0x18183C3A0
	internal bool get_isModified() { }

	// RVA: 0x183D7D0 Offset: 0x183BDD0 VA: 0x18183D7D0
	internal void set_isModified(bool value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public ControllerMap get_controllerMap() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_enabled() { }

	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	public void set_enabled(bool value) { }

	// RVA: 0x183C270 Offset: 0x183A870 VA: 0x18183C270
	public string get_elementIdentifierName() { }

	// RVA: 0x183BDB0 Offset: 0x183A3B0 VA: 0x18183BDB0
	public string get_actionDescriptiveName() { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public int get_elementIndex() { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public int get_id() { }

	// RVA: 0x183C100 Offset: 0x183A700 VA: 0x18183C100
	public object get_elementIdentifierGlyph() { }

	// RVA: 0x183C010 Offset: 0x183A610 VA: 0x18183C010
	public int get_elementIdentifierGlyphCount() { }

	// RVA: 0x183DF90 Offset: 0x183C590 VA: 0x18183DF90
	private bool zNLnxMZiWAbzJnqSbGeRivgWCcbw() { }

	// RVA: 0x183B870 Offset: 0x1839E70 VA: 0x18183B870
	private static int WBNKKmxUwBdfHQvtxQyCHfDiCePjA() { }

	// RVA: 0x183B930 Offset: 0x1839F30 VA: 0x18183B930
	public void .ctor() { }

	// RVA: 0x183B9B0 Offset: 0x1839FB0 VA: 0x18183B9B0
	public void .ctor(ActionElementMap ) { }

	// RVA: 0x183BB40 Offset: 0x183A140 VA: 0x18183BB40
	public void .ctor(int , ControllerElementType , int ) { }

	// RVA: 0x183B8D0 Offset: 0x1839ED0 VA: 0x18183B8D0
	public void .ctor(int , ControllerElementType , int , Pole , AxisRange ) { }

	// RVA: 0x183BAE0 Offset: 0x183A0E0 VA: 0x18183BAE0
	public void .ctor(int , ControllerElementType , int , Pole , AxisRange , bool ) { }

	// RVA: 0x183BB90 Offset: 0x183A190 VA: 0x18183BB90
	public void .ctor(int , ControllerElementType , Pole , KeyboardKeyCode , ModifierKey , ModifierKey , ModifierKey ) { }

	// RVA: 0x183A010 Offset: 0x1838610 VA: 0x18183A010
	public bool CheckForAssignmentConflict(ElementAssignment elementAssignment) { }

	// RVA: 0x183A190 Offset: 0x1838790 VA: 0x18183A190
	public bool CheckForAssignmentConflict(ActionElementMap elementMap) { }

	// RVA: 0x183ADC0 Offset: 0x18393C0 VA: 0x18183ADC0
	public bool ShowInField(AxisRange fieldActionRange) { }

	// RVA: 0x183A920 Offset: 0x1838F20 VA: 0x18183A920
	public bool IsTarget(ControllerElementTarget elementTarget) { }

	// RVA: 0x183A970 Offset: 0x1838F70 VA: 0x18183A970
	public bool IsTarget(IControllerElementTarget elementTarget) { }

	// RVA: 0x183A780 Offset: 0x1838D80 VA: 0x18183A780
	public int GetElementIdentifierGlyphs(ICollection<object> results) { }

	// RVA: -1 Offset: -1
	public int GetElementIdentifierGlyphs<T>(ICollection<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FDE40 Offset: 0x5FC440 VA: 0x1805FDE40
	|-ActionElementMap.GetElementIdentifierGlyphs<object>
	|
	|-RVA: 0x5FDB50 Offset: 0x5FC150 VA: 0x1805FDB50
	|-ActionElementMap.GetElementIdentifierGlyphs<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x183A5F0 Offset: 0x1838BF0 VA: 0x18183A5F0
	public int GetElementIdentifierFinalGlyphKeys(ICollection<string> results) { }

	// RVA: 0x1839D30 Offset: 0x1838330 VA: 0x181839D30
	internal void AmDgvCwpJZwhkgneqPTVkTkxAsMx(ControllerMap ) { }

	// RVA: 0x183C6F0 Offset: 0x183ACF0 VA: 0x18183C6F0
	internal void icpEqScKrgpExJpkrTOjcSlWbvhzA(ControllerMap , HardwareControllerMap_Game ) { }

	// RVA: 0x183DE70 Offset: 0x183C470 VA: 0x18183DE70
	private void umYvnyjHfvmdWJKMNYYDtZjrtmwd(bool ) { }

	// RVA: 0x183AB90 Offset: 0x1839190 VA: 0x18183AB90
	private void SPJGgLoERQllnFallFbGqCRqpywr(ControllerType , HardwareControllerMap_Game , bool ) { }

	// RVA: 0x1839E60 Offset: 0x1838460 VA: 0x181839E60
	private string CNyvOWeWeursZDPviNMgcJyWzaer() { }

	// RVA: 0x183A230 Offset: 0x1838830 VA: 0x18183A230
	private int FuAiWUtIVgavrWPuYlFCGySIMzzS(ICollection<object> ) { }

	// RVA: 0x183C790 Offset: 0x183AD90 VA: 0x18183C790
	private int kbDAFDaKrSqzxyzUUAMhhSnkAjyEA(ICollection<string> ) { }

	// RVA: 0x183DFC0 Offset: 0x183C5C0 VA: 0x18183DFC0
	internal void zdgPVrIGqnQvejDMaaFFIsTZfORZ() { }

	// RVA: 0x1839DD0 Offset: 0x18383D0 VA: 0x181839DD0
	private bool BKSfCvcTypkXEkRTchRbxJTeKIaHb(KeyboardKeyCode , ModifierKeyFlags ) { }

	// RVA: 0x183DF00 Offset: 0x183C500 VA: 0x18183DF00
	private bool vDpHqOaaRtnShuYqCIVOxWMuZfnr(int , AxisRange ) { }

	// RVA: 0x183D020 Offset: 0x183B620 VA: 0x18183D020
	private bool rthqOXfrORFAWEkbmkOWtrJgejqN(ElementAssignmentType ) { }

	// RVA: 0x183AB70 Offset: 0x1839170 VA: 0x18183AB70
	private void OnfrlvNtQPUFGGnanliEyHmtsHYQ() { }

	// RVA: 0x183BC60 Offset: 0x183A260 VA: 0x18183BC60
	private void anrOBoWrOWPJbmCXhtoILWyruPwL() { }

	// RVA: 0x183BD50 Offset: 0x183A350 VA: 0x18183BD50
	private void cbXYOOtcsPitbErRaiPuPOsxanZIA() { }

	// RVA: 0x183BC00 Offset: 0x183A200 VA: 0x18183BC00
	internal void aRXBEcokrpMhILNBhkhcKcgFOmOw() { }

	// RVA: 0x183CD20 Offset: 0x183B320 VA: 0x18183CD20
	internal SerializedObject nvqIOszOvxBVQegwCRjZFyxwgNeb() { }

	// RVA: 0x183C420 Offset: 0x183AA20 VA: 0x18183C420
	internal void hajqVaBLzeoqXPgJNHHSrpGeoDSP(SerializedObject ) { }

	// RVA: 0x183AFE0 Offset: 0x18395E0 VA: 0x18183AFE0 Slot: 3
	public override string ToString() { }
}

// Namespace: Rewired
public class CalibrationMapSaveData // TypeDefIndex: 1992
{
	// Fields
	private CalibrationMap VqnmAbwSDTqMLcgCPcmAKZuKctiu; // 0x10
	private ControllerType BbZFaxdDmcjTMdeQCUjgMCLsDYrxB; // 0x18
	private string JopbGdTnpnzpqDRakRaMXAsJjQTt; // 0x20

	// Properties
	public CalibrationMap map { get; }
	public ControllerType controllerType { get; }
	public string hardwareIdentifier { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public CalibrationMap get_map() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public ControllerType get_controllerType() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_hardwareIdentifier() { }

	// RVA: 0x15A7010 Offset: 0x15A5610 VA: 0x1815A7010
	public void .ctor(CalibrationMap , ControllerType , string ) { }
}

// Namespace: Rewired
public sealed class JoystickCalibrationMapSaveData : CalibrationMapSaveData // TypeDefIndex: 1993
{
	// Fields
	private Guid qNBbsuHuGxWMRHmJBUeyRzJzFJHO; // 0x28

	// Properties
	public Guid joystickHardwareTypeGuid { get; }

	// Methods

	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public Guid get_joystickHardwareTypeGuid() { }

	// RVA: 0x183FD90 Offset: 0x183E390 VA: 0x18183FD90
	public void .ctor(CalibrationMap , ControllerType , string , Guid ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
public sealed class CalibrationMap // TypeDefIndex: 1994
{
	// Fields
	private AxisCalibration[] PYKaumoMWxWSJJzAlCzNCpFNNnzA; // 0x10
	private MappedArray<AxisCalibration> xeTcAHeDDTrvYRzYFsjucIVCRvMf; // 0x18
	private IList<AxisCalibration> zYwRBhBnvURBjOwbNMPwppmJAhKP; // 0x20
	private readonly int AwPXnBkazpHRyVWTAPAPjtvyQjST; // 0x28

	// Properties
	public IList<AxisCalibration> Axes { get; }
	public int axisCount { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IList<AxisCalibration> get_Axes() { }

	// RVA: 0x378930 Offset: 0x376F30 VA: 0x180378930
	public int get_axisCount() { }

	// RVA: 0x183F8C0 Offset: 0x183DEC0 VA: 0x18183F8C0
	private void .ctor() { }

	// RVA: 0x183F5A0 Offset: 0x183DBA0 VA: 0x18183F5A0
	internal void .ctor(AxisCalibrationData[] , Func<int, int> ) { }

	// RVA: 0x183F7D0 Offset: 0x183DDD0 VA: 0x18183F7D0
	public void .ctor(AxisCalibration[] ) { }

	// RVA: 0x183F160 Offset: 0x183D760 VA: 0x18183F160
	public void Reset() { }

	// RVA: 0x183E290 Offset: 0x183C890 VA: 0x18183E290
	public AxisCalibration GetAxis(int index) { }

	// RVA: 0x183E3E0 Offset: 0x183C9E0 VA: 0x18183E3E0
	public float GetCalibratedValue(int axisIndex, float value) { }

	// RVA: 0x183F240 Offset: 0x183D840 VA: 0x18183F240
	public bool SetAxisData(int index, AxisCalibrationData data) { }

	// RVA: 0x183E130 Offset: 0x183C730 VA: 0x18183E130
	public AxisCalibrationData GetAxisData(int index) { }

	// RVA: 0x183E040 Offset: 0x183C640 VA: 0x18183E040
	internal void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone) { }

	// RVA: 0x183F470 Offset: 0x183DA70 VA: 0x18183F470
	public string ToXmlString() { }

	// RVA: 0x183F370 Offset: 0x183D970 VA: 0x18183F370
	public string ToJsonString() { }

	// RVA: 0x183EFF0 Offset: 0x183D5F0 VA: 0x18183EFF0
	public bool ImportXmlString(string xmlString) { }

	// RVA: 0x183EE80 Offset: 0x183D480 VA: 0x18183EE80
	public bool ImportJsonString(string jsonString) { }

	// RVA: 0x183E6C0 Offset: 0x183CCC0 VA: 0x18183E6C0
	private SerializedObject IVMLvhhbAvFDYqDedRZKOICnaTFM() { }

	// RVA: 0x183E4F0 Offset: 0x183CAF0 VA: 0x18183E4F0
	private void GkYkkByryAFihKWTFlhnnlkdfytBA(SerializedObject ) { }

	// RVA: 0x183E360 Offset: 0x183C960 VA: 0x18183E360
	internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class AxisCalibration // TypeDefIndex: 1995
{
	// Fields
	private AlternateAxisCalibrationType _calibrationMode; // 0x10
	private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations; // 0x18
	[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _enabled; // 0x20
	[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _deadZone; // 0x24
	[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _calibratedZero; // 0x28
	[Tooltip("Gets or sets the minimum value. This can be used to transform the value to a new range.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _calibratedMin; // 0x2C
	[Tooltip("Gets or sets the maximum value. This can be used to transform the value to a new range.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _calibratedMax; // 0x30
	[Tooltip("If true, the final value will be multiplied by -1. This can be used to correct an inverted Axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _invert; // 0x34
	[Tooltip("Determines how sensitivity will be calculated.
If sensitivityType is set to Multiplier or Power, the sensitivity property is used to calculate the value.
If sensitivityType is set to Curve, the sensitivityCurve property is used to calculate the value.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private AxisSensitivityType _sensitivityType; // 0x38
	[Tooltip("Gets or sets the sensitivity value.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(0, ∞)]
	private float _sensitivity; // 0x3C
	[Tooltip("Gets or sets the sensitivity curve. The curve has no effect unless sensitivityType is set to Curve.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private AnimationCurve _sensitivityCurve; // 0x40
	[Tooltip("If enabled, calibratedMin, calibratedMax, and calibratedZero will be used to convert the value to a new range.
If disabled, calibratedMin, calibratedMax, and calibratedZero will have no effect on the final value.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _applyRangeCalibration; // 0x48

	// Properties
	public bool enabled { get; set; }
	public float deadZone { get; set; }
	public float calibratedZero { get; set; }
	public float calibratedMin { get; set; }
	public float calibratedMax { get; set; }
	public bool invert { get; set; }
	public AxisSensitivityType sensitivityType { get; set; }
	public float sensitivity { get; set; }
	public AnimationCurve sensitivityCurve { get; set; }
	public bool applyRangeCalibration { get; set; }
	internal AlternateAxisCalibrationType calibrationMode { get; set; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_enabled() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_enabled(bool value) { }

	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490
	public float get_deadZone() { }

	// RVA: 0x1853750 Offset: 0x1851D50 VA: 0x181853750
	public void set_deadZone(float value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0
	public float get_calibratedZero() { }

	// RVA: 0x3CB510 Offset: 0x3C9B10 VA: 0x1803CB510
	public void set_calibratedZero(float value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0
	public float get_calibratedMin() { }

	// RVA: 0x1853730 Offset: 0x1851D30 VA: 0x181853730
	public void set_calibratedMin(float value) { }

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0
	public float get_calibratedMax() { }

	// RVA: 0x36F720 Offset: 0x36DD20 VA: 0x18036F720
	public void set_calibratedMax(float value) { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_invert() { }

	// RVA: 0x16A5170 Offset: 0x16A3770 VA: 0x1816A5170
	public void set_invert(bool value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public AxisSensitivityType get_sensitivityType() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_sensitivityType(AxisSensitivityType value) { }

	// RVA: 0x1853720 Offset: 0x1851D20 VA: 0x181853720
	public float get_sensitivity() { }

	// RVA: 0x1853770 Offset: 0x1851D70 VA: 0x181853770
	public void set_sensitivity(float value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public AnimationCurve get_sensitivityCurve() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_sensitivityCurve(AnimationCurve value) { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_applyRangeCalibration() { }

	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	public void set_applyRangeCalibration(bool value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal AlternateAxisCalibrationType get_calibrationMode() { }

	// RVA: 0x1853740 Offset: 0x1851D40 VA: 0x181853740
	internal void set_calibrationMode(AlternateAxisCalibrationType value) { }

	// RVA: 0x1853360 Offset: 0x1851960 VA: 0x181853360
	internal void .ctor() { }

	// RVA: 0x1853540 Offset: 0x1851B40 VA: 0x181853540
	internal void .ctor(bool , Dictionary<int, AxisCalibrationInfo> , float , float , float , float , bool , bool , AxisSensitivityType , float , AnimationCurve ) { }

	// RVA: 0x18531F0 Offset: 0x18517F0 VA: 0x1818531F0
	internal void .ctor(AxisCalibrationData ) { }

	// RVA: 0x1851CF0 Offset: 0x18502F0 VA: 0x181851CF0
	internal void CopyFrom(AxisCalibration data, bool copyHardwareData) { }

	// RVA: 0x1852730 Offset: 0x1850D30 VA: 0x181852730
	public float GetCalibratedValue(float value) { }

	// RVA: 0x1852520 Offset: 0x1850B20 VA: 0x181852520
	internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion) { }

	// RVA: 0x18527F0 Offset: 0x1850DF0 VA: 0x1818527F0
	public float GetCalibratedValue(float value, AxisRange axisRange) { }

	// RVA: 0x1852600 Offset: 0x1850C00 VA: 0x181852600
	internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion) { }

	// RVA: 0x1852920 Offset: 0x1850F20 VA: 0x181852920
	public AxisCalibrationData GetData() { }

	// RVA: 0x1853180 Offset: 0x1851780 VA: 0x181853180
	public void SetData(AxisCalibrationData data) { }

	// RVA: 0x1852FC0 Offset: 0x18515C0 VA: 0x181852FC0
	public void Reset() { }

	// RVA: 0x1852290 Offset: 0x1850890 VA: 0x181852290
	internal SerializedObject ExportData() { }

	// RVA: 0x1852B10 Offset: 0x1851110 VA: 0x181852B10
	internal void Import(SerializedObject serializedObject) { }

	// RVA: 0x1852D10 Offset: 0x1851310 VA: 0x181852D10
	private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData) { }

	// RVA: 0x1851E10 Offset: 0x1850410 VA: 0x181851E10
	private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData) { }

	// RVA: 0x1852A10 Offset: 0x1851010 VA: 0x181852A10
	private AxisCalibrationInfo GetHardwareDefault() { }

	// RVA: 0x1851EC0 Offset: 0x18504C0 VA: 0x181851EC0
	internal static AxisCalibration CreateRelative() { }
}

// Namespace: Rewired
public struct AxisCalibrationData // TypeDefIndex: 1996
{
	// Fields
	public bool enabled; // 0x0
	public float deadZone; // 0x4
	public float zero; // 0x8
	public float min; // 0xC
	public float max; // 0x10
	public bool invert; // 0x14
	public AxisSensitivityType sensitivityType; // 0x18
	public float sensitivity; // 0x1C
	public AnimationCurve sensitivityCurve; // 0x20
	public bool applyRangeCalibration; // 0x28
	[CustomObfuscation(rename = False)]
	internal Dictionary<int, AxisCalibrationInfo> calibrations; // 0x30

	// Properties
	public static AxisCalibrationData Default { get; }
	[CustomObfuscation(rename = False)]
	internal static AxisCalibrationData Raw { get; }

	// Methods

	// RVA: 0x18515F0 Offset: 0x184FBF0 VA: 0x1818515F0
	public void .ctor(bool , float , float , float , float , bool , bool ) { }

	// RVA: 0x1851820 Offset: 0x184FE20 VA: 0x181851820
	public void .ctor(bool , float , float , float , float , bool , bool , float ) { }

	// RVA: 0x18517A0 Offset: 0x184FDA0 VA: 0x1818517A0
	public void .ctor(bool , float , float , float , float , bool , bool , AxisSensitivityType , float , AnimationCurve ) { }

	// RVA: 0x18519D0 Offset: 0x184FFD0 VA: 0x1818519D0
	public static AxisCalibrationData get_Default() { }

	// RVA: 0x1851B60 Offset: 0x1850160 VA: 0x181851B60
	internal static AxisCalibrationData get_Raw() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class Axis2DCalibration // TypeDefIndex: 1997
{
	// Fields
	[Tooltip("The calculation type for the dead zone.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private DeadZone2DType _deadZoneType; // 0x10
	[Tooltip("Calculation type for sensitivity on 2D axes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private AxisSensitivity2DType _sensitivityType; // 0x14

	// Properties
	public DeadZone2DType deadZoneType { get; set; }
	public AxisSensitivity2DType sensitivityType { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public DeadZone2DType get_deadZoneType() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_deadZoneType(DeadZone2DType value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public AxisSensitivity2DType get_sensitivityType() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_sensitivityType(AxisSensitivity2DType value) { }

	// RVA: 0x140BB40 Offset: 0x140A140 VA: 0x18140BB40
	internal void .ctor() { }

	// RVA: 0x18510D0 Offset: 0x184F6D0 VA: 0x1818510D0
	internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis) { }

	// RVA: 0x1850BC0 Offset: 0x184F1C0 VA: 0x181850BC0
	internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal static class ControllerElementRole // TypeDefIndex: 1998
{
	// Fields
	public const string stick1X = "stick1/x";
	public const string stick1Y = "stick1/y";
	public const string stick1Z = "stick1/z";
	public const string stick1Press = "stick1/press";
	public const string stick1Trigger = "stick1/trigger";
	public const string stick1TriggerStage1 = "stick1/trigger/stage1";
	public const string stick2X = "stick2/x";
	public const string stick2Y = "stick2/y";
	public const string stick2Z = "stick2/z";
	public const string stick2Press = "stick2/press";
	public const string stick2Trigger = "stick2/trigger";
	public const string stick2TriggerStage1 = "stick2/trigger/stage1";
	public const string gamepadA = "gamepad/a";
	public const string gamepadB = "gamepad/b";
	public const string gamepadC = "gamepad/c";
	public const string gamepadX = "gamepad/x";
	public const string gamepadY = "gamepad/y";
	public const string gamepadZ = "gamepad/z";
	public const string gamepadLB = "gamepad/lb";
	public const string gamepadRB = "gamepad/rb";
	public const string gamepadLT = "gamepad/lt";
	public const string gamepadRT = "gamepad/rt";
	public const string dpadU = "dpad/up";
	public const string dpadR = "dpad/right";
	public const string dpadD = "dpad/down";
	public const string dpadL = "dpad/left";
	public const string gamepadSelect = "gamepad/select";
	public const string gamepadStart = "gamepad/start";
	public const string gamepadLogoButton = "gamepad/logo_button";
	public const string home = "home";
	public const string capture = "capture";
	public const string chat = "chat";
	public const string mute = "mute";
	public const string gamepadTouchpadPress = "gamepad/touchpad/press";
	public const string wheel = "racing/wheel";
	public const string accelerator = "racing/accelerator";
	public const string brake = "racing/brake";
	public const string clutch = "racing/clutch";
	public const string gearShiftUp = "racing/gear/up";
	public const string gearShiftDown = "racing/gear/down";
	public const string gearReverse = "racing/gear/reverse";
	public const string gearShifter1 = "racing/gear/1";
	public const string gearShifter2 = "racing/gear/2";
	public const string gearShifter3 = "racing/gear/3";
	public const string gearShifter4 = "racing/gear/4";
	public const string gearShifter5 = "racing/gear/5";
	public const string gearShifter6 = "racing/gear/6";
	public const string gearShifter7 = "racing/gear/7";
	public const string gearShifter8 = "racing/gear/8";
	public const string gearShifter9 = "racing/gear/9";
	public const string gearShifter10 = "racing/gear/10";
	public const string flightThrottle = "flight/throttle";
	public const string flightYokeRotate = "flight/yoke/rotate";
	public const string flightYokeZ = "flight/yoke/z";
	public const string flightLeftPedal = "flight/left_pedal";
	public const string flightRightPedal = "flight/right_pedal";
	public const string flightSlidePedals = "flight/slide_pedals";
	public const string joyMouse1X = "joy_mouse1/x";
	public const string joyMouse1Y = "joy_mouse1/y";
	public const string joyMouse2X = "joy_mouse2/x";
	public const string joyMouse2Y = "joy_mouse2/y";
	public const string joyConLeftSL = "left_joycon/sl";
	public const string joyConLeftSR = "left_joycon/sr";
	public const string joyConRightSL = "right_joycon/sl";
	public const string joyConRightSR = "right_joycon/sr";
	public const string joyConSL = "joycon/sl";
	public const string joyConSR = "joycon/sr";
	private static string[] __s_names; // 0x0

	// Properties
	private static string[] s_names { get; }

	// Methods

	// RVA: 0x1856000 Offset: 0x1854600 VA: 0x181856000
	private static string[] get_s_names() { }

	// RVA: 0x1855F70 Offset: 0x1854570 VA: 0x181855F70
	public static string[] GetNames() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[Serializable]
public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal, rFbSwIKNzFgQqRFWkIpWVHHHyFGy, dmwPlHfCHErBELjQlGwCmsUXbNbq, tJHBOPBhgRxxSrwgazuXzFVgEETjA, RAkQYiWtBKQzQUREhAKdwhDIibCx, bkVFZGAVFjngXfdSYilCslxopbQCA, wBCzWHiuIqOBhjedogWdWfhUXLiw // TypeDefIndex: 2003
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _positiveName; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _negativeName; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _positiveKey; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _negativeKey; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerElementType _elementType; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CompoundControllerElementType _compoundElementType; // 0x4C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _role; // 0x50
	private bool KCTojEYEDTrbyIlpVIbTzXoQXGIx; // 0x58
	private pUhEoiWOvgqPlrYlgZAEIssXSiSb YhJKwRdmeoqKHfqNKFcQMbjIzCFf; // 0x60
	private UUAkiZKANtINUnBWYdmOmFEoxyme MPxBrxXLeweirzNORyybEjvRxoAb; // 0x68
	private SLSLHxzeweNgpPTuwHHzTpNSmhDj LKxFvvPIgVygznTubDWXqrIoFLob; // 0x70
	private ScIpUCpajWbamQImZepVEnQIoqSR mkaRjSORfdRCKQTnbohQbehYRIRC; // 0x78
	private DeviceLocalizationInfo pCHowySsMPqXGETUfuQHkIrAkGbW; // 0x80
	private int CnQWTvNMbRrcDKDJkKkjBbuxhXvR; // 0x88
	private List<ControllerElementIdentifier.oDwIpMfACtNqwDMzqoEFZbBGEbpuA> XwqIfYsiEpFYOhPXYvbfFDnlbtErA; // 0x90
	private ControllerType ueOXYQsoGngpDmjxAULRzVGmQCPT; // 0x98
	private static ControllerElementIdentifier bVLZqVECBjDxAVAuPgGbYhKSowPt; // 0x0

	// Properties
	public int id { get; }
	public string name { get; set; }
	public string positiveName { get; set; }
	public string negativeName { get; set; }
	public ControllerElementType elementType { get; }
	public CompoundControllerElementType compoundElementType { get; }
	public object glyph { get; }
	public object positiveGlyph { get; }
	public object negativeGlyph { get; }
	private string finalGlyphKey { get; }
	private string finalPositiveGlyphKey { get; }
	private string finalNegativeGlyphKey { get; }
	internal string nonLocalizedName { get; set; }
	internal string nonLocalizedPositiveName { get; set; }
	internal string nonLocalizedNegativeName { get; set; }
	public string key { get; }
	public string positiveKey { get; }
	public string negativeKey { get; }
	public string role { get; }
	internal bool isCompoundElement { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedPositiveName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedNegativeName { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedPositiveNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedNegativeNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isPositiveKeyAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNegativeKeyAutoGenerated { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.key { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.positiveKey { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.negativeKey { get; }
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.deviceLocalizationInfo { get; }
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; }
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; }
	internal static ControllerElementIdentifier BlankReadOnly { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedPositiveDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.positiveKey { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.negativeKey { get; set; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.keyCategory { get; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.key { get; }
	private int Rewired.Internal.Glyphs.IGlyphKeySource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.positiveKey { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.negativeKey { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public int get_id() { }

	// RVA: 0x18556F0 Offset: 0x1853CF0 VA: 0x1818556F0 Slot: 5
	public string get_name() { }

	// RVA: 0x1855B70 Offset: 0x1854170 VA: 0x181855B70
	internal void set_name(string value) { }

	// RVA: 0x1855A30 Offset: 0x1854030 VA: 0x181855A30 Slot: 6
	public string get_positiveName() { }

	// RVA: 0x1855D90 Offset: 0x1854390 VA: 0x181855D90
	internal void set_positiveName(string value) { }

	// RVA: 0x1855890 Offset: 0x1853E90 VA: 0x181855890 Slot: 7
	public string get_negativeName() { }

	// RVA: 0x1855C80 Offset: 0x1854280 VA: 0x181855C80
	internal void set_negativeName(string value) { }

	// RVA: 0x1853CA0 Offset: 0x18522A0 VA: 0x181853CA0
	internal string GetCompoundElementSpecialName(int index) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public ControllerElementType get_elementType() { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public CompoundControllerElementType get_compoundElementType() { }

	// RVA: 0x1855610 Offset: 0x1853C10 VA: 0x181855610
	public object get_glyph() { }

	// RVA: 0x1855960 Offset: 0x1853F60 VA: 0x181855960
	public object get_positiveGlyph() { }

	// RVA: 0x18557C0 Offset: 0x1853DC0 VA: 0x1818557C0
	public object get_negativeGlyph() { }

	// RVA: 0x1854C50 Offset: 0x1853250 VA: 0x181854C50
	private string ZbklYqqBPxWvWXDxLcKMBfSNjABe() { }

	// RVA: 0x18554A0 Offset: 0x1853AA0 VA: 0x1818554A0
	private string dUeIVqJuKjpqQYghTxUgpboAEJK() { }

	// RVA: 0x1855EA0 Offset: 0x18544A0 VA: 0x181855EA0
	private string yzhcHOWhpSTgDpxSzphRYdkpSiGm() { }

	// RVA: 0x1853BC0 Offset: 0x18521C0 VA: 0x181853BC0
	internal object GetCompoundElementSpecialGlyph(int index) { }

	// RVA: 0x1853AE0 Offset: 0x18520E0 VA: 0x181853AE0
	internal string GetCompoundElementSpecialFinalGlyphKey(int index) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_nonLocalizedName() { }

	// RVA: 0x1855B70 Offset: 0x1854170 VA: 0x181855B70
	internal void set_nonLocalizedName(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_nonLocalizedPositiveName() { }

	// RVA: 0x1855D90 Offset: 0x1854390 VA: 0x181855D90
	internal void set_nonLocalizedPositiveName(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal string get_nonLocalizedNegativeName() { }

	// RVA: 0x1855C80 Offset: 0x1854280 VA: 0x181855C80
	internal void set_nonLocalizedNegativeName(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_key() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_positiveKey() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_negativeKey() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_role() { }

	// RVA: 0x18556E0 Offset: 0x1853CE0 VA: 0x1818556E0
	internal bool get_isCompoundElement() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedName() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 9
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedPositiveName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 10
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedNegativeName() { }

	// RVA: 0x18544E0 Offset: 0x1852AE0 VA: 0x1818544E0 Slot: 11
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementNonLocalizedName(int index) { }

	// RVA: 0x18545E0 Offset: 0x1852BE0 VA: 0x1818545E0 Slot: 16
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedPositiveNameAutoGenerated() { }

	// RVA: 0x18545D0 Offset: 0x1852BD0 VA: 0x1818545D0 Slot: 17
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedNegativeNameAutoGenerated() { }

	// RVA: 0x18545F0 Offset: 0x1852BF0 VA: 0x1818545F0 Slot: 18
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isPositiveKeyAutoGenerated() { }

	// RVA: 0x18545C0 Offset: 0x1852BC0 VA: 0x1818545C0 Slot: 19
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNegativeKeyAutoGenerated() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 12
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_key() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 13
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_positiveKey() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 14
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_negativeKey() { }

	// RVA: 0x1854450 Offset: 0x1852A50 VA: 0x181854450 Slot: 15
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementKey(int index) { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510 Slot: 20
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_deviceLocalizationInfo() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1854F50 Offset: 0x1853550 VA: 0x181854F50
	public void .ctor(ControllerElementIdentifier ) { }

	// RVA: 0x18551C0 Offset: 0x18537C0 VA: 0x1818551C0
	internal void .ctor(ControllerElementIdentifier.bGyzYlFkGvakUcfidQcMxjXLDSsDA ) { }

	[Obsolete("Used by plugins for mouse controllers. Left for plugin compatibility. Do not use.", False)]
	// RVA: 0x18552C0 Offset: 0x18538C0 VA: 0x1818552C0
	internal void .ctor(int , string , string , string , ControllerElementType , CompoundControllerElementType , bool ) { }

	[Obsolete("Used by UnifiedKeyboardSource. Left for plugin compatibility. Do not use.", False)]
	// RVA: 0x1854D20 Offset: 0x1853320 VA: 0x181854D20
	internal void .ctor(int , string , string , string , ControllerElementType , bool ) { }

	// RVA: 0x1854F20 Offset: 0x1853520 VA: 0x181854F20
	internal void .ctor(ControllerElementIdentifier , bool , ControllerElementType ) { }

	// RVA: 0x1853780 Offset: 0x1851D80 VA: 0x181853780
	public ControllerElementIdentifier Clone() { }

	// RVA: 0x1853D90 Offset: 0x1852390 VA: 0x181853D90
	public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange) { }

	// RVA: 0x1853FC0 Offset: 0x18525C0 VA: 0x181853FC0
	public string GetDisplayName(AxisRange axisRange) { }

	// RVA: 0x1854220 Offset: 0x1852820 VA: 0x181854220
	public object GetGlyph(ControllerElementType actualElementType, AxisRange axisRange) { }

	// RVA: 0x1854210 Offset: 0x1852810 VA: 0x181854210
	public object GetGlyph(AxisRange axisRange) { }

	// RVA: 0x1853FE0 Offset: 0x18525E0 VA: 0x181853FE0
	public string GetFinalGlyphKey(ControllerElementType actualElementType, AxisRange axisRange) { }

	// RVA: 0x1853FD0 Offset: 0x18525D0 VA: 0x181853FD0
	public string GetFinalGlyphKey(AxisRange axisRange) { }

	// RVA: 0x1854570 Offset: 0x1852B70 VA: 0x181854570 Slot: 21
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_elementType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 22
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_useEditorElementTypeOverride() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940 Slot: 23
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_editorElementTypeOverride() { }

	// RVA: 0x1855B00 Offset: 0x1854100 VA: 0x181855B00
	private void lSNKsXXQBMwvZGPkBHeGKUjJXIaI() { }

	// RVA: 0x18537E0 Offset: 0x1851DE0 VA: 0x1818537E0
	internal void FinishRuntimeSetup(DeviceLocalizationInfo deviceLocalizationInfo, ControllerType controllerType) { }

	// RVA: 0x1855570 Offset: 0x1853B70 VA: 0x181855570
	internal static ControllerElementIdentifier get_BlankReadOnly() { }

	// RVA: 0x1854C00 Offset: 0x1853200 VA: 0x181854C00
	internal static void ToElementNameLocalizerTypes(ControllerElementType type, CompoundControllerElementType compoundType, out NrPxKUKQSPaerZsCohGosVlmvWeK.sUpanQdFnWgYwScTqDjkbGSfxPXrA resultElementType, out NrPxKUKQSPaerZsCohGosVlmvWeK.DXSlqAqgGjIHDCIlYMrXHUcnXVoMA resultCompoundElementType) { }

	// RVA: 0x1854900 Offset: 0x1852F00 VA: 0x181854900 Slot: 32
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 33
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 34
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x1854930 Offset: 0x1852F30 VA: 0x181854930 Slot: 35
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 24
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x1854890 Offset: 0x1852E90 VA: 0x181854890 Slot: 25
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 26
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x1854820 Offset: 0x1852E20 VA: 0x181854820 Slot: 27
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 36
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 28
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_positiveKey() { }

	// RVA: 0x1854670 Offset: 0x1852C70 VA: 0x181854670 Slot: 29
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_positiveKey(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 30
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_negativeKey() { }

	// RVA: 0x1854600 Offset: 0x1852C00 VA: 0x181854600 Slot: 31
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_negativeKey(string value) { }

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90 Slot: 37
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x3AAD20 Offset: 0x3A9320 VA: 0x1803AAD20 Slot: 38
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x1854A30 Offset: 0x1853030 VA: 0x181854A30 Slot: 47
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementNonLocalizedDescriptiveName(int index) { }

	// RVA: 0x1854B60 Offset: 0x1853160 VA: 0x181854B60 Slot: 48
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementNonLocalizedDescriptiveName(int index, string value) { }

	// RVA: 0x18549A0 Offset: 0x1852FA0 VA: 0x1818549A0 Slot: 49
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementKey(int index) { }

	// RVA: 0x1854AC0 Offset: 0x18530C0 VA: 0x181854AC0 Slot: 50
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementKey(int index, string value) { }

	// RVA: 0x18546E0 Offset: 0x1852CE0 VA: 0x1818546E0 Slot: 43
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_keyCategory() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 44
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_key() { }

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90 Slot: 45
	private int Rewired.Internal.Glyphs.IGlyphKeySource.get_autoGeneratedValueFlags() { }

	// RVA: 0x3AAD20 Offset: 0x3A9320 VA: 0x1803AAD20 Slot: 46
	private void Rewired.Internal.Glyphs.IGlyphKeySource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 39
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_positiveKey() { }

	// RVA: 0x1854670 Offset: 0x1852C70 VA: 0x181854670 Slot: 40
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_positiveKey(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 41
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_negativeKey() { }

	// RVA: 0x1854600 Offset: 0x1852C00 VA: 0x181854600 Slot: 42
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_negativeKey(string value) { }

	// RVA: 0x18546F0 Offset: 0x1852CF0 VA: 0x1818546F0 Slot: 51
	private string Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.GetSpecialElementKey(int index) { }

	// RVA: 0x1854780 Offset: 0x1852D80 VA: 0x181854780 Slot: 52
	private void Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.SetSpecialElementKey(int index, string value) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[Serializable]
public class ControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, rFbSwIKNzFgQqRFWkIpWVHHHyFGy, dmwPlHfCHErBELjQlGwCmsUXbNbq, tJHBOPBhgRxxSrwgazuXzFVgEETjA, RAkQYiWtBKQzQUREhAKdwhDIibCx, bkVFZGAVFjngXfdSYilCslxopbQCA, wBCzWHiuIqOBhjedogWdWfhUXLiw // TypeDefIndex: 2008
{
	// Fields
	private const string oKQBviIeyMPWZHdDiEiRjIifKUzpA = "controller/template";
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _positiveName; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _negativeName; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	public string _key; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	public string _positiveKey; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	public string _negativeKey; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerTemplateElementType _elementType; // 0x48
	private pUhEoiWOvgqPlrYlgZAEIssXSiSb AcaYrelQxNuMSdfSiwVXkcHZJnkU; // 0x50
	private UUAkiZKANtINUnBWYdmOmFEoxyme KvuAnUcUCJwdmbJyqkJNSnTMYJiF; // 0x58
	private SLSLHxzeweNgpPTuwHHzTpNSmhDj AZjaqOXGJDEVpPPDAyFHvKADOKUN; // 0x60
	private ScIpUCpajWbamQImZepVEnQIoqSR tcOCyhIgRatEORsSRnijDWFAoDvr; // 0x68
	private DeviceLocalizationInfo stFcJdmtilAreDRziibObOYaDPQnA; // 0x70
	private int zObolsBSQoVxSTbGTfBBzIzIGXGE; // 0x78
	private List<ControllerTemplateElementIdentifier.QymqJxVUvVOpiFBNpomvUILmAMZZ> ABDeDaEujESxlqgwkURmcXWaRrkJA; // 0x80

	// Properties
	public int id { get; }
	public string name { get; set; }
	public string positiveName { get; set; }
	public string negativeName { get; set; }
	public ControllerTemplateElementType elementType { get; }
	internal virtual bool useEditorElementTypeOverride { get; }
	internal virtual ControllerElementType editorElementTypeOverride { get; }
	public object glyph { get; }
	public object positiveGlyph { get; }
	public object negativeGlyph { get; }
	private string finalGlyphKey { get; }
	private string finalPositiveGlyphKey { get; }
	private string finalNegativeGlyphKey { get; }
	internal string nonLocalizedName { get; set; }
	internal string nonLocalizedPositiveName { get; set; }
	internal string nonLocalizedNegativeName { get; set; }
	public string key { get; }
	public string positiveKey { get; }
	public string negativeKey { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedPositiveName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedNegativeName { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedPositiveNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedNegativeNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isPositiveKeyAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNegativeKeyAutoGenerated { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.key { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.positiveKey { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.negativeKey { get; }
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.deviceLocalizationInfo { get; }
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; }
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedPositiveDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.positiveKey { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.negativeKey { get; set; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.keyCategory { get; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.key { get; }
	private int Rewired.Internal.Glyphs.IGlyphKeySource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.positiveKey { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.negativeKey { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public int get_id() { }

	// RVA: 0x186A2C0 Offset: 0x18688C0 VA: 0x18186A2C0 Slot: 5
	public string get_name() { }

	// RVA: 0x186A6D0 Offset: 0x1868CD0 VA: 0x18186A6D0
	internal void set_name(string value) { }

	// RVA: 0x186A600 Offset: 0x1868C00 VA: 0x18186A600 Slot: 6
	public string get_positiveName() { }

	// RVA: 0x186A850 Offset: 0x1868E50 VA: 0x18186A850
	internal void set_positiveName(string value) { }

	// RVA: 0x186A460 Offset: 0x1868A60 VA: 0x18186A460 Slot: 7
	public string get_negativeName() { }

	// RVA: 0x186A790 Offset: 0x1868D90 VA: 0x18186A790
	internal void set_negativeName(string value) { }

	// RVA: 0x18689E0 Offset: 0x1866FE0 VA: 0x1818689E0
	internal string GetCompoundElementSpecialName(int index) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940 Slot: 24
	public ControllerTemplateElementType get_elementType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 54
	internal virtual bool get_useEditorElementTypeOverride() { }

	// RVA: 0x186A1B0 Offset: 0x18687B0 VA: 0x18186A1B0 Slot: 55
	internal virtual ControllerElementType get_editorElementTypeOverride() { }

	// RVA: 0x186A1F0 Offset: 0x18687F0 VA: 0x18186A1F0
	public object get_glyph() { }

	// RVA: 0x186A530 Offset: 0x1868B30 VA: 0x18186A530
	public object get_positiveGlyph() { }

	// RVA: 0x186A390 Offset: 0x1868990 VA: 0x18186A390
	public object get_negativeGlyph() { }

	// RVA: 0x18690A0 Offset: 0x18676A0 VA: 0x1818690A0
	private string LQIQlrMCnFNNdtlSkcPYdmpfNxJXA() { }

	// RVA: 0x186A040 Offset: 0x1868640 VA: 0x18186A040
	private string dPeQgukblKCFRaaukofnRKjzLTaxA() { }

	// RVA: 0x1869C10 Offset: 0x1868210 VA: 0x181869C10
	private string URCVYNsmHWqRlovhiFbTMQIigHfv() { }

	// RVA: 0x1868900 Offset: 0x1866F00 VA: 0x181868900
	internal object GetCompoundElementSpecialGlyph(int index) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_nonLocalizedName() { }

	// RVA: 0x186A6D0 Offset: 0x1868CD0 VA: 0x18186A6D0
	internal void set_nonLocalizedName(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_nonLocalizedPositiveName() { }

	// RVA: 0x186A850 Offset: 0x1868E50 VA: 0x18186A850
	internal void set_nonLocalizedPositiveName(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal string get_nonLocalizedNegativeName() { }

	// RVA: 0x186A790 Offset: 0x1868D90 VA: 0x18186A790
	internal void set_nonLocalizedNegativeName(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_key() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_positiveKey() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_negativeKey() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedName() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 9
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedPositiveName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 10
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedNegativeName() { }

	// RVA: 0x1869200 Offset: 0x1867800 VA: 0x181869200 Slot: 11
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementNonLocalizedName(int index) { }

	// RVA: 0x1869320 Offset: 0x1867920 VA: 0x181869320 Slot: 16
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedPositiveNameAutoGenerated() { }

	// RVA: 0x1869310 Offset: 0x1867910 VA: 0x181869310 Slot: 17
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedNegativeNameAutoGenerated() { }

	// RVA: 0x1869330 Offset: 0x1867930 VA: 0x181869330 Slot: 18
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isPositiveKeyAutoGenerated() { }

	// RVA: 0x1869300 Offset: 0x1867900 VA: 0x181869300 Slot: 19
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNegativeKeyAutoGenerated() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 12
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_key() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 13
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_positiveKey() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 14
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_negativeKey() { }

	// RVA: 0x1869170 Offset: 0x1867770 VA: 0x181869170 Slot: 15
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementKey(int index) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0 Slot: 20
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_deviceLocalizationInfo() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1869DD0 Offset: 0x18683D0 VA: 0x181869DD0
	public void .ctor(ControllerTemplateElementIdentifier ) { }

	// RVA: 0x1869CE0 Offset: 0x18682E0 VA: 0x181869CE0
	internal void .ctor(ControllerTemplateElementIdentifier.rwhrCXRHtVpKufmRQSafKTOAgCJP ) { }

	// RVA: 0x186A010 Offset: 0x1868610 VA: 0x18186A010
	internal void .ctor(ControllerTemplateElementIdentifier , ControllerTemplateElementType , bool ) { }

	// RVA: 0x1868580 Offset: 0x1866B80 VA: 0x181868580 Slot: 56
	public virtual ControllerTemplateElementIdentifier Clone() { }

	// RVA: 0x1868AD0 Offset: 0x18670D0 VA: 0x181868AD0
	public string GetDisplayName(AxisRange axisRange) { }

	// RVA: 0x1868EB0 Offset: 0x18674B0 VA: 0x181868EB0
	public object GetGlyph(AxisRange axisRange) { }

	// RVA: 0x1868CC0 Offset: 0x18672C0 VA: 0x181868CC0
	public string GetFinalGlyphKey(AxisRange axisRange) { }

	// RVA: 0x1869770 Offset: 0x1867D70 VA: 0x181869770
	internal ControllerElementIdentifier ToControllerElementIdentifier(IHardwareControllerMap_Internal hardwareControllerMap) { }

	// RVA: 0x18692B0 Offset: 0x18678B0 VA: 0x1818692B0 Slot: 21
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_elementType() { }

	// RVA: 0x1869340 Offset: 0x1867940 VA: 0x181869340 Slot: 22
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_useEditorElementTypeOverride() { }

	// RVA: 0x1869290 Offset: 0x1867890 VA: 0x181869290 Slot: 23
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_editorElementTypeOverride() { }

	// RVA: 0x18685E0 Offset: 0x1866BE0 VA: 0x1818685E0
	internal void FinishRuntimeSetup(DeviceLocalizationInfo deviceLocalizationInfo) { }

	// RVA: 0x18694E0 Offset: 0x1867AE0 VA: 0x1818694E0 Slot: 33
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 34
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 35
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 36
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 25
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10 Slot: 26
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 27
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0 Slot: 28
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 37
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 29
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_positiveKey() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0 Slot: 30
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_positiveKey(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 31
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_negativeKey() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990 Slot: 32
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_negativeKey(string value) { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360 Slot: 38
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x18693A0 Offset: 0x18679A0 VA: 0x1818693A0 Slot: 39
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x18695A0 Offset: 0x1867BA0 VA: 0x1818695A0 Slot: 48
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementNonLocalizedDescriptiveName(int index) { }

	// RVA: 0x18696D0 Offset: 0x1867CD0 VA: 0x1818696D0 Slot: 49
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementNonLocalizedDescriptiveName(int index, string value) { }

	// RVA: 0x1869510 Offset: 0x1867B10 VA: 0x181869510 Slot: 50
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementKey(int index) { }

	// RVA: 0x1869630 Offset: 0x1867C30 VA: 0x181869630 Slot: 51
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementKey(int index, string value) { }

	// RVA: 0x1869370 Offset: 0x1867970 VA: 0x181869370 Slot: 44
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_keyCategory() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 45
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_key() { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360 Slot: 46
	private int Rewired.Internal.Glyphs.IGlyphKeySource.get_autoGeneratedValueFlags() { }

	// RVA: 0x18693A0 Offset: 0x18679A0 VA: 0x1818693A0 Slot: 47
	private void Rewired.Internal.Glyphs.IGlyphKeySource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 40
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_positiveKey() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0 Slot: 41
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_positiveKey(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 42
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_negativeKey() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990 Slot: 43
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_negativeKey(string value) { }

	// RVA: 0x18693B0 Offset: 0x18679B0 VA: 0x1818693B0 Slot: 52
	private string Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.GetSpecialElementKey(int index) { }

	// RVA: 0x1869440 Offset: 0x1867A40 VA: 0x181869440 Slot: 53
	private void Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.SetSpecialElementKey(int index, string value) { }

	// RVA: 0x186A110 Offset: 0x1868710 VA: 0x18186A110
	private static void ftHgfgVJlIHrJVzYsbTmCqNOkoPq(ControllerTemplateElementType , out NrPxKUKQSPaerZsCohGosVlmvWeK.sUpanQdFnWgYwScTqDjkbGSfxPXrA , out NrPxKUKQSPaerZsCohGosVlmvWeK.DXSlqAqgGjIHDCIlYMrXHUcnXVoMA ) { }
}

// Namespace: Rewired
public sealed class ControllerMapEnabler // TypeDefIndex: 2012
{
	// Fields
	private bool UiDEkrChLoIQMxJcyKfLUfCbHzmf; // 0x10
	private Player mYcTCTHSNsFPoCXwbqSAecZeHsos; // 0x18
	private ControllerMapEnabler.ExHBPPJAiWslLTxuqRFqHCQYvmjs fbeSYAWjYEDlcrQtkVpEYRSXscoC; // 0x20
	private readonly int qqXvQEYMuJPXDjhgpQshuYKlhder; // 0x28
	private List<ControllerMapEnabler.RuleSet> bBJoUTKgvDxsFFLVTFXhlJWNUsCf; // 0x30

	// Properties
	public bool enabled { get; set; }
	public List<ControllerMapEnabler.RuleSet> ruleSets { get; set; }

	// Methods

	// RVA: 0x18576F0 Offset: 0x1855CF0 VA: 0x1818576F0
	internal void .ctor(Player , ControllerMapEnabler.ExHBPPJAiWslLTxuqRFqHCQYvmjs ) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_enabled() { }

	// RVA: 0x1857F80 Offset: 0x1856580 VA: 0x181857F80
	public void set_enabled(bool value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<ControllerMapEnabler.RuleSet> get_ruleSets() { }

	// RVA: 0x1857F90 Offset: 0x1856590 VA: 0x181857F90
	public void set_ruleSets(List<ControllerMapEnabler.RuleSet> value) { }

	// RVA: 0x1856B20 Offset: 0x1855120 VA: 0x181856B20
	public void Apply() { }

	// RVA: 0x1857180 Offset: 0x1855780 VA: 0x181857180
	public void LoadDefaults() { }

	// RVA: 0x1857560 Offset: 0x1855B60 VA: 0x181857560
	public string ToXmlString() { }

	// RVA: 0x18573D0 Offset: 0x18559D0 VA: 0x1818573D0
	public string ToJsonString() { }

	// RVA: 0x1856FD0 Offset: 0x18555D0 VA: 0x181856FD0
	public bool ImportXml(string xmlString) { }

	// RVA: 0x1856E20 Offset: 0x1855420 VA: 0x181856E20
	public bool ImportJson(string jsonString) { }

	// RVA: 0x1858120 Offset: 0x1856720 VA: 0x181858120
	private SerializedObject vIvyebnGzuBIjMrlchHahmMFNWhkA() { }

	// RVA: 0x1857860 Offset: 0x1855E60 VA: 0x181857860
	private void qnhXsdOFxIBjlwpzqxdoLZRMVpcN(SerializedObject ) { }

	// RVA: 0x1858010 Offset: 0x1856610 VA: 0x181858010
	private bool sjuAxIDbMdeGtWGwkRAZhjetkRfCb(SerializedObject ) { }
}

// Namespace: Rewired
public sealed class ControllerMapLayoutManager // TypeDefIndex: 2016
{
	// Fields
	private bool iSpOUTcntqdFdepNoohqpOjhkMqEA; // 0x10
	private bool kEpmCVuNlBVovcqODCMaKFJgHqwQ; // 0x11
	private Player lOICihhJXiCEutKjbIJAxpmYrMQoA; // 0x18
	private ControllerMapLayoutManager.KTjbTVulAczqMJpjTFfXjkUzYrtg rOCemDhPAjOtYsKgvuFgdpyUCyaDb; // 0x20
	private readonly int cZNopUvGkkeSBeTOFDbZMczrOFyab; // 0x28
	private List<ControllerMapLayoutManager.RuleSet> aitfRmipmVVaNdEsgCkMxCBDLomCA; // 0x30
	private Action rkrCwqgwlbKXYmjfVegXbyRMKFcM; // 0x38

	// Properties
	public bool enabled { get; set; }
	public bool loadFromUserDataStore { get; set; }
	public List<ControllerMapLayoutManager.RuleSet> ruleSets { get; set; }

	// Methods

	// RVA: 0x18581A0 Offset: 0x18567A0 VA: 0x1818581A0
	internal void AMNzUAzuGtoTYQtLTQvGsPgeEZPF(Action ) { }

	// RVA: 0x1859330 Offset: 0x1857930 VA: 0x181859330
	internal void JxLFtFBPZrjRBBTQZZpqPRPZCJPAA(Action ) { }

	// RVA: 0x18599C0 Offset: 0x1857FC0 VA: 0x1818599C0
	internal void .ctor(Player , ControllerMapLayoutManager.KTjbTVulAczqMJpjTFfXjkUzYrtg ) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_enabled() { }

	// RVA: 0x185A290 Offset: 0x1858890 VA: 0x18185A290
	public void set_enabled(bool value) { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_loadFromUserDataStore() { }

	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_loadFromUserDataStore(bool value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<ControllerMapLayoutManager.RuleSet> get_ruleSets() { }

	// RVA: 0x185A2A0 Offset: 0x18588A0 VA: 0x18185A2A0
	public void set_ruleSets(List<ControllerMapLayoutManager.RuleSet> value) { }

	// RVA: 0x1858240 Offset: 0x1856840 VA: 0x181858240
	public void Apply() { }

	// RVA: 0x1859450 Offset: 0x1857A50 VA: 0x181859450
	public void LoadDefaults() { }

	// RVA: 0x1859830 Offset: 0x1857E30 VA: 0x181859830
	public string ToXmlString() { }

	// RVA: 0x18596A0 Offset: 0x1857CA0 VA: 0x1818596A0
	public string ToJsonString() { }

	// RVA: 0x1859180 Offset: 0x1857780 VA: 0x181859180
	public bool ImportXml(string xmlString) { }

	// RVA: 0x1858FD0 Offset: 0x18575D0 VA: 0x181858FD0
	public bool ImportJson(string jsonString) { }

	// RVA: 0x18593D0 Offset: 0x18579D0 VA: 0x1818593D0
	private SerializedObject LgOSLSKZbqLuLAkElQTWsAIQhDVIA() { }

	// RVA: 0x1859B40 Offset: 0x1858140 VA: 0x181859B40
	private void rdEIsFhqdvORKNcPwOEwfakOngcuA(SerializedObject ) { }

	// RVA: 0x1858E90 Offset: 0x1857490 VA: 0x181858E90
	private bool BEdXmxWZnuTPAJeVXVupcrnFBTxv(SerializedObject ) { }
}

// Namespace: Rewired
public abstract class ControllerMapSaveData // TypeDefIndex: 2017
{
	// Fields
	protected Controller _controller; // 0x10
	protected ControllerMap _map; // 0x18
	internal readonly int XOiLeVzFfqCxcaMRCalNWHGKlfRt; // 0x20

	// Properties
	public ControllerMap map { get; }
	public int categoryId { get; }
	public int layoutId { get; }
	public Type mapType { get; }
	public string mapTypeString { get; }
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public string controllerHardwareIdentifier { get; }

	// Methods

	// RVA: 0x185AB60 Offset: 0x1859160 VA: 0x18185AB60
	public ControllerMap get_map() { }

	// RVA: 0x185A6F0 Offset: 0x1858CF0 VA: 0x18185A6F0
	public int get_categoryId() { }

	// RVA: 0x185A970 Offset: 0x1858F70 VA: 0x18185A970
	public int get_layoutId() { }

	// RVA: 0x185AAC0 Offset: 0x18590C0 VA: 0x18185AAC0
	public Type get_mapType() { }

	// RVA: 0x185AA10 Offset: 0x1859010 VA: 0x18185AA10
	public string get_mapTypeString() { }

	// RVA: 0x185A8E0 Offset: 0x1858EE0 VA: 0x18185A8E0
	public Controller get_controller() { }

	// RVA: 0x185A840 Offset: 0x1858E40 VA: 0x18185A840
	public ControllerType get_controllerType() { }

	// RVA: 0x185A790 Offset: 0x1858D90 VA: 0x18185A790
	public string get_controllerHardwareIdentifier() { }

	// RVA: -1 Offset: -1
	public T GetMap<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC370 Offset: 0x6BA970 VA: 0x1806BC370
	|-ControllerMapSaveData.GetMap<object>
	*/

	// RVA: 0x185A620 Offset: 0x1858C20 VA: 0x18185A620
	internal void .ctor(Controller , ControllerMap ) { }

	// RVA: -1 Offset: -1
	internal static  CYqguBimmlgEednsbvaIByFBKqPtb<>(Controller , ControllerMap ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC2E0 Offset: 0x6BA8E0 VA: 0x1806BC2E0
	|-ControllerMapSaveData.CYqguBimmlgEednsbvaIByFBKqPtb<object>
	*/

	// RVA: 0x185A320 Offset: 0x1858920 VA: 0x18185A320
	internal static ControllerMapSaveData CYqguBimmlgEednsbvaIByFBKqPtb(Controller , ControllerMap ) { }
}

// Namespace: Rewired
public sealed class KeyboardMapSaveData : ControllerMapSaveData // TypeDefIndex: 2018
{
	// Properties
	public KeyboardMap keyboardMap { get; }

	// Methods

	// RVA: 0x186AF40 Offset: 0x1869540 VA: 0x18186AF40
	public KeyboardMap get_keyboardMap() { }

	// RVA: 0x186A910 Offset: 0x1868F10 VA: 0x18186A910
	internal void .ctor(Keyboard , KeyboardMap ) { }
}

// Namespace: Rewired
public sealed class MouseMapSaveData : ControllerMapSaveData // TypeDefIndex: 2019
{
	// Properties
	public MouseMap keyboardMap { get; }

	// Methods

	// RVA: 0x186AFF0 Offset: 0x18695F0 VA: 0x18186AFF0
	public MouseMap get_keyboardMap() { }

	// RVA: 0x186A910 Offset: 0x1868F10 VA: 0x18186A910
	internal void .ctor(Mouse , MouseMap ) { }
}

// Namespace: Rewired
public sealed class JoystickMapSaveData : ControllerMapSaveData // TypeDefIndex: 2020
{
	// Properties
	public Joystick joystick { get; }
	public JoystickMap joystickMap { get; }
	public Guid joystickHardwareTypeGuid { get; }

	// Methods

	// RVA: 0x186AE00 Offset: 0x1869400 VA: 0x18186AE00
	public Joystick get_joystick() { }

	// RVA: 0x186AD50 Offset: 0x1869350 VA: 0x18186AD50
	public JoystickMap get_joystickMap() { }

	// RVA: 0x186ABB0 Offset: 0x18691B0 VA: 0x18186ABB0
	public Guid get_joystickHardwareTypeGuid() { }

	// RVA: 0x186A910 Offset: 0x1868F10 VA: 0x18186A910
	internal void .ctor(Joystick , JoystickMap ) { }
}

// Namespace: Rewired
public sealed class CustomControllerMapSaveData : ControllerMapSaveData // TypeDefIndex: 2021
{
	// Properties
	public CustomController customController { get; }
	public CustomControllerMap customControllerMap { get; }
	public int customControllerSourceId { get; }

	// Methods

	// RVA: 0x186AB00 Offset: 0x1869100 VA: 0x18186AB00
	public CustomController get_customController() { }

	// RVA: 0x186A920 Offset: 0x1868F20 VA: 0x18186A920
	public CustomControllerMap get_customControllerMap() { }

	// RVA: 0x186A9D0 Offset: 0x1868FD0 VA: 0x18186A9D0
	public int get_customControllerSourceId() { }

	// RVA: 0x186A910 Offset: 0x1868F10 VA: 0x18186A910
	internal void .ctor(CustomController , CustomControllerMap ) { }
}

// Namespace: Rewired
public abstract class ControllerMap // TypeDefIndex: 2030
{
	// Fields
	protected int _id; // 0x10
	protected int _sourceMapId; // 0x14
	protected int _categoryId; // 0x18
	protected int _layoutId; // 0x1C
	protected string _name; // 0x20
	protected Guid _hardwareGuid; // 0x28
	protected bool _enabled; // 0x38
	internal readonly int dRMmizzgnmnwnHSdOiFnVuHUAhoi; // 0x3C
	private double aAqMFzQvBZAfLshMVjDDgRsErEO; // 0x40
	private readonly AList<ActionElementMap> PAtfnBaSOCZKuhQXJrZzXkwNEZys; // 0x48
	private readonly ReadOnlyCollection<ActionElementMap> GlOygIaHqUTxyTFMuJgjFVSzkZIG; // 0x50
	private readonly AList<ActionElementMap> oShxHdMwfNFwimcEViiCVKmwQtNe; // 0x58
	private readonly ReadOnlyCollection<ActionElementMap> vXipTfTsbKwUDTUzqrPDpJRrHyqD; // 0x60
	protected int _playerId; // 0x68
	protected int _controllerId; // 0x6C
	protected ControllerType _controllerType; // 0x70
	private static int HYccNlHflnNMwdmocbNYQeYtpPgyB; // 0x0
	private static int UBBgnKEKilhSgenHhGPbSnvFOrny; // 0x4

	// Properties
	private static int OutIQFjSMXkFTozLDpkJfjGzetrr { get; }
	internal static bool yPosDcWqJChlxVslDtmVQdvmPegA { get; }
	public int id { get; }
	public int sourceMapId { get; set; }
	public int categoryId { get; set; }
	public int layoutId { get; set; }
	public string name { get; set; }
	public Guid hardwareGuid { get; set; }
	public bool enabled { get; set; }
	public int playerId { get; set; }
	public int controllerId { get; set; }
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public Player player { get; }
	public int elementMapCount { get; }
	public int buttonMapCount { get; }
	public IList<ActionElementMap> AllMaps { get; }
	public IList<ActionElementMap> ElementMaps { get; }
	public IList<ActionElementMap> ButtonMaps { get; }
	public double modifiedTime { get; }
	public bool isModified { get; set; }
	internal AList<ActionElementMap> BhSDEREYHPLsJoVVCJzvBDqkVOEWb { get; }

	// Methods

	// RVA: 0x1862EB0 Offset: 0x18614B0 VA: 0x181862EB0
	private static int MeFhIafJrrqtRExzSxcdfjogxiGOB() { }

	// RVA: 0x1862F10 Offset: 0x1861510 VA: 0x181862F10
	internal static bool MwdeFSfqBGQAgnDmycQDHmkzSNPNA() { }

	// RVA: 0x1865500 Offset: 0x1863B00 VA: 0x181865500
	public void .ctor() { }

	// RVA: 0x1865710 Offset: 0x1863D10 VA: 0x181865710
	public void .ctor(ControllerMap ) { }

	// RVA: 0x1866750 Offset: 0x1864D50 VA: 0x181866750
	public int get_id() { }

	// RVA: 0x1866C20 Offset: 0x1865220 VA: 0x181866C20
	public int get_sourceMapId() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	internal void maWhjOgNUyTKZoCjVLqfSTFuHrzDb(int ) { }

	// RVA: 0x18662F0 Offset: 0x18648F0 VA: 0x1818662F0
	public int get_categoryId() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	internal void JDNHrEblmtaERDJxgCLDBqDTYGASA(int ) { }

	// RVA: 0x18668C0 Offset: 0x1864EC0 VA: 0x1818668C0
	public int get_layoutId() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	internal void uoGDYLiOBWgeBgDWDylOZTKnbjLQA(int ) { }

	// RVA: 0x1866A40 Offset: 0x1865040 VA: 0x181866A40
	public string get_name() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void uwrQEvGHkwgbEZtUYYiUwRwMhpxo(string ) { }

	// RVA: 0x1866690 Offset: 0x1864C90 VA: 0x181866690
	public Guid get_hardwareGuid() { }

	// RVA: 0x14DAB40 Offset: 0x14D9140 VA: 0x1814DAB40
	internal void BdzbsYgtcJEyZWjclDEvAedjzNdz(Guid ) { }

	// RVA: 0x1866600 Offset: 0x1864C00 VA: 0x181866600
	public bool get_enabled() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_enabled(bool value) { }

	// RVA: 0x1866AE0 Offset: 0x18650E0 VA: 0x181866AE0
	public int get_playerId() { }

	// RVA: 0xC9D9F0 Offset: 0xC9BFF0 VA: 0x180C9D9F0
	internal void NAOUwhcQiCIOmsXHdBrOJoyVVKAs(int ) { }

	// RVA: 0x1866380 Offset: 0x1864980 VA: 0x181866380
	public int get_controllerId() { }

	// RVA: 0xC9D7A0 Offset: 0xC9BDA0 VA: 0x180C9D7A0
	internal void gWuBjpFTiPyfNCowvPBryOwUjLdJ(int ) { }

	// RVA: 0x18664A0 Offset: 0x1864AA0 VA: 0x1818664A0
	public Controller get_controller() { }

	// RVA: 0x1866410 Offset: 0x1864A10 VA: 0x181866410
	public ControllerType get_controllerType() { }

	// RVA: 0x1866B70 Offset: 0x1865170 VA: 0x181866B70
	public Player get_player() { }

	// RVA: 0x1866560 Offset: 0x1864B60 VA: 0x181866560
	public int get_elementMapCount() { }

	// RVA: 0x1866250 Offset: 0x1864850 VA: 0x181866250
	public int get_buttonMapCount() { }

	// RVA: 0x1866070 Offset: 0x1864670 VA: 0x181866070
	public IList<ActionElementMap> get_AllMaps() { }

	// RVA: 0x18661B0 Offset: 0x18647B0 VA: 0x1818661B0
	public IList<ActionElementMap> get_ElementMaps() { }

	// RVA: 0x1866110 Offset: 0x1864710 VA: 0x181866110
	public IList<ActionElementMap> get_ButtonMaps() { }

	// RVA: 0x1866950 Offset: 0x1864F50 VA: 0x181866950
	public double get_modifiedTime() { }

	// RVA: 0x18667E0 Offset: 0x1864DE0 VA: 0x1818667E0
	public bool get_isModified() { }

	// RVA: 0x1868070 Offset: 0x1866670 VA: 0x181868070
	public void set_isModified(bool value) { }

	// RVA: 0x185B290 Offset: 0x1859890 VA: 0x18185B290
	public bool ContainsAction(string actionName) { }

	// RVA: 0x185B390 Offset: 0x1859990 VA: 0x18185B390 Slot: 4
	public virtual bool ContainsAction(int actionId) { }

	// RVA: 0x185B4A0 Offset: 0x1859AA0 VA: 0x18185B4A0
	public bool ContainsElementIdentifier(int elementIdentifierId) { }

	// RVA: 0x185B7D0 Offset: 0x1859DD0 VA: 0x18185B7D0
	public bool ContainsKeyboardKey(KeyCode keyCode, ModifierKeyFlags modifierKeys) { }

	// RVA: 0x185B5B0 Offset: 0x1859BB0 VA: 0x18185B5B0
	public bool ContainsElementMap(ActionElementMap elementMap) { }

	// RVA: 0x185B6C0 Offset: 0x1859CC0 VA: 0x18185B6C0
	public bool ContainsElementMap(int elementMapId) { }

	// RVA: 0x1864250 Offset: 0x1862850 VA: 0x181864250
	public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment) { }

	// RVA: 0x18643F0 Offset: 0x18629F0 VA: 0x1818643F0
	public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result) { }

	// RVA: 0x185BAE0 Offset: 0x185A0E0 VA: 0x18185BAE0
	public bool CreateElementMap(ElementAssignment elementAssignment) { }

	// RVA: 0x185BD20 Offset: 0x185A320 VA: 0x18185BD20
	public bool CreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result) { }

	// RVA: 0x185BCD0 Offset: 0x185A2D0 VA: 0x18185BCD0
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3) { }

	// RVA: 0x185B930 Offset: 0x1859F30 VA: 0x18185B930
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result) { }

	// RVA: 0x185C090 Offset: 0x185A690 VA: 0x18185C090
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags) { }

	// RVA: 0x185BBB0 Offset: 0x185A1B0 VA: 0x18185BBB0
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result) { }

	// RVA: 0x185C030 Offset: 0x185A630 VA: 0x18185C030
	public bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert) { }

	// RVA: 0x185BEE0 Offset: 0x185A4E0 VA: 0x18185BEE0 Slot: 5
	public virtual bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x1863A50 Offset: 0x1862050 VA: 0x181863A50
	public bool ReplaceElementMap(ElementAssignment elementAssignment) { }

	// RVA: 0x1863E60 Offset: 0x1862460 VA: 0x181863E60
	public bool ReplaceElementMap(ElementAssignment elementAssignment, out ActionElementMap result) { }

	// RVA: 0x1863D60 Offset: 0x1862360 VA: 0x181863D60
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3) { }

	// RVA: 0x1864050 Offset: 0x1862650 VA: 0x181864050
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result) { }

	// RVA: 0x1863A90 Offset: 0x1862090 VA: 0x181863A90
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags) { }

	// RVA: 0x1863DB0 Offset: 0x18623B0 VA: 0x181863DB0
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result) { }

	// RVA: 0x1863B40 Offset: 0x1862140 VA: 0x181863B40
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert) { }

	// RVA: 0x1863BB0 Offset: 0x18621B0 VA: 0x181863BB0 Slot: 6
	public virtual bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x185C700 Offset: 0x185AD00 VA: 0x18185C700 Slot: 7
	public virtual bool DeleteElementMap(int elementMapId) { }

	// RVA: 0x185C7C0 Offset: 0x185ADC0 VA: 0x18185C7C0 Slot: 8
	public virtual bool DeleteElementMapsWithAction(string actionName) { }

	// RVA: 0x185C860 Offset: 0x185AE60 VA: 0x18185C860 Slot: 9
	public virtual bool DeleteElementMapsWithAction(int actionId) { }

	// RVA: 0x18603A0 Offset: 0x185E9A0 VA: 0x1818603A0 Slot: 10
	public virtual ActionElementMap GetElementMap(int elementMapId) { }

	// RVA: 0x18617A0 Offset: 0x185FDA0 VA: 0x1818617A0
	public ActionElementMap[] GetElementMaps() { }

	// RVA: 0x18614B0 Offset: 0x185FAB0 VA: 0x1818614B0
	public ActionElementMap[] GetElementMaps(bool skipDisabledMaps) { }

	// RVA: 0x18618F0 Offset: 0x185FEF0 VA: 0x1818618F0
	public int GetElementMaps(List<ActionElementMap> results) { }

	// RVA: 0x18617B0 Offset: 0x185FDB0 VA: 0x1818617B0
	public int GetElementMaps(bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1860C80 Offset: 0x185F280 VA: 0x181860C80
	public ActionElementMap[] GetElementMapsWithAction(string actionName) { }

	// RVA: 0x1860600 Offset: 0x185EC00 VA: 0x181860600
	public ActionElementMap[] GetElementMapsWithAction(int actionId) { }

	// RVA: 0x1860B70 Offset: 0x185F170 VA: 0x181860B70
	public ActionElementMap[] GetElementMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1860750 Offset: 0x185ED50 VA: 0x181860750
	public ActionElementMap[] GetElementMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x18604C0 Offset: 0x185EAC0 VA: 0x1818604C0
	public int GetElementMapsWithAction(string actionName, List<ActionElementMap> results) { }

	// RVA: 0x1860720 Offset: 0x185ED20 VA: 0x181860720
	public int GetElementMapsWithAction(int actionId, List<ActionElementMap> results) { }

	// RVA: 0x1860610 Offset: 0x185EC10 VA: 0x181860610
	public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x18605D0 Offset: 0x185EBD0 VA: 0x1818605D0
	public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x185D720 Offset: 0x185BD20 VA: 0x18185D720
	public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName) { }

	// RVA: 0x185D8C0 Offset: 0x185BEC0 VA: 0x18185D8C0
	public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId) { }

	// RVA: 0x185D8D0 Offset: 0x185BED0 VA: 0x18185D8D0
	public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMap.IzIEXfaJOViFQAAqIkvQxbcaFAnOc))]
	// RVA: 0x185D820 Offset: 0x185BE20 VA: 0x18185D820
	public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x18621F0 Offset: 0x18607F0 VA: 0x1818621F0 Slot: 11
	public virtual ActionElementMap GetFirstElementMapWithAction(int actionId) { }

	// RVA: 0x1862000 Offset: 0x1860600 VA: 0x181862000 Slot: 12
	public virtual ActionElementMap GetFirstElementMapWithAction(string actionName) { }

	// RVA: 0x1861EA0 Offset: 0x18604A0 VA: 0x181861EA0 Slot: 13
	public virtual ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x18620F0 Offset: 0x18606F0 VA: 0x1818620F0
	public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x185DDA0 Offset: 0x185C3A0 VA: 0x18185DDA0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMap.GnmeXHQNyYDAXOwmrIGdEjDpinjFb))]
	// RVA: 0x185DF00 Offset: 0x185C500 VA: 0x18185DF00
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x185DFA0 Offset: 0x185C5A0 VA: 0x18185DFA0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x185DBC0 Offset: 0x185C1C0 VA: 0x18185DBC0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMap.kBrJfOUIobHXFjKjxkAaaoKYeaZz))]
	// RVA: 0x185D9E0 Offset: 0x185BFE0 VA: 0x18185D9E0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x185DAA0 Offset: 0x185C0A0 VA: 0x18185DAA0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x18625A0 Offset: 0x1860BA0 VA: 0x1818625A0
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x18623C0 Offset: 0x18609C0 VA: 0x1818623C0
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x18624B0 Offset: 0x1860AB0 VA: 0x1818624B0
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1862210 Offset: 0x1860810 VA: 0x181862210
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1862830 Offset: 0x1860E30 VA: 0x181862830
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1862730 Offset: 0x1860D30 VA: 0x181862730
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1861070 Offset: 0x185F670 VA: 0x181861070
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1860F80 Offset: 0x185F580 VA: 0x181860F80
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1860D80 Offset: 0x185F380 VA: 0x181860D80
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1861200 Offset: 0x185F800 VA: 0x181861200
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x18613C0 Offset: 0x185F9C0 VA: 0x1818613C0
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1860E70 Offset: 0x185F470 VA: 0x181860E70
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1861DF0 Offset: 0x18603F0 VA: 0x181861DF0
	public ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> predicate) { }

	// RVA: 0x1867FE0 Offset: 0x18665E0 VA: 0x181867FE0 Slot: 14
	internal virtual ActionElementMap rLbJcyULeKdBMBjrxgRkgZiimTLxA(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x18602D0 Offset: 0x185E8D0 VA: 0x1818602D0
	public int GetElementMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results) { }

	// RVA: 0x1867BA0 Offset: 0x18661A0 VA: 0x181867BA0 Slot: 15
	internal virtual int ngCVSRNYXaNMUKZrWTJzXBZXzhAT(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x185ED90 Offset: 0x185D390 VA: 0x18185ED90
	public void ForEachElementMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x185B1C0 Offset: 0x18597C0 VA: 0x18185B1C0 Slot: 16
	public virtual void ClearElementMaps() { }

	// RVA: 0x1864770 Offset: 0x1862D70 VA: 0x181864770
	public int SetAllElementMapsEnabled(bool state) { }

	// RVA: 0x185F3C0 Offset: 0x185D9C0 VA: 0x18185F3C0
	public ActionElementMap GetButtonMap(int index) { }

	// RVA: 0x185FD10 Offset: 0x185E310 VA: 0x18185FD10
	public ActionElementMap[] GetButtonMaps() { }

	// RVA: 0x185FF80 Offset: 0x185E580 VA: 0x18185FF80
	public ActionElementMap[] GetButtonMaps(bool skipDisabledMaps) { }

	// RVA: 0x185FDC0 Offset: 0x185E3C0 VA: 0x18185FDC0
	public int GetButtonMaps(bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x185F660 Offset: 0x185DC60 VA: 0x18185F660
	public ActionElementMap[] GetButtonMapsWithAction(string actionName) { }

	// RVA: 0x185F780 Offset: 0x185DD80 VA: 0x18185F780
	public ActionElementMap[] GetButtonMapsWithAction(int actionId) { }

	// RVA: 0x185F8D0 Offset: 0x185DED0 VA: 0x18185F8D0
	public ActionElementMap[] GetButtonMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x185FB00 Offset: 0x185E100 VA: 0x18185FB00
	public ActionElementMap[] GetButtonMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x185F790 Offset: 0x185DD90 VA: 0x18185F790
	public int GetButtonMapsWithAction(string actionName, List<ActionElementMap> results) { }

	// RVA: 0x185F760 Offset: 0x185DD60 VA: 0x18185F760
	public int GetButtonMapsWithAction(int actionId, List<ActionElementMap> results) { }

	// RVA: 0x185F9E0 Offset: 0x185DFE0 VA: 0x18185F9E0
	public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x185F490 Offset: 0x185DA90 VA: 0x18185F490
	public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x185B110 Offset: 0x1859710 VA: 0x18185B110
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId) { }

	// RVA: 0x185AF00 Offset: 0x1859500 VA: 0x18185AF00
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName) { }

	[IteratorStateMachine(typeof(ControllerMap.GKRLyOwpCPvQiJnRByDnavDKkDmE))]
	// RVA: 0x185B120 Offset: 0x1859720 VA: 0x18185B120
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x185B000 Offset: 0x1859600 VA: 0x18185B000
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1861C00 Offset: 0x1860200 VA: 0x181861C00
	public ActionElementMap GetFirstButtonMapWithAction(int actionId) { }

	// RVA: 0x1861D10 Offset: 0x1860310 VA: 0x181861D10
	public ActionElementMap GetFirstButtonMapWithAction(string actionName) { }

	// RVA: 0x1861AD0 Offset: 0x18600D0 VA: 0x181861AD0
	public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1861C10 Offset: 0x1860210 VA: 0x181861C10
	public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1861A20 Offset: 0x1860020 VA: 0x181861A20
	public ActionElementMap GetFirstButtonMapMatch(Predicate<ActionElementMap> predicate) { }

	// RVA: 0x185E0A0 Offset: 0x185C6A0 VA: 0x18185E0A0
	internal ActionElementMap FfDDsdeAMAfeTrBlUtkXiYEIQKJP(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x185F2F0 Offset: 0x185D8F0 VA: 0x18185F2F0
	public int GetButtonMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results) { }

	// RVA: 0x185EFB0 Offset: 0x185D5B0 VA: 0x18185EFB0
	internal int GDEhJgChEEMOtgUJGLrhnFKawlvbc(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x185E280 Offset: 0x185C880 VA: 0x18185E280
	public void ForEachButtonMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x185C550 Offset: 0x185AB50 VA: 0x18185C550
	public bool DeleteButtonMapsWithAction(string actionName) { }

	// RVA: 0x185C5E0 Offset: 0x185ABE0 VA: 0x18185C5E0
	public bool DeleteButtonMapsWithAction(int actionId) { }

	// RVA: 0x1864650 Offset: 0x1862C50 VA: 0x181864650
	public int SetAllButtonMapsEnabled(bool state) { }

	// RVA: 0x185D360 Offset: 0x185B960 VA: 0x18185D360
	public bool DoesElementAssignmentConflict(ControllerMap controllerMap) { }

	// RVA: 0x185D120 Offset: 0x185B720 VA: 0x18185D120
	public bool DoesElementAssignmentConflict(ActionElementMap actionElementMap) { }

	// RVA: 0x185CDA0 Offset: 0x185B3A0 VA: 0x18185CDA0
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x185D140 Offset: 0x185B740 VA: 0x18185D140 Slot: 17
	public virtual bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x185CDF0 Offset: 0x185B3F0 VA: 0x18185CDF0 Slot: 18
	public virtual bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x185CF50 Offset: 0x185B550 VA: 0x18185CF50 Slot: 19
	public virtual bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x185D570 Offset: 0x185BB70 VA: 0x18185D570
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap) { }

	// RVA: 0x1453C30 Offset: 0x1452230 VA: 0x181453C30
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap) { }

	// RVA: 0x185D590 Offset: 0x185BB90 VA: 0x18185D590
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	[IteratorStateMachine(typeof(ControllerMap.BewOBcekDdWGwAexOgSHaQoGHCWz))]
	// RVA: 0x185D5E0 Offset: 0x185BBE0 VA: 0x18185D5E0 Slot: 20
	public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMap.OorHiJkOKIFuxaRBGJNkUxKXsDj))]
	// RVA: 0x185D680 Offset: 0x185BC80 VA: 0x18185D680 Slot: 21
	public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMap.mpQgGFDffgTUSQDEAfocUijFDXZY))]
	// RVA: 0x185D4B0 Offset: 0x185BAB0 VA: 0x18185D4B0 Slot: 22
	public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1863370 Offset: 0x1861970 VA: 0x181863370
	public int RemoveElementAssignmentConflicts(ControllerMap controllerMap) { }

	// RVA: 0x1863860 Offset: 0x1861E60 VA: 0x181863860
	public int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap) { }

	// RVA: 0x1863320 Offset: 0x1861920 VA: 0x181863320
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1863390 Offset: 0x1861990 VA: 0x181863390 Slot: 23
	public virtual int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1863880 Offset: 0x1861E80 VA: 0x181863880 Slot: 24
	public virtual int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1863610 Offset: 0x1861C10 VA: 0x181863610 Slot: 25
	public virtual int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x185CB20 Offset: 0x185B120 VA: 0x18185CB20
	public int DisableElementAssignmentConflicts(ControllerMap controllerMap) { }

	// RVA: 0x185C870 Offset: 0x185AE70 VA: 0x18185C870
	public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap) { }

	// RVA: 0x185C930 Offset: 0x185AF30 VA: 0x18185C930
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x185CCC0 Offset: 0x185B2C0 VA: 0x18185CCC0
	public int DisableElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x185CBE0 Offset: 0x185B1E0 VA: 0x18185CBE0
	public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x185CA20 Offset: 0x185B020 VA: 0x18185CA20
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1865AE0 Offset: 0x18640E0 VA: 0x181865AE0 Slot: 26
	internal virtual int aoXZaMAsMyKkTlKlPczDBePLjZXi(ControllerMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1865940 Offset: 0x1863F40 VA: 0x181865940 Slot: 27
	internal virtual int aUeNFmSHdvdDmPhHgYpnJmgHKzRC(ActionElementMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x18650F0 Offset: 0x18636F0 VA: 0x1818650F0 Slot: 28
	internal virtual int UGtsxUacvWvGOshSVFQObiGFXjh(ElementAssignmentConflictCheck , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x185E4F0 Offset: 0x185CAF0 VA: 0x18185E4F0
	public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x185E830 Offset: 0x185CE30 VA: 0x18185E830
	public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x185E4A0 Offset: 0x185CAA0 VA: 0x18185E4A0
	public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x185E510 Offset: 0x185CB10 VA: 0x18185E510
	public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps) { }

	// RVA: 0x185EB30 Offset: 0x185D130 VA: 0x18185EB30
	public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps) { }

	// RVA: 0x185E850 Offset: 0x185CE50 VA: 0x18185E850
	public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps) { }

	// RVA: 0x1860140 Offset: 0x185E740 VA: 0x181860140
	public string[] GetButtonNames() { }

	// RVA: 0x1864EC0 Offset: 0x18634C0 VA: 0x181864EC0
	public string ToXmlString() { }

	// RVA: 0x1864D30 Offset: 0x1863330 VA: 0x181864D30
	public string ToJsonString() { }

	// RVA: 0x18648A0 Offset: 0x1862EA0 VA: 0x1818648A0
	public ControllerTemplateMap ToControllerTemplateMap(Guid templateTypeGuid) { }

	// RVA: -1 Offset: -1
	public ControllerTemplateMap ToControllerTemplateMap<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC430 Offset: 0x6BAA30 VA: 0x1806BC430
	|-ControllerMap.ToControllerTemplateMap<object>
	*/

	// RVA: 0x1864AD0 Offset: 0x18630D0 VA: 0x181864AD0
	public ControllerTemplateMap ToControllerTemplateMap(Type templateInterfaceType) { }

	// RVA: 0x185C460 Offset: 0x185AA60 VA: 0x18185C460
	private ControllerTemplateMap DKDowpuxnqoVcGDDupbAoHlCikfW(IControllerTemplate ) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal AList<ActionElementMap> JAktBWAbcbGIcdZILCcPhpUnntPOA() { }

	// RVA: 0x185AC90 Offset: 0x1859290 VA: 0x18185AC90 Slot: 29
	internal virtual bool AkyDVhhmorcjyjgrhwVUicdhusts(ActionElementMap ) { }

	// RVA: 0x1867BC0 Offset: 0x18661C0 VA: 0x181867BC0 Slot: 30
	internal virtual int oFZZczUhhRNQrXKnNGGpgnGSLiiMA(List<ActionElementMap> , bool ) { }

	// RVA: 0x1862E10 Offset: 0x1861410 VA: 0x181862E10 Slot: 31
	internal virtual ActionElementMap LwhYSWMSbQRQxdnwSeOXkVnCJGFeb(int , int , ControllerElementType ) { }

	// RVA: 0x1866EF0 Offset: 0x18654F0 VA: 0x181866EF0 Slot: 32
	internal virtual int kDQHsoEySPLmSQYCaBFimStqqBCf(int , List<ActionElementMap> , bool ) { }

	// RVA: 0x18684B0 Offset: 0x1866AB0 VA: 0x1818684B0 Slot: 33
	internal virtual bool zjKWWkxXFMogYuUUCOKoGmZurAZg(int , int , ControllerElementType ) { }

	// RVA: 0x1866CB0 Offset: 0x18652B0 VA: 0x181866CB0 Slot: 34
	internal virtual int hUnaQQVeGwtmhuDSuyqMJKPhdpuEA(int , int , ControllerElementType ) { }

	// RVA: 0x185ABF0 Offset: 0x18591F0 VA: 0x18185ABF0
	internal int AeFGTaixiOCwxuHCRjOTucGRBnnQ(int ) { }

	// RVA: 0x1866D90 Offset: 0x1865390 VA: 0x181866D90
	internal int iKqCHqbeQSNaAPfzPNhtbOzERjcEA(bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1868170 Offset: 0x1866770 VA: 0x181868170
	internal int wCybelTicqOSEzQAmdsKOmZjgWJbA(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1862A10 Offset: 0x1861010 VA: 0x181862A10 Slot: 35
	internal virtual int IxkiEkdsHQdqyserTHYzhCksksEN(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1865300 Offset: 0x1863900 VA: 0x181865300 Slot: 36
	internal virtual ActionElementMap ZBEhgohJMwBrDQCNizbHcnXwiVGQA(IControllerElementTarget , bool , int , bool , out bool ) { }

	// RVA: 0x1867D20 Offset: 0x1866320 VA: 0x181867D20 Slot: 37
	internal virtual int qXuBObcscRnUKRBVRQMIAMdLJkhH(IControllerElementTarget , bool , int , bool , List<ActionElementMap> , bool , out bool ) { }

	// RVA: 0x185AD60 Offset: 0x1859360 VA: 0x18185AD60
	internal void BfFgDcvAiEArSDNdTGLpwwMecAWh(int , ControllerElementType ) { }

	// RVA: 0x1862910 Offset: 0x1860F10 VA: 0x181862910 Slot: 38
	internal virtual bool HMUIdxoLfQQeZxoFcHJNJyaSswrA(ActionElementMap ) { }

	// RVA: 0x185F270 Offset: 0x185D870 VA: 0x18185F270
	internal bool GDOjvKfoubKiTAMgvSvusNYOjKCU(IControllerElementTarget ) { }

	// RVA: 0x185D380 Offset: 0x185B980 VA: 0x18185D380
	internal bool EIJJysaEHSIvTEfAXaymCxopqrsfA(string ) { }

	// RVA: 0x1868380 Offset: 0x1866980 VA: 0x181868380
	internal bool zXCbdexyxdffzkXuxFEJbnvTnJwM(string ) { }

	// RVA: 0x1865050 Offset: 0x1863650 VA: 0x181865050
	internal void TobsDqkGBPRLenxWjlEFXeBlOEVp(ActionElementMap ) { }

	// RVA: 0x18645E0 Offset: 0x1862BE0 VA: 0x1818645E0
	internal void RnxhZreiFlPWnLMRFXPmveFeiclN(int ) { }

	// RVA: 0x1865E80 Offset: 0x1864480 VA: 0x181865E80
	internal void fEhDOOnsTuDweFIEyFShTVkPveCrA(int , ActionElementMap ) { }

	// RVA: 0x1862990 Offset: 0x1860F90 VA: 0x181862990
	internal static void HZaoGwjEtiLGTnBUdzsiPzAiaDVO(ActionElementMap , int , Pole , int , ControllerElementType , AxisRange , bool ) { }

	// RVA: 0x185ACC0 Offset: 0x18592C0 VA: 0x18185ACC0
	protected void BakeElementMap(ActionElementMap map) { }

	// RVA: 0x1862F50 Offset: 0x1861550 VA: 0x181862F50 Slot: 39
	internal virtual bool OIkQeIQDADIttnGcesnqKpaDJBoM(SerializedObject ) { }

	// RVA: 0x1867080 Offset: 0x1865680 VA: 0x181867080 Slot: 40
	internal virtual void loxdZQRAfhCcXEBeBrDgvroKdgoM(SerializedObject ) { }

	// RVA: 0x1864890 Offset: 0x1862E90 VA: 0x181864890
	private bool SxNAhsqMumFXMIwgkywrhdAApNKt(ControllerElementType ) { }

	// RVA: 0x1864520 Offset: 0x1862B20 VA: 0x181864520
	private void RiPUjUQtMqjQQOeoCBzFiDXoTwsEA(int , int ) { }

	// RVA: 0x185ADF0 Offset: 0x18593F0 VA: 0x18185ADF0
	private void BppucAyJhVbktSqysyeteATHfOet(ActionElementMap ) { }

	// RVA: 0x1865D30 Offset: 0x1864330 VA: 0x181865D30
	private void cAjkgYyOdJHWzYwpryzhUcPrHZKJ(ActionElementMap , int ) { }

	// RVA: 0x1862D70 Offset: 0x1861370 VA: 0x181862D70
	private int KDstejvaPMVhtVeomXKVNHtftjJx(int ) { }

	// RVA: 0x18682F0 Offset: 0x18668F0 VA: 0x1818682F0
	private SerializedObject zVBBrEGxMiinTkEeLhKjzYsznLjF() { }

	// RVA: 0x18632A0 Offset: 0x18618A0 VA: 0x1818632A0
	internal void QROyKGcduyOHDypwPgHTQUbOdOgd() { }

	// RVA: 0x185C280 Offset: 0x185A880 VA: 0x18185C280
	public static ControllerMap Create(Controller controller, int categoryId, int layoutId) { }

	// RVA: 0x1865F40 Offset: 0x1864540 VA: 0x181865F40
	internal static ControllerMap fTWdnDHHNRhjeOTEmgwODxlqDVarA(ControllerType ) { }

	// RVA: 0x1862B90 Offset: 0x1861190 VA: 0x181862B90
	internal static ControllerMap KDdENBeZFBKLEHBoAkDqUpHkOTtK(Controller , int , int ) { }

	// RVA: 0x185C1A0 Offset: 0x185A7A0 VA: 0x18185C1A0
	public static ControllerMap CreateFromXml(ControllerType controllerType, string xmlString) { }

	// RVA: 0x185C0C0 Offset: 0x185A6C0 VA: 0x18185C0C0
	public static ControllerMap CreateFromJson(ControllerType controllerType, string jsonString) { }

	// RVA: 0x185AEC0 Offset: 0x18594C0 VA: 0x18185AEC0
	internal static void BqkNUJVHHRBTpjVmrGqOMwgCopHK() { }

	// RVA: 0x1867FF0 Offset: 0x18665F0 VA: 0x181867FF0
	internal static void sWQdEwGesOcrgvmQELzpawfcvSYwb() { }
}

// Namespace: Rewired
public abstract class ControllerMapWithAxes : ControllerMap // TypeDefIndex: 2035
{
	// Fields
	private readonly IList<ActionElementMap> ZSlaexfWuZythUEQuezCYdndxbrh; // 0x78
	private readonly ReadOnlyCollection<ActionElementMap> tlhQwIHsnqwnbqkbdqbngAexrxIK; // 0x80

	// Properties
	public int axisMapCount { get; }
	public IList<ActionElementMap> AxisMaps { get; }
	internal AList<ActionElementMap> nisECcTmdnqdhoPtgkQnZJqUMMaB { get; }

	// Methods

	// RVA: 0x1877920 Offset: 0x1875F20 VA: 0x181877920
	public int get_axisMapCount() { }

	// RVA: 0x1877880 Offset: 0x1875E80 VA: 0x181877880
	public IList<ActionElementMap> get_AxisMaps() { }

	// RVA: 0x1877700 Offset: 0x1875D00 VA: 0x181877700
	public void .ctor() { }

	// RVA: 0x1877490 Offset: 0x1875A90 VA: 0x181877490
	public void .ctor(ControllerMapWithAxes ) { }

	// RVA: 0x1872F10 Offset: 0x1871510 VA: 0x181872F10 Slot: 4
	public override bool ContainsAction(int actionId) { }

	// RVA: 0x1873040 Offset: 0x1871640 VA: 0x181873040 Slot: 5
	public override bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x1876C40 Offset: 0x1875240 VA: 0x181876C40 Slot: 6
	public override bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x18734D0 Offset: 0x1871AD0 VA: 0x1818734D0 Slot: 7
	public override bool DeleteElementMap(int elementMapId) { }

	// RVA: 0x1873660 Offset: 0x1871C60 VA: 0x181873660 Slot: 8
	public override bool DeleteElementMapsWithAction(string actionName) { }

	// RVA: 0x18735A0 Offset: 0x1871BA0 VA: 0x1818735A0 Slot: 9
	public override bool DeleteElementMapsWithAction(int actionId) { }

	// RVA: 0x1875780 Offset: 0x1873D80 VA: 0x181875780 Slot: 10
	public override ActionElementMap GetElementMap(int elementMapId) { }

	// RVA: 0x18621F0 Offset: 0x18607F0 VA: 0x1818621F0 Slot: 11
	public override ActionElementMap GetFirstElementMapWithAction(int actionId) { }

	// RVA: 0x1875DF0 Offset: 0x18743F0 VA: 0x181875DF0 Slot: 13
	public override ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x18770E0 Offset: 0x18756E0 VA: 0x1818770E0 Slot: 14
	internal override ActionElementMap SUJBuMjtzKpPEHkQHSvIcALXCPrB(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x18763F0 Offset: 0x18749F0 VA: 0x1818763F0 Slot: 15
	internal override int RXjQrWUqNKXQMrbpzywSgVjcTqvR(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1872E50 Offset: 0x1871450 VA: 0x181872E50 Slot: 16
	public override void ClearElementMaps() { }

	// RVA: 0x1874850 Offset: 0x1872E50 VA: 0x181874850
	public ActionElementMap GetAxisMap(int index) { }

	// RVA: 0x18754C0 Offset: 0x1873AC0 VA: 0x1818754C0
	public ActionElementMap[] GetAxisMaps() { }

	// RVA: 0x18751B0 Offset: 0x18737B0 VA: 0x1818751B0
	public ActionElementMap[] GetAxisMaps(bool skipDisabledMaps) { }

	// RVA: 0x1875400 Offset: 0x1873A00 VA: 0x181875400
	public int GetAxisMaps(bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1874960 Offset: 0x1872F60 VA: 0x181874960
	public ActionElementMap[] GetAxisMapsWithAction(string actionName) { }

	// RVA: 0x1874E80 Offset: 0x1873480 VA: 0x181874E80
	public ActionElementMap[] GetAxisMapsWithAction(int actionId) { }

	// RVA: 0x1874FD0 Offset: 0x18735D0 VA: 0x181874FD0
	public ActionElementMap[] GetAxisMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1874A60 Offset: 0x1873060 VA: 0x181874A60
	public ActionElementMap[] GetAxisMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1874E90 Offset: 0x1873490 VA: 0x181874E90
	public int GetAxisMapsWithAction(string actionName, List<ActionElementMap> results) { }

	// RVA: 0x1874940 Offset: 0x1872F40 VA: 0x181874940
	public int GetAxisMapsWithAction(int actionId, List<ActionElementMap> results) { }

	// RVA: 0x1874D60 Offset: 0x1873360 VA: 0x181874D60
	public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x18750E0 Offset: 0x18736E0 VA: 0x1818750E0
	public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1872CB0 Offset: 0x18712B0 VA: 0x181872CB0
	public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName) { }

	// RVA: 0x1872CA0 Offset: 0x18712A0 VA: 0x181872CA0
	public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId) { }

	// RVA: 0x1872C00 Offset: 0x1871200 VA: 0x181872C00
	public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMapWithAxes.bWxtaXwqdtnoClToADDlKmREUuhp))]
	// RVA: 0x1872DB0 Offset: 0x18713B0 VA: 0x181872DB0
	public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1875990 Offset: 0x1873F90 VA: 0x181875990
	public ActionElementMap GetFirstAxisMapWithAction(int actionId) { }

	// RVA: 0x1875CA0 Offset: 0x18742A0 VA: 0x181875CA0
	public ActionElementMap GetFirstAxisMapWithAction(string actionName) { }

	// RVA: 0x1875B40 Offset: 0x1874140 VA: 0x181875B40
	public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1875A40 Offset: 0x1874040 VA: 0x181875A40
	public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x18758E0 Offset: 0x1873EE0 VA: 0x1818758E0
	public ActionElementMap GetFirstAxisMapMatch(Predicate<ActionElementMap> predicate) { }

	// RVA: 0x1878960 Offset: 0x1876F60 VA: 0x181878960
	internal ActionElementMap yTVNFZZHXWXjRigUhZTDmMPGOpec(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x1874780 Offset: 0x1872D80 VA: 0x181874780
	public int GetAxisMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results) { }

	// RVA: 0x1877BA0 Offset: 0x18761A0 VA: 0x181877BA0
	internal int jheELKtvXypjybJLVRSfQjffZNAY(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1874290 Offset: 0x1872890 VA: 0x181874290
	public void ForEachAxisMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x1873440 Offset: 0x1871A40 VA: 0x181873440
	public bool DeleteAxisMapsWithAction(string actionName) { }

	// RVA: 0x1873240 Offset: 0x1871840 VA: 0x181873240
	public bool DeleteAxisMapsWithAction(int actionId) { }

	// RVA: 0x1877140 Offset: 0x1875740 VA: 0x181877140
	public int SetAllAxisMapsEnabled(bool state) { }

	// RVA: 0x18738E0 Offset: 0x1871EE0 VA: 0x1818738E0 Slot: 17
	public override bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1873750 Offset: 0x1871D50 VA: 0x181873750 Slot: 18
	public override bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1873B40 Offset: 0x1872140 VA: 0x181873B40 Slot: 19
	public override bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMapWithAxes.ntiyAZSraqsSNlmBFHOvIszJObAY))]
	// RVA: 0x1873EF0 Offset: 0x18724F0 VA: 0x181873EF0 Slot: 20
	public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMapWithAxes.iIfZrmQUKfnygPkoyhJgGCyXHqlU))]
	// RVA: 0x1873F90 Offset: 0x1872590 VA: 0x181873F90 Slot: 21
	public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	[IteratorStateMachine(typeof(ControllerMapWithAxes.EMUEZwkzaAyvObKLABCJsblrSNul))]
	// RVA: 0x1873E30 Offset: 0x1872430 VA: 0x181873E30 Slot: 22
	public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1876470 Offset: 0x1874A70 VA: 0x181876470 Slot: 23
	public override int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1876740 Offset: 0x1874D40 VA: 0x181876740 Slot: 24
	public override int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1876930 Offset: 0x1874F30 VA: 0x181876930 Slot: 25
	public override int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1876E60 Offset: 0x1875460 VA: 0x181876E60 Slot: 26
	internal override int ReuEOdKtXPYQtYDqOFWfQQvDVeYN(ControllerMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1878110 Offset: 0x1876710 VA: 0x181878110 Slot: 27
	internal override int pRwNSAZyekvIchMqtgoPgAsfTZJNA(ActionElementMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x18744C0 Offset: 0x1872AC0 VA: 0x1818744C0 Slot: 28
	internal override int GSSoOMxaEsBqVnJOQFvVzkwYmUDE(ElementAssignmentConflictCheck , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1875570 Offset: 0x1873B70 VA: 0x181875570
	public string[] GetAxisNames() { }

	// RVA: 0x1878420 Offset: 0x1876A20 VA: 0x181878420
	internal AList<ActionElementMap> tXCcBdjQBJAqINaBvhBGyctJfJzRA() { }

	// RVA: 0x18777F0 Offset: 0x1875DF0 VA: 0x1818777F0 Slot: 29
	internal override bool fkBXfBXAzICNgadaLoGTfQRLFvdDA(ActionElementMap ) { }

	// RVA: 0x1874160 Offset: 0x1872760 VA: 0x181874160 Slot: 30
	internal override int FnRRQJkPTyDwddUqUcJHFpmNISMq(List<ActionElementMap> , bool ) { }

	// RVA: 0x1878BF0 Offset: 0x18771F0 VA: 0x181878BF0 Slot: 31
	internal override ActionElementMap zfDhlyrKnjOYXxZOCIiKliTRocob(int , int , ControllerElementType ) { }

	// RVA: 0x18786A0 Offset: 0x1876CA0 VA: 0x1818786A0 Slot: 32
	internal override int vrlJwcRywKmxEBiuIMbxsXxDfJZI(int , List<ActionElementMap> , bool ) { }

	// RVA: 0x1878AE0 Offset: 0x18770E0 VA: 0x181878AE0 Slot: 33
	internal override bool zQKPjohhtlbpeWSUqvLtWKvqnTnn(int , int , ControllerElementType ) { }

	// RVA: 0x1878310 Offset: 0x1876910 VA: 0x181878310 Slot: 34
	internal override int tTMrGxYMWJupQhNIeVkKQqpYcVJH(int , int , ControllerElementType ) { }

	// RVA: 0x1873D80 Offset: 0x1872380 VA: 0x181873D80
	internal int EJhEBvagQxFUIHOmlbtbHqsmKOxIb(int ) { }

	// RVA: 0x18779D0 Offset: 0x1875FD0 VA: 0x1818779D0
	internal int inGgDPakGglUgPtiMXdjboZEWNBn(bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1876170 Offset: 0x1874770 VA: 0x181876170
	internal int NWmBTjzTKwTbbLfIVjNopPxKVbgt(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1877300 Offset: 0x1875900 VA: 0x181877300 Slot: 35
	internal override int UYikpIHxTCuYAdOrmKUNEVTsRdJA(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1877F50 Offset: 0x1876550 VA: 0x181877F50 Slot: 36
	internal override ActionElementMap nsdUGJihhbDOJgrEtAGIBHZEMidBc(IControllerElementTarget , bool , int , bool , out bool ) { }

	// RVA: 0x1878490 Offset: 0x1876A90 VA: 0x181878490 Slot: 37
	internal override int vJcGQIHGvMyJXCSLMOyEnSUoVuptA(IControllerElementTarget , bool , int , bool , List<ActionElementMap> , bool , out bool ) { }

	// RVA: 0x18788C0 Offset: 0x1876EC0 VA: 0x1818788C0 Slot: 38
	internal override bool wkWOYJZVDNQXuCpLHiFygeFUsAhM(ActionElementMap ) { }

	// RVA: 0x18772F0 Offset: 0x18758F0 VA: 0x1818772F0
	private bool UIrdsNpQkrqZiabfoswYCHmdjMAc(ControllerElementType ) { }

	// RVA: 0x1877E60 Offset: 0x1876460 VA: 0x181877E60
	private void lCbqryeoZUopRzojXkswBuWELHgp(int , int ) { }

	// RVA: 0x1876380 Offset: 0x1874980 VA: 0x181876380
	private void POVfnHFFkxkFXcASHxbMUwbaboAP(ActionElementMap ) { }

	// RVA: 0x1874030 Offset: 0x1872630 VA: 0x181874030
	private void FQoorUqwIQVQwJerEIkHDapsPOAp(ActionElementMap , int ) { }

	// RVA: 0x1875F40 Offset: 0x1874540 VA: 0x181875F40 Slot: 40
	internal override void IFzQpiaDMmVqYTDuafGebRsinIFy(SerializedObject ) { }

	// RVA: 0x1872A70 Offset: 0x1871070 VA: 0x181872A70 Slot: 39
	internal override bool AAjEZIBpspkTMCfcDCnrRCOeEYdl(SerializedObject ) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x18777E0 Offset: 0x1875DE0 VA: 0x1818777E0
	private IEnumerable<ElementAssignmentConflictInfo> dAlEZPFLLUeXxLSEIxepzaCxIWbdA(ControllerMap , bool ) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1877130 Offset: 0x1875730 VA: 0x181877130
	private IEnumerable<ElementAssignmentConflictInfo> SUyewvcVbnwKlqKncysnljtvTBxD(ActionElementMap , bool ) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1876130 Offset: 0x1874730 VA: 0x181876130
	private IEnumerable<ElementAssignmentConflictInfo> KdAwotvaLnxIkUXdJuazibblObiA(ElementAssignmentConflictCheck , bool ) { }
}

// Namespace: Rewired
public sealed class KeyboardMap : ControllerMap // TypeDefIndex: 2036
{
	// Methods

	// RVA: 0x18822E0 Offset: 0x18808E0 VA: 0x1818822E0
	public void .ctor() { }

	// RVA: 0x18822D0 Offset: 0x18808D0 VA: 0x1818822D0
	public void .ctor(KeyboardMap ) { }

	// RVA: 0x1882170 Offset: 0x1880770 VA: 0x181882170
	internal void otEaUAIXVotQuTVyAmnvXMeoOKKG(Guid , int , int ) { }

	// RVA: 0x1882240 Offset: 0x1880840 VA: 0x181882240
	internal static KeyboardMap LjAPFhSKUCFmPjJIyOSUwBlviqAU(Guid , int , int ) { }
}

// Namespace: Rewired
public sealed class MouseMap : ControllerMapWithAxes // TypeDefIndex: 2037
{
	// Methods

	// RVA: 0x1882390 Offset: 0x1880990 VA: 0x181882390
	public void .ctor() { }

	// RVA: 0x1882210 Offset: 0x1880810 VA: 0x181882210
	public void .ctor(MouseMap ) { }

	// RVA: 0x1882170 Offset: 0x1880770 VA: 0x181882170
	internal void LoedpRlKVSoVLGipYehzIJdnErdZA(Guid , int , int ) { }

	// RVA: 0x1882300 Offset: 0x1880900 VA: 0x181882300
	internal static MouseMap DjGwPQQXogRBJVJqFCTTKrqkwSre(Guid , int , int ) { }
}

// Namespace: Rewired
public sealed class JoystickMap : ControllerMapWithAxes // TypeDefIndex: 2038
{
	// Methods

	// RVA: 0x1882220 Offset: 0x1880820 VA: 0x181882220
	public void .ctor() { }

	// RVA: 0x1882210 Offset: 0x1880810 VA: 0x181882210
	public void .ctor(JoystickMap ) { }

	// RVA: 0x1882170 Offset: 0x1880770 VA: 0x181882170
	internal void JhdMuBjbsmOdGXXftTEfiexhEsHdA(Guid , int , int ) { }

	// RVA: 0x1882180 Offset: 0x1880780 VA: 0x181882180
	internal static JoystickMap XSfjLQAzZeqOnuYiXNYjvKZITAFo(Guid , int , int ) { }
}

// Namespace: Rewired
public sealed class CustomControllerMap : ControllerMapWithAxes // TypeDefIndex: 2039
{
	// Fields
	private int dxStOHlBLPgbTiRYpNFOKisseXVk; // 0x88

	// Properties
	public int sourceControllerId { get; set; }

	// Methods

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90
	public int get_sourceControllerId() { }

	// RVA: 0x3AAD20 Offset: 0x3A9320 VA: 0x1803AAD20
	public void set_sourceControllerId(int value) { }

	// RVA: 0x1878DB0 Offset: 0x18773B0 VA: 0x181878DB0
	public void .ctor() { }

	// RVA: 0x1878D70 Offset: 0x1877370 VA: 0x181878D70
	public void .ctor(CustomControllerMap ) { }

	// RVA: 0x1878CB0 Offset: 0x18772B0 VA: 0x181878CB0
	internal void HccITMkNbbidRixhpWwDcykEVvlJc(Guid , int , int , int ) { }

	// RVA: 0x1878CD0 Offset: 0x18772D0 VA: 0x181878CD0
	internal static CustomControllerMap IYDkfqdEkyWQoHOnBkYNRVhdLzCH(Guid , int , int , int ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class HardwareControllerMap_Game // TypeDefIndex: 2045
{
	// Fields
	public readonly string controllerName; // 0x10
	public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; // 0x18
	public readonly int customControllerSourceId; // 0x34
	public readonly ADictionary<int, ControllerElementIdentifier> elementIdentifiers; // 0x38
	public readonly ControllerElementIdentifier[] elementIdentifiers_cache; // 0x40
	public readonly ControllerElementIdentifier[] buttonElementIdentifiers_cache; // 0x48
	public readonly ControllerElementIdentifier[] axisElementIdentifiers_cache; // 0x50
	public readonly ControllerElementIdentifier[] axis2DElementIdentifiers_cache; // 0x58
	public readonly ControllerElementIdentifier[] hatElementIdentifiers_cache; // 0x60
	public readonly ControllerElementIdentifier[] dpadElementIdentifiers_cache; // 0x68
	public readonly IList<ControllerElementIdentifier> elementIdentifiers_readOnly; // 0x70
	public readonly IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly; // 0x78
	public readonly IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly; // 0x80
	public readonly IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly; // 0x88
	public readonly IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly; // 0x90
	public readonly IList<ControllerElementIdentifier> dpadElementIdentifiers_readOnly; // 0x98
	public readonly int[] buttonElementIdentifierIds; // 0xA0
	public readonly int[] axisElementIdentifierIds; // 0xA8
	public readonly int[] axis2DElementIdentifierIds; // 0xB0
	public readonly int[] hatElementIdentifierIds; // 0xB8
	public readonly int[] dpadElementIdentifierIds; // 0xC0
	public readonly int elementIdentifierCount; // 0xC8
	public readonly int axisCount; // 0xCC
	public readonly int buttonCount; // 0xD0
	public readonly int compoundElementCount; // 0xD4
	public readonly int axis2DCount; // 0xD8
	public readonly int hatCount; // 0xDC
	public readonly int dpadCount; // 0xE0
	public readonly JoystickType[] joystickTypes; // 0xE8
	public readonly AxisCalibrationData[] hwAxisCalibrationData; // 0xF0
	public readonly AxisRange[] hwAxisRanges; // 0xF8
	public readonly HardwareAxisInfo[] hwAxisInfo; // 0x100
	public readonly HardwareButtonInfo[] hwButtonInfo; // 0x108
	public readonly HardwareJoystickMap.CompoundElement[] compoundElements; // 0x110
	private readonly DeviceLocalizationInfo WulVOTHhNGQKnjKKigArzHlzpkVs; // 0x118

	// Properties
	public DeviceLocalizationInfo deviceLocalizationInfo { get; }

	// Methods

	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0
	public DeviceLocalizationInfo get_deviceLocalizationInfo() { }

	// RVA: 0x187B160 Offset: 0x1879760 VA: 0x18187B160
	public void .ctor(string , DeviceLocalizationInfo , int , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x187BF10 Offset: 0x187A510 VA: 0x18187BF10
	public void .ctor(string , DeviceLocalizationInfo , HardwareControllerMapIdentifier , JoystickType[] , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x187ADF0 Offset: 0x18793F0 VA: 0x18187ADF0
	public void .ctor(string , HardwareControllerMapIdentifier , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x187B1F0 Offset: 0x18797F0 VA: 0x18187B1F0
	private void .ctor(string , DeviceLocalizationInfo , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x187A5D0 Offset: 0x1878BD0 VA: 0x18187A5D0
	public string GetElementIdentifierName(int elementIdentifierId) { }

	// RVA: 0x187A710 Offset: 0x1878D10 VA: 0x18187A710
	public string GetElementIdentifierPositiveName(int elementIdentifierId) { }

	// RVA: 0x187A670 Offset: 0x1878C70 VA: 0x18187A670
	public string GetElementIdentifierNegativeName(int elementIdentifierId) { }

	// RVA: 0x187A120 Offset: 0x1878720 VA: 0x18187A120
	public int GetAxisIndex(int elementIdentifierId) { }

	// RVA: 0x187A180 Offset: 0x1878780 VA: 0x18187A180
	public int GetAxisIndex(string elementIdentifierName) { }

	// RVA: 0x187A310 Offset: 0x1878910 VA: 0x18187A310
	public int GetButtonIndex(int elementIdentifierId) { }

	// RVA: 0x187A370 Offset: 0x1878970 VA: 0x18187A370
	public int GetButtonIndex(string elementIdentifierName) { }

	// RVA: 0x187A520 Offset: 0x1878B20 VA: 0x18187A520
	public ControllerElementIdentifier GetElementIdentifierById(int id) { }

	// RVA: 0x187A2A0 Offset: 0x18788A0 VA: 0x18187A2A0
	public ControllerElementIdentifier GetButtonElementIdentifierById(int id) { }

	// RVA: 0x187A0B0 Offset: 0x18786B0 VA: 0x18187A0B0
	public ControllerElementIdentifier GetAxisElementIdentifierById(int id) { }

	// RVA: 0x187A020 Offset: 0x1878620 VA: 0x18187A020
	public HardwareJoystickMap.CompoundElement GetAxis2DData(int index) { }

	// RVA: 0x187A850 Offset: 0x1878E50 VA: 0x18187A850
	public HardwareJoystickMap.CompoundElement GetHatData(int index) { }

	// RVA: 0x187A490 Offset: 0x1878A90 VA: 0x18187A490
	public HardwareJoystickMap.CompoundElement GetDPadData(int index) { }

	// RVA: 0x187A7B0 Offset: 0x1878DB0 VA: 0x18187A7B0
	public ControllerElementType GetElementType(int elementIdentifierId) { }

	// RVA: 0x187ABE0 Offset: 0x18791E0 VA: 0x18187ABE0
	public bool TryGetCompoundElementMemberCombinedLocalizedName(IList<ActionElementMap> aems, out string result) { }

	// RVA: 0x187A8E0 Offset: 0x1878EE0 VA: 0x18187A8E0
	public bool TryGetCompoundElementMemberCombinedGlyph(IList<ActionElementMap> aems, bool getGlyph, bool getFinalKey, out object glyphResult, out string finalKey) { }

	// RVA: 0x1879FC0 Offset: 0x18785C0 VA: 0x181879FC0
	private int AbtnbLWFSvRffIQfUegbWAGxFJIW(ControllerElementIdentifier[] , int ) { }

	// RVA: 0x187C050 Offset: 0x187A650 VA: 0x18187C050
	private static HardwareControllerMap_Game.PUezliGykPuAiJZIHdJAMvZbRHrE yaShXCAKcdcuEHXoApShoGzoeDNF(HardwareJoystickMap.CompoundElement , ControllerElementIdentifier , IList<ActionElementMap> , out int ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class HardwareJoystickMap_InputManager // TypeDefIndex: 2046
{
	// Fields
	public string controllerName; // 0x10
	public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; // 0x18
	public readonly HardwareJoystickMap.Platform map; // 0x38
	public readonly int buttonCount; // 0x40
	public readonly int axisCount; // 0x44
	public readonly ControllerElementIdentifier[] elementIdentifiers; // 0x48
	public readonly HardwareJoystickMap.CompoundElement[] compoundElements; // 0x50
	public bool useSystemName; // 0x58
	public readonly bool isUnknownController; // 0x59
	public readonly JoystickType[] joystickTypes; // 0x60
	private readonly DeviceLocalizationInfo BSroaEoFLgFbVuSRRbfhyABpfmsGA; // 0x68

	// Properties
	public DeviceLocalizationInfo deviceLocalizationInfo { get; }

	// Methods

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public DeviceLocalizationInfo get_deviceLocalizationInfo() { }

	// RVA: 0x187CC40 Offset: 0x187B240 VA: 0x18187CC40
	public void .ctor(HardwareControllerMapIdentifier , JoystickType[] , DeviceLocalizationInfo , HardwareJoystickMap.Platform , string , int , int , int , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x187C460 Offset: 0x187AA60 VA: 0x18187C460
	public HardwareControllerMap_Game ToGameHardwareControllerMap() { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputAction : rFbSwIKNzFgQqRFWkIpWVHHHyFGy, dmwPlHfCHErBELjQlGwCmsUXbNbq // TypeDefIndex: 2047
{
	// Fields
	private const string keyCategory = "action";
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private InputActionType _type; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _descriptiveName; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _positiveDescriptiveName; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _negativeDescriptiveName; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _positiveKey; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _negativeKey; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _behaviorId; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _userAssignable; // 0x5C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _categoryId; // 0x60
	private hPDiAolkDfCrXGmZEVSRQzaSAEYRA ZKLQnivolUivjBrSObpkiLziMxVEc; // 0x68
	private int QZeXjgjUKEpDjVGkgBHLkmeHNFWuA; // 0x70

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public InputActionType type { get; set; }
	public string descriptiveName { get; set; }
	public string positiveDescriptiveName { get; set; }
	public string negativeDescriptiveName { get; set; }
	public int behaviorId { get; set; }
	public int categoryId { get; set; }
	public bool userAssignable { get; set; }
	[CustomObfuscation(rename = False)]
	internal string key { get; set; }
	[CustomObfuscation(rename = False)]
	internal string positiveKey { get; set; }
	[CustomObfuscation(rename = False)]
	internal string negativeKey { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedDescriptiveName { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedPositiveDescriptiveName { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedPositiveDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.positiveKey { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.negativeKey { get; set; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_id() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void qHCaNdlQXnDvmbdoBcruFqXInhpU(int ) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_name() { }

	// RVA: 0x187DBD0 Offset: 0x187C1D0 VA: 0x18187DBD0
	internal void ydJIIVasyYdWNZHMkxLxCInzNLnd(string ) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public InputActionType get_type() { }

	// RVA: 0x187D8D0 Offset: 0x187BED0 VA: 0x18187D8D0
	internal void qdaCvToWvGGlquMKlxGyyfpUkktF(InputActionType ) { }

	// RVA: 0x187D670 Offset: 0x187BC70 VA: 0x18187D670
	public string get_descriptiveName() { }

	// RVA: 0x187D230 Offset: 0x187B830 VA: 0x18187D230
	internal void HjsUuzzmiddQHESUZlioiravtWHNA(string ) { }

	// RVA: 0x187D7F0 Offset: 0x187BDF0 VA: 0x18187D7F0
	public string get_positiveDescriptiveName() { }

	// RVA: 0x187D470 Offset: 0x187BA70 VA: 0x18187D470
	internal void WptFrydkvOBJGORCgoNQIAzzmeQA(string ) { }

	// RVA: 0x187D730 Offset: 0x187BD30 VA: 0x18187D730
	public string get_negativeDescriptiveName() { }

	// RVA: 0x187D380 Offset: 0x187B980 VA: 0x18187D380
	internal void QIMnbJTWSCYvLghMZGfWtqBLNZTg(string ) { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	public int get_behaviorId() { }

	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	internal void zICAldFyTbMoHRPxjJigKxxKdUrfA(int ) { }

	// RVA: 0x3848A0 Offset: 0x382EA0 VA: 0x1803848A0
	public int get_categoryId() { }

	// RVA: 0x1548CC0 Offset: 0x15472C0 VA: 0x181548CC0
	internal void RHlpuTENytPMPCTuJFlNvkKrdVyw(int ) { }

	// RVA: 0x14D2470 Offset: 0x14D0A70 VA: 0x1814D2470
	public bool get_userAssignable() { }

	// RVA: 0x187D600 Offset: 0x187BC00 VA: 0x18187D600
	internal void bKXDxKHgfnVTtfwONFrsfHtyWoPD(bool ) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x187D530 Offset: 0x187BB30 VA: 0x18187D530
	public void .ctor(InputAction ) { }

	// RVA: 0x187CEC0 Offset: 0x187B4C0 VA: 0x18187CEC0
	public InputAction Clone() { }

	// RVA: 0x187CFC0 Offset: 0x187B5C0 VA: 0x18187CFC0
	public string GetDisplayName(AxisRange axisRange) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal string get_key() { }

	// RVA: 0x187D990 Offset: 0x187BF90 VA: 0x18187D990
	internal void set_key(string value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal string get_positiveKey() { }

	// RVA: 0x187DB10 Offset: 0x187C110 VA: 0x18187DB10
	internal void set_positiveKey(string value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal string get_negativeKey() { }

	// RVA: 0x187DA50 Offset: 0x187C050 VA: 0x18187DA50
	internal void set_negativeKey(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x187D230 Offset: 0x187B830 VA: 0x18187D230
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal string get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x187D470 Offset: 0x187BA70 VA: 0x18187D470
	internal void set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal string get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x187D380 Offset: 0x187B980 VA: 0x18187D380
	internal void set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x187D2F0 Offset: 0x187B8F0 VA: 0x18187D2F0
	internal void ICiRFnYAruEKRAuqtCNTwhQJACTj() { }

	// RVA: 0x187D8B0 Offset: 0x187BEB0 VA: 0x18187D8B0
	internal void hdKxxMgMwQKZAXiOmKndeNjGsMYK() { }

	// RVA: 0x187D610 Offset: 0x187BC10 VA: 0x18187D610
	private static NrPxKUKQSPaerZsCohGosVlmvWeK.sUpanQdFnWgYwScTqDjkbGSfxPXrA eCyLFOjJFDJNVTAlBnbHTWwqsQSS(InputActionType ) { }

	// RVA: 0x187D440 Offset: 0x187BA40 VA: 0x18187D440 Slot: 12
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 13
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 14
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0 Slot: 15
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 4
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210 Slot: 5
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 6
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0 Slot: 7
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 16
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 8
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_positiveKey() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 9
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_positiveKey(string value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 10
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_negativeKey() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 11
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_negativeKey(string value) { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0 Slot: 17
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x4A4300 Offset: 0x4A2900 VA: 0x1804A4300 Slot: 18
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputBehavior // TypeDefIndex: 2048
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _joystickAxisSensitivity; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _digitalAxisSimulation; // 0x24
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _digitalAxisSnap; // 0x25
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _digitalAxisInstantReverse; // 0x26
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _digitalAxisGravity; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _digitalAxisSensitivity; // 0x2C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private MouseXYAxisMode _mouseXYAxisMode; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private MouseOtherAxisMode _mouseOtherAxisMode; // 0x34
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _mouseXYAxisSensitivity; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc; // 0x3C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _mouseOtherAxisSensitivity; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _customControllerAxisSensitivity; // 0x44
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonDoublePressSpeed; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonShortPressTime; // 0x4C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonShortPressExpiresIn; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonLongPressTime; // 0x54
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonLongPressExpiresIn; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonDeadZone; // 0x5C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonDownBuffer; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonRepeatRate; // 0x64
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonRepeatDelay; // 0x68

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public float joystickAxisSensitivity { get; set; }
	public bool digitalAxisSimulation { get; set; }
	public bool digitalAxisSnap { get; set; }
	public bool digitalAxisInstantReverse { get; set; }
	public float digitalAxisGravity { get; set; }
	public float digitalAxisSensitivity { get; set; }
	public MouseXYAxisMode mouseXYAxisMode { get; set; }
	public MouseOtherAxisMode mouseOtherAxisMode { get; set; }
	public float mouseXYAxisSensitivity { get; set; }
	public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc { get; set; }
	public float mouseOtherAxisSensitivity { get; set; }
	public float customControllerAxisSensitivity { get; set; }
	public float buttonDoublePressSpeed { get; set; }
	public float buttonShortPressTime { get; set; }
	public float buttonShortPressExpiresIn { get; set; }
	public float buttonLongPressTime { get; set; }
	public float buttonLongPressExpiresIn { get; set; }
	public float buttonDeadZone { get; set; }
	public float buttonDownBuffer { get; set; }
	public float buttonRepeatRate { get; set; }
	public float buttonRepeatDelay { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_id() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void pmfQbMEtRjrnrmVYSuXfPNvEOuhW(int ) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_name() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void lNXFzpwCmJhbvrMUtcjoeQHpHikn(string ) { }

	// RVA: 0x3CB400 Offset: 0x3C9A00 VA: 0x1803CB400
	public float get_joystickAxisSensitivity() { }

	// RVA: 0x187F7E0 Offset: 0x187DDE0 VA: 0x18187F7E0
	public void set_joystickAxisSensitivity(float value) { }

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_digitalAxisSimulation() { }

	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_digitalAxisSimulation(bool value) { }

	// RVA: 0x161BB10 Offset: 0x161A110 VA: 0x18161BB10
	public bool get_digitalAxisSnap() { }

	// RVA: 0x161BB90 Offset: 0x161A190 VA: 0x18161BB90
	public void set_digitalAxisSnap(bool value) { }

	// RVA: 0x161BB00 Offset: 0x161A100 VA: 0x18161BB00
	public bool get_digitalAxisInstantReverse() { }

	// RVA: 0x161BB80 Offset: 0x161A180 VA: 0x18161BB80
	public void set_digitalAxisInstantReverse(bool value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0
	public float get_digitalAxisGravity() { }

	// RVA: 0x187F780 Offset: 0x187DD80 VA: 0x18187F780
	public void set_digitalAxisGravity(float value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0
	public float get_digitalAxisSensitivity() { }

	// RVA: 0x187F7B0 Offset: 0x187DDB0 VA: 0x18187F7B0
	public void set_digitalAxisSensitivity(float value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public MouseXYAxisMode get_mouseXYAxisMode() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_mouseXYAxisMode(MouseXYAxisMode value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public MouseOtherAxisMode get_mouseOtherAxisMode() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	public void set_mouseOtherAxisMode(MouseOtherAxisMode value) { }

	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0
	public float get_mouseXYAxisSensitivity() { }

	// RVA: 0x187F840 Offset: 0x187DE40 VA: 0x18187F840
	public void set_mouseXYAxisSensitivity(float value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public MouseXYAxisDeltaCalc get_mouseXYAxisDeltaCalc() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_mouseXYAxisDeltaCalc(MouseXYAxisDeltaCalc value) { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_mouseOtherAxisSensitivity() { }

	// RVA: 0x187F810 Offset: 0x187DE10 VA: 0x18187F810
	public void set_mouseOtherAxisSensitivity(float value) { }

	// RVA: 0x46E1F0 Offset: 0x46C7F0 VA: 0x18046E1F0
	public float get_customControllerAxisSensitivity() { }

	// RVA: 0x187F750 Offset: 0x187DD50 VA: 0x18187F750
	public void set_customControllerAxisSensitivity(float value) { }

	// RVA: 0x187F560 Offset: 0x187DB60 VA: 0x18187F560
	public float get_buttonDoublePressSpeed() { }

	// RVA: 0x187F5E0 Offset: 0x187DBE0 VA: 0x18187F5E0
	public void set_buttonDoublePressSpeed(float value) { }

	// RVA: 0x187F5A0 Offset: 0x187DBA0 VA: 0x18187F5A0
	public float get_buttonShortPressTime() { }

	// RVA: 0x187F720 Offset: 0x187DD20 VA: 0x18187F720
	public void set_buttonShortPressTime(float value) { }

	// RVA: 0x34DA80 Offset: 0x34C080 VA: 0x18034DA80
	public float get_buttonShortPressExpiresIn() { }

	// RVA: 0x187F6F0 Offset: 0x187DCF0 VA: 0x18187F6F0
	public void set_buttonShortPressExpiresIn(float value) { }

	// RVA: 0x17836B0 Offset: 0x1781CB0 VA: 0x1817836B0
	public float get_buttonLongPressTime() { }

	// RVA: 0x187F670 Offset: 0x187DC70 VA: 0x18187F670
	public void set_buttonLongPressTime(float value) { }

	// RVA: 0x187F580 Offset: 0x187DB80 VA: 0x18187F580
	public float get_buttonLongPressExpiresIn() { }

	// RVA: 0x187F640 Offset: 0x187DC40 VA: 0x18187F640
	public void set_buttonLongPressExpiresIn(float value) { }

	// RVA: 0x187F550 Offset: 0x187DB50 VA: 0x18187F550
	public float get_buttonDeadZone() { }

	// RVA: 0x187F5B0 Offset: 0x187DBB0 VA: 0x18187F5B0
	public void set_buttonDeadZone(float value) { }

	// RVA: 0x187F570 Offset: 0x187DB70 VA: 0x18187F570
	public float get_buttonDownBuffer() { }

	// RVA: 0x187F610 Offset: 0x187DC10 VA: 0x18187F610
	public void set_buttonDownBuffer(float value) { }

	// RVA: 0x187F590 Offset: 0x187DB90 VA: 0x18187F590
	public float get_buttonRepeatRate() { }

	// RVA: 0x187F6C0 Offset: 0x187DCC0 VA: 0x18187F6C0
	public void set_buttonRepeatRate(float value) { }

	// RVA: 0x4A42F0 Offset: 0x4A28F0 VA: 0x1804A42F0
	public float get_buttonRepeatDelay() { }

	// RVA: 0x187F6A0 Offset: 0x187DCA0 VA: 0x18187F6A0
	public void set_buttonRepeatDelay(float value) { }

	// RVA: 0x187F440 Offset: 0x187DA40 VA: 0x18187F440
	public void .ctor() { }

	// RVA: 0x187F350 Offset: 0x187D950 VA: 0x18187F350
	public void .ctor(InputBehavior ) { }

	// RVA: 0x187F2C0 Offset: 0x187D8C0 VA: 0x18187F2C0
	public string ToXmlString() { }

	// RVA: 0x187E400 Offset: 0x187CA00 VA: 0x18187E400
	public bool ImportXmlString(string xmlString) { }

	// RVA: 0x187F230 Offset: 0x187D830 VA: 0x18187F230
	public string ToJsonString() { }

	// RVA: 0x187E330 Offset: 0x187C930 VA: 0x18187E330
	public bool ImportJsonString(string jsonString) { }

	// RVA: 0x187E250 Offset: 0x187C850 VA: 0x18187E250
	public bool ImportData(InputBehavior inputBehavior) { }

	// RVA: 0x187DC90 Offset: 0x187C290 VA: 0x18187DC90
	public InputBehavior Clone() { }

	// RVA: 0x187E4D0 Offset: 0x187CAD0 VA: 0x18187E4D0
	public void Reset() { }

	// RVA: 0x187E5F0 Offset: 0x187CBF0 VA: 0x18187E5F0
	internal SerializedObject SJNStLRGsZDBbagLZDDBCmicHRawB() { }

	// RVA: 0x187DDB0 Offset: 0x187C3B0 VA: 0x18187DDB0
	internal void DboPLWXhkoNktVNooZrJbVrFpujC(SerializedObject ) { }

	// RVA: 0x187F470 Offset: 0x187DA70 VA: 0x18187F470
	private static void eoZuanvKUcoQGfINSVqOmOjWORvs(InputBehavior , InputBehavior , bool ) { }
}

// Namespace: Rewired
[Serializable]
public abstract class InputCategory : dmwPlHfCHErBELjQlGwCmsUXbNbq // TypeDefIndex: 2049
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected string _name; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected string _descriptiveName; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected string _key; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected string _tag; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected int _id; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected bool _userAssignable; // 0x34
	private kHQCdvDFmtugtOEvKzWXyTgZIwTh vjbXfLJNGGbkHaabdVLNSiaBZNEd; // 0x38
	private int pnYnhDBJcsFUIfXefmIQMLpNytfp; // 0x40

	// Properties
	internal abstract string keyCategory { get; }
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public string tag { get; set; }
	public int id { get; set; }
	public bool userAssignable { get; set; }
	[CustomObfuscation(rename = False)]
	internal string key { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract string get_keyCategory();

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void PjVdGUzmGPqKRkcaWKkSjEKEqyCf(string ) { }

	// RVA: 0x187F980 Offset: 0x187DF80 VA: 0x18187F980
	public string get_descriptiveName() { }

	// RVA: 0x187F8C0 Offset: 0x187DEC0 VA: 0x18187F8C0
	internal void aAWYkyPPyTeHahQLFiAPNsOWlvRI(string ) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_tag() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void fgfsFdjmsTLhVoGbdWbintvwvoQe(string ) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_id() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	internal void xxsgXwUOJqcUeQBGnBPnxJLNdzGq(int ) { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_userAssignable() { }

	// RVA: 0x16A5170 Offset: 0x16A3770 VA: 0x1816A5170
	internal void VdYLCjwbuqFaybBdMdMywfrSUVfjA(bool ) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_key() { }

	// RVA: 0x187FA40 Offset: 0x187E040 VA: 0x18187FA40
	internal void set_key(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x187F8C0 Offset: 0x187DEC0 VA: 0x18187F8C0
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x187F8A0 Offset: 0x187DEA0 VA: 0x18187F8A0 Slot: 4
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 6
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 7
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 8
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30 Slot: 9
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800 Slot: 10
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x187CE00 Offset: 0x187B400 VA: 0x18187CE00
	public void .ctor(InputCategory ) { }

	// RVA: 0x187F870 Offset: 0x187DE70 VA: 0x18187F870 Slot: 12
	internal virtual void OTNlqTDvKkLXyQNECbJYedgXGAGy() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	internal virtual void qHeUKakOCOTsvUcggKaCulxmnoxf() { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputActionCategory : InputCategory // TypeDefIndex: 2050
{
	// Properties
	internal override string keyCategory { get; }

	// Methods

	// RVA: 0x187CE90 Offset: 0x187B490 VA: 0x18187CE90 Slot: 11
	internal override string get_keyCategory() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x187CE00 Offset: 0x187B400 VA: 0x18187CE00
	public void .ctor(InputActionCategory ) { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputMapCategory : InputCategory // TypeDefIndex: 2051
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _checkConflictsWithAllCategories; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<int> _checkConflictsCategoryIds; // 0x50
	private ReadOnlyCollection<int> _checkConflictsCategoryIds_readOnly; // 0x58

	// Properties
	internal override string keyCategory { get; }
	public bool checkConflictsWithAllCategories { get; set; }
	public IList<int> checkConflictsCategoryIds { get; }
	internal List<int> IxiEHtJYoXfahiMaFLhhUqHgNmIoA { get; }

	// Methods

	// RVA: 0x1880000 Offset: 0x187E600 VA: 0x181880000 Slot: 11
	internal override string get_keyCategory() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_checkConflictsWithAllCategories() { }

	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	internal void HIuYaJsLjGBBGpPXVXYsOXcqcVkh(bool ) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public IList<int> get_checkConflictsCategoryIds() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal List<int> EavyNwyGCTHcjFSviCogHcSBWbFtb() { }

	// RVA: 0x187FEB0 Offset: 0x187E4B0 VA: 0x18187FEB0
	public void .ctor() { }

	// RVA: 0x187FF30 Offset: 0x187E530 VA: 0x18187FF30
	public void .ctor(InputMapCategory ) { }

	// RVA: 0x1880030 Offset: 0x187E630 VA: 0x181880030 Slot: 12
	internal override void wpuFhXhCMnkcxihWadmmJCYKptcr() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	internal override void hljLfQtHlEpFrkZwxtqFEGhwgltK() { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputLayout : dmwPlHfCHErBELjQlGwCmsUXbNbq // TypeDefIndex: 2052
{
	// Fields
	private const string keyCategory = "controller_map/layout";
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _descriptiveName; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x28
	private kHQCdvDFmtugtOEvKzWXyTgZIwTh dCfCAhWhvGMQybtnOQWlfTMzmPeT; // 0x30
	private int ONoSDiGTYItdPscdLHufaBdZnDmTA; // 0x38

	// Properties
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public int id { get; set; }
	[CustomObfuscation(rename = False)]
	internal string key { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void UuoEHTcBKSTkouSXCpIjcPlecjcQc(string ) { }

	// RVA: 0x187FD00 Offset: 0x187E300 VA: 0x18187FD00
	public string get_descriptiveName() { }

	// RVA: 0x187FC40 Offset: 0x187E240 VA: 0x18187FC40
	internal void cRrhNiuEohRuJQWZeEfcxEwPBwgfA(string ) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_id() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	internal void NOrRcuPPdmgCRwgEvcraBOTWmpChb(int ) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_key() { }

	// RVA: 0x187FDF0 Offset: 0x187E3F0 VA: 0x18187FDF0
	internal void set_key(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x187FC40 Offset: 0x187E240 VA: 0x18187FC40
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x187FBA0 Offset: 0x187E1A0 VA: 0x18187FBA0 Slot: 4
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 6
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 7
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 8
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 9
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0 Slot: 10
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x187FBD0 Offset: 0x187E1D0 VA: 0x18187FBD0
	public void .ctor(InputLayout ) { }

	// RVA: 0x187FB00 Offset: 0x187E100 VA: 0x18187FB00
	public InputLayout Clone() { }

	// RVA: 0x187FDC0 Offset: 0x187E3C0 VA: 0x18187FDC0
	internal void qhzEymTPFTQTJjnLFMvaHsmUrpFM() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void zWwMTpCbhfsQaROLtudwnsRMUfHW() { }
}

// Namespace: Rewired
public sealed class InputMapper // TypeDefIndex: 2074
{
	// Fields
	private static InputMapper fEcRHtthGmXulEezUqDHVDTmRSqF; // 0x0
	private static int NXgTaTiJMndoRWCiNyPHRhwiTMjR; // 0x8
	private readonly int qOfsFxOXsCuwtZPUiTuJqLiSbWTdA; // 0x10
	private readonly bool wbJhiUbCygICqvDUZgCjzIHlOHXIA; // 0x14
	private readonly InputMapper.acMMLQlAKPNcINZMPrgTMUPSrffn YlFsdtZVuYOhbDZepAVeeWTaEhHB; // 0x18
	private InputMapper.Options SZiWRcsXIEkjGHhbCaxeBVifozsEb; // 0x20
	private readonly Dictionary<InputMapper.NxCNwPpsrDISVIDTUwhffJsDbVSCA, SafeDelegate> jaGOApljOjmscvfhKXJmWnwpxzkS; // 0x28

	// Properties
	public static InputMapper Default { get; }
	public InputMapper.Options options { get; set; }
	public InputMapper.Context mappingContext { get; }
	public InputMapper.Status status { get; }
	public float timeRemaining { get; }
	internal int JiPHyQnibPhbDNrfHfppcTpEYXrIA { get; }

	// Methods

	// RVA: 0x18814B0 Offset: 0x187FAB0 VA: 0x1818814B0
	public static InputMapper get_Default() { }

	// RVA: 0x1881C90 Offset: 0x1880290 VA: 0x181881C90
	private static int uMoqqtKLtZWHBubJLiDvdScniZwB() { }

	// RVA: 0x1881580 Offset: 0x187FB80 VA: 0x181881580
	public InputMapper.Options get_options() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_options(InputMapper.Options value) { }

	// RVA: 0x1881540 Offset: 0x187FB40 VA: 0x181881540
	public InputMapper.Context get_mappingContext() { }

	// RVA: 0x1881640 Offset: 0x187FC40 VA: 0x181881640
	public InputMapper.Status get_status() { }

	// RVA: 0x1881660 Offset: 0x187FC60 VA: 0x181881660
	public float get_timeRemaining() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal int dniLtBEZWCQmTfHKpjbvpKOUjVjbA() { }

	// RVA: 0x1881140 Offset: 0x187F740 VA: 0x181881140
	public void add_InputMappedEvent(Action<InputMapper.InputMappedEventData> value) { }

	// RVA: 0x1881920 Offset: 0x187FF20 VA: 0x181881920
	public void remove_InputMappedEvent(Action<InputMapper.InputMappedEventData> value) { }

	// RVA: 0x1881060 Offset: 0x187F660 VA: 0x181881060
	public void add_ErrorEvent(Action<InputMapper.ErrorEventData> value) { }

	// RVA: 0x1881840 Offset: 0x187FE40 VA: 0x181881840
	public void remove_ErrorEvent(Action<InputMapper.ErrorEventData> value) { }

	// RVA: 0x1880EA0 Offset: 0x187F4A0 VA: 0x181880EA0
	public void add_CanceledEvent(Action<InputMapper.CanceledEventData> value) { }

	// RVA: 0x1881680 Offset: 0x187FC80 VA: 0x181881680
	public void remove_CanceledEvent(Action<InputMapper.CanceledEventData> value) { }

	// RVA: 0x18813D0 Offset: 0x187F9D0 VA: 0x1818813D0
	public void add_TimedOutEvent(Action<InputMapper.TimedOutEventData> value) { }

	// RVA: 0x1881BB0 Offset: 0x18801B0 VA: 0x181881BB0
	public void remove_TimedOutEvent(Action<InputMapper.TimedOutEventData> value) { }

	// RVA: 0x1881210 Offset: 0x187F810 VA: 0x181881210
	public void add_StartedEvent(Action<InputMapper.StartedEventData> value) { }

	// RVA: 0x18819F0 Offset: 0x187FFF0 VA: 0x1818819F0
	public void remove_StartedEvent(Action<InputMapper.StartedEventData> value) { }

	// RVA: 0x18812F0 Offset: 0x187F8F0 VA: 0x1818812F0
	public void add_StoppedEvent(Action<InputMapper.StoppedEventData> value) { }

	// RVA: 0x1881AD0 Offset: 0x18800D0 VA: 0x181881AD0
	public void remove_StoppedEvent(Action<InputMapper.StoppedEventData> value) { }

	// RVA: 0x1880F80 Offset: 0x187F580 VA: 0x181880F80
	public void add_ConflictFoundEvent(Action<InputMapper.ConflictFoundEventData> value) { }

	// RVA: 0x1881760 Offset: 0x187FD60 VA: 0x181881760
	public void remove_ConflictFoundEvent(Action<InputMapper.ConflictFoundEventData> value) { }

	// RVA: 0x1880E30 Offset: 0x187F430 VA: 0x181880E30
	public void .ctor() { }

	// RVA: 0x1880610 Offset: 0x187EC10 VA: 0x181880610
	private void .ctor(bool ) { }

	// RVA: 0x1880400 Offset: 0x187EA00 VA: 0x181880400
	public void RemoveEventListeners(object listenerOrParent) { }

	// RVA: 0x18802D0 Offset: 0x187E8D0 VA: 0x1818802D0
	public void RemoveAllEventListeners() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void vCEqpeAewLLZTmfTAQDqweYuDSncA(object ) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void wUrLaPScaPIDwUuhOQnoOwoxzMwI() { }

	// RVA: 0x1880550 Offset: 0x187EB50 VA: 0x181880550
	public bool Start(InputMapper.Context mappingContext) { }

	// RVA: 0x18805B0 Offset: 0x187EBB0 VA: 0x1818805B0
	public void Stop() { }

	// RVA: 0x18800E0 Offset: 0x187E6E0 VA: 0x1818800E0
	public void Clear() { }

	// RVA: 0x1880150 Offset: 0x187E750 VA: 0x181880150
	private bool ECZljXVDHstQIqgETyQzvcABvxut(InputMapper.Context , InputMapper.Options ) { }
}

// Namespace: Rewired
public struct PlayerSaveData // TypeDefIndex: 2076
{
	// Fields
	private JoystickMapSaveData[] eenSzaCsXutGZoXqMtbcjmHCdtgEA; // 0x0
	private KeyboardMapSaveData[] DmgGWocMbfaEJYPyxzrFUfWftzlI; // 0x8
	private MouseMapSaveData[] tEYalpMjKziNieAWWFOOmCnTCzMT; // 0x10
	private CustomControllerMapSaveData[] yeovScOFrNBmxrlTpGoemJbfliEo; // 0x18
	private InputBehavior[] uKbXgORekfADCjZshCoaohGejMNib; // 0x20

	// Properties
	public JoystickMapSaveData[] joystickMapSaveData { get; }
	public KeyboardMapSaveData[] keyboardMapSaveData { get; }
	public MouseMapSaveData[] mouseMapSaveData { get; }
	public CustomControllerMapSaveData[] customControllerMapSaveData { get; }
	public InputBehavior[] inputBehaviors { get; }
	public int joystickMapCount { get; }
	public int keyboardMapCount { get; }
	public int mouseMapCount { get; }
	public int customControllerMapCount { get; }
	public int inputBehaviorCount { get; }
	public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public JoystickMapSaveData[] get_joystickMapSaveData() { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public KeyboardMapSaveData[] get_keyboardMapSaveData() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public MouseMapSaveData[] get_mouseMapSaveData() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public CustomControllerMapSaveData[] get_customControllerMapSaveData() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public InputBehavior[] get_inputBehaviors() { }

	// RVA: 0x8F9C20 Offset: 0x8F8220 VA: 0x1808F9C20
	public int get_joystickMapCount() { }

	// RVA: 0x1897A70 Offset: 0x1896070 VA: 0x181897A70
	public int get_keyboardMapCount() { }

	// RVA: 0x378930 Offset: 0x376F30 VA: 0x180378930
	public int get_mouseMapCount() { }

	// RVA: 0x37E800 Offset: 0x37CE00 VA: 0x18037E800
	public int get_customControllerMapCount() { }

	// RVA: 0x176B890 Offset: 0x1769E90 VA: 0x18176B890
	public int get_inputBehaviorCount() { }

	[IteratorStateMachine(typeof(PlayerSaveData.DkASAsLnNIGWqEErwtBzkhhUtuQQ))]
	// RVA: 0x18979E0 Offset: 0x1895FE0 VA: 0x1818979E0
	public IEnumerable<ControllerMapSaveData> get_AllControllerMapSaveData() { }

	// RVA: 0x1897820 Offset: 0x1895E20 VA: 0x181897820
	internal void .ctor(JoystickMapSaveData[] , KeyboardMapSaveData[] , MouseMapSaveData[] , CustomControllerMapSaveData[] , IList<InputBehavior> ) { }
}

// Namespace: Rewired
public sealed class Player : dmwPlHfCHErBELjQlGwCmsUXbNbq // TypeDefIndex: 2142
{
	// Fields
	private const string ognXdpxwxbsTamtXOGoCuWQUSqkg = "player";
	private readonly NtLLFFJOcFyvZRAWZFOVWxCAkgNv XtTKmaJoKEcbCGMLQDUaVmAjkXPj; // 0x10
	private bool dDSrDODmeeHVDEUxRcRSXLCAXIShA; // 0x18
	private int kBkzZSYaGFWPryFBnvmKzvyLcFG; // 0x1C
	private string IJVCIKoueDdSAzFztzNBPaeCOUfJ; // 0x20
	private string lTwmvhaOPfEmmIbBEgzNTetYQeBt; // 0x28
	private readonly string XFhjbRFtqIkZbFJGbcpdhMVCfSSXA; // 0x30
	private bool XNlcPGjyijfxNvQRWuxOmdGlJilK; // 0x38
	private readonly int KOIcfrKwINaYRZRNwbHCacWHUKBgc; // 0x3C
	private readonly kHQCdvDFmtugtOEvKzWXyTgZIwTh QgmZecXMdMqwppxJzuxtgnKdDBho; // 0x40
	private int LFQiINDRyoptTpbfGZpBjodhHQbQ; // 0x48
	public readonly Player.ControllerHelper controllers; // 0x50

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public bool isPlaying { get; set; }
	internal string nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x18A2BD0 Offset: 0x18A11D0 VA: 0x1818A2BD0
	internal void .ctor(bool , int , string , string , string , OfCXoqClnlVSJpkEaYBuIVAVFZZB , ControllerMapLayoutManager.KTjbTVulAczqMJpjTFfXjkUzYrtg , ControllerMapEnabler.ExHBPPJAiWslLTxuqRFqHCQYvmjs ) { }

	// RVA: 0x18A2E40 Offset: 0x18A1440 VA: 0x1818A2E40
	public int get_id() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	internal void IqkcYWWJliIeCkPChwlJGaOJWdigA(int ) { }

	// RVA: 0x18A2F60 Offset: 0x18A1560 VA: 0x1818A2F60
	public string get_name() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void seOKFfQjtuRpfJNXbhtmMElOxnGC(string ) { }

	// RVA: 0x18A2D70 Offset: 0x18A1370 VA: 0x1818A2D70
	public string get_descriptiveName() { }

	// RVA: 0x18A3000 Offset: 0x18A1600 VA: 0x1818A3000
	internal void pGQDSqdSnDRCdiQHPvBaSnrmDtEC(string ) { }

	// RVA: 0x18A2ED0 Offset: 0x18A14D0 VA: 0x1818A2ED0
	public bool get_isPlaying() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_isPlaying(bool value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x18A3000 Offset: 0x18A1600 VA: 0x1818A3000
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x18A2770 Offset: 0x18A0D70 VA: 0x1818A2770 Slot: 4
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 5
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 6
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0 Slot: 7
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 8
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940 Slot: 9
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0 Slot: 10
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x18A0B20 Offset: 0x189F120 VA: 0x1818A0B20
	public PlayerSaveData GetSaveData(bool userAssignableMapsOnly) { }

	// RVA: 0x189DAC0 Offset: 0x189C0C0 VA: 0x18189DAC0
	public bool GetButton(string actionName) { }

	// RVA: 0x189DB90 Offset: 0x189C190 VA: 0x18189DB90
	public bool GetButton(int actionId) { }

	// RVA: 0x189BA70 Offset: 0x189A070 VA: 0x18189BA70
	public bool GetButtonDown(string actionName) { }

	// RVA: 0x189B9A0 Offset: 0x1899FA0 VA: 0x18189B9A0
	public bool GetButtonDown(int actionId) { }

	// RVA: 0x189D9F0 Offset: 0x189BFF0 VA: 0x18189D9F0
	public bool GetButtonUp(string actionName) { }

	// RVA: 0x189D920 Offset: 0x189BF20 VA: 0x18189D920
	public bool GetButtonUp(int actionId) { }

	// RVA: 0x189C020 Offset: 0x189A620 VA: 0x18189C020
	public bool GetButtonPrev(string actionName) { }

	// RVA: 0x189C0F0 Offset: 0x189A6F0 VA: 0x18189C0F0
	public bool GetButtonPrev(int actionId) { }

	// RVA: 0x189CAB0 Offset: 0x189B0B0 VA: 0x18189CAB0
	public bool GetButtonSinglePressHold(int actionId) { }

	// RVA: 0x189C9E0 Offset: 0x189AFE0 VA: 0x18189C9E0
	public bool GetButtonSinglePressHold(string actionName) { }

	// RVA: 0x189C840 Offset: 0x189AE40 VA: 0x18189C840
	public bool GetButtonSinglePressDown(int actionId) { }

	// RVA: 0x189C910 Offset: 0x189AF10 VA: 0x18189C910
	public bool GetButtonSinglePressDown(string actionName) { }

	// RVA: 0x189CB80 Offset: 0x189B180 VA: 0x18189CB80
	public bool GetButtonSinglePressUp(int actionId) { }

	// RVA: 0x189CC50 Offset: 0x189B250 VA: 0x18189CC50
	public bool GetButtonSinglePressUp(string actionName) { }

	// RVA: 0x189B3B0 Offset: 0x18999B0 VA: 0x18189B3B0
	public bool GetButtonDoublePressHold(string actionName, float speed) { }

	// RVA: 0x189B490 Offset: 0x1899A90 VA: 0x18189B490
	public bool GetButtonDoublePressHold(int actionId, float speed) { }

	// RVA: 0x189B570 Offset: 0x1899B70 VA: 0x18189B570
	public bool GetButtonDoublePressHold(string actionName) { }

	// RVA: 0x189B2E0 Offset: 0x18998E0 VA: 0x18189B2E0
	public bool GetButtonDoublePressHold(int actionId) { }

	// RVA: 0x189B0E0 Offset: 0x18996E0 VA: 0x18189B0E0
	public bool GetButtonDoublePressDown(string actionName, float speed) { }

	// RVA: 0x189AEE0 Offset: 0x18994E0 VA: 0x18189AEE0
	public bool GetButtonDoublePressDown(int actionId, float speed) { }

	// RVA: 0x189B1C0 Offset: 0x18997C0 VA: 0x18189B1C0
	public bool GetButtonDoublePressDown(string actionName) { }

	// RVA: 0x189AFC0 Offset: 0x18995C0 VA: 0x18189AFC0
	public bool GetButtonDoublePressDown(int actionId) { }

	// RVA: 0x189B710 Offset: 0x1899D10 VA: 0x18189B710
	public bool GetButtonDoublePressUp(string actionName, float speed) { }

	// RVA: 0x189B7F0 Offset: 0x1899DF0 VA: 0x18189B7F0
	public bool GetButtonDoublePressUp(int actionId, float speed) { }

	// RVA: 0x189B640 Offset: 0x1899C40 VA: 0x18189B640
	public bool GetButtonDoublePressUp(string actionName) { }

	// RVA: 0x189B8D0 Offset: 0x1899ED0 VA: 0x18189B8D0
	public bool GetButtonDoublePressUp(int actionId) { }

	// RVA: 0x189D680 Offset: 0x189BC80 VA: 0x18189D680
	public bool GetButtonTimedPress(string actionName, float time) { }

	// RVA: 0x189D5A0 Offset: 0x189BBA0 VA: 0x18189D5A0
	public bool GetButtonTimedPress(int actionId, float time) { }

	// RVA: 0x189D760 Offset: 0x189BD60 VA: 0x18189D760
	public bool GetButtonTimedPress(string actionName, float time, float expireIn) { }

	// RVA: 0x189D840 Offset: 0x189BE40 VA: 0x18189D840
	public bool GetButtonTimedPress(int actionId, float time, float expireIn) { }

	// RVA: 0x189D140 Offset: 0x189B740 VA: 0x18189D140
	public bool GetButtonTimedPressDown(string actionName, float time) { }

	// RVA: 0x189D060 Offset: 0x189B660 VA: 0x18189D060
	public bool GetButtonTimedPressDown(int actionId, float time) { }

	// RVA: 0x189D3E0 Offset: 0x189B9E0 VA: 0x18189D3E0
	public bool GetButtonTimedPressUp(string actionName, float time) { }

	// RVA: 0x189D4C0 Offset: 0x189BAC0 VA: 0x18189D4C0
	public bool GetButtonTimedPressUp(int actionId, float time) { }

	// RVA: 0x189D300 Offset: 0x189B900 VA: 0x18189D300
	public bool GetButtonTimedPressUp(string actionName, float time, float expireIn) { }

	// RVA: 0x189D220 Offset: 0x189B820 VA: 0x18189D220
	public bool GetButtonTimedPressUp(int actionId, float time, float expireIn) { }

	// RVA: 0x189C770 Offset: 0x189AD70 VA: 0x18189C770
	public bool GetButtonShortPress(string actionName) { }

	// RVA: 0x189C6A0 Offset: 0x189ACA0 VA: 0x18189C6A0
	public bool GetButtonShortPress(int actionId) { }

	// RVA: 0x189C360 Offset: 0x189A960 VA: 0x18189C360
	public bool GetButtonShortPressDown(string actionName) { }

	// RVA: 0x189C430 Offset: 0x189AA30 VA: 0x18189C430
	public bool GetButtonShortPressDown(int actionId) { }

	// RVA: 0x189C500 Offset: 0x189AB00 VA: 0x18189C500
	public bool GetButtonShortPressUp(string actionName) { }

	// RVA: 0x189C5D0 Offset: 0x189ABD0 VA: 0x18189C5D0
	public bool GetButtonShortPressUp(int actionId) { }

	// RVA: 0x189BF50 Offset: 0x189A550 VA: 0x18189BF50
	public bool GetButtonLongPress(string actionName) { }

	// RVA: 0x189BE80 Offset: 0x189A480 VA: 0x18189BE80
	public bool GetButtonLongPress(int actionId) { }

	// RVA: 0x189BC10 Offset: 0x189A210 VA: 0x18189BC10
	public bool GetButtonLongPressDown(string actionName) { }

	// RVA: 0x189BB40 Offset: 0x189A140 VA: 0x18189BB40
	public bool GetButtonLongPressDown(int actionId) { }

	// RVA: 0x189BDB0 Offset: 0x189A3B0 VA: 0x18189BDB0
	public bool GetButtonLongPressUp(string actionName) { }

	// RVA: 0x189BCE0 Offset: 0x189A2E0 VA: 0x18189BCE0
	public bool GetButtonLongPressUp(int actionId) { }

	// RVA: 0x189C1C0 Offset: 0x189A7C0 VA: 0x18189C1C0
	public bool GetButtonRepeating(string actionName) { }

	// RVA: 0x189C290 Offset: 0x189A890 VA: 0x18189C290
	public bool GetButtonRepeating(int actionId) { }

	// RVA: 0x1898900 Offset: 0x1896F00 VA: 0x181898900
	public bool GetAnyButton() { }

	// RVA: 0x1898720 Offset: 0x1896D20 VA: 0x181898720
	public bool GetAnyButtonDown() { }

	// RVA: 0x1898860 Offset: 0x1896E60 VA: 0x181898860
	public bool GetAnyButtonUp() { }

	// RVA: 0x18987C0 Offset: 0x1896DC0 VA: 0x1818987C0
	public bool GetAnyButtonPrev() { }

	// RVA: 0x189CDF0 Offset: 0x189B3F0 VA: 0x18189CDF0
	public double GetButtonTimePressed(string actionName) { }

	// RVA: 0x189CD20 Offset: 0x189B320 VA: 0x18189CD20
	public double GetButtonTimePressed(int actionId) { }

	// RVA: 0x189CEC0 Offset: 0x189B4C0 VA: 0x18189CEC0
	public double GetButtonTimeUnpressed(string actionName) { }

	// RVA: 0x189CF90 Offset: 0x189B590 VA: 0x18189CF90
	public double GetButtonTimeUnpressed(int actionId) { }

	// RVA: 0x18A0980 Offset: 0x189EF80 VA: 0x1818A0980
	public bool GetNegativeButton(string actionName) { }

	// RVA: 0x18A0A50 Offset: 0x189F050 VA: 0x1818A0A50
	public bool GetNegativeButton(int actionId) { }

	// RVA: 0x189E860 Offset: 0x189CE60 VA: 0x18189E860
	public bool GetNegativeButtonDown(string actionName) { }

	// RVA: 0x189E930 Offset: 0x189CF30 VA: 0x18189E930
	public bool GetNegativeButtonDown(int actionId) { }

	// RVA: 0x18A08B0 Offset: 0x189EEB0 VA: 0x1818A08B0
	public bool GetNegativeButtonUp(string actionName) { }

	// RVA: 0x18A07E0 Offset: 0x189EDE0 VA: 0x1818A07E0
	public bool GetNegativeButtonUp(int actionId) { }

	// RVA: 0x189EFB0 Offset: 0x189D5B0 VA: 0x18189EFB0
	public bool GetNegativeButtonPrev(string actionName) { }

	// RVA: 0x189EEE0 Offset: 0x189D4E0 VA: 0x18189EEE0
	public bool GetNegativeButtonPrev(int actionId) { }

	// RVA: 0x189F970 Offset: 0x189DF70 VA: 0x18189F970
	public bool GetNegativeButtonSinglePressHold(int actionId) { }

	// RVA: 0x189F8A0 Offset: 0x189DEA0 VA: 0x18189F8A0
	public bool GetNegativeButtonSinglePressHold(string actionName) { }

	// RVA: 0x189F700 Offset: 0x189DD00 VA: 0x18189F700
	public bool GetNegativeButtonSinglePressDown(int actionId) { }

	// RVA: 0x189F7D0 Offset: 0x189DDD0 VA: 0x18189F7D0
	public bool GetNegativeButtonSinglePressDown(string actionName) { }

	// RVA: 0x189FB10 Offset: 0x189E110 VA: 0x18189FB10
	public bool GetNegativeButtonSinglePressUp(int actionId) { }

	// RVA: 0x189FA40 Offset: 0x189E040 VA: 0x18189FA40
	public bool GetNegativeButtonSinglePressUp(string actionName) { }

	// RVA: 0x189E420 Offset: 0x189CA20 VA: 0x18189E420
	public bool GetNegativeButtonDoublePressHold(string actionName, float speed) { }

	// RVA: 0x189E340 Offset: 0x189C940 VA: 0x18189E340
	public bool GetNegativeButtonDoublePressHold(int actionId, float speed) { }

	// RVA: 0x189E270 Offset: 0x189C870 VA: 0x18189E270
	public bool GetNegativeButtonDoublePressHold(string actionName) { }

	// RVA: 0x189E1A0 Offset: 0x189C7A0 VA: 0x18189E1A0
	public bool GetNegativeButtonDoublePressHold(int actionId) { }

	// RVA: 0x189E0C0 Offset: 0x189C6C0 VA: 0x18189E0C0
	public bool GetNegativeButtonDoublePressDown(string actionName, float speed) { }

	// RVA: 0x189DE40 Offset: 0x189C440 VA: 0x18189DE40
	public bool GetNegativeButtonDoublePressDown(int actionId, float speed) { }

	// RVA: 0x189DF20 Offset: 0x189C520 VA: 0x18189DF20
	public bool GetNegativeButtonDoublePressDown(string actionName) { }

	// RVA: 0x189DFF0 Offset: 0x189C5F0 VA: 0x18189DFF0
	public bool GetNegativeButtonDoublePressDown(int actionId) { }

	// RVA: 0x189E6B0 Offset: 0x189CCB0 VA: 0x18189E6B0
	public bool GetNegativeButtonDoublePressUp(string actionName, float speed) { }

	// RVA: 0x189E5D0 Offset: 0x189CBD0 VA: 0x18189E5D0
	public bool GetNegativeButtonDoublePressUp(int actionId, float speed) { }

	// RVA: 0x189E790 Offset: 0x189CD90 VA: 0x18189E790
	public bool GetNegativeButtonDoublePressUp(string actionName) { }

	// RVA: 0x189E500 Offset: 0x189CB00 VA: 0x18189E500
	public bool GetNegativeButtonDoublePressUp(int actionId) { }

	// RVA: 0x18A0540 Offset: 0x189EB40 VA: 0x1818A0540
	public bool GetNegativeButtonTimedPress(string actionName, float time) { }

	// RVA: 0x18A0460 Offset: 0x189EA60 VA: 0x1818A0460
	public bool GetNegativeButtonTimedPress(int actionId, float time) { }

	// RVA: 0x18A0700 Offset: 0x189ED00 VA: 0x1818A0700
	public bool GetNegativeButtonTimedPress(string actionName, float time, float expireIn) { }

	// RVA: 0x18A0620 Offset: 0x189EC20 VA: 0x1818A0620
	public bool GetNegativeButtonTimedPress(int actionId, float time, float expireIn) { }

	// RVA: 0x189FF20 Offset: 0x189E520 VA: 0x18189FF20
	public bool GetNegativeButtonTimedPressDown(string actionName, float time) { }

	// RVA: 0x18A0000 Offset: 0x189E600 VA: 0x1818A0000
	public bool GetNegativeButtonTimedPressDown(int actionId, float time) { }

	// RVA: 0x18A01C0 Offset: 0x189E7C0 VA: 0x1818A01C0
	public bool GetNegativeButtonTimedPressUp(string actionName, float time) { }

	// RVA: 0x18A0380 Offset: 0x189E980 VA: 0x1818A0380
	public bool GetNegativeButtonTimedPressUp(int actionId, float time) { }

	// RVA: 0x18A02A0 Offset: 0x189E8A0 VA: 0x1818A02A0
	public bool GetNegativeButtonTimedPressUp(string actionName, float time, float expireIn) { }

	// RVA: 0x18A00E0 Offset: 0x189E6E0 VA: 0x1818A00E0
	public bool GetNegativeButtonTimedPressUp(int actionId, float time, float expireIn) { }

	// RVA: 0x189F630 Offset: 0x189DC30 VA: 0x18189F630
	public bool GetNegativeButtonShortPress(string actionName) { }

	// RVA: 0x189F560 Offset: 0x189DB60 VA: 0x18189F560
	public bool GetNegativeButtonShortPress(int actionId) { }

	// RVA: 0x189F2F0 Offset: 0x189D8F0 VA: 0x18189F2F0
	public bool GetNegativeButtonShortPressDown(string actionName) { }

	// RVA: 0x189F220 Offset: 0x189D820 VA: 0x18189F220
	public bool GetNegativeButtonShortPressDown(int actionId) { }

	// RVA: 0x189F3C0 Offset: 0x189D9C0 VA: 0x18189F3C0
	public bool GetNegativeButtonShortPressUp(string actionName) { }

	// RVA: 0x189F490 Offset: 0x189DA90 VA: 0x18189F490
	public bool GetNegativeButtonShortPressUp(int actionId) { }

	// RVA: 0x189EE10 Offset: 0x189D410 VA: 0x18189EE10
	public bool GetNegativeButtonLongPress(string actionName) { }

	// RVA: 0x189ED40 Offset: 0x189D340 VA: 0x18189ED40
	public bool GetNegativeButtonLongPress(int actionId) { }

	// RVA: 0x189EAD0 Offset: 0x189D0D0 VA: 0x18189EAD0
	public bool GetNegativeButtonLongPressDown(string actionName) { }

	// RVA: 0x189EA00 Offset: 0x189D000 VA: 0x18189EA00
	public bool GetNegativeButtonLongPressDown(int actionId) { }

	// RVA: 0x189EC70 Offset: 0x189D270 VA: 0x18189EC70
	public bool GetNegativeButtonLongPressUp(string actionName) { }

	// RVA: 0x189EBA0 Offset: 0x189D1A0 VA: 0x18189EBA0
	public bool GetNegativeButtonLongPressUp(int actionId) { }

	// RVA: 0x189F150 Offset: 0x189D750 VA: 0x18189F150
	public bool GetNegativeButtonRepeating(string actionName) { }

	// RVA: 0x189F080 Offset: 0x189D680 VA: 0x18189F080
	public bool GetNegativeButtonRepeating(int actionId) { }

	// RVA: 0x1898B80 Offset: 0x1897180 VA: 0x181898B80
	public bool GetAnyNegativeButton() { }

	// RVA: 0x18989A0 Offset: 0x1896FA0 VA: 0x1818989A0
	public bool GetAnyNegativeButtonDown() { }

	// RVA: 0x1898AE0 Offset: 0x18970E0 VA: 0x181898AE0
	public bool GetAnyNegativeButtonUp() { }

	// RVA: 0x1898A40 Offset: 0x1897040 VA: 0x181898A40
	public bool GetAnyNegativeButtonPrev() { }

	// RVA: 0x189FCB0 Offset: 0x189E2B0 VA: 0x18189FCB0
	public double GetNegativeButtonTimePressed(string actionName) { }

	// RVA: 0x189FBE0 Offset: 0x189E1E0 VA: 0x18189FBE0
	public double GetNegativeButtonTimePressed(int actionId) { }

	// RVA: 0x189FD80 Offset: 0x189E380 VA: 0x18189FD80
	public double GetNegativeButtonTimeUnpressed(string actionName) { }

	// RVA: 0x189FE50 Offset: 0x189E450 VA: 0x18189FE50
	public double GetNegativeButtonTimeUnpressed(int actionId) { }

	// RVA: 0x189AD40 Offset: 0x1899340 VA: 0x18189AD40
	public float GetAxis(string actionName) { }

	// RVA: 0x189AE10 Offset: 0x1899410 VA: 0x18189AE10
	public float GetAxis(int actionId) { }

	// RVA: 0x189A860 Offset: 0x1898E60 VA: 0x18189A860
	public float GetAxisRaw(string actionName) { }

	// RVA: 0x189A930 Offset: 0x1898F30 VA: 0x18189A930
	public float GetAxisRaw(int actionId) { }

	// RVA: 0x1899DD0 Offset: 0x18983D0 VA: 0x181899DD0
	public float GetAxisPrev(string actionName) { }

	// RVA: 0x1899D00 Offset: 0x1898300 VA: 0x181899D00
	public float GetAxisPrev(int actionId) { }

	// RVA: 0x189A450 Offset: 0x1898A50 VA: 0x18189A450
	public float GetAxisRawPrev(string actionName) { }

	// RVA: 0x189A380 Offset: 0x1898980 VA: 0x18189A380
	public float GetAxisRawPrev(int actionId) { }

	// RVA: 0x1899B60 Offset: 0x1898160 VA: 0x181899B60
	public float GetAxisDelta(string actionName) { }

	// RVA: 0x1899C30 Offset: 0x1898230 VA: 0x181899C30
	public float GetAxisDelta(int actionId) { }

	// RVA: 0x189A2B0 Offset: 0x18988B0 VA: 0x18189A2B0
	public float GetAxisRawDelta(string actionName) { }

	// RVA: 0x189A1E0 Offset: 0x18987E0 VA: 0x18189A1E0
	public float GetAxisRawDelta(int actionId) { }

	// RVA: 0x18996A0 Offset: 0x1897CA0 VA: 0x1818996A0
	public Vector2 GetAxis2D(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x1899520 Offset: 0x1897B20 VA: 0x181899520
	public Vector2 GetAxis2D(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x1898DA0 Offset: 0x18973A0 VA: 0x181898DA0
	public Vector2 GetAxis2DPrev(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x1898C20 Offset: 0x1897220 VA: 0x181898C20
	public Vector2 GetAxis2DPrev(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x18993A0 Offset: 0x18979A0 VA: 0x1818993A0
	public Vector2 GetAxis2DRaw(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x1899220 Offset: 0x1897820 VA: 0x181899220
	public Vector2 GetAxis2DRaw(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x1898F20 Offset: 0x1897520 VA: 0x181898F20
	public Vector2 GetAxis2DRawPrev(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x18990A0 Offset: 0x18976A0 VA: 0x1818990A0
	public Vector2 GetAxis2DRawPrev(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x189AA00 Offset: 0x1899000 VA: 0x18189AA00
	public double GetAxisTimeActive(string actionName) { }

	// RVA: 0x189AAD0 Offset: 0x18990D0 VA: 0x18189AAD0
	public double GetAxisTimeActive(int actionId) { }

	// RVA: 0x189AC70 Offset: 0x1899270 VA: 0x18189AC70
	public double GetAxisTimeInactive(string actionName) { }

	// RVA: 0x189ABA0 Offset: 0x18991A0 VA: 0x18189ABA0
	public double GetAxisTimeInactive(int actionId) { }

	// RVA: 0x189A520 Offset: 0x1898B20 VA: 0x18189A520
	public double GetAxisRawTimeActive(string actionName) { }

	// RVA: 0x189A5F0 Offset: 0x1898BF0 VA: 0x18189A5F0
	public double GetAxisRawTimeActive(int actionId) { }

	// RVA: 0x189A790 Offset: 0x1898D90 VA: 0x18189A790
	public double GetAxisRawTimeInactive(string actionName) { }

	// RVA: 0x189A6C0 Offset: 0x1898CC0 VA: 0x18189A6C0
	public double GetAxisRawTimeInactive(int actionId) { }

	// RVA: 0x1899A90 Offset: 0x1898090 VA: 0x181899A90
	public AxisCoordinateMode GetAxisCoordinateMode(string actionName) { }

	// RVA: 0x18999C0 Offset: 0x1897FC0 VA: 0x1818999C0
	public AxisCoordinateMode GetAxisCoordinateMode(int actionId) { }

	// RVA: 0x189A110 Offset: 0x1898710 VA: 0x18189A110
	public AxisCoordinateMode GetAxisRawCoordinateMode(string actionName) { }

	// RVA: 0x189A040 Offset: 0x1898640 VA: 0x18189A040
	public AxisCoordinateMode GetAxisRawCoordinateMode(int actionId) { }

	// RVA: 0x1899820 Offset: 0x1897E20 VA: 0x181899820
	public AxisCoordinateMode GetAxisCoordinateModePrev(string actionName) { }

	// RVA: 0x18998F0 Offset: 0x1897EF0 VA: 0x1818998F0
	public AxisCoordinateMode GetAxisCoordinateModePrev(int actionId) { }

	// RVA: 0x1899F70 Offset: 0x1898570 VA: 0x181899F70
	public AxisCoordinateMode GetAxisRawCoordinateModePrev(string actionName) { }

	// RVA: 0x1899EA0 Offset: 0x18984A0 VA: 0x181899EA0
	public AxisCoordinateMode GetAxisRawCoordinateModePrev(int actionId) { }

	// RVA: 0x189DC60 Offset: 0x189C260 VA: 0x18189DC60
	public IList<InputActionSourceData> GetCurrentInputSources(string actionName) { }

	// RVA: 0x189DD50 Offset: 0x189C350 VA: 0x18189DD50
	public IList<InputActionSourceData> GetCurrentInputSources(int actionId) { }

	// RVA: 0x18A1320 Offset: 0x189F920 VA: 0x1818A1320
	public bool IsCurrentInputSource(string actionName, ControllerType controllerType) { }

	// RVA: 0x18A1240 Offset: 0x189F840 VA: 0x1818A1240
	public bool IsCurrentInputSource(int actionId, ControllerType controllerType) { }

	// RVA: 0x18A1080 Offset: 0x189F680 VA: 0x1818A1080
	public bool IsCurrentInputSource(string actionName, ControllerType controllerType, int controllerId) { }

	// RVA: 0x18A1400 Offset: 0x189FA00 VA: 0x1818A1400
	public bool IsCurrentInputSource(int actionId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x18A0FA0 Offset: 0x189F5A0 VA: 0x1818A0FA0
	public bool IsCurrentInputSource(string actionName, Controller controller) { }

	// RVA: 0x18A1160 Offset: 0x189F760 VA: 0x1818A1160
	public bool IsCurrentInputSource(int actionId, Controller controller) { }

	// RVA: 0x1898370 Offset: 0x1896970 VA: 0x181898370
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop) { }

	// RVA: 0x1897F90 Offset: 0x1896590 VA: 0x181897F90
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId) { }

	// RVA: 0x1897A90 Offset: 0x1896090 VA: 0x181897A90
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName) { }

	// RVA: 0x1897E50 Offset: 0x1896450 VA: 0x181897E50
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType) { }

	// RVA: 0x18985F0 Offset: 0x1896BF0 VA: 0x1818985F0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId) { }

	// RVA: 0x1898200 Offset: 0x1896800 VA: 0x181898200
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName) { }

	// RVA: 0x18980C0 Offset: 0x18966C0 VA: 0x1818980C0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, object[] arguments) { }

	// RVA: 0x18984A0 Offset: 0x1896AA0 VA: 0x1818984A0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId, object[] arguments) { }

	// RVA: 0x1897CD0 Offset: 0x18962D0 VA: 0x181897CD0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName, object[] arguments) { }

	// RVA: 0x18A1980 Offset: 0x189FF80 VA: 0x1818A1980
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback) { }

	// RVA: 0x18A1A90 Offset: 0x18A0090 VA: 0x1818A1A90
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, int actionId) { }

	// RVA: 0x18A1740 Offset: 0x189FD40 VA: 0x1818A1740
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, string actionName) { }

	// RVA: 0x18A14E0 Offset: 0x189FAE0 VA: 0x1818A14E0
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop) { }

	// RVA: 0x18A2060 Offset: 0x18A0660 VA: 0x1818A2060
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType) { }

	// RVA: 0x18A1F30 Offset: 0x18A0530 VA: 0x1818A1F30
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId) { }

	// RVA: 0x18A1BC0 Offset: 0x18A01C0 VA: 0x1818A1BC0
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName) { }

	// RVA: 0x18A1610 Offset: 0x189FC10 VA: 0x1818A1610
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, int actionId) { }

	// RVA: 0x18A2530 Offset: 0x18A0B30 VA: 0x1818A2530
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, string actionName) { }

	// RVA: 0x18A1E00 Offset: 0x18A0400 VA: 0x1818A1E00
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType) { }

	// RVA: 0x18A2190 Offset: 0x18A0790 VA: 0x1818A2190
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId) { }

	// RVA: 0x18A22D0 Offset: 0x18A08D0 VA: 0x1818A22D0
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName) { }

	// RVA: 0x1898620 Offset: 0x1896C20 VA: 0x181898620
	public void ClearInputEventDelegates() { }

	// RVA: 0x18A29E0 Offset: 0x18A0FE0 VA: 0x1818A29E0
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x18A29C0 Offset: 0x18A0FC0 VA: 0x1818A29C0
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x18A2A00 Offset: 0x18A1000 VA: 0x1818A2A00
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x18A27A0 Offset: 0x18A0DA0 VA: 0x1818A27A0
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x18A0D70 Offset: 0x189F370 VA: 0x1818A0D70
	public float GetVibration(int motorIndex) { }

	// RVA: 0x18A2A20 Offset: 0x18A1020 VA: 0x1818A2A20
	public void StopVibration() { }

	// RVA: 0x18A0F70 Offset: 0x189F570 VA: 0x1818A0F70
	internal void mcRbFxIeijpbtpUADZCUDqXFqNaSA() { }

	// RVA: 0x18A0F70 Offset: 0x189F570 VA: 0x1818A0F70
	private void IIUXJovoSSaICiMBtGjvGkMBmyhhc() { }
}

// Namespace: Rewired
public static class ReInput // TypeDefIndex: 2182
{
	// Fields
	[CustomObfuscation(rename = False)]
	internal const int programVersion1 = 1;
	[CustomObfuscation(rename = False)]
	internal const int programVersion2 = 1;
	[CustomObfuscation(rename = False)]
	internal const int programVersion3 = 59;
	[CustomObfuscation(rename = False)]
	internal const int programVersion4 = 0;
	[CustomObfuscation(rename = False)]
	internal const int dataVersion = 1;
	[CustomObfuscation(rename = False)]
	internal const bool isTrial = False;
	[CustomObfuscation(rename = False)]
	internal const string majorBranch = "U2023";
	private static InputManager_Base opFLklNxznlGmaBxjDWTrcengRhf; // 0x0
	private static PlatformInputManager fkSqyEoBXmZbktvAoWHGzsEfCvkx; // 0x8
	internal static LNoVScqLIaVgcEZncAPtalYUnldD sCEeWKKKGsiTBubOBJiMeUByAWBkA; // 0x10
	internal static NtLLFFJOcFyvZRAWZFOVWxCAkgNv NIcIKzMsdHTrYgxdKlvUJdhmSWnq; // 0x18
	internal static dVAByoXKtOXwKxgqDcLtnCbJXcVr AEJjrwrcpqpGwBKrAvxtlpIwWvQx; // 0x20
	private static ControllerDataFiles XwHQzyAkXlzITwDPKeLBqmcCPBzy; // 0x28
	private static UserData mskbWAgXRWSDcAOuXkFDzdyGVDdfA; // 0x30
	private static bool iDoaxepFyYCUwmDGjxXRIVvgLboF; // 0x38
	private static ConfigVars AYdchkuWcYrjfPxeOhQuosvpLIJi; // 0x40
	private static UpdateLoopType jJrzSsjcHSzjrGKcneaGnluNxyhH; // 0x48
	private static bool MeqYfJSRkaFHhngkINGpKJHaIfXEA; // 0x4C
	private static Platform QyqiIwEKtdNOJKdYClEPkQDWDfrA; // 0x50
	private static WebplayerPlatform dUCODYNhhXyPxlHqMhIftHLIHTWS; // 0x54
	private static EditorPlatform DtrYYGjIUehvROekefCpjMdsqHiBA; // 0x58
	private static bool HjHyJiqikFYztNqhvpDhSKMnunHo; // 0x5C
	private static TimerAbs ijOTydnWEwikUWVTmQilPeMHFQFu; // 0x60
	private static ReInput.NXntoKYmASjXZXGYiFiFOWHQBmRV hjluCJiHVMMtFPgSQToXRLsPkCsQ; // 0x68
	private static string AQilkyfLREIoVLQophOpcJFylabN; // 0x70
	private static bool UwJpGSsMSugdDvrfovOICzxHpTec; // 0x78
	private static bool dsTcFNIPcwMfaBmHrIJXakWFNBwI; // 0x79
	private static bool fuTplxJRljOMBtcpAFVMlKVtwQcA; // 0x7A
	private static int euIZBNlLOQNuOYyQiQmjvdoPYGiJ; // 0x7C
	[CustomObfuscation(rename = False)]
	internal static int _id; // 0x80
	private static int YjOBdCChsYkvrcuOydVkddWCwddFc; // 0x84
	private static int xXJmSjqchuESCBrjlsLxmjrVKRvx; // 0x88
	private static bool sYGnHMzOABOYJeKEFsTCtCYXiExc; // 0x8C
	private static readonly ReInput.UnityTouch GBCbeypusZcLlHcnvNsLnjCJSwECb; // 0x90
	private static readonly ReInput.PlayerHelper JQhUXoyvqotSJVHopftAxrgjgYChA; // 0x98
	private static readonly ReInput.ControllerHelper oDYzPKcIaFTGnHKoLBJjiqpmmecRA; // 0xA0
	private static readonly ReInput.MappingHelper FrqxtNAEBhfRjHzwHfSFVuvxXjTt; // 0xA8
	private static readonly ReInput.TimeHelper ZNRaKiYPMwyNBsFAUwvpjcWSwbMr; // 0xB0
	private static readonly ReInput.ConfigHelper ZyBoYCbNsHeqlelJNMjHoYFNvVnI; // 0xB8
	private static readonly ReInput.LocalizationHelper xlGrjcoxtebmQaKJSGWLfWeAbpvl; // 0xC0
	private static readonly ReInput.GlyphHelper klKbMzdBNSMSFZfaelNEskbeHplpA; // 0xC8
	private static iyoobKLbmIVXtqfUoYWeQpHPutOI sDfvTwiIzDJPnArshdlWtYDSMcSd; // 0xD0
	private static UserDataStore MPTRtAOQiupDcrGOlALcvlhWOAXq; // 0xD8
	private static IControllerAssigner BdjufxUlUqJhMWSNQkrEcjEJQOgq; // 0xE0
	private static ReInput.grarPbZeaWHeNWYzLDyprkJXqKlh MDNZhtFkmtqnGWplopTteeTfYNQg; // 0xE8
	private static SafeAction<ControllerStatusChangedEventArgs> KdfvjKfIHogWzCsRzshriBvXTRRu; // 0xF0
	private static SafeAction<ControllerStatusChangedEventArgs> vPPhLkgAUleYfVHAVqzbFjirEkPp; // 0xF8
	private static SafeAction<ControllerStatusChangedEventArgs> EOZCwJaVLPbAGUearVybykdSlXkd; // 0x100
	private static SafeAction TRBDGWitkxKvCNCgXIJxBRRuIseD; // 0x108
	private static SafeAction lcbUurYcafDSLrlFKbNTBzxbNCxiA; // 0x110
	private static SafeAction bqBGwCwObvMidvClyWtHuqCTMJIP; // 0x118
	private static SafeAction nJPAUdayCGfTIPMAUiVOecggBnyNB; // 0x120
	private static SafeAction jMxYbcpGLnWPAEdTKJXuhBQYGNiZ; // 0x128
	[CustomObfuscation(rename = False)]
	private static Action<bool> _ApplicationFocusChangedEvent; // 0x130
	[CustomObfuscation(rename = False)]
	private static Action<bool> _ApplicationPauseChangedEvent; // 0x138
	private static Action vcejenKXjgGMBSeEUOIAWXUvRSOH; // 0x140
	private static Action<UpdateLoopType> jgtKTEAUOXMhJyJmtYvvBBZzVOFh; // 0x148
	private static Action<UpdateLoopType> JZggQsDKJfuWPFJlUDXjAJRhcamFc; // 0x150
	private static Action<UpdateLoopType> cZxOrjYXpBHsZIgRvWZYqswjgIHv; // 0x158
	private static Action TINdwidinInOYpLXYUQuMOqQFjqz; // 0x160
	private static Action<bool> JmdBsbHqyMSfWQDTPqmkAUxBiMBQA; // 0x168
	private static Action<bool> yXMdjJneXMgaiEEZTsLoOYLdlgzZ; // 0x170
	private static Action<bool> OhaDNawXqEDPRlKHRecynaKPmpZr; // 0x178
	private static Action<FullScreenMode> EnMxyvbxriamjMTPrmbBcPEDAiRy; // 0x180
	private static Action VPMgwkNBgkTJEvqsapenbhWskTAG; // 0x188
	private static Action<bool> xnmwjmMXGEEUMwNzJWcOqflLxQJX; // 0x190
	[CustomObfuscation(rename = False)]
	internal static double unscaledDeltaTime; // 0x198
	[CustomObfuscation(rename = False)]
	internal static double unscaledTime; // 0x1A0
	[CustomObfuscation(rename = False)]
	internal static double unscaledTimePrev; // 0x1A8
	[CustomObfuscation(rename = False)]
	internal static uint currentFrame; // 0x1B0
	[CustomObfuscation(rename = False)]
	internal static uint previousFrame; // 0x1B4
	[CustomObfuscation(rename = False)]
	internal static uint absFrame; // 0x1B8

	// Properties
	private static iyoobKLbmIVXtqfUoYWeQpHPutOI HXPIeDXtdkTpNBCcNheCgSjwcfSP { get; }
	public static ReInput.PlayerHelper players { get; }
	public static ReInput.ControllerHelper controllers { get; }
	public static ReInput.MappingHelper mapping { get; }
	public static ReInput.UnityTouch touch { get; }
	public static ReInput.TimeHelper time { get; }
	public static IUserDataStore userDataStore { get; }
	public static ReInput.ConfigHelper configuration { get; }
	public static ReInput.LocalizationHelper localization { get; }
	public static ReInput.GlyphHelper glyphs { get; }
	public static string programVersion { get; }
	public static bool usingUnityInput { get; }
	public static bool unityJoystickIdentificationRequired { get; }
	public static bool isReady { get; }
	[CustomObfuscation(rename = False)]
	internal static int id { get; }
	[CustomObfuscation(rename = False)]
	internal static bool initialized { get; }
	[CustomObfuscation(rename = False)]
	internal static UpdateLoopType currentUpdateLoop { get; }
	[CustomObfuscation(rename = False)]
	internal static ConfigVars configVars { get; }
	[CustomObfuscation(rename = False)]
	internal static IConfigVars_Internal pluginConfigVars { get; }
	[CustomObfuscation(rename = False)]
	internal static UserData UserData { get; }
	[CustomObfuscation(rename = False)]
	internal static Platform currentPlatform { get; }
	[CustomObfuscation(rename = False)]
	internal static WebplayerPlatform webplayerPlatform { get; }
	[CustomObfuscation(rename = False)]
	internal static EditorPlatform editorPlatform { get; }
	[CustomObfuscation(rename = False)]
	internal static bool checkNeverPressed { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isEditor { get; }
	[CustomObfuscation(rename = False)]
	internal static Guid defaultHardwareJoystickMapGuid { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isRunningInEditMode { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isEditorPaused { get; }
	[CustomObfuscation(rename = False)]
	internal static float unityUnscaledDeltaTime { get; }
	[CustomObfuscation(rename = False)]
	internal static float unityUnscaledDeltaTimePrev { get; }
	[CustomObfuscation(rename = False)]
	internal static double realTime { get; }
	[CustomObfuscation(rename = False)]
	internal static int currentUnityFrame { get; }
	private static bool AsePDcULXCoJbDwczmxAfWFQSKbg { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isAllowedEditorWindowFocused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isUnityEditorFocused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isWindowsStandaloneWebplayerOrEditorPlatform { get; }
	private static bool efuAdNJQNnLbFAyqfFkHTCRmSeUcb { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationIsFocused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationIsPaused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationIsFullScreen { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationRunInBackground { get; }
	[CustomObfuscation(rename = False)]
	internal static bool timeScaleIsPaused { get; }
	[CustomObfuscation(rename = False)]
	internal static InputManager_Base rewiredInputManager { get; }
	[CustomObfuscation(rename = False)]
	internal static PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	internal static IControllerAssigner controllerAssigner { get; set; }
	[CustomObfuscation(rename = False)]
	internal static RewiredVersion rewiredVersion { get; }
	[CustomObfuscation(rename = False)]
	internal static int timeScalePauseChangedCount { get; }

	// Methods

	// RVA: 0x18D7EE0 Offset: 0x18D64E0 VA: 0x1818D7EE0
	private static void .cctor() { }

	// RVA: 0x18D4C50 Offset: 0x18D3250 VA: 0x1818D4C50
	private static iyoobKLbmIVXtqfUoYWeQpHPutOI PBLIPaojrQJqhfLkGulXyOMmyHBQ() { }

	// RVA: 0x18D8E40 Offset: 0x18D7440 VA: 0x1818D8E40
	public static void add_ControllerConnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x18DC520 Offset: 0x18DAB20 VA: 0x1818DC520
	public static void remove_ControllerConnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x18D8FA0 Offset: 0x18D75A0 VA: 0x1818D8FA0
	public static void add_ControllerPreDisconnectEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x18DC680 Offset: 0x18DAC80 VA: 0x1818DC680
	public static void remove_ControllerPreDisconnectEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x18D8EF0 Offset: 0x18D74F0 VA: 0x1818D8EF0
	public static void add_ControllerDisconnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x18DC5D0 Offset: 0x18DABD0 VA: 0x1818DC5D0
	public static void remove_ControllerDisconnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x18D93A0 Offset: 0x18D79A0 VA: 0x1818D93A0
	public static void add_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x18DCA80 Offset: 0x18DB080 VA: 0x1818DCA80
	public static void remove_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x18D9260 Offset: 0x18D7860 VA: 0x1818D9260
	public static void add_EditorRecompileEvent(Action value) { }

	// RVA: 0x18DC940 Offset: 0x18DAF40 VA: 0x1818DC940
	public static void remove_EditorRecompileEvent(Action value) { }

	// RVA: 0x18D9540 Offset: 0x18D7B40 VA: 0x1818D9540
	public static void add_PreShutDownEvent(Action value) { }

	// RVA: 0x18DCC20 Offset: 0x18DB220 VA: 0x1818DCC20
	public static void remove_PreShutDownEvent(Action value) { }

	// RVA: 0x18D96E0 Offset: 0x18D7CE0 VA: 0x1818D96E0
	public static void add_ShutDownEvent(Action value) { }

	// RVA: 0x18DCDC0 Offset: 0x18DB3C0 VA: 0x1818DCDC0
	public static void remove_ShutDownEvent(Action value) { }

	// RVA: 0x18D9300 Offset: 0x18D7900 VA: 0x1818D9300
	public static void add_InitializedEvent(Action value) { }

	// RVA: 0x18DC9E0 Offset: 0x18DAFE0 VA: 0x1818DC9E0
	public static void remove_InitializedEvent(Action value) { }

	// RVA: 0x18D87E0 Offset: 0x18D6DE0 VA: 0x1818D87E0
	internal static void add_ApplicationFocusChangedEvent(Action<bool> value) { }

	// RVA: 0x18DBEC0 Offset: 0x18DA4C0 VA: 0x1818DBEC0
	internal static void remove_ApplicationFocusChangedEvent(Action<bool> value) { }

	// RVA: 0x18D8B10 Offset: 0x18D7110 VA: 0x1818D8B10
	internal static void add_ApplicationPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x18DC1F0 Offset: 0x18DA7F0 VA: 0x1818DC1F0
	internal static void remove_ApplicationPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x18D9050 Offset: 0x18D7650 VA: 0x1818D9050
	internal static void add_EarlyUpdateEvent(Action value) { }

	// RVA: 0x18DC730 Offset: 0x18DAD30 VA: 0x1818DC730
	internal static void remove_EarlyUpdateEvent(Action value) { }

	// RVA: 0x18D8D30 Offset: 0x18D7330 VA: 0x1818D8D30
	internal static void add_BeforeTimeManagerUpdateEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x18DC410 Offset: 0x18DAA10 VA: 0x1818DC410
	internal static void remove_BeforeTimeManagerUpdateEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x18D99A0 Offset: 0x18D7FA0 VA: 0x1818D99A0
	internal static void add_UpdateStartedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x18DD080 Offset: 0x18DB680 VA: 0x1818DD080
	internal static void remove_UpdateStartedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x18D9890 Offset: 0x18D7E90 VA: 0x1818D9890
	internal static void add_UpdateEndedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x18DCF70 Offset: 0x18DB570 VA: 0x1818DCF70
	internal static void remove_UpdateEndedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x18D9440 Offset: 0x18D7A40 VA: 0x1818D9440
	internal static void add_LateUpdateEvent(Action value) { }

	// RVA: 0x18DCB20 Offset: 0x18DB120 VA: 0x1818DCB20
	internal static void remove_LateUpdateEvent(Action value) { }

	// RVA: 0x18D8A00 Offset: 0x18D7000 VA: 0x1818D8A00
	internal static void add_ApplicationIsFullScreenChangedEvent(Action<bool> value) { }

	// RVA: 0x18DC0E0 Offset: 0x18DA6E0 VA: 0x1818DC0E0
	internal static void remove_ApplicationIsFullScreenChangedEvent(Action<bool> value) { }

	// RVA: 0x18D8C20 Offset: 0x18D7220 VA: 0x1818D8C20
	internal static void add_ApplicationRunInBackgroundChangedEvent(Action<bool> value) { }

	// RVA: 0x18DC300 Offset: 0x18DA900 VA: 0x1818DC300
	internal static void remove_ApplicationRunInBackgroundChangedEvent(Action<bool> value) { }

	// RVA: 0x18D9780 Offset: 0x18D7D80 VA: 0x1818D9780
	internal static void add_TimeScalePauseChangedEvent(Action<bool> value) { }

	// RVA: 0x18DCE60 Offset: 0x18DB460 VA: 0x1818DCE60
	internal static void remove_TimeScalePauseChangedEvent(Action<bool> value) { }

	// RVA: 0x18D88F0 Offset: 0x18D6EF0 VA: 0x1818D88F0
	internal static void add_ApplicationFullScreenModeChangedEvent(Action<FullScreenMode> value) { }

	// RVA: 0x18DBFD0 Offset: 0x18DA5D0 VA: 0x1818DBFD0
	internal static void remove_ApplicationFullScreenModeChangedEvent(Action<FullScreenMode> value) { }

	// RVA: 0x18D95E0 Offset: 0x18D7BE0 VA: 0x1818D95E0
	internal static void add_SceneLoadedEvent(Action value) { }

	// RVA: 0x18DCCC0 Offset: 0x18DB2C0 VA: 0x1818DCCC0
	internal static void remove_SceneLoadedEvent(Action value) { }

	// RVA: 0x18D9150 Offset: 0x18D7750 VA: 0x1818D9150
	internal static void add_EditorPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x18DC830 Offset: 0x18DAE30 VA: 0x1818DC830
	internal static void remove_EditorPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x18DAF80 Offset: 0x18D9580 VA: 0x1818DAF80
	public static ReInput.PlayerHelper get_players() { }

	// RVA: 0x18DA5A0 Offset: 0x18D8BA0 VA: 0x1818DA5A0
	public static ReInput.ControllerHelper get_controllers() { }

	// RVA: 0x18DAED0 Offset: 0x18D94D0 VA: 0x1818DAED0
	public static ReInput.MappingHelper get_mapping() { }

	// RVA: 0x18DB5F0 Offset: 0x18D9BF0 VA: 0x1818DB5F0
	public static ReInput.UnityTouch get_touch() { }

	// RVA: 0x18DB540 Offset: 0x18D9B40 VA: 0x1818DB540
	public static ReInput.TimeHelper get_time() { }

	// RVA: 0x18DB900 Offset: 0x18D9F00 VA: 0x1818DB900
	public static IUserDataStore get_userDataStore() { }

	// RVA: 0x18DA490 Offset: 0x18D8A90 VA: 0x1818DA490
	public static ReInput.ConfigHelper get_configuration() { }

	// RVA: 0x18DAE20 Offset: 0x18D9420 VA: 0x1818DAE20
	public static ReInput.LocalizationHelper get_localization() { }

	// RVA: 0x18DA890 Offset: 0x18D8E90 VA: 0x1818DA890
	public static ReInput.GlyphHelper get_glyphs() { }

	// RVA: 0x18DB150 Offset: 0x18D9750 VA: 0x1818DB150
	public static string get_programVersion() { }

	// RVA: 0x18DB9B0 Offset: 0x18D9FB0 VA: 0x1818DB9B0
	public static bool get_usingUnityInput() { }

	// RVA: 0x18DB6A0 Offset: 0x18D9CA0 VA: 0x1818DB6A0
	public static bool get_unityJoystickIdentificationRequired() { }

	// RVA: 0x18DABC0 Offset: 0x18D91C0 VA: 0x1818DABC0
	public static bool get_isReady() { }

	// RVA: 0x18D60B0 Offset: 0x18D46B0 VA: 0x1818D60B0
	public static void Update() { }

	// RVA: 0x18D50A0 Offset: 0x18D36A0 VA: 0x1818D50A0
	public static void Reset() { }

	// RVA: 0x18DA940 Offset: 0x18D8F40 VA: 0x1818DA940
	internal static int get_id() { }

	// RVA: 0x18DA9A0 Offset: 0x18D8FA0 VA: 0x1818DA9A0
	internal static bool get_initialized() { }

	// RVA: 0x18DA730 Offset: 0x18D8D30 VA: 0x1818DA730
	internal static UpdateLoopType get_currentUpdateLoop() { }

	// RVA: 0x18DA440 Offset: 0x18D8A40 VA: 0x1818DA440
	internal static ConfigVars get_configVars() { }

	// RVA: 0x18DB030 Offset: 0x18D9630 VA: 0x1818DB030
	internal static IConfigVars_Internal get_pluginConfigVars() { }

	// RVA: 0x18D9EE0 Offset: 0x18D84E0 VA: 0x1818D9EE0
	internal static UserData get_UserData() { }

	// RVA: 0x18DA650 Offset: 0x18D8C50 VA: 0x1818DA650
	internal static Platform get_currentPlatform() { }

	// RVA: 0x18DBA00 Offset: 0x18DA000 VA: 0x1818DBA00
	internal static WebplayerPlatform get_webplayerPlatform() { }

	// RVA: 0x18DA840 Offset: 0x18D8E40 VA: 0x1818DA840
	internal static EditorPlatform get_editorPlatform() { }

	// RVA: 0x18DA1B0 Offset: 0x18D87B0 VA: 0x1818DA1B0
	internal static bool get_checkNeverPressed() { }

	// RVA: 0x18DAB60 Offset: 0x18D9160 VA: 0x1818DAB60
	internal static bool get_isEditor() { }

	// RVA: 0x18DA780 Offset: 0x18D8D80 VA: 0x1818DA780
	internal static Guid get_defaultHardwareJoystickMapGuid() { }

	// RVA: 0x18DAC10 Offset: 0x18D9210 VA: 0x1818DAC10
	internal static bool get_isRunningInEditMode() { }

	// RVA: 0x18DAAF0 Offset: 0x18D90F0 VA: 0x1818DAAF0
	internal static bool get_isEditorPaused() { }

	// RVA: 0x18DB8A0 Offset: 0x18D9EA0 VA: 0x1818DB8A0
	internal static float get_unityUnscaledDeltaTime() { }

	// RVA: 0x18DB840 Offset: 0x18D9E40 VA: 0x1818DB840
	internal static float get_unityUnscaledDeltaTimePrev() { }

	// RVA: 0x18DB2F0 Offset: 0x18D98F0 VA: 0x1818DB2F0
	internal static double get_realTime() { }

	// RVA: 0x18DA6A0 Offset: 0x18D8CA0 VA: 0x1818DA6A0
	internal static int get_currentUnityFrame() { }

	// RVA: 0x18D4D40 Offset: 0x18D3340 VA: 0x1818D4D40
	private static bool PuZtsRZydzgiEPGaVtBePKlhKbYX() { }

	// RVA: 0x18DA9F0 Offset: 0x18D8FF0 VA: 0x1818DA9F0
	internal static bool get_isAllowedEditorWindowFocused() { }

	// RVA: 0x18DAC60 Offset: 0x18D9260 VA: 0x1818DAC60
	internal static bool get_isUnityEditorFocused() { }

	// RVA: 0x18DAD10 Offset: 0x18D9310 VA: 0x1818DAD10
	internal static bool get_isWindowsStandaloneWebplayerOrEditorPlatform() { }

	// RVA: 0x18DD210 Offset: 0x18DB810 VA: 0x1818DD210
	private static bool tcMgtjefXPfrgJPftXIgbwreXJQGA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D4440 Offset: 0x18D2A40 VA: 0x1818D4440
	internal static bool IsInputAllowed(ControllerType controllerType) { }

	// RVA: 0x18D9F30 Offset: 0x18D8530 VA: 0x1818D9F30
	internal static bool get_applicationIsFocused() { }

	// RVA: 0x18DA070 Offset: 0x18D8670 VA: 0x1818DA070
	internal static bool get_applicationIsPaused() { }

	// RVA: 0x18D9FD0 Offset: 0x18D85D0 VA: 0x1818D9FD0
	internal static bool get_applicationIsFullScreen() { }

	// RVA: 0x18DA110 Offset: 0x18D8710 VA: 0x1818DA110
	internal static bool get_applicationRunInBackground() { }

	// RVA: 0x18DB440 Offset: 0x18D9A40 VA: 0x1818DB440
	internal static bool get_timeScaleIsPaused() { }

	// RVA: 0x18DB380 Offset: 0x18D9980 VA: 0x1818DB380
	internal static InputManager_Base get_rewiredInputManager() { }

	// RVA: 0x18DB080 Offset: 0x18D9680 VA: 0x1818DB080
	internal static PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x18DA540 Offset: 0x18D8B40 VA: 0x1818DA540
	internal static IControllerAssigner get_controllerAssigner() { }

	// RVA: 0x18DD190 Offset: 0x18DB790 VA: 0x1818DD190
	internal static void set_controllerAssigner(IControllerAssigner value) { }

	// RVA: 0x18DB3D0 Offset: 0x18D99D0 VA: 0x1818DB3D0
	internal static RewiredVersion get_rewiredVersion() { }

	// RVA: 0x18DB4E0 Offset: 0x18D9AE0 VA: 0x1818DB4E0
	internal static int get_timeScalePauseChangedCount() { }

	// RVA: 0x18D7E30 Offset: 0x18D6430 VA: 0x1818D7E30
	private static void ZMnYKSzvTwNuqWfMpIPLacSTBNEc() { }

	// RVA: 0x18D2920 Offset: 0x18D0F20 VA: 0x1818D2920
	internal static void FCtdvICrQuxSXlSRdnjaCOBvCvuS(InputManager_Base , Func<ConfigVars, object> , ConfigVars , ControllerDataFiles , UserData , Func<UnityTools.EeMzBLeLNTmTALqdvIAKIfdYhceUA> , Action<Platform> , Action<InputManager_Base.cTcfTFkZGmYbaxIwAeCKOJmCeHrfb> ) { }

	// RVA: 0x18D2240 Offset: 0x18D0840 VA: 0x1818D2240
	internal static void BKAnWkqoVepSBSDxHiIhUcAIcDnf() { }

	// RVA: 0x18DD860 Offset: 0x18DBE60 VA: 0x1818DD860
	internal static void xXgznigbMSNMQiKZPUtgOaMoimtv(UpdateLoopType ) { }

	// RVA: 0x18D5E00 Offset: 0x18D4400 VA: 0x1818D5E00
	private static void TEsGiKBcqrbZyGChifpzaWcgYSKjB(UpdateLoopType ) { }

	// RVA: 0x18DBDC0 Offset: 0x18DA3C0 VA: 0x1818DBDC0
	private static void ooCEDRaNiUsiUBIuMYHWkuQsCGpl() { }

	// RVA: 0x18DD440 Offset: 0x18DBA40 VA: 0x1818DD440
	internal static void xXRFCqHSPOoTeWQAbCypQJplXvCFA(UpdateLoopType ) { }

	// RVA: 0x18D4810 Offset: 0x18D2E10 VA: 0x1818D4810
	internal static void NPKZCYzkHixeYCejPMyXsyrbGClK() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D2800 Offset: 0x18D0E00 VA: 0x1818D2800
	internal static void EditorUpdate() { }

	// RVA: 0x18D9AB0 Offset: 0x18D80B0 VA: 0x1818D9AB0
	internal static void bxAWvRKaFOCxUCFOrXggAfYhijfA() { }

	// RVA: 0x18D4780 Offset: 0x18D2D80 VA: 0x1818D4780
	internal static void NHMUwZfblECmerScjVMcDuzVGNAj() { }

	// RVA: 0x18DBA50 Offset: 0x18DA050 VA: 0x1818DBA50
	internal static void kDlBdUywnvekhEHuAPhXDDnHtzhUb(bool ) { }

	// RVA: 0x18D5200 Offset: 0x18D3800 VA: 0x1818D5200
	internal static void SuccEjJzImYLzBeRwBFssvldrRWFA(bool ) { }

	// RVA: 0x18D4FD0 Offset: 0x18D35D0 VA: 0x1818D4FD0
	internal static void RUWDEcKFSmQHAJxAENkLCPTSXkvW() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D3DD0 Offset: 0x18D23D0 VA: 0x1818D3DD0
	internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController) { }

	// RVA: 0x18D9E60 Offset: 0x18D8460 VA: 0x1818D9E60
	internal static HardwareJoystickMap exTyFDmVQeeFQOEzYcKWDnowUADC(Guid ) { }

	// RVA: 0x18D9C40 Offset: 0x18D8240 VA: 0x1818D9C40
	internal static HardwareJoystickTemplateMap cIdQwwhZFZakqxCXtzETrBeoaDRS(Guid ) { }

	// RVA: 0x18D9DE0 Offset: 0x18D83E0 VA: 0x1818D9DE0
	internal static SUKBHhZFjtXCZDAZGqMkzjNQboJY dluSpeRthiKDeScdqaMrfepwkqFp(Guid ) { }

	// RVA: 0x18D2500 Offset: 0x18D0B00 VA: 0x1818D2500
	internal static IHardwareControllerTemplateMap BOAuWfrsxMmaqcZwjQNpWCywbqaK(Guid ) { }

	// RVA: 0x18D43C0 Offset: 0x18D29C0 VA: 0x1818D43C0
	internal static IHardwareControllerTemplateMap IHqafewZZxKcypItLRBmyUOldZBg(Guid ) { }

	// RVA: 0x18D6190 Offset: 0x18D4790 VA: 0x1818D6190
	internal static IList<SUKBHhZFjtXCZDAZGqMkzjNQboJY> VleaplKDxbROVDDdGzeXMndpNSQbb(Guid ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D3E40 Offset: 0x18D2440 VA: 0x1818D3E40
	internal static int GetNewJoystickId() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D41E0 Offset: 0x18D27E0 VA: 0x1818D41E0
	internal static void HandleCallbackException(string source, Exception exception) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D42B0 Offset: 0x18D28B0 VA: 0x1818D42B0
	internal static void HandleExternException(string source, Exception exception) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D42F0 Offset: 0x18D28F0 VA: 0x1818D42F0
	internal static void HandleExternalInterfaceException(string source, Exception exception) { }

	// RVA: 0x18D9CC0 Offset: 0x18D82C0 VA: 0x1818D9CC0
	internal static void cchhrDiWoYVmznETBnXfCykPafRpA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D26A0 Offset: 0x18D0CA0 VA: 0x1818D26A0
	internal static void CheckRewiredVersionCompatibility() { }

	// RVA: 0x18DBD40 Offset: 0x18DA340 VA: 0x1818DBD40
	internal static float oVzCSJgQJqNgSWiiLBlxEVXBUBMzb() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D2620 Offset: 0x18D0C20 VA: 0x1818D2620
	internal static bool CheckInitialized() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x18D2580 Offset: 0x18D0B80 VA: 0x1818D2580
	internal static bool CheckInitialized(int reInputId) { }

	// RVA: 0x18D4EC0 Offset: 0x18D34C0 VA: 0x1818D4EC0
	private static void QefaFZaCBdijmWzkBdvxzeuNsEfTA() { }

	// RVA: 0x18D52E0 Offset: 0x18D38E0 VA: 0x1818D52E0
	private static void TCXbyByjlbDNSlgLvoyuploROHRb() { }

	// RVA: 0x18D48C0 Offset: 0x18D2EC0 VA: 0x1818D48C0
	private static void NsDNIpCCIWEAniptQhGsFFQBqrryA(string ) { }

	// RVA: 0x18DBC20 Offset: 0x18DA220 VA: 0x1818DBC20
	private static void mQobgRdNnAZHAjRYPnxqRyNpPDw() { }

	// RVA: 0x18DBD00 Offset: 0x18DA300 VA: 0x1818DBD00
	private static void mWIGbkaWeZdvPLgKeRFeodfuJWjPA() { }

	// RVA: 0x18D7C00 Offset: 0x18D6200 VA: 0x1818D7C00
	private static void ZEblmSyfnDQqKWEefHbanzFnEBkF(BridgedController ) { }

	// RVA: 0x18D1F00 Offset: 0x18D0500 VA: 0x1818D1F00
	private static void AFTIjofjWRPJbXQMGRtILPzlFNUG(ControllerDisconnectedEventArgs ) { }

	// RVA: 0x18D2750 Offset: 0x18D0D50 VA: 0x1818D2750
	private static void EWXhIeefMupwyWcEppLPUKGzvKvu(ControllerStatusChangedEventArgs ) { }

	// RVA: 0x18D6000 Offset: 0x18D4600 VA: 0x1818D6000
	private static void UDmsVGuKOkTlYOARhcQuBGVmWZxy(ControllerStatusChangedEventArgs ) { }

	// RVA: 0x18D9D30 Offset: 0x18D8330 VA: 0x1818D9D30
	private static void dXhZuOBLEKODcvkcqWJJAitnOAbQ(ControllerStatusChangedEventArgs ) { }

	// RVA: 0x18D5190 Offset: 0x18D3790 VA: 0x1818D5190
	private static void SjCMxkAUdOEtFotxiNimFDNqvEMm(UpdateControllerInfoEventArgs ) { }

	// RVA: 0x18D3AE0 Offset: 0x18D20E0 VA: 0x1818D3AE0
	private static void FaWEfuAMJipvXrKVtSemqPMfTWLx(bool ) { }

	// RVA: 0x18D2170 Offset: 0x18D0770 VA: 0x1818D2170
	private static void BICIRHsTiBnSKtvqOSFrmLbJbbzq(bool ) { }

	// RVA: 0x18D5F50 Offset: 0x18D4550 VA: 0x1818D5F50
	private static void TgygoiErsOVJYfSvZHnxXIdTIryB(bool ) { }

	// RVA: 0x18D4690 Offset: 0x18D2C90 VA: 0x1818D4690
	private static void MkBSLSWGorNxIcgZAmRiKalkHOzi(int ) { }

	// RVA: 0x18DBB70 Offset: 0x18DA170 VA: 0x1818DBB70
	private static void lxwFZiKAXjIekWpKDxShnmUdtSJe(bool ) { }

	// RVA: 0x18DD370 Offset: 0x18DB970 VA: 0x1818DD370
	private static void xUMGEZCrVlfgfjvEHcjCDFSGHdZMc(bool ) { }

	// RVA: 0x18D3EA0 Offset: 0x18D24A0 VA: 0x1818D3EA0
	private static void HFafLFFLDelbcWPqwCVomdqYcvmKA() { }

	// RVA: 0x18D4920 Offset: 0x18D2F20 VA: 0x1818D4920
	private static void OuZaPtcxznDiLUYmjtakAqLrulhoA() { }

	// RVA: 0x18D4E10 Offset: 0x18D3410 VA: 0x1818D4E10
	private static void PxWgpZazBagQeBWkcFZJDVinDRYmb(bool ) { }

	// RVA: 0x18D6480 Offset: 0x18D4A80 VA: 0x1818D6480
	private static void WyoUDEKiVYkhstiiacdkFRGdVdRG(Func<ConfigVars, object> , UnityTools.EeMzBLeLNTmTALqdvIAKIfdYhceUA , Action<Platform> ) { }

	// RVA: 0x18D20C0 Offset: 0x18D06C0 VA: 0x1818D20C0
	private static void AMDRCsbgNvrSEIzbzRdUyjXofBjdA() { }

	// RVA: 0x18D3BB0 Offset: 0x18D21B0 VA: 0x1818D3BB0
	private static void GMxJyrxCsAbZGuscOXFxvNgXyXJK() { }
}

// Namespace: Rewired
public interface IGamepadTemplate : IControllerTemplate // TypeDefIndex: 5169
{
	// Properties
	public abstract IControllerTemplateButton actionBottomRow1 { get; }
	public abstract IControllerTemplateButton a { get; }
	public abstract IControllerTemplateButton actionBottomRow2 { get; }
	public abstract IControllerTemplateButton b { get; }
	public abstract IControllerTemplateButton actionBottomRow3 { get; }
	public abstract IControllerTemplateButton c { get; }
	public abstract IControllerTemplateButton actionTopRow1 { get; }
	public abstract IControllerTemplateButton x { get; }
	public abstract IControllerTemplateButton actionTopRow2 { get; }
	public abstract IControllerTemplateButton y { get; }
	public abstract IControllerTemplateButton actionTopRow3 { get; }
	public abstract IControllerTemplateButton z { get; }
	public abstract IControllerTemplateButton leftShoulder1 { get; }
	public abstract IControllerTemplateButton leftBumper { get; }
	public abstract IControllerTemplateAxis leftShoulder2 { get; }
	public abstract IControllerTemplateAxis leftTrigger { get; }
	public abstract IControllerTemplateButton rightShoulder1 { get; }
	public abstract IControllerTemplateButton rightBumper { get; }
	public abstract IControllerTemplateAxis rightShoulder2 { get; }
	public abstract IControllerTemplateAxis rightTrigger { get; }
	public abstract IControllerTemplateButton center1 { get; }
	public abstract IControllerTemplateButton back { get; }
	public abstract IControllerTemplateButton center2 { get; }
	public abstract IControllerTemplateButton start { get; }
	public abstract IControllerTemplateButton center3 { get; }
	public abstract IControllerTemplateButton guide { get; }
	public abstract IControllerTemplateThumbStick leftStick { get; }
	public abstract IControllerTemplateThumbStick rightStick { get; }
	public abstract IControllerTemplateDPad dPad { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateButton get_actionBottomRow1();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateButton get_a();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_actionBottomRow2();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_b();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_actionBottomRow3();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_c();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_actionTopRow1();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_x();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_actionTopRow2();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_y();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_actionTopRow3();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_z();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_leftShoulder1();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_leftBumper();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateAxis get_leftShoulder2();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateAxis get_leftTrigger();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_rightShoulder1();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_rightBumper();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateAxis get_rightShoulder2();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateAxis get_rightTrigger();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_center1();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_back();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_center2();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_start();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_center3();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_guide();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateThumbStick get_leftStick();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateThumbStick get_rightStick();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateDPad get_dPad();
}

// Namespace: Rewired
public interface IRacingWheelTemplate : IControllerTemplate // TypeDefIndex: 5170
{
	// Properties
	public abstract IControllerTemplateAxis wheel { get; }
	public abstract IControllerTemplateAxis accelerator { get; }
	public abstract IControllerTemplateAxis brake { get; }
	public abstract IControllerTemplateAxis clutch { get; }
	public abstract IControllerTemplateButton shiftDown { get; }
	public abstract IControllerTemplateButton shiftUp { get; }
	public abstract IControllerTemplateButton wheelButton1 { get; }
	public abstract IControllerTemplateButton wheelButton2 { get; }
	public abstract IControllerTemplateButton wheelButton3 { get; }
	public abstract IControllerTemplateButton wheelButton4 { get; }
	public abstract IControllerTemplateButton wheelButton5 { get; }
	public abstract IControllerTemplateButton wheelButton6 { get; }
	public abstract IControllerTemplateButton wheelButton7 { get; }
	public abstract IControllerTemplateButton wheelButton8 { get; }
	public abstract IControllerTemplateButton wheelButton9 { get; }
	public abstract IControllerTemplateButton wheelButton10 { get; }
	public abstract IControllerTemplateButton consoleButton1 { get; }
	public abstract IControllerTemplateButton consoleButton2 { get; }
	public abstract IControllerTemplateButton consoleButton3 { get; }
	public abstract IControllerTemplateButton consoleButton4 { get; }
	public abstract IControllerTemplateButton consoleButton5 { get; }
	public abstract IControllerTemplateButton consoleButton6 { get; }
	public abstract IControllerTemplateButton consoleButton7 { get; }
	public abstract IControllerTemplateButton consoleButton8 { get; }
	public abstract IControllerTemplateButton consoleButton9 { get; }
	public abstract IControllerTemplateButton consoleButton10 { get; }
	public abstract IControllerTemplateButton shifter1 { get; }
	public abstract IControllerTemplateButton shifter2 { get; }
	public abstract IControllerTemplateButton shifter3 { get; }
	public abstract IControllerTemplateButton shifter4 { get; }
	public abstract IControllerTemplateButton shifter5 { get; }
	public abstract IControllerTemplateButton shifter6 { get; }
	public abstract IControllerTemplateButton shifter7 { get; }
	public abstract IControllerTemplateButton shifter8 { get; }
	public abstract IControllerTemplateButton shifter9 { get; }
	public abstract IControllerTemplateButton shifter10 { get; }
	public abstract IControllerTemplateButton reverseGear { get; }
	public abstract IControllerTemplateButton select { get; }
	public abstract IControllerTemplateButton start { get; }
	public abstract IControllerTemplateButton systemButton { get; }
	public abstract IControllerTemplateButton horn { get; }
	public abstract IControllerTemplateDPad dPad { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateAxis get_wheel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateAxis get_accelerator();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_brake();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_clutch();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_shiftDown();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_shiftUp();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_wheelButton1();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_wheelButton2();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_wheelButton3();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_wheelButton4();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_wheelButton5();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_wheelButton6();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_wheelButton7();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_wheelButton8();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_wheelButton9();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_wheelButton10();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_consoleButton1();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_consoleButton2();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_consoleButton3();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_consoleButton4();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_consoleButton5();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_consoleButton6();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_consoleButton7();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_consoleButton8();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_consoleButton9();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_consoleButton10();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_shifter1();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_shifter2();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_shifter3();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_shifter4();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_shifter5();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_shifter6();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_shifter7();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_shifter8();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_shifter9();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_shifter10();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateButton get_reverseGear();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateButton get_select();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateButton get_start();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateButton get_systemButton();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateButton get_horn();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IControllerTemplateDPad get_dPad();
}

// Namespace: Rewired
public interface IHOTASTemplate : IControllerTemplate // TypeDefIndex: 5171
{
	// Properties
	public abstract IControllerTemplateButton stickTrigger { get; }
	public abstract IControllerTemplateButton stickTriggerStage2 { get; }
	public abstract IControllerTemplateButton stickPinkyButton { get; }
	public abstract IControllerTemplateButton stickPinkyTrigger { get; }
	public abstract IControllerTemplateButton stickButton1 { get; }
	public abstract IControllerTemplateButton stickButton2 { get; }
	public abstract IControllerTemplateButton stickButton3 { get; }
	public abstract IControllerTemplateButton stickButton4 { get; }
	public abstract IControllerTemplateButton stickButton5 { get; }
	public abstract IControllerTemplateButton stickButton6 { get; }
	public abstract IControllerTemplateButton stickButton7 { get; }
	public abstract IControllerTemplateButton stickButton8 { get; }
	public abstract IControllerTemplateButton stickButton9 { get; }
	public abstract IControllerTemplateButton stickButton10 { get; }
	public abstract IControllerTemplateButton stickBaseButton1 { get; }
	public abstract IControllerTemplateButton stickBaseButton2 { get; }
	public abstract IControllerTemplateButton stickBaseButton3 { get; }
	public abstract IControllerTemplateButton stickBaseButton4 { get; }
	public abstract IControllerTemplateButton stickBaseButton5 { get; }
	public abstract IControllerTemplateButton stickBaseButton6 { get; }
	public abstract IControllerTemplateButton stickBaseButton7 { get; }
	public abstract IControllerTemplateButton stickBaseButton8 { get; }
	public abstract IControllerTemplateButton stickBaseButton9 { get; }
	public abstract IControllerTemplateButton stickBaseButton10 { get; }
	public abstract IControllerTemplateButton stickBaseButton11 { get; }
	public abstract IControllerTemplateButton stickBaseButton12 { get; }
	public abstract IControllerTemplateButton mode1 { get; }
	public abstract IControllerTemplateButton mode2 { get; }
	public abstract IControllerTemplateButton mode3 { get; }
	public abstract IControllerTemplateButton throttleButton1 { get; }
	public abstract IControllerTemplateButton throttleButton2 { get; }
	public abstract IControllerTemplateButton throttleButton3 { get; }
	public abstract IControllerTemplateButton throttleButton4 { get; }
	public abstract IControllerTemplateButton throttleButton5 { get; }
	public abstract IControllerTemplateButton throttleButton6 { get; }
	public abstract IControllerTemplateButton throttleButton7 { get; }
	public abstract IControllerTemplateButton throttleButton8 { get; }
	public abstract IControllerTemplateButton throttleButton9 { get; }
	public abstract IControllerTemplateButton throttleButton10 { get; }
	public abstract IControllerTemplateButton throttleBaseButton1 { get; }
	public abstract IControllerTemplateButton throttleBaseButton2 { get; }
	public abstract IControllerTemplateButton throttleBaseButton3 { get; }
	public abstract IControllerTemplateButton throttleBaseButton4 { get; }
	public abstract IControllerTemplateButton throttleBaseButton5 { get; }
	public abstract IControllerTemplateButton throttleBaseButton6 { get; }
	public abstract IControllerTemplateButton throttleBaseButton7 { get; }
	public abstract IControllerTemplateButton throttleBaseButton8 { get; }
	public abstract IControllerTemplateButton throttleBaseButton9 { get; }
	public abstract IControllerTemplateButton throttleBaseButton10 { get; }
	public abstract IControllerTemplateButton throttleBaseButton11 { get; }
	public abstract IControllerTemplateButton throttleBaseButton12 { get; }
	public abstract IControllerTemplateButton throttleBaseButton13 { get; }
	public abstract IControllerTemplateButton throttleBaseButton14 { get; }
	public abstract IControllerTemplateButton throttleBaseButton15 { get; }
	public abstract IControllerTemplateAxis throttleSlider1 { get; }
	public abstract IControllerTemplateAxis throttleSlider2 { get; }
	public abstract IControllerTemplateAxis throttleSlider3 { get; }
	public abstract IControllerTemplateAxis throttleSlider4 { get; }
	public abstract IControllerTemplateAxis throttleDial1 { get; }
	public abstract IControllerTemplateAxis throttleDial2 { get; }
	public abstract IControllerTemplateAxis throttleDial3 { get; }
	public abstract IControllerTemplateAxis throttleDial4 { get; }
	public abstract IControllerTemplateButton throttleWheel1Forward { get; }
	public abstract IControllerTemplateButton throttleWheel1Back { get; }
	public abstract IControllerTemplateButton throttleWheel1Press { get; }
	public abstract IControllerTemplateButton throttleWheel2Forward { get; }
	public abstract IControllerTemplateButton throttleWheel2Back { get; }
	public abstract IControllerTemplateButton throttleWheel2Press { get; }
	public abstract IControllerTemplateButton throttleWheel3Forward { get; }
	public abstract IControllerTemplateButton throttleWheel3Back { get; }
	public abstract IControllerTemplateButton throttleWheel3Press { get; }
	public abstract IControllerTemplateAxis leftPedal { get; }
	public abstract IControllerTemplateAxis rightPedal { get; }
	public abstract IControllerTemplateAxis slidePedals { get; }
	public abstract IControllerTemplateStick stick { get; }
	public abstract IControllerTemplateThumbStick stickMiniStick1 { get; }
	public abstract IControllerTemplateThumbStick stickMiniStick2 { get; }
	public abstract IControllerTemplateHat stickHat1 { get; }
	public abstract IControllerTemplateHat stickHat2 { get; }
	public abstract IControllerTemplateHat stickHat3 { get; }
	public abstract IControllerTemplateHat stickHat4 { get; }
	public abstract IControllerTemplateThrottle throttle1 { get; }
	public abstract IControllerTemplateThrottle throttle2 { get; }
	public abstract IControllerTemplateThumbStick throttleMiniStick { get; }
	public abstract IControllerTemplateHat throttleHat1 { get; }
	public abstract IControllerTemplateHat throttleHat2 { get; }
	public abstract IControllerTemplateHat throttleHat3 { get; }
	public abstract IControllerTemplateHat throttleHat4 { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateButton get_stickTrigger();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateButton get_stickTriggerStage2();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_stickPinkyButton();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_stickPinkyTrigger();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_stickButton1();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_stickButton2();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_stickButton3();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_stickButton4();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_stickButton5();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_stickButton6();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_stickButton7();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_stickButton8();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_stickButton9();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_stickButton10();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_stickBaseButton1();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_stickBaseButton2();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_stickBaseButton3();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_stickBaseButton4();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_stickBaseButton5();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_stickBaseButton6();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_stickBaseButton7();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_stickBaseButton8();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_stickBaseButton9();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_stickBaseButton10();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_stickBaseButton11();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_stickBaseButton12();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_mode1();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_mode2();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_mode3();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_throttleButton1();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_throttleButton2();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_throttleButton3();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_throttleButton4();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_throttleButton5();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_throttleButton6();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_throttleButton7();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateButton get_throttleButton8();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateButton get_throttleButton9();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateButton get_throttleButton10();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateButton get_throttleBaseButton1();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateButton get_throttleBaseButton2();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IControllerTemplateButton get_throttleBaseButton3();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract IControllerTemplateButton get_throttleBaseButton4();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract IControllerTemplateButton get_throttleBaseButton5();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract IControllerTemplateButton get_throttleBaseButton6();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract IControllerTemplateButton get_throttleBaseButton7();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract IControllerTemplateButton get_throttleBaseButton8();

	// RVA: -1 Offset: -1 Slot: 47
	public abstract IControllerTemplateButton get_throttleBaseButton9();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract IControllerTemplateButton get_throttleBaseButton10();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract IControllerTemplateButton get_throttleBaseButton11();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract IControllerTemplateButton get_throttleBaseButton12();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract IControllerTemplateButton get_throttleBaseButton13();

	// RVA: -1 Offset: -1 Slot: 52
	public abstract IControllerTemplateButton get_throttleBaseButton14();

	// RVA: -1 Offset: -1 Slot: 53
	public abstract IControllerTemplateButton get_throttleBaseButton15();

	// RVA: -1 Offset: -1 Slot: 54
	public abstract IControllerTemplateAxis get_throttleSlider1();

	// RVA: -1 Offset: -1 Slot: 55
	public abstract IControllerTemplateAxis get_throttleSlider2();

	// RVA: -1 Offset: -1 Slot: 56
	public abstract IControllerTemplateAxis get_throttleSlider3();

	// RVA: -1 Offset: -1 Slot: 57
	public abstract IControllerTemplateAxis get_throttleSlider4();

	// RVA: -1 Offset: -1 Slot: 58
	public abstract IControllerTemplateAxis get_throttleDial1();

	// RVA: -1 Offset: -1 Slot: 59
	public abstract IControllerTemplateAxis get_throttleDial2();

	// RVA: -1 Offset: -1 Slot: 60
	public abstract IControllerTemplateAxis get_throttleDial3();

	// RVA: -1 Offset: -1 Slot: 61
	public abstract IControllerTemplateAxis get_throttleDial4();

	// RVA: -1 Offset: -1 Slot: 62
	public abstract IControllerTemplateButton get_throttleWheel1Forward();

	// RVA: -1 Offset: -1 Slot: 63
	public abstract IControllerTemplateButton get_throttleWheel1Back();

	// RVA: -1 Offset: -1 Slot: 64
	public abstract IControllerTemplateButton get_throttleWheel1Press();

	// RVA: -1 Offset: -1 Slot: 65
	public abstract IControllerTemplateButton get_throttleWheel2Forward();

	// RVA: -1 Offset: -1 Slot: 66
	public abstract IControllerTemplateButton get_throttleWheel2Back();

	// RVA: -1 Offset: -1 Slot: 67
	public abstract IControllerTemplateButton get_throttleWheel2Press();

	// RVA: -1 Offset: -1 Slot: 68
	public abstract IControllerTemplateButton get_throttleWheel3Forward();

	// RVA: -1 Offset: -1 Slot: 69
	public abstract IControllerTemplateButton get_throttleWheel3Back();

	// RVA: -1 Offset: -1 Slot: 70
	public abstract IControllerTemplateButton get_throttleWheel3Press();

	// RVA: -1 Offset: -1 Slot: 71
	public abstract IControllerTemplateAxis get_leftPedal();

	// RVA: -1 Offset: -1 Slot: 72
	public abstract IControllerTemplateAxis get_rightPedal();

	// RVA: -1 Offset: -1 Slot: 73
	public abstract IControllerTemplateAxis get_slidePedals();

	// RVA: -1 Offset: -1 Slot: 74
	public abstract IControllerTemplateStick get_stick();

	// RVA: -1 Offset: -1 Slot: 75
	public abstract IControllerTemplateThumbStick get_stickMiniStick1();

	// RVA: -1 Offset: -1 Slot: 76
	public abstract IControllerTemplateThumbStick get_stickMiniStick2();

	// RVA: -1 Offset: -1 Slot: 77
	public abstract IControllerTemplateHat get_stickHat1();

	// RVA: -1 Offset: -1 Slot: 78
	public abstract IControllerTemplateHat get_stickHat2();

	// RVA: -1 Offset: -1 Slot: 79
	public abstract IControllerTemplateHat get_stickHat3();

	// RVA: -1 Offset: -1 Slot: 80
	public abstract IControllerTemplateHat get_stickHat4();

	// RVA: -1 Offset: -1 Slot: 81
	public abstract IControllerTemplateThrottle get_throttle1();

	// RVA: -1 Offset: -1 Slot: 82
	public abstract IControllerTemplateThrottle get_throttle2();

	// RVA: -1 Offset: -1 Slot: 83
	public abstract IControllerTemplateThumbStick get_throttleMiniStick();

	// RVA: -1 Offset: -1 Slot: 84
	public abstract IControllerTemplateHat get_throttleHat1();

	// RVA: -1 Offset: -1 Slot: 85
	public abstract IControllerTemplateHat get_throttleHat2();

	// RVA: -1 Offset: -1 Slot: 86
	public abstract IControllerTemplateHat get_throttleHat3();

	// RVA: -1 Offset: -1 Slot: 87
	public abstract IControllerTemplateHat get_throttleHat4();
}

// Namespace: Rewired
public interface IFlightYokeTemplate : IControllerTemplate // TypeDefIndex: 5172
{
	// Properties
	public abstract IControllerTemplateButton leftPaddle { get; }
	public abstract IControllerTemplateButton rightPaddle { get; }
	public abstract IControllerTemplateButton leftGripButton1 { get; }
	public abstract IControllerTemplateButton leftGripButton2 { get; }
	public abstract IControllerTemplateButton leftGripButton3 { get; }
	public abstract IControllerTemplateButton leftGripButton4 { get; }
	public abstract IControllerTemplateButton leftGripButton5 { get; }
	public abstract IControllerTemplateButton leftGripButton6 { get; }
	public abstract IControllerTemplateButton rightGripButton1 { get; }
	public abstract IControllerTemplateButton rightGripButton2 { get; }
	public abstract IControllerTemplateButton rightGripButton3 { get; }
	public abstract IControllerTemplateButton rightGripButton4 { get; }
	public abstract IControllerTemplateButton rightGripButton5 { get; }
	public abstract IControllerTemplateButton rightGripButton6 { get; }
	public abstract IControllerTemplateButton centerButton1 { get; }
	public abstract IControllerTemplateButton centerButton2 { get; }
	public abstract IControllerTemplateButton centerButton3 { get; }
	public abstract IControllerTemplateButton centerButton4 { get; }
	public abstract IControllerTemplateButton centerButton5 { get; }
	public abstract IControllerTemplateButton centerButton6 { get; }
	public abstract IControllerTemplateButton centerButton7 { get; }
	public abstract IControllerTemplateButton centerButton8 { get; }
	public abstract IControllerTemplateButton wheel1Up { get; }
	public abstract IControllerTemplateButton wheel1Down { get; }
	public abstract IControllerTemplateButton wheel1Press { get; }
	public abstract IControllerTemplateButton wheel2Up { get; }
	public abstract IControllerTemplateButton wheel2Down { get; }
	public abstract IControllerTemplateButton wheel2Press { get; }
	public abstract IControllerTemplateButton consoleButton1 { get; }
	public abstract IControllerTemplateButton consoleButton2 { get; }
	public abstract IControllerTemplateButton consoleButton3 { get; }
	public abstract IControllerTemplateButton consoleButton4 { get; }
	public abstract IControllerTemplateButton consoleButton5 { get; }
	public abstract IControllerTemplateButton consoleButton6 { get; }
	public abstract IControllerTemplateButton consoleButton7 { get; }
	public abstract IControllerTemplateButton consoleButton8 { get; }
	public abstract IControllerTemplateButton consoleButton9 { get; }
	public abstract IControllerTemplateButton consoleButton10 { get; }
	public abstract IControllerTemplateButton mode1 { get; }
	public abstract IControllerTemplateButton mode2 { get; }
	public abstract IControllerTemplateButton mode3 { get; }
	public abstract IControllerTemplateYoke yoke { get; }
	public abstract IControllerTemplateThrottle lever1 { get; }
	public abstract IControllerTemplateThrottle lever2 { get; }
	public abstract IControllerTemplateThrottle lever3 { get; }
	public abstract IControllerTemplateThrottle lever4 { get; }
	public abstract IControllerTemplateThrottle lever5 { get; }
	public abstract IControllerTemplateHat leftGripHat { get; }
	public abstract IControllerTemplateHat rightGripHat { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateButton get_leftPaddle();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateButton get_rightPaddle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_leftGripButton1();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_leftGripButton2();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_leftGripButton3();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_leftGripButton4();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_leftGripButton5();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_leftGripButton6();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_rightGripButton1();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_rightGripButton2();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_rightGripButton3();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_rightGripButton4();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_rightGripButton5();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_rightGripButton6();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_centerButton1();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_centerButton2();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_centerButton3();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_centerButton4();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_centerButton5();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_centerButton6();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_centerButton7();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_centerButton8();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_wheel1Up();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_wheel1Down();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_wheel1Press();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_wheel2Up();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_wheel2Down();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_wheel2Press();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_consoleButton1();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_consoleButton2();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_consoleButton3();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_consoleButton4();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_consoleButton5();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_consoleButton6();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_consoleButton7();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_consoleButton8();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateButton get_consoleButton9();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateButton get_consoleButton10();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateButton get_mode1();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateButton get_mode2();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateButton get_mode3();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IControllerTemplateYoke get_yoke();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract IControllerTemplateThrottle get_lever1();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract IControllerTemplateThrottle get_lever2();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract IControllerTemplateThrottle get_lever3();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract IControllerTemplateThrottle get_lever4();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract IControllerTemplateThrottle get_lever5();

	// RVA: -1 Offset: -1 Slot: 47
	public abstract IControllerTemplateHat get_leftGripHat();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract IControllerTemplateHat get_rightGripHat();
}

// Namespace: Rewired
public interface IFlightPedalsTemplate : IControllerTemplate // TypeDefIndex: 5173
{
	// Properties
	public abstract IControllerTemplateAxis leftPedal { get; }
	public abstract IControllerTemplateAxis rightPedal { get; }
	public abstract IControllerTemplateAxis slide { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateAxis get_leftPedal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateAxis get_rightPedal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_slide();
}

// Namespace: Rewired
public interface ISixDofControllerTemplate : IControllerTemplate // TypeDefIndex: 5174
{
	// Properties
	public abstract IControllerTemplateAxis extraAxis1 { get; }
	public abstract IControllerTemplateAxis extraAxis2 { get; }
	public abstract IControllerTemplateAxis extraAxis3 { get; }
	public abstract IControllerTemplateAxis extraAxis4 { get; }
	public abstract IControllerTemplateButton button1 { get; }
	public abstract IControllerTemplateButton button2 { get; }
	public abstract IControllerTemplateButton button3 { get; }
	public abstract IControllerTemplateButton button4 { get; }
	public abstract IControllerTemplateButton button5 { get; }
	public abstract IControllerTemplateButton button6 { get; }
	public abstract IControllerTemplateButton button7 { get; }
	public abstract IControllerTemplateButton button8 { get; }
	public abstract IControllerTemplateButton button9 { get; }
	public abstract IControllerTemplateButton button10 { get; }
	public abstract IControllerTemplateButton button11 { get; }
	public abstract IControllerTemplateButton button12 { get; }
	public abstract IControllerTemplateButton button13 { get; }
	public abstract IControllerTemplateButton button14 { get; }
	public abstract IControllerTemplateButton button15 { get; }
	public abstract IControllerTemplateButton button16 { get; }
	public abstract IControllerTemplateButton button17 { get; }
	public abstract IControllerTemplateButton button18 { get; }
	public abstract IControllerTemplateButton button19 { get; }
	public abstract IControllerTemplateButton button20 { get; }
	public abstract IControllerTemplateButton button21 { get; }
	public abstract IControllerTemplateButton button22 { get; }
	public abstract IControllerTemplateButton button23 { get; }
	public abstract IControllerTemplateButton button24 { get; }
	public abstract IControllerTemplateButton button25 { get; }
	public abstract IControllerTemplateButton button26 { get; }
	public abstract IControllerTemplateButton button27 { get; }
	public abstract IControllerTemplateButton button28 { get; }
	public abstract IControllerTemplateButton button29 { get; }
	public abstract IControllerTemplateButton button30 { get; }
	public abstract IControllerTemplateButton button31 { get; }
	public abstract IControllerTemplateButton button32 { get; }
	public abstract IControllerTemplateHat hat1 { get; }
	public abstract IControllerTemplateHat hat2 { get; }
	public abstract IControllerTemplateThrottle throttle1 { get; }
	public abstract IControllerTemplateThrottle throttle2 { get; }
	public abstract IControllerTemplateStick6D stick { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateAxis get_extraAxis1();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateAxis get_extraAxis2();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_extraAxis3();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_extraAxis4();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_button1();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_button2();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_button3();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_button4();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_button5();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_button6();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_button7();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_button8();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_button9();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_button10();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_button11();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_button12();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_button13();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_button14();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_button15();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_button16();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_button17();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_button18();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_button19();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_button20();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_button21();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_button22();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_button23();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_button24();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_button25();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_button26();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_button27();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_button28();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_button29();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_button30();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_button31();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_button32();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateHat get_hat1();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateHat get_hat2();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateThrottle get_throttle1();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateThrottle get_throttle2();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateStick6D get_stick();
}

// Namespace: Rewired
public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate // TypeDefIndex: 5175
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_leftStickX = 0;
	public const int elementId_leftStickY = 1;
	public const int elementId_rightStickX = 2;
	public const int elementId_rightStickY = 3;
	public const int elementId_actionBottomRow1 = 4;
	public const int elementId_a = 4;
	public const int elementId_actionBottomRow2 = 5;
	public const int elementId_b = 5;
	public const int elementId_actionBottomRow3 = 6;
	public const int elementId_c = 6;
	public const int elementId_actionTopRow1 = 7;
	public const int elementId_x = 7;
	public const int elementId_actionTopRow2 = 8;
	public const int elementId_y = 8;
	public const int elementId_actionTopRow3 = 9;
	public const int elementId_z = 9;
	public const int elementId_leftShoulder1 = 10;
	public const int elementId_leftBumper = 10;
	public const int elementId_leftShoulder2 = 11;
	public const int elementId_leftTrigger = 11;
	public const int elementId_rightShoulder1 = 12;
	public const int elementId_rightBumper = 12;
	public const int elementId_rightShoulder2 = 13;
	public const int elementId_rightTrigger = 13;
	public const int elementId_center1 = 14;
	public const int elementId_back = 14;
	public const int elementId_center2 = 15;
	public const int elementId_start = 15;
	public const int elementId_center3 = 16;
	public const int elementId_guide = 16;
	public const int elementId_leftStickButton = 17;
	public const int elementId_rightStickButton = 18;
	public const int elementId_dPadUp = 19;
	public const int elementId_dPadRight = 20;
	public const int elementId_dPadDown = 21;
	public const int elementId_dPadLeft = 22;
	public const int elementId_leftStick = 23;
	public const int elementId_rightStick = 24;
	public const int elementId_dPad = 25;

	// Properties
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.a { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow2 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.b { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow3 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.c { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.x { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow2 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.y { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow3 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.z { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.leftShoulder1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.leftBumper { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.leftShoulder2 { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.leftTrigger { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.rightShoulder1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.rightBumper { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.rightShoulder2 { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.rightTrigger { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.center1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.back { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.center2 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.start { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.center3 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.guide { get; }
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.leftStick { get; }
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.rightStick { get; }
	private IControllerTemplateDPad Rewired.IGamepadTemplate.dPad { get; }

	// Methods

	// RVA: 0x37BD00 Offset: 0x37A300 VA: 0x18037BD00 Slot: 20
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow1() { }

	// RVA: 0x37BCC0 Offset: 0x37A2C0 VA: 0x18037BCC0 Slot: 21
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_a() { }

	// RVA: 0x37BD40 Offset: 0x37A340 VA: 0x18037BD40 Slot: 22
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow2() { }

	// RVA: 0x37BE80 Offset: 0x37A480 VA: 0x18037BE80 Slot: 23
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_b() { }

	// RVA: 0x37BD80 Offset: 0x37A380 VA: 0x18037BD80 Slot: 24
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow3() { }

	// RVA: 0x37BF00 Offset: 0x37A500 VA: 0x18037BF00 Slot: 25
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_c() { }

	// RVA: 0x37BDC0 Offset: 0x37A3C0 VA: 0x18037BDC0 Slot: 26
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow1() { }

	// RVA: 0x37C340 Offset: 0x37A940 VA: 0x18037C340 Slot: 27
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_x() { }

	// RVA: 0x37BE00 Offset: 0x37A400 VA: 0x18037BE00 Slot: 28
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow2() { }

	// RVA: 0x37C380 Offset: 0x37A980 VA: 0x18037C380 Slot: 29
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_y() { }

	// RVA: 0x37BE40 Offset: 0x37A440 VA: 0x18037BE40 Slot: 30
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow3() { }

	// RVA: 0x37C3C0 Offset: 0x37A9C0 VA: 0x18037C3C0 Slot: 31
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_z() { }

	// RVA: 0x37C0C0 Offset: 0x37A6C0 VA: 0x18037C0C0 Slot: 32
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_leftShoulder1() { }

	// RVA: 0x37C080 Offset: 0x37A680 VA: 0x18037C080 Slot: 33
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_leftBumper() { }

	// RVA: 0x37C100 Offset: 0x37A700 VA: 0x18037C100 Slot: 34
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftShoulder2() { }

	// RVA: 0x37C180 Offset: 0x37A780 VA: 0x18037C180 Slot: 35
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftTrigger() { }

	// RVA: 0x37C200 Offset: 0x37A800 VA: 0x18037C200 Slot: 36
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_rightShoulder1() { }

	// RVA: 0x37C1C0 Offset: 0x37A7C0 VA: 0x18037C1C0 Slot: 37
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_rightBumper() { }

	// RVA: 0x37C240 Offset: 0x37A840 VA: 0x18037C240 Slot: 38
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightShoulder2() { }

	// RVA: 0x37C2C0 Offset: 0x37A8C0 VA: 0x18037C2C0 Slot: 39
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightTrigger() { }

	// RVA: 0x37BF40 Offset: 0x37A540 VA: 0x18037BF40 Slot: 40
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_center1() { }

	// RVA: 0x37BEC0 Offset: 0x37A4C0 VA: 0x18037BEC0 Slot: 41
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_back() { }

	// RVA: 0x37BF80 Offset: 0x37A580 VA: 0x18037BF80 Slot: 42
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_center2() { }

	// RVA: 0x37C300 Offset: 0x37A900 VA: 0x18037C300 Slot: 43
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_start() { }

	// RVA: 0x37BFC0 Offset: 0x37A5C0 VA: 0x18037BFC0 Slot: 44
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_center3() { }

	// RVA: 0x37C040 Offset: 0x37A640 VA: 0x18037C040 Slot: 45
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_guide() { }

	// RVA: 0x37C140 Offset: 0x37A740 VA: 0x18037C140 Slot: 46
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_leftStick() { }

	// RVA: 0x37C280 Offset: 0x37A880 VA: 0x18037C280 Slot: 47
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_rightStick() { }

	// RVA: 0x37C000 Offset: 0x37A600 VA: 0x18037C000 Slot: 48
	private IControllerTemplateDPad Rewired.IGamepadTemplate.get_dPad() { }

	// RVA: 0x37B000 Offset: 0x379600 VA: 0x18037B000
	public void .ctor(object payload) { }

	// RVA: 0x37C400 Offset: 0x37AA00 VA: 0x18037C400
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate // TypeDefIndex: 5176
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_wheel = 0;
	public const int elementId_accelerator = 1;
	public const int elementId_brake = 2;
	public const int elementId_clutch = 3;
	public const int elementId_shiftDown = 4;
	public const int elementId_shiftUp = 5;
	public const int elementId_wheelButton1 = 6;
	public const int elementId_wheelButton2 = 7;
	public const int elementId_wheelButton3 = 8;
	public const int elementId_wheelButton4 = 9;
	public const int elementId_wheelButton5 = 10;
	public const int elementId_wheelButton6 = 11;
	public const int elementId_wheelButton7 = 12;
	public const int elementId_wheelButton8 = 13;
	public const int elementId_wheelButton9 = 14;
	public const int elementId_wheelButton10 = 15;
	public const int elementId_consoleButton1 = 16;
	public const int elementId_consoleButton2 = 17;
	public const int elementId_consoleButton3 = 18;
	public const int elementId_consoleButton4 = 19;
	public const int elementId_consoleButton5 = 20;
	public const int elementId_consoleButton6 = 21;
	public const int elementId_consoleButton7 = 22;
	public const int elementId_consoleButton8 = 23;
	public const int elementId_consoleButton9 = 24;
	public const int elementId_consoleButton10 = 25;
	public const int elementId_shifter1 = 26;
	public const int elementId_shifter2 = 27;
	public const int elementId_shifter3 = 28;
	public const int elementId_shifter4 = 29;
	public const int elementId_shifter5 = 30;
	public const int elementId_shifter6 = 31;
	public const int elementId_shifter7 = 32;
	public const int elementId_shifter8 = 33;
	public const int elementId_shifter9 = 34;
	public const int elementId_shifter10 = 35;
	public const int elementId_reverseGear = 44;
	public const int elementId_select = 36;
	public const int elementId_start = 37;
	public const int elementId_systemButton = 38;
	public const int elementId_horn = 43;
	public const int elementId_dPadUp = 39;
	public const int elementId_dPadRight = 40;
	public const int elementId_dPadDown = 41;
	public const int elementId_dPadLeft = 42;
	public const int elementId_dPad = 45;

	// Properties
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.wheel { get; }
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.accelerator { get; }
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.brake { get; }
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.clutch { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftDown { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftUp { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton1 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton2 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton3 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton4 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton5 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton6 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton7 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton8 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton9 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton10 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton1 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton2 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton3 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton4 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton5 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton6 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton7 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton8 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton9 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton10 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter1 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter2 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter3 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter4 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter5 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter6 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter7 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter8 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter9 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter10 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.reverseGear { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.select { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.start { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.systemButton { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.horn { get; }
	private IControllerTemplateDPad Rewired.IRacingWheelTemplate.dPad { get; }

	// Methods

	// RVA: 0x37F5E0 Offset: 0x37DBE0 VA: 0x18037F5E0 Slot: 20
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_wheel() { }

	// RVA: 0x37EBA0 Offset: 0x37D1A0 VA: 0x18037EBA0 Slot: 21
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_accelerator() { }

	// RVA: 0x37EBE0 Offset: 0x37D1E0 VA: 0x18037EBE0 Slot: 22
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_brake() { }

	// RVA: 0x37EC20 Offset: 0x37D220 VA: 0x18037EC20 Slot: 23
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_clutch() { }

	// RVA: 0x37EFE0 Offset: 0x37D5E0 VA: 0x18037EFE0 Slot: 24
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftDown() { }

	// RVA: 0x37F020 Offset: 0x37D620 VA: 0x18037F020 Slot: 25
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftUp() { }

	// RVA: 0x37F3A0 Offset: 0x37D9A0 VA: 0x18037F3A0 Slot: 26
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton1() { }

	// RVA: 0x37F3E0 Offset: 0x37D9E0 VA: 0x18037F3E0 Slot: 27
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton2() { }

	// RVA: 0x37F420 Offset: 0x37DA20 VA: 0x18037F420 Slot: 28
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton3() { }

	// RVA: 0x37F460 Offset: 0x37DA60 VA: 0x18037F460 Slot: 29
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton4() { }

	// RVA: 0x37F4A0 Offset: 0x37DAA0 VA: 0x18037F4A0 Slot: 30
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton5() { }

	// RVA: 0x37F4E0 Offset: 0x37DAE0 VA: 0x18037F4E0 Slot: 31
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton6() { }

	// RVA: 0x37F520 Offset: 0x37DB20 VA: 0x18037F520 Slot: 32
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton7() { }

	// RVA: 0x37F560 Offset: 0x37DB60 VA: 0x18037F560 Slot: 33
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton8() { }

	// RVA: 0x37F5A0 Offset: 0x37DBA0 VA: 0x18037F5A0 Slot: 34
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton9() { }

	// RVA: 0x37F360 Offset: 0x37D960 VA: 0x18037F360 Slot: 35
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton10() { }

	// RVA: 0x37ECA0 Offset: 0x37D2A0 VA: 0x18037ECA0 Slot: 36
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton1() { }

	// RVA: 0x37ECE0 Offset: 0x37D2E0 VA: 0x18037ECE0 Slot: 37
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton2() { }

	// RVA: 0x37ED20 Offset: 0x37D320 VA: 0x18037ED20 Slot: 38
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton3() { }

	// RVA: 0x37ED60 Offset: 0x37D360 VA: 0x18037ED60 Slot: 39
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton4() { }

	// RVA: 0x37EDA0 Offset: 0x37D3A0 VA: 0x18037EDA0 Slot: 40
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton5() { }

	// RVA: 0x37EDE0 Offset: 0x37D3E0 VA: 0x18037EDE0 Slot: 41
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton6() { }

	// RVA: 0x37EE20 Offset: 0x37D420 VA: 0x18037EE20 Slot: 42
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton7() { }

	// RVA: 0x37EE60 Offset: 0x37D460 VA: 0x18037EE60 Slot: 43
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton8() { }

	// RVA: 0x37EEA0 Offset: 0x37D4A0 VA: 0x18037EEA0 Slot: 44
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton9() { }

	// RVA: 0x37EC60 Offset: 0x37D260 VA: 0x18037EC60 Slot: 45
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton10() { }

	// RVA: 0x37F0A0 Offset: 0x37D6A0 VA: 0x18037F0A0 Slot: 46
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter1() { }

	// RVA: 0x37F0E0 Offset: 0x37D6E0 VA: 0x18037F0E0 Slot: 47
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter2() { }

	// RVA: 0x37F120 Offset: 0x37D720 VA: 0x18037F120 Slot: 48
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter3() { }

	// RVA: 0x37F160 Offset: 0x37D760 VA: 0x18037F160 Slot: 49
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter4() { }

	// RVA: 0x37F1A0 Offset: 0x37D7A0 VA: 0x18037F1A0 Slot: 50
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter5() { }

	// RVA: 0x37F1E0 Offset: 0x37D7E0 VA: 0x18037F1E0 Slot: 51
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter6() { }

	// RVA: 0x37F220 Offset: 0x37D820 VA: 0x18037F220 Slot: 52
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter7() { }

	// RVA: 0x37F260 Offset: 0x37D860 VA: 0x18037F260 Slot: 53
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter8() { }

	// RVA: 0x37F2A0 Offset: 0x37D8A0 VA: 0x18037F2A0 Slot: 54
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter9() { }

	// RVA: 0x37F060 Offset: 0x37D660 VA: 0x18037F060 Slot: 55
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter10() { }

	// RVA: 0x37EF60 Offset: 0x37D560 VA: 0x18037EF60 Slot: 56
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_reverseGear() { }

	// RVA: 0x37EFA0 Offset: 0x37D5A0 VA: 0x18037EFA0 Slot: 57
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_select() { }

	// RVA: 0x37F2E0 Offset: 0x37D8E0 VA: 0x18037F2E0 Slot: 58
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_start() { }

	// RVA: 0x37F320 Offset: 0x37D920 VA: 0x18037F320 Slot: 59
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_systemButton() { }

	// RVA: 0x37EF20 Offset: 0x37D520 VA: 0x18037EF20 Slot: 60
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_horn() { }

	// RVA: 0x37EEE0 Offset: 0x37D4E0 VA: 0x18037EEE0 Slot: 61
	private IControllerTemplateDPad Rewired.IRacingWheelTemplate.get_dPad() { }

	// RVA: 0x37B000 Offset: 0x379600 VA: 0x18037B000
	public void .ctor(object payload) { }

	// RVA: 0x37F620 Offset: 0x37DC20 VA: 0x18037F620
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate // TypeDefIndex: 5177
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_stickX = 0;
	public const int elementId_stickY = 1;
	public const int elementId_stickRotate = 2;
	public const int elementId_stickMiniStick1X = 78;
	public const int elementId_stickMiniStick1Y = 79;
	public const int elementId_stickMiniStick1Press = 80;
	public const int elementId_stickMiniStick2X = 81;
	public const int elementId_stickMiniStick2Y = 82;
	public const int elementId_stickMiniStick2Press = 83;
	public const int elementId_stickTrigger = 3;
	public const int elementId_stickTriggerStage2 = 4;
	public const int elementId_stickPinkyButton = 5;
	public const int elementId_stickPinkyTrigger = 154;
	public const int elementId_stickButton1 = 6;
	public const int elementId_stickButton2 = 7;
	public const int elementId_stickButton3 = 8;
	public const int elementId_stickButton4 = 9;
	public const int elementId_stickButton5 = 10;
	public const int elementId_stickButton6 = 11;
	public const int elementId_stickButton7 = 12;
	public const int elementId_stickButton8 = 13;
	public const int elementId_stickButton9 = 14;
	public const int elementId_stickButton10 = 15;
	public const int elementId_stickBaseButton1 = 18;
	public const int elementId_stickBaseButton2 = 19;
	public const int elementId_stickBaseButton3 = 20;
	public const int elementId_stickBaseButton4 = 21;
	public const int elementId_stickBaseButton5 = 22;
	public const int elementId_stickBaseButton6 = 23;
	public const int elementId_stickBaseButton7 = 24;
	public const int elementId_stickBaseButton8 = 25;
	public const int elementId_stickBaseButton9 = 26;
	public const int elementId_stickBaseButton10 = 27;
	public const int elementId_stickBaseButton11 = 161;
	public const int elementId_stickBaseButton12 = 162;
	public const int elementId_stickHat1Up = 28;
	public const int elementId_stickHat1UpRight = 29;
	public const int elementId_stickHat1Right = 30;
	public const int elementId_stickHat1DownRight = 31;
	public const int elementId_stickHat1Down = 32;
	public const int elementId_stickHat1DownLeft = 33;
	public const int elementId_stickHat1Left = 34;
	public const int elementId_stickHat1Up_Left = 35;
	public const int elementId_stickHat2Up = 36;
	public const int elementId_stickHat2Up_right = 37;
	public const int elementId_stickHat2Right = 38;
	public const int elementId_stickHat2Down_Right = 39;
	public const int elementId_stickHat2Down = 40;
	public const int elementId_stickHat2Down_Left = 41;
	public const int elementId_stickHat2Left = 42;
	public const int elementId_stickHat2Up_Left = 43;
	public const int elementId_stickHat3Up = 84;
	public const int elementId_stickHat3Up_Right = 85;
	public const int elementId_stickHat3Right = 86;
	public const int elementId_stickHat3Down_Right = 87;
	public const int elementId_stickHat3Down = 88;
	public const int elementId_stickHat3Down_Left = 89;
	public const int elementId_stickHat3Left = 90;
	public const int elementId_stickHat3Up_Left = 91;
	public const int elementId_stickHat4Up = 92;
	public const int elementId_stickHat4Up_Right = 93;
	public const int elementId_stickHat4Right = 94;
	public const int elementId_stickHat4Down_Right = 95;
	public const int elementId_stickHat4Down = 96;
	public const int elementId_stickHat4Down_Left = 97;
	public const int elementId_stickHat4Left = 98;
	public const int elementId_stickHat4Up_Left = 99;
	public const int elementId_mode1 = 44;
	public const int elementId_mode2 = 45;
	public const int elementId_mode3 = 46;
	public const int elementId_throttle1Axis = 49;
	public const int elementId_throttle2Axis = 155;
	public const int elementId_throttle1MinDetent = 166;
	public const int elementId_throttle2MinDetent = 167;
	public const int elementId_throttleButton1 = 50;
	public const int elementId_throttleButton2 = 51;
	public const int elementId_throttleButton3 = 52;
	public const int elementId_throttleButton4 = 53;
	public const int elementId_throttleButton5 = 54;
	public const int elementId_throttleButton6 = 55;
	public const int elementId_throttleButton7 = 56;
	public const int elementId_throttleButton8 = 57;
	public const int elementId_throttleButton9 = 58;
	public const int elementId_throttleButton10 = 59;
	public const int elementId_throttleBaseButton1 = 60;
	public const int elementId_throttleBaseButton2 = 61;
	public const int elementId_throttleBaseButton3 = 62;
	public const int elementId_throttleBaseButton4 = 63;
	public const int elementId_throttleBaseButton5 = 64;
	public const int elementId_throttleBaseButton6 = 65;
	public const int elementId_throttleBaseButton7 = 66;
	public const int elementId_throttleBaseButton8 = 67;
	public const int elementId_throttleBaseButton9 = 68;
	public const int elementId_throttleBaseButton10 = 69;
	public const int elementId_throttleBaseButton11 = 132;
	public const int elementId_throttleBaseButton12 = 133;
	public const int elementId_throttleBaseButton13 = 134;
	public const int elementId_throttleBaseButton14 = 135;
	public const int elementId_throttleBaseButton15 = 136;
	public const int elementId_throttleSlider1 = 70;
	public const int elementId_throttleSlider2 = 71;
	public const int elementId_throttleSlider3 = 72;
	public const int elementId_throttleSlider4 = 73;
	public const int elementId_throttleDial1 = 74;
	public const int elementId_throttleDial2 = 142;
	public const int elementId_throttleDial3 = 143;
	public const int elementId_throttleDial4 = 144;
	public const int elementId_throttleMiniStickX = 75;
	public const int elementId_throttleMiniStickY = 76;
	public const int elementId_throttleMiniStickPress = 77;
	public const int elementId_throttleWheel1Forward = 145;
	public const int elementId_throttleWheel1Back = 146;
	public const int elementId_throttleWheel1Press = 147;
	public const int elementId_throttleWheel2Forward = 148;
	public const int elementId_throttleWheel2Back = 149;
	public const int elementId_throttleWheel2Press = 150;
	public const int elementId_throttleWheel3Forward = 151;
	public const int elementId_throttleWheel3Back = 152;
	public const int elementId_throttleWheel3Press = 153;
	public const int elementId_throttleHat1Up = 100;
	public const int elementId_throttleHat1Up_Right = 101;
	public const int elementId_throttleHat1Right = 102;
	public const int elementId_throttleHat1Down_Right = 103;
	public const int elementId_throttleHat1Down = 104;
	public const int elementId_throttleHat1Down_Left = 105;
	public const int elementId_throttleHat1Left = 106;
	public const int elementId_throttleHat1Up_Left = 107;
	public const int elementId_throttleHat2Up = 108;
	public const int elementId_throttleHat2Up_Right = 109;
	public const int elementId_throttleHat2Right = 110;
	public const int elementId_throttleHat2Down_Right = 111;
	public const int elementId_throttleHat2Down = 112;
	public const int elementId_throttleHat2Down_Left = 113;
	public const int elementId_throttleHat2Left = 114;
	public const int elementId_throttleHat2Up_Left = 115;
	public const int elementId_throttleHat3Up = 116;
	public const int elementId_throttleHat3Up_Right = 117;
	public const int elementId_throttleHat3Right = 118;
	public const int elementId_throttleHat3Down_Right = 119;
	public const int elementId_throttleHat3Down = 120;
	public const int elementId_throttleHat3Down_Left = 121;
	public const int elementId_throttleHat3Left = 122;
	public const int elementId_throttleHat3Up_Left = 123;
	public const int elementId_throttleHat4Up = 124;
	public const int elementId_throttleHat4Up_Right = 125;
	public const int elementId_throttleHat4Right = 126;
	public const int elementId_throttleHat4Down_Right = 127;
	public const int elementId_throttleHat4Down = 128;
	public const int elementId_throttleHat4Down_Left = 129;
	public const int elementId_throttleHat4Left = 130;
	public const int elementId_throttleHat4Up_Left = 131;
	public const int elementId_leftPedal = 168;
	public const int elementId_rightPedal = 169;
	public const int elementId_slidePedals = 170;
	public const int elementId_stick = 171;
	public const int elementId_stickMiniStick1 = 172;
	public const int elementId_stickMiniStick2 = 173;
	public const int elementId_stickHat1 = 174;
	public const int elementId_stickHat2 = 175;
	public const int elementId_stickHat3 = 176;
	public const int elementId_stickHat4 = 177;
	public const int elementId_throttle1 = 178;
	public const int elementId_throttle2 = 179;
	public const int elementId_throttleMiniStick = 180;
	public const int elementId_throttleHat1 = 181;
	public const int elementId_throttleHat2 = 182;
	public const int elementId_throttleHat3 = 183;
	public const int elementId_throttleHat4 = 184;

	// Properties
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickTrigger { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickTriggerStage2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyButton { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyTrigger { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton11 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton12 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.mode1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.mode2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.mode3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton11 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton12 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton13 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton14 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton15 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider1 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider2 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider3 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider4 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial1 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial2 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial3 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Forward { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Back { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Press { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Forward { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Back { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Press { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Forward { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Back { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Press { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.leftPedal { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.rightPedal { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.slidePedals { get; }
	private IControllerTemplateStick Rewired.IHOTASTemplate.stick { get; }
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick1 { get; }
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick2 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat1 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat2 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat3 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat4 { get; }
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle1 { get; }
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle2 { get; }
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.throttleMiniStick { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat1 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat2 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat3 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat4 { get; }

	// Methods

	// RVA: 0x37CDB0 Offset: 0x37B3B0 VA: 0x18037CDB0 Slot: 20
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTrigger() { }

	// RVA: 0x37CD70 Offset: 0x37B370 VA: 0x18037CD70 Slot: 21
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTriggerStage2() { }

	// RVA: 0x37CCF0 Offset: 0x37B2F0 VA: 0x18037CCF0 Slot: 22
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyButton() { }

	// RVA: 0x37CD30 Offset: 0x37B330 VA: 0x18037CD30 Slot: 23
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyTrigger() { }

	// RVA: 0x37C930 Offset: 0x37AF30 VA: 0x18037C930 Slot: 24
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton1() { }

	// RVA: 0x37C970 Offset: 0x37AF70 VA: 0x18037C970 Slot: 25
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton2() { }

	// RVA: 0x37C9B0 Offset: 0x37AFB0 VA: 0x18037C9B0 Slot: 26
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton3() { }

	// RVA: 0x37C9F0 Offset: 0x37AFF0 VA: 0x18037C9F0 Slot: 27
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton4() { }

	// RVA: 0x37CA30 Offset: 0x37B030 VA: 0x18037CA30 Slot: 28
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton5() { }

	// RVA: 0x37CA70 Offset: 0x37B070 VA: 0x18037CA70 Slot: 29
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton6() { }

	// RVA: 0x37CAB0 Offset: 0x37B0B0 VA: 0x18037CAB0 Slot: 30
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton7() { }

	// RVA: 0x37CAF0 Offset: 0x37B0F0 VA: 0x18037CAF0 Slot: 31
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton8() { }

	// RVA: 0x37CB30 Offset: 0x37B130 VA: 0x18037CB30 Slot: 32
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton9() { }

	// RVA: 0x37C8F0 Offset: 0x37AEF0 VA: 0x18037C8F0 Slot: 33
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton10() { }

	// RVA: 0x37C6B0 Offset: 0x37ACB0 VA: 0x18037C6B0 Slot: 34
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton1() { }

	// RVA: 0x37C6F0 Offset: 0x37ACF0 VA: 0x18037C6F0 Slot: 35
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton2() { }

	// RVA: 0x37C730 Offset: 0x37AD30 VA: 0x18037C730 Slot: 36
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton3() { }

	// RVA: 0x37C770 Offset: 0x37AD70 VA: 0x18037C770 Slot: 37
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton4() { }

	// RVA: 0x37C7B0 Offset: 0x37ADB0 VA: 0x18037C7B0 Slot: 38
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton5() { }

	// RVA: 0x37C7F0 Offset: 0x37ADF0 VA: 0x18037C7F0 Slot: 39
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton6() { }

	// RVA: 0x37C830 Offset: 0x37AE30 VA: 0x18037C830 Slot: 40
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton7() { }

	// RVA: 0x37C870 Offset: 0x37AE70 VA: 0x18037C870 Slot: 41
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton8() { }

	// RVA: 0x37C8B0 Offset: 0x37AEB0 VA: 0x18037C8B0 Slot: 42
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton9() { }

	// RVA: 0x37C5F0 Offset: 0x37ABF0 VA: 0x18037C5F0 Slot: 43
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton10() { }

	// RVA: 0x37C630 Offset: 0x37AC30 VA: 0x18037C630 Slot: 44
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton11() { }

	// RVA: 0x37C670 Offset: 0x37AC70 VA: 0x18037C670 Slot: 45
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton12() { }

	// RVA: 0x37C4B0 Offset: 0x37AAB0 VA: 0x18037C4B0 Slot: 46
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_mode1() { }

	// RVA: 0x37C4F0 Offset: 0x37AAF0 VA: 0x18037C4F0 Slot: 47
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_mode2() { }

	// RVA: 0x37C530 Offset: 0x37AB30 VA: 0x18037C530 Slot: 48
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_mode3() { }

	// RVA: 0x37D2B0 Offset: 0x37B8B0 VA: 0x18037D2B0 Slot: 49
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton1() { }

	// RVA: 0x37D2F0 Offset: 0x37B8F0 VA: 0x18037D2F0 Slot: 50
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton2() { }

	// RVA: 0x37D330 Offset: 0x37B930 VA: 0x18037D330 Slot: 51
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton3() { }

	// RVA: 0x37D370 Offset: 0x37B970 VA: 0x18037D370 Slot: 52
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton4() { }

	// RVA: 0x37D3B0 Offset: 0x37B9B0 VA: 0x18037D3B0 Slot: 53
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton5() { }

	// RVA: 0x37D3F0 Offset: 0x37B9F0 VA: 0x18037D3F0 Slot: 54
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton6() { }

	// RVA: 0x37D430 Offset: 0x37BA30 VA: 0x18037D430 Slot: 55
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton7() { }

	// RVA: 0x37D470 Offset: 0x37BA70 VA: 0x18037D470 Slot: 56
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton8() { }

	// RVA: 0x37D4B0 Offset: 0x37BAB0 VA: 0x18037D4B0 Slot: 57
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton9() { }

	// RVA: 0x37D270 Offset: 0x37B870 VA: 0x18037D270 Slot: 58
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton10() { }

	// RVA: 0x37D030 Offset: 0x37B630 VA: 0x18037D030 Slot: 59
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton1() { }

	// RVA: 0x37D070 Offset: 0x37B670 VA: 0x18037D070 Slot: 60
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton2() { }

	// RVA: 0x37D0B0 Offset: 0x37B6B0 VA: 0x18037D0B0 Slot: 61
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton3() { }

	// RVA: 0x37D0F0 Offset: 0x37B6F0 VA: 0x18037D0F0 Slot: 62
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton4() { }

	// RVA: 0x37D130 Offset: 0x37B730 VA: 0x18037D130 Slot: 63
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton5() { }

	// RVA: 0x37D170 Offset: 0x37B770 VA: 0x18037D170 Slot: 64
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton6() { }

	// RVA: 0x37D1B0 Offset: 0x37B7B0 VA: 0x18037D1B0 Slot: 65
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton7() { }

	// RVA: 0x37D1F0 Offset: 0x37B7F0 VA: 0x18037D1F0 Slot: 66
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton8() { }

	// RVA: 0x37D230 Offset: 0x37B830 VA: 0x18037D230 Slot: 67
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton9() { }

	// RVA: 0x37CEB0 Offset: 0x37B4B0 VA: 0x18037CEB0 Slot: 68
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton10() { }

	// RVA: 0x37CEF0 Offset: 0x37B4F0 VA: 0x18037CEF0 Slot: 69
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton11() { }

	// RVA: 0x37CF30 Offset: 0x37B530 VA: 0x18037CF30 Slot: 70
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton12() { }

	// RVA: 0x37CF70 Offset: 0x37B570 VA: 0x18037CF70 Slot: 71
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton13() { }

	// RVA: 0x37CFB0 Offset: 0x37B5B0 VA: 0x18037CFB0 Slot: 72
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton14() { }

	// RVA: 0x37CFF0 Offset: 0x37B5F0 VA: 0x18037CFF0 Slot: 73
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton15() { }

	// RVA: 0x37D730 Offset: 0x37BD30 VA: 0x18037D730 Slot: 74
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider1() { }

	// RVA: 0x37D770 Offset: 0x37BD70 VA: 0x18037D770 Slot: 75
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider2() { }

	// RVA: 0x37D7B0 Offset: 0x37BDB0 VA: 0x18037D7B0 Slot: 76
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider3() { }

	// RVA: 0x37D7F0 Offset: 0x37BDF0 VA: 0x18037D7F0 Slot: 77
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider4() { }

	// RVA: 0x37D4F0 Offset: 0x37BAF0 VA: 0x18037D4F0 Slot: 78
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial1() { }

	// RVA: 0x37D530 Offset: 0x37BB30 VA: 0x18037D530 Slot: 79
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial2() { }

	// RVA: 0x37D570 Offset: 0x37BB70 VA: 0x18037D570 Slot: 80
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial3() { }

	// RVA: 0x37D5B0 Offset: 0x37BBB0 VA: 0x18037D5B0 Slot: 81
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial4() { }

	// RVA: 0x37D870 Offset: 0x37BE70 VA: 0x18037D870 Slot: 82
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Forward() { }

	// RVA: 0x37D830 Offset: 0x37BE30 VA: 0x18037D830 Slot: 83
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Back() { }

	// RVA: 0x37D8B0 Offset: 0x37BEB0 VA: 0x18037D8B0 Slot: 84
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Press() { }

	// RVA: 0x37D930 Offset: 0x37BF30 VA: 0x18037D930 Slot: 85
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Forward() { }

	// RVA: 0x37D8F0 Offset: 0x37BEF0 VA: 0x18037D8F0 Slot: 86
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Back() { }

	// RVA: 0x37D970 Offset: 0x37BF70 VA: 0x18037D970 Slot: 87
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Press() { }

	// RVA: 0x37D9F0 Offset: 0x37BFF0 VA: 0x18037D9F0 Slot: 88
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Forward() { }

	// RVA: 0x37D9B0 Offset: 0x37BFB0 VA: 0x18037D9B0 Slot: 89
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Back() { }

	// RVA: 0x37DA30 Offset: 0x37C030 VA: 0x18037DA30 Slot: 90
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Press() { }

	// RVA: 0x37C470 Offset: 0x37AA70 VA: 0x18037C470 Slot: 91
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_leftPedal() { }

	// RVA: 0x37C570 Offset: 0x37AB70 VA: 0x18037C570 Slot: 92
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_rightPedal() { }

	// RVA: 0x37C5B0 Offset: 0x37ABB0 VA: 0x18037C5B0 Slot: 93
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_slidePedals() { }

	// RVA: 0x37CDF0 Offset: 0x37B3F0 VA: 0x18037CDF0 Slot: 94
	private IControllerTemplateStick Rewired.IHOTASTemplate.get_stick() { }

	// RVA: 0x37CC70 Offset: 0x37B270 VA: 0x18037CC70 Slot: 95
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick1() { }

	// RVA: 0x37CCB0 Offset: 0x37B2B0 VA: 0x18037CCB0 Slot: 96
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick2() { }

	// RVA: 0x37CB70 Offset: 0x37B170 VA: 0x18037CB70 Slot: 97
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat1() { }

	// RVA: 0x37CBB0 Offset: 0x37B1B0 VA: 0x18037CBB0 Slot: 98
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat2() { }

	// RVA: 0x37CBF0 Offset: 0x37B1F0 VA: 0x18037CBF0 Slot: 99
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat3() { }

	// RVA: 0x37CC30 Offset: 0x37B230 VA: 0x18037CC30 Slot: 100
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat4() { }

	// RVA: 0x37CE30 Offset: 0x37B430 VA: 0x18037CE30 Slot: 101
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle1() { }

	// RVA: 0x37CE70 Offset: 0x37B470 VA: 0x18037CE70 Slot: 102
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle2() { }

	// RVA: 0x37D6F0 Offset: 0x37BCF0 VA: 0x18037D6F0 Slot: 103
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_throttleMiniStick() { }

	// RVA: 0x37D5F0 Offset: 0x37BBF0 VA: 0x18037D5F0 Slot: 104
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat1() { }

	// RVA: 0x37D630 Offset: 0x37BC30 VA: 0x18037D630 Slot: 105
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat2() { }

	// RVA: 0x37D670 Offset: 0x37BC70 VA: 0x18037D670 Slot: 106
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat3() { }

	// RVA: 0x37D6B0 Offset: 0x37BCB0 VA: 0x18037D6B0 Slot: 107
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat4() { }

	// RVA: 0x37B000 Offset: 0x379600 VA: 0x18037B000
	public void .ctor(object payload) { }

	// RVA: 0x37DA70 Offset: 0x37C070 VA: 0x18037DA70
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate // TypeDefIndex: 5178
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_rotateYoke = 0;
	public const int elementId_yokeZ = 1;
	public const int elementId_leftPaddle = 59;
	public const int elementId_rightPaddle = 60;
	public const int elementId_lever1Axis = 2;
	public const int elementId_lever1MinDetent = 64;
	public const int elementId_lever2Axis = 3;
	public const int elementId_lever2MinDetent = 65;
	public const int elementId_lever3Axis = 4;
	public const int elementId_lever3MinDetent = 66;
	public const int elementId_lever4Axis = 5;
	public const int elementId_lever4MinDetent = 67;
	public const int elementId_lever5Axis = 6;
	public const int elementId_lever5MinDetent = 68;
	public const int elementId_leftGripButton1 = 7;
	public const int elementId_leftGripButton2 = 8;
	public const int elementId_leftGripButton3 = 9;
	public const int elementId_leftGripButton4 = 10;
	public const int elementId_leftGripButton5 = 11;
	public const int elementId_leftGripButton6 = 12;
	public const int elementId_rightGripButton1 = 13;
	public const int elementId_rightGripButton2 = 14;
	public const int elementId_rightGripButton3 = 15;
	public const int elementId_rightGripButton4 = 16;
	public const int elementId_rightGripButton5 = 17;
	public const int elementId_rightGripButton6 = 18;
	public const int elementId_centerButton1 = 19;
	public const int elementId_centerButton2 = 20;
	public const int elementId_centerButton3 = 21;
	public const int elementId_centerButton4 = 22;
	public const int elementId_centerButton5 = 23;
	public const int elementId_centerButton6 = 24;
	public const int elementId_centerButton7 = 25;
	public const int elementId_centerButton8 = 26;
	public const int elementId_wheel1Up = 53;
	public const int elementId_wheel1Down = 54;
	public const int elementId_wheel1Press = 55;
	public const int elementId_wheel2Up = 56;
	public const int elementId_wheel2Down = 57;
	public const int elementId_wheel2Press = 58;
	public const int elementId_leftGripHatUp = 27;
	public const int elementId_leftGripHatUpRight = 28;
	public const int elementId_leftGripHatRight = 29;
	public const int elementId_leftGripHatDownRight = 30;
	public const int elementId_leftGripHatDown = 31;
	public const int elementId_leftGripHatDownLeft = 32;
	public const int elementId_leftGripHatLeft = 33;
	public const int elementId_leftGripHatUpLeft = 34;
	public const int elementId_rightGripHatUp = 35;
	public const int elementId_rightGripHatUpRight = 36;
	public const int elementId_rightGripHatRight = 37;
	public const int elementId_rightGripHatDownRight = 38;
	public const int elementId_rightGripHatDown = 39;
	public const int elementId_rightGripHatDownLeft = 40;
	public const int elementId_rightGripHatLeft = 41;
	public const int elementId_rightGripHatUpLeft = 42;
	public const int elementId_consoleButton1 = 43;
	public const int elementId_consoleButton2 = 44;
	public const int elementId_consoleButton3 = 45;
	public const int elementId_consoleButton4 = 46;
	public const int elementId_consoleButton5 = 47;
	public const int elementId_consoleButton6 = 48;
	public const int elementId_consoleButton7 = 49;
	public const int elementId_consoleButton8 = 50;
	public const int elementId_consoleButton9 = 51;
	public const int elementId_consoleButton10 = 52;
	public const int elementId_mode1 = 61;
	public const int elementId_mode2 = 62;
	public const int elementId_mode3 = 63;
	public const int elementId_yoke = 69;
	public const int elementId_lever1 = 70;
	public const int elementId_lever2 = 71;
	public const int elementId_lever3 = 72;
	public const int elementId_lever4 = 73;
	public const int elementId_lever5 = 74;
	public const int elementId_leftGripHat = 75;
	public const int elementId_rightGripHat = 76;

	// Properties
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftPaddle { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightPaddle { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton7 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton8 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Up { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Down { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Press { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Up { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Down { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Press { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton7 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton8 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton9 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton10 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode3 { get; }
	private IControllerTemplateYoke Rewired.IFlightYokeTemplate.yoke { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever1 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever2 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever3 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever4 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever5 { get; }
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.leftGripHat { get; }
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.rightGripHat { get; }

	// Methods

	// RVA: 0x37B650 Offset: 0x379C50 VA: 0x18037B650 Slot: 20
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftPaddle() { }

	// RVA: 0x37BA50 Offset: 0x37A050 VA: 0x18037BA50 Slot: 21
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightPaddle() { }

	// RVA: 0x37B490 Offset: 0x379A90 VA: 0x18037B490 Slot: 22
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton1() { }

	// RVA: 0x37B4D0 Offset: 0x379AD0 VA: 0x18037B4D0 Slot: 23
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton2() { }

	// RVA: 0x37B510 Offset: 0x379B10 VA: 0x18037B510 Slot: 24
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton3() { }

	// RVA: 0x37B550 Offset: 0x379B50 VA: 0x18037B550 Slot: 25
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton4() { }

	// RVA: 0x37B590 Offset: 0x379B90 VA: 0x18037B590 Slot: 26
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton5() { }

	// RVA: 0x37B5D0 Offset: 0x379BD0 VA: 0x18037B5D0 Slot: 27
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton6() { }

	// RVA: 0x37B890 Offset: 0x379E90 VA: 0x18037B890 Slot: 28
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton1() { }

	// RVA: 0x37B8D0 Offset: 0x379ED0 VA: 0x18037B8D0 Slot: 29
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton2() { }

	// RVA: 0x37B910 Offset: 0x379F10 VA: 0x18037B910 Slot: 30
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton3() { }

	// RVA: 0x37B950 Offset: 0x379F50 VA: 0x18037B950 Slot: 31
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton4() { }

	// RVA: 0x37B990 Offset: 0x379F90 VA: 0x18037B990 Slot: 32
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton5() { }

	// RVA: 0x37B9D0 Offset: 0x379FD0 VA: 0x18037B9D0 Slot: 33
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton6() { }

	// RVA: 0x37B010 Offset: 0x379610 VA: 0x18037B010 Slot: 34
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton1() { }

	// RVA: 0x37B050 Offset: 0x379650 VA: 0x18037B050 Slot: 35
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton2() { }

	// RVA: 0x37B090 Offset: 0x379690 VA: 0x18037B090 Slot: 36
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton3() { }

	// RVA: 0x37B0D0 Offset: 0x3796D0 VA: 0x18037B0D0 Slot: 37
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton4() { }

	// RVA: 0x37B110 Offset: 0x379710 VA: 0x18037B110 Slot: 38
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton5() { }

	// RVA: 0x37B150 Offset: 0x379750 VA: 0x18037B150 Slot: 39
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton6() { }

	// RVA: 0x37B190 Offset: 0x379790 VA: 0x18037B190 Slot: 40
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton7() { }

	// RVA: 0x37B1D0 Offset: 0x3797D0 VA: 0x18037B1D0 Slot: 41
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton8() { }

	// RVA: 0x37BB10 Offset: 0x37A110 VA: 0x18037BB10 Slot: 42
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Up() { }

	// RVA: 0x37BA90 Offset: 0x37A090 VA: 0x18037BA90 Slot: 43
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Down() { }

	// RVA: 0x37BAD0 Offset: 0x37A0D0 VA: 0x18037BAD0 Slot: 44
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Press() { }

	// RVA: 0x37BBD0 Offset: 0x37A1D0 VA: 0x18037BBD0 Slot: 45
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Up() { }

	// RVA: 0x37BB50 Offset: 0x37A150 VA: 0x18037BB50 Slot: 46
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Down() { }

	// RVA: 0x37BB90 Offset: 0x37A190 VA: 0x18037BB90 Slot: 47
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Press() { }

	// RVA: 0x37B250 Offset: 0x379850 VA: 0x18037B250 Slot: 48
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton1() { }

	// RVA: 0x37B290 Offset: 0x379890 VA: 0x18037B290 Slot: 49
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton2() { }

	// RVA: 0x37B2D0 Offset: 0x3798D0 VA: 0x18037B2D0 Slot: 50
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton3() { }

	// RVA: 0x37B310 Offset: 0x379910 VA: 0x18037B310 Slot: 51
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton4() { }

	// RVA: 0x37B350 Offset: 0x379950 VA: 0x18037B350 Slot: 52
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton5() { }

	// RVA: 0x37B390 Offset: 0x379990 VA: 0x18037B390 Slot: 53
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton6() { }

	// RVA: 0x37B3D0 Offset: 0x3799D0 VA: 0x18037B3D0 Slot: 54
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton7() { }

	// RVA: 0x37B410 Offset: 0x379A10 VA: 0x18037B410 Slot: 55
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton8() { }

	// RVA: 0x37B450 Offset: 0x379A50 VA: 0x18037B450 Slot: 56
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton9() { }

	// RVA: 0x37B210 Offset: 0x379810 VA: 0x18037B210 Slot: 57
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton10() { }

	// RVA: 0x37B7D0 Offset: 0x379DD0 VA: 0x18037B7D0 Slot: 58
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode1() { }

	// RVA: 0x37B810 Offset: 0x379E10 VA: 0x18037B810 Slot: 59
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode2() { }

	// RVA: 0x37B850 Offset: 0x379E50 VA: 0x18037B850 Slot: 60
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode3() { }

	// RVA: 0x37BC10 Offset: 0x37A210 VA: 0x18037BC10 Slot: 61
	private IControllerTemplateYoke Rewired.IFlightYokeTemplate.get_yoke() { }

	// RVA: 0x37B690 Offset: 0x379C90 VA: 0x18037B690 Slot: 62
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever1() { }

	// RVA: 0x37B6D0 Offset: 0x379CD0 VA: 0x18037B6D0 Slot: 63
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever2() { }

	// RVA: 0x37B710 Offset: 0x379D10 VA: 0x18037B710 Slot: 64
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever3() { }

	// RVA: 0x37B750 Offset: 0x379D50 VA: 0x18037B750 Slot: 65
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever4() { }

	// RVA: 0x37B790 Offset: 0x379D90 VA: 0x18037B790 Slot: 66
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever5() { }

	// RVA: 0x37B610 Offset: 0x379C10 VA: 0x18037B610 Slot: 67
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.get_leftGripHat() { }

	// RVA: 0x37BA10 Offset: 0x37A010 VA: 0x18037BA10 Slot: 68
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.get_rightGripHat() { }

	// RVA: 0x37B000 Offset: 0x379600 VA: 0x18037B000
	public void .ctor(object payload) { }

	// RVA: 0x37BC50 Offset: 0x37A250 VA: 0x18037BC50
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate // TypeDefIndex: 5179
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_leftPedal = 0;
	public const int elementId_rightPedal = 1;
	public const int elementId_slide = 2;

	// Properties
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.leftPedal { get; }
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.rightPedal { get; }
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.slide { get; }

	// Methods

	// RVA: 0x37AED0 Offset: 0x3794D0 VA: 0x18037AED0 Slot: 20
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_leftPedal() { }

	// RVA: 0x37AF10 Offset: 0x379510 VA: 0x18037AF10 Slot: 21
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_rightPedal() { }

	// RVA: 0x37AF50 Offset: 0x379550 VA: 0x18037AF50 Slot: 22
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_slide() { }

	// RVA: 0x37B000 Offset: 0x379600 VA: 0x18037B000
	public void .ctor(object payload) { }

	// RVA: 0x37AF90 Offset: 0x379590 VA: 0x18037AF90
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate // TypeDefIndex: 5180
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_positionX = 1;
	public const int elementId_positionY = 2;
	public const int elementId_positionZ = 0;
	public const int elementId_rotationX = 3;
	public const int elementId_rotationY = 5;
	public const int elementId_rotationZ = 4;
	public const int elementId_throttle1Axis = 6;
	public const int elementId_throttle1MinDetent = 50;
	public const int elementId_throttle2Axis = 7;
	public const int elementId_throttle2MinDetent = 51;
	public const int elementId_extraAxis1 = 8;
	public const int elementId_extraAxis2 = 9;
	public const int elementId_extraAxis3 = 10;
	public const int elementId_extraAxis4 = 11;
	public const int elementId_button1 = 12;
	public const int elementId_button2 = 13;
	public const int elementId_button3 = 14;
	public const int elementId_button4 = 15;
	public const int elementId_button5 = 16;
	public const int elementId_button6 = 17;
	public const int elementId_button7 = 18;
	public const int elementId_button8 = 19;
	public const int elementId_button9 = 20;
	public const int elementId_button10 = 21;
	public const int elementId_button11 = 22;
	public const int elementId_button12 = 23;
	public const int elementId_button13 = 24;
	public const int elementId_button14 = 25;
	public const int elementId_button15 = 26;
	public const int elementId_button16 = 27;
	public const int elementId_button17 = 28;
	public const int elementId_button18 = 29;
	public const int elementId_button19 = 30;
	public const int elementId_button20 = 31;
	public const int elementId_button21 = 55;
	public const int elementId_button22 = 56;
	public const int elementId_button23 = 57;
	public const int elementId_button24 = 58;
	public const int elementId_button25 = 59;
	public const int elementId_button26 = 60;
	public const int elementId_button27 = 61;
	public const int elementId_button28 = 62;
	public const int elementId_button29 = 63;
	public const int elementId_button30 = 64;
	public const int elementId_button31 = 65;
	public const int elementId_button32 = 66;
	public const int elementId_hat1Up = 32;
	public const int elementId_hat1UpRight = 33;
	public const int elementId_hat1Right = 34;
	public const int elementId_hat1DownRight = 35;
	public const int elementId_hat1Down = 36;
	public const int elementId_hat1DownLeft = 37;
	public const int elementId_hat1Left = 38;
	public const int elementId_hat1UpLeft = 39;
	public const int elementId_hat2Up = 40;
	public const int elementId_hat2UpRight = 41;
	public const int elementId_hat2Right = 42;
	public const int elementId_hat2DownRight = 43;
	public const int elementId_hat2Down = 44;
	public const int elementId_hat2DownLeft = 45;
	public const int elementId_hat2Left = 46;
	public const int elementId_hat2UpLeft = 47;
	public const int elementId_hat1 = 48;
	public const int elementId_hat2 = 49;
	public const int elementId_throttle1 = 52;
	public const int elementId_throttle2 = 53;
	public const int elementId_stick = 54;

	// Properties
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis1 { get; }
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis2 { get; }
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis3 { get; }
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis4 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button1 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button2 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button3 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button4 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button5 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button6 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button7 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button8 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button9 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button10 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button11 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button12 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button13 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button14 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button15 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button16 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button17 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button18 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button19 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button20 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button21 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button22 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button23 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button24 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button25 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button26 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button27 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button28 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button29 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button30 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button31 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button32 { get; }
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat1 { get; }
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat2 { get; }
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle1 { get; }
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle2 { get; }
	private IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.stick { get; }

	// Methods

	// RVA: 0x383370 Offset: 0x381970 VA: 0x180383370 Slot: 20
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis1() { }

	// RVA: 0x3833B0 Offset: 0x3819B0 VA: 0x1803833B0 Slot: 21
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis2() { }

	// RVA: 0x3833F0 Offset: 0x3819F0 VA: 0x1803833F0 Slot: 22
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis3() { }

	// RVA: 0x383430 Offset: 0x381A30 VA: 0x180383430 Slot: 23
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis4() { }

	// RVA: 0x382DF0 Offset: 0x3813F0 VA: 0x180382DF0 Slot: 24
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button1() { }

	// RVA: 0x3830B0 Offset: 0x3816B0 VA: 0x1803830B0 Slot: 25
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button2() { }

	// RVA: 0x3831B0 Offset: 0x3817B0 VA: 0x1803831B0 Slot: 26
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button3() { }

	// RVA: 0x3831F0 Offset: 0x3817F0 VA: 0x1803831F0 Slot: 27
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button4() { }

	// RVA: 0x383230 Offset: 0x381830 VA: 0x180383230 Slot: 28
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button5() { }

	// RVA: 0x383270 Offset: 0x381870 VA: 0x180383270 Slot: 29
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button6() { }

	// RVA: 0x3832B0 Offset: 0x3818B0 VA: 0x1803832B0 Slot: 30
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button7() { }

	// RVA: 0x3832F0 Offset: 0x3818F0 VA: 0x1803832F0 Slot: 31
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button8() { }

	// RVA: 0x383330 Offset: 0x381930 VA: 0x180383330 Slot: 32
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button9() { }

	// RVA: 0x382B70 Offset: 0x381170 VA: 0x180382B70 Slot: 33
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button10() { }

	// RVA: 0x382BB0 Offset: 0x3811B0 VA: 0x180382BB0 Slot: 34
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button11() { }

	// RVA: 0x382BF0 Offset: 0x3811F0 VA: 0x180382BF0 Slot: 35
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button12() { }

	// RVA: 0x382C30 Offset: 0x381230 VA: 0x180382C30 Slot: 36
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button13() { }

	// RVA: 0x382C70 Offset: 0x381270 VA: 0x180382C70 Slot: 37
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button14() { }

	// RVA: 0x382CB0 Offset: 0x3812B0 VA: 0x180382CB0 Slot: 38
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button15() { }

	// RVA: 0x382CF0 Offset: 0x3812F0 VA: 0x180382CF0 Slot: 39
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button16() { }

	// RVA: 0x382D30 Offset: 0x381330 VA: 0x180382D30 Slot: 40
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button17() { }

	// RVA: 0x382D70 Offset: 0x381370 VA: 0x180382D70 Slot: 41
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button18() { }

	// RVA: 0x382DB0 Offset: 0x3813B0 VA: 0x180382DB0 Slot: 42
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button19() { }

	// RVA: 0x382E30 Offset: 0x381430 VA: 0x180382E30 Slot: 43
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button20() { }

	// RVA: 0x382E70 Offset: 0x381470 VA: 0x180382E70 Slot: 44
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button21() { }

	// RVA: 0x382EB0 Offset: 0x3814B0 VA: 0x180382EB0 Slot: 45
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button22() { }

	// RVA: 0x382EF0 Offset: 0x3814F0 VA: 0x180382EF0 Slot: 46
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button23() { }

	// RVA: 0x382F30 Offset: 0x381530 VA: 0x180382F30 Slot: 47
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button24() { }

	// RVA: 0x382F70 Offset: 0x381570 VA: 0x180382F70 Slot: 48
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button25() { }

	// RVA: 0x382FB0 Offset: 0x3815B0 VA: 0x180382FB0 Slot: 49
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button26() { }

	// RVA: 0x382FF0 Offset: 0x3815F0 VA: 0x180382FF0 Slot: 50
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button27() { }

	// RVA: 0x383030 Offset: 0x381630 VA: 0x180383030 Slot: 51
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button28() { }

	// RVA: 0x383070 Offset: 0x381670 VA: 0x180383070 Slot: 52
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button29() { }

	// RVA: 0x3830F0 Offset: 0x3816F0 VA: 0x1803830F0 Slot: 53
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button30() { }

	// RVA: 0x383130 Offset: 0x381730 VA: 0x180383130 Slot: 54
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button31() { }

	// RVA: 0x383170 Offset: 0x381770 VA: 0x180383170 Slot: 55
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button32() { }

	// RVA: 0x383470 Offset: 0x381A70 VA: 0x180383470 Slot: 56
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat1() { }

	// RVA: 0x3834B0 Offset: 0x381AB0 VA: 0x1803834B0 Slot: 57
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat2() { }

	// RVA: 0x383530 Offset: 0x381B30 VA: 0x180383530 Slot: 58
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle1() { }

	// RVA: 0x383570 Offset: 0x381B70 VA: 0x180383570 Slot: 59
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle2() { }

	// RVA: 0x3834F0 Offset: 0x381AF0 VA: 0x1803834F0 Slot: 60
	private IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.get_stick() { }

	// RVA: 0x37B000 Offset: 0x379600 VA: 0x18037B000
	public void .ctor(object payload) { }

	// RVA: 0x3835B0 Offset: 0x381BB0 VA: 0x1803835B0
	private static void .cctor() { }
}

// Namespace: Rewired
[AddComponentMenu("Rewired/Input Manager")]
[EditorBrowsable(1)]
public sealed class InputManager : InputManager_Base // TypeDefIndex: 5181
{
	// Fields
	private bool ignoreRecompile; // 0x58

	// Methods

	// RVA: 0x37DC40 Offset: 0x37C240 VA: 0x18037DC40 Slot: 4
	protected override void OnInitialized() { }

	// RVA: 0x37DC30 Offset: 0x37C230 VA: 0x18037DC30 Slot: 5
	protected override void OnDeinitialized() { }

	// RVA: 0x37DB90 Offset: 0x37C190 VA: 0x18037DB90 Slot: 6
	protected override void DetectPlatform() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected override void CheckRecompile() { }

	// RVA: 0x37DBE0 Offset: 0x37C1E0 VA: 0x18037DBE0 Slot: 8
	protected override IExternalTools GetExternalTools() { }

	// RVA: 0x37DAE0 Offset: 0x37C0E0 VA: 0x18037DAE0
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel) { }

	// RVA: 0x37DC40 Offset: 0x37C240 VA: 0x18037DC40
	private void SubscribeEvents() { }

	// RVA: 0x37DCF0 Offset: 0x37C2F0 VA: 0x18037DCF0
	private void UnsubscribeEvents() { }

	// RVA: 0x37DCE0 Offset: 0x37C2E0 VA: 0x18037DCE0
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x37DD80 Offset: 0x37C380 VA: 0x18037DD80
	public void .ctor() { }
}

