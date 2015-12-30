using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week10Lab.Pinterest.Startup))]
namespace Week10Lab.Pinterest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
