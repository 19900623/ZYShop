using System.Collections.Generic;
using ZYShop.Roles.Dto;
using ZYShop.Users.Dto;

namespace ZYShop.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
