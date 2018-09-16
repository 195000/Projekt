using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Projekt.Startup))]
namespace Projekt
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.MapSignalR();

        }
    }
}