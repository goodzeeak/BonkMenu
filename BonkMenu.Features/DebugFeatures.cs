using HarmonyLib;
using MelonLoader;
using Il2Cpp;

namespace BonkMenu.Features;

/// <summary>
/// Debug helpers for logging interactable hover events.
/// </summary>
public static class DebugFeatures
{
    /// <summary>
    /// When true, logs hovered interactables to the console.
    /// </summary>
    public static bool EnableInteractableLogging = false;

    /// <summary>
    /// Logs interactable name and type when the player hovers over it.
    /// </summary>
    [HarmonyPatch(typeof(BaseInteractable), "StartHover")]
    public static class BaseInteractable_StartHover_Patch
    {
        /// <summary>
        /// Postfix that outputs hover details when logging is enabled.
        /// </summary>
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
