using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Models;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Services;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2
{
    public static class Program
    {
        public static void Main()
        {
            var containerConfig = ContainerConfiguration.CreateFromAssembly(typeof(Program).Assembly, logInitialization: true, initializeAutoMapper: true);
            var container = ContainerInitializationService.CreateInitializedContainer(containerConfig);
            container
                .GetInstance<IConsoleCommandsStartupService>()
                .Start();
        }
    }
}