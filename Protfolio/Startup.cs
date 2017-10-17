using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Protfolio.Startup))]
namespace Protfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
