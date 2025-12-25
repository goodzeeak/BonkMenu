using System;
using MelonLoader;

namespace BonkMenu.Patches;

public static class PotVariantPatch
{
    public static bool SpawnNextAsSilver = false;
    public static int SilverPotsRemaining = 0;
    
    public static bool SpawnNextAsBig = false;
    public static int BigPotsRemaining = 0;
    
    private static System.Collections.Generic.HashSet<IntPtr> ModifiedPots = new System.Collections.Generic.HashSet<IntPtr>();

    public static void Apply()
    {
        try
        {
            var potType = typeof(Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables.InteractablePot);
            
            MelonLogger.Msg("[PotVariantPatch] ✅ Pot variant patch ready (will modify post-spawn)");
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[PotVariantPatch] Failed to patch: {ex.Message}");
            MelonLogger.Error($"[PotVariantPatch] Stack trace: {ex.StackTrace}");
        }
    }

    public static void ApplyVariant(Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables.InteractablePot pot)
    {
        try
        {
            IntPtr ptr = ((Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase)pot).Pointer;
            
            if (SpawnNextAsSilver && SilverPotsRemaining > 0)
            {
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

