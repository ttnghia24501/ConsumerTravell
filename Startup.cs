using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumerTravell.Startup))]
namespace ConsumerTravell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
