using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReCaptcha.Business; 

namespace GoogleInvisibleRecaptcha.Web.Controllers
{
    public class RecaptchaController : Controller
    {
        private IConfiguration _configuration;

        public RecaptchaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public JsonResult CheckInvisibleCaptchaValid()
        {
            var response = HttpContext.Request.Form["g-recaptcha-response"];
            var captchaResponse = new ReCaptchaManager(_configuration).CheckInvisibleCaptchaValid(response);
            return Json(captchaResponse);
        }
    }
}
