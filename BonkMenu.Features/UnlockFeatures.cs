using Il2Cpp;
using Il2CppAssets.Scripts.Managers;
using Il2CppAssets.Scripts.Saves___Serialization.Progression;
using Il2CppAssets.Scripts.Saves___Serialization.Progression.Achievements;
using Il2CppAssets.Scripts.Saves___Serialization.Progression.Unlocks;
using Il2CppAssets.Scripts.Saves___Serialization.SaveFiles;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UniverseLib;

namespace BonkMenu.Features;

/// <summary>
/// Unlocks characters, skins, maps, and all unlockables.
/// </summary>
public static class UnlockFeatures
{
    /// <summary>
    /// Unlocks all characters.
    /// </summary>
    public static void UnlockAllCharacters()
	{
		MelonLogger.Msg("[UnlockAllCharacters] Starting unlock all characters");
		try
		{
			DataManager dm = DataManager.Instance;
			SaveManager sm = SaveManager.Instance;
			if ((Object)(object)dm == (Object)null || (Object)(object)sm == (Object)null || sm.progression == null)
			{
				MelonLogger.Error("[UnlockAllCharacters] Missing managers or progression");
				return;
			}
			ProgressionSaveFile progression = sm.progression;
			List<CharacterData> list = dm.unsortedCharacterData;
			if (list == null)
			{
				MelonLogger.Error("[UnlockAllCharacters] No character list");
				return;
			}
			int added = 0;
			int existing = 0;
			var it = list.GetEnumerator();
			while (it.MoveNext())
			{
				CharacterData cur = it.Current;
				if ((Object)(object)cur == (Object)null) continue;
				bool already = MyAchievements.IsPurchased((UnlockableBase)(object)cur);
				string name = ((UnlockableBase)(object)cur).GetInternalName();
				if (!already && !progression.purchases.Contains(name))
				{
					progression.purchases.Add(name);
					ProgressionSaveFile.A_UnlockablePurchased?.Invoke((UnlockableBase)(object)cur);
					added++;
				}
				else existing++;
			}
			sm.SaveProgression();
			ButtonManager.Refresh();
			MelonLogger.Msg($"[UnlockAllCharacters] Results - Unlocked: {added}, Already Unlocked: {existing}");
		}
		catch (Exception e)
		{
			MelonLogger.Error("[UnlockAllCharacters] ERROR: " + e.Message);
		}
	}

    /// <summary>
    /// Unlocks all skins.
    /// </summary>
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

    /// <summary>
    /// Sets maximum rank XP for all characters.
    /// </summary>
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

    /// <summary>
    /// Unlocks all maps.
    /// </summary>
    public static void UnlockAllMaps()
	{
		MelonLogger.Msg("[UnlockAllMaps] Starting unlock all maps");
		try
		{
			DataManager dm = DataManager.Instance;
			SaveManager sm = SaveManager.Instance;
			if ((Object)(object)dm == (Object)null || (Object)(object)sm == (Object)null || sm.progression == null)
			{
				MelonLogger.Error("[UnlockAllMaps] Missing managers or progression");
				return;
			}
			ProgressionSaveFile progression = sm.progression;
			List<MapData> maps = dm.maps;
			if (maps == null)
			{
				MelonLogger.Error("[UnlockAllMaps] No maps list");
				return;
			}
			int added = 0;
			int existing = 0;
			var it = maps.GetEnumerator();
			while (it.MoveNext())
			{
				MapData cur = it.Current;
				if ((Object)(object)cur == (Object)null) continue;
				bool already = MyAchievements.IsPurchased((UnlockableBase)(object)cur);
				string name = ((UnlockableBase)(object)cur).GetInternalName();
				if (!already && !progression.purchases.Contains(name))
				{
					progression.purchases.Add(name);
					ProgressionSaveFile.A_UnlockablePurchased?.Invoke((UnlockableBase)(object)cur);
					added++;
				}
				else existing++;
			}
			sm.SaveProgression();
			ButtonManager.Refresh();
			MelonLogger.Msg($"[UnlockAllMaps] Results - Unlocked: {added}, Already Unlocked: {existing}");
		}
		catch (Exception e)
		{
			MelonLogger.Error("[UnlockAllMaps] ERROR: " + e.Message);
		}
	}

