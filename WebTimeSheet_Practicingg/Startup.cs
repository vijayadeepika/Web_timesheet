using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTimeSheet_Practicingg.Startup))]
namespace WebTimeSheet_Practicingg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}