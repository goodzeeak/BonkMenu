using System;
using System.Linq;
using System.Reflection;

namespace BonkMenu.Patches;

public static class UniverseLibPatchesRT
{
    public static bool BuildDeobfuscationCache_Prefix()
    {
        try
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => !string.Equals(a.GetName().Name, "UnityEngine.CoreModule", StringComparison.OrdinalIgnoreCase))
                .ToArray();
            for (int i = 0; i < assemblies.Length; i++)
            {
                try
                {
                    var _ = assemblies[i].GetTypes();
                }
                catch (ReflectionTypeLoadException)
                {
                }
                catch
                {
                }
            }
        }
        catch
        {
        }
        return false;
    }
}
