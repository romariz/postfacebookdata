using System.Threading.Tasks;
using Abp.Application.Services;
using RomarizIT.PostFromFacebookData.Sessions.Dto;

namespace RomarizIT.PostFromFacebookData.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
