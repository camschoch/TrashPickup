using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashPickup.Startup))]
namespace TrashPickup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
