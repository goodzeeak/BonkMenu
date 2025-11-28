// Namespace: Rewired.Platforms.Custom
public abstract class CustomInputSource : IDisposable // TypeDefIndex: 2266
{
	// Fields
	private readonly InputSource ygVhJQOauytZotJUWpRpNWPyWHVQ; // 0x10
	private readonly List<CustomInputSource.Joystick> QLtQzhYLNGCxqriGafiZDrgAvdMo; // 0x18
	private readonly ReadOnlyCollection<CustomInputSource.Joystick> tWllBLsLEQTobYXHOGeDUkyLLNNn; // 0x20
	private bool NxOYGCqglqigNCqmqwZvAaWTshRC; // 0x28
	private IUnifiedKeyboardSource tNWbFqbWTyZYTRqZQWbZhzKTvUdEA; // 0x30
	private IUnifiedMouseSource XjMYlrifvWgIDdnXHhzEfRuWmeJBb; // 0x38
	[CompilerGenerated]
	private Action VMGlSZMahWBKnifTXgvmelYTQSCT; // 0x40
	[CompilerGenerated]
	private Action JxPKhmwYUBNKNkKIWPsjTrxxaJGO; // 0x48
	private bool xFSrWORcHcHrivkvvehfenBCgdFbA; // 0x50

	// Properties
	public bool useApproximateMatching { get; set; }
	internal InputSource aHQubFAjaZkEeXRnRjKNWgDiZtay { get; }
	public abstract bool isReady { get; }

	// Methods

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_useApproximateMatching() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	protected void set_useApproximateMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x16F6310 Offset: 0x16F4910 VA: 0x1816F6310
	private void bUmvGSbNJvAVxEycFhfVvcLMpZIiA(Action ) { }

	[CompilerGenerated]
	// RVA: 0x16F63B0 Offset: 0x16F49B0 VA: 0x1816F63B0
	private void jELDHZIgxoUKfgMcenldvYSTcIIjb(Action ) { }

	[CompilerGenerated]
	// RVA: 0x16F5D70 Offset: 0x16F4370 VA: 0x1816F5D70
	private void avbPBxZWoMLPmWLlGJQgwivODtuv(Action ) { }

	[CompilerGenerated]
	// RVA: 0x16F5C30 Offset: 0x16F4230 VA: 0x1816F5C30
	private void ZsTbzgSLFkfvMPMcvyrCwjnbjwHb(Action ) { }

	// RVA: 0x16F6310 Offset: 0x16F4910 VA: 0x1816F6310
	internal void oKDVTLgZfWeCQdWnKTcszHoEHRbl(Action ) { }

	// RVA: 0x16F63B0 Offset: 0x16F49B0 VA: 0x1816F63B0
	internal void eaXbEmdtfhWxXQKQOQBTWJuApqTfb(Action ) { }

	// RVA: 0x16F5D70 Offset: 0x16F4370 VA: 0x1816F5D70
	internal void NWLveFDIcPnapyKvBWkwmYCIfdkO(Action ) { }

	// RVA: 0x16F5C30 Offset: 0x16F4230 VA: 0x1816F5C30
	internal void FAeGzUtmKIrjpjdLZoooBqkdZkAN(Action ) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal InputSource CtHBhTmRdbuNjprSgHkkOlSlqUbj() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal IUnifiedKeyboardSource SJepBXLyzYhbVAzbPxXznVubKFUF() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal IUnifiedMouseSource FziSvcwSPjPNfasTanVgMPLazeZG() { }

	// RVA: 0x16F6170 Offset: 0x16F4770 VA: 0x1816F6170
	public void .ctor(int ) { }

	// RVA: 0x16F6120 Offset: 0x16F4720 VA: 0x1816F6120
	internal void .ctor(int , IUnifiedKeyboardSource , IUnifiedMouseSource ) { }

	// RVA: 0x39A460 Offset: 0x398A60 VA: 0x18039A460 Slot: 5
	internal virtual void BHgDQnZQbcfBIQpPfoyJlySusCNV() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected virtual void OnInitialize() { }

