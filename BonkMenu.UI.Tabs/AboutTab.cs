using BonkMenu.Features;
using BonkMenu.Core;
using BonkMenu.UI.Components;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

public static class AboutTab
{
	public static void Create(GameObject parent)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		UIFactory.CreateSectionHeader("About", parent);
		UIFactory.CreateLabel("BonkMenu v1.0.0", parent);
		UIFactory.CreateLabel("Created by Goodzy", parent);
		UIFactory.CreateSpacer(10, parent);
		UIFactory.CreateSectionHeader("Keybind Settings", parent);
		UIFactory.CreateLabel($"Toggle Menu: {KeybindConfig.ToggleMenuKey}", parent);
		UIFactory.CreateLabel("(Other features accessible via UI buttons)", parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateLabel("Note: Edit keybinds in UserData/BonkMenu_Keybinds.txt", parent);
		UIFactory.CreateButton("Save Current Keybinds", delegate
		{
			KeybindConfig.SaveKeybinds();
		}, parent);
		UIFactory.CreateButton("Reload Keybinds", delegate
		{
			KeybindConfig.LoadKeybinds();
		}, parent);

        UIFactory.CreateSpacer(15, parent);
        UIFactory.CreateSectionHeader("Debug / Inspection", parent);
        
        UIFactory.CreateCircularToggle("Log Interactables on Hover", DebugFeatures.EnableInteractableLogging, delegate(bool value)
        {
            DebugFeatures.EnableInteractableLogging = value;
        }, parent);
        
        UIFactory.CreateButton("List Spawnable Objects", delegate
        {
            WorldFeatures.ListSpawnableObjects();
        }, parent);
        
        UIFactory.CreateLabel("Check MelonLoader console for output", parent);
	}
}
