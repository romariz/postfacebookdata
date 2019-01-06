using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RomarizIT.PostFromFacebookData.MultiTenancy;

namespace RomarizIT.PostFromFacebookData.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
