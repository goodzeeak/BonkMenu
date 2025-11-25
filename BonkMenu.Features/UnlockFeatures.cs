using System;
using Il2Cpp;
using Il2CppAssets.Scripts.Managers;
using Il2CppAssets.Scripts.Saves___Serialization.Progression;
using Il2CppAssets.Scripts.Saves___Serialization.Progression.Achievements;
using Il2CppAssets.Scripts.Saves___Serialization.SaveFiles;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnityEngine;
using UniverseLib;

namespace BonkMenu.Features;

public static class UnlockFeatures
{
	public static void UnlockAllCharacters()
	{
		MelonLogger.Msg("[UnlockAllCharacters] Starting unlock all characters");
		UnlockAll<UnlockableBase>("characters");
	}

	public static void UnlockAllSkins()
	{
		MelonLogger.Msg("[UnlockAllSkins] Starting unlock all skins");
		try
		{
			DataManager instance = DataManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[UnlockAllSkins] DataManager.Instance is null!");
				return;
			}
			SaveManager instance2 = SaveManager.Instance;
			if ((Object)(object)instance2 == (Object)null)
			{
				MelonLogger.Error("[UnlockAllSkins] SaveManager.Instance is null!");
				return;
			}
			ProgressionSaveFile progression = instance2.progression;
			if (progression == null)
			{
				MelonLogger.Error("[UnlockAllSkins] Progression save file is null!");
				return;
			}
			List<SkinData> unsortedSkins = instance.unsortedSkins;
			if (unsortedSkins == null)
			{
				MelonLogger.Error("[UnlockAllSkins] UnsortedSkins is null!");
				return;
			}
			MelonLogger.Msg($"[UnlockAllSkins] Found {unsortedSkins.Count} total skins");
			int num = 0;
			int num2 = 0;
			var enumerator = unsortedSkins.GetEnumerator();
			while (enumerator.MoveNext())
			{
				SkinData current = enumerator.Current;
				try
				{
					if (!((Object)(object)current == (Object)null))
					{
						string text = ((UnlockableBase)current).GetInternalName();
						if (string.IsNullOrEmpty(text))
						{
							text = ((Object)current).name;
						}
						if (!progression.purchases.Contains(text))
						{
							progression.purchases.Add(text);
							ProgressionSaveFile.A_UnlockablePurchased?.Invoke((UnlockableBase)(object)current);
							num++;
						}
						else
						{
							num2++;
						}
						MyAchievement unlockRequirement = ((UnlockableBase)current).GetUnlockRequirement();
						if ((Object)(object)unlockRequirement != (Object)null)
						{
							progression.CompleteAchievement(unlockRequirement);
							progression.ClaimAchievement(unlockRequirement);
						}
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[UnlockAllSkins] Error processing skin: " + ex.Message);
				}
			}
			instance2.SaveProgression();
			ButtonManager.Refresh();
			MelonLogger.Msg($"[UnlockAllSkins] Results - Unlocked: {num}, Already Unlocked: {num2}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[UnlockAllSkins] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[UnlockAllSkins] Stack Trace: " + ex2.StackTrace);
		}
	}

