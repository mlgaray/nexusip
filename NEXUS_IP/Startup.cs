using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NEXUS_IP.Startup))]
namespace NEXUS_IP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
