using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoiceChef.Startup))]
namespace VoiceChef
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
