using Abp.AspNetCore.Mvc.ViewComponents;

namespace X.Dev.Web.Views
{
    public abstract class DevViewComponent : AbpViewComponent
    {
        protected DevViewComponent()
        {
            LocalizationSourceName = DevConsts.LocalizationSourceName;
        }
    }
}
