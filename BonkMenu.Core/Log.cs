using MelonLoader;

namespace BonkMenu.Core;

public static class Log
{
    public static void Info(string message)
    {
        if (!ModConfig.VerboseLogging) return;
        var m = message;
        if (!string.IsNullOrEmpty(m) && m.StartsWith("[BonkMenu]"))
        {
            m = m.Substring("[BonkMenu]".Length).TrimStart();
        }
        MelonLogger.Msg(m);
    }

    public static void Verbose(string message)
    {
        if (!ModConfig.VerboseLogging) return;
        var m = message;
        if (!string.IsNullOrEmpty(m) && m.StartsWith("[BonkMenu]"))
        {
            m = m.Substring("[BonkMenu]".Length).TrimStart();
        }
        MelonLogger.Msg(m);
    }

    public static void Warn(string message)
    {
        var m = message;
        if (!string.IsNullOrEmpty(m) && m.StartsWith("[BonkMenu]"))
        {
            m = m.Substring("[BonkMenu]".Length).TrimStart();
        }
        MelonLogger.Warning(m);
    }

    public static void Error(string message)
    {
        var m = message;
        if (!string.IsNullOrEmpty(m) && m.StartsWith("[BonkMenu]"))
        {
            m = m.Substring("[BonkMenu]".Length).TrimStart();
        }
        MelonLogger.Error(m);
    }
}
