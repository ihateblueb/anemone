using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Anemone;

public class Initialize
{
    [DllImport("libc")]
    public static extern uint getuid();
    public static void EnsureRoot()
    {
        var uid = getuid();
        Logger.Debug($"UID {uid}");

        if (uid != 0)
        {
            Logger.Fatal("Running as root is required");
            throw new Exception("Running as root is required");
        }

        Logger.Debug("Passed root check");
    }

    public static void CreateDirectories()
    {
        Directory.CreateDirectory("/etc/anemone");
        Directory.CreateDirectory("/etc/anemone/pkgs");

        Logger.Debug("Passed /etc/ directories creation");

        Directory.CreateDirectory("/var/anemone");
        Directory.CreateDirectory("/var/anemone/cache");

        Logger.Debug("Passed /var/ directories creation");
    }

    public static void CreateFiles()
    {
        File.Create("/etc/anemone/config.json");
    }

    public static void EnsureNoLeftoverLock()
    {
        if (InstallLock.IsLocked())
        {
            Logger.Warn("A lockfile for a previous install still exists. Installs will be blocked until the lock is removed.");
        }
    }
}