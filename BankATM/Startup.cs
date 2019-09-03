using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopGearBanking.Startup))]
namespace TopGearBanking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
