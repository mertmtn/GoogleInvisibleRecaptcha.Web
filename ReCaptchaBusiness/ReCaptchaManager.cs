using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ReCaptcha.Models;
using System;

namespace ReCaptcha.Business
{
    public class ReCaptchaManager
    {
        private IConfiguration _configuration;

        public ReCaptchaManager(IConfiguration configuration)
        {
            _configuration = configuration;
        } 
         
        public ReCaptchaResponse CheckInvisibleCaptchaValid(string responseFromForm)
        {
            var client = new System.Net.WebClient();
            var secretKey = _configuration.GetSection("GoogleInVisibleRecptcha").GetSection("SecretKey").Value;
            var reply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, responseFromForm));

            return JsonConvert.DeserializeObject<ReCaptchaResponse>(reply);
        }
    }
}
