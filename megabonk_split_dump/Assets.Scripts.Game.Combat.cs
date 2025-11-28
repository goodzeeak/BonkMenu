// Namespace: Assets.Scripts.Game.Combat
public static class CombatScaling // TypeDefIndex: 5668
{
	// Fields
	private static float speedMultiplicationPerMinute; // 0x0
	private static float hpMultiplicationPerMinute; // 0x4
	private static float damageMultiplicationPerMinute; // 0x8
	private static float knockbackResistancePerMinute; // 0xC
	private static float stageSpeedMultiplier; // 0x10
	private static float stageDamageMultiplier; // 0x14
	private static float stageKnockbackResMultiplier; // 0x18

	// Methods

	// RVA: 0x44D3E0 Offset: 0x44B9E0 VA: 0x18044D3E0
	private static float GetMinutes() { }

	// RVA: 0x44D7E0 Offset: 0x44BDE0 VA: 0x18044D7E0
	public static float GetStageMultiplier() { }

	// RVA: 0x44D820 Offset: 0x44BE20 VA: 0x18044D820
	public static float GetStageSpeedMultiplier() { }

	// RVA: 0x44D6F0 Offset: 0x44BCF0 VA: 0x18044D6F0
	public static float GetStageHpMultiplier() { }

	// RVA: 0x44D640 Offset: 0x44BC40 VA: 0x18044D640
	public static float GetStageDamageMultiplier() { }

	// RVA: 0x44D440 Offset: 0x44BA40 VA: 0x18044D440
	public static float GetSpeedMultiplierAddition(out float baseAddition, out float swarmAddition, out float stageAddition) { }

	// RVA: 0x44D060 Offset: 0x44B660 VA: 0x18044D060
	public static float GetHpMultiplierAddition(out float baseAddition, out float swarmAddition, out float stageAddition) { }

	// RVA: 0x44CD10 Offset: 0x44B310 VA: 0x18044CD10
	public static float GetDamageMultiplierAddition(out float baseAddition, out float swarmAddition, out float stageAddition) { }

	// RVA: 0x44D290 Offset: 0x44B890 VA: 0x18044D290
	public static float GetKnockbackResistanceMultiplierAddition(out float baseAddition, out float swarmAddition, out float stageAddition) { }

	// RVA: 0x44CFF0 Offset: 0x44B5F0 VA: 0x18044CFF0
	public static float GetFinalSwarmMultiplier() { }

	// RVA: 0x44CF80 Offset: 0x44B580 VA: 0x18044CF80
	public static float GetFinalSwarmHpMultiplier() { }

	// RVA: 0x44CF10 Offset: 0x44B510 VA: 0x18044CF10
	public static float GetFinalSwarmDamageMultiplier() { }

	// RVA: 0x44D8D0 Offset: 0x44BED0 VA: 0x18044D8D0
	public static float GetSwarmSpeedMultiplier() { }

	// RVA: 0x44D940 Offset: 0x44BF40 VA: 0x18044D940
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Game.Combat
public class DamageUtility // TypeDefIndex: 5669
{
	// Fields
	public const string enemyDamageSource = "Enemy";

	// Methods

	// RVA: 0x44E100 Offset: 0x44C700 VA: 0x18044E100
	public static DamageContainer GetPlayerDamage(Enemy enemy, Vector3 direction, DcFlags flags) { }

	// RVA: 0x44E350 Offset: 0x44C950 VA: 0x18044E350
	public static DamageContainer GetPlayerDamage(float damage, float knockback, Vector3 direction, Enemy enemy, string damageSource, DcFlags flags) { }

	// RVA: 0x44DF10 Offset: 0x44C510 VA: 0x18044DF10
	public static bool CheckEvade(Enemy enemy) { }

	// RVA: 0x44DFB0 Offset: 0x44C5B0 VA: 0x18044DFB0
	public static bool GetCritDamageMultiplier(float critChance, out float multiplier) { }

	// RVA: 0x44DE90 Offset: 0x44C490 VA: 0x18044DE90
	public static void ApplyExecute(DamageContainer dc) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat
public enum EDamageEffect // TypeDefIndex: 5670
{
	// Fields
	public int value__; // 0x0
	public const EDamageEffect None = 0;
	public const EDamageEffect Bonk = 1;
	public const EDamageEffect Megacrit = 2;
	public const EDamageEffect Poison = 3;
	public const EDamageEffect Lightning = 4;
	public const EDamageEffect Fire = 5;
	public const EDamageEffect Execute = 6;
	public const EDamageEffect Cursed = 7;
	public const EDamageEffect Echo = 8;
	public const EDamageEffect Bloodmark = 9;
}

// Namespace: Assets.Scripts.Game.Combat
public enum EElement // TypeDefIndex: 5671
{
	// Fields
	public int value__; // 0x0
	public const EElement Neutral = 0;
	public const EElement Lightning = 1;
	public const EElement Ice = 2;
	public const EElement Fire = 3;
	public const EElement Bleed = 4;
}

// Namespace: Assets.Scripts.Game.Combat
public class ProjectileExplosion : MonoBehaviour // TypeDefIndex: 5672
{
	// Fields
	private WeaponAttack weaponAttack; // 0x20
	public GameObject collisionEffect; // 0x28
	private Vector3 effectPos; // 0x30
	private Vector3 effectDir; // 0x3C
	private bool useAudio; // 0x48

	// Methods

	// RVA: 0x45E270 Offset: 0x45C870 VA: 0x18045E270
	public void Set(WeaponAttack weaponAttack, float radius, Vector3 position, float defaultRadius) { }

	// RVA: 0x45DE00 Offset: 0x45C400 VA: 0x18045DE00
	public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect) { }

	// RVA: 0x45E500 Offset: 0x45CB00 VA: 0x18045E500
	private void SpawnEffect() { }

	// RVA: 0x45E570 Offset: 0x45CB70 VA: 0x18045E570
	public void .ctor() { }
}

