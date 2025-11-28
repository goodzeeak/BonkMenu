// Namespace: UnityEngine.Localization.Pseudo
public interface IPseudoLocalizationMethod // TypeDefIndex: 11974
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Transform(Message message);
}

// Namespace: UnityEngine.Localization.Pseudo
[DefaultMember("Item")]
public abstract class MessageFragment // TypeDefIndex: 11975
{
	// Fields
	protected string m_OriginalString; // 0x10
	protected int m_StartIndex; // 0x18
	protected int m_EndIndex; // 0x1C
	private string m_CachedToString; // 0x20
	[CompilerGenerated]
	private Message <Message>k__BackingField; // 0x28

	// Properties
	public int Length { get; }
	public Message Message { get; set; }
	public char Item { get; }

	// Methods

	// RVA: 0x1EF23F0 Offset: 0x1EF09F0 VA: 0x181EF23F0
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Message get_Message() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	private void set_Message(Message value) { }

	// RVA: 0x1EF22F0 Offset: 0x1EF08F0 VA: 0x181EF22F0
	internal void Initialize(Message parent, string original, int start, int end) { }

	// RVA: 0x1EF2290 Offset: 0x1EF0890 VA: 0x181EF2290
	internal void Initialize(Message parent, string text) { }

	// RVA: 0x1EF21A0 Offset: 0x1EF07A0 VA: 0x181EF21A0
	public WritableMessageFragment CreateTextFragment(int start, int end) { }

	// RVA: 0x1EF20B0 Offset: 0x1EF06B0 VA: 0x181EF20B0
	public ReadOnlyMessageFragment CreateReadonlyTextFragment(int start, int end) { }

	// RVA: 0x1EF2360 Offset: 0x1EF0960 VA: 0x181EF2360 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EF2060 Offset: 0x1EF0660 VA: 0x181EF2060
	internal void BuildString(StringBuilder builder) { }

	// RVA: 0x1EF23C0 Offset: 0x1EF09C0 VA: 0x181EF23C0
	public char get_Item(int index) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[DebuggerDisplay("Writable: {Text}")]
public class WritableMessageFragment : MessageFragment // TypeDefIndex: 11976
{
	// Properties
	public string Text { get; set; }

	// Methods

	// RVA: 0x14B4000 Offset: 0x14B2600 VA: 0x1814B4000
	public string get_Text() { }

