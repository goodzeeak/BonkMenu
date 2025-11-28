// Namespace: UnityEngine.Localization.SmartFormat.Core.Output
public interface IOutput // TypeDefIndex: 11940
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Write(string text, IFormattingInfo formattingInfo);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo);
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Output
public class StringOutput : IOutput // TypeDefIndex: 11941
{
	// Fields
	private readonly StringBuilder output; // 0x10

	// Methods

	// RVA: 0x1EFA220 Offset: 0x1EF8820 VA: 0x181EFA220
	public void .ctor() { }

	// RVA: 0x1EFA1A0 Offset: 0x1EF87A0 VA: 0x181EFA1A0
	public void .ctor(int capacity) { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(StringBuilder output) { }

	// RVA: 0x1EFA120 Offset: 0x1EF8720 VA: 0x181EFA120
	public void SetCapacity(int capacity) { }

	// RVA: 0x1A17240 Offset: 0x1A15840 VA: 0x181A17240 Slot: 4
	public void Write(string text, IFormattingInfo formattingInfo) { }

	// RVA: 0x1EFA170 Offset: 0x1EF8770 VA: 0x181EFA170 Slot: 5
	public void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo) { }

	// RVA: 0x1EFA100 Offset: 0x1EF8700 VA: 0x181EFA100
	public void Clear() { }

	// RVA: 0xB98DD0 Offset: 0xB973D0 VA: 0x180B98DD0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Output
public class TextWriterOutput : IOutput // TypeDefIndex: 11942
{
	// Fields
	[CompilerGenerated]
	private readonly TextWriter <Output>k__BackingField; // 0x10

	// Properties
	public TextWriter Output { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(TextWriter output) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public TextWriter get_Output() { }

	// RVA: 0x1EFB6A0 Offset: 0x1EF9CA0 VA: 0x181EFB6A0 Slot: 4
	public void Write(string text, IFormattingInfo formattingInfo) { }

	// RVA: 0x1EFB6D0 Offset: 0x1EF9CD0 VA: 0x181EFB6D0 Slot: 5
	public void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo) { }
}

