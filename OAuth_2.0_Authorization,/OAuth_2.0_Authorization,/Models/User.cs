using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuth_2._0_Authorization_.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}