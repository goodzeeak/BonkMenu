// Namespace: Assets.Scripts.Settings___Saves.SaveFiles
public class CFControlSettings : CFSettings // TypeDefIndex: 5396
{
	// Fields
	public float sensitivity; // 0x10
	public float look_smoothing; // 0x14
	public float controller_sensitivity; // 0x18
	public int inverted_horizontal_axis; // 0x1C
	public int inverted_vertical_axis; // 0x20
	public int hold_crouch; // 0x24
	public int hold_aim; // 0x28
	public int rotate_camera_with_arrow_keys; // 0x2C
	public int select_upgrades_with_number_keys; // 0x30
	public string keyboard_move_forward; // 0x38
	public string keyboard_move_backward; // 0x40
	public string keyboard_move_left; // 0x48
	public string keyboard_move_right; // 0x50
	public string keyboard_jump; // 0x58
	public string keyboard_interact; // 0x60
	public string keyboard_slide; // 0x68
	public string keyboard_aim; // 0x70
	public string keyboard_quick_reset; // 0x78
	public string map_overlay; // 0x80
	public int controller; // 0x88
	public float controller_vibration; // 0x8C
	public string controller_jump; // 0x90
	public string controller_interact; // 0x98
	public string controller_slide; // 0xA0
	public string controller_aim; // 0xA8
	public string controller_quick_reset; // 0xB0
	public string controller_map_overlay; // 0xB8
	public int pause_on_controller_disconnect; // 0xC0

	// Methods

	// RVA: 0x3D7DA0 Offset: 0x3D63A0 VA: 0x1803D7DA0 Slot: 4
	public List<SettingHeader> GetHeaders() { }

	// RVA: 0x3D80D0 Offset: 0x3D66D0 VA: 0x1803D80D0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Settings___Saves.SaveFiles
[Serializable]
public class CFGameSettings : CFSettings // TypeDefIndex: 5397
{
	// Fields
	public int camera_shake; // 0x10
	public float input_delay; // 0x14
	public int enemy_targeting_mode; // 0x18
	public float random_enemy_targeting; // 0x1C
	public int language; // 0x20
	public int show_tips; // 0x24
	public float minimap_size; // 0x28
	public int minimap_rotation; // 0x2C
	public int hp_bar_color; // 0x30
	public float crosshair_height; // 0x34
	public float crosshair_size; // 0x38
	public float crosshair_alpha; // 0x3C
	public int hide_leaderboards; // 0x40
	public int upload_score_to_leaderboard; // 0x44
	public int quick_reset; // 0x48
	public int debug_fps; // 0x4C
	public int debug_speed; // 0x50
	public int debug_ram; // 0x54
	public int debug_enemy_scaling; // 0x58
	public int pege_mode; // 0x5C
	public int unlock_all; // 0x60

	// Methods

	// RVA: 0x3D8370 Offset: 0x3D6970 VA: 0x1803D8370 Slot: 4
	public List<SettingHeader> GetHeaders() { }

	// RVA: 0x3D8600 Offset: 0x3D6C00 VA: 0x1803D8600
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Settings___Saves.SaveFiles
public interface CFSettings // TypeDefIndex: 5398
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract List<SettingHeader> GetHeaders();
}

// Namespace: Assets.Scripts.Settings___Saves.SaveFiles
public class CFVideoSettings : CFSettings // TypeDefIndex: 5399
{
	// Fields
	public int resolution; // 0x10
	public int target_monitor; // 0x14
	public int fullscreen_mode; // 0x18
	public int vsync; // 0x1C
	public float fps_limit; // 0x20
	public float fov; // 0x24
	public float camera_distance; // 0x28
	public int grass_quality; // 0x2C
	public int shadow_quality; // 0x30
	public int shadow_resolution; // 0x34
	public int anti_aliasing; // 0x38
	public int soft_particles; // 0x3C
	public int bloom; // 0x40
	public int motion_blur; // 0x44
	public int ambient_occlusion; // 0x48

