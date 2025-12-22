using System;
using System.Collections.Generic;
using HarmonyLib;
using BonkMenu.Core;
using BonkMenu.Features;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Enemies;
using Il2CppAssets.Scripts.Managers;
using Il2CppAssets.Scripts.Game.Other;
using Il2CppAssets.Scripts.Game.Spawning;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Inventory.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Game.Spawning.New;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Patches;

/// <summary>
/// Direct patches for enemy scaling logic to ensure mod modifiers are applied.
/// Many of these stats aren't natively read from PlayerStats by the game, so we force them here.
/// </summary>
public static class EnemyScalingPatches
{
    private static float GetModMultiplier(EStat stat)
    {
        if (StatsPatches._customStatOffsets.TryGetValue(stat, out float offset))
        {
            return PlayerStatsNew.GetBaseValue(stat) + offset;
        }
        return 1f;
    }
    
    private static float GetDifficultyMultiplier()
    {
        return GetModMultiplier((EStat)38);
    }
    
    private static float GetSpawnRateMultiplier()
    {
        float mult = StatsHelper.GetCurrentStatValue((EStat)57, 1f);
        if (mult < 0f) mult = 0f;
        return mult;
    }
    
    private static bool _isExtraSpawn = false;

    // --- HP Patches ---
    [HarmonyPatch(typeof(RunConfig), nameof(RunConfig.GetEnemyHp))]
    public static class RunConfig_GetEnemyHp_Patch
    {
        public static void Postfix(ref float __result)
        {
            float mult = GetModMultiplier((EStat)53);
            float diff = GetDifficultyMultiplier();
            if (mult != 1f && mult > 0) __result *= mult;
            if (diff != 1f && diff > 0) __result *= diff;
        }
    }

    [HarmonyPatch(typeof(EnemyStats), nameof(EnemyStats.GetHp))]
    public static class EnemyStats_GetHp_Patch
    {
        public static void Postfix(ref float __result)
        {
            float mult = GetModMultiplier((EStat)53);
            float diff = GetDifficultyMultiplier();
            if (mult != 1f && mult > 0) __result *= mult;
            if (diff != 1f && diff > 0) __result *= diff;
        }
    }

    // --- Damage Patches ---
    [HarmonyPatch(typeof(RunConfig), nameof(RunConfig.GetEnemyDamage))]
    public static class RunConfig_GetEnemyDamage_Patch
    {
        public static void Postfix(ref float __result)
        {
            float mult = GetModMultiplier((EStat)54);
            float diff = GetDifficultyMultiplier();
            if (mult != 1f && mult > 0) __result *= mult;
            if (diff != 1f && diff > 0) __result *= diff;
        }
    }

    [HarmonyPatch(typeof(EnemyStats), nameof(EnemyStats.GetDamage))]
    public static class EnemyStats_GetDamage_Patch
    {
        public static void Postfix(ref float __result)
        {
            float mult = GetModMultiplier((EStat)54);
            float diff = GetDifficultyMultiplier();
            if (mult != 1f && mult > 0) __result *= mult;
            if (diff != 1f && diff > 0) __result *= diff;
        }
    }

    // --- Speed Patches ---
    [HarmonyPatch(typeof(RunConfig), nameof(RunConfig.GetEnemySpeed))]
    public static class RunConfig_GetEnemySpeed_Patch
    {
        public static void Postfix(ref float __result)
        {
            float mult = GetModMultiplier((EStat)52);
            float diff = GetDifficultyMultiplier();
            if (mult != 1f && mult > 0) __result *= mult;
            if (diff != 1f && diff > 0) __result *= diff;
        }
    }

    [HarmonyPatch(typeof(EnemyStats), nameof(EnemyStats.GetSpeed))]
    public static class EnemyStats_GetSpeed_Patch
    {
        public static void Postfix(ref float __result)
        {
            float mult = GetModMultiplier((EStat)52);
            float diff = GetDifficultyMultiplier();
            if (mult != 1f && mult > 0) __result *= mult;
            if (diff != 1f && diff > 0) __result *= diff;
        }
    }

    // --- Other Modifiers ---
    [HarmonyPatch(typeof(Enemy), nameof(Enemy.InitEnemy))]
    public static class Enemy_InitEnemy_Patch
    {
        public static void Prefix(ref float extraSizeMultiplier)
        {
            float mult = GetModMultiplier((EStat)51);
            if (mult != 1f && mult > 0) extraSizeMultiplier *= mult;
        }
    }

