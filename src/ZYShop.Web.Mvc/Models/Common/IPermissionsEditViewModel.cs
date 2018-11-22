using System.Collections.Generic;
using ZYShop.Roles.Dto;

namespace ZYShop.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}