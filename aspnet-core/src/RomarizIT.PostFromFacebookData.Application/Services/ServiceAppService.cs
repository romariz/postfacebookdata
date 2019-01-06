using Abp.AutoMapper;
using Abp.Domain.Repositories;
using RomarizIT.PostFromFacebookData.Services.Dto;
using System.Collections.Generic;
using System.Linq;

namespace RomarizIT.PostFromFacebookData.Services
{
    public class ServiceAppService : IServiceAppService
    {
        private readonly IRepository<Service> _serviceRepository;
        public ServiceAppService(IRepository<Service> serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public IList<ServiceInput> GetAll(int SkipCount, int MaxResultCount)
        {
            var result = _serviceRepository.GetAll()
                .Skip(SkipCount)
                .Take(MaxResultCount)
                .ToList()
                .MapTo<List<ServiceInput>>();

            return result;
        }
    }
}