    [HarmonyPatch(typeof(EnemyWave), nameof(EnemyWave.EnemiesPerSecond))]
    public static class EnemyWave_EnemiesPerSecond_Patch
    {
        public static void Postfix(ref float __result)
        {
            float mult = GetSpawnRateMultiplier();
            if (mult > 0f && mult != 1f) __result *= mult;
        }
    }

    [HarmonyPatch(typeof(EnemyStats), nameof(EnemyStats.GetEliteChance))]
    public static class EnemyStats_GetEliteChance_Patch
    {
        public static void Postfix(ref float __result)
        {
            if (StatsPatches._customStatOffsets.TryGetValue((EStat)39, out float offset))
            {
                if (offset != 0f) __result += offset;
            }
        }
    }

    [HarmonyPatch(typeof(PlayerInventory), nameof(PlayerInventory.AddXp))]
    public static class PlayerInventory_AddXp_Patch
    {
        public static void Prefix(ref int amount)
        {
            float mult = GetModMultiplier((EStat)32);
            if (mult > 1f) amount = (int)(amount * mult);
        }
    }

    private static bool ShouldAffectSpawn(EnemyData enemyData, int waveNumber, bool forceSpawn, EEnemyFlag flag, bool canBeElite)
    {
        if (flag != 0)
        {
            return false;
        }
        if ((Object)enemyData != (Object)null)
        {
            string name = ((Object)enemyData).name;
            if (!string.IsNullOrEmpty(name))
            {
                string lower = name.ToLowerInvariant();
                if (lower.Contains("boss") || lower.Contains("shrine"))
                {
                    return false;
                }
            }
        }
        return true;
    }

    [HarmonyPatch(typeof(EnemyManager), "SpawnEnemy", new Type[] { typeof(EnemyData), typeof(Vector3), typeof(int), typeof(bool), typeof(EEnemyFlag), typeof(bool), typeof(float) })]
    public static class EnemyManager_SpawnEnemy_Patch
    {
        public static bool Prefix(EnemyData enemyData, Vector3 pos, int waveNumber, bool forceSpawn, EEnemyFlag flag, bool canBeElite, float extraSizeMultiplier)
        {
            if (_isExtraSpawn) return true;
            if (!ShouldAffectSpawn(enemyData, waveNumber, forceSpawn, flag, canBeElite)) return true;
            float mult = GetSpawnRateMultiplier();
            if (mult < 1f && mult > 0f)
            {
                if (UnityEngine.Random.value > mult) return false;
            }
            return true;
        }
        
        public static void Postfix(EnemyManager __instance, Enemy __result, EnemyData enemyData, Vector3 pos, int waveNumber, bool forceSpawn, EEnemyFlag flag, bool canBeElite, float extraSizeMultiplier)
        {
            return;
        }
    }
    
    [HarmonyPatch(typeof(EnemyManager), nameof(EnemyManager.GetNumMaxEnemies))]
    public static class EnemyManager_GetNumMaxEnemies_Patch
    {
        public static void Postfix(ref int __result)
        {
            float mult = GetSpawnRateMultiplier();
            if (mult <= 0f)
            {
                __result = 0;
                return;
            }

            if (mult > 1f)
            {
                __result = int.MaxValue;
            }
        }
    }

    [HarmonyPatch(typeof(BaseSummoner), nameof(BaseSummoner.Tick))]
    public static class BaseSummoner_Tick_Patch
    {
        private static readonly Dictionary<nint, float> _lastBudgets = new Dictionary<nint, float>();

        public static void Prefix(BaseSummoner __instance)
        {
            try
            {
                unsafe
                {
                    nint ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)__instance);
                    float* budgetPtr = (float*)(ptr + 0x10);
                    float current = *budgetPtr;
                    _lastBudgets[ptr] = current;
                }
            }
            catch (Exception ex)
            {
                Log.Warn("BaseSummoner Tick Prefix error: " + ex.Message);
            }
        }

        public static void Postfix(BaseSummoner __instance)
        {
            try
            {
                float mult = GetSpawnRateMultiplier();
                if (mult <= 1f) return;
                unsafe
                {
                    nint ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)__instance);
                    float* budgetPtr = (float*)(ptr + 0x10);
                    float newBudget = *budgetPtr;
                    if (!_lastBudgets.TryGetValue(ptr, out float oldBudget))
                    {
                        oldBudget = newBudget;
                    }
                    float delta = newBudget - oldBudget;
                    if (delta <= 0f) return;
                    float adjusted = oldBudget + delta * mult;
                    *budgetPtr = adjusted;
                }
            }
            catch (Exception ex)
            {
                Log.Warn("BaseSummoner Tick Postfix error: " + ex.Message);
            }
        }
    }
    
}
