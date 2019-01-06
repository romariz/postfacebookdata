using Abp.AutoMapper;
using RomarizIT.PostFromFacebookData.Authentication.External;

namespace RomarizIT.PostFromFacebookData.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
