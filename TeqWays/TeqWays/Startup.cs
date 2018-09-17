using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeqWays.Startup))]
namespace TeqWays
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
