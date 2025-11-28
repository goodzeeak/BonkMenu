// Namespace: Assets.Scripts.UI.HUD
public class ColorFilterUI : MonoBehaviour // TypeDefIndex: 5371
{
	// Fields
	public CanvasGroup group; // 0x20
	public RawImage i_color; // 0x28
	private bool usingFilter; // 0x30
	private float fadeSeconds; // 0x34
	private float interpValue; // 0x38

	// Methods

	// RVA: 0x3B57B0 Offset: 0x3B3DB0 VA: 0x1803B57B0
	private void Awake() { }

	// RVA: 0x3B59D0 Offset: 0x3B3FD0 VA: 0x1803B59D0
	private void OnDestroy() { }

	// RVA: 0x3B5BF0 Offset: 0x3B41F0 VA: 0x1803B5BF0
	private void OnFilterEnter(ColorFilter filter) { }

	// RVA: 0x3B5CA0 Offset: 0x3B42A0 VA: 0x1803B5CA0
	private void OnFilterExit(ColorFilter filter) { }

	// RVA: 0x3B5CB0 Offset: 0x3B42B0 VA: 0x1803B5CB0
	private void Update() { }

	// RVA: 0x3B5DA0 Offset: 0x3B43A0 VA: 0x1803B5DA0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.UI.HUD
public class ObjectivePrefabUi : MonoBehaviour // TypeDefIndex: 5372
{
	// Fields
	public GameObject checkBox; // 0x20
	public GameObject checkMark; // 0x28
	public TextMeshProUGUI t_objective; // 0x30
	public LayoutGroup content; // 0x38
	public TextSizer textSizer; // 0x40
	public RawImage overlay; // 0x48
	private float padding; // 0x50
	private int paddingWidth; // 0x54
	private float slideTime; // 0x58
	private float timer; // 0x5C
	private bool completed; // 0x60
	private Color completedColor; // 0x64

	// Methods

	// RVA: 0x3C5200 Offset: 0x3C3800 VA: 0x1803C5200
	public void Set(string t, bool showCheckmark) { }

	// RVA: 0x3C5320 Offset: 0x3C3920 VA: 0x1803C5320
	private void Update() { }

	// RVA: 0x3C4FE0 Offset: 0x3C35E0 VA: 0x1803C4FE0
	private void Rebuild() { }

	// RVA: 0x3C4F00 Offset: 0x3C3500 VA: 0x1803C4F00
	public void Complete() { }

	// RVA: 0x3C5A60 Offset: 0x3C4060 VA: 0x1803C5A60
	public void .ctor() { }
}

// Namespace: Assets.Scripts.UI.HUD
public class ScoreUi : MonoBehaviour // TypeDefIndex: 5373
{
	// Fields
	public RandomSfx scoreSound; // 0x20
	public RandomSfx negativeSound; // 0x28
	private bool moveDesc; // 0x30
	private Queue<ScoreContainer> scoreQueue; // 0x38
	private List<ScoreUiPrefab> prefabs; // 0x40
	public GameObject prefab; // 0x48
	private bool isActive; // 0x50
	private float readyTime; // 0x54

	// Methods

	// RVA: 0x3C9FA0 Offset: 0x3C85A0 VA: 0x1803C9FA0
	public void AddScore(string description, string header, bool isPositive = True) { }

	// RVA: 0x3CA0E0 Offset: 0x3C86E0 VA: 0x1803CA0E0
	public void AddScore(StatModifier statModifier, bool isPositive) { }

	// RVA: 0x3CA630 Offset: 0x3C8C30 VA: 0x1803CA630
	private void Update() { }

	// RVA: 0x3CA2C0 Offset: 0x3C88C0 VA: 0x1803CA2C0
	private void SetScore() { }

	// RVA: 0x3CA6C0 Offset: 0x3C8CC0 VA: 0x1803CA6C0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.UI.HUD
public class ScoreContainer // TypeDefIndex: 5374
{
	// Fields
	public string header; // 0x10
	public string description; // 0x18
	public bool isPositive; // 0x20

	// Methods

	// RVA: 0x3C9F30 Offset: 0x3C8530 VA: 0x1803C9F30
	public void .ctor(string header, string description, bool isPositive) { }
}

