using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConquerStock.Startup))]
namespace ConquerStock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
