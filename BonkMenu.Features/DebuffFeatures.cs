using Il2CppAssets.Scripts.Actors;
using Il2CppAssets.Scripts.Actors.Enemies;
using Il2CppAssets.Scripts.Game.Combat.EnemyDebuffs;
using Il2CppAssets.Scripts.Managers;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace BonkMenu.Features;

/// <summary>
/// Applies and clears debuffs on enemies.
/// </summary>
public static class DebuffFeatures
{
    /// <summary>
    /// Applies a debuff by id to all living enemies.
    /// </summary>
    public static void ApplyDebuff(int debuffId, string debuffName)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		BonkMenu.Core.Log.Info($"[ApplyDebuff] Applying debuff: {debuffName} (ID: {debuffId})");
		try
		{
			EnemyManager instance = EnemyManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[ApplyDebuff] EnemyManager.Instance is null!");
				return;
			}
			Dictionary<uint, Enemy> enemies = instance.enemies;
			if (enemies == null)
			{
				MelonLogger.Error("[ApplyDebuff] Enemy list is null!");
				return;
			}
			if (enemies.Count == 0)
			{
				MelonLogger.Warning("[ApplyDebuff] No enemies found to apply debuff to");
				return;
			}
			BonkMenu.Core.Log.Info($"[ApplyDebuff] Found {enemies.Count} enemies");
			EDebuff val = (EDebuff)(1 << debuffId);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			var enumerator = enemies.GetEnumerator();
			while (enumerator.MoveNext())
			{
				KeyValuePair<uint, Enemy> current = enumerator.Current;
				try
				{
					Enemy value = current.Value;
					if ((Object)(object)value == (Object)null)
					{
						num3++;
						continue;
					}
					if (value.IsDead())
					{
						num2++;
						continue;
					}
					value.AddDebuff(val, (DamageContainer)null, 10f, 1);
					num++;
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[ApplyDebuff] Error applying to individual enemy: " + ex.Message);
				}
			}
			BonkMenu.Core.Log.Info($"[ApplyDebuff] Results - Applied: {num}, Dead: {num2}, Null: {num3}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[ApplyDebuff] CRITICAL ERROR applying " + debuffName + ": " + ex2.Message);
			MelonLogger.Error("[ApplyDebuff] Stack Trace: " + ex2.StackTrace);
		}
	}

    /// <summary>
    /// Clears all debuffs from living enemies.
    /// </summary>
    public static void RemoveAllDebuffs()
	{
		BonkMenu.Core.Log.Info("[RemoveAllDebuffs] Clearing all debuffs from enemies");
		try
		{
			EnemyManager instance = EnemyManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[RemoveAllDebuffs] EnemyManager.Instance is null!");
				return;
			}
			Dictionary<uint, Enemy> enemies = instance.enemies;
			if (enemies == null)
			{
				MelonLogger.Warning("[RemoveAllDebuffs] Enemy list is null!");
				return;
			}
			if (enemies.Count == 0)
			{
				MelonLogger.Warning("[RemoveAllDebuffs] No enemies found");
				return;
			}
			BonkMenu.Core.Log.Info($"[RemoveAllDebuffs] Found {enemies.Count} enemies");
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			var enumerator = enemies.GetEnumerator();
			while (enumerator.MoveNext())
			{
				KeyValuePair<uint, Enemy> current = enumerator.Current;
				try
				{
					Enemy value = current.Value;
					if ((Object)(object)value == (Object)null)
					{
						num3++;
						continue;
					}
					if (value.IsDead())
					{
						num2++;
						continue;
					}
					value.QueueClearAllDebuffs();
					num++;
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[RemoveAllDebuffs] Error clearing debuffs from individual enemy: " + ex.Message);
				}
			}
			BonkMenu.Core.Log.Info($"[RemoveAllDebuffs] Results - Cleared: {num}, Dead: {num2}, Null: {num3}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[RemoveAllDebuffs] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[RemoveAllDebuffs] Stack Trace: " + ex2.StackTrace);
		}
	}
}
