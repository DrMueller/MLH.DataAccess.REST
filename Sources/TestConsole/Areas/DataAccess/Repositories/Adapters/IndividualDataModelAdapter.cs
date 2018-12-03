//using System;
//using System.Collections.Generic;
//using System.Text;
//using AutoMapper;
//using Mmu.Mlh.DataAccess.Areas.DataModeling.Services.Implementation;
//using Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.DataAccess.DataModeling;
//using Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.Domain.Models;

//namespace Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.DataAccess.Repositories.Adapters
//{
//    public class IndividualDataModelAdapter : DataModelAdapterBase<IndividualDataModel, Individual, string>
//    {
//        private readonly IIndividualFactory _individualFactory;

//        public IndividualDataModelAdapter(IIndividualFactory individualFactory, IMapper mapper) : base(mapper)
//        {
//            _individualFactory = individualFactory;
//        }

//        public override Individual Adapt(IndividualDataModel dataModel)
//        {
//            return _individualFactory.Create(
//                dataModel.FirstName,
//                dataModel.LastName,
//                dataModel.Birthdate,
//                dataModel.Id);
//        }
//    }
//}
