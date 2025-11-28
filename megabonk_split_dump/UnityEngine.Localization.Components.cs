// Namespace: UnityEngine.Localization.Components
[AddComponentMenu("Localization/Asset/Localize Audio Clip Event")]
public class LocalizeAudioClipEvent : LocalizedAssetEvent<AudioClip, LocalizedAudioClip, UnityEventAudioClip> // TypeDefIndex: 12015
{
	// Methods

	// RVA: 0x1F08400 Offset: 0x1F06A00 VA: 0x181F08400
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Components
[ExecuteAlways]
public abstract class LocalizedAssetBehaviour<TObject, TReference> : LocalizedMonoBehaviour // TypeDefIndex: 12016
{
	// Fields
	[SerializeField]
	private TReference m_LocalizedAssetReference; // 0x0
	private LocalizedAsset.ChangeHandler<TObject> m_ChangeHandler; // 0x0

	// Properties
	public TReference AssetReference { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public TReference get_AssetReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-LocalizedAssetBehaviour<object, object>.get_AssetReference
	*/

	// RVA: -1 Offset: -1
	public void set_AssetReference(TReference value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C860 Offset: 0x127AE60 VA: 0x18127C860
	|-LocalizedAssetBehaviour<object, object>.set_AssetReference
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A460 Offset: 0x398A60 VA: 0x18039A460
	|-LocalizedAssetBehaviour<object, object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D780 Offset: 0x49BD80 VA: 0x18049D780
	|-LocalizedAssetBehaviour<object, object>.OnDisable
	*/

	// RVA: -1 Offset: -1
	private void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D780 Offset: 0x49BD80 VA: 0x18049D780
	|-LocalizedAssetBehaviour<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	private void OnValidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C5D0 Offset: 0x127ABD0 VA: 0x18127C5D0
	|-LocalizedAssetBehaviour<object, object>.OnValidate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal virtual void RegisterChangeHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C5F0 Offset: 0x127ABF0 VA: 0x18127C5F0
	|-LocalizedAssetBehaviour<object, object>.RegisterChangeHandler
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal virtual void ClearChangeHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C540 Offset: 0x127AB40 VA: 0x18127C540
	|-LocalizedAssetBehaviour<object, object>.ClearChangeHandler
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void UpdateAsset(TObject localizedAsset);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-LocalizedAssetBehaviour<object, object>.UpdateAsset
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C820 Offset: 0x127AE20 VA: 0x18127C820
	|-LocalizedAssetBehaviour<object, object>..ctor
	*/
}

// Namespace: UnityEngine.Localization.Components
public class LocalizedAssetEvent<TObject, TReference, TEvent> : LocalizedAssetBehaviour<TObject, TReference> // TypeDefIndex: 12017
{
	// Fields
	[SerializeField]
	private TEvent m_UpdateAsset; // 0x0

	// Properties
	public TEvent OnUpdateAsset { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public TEvent get_OnUpdateAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-LocalizedAssetEvent<object, object, object>.get_OnUpdateAsset
	*/

	// RVA: -1 Offset: -1
	public void set_OnUpdateAsset(TEvent value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	|-LocalizedAssetEvent<object, object, object>.set_OnUpdateAsset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override void UpdateAsset(TObject localizedAsset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C8C0 Offset: 0x127AEC0 VA: 0x18127C8C0
	|-LocalizedAssetEvent<object, object, object>.UpdateAsset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C8F0 Offset: 0x127AEF0 VA: 0x18127C8F0
	|-LocalizedAssetEvent<object, object, object>..ctor
	*/
}

// Namespace: UnityEngine.Localization.Components
[AddComponentMenu("Localization/Asset/Localize Prefab Event")]
public class LocalizedGameObjectEvent : LocalizedAssetEvent<GameObject, LocalizedGameObject, UnityEventGameObject> // TypeDefIndex: 12018
{
	// Fields
	private GameObject m_Current; // 0x38

	// Methods

	// RVA: 0x1F08B30 Offset: 0x1F07130 VA: 0x181F08B30 Slot: 8
	protected override void UpdateAsset(GameObject localizedAsset) { }

	// RVA: 0x1F08CA0 Offset: 0x1F072A0 VA: 0x181F08CA0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Components
[ExecuteAlways]
public class LocalizedMonoBehaviour : MonoBehaviour // TypeDefIndex: 12019
{
	// Methods

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Components
[AddComponentMenu("Localization/Asset/Localize Sprite Event")]
public class LocalizeSpriteEvent : LocalizedAssetEvent<Sprite, LocalizedSprite, UnityEventSprite> // TypeDefIndex: 12020
{
	// Methods

	// RVA: 0x1F08440 Offset: 0x1F06A40 VA: 0x181F08440
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Components
[AddComponentMenu("Localization/Localize String Event")]
public class LocalizeStringEvent : LocalizedMonoBehaviour // TypeDefIndex: 12021
{
	// Fields
	[SerializeField]
	private LocalizedString m_StringReference; // 0x20
	[SerializeField]
	private List<Object> m_FormatArguments; // 0x28
	[SerializeField]
	private UnityEventString m_UpdateString; // 0x30
	private LocalizedString.ChangeHandler m_ChangeHandler; // 0x38

	// Properties
	public LocalizedString StringReference { get; set; }
	public UnityEventString OnUpdateString { get; set; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public LocalizedString get_StringReference() { }

	// RVA: 0x1F08A60 Offset: 0x1F07060 VA: 0x181F08A60
	public void set_StringReference(LocalizedString value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public UnityEventString get_OnUpdateString() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_OnUpdateString(UnityEventString value) { }

	// RVA: 0x1F084A0 Offset: 0x1F06AA0 VA: 0x181F084A0
	public void RefreshString() { }

	// RVA: 0x1F087E0 Offset: 0x1F06DE0 VA: 0x181F087E0
	public void SetTable(string tableReference) { }

	// RVA: 0x1F086F0 Offset: 0x1F06CF0 VA: 0x181F086F0
	public void SetEntry(string entryName) { }

	// RVA: 0x49D780 Offset: 0x49BD80 VA: 0x18049D780 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0xD13700 Offset: 0xD11D00 VA: 0x180D13700 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0xD13700 Offset: 0xD11D00 VA: 0x180D13700
	private void OnDestroy() { }

	// RVA: 0x1F088F0 Offset: 0x1F06EF0 VA: 0x181F088F0 Slot: 6
	protected virtual void UpdateString(string value) { }

	// RVA: 0x1F084A0 Offset: 0x1F06AA0 VA: 0x181F084A0
	private void OnValidate() { }

	// RVA: 0x1F084C0 Offset: 0x1F06AC0 VA: 0x181F084C0 Slot: 7
	internal virtual void RegisterChangeHandler() { }

	// RVA: 0x1F08480 Offset: 0x1F06A80 VA: 0x181F08480 Slot: 8
	internal virtual void ClearChangeHandler() { }

	// RVA: 0x1F08950 Offset: 0x1F06F50 VA: 0x181F08950
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Components
[AddComponentMenu("Localization/Asset/Localize Texture Event")]
public class LocalizeTextureEvent : LocalizedAssetEvent<Texture, LocalizedTexture, UnityEventTexture> // TypeDefIndex: 12022
{
	// Methods

	// RVA: 0x1F08AC0 Offset: 0x1F070C0 VA: 0x181F08AC0
	public void .ctor() { }
}

