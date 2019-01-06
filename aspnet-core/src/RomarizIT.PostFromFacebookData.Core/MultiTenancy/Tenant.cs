using Abp.MultiTenancy;
using RomarizIT.PostFromFacebookData.Authorization.Users;

namespace RomarizIT.PostFromFacebookData.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
