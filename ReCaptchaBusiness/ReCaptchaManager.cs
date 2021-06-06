using Newtonsoft.Json;
using ReCaptcha.Models;

namespace ReCaptcha.Business
{
    public class ReCaptchaManager
    { 
        public static ReCaptchaResponse CheckInvisibleCaptchaValid(string secretKey, string responseFromForm)
        {
            var client = new System.Net.WebClient();           
 
            var reply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, responseFromForm));

            return JsonConvert.DeserializeObject<ReCaptchaResponse>(reply);
        }
    }
}
