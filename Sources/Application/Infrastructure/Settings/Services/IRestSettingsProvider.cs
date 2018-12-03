using Mmu.Mlh.DataAccess.Rest.Infrastructure.Settings.Models;

namespace Mmu.Mlh.DataAccess.Rest.Infrastructure.Settings.Services
{
    public interface IRestSettingsProvider
    {
        RestSettings ProvideRestSettings();
    }
}