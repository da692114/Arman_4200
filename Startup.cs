using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arman_4200.Startup))]
namespace Arman_4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
