using System.Threading.Tasks;
using RomarizIT.PostFromFacebookData.Configuration.Dto;

namespace RomarizIT.PostFromFacebookData.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
