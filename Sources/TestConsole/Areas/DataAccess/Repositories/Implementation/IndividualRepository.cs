using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.Rest.Areas.Repositories;
using Mmu.Mlh.DataAccess.Rest.Areas.RestAccess;
using Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.DataAccess.Repositories.Implementation
{
    public class IndividualRepository : RestRepositoryBase<Individual, IndividualDataModel, string>,IIndividualRepository
    {
        private readonly IRestAccess<IndividualDataModel, string> _restAccess;
        private readonly IDataModelAdapter<IndividualDataModel, Individual, string> _dataModelAdapter;

        public IndividualRepository(IRestAccess<IndividualDataModel, string> restAccess, IDataModelAdapter<IndividualDataModel, Individual, string> dataModelAdapter) : base(restAccess, dataModelAdapter)
        {
            _restAccess = restAccess;
            _dataModelAdapter = dataModelAdapter;
        }
    }
}