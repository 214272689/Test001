using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test001.Startup))]
namespace Test001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);  
        }
    }
}
