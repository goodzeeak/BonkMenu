// Namespace: UnityEngine.Localization
internal class AddressablesInterface // TypeDefIndex: 11758
{
	// Fields
	private static AddressablesInterface s_Instance; // 0x0

	// Properties
	public static AddressablesInterface Instance { get; set; }
	public static ResourceManager ResourceManager { get; }

	// Methods

	// RVA: 0x1EC5670 Offset: 0x1EC3C70 VA: 0x181EC5670
	public static AddressablesInterface get_Instance() { }

	// RVA: 0x1EC5740 Offset: 0x1EC3D40 VA: 0x181EC5740
	public static void set_Instance(AddressablesInterface value) { }

	// RVA: 0x1EC5700 Offset: 0x1EC3D00 VA: 0x181EC5700
	public static ResourceManager get_ResourceManager() { }

	// RVA: 0x1EC4F40 Offset: 0x1EC3540 VA: 0x181EC4F40
	public static void Acquire(AsyncOperationHandle handle) { }

	// RVA: 0x1EC55C0 Offset: 0x1EC3BC0 VA: 0x181EC55C0
	public static void Release(AsyncOperationHandle handle) { }

	// RVA: 0x1EC5610 Offset: 0x1EC3C10 VA: 0x181EC5610
	public static void SafeRelease(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	public static void ReleaseAndReset<TObject>(ref AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DF90 Offset: 0x67C590 VA: 0x18067DF90
	|-AddressablesInterface.ReleaseAndReset<object>
	|
	|-RVA: 0x67DEC0 Offset: 0x67C4C0 VA: 0x18067DEC0
	|-AddressablesInterface.ReleaseAndReset<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EC4F90 Offset: 0x1EC3590 VA: 0x181EC4F90
	public static AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation(List<AsyncOperationHandle> asyncOperations) { }

	// RVA: 0x1EC5340 Offset: 0x1EC3940 VA: 0x181EC5340
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithLabelsAsync(IEnumerable labels, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x1EC54C0 Offset: 0x1EC3AC0 VA: 0x181EC54C0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadTableLocationsAsync(string tableName, LocaleIdentifier id, Type type) { }

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsFromLocations<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DCE0 Offset: 0x67C2E0 VA: 0x18067DCE0
	|-AddressablesInterface.LoadAssetsFromLocations<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetFromGUID<TObject>(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DBA0 Offset: 0x67C1A0 VA: 0x18067DBA0
	|-AddressablesInterface.LoadAssetFromGUID<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetFromName<TObject>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DBA0 Offset: 0x67C1A0 VA: 0x18067DBA0
	|-AddressablesInterface.LoadAssetFromName<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadTableFromLocation<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DBA0 Offset: 0x67C1A0 VA: 0x18067DBA0
	|-AddressablesInterface.LoadTableFromLocation<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsWithLabel<TObject>(string label, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DCE0 Offset: 0x67C2E0 VA: 0x18067DCE0
	|-AddressablesInterface.LoadAssetsWithLabel<object>
	*/

	// RVA: 0x1EC4EC0 Offset: 0x1EC34C0 VA: 0x181EC4EC0 Slot: 4
	internal virtual void AcquireInternal(AsyncOperationHandle handle) { }

	// RVA: 0x1EC5560 Offset: 0x1EC3B60 VA: 0x181EC5560 Slot: 5
	internal virtual void ReleaseInternal(AsyncOperationHandle handle) { }

	// RVA: 0x1EC52B0 Offset: 0x1EC38B0 VA: 0x181EC52B0 Slot: 6
	internal virtual AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithLabelsAsyncInternal(IEnumerable labels, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x1EC53D0 Offset: 0x1EC39D0 VA: 0x181EC53D0 Slot: 7
	internal virtual AsyncOperationHandle<IList<IResourceLocation>> LoadTableLocationsAsyncInternal(string tableName, LocaleIdentifier id, Type type) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal virtual AsyncOperationHandle<IList<TObject>> LoadAssetsFromLocationsInternal<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DC40 Offset: 0x67C240 VA: 0x18067DC40
	|-AddressablesInterface.LoadAssetsFromLocationsInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal virtual AsyncOperationHandle<TObject> LoadAssetFromGUIDInternal<TObject>(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DB10 Offset: 0x67C110 VA: 0x18067DB10
	|-AddressablesInterface.LoadAssetFromGUIDInternal<object>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual AsyncOperationHandle<TObject> LoadAssetFromNameInternal<TObject>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DB10 Offset: 0x67C110 VA: 0x18067DB10
	|-AddressablesInterface.LoadAssetFromNameInternal<object>
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual AsyncOperationHandle<TObject> LoadTableFromLocationInternal<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DE30 Offset: 0x67C430 VA: 0x18067DE30
	|-AddressablesInterface.LoadTableFromLocationInternal<object>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal virtual AsyncOperationHandle<IList<TObject>> LoadAssetsWithLabelInternal<TObject>(string label, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DD90 Offset: 0x67C390 VA: 0x18067DD90
	|-AddressablesInterface.LoadAssetsWithLabelInternal<object>
	*/

	// RVA: 0x1EC5250 Offset: 0x1EC3850 VA: 0x181EC5250 Slot: 13
	internal virtual AsyncOperationHandle<IResourceLocator> InitializeAddressablesAsync() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Usage(32767, AllowMultiple = False)]
public class DisplayNameAttribute : Attribute // TypeDefIndex: 11759
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <IconPath>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string IconPath { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_IconPath() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_IconPath(string value) { }

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string name, string iconPath) { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public struct LocaleIdentifier : IEquatable<LocaleIdentifier>, IComparable<LocaleIdentifier> // TypeDefIndex: 11760
{
	// Fields
	[SerializeField]
	private string m_Code; // 0x0
	private CultureInfo m_CultureInfo; // 0x8

	// Properties
	public string Code { get; }
	public CultureInfo CultureInfo { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public string get_Code() { }

	// RVA: 0x1EC9740 Offset: 0x1EC7D40 VA: 0x181EC9740
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x1EC9670 Offset: 0x1EC7C70 VA: 0x181EC9670
	public void .ctor(string code) { }

	// RVA: 0x1EC96A0 Offset: 0x1EC7CA0 VA: 0x181EC96A0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x1EC9630 Offset: 0x1EC7C30 VA: 0x181EC9630
	public void .ctor(SystemLanguage systemLanguage) { }

	// RVA: 0x1EC9880 Offset: 0x1EC7E80 VA: 0x181EC9880
	public static LocaleIdentifier op_Implicit(string code) { }

	// RVA: 0x1EC98C0 Offset: 0x1EC7EC0 VA: 0x181EC98C0
	public static LocaleIdentifier op_Implicit(CultureInfo culture) { }

	// RVA: 0x1EC9830 Offset: 0x1EC7E30 VA: 0x181EC9830
	public static LocaleIdentifier op_Implicit(SystemLanguage systemLanguage) { }

	// RVA: 0x1EC9560 Offset: 0x1EC7B60 VA: 0x181EC9560 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EC93B0 Offset: 0x1EC79B0 VA: 0x181EC93B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EC9470 Offset: 0x1EC7A70 VA: 0x181EC9470 Slot: 4
	public bool Equals(LocaleIdentifier other) { }

	// RVA: 0x1EC94D0 Offset: 0x1EC7AD0 VA: 0x181EC94D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EC9300 Offset: 0x1EC7900 VA: 0x181EC9300 Slot: 5
	public int CompareTo(LocaleIdentifier other) { }

	// RVA: 0x1EC97D0 Offset: 0x1EC7DD0 VA: 0x181EC97D0
	public static bool op_Equality(LocaleIdentifier l1, LocaleIdentifier l2) { }

	// RVA: 0x1EC9970 Offset: 0x1EC7F70 VA: 0x181EC9970
	public static bool op_Inequality(LocaleIdentifier l1, LocaleIdentifier l2) { }
}

// Namespace: UnityEngine.Localization
public class Locale : ScriptableObject, IEquatable<Locale>, IComparable<Locale>, ISerializationCallbackReceiver // TypeDefIndex: 11762
{
	// Fields
	[SerializeField]
	private LocaleIdentifier m_Identifier; // 0x18
	[SerializeField]
	[MetadataType(1)]
	private MetadataCollection m_Metadata; // 0x28
	[SerializeField]
	private string m_LocaleName; // 0x30
	[SerializeField]
	private string m_CustomFormatCultureCode; // 0x38
	[SerializeField]
	private bool m_UseCustomFormatter; // 0x40
	[SerializeField]
	private ushort m_SortOrder; // 0x42
	private IFormatProvider m_Formatter; // 0x48

	// Properties
	public LocaleIdentifier Identifier { get; set; }
	public MetadataCollection Metadata { get; set; }
	public ushort SortOrder { get; set; }
	public string LocaleName { get; set; }
	public bool UseCustomFormatter { get; set; }
	public string CustomFormatterCode { get; set; }
	public virtual IFormatProvider Formatter { get; set; }

	// Methods

	// RVA: 0x8641A0 Offset: 0x8627A0 VA: 0x1808641A0
	public LocaleIdentifier get_Identifier() { }

	// RVA: 0x1ECA5B0 Offset: 0x1EC8BB0 VA: 0x181ECA5B0
	public void set_Identifier(LocaleIdentifier value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public MetadataCollection get_Metadata() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Metadata(MetadataCollection value) { }

	// RVA: 0x1ECA570 Offset: 0x1EC8B70 VA: 0x181ECA570
	public ushort get_SortOrder() { }

	// RVA: 0x1ECA5D0 Offset: 0x1EC8BD0 VA: 0x181ECA5D0
	public void set_SortOrder(ushort value) { }

	// RVA: 0x1ECA4E0 Offset: 0x1EC8AE0 VA: 0x181ECA4E0
	public string get_LocaleName() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_LocaleName(string value) { }

	[Obsolete("GetFallback is obsolete, please use GetFallbacks.")]
	// RVA: 0x1ECA050 Offset: 0x1EC8650 VA: 0x181ECA050 Slot: 8
	public virtual Locale GetFallback() { }

	[IteratorStateMachine(typeof(Locale.<GetFallbacks>d__20))]
	// RVA: 0x1ECA170 Offset: 0x1EC8770 VA: 0x181ECA170
	public IEnumerable<Locale> GetFallbacks() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_UseCustomFormatter() { }

	// RVA: 0x1ECA5E0 Offset: 0x1EC8BE0 VA: 0x181ECA5E0
	public void set_UseCustomFormatter(bool value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_CustomFormatterCode() { }

	// RVA: 0x1ECA580 Offset: 0x1EC8B80 VA: 0x181ECA580
	public void set_CustomFormatterCode(string value) { }

	// RVA: 0x1ECA3D0 Offset: 0x1EC89D0 VA: 0x181ECA3D0 Slot: 9
	public virtual IFormatProvider get_Formatter() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 10
	public virtual void set_Formatter(IFormatProvider value) { }

	// RVA: 0x1ECA1F0 Offset: 0x1EC87F0 VA: 0x181ECA1F0
	internal static CultureInfo GetFormatter(bool useCustom, LocaleIdentifier localeIdentifier, string customCode) { }

	// RVA: 0x1EC9B70 Offset: 0x1EC8170 VA: 0x181EC9B70
	public static Locale CreateLocale(string code) { }

	// RVA: 0x1EC9D30 Offset: 0x1EC8330 VA: 0x181EC9D30
	public static Locale CreateLocale(LocaleIdentifier identifier) { }

	// RVA: 0x1EC9C50 Offset: 0x1EC8250 VA: 0x181EC9C50
	public static Locale CreateLocale(SystemLanguage language) { }

	// RVA: 0x1EC9DE0 Offset: 0x1EC83E0 VA: 0x181EC9DE0
	public static Locale CreateLocale(CultureInfo cultureInfo) { }

	// RVA: 0x1EC99D0 Offset: 0x1EC7FD0 VA: 0x181EC99D0 Slot: 5
	public int CompareTo(Locale other) { }

	// RVA: 0x1ECA2C0 Offset: 0x1EC88C0 VA: 0x181ECA2C0 Slot: 7
	public void OnAfterDeserialize() { }

	// RVA: 0x1ECA2E0 Offset: 0x1EC88E0 VA: 0x181ECA2E0 Slot: 6
	public void OnBeforeSerialize() { }

	// RVA: 0x1ECA320 Offset: 0x1EC8920 VA: 0x181ECA320 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EC9F30 Offset: 0x1EC8530 VA: 0x181EC9F30 Slot: 4
	public bool Equals(Locale other) { }

	// RVA: 0x1ECA360 Offset: 0x1EC8960 VA: 0x181ECA360
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedAudioClip : LocalizedAsset<AudioClip> // TypeDefIndex: 11763
{
	// Methods

	// RVA: 0x1ECB190 Offset: 0x1EC9790 VA: 0x181ECB190
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedGameObject : LocalizedAsset<GameObject> // TypeDefIndex: 11764
{
	// Methods

	// RVA: 0x1ECB210 Offset: 0x1EC9810 VA: 0x181ECB210
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedMesh : LocalizedAsset<Mesh> // TypeDefIndex: 11765
{
	// Methods

	// RVA: 0x1ECB290 Offset: 0x1EC9890 VA: 0x181ECB290
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedMaterial : LocalizedAsset<Material> // TypeDefIndex: 11766
{
	// Methods

	// RVA: 0x1ECB250 Offset: 0x1EC9850 VA: 0x181ECB250
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedObject : LocalizedAsset<Object> // TypeDefIndex: 11767
{
	// Methods

	// RVA: 0x1ECB2D0 Offset: 0x1EC98D0 VA: 0x181ECB2D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedSprite : LocalizedAsset<Sprite> // TypeDefIndex: 11768
{
	// Methods

	// RVA: 0x1ECB7A0 Offset: 0x1EC9DA0 VA: 0x181ECB7A0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedTexture : LocalizedAsset<Texture> // TypeDefIndex: 11769
{
	// Methods

	// RVA: 0x1ECEB70 Offset: 0x1ECD170 VA: 0x181ECEB70
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedTmpFont : LocalizedAsset<TMP_FontAsset> // TypeDefIndex: 11770
{
	// Methods

	// RVA: 0x1ECEBB0 Offset: 0x1ECD1B0 VA: 0x181ECEBB0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedFont : LocalizedAsset<Font> // TypeDefIndex: 11771
{
	// Methods

	// RVA: 0x1ECB1D0 Offset: 0x1EC97D0 VA: 0x181ECB1D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
public abstract class LocalizedAssetBase : LocalizedReference // TypeDefIndex: 11772
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract AsyncOperationHandle<Object> LoadAssetAsObjectAsync();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract AsyncOperationHandle<TObject> LoadAssetAsync<TObject>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-LocalizedAssetBase.LoadAssetAsync<object>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedAsset<TObject> : LocalizedAssetBase, IDisposable // TypeDefIndex: 11775
{
	// Fields
	private CallbackArray<LocalizedAsset.ChangeHandler<TObject>> m_ChangeHandler; // 0x0
	private Action<Locale> m_SelectedLocaleChanged; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_AutomaticLoadingCompleted; // 0x0
	private AsyncOperationHandle<TObject> m_PreviousLoadingOperation; // 0x0
	[CompilerGenerated]
	private AsyncOperationHandle<TObject> <CurrentLoadingOperationHandle>k__BackingField; // 0x0

	// Properties
	public override bool WaitForCompletion { set; }
	public AsyncOperationHandle<TObject> CurrentLoadingOperationHandle { get; set; }
	public bool HasChangeHandler { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public override void set_WaitForCompletion(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D8C0 Offset: 0x127BEC0 VA: 0x18127D8C0
	|-LocalizedAsset<object>.set_WaitForCompletion
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> get_CurrentLoadingOperationHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC98010 Offset: 0xC96610 VA: 0x180C98010
	|-LocalizedAsset<object>.get_CurrentLoadingOperationHandle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_CurrentLoadingOperationHandle(AsyncOperationHandle<TObject> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D890 Offset: 0x127BE90 VA: 0x18127D890
	|-LocalizedAsset<object>.set_CurrentLoadingOperationHandle
	*/

	// RVA: -1 Offset: -1
	public void add_AssetChanged(LocalizedAsset.ChangeHandler<TObject> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D670 Offset: 0x127BC70 VA: 0x18127D670
	|-LocalizedAsset<object>.add_AssetChanged
	*/

	// RVA: -1 Offset: -1
	public void remove_AssetChanged(LocalizedAsset.ChangeHandler<TObject> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D820 Offset: 0x127BE20 VA: 0x18127D820
	|-LocalizedAsset<object>.remove_AssetChanged
	*/

	// RVA: -1 Offset: -1
	public bool get_HasChangeHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D810 Offset: 0x127BE10 VA: 0x18127D810
	|-LocalizedAsset<object>.get_HasChangeHandler
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D570 Offset: 0x127BB70 VA: 0x18127D570
	|-LocalizedAsset<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D2F0 Offset: 0x127B8F0 VA: 0x18127D2F0
	|-LocalizedAsset<object>.LoadAssetAsync
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override AsyncOperationHandle<T> LoadAssetAsync<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x605020 Offset: 0x603620 VA: 0x180605020
	|-LocalizedAsset<object>.LoadAssetAsync<object>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override AsyncOperationHandle<Object> LoadAssetAsObjectAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D160 Offset: 0x127B760 VA: 0x18127D160
	|-LocalizedAsset<object>.LoadAssetAsObjectAsync
	*/

	// RVA: -1 Offset: -1
	public TObject LoadAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D360 Offset: 0x127B960 VA: 0x18127D360
	|-LocalizedAsset<object>.LoadAsset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected internal override void ForceUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CD00 Offset: 0x127B300 VA: 0x18127CD00
	|-LocalizedAsset<object>.ForceUpdate
	*/

	// RVA: -1 Offset: -1
	private void HandleLocaleChange(Locale _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CD20 Offset: 0x127B320 VA: 0x18127CD20
	|-LocalizedAsset<object>.HandleLocaleChange
	*/

	// RVA: -1 Offset: -1
	private void AutomaticLoadingCompleted(AsyncOperationHandle<TObject> loadOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C970 Offset: 0x127AF70 VA: 0x18127C970
	|-LocalizedAsset<object>.AutomaticLoadingCompleted
	*/

	// RVA: -1 Offset: -1
	private void InvokeChangeHandler(TObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D020 Offset: 0x127B620 VA: 0x18127D020
	|-LocalizedAsset<object>.InvokeChangeHandler
	*/

	// RVA: -1 Offset: -1
	internal void ClearLoadingOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CB60 Offset: 0x127B160 VA: 0x18127CB60
	|-LocalizedAsset<object>.ClearLoadingOperation
	*/

	// RVA: -1 Offset: -1
	private void ClearPreviousLoadingOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CBD0 Offset: 0x127B1D0 VA: 0x18127CBD0
	|-LocalizedAsset<object>.ClearPreviousLoadingOperation
	*/

	// RVA: -1 Offset: -1
	private void ClearLoadingOperation(AsyncOperationHandle<TObject> operationHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CA80 Offset: 0x127B080 VA: 0x18127CA80
	|-LocalizedAsset<object>.ClearLoadingOperation
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D400 Offset: 0x127BA00 VA: 0x18127D400
	|-LocalizedAsset<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CC30 Offset: 0x127B230 VA: 0x18127CC30
	|-LocalizedAsset<object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D480 Offset: 0x127BA80 VA: 0x18127D480
	|-LocalizedAsset<object>.System.IDisposable.Dispose
	*/
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedAssetTable : LocalizedTable<AssetTable, AssetTableEntry> // TypeDefIndex: 11776
{
	// Properties
	protected override LocalizedDatabase<AssetTable, AssetTableEntry> Database { get; }

	// Methods

	// RVA: 0x1ECB180 Offset: 0x1EC9780 VA: 0x181ECB180 Slot: 4
	protected override LocalizedDatabase<AssetTable, AssetTableEntry> get_Database() { }

	// RVA: 0x1ECB140 Offset: 0x1EC9740 VA: 0x181ECB140
	public void .ctor() { }

	// RVA: 0x1ECB0C0 Offset: 0x1EC96C0 VA: 0x181ECB0C0
	public void .ctor(TableReference tableReference) { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public abstract class LocalizedReference : ISerializationCallbackReceiver // TypeDefIndex: 11777
{
	// Fields
	[SerializeField]
	private TableReference m_TableReference; // 0x10
	[SerializeField]
	private TableEntryReference m_TableEntryReference; // 0x30
	[SerializeField]
	private FallbackBehavior m_FallbackState; // 0x48
	[SerializeField]
	private bool m_WaitForCompletion; // 0x4C
	private Locale m_LocaleOverride; // 0x50

	// Properties
	public TableReference TableReference { get; set; }
	public TableEntryReference TableEntryReference { get; set; }
	public FallbackBehavior FallbackState { get; set; }
	public Locale LocaleOverride { get; set; }
	public virtual bool WaitForCompletion { get; set; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xC175B0 Offset: 0xC15BB0 VA: 0x180C175B0
	public TableReference get_TableReference() { }

	// RVA: 0x1ECB6E0 Offset: 0x1EC9CE0 VA: 0x181ECB6E0
	public void set_TableReference(TableReference value) { }

	// RVA: 0x1ECB590 Offset: 0x1EC9B90 VA: 0x181ECB590
	public TableEntryReference get_TableEntryReference() { }

	// RVA: 0x1ECB640 Offset: 0x1EC9C40 VA: 0x181ECB640
	public void set_TableEntryReference(TableEntryReference value) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public FallbackBehavior get_FallbackState() { }

	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	public void set_FallbackState(FallbackBehavior value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public Locale get_LocaleOverride() { }

	// RVA: 0x1ECB5B0 Offset: 0x1EC9BB0 VA: 0x181ECB5B0
	public void set_LocaleOverride(Locale value) { }

	// RVA: 0x16EE360 Offset: 0x16EC960 VA: 0x1816EE360 Slot: 6
	public virtual bool get_WaitForCompletion() { }

	// RVA: 0x16EE370 Offset: 0x16EC970 VA: 0x1816EE370 Slot: 7
	public virtual void set_WaitForCompletion(bool value) { }

	// RVA: 0x1ECB510 Offset: 0x1EC9B10 VA: 0x181ECB510
	public bool get_IsEmpty() { }

	// RVA: 0x1ECB310 Offset: 0x1EC9910 VA: 0x181ECB310
	public void SetReference(TableReference table, TableEntryReference entry) { }

	// RVA: 0x1ECB450 Offset: 0x1EC9A50 VA: 0x181ECB450 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected internal abstract void ForceUpdate();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Reset();

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization
[DefaultMember("Item")]
[Serializable]
public class LocalizedString : LocalizedReference, IVariableGroup, IDictionary<string, IVariable>, ICollection<KeyValuePair<string, IVariable>>, IEnumerable<KeyValuePair<string, IVariable>>, IEnumerable, IVariableValueChanged, IVariable, IDisposable // TypeDefIndex: 11785
{
	// Fields
	[SerializeField]
	private List<VariableNameValuePair> m_LocalVariables; // 0x58
	private CallbackArray<LocalizedString.ChangeHandler> m_ChangeHandler; // 0x60
	private string m_CurrentStringChangedValue; // 0x88
	private readonly Dictionary<string, VariableNameValuePair> m_VariableLookup; // 0x90
	private readonly List<IVariableValueChanged> m_UsedVariables; // 0x98
	private Action<IVariable> m_OnVariableChanged; // 0xA0
	private Action<Locale> m_SelectedLocaleChanged; // 0xA8
	private Action<AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>>> m_AutomaticLoadingCompleted; // 0xB0
	private Action<AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>>> m_CompletedSourceValue; // 0xB8
	private bool m_WaitingForVariablesEndUpdate; // 0xC0
	[CompilerGenerated]
	private Action<IVariable> ValueChanged; // 0xC8
	[CompilerGenerated]
	private IList<object> <Arguments>k__BackingField; // 0xD0
	[CompilerGenerated]
	private AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> <CurrentLoadingOperationHandle>k__BackingField; // 0xD8

	// Properties
	public IList<object> Arguments { get; set; }
	public AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> CurrentLoadingOperationHandle { get; set; }
	public bool HasChangeHandler { get; }
	public int Count { get; }
	public ICollection<string> Keys { get; }
	public ICollection<IVariable> Values { get; }
	public bool IsReadOnly { get; }
	public IVariable Item { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ECE660 Offset: 0x1ECCC60 VA: 0x181ECE660 Slot: 30
	public void add_ValueChanged(Action<IVariable> value) { }

	[CompilerGenerated]
	// RVA: 0x1ECEA70 Offset: 0x1ECD070 VA: 0x181ECEA70 Slot: 31
	public void remove_ValueChanged(Action<IVariable> value) { }

	[CompilerGenerated]
	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public IList<object> get_Arguments() { }

	[CompilerGenerated]
	// RVA: 0x510990 Offset: 0x50EF90 VA: 0x180510990
	public void set_Arguments(IList<object> value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE770 Offset: 0x1ECCD70 VA: 0x181ECE770
	public AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> get_CurrentLoadingOperationHandle() { }

	[CompilerGenerated]
	// RVA: 0x1ECEB30 Offset: 0x1ECD130 VA: 0x181ECEB30
	internal void set_CurrentLoadingOperationHandle(AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> value) { }

	// RVA: 0x1ECE4E0 Offset: 0x1ECCAE0 VA: 0x181ECE4E0
	public void add_StringChanged(LocalizedString.ChangeHandler value) { }

	// RVA: 0x1ECE9F0 Offset: 0x1ECCFF0 VA: 0x181ECE9F0
	public void remove_StringChanged(LocalizedString.ChangeHandler value) { }

	// RVA: 0x1ECE790 Offset: 0x1ECCD90 VA: 0x181ECE790
	public bool get_HasChangeHandler() { }

	// RVA: 0x1ECE100 Offset: 0x1ECC700 VA: 0x181ECE100
	public void .ctor() { }

	// RVA: 0x1ECE350 Offset: 0x1ECC950 VA: 0x181ECE350
	public void .ctor(TableReference tableReference, TableEntryReference entryReference) { }

	// RVA: 0x1ECD670 Offset: 0x1ECBC70 VA: 0x181ECD670
	public bool RefreshString() { }

	// RVA: 0x1ECC370 Offset: 0x1ECA970 VA: 0x181ECC370
	public AsyncOperationHandle<string> GetLocalizedStringAsync() { }

	// RVA: 0x1ECC500 Offset: 0x1ECAB00 VA: 0x181ECC500
	public string GetLocalizedString() { }

	// RVA: 0x1ECC4D0 Offset: 0x1ECAAD0 VA: 0x181ECC4D0
	public AsyncOperationHandle<string> GetLocalizedStringAsync(object[] arguments) { }

	// RVA: 0x1ECC600 Offset: 0x1ECAC00 VA: 0x181ECC600
	public string GetLocalizedString(object[] arguments) { }

	// RVA: 0x1ECC580 Offset: 0x1ECAB80 VA: 0x181ECC580
	public string GetLocalizedString(IList<object> arguments) { }

	// RVA: 0x1ECC3B0 Offset: 0x1ECA9B0 VA: 0x181ECC3B0
	public AsyncOperationHandle<string> GetLocalizedStringAsync(IList<object> arguments) { }

	// RVA: 0x1ECE720 Offset: 0x1ECCD20 VA: 0x181ECE720 Slot: 21
	public int get_Count() { }

	// RVA: 0x1ECE840 Offset: 0x1ECCE40 VA: 0x181ECE840 Slot: 15
	public ICollection<string> get_Keys() { }

	// RVA: 0x1ECE890 Offset: 0x1ECCE90 VA: 0x181ECE890 Slot: 16
	public ICollection<IVariable> get_Values() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 22
	public bool get_IsReadOnly() { }

	// RVA: 0x1ECE7D0 Offset: 0x1ECCDD0 VA: 0x181ECE7D0 Slot: 13
	public IVariable get_Item(string name) { }

	// RVA: 0x1ECEB60 Offset: 0x1ECD160 VA: 0x181ECEB60 Slot: 14
	public void set_Item(string name, IVariable value) { }

	// RVA: 0x1ECDC80 Offset: 0x1ECC280 VA: 0x181ECDC80 Slot: 20
	public bool TryGetValue(string name, out IVariable value) { }

	// RVA: 0x1ECB8B0 Offset: 0x1EC9EB0 VA: 0x181ECB8B0 Slot: 18
	public void Add(string name, IVariable variable) { }

	// RVA: 0x1ECBBC0 Offset: 0x1ECA1C0 VA: 0x181ECBBC0 Slot: 23
	public void Add(KeyValuePair<string, IVariable> item) { }

	// RVA: 0x1ECDAB0 Offset: 0x1ECC0B0 VA: 0x181ECDAB0 Slot: 19
	public bool Remove(string name) { }

	// RVA: 0x1ECD9C0 Offset: 0x1ECBFC0 VA: 0x181ECD9C0 Slot: 27
	public bool Remove(KeyValuePair<string, IVariable> item) { }

	// RVA: 0x1ECBED0 Offset: 0x1ECA4D0 VA: 0x181ECBED0 Slot: 17
	public bool ContainsKey(string name) { }

	// RVA: 0x1ECBF30 Offset: 0x1ECA530 VA: 0x181ECBF30 Slot: 25
	public bool Contains(KeyValuePair<string, IVariable> item) { }

	// RVA: 0x1ECC010 Offset: 0x1ECA610 VA: 0x181ECC010 Slot: 26
	public void CopyTo(KeyValuePair<string, IVariable>[] array, int arrayIndex) { }

	[IteratorStateMachine(typeof(LocalizedString.<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__56))]
	// RVA: 0x1ECDB90 Offset: 0x1ECC190 VA: 0x181ECDB90 Slot: 28
	private IEnumerator<KeyValuePair<string, IVariable>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.IVariable>>.GetEnumerator() { }

	[IteratorStateMachine(typeof(LocalizedString.<GetEnumerator>d__57))]
	// RVA: 0x1ECC300 Offset: 0x1ECA900 VA: 0x181ECC300 Slot: 29
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1ECBE20 Offset: 0x1ECA420 VA: 0x181ECBE20 Slot: 24
	public void Clear() { }

	// RVA: 0x1ECC680 Offset: 0x1ECAC80 VA: 0x181ECC680 Slot: 32
	public object GetSourceValue(ISelectorInfo selector) { }

	// RVA: 0x1ECBEB0 Offset: 0x1ECA4B0 VA: 0x181ECBEB0
	private void CompletedSourceValue(AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> _) { }

	// RVA: 0x1ECC290 Offset: 0x1ECA890 VA: 0x181ECC290 Slot: 8
	protected internal override void ForceUpdate() { }

	// RVA: 0x1ECDD40 Offset: 0x1ECC340 VA: 0x181ECDD40
	private void UpdateVariableListeners(List<IVariableValueChanged> variables) { }

	// RVA: 0x1ECD510 Offset: 0x1ECBB10 VA: 0x181ECD510
	private void OnVariableChanged(IVariable globalVariable) { }

	// RVA: 0x1ECD5D0 Offset: 0x1ECBBD0 VA: 0x181ECD5D0
	private void OnVariablesSourceUpdateCompleted() { }

	// RVA: 0x1ECD220 Offset: 0x1ECB820 VA: 0x181ECD220
	private void InvokeChangeHandler(string value) { }

	// RVA: 0x1ECCF60 Offset: 0x1ECB560 VA: 0x181ECCF60
	private void HandleLocaleChange(Locale _) { }

	// RVA: 0x1ECBC20 Offset: 0x1ECA220 VA: 0x181ECBC20
	private void AutomaticLoadingCompleted(AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> loadOperation) { }

	// RVA: 0x1ECBCA0 Offset: 0x1ECA2A0 VA: 0x181ECBCA0
	private void ClearLoadingOperation() { }

	// RVA: 0x1ECDB80 Offset: 0x1ECC180 VA: 0x181ECDB80 Slot: 9
	protected override void Reset() { }

	// RVA: 0x1ECD390 Offset: 0x1ECB990 VA: 0x181ECD390 Slot: 11
	public override void OnAfterDeserialize() { }

	// RVA: 0x1ECC230 Offset: 0x1ECA830 VA: 0x181ECC230 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1ECDC00 Offset: 0x1ECC200 VA: 0x181ECDC00 Slot: 33
	private void System.IDisposable.Dispose() { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public class LocalizedStringTable : LocalizedTable<StringTable, StringTableEntry> // TypeDefIndex: 11786
{
	// Properties
	protected override LocalizedDatabase<StringTable, StringTableEntry> Database { get; }

	// Methods

	// RVA: 0x1ECB8A0 Offset: 0x1EC9EA0 VA: 0x181ECB8A0 Slot: 4
	protected override LocalizedDatabase<StringTable, StringTableEntry> get_Database() { }

	// RVA: 0x1ECB860 Offset: 0x1EC9E60 VA: 0x181ECB860
	public void .ctor() { }

	// RVA: 0x1ECB7E0 Offset: 0x1EC9DE0 VA: 0x181ECB7E0
	public void .ctor(TableReference tableReference) { }
}

// Namespace: UnityEngine.Localization
[Serializable]
public abstract class LocalizedTable<TTable, TEntry> // TypeDefIndex: 11788
{
	// Fields
	[SerializeField]
	private TableReference m_TableReference; // 0x0
	private CallbackArray<LocalizedTable.ChangeHandler<TTable, TEntry>> m_ChangeHandler; // 0x0
	private Action<Locale> m_SelectedLocaleChanged; // 0x0
	[CompilerGenerated]
	private AsyncOperationHandle<TTable> <CurrentLoadingOperationHandle>k__BackingField; // 0x0

	// Properties
	protected abstract LocalizedDatabase<TTable, TEntry> Database { get; }
	public AsyncOperationHandle<TTable> CurrentLoadingOperationHandle { get; set; }
	public TableReference TableReference { get; set; }
	public bool IsEmpty { get; }
	[Obsolete("CurrentLoadingOperation is deprecated, use CurrentLoadingOperationHandle instead.")]
	public Nullable<AsyncOperationHandle<TTable>> CurrentLoadingOperation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract LocalizedDatabase<TTable, TEntry> get_Database();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-LocalizedTable<object, object>.get_Database
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TTable> get_CurrentLoadingOperationHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281F90 Offset: 0x1280590 VA: 0x181281F90
	|-LocalizedTable<object, object>.get_CurrentLoadingOperationHandle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_CurrentLoadingOperationHandle(AsyncOperationHandle<TTable> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1282130 Offset: 0x1280730 VA: 0x181282130
	|-LocalizedTable<object, object>.set_CurrentLoadingOperationHandle
	*/

	// RVA: -1 Offset: -1
	public TableReference get_TableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC175B0 Offset: 0xC15BB0 VA: 0x180C175B0
	|-LocalizedTable<object, object>.get_TableReference
	*/

	// RVA: -1 Offset: -1
	public void set_TableReference(TableReference value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1282150 Offset: 0x1280750 VA: 0x181282150
	|-LocalizedTable<object, object>.set_TableReference
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1282060 Offset: 0x1280660 VA: 0x181282060
	|-LocalizedTable<object, object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public void add_TableChanged(LocalizedTable.ChangeHandler<TTable, TEntry> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281DE0 Offset: 0x12803E0 VA: 0x181281DE0
	|-LocalizedTable<object, object>.add_TableChanged
	*/

	// RVA: -1 Offset: -1
	public void remove_TableChanged(LocalizedTable.ChangeHandler<TTable, TEntry> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12820C0 Offset: 0x12806C0 VA: 0x1812820C0
	|-LocalizedTable<object, object>.remove_TableChanged
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281D50 Offset: 0x1280350 VA: 0x181281D50
	|-LocalizedTable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TTable> GetTableAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12817D0 Offset: 0x127FDD0 VA: 0x1812817D0
	|-LocalizedTable<object, object>.GetTableAsync
	*/

	// RVA: -1 Offset: -1
	public TTable GetTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281860 Offset: 0x127FE60 VA: 0x181281860
	|-LocalizedTable<object, object>.GetTable
	*/

	// RVA: -1 Offset: -1
	protected void ForceUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12817B0 Offset: 0x127FDB0 VA: 0x1812817B0
	|-LocalizedTable<object, object>.ForceUpdate
	*/

	// RVA: -1 Offset: -1
	private void InvokeChangeHandler(TTable value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281B90 Offset: 0x1280190 VA: 0x181281B90
	|-LocalizedTable<object, object>.InvokeChangeHandler
	*/

	// RVA: -1 Offset: -1
	private void HandleLocaleChange(Locale _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281920 Offset: 0x127FF20 VA: 0x181281920
	|-LocalizedTable<object, object>.HandleLocaleChange
	*/

	// RVA: -1 Offset: -1
	private void AutomaticLoadingCompleted(AsyncOperationHandle<TTable> loadOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12815D0 Offset: 0x127FBD0 VA: 0x1812815D0
	|-LocalizedTable<object, object>.AutomaticLoadingCompleted
	*/

	// RVA: -1 Offset: -1
	private void ClearLoadingOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281680 Offset: 0x127FC80 VA: 0x181281680
	|-LocalizedTable<object, object>.ClearLoadingOperation
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281CD0 Offset: 0x12802D0 VA: 0x181281CD0
	|-LocalizedTable<object, object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Nullable<AsyncOperationHandle<TTable>> get_CurrentLoadingOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281FB0 Offset: 0x12805B0 VA: 0x181281FB0
	|-LocalizedTable<object, object>.get_CurrentLoadingOperation
	*/
}

// Namespace: UnityEngine.Localization
public interface IPreloadRequired // TypeDefIndex: 11789
{
	// Properties
	public abstract AsyncOperationHandle PreloadOperation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle get_PreloadOperation();
}

// Namespace: UnityEngine.Localization
public static class EditorPropertyDriver // TypeDefIndex: 11790
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void RegisterProperty(Object target, string propertyPath) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void UnregisterProperty(Object target, string propertyPath) { }
}

// Namespace: UnityEngine.Localization
internal class AddressHelper // TypeDefIndex: 11791
{
	// Fields
	private const char k_Separator = '\x5f';
	private const string k_AssetLabelPrefix = "Locale-";

	// Methods

	// RVA: 0x1EC4D00 Offset: 0x1EC3300 VA: 0x181EC4D00
	public static string GetTableAddress(string tableName, LocaleIdentifier localeId) { }

	// RVA: 0x1EC4CC0 Offset: 0x1EC32C0 VA: 0x181EC4CC0
	public static string GetSharedTableAddress(string tableName) { }

	// RVA: 0x1EC4C80 Offset: 0x1EC3280 VA: 0x181EC4C80
	public static string FormatAssetLabel(LocaleIdentifier localeIdentifier) { }

	// RVA: 0x1EC4D70 Offset: 0x1EC3370 VA: 0x181EC4D70
	public static bool IsLocaleLabel(string label) { }

	// RVA: 0x86A2C0 Offset: 0x8688C0 VA: 0x18086A2C0
	public static LocaleIdentifier LocaleLabelToId(string label) { }

	// RVA: 0x1EC4DC0 Offset: 0x1EC33C0 VA: 0x181EC4DC0
	public static bool TryGetLocaleLabelToId(string label, out LocaleIdentifier localeId) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
internal static class AssetAddress // TypeDefIndex: 11792
{
	// Fields
	private const string k_SubAssetEntryStartBracket = "[";
	private const string k_SubAssetEntryEndBracket = "]";

	// Methods

	// RVA: 0x1EC5940 Offset: 0x1EC3F40 VA: 0x181EC5940
	public static bool IsSubAsset(string address) { }

	// RVA: 0x1EC5810 Offset: 0x1EC3E10 VA: 0x181EC5810
	public static string GetGuid(string address) { }

	// RVA: 0x1EC58A0 Offset: 0x1EC3EA0 VA: 0x181EC58A0
	public static string GetSubAssetName(string address) { }

	// RVA: 0x1EC57A0 Offset: 0x1EC3DA0 VA: 0x181EC57A0
	public static string FormatAddress(string guid, string subAssetName) { }
}

// Namespace: UnityEngine.Localization
internal struct CallbackArray<TDelegate> // TypeDefIndex: 11793
{
	// Fields
	private const int k_AllocationIncrement = 5;
	private TDelegate m_SingleDelegate; // 0x0
	private TDelegate[] m_MultipleDelegates; // 0x0
	private List<TDelegate> m_AddCallbacks; // 0x0
	private List<TDelegate> m_RemoveCallbacks; // 0x0
	private int m_Length; // 0x0
	private bool m_CannotMutateCallbacksArray; // 0x0
	private bool m_MutatedDuringCallback; // 0x0

	// Properties
	public TDelegate SingleDelegate { get; }
	public TDelegate[] MultiDelegates { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public TDelegate get_SingleDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-CallbackArray<object>.get_SingleDelegate
	*/

	// RVA: -1 Offset: -1
	public TDelegate[] get_MultiDelegates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	|-CallbackArray<object>.get_MultiDelegates
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-CallbackArray<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public void Add(TDelegate callback, int capacityIncrement = 5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91BE0 Offset: 0xC901E0 VA: 0x180C91BE0
	|-CallbackArray<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void RemoveByMovingTail(TDelegate callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91E80 Offset: 0xC90480 VA: 0x180C91E80
	|-CallbackArray<object>.RemoveByMovingTail
	*/

	// RVA: -1 Offset: -1
	public void LockForChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91E70 Offset: 0xC90470 VA: 0x180C91E70
	|-CallbackArray<object>.LockForChanges
	*/

	// RVA: -1 Offset: -1
	public void UnlockForChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC92090 Offset: 0xC90690 VA: 0x180C92090
	|-CallbackArray<object>.UnlockForChanges
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC91E40 Offset: 0xC90440 VA: 0x180C91E40
	|-CallbackArray<object>.Clear
	*/
}

// Namespace: UnityEngine.Localization
internal class LocalizationBehaviour : ComponentSingleton<LocalizationBehaviour> // TypeDefIndex: 11794
{
	// Fields
	[TupleElementNames(new[] { "frame", "handle" })]
	private Queue<ValueTuple<int, AsyncOperationHandle>> m_ReleaseQueue; // 0x20

	// Methods

	// RVA: 0x1ECA8C0 Offset: 0x1EC8EC0 VA: 0x181ECA8C0 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x1ECAAC0 Offset: 0x1EC90C0 VA: 0x181ECAAC0
	public static void ReleaseNextFrame(AsyncOperationHandle handle) { }

	// RVA: 0x1ECA600 Offset: 0x1EC8C00 VA: 0x181ECA600
	private void DoReleaseNextFrame(AsyncOperationHandle handle) { }

	// RVA: 0x1ECA8F0 Offset: 0x1EC8EF0 VA: 0x181ECA8F0
	private void LateUpdate() { }

	// RVA: 0x1ECA6D0 Offset: 0x1EC8CD0 VA: 0x181ECA6D0
	public static void ForceRelease() { }

	// RVA: 0x1ECABC0 Offset: 0x1EC91C0 VA: 0x181ECABC0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization
internal static class StringBuilderPool // TypeDefIndex: 11796
{
	// Fields
	internal static readonly ObjectPool<StringBuilder> s_Pool; // 0x0

	// Methods

	// RVA: 0x1ED97E0 Offset: 0x1ED7DE0 VA: 0x181ED97E0
	public static StringBuilder Get() { }

	// RVA: 0x1ED9850 Offset: 0x1ED7E50 VA: 0x181ED9850
	public static PooledObject<StringBuilder> Get(out StringBuilder value) { }

	// RVA: 0x1ED98F0 Offset: 0x1ED7EF0 VA: 0x181ED98F0
	public static void Release(StringBuilder toRelease) { }

	// RVA: 0x1ED9970 Offset: 0x1ED7F70 VA: 0x181ED9970
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization
[Extension]
internal static class StringExtensionMethods // TypeDefIndex: 11797
{
	// Fields
	private static readonly Regex s_WhitespaceRegex; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1ED9B00 Offset: 0x1ED8100 VA: 0x181ED9B00
	public static string ReplaceWhiteSpaces(string str, string replacement = "") { }

	// RVA: 0x1ED9B80 Offset: 0x1ED8180 VA: 0x181ED9B80
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization
internal static class SystemLanguageConverter // TypeDefIndex: 11798
{
	// Methods

	// RVA: 0x1EDB3E0 Offset: 0x1ED99E0 VA: 0x181EDB3E0
	internal static string GetSystemLanguageCultureCode(SystemLanguage lang) { }
}

