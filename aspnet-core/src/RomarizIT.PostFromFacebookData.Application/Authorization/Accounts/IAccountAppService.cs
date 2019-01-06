using System.Threading.Tasks;
using Abp.Application.Services;
using RomarizIT.PostFromFacebookData.Authorization.Accounts.Dto;

namespace RomarizIT.PostFromFacebookData.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
