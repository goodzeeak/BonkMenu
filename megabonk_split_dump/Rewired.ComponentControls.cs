// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[Serializable]
public abstract class ComponentControl : MonoBehaviour, IComponentControl // TypeDefIndex: 2708
{
	// Fields
	private IComponentController _controller; // 0x20
	private bool WxQEBisVmcHUMNgnsMNbwooAWwCN; // 0x28
	private bool pFvdugceMtxxOthujpqkIPGHwDDiA; // 0x29
	private int _lastUpdateFrame; // 0x2C

	// Properties
	internal abstract bool wKSJYuNWaWSPZSUdNoUHPyLlCbep { get; }
	internal bool nupFXudRnKEERXEMoxkvlOuQkxWo { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool OMgnHLWaKneNrHlaeWygBYXMDjrAA();

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	internal bool mjaJTVvoMrrHWPnzcOEXzaGJdOtM() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774E40 Offset: 0x1773440 VA: 0x181774E40
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ClearValue();

	// RVA: 0x1774D10 Offset: 0x1773310 VA: 0x181774D10 Slot: 4
	private void Rewired.ComponentControls.IComponentControl.Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774A10 Offset: 0x1773010 VA: 0x181774A10 Slot: 8
	internal virtual void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	internal virtual void Start() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774B80 Offset: 0x1773180 VA: 0x181774B80 Slot: 10
	internal virtual void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774B10 Offset: 0x1773110 VA: 0x181774B10 Slot: 11
	internal virtual void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	internal virtual void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774C90 Offset: 0x1773290 VA: 0x181774C90 Slot: 13
	internal virtual void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774AF0 Offset: 0x17730F0 VA: 0x181774AF0 Slot: 14
	internal virtual void OnCanvasGroupChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774AF0 Offset: 0x17730F0 VA: 0x181774AF0 Slot: 15
	internal virtual void OnTransformParentChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 16
	internal virtual void OnDidApplyAnimationProperties() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 17
	internal virtual void Reset() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 18
	internal virtual void UjYAamsdzBByKqJeCzTogWwkpzPq() { }

	// RVA: 0x1774EA0 Offset: 0x17734A0 VA: 0x181774EA0 Slot: 19
	internal virtual bool pSfLXLykqGsrHeXOKVHkoiqvAwzcA() { }

	// RVA: 0x1775120 Offset: 0x1773720 VA: 0x181775120 Slot: 20
	internal virtual void xlshkLiVaPQfkaubhIUDfrmClVY() { }

	// RVA: 0x1774E00 Offset: 0x1773400 VA: 0x181774E00 Slot: 21
	internal virtual void YPIpAATaLSbyQilpgKOjbXBAhEqXA() { }

	// RVA: 0x1775110 Offset: 0x1773710 VA: 0x181775110 Slot: 22
	internal virtual void wKtlVbgqdJHWDjRQWgYcGuxfgWDxA() { }

	// RVA: 0x1774C90 Offset: 0x1773290 VA: 0x181774C90 Slot: 23
	internal virtual void PCavBKUOTQxjogDkKkwMMvzHZTRh() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 24
	internal virtual void uejyLnYLOhZNmitUQHKQQMEZdrEY() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 25
	internal virtual void qtZqEKmcBeznBvpwZlLBySPsIsmM() { }

	// RVA: 0x1774AA0 Offset: 0x17730A0 VA: 0x181774AA0
	internal bool KumenAicfBvAvvOgJjJtpMqkIdLrA() { }

	// RVA: 0x1774E50 Offset: 0x1773450 VA: 0x181774E50
	internal bool fbMrllBqvZAEgxfELaKoJyFHJrfgA() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal IComponentController xTQkisfrUGLJnijnYWdfNshhGakc() { }

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 26
	internal abstract IComponentController FindController();

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 27
	internal abstract Type GetRequiredControllerType();

	[IteratorStateMachine(typeof(ComponentControl.jQwvusFgsusvHulzjgMhLNIewDxw))]
	// RVA: 0x1774A30 Offset: 0x1773030 VA: 0x181774A30
	private IEnumerator GqLRBpOsBEyoevIpNpTBVettXluG() { }

	// RVA: 0x1774CB0 Offset: 0x17732B0 VA: 0x181774CB0
	private void QfsCrGBNzeuQXEDhPltecGLJcwGpA() { }

	// RVA: 0x1774F10 Offset: 0x1773510 VA: 0x181774F10
	private bool vHhgmbVYyIdnbYGhScfYVnTxixXi(bool , bool ) { }

	// RVA: 0x1774A20 Offset: 0x1773020 VA: 0x181774A20
	private void DCrgFnihSKUORstVQxazizoHWOZWA() { }

	// RVA: 0x1774D50 Offset: 0x1773350 VA: 0x181774D50
	private void RxmxxIOASPIZteDowNdkBLGaftqu() { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[Serializable]
public abstract class ComponentController : MonoBehaviour, IComponentController, IRegistrar<IComponentControl> // TypeDefIndex: 2710
{
	// Fields
	private bool QYQbImJEnYgNkSYdgGvyedFFOJRsA; // 0x20
	private bool mqBrYwowSousTwsUDGIZcrmWemmn; // 0x21
	private List<IComponentControl> _controls; // 0x28

	// Properties
	internal bool qDfffMLSiSQvOXmYgcdlmgLFwWHU { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	internal bool SwVyssqDnUYDsEHcesXlzmvQExSA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17755B0 Offset: 0x1773BB0 VA: 0x1817755B0
	internal void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17751B0 Offset: 0x17737B0 VA: 0x1817751B0 Slot: 7
	internal virtual void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17754C0 Offset: 0x1773AC0 VA: 0x1817754C0 Slot: 8
	internal virtual void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1775330 Offset: 0x1773930 VA: 0x181775330 Slot: 9
	internal virtual void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1775310 Offset: 0x1773910 VA: 0x181775310 Slot: 10
	internal virtual void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00 Slot: 11
	internal virtual void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17752B0 Offset: 0x17738B0 VA: 0x1817752B0 Slot: 12
	internal virtual void OnDestroy() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 13
	internal virtual bool rjQJHucPbYJcRVnREFcEEEXpbVnAA() { }

	// RVA: 0x398D10 Offset: 0x397310 VA: 0x180398D10 Slot: 14
	internal virtual void IzXasWjsPBhTqjNhVojyvvKyIkFZ() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	internal virtual void GIwlJZRSZgetsqmmxaDeFkBMgXbyA() { }

	// RVA: 0x1775460 Offset: 0x1773A60 VA: 0x181775460 Slot: 5
	private void Rewired.Utils.Interfaces.IRegistrar<Rewired.ComponentControls.IComponentControl>.Register(IComponentControl control) { }

	// RVA: 0x17753F0 Offset: 0x17739F0 VA: 0x1817753F0 Slot: 6
	private void Rewired.Utils.Interfaces.IRegistrar<Rewired.ComponentControls.IComponentControl>.Deregister(IComponentControl control) { }

	// RVA: 0x17751C0 Offset: 0x17737C0 VA: 0x1817751C0 Slot: 16
	public virtual void ClearControlValues() { }

	// RVA: 0x1775630 Offset: 0x1773C30 VA: 0x181775630
	private void eefHgIzbWdEFJJKMybMuIQbDFVJOB() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void ccDEnxRnwahBFAVJFgYcHIgyAyBj() { }

	[IteratorStateMachine(typeof(ComponentController.fvIFvFhYGxdEloaGpEMMbSrmYVUn))]
	// RVA: 0x1775680 Offset: 0x1773C80 VA: 0x181775680
	private IEnumerator eiIDdOBzQUTZuZolCCKnsCoXTxCd() { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[AddComponentMenu("Rewired/Component Controls/Custom Controller")]
[Serializable]
public class CustomController : ComponentController // TypeDefIndex: 2713
{
	// Fields
	[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Custom Controller elements, etc.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private InputManager_Base _rewiredInputManager; // 0x30
	[Tooltip("Contains search parameters to find a particular Custom Controller.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerSelector _customControllerSelector; // 0x38
	[Tooltip("Settings for creating a Custom Controller on start.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomController.CreateCustomControllerSettings _createCustomControllerSettings; // 0x40
	private List<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi> dYOhxGRPDaALaQvfWRUgrOnMJvWP; // 0x48
	private int fNHKuKtdCiMySncnPzFSxKTtofyq; // 0x50
	private Action edUAFqgDlsFShvvoowSWjCvHHuLR; // 0x58

	// Properties
	public InputManager_Base rewiredInputManager { get; set; }
	public CustomControllerSelector customControllerSelector { get; }
	public CustomController.CreateCustomControllerSettings createCustomControllerSettings { get; }

	// Methods

	// RVA: 0x17778E0 Offset: 0x1775EE0 VA: 0x1817778E0
	internal void add_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x1777E00 Offset: 0x1776400 VA: 0x181777E00
	internal void remove_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public InputManager_Base get_rewiredInputManager() { }

	// RVA: 0x1777EA0 Offset: 0x17764A0 VA: 0x181777EA0
	public void set_rewiredInputManager(InputManager_Base value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public CustomControllerSelector get_customControllerSelector() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public CustomController.CreateCustomControllerSettings get_createCustomControllerSettings() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17775D0 Offset: 0x1775BD0 VA: 0x1817775D0
	internal void .ctor() { }

	// RVA: 0x1776A50 Offset: 0x1775050 VA: 0x181776A50
	public CustomController GetCustomController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1775330 Offset: 0x1773930 VA: 0x181775330 Slot: 9
	internal override void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1776B70 Offset: 0x1775170 VA: 0x181776B70 Slot: 10
	internal override void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1776E80 Offset: 0x1775480 VA: 0x181776E80 Slot: 11
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1776A60 Offset: 0x1775060 VA: 0x181776A60 Slot: 12
	internal override void OnDestroy() { }

	// RVA: 0x1776BE0 Offset: 0x17751E0 VA: 0x181776BE0 Slot: 13
	internal override bool OnInitialize() { }

	// RVA: 0x1776CE0 Offset: 0x17752E0 VA: 0x181776CE0 Slot: 14
	internal override void OnSubscribeEvents() { }

	// RVA: 0x1776DF0 Offset: 0x17753F0 VA: 0x181776DF0 Slot: 15
	internal override void OnUnsubscribeEvents() { }

	// RVA: 0x1776120 Offset: 0x1774720 VA: 0x181776120 Slot: 16
	public override void ClearControlValues() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 20
	internal virtual bool GetUseCustomController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	internal virtual void SetUseCustomController(bool value) { }

	// RVA: 0x1776F20 Offset: 0x1775520 VA: 0x181776F20
	internal void SetAxisValue(CustomControllerElementSelector element, float value) { }

	// RVA: 0x1777120 Offset: 0x1775720 VA: 0x181777120
	internal void SetButtonValue(CustomControllerElementSelector element, bool value) { }

	// RVA: 0x1776250 Offset: 0x1774850 VA: 0x181776250
	internal void ClearElementValue(CustomControllerElementTargetSet targetSet) { }

	// RVA: 0x1776480 Offset: 0x1774A80 VA: 0x181776480
	internal void ClearElementValue(CustomControllerElementTarget target) { }

	// RVA: 0x17762E0 Offset: 0x17748E0 VA: 0x1817762E0
	internal void ClearElementValue(CustomControllerElementSelector element) { }

	// RVA: 0x17764A0 Offset: 0x1774AA0 VA: 0x1817764A0
	internal int ElementExists_Editor(CustomControllerElementSelector element) { }

	// RVA: 0x17766E0 Offset: 0x1774CE0 VA: 0x1817766E0
	internal bool ElementExists(CustomControllerElementSelector element) { }

	// RVA: 0x1777510 Offset: 0x1775B10 VA: 0x181777510
	internal bool ValidateElements(CustomControllerElementTargetSet targetSet) { }

	// RVA: 0x1777310 Offset: 0x1775910 VA: 0x181777310
	internal bool ValidateElement(CustomControllerElementTarget target) { }

	// RVA: 0x1777330 Offset: 0x1775930 VA: 0x181777330
	internal bool ValidateElement(CustomControllerElementSelector element) { }

	// RVA: 0x1776ED0 Offset: 0x17754D0 VA: 0x181776ED0
	private void RimrAZGkeFhACqOEGRoLvBavFwXiA() { }

	// RVA: 0x1777D40 Offset: 0x1776340 VA: 0x181777D40
	private bool lMKUWIPdbFzMcSMSSeJmgvdiaHNXA() { }

	// RVA: 0x1777AF0 Offset: 0x17760F0 VA: 0x181777AF0
	private void ePifCscygWbXBDNaYtWRslkKGqXc() { }

	// RVA: 0x1776730 Offset: 0x1774D30 VA: 0x181776730
	private CustomController FMSplgsPBwzOYerBozQTwAnjAnUB(bool ) { }

	// RVA: 0x1777980 Offset: 0x1775F80 VA: 0x181777980
	private void aoYhFuEifkDRqIGefXeRwwrGvwssA(CustomController ) { }

	// RVA: 0x1777C80 Offset: 0x1776280 VA: 0x181777C80
	private void kmkuHNcyVkDTTSernCmTxWOFaYqhA() { }

	// RVA: 0x1777730 Offset: 0x1775D30 VA: 0x181777730
	private void aJrJDEXKHDZbKvXbRHwqcmSrOCtr() { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[Serializable]
public abstract class CustomControllerControl : ComponentControl // TypeDefIndex: 2714
{
	// Properties
	internal CustomController UEyBBtoPtEFqRBAUuqoFIKGZPYeq { get; }
	internal override bool wKSJYuNWaWSPZSUdNoUHPyLlCbep { get; }

	// Methods

	// RVA: 0x1775E40 Offset: 0x1774440 VA: 0x181775E40
	internal CustomController ftkqeKDjPXRSKTFgcWbamcGhbPcn() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774E40 Offset: 0x1773440 VA: 0x181774E40
	internal void .ctor() { }

	// RVA: 0x1775A70 Offset: 0x1774070 VA: 0x181775A70 Slot: 6
	internal override bool OMgnHLWaKneNrHlaeWygBYXMDjrAA() { }

	// RVA: 0x1775B20 Offset: 0x1774120 VA: 0x181775B20 Slot: 21
	internal override void UVZGxPWwcpxpTMkbgdkEtEpLhYei() { }

	// RVA: 0x1775FE0 Offset: 0x17745E0 VA: 0x181775FE0 Slot: 22
	internal override void rudbFlehPdwSmMhyrCJLpnVGinqJA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1775720 Offset: 0x1773D20 VA: 0x181775720 Slot: 26
	internal override IComponentController FindController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1775790 Offset: 0x1773D90 VA: 0x181775790 Slot: 27
	internal override Type GetRequiredControllerType() { }

	// RVA: 0x1775950 Offset: 0x1773F50 VA: 0x181775950
	internal void MKqOIMmozyhUGkNGaBAgeuPjusem(CustomControllerElementTargetSet , float , float ) { }

	// RVA: 0x1775ED0 Offset: 0x17744D0 VA: 0x181775ED0
	internal void mVGouiyYIFWLbehVbdTXdBDGfvWx(CustomControllerElementTargetSet , bool ) { }

	// RVA: -1 Offset: -1 Slot: 30
	internal abstract void JjbSogcowrvbvmUaaVAcTDurzTkd();

	// RVA: 0x17757E0 Offset: 0x1773DE0 VA: 0x1817757E0
	private void HGOwxnubCbpVtKjsOcCNwDOlZDbt(CustomControllerElementTarget , float , float ) { }

	// RVA: 0x1775C80 Offset: 0x1774280 VA: 0x181775C80
	private void XyUEtMXklqqQyQKshhrAmFUcGjwCA(CustomControllerElementTarget , bool ) { }

	// RVA: 0x1775D90 Offset: 0x1774390 VA: 0x181775D90
	private void cbgJYeztBqJSQlkhZHldYdTkgmRdA() { }
}

// Namespace: Rewired.ComponentControls
public interface IComponentControl // TypeDefIndex: 2715
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ClearValue();
}

// Namespace: Rewired.ComponentControls
public interface IComponentController : IRegistrar<IComponentControl> // TypeDefIndex: 2716
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ClearControlValues();
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Component Controls/Tilt Control")]
[Serializable]
public sealed class TiltControl : CustomControllerControl // TypeDefIndex: 2718
{
	// Fields
	private const float maxFullTiltAngle = 180;
	private const float maxAngleOffset = 90;
	[Tooltip("The tilt directions in which movement is allowed. You can restrict movement to one or both directions.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TiltControl.TiltDirection _allowedTiltDirections; // 0x30
	[Tooltip("The Custom Controller element that will receive input values from the X axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement; // 0x38
	[Tooltip("The maximum horizontal tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 180)]
	private float _horizontalTiltLimit; // 0x40
	[Tooltip("The offset angle from horizontal which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(-90, 90)]
	private float _horizontalRestAngle; // 0x44
	[Tooltip("The Custom Controller element that will receive input values from the Y axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement; // 0x48
	[Tooltip("The maximum forward tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 180)]
	private float _forwardTiltLimit; // 0x50
	[Tooltip("The offset angle from vertical which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt. A typical value would be around 40 degrees.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(-90, 90)]
	private float _forwardRestAngle; // 0x54
	[Tooltip("The underlying 2D axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private StandaloneAxis2D _axis2D; // 0x58
	private bool _useHAxis; // 0x60
	private bool _useFAxis; // 0x61
	private Func<Vector3> _getAccelerationValue; // 0x68

	// Properties
	public TiltControl.TiltDirection axesToUse { get; set; }
	public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement { get; }
	public float horizontalTiltLimit { get; set; }
	public float horizontalRestAngle { get; set; }
	public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement { get; }
	public float forwardTiltLimit { get; set; }
	public float forwardRestAngle { get; set; }
	public AxisCalibration horizontalAxisCalibration { get; }
	public AxisCalibration verticalAxisCalibration { get; }
	[Obsolete("Use axis2DCalibration instead.", False)]
	public Axis2DCalibration deadZoneType { get; }
	public Axis2DCalibration axis2DCalibration { get; }
	internal StandaloneAxis2D muyEXkjhAFpcxBveIAEqqVPQmLxo { get; }
	private Vector3 qVWWasgvCgeMAOOpIqvCvuvdIxgO { get; }

	// Methods

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public TiltControl.TiltDirection get_axesToUse() { }

	// RVA: 0x1783720 Offset: 0x1781D20 VA: 0x181783720
	public void set_axesToUse(TiltControl.TiltDirection value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public CustomControllerElementTargetSetForFloat get_horizontalTiltCustomControllerElement() { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_horizontalTiltLimit() { }

	// RVA: 0x1783870 Offset: 0x1781E70 VA: 0x181783870
	public void set_horizontalTiltLimit(float value) { }

	// RVA: 0x46E1F0 Offset: 0x46C7F0 VA: 0x18046E1F0
	public float get_horizontalRestAngle() { }

	// RVA: 0x1783810 Offset: 0x1781E10 VA: 0x181783810
	public void set_horizontalRestAngle(float value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public CustomControllerElementTargetSetForFloat get_forwardTiltCustomControllerElement() { }

	// RVA: 0x34DA80 Offset: 0x34C080 VA: 0x18034DA80
	public float get_forwardTiltLimit() { }

	// RVA: 0x17837C0 Offset: 0x1781DC0 VA: 0x1817837C0
	public void set_forwardTiltLimit(float value) { }

	// RVA: 0x17836B0 Offset: 0x1781CB0 VA: 0x1817836B0
	public float get_forwardRestAngle() { }

	// RVA: 0x1783760 Offset: 0x1781D60 VA: 0x181783760
	public void set_forwardRestAngle(float value) { }

	// RVA: 0x17836C0 Offset: 0x1781CC0 VA: 0x1817836C0
	public AxisCalibration get_horizontalAxisCalibration() { }

	// RVA: 0x17836F0 Offset: 0x1781CF0 VA: 0x1817836F0
	public AxisCalibration get_verticalAxisCalibration() { }

	// RVA: 0x165BEA0 Offset: 0x165A4A0 VA: 0x18165BEA0
	public Axis2DCalibration get_deadZoneType() { }

	// RVA: 0x165BEA0 Offset: 0x165A4A0 VA: 0x18165BEA0
	public Axis2DCalibration get_axis2DCalibration() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal StandaloneAxis2D KlUVAxpdgGyHFhqAUbdKIcFbYqeoA() { }

	// RVA: 0x1783660 Offset: 0x1781C60 VA: 0x181783660
	private Vector3 fWZCPkOoFshJdZIzcuyrfLhREmkh() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1783570 Offset: 0x1781B70 VA: 0x181783570
	internal void .ctor() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void SetAccelerationSourceCallback(Func<Vector3> callback) { }

	// RVA: 0x1783000 Offset: 0x1781600 VA: 0x181783000
	public void SetRestOrientation() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1782FC0 Offset: 0x17815C0 VA: 0x181782FC0 Slot: 13
	internal override void OnValidate() { }

	// RVA: 0x17834F0 Offset: 0x1781AF0 VA: 0x1817834F0 Slot: 19
	internal override bool YxrNnxIxfszgFLzBopFiDrwnublb() { }

	// RVA: 0x1783650 Offset: 0x1781C50 VA: 0x181783650 Slot: 18
	internal override void cRUrQemCrvmsWgckyxfkeLuxTPUw() { }

	// RVA: 0x1782EC0 Offset: 0x17814C0 VA: 0x181782EC0 Slot: 30
	internal override void OHgKTPARmjKbTctvEPdZgEJARvdB() { }

	// RVA: 0x1782D30 Offset: 0x1781330 VA: 0x181782D30 Slot: 7
	public override void ClearValue() { }

	// RVA: 0x1783120 Offset: 0x1781720 VA: 0x181783120
	private void XATvNaGpTtEWkIdMTuzhgCDYWEiR() { }

	// RVA: 0x17838C0 Offset: 0x1781EC0 VA: 0x1817838C0
	private void uhUBwxKCAzoucjxllrzQaSHjCrKh() { }

	// RVA: 0x1783950 Offset: 0x1781F50 VA: 0x181783950
	private void yjBKUqTvtMfxTSljbQJPaxGOWdgR(TiltControl.TiltDirection ) { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[AddComponentMenu("Rewired/Touch Controls/Touch Button")]
[Serializable]
public sealed class TouchButton : TouchInteractable // TypeDefIndex: 2727
{
	// Fields
	private const float fAjFkZWUApqqSLYUlpHdcUjVCAvq = 20;
	[Tooltip("The Custom Controller element that will receive input values from this control.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForFloat _targetCustomControllerElement; // 0x130
	[Tooltip("The type of button.
Standard: A momentary switch. Returns True while the button is pressed down.
Toggle Switch: Alternately turns on and off with each press.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchButton.ButtonType _buttonType; // 0x138
	[Tooltip("If true, the button can be turned on by a touch swipe that began in an area outside the button region. If false, the button can only be turned on by a direct press.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _activateOnSwipeIn; // 0x13C
	[Tooltip("If true, the button will stay on even if the touch that activated it moves outside the button region. If false, the button will turn off once the touch that activated it moves outside the button region.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _stayActiveOnSwipeOut; // 0x13D
	[Tooltip("Makes the axis value gradually change over time based on gravity and sensitivity as the button is pressed.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useDigitalAxisSimulation; // 0x13E
	[Tooltip("Speed (units/sec) that the axis value falls toward 0 when not pressed. A value of 1.0 means an axis value of 1 will drain to 0 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(0, ∞)]
	private float _digitalAxisGravity; // 0x140
	[Tooltip("Speed to move toward an axis value of 1.0 in units/sec when pressed. A value of 1.0 means an axis value of 0 will reach 1 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(0, ∞)]
	private float _digitalAxisSensitivity; // 0x144
	[Tooltip("The internal axis of the button. The axis is used for all value calculations.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private StandaloneAxis _axis; // 0x148
	[Tooltip("Optional external region to use for hover/click/touch detection. If set, this region will be used for touch detection instead of or in addition to the button's RectTransform. This can be useful if you want a larger area of the screen to act as a button.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchRegion _touchRegion; // 0x150
	[Tooltip("If True, hovers/clicks/touches on the local button will be ignored and only Touch Region touches will be used. Otherwise, both touches on the button and on the Touch Region will be used. This also applies to mouse hover. This setting has no effect if no Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useTouchRegionOnly; // 0x158
	[Tooltip("If True, the button will move to the location of the current touch in the Touch Region. This can be used to designate an area of the screen as a hot-spot for a button and have the button graphics follow the users touches. This only has an effect if a Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _moveToTouchPosition; // 0x159
	[Tooltip("If Move To Touch Position is enabled, this will make the button return to its original position after the press is released. This only has an effect if a Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _returnOnRelease; // 0x15A
	[Tooltip("If True, the button will follow the touch around until released. This setting overrides Move To Touch Position.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _followTouchPosition; // 0x15B
	[Tooltip("Should the button animate when moving to the touch point? This only has an effect if Move To Touch Position is True and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _animateOnMoveToTouch; // 0x15C
	[Tooltip("The speed at which the button will move toward the touch position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Move To Touch Position is True, Animate On Move To Touch is true, and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 20)]
	private float _moveToTouchSpeed; // 0x160
	[Tooltip("Should the button animate when moving back to its original position? This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _animateOnReturn; // 0x164
	[Tooltip("The speed at which the button will move back toward its original position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release and Animate on Return are both True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 20)]
	private float _returnSpeed; // 0x168
	[Tooltip("If True, it will attempt to automatically manage Graphic component raycasting for best results based on your current settings.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _manageRaycasting; // 0x16C
	private float tsAHpjvYbNCkRmEkFRNupXyxXOu; // 0x170
	private float eChgOsVuKawoXIuikCQxbwCXuhkg; // 0x174
	private TouchRegion QiIqoIyNJlwMgeRLukOPZZVPmfWp; // 0x178
	private Vector2 CbpkeimAaAkIWZPFyYJOZAImjdyiA; // 0x180
	private bool NrxNozasCOsncRdAzipAxzcCTQiF; // 0x188
	private bool zfoNRKAcrznzNymrHzvYXFkTmTvf; // 0x189
	private TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz jBbGyAAtARlNUQLXcUgppSibjFFd; // 0x18C
	private int oDlVNYNJMynnMcibpyXDANRWvSXl; // 0x190
	private int DkhtdAGrELiJLGzhbZpxchtuKVYG; // 0x194
	private bool TjFvEQwLLoKwqWnMWchhsXQdBpsx; // 0x198
	private bool zeGqkmgFpPTQodXskogRsPPGhSNc; // 0x199
	private IEnumerator UJuHLOkXjLXYQjuTFzCvEoFIwkNJ; // 0x1A0
	private ArkyMExcqvAjSSEgvKopSLEhHuEEA aUrGpxvNvFbrePxUGyFgRhqQDmBJ; // 0x1A8
	private Action<TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz> NlslHLQPJoWhviHQxgYgHMNpQpJd; // 0x1B0
	private Action<TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz> FPNoeVcnqegGVBWwWxIJlHKmTTvp; // 0x1B8
	[Tooltip("Event sent when the axis value changes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchButton.AxisValueChangedEventHandler _onAxisValueChanged; // 0x1C0
	[Tooltip("Event sent when the button value changes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchButton.ButtonValueChangedEventHandler _onButtonValueChanged; // 0x1C8
	[Tooltip("Event sent when the button is pressed.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchButton.ButtonDownEventHandler _onButtonDown; // 0x1D0
	[Tooltip("Event sent when the button is released.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchButton.ButtonUpEventHandler _onButtonUp; // 0x1D8
	private Dictionary<int, PointerEventData> cgOaamUtyKXCSaUhGmyEQFueZSYm; // 0x1E0

	// Properties
	public CustomControllerElementTargetSetForFloat targetCustomControllerElement { get; }
	public TouchButton.ButtonType buttonType { get; set; }
	public bool activateOnSwipeIn { get; set; }
	public bool stayActiveOnSwipeOut { get; set; }
	public bool useDigitalAxisSimulation { get; set; }
	public float digitalAxisGravity { get; set; }
	public float digitalAxisSensitivity { get; set; }
	public TouchRegion touchRegion { get; set; }
	public bool useTouchRegionOnly { get; set; }
	public bool moveToTouchPosition { get; set; }
	public bool returnOnRelease { get; set; }
	public bool followTouchPosition { get; set; }
	public bool animateOnMoveToTouch { get; set; }
	public float moveToTouchSpeed { get; set; }
	public bool animateOnReturn { get; set; }
	public float returnSpeed { get; set; }
	public bool manageRaycasting { get; set; }
	public int pointerId { get; set; }
	public bool hasPointer { get; }
	internal StandaloneAxis axis { get; }
	private Action<TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz> moveStartedDelegate { get; }
	private Action<TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz> moveEndedDelegate { get; }
	private float axisValue { get; }
	private float axisValuePrev { get; }
	private bool buttonValue { get; }
	private bool buttonValuePrev { get; }
	private int effectivePointerId { get; }

	// Methods

	// RVA: 0x17867B0 Offset: 0x1784DB0 VA: 0x1817867B0
	public void add_AxisValueChangedEvent(UnityAction<float> value) { }

	// RVA: 0x17877A0 Offset: 0x1785DA0 VA: 0x1817877A0
	public void remove_AxisValueChangedEvent(UnityAction<float> value) { }

	// RVA: 0x1786870 Offset: 0x1784E70 VA: 0x181786870
	public void add_ButtonValueChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x1787860 Offset: 0x1785E60 VA: 0x181787860
	public void remove_ButtonValueChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x1786810 Offset: 0x1784E10 VA: 0x181786810
	public void add_ButtonDownEvent(UnityAction value) { }

	// RVA: 0x1787800 Offset: 0x1785E00 VA: 0x181787800
	public void remove_ButtonDownEvent(UnityAction value) { }

	// RVA: 0x1786840 Offset: 0x1784E40 VA: 0x181786840
	public void add_ButtonUpEvent(UnityAction value) { }

	// RVA: 0x1787830 Offset: 0x1785E30 VA: 0x181787830
	public void remove_ButtonUpEvent(UnityAction value) { }

	// RVA: 0x17871D0 Offset: 0x17857D0 VA: 0x1817871D0
	public CustomControllerElementTargetSetForFloat get_targetCustomControllerElement() { }

	// RVA: 0x17870A0 Offset: 0x17856A0 VA: 0x1817870A0
	public TouchButton.ButtonType get_buttonType() { }

	// RVA: 0x17879F0 Offset: 0x1785FF0 VA: 0x1817879F0
	public void set_buttonType(TouchButton.ButtonType value) { }

	// RVA: 0x1787070 Offset: 0x1785670 VA: 0x181787070
	public bool get_activateOnSwipeIn() { }

	// RVA: 0x1787990 Offset: 0x1785F90 VA: 0x181787990
	public void set_activateOnSwipeIn(bool value) { }

	// RVA: 0x1787140 Offset: 0x1785740 VA: 0x181787140
	public bool get_stayActiveOnSwipeOut() { }

	// RVA: 0x1787C00 Offset: 0x1786200 VA: 0x181787C00
	public void set_stayActiveOnSwipeOut(bool value) { }

	// RVA: 0x17871F0 Offset: 0x17857F0 VA: 0x1817871F0
	public bool get_useDigitalAxisSimulation() { }

	// RVA: 0x1787CC0 Offset: 0x17862C0 VA: 0x181787CC0
	public void set_useDigitalAxisSimulation(bool value) { }

	// RVA: 0x17870B0 Offset: 0x17856B0 VA: 0x1817870B0
	public float get_digitalAxisGravity() { }

	// RVA: 0x1787A10 Offset: 0x1786010 VA: 0x181787A10
	public void set_digitalAxisGravity(float value) { }

	// RVA: 0x17870C0 Offset: 0x17856C0 VA: 0x1817870C0
	public float get_digitalAxisSensitivity() { }

	// RVA: 0x1787A40 Offset: 0x1786040 VA: 0x181787A40
	public void set_digitalAxisSensitivity(float value) { }

	// RVA: 0x17871E0 Offset: 0x17857E0 VA: 0x1817871E0
	public TouchRegion get_touchRegion() { }

	// RVA: 0x1787C20 Offset: 0x1786220 VA: 0x181787C20
	public void set_touchRegion(TouchRegion value) { }

	// RVA: 0x1787200 Offset: 0x1785800 VA: 0x181787200
	public bool get_useTouchRegionOnly() { }

	// RVA: 0x1787CE0 Offset: 0x17862E0 VA: 0x181787CE0
	public void set_useTouchRegionOnly(bool value) { }

	// RVA: 0x1787100 Offset: 0x1785700 VA: 0x181787100
	public bool get_moveToTouchPosition() { }

	// RVA: 0x1787AF0 Offset: 0x17860F0 VA: 0x181787AF0
	public void set_moveToTouchPosition(bool value) { }

	// RVA: 0x1787120 Offset: 0x1785720 VA: 0x181787120
	public bool get_returnOnRelease() { }

	// RVA: 0x1787B80 Offset: 0x1786180 VA: 0x181787B80
	public void set_returnOnRelease(bool value) { }

	// RVA: 0x17870D0 Offset: 0x17856D0 VA: 0x1817870D0
	public bool get_followTouchPosition() { }

	// RVA: 0x1787A70 Offset: 0x1786070 VA: 0x181787A70
	public void set_followTouchPosition(bool value) { }

	// RVA: 0x1787080 Offset: 0x1785680 VA: 0x181787080
	public bool get_animateOnMoveToTouch() { }

	// RVA: 0x17879B0 Offset: 0x1785FB0 VA: 0x1817879B0
	public void set_animateOnMoveToTouch(bool value) { }

	// RVA: 0x3527A0 Offset: 0x350DA0 VA: 0x1803527A0
	public float get_moveToTouchSpeed() { }

	// RVA: 0x1787B10 Offset: 0x1786110 VA: 0x181787B10
	public void set_moveToTouchSpeed(float value) { }

	// RVA: 0x1787090 Offset: 0x1785690 VA: 0x181787090
	public bool get_animateOnReturn() { }

	// RVA: 0x17879D0 Offset: 0x1785FD0 VA: 0x1817879D0
	public void set_animateOnReturn(bool value) { }

	// RVA: 0x1787130 Offset: 0x1785730 VA: 0x181787130
	public float get_returnSpeed() { }

	// RVA: 0x1787BA0 Offset: 0x17861A0 VA: 0x181787BA0
	public void set_returnSpeed(float value) { }

	// RVA: 0x17870F0 Offset: 0x17856F0 VA: 0x1817870F0
	public bool get_manageRaycasting() { }

	// RVA: 0x1787A90 Offset: 0x1786090 VA: 0x181787A90
	public void set_manageRaycasting(bool value) { }

	// RVA: 0x1787110 Offset: 0x1785710 VA: 0x181787110
	public int get_pointerId() { }

	// RVA: 0x1787B70 Offset: 0x1786170 VA: 0x181787B70
	public void set_pointerId(int value) { }

	// RVA: 0x17870E0 Offset: 0x17856E0 VA: 0x1817870E0
	public bool get_hasPointer() { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	internal StandaloneAxis get_axis() { }

	// RVA: 0x1785CE0 Offset: 0x17842E0 VA: 0x181785CE0
	private Action<TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz> UIhDIyFdKWoaDLjwIqhnNSntZIyJA() { }

	// RVA: 0x1784830 Offset: 0x1782E30 VA: 0x181784830
	private Action<TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz> OVJANkcRXpLLOSlzeoBQGaABJUEgb() { }

	// RVA: 0x1788890 Offset: 0x1786E90 VA: 0x181788890
	private float zzUcYMeCVUYpWqAvxBqoscAmiwuGb() { }

	// RVA: 0x1783CF0 Offset: 0x17822F0 VA: 0x181783CF0
	private float CJKOuoIbyIcYyeakgvtngQyzmCKY() { }

	// RVA: 0x1787360 Offset: 0x1785960 VA: 0x181787360
	private bool lxNAHrqPgblEmEKCZCCYzqLwPPwu() { }

	// RVA: 0x1783AA0 Offset: 0x17820A0 VA: 0x181783AA0
	private bool AQgyBMWqHBJerMvKZDStzrPotOtD() { }

	// RVA: 0x1787210 Offset: 0x1785810 VA: 0x181787210
	private int goVQhNVIDNxniMwcsnmUxXtalsJP() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17863E0 Offset: 0x17849E0 VA: 0x1817863E0
	private void .ctor() { }

	// RVA: 0x1785BD0 Offset: 0x17841D0 VA: 0x181785BD0
	public void SetRawValue(float value) { }

	// RVA: 0x1785B30 Offset: 0x1784130 VA: 0x181785B30
	public void SetDefaultPosition() { }

	// RVA: 0x1787240 Offset: 0x1785840 VA: 0x181787240
	private void gwuhSavTjFoSVMPuYBpBRSxauxsc(Vector2 ) { }

	// RVA: 0x1785A60 Offset: 0x1784060 VA: 0x181785A60
	public void ReturnToDefaultPosition(bool instant) { }

	// RVA: 0x1785AD0 Offset: 0x17840D0 VA: 0x181785AD0
	public void ReturnToDefaultPosition() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1783AD0 Offset: 0x17820D0 VA: 0x181783AD0 Slot: 8
	internal override void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1784AA0 Offset: 0x17830A0 VA: 0x181784AA0 Slot: 10
	internal override void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1784A60 Offset: 0x1783060 VA: 0x181784A60 Slot: 11
	internal override void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17853F0 Offset: 0x17839F0 VA: 0x1817853F0 Slot: 13
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17859C0 Offset: 0x1783FC0 VA: 0x1817859C0 Slot: 17
	internal override void Reset() { }

	// RVA: 0x1785270 Offset: 0x1783870 VA: 0x181785270 Slot: 18
	internal override void OnUpdate() { }

	// RVA: 0x1784AD0 Offset: 0x17830D0 VA: 0x181784AD0 Slot: 19
	internal override bool OnInitialize() { }

	// RVA: 0x17849C0 Offset: 0x1782FC0 VA: 0x1817849C0 Slot: 30
	internal override void OnCustomControllerUpdate() { }

	// RVA: 0x1784F10 Offset: 0x1783510 VA: 0x181784F10 Slot: 21
	internal override void OnSubscribeEvents() { }

	// RVA: 0x17850C0 Offset: 0x17836C0 VA: 0x1817850C0 Slot: 22
	internal override void OnUnsubscribeEvents() { }

	// RVA: 0x1784EB0 Offset: 0x17834B0 VA: 0x181784EB0 Slot: 23
	internal override void OnSetProperty() { }

	// RVA: 0x17848D0 Offset: 0x1782ED0 VA: 0x1817848D0 Slot: 24
	internal override void OnClear() { }

	// RVA: 0x1783D80 Offset: 0x1782380 VA: 0x181783D80 Slot: 7
	public override void ClearValue() { }

	// RVA: 0x1784310 Offset: 0x1782910 VA: 0x181784310 Slot: 42
	internal override bool IsPressed() { }

	// RVA: 0x17843B0 Offset: 0x17829B0 VA: 0x1817843B0 Slot: 43
	internal override bool IsThisOrTouchRegionGameObject(GameObject gameObject) { }

	// RVA: 0x17886B0 Offset: 0x1786CB0 VA: 0x1817886B0
	private void xwfFLuRVHVwZLNuDQkbgfrmHJtVj() { }

	// RVA: 0x17868D0 Offset: 0x1784ED0 VA: 0x1817868D0
	private void cHwTCdYGJFYeZbEFGWFxhnaEVzTp() { }

	// RVA: 0x17884B0 Offset: 0x1786AB0 VA: 0x1817884B0
	private void vbrmyrxuTyDYuivmnWvFsfvFZGGf() { }

	// RVA: 0x1785E20 Offset: 0x1784420 VA: 0x181785E20
	private void WjQXfnCqTvSAWCTPBjbbQZgTmZwT(float , bool ) { }

	// RVA: 0x1787900 Offset: 0x1785F00 VA: 0x181787900
	private void sDbytSfHsruVhqhqoBTcIezOmraQ() { }

	// RVA: 0x1783D30 Offset: 0x1782330 VA: 0x181783D30
	private void CdlSVoGfApfKzwWhpXJVfefGlgYj() { }

	// RVA: 0x1787390 Offset: 0x1785990 VA: 0x181787390
	private void mLdLcYSdzTGNnaGtghWewiamooCDb() { }

	// RVA: 0x1783A30 Offset: 0x1782030 VA: 0x181783A30
	private void AHPTpCHiCmaDAJmOEUOUiCZxYkVX() { }

	// RVA: 0x1785D80 Offset: 0x1784380 VA: 0x181785D80
	private bool UNtBkbhcQmIGPojelpIiaAKxYbzo() { }

	// RVA: 0x1786B40 Offset: 0x1785140 VA: 0x181786B40
	private void dzfRRsPYayPDQhciUjsZcAeNOSXCA(TouchRegion ) { }

	// RVA: 0x1786CD0 Offset: 0x17852D0 VA: 0x181786CD0
	private void ebKwQrPlwUcCZrrZABhPqTJIRoIq(TouchRegion ) { }

	// RVA: 0x1786E50 Offset: 0x1785450 VA: 0x181786E50
	private void ebaVekCyIQGeThPexwcRNbxOpZge() { }

	// RVA: 0x1787D00 Offset: 0x1786300 VA: 0x181787D00
	private void shBvXmoUZbPzOzVpfePBsJOovctl(Vector2 , bool , float , TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz ) { }

	// RVA: 0x17854C0 Offset: 0x1783AC0 VA: 0x1817854C0
	private void PfEUnZRiSuAkflrTmXAkYqhLQBXN(Vector2 , PositionType , bool , float , TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz ) { }

	[IteratorStateMachine(typeof(TouchButton.ihUyHfieHYRXvADPuNxiUoqiunkt))]
	// RVA: 0x1786700 Offset: 0x1784D00 VA: 0x181786700
	private IEnumerator aEBCfSFQWBHbhCvRZziGLFIeeeAIA(Vector2 , PositionType , float , TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz ) { }

	// RVA: 0x1788020 Offset: 0x1786620 VA: 0x181788020
	private void ulfAtBcYMbHaGITqdostcuiibsPob(TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz , Vector2 , PositionType ) { }

	// RVA: 0x1784510 Offset: 0x1782B10 VA: 0x181784510
	private void JfDXQnvlrFYhrrFBpDiCcHMvOrkyA(TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz ) { }

	// RVA: 0x1783E00 Offset: 0x1782400 VA: 0x181783E00
	private void DZajOjzzTAndHIdiheUueYPRaMGkA(TouchButton.uwIHpvVmsDEaEfdVpMdhPIDRSeAz ) { }

	// RVA: 0x1787250 Offset: 0x1785850 VA: 0x181787250
	private void jHvwzZlmhATDnAZmKfcNLvJbeQiP(int ) { }

	// RVA: 0x1787300 Offset: 0x1785900 VA: 0x181787300
	private void jbtNlYJNPDrdkNRzIoMJwLicLFRv() { }

	// RVA: 0x1786130 Offset: 0x1784730 VA: 0x181786130
	private void YxHbeSrQGaxByWEaRhnbztzAEWVeA() { }

	// RVA: 0x1785940 Offset: 0x1783F40 VA: 0x181785940
	private bool QtabBcFwHFTZVBKlRdcWbzjSNmtg() { }

	// RVA: 0x1785E00 Offset: 0x1784400 VA: 0x181785E00
	private void UTGAiGsPyCivxIsSLcVSHCPxTJfl() { }

	// RVA: 0x1785420 Offset: 0x1783A20 VA: 0x181785420
	private bool PKVZGgIdrxvvoewdeTLZFBAmGorQ(int ) { }

	// RVA: 0x1783F00 Offset: 0x1782500 VA: 0x181783F00
	private PointerEventData EMKwrnUTismCviJTOFTEjQKVVfblA(int , GameObject ) { }

	// RVA: 0x1786250 Offset: 0x1784850 VA: 0x181786250
	private PointerEventData ZPahbuoNtggtSDuZTpgaJnBbHRSn(int ) { }

	// RVA: 0x1785F80 Offset: 0x1784580 VA: 0x181785F80
	private void XPPJpyeAwXIEnnXYGXDmhHyQXPwE(PointerEventData ) { }

	// RVA: 0x1787490 Offset: 0x1785A90 VA: 0x181787490
	private PointerEventData maXisXPrntzTgaxgzhciUeFLovSJ(int ) { }

	// RVA: 0x1784600 Offset: 0x1782C00 VA: 0x181784600
	private void KwmVxilekbavMarqkgNjXTCrEuhyA(PointerEventData , TouchButton.aNAWfpSnWCOtAeVooUfSMexEGNCD ) { }

	// RVA: 0x1783BB0 Offset: 0x17821B0 VA: 0x181783BB0
	private void BlYgUWnbABtYxPGEnUlePHxRILwC(PointerEventData , TouchButton.aNAWfpSnWCOtAeVooUfSMexEGNCD ) { }

	// RVA: 0x1788190 Offset: 0x1786790 VA: 0x181788190
	private void vOEHBwEserFLuFcxJmqWYYTBScIA(PointerEventData , TouchButton.aNAWfpSnWCOtAeVooUfSMexEGNCD ) { }

	// RVA: 0x17869E0 Offset: 0x1784FE0 VA: 0x1817869E0
	private void crRjtFKPVTFdrjFOONOYUpocdXaCb(PointerEventData , TouchButton.aNAWfpSnWCOtAeVooUfSMexEGNCD ) { }

	// RVA: 0x17876B0 Offset: 0x1785CB0 VA: 0x1817876B0
	private void oIiEasJndBdgFuRSqCcXqQjvREro(int , Vector2 , TouchButton.aNAWfpSnWCOtAeVooUfSMexEGNCD ) { }

	// RVA: 0x1785C00 Offset: 0x1784200 VA: 0x181785C00
	private void TTzBMQmqdkTqHbkeigeiofLjeVBb() { }

	// RVA: 0x1784AF0 Offset: 0x17830F0 VA: 0x181784AF0 Slot: 44
	internal override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1784DC0 Offset: 0x17833C0 VA: 0x181784DC0 Slot: 45
	internal override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1784BE0 Offset: 0x17831E0 VA: 0x181784BE0 Slot: 46
	internal override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1784CD0 Offset: 0x17832D0 VA: 0x181784CD0 Slot: 47
	internal override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1785890 Offset: 0x1783E90 VA: 0x181785890
	private void QCZycLzuEgfowZOEJDcRiWXnVhchA(PointerEventData ) { }

	// RVA: 0x1787F70 Offset: 0x1786570 VA: 0x181787F70
	private void snyDcmgrlDikjrGjwDBqnUnuhHxH(PointerEventData ) { }

	// RVA: 0x1785ED0 Offset: 0x17844D0 VA: 0x181785ED0
	private void XEqdSwdNffGkwpFjAHgShcEBwxBJ(PointerEventData ) { }

	// RVA: 0x1788600 Offset: 0x1786C00 VA: 0x181788600
	private void xiubjgEGDCyoYVpPVebzRkcwhOUvA(PointerEventData ) { }

	// RVA: 0x1788580 Offset: 0x1786B80 VA: 0x181788580
	private void wKzjfiWSbzfibBPwTBjNmKhyrqkt(float ) { }

	// RVA: 0x1787420 Offset: 0x1785A20 VA: 0x181787420
	private void mVsFeduQazJgAbxFVxcLBwGxfVlj(bool ) { }

	// RVA: 0x17842D0 Offset: 0x17828D0 VA: 0x1817842D0
	private void FtreTZFIthhOHYggCCCkLRmlNNacb() { }

	// RVA: 0x17878C0 Offset: 0x1785EC0 VA: 0x1817878C0
	private void ruaORNDnBNLkHYrWFOHIRhprqhAf() { }
}

// Namespace: Rewired.ComponentControls
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[Serializable]
public abstract class TouchControl : CustomControllerControl // TypeDefIndex: 2728
{
	// Fields
	private Canvas _canvas; // 0x30
	private RectTransform __rectTransform; // 0x38

	// Properties
	internal TouchController xigqneIDmCDiLjNYtEWzAVeLexJWA { get; }
	internal Canvas phOuSfQimIOjLxBPgEEglddWdnOD { get; }
	internal RectTransform etqVOyGQlwdHbEsOeoTEaGeCpVNj { get; }
	internal RectTransform RpRmuuNFfEGvNgpXIdtljfXtksMCb { get; }
	internal override bool wKSJYuNWaWSPZSUdNoUHPyLlCbep { get; }

	// Methods

	// RVA: 0x1788C60 Offset: 0x1787260 VA: 0x181788C60
	internal TouchController gjNpqcGLKDReaYqzUCivpwkbuPbA() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal Canvas GpdBcbYrzCPJfVCdtyWaKurYayHB() { }

	// RVA: 0x1788CB0 Offset: 0x17872B0 VA: 0x181788CB0
	internal RectTransform jPTtLrwJDVpiYtJwMbxzqwjyGwuF() { }

	// RVA: 0x1788A80 Offset: 0x1787080 VA: 0x181788A80
	internal RectTransform YhYltQhnpECNNeUdnGtWlJbCKkhFA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1774E40 Offset: 0x1773440 VA: 0x181774E40
	internal void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1788A40 Offset: 0x1787040 VA: 0x181788A40 Slot: 13
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1788A00 Offset: 0x1787000 VA: 0x181788A00 Slot: 14
	internal override void OnCanvasGroupChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1788A00 Offset: 0x1787000 VA: 0x181788A00 Slot: 15
	internal override void OnTransformParentChanged() { }

	// RVA: 0x1788990 Offset: 0x1786F90 VA: 0x181788990 Slot: 6
	internal override bool OMgnHLWaKneNrHlaeWygBYXMDjrAA() { }

	// RVA: 0x1788D50 Offset: 0x1787350 VA: 0x181788D50 Slot: 19
	internal override bool poUqqfBRFpnqDvAuGNmJgHSkaSLf() { }

	// RVA: 0x1788C20 Offset: 0x1787220 VA: 0x181788C20 Slot: 23
	internal override void dErgKkFcxoyhCAGwpzOhcOxILjfuA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17888D0 Offset: 0x1786ED0 VA: 0x1817888D0 Slot: 26
	internal override IComponentController FindController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1788940 Offset: 0x1786F40 VA: 0x181788940 Slot: 27
	internal override Type GetRequiredControllerType() { }

	// RVA: 0x1788AF0 Offset: 0x17870F0 VA: 0x181788AF0
	private bool bcwcSSZTsPTDExmgaIHJyWCvjGuCA(bool , bool ) { }
}

// Namespace: Rewired.ComponentControls
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Touch Controller")]
[Serializable]
public sealed class TouchController : CustomController // TypeDefIndex: 2729
{
	// Fields
	[Tooltip("If true, disables mouse input when the Touch Controller script is enabled or GameObject is activated and re-enables mouse input when the script is disabled or GameObject is deactivated. This is useful for disabling Mouse Look controls when using touch controls in an FPS for example.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _disableMouseInputWhenEnabled; // 0x60
	[Tooltip("If true, a Custom Controller will be populated with the data from this controller.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useCustomController; // 0x61
	private bool gVoIkIbDZxEUZEJaPkeqGzYfmyizB; // 0x62

	// Properties
	public bool disableMouseInputWhenEnabled { get; set; }
	public bool useCustomController { get; set; }

	// Methods

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_disableMouseInputWhenEnabled() { }

	// RVA: 0x1789460 Offset: 0x1787A60 VA: 0x181789460
	public void set_disableMouseInputWhenEnabled(bool value) { }

	// RVA: 0x1380E10 Offset: 0x137F410 VA: 0x181380E10
	public bool get_useCustomController() { }

	// RVA: 0x1789470 Offset: 0x1787A70 VA: 0x181789470
	public void set_useCustomController(bool value) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1789000 Offset: 0x1787600 VA: 0x181789000
	private void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1788DE0 Offset: 0x17873E0 VA: 0x181788DE0 Slot: 10
	internal override void OnDisable() { }

	// RVA: 0x1789160 Offset: 0x1787760 VA: 0x181789160 Slot: 13
	internal override bool ldygopPMorQoyaBpDCVdyvtboAKX() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1380E10 Offset: 0x137F410 VA: 0x181380E10 Slot: 20
	internal override bool GetUseCustomController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x14C6DE0 Offset: 0x14C53E0 VA: 0x1814C6DE0 Slot: 21
	internal override void SetUseCustomController(bool value) { }

	// RVA: 0x1789390 Offset: 0x1787990 VA: 0x181789390
	private void ncCXCsLeEEocrMGvIqwQhdletSwv(bool ) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void rbFbmXMWeofHXdOiMfGpjmxAzebub() { }

	// RVA: 0x1788F40 Offset: 0x1787540 VA: 0x181788F40
	private bool TqhPmMkBYyNQfCOxBPEUmjDaxVuP() { }
}

// Namespace: Rewired.ComponentControls
[ExecuteInEditMode]
[DisallowMultipleComponent]
[Serializable]
public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 2738
{
	// Fields
	public const int POINTER_ID_NULL = -2147483648;
	public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1;
	public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2;
	public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3;
	internal const int MAX_MOUSE_BUTTONS = 3;
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Toggles whether the control can be interacted with by the user.")]
	private bool _interactable; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Toggles visibility. An invisible control can still be interacted with. This property only has any effect when used with an Image Component.")]
	private bool _visible; // 0x41
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Sets visibility to False when the control is idle. When the control is no longer idle, visibility will be set to True again.")]
	private bool _hideWhenIdle; // 0x42
	[Tooltip("The mouse buttons that are allowed to interact with this control.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Bitmask(typeof(TouchInteractable.MouseButtonFlags))]
	private TouchInteractable.MouseButtonFlags _allowedMouseButtons; // 0x44
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The transition type(s) to be used when transitioning to various states. Multiple transition types can be used simultaneously.")]
	[Bitmask(typeof(TouchInteractable.TransitionTypeFlags))]
	private TouchInteractable.TransitionTypeFlags _transitionType; // 0x48
	[Tooltip("Settings using for Color Tint transitions.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ColorBlock _transitionColorTint; // 0x4C
	[Tooltip("Settings using for Sprite State transitions.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private SpriteState _transitionSpriteState; // 0xA8
	[Tooltip("Settings using for Animation Trigger transitions.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private AnimationTriggers _transitionAnimationTriggers; // 0xC8
	[Tooltip("The target Graphic component for interaction state transitions. This should normally be set to an Image component on this GameObject.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Graphic _targetGraphic; // 0xD0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when the Interaction State changes.")]
	private TouchInteractable.InteractionStateTransitionEventHandler _onInteractionStateTransition; // 0xD8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when visibility changes.")]
	private TouchInteractable.VisibilityChangedEventHandler _onVisibilityChanged; // 0xE0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when interaction state changes to Normal.")]
	private UnityEvent _onInteractionStateChangedToNormal; // 0xE8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when interaction state changes to Highlighted.")]
	private UnityEvent _onInteractionStateChangedToHighlighted; // 0xF0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when interaction state changes to Pressed.")]
	private UnityEvent _onInteractionStateChangedToPressed; // 0xF8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when interaction state changes to Disabled.")]
	private UnityEvent _onInteractionStateChangedToDisabled; // 0x100
	private readonly List<CanvasGroup> _canvasGroupCache; // 0x108
	private bool _groupsAllowInteraction; // 0x110
	private TouchInteractable.InteractionState _interactionState; // 0x114
	private bool wClICzBvetppzLQOtPzTmrbeSAFHb; // 0x118
	private bool aahCrujdIVaPZilYNpCwRyJPlvMw; // 0x119
	private bool _varWatch_visible; // 0x11A
	private bool _varWatch_interactable; // 0x11B
	private bool _allowSendingEvents; // 0x11C
	private static TouchInteractable.InteractionStateTransitionArgs _transitionArgs; // 0x0
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers; // 0x120
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers; // 0x128
	private static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate; // 0x8

	// Properties
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<IVisibilityChangedHandler, bool> FVbLGlfJnUyURZfFgxqwMggVxnJ { get; }
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> DYXKzbvTpQLsfjymhoTErLaYIFNl { get; }
	public bool interactable { get; set; }
	public bool visible { get; set; }
	public bool hideWhenIdle { get; set; }
	public TouchInteractable.MouseButtonFlags allowedMouseButtons { get; set; }
	public TouchInteractable.TransitionTypeFlags transitionType { get; set; }
	public ColorBlock transitionColorTint { get; set; }
	public SpriteState transitionSpriteState { get; set; }
	public AnimationTriggers transitionAnimationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	public TouchInteractable.InteractionState interactionState { get; }
	internal static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> vhGEdeascCveThdbiGqhFuIEgMuy { get; }

	// Methods

	// RVA: 0x178BA30 Offset: 0x178A030 VA: 0x18178BA30
	public void add_InteractionStateSetEvent(UnityAction<TouchInteractable.InteractionStateTransitionArgs> value) { }

	// RVA: 0x178CA60 Offset: 0x178B060 VA: 0x18178CA60
	public void remove_InteractionStateSetEvent(UnityAction<TouchInteractable.InteractionStateTransitionArgs> value) { }

	// RVA: 0x178BA90 Offset: 0x178A090 VA: 0x18178BA90
	public void add_VisibilityChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x178CAC0 Offset: 0x178B0C0 VA: 0x18178CAC0
	public void remove_VisibilityChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x178B9D0 Offset: 0x1789FD0 VA: 0x18178B9D0
	public void add_InteractionStateChangedToNormal(UnityAction value) { }

	// RVA: 0x178CA00 Offset: 0x178B000 VA: 0x18178CA00
	public void remove_InteractionStateChangedToNormal(UnityAction value) { }

	// RVA: 0x178B9A0 Offset: 0x1789FA0 VA: 0x18178B9A0
	public void add_InteractionStateChangedToHighlighted(UnityAction value) { }

	// RVA: 0x178C9D0 Offset: 0x178AFD0 VA: 0x18178C9D0
	public void remove_InteractionStateChangedToHighlighted(UnityAction value) { }

	// RVA: 0x178BA00 Offset: 0x178A000 VA: 0x18178BA00
	public void add_InteractionStateChangedToPressed(UnityAction value) { }

	// RVA: 0x178CA30 Offset: 0x178B030 VA: 0x18178CA30
	public void remove_InteractionStateChangedToPressed(UnityAction value) { }

	// RVA: 0x178B970 Offset: 0x1789F70 VA: 0x18178B970
	public void add_InteractionStateChangedToDisabled(UnityAction value) { }

	// RVA: 0x178C9A0 Offset: 0x178AFA0 VA: 0x18178C9A0
	public void remove_InteractionStateChangedToDisabled(UnityAction value) { }

	// RVA: 0x178C3E0 Offset: 0x178A9E0 VA: 0x18178C3E0
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<IVisibilityChangedHandler, bool> lhEJEAWYGBYDQkeJvGwrqMDiipFh() { }

	// RVA: 0x178BD10 Offset: 0x178A310 VA: 0x18178BD10
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> fewcOSLLSEJbgXEbAfHZgocvKOnx() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_interactable() { }

	// RVA: 0x178CC00 Offset: 0x178B200 VA: 0x18178CC00
	public void set_interactable(bool value) { }

	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70
	public bool get_visible() { }

	// RVA: 0x178CE00 Offset: 0x178B400 VA: 0x18178CE00
	public void set_visible(bool value) { }

	// RVA: 0x178BFD0 Offset: 0x178A5D0 VA: 0x18178BFD0
	public bool get_hideWhenIdle() { }

	// RVA: 0x178CB40 Offset: 0x178B140 VA: 0x18178CB40
	public void set_hideWhenIdle(bool value) { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public TouchInteractable.MouseButtonFlags get_allowedMouseButtons() { }

	// RVA: 0x178CB20 Offset: 0x178B120 VA: 0x18178CB20
	public void set_allowedMouseButtons(TouchInteractable.MouseButtonFlags value) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public TouchInteractable.TransitionTypeFlags get_transitionType() { }

	// RVA: 0x178CDE0 Offset: 0x178B3E0 VA: 0x18178CDE0
	public void set_transitionType(TouchInteractable.TransitionTypeFlags value) { }

	// RVA: 0x178C070 Offset: 0x178A670 VA: 0x18178C070
	public ColorBlock get_transitionColorTint() { }

	// RVA: 0x178CD10 Offset: 0x178B310 VA: 0x18178CD10
	public void set_transitionColorTint(ColorBlock value) { }

	// RVA: 0x178C0B0 Offset: 0x178A6B0 VA: 0x18178C0B0
	public SpriteState get_transitionSpriteState() { }

	// RVA: 0x178CD60 Offset: 0x178B360 VA: 0x18178CD60
	public void set_transitionSpriteState(SpriteState value) { }

	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public AnimationTriggers get_transitionAnimationTriggers() { }

	// RVA: 0x178CCC0 Offset: 0x178B2C0 VA: 0x18178CCC0
	public void set_transitionAnimationTriggers(AnimationTriggers value) { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public Graphic get_targetGraphic() { }

	// RVA: 0x178CC20 Offset: 0x178B220 VA: 0x18178CC20
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x178BFE0 Offset: 0x178A5E0 VA: 0x18178BFE0
	public Image get_image() { }

	// RVA: 0x178CB60 Offset: 0x178B160 VA: 0x18178CB60
	public void set_image(Image value) { }

	// RVA: 0x178BF80 Offset: 0x178A580 VA: 0x18178BF80
	public Animator get_animator() { }

	// RVA: 0x561190 Offset: 0x55F790 VA: 0x180561190
	public TouchInteractable.InteractionState get_interactionState() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178B6A0 Offset: 0x1789CA0 VA: 0x18178B6A0
	internal void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1789540 Offset: 0x1787B40 VA: 0x181789540 Slot: 8
	internal override void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1789E20 Offset: 0x1788420 VA: 0x181789E20 Slot: 14
	internal override void OnCanvasGroupChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1789FE0 Offset: 0x17885E0 VA: 0x181789FE0 Slot: 16
	internal override void OnDidApplyAnimationProperties() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178A1D0 Offset: 0x17887D0 VA: 0x18178A1D0 Slot: 10
	internal override void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1789FF0 Offset: 0x17885F0 VA: 0x181789FF0 Slot: 11
	internal override void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178A630 Offset: 0x1788C30 VA: 0x18178A630 Slot: 13
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178A900 Offset: 0x1788F00 VA: 0x18178A900 Slot: 17
	internal override void Reset() { }

	// RVA: 0x1789D60 Offset: 0x1788360 VA: 0x181789D60 Slot: 23
	internal override void JvVGAvemidwJBkWPQixCkyeKElcfb() { }

	// RVA: 0x178AF20 Offset: 0x1789520 VA: 0x18178AF20 Slot: 25
	internal override void YXZXCxhkKgTnyRywHFMaDNrJrdFF() { }

	// RVA: 0x178AD70 Offset: 0x1789370 VA: 0x18178AD70
	private void VEPRWhRzzERRAERQewsgCCDkamJy() { }

	// RVA: 0x178B010 Offset: 0x1789610 VA: 0x18178B010
	private void YvcGSeDNUNUaecAOQWsrybwXABjp(TouchInteractable.InteractionState , bool ) { }

	// RVA: 0x178AB30 Offset: 0x1789130 VA: 0x18178AB30
	private void TIoemVcutdssFDqWtKCtwVmKZmev(Color , bool ) { }

	// RVA: 0x178AA90 Offset: 0x1789090 VA: 0x18178AA90
	private void SmxjfuAtuqDwhkRDiKuEFQzYJXZM(Sprite ) { }

	// RVA: 0x178C160 Offset: 0x178A760 VA: 0x18178C160
	private void kRhYNrTOTGPzyGETcYnEDmiFjKsi(string ) { }

	// RVA: 0x17897A0 Offset: 0x1787DA0 VA: 0x1817897A0
	private void DcOodNjPrFAqwYRVLMUUqLLPEBnc(bool ) { }

	// RVA: 0x1789D40 Offset: 0x1788340 VA: 0x181789D40
	public bool IsInteractable() { }

	// RVA: 0x178AA20 Offset: 0x1789020 VA: 0x18178AA20 Slot: 42
	internal virtual bool SjGLqQCXTLpKRhCblQEzSnJNvLxp() { }

	// RVA: 0x178C8E0 Offset: 0x178AEE0 VA: 0x18178C8E0
	internal void rSDKCytBOZjlcqojShANaYpxeOoCA(BaseEventData ) { }

	// RVA: 0x178C530 Offset: 0x178AB30 VA: 0x18178C530 Slot: 43
	internal virtual bool muEjuLNOgxFpTfrtZBaeqossxvzd(GameObject ) { }

	// RVA: 0x178D020 Offset: 0x178B620 VA: 0x18178D020
	private bool xJppmiJWhlJHmpMmLoMgFkpXciyz(BaseEventData ) { }

	// RVA: 0x17899E0 Offset: 0x1787FE0 VA: 0x1817899E0
	private bool HIplkJyURnwHTHoOdWzWCxceVCaG(bool , GameObject ) { }

	// RVA: 0x1789980 Offset: 0x1787F80 VA: 0x181789980
	private TouchInteractable.InteractionState FQNEKGFCOPCCIFQnxGDseLfhoePib(BaseEventData ) { }

	// RVA: 0x178C0D0 Offset: 0x178A6D0 VA: 0x18178C0D0
	private bool iCLqyYcXkBfVwBgVvYnJkEdTQKJI(TouchInteractable.InteractionState ) { }

	// RVA: 0x178AC20 Offset: 0x1789220 VA: 0x18178AC20
	private void UFTxADUzumNnqQMGJHaSAFTWxBHR() { }

	// RVA: 0x178AC20 Offset: 0x1789220 VA: 0x18178AC20
	private void qDCRNUNhPtjVVhefYTDVVnpqtEEkA() { }

	// RVA: 0x178BAF0 Offset: 0x178A0F0 VA: 0x18178BAF0
	private void bxMAaapbTaAfSjIJxiEQkvcubOnvA(bool , bool ) { }

	// RVA: 0x178C6D0 Offset: 0x178ACD0 VA: 0x18178C6D0
	private void rQhSBBPwGDMjNLawqCTmYzXHUgoj() { }

	// RVA: 0x178A970 Offset: 0x1788F70 VA: 0x18178A970
	private void RkrKcSzeuzNZFqQOvdfhKLyjDjbFA() { }

	// RVA: 0x178BBB0 Offset: 0x178A1B0 VA: 0x18178BBB0
	private void cKBtCmIzAfmTQiQQekCMNmyIjnBn() { }

	// RVA: 0x178C620 Offset: 0x178AC20 VA: 0x18178C620
	private void obCJfPDDNTcRugcslJIIEPKKpUjhb() { }

	// RVA: 0x178A3B0 Offset: 0x17889B0 VA: 0x18178A3B0 Slot: 44
	internal virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x178A590 Offset: 0x1788B90 VA: 0x18178A590 Slot: 45
	internal virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x178A450 Offset: 0x1788A50 VA: 0x18178A450 Slot: 46
	internal virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x178A4F0 Offset: 0x1788AF0 VA: 0x18178A4F0 Slot: 47
	internal virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1789DB0 Offset: 0x17883B0 VA: 0x181789DB0 Slot: 48
	internal virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x178A160 Offset: 0x1788760 VA: 0x18178A160 Slot: 49
	internal virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x178A340 Offset: 0x1788940 VA: 0x18178A340 Slot: 50
	internal virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x178ACF0 Offset: 0x17892F0 VA: 0x18178ACF0 Slot: 33
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x178AD50 Offset: 0x1789350 VA: 0x18178AD50 Slot: 34
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x178AD10 Offset: 0x1789310 VA: 0x18178AD10 Slot: 35
	private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x178AD30 Offset: 0x1789330 VA: 0x18178AD30 Slot: 36
	private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x178AC90 Offset: 0x1789290 VA: 0x18178AC90 Slot: 37
	private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x178ACB0 Offset: 0x17892B0 VA: 0x18178ACB0 Slot: 38
	private void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	// RVA: 0x178ACD0 Offset: 0x17892D0 VA: 0x18178ACD0 Slot: 39
	private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1789B70 Offset: 0x1788170 VA: 0x181789B70
	internal static bool INUPjGWqdlwyKMAtpgAYFcnTXXMSA(int ) { }

	// RVA: 0x1789630 Offset: 0x1787C30 VA: 0x181789630
	internal static Vector3 BCPeAGoHmajmVdrEpKshcTFpjvWeA(int ) { }

	// RVA: 0x1789B60 Offset: 0x1788160 VA: 0x181789B60
	internal static bool HyBlOAWZFzRvGEiINAIuhMtplyTC(int ) { }

	// RVA: 0x178C3C0 Offset: 0x178A9C0 VA: 0x18178C3C0
	internal static bool kTioofhhGVvCxLoXdTDTFcZNaMvCA(int ) { }

	// RVA: 0x178B510 Offset: 0x1789B10 VA: 0x18178B510
	private static int ZIQCMOENUKdrCTmibFCTuSNziezAb(int ) { }

	// RVA: 0x178AF30 Offset: 0x1789530 VA: 0x18178AF30
	internal static bool YlaZcikOPYjJLzQtmQATJPccTxrJ(TouchInteractable.MouseButtonFlags , int ) { }

	// RVA: 0x178CE40 Offset: 0x178B440 VA: 0x18178CE40
	private static bool sgAzekEENDtrEtcjoHRNGZyiVfZIA(TouchInteractable.MouseButtonFlags , int ) { }

	// RVA: 0x178AE90 Offset: 0x1789490 VA: 0x18178AE90
	private static int WTVDhalFSJAIHgMmQpeuNlyNSkBA(int ) { }

	// RVA: 0x178C4C0 Offset: 0x178AAC0 VA: 0x18178C4C0
	internal static bool lyEXdLAndjWqCDgKIbjWiFwUfTRcb(TouchInteractable.MouseButtonFlags , out int ) { }

	// RVA: 0x1789830 Offset: 0x1787E30 VA: 0x181789830
	internal static bool ESeWtKCEBMvaJODaafiEfambrfsB(int , TouchInteractable.MouseButtonFlags , EventTriggerType ) { }

	// RVA: 0x178C5A0 Offset: 0x178ABA0 VA: 0x18178C5A0
	internal static bool oSIyXpZCVZIJmeTLCvTrtnwAALBW(TouchInteractable.MouseButtonFlags ) { }

	// RVA: 0x178CE70 Offset: 0x178B470 VA: 0x18178CE70
	internal static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> wglfuaBoezbXPAxReovoUPFJTzFIB() { }

	// RVA: 0x178B620 Offset: 0x1789C20 VA: 0x18178B620
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x178B610 Offset: 0x1789C10 VA: 0x18178B610
	private void ZUTYBlrzjAfHvrlTASvUhLuGoEZo(bool ) { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Touch Joystick")]
[Serializable]
public sealed class TouchJoystick : TouchInteractable // TypeDefIndex: 2754
{
	// Fields
	private const float MAX_MOVE_SPEED = 20;
	[Tooltip("The Custom Controller element(s) that will receive input values from the joystick's X axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x130
	[Tooltip("The Custom Controller element(s) that will receive input values from the joystick's Y axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x138
	[Tooltip("The Custom Controller element that will receive input values from taps.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x140
	[Tooltip("The Rect Transform of the stick disc. This is moved around by the user when manipulating the joystick.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private RectTransform _stickTransform; // 0x148
	[Tooltip("The joystick's mode of operation. Set this to Digital to simulate a D-Pad which has only On/Off states. If you want mimic a real D-Pad, you should also set Snap Directions to 8.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.JoystickMode _joystickMode; // 0x150
	[Tooltip("A dead zone which is applied when Stick Mode is set to Digital. This is used to filter out tiny stick movements near 0, 0.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 1)]
	private float _digitalModeDeadZone; // 0x154
	[Tooltip("The range of movement of the stick in Canvas pixels. The larger the number, the further the stick must be moved from center to register movement.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0.01, 1000)]
	private float _stickRange; // 0x158
	[Tooltip("If enabled, the stick range will scale with parent controls. Otherwise, the stick range will remain constant.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _scaleStickRange; // 0x15C
	[Tooltip("The shape of the range of movement of the joystick.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.StickBounds _stickBounds; // 0x160
	[Tooltip("The axis directions in which movement is allowed. You can restrict movement to one or both axes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.AxisDirection _axesToUse; // 0x164
	[Tooltip("Snaps joystick movement to a fixed number of directions. This can be used to create a D-Pad, for example, setting it to 4 or 8 directions. If you want a true D-Pad, Stick Mode should be set to digital.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.SnapDirections _snapDirections; // 0x168
	[Tooltip("If true, the stick disc will snap immediately to the touch position when initially touched. This results in the stick disc being centered to the touch position. This will cause the stick to generate input immediately when touched if not touched perfectly centered.If false, the stick disc will remain in its current position on touch, and when dragged will retain the same offset. The stick's center point will be set to the position of the touch. The initial touch will not cause the stick to pop in any direction.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _snapStickToTouch; // 0x16C
	[Tooltip("If true, the stick will return to the center after it is released. Otherwise, the stick will remain in the last position and continue to return input.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _centerStickOnRelease; // 0x16D
	[Tooltip("The underlying Axis 2D.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private StandaloneAxis2D _axis2D; // 0x170
	[Tooltip("If true, the joystick can be activated by a touch swipe that began in an area outside the joystick region. If false, the joystick can only be activated by a direct touch.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _activateOnSwipeIn; // 0x178
	[Tooltip("If true, the joystick will stay engaged even if the touch that activated it moves outside the joystick region. If false, the joystick will be released once the touch that activated it moves outside the joystick region.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _stayActiveOnSwipeOut; // 0x179
	[Tooltip("Should taps on the touch pad be processed?")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _allowTap; // 0x17A
	[Tooltip("The maximum touch duration allowed for the touch to be considered a tap. A touch that lasts longer than this value will not trigger a tap when released.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(0, 3.4028235E+38)]
	private float _tapTimeout; // 0x17C
	[Tooltip("The maximum movement distance allowed in pixels since the touch began for the touch to be considered a tap. [-1 = no limit]")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(-1, 2147483647)]
	private int _tapDistanceLimit; // 0x180
	[Tooltip("Optional external region to use for hover/click/touch detection. If set, this region will be used for touch detection instead of or in addition to the joystick's RectTransform. This can be useful if you want a larger area of the screen to act as a joystick.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchRegion _touchRegion; // 0x188
	[Tooltip("If True, hovers/clicks/touches on the local joystick will be ignored and only Touch Region touches will be used. Otherwise, both touches on the joystick and on the Touch Region will be used. This also applies to mouse hover. This setting has no effect if no Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useTouchRegionOnly; // 0x190
	[Tooltip("If True, the joystick will move to the location of the current touch in the Touch Region. This can be used to designate an area of the screen as a hot-spot for a joystick and have the joystick graphics follow the users touches. This only has an effect if a Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _moveToTouchPosition; // 0x191
	[Tooltip("If Move To Touch Position is enabled, this will make the joystick return to its original position after the press is released. This only has an effect if a Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _returnOnRelease; // 0x192
	[Tooltip("If True, the joystick will follow the touch around until released. This setting overrides Move To Touch Position.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _followTouchPosition; // 0x193
	[Tooltip("Should the joystick animate when moving to the touch point? This only has an effect if Move To Touch Position is True and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _animateOnMoveToTouch; // 0x194
	[Tooltip("The speed at which the joystick will move toward the touch position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Move To Touch Position is True, Animate On Move To Touch is true, and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 20)]
	private float _moveToTouchSpeed; // 0x198
	[Tooltip("Should the joystick animate when moving back to its original position? This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _animateOnReturn; // 0x19C
	[Tooltip("The speed at which the joystick will move back toward its original position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release and Animate on Return are both True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 20)]
	private float _returnSpeed; // 0x1A0
	[Tooltip("If True, it will attempt to automatically manage Graphic component raycasting for best results based on your current settings.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _manageRaycasting; // 0x1A4
	private bool _useXAxis; // 0x1A5
	private bool _useYAxis; // 0x1A6
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<TouchJoystick.IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers; // 0x1A8
	private VRubiuUbWcigTnrJaYOjDhZZJCsd.HierarchyEventHelper<TouchJoystick.IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers; // 0x1B0
	private TouchRegion _workingTouchRegion; // 0x1B8
	private Vector2 _origAnchoredPosition; // 0x1C0
	private Vector2 _origStickAnchoredPosition; // 0x1C8
	private Vector2 _lastPressAnchoredPosition; // 0x1D0
	private bool _isMoving; // 0x1D8
	private bool _isMovedFromDefaultPosition; // 0x1D9
	private TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS _moveDirection; // 0x1DC
	private int _pointerId; // 0x1E0
	private int _realMousePointerId; // 0x1E4
	private bool HdiWgFbEXSOVdOZwETnuIfOmtZyu; // 0x1E8
	private bool xbQEYQHHwlgFxIxlNqDtFmWxtRuh; // 0x1E9
	private bool _pointerDownIsFake; // 0x1EA
	private Vector2 _lastPressStartingValue; // 0x1EC
	private TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm _lastClaimSource; // 0x1F4
	private float _touchStartTime; // 0x1F8
	private Vector2 _touchStartPosition; // 0x1FC
	private IEnumerator _coroutineMove; // 0x208
	private ArkyMExcqvAjSSEgvKopSLEhHuEEA _imageRaycastHelper; // 0x210
	private int _calculatedStickRange_lastUpdatedFrame; // 0x218
	private int _lastTapFrame; // 0x21C
	private bool _isEligibleForTap; // 0x220
	private float __calculatedStickRange_cachedValue; // 0x224
	private Action<TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS> __moveStartedDelegate; // 0x228
	private Action<TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS> __moveEndedDelegate; // 0x230
	[Tooltip("Event sent when the joystick value changes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.ValueChangedEventHandler _onValueChanged; // 0x238
	[Tooltip("Event sent when the joystick's stick position changes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.ValueChangedEventHandler _onStickPositionChanged; // 0x240
	[Tooltip("Event sent when the joystick is touched.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.TouchStartedEventHandler _onTouchStarted; // 0x248
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.TouchEndedEventHandler _onTouchEnded; // 0x250
	[Tooltip("Event sent when the touch pad is tapped. This event will only be sent if allowTap is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.TapEventHandler _onTap; // 0x258
	private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x260
	private static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> __valueChangedHandlerDelegate; // 0x0
	private static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate; // 0x8

	// Properties
	public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get; }
	public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get; }
	public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get; }
	public RectTransform stickTransform { get; set; }
	public TouchJoystick.JoystickMode joystickMode { get; set; }
	public float digitalModeDeadZone { get; set; }
	public float stickRange { get; set; }
	public bool scaleStickRange { get; set; }
	private TouchJoystick.StickBounds gysENviCwaWUJerwrsVFaiEfZEFfA { get; set; }
	public TouchJoystick.AxisDirection axesToUse { get; set; }
	public TouchJoystick.SnapDirections snapDirections { get; set; }
	public bool snapStickToTouch { get; set; }
	public bool centerStickOnRelease { get; set; }
	public bool activateOnSwipeIn { get; set; }
	public bool stayActiveOnSwipeOut { get; set; }
	public bool allowTap { get; set; }
	public float tapTimeout { get; set; }
	public int tapDistanceLimit { get; set; }
	public TouchRegion touchRegion { get; set; }
	public bool useTouchRegionOnly { get; set; }
	public bool moveToTouchPosition { get; set; }
	public bool returnOnRelease { get; set; }
	public bool followTouchPosition { get; set; }
	public bool animateOnMoveToTouch { get; set; }
	public float moveToTouchSpeed { get; set; }
	public bool animateOnReturn { get; set; }
	public float returnSpeed { get; set; }
	public bool manageRaycasting { get; set; }
	public AxisCalibration horizontalAxisCalibration { get; }
	public AxisCalibration verticalAxisCalibration { get; }
	[Obsolete("Use axis2DCalibration instead.", False)]
	public Axis2DCalibration deadZoneType { get; }
	public Axis2DCalibration axis2DCalibration { get; }
	public int pointerId { get; set; }
	public bool hasPointer { get; }
	private bool vlOJISRkwPtOnPfLnGPuBMEdHbWw { get; }
	internal StandaloneAxis2D WXBwcwdevEeGrkSpYtTmlNMJioMDb { get; }
	private Action<TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS> yAFHrlZbNRNrjpiJiakabjAaiNad { get; }
	private Action<TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS> xNeiemUwwvQbrpULwSzGMPuVveom { get; }
	private int vnSbsZDTQALzKBTxIxUGXBMfsUki { get; }
	private RectTransform qbViowpEvrNDQLSBeXVuPfAxsfDl { get; }
	private float UcUzqOPbiknOiaGddbUZFNFCZgQd { get; }
	internal static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> jjNYIojDDHEsgjnqonKkKnVvfBKDA { get; }
	internal static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> wNqWTuOTgDkvxySbmddvTNfUNDdI { get; }

	// Methods

	// RVA: 0x17871D0 Offset: 0x17857D0 VA: 0x1817871D0
	public CustomControllerElementTargetSetForFloat get_horizontalAxisCustomControllerElement() { }

	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	public CustomControllerElementTargetSetForFloat get_verticalAxisCustomControllerElement() { }

	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	public CustomControllerElementTargetSetForBoolean get_tapCustomControllerElement() { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	public RectTransform get_stickTransform() { }

	// RVA: 0x1793C40 Offset: 0x1792240 VA: 0x181793C40
	public void set_stickTransform(RectTransform value) { }

	// RVA: 0x1791B00 Offset: 0x1790100 VA: 0x181791B00
	public TouchJoystick.JoystickMode get_joystickMode() { }

	// RVA: 0x17939F0 Offset: 0x1791FF0 VA: 0x1817939F0
	public void set_joystickMode(TouchJoystick.JoystickMode value) { }

	// RVA: 0x46A710 Offset: 0x468D10 VA: 0x18046A710
	public float get_digitalModeDeadZone() { }

	// RVA: 0x1793980 Offset: 0x1791F80 VA: 0x181793980
	public void set_digitalModeDeadZone(float value) { }

	// RVA: 0x1791C10 Offset: 0x1790210 VA: 0x181791C10
	public float get_stickRange() { }

	// RVA: 0x1793BE0 Offset: 0x17921E0 VA: 0x181793BE0
	public void set_stickRange(float value) { }

	// RVA: 0x1787080 Offset: 0x1785680 VA: 0x181787080
	public bool get_scaleStickRange() { }

	// RVA: 0x17879B0 Offset: 0x1785FB0 VA: 0x1817879B0
	public void set_scaleStickRange(bool value) { }

	// RVA: 0x178DC60 Offset: 0x178C260 VA: 0x18178DC60
	private TouchJoystick.StickBounds ITLvUpeNubfwShalSiRFdNSibMgcA() { }

	// RVA: 0x17948E0 Offset: 0x1792EE0 VA: 0x1817948E0
	private void yZAItvcAeRtPYCoxOuTSYGGPtpzS(TouchJoystick.StickBounds ) { }

	// RVA: 0x1791A70 Offset: 0x1790070 VA: 0x181791A70
	public TouchJoystick.AxisDirection get_axesToUse() { }

	// RVA: 0x1793920 Offset: 0x1791F20 VA: 0x181793920
	public void set_axesToUse(TouchJoystick.AxisDirection value) { }

	// RVA: 0x1791B70 Offset: 0x1790170 VA: 0x181791B70
	public TouchJoystick.SnapDirections get_snapDirections() { }

	// RVA: 0x1793B80 Offset: 0x1792180 VA: 0x181793B80
	public void set_snapDirections(TouchJoystick.SnapDirections value) { }

	// RVA: 0x17870F0 Offset: 0x17856F0 VA: 0x1817870F0
	public bool get_snapStickToTouch() { }

	// RVA: 0x1793BA0 Offset: 0x17921A0 VA: 0x181793BA0
	public void set_snapStickToTouch(bool value) { }

	// RVA: 0x1791AA0 Offset: 0x17900A0 VA: 0x181791AA0
	public bool get_centerStickOnRelease() { }

	// RVA: 0x1793960 Offset: 0x1791F60 VA: 0x181793960
	public void set_centerStickOnRelease(bool value) { }

	// RVA: 0x1791A30 Offset: 0x1790030 VA: 0x181791A30
	public bool get_activateOnSwipeIn() { }

	// RVA: 0x17938A0 Offset: 0x1791EA0 VA: 0x1817938A0
	public void set_activateOnSwipeIn(bool value) { }

	// RVA: 0x1791B80 Offset: 0x1790180 VA: 0x181791B80
	public bool get_stayActiveOnSwipeOut() { }

	// RVA: 0x1793BC0 Offset: 0x17921C0 VA: 0x181793BC0
	public void set_stayActiveOnSwipeOut(bool value) { }

	// RVA: 0x1791A40 Offset: 0x1790040 VA: 0x181791A40
	public bool get_allowTap() { }

	// RVA: 0x17938C0 Offset: 0x1791EC0 VA: 0x1817938C0
	public void set_allowTap(bool value) { }

	// RVA: 0x1791C30 Offset: 0x1790230 VA: 0x181791C30
	public float get_tapTimeout() { }

	// RVA: 0x1793D30 Offset: 0x1792330 VA: 0x181793D30
	public void set_tapTimeout(float value) { }

	// RVA: 0x37EAF0 Offset: 0x37D0F0 VA: 0x18037EAF0
	public int get_tapDistanceLimit() { }

	// RVA: 0x1793CE0 Offset: 0x17922E0 VA: 0x181793CE0
	public void set_tapDistanceLimit(int value) { }

	// RVA: 0x37EAE0 Offset: 0x37D0E0 VA: 0x18037EAE0
	public TouchRegion get_touchRegion() { }

	// RVA: 0x1793D80 Offset: 0x1792380 VA: 0x181793D80
	public void set_touchRegion(TouchRegion value) { }

	// RVA: 0x1791C40 Offset: 0x1790240 VA: 0x181791C40
	public bool get_useTouchRegionOnly() { }

	// RVA: 0x1793E20 Offset: 0x1792420 VA: 0x181793E20
	public void set_useTouchRegionOnly(bool value) { }

	// RVA: 0x1791B20 Offset: 0x1790120 VA: 0x181791B20
	public bool get_moveToTouchPosition() { }

	// RVA: 0x1793A70 Offset: 0x1792070 VA: 0x181793A70
	public void set_moveToTouchPosition(bool value) { }

	// RVA: 0x1791B50 Offset: 0x1790150 VA: 0x181791B50
	public bool get_returnOnRelease() { }

	// RVA: 0x1793B00 Offset: 0x1792100 VA: 0x181793B00
	public void set_returnOnRelease(bool value) { }

	// RVA: 0x1791AB0 Offset: 0x17900B0 VA: 0x181791AB0
	public bool get_followTouchPosition() { }

	// RVA: 0x17939D0 Offset: 0x1791FD0 VA: 0x1817939D0
	public void set_followTouchPosition(bool value) { }

	// RVA: 0x1791A50 Offset: 0x1790050 VA: 0x181791A50
	public bool get_animateOnMoveToTouch() { }

	// RVA: 0x17938E0 Offset: 0x1791EE0 VA: 0x1817938E0
	public void set_animateOnMoveToTouch(bool value) { }

	// RVA: 0x1791B30 Offset: 0x1790130 VA: 0x181791B30
	public float get_moveToTouchSpeed() { }

	// RVA: 0x1793A90 Offset: 0x1792090 VA: 0x181793A90
	public void set_moveToTouchSpeed(float value) { }

	// RVA: 0x1791A60 Offset: 0x1790060 VA: 0x181791A60
	public bool get_animateOnReturn() { }

	// RVA: 0x1793900 Offset: 0x1791F00 VA: 0x181793900
	public void set_animateOnReturn(bool value) { }

	// RVA: 0x1791B60 Offset: 0x1790160 VA: 0x181791B60
	public float get_returnSpeed() { }

	// RVA: 0x1793B20 Offset: 0x1792120 VA: 0x181793B20
	public void set_returnSpeed(float value) { }

	// RVA: 0x1791B10 Offset: 0x1790110 VA: 0x181791B10
	public bool get_manageRaycasting() { }

	// RVA: 0x1793A10 Offset: 0x1792010 VA: 0x181793A10
	public void set_manageRaycasting(bool value) { }

	// RVA: 0x1791AD0 Offset: 0x17900D0 VA: 0x181791AD0
	public AxisCalibration get_horizontalAxisCalibration() { }

	// RVA: 0x1791C50 Offset: 0x1790250 VA: 0x181791C50
	public AxisCalibration get_verticalAxisCalibration() { }

	// RVA: 0x1791A80 Offset: 0x1790080 VA: 0x181791A80
	public Axis2DCalibration get_deadZoneType() { }

	// RVA: 0x1791A80 Offset: 0x1790080 VA: 0x181791A80
	public Axis2DCalibration get_axis2DCalibration() { }

	// RVA: 0x1791B40 Offset: 0x1790140 VA: 0x181791B40
	public int get_pointerId() { }

	// RVA: 0x1793AF0 Offset: 0x17920F0 VA: 0x181793AF0
	public void set_pointerId(int value) { }

	// RVA: 0x1791AC0 Offset: 0x17900C0 VA: 0x181791AC0
	public bool get_hasPointer() { }

	// RVA: 0x1793680 Offset: 0x1791C80 VA: 0x181793680
	private bool sEpQfawinlHxEaTgrYEGglrSOoVC() { }

	// RVA: 0x1793F00 Offset: 0x1792500 VA: 0x181793F00
	internal StandaloneAxis2D tESOqYydQzLulBhviZSQfAndDUeb() { }

	// RVA: 0x17914B0 Offset: 0x178FAB0 VA: 0x1817914B0
	private Action<TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS> aqQsjLbfXRcfpBYXLJZBhhBXgdXeA() { }

	// RVA: 0x1792650 Offset: 0x1790C50 VA: 0x181792650
	private Action<TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS> jyvbcyrJNBHcvFzPzPJxJlHxefcr() { }

	// RVA: 0x1792420 Offset: 0x1790A20 VA: 0x181792420
	private int iLiBqwCwQFAURwfvMXbrWLQFshdjA() { }

	// RVA: 0x17903B0 Offset: 0x178E9B0 VA: 0x1817903B0
	private RectTransform UbwDtMHQVhUxukgzTIsYaTQehQkCc() { }

	// RVA: 0x1792100 Offset: 0x1790700 VA: 0x181792100
	private float iAIYemOiziYtrNdIYLpZhemRVrDn() { }

	// RVA: 0x1791280 Offset: 0x178F880 VA: 0x181791280
	public void add_ValueChangedEvent(UnityAction<Vector2> value) { }

	// RVA: 0x17935B0 Offset: 0x1791BB0 VA: 0x1817935B0
	public void remove_ValueChangedEvent(UnityAction<Vector2> value) { }

	// RVA: 0x1791190 Offset: 0x178F790 VA: 0x181791190
	public void add_StickPositionChangedEvent(UnityAction<Vector2> value) { }

	// RVA: 0x17934C0 Offset: 0x1791AC0 VA: 0x1817934C0
	public void remove_StickPositionChangedEvent(UnityAction<Vector2> value) { }

	// RVA: 0x1791220 Offset: 0x178F820 VA: 0x181791220
	public void add_TouchDownEvent(UnityAction value) { }

	// RVA: 0x1793550 Offset: 0x1791B50 VA: 0x181793550
	public void remove_TouchDownEvent(UnityAction value) { }

	// RVA: 0x1791250 Offset: 0x178F850 VA: 0x181791250
	public void add_TouchUpEvent(UnityAction value) { }

	// RVA: 0x1793580 Offset: 0x1791B80 VA: 0x181793580
	public void remove_TouchUpEvent(UnityAction value) { }

	// RVA: 0x17911F0 Offset: 0x178F7F0 VA: 0x1817911F0
	public void add_TapEvent(UnityAction value) { }

	// RVA: 0x1793520 Offset: 0x1791B20 VA: 0x181793520
	public void remove_TapEvent(UnityAction value) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1790920 Offset: 0x178EF20 VA: 0x181790920
	private void .ctor() { }

	// RVA: 0x178DA70 Offset: 0x178C070 VA: 0x18178DA70
	public Vector2 GetValue() { }

	// RVA: 0x178DA30 Offset: 0x178C030 VA: 0x18178DA30
	public Vector2 GetRawValue() { }

	// RVA: 0x178FF00 Offset: 0x178E500 VA: 0x18178FF00
	public void SetRawValue(Vector2 value) { }

	// RVA: 0x178FE60 Offset: 0x178E460 VA: 0x18178FE60
	public void SetDefaultPosition() { }

	// RVA: 0x178E310 Offset: 0x178C910 VA: 0x18178E310
	private void IqHhTJfHTkmIxPKwQsXfiHDGUdvv(Vector2 ) { }

	// RVA: 0x178FC40 Offset: 0x178E240 VA: 0x18178FC40
	public void ReturnToDefaultPosition(bool instant) { }

	// RVA: 0x178FCB0 Offset: 0x178E2B0 VA: 0x18178FCB0
	public void ReturnToDefaultPosition() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178D2D0 Offset: 0x178B8D0 VA: 0x18178D2D0 Slot: 8
	internal override void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178F6A0 Offset: 0x178DCA0 VA: 0x18178F6A0 Slot: 10
	internal override void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178F650 Offset: 0x178DC50 VA: 0x18178F650 Slot: 11
	internal override void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x178F6D0 Offset: 0x178DCD0 VA: 0x18178F6D0 Slot: 13
	internal override void OnValidate() { }

	// RVA: 0x178F480 Offset: 0x178DA80 VA: 0x18178F480 Slot: 18
	internal override void NdyWSmCmAaJsKaRMhrelEKqfyKetA() { }

	// RVA: 0x178E2C0 Offset: 0x178C8C0 VA: 0x18178E2C0 Slot: 19
	internal override bool IYumeHBsHLDkZbXXTlVyipwztfSj() { }

	// RVA: 0x17936A0 Offset: 0x1791CA0 VA: 0x1817936A0 Slot: 30
	internal override void sVNkGLdpJSNCoXYpHAuevZqJdCtX() { }

	// RVA: 0x1792450 Offset: 0x1790A50 VA: 0x181792450 Slot: 21
	internal override void izZNMKwHiMXjFJffBnvKelFRpehT() { }

	// RVA: 0x1791550 Offset: 0x178FB50 VA: 0x181791550 Slot: 22
	internal override void crFihhsyVqsdTpqgirKgdRsNPvXT() { }

	// RVA: 0x178ED10 Offset: 0x178D310 VA: 0x18178ED10 Slot: 23
	internal override void KwnhRaBkoAKMzumDquVdFxommGS() { }

	// RVA: 0x1790220 Offset: 0x178E820 VA: 0x181790220 Slot: 24
	internal override void UXSLqhpqNcHnJjehJDwlXpNSBwpH() { }

	// RVA: 0x1792750 Offset: 0x1790D50 VA: 0x181792750 Slot: 25
	internal override void ksNKchhLiDhpUJqRqPTEkeCiwedGA() { }

	// RVA: 0x178D540 Offset: 0x178BB40 VA: 0x18178D540 Slot: 7
	public override void ClearValue() { }

	// RVA: 0x1793450 Offset: 0x1791A50 VA: 0x181793450 Slot: 42
	internal override bool rbrKdenDNsJuXyUlGwwTBbjdadAZ() { }

	// RVA: 0x178F800 Offset: 0x178DE00 VA: 0x18178F800 Slot: 43
	internal override bool QiHyHJSTOcNccWdcLMRGemqUlZfr(GameObject ) { }

	// RVA: 0x178D960 Offset: 0x178BF60 VA: 0x18178D960
	private void FeGCykJnmLAwsqMCWgSYdQBZFBCGA() { }

	// RVA: 0x1793610 Offset: 0x1791C10 VA: 0x181793610
	private void rffGxPRMLEAhMBaZWJjIeVLhlyFqb() { }

	// RVA: 0x178EEE0 Offset: 0x178D4E0 VA: 0x18178EEE0
	private bool LcAsLtcLuhrGCavLwvrrgMBTDGzY() { }

	// RVA: 0x17917E0 Offset: 0x178FDE0 VA: 0x1817917E0
	private void fjTuazmhrYFVmbsGVfKmyfMHXQPj(TouchRegion ) { }

	// RVA: 0x178E320 Offset: 0x178C920 VA: 0x18178E320
	private void IuHrWbEPZKDNsrhGfpDHuXfSqNmT(TouchRegion ) { }

	// RVA: 0x1793E40 Offset: 0x1792440 VA: 0x181793E40
	private void sngbEKjSyRPziSFWtwqCAqpoGdevA() { }

	// RVA: 0x1792F50 Offset: 0x1791550 VA: 0x181792F50
	private void prARgWLLQmrmIEBDQtuYwqpxHAUt(Vector2 , bool , float , TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS ) { }

	// RVA: 0x178DC70 Offset: 0x178C270 VA: 0x18178DC70
	private void IYZDWKFYIUsXzdnxLewiqXUiSKVm(Vector2 , PositionType , bool , float , TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS ) { }

	[IteratorStateMachine(typeof(TouchJoystick.jAxstCEihqaxkabqESzMSHXsLVboA))]
	// RVA: 0x178F960 Offset: 0x178DF60 VA: 0x18178F960
	private IEnumerator QnQfAeaqQASZjhNfNLBUmKUcEqnA(Vector2 , PositionType , float , TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS ) { }

	// RVA: 0x178F310 Offset: 0x178D910 VA: 0x18178F310
	private void MDcGppoSlSjOWiAtnflGvIwlmUpV(TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS , Vector2 , PositionType ) { }

	// RVA: 0x1791C90 Offset: 0x1790290 VA: 0x181791C90
	private void ggQQnyvoxgjNgGrqTwuqvbJRpVHe(TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS ) { }

	// RVA: 0x17915F0 Offset: 0x178FBF0 VA: 0x1817915F0
	private void czGSxWdDqeBEGTWMOgxdnrKLeeMU(TouchJoystick.fGEsAHSFJlSnyjOCTuBwMnTPhdPS ) { }

	// RVA: 0x17926F0 Offset: 0x1790CF0 VA: 0x1817926F0
	private void khGKyuyQFNFEIVCFRbGAIxKpgwQhA() { }

	// RVA: 0x1791DA0 Offset: 0x17903A0 VA: 0x181791DA0
	private void gpKaMFGGZUKhbFoFvwphihzAsIKKB(int , Vector2 , PositionType ) { }

	// RVA: 0x178F080 Offset: 0x178D680 VA: 0x18178F080
	private void LsRvXhYlOlfLfdKEJcSmNLbIjnob() { }

	// RVA: 0x178DAB0 Offset: 0x178C0B0 VA: 0x18178DAB0
	private void GsUlwoYAROkWFhURgixTPcYYLBYm() { }

	// RVA: 0x1793F10 Offset: 0x1792510 VA: 0x181793F10
	private void uSvvrnQLlhdyjhbAmpsjpLAfcIhG(ref Vector2 ) { }

	// RVA: 0x178D250 Offset: 0x178B850 VA: 0x18178D250
	private bool ASfznjJypLtQbmJVbuMgjWkFlkbu() { }

	// RVA: 0x1791D80 Offset: 0x1790380 VA: 0x181791D80
	private void gjHeQKkLKTqXnfigaBHKSqrInMPSA() { }

	// RVA: 0x1792060 Offset: 0x1790660 VA: 0x181792060
	private bool hoMaJNBftmPbIiCRqgVIcWbSDrEDA(int ) { }

	// RVA: 0x178E6F0 Offset: 0x178CCF0 VA: 0x18178E6F0
	private PointerEventData JkJSubDHPViBBJbAcSwjGTefvlJK(int , GameObject ) { }

	// RVA: 0x178D720 Offset: 0x178BD20 VA: 0x18178D720
	private PointerEventData ElcDfYlLeAxgXJXswtADXYZPynIJ(int , GameObject ) { }

	// RVA: 0x178E560 Offset: 0x178CB60 VA: 0x18178E560
	private PointerEventData JOOevZHKsijLrFDhitfhTClVXPUMA(int ) { }

	// RVA: 0x1794030 Offset: 0x1792630 VA: 0x181794030
	private void vrqFpBbfboeWWcPKapaEkWfzwBNAc(PointerEventData ) { }

	// RVA: 0x1792C10 Offset: 0x1791210 VA: 0x181792C10
	private void nxoXBAMzgBvvdXkHlidlhuKXxFDxA(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x178FA20 Offset: 0x178E020 VA: 0x18178FA20
	private PointerEventData RUlGpgAWHAbJnqLOBziBzkPTMpLj(int ) { }

	// RVA: 0x178D610 Offset: 0x178BC10 VA: 0x18178D610
	private void DWSGWSLGXGgdIbHcsJKDbveKhjZZ() { }

	// RVA: 0x17931C0 Offset: 0x17917C0 VA: 0x1817931C0
	private void rNBCGsotbUnuXuUnuogLOWEDOUG(TouchJoystick.AxisDirection ) { }

	// RVA: 0x1792D60 Offset: 0x1791360 VA: 0x181792D60
	private void obNRRLKRXptKuPHojhhaDPIVnSiVA(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x17905B0 Offset: 0x178EBB0 VA: 0x1817905B0
	private void XbqoumvQtRpUqZBHaLDojCilQYDF(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x17945A0 Offset: 0x1792BA0 VA: 0x1817945A0
	private void yRhHcnBbQnbmwaOohwEaafXhmjuTA(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x178ED80 Offset: 0x178D380 VA: 0x18178ED80
	private void LCwdRFeusmtuoADzVcTvmFeTDmFsA(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x17907E0 Offset: 0x178EDE0 VA: 0x1817907E0
	private void YRGsCLLRZhODAPNxrIxbZuyUkqEq(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x1790C40 Offset: 0x178F240 VA: 0x181790C40
	private void aXHmmzGlPTaGmvUuFsFFTOkVygel(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x1792EC0 Offset: 0x17914C0 VA: 0x181792EC0
	private void oopejoGBNqfazJWfJuaTAMflJUCFb(PointerEventData , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x178EAC0 Offset: 0x178D0C0 VA: 0x18178EAC0
	private void KRtrYehMOVJKzpoBBtysVMAULKlH(int , Vector2 , TouchJoystick.gHeicMOeEPTpTPljsYlKQfBjIzwm ) { }

	// RVA: 0x17912E0 Offset: 0x178F8E0 VA: 0x1817912E0
	private void amxZighgDRWbNXyUnLXyNGWatGki() { }

	// RVA: 0x17916F0 Offset: 0x178FCF0 VA: 0x1817916F0 Slot: 45
	internal override void fBVxslPhWsqUeQPUlUoOMnKNYHVc(PointerEventData ) { }

	// RVA: 0x178D450 Offset: 0x178BA50 VA: 0x18178D450 Slot: 44
	internal override void CGtrHOjHGtaLBADQUdTiLiycYHtM(PointerEventData ) { }

	// RVA: 0x1792B20 Offset: 0x1791120 VA: 0x181792B20 Slot: 46
	internal override void mtBLQKENStCsdKsZBhKgnfhikfEOA(PointerEventData ) { }

	// RVA: 0x17906F0 Offset: 0x178ECF0 VA: 0x1817906F0 Slot: 47
	internal override void YBtBRcGoMqSysKUpbggsfajWRGbLA(PointerEventData ) { }

	// RVA: 0x178E170 Offset: 0x178C770 VA: 0x18178E170 Slot: 48
	internal override void IYsFlzUbREpbQUIYBvYetgXQXeaS(PointerEventData ) { }

	// RVA: 0x178F710 Offset: 0x178DD10 VA: 0x18178F710 Slot: 49
	internal override void QGmOEeXWMMVpZRVyqDhCuvOQEITf(PointerEventData ) { }

	// RVA: 0x178FD10 Offset: 0x178E310 VA: 0x18178FD10 Slot: 50
	internal override void SSeYboxZnqimfiPlhwdNsWOrinIS(PointerEventData ) { }

	// RVA: 0x17940A0 Offset: 0x17926A0 VA: 0x1817940A0
	private void xIoitajGPxZWWcEbNuNFdyqXyuzH(PointerEventData ) { }

	// RVA: 0x1790500 Offset: 0x178EB00 VA: 0x181790500
	private void XHWNQalHQwsfDRbjDyzgoDVkiHPG(PointerEventData ) { }

	// RVA: 0x1790170 Offset: 0x178E770 VA: 0x181790170
	private void ThfMPjCnfuNOAjWqbdSCdbPYKCGG(PointerEventData ) { }

	// RVA: 0x1790870 Offset: 0x178EE70 VA: 0x181790870
	private void YxEKUcMyRdfFOJJKLPIHNkNLilyW(PointerEventData ) { }

	// RVA: 0x178EF60 Offset: 0x178D560 VA: 0x18178EF60
	private void LkVNuGIxIBvTxchQHahVUBMUGYSeA(PointerEventData ) { }

	// RVA: 0x1790450 Offset: 0x178EA50 VA: 0x181790450
	private void UjTwuVarFvmYQXIFwqGYaBNZoSkj(PointerEventData ) { }

	// RVA: 0x178D840 Offset: 0x178BE40 VA: 0x18178D840
	private void EnzOoapzRsqjzRzPIhGfpnkvXsTQ(PointerEventData ) { }

	// RVA: 0x1794150 Offset: 0x1792750 VA: 0x181794150
	private void yMmOhlFbOcjetZCklxdRdaGGZgCM(Vector2 ) { }

	// RVA: 0x1791F10 Offset: 0x1790510 VA: 0x181791F10
	internal static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> hoAcHqbPlvMVacBAVqOWFqJaKEmub() { }

	// RVA: 0x17924F0 Offset: 0x1790AF0 VA: 0x1817924F0
	internal static VRubiuUbWcigTnrJaYOjDhZZJCsd.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> jMVfwuxmoVagmAoHnLTqkmlzTQNMA() { }
}

// Namespace: Rewired.ComponentControls
[RequireComponent(typeof(Image))]
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Touch Pad")]
[Serializable]
public sealed class TouchPad : TouchInteractable, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 2764
{
	// Fields
	private const int SMOOTH_DELTA_FRAME_COUNT = 3;
	[Tooltip("The Custom Controller element that will receive input values from the touch pad's X axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x130
	[Tooltip("The Custom Controller element that will receive input values from the touch pad's Y axis.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x138
	[Tooltip("The Custom Controller element that will receive input values from touch pad taps.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x140
	[Tooltip("The Custom Controller element that will receive input values from touch pad presses.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTargetSetForBoolean _pressCustomControllerElement; // 0x148
	[Tooltip("The axis directions in which movement is allowed. You can restrict movement to one or both axes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchPad.AxisDirection _axesToUse; // 0x150
	[Tooltip("The mode of the touch pad.

Delta - Returns the change in position of the touch from the previous to the current frame.

Screen Position - Returns the absolute position of the touch  on the screen.

Vector From Center - Returns a vector from the center of the Touch Pad to the current touch position.

Vector From Initial Touch - Returns a vector from the intial touch position to the current touch position.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchPad.TouchPadMode _touchPadMode; // 0x154
	[Tooltip("The format of the resulting data generated by the touch pad.

Pixels - Screen pixels.

Screen - The proportion of the value to screen size in the corresponding dimension. 1 unit = 1 screen length (width for X, height for Y).

Physical - 1 unit = 1/100th of an inch. The resulting value will be consistent across different screen resolutions and sizes. IMPORTANT: This relies on the value returned by UnityEngine.Screen.dpi. If the device does not return a value, a reference resolution of 96 dpi will be used.

Direction - A normalized direction vector.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchPad.ValueFormat _valueFormat; // 0x158
	[Tooltip("If enabled, when swiped and released, the value will slowly fall toward zero based on the Friction value. This only has an effect if Touch Pad Mode is set to Position Delta.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useInertia; // 0x15C
	[Tooltip("Determines how quickly a swipe value will fall toward zero when Use Inertia is enabled.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(0, 3.4028235E+38)]
	private float _inertiaFriction; // 0x160
	[Tooltip("If true, the touch pad can be activated by a touch swipe that began in an area outside the touch pad region. If false, the touch pad can only be activated by a direct touch.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _activateOnSwipeIn; // 0x164
	[Tooltip("If true, the touch pad will stay engaged even if the touch that activated it moves outside the touch pad region. If false, the touch pad will be released once the touch that activated it moves outside the touch pad region.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _stayActiveOnSwipeOut; // 0x165
	[Tooltip("Should taps on the touch pad be processed?")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _allowTap; // 0x166
	[Tooltip("The maximum touch duration allowed for the touch to be considered a tap. A touch that lasts longer than this value will not trigger a tap when released.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(0, 3.4028235E+38)]
	private float _tapTimeout; // 0x168
	[Tooltip("The maximum movement distance allowed in pixels since the touch began for the touch to be considered a tap. [-1 = no limit]")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(-1, 2147483647)]
	private int _tapDistanceLimit; // 0x16C
	[Tooltip("Should presses (continual press like a button) on the touch pad be processed?")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _allowPress; // 0x170
	[Tooltip("Time the touch pad must be touched before it will be considered a press.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _pressStartDelay; // 0x174
	[Tooltip("The maximum movement distance allowed in pixels since the touch began for the touch to be considered a press. Any movement beyond this value will cancel the press. [-1 = no limit]")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(-1, 2147483647)]
	private int _pressDistanceLimit; // 0x178
	[Tooltip("If enabled, the control will be hidden when gameplay starts.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _hideAtRuntime; // 0x17C
	[Tooltip("The underlying Axis 2D.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private StandaloneAxis2D _axis2D; // 0x180
	[Tooltip("Event sent when the value changes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchPad.ValueChangedEventHandler _onValueChanged; // 0x188
	[Tooltip("Event sent when the touch pad is tapped. This event will only be sent if allowTap is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchPad.TapEventHandler _onTap; // 0x190
	[Tooltip("Event sent when the touch pad is initally pressed. This event is for the Press button simulation which must be enabled by setting Press Allowed to True. This event will only be sent if allowPress is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchPad.PressDownEventHandler _onPressDown; // 0x198
	[Tooltip("Event sent when the touch pad is released after a press. This event is for the Press button simulation which must be enabled by setting Press Allowed to True. This event will only be sent if allowPress is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchPad.PressUpEventHandler _onPressUp; // 0x1A0
	private bool _useXAxis; // 0x1A8
	private bool _useYAxis; // 0x1A9
	private int _pointerId; // 0x1AC
	private int _realMousePointerId; // 0x1B0
	private bool lfGdLUwWRxHNIatwEAwDtAqxZvQQ; // 0x1B4
	private bool ZLGSAoLNCwCDjyGTunitFOJIitQGA; // 0x1B5
	private bool _pointerDownIsFake; // 0x1B6
	private Vector2 _touchStartPosition; // 0x1B8
	private float _touchStartTime; // 0x1C0
	private Vector3 _currentCenter; // 0x1C4
	private Vector2 _previousTouchPosition; // 0x1D0
	private int _lastTapFrame; // 0x1D8
	private bool _isEligibleForTap; // 0x1DC
	private bool _isEligibleForPress; // 0x1DD
	private bool _pressValue; // 0x1DE
	private TouchPad.wCBIafSknqZihTHAZGrAbNRHvUTV _smoothDelta; // 0x1E0
	private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x1E8

	// Properties
	public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get; }
	public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get; }
	public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get; }
	public CustomControllerElementTargetSetForBoolean pressCustomControllerElement { get; }
	public TouchPad.AxisDirection axesToUse { get; set; }
	public TouchPad.TouchPadMode touchPadMode { get; set; }
	public TouchPad.ValueFormat valueFormat { get; set; }
	public bool useInertia { get; set; }
	public float inertiaFriction { get; set; }
	public bool activateOnSwipeIn { get; set; }
	public bool stayActiveOnSwipeOut { get; set; }
	public bool allowTap { get; set; }
	public float tapTimeout { get; set; }
	public int tapDistanceLimit { get; set; }
	public bool allowPress { get; set; }
	public float pressStartDelay { get; set; }
	public int pressDistanceLimit { get; set; }
	public bool hideAtRuntime { get; set; }
	public int pointerId { get; set; }
	public bool hasPointer { get; }
	public Vector2 touchStartPosition { get; }
	public Vector2 touchPosition { get; }
	public AxisCalibration horizontalAxisCalibration { get; }
	public AxisCalibration verticalAxisCalibration { get; }
	public Axis2DCalibration axis2DCalibration { get; }
	internal StandaloneAxis2D OCvrbxaegKBwcOCBDJRWOXPMEtGW { get; }
	private int gHRyszHqSJuCNDqlEYCQtTOQsmKQ { get; }
	private bool rWGDpRkhTYPefhXPdunUBMigiSntc { get; }

	// Methods

	// RVA: 0x17A1BE0 Offset: 0x17A01E0 VA: 0x1817A1BE0
	public void add_ValueChangedEvent(UnityAction<Vector2> value) { }

	// RVA: 0x17A3620 Offset: 0x17A1C20 VA: 0x1817A3620
	public void remove_ValueChangedEvent(UnityAction<Vector2> value) { }

	// RVA: 0x17A1BB0 Offset: 0x17A01B0 VA: 0x1817A1BB0
	public void add_TapEvent(UnityAction value) { }

	// RVA: 0x17A35F0 Offset: 0x17A1BF0 VA: 0x1817A35F0
	public void remove_TapEvent(UnityAction value) { }

	// RVA: 0x17A1B50 Offset: 0x17A0150 VA: 0x1817A1B50
	public void add_PressDownEvent(UnityAction value) { }

	// RVA: 0x17A3590 Offset: 0x17A1B90 VA: 0x1817A3590
	public void remove_PressDownEvent(UnityAction value) { }

	// RVA: 0x17A1B80 Offset: 0x17A0180 VA: 0x1817A1B80
	public void add_PressUpEvent(UnityAction value) { }

	// RVA: 0x17A35C0 Offset: 0x17A1BC0 VA: 0x1817A35C0
	public void remove_PressUpEvent(UnityAction value) { }

	// RVA: 0x17871D0 Offset: 0x17857D0 VA: 0x1817871D0
	public CustomControllerElementTargetSetForFloat get_horizontalAxisCustomControllerElement() { }

	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	public CustomControllerElementTargetSetForFloat get_verticalAxisCustomControllerElement() { }

	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	public CustomControllerElementTargetSetForBoolean get_tapCustomControllerElement() { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	public CustomControllerElementTargetSetForBoolean get_pressCustomControllerElement() { }

	// RVA: 0x1791B00 Offset: 0x1790100 VA: 0x181791B00
	public TouchPad.AxisDirection get_axesToUse() { }

	// RVA: 0x17A36C0 Offset: 0x17A1CC0 VA: 0x1817A36C0
	public void set_axesToUse(TouchPad.AxisDirection value) { }

	// RVA: 0x17A24E0 Offset: 0x17A0AE0 VA: 0x1817A24E0
	public TouchPad.TouchPadMode get_touchPadMode() { }

	// RVA: 0x17A38E0 Offset: 0x17A1EE0 VA: 0x1817A38E0
	public void set_touchPadMode(TouchPad.TouchPadMode value) { }

	// RVA: 0x17A2690 Offset: 0x17A0C90 VA: 0x1817A2690
	public TouchPad.ValueFormat get_valueFormat() { }

	// RVA: 0x17A3900 Offset: 0x17A1F00 VA: 0x1817A3900
	public void set_valueFormat(TouchPad.ValueFormat value) { }

	// RVA: 0x1787080 Offset: 0x1785680 VA: 0x181787080
	public bool get_useInertia() { }

	// RVA: 0x17879B0 Offset: 0x1785FB0 VA: 0x1817879B0
	public void set_useInertia(bool value) { }

	// RVA: 0x3527A0 Offset: 0x350DA0 VA: 0x1803527A0
	public float get_inertiaFriction() { }

	// RVA: 0x17A3730 Offset: 0x17A1D30 VA: 0x1817A3730
	public void set_inertiaFriction(float value) { }

	// RVA: 0x1787090 Offset: 0x1785690 VA: 0x181787090
	public bool get_activateOnSwipeIn() { }

	// RVA: 0x17879D0 Offset: 0x1785FD0 VA: 0x1817879D0
	public void set_activateOnSwipeIn(bool value) { }

	// RVA: 0x17A24C0 Offset: 0x17A0AC0 VA: 0x1817A24C0
	public bool get_stayActiveOnSwipeOut() { }

	// RVA: 0x17A3820 Offset: 0x17A1E20 VA: 0x1817A3820
	public void set_stayActiveOnSwipeOut(bool value) { }

	// RVA: 0x17A2410 Offset: 0x17A0A10 VA: 0x1817A2410
	public bool get_allowTap() { }

	// RVA: 0x17A36A0 Offset: 0x17A1CA0 VA: 0x1817A36A0
	public void set_allowTap(bool value) { }

	// RVA: 0x1787130 Offset: 0x1785730 VA: 0x181787130
	public float get_tapTimeout() { }

	// RVA: 0x17A3890 Offset: 0x17A1E90 VA: 0x1817A3890
	public void set_tapTimeout(float value) { }

	// RVA: 0x17A24D0 Offset: 0x17A0AD0 VA: 0x1817A24D0
	public int get_tapDistanceLimit() { }

	// RVA: 0x17A3840 Offset: 0x17A1E40 VA: 0x1817A3840
	public void set_tapDistanceLimit(int value) { }

	// RVA: 0x17A2400 Offset: 0x17A0A00 VA: 0x1817A2400
	public bool get_allowPress() { }

	// RVA: 0x17A3680 Offset: 0x17A1C80 VA: 0x1817A3680
	public void set_allowPress(bool value) { }

	// RVA: 0x17A24B0 Offset: 0x17A0AB0 VA: 0x1817A24B0
	public float get_pressStartDelay() { }

	// RVA: 0x17A37E0 Offset: 0x17A1DE0 VA: 0x1817A37E0
	public void set_pressStartDelay(float value) { }

	// RVA: 0x17A24A0 Offset: 0x17A0AA0 VA: 0x1817A24A0
	public int get_pressDistanceLimit() { }

	// RVA: 0x17A3790 Offset: 0x17A1D90 VA: 0x1817A3790
	public void set_pressDistanceLimit(int value) { }

	// RVA: 0x17A2450 Offset: 0x17A0A50 VA: 0x1817A2450
	public bool get_hideAtRuntime() { }

	// RVA: 0x17A3700 Offset: 0x17A1D00 VA: 0x1817A3700
	public void set_hideAtRuntime(bool value) { }

	// RVA: 0x17A2490 Offset: 0x17A0A90 VA: 0x1817A2490
	public int get_pointerId() { }

	// RVA: 0x17A3780 Offset: 0x17A1D80 VA: 0x1817A3780
	public void set_pointerId(int value) { }

	// RVA: 0x17A2440 Offset: 0x17A0A40 VA: 0x1817A2440
	public bool get_hasPointer() { }

	// RVA: 0x17A2620 Offset: 0x17A0C20 VA: 0x1817A2620
	public Vector2 get_touchStartPosition() { }

	// RVA: 0x17A24F0 Offset: 0x17A0AF0 VA: 0x1817A24F0
	public Vector2 get_touchPosition() { }

	// RVA: 0x17A2460 Offset: 0x17A0A60 VA: 0x1817A2460
	public AxisCalibration get_horizontalAxisCalibration() { }

	// RVA: 0x17A26A0 Offset: 0x17A0CA0 VA: 0x1817A26A0
	public AxisCalibration get_verticalAxisCalibration() { }

	// RVA: 0x17A2420 Offset: 0x17A0A20 VA: 0x1817A2420
	public Axis2DCalibration get_axis2DCalibration() { }

	// RVA: 0x17A1C60 Offset: 0x17A0260 VA: 0x1817A1C60
	internal StandaloneAxis2D ehomRkZjtzQSgriiJQHaPqpgOFyw() { }

	// RVA: 0x17A2F80 Offset: 0x17A1580 VA: 0x1817A2F80
	private int kZGEFYMDwawkOzlfrhmIaTPgdYKV() { }

	// RVA: 0x17A1C40 Offset: 0x17A0240 VA: 0x1817A1C40
	private bool arQkfJPqHyMKzHSmPYXsPdTkhAkw() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17A17C0 Offset: 0x179FDC0 VA: 0x1817A17C0
	private void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17A0800 Offset: 0x179EE00 VA: 0x1817A0800 Slot: 8
	internal override void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17A1480 Offset: 0x179FA80 VA: 0x1817A1480 Slot: 13
	internal override void OnValidate() { }

	// RVA: 0x17A23D0 Offset: 0x17A09D0 VA: 0x1817A23D0 Slot: 19
	internal override bool gdbGHffXnsPTWqjvaABZHAmCgGTi() { }

	// RVA: 0x17A2BD0 Offset: 0x17A11D0 VA: 0x1817A2BD0 Slot: 18
	internal override void jpDnQSBIYxEEYfNDFomeMuNFSNPd() { }

	// RVA: 0x17A3920 Offset: 0x17A1F20 VA: 0x1817A3920 Slot: 30
	internal override void uwszEwbuDhSUuDkyYcwhjzDRqvIp() { }

	// RVA: 0x17A1B10 Offset: 0x17A0110 VA: 0x1817A1B10 Slot: 23
	internal override void aMIHwyJCaljBKRBzTQgEndoXBAwr() { }

	// RVA: 0x17A32B0 Offset: 0x17A18B0 VA: 0x1817A32B0 Slot: 24
	internal override void qzEGFuAsFyaErKssLOfaxcOmklkk() { }

	// RVA: 0x17A0940 Offset: 0x179EF40 VA: 0x1817A0940 Slot: 7
	public override void ClearValue() { }

	// RVA: 0x17A2340 Offset: 0x17A0940 VA: 0x1817A2340
	private void gOFsKepcoxCVurdbwhClnjNdRJnv() { }

	// RVA: 0x17A1C70 Offset: 0x17A0270 VA: 0x1817A1C70
	private void ewWpWGLJqMaMOkVrbFxubMlIgmLj() { }

	// RVA: 0x17A31C0 Offset: 0x17A17C0 VA: 0x1817A31C0
	private void ooxXaCasnHXxrFnhDBvCwwoiuicw(TouchPad.AxisDirection ) { }

	// RVA: 0x17A1610 Offset: 0x179FC10 VA: 0x1817A1610
	private void TbwdnlgswdOTiMHugEvNAwOLqzhbA() { }

	// RVA: 0x17A3A90 Offset: 0x17A2090 VA: 0x1817A3A90
	private void wNuXDGGjnFUirespaDTQKBOcPWvj() { }

	// RVA: 0x17A2A80 Offset: 0x17A1080 VA: 0x1817A2A80
	private void hlhbWKjVqkFXnekmhoXmCFoeNpZUB() { }

	// RVA: 0x17A0D30 Offset: 0x179F330 VA: 0x1817A0D30
	private void KcEqvknpKbMDJFFZdkkKSLTHXxjU() { }

	// RVA: 0x17A34F0 Offset: 0x17A1AF0 VA: 0x1817A34F0
	private void rebjVYzIYFiDbjdfJDEbdtHQKPpL(ref Vector2 ) { }

	// RVA: 0x17A0A10 Offset: 0x179F010 VA: 0x1817A0A10
	private void CoSTNXMMjOtMbLwcstEySqCVfRDIA(ref Vector2 ) { }

	// RVA: 0x17A14C0 Offset: 0x179FAC0 VA: 0x1817A14C0
	private void SnnQgepbexutLucIJLHslBjBXCkB() { }

	// RVA: 0x17A0F40 Offset: 0x179F540 VA: 0x1817A0F40
	private Vector2 MBfhrbFnganQIdcHMxoftlfFEFpHb(Vector2 ) { }

	// RVA: 0x17A2FB0 Offset: 0x17A15B0 VA: 0x1817A2FB0
	private void nXRtHIVLvufWQiwHwjdgwIRyaXhZ(bool ) { }

	// RVA: 0x17A33C0 Offset: 0x17A19C0 VA: 0x1817A33C0
	private void rPGBnMKQkyqWxHHhybtVMxuysEIO(PointerEventData ) { }

	// RVA: 0x17A0870 Offset: 0x179EE70 VA: 0x1817A0870
	private void CEZbyfijJGMjbwxFKdjQALzDhMdsB(PointerEventData ) { }

	// RVA: 0x17A2150 Offset: 0x17A0750 VA: 0x1817A2150
	private void gHBsrOnyUPEjUvTQDRsqkKPvQJfF(PointerEventData ) { }

	// RVA: 0x17A0CA0 Offset: 0x179F2A0 VA: 0x1817A0CA0
	private void FNWyzPEbExDjqFKjTbyeanHuhHGL(PointerEventData ) { }

	// RVA: 0x17A1730 Offset: 0x179FD30 VA: 0x1817A1730
	private void ZKFAZibolkkbpkszahwXqRjlunWt(int , Vector2 ) { }

	// RVA: 0x17A4030 Offset: 0x17A2630 VA: 0x1817A4030
	private void xFKEYCFmsnIftxFUAfFrWGdSlRhhA() { }

	// RVA: 0x17A1340 Offset: 0x179F940 VA: 0x1817A1340 Slot: 45
	internal override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x17A1100 Offset: 0x179F700 VA: 0x1817A1100 Slot: 44
	internal override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17A11A0 Offset: 0x179F7A0 VA: 0x1817A11A0 Slot: 46
	internal override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x17A1240 Offset: 0x179F840 VA: 0x1817A1240 Slot: 47
	internal override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x17A10E0 Offset: 0x179F6E0 VA: 0x1817A10E0
	private void MmMJIjVytdLyHDYqcrixUNySFEMe() { }

	// RVA: 0x17A3120 Offset: 0x17A1720 VA: 0x1817A3120
	private bool oIqZIZUJdtJAgHzsuHrbOkWolFUo(int ) { }

	// RVA: 0x17A1D80 Offset: 0x17A0380 VA: 0x1817A1D80
	private PointerEventData fWXIPhUIksiunwDkLZoBgONmnhgT(int , GameObject ) { }

	// RVA: 0x17A3000 Offset: 0x17A1600 VA: 0x1817A3000
	private PointerEventData nePYxySjPtNtjIjfjgetDPMMNzhp(int , GameObject ) { }

	// RVA: 0x17A26D0 Offset: 0x17A0CD0 VA: 0x1817A26D0
	private PointerEventData hJctmOjrmqDrPbgQevzjgjqyqaDL(int ) { }

	// RVA: 0x17A0AF0 Offset: 0x179F0F0 VA: 0x1817A0AF0
	private void ENkIEnYoYWSKzRuKUwCrCcZAFzWr(PointerEventData ) { }

	// RVA: 0x17A2860 Offset: 0x17A0E60 VA: 0x1817A2860
	private PointerEventData hkDdASIptzmVeASRJLPSGRChMZhpC(int ) { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Touch Region")]
[Serializable]
public sealed class TouchRegion : TouchInteractable // TypeDefIndex: 2772
{
	// Fields
	[Tooltip("If enabled, the Touch Region will be hidden when gameplay starts.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _hideAtRuntime; // 0x130
	private TouchRegion.QrvDmFhlHGnRncLxzbJEvBVwMgbaA _onPointerDown; // 0x138
	private TouchRegion.BTeDlbCEGeLNUrdmbqSgCSpJrADD _onPointerUp; // 0x140
	private TouchRegion.mnlZHsLcuHqdDbSLQsmXHgmpbjnn _onPointerEnter; // 0x148
	private TouchRegion.EfJHaRkphqxiTigAHpeEyFAnkhMO _onPointerExit; // 0x150
	private TouchRegion.RpFscDBBPtjCDMkuvLsdcJnoFTqHA _onBeginDrag; // 0x158
	private TouchRegion.rGBNbBnQAVZkZzheEhIOEBqeSfPf _onDrag; // 0x160
	private TouchRegion.gpnRdfLsbFAAjkBUMljPboKCSjZIc _onEndDrag; // 0x168

	// Properties
	public bool hideAtRuntime { get; set; }

	// Methods

	// RVA: 0x17A4D50 Offset: 0x17A3350 VA: 0x1817A4D50
	public bool get_hideAtRuntime() { }

	// RVA: 0x17A51E0 Offset: 0x17A37E0 VA: 0x1817A51E0
	public void set_hideAtRuntime(bool value) { }

	// RVA: 0x17A4AE0 Offset: 0x17A30E0 VA: 0x1817A4AE0
	public void add_PointerDownEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A5060 Offset: 0x17A3660 VA: 0x1817A5060
	public void remove_PointerDownEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A4C00 Offset: 0x17A3200 VA: 0x1817A4C00
	public void add_PointerUpEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A5180 Offset: 0x17A3780 VA: 0x1817A5180
	public void remove_PointerUpEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A4B40 Offset: 0x17A3140 VA: 0x1817A4B40
	public void add_PointerEnterEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A50C0 Offset: 0x17A36C0 VA: 0x1817A50C0
	public void remove_PointerEnterEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A4BA0 Offset: 0x17A31A0 VA: 0x1817A4BA0
	public void add_PointerExitEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A5120 Offset: 0x17A3720 VA: 0x1817A5120
	public void remove_PointerExitEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A49C0 Offset: 0x17A2FC0 VA: 0x1817A49C0
	public void add_BeginDragEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A4F40 Offset: 0x17A3540 VA: 0x1817A4F40
	public void remove_BeginDragEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A4A20 Offset: 0x17A3020 VA: 0x1817A4A20
	public void add_DragEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A4FA0 Offset: 0x17A35A0 VA: 0x1817A4FA0
	public void remove_DragEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A4A80 Offset: 0x17A3080 VA: 0x1817A4A80
	public void add_EndDragEvent(UnityAction<PointerEventData> value) { }

	// RVA: 0x17A5000 Offset: 0x17A3600 VA: 0x1817A5000
	public void remove_EndDragEvent(UnityAction<PointerEventData> value) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17A46E0 Offset: 0x17A2CE0 VA: 0x1817A46E0
	private void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17A42B0 Offset: 0x17A28B0 VA: 0x1817A42B0 Slot: 8
	internal override void Awake() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void ClearValue() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 30
	internal override void FdNyVzrXbareYNTtAgryMGXipqxE() { }

	// RVA: 0x17A4C60 Offset: 0x17A3260 VA: 0x1817A4C60 Slot: 44
	internal override void cgzFkzeRtfTVDKuFuiirwMSwFRuR(PointerEventData ) { }

	// RVA: 0x17A4410 Offset: 0x17A2A10 VA: 0x1817A4410 Slot: 45
	internal override void KuQZHmFjcMHsPeQDXUkixOMRwNrN(PointerEventData ) { }

	// RVA: 0x17A4D60 Offset: 0x17A3360 VA: 0x1817A4D60 Slot: 46
	internal override void pTGyMMUsfDtAaAQnKYsdIwhBuwji(PointerEventData ) { }

	// RVA: 0x17A4320 Offset: 0x17A2920 VA: 0x1817A4320 Slot: 47
	internal override void FuHQEMDTYyuomVbdydseJTfZHMY(PointerEventData ) { }

	// RVA: 0x17A45F0 Offset: 0x17A2BF0 VA: 0x1817A45F0 Slot: 48
	internal override void ZvWFIGoqaLAvDaIPkJynSdhvYcVW(PointerEventData ) { }

	// RVA: 0x17A4E50 Offset: 0x17A3450 VA: 0x1817A4E50 Slot: 49
	internal override void pxFRgrbfLdOOLYczwIRFHaRXepag(PointerEventData ) { }

	// RVA: 0x17A4500 Offset: 0x17A2B00 VA: 0x1817A4500 Slot: 50
	internal override void PpXkYEXDvldoghVxBGUXgtBYrXzEA(PointerEventData ) { }
}

