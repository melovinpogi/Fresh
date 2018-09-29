using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FreshPros.Commons.Objects.Account
{
    public class Login
    {
        public Login() { }

        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string device { get; set; }
    }
}