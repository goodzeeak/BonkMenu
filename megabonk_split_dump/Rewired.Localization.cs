// Namespace: Rewired.Localization
[AddComponentMenu("Rewired/Localization/Localized String Provider")]
public class LocalizedStringProvider : LocalizedStringProviderBase // TypeDefIndex: 5227
{
	// Fields
	[SerializeField]
	[Tooltip("A JSON file containing localizied string key value pairs.")]
	private TextAsset _localizedStringsFile; // 0x28
	private Dictionary<string, string> _dictionary; // 0x30
	private bool _initialized; // 0x38

	// Properties
	protected virtual Dictionary<string, string> dictionary { get; set; }
	public virtual TextAsset localizedStringsFile { get; set; }
	protected override bool initialized { get; }

	// Methods

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 15
	protected virtual Dictionary<string, string> get_dictionary() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210 Slot: 16
	protected virtual void set_dictionary(Dictionary<string, string> value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 17
	public virtual TextAsset get_localizedStringsFile() { }

	// RVA: 0x39D640 Offset: 0x39BC40 VA: 0x18039D640 Slot: 18
	public virtual void set_localizedStringsFile(TextAsset value) { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630 Slot: 7
	protected override bool get_initialized() { }

	// RVA: 0x39D3A0 Offset: 0x39B9A0 VA: 0x18039D3A0 Slot: 12
	protected override bool Initialize() { }

	// RVA: 0x39D460 Offset: 0x39BA60 VA: 0x18039D460 Slot: 19
	protected virtual bool TryLoadLocalizedStringData() { }

	// RVA: 0x39D3D0 Offset: 0x39B9D0 VA: 0x18039D3D0 Slot: 14
	protected override bool TryGetLocalizedString(string key, out string result) { }

	// RVA: 0x39D5B0 Offset: 0x39BBB0 VA: 0x18039D5B0
	public void .ctor() { }
}

// Namespace: Rewired.Localization
public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider // TypeDefIndex: 5228
{
	// Fields
	[SerializeField]
	[Tooltip("Determines if localized strings should be fetched immediately in bulk when available. If false, strings will be fetched when queried.")]
	private bool _prefetch; // 0x20

	// Properties
	public virtual bool prefetch { get; set; }
	protected abstract bool initialized { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180 Slot: 5
	public virtual bool get_prefetch() { }

	// RVA: 0x39D260 Offset: 0x39B860 VA: 0x18039D260 Slot: 6
	public virtual void set_prefetch(bool value) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool get_initialized();

	// RVA: 0x39CEA0 Offset: 0x39B4A0 VA: 0x18039CEA0 Slot: 8
	protected virtual void OnEnable() { }

	// RVA: 0x39CD50 Offset: 0x39B350 VA: 0x18039CD50 Slot: 9
	protected virtual void OnDisable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	protected virtual void Update() { }

	// RVA: 0x39D050 Offset: 0x39B650 VA: 0x18039D050 Slot: 11
	protected virtual void TrySetLocalizedStringProvider() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool Initialize();

	// RVA: 0x39CEF0 Offset: 0x39B4F0 VA: 0x18039CEF0 Slot: 13
	public virtual void Reload() { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract bool TryGetLocalizedString(string key, out string result);

	// RVA: 0x39D030 Offset: 0x39B630 VA: 0x18039D030 Slot: 4
	private bool Rewired.Interfaces.ILocalizedStringProvider.TryGetLocalizedString(string key, out string result) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

