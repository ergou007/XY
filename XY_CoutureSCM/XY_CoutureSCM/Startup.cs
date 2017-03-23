using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XY_CoutureSCM.Startup))]
namespace XY_CoutureSCM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
