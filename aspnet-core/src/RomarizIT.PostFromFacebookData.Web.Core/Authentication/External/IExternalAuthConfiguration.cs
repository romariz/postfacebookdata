using System.Collections.Generic;

namespace RomarizIT.PostFromFacebookData.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
