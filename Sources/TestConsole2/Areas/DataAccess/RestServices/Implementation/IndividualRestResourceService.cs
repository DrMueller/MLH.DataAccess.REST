using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Rest.Areas.RestResourceServices.Implementation;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.Rest.TestConsole2.Infrastructure.Settings;
using Mmu.Mlh.RestExtensions.Areas.Models;
using Mmu.Mlh.RestExtensions.Areas.RestCallBuilding;
using Mmu.Mlh.RestExtensions.Areas.RestProxies;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Areas.DataAccess.RestServices.Implementation
{
    public class IndividualRestResourceService : RestResourceServiceBase<IndividualDataModel, long?>, IIndividualRestResourceService
    {
        private readonly IRestProxy _restProxy;

        public IndividualRestResourceService(
            IRestProxy restProxy,
            IRestCallBuilderFactory restCallBuilderFactory,
            IIndividualRestSettingsProvider individalRestSettingsProvider)
            : base(restProxy, restCallBuilderFactory, individalRestSettingsProvider)
        {
            _restProxy = restProxy;
        }

        public async Task<IReadOnlyCollection<IndividualDataModel>> GetPageAsync(long currentPage)
        {
            var restCall = CreateBaseBuilder(RestSettings.ResourcePath, RestCallMethodType.Get)
                .WithQueryParameter("currentPage", currentPage)
                .WithQueryParameter("pageSize", 100)
                .Build();

            return await _restProxy.PerformCallAsync<List<IndividualDataModel>>(restCall);
        }
    }
}