using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(casino_oxana_back.Startup))]
namespace casino_oxana_back
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
