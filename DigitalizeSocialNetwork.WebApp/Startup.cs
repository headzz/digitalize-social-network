using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalizeSocialNetwork.WebApp.Startup))]
namespace DigitalizeSocialNetwork.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
