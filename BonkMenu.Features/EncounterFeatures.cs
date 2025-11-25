using System;
using Il2CppAssets.Scripts.UI.InGame.Levelup;
using Il2CppAssets.Scripts.UI.InGame.Rewards;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Features;

public static class EncounterFeatures
{
	public static void ForceEncounter(int encounterId, string encounterName)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg($"[ForceEncounter] Forcing encounter: {encounterName} (ID: {encounterId})");
		try
		{
			EncounterWindows val = Object.FindObjectOfType<EncounterWindows>();
			if ((Object)(object)val == (Object)null)
			{
				MelonLogger.Warning("[ForceEncounter] EncounterWindows not found - are you in a run?");
				return;
			}
			MelonLogger.Msg("[ForceEncounter] EncounterWindows found");
			EEncounter val2 = (EEncounter)encounterId;
			MelonLogger.Msg($"[ForceEncounter] Adding encounter: {val2}");
			val.AddEncounter(val2);
			MelonLogger.Msg("[ForceEncounter] Successfully forced encounter: " + encounterName);
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[ForceEncounter] CRITICAL ERROR forcing " + encounterName + ": " + ex.Message);
			MelonLogger.Error("[ForceEncounter] Stack Trace: " + ex.StackTrace);
		}
	}

	public static void SkipEncounter()
	{
		MelonLogger.Msg("[SkipEncounter] Attempting to skip current encounter");
		try
		{
			EncounterWindows val = Object.FindObjectOfType<EncounterWindows>();
			if ((Object)(object)val == (Object)null)
			{
				MelonLogger.Warning("[SkipEncounter] EncounterWindows not found - are you in a run?");
				return;
			}
			MelonLogger.Msg("[SkipEncounter] EncounterWindows found");
			if (!val.encounterInProgress)
			{
				MelonLogger.Warning("[SkipEncounter] No encounter currently in progress");
				return;
			}
			MelonLogger.Msg("[SkipEncounter] Encounter in progress, calling RewardFinished()");
			val.RewardFinished();
			MelonLogger.Msg("[SkipEncounter] Successfully skipped encounter");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("[SkipEncounter] CRITICAL ERROR: " + ex.Message);
			MelonLogger.Error("[SkipEncounter] Stack Trace: " + ex.StackTrace);
		}
	}
}
