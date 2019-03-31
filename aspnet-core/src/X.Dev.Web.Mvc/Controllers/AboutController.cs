using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using X.Dev.Controllers;

namespace X.Dev.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : DevControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
