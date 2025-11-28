// Namespace: Assets.Scripts.UI.Mouse
public static class Tooltip // TypeDefIndex: 5353
{
	// Fields
	private const string tooltipColor = "#ffe88a";
	private const string tooltipColorOther = "#42b9f5";

	// Methods

	// RVA: 0x3CF950 Offset: 0x3CDF50 VA: 0x1803CF950
	public static string GetTooltipString(EStat stat, string color = "#ffe88a") { }

	// RVA: 0x3CF7C0 Offset: 0x3CDDC0 VA: 0x1803CF7C0
	public static string GetTooltipString(string s, string forceColor = "") { }

	// RVA: 0x3CF6B0 Offset: 0x3CDCB0 VA: 0x1803CF6B0
	public static string GetIdInfo(string keyword) { }
}

// Namespace: Assets.Scripts.UI.Mouse
public class ToolTipsText : MonoBehaviour // TypeDefIndex: 5356
{
	// Fields
	private TMP_Text tmpTextBox; // 0x20
	private Canvas canvas; // 0x28
	private Camera camera; // 0x30
	private RectTransform textBoxRectTransform; // 0x38
	private int currentlyActiveLinkedElement; // 0x40
	[CompilerGenerated]
	private static ToolTipsText.HoverOnLinkEvent OnHoverOnLinkEvent; // 0x0
	[CompilerGenerated]
	private static ToolTipsText.CloseTooltipEvent OnCloseTooltipEvent; // 0x8
	public static Action<string, Vector2> A_OpenTooltip; // 0x10
	public static Action<string> A_CloseTooltip; // 0x18
	private float readyTime; // 0x44
	private Vector3 lastPos; // 0x48
	private bool hasVisibleMouse; // 0x54

	// Methods

	[CompilerGenerated]
	// RVA: 0x3CF470 Offset: 0x3CDA70 VA: 0x1803CF470
	public static void add_OnHoverOnLinkEvent(ToolTipsText.HoverOnLinkEvent value) { }

	[CompilerGenerated]
	// RVA: 0x3CF5F0 Offset: 0x3CDBF0 VA: 0x1803CF5F0
	public static void remove_OnHoverOnLinkEvent(ToolTipsText.HoverOnLinkEvent value) { }

	[CompilerGenerated]
	// RVA: 0x3CF3B0 Offset: 0x3CD9B0 VA: 0x1803CF3B0
	public static void add_OnCloseTooltipEvent(ToolTipsText.CloseTooltipEvent value) { }

	[CompilerGenerated]
	// RVA: 0x3CF530 Offset: 0x3CDB30 VA: 0x1803CF530
	public static void remove_OnCloseTooltipEvent(ToolTipsText.CloseTooltipEvent value) { }

	// RVA: 0x3CEAF0 Offset: 0x3CD0F0 VA: 0x1803CEAF0
	private void Awake() { }

	// RVA: 0x3CF300 Offset: 0x3CD900 VA: 0x1803CF300
	private void OnEnable() { }

	// RVA: 0x3CF330 Offset: 0x3CD930 VA: 0x1803CF330
	private void Update() { }

	// RVA: 0x3CEBF0 Offset: 0x3CD1F0 VA: 0x1803CEBF0
	private void CheckForLinkAtMousePosition() { }

	// RVA: 0x3CEF80 Offset: 0x3CD580 VA: 0x1803CEF80
	private Vector3 GetLinkPosition(TMP_LinkInfo linkInfo, float verticalOffset = 10) { }

	// RVA: 0x3CF250 Offset: 0x3CD850 VA: 0x1803CF250
	private void OnDisable() { }

	// RVA: 0x3CF3A0 Offset: 0x3CD9A0 VA: 0x1803CF3A0
	public void .ctor() { }
}

