using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShoppingCartTrial.Startup))]
namespace MyShoppingCartTrial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
