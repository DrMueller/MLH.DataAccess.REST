using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Services;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.ConsoleCommands
{
    public class GetIndividualPage : IConsoleCommand
    {
        private readonly IIndividualDtoDataService _individualDtoDataService;
        public string Description { get; } = "Get Individual Page";
        public ConsoleKey Key { get; } = ConsoleKey.D2;

        public GetIndividualPage(IIndividualDtoDataService individualDtoDataService)
        {
            _individualDtoDataService = individualDtoDataService;
        }

        public async Task ExecuteAsync()
        {
            var individual = await _individualDtoDataService.LoadIndividualPageAsync(1);
            Console.WriteLine(JsonConvert.SerializeObject(individual));
        }
    }
}