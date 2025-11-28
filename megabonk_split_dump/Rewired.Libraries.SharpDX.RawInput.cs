// Namespace: Rewired.Libraries.SharpDX.RawInput
internal enum KeyState // TypeDefIndex: 6062
{
	// Fields
	public int value__; // 0x0
	public const KeyState VirtualKeyToItem = 46;
	public const KeyState SetHotKey = 50;
	public const KeyState GetHotKey = 51;
	public const KeyState KeyFirst = 256;
	public const KeyState KeyDown = 256;
	public const KeyState KeyUp = 257;
	public const KeyState SystemKeyDown = 260;
	public const KeyState SystemKeyUp = 261;
	public const KeyState KeyLast = 265;
	public const KeyState ImeKeyLast = 271;
	public const KeyState ImeKeyDown = 656;
	public const KeyState ImeKeyUp = 657;
	public const KeyState HotKey = 786;
}

// Namespace: Rewired.Libraries.SharpDX.RawInput
[Flags]
internal enum ScanCodeFlags // TypeDefIndex: 6067
{
	// Fields
	public short value__; // 0x0
	public const ScanCodeFlags Make = 0;
	public const ScanCodeFlags Break = 1;
	public const ScanCodeFlags E0 = 2;
	public const ScanCodeFlags E1 = 4;
}

