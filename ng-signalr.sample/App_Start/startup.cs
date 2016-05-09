using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ng_signalr.sample.App_Start.Startup))]
namespace ng_signalr.sample.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true
            };

            app.MapSignalR("/signalr", hubConfiguration);
        }
    }
}