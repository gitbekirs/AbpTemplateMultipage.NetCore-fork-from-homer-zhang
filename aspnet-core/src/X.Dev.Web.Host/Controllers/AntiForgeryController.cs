using Microsoft.AspNetCore.Antiforgery;
using X.Dev.Controllers;

namespace X.Dev.Web.Host.Controllers
{
    public class AntiForgeryController : DevControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
