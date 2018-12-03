using System;
using System.IO;
using Mmu.Mlh.DataAccess.Rest.Infrastructure.Settings.Models;
using Mmu.Mlh.RestExtensions.Areas.Models.Security;

namespace Mmu.Mlh.DataAccess.Rest.TestConsole2.Infrastructure.Settings.Implementation
{
    public class IndividualRestSettingsProvider : IIndividualRestSettingsProvider
    {
        private Lazy<RestSettings> _lazyRestSettings = new Lazy<RestSettings>(CreateRestSettings);

        public RestSettings ProvideRestSettings()
        {
            return _lazyRestSettings.Value;
        }

        private static RestSettings CreateRestSettings()
        {
            var lines = File.ReadAllLines(@"C:\Users\matthias.mueller\Desktop\Stuff\Settings\Individuals.txt");
            var basePath = new Uri(lines[0]);
            var relativePath = lines[1];
            var userName = lines[2];
            var password = lines[3];

            return new RestSettings(basePath, relativePath, RestSecurity.CreateBasicAuthentication(userName, password));
        }
    }
}