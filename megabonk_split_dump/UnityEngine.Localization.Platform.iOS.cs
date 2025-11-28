// Namespace: UnityEngine.Localization.Platform.iOS
[DisplayName("iOS App Info", null)]
[Metadata(AllowedTypes = 256, AllowMultiple = False, MenuItem = "iOS/App Info")]
[Serializable]
public class AppInfo : IMetadata // TypeDefIndex: 11992
{
	// Fields
	[Tooltip("The user-visible name for the bundle, used by Siri and visible on the iOS Home screen.
This name can contain up to 15 characters.
CFBundleName field in xcode projects info.plist file.")]
	[SerializeField]
	private LocalizedString m_ShortName; // 0x10
	[Tooltip("The user-visible name for the bundle, used by Siri and visible on the iOS Home screen.
Use this key if you want a product name that's longer than Bundle Name.
CFBundleDisplayName field in xcode projects info.plist file.")]
	[SerializeField]
	private LocalizedString m_DisplayName; // 0x18
	[Tooltip("A message that tells the user why the app is requesting access to the device’s camera.
NSCameraUsageDescription field in xcode projects info.plist file.")]
	[SerializeField]
	private LocalizedString m_CameraUsageDescription; // 0x20
	[Tooltip("A message that tells the user why the app is requesting access to the device’s microphone.
NSMicrophoneUsageDescription field in xcode projects info.plist file.")]
	[SerializeField]
	private LocalizedString m_MicrophoneUsageDescription; // 0x28
	[Tooltip("A message that tells the user why the app is requesting access to the user’s location information while the app is running in the foreground.
NSLocationWhenInUseUsageDescription field in xcode projects info.plist file.")]
	[SerializeField]
	private LocalizedString m_LocationUsageDescription; // 0x30
	[Tooltip("A message that informs the user why an app is requesting permission to use data for tracking the user or the device.
NSUserTrackingUsageDescription field in xcode projects info.plist file.")]
	[SerializeField]
	private LocalizedString m_UserTrackingUsageDescription; // 0x38

	// Properties
	public LocalizedString ShortName { get; set; }
	public LocalizedString DisplayName { get; set; }
	public LocalizedString CameraUsageDescription { get; set; }
	public LocalizedString MicrophoneUsageDescription { get; set; }
	public LocalizedString LocationUsageDescription { get; set; }
	public LocalizedString UserTrackingUsageDescription { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LocalizedString get_ShortName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_ShortName(LocalizedString value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public LocalizedString get_DisplayName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_DisplayName(LocalizedString value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public LocalizedString get_CameraUsageDescription() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_CameraUsageDescription(LocalizedString value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public LocalizedString get_MicrophoneUsageDescription() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_MicrophoneUsageDescription(LocalizedString value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public LocalizedString get_LocationUsageDescription() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_LocationUsageDescription(LocalizedString value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public LocalizedString get_UserTrackingUsageDescription() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_UserTrackingUsageDescription(LocalizedString value) { }

	// RVA: 0x1F00770 Offset: 0x1EFED70 VA: 0x181F00770
	public void .ctor() { }
}

