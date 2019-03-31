using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace X.Dev.Controllers
{
    public abstract class DevControllerBase: AbpController
    {
        protected DevControllerBase()
        {
            LocalizationSourceName = DevConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
