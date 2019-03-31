using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace X.Dev.Web.Views
{
    public abstract class DevRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DevRazorPage()
        {
            LocalizationSourceName = DevConsts.LocalizationSourceName;
        }
    }
}
