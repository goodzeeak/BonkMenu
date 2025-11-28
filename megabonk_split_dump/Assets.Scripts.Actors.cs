// Namespace: Assets.Scripts.Actors
public class DamageContainer // TypeDefIndex: 5711
{
	// Fields
	public const string unknownDamageSource = "Unkown";
	public Vector3 direction; // 0x10
	public float damage; // 0x1C
	public bool crit; // 0x20
	public float knockback; // 0x24
	public Enemy enemy; // 0x28
	public EDamageEffect damageEffect; // 0x30
	public EElement element; // 0x34
	public float procCoefficient; // 0x38
	public string damageSource; // 0x40
	public int damageBlockedByArmor; // 0x48
	public DcFlags flags; // 0x4C

	// Methods

	// RVA: 0x4666B0 Offset: 0x464CB0 VA: 0x1804666B0
	public void .ctor(float procCoefficient, string damageSource) { }

	// RVA: 0x466620 Offset: 0x464C20 VA: 0x180466620
	public void Reuse(float procCoefficient, string damageSource) { }

	// RVA: 0x466580 Offset: 0x464B80 VA: 0x180466580
	public Color GetColor() { }
}

// Namespace: Assets.Scripts.Actors
[Flags]
public enum DcFlags // TypeDefIndex: 5712
{
	// Fields
	public int value__; // 0x0
	public const DcFlags None = 0;
	public const DcFlags BypassEvade = 1;
	public const DcFlags BossDamage = 2;
	public const DcFlags BypassAegis = 4;
	public const DcFlags FinalBossDamage = 8;
	public const DcFlags BypassAll = 5;
}

