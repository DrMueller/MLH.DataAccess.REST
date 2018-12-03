using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.Rest.Infrastructure.Settings.Models;
using Mmu.Mlh.DataAccess.Rest.Infrastructure.Settings.Services;
using Mmu.Mlh.RestExtensions.Areas.Models;
using Mmu.Mlh.RestExtensions.Areas.RestCallBuilding;
using Mmu.Mlh.RestExtensions.Areas.RestProxies;

namespace Mmu.Mlh.DataAccess.Rest.Areas.RestResourceServices.Implementation
{
    public abstract class RestResourceServiceBase<TDataModel, TId> : IRestResourceService<TDataModel, TId>
        where TDataModel : DataModelBase<TId>
    {
        private readonly IRestCallBuilderFactory _restCallBuilderFactory;
        private readonly IRestProxy _restProxy;
        protected RestSettings RestSettings { get; }

        protected RestResourceServiceBase(
            IRestProxy restProxy,
            IRestCallBuilderFactory restCallBuilderFactory,
            IRestSettingsProvider restSettingsProvider)
        {
            _restProxy = restProxy;
            _restCallBuilderFactory = restCallBuilderFactory;
            RestSettings = restSettingsProvider.ProvideRestSettings();
        }

        public virtual async Task DeleteAsync(TId id)
        {
            var restCall = CreateBaseBuilder(RestSettings.ResourcePath + id, RestCallMethodType.Delete).Build();
            await _restProxy.PerformCallAsync<TDataModel>(restCall);
        }

        public virtual async Task<IReadOnlyCollection<TDataModel>> GetAllAsync()
        {
            var restCall = CreateBaseBuilder(RestSettings.ResourcePath, RestCallMethodType.Get).Build();
            return await _restProxy.PerformCallAsync<List<TDataModel>>(restCall);
        }

        public virtual async Task<TDataModel> GetByIdAsync(TId id)
        {
            var restCall = CreateBaseBuilder(RestSettings.ResourcePath + id, RestCallMethodType.Get).Build();
            return await _restProxy.PerformCallAsync<TDataModel>(restCall);
        }

        public virtual async Task<TDataModel> PutAsync(TDataModel dataModel)
        {
            var restCall = CreateBaseBuilder(RestSettings.ResourcePath + dataModel.Id, RestCallMethodType.Put).Build();
            return await _restProxy.PerformCallAsync<TDataModel>(restCall);
        }

        protected IRestCallBuilder CreateBaseBuilder(string resourcePath, RestCallMethodType method)
        {
            return _restCallBuilderFactory.StartBuilding(RestSettings.BasePath, method)
                .WithResourcePath(resourcePath)
                .WithSecurity(RestSettings.RestSecurity);
        }
    }
}