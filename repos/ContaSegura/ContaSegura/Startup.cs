using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContaSegura.Startup))]
namespace ContaSegura
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
