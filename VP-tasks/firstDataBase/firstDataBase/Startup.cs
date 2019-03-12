using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstDataBase.Startup))]
namespace firstDataBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
