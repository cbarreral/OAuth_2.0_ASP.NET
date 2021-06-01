using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using OAuth_2._0_Authorization_.provider;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuth_2._0_Authorization_
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        static Startup()
        {
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new OAuthAppProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(2),
                AllowInsecureHttp = true
            };
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}