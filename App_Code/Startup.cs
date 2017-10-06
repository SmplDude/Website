using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Luke_Gregor.Startup))]
namespace Luke_Gregor
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
