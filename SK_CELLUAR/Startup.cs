using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SK_CELLUAR.Startup))]
namespace SK_CELLUAR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
