using AutoMapper;
using Mmu.Mlh.ApplicationExtensions.Areas.DtoHandling.Services.Implementation;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Dtos;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Factories;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Services.Adapters
{
    public class IndividualDtoAdapter : DtoAdapterBase<IndividualDto, Individual, long?>
    {
        private readonly IIndividualFactory _individualFactory;

        public IndividualDtoAdapter(IMapper mapper, IIndividualFactory individualFactory) : base(mapper)
        {
            _individualFactory = individualFactory;
        }

        public override Individual Adapt(IndividualDto dto)
        {
            return _individualFactory.Create(
                dto.FirstName,
                dto.LastName,
                dto.Birthdate,
                dto.Id);
        }
    }
}