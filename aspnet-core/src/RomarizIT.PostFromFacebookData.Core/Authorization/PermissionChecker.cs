using Abp.Authorization;
using RomarizIT.PostFromFacebookData.Authorization.Roles;
using RomarizIT.PostFromFacebookData.Authorization.Users;

namespace RomarizIT.PostFromFacebookData.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
