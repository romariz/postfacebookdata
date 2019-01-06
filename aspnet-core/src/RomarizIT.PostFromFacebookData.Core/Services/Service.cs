using Abp.Domain.Entities;
using RomarizIT.PostFromFacebookData.Enum;

namespace RomarizIT.PostFromFacebookData.Services
{
    public class Service : Entity
    {
        public ServiceEnum ServiceType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