	// RVA: 0x1EFFE50 Offset: 0x1EFE450 VA: 0x181EFFE50
	public void set_Text(string value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[DebuggerDisplay("ReadOnly: {Text}")]
public class ReadOnlyMessageFragment : MessageFragment // TypeDefIndex: 11977
{
	// Properties
	public string Text { get; }

	// Methods

	// RVA: 0x14B4000 Offset: 0x14B2600 VA: 0x1814B4000
	public string get_Text() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
public class Message // TypeDefIndex: 11978
{
	// Fields
	[CompilerGenerated]
	private string <Original>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<MessageFragment> <Fragments>k__BackingField; // 0x18

	// Properties
	public string Original { get; set; }
	public List<MessageFragment> Fragments { get; set; }
	public int Length { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Original() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Original(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<MessageFragment> get_Fragments() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_Fragments(List<MessageFragment> value) { }

	// RVA: 0x1EF2FC0 Offset: 0x1EF15C0 VA: 0x181EF2FC0
	public int get_Length() { }

	// RVA: 0x1EF2770 Offset: 0x1EF0D70 VA: 0x181EF2770
	public WritableMessageFragment CreateTextFragment(string original, int start, int end) { }

	// RVA: 0x1EF2850 Offset: 0x1EF0E50 VA: 0x181EF2850
	public WritableMessageFragment CreateTextFragment(string original) { }

	// RVA: 0x1EF2690 Offset: 0x1EF0C90 VA: 0x181EF2690
	public ReadOnlyMessageFragment CreateReadonlyTextFragment(string original, int start, int end) { }

	// RVA: 0x1EF25D0 Offset: 0x1EF0BD0 VA: 0x181EF25D0
	public ReadOnlyMessageFragment CreateReadonlyTextFragment(string original) { }

	// RVA: 0x1EF2BB0 Offset: 0x1EF11B0 VA: 0x181EF2BB0
	public void ReplaceFragment(MessageFragment original, MessageFragment replacement) { }

	// RVA: 0x1EF2910 Offset: 0x1EF0F10 VA: 0x181EF2910
	public void ReleaseFragment(MessageFragment fragment) { }

	// RVA: 0x1EF2420 Offset: 0x1EF0A20 VA: 0x181EF2420
	internal static Message CreateMessage(string text) { }

	// RVA: 0x1EF2A30 Offset: 0x1EF1030 VA: 0x181EF2A30
	internal void Release() { }

	// RVA: 0x1EF2CD0 Offset: 0x1EF12D0 VA: 0x181EF2CD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EF2F40 Offset: 0x1EF1540 VA: 0x181EF2F40
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[Serializable]
public class Accenter : CharacterSubstitutor // TypeDefIndex: 11979
{
	// Methods

	// RVA: 0x1EE5AE0 Offset: 0x1EE40E0 VA: 0x181EE5AE0
	public void .ctor() { }

	// RVA: 0x1EE4DF0 Offset: 0x1EE33F0 VA: 0x181EE4DF0
	public void AddDefaults() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[Serializable]
public class CharacterSubstitutor : IPseudoLocalizationMethod, ISerializationCallbackReceiver // TypeDefIndex: 11983
{
	// Fields
	[SerializeField]
	private CharacterSubstitutor.SubstitutionMethod m_SubstitutionMethod; // 0x10
	[SerializeField]
	private CharacterSubstitutor.ListSelectionMethod m_ListMode; // 0x14
	[SerializeField]
	private List<CharacterSubstitutor.CharReplacement> m_ReplacementsMap; // 0x18
	[SerializeField]
	private List<char> m_ReplacementList; // 0x20
	internal int m_ReplacementsPosition; // 0x28
	[CompilerGenerated]
	private Dictionary<char, char> <ReplacementMap>k__BackingField; // 0x30

	// Properties
	public CharacterSubstitutor.SubstitutionMethod Method { get; set; }
	public Dictionary<char, char> ReplacementMap { get; set; }
	public CharacterSubstitutor.ListSelectionMethod ListMode { get; set; }
	public List<char> ReplacementList { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public CharacterSubstitutor.SubstitutionMethod get_Method() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_Method(CharacterSubstitutor.SubstitutionMethod value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Dictionary<char, char> get_ReplacementMap() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_ReplacementMap(Dictionary<char, char> value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public CharacterSubstitutor.ListSelectionMethod get_ListMode() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_ListMode(CharacterSubstitutor.ListSelectionMethod value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<char> get_ReplacementList() { }

	// RVA: 0x1E65FE0 Offset: 0x1E645E0 VA: 0x181E65FE0
	private int GetRandomSeed(string input) { }

	// RVA: 0x1F01380 Offset: 0x1EFF980 VA: 0x181F01380
	internal char ReplaceCharFromMap(char value) { }

	// RVA: 0x1F01180 Offset: 0x1EFF780 VA: 0x181F01180 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x1F00FE0 Offset: 0x1EFF5E0 VA: 0x181F00FE0 Slot: 6
	public void OnAfterDeserialize() { }

	// RVA: 0x1F013F0 Offset: 0x1EFF9F0 VA: 0x181F013F0
	private void TransformFragment(WritableMessageFragment writableFragment) { }

	// RVA: 0x1F01720 Offset: 0x1EFFD20 VA: 0x181F01720 Slot: 4
	public void Transform(Message message) { }

	// RVA: 0x1F01BD0 Offset: 0x1F001D0 VA: 0x181F01BD0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[Serializable]
public class Encapsulator : IPseudoLocalizationMethod // TypeDefIndex: 11984
{
	// Fields
	[SerializeField]
	private string m_Start; // 0x10
	[SerializeField]
	private string m_End; // 0x18

	// Properties
	public string Start { get; set; }
	public string End { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Start() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Start(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_End() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_End(string value) { }

	// RVA: 0x1F020A0 Offset: 0x1F006A0 VA: 0x181F020A0 Slot: 4
	public void Transform(Message message) { }

	// RVA: 0x1F021C0 Offset: 0x1F007C0 VA: 0x181F021C0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[Serializable]
public class Expander : IPseudoLocalizationMethod // TypeDefIndex: 11987
{
	// Fields
	[SerializeField]
	private List<Expander.ExpansionRule> m_ExpansionRules; // 0x10
	[SerializeField]
	private Expander.InsertLocation m_Location; // 0x18
	[SerializeField]
	private int m_MinimumStringLength; // 0x1C
	[SerializeField]
	private List<char> m_PaddingCharacters; // 0x20

	// Properties
	public List<Expander.ExpansionRule> ExpansionRules { get; }
	public Expander.InsertLocation Location { get; set; }
	public List<char> PaddingCharacters { get; }
	public int MinimumStringLength { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public List<Expander.ExpansionRule> get_ExpansionRules() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public Expander.InsertLocation get_Location() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_Location(Expander.InsertLocation value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<char> get_PaddingCharacters() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_MinimumStringLength() { }

	// RVA: 0x1F039E0 Offset: 0x1F01FE0 VA: 0x181F039E0
	public void set_MinimumStringLength(int value) { }

	// RVA: 0x1F03100 Offset: 0x1F01700 VA: 0x181F03100
	public void .ctor() { }

	// RVA: 0x1F02C40 Offset: 0x1F01240 VA: 0x181F02C40
	public void .ctor(char paddingCharacter) { }

	// RVA: 0x1F03560 Offset: 0x1F01B60 VA: 0x181F03560
	public void .ctor(char start, char end) { }

	// RVA: 0x1F02280 Offset: 0x1F00880 VA: 0x181F02280
	public void AddCharacterRange(char start, char end) { }

	// RVA: 0x1F02780 Offset: 0x1F00D80 VA: 0x181F02780
	public void SetConstantExpansion(float expansion) { }

	// RVA: 0x1F02340 Offset: 0x1F00940 VA: 0x181F02340
	public void AddExpansionRule(int minCharacters, int maxCharacters, float expansion) { }

	// RVA: 0x1F02640 Offset: 0x1F00C40 VA: 0x181F02640
	internal float GetExpansionForLength(int length) { }

	// RVA: 0x1F028F0 Offset: 0x1F00EF0 VA: 0x181F028F0 Slot: 4
	public void Transform(Message message) { }

	// RVA: 0x1F024A0 Offset: 0x1F00AA0 VA: 0x181F024A0
	private void AddPaddingToMessage(Message message, char[] padding) { }

	// RVA: 0x1E65FE0 Offset: 0x1E645E0 VA: 0x181E65FE0
	private int GetRandomSeed(string input) { }
}

// Namespace: UnityEngine.Localization.Pseudo
public class Mirror : IPseudoLocalizationMethod // TypeDefIndex: 11988
{
	// Methods

	// RVA: 0x1F09180 Offset: 0x1F07780 VA: 0x181F09180 Slot: 4
	public void Transform(Message message) { }

	// RVA: 0x1F08FE0 Offset: 0x1F075E0 VA: 0x181F08FE0
	private void MirrorFragment(WritableMessageFragment writableMessageFragment) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[Serializable]
public class PreserveTags : IPseudoLocalizationMethod // TypeDefIndex: 11989
{
	// Fields
	[SerializeField]
	private char m_Opening; // 0x10
	[SerializeField]
	private char m_Closing; // 0x12

	// Properties
	public char Opening { get; set; }
	public char Closing { get; set; }

	// Methods

	// RVA: 0xB99A10 Offset: 0xB98010 VA: 0x180B99A10
	public char get_Opening() { }

	// RVA: 0x132DF00 Offset: 0x132C500 VA: 0x18132DF00
	public void set_Opening(char value) { }

	// RVA: 0x19A0E30 Offset: 0x199F430 VA: 0x1819A0E30
	public char get_Closing() { }

	// RVA: 0x19A0F60 Offset: 0x199F560 VA: 0x1819A0F60
	public void set_Closing(char value) { }

	// RVA: 0x1F09CC0 Offset: 0x1F082C0 VA: 0x181F09CC0 Slot: 4
	public void Transform(Message message) { }

	// RVA: 0x1F0A080 Offset: 0x1F08680 VA: 0x181F0A080
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Pseudo
[CreateAssetMenu(menuName = "Localization/Pseudo-Locale", fileName = "Pseudo-Locale(pseudo)")]
public class PseudoLocale : Locale // TypeDefIndex: 11990
{
	// Fields
	[SerializeReference]
	private List<IPseudoLocalizationMethod> m_Methods; // 0x50

	// Properties
	public List<IPseudoLocalizationMethod> Methods { get; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public List<IPseudoLocalizationMethod> get_Methods() { }

	// RVA: 0x1F0A090 Offset: 0x1F08690 VA: 0x181F0A090
	public static PseudoLocale CreatePseudoLocale() { }

	// RVA: 0x1F0A410 Offset: 0x1F08A10 VA: 0x181F0A410
	private void .ctor() { }

	// RVA: 0x1F0A270 Offset: 0x1F08870 VA: 0x181F0A270
	internal void Reset() { }

	// RVA: 0x1F0A100 Offset: 0x1F08700 VA: 0x181F0A100 Slot: 11
	public virtual string GetPseudoString(string input) { }

	// RVA: 0x1F0A3B0 Offset: 0x1F089B0 VA: 0x181F0A3B0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Localization.Pseudo
public static class TypicalCharacterSets // TypeDefIndex: 11991
{
	// Fields
	internal static Dictionary<SystemLanguage, char[]> s_TypicalCharacterSets; // 0x0

	// Methods

	// RVA: 0x1F0DB30 Offset: 0x1F0C130 VA: 0x181F0DB30
	public static char[] GetTypicalCharactersForLanguage(SystemLanguage language) { }

	// RVA: 0x1F0DBD0 Offset: 0x1F0C1D0 VA: 0x181F0DBD0
	private static void .cctor() { }
}

