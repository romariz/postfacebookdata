using Abp.AutoMapper;
using RomarizIT.PostFromFacebookData.Enum;

namespace RomarizIT.PostFromFacebookData.Services.Dto
{
    [AutoMapTo(typeof(Service))]
    public class ServiceInput
    {
        public ServiceEnum ServiceType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
