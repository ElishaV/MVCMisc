using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMiscellaneous.Startup))]
namespace MVCMiscellaneous
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
