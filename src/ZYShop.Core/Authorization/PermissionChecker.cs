using Abp.Authorization;
using ZYShop.Authorization.Roles;
using ZYShop.Authorization.Users;

namespace ZYShop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
