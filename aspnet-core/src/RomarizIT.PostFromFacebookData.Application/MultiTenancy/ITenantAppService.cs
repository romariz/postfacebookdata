using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RomarizIT.PostFromFacebookData.MultiTenancy.Dto;

namespace RomarizIT.PostFromFacebookData.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

