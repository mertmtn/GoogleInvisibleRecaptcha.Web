using GoogleInvisibleRecaptcha.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GoogleInvisibleRecaptcha.Web.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Login()
        {
            ViewBag.SiteKey = _configuration.GetSection("GoogleInVisibleRecptcha").GetSection("SiteKey").Value;
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
