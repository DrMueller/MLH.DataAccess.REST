using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Dtos;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Services
{
    public interface IIndividualDtoDataService : IDtoDataService<IndividualDto, long?>
    {
        Task<IReadOnlyCollection<IndividualDto>> LoadIndividualPageAsync(long currentPage);
    }
}