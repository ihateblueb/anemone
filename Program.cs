using System.CommandLine;
using Anemone.Commands;

namespace Anemone
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            Initialize.EnsureRoot();
            Initialize.CreateDirectories();
            Initialize.EnsureNoLeftoverLock();

            InstallLock.Lock();

            var rootCommand = new RootCommand("anemone package manager");

            // install
            var installCommand = new Command("install", "Install packages");
            installCommand.AddAlias("ins");
            installCommand.AddAlias("i");

            installCommand.SetHandler(InstallCommand.Handler);
            rootCommand.AddCommand(installCommand);

            // source
            var sourceCommand = new Command("source", "Manage sources");
            sourceCommand.AddAlias("src");
            sourceCommand.AddAlias("s");

            var addSourceCommand = new Command("add", "Add package source");
            addSourceCommand.SetHandler(SourceCommand.AddSource);
            sourceCommand.AddCommand(addSourceCommand);

            var removeSourceCommand = new Command("remove", "Remove package source");
            removeSourceCommand.SetHandler(SourceCommand.RemoveSource);
            sourceCommand.AddCommand(removeSourceCommand);

            var syncSourceCommand = new Command("sync", "Sync package sources");
            syncSourceCommand.SetHandler(SourceCommand.SyncSources);
            sourceCommand.AddCommand(syncSourceCommand);

            sourceCommand.SetHandler(SourceCommand.Handler);
            rootCommand.AddCommand(sourceCommand);


            return await rootCommand.InvokeAsync(args);
        }
    }
}