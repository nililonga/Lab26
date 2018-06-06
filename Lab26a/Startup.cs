using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab26a.Startup))]
namespace Lab26a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
