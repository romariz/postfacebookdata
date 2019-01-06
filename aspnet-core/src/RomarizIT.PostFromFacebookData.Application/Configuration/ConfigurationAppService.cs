using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RomarizIT.PostFromFacebookData.Configuration.Dto;

namespace RomarizIT.PostFromFacebookData.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PostFromFacebookDataAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
