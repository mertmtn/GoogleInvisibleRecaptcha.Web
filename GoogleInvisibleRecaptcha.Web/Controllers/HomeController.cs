using GoogleInvisibleRecaptcha.Web.Models;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Options;
using ReCaptcha.Models;

namespace GoogleInvisibleRecaptcha.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<GoogleInVisibleRecaptcha> _invisibleRecaptchaOptions;

        public HomeController(IOptions<GoogleInVisibleRecaptcha> invisibleRecaptchaOptions)
        {
            _invisibleRecaptchaOptions = invisibleRecaptchaOptions;
        }

        public IActionResult Login()
        {
            ViewBag.SiteKey = _invisibleRecaptchaOptions.Value.SiteKey;
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login loginModel)
        {      
            //Kullanıcı giriş kontrolleri ve validasyon işlemleri yapılabilir.
            return View();
        }
    }
}
