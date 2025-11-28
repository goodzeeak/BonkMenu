// Namespace: MilkShake
public interface IShakeParameters // TypeDefIndex: 5297
{
	// Properties
	public abstract ShakeType ShakeType { get; set; }
	public abstract float Strength { get; set; }
	public abstract float Roughness { get; set; }
	public abstract float FadeIn { get; set; }
	public abstract float FadeOut { get; set; }
	public abstract Vector3 PositionInfluence { get; set; }
	public abstract Vector3 RotationInfluence { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ShakeType get_ShakeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_ShakeType(ShakeType value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_Strength();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Strength(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_Roughness();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_Roughness(float value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_FadeIn();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_FadeIn(float value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_FadeOut();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_FadeOut(float value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Vector3 get_PositionInfluence();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_PositionInfluence(Vector3 value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Vector3 get_RotationInfluence();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_RotationInfluence(Vector3 value);
}

// Namespace: MilkShake
[Serializable]
public class ShakeInstance // TypeDefIndex: 5298
{
	// Fields
	public ShakeParameters ShakeParameters; // 0x10
	public float StrengthScale; // 0x18
	public float RoughnessScale; // 0x1C
	public bool RemoveWhenStopped; // 0x20
	[CompilerGenerated]
	private ShakeState <State>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsPaused>k__BackingField; // 0x28
	private int baseSeed; // 0x2C
	private float seed1; // 0x30
	private float seed2; // 0x34
	private float seed3; // 0x38
	private float noiseTimer; // 0x3C
	private float fadeTimer; // 0x40
	private float fadeInTime; // 0x44
	private float fadeOutTime; // 0x48
	private float pauseTimer; // 0x4C
	private float pauseFadeTime; // 0x50
	private int lastUpdatedFrame; // 0x54

	// Properties
	public ShakeState State { get; set; }
	public bool IsPaused { get; set; }
	public bool IsFinished { get; }
	public float CurrentStrength { get; }
	public float CurrentRoughness { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public ShakeState get_State() { }

	[CompilerGenerated]
	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	private void set_State(ShakeState value) { }

	[CompilerGenerated]
	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_IsPaused() { }

	[CompilerGenerated]
	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	private void set_IsPaused(bool value) { }

	// RVA: 0x3CB140 Offset: 0x3C9740 VA: 0x1803CB140
	public bool get_IsFinished() { }

	// RVA: 0x3CB110 Offset: 0x3C9710 VA: 0x1803CB110
	public float get_CurrentStrength() { }

	// RVA: 0x3CB0E0 Offset: 0x3C96E0 VA: 0x1803CB0E0
	public float get_CurrentRoughness() { }

	// RVA: 0x3CAD60 Offset: 0x3C9360 VA: 0x1803CAD60
	public void .ctor(Nullable<int> seed) { }

	// RVA: 0x3CABB0 Offset: 0x3C91B0 VA: 0x1803CABB0
	public void .ctor(IShakeParameters shakeData, Nullable<int> seed) { }

	// RVA: 0x3CA820 Offset: 0x3C8E20 VA: 0x1803CA820
	public ShakeResult UpdateShake(float deltaTime) { }

	// RVA: 0x3CA7C0 Offset: 0x3C8DC0 VA: 0x1803CA7C0
	public void Start(float fadeTime) { }

	// RVA: 0x3CA7D0 Offset: 0x3C8DD0 VA: 0x1803CA7D0
	public void Stop(float fadeTime, bool removeWhenStopped) { }

	// RVA: 0x3CA780 Offset: 0x3C8D80 VA: 0x1803CA780
	public void Pause(float fadeTime) { }

	// RVA: 0x3CA7A0 Offset: 0x3C8DA0 VA: 0x1803CA7A0
	public void Resume(float fadeTime) { }

	// RVA: 0x3CA7F0 Offset: 0x3C8DF0 VA: 0x1803CA7F0
	public void TogglePaused(float fadeTime) { }

	// RVA: 0x3CAE80 Offset: 0x3C9480 VA: 0x1803CAE80
	private Vector3 getPositionShake() { }

	// RVA: 0x3CAFB0 Offset: 0x3C95B0 VA: 0x1803CAFB0
	private Vector3 getRotationShake() { }

	// RVA: 0x3CAE50 Offset: 0x3C9450 VA: 0x1803CAE50
	private float getNoise(float x, float y) { }
}

// Namespace: MilkShake
[Serializable]
public class ShakeParameters : IShakeParameters // TypeDefIndex: 5299
{
	// Fields
	[Header("Shake Type")]
	[SerializeField]
	private ShakeType shakeType; // 0x10
	[Header("Shake Strength")]
	[SerializeField]
	private float strength; // 0x14
	[SerializeField]
	private float roughness; // 0x18
	[Header("Fade")]
	[SerializeField]
	private float fadeIn; // 0x1C
	[SerializeField]
	private float fadeOut; // 0x20
	[Header("Shake Influence")]
	[SerializeField]
	private Vector3 positionInfluence; // 0x24
	[SerializeField]
	private Vector3 rotationInfluence; // 0x30

	// Properties
	public ShakeType ShakeType { get; set; }
	public float Strength { get; set; }
	public float Roughness { get; set; }
	public float FadeIn { get; set; }
	public float FadeOut { get; set; }
	public Vector3 PositionInfluence { get; set; }
	public Vector3 RotationInfluence { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3CB190 Offset: 0x3C9790 VA: 0x1803CB190
	public void .ctor(IShakeParameters original) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public ShakeType get_ShakeType() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60 Slot: 5
	public void set_ShakeType(ShakeType value) { }

	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0 Slot: 6
	public float get_Strength() { }

	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60 Slot: 7
	public void set_Strength(float value) { }

	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70 Slot: 8
	public float get_Roughness() { }

	// RVA: 0x3A4C30 Offset: 0x3A3230 VA: 0x1803A4C30 Slot: 9
	public void set_Roughness(float value) { }

	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0 Slot: 10
	public float get_FadeIn() { }

	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450 Slot: 11
	public void set_FadeIn(float value) { }

	// RVA: 0x3CB400 Offset: 0x3C9A00 VA: 0x1803CB400 Slot: 12
	public float get_FadeOut() { }

	// RVA: 0x3CB460 Offset: 0x3C9A60 VA: 0x1803CB460 Slot: 13
	public void set_FadeOut(float value) { }

	// RVA: 0x3CB410 Offset: 0x3C9A10 VA: 0x1803CB410 Slot: 14
	public Vector3 get_PositionInfluence() { }

	// RVA: 0x3CB470 Offset: 0x3C9A70 VA: 0x1803CB470 Slot: 15
	public void set_PositionInfluence(Vector3 value) { }

	// RVA: 0x3CB430 Offset: 0x3C9A30 VA: 0x1803CB430 Slot: 16
	public Vector3 get_RotationInfluence() { }

	// RVA: 0x3CB480 Offset: 0x3C9A80 VA: 0x1803CB480 Slot: 17
	public void set_RotationInfluence(Vector3 value) { }
}

// Namespace: MilkShake
[CreateAssetMenu(fileName = "New Shake Preset", menuName = "MilkShake/Shake Preset")]
public class ShakePreset : ScriptableObject, IShakeParameters // TypeDefIndex: 5300
{
	// Fields
	[Header("Shake Type")]
	[SerializeField]
	private ShakeType shakeType; // 0x18
	[Header("Shake Strength")]
	[SerializeField]
	private float strength; // 0x1C
	[SerializeField]
	private float roughness; // 0x20
	[Header("Fade")]
	[SerializeField]
	private float fadeIn; // 0x24
	[SerializeField]
	private float fadeOut; // 0x28
	[Header("Shake Influence")]
	[SerializeField]
	private Vector3 positionInfluence; // 0x2C
	[SerializeField]
	private Vector3 rotationInfluence; // 0x38

	// Properties
	public ShakeType ShakeType { get; set; }
	public float Strength { get; set; }
	public float Roughness { get; set; }
	public float FadeIn { get; set; }
	public float FadeOut { get; set; }
	public Vector3 PositionInfluence { get; set; }
	public Vector3 RotationInfluence { get; set; }

	// Methods

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 4
	public ShakeType get_ShakeType() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540 Slot: 5
	public void set_ShakeType(ShakeType value) { }

	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0 Slot: 6
	public float get_Strength() { }

	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450 Slot: 7
	public void set_Strength(float value) { }

	// RVA: 0x3CB400 Offset: 0x3C9A00 VA: 0x1803CB400 Slot: 8
	public float get_Roughness() { }

	// RVA: 0x3CB460 Offset: 0x3C9A60 VA: 0x1803CB460 Slot: 9
	public void set_Roughness(float value) { }

	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490 Slot: 10
	public float get_FadeIn() { }

	// RVA: 0x3CB500 Offset: 0x3C9B00 VA: 0x1803CB500 Slot: 11
	public void set_FadeIn(float value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0 Slot: 12
	public float get_FadeOut() { }

	// RVA: 0x3CB510 Offset: 0x3C9B10 VA: 0x1803CB510 Slot: 13
	public void set_FadeOut(float value) { }

	// RVA: 0x3CB4B0 Offset: 0x3C9AB0 VA: 0x1803CB4B0 Slot: 14
	public Vector3 get_PositionInfluence() { }

	// RVA: 0x3CB520 Offset: 0x3C9B20 VA: 0x1803CB520 Slot: 15
	public void set_PositionInfluence(Vector3 value) { }

	// RVA: 0x3CB4D0 Offset: 0x3C9AD0 VA: 0x1803CB4D0 Slot: 16
	public Vector3 get_RotationInfluence() { }

	// RVA: 0x3CB530 Offset: 0x3C9B30 VA: 0x1803CB530 Slot: 17
	public void set_RotationInfluence(Vector3 value) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: MilkShake
[AddComponentMenu("MilkShake/Shaker")]
public class Shaker : MonoBehaviour // TypeDefIndex: 5301
{
	// Fields
	public static List<Shaker> GlobalShakers; // 0x0
	[SerializeField]
	private bool addToGlobalShakers; // 0x20
	private List<ShakeInstance> activeShakes; // 0x28

	// Methods

	// RVA: 0x3CBD20 Offset: 0x3CA320 VA: 0x1803CBD20
	public static ShakeInstance ShakeAll(IShakeParameters shakeData, Nullable<int> seed) { }

	// RVA: 0x3CBB60 Offset: 0x3CA160 VA: 0x1803CBB60
	public static void ShakeAllSeparate(IShakeParameters shakeData, List<ShakeInstance> shakeInstances, Nullable<int> seed) { }

	// RVA: 0x3CB950 Offset: 0x3C9F50 VA: 0x1803CB950
	public static void ShakeAllFromPoint(Vector3 point, float maxDistance, IShakeParameters shakeData, List<ShakeInstance> shakeInstances, Nullable<int> seed) { }

	// RVA: 0x3CB5E0 Offset: 0x3C9BE0 VA: 0x1803CB5E0
	public static void AddShakeAll(ShakeInstance shakeInstance) { }

	// RVA: 0x3CB7E0 Offset: 0x3C9DE0 VA: 0x1803CB7E0
	private void Awake() { }

	// RVA: 0x3CB8C0 Offset: 0x3C9EC0 VA: 0x1803CB8C0
	private void OnDestroy() { }

	// RVA: 0x3CC140 Offset: 0x3CA740 VA: 0x1803CC140
	private void Update() { }

	// RVA: 0x3CC0C0 Offset: 0x3CA6C0 VA: 0x1803CC0C0
	public ShakeInstance Shake(IShakeParameters shakeData, Nullable<int> seed) { }

	// RVA: 0x3CBEE0 Offset: 0x3CA4E0 VA: 0x1803CBEE0
	public ShakeInstance ShakeFromPoint(Vector3 point, float maxDistance, IShakeParameters shakeData, Nullable<int> seed) { }

	// RVA: 0x3CB730 Offset: 0x3C9D30 VA: 0x1803CB730
	public void AddShake(ShakeInstance shakeInstance) { }

	// RVA: 0x3CC3F0 Offset: 0x3CA9F0 VA: 0x1803CC3F0
	public void .ctor() { }

	// RVA: 0x3CC360 Offset: 0x3CA960 VA: 0x1803CC360
	private static void .cctor() { }
}

// Namespace: MilkShake
public struct ShakeResult // TypeDefIndex: 5302
{
	// Fields
	public Vector3 PositionShake; // 0x0
	public Vector3 RotationShake; // 0xC

	// Methods

	// RVA: 0x3CB550 Offset: 0x3C9B50 VA: 0x1803CB550
	public static ShakeResult op_Addition(ShakeResult a, ShakeResult b) { }
}

// Namespace: MilkShake
public enum ShakeState // TypeDefIndex: 5303
{
	// Fields
	public int value__; // 0x0
	public const ShakeState FadingIn = 0;
	public const ShakeState Sustained = 1;
	public const ShakeState FadingOut = 2;
	public const ShakeState Stopped = 3;
}

// Namespace: MilkShake
public enum ShakeType // TypeDefIndex: 5304
{
	// Fields
	public int value__; // 0x0
	public const ShakeType OneShot = 0;
	public const ShakeType Sustained = 1;
}

