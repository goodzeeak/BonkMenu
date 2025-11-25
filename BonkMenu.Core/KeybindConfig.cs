using System;
using System.IO;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Core;

public static class KeybindConfig
{
	private static string ConfigPath => "UserData/BonkMenu_Keybinds.txt";

	// F1 - Toggle Menu (only keybind for now)
	public static KeyCode ToggleMenuKey { get; set; } = (KeyCode)282;

	public static void SaveKeybinds()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string directoryName = Path.GetDirectoryName(ConfigPath);
			if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			string[] contents = new string[1]
			{
				$"ToggleMenu={ToggleMenuKey}"
			};
			File.WriteAllLines(ConfigPath, contents);
			MelonLogger.Msg("Keybinds saved successfully");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("Failed to save keybinds: " + ex.Message);
		}
	}

	public static void LoadKeybinds()
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!File.Exists(ConfigPath))
			{
				MelonLogger.Msg("No keybind config found, using defaults");
				return;
			}
			string[] array = File.ReadAllLines(ConfigPath);
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split('=');
				if (array3.Length != 2)
				{
					continue;
				}
				string text2 = array3[0].Trim();
				if (Enum.TryParse<KeyCode>(array3[1].Trim(), out KeyCode result))
				{
					if (text2 == "ToggleMenu")
					{
						ToggleMenuKey = result;
					}
				}
			}
			MelonLogger.Msg("Keybinds loaded successfully");
		}
		catch (Exception ex)
		{
			MelonLogger.Error("Failed to load keybinds: " + ex.Message);
		}
	}
}
