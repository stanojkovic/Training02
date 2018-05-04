using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp02.Startup))]
namespace WebApp02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
