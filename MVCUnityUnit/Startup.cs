using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCUnityUnit.Startup))]
namespace MVCUnityUnit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
