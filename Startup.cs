using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ac686115_MIS4200.Startup))]
namespace ac686115_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
