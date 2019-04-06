using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookWeb.Startup))]
namespace CookWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
