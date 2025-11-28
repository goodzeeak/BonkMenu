// Namespace: RetroArsenalLib
public class RetroLibCanvas : MonoBehaviour // TypeDefIndex: 5719
{
	// Fields
	public static RetroLibCanvas GlobalAccess; // 0x0
	public bool MouseOverButton; // 0x20
	public Text PENameText; // 0x28
	public Text ToolTipText; // 0x30
	private RaycastHit rayHit; // 0x38

	// Methods

	// RVA: 0x475680 Offset: 0x473C80 VA: 0x180475680
	private void Awake() { }

	// RVA: 0x475AB0 Offset: 0x4740B0 VA: 0x180475AB0
	private void Start() { }

	// RVA: 0x475CA0 Offset: 0x4742A0 VA: 0x180475CA0
	private void Update() { }

	// RVA: 0x475C10 Offset: 0x474210 VA: 0x180475C10
	public void UpdateToolTip(string toolTipText) { }

	// RVA: 0x4756E0 Offset: 0x473CE0 VA: 0x1804756E0
	public void ClearToolTip() { }

	// RVA: 0x475870 Offset: 0x473E70 VA: 0x180475870
	private void SelectPreviousPE() { }

	// RVA: 0x475770 Offset: 0x473D70 VA: 0x180475770
	private void SelectNextPE() { }

	// RVA: 0x475980 Offset: 0x473F80 VA: 0x180475980
	private void SpawnCurrentParticleEffect() { }

	// RVA: 0x475B80 Offset: 0x474180 VA: 0x180475B80
	public void UIButtonClick(string buttonTypeClicked) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: RetroArsenalLib
public class RetroVFXLibrary : MonoBehaviour // TypeDefIndex: 5720
{
	// Fields
	public static RetroVFXLibrary GlobalAccess; // 0x0
	public int TotalEffects; // 0x20
	public int CurrentParticleEffectIndex; // 0x24
	public int CurrentParticleEffectNum; // 0x28
	public Vector3[] ParticleEffectSpawnOffsets; // 0x30
	public float[] ParticleEffectLifetimes; // 0x38
	public GameObject[] ParticleEffectPrefabs; // 0x40
	private List<Transform> currentActivePEList; // 0x48
	private StringBuilder effectNameBuilder; // 0x50

	// Methods

	// RVA: 0x478650 Offset: 0x476C50 VA: 0x180478650
	private void Awake() { }

	// RVA: 0x4788F0 Offset: 0x476EF0 VA: 0x1804788F0
	public string GetCurrentPENameString() { }

	// RVA: 0x478950 Offset: 0x476F50 VA: 0x180478950
	public void PreviousParticleEffect() { }

	// RVA: 0x478920 Offset: 0x476F20 VA: 0x180478920
	public void NextParticleEffect() { }

	// RVA: 0x478700 Offset: 0x476D00 VA: 0x180478700
	private void DestroyLoopingParticleEffects() { }

	// RVA: 0x478C40 Offset: 0x477240 VA: 0x180478C40
	private void UpdateEffectNameString() { }

	// RVA: 0x478980 Offset: 0x476F80 VA: 0x180478980
	public void SpawnParticleEffect(Vector3 positionInWorldToSpawn) { }

	// RVA: 0x478D70 Offset: 0x477370 VA: 0x180478D70
	public void .ctor() { }
}

