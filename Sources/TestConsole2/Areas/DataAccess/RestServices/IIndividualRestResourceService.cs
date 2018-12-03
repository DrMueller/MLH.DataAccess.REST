using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Rest.Areas.RestResourceServices;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.DataModeling;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.RestServices
{
    public interface IIndividualRestResourceService : IRestResourceService<IndividualDataModel, long?>
    {
        Task<IReadOnlyCollection<IndividualDataModel>> GetPageAsync(long currentPage);
    }
}