	// RVA: 0x16F58F0 Offset: 0x16F3EF0 VA: 0x1816F58F0
	public void AddJoystick(CustomInputSource.Joystick joystick) { }

	// RVA: 0x16F5E50 Offset: 0x16F4450 VA: 0x1816F5E50
	public void RemoveJoystick(CustomInputSource.Joystick joystick) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IList<CustomInputSource.Joystick> GetJoysticks() { }

	// RVA: 0x16F5E10 Offset: 0x16F4410 VA: 0x1816F5E10 Slot: 7
	protected virtual void OnJoystickConnected() { }

	// RVA: 0x16F5E30 Offset: 0x16F4430 VA: 0x1816F5E30 Slot: 8
	protected virtual void OnJoystickDisconnected() { }

	// RVA: 0x16F5D40 Offset: 0x16F4340 VA: 0x1816F5D40
	private void KcECWtFRmIxYFRNovTdzehKjBNED(bool ) { }

	// RVA: 0x16F6000 Offset: 0x16F4600 VA: 0x1816F6000
	internal CustomInputSource.Joystick[] UamQtrwmhRadUdUdlpnqDHmhZHVIA() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	internal virtual void niIJZPrTMHaYrfMOIYOAKpupbvf() { }

	// RVA: 0x16F5BD0 Offset: 0x16F41D0 VA: 0x1816F5BD0 Slot: 10
	public virtual void Dispose() { }

	// RVA: 0x16F5CD0 Offset: 0x16F42D0 VA: 0x1816F5CD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16F5AA0 Offset: 0x16F40A0 VA: 0x1816F5AA0 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_isReady();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Update();
}

// Namespace: Rewired.Platforms.Custom
public sealed class CustomPlatformInitOptions // TypeDefIndex: 2267
{
	// Fields
	internal const int jAIjnEINYxTtEaOUjplRpnvemSAGb = -1;
	public int platformId; // 0x10
	public string platformIdentifierString; // 0x18
	public CustomInputSource inputSource; // 0x20
	public IHardwareJoystickMapCustomPlatformMapProvider hardwareJoystickMapCustomPlatformMapProvider; // 0x28
	public CustomPlatformConfigVars configVars; // 0x30

	// Methods

	// RVA: 0x16F6470 Offset: 0x16F4A70 VA: 0x1816F6470
	public void .ctor() { }

