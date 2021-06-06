using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Options;
using ReCaptcha.Business;
using ReCaptcha.Models;

namespace GoogleInvisibleRecaptcha.Web.Controllers
{
    public class RecaptchaController : Controller
    { 
        private readonly IOptions<GoogleInVisibleRecaptcha> _invisibleRecaptchaOptions;

        public RecaptchaController(IOptions<GoogleInVisibleRecaptcha> invisibleRecaptchaOptions)
        {
            _invisibleRecaptchaOptions = invisibleRecaptchaOptions;
        }

        [HttpPost]
        public JsonResult CheckInvisibleCaptchaValid()
        {
            var response = HttpContext.Request.Form["g-recaptcha-response"];
            var secretKey = _invisibleRecaptchaOptions.Value.SecretKey;

            var captchaResponse = ReCaptchaManager.CheckInvisibleCaptchaValid(secretKey, response);
            return Json(captchaResponse);
        }
    }
}
