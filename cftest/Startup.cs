using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cftest.Startup))]
namespace cftest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
