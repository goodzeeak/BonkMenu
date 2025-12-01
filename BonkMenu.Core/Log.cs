using MelonLoader;

namespace BonkMenu.Core;

public static class Log
{
    public static void Info(string message)
    {
        MelonLogger.Msg(message);
    }

    public static void Warn(string message)
    {
        MelonLogger.Warning(message);
    }

    public static void Error(string message)
    {
        MelonLogger.Error(message);
    }
}
