// Namespace: Rewired.InputSources.SDL2
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class SDL2InputSource : IInputSource, IDisposable // TypeDefIndex: 6462
{
	// Fields
	private const int fsVWjWHwgerIUIGTTSBNEVBlMtis = 32;
	private bool UVgEJiAAzOGyeXvUEPongOTdxZYE; // 0x10
	private bool JyKjnHKcUPkGFMLHcbQRQzcpoRJw; // 0x11
	private bool LOYkYseyJIcaohVszckYihsuPDPI; // 0x12
	private bool UyOcnWKBzKRmTTLLSBUcxOVEyaRk; // 0x13
	private bool JWpCnlGXQuiiglcpUFqGNCcCZFaB; // 0x14
	private ADictionary<int, EDMLXIVQZTAQYUVDbcrQxMhxfKoB> UlaSaxABBLrMgcCwDVhKrJpnszV; // 0x18
	private ADictionary<int, ihGbBntUbqdcAoUSKlRNVQklGFas> wqoUUcmkVmFhDWZXXCmqOaVXLYLs; // 0x20
	private xsGdtKZhJXFPDSHnlpbcrhALFUHz.ghOtUnnOVgZVtCJDZPHwgBBZQNpp dITXHaYsZigHVQTWGyyhjfEphqEjA; // 0x28
	private NativeBuffer ItoHYQvtoFvNMWOTxTDBXlVnaTiu; // 0xB0
	[CompilerGenerated]
	private Action OtRdlyGrejVMMexGaQoTOCoElYhEA; // 0xB8
	private bool mGBhtiCSbWgKEuxAhpPAUwnfNssZ; // 0xC0

	// Properties
	public bool initialized { get; }

	// Methods

	// RVA: 0xC1EE00 Offset: 0xC1D400 VA: 0x180C1EE00
	public bool get_initialized() { }

	// RVA: 0x19ACF30 Offset: 0x19AB530 VA: 0x1819ACF30
	public void .ctor(UpdateLoopSetting , bool , bool , bool , bool ) { }

	[CompilerGenerated]
	// RVA: 0x19ABEF0 Offset: 0x19AA4F0 VA: 0x1819ABEF0
	private void GFIDNSSvTblbUzSCSgjSVGLvGBKE(Action ) { }

	[CompilerGenerated]
	// RVA: 0x19AD7F0 Offset: 0x19ABDF0 VA: 0x1819AD7F0
	private void fQdEvMhhYcBOWXuaoRkmQGCZqrMsA(Action ) { }

	// RVA: 0x19ABEF0 Offset: 0x19AA4F0 VA: 0x1819ABEF0 Slot: 4
	public void add_DeviceChangedEvent(Action value) { }

	// RVA: 0x19AD7F0 Offset: 0x19ABDF0 VA: 0x1819AD7F0 Slot: 5
	public void remove_DeviceChangedEvent(Action value) { }

	// RVA: 0x19AC550 Offset: 0x19AAB50 VA: 0x1819AC550 Slot: 6
	public void SystemDeviceConnected() { }

	// RVA: 0x19AC590 Offset: 0x19AAB90 VA: 0x1819AC590 Slot: 7
	public void SystemDeviceDisconnected() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public void Update() { }

	// RVA: 0x19AC980 Offset: 0x19AAF80 VA: 0x1819AC980 Slot: 9
	public void UpdateDevices(UpdateLoopType updateLoop) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public void UpdateFinished() { }

	// RVA: -1 Offset: -1 Slot: 11
	public IList<T> GetJoysticks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7988D0 Offset: 0x796ED0 VA: 0x1807988D0
	|-SDL2InputSource.GetJoysticks<object>
	*/

	// RVA: 0x19AEC50 Offset: 0x19AD250 VA: 0x1819AEC50
	private int xeBmIMqKCKmbMsdJczpKEVyRrONB() { }

	// RVA: 0x19ACA00 Offset: 0x19AB000 VA: 0x1819ACA00
	private int XpDaoeVZelJdDQqlpNIcayGlcyeC() { }

	// RVA: 0x19ADB80 Offset: 0x19AC180 VA: 0x1819ADB80
	private EDMLXIVQZTAQYUVDbcrQxMhxfKoB pxeJeLETSVemYdvmROtdYOCgrGCV(int ) { }

	// RVA: 0x19ACA70 Offset: 0x19AB070 VA: 0x1819ACA70
	private ihGbBntUbqdcAoUSKlRNVQklGFas ZpzJPSTGsoGODHQifMakZIBJoEBm(int ) { }

	// RVA: 0x19ADDD0 Offset: 0x19AC3D0 VA: 0x1819ADDD0
	private fDbJJcHmDfGbNBOeIdCSAuIdujaMC qVUJsVmzlttSvbBCdppbRblKdEdw(int , JmHvsErHQuhKVTMnRwHHtbIrekxV ) { }

	// RVA: 0x19AC1E0 Offset: 0x19AA7E0 VA: 0x1819AC1E0
	private fDbJJcHmDfGbNBOeIdCSAuIdujaMC JursDvPaAsQTSIXxXHoQvhXgHGAQ(int , SfqSKfhkaqBmtqnOcTSpiYXLhsQc ) { }

	// RVA: 0x19AC990 Offset: 0x19AAF90 VA: 0x1819AC990
	private void XMWitRinKWeeWlSbOuXOLubPxiPj() { }

	// RVA: 0x19AC5D0 Offset: 0x19AABD0 VA: 0x1819AC5D0
	private void UeGIlCJGOQZCSrfvVzuCjDRFboqkA() { }

	// RVA: 0x19AD8F0 Offset: 0x19ABEF0 VA: 0x1819AD8F0
	private bool nWsBzdiDTgOFdJdytWyVIeEvNWXQA(int ) { }

	// RVA: 0x19AC440 Offset: 0x19AAA40 VA: 0x1819AC440
	private void OxNDOAhYSXrsKexQlGogImmqfell(int ) { }

	// RVA: 0x19AC2F0 Offset: 0x19AA8F0 VA: 0x1819AC2F0
	private bool OrXdZlQfQFwPRmfSpQavEwzrgwoj(int ) { }

	// RVA: 0x19ADAC0 Offset: 0x19AC0C0 VA: 0x1819ADAC0
	private void ooVKFsMLpMvtiLlZqfYqVhEtMVeV(int ) { }

	// RVA: 0x19AD770 Offset: 0x19ABD70 VA: 0x1819AD770
	private EDMLXIVQZTAQYUVDbcrQxMhxfKoB eFsfIaACPQtWZqtlfeqnkxSkVnwl(int ) { }

	// RVA: 0x19ADA40 Offset: 0x19AC040 VA: 0x1819ADA40
	private ihGbBntUbqdcAoUSKlRNVQklGFas ncLYiqIhpFqGZZoFZhTxoFbSfpei(int ) { }

	// RVA: 0x19AD360 Offset: 0x19AB960 VA: 0x1819AD360
	private void cDYMpqbTWnWnEXpfEZGaNLYorPjd() { }

	// RVA: 0x19AD320 Offset: 0x19AB920 VA: 0x1819AD320
	private void cANrMyTTFRyDnKlvCSyZmrggtTT(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.IASedDQOgiagncXczGoBLnyhrYYhA , double ) { }

	// RVA: 0x19AC2B0 Offset: 0x19AA8B0 VA: 0x1819AC2B0
	private void KAuSUzYEbkgfQpEzLGAoFCnPKoicA(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.uXLyHtVHPDGALbGFzlkICwazKZMk , double ) { }

	// RVA: 0x19AEC10 Offset: 0x19AD210 VA: 0x1819AEC10
	private void uHNIztQvzHRGspYQbigSFGHNnRzQ(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.nzGyjPBmYBnNeTsGreQIIaXBzTuSA , double ) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void eUnBfTCMgTllDFjcIZDqdzavbMyoA(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.SNwaWHYHtISJnyHPiBxeEOtVzCjiA , double ) { }

	// RVA: 0x19AD8A0 Offset: 0x19ABEA0 VA: 0x1819AD8A0
	private void mTxKXCHcgoTAOSSkREVnfWLOVCxL(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.iMAejbCYbSUdfDHTngMVarlEkRCuB ) { }

	// RVA: 0x19ABE00 Offset: 0x19AA400 VA: 0x1819ABE00
	private void FmcAhMQzkClFJghdLutLpMZpfGVw(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.iMAejbCYbSUdfDHTngMVarlEkRCuB ) { }

	// RVA: 0x19AEBD0 Offset: 0x19AD1D0 VA: 0x1819AEBD0
	private void tSyoZYQHATHrgiHxQHaDuQOfFDDI(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.QjdGbKHiVHuUFZxwzgWytHmIKvln , double ) { }

	// RVA: 0x19ABDC0 Offset: 0x19AA3C0 VA: 0x1819ABDC0
	private void EstZowPptZPqmTkiKdjyOPELmdmg(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.fZGamDuftoNKuylVYsjSBHEwkGED , double ) { }

	// RVA: 0x19AC500 Offset: 0x19AAB00 VA: 0x1819AC500
	private void QMncufPDZrDjAsWwWBDbgksbtBDZ(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.JqEfZzXdeWctlHiBLdQDABCElyyU ) { }

	// RVA: 0x19AEA20 Offset: 0x19AD020 VA: 0x1819AEA20
	private void rYbtDcfXXicVzmMFnWgAwNReawBj(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.JqEfZzXdeWctlHiBLdQDABCElyyU ) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void qfumXpXOOCqbcqwIDoBaJBpUnlQh(ref xsGdtKZhJXFPDSHnlpbcrhALFUHz.JqEfZzXdeWctlHiBLdQDABCElyyU ) { }

	// RVA: 0x19AE960 Offset: 0x19ACF60 VA: 0x1819AE960
	private void qZOwIHiAwNuVzZVZEJbNCxGJDxcU(int , JVAggskIXCHscZhHndFCJHiGmoHQ , byte , short , double ) { }

	// RVA: 0x19AEB10 Offset: 0x19AD110 VA: 0x1819AEB10
	private void roheWNsPaVdFnZxhYCuYmYMmxzPB(int , JVAggskIXCHscZhHndFCJHiGmoHQ , byte , short , double ) { }

	// RVA: 0x19ABFA0 Offset: 0x19AA5A0 VA: 0x1819ABFA0
	private void HsfeOXJvMqUAXhVgDZhOaKMLuTPJ() { }

	// RVA: 0x19ABD60 Offset: 0x19AA360 VA: 0x1819ABD60 Slot: 12
	public void Dispose() { }

	// RVA: 0x1830B90 Offset: 0x182F190 VA: 0x181830B90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19ABBC0 Offset: 0x19AA1C0 VA: 0x1819ABBC0 Slot: 13
	protected virtual void Dispose(bool disposing) { }
}

