namespace Anemone;

public class InstallLock
{
    public static void Lock()
    {
        File.Create("/etc/anemone/install_lockfile");
    }

    public static void Unlock()
    {
        File.Delete("/etc/anemone/install_lockfile");
    }

    public static bool IsLocked()
    {
        return File.Exists("/etc/anemone/install_lockfile");
    }
}