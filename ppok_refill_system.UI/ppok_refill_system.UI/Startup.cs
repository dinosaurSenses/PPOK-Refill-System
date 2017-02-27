using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ppok_refill_system.UI.Startup))]
namespace ppok_refill_system.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
