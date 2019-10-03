using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotorBike_Shop.Startup))]
namespace MotorBike_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
