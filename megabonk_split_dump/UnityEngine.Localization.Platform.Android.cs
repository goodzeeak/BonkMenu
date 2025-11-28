// Namespace: UnityEngine.Localization.Platform.Android
[DisplayName("Android App Info", "Packages/com.unity.localization/Editor/Icons/Android/Android.png")]
[Metadata(AllowedTypes = 256, AllowMultiple = False, MenuItem = "Android/App Info")]
[Serializable]
public class AppInfo : IMetadata // TypeDefIndex: 11993
{
	// Fields
	[Tooltip("The user-visible name for the bundle, used by Google Assistant and visible on the Android Home screen.
")]
	[SerializeField]
	private LocalizedString m_DisplayName; // 0x10

	// Properties
	public LocalizedString DisplayName { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LocalizedString get_DisplayName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_DisplayName(LocalizedString value) { }

	// RVA: 0x1F008B0 Offset: 0x1EFEEB0 VA: 0x181F008B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Platform.Android
[Serializable]
public class AdaptiveIcon // TypeDefIndex: 11994
{
	// Fields
	[SerializeField]
	private LocalizedTexture m_Background; // 0x10
	[SerializeField]
	private LocalizedTexture m_Foreground; // 0x18

	// Properties
	public LocalizedTexture Background { get; set; }
	public LocalizedTexture Foreground { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LocalizedTexture get_Background() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Background(LocalizedTexture value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public LocalizedTexture get_Foreground() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Foreground(LocalizedTexture value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Platform.Android
[DisplayName("Android Adaptive Icon Info", null)]
[Metadata(AllowedTypes = 256, AllowMultiple = False, MenuItem = "Android/Adaptive Icon")]
[Serializable]
public class AdaptiveIconsInfo : IMetadata // TypeDefIndex: 11995
{
	// Fields
	[SerializeField]
	private AdaptiveIcon m_Adaptive_idpi; // 0x10
	[SerializeField]
	private AdaptiveIcon m_Adaptive_mdpi; // 0x18
	[SerializeField]
	private AdaptiveIcon m_Adaptive_hdpi; // 0x20
	[SerializeField]
	private AdaptiveIcon m_Adaptive_xhdpi; // 0x28
	[SerializeField]
	private AdaptiveIcon m_Adaptive_xxhdpi; // 0x30
	[SerializeField]
	private AdaptiveIcon m_Adaptive_xxxhdpi; // 0x38
	internal List<AdaptiveIcon> AdaptiveIcons; // 0x40

	// Properties
	public AdaptiveIcon AdaptiveHdpi { get; set; }
	public AdaptiveIcon AdaptiveIdpi { get; set; }
	public AdaptiveIcon AdaptiveMdpi { get; set; }
	public AdaptiveIcon AdaptiveXhdpi { get; set; }
	public AdaptiveIcon AdaptiveXXHdpi { get; set; }
	public AdaptiveIcon AdaptiveXXXHdpi { get; set; }

	// Methods

	// RVA: 0x1F00400 Offset: 0x1EFEA00 VA: 0x181F00400
	internal void RefreshAdaptiveIcons() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public AdaptiveIcon get_AdaptiveHdpi() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_AdaptiveHdpi(AdaptiveIcon value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public AdaptiveIcon get_AdaptiveIdpi() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_AdaptiveIdpi(AdaptiveIcon value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public AdaptiveIcon get_AdaptiveMdpi() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_AdaptiveMdpi(AdaptiveIcon value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public AdaptiveIcon get_AdaptiveXhdpi() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_AdaptiveXhdpi(AdaptiveIcon value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public AdaptiveIcon get_AdaptiveXXHdpi() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_AdaptiveXXHdpi(AdaptiveIcon value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public AdaptiveIcon get_AdaptiveXXXHdpi() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_AdaptiveXXXHdpi(AdaptiveIcon value) { }

	// RVA: 0x1F006F0 Offset: 0x1EFECF0 VA: 0x181F006F0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Platform.Android
[DisplayName("Android Round Icon Info", null)]
[Metadata(AllowedTypes = 256, AllowMultiple = False, MenuItem = "Android/Round Icon")]
[Serializable]
public class RoundIconsInfo : IMetadata // TypeDefIndex: 11996
{
	// Fields
	[SerializeField]
	private LocalizedTexture m_Round_idpi; // 0x10
	[SerializeField]
	private LocalizedTexture m_Round_mdpi; // 0x18
	[SerializeField]
	private LocalizedTexture m_Round_hdpi; // 0x20
	[SerializeField]
	private LocalizedTexture m_Round_xhdpi; // 0x28
	[SerializeField]
	private LocalizedTexture m_Round_xxhdpi; // 0x30
	[SerializeField]
	private LocalizedTexture m_Round_xxxhdpi; // 0x38
	internal List<LocalizedTexture> RoundIcons; // 0x40

	// Properties
	public LocalizedTexture RoundHdpi { get; set; }
	public LocalizedTexture RoundIdpi { get; set; }
	public LocalizedTexture RoundMdpi { get; set; }
	public LocalizedTexture RoundXhdpi { get; set; }
	public LocalizedTexture RoundXXHdpi { get; set; }
	public LocalizedTexture RoundXXXHdpi { get; set; }

	// Methods

	// RVA: 0x1F0A770 Offset: 0x1F08D70 VA: 0x181F0A770
	internal void RefreshRoundIcons() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public LocalizedTexture get_RoundHdpi() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_RoundHdpi(LocalizedTexture value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LocalizedTexture get_RoundIdpi() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_RoundIdpi(LocalizedTexture value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public LocalizedTexture get_RoundMdpi() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_RoundMdpi(LocalizedTexture value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public LocalizedTexture get_RoundXhdpi() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_RoundXhdpi(LocalizedTexture value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public LocalizedTexture get_RoundXXHdpi() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_RoundXXHdpi(LocalizedTexture value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public LocalizedTexture get_RoundXXXHdpi() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_RoundXXXHdpi(LocalizedTexture value) { }

	// RVA: 0x1F0AA60 Offset: 0x1F09060 VA: 0x181F0AA60
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Platform.Android
[DisplayName("Android Legacy Icon Info", null)]
[Metadata(AllowedTypes = 256, AllowMultiple = False, MenuItem = "Android/Legacy Icon")]
[Serializable]
public class LegacyIconsInfo : IMetadata // TypeDefIndex: 11997
{
	// Fields
	[SerializeField]
	private LocalizedTexture m_Legacy_idpi; // 0x10
	[SerializeField]
	private LocalizedTexture m_Legacy_mdpi; // 0x18
	[SerializeField]
	private LocalizedTexture m_Legacy_hdpi; // 0x20
	[SerializeField]
	private LocalizedTexture m_Legacy_xhdpi; // 0x28
	[SerializeField]
	private LocalizedTexture m_Legacy_xxhdpi; // 0x30
	[SerializeField]
	private LocalizedTexture m_Legacy_xxxhdpi; // 0x38
	internal List<LocalizedTexture> LegacyIcons; // 0x40

	// Properties
	public LocalizedTexture LegacyHdpi { get; set; }
	public LocalizedTexture LegacyIdpi { get; set; }
	public LocalizedTexture LegacyMdpi { get; set; }
	public LocalizedTexture LegacyXhdpi { get; set; }
	public LocalizedTexture LegacyXXHdpi { get; set; }
	public LocalizedTexture LegacyXXXHdpi { get; set; }

	// Methods

	// RVA: 0x1F07E10 Offset: 0x1F06410 VA: 0x181F07E10
	internal void RefreshLegacyIcons() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public LocalizedTexture get_LegacyHdpi() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_LegacyHdpi(LocalizedTexture value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LocalizedTexture get_LegacyIdpi() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_LegacyIdpi(LocalizedTexture value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public LocalizedTexture get_LegacyMdpi() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_LegacyMdpi(LocalizedTexture value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public LocalizedTexture get_LegacyXhdpi() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_LegacyXhdpi(LocalizedTexture value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public LocalizedTexture get_LegacyXXHdpi() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_LegacyXXHdpi(LocalizedTexture value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public LocalizedTexture get_LegacyXXXHdpi() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_LegacyXXXHdpi(LocalizedTexture value) { }

	// RVA: 0x1F08100 Offset: 0x1F06700 VA: 0x181F08100
	public void .ctor() { }
}

