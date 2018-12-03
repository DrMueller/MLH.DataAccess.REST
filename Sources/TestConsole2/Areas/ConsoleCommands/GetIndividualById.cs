using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Services;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.ConsoleCommands
{
    public class GetIndividualById : IConsoleCommand
    {
        private readonly IIndividualDtoDataService _individualDataDtoService;
        public string Description { get; } = "Get Individual by ID";
        public ConsoleKey Key { get; } = ConsoleKey.D1;

        public GetIndividualById(IIndividualDtoDataService individualDataDtoService)
        {
            _individualDataDtoService = individualDataDtoService;
        }

        public async Task ExecuteAsync()
        {
            var individual = await _individualDataDtoService.LoadByIdAsync(177616);
            Console.WriteLine(JsonConvert.SerializeObject(individual));
        }
    }
}