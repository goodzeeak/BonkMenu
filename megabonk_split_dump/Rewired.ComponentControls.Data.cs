// Namespace: Rewired.ComponentControls.Data
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public class CustomControllerElementTarget // TypeDefIndex: 2780
{
	// Fields
	[Tooltip("The Custom Controller element.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementSelector _element; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTarget.ValueRange _valueRange; // 0x18
	[Tooltip("Should the final value be positive or negative?")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Pole _valueContribution; // 0x1C
	[Tooltip("Should the final value be inverted?")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _invert; // 0x20

	// Properties
	public CustomControllerElementSelector element { get; }
	public Pole valueContribution { get; set; }
	internal CustomControllerElementTarget.ValueRange valueRange { get; set; }
	public bool invert { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public CustomControllerElementSelector get_element() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public Pole get_valueContribution() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_valueContribution(Pole value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	internal CustomControllerElementTarget.ValueRange get_valueRange() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	internal void set_valueRange(CustomControllerElementTarget.ValueRange value) { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_invert() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_invert(bool value) { }

	// RVA: 0x1796110 Offset: 0x1794710 VA: 0x181796110
	internal void .ctor() { }

	// RVA: 0x17961B0 Offset: 0x17947B0 VA: 0x1817961B0
	internal void .ctor(CustomControllerElementSelector ) { }

	// RVA: 0x17960F0 Offset: 0x17946F0 VA: 0x1817960F0
	internal void ClearElementCaches() { }
}

// Namespace: Rewired.ComponentControls.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public abstract class CustomControllerElementTargetSet // TypeDefIndex: 2781
{
	// Properties
	internal abstract int targetCount { get; }
	internal abstract CustomControllerElementTarget Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract int get_targetCount();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract CustomControllerElementTarget get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void ClearElementCaches();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Rewired.ComponentControls.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet // TypeDefIndex: 2782
{
	// Fields
	private const int mpXCNXHeExbBDHJJhctNAhpHPTNyb = 1;
	[Tooltip("The target element.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTarget _target; // 0x10

	// Properties
	public CustomControllerElementTarget target { get; }
	internal override int targetCount { get; }
	internal override CustomControllerElementTarget Item { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public CustomControllerElementTarget get_target() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	internal override int get_targetCount() { }

	// RVA: 0x17959A0 Offset: 0x1793FA0 VA: 0x1817959A0 Slot: 5
	internal override CustomControllerElementTarget get_Item(int index) { }

	// RVA: 0x17958C0 Offset: 0x1793EC0 VA: 0x1817958C0
	internal void .ctor() { }

	// RVA: 0x17957C0 Offset: 0x1793DC0 VA: 0x1817957C0
	internal void .ctor(CustomControllerElementTarget ) { }

	// RVA: 0x17957A0 Offset: 0x1793DA0 VA: 0x1817957A0 Slot: 6
	internal override void ClearElementCaches() { }
}

// Namespace: Rewired.ComponentControls.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet // TypeDefIndex: 2783
{
	// Fields
	[Tooltip("Splits the value into positive and negative sides which can be assigned to different Custom Controller elements.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _splitValue; // 0x10
	[Tooltip("The target element. This is unused if Split Value is enabled.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTarget _target; // 0x18
	[Tooltip("The positive target element. This is unused if Split Value is not enabled.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTarget _positiveTarget; // 0x20
	[Tooltip("The negative target element. This is unused if Split Value is not enabled.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementTarget _negativeTarget; // 0x28

	// Properties
	public bool splitValue { get; set; }
	public CustomControllerElementTarget target { get; }
	public CustomControllerElementTarget positiveTarget { get; }
	public CustomControllerElementTarget negativeTarget { get; }
	internal override int targetCount { get; }
	internal override CustomControllerElementTarget Item { get; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_splitValue() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_splitValue(bool value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public CustomControllerElementTarget get_target() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public CustomControllerElementTarget get_positiveTarget() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public CustomControllerElementTarget get_negativeTarget() { }

	// RVA: 0x17960E0 Offset: 0x17946E0 VA: 0x1817960E0 Slot: 4
	internal override int get_targetCount() { }

	// RVA: 0x1796030 Offset: 0x1794630 VA: 0x181796030 Slot: 5
	internal override CustomControllerElementTarget get_Item(int index) { }

	// RVA: 0x1795A20 Offset: 0x1794020 VA: 0x181795A20
	internal void .ctor() { }

	// RVA: 0x1795E20 Offset: 0x1794420 VA: 0x181795E20
	internal void .ctor(CustomControllerElementTarget ) { }

	// RVA: 0x1795C00 Offset: 0x1794200 VA: 0x181795C00
	internal void .ctor(CustomControllerElementTarget , CustomControllerElementTarget ) { }

	// RVA: 0x1795A00 Offset: 0x1794000 VA: 0x181795A00 Slot: 6
	internal override void ClearElementCaches() { }
}

// Namespace: Rewired.ComponentControls.Data
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public sealed class CustomControllerElementSelector // TypeDefIndex: 2786
{
	// Fields
	[Tooltip("The target Custom Controller element type.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementSelector.ElementType _elementType; // 0x10
	[Tooltip("The method to use to look up the target Custom Controller element.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CustomControllerElementSelector.SelectorType _selectorType; // 0x14
	[Tooltip("The target Custom Controller element name.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _elementName; // 0x18
	[Tooltip("The target Custom Controller element index.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(-1, 2147483647)]
	private int _elementIndex; // 0x20
	[Tooltip("The target Custom Controller element id.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(-1, 2147483647)]
	private int _elementId; // 0x24
	[HideInInspector]
	private int kXgWXmllNAXRyHpLQUEhiYAHraLe; // 0x28
	[HideInInspector]
	private int CBAVFMcKTjXdnftWYTHqQcfDtjXo; // 0x2C

	// Properties
	public CustomControllerElementSelector.ElementType elementType { get; set; }
	public CustomControllerElementSelector.SelectorType selectorType { get; set; }
	public string elementName { get; set; }
	public int elementIndex { get; set; }
	public int elementId { get; set; }
	public bool isAssigned { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public CustomControllerElementSelector.ElementType get_elementType() { }

	// RVA: 0x1795760 Offset: 0x1793D60 VA: 0x181795760
	public void set_elementType(CustomControllerElementSelector.ElementType value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public CustomControllerElementSelector.SelectorType get_selectorType() { }

	// RVA: 0x1795780 Offset: 0x1793D80 VA: 0x181795780
	public void set_selectorType(CustomControllerElementSelector.SelectorType value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_elementName() { }

	// RVA: 0x1795710 Offset: 0x1793D10 VA: 0x181795710
	public void set_elementName(string value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_elementIndex() { }

	// RVA: 0x17956F0 Offset: 0x1793CF0 VA: 0x1817956F0
	public void set_elementIndex(int value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public int get_elementId() { }

	// RVA: 0x17956D0 Offset: 0x1793CD0 VA: 0x1817956D0
	public void set_elementId(int value) { }

	// RVA: 0x1795640 Offset: 0x1793C40 VA: 0x181795640
	public bool get_isAssigned() { }

	// RVA: 0x1795190 Offset: 0x1793790 VA: 0x181795190
	public int GetElementIndex(CustomController customController) { }

	// RVA: 0x17954B0 Offset: 0x1793AB0 VA: 0x1817954B0
	public string GetSelectorFormattedString() { }

	// RVA: 0x17955A0 Offset: 0x1793BA0 VA: 0x1817955A0
	private IList<ControllerElementIdentifier> YcmjOsEVCRaWbnTPLuMOPnPAZrfKA(CustomController , CustomControllerElementSelector.ElementType ) { }

	// RVA: 0x1795180 Offset: 0x1793780 VA: 0x181795180
	public void ClearCache() { }

	// RVA: 0x1795620 Offset: 0x1793C20 VA: 0x181795620
	public void .ctor() { }
}

// Namespace: Rewired.ComponentControls.Data
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public sealed class CustomControllerSelector // TypeDefIndex: 2787
{
	// Fields
	[Tooltip("If true, the Custom Controller will be searched for by its source controller id. This can be used with Find in Player and/or Find Using Tag to further refine the search parameters.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _findUsingSourceId; // 0x10
	[Tooltip("The source id of the Custom Controller. This is used to find the Custom Controller if Find Using Source Id is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[FieldRange(0, 2147483647)]
	private int _sourceId; // 0x14
	[Tooltip("If true, the Custom Controller will be found using the tag specified here. This can be used with Find in Player and/or Find Using Source Id to further refine the search parameters.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _findUsingTag; // 0x18
	[Tooltip("The tag on the Custom Controller you wish to use. This is used to find the Custom Controller.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _tag; // 0x20
	[Tooltip("If true, the Custom Controller will be searched for in the Player specified in the Player Id field. This can be used with Find Using Source Id and/or Find Using Tag to further refine the search parameters.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _findInPlayer; // 0x28
	[Tooltip("The Player Id of the Player that owns the Custom Controller.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _playerId; // 0x2C

	// Properties
	public bool findUsingSourceId { get; set; }
	public int sourceId { get; set; }
	public bool findUsingTag { get; set; }
	public string tag { get; set; }
	public bool findInPlayer { get; set; }
	public int playerId { get; set; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_findUsingSourceId() { }

	// RVA: 0x1775710 Offset: 0x1773D10 VA: 0x181775710
	public void set_findUsingSourceId(bool value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_sourceId() { }

	// RVA: 0x1796590 Offset: 0x1794B90 VA: 0x181796590
	public void set_sourceId(int value) { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_findUsingTag() { }

	// RVA: 0x1796570 Offset: 0x1794B70 VA: 0x181796570
	public void set_findUsingTag(bool value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_tag() { }

	// RVA: 0x17965C0 Offset: 0x1794BC0 VA: 0x1817965C0
	public void set_tag(string value) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_findInPlayer() { }

	// RVA: 0x1796560 Offset: 0x1794B60 VA: 0x181796560
	public void set_findInPlayer(bool value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_playerId() { }

	// RVA: 0x1796580 Offset: 0x1794B80 VA: 0x181796580
	public void set_playerId(int value) { }

	// RVA: 0x1796260 Offset: 0x1794860 VA: 0x181796260
	internal CustomController GetCustomController() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void NubdvdwJFIrElKUTXljKcnLQCIdI() { }

	// RVA: 0x1796550 Offset: 0x1794B50 VA: 0x181796550
	public void .ctor() { }
}

