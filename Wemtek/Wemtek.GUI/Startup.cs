using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wemtek.GUI.Startup))]
namespace Wemtek.GUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