    /// <summary>
    /// Unlocks every unlockable item and claims achievements.
    /// </summary>
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
			DataManager dm = DataManager.Instance;
			if ((Object)(object)dm == (Object)null)
			{
				MelonLogger.Error("[UnlockEverything] DataManager.Instance is null!");
				return;
			}
			List<UnlockableBase> all = dm.GetAllPurchasable();
			if (all == null)
			{
				MelonLogger.Error("[UnlockEverything] GetAllPurchasable returned null!");
				return;
			}
			MelonLogger.Msg($"[UnlockEverything] Found {all.Count} purchasables");
			int num = 0;
			int num2 = 0;
			var it = all.GetEnumerator();
			while (it.MoveNext())
			{
				try
				{
					UnlockableBase val = it.Current;
					if (!((Object)(object)val == (Object)null))
					{
						string text = val.GetInternalName();
						if (string.IsNullOrEmpty(text))
						{
							text = ((Object)val).name;
						}
						bool already = MyAchievements.IsPurchased(val);
						if (!already && !progression.purchases.Contains(text))
						{
							progression.purchases.Add(text);
							ProgressionSaveFile.A_UnlockablePurchased?.Invoke(val);
							num++;
						}
						else
						{
							num2++;
						}
						MyAchievement unlockRequirement = val.GetUnlockRequirement();
						if ((Object)(object)unlockRequirement != (Object)null)
						{
							bool done = progression.achievements != null && progression.achievements.Contains(unlockRequirement.internalName);
							bool claimed = progression.claimedAchievements != null && progression.claimedAchievements.Contains(unlockRequirement.internalName);
							if (!done) progression.CompleteAchievement(unlockRequirement);
							if (!claimed) progression.ClaimAchievement(unlockRequirement);
						}
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning("[UnlockEverything] Error processing unlockable: " + ex.Message);
				}
			}

			UnlockAllShopItems();
			CompleteAndClaimAllAchievements();
			EnsureMenusUnlocked();
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

	private static void UnlockAllShopItems()
	{
		MelonLogger.Msg("[UnlockAllShopItems] Maxing all shop items");
		try
		{
			DataManager dm = DataManager.Instance;
			SaveManager sm = SaveManager.Instance;
			if ((Object)(object)dm == (Object)null || (Object)(object)sm == (Object)null || sm.progression == null)
			{
				MelonLogger.Error("[UnlockAllShopItems] Missing managers or progression");
				return;
			}
			ProgressionSaveFile progression = sm.progression;
			List<ShopItemData> items = dm.unsortedShopItems;
			if (items == null)
			{
				MelonLogger.Error("[UnlockAllShopItems] No shop item list");
				return;
			}
			int maxed = 0;
			var it = items.GetEnumerator();
			while (it.MoveNext())
			{
				ShopItemData cur = it.Current;
				if ((Object)(object)cur == (Object)null) continue;
				int safety = 0;
				while (!cur.IsMaxLevel() && safety < 1000)
				{
					progression.PurchaseShopItem(cur);
					safety++;
				}
				if (cur.IsMaxLevel()) maxed++;
			}
			MelonLogger.Msg($"[UnlockAllShopItems] Maxed {maxed} shop items");
		}
		catch (Exception e)
		{
			MelonLogger.Error("[UnlockAllShopItems] ERROR: " + e.Message);
		}
	}

	private static void EnsureMenusUnlocked()
	{
		try
		{
			SaveManager sm = SaveManager.Instance;
			if ((Object)(object)sm == (Object)null || sm.progression == null) return;
			if (sm.progression.menuMeta == null) sm.progression.menuMeta = new MenuMeta();
			sm.progression.menuMeta.hasVisitedShop = true;
			sm.progression.menuMeta.hasVisitedUnlocks = true;
			sm.progression.menuMeta.hasVisitedQuests = true;
		}
		catch (Exception e)
		{
			MelonLogger.Warning("[EnsureMenusUnlocked] " + e.Message);
		}
	}

	private static void CompleteAndClaimAllAchievements()
	{
		MelonLogger.Msg("[CompleteAndClaimAllAchievements] Completing and claiming all achievements/quests");
		try
		{
			DataManager dm = DataManager.Instance;
			SaveManager sm = SaveManager.Instance;
			if ((Object)(object)dm == (Object)null || (Object)(object)sm == (Object)null || sm.progression == null)
			{
				MelonLogger.Error("[CompleteAndClaimAllAchievements] Missing managers or progression");
				return;
			}
			ProgressionSaveFile progression = sm.progression;
			List<MyAchievement> achs = dm.unsortedAchievements;
			if (achs == null)
			{
				MelonLogger.Error("[CompleteAndClaimAllAchievements] No achievements list");
				return;
			}
			int completed = 0;
			int claimed = 0;
			var it = achs.GetEnumerator();
			while (it.MoveNext())
			{
				MyAchievement cur = it.Current;
				if ((Object)(object)cur == (Object)null) continue;
				string name = cur.internalName;
				bool isDone = progression.achievements != null && progression.achievements.Contains(name);
				bool isClaimed = progression.claimedAchievements != null && progression.claimedAchievements.Contains(name);
				if (!isDone)
				{
					progression.CompleteAchievement(cur);
					completed++;
				}
				if (!isClaimed)
				{
					progression.ClaimAchievement(cur);
					claimed++;
				}
			}
			MelonLogger.Msg($"[CompleteAndClaimAllAchievements] Completed {completed}, Claimed {claimed}");
		}
		catch (Exception e)
		{
			MelonLoader.MelonLogger.Error("[CompleteAndClaimAllAchievements] ERROR: " + e.Message);
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
