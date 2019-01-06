using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RomarizIT.PostFromFacebookData.Roles.Dto;
using RomarizIT.PostFromFacebookData.Users.Dto;

namespace RomarizIT.PostFromFacebookData.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
