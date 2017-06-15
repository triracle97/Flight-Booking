using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightBookingWebsite.Startup))]
namespace FlightBookingWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