	public static void MaxRankAllCharacters()
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		MelonLogger.Msg("[MaxRankAllCharacters] Starting max rank all characters");
		try
		{
			DataManager instance = DataManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[MaxRankAllCharacters] DataManager.Instance is null!");
				return;
			}
			SaveManager instance2 = SaveManager.Instance;
			if ((Object)(object)instance2 == (Object)null)
			{
				MelonLogger.Error("[MaxRankAllCharacters] SaveManager.Instance is null!");
				return;
			}
			ProgressionSaveFile progression = instance2.progression;
			if (progression == null)
			{
				MelonLogger.Error("[MaxRankAllCharacters] Progression save file is null!");
				return;
			}
			List<CharacterData> unsortedCharacterData = instance.unsortedCharacterData;
			if (unsortedCharacterData == null)
			{
				MelonLogger.Error("[MaxRankAllCharacters] Uns ortedCharacterData is null!");
				return;
			}
			MelonLogger.Msg($"[MaxRankAllCharacters] Found {unsortedCharacterData.Count} characters");
			int num = 0;
			int num2 = 0;
			var enumerator = unsortedCharacterData.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CharacterData current = enumerator.Current;
				try
				{
					if (!((Object)(object)current == (Object)null))
					{
						if (!progression.characterProgression.ContainsKey(current.eCharacter))
						{
							CharacterProgression val = new CharacterProgression();
							val.xp = 1000000;
							progression.characterProgression.Add(current.eCharacter, val);
							num2++;
						}
						else
						{
							progression.characterProgression[current.eCharacter].xp = 1000000;
						}
						num++;
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[MaxRankAllCharacters] Error processing character: " + ex.Message);
				}
			}
			instance2.SaveProgression();
			MelonLogger.Msg($"[MaxRankAllCharacters] Results - Maxed: {num}, New Entries: {num2}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[MaxRankAllCharacters] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[MaxRankAllCharacters] Stack Trace: " + ex2.StackTrace);
		}
	}

	public static void UnlockAllMaps()
	{
		MelonLogger.Msg("[UnlockAllMaps] Starting unlock all maps");
		UnlockAll<MapData>("maps");
	}

	public static void UnlockEverything()
	{
		MelonLogger.Msg("[UnlockEverything] Starting unlock everything");
		try
		{
			SaveManager instance = SaveManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[UnlockEverything] SaveManager.Instance is null!");
				return;
			}
			ProgressionSaveFile progression = instance.progression;
			if (progression == null)
			{
				MelonLogger.Error("[UnlockEverything] Progression save file is null!");
				return;
			}
			UnlockableBase[] array = RuntimeHelper.FindObjectsOfTypeAll<UnlockableBase>();
			if (array == null)
			{
				MelonLogger.Error("[UnlockEverything] FindObjectsOfTypeAll returned null!");
				return;
			}
			MelonLogger.Msg($"[UnlockEverything] Found {array.Length} unlockable items");
			int num = 0;
			int num2 = 0;
			UnlockableBase[] array2 = array;
			foreach (UnlockableBase val in array2)
			{
				try
				{
					if (!((Object)(object)val == (Object)null))
					{
						string text = val.GetInternalName();
						if (string.IsNullOrEmpty(text))
						{
							text = ((Object)val).name;
						}
						if (!progression.purchases.Contains(text))
						{
							progression.purchases.Add(text);
							num++;
						}
						else
						{
							num2++;
						}
						MyAchievement unlockRequirement = val.GetUnlockRequirement();
						if ((Object)(object)unlockRequirement != (Object)null)
						{
							progression.CompleteAchievement(unlockRequirement);
							progression.ClaimAchievement(unlockRequirement);
						}
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[UnlockEverything] Error processing unlockable: " + ex.Message);
				}
			}
			instance.SaveProgression();
			ButtonManager.Refresh();
			MelonLogger.Msg($"[UnlockEverything] Results - Unlocked: {num}, Already Unlocked: {num2}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[UnlockEverything] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[UnlockEverything] Stack Trace: " + ex2.StackTrace);
		}
	}

	private static void UnlockAll<T>(string label) where T : UnlockableBase
	{
		MelonLogger.Msg("[UnlockAll] Unlocking all " + label);
		try
		{
			SaveManager instance = SaveManager.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				MelonLogger.Error("[UnlockAll<" + label + ">] SaveManager.Instance is null!");
				return;
			}
			ProgressionSaveFile progression = instance.progression;
			if (progression == null)
			{
				MelonLogger.Error("[UnlockAll<" + label + ">] Progression save file is null!");
				return;
			}
			T[] array = RuntimeHelper.FindObjectsOfTypeAll<T>();
			if (array == null)
			{
				MelonLogger.Error("[UnlockAll<" + label + ">] FindObjectsOfTypeAll returned null!");
				return;
			}
			MelonLogger.Msg($"[UnlockAll<{label}>] Found {array.Length} items");
			int num = 0;
			int num2 = 0;
			T[] array2 = array;
			foreach (T val in array2)
			{
				try
				{
					if (!((Object)(object)val == (Object)null))
					{
						string text = ((UnlockableBase)val).GetInternalName();
						if (string.IsNullOrEmpty(text))
						{
							text = ((Object)(object)val).name;
						}
						if (!progression.purchases.Contains(text))
						{
							progression.purchases.Add(text);
							ProgressionSaveFile.A_UnlockablePurchased?.Invoke((UnlockableBase)(object)val);
							num++;
						}
						else
						{
							num2++;
						}
						MyAchievement unlockRequirement = ((UnlockableBase)val).GetUnlockRequirement();
						if ((Object)(object)unlockRequirement != (Object)null)
						{
							progression.CompleteAchievement(unlockRequirement);
							progression.ClaimAchievement(unlockRequirement);
						}
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[UnlockAll<" + label + ">] Error processing item: " + ex.Message);
				}
			}
			instance.SaveProgression();
			ButtonManager.Refresh();
			MelonLogger.Msg($"[UnlockAll<{label}>] Results - Unlocked: {num}, Already Unlocked: {num2}");
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[UnlockAll<" + label + ">] CRITICAL ERROR: " + ex2.Message);
			MelonLogger.Error("[UnlockAll<" + label + ">] Stack Trace: " + ex2.StackTrace);
		}
	}
}
