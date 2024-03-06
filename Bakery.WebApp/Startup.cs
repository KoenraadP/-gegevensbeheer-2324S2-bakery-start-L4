using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bakery.WebApp.Startup))]
namespace Bakery.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
