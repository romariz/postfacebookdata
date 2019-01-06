using Abp.Application.Services;
using RomarizIT.PostFromFacebookData.Services.Dto;
using System.Collections.Generic;

namespace RomarizIT.PostFromFacebookData.Services
{
    public interface IServiceAppService : IApplicationService
    {
        IList<ServiceInput> GetAll(int SkipCount, int MaxResultCount);
    }
}
