using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnDCampaignAssistant.Startup))]
namespace DnDCampaignAssistant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
