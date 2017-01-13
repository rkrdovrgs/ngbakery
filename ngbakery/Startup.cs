using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ngbakery.Startup))]
namespace ngbakery
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ngcommerce.Web.Startup.Register(app);
        }
    }
}
