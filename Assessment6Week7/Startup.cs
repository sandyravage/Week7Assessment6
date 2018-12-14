using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assessment6Week7.Startup))]
namespace Assessment6Week7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
