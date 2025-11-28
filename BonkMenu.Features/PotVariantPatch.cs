using System;
using HarmonyLib;
using MelonLoader;

namespace BonkMenu.Patches;

public static class PotVariantPatch
{
    // Static flags to control pot variants
    public static bool SpawnNextAsSilver = false;
    public static int SilverPotsRemaining = 0;
    
    public static bool SpawnNextAsBig = false;
    public static int BigPotsRemaining = 0;
    
    // Track which pots we've modified so we don't affect naturally spawned pots
    private static System.Collections.Generic.HashSet<IntPtr> ModifiedPots = new System.Collections.Generic.HashSet<IntPtr>();

    public static void Apply(HarmonyLib.Harmony harmony)
    {
        try
        {
            // Get the managed wrapper type for InteractablePot
            var potType = typeof(Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables.InteractablePot);
            
            // InteractablePot doesn't have Awake, only Interact - patch the constructor/Start if needed
            // For now, we'll use a different approach - modify after instantiation
            
            MelonLogger.Msg("[PotVariantPatch] ✅ Pot variant patch ready (will modify post-spawn)");
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[PotVariantPatch] Failed to patch: {ex.Message}");
            MelonLogger.Error($"[PotVariantPatch] Stack trace: {ex.StackTrace}");
        }
    }

    // Helper method to apply variant to a pot instance
    public static void ApplyVariant(Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables.InteractablePot pot)
    {
        try
        {
            IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)pot).Pointer;
            
            if (SpawnNextAsSilver && SilverPotsRemaining > 0)
            {
                // Offset 0x82 is isSilver
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0x82, 1);
                ModifiedPots.Add(ptr);
                SilverPotsRemaining--;
                
                if (SilverPotsRemaining <= 0)
                {
                    SpawnNextAsSilver = false;
                    SilverPotsRemaining = 0;
                }
                
                MelonLogger.Msg("[PotVariantPatch] Set pot to Silver");
            }
            else if (SpawnNextAsBig && BigPotsRemaining > 0)
            {
                // Offset 0x81 is isBig
                System.Runtime.InteropServices.Marshal.WriteByte(ptr + 0x81, 1);
                ModifiedPots.Add(ptr);
                BigPotsRemaining--;
                
                if (BigPotsRemaining <= 0)
                {
                    SpawnNextAsBig = false;
                    BigPotsRemaining = 0;
                }
                
                MelonLogger.Msg("[PotVariantPatch] Set pot to Big (Microwave)");
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[PotVariantPatch] Failed to apply variant: {ex.Message}");
        }
    }
}
