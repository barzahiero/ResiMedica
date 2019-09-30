using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResiMedica.Backend.Startup))]
namespace ResiMedica.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
