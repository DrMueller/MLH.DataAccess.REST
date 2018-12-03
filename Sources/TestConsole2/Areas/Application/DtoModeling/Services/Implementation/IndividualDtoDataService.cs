using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services.Implementation;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Dtos;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.Repositories;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Services.Implementation
{
    public class IndividualDtoDataService : DtoDataServiceBase<IndividualDto, Individual, long?>, IIndividualDtoDataService
    {
        private readonly IDtoAdapter<IndividualDto, Individual, long?> _dtoAdapter;
        private readonly IIndividualRepository _repository;

        public IndividualDtoDataService(IIndividualRepository repository, IDtoAdapter<IndividualDto, Individual, long?> dtoAdapter) : base(repository, dtoAdapter)
        {
            _repository = repository;
            _dtoAdapter = dtoAdapter;
        }

        public async Task<IReadOnlyCollection<IndividualDto>> LoadIndividualPageAsync(long currentPage)
        {
            var individuals = await _repository.LoadPageAsync(currentPage);
            return individuals.Select(ind => _dtoAdapter.Adapt(ind)).ToList();
        }
    }
}