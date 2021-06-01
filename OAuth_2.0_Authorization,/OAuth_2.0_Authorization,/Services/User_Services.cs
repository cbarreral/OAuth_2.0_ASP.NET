using OAuth_2._0_Authorization_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuth_2._0_Authorization_.Services
{
    public class User_Services
    {
        public User GetUserByCredentials(string email, string password)
        {
            if (email != "cbarreral@gmail.com" || password != "1230")
            {
                return null;
            }
            User user = new User()
            {
                Id = "1",
                Email = "cabrreral@itsoeh.edu.mx",
                Password = "1230",
                Nombre = "Carlos Alberto"
            };
            if (user != null)
            {
                user.Password = string.Empty;
            }
            return user;
        }
    }
}