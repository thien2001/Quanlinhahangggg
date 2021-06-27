using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quanlinhahangggg.Startup))]
namespace Quanlinhahangggg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
