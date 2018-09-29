using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace FreshPros.Commons.Helpers
{
    public class UserHelper
    {
        public static HttpCookie storeCookie(string cookieName, dynamic value, int expDay)
        {
            var _Cookie = new HttpCookie(cookieName, value);
            _Cookie.Expires.AddDays(expDay);
            return _Cookie;
        }

        public static object getCookie(string cookieName)
        {
            var _cookie = HttpContext.Current.Request.Cookies[cookieName];
            if (_cookie != null)
            {
                return _cookie.Value.ToString();
            }
            else
            {
                return null; 
            }
        }

        public static void clearCookies()
        {
            string[] myCookies = HttpContext.Current.Request.Cookies.AllKeys;
            foreach (string cookie in myCookies)
            {
                HttpContext.Current.Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
        }


        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}