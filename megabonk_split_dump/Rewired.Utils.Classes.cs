// Namespace: Rewired.Utils.Classes
[Browsable(False)]
[EditorBrowsable(1)]
public abstract class CodeHelper // TypeDefIndex: 2938
{
	// Methods

	[Browsable(False)]
	[EditorBrowsable(1)]
	// RVA: 0x142DC10 Offset: 0x142C210 VA: 0x18142DC10 Slot: 0
	public override bool Equals(object obj) { }

	[Browsable(False)]
	[EditorBrowsable(1)]
	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	[Browsable(False)]
	[EditorBrowsable(1)]
	// RVA: 0x142E230 Offset: 0x142C830 VA: 0x18142E230 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Rewired.Utils.Classes
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public abstract class SerializedMethod : ScriptableObject // TypeDefIndex: 2939
{
	// Fields
	private const int GZyuWcEkgoqpBbFyHcKbqelQvysn = 3;
	private bool zJFsdCfbvgnoDhSxngNqZFfaagvZ; // 0x18
	internal List<TypeWrapper> _data; // 0x20
	internal TypeWrapper _result; // 0x28
	internal bool _resultIsValid; // 0x48

	// Properties
	internal abstract TypeWrapper.DataType ResultType { get; }
	internal int DataCount { get; }
	internal TypeWrapper Result { get; }
	internal bool ResultIsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract TypeWrapper.DataType get_ResultType();

	// RVA: 0x17EA700 Offset: 0x17E8D00 VA: 0x1817EA700
	internal int get_DataCount() { }

	// RVA: 0x11165A0 Offset: 0x1114BA0 VA: 0x1811165A0
	internal TypeWrapper get_Result() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	internal bool get_ResultIsValid() { }

	// RVA: 0x17EA5A0 Offset: 0x17E8BA0 VA: 0x1817EA5A0
	internal TypeWrapper GetData(int index) { }

	// RVA: 0x17E9880 Offset: 0x17E7E80 VA: 0x1817E9880
	internal void AddData(byte item) { }

	// RVA: 0x17E9DB0 Offset: 0x17E83B0 VA: 0x1817E9DB0
	internal void AddData(sbyte item) { }

	// RVA: 0x17EA410 Offset: 0x17E8A10 VA: 0x1817EA410
	internal void AddData(char item) { }

	// RVA: 0x17E9770 Offset: 0x17E7D70 VA: 0x1817E9770
	internal void AddData(int item) { }

	// RVA: 0x17EA300 Offset: 0x17E8900 VA: 0x1817EA300
	internal void AddData(uint item) { }

	// RVA: 0x17E9990 Offset: 0x17E7F90 VA: 0x1817E9990
	internal void AddData(long item) { }

	// RVA: 0x17E9BB0 Offset: 0x17E81B0 VA: 0x1817E9BB0
	internal void AddData(ulong item) { }

	// RVA: 0x17E9FD0 Offset: 0x17E85D0 VA: 0x1817E9FD0
	internal void AddData(float item) { }

	// RVA: 0x17E9AA0 Offset: 0x17E80A0 VA: 0x1817E9AA0
	internal void AddData(double item) { }

	// RVA: 0x17EA0E0 Offset: 0x17E86E0 VA: 0x1817EA0E0
	internal void AddData(bool item) { }

	// RVA: 0x17EA1F0 Offset: 0x17E87F0 VA: 0x1817EA1F0
	internal void AddData(string item) { }

	// RVA: 0x17E9EC0 Offset: 0x17E84C0 VA: 0x1817E9EC0
	internal void AddData(object item) { }

	// RVA: 0x17E9CC0 Offset: 0x17E82C0 VA: 0x1817E9CC0
	internal void AddData(TypeWrapper item) { }

	// RVA: 0x17EA520 Offset: 0x17E8B20 VA: 0x1817EA520
	internal void ClearData() { }

	// RVA: 0x17EA590 Offset: 0x17E8B90 VA: 0x1817EA590
	internal void ClearResult() { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Process();

	// RVA: 0x17EA680 Offset: 0x17E8C80 VA: 0x1817EA680
	private void XEIpjTZQscHecGBxWDqrhCsKpSvAb() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

