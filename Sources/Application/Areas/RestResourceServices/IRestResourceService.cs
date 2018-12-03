using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;

namespace Mmu.Mlh.DataAccess.Rest.Areas.RestResourceServices
{
    public interface IRestResourceService<TDataModel, TId>
        where TDataModel : DataModelBase<TId>
    {
        Task DeleteAsync(TId id);

        Task<IReadOnlyCollection<TDataModel>> GetAllAsync();

        Task<TDataModel> GetByIdAsync(TId id);

        Task<TDataModel> PutAsync(TDataModel dataModel);
    }
}