using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyecoFinal.Startup))]
namespace ProyecoFinal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
