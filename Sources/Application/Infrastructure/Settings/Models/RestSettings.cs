using System;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;
using Mmu.Mlh.RestExtensions.Areas.Models.Security;

namespace Mmu.Mlh.DataAccess.Rest.Infrastructure.Settings.Models
{
    public class RestSettings
    {
        public Uri BasePath { get; }
        public string ResourcePath { get; }
        public RestSecurity RestSecurity { get; }

        public RestSettings(Uri basePath, string resourcePath, RestSecurity restSecurity)
        {
            Guard.ObjectNotNull(() => basePath);
            Guard.ObjectNotNull(() => restSecurity);

            BasePath = basePath;
            ResourcePath = resourcePath;
            RestSecurity = restSecurity;
        }
    }
}