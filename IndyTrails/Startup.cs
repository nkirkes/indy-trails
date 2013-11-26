using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndyTrails.Startup))]
namespace IndyTrails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
