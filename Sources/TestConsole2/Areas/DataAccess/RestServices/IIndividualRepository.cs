using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.Domain.Models;
using Mmu.Mlh.DomainExtensions.Areas.Repositories;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.Repositories
{
    public interface IIndividualRepository : IRepository<Individual, long?>
    {
        Task<IReadOnlyCollection<Individual>> LoadPageAsync(long currentPage);
    }
}