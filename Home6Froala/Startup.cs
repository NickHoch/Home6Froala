using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Home6Froala.Startup))]
namespace Home6Froala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
