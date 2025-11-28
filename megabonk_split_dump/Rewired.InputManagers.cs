// Namespace: Rewired.InputManagers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class CustomInputManager : PlatformInputManager // TypeDefIndex: 2194
{
	// Fields
	private List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> oxDsQJPlYuzrzWvVigPHWqnXXoXN; // 0x38
	private int pplpkIOqXMTcHHzdPLGZbtDDEweb; // 0x40
	private CustomInputManager.EsSalVUwoRpQyImrUHVVyrbvwytP QoyFDcIrNVRMJvHYCITxeDdpegiKA; // 0x48
	private UpdateLoopType szvSKssrzwSiKhmbQWOxXRtkuCAH; // 0x50
	private Action<int, ControllerDataUpdater> WAicUpDZjuErKmrXBQRThZXFCIDJ; // 0x58
	private PlatformInputManager aweVzmcyHyDOhHJkawzZJuTyjmUu; // 0x60
	private CustomInputSource ugnyLhkJNbZVeeSfNqHWuHeGHsKA; // 0x68
	private bool cExbrUCoIwbufWLEYzypAtTScnkU; // 0x70
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> ANhStcFpRfXKfROfputcTNKVsEEd; // 0x78
	private Func<int> SGEaYYFIzKUNofrfnNUvdfQBQGVpA; // 0x80

	// Properties
	[CustomObfuscation(rename = False)]
	public override int deviceCount { get; }
	[CustomObfuscation(rename = False)]
	public override PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	public override IInputSource inputSource { get; }
	[CustomObfuscation(rename = False)]
	public override InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x16F4C10 Offset: 0x16F3210 VA: 0x1816F4C10
	public void .ctor(CustomInputSource , UpdateLoopSetting , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Func<int> ) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30 Slot: 4
	public override int get_deviceCount() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 5
	public override PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public override IInputSource get_inputSource() { }

	// RVA: 0x16F50A0 Offset: 0x16F36A0 VA: 0x1816F50A0 Slot: 7
	public override InputSource get_inputSourceType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F4090 Offset: 0x16F2690 VA: 0x1816F4090 Slot: 8
	public override void Initialize() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F4A20 Offset: 0x16F3020 VA: 0x1816F4A20 Slot: 9
	public override void Update(UpdateLoopType updateLoop) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F4560 Offset: 0x16F2B60 VA: 0x1816F4560 Slot: 10
	public override void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 14
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F4900 Offset: 0x16F2F00 VA: 0x1816F4900 Slot: 13
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F48C0 Offset: 0x16F2EC0 VA: 0x1816F48C0 Slot: 11
	public override void SystemDeviceConnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F48E0 Offset: 0x16F2EE0 VA: 0x1816F48E0 Slot: 12
	public override void SystemDeviceDisconnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	public override void SetUnityJoystickId(int joystickId, int unityJoystickIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F3B30 Offset: 0x16F2130 VA: 0x1816F3B30 Slot: 16
	public override IUnifiedMouseSource GetUnifiedMouseSource() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16F3B10 Offset: 0x16F2110 VA: 0x1816F3B10 Slot: 17
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	// RVA: 0x16F3B50 Offset: 0x16F2150 VA: 0x1816F3B50
	private void HMkpDWcEWoZoipFmoHhxIlIwRJxl(CustomInputSource.Joystick[] ) { }

	// RVA: 0x16F4670 Offset: 0x16F2C70 VA: 0x1816F4670
	private void SCVbtTFCSPfzVKjUTWIqjrvCAuUdb() { }

	// RVA: 0x16F5510 Offset: 0x16F3B10 VA: 0x1816F5510
	private void tmlwoDLqWiOZTFeXLauMiamHXGKy(int , int , List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> ) { }

	// RVA: 0x16F4E70 Offset: 0x16F3470 VA: 0x1816F4E70
	private void awsDcSfGeEUsYlTHkLptmKZQzokS(List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , int , int ) { }

	// RVA: 0x16F4F50 Offset: 0x16F3550 VA: 0x1816F4F50
	private bool ccoHVtlfHZoLoEauzYpdTwVINVrm(List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , int ) { }

	// RVA: 0x16F50C0 Offset: 0x16F36C0 VA: 0x1816F50C0
	private int jBkcYSzubKMNsJpwVPKGkJgGPsZo(List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> ) { }

	// RVA: 0x16F5000 Offset: 0x16F3600 VA: 0x1816F5000
	private bool eaIgKMTVWXBAbHiuwyMBbJivLIKtA(List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , int ) { }

	// RVA: 0x16F3940 Offset: 0x16F1F40 VA: 0x1816F3940
	private void DToAJQilbUhLXkfytzQVHaBJCzGQA(int , List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , int , List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , CustomInputManager.EsSalVUwoRpQyImrUHVVyrbvwytP.zkdMCdLWnCNBoYDqVwuwNOlAbAtFA ) { }

	// RVA: 0x16F5280 Offset: 0x16F3880 VA: 0x1816F5280
	private void qtpdvLApCDOTjZaSiKyNiAKoYXXy(int , List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , CustomInputManager.EsSalVUwoRpQyImrUHVVyrbvwytP.zkdMCdLWnCNBoYDqVwuwNOlAbAtFA ) { }

	// RVA: 0x16F5780 Offset: 0x16F3D80 VA: 0x1816F5780
	private void xHYMmwgjVLtExtFPGFkFHHCmhAUh() { }

	// RVA: 0x16F42E0 Offset: 0x16F28E0 VA: 0x1816F42E0
	private bool MVNZBfntTrrYlwnmLejVBmelZljU(CustomInputSource.Joystick[] ) { }

	// RVA: 0x16F41C0 Offset: 0x16F27C0 VA: 0x1816F41C0
	private void KaXHMbGDHGJqIOqnRUurjJDdGYNu(List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , List<CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts> , bool ) { }

	// RVA: 0x16F5170 Offset: 0x16F3770 VA: 0x1816F5170
	private void pBjkucWjycJoqEnBwbcWdoqZHELe(CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts , bool ) { }

	// RVA: 0x16F4580 Offset: 0x16F2B80 VA: 0x1816F4580
	private void PPlghwyBhhBIEDBiYiQJRlbBAkybb(CustomInputManager.ifLOodAiDNAvPlLYpyrPuneEMcts , bool ) { }
}

// Namespace: Rewired.InputManagers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class Initializer : PlatformInitializer // TypeDefIndex: 5753
{
	// Fields
	internal const string initErrorMsg = "";
	private static PlatformInitializer bePQRYVoYNjFgOtNxfvlipyBTzGQ; // 0x0

	// Methods

	// RVA: 0x18E8810 Offset: 0x18E6E10 VA: 0x1818E8810
	public static PlatformInitializer GetPlatformInitializer() { }

	// RVA: 0x18E88A0 Offset: 0x18E6EA0 VA: 0x1818E88A0 Slot: 4
	public override object Initialize(IConfigVars_Internal configVars) { }

	// RVA: 0x18E8760 Offset: 0x18E6D60 VA: 0x1818E8760 Slot: 5
	public override IElementIdentifierTool CreateTool(string inputSourceString) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

