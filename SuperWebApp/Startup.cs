using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperWebApp.Startup))]
namespace SuperWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
