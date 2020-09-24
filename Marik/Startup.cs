using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Marik.Startup))]
namespace Marik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
