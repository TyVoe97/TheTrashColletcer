using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashColletctor.Startup))]
namespace TrashColletctor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
