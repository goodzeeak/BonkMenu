// Namespace: UnityEngine.Localization.SmartFormat.Core.Settings
public enum CaseSensitivityType // TypeDefIndex: 11919
{
	// Fields
	public int value__; // 0x0
	public const CaseSensitivityType CaseSensitive = 0;
	public const CaseSensitivityType CaseInsensitive = 1;
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Settings
public enum ErrorAction // TypeDefIndex: 11920
{
	// Fields
	public int value__; // 0x0
	public const ErrorAction ThrowError = 0;
	public const ErrorAction OutputErrorInResult = 1;
	public const ErrorAction Ignore = 2;
	public const ErrorAction MaintainTokens = 3;
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Settings
[Serializable]
public class SmartSettings // TypeDefIndex: 11921
{
	// Fields
	[SerializeField]
	private ErrorAction m_FormatErrorAction; // 0x10
	[SerializeField]
	private ErrorAction m_ParseErrorAction; // 0x14
	[Tooltip("Determines whether placeholders are case-sensitive or not.")]
	[SerializeField]
	private CaseSensitivityType m_CaseSensitivity; // 0x18
	[Tooltip("This setting is relevant for the 'Parsing.LiteralText', If true (the default), character string literals are treated like in normal string.Format: string.Format("	") will return a "TAB" character If false, character string literals are not converted, just like with this string.Format: string.Format(@"	") will return the 2 characters "" and "t"")]
	[SerializeField]
	private bool m_ConvertCharacterStringLiterals; // 0x1C

	// Properties
	public ErrorAction FormatErrorAction { get; set; }
	public ErrorAction ParseErrorAction { get; set; }
	public CaseSensitivityType CaseSensitivity { get; set; }
	public bool ConvertCharacterStringLiterals { get; set; }

	// Methods

	// RVA: 0x1EF96B0 Offset: 0x1EF7CB0 VA: 0x181EF96B0
	internal void .ctor() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ErrorAction get_FormatErrorAction() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_FormatErrorAction(ErrorAction value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public ErrorAction get_ParseErrorAction() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_ParseErrorAction(ErrorAction value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public CaseSensitivityType get_CaseSensitivity() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_CaseSensitivity(CaseSensitivityType value) { }

	// RVA: 0x39A900 Offset: 0x398F00 VA: 0x18039A900
	public bool get_ConvertCharacterStringLiterals() { }

	// RVA: 0x39A910 Offset: 0x398F10 VA: 0x18039A910
	public void set_ConvertCharacterStringLiterals(bool value) { }

	// RVA: 0x1EF9470 Offset: 0x1EF7A70 VA: 0x181EF9470
	internal IEqualityComparer<string> GetCaseSensitivityComparer() { }

	// RVA: 0x1EF95F0 Offset: 0x1EF7BF0 VA: 0x181EF95F0
	internal StringComparison GetCaseSensitivityComparison() { }
}

