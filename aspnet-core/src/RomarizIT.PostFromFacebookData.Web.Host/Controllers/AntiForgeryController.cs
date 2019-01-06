using Microsoft.AspNetCore.Antiforgery;
using RomarizIT.PostFromFacebookData.Controllers;

namespace RomarizIT.PostFromFacebookData.Web.Host.Controllers
{
    public class AntiForgeryController : PostFromFacebookDataControllerBase
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
