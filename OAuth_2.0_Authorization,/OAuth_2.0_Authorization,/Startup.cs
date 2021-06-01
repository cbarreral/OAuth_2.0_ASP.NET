using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuth_2._0_Authorization_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}