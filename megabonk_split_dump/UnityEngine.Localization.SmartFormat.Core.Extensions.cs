// Namespace: UnityEngine.Localization.SmartFormat.Core.Extensions
public abstract class FormatterBase : IFormatter, ISerializationCallbackReceiver // TypeDefIndex: 11947
{
	// Fields
	[SerializeField]
	private string[] m_Names; // 0x10

	// Properties
	public string[] Names { get; set; }
	public abstract string[] DefaultNames { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public string[] get_Names() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 5
	public void set_Names(string[] value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string[] get_DefaultNames();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool TryEvaluateFormat(IFormattingInfo formattingInfo);

	// RVA: 0x1EEA630 Offset: 0x1EE8C30 VA: 0x181EEA630 Slot: 11
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public void OnBeforeSerialize() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Extensions
public interface IFormatter // TypeDefIndex: 11948
{
	// Properties
	public abstract string[] Names { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string[] get_Names();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Names(string[] value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryEvaluateFormat(IFormattingInfo formattingInfo);
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Extensions
public interface IFormatterLiteralExtractor // TypeDefIndex: 11949
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void WriteAllLiterals(IFormattingInfo formattingInfo);
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Extensions
public interface IFormattingInfo // TypeDefIndex: 11950
{
	// Properties
	public abstract object CurrentValue { get; }
	public abstract Format Format { get; }
	[EditorBrowsable(2)]
	public abstract Placeholder Placeholder { get; }
	public abstract int Alignment { get; }
	public abstract string FormatterOptions { get; }
	[EditorBrowsable(2)]
	public abstract FormatDetails FormatDetails { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_CurrentValue();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Format get_Format();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Placeholder get_Placeholder();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_Alignment();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_FormatterOptions();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract FormatDetails get_FormatDetails();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Write(string text);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Write(string text, int startIndex, int length);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Write(Format format, object value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract FormattingException FormattingException(string issue, FormatItem problemItem, int startIndex = -1);
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Extensions
public interface ISelectorInfo // TypeDefIndex: 11951
{
	// Properties
	public abstract object CurrentValue { get; }
	public abstract string SelectorText { get; }
	public abstract int SelectorIndex { get; }
	public abstract string SelectorOperator { get; }
	public abstract object Result { get; set; }
	[EditorBrowsable(2)]
	public abstract Placeholder Placeholder { get; }
	[EditorBrowsable(2)]
	public abstract FormatDetails FormatDetails { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_CurrentValue();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_SelectorText();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_SelectorIndex();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_SelectorOperator();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object get_Result();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_Result(object value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Placeholder get_Placeholder();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract FormatDetails get_FormatDetails();
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Extensions
public interface ISource // TypeDefIndex: 11952
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryEvaluateSelector(ISelectorInfo selectorInfo);
}

