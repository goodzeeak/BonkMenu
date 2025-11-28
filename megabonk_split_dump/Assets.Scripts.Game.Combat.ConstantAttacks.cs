// Namespace: Assets.Scripts.Game.Combat.ConstantAttacks
public class AegisAttack : ConstantAttack // TypeDefIndex: 5698
{
	// Fields
	public RandomSfx shieldUseSfx; // 0x28
	public RandomSfx shieldRegenSfx; // 0x30
	public Transform renderer; // 0x38
	public AegisRenderer aegisRenderer; // 0x40
	public Transform[] particles; // 0x48
	public ParticleSystem rootParticles; // 0x50
	private bool isActive; // 0x58
	private int currentAmount; // 0x5C
	private float minAegisCooldown; // 0x60
	private float shieldReadyAtTime; // 0x64
	public static Action<int> A_Used; // 0x0
	public static Action<int> A_Regen; // 0x8
	private float nextAmountTime; // 0x68

	// Methods

	// RVA: 0x448450 Offset: 0x446A50 VA: 0x180448450 Slot: 4
	protected override void Init() { }

	// RVA: 0x448340 Offset: 0x446940 VA: 0x180448340
	private void FixedUpdate() { }

	// RVA: 0x448450 Offset: 0x446A50 VA: 0x180448450
	public void RegenShield() { }

	// RVA: 0x448240 Offset: 0x446840 VA: 0x180448240
	private void AmplifyShield() { }

	// RVA: 0x448590 Offset: 0x446B90 VA: 0x180448590
	private void ResetNextAmountTime() { }

	// RVA: 0x448400 Offset: 0x446A00 VA: 0x180448400
	private int GetMaxShields() { }

	// RVA: 0x448640 Offset: 0x446C40 VA: 0x180448640
	public void UseShield(Vector3 enemyFeetPosition) { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool IsActive() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected override void OnWeaponStatUpdate(EStat stat, EWeapon weapon) { }

	// RVA: 0x4484C0 Offset: 0x446AC0 VA: 0x1804484C0 Slot: 6
	protected override void OnStatUpdate(EStat stat) { }

	// RVA: 0x4483F0 Offset: 0x4469F0 VA: 0x1804483F0 Slot: 7
	public override float GetAuraRotationSpeed() { }

	// RVA: 0x448EE0 Offset: 0x4474E0 VA: 0x180448EE0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.ConstantAttacks
public abstract class ConstantAttack : MonoBehaviour // TypeDefIndex: 5699
{
	// Fields
	public WeaponBase weaponBase; // 0x20

	// Methods

	// RVA: 0x44DE60 Offset: 0x44C460 VA: 0x18044DE60
	public void Set(WeaponBase weaponBase) { }

	// RVA: 0x44DA00 Offset: 0x44C000 VA: 0x18044DA00
	protected void Awake() { }

	// RVA: 0x44DC30 Offset: 0x44C230 VA: 0x18044DC30
	protected void OnDestroy() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Init();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnWeaponStatUpdate(EStat stat, EWeapon weapon);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnStatUpdate(EStat stat);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float GetAuraRotationSpeed();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public virtual bool IsManualRotation() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

