using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterfaceGW2Api.Startup))]
namespace InterfaceGW2Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
