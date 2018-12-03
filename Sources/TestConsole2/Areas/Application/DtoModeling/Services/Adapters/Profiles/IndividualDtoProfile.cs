using AutoMapper;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Dtos;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Application.DtoModeling.Services.Adapters.Profiles
{
    public class IndividualDtoProfile : Profile
    {
        public IndividualDtoProfile()
        {
            CreateMap<Individual, IndividualDto>()
                .ForMember(d => d.Birthdate, c => c.MapFrom(f => f.Birthdate))
                .ForMember(d => d.FirstName, c => c.MapFrom(f => f.FirstName))
                .ForMember(d => d.Id, c => c.MapFrom(f => f.Id))
                .ForMember(d => d.LastName, c => c.MapFrom(f => f.LastName));
        }
    }
}