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
        MelonLogger.Msg(message);
    }

    /// <summary>
    /// Logs a warning message.
    /// </summary>
    public static void Warn(string message)
    {
        MelonLogger.Warning(message);
    }

    /// <summary>
    /// Logs an error message.
    /// </summary>
    public static void Error(string message)
    {
        MelonLogger.Error(message);
    }
}
