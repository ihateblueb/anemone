namespace Anemone.Commands;

public class SourceCommand
{
    public static void Handler()
    {
        Logger.Debug("SourceCommand.Handler");
    }

    public static void AddSource()
    {
        Logger.Debug("SourceCommand.AddSource");
    }

    public static void RemoveSource()
    {
        Logger.Debug("SourceCommand.RemoveSource");
    }

    public static void SyncSources()
    {
        Logger.Debug("SourceCommand.SyncSources");
    }
}