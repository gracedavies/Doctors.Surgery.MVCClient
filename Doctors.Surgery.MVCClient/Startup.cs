using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doctors.Surgery.MVCClient.Startup))]
namespace Doctors.Surgery.MVCClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
