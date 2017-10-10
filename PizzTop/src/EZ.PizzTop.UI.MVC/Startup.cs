using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EZ.PizzTop.UI.MVC.Startup))]
namespace EZ.PizzTop.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
