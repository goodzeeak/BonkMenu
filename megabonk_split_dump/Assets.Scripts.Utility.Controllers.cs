// Namespace: Assets.Scripts.Utility.Controllers
[Serializable]
public class InputGlyph // TypeDefIndex: 5344
{
	// Fields
	public KeyCode keycode; // 0x10
	public Texture glyph; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Utility.Controllers
public enum EInputItem // TypeDefIndex: 5345
{
	// Fields
	public int value__; // 0x0
	public const EInputItem Aim = 0;
	public const EInputItem Jump = 1;
	public const EInputItem Slide = 2;
}

// Namespace: Assets.Scripts.Utility.Controllers
public class InputTip // TypeDefIndex: 5346
{
	// Fields
	public string tip; // 0x10
	public string action; // 0x18
	public float extraDelay; // 0x20

	// Methods

	// RVA: 0x3BDAA0 Offset: 0x3BC0A0 VA: 0x1803BDAA0
	public void .ctor(string tip, string action, float extraDelay) { }
}

