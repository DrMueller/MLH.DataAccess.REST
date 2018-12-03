using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.Rest.Areas.RestResourceServices;
using Mmu.Mlh.DomainExtensions.Areas.DomainModeling;
using Mmu.Mlh.DomainExtensions.Areas.Repositories;

namespace Mmu.Mlh.DataAccess.Rest.Areas.Repositories
{
    public abstract class RestRepositoryBase<TAggregateRoot, TDataModel, TId> : IRepository<TAggregateRoot, TId>
        where TAggregateRoot : AggregateRoot<TId>
        where TDataModel : DataModelBase<TId>
    {
        private readonly IDataModelAdapter<TDataModel, TAggregateRoot, TId> _adapter;
        private readonly IRestResourceService<TDataModel, TId> _restResourceService;

        protected RestRepositoryBase(
            IRestResourceService<TDataModel, TId> restResourceService,
            IDataModelAdapter<TDataModel, TAggregateRoot, TId> adapter)
        {
            _restResourceService = restResourceService;
            _adapter = adapter;
        }

        public async Task DeleteAsync(TId id)
        {
            await _restResourceService.DeleteAsync(id);
        }

        public async Task<IReadOnlyCollection<TAggregateRoot>> LoadAllAsync()
        {
            var dataModels = await _restResourceService.GetAllAsync();
            return dataModels.Select(dataModel => _adapter.Adapt(dataModel)).ToList();
        }

        public async Task<TAggregateRoot> LoadByIdAsync(TId id)
        {
            var dataModel = await _restResourceService.GetByIdAsync(id);
            return _adapter.Adapt(dataModel);
        }

        public async Task<TAggregateRoot> SaveAsync(TAggregateRoot aggregateRoot)
        {
            var dataModel = _adapter.Adapt(aggregateRoot);
            var returnedDataModel = await _restResourceService.PutAsync(dataModel);

            return _adapter.Adapt(returnedDataModel);
        }
    }
}