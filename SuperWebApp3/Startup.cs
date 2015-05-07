using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperWebApp3.Startup))]
namespace SuperWebApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
