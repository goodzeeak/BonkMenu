// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityBullseye : PassiveAbility // TypeDefIndex: 5619
{
	// Fields
	private float critDamagePerLevel; // 0x18
	public const int MAX_MARKERS = 20;
	private float markDuration; // 0x1C
	private float markCooldown; // 0x20
	private float markReadyAtTime; // 0x24
	private float explosionRadius; // 0x28
	private float maxExplosionRadius; // 0x2C
	private float explosionDamage; // 0x30
	private static float minCooldown; // 0x0
	private static float maxCooldown; // 0x4
	private float cooldownReductionPerLevel; // 0x34
	private static Dictionary<Enemy, float> markedEnemies; // 0x8
	private string damageSource; // 0x38
	private DamageContainer reuseDc; // 0x40
	private bool isExplosionDamage; // 0x48

	// Methods

	// RVA: 0x445870 Offset: 0x443E70 VA: 0x180445870 Slot: 4
	public override void Init() { }

	// RVA: 0x445170 Offset: 0x443770 VA: 0x180445170 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x4468A0 Offset: 0x444EA0 VA: 0x1804468A0
	private void OnLevelup(int level) { }

	// RVA: 0x446AA0 Offset: 0x4450A0 VA: 0x180446AA0
	private void OnStageStarted() { }

	// RVA: 0x446660 Offset: 0x444C60 VA: 0x180446660
	private void OnEnemySpawned(Enemy enemy) { }

	// RVA: 0x445F60 Offset: 0x444560 VA: 0x180445F60
	private void OnEnemyDamaged(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x446570 Offset: 0x444B70 VA: 0x180446570
	private void OnEnemyReleasedFromPool(Enemy enemy) { }

	// RVA: 0x446AB0 Offset: 0x4450B0 VA: 0x180446AB0
	private void Reset() { }

	// RVA: 0x445DC0 Offset: 0x4443C0 VA: 0x180445DC0
	public static bool IsMarkedEnemy(Enemy enemy) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x4456C0 Offset: 0x443CC0 VA: 0x1804456C0 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x446BF0 Offset: 0x4451F0 VA: 0x180446BF0
	public void .ctor() { }

	// RVA: 0x446BA0 Offset: 0x4451A0 VA: 0x180446BA0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityCritHappens : PassiveAbility // TypeDefIndex: 5620
{
	// Fields
	private float critChancePerLevel; // 0x18

	// Methods

	// RVA: 0x455090 Offset: 0x453690 VA: 0x180455090 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x4551E0 Offset: 0x4537E0 VA: 0x1804551E0
	private void OnLevelup(int level) { }

	// RVA: 0x454D80 Offset: 0x453380 VA: 0x180454D80 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x454ED0 Offset: 0x4534D0 VA: 0x180454ED0 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x455270 Offset: 0x453870 VA: 0x180455270
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityCurse : PassiveAbility // TypeDefIndex: 5621
{
	// Fields
	private float difficultyChancePerLevel; // 0x18

	// Methods

	// RVA: 0x455590 Offset: 0x453B90 VA: 0x180455590 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x4556E0 Offset: 0x453CE0 VA: 0x1804556E0
	private void OnLevelup(int level) { }

	// RVA: 0x455280 Offset: 0x453880 VA: 0x180455280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x455580 Offset: 0x453B80 VA: 0x180455580 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x4553D0 Offset: 0x4539D0 VA: 0x1804553D0 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x455270 Offset: 0x453870 VA: 0x180455270
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityEnduring : PassiveAbility // TypeDefIndex: 5622
{
	// Fields
	private float sizePerLevel; // 0x18
	private float maxSize; // 0x1C
	private float damageMultiplierPerFrozenEnemy; // 0x20
	private int lastNumFrozenEnemies; // 0x24

	// Methods

	// RVA: 0x455BC0 Offset: 0x4541C0 VA: 0x180455BC0 Slot: 4
	public override void Init() { }

	// RVA: 0x455EE0 Offset: 0x4544E0 VA: 0x180455EE0
	private void OnStageStarted() { }

	// RVA: 0x455F40 Offset: 0x454540 VA: 0x180455F40 Slot: 6
	public override void Tick() { }

	// RVA: 0x455E40 Offset: 0x454440 VA: 0x180455E40
	private void OnLevelup(int level) { }

	// RVA: 0x455770 Offset: 0x453D70 VA: 0x180455770 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x455BB0 Offset: 0x4541B0 VA: 0x180455BB0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x4559C0 Offset: 0x453FC0 VA: 0x1804559C0 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x456040 Offset: 0x454640 VA: 0x180456040
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityFlex : PassiveAbility // TypeDefIndex: 5623
{
	// Fields
	public static Action<bool> A_FlexReady; // 0x0
	private static float cooldown; // 0x8
	private static float minCooldown; // 0xC
	private static float maxCooldown; // 0x10
	private float cooldownReductionPerLevel; // 0x18
	private float radius; // 0x1C
	private static float flexReadyAtTime; // 0x14
	public float damagePerFlex; // 0x20
	private int stacks; // 0x24
	private bool canFlex; // 0x28
	private DamageContainer reuseDc; // 0x30
	private string damageSource; // 0x38

	// Methods

	// RVA: 0x456680 Offset: 0x454C80 VA: 0x180456680 Slot: 4
	public override void Init() { }

	// RVA: 0x456060 Offset: 0x454660 VA: 0x180456060 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x456A50 Offset: 0x455050 VA: 0x180456A50
	private void OnLevelup(int level) { }

	// RVA: 0x456B00 Offset: 0x455100 VA: 0x180456B00 Slot: 6
	public override void Tick() { }

	// RVA: 0x456970 Offset: 0x454F70 VA: 0x180456970
	private void OnCheckStopDamage(DamageContainer dc, bool shieldDamage) { }

	// RVA: 0x456320 Offset: 0x454920 VA: 0x180456320
	private float GetDamage() { }

	// RVA: 0x4565B0 Offset: 0x454BB0 VA: 0x1804565B0
	private float GetKnockback() { }

	// RVA: 0x456BF0 Offset: 0x4551F0 VA: 0x180456BF0
	private void UseFlex() { }

	// RVA: 0x4565E0 Offset: 0x454BE0 VA: 0x1804565E0
	private bool HasFlex() { }

	// RVA: 0x4565D0 Offset: 0x454BD0 VA: 0x1804565D0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x456390 Offset: 0x454990 VA: 0x180456390 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x4572E0 Offset: 0x4558E0 VA: 0x1804572E0
	public void .ctor() { }

	// RVA: 0x457270 Offset: 0x455870 VA: 0x180457270
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityFloating : PassiveAbility // TypeDefIndex: 5624
{
	// Fields
	private float floatingDamagePerLevel; // 0x18
	private float lastSetDamage; // 0x1C
	private float updateDamageAtTime; // 0x20
	private float updateDamageCooldown; // 0x24

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x457550 Offset: 0x455B50 VA: 0x180457550 Slot: 6
	public override void Tick() { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x4573A0 Offset: 0x4559A0 VA: 0x1804573A0 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x457900 Offset: 0x455F00 VA: 0x180457900
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityFlowstate : PassiveAbility // TypeDefIndex: 5625
{
	// Fields
	private float attackSpeedPerLevel; // 0x18

	// Methods

	// RVA: 0x457C20 Offset: 0x456220 VA: 0x180457C20 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x457D70 Offset: 0x456370 VA: 0x180457D70
	private void OnLevelup(int level) { }

	// RVA: 0x457920 Offset: 0x455F20 VA: 0x180457920 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x457A70 Offset: 0x456070 VA: 0x180457A70 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x455270 Offset: 0x453870 VA: 0x180455270
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityGamba : PassiveAbility // TypeDefIndex: 5626
{
	// Fields
	private float upgradeMultiplier; // 0x18
	private float minMultiplier; // 0x1C
	private float maxMultiplier; // 0x20

	// Methods

	// RVA: 0x457F60 Offset: 0x456560 VA: 0x180457F60 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x4580B0 Offset: 0x4566B0 VA: 0x1804580B0
	private void OnLevelup(int level) { }

	// RVA: 0x457E00 Offset: 0x456400 VA: 0x180457E00 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x457F50 Offset: 0x456550 VA: 0x180457F50 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x447360 Offset: 0x445960 VA: 0x180447360 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x4582A0 Offset: 0x4568A0 VA: 0x1804582A0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityLockIn : PassiveAbility // TypeDefIndex: 5627
{
	// Fields
	public int thornsPerLevel; // 0x18
	private float maxDamage; // 0x1C
	private float maxDamagePerLevel; // 0x20
	private float updateCooldown; // 0x24
	private float nextUpdateTime; // 0x28
	private float lastValue; // 0x2C

	// Methods

	// RVA: 0x458790 Offset: 0x456D90 VA: 0x180458790 Slot: 4
	public override void Init() { }

	// RVA: 0x4582C0 Offset: 0x4568C0 VA: 0x1804582C0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x458AB0 Offset: 0x4570B0 VA: 0x180458AB0
	private void OnAegisChange(int currentAmount) { }

	// RVA: 0x458C00 Offset: 0x457200 VA: 0x180458C00 Slot: 6
	public override void Tick() { }

	// RVA: 0x458B50 Offset: 0x457150 VA: 0x180458B50
	private void OnLevelup(int level) { }

	// RVA: 0x458780 Offset: 0x456D80 VA: 0x180458780 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x4585E0 Offset: 0x456BE0 VA: 0x1804585E0 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x458E20 Offset: 0x457420 VA: 0x180458E20
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityMissing : PassiveAbility // TypeDefIndex: 5628
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x458E50 Offset: 0x457450 VA: 0x180458E50 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x458E60 Offset: 0x457460 VA: 0x180458E60
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityPlague : PassiveAbility // TypeDefIndex: 5629
{
	// Fields
	private int levelsPerStack; // 0x18
	private float radius; // 0x1C
	private float duration; // 0x20

	// Methods

	// RVA: 0x458FD0 Offset: 0x4575D0 VA: 0x180458FD0 Slot: 4
	public override void Init() { }

	// RVA: 0x458E70 Offset: 0x457470 VA: 0x180458E70 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x459120 Offset: 0x457720 VA: 0x180459120
	private void OnEnemyDied(Enemy enemy, DamageContainer deathSource) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x459620 Offset: 0x457C20 VA: 0x180459620
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityQuantumXp : PassiveAbility // TypeDefIndex: 5630
{
	// Fields
	private float xpPerLevel; // 0x18

	// Methods

	// RVA: 0x459950 Offset: 0x457F50 VA: 0x180459950 Slot: 4
	public override void Init() { }

	// RVA: 0x459640 Offset: 0x457C40 VA: 0x180459640 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x459AA0 Offset: 0x4580A0 VA: 0x180459AA0
	private void OnLevelup(int level) { }

	// RVA: 0x459790 Offset: 0x457D90 VA: 0x180459790 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x459940 Offset: 0x457F40 VA: 0x180459940 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x455270 Offset: 0x453870 VA: 0x180455270
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityReinforced : PassiveAbility // TypeDefIndex: 5631
{
	// Fields
	private float armorPerLevel; // 0x18

	// Methods

	// RVA: 0x459E30 Offset: 0x458430 VA: 0x180459E30 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x459F80 Offset: 0x458580 VA: 0x180459F80
	private void OnLevelup(int level) { }

	// RVA: 0x459B30 Offset: 0x458130 VA: 0x180459B30 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x459C80 Offset: 0x458280 VA: 0x180459C80 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x455270 Offset: 0x453870 VA: 0x180455270
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityRngBlessing : PassiveAbility // TypeDefIndex: 5632
{
	// Fields
	private float luckPerLevel; // 0x18

	// Methods

	// RVA: 0x45A310 Offset: 0x458910 VA: 0x18045A310 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x45A460 Offset: 0x458A60 VA: 0x18045A460
	private void OnLevelup(int level) { }

	// RVA: 0x45A010 Offset: 0x458610 VA: 0x18045A010 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45A160 Offset: 0x458760 VA: 0x18045A160 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x45A4F0 Offset: 0x458AF0 VA: 0x18045A4F0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityShadowstep : PassiveAbility // TypeDefIndex: 5633
{
	// Fields
	private float evadePerLevel; // 0x18
	private const string damageSource = "Shadowstep";
	private DamageContainer reuseDc; // 0x20

	// Methods

	// RVA: 0x45A9C0 Offset: 0x458FC0 VA: 0x18045A9C0 Slot: 4
	public override void Init() { }

	// RVA: 0x45A500 Offset: 0x458B00 VA: 0x18045A500 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x45AD70 Offset: 0x459370 VA: 0x18045AD70
	private void OnLevelup(int level) { }

	// RVA: 0x45AC30 Offset: 0x459230 VA: 0x18045AC30
	private void OnEvade(Enemy enemy) { }

	// RVA: 0x45A9B0 Offset: 0x458FB0 VA: 0x18045A9B0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45A770 Offset: 0x458D70 VA: 0x18045A770 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x45AE00 Offset: 0x459400 VA: 0x18045AE00
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilitySpeedDemon : PassiveAbility // TypeDefIndex: 5634
{
	// Fields
	private float increaseInterval; // 0x18
	private float increasePerInterval; // 0x1C
	private float speedIncrease; // 0x20
	private float nextInterval; // 0x24
	private float cap; // 0x28
	private float updateStatsInterval; // 0x2C
	private float nextUpdateDamageTime; // 0x30
	private float damagePerSpeedMultiplier; // 0x34
	private float damagePerLevel; // 0x38

	// Methods

	// RVA: 0x45AFE0 Offset: 0x4595E0 VA: 0x18045AFE0 Slot: 4
	public override void Init() { }

	// RVA: 0x45AE90 Offset: 0x459490 VA: 0x18045AE90 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x45B6A0 Offset: 0x459CA0 VA: 0x18045B6A0 Slot: 6
	public override void Tick() { }

	// RVA: 0x45B570 Offset: 0x459B70 VA: 0x18045B570
	private void TickSpeedIncrease() { }

	// RVA: 0x45B320 Offset: 0x459920 VA: 0x18045B320
	private void TickDamageIncrease() { }

	// RVA: 0x45B170 Offset: 0x459770 VA: 0x18045B170
	private void OnDamage(PlayerHealth ph, DamageContainer dc, bool brokeShield) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45B7D0 Offset: 0x459DD0 VA: 0x18045B7D0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityStonks : PassiveAbility // TypeDefIndex: 5635
{
	// Fields
	private float goldIncreasePerLevel; // 0x18
	private float damageIncreasePer1000Gold; // 0x1C
	private float damagePer1000Gold_First10k; // 0x20
	private float damagePer1000Gold_First200k; // 0x24
	private float damagePer1000Gold_First1m; // 0x28
	private float damagePer1000Gold_After1m; // 0x2C
	private float nextUpdateTime; // 0x30
	private float updateCooldown; // 0x34
	private float lastValue; // 0x38

	// Methods

	// RVA: 0x45BCB0 Offset: 0x45A2B0 VA: 0x18045BCB0 Slot: 4
	public override void Init() { }

	// RVA: 0x45B960 Offset: 0x459F60 VA: 0x18045B960
	private float GetDamage() { }

	// RVA: 0x45BE90 Offset: 0x45A490 VA: 0x18045BE90 Slot: 6
	public override void Tick() { }

	// RVA: 0x45BE00 Offset: 0x45A400 VA: 0x18045BE00
	private void OnLevelup(int level) { }

	// RVA: 0x45B810 Offset: 0x459E10 VA: 0x18045B810 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x45BCA0 Offset: 0x45A2A0 VA: 0x18045BCA0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45BA60 Offset: 0x45A060 VA: 0x18045BA60 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x45C0B0 Offset: 0x45A6B0 VA: 0x18045C0B0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityVampire : PassiveAbility // TypeDefIndex: 5636
{
	// Fields
	private float lifestealPerLevel; // 0x18

	// Methods

	// RVA: 0x45C400 Offset: 0x45AA00 VA: 0x18045C400 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x45C550 Offset: 0x45AB50 VA: 0x18045C550
	private void OnLevelup(int level) { }

	// RVA: 0x45C0F0 Offset: 0x45A6F0 VA: 0x18045C0F0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45C240 Offset: 0x45A840 VA: 0x18045C240 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x455270 Offset: 0x453870 VA: 0x180455270
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityWallClimb : PassiveAbility // TypeDefIndex: 5637
{
	// Fields
	private float hpPerLevel; // 0x18

	// Methods

	// RVA: 0x45C8E0 Offset: 0x45AEE0 VA: 0x18045C8E0 Slot: 4
	public override void Init() { }

	// RVA: 0x45CA30 Offset: 0x45B030 VA: 0x18045CA30
	private void OnLevelup(int level) { }

	// RVA: 0x45C5E0 Offset: 0x45ABE0 VA: 0x18045C5E0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45C730 Offset: 0x45AD30 VA: 0x18045C730 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x45CAC0 Offset: 0x45B0C0 VA: 0x18045CAC0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityWarrior : PassiveAbility // TypeDefIndex: 5638
{
	// Fields
	private float damagePerLevel; // 0x18

	// Methods

	// RVA: 0x45CDD0 Offset: 0x45B3D0 VA: 0x18045CDD0 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void Tick() { }

	// RVA: 0x45CF20 Offset: 0x45B520 VA: 0x18045CF20
	private void OnLevelup(int level) { }

	// RVA: 0x45CAD0 Offset: 0x45B0D0 VA: 0x18045CAD0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45CC20 Offset: 0x45B220 VA: 0x18045CC20 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x45CFB0 Offset: 0x45B5B0 VA: 0x18045CFB0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Implementations
public class PassiveAbilityZooma : PassiveAbility // TypeDefIndex: 5639
{
	// Fields
	private float chargePerMeter; // 0x18
	private float checkInterval; // 0x1C
	private float nextCheckTime; // 0x20
	private Vector3 lastPos; // 0x24
	private float accumulatedCharge; // 0x30
	private float attractionAddPerLevel; // 0x34
	private DamageContainer reuseDc; // 0x38
	private string damageSource; // 0x40

	// Methods

	// RVA: 0x45D450 Offset: 0x45BA50 VA: 0x18045D450 Slot: 4
	public override void Init() { }

	// RVA: 0x45CFC0 Offset: 0x45B5C0 VA: 0x18045CFC0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x45DAC0 Offset: 0x45C0C0 VA: 0x18045DAC0
	private void OnLevelup(int level) { }

	// RVA: 0x45D6C0 Offset: 0x45BCC0 VA: 0x18045D6C0
	private void OnEnemyDamage(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x45D230 Offset: 0x45B830 VA: 0x18045D230
	private float GetDamage() { }

	// RVA: 0x45DB50 Offset: 0x45C150 VA: 0x18045DB50 Slot: 6
	public override void Tick() { }

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0
	public float GetProgress() { }

	// RVA: 0x412DA0 Offset: 0x4113A0 VA: 0x180412DA0 Slot: 7
	public override EPassive GetPassiveType() { }

	// RVA: 0x45D2A0 Offset: 0x45B8A0 VA: 0x18045D2A0 Slot: 8
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x45DD40 Offset: 0x45C340 VA: 0x18045DD40
	public void .ctor() { }
}

