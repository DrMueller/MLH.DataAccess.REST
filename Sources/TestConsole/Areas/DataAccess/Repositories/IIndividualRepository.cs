using Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.Domain.Models;
using Mmu.Mlh.DomainExtensions.Areas.Repositories;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole.Areas.DataAccess.Repositories
{
    public interface IIndividualRepository : IRepository<Individual, string>
    {
    }
}