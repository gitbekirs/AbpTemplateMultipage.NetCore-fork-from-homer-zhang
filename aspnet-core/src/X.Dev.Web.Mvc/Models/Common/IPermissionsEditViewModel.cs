using System.Collections.Generic;
using X.Dev.Roles.Dto;

namespace X.Dev.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}