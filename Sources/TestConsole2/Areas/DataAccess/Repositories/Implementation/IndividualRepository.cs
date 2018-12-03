using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.Rest.Areas.Repositories;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.RestServices;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.Repositories.Implementation
{
    public class IndividualRepository : RestRepositoryBase<Individual, IndividualDataModel, long?>, IIndividualRepository
    {
        private readonly IDataModelAdapter<IndividualDataModel, Individual, long?> _adapter;
        private readonly IIndividualRestResourceService _restResourceService;

        public IndividualRepository(IIndividualRestResourceService restResourceService, IDataModelAdapter<IndividualDataModel, Individual, long?> adapter) : base(restResourceService, adapter)
        {
            _restResourceService = restResourceService;
            _adapter = adapter;
        }

        public async Task<IReadOnlyCollection<Individual>> LoadPageAsync(long currentPage)
        {
            var dataModels = await _restResourceService.GetPageAsync(currentPage);
            return dataModels.Select(dataModel => _adapter.Adapt(dataModel)).ToList();
        }
    }
}