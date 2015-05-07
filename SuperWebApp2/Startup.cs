using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperWebApp2.Startup))]
namespace SuperWebApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
