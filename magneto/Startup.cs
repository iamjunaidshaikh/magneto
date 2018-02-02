using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(magneto.Startup))]
namespace magneto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
