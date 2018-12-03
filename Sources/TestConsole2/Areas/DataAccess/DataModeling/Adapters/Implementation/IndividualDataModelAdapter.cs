using AutoMapper;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services.Implementation;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Factories;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.DataModeling.Adapters.Implementation
{
    public class IndividualDataModelAdapter : DataModelAdapterBase<IndividualDataModel, Individual, long?>
    {
        private readonly IIndividualFactory _individualFactory;

        public IndividualDataModelAdapter(IIndividualFactory individualFactory, IMapper mapper) : base(mapper)
        {
            _individualFactory = individualFactory;
        }

        public override Individual Adapt(IndividualDataModel dataModel)
        {
            return _individualFactory.Create(
                dataModel.FirstName,
                dataModel.LastName,
                dataModel.Birthdate,
                dataModel.Id);
        }
    }
}