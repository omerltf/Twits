using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Twits.Startup))]
namespace Twits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
