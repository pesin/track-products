using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductsTracker.Web4.Startup))]
namespace ProductsTracker.Web4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
