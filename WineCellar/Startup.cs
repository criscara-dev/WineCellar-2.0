using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WineCellar.Startup))]
namespace WineCellar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
