using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Features;

/// <summary>
/// Applies temporary status effects to the player.
/// </summary>
public static class StatusEffects
{
    /// <summary>
    /// Applies Rage for the specified duration.
    /// </summary>
    public static void ApplyRage(float duration = 30f)
	{
		ApplyStatusEffect((EStatusEffect)1, duration, "Rage");
	}

    /// <summary>
    /// Applies Haste for the specified duration.
    /// </summary>
    public static void ApplyHaste(float duration = 30f)
	{
		ApplyStatusEffect((EStatusEffect)0, duration, "Haste");
	}

    /// <summary>
    /// Applies Shield for the specified duration.
    /// </summary>
    public static void ApplyShield(float duration = 30f)
	{
		ApplyStatusEffect((EStatusEffect)2, duration, "Shield");
	}

    /// <summary>
    /// Applies Invulnerability for the specified duration.
    /// </summary>
    public static void ApplyInvulnerability(float duration = 10f)
	{
		ApplyStatusEffect((EStatusEffect)5, duration, "Invulnerability");
	}

	private static void ApplyStatusEffect(EStatusEffect effectType, float duration, string effectName)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		try
		{
			GameManager instance = GameManager.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				MyPlayer player = instance.player;
				if (player == null)
				{
					obj = null;
				}
				else
				{
					PlayerInventory inventory = player.inventory;
					obj = ((inventory != null) ? inventory.statusEffects : null);
				}
			}
			PlayerStatusEffects val = (PlayerStatusEffects)obj;
			if (val != null)
			{
				StatusEffect val2 = new StatusEffect(effectType, Time.time + duration, (Il2CppReferenceArray<StatModifier>)null);
				val.AddNewEffect(val2, duration);
				MelonLogger.Msg("Applied " + effectName + " buff!");
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Error(effectName + " buff failed: " + ex.Message);
		}
	}
}
