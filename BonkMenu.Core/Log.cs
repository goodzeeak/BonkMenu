using MelonLoader;

namespace BonkMenu.Core;

public static class Log
{
    private static string Normalize(string message)
    {
        var m = message;
        if (!string.IsNullOrEmpty(m) && m.StartsWith("[BonkMenu]"))
        {
            m = m.Substring("[BonkMenu]".Length).TrimStart();
        }
        return m;
    }

    public static void Info(string message)
    {
        if (!ModConfig.VerboseLogging) return;
        MelonLogger.Msg(Normalize(message));
    }

    public static void Verbose(string message)
    {
        if (!ModConfig.VerboseLogging) return;
        MelonLogger.Msg(Normalize(message));
    }

    public static void Warn(string message)
    {
        MelonLogger.Warning(Normalize(message));
    }

    public static void Error(string message)
    {
        MelonLogger.Error(Normalize(message));
    }

    public static void Exception(string context, System.Exception ex)
    {
        var prefix = string.IsNullOrEmpty(context) ? "[Exception]" : context;
        MelonLogger.Error(Normalize(prefix + " " + ex.Message));
        if (!string.IsNullOrEmpty(ex.StackTrace))
        {
            MelonLogger.Error(Normalize(prefix + " Stack Trace: " + ex.StackTrace));
        }
    }
}
