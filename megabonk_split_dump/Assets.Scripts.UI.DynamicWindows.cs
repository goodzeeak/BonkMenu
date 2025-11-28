// Namespace: Assets.Scripts.UI.DynamicWindows
public class DWindow : DWindowBase // TypeDefIndex: 5375
{
	// Fields
	public TextMeshProUGUI t_header; // 0x28
	public TextMeshProUGUI t_content; // 0x30
	public TextMeshProUGUI t_button; // 0x38

	// Methods

	// RVA: 0x3B63D0 Offset: 0x3B49D0 VA: 0x1803B63D0
	public void Set(string header, string content, string buttonText = "Okey") { }

	// RVA: 0x3B6370 Offset: 0x3B4970 VA: 0x1803B6370
	public void Close() { }

	// RVA: 0x3B6210 Offset: 0x3B4810 VA: 0x1803B6210
	public void .ctor() { }
}

// Namespace: Assets.Scripts.UI.DynamicWindows
public class DWindowBase : MonoBehaviour // TypeDefIndex: 5376
{
	// Fields
	private int rebuildAfterFrames; // 0x20

	// Methods

	// RVA: 0x3B6200 Offset: 0x3B4800 VA: 0x1803B6200
	protected void QueueRebuild() { }

	// RVA: 0x3B6010 Offset: 0x3B4610 VA: 0x1803B6010
	private void LateUpdate() { }

	// RVA: 0x3B6210 Offset: 0x3B4810 VA: 0x1803B6210
	public void .ctor() { }
}

// Namespace: Assets.Scripts.UI.DynamicWindows
public class DWindowPrompt : DWindowBase // TypeDefIndex: 5377
{
	// Fields
	public TextMeshProUGUI t_header; // 0x28
	public TextMeshProUGUI t_content; // 0x30
	private Action A_Accept; // 0x38

	// Methods

	// RVA: 0x3B62F0 Offset: 0x3B48F0 VA: 0x1803B62F0
	public void Set(string header, string content, Action A_Accept) { }

	// RVA: 0x3B6220 Offset: 0x3B4820 VA: 0x1803B6220
	public void Accept() { }

	// RVA: 0x3B6290 Offset: 0x3B4890 VA: 0x1803B6290
	public void Close() { }

	// RVA: 0x3B6210 Offset: 0x3B4810 VA: 0x1803B6210
	public void .ctor() { }
}