	// RVA: 0x16F64F0 Offset: 0x16F4AF0 VA: 0x1816F64F0
	public void .ctor(CustomPlatformInitOptions ) { }
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public class CustomPlatformConfigVars : ConfigVars.PlatformVars // TypeDefIndex: 2268
{
	// Fields
	public bool useNativeKeyboard; // 0x18
	public bool useNativeMouse; // 0x19

	// Methods

	// RVA: 0x16F6450 Offset: 0x16F4A50 VA: 0x1816F6450
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
public interface ICustomPlatformInitializer // TypeDefIndex: 2269
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CustomPlatformInitOptions GetCustomPlatformInitOptions();
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformInputSource : CustomInputSource // TypeDefIndex: 2272
{
	// Fields
	private readonly CustomPlatformConfigVars JZkQLwfopzUfnBKQwiZUPOXqymtH; // 0x58
	private readonly bool sETGnEfjkxRrptWrsbAspmGRPcAI; // 0x60
	private readonly bool SGnTVTBwsPNEFaoDbUjKeAWKNlIP; // 0x61
	private bool xnDZxitqVHZHOyYrqzynfSMZNrSG; // 0x62

	// Methods

	// RVA: 0x16F67D0 Offset: 0x16F4DD0 VA: 0x1816F67D0
	protected void .ctor(CustomPlatformConfigVars , CustomPlatformInputSource.InitOptions ) { }

	// RVA: 0x16F6640 Offset: 0x16F4C40 VA: 0x1816F6640 Slot: 5
	internal override void UnQahBHruWcRBbGDdPgiqdHJsXRJ() { }

	// RVA: 0x16F69D0 Offset: 0x16F4FD0 VA: 0x1816F69D0 Slot: 9
	internal override void kiZPBeCnROxEiowGJPWpERyEgdBP() { }

	// RVA: 0x16F6620 Offset: 0x16F4C20 VA: 0x1816F6620 Slot: 11
	protected override void Dispose(bool disposing) { }
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformUnifiedControllerSource : IDisposable // TypeDefIndex: 2273
{
	// Fields
	private readonly int RTkfQbKTFPSeeBGBBPncltMEtKPoA; // 0x10
	private readonly int SWtXgXnhWKZZDZUgrVTChwCWrPcb; // 0x14
	private readonly bool[] KTRtUSedRMkjlFGSGeapusozoMWS; // 0x18
	private readonly bool[] xLhhhddnMQaXMwXtnfrrbmTOIkPjb; // 0x20
	private readonly float[] BRQkrdDNUeSbDWSSPYSpUZCOKWsu; // 0x28
	private bool ZsQbvrdljETFLtebDMYeXyMDaMmAA; // 0x30

	// Properties
	public int axisCount { get; }
	public int buttonCount { get; }
	public virtual Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: 0x16F72F0 Offset: 0x16F58F0 VA: 0x1816F72F0
	public void .ctor(int , int ) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void Update();

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	internal virtual void lLFygwRTPtikyvcXNjOynxAOxFnA() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_axisCount() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_buttonCount() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public virtual Controller.Extension get_controllerExtension() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void OnInitialize() { }

	// RVA: 0x16F6B90 Offset: 0x16F5190 VA: 0x1816F6B90 Slot: 9
	protected virtual void Clear() { }

	// RVA: 0x16F6BF0 Offset: 0x16F51F0 VA: 0x1816F6BF0
	protected float GetAxisValue(int index) { }

	// RVA: 0x16F6C30 Offset: 0x16F5230 VA: 0x1816F6C30
	protected bool GetButtonValue(int index) { }

	// RVA: 0x16F6C70 Offset: 0x16F5270 VA: 0x1816F6C70
	protected void SetAxisValue(int index, float value) { }

	// RVA: 0x16F6CB0 Offset: 0x16F52B0 VA: 0x1816F6CB0
	protected void SetAxisValues(IList<float> values) { }

	// RVA: 0x16F6E60 Offset: 0x16F5460 VA: 0x1816F6E60
	protected void SetButtonValue(int index, bool value) { }

	// RVA: 0x16F6ED0 Offset: 0x16F54D0 VA: 0x1816F6ED0
	protected void SetButtonValues(IList<bool> values) { }

	// RVA: 0xD13700 Offset: 0xD11D00 VA: 0x180D13700
	internal void bConiREfHlMaKtEAAaBmUsaHsOqE() { }

	// RVA: 0x54A640 Offset: 0x548C40 VA: 0x18054A640
	internal void wERnMgyiUgrqIHsHDJZXXCHfFiAA() { }

	// RVA: 0x16F7170 Offset: 0x16F5770 VA: 0x1816F7170
	internal void TkOZhCMHIYejqeDpgJxjHpVvoBcM(ControllerDataUpdater ) { }

	// RVA: 0x16F72C0 Offset: 0x16F58C0 VA: 0x1816F72C0
	private void WgsZVPTmEpubGEYInpGLtbgrZvEV() { }

	// RVA: 0x16F6BE0 Offset: 0x16F51E0 VA: 0x1816F6BE0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F7110 Offset: 0x16F5710 VA: 0x1816F7110 Slot: 4
	private void System.IDisposable.Dispose() { }
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformUnifiedMouseSource : CustomPlatformUnifiedControllerSource // TypeDefIndex: 2274
{
	// Properties
	public abstract Vector2 mousePosition { get; }

	// Methods

	// RVA: 0x16F7800 Offset: 0x16F5E00 VA: 0x1816F7800
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Vector2 get_mousePosition();
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformUnifiedKeyboardSource : CustomPlatformUnifiedControllerSource // TypeDefIndex: 2277
{
	// Fields
	private CustomPlatformUnifiedKeyboardSource.KeyPropertyMap WxFSEAJKXiMqdzsMOSpfEfdIaaMx; // 0x38

	// Properties
	public CustomPlatformUnifiedKeyboardSource.KeyPropertyMap keyPropertyMap { get; set; }

	// Methods

	// RVA: 0x16F76A0 Offset: 0x16F5CA0 VA: 0x1816F76A0
	public void .ctor() { }

	// RVA: 0x16F7720 Offset: 0x16F5D20 VA: 0x1816F7720
	public CustomPlatformUnifiedKeyboardSource.KeyPropertyMap get_keyPropertyMap() { }

	// RVA: 0x16F7790 Offset: 0x16F5D90 VA: 0x1816F7790
	public void set_keyPropertyMap(CustomPlatformUnifiedKeyboardSource.KeyPropertyMap value) { }

	// RVA: 0x16F75C0 Offset: 0x16F5BC0 VA: 0x1816F75C0
	protected void SetKeyValue(KeyboardKeyCode keyCode, bool value) { }

	// RVA: 0x16F75A0 Offset: 0x16F5BA0 VA: 0x1816F75A0 Slot: 6
	internal override void PaTMudwGPZIUqncAwCmaFhZKSGTT() { }

	// RVA: 0x16F73C0 Offset: 0x16F59C0 VA: 0x1816F73C0
	private void HGAfVIorlDFhSntIGHTWYJnMMbpl() { }
}

// Namespace: Rewired.Platforms.Custom
public interface IHardwareJoystickMapCustomPlatformMapProvider // TypeDefIndex: 2278
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract HardwareJoystickMap.Platform GetPlatformMap(int customPlatformId, Guid hardwareTypeGuid);
}

// Namespace: Rewired.Platforms.Custom
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMapCustomPlatformMap : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 2283
{
	// Fields
	[Tooltip("The list of controller elements.")]
	public HardwareJoystickMapCustomPlatformMap.Elements elements; // 0x18
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x20
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x28

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMapCustomPlatformMap.Axis[] Axes_orig { get; }
	internal HardwareJoystickMapCustomPlatformMap.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x16F9050 Offset: 0x16F7650 VA: 0x1816F9050 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x16F9020 Offset: 0x16F7620 VA: 0x1816F9020 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x80F2D0 Offset: 0x80D8D0 VA: 0x18080F2D0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x16F8DC0 Offset: 0x16F73C0 VA: 0x1816F8DC0 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x16F8EF0 Offset: 0x16F74F0 VA: 0x1816F8EF0 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x16F8ED0 Offset: 0x16F74D0 VA: 0x1816F8ED0
	internal HardwareJoystickMapCustomPlatformMap.Axis[] get_Axes_orig() { }

	// RVA: 0x16F9000 Offset: 0x16F7600 VA: 0x1816F9000
	internal HardwareJoystickMapCustomPlatformMap.Button[] get_Buttons_orig() { }

	// RVA: 0x16F9080 Offset: 0x16F7680 VA: 0x1816F9080 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x16F90D0 Offset: 0x16F76D0 VA: 0x1816F90D0 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract object CreateInstance();

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 29
	protected virtual void DeepClone(object destination) { }

	// RVA: 0x16F8BB0 Offset: 0x16F71B0 VA: 0x1816F8BB0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x16F8AE0 Offset: 0x16F70E0 VA: 0x1816F8AE0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	protected void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMapCustomPlatformMap<TMatchingCriteria> : HardwareJoystickMapCustomPlatformMap // TypeDefIndex: 2286
{
	// Fields
	[Tooltip("User-defined matching criteria. Determines whether this platform map matches to a particular controller.")]
	public TMatchingCriteria matchingCriteria; // 0x0

	// Properties
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	internal override bool get_hasData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037370 Offset: 0x1035970 VA: 0x181037370
	|-HardwareJoystickMapCustomPlatformMap<object>.get_hasData
	*/

	// RVA: -1 Offset: -1 Slot: 15
	internal override bool get_disabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037350 Offset: 0x1035950 VA: 0x181037350
	|-HardwareJoystickMapCustomPlatformMap<object>.get_disabled
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal override bool get_isAllowed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10373D0 Offset: 0x10359D0 VA: 0x1810373D0
	|-HardwareJoystickMapCustomPlatformMap<object>.get_isAllowed
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10371A0 Offset: 0x10357A0 VA: 0x1810371A0
	|-HardwareJoystickMapCustomPlatformMap<object>.Matches
	*/

	[IteratorStateMachine(typeof(HardwareJoystickMapCustomPlatformMap.rtnvvRqiutmcTIGoQLWQKSpJHhMC<>))]
	// RVA: -1 Offset: -1 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037080 Offset: 0x1035680 VA: 0x181037080
	|-HardwareJoystickMapCustomPlatformMap<object>.IterateAxes
	*/

	[IteratorStateMachine(typeof(HardwareJoystickMapCustomPlatformMap.AeLugFBxaaMcsbvIGCGKAOMuEISt<>))]
	// RVA: -1 Offset: -1 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037110 Offset: 0x1035710 VA: 0x181037110
	|-HardwareJoystickMapCustomPlatformMap<object>.IterateButtons
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1036D40 Offset: 0x1035340 VA: 0x181036D40
	|-HardwareJoystickMapCustomPlatformMap<object>.IsElementIdentifierMapped
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1036820 Offset: 0x1034E20 VA: 0x181036820
	|-HardwareJoystickMapCustomPlatformMap<object>.GetGameElementIdentifierIdMappings
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035F60 Offset: 0x1034560 VA: 0x181035F60
	|-HardwareJoystickMapCustomPlatformMap<object>.GetAxisCalibrationData
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10362D0 Offset: 0x10348D0 VA: 0x1810362D0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetAxisData
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1036610 Offset: 0x1034C10 VA: 0x181036610
	|-HardwareJoystickMapCustomPlatformMap<object>.GetButtonData
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10367F0 Offset: 0x1034DF0 VA: 0x1810367F0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetEffectiveElementIdentifierType
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10367C0 Offset: 0x1034DC0 VA: 0x1810367C0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetEffectiveAxisRange
	*/

	// RVA: -1 Offset: -1 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035E70 Offset: 0x1034470 VA: 0x181035E70
	|-HardwareJoystickMapCustomPlatformMap<object>.CopyVars
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037340 Offset: 0x1035940 VA: 0x181037340
	|-HardwareJoystickMapCustomPlatformMap<object>..ctor
	*/
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public class HardwareJoystickMapCustomPlatformMapSimpleBase : HardwareJoystickMapCustomPlatformMap<HardwareJoystickMapCustomPlatformMapSimpleBase.MatchingCriteria> // TypeDefIndex: 2288
{
	// Methods

	// RVA: 0x16F89C0 Offset: 0x16F6FC0 VA: 0x1816F89C0 Slot: 28
	protected override object CreateInstance() { }

	// RVA: 0x16F8A30 Offset: 0x16F7030 VA: 0x1816F8A30
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMapCustomPlatformMapSimple : HardwareJoystickMapCustomPlatformMapSimpleBase // TypeDefIndex: 2289
{
	// Fields
	public HardwareJoystickMapCustomPlatformMapSimpleBase[] variants; // 0x38

	// Methods

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x16F8A70 Offset: 0x16F7070 VA: 0x1816F8A70 Slot: 28
	protected override object CreateInstance() { }

	// RVA: 0x16F8A30 Offset: 0x16F7030 VA: 0x1816F8A30
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public abstract class HardwareJoystickMapCustomPlatformMapSO : ScriptableObject // TypeDefIndex: 2290
{
	// Fields
	[Tooltip("The joystick to which this platform map belongs. This must be assigned a HardwareJoystickMap (controller definition).")]
	public HardwareJoystickMap hardwareJoystickMap; // 0x18

	// Methods

	// RVA: 0x16F8900 Offset: 0x16F6F00 VA: 0x1816F8900 Slot: 4
	public virtual bool Matches(Guid hardwareTypeGuid) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract HardwareJoystickMap.Platform GetPlatformMap();

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public class HardwareJoystickMapCustomPlatformMapSimpleSO : HardwareJoystickMapCustomPlatformMapSO // TypeDefIndex: 2291
{
	// Fields
	public HardwareJoystickMapCustomPlatformMapSimple platformMap; // 0x20

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 5
	public override HardwareJoystickMap.Platform GetPlatformMap() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

