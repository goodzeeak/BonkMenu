using System;
using System.IO;
using MelonLoader;
using UnityEngine;

namespace BonkMenu.Core;

public static class KeybindConfig
{
	private static string ConfigPath => "UserData/BonkMenu_Keybinds.txt";

	public static KeyCode ToggleMenuKey { get; set; } = (KeyCode)282;

	public static KeyCode GodModeKey { get; set; } = (KeyCode)277;

	public static KeyCode AddGoldKey { get; set; } = (KeyCode)278;

	public static KeyCode KillEnemiesKey { get; set; } = (KeyCode)127;

	public static KeyCode SpawnEnemyKey { get; set; } = (KeyCode)279;

	public static void SaveKeybinds()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string directoryName = Path.GetDirectoryName(ConfigPath);
			if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			string[] contents = new string[5]
			{
				$"ToggleMenu={ToggleMenuKey}",
				$"GodMode={GodModeKey}",
				$"AddGold={AddGoldKey}",
				$"KillEnemies={KillEnemiesKey}",
				$"SpawnEnemy={SpawnEnemyKey}"
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
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
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
					switch (text2)
					{
					case "ToggleMenu":
						ToggleMenuKey = result;
						break;
					case "GodMode":
						GodModeKey = result;
						break;
					case "AddGold":
						AddGoldKey = result;
						break;
					case "KillEnemies":
						KillEnemiesKey = result;
						break;
					case "SpawnEnemy":
						SpawnEnemyKey = result;
						break;
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
