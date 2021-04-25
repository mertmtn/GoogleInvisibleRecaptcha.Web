namespace GoogleInvisibleRecaptcha.Web.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}