using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using System.Linq;
using UnityEngine;

namespace BonkMenu.Patches;

/// <summary>
/// Shows uncapped XP multiplier in HUD by patching level text.
/// </summary>
public static class XpDisplayPatch
{
	    /// <summary>
	    /// Postfix for XpBarUI.SetLevelText to replace capped multiplier.
	    /// </summary>
	    [HarmonyPatch(typeof(XpBarUI), "SetLevelText")]
	    public static class XpBarUI_SetLevelText_Patch
	{
        /// <summary>
        /// Rewrites the displayed multiplier using the actual uncapped value.
        /// </summary>
        public static void Postfix(XpBarUI __instance)
		{
			try
			{
				// Access t_levelText field via reflection to avoid TextMeshProUGUI type reference
				var textFieldInfo = __instance.GetType().GetField("t_levelText");
				if (textFieldInfo == null) return;
				
				var textField = textFieldInfo.GetValue(__instance);
				if (textField == null) return;

				// Get the text property
				var textProp = textField.GetType().GetProperty("text");
				if (textProp == null) return;
				
				string currentText = (string)textProp.GetValue(textField);
				if (string.IsNullOrEmpty(currentText)) return;
				
				// Get the actual XP multiplier from PlayerXp
				float actualMultiplier = GetActualXpMultiplier();
				
				// Only modify if there's a multiplier indicator in the text
				// The game typically shows format like "Level 5  10x"
				if (currentText.Contains("x") && actualMultiplier > 10f)
				{
					// Replace the capped multiplier with actual value
					// Find the multiplier part (e.g., "10x")
					int xIndex = currentText.LastIndexOf('x');
					if (xIndex > 0)
					{
						// Find the start of the number before 'x'
						int startIndex = xIndex - 1;
						while (startIndex > 0 && (char.IsDigit(currentText[startIndex]) || currentText[startIndex] == '.'))
						{
							startIndex--;
						}
						startIndex++; // Move back to first digit

						// Extract the level part
						string beforeMultiplier = currentText.Substring(0, startIndex);
						
						// Format new text with actual multiplier
						string newText = $"{beforeMultiplier}{Mathf.RoundToInt(actualMultiplier)}x";
						textProp.SetValue(textField, newText);
					}
				}
			}
			catch (System.Exception ex)
			{
				MelonLogger.Warning($"[XpDisplayPatch] Error in SetLevelText postfix: {ex.Message}");
			}
		}

		private static float GetActualXpMultiplier()
		{
			try
			{
				// Access the static maxXpMultiplier field from PlayerXp via reflection
				// The type is in Inventory__Items__Pickups.Xp_and_Levels namespace
				var assemblies = System.AppDomain.CurrentDomain.GetAssemblies();
				System.Type playerXpType = null;
				
				foreach (var asm in assemblies)
				{
					try
					{
						playerXpType = asm.GetTypes().FirstOrDefault(t => t.Name == "PlayerXp" && t.Namespace?.Contains("Xp_and_Levels") == true);
						if (playerXpType != null) break;
					}
					catch { }
				}
				
				if (playerXpType != null)
				{
					var field = playerXpType.GetField("maxXpMultiplier", 
						System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
					
					if (field != null)
					{
						var value = field.GetValue(null);
						if (value != null)
						{
							return (float)value;
						}
					}
				}
			}
			catch (System.Exception ex)
			{
				MelonLogger.Warning($"[XpDisplayPatch] Could not retrieve actual XP multiplier: {ex.Message}");
			}

			return 10f; // Default fallback
		}
	}

    /// <summary>
    /// Applies the XpBarUI patches.
    /// </summary>
    public static void Apply(HarmonyLib.Harmony harmony)
	{
		try
		{
			harmony.PatchAll(typeof(XpBarUI_SetLevelText_Patch));
			MelonLogger.Msg("[XpDisplayPatch] ✅ XpBarUI.SetLevelText patched - will show uncapped XP multiplier");
		}
		catch (System.Exception ex)
		{
			MelonLogger.Error($"[XpDisplayPatch] Failed to patch XpBarUI.SetLevelText: {ex.Message}");
		}
	}
}
