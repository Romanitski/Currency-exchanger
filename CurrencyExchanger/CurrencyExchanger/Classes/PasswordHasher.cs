using System;
using System.Security.Cryptography;
using System.Text;

namespace CurrencyExchanger.Classes
{
    class PasswordHasher
    {
        public static string GetHesh(string password)
        {
            var md_five = MD5.Create();
            var hash = md_five.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }
    }
}
