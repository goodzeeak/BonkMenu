using System;
using HarmonyLib;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables;

namespace BonkMenu.Features;

public static class DebugFeatures
{
    public static bool EnableInteractableLogging = false;

    [HarmonyPatch(typeof(BaseInteractable), "StartHover")]
    public static class BaseInteractable_StartHover_Patch
    {
        public static void Postfix(BaseInteractable __instance)
        {
            if (EnableInteractableLogging)
            {
                try
                {
                    string name = __instance.gameObject.name;
                    string prefabName = name.Replace("(Clone)", "").Trim();
                    MelonLogger.Msg($"[BonkMenu-DEBUG] Hovered Object: '{name}' | Prefab Name: '{prefabName}'");
                    
                    // Also log the type of the interactable
                    MelonLogger.Msg($"[BonkMenu-DEBUG] Type: {__instance.GetIl2CppType().Name}");
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[BonkMenu-DEBUG] Error logging interactable: {ex.Message}");
                }
            }
        }
    }
}
