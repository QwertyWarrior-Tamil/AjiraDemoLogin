using AjiraDemoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjiraDemoLogin
{
    public class ProUserSecure
    {
        public static bool Login(string username, string password)
        {
            using (SampleLogin123Entities entities = new SampleLogin123Entities())
            {
                return entities.ProUsers.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                                          && user.Password == password);
            }
        }
    }
}