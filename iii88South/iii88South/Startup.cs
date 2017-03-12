using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iii88South.Startup))]
namespace iii88South
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