	// Methods

	// RVA: 0x3D8660 Offset: 0x3D6C60 VA: 0x1803D8660 Slot: 4
	public List<SettingHeader> GetHeaders() { }

	// RVA: 0x3D8850 Offset: 0x3D6E50 VA: 0x1803D8850
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Settings___Saves.SaveFiles
public static class ConfigSettingsUtility // TypeDefIndex: 5400
{
	// Methods

	// RVA: 0x3DC610 Offset: 0x3DAC10 VA: 0x1803DC610
	public static SettingType GetSettingType(FieldInfo field) { }

	// RVA: 0x3DAFF0 Offset: 0x3D95F0 VA: 0x1803DAFF0
	public static string CheckSettingName(string settingName) { }

	// RVA: 0x3DBC80 Offset: 0x3DA280 VA: 0x1803DBC80
	public static string GetSettingDescription(string settingName) { }

	// RVA: 0x3DC890 Offset: 0x3DAE90 VA: 0x1803DC890
	public static string[] GetSettingValues(string settingName) { }

	// RVA: 0x3DD350 Offset: 0x3DB950 VA: 0x1803DD350
	public static bool GetSliderWholeNumbers(string settingName) { }

	// RVA: 0x3DCF20 Offset: 0x3DB520 VA: 0x1803DCF20
	public static void GetSliderRange(string settingName, out float min, out float max) { }

	// RVA: 0x3DBAC0 Offset: 0x3DA0C0 VA: 0x1803DBAC0
	private static string[] GetResolutionNames() { }

	// RVA: 0x3DB420 Offset: 0x3D9A20 VA: 0x1803DB420
	private static string[] GetLanguageNames() { }

	// RVA: 0x3DB7E0 Offset: 0x3D9DE0 VA: 0x1803DB7E0
	public static Resolution[] GetMyResolutions() { }

	// RVA: 0x3DB0D0 Offset: 0x3D96D0 VA: 0x1803DB0D0
	public static string[] GetControllers() { }

	// RVA: 0x3DAF80 Offset: 0x3D9580 VA: 0x1803DAF80
	public static bool AreResolutionSame(Resolution r1, Resolution r2) { }

	// RVA: 0x3DB590 Offset: 0x3D9B90 VA: 0x1803DB590
	private static string[] GetMonitorNames() { }

	// RVA: 0x3DD790 Offset: 0x3DBD90 VA: 0x1803DD790
	public static string SettingNameToReadable(string s) { }

	// RVA: 0x3DD430 Offset: 0x3DBA30 VA: 0x1803DD430
	public static string SettingNameToReadable(string s, CFSettings cfSettings) { }

	// RVA: 0x3DC570 Offset: 0x3DAB70 VA: 0x1803DC570
	public static string GetSettingEnumLocalized(string settingEnumValue) { }

	// RVA: 0x3DCEA0 Offset: 0x3DB4A0 VA: 0x1803DCEA0
	public static float GetSliderIncrement(string settingName) { }
}

// Namespace: Assets.Scripts.Settings___Saves.SaveFiles
public class SettingHeader // TypeDefIndex: 5401
{
	// Fields
	public int index; // 0x10
	public string header; // 0x18

	// Methods

	// RVA: 0x3E8780 Offset: 0x3E6D80 VA: 0x1803E8780
	public void .ctor(int index, string header) { }
}

// Namespace: Assets.Scripts.Settings___Saves.SaveFiles
public enum SettingType // TypeDefIndex: 5402
{
	// Fields
	public int value__; // 0x0
	public const SettingType Enum = 0;
	public const SettingType Slider = 1;
	public const SettingType Resolution = 2;
	public const SettingType Control = 3;
	public const SettingType Language = 4;
	public const SettingType ControlNew = 5;
	public const SettingType ControllerDisplay = 6;
}

