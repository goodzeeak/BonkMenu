// Namespace: Assets.Scripts.Settings___Saves.SaveFiles.ConfigSaves
[Serializable]
public class ConfigSaveFile // TypeDefIndex: 5404
{
	// Fields
	public int settingsVersion; // 0x10
	public bool hasSelectedLanguage; // 0x14
	public CFGameSettings cfGameSettings; // 0x18
	public CFVideoSettings cfVideoSettings; // 0x20
	public CFAudioSettings cfAudioSettings; // 0x28
	public CFControlSettings cfControlSettings; // 0x30
	public CFVisualsSettings cfVisualsSettings; // 0x38
	public ConfigSettingsExtra otherSettings; // 0x40
	public Preferences preferences; // 0x48

	// Methods

	// RVA: 0x3DABE0 Offset: 0x3D91E0 VA: 0x1803DABE0
	public void Init() { }

	// RVA: 0x3DAC00 Offset: 0x3D9200 VA: 0x1803DAC00
	public void .ctor() { }
}

