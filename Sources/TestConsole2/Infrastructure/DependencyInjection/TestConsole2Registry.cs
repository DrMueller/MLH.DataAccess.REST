using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.Rest.Areas.RestResourceServices;
using Mmu.Mlh.DataAccess.Rest.Infrastructure.Settings.Services;
using Mmu.Mlh.DomainExtensions.Areas.Repositories;
using StructureMap;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Infrastructure.DependencyInjection
{
    public class TestConsole2Registry : Registry
    {
        public TestConsole2Registry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<TestConsole2Registry>();
                    scanner.WithDefaultConventions();

                    // Console
                    scanner.AddAllTypesOf<IConsoleCommand>();

                    // DataAccess
                    scanner.AddAllTypesOf(typeof(IRepository<,>));
                    scanner.AddAllTypesOf(typeof(IRestResourceService<,>));

                    // Application
                    scanner.AddAllTypesOf(typeof(IDtoAdapter<,,>));
                    scanner.AddAllTypesOf(typeof(IDataModelAdapter<,,>));

                    // Infrastructure
                    scanner.AddAllTypesOf<IRestSettingsProvider>();
                });

            For<IConsoleCommand>().Singleton();

            For(typeof(IRestResourceService<,>)).Singleton();
            For(typeof(IRepository<,>)).Singleton();

            For(typeof(IDtoAdapter<,,>)).Singleton();
            For(typeof(IDataModelAdapter<,,>)).Singleton();

            For<IRestSettingsProvider>().Singleton();
        }
    }
}