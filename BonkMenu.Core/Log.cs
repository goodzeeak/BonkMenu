using MelonLoader;

namespace BonkMenu.Core;

/// <summary>
/// Simple logging facade for BonkMenu.
/// </summary>
public static class Log
{
    /// <summary>
    /// Logs an informational message.
    /// </summary>
    public static void Info(string message)
    {
        var m = message;
        if (!string.IsNullOrEmpty(m) && m.StartsWith("[BonkMenu]"))
        {
            m = m.Substring("[BonkMenu]".Length).TrimStart();
        }
        MelonLogger.Msg(m);
    }

    /// <summary>
    /// Logs a warning message.
    /// </summary>
    public static void Warn(string message)
    {
        var m = message;
        if (!string.IsNullOrEmpty(m) && m.StartsWith("[BonkMenu]"))
        {
            m = m.Substring("[BonkMenu]".Length).TrimStart();
        }
        MelonLogger.Warning(m);
    }

    /// <summary>
    /// Logs an error message.
    /// </summary>
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
